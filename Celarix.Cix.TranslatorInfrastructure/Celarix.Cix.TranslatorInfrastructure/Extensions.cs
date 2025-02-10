using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celarix.Cix.TranslatorInfrastructure
{
    public static class Extensions
    {
        public static Pointer<T> AddressOf<T>(this T value) => throw new InvalidOperationException("Stub method");
        public static T LogicalNOT<T>(this T value) => throw new InvalidOperationException("Stub method");
    }
}
