using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InterbikesWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome da Categoria")]
        public string Name { get; set; }
        [DisplayName("Código de Identificação")]
        public int DisplayOrder { get; set; }
    }
}
