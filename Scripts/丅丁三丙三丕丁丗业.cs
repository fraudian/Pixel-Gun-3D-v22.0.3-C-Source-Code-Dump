using UnityEngine;
private sealed class InfoWindowController.丅丁三丙三丕丁丗业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 业东且万丄丈业上丝;
    public InfoWindowController.不丌丅丗丁丟丅丐一 丛丄丌三丁丝丈且七;
    public InfoWindowController 丝且与丝丒丟万丁专;
    private bool 七丂一丒丈丝业丆丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InfoWindowController.丅丁三丙三丕丁丗业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        int val_11;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_10 = 106046628 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_10 = val_10 + 106046628;
        }
        else
        {
                val_11 = 0;
            return (bool)val_11;
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
