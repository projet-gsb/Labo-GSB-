<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormEtablissement.aspx.cs" Inherits="LaboGSB_ApplicationWeb.MVC.Vue.vueCR.FormEtablissement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulaire Etablissement</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <h1>Ajouter un Etablissement</h1>
        </div>

        <fieldset id="section-1">
            <legend>Informations Etablissement :</legend>

            <p>
                <label for="nom">Nom :</label>
                <input type="text" name="nom" />
            </p>

            <p>
                <label for="adresse">Adresse :</label>
                <input type="text" name="adresse" />
            </p>

            <p>
                <label for="numeroTelephone">NumeroTelephone :</label>
                <input type="text" name="numeroTelephone" />
            </p>

            <p>
                <label for="mel">Mel :</label>
                <input type="email" name="mel" value="email@gsb.com" />
            </p>

            <p>
                <label for="type">Type :</label>
                <input type="text" name="type" />
            </p>

        </fieldset>

        <fieldset id="section-2">
            <asp:Button ID="Button1" runat="server" Text="Valider" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Annuler" OnClick="Button2_Click" />
        </fieldset>
    </form>
</body>
</html>
