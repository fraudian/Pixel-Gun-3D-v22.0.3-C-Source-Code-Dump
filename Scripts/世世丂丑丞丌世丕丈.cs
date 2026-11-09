using UnityEngine;
private sealed class OnlineModeController.世世丂丑丞丌世丕丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public OnlineModeController 丝且与丝丒丟万丁专;
    public bool 丂丘下万丈丘丅一丄;
    private PlayerSavedStateListener 丛丁丄不丛丁丝丏一;
    private float 丑丐且业丌丒丁丑三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OnlineModeController.世世丂丑丞丌世丕丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LoadingInAfterGame val_27;
        int val_29;
        val_27 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_27 = 106017056 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_27 = val_27 + 106017056;
        }
        else
        {
                val_29 = 0;
            return (bool);
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
