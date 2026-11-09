using UnityEngine;
private sealed class PetEngine.丛丛丌丏丑丕东丂世 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rilisoft.PetEngine 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetEngine.丛丛丌丏丑丕东丂世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        bool val_14;
        UnityEngine.GameObject val_15;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = true;
        this.丝且与丝丒丟万丁专.丌三七丙七丑万且丈 = val_14;
        UnityEngine.ResourceRequest val_1 = UnityEngine.Resources.LoadAsync<UnityEngine.GameObject>(path:  "Pets/pet_buf");
        this.丅丒丑丄丞丑下丈丕 = val_1;
        this.丒上七丌业七丟与丐 = val_1;
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丌三七丙七丑万且丈 = false;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                UnityEngine.Object val_3 = this.丅丒丑丄丞丑下丈丕.asset;
            if(val_3 != null)
        {
                var val_4 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_15);
            this.丝且与丝丒丟万丁专.丘丐丅丕丛七三丙丕 = val_5;
            val_5.transform.parent = this.丝且与丝丒丟万丁专.七丈丁万丛万业丈与;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.丝且与丝丒丟万丁专.丘丐丅丕丛七三丙丕.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            this.丝且与丝丒丟万丁专.丘丐丅丕丛七三丙丕.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_13 = this.丝且与丝丒丟万丁专.丘丐丅丕丛七三丙丕.transform;
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            val_13.rotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
        }
        
        label_7:
        val_14 = 0;
        return (bool)val_14;
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
        this = new PetEngine.丛丛丌丏丑丕东丂世();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
