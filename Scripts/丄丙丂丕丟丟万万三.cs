using UnityEngine;
private sealed class Gravitan.丄丙丂丕丟丟万万三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Gravitan 丝且与丝丒丟万丁专;
    public float 丕丕世且下一与丝与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Gravitan.丄丙丂丕丟丟万万三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        Gravitan val_3;
        bool val_4;
        var val_5;
        val_2 = this;
        val_3 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = true;
        this.丝且与丝丒丟万丁专.丏万丗世丛丄丘与一 = val_4;
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丒上七丌业七丟与丐 = val_3;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 != null)
        {
                this.丝且与丝丒丟万丁专.丏万丗世丛丄丘与一 = false;
        }
        else
        {
                mem[48] = 0;
        }
        
        if((this.丝且与丝丒丟万丁专.instaJump != false) && (this.丝且与丝丒丟万丁专.与丘丐丏一一三东丂 != false))
        {
                val_5 = null;
            val_5 = null;
            val_2 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_2 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_4 = 0;
            mem2[0] = this.丝且与丝丒丟万丁专.gravitation;
            mem2[0] = ???;
            mem2[0] = val_3;
            return (bool)val_4;
        }
        
        label_8:
        val_4 = 0;
        return (bool)val_4;
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

}
