using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incubadora.Project.Domain.Models
{
    [Table("Startup")]
    public class Startup
    {
        [Key]
        [Column("Sta_Codigo")]
        public int Id { get; set; }

        [Column("Sta_Descricao")]
        public string? Descricao { get; set; }
    }
}
