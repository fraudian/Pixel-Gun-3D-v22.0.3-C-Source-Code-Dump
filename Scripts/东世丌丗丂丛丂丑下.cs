using UnityEngine;
public sealed class BulletForBot.东世丌丗丂丛丂丑下 : MulticastDelegate
{
    // Methods
    public BulletForBot.东世丌丗丂丛丂丑下(object 三一丄丗专丌丛丘丅, IntPtr 丛丌丙世专世东丕下)
    {
        mem[1152921536447330992] = 三一丄丗专丌丛丘丅;
        mem[1152921536447331000] = 丛丌丙世专世东丕下;
        mem[1152921536447330976] = 丛丌丙世专世东丕下;
    }
    public virtual void Invoke(UnityEngine.GameObject 丏三丐丈丆与上丙丏, UnityEngine.Vector3 世丘丂丁七丐丐一专, bool 丂丘且丝丙上业世丙)
    {
        var val_33;
        var val_34;
        var val_36;
        var val_37;
        var val_38;
        var val_41;
        var val_42;
        var val_43;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
                return;
        }
        
        var val_44 = 0;
        goto label_65;
        label_0:
        if((X22 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X22 + 74) != 3)
        {
            goto label_5;
        }
        
        if((X22 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X23 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X23 == 0)
        {
            goto label_70;
        }
        
        if(((X23 + 265) & 1) != 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X22.丘一一丆业丂丘丒世();
        if((X22 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_52 = X23;
        if((X23 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_30 = X23 + 176;
        var val_31 = 0;
        val_30 = val_30 + 8;
        label_16:
        if(((X23 + 176 + 8) + -8) == (X22 + 24))
        {
            goto label_15;
        }
        
        val_31 = val_31 + 1;
        val_30 = val_30 + 16;
        if(val_31 < (X23 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_33 = mem[X22 + 72];
        val_33 = X22 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X22.丘一一丆业丂丘丒世();
        var val_32 = 0;
        val_32 = val_32 + 1;
        goto label_22;
        label_60:
        UnityEngine.GameObject val_3 = 1152921504834002944 + ((X22 + 72) << 4);
        val_36 = mem[(1152921504834002944 + (X22 + 72) << 4) + 304];
        goto label_23;
        label_18:
        bool val_4 = 丂丘且丝丙上业世丙;
        UnityEngine.GameObject val_5 = 1152921504834002944 + val_33;
        goto label_58;
        label_45:
        if((丏三丐丈丆与上丙丏 & 1) == 0)
        {
            goto label_25;
        }
        
        if((X22 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_33 = X22 + 72 + 176;
        var val_34 = 0;
        val_33 = val_33 + 8;
        label_28:
        if(((X22 + 72 + 176 + 8) + -8) == X22.丘一一丆业丂丘丒世())
        {
            goto label_27;
        }
        
        val_34 = val_34 + 1;
        val_33 = val_33 + 16;
        if(val_34 < (X22 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_35 = val_33;
        val_35 = val_35 + ((X22 + 72) << 4);
        val_38 = mem[(X22 + 72 + (X22 + 72) << 4) + 304];
        val_38 = (X22 + 72 + (X22 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_36 = val_33;
        bool val_7 = 丂丘且丝丙上业世丙;
        val_36 = val_36 + (X22 + 72);
        goto label_58;
        label_64:
        val_36 = mem[(((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (丂丘且丝丙上业世丙 & 1))) + 296) + 8];
        val_36 = (((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (丂丘且丝丙上业世丙 & 1))) + 296) + 8;
        label_23:
        bool val_9 = 丂丘且丝丙上业世丙;
        goto label_58;
        label_22:
        var val_39 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(val_2), slot: 0);
        bool val_11 = 丂丘且丝丙上业世丙;
        goto label_58;
        label_48:
        var val_38 = 1179403647;
        val_38 = val_38 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(val_2), slot: 0) + 8);
        val_39 = val_39 + val_38;
        var val_12 = val_39 + 296;
        label_50:
        val_38 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(val_2), slot: 0) + 8))  + 8];
        val_38 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(val_2), slot: 0) + 8))  + 8;
        label_30:
        bool val_13 = 丂丘且丝丙上业世丙;
        goto label_58;
        label_27:
        var val_40 = val_33;
        val_40 = val_40 + (X22 + 72);
        val_40 = val_33 + val_40;
        val_37 = val_40 + 296;
        label_29:
        bool val_14 = 丂丘且丝丙上业世丙;
        goto label_58;
        label_65:
        var val_15 = X25 + 0;
        val_33 = mem[(X25 + 0) + 32 + 32];
        val_33 = (X25 + 0) + 32 + 32;
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 3)
        {
            goto label_38;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(val_33 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_42;
        }
        
        if(val_33 == 0)
        {
            goto label_56;
        }
        
        if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_45;
        }
        
        if((((X25 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_41 = (X25 + 0) + 32 + 32 + 176;
        var val_42 = 0;
        val_41 = val_41 + 8;
        label_49:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_42 = val_42 + 1;
        val_41 = val_41 + 16;
        if(val_42 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X25 + 0) + 32 + 32 + 8 + 74) == 3)
        {
            goto label_56;
        }
        
        label_42:
        丂丘且丝丙上业世丙 = 丂丘且丝丙上业世丙;
        goto label_58;
        label_38:
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_33 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_56;
        }
        
        if(val_33 != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_59;
        }
        
        if((((X25 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
        {
            goto label_60;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        goto label_64;
        label_56:
        bool val_18 = 丂丘且丝丙上业世丙;
        label_58:
        val_44 = val_44 + 1;
        if(val_44 != (X25 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X22 + 74) == 3)
        {
            goto label_70;
        }
        
        label_9:
        丂丘且丝丙上业世丙 = 丂丘且丝丙上业世丙;
        label_96:
        label_5:
        if((X22 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X23 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X23 != 0)
        {
                if(((X23 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_19 = X22.丘一一丆业丂丘丒世();
        if((X22 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_19 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        goto label_78;
        label_70:
        bool val_20 = 丂丘且丝丙上业世丙;
        label_94:
        label_73:
        if((val_19 & 1) == 0)
        {
            goto label_79;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_21 = X22.丘一一丆业丂丘丒世();
        var val_46 = 0;
        val_46 = val_46 + 1;
        goto label_83;
        label_74:
        UnityEngine.GameObject val_22 = 1152921504834002944 + ((X22 + 72) << 4);
        val_41 = mem[(1152921504834002944 + (X22 + 72) << 4) + 304];
        goto label_84;
        label_79:
        UnityEngine.GameObject val_23 = 1152921504834002944 + (X22 + 72);
        goto label_85;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X23 + 286) == 0)
        {
            goto label_90;
        }
        
        var val_47 = X23 + 176;
        var val_48 = 0;
        val_47 = val_47 + 8;
        label_89:
        if(((X23 + 176 + 8) + -8) == X22.丘一一丆业丂丘丒世())
        {
            goto label_88;
        }
        
        val_48 = val_48 + 1;
        val_47 = val_47 + 16;
        if(val_48 < (X23 + 286))
        {
            goto label_89;
        }
        
        goto label_90;
        label_13:
        var val_49 = X23;
        val_49 = val_49 + ((X22 + 72) << 4);
        val_43 = mem[(X23 + (X22 + 72) << 4) + 304];
        val_43 = (X23 + (X22 + 72) << 4) + 304;
        goto label_91;
        label_86:
        var val_50 = X23;
        val_50 = val_50 + (X22 + 72);
        goto label_92;
        label_78:
        val_41 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(X22 + 24), slot: 0) + 8];
        val_41 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丏三丐丈丆与上丙丏, typeof(X22 + 24), slot: 0) + 8;
        label_84:
        bool val_26 = 丂丘且丝丙上业世丙;
        goto label_94;
        label_83:
        label_85:
        bool val_28 = 丂丘且丝丙上业世丙;
        goto label_94;
        label_15:
        var val_51 = val_30;
        val_51 = val_51 + (X22 + 72);
        val_52 = val_52 + val_51;
        val_34 = val_52 + 296;
        label_17:
        val_43 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8];
        val_43 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8;
        label_91:
        bool val_29 = 丂丘且丝丙上业世丙;
        goto label_96;
        label_88:
        var val_53 = val_47;
        val_53 = val_53 + (X22 + 72);
        val_53 = X23 + val_53;
        val_42 = val_53 + 296;
        label_90:
        label_92:
        丂丘且丝丙上业世丙 = 丂丘且丝丙上业世丙;
        goto label_96;
    }
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.GameObject 丏三丐丈丆与上丙丏, UnityEngine.Vector3 世丘丂丁七丐丐一专, bool 丂丘且丝丙上业世丙, System.AsyncCallback 业丏丈世世世丞丒世, object 三一丄丗专丌丛丘丅)
    {
        bool val_1 = 丂丘且丝丙上业世丙;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult 东且丁丆丛丁丏丘且)
    {
    
    }

}
