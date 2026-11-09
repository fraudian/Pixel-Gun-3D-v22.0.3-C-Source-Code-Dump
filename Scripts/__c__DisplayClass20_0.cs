using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0
{
    // Fields
    public System.Action<bool> callback;
    public GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome;
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    public byte[] data;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__1;
    public System.Action<UnityEngine.AndroidJavaObject> <>9__2;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0()
    {
    
    }
    internal void <Finish>b__0(bool status, UnityEngine.AndroidJavaObject foundMatch)
    {
        var val_43;
        var val_44;
        UnityEngine.AndroidJavaObject val_45;
        var val_46;
        AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0 val_51;
        var val_52;
        UnityEngine.AndroidJavaObject val_53;
        string val_55;
        var val_57;
        var val_58;
        var val_61;
        var val_62;
        System.Action<UnityEngine.AndroidJavaObject> val_63;
        val_43 = foundMatch;
        if(status == false)
        {
            goto label_1;
        }
        
        val_44 = 1152921516266839504;
        UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.ArrayList", args:  System.Array.Empty<System.Object>());
        System.Collections.Generic.Dictionary<System.String, UnityEngine.AndroidJavaObject> val_3 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AndroidJavaObject>();
        UnityEngine.AndroidJavaObject val_5 = val_43.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParticipants", args:  System.Array.Empty<System.Object>());
        int val_7 = val_5.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>());
        if(val_7 < 1)
        {
            goto label_4;
        }
        
        object val_43 = 0;
        val_43 = 0;
        do
        {
            object[] val_8 = new object[1];
            val_8[0] = val_43;
            val_45 = val_5.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_8).Call<UnityEngine.AndroidJavaObject>(methodName:  "getResult", args:  System.Array.Empty<System.Object>());
            null.set_Item(key:  val_45.Call<System.String>(methodName:  "getParticipantId", args:  System.Array.Empty<System.Object>()), value:  val_45);
            object[] val_14 = new object[1];
            val_14[0] = val_45;
            UnityEngine.AndroidJavaObject val_15 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "add", args:  val_14);
            val_46 = 0 + 1;
            mem2[0] = 188;
            if(val_45 != null)
        {
                var val_41 = 0;
            val_41 = val_41 + 1;
            val_45.Dispose();
        }
        
            if((val_46 != 1) && ((-1421738448 + ((0 + 1)) << 2) == 188))
        {
                var val_42 = 0;
            val_42 = val_42 ^ (val_46 >> 31);
            val_46 = val_46 + val_42;
        }
        else
        {
                if(val_43 != 0)
        {
                val_43 = 0;
        }
        
        }
        
            val_43 = val_43 + 1;
        }
        while(val_43 < val_7);
        
        goto label_28;
        label_1:
        val_51 = mem[1152921541839826432];
        val_51.Invoke(obj:  false);
        return;
        label_4:
        val_43 = 0;
        val_46 = 0;
        label_28:
        val_52 = val_46 + 1;
        mem2[0] = 216;
        val_53 = val_2;
        if(val_5 != null)
        {
                var val_44 = 0;
            val_44 = val_44 + 1;
            val_5.Dispose();
        }
        
        if((val_52 != 1) && ((-1421738448 + ((val_46 + 1)) << 2) == 216))
        {
                var val_45 = 0;
            val_45 = val_45 ^ (val_52 >> 31);
            val_52 = val_52 + val_45;
        }
        else
        {
                if(val_43 != 0)
        {
                val_43 = 0;
        }
        
        }
        
        val_55 = mem[1152921541839826440].ParticipantIds;
        List.Enumerator<T> val_19 = val_55.GetEnumerator();
        label_94:
        if(((-1421738352) & 1) == 0)
        {
            goto label_58;
        }
        
        val_55 = val_43.丐丏七丌丕丗业且上();
        ParticipantResult val_22 = mem[1152921541839826440].GetResultFor(participantId:  val_55);
        uint val_23 = mem[1152921541839826440].GetPlacementFor(participantId:  val_55);
        if((null.ContainsKey(key:  val_55)) == false)
        {
            goto label_62;
        }
        
        val_45 = null.Item[val_55].Get<System.Int32>(fieldName:  "result");
        val_44 = null.Item[val_55];
        int val_28 = val_44.Get<System.Int32>(fieldName:  "placing");
        if(val_22 != val_45)
        {
            goto label_69;
        }
        
        if(val_23 == val_28)
        {
            goto label_94;
        }
        
        goto label_69;
        label_62:
        object[] val_29 = new object[3];
        val_29[0] = val_55;
        val_29[1] = val_22;
        val_29[2] = val_23;
        new UnityEngine.AndroidJavaObject() = new UnityEngine.AndroidJavaObject(className:  "com.google.android.gms.games.multiplayer.ParticipantResult", args:  val_29);
        object[] val_31 = new object[1];
        val_31[0] = new UnityEngine.AndroidJavaObject();
        bool val_32 = val_2.Call<System.Boolean>(methodName:  "add", args:  val_31);
        val_52 = val_52 + 1;
        mem2[0] = 471;
        if(new UnityEngine.AndroidJavaObject() != null)
        {
                var val_46 = 0;
            val_46 = val_46 + 1;
            new UnityEngine.AndroidJavaObject().Dispose();
        }
        
        if((val_52 == 1) || ((-1421738448 + (((val_46 + 1) + 1)) << 2) != 471))
        {
            goto label_91;
        }
        
        var val_47 = 0;
        val_47 = val_47 ^ (val_52 >> 31);
        val_52 = val_52 + val_47;
        goto label_94;
        label_91:
        if(val_43 == 0)
        {
            goto label_94;
        }
        
        goto label_94;
        label_58:
        val_57 = val_52 + 1;
        val_58 = 499;
        goto label_98;
        label_69:
        GooglePlayGames.OurUtils.Logger.e(msg:  System.String.Format(format:  "Attempted to override existing results for participant {0}: Placing {1}, Result {2}", arg0:  val_55, arg1:  val_28, arg2:  val_45));
        mem[1152921541839826432].Invoke(obj:  false);
        val_57 = val_52 + 1;
        val_58 = 661;
        label_98:
        mem2[0] = 661;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_51 = this;
        if(val_52 == 1)
        {
            goto label_141;
        }
        
        if((-1421738448 + (((val_46 + 1) + 1)) << 2) == 661)
        {
            goto label_167;
        }
        
        if((-1421738448 + (((val_46 + 1) + 1)) << 2) != 499)
        {
            goto label_141;
        }
        
        var val_48 = 0;
        val_48 = val_48 ^ (val_52 >> 31);
        val_62 = val_52 + val_48;
        goto label_143;
        label_141:
        if( != 0)
        {
                val_43 = 0;
        }
        
        label_143:
        object[] val_35 = new object[3];
        val_51 = this;
        val_35[0] = mem[1152921541839826456].MatchId;
        val_35[1] = mem[1152921541839826464];
        val_35[2] = ;
        UnityEngine.AndroidJavaObject val_37 = mem[1152921541839826448] + 16.Call<UnityEngine.AndroidJavaObject>(methodName:  "finishMatch", args:  val_35);
        val_63 = mem[1152921541839826472];
        if(val_63 == 0)
        {
                val_63 = null;
            val_63 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0::<Finish>b__1(UnityEngine.AndroidJavaObject turnBasedMatch));
            mem[1152921541839826472] = val_63;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_37, callback:  null);
        val_55 = mem[1152921541839826480];
        if(val_55 == 0)
        {
                val_55 = null;
            val_55 = new System.Action<UnityEngine.AndroidJavaObject>(object:  this, method:  System.Void AndroidTurnBasedMultiplayerClient.<>c__DisplayClass20_0::<Finish>b__2(UnityEngine.AndroidJavaObject e));
            mem[1152921541839826480] = val_55;
        }
        
        GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_37, callback:  null);
        val_61 = val_52 + 1;
        mem2[0] = 661;
        if(val_37 != null)
        {
                var val_49 = 0;
            val_49 = val_49 + 1;
            val_37.Dispose();
        }
        
        if(val_61 == 1)
        {
            goto label_164;
        }
        
        if(val_43 == 0)
        {
            goto label_167;
        }
        
        if((-1421738448 + ((((val_46 + 1) + 1) + 1)) << 2) != 661)
        {
            goto label_166;
        }
        
        goto label_167;
        label_164:
        if(val_43 == 0)
        {
            goto label_168;
        }
        
        label_166:
        val_43 = 0;
        if( != 0)
        {
            goto label_171;
        }
        
        goto label_186;
        label_168:
        val_61 = 0;
        if( != 0)
        {
            goto label_171;
        }
        
        goto label_186;
        label_167:
        if( == 0)
        {
            goto label_186;
        }
        
        label_171:
        UnityEngine.AndroidJavaObject val_51 = val_2;
        var val_50 = 0;
        val_50 = val_50 + 1;
        val_2.Dispose();
        label_186:
        if(val_52 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((-1421738448 + (((val_46 + 1) + 1)) << 2) == 661)
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
    internal void <Finish>b__1(UnityEngine.AndroidJavaObject turnBasedMatch)
    {
        this.callback.Invoke(obj:  true);
    }
    internal void <Finish>b__2(UnityEngine.AndroidJavaObject e)
    {
        this.callback.Invoke(obj:  false);
    }

}
