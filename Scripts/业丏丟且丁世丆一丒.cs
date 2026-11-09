using UnityEngine;
private sealed class NetworkStartTable.业丏丟且丁世丆一丒 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public NetworkStartTable 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTable.业丏丟且丁世丆一丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
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
        
        val_2 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_2 = 0;
        this.丝且与丝丒丟万丁专.业上丑丈丑丘东丞丏 = false;
        return (bool)val_2;
        label_2:
        val_2 = 0;
        return (bool)val_2;
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
                NetworkStartTable.业丏丟且丁世丆一丒 val_2 = null;
            val_4 = val_2;
            val_2 = new NetworkStartTable.业丏丟且丁世丆一丒();
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
