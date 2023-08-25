﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for rptInDonHang
/// </summary>
public class rptInDonHang : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel7;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRLabel xrLabel29;
    private XRLabel xrLabel38;
    private XRLabel xrLabel37;
    private XRLabel xrLabel36;
    private XRLabel xrLabel44;
    private XRLabel xrLabel45;
    private XRLabel xrLabel42;
    private XRLabel xrLabel43;
    private XRLabel xrLabel41;
    private XRLabel xrLabel40;
    private XRLabel xrLabel39;
    private XRLabel xrLabel47;
    private XRLabel xrLabel46;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrLabel18;
    private XRLabel xrLabel17;
    private XRLabel xrLabel19;
    private XRLabel xrLabel16;
    private XRLabel xrLabel35;
    private XRLabel xrLabel15;
    private XRLabel xrLabel20;
    private XRLabel xrLabel21;
    private XRLabel xrLabel33;
    private XRLabel xrLabel28;
    private XRLabel xrLabel26;
    private XRLabel xrLabel30;
    private XRLabel xrLabel32;
    private XRLabel xrLabel31;
    private XRLabel xrLabel22;
    private XRLabel xrLabel23;
    private XRLabel xrLabel25;
    private XRLabel xrLabel24;
    private XRLabel xrLabel27;
    private ReportFooterBand ReportFooter;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRLabel hoahong;
    private XRLabel nguoinhan;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRPictureBox xrPictureBox2;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell3;
    private XRLabel xrLabel34;
    private XRLabel ghichu;
    private XRLabel xrLabel48;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rptInDonHang()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
        DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
        this.ghichu = new DevExpress.XtraReports.UI.XRLabel();
        this.hoahong = new DevExpress.XtraReports.UI.XRLabel();
        this.nguoinhan = new DevExpress.XtraReports.UI.XRLabel();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.Detail.Dpi = 100F;
        this.Detail.HeightF = 69.79166F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable1
        // 
        this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable1.Dpi = 100F;
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(794.9999F, 69.79166F);
        this.xrTable1.StylePriority.UseBorders = false;
        this.xrTable1.StylePriority.UsePadding = false;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell12,
            this.xrTableCell2,
            this.xrTableCell8,
            this.xrTableCell13,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell3});
        this.xrTableRow1.Dpi = 100F;
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Dpi = 100F;
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell4.StylePriority.UsePadding = false;
        this.xrTableCell4.StylePriority.UseTextAlignment = false;
        xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
        xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrTableCell4.Summary = xrSummary1;
        this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell4.Weight = 0.12767027633541475D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ma_sanpham")});
        this.xrTableCell5.Dpi = 100F;
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseTextAlignment = false;
        this.xrTableCell5.Text = "[ma_sanpham]";
        this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell5.Weight = 0.431408432337253D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2});
        this.xrTableCell6.Dpi = 100F;
        this.xrTableCell6.Multiline = true;
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Weight = 0.43825172229193543D;
        // 
        // xrPictureBox2
        // 
        this.xrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrPictureBox2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("ImageUrl", null, "url", "~/images/products/fullsize/{0}")});
        this.xrPictureBox2.Dpi = 100F;
        this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(1F, 0F);
        this.xrPictureBox2.Name = "xrPictureBox2";
        this.xrPictureBox2.SizeF = new System.Drawing.SizeF(103F, 67.79166F);
        this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        this.xrPictureBox2.StylePriority.UseBorders = false;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ma_sanpham_khach")});
        this.xrTableCell1.Dpi = 100F;
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "[ma_sanpham_khach]";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell1.Weight = 0.2628505567078756D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "mota_tienganh")});
        this.xrTableCell7.Dpi = 100F;
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseTextAlignment = false;
        this.xrTableCell7.Text = "[mota_tienganh]";
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell7.Weight = 0.445426967167465D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ten_donggoi_inner")});
        this.xrTableCell12.Dpi = 100F;
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.Text = "xrTableCell12";
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell12.Weight = 0.18775058583083493D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ten_donggoi_outer")});
        this.xrTableCell2.Dpi = 100F;
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "[ten_donggoi]";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell2.Weight = 0.17748815470769253D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ofpack", "{0:#,#0.0}")});
        this.xrTableCell8.Dpi = 100F;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.StylePriority.UseTextAlignment = false;
        this.xrTableCell8.Text = "xrTableCell8";
        this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell8.Weight = 0.20443910293093803D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "soluong", "{0:#,#0}")});
        this.xrTableCell13.Dpi = 100F;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseTextAlignment = false;
        this.xrTableCell13.Text = "xrTableCell13";
        this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell13.Weight = 0.18357828439257029D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "dvt_sp")});
        this.xrTableCell9.Dpi = 100F;
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.StylePriority.UseTextAlignment = false;
        this.xrTableCell9.Text = "[dvt_sp]";
        this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell9.Weight = 0.15854318953185076D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "giafob", "{0:#,#0.00}")});
        this.xrTableCell10.Dpi = 100F;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseTextAlignment = false;
        this.xrTableCell10.Text = "xrTableCell10";
        this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell10.Weight = 0.19400404341364008D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbm", "{0:#,#0.000}")});
        this.xrTableCell11.Dpi = 100F;
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.StylePriority.UseTextAlignment = false;
        this.xrTableCell11.Text = "xrTableCell11";
        this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell11.Weight = 0.18984199762537846D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "amount", "{0:#,#0.00}")});
        this.xrTableCell3.Dpi = 100F;
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseTextAlignment = false;
        this.xrTableCell3.Text = "xrTableCell3";
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTableCell3.Weight = 0.31116273693094237D;
        // 
        // TopMargin
        // 
        this.TopMargin.Dpi = 100F;
        this.TopMargin.HeightF = 12F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Dpi = 100F;
        this.BottomMargin.HeightF = 0F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.Dpi = 100F;
        this.xrPictureBox1.ImageUrl = "~\\images\\VINHGIA_logo_print.png";
        this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(173.6216F, 0F);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.SizeF = new System.Drawing.SizeF(80.20834F, 54.25002F);
        this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
        // 
        // xrLabel3
        // 
        this.xrLabel3.Dpi = 100F;
        this.xrLabel3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0.009435018F, 98.66669F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(794.8238F, 40.70834F);
        this.xrLabel3.StylePriority.UseFont = false;
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = "PROFORMA INVOICE";
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel4
        // 
        this.xrLabel4.Dpi = 100F;
        this.xrLabel4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Underline);
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 76.45836F);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(795F, 22.20834F);
        this.xrLabel4.StylePriority.UseFont = false;
        this.xrLabel4.StylePriority.UseTextAlignment = false;
        this.xrLabel4.Text = "Tel.:  (Tel: (84-235) 3567393   Fax: (84-235) 3567494";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Dpi = 100F;
        this.xrLabel2.Font = new System.Drawing.Font("Arial", 10F);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.009435018F, 54.25F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(794.9905F, 22.20835F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "Northern Chu Lai Industrial Zone, Tam Hiep Commune, Nui Thanh District, Quang Nam Province, Viet Nam";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Dpi = 100F;
        this.xrLabel1.Font = new System.Drawing.Font("Arial", 16F);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(253.8302F, 0F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(326.9174F, 54.25002F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "VINH GIA COMPANY LIMITED";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel10
        // 
        this.xrLabel10.Dpi = 100F;
        this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 187.5F);
        this.xrLabel10.Name = "xrLabel10";
        this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel10.SizeF = new System.Drawing.SizeF(126.3751F, 22.99998F);
        this.xrLabel10.StylePriority.UseTextAlignment = false;
        this.xrLabel10.Text = "The Buyer:";
        this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel6
        // 
        this.xrLabel6.Dpi = 100F;
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(602.5153F, 164.5F);
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(52.64621F, 23F);
        this.xrLabel6.StylePriority.UseTextAlignment = false;
        this.xrLabel6.Text = "No. :";
        this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel7
        // 
        this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sochungtu")});
        this.xrLabel7.Dpi = 100F;
        this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(655.1616F, 164.5F);
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel7.SizeF = new System.Drawing.SizeF(137.8384F, 22.99995F);
        this.xrLabel7.StylePriority.UseTextAlignment = false;
        this.xrLabel7.Text = "[sochungtu]";
        this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel8
        // 
        this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ngaylap", "{0:dd/MMM/yyyy}")});
        this.xrLabel8.Dpi = 100F;
        this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(655.1616F, 141.5F);
        this.xrLabel8.Name = "xrLabel8";
        this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel8.SizeF = new System.Drawing.SizeF(137.8384F, 23F);
        this.xrLabel8.StylePriority.UseTextAlignment = false;
        this.xrLabel8.Text = "xrLabel8";
        this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel9
        // 
        this.xrLabel9.Dpi = 100F;
        this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 256.4999F);
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel9.SizeF = new System.Drawing.SizeF(794.9999F, 23F);
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = "The Payer:";
        this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel5
        // 
        this.xrLabel5.Dpi = 100F;
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(602.5153F, 141.4999F);
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(52.64621F, 23F);
        this.xrLabel5.StylePriority.UseTextAlignment = false;
        this.xrLabel5.Text = "Date:";
        this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel11
        // 
        this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ten_dtkd")});
        this.xrLabel11.Dpi = 100F;
        this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(131.5415F, 187.5F);
        this.xrLabel11.Name = "xrLabel11";
        this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel11.SizeF = new System.Drawing.SizeF(663.4584F, 22.99998F);
        this.xrLabel11.StylePriority.UseTextAlignment = false;
        this.xrLabel11.Text = "[ten_dtkd]";
        this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel12
        // 
        this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "payer")});
        this.xrLabel12.Dpi = 100F;
        this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 279.4999F);
        this.xrLabel12.Name = "xrLabel12";
        this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel12.SizeF = new System.Drawing.SizeF(793.1667F, 23.00003F);
        this.xrLabel12.StylePriority.UseTextAlignment = false;
        this.xrLabel12.Text = "[payer]";
        this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel13
        // 
        this.xrLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(222)))), ((int)(((byte)(239)))));
        this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "commodity", "Commodity: {0}")});
        this.xrLabel13.Dpi = 100F;
        this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 348.5001F);
        this.xrLabel13.Name = "xrLabel13";
        this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel13.SizeF = new System.Drawing.SizeF(794.9999F, 23F);
        this.xrLabel13.StylePriority.UseBackColor = false;
        this.xrLabel13.StylePriority.UseTextAlignment = false;
        this.xrLabel13.Text = "xrLabel13";
        this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel14
        // 
        this.xrLabel14.Dpi = 100F;
        this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 371.5F);
        this.xrLabel14.Name = "xrLabel14";
        this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel14.SizeF = new System.Drawing.SizeF(794.9999F, 23F);
        this.xrLabel14.StylePriority.UseTextAlignment = false;
        this.xrLabel14.Text = "Item nos., description, packing, quantity, unit price and amount:";
        this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel23
        // 
        this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "dis", "Discount:({0:#,#}%)")});
        this.xrLabel23.Dpi = 100F;
        this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(0F, 69.29144F);
        this.xrLabel23.Name = "xrLabel23";
        this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel23.SizeF = new System.Drawing.SizeF(497.1793F, 23.00001F);
        this.xrLabel23.StylePriority.UseFont = false;
        this.xrLabel23.StylePriority.UseTextAlignment = false;
        xrSummary2.FormatString = "{0:#,#.00}";
        this.xrLabel23.Summary = xrSummary2;
        this.xrLabel23.Text = "xrLabel23";
        this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel22
        // 
        this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "discount", "{0:#,#0.00}")});
        this.xrLabel22.Dpi = 100F;
        this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(720.8198F, 69.00002F);
        this.xrLabel22.Name = "xrLabel22";
        this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel22.SizeF = new System.Drawing.SizeF(73.51343F, 23.00002F);
        this.xrLabel22.StylePriority.UseFont = false;
        this.xrLabel22.StylePriority.UseTextAlignment = false;
        xrSummary3.FormatString = "{0:#,#0.00}";
        this.xrLabel22.Summary = xrSummary3;
        this.xrLabel22.Text = "xrLabel22";
        this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel16
        // 
        this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "phicong", "{0:#,#0.00}")});
        this.xrLabel16.Dpi = 100F;
        this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(720.8197F, 23.00001F);
        this.xrLabel16.Name = "xrLabel16";
        this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel16.SizeF = new System.Drawing.SizeF(73.51355F, 23.00002F);
        this.xrLabel16.StylePriority.UseFont = false;
        this.xrLabel16.StylePriority.UseTextAlignment = false;
        xrSummary4.FormatString = "{0:#,#0.00}";
        this.xrLabel16.Summary = xrSummary4;
        this.xrLabel16.Text = "xrLabel16";
        this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel35
        // 
        this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "total", "{0:#,#0.00}")});
        this.xrLabel35.Dpi = 100F;
        this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(720.8174F, 92.29144F);
        this.xrLabel35.Name = "xrLabel35";
        this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel35.SizeF = new System.Drawing.SizeF(73.51587F, 23.00001F);
        this.xrLabel35.StylePriority.UseFont = false;
        this.xrLabel35.StylePriority.UseTextAlignment = false;
        xrSummary5.FormatString = "{0:#,#0.00}";
        this.xrLabel35.Summary = xrSummary5;
        this.xrLabel35.Text = "xrLabel35";
        this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel15
        // 
        this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "phitru", "{0:#,#0.00}")});
        this.xrLabel15.Dpi = 100F;
        this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(720.8198F, 46.00001F);
        this.xrLabel15.Name = "xrLabel15";
        this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel15.SizeF = new System.Drawing.SizeF(73.51343F, 23.00002F);
        this.xrLabel15.StylePriority.UseFont = false;
        this.xrLabel15.StylePriority.UseTextAlignment = false;
        xrSummary6.FormatString = "{0:#,#0.00}";
        this.xrLabel15.Summary = xrSummary6;
        this.xrLabel15.Text = "xrLabel15";
        this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel20
        // 
        this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "diengiaitru", "(-) {0}")});
        this.xrLabel20.Dpi = 100F;
        this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.00001F);
        this.xrLabel20.Name = "xrLabel20";
        this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel20.SizeF = new System.Drawing.SizeF(497.5149F, 23.00002F);
        this.xrLabel20.StylePriority.UseFont = false;
        this.xrLabel20.StylePriority.UseTextAlignment = false;
        this.xrLabel20.Text = "xrLabel20";
        this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel21
        // 
        this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "diengiaicong", "(+) {0}")});
        this.xrLabel21.Dpi = 100F;
        this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.00003F);
        this.xrLabel21.Name = "xrLabel21";
        this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel21.SizeF = new System.Drawing.SizeF(497.3482F, 23.00001F);
        this.xrLabel21.StylePriority.UseFont = false;
        this.xrLabel21.StylePriority.UseTextAlignment = false;
        this.xrLabel21.Text = "xrLabel21";
        this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel33
        // 
        this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "amount", "{0:#,#0.00}")});
        this.xrLabel33.Dpi = 100F;
        this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(720.8198F, 0F);
        this.xrLabel33.Name = "xrLabel33";
        this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel33.SizeF = new System.Drawing.SizeF(73.34686F, 23.00002F);
        this.xrLabel33.StylePriority.UseFont = false;
        this.xrLabel33.StylePriority.UseTextAlignment = false;
        xrSummary7.FormatString = "{0:#,#0.00}";
        xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrLabel33.Summary = xrSummary7;
        this.xrLabel33.Text = "xrLabel33";
        this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel28
        // 
        this.xrLabel28.Dpi = 100F;
        this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 92.29147F);
        this.xrLabel28.Name = "xrLabel28";
        this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel28.SizeF = new System.Drawing.SizeF(497.1815F, 22.99999F);
        this.xrLabel28.StylePriority.UseFont = false;
        this.xrLabel28.StylePriority.UseTextAlignment = false;
        this.xrLabel28.Text = "Total:";
        this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel26
        // 
        this.xrLabel26.Dpi = 100F;
        this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrLabel26.Name = "xrLabel26";
        this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel26.SizeF = new System.Drawing.SizeF(497.1815F, 23.00002F);
        this.xrLabel26.StylePriority.UseFont = false;
        this.xrLabel26.StylePriority.UseTextAlignment = false;
        this.xrLabel26.Text = "Sub Total:";
        this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel30
        // 
        this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ofpack", "{0:#,#0.0}")});
        this.xrLabel30.Dpi = 100F;
        this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(497.1815F, 0F);
        this.xrLabel30.Name = "xrLabel30";
        this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel30.SizeF = new System.Drawing.SizeF(48.56747F, 23.00002F);
        this.xrLabel30.StylePriority.UseFont = false;
        this.xrLabel30.StylePriority.UseTextAlignment = false;
        xrSummary8.FormatString = "{0:#0.0}";
        xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrLabel30.Summary = xrSummary8;
        this.xrLabel30.Text = "xrLabel30";
        this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel32
        // 
        this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cbm", "{0:#,#0.000}")});
        this.xrLabel32.Dpi = 100F;
        this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(673.4517F, 0F);
        this.xrLabel32.Name = "xrLabel32";
        this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel32.SizeF = new System.Drawing.SizeF(47.36591F, 23.00002F);
        this.xrLabel32.StylePriority.UseFont = false;
        this.xrLabel32.StylePriority.UseTextAlignment = false;
        xrSummary9.FormatString = "{0:#,#0.000}";
        xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrLabel32.Summary = xrSummary9;
        this.xrLabel32.Text = "xrLabel32";
        this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel31
        // 
        this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "soluong", "{0:#,#0}")});
        this.xrLabel31.Dpi = 100F;
        this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(546.0824F, 0F);
        this.xrLabel31.Name = "xrLabel31";
        this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel31.SizeF = new System.Drawing.SizeF(43.89325F, 23.00002F);
        this.xrLabel31.StylePriority.UseFont = false;
        this.xrLabel31.StylePriority.UseTextAlignment = false;
        xrSummary10.FormatString = "{0:#,#0}";
        xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        this.xrLabel31.Summary = xrSummary10;
        this.xrLabel31.Text = "xrLabel31";
        this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel19
        // 
        this.xrLabel19.Dpi = 100F;
        this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(32.54837F, 161.2914F);
        this.xrLabel19.Name = "xrLabel19";
        this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel19.SizeF = new System.Drawing.SizeF(762.4517F, 23.00002F);
        this.xrLabel19.StylePriority.UseFont = false;
        this.xrLabel19.StylePriority.UseTextAlignment = false;
        this.xrLabel19.Text = "(10% more or less in quantity and amount are acceptable).";
        this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // xrLabel47
        // 
        this.xrLabel47.Dpi = 100F;
        this.xrLabel47.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(414.8584F, 400.1249F);
        this.xrLabel47.Name = "xrLabel47";
        this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel47.SizeF = new System.Drawing.SizeF(380.1416F, 45.9166F);
        this.xrLabel47.StylePriority.UseFont = false;
        this.xrLabel47.StylePriority.UseTextAlignment = false;
        this.xrLabel47.Text = "VINH GIA COMPANY LTD.";
        this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel46
        // 
        this.xrLabel46.Dpi = 100F;
        this.xrLabel46.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(0F, 400.1249F);
        this.xrLabel46.Name = "xrLabel46";
        this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel46.SizeF = new System.Drawing.SizeF(400.8752F, 45.91669F);
        this.xrLabel46.StylePriority.UseFont = false;
        this.xrLabel46.StylePriority.UseTextAlignment = false;
        this.xrLabel46.Text = "CONFIRMED BY THE BUYER";
        this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel44
        // 
        this.xrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "portdischarge")});
        this.xrLabel44.Dpi = 100F;
        this.xrLabel44.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(126.2084F, 266.2915F);
        this.xrLabel44.Name = "xrLabel44";
        this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel44.SizeF = new System.Drawing.SizeF(668.1248F, 23.00003F);
        this.xrLabel44.StylePriority.UseFont = false;
        this.xrLabel44.StylePriority.UseTextAlignment = false;
        this.xrLabel44.Text = "[portdischarge]";
        this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel45
        // 
        this.xrLabel45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ten_cangbien")});
        this.xrLabel45.Dpi = 100F;
        this.xrLabel45.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(126.2084F, 241.2915F);
        this.xrLabel45.Name = "xrLabel45";
        this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel45.SizeF = new System.Drawing.SizeF(668.1248F, 23.00003F);
        this.xrLabel45.StylePriority.UseFont = false;
        this.xrLabel45.StylePriority.UseTextAlignment = false;
        this.xrLabel45.Text = "[ten_cangbien]";
        this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel42
        // 
        this.xrLabel42.AutoWidth = true;
        this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "mota")});
        this.xrLabel42.Dpi = 100F;
        this.xrLabel42.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(126.2084F, 339.1248F);
        this.xrLabel42.Multiline = true;
        this.xrLabel42.Name = "xrLabel42";
        this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel42.SizeF = new System.Drawing.SizeF(668.7916F, 23.00003F);
        this.xrLabel42.StylePriority.UseFont = false;
        this.xrLabel42.StylePriority.UseTextAlignment = false;
        this.xrLabel42.Text = "[paymentterm]";
        this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel43
        // 
        this.xrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "shipmenttime", "{0:dd/MMM/yyyy}")});
        this.xrLabel43.Dpi = 100F;
        this.xrLabel43.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(126.2084F, 290.2915F);
        this.xrLabel43.Name = "xrLabel43";
        this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel43.SizeF = new System.Drawing.SizeF(668.1248F, 23.00003F);
        this.xrLabel43.StylePriority.UseFont = false;
        this.xrLabel43.StylePriority.UseTextAlignment = false;
        this.xrLabel43.Text = "xrLabel43";
        this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel41
        // 
        this.xrLabel41.Dpi = 100F;
        this.xrLabel41.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 377.1249F);
        this.xrLabel41.Name = "xrLabel41";
        this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel41.SizeF = new System.Drawing.SizeF(793.1667F, 23.00006F);
        this.xrLabel41.StylePriority.UseFont = false;
        this.xrLabel41.StylePriority.UseTextAlignment = false;
        this.xrLabel41.Text = "This agreement comes into effect from the signing date.";
        this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel40
        // 
        this.xrLabel40.Dpi = 100F;
        this.xrLabel40.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(0.009435018F, 314.2916F);
        this.xrLabel40.Name = "xrLabel40";
        this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel40.SizeF = new System.Drawing.SizeF(114.3751F, 23.00003F);
        this.xrLabel40.StylePriority.UseFont = false;
        this.xrLabel40.StylePriority.UseTextAlignment = false;
        this.xrLabel40.Text = "Payment term:";
        this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel39
        // 
        this.xrLabel39.Dpi = 100F;
        this.xrLabel39.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 290.2915F);
        this.xrLabel39.Name = "xrLabel39";
        this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel39.SizeF = new System.Drawing.SizeF(114.3751F, 23.00003F);
        this.xrLabel39.StylePriority.UseFont = false;
        this.xrLabel39.StylePriority.UseTextAlignment = false;
        this.xrLabel39.Text = "Shipment Time:";
        this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel38
        // 
        this.xrLabel38.Dpi = 100F;
        this.xrLabel38.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 266.2915F);
        this.xrLabel38.Name = "xrLabel38";
        this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel38.SizeF = new System.Drawing.SizeF(114.3751F, 23.00003F);
        this.xrLabel38.StylePriority.UseFont = false;
        this.xrLabel38.StylePriority.UseTextAlignment = false;
        this.xrLabel38.Text = "Port of discharge:";
        this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel37
        // 
        this.xrLabel37.Dpi = 100F;
        this.xrLabel37.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 241.2915F);
        this.xrLabel37.Name = "xrLabel37";
        this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel37.SizeF = new System.Drawing.SizeF(114.3751F, 23.00002F);
        this.xrLabel37.StylePriority.UseFont = false;
        this.xrLabel37.StylePriority.UseTextAlignment = false;
        this.xrLabel37.Text = "Port of loading:";
        this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel36
        // 
        this.xrLabel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(215)))), ((int)(((byte)(236)))));
        this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "no_cont", "No. of Conts : {0}")});
        this.xrLabel36.Dpi = 100F;
        this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(0F, 216.2915F);
        this.xrLabel36.Name = "xrLabel36";
        this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel36.SizeF = new System.Drawing.SizeF(794.4999F, 23F);
        this.xrLabel36.StylePriority.UseBackColor = false;
        this.xrLabel36.StylePriority.UseFont = false;
        this.xrLabel36.StylePriority.UseTextAlignment = false;
        this.xrLabel36.Text = "xrLabel36";
        this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel29
        // 
        this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "money", "Say: USD {0}")});
        this.xrLabel29.Dpi = 100F;
        this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(32.5484F, 138.2914F);
        this.xrLabel29.Multiline = true;
        this.xrLabel29.Name = "xrLabel29";
        this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel29.SizeF = new System.Drawing.SizeF(762.4516F, 23.00002F);
        this.xrLabel29.StylePriority.UseFont = false;
        this.xrLabel29.StylePriority.UseTextAlignment = false;
        this.xrLabel29.Text = "xrLabel29";
        this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrLabel27,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel1,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel5,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel10,
            this.xrLabel2,
            this.xrPictureBox1,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel14});
        this.ReportHeader.Dpi = 100F;
        this.ReportHeader.HeightF = 446.5835F;
        this.ReportHeader.Name = "ReportHeader";
        this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.ReportHeader.StylePriority.UsePadding = false;
        // 
        // xrTable2
        // 
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable2.Dpi = 100F;
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 394.5001F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(794.9999F, 52.08334F);
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell16,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
        this.xrTableRow2.Dpi = 100F;
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.Dpi = 100F;
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.Text = "No.";
        this.xrTableCell14.Weight = 0.10878087931899351D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.Dpi = 100F;
        this.xrTableCell15.Multiline = true;
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.Text = "VINH GIA\r\nItem No.";
        this.xrTableCell15.Weight = 0.36760526793808657D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.Dpi = 100F;
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.Text = "Picture";
        this.xrTableCell17.Weight = 0.37343636470443153D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.Dpi = 100F;
        this.xrTableCell18.Multiline = true;
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.Text = "Customer\r\nItem No.";
        this.xrTableCell18.Weight = 0.22397616129279549D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.Dpi = 100F;
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.Text = "Description";
        this.xrTableCell16.Weight = 0.37954823139009508D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.Dpi = 100F;
        this.xrTableCell19.Multiline = true;
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.Text = "Packing\r\ninner/master";
        this.xrTableCell19.Weight = 0.31122081951896086D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Dpi = 100F;
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.Text = "Nbr of packs";
        this.xrTableCell20.Weight = 0.17420339752983605D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.Dpi = 100F;
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.Text = "Quantity (sets/pcs)";
        this.xrTableCell21.Weight = 0.29152356273324331D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.Dpi = 100F;
        this.xrTableCell22.Multiline = true;
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.Text = "FOB\r\nPRICE\r\n(USD)";
        this.xrTableCell22.Weight = 0.1653116781340529D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Dpi = 100F;
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.Text = "Cbm";
        this.xrTableCell23.Weight = 0.16176518142906793D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Dpi = 100F;
        this.xrTableCell24.Multiline = true;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.Text = "Amount\r\n(USD)";
        this.xrTableCell24.Weight = 0.26514217262484568D;
        // 
        // xrLabel27
        // 
        this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "fax", "Fax: {0}")});
        this.xrLabel27.Dpi = 100F;
        this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(458.6252F, 233.5F);
        this.xrLabel27.Name = "xrLabel27";
        this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel27.SizeF = new System.Drawing.SizeF(336.3748F, 22.99995F);
        this.xrLabel27.StylePriority.UseTextAlignment = false;
        this.xrLabel27.Text = "xrLabel27";
        this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel25
        // 
        this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tel", "Tel: {0}")});
        this.xrLabel25.Dpi = 100F;
        this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(131.8749F, 233.5F);
        this.xrLabel25.Name = "xrLabel25";
        this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel25.SizeF = new System.Drawing.SizeF(316.9171F, 22.99997F);
        this.xrLabel25.StylePriority.UseTextAlignment = false;
        this.xrLabel25.Text = "xrLabel25";
        this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel24
        // 
        this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "diachi", "Address: {0}")});
        this.xrLabel24.Dpi = 100F;
        this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(131.0415F, 210.5F);
        this.xrLabel24.Name = "xrLabel24";
        this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel24.SizeF = new System.Drawing.SizeF(661.9585F, 23.00002F);
        this.xrLabel24.StylePriority.UseTextAlignment = false;
        this.xrLabel24.Text = "xrLabel24";
        this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel18
        // 
        this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "customer_order_no", "Customer\'s order no.: {0}")});
        this.xrLabel18.Dpi = 100F;
        this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 325.5F);
        this.xrLabel18.Name = "xrLabel18";
        this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel18.SizeF = new System.Drawing.SizeF(794.9999F, 23.00003F);
        this.xrLabel18.StylePriority.UseTextAlignment = false;
        this.xrLabel18.Text = "Customer\'s order no.:";
        this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel17
        // 
        this.xrLabel17.Dpi = 100F;
        this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 302.5F);
        this.xrLabel17.Name = "xrLabel17";
        this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel17.SizeF = new System.Drawing.SizeF(794.9999F, 23.00003F);
        this.xrLabel17.StylePriority.UseTextAlignment = false;
        this.xrLabel17.Text = "VINH GIA Company agrees to sale and the Buyer agrees to buy the goods under terms and" +
