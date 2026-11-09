using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass18_1
{
    // Fields
    public UnityEngine.AndroidJavaObject taskGetPlayer;
    public UnityEngine.AndroidJavaObject taskIsCaptureSupported;
    public UnityEngine.AndroidJavaObject taskGetActivationHint;
    public GooglePlayGames.Android.AndroidClient.<>c__DisplayClass18_0 CS$<>8__locals1;
    
    // Methods
    public AndroidClient.<>c__DisplayClass18_1()
    {
    
    }
    internal void <Authenticate>b__1(UnityEngine.AndroidJavaObject completeTask)
    {
        System.Object[] val_35;
        var val_36;
        var val_37;
        var val_38;
        System.Action<System.Boolean, System.String> val_40;
        var val_41;
        AndroidClient.<>c__DisplayClass18_0 val_43;
        GooglePlayGames.Android.AndroidClient val_44;
        AndroidClient.<>c__DisplayClass18_0 val_45;
        GooglePlayGames.Android.AndroidClient val_46;
        GooglePlayGames.BasicApi.Multiplayer.MatchDelegate val_47;
        var val_48;
        var val_52;
        var val_54;
        var val_55;
        val_35 = System.Array.Empty<System.Object>();
        val_36 = 1152921516267287104;
        if((completeTask.Call<System.Boolean>(methodName:  "isSuccessful", args:  val_35)) == false)
        {
            goto label_2;
        }
        
        UnityEngine.AndroidJavaObject val_4 = this.taskGetPlayer.Call<UnityEngine.AndroidJavaObject>(methodName:  "getResult", args:  System.Array.Empty<System.Object>());
        val_37 = 0;
        val_38 = 0;
        this.CS$<>8__locals1.<>4__this.mUser = GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_4);
        if(val_4 == null)
        {
            goto label_193;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_10;
        label_2:
        this.CS$<>8__locals1.<>4__this.SignOut(uiCallback:  0);
        val_40 = this.CS$<>8__locals1.callback;
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean, System.String>(callback:  val_40, t1:  false, t2:  "Authentication failed");
        GooglePlayGames.OurUtils.Logger.d(msg:  "Authentication failed");
        return;
        label_10:
        val_4.Dispose();
        label_193:
        if((val_37 != 1) && (79 == 79))
        {
                val_37 = 0;
        }
        else
        {
                if(val_38 != 0)
        {
                val_38 = 0;
        }
        
        }
        
        UnityEngine.AndroidJavaObject val_7 = this.CS$<>8__locals1.<>4__this.mTokenClient.GetAccount();
        bool val_8 = false;
        System.Threading.Monitor.Enter(obj:  this.CS$<>8__locals1.<>4__this.GameServicesLock, lockTaken: ref  val_8);
        new GooglePlayGames.Android.AndroidSavedGameClient() = new GooglePlayGames.Android.AndroidSavedGameClient(account:  val_7);
        this.CS$<>8__locals1.<>4__this.mSavedGameClient = new GooglePlayGames.Android.AndroidSavedGameClient();
        new GooglePlayGames.Android.AndroidEventsClient() = new GooglePlayGames.Android.AndroidEventsClient(account:  val_7);
        this.CS$<>8__locals1.<>4__this.mEventsClient = new GooglePlayGames.Android.AndroidEventsClient();
        UnityEngine.AndroidJavaObject val_12 = this.taskIsCaptureSupported.Call<UnityEngine.AndroidJavaObject>(methodName:  "getResult", args:  System.Array.Empty<System.Object>());
        val_41 = 1;
        if(val_12 != null)
        {
                var val_36 = 0;
            val_36 = val_36 + 1;
            val_12.Dispose();
        }
        
        if((val_41 != 1) && (234 == 234))
        {
                var val_37 = 0;
            val_37 = val_37 ^ 0;
            val_41 = val_41 + val_37;
        }
        else
        {
                if(val_38 != 0)
        {
                val_38 = 0;
        }
        
        }
        
        new GooglePlayGames.Android.AndroidVideoClient() = new GooglePlayGames.Android.AndroidVideoClient(isCaptureSupported:  val_12.Call<System.Boolean>(methodName:  "booleanValue", args:  System.Array.Empty<System.Object>()), account:  val_7);
        this.CS$<>8__locals1.<>4__this.mVideoClient = new GooglePlayGames.Android.AndroidVideoClient();
        val_43 = this.CS$<>8__locals1;
        if(val_43 != null)
        {
                val_44 = this.CS$<>8__locals1.<>4__this;
        }
        else
        {
                val_44 = this.CS$<>8__locals1.<>4__this;
            if((this.CS$<>8__locals1) != null)
        {
                val_43 = this.CS$<>8__locals1;
        }
        else
        {
                val_43 = 0;
        }
        
        }
        
        new GooglePlayGames.Android.AndroidRealTimeMultiplayerClient() = new GooglePlayGames.Android.AndroidRealTimeMultiplayerClient(androidClient:  11993091, account:  val_7);
        this.CS$<>8__locals1.<>4__this.mRealTimeClient = new GooglePlayGames.Android.AndroidRealTimeMultiplayerClient();
        val_45 = this.CS$<>8__locals1;
        if(val_45 != null)
        {
                val_46 = this.CS$<>8__locals1.<>4__this;
        }
        else
        {
                val_46 = this.CS$<>8__locals1.<>4__this;
            if((this.CS$<>8__locals1) != null)
        {
                val_45 = this.CS$<>8__locals1;
        }
        else
        {
                val_45 = 0;
        }
        
        }
        
        new GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient() = new GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient(androidClient:  11993091, account:  val_7);
        this.CS$<>8__locals1.<>4__this.mTurnBasedClient = new GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient();
        val_47 = this.CS$<>8__locals1.<>4__this.mConfiguration.AccountName;
        this.CS$<>8__locals1.<>4__this.mTurnBasedClient.RegisterMatchDelegate(del:  val_47);
        val_48 = val_41 + 1;
        mem2[0] = 390;
        if(val_8 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.CS$<>8__locals1.<>4__this.GameServicesLock);
        }
        
        if((val_48 != 1) && ((1152921541759789504 + ((val_41 + 1)) << 2) == 390))
        {
                var val_38 = 0;
            val_38 = val_38 ^ (val_48 >> 31);
            val_48 = val_48 + val_38;
        }
        else
        {
                if(val_38 != 0)
        {
                val_38 = 0;
        }
        
        }
        
        this.CS$<>8__locals1.<>4__this.mAuthState = 1;
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<System.Boolean, System.String>(callback:  this.CS$<>8__locals1.callback, t1:  true, t2:  "Authentication succeeded");
        GooglePlayGames.OurUtils.Logger.d(msg:  "Authentication succeeded");
        val_36 = 1152921516267089008;
        val_35 = this.taskGetActivationHint.Call<UnityEngine.AndroidJavaObject>(methodName:  "getResult", args:  System.Array.Empty<System.Object>());
        if((this.CS$<>8__locals1.<>4__this.mInvitationDelegate) != null)
        {
                object[] val_23 = new object[1];
            val_23[0] = "invitation";
            UnityEngine.AndroidJavaObject val_24 = val_35.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParcelable", args:  val_23);
            val_47 = GooglePlayGames.Android.AndroidJavaConverter.ToInvitation(invitation:  val_24);
            this.CS$<>8__locals1.<>4__this.mInvitationDelegate.Invoke(arg1:  val_47, arg2:  true);
            val_48 = val_48 + 1;
            mem2[0] = 561;
            if(val_24 != null)
        {
                var val_39 = 0;
            val_39 = val_39 + 1;
            val_24.Dispose();
        }
        
            if((val_48 != 1) && ((1152921541759789504 + (((val_41 + 1) + 1)) << 2) == 561))
        {
                var val_40 = 0;
            val_40 = val_40 ^ (val_48 >> 31);
            val_48 = val_48 + val_40;
        }
        else
        {
                if(val_38 != 0)
        {
                val_38 = 0;
        }
        
        }
        
        }
        
        if((this.CS$<>8__locals1.<>4__this.mTurnBasedClient.MatchDelegate) != null)
        {
                object[] val_28 = new object[1];
            val_28[0] = "turn_based_match";
            UnityEngine.AndroidJavaObject val_29 = val_35.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParcelable", args:  val_28);
            val_47 = GooglePlayGames.Android.AndroidJavaConverter.ToTurnBasedMatch(turnBasedMatch:  val_29);
            this.CS$<>8__locals1.<>4__this.mTurnBasedClient.MatchDelegate.Invoke(arg1:  val_47, arg2:  true);
            val_48 = val_48 + 1;
            mem2[0] = 673;
            if(val_29 != null)
        {
                var val_41 = 0;
            val_41 = val_41 + 1;
            val_29.Dispose();
        }
        
            if((val_48 != 1) && ((1152921541759789504 + ((((val_41 + 1) + 1) + 1)) << 2) == 673))
        {
                var val_42 = 0;
            val_42 = val_42 ^ (val_48 >> 31);
            val_48 = val_48 + val_42;
        }
        else
        {
                if(val_38 != 0)
        {
                val_38 = 0;
        }
        
        }
        
        }
        
        val_48 = val_48 + 1;
        mem2[0] = 692;
        if(val_35 != null)
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            val_35.Dispose();
        }
        
        if(val_48 == 1)
        {
            goto label_120;
        }
        
        if(val_38 == 0)
        {
            goto label_217;
        }
        
        if((1152921541759789504 + (((((val_41 + 1) + 1) + 1) + 1)) << 2) != 692)
        {
            goto label_122;
        }
        
        goto label_217;
        label_120:
        if(val_38 == 0)
        {
            goto label_217;
        }
        
        label_122:
        label_217:
        val_40 = this.CS$<>8__locals1.<>4__this;
        val_52 = null;
        val_52 = null;
        if((AndroidClient.<>c.<>9__18_2) == null)
        {
            goto label_128;
        }
        
        label_133:
        val_40.LoadAchievements(callback:  AndroidClient.<>c.<>9__18_2);
        return;
        label_128:
        AndroidClient.<>c.<>9__18_2 = new System.Action<GooglePlayGames.BasicApi.Achievement[]>(object:  AndroidClient.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AndroidClient.<>c::<Authenticate>b__18_2(GooglePlayGames.BasicApi.Achievement[] ignore));
        if(val_40 != null)
        {
            goto label_133;
        }
        
        goto label_133;
        label_218:
        val_54 = AndroidClient.<>c.__il2cppRuntimeField_static_fields;
        val_55 = 0;
        if(val_54 != 1)
        {
            goto label_221;
        }
        
        if((null & 1) == 0)
        {
            goto label_216;
        }
        
        goto label_217;
        label_216:
        mem[8] = 1179403647;
        goto label_218;
        label_221:
    }

}
