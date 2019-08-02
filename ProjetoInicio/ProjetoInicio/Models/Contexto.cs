using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace ProjetoInicio.Models
{
    public class Contexto : DbContext
    {
        public DbSet<TipoComodidade> Tiposcomodidades { get; set; }
        public DbSet<TipoHistorico> TiposHistoricos { get; set; }
        public DbSet<SituacaoDoContrato> SituacaoDosContratos { get; set; }
        public DbSet<TipoDeContrato> TiposDeContratos { get; set; }
        public DbSet<TipoImovel> TiposDeImoveis { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<TipoPagamento> TipoPagamentoes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Comodidade> Comodidades { get; set; }
        public DbSet<HistoricoDoImovel> HistoricoDoImovels { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public Contexto() : base("DefaultConnection")
        {

        }
    }
}