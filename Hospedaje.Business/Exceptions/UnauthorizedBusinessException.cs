using System;

namespace Hospedaje.Business.Exceptions
{
    /// <summary>
    /// ExcepciÃ³n lanzada cuando el usuario no estÃ¡ autenticado o no tiene permisos suficientes.
    /// </summary>
    public class UnauthorizedBusinessException : Exception
    {
        public string? CodigoError { get; set; }

        public UnauthorizedBusinessException() : base() { }

        public UnauthorizedBusinessException(string message) : base(message) { }

        public UnauthorizedBusinessException(string codigoError, string message) : base(message)
        {
            CodigoError = codigoError;
        }

        public UnauthorizedBusinessException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
