using UnityEngine;
private sealed class BPChallengesController.丝丒丛丘丛丄丐丝丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BPChallengesController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPChallengesController.丝丒丛丘丛丄丐丝丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_7;
        var val_11;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        int val_35;
        BPChallengesController val_36;
        var val_39;
        char val_40;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
            goto label_4;
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        this.丝且与丝丒丟万丁专.东丅业丅不上七丁丙();
        Dictionary.Enumerator<TKey, TValue> val_4 = this.丝且与丝丒丟万丁专.丘业业丒一丅东专丅.GetEnumerator();
        val_30 = 0;
        val_31 = 0;
        var val_27 = 0;
        label_54:
        if((1714578960 & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
        List.Enumerator<T> val_9 = val_8._value._obj.GetEnumerator();
        goto label_33;
        label_36:
        string val_12 = val_11.丐丏七丌丕丗业且上();
        if((val_3 == null) || (val_8._value._obj.丙东专丂世丈丏丁丂() != val_3.万上丁一丞业业万东()))
        {
            goto label_13;
        }
        
        if(val_3.专丁丟丏丁丏不丗三() == false)
        {
            goto label_14;
        }
        
        val_32 = (~val_3.丗丄上丑丑丅丐丒丌()) & 1;
        goto label_15;
        label_13:
        val_12.七丝丆丂丞丙丆丟三(丙业与丙丗丝不丈东:  false);
        goto label_33;
        label_14:
        val_32 = 0;
        label_15:
        if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() == false)
        {
            goto label_20;
        }
        
        if(val_32 == 0)
        {
            goto label_26;
        }
        
        if(val_12.业上丙丞丐丄丆丅七() != 9999)
        {
            goto label_23;
        }
        
        label_28:
        val_32 = 0;
        if(val_12 != null)
        {
            goto label_34;
        }
        
        goto label_35;
        label_20:
        if(val_32 == 0)
        {
            goto label_26;
        }
        
        if(val_12.业上丙丞丐丄丆丅七() != 9999)
        {
            goto label_28;
        }
        
        label_23:
        int val_20 = val_12.三万七与东丄业丐丙();
        if(val_12.三丝丄丈丆丂专丄东() != 10)
        {
            goto label_31;
        }
        
        label_26:
        if(val_12 != null)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        val_12.七丝丆丂丞丙丆丟三(丙业与丙丗丝不丈东:  (val_20 == val_3.丒丑丅丑丕万丞丅丟()) ? 1 : 0);
        goto label_33;
        label_31:
        var val_25 = (val_20 <= val_3.丒丑丅丑丕万丞丅丟()) ? 1 : 0;
        if(val_12 != null)
        {
            goto label_34;
        }
        
        goto label_35;
        label_33:
        if((1714578912 & 1) != 0)
        {
            goto label_36;
        }
        
        val_27 = val_27 + 1;
        mem2[0] = 339;
        val_33 = val_31;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_27 == 1) || ((1152921536386196864 + ((0 + 1)) << 2) != 339))
        {
            goto label_51;
        }
        
        var val_28 = 0;
        val_28 = val_28 ^ (val_27 >> 31);
        val_27 = val_27 + val_28;
        goto label_54;
        label_51:
        if( == 0)
        {
            goto label_54;
        }
        
        goto label_54;
        label_1:
        val_35 = 0;
        return (bool)val_35;
        label_4:
        val_35 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_35;
        return (bool)val_35;
        label_9:
        val_36 = this.丝且与丝丒丟万丁专;
        val_27 = val_27 + 1;
        mem2[0] = 367;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_27 == 1)
        {
            goto label_66;
        }
        
        if( == 0)
        {
            goto label_70;
        }
        
        if((1152921536386196864 + ((0 + 1)) << 2) != 367)
        {
            goto label_68;
        }
        
        goto label_70;
        label_66:
        if( == 0)
        {
            goto label_70;
        }
        
        label_68:
        label_70:
        val_29 = 1152921505136771072;
        val_39 = null;
        val_39 = null;
        val_40 = BPChallengesController.丁七丈丆丂丞丕丌丐;
        if(val_40 != 0)
        {
                val_40 = BPChallengesController.丁七丈丆丂丞丕丌丐;
            if(val_40 == 0)
        {
                val_40 = 0;
        }
        
            val_40.Invoke();
        }
        
        val_35 = 0;
        mem2[0] = 0;
        return (bool)val_35;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
