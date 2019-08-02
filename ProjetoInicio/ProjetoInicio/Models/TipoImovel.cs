using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class TipoImovel 
    {
        [Key]
        public int Id { get; set; }
        public enum Funcao { Comercio, Pessoal }
        public enum Etilo { casa, apartamento }
        public string Descricao { get; set; }
    }
}