using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaOnline.Models
{
    public class Livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "O código é obrigatório")]
        [DisplayName("Código do Livro")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(100, ErrorMessage = "O livro deve conter até 100 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório")]
        [StringLength(100, ErrorMessage = "O autor deve conter até 100 caracteres")]
        [DisplayName("Autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória")]
        [StringLength(100, ErrorMessage = "A categoria deve conter até 100 caracteres")]
        [DisplayName("Categoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "A editora é obrigatória")]
        [StringLength(100, ErrorMessage = "A editora deve conter até 100 caracteres")]
        public string Editora { get; set; }
    }
}
