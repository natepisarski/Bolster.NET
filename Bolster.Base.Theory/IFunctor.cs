using System;

namespace Bolster.Base.Theory
{
    /// <summary>
    /// Although a far cry from its true category theory counterpart, IFunctor is useful as it can be used 
    /// to map functions returning arbitrary types over monads of arbitrary type. Abuses the fact that monads
    /// must implement a way to create a unit instantiation of itself.
    /// </summary>
    /// <typeparam name="T">The type of the original monad, and argument of the function</typeparam>
    /// <typeparam name="W">The return value of the function, and the type of the resulting monad.</typeparam>
    public interface IFunctor<T, W> : IMonad<T>
    {
        IMonad<W> Map(Func<T, W> toApply);
    }
}