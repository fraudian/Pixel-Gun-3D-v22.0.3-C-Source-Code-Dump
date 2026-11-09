using UnityEngine;
private sealed class AndroidRealTimeMultiplayerClient.<>c__DisplayClass32_0
{
    // Fields
    public string invitationId;
    public System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback;
    public System.Action<bool> fail;
    
    // Methods
    public AndroidRealTimeMultiplayerClient.<>c__DisplayClass32_0()
    {
    
    }
    internal void <FindInvitation>b__0(UnityEngine.AndroidJavaObject annotatedData)
    {
        var val_13;
        object val_14;
        int val_15;
        var val_18;
        GooglePlayGames.BasicApi.Multiplayer.Invitation val_19;
        var val_21;
        var val_22;
        UnityEngine.AndroidJavaObject val_2 = annotatedData.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  System.Array.Empty<System.Object>());
        int val_4 = val_2.Call<System.Int32>(methodName:  "getCount", args:  System.Array.Empty<System.Object>());
        if(val_4 <= 0)
        {
            goto label_3;
        }
        
        val_14 = 0;
        val_15 = 0;
        goto label_5;
        label_26:
        val_14 = 1;
        if(val_14 < val_4)
        {
            goto label_5;
        }
        
        goto label_34;
        label_5:
        object[] val_5 = new object[1];
        val_5[0] = val_14;
        UnityEngine.AndroidJavaObject val_6 = val_2.Call<UnityEngine.AndroidJavaObject>(methodName:  "get", args:  val_5);
        val_18 = 0 + 1;
        mem2[0] = 88;
        val_19 = GooglePlayGames.Android.AndroidJavaConverter.ToInvitation(invitation:  val_6);
        if(val_6 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            val_6.Dispose();
        }
        
        if((val_18 == 1) || ((1152921541809579648 + ((0 + 1)) << 2) != 88))
        {
            goto label_21;
        }
        
        var val_15 = 0;
        val_15 = val_15 ^ (val_18 >> 31);
        val_18 = val_18 + val_15;
        if(val_19 != null)
        {
            goto label_25;
        }
        
        goto label_23;
        label_21:
        if(val_15 != 0)
        {
                val_15 = 0;
        }
        
        if(val_19 != null)
        {
            goto label_25;
        }
        
        label_23:
        label_25:
        if((System.String.op_Equality(a:  val_19.InvitationId, b:  mem[this.invitationId])) == false)
        {
            goto label_26;
        }
        
        mem[1152921541809591816].Invoke(obj:  val_19);
        val_21 = 0;
        goto label_28;
        label_3:
        val_21 = 0;
        val_15 = 0;
        val_18 = 0;
        label_34:
        val_19 = "Invitation with ID " + mem[this.invitationId] + " couldn\'t be found";
        GooglePlayGames.OurUtils.Logger.e(msg:  val_19);
        mem[1152921541809591824].Invoke(obj:  true);
        label_28:
        val_22 = val_18 + 1;
        mem2[0] = 179;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_2.Dispose();
        }
        
        if(0 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(val_13 == 179)
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
    internal void <FindInvitation>b__1(UnityEngine.AndroidJavaObject exception)
    {
        GooglePlayGames.OurUtils.Logger.e(msg:  "Couldn\'t load invitations.");
        this.fail.Invoke(obj:  true);
    }

}
