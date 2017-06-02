using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho0106.Models;

namespace Trabalho0106.Controllers
{
    public class JogoBean
    {
        private static Entities contexto = new Entities();

        public static void Adicionar(Jogo jogo)
        {
            if (GeneroBean.LocalizarPorID(jogo.GeneroId) != null)
            {
                contexto.Jogo.Add(jogo);
                contexto.SaveChanges();
            }
        }
        public static List<Jogo> Listar()
        {
            return contexto.Jogo.ToList();
        }
        public static Jogo LocalizarPorID(int id)
        {
            return contexto.Jogo.Find(id);
        }
        public static Jogo LocalizarPorNome(string Nome)
        {
            return contexto.Jogo.Where(x => x.Nome.Contains(Nome)).FirstOrDefault();
        }
        public static void Editar(Jogo jogo)
        {
            contexto.Entry(jogo).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public static void Excluir(Jogo jogo)
        {
            contexto.Entry(jogo).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}