using UnityEngine;
private sealed class UIInputFocusAtEnable.丌不丝丞丞世丛世丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UIInputFocusAtEnable 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIInputFocusAtEnable.丌不丝丞丞世丛世丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        UnityEngine.WaitForSecondsRealtime val_4;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._input.isSelected = false;
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._input.isSelected = true;
        goto label_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丗丕专丐丞丞下不丒 = 0;
        label_10:
        if(this.丝且与丝丒丟万丁专._input.isSelected == false)
        {
            goto label_12;
        }
        
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_12:
        val_4 = this.丗丕专丐丞丞下不丒;
        if(val_4 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.WaitForSecondsRealtime(time:  0.3f);
            this.丗丕专丐丞丞下不丒 = val_4;
        }
        
        this.丒上七丌业七丟与丐 = val_4;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_3 = 1;
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
