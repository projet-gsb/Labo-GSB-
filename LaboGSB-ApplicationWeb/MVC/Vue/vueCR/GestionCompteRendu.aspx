<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionCompteRendu.aspx.cs" Inherits="LaboGSB_ApplicationWeb.MVC.Vue.vueCR.GestionCompteRendu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Gestion des Comptes-Rendus</title>
</head>
<body>
    <h2>Gestion Compte-Rendu</h2>
    <form id="form1" runat="server">
        <>
            <asp:Panel ID="Panel1" runat="server" Height="97px">
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Compte-Rendu" Height="39px" />
                </p>
                <asp:Button ID="Button2" runat="server" Text="Ajouter Etablissement" />
                <asp:Button ID="Button3" runat="server" Text="Ajouter Contact" />

            </asp:Panel>
        </>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
