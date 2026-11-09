using UnityEngine;
public class UIInput : MonoBehaviour
{
    // Fields
    public static UIInput current;
    public static UIInput selection;
    public UILabel label;
    public UIInput.丏专专丈业丞丝与丏 inputType;
    public UIInput.丄三且丅丕丁专丘不 onReturnKey;
    public UIInput.与丄丙不丞丑万丛与 keyboardType;
    public bool hideInput;
    public bool selectAllTextOnFocus;
    public UIInput.与七丛与丂丞一且丗 validation;
    public int characterLimit;
    public string savedAs;
    private UnityEngine.GameObject selectOnTab;
    public UnityEngine.Color activeTextColor;
    public UnityEngine.Color caretColor;
    public UnityEngine.Color selectionColor;
    public System.Collections.Generic.List<EventDelegate> onSubmit;
    public System.Collections.Generic.List<EventDelegate> onChange;
    public UIInput.丗丘丄丑丕丌且七上 onValidate;
    protected string mValue;
    protected string 丁丙丙丙上不万丁丌;
    protected UnityEngine.Color 与世丐下丘丑丈不且;
    protected float 丘丟丗三丅丆七丝丑;
    protected bool 丞丐业丕世业专丁专;
    protected 丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 业丅三丞业丄上且丒;
    protected bool 东丏三丘丑专丅丐丏;
    protected static int 丟丄下丟丐与专丙丁;
    protected static string 世丛丐丈丌丂丅上丟;
    protected static UnityEngine.TouchScreenKeyboard 丗丏一丛丄七丞万与;
    private static bool 丐下与丐下三丒丘与;
    protected int 丟一下丟丂三一丂七;
    protected int 不丗丞丂丈丒七丒丌;
    protected UITexture 丟丁丂丌丆丄丐业专;
    protected UITexture 万与丏东且丘丕不与;
    protected UnityEngine.Texture2D 丗且丐丗世万世丌业;
    protected float 丂丈丛东业万丁东专;
    protected float 上业丘专丆丏东下丂;
    protected string 丛世专万业丈东不丁;
    protected int 丌丏丕丑丈业丞不丝;
    protected int 与丕丂下丁丒丘丆专;
    private char[] 丗丌丘丒世下丑丒与;
    private UICamera 丟丕东万丐丁丁专一;
    private bool 万丝丛七丝丑丒三东;
    private static int 上丄世与丏丏下丆丏;
    
    // Properties
    public string 丐世一丅丁且业世业 { get; set; }
    public UnityEngine.Color 丑丙丝丆三七三丛丛 { get; set; }
    public bool 丒丞丝专下丆丕丒丆 { get; }
    public string 丕丗丘丑丛与丑业丒 { get; set; }
    public string 丙业与丙丗丝不丈东 { get; set; }
    public bool 丛丗七丅下丞丗且丐 { get; set; }
    public bool 丞丈丌且东丆丅丗万 { get; set; }
    public int 东丛丙丗丙丘丙专丒 { get; set; }
    public int 丑丑丌丛世丌丟丂不 { get; set; }
    public int 与丝丘万与丙不丗丞 { get; set; }
    public UITexture 丑丏丕下丙万丐丛丄 { get; }
    
    // Methods
    public string get_defaultText()
    {
        if(this.丞丐业丕世业专丁专 == false)
        {
                return (string)this.丁丙丙丙上不万丁丌;
        }
        
        this.丘上丐世丆丑且丞丒();
        return (string)this.丁丙丙丙上不万丁丌;
    }
    public void set_defaultText(string 丙业与丙丗丝不丈东)
    {
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        this.丁丙丙丙上不万丁丌 = 丙业与丙丗丝不丈东;
        this.UpdateLabel();
    }
    public UnityEngine.Color get_defaultColor()
    {
        if(this.丞丐业丕世业专丁专 == false)
        {
                return new UnityEngine.Color() {r = this.与世丐下丘丑丈不且};
        }
        
        this.丘上丐世丆丑且丞丒();
        return new UnityEngine.Color() {r = this.与世丐下丘丑丈不且};
    }
    public void set_defaultColor(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.与世丐下丘丑丈不且 = 丙业与丙丗丝不丈东;
        mem[1152921535318109572] = 丙业与丙丗丝不丈东.g;
        mem[1152921535318109576] = 丙业与丙丗丝不丈东.b;
        mem[1152921535318109580] = 丙业与丙丗丝不丈东.a;
        if(this.isSelected != false)
        {
                return;
        }
        
        this.label.color = new UnityEngine.Color() {r = 丙业与丙丗丝不丈东.r, g = 丙业与丙丗丝不丈东.g, b = 丙业与丙丗丝不丈东.b, a = 丙业与丙丗丝不丈东.a};
    }
    public bool get_inputShouldBeHidden()
    {
        var val_3;
        if(this.hideInput != false)
        {
                if((this.label != 0) && (this.label.mMaxLineCount == 1))
        {
                var val_2 = (this.inputType != 2) ? 1 : 0;
            return (bool)val_3;
        }
        
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public string get_text()
    {
        if(this.丞丐业丕世业专丁专 == false)
        {
                return (string)this.mValue;
        }
        
        this.丘上丐世丆丑且丞丒();
        return (string)this.mValue;
    }
    public void set_text(string 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public string get_value()
    {
        if(this.丞丐业丕世业专丁专 == false)
        {
                return (string)this.mValue;
        }
        
        this.丘上丐世丆丑且丞丒();
        return (string)this.mValue;
    }
    public void set_value(string 丙业与丙丗丝不丈东)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = 丙业与丙丗丝不丈东;
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        val_11 = null;
        val_11 = null;
        UIInput.丟丄下丟丐与专丙丁 = 0;
        if(UnityEngine.Application.platform == 22)
        {
                val_10 = val_10.Replace(oldValue:  "\\b", newValue:  "\b");
        }
        
        string val_3 = this.Validate(下下丏一丙不丘丌丞:  val_10);
        if(this.isSelected != false)
        {
                val_12 = null;
            val_12 = null;
            if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if((System.String.op_Inequality(a:  this.丛世专万业丈东不丁, b:  val_3)) != false)
        {
                val_13 = null;
            val_13 = null;
            UIInput.丗丏一丛丄七丞万与.text = val_3;
            this.丛世专万业丈东不丁 = val_3;
        }
        
        }
        
        }
        
        if((System.String.op_Inequality(a:  this.mValue, b:  val_3)) == false)
        {
                return;
        }
        
        this.mValue = val_3;
        this.东丏三丘丑专丅丐丏 = false;
        if(this.isSelected == false)
        {
            goto label_15;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_3)) == false)
        {
            goto label_16;
        }
        
