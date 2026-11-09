using UnityEngine;
private sealed class 且丐上一丝业不专上.一丕丘丅三丌丌丙丘 : IEnumerable<SimpleJSON.且丐上一丝业不专上>, IEnumerable, IEnumerator<SimpleJSON.且丐上一丝业不专上>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private SimpleJSON.且丐上一丝业不专上 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    
    // Properties
    private SimpleJSON.且丐上一丝业不专上 System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且丐上一丝业不专上.一丕丘丅三丌丌丙丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        return false;
    }
    private SimpleJSON.且丐上一丝业不专上 System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current()
    {
        return (SimpleJSON.且丐上一丝业不专上)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上>)this;
        }
        
        }
        
        且丐上一丝业不专上.一丕丘丅三丌丌丙丘 val_2 = null;
        this = val_2;
        val_2 = new 且丐上一丝业不专上.一丕丘丅三丌丌丙丘();
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        return (System.Collections.Generic.IEnumerator<SimpleJSON.且丐上一丝业不专上>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
    }

}
