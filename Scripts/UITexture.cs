using UnityEngine;
public class UITexture : UIBasicSprite
{
    // Fields
    private UnityEngine.Rect mRect;
    private UnityEngine.Texture mTexture;
    private UnityEngine.Material mMat;
    private UnityEngine.Shader mShader;
    private UnityEngine.Vector4 mBorder;
    private bool mFixedAspect;
    private int 专丘三丏不一业丅丘;
    
    // Properties
    public override UnityEngine.Texture 丒丕世丏丆丗三专丑 { get; set; }
    public override UnityEngine.Material 丘上专不丂万业不一 { get; set; }
    public override UnityEngine.Shader 丕丄与专丛丝丄丐下 { get; set; }
    public override bool 一丘下丝丏不七丟下 { get; }
    public override UnityEngine.Vector4 业三丏专丘专丏丛与 { get; set; }
    public UnityEngine.Rect 世丈丆丆丙一一三与 { get; set; }
    public override UnityEngine.Vector4 丈丅且丛丑丞万丁丝 { get; }
    public bool 万专东丏丕丒丌丏丂 { get; set; }
    
    // Methods
    public override UnityEngine.Texture get_mainTexture()
    {
        UnityEngine.Texture val_3;
        if(this.mTexture != 0)
        {
                val_3 = this.mTexture;
            return val_3;
        }
        
        val_3 = 0;
        if(this.mMat == 0)
        {
                return val_3;
        }
        
        if(this.mMat != null)
        {
                return this.mMat.mainTexture;
        }
        
        return this.mMat.mainTexture;
    }
    public override void set_mainTexture(UnityEngine.Texture 丙业与丙丗丝不丈东)
    {
        UnityEngine.Material val_4;
        if(this.mTexture == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        if(this.mTexture != 0)
        {
                val_4 = this.mMat;
            if(val_4 == 0)
        {
                this.mTexture = 丙业与丙丗丝不丈东;
            val_4.mainTexture = 丙业与丙丗丝不丈东;
            return;
        }
        
        }
        
        this.RemoveFromPanel();
        this.mTexture = 丙业与丙丗丝不丈东;
        this.专丘三丏不一业丅丘 = 0;
        this.MarkAsChanged();
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
        this.mShader = 0;
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
        UnityEngine.Material val_4;
        if(this.mShader == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        if(this.mShader != 0)
        {
                val_4 = this.mMat;
            if(val_4 == 0)
        {
                this.mShader = 丙业与丙丗丝不丈东;
            val_4.shader = 丙业与丙丗丝不丈东;
            return;
        }
        
        }
        
        this.RemoveFromPanel();
        this.mMat = 0;
        this.mShader = 丙业与丙丗丝不丈东;
        this.专丘三丏不一业丅丘 = 0;
        this.MarkAsChanged();
    }
    public override bool get_premultipliedAlpha()
    {
        int val_9 = this.专丘三丏不一业丅丘;
        if(val_9 != 1)
        {
                return (bool)(val_9 == 1) ? 1 : 0;
        }
        
        if((this != 0) && (this.shader != 0))
        {
                val_9 = this.shader.name.Contains(value:  "Premultiplied");
        }
        else
        {
                val_9 = 0;
        }
        
        this.专丘三丏不一业丅丘 = val_9;
        return (bool)(val_9 == 1) ? 1 : 0;
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
        mem[1152921535366596764] = 丙业与丙丗丝不丈东.y;
        mem[1152921535366596768] = 丙业与丙丗丝不丈东.z;
        mem[1152921535366596772] = 丙业与丙丗丝不丈东.w;
        this.MarkAsChanged();
    }
    public UnityEngine.Rect get_uvRect()
    {
        return new UnityEngine.Rect() {m_XMin = this.mRect};
    }
    public void set_uvRect(UnityEngine.Rect 丙业与丙丗丝不丈东)
    {
        if((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = this.mRect, m_YMin = 丙业与丙丗丝不丈东.m_YMin, m_Width = 丙业与丙丗丝不丈东.m_Width, m_Height = 丙业与丙丗丝不丈东.m_Height}, rhs:  new UnityEngine.Rect() {m_XMin = 丙业与丙丗丝不丈东.m_XMin, m_YMin = 丙业与丙丗丝不丈东.m_YMin, m_Width = 丙业与丙丗丝不丈东.m_Width, m_Height = 丙业与丙丗丝不丈东.m_Height})) == false)
        {
                return;
        }
        
        this.mRect = 丙业与丙丗丝不丈东;
        mem[1152921535366820724] = 丙业与丙丗丝不丈东.m_YMin;
        mem[1152921535366820728] = 丙业与丙丗丝不丈东.m_Width;
        mem[1152921535366820732] = 丙业与丙丗丝不丈东.m_Height;
        this.MarkAsChanged();
    }
    public override UnityEngine.Vector4 get_drawingDimensions()
    {
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        UnityEngine.Vector2 val_1 = 万丗丅且丄丑世专与.丄丐与世一丕与下丂(业业上丂丒丄上丗丏:  102893);
        float val_2 = val_1.x * (float)val_1.x;
        float val_3 = val_1.y * (float)val_1.y;
        val_22 = -(val_1.x * (float)val_1.x);
        val_23 = -(val_1.y * (float)val_1.y);
        val_24 = (float)val_1.x - val_2;
        val_25 = (float)val_1.y - val_3;
        if(this.mTexture == 0)
        {
            goto label_15;
        }
        
        val_26 = 0f;
        val_21 = 1f;
        if((this.mTexture < 1) || (this.mTexture < 1))
        {
            goto label_8;
        }
        
        if(null == 3)
        {
            goto label_9;
        }
        
        val_27 = val_21;
        val_28 = 0f;
        if(null != null)
        {
            goto label_11;
        }
        
        label_9:
        float val_16 = (float)this.mTexture;
        float val_17 = 1f;
        val_16 = val_17 / val_16;
        val_17 = val_17 / (float)this.mTexture;
        val_28 = (float)this.mTexture & 1;
        val_27 = val_16 * (float)S4;
        val_21 = val_17 * (float)S5;
        val_26 = (float)this.mTexture & 1;
        goto label_11;
        label_8:
        val_27 = val_21;
        val_28 = 0f;
        label_11:
        val_27 = val_27 * val_28;
        if((1152921504848166912 | 2) == 3)
        {
                val_22 = val_27 - val_2;
        }
        else
        {
                val_24 = val_24 - val_27;
        }
        
        val_20 = val_21 * val_26;
        if((1152921504848166912 & 4294967294) == 2)
        {
                val_23 = val_20 - val_3;
        }
        else
        {
                val_25 = val_25 - val_20;
        }
        
        label_15:
        val_29 = 0f;
        val_30 = 0f;
        if(this.mFixedAspect != true)
        {
                val_30 = val_20 + val_27;
            val_29 = val_21 + val_28;
        }
        
        val_21 = val_24 - val_30;
        float val_9 = UnityEngine.Mathf.Lerp(a:  val_22, b:  val_21, t:  val_3);
        float val_11 = UnityEngine.Mathf.Lerp(a:  val_23, b:  val_25 - val_29, t:  val_3);
        float val_13 = UnityEngine.Mathf.Lerp(a:  val_22 + val_30, b:  val_24, t:  val_3);
        float val_15 = UnityEngine.Mathf.Lerp(a:  val_23 + val_29, b:  val_25, t:  val_3);
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    public bool get_fixedAspect()
    {
        return (bool)this.mFixedAspect;
    }
    public void set_fixedAspect(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (this.mFixedAspect == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.mFixedAspect = 丙业与丙丗丝不丈东;
        mem[1152921535367181084] = 0;
        mem[1152921535367181088] = 0;
        mem[1152921535367181096] = 0;
        this.MarkAsChanged();
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
                if(this.hasBorder == true)
        {
                return;
        }
        
        }
        
        if(this == 0)
        {
                return;
        }
        
        this.width = this.isAnchoredHorizontally + this.isAnchoredHorizontally;
        this.height = this.canBeAnchored + this.canBeAnchored;
    }
    protected override void 丑丈丆万丅上丞丗丐()
    {
        float val_7;
        float val_8;
        this.丑丈丆万丅上丞丗丐();
        if(this.mFixedAspect == false)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        bool val_2 = this.isAnchoredHorizontally;
        bool val_3 = this.canBeAnchored;
        bool val_4 = val_2;
        bool val_5 = val_3;
        val_4 = val_4 + val_2;
        val_5 = val_5 + val_3;
        float val_7 = (float)val_4;
        float val_9 = (float)S0;
        float val_8 = (float)S1;
        float val_6 = val_9 / val_8;
        val_7 = val_7 / (float)val_5;
        if(val_7 < 0)
        {
                val_8 = val_7 * val_8;
            val_8 = val_9 - val_8;
            float val_10 = 0.5f;
            val_9 = val_8 / val_9;
            val_9 = val_9 * val_10;
            val_7 = 1f;
            val_10 = val_7 - val_9;
            val_8 = 0f;
        }
        else
        {
                val_9 = val_9 / val_7;
            val_9 = val_8 - val_9;
            val_9 = val_9 / val_8;
            val_8 = val_9 * 0.5f;
            val_7 = 1f - val_8;
        }
        
        this.drawRegion = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    public override void OnFill(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        if(this == 0)
        {
                return;
        }
        
        float val_2 = this.mRect.x;
        float val_7 = val_2 * (float)this.isAnchoredHorizontally;
        float val_11 = 0f.x;
        val_11 = val_11 + 0f;
        val_11 = (val_2 * (float)this.canBeAnchored) + val_11;
        val_11 = val_11 - (val_2 * (float)this.isAnchoredHorizontally);
        val_11 = val_11 - (val_2 * (float)this.canBeAnchored);
        float val_17 = 1f;
        float val_13 = val_17 / (float)this.isAnchoredHorizontally;
        val_17 = val_17 / (float)this.canBeAnchored;
        float val_15 = 0f.System.IConvertible.ToSingle(provider:  0);
        val_15 = val_13 * val_15;
        val_15 = val_13 * val_15;
        val_15 = val_17 * val_15;
        val_15 = val_17 * val_15;
        float val_16 = 0f.x;
        val_16 = val_13 * val_16;
        val_16 = val_13 * val_16;
        val_16 = val_17 * val_16;
        val_16 = val_17 * val_16;
        this.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  丗丞不丞业丑七且丗, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  丗丄丌丝丌上世丄丘, 丈丒丈丆丑丅丆丌丌:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 万万丁丄丑丌丙丝丏:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
    }
    private void 不一丂丝万丐丌与丏()
    {
        this.enabled = false;
        UITextureMasked val_2 = this.gameObject.AddComponent<UITextureMasked>();
        if(val_2 != null)
        {
                val_2.width = W21;
            val_2.height = W21;
        }
        else
        {
                val_2.width = W21;
            val_2.height = W21;
        }
        
        val_2.depth = W21;
        UnityEngine.Object.DestroyImmediate(obj:  this);
    }
    public UITexture()
    {
        this.mRect = 0;
        mem[1152921535367783284] = 0;
        mem[1152921535367783292] = 0;
        UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
        this.mBorder = val_1;
        mem[1152921535367783324] = val_1.y;
        mem[1152921535367783328] = val_1.z;
        mem[1152921535367783332] = val_1.w;
        this.专丘三丏不一业丅丘 = 0;
    }

}
