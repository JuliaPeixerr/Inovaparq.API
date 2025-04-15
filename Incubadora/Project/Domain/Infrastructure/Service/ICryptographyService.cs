namespace Incubadora.Project.Domain.Infrastructure.Service
{
    public interface ICryptographyService
    {
        string Cryptograph(string password);
        string Descryptograph(string password);
    }
}
