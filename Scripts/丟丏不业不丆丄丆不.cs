using UnityEngine;
private sealed class 丅丆万丟丐丏丏下丄.丟丏不业不丆丄丆不 : IEnumerable<UnityEngine.GameObject>, IEnumerable, IEnumerator<UnityEngine.GameObject>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private UnityEngine.GameObject 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private UnityEngine.GameObject 丈丆上丅丘世专丑丕;
    public UnityEngine.GameObject 丄不万丒三丝与丛不;
    private string 丛业万丗业丝丕不上;
    public string 专丞万丕丘丗且丘丅;
    private bool 丗七丐世业丆丂下丑;
    public bool 万不下不丟东丒丅丒;
    private System.Collections.IEnumerator 与业丕业业业丌丟丐;
    
    // Properties
    private UnityEngine.GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丆万丟丐丏丏下丄.丟丏不业不丆丄丆不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
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
        UnityEngine.GameObject val_17;
        var val_18;
        UnityEngine.Object val_19;
        var val_20;
        int val_21;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_66;
        }
        
        val_17 = this.丈丆上丅丘世专丑丕;
        label_38:
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_18;
        label_26:
        var val_20 = mem[this.与业丕业业业丌丟丐];
        if((mem[this.与业丕业业业丌丟丐] + 286) == 0)
        {
            goto label_9;
        }
        
        var val_17 = mem[this.与业丕业业业丌丟丐] + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_8:
        if(((mem[this.与业丕业业业丌丟丐] + 176 + 8) + -8) == null)
        {
            goto label_7;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (mem[this.与业丕业业业丌丟丐] + 286))
        {
            goto label_8;
        }
        
        goto label_9;
        label_7:
        var val_19 = val_17;
        val_19 = val_19 + 1;
        val_20 = val_20 + val_19;
        val_18 = val_20 + 296;
        label_9:
        object val_1 = mem[this.与业丕业业业丌丟丐].Current;
        val_19 = 0.gameObject;
        if(val_19 == mem[this.丈丆上丅丘世专丑丕])
        {
            goto label_15;
        }
        
        if(this.丛业万丗业丝丕不上 == null)
        {
            goto label_19;
        }
        
        if((System.String.op_Equality(a:  0.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_18;
        }
        
        goto label_19;
        label_18:
        var val_23 = mem[this.与业丕业业业丌丟丐];
        if((mem[this.与业丕业业业丌丟丐] + 286) == 0)
        {
            goto label_25;
        }
        
        var val_21 = mem[this.与业丕业业业丌丟丐] + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_24:
        if(((mem[this.与业丕业业业丌丟丐] + 176 + 8) + -8) == null)
        {
            goto label_23;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (mem[this.与业丕业业业丌丟丐] + 286))
        {
            goto label_24;
        }
        
        goto label_25;
        label_23:
        val_23 = val_23 + (((mem[this.与业丕业业业丌丟丐] + 176 + 8)) << 4);
        val_20 = val_23 + 296;
        label_25:
        if(mem[this.与业丕业业业丌丟丐].MoveNext() == true)
        {
            goto label_26;
        }
        
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        goto label_35;
        label_1:
        val_17 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = 1152921504848912384;
        if(this.丈丆上丅丘世专丑丕 == 0)
        {
            goto label_66;
        }
        
        UnityEngine.Transform val_11 = null.transform.parent;
        if(val_11 == 0)
        {
            goto label_35;
        }
        
        this.与业丕业业业丌丟丐 = val_11.transform.GetEnumerator();
        goto label_38;
        label_2:
        val_21 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_21;
        label_19:
        val_21 = 1;
        this.丒上七丌业七丟与丐 = val_19;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_15:
        this.一世丕丕业且且丅丌();
        label_35:
        if(this.丗七丐世业丆丂下丑 != false)
        {
                if(this.丛业万丗业丝丕不上 != null)
        {
                if((System.String.op_Equality(a:  this.丈丆上丅丘世专丑丕.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_66;
        }
        
        }
        
            this.丗丏丅丕丆世丁专丟 = 2;
            val_21 = 1;
            this.丒上七丌业七丟与丐 = this.丈丆上丅丘世专丑丕;
            return (bool)val_21;
        }
        
        label_66:
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
        丅丆万丟丐丏丏下丄.丟丏不业不丆丄丆不 val_2 = null;
        val_5 = val_2;
        val_2 = new 丅丆万丟丐丏丏下丄.丟丏不业不丆丄丆不();
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
        mem[56] = this.专丞万丕丘丗且丘丅;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator();
    }

}
