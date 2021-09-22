using System;

namespace Main.Exceptions
{
    public class CollaboratorCallException : Exception
    {
        public CollaboratorCallException(string message) => message = message;
    }
}