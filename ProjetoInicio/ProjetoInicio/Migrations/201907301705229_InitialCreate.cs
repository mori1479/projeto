namespace ProjetoInicio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comodidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantidade = c.Int(nullable: false),
                        Imoveis_Id = c.Int(),
                        Tipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Imovels", t => t.Imoveis_Id)
                .ForeignKey("dbo.TipoComodidades", t => t.Tipo_Id)
                .Index(t => t.Imoveis_Id)
                .Index(t => t.Tipo_Id);
            
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Double(nullable: false),
                        Tamanho = c.Double(nullable: false),
                        FimInatividade = c.DateTime(nullable: false),
                        InicioInatividade = c.DateTime(nullable: false),
                        Image = c.String(),
                        Enderecos_Id = c.Int(),
                        Proprietario_Id = c.Int(),
                        Tipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecoes", t => t.Enderecos_Id)
                .ForeignKey("dbo.Usuarios", t => t.Proprietario_Id)
                .ForeignKey("dbo.TipoImovels", t => t.Tipo_Id)
                .Index(t => t.Enderecos_Id)
                .Index(t => t.Proprietario_Id)
                .Index(t => t.Tipo_Id);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pais = c.String(),
                        Estado = c.String(),
                        Cidade = c.String(),
                        Bairro = c.String(),
                        Rua = c.String(),
                        Numero = c.Int(nullable: false),
                        Cep = c.Int(nullable: false),
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Image = c.String(),
                        Endereco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_Id)
                .Index(t => t.Endereco_Id);
            
            CreateTable(
                "dbo.TipoImovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoComodidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Telefone = c.String(),
                        Email = c.String(),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.Usuarios_Id);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Proprietario = c.String(),
                        Inquilino = c.String(),
                        InicioPeriodoVigencia = c.DateTime(nullable: false),
                        FimPeriodoVigencia = c.DateTime(nullable: false),
                        Preco = c.Double(nullable: false),
                        observacao = c.String(),
                        DiaPagamento = c.Int(nullable: false),
                        Imoveis_Id = c.Int(),
                        Situacao_Id = c.Int(),
                        Tipo_Id = c.Int(),
                        TipoP_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Imovels", t => t.Imoveis_Id)
                .ForeignKey("dbo.SituacaoDoContratoes", t => t.Situacao_Id)
                .ForeignKey("dbo.TipoDeContratoes", t => t.Tipo_Id)
                .ForeignKey("dbo.TipoPagamentoes", t => t.TipoP_Id)
                .Index(t => t.Imoveis_Id)
                .Index(t => t.Situacao_Id)
                .Index(t => t.Tipo_Id)
                .Index(t => t.TipoP_Id);
            
            CreateTable(
                "dbo.SituacaoDoContratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoDeContratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        MesesDeAtraso = c.Int(nullable: false),
                        PrimeiroAluguel = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoPagamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Intervalo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HistoricoDoImovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Data = c.DateTime(nullable: false),
                        Imoveis_Id = c.Int(),
                        TiposHistoricos_Id = c.Int(),
                        Usuarios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Imovels", t => t.Imoveis_Id)
                .ForeignKey("dbo.TipoHistoricoes", t => t.TiposHistoricos_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarios_Id)
                .Index(t => t.Imoveis_Id)
                .Index(t => t.TiposHistoricos_Id)
                .Index(t => t.Usuarios_Id);
            
            CreateTable(
                "dbo.TipoHistoricoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pagamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataPagamento = c.DateTime(nullable: false),
                        ValorPago = c.Double(nullable: false),
                        Atrasado = c.Boolean(nullable: false),
                        Numero = c.Int(nullable: false),
                        contrato_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contratoes", t => t.contrato_id)
                .Index(t => t.contrato_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pagamentoes", "contrato_id", "dbo.Contratoes");
            DropForeignKey("dbo.HistoricoDoImovels", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.HistoricoDoImovels", "TiposHistoricos_Id", "dbo.TipoHistoricoes");
            DropForeignKey("dbo.HistoricoDoImovels", "Imoveis_Id", "dbo.Imovels");
            DropForeignKey("dbo.Contratoes", "TipoP_Id", "dbo.TipoPagamentoes");
            DropForeignKey("dbo.Contratoes", "Tipo_Id", "dbo.TipoDeContratoes");
            DropForeignKey("dbo.Contratoes", "Situacao_Id", "dbo.SituacaoDoContratoes");
            DropForeignKey("dbo.Contratoes", "Imoveis_Id", "dbo.Imovels");
            DropForeignKey("dbo.Contatoes", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Comodidades", "Tipo_Id", "dbo.TipoComodidades");
            DropForeignKey("dbo.Comodidades", "Imoveis_Id", "dbo.Imovels");
            DropForeignKey("dbo.Imovels", "Tipo_Id", "dbo.TipoImovels");
            DropForeignKey("dbo.Imovels", "Proprietario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "Endereco_Id", "dbo.Enderecoes");
            DropForeignKey("dbo.Imovels", "Enderecos_Id", "dbo.Enderecoes");
            DropIndex("dbo.Pagamentoes", new[] { "contrato_id" });
            DropIndex("dbo.HistoricoDoImovels", new[] { "Usuarios_Id" });
            DropIndex("dbo.HistoricoDoImovels", new[] { "TiposHistoricos_Id" });
            DropIndex("dbo.HistoricoDoImovels", new[] { "Imoveis_Id" });
            DropIndex("dbo.Contratoes", new[] { "TipoP_Id" });
            DropIndex("dbo.Contratoes", new[] { "Tipo_Id" });
            DropIndex("dbo.Contratoes", new[] { "Situacao_Id" });
            DropIndex("dbo.Contratoes", new[] { "Imoveis_Id" });
            DropIndex("dbo.Contatoes", new[] { "Usuarios_Id" });
            DropIndex("dbo.Usuarios", new[] { "Endereco_Id" });
            DropIndex("dbo.Imovels", new[] { "Tipo_Id" });
            DropIndex("dbo.Imovels", new[] { "Proprietario_Id" });
            DropIndex("dbo.Imovels", new[] { "Enderecos_Id" });
            DropIndex("dbo.Comodidades", new[] { "Tipo_Id" });
            DropIndex("dbo.Comodidades", new[] { "Imoveis_Id" });
            DropTable("dbo.Pagamentoes");
            DropTable("dbo.TipoHistoricoes");
            DropTable("dbo.HistoricoDoImovels");
            DropTable("dbo.TipoPagamentoes");
            DropTable("dbo.TipoDeContratoes");
            DropTable("dbo.SituacaoDoContratoes");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Contatoes");
            DropTable("dbo.TipoComodidades");
            DropTable("dbo.TipoImovels");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Imovels");
            DropTable("dbo.Comodidades");
        }
    }
}
