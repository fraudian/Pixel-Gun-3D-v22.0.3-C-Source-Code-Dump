using UnityEngine;
private sealed class ClanWarUIRewardsAnimator.与下万丛专丟丝且丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三;
    public PGCompany.ClanWarUIRewardsAnimator 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarUIRewardsAnimator.与下万丛专丟丝且丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        PGCompany.ClanWarUIRewardsAnimator val_34;
        System.Action val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_40;
        var val_41;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_34 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.上业丟世三与七七三 == null)
        {
            goto label_4;
        }
        
        List.Enumerator<T> val_3 = System.Linq.Enumerable.ToList<DiscreteVector2>(source:  this.上业丟世三与七七三.Keys).GetEnumerator();
        label_12:
        if(((-1894463520) & 1) == 0)
        {
            goto label_6;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((this.上业丟世三与七七三.Item[new DiscreteVector2() {_x = val_6, _y = val_6}]) != null)
        {
                if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  this.上业丟世三与七七三.Item[new DiscreteVector2() {_x = val_6, _y = val_6}])) == true)
        {
            goto label_12;
        }
        
        }
        
        bool val_10 = this.上业丟世三与七七三.Remove(key:  new DiscreteVector2() {_x = val_6, _y = val_6});
        goto label_12;
        label_2:
        val_35 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_35;
        label_4:
        if(val_34 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        bool val_11 = System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>>>(source:  this.上业丟世三与七七三);
        if(val_34 == null)
        {
            goto label_23;
        }
        
        if(val_11 == false)
        {
            goto label_24;
        }
        
        label_70:
        if(this.丝且与丝丒丟万丁专.丁丁丞丌丗丑丞不丂 != null)
        {
                this.丝且与丝丒丟万丁专.丁丁丞丌丗丑丞不丂.Invoke();
        }
        
        if((PGCompany.万丞丘与丕丞下万丌.不万丌东丞上丒丞不(三丅丘上丞一丙丑业:  1)) == false)
        {
            goto label_28;
        }
        
        System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> val_13 = new System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>>();
        Dictionary.Enumerator<TKey, TValue> val_14 = this.上业丟世三与七七三.GetEnumerator();
        val_36 = 0;
        label_69:
        if(((-1894463568) & 1) == 0)
        {
            goto label_30;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_5.GetAwaiter();
        List.Enumerator<T> val_17 = val_16._value._obj.GetEnumerator();
        label_47:
        if(((-1894463616) & 1) == 0)
        {
            goto label_32;
        }
        
        string val_18 = val_5.丐丏七丌丕丗业且上();
        if((val_18.Type != 1200) || ((System.String.op_Equality(a:  val_18.Id, b:  "ClanSilver")) == false))
        {
            goto label_47;
        }
        
        if((val_13.ContainsKey(key:  new DiscreteVector2() {_x = val_16._value._obj.丐丏七丌丕丗业且上(), _y = val_16._value._obj.丐丏七丌丕丗业且上()})) != true)
        {
                System.Collections.Generic.List<Rilisoft.OfferItem> val_25 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_13.set_Item(key:  new DiscreteVector2() {_x = val_16._value._obj.丐丏七丌丕丗业且上(), _y = val_16._value._obj.丐丏七丌丕丗业且上()}, value:  null);
        }
        
        Rilisoft.OfferItem val_26 = PGCompany.万丞丘与丕丞下万丌.丐丝不七与丑且丟丝(丏且丕丄丁丟丆丏丁:  val_18);
        val_26.Count = val_26.Count - val_18.Count;
        val_13.Item[new DiscreteVector2() {_x = val_16._value._obj.丐丏七丌丕丗业且上(), _y = val_16._value._obj.丐丏七丌丕丗业且上()}].Add(item:  val_26);
        goto label_47;
        label_32:
        val_37 = 0;
        val_38 = 0 + 1;
        mem2[0] = 448;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_38 == 1) || ((1152921554251990832 + ((0 + 1)) << 2) != 448))
        {
            goto label_66;
        }
        
        var val_34 = 0;
        val_34 = val_34 ^ (val_38 >> 31);
        val_38 = val_38 + val_34;
        goto label_69;
        label_66:
        if( == 0)
        {
            goto label_69;
        }
        
        goto label_69;
        label_23:
        if(val_11 == true)
        {
            goto label_70;
        }
        
        label_24:
        val_35 = this.丝且与丝丒丟万丁专.丐七丘丟世丐东丛丅;
        if(val_35 == null)
        {
                return (bool)val_35;
        }
        
        val_35.Invoke();
        label_3:
        val_35 = 0;
        return (bool)val_35;
        label_28:
        this.丒上七丌业七丟与丐 = val_34.世专丑丞丄丑与且专(上业丟世三与七七三:  this.上业丟世三与七七三);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_35;
        label_30:
        val_40 = 0;
        val_41 = 0 + 1;
        mem2[0] = 476;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_38 == 1)
        {
            goto label_78;
        }
        
        if(( == 0) || ((1152921554251990832 + ((0 + 1)) << 2) == 476))
        {
            goto label_84;
        }
        
        label_83:
        label_84:
        this.丒上七丌业七丟与丐 = val_34.且上丘丐丂丑丅世且(上业丟世三与七七三:  this.上业丟世三与七七三, 丕丂丗丟专东丌不丞:  val_13);
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_35;
        label_78:
        if( != 0)
        {
            goto label_83;
        }
        
        goto label_84;
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
