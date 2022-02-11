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
    public class ContasApiController : ControllerBase
    {
        private readonly ContextoDb context;

        public ContasApiController(ContextoDb context)
        {
            this.context = context;
        }

        [Route("/api/conta/cadastrar")]
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

            return StatusCode(201, conta);
        }

        [Route("/api/conta")]
        public IActionResult Lista()
        {
            return StatusCode(200, context.Contas.Include("Cliente").ToList());
        }

        [Route("/api/conta/{id}/excluir")]
        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            var conta = context.Contas.Find(id);
            if (conta == null)
            {
                return StatusCode(404);
            }
            context.Contas.Remove(conta);
            context.SaveChanges();
            return StatusCode(204);
        }

        [Route("/api/conta/{id}")]
        [HttpGet]
        public IActionResult Mostrar(int id)
        {
            var conta = context.Contas.Include("Cliente").Where(c => c.Id == id).First();
            if (conta == null)
            {
                return StatusCode(404);
            }
            return StatusCode(200, conta);
        }

        [Route("api/conta/{id}/atualizar")]
        [HttpPut]
        public IActionResult Atualizar(int id, int clienteId, int agencia, int tipo, double saldo)
        {
            var conta = context.Contas.Find(id);
            if (conta == null)
            {
                return StatusCode(404);
            }

            conta.Agencia = agencia;
            conta.Tipo = tipo;
            conta.Saldo = saldo;
            conta.ClienteId = clienteId;
            context.Contas.Update(conta);
            context.SaveChanges();
            return StatusCode(200, conta);
        }
    }
}