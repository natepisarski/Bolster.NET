using Bolster.API.Status.Stateless;
using Bolster.Base;

namespace Bolster.API.Interface.Stateless
{
    public static class Status
    {
        public static Success Success => new Success();
        public static Failure Failure => new Failure();

        public static Either<Success, Failure> SuccessfulResult => Either<Success, Failure>.Choose(Success);
        public static Either<Success, Failure> FailureResult => Either<Success, Failure>.Choose(Failure); 
    }
}