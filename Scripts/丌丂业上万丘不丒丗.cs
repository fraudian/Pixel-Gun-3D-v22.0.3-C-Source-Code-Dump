using UnityEngine;
private sealed class ItemRewardListView.丌丂业上万丘不丒丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ItemRewardListView 丝且与丝丒丟万丁专;
    private System.Collections.Generic.IEnumerator<PGCompany.丄与丘丑业专丞七丅> 与业丕业业业丌丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ItemRewardListView.丌丂业上万丘不丒丗(int 丗丏丅丕丆世丁专丟)
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
        System.Collections.Generic.IEnumerator<PGCompany.丄与丘丑业专丞七丅> val_20;
        System.Collections.Generic.IEnumerable<PGCompany.丄与丘丑业专丞七丅> val_21;
        int val_23;
        var val_24;
        System.Collections.Generic.IEnumerator<PGCompany.丄与丘丑业专丞七丅> val_25;
        var val_26;
        var val_27;
        WidgetLayout val_28;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_105;
        }
        
        val_20 = this.与业丕业业业丌丟丐;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丘上丐世丆丑且丞丒();
        this.丝且与丝丒丟万丁专.丄一且丄丑专丙丗世();
        val_21 = this.丝且与丝丒丟万丁专.丑丟上一三业万万丏;
        if(val_21 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
        }
        else
        {
                val_23 = 0;
            this.丝且与丝丒丟万丁专.丗丞丄丐丈万丕丌一 = true;
            return (bool)val_23;
        }
        
        val_20 = this;
        this.与业丕业业业丌丟丐 = val_21.GetEnumerator();
        label_3:
        val_24 = 0;
        this.丗丏丅丕丆世丁专丟 = -3;
        label_40:
        val_25 = this.与业丕业业业丌丟丐;
        var val_24 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_17;
        }
        
        var val_22 = mem[val_2] + 176;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_16:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_15;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (mem[val_2] + 286))
        {
            goto label_16;
        }
        
        goto label_17;
        label_15:
        val_24 = val_24 + (((mem[val_2] + 176 + 8)) << 4);
        val_26 = val_24 + 296;
        label_17:
        if(val_25.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_27 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_23;
        }
        
        var val_25 = mem[val_2] + 176;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_22:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_21;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (mem[val_2] + 286))
        {
            goto label_22;
        }
        
        goto label_23;
        label_21:
        val_27 = val_27 + (((mem[val_2] + 176 + 8)) << 4);
        val_27 = val_27 + 296;
        label_23:
        val_25 = this.与业丕业业业丌丟丐.Current;
        ItemRewardView val_5 = this.丝且与丝丒丟万丁专.万上万丛丌丟丗上丂.Get<ItemRewardView>();
        this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Add(item:  val_5);
        this.丝且与丝丒丟万丁专.SetParent(丑丂不下丁丄与万丏:  val_5);
        val_28 = val_5.gameObject;
        val_28.SetActive(value:  true);
        if(this.丝且与丝丒丟万丁专.丏专丌万与上丆丈三 != null)
        {
                (this.丝且与丝丒丟万丁专.丏专丌万与上丆丈三 == 0) ? 0 : this.丝且与丝丒丟万丁专.丏专丌万与上丆丈三.AddElement(丅丆东丏丙丝丅丆丟:  val_5);
            val_28 = this.丝且与丝丒丟万丁专.丏专丌万与上丆丈三;
            if(val_28 != null)
        {
                (val_28 == 0) ? (val_24) : (val_28).Reposition();
            val_24 = val_28;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗)) != false)
        {
                this.丝且与丝丒丟万丁专.丝三不丑丏丘丒丂丗.repositionNow = true;
        }
        
        if(this.丝且与丝丒丟万丁专.丒丄丒丈丛丈专三丞 != null)
        {
                (this.丝且与丝丒丟万丁专.丒丄丒丈丛丈专三丞 == 0) ? 0 : this.丝且与丝丒丟万丁专.丒丄丒丈丛丈专三丞.Invoke(obj:  val_25);
        }
        
        if(this.丝且与丝丒丟万丁专.stepDelay <= 0f)
        {
            goto label_40;
        }
        
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.stepDelay);
        val_23 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_18:
        this.一世丕丕业且且丅丌();
        this.与业丕业业业丌丟丐 = 0;
        val_21 = this.丝且与丝丒丟万丁专.丅业上丆丕上丝丄不;
        if((UnityEngine.Object.op_Implicit(exists:  val_21)) == false)
        {
            goto label_45;
        }
        
        this.丝且与丝丒丟万丁专.丅业上丆丕上丝丄不.state = this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Count - 1;
        this.丝且与丝丒丟万丁专.丅业上丆丕上丝丄不.LoadState();
        val_28 = 1152921539242113936;
        val_21 = 0;
        goto label_49;
        label_62:
        val_25 = this.丝且与丝丒丟万丁专.丅业上丆丕上丝丄不.obj[0].transform;
        this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Item[0].transform.SetParent(p:  val_25);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Item[0].transform);
        val_21 = 1;
        label_49:
        if(val_21 < this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Count)
        {
            goto label_62;
        }
        
        label_45:
        val_23 = this.丝且与丝丒丟万丁专.世万万丌丘丛丟丒上;
        this.丝且与丝丒丟万丁专.丗丞丄丐丈万丕丌一 = true;
        if(val_23 == null)
        {
                return (bool)val_23;
        }
        
        val_23.Invoke();
        label_105:
        val_23 = 0;
        return (bool)val_23;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.与业丕业业业丌丟丐 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.与业丕业业业丌丟丐.Dispose();
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
