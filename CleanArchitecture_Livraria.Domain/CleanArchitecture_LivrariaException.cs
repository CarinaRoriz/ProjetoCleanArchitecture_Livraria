namespace CleanArchitecture_Livraria.Domain
{
    using System;

    public class CleanArchitecture_LivrariaException : Exception
    {
        internal CleanArchitecture_LivrariaException()
        { }

        internal CleanArchitecture_LivrariaException(string message)
            : base(message)
        { }

        internal CleanArchitecture_LivrariaException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
