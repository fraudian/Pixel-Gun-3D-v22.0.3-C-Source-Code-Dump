using UnityEngine;
private sealed class CoroutineRunner.丒不专业上三丑丌丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.IEnumerator 丈不不丁丆世丑专上;
    public System.Threading.Tasks.TaskCompletionSource<bool> 世丅丒丆三下专丘丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoroutineRunner.丒不专业上三丑丌丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<System.Boolean> val_3;
        int val_6;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        var val_5 = 0;
        val_5 = val_5 + 1;
        if(this.丈不不丁丆世丑专上.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        goto label_12;
        label_7:
        val_3 = this.世丅丒丆三下专丘丆;
        val_3.SetResult(result:  true);
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_12:
        this.丒上七丌业七丟与丐 = this.丈不不丁丆世丑专上.Current;
        val_6 = 1;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
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