" conditions as follows:";
        this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel48,
            this.xrLabel34,
            this.ghichu,
            this.hoahong,
            this.nguoinhan,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel16,
            this.xrLabel35,
            this.xrLabel15,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel33,
            this.xrLabel28,
            this.xrLabel26,
            this.xrLabel30,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel19,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLabel42,
            this.xrLabel43,
            this.xrLabel41,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel29,
            this.xrLabel46,
            this.xrLabel47});
        this.ReportFooter.Dpi = 100F;
        this.ReportFooter.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.ReportFooter.HeightF = 446.0416F;
        this.ReportFooter.Name = "ReportFooter";
        this.ReportFooter.StylePriority.UseBorderColor = false;
        this.ReportFooter.StylePriority.UseFont = false;
        // 
        // xrLabel48
        // 
        this.xrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ten_paymentterm")});
        this.xrLabel48.Dpi = 100F;
        this.xrLabel48.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(126.2084F, 314.2916F);
        this.xrLabel48.Name = "xrLabel48";
        this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel48.SizeF = new System.Drawing.SizeF(668.1248F, 23F);
        this.xrLabel48.StylePriority.UseFont = false;
        this.xrLabel48.StylePriority.UseTextAlignment = false;
        this.xrLabel48.Text = "[ten_paymentterm]";
        this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel34
        // 
        this.xrLabel34.Dpi = 100F;
        this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(0F, 184.2913F);
        this.xrLabel34.Multiline = true;
        this.xrLabel34.Name = "xrLabel34";
        this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel34.SizeF = new System.Drawing.SizeF(45.54837F, 32.00015F);
        this.xrLabel34.StylePriority.UseFont = false;
        this.xrLabel34.StylePriority.UseTextAlignment = false;
        this.xrLabel34.Text = "Note:";
        this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // ghichu
        // 
        this.ghichu.AutoWidth = true;
        this.ghichu.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ghichu")});
        this.ghichu.Dpi = 100F;
        this.ghichu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.ghichu.LocationFloat = new DevExpress.Utils.PointFloat(46.38181F, 184.2913F);
        this.ghichu.Multiline = true;
        this.ghichu.Name = "ghichu";
        this.ghichu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.ghichu.SizeF = new System.Drawing.SizeF(748.6182F, 32.00023F);
        this.ghichu.StylePriority.UseFont = false;
        this.ghichu.StylePriority.UseTextAlignment = false;
        this.ghichu.Text = "[ghichu]";
        this.ghichu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // hoahong
        // 
        this.hoahong.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "hoahong", "Hoa hồng: {0:#0.00}%")});
        this.hoahong.Dpi = 100F;
        this.hoahong.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.hoahong.LocationFloat = new DevExpress.Utils.PointFloat(412.5518F, 115.2914F);
        this.hoahong.Multiline = true;
        this.hoahong.Name = "hoahong";
        this.hoahong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.hoahong.SizeF = new System.Drawing.SizeF(155.1957F, 22.99999F);
        this.hoahong.StylePriority.UseFont = false;
        this.hoahong.StylePriority.UseTextAlignment = false;
        this.hoahong.Text = "xrLabel29";
        this.hoahong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // nguoinhan
        // 
        this.nguoinhan.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nguoinhan", "Người nhận: {0}")});
        this.nguoinhan.Dpi = 100F;
        this.nguoinhan.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.nguoinhan.LocationFloat = new DevExpress.Utils.PointFloat(568.4141F, 115.2914F);
        this.nguoinhan.Multiline = true;
        this.nguoinhan.Name = "nguoinhan";
        this.nguoinhan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.nguoinhan.SizeF = new System.Drawing.SizeF(225.9191F, 23.00002F);
        this.nguoinhan.StylePriority.UseFont = false;
        this.nguoinhan.StylePriority.UseTextAlignment = false;
        this.nguoinhan.Text = "xrLabel29";
        this.nguoinhan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // rptInDonHang
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter,
            this.ReportHeader});
        this.Margins = new System.Drawing.Printing.Margins(16, 16, 12, 0);
        this.PageHeight = 1169;
        this.PageWidth = 827;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Version = "17.2";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
