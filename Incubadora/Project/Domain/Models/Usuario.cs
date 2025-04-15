using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incubadora.Project.Domain.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Column("Usu_Codigo")]
        public int Id { get; set; }

        [Column("Usu_Nome")]
        public string? Nome { get; set; }

        [Column("Usu_Senha")]
        public string? Senha { get; set; }
    }
}
