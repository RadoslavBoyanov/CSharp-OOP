﻿namespace Logger.Core.Exceptions
{
    public class EmptyFileNameException : Exception
    {
        private const string DefaultMessage = "File cannot be null or whitespace";

        public EmptyFileNameException() : base(DefaultMessage)
        {
        }

        public EmptyFileNameException(string message) : base(message)
        {

        }
    }
}
