﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connexion.aspx.cs" Inherits="LaboGSB_ApplicationWeb.MVC.Vue.vueCR.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 190px">
            <asp:Button ID="Connexion" runat="server" Text="Connexion" />
            <asp:Login ID="Login1" runat="server">
            </asp:Login>
        </div>
    </form>
</body>
</html>