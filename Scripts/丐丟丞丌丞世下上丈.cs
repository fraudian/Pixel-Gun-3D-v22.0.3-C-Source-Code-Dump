using UnityEngine;
public sealed class UIWidget.丐丟丞丌丞世下上丈 : MulticastDelegate
{
    // Methods
    public UIWidget.丐丟丞丌丞世下上丈(object 三一丄丗专丌丛丘丅, IntPtr 丛丌丙世专世东丕下)
    {
        mem[1152921535257037152] = 三一丄丗专丌丛丘丅;
        mem[1152921535257037160] = 丛丌丙世专世东丕下;
        mem[1152921535257037136] = 丛丌丙世专世东丕下;
    }
    public virtual void Invoke(UIWidget 世丌丌丙丞丟下东丞, int 丈丄丗丆丞一与七丆, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        UIWidget.丐丟丞丌丞世下上丈 val_23;
        var val_24;
        var val_25;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_33;
        var val_34;
        var val_35;
        val_23 = this;
        if(X28 == 0)
        {
            goto label_0;
        }
        
        if((X28 + 24) == 0)
        {
                return;
        }
        
        goto label_65;
        label_0:
        if((X25 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X25 + 74) != 5)
        {
            goto label_5;
        }
        
        if((X25 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X26 != 0)
        {
                if(((X26 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X26 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X26 == 0)
        {
            goto label_70;
        }
        
        if(((X26 + 265) & 1) != 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X25.丘一一丆业丂丘丒世();
        if((X25 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_41 = X26;
        if((X26 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_20 = X26 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_16:
        if(((X26 + 176 + 8) + -8) == (X25 + 24))
        {
            goto label_15;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X26 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X25 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X25.丘一一丆业丂丘丒世();
        var val_22 = 0;
        val_22 = val_22 + 1;
        goto label_22;
        label_60:
        UIWidget val_3 = 1152921505094811648 + ((X25 + 72) << 4);
        val_27 = mem[(1152921505094811648 + (X25 + 72) << 4) + 304];
        goto label_58;
        label_18:
        UIWidget val_4 = 1152921505094811648 + (X25 + 72);
        goto label_58;
        label_45:
        val_28 = mem[X25 + 72];
        val_28 = X25 + 72;
        if((世丌丌丙丞丟下东丞.Equals(other:  丈丄丗丆丞一与七丆)) == false)
        {
            goto label_25;
        }
        
        if((X25 + 72 + 286) == 0)
        {
            goto label_58;
        }
        
        var val_23 = X25 + 72 + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_28:
        if(((X25 + 72 + 176 + 8) + -8) == X25.丘一一丆业丂丘丒世())
        {
            goto label_27;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (X25 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_58;
        label_46:
        var val_25 = X25 + 72;
        val_25 = val_25 + ((X25 + 72) << 4);
        val_30 = mem[(X25 + 72 + (X25 + 72) << 4) + 304];
        val_30 = (X25 + 72 + (X25 + 72) << 4) + 304;
        goto label_58;
        label_25:
        var val_26 = X25 + 72;
        val_26 = val_26 + val_28;
        goto label_58;
        label_64:
        val_27 = mem[(((X25 + 72 + X25 + 72) + (((X26 + 176 + 8) + 16) + 丈丄丗丆丞一与七丆)) + 296) + 8];
        val_27 = (((X25 + 72 + X25 + 72) + (((X26 + 176 + 8) + 16) + 丈丄丗丆丞一与七丆)) + 296) + 8;
        goto label_58;
        label_22:
        var val_29 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(世丌丌丙丞丟下东丞, typeof(val_2), slot: 0);
        goto label_58;
        label_48:
        var val_28 = 1179403647;
        val_28 = val_28 + 丗丞不丞业丑七且丗;
        val_29 = val_29 + val_28;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_9 = val_29 + 296;
        goto label_58;
        label_27:
        var val_30 = val_23;
        val_30 = val_30 + val_28;
        val_30 = (X25 + 72) + val_30;
        val_29 = val_30 + 296;
        goto label_58;
        label_65:
        var val_10 = X28 + 0;
        val_24 = mem[(X28 + 0) + 32 + 32 + 8];
        val_24 = (X28 + 0) + 32 + 32 + 8;
        val_28 = mem[(X28 + 0) + 32 + 16];
        val_28 = (X28 + 0) + 32 + 16;
        if((val_24 & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X28 + 0) + 32 + 32 + 8 + 74) != 5)
        {
            goto label_38;
        }
        
        if(((X28 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_58;
        }
        
        if(((X28 + 0) + 32 + 32) != 0)
        {
                if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if(mem[1152921535257202392] == 0)
        {
            goto label_58;
        }
        
        if(((X28 + 0) + 32 + 32) == 0)
        {
            goto label_56;
        }
        
        if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((val_24 & 1) == 0)
        {
            goto label_45;
        }
        
        if((val_24.丘一一丆业丂丘丒世() & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X28 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_58;
        }
        
        var val_31 = (X28 + 0) + 32 + 32 + 176;
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_49:
        if((((X28 + 0) + 32 + 32 + 176 + 8) + -8) == ((X28 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < ((X28 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_58;
        label_37:
        if(((X28 + 0) + 32 + 32 + 8 + 74) == 5)
        {
            goto label_56;
        }
        
        goto label_58;
        label_38:
        if(((X28 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(((X28 + 0) + 32 + 32) != 0)
        {
                if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(mem[1152921535257202392] == 0)
        {
            goto label_56;
        }
        
        if(((X28 + 0) + 32 + 32) != 0)
        {
                if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((val_24 & 1) == 0)
        {
            goto label_59;
        }
        
        if((val_24.丘一一丆业丂丘丒世() & 1) == 0)
        {
            goto label_60;
        }
        
        var val_33 = 0;
        val_33 = val_33 + 1;
        goto label_64;
        label_56:
        label_58:
        val_23 = 0 + 1;
        if(val_23 != (X28 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X25 + 74) == 5)
        {
            goto label_70;
        }
        
        label_9:
        label_96:
        label_5:
        if((X25 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X26 != 0)
        {
                if(((X26 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X26 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X26 != 0)
        {
                if(((X26 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = X25.丘一一丆业丂丘丒世();
        if((X25 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        goto label_78;
        label_70:
        label_94:
        label_73:
        if((val_13 & 1) == 0)
        {
            goto label_79;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = X25.丘一一丆业丂丘丒世();
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_94;
        label_74:
        UIWidget val_15 = 1152921505094811648 + ((X25 + 72) << 4);
        val_33 = mem[(1152921505094811648 + (X25 + 72) << 4) + 304];
        goto label_94;
        label_79:
        UIWidget val_16 = 1152921505094811648 + (X25 + 72);
        goto label_94;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X26 + 286) == 0)
        {
            goto label_96;
        }
        
        var val_36 = X26 + 176;
        var val_37 = 0;
        val_36 = val_36 + 8;
        label_89:
        if(((X26 + 176 + 8) + -8) == X25.丘一一丆业丂丘丒世())
        {
            goto label_88;
        }
        
        val_37 = val_37 + 1;
        val_36 = val_36 + 16;
        if(val_37 < (X26 + 286))
        {
            goto label_89;
        }
        
        goto label_96;
        label_13:
        var val_38 = X26;
        val_38 = val_38 + ((X25 + 72) << 4);
        val_35 = mem[(X26 + (X25 + 72) << 4) + 304];
        val_35 = (X26 + (X25 + 72) << 4) + 304;
        goto label_96;
        label_86:
        var val_39 = X26;
        val_39 = val_39 + (X25 + 72);
        goto label_96;
        label_78:
        val_33 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(世丌丌丙丞丟下东丞, typeof(X25 + 24), slot: 0) + 8];
        val_33 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(世丌丌丙丞丟下东丞, typeof(X25 + 24), slot: 0) + 8;
        goto label_94;
        label_15:
        var val_40 = val_20;
        val_40 = val_40 + (X25 + 72);
        val_41 = val_41 + val_40;
        val_25 = val_41 + 296;
        label_17:
        val_35 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X25 + 24), slot: 0) + 8];
        val_35 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X25 + 24), slot: 0) + 8;
        goto label_96;
        label_88:
        var val_42 = val_36;
        val_42 = val_42 + (X25 + 72);
        val_42 = X26 + val_42;
        val_34 = val_42 + 296;
        goto label_96;
    }
    public virtual System.IAsyncResult BeginInvoke(UIWidget 世丌丌丙丞丟下东丞, int 丈丄丗丆丞一与七丆, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘, System.AsyncCallback 业丏丈世世世丞丒世, object 三一丄丗专丌丛丘丅)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult 东且丁丆丛丁丏丘且)
    {
    
    }

}
