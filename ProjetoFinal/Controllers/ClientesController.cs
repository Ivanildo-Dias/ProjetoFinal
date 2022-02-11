using ProjetoFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ProjetoFinal.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ContextoDb context;

        public ClientesController(ContextoDb context)
        {
            this.context = context;
        }

        [Route("/cliente/cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }

        [Route("/cliente/cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(string nome, string cpf, string telefone, string email)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Telefone = telefone;
            cliente.Email = email;

            context.Clientes.Add(cliente);
            context.SaveChanges();

            return Redirect("/cliente/lista");
        }
        [Route("/cliente/lista")]
        public IActionResult Lista()
        {
            ViewBag.Clientes = context.Clientes.ToList();
            return View();
        }

        [Route("cliente/{id}/excluir")]
        public IActionResult Excluir(int id)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente == null) return Redirect("/cliente/lista");
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return Redirect("/cliente/lista");
        }

        [Route("/cliente/{id}")]
        public IActionResult Editar(int id)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente == null) return Redirect("/cliente/lista");
            ViewBag.Cliente = cliente;
            return View();
        }

        [Route("/cliente/{id}/atualizar")]
        [HttpPost]
        public IActionResult Atualizar(int id, string nome, string cpf, string telefone, string email)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente == null) return Redirect("/cliente/lista");

            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Telefone = telefone;
            cliente.Email = email;
            context.Clientes.Update(cliente);
            context.SaveChanges();

            return Redirect("/cliente/lista");
        }
    }
}