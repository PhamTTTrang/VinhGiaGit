using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraReports.UI;
using System.IO;
using NPOI.HSSF.UserModel;

public partial class PrintControllers_InBL_Default : System.Web.UI.Page
{
    public LinqDBDataContext db = new LinqDBDataContext();
    public string logo = "", sothapphan = "", inPDF = "";
    public InfoPrint infoPrint = PrintAnco2.GetInfoPrint();
    public HttpContext context = HttpContext.Current;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            var context = HttpContext.Current;
            sothapphan = PrintAnco2.GetDecimal(context.Request.QueryString["stp"], 1);
            string nameTemp = "(CT) BL.xls";
            string nameRpt = "BL";
            
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
        catch (Exception ex)
        {
            Response.Write(ex + "");
        }
    }

    public void viewReport(String SqlQuery)
    {

    }

    public string CreateSql(HttpContext context)
    {
        String c_packinglist_id = context.Request.QueryString["pklId"];
        String md_doitackinhdoanh_id = Request.QueryString["md_doitackinhdoanh_id"];

        String selDH = @"select distinct dh.sochungtu from c_dongpklinv dpkl, c_donhang dh where dpkl.c_donhang_id = dh.c_donhang_id AND dpkl.c_packinginvoice_id = @c_packinginvoice_id";
        DataTable dtDonHang = mdbc.GetData(selDH, "@c_packinginvoice_id", c_packinglist_id);
        String dsDonHang = "";
        foreach (DataRow item in dtDonHang.Rows)
        {
            dsDonHang += String.Format(", {0}", item[0].ToString());
        }

        dsDonHang = dsDonHang.Substring(2);

        String select = string.Format(@"
            select top 1
                *, N'{0}' as dsdonhang, N'{0}' as dsdonhang2 
            from 
                dbo.f_taobanginbl('{1}', '{2}')",
            dsDonHang,
            c_packinglist_id,
            md_doitackinhdoanh_id
            );

        return select;
    }
}