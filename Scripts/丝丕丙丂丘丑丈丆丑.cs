using UnityEngine;
private sealed class 丅丆万丟丐丏丏下丄.丝丕丙丂丘丑丈丆丑 : IEnumerable<UnityEngine.GameObject>, IEnumerable, IEnumerator<UnityEngine.GameObject>, IEnumerator, IDisposable
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
    private UnityEngine.Transform 上业专专业业丆业与;
    
    // Properties
    private UnityEngine.GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅丆万丟丐丏丏下丄.丝丕丙丂丘丑丈丆丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_11;
        int val_12;
        UnityEngine.Transform val_13;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        val_11 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丈丆上丅丘世专丑丕 == 0)
        {
            goto label_6;
        }
        
        if(this.丗七丐世业丆丂下丑 == false)
        {
            goto label_10;
        }
        
        if(this.丛业万丗业丝丕不上 != null)
        {
                if((System.String.op_Equality(a:  this.丈丆上丅丘世专丑丕.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_10;
        }
        
        }
        
        val_12 = 1;
        this.丗丏丅丕丆世丁专丟 = val_12;
        this.丒上七丌业七丟与丐 = this.丈丆上丅丘世专丑丕;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_18;
        label_2:
        val_11 = this.丈丆上丅丘世专丑丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        val_13 = mem[this.丈丆上丅丘世专丑丕].transform.parent;
        this.上业专专业业丆业与 = val_13;
        goto label_15;
        label_24:
        if(this.丛业万丗业丝丕不上 != null)
        {
                if((System.String.op_Equality(a:  this.上业专专业业丆业与.name, b:  this.丛业万丗业丝丕不上)) == false)
        {
            goto label_18;
        }
        
        }
        
        this.丒上七丌业七丟与丐 = this.上业专专业业丆业与.gameObject;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_12 = 1;
        return (bool)val_12;
        label_18:
        val_13 = mem[this.上业专专业业丆业与].parent;
        mem2[0] = val_13;
        label_15:
        if(val_13 != 0)
        {
            goto label_24;
        }
        
        label_6:
        val_12 = 0;
        return (bool)val_12;
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
        丅丆万丟丐丏丏下丄.丝丕丙丂丘丑丈丆丑 val_2 = null;
        val_5 = val_2;
        val_2 = new 丅丆万丟丐丏丏下丄.丝丕丙丂丘丑丈丆丑();
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
