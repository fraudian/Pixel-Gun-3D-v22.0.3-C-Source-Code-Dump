using UnityEngine;
private sealed class TurretController.丟下业万丌丁丒专与 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public TurretController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController.丟下业万丌丁丒专与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TurretController val_5;
        int val_6;
        var val_7;
        var val_8;
        val_5 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_19;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_6 = 1;
        this.丒上七丌业七丟与丐 = val_5;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_7 = null;
        val_7 = null;
        if(val_5 == null)
        {
            goto label_7;
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_8;
        }
        
        label_16:
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_9;
        }
        
        val_8 = null;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_19;
        }
        
        val_5 = val_5.gameObject;
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  val_5);
        goto label_19;
        label_7:
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
            goto label_16;
        }
        
        label_8:
        val_5 = val_5.gameObject;
        UnityEngine.Object.Destroy(obj:  val_5);
        goto label_19;
        label_9:
        val_5 = val_5.transform;
        val_5.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_19:
        val_6 = 0;
        return (bool)val_6;
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
                TurretController.丟下业万丌丁丒专与 val_2 = null;
            val_4 = val_2;
            val_2 = new TurretController.丟下业万丌丁丒专与();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
