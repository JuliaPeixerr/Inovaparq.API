using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incubadora.Project.Domain.Models
{
    [Table("Startup_Grupo")]
    public class StartupGrupo
    {
        [Key]
        [Column("SGr_Codigo")]
        public int Id { get; set; }

        [Column("SGr_Descricao")]
        public string? Descricao { get; set; }
    }
}
