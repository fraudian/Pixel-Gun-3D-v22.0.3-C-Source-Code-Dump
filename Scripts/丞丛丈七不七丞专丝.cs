using UnityEngine;
private sealed class PetEngine.丞丛丈七不七丞专丝 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rilisoft.PetEngine 丝且与丝丒丟万丁专;
    private System.Action 丘与丆下丆丛丈丘一;
    public System.Action 且丕丈与丈丟丁丐且;
    private System.Threading.CancellationToken 不丒三业下丑不丞业;
    public System.Threading.CancellationToken 丙且丏业丕丞与丛丘;
    private float 丘丁专与丅三三丏丞;
    private int 不丄三丝不七丑丆万;
    private UnityEngine.WaitForSeconds 丞与丁丁丘下与一丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetEngine.丞丛丈七不七丞专丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        UnityEngine.WaitForSeconds val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.丙丒丏三丆业丗东丟(丌七丞丌丑丆丈万不:  2);
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        goto label_6;
        label_3:
        val_8 = 0.丙丒丏三丆业丗东丟(丌七丞丌丑丆丈万不:  2);
        label_4:
        PetInfo val_3 = this.丝且与丝丒丟万丁专.丙丕丞且丕不丘丙丑();
        this.不丄三丝不七丑丆万 = 0;
        this.丞与丁丁丘下与一丑 = 0;
        float val_7 = (float)val_3.DamagePartsCount;
        val_7 = val_8 / val_7;
        this.丘丁专与丅三三丏丞 = val_7;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        label_6:
        label_8:
        if(this.丝且与丝丒丟万丁专.业丒上丟丆上丙一丒() == false)
        {
                return false;
        }
        
        PetInfo val_5 = this.丝且与丝丒丟万丁专.丙丕丞且丕不丘丙丑();
        if(this.不丄三丝不七丑丆万 >= val_5.DamagePartsCount)
        {
                return false;
        }
        
        if((this.不丒三业下丑不丞业 & 1) != 0)
        {
                return false;
        }
        
        if(this.丘与丆下丆丛丈丘一 == null)
        {
                return false;
        }
        
        this.丘与丆下丆丛丈丘一.Invoke();
        int val_8 = this.不丄三丝不七丑丆万;
        val_9 = this.丞与丁丁丘下与一丑;
        val_8 = val_8 + 1;
        this.不丄三丝不七丑丆万 = val_8;
        if(val_9 == null)
        {
                UnityEngine.WaitForSeconds val_6 = null;
            val_9 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  this.丘丁专与丅三三丏丞);
            this.丞与丁丁丘下与一丑 = val_9;
        }
        
        this.丒上七丌业七丟与丐 = val_9;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                PetEngine.丞丛丈七不七丞专丝 val_2 = null;
            val_4 = val_2;
            val_2 = new PetEngine.丞丛丈七不七丞专丝();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丘与丆下丆丛丈丘一 = this.且丕丈与丈丟丁丐且;
        .不丒三业下丑不丞业 = this.丙且丏业丕丞与丛丘;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
