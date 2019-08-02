using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoInicio.Models
{
    public class Imovel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public Usuario Proprietario { get; set; }
        public Endereco Enderecos { get; set; }
        public double Preco { get; set; }
        public double Tamanho { get; set; }
        public DateTime FimInatividade { get; set; }
        public DateTime InicioInatividade { get; set; }
        public TipoImovel Tipo { get; set; }
        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUser { get; set; }

    }
}