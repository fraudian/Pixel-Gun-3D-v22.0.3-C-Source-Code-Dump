using UnityEngine;
private sealed class CoroutineRunner.丟丂专丈上一丈东丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task 东且丘且丟万丘丛丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoroutineRunner.丟丂专丈上一丈东丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.Task val_2;
        System.Threading.Tasks.Task val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        val_2 = this.东且丘且丟万丘丛丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_2 != null)
        {
            goto label_4;
        }
        
        return (bool)val_4;
        label_0:
        val_3 = this.东且丘且丟万丘丛丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        label_4:
        if(val_3.IsCompleted == false)
        {
            goto label_5;
        }
        
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_5:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
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
