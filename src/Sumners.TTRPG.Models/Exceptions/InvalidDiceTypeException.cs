using System;

namespace Sumners.TTRPG.Models.Exceptions
{
    [Serializable]
    public class InvalidDiceTypeException : ApplicationException
    {
        public InvalidDiceTypeException()
        { }

        public InvalidDiceTypeException(int numberOfSides) : this($"'{numberOfSides}' isn't a valid dice type.")
        {
        }

        public InvalidDiceTypeException(int numberOfSides, Exception inner) : this($"'{numberOfSides}' isn't a valid dice type.", inner)
        {
        }

        public InvalidDiceTypeException(string message) : base(message)
        {
        }

        public InvalidDiceTypeException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidDiceTypeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}