using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0
{
    // Fields
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public byte[] data;
    public string pendingParticipantId;
    public System.Action<bool> callback;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__1;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__2;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0()
    {
    
    }
    internal void <TakeTurn>b__0(GooglePlayGames.BasicApi.Multiplayer.Participant pendingParticipant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)
    {
        System.Action<UnityEngine.AndroidJavaObject> val_13;
        System.Action<UnityEngine.AndroidJavaObject> val_14;
        var val_15;
        var val_16;
        object[] val_1 = new object[3];
        val_1[0] = foundMatch.MatchId;
        val_1[1] = this.data;
        val_1[2] = this.pendingParticipantId;
        UnityEngine.AndroidJavaObject val_3 = this.<>4__this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "takeTurn", args:  val_1);
        val_13 = this.<>9__1;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0::<TakeTurn>b__1(UnityEngine.AndroidJavaObject turnBasedMatch));
            this.<>9__1 = val_13;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_3, callback:  null);
        val_14 = this.<>9__2;
        if(val_14 == null)
        {
                val_14 = null;
            val_14 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass18_0::<TakeTurn>b__2(UnityEngine.AndroidJavaObject exception));
            this.<>9__2 = val_14;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_3, callback:  null);
        val_15 = 0;
        val_16 = 0;
        if(val_3 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_3.Dispose();
        }
        
        if(val_15 != 1)
        {
                return;
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        val_16 = ???;
        val_15 = ???;
    }
    internal void <TakeTurn>b__1(UnityEngine.AndroidJavaObject turnBasedMatch)
    {
        this.callback.Invoke(obj:  true);
    }
    internal void <TakeTurn>b__2(UnityEngine.AndroidJavaObject exception)
    {
        GooglePlayGames.OurUtils.Logger.d(msg:  "Taking turn failed");
        this.callback.Invoke(obj:  false);
    }

}
