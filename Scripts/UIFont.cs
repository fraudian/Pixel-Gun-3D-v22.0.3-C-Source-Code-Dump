using UnityEngine;
public class UIFont : MonoBehaviour
{
    // Fields
    private UnityEngine.Material mMat;
    private UnityEngine.Rect mUVRect;
    private BMFont mFont;
    private UIAtlas mAtlas;
    private UIFont mReplacement;
    private System.Collections.Generic.List<BMSymbol> mSymbols;
    private UnityEngine.Font mDynamicFont;
    private int mDynamicFontSize;
    private UnityEngine.FontStyle mDynamicFontStyle;
    private UISpriteData 丂丑丌丂丝专丗丆东;
    private int 专丘三丏不一业丅丘;
    private int 丝丝丕丅丛丁业丅丁;
    
    // Properties
    public BMFont 丙万东与丐丝丐丄丛 { get; set; }
    public int 东丕丙丕业丈一丛丘 { get; set; }
    public int 且丟丘丒丕丕丅丁丞 { get; set; }
    public bool 万业丙世世丙丑上丄 { get; }
    public System.Collections.Generic.List<BMSymbol> 丙丝不下东丆上丆丙 { get; }
    public UIAtlas 不丗丐丘业专丂丝上 { get; set; }
    public UnityEngine.Material 丘上专不丂万业不一 { get; set; }
    public bool 一丘下丝丏不七丟下 { get; }
    public bool 丆与丄与且丅丌丛丂 { get; }
    public bool 专丐上丈三七东业业 { get; }
    public UnityEngine.Texture2D 与万丆丛丒万丝丙丑 { get; }
    public UnityEngine.Rect 世丈丆丆丙一一三与 { get; set; }
    public string 万丑丞一丝丌丐丒丘 { get; set; }
    public bool 丕且七业丙万丕丛丞 { get; }
    public int 丟丒且一专丟丙下一 { get; set; }
    public int 万丐丕东万专专丛万 { get; set; }
    public UISpriteData 与丄丈丘丟丕丏丐丁 { get; }
    public UIFont 丙一与丗丞丞丞丘丅 { get; set; }
    public bool 一东且上丏三丒一丅 { get; }
    public UnityEngine.Font 丝丈丌丏丂丘丟丙专 { get; set; }
    public UnityEngine.FontStyle 丐丟三丛丙丈丟丂三 { get; set; }
    private UnityEngine.Texture 丑世丂东丗上丝丅业 { get; }
    