        this.丟一下丟丂三一丂七 = 0;
        this.不丗丞丂丈丒七丒丌 = 0;
        goto label_18;
        label_15:
        this.丒丂丒丕丏万不丅且(下下丏一丙不丘丌丞:  val_3);
        goto label_18;
        label_16:
        int val_9 = val_3.Length;
        this.丟一下丟丂三一丂七 = val_9;
        this.不丗丞丂丈丒七丒丌 = val_9;
        label_18:
        this.UpdateLabel();
        this.丄丕上且专七东丌丙();
    }
    public bool get_selected()
    {
        return this.isSelected;
    }
    public void set_selected(bool 丙业与丙丗丝不丈东)
    {
        this.isSelected = 丙业与丙丗丝不丈东;
    }
    public bool get_isSelected()
    {
        null = null;
        return UnityEngine.Object.op_Equality(x:  UIInput.selection, y:  this);
    }
    public void set_isSelected(bool 丙业与丙丗丝不丈东)
    {
        var val_3;
        UnityEngine.GameObject val_4;
        val_3 = this;
        if(丙业与丙丗丝不丈东 != false)
        {
                val_3 = this.gameObject;
            val_4 = val_3;
        }
        else
        {
                if(this.isSelected == false)
        {
                return;
        }
        
            val_4 = 0;
        }
        
        UICamera.selectedObject = val_4;
    }
    public int get_cursorPosition()
    {
        null = null;
        if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if(this.inputShouldBeHidden == false)
        {
            goto label_5;
        }
        
        }
        
        if(this.isSelected != false)
        {
                return (int)this.不丗丞丂丈丒七丒丌;
        }
        
        label_5:
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        if(this.mValue != null)
        {
                return this.mValue.Length;
        }
        
        return this.mValue.Length;
    }
    public void set_cursorPosition(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        if(this.isSelected == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if(this.inputShouldBeHidden == false)
        {
                return;
        }
        
        }
        
        this.不丗丞丂丈丒七丒丌 = 丙业与丙丗丝不丈东;
        this.UpdateLabel();
    }
    public int get_selectionStart()
    {
        var val_3;
        int val_4;
        val_3 = null;
        val_3 = null;
        if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if(this.inputShouldBeHidden == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.isSelected != false)
        {
                val_4 = this.丟一下丟丂三一丂七;
            return (int)val_4;
        }
        
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        if(this.mValue != null)
        {
                return this.mValue.Length;
        }
        
        return this.mValue.Length;
        label_4:
        val_4 = 0;
        return (int)val_4;
    }
    public void set_selectionStart(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        if(this.isSelected == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if(this.inputShouldBeHidden == false)
        {
                return;
        }
        
        }
        
        this.丟一下丟丂三一丂七 = 丙业与丙丗丝不丈东;
        this.UpdateLabel();
    }
    public int get_selectionEnd()
    {
        null = null;
        if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if(this.inputShouldBeHidden == false)
        {
            goto label_5;
        }
        
        }
        
        if(this.isSelected != false)
        {
                return (int)this.不丗丞丂丈丒七丒丌;
        }
        
        label_5:
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        if(this.mValue != null)
        {
                return this.mValue.Length;
        }
        
        return this.mValue.Length;
    }
    public void set_selectionEnd(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        if(this.isSelected == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                if(this.inputShouldBeHidden == false)
        {
                return;
        }
        
        }
        
        this.不丗丞丂丈丒七丒丌 = 丙业与丙丗丝不丈东;
        this.UpdateLabel();
    }
    public UITexture get_caret()
    {
        return (UITexture)this.万与丏东且丘丕不与;
    }
    public string Validate(string 下下丏一丙不丘丌丞)
    {
        int val_13;
        var val_14;
        var val_15;
        var val_16;
        val_13 = this;
        if((System.String.IsNullOrEmpty(value:  下下丏一丙不丘丌丞)) != false)
        {
                return "";
        }
        
        System.Text.StringBuilder val_3 = new System.Text.StringBuilder(capacity:  下下丏一丙不丘丌丞.Length);
        val_14 = 0;
        goto label_3;
        label_14:
        char val_4 = 下下丏一丙不丘丌丞.Chars[0];
        if(this.onValidate != null)
        {
                val_15 = this.onValidate;
            char val_6 = val_15.Invoke(丕丗丘丑丛与丑业丒:  val_3, 上世丅丒三丅丈丁下:  val_3.Length, 一丆丕不业丕丆不业:  val_4);
        }
        else
        {
                val_15 = val_13;
            char val_8 = this.丏且丕丄世丕不丕丙(丕丗丘丑丛与丑业丒:  val_3, 下业丕七东丌丝下且:  val_3.Length, 丕上丙丝丅丛丐丏丑:  val_4);
        }
        
        if((val_8 & 65535) != 0)
        {
                System.Text.StringBuilder val_10 = val_3.Append(value:  val_8);
        }
        
        val_14 = 1;
        label_3:
        val_16 = 0;
        if(val_14 < 下下丏一丙不丘丌丞.Length)
        {
            goto label_14;
        }
        
        if(this.characterLimit >= 1)
        {
                val_16 = 0;
            val_13 = this.characterLimit;
            if(val_3.Length > val_13)
        {
                if(val_3 != null)
        {
                return val_3.ToString(startIndex:  0, length:  val_13);
        }
        
            return val_3.ToString(startIndex:  0, length:  val_13);
        }
        
        }
        
        if(val_3 == null)
        {
            
        }
    
    }
    private void Start()
    {
        if(this.selectOnTab != 0)
        {
                if((this.GetComponent<UIKeyNavigation>()) == 0)
        {
                UIKeyNavigation val_5 = this.gameObject.AddComponent<UIKeyNavigation>();
            val_5.onDown = this.selectOnTab;
        }
        
            this.selectOnTab = 0;
            不丌丂丁丄一与丆丙.丒不七东丙丒丞业丛(万且万且丑丗且丌丆:  this);
        }
        
        if(this.东丏三丘丑专丅丐丏 != false)
        {
                if((System.String.IsNullOrEmpty(value:  this.savedAs)) == false)
        {
            goto label_12;
        }
        
        }
        
        this.value = this.mValue.Replace(oldValue:  "\\n", newValue:  "\n");
        return;
        label_12:
        this.LoadValue();
    }
    protected void 丘上丐世丆丑且丞丒()
    {
        UILabel val_5;
        UILabel val_6;
        UILabel val_7;
        if(this.丞丐业丕世业专丁专 == false)
        {
                return;
        }
        
        if(this.label == 0)
        {
                return;
        }
        
        val_5 = this.label;
        this.丞丐业丕世业专丁专 = false;
        if(val_5 != null)
        {
                this.丁丙丙丙上不万丁丌 = this.label.mText;
        }
        else
        {
                val_5 = this.label;
            this.丁丙丙丙上不万丁丌 = this.label.mText;
        }
        
        UnityEngine.Color val_2 = val_5.color;
        this.与世丐下丘丑丈不且 = val_2;
        mem[1152921535320547060] = val_2.g;
        mem[1152921535320547064] = val_2.b;
        mem[1152921535320547068] = val_2.a;
        if(this.label.mEncoding != false)
        {
                this.label.mEncoding = false;
            mem2[0] = true;
            this.label.丁丛下专丗丁丞万上 = true;
        }
        
        val_6 = this.label;
        if(val_6 == null)
        {
            goto label_10;
        }
        
        this.万丝丛七丝丑丒三东 = this.label.mOverflowEllipsis;
        goto label_11;
        label_10:
        val_6 = this.label;
        this.万丝丛七丝丑丒三东 = this.label.mOverflowEllipsis;
        if(this.label == null)
        {
            goto label_12;
        }
        
        label_11:
        if(this.label.mAlignment == 4)
        {
                if(this.label.mAlignment != 1)
        {
                this.label.mAlignment = 1;
            mem2[0] = 1;
            this.label.丁丛下专丗丁丞万上 = 1;
            this.label.丆丐丈七丆丆一丛丏();
        }
        
            UnityEngine.Debug.LogWarning(message:  "Input fields using labels with justified alignment are not supported at this time", context:  this);
        }
        
        val_7 = this.label;
        if(val_7 != null)
        {
                this.业丅三丞业丄上且丒 = this.label.mAlignment;
        }
        else
        {
                val_7 = this.label;
            this.业丅三丞业丄上且丒 = this.label.mAlignment;
        }
        
        UnityEngine.Vector3 val_4 = val_7.cachedTransform.localPosition;
        this.丘丟丗三丅丆七丝丑 = val_4.x;
        this.UpdateLabel();
        return;
        label_12:
    }
    protected void 丒丂丒丕丏万不丅且(string 下下丏一丙不丘丌丞)
    {
        if((System.String.IsNullOrEmpty(value:  this.savedAs)) != false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  下下丏一丙不丘丌丞)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  this.savedAs);
            return;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  this.savedAs, value:  下下丏一丙不丘丌丞);
    }
    protected virtual void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(丞丈丌且东丆丅丗万 != false)
        {
                this.与不三丑业丟丏与丘();
            return;
        }
        
        this.万丗丞丟下且不丛丕();
    }
    protected void 与不三丑业丟丏与丘()
    {
        var val_6;
        UILabel val_7;
        UILabel val_8;
        this.与丕丂下丁丒丘丆专 = UnityEngine.Time.frameCount;
        val_6 = null;
        val_6 = null;
        UIInput.selection = this;
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        if(this.label != 0)
        {
                val_7 = this.label;
            if(val_7 != null)
        {
                val_8 = val_7;
            this.万丝丛七丝丑丒三东 = this.label.mOverflowEllipsis;
        }
        else
        {
                val_8 = this.label;
            this.万丝丛七丝丑丒三东 = this.label.mOverflowEllipsis;
            if(val_8 != null)
        {
                val_7 = val_8;
        }
        else
        {
                val_7 = 0;
        }
        
        }
        
            if(57 != 0)
        {
                mem[536] = 0;
        }
        
        }
        
        if(this.label == 0)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        this.丌丏丕丑丈业丞不丝 = UnityEngine.Time.frameCount;
    }
    protected void 万丗丞丟下且不丛丕()
    {
        丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 val_7;
        var val_8;
        var val_10;
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        val_7 = 1152921504848912384;
        if(this.label != 0)
        {
                if(((this.万丝丛七丝丑丒三东 == true) ? 1 : 0) != ((this.label.mOverflowEllipsis == true) ? 1 : 0))
        {
                this.label.mOverflowEllipsis = this.万丝丛七丝丑丒三东;
        }
        
        }
        
        if((this.label != 0) && ((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) != false))
        {
                if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
            val_8 = null;
            val_8 = null;
            if(UIInput.丗丏一丛丄七丞万与 != null)
        {
                val_8 = null;
            UIInput.丐下与丐下三丒丘与 = false;
            UIInput.丗丏一丛丄七丞万与.active = false;
            UIInput.丗丏一丛丄七丞万与 = 0;
        }
        
            if((System.String.IsNullOrEmpty(value:  this.mValue)) != false)
        {
                this.label.text = this.丁丙丙丙上不万丁丌;
            this.label.color = new UnityEngine.Color() {r = this.与世丐下丘丑丈不且, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        else
        {
                this.label.text = this.mValue;
        }
        
            UnityEngine.Input.imeCompositionMode = 0;
            val_7 = this.业丅三丞业丄上且丒;
            if(this.label.mAlignment != val_7)
        {
                this.label.mAlignment = val_7;
            mem2[0] = true;
            this.label.丁丛下专丗丁丞万上 = true;
            this.label.丆丐丈七丆丆一丛丏();
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        UIInput.selection = 0;
        this.UpdateLabel();
    }
    protected virtual void Update()
    {
        var val_76;
        var val_77;
        UnityEngine.TouchScreenKeyboard val_79;
        var val_80;
        var val_81;
        int val_82;
        UnityEngine.Color val_83;
        与丄丙不丞丑万丛与 val_84;
        string val_85;
        var val_86;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        UnityEngine.TouchScreenKeyboard val_92;
        var val_93;
        var val_94;
        string val_95;
        var val_96;
        var val_97;
        var val_98;
        var val_99;
        int val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        var val_105;
        var val_106;
        var val_107;
        var val_108;
        UICamera val_109;
        var val_110;
        var val_111;
        var val_112;
        var val_113;
        var val_114;
        var val_115;
        var val_116;
        var val_117;
        var val_118;
        var val_119;
        UnityEngine.Object val_120;
        var val_121;
        var val_122;
        var val_123;
        var val_124;
        var val_125;
        if(this.isSelected == false)
        {
                return;
        }
        
        if(this.与丕丂下丁丒丘丆专 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        val_76 = 1152921505098006528;
        val_77 = null;
        val_77 = null;
        if(UIInput.丐下与丐下三丒丘与 != false)
        {
                val_77 = null;
            val_79 = UIInput.丗丏一丛丄七丞万与;
            if(val_79 != null)
        {
                val_79 = UIInput.丗丏一丛丄七丞万与;
            if(val_79 == null)
        {
                val_79 = 0;
        }
        
            if(val_79.active == false)
        {
                return;
        }
        
            val_77 = null;
        }
        
            val_77 = null;
            UIInput.丐下与丐下三丒丘与 = false;
        }
        
        if((this.丌丏丕丑丈业丞不丝 == 1) || (this.丌丏丕丑丈业丞不丝 == UnityEngine.Time.frameCount))
        {
            goto label_17;
        }
        
        this.丌丏丕丑丈业丞不丝 = 0;
        if((System.String.IsNullOrEmpty(value:  this.mValue)) != false)
        {
                val_80 = 0;
        }
        else
        {
                val_80 = this.mValue;
        }
        
        this.不丗丞丂丈丒七丒丌 = val_80.Length;
        val_81 = null;
        val_81 = null;
        UIInput.丟丄下丟丐与专丙丁 = 0;
        val_82 = 0;
        if(this.selectAllTextOnFocus != true)
        {
                val_82 = this.不丗丞丂丈丒七丒丌;
        }
        
        val_83 = this.activeTextColor;
        this.丟一下丟丂三一丂七 = val_82;
        this.label.color = new UnityEngine.Color() {r = val_83, g = V9.16B, b = V10.16B, a = V11.16B};
        UnityEngine.RuntimePlatform val_7 = UnityEngine.Application.platform;
        if(val_7 > 22)
        {
            goto label_26;
        }
        
        var val_73 = 1;
        val_73 = val_73 << val_7;
        val_73 = val_73 & 8128768;
        if(val_73 == 0)
        {
            goto label_26;
        }
        
        if(this.inputShouldBeHidden != false)
        {
                UnityEngine.TouchScreenKeyboard.hideInput = true;
            val_84 = this.keyboardType;
            val_85 = "|";
        }
        else
        {
                UnityEngine.TouchScreenKeyboard.hideInput = false;
            val_84 = this.keyboardType;
            val_85 = this.mValue;
            this.丟一下丟丂三一丂七 = this.不丗丞丂丈丒七丒丌;
        }
        
        val_86 = null;
        val_86 = null;
        UIInput.丐下与丐下三丒丘与 = true;
        if(this.inputType == 2)
        {
                UnityEngine.TouchScreenKeyboard val_9 = UnityEngine.TouchScreenKeyboard.Open(text:  val_85, keyboardType:  val_84, autocorrection:  false, multiline:  false, secure:  true);
        }
        else
        {
                if(this.inputShouldBeHidden != false)
        {
                val_88 = 0;
        }
        
            if(this.label.mMaxLineCount == 1)
        {
                val_89 = 0;
        }
        else
        {
                bool val_74 = this.hideInput;
            val_74 = val_74 ^ 1;
            val_89 = val_74 & 255;
        }
        
            if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        }
        
        val_90 = null;
        val_90 = null;
        UIInput.丗丏一丛丄七丞万与 = UnityEngine.TouchScreenKeyboard.Open(text:  val_85, keyboardType:  val_84, autocorrection:  (this.inputType == 1) ? 1 : 0, multiline:  (val_89 == true) ? 1 : 0, secure:  false, alert:  false, textPlaceholder:  this.丁丙丙丙上不万丁丌);
        label_207:
        this.UpdateLabel();
        if((System.String.IsNullOrEmpty(value:  UnityEngine.Input.inputString)) == true)
        {
                return;
        }
        
        label_17:
        val_91 = null;
        val_91 = null;
        val_92 = UIInput.丗丏一丛丄七丞万与;
        if(val_92 == null)
        {
            goto label_44;
        }
        
        val_92 = UIInput.丗丏一丛丄七丞万与;
        if(val_92 == null)
        {
                val_92 = 0;
        }
        
        if(val_92.done == true)
        {
            goto label_52;
        }
        
        val_93 = null;
        val_93 = null;
        if(UIInput.丗丏一丛丄七丞万与.active == false)
        {
            goto label_52;
        }
        
        val_94 = null;
        val_94 = null;
        val_95 = UIInput.丗丏一丛丄七丞万与.text;
        goto label_56;
        label_52:
        val_95 = this.丛世专万业丈东不丁;
        label_56:
        if(this.inputShouldBeHidden == false)
        {
            goto label_57;
        }
        
        val_85 = "|";
        if((System.String.op_Inequality(a:  val_95, b:  "|")) == false)
        {
            goto label_91;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_95)) == false)
        {
            goto label_59;
        }
        
        val_96 = null;
        val_96 = null;
        if(UIInput.丗丏一丛丄七丞万与.done == true)
        {
            goto label_68;
        }
        
        val_97 = null;
        val_97 = null;
        if(UIInput.丗丏一丛丄七丞万与.active == false)
        {
            goto label_68;
        }
        
        this.三一丘丙业且世与丛();
        goto label_68;
        label_44:
        string val_24 = UnityEngine.Input.compositionString;
        if(((System.String.IsNullOrEmpty(value:  val_24)) == false) || ((System.String.IsNullOrEmpty(value:  UnityEngine.Input.inputString)) == true))
        {
            goto label_70;
        }
        
        val_85 = UnityEngine.Input.inputString;
        val_98 = 0;
        goto label_71;
        label_76:
        char val_29 = val_85.Chars[0];
        if((val_29 & 65535) >= ' ')
        {
                char val_31 = val_29 & 4294967292;
            val_31 = val_31 & 65535;
            if(val_31 != '')
        {
            
        }
        
        }
        
        val_98 = 1;
        label_71:
        if(val_98 < val_85.Length)
        {
            goto label_76;
        }
        
        label_70:
        val_99 = null;
        val_99 = null;
        if((System.String.op_Inequality(a:  UIInput.世丛丐丈丌丂丅上丟, b:  val_24)) == false)
        {
            goto label_108;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_24)) == false)
        {
            goto label_80;
        }
        
        val_100 = this.丟一下丟丂三一丂七;
        goto label_81;
        label_57:
        if((System.String.op_Inequality(a:  this.丛世专万业丈东不丁, b:  val_95)) == false)
        {
            goto label_91;
        }
        
        this.丛世专万业丈东不丁 = val_95;
        val_101 = null;
        val_101 = null;
        val_85 = UIInput.丗丏一丛丄七丞万与;
        if(val_85.done == true)
        {
            goto label_91;
        }
        
        val_102 = null;
        val_102 = null;
        val_85 = UIInput.丗丏一丛丄七丞万与;
        if(val_85.active == false)
        {
            goto label_91;
        }
        
        this.value = val_95;
        goto label_91;
        label_80:
        val_85 = this.mValue.Length;
        val_100 = val_24.Length + val_85;
        label_81:
        this.不丗丞丂丈丒七丒丌 = val_100;
        val_103 = null;
        val_103 = null;
        UIInput.世丛丐丈丌丂丅上丟 = val_24;
        this.UpdateLabel();
        this.丄丕上且专七东丌丙();
        goto label_108;
        label_59:
        string val_40 = val_95.Substring(startIndex:  1);
        label_68:
        val_104 = null;
        val_104 = null;
        UIInput.丗丏一丛丄七丞万与.text = "|";
        label_91:
        val_105 = null;
        val_105 = null;
        if(UIInput.丗丏一丛丄七丞万与.done == true)
        {
            goto label_104;
        }
        
        val_106 = null;
        val_106 = null;
        if(UIInput.丗丏一丛丄七丞万与.active == true)
        {
            goto label_108;
        }
        
        label_104:
        val_107 = null;
        val_107 = null;
        bool val_43 = UIInput.丗丏一丛丄七丞万与.wasCanceled;
        val_108 = null;
        val_108 = null;
        UIInput.丗丏一丛丄七丞万与 = 0;
        this.isSelected = false;
        this.丛世专万业丈东不丁 = "";
        label_108:
        if(this.万与丏东且丘丕不与 != 0)
        {
                val_83 = this.丂丈丛东业万丁东专;
            float val_45 = RealTime.time;
            if(val_83 < 0)
        {
                float val_46 = RealTime.time;
            val_46 = val_46 + 0.5f;
            this.丂丈丛东业万丁东专 = val_46;
            if(this.万与丏东且丘丕不与 != null)
        {
                val_85 = this.万与丏东且丘丕不与.enabled;
        }
        else
        {
                val_85 = 0.enabled;
        }
        
            this.万与丏东且丘丕不与.enabled = (~val_85) & 1;
        }
        
        }
        
        if(this.isSelected != false)
        {
                val_83 = this.上业丘专丆丏东下丂;
            if(val_83 != val_46)
        {
                this.UpdateLabel();
        }
        
        }
        
        if(this.丟丕东万丐丁丁专一 == 0)
        {
                val_109 = UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  this.gameObject.layer);
            this.丟丕东万丐丁丁专一 = val_109;
        }
        else
        {
                val_109 = this.丟丕东万丐丁丁专一;
        }
        
        if(val_109 == 0)
        {
                return;
        }
        
        if(this.label.mMaxLineCount == 1)
        {
                val_110 = 0;
        }
        else
        {
                if((UnityEngine.Input.GetKey(key:  50)) != false)
        {
                val_111 = 1;
        }
        else
        {
                val_111 = UnityEngine.Input.GetKey(key:  49);
        }
        
            var val_60 = (this.onReturnKey == 1) ? ((val_111 == true) ? 1 : 0) : ((val_111 == false) ? 1 : 0);
        }
        
        val_76 = 1152921505096622080;
        val_112 = null;
        val_112 = null;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  this.丟丕东万丐丁丁专一.submitKey0)) != false)
        {
                if(val_60 != 0)
        {
            
        }
        else
        {
                val_113 = null;
            val_113 = null;
            if(UICamera.controller.上丞丕专丈业丁世专 != 0)
        {
                val_114 = null;
            val_114 = null;
            UICamera.controller.丌下丐上丛丘丗万丅 = 0;
        }
        
            UICamera.currentKey = this.丟丕东万丐丁丁专一.submitKey0;
        }
        
        }
        
        val_115 = null;
        val_115 = null;
        val_85 = this.丟丕东万丐丁丁专一.submitKey1;
        if((UICamera.GetKeyDown.Invoke(下上丐丆丝丟丝丒不:  val_85)) != false)
        {
                if(val_60 != 0)
        {
            
        }
        else
        {
                val_116 = null;
            val_116 = null;
            if(UICamera.controller.上丞丕专丈业丁世专 != 0)
        {
                val_117 = null;
            val_117 = null;
            UICamera.controller.丌下丐上丛丘丗万丅 = 0;
        }
        
            UICamera.currentKey = this.丟丕东万丐丁丁专一.submitKey1;
        }
        
        }
        
        if(this.丟丕东万丐丁丁专一.useKeyboard == true)
        {
                return;
        }
        
        val_118 = null;
        val_118 = null;
        if((UICamera.GetKeyUp.Invoke(下上丐丆丝丟丝丒不:  9)) == false)
        {
                return;
        }
        
        this.OnKey(下上丐丆丝丟丝丒不:  9);
        return;
        label_26:
        val_119 = null;
        val_119 = null;
        val_120 = 0;
        if(UICamera.current == val_120)
        {
            goto label_193;
        }
        
        val_121 = null;
        val_121 = null;
        val_120 = 0;
        if(UICamera.current.cachedCamera == val_120)
        {
            goto label_193;
        }
        
        val_122 = null;
        val_122 = null;
        UnityEngine.Vector3 val_70 = UICamera.current.cachedCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_83, y = V9.16B, z = V10.16B});
        val_123 = val_70.x;
        val_124 = val_70.y;
        val_125 = val_70.z;
        goto label_201;
        label_193:
        label_201:
        UnityEngine.Vector2 val_71 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_83, y = V9.16B, z = V10.16B});
        float val_75 = val_71.y;
        val_75 = (float)UnityEngine.Screen.height - val_75;
        UnityEngine.Input.imeCompositionMode = 1;
        UnityEngine.Input.compositionCursorPos = new UnityEngine.Vector2() {x = val_71.x, y = val_75};
        goto label_207;
    }
    private void OnKey(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        var val_13;
        UnityEngine.Object val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_13 = 下上丐丆丝丟丝丒不;
        val_14 = this;
        int val_1 = UnityEngine.Time.frameCount;
        val_15 = 1152921505098006528;
        val_16 = null;
        val_16 = null;
        if(UIInput.上丄世与丏丏下丆丏 == val_1)
        {
                return;
        }
        
        if(this.丟丕东万丐丁丁专一 != 0)
        {
                if(this.丟丕东万丐丁丁专一.cancelKey0 != val_13)
        {
                if(this.丟丕东万丐丁丁专一.cancelKey1 != val_13)
        {
            goto label_10;
        }
        
        }
        
            val_17 = null;
            val_17 = null;
            UIInput.上丄世与丏丏下丆丏 = val_1;
            this.isSelected = false;
            return;
        }
        
        label_10:
        if(val_13 != 9)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        UIInput.上丄世与丏丏下丆丏 = val_1;
        this.isSelected = false;
        val_14 = this.GetComponent<UIKeyNavigation>();
        if(val_14 == 0)
        {
                return;
        }
        
        val_14 = ???;
        val_13 = ???;
        val_15 = ???;
        goto typeof(UIKeyNavigation).__il2cppRuntimeField_198;
    }
    protected void 三一丘丙业且世与丛()
    {
        if((System.String.IsNullOrEmpty(value:  this.mValue)) != false)
        {
                return;
        }
        
        int val_2 = this.丟一下丟丂三一丂七;
        if(val_2 == this.不丗丞丂丈丒七丒丌)
        {
                val_2 = val_2 - 1;
            if(val_2 < this.不丗丞丂丈丒七丒丌)
        {
                return;
        }
        
            this.不丗丞丂丈丒七丒丌 = val_2;
        }
    
    }
    protected virtual void 丁丌丒七丐丂且下丞(string 丕丗丘丑丛与丑业丒)
    {
        var val_31;
        丗丘丄丑丕丌且七上 val_32;
        丗丘丄丑丕丌且七上 val_33;
        var val_34;
        var val_35;
        string val_36;
        var val_37;
        string val_1 = this.丁一不丌世丒丛上丕();
        string val_2 = this.丄丗与丁业丐一上东();
        val_31 = val_2.Length;
        val_32 = val_1.Length;
        val_33 = 丕丗丘丑丛与丑业丒.Length;
        System.Text.StringBuilder val_9 = new System.Text.StringBuilder(capacity:  (val_2.Length + val_32) + val_33);
        System.Text.StringBuilder val_10 = val_9.Append(value:  val_1);
        int val_11 = 丕丗丘丑丛与丑业丒.Length;
        if(val_11 < 1)
        {
            goto label_13;
        }
        
        val_32 = 0;
        label_22:
        val_34 = val_32;
        char val_12 = 丕丗丘丑丛与丑业丒.Chars[0];
        if((val_12 & 65535) != '')
        {
            goto label_9;
        }
        
        this.三一丘丙业且世与丛();
        goto label_20;
        label_9:
        if(this.characterLimit < 1)
        {
            goto label_11;
        }
        
        val_34 = 0;
        if((val_9.Length + val_31) >= this.characterLimit)
        {
            goto label_13;
        }
        
        label_11:
        val_33 = this.onValidate;
        if(val_33 != null)
        {
                val_35 = val_33;
            char val_17 = val_35.Invoke(丕丗丘丑丛与丑业丒:  val_9, 上世丅丒三丅丈丁下:  val_9.Length, 一丆丕不业丕丆不业:  val_12);
        }
        else
        {
                val_33 = val_9;
            val_35 = this;
            char val_19 = this.丏且丕丄世丕不丕丙(丕丗丘丑丛与丑业丒:  val_9, 下业丕七东丌丝下且:  val_9.Length, 丕上丙丝丅丛丐丏丑:  val_12);
        }
        
        if((val_19 & 65535) != 0)
        {
                System.Text.StringBuilder val_21 = val_9.Append(value:  val_19);
        }
        
        label_20:
        val_32 = val_32 + 1;
        if(val_32 < val_11)
        {
            goto label_22;
        }
        
        label_13:
        int val_22 = val_9.Length;
        this.丟一下丟丂三一丂七 = val_22;
        this.不丗丞丂丈丒七丒丌 = val_22;
        val_36 = 0;
        int val_23 = val_2.Length;
        if(val_23 >= 1)
        {
                do
        {
            char val_24 = val_2.Chars[0];
            val_32 = this.onValidate;
            if(val_32 != null)
        {
                val_37 = val_32;
            val_36 = val_9;
            char val_26 = val_37.Invoke(丕丗丘丑丛与丑业丒:  val_9, 上世丅丒三丅丈丁下:  val_9.Length, 一丆丕不业丕丆不业:  val_24);
        }
        else
        {
                val_32 = val_9;
            val_37 = this;
            val_36 = val_32;
            char val_28 = this.丏且丕丄世丕不丕丙(丕丗丘丑丛与丑业丒:  val_9, 下业丕七东丌丝下且:  val_9.Length, 丕上丙丝丅丛丐丏丑:  val_24);
        }
        
            if((val_28 & 65535) != 0)
        {
                val_36 = val_28;
            System.Text.StringBuilder val_30 = val_9.Append(value:  val_36);
        }
        
            val_31 = 0 + 1;
        }
        while(val_23 != val_31);
        
        }
        
        this.mValue = val_9;
        this.UpdateLabel();
        this.丄丕上且专七东丌丙();
    }
    protected string 丁一不丌世丒丛上丕()
    {
        int val_1 = UnityEngine.Mathf.Min(a:  this.丟一下丟丂三一丂七, b:  this.不丗丞丂丈丒七丒丌);
        if((val_1 & 2147483648) != 0)
        {
                return "";
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mValue)) == true)
        {
                return "";
        }
        
        if(this.mValue != null)
        {
                return this.mValue.Substring(startIndex:  0, length:  val_1);
        }
        
        return this.mValue.Substring(startIndex:  0, length:  val_1);
    }
    protected string 丄丗与丁业丐一上东()
    {
        int val_1 = UnityEngine.Mathf.Max(a:  this.丟一下丟丂三一丂七, b:  this.不丗丞丂丈丒七丒丌);
        if((System.String.IsNullOrEmpty(value:  this.mValue)) == true)
        {
                return "";
        }
        
        if(val_1 >= this.mValue.Length)
        {
                return "";
        }
        
        if(this.mValue != null)
        {
                return this.mValue.Substring(startIndex:  val_1);
        }
        
        return this.mValue.Substring(startIndex:  val_1);
    }
    protected string 不丅丏丙丂丏丛丛下()
    {
        if((System.String.IsNullOrEmpty(value:  this.mValue)) == true)
        {
                return "";
        }
        
        if(this.丟一下丟丂三一丂七 == this.不丗丞丂丈丒七丒丌)
        {
                return "";
        }
        
        int val_2 = UnityEngine.Mathf.Min(a:  this.丟一下丟丂三一丂七, b:  this.不丗丞丂丈丒七丒丌);
        return this.mValue.Substring(startIndex:  val_2, length:  (UnityEngine.Mathf.Max(a:  this.丟一下丟丂三一丂七, b:  this.不丗丞丂丈丒七丒丌)) - val_2);
    }
    protected int 丏业丄丛丘万七三丝()
    {
        UILabel val_5;
        var val_7;
        float val_8;
        var val_9;
        var val_10;
        val_5 = this;
        UnityEngine.Ray val_1 = UICamera.currentRay;
        if((651043024 & 1) != 0)
        {
                val_9 = null;
            val_9 = null;
            val_5 = this.label;
            val_7 = 0f;
            val_8 = V10.16B;
            val_10 = (val_5.GetCharacterIndexAtPosition(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 0f, y = V9.16B, z = val_8}, 丑丁丝丕丆丐业七上:  false)) + UIInput.丟丄下丟丐与专丙丁;
            return (int)val_10;
        }
        
        val_10 = 0;
        return (int)val_10;
    }
    protected virtual void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        if(丆丟专丑丁丒丁上丙 == false)
        {
                return;
        }
        
        if(this.isSelected == false)
        {
                return;
        }
        
        if(this.label == 0)
        {
                return;
        }
        
        if(UICamera.currentScheme != 0)
        {
                if(UICamera.currentScheme != 1)
        {
                return;
        }
        
        }
        
        this.selectionEnd = this.丏业丄丛丘万七三丝();
        if((UnityEngine.Input.GetKey(key:  48)) == true)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKey(key:  47)) != false)
        {
                return;
        }
        
        this.selectionStart = this.不丗丞丂丈丒七丒丌;
    }
    protected virtual void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.label == 0)
        {
                return;
        }
        
        if(UICamera.currentScheme != 0)
        {
                if(UICamera.currentScheme != 1)
        {
                return;
        }
        
        }
        
        this.selectionEnd = this.丏业丄丛丘万七三丝();
    }
    private void OnDisable()
    {
        goto typeof(UIInput).__il2cppRuntimeField_1B8;
    }
    protected virtual void 丈丏丅丌七丕上业丟()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丟丁丂丌丆丄丐业专)) != false)
        {
                this.丟丁丂丌丆丄丐业专.enabled = false;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.万与丏东且丘丕不与)) != false)
        {
                this.万与丏东且丘丕不与.enabled = false;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丗且丐丗世万世丌业)) == false)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.Destroy(万且万且丑丗且丌丆:  this.丗且丐丗世万世丌业);
        this.丗且丐丗世万世丌业 = 0;
    }
    public virtual void Submit()
    {
        var val_3;
        var val_4;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  this)) == false)
        {
                return;
        }
        
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        val_3 = null;
        val_3 = null;
        if(UIInput.current == 0)
        {
                val_4 = null;
            val_4 = null;
            UIInput.current = this;
            EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onSubmit);
            UIInput.current = 0;
        }
        
        this.丒丂丒丕丏万不丅且(下下丏一丙不丘丌丞:  this.mValue);
    }
    public void UpdateLabel()
    {
        var val_71;
        var val_72;
        UILabel val_73;
        var val_74;
        UnityEngine.Color val_75;
        var val_76;
        var val_77;
        var val_78;
        float val_79;
        float val_80;
        UILabel val_81;
        string val_82;
        string val_83;
        var val_84;
        int val_85;
        string val_86;
        var val_87;
        var val_88;
        var val_90;
        int val_92;
        var val_94;
        var val_95;
        int val_96;
        int val_97;
        int val_98;
        float val_99;
        float val_100;
        float val_101;
        float val_102;
        float val_103;
        bool val_104;
        var val_105;
        UILabel val_106;
        丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 val_107;
        var val_109;
        int val_110;
        var val_111;
        val_71 = this;
        val_72 = 1152921504848912384;
        if(this.label == 0)
        {
                return;
        }
        
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        bool val_2 = this.isSelected;
        if(this.丞丐业丕世业专丁专 != false)
        {
                this.丘上丐世丆丑且丞丒();
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mValue)) == false)
        {
            goto label_6;
        }
        
        val_73 = this.label;
        val_74 = System.String.IsNullOrEmpty(value:  UnityEngine.Input.compositionString);
        if((val_2 | (~val_74)) == true)
        {
            goto label_7;
        }
        
        val_75 = this.与世丐下丘丑丈不且;
        val_76 = 1152921535323731588;
        val_77 = 1152921535323731592;
        val_78 = 1152921535323731596;
        val_74 = 1;
        goto label_8;
        label_6:
        val_73 = this.label;
        val_74 = 0;
        label_7:
        val_75 = this.activeTextColor;
        val_76 = 1152921535323731500;
        val_77 = 1152921535323731504;
        val_78 = 1152921535323731508;
        label_8:
        val_80 = mem[this.activeTextColor];
        val_80 = this.activeTextColor.r;
        val_73.color = new UnityEngine.Color() {r = val_80, g = 2.627126E-21f, b = 2.627126E-21f, a = 2.627126E-21f};
        if((val_74 & 1) == 0)
        {
            goto label_10;
        }
        
        val_81 = this.label;
        val_82 = mem[val_2 != true ? "" : this.丁丙丙丙上不万丁丌];
        val_82 = (val_2 != true) ? "" : this.丁丙丙丙上不万丁丌;
        goto label_11;
        label_10:
        if(this.inputType != 2)
        {
            goto label_12;
        }
        
        val_83 = "";
        val_84 = "*";
        var val_68 = this.mValue.Length;
        if(val_68 >= 1)
        {
                do
        {
            val_68 = val_68 - 1;
            val_83 = val_83 + ((this.label.mFont.bmFont.且丞世东丟丌且下丁(丞世不丒下上上丝丑:  42)) == 0) ? "x" : (val_84)(((this.label.mFont.bmFont.且丞世东丟丌且下丁(丞世不丒下上上丝丑:  42)) == 0) ? "x" : (val_84));
        }
        while(val_68 != 0);
        
        }
        
        if(val_2 == false)
        {
            goto label_26;
        }
        
        label_32:
        val_85 = UnityEngine.Mathf.Min(a:  val_83.Length, b:  this.cursorPosition);
        if(val_83 != null)
        {
            goto label_33;
        }
        
        goto label_31;
        label_12:
        val_83 = this.mValue;
        if(val_2 == true)
        {
            goto label_32;
        }
        
        label_26:
        val_85 = 0;
        if(val_83 != null)
        {
            goto label_33;
        }
        
        label_31:
        label_33:
        val_86 = val_83.Substring(startIndex:  0, length:  0);
        if(val_2 != false)
        {
                val_86 = val_86 + UnityEngine.Input.compositionString;
        }
        
        if(val_83 != null)
        {
                val_87 = val_83.Length;
        }
        else
        {
                val_87 = 0.Length;
        }
        
        val_82 = val_86 + val_83.Substring(startIndex:  0, length:  val_87 - val_85)(val_83.Substring(startIndex:  0, length:  val_87 - val_85));
        if(((val_2 == false) || (this.label.mOverflow != 1)) || (this.label.mMaxLineCount != 1))
        {
            goto label_41;
        }
        
        int val_26 = this.label.CalculateOffsetToFit(丕丗丘丑丛与丑业丒:  val_82);
        val_88 = null;
        if(val_26 == 0)
        {
            goto label_43;
        }
        
        val_90 = null;
        val_92 = UIInput.丟丄下丟丐与专丙丁;
        if(val_85 >= val_92)
        {
            goto label_46;
        }
        
        UIInput.丟丄下丟丐与专丙丁 = val_85;
        goto label_49;
        label_41:
        val_94 = null;
        val_94 = null;
        UIInput.丟丄下丟丐与专丙丁 = 0;
        val_81 = this.label;
        label_11:
        if(this.label.mAlignment != this.业丅三丞业丄上且丒)
        {
                this.label.mAlignment = this.业丅三丞业丄上且丒;
            mem2[0] = true;
            this.label.丁丛下专丗丁丞万上 = true;
            val_81.丆丐丈七丆丆一丛丏();
        }
        
        label_140:
        this.label.text = val_82;
        if(val_2 == false)
        {
            goto label_59;
        }
        
        val_95 = null;
        val_95 = null;
        if(UIInput.丗丏一丛丄七丞万与 == null)
        {
            goto label_58;
        }
        
        if(this.inputShouldBeHidden == false)
        {
            goto label_59;
        }
        
        val_95 = null;
        label_58:
        val_95 = null;
        val_96 = this.不丗丞丂丈丒七丒丌;
        val_97 = this.丟一下丟丂三一丂七 - UIInput.丟丄下丟丐与专丙丁;
        val_98 = val_96 - UIInput.丟丄下丟丐与专丙丁;
        if(this.丗且丐丗世万世丌业 == 0)
        {
                var val_69 = 0;
            this.丗且丐丗世万世丌业 = new UnityEngine.Texture2D(width:  2, height:  2, textureFormat:  5, mipChain:  false);
            do
        {
            do
        {
            UnityEngine.Color val_30 = UnityEngine.Color.white;
            val_79 = val_30.g;
            val_80 = val_30.a;
            this.丗且丐丗世万世丌业.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_30.r, g = val_79, b = val_30.b, a = val_80});
            val_96 = 0 + 1;
        }
        while(val_96 != 2);
        
            val_69 = val_69 + 1;
        }
        while(val_69 != 2);
        
            this.丗且丐丗世万世丌业.Apply();
        }
        
        if(val_97 == val_98)
        {
            goto label_83;
        }
        
        if(this.丟丁丂丌丆丄丐业专 != 0)
        {
            goto label_72;
        }
        
        UITexture val_33 = 不丌丂丁丄一与丆丙.丞丝业一丟世丒上且<UITexture>(丝三丁东丈丒世丅业:  this.label.cachedGameObject, 丟丕丞丁丝丂上丄上:  2147483647);
        this.丟丁丂丌丆丄丐业专 = val_33;
        val_33.name = "Input Highlight";
        mem2[0] = 0;
        this.丟丁丂丌丆丄丐业专.pivot = this.label.pivot;
        val_96 = this.label.cachedTransform;
        this.丟丁丂丌丆丄丐业专.SetAnchor(丙丒七丄上与丏丙丙:  val_96);
        goto label_83;
        label_59:
        val_97 = ???;
        val_71 = ???;
        val_98 = ???;
        val_72 = ???;
        val_79 = ???;
        val_80 = ???;
        goto typeof(UIInput).__il2cppRuntimeField_1B8;
        label_72:
        val_71 + 200.pivot = val_71 + 24.pivot;
        val_96 = mem[val_71 + 216];
        val_96 = val_71 + 216;
        val_71 + 200.enabled = true;
        label_83:
        if((val_71 + 208) == 0)
        {
                UITexture val_39 = 不丌丂丁丄一与丆丙.丞丝业一丟世丒上且<UITexture>(丝三丁东丈丒世丅业:  val_71 + 24.cachedGameObject, 丟丕丞丁丝丂上丄上:  2147483647);
            mem2[0] = val_39;
            val_39.name = "Input Caret";
            mem2[0] = 0;
            val_71 + 208.pivot = val_71 + 24.pivot;
            val_71 + 208.SetAnchor(丙丒七丄上与丏丙丙:  val_71 + 24.cachedTransform);
        }
        else
        {
                val_71 + 208.pivot = val_71 + 24.pivot;
            val_71 + 208.enabled = true;
        }
        
        if(val_97 != val_98)
        {
            goto label_109;
        }
        
        val_99 = mem[val_71 + 88];
        val_99 = val_71 + 88;
        val_100 = mem[val_71 + 96];
        val_100 = val_71 + 96;
        val_101 = mem[val_71 + 104];
        val_101 = val_71 + 104;
        val_102 = mem[val_71 + 112];
        val_102 = val_71 + 112;
        val_103 = val_99;
        val_71 + 24.PrintOverlay(丄且一丄丏丆丐丗与:  val_97, 丈丝世且万世丈丌万:  val_97, 丑丏丕下丙万丐丛丄:  val_71 + 208 + 224, 下丙丕丌丁与与丏丗:  0, 丐丆丝丝丁丙丙丙丕:  new UnityEngine.Color() {r = val_103, g = val_71 + 88 + 4, b = val_100, a = val_71 + 96 + 4}, 与丛三不丝丞下万丑:  new UnityEngine.Color() {r = val_101, g = val_71 + 104 + 4, b = val_102, a = val_71 + 112 + 4});
        if((val_71 + 200) == 0)
        {
            goto label_113;
        }
        
        val_104 = 0;
        goto label_115;
        label_109:
        val_99 = mem[val_71 + 88];
        val_99 = val_71 + 88;
        val_100 = mem[val_71 + 96];
        val_100 = val_71 + 96;
        val_101 = mem[val_71 + 104];
        val_101 = val_71 + 104;
        val_102 = mem[val_71 + 112];
        val_102 = val_71 + 112;
        val_103 = val_99;
        val_71 + 24.PrintOverlay(丄且一丄丏丆丐丗与:  val_97, 丈丝世且万世丈丌万:  val_98, 丑丏丕下丙万丐丛丄:  val_71 + 208 + 224, 下丙丕丌丁与与丏丗:  val_71 + 200 + 224, 丐丆丝丝丁丙丙丙丕:  new UnityEngine.Color() {r = val_103, g = val_71 + 88 + 4, b = val_100, a = val_71 + 96 + 4}, 与丛三不丝丞下万丑:  new UnityEngine.Color() {r = val_101, g = val_71 + 104 + 4, b = val_102, a = val_71 + 112 + 4});
        val_98 = mem[val_71 + 200 + 224];
        val_98 = val_71 + 200 + 224;
        val_104 = val_98.丗丁丅丗三下丂丘一();
        label_115:
        val_71 + 200.enabled = val_104;
        label_113:
        float val_45 = RealTime.time;
        val_45 = val_45 + 0.5f;
        mem2[0] = val_45;
        mem2[0] = val_71 + 24 + 140;
        return;
        label_43:
        val_105 = null;
        UIInput.丟丄下丟丐与专丙丁 = 0;
        val_106 = this.label;
        if(this.label.mAlignment == this.业丅三丞业丄上且丒)
        {
            goto label_149;
        }
        
        val_107 = 1;
        this.label.mAlignment = this.业丅三丞业丄上且丒;
        goto label_125;
        label_46:
        val_90 = null;
        val_92 = UIInput.丟丄下丟丐与专丙丁;
        if(val_26 >= val_92)
        {
            goto label_128;
        }
        
        UIInput.丟丄下丟丐与专丙丁 = val_26;
        label_49:
        val_106 = this.label;
        if(this.label.mAlignment == 1)
        {
            goto label_149;
        }
        
        val_107 = 1;
        this.label.mAlignment = val_107;
        label_125:
        mem2[0] = val_107;
        this.label.丁丛下专丗丁丞万上 = val_107;
        label_150:
        val_106.丆丐丈七丆丆一丛丏();
        label_149:
        val_109 = null;
        val_109 = null;
        val_110 = UIInput.丟丄下丟丐与专丙丁;
        if(val_110 == 0)
        {
            goto label_140;
        }
        
        val_110 = UIInput.丟丄下丟丐与专丙丁;
        string val_65 = val_82.Substring(startIndex:  val_110, length:  val_82.Length - UIInput.丟丄下丟丐与专丙丁);
        goto label_140;
        label_128:
        int val_67 = this.label.CalculateOffsetToFit(丕丗丘丑丛与丑业丒:  val_82.Substring(startIndex:  0, length:  0));
        val_111 = null;
        val_111 = null;
        if(val_67 <= UIInput.丟丄下丟丐与专丙丁)
        {
            goto label_149;
        }
        
        UIInput.丟丄下丟丐与专丙丁 = val_67;
        if(this.label.mAlignment == 3)
        {
            goto label_149;
        }
        
        this.label.mAlignment = 3;
        mem2[0] = true;
        this.label.丁丛下专丗丁丞万上 = true;
        goto label_150;
    }
    protected char 丏且丕丄世丕不丕丙(string 丕丗丘丑丛与丑业丒, int 下业丕七东丌丝下且, char 丕上丙丝丅丛丐丏丑)
    {
        int val_54;
        int val_55;
        char val_56;
        var val_59;
        val_54 = 下业丕七东丌丝下且;
        val_55 = this;
        val_56 = 丕上丙丝丅丛丐丏丑;
        if((万三丟丞业万丕丐丌.丅丗丑一丁一丌丏丕(丕上丙丝丅丛丐丏丑:  val_56)) == false)
        {
            goto label_88;
        }
        
        if((this.validation == 0) || (this.enabled == false))
        {
            goto label_89;
        }
        
        与七丛与丂丞一且丗 val_47 = this.validation;
        val_47 = val_47 - 1;
        if(val_47 > 6)
        {
            goto label_88;
        }
        
        var val_48 = 106029800 + ((this.validation - 1)) << 2;
        val_48 = val_48 + 106029800;
        goto (106029800 + ((this.validation - 1)) << 2 + 106029800);
        label_88:
        val_56 = 0;
        label_89:
        val_59 = val_56;
        return (char)val_59;
    }
    protected void 丄丕上且专七东丌丙()
    {
        UIInput val_3;
        var val_4;
        var val_5;
        val_3 = this;
        val_4 = null;
        val_4 = null;
        if(UIInput.current != 0)
        {
                return;
        }
        
        if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this.onChange)) == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        UIInput.current = val_3;
        val_3 = this.onChange;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  val_3);
        UIInput.current = 0;
    }
    public void RemoveFocus()
    {
        this.isSelected = false;
    }
    public void SaveValue()
    {
        this.丒丂丒丕丏万不丅且(下下丏一丙不丘丌丞:  this.mValue);
    }
    public void LoadValue()
    {
        string val_5;
        if((System.String.IsNullOrEmpty(value:  this.savedAs)) != false)
        {
                return;
        }
        
        val_5 = this.mValue.Replace(oldValue:  "\\n", newValue:  "\n");
        this.mValue = "";
        if((UnityEngine.PlayerPrefs.HasKey(key:  this.savedAs)) != false)
        {
                val_5 = UnityEngine.PlayerPrefs.GetString(key:  this.savedAs);
        }
        
        this.value = val_5;
    }
    public UIInput()
    {
        this.selectAllTextOnFocus = true;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        mem[1152921535324776304] = val_1.b;
        mem[1152921535324776308] = val_1.a;
        this.activeTextColor = val_1;
        mem[1152921535324776300] = val_1.g;
        this.caretColor = 0;
        mem[1152921535324776316] = 0;
        mem[1152921535324776324] = 0;
        this.selectionColor = 0;
        mem[1152921535324776332] = 0;
        mem[1152921535324776340] = 0;
        this.onSubmit = new System.Collections.Generic.List<EventDelegate>();
        this.onChange = new System.Collections.Generic.List<EventDelegate>();
        this.丁丙丙丙上不万丁丌 = "";
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.与世丐下丘丑丈不且 = val_4;
        mem[1152921535324776388] = val_4.g;
        mem[1152921535324776392] = val_4.b;
        mem[1152921535324776396] = val_4.a;
        this.丞丐业丕世业专丁专 = true;
        this.业丅三丞业丄上且丒 = true;
        this.东丏三丘丑专丅丐丏 = true;
        this.丛世专万业丈东不丁 = "";
        this.丌丏丕丑丈业丞不丝 = 0;
        this.与丕丂下丁丒丘丆专 = 0;
        this.丗丌丘丒世下丑丒与 = new char[5];
    }
    private static UIInput()
    {
        UIInput.丟丄下丟丐与专丙丁 = 0;
        UIInput.世丛丐丈丌丂丅上丟 = "";
        UIInput.丐下与丐下三丒丘与 = false;
        UIInput.上丄世与丏丏下丆丏 = 0;
    }

}
