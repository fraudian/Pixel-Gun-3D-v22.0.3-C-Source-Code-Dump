using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass27_0
{
    // Fields
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public string invitationId;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass27_0()
    {
    
    }
    internal void <DeclineInvitation>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)
    {
        GooglePlayGames.BasicApi.Multiplayer.Invitation val_4 = invitation;
        if(val_4 == null)
        {
                return;
        }
        
        object[] val_1 = new object[1];
        val_1[0] = this.invitationId;
        val_4 = this.<>4__this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "declineInvitation", args:  val_1);
        if(val_4 == null)
        {
                return;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4.Dispose();
    }

}
