using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805
{
    public partial class Calc1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(txtValor1.Text) + Convert.ToDouble(txtValor2.Text);

            ViewState.Add("Valor1", txtValor1.Text);
            ViewState.Add("Valor2", txtValor2.Text);
            ViewState.Add("Resultado", resultado);

            txtValor1.Text = ViewState["Valor1"].ToString();
            txtValor2.Text = ViewState["Valor2"].ToString();
            txtResultaDO.Text = ViewState["Resultado"].ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            Session["Valor1"] = txtValor1.Text;
            Session["Valor2"] = txtValor2.Text;
            Response.Redirect("~/Calc2.aspx");
        }
    }
}