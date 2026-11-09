using UnityEngine;
private sealed class 丅丆万丟丐丏丏下丄.丄丒丈丄东且丌丌丁 : IEnumerable<UnityEngine.GameObject>, IEnumerable, IEnumerator<UnityEngine.GameObject>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private UnityEngine.GameObject 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private System.Collections.Generic.IEnumerable<UnityEngine.GameObject> 丑东与丅丐丅丂丞业;
    public System.Collections.Generic.IEnumerable<UnityEngine.GameObject> 丆丙丌丝丝丌下不丐;
    private string 丒丘丏上丙丟丑丕丈;
    public string 丂丘丑丘丝丛且三东;
    private System.Collections.Generic.IEnumerator<UnityEngine.GameObject> 与业丕业业业丌丟丐;
    private System.Collections.Generic.IEnumerator<UnityEngine.GameObject> 业东东下丘丒丝业专;
    
    // Properties
    private UnityEngine.GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丆万丟丐丏丏下丄.丄丒丈丄东且丌丌丁(int 丗丏丅丕丆世丁专丟)
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
        
        if((this.丗丏丅丕丆世丁专丟 == 4) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        goto label_6;
        label_0:
        if(this.丗丏丅丕丆世丁专丟 != 1)
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
        System.Collections.Generic.IEnumerator<UnityEngine.GameObject> val_9;
        var val_10;
        var val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_49;
        }
        
        goto label_41;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_9 = this.丑东与丅丐丅丂丞业.GetEnumerator();
        val_10 = this;
        this.与业丕业业业丌丟丐 = val_9;
        this.丗丏丅丕丆世丁专丟 = -3;
        if(val_9 != null)
        {
            goto label_23;
        }
        
        goto label_10;
        label_41:
        this.丗丏丅丕丆世丁专丟 = -4;
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(this.业东东下丘丒丝业专.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_22;
        label_17:
        this.且丆与丗丏三专丅丌();
        val_10 = this;
        val_9 = this.与业丕业业业丌丟丐;
        this.业东东下丘丒丝业专 = 0;
        if(val_9 != null)
        {
            goto label_23;
        }
        
        label_10:
        label_23:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_28;
        }
        
        var val_19 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_33;
        }
        
        var val_17 = mem[val_2] + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_32:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_31;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (mem[val_2] + 286))
        {
            goto label_32;
        }
        
        goto label_33;
        label_28:
        this.一世丕丕业且且丅丌();
        val_15 = 0;
        this.与业丕业业业丌丟丐 = 0;
        return (bool)val_15;
        label_22:
        this.丒上七丌业七丟与丐 = this.业东东下丘丒丝业专.Current;
        val_15 = 1;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_31:
        val_19 = val_19 + (((mem[val_2] + 176 + 8)) << 4);
        val_14 = val_19 + 296;
        label_33:
        var val_20 = 0;
        val_20 = val_20 + 1;
        this.业东东下丘丒丝业专 = Unity.Linq.丅丆万丟丐丏丏下丄.上专丈丄丄丌丑丏不(丈丆上丅丘世专丑丕:  this.与业丕业业业丌丟丐.Current, 丛业万丗业丝丕不上:  this.丒丘丏上丙丟丑丕丈, 丗七丐世业丆丂下丑:  true).GetEnumerator();
        goto label_41;
        label_49:
        val_15 = 0;
        return (bool)val_15;
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
        System.Collections.Generic.IEnumerable<UnityEngine.GameObject> val_4;
        var val_5;
        if((this.丗丏丅丕丆世丁专丟 != 2) || (this.丈世三丐万且丅上丈 != System.Environment.CurrentManagedThreadId))
        {
            goto label_2;
        }
        
        val_4 = this.丆丙丌丝丝丌下不丐;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this;
        goto label_3;
        label_2:
        丅丆万丟丐丏丏下丄.丄丒丈丄东且丌丌丁 val_2 = null;
        val_5 = val_2;
        val_2 = new 丅丆万丟丐丏丏下丄.丄丒丈丄东且丌丌丁();
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        val_4 = this.丆丙丌丝丝丌下不丐;
        if(val_5 == null)
        {
            goto label_4;
        }
        
        label_3:
        .丑东与丅丐丅丂丞业 = val_4;
        .丒丘丏上丙丟丑丕丈 = this.丂丘丑丘丝丛且三东;
        return (System.Collections.Generic.IEnumerator<UnityEngine.GameObject>)val_5;
        label_4:
        mem[40] = val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator();
    }

}
