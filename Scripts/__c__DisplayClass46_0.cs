using UnityEngine;
private sealed class PlayGamesPlatform.<>c__DisplayClass46_0
{
    // Fields
    public System.Action<string> callback;
    public GooglePlayGames.PlayGamesPlatform <>4__this;
    
    // Methods
    public PlayGamesPlatform.<>c__DisplayClass46_0()
    {
    
    }
    internal void <GetAnotherServerAuthCode>b__0(bool success, string msg)
    {
        System.Action<System.String> val_3;
        var val_5;
        string val_6;
        if(success == false)
        {
            goto label_1;
        }
        
        val_3 = this.callback;
        var val_4 = 0;
        val_4 = val_4 + 1;
        goto label_7;
        label_1:
        GooglePlayGames.OurUtils.Logger.e(msg:  "Re-authentication failed: "("Re-authentication failed: ") + msg);
        val_3 = this.callback;
        val_5 = 1152921523968236400;
        val_6 = 0;
        goto label_11;
        label_7:
        val_5 = 1152921523968236400;
        val_6 = this.<>4__this.mClient.GetServerAuthCode();
        label_11:
        val_3.Invoke(obj:  val_6);
    }

}
