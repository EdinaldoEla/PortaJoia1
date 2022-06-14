using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atv_4.Models;

namespace Atv_4.Controllers
{
    public class TrabalheConoscoController : Controller
    {
        public IActionResult Lista()
        {
            TrabalheConoscoRepository tr = new TrabalheConoscoRepository();
            List<TrabalheConosco> lista = tr.Listar();
            return View(lista);
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(TrabalheConosco novoColab)
        {
            TrabalheConoscoRepository tr = new TrabalheConoscoRepository();
            tr.Inserir(novoColab);

            ViewData["mensagem"] = "Cadastro realizado com sucesso";
            return View();
        }
        public IActionResult Excluir(int Id)
        {
            TrabalheConoscoRepository tr = new TrabalheConoscoRepository();
            TrabalheConosco ColaborarEnconrado = tr.BuscarPorId(Id);
            if(ColaborarEnconrado.Id>0)
            {
                tr.Remover(ColaborarEnconrado);
            }
            else
            {
                ViewData["mensagem"] = "Colaborador não localizado";
            }
            return RedirectToAction("Lista");
        }

        public IActionResult Alterar(int Id)
        {
            TrabalheConoscoRepository tr = new TrabalheConoscoRepository();
            TrabalheConosco ColaboradorEncontrado = tr.BuscarPorId(Id);
            if (ColaboradorEncontrado.Id < 0)
            {
                ViewData["mensagem"] = "Colaborador não localizado";
            }
            return View(ColaboradorEncontrado);
        }
        [HttpPost]
        public IActionResult Alterar(TrabalheConosco ColabAlter)
        {
            TrabalheConoscoRepository tr = new TrabalheConoscoRepository();
            tr.Atualizar(ColabAlter);
            return RedirectToAction("Lista");
        }
    }
}