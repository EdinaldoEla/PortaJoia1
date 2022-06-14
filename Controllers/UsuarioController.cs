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
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuarioSessao = ur.ValidarLogin(user);

            if (usuarioSessao == null)
            {
                //usuario não localizado
                ViewBag.mensagem = "Usuário não localizado!";
                return View();
            }
            else
            {
                ViewBag.mensagem = "Você está logado!";

                //registra os dados da sessao
                HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.Id);
                //HttpContext.Session.SetString("NomeUsuario", usuarioSessao.Nome);
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Logout()
        {
            //1 - limpar os dados da sessão
            HttpContext.Session.Clear();

            //2 - redicionamento
            return View("Login");
        }
        public IActionResult Lista()
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> lista = ur.Lista();
            return View(lista);
        }

        public IActionResult Excluir(int Id)
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }

            UsuarioRepository ur = new UsuarioRepository();
            Usuario UsuarioEncontrado = ur.BuscarPorId(Id);
            if (UsuarioEncontrado.Id > 0)
            {
                ur.Remover(UsuarioEncontrado);
            }
            else
            {
                ViewData["mensagem"] = "Usuário não localizado";
            }

            return RedirectToAction("Lista");
        }
        public IActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Inserir(Usuario novoUser)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ViewData["mensagem"] = "Cadastro realizado com sucesso.";
            ur.Inserir(novoUser);

            return RedirectToAction("Login", "Usuario");
        }

        public IActionResult Alterar(int Id)
        {
            //Validando se o usuário está logado, caso não esteja direciona para Login
            if (HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login", "Usuario");
            }
            UsuarioRepository ur = new UsuarioRepository();
            Usuario UsuarioEncontrado = ur.BuscarPorId(Id);
            if (UsuarioEncontrado.Id < 0)
            {
                ViewData["mensagem"] = "Usuário não localizado";
            }
            return View(UsuarioEncontrado);
        }
        [HttpPost]
        public IActionResult Alterar(Usuario userAlter)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.Atualizar(userAlter);

            return RedirectToAction("Lista");
        }
    }
}