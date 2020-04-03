using System;
using System.Runtime.Serialization;

namespace OzExtensions
{
    public class ArgumentIsFuckedException : ArgumentException
    {
        public ArgumentIsFuckedException() { }
        public ArgumentIsFuckedException(string message) : base(message) { }
        public ArgumentIsFuckedException(string message, string paramName) : base(message, paramName) { }
        public ArgumentIsFuckedException(string message, Exception exception) : base(message, exception) { }
        public ArgumentIsFuckedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}