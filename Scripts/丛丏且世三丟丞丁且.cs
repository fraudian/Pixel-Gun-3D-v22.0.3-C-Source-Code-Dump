using UnityEngine;
private sealed class PetEngine.丛丏且世三丟丞丁且 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rilisoft.PetEngine 丝且与丝丒丟万丁专;
    private float 丘丌丕一上丛下丙上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetEngine.丛丏且世三丟丞丁且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.PetEngine val_12;
        bool val_13;
        float val_14;
        val_12 = this.丝且与丝丒丟万丁专;
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
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        PetEngine.丆下丕世下专丕七丄 val_1 = new PetEngine.丆下丕世下专丕七丄();
        if(this.丝且与丝丒丟万丁专.不丏丈丆丏丐下上丒 == true)
        {
            goto label_5;
        }
        
        val_13 = true;
        this.丝且与丝丒丟万丁专.不丏丈丆丏丐下上丒 = val_13;
        .不七丞丄丙一一丒丆 = val_13;
        val_14 = val_12.丙丒丏三丆业丗东丟(丌七丞丌丑丆丈万不:  3);
        val_12.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  val_14, 丌专业且丛丏丞丝且:  new System.Action(object:  val_1, method:  System.Void PetEngine.丆下丕世下专丕七丄::上世七且丐万丂丈丂()));
        System.Func<System.Boolean> val_4 = null;
        val_12 = val_4;
        val_4 = new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean PetEngine.丆下丕世下专丕七丄::丙丌丕丆丝世丂与丄());
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitWhile(predicate:  val_4);
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        val_14 = this.丘丌丕一上丛下丙上;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_12 != null)
        {
                val_12.丌七业一丞丈丅万三();
        }
        else
        {
                0.丌七业一丞丈丅万三();
        }
        
        val_14 = 0f;
        if(this.丝且与丝丒丟万丁专.EffectHide != 0)
        {
                val_14 = this.丝且与丝丒丟万丁专.EffectHide.WaitTime;
        }
        
        this.丘丌丕一上丛下丙上 = val_14;
        label_8:
        if(val_14 > 0f)
        {
            goto label_15;
        }
        
        if((val_12.gameObject & 1) == 0)
        {
            goto label_18;
        }
        
        label_5:
        val_13 = 0;
        return (bool)val_13;
        label_15:
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = val_14 - val_8;
        this.丒上七丌业七丟与丐 = 0;
        this.丘丌丕一上丛下丙上 = val_8;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_13 = 1;
        return (bool)val_13;
        label_18:
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  10000f);
        val_14 = val_11.x;
        val_12.transform.position = new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_11.z};
        val_13 = 0;
        this.丝且与丝丒丟万丁专.不丏丈丆丏丐下上丒 = false;
        return (bool)val_13;
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
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new PetEngine.丛丏且世三丟丞丁且();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
