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
            CarregarGridGenero();
            CarregarGridJogo();
        }

        protected void btnAddG_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero
            {
                Nome = txtNomeG.Text,
                Descricao = txtDescricaoG.Text
            };
            GeneroBean.Adicionar(genero);

            LimparCamposGenero();
            CarregarGridGenero();
        }

        protected void btnLimparG_Click(object sender, EventArgs e)
        {
            LimparCamposGenero();

            btnAddG.Enabled = true;
            btnEditarG.Enabled = false;
            btnExcluirG.Enabled = false;
        }

        protected void btnLocalizarG_Click(object sender, EventArgs e)
        {
            string nome = txtNomeG.Text;

            txtNomeG.Text = GeneroBean.LocalizarPorNome(nome).Nome;
            txtDescricaoG.Text = GeneroBean.LocalizarPorNome(nome).Descricao;
            Session.Add("genero", GeneroBean.LocalizarPorNome(nome));

            btnAddG.Enabled = false;
            btnEditarG.Enabled = true;
            btnExcluirG.Enabled = true;
        }

        protected void btnEditarG_Click(object sender, EventArgs e)
        {
            Genero generoEditar = (Genero)Session["genero"];
            generoEditar.Nome = txtNomeG.Text;
            generoEditar.Descricao = txtDescricaoG.Text;

            GeneroBean.Editar(generoEditar);
            LimparCamposGenero();
            CarregarGridGenero();

            btnAddG.Enabled = true;
            btnEditarG.Enabled = false;
            btnExcluirG.Enabled = false;
        }

        protected void btnExcluirG_Click(object sender, EventArgs e)
        {
            Genero generoEditar = (Genero)Session["genero"];
            GeneroBean.Excluir(generoEditar);
            LimparCamposGenero();
            CarregarGridGenero();

            btnAddG.Enabled = true;
            btnEditarG.Enabled = false;
            btnExcluirG.Enabled = false;
        }

        //Cadastro de jogo

        protected void btnAddJ_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo
            {
                Nome = txtNomeJ.Text,
                Descricao = txtDescricaoJ.Text,
                Lancamento = txtLancamento.Text,
                GeneroId = Convert.ToInt32(GeneroBean.LocalizarPorNome(ddpGenero.SelectedItem.Text).Id)
                //GeneroId = Convert.ToInt32(txtGeneroJ.Text)
            };
            JogoBean.Adicionar(jogo);

            LimparCamposJogo();
            CarregarGridGenero();

        }

        protected void btnLimparJ_Click(object sender, EventArgs e)
        {
            LimparCamposJogo();

            btnAddJ.Enabled = true;
            btnEditarJ.Enabled = false;
            btnExcluirJ.Enabled = false;
        }

        protected void btnLocalizarJ_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJ.Text;

            txtNomeJ.Text = JogoBean.LocalizarPorNome(nome).Nome;
            txtDescricaoJ.Text = JogoBean.LocalizarPorNome(nome).Descricao;
            txtLancamento.Text = JogoBean.LocalizarPorNome(nome).Lancamento;
            txtGeneroJ.Text = Convert.ToString(JogoBean.LocalizarPorNome(nome).GeneroId);

            Session.Add("Jogo", JogoBean.LocalizarPorNome(nome));

            btnAddJ.Enabled = false;
            btnEditarJ.Enabled = true;
            btnExcluirJ.Enabled = true;
        }

        protected void btnEditarJ_Click(object sender, EventArgs e)
        {
            Jogo jogoEditar = (Jogo)Session["Jogo"];
            jogoEditar.Nome = txtNomeJ.Text;
            jogoEditar.Descricao = txtDescricaoJ.Text;
            jogoEditar.Lancamento = txtLancamento.Text;
            jogoEditar.GeneroId = Convert.ToInt32(txtGeneroJ.Text);

            JogoBean.Editar(jogoEditar);
            LimparCamposJogo();
            CarregarGridGenero();

            btnAddJ.Enabled = true;
            btnEditarJ.Enabled = false;
            btnExcluirJ.Enabled = false;
        }

        protected void btnExcluirJ_Click(object sender, EventArgs e)
        {
            Jogo jogoEditar = (Jogo)Session["Jogo"];
            JogoBean.Excluir(jogoEditar);
            LimparCamposJogo();
            CarregarGridGenero();

            btnAddJ.Enabled = true;
            btnEditarJ.Enabled = false;
            btnExcluirJ.Enabled = false;
        }

        protected void CarregarGridGenero()
        {
            gdGenero.DataSource = GeneroBean.Listar();
            gdGenero.DataBind();

            foreach (Genero item in GeneroBean.Listar())
            {
                ddpGenero.Items.Add(item.Nome);
            };
        }

        protected void CarregarGridJogo()
        {
            gdJogo.DataSource = JogoBean.Listar();
            gdJogo.DataBind();
        }

        protected void LimparCamposGenero()
        {
            txtDescricaoG.Text = string.Empty;
            txtNomeG.Text = string.Empty;
        }
        protected void LimparCamposJogo()
        {
            txtDescricaoJ.Text = string.Empty;
            txtNomeJ.Text = string.Empty;
            txtLancamento.Text = string.Empty;
            txtGeneroJ.Text = string.Empty;
        }
    }
}