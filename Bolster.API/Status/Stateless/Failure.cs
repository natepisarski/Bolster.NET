namespace Bolster.API.Status.Stateless
{
    public class Failure : Result, IFailure
    {
        public string FailureReason { get; }
        
        public Failure(string failureReason = null) {
            FailureReason = failureReason;
        }
        
        public Failure Reason(string failureReason) =>
            new Failure(failureReason);
        
        public override bool IsSuccess => false;
        
        public override bool IsFailure => true;
    }
}