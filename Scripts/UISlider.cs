using UnityEngine;
public class UISlider : UIProgressBar
{
    // Fields
    private UnityEngine.Transform foreground;
    private float rawValue;
    private UISlider.丟世丆丕丌且七下丂 direction;
    protected bool mInverted;
    
    // Properties
    public bool 东世三丕三业七丑三 { get; }
    public float 丗丗七万与丗三与上 { get; set; }
    public bool 丏丈丒丙丅与丞业丂 { get; set; }
    
    // Methods
    public bool get_isColliderEnabled()
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        if(val_1 != 0)
        {
                if(val_1 != null)
        {
                return val_1.enabled;
        }
        
            return val_1.enabled;
        }
        
        UnityEngine.Collider2D val_3 = this.GetComponent<UnityEngine.Collider2D>();
        if(val_3 == 0)
        {
                return false;
        }
        
        if(val_3 != null)
        {
                return val_3.enabled;
        }
        
        return val_3.enabled;
    }
    public float get_sliderValue()
    {
        return this.value;
    }
    public void set_sliderValue(float 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public bool get_inverted()
    {
        return (bool)((W8 | 2) == 3) ? 1 : 0;
    }
    public void set_inverted(bool 丙业与丙丗丝不丈东)
    {
    
    }
    protected override void 丌上七丕专一东丝丏()
    {
        if(this.direction == 2)
        {
                return;
        }
        
        mem[1152921531133181336] = this.rawValue;
        if(this.foreground != 0)
        {
                mem[1152921531133181328] = this.foreground.GetComponent<UIWidget>();
        }
        
        bool val_4 = this.mInverted;
        this.direction = 2;
        val_4 = (this.direction == 0) ? (val_4) : ((val_4 == true) ? (2 + 1) : 2);
        mem[1152921531133181340] = val_4;
    }
    protected override void 丁业三上丛丐且专东()
    {
        object val_27;
        var val_28;
        下丈业丑世丟丘丅下 val_29;
        一丑下丄丝不丆三三 val_30;
        下丈业丑世丟丘丅下 val_31;
        val_27 = this;
        if(137162752 == 0)
        {
            goto label_11;
        }
        
        UnityEngine.Collider val_2 = GetComponent<UnityEngine.Collider>();
        if(val_2 != 0)
        {
            goto label_7;
        }
        
        UnityEngine.Collider2D val_4 = val_2.GetComponent<UnityEngine.Collider2D>();
        if(val_4 == 0)
        {
            goto label_11;
        }
        
        label_7:
        if(val_4 != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_11:
        val_28 = val_27;
        label_13:
        UIEventListener val_7 = UIEventListener.Get(丝三丁东丈丒世丅业:  this.gameObject);
        val_29 = System.Delegate.Combine(a:  val_7.onPress, b:  new UIEventListener.下丈业丑世丟丘丅下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISlider::丄丙专丂七与丏丕且(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丆丟专丑丁丒丁上丙)));
        if(val_7 == null)
        {
            goto label_15;
        }
        
        if(val_29 != null)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(val_29 == null)
        {
            goto label_19;
        }
        
        label_16:
        if(null != null)
        {
                val_29 = 0;
        }
        
        label_19:
        val_7.onPress = val_29;
        val_30 = System.Delegate.Combine(a:  val_7.onMovedThumb, b:  new UIEventListener.一丑下丄丝不丆三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISlider::丐专丟东丁万丁丒丂(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)));
        if(val_7 == null)
        {
            goto label_21;
        }
        
        if(val_30 != null)
        {
            goto label_22;
        }
        
        goto label_25;
        label_21:
        if(val_30 == null)
        {
            goto label_25;
        }
        
        label_22:
        if(null != null)
        {
                val_30 = 0;
        }
        
        label_25:
        val_7.onMovedThumb = val_30;
        if(val_7 == 0)
        {
                return;
        }
        
        UnityEngine.Collider val_14 = val_7.GetComponent<UnityEngine.Collider>();
        if(val_14 == 0)
        {
                UnityEngine.Collider2D val_16 = val_14.GetComponent<UnityEngine.Collider2D>();
            if(val_16 == 0)
        {
                return;
        }
        
        }
        
        if(val_16 != 0)
        {
                val_30 = val_30.cachedTransform;
            if(val_16 == val_30)
        {
                return;
        }
        
        }
        
        UIEventListener val_22 = UIEventListener.Get(丝三丁东丈丒世丅业:  val_16.gameObject);
        val_31 = System.Delegate.Combine(a:  val_22.onPress, b:  new UIEventListener.下丈业丑世丟丘丅下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISlider::丌丗下丌不丞一丅丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丆丟专丑丁丒丁上丙)));
        if(val_22 == null)
        {
            goto label_46;
        }
        
        if(val_31 != null)
        {
            goto label_47;
        }
        
        goto label_50;
        label_46:
        if(val_31 == null)
        {
            goto label_50;
        }
        
        label_47:
        if(null != null)
        {
                val_31 = 0;
        }
        
        label_50:
        val_22.onPress = val_31;
        val_30 = val_22.onMovedThumb;
        val_27 = System.Delegate.Combine(a:  val_30, b:  new UIEventListener.一丑下丄丝不丆三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISlider::丙丑丈丏与丐丛丁且(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)));
        if(val_22 == null)
        {
            goto label_52;
        }
        
        if(val_27 != null)
        {
            goto label_53;
        }
        
        goto label_56;
        label_52:
        if(val_27 == null)
        {
            goto label_56;
        }
        
        label_53:
        if(null != null)
        {
                val_27 = 0;
        }
        
        label_56:
        val_22.onMovedThumb = val_27;
    }
    protected void 丄丙专丂七与丏丕且(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丆丟专丑丁丒丁上丙)
    {
        var val_8;
        var val_9;
        var val_10;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        mem[1152921531133616304] = UICamera.currentCamera;
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        this.value = this.丂丌丆丝丟丂下丝与(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        if(丆丟专丑丁丒丁上丙 != false)
        {
                val_9 = null;
            val_9 = null;
            bool val_5 = UICamera.丅丒世丆业丑丏丁丈.Add(item:  this.gameObject);
            return;
        }
        
        if(this != null)
        {
                this.Invoke();
        }
        
        val_10 = null;
        val_10 = null;
        bool val_7 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    protected void 丘丙东七丌专丟三不(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        var val_4;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        mem[1152921531133752880] = UICamera.currentCamera;
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        this.value = this.丂丌丆丝丟丂下丝与(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
    }
    protected void 丐专丟东丁万丁丒丂(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        var val_4;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        mem[1152921531133881264] = UICamera.currentCamera;
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        this.value = this.丂丌丆丝丟丂下丝与(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
    }
    protected void 丌丗下丌不丞一丅丗(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丆丟专丑丁丒丁上丙)
    {
        var val_10;
        float val_11;
        var val_12;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        mem[1152921531134017840] = UICamera.currentCamera;
        if(丆丟专丑丁丒丁上丙 != false)
        {
                val_11 = 0f;
            if(丆丟专丑丁丒丁上丙 != 0)
        {
                UnityEngine.Vector2 val_4 = UICamera.lastEventPosition;
            val_11 = this.value - (this.丂丌丆丝丟丂下丝与(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}));
        }
        
            mem[1152921531134017848] = val_11;
            val_12 = null;
            val_12 = null;
            bool val_7 = UICamera.丅丒世丆业丑丏丁丈.Add(item:  this.gameObject);
            return;
        }
        
        if(UICamera.currentCamera != null)
        {
                UICamera.currentCamera.Invoke();
            val_10 = null;
        }
        
        val_10 = null;
        bool val_9 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    protected void 世东丏丛丗三上丄丄(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        var val_4;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        mem[1152921531134154416] = UICamera.currentCamera;
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        float val_3 = this.丂丌丆丝丟丂下丝与(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_3 = S8 + val_3;
        this.value = val_3;
    }
    protected void 丙丑丈丏与丐丛丁且(UnityEngine.GameObject 丝三丁东丈丒世丅业, UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        var val_4;
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        mem[1152921531134282800] = UICamera.currentCamera;
        UnityEngine.Vector2 val_2 = UICamera.lastEventPosition;
        float val_3 = this.丂丌丆丝丟丂下丝与(丅丙丆丕业上下丌丄:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_3 = S8 + val_3;
        this.value = val_3;
    }
    public override void OnPan(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.isColliderEnabled == false)
        {
                return;
        }
        
        this.OnPan(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    private void OnDisable()
    {
        null = null;
        bool val_2 = UICamera.丅丒世丆业丑丏丁丈.Remove(item:  this.gameObject);
    }
    public UISlider()
    {
        this.rawValue = 1f;
        this.direction = 2;
    }

}
