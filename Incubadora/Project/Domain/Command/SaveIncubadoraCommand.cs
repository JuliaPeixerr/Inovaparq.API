namespace Incubadora.Project.Domain.Command
{
    public class SaveIncubadoraCommand
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public int CodigoStatus { get; set; }
    }
}
