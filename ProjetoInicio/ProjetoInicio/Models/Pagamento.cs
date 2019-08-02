using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        public Contrato contrato { get; set; }
        public DateTime DataPagamento { get; set; }
        public double ValorPago { get; set; }
        public bool Atrasado { get; set; }
        public int Numero { get; set; }
    }
}