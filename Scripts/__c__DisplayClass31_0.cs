using UnityEngine;
private sealed class AndroidRealTimeMultiplayerClient.<>c__DisplayClass31_0
{
    // Fields
    public GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;
    public string invitationId;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.<>c__DisplayClass31_0()
    {
    
    }
    internal void <DeclineInvitation>b__1(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(this.invitationId != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(this.invitationId == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = this.invitationId;
        UnityEngine.AndroidJavaObject val_2 = this.<>4__this.mRtmpClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "declineInvitation", args:  val_1);
        if(val_2 == null)
        {
                return;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_2.Dispose();
    }

}
