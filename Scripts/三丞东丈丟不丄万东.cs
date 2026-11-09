using UnityEngine;
private sealed class ItemRewardListViewScrolled.三丞东丈丟不丄万东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ItemRewardListViewScrolled 丝且与丝丒丟万丁专;
    private int 丛世一丁丄上一丒丅;
    private int 七东世与丏七且丞七;
    private int 世世不丕丕丑三丘一;
    private int 丕丗丆丆丈东东丐业;
    private System.Collections.Generic.IEnumerator<PGCompany.丄与丘丑业专丞七丅> 丑丅丞不不丏上丄丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ItemRewardListViewScrolled.三丞东丈丟不丄万东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 2)
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
        var val_28;
        System.Collections.Generic.IEnumerator<PGCompany.丄与丘丑业专丞七丅> val_29;
        int val_30;
        System.Collections.Generic.List<ItemRewardView> val_31;
        var val_32;
        var val_33;
        var val_36;
        int val_37;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_136;
        }
        
        val_28 = this;
        val_29 = this.丑丅丞不不丏上丄丅;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丘上丐世丆丑且丞丒();
        this.丝且与丝丒丟万丁专.丄一且丄丑专丙丗世();
        val_30 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_30;
        return (bool)val_30;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_29 = (float)System.Linq.Enumerable.Count<PGCompany.丄与丘丑业专丞七丅>(source:  this.丝且与丝丒丟万丁专.丑丟上一三业万万丏);
        val_29 = val_29 / (float)this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗.maxPerLine;
        this.丛世一丁丄上一丒丅 = UnityEngine.Mathf.CeilToInt(f:  val_29);
        List.Enumerator<T> val_4 = this.丝且与丝丒丟万丁专.linesScrollValues.GetEnumerator();
        val_31 = 1152921539246306928;
        label_21:
        if((279847152 & 1) == 0)
        {
            goto label_15;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if(val_7.m_stringLength != this.丛世一丁丄上一丒丅)
        {
            goto label_21;
        }
        
        val_6 = 0;
        this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_21;
        label_15:
        val_32 = 0;
        val_33 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (260 != 260))
        {
            goto label_38;
        }
        
        val_32 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_42;
        }
        
        goto label_40;
        label_38:
        if( != 0)
        {
                val_33 = 0;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_42;
        }
        
        label_40:
        label_42:
        val_6 = 0;
        this.丝且与丝丒丟万丁专.transform.parent.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        List.Enumerator<T> val_11 = this.丝且与丝丒丟万丁专.scaleSettings.GetEnumerator();
        label_52:
        if((279847120 & 1) == 0)
        {
            goto label_47;
        }
        
        string val_13 = 0.丐丏七丌丕丗业且上();
        if(val_13.m_stringLength != (System.Linq.Enumerable.Count<PGCompany.丄与丘丑业专丞七丅>(source:  this.丝且与丝丒丟万丁专.丑丟上一三业万万丏)))
        {
            goto label_52;
        }
        
        val_6 = 0;
        this.丝且与丝丒丟万丁专.transform.parent.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_52;
        label_47:
        mem2[0] = 407;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((0 + 1) == 1)
        {
            goto label_66;
        }
        
        if( == 0)
        {
            goto label_70;
        }
        
        if((1152921539246432384 + ((0 + 1)) << 2) != 407)
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
        this.七东世与丏七且丞七 = 1;
        this.世世不丕丕丑三丘一 = 0;
        this.丕丗丆丆丈东东丐业 = System.Linq.Enumerable.Count<PGCompany.丄与丘丑业专丞七丅>(source:  this.丝且与丝丒丟万丁专.丑丟上一三业万万丏);
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_29 = this.丝且与丝丒丟万丁专.丑丟上一三业万万丏.GetEnumerator();
        val_28 = this;
        this.丑丅丞不不丏上丄丅 = val_29;
        label_4:
        this.丗丏丅丕丆世丁专丟 = -3;
        var val_31 = 0;
        val_31 = val_31 + 1;
        if(val_29.MoveNext() == false)
        {
            goto label_81;
        }
        
        var val_34 = mem[val_20];
        if((mem[val_20] + 286) == 0)
        {
            goto label_86;
        }
        
        var val_32 = mem[val_20] + 176;
        var val_33 = 0;
        val_32 = val_32 + 8;
        label_85:
        if(((mem[val_20] + 176 + 8) + -8) == null)
        {
            goto label_84;
        }
        
        val_33 = val_33 + 1;
        val_32 = val_32 + 16;
        if(val_33 < (mem[val_20] + 286))
        {
            goto label_85;
        }
        
        goto label_86;
        label_81:
        this.一世丕丕业且且丅丌();
        val_37 = this.丛世一丁丄上一丒丅;
        this.丑丅丞不不丏上丄丅 = 0;
        if(val_37 >= this.丝且与丝丒丟万丁专.linesCountToShowScrollBar)
        {
                val_37 = this.丝且与丝丒丟万丁专.scrollBarVerical;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_37, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.scrollBarVerical, 丏业丟一东丂东丘丛:  true);
        }
        
        val_30 = this.丝且与丝丒丟万丁专.世万万丌丘丛丟丒上;
        if(val_30 == null)
        {
                return (bool)val_30;
        }
        
        val_30.Invoke();
        goto label_136;
        label_84:
        val_34 = val_34 + (((mem[val_20] + 176 + 8)) << 4);
        val_36 = val_34 + 296;
        label_86:
        int val_35 = this.丕丗丆丆丈东东丐业;
        val_35 = val_35 - 1;
        this.丕丗丆丆丈东东丐业 = val_35;
        ItemRewardView val_24 = this.丝且与丝丒丟万丁专.万上万丛丌丟丗上丂.Get<ItemRewardView>();
        val_31 = this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄;
        val_31.Add(item:  val_24);
        this.丝且与丝丒丟万丁专.SetParent(丑丂不下丁丄与万丏:  val_24);
        val_24.gameObject.SetActive(value:  true);
        if((UnityEngine.Object.op_Implicit(exists:  this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗)) != false)
        {
                this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗.repositionNow = true;
        }
        
        if(this.丝且与丝丒丟万丁专.丒丄丒丈丛丈专三丞 != null)
        {
                this.丝且与丝丒丟万丁专.丒丄丒丈丛丈专三丞.Invoke(obj:  this.丑丅丞不不丏上丄丅.Current);
        }
        
        val_37 = this.世世不丕丕丑三丘一 + 1;
        this.世世不丕丕丑三丘一 = val_37;
        if(val_37 >= this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗.maxPerLine)
        {
                int val_27 = this.七东世与丏七且丞七 + 1;
            this.七东世与丏七且丞七 = val_27;
            this.世世不丕丕丑三丘一 = 0;
            if(this.丕丗丆丆丈东东丐业 >= 1)
        {
                this.丝且与丝丒丟万丁专.与丁丞万丏丂业丝丁(丐丁上上专七丑丐丗:  val_27);
        }
        
        }
        
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.stepDelay);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_30 = 1;
        return (bool)val_30;
        label_136:
        val_30 = 0;
        return (bool)val_30;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丑丅丞不不丏上丄丅 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丑丅丞不不丏上丄丅.Dispose();
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
