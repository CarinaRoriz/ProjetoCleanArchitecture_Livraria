namespace CleanArchitecture_Livraria.Domain.Accounts
{
    public class CarrinhoNotFoundException : DomainException
    {
        public CarrinhoNotFoundException(string message)
            : base(message)
        { }
    }
}
