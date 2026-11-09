using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass25_0
{
    // Fields
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass25_0()
    {
    
    }
    internal void <Dismiss>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)
    {
        bool val_5 = success;
        if(val_5 == false)
        {
                return;
        }
        
        object[] val_1 = new object[1];
        val_1[0] = this.match.MatchId;
        val_5 = this.<>4__this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "dismissMatch", args:  val_1);
        if(val_5 == null)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5.Dispose();
    }

}
