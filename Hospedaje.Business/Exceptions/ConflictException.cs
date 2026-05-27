using System;

namespace Hospedaje.Business.Exceptions
{
    /// <summary>
    /// ExcepciÃ³n para conflictos de negocio (409 Conflict), por ejemplo transiciones de estado invÃ¡lidas.
    /// </summary>
    public class ConflictException : Exception
    {
        public ConflictException() : base() { }

        public ConflictException(string message) : base(message) { }

        public ConflictException(string message, Exception innerException) : base(message, innerException) { }
    }
}


