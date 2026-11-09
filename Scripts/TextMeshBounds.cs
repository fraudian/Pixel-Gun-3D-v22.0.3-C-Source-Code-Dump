using UnityEngine;
public class TextMeshBounds : MonoBehaviour
{
    // Fields
    private readonly string 世丒丅丕专丄业七上;
    private string _text;
    private string _localizationKey;
    public UnityEngine.Vector2 textBound;
    private UnityEngine.Vector2 上丄丁不丝丘上丄下;
    public float fontSize;
    private float 丙丑东东丛丅丘丑丁;
    private UnityEngine.Vector3 丞丂七且丐丕丘丄丙;
    private string 丕丗丘丑丛与丑业丒;
    private string 且丟丛丁丝丅丁一丗;
    public float finalWidth;
    public UnityEngine.Transform clanImaje;
    public UnityEngine.Vector2 imageOffset;
    public TextMeshBounds.下丂专丞万下丕上专 imageAlignment;
    private UnityEngine.Vector2 丕丕东丄三丗丙丁与;
    private UnityEngine.TextMesh 专与业上丌丐下与丄;
    public bool outlined;
    public float outlineSize;
    public bool ThrueWalls;
    private bool 丑与不业丞丑丏丘一;
    private float 丘丈丁下上丏世东专;
    public UnityEngine.Color outlineColor;
    private UnityEngine.Color 丁东丄东业丘丙丘三;
    public bool oneLine;
    private System.Collections.Generic.List<UnityEngine.TextMesh> 丆丆业丐丟丕专丁专;
    private bool 万丆丁丕丏专不下业;
    internal static UnityEngine.GameObject 丏下丅丅不丄丛丟上;
    internal static UnityEngine.GameObject 上不丏丂丆东丝世专;
    private static System.Text.StringBuilder 丕丒东丅东业丅且丟;
    
    // Properties
    public string 不三世丏丙丁与丑丒 { get; set; }
    public string 丁丗下一丒丕三下丛 { get; set; }
    private UnityEngine.TextMesh 专丘一丕专业七专丏 { get; }
    public UnityEngine.Color 下丏丟丐丈下东丏一 { get; set; }
    public UnityEngine.Color 丕丆一且万业丙一丅 { get; set; }
    
    // Methods
    public string get_Text()
    {
        return (string)this._text;
    }
    public void set_Text(string 丙业与丙丗丝不丈东)
    {
        if((System.String.op_Inequality(a:  this._text, b:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
        this._text = 丙业与丙丗丝不丈东;
        this.丆三且丆三不世丈丌();
        this.且丟丛丁丝丅丁一丗 = this._text;
    }
    public string get_LocalizationKey()
    {
        return (string)this._localizationKey;
    }
    public void set_LocalizationKey(string 丙业与丙丗丝不丈东)
    {
        this._localizationKey = 丙业与丙丗丝不丈东;
    }
    private UnityEngine.TextMesh 丌专丘丒丁丝丟丞且()
    {
        if(this.专与业上丌丐下与丄 != 0)
        {
                return (UnityEngine.TextMesh)this.专与业上丌丐下与丄;
        }
        
        UnityEngine.TextMesh val_2 = this.GetComponent<UnityEngine.TextMesh>();
        this.专与业上丌丐下与丄 = val_2;
        if(val_2 == 0)
        {
                return (UnityEngine.TextMesh)this.专与业上丌丐下与丄;
        }
        
        this.专与业上丌丐下与丄.richText = false;
        return (UnityEngine.TextMesh)this.专与业上丌丐下与丄;
    }
    public void set_OutlineColor(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        float val_3;
        float val_4;
        var val_5;
        val_3 = 丙业与丙丗丝不丈东.a;
        val_4 = 丙业与丙丗丝不丈东.g;
        this.outlineColor = 丙业与丙丗丝不丈东;
        mem[1152921540527691164] = val_4;
        mem[1152921540527691168] = 丙业与丙丗丝不丈东.b;
        mem[1152921540527691172] = val_3;
        if(this.outlined == false)
        {
                return;
        }
        
        val_5 = 0;
        goto label_2;
        label_6:
        val_3 = this.outlineColor;
        this.丆丆业丐丟丕专丁专.Item[0].color = new UnityEngine.Color() {r = val_3, g = 丙业与丙丗丝不丈东.b, b = val_4, a = 丙业与丙丗丝不丈东.r};
        val_5 = 1;
        label_2:
        if(val_5 < this.丆丆业丐丟丕专丁专.Count)
        {
            goto label_6;
        }
    
    }
    public UnityEngine.Color get_OutlineColor()
    {
        return new UnityEngine.Color() {r = this.outlineColor};
    }
    public void set_Color(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.丌专丘丒丁丝丟丞且().color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
    }
    public UnityEngine.Color get_Color()
    {
        UnityEngine.TextMesh val_1 = this.丌专丘丒丁丝丟丞且();
        if(val_1 != null)
        {
                return val_1.color;
        }
        
        return val_1.color;
    }
    private void OnEnable()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._localizationKey)) != true)
        {
                this._text = System.String.alignConst;
        }
        
