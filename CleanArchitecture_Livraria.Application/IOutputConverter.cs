namespace CleanArchitecture_Livraria.Application
{
    public interface IOutputConverter
    {
        T Map<T>(object source);
    }
}
