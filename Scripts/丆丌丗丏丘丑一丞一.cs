using UnityEngine;
private sealed class Player_move_c.丆丌丗丏丘丑一丞一 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
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
    public Player_move_c.丆丌丗丏丘丑一丞一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_3;
        int val_4;
        val_3 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_4 = 1;
        this.丒上七丌业七丟与丐 = val_3;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(val_3 == null)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专.丁丑丅丏丒不七上丁 == false)
        {
            goto label_6;
        }
        
        label_17:
        if(this.丝且与丝丒丟万丁专.丝丙七丒且丂丝与丏 == false)
        {
            goto label_16;
        }
        
        val_3 = this.丝且与丝丒丟万丁专.photonView;
        object[] val_2 = new object[2];
        val_2[0] = null;
        val_2[1] = 0;
        val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  21, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        goto label_16;
        label_5:
        if(0 != 0)
        {
            goto label_17;
        }
        
        label_6:
        val_3.丏丞丝上丝丗丁业丅(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0);
        label_16:
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
                Player_move_c.丆丌丗丏丘丑一丞一 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丆丌丗丏丘丑一丞一();
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
