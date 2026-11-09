using UnityEngine;

namespace BestHTTP.Futures
{
    public class Future<T> : IFuture<T>
    {
        // Fields
        private BestHTTP.Futures.FutureState _state;
        private T _value;
        private System.Exception _error;
        private System.Func<T> _processFunc;
        private readonly System.Collections.Generic.List<BestHTTP.Futures.FutureValueCallback<T>> _itemCallbacks;
        private readonly System.Collections.Generic.List<BestHTTP.Futures.FutureValueCallback<T>> _successCallbacks;
        private readonly System.Collections.Generic.List<BestHTTP.Futures.FutureErrorCallback> _errorCallbacks;
        private readonly System.Collections.Generic.List<BestHTTP.Futures.FutureCallback<T>> _complationCallbacks;
        
        // Properties
        public BestHTTP.Futures.FutureState state { get; }
        public T value { get; }
        public System.Exception error { get; }
        
        // Methods
        public BestHTTP.Futures.FutureState get_state()
        {
            return (BestHTTP.Futures.FutureState)W19;
        }
        public T get_value()
        {
            if(137162752 == 2)
            {
                    return 39178;
            }
            
            if(137162752 == 1)
            {
                    return 39178;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "value is not available unless state is Success or Processing.");
        }
        public System.Exception get_error()
        {
            if(137162752 == 3)
            {
                    return 39177;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "error is not available unless state is Error.");
        }
        public Future<T>()
        {
            mem[1152921553769214560] = __RuntimeMethodHiddenParam + 24 + 192;
            mem[1152921553769214568] = __RuntimeMethodHiddenParam + 24 + 192;
            mem[1152921553769214576] = new System.Collections.Generic.List<BestHTTP.Futures.FutureErrorCallback>();
            mem[1152921553769214584] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem[1152921553769214528] = 0;
        }
        public BestHTTP.Futures.IFuture<T> OnItem(BestHTTP.Futures.FutureValueCallback<T> callback)
        {
            if(W22 > 1)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if((X22 & 1) != 0)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            return (BestHTTP.Futures.IFuture<T>)this;
        }
        public BestHTTP.Futures.IFuture<T> OnSuccess(BestHTTP.Futures.FutureValueCallback<T> callback)
        {
            if(W22 == 2)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if(W22 == 3)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if((X22 & 1) != 0)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if(X22 != 0)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            return (BestHTTP.Futures.IFuture<T>)this;
        }
        public BestHTTP.Futures.IFuture<T> OnError(BestHTTP.Futures.FutureErrorCallback callback)
        {
            System.Exception val_2;
            if(137162752 == 3)
            {
                    val_2 = this;
                callback.Invoke(error:  this);
                return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if(__RuntimeMethodHiddenParam == 2)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if((__RuntimeMethodHiddenParam.Contains(item:  callback)) == true)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            __RuntimeMethodHiddenParam.Add(item:  callback);
            return (BestHTTP.Futures.IFuture<T>)this;
        }
        public BestHTTP.Futures.IFuture<T> OnComplete(BestHTTP.Futures.FutureCallback<T> callback)
        {
            if(W22 != 2)
            {
                    if(W22 != 3)
            {
                goto label_1;
            }
            
            }
            
            return (BestHTTP.Futures.IFuture<T>)this;
            label_1:
            if((X22 & 1) != 0)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            if(X22 != 0)
            {
                    return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            return (BestHTTP.Futures.IFuture<T>)this;
        }
        public BestHTTP.Futures.IFuture<T> Process(System.Func<T> func)
        {
            if(==0)
            {
                    mem[1152921553769826776] = func;
                bool val_2 = System.Threading.ThreadPool.QueueUserWorkItem(callBack:  new System.Threading.WaitCallback(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 104));
                return (BestHTTP.Futures.IFuture<T>)this;
            }
            
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "Cannot process a future that isn\'t in the Pending state.");
        }
        private void ThreadFunc(object param)
        {
            mem[1152921553769955160] = 0;
        }
        public void Assign(T value)
        {
            if(!=0)
            {
                    if(137162752 == 1)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot assign a value to a future that isn\'t in the Pending or Processing state.");
            }
            
            }
        
        }
        public void BeginProcess(T initialItem)
        {
            mem[1152921553770204736] = 1;
            mem[1152921553770204744] = initialItem;
        }
        public void AssignItem(T value)
        {
            var val_1;
            var val_2;
            var val_6;
            var val_7;
            var val_8;
            mem[1152921553770329048] = value;
            mem[1152921553770329056] = 0;
            label_4:
            if((1918829712 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_2.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            val_6 = 0;
            val_7 = 0;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 160;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 286) == 0)
            {
                goto label_13;
            }
            
            var val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_12:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (__RuntimeMethodHiddenParam + 24 + 192 + 160 + 286))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_8 = ((__RuntimeMethodHiddenParam + 24 + 192 + 160) + (((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 176 + 8)) << 4)) + 296;
            label_13:
            val_2.Dispose();
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public void Fail(System.Exception error)
        {
            if(!=0)
            {
                    if(137162752 == 1)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Cannot fail future that isn\'t in the Pending or Processing state.");
            }
            
            }
        
        }
        private void AssignImpl(T value)
        {
            mem[1152921553770582968] = value;
            mem[1152921553770582976] = 0;
            mem[1152921553770582960] = 2;
            if(this == null)
            {
                
            }
        
        }
        private void FailImpl(System.Exception error)
        {
            mem[1152921553770703160] = 0;
            mem[1152921553770703168] = error;
            mem[1152921553770703152] = 3;
            if(this == null)
            {
                
            }
        
        }
        private void FlushSuccessCallbacks()
        {
            var val_1;
            var val_2;
            var val_6;
            var val_7;
            var val_8;
            label_4:
            if((1919324016 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_2.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            val_6 = 0;
            val_7 = 0;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 160;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 286) == 0)
            {
                goto label_13;
            }
            
            var val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 160 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_12:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (__RuntimeMethodHiddenParam + 24 + 192 + 160 + 286))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_8 = ((__RuntimeMethodHiddenParam + 24 + 192 + 160) + (((__RuntimeMethodHiddenParam + 24 + 192 + 160 + 176 + 8)) << 4)) + 296;
            label_13:
            val_2.Dispose();
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private void FlushErrorCallbacks()
        {
            var val_4;
            var val_5;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if((1919447312 & 1) == 0)
            {
                goto label_2;
            }
            
            0.丐丏七丌丕丗业且上().Invoke(error:  this);
            goto label_4;
            label_2:
            val_4 = 0;
            val_5 = 0;
            var val_3 = 0;
            val_3 = val_3 + 1;
            null.Dispose();
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private void FlushComplationCallbacks()
        {
            var val_1;
            var val_2;
            var val_6;
            var val_7;
            var val_8;
            label_4:
            if((1919567536 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_2.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            val_6 = 0;
            val_7 = 0;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 216;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 216 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 216 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_11:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 216 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (__RuntimeMethodHiddenParam + 24 + 192 + 216 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            val_8 = ((__RuntimeMethodHiddenParam + 24 + 192 + 216) + (((__RuntimeMethodHiddenParam + 24 + 192 + 216 + 176 + 8)) << 4)) + 296;
            label_12:
            val_2.Dispose();
            if(this != null)
            {
                    return;
            }
        
        }
        private void ClearCallbacks()
        {
            Clear();
            if(this == null)
            {
                
            }
        
        }
    
    }

}
