using UnityEngine;
private sealed class NewsLobbyController.丄丌丞且丅丗不上三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.NewsLobbyController 丝且与丝丒丟万丁专;
    public string 专丞上下一丙一丆丕;
    public int 一业东下丝丛七丂丝;
    private UnityEngine.BoxCollider 丌丂下丕丂与下三一;
    private string 丛丈东丌不下丛丝丄;
    private UnityEngine.WWW 丆与丟丅丈世丑丌与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NewsLobbyController.丄丌丞且丅丗不上三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_65;
        var val_71;
        val_65 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_65 = 106029480 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_65 = val_65 + 106029480;
        }
        else
        {
                val_71 = 0;
            return (bool)val_71;
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
