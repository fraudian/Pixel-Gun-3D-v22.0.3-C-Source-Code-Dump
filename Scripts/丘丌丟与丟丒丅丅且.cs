using UnityEngine;
private sealed class MapVoteController.丘丌丟与丟丒丅丅且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MapVoteController 丝且与丝丒丟万丁专;
    private string 丕丂丐丑丆丞丑七丌;
    private UnityEngine.WWW 丐万下上丛丛业一丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MapVoteController.丘丌丟与丟丒丅丅且(int 丗丏丅丕丆世丁专丟)
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
                var val_18 = 106045656 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_18 = val_18 + 106045656;
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
