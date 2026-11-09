using UnityEngine;
private sealed class InGameGUIPartItem.上丞丟丒丄且世丈七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InGameGUIPartItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameGUIPartItem.上丞丟丒丄且世丈七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UIPanel val_4;
        var val_5;
        var val_6;
        int val_7;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_18;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = null;
        val_5 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
            goto label_7;
        }
        
        goto label_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        val_6 = null;
        val_6 = null;
        if(activeInHierarchy != false)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        label_13:
        val_4 = this.丝且与丝丒丟万丁专.丛丘下丗业丂一且业;
        if(val_4 != 0)
        {
                val_4 = this.丝且与丝丒丟万丁专.丛丘下丗业丂一且业;
            val_4.ResetAndUpdateAnchors();
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
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
