using System;
using System.Runtime.Serialization;

namespace OzExtensions
{
    public class ArgumentIsFuckAllException : ArgumentNullException
    {
        public ArgumentIsFuckAllException() { }
        public ArgumentIsFuckAllException(string paramName) : base(paramName) { }
        public ArgumentIsFuckAllException(string paramName, string message) : base(paramName, message) { }
        public ArgumentIsFuckAllException(string message, Exception exception) : base(message, exception) { }
        public ArgumentIsFuckAllException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
