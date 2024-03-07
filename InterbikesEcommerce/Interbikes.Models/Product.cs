using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(200, ErrorMessage = "O nome do produto deve ter no máximo 30 caracteres.")]
        [DisplayName("Nome do Produto")]
        public string Name { get; set; }
        [Range(1, 10000, ErrorMessage = "O preço deve ser maior que zero")]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Preço")]
        public double Price { get; set; }
        [MaxLength(1000, ErrorMessage = "A descrição do produto deve ter no máximo 1000 caracteres.")]
        [DisplayName("Drescrição do Produto")]
        public string Description { get; set; }
    }
}
