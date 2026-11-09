using UnityEngine;
public class UISprite : UIBasicSprite
{
    // Fields
    private UIAtlas mAtlas;
    private string mSpriteName;
    private bool mFillCenter;
    protected UISpriteData 丂丑丌丂丝专丗丆东;
    private bool 丕丞且与东不万丟丁;
    
    // Properties
    public override UnityEngine.Material 丘上专不丂万业不一 { get; }
    public UIAtlas 不丗丐丘业专丂丝上 { get; set; }
    public string 万丑丞一丝丌丐丒丘 { get; set; }
    public bool 丕且七业丙万丕丛丞 { get; }
    public bool 一丌丈七丙世专三与 { get; set; }
    public override UnityEngine.Vector4 业三丏专丘专丏丛与 { get; }
    public override float 一丞上丘一七丗丟与 { get; }
    public override int 上专上丛丈丆丗丒丟 { get; }
    public override int 丐丆丏丂上丒丗丌丁 { get; }
    public override UnityEngine.Vector4 丈丅且丛丑丞万丁丝 { get; }
    public override bool 一丘下丝丏不七丟下 { get; }
    
    // Methods
    public override UnityEngine.Material get_material()
    {
        if(this.mAtlas == 0)
        {
                return 0;
        }
        
        if(this.mAtlas != null)
        {
                return this.mAtlas.spriteMaterial;
        }
        
        return this.mAtlas.spriteMaterial;
    }
    public UIAtlas get_atlas()
    {
        return (UIAtlas)this.mAtlas;
    }
    public void set_atlas(UIAtlas 丙业与丙丗丝不丈东)
    {
        if(this.mAtlas == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        this.RemoveFromPanel();
        this.mAtlas = 丙业与丙丗丝不丈东;
        this.丕丞且与东不万丟丁 = false;
        this.丂丑丌丂丝专丗丆东 = 0;
        if(((System.String.IsNullOrEmpty(value:  this.mSpriteName)) != false) && (this.mAtlas != 0))
        {
                if(this.mAtlas.spriteList.Count >= 1)
        {
                this.万丝丏丈丛且丈丝丝(丄世业且下业上丄丟:  this.mAtlas.spriteList.Item[0]);
            this.mSpriteName = this.丂丑丌丂丝专丗丆东.name;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mSpriteName)) != false)
        {
                return;
        }
        
        this.mSpriteName = "";
        this.spriteName = this.mSpriteName;
        this.MarkAsChanged();
    }
    public string get_spriteName()
    {
        return (string)this.mSpriteName;
    }
    public void set_spriteName(string 丙业与丙丗丝不丈东)
    {
        if((System.String.IsNullOrEmpty(value:  丙业与丙丗丝不丈东)) != false)
        {
                if((System.String.IsNullOrEmpty(value:  this.mSpriteName)) == true)
        {
                return;
        }
        
            this.丂丑丌丂丝专丗丆东 = 0;
            mem[1152921535356321080] = 1;
            this.mSpriteName = "";
        }
        else
        {
                if((System.String.op_Inequality(a:  this.mSpriteName, b:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
            this.mSpriteName = 丙业与丙丗丝不丈东;
            this.丂丑丌丂丝专丗丆东 = 0;
            mem[1152921535356321080] = 1;
        }
        
        this.丕丞且与东不万丟丁 = false;
    }
    public bool get_isValid()
    {
        return (bool)(this.GetAtlasSprite() != 0) ? 1 : 0;
    }
    public bool get_fillCenter()
    {
        return (bool)(W8 != 0) ? 1 : 0;
    }
    public void set_fillCenter(bool 丙业与丙丗丝不丈东)
    {
        var val_1 = (W8 != 0) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        mem[1152921535356673804] = 丙业与丙丗丝不丈东;
        this.MarkAsChanged();
    }
    public override UnityEngine.Vector4 get_border()
    {
        if(this.GetAtlasSprite() != null)
        {
                return new UnityEngine.Vector4() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        }
        
        UnityEngine.Vector4 val_2 = this.border;
        return new UnityEngine.Vector4() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
    }
    public override float get_pixelSize()
    {
        if(this.mAtlas == 0)
        {
                return 1f;
        }
        
        if(this.mAtlas != null)
        {
                return this.mAtlas.pixelSize;
        }
        
        return this.mAtlas.pixelSize;
    }
    public override int get_minWidth()
    {
        int val_10;
        if(this.type != 1)
        {
                if(this.type != 4)
        {
                return this.minWidth;
        }
        
        }
        
        UnityEngine.Vector4 val_3 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B}, d:  V0.16B);
        val_3.x = val_3.x + val_3.z;
        val_10 = UnityEngine.Mathf.RoundToInt(f:  val_3.x);
        if(this.GetAtlasSprite() != null)
        {
                float val_10 = (float)val_5.paddingRight + val_5.paddingLeft;
            val_10 = V0.16B * val_10;
            val_10 = (UnityEngine.Mathf.RoundToInt(f:  val_10)) + val_10;
        }
        
        val_10 = (val_10 & 1) + val_10;
        return UnityEngine.Mathf.Max(a:  this.minWidth, b:  val_10);
    }
    public override int get_minHeight()
    {
        int val_11;
        if(this.type != 1)
        {
                if(this.type != 4)
        {
                return this.minHeight;
        }
        
        }
        
        UnityEngine.Vector4 val_3 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B}, d:  V0.16B);
        val_11 = UnityEngine.Mathf.RoundToInt(f:  val_3.y + val_3.w);
        if(this.GetAtlasSprite() != null)
        {
                float val_11 = (float)val_6.paddingBottom + val_6.paddingTop;
            val_11 = V0.16B * val_11;
            val_11 = (UnityEngine.Mathf.RoundToInt(f:  val_11)) + val_11;
        }
        
