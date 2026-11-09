using UnityEngine;
private sealed class BetterWrapContent.世丌业丌且不七与下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.BetterWrapContent 丝且与丝丒丟万丁专;
    public float 专丂丕丗丗东世丞下;
    public float 七不丞世丁丝业丌专;
    private UIPanel 丁与不丑业丞丐丞丟;
    private bool 丑丝丅丗丈七丁丄且;
    private float 丌与丗丅七丁不丞业;
    private float 丏下业丅且三世专七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BetterWrapContent.世丌业丌且不七与下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UIScrollView val_18;
        int val_19;
        bool val_20;
        float val_21;
        float val_22;
        val_18 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_19 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_19;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UIPanel val_1 = this.丝且与丝丒丟万丁专.下七丅一且丂丒专丕.GetComponent<UIPanel>();
        val_20 = val_18;
        this.丑丝丅丗丈七丁丄且 = true;
        mem[1152921543580969744] = val_1;
        UnityEngine.Vector3 val_3 = val_1.transform.localPosition;
        this.丌与丗丅七丁不丞业 = val_3.x;
        if(val_3.x <= 0f)
        {
            goto label_7;
        }
        
        val_21 = this.专丂丕丗丗东世丞下 + System.Math.Abs(val_3.x);
        goto label_10;
        label_1:
        val_20 = this.丑丝丅丗丈七丁丄且;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_11;
        label_7:
        val_21 = this.专丂丕丗丗东世丞下 - System.Math.Abs(val_3.x);
        label_10:
        this.专丂丕丗丗东世丞下 = val_21;
        this.丏下业丅且三世专七 = 0f;
        label_11:
        if(this.丑丝丅丗丈七丁丄且 != false)
        {
                float val_4 = UnityEngine.Mathf.Lerp(a:  this.丌与丗丅七丁不丞业, b:  this.专丂丕丗丗东世丞下, t:  this.丏下业丅且三世专七);
            UnityEngine.Vector3 val_6 = this.丁与不丑业丞丐丞丟.transform.localPosition;
            UnityEngine.Vector3 val_8 = this.丁与不丑业丞丐丞丟.transform.localPosition;
            float val_9 = UnityEngine.Time.deltaTime;
            val_9 = this.七不丞世丁丝业丌专 / val_9;
            val_9 = this.丏下业丅且三世专七 + val_9;
            this.丏下业丅且三世专七 = val_9;
            this.丝且与丝丒丟万丁专.下七丅一且丂丒专丕.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_11 = this.丁与不丑业丞丐丞丟.clipOffset;
            val_22 = 0f;
            this.丁与不丑业丞丐丞丟.clipOffset = new UnityEngine.Vector2() {x = 0f, y = val_22};
            if(this.丏下业丅且三世专七 >= 1f)
        {
                this.丑丝丅丗丈七丁丄且 = false;
        }
        
            val_19 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_19;
            return (bool)val_19;
        }
        
        UnityEngine.Vector3 val_13 = this.丁与不丑业丞丐丞丟.transform.localPosition;
        UnityEngine.Vector3 val_15 = this.丁与不丑业丞丐丞丟.transform.localPosition;
        this.丝且与丝丒丟万丁专.下七丅一且丂丒专丕.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector2 val_17 = this.丁与不丑业丞丐丞丟.clipOffset;
        val_22 = 0f;
        this.丁与不丑业丞丐丞丟.clipOffset = new UnityEngine.Vector2() {x = 0f, y = val_22};
        val_18 = this.丝且与丝丒丟万丁专.下七丅一且丂丒专丕;
        val_19 = 0;
        this.丝且与丝丒丟万丁专.万丘丂丗世三不丅丕 = 0;
        return (bool)val_19;
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
