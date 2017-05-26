using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2505.Views.CadastroCategoria
{
    public partial class CadastroCategoria : Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Ativo = cbAtivo.Checked
            };

                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
                txtNome.Text = string.Empty;
                txtDescricao.Text = string.Empty; 
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }
    }
}