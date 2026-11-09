using UnityEngine;
private sealed class GameCircleSocial.<>c__DisplayClass25_0
{
    // Fields
    public System.Action<bool, string> callback;
    
    // Methods
    public GameCircleSocial.<>c__DisplayClass25_0()
    {
    
    }
    internal void <Authenticate>b__0(bool success)
    {
        success = success;
        this.callback.Invoke(arg1:  success, arg2:  System.String.alignConst);
    }

}
