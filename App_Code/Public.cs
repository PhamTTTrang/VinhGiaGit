using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public static class Public
{
    public const string accountSid = "ACb7755e1ca015b01607062a7dd1e95220";
    public const string authToken = "67a2e776a69449ad1b3e2872044653bb";
    public const string fromTwillo = "+12019052566";

    public static string imgNotFound = "images/products/fullsize/default.jpg";
    public static string imgProduct = "images/products/fullsize/";
    public static string imgPattern = "images/products/detai/";
    public static string imgColor = "images/products/mausac/";
    public static string imgProducts = ExcuteSignalRStatic.mapPathSignalR("~/" + imgProduct);
    public static string imgPatterns = ExcuteSignalRStatic.mapPathSignalR("~/" + imgPattern);
    public static string imgColors = ExcuteSignalRStatic.mapPathSignalR("~/" + imgColor);
    public static string NewId()
    {
        return Guid.NewGuid().ToString().Replace("-", "");
    }

    public static c_dongdonhang DiscountHehangValue(string discount_hehang_value, c_dongdonhang ddonhang, LinqDBDataContext db)
    {
        if (!string.IsNullOrEmpty(discount_hehang_value))
        {
            var nnl = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(discount_hehang_value);
            var sp = db.md_sanphams.Where(s => s.md_sanpham_id == ddonhang.md_sanpham_id).FirstOrDefault();
            if (sp != null)
            {
                string code_cl = db.md_chungloais.Where(s => s.md_chungloai_id == sp.md_chungloai_id).Select(s => s.code_cl).FirstOrDefault();
                string gthh = nnl.Where(s => s["hehang"].ToString() == code_cl).Select(s => s["giatri"].ToString()).FirstOrDefault();
                if (!string.IsNullOrEmpty(gthh))
                {
                    var discount_hh = double.Parse(gthh);
                    ddonhang.discount = discount_hh;

                    if (ddonhang.giachuan == null)
                        ddonhang.giachuan = ddonhang.giafob;

                    //var giafob = (double)ddonhang.giachuan.GetValueOrDefault(0) - ((double)ddonhang.giachuan.GetValueOrDefault(0) * discount_hh / 100);
                    //ddonhang.giafob = decimal.Round((decimal)giafob, 2);
                }
            }
        }
        return ddonhang;
    }

    public static bool LaNguoiTao(HttpContext context, string nguoitao, LinqDBDataContext db)
    {
        bool ok = false;
        string manv = context.User.Identity.Name;
        string selAdmin = "select isadmin from nhanvien where manv = @manv";
        //string selAdmin = "select isadmin from nhanvien where manv like '%admin%' ";
        bool isadmin = (bool)mdbc.ExecuteScalar(selAdmin, "@manv", manv);
        if (manv == nguoitao)
            ok = true;
        else if (isadmin == true)
            ok = true;
        else
            ok = false;
        return ok;
    }

    public static string DecodeHTML(string text)
    {
        try { text = text.Replace("0ψ0", "<").Replace("1Ψ1", ">"); }
        catch { }
        return text;
    }

    public static string EncodeHTML(string text)
    {
        try { text = text.Replace("<", "0ψ0").Replace(">", "1Ψ1"); }
        catch { }
        return text;
    }

    public static string taoPhieuXK(HttpContext context, string ids)
    {
        var db = new LinqDBDataContext();
        string msg = "";
        string list_docPO = "";
        // String ids = context.Request.Form["p[arrayPhieuXuat]"];
        // string[] s = ids.Replace(" ", "").Split(',');
        string[] s = ids.Replace(" ", "").Split(',');
        string listPN = "'" + ids.Replace(",", "','").Replace(" ", "") + "'";
        // Kiểm tra các đơn hàng đã kết thúc chưa?
        //String sqlStop = "select count(*) from c_donhang dh where dh.md_trangthai_id ='KETTHUC' AND dh.c_donhang_id IN( select distinct c_donhang_id from c_nhapxuat where c_nhapxuat_id IN( " + listPN + " ) )";
        //int countStop = (int)mdbc.ExecuteScalar(sqlStop);
        int countStop = db.c_donhangs.Where(t =>
            t.md_trangthai_id == "KETTHUC" &
            db.c_nhapxuats.Where(tt =>
                s.Contains(tt.c_nhapxuat_id))
            .Select(tt => tt.c_donhang_id)
            .Distinct()
            .Contains(t.c_donhang_id)
        ).Count();

        int countSoanThao = db.c_nhapxuats.Where(t =>
            t.md_trangthai_id == "SOANTHAO" &
            s.Contains(t.c_nhapxuat_id)).Count();

        if (countStop > 0)
        {
            msg = @"Tạo phiếu xuất thất bại! Vì có đơn hàng đã ""Kết Thúc""!";
        }
        else if (countSoanThao > 0)
        {
            msg = @"Tạo phiếu xuất thất bại! Vì có phiếu nhập kho đang ""Soạn Thảo""!";
        }
        else
        {
            string sql = @"select COUNT( distinct md_doitackinhdoanh_id) from c_donhang where c_donhang_id 
                in(select distinct c_donhang_id from c_nhapxuat where c_nhapxuat_id in (" + listPN + "))";
            int check = (int)mdbc.ExecuteScalar(sql);

            if (check == 1)
            {
                string sql_dt = @"select distinct md_doitackinhdoanh_id from c_donhang where c_donhang_id 
                                in(select distinct c_donhang_id from c_nhapxuat where c_nhapxuat_id in (" + listPN + "))";
                string doitackinhdoanh_id = (string)mdbc.ExecuteScalar(sql_dt);

                string sql_doc_dh = "select sochungtu from c_donhang where c_donhang_id in(select distinct c_donhang_id from c_nhapxuat where c_nhapxuat_id in (" + listPN + "))";
                DataTable tbl_doc_PO = mdbc.GetData(sql_doc_dh);
                foreach (DataRow item in tbl_doc_PO.Rows)
                {
                    list_docPO += item[0].ToString() + ", ";
                }

                c_nhapxuat obj = new c_nhapxuat();
                obj.c_nhapxuat_id = Security.EncodeMd5Hash(DateTime.Now.ToString());
                obj.cr_invoice = false;
                obj.md_doitackinhdoanh_id = doitackinhdoanh_id;
                obj.sophieunx = list_docPO.Substring(0, list_docPO.Length - 2);
                obj.md_kho_id = (string)mdbc.ExecuteScalar("SELECT TOP 1 md_kho_id FROM md_kho");
                obj.md_loaichungtu_id = "XK";
                obj.md_trangthai_id = "SOANTHAO";
                obj.ngay_giaonhan = DateTime.Now;
                obj.ngay_phieu = DateTime.Now;
                obj.hoatdong = true;
                obj.ngaytao = DateTime.Now;
                obj.ngaycapnhat = DateTime.Now;
                obj.nguoitao = UserUtils.getUser(context);
                obj.nguoicapnhat = UserUtils.getUser(context);
                var chungtu = db.md_sochungtus.Single(ct => ct.tiento.Equals("XK"));
                obj.sophieu = chungtu.tiento + "/" + chungtu.so_duocgan + "/" + chungtu.hauto;

                // danh sách bảng tạm dòng xuất
                var listDongXuat = new List<c_dongnhapxuat>();
                int line = 10;

                for (int i = 0; i < s.Length; i++)
                {
                    var dongNhap = from dn in db.c_dongnhapxuats
                                   where dn.c_nhapxuat_id.Equals(s[i])
                                   select new
                                   {
                                       dn.c_dongdonhang_id,
                                       dn.c_dongnhapxuat_id,
                                       dn.c_dongdsdh_id,
                                       dn.md_donvitinh_id,
                                       dn.md_sanpham_id,
                                       dn.mota,
                                       dn.mota_tiengviet,
                                       dn.slthuc_nhapxuat,
                                       dn.slphai_nhapxuat,
                                       dn.sl_dathang
                                   };

                    foreach (var item in dongNhap)
                    {
                        var dongXuat = new c_dongnhapxuat();
                        var dongDH = db.c_dongdonhangs.Single(ddh => ddh.c_dongdonhang_id.Equals(item.c_dongdonhang_id));
                        var dh = db.c_donhangs.Where(t => t.c_donhang_id == dongDH.c_donhang_id).FirstOrDefault();

                        dongXuat.c_dongnhapxuat_id = Security.EncodeMd5Hash(DateTime.Now.ToString() + item.c_dongnhapxuat_id);
                        dongXuat.c_nhapxuat_id = obj.c_nhapxuat_id;
                        dongXuat.c_dongdonhang_id = dongDH.c_dongdonhang_id;
                        dongXuat.dongnhapxuat_ref = item.c_dongnhapxuat_id;
                        dongXuat.dongia = UserUtils.getGiaHopDongPO(dh, dongDH);
                        dongXuat.c_dongdsdh_id = item.c_dongdsdh_id;
                        dongXuat.hoatdong = true;
                        dongXuat.md_donvitinh_id = item.md_donvitinh_id;
                        dongXuat.md_sanpham_id = item.md_sanpham_id;
                        dongXuat.mota = item.mota;
                        dongXuat.mota_tiengviet = item.mota_tiengviet;
                        dongXuat.slthuc_nhapxuat = item.slthuc_nhapxuat;
                        dongXuat.slphai_nhapxuat = item.slthuc_nhapxuat;
                        dongXuat.sl_dathang = item.sl_dathang;
                        dongXuat.line = line;
                        dongXuat.ngaytao = DateTime.Now;
                        dongXuat.nguoitao = UserUtils.getUser(context);
                        dongXuat.ngaycapnhat = DateTime.Now;
                        dongXuat.nguoicapnhat = UserUtils.getUser(context);

                        listDongXuat.Add(dongXuat);
                        line += 10;
                    }
                }



                // Thêm  nhập xuất
                db.c_nhapxuats.InsertOnSubmit(obj);
                db.SubmitChanges();

                // Thêm dòng nhập xuất từ danh sách tạm
                //db.c_dongnhapxuats.InsertAllOnSubmit(listAddDongXuat);
                for (int i = 0; i < listDongXuat.Count; i++)
                {
                    int count__ = (
                                   from ll in db.c_dongnhapxuats
                                   where ll.md_sanpham_id.Equals(listDongXuat[i].md_sanpham_id)
                                   && ll.c_nhapxuat_id.Equals(listDongXuat[i].c_nhapxuat_id)
                                   && ll.dongia.Equals(listDongXuat[i].dongia)
                                   && ll.c_dongdonhang_id.Equals(listDongXuat[i].c_dongdonhang_id)
                                   && ll.c_dongnhapxuat_id.Equals(listDongXuat[i].c_dongnhapxuat_id)
                                   select new { ll.c_dongnhapxuat_id }
                                   ).Count();
                    if (count__ == 0)
                    {
                        db.c_dongnhapxuats.InsertOnSubmit(listDongXuat[i]);
                        db.SubmitChanges();
                    }
                    else
                    {
                        c_dongnhapxuat dnx = db.c_dongnhapxuats.FirstOrDefault(
                                    p => p.md_sanpham_id.Equals(listDongXuat[i].md_sanpham_id)
                                    && p.c_nhapxuat_id.Equals(listDongXuat[i].c_nhapxuat_id)
                                    && p.dongia.Equals(listDongXuat[i].dongia)
                                    && p.c_dongdonhang_id.Equals(listDongXuat[i].c_dongdonhang_id)
                                    && p.c_dongnhapxuat_id.Equals(listDongXuat[i].c_dongnhapxuat_id)
                                );
                        dnx.slthuc_nhapxuat += listDongXuat[i].slthuc_nhapxuat;
                        dnx.slphai_nhapxuat += listDongXuat[i].slphai_nhapxuat;
                        db.SubmitChanges();
                    }
                }



                //string getsct = db.c_nhapxuats.Single(xk=>xk.c_nhapxuat_id.Equals(obj.c_nhapxuat_id)).sophieu;
                msg = "Tạo phiếu xuất thành công! Số PX: " + obj.sophieu;
            }
            else
            {
                msg = "Không thể tạo phiếu xuất từ các phiếu nhập không cùng 1 khách hàng!";
            }
        }
        return msg;
    }

    public static string getPhieuC(LinqDBDataContext db)
    {
        string sphieu_id = "6075512b0ec3145bc86241ab1d7f510b", sphieu = "", tiento = "T"; // table hotro
        hotro ht = null;
        ht = db.hotros.Where(s => s.c_chitietthuchi_id == sphieu_id).FirstOrDefault();
        md_sochungtu sochungtu = db.md_sochungtus.Single(s => s.tiento == tiento);
        if (ht != null)
        {
            if (ht.ngaymoinhat.Value.Year == DateTime.Now.Year)
            {
                if (ht.ngaymoinhat.Value.Month != DateTime.Now.Month)
                {
                    sochungtu.so_duocgan = 1;
                }
                sphieu = sochungtu.so_duocgan + sochungtu.tiento + "/" + sochungtu.hauto;
                sochungtu.so_duocgan = sochungtu.so_duocgan + sochungtu.buocnhay;
            }
            else
            {
                sphieu = sochungtu.so_duocgan + sochungtu.tiento + "/" + sochungtu.hauto;
                sochungtu.so_duocgan = sochungtu.so_duocgan + sochungtu.buocnhay;
            }
        }
        else
        {
            sphieu = sochungtu.so_duocgan + sochungtu.tiento + "/" + sochungtu.hauto;
            sochungtu.so_duocgan = sochungtu.so_duocgan + sochungtu.buocnhay;
        }

        return sphieu;
    }

    public static Dictionary<string, object> convertCmToInch(string mota, List<string> masterSize, string tenKT)
    {
        if (tenKT == "inch")
        {
            var tyle = 0.3937;
            var posSize = mota.LastIndexOf("- Size ");
            string motaKT = mota.Substring(posSize + 6).Trim();
            motaKT = motaKT.Remove(motaKT.Length - 5);
            var lstSize = motaKT.Split(new string[] { "H/" }, StringSplitOptions.None).ToList();

            string motaInch = mota.Substring(0, posSize + 7);
            for (var i = 0; i < lstSize.Count; i++)
            {
                var row = lstSize[i];
                var arr = row.Split('x');
                for (var iR = 0; iR < arr.Length; iR++)
                {
                    try
                    {
                        var iRinch = double.Parse(arr[iR]) * tyle;
                        motaInch += iRinch.ToString("#.0") + "x";
                    }
                    catch
                    {
                        throw new ArgumentNullException("Err: " + arr[iR]);
                    }
                }
                motaInch = motaInch.Remove(motaInch.Length - 1) + "H/ ";
            }

            masterSize[0] = (double.Parse(masterSize[0]) * tyle).ToString("#.00");
            masterSize[1] = (double.Parse(masterSize[1]) * tyle).ToString("#.00");
            masterSize[2] = (double.Parse(masterSize[2]) * tyle).ToString("#.00");

            motaInch = motaInch.Remove(motaInch.Length - 2);
            mota = string.Format(@"{0}({1})", motaInch, tenKT);
        }

        return new Dictionary<string, object>
        {
            { "mota", mota },
            { "masterSize", masterSize }
        };
    }

    public static Dictionary<string, object> convertKgToPound(string weight, string NWmaster, string GWmaster, string tenTL)
    {
        if (tenTL == "pound")
        {
            var tyle = 0.4535;
            weight = (double.Parse(weight) / tyle).ToString("#.00");
            NWmaster = (double.Parse(NWmaster) / tyle).ToString("#.00");
            GWmaster = (double.Parse(GWmaster) / tyle).ToString("#.00");
        }

        return new Dictionary<string, object>
        {
            { "weight", weight },
            { "NWmaster", NWmaster },
            { "GWmaster", GWmaster }
        };
    }
}
