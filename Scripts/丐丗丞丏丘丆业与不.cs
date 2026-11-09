using UnityEngine;
private sealed class ZombieCreator.丐丗丞丏丘丆业与不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Action 丌专业且丛丏丞丝且;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ZombieCreator.丐丗丞丏丘丆业与不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        InGameGUI val_19;
        int val_25;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 <= 7)
        {
                var val_19 = 106022008 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_19 = val_19 + 106022008;
        }
        else
        {
                val_25 = 0;
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