    // Methods
    public BMFont get_bmFont()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (BMFont)this.mReplacement.mFont;
    }
    public void set_bmFont(BMFont 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        this.mReplacement.mFont = 丙业与丙丗丝不丈东;
    }
    public int get_texWidth()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mFont == null)
        {
                return 1;
        }
        
        return this.mReplacement.mFont.texWidth;
    }
    public void set_texWidth(int 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mFont == null)
        {
                return;
        }
        
        this.mReplacement.mFont.texWidth = 丙业与丙丗丝不丈东;
    }
    public int get_texHeight()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mFont == null)
        {
                return 1;
        }
        
        return this.mReplacement.mFont.texHeight;
    }
    public void set_texHeight(int 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mFont == null)
        {
                return;
        }
        
        this.mReplacement.mFont.texHeight = 丙业与丙丗丝不丈东;
    }
    public bool get_hasSymbols()
    {
        UIFont val_4;
        System.Collections.Generic.List<BMSymbol> val_5;
        val_4 = this;
        goto label_1;
        label_5:
        val_4 = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        val_5 = this.mReplacement.mSymbols;
        if(val_5 == null)
        {
                return (bool)(val_5.Count != 0) ? 1 : 0;
        }
        
        return (bool)(val_5.Count != 0) ? 1 : 0;
    }
    public System.Collections.Generic.List<BMSymbol> get_symbols()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (System.Collections.Generic.List<BMSymbol>)this.mReplacement.mSymbols;
    }
    public UIAtlas get_atlas()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (UIAtlas)this.mReplacement.mAtlas;
    }
    public void set_atlas(UIAtlas 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mAtlas == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mReplacement.专丘三丏不一业丅丘 = 0;
        this.mReplacement.mAtlas = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 != 0)
        {
                this.mReplacement.mMat = this.mReplacement.mAtlas.spriteMaterial;
            if(this.sprite != null)
        {
                UnityEngine.Rect val_6 = this.uvRect;
            this.mReplacement.mUVRect = val_6;
            mem2[0] = val_6.m_YMin;
            mem2[0] = val_6.m_Width;
            mem2[0] = val_6.m_Height;
        }
        
        }
        
        this.MarkAsChanged();
    }
    public UnityEngine.Material get_material()
    {
        UIFont val_10;
        UIFont val_11;
        UnityEngine.Material val_12;
        val_10 = this;
        goto label_1;
        label_5:
        val_10 = this.mReplacement;
        label_1:
        val_11 = this.mReplacement.mReplacement;
        if(val_11 != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mAtlas != 0)
        {
                if(this.mReplacement.mAtlas != null)
        {
                return this.mReplacement.mAtlas.spriteMaterial;
        }
        
            return this.mReplacement.mAtlas.spriteMaterial;
        }
        
        if(this.mReplacement.mMat != 0)
        {
                if(this.mReplacement.mDynamicFont != 0)
        {
                val_11 = this.mReplacement.mDynamicFont.material;
            if(this.mReplacement.mMat != val_11)
        {
                val_11 = this.mReplacement.mDynamicFont.material.mainTexture;
            this.mReplacement.mMat.mainTexture = val_11;
        }
        
        }
        
            val_12 = this.mReplacement.mMat;
            return val_12;
        }
        
        val_12 = 0;
        if(this.mReplacement.mDynamicFont == 0)
        {
                return val_12;
        }
        
        if(this.mReplacement.mDynamicFont != null)
        {
                return this.mReplacement.mDynamicFont.material;
        }
        
        return this.mReplacement.mDynamicFont.material;
    }
    public void set_material(UnityEngine.Material 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mMat == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mReplacement.专丘三丏不一业丅丘 = 0;
        this.mReplacement.mMat = 丙业与丙丗丝不丈东;
        this.MarkAsChanged();
    }
    public bool get_premultipliedAlpha()
    {
        return this.premultipliedAlphaShader;
    }
    public bool get_premultipliedAlphaShader()
    {
        UIFont val_12;
        UIFont val_13;
        int val_14;
        val_12 = this;
        goto label_1;
        label_5:
        val_12 = this.mReplacement;
        label_1:
        val_13 = this.mReplacement.mReplacement;
        if(val_13 != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mAtlas != 0)
        {
                if(this.mReplacement.mAtlas != null)
        {
                return this.mReplacement.mAtlas.premultipliedAlpha;
        }
        
            return this.mReplacement.mAtlas.premultipliedAlpha;
        }
        
        val_14 = this.mReplacement.专丘三丏不一业丅丘;
        if(val_14 != 1)
        {
                return (bool)(val_14 == 1) ? 1 : 0;
        }
        
        UnityEngine.Material val_3 = val_12.material;
        if(val_3 == 0)
        {
            goto label_17;
        }
        
        val_13 = val_3.shader;
        if(val_13 == 0)
        {
            goto label_17;
        }
        
        val_14 = val_3.shader.name.Contains(value:  "Premultiplied");
        goto label_21;
        label_17:
        val_14 = 0;
        label_21:
        this.mReplacement.专丘三丏不一业丅丘 = val_14;
        return (bool)(val_14 == 1) ? 1 : 0;
    }
    public bool get_packedFontShader()
    {
        UIFont val_12;
        UIFont val_13;
        var val_14;
        int val_15;
        val_12 = this;
        goto label_1;
        label_5:
        val_12 = this.mReplacement;
        label_1:
        val_13 = this.mReplacement.mReplacement;
        if(val_13 != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mAtlas != 0)
        {
                val_14 = 0;
            return (bool)(val_15 == 1) ? 1 : 0;
        }
        
        val_15 = this.mReplacement.丝丝丕丅丛丁业丅丁;
        if(val_15 != 1)
        {
                return (bool)(val_15 == 1) ? 1 : 0;
        }
        
        UnityEngine.Material val_3 = val_12.material;
        if(val_3 == 0)
        {
            goto label_17;
        }
        
        val_13 = val_3.shader;
        if(val_13 == 0)
        {
            goto label_17;
        }
        
        val_15 = val_3.shader.name.Contains(value:  "Packed");
        goto label_21;
        label_17:
        val_15 = 0;
        label_21:
        this.mReplacement.丝丝丕丅丛丁业丅丁 = val_15;
        return (bool)(val_15 == 1) ? 1 : 0;
    }
    public UnityEngine.Texture2D get_texture()
    {
        UIFont val_6;
        var val_7;
        val_6 = this;
        goto label_1;
        label_5:
        val_6 = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        UnityEngine.Material val_2 = val_6.material;
        val_7 = 0;
        if(val_2 == 0)
        {
                return (UnityEngine.Texture2D)(null == null) ? (val_4) : 0;
        }
        
        UnityEngine.Texture val_4 = val_2.mainTexture;
        if(val_4 == null)
        {
                return (UnityEngine.Texture2D)(null == null) ? (val_4) : 0;
        }
        
        return (UnityEngine.Texture2D)(null == null) ? (val_4) : 0;
    }
    public UnityEngine.Rect get_uvRect()
    {
        if(this.mReplacement != 0)
        {
                this = this.mReplacement;
            if(this != null)
        {
                return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        
        if(this.mAtlas != 0)
        {
                if(this.sprite != null)
        {
                return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        
        }
        
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    public void set_uvRect(UnityEngine.Rect 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.sprite != null)
        {
                return;
        }
        
        if((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = this.mReplacement.mUVRect, m_YMin = 丙业与丙丗丝不丈东.m_YMin, m_Width = 丙业与丙丗丝不丈东.m_Width, m_Height = 丙业与丙丗丝不丈东.m_Height}, rhs:  new UnityEngine.Rect() {m_XMin = 丙业与丙丗丝不丈东.m_XMin, m_YMin = 丙业与丙丗丝不丈东.m_YMin, m_Width = 丙业与丙丗丝不丈东.m_Width, m_Height = 丙业与丙丗丝不丈东.m_Height})) == false)
        {
                return;
        }
        
        this.mReplacement.mUVRect = 丙业与丙丗丝不丈东;
        mem2[0] = 丙业与丙丗丝不丈东.m_YMin;
        mem2[0] = 丙业与丙丗丝不丈东.m_Width;
        mem2[0] = 丙业与丙丗丝不丈东.m_Height;
        this.MarkAsChanged();
    }
    public string get_spriteName()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mFont != null)
        {
                return this.mReplacement.mFont.spriteName;
        }
        
        return this.mReplacement.mFont.spriteName;
    }
    public void set_spriteName(string 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if((System.String.op_Inequality(a:  this.mReplacement.mFont.spriteName, b:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
        this.mReplacement.mFont.spriteName = 丙业与丙丗丝不丈东;
        this.MarkAsChanged();
    }
    public bool get_isValid()
    {
        if(this.mDynamicFont != 0)
        {
                return true;
        }
        
        if(this.mFont != null)
        {
                return this.mFont.isValid;
        }
        
        return this.mFont.isValid;
    }
    public int get_size()
    {
        return this.defaultSize;
    }
    public void set_size(int 丙业与丙丗丝不丈东)
    {
        this.defaultSize = 丙业与丙丗丝不丈东;
    }
    public int get_defaultSize()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.isDynamic == true)
        {
                return (int)this.mReplacement.mDynamicFontSize;
        }
        
        if(this.mReplacement.mFont == null)
        {
                return (int)this.mReplacement.mDynamicFontSize;
        }
        
        return this.mReplacement.mFont.charSize;
    }
    public void set_defaultSize(int 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        this.mReplacement.mDynamicFontSize = 丙业与丙丗丝不丈东;
    }
    public UISpriteData get_sprite()
    {
        UIFont val_12;
        var val_13;
        UIFont val_14;
        val_12 = this;
        goto label_1;
        label_5:
        val_12 = this.mReplacement;
        label_1:
        val_14 = this.mReplacement.mReplacement;
        if(val_14 != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.丂丑丌丂丝专丗丆东 != null)
        {
                return (UISpriteData)this.mReplacement.丂丑丌丂丝专丗丆东;
        }
        
        if(this.mReplacement.mAtlas == 0)
        {
                return (UISpriteData)this.mReplacement.丂丑丌丂丝专丗丆东;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mReplacement.mFont.spriteName)) == true)
        {
                return (UISpriteData)this.mReplacement.丂丑丌丂丝专丗丆东;
        }
        
        val_14 = this.mReplacement.mFont.spriteName;
        UISpriteData val_6 = this.mReplacement.mAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_14);
        this.mReplacement.丂丑丌丂丝专丗丆东 = val_6;
        if(val_6 != null)
        {
            goto label_14;
        }
        
        val_14 = val_12.name;
        UISpriteData val_8 = this.mReplacement.mAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_14);
        this.mReplacement.丂丑丌丂丝专丗丆东 = val_8;
        if(val_8 == null)
        {
            goto label_16;
        }
        
        label_14:
        val_12.UpdateUVRect();
        label_23:
        int val_9 = this.mReplacement.mSymbols.Count;
        if(val_9 < 1)
        {
                return (UISpriteData)this.mReplacement.丂丑丌丂丝专丗丆东;
        }
        
        val_13 = 1152921535314258720;
        do
        {
            val_12.symbols.Item[0].丄丙丒丒且七丟三七();
            val_14 = 0 + 1;
        }
        while(val_9 != val_14);
        
        return (UISpriteData)this.mReplacement.丂丑丌丂丝专丗丆东;
        label_16:
        this.mReplacement.mFont.spriteName = 0;
        goto label_23;
    }
    public UIFont get_replacement()
    {
        return (UIFont)this.mReplacement;
    }
    public void set_replacement(UIFont 丙业与丙丗丝不丈东)
    {
        UnityEngine.Object val_2 = (丙业与丙丗丝不丈东 != this) ? 0 : 丙业与丙丗丝不丈东;
        if(this.mReplacement == val_2)
        {
                return;
        }
        
        if(val_2 != 0)
        {
                bool val_5 = UnityEngine.Object.op_Equality(x:  val_1 != true ? 0 : 丙业与丙丗丝不丈东 + 64, y:  this);
        }
        
        if(this.mReplacement != 0)
        {
                this.MarkAsChanged();
        }
        
        this.mReplacement = val_2;
        if(val_2 != 0)
        {
                this.mMat = 0;
            this.mFont = 0;
            this.专丘三丏不一业丅丘 = 0;
            this.mDynamicFont = 0;
        }
        
        this.MarkAsChanged();
    }
    public bool get_isDynamic()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return UnityEngine.Object.op_Inequality(x:  this.mReplacement.mDynamicFont, y:  0);
    }
    public UnityEngine.Font get_dynamicFont()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (UnityEngine.Font)this.mReplacement.mDynamicFont;
    }
    public void set_dynamicFont(UnityEngine.Font 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mDynamicFont == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        if(this.mReplacement.mDynamicFont != 0)
        {
                this.material = 0;
        }
        
        this.mReplacement.mDynamicFont = 丙业与丙丗丝不丈东;
        this.MarkAsChanged();
    }
    public UnityEngine.FontStyle get_dynamicFontStyle()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (UnityEngine.FontStyle)this.mReplacement.mDynamicFontStyle;
    }
    public void set_dynamicFontStyle(UnityEngine.FontStyle 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mDynamicFontStyle == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.mReplacement.mDynamicFontStyle = 丙业与丙丗丝不丈东;
        this.MarkAsChanged();
    }
    private void 丝丙丆三丑东丈且丙()
    {
        int val_15;
        UISpriteData val_16;
        int val_17;
        val_15 = this;
        if(this.mAtlas.texture == 0)
        {
                return;
        }
        
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
                return;
        }
        
        UnityEngine.Rect val_7 = 万丗丅且丄丑世专与.与且万东一丕且丄丆(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = this.mUVRect, m_YMin = V9.16B, m_Width = V10.16B, m_Height = V11.16B}, 业与三万七丝不万东:  this.texture.width, 丟丌丐丘丆丙丑丑一:  this.texture.height, 丟东丝专丒丒且不且:  true);
        val_16 = this.丂丑丌丂丝专丗丆东;
        if(val_16 == null)
        {
            goto label_8;
        }
        
        val_17 = this.丂丑丌丂丝专丗丆东.x;
        goto label_9;
        label_8:
        val_17 = this.丂丑丌丂丝专丗丆东.x;
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_10;
        }
        
        val_16 = this.丂丑丌丂丝专丗丆东;
        label_9:
        label_14:
        label_15:
        float val_9 = val_7.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_9 = 0.x - val_9;
        val_9 = val_9 - val_9;
        float val_12 = val_7.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_12 = val_9 - val_12;
        val_12 = val_12 - val_12;
        val_15 = UnityEngine.Mathf.RoundToInt(f:  val_12);
        this.mFont.丝丙丆三丑东丈且丙(丘丄七七丝丞丄七万:  UnityEngine.Mathf.RoundToInt(f:  val_9), 与上世世专丐与丄丐:  UnityEngine.Mathf.RoundToInt(f:  val_9), 丌丝丘丑丘丂专丞丗:  UnityEngine.Mathf.RoundToInt(f:  val_12), 丏丐丘丗丙上世丏不:  val_15);
        return;
        label_10:
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_14;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_15;
        }
    
    }
    private bool 三一万丈万丈丟三丗(UIFont 丂一丂丗与丟业丆丙)
    {
        UnityEngine.Object val_4;
        var val_5;
        val_4 = this;
        goto label_7;
        label_11:
        if(丂一丂丗与丟业丆丙 == this)
        {
            goto label_3;
        }
        
        if(this.mReplacement == 0)
        {
            goto label_6;
        }
        
        val_4 = this.mReplacement;
        label_7:
        if(丂一丂丗与丟业丆丙 != 0)
        {
            goto label_11;
        }
        
        label_6:
        val_5 = 0;
        return (bool)val_5;
        label_3:
        val_5 = 1;
        return (bool)val_5;
    }
    public static bool CheckIfRelated(UIFont 丆丛丑世下一丐且丕, UIFont 丌丗丏丏丛东专丁且)
    {
        string val_12;
        var val_13;
        if(丆丛丑世下一丐且丕 != 0)
        {
                if(丌丗丏丏丛东专丁且 != 0)
        {
            goto label_6;
        }
        
        }
        
        val_13 = 0;
        return (bool)val_13;
        label_6:
        if((丆丛丑世下一丐且丕.isDynamic == false) || (丌丗丏丏丛东专丁且.isDynamic == false))
        {
            goto label_11;
        }
        
        val_12 = 丆丛丑世下一丐且丕.dynamicFont.fontNames[0];
        if((System.String.op_Equality(a:  val_12, b:  丌丗丏丏丛东专丁且.dynamicFont.fontNames[0])) == true)
        {
            goto label_23;
        }
        
        label_11:
        if(丆丛丑世下一丐且丕 != 丌丗丏丏丛东专丁且)
        {
                if((丆丛丑世下一丐且丕.三一万丈万丈丟三丗(丂一丂丗与丟业丆丙:  丌丗丏丏丛东专丁且)) == false)
        {
            goto label_25;
        }
        
        }
        
        label_23:
        val_13 = 1;
        return (bool)val_13;
        label_25:
        if(丌丗丏丏丛东专丁且 != null)
        {
                return 丌丗丏丏丛东专丁且.三一万丈万丈丟三丗(丂一丂丗与丟业丆丙:  丆丛丑世下一丐且丕);
        }
        
        return 丌丗丏丏丛东专丁且.三一万丈万丈丟三丗(丂一丂丗与丟业丆丙:  丆丛丑世下一丐且丕);
    }
    private UnityEngine.Texture 丑丕且万丟丙丂不丟()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if((UnityEngine.Object.op_Implicit(exists:  this.mReplacement.mReplacement)) == true)
        {
            goto label_5;
        }
        
        if(this.isDynamic == false)
        {
                return 0;
        }
        
        UnityEngine.Material val_3 = this.mReplacement.mDynamicFont.material;
        if(val_3 != null)
        {
                return val_3.mainTexture;
        }
        
        return val_3.mainTexture;
    }
    public void MarkAsChanged()
    {
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        UIFont val_19;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.mReplacement, y:  0);
        this.丂丑丌丂丝专丗丆东 = 0;
        val_15 = 1152921505093320704;
        if(val_2.Length < 1)
        {
            goto label_9;
        }
        
        val_16 = val_2.Length & 4294967295;
        val_17 = 0;
        goto label_10;
        label_22:
        val_16 = val_2.Length;
        val_17 = 1;
        label_10:
        if(((X21.enabled != false) && ((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  X21.gameObject)) != false)) && ((UIFont.CheckIfRelated(丆丛丑世下一丐且丕:  this, 丌丗丏丏丛东专丁且:  X21.bitmapFont)) != false))
        {
                if(X21 != 0)
        {
                val_19 = X21.bitmapFont;
            X21.bitmapFont = 0;
        }
        else
        {
                val_19 = 0.bitmapFont;
            0.bitmapFont = 0;
        }
        
            X21.bitmapFont = val_19;
        }
        
        if((val_16 - 1) != val_17)
        {
            goto label_22;
        }
        
        label_9:
        int val_12 = this.symbols.Count;
        if(val_12 < 1)
        {
                return;
        }
        
        val_15 = 1152921535314258720;
        do
        {
            this.symbols.Item[0].丄丙丒丒且七丟三七();
            val_18 = 0 + 1;
        }
        while(val_12 != val_18);
    
    }
    public void UpdateUVRect()
    {
        int val_10;
        UISpriteData val_11;
        int val_12;
        val_10 = 1152921504848912384;
        if(this.mAtlas == 0)
        {
                return;
        }
        
        UnityEngine.Texture val_2 = this.mAtlas.texture;
        if(val_2 == 0)
        {
                return;
        }
        
        val_11 = this.丂丑丌丂丝专丗丆东;
        if(val_11 == null)
        {
            goto label_8;
        }
        
        val_12 = this.丂丑丌丂丝专丗丆东.x;
        goto label_9;
        label_8:
        val_12 = this.丂丑丌丂丝专丗丆东.x;
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_10;
        }
        
        val_11 = this.丂丑丌丂丝专丗丆东;
        label_9:
        label_15:
        label_16:
        label_17:
        label_18:
        label_19:
        int val_10 = this.丂丑丌丂丝专丗丆东.paddingRight;
        label_20:
        label_23:
        int val_11 = this.丂丑丌丂丝专丗丆东.paddingBottom;
        int val_4 = val_12 - this.丂丑丌丂丝专丗丆东.paddingLeft;
        val_10 = (this.丂丑丌丂丝专丗丆东.paddingLeft + this.丂丑丌丂丝专丗丆东.width) + val_10;
        int val_7 = this.丂丑丌丂丝专丗丆东.y - this.丂丑丌丂丝专丗丆东.paddingTop;
        val_11 = (this.丂丑丌丂丝专丗丆东.paddingTop + this.丂丑丌丂丝专丗丆东.height) + val_11;
        this.mUVRect = 0;
        mem[1152921535316550788] = 0;
        mem[1152921535316550792] = 0;
        mem[1152921535316550796] = 0f;
        val_10 = val_2;
        UnityEngine.Rect val_8 = 万丗丅且丄丑世专与.不丟丌丙丞业丏万丂(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 业与三万七丝不万东:  val_10, 丟丌丐丘丆丙丑丑一:  val_2);
        this.mUVRect = val_8;
        mem[1152921535316550788] = val_8.m_YMin;
        mem[1152921535316550792] = val_8.m_Width;
        mem[1152921535316550796] = val_8.m_Height;
        if(this.丂丑丌丂丝专丗丆东.hasPadding == false)
        {
                return;
        }
        
        this.丝丙丆三丑东丈且丙();
        return;
        label_10:
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_15;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_16;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_17;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_18;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_19;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_20;
        }
        
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_21;
        }
        
        goto label_23;
        label_21:
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_23;
        }
    
    }
    private BMSymbol 丞丙丑丌丙下丒丅丘(string 上丌丆世丛不丝丈丒, bool 丐丗丏东丘东丘丈且)
    {
        string val_5;
        BMSymbol val_6;
        val_5 = 上丌丆世丛不丝丈丒;
        int val_1 = this.mSymbols.Count;
        if(val_1 >= 1)
        {
                var val_5 = 0;
            do
        {
            val_6 = this.mSymbols.Item[0];
            if((System.String.op_Equality(a:  val_2.sequence, b:  val_5)) == true)
        {
                return (BMSymbol)val_6;
        }
        
            val_5 = val_5 + 1;
        }
        while(val_5 < val_1);
        
        }
        
        if(丐丗丏东丘东丘丈且 != false)
        {
                BMSymbol val_4 = null;
            val_6 = val_4;
            val_4 = new BMSymbol();
            .sequence = val_5;
            val_5 = this.mSymbols;
            val_5.Add(item:  val_4);
            return (BMSymbol)val_6;
        }
        
        val_6 = 0;
        return (BMSymbol)val_6;
    }
    public BMSymbol MatchSymbol(string 丕丗丘丑丛与丑业丒, int 丛上丙丄丄七丈且丅, int 丙丈丐丙业丕世丞东)
    {
        var val_11;
        var val_12;
        UIAtlas val_13;
        int val_1 = this.mSymbols.Count;
        if((val_1 == 0) || (val_1 < 1))
        {
            goto label_3;
        }
        
        val_11 = 0;
        label_16:
        val_12 = this.mSymbols.Item[0];
        val_13 = val_12.length;
        if((val_13 == 0) || ((丙丈丐丙业丕世丞东 - 丛上丙丄丄七丈且丅) < val_13))
        {
            goto label_12;
        }
        
        if(val_13 < 1)
        {
            goto label_8;
        }
        
        var val_11 = 0;
        label_13:
        if(((丕丗丘丑丛与丑业丒.Chars[丛上丙丄丄七丈且丅 + val_11]) & 65535) != val_3.sequence.Chars[0])
        {
            goto label_12;
        }
        
        val_11 = val_11 + 1;
        if(val_11 < val_13)
        {
            goto label_13;
        }
        
        label_8:
        val_13 = this.atlas;
        if((val_12.丏且丕丄世丕不丕丙(不丗丐丘业专丂丝上:  val_13)) == true)
        {
                return (BMSymbol)val_12;
        }
        
        label_12:
        val_11 = val_11 + 1;
        if(val_11 < val_1)
        {
            goto label_16;
        }
        
        label_3:
        val_12 = 0;
        return (BMSymbol)val_12;
    }
    public void AddSymbol(string 上丌丆世丛不丝丈丒, string 万丑丞一丝丌丐丒丘)
    {
        BMSymbol val_1 = this.丞丙丑丌丙下丒丅丘(上丌丆世丛不丝丈丒:  上丌丆世丛不丝丈丒, 丐丗丏东丘东丘丈且:  true);
        val_1.spriteName = 万丑丞一丝丌丐丒丘;
        this.MarkAsChanged();
    }
    public void RemoveSymbol(string 上丌丆世丛不丝丈丒)
    {
        BMSymbol val_1 = this.丞丙丑丌丙下丒丅丘(上丌丆世丛不丝丈丒:  上丌丆世丛不丝丈丒, 丐丗丏东丘东丘丈且:  false);
        if(val_1 != null)
        {
                bool val_3 = this.symbols.Remove(item:  val_1);
        }
        
        this.MarkAsChanged();
    }
    public void RenameSymbol(string 且丕万丞丏世丄上丗, string 丂丆东上丂丏丟下专)
    {
        if((this.丞丙丑丌丙下丒丅丘(上丌丆世丛不丝丈丒:  且丕万丞丏世丄上丗, 丐丗丏东丘东丘丈且:  false)) != null)
        {
                val_1.sequence = 丂丆东上丂丏丟下专;
        }
        
        this.MarkAsChanged();
    }
    public bool UsesSprite(string 丏丛与丅丛丌万专丌)
    {
        string val_9;
        var val_10;
        if((System.String.IsNullOrEmpty(value:  丏丛与丅丛丌万专丌)) == false)
        {
            goto label_1;
        }
        
        label_12:
        val_10 = 0;
        return (bool)val_10;
        label_1:
        val_9 = this.spriteName;
        if((丏丛与丅丛丌万专丌.Equals(value:  val_9)) == true)
        {
            goto label_10;
        }
        
        val_9 = this.symbols.Count;
        if(val_9 < 1)
        {
            goto label_12;
        }
        
        var val_9 = 0;
        label_11:
        BMSymbol val_7 = this.symbols.Item[0];
        if((丏丛与丅丛丌万专丌.Equals(value:  val_7.spriteName)) == true)
        {
            goto label_10;
        }
        
        val_9 = val_9 + 1;
        if(val_9 < val_9)
        {
            goto label_11;
        }
        
        goto label_12;
        label_10:
        val_10 = 1;
        return (bool)val_10;
    }
    public UIFont()
    {
        this.mUVRect = 0;
        mem[1152921535317632772] = 0;
        mem[1152921535317632780] = 0;
        this.mFont = new BMFont();
        this.mSymbols = new System.Collections.Generic.List<BMSymbol>();
        this.mDynamicFontSize = 16;
        this.专丘三丏不一业丅丘 = 0;
        this.丝丝丕丅丛丁业丅丁 = 0;
    }

}
