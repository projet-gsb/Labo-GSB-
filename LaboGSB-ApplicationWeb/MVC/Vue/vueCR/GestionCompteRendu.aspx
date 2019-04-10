<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionCompteRendu.aspx.cs" Inherits="LaboGSB_ApplicationWeb.MVC.Vue.vueCR.GestionCompteRendu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        

    </title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Gestion Compte-Rendu</h1>
        <div>
            </div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="371px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="nom" HeaderText="nom" SortExpression="nom" />
                <asp:BoundField DataField="adresse" HeaderText="adresse" SortExpression="adresse" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gsb-gestionConnectionString %>" SelectCommand="SELECT [nom], [adresse], [type] FROM [etablissement]"></asp:SqlDataSource>
    </form>
</body>
</html>
