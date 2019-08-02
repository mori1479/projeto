using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace ProjetoInicio.Models
{
    public class Comodidade
    {
        [Key]
        public int Id { get; set; }
        public Imovel Imoveis { get; set; }
        public int quantidade { get; set; }
        public TipoComodidade Tipo { get; set; }
    }
}