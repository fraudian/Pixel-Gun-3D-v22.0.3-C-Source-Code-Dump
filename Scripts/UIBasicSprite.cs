using UnityEngine;
public abstract class UIBasicSprite : UIWidget
{
    // Fields
    protected UIBasicSprite.丒三丝一上丙专丗丒 mType;
    protected UIBasicSprite.丏丆与丏丟丈丛丑丅 mFillDirection;
    protected float mFillAmount;
    protected bool mInvert;
    protected UIBasicSprite.与丂不丏不丁不丛丐 mFlip;
    private UnityEngine.Rect 丅丘三一与丑丛丑东;
    private UnityEngine.Rect 丐丑丛不下丝万丕万;
    public UIBasicSprite.三万丏丆七丄丙丞丙 centerType;
    public UIBasicSprite.三万丏丆七丄丙丞丙 leftType;
    public UIBasicSprite.三万丏丆七丄丙丞丙 rightType;
    public UIBasicSprite.三万丏丆七丄丙丞丙 bottomType;
    public UIBasicSprite.三万丏丆七丄丙丞丙 topType;
    protected static UnityEngine.Vector2[] 万万丂三专丞丆专丏;
    protected static UnityEngine.Vector2[] 万丘丁丝丏世丂业专;
    
    // Properties
    public virtual UIBasicSprite.丒三丝一上丙专丗丒 丁丅丈丌丟世丗丗丟 { get; set; }
    public UIBasicSprite.与丂不丏不丁不丛丐 丄丛一丟丆不丗丑丑 { get; set; }
    public UIBasicSprite.丏丆与丏丟丈丛丑丅 丄丂万丁丒上丒丄丑 { get; set; }
    public float 丙丝与丆三丝不且丑 { get; set; }
    public override int 上专上丛丈丆丗丒丟 { get; }
    public override int 丐丆丏丂上丒丗丌丁 { get; }
    public bool 丝业丈不丙丄丝一一 { get; set; }
    public bool 丁丛丂丑丒专丘下丕 { get; }
    public virtual bool 一丘下丝丏不七丟下 { get; }
    public virtual float 一丞上丘一七丗丟与 { get; }
    private UnityEngine.Vector4 丕丆与丞一万丆丐丝 { get; }
    private UnityEngine.Color32 七丞七东丌业七丙专 { get; }
    
