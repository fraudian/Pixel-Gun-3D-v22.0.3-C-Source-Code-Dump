using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass28_0
{
    // Fields
    public string invitationId;
    public System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass28_0()
    {
    
    }
    internal void <FindInvitationWithId>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_20;
        UnityEngine.AndroidJavaObject val_2 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        UnityEngine.AndroidJavaObject val_4 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "getInvitations", args:  System.Array.Empty<System.Object>());
        int val_6 = val_4.Call<System.Int32>(methodName:  "getCount", args:  System.Array.Empty<System.Object>());
        if(val_6 < 1)
        {
            goto label_4;
        }
        
        object val_14 = 0;
        label_12:
        object[] val_7 = new object[1];
        val_7[0] = val_14;
        GooglePlayGames.BasicApi.Multiplayer.Invitation val_9 = GooglePlayGames.Android.AndroidJavaConverter.ToInvitation(invitation:  val_4.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_7));
        if((System.String.op_Equality(a:  val_9.InvitationId, b:  mem[1152921541844224160])) == true)
        {
            goto label_11;
        }
        
        val_14 = val_14 + 1;
        if(val_14 < val_6)
        {
            goto label_12;
        }
        
        label_4:
        val_14 = 0;
        val_15 = 0;
        label_16:
        val_16 = -1417340640;
        if(val_4 != null)
        {
            goto label_13;
        }
        
        goto label_28;
        label_11:
        mem[1152921541844224168].Invoke(obj:  val_9);
        goto label_16;
        label_56:
        val_17 = val_9;
        val_18 = mem[1152921541844224168];
        goto label_27;
        label_13:
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_32;
        label_27:
        val_14 = 0;
        if(val_17 != 1)
        {
            goto label_56;
        }
        
        val_15 = mem[mem[1152921541844224168]];
        val_15 = val_18;
        goto label_43;
        label_32:
        val_4.Dispose();
        label_28:
        if( == 1)
        {
            goto label_35;
        }
        
        if( != 165)
        {
            goto label_36;
        }
        
        label_43:
        val_20 = ;
        if(val_2 != null)
        {
            goto label_40;
        }
        
        goto label_44;
        label_35:
        if( != 0)
        {
            goto label_39;
        }
        
        val_20 = 0;
        val_14 = 0;
        if(val_2 != null)
        {
            goto label_40;
        }
        
        goto label_44;
        label_36:
        if(( == 0) || ( == 153))
        {
            goto label_43;
        }
        
        label_39:
        val_15 = 0;
        val_20 = 0;
        if(val_2 == null)
        {
            goto label_44;
        }
        
        label_40:
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_2.Dispose();
        label_44:
        if( == 1)
        {
            goto label_49;
        }
        
        if( == 165)
        {
                return;
        }
        
        if(val_20 == 0)
        {
            goto label_54;
        }
        
        if( != 153)
        {
            goto label_52;
        }
        
        goto label_54;
        label_49:
        if(val_20 == 0)
        {
            goto label_54;
        }
        
        label_52:
        label_54:
        val_20 = mem[1152921541844224168];
        val_20.Invoke(obj:  0);
    }
    internal void <FindInvitationWithId>b__1(UnityEngine.AndroidJavaObject e)
    {
        this.callback.Invoke(obj:  0);
    }

}
