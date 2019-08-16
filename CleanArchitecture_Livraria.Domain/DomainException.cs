namespace CleanArchitecture_Livraria.Domain
{
    public class DomainException : CleanArchitecture_LivrariaException
    {
        public string BusinessMessage { get; private set; }

        public DomainException(string businessMessage)
        {
            BusinessMessage = businessMessage;
        }
    }
}
