using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class LayoutCalculadora : System.Web.UI.Page
    {
        public double valor1 { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "3";
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "4";
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "5";
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "6";
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "7";
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "8";
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "9";
        }

        protected void btnVirgula_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += ",";
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            TtxtDysplay.Text += "0";
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {

        }

        protected void btnMais_Click(object sender, EventArgs e)
        {

        }
    }
}