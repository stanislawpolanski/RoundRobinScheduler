using System;
using System.Runtime.Serialization;

namespace RoundRobinScheduler
{
    /// <summary>
    /// Thrown out when score is not invalid.
    /// </summary>
    [Serializable]
    internal class InvalidScoreException : ArgumentException
    {
        public InvalidScoreException()
        {
        }

        public InvalidScoreException(string message) : base(message)
        {
        }

        public InvalidScoreException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidScoreException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}