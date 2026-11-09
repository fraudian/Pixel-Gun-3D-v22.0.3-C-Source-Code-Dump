using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass48_1
{
    // Fields
    public GooglePlayGames.BasicApi.UIStatus status;
    public GooglePlayGames.Android.AndroidClient.<>c__DisplayClass48_0 CS$<>8__locals1;
    
    // Methods
    public AndroidClient.<>c__DisplayClass48_1()
    {
    
    }
    internal void <GetUiSignOutCallbackOnGameThread>b__1()
    {
        if((this.CS$<>8__locals1.callback) == null)
        {
                return;
        }
        
        this.CS$<>8__locals1.callback.Invoke(obj:  this.status);
    }

}
