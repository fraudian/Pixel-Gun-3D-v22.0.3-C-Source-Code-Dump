using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass48_0
{
    // Fields
    public GooglePlayGames.Android.AndroidClient <>4__this;
    public System.Action<GooglePlayGames.BasicApi.UIStatus> callback;
    
    // Methods
    public AndroidClient.<>c__DisplayClass48_0()
    {
    
    }
    internal void <GetUiSignOutCallbackOnGameThread>b__0(GooglePlayGames.BasicApi.UIStatus status)
    {
        GooglePlayGames.BasicApi.UIStatus val_3;
        GooglePlayGames.BasicApi.UIStatus val_4;
        val_3 = status;
        AndroidClient.<>c__DisplayClass48_1 val_1 = new AndroidClient.<>c__DisplayClass48_1();
        if(val_1 != null)
        {
                val_4 = val_1;
            .status = val_3;
            mem[1152921541766631624] = this;
        }
        else
        {
                mem[24] = this;
            val_4 = 16;
            mem[16] = val_3;
            val_3 = mem[16];
        }
        
        if(val_3 == 3)
        {
                this.<>4__this.SignOut(uiCallback:  new System.Action(object:  val_1, method:  System.Void AndroidClient.<>c__DisplayClass48_1::<GetUiSignOutCallbackOnGameThread>b__1()));
            return;
        }
        
        if(this.callback == null)
        {
                return;
        }
        
        this.callback.Invoke(obj:  val_4);
    }

}
