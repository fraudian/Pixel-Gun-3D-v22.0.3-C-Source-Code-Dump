using UnityEngine;
private sealed class 且丐上一丝业不专上.一丕且丂且专丗丘丂 : IEnumerable<SimpleJSON.且丐上一丝业不专上>, IEnumerable, IEnumerator<SimpleJSON.且丐上一丝业不专上>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private SimpleJSON.且丐上一丝业不专上 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public SimpleJSON.且丐上一丝业不专上 丝且与丝丒丟万丁专;
    private System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上> 与业丕业业业丌丟丐;
    private System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上> 业东东下丘丒丝业专;
    
    // Properties
    private SimpleJSON.且丐上一丝业不专上 System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且丐上一丝业不专上.一丕且丂且专丗丘丂(int 丗丏丅丕丆世丁专丟)
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
        System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上> val_9;
        var val_10;
        var val_14;
        int val_15;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_52;
        }
        
        goto label_44;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_9 = this.丝且与丝丒丟万丁专.GetEnumerator();
        val_10 = this;
        this.与业丕业业业丌丟丐 = val_9;
        this.丗丏丅丕丆世丁专丟 = -3;
        if(val_9 != null)
        {
            goto label_25;
        }
        
        goto label_11;
        label_44:
        this.丗丏丅丕丆世丁专丟 = -4;
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(this.业东东下丘丒丝业专.MoveNext() == false)
        {
            goto label_19;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        goto label_24;
        label_19:
        this.且丆与丗丏三专丅丌();
        val_10 = this;
        val_9 = this.与业丕业业业丌丟丐;
        this.业东东下丘丒丝业专 = 0;
        if(val_9 != null)
        {
            goto label_25;
        }
        
        label_11:
        label_25:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_19 = mem[val_2];
        if((mem[val_2] + 286) == 0)
        {
            goto label_35;
        }
        
        var val_17 = mem[val_2] + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_34:
        if(((mem[val_2] + 176 + 8) + -8) == null)
        {
            goto label_33;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (mem[val_2] + 286))
        {
            goto label_34;
        }
        
        goto label_35;
        label_30:
        this.一世丕丕业且且丅丌();
        val_15 = 0;
        this.与业丕业业业丌丟丐 = 0;
        return (bool)val_15;
        label_24:
        this.丒上七丌业七丟与丐 = this.业东东下丘丒丝业专.Current;
        val_15 = 1;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_33:
        val_19 = val_19 + (((mem[val_2] + 176 + 8)) << 4);
        val_14 = val_19 + 296;
        label_35:
        var val_20 = 0;
        val_20 = val_20 + 1;
        this.业东东下丘丒丝业专 = this.与业丕业业业丌丟丐.Current.丙世丞世丙世业丁且().GetEnumerator();
        goto label_44;
        label_52:
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
    private SimpleJSON.且丐上一丝业不专上 System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current()
    {
        return (SimpleJSON.且丐上一丝业不专上)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new 且丐上一丝业不专上.一丕且丂且专丗丘丂();
        return (System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
    }

}
