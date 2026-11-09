using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丂世丆丈丐丟丐丏不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 且丏下一下上丟与丐;
    private Rilisoft.丐丌丝七下丈丒丅丗.上丏三丌丂丙丅且丘 丄丌丂东丘丗一万且;
    public bool 与下丛丂丒丘丛三丆;
    public bool 丙丛丐东与丒且丂上;
    private System.Action 丅上专七丐丅万不业;
    private UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> 丂丒三上丐下业丟丞;
    private System.Threading.Tasks.TaskCompletionSource<bool> 丗丘且不丈丕专世丁;
    private System.Threading.Tasks.TaskCompletionSource<bool> 与下丂丐世三下丛世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丂世丆丈丐丟丐丏不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_47;
        int val_54;
        val_47 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 5)
        {
                var val_47 = 106029288 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_47 = val_47 + 106029288;
        }
        else
        {
                val_54 = 0;
            return (bool)val_54;
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
