using UnityEngine;
public class UIAtlas : MonoBehaviour
{
    // Fields
    private UnityEngine.Material material;
    private System.Collections.Generic.List<UISpriteData> mSprites;
    private float mPixelSize;
    private UIAtlas mReplacement;
    private UIAtlas.丅上丌丕世丝丒丙世 mCoordinates;
    private System.Collections.Generic.List<UIAtlas.Sprite> sprites;
    private int 专丘三丏不一业丅丘;
    private System.Collections.Generic.Dictionary<string, int> 丈丝专丄丘下世丐丈;
    
    // Properties
    public UnityEngine.Material 下丆丁三丙丆一丐业 { get; set; }
    public bool 一丘下丝丏不七丟下 { get; }
    public System.Collections.Generic.List<UISpriteData> 万丌专丞丑丝丅丆丅 { get; set; }
    public UnityEngine.Texture 与万丆丛丒万丝丙丑 { get; }
    public float 一丞上丘一七丗丟与 { get; set; }
    public UIAtlas 丙一与丗丞丞丞丘丅 { get; set; }
    
    // Methods
    public UnityEngine.Material get_spriteMaterial()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (UnityEngine.Material)this.mReplacement.material;
    }
    public void set_spriteMaterial(UnityEngine.Material 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.material == 0)
        {
                this.mReplacement.专丘三丏不一业丅丘 = 0;
            this.mReplacement.material = 丙业与丙丗丝不丈东;
            return;
        }
        
        this.MarkAsChanged();
        this.mReplacement.专丘三丏不一业丅丘 = 0;
        this.mReplacement.material = 丙业与丙丗丝不丈东;
        this.MarkAsChanged();
    }
    public bool get_premultipliedAlpha()
    {
        UIAtlas val_11;
        UIAtlas val_12;
        int val_13;
        val_11 = this;
        goto label_1;
        label_5:
        val_11 = this.mReplacement;
        label_1:
        val_12 = this.mReplacement.mReplacement;
        if(val_12 != 0)
        {
            goto label_5;
        }
        
        val_13 = this.mReplacement.专丘三丏不一业丅丘;
        if(val_13 != 1)
        {
                return (bool)(val_13 == 1) ? 1 : 0;
        }
        
        UnityEngine.Material val_2 = val_11.spriteMaterial;
        if(val_2 == 0)
        {
            goto label_13;
        }
        
        val_12 = val_2.shader;
        if(val_12 == 0)
        {
            goto label_13;
        }
        
        val_13 = val_2.shader.name.Contains(value:  "Premultiplied");
        goto label_17;
        label_13:
        val_13 = 0;
        label_17:
        this.mReplacement.专丘三丏不一业丅丘 = val_13;
        return (bool)(val_13 == 1) ? 1 : 0;
    }
    public System.Collections.Generic.List<UISpriteData> get_spriteList()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mSprites.Count != 0)
        {
                return (System.Collections.Generic.List<UISpriteData>)this.mReplacement.mSprites;
        }
        
        bool val_3 = this.丌上七丕专一东丝丏();
        return (System.Collections.Generic.List<UISpriteData>)this.mReplacement.mSprites;
    }
    public void set_spriteList(System.Collections.Generic.List<UISpriteData> 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        this.mReplacement.mSprites = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Texture get_texture()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.material == 0)
        {
                return 0;
        }
        
        if(this.mReplacement.material != null)
        {
                return this.mReplacement.material.mainTexture;
        }
        
        return this.mReplacement.material.mainTexture;
    }
    public float get_pixelSize()
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        return (float)this.mReplacement.mPixelSize;
    }
    public void set_pixelSize(float 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_5:
        this = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        float val_2 = UnityEngine.Mathf.Clamp(value:  丙业与丙丗丝不丈东, min:  0.25f, max:  4f);
        if(this.mReplacement.mPixelSize == val_2)
        {
                return;
        }
        
        this.mReplacement.mPixelSize = val_2;
        this.MarkAsChanged();
    }
    public UIAtlas get_replacement()
    {
        return (UIAtlas)this.mReplacement;
    }
    public void set_replacement(UIAtlas 丙业与丙丗丝不丈东)
    {
        UnityEngine.Object val_2 = (丙业与丙丗丝不丈东 != this) ? 0 : 丙业与丙丗丝不丈东;
        if(this.mReplacement == val_2)
        {
                return;
        }
        
        if(val_2 != 0)
        {
                bool val_5 = UnityEngine.Object.op_Equality(x:  val_1 != true ? 0 : 丙业与丙丗丝不丈东 + 48, y:  this);
        }
        
        if(this.mReplacement != 0)
        {
                this.MarkAsChanged();
        }
        
        this.mReplacement = val_2;
        if(val_2 != 0)
        {
                this.material = 0;
        }
        
        this.MarkAsChanged();
    }
    public UISpriteData GetSprite(string 丒丘丏上丙丟丑丕丈)
    {
        string val_17;
        UIAtlas val_18;
        var val_19;
        var val_20;
        val_17 = 丒丘丏上丙丟丑丕丈;
        int val_8 = 0;
        val_18 = this.mReplacement;
        if(val_18 != 0)
        {
                val_19 = this.mReplacement;
            return (UISpriteData)val_19;
        }
        
        val_19 = 0;
        if((System.String.IsNullOrEmpty(value:  val_17)) == true)
        {
                return (UISpriteData)val_19;
        }
        
        val_20 = 1152921535285352576;
        if(this.mSprites.Count == 0)
        {
                bool val_4 = this.丌上七丕专一东丝丏();
        }
        
        val_18 = this.mSprites;
        if(val_18.Count == 0)
        {
            goto label_25;
        }
        
        if(this.丈丝专丄丘下世丐丈.Count != this.mSprites.Count)
        {
                this.MarkSpriteListAsChanged();
        }
        
        if((this.丈丝专丄丘下世丐丈.TryGetValue(key:  val_17, value: out  val_8)) == false)
        {
            goto label_16;
        }
        
        if((val_8 & 2147483648) != 0)
        {
            goto label_17;
        }
        
        val_18 = this.mSprites;
        if(0 < val_18.Count)
        {
            goto label_19;
        }
        
        label_17:
        this.MarkSpriteListAsChanged();
        val_18 = this.丈丝专丄丘下世丐丈;
        if((val_18.TryGetValue(key:  val_17, value: out  val_8)) == false)
        {
            goto label_25;
        }
        
        label_19:
        val_17 = this.mSprites;
        val_19 = val_17.Item[0];
        return (UISpriteData)val_19;
        label_16:
        val_18 = this.mSprites.Count;
        if(val_18 >= 1)
        {
                do
        {
            UISpriteData val_14 = this.mSprites.Item[0];
            if((System.String.IsNullOrEmpty(value:  val_14.name)) != true)
        {
                if((System.String.op_Equality(a:  val_17, b:  val_14.name)) == true)
        {
            goto label_29;
        }
        
        }
        
            val_20 = 0 + 1;
        }
        while(val_20 < val_18);
        
        }
        
        label_25:
        val_19 = 0;
        return (UISpriteData)val_19;
        label_29:
        this.MarkSpriteListAsChanged();
        return (UISpriteData)val_19;
    }
    public string GetRandomSprite(string 丑丗万下七丂丗与丕)
    {
        var val_11;
        string val_12;
        var val_13;
        val_12 = 丑丗万下七丂丗与丕;
        val_13 = this;
        if((this.GetSprite(丒丘丏上丙丟丑丕丈:  val_12)) != null)
        {
                return (string)val_12;
        }
        
        val_11 = this.spriteList;
        System.Collections.Generic.List<System.String> val_3 = null;
        val_13 = val_3;
        val_3 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_4 = val_11.GetEnumerator();
        label_8:
        if((614955768 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_5 = 0.丐丏七丌丕丗业且上();
        if((val_5.m_stringLength.StartsWith(value:  val_12)) == false)
        {
            goto label_8;
        }
        
        val_3.Add(item:  val_5.m_stringLength);
        goto label_8;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_3.Count >= 1)
        {
                val_12 = val_3.Item[UnityEngine.Random.Range(min:  0, max:  val_3.Count)];
            return (string)val_12;
        }
        
        val_12 = 0;
        return (string)val_12;
    }
    public void MarkSpriteListAsChanged()
    {
        this.丈丝专丄丘下世丐丈.Clear();
        int val_1 = this.mSprites.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            UISpriteData val_2 = this.mSprites.Item[0];
            this.丈丝专丄丘下世丐丈.set_Item(key:  val_2.name, value:  0);
            val_3 = val_3 + 1;
        }
        while(val_1 != val_3);
    
    }
    public void SortAlphabetically()
    {
        var val_2 = null;
        if((UIAtlas.<>c.<>9__29_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        this.mSprites.Sort(comparison:  UIAtlas.<>c.<>9__29_0);
        return;
        label_3:
        UIAtlas.<>c.<>9__29_0 = new System.Comparison<UISpriteData>(object:  UIAtlas.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 UIAtlas.<>c::丂丁丒七丈丈业业丁(UISpriteData 一世不丄下丐丁丙丄, UISpriteData 丒与且丂丆丑丑丄东));
        if(this.mSprites != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    public 丒丞丕丕七丁丗丟丛<string> GetListOfSprites()
    {
        UIAtlas val_8;
        string val_9;
        val_8 = this;
        val_9 = 1152921504848912384;
        goto label_1;
        label_5:
        val_8 = this.mReplacement;
        label_1:
        if(this.mReplacement.mReplacement != 0)
        {
            goto label_5;
        }
        
        if(this.mReplacement.mSprites.Count == 0)
        {
                bool val_3 = val_8.丌上七丕专一东丝丏();
        }
        
        丒丞丕丕七丁丗丟丛<System.String> val_4 = new 丒丞丕丕七丁丗丟丛<System.String>();
        int val_5 = this.mReplacement.mSprites.Count;
        if(val_5 < 1)
        {
                return val_4;
        }
        
        var val_8 = 0;
        do
        {
            val_9 = this.mReplacement.mSprites.Item[0];
            if(val_9 != null)
        {
                if((System.String.IsNullOrEmpty(value:  val_6.name)) != true)
        {
                val_9 = val_6.name;
            val_4.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_9);
        }
        
        }
        
            val_8 = val_8 + 1;
        }
        while(val_5 != val_8);
        
        return val_4;
    }
    public 丒丞丕丕七丁丗丟丛<string> GetListOfSprites(string 与丛丙一丙丆丁七业)
    {
        string val_18;
        UIAtlas val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        int val_24;
        丒丞丕丕七丁丗丟丛<T> val_25;
        val_18 = 与丛丙一丙丆丁七业;
        val_19 = this;
        goto label_1;
        label_5:
        val_19 = this.mReplacement;
        label_1:
        if((UnityEngine.Object.op_Implicit(exists:  this.mReplacement.mReplacement)) == true)
        {
            goto label_5;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_18)) != false)
        {
                return val_19.GetListOfSprites();
        }
        
        val_20 = 1152921535285352576;
        if(this.mReplacement.mSprites.Count == 0)
        {
                bool val_4 = val_19.丌上七丕专一东丝丏();
        }
        
        丒丞丕丕七丁丗丟丛<System.String> val_5 = new 丒丞丕丕七丁丗丟丛<System.String>();
        int val_6 = this.mReplacement.mSprites.Count;
        if(val_6 >= 1)
        {
                val_21 = 0;
            do
        {
            if(this.mReplacement.mSprites.Item[0] != null)
        {
                if((System.String.IsNullOrEmpty(value:  val_7.name)) != true)
        {
                if((System.String.Equals(a:  val_18, b:  val_7.name, comparisonType:  5)) == true)
        {
            goto label_14;
        }
        
        }
        
        }
        
            val_21 = val_21 + 1;
        }
        while(val_21 < val_6);
        
        }
        
        char[] val_10 = new char[1];
        val_10[0] = 32;
        val_18 = val_18.Split(separator:  val_10, options:  1);
        val_21 = 0;
        goto label_19;
        label_26:
        val_21 = 1;
        mem2[0] = val_18[0].ToLower();
        label_19:
        if(val_21 < val_11.Length)
        {
            goto label_26;
        }
        
        int val_13 = this.mReplacement.mSprites.Count;
        if(val_13 < 1)
        {
                return val_5;
        }
        
        label_42:
        if((this.mReplacement.mSprites.Item[0] == null) || ((System.String.IsNullOrEmpty(value:  val_14.name)) == true))
        {
            goto label_40;
        }
        
        val_20 = val_14.name.ToLower();
        val_22 = 0;
        val_23 = 0;
        goto label_33;
        label_39:
        val_18[0] = val_20.Contains(value:  val_18[0]);
        val_23 = val_23 + val_18[0];
        val_22 = 1;
        label_33:
        if(val_18 == null)
        {
            goto label_36;
        }
        
        val_24 = val_11.Length;
        if(val_22 < val_24)
        {
            goto label_39;
        }
        
        goto label_38;
        label_36:
        val_24 = val_11.Length;
        if(val_22 < val_11.Length)
        {
            goto label_39;
        }
        
        label_38:
        if(val_23 == val_24)
        {
                val_25 = val_5;
            if(val_25 == 0)
        {
                val_25 = val_5;
        }
        
            val_5.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_14.name);
        }
        
        label_40:
        val_21 = 0 + 1;
        if(val_21 != val_13)
        {
            goto label_42;
        }
        
        return val_5;
        label_14:
        val_19 = val_7.name;
        val_5.业丏丗丐丂业东丂丗(下丅丙一丂丗丅丝七:  val_19);
        return val_5;
    }
    private bool 三一万丈万丈丟三丗(UIAtlas 不丗丐丘业专丂丝上)
    {
        UnityEngine.Object val_4;
        var val_5;
        val_4 = this;
        goto label_7;
        label_11:
        if(不丗丐丘业专丂丝上 == this)
        {
            goto label_3;
        }
        
        if(this.mReplacement == 0)
        {
            goto label_6;
        }
        
        val_4 = this.mReplacement;
        label_7:
        if(不丗丐丘业专丂丝上 != 0)
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
    public static bool CheckIfRelated(UIAtlas 丆丛丑世下一丐且丕, UIAtlas 丌丗丏丏丛东专丁且)
    {
        var val_5;
        if(丆丛丑世下一丐且丕 != 0)
        {
                if(丌丗丏丏丛东专丁且 != 0)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
        label_6:
        if(丆丛丑世下一丐且丕 != 丌丗丏丏丛东专丁且)
        {
                if((丆丛丑世下一丐且丕.三一万丈万丈丟三丗(不丗丐丘业专丂丝上:  丌丗丏丏丛东专丁且)) == false)
        {
            goto label_12;
        }
        
        }
        
        val_5 = 1;
        return (bool)val_5;
        label_12:
        if(丌丗丏丏丛东专丁且 != null)
        {
                return 丌丗丏丏丛东专丁且.三一万丈万丈丟三丗(不丗丐丘业专丂丝上:  丆丛丑世下一丐且丕);
        }
        
        return 丌丗丏丏丛东专丁且.三一万丈万丈丟三丗(不丗丐丘业专丂丝上:  丆丛丑世下一丐且丕);
    }
    public void MarkAsChanged()
    {
        int val_24;
        var val_25;
        UIAtlas val_27;
        int val_28;
        UIAtlas val_29;
        int val_30;
        var val_31;
        UIFont val_32;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.mReplacement, y:  0);
        if(val_2.Length < 1)
        {
            goto label_9;
        }
        
        val_24 = val_2.Length & 4294967295;
        val_25 = 0;
        goto label_10;
        label_16:
        val_24 = val_2.Length;
        val_25 = 1;
        label_10:
        if((UIAtlas.CheckIfRelated(丆丛丑世下一丐且丕:  this, 丌丗丏丏丛东专丁且:  X21.atlas)) != false)
        {
                if(X21 != 0)
        {
                val_27 = X21.atlas;
            X21.atlas = 0;
        }
        else
        {
                val_27 = 0.atlas;
            0.atlas = 0;
        }
        
            X21.atlas = val_27;
        }
        
        if((val_24 - 1) != val_25)
        {
            goto label_16;
        }
        
        label_9:
        if(val_9.Length < 1)
        {
            goto label_20;
        }
        
        val_28 = val_9.Length & 4294967295;
        val_25 = 0;
        goto label_21;
        label_27:
        val_28 = val_9.Length;
        val_25 = 1;
        label_21:
        if((UIAtlas.CheckIfRelated(丆丛丑世下一丐且丕:  this, 丌丗丏丏丛东专丁且:  X21.atlas)) != false)
        {
                if(X21 != 0)
        {
                val_29 = X21.atlas;
            X21.atlas = 0;
        }
        else
        {
                val_29 = 0.atlas;
            0.atlas = 0;
        }
        
            X21.atlas = val_29;
        }
        
        if((val_28 - 1) != val_25)
        {
            goto label_27;
        }
        
        label_20:
        if(val_15.Length < 1)
        {
                return;
        }
        
        val_30 = val_15.Length & 4294967295;
        val_31 = 0;
        goto label_32;
        label_43:
        val_30 = val_15.Length;
        val_31 = 1;
        label_32:
        if((X21.bitmapFont != 0) && ((UIAtlas.CheckIfRelated(丆丛丑世下一丐且丕:  this, 丌丗丏丏丛东专丁且:  X21.bitmapFont.atlas)) != false))
        {
                if(X21 != 0)
        {
                val_32 = X21.bitmapFont;
            X21.bitmapFont = 0;
        }
        else
        {
                val_32 = 0.bitmapFont;
            0.bitmapFont = 0;
        }
        
            X21.bitmapFont = val_32;
        }
        
        if((val_30 - 1) != val_31)
        {
            goto label_43;
        }
    
    }
    private bool 丌上七丕专一东丝丏()
    {
        UIAtlas val_28;
        var val_29;
        var val_30;
        val_28 = this;
        if((UnityEngine.Object.op_Implicit(exists:  this.mReplacement)) == false)
        {
            goto label_3;
        }
        
        val_28 = this.mReplacement;
        val_29 = val_28;
        goto label_36;
        label_3:
        if(this.mSprites.Count == 0)
        {
            goto label_8;
        }
        
        label_13:
        val_29 = 0;
        label_36:
        val_29 = val_29 & 1;
        return (bool)val_29;
        label_8:
        if((this.sprites.Count < 1) || ((UnityEngine.Object.op_Implicit(exists:  this.material)) == false))
        {
            goto label_13;
        }
        
        UnityEngine.Texture val_5 = this.material.mainTexture;
        if(val_5 != 0)
        {
                if(val_5 != null)
        {
            goto label_19;
        }
        
        }
        
        label_19:
        if(val_5 != 0)
        {
                if(val_5 != null)
        {
            goto label_24;
        }
        
        }
        
        label_24:
        val_30 = 0;
        goto label_25;
        label_35:
        Sprite val_8 = X23.Item[0];
        if(this.mCoordinates == 1)
        {
                UnityEngine.Rect val_9 = 万丗丅且丄丑世专与.与且万东一丕且丄丆(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = val_8.outer, m_YMin = val_8.outer, m_Width = val_8.outer, m_Height = val_8.outer}, 业与三万七丝不万东:  512, 丟丌丐丘丆丙丑丑一:  512, 丟东丝专丒丒且不且:  true);
            UnityEngine.Rect val_10 = 万丗丅且丄丑世专与.与且万东一丕且丄丆(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = val_8.inner, m_YMin = val_8.inner, m_Width = val_8.inner, m_Height = val_8.inner}, 业与三万七丝不万东:  512, 丟丌丐丘丆丙丑丑一:  512, 丟东丝专丒丒且不且:  true);
        }
        
        .name = val_8.name;
        float val_28 = val_8.outer.x;
        .x = UnityEngine.Mathf.RoundToInt(f:  val_28);
        .y = UnityEngine.Mathf.RoundToInt(f:  val_28);
        .width = UnityEngine.Mathf.RoundToInt(f:  val_28);
        .height = UnityEngine.Mathf.RoundToInt(f:  val_28);
        val_28 = val_8.paddingLeft * val_28;
        .paddingLeft = UnityEngine.Mathf.RoundToInt(f:  val_28);
        val_28 = val_8.paddingRight * val_28;
        .paddingRight = UnityEngine.Mathf.RoundToInt(f:  val_28);
        val_28 = val_8.paddingBottom * val_28;
        .paddingBottom = UnityEngine.Mathf.RoundToInt(f:  val_28);
        val_28 = val_8.paddingTop * val_28;
        .paddingTop = UnityEngine.Mathf.RoundToInt(f:  val_28);
        float val_22 = val_8.outer.x;
        val_22 = val_8.inner.x - val_22;
        .borderLeft = UnityEngine.Mathf.RoundToInt(f:  val_22);
        val_22 = val_22 - val_22;
        .borderRight = UnityEngine.Mathf.RoundToInt(f:  val_22);
        val_22 = val_22 - val_22;
        .borderBottom = UnityEngine.Mathf.RoundToInt(f:  val_22);
        val_22 = val_22 - val_22;
        .borderTop = UnityEngine.Mathf.RoundToInt(f:  val_22);
        this.mSprites.Add(item:  new UISpriteData());
        val_30 = 1;
        label_25:
        if(val_30 < this.sprites.Count)
        {
            goto label_35;
        }
        
        this.sprites.Clear();
        goto label_36;
    }
    public UIAtlas()
    {
        this.mSprites = new System.Collections.Generic.List<UISpriteData>();
        this.mPixelSize = 1f;
        this.sprites = new System.Collections.Generic.List<Sprite>();
        this.专丘三丏不一业丅丘 = 0;
        this.丈丝专丄丘下世丐丈 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
    }

}
