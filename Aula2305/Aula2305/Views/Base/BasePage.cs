using Aula2305.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2305.Views.Base
{
    public class BasePage : System.Web.UI.Page
    {
        // context (referencia para o banco de dados)
        protected LojaDBEntities contexto = new LojaDBEntities();
    }
}