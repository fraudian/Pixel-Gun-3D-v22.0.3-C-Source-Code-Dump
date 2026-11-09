using UnityEngine;
private sealed class AndroidNearbyConnectionClient.<>c__DisplayClass31_0<T>
{
    // Fields
    public System.Action<T> toConvert;
    
    // Methods
    public AndroidNearbyConnectionClient.<>c__DisplayClass31_0<T>()
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
                mem[32] = this;
        }
        
        mem2[0] = val.mStatus;
        mem2[0] = val.mLocalEndpointName;
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 192, method:  __RuntimeMethodHiddenParam + 24 + 192 + 16));
    }

}
