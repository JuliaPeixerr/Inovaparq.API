using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incubadora.Project.Domain.Models
{
    [Table("Incubadora")]
    public class Incubadora
    {
        [Key]
        [Column("Inc_Codigo")]
        public int Id { get; set; }

        [Column("Inc_Descricao")]
        public string? Descricao { get; set; }

        [Column("Inc_Cod_Status")]
        public int? CodigoStatus { get; set; }

        [Column("Inc_Ativo")]
        public bool? Ativo { get; set; }
    }
}
