using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho0106.Models;

namespace Trabalho0106.Controllers
{
    public class GeneroBean
    {
        private static Entities contexto = new Entities();

        public static void Adicionar(Genero genero)
        {
            contexto.Genero.Add(genero);
            contexto.SaveChanges();
        }
        public static List<Genero> Listar()
        {
            return contexto.Genero.ToList();
        }
        public static Genero LocalizarPorID(int id)
        {
            return contexto.Genero.Find(id);
        }
        public static Genero LocalizarPorNome(string Nome)
        {
            return contexto.Genero.Where(x => x.Nome.Contains(Nome)).FirstOrDefault();
        }
        public static void Editar(Genero genero)
        {
            contexto.Entry(genero).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public static void Excluir(Genero genero)
        {
            contexto.Entry(genero).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}