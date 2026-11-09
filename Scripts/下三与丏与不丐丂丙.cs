using UnityEngine;
private sealed class Rocket.下三与丏与不丐丂丙 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.下三与丏与不丐丂丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rocket val_6;
        int val_7;
        RocketSettings val_8;
        val_6 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_20;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_6 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_7 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(this.丝且与丝丒丟万丁专.下丄丈丑丙丕世丆丂 == false)
        {
            goto label_20;
        }
        
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_7;
        }
        
        val_6.一丑丝丛丘下上丈三(丁丙丈上一丘下丘丆:  true);
        val_8 = val_6;
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 == 0)
        {
            goto label_13;
        }
        
        this.丝且与丝丒丟万丁专 + 40.丅丆万丙丕丕丞丁丁().enabled = false;
        goto label_13;
        label_7:
        val_8 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        label_13:
        this.丝且与丝丒丟万丁专.万丂一万丙丌不丘一 = true;
        val_6 = mem[this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上];
        if(val_6 != 0)
        {
                val_6 = mem[mem[this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上] + 144];
            val_6 = mem[this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上] + 144;
            if(val_6 != 0)
        {
                val_6 = mem[mem[this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上] + 144];
            val_6 = mem[this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上] + 144;
            val_6.enabled = true;
        }
        
        }
        
        label_20:
        val_7 = 0;
        return (bool)val_7;
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
                Rocket.下三与丏与不丐丂丙 val_2 = null;
            val_4 = val_2;
            val_2 = new Rocket.下三与丏与不丐丂丙();
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
