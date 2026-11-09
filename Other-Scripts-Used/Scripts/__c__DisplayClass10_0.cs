using UnityEngine;
private sealed class AGSSocialLocalUser.<>c__DisplayClass10_0
{
    // Fields
    public System.Action<bool, string> callback;
    
    // Methods
    public AGSSocialLocalUser.<>c__DisplayClass10_0()
    {
    
    }
    internal void <Authenticate>b__0(bool success)
    {
        success = success;
        this.callback.Invoke(arg1:  success, arg2:  System.String.alignConst);
    }

}
