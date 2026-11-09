using UnityEngine;
private sealed class FreePlayThematicSoundsController.丗丗丝丞丑丘三丐丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreePlayThematicSoundsController 丝且与丝丒丟万丁专;
    private MenuBackgroundMusic 丙丈且丗且丅丂丆东;
    private BackgroundMusicController 丌万丝丑丑不丘不三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreePlayThematicSoundsController.丗丗丝丞丑丘三丐丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_18 = 106014952 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_18 = val_18 + 106014952;
        }
        else
        {
                val_18 = 0;
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
