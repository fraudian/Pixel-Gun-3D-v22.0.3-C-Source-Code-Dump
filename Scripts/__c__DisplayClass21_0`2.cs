using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass21_0<T1, T2>
{
    // Fields
    public System.Action<T1, T2> toInvokeOnGameThread;
    
    // Methods
    public AndroidClient.<>c__DisplayClass21_0<T1, T2>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <AsOnGameThreadCallback>b__0(T1 result1, T2 result2)
    {
        if((__RuntimeMethodHiddenParam + 24 + 192) != 0)
        {
                mem2[0] = this;
            mem2[0] = result1;
        }
        else
        {
                mem[32] = this;
            mem[16] = result1;
        }
        
        bool val_1 = result2;
        mem2[0] = val_1;
        if(val_1 == false)
        {
                return;
        }
        
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 192, method:  __RuntimeMethodHiddenParam + 24 + 192 + 16));
    }

}
