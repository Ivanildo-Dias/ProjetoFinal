using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using ProjetoFinal.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ProjetoFinal.Controllers
{
    public class ContasController : Controller
    {
        private readonly ContextoDb context;

        public ContasController(ContextoDb context)
        {
            this.context = context;
        }

        [Route("/conta/cadastro")]
        public IActionResult Cadastro()
        {
            ViewBag.Clientes = context.Clientes.ToList();
            return View();
        }

        [Route("/conta/cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(int clienteId, int agencia, int tipo, double saldo)
        {
            Conta conta = new Conta();
            conta.Agencia = agencia;
            conta.Tipo = tipo;
            conta.Saldo = saldo;
            conta.ClienteId = clienteId;

            context.Contas.Add(conta);
            context.SaveChanges();

            return Redirect("/conta/lista");
        }

        [Route("/conta/lista")]
        public IActionResult Lista()
        {
            ViewBag.Contas = context.Contas.Include("Cliente").ToList();
            return View();
        }

        [Route("/conta/{id}/excluir")]
        public IActionResult Excluir(int id)
        {
            var conta = context.Contas.Find(id);
            if (conta == null)
            {
                return Redirect("/conta/lista");
            }
            context.Contas.Remove(conta);
            context.SaveChanges();
            return Redirect("/conta/lista");
        }

        [Route("/conta/{id}")]
        public IActionResult Editar(int id)
        {
            var conta = context.Contas.Find(id);
            if (conta == null) return Redirect("/conta/lista");
            ViewBag.Conta = conta;
            ViewBag.Clientes = context.Clientes.ToList();
            return View();
        }

        [Route("/conta/{id}/atualizar")]
        [HttpPost]
        public IActionResult Atualizar(int id, int clienteId, int agencia, int tipo, double saldo)
        {
            var conta = context.Contas.Find(id);
            if (conta == null)
            {
                return Redirect("/conta/lista");
            }

            conta.Agencia = agencia;
            conta.Tipo = tipo;
            conta.Saldo = saldo;
            conta.ClienteId = clienteId;
            context.Contas.Update(conta);
            context.SaveChanges();
            return Redirect("/conta/lista");
        }
    }
}