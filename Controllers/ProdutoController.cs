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
    public class ProdutoController : Controller
    {
        public IActionResult Lista()
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            ProdutoRepository pr = new ProdutoRepository();
            List<Produto> lista = pr.ListaProduto();
            return View(lista);
        }
        public IActionResult Listagem()
        {
            ProdutoRepository pr = new ProdutoRepository();
            List<Produto> listagem = pr.ListaProduto();
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
        public IActionResult Inserir(Produto novoProd)
        {
            ProdutoRepository pr = new ProdutoRepository();
            pr.Inserir(novoProd);

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
            ProdutoRepository pr = new ProdutoRepository();
            Produto ProdutoEncontrado = pr.BuscarPorId(Id);

            if (ProdutoEncontrado.IdProduto < 0)
            {
                ViewData["mensagem"] = "Produto não localizado";
            }
            return View(ProdutoEncontrado);
        }
        [HttpPost]
        public IActionResult Alterar(Produto ProdAlter)
        {
            ProdutoRepository pr = new ProdutoRepository();
            pr.Atualizar(ProdAlter);
            return RedirectToAction("Lista");
        }
        public IActionResult Excluir(int Id)
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            ProdutoRepository pr = new ProdutoRepository();
            Produto ProdutoEnconrado = pr.BuscarPorId(Id);
            if (ProdutoEnconrado.IdProduto > 0)
            {
                pr.Remover(ProdutoEnconrado);
            }
            else
            {
                ViewData["mensagem"] = "Serviço não localizado";
            }
            return RedirectToAction("Lista");
        }
    }
}