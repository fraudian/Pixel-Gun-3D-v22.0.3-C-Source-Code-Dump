using UnityEngine;
private sealed class DamageableObjectHealthUI.七一丟丕三丆丑万丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public DamageableObjectHealthUI 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DamageableObjectHealthUI.七一丟丕三丆丑万丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        object val_4;
        int val_5;
        val_3 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._frame.SetActive(value:  false);
        UnityEngine.WaitForSeconds val_1 = null;
        val_4 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        val_5 = 1;
        goto label_6;
        label_1:
        val_5 = 0;
        goto label_7;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = this.丝且与丝丒丟万丁专.丙丟丄下万丙丗丑万();
        val_5 = 2;
        label_6:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = val_4;
        label_7:
        this.丗丏丅丕丆世丁专丟 = val_5;
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
