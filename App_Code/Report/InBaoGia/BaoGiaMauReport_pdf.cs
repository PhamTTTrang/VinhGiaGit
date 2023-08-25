﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.SS.Util;

/// <summary>
/// Summary description for BaoGiaMauReport_pdf
/// </summary>
public class BaoGiaMauReport_pdf
{
    private String c_baogia_id, logoPath, productImagePath;

    public String LogoPath
    {
        get { return logoPath; }
        set { logoPath = value; }
    }

    public String ProductImagePath
    {
        get { return productImagePath; }
        set { productImagePath = value; }
    }
	
	private LinqDBDataContext db = new LinqDBDataContext();
    public HSSFWorkbook CreateWBQuotation()
    {
        //try
        //{
			string orderby = UserUtils.get_sapxep_qodetail(null, c_baogia_id, "B.ma_sanpham", "order by B.ma_sanpham asc", db);
            String selectDetails = String.Format(@"
				SELECT *, CASE WHEN  B.sl_inner = '0 0' and B.master like N'%ctn%'
						THEN round(B.n_w_outer + ((B.l2 + B.w2) * (B.w2 + B.h2))/5400,2)

						WHEN B.sl_inner like N'%ctn%' and B.master like N'%ctn%'
						THEN round((B.g_w_inner * (B.sl_outer/ B.inner_)) +  (((B.l2 + B.w2) * (B.w2 + B.h2))/5400),2)

						WHEN B.sl_inner like N'%ctn%' and B.master like N'%pal%'
						THEN round(B.g_w_inner * (B.sl_outer/ B.inner_) + 20,2)

						WHEN B.sl_inner like N'%ctn%' and B.master like N'%crt%'
						THEN round(B.g_w_inner * (B.sl_outer/ B.inner_) + 5,2)

						WHEN B.sl_inner like N'%bun%' and B.master like N'%crt%'
						THEN round(B.g_w_inner * (B.sl_outer/ B.inner_) + 5,2)

						WHEN B.sl_inner like N'%bun%' and B.master like N'%pal%'
						THEN round(B.g_w_inner * (B.sl_outer/ B.inner_) + 20,2)

						WHEN B.sl_inner = '0 0' and B.master like N'%pal%'
						THEN round(B.n_w_outer + 25,2)

						WHEN B.sl_inner = '0 0' and B.master like N'%bun%'
						THEN round(B.n_w_outer + 0.5,2)
						
						WHEN B.sl_inner = '0 0' and B.master like N'%crt%'
						THEN round(B.n_w_outer + 5,2)

						ELSE 0 END as g_w_outer
				FROM(
				SELECT *,CASE WHEN  A.sl_inner like N'%ctn%'  
						THEN round(A.n_w_inner + ((A.l1+A.w1)*(A.w1+A.h1)/5400),2)
						WHEN A.sl_inner like N'%bun%'  
						THEN round(A.n_w_inner + 0.5,2)
						WHEN A.sl_inner like N'%crt%'  
						THEN round(A.n_w_inner + 3,2)
						ELSE 0 END as g_w_inner
				FROM(
				select 
	            dtkd.ten_dtkd, dtkd.diachi, dtkd.tel, dtkd.fax, bg.ngaybaogia
	            , sp.ma_sanpham as msp, (case when  SUBSTRING(sp.ma_sanpham,10,1) != 'F' then SUBSTRING(sp.ma_sanpham,0,9) else SUBSTRING(sp.ma_sanpham,0,12) end) as pic, sp.ma_sanpham, ctbg.ma_sanpham_khach
	            , (CASE 
						WHEN kt.ten_kichthuoc = 'inch' then dbo.f_taomotainchQoPo(sp.md_sanpham_id) 
						ELSE ctbg.mota_tienganh
					END) as mota_tienganh
				,  (select dbo.f_convertKgToPounds(sp.trongluong, bg.md_trongluong_id)) as trongluong
                ,  tl.ten_trongluong, dg.sl_inner as inner_, dg.sl_outer
                , (CAST(dg.sl_inner as nvarchar) + ' ' + (select ten_dvt from md_donvitinh dvt where dvt.md_donvitinh_id = dg.dvt_inner)) as sl_inner
	            , (CAST(dg.sl_outer as nvarchar) + ' ' + (select ten_dvt from md_donvitinh dvt where dvt.md_donvitinh_id = dg.dvt_outer)) as master
                , dg.ten_donggoi, ctbg.l1, ctbg.w1, ctbg.h1, ctbg.l2, ctbg.w2, ctbg.h2, ctbg.v2, round(ctbg.v2 * 35.31466672, 2)  as cbf
	            , dg.soluonggoi_ctn as nopack, dg.soluonggoi_ctn_20 as nopack_20, dg.soluonggoi_ctn_40hc as nopack_40hc, ctbg.giafob
	            , sp.l_cm, sp.w_cm, sp.h_cm
	            , bg.shipmenttime, bg.shipmenttime + 15 as shipmenttime2, cb.ten_cangbien
	            , bg.ngayhethan, kt.ten_kichthuoc, bg.moq_item_color, hscode.hscode
				, dg.sl_inner * (SELECT dbo.f_convertKgToPounds(sp.trongluong, bg.md_trongluong_id))  as n_w_inner
				, dg.sl_outer * (SELECT dbo.f_convertKgToPounds(sp.trongluong, bg.md_trongluong_id)) as n_w_outer
            from 
	            c_baogia bg
				left join c_chitietbaogia ctbg ON bg.c_baogia_id = ctbg.c_baogia_id
	            left join md_doitackinhdoanh dtkd ON bg.md_doitackinhdoanh_id = dtkd.md_doitackinhdoanh_id
				left join md_sanpham sp ON ctbg.md_sanpham_id = sp.md_sanpham_id
				left join md_hscode hscode ON sp.md_hscode_id = hscode.md_hscode_id
	            left join md_donggoi dg ON ctbg.md_donggoi_id = dg.md_donggoi_id
	            left join md_cangbien cb ON sp.md_cangbien_id = cb.md_cangbien_id
                left join md_kichthuoc kt ON bg.md_kichthuoc_id = kt.md_kichthuoc_id
                left join md_trongluong tl ON bg.md_trongluong_id = tl.md_trongluong_id
            where bg.c_baogia_id = N'{0}')A)B {1}", c_baogia_id == null ? "" : c_baogia_id, orderby);


            String selectRefereces = String.Format(@"SELECT 
	                                                  (select SUBSTRING(filter, 1, 2) + '-' + ta_ngan as ta_ngan from md_chungloai cl where cl.code_cl = SUBSTRING(filter, 1, 2)) as ta_ngan, SUBSTRING(filter, 1, 2) as chungloai, SUBSTRING(filter, 4, 2) as codemau, mau , url
                                                   FROM 
	                                                   c_baogia bg
														left join md_color_reference color on bg.c_baogia_id = color.c_baogia_id
                                                   WHERE
                                                       color.hoatdong = 1
                                                       AND bg.c_baogia_id = N'{0}'", c_baogia_id == null ? "" : c_baogia_id);

            String selectDistinct = String.Format(@"SELECT distinct chungloai
                                                    FROM(
                                                        SELECT 
	                                                        (select ta_ngan from md_chungloai cl where cl.code_cl = SUBSTRING(filter, 1, 2)) as ta_ngan, SUBSTRING(filter, 1, 2) as chungloai, SUBSTRING(filter, 4, 2) as codemau, mau , url
                                                        FROM 
	                                                        c_baogia bg
															left join md_color_reference color on bg.c_baogia_id = color.c_baogia_id
                                                        WHERE
														color.hoatdong = 1
														and bg.c_baogia_id = N'{0}'
                                                    ) as tmp", c_baogia_id == null ? "" : c_baogia_id);

            DataTable dtDetails = mdbc.GetData(selectDetails);
            DataTable dtDistinct = mdbc.GetData(selectDistinct);
            DataTable dtReferences = mdbc.GetData(selectRefereces);
            if (dtDetails.Rows.Count != 0)
            {
                HSSFWorkbook hssfworkbook = this.CreateHSSFWorkbook(dtDetails, dtDistinct, dtReferences);
                return hssfworkbook;
            }
            else
            {
                throw new Exception("Báo giá không có dữ liệu!");
            }
        //}
        //catch (Exception ex)
        //{
        //    throw ex;
        //}
    }

     private HSSFWorkbook CreateHSSFWorkbook(DataTable dtDetails, DataTable dtDistinct, DataTable dtReferences)
    {
        string tenkt = dtDetails.Rows[0]["ten_kichthuoc"].ToString().ToLower();
        string tentl = dtDetails.Rows[0]["ten_trongluong"].ToString().ToLower();
        HSSFWorkbook hssfworkbook = new HSSFWorkbook();
        ISheet s1 = hssfworkbook.CreateSheet("Sheet1");
        System.Drawing.Image logo = System.Drawing.Image.FromFile(logoPath);
        MemoryStream mslogo = new MemoryStream();
        logo.Save(mslogo, System.Drawing.Imaging.ImageFormat.Jpeg);

        IDrawing patriarchlogo = s1.CreateDrawingPatriarch();
        HSSFClientAnchor anchorlogo = new HSSFClientAnchor(0, 0, 0, 0, 1, 0, 2, 3);
        //anchorlogo.AnchorType = 3;

        int indexlogo = hssfworkbook.AddPicture(mslogo.ToArray(), PictureType.JPEG);
        IPicture signaturePicturelogo = patriarchlogo.CreatePicture(anchorlogo, indexlogo);

        // set A1
        s1.CreateRow(0).CreateCell(0).SetCellValue("VINH GIA COMPANY LIMITED");

        // set A2
        s1.CreateRow(1).CreateCell(0).SetCellValue("Northern Chu Lai Industrial Zone, Tam Hiep Commune, Nui Thanh District, Quang Nam Province, Viet Nam");

        // set A3
        s1.CreateRow(2).CreateCell(0).SetCellValue("Tel: (84-235) 3567393   Fax: (84-235) 3567494");

        // set A4
        s1.CreateRow(3).CreateCell(0).SetCellValue("QUOTATION");
		
		IFont fontBold = hssfworkbook.CreateFont();
        fontBold.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
        
        ICellStyle cellBold = hssfworkbook.CreateCellStyle();
        cellBold.SetFont(fontBold);
		
		ICellStyle cellBoldCenter = hssfworkbook.CreateCellStyle();
        cellBoldCenter.Alignment = HorizontalAlignment.Center;
        cellBoldCenter.VerticalAlignment = VerticalAlignment.Top;
        cellBoldCenter.SetFont(fontBold);

        // Style of Company Name
        ICellStyle cellStyleCompany = hssfworkbook.CreateCellStyle();
        cellStyleCompany.Alignment = HorizontalAlignment.Center;
        cellStyleCompany.SetFont(NPOIUtils.CreateFontSize(hssfworkbook, 15));

        // Style of Company Information 
        ICellStyle cellStyleInfomation = hssfworkbook.CreateCellStyle();
        cellStyleInfomation.Alignment = HorizontalAlignment.Center;
        cellStyleInfomation.SetFont(NPOIUtils.CreateFontSize(hssfworkbook, 12));

        // Style of Title
        ICellStyle cellStyleTitle = hssfworkbook.CreateCellStyle();
        cellStyleTitle.Alignment = HorizontalAlignment.Center;
        cellStyleTitle.SetFont(NPOIUtils.CreateFontSize(hssfworkbook, 18));

        // Style of Company Information Underline
        ICellStyle cellStyleInfomationUnderline = hssfworkbook.CreateCellStyle();
        cellStyleInfomationUnderline.Alignment = HorizontalAlignment.Center;
        cellStyleInfomationUnderline.SetFont(NPOIUtils.CreateFontSize(hssfworkbook, 12, true));



        s1.GetRow(0).GetCell(0).CellStyle = cellStyleCompany;
        s1.GetRow(1).GetCell(0).CellStyle = cellStyleInfomation;
        s1.GetRow(2).GetCell(0).CellStyle = cellStyleInfomationUnderline;
        s1.GetRow(3).GetCell(0).CellStyle = cellStyleTitle;

        s1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 15));
        s1.AddMergedRegion(new CellRangeAddress(1, 1, 0, 15));
        s1.AddMergedRegion(new CellRangeAddress(2, 2, 0, 15));
        s1.AddMergedRegion(new CellRangeAddress(3, 3, 0, 15));

        s1.CreateRow(4).CreateCell(0).SetCellValue("CUSTOMER NAME:");
		s1.GetRow(4).GetCell(0).CellStyle = cellBold;
		
        s1.GetRow(4).CreateCell(3).SetCellValue(dtDetails.Rows[0]["ten_dtkd"].ToString());
		s1.GetRow(4).GetCell(3).CellStyle = cellBold;


        s1.CreateRow(5).CreateCell(0).SetCellValue("ADDRESS:");
		s1.GetRow(5).GetCell(0).CellStyle = cellBold;
		
        s1.GetRow(5).CreateCell(3).SetCellValue(dtDetails.Rows[0]["diachi"].ToString() + " Tel:" + dtDetails.Rows[0]["tel"].ToString() + " Fax:" + dtDetails.Rows[0]["fax"].ToString());
		s1.GetRow(5).GetCell(3).CellStyle = cellBold;

        s1.GetRow(5).CreateCell(13).SetCellValue("Date:");
		s1.GetRow(5).GetCell(13).CellStyle = cellBold;
		
        s1.GetRow(5).CreateCell(14).SetCellValue(DateTime.Parse(dtDetails.Rows[0]["ngaybaogia"].ToString()).ToString("dd/MMM/yyyy"));
		s1.GetRow(5).GetCell(14).CellStyle = cellBold;

        IRow headerColumn = s1.CreateRow(6);
        IRow headerColumn2 = s1.CreateRow(7);

        headerColumn.HeightInPoints = 40;
        headerColumn2.HeightInPoints = 40;
        ICellStyle hStyle = hssfworkbook.CreateCellStyle();
        hStyle.WrapText = true;
		hStyle.SetFont(fontBold);
        hStyle.Alignment = HorizontalAlignment.Center;
		hStyle.VerticalAlignment = VerticalAlignment.Top;
        hStyle.BorderBottom = hStyle.BorderLeft
            = hStyle.BorderRight
            = hStyle.BorderTop
            = NPOI.SS.UserModel.BorderStyle.Thin;

        for (int i = 0; i <= 23; i++)
        {
            headerColumn.CreateCell(i).CellStyle = hStyle;
            headerColumn2.CreateCell(i).CellStyle = hStyle;
        }

        headerColumn.GetCell(0).SetCellValue("Item No");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 0, 0));

