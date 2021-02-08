using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sirus.CompetenceMatrix.Api.Exceptions
{
    public class InvalidParametersException : Exception
    {
        public InvalidParametersException() : base()
        { }

        public InvalidParametersException(string message) : base(message)
        { }

        public InvalidParametersException(string message, Exception innerException) : base(message, innerException)
        { }

        public InvalidParametersException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
