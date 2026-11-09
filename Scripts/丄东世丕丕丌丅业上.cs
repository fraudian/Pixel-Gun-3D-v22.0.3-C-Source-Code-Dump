using UnityEngine;
private sealed class Player_move_c.丄东世丕丕丌丅业上 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 不丕且丐丑丝丅不丙;
    public float 丟不丕三丒丆丛丅七;
    public Player_move_c 丝且与丝丒丟万丁专;
    private System.Threading.CancellationToken 不丒三业下丑不丞业;
    public System.Threading.CancellationToken 丙且丏业丕丞与丛丘;
    private float 丈专下与丛业下下业;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丄东世丕丕丌丅业上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_17;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_17 = 106024416 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_17 = val_17 + 106024416;
        }
        else
        {
                val_17 = 0;
            return (bool)val_17;
        }
    
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
                Player_move_c.丄东世丕丕丌丅业上 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丄东世丕丕丌丅业上();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .不丒三业下丑不丞业 = this.丙且丏业丕丞与丛丘;
        .不丕且丐丑丝丅不丙 = this.丟不丕三丒丆丛丅七;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
