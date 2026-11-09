using UnityEngine;
private sealed class 丅丆万丟丐丏丏下丄.丑丟丏丏丑不丆业不 : IEnumerable<UnityEngine.GameObject>, IEnumerable, IEnumerator<UnityEngine.GameObject>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private UnityEngine.GameObject 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private UnityEngine.GameObject 丈丆上丅丘世专丑丕;
    public UnityEngine.GameObject 丄不万丒三丝与丛不;
    private bool 丗七丐世业丆丂下丑;
    public bool 万不下不丟东丒丅丒;
    private string 丛业万丗业丝丕不上;
    public string 专丞万丕丘丗且丘丅;
    private System.Collections.IEnumerator 与业丕业业业丌丟丐;
    private System.Collections.Generic.IEnumerator<UnityEngine.GameObject> 业东东下丘丒丝业专;
    
    // Properties
    private UnityEngine.GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丆万丟丐丏丏下丄.丑丟丏丏丑不丆业不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.丗丏丅丕丆世丁专丟 & 4294967294) != 4)
        {
            goto label_0;
        }
        
        if((this.丗丏丅丕丆世丁专丟 == 4) || (this.丗丏丅丕丆世丁专丟 == 2))
        {
            goto label_2;
        }
        
        goto label_6;
        label_0:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
                return;
        }
        
        label_2:
        this.且丆与丗丏三专丅丌();
        label_6:
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        System.Collections.Generic.IEnumerator<UnityEngine.GameObject> val_18;
        string val_19;
        int val_21;
        var val_22;
        var val_24;
        var val_25;
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
            goto label_72;
        }
        
        val_18 = this.业东东下丘丒丝业专;
        val_19 = this.丛业万丗业丝丕不上;
        goto label_4;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_18:
        System.Collections.IEnumerator val_2 = mem[this.丈丆上丅丘世专丑丕].transform.GetEnumerator();
        val_19 = this;
        this.与业丕业业业丌丟丐 = val_2;
        this.丗丏丅丕丆世丁专丟 = -3;
        if(val_2 != null)
        {
            goto label_51;
        }
        
        label_52:
        label_51:
        var val_20 = 0;
        val_20 = val_20 + 1;
        goto label_11;
        label_1:
        val_19 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丈丆上丅丘世专丑丕 == 0)
        {
            goto label_72;
        }
        
        if(this.丗七丐世业丆丂下丑 == false)
        {
            goto label_18;
        }
        
        if(this.丛业万丗业丝丕不上 != null)
        {
                if((System.String.op_Equality(a:  null.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_18;
        }
        
        }
        
        val_21 = 1;
        this.丗丏丅丕丆世丁专丟 = val_21;
        this.丒上七丌业七丟与丐 = this.丈丆上丅丘世专丑丕;
        return (bool)val_21;
        label_11:
        if(val_2.MoveNext() == false)
        {
            goto label_20;
        }
        
        var val_24 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_25;
        }
        
        var val_21 = mem[val_2] + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_24:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_23;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (mem[val_2] + 286))
        {
            goto label_24;
        }
        
        goto label_25;
        label_20:
        this.一世丕丕业且且丅丌();
        val_21 = 0;
        mem[1152921541540696400] = 0;
        return (bool)val_21;
        label_23:
        var val_23 = val_21;
        val_23 = val_23 + 1;
        val_24 = val_24 + val_23;
        val_22 = val_24 + 296;
        label_25:
        object val_8 = this.与业丕业业业丌丟丐.Current;
        val_19 = this;
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_18 = this;
        this.业东东下丘丒丝业专 = Unity.Linq.丅丆万丟丐丏丏下丄.上专丈丄丄丌丑丏不(丈丆上丅丘世专丑丕:  0.gameObject, 丛业万丗业丝丕不上:  this.丛业万丗业丝丕不上, 丗七丐世业丆丂下丑:  true).GetEnumerator();
        label_4:
        this.丗丏丅丕丆世丁专丟 = -4;
        label_48:
        var val_28 = mem[val_14];
        if((mem[val_14] + 286) == 0)
        {
            goto label_39;
        }
        
        var val_26 = mem[val_14] + 176;
        var val_27 = 0;
        val_26 = val_26 + 8;
        label_38:
        if(((mem[val_14] + 176 + 8) + -8) == null)
        {
            goto label_37;
        }
        
        val_27 = val_27 + 1;
        val_26 = val_26 + 16;
        if(val_27 < (mem[val_14] + 286))
        {
            goto label_38;
        }
        
        goto label_39;
        label_37:
        val_28 = val_28 + (((mem[val_14] + 176 + 8)) << 4);
        val_24 = val_28 + 296;
        label_39:
        if(this.业东东下丘丒丝业专.MoveNext() == false)
        {
            goto label_40;
        }
        
        var val_31 = mem[val_14];
        if((mem[val_14] + 286) == 0)
        {
            goto label_45;
        }
        
        var val_29 = mem[val_14] + 176;
        var val_30 = 0;
        val_29 = val_29 + 8;
        label_44:
        if(((mem[val_14] + 176 + 8) + -8) == null)
        {
            goto label_43;
        }
        
        val_30 = val_30 + 1;
        val_29 = val_29 + 16;
        if(val_30 < (mem[val_14] + 286))
        {
            goto label_44;
        }
        
        goto label_45;
        label_43:
        val_31 = val_31 + (((mem[val_14] + 176 + 8)) << 4);
        val_25 = val_31 + 296;
        label_45:
        T val_16 = this.业东东下丘丒丝业专.Current;
        if(null != null)
        {
                if((System.String.op_Equality(a:  val_16.name, b:  null)) == false)
        {
            goto label_48;
        }
        
        }
        
        this.丒上七丌业七丟与丐 = val_16.gameObject;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_21 = 1;
        return (bool)val_21;
        label_40:
        this.且丆与丗丏三专丅丌();
        this.业东东下丘丒丝业专 = 0;
        if(this.与业丕业业业丌丟丐 != null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_72:
        val_21 = 0;
        return (bool)val_21;
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
    private void 且丆与丗丏三专丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = -3;
        if(this.业东东下丘丒丝业专 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.业东东下丘丒丝业专.Dispose();
    }
    private UnityEngine.GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.get_Current()
    {
        return (UnityEngine.GameObject)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<UnityEngine.GameObject> System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        if((this.丗丏丅丕丆世丁专丟 != 2) || (this.丈世三丐万且丅上丈 != System.Environment.CurrentManagedThreadId))
        {
            goto label_2;
        }
        
        val_4 = this.丄不万丒三丝与丛不;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this;
        goto label_3;
        label_2:
        丅丆万丟丐丏丏下丄.丑丟丏丏丑不丆业不 val_2 = null;
        val_5 = val_2;
        val_2 = new 丅丆万丟丐丏丏下丄.丑丟丏丏丑不丆业不();
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        val_4 = this.丄不万丒三丝与丛不;
        if(val_5 == null)
        {
            goto label_4;
        }
        
        label_3:
        .丈丆上丅丘世专丑丕 = val_4;
        .丛业万丗业丝丕不上 = this.专丞万丕丘丗且丘丅;
        .丗七丐世业丆丂下丑 = this.万不下不丟东丒丅丒;
        return (System.Collections.Generic.IEnumerator<UnityEngine.GameObject>)val_5;
        label_4:
        mem[40] = val_4;
        mem[64] = this.专丞万丕丘丗且丘丅;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator();
    }

}
