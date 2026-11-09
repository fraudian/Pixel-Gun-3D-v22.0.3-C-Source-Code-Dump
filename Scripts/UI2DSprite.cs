using UnityEngine;
public class UI2DSprite : UIBasicSprite
{
    // Fields
    private UnityEngine.Sprite mSprite;
    private UnityEngine.Material mMat;
    private UnityEngine.Shader mShader;
    private UnityEngine.Vector4 mBorder;
    private bool mFixedAspect;
    private float mPixelSize;
    public UnityEngine.Sprite nextSprite;
    private int 专丘三丏不一业丅丘;
    
    // Properties
    public UnityEngine.Sprite 丁丏丁丑丟三丙丂丝 { get; set; }
    public override UnityEngine.Material 丘上专不丂万业不一 { get; set; }
    public override UnityEngine.Shader 丕丄与专丛丝丄丐下 { get; set; }
    public override UnityEngine.Texture 丒丕世丏丆丗三专丑 { get; }
    public override bool 一丘下丝丏不七丟下 { get; }
    public override float 一丞上丘一七丗丟与 { get; }
    public override UnityEngine.Vector4 丈丅且丛丑丞万丁丝 { get; }
    public override UnityEngine.Vector4 业三丏专丘专丏丛与 { get; set; }
    
