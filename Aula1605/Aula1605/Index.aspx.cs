using Aula1605.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1605
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            chkAtivo.Checked = false;
            txtDescricao.Text = string.Empty;

            if (ViewState["controle"] == null)
            {
                ViewState.Add("controle", "1"); //Funciona apenas enquanto está na mesma pagina. Ele cria um dicionario temporario, Key | Value        
            }else
            {
                int quantidadeClique = (int)ViewState["controle"];
                quantidadeClique++;
                ViewState["controle"] = quantidadeClique;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            projeto.Nome = txtNome.Text;
            projeto.Ativo = chkAtivo.Checked;
            projeto.Descricao = txtDescricao.Text;

            ViewState.Remove("controle");

        }
    }
}