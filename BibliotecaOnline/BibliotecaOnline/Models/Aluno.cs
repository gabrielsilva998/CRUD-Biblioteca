using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaOnline.Models
{
    public class Aluno
    {
        [Key] //Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "O RA é obrigatório")]
        public int RA { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]  //Validação para o campo não ficar vazio
        [StringLength(100, ErrorMessage = "O nome deve conter até 100 caracteres")]  //Validação para não ultrapassar limite de caractere
        [MinLength(5, ErrorMessage = "Digite o nome Completo")]
        [DisplayName("Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [StringLength(100, ErrorMessage = "O email deve conter até 100 caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")] //Validação Email 
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Phone(ErrorMessage = "Telefone inválido")] //Validação Telefone
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória")]
        [DataType(DataType.Date)]  //Especificar que é uma data
        [DisplayName("Data de Nascimento")]  //O que vai aparecer na tela
        public DateTime DataNascimento { get; set; }
    }
}
