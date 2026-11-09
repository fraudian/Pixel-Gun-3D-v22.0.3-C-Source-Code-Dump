using UnityEngine;
private sealed class AndroidSavedGameClient.<>c__DisplayClass15_0<T1, T2>
{
    // Fields
    public System.Action<T1, T2> toConvert;
    
    // Methods
    public AndroidSavedGameClient.<>c__DisplayClass15_0<T1, T2>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <ToOnGameThread>b__0(T1 val1, T2 val2)
    {
        if((__RuntimeMethodHiddenParam + 24 + 192) != 0)
        {
                mem2[0] = this;
            mem2[0] = val1;
        }
        else
        {
                mem[32] = this;
            mem[16] = val1;
        }
        
        mem2[0] = val2;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 192, method:  __RuntimeMethodHiddenParam + 24 + 192 + 16));
    }

}
