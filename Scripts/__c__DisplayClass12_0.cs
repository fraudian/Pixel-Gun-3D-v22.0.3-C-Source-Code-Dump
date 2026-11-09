using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass12_0
{
    // Fields
    public string matchId;
    public System.Action<bool, UnityEngine.AndroidJavaObject> callback;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass12_0()
    {
    
    }
    internal void <GetMatchAndroidJavaObject>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_6;
        UnityEngine.AndroidJavaObject val_7;
        string val_8;
        val_7 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        if(val_7 == null)
        {
            goto label_2;
        }
        
        this.callback.Invoke(arg1:  true, arg2:  val_7);
        val_8 = 0;
        var val_6 = 0;
        val_6 = val_6 + 1;
        goto label_7;
        label_2:
        val_8 = System.String.Format(format:  "Could not find match {0}", arg0:  this.matchId);
        GooglePlayGames.OurUtils.Logger.e(msg:  val_8);
        this.callback.Invoke(arg1:  false, arg2:  0);
        goto label_14;
        label_7:
        val_7.Dispose();
        if(val_8 != 1)
        {
                if(81 == 81)
        {
            goto label_14;
        }
        
        }
        
        if(0 != 0)
        {
                val_6 = ???;
            val_7 = ???;
            val_8 = ???;
        }
        
        label_14:
        var val_5 = val_6 - 32;
    }
    internal void <GetMatchAndroidJavaObject>b__1(UnityEngine.AndroidJavaObject exception)
    {
        this.callback.Invoke(arg1:  false, arg2:  0);
    }

}
