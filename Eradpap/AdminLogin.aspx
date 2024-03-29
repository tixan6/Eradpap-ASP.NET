﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Eradpap.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="www/adminLogin.css" rel="stylesheet" />

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Панель администрации</title>
</head>
<body>

    <form id="form1" runat="server">
        <div class="login">

            <div class="label">
                <h1>Eradpap</h1>
                <p class="sty">Администрирование товара</p>
            </div>


            <div class="baground-input">
                <asp:Label Text="" ID="Error" CssClass="errorTxt" runat="server" />
                <div class="CenterItems">
                    <asp:TextBox runat="server" ID="LoginUser" placeholder="Логин" CssClass="input"/> <br />
                    <asp:TextBox runat="server" ID="PasswordUser" TextMode="Password" placeholder="Пароль" CssClass="input"/> <br />

                    <asp:Button Text="Войти" runat="server" CssClass="buttonSigin" OnClick="SetUpConnection"/>
                </div>
                

            </div>


       
        </div>
        
    </form>

</body>


</html>
