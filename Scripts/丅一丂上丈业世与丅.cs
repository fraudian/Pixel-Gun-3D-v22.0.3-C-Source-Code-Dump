using UnityEngine;
internal sealed class 丌丟丄专丂丒丁丛三.丅一丂上丈业世与丅 : MulticastDelegate
{
    // Methods
    public 丌丟丄专丂丒丁丛三.丅一丂上丈业世与丅(object 三一丄丗专丌丛丘丅, IntPtr 丛丌丙世专世东丕下)
    {
        mem[1152921537323381472] = 三一丄丗专丌丛丘丅;
        mem[1152921537323381480] = 丛丌丙世专世东丕下;
        mem[1152921537323381456] = 丛丌丙世专世东丕下;
    }
    public virtual void Invoke(bool 东丏丂丙丑丁丞丞万, bool 业下丁且专丞一丕七)
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        if(X25 == 0)
        {
            goto label_0;
        }
        
        if((X25 + 24) == 0)
        {
                return;
        }
        
        var val_29 = 0;
        goto label_42;
        label_0:
        if((X23 & 1) == 0)
        {
            goto label_4;
        }
        
        if((X23 + 72) == 1)
        {
            goto label_43;
        }
        
        if(X22 != 0)
        {
                if(((X22 + 265) & 1) != 0)
        {
            goto label_43;
        }
        
        }
        
        if((X22 + 265) == 0)
        {
            goto label_43;
        }
        
        if(X22 == 0)
        {
            goto label_9;
        }
        
        if(((X22 + 265) & 1) != 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X23.丘一一丆业丂丘丒世();
        if((X23 & 1) == 0)
        {
            goto label_11;
        }
        
        if((val_1 & 1) == 0)
        {
            goto label_12;
        }
        
        var val_35 = X22;
        if((X22 + 286) == 0)
        {
            goto label_16;
        }
        
        var val_19 = X22 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_15:
        if(((X22 + 176 + 8) + -8) == (X23 + 24))
        {
            goto label_14;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X22 + 286))
        {
            goto label_15;
        }
        
