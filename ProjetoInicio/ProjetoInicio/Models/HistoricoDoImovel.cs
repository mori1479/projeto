using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace ProjetoInicio.Models
{
    public class HistoricoDoImovel
    {
        [Key]
        public int Id { get; set; }
        public Imovel Imoveis { get; set; }
        public string Descricao { get; set; }
        public Usuario Usuarios { get; set; }
        public DateTime Data { get; set; }
        public TipoHistorico TiposHistoricos { get; set; }
    }
}