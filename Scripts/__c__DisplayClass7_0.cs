using UnityEngine;
private sealed class AndroidVideoClient.<>c__DisplayClass7_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback;
    
    // Methods
    public AndroidVideoClient.<>c__DisplayClass7_0()
    {
    
    }
    internal void <IsCaptureAvailable>b__0(bool isCaptureAvailable)
    {
        this.callback.Invoke(arg1:  1, arg2:  isCaptureAvailable);
    }
    internal void <IsCaptureAvailable>b__1(UnityEngine.AndroidJavaObject exception)
    {
        this.callback.Invoke(arg1:  -2, arg2:  false);
    }

}
