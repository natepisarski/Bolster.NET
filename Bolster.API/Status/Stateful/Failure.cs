namespace Bolster.API.Status.Stateful
{
    public class Failure<T> : Stateless.Failure 
    {
        public T State { get; }

        public Failure(T state) {
            State = state;
        }
    }
}