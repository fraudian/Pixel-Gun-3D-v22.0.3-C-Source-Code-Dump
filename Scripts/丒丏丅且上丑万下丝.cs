using UnityEngine;
private sealed class TempItemsController.丒丏丅且上丑万下丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 七且丆丞丌丘下世丑;
    private float 万丟丆东一下丑丆丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TempItemsController.丒丏丅且上丑万下丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.万丟丆东一下丑丆丐 = UnityEngine.Time.realtimeSinceStartup;
        goto label_3;
        label_0:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_2 = val_2 - this.万丟丆东一下丑丆丐;
        if(val_2 < 0)
        {
            goto label_3;
        }
        
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
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
