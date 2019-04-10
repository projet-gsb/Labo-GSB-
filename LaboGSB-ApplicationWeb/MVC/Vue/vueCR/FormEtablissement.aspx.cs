using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaboGSB_ApplicationWeb.MVC.Vue.vueCR
{
    public partial class FormEtablissement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Response.Write("<body><script>window.close();</script></body>"); //on ferme la fenetre et rien d'autre
        }

    }
}