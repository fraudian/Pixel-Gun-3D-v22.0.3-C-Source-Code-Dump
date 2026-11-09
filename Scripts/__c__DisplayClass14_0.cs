using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0
{
    // Fields
    public string invitationId;
    public System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__1;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__2;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0()
    {
    
    }
    internal void <AcceptInvitation>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation)
    {
        System.Action<UnityEngine.AndroidJavaObject> val_13;
        System.Action<UnityEngine.AndroidJavaObject> val_14;
        var val_15;
        var val_16;
        if(invitation == null)
        {
            goto label_1;
        }
        
        object[] val_1 = new object[1];
        val_1[0] = this.invitationId;
        UnityEngine.AndroidJavaObject val_2 = this.<>4__this.mClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "acceptInvitation", args:  val_1);
        val_13 = this.<>9__1;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0::<AcceptInvitation>b__1(UnityEngine.AndroidJavaObject turnBasedMatch));
            this.<>9__1 = val_13;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_2, callback:  null);
        val_14 = this.<>9__2;
        if(val_14 == null)
        {
                val_14 = null;
            val_14 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass14_0::<AcceptInvitation>b__2(UnityEngine.AndroidJavaObject e));
            this.<>9__2 = val_14;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_2, callback:  null);
        val_15 = 0;
        val_16 = 0;
        if(val_2 == null)
        {
            goto label_24;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        goto label_14;
        label_1:
        GooglePlayGames.OurUtils.Logger.e(msg:  "Could not find invitation with id " + this.invitationId);
        this.callback.Invoke(arg1:  false, arg2:  0);
        return;
        label_14:
        val_2.Dispose();
        label_24:
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
    internal void <AcceptInvitation>b__1(UnityEngine.AndroidJavaObject turnBasedMatch)
    {
        this.callback.Invoke(arg1:  true, arg2:  GooglePlayGames.Android.AndroidJavaConverter.ToTurnBasedMatch(turnBasedMatch:  turnBasedMatch));
    }
    internal void <AcceptInvitation>b__2(UnityEngine.AndroidJavaObject e)
    {
        this.callback.Invoke(arg1:  false, arg2:  0);
    }

}
