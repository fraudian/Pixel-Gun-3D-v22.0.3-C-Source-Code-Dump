using UnityEngine;
private sealed class GiftScroll.丞下丒专丄且丁丕七 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public GiftScroll 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftScroll.丞下丒专丄且丁丕七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        GiftBannerWindow val_8;
        var val_9;
        int val_10;
        var val_11;
        GiftBannerWindow val_12;
        var val_13;
        bool val_14;
        var val_15;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 3)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            this.丝且与丝丒丟万丁专.scrollView.disableDragIfFits = false;
            this.丝且与丝丒丟万丁专.丂专丗且万七丂三丈(丆专且丕专丗与一丏:  this.丝且与丝丒丟万丁专.丈世与三丒丞丌丂丁, 丐丐七专三且世三七:  false, 万下业业丘业丙丄七:  1, 东世丑世丛丞不专丕:  0);
            val_9 = null;
            val_9 = null;
            val_8 = GiftBannerWindow.丄丘七三上丕世丞业;
            val_8.UpdateSizeScroll();
        }
        
        val_10 = 0;
        return val_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_11 = null;
        val_11 = null;
        val_12 = GiftBannerWindow.丄丘七三上丕世丞业;
        if(val_12 != 0)
        {
            goto label_14;
        }
        
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return val_10;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_13 = null;
        val_13 = null;
        GiftBannerWindow.丄丘七三上丕世丞业.UpdateSizeScroll();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_19;
        }
        
        val_14 = this.丝且与丝丒丟万丁专.丙丙丌丌丈丞不丏丕;
        goto label_20;
        label_14:
        if(this.丝且与丝丒丟万丁专.wrapScript == 0)
        {
                this.丝且与丝丒丟万丁专.wrapScript = this.丝且与丝丒丟万丁专.parentButton.GetComponent<UIWrapContent>();
        }
        
        七与丗不丝丞业一万 val_4 = null;
        val_12 = val_4;
        val_4 = new 七与丗不丝丞业一万();
        this.丝且与丝丒丟万丁专.listButton.Sort(comparer:  val_4);
        val_15 = null;
        val_15 = null;
        GiftBannerWindow.丄丘七三上丕世丞业.UpdateSizeScroll();
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_10 = 1;
        return val_10;
        label_19:
        val_14 = 0;
        label_20:
        val_12 = this.丝且与丝丒丟万丁专.scrollView;
        if(val_12 == null)
        {
            goto label_31;
        }
        
        if(val_14 == 0)
        {
            goto label_32;
        }
        
        label_41:
        val_12.ResetPosition();
        val_12 = this.丝且与丝丒丟万丁专.wrapScript;
        if(val_12 == 0)
        {
            goto label_40;
        }
        
        val_12 = this.丝且与丝丒丟万丁专.scrollView;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.001f);
        if(val_12 != null)
        {
            goto label_40;
        }
        
        goto label_40;
        label_31:
        if(val_14 != 0)
        {
            goto label_41;
        }
        
        label_32:
        val_12.InvalidateBounds();
        label_40:
        val_10 = true;
        this.丝且与丝丒丟万丁专.scrollView.restrictWithinPanel = val_10;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 3;
        return val_10;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new GiftScroll.丞下丒专丄且丁丕七();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
