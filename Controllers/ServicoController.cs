using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Atv_4.Models;

namespace Atv_4.Controllers
{
    public class ServicoController : Controller
    {
        public IActionResult Lista()
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            ServicoRepository sr = new ServicoRepository();
            List<Servico> lista = sr.Listar();
            return View(lista);
        }

        public IActionResult Listagem()
        {
            ServicoRepository sr = new ServicoRepository();
            List<Servico> listagem = sr.Listar();
            return View(listagem);
        }
        
        public IActionResult Inserir()
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Inserir(Servico novoServ)
        {
            ServicoRepository sr = new ServicoRepository();
            sr.Inserir(novoServ);

            ViewData["mensagem"] = "Cadastro realizado com sucesso";
            return RedirectToAction("Lista");
        }

        public IActionResult Alterar(int Id)
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            ServicoRepository sr = new ServicoRepository();
            Servico ServicoEncontrado = sr.BuscarPorId(Id);

            if (ServicoEncontrado.IdServico < 0)
            {
                ViewData["mensagem"] = "Serviço não localizado";
            }
            return View(ServicoEncontrado);
        }
        [HttpPost]
        public IActionResult Alterar(Servico ServAlter)
        {
            ServicoRepository sr = new ServicoRepository();
            sr.Atualizar(ServAlter);
            return RedirectToAction("Lista");
        }
        public IActionResult Excluir(int Id)
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            ServicoRepository sr = new ServicoRepository();
            Servico ServicoEnconrado = sr.BuscarPorId(Id);
            if (ServicoEnconrado.IdServico > 0)
            {
                sr.Remover(ServicoEnconrado);
            }
            else
            {
                ViewData["mensagem"] = "Serviço não localizado";
            }
            return RedirectToAction("Lista");
        }
    }
}