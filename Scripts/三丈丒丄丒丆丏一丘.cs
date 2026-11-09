using UnityEngine;
private sealed class 丒丑下丙丅丂丁丈不.三丈丒丄丒丆丏一丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.Offers.丒丑下丙丅丂丁丈不 丝且与丝丒丟万丁专;
    public System.Action 业丒丒专丞丒丘丌丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒丑下丙丅丂丁丈不.三丈丒丄丒丆丏一丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        int val_38;
        var val_39;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32> val_41;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        if(((this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 != null) && (this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.SeasonId >= 1)) && (coinsShop.七三丗丏丑丗三丆世() != false))
        {
                int val_3 = Rilisoft.Offers.专下丞一丕下下丗与.丛丅下丆丗丏三丁丕<System.Int32>(丕上业丕丘上丘七一:  new System.Nullable<OfferModule>() {HasValue = false}, 丒丑丂丐丕丒丕东与:  "level");
            if(val_3 >= 1)
        {
                if(val_3 <= ExperienceController.丞丞丘业东丙丏七丌())
        {
            goto label_16;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Clear();
        label_87:
        val_33 = this.业丒丒专丞丒丘丌丗;
        if(val_33 == null)
        {
                return (bool)val_33;
        }
        
        val_33.Invoke();
        label_1:
        val_33 = 0;
        return (bool)val_33;
        label_4:
        val_33 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_33;
        return (bool)val_33;
        label_16:
        if(Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.SeasonId != 0)
        {
                if(Count != 0)
        {
                if((System.String.op_Inequality(a:  Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.TierKey, b:  this.丝且与丝丒丟万丁专.不丌丁丙七专丁世不())) == false)
        {
            goto label_37;
        }
        
        }
        
        }
        
        val_34 = 1;
        label_37:
        if(this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.SeasonId != Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄.SeasonId)
        {
                Progress.DailyTierProgress val_10 = new Progress.DailyTierProgress();
            val_34 = 1;
            Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄 = val_10;
        }
        
        if(val_34 == 0)
        {
            goto label_31;
        }
        
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Clear();
        this.丝且与丝丒丟万丁专.丂丁丒一丅丄丏丐丁 = 0;
        if(Rilisoft.Offers.丒丑下丙丅丂丁丈不.丈丄丂下丒专丌丛丄 == null)
        {
            goto label_32;
        }
        
        val_35 = val_10.GenerateIndex;
        goto label_33;
        label_31:
        if(this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Count == 0)
        {
            goto label_34;
        }
        
        label_46:
        val_36 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_72;
        }
        
        goto label_67;
        label_32:
        val_35 = 0.GenerateIndex;
        label_33:
        val_10.GenerateIndex = val_35 + 1;
        System.Collections.Generic.List<DailyTierOffersSettingKey> val_15 = this.丝且与丝丒丟万丁专.丟丄丒七三七丅万业();
        if(val_15 == null)
        {
            goto label_38;
        }
        
        List.Enumerator<T> val_16 = val_15.GetEnumerator();
        label_44:
        val_37 = 0;
        label_41:
        if((508068288 & 1) == 0)
        {
            goto label_39;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_19 = this.丝且与丝丒丟万丁专.丁与且丅丏下丌且与(东丅丌丟丗丌世下丙:  0.丐丏七丌丕丗业且上());
        if(val_19 == null)
        {
            goto label_41;
        }
        
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Add(item:  val_19);
        goto label_44;
        label_34:
        if(mem[1152921543769689688] == 0)
        {
            goto label_46;
        }
        
        List.Enumerator<T> val_20 = mem[1152921543769689688].GetEnumerator();
        label_54:
        label_51:
        if((508068288 & 1) == 0)
        {
            goto label_49;
        }
        
        Rilisoft.业丙丘丆东丈丕丂丄 val_22 = this.丝且与丝丒丟万丁专.丁与且丅丏下丌且与(东丅丌丟丗丌世下丙:  0.丐丏七丌丕丗业且上());
        if(val_22 == null)
        {
            goto label_51;
        }
        
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Add(item:  val_22);
        goto label_54;
        label_38:
        val_37 = 0;
        goto label_70;
        label_39:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_70;
        label_49:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_72;
        }
        
        goto label_67;
        label_70:
        mem2[0] = mem[1152921543769689688];
        val_36 = W28 & 1;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_72;
        }
        
        label_67:
        label_72:
        val_38 = this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Count;
        goto label_77;
        label_80:
        val_38 = val_38 - 1;
        Rilisoft.业丙丘丆东丈丕丂丄 val_26 = this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Item[val_38];
        if(val_26.世一丒专丛丏世丁丙() != false)
        {
                bool val_28 = this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐.Remove(item:  val_26);
            val_36 = 1;
        }
        
        label_77:
        if(val_38 > 0)
        {
            goto label_80;
        }
        
        if((val_36 & 1) == 0)
        {
            goto label_87;
        }
        
        val_39 = null;
        val_39 = null;
        val_41 = 丒丑下丙丅丂丁丈不.<>c.<>9__24_0;
        if(val_41 == null)
        {
                System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32> val_29 = null;
            val_41 = val_29;
            val_29 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32>(object:  丒丑下丙丅丂丁丈不.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丒丑下丙丅丂丁丈不.<>c::下与专业上丅丑丏东(Rilisoft.业丙丘丆东丈丕丂丄 三丟东丕丄丄下下丑));
            丒丑下丙丅丂丁丈不.<>c.<>9__24_0 = val_41;
        }
        
        this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.OrderByDescending<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32>(source:  this.丝且与丝丒丟万丁专.且丑不丛丏丏丐丄丐, keySelector:  val_29));
        goto label_87;
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
