using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Movel
    {
        public int MovelId {get; set;}
        [Required(ErrorMessage = "Informe o nome do Movel")]
        [Display(Name = "Movel")]
        [MinLength(3, ErrorMessage = "Movel deve ter no mínimo {1} caracteres")]
        [MaxLength(30, ErrorMessage = "Movel deve ter no maximo {1} caracteres")]
        public string Nome {get; set;}
        [Required(ErrorMessage = "Informe o nome da Categoria")]
        [Display(Name = "Descricao")]
        [MinLength(3, ErrorMessage = "Descricao deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descricao deve ter no maximo {1} caracteres")]
        public string Descricao {get; set;}
        [Display(Name = "Cor")]
        [MaxLength(20, ErrorMessage = "Cor deve ter no maximo {1} caracteres")]
        public string Cor {get; set;}
        [Display(Name = "Caminho da Imagem")]
        public string ImagemUrl {get; set;}
        [Display(Name = "Caminho da Imagem pequena")]
        public string ImagemPequena {get; set;}
        [Required(ErrorMessage = "Informe o valor")]
        [Display(Name = "Valor")]
        [Range(1,99999.99, ErrorMessage = "O valor de estar entre {1} e {2}")]
        public double Valor {get; set;}
        [Display(Name = "Em linha de Produção")]
        public bool EmProducao {get; set;}
        [Display(Name = "Ativo")]
        public bool Ativo{get; set;}
        [Required(ErrorMessage = "Informe a Categoria")]
        public int CategoriaId {get; set;}
        public  virtual Categoria Categoria{get; set;}
    }
}