    // Methods
    public virtual UIBasicSprite.丒三丝一上丙专丗丒 get_type()
    {
        return (丒三丝一上丙专丗丒)this.mType;
    }
    public virtual void set_type(UIBasicSprite.丒三丝一上丙专丗丒 丙业与丙丗丝不丈东)
    {
        if(this.mType == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mType = 丙业与丙丗丝不丈东;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_338;
    }
    public UIBasicSprite.与丂不丏不丁不丛丐 get_flip()
    {
        return (与丂不丏不丁不丛丐)this.mFlip;
    }
    public void set_flip(UIBasicSprite.与丂不丏不丁不丛丐 丙业与丙丗丝不丈东)
    {
        if(this.mFlip == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mFlip = 丙业与丙丗丝不丈东;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_338;
    }
    public UIBasicSprite.丏丆与丏丟丈丛丑丅 get_fillDirection()
    {
        return (丏丆与丏丟丈丛丑丅)this.mFillDirection;
    }
    public void set_fillDirection(UIBasicSprite.丏丆与丏丟丈丛丑丅 丙业与丙丗丝不丈东)
    {
        if(this.mFillDirection == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mFillDirection = 丙业与丙丗丝不丈东;
        mem[1152921535219883704] = 1;
    }
    public float get_fillAmount()
    {
        return (float)this.mFillAmount;
    }
    public void set_fillAmount(float 丙业与丙丗丝不丈东)
    {
        float val_1 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
        if(this.mFillAmount == val_1)
        {
                return;
        }
        
        this.mFillAmount = val_1;
        mem[1152921535220115896] = 1;
    }
    public override int get_minWidth()
    {
        if(this != 1)
        {
                if(this != 4)
        {
                return this.minWidth;
        }
        
        }
        
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B}, d:  V0.16B);
        val_1.x = val_1.x + val_1.z;
        int val_5 = UnityEngine.Mathf.RoundToInt(f:  val_1.x);
        val_5 = (val_5 & 1) + val_5;
        return UnityEngine.Mathf.Max(a:  this.minWidth, b:  val_5);
    }
    public override int get_minHeight()
    {
        if(this != 1)
        {
                if(this != 4)
        {
                return this.minHeight;
        }
        
        }
        
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B}, d:  V0.16B);
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_1.y + val_1.w);
        val_6 = (val_6 & 1) + val_6;
        return UnityEngine.Mathf.Max(a:  this.minHeight, b:  val_6);
    }
    public bool get_invert()
    {
        return (bool)this.mInvert;
    }
    public void set_invert(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mInvert == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.mInvert = 丙业与丙丗丝不丈东;
        mem[1152921535220563896] = 1;
    }
    public bool get_hasBorder()
    {
        var val_2;
        val_2 = 1;
        if(S2 != 0f)
        {
                return (bool)(S3 != 0f) ? 1 : 0;
        }
        
        if(S0 != 0f)
        {
                return (bool)(S3 != 0f) ? 1 : 0;
        }
        
        if(S1 != 0f)
        {
                return (bool)(S3 != 0f) ? 1 : 0;
        }
        
        return (bool)(S3 != 0f) ? 1 : 0;
    }
    public virtual bool get_premultipliedAlpha()
    {
        return false;
    }
    public virtual float get_pixelSize()
    {
        return 1f;
    }
    private UnityEngine.Vector4 下与下丂东专与东丌()
    {
        var val_5;
        var val_6;
        var val_8;
        if(this.mFlip == 3)
        {
            goto label_0;
        }
        
        if(this.mFlip == 2)
        {
            goto label_1;
        }
        
        if(this.mFlip != 1)
        {
            goto label_2;
        }
        
        val_5 = V0.16B;
        val_6 = V0.16B;
        float val_1 = this.丐丑丛不下丝万丕万.x;
        goto label_3;
        label_0:
        val_5 = V0.16B;
        val_6 = V0.16B;
        float val_2 = this.丐丑丛不下丝万丕万.x;
        goto label_4;
        label_1:
        float val_3 = this.丐丑丛不下丝万丕万.x;
        val_5 = val_3;
        val_6 = val_3;
        label_4:
        val_8 = val_3;
        goto label_5;
        label_2:
        float val_4 = this.丐丑丛不下丝万丕万.x;
        val_5 = val_4;
        val_6 = val_4;
        label_3:
        val_8 = val_4;
        label_5:
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    private UnityEngine.Color32 世丕丅丞丂丏丄丏三()
    {
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        UnityEngine.Color val_1 = this.color;
        val_14 = val_1.r;
        val_15 = val_1.g;
        val_16 = val_1.b;
        if((this & 1) != 0)
        {
                UnityEngine.Color val_2 = 不丌丂丁丄一与丆丙.下丑与且丅丛丁丄丒(丁丂专业丁丅丅丈丙:  new UnityEngine.Color() {r = val_14, g = val_15, b = val_16, a = V10.16B});
            val_14 = val_2.r;
            val_15 = val_2.g;
            val_16 = val_2.b;
            val_13 = val_2.a;
        }
        
        if(UnityEngine.QualitySettings.activeColorSpace == 1)
        {
                val_14 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_14);
            val_15 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_15);
            val_16 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_16);
            val_13 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_13);
        }
        
        UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_14, g = val_15, b = val_16, a = val_13});
        val_8.r = val_8.r & 4294967295;
        return new UnityEngine.Color32() {r = val_8.r, g = val_8.r, b = val_8.r, a = val_8.r};
    }
    protected void 上东与丛丞下丈专丈(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘, UnityEngine.Rect 丈丒丈丆丑丅丆丌丌, UnityEngine.Rect 万万丁丄丑丌丙丝丏)
    {
        this.丐丑丛不下丝万丕万 = 丈丒丈丆丑丅丆丌丌;
        mem[1152921535221264896] = 丈丒丈丆丑丅丆丌丌.m_YMin;
        mem[1152921535221264900] = 丈丒丈丆丑丅丆丌丌.m_Width;
        mem[1152921535221264904] = 丈丒丈丆丑丅丆丌丌.m_Height;
        this.丅丘三一与丑丛丑东 = 万万丁丄丑丌丙丝丏;
        mem[1152921535221264880] = 万万丁丄丑丌丙丝丏.m_YMin;
        mem[1152921535221264884] = 万万丁丄丑丌丙丝丏.m_Width;
        mem[1152921535221264888] = 万万丁丄丑丌丙丝丏.m_Height;
        if(this > 4)
        {
                return;
        }
        
        var val_1 = mem[4611686140991105096];
        val_1 = val_1 + 106047176;
        goto (mem[4611686140991105096] + 106047176);
    }
    private void 世丘万三丑上丙丗丗(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        byte val_9;
        UnityEngine.Vector4 val_1 = this.下与下丂东专与东丌();
        UnityEngine.Color32 val_2 = this.世丕丅丞丂丏丄丏三();
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.w);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_1.z, y:  val_1.w);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_1.z, y:  val_1.y);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        if(丗丄丌丝丌上世丄丘 != null)
        {
                val_9 = val_2.r & 4294967295;
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
        }
        else
        {
                val_9 = val_2.r & 4294967295;
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
        }
        
        丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9, g = val_9, b = val_9, a = val_9});
    }
    private void 一万丈七丘丁丑丞丏(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        float val_18;
        float val_20;
        var val_21;
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B}, d:  V0.16B);
        if((((val_1.w == 0f) && (val_1.z == 0f)) && (val_1.x == 0f)) && (val_1.y == 0f))
        {
                this.世丘万三丑上丙丗丗(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘);
            return;
        }
        
        UnityEngine.Color32 val_2 = this.世丕丅丞丂丏丄丏三();
        byte val_25 = val_2.r;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_20 = val_1.x;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_24 = val_1.y;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_38 = val_1.z;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_3C = val_1.w;
        var val_23 = mem[1152921535221538024];
        val_23 = val_23 | 2;
        if(val_23 != 3)
        {
            goto label_17;
        }
        
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        val_18 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 32];
        val_18 = UIBasicSprite.万万丂三专丞丆专丏 + 32;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = val_1.z + val_18;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = (UIBasicSprite.万万丂三专丞丆专丏 + 56) - val_1.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_38 = x;
        float val_6 = x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = val_6;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = val_6;
        if(UIBasicSprite.万丘丁丝丏世丂业专.Length != 0)
        {
            goto label_36;
        }
        
        goto label_36;
        label_17:
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        val_18 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 32];
        val_18 = UIBasicSprite.万万丂三专丞丆专丏 + 32;
        val_1.x = val_1.x + val_18;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = val_1.x;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = (UIBasicSprite.万万丂三专丞丆专丏 + 56) - val_1.z;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_20 = x;
        float val_9 = x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = val_9;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = val_9;
        label_36:
        mem2[0] = val_9;
        var val_24 = mem[1152921535221538024];
        val_24 = val_24 & 4294967294;
        if(val_24 != 2)
        {
            goto label_55;
        }
        
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        val_20 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 36];
        val_20 = UIBasicSprite.万万丂三专丞丆专丏 + 36;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = val_1.w + val_20;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        float val_11 = (UIBasicSprite.万万丂三专丞丆专丏 + 60) - val_1.y;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = val_11;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_3C = val_11;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = val_11;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = val_11;
        if(UIBasicSprite.万丘丁丝丏世丂业专.Length != 0)
        {
            goto label_74;
        }
        
        goto label_74;
        label_55:
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        val_20 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 36];
        val_20 = UIBasicSprite.万万丂三专丞丆专丏 + 36;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = val_1.y + val_20;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_82;
        }
        
        }
        
        float val_13 = (UIBasicSprite.万万丂三专丞丆专丏 + 60) - val_1.w;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = val_13;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_24 = val_13;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = val_13;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = val_13;
        label_74:
        val_25 = val_25 & 4294967295;
        mem2[0] = val_13;
        do
        {
            do
        {
            label_140:
            if((0 == 1) && (0 == 1))
        {
                if(mem[1152921535221538060] == 0)
        {
            goto label_140;
        }
        
        }
        
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector2[] val_15 = UIBasicSprite.万万丂三专丞丆专丏 + (((0 + 1)) << 3);
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector2[] val_16 = UIBasicSprite.万万丂三专丞丆专丏 + (((0 + 1)) << 3);
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  (mem[1152921535221538024] & 4294967294) + 32, y:  UIBasicSprite.万丘丁丝丏世丂业专.Length + 36);
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector2[] val_18 = UIBasicSprite.万丘丁丝丏世丂业专 + (((0 + 1)) << 3);
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  (mem[1152921535221538024] & 4294967294) + 32, y:  (UIBasicSprite.万丘丁丝丏世丂业专 + ((0 + 1)) << 3) + 36);
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Vector2[] val_20 = UIBasicSprite.万丘丁丝丏世丂业专 + (((0 + 1)) << 3);
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  (mem[1152921535221538024] & 4294967294) + 32, y:  (UIBasicSprite.万丘丁丝丏世丂业专 + ((0 + 1)) << 3) + 36);
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  (mem[1152921535221538024] & 4294967294) + 32, y:  UIBasicSprite.万丘丁丝丏世丂业专.Length + 36);
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            if(丗丄丌丝丌上世丄丘 != null)
        {
                val_21 = 1152921535198486432;
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
        }
        else
        {
                val_21 = 1152921535198486432;
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
        }
        
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_25, g = val_25, b = val_25, a = val_25});
        }
        while((0 + 1) != 3);
        
        }
        while(1 != 3);
        
        return;
        label_82:
    }
    private void 丟三丕丐上专东下丐(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        float val_22;
        float val_23;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_31;
        var val_32;
        float val_33;
        float val_34;
        if(this == 0)
        {
                return;
        }
        
        float val_20 = 1.152922E+18f;
        float val_21 = 1.152922E+18f;
        val_20 = V0.16B * val_20;
        val_21 = V0.16B * val_21;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_20, y:  val_21);
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  val_20);
        if(val_3.x < 0)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        val_22 = val_3.y;
        if(val_22 < 0)
        {
                return;
        }
        
        UnityEngine.Color32 val_5 = this.世丕丅丞丂丏丄丏三();
        与丂不丏不丁不丛丐 val_22 = this.mFlip;
        val_23 = val_22;
        val_22 = val_22 | 2;
        if(val_22 == 3)
        {
                float val_6 = this.丅丘三一与丑丛丑东.x;
        }
        else
        {
                float val_7 = this.丅丘三一与丑丛丑东.x;
        }
        
        与丂不丏不丁不丛丐 val_23 = this.mFlip;
        val_23 = val_23 & 4294967294;
        if(val_23 == 2)
        {
                val_25 = val_7;
        }
        else
        {
                val_25 = val_7;
        }
        
        val_26 = ???;
        if(val_23 >= 0)
        {
                return;
        }
        
        byte val_8 = val_5.r & 4294967295;
        do
        {
            val_27 = val_7;
            val_28 = val_23 + val_3.y;
            if(val_28 > val_26)
        {
                val_26 = ???;
            val_22 = val_7;
            val_26 = val_26 - val_23;
            val_28 = ???;
            val_27 = UnityEngine.Mathf.Lerp(a:  val_25, b:  val_22, t:  val_26 / val_3.y);
        }
        
            if(2f < 0)
        {
                float val_24 = 2f;
            do
        {
            val_29 = val_7;
            val_30 = val_24 + val_3.x;
            if(val_30 > val_20)
        {
                val_29 = UnityEngine.Mathf.Lerp(a:  val_7, b:  val_7, t:  (val_20 - val_24) / val_3.x);
            val_30 = val_20;
        }
        
            val_31 = 0;
            if(丗丞不丞业丑七且丗 == null)
        {
                val_31 = 1;
        }
        
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_32 = 0;
            if(丗丞不丞业丑七且丗 == null)
        {
                val_32 = 1;
        }
        
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_7, y:  val_25);
            if(丂丙丆丂丑丝丂丝丒 != null)
        {
                丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            val_33 = val_27;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_7, y:  val_33);
        }
        else
        {
                0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            val_33 = val_27;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_7, y:  val_33);
        }
        
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_29, y:  val_27);
            if(丂丙丆丂丑丝丂丝丒 != null)
        {
                丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            val_34 = val_25;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_29, y:  val_34);
        }
        else
        {
                0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            val_34 = val_25;
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_29, y:  val_34);
        }
        
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            if(丗丄丌丝丌上世丄丘 != null)
        {
                丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
        }
        else
        {
                0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
            0.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
        }
        
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8});
            val_23 = val_3.x;
            val_24 = val_24 + val_23;
        }
        while(val_24 < 0);
        
        }
        
            float val_25 = val_23;
            val_25 = val_25 + val_3.y;
        }
        while(val_25 < 0);
    
    }
    private void 丈丐世丘丕丐一七丞(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        float val_53;
        float val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        float val_59;
        float val_60;
        var val_61;
        var val_62;
        byte val_63;
        var val_64;
        var val_65;
        var val_66;
        UnityEngine.Vector2[] val_67;
        UnityEngine.Vector2[] val_68;
        UnityEngine.Vector2[] val_69;
        UnityEngine.Vector2[] val_70;
        UnityEngine.Vector2[] val_71;
        float val_72;
        UnityEngine.Vector2[] val_73;
        UnityEngine.Vector2[] val_74;
        UnityEngine.Vector2[] val_75;
        var val_76;
        UnityEngine.Vector2[] val_77;
        float val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        float val_85;
        UnityEngine.Vector2[] val_86;
        UnityEngine.Vector2[] val_87;
        UnityEngine.Vector2[] val_88;
        UnityEngine.Vector2[] val_89;
        UnityEngine.Vector2[] val_90;
        UnityEngine.Vector2[] val_91;
        UnityEngine.Vector2[] val_92;
        UnityEngine.Vector2[] val_93;
        var val_94;
        var val_95;
        if(this.mFillAmount < 0)
        {
                return;
        }
        
        val_53 = this.mFillAmount;
        val_54 = 0.001f;
        val_55 = V2.16B;
        val_56 = V3.16B;
        UnityEngine.Vector4 val_1 = this.下与下丂东专与东丌();
        val_57 = val_1.x;
        val_58 = val_1.y;
        val_59 = val_1.w;
        UnityEngine.Color32 val_2 = this.世丕丅丞丂丏丄丏三();
        byte val_63 = val_2.r;
        if(this.mFillDirection == 1)
        {
            goto label_2;
        }
        
        if(this.mFillDirection != 0)
        {
            goto label_8;
        }
        
        float val_53 = this.mFillAmount;
        val_60 = val_55 - val_53;
        val_1.x = val_1.z - val_57;
        val_1.x = val_1.x * val_53;
        val_53 = val_60 * val_53;
        if(this.mInvert == false)
        {
            goto label_4;
        }
        
        val_53 = val_55 - val_53;
        val_57 = val_1.z - val_1.x;
        goto label_8;
        label_2:
        float val_54 = this.mFillAmount;
        float val_3 = val_59 - val_58;
        val_60 = val_56 - val_54;
        val_3 = val_3 * val_54;
        val_54 = val_60 * val_54;
        if(this.mInvert == false)
        {
            goto label_6;
        }
        
        val_54 = val_56 - val_54;
        val_58 = val_59 - val_3;
        goto label_8;
        label_4:
        val_1.x = val_57 + val_1.x;
        val_55 = val_53 + val_53;
        goto label_8;
        label_6:
        val_56 = val_54 + val_54;
        val_59 = val_58 + val_3;
        label_8:
        val_61 = null;
        val_61 = null;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_53, y:  val_54);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_20 = val_4.x;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_24 = val_4.y;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_53, y:  val_56);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = val_5.x;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = val_5.y;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_55, y:  val_56);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = val_6.x;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = val_6.y;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_55, y:  val_54);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_38 = val_7.x;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_3C = val_7.y;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_57, y:  val_58);
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_20 = val_8.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_24 = val_8.y;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_57, y:  val_59);
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = val_9.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = val_9.y;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_1.x, y:  val_59);
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = val_10.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = val_10.y;
        val_62 = 0;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_1.x, y:  val_58);
        if(UIBasicSprite.万丘丁丝丏世丂业专.Length <= 3)
        {
                val_62 = 0;
        }
        
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_38 = val_11.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_3C = val_11.y;
        if(this.mFillAmount >= 0)
        {
            goto label_30;
        }
        
        if(this.mFillDirection == 2)
        {
            goto label_28;
        }
        
        if(this.mFillDirection == 3)
        {
            goto label_29;
        }
        
        if(this.mFillDirection != 4)
        {
            goto label_30;
        }
        
        var val_59 = 0;
        val_63 = val_63 & 4294967295;
        label_101:
        val_64 = 0.5f;
        float val_12 = (val_59 > 1) ? 1f : 0.5f;
        float val_13 = (val_59 > 1) ? 0.5f : 0f;
        val_65 = 0f;
        if(val_59 != 0)
        {
                float val_14 = (val_59 == 3) ? 0.5f : 1f;
            float val_15 = (val_59 == 3) ? 0f : 0.5f;
        }
        
        val_66 = null;
        val_66 = null;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_20 = UnityEngine.Mathf.Lerp(a:  val_53, b:  val_55, t:  val_13);
        val_67 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_38;
        }
        
        val_67 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_67 == null)
        {
            goto label_181;
        }
        
        label_38:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = UIBasicSprite.万万丂三专丞丆专丏 + 32;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = UnityEngine.Mathf.Lerp(a:  val_53, b:  val_55, t:  val_12);
        val_68 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_44;
        }
        
        val_68 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_68 == null)
        {
            goto label_181;
        }
        
        label_44:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_38 = UIBasicSprite.万万丂三专丞丆专丏 + 48;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_24 = UnityEngine.Mathf.Lerp(a:  val_54, b:  val_56, t:  val_15);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = UnityEngine.Mathf.Lerp(a:  val_54, b:  val_56, t:  val_14);
        val_69 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_52;
        }
        
        val_69 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_69 == null)
        {
            goto label_181;
        }
        
        label_52:
        val_57 = val_57;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = UIBasicSprite.万万丂三专丞丆专丏 + 44;
        val_70 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_56;
        }
        
        val_70 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_70 == null)
        {
            goto label_181;
        }
        
        label_56:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_3C = UIBasicSprite.万万丂三专丞丆专丏 + 36;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_20 = UnityEngine.Mathf.Lerp(a:  val_57, b:  val_1.x, t:  val_13);
        val_71 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_62;
        }
        
        val_71 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_71 == null)
        {
            goto label_181;
        }
        
        label_62:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = UIBasicSprite.万丘丁丝丏世丂业专 + 32;
        val_72 = UnityEngine.Mathf.Lerp(a:  val_57, b:  val_1.x, t:  val_12);
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = val_72;
        val_73 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_68;
        }
        
        val_73 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_73 == null)
        {
            goto label_181;
        }
        
        label_68:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_38 = UIBasicSprite.万丘丁丝丏世丂业专 + 48;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_24 = UnityEngine.Mathf.Lerp(a:  val_58, b:  val_59, t:  val_15);
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = UnityEngine.Mathf.Lerp(a:  val_58, b:  val_59, t:  val_14);
        val_74 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_76;
        }
        
        val_74 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_74 == null)
        {
            goto label_181;
        }
        
        label_76:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = UIBasicSprite.万丘丁丝丏世丂业专 + 44;
        val_75 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_80;
        }
        
        val_75 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_75 == null)
        {
            goto label_181;
        }
        
        label_80:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_3C = UIBasicSprite.万丘丁丝丏世丂业专 + 36;
        float val_57 = this.mFillAmount;
        int val_24 = val_59 + 2;
        int val_56 = 万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  val_24, 七丝东丛东丝且丆不:  4);
        val_76 = null;
        var val_55 = 3;
        val_55 = val_55 - val_56;
        val_56 = (this.mInvert == true) ? (val_56) : (val_55);
        val_57 = val_57 * 4f;
        val_76 = null;
        val_57 = val_57 - (float)val_56;
        val_77 = UIBasicSprite.万丘丁丝丏世丂业专;
        val_78 = UnityEngine.Mathf.Clamp01(value:  val_57);
        if((UIBasicSprite.且且丛东丌丅东丗专(三丗万世丅丌丏丄丅:  UIBasicSprite.万万丂三专丞丆专丏, 丌丌丁专与东丌丗且:  val_77, 一丝丟丈丛丑丂与一:  val_78, 丝业丈不丙丄丝一一:  this.mInvert, 丅东下丄丏且三丆丘:  万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  val_24, 七丝东丛东丝且丆不:  4))) != false)
        {
                var val_58 = 0;
            do
        {
            val_79 = null;
            val_79 = null;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UIBasicSprite.万万丂三专丞丆专丏.Length + 32, y = UIBasicSprite.万万丂三专丞丆专丏.Length + 32 + 4});
            val_72 = val_29.z;
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_72});
            val_78 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 32];
            val_78 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32;
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_78, y = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32 + 4});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_63, g = val_63, b = val_63, a = val_63});
            val_77 = 0 + 1;
            val_58 = val_58 + 8;
        }
        while(val_77 != 4);
        
        }
        
        val_80 = 1152921504838422528;
        val_59 = val_59 + 1;
        if(val_59 != 4)
        {
            goto label_101;
        }
        
        return;
        label_30:
        val_80 = 1152921535198484384;
        val_63 = 1152921535198486432;
        var val_60 = 0;
        do
        {
            val_81 = null;
            val_81 = null;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {y = 1152921504850403328.__il2cppRuntimeField_24});
            val_72 = val_31.z;
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_72});
            val_78 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 32];
            val_78 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32;
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_78, y = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32 + 4});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_63 & 4294967295, g = val_63 & 4294967295, b = val_63 & 4294967295, a = val_63 & 4294967295});
            val_77 = 0 + 1;
            val_60 = val_60 + 8;
        }
        while(val_77 != 4);
        
        return;
        label_28:
        val_82 = null;
        val_82 = null;
        if((UIBasicSprite.且且丛东丌丅东丗专(三丗万世丅丌丏丄丅:  UIBasicSprite.万万丂三专丞丆专丏, 丌丌丁专与东丌丗且:  UIBasicSprite.万丘丁丝丏世丂业专, 一丝丟丈丛丑丂与一:  this.mFillAmount, 丝业丈不丙丄丝一一:  this.mInvert, 丅东下丄丏且三丆丘:  0)) == false)
        {
                return;
        }
        
        var val_62 = 0;
        var val_61 = 0;
        do
        {
            val_83 = null;
            val_83 = null;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {y = 1152921504850403328.__il2cppRuntimeField_24});
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32, y = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32 + 4});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_63 & 4294967295, g = val_63 & 4294967295, b = val_63 & 4294967295, a = val_63 & 4294967295});
            val_61 = val_61 + 1;
            val_62 = val_62 + 8;
        }
        while(val_61 != 4);
        
        return;
        label_29:
        var val_67 = 0;
        val_63 = val_63 & 4294967295;
        label_201:
        val_84 = null;
        float val_35 = (val_67 == 0) ? 0.5f : 1f;
        float val_36 = (val_67 == 0) ? 0f : 0.5f;
        val_85 = val_53;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_20 = UnityEngine.Mathf.Lerp(a:  null, b:  val_55, t:  val_36);
        val_86 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_138;
        }
        
        val_86 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_86 == null)
        {
            goto label_181;
        }
        
        label_138:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = UIBasicSprite.万万丂三专丞丆专丏 + 32;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = UnityEngine.Mathf.Lerp(a:  null, b:  val_55, t:  val_35);
        val_87 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_144;
        }
        
        val_87 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_87 == null)
        {
            goto label_181;
        }
        
        label_144:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_38 = UIBasicSprite.万万丂三专丞丆专丏 + 48;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_24 = UnityEngine.Mathf.Lerp(a:  val_54, b:  val_56, t:  0f);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = UnityEngine.Mathf.Lerp(a:  val_54, b:  val_56, t:  1f);
        val_88 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_152;
        }
        
        val_88 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_88 == null)
        {
            goto label_181;
        }
        
        label_152:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = UIBasicSprite.万万丂三专丞丆专丏 + 44;
        val_89 = UIBasicSprite.万万丂三专丞丆专丏;
        if(UIBasicSprite.万万丂三专丞丆专丏 != null)
        {
            goto label_156;
        }
        
        val_89 = UIBasicSprite.万万丂三专丞丆专丏;
        if(val_89 == null)
        {
            goto label_181;
        }
        
        label_156:
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_3C = UIBasicSprite.万万丂三专丞丆专丏 + 36;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_20 = UnityEngine.Mathf.Lerp(a:  val_57, b:  val_1.x, t:  val_36);
        val_90 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_162;
        }
        
        val_90 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_90 == null)
        {
            goto label_181;
        }
        
        label_162:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = UIBasicSprite.万丘丁丝丏世丂业专 + 32;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = UnityEngine.Mathf.Lerp(a:  val_57, b:  val_1.x, t:  val_35);
        val_91 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_168;
        }
        
        val_91 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_91 == null)
        {
            goto label_181;
        }
        
        label_168:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_38 = UIBasicSprite.万丘丁丝丏世丂业专 + 48;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_24 = UnityEngine.Mathf.Lerp(a:  val_58, b:  val_59, t:  0f);
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = UnityEngine.Mathf.Lerp(a:  val_58, b:  val_59, t:  1f);
        val_92 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_176;
        }
        
        val_92 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_92 == null)
        {
            goto label_181;
        }
        
        label_176:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = UIBasicSprite.万丘丁丝丏世丂业专 + 44;
        val_93 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(UIBasicSprite.万丘丁丝丏世丂业专 != null)
        {
            goto label_180;
        }
        
        val_93 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_93 == null)
        {
            goto label_181;
        }
        
        label_180:
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_3C = UIBasicSprite.万丘丁丝丏世丂业专 + 36;
        val_94 = null;
        var val_64 = 1;
        val_64 = val_64 - val_67;
        float val_46 = this.mFillAmount + this.mFillAmount;
        val_94 = null;
        val_46 = val_46 - ((float)(this.mInvert == true) ? (val_64) : (val_67));
        if((UIBasicSprite.且且丛东丌丅东丗专(三丗万世丅丌丏丄丅:  UIBasicSprite.万万丂三专丞丆专丏, 丌丌丁专与东丌丗且:  UIBasicSprite.万丘丁丝丏世丂业专, 一丝丟丈丛丑丂与一:  UnityEngine.Mathf.Clamp01(value:  val_46), 丝业丈不丙丄丝一一:  (this.mInvert == false) ? 1 : 0, 丅东下丄丏且三丆丘:  万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  val_67 + 3, 七丝东丛东丝且丆不:  4))) != false)
        {
                var val_66 = 0;
            var val_65 = 0;
            do
        {
            val_95 = null;
            val_95 = null;
            UnityEngine.Vector3 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {y = 1152921504850403328.__il2cppRuntimeField_24});
            丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
            丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32, y = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32 + 4});
            丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_63, g = val_63, b = val_63, a = val_63});
            val_65 = val_65 + 1;
            val_66 = val_66 + 8;
        }
        while(val_65 != 4);
        
        }
        
        val_67 = val_67 + 1;
        if(val_67 != 2)
        {
            goto label_201;
        }
        
        return;
        label_181:
    }
    private void 丅丞丞下不三丈上丂(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        UnityEngine.Object val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_40;
        UIBasicSprite val_41;
        var val_42;
        var val_43;
        float val_44;
        float val_45;
        float val_46;
        float val_48;
        var val_49;
        float val_50;
        float val_51;
        float val_52;
        var val_53;
        UnityEngine.Vector2[] val_54;
        var val_55;
        var val_56;
        float val_57;
        var val_58;
        float val_59;
        float val_60;
        float val_61;
        var val_62;
        var val_63;
        val_32 = this;
        if(this == 0)
        {
                return;
        }
        
        val_33 = V0.16B;
        val_34 = V0.16B;
        UnityEngine.Vector4 val_2 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = val_33, y = V1.16B, z = V2.16B, w = V3.16B}, d:  val_34);
        val_35 = val_2.x;
        if((((val_2.w == 0f) && (val_2.z == 0f)) && (val_35 == 0f)) && (val_2.y == 0f))
        {
                this.世丘万三丑上丙丗丗(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘);
            return;
        }
        
        UnityEngine.Color32 val_3 = this.世丕丅丞丂丏丄丏三();
        byte val_34 = val_3.r;
        val_36 = val_2.y;
        float val_28 = 1.152922E+18f;
        float val_29 = 1.152922E+18f;
        val_28 = val_2.x * val_28;
        val_29 = val_2.x * val_29;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_28, y:  val_29);
        val_34 = val_28;
        val_37 = val_4.y;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_37}, d:  val_34);
        val_38 = 1f;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_20 = val_2.x;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_24 = val_36;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_38 = val_2.z;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_3C = val_2.w;
        var val_30 = mem[1152921535221980520];
        val_30 = val_30 | 2;
        if(val_30 != 3)
        {
            goto label_27;
        }
        
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = val_2.z + (UIBasicSprite.万万丂三专丞丆专丏 + 32);
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = (UIBasicSprite.万万丂三专丞丆专丏 + 56) - val_35;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_38 = x;
        float val_9 = this.丅丘三一与丑丛丑东.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = val_9;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = val_9;
        if(UIBasicSprite.万丘丁丝丏世丂业专.Length != 0)
        {
            goto label_46;
        }
        
        goto label_46;
        label_27:
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_28 = val_35 + (UIBasicSprite.万万丂三专丞丆专丏 + 32);
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_30 = (UIBasicSprite.万万丂三专丞丆专丏 + 56) - val_2.z;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_20 = x;
        float val_13 = this.丅丘三一与丑丛丑东.x;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_28 = val_13;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_30 = val_13;
        label_46:
        mem2[0] = val_13;
        var val_31 = mem[1152921535221980520];
        val_31 = val_31 & 4294967294;
        if(val_31 != 2)
        {
            goto label_65;
        }
        
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        float val_32 = val_2.w;
        val_32 = val_32 + (UIBasicSprite.万万丂三专丞丆专丏 + 36);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = val_32;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        val_40 = (UIBasicSprite.万万丂三专丞丆专丏 + 60) - val_2.y;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = val_40;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_3C = val_40;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = val_40;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = val_40;
        val_41 = this;
        val_33 = val_40;
        if(UIBasicSprite.万丘丁丝丏世丂业专.Length != 0)
        {
            goto label_84;
        }
        
        goto label_84;
        label_65:
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        float val_33 = val_2.y;
        val_33 = val_33 + (UIBasicSprite.万万丂三专丞丆专丏 + 36);
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_2C = val_33;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
            goto label_92;
        }
        
        }
        
        val_40 = (UIBasicSprite.万万丂三专丞丆专丏 + 60) - val_2.w;
        UIBasicSprite.万万丂三专丞丆专丏.__unknownFiledOffset_34 = val_40;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_24 = val_40;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_2C = val_40;
        UIBasicSprite.万丘丁丝丏世丂业专.__unknownFiledOffset_34 = val_40;
        val_41 = this;
        val_33 = val_40;
        label_84:
        mem2[0] = val_33;
        val_32 = 1152921504838422528;
        val_42 = 0;
        val_34 = val_34 & 4294967295;
        label_278:
        label_277:
        if((0 == 1) && (val_42 == 1))
        {
                if(mem[1152921535221980556] == 0)
        {
            goto label_277;
        }
        
        }
        
        if((val_42 != 1) || (0 != 1))
        {
            goto label_107;
        }
        
        if(mem[1152921535221980556] == 1)
        {
            goto label_108;
        }
        
        if(mem[1152921535221980556] != 2)
        {
            goto label_258;
        }
        
        int val_35 = UIBasicSprite.万万丂三专丞丆专丏.Length;
        val_35 = val_35 & 4294967294;
        val_34 = 8.96831E-44f;
        int val_36 = UIBasicSprite.万万丂三专丞丆专丏.Length;
        val_36 = val_36 & 4294967294;
        int val_37 = UIBasicSprite.万丘丁丝丏世丂业专.Length;
        val_37 = val_37 & 4294967294;
        int val_38 = UIBasicSprite.万丘丁丝丏世丂业专.Length;
        val_38 = val_38 & 4294967294;
        if((UIBasicSprite.万万丂三专丞丆专丏 + 44) >= 0)
        {
            goto label_258;
        }
        
        do
        {
            val_33 = 1f;
            float val_39 = UIBasicSprite.万万丂三专丞丆专丏 + 44;
            val_39 = val_39 + val_33;
            if(val_39 > 0f)
        {
                float val_40 = UIBasicSprite.万万丂三专丞丆专丏 + 44;
            val_40 = 0f - val_40;
        }
        
            if((UIBasicSprite.万万丂三专丞丆专丏 + 40) < 0)
        {
                float val_41 = UIBasicSprite.万万丂三专丞丆专丏 + 40;
            do
        {
            val_36 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 32];
            val_36 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32;
            if((val_41 + 1f) > val_34)
        {
                val_36 = UnityEngine.Mathf.Lerp(a:  UIBasicSprite.万丘丁丝丏世丂业专 + 40, b:  val_36, t:  (val_34 - val_41) / 1f);
        }
        
            UnityEngine.Color val_20 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_34, g = val_34, b = val_34, a = val_34});
            val_35 = val_20.r;
            UIBasicSprite.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘, 且三不丆丟丙丝丝万:  val_41, 不丄丒一上丏七丏丗:  val_34, 上七丆一与丄丝丝丛:  UIBasicSprite.万万丂三专丞丆专丏 + 44, 东丒上丌不丙丒不业:  0f, 丏与丈世上丐丑丕丒:  UIBasicSprite.万丘丁丝丏世丂业专 + 40, 丒丁丁丕且丌与丞东:  val_36, 七丂下三专世丁一万:  UIBasicSprite.万丘丁丝丏世丂业专 + 44, 丈丟丗一丟丕万丂专:  UnityEngine.Mathf.Lerp(a:  UIBasicSprite.万丘丁丝丏世丂业专 + 44, b:  UIBasicSprite.万丘丁丝丏世丂业专.Length + 36, t:  val_40 / val_33), 丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = val_35, g = val_20.b, a = 3.487385E-19f});
            val_33 = 1f;
            val_41 = val_41 + val_33;
        }
        while(val_41 < 0);
        
        }
        
            float val_42 = UIBasicSprite.万万丂三专丞丆专丏 + 44;
            val_42 = val_42 + 1f;
        }
        while(val_42 < 0);
        
        goto label_258;
        label_107:
        if(val_42 != 1)
        {
            goto label_145;
        }
        
        if(0 == 2)
        {
            goto label_146;
        }
        
        if(0 != 0)
        {
            goto label_258;
        }
        
        if(mem[1152921535221980568] != 0)
        {
            goto label_148;
        }
        
        goto label_258;
        label_145:
        if(0 == 0)
        {
            goto label_150;
        }
        
        if(0 == 2)
        {
            goto label_151;
        }
        
        if(0 != 1)
        {
            goto label_207;
        }
        
        if(val_42 == 2)
        {
            goto label_153;
        }
        
        if(val_42 != 0)
        {
            goto label_258;
        }
        
        val_43 = mem[1152921535221980560];
        if(val_43 != 0)
        {
            goto label_155;
        }
        
        goto label_258;
        label_108:
        int val_43 = UIBasicSprite.万万丂三专丞丆专丏.Length;
        val_43 = val_43 & 4294967294;
        val_33 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 40];
        val_33 = UIBasicSprite.万万丂三专丞丆专丏 + 40;
        val_44 = 8.96831E-44f;
        int val_44 = UIBasicSprite.万万丂三专丞丆专丏.Length;
        val_44 = val_44 & 4294967294;
        val_35 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 44];
        val_35 = UIBasicSprite.万万丂三专丞丆专丏 + 44;
        val_45 = 0f;
        int val_45 = UIBasicSprite.万丘丁丝丏世丂业专.Length;
        val_45 = val_45 & 4294967294;
        val_34 = mem[UIBasicSprite.万丘丁丝丏世丂业专 + 40];
        val_34 = UIBasicSprite.万丘丁丝丏世丂业专 + 40;
        val_46 = 8.96831E-44f;
        int val_46 = UIBasicSprite.万丘丁丝丏世丂业专.Length;
        val_46 = val_46 & 4294967294;
        val_36 = mem[UIBasicSprite.万丘丁丝丏世丂业专 + 44];
        val_36 = UIBasicSprite.万丘丁丝丏世丂业专 + 44;
        if(1 < UIBasicSprite.万丘丁丝丏世丂业专.Length)
        {
            goto label_175;
        }
        
        goto label_175;
        label_146:
        if(mem[1152921535221980572] == 0)
        {
            goto label_258;
        }
        
        label_148:
        if(mem[1152921535221980572] != 2)
        {
            goto label_177;
        }
        
        int val_47 = UIBasicSprite.万万丂三专丞丆专丏.Length;
        val_47 = val_47 & 4294967294;
        val_33 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 40];
        val_33 = UIBasicSprite.万万丂三专丞丆专丏 + 40;
        int val_48 = UIBasicSprite.万丘丁丝丏世丂业专.Length;
        val_48 = val_48 & 4294967294;
        if(val_33 >= 0)
        {
            goto label_258;
        }
        
        val_48 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 36];
        val_48 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 36;
        do
        {
            val_49 = null;
            val_49 = null;
            val_50 = val_33 + 1f;
            val_36 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 32];
            val_36 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 32;
            if(val_50 > (8.96831E-44f))
        {
                val_51 = ((8.96831E-44f) - val_33) / 1f;
            val_48 = UIBasicSprite.万丘丁丝丏世丂业专 + 40;
            val_52 = val_36;
            val_36 = UnityEngine.Mathf.Lerp(a:  val_48, b:  val_52, t:  val_51);
            val_50 = 8.96831E-44f;
        }
        
            UnityEngine.Color val_23 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_34, g = val_34, b = val_34, a = val_34});
            val_35 = val_23.g;
            val_34 = val_23.b;
            UIBasicSprite.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘, 且三不丆丟丙丝丝万:  val_33, 不丄丒一上丏七丏丗:  val_50, 上七丆一与丄丝丝丛:  0f, 东丒上丌不丙丒不业:  0f, 丏与丈世上丐丑丕丒:  UIBasicSprite.万丘丁丝丏世丂业专 + 40, 丒丁丁丕且丌与丞东:  val_36, 七丂下三专世丁一万:  0f, 丈丟丗一丟丕万丂专:  val_48, 丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = val_23.r, g = val_34, a = 3.487385E-19f});
            val_33 = val_33 + 1f;
        }
        while(val_33 < 0);
        
        goto label_258;
        label_150:
        if(mem[1152921535221980568] != 0)
        {
            goto label_230;
        }
        
        goto label_207;
        label_151:
        if(mem[1152921535221980572] != 0)
        {
            goto label_230;
        }
        
        label_207:
        if(val_42 == 2)
        {
            goto label_209;
        }
        
        if(val_42 != 0)
        {
            goto label_258;
        }
        
        if(mem[1152921535221980560] != 0)
        {
            goto label_230;
        }
        
        goto label_258;
        label_177:
        val_53 = null;
        val_53 = null;
        int val_49 = UIBasicSprite.万万丂三专丞丆专丏.Length;
        val_49 = val_49 & 4294967294;
        val_33 = mem[UIBasicSprite.万万丂三专丞丆专丏 + 40];
        val_33 = UIBasicSprite.万万丂三专丞丆专丏 + 40;
        val_44 = 8.96831E-44f;
        val_35 = 0f;
        val_45 = 0f;
        int val_50 = UIBasicSprite.万丘丁丝丏世丂业专.Length;
        val_50 = val_50 & 4294967294;
        val_34 = mem[UIBasicSprite.万丘丁丝丏世丂业专 + 40];
        val_34 = UIBasicSprite.万丘丁丝丏世丂业专 + 40;
        val_54 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_54 != null)
        {
            goto label_271;
        }
        
        goto label_226;
        label_209:
        if(mem[1152921535221980564] != 0)
        {
            goto label_230;
        }
        
        goto label_258;
        label_153:
        val_43 = mem[1152921535221980564];
        if(val_43 == 0)
        {
            goto label_258;
        }
        
        label_155:
        if(val_43 != 2)
        {
            goto label_230;
        }
        
        val_55 = null;
        val_55 = null;
        val_56 = val_42;
        if(0 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_56 = val_42;
        }
        
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                val_56 = val_42;
        }
        
        if(1 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_56 = val_42;
        }
        
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                val_56 = val_42;
        }
        
        if(0 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_56 = val_42;
        }
        
        val_35 = 0f;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                val_56 = val_42;
        }
        
        if(1 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_56 = val_42;
        }
        
        if(UIBasicSprite.万丘丁丝丏世丂业专 == null)
        {
                val_56 = val_42;
        }
        
        if(0 >= UIBasicSprite.万丘丁丝丏世丂业专.Length)
        {
                val_56 = val_42;
        }
        
        if(val_35 >= 0)
        {
            goto label_258;
        }
        
        val_57 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 36];
        val_57 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 36;
        do
        {
            val_58 = null;
            val_58 = null;
            val_36 = mem[UIBasicSprite.万丘丁丝丏世丂业专.Length + 36];
            val_36 = UIBasicSprite.万丘丁丝丏世丂业专.Length + 36;
            val_59 = val_35 + 1f;
            if(val_59 > 0f)
        {
                val_60 = (0f - val_35) / 1f;
            val_57 = val_57;
            val_61 = val_36;
            val_36 = UnityEngine.Mathf.Lerp(a:  val_57, b:  val_61, t:  val_60);
            val_59 = 0f;
        }
        
            UnityEngine.Color val_26 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_34, g = val_34, b = val_34, a = val_34});
            val_33 = val_26.r;
            val_34 = val_26.a;
            UIBasicSprite.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘, 且三不丆丟丙丝丝万:  8.96831E-44f, 不丄丒一上丏七丏丗:  8.96831E-44f, 上七丆一与丄丝丝丛:  val_35, 东丒上丌不丙丒不业:  val_59, 丏与丈世上丐丑丕丒:  8.96831E-44f, 丒丁丁丕且丌与丞东:  8.96831E-44f, 七丂下三专世丁一万:  val_57, 丈丟丗一丟丕万丂专:  val_36, 丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = val_33, g = val_26.b, a = 3.487385E-19f});
            val_35 = val_35 + 1f;
        }
        while(val_35 < 0);
        
        goto label_258;
        label_230:
        val_62 = null;
        val_62 = null;
        val_63 = val_42;
        if(0 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_63 = val_42;
        }
        
        val_33 = 8.96831E-44f;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                val_63 = val_42;
        }
        
        if(1 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_63 = val_42;
        }
        
        val_44 = 8.96831E-44f;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                val_63 = val_42;
        }
        
        if(0 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_63 = val_42;
        }
        
        val_35 = 0f;
        if(UIBasicSprite.万万丂三专丞丆专丏 == null)
        {
                val_63 = val_42;
        }
        
        if(1 >= UIBasicSprite.万万丂三专丞丆专丏.Length)
        {
                val_63 = val_42;
        }
        
        val_45 = 0f;
        if(UIBasicSprite.万丘丁丝丏世丂业专 == null)
        {
                val_63 = val_42;
        }
        
        if(0 >= UIBasicSprite.万丘丁丝丏世丂业专.Length)
        {
                val_63 = val_42;
        }
        
        val_34 = 8.96831E-44f;
        val_54 = UIBasicSprite.万丘丁丝丏世丂业专;
        if(val_54 != null)
        {
            goto label_271;
        }
        
        label_226:
        label_271:
        val_46 = 8.96831E-44f;
        val_36 = 0f;
        label_175:
        UnityEngine.Color val_27 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_34, g = val_34, b = val_34, a = val_34});
        UIBasicSprite.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘, 且三不丆丟丙丝丝万:  val_33, 不丄丒一上丏七丏丗:  val_44, 上七丆一与丄丝丝丛:  val_35, 东丒上丌不丙丒不业:  val_45, 丏与丈世上丐丑丕丒:  val_34, 丒丁丁丕且丌与丞东:  val_46, 七丂下三专世丁一万:  val_36, 丈丟丗一丟丕万丂专:  UIBasicSprite.万丘丁丝丏世丂业专.Length + 36, 丆丛丂丝丄世且丛丕:  new UnityEngine.Color() {r = val_27.r, g = val_27.b, a = 3.487385E-19f});
        label_258:
        if(1 != 3)
        {
            goto label_277;
        }
        
        if(1 != 3)
        {
            goto label_278;
        }
        
        return;
        label_92:
    }
    private static bool 且且丛东丌丅东丗专(UnityEngine.Vector2[] 三丗万世丅丌丏丄丅, UnityEngine.Vector2[] 丌丌丁专与东丌丗且, float 一丝丟丈丛丑丂与一, bool 丝业丈不丙丄丝一一, int 丅东下丄丏且三丆丘)
    {
        float val_4;
        var val_5;
        bool val_4 = 丝业丈不丙丄丝一一;
        val_4 = 一丝丟丈丛丑丂与一;
        if(val_4 < 0)
        {
            goto label_1;
        }
        
        val_4 = (丅东下丄丏且三丆丘 & 1) ^ val_4;
        if(val_4 > 0.999f)
        {
                if((val_4 & 1) == 0)
        {
            goto label_3;
        }
        
        }
        
        float val_2 = UnityEngine.Mathf.Clamp01(value:  val_4);
        float val_5 = 1f;
        val_5 = val_5 - val_2;
        val_2 = (val_4 != 1) ? (val_5) : (val_2);
        float val_3 = val_2 * 1.570796f;
        val_4 = val_3;
        val_4 = val_4 & 1;
        UIBasicSprite.且且丛东丌丅东丗专(三丗万世丅丌丏丄丅:  三丗万世丅丌丏丄丅, 业丘丁万丛一丐万丗:  val_4, 世丝与丂丛丒丛一丅:  val_3, 丝业丈不丙丄丝一一:  val_4, 丅东下丄丏且三丆丘:  丅东下丄丏且三丆丘);
        UIBasicSprite.且且丛东丌丅东丗专(三丗万世丅丌丏丄丅:  丌丌丁专与东丌丗且, 业丘丁万丛一丐万丗:  val_4, 世丝与丂丛丒丛一丅:  val_3, 丝业丈不丙丄丝一一:  val_4, 丅东下丄丏且三丆丘:  丅东下丄丏且三丆丘);
        label_3:
        val_5 = 1;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
    }
    private static void 且且丛东丌丅东丗专(UnityEngine.Vector2[] 三丗万世丅丌丏丄丅, float 业丘丁万丛一丐万丗, float 世丝与丂丛丒丛一丅, bool 丝业丈不丙丄丝一一, int 丅东下丄丏且三丆丘)
    {
        var val_17;
        float val_18;
        float val_19;
        float val_20;
        int val_21;
        UnityEngine.Vector2 val_22;
        int val_24;
        var val_25;
        int val_26;
        int val_28;
        float val_29;
        int val_30;
        int val_31;
        int val_32;
        int val_33;
        var val_34;
        UnityEngine.Vector2 val_35;
        var val_36;
        int val_2 = 万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  丅东下丄丏且三丆丘 + 1, 七丝东丛东丝且丆不:  4);
        int val_4 = 万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  丅东下丄丏且三丆丘 + 2, 七丝东丛东丝且丆不:  4);
        val_17 = 万丗丅且丄丑世专与.与丗丝丒丈丄不与且(下下丏一丙不丘丌丞:  丅东下丄丏且三丆丘 + 3, 七丝东丛东丝且丆不:  4);
        if((丅东下丄丏且三丆丘 & 1) != 0)
        {
            goto label_1;
        }
        
        if(业丘丁万丛一丐万丗 <= 世丝与丂丛丒丛一丅)
        {
            goto label_2;
        }
        
        val_18 = 世丝与丂丛丒丛一丅 / 业丘丁万丛一丐万丗;
        if(丝业丈不丙丄丝一一 == false)
        {
            goto label_3;
        }
        
        val_19 = 1f;
        if(三丗万世丅丌丏丄丅 != null)
        {
            goto label_53;
        }
        
        goto label_53;
        label_1:
        if(世丝与丂丛丒丛一丅 <= 业丘丁万丛一丐万丗)
        {
            goto label_6;
        }
        
        val_20 = 业丘丁万丛一丐万丗 / 世丝与丂丛丒丛一丅;
        if(丝业丈不丙丄丝一一 == false)
        {
            goto label_7;
        }
        
        val_21 = 三丗万世丅丌丏丄丅.Length;
        if(val_21 <= 丅东下丄丏且三丆丘)
        {
                val_21 = 三丗万世丅丌丏丄丅.Length;
        }
        
        float val_7 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[(long)val_4], t:  val_20);
        三丗万世丅丌丏丄丅[(long)val_2] = val_7;
        val_24 = 三丗万世丅丌丏丄丅.Length;
        if(val_2 >= val_24)
        {
            goto label_14;
        }
        
        val_25 = val_7;
        goto label_15;
        label_2:
        val_18 = 1f;
        if(世丝与丂丛丒丛一丅 <= 业丘丁万丛一丐万丗)
        {
            goto label_16;
        }
        
        val_19 = 业丘丁万丛一丐万丗 / 世丝与丂丛丒丛一丅;
        if(丝业丈不丙丄丝一一 == false)
        {
            goto label_17;
        }
        
        val_26 = 三丗万世丅丌丏丄丅.Length;
        if(val_26 <= 丅东下丄丏且三丆丘)
        {
                val_26 = 三丗万世丅丌丏丄丅.Length;
        }
        
        float val_8 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[(long)val_4], t:  val_19);
        mem2[0] = val_8;
        val_28 = 三丗万世丅丌丏丄丅.Length;
        if(val_4 >= val_28)
        {
            goto label_24;
        }
        
        val_22 = val_8;
        goto label_25;
        label_6:
        val_20 = 1f;
        if(业丘丁万丛一丐万丗 <= 世丝与丂丛丒丛一丅)
        {
            goto label_26;
        }
        
        val_29 = 世丝与丂丛丒丛一丅 / 业丘丁万丛一丐万丗;
        if(丝业丈不丙丄丝一一 == true)
        {
            goto label_27;
        }
        
        val_30 = 三丗万世丅丌丏丄丅.Length;
        if(val_30 <= 丅东下丄丏且三丆丘)
        {
                val_30 = 三丗万世丅丌丏丄丅.Length;
        }
        
        float val_9 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[(long)val_4], t:  val_29);
        mem2[0] = val_9;
        val_31 = 三丗万世丅丌丏丄丅.Length;
        if(val_4 >= val_31)
        {
            goto label_34;
        }
        
        val_22 = val_9;
        goto label_35;
        label_3:
        val_32 = 三丗万世丅丌丏丄丅.Length;
        if(val_32 <= 丅东下丄丏且三丆丘)
        {
                val_32 = 三丗万世丅丌丏丄丅.Length;
        }
        
        float val_10 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[(long)val_4], t:  val_18);
        三丗万世丅丌丏丄丅[(long)val_2] = val_10;
        val_33 = 三丗万世丅丌丏丄丅.Length;
        if(val_2 >= val_33)
        {
            goto label_42;
        }
        
        val_34 = val_10;
        goto label_43;
        label_7:
        val_29 = 1f;
        label_27:
        if(三丗万世丅丌丏丄丅 != null)
        {
            goto label_51;
        }
        
        goto label_51;
        label_16:
        val_19 = val_18;
        label_17:
        if(三丗万世丅丌丏丄丅 != null)
        {
            goto label_53;
        }
        
        goto label_53;
        label_26:
        val_29 = val_20;
        if(三丗万世丅丌丏丄丅 != null)
        {
            goto label_51;
        }
        
        goto label_51;
        label_14:
        val_25 = mem[三丗万世丅丌丏丄丅[(long)(int)(val_2)] + 32];
        val_25 = 三丗万世丅丌丏丄丅[(long)(int)(val_2)] + 32;
        val_24 = 三丗万世丅丌丏丄丅.Length;
        label_15:
        mem2[0] = val_25;
        val_29 = 1f;
        goto label_51;
        label_42:
        val_34 = mem[三丗万世丅丌丏丄丅[(long)(int)(val_2)] + 36];
        val_34 = 三丗万世丅丌丏丄丅[(long)(int)(val_2)] + 36;
        val_33 = 三丗万世丅丌丏丄丅.Length;
        label_43:
        mem2[0] = val_34;
        val_19 = 1f;
        goto label_53;
        label_24:
        val_22 = mem[三丗万世丅丌丏丄丅[(long)(int)(val_4)] + 32];
        val_22 = 三丗万世丅丌丏丄丅[(long)(int)(val_4)] + 32;
        val_28 = 三丗万世丅丌丏丄丅.Length;
        label_25:
        val_18 = 1f;
        三丗万世丅丌丏丄丅[(long)val_17] = val_22;
        label_53:
        if(丝业丈不丙丄丝一一 == false)
        {
            goto label_56;
        }
        
        val_35 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[(long)val_4], t:  val_18);
        val_36 = (long)val_17;
        if(val_17 >= 三丗万世丅丌丏丄丅.Length)
        {
            goto label_60;
        }
        
        goto label_73;
        label_56:
        val_17 = (long)val_4;
        val_35 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[val_17], t:  val_19);
        if(val_2 < 三丗万世丅丌丏丄丅.Length)
        {
            goto label_78;
        }
        
        label_77:
        label_78:
        三丗万世丅丌丏丄丅[(long)val_2] = val_35;
        return;
        label_34:
        val_22 = mem[三丗万世丅丌丏丄丅[(long)(int)(val_4)] + 36];
        val_22 = 三丗万世丅丌丏丄丅[(long)(int)(val_4)] + 36;
        val_31 = 三丗万世丅丌丏丄丅.Length;
        label_35:
        val_20 = 1f;
        三丗万世丅丌丏丄丅[(long)val_17] = val_22;
        label_51:
        if(丝业丈不丙丄丝一一 == false)
        {
            goto label_69;
        }
        
        val_17 = (long)val_4;
        val_35 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[val_17], t:  val_29);
        val_36 = (long)val_2;
        if(val_2 < 三丗万世丅丌丏丄丅.Length)
        {
            goto label_73;
        }
        
        label_60:
        label_73:
        三丗万世丅丌丏丄丅[val_36] = val_35;
        return;
        label_69:
        float val_14 = UnityEngine.Mathf.Lerp(a:  三丗万世丅丌丏丄丅[(long)丅东下丄丏且三丆丘], b:  三丗万世丅丌丏丄丅[(long)val_4], t:  val_20);
        if(val_17 >= 三丗万世丅丌丏丄丅.Length)
        {
            goto label_77;
        }
        
        goto label_78;
    }
    private static void 上东与丛丞下丈专丈(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘, float 且三不丆丟丙丝丝万, float 不丄丒一上丏七丏丗, float 上七丆一与丄丝丝丛, float 东丒上丌不丙丒不业, float 丏与丈世上丐丑丕丒, float 丒丁丁丕且丌与丞东, float 七丂下三专世丁一万, float 丈丟丗一丟丕万丂专, UnityEngine.Color 丆丛丂丝丄世且丛丕)
    {
        float val_4;
        float val_5;
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  丏与丈世上丐丑丕丒, y:  七丂下三专世丁一万);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  丏与丈世上丐丑丕丒, y:  丈丟丗一丟丕万丂专);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  丒丁丁丕且丌与丞东, y:  丈丟丗一丟丕万丂专);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  丒丁丁丕且丌与丞东, y:  七丂下三专世丁一万);
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 丆丛丂丝丄世且丛丕.r, g = val_5, b = 丆丛丂丝丄世且丛丕.g, a = val_4});
        丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_7.r & 4294967295, g = val_7.r & 4294967295, b = val_7.r & 4294967295, a = val_7.r & 4294967295});
        UnityEngine.Color32 val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 丆丛丂丝丄世且丛丕.r, g = val_5, b = 丆丛丂丝丄世且丛丕.g, a = val_4});
        丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_9.r & 4294967295, g = val_9.r & 4294967295, b = val_9.r & 4294967295, a = val_9.r & 4294967295});
        UnityEngine.Color32 val_11 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 丆丛丂丝丄世且丛丕.r, g = val_5, b = 丆丛丂丝丄世且丛丕.g, a = val_4});
        丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_11.r & 4294967295, g = val_11.r & 4294967295, b = val_11.r & 4294967295, a = val_11.r & 4294967295});
        UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 丆丛丂丝丄世且丛丕.r, g = val_5, b = 丆丛丂丝丄世且丛丕.g, a = val_4});
        丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = val_13.r & 4294967295, g = val_13.r & 4294967295, b = val_13.r & 4294967295, a = val_13.r & 4294967295});
    }
    protected UIBasicSprite()
    {
        mem2[0] = 4;
        mem2[0] = 1;
        this.topType = 1;
    }
    private static UIBasicSprite()
    {
        UIBasicSprite.万万丂三专丞丆专丏 = new UnityEngine.Vector2[4];
        UIBasicSprite.万丘丁丝丏世丂业专 = new UnityEngine.Vector2[4];
    }

}
