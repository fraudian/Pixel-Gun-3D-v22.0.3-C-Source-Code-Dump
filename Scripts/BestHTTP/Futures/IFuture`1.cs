using UnityEngine;

namespace BestHTTP.Futures
{
    public interface IFuture<T>
    {
        // Properties
        public abstract BestHTTP.Futures.FutureState state { get; }
        public abstract T value { get; }
        public abstract System.Exception error { get; }
        
        // Methods
        public abstract BestHTTP.Futures.FutureState get_state(); // 0
        public abstract T get_value(); // 0
        public abstract System.Exception get_error(); // 0
        public abstract BestHTTP.Futures.IFuture<T> OnItem(BestHTTP.Futures.FutureValueCallback<T> callback); // 0
        public abstract BestHTTP.Futures.IFuture<T> OnSuccess(BestHTTP.Futures.FutureValueCallback<T> callback); // 0
        public abstract BestHTTP.Futures.IFuture<T> OnError(BestHTTP.Futures.FutureErrorCallback callback); // 0
        public abstract BestHTTP.Futures.IFuture<T> OnComplete(BestHTTP.Futures.FutureCallback<T> callback); // 0
    
    }

}
