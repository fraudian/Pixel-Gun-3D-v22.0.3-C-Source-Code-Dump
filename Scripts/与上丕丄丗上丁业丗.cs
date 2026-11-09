using UnityEngine;
private sealed class 东下丗世丘上丞世丛.与上丕丄丗上丁业丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private float 丐业三专丂世专一专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 东下丗世丘上丞世丛.与上丕丄丗上丁业丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Progress.丙丆丞丆一丏一丁业 val_12;
        int val_13;
        val_12 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_12 = 106032524 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_12 = val_12 + 106032524;
        }
        else
        {
                val_13 = 0;
            return (bool)val_13;
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
