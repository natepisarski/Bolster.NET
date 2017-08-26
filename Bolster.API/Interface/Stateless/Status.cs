using System;
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

        public static Either<Success, Failure> ToStatus(this bool boolean) =>
            boolean ? Either<Success, Failure>.Choose(new Success()) : Either<Success, Failure>.Choose(new Failure());

        public static Either<Success, Failure> Safely(this Action apiAction) {
            try {
                apiAction();
                return SuccessfulResult;
            }
            catch (Exception e) {
                return Either<Success, Failure>.Choose(Failure.Reason(e.Message));
            }
        }
    }
}