using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0
{
    // Fields
    public System.Action<bool> callback;
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__1;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__2;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0()
    {
    
    }
    internal void <Leave>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)
    {
        System.Action<UnityEngine.AndroidJavaObject> val_13;
        System.Action<UnityEngine.AndroidJavaObject> val_14;
        var val_15;
        var val_16;
        if(success != true)
        {
                this.callback.Invoke(obj:  false);
        }
        
        object[] val_1 = new object[1];
        val_1[0] = this.match.MatchId;
        UnityEngine.AndroidJavaObject val_3 = this.<>4__this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "leaveMatch", args:  val_1);
        val_13 = this.<>9__1;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0::<Leave>b__1(UnityEngine.AndroidJavaObject v));
            this.<>9__1 = val_13;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_3, callback:  null);
        val_14 = this.<>9__2;
        if(val_14 == null)
        {
                val_14 = null;
            val_14 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass22_0::<Leave>b__2(UnityEngine.AndroidJavaObject exception));
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
    internal void <Leave>b__1(UnityEngine.AndroidJavaObject v)
    {
        this.callback.Invoke(obj:  true);
    }
    internal void <Leave>b__2(UnityEngine.AndroidJavaObject exception)
    {
        this.callback.Invoke(obj:  false);
    }

}
