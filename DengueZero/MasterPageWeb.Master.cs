using Excecao.AspectoBaseExcecao;
using System;

namespace DengueZero
{
    public partial class MasterPageWeb : System.Web.UI.MasterPage
    {
        private string SessionSite { get { return Session["Usuario"] != null ? Session["Usuario"].ToString() : string.Empty; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(SessionSite))
                //Response.Redirect("~/ModuloLogin.aspx");
        }

        protected void lnkSairSistema_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            //Response.Redirect("~/ModuloLogin.aspx");
        }

        protected void lnkMenuInicial_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MenuInicial.aspx");
        }
    }
}