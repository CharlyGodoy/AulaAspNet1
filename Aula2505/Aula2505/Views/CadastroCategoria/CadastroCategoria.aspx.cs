using Aula2505.Controllers;
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
            gdCategorias.DataSource = CategoriasController.Listar();
            gdCategorias.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Ativo = cbAtivo.Checked
            };

            CategoriasController.Adicionar(categoria);
                txtNome.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                Response.Redirect("~/Views/CadastroCategoria/CadastroCategoria");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        protected void btnLocalizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            txtNome.Text = CategoriasController.LocalizarPorNome(nome).Nome;
            txtDescricao.Text = CategoriasController.LocalizarPorNome(nome).Descricao;
            cbAtivo.Checked = CategoriasController.LocalizarPorNome(nome).Ativo;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            CategoriasController.Editar(CategoriasController.LocalizarPorNome(txtNome.Text));
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            CategoriasController.Excluir(CategoriasController.LocalizarPorNome(txtNome.Text));
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}