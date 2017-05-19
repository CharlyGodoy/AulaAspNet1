using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1805
{
    public partial class Calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Valor1"] != null && Session["Valor2"] != null)
                {
                    txtValor1Soma.Text = Session["Valor1"].ToString();
                    txtValor2Soma.Text = Session["Valor2"].ToString();
                    txtValor1Sub.Text = Session["Valor1"].ToString();
                    txtValor2Sub.Text = Session["Valor2"].ToString();
                    txtValor1Mult.Text = Session["Valor1"].ToString();
                    txtValor2Mult.Text = Session["Valor2"].ToString();
                    txtValor1Div.Text = Session["Valor1"].ToString();
                    txtValor2Div.Text = Session["Valor2"].ToString();

                    txtResultadoSoma.Text = (Convert.ToDouble(Session["Valor1"]) + Convert.ToDouble(Session["Valor2"])).ToString();
                    txtResultadoSub.Text = (Convert.ToDouble(Session["Valor1"]) - Convert.ToDouble(Session["Valor2"])).ToString();
                    txtResultadoMult.Text = (Convert.ToDouble(Session["Valor1"]) * Convert.ToDouble(Session["Valor2"])).ToString();
                    txtResultadoDiv.Text = (Convert.ToDouble(Session["Valor1"]) / Convert.ToDouble(Session["Valor2"])).ToString();
                }else
                {
                    Response.Redirect("~/Calc1.aspx");
                }
            }
            

        }
    }
}