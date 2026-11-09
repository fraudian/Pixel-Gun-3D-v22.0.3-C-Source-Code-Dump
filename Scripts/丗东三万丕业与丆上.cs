using UnityEngine;
private sealed class 丏下丞上世丘不业万.丗东三万丕业与丆上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ItemRewardListView 业上丙下丕专丏丒与;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> 万丒不丐丞丗世丐世;
    private System.Collections.Generic.List.Enumerator<SimpleTweenePlayer> 业东东下丘丒丝业专;
    private SimpleTweenePlayer 万丒东丟丅丐上专不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丏下丞上世丘不业万.丗东三万丕业与丆上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_6;
        var val_12;
        List.Enumerator<SimpleTweenePlayer> val_13;
        List.Enumerator<SimpleTweenePlayer> val_18;
        var val_19;
        System.Comparison<PGCompany.InventoryItemView> val_21;
        var val_22;
        var val_23;
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_24;
        int val_27;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_68;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        this.万丒东丟丅丐上专不.Play();
        val_18 = this.业东东下丘丒丝业专;
        this.万丒东丟丅丐上专不 = 0;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.InventoryItemView>.万世丅七一专丕丞不();
        this.万丒不丐丞丗世丐世 = val_1;
        this.业上丙下丕专丏丒与.GetComponentsInChildren<PGCompany.InventoryItemView>(includeInactive:  true, result:  val_1);
        val_19 = null;
        val_19 = null;
        val_21 = 丏下丞上世丘不业万.<>c.<>9__24_0;
        if(val_21 == null)
        {
            goto label_11;
        }
        
        if(this.万丒不丐丞丗世丐世 != null)
        {
            goto label_16;
        }
        
        goto label_13;
        label_11:
        val_21 = null;
        val_21 = new System.Comparison<PGCompany.InventoryItemView>(object:  丏下丞上世丘不业万.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丏下丞上世丘不业万.<>c::丂一丐丄一丈丒丘世(PGCompany.InventoryItemView 丈丂丕下丏丈丞丗业, PGCompany.InventoryItemView 丂丌丌丛丆丆丙丌丈));
        丏下丞上世丘不业万.<>c.<>9__24_0 = val_21;
        if(this.万丒不丐丞丗世丐世 != null)
        {
            goto label_16;
        }
        
        label_13:
        label_16:
        val_22 = public System.Void System.Collections.Generic.List<PGCompany.InventoryItemView>::Sort(System.Comparison<T> comparison);
        this.万丒不丐丞丗世丐世.Sort(comparison:  null);
        System.Collections.Generic.List<SimpleTweenePlayer> val_3 = new System.Collections.Generic.List<SimpleTweenePlayer>();
        List.Enumerator<T> val_4 = this.万丒不丐丞丗世丐世.GetEnumerator();
        label_28:
        if(((-133951024) & 1) == 0)
        {
            goto label_18;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if(val_7 == 0)
        {
            goto label_28;
        }
        
        SimpleTweenePlayer val_9 = val_7.GetComponent<SimpleTweenePlayer>();
        if((val_9 == null) || (val_9 == 0))
        {
            goto label_28;
        }
        
        val_9.SetInitial();
        null.Add(item:  val_9);
        goto label_28;
        label_18:
        val_23 = 0;
        val_24 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_44;
        }
        
        if( == 0)
        {
            goto label_48;
        }
        
        if(209 != 209)
        {
            goto label_46;
        }
        
        goto label_48;
        label_44:
        if( == 0)
        {
            goto label_48;
        }
        
        label_46:
        val_22 = 0;
        label_48:
        List.Enumerator<T> val_11 = null.GetEnumerator();
        val_18 = this.业东东下丘丒丝业专;
        mem[1152921560307482992] = val_12;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.业东东下丘丒丝业专 = val_13;
        label_4:
        if((val_18 & 1) != 0)
        {
                this.万丒东丟丅丐上专不 = val_18.丐丏七丌丕丗业且上();
            this.丒上七丌业七丟与丐 = PGCompany.Ads.AdvertisingChestWindowMachinery.丏下丞上世丘不业万.丐丕万丛丝丆丏业丁();
            val_27 = 1;
            this.丗丏丅丕丆世丁专丟 = val_27;
            return (bool)val_27;
        }
        
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_24 = this.万丒不丐丞丗世丐世;
        label_68:
        val_27 = 0;
        return (bool)val_27;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.业东东下丘丒丝业专);
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
