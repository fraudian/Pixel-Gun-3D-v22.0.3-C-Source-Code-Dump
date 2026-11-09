using UnityEngine;
public class UIScrollBar : UISlider
{
    // Fields
    protected float mSize;
    private float mScroll;
    private UIScrollBar.丟世丆丕丌且七下丂 mDir;
    
    // Properties
    public float 世丕丞三一丞世与万 { get; set; }
    public float 丌万业业七专不丏丂 { get; set; }
    
    // Methods
    public float get_scrollValue()
    {
        return this.value;
    }
    public void set_scrollValue(float 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public float get_barSize()
    {
        return (float)this.mSize;
    }
    public void set_barSize(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Behaviour val_10;
        UnityEngine.Object val_11;
        val_10 = this;
        float val_1 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
        if(this.mSize == val_1)
        {
                return;
        }
        
        this.mSize = val_1;
        mem[1152921531124248184] = 1;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        val_11 = 0;
        if(UIProgressBar.current == val_11)
        {
                UIProgressBar.current = val_10;
            val_11 = 0;
            EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  UIProgressBar.current);
            UIProgressBar.current = 0;
        }
        
        val_10 = ???;
        goto typeof(UIScrollBar).__il2cppRuntimeField_198;
    }
    protected override void 丌上七丕专一东丝丏()
    {
        if(this.mDir == 2)
        {
                return;
        }
        
        this.mDir = 2;
        mem[1152921531124364264] = this.mScroll;
        mem[1152921531124364268] = (this.mDir == 0) ? (W9) : ((W9 == 0) ? (2 + 1) : 2);
    }
    protected override void 丁业三上丛丐且专东()
    {
        object val_16;
        UnityEngine.Object val_17;
        下丈业丑世丟丘丅下 val_18;
        val_16 = this;
        this.丁业三上丛丐且专东();
        if(137162752 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = gameObject;
        val_17 = this.gameObject;
        if(val_2 == val_17)
        {
                return;
        }
        
        UnityEngine.Collider val_5 = val_2.GetComponent<UnityEngine.Collider>();
        if(val_5 == 0)
        {
                UnityEngine.Collider2D val_7 = val_5.GetComponent<UnityEngine.Collider2D>();
            if(val_7 == 0)
        {
                return;
        }
        
        }
        
        UIEventListener val_10 = UIEventListener.Get(丝三丁东丈丒世丅业:  val_7.gameObject);
        val_18 = System.Delegate.Combine(a:  val_10.onPress, b:  new UIEventListener.下丈业丑世丟丘丅下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISlider::丌丗下丌不丞一丅丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丆丟专丑丁丒丁上丙)));
        if(val_10 == null)
        {
            goto label_18;
        }
        
        if(val_18 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_18 == null)
        {
            goto label_22;
        }
        
        label_19:
        if(null != null)
        {
                val_18 = 0;
        }
        
        label_22:
        val_10.onPress = val_18;
        val_17 = System.Delegate.Combine(a:  val_10.onMovedThumb, b:  new UIEventListener.一丑下丄丝不丆三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISlider::丙丑丈丏与丐丛丁且(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)));
        if(val_10 == null)
        {
            goto label_24;
        }
        
        if(val_17 != null)
        {
            goto label_25;
        }
        
        goto label_28;
        label_24:
        if(val_17 == null)
        {
            goto label_28;
        }
        
        label_25:
        if(null != null)
        {
                val_17 = 0;
        }
        
        label_28:
        val_10.onMovedThumb = val_17;
        mem[1152921531124531704] = 1;
    }
    protected override float 丕丑丟丘丘丛上丞下(UnityEngine.Vector2 丈丑丑且业下丒丁丞)
    {
        float val_9;
        bool val_10;
        float val_12;
        float val_13;
        bool val_14;
        val_9 = 丈丑丑且业下丒丁丞.y;
        if(137162752 == 0)
        {
                return this.丕丑丟丘丘丛上丞下(丈丑丑且业下丒丁丞:  new UnityEngine.Vector2() {x = 丈丑丑且业下丒丁丞.x, y = val_9});
        }
        
        float val_7 = 0.5f;
        val_7 = (UnityEngine.Mathf.Clamp01(value:  this.mSize)) * val_7;
        float val_8 = 1f;
        val_8 = val_8 - val_7;
        if(W22 > 1)
        {
            goto label_9;
        }
        
        val_10 = static_value_082CF018;
        val_9 = UnityEngine.Mathf.Lerp(a:  mem[137162784], b:  mem[137162808], t:  val_7);
        val_10 = static_value_082CF018;
        float val_4 = UnityEngine.Mathf.Lerp(a:  mem[137162784], b:  mem[137162808], t:  val_8);
        val_12 = val_4 - val_9;
        if(val_12 == 0f)
        {
                return this.value;
        }
        
        val_10 = val_10 | 2;
        if(val_10 != true)
        {
            goto label_16;
        }
        
        val_13 = val_4 - 丈丑丑且业下丒丁丞.x;
        goto label_26;
        label_9:
        float val_5 = UnityEngine.Mathf.Lerp(a:  mem[137162788], b:  mem[137162800], t:  val_7);
        val_14 = static_value_082CF018;
        if(val_14 <= true)
        {
                val_14 = static_value_082CF018;
        }
        
        float val_6 = UnityEngine.Mathf.Lerp(a:  mem[137162824], b:  mem[137162812], t:  val_8);
        val_12 = val_6 - val_5;
        if(val_12 == 0f)
        {
                return this.value;
        }
        
        val_14 = val_14 | 2;
        if(val_14 != true)
        {
            goto label_24;
        }
        
        val_13 = val_6 - val_9;
        goto label_26;
        label_16:
        val_13 = 丈丑丑且业下丒丁丞.x - val_9;
        goto label_26;
        label_24:
        val_13 = val_9 - val_5;
        label_26:
        val_13 = val_13 / val_12;
        return (float)val_13;
    }
    public override void ForceUpdate()
    {
        float val_14;
        float val_15;
        if(137162752 != 0)
        {
                mem[1152921531124808824] = 0;
            float val_14 = 0.5f;
            float val_3 = (UnityEngine.Mathf.Clamp01(value:  this.mSize)) * val_14;
            float val_15 = this.value;
            val_14 = 1f - val_3;
            float val_5 = UnityEngine.Mathf.Lerp(a:  val_3, b:  val_14, t:  val_15);
            val_5 = 1f - (val_3 + val_5);
            val_15 = 1f - (val_5 - val_3);
        }
        else
        {
                this.ForceUpdate();
            return;
        }
        
        val_14 = 0f;
        val_15 = 0f;
        drawRegion = new UnityEngine.Vector4() {x = val_14, y = 0f, z = val_15, w = 0f};
        if(137162752 == 0)
        {
                return;
        }
        
        float val_10 = UnityEngine.Mathf.Lerp(a:  val_14, b:  val_15, t:  0.5f);
        float val_11 = UnityEngine.Mathf.Lerp(a:  0f, b:  0f, t:  0.5f);
        val_14 = 0f;
        val_15 = 0f;
        UnityEngine.Vector3 val_13 = cachedTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_14, y = 0f, z = val_15});
        this.三上丑下丝丒三丑三(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
    }
    public UIScrollBar()
    {
        this.mSize = 1f;
        this.mDir = 2;
        mem[1152921531124924960] = 1065353216;
        val_1 = new UIProgressBar();
    }

}
