using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SendMail_PaymentRequest : System.Web.UI.Page
{
    public LinqDBDataContext db = new LinqDBDataContext();
    public string logo = "", sothapphan = "", inPDF = "";
    public InfoPrint infoPrint = PrintAnco2.GetInfoPrint();
    public HttpContext context = HttpContext.Current;
    protected void Page_Load(object sender, EventArgs e)
    {
        var context = HttpContext.Current;
        sothapphan = PrintAnco2.GetDecimal(context.Request.QueryString["stp"], 1);
        string nameTemp = "(CT) Payment Request.xls";
        string nameRpt = "Payment Request";
        string sql = CreateSql(context);

        inPDF = "2";
        var task = new System.Threading.Tasks.Task(() =>
        {
            viewReport(sql);
        });

        var compineF = Request.QueryString["compineF"];
        nameRpt = string.IsNullOrWhiteSpace(compineF) ? nameRpt + "-" + DateTime.Now.ToString("ddMMyy") : nameRpt;
        PrintAnco2.exportDataWithType(task, sql, inPDF, nameTemp, nameRpt, ReportViewer1, string.IsNullOrWhiteSpace(compineF), !string.IsNullOrWhiteSpace(compineF));
    }

    public void viewReport(String SqlQuery)
    {

    }

    public string CreateSql(HttpContext context)
    {
        String pklId = context.Request.QueryString["pklId"];

        // Lấy packing list - invoice
        var info = (from pkl in db.c_packinginvoices
                    join cb in db.md_cangbiens on pkl.noidi equals cb.md_cangbien_id
                    where pkl.c_packinginvoice_id.Equals(pklId)
                    select new { pkl, cb }).Single();

        // Lấy số lượng sản phẩm Packing List Invoice
        var totalQuantity = (from p in db.c_dongpklinvs where p.c_packinginvoice_id.Equals(pklId) select p.soluong).Sum();



        // Lấy thông tin khách hàng
        var dtkd = (from pkl in db.c_packinginvoices
                    join dt in db.md_doitackinhdoanhs on pkl.md_doitackinhdoanh_id equals dt.md_doitackinhdoanh_id
                    where pkl.c_packinginvoice_id.Equals(pklId)
                    select dt).Single();

        // Lấy danh sách đơn hàng thuộc invoice đang chọn
        var dsDonHang = from p in db.c_packinginvoices
                        join dp in db.c_dongpklinvs on p.c_packinginvoice_id equals dp.c_packinginvoice_id
                        join dh in db.c_donhangs on dp.c_donhang_id equals dh.c_donhang_id
                        where p.c_packinginvoice_id.Equals(pklId)
                        select new { dh };

        // Lấy danh sách số chứng từ đơn hàng
        var chungTuDonHang = (from dh in dsDonHang select new { dh.dh.sochungtu }).Distinct();

        // Lấy thông tin ngân hàng
        var nganhang = db.md_nganhangs.Single(
                    p => p.md_nganhang_id.Equals(dsDonHang.Take(1).Single().dh.md_nganhang_id)
                );

        //Chuyển danh sách đơn hàng sang chuỗi
        string dhStr = string.Join(", ", chungTuDonHang.Select(s=>s.sochungtu).ToList());

        // Lấy tổng số kiện
        var soKien = (from nxk in db.c_nhapxuats
                      join dnxk in db.c_dongnhapxuats on nxk.c_nhapxuat_id equals dnxk.c_nhapxuat_id
                      where nxk.c_donhang_id.Equals(dsDonHang.Take(1).Single().dh.c_donhang_id)
                      select new { dnxk.sokien_thucte });

        Nullable<decimal> toSoKien = soKien.Sum(p => p.sokien_thucte);

        string sql = string.Format(@"
            select '{0}' as sopo, '{1}' as ngayguimail, '{2}' as tenkh, '{3}' as chungloai, '{4}' as tentau, '{5}' as noidi
            , '{6}' as noiden, '{7}' as shipmenttime, '{8}' as sobil, '{9}' as slinvoice, '{10}' as sokien, '{11}' as tongtieninvoice
            , '{12}' as soinvoice, '{13}' as datcoc, '{14}' as giatriconlai, N'{15}' as nganhang
            , N'/images/more/ckcdct.jpg' as picture_signature
        "
        , dhStr, DateTime.Now.ToString("dd/MMM/yyyy"), dtkd.ten_dtkd.Replace("'", "''"), info.pkl.commodity, info.pkl.mv, info.cb.ten_cangbien.Replace("'", "''")
        , info.pkl.noiden.Replace("'", "''"), info.pkl.etd.Value.ToString("dd/MMM/yyyy"), info.pkl.blno, totalQuantity == null ? "0" : totalQuantity.Value.ToString()
        , toSoKien == null ? "0" : toSoKien.Value.ToString(), info.pkl.totalgross == null ? "0" : info.pkl.totalgross.Value.ToString()
        , info.pkl.so_inv, info.pkl.tiendatcoc == null ? "0" : info.pkl.tiendatcoc.Value.ToString(), info.pkl.tienconlai == null ? "0" : info.pkl.tienconlai.Value.ToString()
        , nganhang.thongtin.Replace("'", "''"));

        //throw new ArgumentNullException(sql);
        return sql;
    }
}