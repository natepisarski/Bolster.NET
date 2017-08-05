using System;
using Bolster.Base.Theory;

namespace Bolster.Base
{
    public abstract class Maybe<T> : IMonad<T>
    {
        protected T Value { get; set; }

        public abstract T Return();

        public abstract bool HasValue { get; }
        
        public abstract bool HasError { get; }
        
        public IMonad<W> Compose<W>(W argument)
            => new Just<W>(argument);
    }

    public class Just<T> : Maybe<T>
    {
        public Just(T value)
        {
            Value = value;
        }
        
        public override T Return()
        {
            return Value;
        }

        public override bool HasValue => true;

        public override bool HasError => false;
    }

    public class None<T> : Maybe<T>
    {
        public Exception Error { get; }

        public None(Exception exception)
        {
            Error = exception;
        }

        public override T Return()
        {
            if (Error == null) {
                throw new Exception("");
            }
            else {
                throw new Exception(Constants.ReturnFromNoneTypeExceptionMessage);
            }
        }

        public override bool HasValue { get; }
        public override bool HasError { get; }
    }
}