using UnityEngine;
public class UIProgressBar : UIWidgetContainer
{
    // Fields
    public static UIProgressBar current;
    public UIProgressBar.丒丗丝专丝下且业与 onDragFinished;
    public UnityEngine.Transform thumb;
    protected UIWidget mBG;
    protected UIWidget mFG;
    protected float mValue;
    protected UIProgressBar.丏丆与丏丟丈丛丑丅 mFill;
    protected UnityEngine.Transform 丐一丗丛丕世丘东丁;
    protected bool 丆不丙丘不丘丐丒丈;
    protected UnityEngine.Camera 丟丕东万丐丁丁专一;
    protected float 下丟丅丏丏丞东丁丆;
    public int numberOfSteps;
    public System.Collections.Generic.List<EventDelegate> onChange;
    
    // Properties
    public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
    public UnityEngine.Camera 丘丐下不丐下丘丞丗 { get; }
    public UIWidget 七丐丘东丐丆丛一七 { get; set; }
    public UIWidget 上丟世与丗丗上专丏 { get; set; }
    public UIProgressBar.丏丆与丏丟丈丛丑丅 丄丂万丁丒上丒丄丑 { get; set; }
    public float 丙业与丙丗丝不丈东 { get; set; }
    public float 与专丌丅丙上丌一丄 { get; set; }
    protected bool 东丛丌丆丅世丐不丒 { get; }
    protected bool 丘下丐丑专专丐下上 { get; }
    
    // Methods
    public UnityEngine.Transform get_cachedTransform()
    {
        UnityEngine.Transform val_3;
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                this.丐一丗丛丕世丘东丁 = this.transform;
            return val_3;
        }
        
