namespace Incubadora.Project.Domain.Command
{
    public class CreateUsuarioCommand : LoginCommand
    {
        public int? Id { get; set; }
    }
}
