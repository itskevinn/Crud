using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Base
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DomainServiceAttribute: Attribute
    {
    }
}
