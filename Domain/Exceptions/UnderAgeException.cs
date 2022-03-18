using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class UnderAgeException : System.Exception
    {
        public UnderAgeException() { }
        public UnderAgeException(string message) : base(message) { }
        public UnderAgeException(string message, System.Exception inner) : base(message, inner) { }
        protected UnderAgeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
