using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass11_0
{
    // Fields
    public string matchId;
    public System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass11_0()
    {
    
    }
    internal void <GetMatch>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_7;
        UnityEngine.AndroidJavaObject val_8;
        string val_9;
        val_8 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        if(val_8 == null)
        {
            goto label_2;
        }
        
        this.callback.Invoke(arg1:  true, arg2:  GooglePlayGames.Android.AndroidJavaConverter.ToTurnBasedMatch(turnBasedMatch:  val_8));
        val_9 = 0;
        var val_7 = 0;
        val_7 = val_7 + 1;
        goto label_7;
        label_2:
        val_9 = System.String.Format(format:  "Could not find match {0}", arg0:  this.matchId);
        GooglePlayGames.OurUtils.Logger.e(msg:  val_9);
        this.callback.Invoke(arg1:  false, arg2:  0);
        goto label_14;
        label_7:
        val_8.Dispose();
        if(val_9 != 1)
        {
                if(86 == 86)
        {
            goto label_14;
        }
        
        }
        
        if(0 != 0)
        {
                val_7 = ???;
            val_8 = ???;
            val_9 = ???;
        }
        
        label_14:
        var val_6 = val_7 - 32;
    }
    internal void <GetMatch>b__1(UnityEngine.AndroidJavaObject e)
    {
        this.callback.Invoke(arg1:  false, arg2:  0);
    }

}
