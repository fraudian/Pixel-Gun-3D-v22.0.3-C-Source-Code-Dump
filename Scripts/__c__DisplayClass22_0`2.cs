using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass22_0<T1, T2>
{
    // Fields
    public System.Action<T1, T2> callback;
    public T1 t1;
    public T2 t2;
    
    // Methods
    public AndroidClient.<>c__DisplayClass22_0<T1, T2>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <InvokeCallbackOnGameThread>b__0()
    {
        GooglePlayGames.OurUtils.Logger.d(msg:  "Invoking user callback on game thread");
        var val_1 = (W22 != 0) ? 1 : 0;
        goto __RuntimeMethodHiddenParam + 24 + 192;
    }

}
