using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using ProjetoFinal.Models;
using Newtonsoft.Json;

namespace ProjetoFinal.Controllers
{
    public class ClientesApiController : ControllerBase
    {
        private readonly ContextoDb context;

        public ClientesApiController(ContextoDb context)
        {
            this.context = context;
        }

        [Route("/api/cliente/cadastrar")]
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

            return StatusCode(201, cliente);
        }

        [Route("/api/cliente/{id}")]
        [HttpGet]
        public IActionResult Mostrar(int id)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente == null)
            {
                return StatusCode(404);
            }
            return StatusCode(200, cliente);
        }

        [Route("/api/cliente")]
        public IActionResult Lista()
        {
            return StatusCode(200, context.Clientes.ToList());
        }

        [Route("/api/cliente/{id}/excluir")]
        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente == null)
            {
                return StatusCode(404);
            }
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return StatusCode(204);
        }

        [Route("/api/cliente/{id}/atualizar")]
        [HttpPut]
        public IActionResult Atualizar(int id, string nome, string cpf, string telefone, string email)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente == null)
            {
                return StatusCode(404);
            }

            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.Telefone = telefone;
            cliente.Email = email;
            context.Clientes.Update(cliente);
            context.SaveChanges();
            return StatusCode(200, cliente);
        }
    }
}