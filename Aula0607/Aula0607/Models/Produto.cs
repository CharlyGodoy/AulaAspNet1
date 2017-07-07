using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula0607.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; }

        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }
    }
}