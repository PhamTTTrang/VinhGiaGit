﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XoaChungLoaiNHD.aspx.cs" Inherits="Tool_XoaChungLoaiNHD" %>

<script type="text/javascript">
    var exportSPTT = function (a, b, c) {
        var url = 'XuatDSHHNHD.aspx';
        var rptURL = url + "?cl=" + a + "&dt=" + b + '&ms=' + c;
        window.open(rptURL);
    };
</script>