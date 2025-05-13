using System;
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

        [Column("Sta_Nome")]
        public string? Nome { get; set; }

        [Column("Sta_Descricao")]
        public string? Descricao { get; set; }

        [Column("Sta_Cod_Status")]
        public int? CodigoStatus { get; set; }

        [Column("Sta_Cod_Grupo")]
        public int? CodigoGrupo { get; set; }

        [Column("Sta_Email")]
        public string? Email { get; set; }

        [Column("Sta_Fundador")]
        public string? Fundador { get; set; }

        [Column("Sta_Data_Criacao")]
        public DateTime? DataCriacao { get; set; }
    }
}
