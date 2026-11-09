using UnityEngine;
private sealed class GiftHUDItem.业不丌丐业且不七丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftHUDItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftHUDItem.业不丌丐业且不七丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        int val_10;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 3)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.下丝上丒丁业下丈业 != 0)
        {
            goto label_8;
        }
        
        val_7 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = this.丝且与丝丒丟万丁专.下丝上丒丁业下丈业.gameObject;
        val_6.SetActive(value:  true);
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_8:
        this.丝且与丝丒丟万丁专.下丝上丒丁业下丈业.gameObject.SetActive(value:  false);
        label_4:
        val_8 = null;
        val_8 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
            goto label_25;
        }
        
        val_9 = null;
        val_9 = null;
        if(activeSelf == false)
        {
            goto label_25;
        }
        
        val_10 = 2;
        this.丒上七丌业七丟与丐 = 0;
        goto label_26;
        label_25:
        this.丒上七丌业七丟与丐 = 0;
        val_10 = 3;
        label_26:
        this.丗丏丅丕丆世丁专丟 = val_10;
        val_7 = 1;
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
