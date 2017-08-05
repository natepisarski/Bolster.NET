using System;

namespace Bolster.Base.Interface
{
    public static class MaybeInterface
    {
        public static Just<T> Just<T>(this T item) => new Just<T>(item);
        
        public static None<T> None<T>(this Exception exception) => new None<T>(exception);
    }
}