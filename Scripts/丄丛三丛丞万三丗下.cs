using UnityEngine;
private sealed class NetworkStartTableNGUIController.丄丛三丛丞万三丗下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    public float 丕丕世且下一与丝与;
    public bool 丈丅三丈丗丐下一丄;
    private 丏与丌丐东七丈丑丕 丐丟丄丁丆丙丄一丒;
    private bool 丅丙丘三东丕七丒丞;
    private int 丈东丌丒且七业与丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.丄丛三丛丞万三丗下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_91;
        var val_94;
        val_91 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_91 = 106025900 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_91 = val_91 + 106025900;
        }
        else
        {
                val_94 = 0;
            return (bool)val_94;
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