        val_11 = (val_11 & 1) + val_11;
        return UnityEngine.Mathf.Max(a:  this.minHeight, b:  val_11);
    }
    public override UnityEngine.Vector4 get_drawingDimensions()
    {
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_39;
        UISpriteData val_40;
        int val_41;
        int val_42;
        int val_43;
        int val_44;
        UISpriteData val_45;
        var val_46;
        float val_47;
        float val_48;
        var val_49;
        float val_50;
        float val_51;
        float val_52;
        UnityEngine.Vector2 val_1 = this.pivotOffset;
        val_34 = (float)S2;
        val_35 = (float)S3;
        float val_2 = val_1.x * val_34;
        float val_3 = val_1.y * val_35;
        val_36 = -(val_1.x * val_34);
        val_37 = -(val_1.y * val_35);
        val_38 = val_34 - val_2;
        val_39 = val_35 - val_3;
        if((this.GetAtlasSprite() == null) || (true == 2))
        {
            goto label_2;
        }
        
        val_40 = this.丂丑丌丂丝专丗丆东;
        if(val_40 == null)
        {
            goto label_3;
        }
        
        val_41 = this.丂丑丌丂丝专丗丆东.paddingLeft;
        goto label_4;
        label_3:
        val_41 = this.丂丑丌丂丝专丗丆东.paddingLeft;
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_5;
        }
        
        val_40 = this.丂丑丌丂丝专丗丆东;
        label_4:
        val_42 = this.丂丑丌丂丝专丗丆东.paddingBottom;
        label_32:
        label_33:
        val_43 = this.丂丑丌丂丝专丗丆东.paddingRight;
        val_44 = this.丂丑丌丂丝专丗丆东.paddingTop;
        if((W9 != 0) && (val_1.x != 1f))
        {
                float val_28 = (float)val_41;
            val_28 = val_1.x * val_28;
            float val_29 = (float)val_42;
            val_41 = UnityEngine.Mathf.RoundToInt(f:  val_28);
            val_29 = val_1.x * val_29;
            float val_30 = (float)val_43;
            val_42 = UnityEngine.Mathf.RoundToInt(f:  val_29);
            val_30 = val_1.x * val_30;
            float val_31 = (float)val_44;
            val_43 = UnityEngine.Mathf.RoundToInt(f:  val_30);
            val_31 = val_1.x * val_31;
            val_44 = UnityEngine.Mathf.RoundToInt(f:  val_31);
        }
        
        val_45 = this.丂丑丌丂丝专丗丆东;
        if(val_45 == null)
        {
            goto label_10;
        }
        
        val_46 = (val_41 + val_43) + this.丂丑丌丂丝专丗丆东.width;
        goto label_11;
        label_10:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_12;
        }
        
        val_45 = this.丂丑丌丂丝专丗丆东;
        val_46 = (val_41 + val_43) + this.丂丑丌丂丝专丗丆东.width;
        label_11:
        val_47 = 1f;
        if(val_46 < 1)
        {
            goto label_16;
        }
        
        int val_32 = this.丂丑丌丂丝专丗丆东.height;
        int val_11 = val_42 + val_44;
        val_32 = val_11 + val_32;
        if(val_32 < 1)
        {
            goto label_16;
        }
        
        if(val_11 != 3)
        {
                if(val_11 != 0)
        {
            goto label_16;
        }
        
        }
        
        float val_33 = (float)val_46;
        float val_34 = (float)val_32;
        val_33 = 1f / val_33;
        val_34 = 1f / val_34;
        val_43 = (val_46 & 1) + val_43;
        val_44 = (val_32 & 1) + val_44;
        val_48 = val_33 * val_35;
        val_47 = val_34 * (float)S4;
        goto label_17;
        label_16:
        val_48 = val_47;
        label_17:
        if((val_46 | 2) == 3)
        {
                val_49 = val_43;
        }
        else
        {
                val_49 = val_41;
            val_41 = val_43;
        }
        
        float val_35 = (float)val_49;
        val_35 = (float)val_41;
        val_46 = val_46 & 4294967294;
        val_35 = val_48 * val_35;
        val_48 = val_48 * val_35;
        val_36 = val_35 - val_2;
        val_38 = val_38 - val_48;
        if(val_46 == 2)
        {
                val_50 = (float)val_44;
            val_34 = (float)val_42;
        }
        else
        {
                val_50 = (float)val_42;
            val_34 = (float)val_44;
        }
        
        val_51 = val_47 * val_50;
        val_52 = val_47 * val_34;
        val_37 = val_51 - val_3;
        val_39 = val_39 - val_52;
        label_2:
        if(this.mAtlas != 0)
        {
                val_52 = val_52;
            val_51 = val_51;
            val_34 = val_34;
            val_35 = val_35;
            UnityEngine.Vector4 val_16 = UnityEngine.Vector4.op_Multiply(a:  new UnityEngine.Vector4() {x = val_52, y = val_51, z = val_34, w = val_35}, d:  val_52);
            val_39 = val_39;
            val_38 = val_38;
        }
        else
        {
                UnityEngine.Vector4 val_17 = UnityEngine.Vector4.zero;
        }
        
        float val_18 = val_17.x + val_17.z;
        float val_19 = val_17.y + val_17.w;
        float val_21 = UnityEngine.Mathf.Lerp(a:  val_36, b:  val_38 - val_18, t:  val_3);
        float val_23 = UnityEngine.Mathf.Lerp(a:  val_37, b:  val_39 - val_19, t:  val_3);
        float val_25 = UnityEngine.Mathf.Lerp(a:  val_36 + val_18, b:  val_38, t:  val_3);
        float val_27 = UnityEngine.Mathf.Lerp(a:  val_37 + val_19, b:  val_39, t:  val_3);
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        label_5:
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_32;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_33;
        }
        
        label_12:
    }
    public override bool get_premultipliedAlpha()
    {
        if(this.mAtlas == 0)
        {
                return false;
        }
        
        if(this.mAtlas != null)
        {
                return this.mAtlas.premultipliedAlpha;
        }
        
        return this.mAtlas.premultipliedAlpha;
    }
    public UISpriteData GetAtlasSprite()
    {
        UISpriteData val_10;
        if(this.丕丞且与东不万丟丁 == false)
        {
            goto label_1;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_18;
        }
        
        goto label_3;
        label_1:
        this.丂丑丌丂丝专丗丆东 = 0;
        label_3:
        if(this.mAtlas == 0)
        {
            goto label_18;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mSpriteName)) != true)
        {
                UISpriteData val_3 = this.mAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  this.mSpriteName);
            if(val_3 == null)
        {
                return val_10;
        }
        
            this.万丝丏丈丛且丈丝丝(丄世业且下业上丄丟:  val_3);
        }
        
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_10;
        }
        
        label_18:
        val_10 = this.丂丑丌丂丝专丗丆东;
        return val_10;
        label_10:
        if(this.mAtlas.spriteList.Count < 1)
        {
            goto label_18;
        }
        
        UISpriteData val_7 = this.mAtlas.spriteList.Item[0];
        if(val_7 == null)
        {
                return val_10;
        }
        
        this.万丝丏丈丛且丈丝丝(丄世业且下业上丄丟:  val_7);
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_17;
        }
        
        this.mSpriteName = this.丂丑丌丂丝专丗丆东.name;
        goto label_18;
        label_17:
        UnityEngine.Debug.LogError(message:  this.mAtlas.name + " seems to have a null sprite!"(" seems to have a null sprite!"));
        return val_10;
    }
    protected void 万丝丏丈丛且丈丝丝(UISpriteData 丄世业且下业上丄丟)
    {
        string val_2;
        mem[1152921535357884984] = true;
        this.丕丞且与东不万丟丁 = true;
        if(丄世业且下业上丄丟 != null)
        {
                this.丂丑丌丂丝专丗丆东 = 丄世业且下业上丄丟;
            val_2 = 丄世业且下业上丄丟.name;
        }
        else
        {
                val_2 = mem[this.丂丑丌丂丝专丗丆东 == null ? "" : this.丂丑丌丂丝专丗丆东.name];
            val_2 = (this.丂丑丌丂丝专丗丆东 == 0) ? "" : this.丂丑丌丂丝专丗丆东.name;
            this.丂丑丌丂丝专丗丆东 = 0;
        }
        
        this.mSpriteName = val_2;
    }
    public override void MakePixelPerfect()
    {
        if(this.GetAtlasSprite() == null)
        {
                return;
        }
        
        this.MakePixelPerfect();
        if(true == 2)
        {
                return;
        }
        
        if(this.GetAtlasSprite() == null)
        {
                return;
        }
        
        UnityEngine.Texture val_3 = this.mainTexture;
        if(val_3 == 0)
        {
                return;
        }
        
        if((null != 0) && (null != 3))
        {
                int val_12 = val_2.borderLeft;
            val_12 = val_2.borderRight | val_12;
            val_12 = val_12 | val_2.borderTop;
            val_12 = val_12 | val_2.borderBottom;
            if(val_12 != 0)
        {
                return;
        }
        
        }
        
        if(val_3 == 0)
        {
                return;
        }
        
        int val_6 = val_2.paddingLeft + val_2.width;
        val_6 = val_6 + val_2.paddingRight;
        float val_13 = (float)val_6;
        val_13 = V0.16B * val_13;
        int val_7 = UnityEngine.Mathf.RoundToInt(f:  val_13);
        int val_14 = val_2.height;
        int val_15 = val_2.paddingTop;
        val_14 = val_15 + val_14;
        val_14 = val_14 + val_2.paddingBottom;
        val_13 = val_13 * (float)val_14;
        int val_8 = UnityEngine.Mathf.RoundToInt(f:  val_13);
        val_15 = val_8 & 1;
        this.width = (val_7 & 1) + val_7;
        this.height = val_15 + val_8;
    }
    protected override void 丅丒丐且丘丝丝丄且()
    {
        if(this.mFillCenter != true)
        {
                this.mFillCenter = true;
            mem[1152921535358146188] = 0;
        }
        
        this.丅丒丐且丘丝丝丄且();
    }
    protected override void 丑丈丆万丅上丞丗丐()
    {
        this.丑丈丆万丅上丞丗丐();
        if(W8 == 0)
        {
                if(this.丕丞且与东不万丟丁 == true)
        {
                return;
        }
        
        }
        
        this.丂丑丌丂丝专丗丆东 = 0;
        this.丕丞且与东不万丟丁 = true;
        mem[1152921535358257848] = true;
    }
    public override void OnFill(丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> 丗丞不丞业丑七且丗, 丒丞丕丕七丁丗丟丛<UnityEngine.Vector2> 丂丙丆丂丑丝丂丝丒, 丒丞丕丕七丁丗丟丛<UnityEngine.Color32> 丗丄丌丝丌上世丄丘)
    {
        int val_8;
        丒丞丕丕七丁丗丟丛<UnityEngine.Vector3> val_9;
        UISpriteData val_10;
        string val_11;
        UISpriteData val_12;
        int val_13;
        val_9 = 丗丄丌丝丌上世丄丘;
        UnityEngine.Texture val_1 = this.mainTexture;
        if(val_1 == 0)
        {
                return;
        }
        
        val_10 = this.丂丑丌丂丝专丗丆东;
        if(val_10 == null)
        {
                val_11 = this.mSpriteName;
            UISpriteData val_3 = this.mAtlas.GetSprite(丒丘丏上丙丟丑丕丈:  val_11);
            this.丂丑丌丂丝专丗丆东 = val_3;
            if(val_3 == null)
        {
                return;
        }
        
        }
        
        val_12 = this.丂丑丌丂丝专丗丆东;
        if(val_12 == null)
        {
            goto label_7;
        }
        
        val_13 = this.丂丑丌丂丝专丗丆东.x;
        goto label_8;
        label_7:
        val_13 = this.丂丑丌丂丝专丗丆东.x;
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_9;
        }
        
        val_12 = this.丂丑丌丂丝专丗丆东;
        label_8:
        label_16:
        label_18:
        label_20:
        label_22:
        val_8 = this.丂丑丌丂丝专丗丆东.borderLeft;
        label_24:
        label_26:
        val_11 = this.丂丑丌丂丝专丗丆东.height;
        label_29:
        int val_8 = this.丂丑丌丂丝专丗丆东.borderBottom;
        val_13 = this.丂丑丌丂丝专丗丆东.borderLeft + val_13;
        int val_4 = this.丂丑丌丂丝专丗丆东.width - val_8;
        val_8 = val_11 - val_8;
        int val_5 = this.丂丑丌丂丝专丗丆东.borderTop + this.丂丑丌丂丝专丗丆东.y;
        val_4 = val_4 - this.丂丑丌丂丝专丗丆东.borderRight;
        val_8 = val_8 - this.丂丑丌丂丝专丗丆东.borderTop;
        val_9 = 丗丞不丞业丑七且丗;
        UnityEngine.Rect val_6 = 万丗丅且丄丑世专与.不丟丌丙丞业丏万丂(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 业与三万七丝不万东:  val_1, 丟丌丐丘丆丙丑丑一:  val_1);
        UnityEngine.Rect val_7 = 万丗丅且丄丑世专与.不丟丌丙丞业丏万丂(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 业与三万七丝不万东:  val_1, 丟丌丐丘丆丙丑丑一:  val_1);
        this.上东与丛丞下丈专丈(丗丞不丞业丑七且丗:  val_9, 丂丙丆丂丑丝丂丝丒:  丂丙丆丂丑丝丂丝丒, 丗丄丌丝丌上世丄丘:  val_9, 丈丒丈丆丑丅丆丌丌:  new UnityEngine.Rect() {m_XMin = val_6.m_XMin, m_YMin = val_6.m_YMin, m_Width = val_6.m_Width, m_Height = val_6.m_Height}, 万万丁丄丑丌丙丝丏:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height});
        return;
        label_9:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_15:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_17;
        }
        
        goto label_18;
        label_17:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_19:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_21;
        }
        
        goto label_22;
        label_21:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_23:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_25:
        if(this.丂丑丌丂丝专丗丆东 == null)
        {
            goto label_27;
        }
        
        goto label_29;
        label_27:
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
            goto label_29;
        }
    
    }
    public UISprite()
    {
        this.mFillCenter = true;
    }

}
