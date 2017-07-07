using Aula0607.Models;
using Aula0607.Relatorios.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula0607.Relatorios
{
    public partial class wfRelatorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarRelatorio();
            }
        }

        private void CarregarRelatorio()
        {
            rvVisualizador.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;


            //Limpando DataSource
            rvVisualizador.LocalReport.DataSources.Clear();

            //Escolhendo qual relatorio
            rvVisualizador.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath + @"Relatorios\Reports\rptProdutosAnaliticos.rdlc");

            //Consultando os dados
            Contexto db = new Contexto();

            var resultadoConsulta = db.Produtos.ToList();

            dsRelatorioProdutosAnalitico dataSet = new dsRelatorioProdutosAnalitico();

            foreach (Produto p in resultadoConsulta)
            {
                dataSet.dtProdutosAnaliticos.AdddtProdutosAnaliticosRow(
                    p.Nome, p.Descricao, p.Preco, p._Categoria.Nome
                    );
            }

            //Informandoo dataset para o relatorio
            rvVisualizador.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("dsProdutos", (DataTable)dataSet.dtProdutosAnaliticos));

            rvVisualizador.LocalReport.Refresh();
        }
    }
}