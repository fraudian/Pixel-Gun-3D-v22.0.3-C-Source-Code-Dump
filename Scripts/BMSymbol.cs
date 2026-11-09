using UnityEngine;
[Serializable]
public class BMSymbol
{
    // Fields
    public string sequence;
    public string spriteName;
    private UISpriteData mSprite;
    private bool mIsValid;
    private int mLength;
    private int mOffsetX;
    private int mOffsetY;
    private int mWidth;
    private int mHeight;
    private int mAdvance;
    private UnityEngine.Rect mUV;
    
    // Properties
    public int length { get; }
    public int offsetX { get; }
    public int offsetY { get; }
    public int width { get; }
    public int height { get; }
    public int advance { get; }
    public UnityEngine.Rect uvRect { get; }
    
    // Methods
    public int get_length()
    {
        int val_2 = this.mLength;
        if(val_2 != 0)
        {
                return val_1;
        }
        
        val_2 = this.sequence;
        int val_1 = val_2.Length;
        this.mLength = val_1;
        return val_1;
    }
    public int get_offsetX()
    {
        return (int)this.mOffsetX;
    }
    public int get_offsetY()
    {
        return (int)this.mOffsetY;
    }
    public int get_width()
    {
        return (int)this.mWidth;
    }
    public int get_height()
    {
        return (int)this.mHeight;
    }
    public int get_advance()
    {
        return (int)this.mAdvance;
    }
    public UnityEngine.Rect get_uvRect()
    {
        return new UnityEngine.Rect() {m_XMin = this.mUV};
    }
    public void 丄丙丒丒且七丟三七()
    {
        this.mIsValid = false;
    }
    public bool 丏且丕丄世丕不丕丙(UIAtlas 不丗丐丘业专丂丝上)
    {
        var val_9;
        UISpriteData val_11;
        var val_12;
        var val_13;
        UISpriteData val_14;
        UISpriteData val_15;
        if(不丗丐丘业专丂丝上 != 0)
        {
            goto label_3;
        }
        
        label_6:
        val_9 = 0;
        return (bool)(mem[this.mSprite] != 0) ? 1 : 0;
        label_3:
        if(this.mIsValid != false)
        {
                return (bool)(mem[this.mSprite] != 0) ? 1 : 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.spriteName)) == true)
        {
            goto label_6;
        }
        
        if(不丗丐丘业专丂丝上 == 0)
        {
            goto label_9;
        }
        
        UISpriteData val_5 = 不丗丐丘业专丂丝上.GetSprite(丒丘丏上丙丟丑丕丈:  this.spriteName);
        this.mSprite = val_5;
        if(val_5 == null)
        {
                return (bool)(mem[this.mSprite] != 0) ? 1 : 0;
        }
        
        UnityEngine.Texture val_6 = 不丗丐丘业专丂丝上.texture;
        if(val_6 != 0)
        {
            goto label_15;
        }
        
        this.mSprite = 0;
        return (bool)(mem[this.mSprite] != 0) ? 1 : 0;
        label_9:
        this.mSprite = 0;
        return (bool)(mem[this.mSprite] != 0) ? 1 : 0;
        label_15:
        val_11 = this.mSprite;
        if(val_11 == null)
        {
            goto label_18;
        }
        
        val_12 = 28563616;
        goto label_19;
        label_18:
        val_13 = 28563616;
        if(this.mSprite == null)
        {
            goto label_20;
        }
        
        val_11 = this.mSprite;
        label_19:
        label_27:
        label_28:
        this.mUV = 0;
        mem[1152921531152723272] = 0;
        mem[1152921531152723276] = 0;
        mem[1152921531152723280] = 0f;
        UnityEngine.Rect val_8 = 万丗丅且丄丑世专与.不丟丌丙丞业丏万丂(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, 业与三万七丝不万东:  val_6, 丟丌丐丘丆丙丑丑一:  val_6);
        val_14 = this.mSprite;
        this.mUV = val_8;
        mem[1152921531152723272] = val_8.m_YMin;
        mem[1152921531152723276] = val_8.m_Width;
        mem[1152921531152723280] = val_8.m_Height;
        if(val_14 == null)
        {
            goto label_23;
        }
        
        this.mOffsetX = this.mSprite.paddingLeft;
        goto label_24;
        label_23:
        val_15 = this.mSprite;
        this.mOffsetX = this.mSprite.paddingLeft;
        if(val_15 == null)
        {
            goto label_25;
        }
        
        val_14 = val_15;
        label_24:
        this.mOffsetY = this.mSprite.paddingTop;
        label_29:
        this.mWidth = this.mSprite.width;
        label_30:
        this.mHeight = this.mSprite.height;
        label_31:
        label_34:
        int val_9 = this.mSprite.paddingLeft;
        this.mIsValid = true;
        val_9 = val_9 + this.mSprite.width;
        val_9 = val_9 + this.mSprite.paddingRight;
        this.mAdvance = val_9;
        return (bool)(mem[this.mSprite] != 0) ? 1 : 0;
        label_20:
        if(this.mSprite != null)
        {
            goto label_27;
        }
        
        if(this.mSprite != null)
        {
            goto label_28;
        }
        
        label_35:
        label_25:
        this.mOffsetY = -1341974048;
        if(this.mSprite != null)
        {
            goto label_29;
        }
        
        this.mWidth = this.mSprite.width;
        if(this.mSprite != null)
        {
            goto label_30;
        }
        
        this.mHeight = this.mSprite.height;
        if(this.mSprite != null)
        {
            goto label_31;
        }
        
        if(this.mSprite == null)
        {
            goto label_32;
        }
        
        goto label_34;
        label_32:
        if(this.mSprite != null)
        {
            goto label_34;
        }
        
        goto label_35;
    }
    public BMSymbol()
    {
    
    }

}
