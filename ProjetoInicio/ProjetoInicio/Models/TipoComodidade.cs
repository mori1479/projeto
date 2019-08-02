using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TipoComodidade
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}