    // Methods
    public UnityEngine.Sprite get_sprite2D()
    {
        return (UnityEngine.Sprite)this.mSprite;
    }
    public void set_sprite2D(UnityEngine.Sprite 丙业与丙丗丝不丈东)
    {
        if(this.mSprite == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.RemoveFromPanel();
        this.mSprite = 丙业与丙丗丝不丈东;
        this.nextSprite = 0;
        UIPanel val_2 = this.CreatePanel();
    }
    public override UnityEngine.Material get_material()
    {
        return (UnityEngine.Material)this.mMat;
    }
    public override void set_material(UnityEngine.Material 丙业与丙丗丝不丈东)
    {
        if(this.mMat == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.RemoveFromPanel();
        this.mMat = 丙业与丙丗丝不丈东;
        this.专丘三丏不一业丅丘 = 0;
        this.MarkAsChanged();
    }
    public override UnityEngine.Shader get_shader()
    {
        UnityEngine.Shader val_4;
        if(this.mMat != 0)
        {
                if(this.mMat != null)
        {
                return this.mMat.shader;
        }
        
            return this.mMat.shader;
        }
        
        if(this.mShader == 0)
        {
                this.mShader = UnityEngine.Shader.Find(name:  "Unlit/Transparent Colored");
            return val_4;
        }
        
        val_4 = this.mShader;
        return val_4;
    }
    public override void set_shader(UnityEngine.Shader 丙业与丙丗丝不丈东)
    {
        if(this.mShader == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.RemoveFromPanel();
        this.mShader = 丙业与丙丗丝不丈东;
        if(this.mMat != 0)
        {
                return;
        }
        
        this.专丘三丏不一业丅丘 = 0;
        this.MarkAsChanged();
    }
    public override UnityEngine.Texture get_mainTexture()
    {
        UnityEngine.Sprite val_4;
        var val_5;
        val_4 = this;
        if(this.mSprite != 0)
        {
                val_4 = this.mSprite;
            return (UnityEngine.Texture)val_4.texture;
        }
        
        val_5 = 0;
        if(this.mMat == 0)
        {
                return (UnityEngine.Texture)val_4.texture;
        }
        
        if(this.mMat != null)
        {
                return this.mMat.mainTexture;
        }
        
        return this.mMat.mainTexture;
    }
    public override bool get_premultipliedAlpha()
    {
        int val_6 = this.专丘三丏不一业丅丘;
        if(val_6 != 1)
        {
                return (bool)(val_6 == 1) ? 1 : 0;
        }
        
        if(this != 0)
        {
                val_6 = this.name.Contains(value:  "Premultiplied");
        }
        else
        {
                val_6 = 0;
        }
        
        this.专丘三丏不一业丅丘 = val_6;
        return (bool)(val_6 == 1) ? 1 : 0;
    }
    public override float get_pixelSize()
    {
        return (float)this.mPixelSize;
    }
    public override UnityEngine.Vector4 get_drawingDimensions()
    {
        float val_45;
        float val_46;
        float val_47;
        float val_48;
        float val_49;
        float val_50;
        var val_51;
        var val_52;
        var val_55;
        float val_56;
        float val_57;
        var val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        UnityEngine.Vector2 val_1 = this.pivotOffset;
        float val_2 = val_1.x * (float)val_1.x;
        float val_3 = val_1.y * (float)val_1.y;
        val_47 = -(val_1.x * (float)val_1.x);
        val_48 = -(val_1.y * (float)val_1.y);
        val_49 = (float)val_1.x - val_2;
        val_50 = (float)val_1.y - val_3;
        if(this.mSprite != 0)
        {
                UnityEngine.Rect val_5 = this.mSprite.rect;
            int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_5.m_XMin);
            UnityEngine.Rect val_7 = this.mSprite.rect;
            int val_8 = UnityEngine.Mathf.RoundToInt(f:  val_7.m_XMin);
            UnityEngine.Vector2 val_9 = this.mSprite.textureRectOffset;
            val_51 = UnityEngine.Mathf.RoundToInt(f:  val_9.x);
            UnityEngine.Vector2 val_11 = this.mSprite.textureRectOffset;
            UnityEngine.Rect val_13 = this.mSprite.rect;
            UnityEngine.Rect val_14 = this.mSprite.textureRect;
            UnityEngine.Vector2 val_15 = this.mSprite.textureRectOffset;
            val_15.x = (val_13.m_XMin - val_14.m_XMin) - val_15.x;
            val_52 = UnityEngine.Mathf.RoundToInt(f:  val_15.x);
            UnityEngine.Rect val_18 = this.mSprite.rect;
            UnityEngine.Rect val_19 = this.mSprite.textureRect;
            UnityEngine.Vector2 val_20 = this.mSprite.textureRectOffset;
            float val_21 = val_18.m_XMin - val_19.m_XMin;
            val_21 = val_21 - val_20.y;
            val_55 = 0;
            int val_22 = UnityEngine.Mathf.RoundToInt(f:  val_21);
            val_56 = 1f;
            if((val_6 >= 1) && (val_8 >= 1))
        {
                val_57 = val_56;
            float val_35 = (float)val_6;
            float val_36 = (float)val_8;
            val_35 = 1f / val_35;
            val_36 = 1f / val_36;
            val_52 = val_52 + (val_6 & 1);
            val_55 = val_22 + (val_8 & 1);
            val_57 = val_35 * (float)val_19.m_Height;
            val_56 = val_36 * (float)S4;
        }
        else
        {
                val_57 = val_56;
        }
        
            val_58 = val_52;
            float val_37 = (float);
            val_37 = val_57 * val_37;
            val_57 = val_57 * (float);
            val_47 = val_37 - val_2;
            val_49 = val_49 - val_57;
            val_59 = (float)val_22;
            val_60 = (float)UnityEngine.Mathf.RoundToInt(f:  val_11.y);
            val_46 = val_56 * ;
            val_45 = val_56 * ;
            val_48 = val_46 - val_3;
            val_50 = val_50 - val_45;
        }
        
        val_61 = 0f;
        val_62 = 0f;
        if(this.mFixedAspect != true)
        {
                UnityEngine.Vector4 val_26 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = val_45, y = val_46, w = (float)}, d:  val_45);
            val_50 = val_50;
            val_49 = val_49;
            val_62 = val_26.x + val_26.z;
            val_61 = val_26.y + val_26.w;
        }
        
        float val_28 = UnityEngine.Mathf.Lerp(a:  val_47, b:  val_49 - val_62, t:  val_45);
        float val_30 = UnityEngine.Mathf.Lerp(a:  val_48, b:  val_50 - val_61, t:  val_45);
        float val_32 = UnityEngine.Mathf.Lerp(a:  val_47 + val_62, b:  val_49, t:  val_45);
        float val_34 = UnityEngine.Mathf.Lerp(a:  val_48 + val_61, b:  val_50, t:  val_45);
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    public override UnityEngine.Vector4 get_border()
    {
        return new UnityEngine.Vector4() {x = this.mBorder};
    }
    public override void set_border(UnityEngine.Vector4 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Vector4.op_Inequality(lhs:  new UnityEngine.Vector4() {x = this.mBorder, y = V14.16B, z = V12.16B, w = V13.16B}, rhs:  new UnityEngine.Vector4() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z, w = 丙业与丙丗丝不丈东.w})) == false)
        {
                return;
        }
        
        this.mBorder = 丙业与丙丗丝不丈东;
        mem[1152921535281126620] = 丙业与丙丗丝不丈东.y;
        mem[1152921535281126624] = 丙业与丙丗丝不丈东.z;
        mem[1152921535281126628] = 丙业与丙丗丝不丈东.w;
        this.MarkAsChanged();
    }
    protected override void 丑丈丆万丅上丞丗丐()
    {
        UnityEngine.Sprite val_25;
        float val_26;
        float val_27;
        if(this.nextSprite != 0)
        {
                val_25 = this.mSprite;
            if(this.nextSprite != val_25)
        {
                this.sprite2D = this.nextSprite;
        }
        
            this.nextSprite = 0;
        }
        
        this.丑丈丆万丅上丞丗丐();
        if(this.mFixedAspect == false)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_4 = this.mSprite.rect;
        UnityEngine.Rect val_6 = this.mSprite.rect;
        val_25 = UnityEngine.Mathf.RoundToInt(f:  val_6.m_XMin);
        UnityEngine.Vector2 val_8 = this.mSprite.textureRectOffset;
        UnityEngine.Vector2 val_10 = this.mSprite.textureRectOffset;
        UnityEngine.Rect val_12 = this.mSprite.rect;
        UnityEngine.Rect val_13 = this.mSprite.textureRect;
        UnityEngine.Vector2 val_14 = this.mSprite.textureRectOffset;
        val_14.x = (val_12.m_XMin - val_13.m_XMin) - val_14.x;
        UnityEngine.Rect val_17 = this.mSprite.rect;
        UnityEngine.Rect val_18 = this.mSprite.textureRect;
        UnityEngine.Vector2 val_19 = this.mSprite.textureRectOffset;
        float val_20 = val_17.m_XMin - val_18.m_XMin;
        val_20 = val_20 - val_19.y;
        int val_22 = (UnityEngine.Mathf.RoundToInt(f:  val_10.y)) + val_25;
        int val_23 = (UnityEngine.Mathf.RoundToInt(f:  val_8.x)) + (UnityEngine.Mathf.RoundToInt(f:  val_4.m_XMin));
        val_22 = val_22 + (UnityEngine.Mathf.RoundToInt(f:  val_20));
        val_23 = val_23 + (UnityEngine.Mathf.RoundToInt(f:  val_14.x));
        float val_25 = (float)val_23;
        float val_27 = val_20;
        float val_26 = (float)val_19.y;
        float val_24 = val_27 / val_26;
        val_25 = val_25 / (float)val_22;
        if(val_25 < 0)
        {
                val_26 = val_25 * val_26;
            val_26 = val_27 - val_26;
            float val_28 = 0.5f;
            val_27 = val_26 / val_27;
            val_27 = val_27 * val_28;
            val_26 = 1f;
            val_28 = val_26 - val_27;
            val_27 = 0f;
        }
        else
        {
                val_27 = val_27 / val_25;
            val_27 = val_26 - val_27;
            val_27 = val_27 / val_26;
            val_27 = val_27 * 0.5f;
            val_26 = 1f - val_27;
        }
        
        this.drawRegion = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    public override void MakePixelPerfect()
    {
        this.MakePixelPerfect();
        if(true == 2)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        if((null != 0) && (null != 3))
        {
                if(S3 != 0f)
        {
                return;
        }
        
            if(S2 != 0f)
        {
                return;
        }
        
            if(S0 != 0f)
        {
                return;
        }
        
            if(S1 != 0f)
        {
                return;
        }
        
        }
        
        if(this == 0)
        {
                return;
        }
        
        UnityEngine.Rect val_3 = this.mSprite.rect;
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_3.m_XMin);
        int val_5 = UnityEngine.Mathf.RoundToInt(f:  val_3.m_XMin);
        this.width = (val_4 & 1) + val_4;
        this.height = (val_5 & 1) + val_5;
    }
    public override void OnFill(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        if(this == 0)
        {
                return;
        }
        
        if(this.mSprite != 0)
        {
                UnityEngine.Rect val_3 = this.mSprite.textureRect;
        }
        else
        {
                bool val_4 = this.isAnchoredHorizontally;
            bool val_5 = this.canBeAnchored;
        }
        
        float val_6 = 0f.x;
        val_6 = val_6 + 0f;
        val_6 = 0f + val_6;
        val_6 = val_6 - 0f;
        val_6 = val_6 - 0f;
        float val_12 = 1f;
        float val_8 = val_12 / (float)this.isAnchoredHorizontally;
        val_12 = val_12 / (float)this.canBeAnchored;
        float val_10 = 0f.System.IConvertible.ToSingle(provider:  0);
        val_10 = val_8 * val_10;
        val_10 = val_8 * val_10;
        val_10 = val_12 * val_10;
        val_10 = val_12 * val_10;
        float val_11 = 0f.x;
        val_11 = val_8 * val_11;
        val_11 = val_8 * val_11;
        val_11 = val_12 * val_11;
        val_11 = val_12 * val_11;
        this.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘, 丈丒丈丆丑丅丆丌丌:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 万万丁丄丑丌丙丝丏:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
    }
    public UI2DSprite()
    {
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
        this.mBorder = val_1;
        mem[1152921535281738460] = val_1.y;
        mem[1152921535281738464] = val_1.z;
        mem[1152921535281738468] = val_1.w;
        this.mPixelSize = 1f;
        this.专丘三丏不一业丅丘 = 0;
        mem[1152921535281738364] = 4;
        mem[1152921535281738412] = 1;
        mem[1152921535281738428] = 1;
        1152921535281738364 = new UIWidget();
    }

}
