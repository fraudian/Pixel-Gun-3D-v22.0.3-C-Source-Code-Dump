using UnityEngine;
public class UILabel : UIWidget
{
    // Fields
    public UILabel.丗上丒上三丞下不丌 keepCrispWhenShrunk;
    private UnityEngine.Font mTrueTypeFont;
    public bool nickNameValidator;
    private UIFont mFont;
    private string mText;
    private int mFontSize;
    private UnityEngine.FontStyle mFontStyle;
    private 丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 mAlignment;
    private bool mEncoding;
    private int mMaxLineCount;
    private UILabel.东丗一且与丑与丈且 mEffectStyle;
    private UnityEngine.Color mEffectColor;
    private 丐丄七丙丁丆丁专丏.不丛东一上丟业丑一 mSymbols;
    private UnityEngine.Vector2 mEffectDistance;
    private UILabel.丐丏上丂丐丂丝世丐 mOverflow;
    private UnityEngine.Material mMaterial;
    private bool mApplyGradient;
    private UnityEngine.Color mGradientTop;
    private UnityEngine.Color mGradientBottom;
    private int mSpacingX;
    private int mSpacingY;
    private bool mUseFloatSpacing;
    private float mFloatSpacingX;
    private float mFloatSpacingY;
    private bool mOverflowEllipsis;
    private bool neverActLikeOutline8;
    private bool mShrinkToFit;
    private int mMaxLineWidth;
    private int mMaxLineHeight;
    private float mLineWidth;
    private bool mMultiline;
    private UnityEngine.Font 丕丌丈丛丑丙丂丕丝;
    private float 业丒丙三丑丈丄业专;
    private bool 丁丛下专丗丁丞万上;
    private string 下丑丞上与丄下丙东;
    private bool 且丟且丏一丑三丑丆;
    private UnityEngine.Vector2 丆丛丟专丒丞丕丟丑;
    private float 丟丕世万七且万丌丈;
    private int 丛丆丛丕丏丙丛不丄;
    private int 丒丘丞丏丙丒上与下;
    private int 专业丁丆不东丙丞不;
    private System.Collections.Generic.List<UILabel> copyTo;
    private static 丒丞丕丕七丁丗丟丛<UILabel> 丟丂与东业专三丕丏;
    private static System.Collections.Generic.Dictionary<UnityEngine.Font, int> 丕丐七丂三专三丕丐;
    private static System.Collections.Generic.List<UIDrawCall> 三专万不丏一丆丑丆;
    private static bool 一且丅丏丆丂丐丘丗;
    private static 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丕丙丒丘丈丞丙丒业;
    private static 丒丞丕丕七丁丗丟丛<int> 三丁丙丘上丆丑且东;
    private static 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丈丆不万丟且东七且;
    private static 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 七业丐丆东丁东且与;
    private static 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丆丒丛一业不世丞下;
    
    // Properties
    public int 丟不与专丝一丐三与 { get; }
    private bool 丞丈丂丛一丄且丞且 { get; set; }
    public override bool 不丄丄东专丌丆一丐 { get; }
    public override bool 业丕丁下世与万三丑 { get; }
    public override UnityEngine.Material 丘上专不丂万业不一 { get; set; }
    public UIFont 丂一丂丗与丟业丆丙 { get; set; }
    public UIFont 丝万业丏丐丈世专丁 { get; set; }
    public UnityEngine.Font 丁丁一丏专且丆丄丑 { get; set; }
    public UnityEngine.Object 一一丝专丝丏丅丟丞 { get; set; }
    public string 丕丗丘丑丛与丑业丒 { get; set; }
    public int 丒且一专丕世丈与丈 { get; }
    public int 东丈丝丌丑丈丛丐丅 { get; set; }
    public UnityEngine.FontStyle 东业丏专丛丁与丙丒 { get; set; }
    public 丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 世丕七丑丑丟不丙丏 { get; set; }
    public bool 东上万专三东丞丑丙 { get; set; }
    public UnityEngine.Color 三世丂丑丂且专三丘 { get; set; }
    public UnityEngine.Color 丒丂丑七丞丞丏丂丆 { get; set; }
    public int 丅丑世丈东丛丈丑三 { get; set; }
    public int 上业丞且丆丏丘与三 { get; set; }
    public bool 丏上七丁丈专丝丁丂 { get; set; }
    public float 丑下丅一丆丟三东丘 { get; set; }
    public float 丌与丐丕下丟且丒业 { get; set; }
    public float 世丒丒下丑七万世丐 { get; }
    public float 丑下上三丂丘丈丐丌 { get; }
    public bool 丕与丂业上丗世丌丁 { get; set; }
    private bool 三与不万一丝七丁丒 { get; }
    public bool 丄丘上丞丕一七丈不 { get; set; }
    public 丐丄七丙丁丆丁专丏.不丛东一上丟业丑一 七一上丘万东丕世丘 { get; set; }
    public UILabel.丐丏上丂丐丂丝世丐 七专丛世丟丂丘丈丝 { get; set; }
    public int 东丛七一丘东丝丙丗 { get; set; }
    public int 丂东下万且专丗专丁 { get; set; }
    public bool 丈丟丞丞丕一丌丆丟 { get; set; }
    public override UnityEngine.Vector3[] 丝下丒丙丂万丆丞业 { get; }
    public override UnityEngine.Vector3[] 丈丞上三七丌丑业丛 { get; }
    public override UnityEngine.Vector4 丈丅且丛丑丞万丁丝 { get; }
    public int 丌下丈丙世丄万不丂 { get; set; }
    public UILabel.东丗一且与丑与丈且 七丐丞世世丟丙与丏 { get; set; }
    public UnityEngine.Color 丌丆三一与业一丘丝 { get; set; }
    public UnityEngine.Vector2 丝上上三丈一丏丌丈 { get; set; }
    public bool 且丂丒业丕丅东世七 { get; set; }
    public string 七丗东丟与下丙丁丒 { get; }
    public UnityEngine.Vector2 东且不丂丄专一丌东 { get; }
    public override UnityEngine.Vector2 丟丘丞丟世东丒丟丅 { get; }
    private bool 丕且七业丙万丕丛丞 { get; }
    
