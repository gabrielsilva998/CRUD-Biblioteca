using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaOnline.Models
{
    public class Emprestimo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "O Código é obrigatório")]
        [DisplayName("Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "A data de retirada é obrigatória")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Retirada")]
        public DateTime DataRetirada { get; set; }

        [Required(ErrorMessage = "A data de entrega é obrigatória")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Entrega")]
        public DateTime DataEntrega { get; set; }
    }
}
