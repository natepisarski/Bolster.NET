using System;

namespace Bolster.Utility.Functions
{
    public static class Currying
    {

        public static
            Func<B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            Curry<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            (Func<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q> func, A a)
            => (B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            Curry<B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            (Func<B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q> func, B b)
            => (C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            Curry<C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            (Func<C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q> func, C c)
            => (D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<E, F, G, H, I, J, K, L, M, N, O, P, Q>
            Curry<D, E, F, G, H, I, J, K, L, M, N, O, P, Q>
            (Func<D, E, F, G, H, I, J, K, L, M, N, O, P, Q> func, D d)
            => (E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(d, e, f, g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<F, G, H, I, J, K, L, M, N, O, P, Q>
            Curry<E, F, G, H, I, J, K, L, M, N, O, P, Q>
            (Func<E, F, G, H, I, J, K, L, M, N, O, P, Q> func, E e)
            => (F f, G g, H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(e, f, g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<G, H, I, J, K, L, M, N, O, P, Q>
            Curry<F, G, H, I, J, K, L, M, N, O, P, Q>
            (Func<F, G, H, I, J, K, L, M, N, O, P, Q> func, F f)
            => (G g, H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(f, g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<H, I, J, K, L, M, N, O, P, Q>
            Curry<G, H, I, J, K, L, M, N, O, P, Q>
            (Func<G, H, I, J, K, L, M, N, O, P, Q> func, G g)
            => (H h, I i, J j, K k, L l, M m, N n, O o, P p)
                => func(g, h, i, j, k, l, m, n, o, p);
        
        public static
            Func<I, J, K, L, M, N, O, P, Q>
            Curry<H, I, J, K, L, M, N, O, P, Q>
            (Func<H, I, J, K, L, M, N, O, P, Q> func, H h)
            => (I i, J j, K k, L l, M m, N n, O o, P p)
                => func(h, i, j, k, l, m, n, o, p);
        
        public static
            Func<J, K, L, M, N, O, P, Q>
            Curry<I, J, K, L, M, N, O, P, Q>
            (Func<I, J, K, L, M, N, O, P, Q> func, I i)
            => (J j, K k, L l, M m, N n, O o, P p)
                => func(i, j, k, l, m, n, o, p);
        
        public static
            Func<K, L, M, N, O, P, Q>
            Curry<J, K, L, M, N, O, P, Q>
            (Func<J, K, L, M, N, O, P, Q> func, J j)
            => (K k, L l, M m, N n, O o, P p)
                => func(j, k, l, m, n, o, p);
        
        public static
            Func<L, M, N, O, P, Q>
            Curry<K, L, M, N, O, P, Q>
            (Func<K, L, M, N, O, P, Q> func, K k)
            => (L l, M m, N n, O o, P p)
                => func(k, l, m, n, o, p);
        
        public static
            Func<M, N, O, P, Q>
            Curry<L, M, N, O, P, Q>
            (Func<L, M, N, O, P, Q> func, L l)
            => (M m, N n, O o, P p)
                => func(l, m, n, o, p);
        
        public static
            Func<N, O, P, Q>
            Curry<M, N, O, P, Q>
            (Func<M, N, O, P, Q> func, M m)
            => (N n, O o, P p)
                => func(m, n, o, p);
        
        public static
            Func<O, P, Q>
            Curry<N, O, P, Q>
            (Func<N, O, P, Q> func, N n)
            => (O o, P p)
                => func(n, o, p);
        
        public static
            Func<P, Q>
            Curry<O, P, Q>
            (Func<O, P, Q> func, O o)
            => (P p)
                => func(o, p);
        
        public static
            Func<Q>
            Curry<P, Q>
            (Func<P, Q> func, P p)
            => ()
                => func(p);
    }
}