    // Methods
    public int get_finalFontSize()
    {
        int val_4;
        float val_5;
        float val_6;
        val_4 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.trueTypeFont)) != false)
        {
                val_5 = this.丟丕世万七且万丌丈;
            val_4 = this.丛丆丛丕丏丙丛不丄;
            val_6 = (float)val_4;
            return UnityEngine.Mathf.RoundToInt(f:  val_6 * val_5);
        }
        
        val_6 = this.丟丕世万七且万丌丈;
        val_5 = (float)this.丛丆丛丕丏丙丛不丄;
        return UnityEngine.Mathf.RoundToInt(f:  val_6 * val_5);
    }
    private bool 丅七不丛丒专一七下()
    {
        return (bool)this.丁丛下专丗丁丞万上;
    }
    private void 上丆丙丗丛丄丂东丅(bool 丙业与丙丗丝不丈东)
    {
        bool val_1;
        if(丙业与丙丗丝不丈东 != false)
        {
                val_1 = 1;
            mem[1152921535325935912] = val_1;
        }
        else
        {
                val_1 = false;
        }
        
        this.丁丛下专丗丁丞万上 = val_1;
    }
    public override bool get_isAnchoredHorizontally()
    {
        var val_3;
        if(this.isAnchoredHorizontally == false)
        {
                return (bool)(this.mOverflow == 2) ? 1 : 0;
        }
        
        val_3 = 1;
        return (bool)(this.mOverflow == 2) ? 1 : 0;
    }
    public override bool get_isAnchoredVertically()
    {
        var val_3;
        if(this.isAnchoredVertically != false)
        {
                val_3 = 1;
            return (bool)(val_3 == 3) ? 1 : 0;
        }
        
        丐丏上丂丐丂丝世丐 val_3 = this.mOverflow;
        val_3 = val_3 | 1;
        return (bool)(val_3 == 3) ? 1 : 0;
    }
    public override UnityEngine.Material get_material()
    {
        if(this.mMaterial != 0)
        {
                return (UnityEngine.Material)this.mMaterial;
        }
        
        if(this.mFont != 0)
        {
                if(this.mFont != null)
        {
                return this.mFont.material;
        }
        
            return this.mFont.material;
        }
        
        if(this.mTrueTypeFont == 0)
        {
                return (UnityEngine.Material)this.mMaterial;
        }
        
        if(this.mTrueTypeFont != null)
        {
                return this.mTrueTypeFont.material;
        }
        
        return this.mTrueTypeFont.material;
    }
    public override void set_material(UnityEngine.Material 丙业与丙丗丝不丈东)
    {
        UnityEngine.Material val_7 = 丙业与丙丗丝不丈东;
        if(this.mMaterial == val_7)
        {
                return;
        }
        
        this.RemoveFromPanel();
        this.mMaterial = val_7;
        val_7 = ???;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public UIFont get_font()
    {
        return (UIFont)this.mFont;
    }
    public void set_font(UIFont 丙业与丙丗丝不丈东)
    {
        this.bitmapFont = 丙业与丙丗丝不丈东;
    }
    public UIFont get_bitmapFont()
    {
        return (UIFont)this.mFont;
    }
    public void set_bitmapFont(UIFont 丙业与丙丗丝不丈东)
    {
        UIFont val_7 = 丙业与丙丗丝不丈东;
        if(this.mFont == val_7)
        {
                return;
        }
        
        this.RemoveFromPanel();
        this.mFont = val_7;
        this.mTrueTypeFont = 0;
        val_7 = ???;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public UnityEngine.Font get_trueTypeFont()
    {
        UnityEngine.Font val_3;
        if(this.mTrueTypeFont != 0)
        {
                val_3 = this.mTrueTypeFont;
            return val_3;
        }
        
        val_3 = 0;
        if(this.mFont == 0)
        {
                return val_3;
        }
        
        if(this.mFont != null)
        {
                return this.mFont.dynamicFont;
        }
        
        return this.mFont.dynamicFont;
    }
    public void set_trueTypeFont(UnityEngine.Font 丙业与丙丗丝不丈东)
    {
        if(this.mTrueTypeFont == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.业一丆与丁丏三丐专(东丞且丌丛世丞丅丆:  0);
        this.RemoveFromPanel();
        this.mTrueTypeFont = 丙业与丙丗丝不丈东;
        mem[1152921535327223848] = true;
        this.丁丛下专丗丁丞万上 = true;
        this.mFont = 0;
        this.业一丆与丁丏三丐专(东丞且丌丛世丞丅丆:  丙业与丙丗丝不丈东);
        this.丆丐丈七丆丆一丛丏();
        if(this.丕丌丈丛丑丙丂丕丝 == 0)
        {
                return;
        }
        
        this.MarkAsChanged();
    }
    public UnityEngine.Object get_ambigiousFont()
    {
        if(this.mFont == null)
        {
                return (UnityEngine.Object)this.mTrueTypeFont;
        }
        
        return (UnityEngine.Object)this.mFont;
    }
    public void set_ambigiousFont(UnityEngine.Object 丙业与丙丗丝不丈东)
    {
        var val_4;
        UnityEngine.Font val_5;
        val_4 = 0;
        if( != 0)
        {
                this.bitmapFont = ;
            return;
        }
        
        if(丙业与丙丗丝不丈东 != null)
        {
                var val_3 = (null == null) ? 丙业与丙丗丝不丈东 : 0;
        }
        else
        {
                val_5 = 0;
        }
        
        this.trueTypeFont = val_5;
    }
    public string get_text()
    {
        return (string)this.mText;
    }
    public void set_text(string 丙业与丙丗丝不丈东)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.copyTo, 丕丗丘丑丛与丑业丒:  丙业与丙丗丝不丈东);
        if((System.String.op_Equality(a:  this.mText, b:  丙业与丙丗丝不丈东)) == true)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  丙业与丙丗丝不丈东)) == false)
        {
            goto label_4;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mText)) == true)
        {
            goto label_7;
        }
        
        this.mText = "";
        goto label_6;
        label_4:
        if((System.String.op_Inequality(a:  this.mText, b:  丙业与丙丗丝不丈东)) == false)
        {
            goto label_7;
        }
        
        this.mText = 丙业与丙丗丝不丈东;
        label_6:
        this.丆丐丈七丆丆一丛丏();
        label_7:
        if(null == null)
        {
                return;
        }
        
        this.ResizeCollider();
    }
    public int get_defaultFontSize()
    {
        int val_4;
        if(this.trueTypeFont != 0)
        {
                val_4 = this.mFontSize;
            return (int)val_4;
        }
        
        if(this.mFont != 0)
        {
                if(this.mFont != null)
        {
                return this.mFont.defaultSize;
        }
        
            return this.mFont.defaultSize;
        }
        
        val_4 = 16;
        return (int)val_4;
    }
    public int get_fontSize()
    {
        return (int)this.mFontSize;
    }
    public void set_fontSize(int 丙业与丙丗丝不丈东)
    {
        int val_1 = UnityEngine.Mathf.Clamp(value:  丙业与丙丗丝不丈东, min:  0, max:  256);
        if(this.mFontSize == val_1)
        {
                return;
        }
        
        this.mFontSize = val_1;
        mem[1152921535328110248] = true;
        this.丁丛下专丗丁丞万上 = true;
        this.丆丐丈七丆丆一丛丏();
    }
    public UnityEngine.FontStyle get_fontStyle()
    {
        return (UnityEngine.FontStyle)this.mFontStyle;
    }
    public void set_fontStyle(UnityEngine.FontStyle 丙业与丙丗丝不丈东)
    {
        if(this.mFontStyle == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mFontStyle = 丙业与丙丗丝不丈东;
        mem[1152921535328350632] = true;
        this.丁丛下专丗丁丞万上 = true;
        this.丆丐丈七丆丆一丛丏();
    }
    public 丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 get_alignment()
    {
        return (丐丄七丙丁丆丁专丏.下丂专丞万下丕上专)this.mAlignment;
    }
    public void set_alignment(丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 丙业与丙丗丝不丈东)
    {
        if(this.mAlignment == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mAlignment = 丙业与丙丗丝不丈东;
        mem[1152921535328599208] = true;
        this.丁丛下专丗丁丞万上 = true;
        this.丆丐丈七丆丆一丛丏();
    }
    public bool get_applyGradient()
    {
        return (bool)this.mApplyGradient;
    }
    public void set_applyGradient(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mApplyGradient == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.mApplyGradient = 丙业与丙丗丝不丈东;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public UnityEngine.Color get_gradientTop()
    {
        return new UnityEngine.Color() {r = this.mGradientTop};
    }
    public void set_gradientTop(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        float val_9;
        float val_10;
        val_9 = 丙业与丙丗丝不丈东.a;
        val_10 = 丙业与丙丗丝不丈东.g;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.mGradientTop, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a}, rhs:  new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = val_10, b = 丙业与丙丗丝不丈东.b, a = val_9})) == false)
        {
                return;
        }
        
        this.mGradientTop = 丙业与丙丗丝不丈东;
        mem[1152921535329055800] = val_10;
        mem[1152921535329055804] = 丙业与丙丗丝不丈东.b;
        mem[1152921535329055808] = val_9;
        if(this.mApplyGradient == false)
        {
                return;
        }
        
        val_9 = ???;
        val_10 = ???;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public UnityEngine.Color get_gradientBottom()
    {
        return new UnityEngine.Color() {r = this.mGradientBottom};
    }
    public void set_gradientBottom(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        float val_9;
        float val_10;
        val_9 = 丙业与丙丗丝不丈东.a;
        val_10 = 丙业与丙丗丝不丈东.g;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.mGradientBottom, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a}, rhs:  new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = val_10, b = 丙业与丙丗丝不丈东.b, a = val_9})) == false)
        {
                return;
        }
        
        this.mGradientBottom = 丙业与丙丗丝不丈东;
        mem[1152921535329279816] = val_10;
        mem[1152921535329279820] = 丙业与丙丗丝不丈东.b;
        mem[1152921535329279824] = val_9;
        if(this.mApplyGradient == false)
        {
                return;
        }
        
        val_9 = ???;
        val_10 = ???;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public int get_spacingX()
    {
        return (int)this.mSpacingX;
    }
    public void set_spacingX(int 丙业与丙丗丝不丈东)
    {
        if(this.mSpacingX == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mSpacingX = 丙业与丙丗丝不丈东;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public int get_spacingY()
    {
        return (int)this.mSpacingY;
    }
    public void set_spacingY(int 丙业与丙丗丝不丈东)
    {
        if(this.mSpacingY == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mSpacingY = 丙业与丙丗丝不丈东;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public bool get_useFloatSpacing()
    {
        return (bool)this.mUseFloatSpacing;
    }
    public void set_useFloatSpacing(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mUseFloatSpacing == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.mUseFloatSpacing = 丙业与丙丗丝不丈东;
        mem[1152921535329951400] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public float get_floatSpacingX()
    {
        return (float)this.mFloatSpacingX;
    }
    public void set_floatSpacingX(float 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Mathf.Approximately(a:  this.mFloatSpacingX, b:  丙业与丙丗丝不丈东)) != false)
        {
                return;
        }
        
        this.mFloatSpacingX = 丙业与丙丗丝不丈东;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public float get_floatSpacingY()
    {
        return (float)this.mFloatSpacingY;
    }
    public void set_floatSpacingY(float 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Mathf.Approximately(a:  this.mFloatSpacingY, b:  丙业与丙丗丝不丈东)) != false)
        {
                return;
        }
        
        this.mFloatSpacingY = 丙业与丙丗丝不丈东;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public float get_effectiveSpacingY()
    {
        if(this.mUseFloatSpacing == false)
        {
                return (float)(float)this.mSpacingY;
        }
        
        return (float)this.mFloatSpacingY;
    }
    public float get_effectiveSpacingX()
    {
        if(this.mUseFloatSpacing == false)
        {
                return (float)(float)this.mSpacingX;
        }
        
        return (float)this.mFloatSpacingX;
    }
    public bool get_overflowEllipsis()
    {
        return (bool)this.mOverflowEllipsis;
    }
    public void set_overflowEllipsis(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mOverflowEllipsis == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.mOverflowEllipsis = 丙业与丙丗丝不丈东;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    private bool 上上丁丐万丒万且业()
    {
        var val_4;
        if(this.trueTypeFont != 0)
        {
                var val_3 = (this.keepCrispWhenShrunk == 2) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public bool get_supportEncoding()
    {
        return (bool)this.mEncoding;
    }
    public void set_supportEncoding(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mEncoding == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.mEncoding = 丙业与丙丗丝不丈东;
        mem[1152921535331199784] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public 丐丄七丙丁丆丁专丏.不丛东一上丟业丑一 get_symbolStyle()
    {
        return (丐丄七丙丁丆丁专丏.不丛东一上丟业丑一)this.mSymbols;
    }
    public void set_symbolStyle(丐丄七丙丁丆丁专丏.不丛东一上丟业丑一 丙业与丙丗丝不丈东)
    {
        if(this.mSymbols == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mSymbols = 丙业与丙丗丝不丈东;
        mem[1152921535331440168] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public UILabel.丐丏上丂丐丂丝世丐 get_overflowMethod()
    {
        return (丐丏上丂丐丂丝世丐)this.mOverflow;
    }
    public void set_overflowMethod(UILabel.丐丏上丂丐丂丝世丐 丙业与丙丗丝不丈东)
    {
        if(this.mOverflow == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mOverflow = 丙业与丙丗丝不丈东;
        mem[1152921535331688744] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public int get_lineWidth()
    {
        return this.width;
    }
    public void set_lineWidth(int 丙业与丙丗丝不丈东)
    {
        this.width = 丙业与丙丗丝不丈东;
    }
    public int get_lineHeight()
    {
        return this.height;
    }
    public void set_lineHeight(int 丙业与丙丗丝不丈东)
    {
        this.height = 丙业与丙丗丝不丈东;
    }
    public bool get_multiLine()
    {
        return (bool)(this.mMaxLineCount != 1) ? 1 : 0;
    }
    public void set_multiLine(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mMaxLineCount != 1) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        int val_2 = ~丙业与丙丗丝不丈东;
        val_2 = val_2 & 1;
        mem[1152921535332368936] = true;
        this.mMaxLineCount = val_2;
        this.丁丛下专丗丁丞万上 = true;
    }
    public override UnityEngine.Vector3[] get_localCorners()
    {
        if(this.丁丛下专丗丁丞万上 == false)
        {
                return this.localCorners;
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return this.localCorners;
    }
    public override UnityEngine.Vector3[] get_worldCorners()
    {
        if(this.丁丛下专丗丁丞万上 == false)
        {
                return this.worldCorners;
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return this.worldCorners;
    }
    public override UnityEngine.Vector4 get_drawingDimensions()
    {
        if(this.丁丛下专丗丁丞万上 == false)
        {
                return this.drawingDimensions;
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return this.drawingDimensions;
    }
    public int get_maxLineCount()
    {
        return (int)this.mMaxLineCount;
    }
    public void set_maxLineCount(int 丙业与丙丗丝不丈东)
    {
        if(this.mMaxLineCount == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mMaxLineCount = UnityEngine.Mathf.Max(a:  丙业与丙丗丝不丈东, b:  0);
        mem[1152921535332933032] = true;
        this.丁丛下专丗丁丞万上 = true;
        if(this.mOverflow == 0)
        {
            goto typeof(UILabel).__il2cppRuntimeField_358;
        }
    
    }
    public UILabel.东丗一且与丑与丈且 get_effectStyle()
    {
        return (东丗一且与丑与丈且)this.mEffectStyle;
    }
    public void set_effectStyle(UILabel.东丗一且与丑与丈且 丙业与丙丗丝不丈东)
    {
        if(this.mEffectStyle == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mEffectStyle = 丙业与丙丗丝不丈东;
        mem[1152921535333177512] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public UnityEngine.Color get_effectColor()
    {
        return new UnityEngine.Color() {r = this.mEffectColor};
    }
    public void set_effectColor(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.mEffectColor, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a}, rhs:  new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a})) == false)
        {
                return;
        }
        
        this.mEffectColor = 丙业与丙丗丝不丈东;
        mem[1152921535333414156] = 丙业与丙丗丝不丈东.g;
        mem[1152921535333414160] = 丙业与丙丗丝不丈东.b;
        mem[1152921535333414164] = 丙业与丙丗丝不丈东.a;
        if(this.mEffectStyle == 0)
        {
                return;
        }
        
        mem[1152921535333413800] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public UnityEngine.Vector2 get_effectDistance()
    {
        return new UnityEngine.Vector2() {x = this.mEffectDistance};
    }
    public void set_effectDistance(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.mEffectDistance, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y})) == false)
        {
                return;
        }
        
        this.mEffectDistance = 丙业与丙丗丝不丈东;
        mem[1152921535333642272] = 丙业与丙丗丝不丈东.y;
        mem[1152921535333641896] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public bool get_shrinkToFit()
    {
        return (bool)(this.mOverflow == 0) ? 1 : 0;
    }
    public void set_shrinkToFit(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        if(this.mOverflow == 0)
        {
                return;
        }
        
        this.mOverflow = 0;
        mem[1152921535333878184] = true;
        this.丁丛下专丗丁丞万上 = true;
    }
    public string get_processedText()
    {
        if(this.丒丘丞丏丙丒上与下 != W8)
        {
            goto label_0;
        }
        
        if(this.专业丁丆不东丙丞不 != this.丒丘丞丏丙丒上与下)
        {
            goto label_1;
        }
        
        if(this.丁丛下专丗丁丞万上 == true)
        {
            goto label_2;
        }
        
        return (string)this.下丑丞上与丄下丙东;
        label_0:
        label_1:
        this.丒丘丞丏丙丒上与下 = ;
        this.专业丁丆不东丙丞不 = this.丒丘丞丏丙丒上与下;
        this.丁丛下专丗丁丞万上 = true;
        label_2:
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return (string)this.下丑丞上与丄下丙东;
    }
    public UnityEngine.Vector2 get_printedSize()
    {
        if(this.丁丛下专丗丁丞万上 != true)
        {
                if(this.nickNameValidator == false)
        {
                return new UnityEngine.Vector2() {x = this.丆丛丟专丒丞丕丟丑};
        }
        
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return new UnityEngine.Vector2() {x = this.丆丛丟专丒丞丕丟丑};
    }
    public override UnityEngine.Vector2 get_localSize()
    {
        if(this.丁丛下专丗丁丞万上 == false)
        {
                return this.localSize;
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return this.localSize;
    }
    private bool 业三丐专世上下丌丁()
    {
        if(this.mFont == 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.mTrueTypeFont, y:  0);
        }
        
        return true;
    }
    protected override void 丅丒丐且丘丝丝丄且()
    {
        var val_2;
        this.丅丒丐且丘丝丝丄且();
        val_2 = null;
        val_2 = null;
        UILabel.丟丂与东业专三丕丏.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  this);
        this.业一丆与丁丏三丐专(东丞且丌丛世丞丅丆:  this.trueTypeFont);
    }
    protected override void OnDisable()
    {
        var val_2;
        this.业一丆与丁丏三丐专(东丞且丌丛世丞丅丆:  0);
        val_2 = null;
        val_2 = null;
        bool val_1 = UILabel.丟丂与东业专三丕丏.Remove(下丅丙一丂丗丅丝七:  this);
        this.OnDisable();
    }
    protected void 业一丆与丁丏三丐专(UnityEngine.Font 东丞且丌丛世丞丅丆)
    {
        UnityEngine.Font val_8;
        System.Collections.Generic.Dictionary<UnityEngine.Font, System.Int32> val_9;
        var val_10;
        var val_11;
        int val_12;
        var val_13;
        var val_14;
        var val_15;
        val_8 = this.丕丌丈丛丑丙丂丕丝;
        if(val_8 == 东丞且丌丛世丞丅丆)
        {
                return;
        }
        
        val_8 = this.丕丌丈丛丑丙丂丕丝;
        if(val_8 != 0)
        {
                val_9 = 1152921505098379264;
            val_10 = null;
            val_10 = null;
            if((UILabel.丕丐七丂三专三丕丐.TryGetValue(key:  val_8, value: out  0)) != false)
        {
                val_11 = null;
            val_12 = UnityEngine.Mathf.Max(a:  0, b:  -1);
            if(val_12 != 0)
        {
                val_13 = null;
            val_12 = val_12;
            val_9 = UILabel.丕丐七丂三专三丕丐;
            val_9.set_Item(key:  val_8, value:  val_12);
        }
        else
        {
                val_14 = null;
            bool val_6 = UILabel.丕丐七丂三专三丕丐.Remove(key:  val_8);
        }
        
        }
        
        }
        
        this.丕丌丈丛丑丙丂丕丝 = 东丞且丌丛世丞丅丆;
        if(东丞且丌丛世丞丅丆 == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        UILabel.丕丐七丂三专三丕丐.set_Item(key:  东丞且丌丛世丞丅丆, value:  1);
    }
    private static void 下丏业三丗万专业丅(UnityEngine.Font 丂一丂丗与丟业丆丙)
    {
        var val_14;
        string val_15;
        int val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        丒丞丕丕七丁丗丟丛<UILabel> val_22;
        System.Collections.Generic.List<T> val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_14 = 0;
        goto label_1;
        label_36:
        UILabel val_1 = UILabel.丟丂与东业专三丕丏.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        if(val_1 != 0)
        {
                UnityEngine.Font val_3 = val_1.trueTypeFont;
            if(val_3 == 丂一丂丗与丟业丆丙)
        {
                if(val_1 != null)
        {
                val_15 = val_1.mText;
            val_16 = val_1.丛丆丛丕丏丙丛不丄;
        }
        else
        {
                val_15 = 0;
            val_16 = 655;
        }
        
            val_3.RequestCharactersInTexture(characters:  val_15, size:  655, style:  val_1.mFontStyle);
            if(val_3 == 0)
        {
                UIPanel val_6 = val_1.CreatePanel();
        }
        
            val_17 = null;
            val_17 = null;
            if(UILabel.三专万不丏一丆丑丆 == null)
        {
                System.Collections.Generic.List<UIDrawCall> val_7 = new System.Collections.Generic.List<UIDrawCall>();
            val_18 = null;
            val_18 = null;
            UILabel.三专万不丏一丆丑丆 = val_7;
        }
        
            if(val_7 != 0)
        {
                val_19 = null;
            val_19 = null;
            if((val_7.Contains(item:  val_15)) != true)
        {
                val_20 = null;
            val_20 = null;
            val_7.Add(item:  val_1);
        }
        
        }
        
        }
        
        }
        
        val_14 = 1;
        label_1:
        val_21 = null;
        val_21 = null;
        val_22 = UILabel.丟丂与东业专三丕丏;
        if(val_22 == null)
        {
                val_21 = null;
        }
        
        if(val_14 < (UILabel.丟丂与东业专三丕丏 + 24))
        {
            goto label_36;
        }
        
        val_21 = null;
        val_23 = UILabel.三专万不丏一丆丑丆;
        if(val_23 == null)
        {
                return;
        }
        
        val_23 = UILabel.三专万不丏一丆丑丆;
        if(val_23 == null)
        {
                val_23 = 0;
        }
        
        int val_10 = val_23.Count;
        val_24 = null;
        val_25 = (uint)(((uint)((UILabel.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        if(val_10 >= 1)
        {
                val_15 = 1152921535334850448;
            var val_14 = 0;
            do
        {
            val_26 = null;
            val_22 = val_7.Item[0];
            if(val_11.panel != 0)
        {
                bool val_13 = val_11.panel.FillDrawCall(丘七专丆丘丛丒丗东:  val_22);
        }
        
            val_27 = null;
            val_14 = val_14 + 1;
            val_25 = (uint)(((uint)((UILabel.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
        }
        while(val_10 != val_14);
        
        }
        
        val_27 = null;
        val_7.Clear();
    }
    public override UnityEngine.Vector3[] GetSides(UnityEngine.Transform 一世丛下丘东世专丈)
    {
        if(this.丁丛下专丗丁丞万上 == false)
        {
                return this.GetSides(一世丛下丘东世专丈:  一世丛下丘东世专丈);
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        return this.GetSides(一世丛下丘东世专丈:  一世丛下丘东世专丈);
    }
    protected override void 丘业丑丌专七丘三三()
    {
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  true, 业业丄不东世丝丑专:  true);
        if(this.mShrinkToFit != false)
        {
                if(this.mOverflow != 0)
        {
                this.mOverflow = 0;
            mem[1152921535335186600] = true;
            this.丁丛下专丗丁丞万上 = true;
        }
        
            this.mMaxLineCount = 0;
        }
        
        if(this.mMaxLineWidth == 0)
        {
            goto label_3;
        }
        
        this.width = this.mMaxLineWidth;
        丐丏上丂丐丂丝世丐 val_1 = (this.mMaxLineCount > 0) ? 3 : 0;
        if(this.mOverflow == val_1)
        {
            goto label_6;
        }
        
        this.mOverflow = val_1;
        mem[1152921535335186600] = true;
        this.丁丛下专丗丁丞万上 = true;
        goto label_6;
        label_3:
        if(this.mOverflow != 2)
        {
                this.mOverflow = 2;
            mem[1152921535335186600] = true;
            this.丁丛下专丗丁丞万上 = true;
        }
        
        label_6:
        if(this.mMaxLineHeight != 0)
        {
                this.height = this.mMaxLineHeight;
        }
        
        if(this.mFont != 0)
        {
                int val_3 = this.mFont.defaultSize;
            if(this.height < val_3)
        {
                this.height = val_3;
        }
        
            this.fontSize = val_3;
        }
        
        mem2[0] = 0;
        this.mShrinkToFit = false;
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(丝三丁东丈丒世丅业:  this.gameObject, 三世与丌丈丈丅丒三:  true);
    }
    protected override void 东七一下丕丛与丑丝()
    {
        if(this.mOverflow == 3)
        {
            goto label_1;
        }
        
        if(this.mOverflow != 2)
        {
            goto label_12;
        }
        
        if(this.isFullyAnchored == true)
        {
            goto label_3;
        }
        
        goto label_12;
        label_1:
        if((mem[137121808] == 0) || ((mem[137121808] + 16) == 0))
        {
            goto label_12;
        }
        
        label_3:
        this.mOverflow = 0;
        label_12:
        this.东七一下丕丛与丑丝();
    }
    private void 丆丐丈七丆丆一丛丏()
    {
        UIFont val_2 = this.mFont;
        if(val_2 == null)
        {
                val_2 = this.mTrueTypeFont;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
    }
    protected override void OnEnable()
    {
        var val_2;
        this.OnEnable();
        val_2 = null;
        val_2 = null;
        if(UILabel.一且丅丏丆丂丐丘丗 != false)
        {
                return;
        }
        
        UILabel.一且丅丏丆丂丐丘丗 = true;
        UnityEngine.Font.add_textureRebuilt(value:  new System.Action<UnityEngine.Font>(object:  0, method:  static System.Void UILabel::下丏业三丗万专业丅(UnityEngine.Font 丂一丂丗与丟业丆丙)));
    }
    protected override void 丁业三上丛丐且专东()
    {
        bool val_9;
        this.丁业三上丛丐且专东();
        if(this.mLineWidth > 0f)
        {
                this.mMaxLineWidth = UnityEngine.Mathf.RoundToInt(f:  this.mLineWidth);
            this.mLineWidth = 0f;
        }
        
        if(this.mMultiline != true)
        {
                this.mMaxLineCount = 1;
            this.mMultiline = 1;
        }
        
        if((this != 0) && (this.shader != 0))
        {
                val_9 = this.shader.name.Contains(value:  "Premultiplied");
        }
        else
        {
                val_9 = false;
        }
        
        this.且丟且丏一丑三丑丆 = val_9;
        this.丆丐丈七丆丆一丛丏();
    }
    public override void MarkAsChanged()
    {
        mem[1152921535335830568] = true;
        this.丁丛下专丗丁丞万上 = true;
        this.MarkAsChanged();
    }
    public void ProcessText()
    {
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
    }
    private void 丈与下一东丘下丒业(bool 专丄丛丆丈丏东一世, bool 业业丄不东世丝丑专)
    {
        var val_55;
        int val_56;
        var val_57;
        int val_58;
        float val_59;
        var val_60;
        int val_61;
        var val_62;
        float val_63;
        float val_64;
        var val_65;
        int val_66;
        var val_67;
        var val_68;
        var val_69;
        string val_71;
        UnityEngine.Object val_72;
        丐丏上丂丐丂丝世丐 val_73;
        var val_74;
        var val_75;
        float val_76;
        var val_77;
        var val_78;
        int val_80;
        val_55 = 专丄丛丆丈丏东一世;
        if(this.业三丐专世上下丌丁() == false)
        {
                return;
        }
        
        mem[1152921535336107816] = 1;
        this.丁丛下专丗丁丞万上 = false;
        if(val_55 != false)
        {
                var val_2 = (this.mMaxLineWidth == 0) ? 1000000 : this.mMaxLineWidth;
        }
        else
        {
                val_56 = this.width;
        }
        
        val_57 = null;
        val_57 = null;
        丐丄七丙丁丆丁专丏.丅丈丌丅丆丕万世丑 = val_56;
        if(val_55 != false)
        {
                var val_4 = (this.mMaxLineHeight == 0) ? 1000000 : this.mMaxLineHeight;
        }
        else
        {
                val_57 = null;
            val_58 = this.height;
        }
        
        float val_6 = S8 - S11;
        val_57 = null;
        val_59 = 1f;
        丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙 = val_58;
        if(val_6 == val_59)
        {
                val_60 = null;
            val_61 = 丐丄七丙丁丆丁专丏.丅丈丌丅丆丕万世丑;
        }
        else
        {
                val_62 = null;
            val_63 = val_6 * (float)丐丄七丙丁丆丁专丏.丅丈丌丅丆丕万世丑;
            val_60 = null;
            val_61 = UnityEngine.Mathf.RoundToInt(f:  val_63);
        }
        
        val_64 = S9 - S10;
        val_60 = null;
        丐丄七丙丁丆丁专丏.丐丄丗上丂丑丙丑丗 = val_61;
        if(val_64 == val_59)
        {
                val_65 = null;
            val_66 = 丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙;
        }
        else
        {
                val_67 = null;
            val_63 = val_64 * (float)丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙;
            val_65 = null;
            val_66 = UnityEngine.Mathf.RoundToInt(f:  val_63);
        }
        
        val_65 = null;
        val_68 = this;
        丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 = val_66;
        if(val_55 != false)
        {
                UnityEngine.Vector3 val_10 = this.cachedTransform.localScale;
            val_63 = val_10.x;
            val_68 = 0;
            int val_11 = UnityEngine.Mathf.RoundToInt(f:  val_63);
        }
        
        this.丛丆丛丕丏丙丛不丄 = UnityEngine.Mathf.Abs(value:  this.defaultFontSize);
        this.丟丕世万七且万丌丈 = 1f;
        val_69 = null;
        val_69 = null;
        if((丐丄七丙丁丆丁专丏.丐丄丗上丂丑丙丑丗 < 1) || ((丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 & 2147483648) != 0))
        {
            goto label_42;
        }
        
        val_71 = 1152921504848912384;
        bool val_15 = UnityEngine.Object.op_Inequality(x:  this.trueTypeFont, y:  0);
        if((val_15 == false) || (this.上上丁丐万丒万且业() == false))
        {
            goto label_52;
        }
        
        val_72 = this.root;
        if(val_72 == 0)
        {
            goto label_49;
        }
        
        if(val_72 != 0)
        {
                val_59 = val_72.pixelSizeAdjustment;
        }
        
        label_52:
        this.业丒丙三丑丈丄业专 = val_59;
        label_49:
        if(业业丄不东世丝丑专 != false)
        {
                this.UpdateNGUIText();
        }
        
        val_73 = this.mOverflow;
        if(val_73 != 2)
        {
            goto label_55;
        }
        
        val_74 = null;
        val_74 = null;
        丐丄七丙丁丆丁专丏.丅丈丌丅丆丕万世丑 = 1000000;
        丐丄七丙丁丆丁专丏.丐丄丗上丂丑丙丑丗 = 1000000;
        val_73 = this.mOverflow;
        if(val_73 == 2)
        {
            goto label_58;
        }
        
        label_55:
        if(val_73 != 3)
        {
            goto label_59;
        }
        
        val_74 = null;
        label_58:
        val_74 = null;
        丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙 = 1000000;
        丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 = 1000000;
        label_59:
        if(this.丛丆丛丕丏丙丛不丄 < 1)
        {
            goto label_62;
        }
        
        int val_52 = this.丛丆丛丕丏丙丛不丄;
        val_72 = this.上上丁丐万丒万且业();
        if(val_52 < 1)
        {
            goto label_119;
        }
        
        label_81:
        if(val_72 != false)
        {
                this.丛丆丛丕丏丙丛不丄 = val_52;
            val_75 = null;
            val_75 = null;
            丐丄七丙丁丆丁专丏.东丈丝丌丑丈丛丐丅 = val_52;
        }
        else
        {
                val_76 = (float)val_52;
            val_63 = (float)this.丛丆丛丕丏丙丛不丄;
            val_59 = val_76 / val_63;
            this.丟丕世万七且万丌丈 = val_59;
            if(val_15 != true)
        {
                val_63 = this.丟丕世万七且万丌丈;
            val_76 = (float)this.mFontSize / (float)this.mFont.defaultSize;
            val_59 = val_63 * val_76;
        }
        
            val_75 = null;
            val_75 = null;
            丐丄七丙丁丆丁专丏.东丞丐丅丙下万丘丘 = val_59;
        }
        
        丐丄七丙丁丆丁专丏.上专丄丑专丑丘业丌(东丞丒丙世丏三下丟:  false);
        val_71 = this.mText;
        if(this.mOverflowEllipsis != false)
        {
                var val_23 = (this.mOverflow == 1) ? 1 : 0;
        }
        else
        {
                val_77 = 0;
        }
        
        if(((丐丄七丙丁丆丁专丏.丌丌丐丌丑丞万且丛(丕丗丘丑丛与丑业丒:  val_71, 丆万丁丛丝三丅丅东: out  this.下丑丞上与丄下丙东, 丆丄上三上丘丆一世:  true, 世丅丆丟世丞上世世:  false, 丐丅且丞丒下丐业三:  false)) == true) || (this.mOverflow != 0))
        {
            goto label_79;
        }
        
        if((val_52 - 1) < 2)
        {
            goto label_119;
        }
        
        val_52 = val_52 - 2;
        if(val_52 >= 3)
        {
            goto label_81;
        }
        
        goto label_119;
        label_42:
        this.下丑丞上与丄下丙东 = "";
        return;
        label_62:
        val_55 = this.cachedTransform;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
        val_59 = val_28.x;
        val_64 = val_28.z;
        val_55.localScale = new UnityEngine.Vector3() {x = val_59, y = val_28.y, z = val_64};
        this.丟丕世万七且万丌丈 = 1f;
        this.下丑丞上与丄下丙东 = "";
        label_119:
        if(业业丄不东世丝丑专 == false)
        {
                return;
        }
        
        label_125:
        val_78 = null;
        val_78 = null;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        return;
        label_79:
        if(this.mOverflow != 2)
        {
            goto label_90;
        }
        
        UnityEngine.Vector2 val_30 = 丐丄七丙丁丆丁专丏.丞专丏丂丁丗丅一丝(丕丗丘丑丛与丑业丒:  this.下丑丞上与丄下丙东, 与丙丅丛丞丌且丐不:  (this.nickNameValidator == true) ? 1 : 0);
        this.丆丛丟专丒丞丕丟丑 = val_30;
        mem[1152921535336108320] = val_30.y;
        int val_33 = UnityEngine.Mathf.Max(a:  this.minWidth, b:  UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑));
        mem[1152921535336107896] = val_33;
        if(val_6 != 1f)
        {
                float val_53 = (float)val_33;
            val_53 = val_53 / val_6;
            mem[1152921535336107896] = UnityEngine.Mathf.RoundToInt(f:  val_53);
        }
        
        val_80 = UnityEngine.Mathf.Max(a:  this.minHeight, b:  UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑));
        mem[1152921535336107900] = val_80;
        if(val_64 != 1f)
        {
                float val_54 = (float)val_80;
            val_54 = val_54 / val_64;
            val_80 = UnityEngine.Mathf.RoundToInt(f:  val_54);
            mem[1152921535336107900] = val_80;
        }
        
        mem[1152921535336107896] = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + 1);
        if((val_80 & 1) != 0)
        {
            goto label_104;
        }
        
        goto label_114;
        label_90:
        if(this.mOverflow != 3)
        {
            goto label_106;
        }
        
        UnityEngine.Vector2 val_40 = 丐丄七丙丁丆丁专丏.丞专丏丂丁丗丅一丝(丕丗丘丑丛与丑业丒:  this.下丑丞上与丄下丙东, 与丙丅丛丞丌且丐不:  (this.nickNameValidator == true) ? 1 : 0);
        this.丆丛丟专丒丞丕丟丑 = val_40;
        mem[1152921535336108320] = val_40.y;
        val_80 = UnityEngine.Mathf.Max(a:  this.minHeight, b:  UnityEngine.Mathf.RoundToInt(f:  val_59));
        mem[1152921535336107900] = val_80;
        if(val_64 != 1f)
        {
                float val_55 = (float)val_80;
            val_55 = val_55 / val_64;
            val_80 = UnityEngine.Mathf.RoundToInt(f:  val_55);
            mem[1152921535336107900] = val_80;
        }
        
        if((val_80 & 1) == 0)
        {
            goto label_114;
        }
        
        label_104:
        mem[1152921535336107900] = val_80 + 1;
        if(val_55 == false)
        {
            goto label_119;
        }
        
        goto label_116;
        label_106:
        UnityEngine.Vector2 val_47 = 丐丄七丙丁丆丁专丏.丞专丏丂丁丗丅一丝(丕丗丘丑丛与丑业丒:  this.下丑丞上与丄下丙东, 与丙丅丛丞丌且丐不:  (this.nickNameValidator == true) ? 1 : 0);
        this.丆丛丟专丒丞丕丟丑 = val_47;
        mem[1152921535336108320] = val_47.y;
        label_114:
        if(val_55 == false)
        {
            goto label_119;
        }
        
        label_116:
        this.width = UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑);
        this.height = UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑);
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.one;
        this.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
        if(业业丄不东世丝丑专 == true)
        {
            goto label_125;
        }
    
    }
    public override void MakePixelPerfect()
    {
        UIFont val_24 = this.mFont;
        if(val_24 == null)
        {
                val_24 = this.mTrueTypeFont;
        }
        
        if(val_24 == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_3 = this.cachedTransform.localPosition;
        this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = (float)UnityEngine.Mathf.RoundToInt(f:  val_3.x), y = (float)UnityEngine.Mathf.RoundToInt(f:  val_3.y), z = (float)UnityEngine.Mathf.RoundToInt(f:  val_3.z)};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        this.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(this.mOverflow != 2)
        {
            goto label_12;
        }
        
        this.AssumeNaturalSize();
        return;
        label_4:
        this.MakePixelPerfect();
        return;
        label_12:
        if(this.mOverflow != 3)
        {
                mem[1152921535336301816] = 100000;
        }
        
        mem[1152921535336301820] = 100000;
        this.mOverflow = 0;
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        this.mOverflow = this.mOverflow;
        int val_15 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑), b:  this.minWidth);
        int val_17 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑), b:  this.minHeight);
        mem[1152921535336301816] = UnityEngine.Mathf.Max(a:  this.width, b:  (val_15 & 1) + val_15);
        mem[1152921535336301820] = UnityEngine.Mathf.Max(a:  this.height, b:  (val_17 & 1) + val_17);
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public void AssumeNaturalSize()
    {
        var val_10;
        UIFont val_11;
        val_10 = this;
        val_11 = this.mFont;
        if(val_11 == null)
        {
                val_11 = this.mTrueTypeFont;
        }
        
        if(val_11 == 0)
        {
                return;
        }
        
        mem[1152921535336450680] = 100001;
        this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  true);
        mem[1152921535336450680] = UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑);
        int val_3 = UnityEngine.Mathf.RoundToInt(f:  this.丆丛丟专丒丞丕丟丑);
        mem[1152921535336450684] = val_3;
        mem[1152921535336450680] = (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + 1);
        if((val_3 & 1) != 0)
        {
                mem[1152921535336450684] = val_3 + 1;
        }
        
        val_10 = ???;
        goto typeof(UILabel).__il2cppRuntimeField_338;
    }
    public int GetCharacterIndex(UnityEngine.Vector3 丈七东丐世丒丅丗丌)
    {
        return this.GetCharacterIndexAtPosition(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z}, 丑丁丝丕丆丐业七上:  false);
    }
    public int GetCharacterIndex(UnityEngine.Vector2 丈丑丑且业下丒丁丞)
    {
        return this.GetCharacterIndexAtPosition(丈丑丑且业下丒丁丞:  new UnityEngine.Vector2() {x = 丈丑丑且业下丒丁丞.x, y = 丈丑丑且业下丒丁丞.y}, 丑丁丝丕丆丐业七上:  false);
    }
    public int GetCharacterIndexAtPosition(UnityEngine.Vector3 丈七东丐世丒丅丗丌, bool 丑丁丝丕丆丐业七上)
    {
        UnityEngine.Vector3 val_2 = this.cachedTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z});
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        return this.GetCharacterIndexAtPosition(丈丑丑且业下丒丁丞:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, 丑丁丝丕丆丐业七上:  丑丁丝丕丆丐业七上);
    }
    public int GetCharacterIndexAtPosition(UnityEngine.Vector2 丈丑丑且业下丒丁丞, bool 丑丁丝丕丆丐业七上)
    {
        string val_7;
        var val_8;
        var val_9;
        var val_10;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        if(this.业三丐专世上下丌丁() == false)
        {
            goto label_1;
        }
        
        string val_2 = this.processedText;
        val_7 = val_2;
        if((System.String.IsNullOrEmpty(value:  val_2)) == false)
        {
            goto label_2;
        }
        
        label_1:
        val_8 = 0;
        return (int)val_8;
        label_2:
        this.UpdateNGUIText();
        val_9 = null;
        if(丑丁丝丕丆丐业七上 != false)
        {
                val_10 = null;
            val_11 = UILabel.丕丙丒丘丈丞丙丒业;
            丐丄七丙丁丆丁专丏.不丕丕丁丌丗丕丝丑(丕丗丘丑丛与丑业丒:  val_7, 丗丞不丞业丑七且丗:  val_11, 丄丆下与丏丈丆七丑:  UILabel.三丁丙丘上丆丑且东);
        }
        else
        {
                val_12 = null;
            val_11 = UILabel.丕丙丒丘丈丞丙丒业;
            丐丄七丙丁丆丁专丏.丁丂丁专丗丅丄丞七(丕丗丘丑丛与丑业丒:  val_7, 丗丞不丞业丑七且丗:  val_11, 丄丆下与丏丈丆七丑:  UILabel.三丁丙丘上丆丑且东);
        }
        
        val_13 = null;
        val_13 = null;
        val_7 = UILabel.丕丙丒丘丈丞丙丒业;
        if((UILabel.丕丙丒丘丈丞丙丒业 + 24) < 1)
        {
            goto label_17;
        }
        
        val_14 = null;
        val_14 = null;
        UnityEngine.Vector2 val_4 = this.ApplyOffset(丗丞不丞业丑七且丗:  UILabel.丕丙丒丘丈丞丙丒业, 丄且一丄丏丆丐丗与:  0);
        val_15 = null;
        if(丑丁丝丕丆丐业七上 == false)
        {
            goto label_20;
        }
        
        val_16 = null;
        val_17 = UILabel.丕丙丒丘丈丞丙丒业;
        int val_5 = 丐丄七丙丁丆丁专丏.专丒东丌丕七丝与且(丗丞不丞业丑七且丗:  val_17, 丄丆下与丏丈丆七丑:  UILabel.三丁丙丘上丆丑且东, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = 丈丑丑且业下丒丁丞.x, y = 丈丑丑且业下丒丁丞.y});
        goto label_25;
        label_17:
        val_18 = 1152921505093107712;
        val_19 = null;
        val_19 = null;
        val_8 = 0;
        goto label_38;
        label_20:
        val_20 = null;
        val_17 = UILabel.丕丙丒丘丈丞丙丒业;
        label_25:
        val_8 = 丐丄七丙丁丆丁专丏.世专丙专丙丌与丑丗(丗丞不丞业丑七且丗:  val_17, 丄丆下与丏丈丆七丑:  UILabel.三丁丙丘上丆丑且东, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = 丈丑丑且业下丒丁丞.x, y = 丈丑丑且业下丒丁丞.y});
        val_21 = null;
        val_21 = null;
        UILabel.丕丙丒丘丈丞丙丒业.世业丒万丘丆专丘丐();
        UILabel.三丁丙丘上丆丑且东.世业丒万丘丆专丘丐();
        val_18 = 1152921505093107712;
        val_19 = null;
        val_19 = null;
        label_38:
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        return (int)val_8;
    }
    public string GetWordAtPosition(UnityEngine.Vector3 丈七东丐世丒丅丗丌)
    {
        return this.GetWordAtCharacterIndex(丞丅上丂丝且丞丌东:  this.GetCharacterIndexAtPosition(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z}, 丑丁丝丕丆丐业七上:  true));
    }
    public string GetWordAtPosition(UnityEngine.Vector2 丈丑丑且业下丒丁丞)
    {
        return this.GetWordAtCharacterIndex(丞丅上丂丝且丞丌东:  this.GetCharacterIndexAtPosition(丈丑丑且业下丒丁丞:  new UnityEngine.Vector2() {x = 丈丑丑且业下丒丁丞.x, y = 丈丑丑且业下丒丁丞.y}, 丑丁丝丕丆丐业七上:  true));
    }
    public string GetWordAtCharacterIndex(int 丞丅上丂丝且丞丌东)
    {
        string val_8;
        int val_9;
        var val_10;
        if(丞丅上丂丝且丞丌东 == 1)
        {
                return 0;
        }
        
        val_8 = this.mText;
        if(val_8.Length <= 丞丅上丂丝且丞丌东)
        {
                return 0;
        }
        
        char[] val_2 = new char[2];
        val_9 = val_2.Length;
        if(val_9 == 0)
        {
                val_9 = val_2.Length;
        }
        
        val_2[0] = 32;
        val_2[0] = '
        ';
        val_10 = this.mText;
        val_8 = (this.mText.LastIndexOfAny(anyOf:  val_2, startIndex:  丞丅上丂丝且丞丌东)) + 1;
        int val_5 = val_10.IndexOfAny(anyOf:  new char[4], startIndex:  丞丅上丂丝且丞丌东);
        if(val_5 == 1)
        {
                string val_8 = this.mText;
            val_10 = val_8;
        }
        
        val_8 = val_10.Length - val_8;
        if(val_5 == 1)
        {
                return 0;
        }
        
        if(val_8 < 1)
        {
                return 0;
        }
        
        return 丐丄七丙丁丆丁专丏.丂丞世丐丌丑丕下三(丕丗丘丑丛与丑业丒:  this.mText.Substring(startIndex:  val_8, length:  val_8));
    }
    public string GetUrlAtPosition(UnityEngine.Vector3 丈七东丐世丒丅丗丌)
    {
        return this.GetUrlAtCharacterIndex(丞丅上丂丝且丞丌东:  this.GetCharacterIndexAtPosition(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z}, 丑丁丝丕丆丐业七上:  true));
    }
    public string GetUrlAtPosition(UnityEngine.Vector2 丈丑丑且业下丒丁丞)
    {
        return this.GetUrlAtCharacterIndex(丞丅上丂丝且丞丌东:  this.GetCharacterIndexAtPosition(丈丑丑且业下丒丁丞:  new UnityEngine.Vector2() {x = 丈丑丑且业下丒丁丞.x, y = 丈丑丑且业下丒丁丞.y}, 丑丁丝丕丆丐业七上:  true));
    }
    public string GetUrlAtCharacterIndex(int 丞丅上丂丝且丞丌东)
    {
        string val_21;
        var val_22;
        if(丞丅上丂丝且丞丌东 == 1)
        {
                return 0;
        }
        
        val_21 = this.mText;
        if((val_21.Length - 6) <= 丞丅上丂丝且丞丌东)
        {
                return 0;
        }
        
        if(((((this.mText.Chars[丞丅上丂丝且丞丌东] & 65535) != '[') || (((this.mText.Chars[丞丅上丂丝且丞丌东 + 1]) & 65535) != 'u')) || (((this.mText.Chars[丞丅上丂丝且丞丌东 + 2]) & 65535) != 'r')) || (((this.mText.Chars[丞丅上丂丝且丞丌东 + 3]) & 65535) != 'l'))
        {
            goto label_11;
        }
        
        val_22 = 丞丅上丂丝且丞丌东;
        if(((this.mText.Chars[丞丅上丂丝且丞丌东 + 4]) & 65535) == ('='))
        {
            goto label_13;
        }
        
        label_11:
        val_21 = this.mText;
        val_22 = val_21;
        int val_17 = val_22.LastIndexOf(value:  "[url=", startIndex:  丞丅上丂丝且丞丌东);
        if(val_17 == 1)
        {
                return 0;
        }
        
        label_13:
        val_21 = val_17 + 5;
        int val_18 = this.mText.IndexOf(value:  "]", startIndex:  val_21);
        if(val_18 == 1)
        {
                return 0;
        }
        
        int val_19 = this.mText.IndexOf(value:  "[/url]", startIndex:  val_18);
        if((val_19 == 1) || (val_19 >= 丞丅上丂丝且丞丌东))
        {
                return this.mText.Substring(startIndex:  val_21, length:  val_18 - val_21);
        }
        
        return 0;
    }
    public int GetCharacterIndex(int 不丛三三专丛一万丝, UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        string val_12;
        var val_13;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_14;
        var val_15;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        float val_23;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        if(this.业三丐专世上下丌丁() == false)
        {
            goto label_46;
        }
        
        string val_2 = this.processedText;
        val_12 = val_2;
        if((System.String.IsNullOrEmpty(value:  val_2)) != false)
        {
                val_13 = 0;
            return (int)val_13;
        }
        
        val_14 = this.defaultFontSize;
        this.UpdateNGUIText();
        val_15 = null;
        val_15 = null;
        val_16 = UILabel.丕丙丒丘丈丞丙丒业;
        丐丄七丙丁丆丁专丏.丁丂丁专丗丅丄丞七(丕丗丘丑丛与丑业丒:  val_12, 丗丞不丞业丑七且丗:  val_16, 丄丆下与丏丈丆七丑:  UILabel.三丁丙丘上丆丑且东);
        if((UILabel.丕丙丒丘丈丞丙丒业 + 24) < 1)
        {
            goto label_9;
        }
        
        val_17 = null;
        val_17 = null;
        UnityEngine.Vector2 val_5 = this.ApplyOffset(丗丞不丞业丑七且丗:  UILabel.丕丙丒丘丈丞丙丒业, 丄且一丄丏丆丐丗与:  0);
        val_18 = 0;
        goto label_12;
        label_20:
        val_19 = null;
        val_19 = null;
        if((UILabel.三丁丙丘上丆丑且东.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0)) == 不丛三三专丛一万丝)
        {
            goto label_16;
        }
        
        val_18 = 1;
        label_12:
        val_20 = null;
        val_20 = null;
        val_16 = UILabel.三丁丙丘上丆丑且东;
        if(val_18 < (UILabel.三丁丙丘上丆丑且东 + 24))
        {
            goto label_20;
        }
        
        goto label_21;
        label_16:
        val_21 = null;
        val_21 = null;
        val_16 = UILabel.丕丙丒丘丈丞丙丒业;
        UnityEngine.Vector3 val_7 = val_16.丂丑丞丝且万丐万丟(七丞丙丒三丕且丌丟:  0);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_22 = val_8.x;
        val_23 = val_8.y;
        if((下上丐丆丝丟丝丒不 - 273) > 6)
        {
            goto label_34;
        }
        
        var val_12 = 106029864 + ((下上丐丆丝丟丝丒不 - 273)) << 2;
        val_12 = val_12 + 106029864;
        goto (106029864 + ((下上丐丆丝丟丝丒不 - 273)) << 2 + 106029864);
        label_34:
        val_27 = null;
        val_27 = null;
        val_14 = UILabel.丕丙丒丘丈丞丙丒业;
        if((丐丄七丙丁丆丁专丏.世专丙专丙丌与丑丗(丗丞不丞业丑七且丗:  val_14, 丄丆下与丏丈丆七丑:  UILabel.三丁丙丘上丆丑且东, 下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_22})) != 不丛三三专丛一万丝)
        {
            goto label_39;
        }
        
        label_21:
        val_28 = null;
        val_28 = null;
        UILabel.丕丙丒丘丈丞丙丒业.世业丒万丘丆专丘丐();
        UILabel.三丁丙丘上丆丑且东.世业丒万丘丆专丘丐();
        label_9:
        val_29 = null;
        val_29 = null;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        if((下上丐丆丝丟丝丒不 - 273) > 6)
        {
            goto label_46;
        }
        
        var val_13 = 106029892 + ((下上丐丆丝丟丝丒不 - 273)) << 2;
        val_13 = val_13 + 106029892;
        goto (106029892 + ((下上丐丆丝丟丝丒不 - 273)) << 2 + 106029892);
        label_46:
        val_13 = 不丛三三专丛一万丝;
        return (int)val_13;
        label_39:
        val_30 = null;
        val_30 = null;
        UILabel.丕丙丒丘丈丞丙丒业.世业丒万丘丆专丘丐();
        UILabel.三丁丙丘上丆丑且东.世业丒万丘丆专丘丐();
        return (int)val_13;
    }
    public void PrintOverlay(int 丄且一丄丏丆丐丗与, int 丈丝世且万世丈丌万, 丏丌业丑万丐丐不丙 丑丏丕下丙万丐丛丄, 丏丌业丑万丐丐不丙 下丙丕丌丁与与丏丗, UnityEngine.Color 丐丆丝丝丁丙丙丙丕, UnityEngine.Color 与丛三不丝丞下万丑)
    {
        float val_12;
        float val_13;
        var val_14;
        int val_15;
        byte val_16;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_18;
        var val_20;
        val_12 = 与丛三不丝丞下万丑.b;
        val_13 = 丐丆丝丝丁丙丙丙丕.b;
        val_14 = 丑丏丕下丙万丐丛丄;
        val_15 = 丈丝世且万世丈丌万;
        val_16 = this;
        if(val_14 != null)
        {
                val_14.世业丒万丘丆专丘丐();
        }
        
        if(下丙丕丌丁与与丏丗 != null)
        {
                下丙丕丌丁与与丏丗.世业丒万丘丆专丘丐();
        }
        
        if(this.业三丐专世上下丌丁() == false)
        {
                return;
        }
        
        string val_2 = this.processedText;
        this.UpdateNGUIText();
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
        if((丄且一丄丏丆丐丗与 == val_15) || (下丙丕丌丁与与丏丗 == null))
        {
            goto label_7;
        }
        
        val_18 = 下丙丕丌丁与与丏丗.丗丞不丞业丑七且丗;
        if(下丙丕丌丁与与丏丗.丗丞不丞业丑七且丗 == null)
        {
                val_18 = 下丙丕丌丁与与丏丗.丗丞不丞业丑七且丗;
        }
        
        丐丄七丙丁丆丁专丏.一丆七丕东丕丄上丄(丕丗丘丑丛与丑业丒:  val_2, 丄且一丄丏丆丐丗与:  丄且一丄丏丆丐丗与, 丈丝世且万世丈丌万:  val_15, 丑丏丕下丙万丐丛丄:  丑丏丕下丙万丐丛丄.丗丞不丞业丑七且丗, 下丙丕丌丁与与丏丗:  val_18);
        UnityEngine.Vector2 val_4 = this.ApplyOffset(丗丞不丞业丑七且丗:  下丙丕丌丁与与丏丗.丗丞不丞业丑七且丗, 丄且一丄丏丆丐丗与:  下丙丕丌丁与与丏丗.丗丞不丞业丑七且丗);
        float val_5 = 与丛三不丝丞下万丑.a * val_13;
        UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_18 = 1152921535198486432;
        byte val_7 = val_6.r & 4294967295;
        label_30:
        UnityEngine.Vector2 val_8 = this.ApplyOffset(丗丞不丞业丑七且丗:  丑丏丕下丙万丐丛丄.丗丞不丞业丑七且丗, 丄且一丄丏丆丐丗与:  丑丏丕下丙万丐丛丄.丗丞不丞业丑七且丗);
        float val_9 = 丐丆丝丝丁丙丙丙丕.a * val_13;
        UnityEngine.Color32 val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        val_15 = 1152921535198484384;
        val_16 = val_10.r & 4294967295;
        val_14 = 1152921505093107712;
        val_20 = null;
        val_20 = null;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        return;
        label_7:
        丐丄七丙丁丆丁专丏.一丆七丕东丕丄上丄(丕丗丘丑丛与丑业丒:  val_2, 丄且一丄丏丆丐丗与:  丄且一丄丏丆丐丗与, 丈丝世且万世丈丌万:  val_15, 丑丏丕下丙万丐丛丄:  丑丏丕下丙万丐丛丄.丗丞不丞业丑七且丗, 下丙丕丌丁与与丏丗:  0);
        if(val_14 != null)
        {
            goto label_30;
        }
        
        goto label_30;
    }
    public override void OnFill(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        var val_22;
        var val_23;
        var val_24;
        丒丞丕丕七丁丗丟丛<UnityEngine.Color32> val_25;
        var val_26;
        var val_27;
        var val_28;
        int val_29;
        var val_30;
        var val_31;
        UILabel val_32;
        东丗一且与丑与丈且 val_33;
        var val_34;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_36;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_38;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_40;
        var val_41;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_43;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_45;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_47;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_49;
        var val_50;
        if(this.业三丐专世上下丌丁() == false)
        {
                return;
        }
        
        UnityEngine.Color val_2 = this.color;
        val_19 = val_2.r;
        val_20 = val_2.g;
        val_21 = val_2.b;
        if(this.mFont != 0)
        {
                if(this.mFont.premultipliedAlphaShader != false)
        {
                UnityEngine.Color val_5 = 不丌丂丁丄一与丆丙.下丑与且丅丛丁丄丒(丁丂专业丁丅丅丈丙:  new UnityEngine.Color() {r = val_19, g = val_20, b = val_21, a = V10.16B});
            val_19 = val_5.r;
            val_20 = val_5.g;
            val_21 = val_5.b;
            val_18 = val_5.a;
        }
        
        }
        
        if(UnityEngine.QualitySettings.activeColorSpace == 1)
        {
                val_19 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_19);
            val_20 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_20);
            val_21 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_21);
            val_18 = UnityEngine.Mathf.GammaToLinearSpace(value:  val_18);
        }
        
        this.UpdateNGUIText();
        val_22 = null;
        val_22 = null;
        丐丄七丙丁丆丁专丏.丘不丂丞三丌丝下一 = val_19;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_30 = val_20;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_34 = val_21;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_38 = val_18;
        丐丄七丙丁丆丁专丏.上业与七且上丅三丄(丕丗丘丑丛与丑业丒:  this.processedText, 丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘);
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        UnityEngine.Vector2 val_12 = this.ApplyOffset(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丄且一丄丏丆丐丗与:  this.mFont);
        val_23 = 0;
        if(this.mFont != 0)
        {
                if(this.mFont.packedFontShader == true)
        {
                return;
        }
        
        }
        
        if(this.mEffectStyle == 0)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        UILabel.丈丆不万丟且东七且.世业丒万丘丆专丘丐();
        UILabel.七业丐丆东丁东且与.世业丒万丘丆专丘丐();
        val_25 = UILabel.丆丒丛一业不世丞下;
        val_25.世业丒万丘丆专丘丐();
        if(1152921535227159920 >= 1)
        {
                var val_18 = 0;
            do
        {
            val_26 = null;
            val_26 = null;
            val_25 = UILabel.丈丆不万丟且东七且;
            if(val_18 >= this.mFont.mMat)
        {
                val_23 = 0;
        }
        
            val_25.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = (0 * 12) + this.mFont + 32, y = (0 * 12) + this.mFont + 32 + 4, z = (0 * 12) + this.mFont + 40});
            val_18 = val_18 + 1;
        }
        while(val_18 < (this.mFont + (0 * 12)));
        
        }
        
        val_27 = 0;
        goto label_33;
        label_40:
        val_28 = null;
        val_28 = null;
        val_25 = UILabel.七业丐丆东丁东且与;
        if(val_27 >= ((0 + 1) + 24))
        {
                val_23 = 0;
        }
        
        val_25.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = ((0 + 1) + 0) + 32, y = ((0 + 1) + 0) + 32 + 4});
        val_27 = 1;
        label_33:
        if(val_27 < (val_18 + 0))
        {
            goto label_40;
        }
        
        val_29 = 1152921535198486432;
        val_30 = 0;
        goto label_41;
        label_48:
        val_25 = UILabel.丆丒丛一业不世丞下;
        val_23 = public System.Void 丒丞丕丕七丁丗丟丛<UnityEngine.Color32>::业丏丗丐丂业东丂丗(UnityEngine.Color32 下丅丙一丂丗丅丝七);
        val_25.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = UIFont.__il2cppRuntimeField_byval_arg, g = UIFont.__il2cppRuntimeField_byval_arg, b = UIFont.__il2cppRuntimeField_byval_arg, a = UIFont.__il2cppRuntimeField_byval_arg});
        val_30 = 1;
        label_41:
        val_31 = null;
        if(val_30 < W9)
        {
            goto label_48;
        }
        
        val_32 = this;
        val_33 = this.mEffectStyle;
        val_31 = null;
        this.ApplyShadow(丗丞不丞业丑七且丗:  UILabel.丈丆不万丟且东七且, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  137121792, 丈丝世且万世丈丌万:  null, 三丟东丕丄丄下下丑:  this.mEffectDistance, 丒丒丄丁且丄丆丂丌:  -val_19);
        东丗一且与丑与丈且 val_19 = this.mEffectStyle;
        val_19 = val_19 & 4294967294;
        if(val_19 == 2)
        {
                val_34 = null;
            val_34 = null;
            val_36 = UILabel.丈丆不万丟且东七且;
            if(UILabel.丈丆不万丟且东七且 == null)
        {
                val_36 = UILabel.丈丆不万丟且东七且;
        }
        
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_36, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  null, 丈丝世且万世丈丌万:  UILabel.丈丆不万丟且东七且 + 24, 三丟东丕丄丄下下丑:  -this.mEffectDistance, 丒丒丄丁且丄丆丂丌:  val_19);
            val_38 = UILabel.丈丆不万丟且东七且;
            if(UILabel.丈丆不万丟且东七且 == null)
        {
                val_38 = UILabel.丈丆不万丟且东七且;
        }
        
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_38, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  UILabel.丈丆不万丟且东七且 + 24, 丈丝世且万世丈丌万:  UILabel.丈丆不万丟且东七且 + 24, 三丟东丕丄丄下下丑:  this.mEffectDistance, 丒丒丄丁且丄丆丂丌:  val_19);
            val_40 = UILabel.丈丆不万丟且东七且;
            if(UILabel.丈丆不万丟且东七且 == null)
        {
                val_40 = UILabel.丈丆不万丟且东七且;
        }
        
            val_29 = mem[UILabel.丈丆不万丟且东七且 + 24];
            val_29 = UILabel.丈丆不万丟且东七且 + 24;
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_40, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  UILabel.丈丆不万丟且东七且 + 24, 丈丝世且万世丈丌万:  val_29, 三丟东丕丄丄下下丑:  -this.mEffectDistance, 丒丒丄丁且丄丆丂丌:  -val_19);
            if(mem[1152921535338292249] != true)
        {
                if((this.mEffectStyle != 3) && (System.Math.Abs(val_19) < 2.5f))
        {
                if((System.Math.Abs(this.mEffectDistance) < 2.5f) && (mem[1152921535338292128] >= 32))
        {
                if(this.height > 32)
        {
            goto label_67;
        }
        
        }
        
        }
        
            val_41 = null;
            val_41 = null;
            val_43 = UILabel.丈丆不万丟且东七且;
            if(UILabel.丈丆不万丟且东七且 == null)
        {
                val_43 = UILabel.丈丆不万丟且东七且;
        }
        
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_43, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  val_29, 丈丝世且万世丈丌万:  UILabel.丈丆不万丟且东七且 + 24, 三丟东丕丄丄下下丑:  -this.mEffectDistance, 丒丒丄丁且丄丆丂丌:  0f);
            val_45 = UILabel.丈丆不万丟且东七且;
            if(UILabel.丈丆不万丟且东七且 == null)
        {
                val_45 = UILabel.丈丆不万丟且东七且;
        }
        
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_45, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  UILabel.丈丆不万丟且东七且 + 24, 丈丝世且万世丈丌万:  UILabel.丈丆不万丟且东七且 + 24, 三丟东丕丄丄下下丑:  this.mEffectDistance, 丒丒丄丁且丄丆丂丌:  0f);
            val_47 = UILabel.丈丆不万丟且东七且;
            if(UILabel.丈丆不万丟且东七且 == null)
        {
                val_47 = UILabel.丈丆不万丟且东七且;
        }
        
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_47, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  UILabel.丈丆不万丟且东七且 + 24, 丈丝世且万世丈丌万:  UILabel.丈丆不万丟且东七且 + 24, 三丟东丕丄丄下下丑:  0f, 丒丒丄丁且丄丆丂丌:  val_19);
            val_29 = UILabel.丈丆不万丟且东七且;
            val_49 = val_29;
            if(val_29 == null)
        {
                val_49 = UILabel.丈丆不万丟且东七且;
        }
        
            this.ApplyShadow(丗丞不丞业丑七且丗:  val_49, 丂丙丆丂丑丝丂丝丒:  UILabel.七业丐丆东丁东且与, 丗丄丌丝丌上世丄丘:  UILabel.丆丒丛一业不世丞下, 丄且一丄丏丆丐丗与:  UILabel.丈丆不万丟且东七且 + 24, 丈丝世且万世丈丌万:  UILabel.丈丆不万丟且东七且 + 24, 三丟东丕丄丄下下丑:  0f, 丒丒丄丁且丄丆丂丌:  -val_19);
        }
        
        }
        
        label_67:
        val_50 = null;
        val_50 = null;
        丗丞不丞业丑七且丗.万上下丌丏世下与世(下丈丌三且三丝丄与:  UILabel.丈丆不万丟且东七且);
        丂丙丆丂丑丝丂丝丒.万上下丌丏世下与世(下丈丌三且三丝丄与:  UILabel.七业丐丆东丁东且与);
        丗丄丌丝丌上世丄丘.万上下丌丏世下与世(下丈丌三且三丝丄与:  UILabel.丆丒丛一业不世丞下);
    }
    public UnityEngine.Vector2 ApplyOffset(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, int 丄且一丄丏丆丐丗与)
    {
        var val_5;
        var val_11;
        var val_12;
        float val_13;
        var val_15;
        float val_16;
        val_11 = 丄且一丄丏丆丐丗与;
        UnityEngine.Vector2 val_1 = this.pivotOffset;
        float val_12 = val_1.y;
        float val_2 = UnityEngine.Mathf.Lerp(a:  0f, b:  -1.371218E+08f, t:  val_1.x);
        float val_3 = UnityEngine.Mathf.Lerp(a:  val_2, b:  0f, t:  val_12);
        float val_11 = val_3;
        val_11 = 0f - val_11;
        val_12 = val_3 + (UnityEngine.Mathf.Lerp(a:  val_11, b:  0f, t:  val_12));
        if(val_2 >= 0f)
        {
            goto label_3;
        }
        
        if((double)val_2 != (-0.5))
        {
            goto label_4;
        }
        
        val_12 = val_5;
        val_13 = -1f;
        goto label_5;
        label_3:
        if((double)val_2 != 0.5)
        {
            goto label_6;
        }
        
        val_12 = val_5;
        val_13 = 1f;
        label_5:
        val_13 = (float)val_12 + val_13;
        var val_6 = (((long)val_12 & 1) != 0) ? ((float)val_12) : (val_13);
        goto label_8;
        label_4:
        float val_13 = -0.5f;
        val_13 = val_2 + val_13;
        goto label_8;
        label_6:
        float val_14 = 0.5f;
        val_14 = val_2 + val_14;
        label_8:
        if(val_12 >= 0f)
        {
            goto label_9;
        }
        
        if((double)val_12 != (-0.5))
        {
            goto label_10;
        }
        
        val_15 = val_5;
        val_16 = -1f;
        goto label_11;
        label_9:
        if((double)val_12 != 0.5)
        {
            goto label_12;
        }
        
        val_15 = val_5;
        val_16 = 1f;
        label_11:
        val_16 = (float)val_15 + val_16;
        var val_7 = (((long)val_15 & 1) != 0) ? ((float)val_15) : (val_16);
        goto label_15;
        label_10:
        float val_15 = -0.5f;
        val_15 = val_12 + val_15;
        goto label_15;
        label_12:
        float val_16 = 0.5f;
        val_16 = val_12 + val_16;
        goto label_15;
        label_21:
        var val_8 = X23 + ((long)val_11 * 12);
        float val_17 = ((long)(int)(丄且一丄丏丆丐丗与) * 12) + X23 + 32;
        val_17 = val_2 + val_17;
        mem2[0] = val_17;
        float val_18 = ((long)(int)(丄且一丄丏丆丐丗与) * 12) + X23 + 36;
        val_11 = val_11 + 1;
        val_18 = val_12 + val_18;
        mem2[0] = val_18;
        label_15:
        if(val_11 < (X23 + ((long)val_11 * 12)))
        {
            goto label_21;
        }
        
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_2, y:  val_12);
        return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
    }
    public void ApplyShadow(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘, int 丄且一丄丏丆丐丗与, int 丈丝世且万世丈丌万, float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌)
    {
        int val_17;
        float val_18;
        UnityEngine.Object val_19;
        float val_20;
        float val_25;
        int val_18 = 丈丝世且万世丈丌万;
        val_17 = 丄且一丄丏丆丐丗与;
        val_18 = mem[1152921535338585796];
        float val_15 = mem[1152921535338585484];
        val_19 = mem[1152921535338585744];
        val_15 = val_18 * val_15;
        val_20 = mem[1152921535338585788];
        if(val_19 != 0)
        {
                val_19 = mem[1152921535338585744];
            val_20 = mem[1152921535338585788];
            if(val_19.premultipliedAlphaShader != false)
        {
                val_20 = mem[1152921535338585788];
            UnityEngine.Color val_3 = 不丌丂丁丄一与丆丙.下丑与且丅丛丁丄丒(丁丂专业丁丅丅丈丙:  new UnityEngine.Color() {r = mem[1152921535338585784], g = val_20, b = mem[1152921535338585792], a = val_15});
        }
        
        }
        
        UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        if(val_17 >= val_18)
        {
                return;
        }
        
        var val_16 = (long)val_18;
        val_16 = val_16 - (val_17 << );
        label_38:
        丗丞不丞业丑七且丗.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector3() {x = mem[1152921535475707168], y = mem[1152921535475707172], z = mem[1152921535475707176]});
        int val_7 = 137121792 + val_18;
        丂丙丆丂丑丝丂丝丒.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Vector2() {x = (137121792 + 丈丝世且万世丈丌万) + 32, y = (137121792 + 丈丝世且万世丈丌万) + 32 + 4});
        丗丄丌丝丌上世丄丘.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  new UnityEngine.Color32() {r = mem[1152921535475707168], g = mem[1152921535475707168], b = mem[1152921535475707168], a = mem[1152921535475707168]});
        val_25 = mem[1152921535475707168] + 三丟东丕丄丄下下丑;
        val_18 = mem[1152921535475707172] + 丒丒丄丁且丄丆丂丌;
        int val_8 = val_17 + 1152921535338585376;
        mem2[0] = val_25;
        mem2[0] = val_18;
        mem2[0] = mem[1152921535475707176];
        UILabel val_9 = mem[1152921535475707176] + 1152921535338585376;
        var val_17 = (mem[1152921535475707176] + 1152921535338585376) + 0;
        val_17 = val_17 >> 24;
        if(val_17 == 255)
        {
            goto label_24;
        }
        
        val_18 = (float)val_17 / 255f;
        val_25 = val_15 * val_18;
        if((mem[1152921535338585744] != 0) && (mem[1152921535338585744].premultipliedAlphaShader != false))
        {
                UnityEngine.Color val_12 = 不丌丂丁丄一与丆丙.下丑与且丅丛丁丄丒(丁丂专业丁丅丅丈丙:  new UnityEngine.Color() {r = mem[1152921535338585784], g = mem[1152921535338585788], b = mem[1152921535338585792], a = val_25});
            val_25 = val_12.a;
        }
        
        UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = mem[1152921535338585784], g = mem[1152921535338585788], b = mem[1152921535338585792], a = val_25});
        val_17 = val_13.r;
        if((val_17 + 0) < (mem[1152921535475707176] + 24))
        {
            goto label_35;
        }
        
        goto label_35;
        label_24:
        val_17 = val_4.r & 4294967295;
        label_35:
        UILabel val_14 = mem[1152921535475707176] + 1152921535338585376;
        mem2[0] = val_17;
        val_19 = 0 + 1;
        val_18 = val_18 + 8;
        if(val_16 != val_19)
        {
            goto label_38;
        }
    
    }
    public int CalculateOffsetToFit(string 丕丗丘丑丛与丑业丒)
    {
        var val_2;
        this.UpdateNGUIText();
        val_2 = null;
        val_2 = null;
        丐丄七丙丁丆丁专丏.丛业丈丌丏不丘且丗 = false;
        丐丄七丙丁丆丁专丏.七一上丘万东丕世丘 = 0;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        return (int)丐丄七丙丁丆丁专丏.丌三丘东下丈丅丙万(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    public void SetCurrentProgress()
    {
        if(UIProgressBar.current == 0)
        {
                return;
        }
        
        this.text = UIProgressBar.current.value.ToString(format:  "F");
    }
    public void SetCurrentPercent()
    {
        if(UIProgressBar.current == 0)
        {
                return;
        }
        
        float val_5 = 100f;
        val_5 = UIProgressBar.current.value * val_5;
        this.text = UnityEngine.Mathf.RoundToInt(f:  val_5)(UnityEngine.Mathf.RoundToInt(f:  val_5)) + "%"("%");
    }
    public void SetCurrentSelection()
    {
        var val_3;
        var val_4;
        var val_5;
        string val_6;
        var val_7;
        val_3 = null;
        val_3 = null;
        if(UIPopupList.专三丆三与下丕丆不 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(UIPopupList.专三丆三与下丕丆不 == 0)
        {
                val_4 = null;
        }
        
        if((UIPopupList.专三丆三与下丕丆不 + 153) != 0)
        {
                val_5 = null;
            string val_2 = 丛丝丝丈丝丞丒业丝.丐下下丅与上东丙丑(下上丐丆丝丟丝丒不:  UIPopupList.专三丆三与下丕丆不);
        }
        else
        {
                val_7 = null;
            val_6 = UIPopupList.专三丆三与下丕丆不;
        }
        
        this.text = val_6;
    }
    public bool Wrap(string 丕丗丘丑丛与丑业丒, out string 专丒丕丒上上丒丄七)
    {
        return this.Wrap(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 专丒丕丒上上丒丄七: out  string val_1 = 专丒丕丒上上丒丄七, 丟丌丐丘丆丙丑丑一:  1000000);
    }
    public bool Wrap(string 丕丗丘丑丛与丑业丒, out string 专丒丕丒上上丒丄七, int 丟丌丐丘丆丙丑丑一)
    {
        var val_4;
        this.UpdateNGUIText();
        val_4 = null;
        val_4 = null;
        丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙 = 丟丌丐丘丆丙丑丑一;
        丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 = 丟丌丐丘丆丙丑丑一;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        return (bool)丐丄七丙丁丆丁专丏.丌丌丐丌丑丞万且丛(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丆万丁丛丝三丅丅东: out  string val_1 = 专丒丕丒上上丒丄七, 世丅丆丟世丞上世世:  false);
    }
    public void UpdateNGUIText()
    {
        UnityEngine.Object val_25;
        var val_26;
        bool val_27;
        var val_28;
        float val_29;
        float val_30;
        float val_31;
        var val_32;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        float val_39;
        var val_40;
        float val_41;
        var val_42;
        丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 val_43;
        val_25 = this.trueTypeFont;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  val_25, y:  0);
        val_26 = null;
        val_26 = null;
        丐丄七丙丁丆丁专丏.东丈丝丌丑丈丛丐丅 = this.丛丆丛丕丏丙丛不丄;
        丐丄七丙丁丆丁专丏.东业丏专丛丁与丙丒 = this.mFontStyle;
        丐丄七丙丁丆丁专丏.丅丈丌丅丆丕万世丑 = this.mFontStyle;
        丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙 = this.mFontStyle;
        float val_24 = (float)this.丛丆丛丕丏丙丛不丄;
        float val_3 = S8 - S9;
        val_24 = val_3 * val_24;
        丐丄七丙丁丆丁专丏.丐丄丗上丂丑丙丑丗 = UnityEngine.Mathf.RoundToInt(f:  val_24);
        val_24 = val_24 - S2;
        val_24 = val_24 * val_3;
        丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 = UnityEngine.Mathf.RoundToInt(f:  val_24);
        if(this.mApplyGradient == false)
        {
            goto label_7;
        }
        
        if(this.mFont != 0)
        {
            goto label_10;
        }
        
        val_27 = 1;
        goto label_12;
        label_7:
        val_27 = 0;
        goto label_12;
        label_10:
        val_27 = (~this.mFont.packedFontShader) & 1;
        label_12:
        val_28 = null;
        val_28 = null;
        丐丄七丙丁丆丁专丏.丂丝且专丒三世丞丐 = val_27;
        丐丄七丙丁丆丁专丏.三世丂丑丂且专三丘 = this.mGradientTop;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_68 = 丐丄七丙丁丆丁专丏.__il2cppRuntimeField_static_fields;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_70 = ???;
        丐丄七丙丁丆丁专丏.丒丂丑七丞丞丏丂丆 = this.mGradientBottom;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_58 = 丐丄七丙丁丆丁专丏.__il2cppRuntimeField_static_fields;
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.__il2cppRuntimeField_60 = ???;
        丐丄七丙丁丆丁专丏.丛业丈丌丏不丘且丗 = this.mEncoding;
        丐丄七丙丁丆丁专丏.丗万丁丟丐一丕丂上 = this.且丟且丏一丑三丑丆;
        丐丄七丙丁丆丁专丏.七一上丘万东丕世丘 = this.mSymbols;
        丐丄七丙丁丆丁专丏.丈专不丅丌丅丂丆丑 = this.mMaxLineCount;
        if(this.mUseFloatSpacing != false)
        {
                val_29 = this.mFloatSpacingX;
        }
        else
        {
                val_29 = (float)this.mSpacingX;
        }
        
        丐丄七丙丁丆丁专丏.丅丑世丈东丛丈丑三 = val_29;
        if(this.mUseFloatSpacing != false)
        {
                val_30 = this.mFloatSpacingY;
        }
        else
        {
                val_30 = (float)this.mSpacingY;
        }
        
        丐丄七丙丁丆丁专丏.上业丞且丆丏丘与三 = val_30;
        if(val_2 != false)
        {
                val_31 = this.丟丕世万七且万丌丈;
        }
        else
        {
                val_30 = this.丟丕世万七且万丌丈;
            val_28 = null;
            float val_25 = (float)this.mFontSize;
            val_25 = val_25 / (float)this.mFont.defaultSize;
            val_31 = val_30 * val_25;
        }
        
        val_28 = null;
        丐丄七丙丁丆丁专丏.东丞丐丅丙下万丘丘 = val_31;
        if(this.mFont == 0)
        {
            goto label_27;
        }
        
        goto label_42;
        label_27:
        val_32 = null;
        val_32 = null;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = val_25;
        goto label_33;
        label_42:
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = this.mFont;
        val_34 = null;
        val_34 = null;
        val_35 = null;
        if(丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁.replacement == 0)
        {
            goto label_39;
        }
        
        goto label_42;
        label_39:
        val_35 = null;
        val_25 = 丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁;
        val_36 = null;
        if(val_25.isDynamic == false)
        {
            goto label_46;
        }
        
        val_37 = null;
        val_25 = 丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = val_25.dynamicFont;
        label_33:
        丐丄七丙丁丆丁专丏.丝万业丏丐丈世专丁 = 0;
        if(val_2 == true)
        {
            goto label_50;
        }
        
        goto label_55;
        label_46:
        val_38 = null;
        丐丄七丙丁丆丁专丏.丝丈丌丏丂丘丟丙专 = 0;
        if(val_2 == false)
        {
            goto label_55;
        }
        
        label_50:
        if(this.上上丁丐万丒万且业() == false)
        {
            goto label_55;
        }
        
        UIRoot val_15 = this.root;
        if(val_15 == 0)
        {
            goto label_58;
        }
        
        if(val_15 == 0)
        {
            goto label_61;
        }
        
        val_39 = val_15.pixelSizeAdjustment;
        goto label_63;
        label_55:
        val_39 = 1f;
        goto label_66;
        label_58:
        val_40 = null;
        goto label_67;
        label_61:
        val_39 = 1f;
        label_63:
        label_66:
        val_40 = null;
        丐丄七丙丁丆丁专丏.业与与丂业丐一下一 = val_39;
        label_67:
        val_41 = this.业丒丙三丑丈丄业专;
        val_40 = null;
        if(val_41 != 丐丄七丙丁丆丁专丏.业与与丂业丐一下一)
        {
                this.丈与下一东丘下丒业(专丄丛丆丈丏东一世:  false, 业业丄不东世丝丑专:  false);
            val_42 = null;
            val_42 = null;
            丐丄七丙丁丆丁专丏.丅丈丌丅丆丕万世丑 = val_15;
            丐丄七丙丁丆丁专丏.一丕世万丙丛丆丆丙 = 丐丄七丙丁丆丁专丏.__il2cppRuntimeField_static_fields;
            float val_26 = (float)val_15;
            float val_19 = val_41 - S9;
            val_26 = val_19 * val_26;
            丐丄七丙丁丆丁专丏.丐丄丗上丂丑丙丑丗 = UnityEngine.Mathf.RoundToInt(f:  val_26);
            val_26 = val_26 - (float)this.mFont.defaultSize;
            val_26 = val_26 * val_19;
            val_40 = null;
            丐丄七丙丁丆丁专丏.一丞丏且三上丞丝丟 = UnityEngine.Mathf.RoundToInt(f:  val_26);
        }
        
        val_43 = this.mAlignment;
        if(val_43 == 0)
        {
            goto label_76;
        }
        
        goto label_88;
        label_76:
        七丐与七丌不丂丞且 val_22 = this.pivot;
        if(val_22 > 8)
        {
            goto label_82;
        }
        
        var val_27 = 1;
        val_27 = val_27 << val_22;
        if((val_27 & 73) != 0)
        {
            goto label_81;
        }
        
        val_27 = val_27 & 292;
        if(val_27 == 0)
        {
            goto label_82;
        }
        
        val_43 = 3;
        goto label_88;
        label_81:
        val_43 = 1;
        goto label_88;
        label_82:
        val_43 = 2;
        label_88:
        丐丄七丙丁丆丁专丏.世丕七丑丑丟不丙丏 = val_43;
        丐丄七丙丁丆丁专丏.上专丄丑专丑丘业丌();
    }
    private void OnApplicationPause(bool 丆丕与三丝丙丑丛三)
    {
        if(丆丕与三丝丙丑丛三 == true)
        {
                return;
        }
        
        if(this.mTrueTypeFont == 0)
        {
                return;
        }
        
        this.Invalidate(丕丐丟下东专丒丘业:  false);
    }
    public UILabel()
    {
        this.keepCrispWhenShrunk = 1;
        this.mFontSize = 16;
        this.mEncoding = 1;
        this.mText = "";
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        this.mEffectColor = val_1;
        mem[1152921535339799324] = val_1.g;
        mem[1152921535339799328] = val_1.b;
        mem[1152921535339799332] = val_1.a;
        this.mSymbols = 1;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
        this.mEffectDistance = val_2;
        mem[1152921535339799344] = val_2.y;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.mGradientTop = val_3;
        mem[1152921535339799368] = val_3.g;
        mem[1152921535339799372] = val_3.b;
        mem[1152921535339799376] = val_3.a;
        this.mMultiline = 1;
        this.业丒丙三丑丈丄业专 = 1f;
        this.mGradientBottom = 0;
        mem[1152921535339799384] = 0;
        mem[1152921535339799392] = 0;
        this.丁丛下专丗丁丞万上 = 1;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丆丛丟专丒丞丕丟丑 = val_4;
        mem[1152921535339799472] = val_4.y;
        this.丟丕世万七且万丌丈 = 1f;
        this.copyTo = new System.Collections.Generic.List<UILabel>(capacity:  0);
    }
    private static UILabel()
    {
        UILabel.丟丂与东业专三丕丏 = new 丒丞丕丕七丁丗丟丛<UILabel>();
        UILabel.丕丐七丂三专三丕丐 = new System.Collections.Generic.Dictionary<UnityEngine.Font, System.Int32>();
        UILabel.一且丅丏丆丂丐丘丗 = false;
        UILabel.丕丙丒丘丈丞丙丒业 = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3>();
        UILabel.三丁丙丘上丆丑且东 = new 丒丞丕丕七丁丗丟丛<System.Int32>();
        UILabel.丈丆不万丟且东七且 = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector3>(丏上万丅丏一不不丕:  184);
        UILabel.七业丐丆东丁东且与 = new 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2>(丏上万丅丏一不不丕:  184);
        UILabel.丆丒丛一业不世丞下 = new 丒丞丕丕七丁丗丟丛<UnityEngine.Color32>(丏上万丅丏一不不丕:  184);
    }

}