        headerColumn.GetCell(1).SetCellValue("Picture - Only for shape ref.");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 1, 1));

        headerColumn.GetCell(2).SetCellValue("Customer's Code");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 2, 2));

        headerColumn.GetCell(3).SetCellValue("Description");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 3, 3));

        headerColumn.GetCell(4).SetCellValue("Weight(" + tentl + ")");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 4, 4));

        headerColumn.GetCell(5).SetCellValue("Packing");
        s1.AddMergedRegion(new CellRangeAddress(6, 6, 5, 6));

        headerColumn2.GetCell(5).SetCellValue("Inner");
        headerColumn2.GetCell(6).SetCellValue("Master");

        headerColumn.GetCell(7).SetCellValue("Inner Packing size ("+tenkt+")");
        s1.AddMergedRegion(new CellRangeAddress(6, 6, 7, 9));
        headerColumn2.GetCell(7).SetCellValue("L");
        headerColumn2.GetCell(8).SetCellValue("W");
        headerColumn2.GetCell(9).SetCellValue("H");


        headerColumn.GetCell(10).SetCellValue("Master Packing size ("+tenkt+")");
        s1.AddMergedRegion(new CellRangeAddress(6, 6, 10, 12));

        headerColumn2.GetCell(10).SetCellValue("L");
        headerColumn2.GetCell(11).SetCellValue("W");
        headerColumn2.GetCell(12).SetCellValue("H");


        headerColumn.GetCell(13).SetCellValue(String.Format("PACK {0}",tenkt.Equals("cm") ? "CBM" : "CBF"));
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 13, 13));

        headerColumn.GetCell(14).SetCellValue("No. of master packages");
        s1.AddMergedRegion(new CellRangeAddress(6, 6, 14, 16));
		
		headerColumn2.GetCell(14).SetCellValue("per 20'");
        headerColumn2.GetCell(15).SetCellValue("per 40'");
        headerColumn2.GetCell(16).SetCellValue("per 40'HC");
		
		headerColumn.GetCell(17).SetCellValue("N.W/inner ("+tentl+")");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 17, 17));
		
		headerColumn.GetCell(18).SetCellValue("G.W/inner ("+tentl+")");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 18, 18));
		
		headerColumn.GetCell(19).SetCellValue("N.W/master ("+tentl+")");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 19, 19));
		
		headerColumn.GetCell(20).SetCellValue("G.W/master ("+tentl+")");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 20, 20));

        headerColumn.GetCell(21).SetCellValue("FOB PRICE (USD)");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 21, 21));

        headerColumn.GetCell(22).SetCellValue("port of loading");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 22, 22));
		
		headerColumn.GetCell(23).SetCellValue("HS Code");
        s1.AddMergedRegion(new CellRangeAddress(6, 7, 23, 23));

        /*headerColumn.GetCell(24).SetCellValue(String.Format("Size Product ({0})", tenkt.Equals("cm") ? "cm" : "inch"));
        s1.AddMergedRegion(new CellRangeAddress(6, 6, 24, 26));

        headerColumn2.GetCell(24).SetCellValue("L");
        headerColumn2.GetCell(25).SetCellValue("W");
        headerColumn2.GetCell(26).SetCellValue("H");*/

        ICellStyle cellStyleRight = hssfworkbook.CreateCellStyle();
        cellStyleRight.Alignment = HorizontalAlignment.Right;
        cellStyleRight.VerticalAlignment = VerticalAlignment.Top;
        cellStyleRight.BorderBottom = cellStyleRight.BorderLeft
            = cellStyleRight.BorderRight
            = cellStyleRight.BorderTop
            = NPOI.SS.UserModel.BorderStyle.Thin;
        cellStyleRight.WrapText = true;

        ICellStyle border = hssfworkbook.CreateCellStyle();
        border.BorderBottom = border.BorderLeft
            = border.BorderRight
            = border.BorderTop
            = NPOI.SS.UserModel.BorderStyle.Thin;
        border.WrapText = true;
        border.VerticalAlignment = VerticalAlignment.Top;

        s1.SetColumnWidth(0, 5000);
        s1.SetColumnWidth(1, 4000);
        s1.SetColumnWidth(3, 9000);
		s1.SetColumnWidth(4, 3000);

		s1.SetColumnWidth(17, 3000);
        s1.SetColumnWidth(18, 3000);
        s1.SetColumnWidth(19, 3000);
        s1.SetColumnWidth(20, 3000);
        s1.SetColumnWidth(21, 4000);

        if (tenkt.Equals("cm"))
        {
            //s1.SetColumnWidth(17, 0);
        }
        
		
		//SO
		ICellStyle cellNumBorder = hssfworkbook.CreateCellStyle();
        cellNumBorder.Alignment = HorizontalAlignment.Right;
        cellNumBorder.VerticalAlignment = VerticalAlignment.Top;
        cellNumBorder.DataFormat = HSSFUtils.CellDataFormat.GetDataFormat(hssfworkbook, "#,##0.00");
        cellNumBorder.BorderBottom = cellNumBorder.BorderRight = cellNumBorder.BorderLeft = cellNumBorder.BorderTop = BorderStyle.Thin;

		ICellStyle cellNumBorderCBM = hssfworkbook.CreateCellStyle();
        cellNumBorderCBM.Alignment = HorizontalAlignment.Right;
        cellNumBorderCBM.VerticalAlignment = VerticalAlignment.Top;
        cellNumBorderCBM.DataFormat = HSSFUtils.CellDataFormat.GetDataFormat(hssfworkbook, "#,##0.000");
        cellNumBorderCBM.BorderBottom = cellNumBorderCBM.BorderRight = cellNumBorderCBM.BorderLeft = cellNumBorderCBM.BorderTop = BorderStyle.Thin;
		
		ICellStyle cellNumBorderKT = hssfworkbook.CreateCellStyle();
        cellNumBorderKT.Alignment = HorizontalAlignment.Right;
        cellNumBorderKT.VerticalAlignment = VerticalAlignment.Top;
        cellNumBorderKT.DataFormat = HSSFUtils.CellDataFormat.GetDataFormat(hssfworkbook, "#,##0.0");
        cellNumBorderKT.BorderBottom = cellNumBorderKT.BorderRight = cellNumBorderKT.BorderLeft = cellNumBorderKT.BorderTop = BorderStyle.Thin;
		//SO
		
        int detailsCount = dtDetails.Rows.Count;
        for (int i = 0; i < detailsCount; i++)
        {
            try
            {
                String imgPath = System.IO.Path.Combine(productImagePath, dtDetails.Rows[i]["pic"].ToString() + ".jpg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(imgPath);
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                IDrawing patriarch = s1.CreateDrawingPatriarch();
                HSSFClientAnchor anchor = new HSSFClientAnchor(0, 0, 0, 0, 1, 8 + i, 2, 9 + i);
                //anchor.AnchorType = 2;

                int index = hssfworkbook.AddPicture(ms.ToArray(), PictureType.JPEG);
                IPicture signaturePicture = patriarch.CreatePicture(anchor, index);
            }
            catch
            { }

            s1.CreateRow(8 + i).CreateCell(0).SetCellValue(dtDetails.Rows[i]["ma_sanpham"].ToString());
            s1.GetRow(8 + i).HeightInPoints = 50;
            s1.GetRow(8 + i).CreateCell(1).SetCellValue("");
            s1.GetRow(8 + i).CreateCell(2).SetCellValue(dtDetails.Rows[i]["ma_sanpham_khach"].ToString());
            s1.GetRow(8 + i).CreateCell(3).SetCellValue(dtDetails.Rows[i]["mota_tienganh"].ToString());
            s1.GetRow(8 + i).CreateCell(4).SetCellValue(double.Parse(dtDetails.Rows[i]["trongluong"].ToString()));
            s1.GetRow(8 + i).GetCell(4).SetCellType(CellType.Numeric);

            s1.GetRow(8 + i).CreateCell(5).SetCellValue(dtDetails.Rows[i]["sl_inner"].ToString());
            s1.GetRow(8 + i).CreateCell(6).SetCellValue(dtDetails.Rows[i]["master"].ToString());
			
            s1.GetRow(8 + i).CreateCell(7).SetCellValue(double.Parse((tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["l1"].ToString()) : double.Parse(dtDetails.Rows[i]["l1"].ToString()) / (double)2.54).ToString("#.0")));
            s1.GetRow(8 + i).GetCell(7).SetCellType(CellType.Numeric);

            s1.GetRow(8 + i).CreateCell(8).SetCellValue(double.Parse((tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["w1"].ToString()) : double.Parse(dtDetails.Rows[i]["w1"].ToString()) / (double)2.54).ToString("#.0")));
            s1.GetRow(8 + i).GetCell(8).SetCellType(CellType.Numeric);

            s1.GetRow(8 + i).CreateCell(9).SetCellValue(double.Parse((tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["h1"].ToString()) : double.Parse(dtDetails.Rows[i]["h1"].ToString()) / (double)2.54).ToString("#.0")));
            s1.GetRow(8 + i).GetCell(9).SetCellType(CellType.Numeric);
            
            s1.GetRow(8 + i).CreateCell(10).SetCellValue(double.Parse((tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["l2"].ToString()) : double.Parse(dtDetails.Rows[i]["l2"].ToString()) / (double)2.54).ToString("#.0")));
            s1.GetRow(8 + i).GetCell(10).SetCellType(CellType.Numeric);
            
            s1.GetRow(8 + i).CreateCell(11).SetCellValue(double.Parse((tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["w2"].ToString()) : double.Parse(dtDetails.Rows[i]["w2"].ToString()) / (double)2.54).ToString("#.0")));
            s1.GetRow(8 + i).GetCell(11).SetCellType(CellType.Numeric);
            
            s1.GetRow(8 + i).CreateCell(12).SetCellValue(double.Parse((tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["h2"].ToString()) : double.Parse(dtDetails.Rows[i]["h2"].ToString()) / (double)2.54).ToString("#.0")));
			s1.GetRow(8 + i).GetCell(12).SetCellType(CellType.Numeric);

            s1.GetRow(8 + i).CreateCell(13).SetCellValue(tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["v2"].ToString()) : double.Parse(dtDetails.Rows[i]["cbf"].ToString()));
            s1.GetRow(8 + i).GetCell(13).SetCellType(CellType.Numeric);
			
			double nopack_20 = 0;
			try { nopack_20 = double.Parse(dtDetails.Rows[i]["nopack_20"].ToString()); } catch { }
			s1.GetRow(8 + i).CreateCell(14).SetCellValue(nopack_20);
            s1.GetRow(8 + i).GetCell(14).SetCellType(CellType.Numeric);
			
            s1.GetRow(8 + i).CreateCell(15).SetCellValue(double.Parse(dtDetails.Rows[i]["nopack"].ToString()));
            s1.GetRow(8 + i).GetCell(15).SetCellType(CellType.Numeric);
			
			double nopack_40hc = 0;
			try { nopack_40hc = double.Parse(dtDetails.Rows[i]["nopack_40hc"].ToString()); } catch { }
            s1.GetRow(8 + i).CreateCell(16).SetCellValue(nopack_40hc);
            s1.GetRow(8 + i).GetCell(16).SetCellType(CellType.Numeric);
			
			s1.GetRow(8 + i).CreateCell(17).SetCellValue(double.Parse(dtDetails.Rows[i]["n_w_inner"].ToString()));
            s1.GetRow(8 + i).GetCell(17).SetCellType(CellType.Numeric);
			
			s1.GetRow(8 + i).CreateCell(18).SetCellValue(double.Parse(dtDetails.Rows[i]["g_w_inner"].ToString()));
            s1.GetRow(8 + i).GetCell(18).SetCellType(CellType.Numeric);
			
			s1.GetRow(8 + i).CreateCell(19).SetCellValue(double.Parse(dtDetails.Rows[i]["n_w_outer"].ToString()));
            s1.GetRow(8 + i).GetCell(19).SetCellType(CellType.Numeric);
			
			s1.GetRow(8 + i).CreateCell(20).SetCellValue(double.Parse(dtDetails.Rows[i]["g_w_outer"].ToString()));
            s1.GetRow(8 + i).GetCell(20).SetCellType(CellType.Numeric);

            s1.GetRow(8 + i).CreateCell(21).SetCellValue(double.Parse(dtDetails.Rows[i]["giafob"].ToString()));
            s1.GetRow(8 + i).GetCell(21).SetCellType(CellType.Numeric);

            s1.GetRow(8 + i).CreateCell(22).SetCellValue(dtDetails.Rows[i]["ten_cangbien"].ToString());
            s1.GetRow(8 + i).CreateCell(23).SetCellValue(double.Parse(dtDetails.Rows[i]["hscode"].ToString()));

            /*s1.GetRow(8 + i).CreateCell(24).SetCellValue(tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["l_cm"].ToString()) : double.Parse(dtDetails.Rows[i]["l_inch"].ToString()));	
			s1.GetRow(8 + i).CreateCell(25).SetCellValue(tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["w_cm"].ToString()) : double.Parse(dtDetails.Rows[i]["w_inch"].ToString()));
            s1.GetRow(8 + i).CreateCell(26).SetCellValue(tenkt.Equals("cm") ? double.Parse(dtDetails.Rows[i]["h_cm"].ToString()) : double.Parse(dtDetails.Rows[i]["h_inch"].ToString()));*/
        }

        for (int i = 0; i < dtDetails.Rows.Count; i++)
        {
            for (int j = 0; j <= 23; j++)
            {
                if (j.Equals(4) || j.Equals(5) || j.Equals(7) || j.Equals(8) || j.Equals(9) || j.Equals(10) || j.Equals(11) || j.Equals(12) || j.Equals(13) || j.Equals(14) || j.Equals(15))
                {
                    s1.GetRow(8 + i).GetCell(j).CellStyle = cellStyleRight;
                }
                else
                {
                    s1.GetRow(8 + i).GetCell(j).CellStyle = border;
					for(int nht = 7 ; nht <= 12; nht++)
					{
						s1.GetRow(8 + i).GetCell(nht).CellStyle = cellNumBorderKT;
					}
					s1.GetRow(8 + i).GetCell(13).CellStyle = cellNumBorderCBM;
					//s1.GetRow(8 + i).GetCell(15).CellStyle = cellNumBorder;
					s1.GetRow(8 + i).GetCell(18).CellStyle = cellNumBorder;
					s1.GetRow(8 + i).GetCell(20).CellStyle = cellNumBorder;
					s1.GetRow(8 + i).GetCell(21).CellStyle = cellNumBorder;
                }
            }
        }

        s1.CreateRow(8 + detailsCount).CreateCell(0).SetCellValue("Color References:");
        int curLine = 0;
        int lineNum = 4;
        int curCell = 0;
        int totalLine = 0;
        for (int i = 0; i < dtDistinct.Rows.Count; i++)
        {

            List<DataRow> items = new List<DataRow>();
            foreach (DataRow row in dtReferences.Rows)
            {
                if (row["chungloai"].ToString().Equals(dtDistinct.Rows[i]["chungloai"].ToString()))
                {
                    items.Add(row);
                }
            }

            if (Math.Ceiling(items.Count / 4.0) != 0)
            {
                totalLine += (int)Math.Ceiling(items.Count / 4.0);
            }
            else
            {
                totalLine += (int)Math.Ceiling(items.Count / 4.0);
            }

            for (int j = 0; j < items.Count; j++)
            {
                if (curCell == 0 || curCell == lineNum)
                {
                    s1.CreateRow(9 + detailsCount + curLine * 8 + i * 8);
                    s1.CreateRow(10 + detailsCount + curLine * 8 + i * 8);
                }

                if (j == 0 || j == items.Count)
                {
                    s1.GetRow(9 + detailsCount + curLine * 8 + i * 8).CreateCell(1).SetCellValue(items[j]["ta_ngan"].ToString());
                    s1.AddMergedRegion(new CellRangeAddress(9 + detailsCount + curLine * 8 + i * 8, 9 + detailsCount + curLine * 8 + i * 8, 1, 2));
                }

                s1.GetRow(9 + detailsCount + curLine * 8 + i * 8).CreateCell(4 + curCell * 3).SetCellValue("Color " + items[j]["codemau"].ToString());
                s1.GetRow(10 + detailsCount + curLine * 8 + i * 8).CreateCell(4 + curCell * 3).SetCellValue(items[j]["mau"].ToString());
                try
                {
                    String imgPath = System.IO.Path.Combine(Public.imgColors, items[j]["url"].ToString());
                    System.Drawing.Image image = System.Drawing.Image.FromFile(imgPath);
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    IDrawing patriarch = s1.CreateDrawingPatriarch();
                    HSSFClientAnchor anchor = new HSSFClientAnchor(0, 0, 0, 0
                        , 4 + curCell * 3
                        , 11 + detailsCount + curLine * 8 + i * 8
                        , 6 + curCell * 3
                        , 17 + detailsCount + curLine * 8 + i * 8);
                    //anchor.AnchorType = 2;

                    int index = hssfworkbook.AddPicture(ms.ToArray(), PictureType.JPEG);
                    IPicture signaturePicture = patriarch.CreatePicture(anchor, index);
                }
                catch
                { }

                curCell++;
                if (curCell == lineNum)
                {
                    curCell = 0;
                    if(lineNum < items.Count) {
						curLine++;
					}
                }

                if (j + 1 == items.Count)
                {
                    curCell = 0;
                }
            }
        }

        /*s1.CreateRow(totalLine * 8 + 10 + detailsCount).CreateCell(0).SetCellValue("Remark:");
        s1.CreateRow(totalLine * 8 + 11 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 12 + detailsCount).CreateCell(0).SetCellValue("Number of items for:");
        s1.CreateRow(totalLine * 8 + 13 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 14 + detailsCount).CreateCell(0).SetCellValue("MOQ/item/color:");
        s1.CreateRow(totalLine * 8 + 15 + detailsCount).CreateCell(0).SetCellValue("Shipmenttime:");
        //s1.CreateRow(totalLine * 8 + 16 + detailsCount).CreateCell(0).SetCellValue("Port of loading:");
        s1.CreateRow(totalLine * 8 + 17 + detailsCount).CreateCell(0).SetCellValue("Payment term:");
        s1.CreateRow(totalLine * 8 + 18 + detailsCount).CreateCell(0).SetCellValue("Bank Details:");
        //s1.CreateRow(totalLine * 8 + 19 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 19 + detailsCount).CreateCell(0).SetCellValue("Validity  until:");

        ICellStyle wrap = hssfworkbook.CreateCellStyle();
        wrap.WrapText = true;


        //s1.GetRow(totalLine * 8 + 10 + detailsCount).CreateCell(1).SetCellValue("All above FOB prices is requested for FCL container - Packing as our standard offered above - Labelling in black & white color – including Bill of lading & seal fee and THC charge from the shipping line/forwarder.");
        s1.GetRow(totalLine * 8 + 10 + detailsCount).CreateCell(1).SetCellValue("All offered FOB prices are requested for FCL container - including packing as our above-mentioned  standard  -  Labeling in black & white color ( if required) – and Bill of lading & seal fee, THC, ENS charges from the shipping line/forwarder.");
        s1.GetRow(totalLine * 8 + 11 + detailsCount).CreateCell(1).SetCellValue("Other arising costs (if any) will be charged to customers.");

        s1.GetRow(totalLine * 8 + 12 + detailsCount).CreateCell(1).SetCellValue("20' cont.");
        //s1.GetRow(totalLine * 8 + 12 + detailsCount).CreateCell(2).SetCellValue("10 different items (max.)");
        s1.GetRow(totalLine * 8 + 12 + detailsCount).CreateCell(2).SetCellValue("12 different items (max.) which is offered under the same delivery terms/port of loading.");

        s1.GetRow(totalLine * 8 + 13 + detailsCount).CreateCell(1).SetCellValue("40' cont.");
        //s1.GetRow(totalLine * 8 + 13 + detailsCount).CreateCell(2).SetCellValue("20 different items (max.)");
        s1.GetRow(totalLine * 8 + 13 + detailsCount).CreateCell(2).SetCellValue("24 different items (max.) which is offered under the same delivery terms/port of loading.");

        s1.GetRow(totalLine * 8 + 14 + detailsCount).CreateCell(1).SetCellValue(dtDetails.Rows[0]["moq_item_color"].ToString());
        s1.GetRow(totalLine * 8 + 15 + detailsCount).CreateCell(1).SetCellValue(String.Format("{0} days after receipt od original L/C or 30% deposit", dtDetails.Rows[0]["shipmenttime"].ToString()));
        //s1.GetRow(totalLine * 8 + 16 + detailsCount).CreateCell(1).SetCellValue(dtDetails.Rows[0]["ten_cangbien"].ToString());
        s1.GetRow(totalLine * 8 + 17 + detailsCount).CreateCell(1).SetCellValue("TTR 30% deposit, 70% after shipment, or L/C at sight ( value over USD 20,000)");
        s1.GetRow(totalLine * 8 + 18 + detailsCount).CreateCell(1).SetCellValue(@"1. In favor VINH GIA COMPANY LTD. Account no. : 007.137.0321634 At bank: Joint Stock Commercial Bank For Foreign Trade of Vietnam (VIETCOMBANK),  29 Ben Chuong Duong St., Dist. 1, Hochiminh City, Vietnam. Tel.: (84-028) 38297245, Fax: (84-028) 38297228, Swift code: BFTVVNVX007.");
        //s1.GetRow(totalLine * 8 + 19 + detailsCount).CreateCell(1).SetCellValue(@"2. In favor of VINH GIA COMPANY LTD. Account no. : 001-395698-101 (USD). At bank: HSBC   Hochiminh City Branch , Metropolitan Building, 235 Dong Khoi St., Dist. 1, Tel.: (84-028) 35203051, Fax: (84-028) 38230530, Swift code: HSBCVNVXHochiminh City, Vietnam. ");
        s1.GetRow(totalLine * 8 + 19 + detailsCount).CreateCell(1).SetCellValue(DateTime.Parse(dtDetails.Rows[0]["ngayhethan"].ToString()).ToString("dd/MMM/yyyy"));

        s1.GetRow(totalLine * 8 + 10 + detailsCount).HeightInPoints = 30;
        s1.GetRow(totalLine * 8 + 18 + detailsCount).HeightInPoints = 30;
        s1.GetRow(totalLine * 8 + 19 + detailsCount).HeightInPoints = 30;

        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 10 + detailsCount, totalLine * 8 + 10 + detailsCount, 1, 12));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 11 + detailsCount, totalLine * 8 + 11 + detailsCount, 1, 12));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 15 + detailsCount, totalLine * 8 + 15 + detailsCount, 1, 12));
        //s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 16 + detailsCount, totalLine * 8 + 16 + detailsCount, 1, 12));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 17 + detailsCount, totalLine * 8 + 17 + detailsCount, 1, 12));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 18 + detailsCount, totalLine * 8 + 18 + detailsCount, 1, 12));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 19 + detailsCount, totalLine * 8 + 19 + detailsCount, 1, 12));

        s1.GetRow(totalLine * 8 + 10 + detailsCount).GetCell(1).CellStyle = wrap;
        s1.GetRow(totalLine * 8 + 11 + detailsCount).GetCell(1).CellStyle = wrap;
        s1.GetRow(totalLine * 8 + 15 + detailsCount).GetCell(1).CellStyle = wrap;
        //s1.GetRow(totalLine * 8 + 16 + detailsCount).GetCell(1).CellStyle = wrap;
        s1.GetRow(totalLine * 8 + 17 + detailsCount).GetCell(1).CellStyle = wrap;
        s1.GetRow(totalLine * 8 + 18 + detailsCount).GetCell(1).CellStyle = wrap;
        s1.GetRow(totalLine * 8 + 19 + detailsCount).GetCell(1).CellStyle = wrap;

        return hssfworkbook;*/
		detailsCount += 1;
		s1.CreateRow(totalLine * 8 + 10 + detailsCount).CreateCell(0).SetCellValue("Remark:");
        s1.CreateRow(totalLine * 8 + 11 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 12 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 13 + detailsCount).CreateCell(0).SetCellValue("");
		s1.CreateRow(totalLine * 8 + 14 + detailsCount).CreateCell(0).SetCellValue("Minimum order:");
        s1.CreateRow(totalLine * 8 + 15 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 16 + detailsCount).CreateCell(0).SetCellValue("Number of items for:");
        s1.CreateRow(totalLine * 8 + 17 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 18 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 19 + detailsCount).CreateCell(0).SetCellValue("MOQ/item/color:");
        s1.CreateRow(totalLine * 8 + 20 + detailsCount).CreateCell(0).SetCellValue("Shipment time:");
        s1.CreateRow(totalLine * 8 + 21 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 22 + detailsCount).CreateCell(0).SetCellValue("Port of loading:");
        s1.CreateRow(totalLine * 8 + 23 + detailsCount).CreateCell(0).SetCellValue("Payment terms:");
        s1.CreateRow(totalLine * 8 + 24 + detailsCount).CreateCell(0).SetCellValue("Bank Details:");
        //s1.CreateRow(totalLine * 8 + 19 + detailsCount).CreateCell(0).SetCellValue("");
        s1.CreateRow(totalLine * 8 + 25 + detailsCount).CreateCell(0).SetCellValue("Validity  until:");

        s1.GetRow(totalLine * 8 + 10 + detailsCount).CreateCell(1).SetCellValue("All offered FOB prices are requested for FCL container - including packing as our above-mentioned  standard; Labeling in black & white color ( if required); Bill of lading & seal fee, THC, ENS charges from the shipping line/forwarder and normal container fumigation & ventilation fees with Methyl Bromide (if any).");
        s1.GetRow(totalLine * 8 + 11 + detailsCount).CreateCell(1).SetCellValue(
			@"The fee of Fumigation and Ventilation under AFAS standard for all containers imported to Australia (if required) will be charged to customers: 220 USD/20"" container; 310 USD/40"", 40”HC, 45” container."
		);
        s1.GetRow(totalLine * 8 + 12 + detailsCount).CreateCell(1).SetCellValue("Other arising costs (if any) will be charged to customers.");
        s1.GetRow(totalLine * 8 + 13 + detailsCount).CreateCell(1).SetCellValue("All information of weight, loadability are estimated only.");
        
		s1.GetRow(totalLine * 8 + 14 + detailsCount).CreateCell(1).SetCellValue("1x40” container ( a full container)");
        s1.GetRow(totalLine * 8 + 15 + detailsCount).CreateCell(1).SetCellValue("Order of 1x20\" can be accepted, but if the value is under 8000 USD, the extra charge of 250 USD will be added into the proforma invoice/commercial invoice");
		
        s1.GetRow(totalLine * 8 + 16 + detailsCount).CreateCell(1).SetCellValue("20' cont.");
        s1.GetRow(totalLine * 8 + 16 + detailsCount).CreateCell(2).SetCellValue("12 different items (max.) which is offered under the same delivery terms/port of loading.");

        s1.GetRow(totalLine * 8 + 17 + detailsCount).CreateCell(1).SetCellValue("40' cont.");
        s1.GetRow(totalLine * 8 + 17 + detailsCount).CreateCell(2).SetCellValue("24 different items (max.) which is offered under the same delivery terms/port of loading.");     
		
		s1.GetRow(totalLine * 8 + 18 + detailsCount).CreateCell(1).SetCellValue("The extra charge of 5%-10% will be added into the prices if the number of items in a container is over the above-mentioned requirement.");
		
        s1.GetRow(totalLine * 8 + 19 + detailsCount).CreateCell(1).SetCellValue(dtDetails.Rows[0]["moq_item_color"].ToString());
        s1.GetRow(totalLine * 8 + 20 + detailsCount).CreateCell(1).SetCellValue(String.Format("Normally, {0} - {1} days after receipt of original L/C or 30% deposit", dtDetails.Rows[0]["shipmenttime"].ToString() , dtDetails.Rows[0]["shipmenttime2"].ToString()));
        s1.GetRow(totalLine * 8 + 21 + detailsCount).CreateCell(1).SetCellValue(String.Format("In peak season, the shipment time can be longer and is quoted under rules of FIRST IN FIRST OUT ( FIFO) "));
        //s1.GetRow(totalLine * 8 + 16 + detailsCount).CreateCell(1).SetCellValue(dtDetails.Rows[0]["ten_cangbien"].ToString());
		s1.GetRow(totalLine * 8 + 22 + detailsCount).CreateCell(1).SetCellValue(" As above-mentioned");
        s1.GetRow(totalLine * 8 + 23 + detailsCount).CreateCell(1).SetCellValue("TTR 30% deposit, 70% after shipment, or L/C at sight ( value over USD 20,000)");
        
		
		
		s1.GetRow(totalLine * 8 + 24 + detailsCount).CreateCell(1).SetCellValue("In  favor VINH GIA COMPANY LTD."
																				  +"\r\nAccount no. : 007.137.0321634"
																				  +"\r\nAt bank: Joint Stock Commercial Bank For Foreign Trade of Vietnam (VIETCOMBANK),"
																				  +"\r\n10 Vo Van Kiet St., Dist. 1, Hochiminh City, Vietnam."
																				  +"\r\nTel.: (84-28) 38297245,"
																				  +"\r\nFax: (84-28) 38297228,"
																				  +"\r\nSwift code: BFTVVNVX007.");
        //s1.GetRow(totalLine * 8 + 19 + detailsCount).CreateCell(1).SetCellValue(@"2. In favor of VINH GIA COMPANY LTD. Account no. : 001-395698-101 (USD). At bank: HSBC   Hochiminh City Branch , Metropolitan Building, 235 Dong Khoi St., Dist. 1, Tel.: (84-028) 35203051, Fax: (84-028) 38230530, Swift code: HSBCVNVXHochiminh City, Vietnam. ");
        s1.GetRow(totalLine * 8 + 25 + detailsCount).CreateCell(1).SetCellValue(DateTime.Parse(dtDetails.Rows[0]["ngayhethan"].ToString()).ToString("dd/MMM/yyyy"));
        
		s1.GetRow(totalLine * 8 + 10 + detailsCount).HeightInPoints = 30;
        //s1.GetRow(totalLine * 8 + 19 + detailsCount).HeightInPoints = 30;
        //s1.GetRow(totalLine * 8 + 20 + detailsCount).HeightInPoints = 30;
        //s1.GetRow(totalLine * 8 + 21 + detailsCount).HeightInPoints = 30;
        s1.GetRow(totalLine * 8 + 24 + detailsCount).HeightInPoints = 90;
		
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 10 + detailsCount, totalLine * 8 + 10 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 11 + detailsCount, totalLine * 8 + 11 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 12 + detailsCount, totalLine * 8 + 12 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 13 + detailsCount, totalLine * 8 + 13 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 14 + detailsCount, totalLine * 8 + 14 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 15 + detailsCount, totalLine * 8 + 15 + detailsCount, 1, 15));
        //s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 16 + detailsCount, totalLine * 8 + 16 + detailsCount, 1, 15));
        //s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 17 + detailsCount, totalLine * 8 + 17 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 18 + detailsCount, totalLine * 8 + 18 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 19 + detailsCount, totalLine * 8 + 19 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 20 + detailsCount, totalLine * 8 + 20 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 21 + detailsCount, totalLine * 8 + 21 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 22 + detailsCount, totalLine * 8 + 22 + detailsCount, 1, 15));
        s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 23 + detailsCount, totalLine * 8 + 23 + detailsCount, 1, 15));
		s1.AddMergedRegion(new CellRangeAddress(totalLine * 8 + 24 + detailsCount, totalLine * 8 + 24 + detailsCount, 1, 15));

		ICellStyle wrap = hssfworkbook.CreateCellStyle();
		wrap.Alignment = HorizontalAlignment.Left;
        wrap.VerticalAlignment = VerticalAlignment.Top;
		wrap.WrapText = true;
		
        for(int nht = 10; nht <= 25; nht++)
		{
			s1.GetRow(totalLine * 8 + nht + detailsCount).GetCell(0).CellStyle = wrap;
			s1.GetRow(totalLine * 8 + nht + detailsCount).GetCell(1).CellStyle = wrap;
		}
		
		return hssfworkbook;
    }

    public String C_baogia_id
    {
        get { return c_baogia_id; }
        set { c_baogia_id = value; }
    }

    public BaoGiaMauReport_pdf(String c_baogia_id, String logoPath, String productImagePath)
	{
        this.c_baogia_id = c_baogia_id;
        this.logoPath = logoPath;
        this.productImagePath = productImagePath;
	}
}
