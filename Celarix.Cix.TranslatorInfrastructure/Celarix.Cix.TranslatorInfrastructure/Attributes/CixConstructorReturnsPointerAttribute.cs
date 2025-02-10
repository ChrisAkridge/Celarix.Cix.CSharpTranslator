using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celarix.Cix.TranslatorInfrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public sealed class CixConstructorReturnsPointerAttribute : Attribute
    {
    }
}
