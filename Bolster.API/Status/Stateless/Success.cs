namespace Bolster.API.Status.Stateless
{
    public class Success : Result, ISuccess
    {
        public string Reason { get; }
        
        public Success(string successReason = null) {
            Reason = successReason;
        }
        
        public Success Result(string successReason) =>
            new Success(successReason);

        public override bool IsSuccess => true;
        
        public override bool IsFailure => false;
    }
}