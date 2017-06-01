using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trabalho0106.Controllers;
using Trabalho0106.Models;

namespace Trabalho0106.View
{
    public partial class Main : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            gdGenero.DataSource = GeneroBean.Listar();
            gdGenero.DataBind();
            gdJogo.DataSource = JogoBean.Listar();
            gdJogo.DataBind();
        }

        protected void btnAddG_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero
            {
                Nome = txtNomeG.Text,
                Descricao = txtDescricaoG.Text
            };
            GeneroBean.Adicionar(genero);

            txtDescricaoG.Text = string.Empty;
            txtNomeG.Text = string.Empty;
            Response.Redirect("~/View/Main");
        }

        protected void btnLimparG_Click(object sender, EventArgs e)
        {
            txtDescricaoG.Text = string.Empty;
            txtNomeG.Text = string.Empty;
        }

        protected void btnLocalizarG_Click(object sender, EventArgs e)
        {
            string nome = txtNomeG.Text;

            txtNomeG.Text = GeneroBean.LocalizarPorNome(nome).Nome;
            txtDescricaoG.Text = GeneroBean.LocalizarPorNome(nome).Descricao;
            Session.Add("genero", GeneroBean.LocalizarPorNome(nome));
        }

        protected void btnEditarG_Click(object sender, EventArgs e)
        {
            Genero generoEditar = (Genero)Session["genero"];
            generoEditar.Nome = txtNomeG.Text;
            generoEditar.Descricao = txtDescricaoG.Text;

            GeneroBean.Editar(generoEditar);
        }

        protected void btnExcluirG_Click(object sender, EventArgs e)
        {
            Genero generoEditar = (Genero)Session["genero"];
            GeneroBean.Excluir(generoEditar);
        }

        //Cadastro de jogo

        protected void btnAddJ_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo
            {
                Nome = txtNomeJ.Text,
                Descricao = txtDescricaoJ.Text,
                Lancamento = txtLancamento.Text,
                IdGenero = Convert.ToInt32(txtGeneroJ.Text)
            };
            JogoBean.Adicionar(jogo);

            txtDescricaoJ.Text = string.Empty;
            txtNomeJ.Text = string.Empty;
            txtLancamento.Text = string.Empty;
            txtGeneroJ.Text = string.Empty;
            Response.Redirect("~/View/Main");
        }

        protected void btnLimparJ_Click(object sender, EventArgs e)
        {
            txtDescricaoJ.Text = string.Empty;
            txtNomeJ.Text = string.Empty;
            txtLancamento.Text = string.Empty;
            txtGeneroJ.Text = string.Empty;
        }

        protected void btnLocalizarJ_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJ.Text;

            txtNomeJ.Text = JogoBean.LocalizarPorNome(nome).Nome;
            txtDescricaoJ.Text = JogoBean.LocalizarPorNome(nome).Descricao;
            txtLancamento.Text = JogoBean.LocalizarPorNome(nome).Lancamento;
            txtGeneroJ.Text = Convert.ToString(JogoBean.LocalizarPorNome(nome).IdGenero);

            Session.Add("Jogo", JogoBean.LocalizarPorNome(nome));
        }

        protected void btnEditarJ_Click(object sender, EventArgs e)
        {
            Jogo jogoEditar = (Jogo)Session["Jogo"];
            jogoEditar.Nome = txtNomeJ.Text;
            jogoEditar.Descricao = txtDescricaoJ.Text;
            jogoEditar.Lancamento = txtLancamento.Text;
            jogoEditar.IdGenero = Convert.ToInt32(txtGeneroJ);

            JogoBean.Editar(jogoEditar);
        }

        protected void btnExcluirJ_Click(object sender, EventArgs e)
        {
            Jogo jogoEditar = (Jogo)Session["Jogo"];
            JogoBean.Excluir(jogoEditar);
        }
    }
}