using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丙上丗业丑丗丌丈丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 且丏下一下上丟与丐;
    private System.Action 丅上专七丐丅万不业;
    private UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> 丂丒三上丐下业丟丞;
    private System.Threading.Tasks.TaskCompletionSource<bool> 丞专丂丌丑丄一丛业;
    private System.IDisposable 丗丕丐丟世丛丁丗三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丙上丗业丑丗丌丈丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.IDisposable val_47;
        int val_55;
        val_47 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_47 = 106029348 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_47 = val_47 + 106029348;
        }
        else
        {
                val_55 = 0;
            return (bool)val_55;
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

}
