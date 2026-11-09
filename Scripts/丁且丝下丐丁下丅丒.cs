using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丁且丝下丐丁下丅丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.TaskCompletionSource<bool> 世丅丒丆三下专丘丆;
    private Rilisoft.丐丌丝七下丈丒丅丗.不丄业上万丝丒专丂 丄丌丂东丘丗一万且;
    private float 丘万丆丁丛下丒丞上;
    private System.Action 七一专丕世丟且丂丛;
    private float 丈丂一丏丈丝丌丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丁且丝下丐丁下丅丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<System.Boolean> val_27;
        var val_31;
        val_27 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_31 = 106029272 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_31 = val_31 + 106029272;
        }
        else
        {
                val_31 = 0;
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
