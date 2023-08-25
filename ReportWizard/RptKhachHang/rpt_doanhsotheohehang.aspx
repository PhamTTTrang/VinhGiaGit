﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rpt_doanhsotheohehang.aspx.cs" Inherits="ReportWizard_RptKhachHang_rpt_doanhsotheohehang" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="../../jQuery/Core/jquery-1.7.1.min.js" type="text/javascript"></script>
<script type="text/javascript"> 
    $(function() {
         setTimeout( function(){  
             $('td#oReportCell', window.parent.frames[0].frames[1].document).next().remove();  
             $("#rpt-container").fadeIn();
          }, 300);  //slight delay to allow the iframe to load
     });
 </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="rpt-container" >
    
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="8pt" Height="561px" Width="861px">
            <LocalReport ReportPath="rpt_doanhsotheohehang.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" 
                        Name="anco_test_importDataSet_rpt_doanhsotheohehang" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            OldValuesParameterFormatString="original_{0}" 
            SelectMethod="rpt_doanhsotheohehang" 
            TypeName="anco_test_importDataSetTableAdapters.rpt_doanhsotheohehangTableAdapter">
            <SelectParameters>
                <asp:QueryStringParameter Name="startdate" QueryStringField="startdate" 
                    Type="DateTime" />
                <asp:QueryStringParameter Name="enddate" QueryStringField="enddate" 
                    Type="DateTime" />
                <asp:QueryStringParameter Name="trans" QueryStringField="trans" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
