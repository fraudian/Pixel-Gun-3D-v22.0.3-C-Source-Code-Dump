using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass36_0
{
    // Fields
    public System.Action<bool> callback;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass36_0()
    {
    
    }
    internal void <Authenticate>b__0(bool success, string msg)
    {
        success = success;
        this.callback.Invoke(obj:  success);
    }

}
