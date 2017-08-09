using System;
using Bolster.Base.Theory;

namespace Bolster.Base
{
    public abstract class Either<T, W>
    {
        protected Either(dynamic value) {
            Value = value;
        }
        public dynamic Value { get; set; }
        
        public abstract bool IsLeft { get; }
        
        public abstract bool IsRight { get; }
        
        public static Either<T, W> Choose(T item) => new Left<T, W>(item);

        public static Either<T, W> Choose(W item) => new Right<T, W>(item);
        
        public bool Is<X>() {
            if (IsLeft) {
                var leftType = typeof(T);
                var isType = typeof(X) == leftType || typeof(X).IsSubclassOf(leftType);
                return isType;
            }

            if (IsRight) {
                var rightType = typeof(W);
                var isType = typeof(X) == rightType || typeof(X).IsSubclassOf(rightType);
                return isType;
            }
            
            throw new Exception(Constants.TypeNotDeclaredLeftOrRightExceptionMessage);
        }

        public Maybe<X> ValueAs<X>() {
            if (Is<X>()) {
                return new Just<X>(Value);
            }
            return new None<X>(new Exception(Constants.ValueAsProvidesIncorrectType));
        }
    }

    public class Left<T, W> : Either<T, W>, IMonad<T>
    {
        
        public override bool IsLeft => true;

        public override bool IsRight => false;

        public Left(T item) :base(item) {
            
        }

        public T Return() => ValueAs<T>().Return();

        public IMonad<W1> Compose<W1>(W1 argument) => new Left<W1, object>(argument);
    }
    
    public class Right<T, W> : Either<T, W>, IMonad<W>
    {
        public override bool IsLeft => false;
        
        public override bool IsRight => true;

        public Right(W item) : base(item) {
            
        }

        public W Return() => ValueAs<W>().Return();

        public IMonad<W1> Compose<W1>(W1 argument) => new Right<object, W1>(argument);
    }
}