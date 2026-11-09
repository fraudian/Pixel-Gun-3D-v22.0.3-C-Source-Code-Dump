using UnityEngine;
private sealed class Rocket.丙丅且丁三丝丙丒专 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.丙丅且丁三丝丙丒专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        UnityEngine.Object val_12;
        int val_13;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_14;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专.丞三与丑业业丕丗丞 == false) || (GameConnect.丒上世丑丈丒丒与丕() == false))
        {
            goto label_14;
        }
        
        val_12 = this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不();
        if(val_12 == 0)
        {
            goto label_14;
        }
        
        val_12 = this.丝且与丝丒丟万丁专.下业丑万丟丁与丕不();
        if(val_12 != this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟().丙不丅丕三丂业东丕())
        {
            goto label_14;
        }
        
        val_13 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_11 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟();
        }
        else
        {
                val_11 = 0.上丗丞且且丏丑下丟();
        }
        
        val_12 = this.丝且与丝丒丟万丁专.万一丂丐丄丁上与丟;
        UnityEngine.Vector3 val_10 = val_12.position;
        val_11.三丛丞丏丕丈丁丏丄(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, 七一与丁丕世丘丛专:  this.丝且与丝丒丟万丁专.丟上上丝与丈丞丞上, 与丁丐丈万丏丘丂下:  this.丝且与丝丒丟万丁专.丞丌三丐丞丘且丂三, 专世万丙丐丐七丐丁:  this.丝且与丝丒丟万丁专.丌七丁万业丄丙且三, 三丏下七丄东丆丂丗:  this.丝且与丝丒丟万丁专.一丌丞丘丁且丛丆丒, 丙世万万丒丙丂丒丏:  this.丝且与丝丒丟万丁专.丗世丕丐丑丁丐丟丒, 丆一三东世下丑七世:  this.丝且与丝丒丟万丁专.且丒丏专丈丝丛丙丙, 不世三且一丒丕丘丈:  this.丝且与丝丒丟万丁专.下业世一七丙专丄丂, 东丏丒三且丄上丟丅:  this.丝且与丝丒丟万丁专.不丄丟丟与上万七丆, 丂丞丁不丄丑丕万丐:  this.丝且与丝丒丟万丁专.harpoonMinDistance);
        label_14:
        val_13 = 0;
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
        this = new Rocket.丙丅且丁三丝丙丒专();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
