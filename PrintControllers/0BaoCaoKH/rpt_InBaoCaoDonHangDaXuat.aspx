﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rpt_InBaoCaoDonHangDaXuat.aspx.cs" Inherits="PrintControllers_0BaoCaoKH_rpt_InBaoCaoDonHangDaXuat" %>

<%@ Register assembly="DevExpress.XtraReports.v11.2.Web, Version=11.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<link rel="shortcut icon" href="images/logo/favicon.ico"/>
    <title>[eMan] <%=ReportViewer1.Report.DisplayName %></title>
    <style type="text/css">
        .reportDEX > .dxmLite.dxm-ltr{
            display:table;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="reportDEX" align="center">
    
        <dx:ReportToolbar ID="ReportToolbar1" runat="server" 
            ReportViewerID="ReportViewer1" ShowDefaultButtons="False">
            <Items>
                <dx:ReportToolbarButton ItemKind="Search" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="PrintReport" />
                <dx:ReportToolbarButton ItemKind="PrintPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                <dx:ReportToolbarLabel ItemKind="PageLabel" />
                <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarLabel ItemKind="OfLabel" />
                <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
                <dx:ReportToolbarButton ItemKind="NextPage" />
                <dx:ReportToolbarButton ItemKind="LastPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dx:ListElement Value="xls" />
                        <dx:ListElement Value="xlsx" />                        
                        <dx:ListElement Value="csv" />
						<dx:ListElement Value="pdf" />
						<dx:ListElement Value="html" />
                    </Elements>
                </dx:ReportToolbarComboBox>
            </Items>
        </dx:ReportToolbar>
        <dx:ReportViewer ID="ReportViewer1" runat="server" ReportName="XtraReport1">
        </dx:ReportViewer>
        <br />
    </div>
    </form>
</body>
</html>