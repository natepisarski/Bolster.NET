using System;

namespace Bolster.Base.Theory
{
    /// <summary>
    /// An EndoFunctor is a functor from one category back into the same category. In the context of the C# 
    /// type system and Bolster, it means that it will map a monad of one type into a monad of the same type.
    /// </summary>
    public interface IEndoFunctor<T> : IMonad<T>
    {
        IMonad<T> Map(Func<T, T> toApply);
    }
}