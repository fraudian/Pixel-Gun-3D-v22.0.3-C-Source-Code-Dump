using UnityEngine;
private sealed class Player_move_c.七下丏丒丌业不丅三 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.七下丏丒丌业不丅三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_13;
        var val_14;
        var val_15;
        int val_16;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丂丗丘丁下世丙丐上 == false)
        {
            goto label_11;
        }
        
        val_13 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_13 == 0)
        {
            goto label_11;
        }
        
        val_13 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_3.isCharging == false)
        {
            goto label_11;
        }
        
        val_13 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        if(val_4.chargeLoop == false)
        {
            goto label_11;
        }
        
        val_13 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈();
        val_14 = null;
        val_14 = null;
        if((val_13.IsPlaying(name:  Player_move_c.业丒丘丆丁一丘丝丝)) != true)
        {
                val_15 = null;
            val_13 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈();
            val_15 = null;
            bool val_10 = val_13.Play(animation:  Player_move_c.业丒丘丆丁一丘丝丝);
            if(this.丝且与丝丒丟万丁专.东丗丒丝丐且丞丄丏 != true)
        {
                val_13 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
            this.丝且与丝丒丟万丁专.万丙丘丗丆业丐万世(丆与丈丏丟七丁东丛:  val_13.且且东专三丛专上东(), 丛丝丗不丞丛丕七丏:  true, 与丁万东丌丑下丏丕:  1f, 七丗专上丄丙丝上丁:  false);
        }
        
        }
        
        val_16 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
        label_1:
        val_16 = 0;
        return (bool)val_16;
        label_11:
        val_16 = 0;
        mem2[0] = 0;
        return (bool)val_16;
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
        this = new Player_move_c.七下丏丒丌业不丅三();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
