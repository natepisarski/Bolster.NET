namespace Bolster.API.Status.Stateful
{
    public class Success<T> : Stateless.Success
    {
        public T State { get; }

        public Success(T item) {
            State = item;
        }
    }
}