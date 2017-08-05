namespace Bolster.Base.Theory
{
    /// <summary>
    /// IMonad does not truly follow the monadic laws. Due to restriction's of C#'s type system regarding Kinds,
    /// the theoretical basis of Monads are unimplementable in idiomatic C#
    /// </summary>
    /// <typeparam name="T">The type that this monad is wrapping.</typeparam>
    public interface IMonad<T>
    {
        /// <summary>
        /// Returns the value that this 'Monad' is wrapping
        /// </summary>
        /// <returns></returns>
        T Return();
        
        /// <summary>
        /// Differs strongly from the true monadic compose function. This serves to instantiate a unit 
        /// instance of this monad, so that code can apply and compose monads without applicative types.
        /// </summary>
        /// <param name="argument">The argument that this monad should wrap</param>
        /// <typeparam name="W">The type of the argument</typeparam>
        /// <returns>A unit instantiation of this monad, if possible. This should never fail.</returns>
        IMonad<W> Compose<W>(W argument); 
    }
}