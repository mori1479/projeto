using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public Usuario Usuarios { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}