﻿using CondS.PIM.Modelo;
using CondS.PIM.Repositorio;
using System.Web.Mvc;

namespace CondS.PIM.UI.WEB.Controllers
{
    public class HomeController : Controller
    {
        //Instanciando repositorio
        usuarioREP usuarioREP = new usuarioREP();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //Quando for postar, passar para o modelo 
        public ActionResult Index(usuarioMOD dadosDaTela)
        {
            usuarioREP.Cadastrar(dadosDaTela);
            return View();
        }
    }
}