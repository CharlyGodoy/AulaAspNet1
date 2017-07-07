using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula0607.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            //Database.SetInitializer<Contexto>(
            //    new CreateDatabaseIfNotExists<Contexto>()
            //    );
            
            //Database.SetInitializer<Contexto>(
            //    new DropCreateDatabaseAlways<Contexto>()
            //    );

            //Database.SetInitializer<Contexto>(
            //    new DropCreateDatabaseIfModelChanges<Contexto>()
            //    );

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}