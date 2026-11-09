using UnityEngine;
public class UIButtonColor : UIWidgetContainer
{
    // Fields
    public UnityEngine.GameObject tweenTarget;
    public UnityEngine.Color hover;
    public UnityEngine.Color pressed;
    public UnityEngine.Color disabledColor;
    public float duration;
    protected UnityEngine.Color 丏七丒丈不丁丏丙业;
    protected UnityEngine.Color 与世丐下丘丑丈不且;
    protected bool 丕丞且丐丙万丆业丟;
    protected UIWidget 丆不下丄丄且丞一丈;
    protected UIButtonColor.丙丟与丐三丐万万丆 不丙丄丒丁万丙丆七;
    
    // Properties
    public UIButtonColor.丙丟与丐三丐万万丆 丏业丟一东丂东丘丛 { get; set; }
    public UnityEngine.Color 丑丙丝丆三七三丛丛 { get; set; }
    public virtual bool 丆丛丆丞下丅丂且丝 { get; set; }
    
    // Methods
    public UIButtonColor.丙丟与丐三丐万万丆 get_state()
    {
        return (丙丟与丐三丐万万丆)this.不丙丄丒丁万丙丆七;
    }
    public void set_state(UIButtonColor.丙丟与丐三丐万万丆 丙业与丙丗丝不丈东)
    {
        goto typeof(UIButtonColor).__il2cppRuntimeField_1F8;
    }
    public UnityEngine.Color get_defaultColor()
    {
        if(this.丕丞且丐丙万丆业丟 == true)
        {
                return new UnityEngine.Color() {r = this.与世丐下丘丑丈不且};
        }
        
        return new UnityEngine.Color() {r = this.与世丐下丘丑丈不且};
    }
    public void set_defaultColor(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.与世丐下丘丑丈不且 = 丙业与丙丗丝不丈东;
        mem[1152921531070585944] = 丙业与丙丗丝不丈东.g;
        mem[1152921531070585948] = 丙业与丙丗丝不丈东.b;
        mem[1152921531070585952] = 丙业与丙丗丝不丈东.a;
        this.不丙丄丒丁万丙丆七 = 3;
        goto typeof(UIButtonColor).__il2cppRuntimeField_1F8;
    }
    public void LogIsEnabled()
    {
        UnityEngine.Debug.LogError(message:  "isEnabled: "("isEnabled: ") + 0.ToString());
    }
    public virtual bool get_isEnabled()
    {
        return this.enabled;
    }
    public virtual void set_isEnabled(bool 丙业与丙丗丝不丈东)
    {
        this.enabled = 丙业与丙丗丝不丈东;
    }
    public void ResetDefaultColor()
    {
        this.defaultColor = new UnityEngine.Color() {r = this.丏七丒丈不丁丏丙业};
    }
    public void CacheDefaultColor()
    {
        if(this.丕丞且丐丙万丆业丟 == false)
        {
            goto typeof(UIButtonColor).__il2cppRuntimeField_188;
        }
    
    }
    private void Start()
    {
        if((this & 1) == 0)
        {
            goto typeof(UIButtonColor).__il2cppRuntimeField_1F8;
        }
    
    }
    protected virtual void 丅丒丐且丘丝丝丄且()
    {
        UIWidget val_18;
        var val_19;
        this.丕丞且丐丙万丆业丟 = true;
        if(this.tweenTarget == 0)
        {
                if(UnityEngine.Application.isPlaying != true)
        {
                this.tweenTarget = this.gameObject;
        }
        
        }
        
        if(this.tweenTarget != 0)
        {
                val_18 = this.tweenTarget.GetComponent<UIWidget>();
            val_19 = this;
            this.丆不下丄丄且丞一丈 = val_18;
        }
        else
        {
                val_19 = this;
            val_18 = this.丆不下丄丄且丞一丈;
        }
        
        if(val_18 == 0)
        {
            goto label_12;
        }
        
        UnityEngine.Color val_7 = this.丆不下丄丄且丞一丈.color;
        label_31:
        this.与世丐下丘丑丈不且 = val_7;
        mem[1152921531071444792] = val_7.g;
        mem[1152921531071444796] = val_7.b;
        mem[1152921531071444800] = val_7.a;
        this.丏七丒丈不丁丏丙业 = val_7;
        mem[1152921531071444776] = val_7.g;
        mem[1152921531071444780] = val_7.b;
        mem[1152921531071444784] = val_7.a;
        return;
        label_12:
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        UnityEngine.Renderer val_9 = this.tweenTarget.GetComponent<UnityEngine.Renderer>();
        if(val_9 == 0)
        {
            goto label_21;
        }
        
        bool val_11 = UnityEngine.Application.isPlaying;
        if(val_9 == null)
        {
            goto label_22;
        }
        
        if(val_11 == false)
        {
            goto label_23;
        }
        
        label_32:
        if(val_9.material != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        UnityEngine.Color val_13 = 0.color;
        goto label_31;
        label_21:
        UnityEngine.Light val_14 = this.tweenTarget.GetComponent<UnityEngine.Light>();
        if(val_14 == 0)
        {
            goto label_29;
        }
        
        UnityEngine.Color val_16 = val_14.color;
        goto label_31;
        label_29:
        this.tweenTarget = 0;
        this.丕丞且丐丙万丆业丟 = false;
        return;
        label_22:
        if(val_11 == true)
        {
            goto label_32;
        }
        
        label_23:
        if(val_9.sharedMaterial != null)
        {
            goto label_33;
        }
        
        goto label_34;
    }
    protected virtual void OnEnable()
    {
        var val_15;
        var val_16;
        丞上且下专丞东专世 val_17;
        UnityEngine.Object val_18;
        var val_20;
        UnityEngine.Object val_21;
        var val_22;
        val_15 = this;
        if(this.丕丞且丐丙万丆业丟 != false)
        {
                bool val_3 = UICamera.IsHighlighted(丝三丁东丈丒世丅业:  this.gameObject);
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = UICamera.currentTouch;
        if(val_17 == null)
        {
                return;
        }
        
        val_17 = UICamera.currentTouch;
        if(val_17 != null)
        {
                val_18 = this.gameObject;
            if(UICamera.currentTouch.万东丂丒且丅丛丑丕 == val_18)
        {
            
        }
        else
        {
                val_20 = null;
            val_20 = null;
            val_21 = this.gameObject;
            if(UICamera.currentTouch.上丞丕专丈业丁世专 != val_21)
        {
                return;
        }
        
        }
        
            val_15 = ???;
            val_22 = ???;
        }
    
    }
    protected virtual void OnDisable()
    {
        if(this.丕丞且丐丙万丆业丟 == false)
        {
                return;
        }
        
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        TweenColor val_2 = this.tweenTarget.GetComponent<TweenColor>();
        if(val_2 == 0)
        {
                return;
        }
        
        if(val_2 != null)
        {
                val_2.value = new UnityEngine.Color() {r = this.与世丐下丘丑丈不且, g = V10.16B, b = V9.16B, a = V8.16B};
        }
        else
        {
                val_2.value = new UnityEngine.Color() {r = this.与世丐下丘丑丈不且, g = V10.16B, b = V9.16B, a = V8.16B};
        }
        
        val_2.enabled = false;
    }
    protected virtual void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        bool val_8 = 丟丆丕且丆丈丂丌丘;
        if((this & 1) == 0)
        {
                return;
        }
        
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        bool val_2 = val_8;
        val_8 = ???;
        goto typeof(UIButtonColor).__il2cppRuntimeField_1F8;
    }
    protected virtual void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        var val_10;
        UnityEngine.GameObject val_11;
        var val_13;
        UnityEngine.Object val_14;
        if((this & 1) == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(UICamera.currentTouch == null)
        {
                return;
        }
        
        val_11 = this.tweenTarget;
        if(val_11 == 0)
        {
                return;
        }
        
        if(丆丟专丑丁丒丁上丙 != false)
        {
            
        }
        else
        {
                val_13 = null;
            val_13 = null;
            val_14 = this.gameObject;
            if(UICamera.currentTouch.上丞丕专丈业丁世专 == val_14)
        {
                if(UICamera.currentScheme == 2)
        {
            
        }
        else
        {
                if(UICamera.currentScheme == 0)
        {
                val_14 = this.gameObject;
            if(UICamera.hoveredObject != val_14)
        {
            
        }
        
        }
        
        }
        
        }
        
        }
    
    }
    protected virtual void 专丌丟下上东丞不丙()
    {
        var val_6 = this;
        if((val_6 & 1) == 0)
        {
                return;
        }
        
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        val_6 = ???;
        goto typeof(UIButtonColor).__il2cppRuntimeField_1F8;
    }
    protected virtual void 世丆丕丌丒下丆万上()
    {
        var val_6 = this;
        if((val_6 & 1) == 0)
        {
                return;
        }
        
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        val_6 = ???;
        goto typeof(UIButtonColor).__il2cppRuntimeField_1F8;
    }
    public virtual void SetState(UIButtonColor.丙丟与丐三丐万万丆 丏业丟一东丂东丘丛, bool 丌丝丌丁下丐丞丆一)
    {
        if(this.丕丞且丐丙万丆业丟 != true)
        {
                this.丕丞且丐丙万丆业丟 = true;
        }
        
        if(this.不丙丄丒丁万丙丆七 == 丏业丟一东丂东丘丛)
        {
                return;
        }
        
        this.不丙丄丒丁万丙丆七 = 丏业丟一东丂东丘丛;
        this.UpdateColor(丌丝丌丁下丐丞丆一:  丌丝丌丁下丐丞丆一);
    }
    public void UpdateColor(bool 丌丝丌丁下丐丞丆一)
    {
        UnityEngine.GameObject val_4;
        if(this.tweenTarget == 0)
        {
                return;
        }
        
        if(this.不丙丄丒丁万丙丆七 == 3)
        {
            goto label_4;
        }
        
        if(this.不丙丄丒丁万丙丆七 == 2)
        {
            goto label_5;
        }
        
        if(this.不丙丄丒丁万丙丆七 != 1)
        {
            goto label_6;
        }
        
        val_4 = this.tweenTarget;
        goto label_9;
        label_4:
        val_4 = this.tweenTarget;
        goto label_9;
        label_5:
        val_4 = this.tweenTarget;
        goto label_9;
        label_6:
        val_4 = this.tweenTarget;
        label_9:
        TweenColor val_2 = TweenColor.Begin(丝三丁东丈丒世丅业:  val_4, 与丈业丛丝丒丙一丏:  this.duration, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.与世丐下丘丑丈不且});
        if(丌丝丌丁下丐丞丆一 == false)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        if(val_2 != null)
        {
                val_2.value = new UnityEngine.Color() {r = val_2.to, g = V10.16B, b = V9.16B, a = V8.16B};
        }
        else
        {
                0.value = new UnityEngine.Color() {r = val_2.to, g = V10.16B, b = V9.16B, a = V8.16B};
        }
        
        val_2.enabled = false;
    }
    public UIButtonColor()
    {
        this.hover = 0;
        mem[1152921531072703604] = 0;
        mem[1152921531072703612] = 0;
        this.pressed = 0;
        mem[1152921531072703620] = 0;
        mem[1152921531072703628] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.grey;
        this.disabledColor = val_1;
        mem[1152921531072703636] = val_1.g;
        mem[1152921531072703640] = val_1.b;
        mem[1152921531072703644] = val_1.a;
        this.duration = 0.2f;
    }

}
