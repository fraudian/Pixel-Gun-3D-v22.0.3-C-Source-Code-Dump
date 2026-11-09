using UnityEngine;
public sealed class Localize.丑丑丕丟业一上丐丂 : MulticastDelegate
{
    // Methods
    public Localize.丑丑丕丟业一上丐丂(object 三一丄丗专丌丛丘丅, IntPtr 丛丌丙世专世东丕下)
    {
        mem[1152921541595088752] = 三一丄丗专丌丛丘丅;
        mem[1152921541595088760] = 丛丌丙世专世东丕下;
        mem[1152921541595088736] = 丛丌丙世专世东丕下;
    }
    public virtual bool Invoke(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂)
    {
        Localize.丑丑丕丟业一上丐丂 val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_33;
        var val_34;
        var val_35;
        val_22 = this;
        if(X27 == 0)
        {
            goto label_0;
        }
        
        if((X27 + 24) == 0)
        {
            goto label_1;
        }
        
        val_23 = 0;
        var val_34 = 0;
        goto label_65;
        label_0:
        if((X24 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X24 + 74) != 4)
        {
            goto label_5;
        }
        
        if((X24 + 72) == 65535)
        {
            goto label_9;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
            goto label_9;
        }
        
        }
        
        if((X25 + 265) == 0)
        {
            goto label_9;
        }
        
        if(X25 == 0)
        {
                return (bool)val_23 & 1;
        }
        
