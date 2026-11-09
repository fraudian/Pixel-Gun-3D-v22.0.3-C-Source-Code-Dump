using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass13_0
{
    // Fields
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    public System.Action <>9__1;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass13_0()
    {
    
    }
    internal void <AcceptFromInbox>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch turnBasedMatch)
    {
        string val_3;
        System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> val_4;
        var val_5;
        var val_6;
        GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_7;
        val_3 = status;
        if(val_3 == 1)
        {
            goto label_1;
        }
        
        if(val_3 != 3)
        {
            goto label_2;
        }
        
        if((this.<>9__1) == null)
        {
            goto label_4;
        }
        
        label_12:
        this.<>4__this.mAndroidClient.SignOut(uiCallback:  this.<>9__1);
        return;
        label_1:
        val_3 = "Passing converted match to user callback:"("Passing converted match to user callback:") + turnBasedMatch;
        GooglePlayGames.OurUtils.Logger.d(msg:  val_3);
        val_4 = this.callback;
        val_5 = 1152921541833285136;
        val_6 = 1;
        val_7 = turnBasedMatch;
        goto label_9;
        label_2:
        val_4 = this.callback;
        val_5 = 1152921541833285136;
        val_6 = 0;
        val_7 = 0;
        label_9:
        val_4.Invoke(arg1:  false, arg2:  val_7);
        return;
        label_4:
        this.<>9__1 = new System.Action(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass13_0::<AcceptFromInbox>b__1());
        if((this.<>4__this.mAndroidClient) != null)
        {
            goto label_12;
        }
        
        goto label_12;
    }
    internal void <AcceptFromInbox>b__1()
    {
        this.callback.Invoke(arg1:  false, arg2:  0);
    }

}
