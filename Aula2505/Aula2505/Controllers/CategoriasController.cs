using Aula2505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2505.Controllers
{
    public class CategoriasController
    {
        private static BaseDadosContainer contexto = new BaseDadosContainer();

        public static void Adicionar(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
        }
        public static List<Categoria> Listar()
        {
            return contexto.Categorias.ToList();
        }
        public static Categoria LocalizarPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }
        public static Categoria LocalizarPorNome(string Nome)
        {
            return contexto.Categorias.Where(x => x.Nome.Contains(Nome)).FirstOrDefault();
        }
        public static void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public static void Excluir(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}