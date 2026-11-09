using UnityEngine;
private sealed class CoroutineRunner.丛丂与丛丑上七丝丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 业丗七丕万万不丈丗;
    public System.Action 一丏丘业丅丈东东丄;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoroutineRunner.丛丂与丛丑上七丝丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        int val_2;
        val_1 = this.丗丏丅丕丆世丁专丟;
        if(val_1 == 1)
        {
            goto label_0;
        }
        
        if(val_1 != 0)
        {
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_2;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_1 = this.丙不丅丌丗上丂丕一 + 1;
        this.丙不丅丌丗上丂丕一 = val_1;
        label_2:
        if(val_1 < this.业丗七丕万万不丈丗)
        {
                val_2 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_2;
            return (bool)val_2;
        }
        
        if(this.一丏丘业丅丈东东丄 != null)
        {
                this.一丏丘业丅丈东东丄.Invoke();
            val_2 = 0;
            return (bool)val_2;
        }
        
        label_5:
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

}
