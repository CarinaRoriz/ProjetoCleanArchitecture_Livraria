namespace CleanArchitecture_Livraria.Domain
{
    public interface IAggregateRoot : IEntity
    {
        int Version { get; }
    }
}