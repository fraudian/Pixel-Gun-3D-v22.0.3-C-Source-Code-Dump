using UnityEngine;
private sealed class 丅丆万丟丐丏丏下丄.丞丅与丑丌丙世丆丙 : IEnumerable<UnityEngine.GameObject>, IEnumerable, IEnumerator<UnityEngine.GameObject>, IEnumerator, IDisposable
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
    
    // Properties
    private UnityEngine.GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丆万丟丐丏丏下丄.丞丅与丑丌丙世丆丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
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
        System.Collections.IEnumerator val_13;
        var val_14;
        int val_15;
        UnityEngine.GameObject val_16;
        var val_17;
        var val_18;
        var val_19;
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
            goto label_51;
        }
        
        val_13 = this.与业丕业业业丌丟丐;
        goto label_4;
        label_1:
        val_14 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丈丆上丅丘世专丑丕 == 0)
        {
            goto label_51;
        }
        
        if(this.丗七丐世业丆丂下丑 == false)
        {
            goto label_11;
        }
        
        if(this.丛业万丗业丝丕不上 != null)
        {
                if((System.String.op_Equality(a:  this.丈丆上丅丘世专丑丕.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_11;
        }
        
        }
        
        val_15 = 1;
        this.丗丏丅丕丆世丁专丟 = val_15;
        this.丒上七丌业七丟与丐 = this.丈丆上丅丘世专丑丕;
        return (bool)val_15;
        label_2:
        val_16 = this.丈丆上丅丘世专丑丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_11:
        val_13 = this;
        this.与业丕业业业丌丟丐 = mem[this.丈丆上丅丘世专丑丕].transform.GetEnumerator();
        label_4:
        this.丗丏丅丕丆世丁专丟 = -3;
        label_31:
        var val_15 = mem[val_5];
        if((mem[val_5] + 286) == 0)
        {
            goto label_19;
        }
        
        var val_13 = mem[val_5] + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_18:
        if(((mem[val_5] + 176 + 8) + -8) == null)
        {
            goto label_17;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (mem[val_5] + 286))
        {
            goto label_18;
        }
        
        goto label_19;
        label_17:
        val_15 = val_15 + (((mem[val_5] + 176 + 8)) << 4);
        val_17 = val_15 + 296;
        label_19:
        if(this.与业丕业业业丌丟丐.MoveNext() == false)
        {
            goto label_20;
        }
        
        var val_19 = mem[val_5];
        if((mem[val_5] + 286) == 0)
        {
            goto label_25;
        }
        
        var val_16 = mem[val_5] + 176;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_24:
        if(((mem[val_5] + 176 + 8) + -8) == null)
        {
            goto label_23;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < (mem[val_5] + 286))
        {
            goto label_24;
        }
        
        goto label_25;
        label_23:
        var val_18 = val_16;
        val_18 = val_18 + 1;
        val_19 = val_19 + val_18;
        val_18 = val_19 + 296;
        label_25:
        val_19 = this.与业丕业业业丌丟丐.Current;
        if(val_19 != null)
        {
                val_19 = 0;
        }
        
        if(this.丛业万丗业丝丕不上 != null)
        {
                if((System.String.op_Equality(a:  val_19.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_31;
        }
        
        }
        
        this.丒上七丌业七丟与丐 = val_19.gameObject;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_15 = 1;
        return (bool)val_15;
        label_20:
        this.一世丕丕业且且丅丌();
        val_15 = 0;
        this.与业丕业业业丌丟丐 = 0;
        return (bool)val_15;
        label_51:
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
        丅丆万丟丐丏丏下丄.丞丅与丑丌丙世丆丙 val_2 = null;
        val_5 = val_2;
        val_2 = new 丅丆万丟丐丏丏下丄.丞丅与丑丌丙世丆丙();
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
