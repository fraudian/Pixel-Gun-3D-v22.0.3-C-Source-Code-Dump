using UnityEngine;
private sealed class FriendsController.不丑三丄丒丘业丟丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task 丏丗丏丝丌七三丅丗;
    private string 与丛丑七丂专专丏丕;
    private UnityEngine.WWW 丆丑万业丄与丈丏丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendsController.不丑三丄丒丘业丟丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_19;
        int val_21;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 5)
        {
                var val_19 = 106017440 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_19 = val_19 + 106017440;
        }
        else
        {
                val_21 = 0;
            return (bool)val_21;
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
