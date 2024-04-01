using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interbikes.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O nome do produto deve ter no máximo 200 caracteres.")]
        [DisplayName("Nome do Produto")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [Range(1, 10000, ErrorMessage = "O preço deve ser maior que R$ 0,00 e menor que R$ 10.000,00")]
        [DisplayName("Preço")]
        public double Price { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório.")]
        [MaxLength(1000, ErrorMessage = "A descrição do produto deve ter no máximo 1000 caracteres.")]
        [MinLength(30, ErrorMessage = "A descrição deve ter pelo menos 30 caracteres.")]
        [DisplayName("Drescrição do Produto")]
        public string Description { get; set; }

        [DisplayName("Categoria")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
