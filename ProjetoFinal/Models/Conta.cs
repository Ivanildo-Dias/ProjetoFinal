using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("contas")]
    public class Conta
    {
        [Key]
        [Column("Numero")]
        public int Id { get; set; }

        public int Agencia { get; set; }

        public int Tipo { get; set; }

        public string TipoString()
        {
            if (this.Tipo == 0)
                return "Conta corrente";
            else if (this.Tipo == 1)
                return "Conta poupança";
            else
                return "Conta investimento";
        }

        public double Saldo { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}