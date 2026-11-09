using UnityEngine;
private sealed class ClanLootBoxRewardUI.不丈丂丈丂三丁丆丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanLootBoxRewardUI 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丝丅下丒丏丙丒万丆;
    private System.Collections.Generic.List.Enumerator<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 业东东下丘丒丝业专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanLootBoxRewardUI.不丈丂丈丂三丁丆丌(int 丗丏丅丕丆世丁专丟)
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
        var val_20;
        var val_24;
        var val_31;
        List.Enumerator<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> val_32;
        ClanLootBoxCraftWeaponWindow val_34;
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_35;
        float val_36;
        var val_37;
        ClanLootBoxMultiRewardContainer val_38;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_39;
        int val_40;
        var val_41;
        var val_42;
        var val_43;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_99;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        label_90:
        if((this.业东东下丘丒丝业专 & 1) == 0)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.丈丏丁东上与东丙丕().Clear();
        this.丝且与丝丒丟万丁专.丈丏丁东上与东丙丕().AddRange(collection:  this.业东东下丘丒丝业专.丐丏七丌丕丗业且上());
        float val_4 = this.丝且与丝丒丟万丁专.上丟下丂丙丛丕丌且.一丒专丝丛丟上三丅();
        val_35 = this.丝且与丝丒丟万丁专.丞上丈丁丙丙丟东万;
        if(this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 == false)
        {
            goto label_10;
        }
        
        float val_6 = val_4 + this.丝且与丝丒丟万丁专.animateRewardDelay;
        val_6 = val_6 * (float)val_35.Count;
        val_36 = val_6 / this.丝且与丝丒丟万丁专.multiOpenSpeedScale;
        goto label_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 = true;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        this.丝丅下丒丏丙丒万丆 = null;
        null.AddRange(collection:  this.丝且与丝丒丟万丁专.丈丏丁东上与东丙丕());
        System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> val_9 = new System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>();
        label_18:
        if(null.Count >= this.丝且与丝丒丟万丁专.丏丏丝专下丟丅丁丅)
        {
            goto label_16;
        }
        
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_11 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        null.Add(item:  null);
        goto label_18;
        label_3:
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_37 = this.丝且与丝丒丟万丁专;
            val_38 = this.丝且与丝丒丟万丁专.window_multiRewardResult;
            val_39 = this.丝丅下丒丏丙丒万丆;
        }
        else
        {
                val_37 = 184;
            val_38 = 130653168;
            val_39 = this.丝丅下丒丏丙丒万丆;
        }
        
        val_34 = this.丝且与丝丒丟万丁专.window_CraftableWeapon;
        new System.Action() = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  typeof(PGCompany.ClanLootBoxRewardUI).__il2cppRuntimeField_1B0);
        val_38.丈且东丑丂且万丒丅<ClanLootBoxCraftWeaponWindow>(上业丟世三与七七三:  val_39, 丙与丟丞三三丈丁七:  val_34, 与万一丏丙且丝丒丞:  new System.Action());
        this.丝且与丝丒丟万丁专.业三东丏与丘丞丆专();
        this.丝且与丝丒丟万丁专.一东丁丅三丙丅丐丒 = false;
        val_35 = this.丝且与丝丒丟万丁专.丈丏丁东上与东丙丕();
        val_35.Clear();
        this.丝且与丝丒丟万丁专.丞丆丏万丝世丐丈丌 = 0;
        130653168.丄下丑与与丟丗丟丏();
        goto label_99;
        label_10:
        val_4 = val_4 + this.丝且与丝丒丟万丁专.animateRewardDelay;
        val_36 = val_4 * (float)val_35.Count;
        label_12:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  val_36);
        val_40 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
        this.丗丏丅丕丆世丁专丟 = val_40;
        return (bool)val_40;
        label_16:
        if((this.丝且与丝丒丟万丁专.专东丐丂七专与丕丗 == null) || (this.丝且与丝丒丟万丁专.专东丐丂七专与丕丗.Count < 1))
        {
            goto label_88;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_17 = this.丝且与丝丒丟万丁专.专东丐丂七专与丕丗.GetEnumerator();
        val_41 = 0;
        val_42 = 0;
        var val_33 = 0;
        label_50:
        if(((-2036890016) & 1) == 0)
        {
            goto label_31;
        }
        
        ConfiguredValueTaskAwaiter val_21 = val_20.GetAwaiter();
        List.Enumerator<T> val_22 = val_21._value._obj.GetEnumerator();
        label_38:
        if(((-2036890064) & 1) == 0)
        {
            goto label_33;
        }
        
        null.Item[val_21._value._obj.丙东专丂世丈丏丁丂()].Add(item:  this.丝且与丝丒丟万丁专.丈丏丁东上与东丙丕().Item[val_24.丙东专丂世丈丏丁丂()]);
        goto label_38;
        label_33:
        val_33 = val_33 + 1;
        mem2[0] = 252;
        val_43 = val_42;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_33 == 1) || ((-2036890192 + ((0 + 1)) << 2) != 252))
        {
            goto label_47;
        }
        
        var val_34 = 0;
        val_34 = val_34 ^ (val_33 >> 31);
        val_33 = val_33 + val_34;
        goto label_50;
        label_47:
        if( == 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_31:
        val_33 = val_33 + 1;
        mem2[0] = 277;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_33 == 1)
        {
            goto label_84;
        }
        
        if( == 0)
        {
            goto label_88;
        }
        
        if((-2036890192 + ((0 + 1)) << 2) != 277)
        {
            goto label_86;
        }
        
        goto label_88;
        label_84:
        if( == 0)
        {
            goto label_88;
        }
        
        label_86:
        label_88:
        List.Enumerator<T> val_30 = null.GetEnumerator();
        mem[1152921554109576752] = val_31;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.业东东下丘丒丝业专 = val_32;
        goto label_90;
        label_99:
        val_40 = 0;
        return (bool)val_40;
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
