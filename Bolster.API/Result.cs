using Bolster.API.Status.Stateless;
using Bolster.Base;

namespace Bolster.API
{
    public abstract class Result
    {
        public abstract bool IsSuccess { get; }
        
        public abstract bool IsFailure { get; }
    }
}