using UnityEngine;
private sealed class FriendsController.丟丒丒丝丏下与下丛 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private float 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public FriendsController 丝且与丝丒丟万丁专;
    
    // Properties
    private float System.Collections.Generic.IEnumerator<System.Single>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendsController.丟丒丒丝丏下与下丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FriendsController val_31;
        int val_34;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_31 = 106017480 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_31 = this.丝且与丝丒丟万丁专;
            val_31 = val_31 + 106017480;
        }
        else
        {
                val_34 = 0;
            return (bool);
        }
    
    }
    private float System.Collections.Generic.IEnumerator<System.Single>.get_Current()
    {
        return (float)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Single>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new FriendsController.丟丒丒丝丏下与下丛();
        return (System.Collections.Generic.IEnumerator<System.Single>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator();
    }

}
