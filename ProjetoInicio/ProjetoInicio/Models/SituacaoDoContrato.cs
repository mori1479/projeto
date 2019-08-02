using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class SituacaoDoContrato
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
