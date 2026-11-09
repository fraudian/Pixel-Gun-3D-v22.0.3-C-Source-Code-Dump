using UnityEngine;
private sealed class FreePlayThematicSoundsController.丌丄丌丄不丅丄丆丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreePlayThematicSoundsController 丝且与丝丒丟万丁专;
    public string 七不丐下丟专业万丅;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    private BackgroundMusicController 丌万丝丑丑不丘不三;
    private MenuBackgroundMusic 且丞丘丐丏与丈丕丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreePlayThematicSoundsController.丌丄丌丄不丅丄丆丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_36;
        int val_38;
        val_36 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_34 = 106014936 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_34 = val_34 + 106014936;
        }
        else
        {
                val_38 = 0;
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
