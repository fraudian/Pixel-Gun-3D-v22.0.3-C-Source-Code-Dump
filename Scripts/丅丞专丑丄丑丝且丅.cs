using UnityEngine;
private sealed class GiftBannerWindow.丅丞专丑丄丑丝且丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftBannerWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftBannerWindow.丅丞专丑丄丑丝且丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GiftScroll val_11;
        int val_12;
        int val_13;
        val_11 = this;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_12 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_12;
        }
        
        val_12 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_4 = this.丝且与丝丒丟万丁专.scrollGift.transform.parent.localScale;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        if(( & 1) == 0)
        {
            goto label_11;
        }
        
        val_13 = 3;
        this.丒上七丌业七丟与丐 = 0;
        goto label_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        this.丝且与丝丒丟万丁专.scrollGift.transform.parent.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        this.丝且与丝丒丟万丁专.scrollGift.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        this.丝且与丝丒丟万丁专.scrollGift.Sort(三丅万丒与丑且世业:  false);
        this.丒上七丌业七丟与丐 = 0;
        val_13 = 2;
        label_12:
        this.丗丏丅丕丆世丁专丟 = val_13;
        val_12 = 1;
        return (bool)val_12;
        label_11:
        val_11 = this.丝且与丝丒丟万丁专.scrollGift;
        val_11.Sort(三丅万丒与丑且世业:  true);
        val_12 = 0;
        return (bool)val_12;
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
