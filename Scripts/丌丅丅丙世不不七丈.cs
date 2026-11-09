using UnityEngine;
private sealed class GiftScroll.丌丅丅丙世不不七丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftScroll 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftScroll.丌丅丅丙世不不七丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GiftBannerWindow val_4;
        int val_5;
        var val_6;
        var val_7;
        val_4 = this;
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
        
        val_5 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.scrollView.disableDragIfFits = false;
        this.丝且与丝丒丟万丁专.丂专丗且万七丂三丈(丆专且丕专丗与一丏:  this.丝且与丝丒丟万丁专.丈世与三丒丞丌丂丁, 丐丐七专三且世三七:  false, 万下业业丘业丙丄七:  1, 东世丑世丛丞不专丕:  0);
        val_6 = null;
        val_6 = null;
        val_4 = GiftBannerWindow.丄丘七三上丕世丞业;
        val_4.UpdateSizeScroll();
        label_3:
        val_5 = 0;
        return val_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = null;
        val_7 = null;
        GiftBannerWindow.丄丘七三上丕世丞业.UpdateSizeScroll();
        this.丝且与丝丒丟万丁专.scrollView.ResetPosition();
        if(this.丝且与丝丒丟万丁专.wrapScript != 0)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.001f);
        }
        
        val_5 = true;
        this.丝且与丝丒丟万丁专.scrollView.restrictWithinPanel = val_5;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return val_5;
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
