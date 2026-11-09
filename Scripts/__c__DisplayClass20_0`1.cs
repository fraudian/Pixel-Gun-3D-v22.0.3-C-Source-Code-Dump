using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass20_0<T>
{
    // Fields
    public System.Action<T> callback;
    public T data;
    
    // Methods
    public AndroidClient.<>c__DisplayClass20_0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <InvokeCallbackOnGameThread>b__0()
    {
        GooglePlayGames.OurUtils.Logger.d(msg:  "Invoking user callback on game thread");
        var val_1 = (this != 0) ? 1 : 0;
        goto __RuntimeMethodHiddenParam + 24 + 192;
    }

}
