using UnityEngine;
private sealed class 丈丆丅丄与万丌世丂.且一丂丙三丛丈丏不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丈丆丅丄与万丌世丂.丞丙万下丘丐丛与丑 丒且丆丘丞丑业丅不;
    private UnityEngine.WWW 丄与丄专丐丈万丂七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丈丆丅丄与万丌世丂.且一丂丙三丛丈丏不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_27;
        int val_32;
        val_27 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_27 = 106015744 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_27 = val_27 + 106015744;
        }
        else
        {
                val_32 = 0;
            return (bool)val_32;
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
