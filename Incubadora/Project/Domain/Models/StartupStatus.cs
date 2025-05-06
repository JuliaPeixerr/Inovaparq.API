using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incubadora.Project.Domain.Models
{
    [Table("Startup_Status")]
    public class StartupStatus
    {
        [Key]
        [Column("SSt_Codigo")]
        public int Id { get; set; }

        [Column("SSt_Descricao")]
        public string? Descricao { get; set; }
    }
}
