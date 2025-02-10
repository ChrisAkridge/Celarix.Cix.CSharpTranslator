using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Celarix.Cix.TranslatorInfrastructure
{
    public sealed class Pointer<T>
    {
        public T this[int index]
        {
            get => throw new InvalidOperationException("Stub method");
            set => throw new InvalidOperationException("Stub method");
        }

        public T ValueAt() => throw new InvalidOperationException("Stub method");
        public U Member<U>(Expression<Func<T, U>> accessor) => throw new InvalidOperationException("Stub method");

        public static Pointer<T> operator +(Pointer<T> pointer, int offset) => throw new InvalidOperationException("Stub method");
        public static Pointer<T> operator -(Pointer<T> pointer, int offset) => throw new InvalidOperationException("Stub method");
    }
}
