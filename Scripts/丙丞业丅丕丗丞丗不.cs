using UnityEngine;
private sealed class GameModeLowDeviceWarningBanner.丙丞业丅丕丗丞丗不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task 丑专丙下丒丆万丕丄;
    public System.Action 七丐丅专且专七三丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameModeLowDeviceWarningBanner.丙丞业丅丕丗丞丗不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丑专丙下丒丆万丕丄 == null)
        {
            goto label_11;
        }
        
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.丑专丙下丒丆万丕丄);
        val_5 = 1;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丑专丙下丒丆万丕丄.IsCanceled != true)
        {
                if(this.丑专丙下丒丆万丕丄.IsCompleted != false)
        {
                val_5 = this.七丐丅专且专七三丆;
            if(val_5 == null)
        {
                return (bool)val_5;
        }
        
            val_5.Invoke();
        }
        
        }
        
        label_11:
        val_5 = 0;
        return (bool)val_5;
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
