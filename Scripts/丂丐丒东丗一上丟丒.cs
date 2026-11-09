using UnityEngine;
private sealed class ClanChestInfoView.丂丐丒东丗一上丟丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private UnityEngine.WaitForSeconds 丈上三丆丝丈丗丒丑;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanChestInfoView.丂丐丒东丗一上丟丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        UnityEngine.WaitForSeconds val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_2 = this;
        this.丈上三丆丝丈丗丒丑 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_1:
        val_2 = this;
        val_3 = this.丈上三丆丝丈丗丒丑;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_3 != null)
        {
            goto label_4;
        }
        
        label_3:
        UnityEngine.WaitForSeconds val_1 = null;
        val_3 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.丈上三丆丝丈丗丒丑 = val_3;
        label_4:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = val_3;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