        goto label_16;
        label_34:
        if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0)) & 1) == 0)
        {
            goto label_17;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_21;
        }
        
        var val_21 = X22 + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_20:
        if(((X22 + 176 + 8) + -8) == X23.丘一一丆业丂丘丒世())
        {
            goto label_19;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (X22 + 286))
        {
            goto label_20;
        }
        
        goto label_21;
        label_35:
        var val_23 = X22;
        val_23 = val_23 + ((X23 + 72) << 4);
        val_25 = mem[(X22 + (X23 + 72) << 4) + 304];
        val_25 = (X22 + (X23 + 72) << 4) + 304;
        goto label_22;
        label_17:
        var val_24 = X22;
        bool val_3 = 东丏丂丙丑丁丞丞万;
        val_24 = val_24 + (X23 + 72);
        goto label_41;
        label_37:
        var val_25 = val_19;
        val_25 = val_25 + 业下丁且专丞一丕七;
        val_24 = val_24 + val_25;
        bool val_5 = val_24 + 296;
        label_39:
        val_25 = mem[(((X22 + X23 + 72) + (((X22 + 176 + 8) + 16) + (业下丁且专丞一丕七 & 1))) + 296) + 8];
        val_25 = (((X22 + X23 + 72) + (((X22 + 176 + 8) + 16) + (业下丁且专丞一丕七 & 1))) + 296) + 8;
        label_22:
        bool val_6 = 东丏丂丙丑丁丞丞万;
        bool val_7 = 业下丁且专丞一丕七;
        goto label_41;
        label_19:
        var val_26 = val_21;
        val_26 = val_26 + (X23 + 72);
        val_26 = X22 + val_26;
        val_24 = val_26 + 296;
        label_21:
        bool val_8 = 东丏丂丙丑丁丞丞万;
        bool val_9 = 业下丁且专丞一丕七;
        goto label_41;
        label_42:
        var val_10 = X25 + 0;
        val_22 = mem[(X25 + 0) + 32 + 32 + 8];
        val_22 = (X25 + 0) + 32 + 32 + 8;
        if((val_22 & 1) == 0)
        {
            goto label_27;
        }
        
        if(((X25 + 0) + 32 + 32 + 8 + 72) == 1)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) != 0)
        {
                if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_40;
        }
        
        }
        
        if(((X25 + 0) + 32 + 32 + 265) == 0)
        {
            goto label_40;
        }
        
        if(((X25 + 0) + 32 + 32) == 0)
        {
            goto label_32;
        }
        
        if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
        {
            goto label_41;
        }
        
        if((val_22 & 1) == 0)
        {
            goto label_34;
        }
        
        if((val_22.丘一一丆业丂丘丒世() & 1) == 0)
        {
            goto label_35;
        }
        
        if(((X25 + 0) + 32 + 32 + 286) == 0)
        {
            goto label_39;
        }
        
        var val_27 = (X25 + 0) + 32 + 32 + 176;
        var val_28 = 0;
        val_27 = val_27 + 8;
        label_38:
        if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
        {
            goto label_37;
        }
        
        val_28 = val_28 + 1;
        val_27 = val_27 + 16;
        if(val_28 < ((X25 + 0) + 32 + 32 + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_27:
        if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
        {
            goto label_40;
        }
        
        label_32:
        bool val_12 = 东丏丂丙丑丁丞丞万;
        bool val_13 = 业下丁且专丞一丕七;
        goto label_41;
        label_40:
        东丏丂丙丑丁丞丞万 = 东丏丂丙丑丁丞丞万;
        业下丁且专丞一丕七 = 业下丁且专丞一丕七;
        label_41:
        val_29 = val_29 + 1;
        if(val_29 != (X25 + 24))
        {
            goto label_42;
        }
        
        return;
        label_4:
        if((X23 + 74) != 2)
        {
            goto label_43;
        }
        
        label_9:
        bool val_14 = 东丏丂丙丑丁丞丞万;
        bool val_15 = 业下丁且专丞一丕七;
        label_43:
        东丏丂丙丑丁丞丞万 = 东丏丂丙丑丁丞丞万;
        业下丁且专丞一丕七 = 业下丁且专丞一丕七;
        label_52:
        label_11:
        if((val_1 & 1) == 0)
        {
            goto label_44;
        }
        
        if((X22 + 286) == 0)
        {
            goto label_48;
        }
        
        var val_30 = X22 + 176;
        var val_31 = 0;
        val_30 = val_30 + 8;
        label_47:
        if(((X22 + 176 + 8) + -8) == X23.丘一一丆业丂丘丒世())
        {
            goto label_46;
        }
        
        val_31 = val_31 + 1;
        val_30 = val_30 + 16;
        if(val_31 < (X22 + 286))
        {
            goto label_47;
        }
        
        goto label_48;
        label_12:
        var val_32 = X22;
        val_32 = val_32 + ((X23 + 72) << 4);
        val_27 = mem[(X22 + (X23 + 72) << 4) + 304];
        val_27 = (X22 + (X23 + 72) << 4) + 304;
        goto label_49;
        label_44:
        var val_33 = X22;
        val_33 = val_33 + (X23 + 72);
        goto label_50;
        label_14:
        var val_34 = val_19;
        val_34 = val_34 + (X23 + 72);
        val_35 = val_35 + val_34;
        val_23 = val_35 + 296;
        label_16:
        val_27 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8];
        val_27 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X22, typeof(X23 + 24), slot: 0) + 8;
        label_49:
        bool val_17 = 东丏丂丙丑丁丞丞万;
        bool val_18 = 业下丁且专丞一丕七;
        goto label_52;
        label_46:
        var val_36 = val_30;
        val_36 = val_36 + (X23 + 72);
        val_36 = X22 + val_36;
        val_26 = val_36 + 296;
        label_48:
        label_50:
        东丏丂丙丑丁丞丞万 = 东丏丂丙丑丁丞丞万;
        业下丁且专丞一丕七 = 业下丁且专丞一丕七;
        goto label_52;
    }
    public virtual System.IAsyncResult BeginInvoke(bool 东丏丂丙丑丁丞丞万, bool 业下丁且专丞一丕七, System.AsyncCallback 业丏丈世世世丞丒世, object 三一丄丗专丌丛丘丅)
    {
        bool val_1 = 东丏丂丙丑丁丞丞万;
        bool val_2 = 业下丁且专丞一丕七;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult 东且丁丆丛丁丏丘且)
    {
    
    }

}
