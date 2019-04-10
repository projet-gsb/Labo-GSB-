<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connexion.aspx.cs" Inherits="LaboGSB_ApplicationWeb.MVC.Vue.vueCR.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Connexion aux Labos GSB</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Connexion</h2>

        <label>Utilisateur</label>
        <input type="text" id="txt_pseudo" />
        <br />


        <label>Mot de passe</label>
        <input type="text" id="txt_mdp" />
        <br />

        <input type="checkbox" id="chk_connexion" />
        <label>Connexion automatique</label>
        <a href="#">Mot de passe oublié ?</a>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Connexion" OnCommand="Button1_Command" />



    </form>
</body>
</html>
