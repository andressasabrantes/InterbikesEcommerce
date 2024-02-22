using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InterbikesWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        [MaxLength(30, ErrorMessage = "O nome da categoria deve ter no máximo 30 caracteres.")]
        [DisplayName("Nome da Categoria")]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage = "O código de Identificação deve ser entre 1-100 caracteres.")]
        [Required(ErrorMessage = "O campo é obrigatório.")]
        [DisplayName("Código de Identificação")]
        public int? DisplayOrder { get; set; }
    }
}
