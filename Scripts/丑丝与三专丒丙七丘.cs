using UnityEngine;
private sealed class Player_move_c.丑丝与三专丒丙七丘 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丑丝与三专丒丙七丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_7;
        int val_8;
        val_7 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_7 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        var val_8 = 0;
        val_8 = val_8 + 1;
        goto label_13;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_13:
        System.Collections.IEnumerator val_5 = val_7.一丞上丐丈丘丌丄丈(丕丕世且下一与丝与:  0.5f).GetEnumerator();
        if(val_7 != null)
        {
                UnityEngine.Coroutine val_6 = val_7.StartCoroutine(routine:  val_5);
        }
        else
        {
                UnityEngine.Coroutine val_7 = 0.StartCoroutine(routine:  val_5);
        }
        
        val_8 = 0;
        this.丝且与丝丒丟万丁专.专丕丂丒丞且一丕上 = false;
        return (bool)val_8;
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
                Player_move_c.丑丝与三专丒丙七丘 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丑丝与三专丒丙七丘();
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
