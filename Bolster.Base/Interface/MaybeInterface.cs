using System;

namespace Bolster.Base.Interface
{
    public static class MaybeInterface
    {
        public static Just<T> Just<T>(this T item) => new Just<T>(item);
        
        public static None<T> None<T>(this Exception exception) => new None<T>(exception);

        public static Maybe<T> AbductFailures<T>(this Func<T> block) {
            try {
                return block().Just();
            }
            catch (Exception exception) {
                return new None<T>(exception);
            }
        }

        public static Maybe<T> AsMaybe<T>(this T item) where T : class {
            if (item == null) {
                return new None<T>();
            }
            return item.Just();
        }
    }
}