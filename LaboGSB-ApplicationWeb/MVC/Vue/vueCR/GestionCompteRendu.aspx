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
        <><asp:Menu ID="Menu1" runat="server" Height="140px" Width="143px" OnMenuItemClick="Menu1_MenuItemClick">
            <Items>
                <asp:MenuItem Text="Fichier" Value="Fichier">
                    <asp:MenuItem Text="Quitter" Value="Quitter"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Outils" Value="Outils">
                    <asp:MenuItem Text="Recherche..." Value="Recherche...">
                        <asp:MenuItem Text="Contact" Value="Contact"></asp:MenuItem>
                        <asp:MenuItem Text="Entreprise" Value="Entreprise"></asp:MenuItem>
                        <asp:MenuItem Text="Ville" Value="Ville"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
&nbsp;<asp:Panel ID="Panel1" runat="server" Height="97px">
                <p>
                    <asp:Button ID="ButtonCompteRendu" runat="server" Text="Compte-Rendu" Height="39px" />
                    <asp:Button ID="ButtonGestionFrais" runat="server" style="margin-top: 0px" Text="Gestion fiche de frais" />
                </p>
                <asp:Button ID="ButtonFormEtablissement" runat="server" Text="Ajouter Etablissement" OnClick="Button2_Click" />
                <asp:Button ID="ButtonFormContact" runat="server" Text="Ajouter Contact" />

            </asp:Panel>
        </>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="347px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="nom" HeaderText="nom" SortExpression="nom" />
                <asp:BoundField DataField="adresse" HeaderText="adresse" SortExpression="adresse" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                <asp:BoundField DataField="contact" HeaderText="contact" ReadOnly="True" SortExpression="contact" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:gsb-gestionConnectionString %>" SelectCommand="SELECT nom, adresse, type, STUFF((SELECT DISTINCT '\' + p.nom AS Expr1 FROM personne INNER JOIN travailpour ON e.id = travailpour.idEtablissement INNER JOIN personne AS p ON travailpour.idContact = p.id FOR XML PATH('')), 1, 1, '') AS contact FROM etablissement AS e"></asp:SqlDataSource>
    </form>
</body>
</html>
