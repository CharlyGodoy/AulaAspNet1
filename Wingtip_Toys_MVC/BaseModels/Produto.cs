using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Produto
    {
        [Key]             //Chave primaria
        public int ProdutoID { get; set; }
        [Required]        // Campo not null
        [StringLength(20)]//Tamanho maximo da string
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }

        // -- Relacionamento Categoria --> Produto
        public int CategoriaID { get; set; }
        public virtual Categoria _Categoria { get; set; }

    }
}
