using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incubadora.Project.Domain.Models
{
    [Table("Incubadora_Status")]
    public class IncubadoraStatus
    {
        [Key]
        [Column("ISt_Codigo")]
        public int Id { get; set; }

        [Column("ISt_Descricao")]
        public string? Descricao { get; set; }

        [Column("ISt_Ativo")]
        public bool? Ativo { get; set; }
    }
}
