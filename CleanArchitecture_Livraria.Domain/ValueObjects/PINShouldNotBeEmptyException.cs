namespace CleanArchitecture_Livraria.Domain.ValueObjects
{
    public class PINShouldNotBeEmptyException : DomainException
    {
        internal PINShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
