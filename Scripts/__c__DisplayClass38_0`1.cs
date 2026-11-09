using UnityEngine;
private sealed class AndroidRealTimeMultiplayerClient.<>c__DisplayClass38_0<T>
{
    // Fields
    public System.Action<T> toConvert;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.<>c__DisplayClass38_0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal void <ToOnGameThread>b__0(T val)
    {
        if((__RuntimeMethodHiddenParam + 24 + 192) != 0)
        {
                mem2[0] = this;
        }
        else
        {
                mem[24] = this;
        }
        
        mem2[0] = val;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 192, method:  __RuntimeMethodHiddenParam + 24 + 192 + 16));
    }

}
