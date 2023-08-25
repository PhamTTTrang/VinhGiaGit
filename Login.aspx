﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>An Co Emanagement 3.0</title>
    <style>
        body *
        {
        	font-family:Arial;
        	font-size:10pt;
        }
        
        input
        {
        	padding:5px;
        }
        
        .bg
        {
        	background:url('images/login/bg.jpg') repeat-x;
        }
        .form
        {
        	margin:92px 0 0 100px;
        	position:relative;
        	width:776px; 
        	height:405px; 
        	background:url('images/login/form.jpg') no-repeat
        }
        
        .form-content
        {
            position: absolute;
            top:125px;
            left: 140px;	
        }

        .inputFormLogin {
            color: #00862d;
        }
    </style>
</head>
<body class="bg">
    <div class="form">
        <form id="form1" runat="server">
                <div class="form-content">
                    <table>
                        <tr>
                            <td><label for="txtUserName" class="inputFormLogin">Tên Đăng Nhập</label></td>
                        </tr>
                        <tr>
                            <td><asp:TextBox Width="280" ID="txtUserName" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><div style="height: 3px;"></div></td>
                        </tr>
                        <tr>
                            <td><label for="txtPassword" class="inputFormLogin">Mật Khẩu</label></td>
                        </tr>
                        <tr>
                            <td><asp:TextBox Width="280" ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><div style="height: 6px;"></div></td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="btnLogin" OnClick='btnLogin_Click' runat="server" Text="Đăng Nhập" /></td>
                        </tr>
                    </table>
                </div>
        </form>
    </div>
    
</body>
</html>
