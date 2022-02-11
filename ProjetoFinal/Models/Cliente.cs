using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{ 
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Column("CodigoInterno")]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }
    }
}
