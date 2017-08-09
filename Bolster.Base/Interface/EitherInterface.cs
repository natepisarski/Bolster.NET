namespace Bolster.Base.Interface
{
    public static class EitherInterface
    {
        public static Either<T, W> ToLeft<T, W>(this T item) => Either<T, W>.Choose(item);

        public static Either<T, W> ToRight<T, W>(this W item) => Either<T, W>.Choose(item);
    }
}