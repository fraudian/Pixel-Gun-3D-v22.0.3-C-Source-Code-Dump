using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass29_0
{
    // Fields
    public System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass29_0()
    {
    
    }
    internal void <FindEqualVersionMatch>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)
    {
        var val_6;
        System.Action<System.Boolean, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> val_7;
        var val_8;
        var val_9;
        GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_10;
        val_6 = success;
        if(val_6 == false)
        {
            goto label_1;
        }
        
        val_6 = this.match.Version;
        if(val_6 != foundMatch.Version)
        {
            goto label_4;
        }
        
        val_7 = this.callback;
        val_8 = 1152921541833285136;
        val_9 = 1;
        val_10 = foundMatch;
        goto label_6;
        label_1:
        val_7 = this.callback;
        val_8 = 1152921541833285136;
        val_9 = 0;
        val_10 = 0;
        label_6:
        val_7.Invoke(arg1:  false, arg2:  val_10);
        return;
        label_4:
        GooglePlayGames.OurUtils.Logger.e(msg:  System.String.Format(format:  "Attempted to update a stale version of the match. Expected version was {0} but current version is {1}.", arg0:  this.match.Version, arg1:  foundMatch.Version));
        this.callback.Invoke(arg1:  false, arg2:  0);
    }

}
