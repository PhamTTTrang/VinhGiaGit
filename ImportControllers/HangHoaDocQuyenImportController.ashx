﻿<%@ WebHandler Language="C#" Class="HangHoaDocQuyenImportController" %>

using System;
using System.Web;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary;

public class HangHoaDocQuyenImportController : IHttpHandler
{
    
    public void ProcessRequest (HttpContext context) {
        String filename = context.Request.QueryString["filename"];
        String file = context.Server.MapPath("../FileUpload/" + filename);
		int j = file.LastIndexOf(".");
		if(file.Substring(j) != ".xls") {
			file = ConvertXLSXToXLS.ConvertWorkbookXSSFToHSSF(file);
		}
        Workbook wb = Workbook.Load(file);
        Worksheet ws = wb.Worksheets[0];
        this.NewFromCellCollection(context, ws.Cells);
    }

    public void NewFromCellCollection(HttpContext context, CellCollection cellCollection)
    {
        for (int i = 1; i < cellCollection.Rows.Count; i++)
        //for (int i = 1; i < 100; i++)
        {
            try
            {
                Row row = cellCollection.Rows[i];
                String cellMaHH = row.GetCell(0).Value == null ? String.Empty : row.GetCell(0).Value.ToString();
                String cellMaKH = row.GetCell(1).Value == null ? String.Empty : row.GetCell(1).Value.ToString();
                String cellNgayKetThuc = row.GetCell(2).Value == null ? String.Empty : row.GetCell(2).Value.ToString();
                String cellMoTa = row.GetCell(3).Value == null ? String.Empty : row.GetCell(3).Value.ToString();
                String cellGhiChu = row.GetCell(4).Value == null ? String.Empty : row.GetCell(4).Value.ToString();

                md_sanpham sp = ImportUtils.getSanPham(cellMaHH);
                md_doitackinhdoanh dtkd = ImportUtils.getDoiTac(cellMaKH);
                
                String msg = "";
                msg += String.Format("<div>--- Import Dòng {0} ---</div>", i + 1);

                bool next = true;

                if (sp == null)
                {
                    next = false;
                    msg += String.Format("<div style=\"color:red\">Không tìm thấy sản phẩm {0} </div>", cellMaHH);
                }

                if (dtkd == null)
                {
                    next = false;
                    msg += String.Format("<div style=\"color:red\">Không tìm thấy mã khách hàng {0} </div>", cellMaKH);
                }

                if (next)
                {
                    md_hanghoadocquyen hhdq = ImportUtils.getHangHoaDocQuyen(cellMaHH, cellMaKH);
                    if (hhdq == null)
                    {
                        HangHoaDocQuyenImport import = new HangHoaDocQuyenImport(sp.md_sanpham_id, dtkd.md_doitackinhdoanh_id, cellNgayKetThuc, cellMoTa, cellGhiChu);
                        import.Import();
                        msg += String.Format("<div style=\"color:green\">Đã tạo một hàng hóa độc quyền mới!</div>");
                    }
                    else
                    {
                        HangHoaDocQuyenImport import = new HangHoaDocQuyenImport(sp.md_sanpham_id, dtkd.md_doitackinhdoanh_id, cellNgayKetThuc, cellMoTa, cellGhiChu);
                        import.Update();
                        msg += String.Format("<div style=\"color:green\">Cập nhật hàng hóa độc quyền thành công!</div>");
                    }
                }

                msg += String.Format("<div>--- Kết thúc dòng {0} ---</div>", i + 1);
                context.Response.Write(msg);
            }
            catch (Exception ex)
            {
                context.Response.Write(String.Format("<div style=\"color:red\">Dòng {0} xảy ra lỗi {1}</div>", i + 1, ex.Message));
            }
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}