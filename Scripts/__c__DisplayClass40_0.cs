using UnityEngine;
private sealed class AndroidClient.<>c__DisplayClass40_0
{
    // Fields
    public System.Action<GooglePlayGames.BasicApi.Achievement[]> callback;
    
    // Methods
    public AndroidClient.<>c__DisplayClass40_0()
    {
    
    }
    internal void <LoadAchievements>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_46;
        UnityEngine.AndroidJavaObject val_2 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        int val_4 = val_2.Call<System.Int32>(methodName:  "getCount", args:  System.Array.Empty<System.Object>());
        GooglePlayGames.BasicApi.Achievement[] val_5 = new GooglePlayGames.BasicApi.Achievement[0];
        if(val_4 < 1)
        {
            goto label_3;
        }
        
        object val_42 = 0;
        val_40 = 0;
        var val_39 = 0;
        goto label_97;
        label_3:
        val_41 = 0;
        val_42 = 0;
        label_98:
        val_2.Call(methodName:  "release", args:  System.Array.Empty<System.Object>());
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.Achievement[]>(callback:  mem[1152921541765648016], data:  val_5);
        val_43 = 0 + 1;
        mem2[0] = 457;
        if(val_2 != null)
        {
            goto label_8;
        }
        
        goto label_110;
        label_97:
        new GooglePlayGames.BasicApi.Achievement() = new GooglePlayGames.BasicApi.Achievement();
        object[] val_8 = new object[1];
        val_8[0] = val_42;
        UnityEngine.AndroidJavaObject val_9 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_8);
        new GooglePlayGames.BasicApi.Achievement().Id = val_9.Call<System.String>(methodName:  "getAchievementId", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.Achievement().Description = val_9.Call<System.String>(methodName:  "getDescription", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.Achievement().Name = val_9.Call<System.String>(methodName:  "getName", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.Achievement().Points = val_9.Call<System.UInt64>(methodName:  "getXpValue", args:  System.Array.Empty<System.Object>());
        System.DateTime val_20 = GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  val_9.Call<System.Int64>(methodName:  "getLastUpdatedTimestamp", args:  System.Array.Empty<System.Object>()));
        new GooglePlayGames.BasicApi.Achievement().LastModifiedTime = new System.DateTime() {dateData = val_20.dateData};
        new GooglePlayGames.BasicApi.Achievement().RevealedImageUrl = val_9.Call<System.String>(methodName:  "getRevealedImageUrl", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.Achievement().UnlockedImageUrl = val_9.Call<System.String>(methodName:  "getUnlockedImageUrl", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.Achievement().IsIncremental = ((val_9.Call<System.Int32>(methodName:  "getType", args:  System.Array.Empty<System.Object>())) == 1) ? 1 : 0;
        if(new GooglePlayGames.BasicApi.Achievement().IsIncremental != false)
        {
                new GooglePlayGames.BasicApi.Achievement().CurrentSteps = val_9.Call<System.Int32>(methodName:  "getCurrentSteps", args:  System.Array.Empty<System.Object>());
            new GooglePlayGames.BasicApi.Achievement().TotalSteps = val_9.Call<System.Int32>(methodName:  "getTotalSteps", args:  System.Array.Empty<System.Object>());
        }
        
        int val_34 = val_9.Call<System.Int32>(methodName:  "getState", args:  System.Array.Empty<System.Object>());
        new GooglePlayGames.BasicApi.Achievement().IsUnlocked = (val_34 == 0) ? 1 : 0;
        new GooglePlayGames.BasicApi.Achievement().IsRevealed = (val_34 == 1) ? 1 : 0;
        val_46 = -1495916784;
        val_39 = val_39 + 1;
        mem2[0] = 401;
        if(val_9 != null)
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_9.Dispose();
        }
        
        if((val_39 == 1) || ((val_46 + ((0 + 1)) << 2) != 401))
        {
            goto label_87;
        }
        
        var val_41 = 0;
        val_41 = val_41 ^ (val_39 >> 31);
        val_39 = val_39 + val_41;
        if(val_5 != null)
        {
            goto label_93;
        }
        
        goto label_92;
        label_87:
        if(val_40 == 0)
        {
            goto label_90;
        }
        
        if(val_5 != null)
        {
            goto label_93;
        }
        
        goto label_92;
        label_90:
        if(val_5 != null)
        {
            goto label_93;
        }
        
        label_92:
        label_93:
        val_42 = val_42 + 1;
        val_5[val_42] = new GooglePlayGames.BasicApi.Achievement();
        if(val_42 < (long)val_4)
        {
            goto label_97;
        }
        
        goto label_98;
        label_8:
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_2.Dispose();
        label_110:
        if(val_43 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((val_39 + ((0 + 1)) << 2) == 457)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal void <LoadAchievements>b__1(UnityEngine.AndroidJavaObject exception)
    {
        UnityEngine.Debug.Log(message:  "LoadAchievements failed");
        GooglePlayGames.Android.AndroidClient.InvokeCallbackOnGameThread<GooglePlayGames.BasicApi.Achievement[]>(callback:  this.callback, data:  new GooglePlayGames.BasicApi.Achievement[0]);
    }

}
