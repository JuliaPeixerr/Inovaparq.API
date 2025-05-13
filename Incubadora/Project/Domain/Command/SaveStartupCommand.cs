namespace Incubadora.Project.Domain.Command
{
    public class SaveStartupCommand
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int? CodigoGrupo { get; set; }
        public string? Email { get; set; }
        public string? Fundador { get; set; }
    }
}