        this.丞万专丒丁丒丅丙丆();
        this.三东丛与且丝业丛丄();
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TextMeshBounds::丞万专丒丁丒丅丙丆()));
    }
    private void OnDisable()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TextMeshBounds::丞万专丒丁丒丅丙丆()));
    }
    private void 丞万专丒丁丒丅丙丆()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._localizationKey)) != false)
        {
                return;
        }
        
        this.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._localizationKey);
    }
    private void 丆三且丆三不世丈丌()
    {
        this.丌专丘丒丁丝丟丞且().text = this._text;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._text)) != false)
        {
                this.Text = " ";
            this.丌专丘丒丁丝丟丞且().text = this._text;
        }
        
        this.丌丌丐丌丑丞万且丛();
    }
    private void 丌丌丐丌丑丞万且丛()
    {
        var val_37;
        System.Int32[] val_38;
        var val_39;
        var val_40;
        var val_41;
        string val_42;
        string val_43;
        int val_44;
        var val_45;
        float val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        float val_1 = this.textBound / this.fontSize;
        val_1 = val_1 * 10f;
        val_1 = val_1 / this.fontSize;
        val_1 = val_1 * 10f;
        int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_1);
        bool val_10 = this.丌专丘丒丁丝丟丞且().font.GetCharacterInfo(ch:  ' ', info: out  new UnityEngine.CharacterInfo() {uv = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, vert = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, width = 0f, flipped = ???}, size:  this.丌专丘丒丁丝丟丞且().fontSize, style:  this.丌专丘丒丁丝丟丞且().fontStyle);
        string val_11 = this._text.Replace(oldValue:  "\t", newValue:  System.String.alignConst);
        if(this.oneLine != false)
        {
                val_37 = new string[1];
            val_37[0] = val_11;
        }
        else
        {
                char[] val_13 = new char[1];
            val_13[0] = 32;
            val_37 = val_11.Split(separator:  val_13);
            if(val_37 != null)
        {
            
        }
        
        }
        
        val_38 = new int[0];
        val_39 = 0;
        goto label_19;
        label_37:
        val_40 = 0;
        val_38[0] = 0;
        goto label_22;
        label_32:
        bool val_23 = this.丌专丘丒丁丝丟丞且().font.GetCharacterInfo(ch:  1152921505724518352.Chars[0], info: out  new UnityEngine.CharacterInfo() {uv = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, vert = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, width = 0f, flipped = false}, size:  this.丌专丘丒丁丝丟丞且().fontSize, style:  this.丌专丘丒丁丝丟丞且().fontStyle);
        val_38 = val_38;
        val_40 = 1;
        mem2[0] = 1152921540528842144 + (val_15[0x0] + 32);
        label_22:
        if(val_40 < 1152921505724518352.Length)
        {
            goto label_32;
        }
        
        val_39 = 1;
        label_19:
        if(val_39 < val_14.Length)
        {
            goto label_37;
        }
        
        val_41 = null;
        val_41 = null;
        System.Text.StringBuilder val_26 = TextMeshBounds.丕丒东丅东业丅且丟.Clear();
        val_42 = val_37[0];
        val_43 = val_42;
        System.Text.StringBuilder val_27 = TextMeshBounds.丕丒东丅东业丅且丟.Append(value:  val_43);
        val_44 = val_15.Length;
        if(val_44 == 0)
        {
                val_43 = 0;
            val_44 = val_15.Length;
        }
        
        val_45 = mem[1152921540528960160];
        val_46 = 0f;
        if(val_44 >= 2)
        {
                val_46 = 0f;
            do
        {
            System.Int32[] val_28 = val_38 + 4;
            val_47 = mem[(val_15 + 4) + 32];
            val_47 = (val_15 + 4) + 32;
            if((val_47 + val_45) < (val_15[0x0] + 32))
        {
                if(1 >= val_15.Length)
        {
                val_48 = mem[(val_15 + 4) + 32];
            val_48 = (val_15 + 4) + 32;
        }
        
            val_49 = null;
            val_49 = null;
            val_45 = val_45 + 0;
            val_42 = val_37[1];
            val_50 = val_45 + val_48;
            val_43 = " {0}";
            System.Text.StringBuilder val_30 = TextMeshBounds.丕丒东丅东业丅且丟.AppendFormat(format:  val_43, arg0:  val_42);
        }
        else
        {
                var val_31 = (val_46 < 0) ? ((float)val_45) : (val_46);
            if(1 >= val_15.Length)
        {
                val_50 = mem[(val_15 + 4) + 32];
            val_50 = (val_15 + 4) + 32;
        }
        
            val_51 = null;
            val_51 = null;
            val_42 = TextMeshBounds.丕丒东丅东业丅且丟;
            val_43 = "{0}{1}";
            System.Text.StringBuilder val_32 = val_42.AppendFormat(format:  val_43, arg0:  this.世丒丅丕专丄业七上, arg1:  val_37[1]);
            val_38 = val_38;
        }
        
            val_45 = val_50;
        }
        while((1 + 1) < val_15.Length);
        
        }
        else
        {
                val_50 = val_45;
        }
        
        val_52 = null;
        val_52 = null;
        this.丕丗丘丑丛与丑业丒 = TextMeshBounds.丕丒东丅东业丅且丟;
        this.丌专丘丒丁丝丟丞且().text = this.丕丗丘丑丛与丑业丒;
        float val_40 = (float)UnityEngine.Mathf.RoundToInt(f:  val_1);
        val_40 = val_40 / ((float)val_15[0x0] + 32);
        val_40 = val_40 * this.fontSize;
        this.丌专丘丒丁丝丟丞且().characterSize = val_40;
        float val_38 = this.丌专丘丒丁丝丟丞且().characterSize;
        val_38 = (UnityEngine.Mathf.Max(a:  val_46, b:  (float)val_50)) * val_38;
        val_38 = val_38 * 0.1f;
        this.finalWidth = val_38;
        this.三东丛与且丝业丛丄();
        this.且丆七丄东业丒丕丝();
    }
    private void 不丑丗丌世丐世丝丝()
    {
        this.三东丛与且丝业丛丄();
        this.且丆七丄东业丒丕丝();
    }
    private void 且丆七丄东业丒丕丝()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.clanImaje)) == false)
        {
                return;
        }
        
        float val_5 = this.丌专丘丒丁丝丟丞且().characterSize;
        val_5 = this.finalWidth + val_5;
        val_5 = ((this.imageAlignment == 0) ? -1f : 1f) * val_5;
        val_5 = val_5 * 0.5f;
        val_5 = this.imageOffset + val_5;
        this.clanImaje.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 三东丛与且丝业丛丄()
    {
        var val_34;
        System.Collections.Generic.List<UnityEngine.TextMesh> val_80;
        var val_81;
        var val_82;
        var val_83;
        System.Collections.Generic.List<UnityEngine.TextMesh> val_84;
        var val_85;
        var val_87;
        System.Collections.Generic.List<UnityEngine.TextMesh> val_91;
        var val_97;
        float val_99;
        float val_100;
        System.Collections.Generic.List<UnityEngine.TextMesh> val_101;
        var val_103;
        val_80 = this;
        if(this.outlined == false)
        {
            goto label_1;
        }
        
        if(this.万丆丁丕丏专不下业 == false)
        {
            goto label_2;
        }
        
        label_5:
        val_82 = 0;
        val_83 = 0;
        goto label_3;
        label_1:
        val_84 = this.丆丆业丐丟丕专丁专;
        val_85 = 0;
        goto label_203;
        label_2:
        if(this.ThrueWalls == false)
        {
            goto label_5;
        }
        
        this.丆丆业丐丟丕专丁专 = 0;
        var val_85 = 0;
        val_85 = val_85 + 1;
        System.Collections.Generic.IEnumerator<T> val_5 = Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.丌专丘丒丁丝丟丞且().gameObject).GetEnumerator();
        val_87 = 1152921504686346240;
        label_33:
        var val_86 = 0;
        val_86 = val_86 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_87 = 0;
        val_87 = val_87 + 1;
        T val_9 = val_5.Current;
        UnityEngine.TextMesh val_10 = val_9.GetComponent<UnityEngine.TextMesh>();
        if(((UnityEngine.Object.op_Implicit(exists:  val_10)) == false) || ((val_9.name.Contains(value:  "TextOutline")) == false))
        {
            goto label_33;
        }
        
        UnityEngine.Object.Destroy(obj:  val_10.gameObject);
        goto label_33;
        label_17:
        val_83 = 0;
        val_82 = 0;
        if(val_5 == null)
        {
            
        }
        else
        {
                var val_88 = 0;
            val_88 = val_88 + 1;
            val_5.Dispose();
        }
        
        if(( != 1) && (129 == 129))
        {
                val_83 = 0;
        }
        else
        {
                if( != false)
        {
                val_82 = 0;
        }
        
        }
        
        this.万丆丁丕丏专不下业 = true;
        label_3:
        val_84 = val_80;
        val_91 = this.丆丆业丐丟丕专丁专;
        if(val_91 != null)
        {
            goto label_98;
        }
        
        System.Collections.Generic.List<UnityEngine.TextMesh> val_16 = new System.Collections.Generic.List<UnityEngine.TextMesh>();
        this.丆丆业丐丟丕专丁专 = val_16;
        var val_89 = 0;
        val_89 = val_89 + 1;
        System.Collections.Generic.IEnumerator<T> val_21 = Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.丌专丘丒丁丝丟丞且().gameObject).GetEnumerator();
        label_79:
        var val_90 = 0;
        val_90 = val_90 + 1;
        if(val_21.MoveNext() == false)
        {
            goto label_65;
        }
        
        var val_91 = 0;
        val_91 = val_91 + 1;
        T val_25 = val_21.Current;
        UnityEngine.TextMesh val_26 = val_25.GetComponent<UnityEngine.TextMesh>();
        if(((UnityEngine.Object.op_Implicit(exists:  val_26)) == false) || ((val_25.name.Contains(value:  "TextOutline")) == false))
        {
            goto label_79;
        }
        
        val_16.Add(item:  val_26);
        goto label_79;
        label_65:
        val_81 = 129;
        val_83 = 1;
        mem[133] = 259;
        if(val_21 == null)
        {
            
        }
        else
        {
                var val_92 = 0;
            val_92 = val_92 + 1;
            val_21.Dispose();
        }
        
        if((val_83 != 1) && (mem[133] == 259))
        {
                var val_93 = 0;
            val_93 = val_93 ^ 0;
            val_83 = val_83 + val_93;
        }
        else
        {
                if( != false)
        {
                val_82 = 0;
        }
        
        }
        
        val_91 = this.丆丆业丐丟丕专丁专;
        if(val_91 == null)
        {
                val_91 = 0;
        }
        
        label_98:
        if(val_91.Count <= 7)
        {
            goto label_99;
        }
        
        val_97 = 0;
        goto label_100;
        label_99:
        List.Enumerator<T> val_32 = val_16.GetEnumerator();
        val_87 = 1152921540529413408;
        label_114:
        if((1562998608 & 1) == 0)
        {
            goto label_102;
        }
        
        string val_35 = val_34.丐丏七丌丕丗业且上();
        if((UnityEngine.Object.op_Implicit(exists:  val_35)) == false)
        {
            goto label_114;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_106;
        }
        
        UnityEngine.Object.Destroy(obj:  val_35.gameObject);
        goto label_114;
        label_106:
        UnityEngine.Object.DestroyImmediate(obj:  val_35.gameObject);
        goto label_114;
        label_102:
        val_83 = val_83 + 1;
        mem2[0] = 364;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_83 != 1) && ((val_81 + ((val_83 + 1)) << 2) == 364))
        {
                var val_94 = 0;
            val_94 = val_94 ^ (val_83 >> 31);
            val_83 = val_83 + val_94;
        }
        else
        {
                if( != 0)
        {
                val_82 = 0;
        }
        
        }
        
        val_16.Clear();
        var val_95 = 8;
        do
        {
            this.丈丛丄丕丟业东业丞();
            val_95 = val_95 - 1;
        }
        while(val_95 != 0);
        
        val_97 = 1;
        label_100:
        val_99 = this.outlineSize;
        val_100 = this.丘丈丁下上丏世东专;
        val_97 = val_97 | ((val_99 != val_100) ? 1 : 0);
        if(val_97 != 0)
        {
                UnityEngine.Vector3 val_44 = this.丌专丘丒丁丝丟丞且().gameObject.transform.lossyScale;
            val_99 = val_99 * 0.05f;
            val_99 = val_99 * val_44.x;
            val_34 = 0;
            val_16.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16.Item[1].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16.Item[2].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16.Item[3].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16.Item[4].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16.Item[5].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_16.Item[6].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_100 = 0f;
            val_16.Item[7].transform.localPosition = new UnityEngine.Vector3() {x = val_100, y = 0f, z = 0f};
        }
        
        val_101 = this.丆丆业丐丟丕专丁专;
        List.Enumerator<T> val_61 = val_16.GetEnumerator();
        label_176:
        if((1562998608 & 1) == 0)
        {
            goto label_157;
        }
        
        string val_62 = val_34.丐丏七丌丕丗业且上();
        if(val_62.font != this.丌专丘丒丁丝丟丞且().font)
        {
                val_62.font = this.丌专丘丒丁丝丟丞且().font;
        }
        
        val_62.richText = false;
        val_62.text = this.丌专丘丒丁丝丟丞且().text;
        val_62.characterSize = this.丌专丘丒丁丝丟丞且().characterSize;
        val_62.lineSpacing = this.丌专丘丒丁丝丟丞且().lineSpacing;
        val_62.fontSize = this.丌专丘丒丁丝丟丞且().fontSize;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = this.丁东丄东业丘丙丘三, g = 0f, b = 0f}, rhs:  new UnityEngine.Color() {r = this.outlineColor})) == false)
        {
            goto label_176;
        }
        
        val_62.color = new UnityEngine.Color() {r = this.outlineColor, g = val_99, b = V10.16B, a = V11.16B};
        goto label_176;
        label_157:
        val_85 = val_83 + 1;
        mem2[0] = 1102;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_85 != 1)
        {
                if((val_81 + (((val_83 + 1) + 1)) << 2) == 1102)
        {
                return;
        }
        
        }
        
        label_203:
        if(this.丆丆业丐丟丕专丁专 == null)
        {
                return;
        }
        
        if(val_16.Count < 1)
        {
                return;
        }
        
        List.Enumerator<T> val_79 = val_16.GetEnumerator();
        val_101 = 1152921540529412384;
        val_87 = 1152921504848912384;
        label_216:
        if((1562998608 & 1) == 0)
        {
            goto label_207;
        }
        
        string val_80 = val_34.丐丏七丌丕丗业且上();
        val_80.gameObject.SetActive(value:  false);
        val_80.gameObject.transform.SetParent(p:  0);
        UnityEngine.Object.Destroy(obj:  val_80.gameObject);
        goto label_216;
        label_207:
        val_103 = 0;
        val_85 = val_85 + 1;
        mem2[0] = 1091;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_85 == 1)
        {
            goto label_225;
        }
        
        if(( == 0) || ((val_81 + ((((val_83 + 1) + 1) + 1)) << 2) == 1091))
        {
            goto label_230;
        }
        
        label_229:
        label_230:
        val_80 = this.丆丆业丐丟丕专丁专;
        val_16.Clear();
        return;
        label_225:
        if( != 0)
        {
            goto label_229;
        }
        
        goto label_230;
    }
    private void 丈丛丄丕丟业东业丞()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        val_23 = null;
        val_23 = null;
        if(TextMeshBounds.丏下丅丅不丄丛丟上 == 0)
        {
            goto label_5;
        }
        
        val_24 = null;
        val_24 = null;
        if(TextMeshBounds.上不丏丂丆东丝世专 != 0)
        {
            goto label_10;
        }
        
        label_5:
        val_25 = null;
        val_25 = null;
        TextMeshBounds.丏下丅丅不丄丛丟上 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "TextOutline");
        val_26 = null;
        TextMeshBounds.上不丏丂丆东丝世专 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "TextOutlineThrueWalls");
        goto label_13;
        label_10:
        val_26 = null;
        label_13:
        if(this.ThrueWalls != false)
        {
                val_27 = null;
            val_28 = 1152921505329958920;
        }
        else
        {
                val_29 = null;
        }
        
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  TextMeshBounds.__il2cppRuntimeField_static_fields);
        if(val_5 != null)
        {
                val_5.hideFlags = 61;
        }
        else
        {
                0.hideFlags = 61;
        }
        
        val_5.transform.SetParent(p:  this.丌专丘丒丁丝丟丞且().gameObject.transform);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.identity;
        val_5.transform.localRotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w};
        UnityEngine.TextMesh val_16 = val_5.GetComponent<UnityEngine.TextMesh>();
        this.丆丆业丐丟丕专丁专.Add(item:  val_16);
        val_16.font = this.丌专丘丒丁丝丟丞且().font;
        val_16.text = this.丌专丘丒丁丝丟丞且().text;
        val_16.characterSize = this.丌专丘丒丁丝丟丞且().characterSize;
        val_16.color = new UnityEngine.Color() {r = this.outlineColor, g = val_15.y, b = val_15.z, a = val_15.w};
    }
    private void OnDrawGizmos()
    {
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Quaternion val_4 = this.transform.rotation;
        UnityEngine.Vector3 val_6 = this.transform.lossyScale;
        UnityEngine.Matrix4x4 val_7 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, q:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, s:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.z});
        UnityEngine.Gizmos.matrix = new UnityEngine.Matrix4x4() {m00 = val_10, m10 = val_10, m20 = val_10, m30 = val_10, m01 = val_11, m11 = val_11, m21 = val_11, m31 = val_11, m02 = val_8, m12 = val_8, m22 = val_8, m32 = val_8, m03 = val_9, m13 = val_9, m23 = val_9, m33 = val_9};
        UnityEngine.Color val_12 = UnityEngine.Color.red;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.textBound, y = val_4.x});
        UnityEngine.Gizmos.DrawWireCube(center:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, size:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
    }
    public TextMeshBounds()
    {
        this.世丒丅丕专丄业七上 = "\n";
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.textBound = val_1;
        mem[1152921540530325732] = val_1.y;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.上丄丁不丝丘上丄下 = val_2;
        mem[1152921540530325740] = val_2.y;
        this.且丟丛丁丝丅丁一丗 = System.String.alignConst;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        this.imageOffset = val_3;
        mem[1152921540530325804] = val_3.y;
        this.outlineSize = 1f;
        UnityEngine.Color val_4 = UnityEngine.Color.black;
        this.outlineColor = val_4;
        mem[1152921540530325852] = val_4.g;
        mem[1152921540530325856] = val_4.b;
        mem[1152921540530325860] = val_4.a;
    }
    private static TextMeshBounds()
    {
        TextMeshBounds.丕丒东丅东业丅且丟 = new System.Text.StringBuilder();
    }

}
