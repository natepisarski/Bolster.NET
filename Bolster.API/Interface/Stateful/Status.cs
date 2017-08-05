using Bolster.API.Status.Stateful;
using Bolster.API.Status.Stateless;
using Bolster.Base;

namespace Bolster.API.Interface.Stateful
{
    public static class Status
    {
        public static Success<T> Success<T>(this T state) => new Success<T>(state);
        public static Failure Failure => new Failure();

        public static Either<Success<T>, Failure> SuccessfulResult<T>(this T item) => Either<Success<T>, Failure>.Choose(item.Success());
        public static Either<Success<T>, Failure> FailureResult<T>() => Either<Success<T>, Failure>.Choose(Failure);
    }
}