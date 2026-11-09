using UnityEngine;
internal sealed class 丐丆丏丌丅丛与丆丟.下丙丒丂一丒一丒丒 : MulticastDelegate
{
    // Methods
    public 丐丆丏丌丅丛与丆丟.下丙丒丂一丒一丒丒(object 三一丄丗专丌丛丘丅, IntPtr 丛丌丙世专世东丕下)
    {
        mem[1152921559891804160] = 三一丄丗专丌丛丘丅;
        mem[1152921559891804168] = 丛丌丙世专世东丕下;
        mem[1152921559891804144] = 丛丌丙世专世东丕下;
    }
    public virtual void Invoke(Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 东一丁世丑丞业丄丐, bool 丐万丗丒下七丟丁三, bool 业丁丁丕丆丛丕专且, int 丟丝三不世与专且三)
    {
        丐丆丏丌丅丛与丆丟.下丙丒丂一丒一丒丒 val_43;
        var val_44;
        var val_45;
        var val_47;
        var val_48;
        var val_49;
        var val_52;
        var val_53;
        var val_54;
        val_43 = this;
        if(X27 == 0)
        {
            goto label_0;
        }
        
        if((X27 + 24) == 0)
        {
                return;
        }
        
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
            goto label_70;
        }
        
        if(((X25 + 265) & 1) != 0)
        {
                return;
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
        
        var val_61 = X25;
        if((X25 + 286) == 0)
        {
            goto label_17;
        }
        
        var val_40 = X25 + 176;
        var val_41 = 0;
        val_40 = val_40 + 8;
        label_16:
        if(((X25 + 176 + 8) + -8) == (X24 + 24))
        {
            goto label_15;
        }
        
        val_41 = val_41 + 1;
        val_40 = val_40 + 16;
        if(val_41 < (X25 + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_59:
        val_44 = mem[X24 + 72];
        val_44 = X24 + 72;
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0)) & 1) == 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X24.丘一一丆业丂丘丒世();
        var val_42 = 0;
        val_42 = val_42 + 1;
        goto label_22;
        label_60:
        丒丌丝丆东上下下专 val_3 = 1152921505362595840 + ((X24 + 72) << 4);
        val_47 = mem[(1152921505362595840 + (X24 + 72) << 4) + 304];
        goto label_23;
        label_18:
        bool val_4 = 丐万丗丒下七丟丁三;
        bool val_5 = 业丁丁丕丆丛丕专且;
        丒丌丝丆东上下下专 val_6 = 1152921505362595840 + val_44;
        goto label_58;
        label_45:
        if((东一丁世丑丞业丄丐 & 1) == 0)
        {
            goto label_25;
        }
        
        if((X24 + 72 + 286) == 0)
        {
            goto label_29;
        }
        
        var val_43 = X24 + 72 + 176;
        var val_44 = 0;
        val_43 = val_43 + 8;
        label_28:
        if(((X24 + 72 + 176 + 8) + -8) == X24.丘一一丆业丂丘丒世())
        {
            goto label_27;
        }
        
        val_44 = val_44 + 1;
        val_43 = val_43 + 16;
        if(val_44 < (X24 + 72 + 286))
        {
            goto label_28;
        }
        