        if(((X25 + 265) & 1) != 0)
        {
                return (bool)val_23 & 1;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X24.丘一一丆业丂丘丒世();
        if((X24 & 1) == 0)
        {
            goto label_12;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_13;
        }
        
        var val_42 = X25;
        if((X25 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_20 = X25 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_16:
        if(((X25 + 176 + 8) + -8) == (X24 + 24))
        {
            goto label_15;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X25 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_25 = mem[X24 + 72];
        val_25 = X24 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X24.丘一一丆业丂丘丒世();
        var val_22 = 0;
        val_22 = val_22 + 1;
        goto label_22;
        label_60:
        string val_3 = 1152921504624312320 + ((X24 + 72) << 4);
        val_27 = mem[(1152921504624312320 + (X24 + 72) << 4) + 304];
        goto label_23;
        label_18:
        val_28 = 丅下丂三上不丕丒丕;
        string val_4 = 1152921504624312320 + val_25;
        goto label_52;
        label_45:
        if((val_28 & 1) == 0)
        {
            goto label_25;
        }
        
        if((X24 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_23 = X24 + 72 + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_28:
        if(((X24 + 72 + 176 + 8) + -8) == X24.丘一一丆业丂丘丒世())
        {
            goto label_27;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (X24 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_25 = val_25;
        val_25 = val_25 + ((X24 + 72) << 4);
        val_30 = mem[(X24 + 72 + (X24 + 72) << 4) + 304];
        val_30 = (X24 + 72 + (X24 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_26 = val_25;
        val_28 = val_25;
        val_26 = val_26 + (X24 + 72);
        goto label_52;
        label_64:
        label_23:
        val_28 = 丅下丂三上不丕丒丕;
        goto label_52;
        label_22:
        var val_29 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丅下丂三上不丕丒丕, typeof(val_2), slot: 0);
        val_28 = 丅下丂三上不丕丒丕;
        goto label_52;
        label_48:
        var val_28 = 1179403647;
        val_28 = val_28 + 1152921541595294032;
        val_29 = val_29 + val_28;
        var val_8 = val_29 + 296;
        label_50:
        val_30 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丅下丂三上不丕丒丕, typeof(val_2), slot: 0) + (1179403647 + 丝丁且丑丒丅东丂丏)) + 296) + 8];
        val_30 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丅下丂三上不丕丒丕, typeof(val_2), slot: 0) + (1179403647 + 丝丁且丑丒丅东丂丏)) + 296) + 8;
        label_30:
        val_28 = val_25;
        goto label_52;
        label_27:
        var val_30 = val_23;
        val_30 = val_30 + (X24 + 72);
        val_30 = val_25 + val_30;
        val_29 = val_30 + 296;
        label_29:
        val_28 = val_25;
        goto label_52;
        label_65:
        var val_9 = X27 + 0;
        val_25 = mem[(X27 + 0) + 32 + 32];
        val_25 = (X27 + 0) + 32 + 32;
        val_22 = mem[(X27 + 0) + 32 + 16];
        val_22 = (X27 + 0) + 32 + 16;
        if((((X27 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_37;
        }
        
        if(((X27 + 0) + 32 + 32 + 8 + 74) != 4)
        {
            goto label_38;
        }
        
        if(((X27 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_42;
        }
        
        if(val_25 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(mem[1152921541595253864] == 0)
        {
            goto label_42;
        }
        
        if(val_25 == 0)
        {
            goto label_56;
        }
        
        if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        if((((X27 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_45;
        }
        
        if((((X27 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
        {
            goto label_46;
        }
        
        if(((X27 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_50;
        }
        
        var val_31 = (X27 + 0) + 32 + 32 + 176;
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_49:
        if((((X27 + 0) + 32 + 32 + 176 + 8) + -8) == ((X27 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < ((X27 + 0) + 32 + 32 + 286))
        {
            goto label_49;
        }
        
        goto label_50;
        label_37:
        if(((X27 + 0) + 32 + 32 + 8 + 74) == 4)
        {
            goto label_56;
        }
        
        label_42:
        val_28 = val_25;
        goto label_52;
        label_38:
        if(((X27 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_25 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(mem[1152921541595253864] == 0)
        {
            goto label_56;
        }
        
        if(val_25 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_58;
        }
        
        }
        
        if((((X27 + 0) + 32 + 32 + 8) & 1) == 0)
        {
            goto label_59;
        }
        
        if((((X27 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
        {
            goto label_60;
        }
        
        var val_33 = 0;
        val_33 = val_33 + 1;
        goto label_64;
        label_56:
        val_28 = 丅下丂三上不丕丒丕;
        label_52:
        val_23 = val_28 & 1;
        label_58:
        val_34 = val_34 + 1;
        if(val_34 != (X27 + 24))
        {
            goto label_65;
        }
        
        return (bool)val_23 & 1;
        label_1:
        val_23 = 0;
        return (bool)val_23 & 1;
        label_4:
        if((X24 + 74) == 4)
        {
                return (bool)val_23 & 1;
        }
        
        label_9:
        label_98:
        label_5:
        if((X24 + 72) == 65535)
        {
                return (bool)val_23 & 1;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
                return (bool)val_23 & 1;
        }
        
        }
        
        if((X25 + 265) == 0)
        {
                return (bool)val_23 & 1;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
                return (bool)val_23 & 1;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = X24.丘一一丆业丂丘丒世();
        if((X24 & 1) == 0)
        {
            goto label_74;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_75;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        goto label_79;
        label_74:
        if((val_13 & 1) == 0)
        {
            goto label_81;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = X24.丘一一丆业丂丘丒世();
        var val_36 = 0;
        val_36 = val_36 + 1;
        return (bool)val_23 & 1;
        label_75:
        string val_15 = 1152921504624312320 + ((X24 + 72) << 4);
        val_33 = mem[(1152921504624312320 + (X24 + 72) << 4) + 304];
        return (bool)val_23 & 1;
        label_81:
        string val_16 = 1152921504624312320 + (X24 + 72);
        return (bool)val_23 & 1;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_88;
        }
        
        if((X25 + 286) == 0)
        {
            goto label_98;
        }
        
        var val_37 = X25 + 176;
        var val_38 = 0;
        val_37 = val_37 + 8;
        label_91:
        if(((X25 + 176 + 8) + -8) == X24.丘一一丆业丂丘丒世())
        {
            goto label_90;
        }
        
        val_38 = val_38 + 1;
        val_37 = val_37 + 16;
        if(val_38 < (X25 + 286))
        {
            goto label_91;
        }
        
        goto label_98;
        label_13:
        var val_39 = X25;
        val_39 = val_39 + ((X24 + 72) << 4);
        val_35 = mem[(X25 + (X24 + 72) << 4) + 304];
        val_35 = (X25 + (X24 + 72) << 4) + 304;
        goto label_98;
        label_88:
        var val_40 = X25;
        val_40 = val_40 + (X24 + 72);
        goto label_98;
        label_79:
        val_33 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丅下丂三上不丕丒丕, typeof(X24 + 24), slot: 0) + 8];
        val_33 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(丅下丂三上不丕丒丕, typeof(X24 + 24), slot: 0) + 8;
        return (bool)val_23 & 1;
        label_15:
        var val_41 = val_20;
        val_41 = val_41 + (X24 + 72);
        val_42 = val_42 + val_41;
        val_24 = val_42 + 296;
        label_17:
        val_35 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0) + 8];
        val_35 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0) + 8;
        goto label_98;
        label_90:
        var val_43 = val_37;
        val_43 = val_43 + (X24 + 72);
        val_43 = X25 + val_43;
        val_34 = val_43 + 296;
        goto label_98;
    }
    public virtual System.IAsyncResult BeginInvoke(string 丅下丂三上不丕丒丕, string 一东丙丑丛丟上一丅, out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂, System.AsyncCallback 业丏丈世世世丞丒世, object 三一丄丗专丌丛丘丅)
    {
        return (System.IAsyncResult)this;
    }
    public virtual bool EndInvoke(out string 丝丁且丑丒丅东丂丏, out string 丞丌丕丑三丐七丐丂, System.IAsyncResult 东且丁丆丛丁丏丘且)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  东且丁丆丛丁丏丘且);
        return (bool)null;
    }

}