        val_3 = this.丐一丗丛丕世丘东丁;
        return val_3;
    }
    public UnityEngine.Camera get_cachedCamera()
    {
        UnityEngine.Camera val_5;
        if(this.丟丕东万丐丁丁专一 == 0)
        {
                this.丟丕东万丐丁丁专一 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer);
            return val_5;
        }
        
        val_5 = this.丟丕东万丐丁丁专一;
        return val_5;
    }
    public UIWidget get_foregroundWidget()
    {
        return (UIWidget)this.mFG;
    }
    public void set_foregroundWidget(UIWidget 丙业与丙丗丝不丈东)
    {
        if(this.mFG == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mFG = 丙业与丙丗丝不丈东;
        this.丆不丙丘不丘丐丒丈 = true;
    }
    public UIWidget get_backgroundWidget()
    {
        return (UIWidget)this.mBG;
    }
    public void set_backgroundWidget(UIWidget 丙业与丙丗丝不丈东)
    {
        if(this.mBG == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mBG = 丙业与丙丗丝不丈东;
        this.丆不丙丘不丘丐丒丈 = true;
    }
    public UIProgressBar.丏丆与丏丟丈丛丑丅 get_fillDirection()
    {
        return (丏丆与丏丟丈丛丑丅)this.mFill;
    }
    public void set_fillDirection(UIProgressBar.丏丆与丏丟丈丛丑丅 丙业与丙丗丝不丈东)
    {
        if(this.mFill == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mFill = 丙业与丙丗丝不丈东;
        goto typeof(UIProgressBar).__il2cppRuntimeField_198;
    }
    public float get_value()
    {
        var val_2;
        float val_3;
        var val_4;
        float val_5;
        val_3 = this.mValue;
        if(this.numberOfSteps < 2)
        {
                return (float)val_3;
        }
        
        val_3 = val_3 * ((float)this.numberOfSteps - 1);
        if(val_3 >= 0f)
        {
            goto label_4;
        }
        
        if((double)val_3 != (-0.5))
        {
            goto label_5;
        }
        
        val_4 = val_2;
        val_5 = -1f;
        goto label_6;
        label_4:
        if((double)val_3 != 0.5)
        {
            goto label_7;
        }
        
        val_4 = val_2;
        val_5 = 1f;
        label_6:
        float val_3 = (float)val_4;
        val_5 = val_3 + val_5;
        val_3 = (((long)val_4 & 1) != 0) ? (val_3) : (val_5);
        goto label_9;
        label_5:
        float val_4 = -0.5f;
        val_4 = val_3 + val_4;
        goto label_9;
        label_7:
        float val_5 = 0.5f;
        val_5 = val_3 + val_5;
        label_9:
        int val_6 = this.numberOfSteps;
        val_6 = val_6 - 1;
        val_3 = val_5 / (float)val_6;
        return (float)val_3;
    }
    public void set_value(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Behaviour val_6 = this;
        float val_1 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
        if(this.mValue == val_1)
        {
                return;
        }
        
        this.mValue = val_1;
        if(this.value == this.value)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this.onChange)) == false)
        {
                return;
        }
        
        UIProgressBar.current = val_6;
        val_6 = this.onChange;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_6);
        UIProgressBar.current = 0;
    }
    public float get_alpha()
    {
        var val_8;
        var val_9;
        UIWidget val_10;
        val_8 = this;
        val_9 = 1152921504848912384;
        if(this.mFG == 0)
        {
            goto label_3;
        }
        
        val_10 = this.mFG;
        if(val_10 != null)
        {
            goto label_8;
        }
        
        label_9:
        val_10 = 0;
        label_8:
        val_8 = ???;
        val_9 = ???;
        goto mem[282584257677079];
        label_3:
        if((val_8 + 40) == 0)
        {
                return 1f;
        }
        
        if((val_8 + 40) != 0)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    public void set_alpha(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Object val_31;
        UIWidget val_32;
        var val_33;
        var val_34;
        val_31 = this;
        if(this.mFG == 0)
        {
            goto label_16;
        }
        
        bool val_3 = UnityEngine.Object.op_Inequality(x:  this.mFG.GetComponent<UnityEngine.Collider>(), y:  0);
        if(this.mFG == null)
        {
            goto label_8;
        }
        
        if(val_3 == false)
        {
            goto label_9;
        }
        
        label_13:
        val_32 = this.mFG;
        this.mFG.GetComponent<UnityEngine.Collider>().enabled = (丙业与丙丗丝不丈东 > 0.001f) ? 1 : 0;
        goto label_16;
        label_8:
        if(val_3 == true)
        {
            goto label_13;
        }
        
        label_9:
        val_32 = 1152921531090919856;
        if((this.mFG.GetComponent<UnityEngine.Collider2D>()) != 0)
        {
                val_32 = this.mFG;
            this.mFG.GetComponent<UnityEngine.Collider2D>().enabled = (丙业与丙丗丝不丈东 > 0.001f) ? 1 : 0;
        }
        
        label_16:
        if(this.mBG == 0)
        {
            goto label_35;
        }
        
        bool val_12 = UnityEngine.Object.op_Inequality(x:  this.mBG.GetComponent<UnityEngine.Collider>(), y:  0);
        if(this.mBG == null)
        {
            goto label_27;
        }
        
        if(val_12 == false)
        {
            goto label_28;
        }
        
        label_32:
        val_32 = this.mBG;
        this.mBG.GetComponent<UnityEngine.Collider>().enabled = (丙业与丙丗丝不丈东 > 0.001f) ? 1 : 0;
        goto label_35;
        label_27:
        if(val_12 == true)
        {
            goto label_32;
        }
        
        label_28:
        val_32 = 1152921531090919856;
        if((this.mBG.GetComponent<UnityEngine.Collider2D>()) != 0)
        {
                val_32 = this.mBG;
            this.mBG.GetComponent<UnityEngine.Collider2D>().enabled = (丙业与丙丗丝不丈东 > 0.001f) ? 1 : 0;
        }
        
        label_35:
        if(this.thumb == 0)
        {
                return;
        }
        
        val_31 = this.thumb.GetComponent<UIWidget>();
        if(val_31 == 0)
        {
                return;
        }
        
        bool val_23 = UnityEngine.Object.op_Inequality(x:  val_31.GetComponent<UnityEngine.Collider>(), y:  0);
        if(val_31 == null)
        {
            goto label_50;
        }
        
        if(val_23 == false)
        {
            goto label_51;
        }
        
        label_54:
        val_31.GetComponent<UnityEngine.Collider>().enabled = (丙业与丙丗丝不丈东 > 0.001f) ? 1 : 0;
        return;
        label_50:
        if(val_23 == true)
        {
            goto label_54;
        }
        
        label_51:
        val_32 = 1152921531090919856;
        if((val_31.GetComponent<UnityEngine.Collider2D>()) == 0)
        {
                return;
        }
        
        if(val_31 != null)
        {
                val_33 = public UnityEngine.Collider2D UnityEngine.Component::GetComponent<UnityEngine.Collider2D>();
            val_34 = val_31.GetComponent<UnityEngine.Collider2D>();
        }
        else
        {
                val_33 = public UnityEngine.Collider2D UnityEngine.Component::GetComponent<UnityEngine.Collider2D>();
            val_34 = val_31.GetComponent<UnityEngine.Collider2D>();
        }
        
        val_34.enabled = (丙业与丙丗丝不丈东 > 0.001f) ? 1 : 0;
    }
    protected bool 丆七丆丂下丟丁丘下()
    {
        return (bool)(this.mFill < 2) ? 1 : 0;
    }
    protected bool 丝丐七丂七万丛丛丐()
    {
        丏丆与丏丟丈丛丑丅 val_2 = this.mFill;
        val_2 = val_2 | 2;
        return (bool)(val_2 == 3) ? 1 : 0;
    }
    protected void Start()
    {
        UnityEngine.Object val_4;
        if(UnityEngine.Application.isPlaying != false)
        {
                if(this.mBG != 0)
        {
                this.mBG.autoResizeBoxCollider = true;
        }
        
            val_4 = 0;
            if((UIProgressBar.current == val_4) && (this.onChange != null))
        {
                UIProgressBar.current = this;
            val_4 = 0;
            EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onChange);
            UIProgressBar.current = 0;
        }
        
        }
    
    }
    protected virtual void 丌上七丕专一东丝丏()
    {
    
    }
    protected virtual void 丁业三上丛丐且专东()
    {
    
    }
    protected void Update()
    {
        if(this.丆不丙丘不丘丐丒丈 == false)
        {
                return;
        }
        
        goto typeof(UIProgressBar).__il2cppRuntimeField_198;
    }
    protected void OnValidate()
    {
        UnityEngine.Behaviour val_9;
        int val_10;
        val_9 = this;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
            goto label_3;
        }
        
        this.丆不丙丘不丘丐丒丈 = true;
        float val_2 = UnityEngine.Mathf.Clamp01(value:  this.mValue);
        if(this.mValue != val_2)
        {
                this.mValue = val_2;
        }
        
        if((this.numberOfSteps & 2147483648) != 0)
        {
            goto label_7;
        }
        
        if(this.numberOfSteps < 21)
        {
            goto label_8;
        }
        
        val_10 = 20;
        goto label_9;
        label_3:
        float val_3 = UnityEngine.Mathf.Clamp01(value:  this.mValue);
        if(this.mValue != val_3)
        {
                this.mValue = val_3;
        }
        
        if((this.numberOfSteps & 2147483648) != 0)
        {
            goto label_13;
        }
        
        if(this.numberOfSteps < 21)
        {
                return;
        }
        
        this.numberOfSteps = 20;
        return;
        label_7:
        val_10 = 0;
        label_9:
        this.numberOfSteps = val_10;
        label_8:
        val_9 = ???;
        goto typeof(UIProgressBar).__il2cppRuntimeField_198;
        label_13:
        mem2[0] = 0;
    }
    protected float 丂丌丆丝丟丂下丝与(UnityEngine.Vector2 丅丙丆丕业上下丌丄)
    {
        float val_10;
        float val_14;
        float val_15;
        UnityEngine.Transform val_1 = this.cachedTransform;
        UnityEngine.Quaternion val_2 = val_1.rotation;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.back;
        UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = val_1.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丅丙丆丕业上下丌丄.x, y = 丅丙丆丕业上下丌丄.y});
        val_14 = val_7.x;
        val_15 = val_7.z;
        UnityEngine.Ray val_8 = this.cachedCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_14, y = val_7.y, z = val_15});
        if((744331024 & 1) == 0)
        {
                return (float)this.value;
        }
        
        UnityEngine.Vector3 val_11 = val_1.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_10, z = val_15});
        val_14 = val_11.x;
        val_15 = val_11.z;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_15});
        return (float)this.value;
    }
    protected virtual float 丕丑丟丘丘丛上丞下(UnityEngine.Vector2 丈丑丑且业下丒丁丞)
    {
        丏丆与丏丟丈丛丑丅 val_4;
        var val_5;
        float val_6;
        float val_7;
        if(this.mFG == 0)
        {
                return this.value;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V10.16B, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = V15.16B, y = V13.16B, z = V14.16B});
        val_4 = this.mFill;
        if(val_4 <= 1)
        {
                val_4 = this.mFill;
            val_5 = val_4 | 2;
            val_6 = 1f;
            val_2.x = 丈丑丑且业下丒丁丞.x - val_2.x;
            val_7 = val_2.x / val_2.x;
        }
        else
        {
                val_5 = this.mFill | 2;
            val_6 = 1f;
            val_2.x = 丈丑丑且业下丒丁丞.y - val_2.x;
            val_7 = val_2.x / val_2.y;
        }
        
        val_6 = val_6 - val_7;
        val_7 = (val_5 == 3) ? (val_6) : (val_7);
        return (float)val_7;
    }
    public virtual void ForceUpdate()
    {
        UIWidget val_33;
        var val_34;
        var val_35;
        丏丆与丏丟丈丛丑丅 val_36;
        var val_38;
        UIWidget val_39;
        var val_40;
        float val_42;
        float val_43;
        float val_44;
        UIWidget val_45;
        UIWidget val_46;
        var val_47;
        var val_48;
        var val_52;
        float val_53;
        float val_54;
        float val_55;
        float val_56;
        var val_57;
        val_33 = this;
        this.丆不丙丘不丘丐丒丈 = false;
        val_34 = 1152921504848912384;
        if(this.mFG == 0)
        {
            goto label_3;
        }
        
        val_35 = 0;
        if(this.mFill > 1)
        {
            goto label_7;
        }
        
        if(( == 0) || ( != 3))
        {
            goto label_12;
        }
        
        if(fillDirection != 0)
        {
                if(fillDirection != 1)
        {
            goto label_22;
        }
        
        }
        
        val_36 = 0;
        goto label_15;
        label_7:
        if(( == 0) || ( != 3))
        {
            goto label_20;
        }
        
        if(fillDirection != 0)
        {
                if(fillDirection != 1)
        {
            goto label_22;
        }
        
        }
        
        val_36 = 1;
        label_15:
        fillDirection = val_36;
        丏丆与丏丟丈丛丑丅 val_32 = this.mFill;
        val_32 = val_32 | 2;
        invert = (val_32 == 3) ? 1 : 0;
        label_22:
        fillAmount = this.value;
        label_3:
        val_38 = 0;
        goto label_23;
        label_12:
        val_39 = this.mFG;
        val_40 = this.mFill | 2;
        float val_11 = this.value;
        if(val_40 != 3)
        {
            goto label_24;
        }
        
        val_42 = 1f;
        val_11 = val_42 - val_11;
        goto label_28;
        label_20:
        val_39 = this.mFG;
        val_40 = this.mFill | 2;
        if(val_40 != 3)
        {
            goto label_26;
        }
        
        val_42 = 1f;
        float val_13 = val_42 - this.value;
        goto label_28;
        label_24:
        goto label_28;
        label_26:
        label_28:
        val_43 = 0f;
        val_44 = 0f;
        val_39.drawRegion = new UnityEngine.Vector4() {x = val_43, y = 0f, z = val_44, w = 0f};
        this.mFG.enabled = true;
        float val_14 = this.value;
        label_23:
        if(this.thumb == 0)
        {
            goto label_39;
        }
        
        if(this.mFG == 0)
        {
                if(this.mBG == 0)
        {
            goto label_39;
        }
        
        }
        
        if(this.mFG == 0)
        {
            goto label_42;
        }
        
        val_45 = this.mFG;
        if(val_45 != null)
        {
            goto label_73;
        }
        
        label_74:
        val_45 = 0;
        label_73:
        if(this.mFG == 0)
        {
            goto label_46;
        }
        
        val_46 = this.mFG;
        if(val_46 != null)
        {
            goto label_75;
        }
        
        label_76:
        val_46 = 0;
        label_75:
        val_47 = 28563616;
        if(val_47 == 0)
        {
                val_47 = 28563616;
        }
        
        float val_33 = 8.96831E-44f;
        val_33 = val_14 + val_33;
        mem[32] = val_33;
        if(val_47 <= 1)
        {
                val_47 = 28563616;
        }
        
        float val_34 = 0f;
        val_34 = val_14 + val_34;
        mem[44] = val_34;
        if(val_47 <= 2)
        {
                val_47 = 28563616;
        }
        
        float val_35 = 5.877482E-39f;
        val_35 = val_35 - val_44;
        mem[56] = val_35;
        if(val_47 <= 3)
        {
                val_47 = 28563616;
        }
        
        float val_36 = 7.006492E-45f;
        val_36 = val_36 - val_44;
        mem[68] = val_36;
        if(val_47 == 0)
        {
                val_47 = 28563616;
        }
        
        float val_37 = 0f;
        val_37 = 0.001f + val_37;
        mem[36] = val_37;
        if(val_47 <= 1)
        {
                val_47 = 28563616;
        }
        
        float val_38 = 0f;
        val_38 = val_38 - 0f;
        mem[48] = val_38;
        if(val_47 <= 2)
        {
                val_47 = 28563616;
        }
        
        float val_39 = 2.479598E-39f;
        val_39 = val_39 - 0f;
        mem[60] = val_39;
        float val_40 = 0f;
        val_40 = 0.001f + val_40;
        mem[72] = val_40;
        if(this.mFG == 0)
        {
            goto label_59;
        }
        
        if(this.mFG != null)
        {
            goto label_77;
        }
        
        label_78:
        label_77:
        do
        {
            UnityEngine.Vector3 val_24 = 0.cachedTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = (val_45 + 40) + -8, y = (val_45 + 40) + -8 + 4, z = val_45 + 40});
            val_34 = 0 + 1;
            mem2[0] = val_24.x;
            mem2[0] = val_24.y;
            mem2[0] = val_24.z;
        }
        while(val_34 != 4);
        
        val_48 = 28563616;
        if(val_48 == 0)
        {
                val_48 = 28563616;
        }
        
        if(this.mFill > 1)
        {
            goto label_66;
        }
        
        val_40 = 1152921504838316032;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = mem[32], y = mem[36], z = 4.656534E-34f}, b:  new UnityEngine.Vector3() {x = mem[44], y = mem[48], z = 5.142877E-39f}, t:  0.5f);
        val_52 = 28563616;
        val_43 = val_25.x;
        val_53 = val_25.y;
        val_44 = val_25.z;
        if(val_52 <= 2)
        {
                val_52 = 28563616;
        }
        
        val_54 = mem[56];
        val_55 = mem[60];
        val_56 = 1.401298E-45f;
        if(val_52 > 3)
        {
            goto label_72;
        }
        
        goto label_72;
        label_42:
        if(this.mBG != null)
        {
            goto label_73;
        }
        
        goto label_74;
        label_46:
        if(this.mBG != null)
        {
            goto label_75;
        }
        
        goto label_76;
        label_59:
        if(this.mBG != null)
        {
            goto label_77;
        }
        
        goto label_78;
        label_66:
        val_40 = 1152921504838316032;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = mem[32], y = mem[36], z = 4.656534E-34f}, b:  new UnityEngine.Vector3() {x = mem[68], y = mem[72], z = 0f}, t:  0.5f);
        val_57 = 28563616;
        val_43 = val_26.x;
        val_53 = val_26.y;
        val_44 = val_26.z;
        if(val_57 <= 1)
        {
                val_57 = 28563616;
        }
        
        val_54 = mem[44];
        val_55 = mem[48];
        val_56 = 5.142877E-39f;
        label_72:
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_54, y = val_55, z = val_56}, b:  new UnityEngine.Vector3() {x = mem[56], y = mem[60], z = 1.401298E-45f}, t:  0.5f);
        float val_29 = this.value;
        float val_41 = 1f;
        val_41 = val_41 - val_29;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_43, y = val_53, z = val_44}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, t:  ((this.mFill | 2) == 3) ? (val_41) : (val_29));
        this.三上丑下丝丒三丑三(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        label_39:
        if(((val_14 < 0) ? 1 : 0) == 0)
        {
                return;
        }
        
        val_33 = this.mFG;
        val_33.enabled = false;
    }
    protected void 三上丑下丝丒三丑三(UnityEngine.Vector3 丈七东丐世丒丅丗丌)
    {
        var val_4;
        float val_11;
        float val_12;
        var val_13;
        float val_14;
        float val_15;
        double val_16;
        var val_17;
        float val_18;
        float val_19;
        val_11 = 丈七东丐世丒丅丗丌.z;
        val_12 = 丈七东丐世丒丅丗丌.x;
        UnityEngine.Transform val_1 = this.thumb.parent;
        if(val_1 == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_3 = val_1.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_12, y = 丈七东丐世丒丅丗丌.y, z = val_11});
        if(val_3.x >= 0f)
        {
            goto label_8;
        }
        
        if((double)val_3.x != (-0.5))
        {
            goto label_9;
        }
        
        val_13 = val_4;
        val_14 = -1f;
        goto label_10;
        label_4:
        UnityEngine.Vector3 val_5 = this.thumb.position;
        val_15 = val_5.y;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_15, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_12, y = 丈七东丐世丒丅丗丌.y, z = val_11})) <= (1E-05f))
        {
                return;
        }
        
        this.thumb.position = new UnityEngine.Vector3() {x = val_12, y = 丈七东丐世丒丅丗丌.y, z = val_11};
        return;
        label_8:
        if((double)val_3.x != 0.5)
        {
            goto label_16;
        }
        
        val_13 = val_4;
        val_14 = 1f;
        label_10:
        val_14 = (float)val_13 + val_14;
        var val_7 = (((long)val_13 & 1) != 0) ? ((float)val_13) : (val_14);
        goto label_18;
        label_9:
        float val_11 = -0.5f;
        val_11 = val_3.x + val_11;
        goto label_18;
        label_16:
        float val_12 = 0.5f;
        val_12 = val_3.x + val_12;
        label_18:
        if(val_3.y >= 0f)
        {
            goto label_19;
        }
        
        val_16 = -0.5;
        if((double)val_3.y != val_16)
        {
            goto label_20;
        }
        
        val_17 = val_4;
        val_18 = -1f;
        goto label_21;
        label_19:
        val_16 = 0.5;
        if((double)val_3.y != val_16)
        {
            goto label_22;
        }
        
        val_17 = val_4;
        val_18 = 1f;
        label_21:
        val_19 = (float)val_17;
        val_16 = val_19 + val_18;
        var val_8 = (((long)val_17 & 1) != 0) ? (val_19) : (val_16);
        goto label_24;
        label_20:
        val_19 = val_3.y + (-0.5f);
        goto label_24;
        label_22:
        val_19 = val_3.y + 0.5f;
        label_24:
        UnityEngine.Vector3 val_9 = this.thumb.localPosition;
        val_12 = val_9.x;
        val_15 = val_9.z;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12, y = val_9.y, z = val_15}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = 0f})) <= 0.001f)
        {
                return;
        }
        
        this.thumb.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = 0f};
    }
    public virtual void OnPan(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_6 = 丞且丅三三东不丄且.y;
        if(this.enabled == false)
        {
                return;
        }
        
        if(this.mFill > 3)
        {
                return;
        }
        
        var val_3 = 106066080 + (this.mFill) << 2;
        val_3 = val_3 + 106066080;
        goto (106066080 + (this.mFill) << 2 + 106066080);
    }
    public UIProgressBar()
    {
        this.mValue = 1f;
        this.onChange = new System.Collections.Generic.List<EventDelegate>();
    }

}
