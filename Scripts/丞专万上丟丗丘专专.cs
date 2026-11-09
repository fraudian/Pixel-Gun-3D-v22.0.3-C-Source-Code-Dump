using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.丞专万上丟丗丘专专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private Rilisoft.丐丌丝七下丈丒丅丗.丛丄丁业且世丝丂丅 丄丌丂东丘丗一万且;
    private BannerWindowController 东丂下丈丁丅世丅丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丞专万上丟丗丘专专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        if(this.丗丏丅丕丆世丁专丟 <= 4)
        {
                var val_13 = 106029368 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_13 = val_13 + 106029368;
        }
        else
        {
                val_18 = 0;
            return (bool)val_18;
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
