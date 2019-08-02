using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class Contrato
    {
        [Key]
        public int id { get; set; }
        public Imovel Imoveis { get; set; }
        public string Proprietario { get; set; }
        public string Inquilino { get; set; }
        public DateTime InicioPeriodoVigencia { get; set; }
        public DateTime FimPeriodoVigencia { get; set; }
        public double Preco { get; set; }
        public TipoDeContrato Tipo { get; set; }
        public SituacaoDoContrato Situacao { get; set; }
        public string observacao { get; set; }
        public int DiaPagamento { get; set; }
        public TipoPagamento TipoP { get; set; }
    }
}