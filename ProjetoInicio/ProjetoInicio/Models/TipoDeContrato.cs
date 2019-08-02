using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class TipoDeContrato
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int MesesDeAtraso { get; set; }
        public DateTime PrimeiroAluguel { get; set; }
    }
}