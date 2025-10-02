using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BibliotecaOnline.Models
{
    // classe para mapear os models para tabelas no banco.
    public class BibliotecaContext : DbContext
    {
        // Construtor da classe BibliotecaContext.
        // Recebe as configurações definidas no Program.cs, como a string de conexão e o tipo de banco de dados
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        // DbSet representa uma tabela no banco de dados.
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
