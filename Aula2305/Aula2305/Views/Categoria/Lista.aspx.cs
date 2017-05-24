using Aula2305.Models;
using Aula2305.Views.Base;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Aula2305.Views.Categoria
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCategorias.DataSource = contexto.Categoria.ToList();

            gvCategorias.DataBind();
        }
    }
}