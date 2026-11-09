using UnityEngine;
private sealed class ItemRewardListView.丒丕丐下丕七丐丈丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ItemRewardListView 丝且与丝丒丟万丁专;
    public int 丌丒丝东丌下丕丁丅;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丛丞丞东丗下丅丛丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ItemRewardListView.丒丕丐下丕七丐丈丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        ScrollViewHelper val_35;
        UIScrollView val_36;
        var val_37;
        System.Collections.Generic.List<ItemRewardView> val_38;
        var val_39;
        var val_40;
        val_35 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_67;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_36 = this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕;
        if(val_36 == 0)
        {
            goto label_67;
        }
        
        this.丛丞丞东丗下丅丛丕 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        val_37 = 0;
        goto label_7;
        label_19:
        if((this.丝且与丝丒丟万丁专.transform.GetChild(index:  0).gameObject.activeSelf) != false)
        {
                this.丛丞丞东丗下丅丛丕.Add(item:  this.丝且与丝丒丟万丁专.transform.GetChild(index:  0).gameObject);
        }
        
        val_37 = 1;
        label_7:
        if(val_37 < this.丝且与丝丒丟万丁专.transform.childCount)
        {
            goto label_19;
        }
        
        List.Enumerator<T> val_12 = this.丛丞丞东丗下丅丛丕.GetEnumerator();
        label_23:
        if((276764976 & 1) == 0)
        {
            goto label_21;
        }
        
        val_14.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_23;
        label_1:
        int val_34 = this.丌丒丝东丌下丕丁丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_34 = val_34 - 1;
        if(val_34 <= 3)
        {
            goto label_24;
        }
        
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.contentPivot = 0;
        List.Enumerator<T> val_16 = this.丛丞丞东丗下丅丛丕.GetEnumerator();
        val_38 = 1152921519068956112;
        label_30:
        if((276764976 & 1) == 0)
        {
            goto label_28;
        }
        
        val_14.丐丏七丌丕丗业且上().SetActive(value:  true);
        goto label_30;
        label_24:
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.contentPivot = 4;
        List.Enumerator<T> val_18 = this.丛丞丞东丗下丅丛丕.GetEnumerator();
        val_38 = 1152921519068956112;
        label_36:
        if((276764976 & 1) == 0)
        {
            goto label_34;
        }
        
        val_14.丐丏七丌丕丗业且上().SetActive(value:  true);
        goto label_36;
        label_21:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_81;
        label_28:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_53;
        }
        
        goto label_39;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.ResetPosition();
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.UpdatePosition();
        goto label_50;
        label_39:
        label_53:
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.ResetPosition();
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.UpdatePosition();
        UnityEngine.Vector3 val_22 = this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.transform.localPosition;
        UnityEngine.Vector3 val_24 = this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.transform.localPosition;
        val_14 = 0;
        this.丝且与丝丒丟万丁专.丅七丗丁丏丄丆丁丕.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector2 val_25 = UnityEngine.Vector2.zero;
        this.丝且与丝丒丟万丁专.丛丘下丗业丂一且业.clipOffset = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        label_50:
        val_36 = this.丝且与丝丒丟万丁专.丑丝丒丛业丌下与七;
        if(val_36 == 0)
        {
            goto label_67;
        }
        
        val_39 = 0;
        val_36 = 0;
        goto label_68;
        label_74:
        ItemRewardView val_27 = this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Item[0];
        int val_29 = ((val_27.<丕丟专丅丟丑下丈七>k__BackingField.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "state_can_collect")) != true) ? (val_39) : (val_36);
        val_39 = 1;
        label_68:
        val_38 = this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄;
        if(val_39 < val_38.Count)
        {
            goto label_74;
        }
        
        val_40 = 0;
        if(val_29 < 5)
        {
                return (bool)val_40;
        }
        
        if(this.丌丒丝东丌下丕丁丅 < 6)
        {
                return (bool)val_40;
        }
        
        val_35 = this.丝且与丝丒丟万丁专.丑丝丒丛业丌下与七;
        val_35.ScrollTo(不七丘丘丒万七丄丒:  this.丝且与丝丒丟万丁专.丁专丈丆丐丙世业丄.Item[val_29].丌丟丄业且三丛丕丄(), 丌与丟丁万丝丞丄丏:  true);
        label_67:
        val_40 = 0;
        return (bool)val_40;
        label_81:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForFixedUpdate();
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_40;
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