        goto label_29;
        label_46:
        var val_45 = val_44;
        val_45 = val_45 + ((X24 + 72) << 4);
        val_49 = mem[(X24 + 72 + (X24 + 72) << 4) + 304];
        val_49 = (X24 + 72 + (X24 + 72) << 4) + 304;
        goto label_30;
        label_25:
        var val_46 = val_44;
        bool val_8 = 丐万丗丒下七丟丁三;
        bool val_9 = 业丁丁丕丆丛丕专且;
        val_46 = val_46 + (X24 + 72);
        goto label_58;
        label_64:
        val_47 = mem[(((X24 + 72 + X24 + 72) + (((X25 + 176 + 8) + 16) + (丐万丗丒下七丟丁三 & 1))) + 296) + 8];
        val_47 = (((X24 + 72 + X24 + 72) + (((X25 + 176 + 8) + 16) + (丐万丗丒下七丟丁三 & 1))) + 296) + 8;
        label_23:
        bool val_11 = 丐万丗丒下七丟丁三;
        bool val_12 = 业丁丁丕丆丛丕专且;
        goto label_58;
        label_22:
        var val_49 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(东一丁世丑丞业丄丐, typeof(val_2), slot: 0);
        bool val_14 = 丐万丗丒下七丟丁三;
        goto label_58;
        label_48:
        var val_48 = 1179403647;
        val_48 = val_48 + 业丁丁丕丆丛丕专且;
        val_49 = val_49 + val_48;
        bool val_16 = val_49 + 296;
        label_50:
        val_49 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(东一丁世丑丞业丄丐, typeof(val_2), slot: 0) + (1179403647 + (业丁丁丕丆丛丕专且 & 1))) + 296) + 8];
        val_49 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(东一丁世丑丞业丄丐, typeof(val_2), slot: 0) + (1179403647 + (业丁丁丕丆丛丕专且 & 1))) + 296) + 8;
        label_30:
        bool val_17 = 丐万丗丒下七丟丁三;
        bool val_18 = 业丁丁丕丆丛丕专且;
        goto label_58;
        label_27:
        var val_50 = val_43;
        val_50 = val_50 + (X24 + 72);
        val_50 = val_44 + val_50;
        val_48 = val_50 + 296;
        label_29:
        bool val_19 = 丐万丗丒下七丟丁三;
        bool val_20 = 业丁丁丕丆丛丕专且;
        goto label_58;
        label_65:
        var val_21 = X27 + 0;
        val_44 = mem[(X27 + 0) + 32 + 32];
        val_44 = (X27 + 0) + 32 + 32;
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
        
        if(val_44 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_42;
        }
        
        }
        
        if(mem[1152921559891957112] == 0)
        {
            goto label_42;
        }
        
        if(val_44 == 0)
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
        
        var val_51 = (X27 + 0) + 32 + 32 + 176;
        var val_52 = 0;
        val_51 = val_51 + 8;
        label_49:
        if((((X27 + 0) + 32 + 32 + 176 + 8) + -8) == ((X27 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_48;
        }
        
        val_52 = val_52 + 1;
        val_51 = val_51 + 16;
        if(val_52 < ((X27 + 0) + 32 + 32 + 286))
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
        丐万丗丒下七丟丁三 = 丐万丗丒下七丟丁三;
        业丁丁丕丆丛丕专且 = 业丁丁丕丆丛丕专且;
        goto label_58;
        label_38:
        if(((X27 + 0) + 32 + 32 + 8 + 72) == 65535)
        {
            goto label_56;
        }
        
        if(val_44 != 0)
        {
                if((((X27 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_56;
        }
        
        }
        
        if(mem[1152921559891957112] == 0)
        {
            goto label_56;
        }
        
        if(val_44 != 0)
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
        
        var val_53 = 0;
        val_53 = val_53 + 1;
        goto label_64;
        label_56:
        bool val_24 = 丐万丗丒下七丟丁三;
        bool val_25 = 业丁丁丕丆丛丕专且;
        label_58:
        val_43 = 0 + 1;
        if(val_43 != (X27 + 24))
        {
            goto label_65;
        }
        
        return;
        label_4:
        if((X24 + 74) == 4)
        {
            goto label_70;
        }
        
        label_9:
        丐万丗丒下七丟丁三 = 丐万丗丒下七丟丁三;
        业丁丁丕丆丛丕专且 = 业丁丁丕丆丛丕专且;
        label_96:
        label_5:
        if((X24 + 72) == 65535)
        {
            goto label_70;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
            goto label_70;
        }
        
        }
        
        if((X25 + 265) == 0)
        {
            goto label_70;
        }
        
        if(X25 != 0)
        {
                if(((X25 + 265) & 1) != 0)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_26 = X24.丘一一丆业丂丘丒世();
        if((X24 & 1) == 0)
        {
            goto label_73;
        }
        
        if((val_26 & 1) == 0)
        {
            goto label_74;
        }
        
        var val_54 = 0;
        val_54 = val_54 + 1;
        goto label_78;
        label_70:
        bool val_27 = 丐万丗丒下七丟丁三;
        bool val_28 = 业丁丁丕丆丛丕专且;
        label_94:
        label_73:
        if((val_26 & 1) == 0)
        {
            goto label_79;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_29 = X24.丘一一丆业丂丘丒世();
        var val_55 = 0;
        val_55 = val_55 + 1;
        goto label_83;
        label_74:
        丒丌丝丆东上下下专 val_30 = 1152921505362595840 + ((X24 + 72) << 4);
        val_52 = mem[(1152921505362595840 + (X24 + 72) << 4) + 304];
        goto label_84;
        label_79:
        丒丌丝丆东上下下专 val_31 = 1152921505362595840 + (X24 + 72);
        goto label_85;
        label_12:
        if((val_1 & 1) == 0)
        {
            goto label_86;
        }
        
        if((X25 + 286) == 0)
        {
            goto label_90;
        }
        
        var val_56 = X25 + 176;
        var val_57 = 0;
        val_56 = val_56 + 8;
        label_89:
        if(((X25 + 176 + 8) + -8) == X24.丘一一丆业丂丘丒世())
        {
            goto label_88;
        }
        
        val_57 = val_57 + 1;
        val_56 = val_56 + 16;
        if(val_57 < (X25 + 286))
        {
            goto label_89;
        }
        
        goto label_90;
        label_13:
        var val_58 = X25;
        val_58 = val_58 + ((X24 + 72) << 4);
        val_54 = mem[(X25 + (X24 + 72) << 4) + 304];
        val_54 = (X25 + (X24 + 72) << 4) + 304;
        goto label_91;
        label_86:
        var val_59 = X25;
        val_59 = val_59 + (X24 + 72);
        goto label_92;
        label_78:
        val_52 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(东一丁世丑丞业丄丐, typeof(X24 + 24), slot: 0) + 8];
        val_52 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(东一丁世丑丞业丄丐, typeof(X24 + 24), slot: 0) + 8;
        label_84:
        bool val_34 = 丐万丗丒下七丟丁三;
        bool val_35 = 业丁丁丕丆丛丕专且;
        goto label_94;
        label_83:
        label_85:
        bool val_37 = 丐万丗丒下七丟丁三;
        bool val_38 = 业丁丁丕丆丛丕专且;
        goto label_94;
        label_15:
        var val_60 = val_40;
        val_60 = val_60 + (X24 + 72);
        val_61 = val_61 + val_60;
        val_45 = val_61 + 296;
        label_17:
        val_54 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0) + 8];
        val_54 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X25, typeof(X24 + 24), slot: 0) + 8;
        label_91:
        bool val_39 = 丐万丗丒下七丟丁三;
        业丁丁丕丆丛丕专且 = 业丁丁丕丆丛丕专且;
        goto label_96;
        label_88:
        var val_62 = val_56;
        val_62 = val_62 + (X24 + 72);
        val_62 = X25 + val_62;
        val_53 = val_62 + 296;
        label_90:
        label_92:
        丐万丗丒下七丟丁三 = 丐万丗丒下七丟丁三;
        业丁丁丕丆丛丕专且 = 业丁丁丕丆丛丕专且;
        goto label_96;
    }
    public virtual System.IAsyncResult BeginInvoke(Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 东一丁世丑丞业丄丐, bool 丐万丗丒下七丟丁三, bool 业丁丁丕丆丛丕专且, int 丟丝三不世与专且三, System.AsyncCallback 业丏丈世世世丞丒世, object 三一丄丗专丌丛丘丅)
    {
        bool val_1 = 丐万丗丒下七丟丁三;
        bool val_2 = 业丁丁丕丆丛丕专且;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult 东且丁丆丛丁丏丘且)
    {
    
    }

}
