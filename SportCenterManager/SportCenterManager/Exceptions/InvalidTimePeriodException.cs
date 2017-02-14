using System;
using System.Runtime.Serialization;

namespace SportCenterManager.Exceptions
{
    [Serializable]
    internal class InvalidTimePeriodException : Exception
    {
        public InvalidTimePeriodException()
        {
        }

        public InvalidTimePeriodException(string message) : base(message)
        {
        }

        public InvalidTimePeriodException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidTimePeriodException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}