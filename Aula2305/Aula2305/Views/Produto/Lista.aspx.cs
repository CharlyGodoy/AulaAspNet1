using Aula2305.Models;
using Aula2305.Views.Base;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Aula2305.Views.Produto
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvProdutos.DataSource = contexto.Produto.ToList();

            gvProdutos.DataBind();
        }
    }
}