using UnityEngine;
private sealed class BatteryWatcher.丌丞专丝万丐丛业丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BatteryWatcher 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BatteryWatcher.丌丞专丝万丐丛业丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_24;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_22 = 106044988 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_22 = val_22 + 106044988;
        }
        else
        {
                val_24 = 0;
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
