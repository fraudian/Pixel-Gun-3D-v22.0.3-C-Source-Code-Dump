using UnityEngine;
public class UIPopupList : UIWidgetContainer
{
    // Fields
    public static UIPopupList current;
    private static UnityEngine.GameObject 丙专万丙丏业下丛丛;
    private static float 丅丕三三且业丅丆丈;
    private const float 专三丆三与下丕丆不 = 0.15;
    public UIAtlas atlas;
    public UIFont bitmapFont;
    public UnityEngine.Font trueTypeFont;
    public int fontSize;
    public UnityEngine.FontStyle fontStyle;
    public string backgroundSprite;
    public string highlightSprite;
    public UIPopupList.丘丂不不下丕丁下丟 position;
    public 丐丄七丙丁丆丁专丏.下丂专丞万下丕上专 alignment;
    public System.Collections.Generic.List<string> items;
    public System.Collections.Generic.List<object> itemData;
    public UnityEngine.Vector2 padding;
    public UnityEngine.Color textColor;
    public UnityEngine.Color backgroundColor;
    public UnityEngine.Color highlightColor;
    public bool isAnimated;
    public bool isLocalized;
    public bool separatePanel;
    public UIPopupList.丙丒丂丟丘与丕丄丆 openOn;
    public System.Collections.Generic.List<EventDelegate> onChange;
    protected string mSelectedItem;
    protected UIPanel mPanel;
    protected UISprite mBackground;
    protected UISprite mHighlight;
    protected UILabel mHighlightedLabel;
    protected System.Collections.Generic.List<UILabel> mLabelList;
    protected float mBgBorder;
    protected UnityEngine.GameObject 世丄且专下世七丄丈;
    protected int 万丁丑丟丒丒丙一丟;
    private UnityEngine.GameObject eventReceiver;
    private string functionName;
    private float textScale;
    private UIFont font;
    private UILabel textLabel;
    private UIPopupList.世丁丑丌丕丑丌丁下 丆不丐丐东丁丌丁丁;
    protected bool 七丐丐上七与丞丄与;
    protected bool 丛丌七业丛不专丅丝;
    protected bool 业丐不丞丝三万丂丈;
    public UnityEngine.GameObject source;
    
    // Properties
    public UnityEngine.Object 一一丝专丝丏丅丟丞 { get; set; }
    public UIPopupList.世丁丑丌丕丑丌丁下 丛丐万业丅丆丛世丟 { get; set; }
    public static bool 丁与万丂丝丒丐万丄 { get; }
    public virtual string 丙业与丙丗丝不丈东 { get; set; }
    public virtual object 一丐丗丁丞丆丅丟丄 { get; }
    public bool 东世三丕三业七丑三 { get; }
    public string 世丝业万世丏丞丝丈 { get; set; }
    private bool 丕且七业丙万丕丛丞 { get; }
    private int 丞丝丐丘一丏丑上三 { get; }
    private float 下丂丘丘丟专丂丂丝 { get; }
    
    // Methods
    public UnityEngine.Object get_ambigiousFont()
    {
        UnityEngine.Font val_3;
        if(this.trueTypeFont != 0)
        {
                val_3 = this.trueTypeFont;
            return (UnityEngine.Object)val_3;
        }
        
        if(this.bitmapFont != 0)
        {
                val_3 = this.bitmapFont;
            return (UnityEngine.Object)val_3;
        }
        
        val_3 = this.font;
        return (UnityEngine.Object)val_3;
    }
    public void set_ambigiousFont(UnityEngine.Object 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                this.bitmapFont = 丙业与丙丗丝不丈东;
            this.trueTypeFont = 0;
        }
        else
        {
                this.bitmapFont = 0;
            this.trueTypeFont = 丙业与丙丗丝不丈东;
        }
        
        this.font = 0;
    }
    public UIPopupList.世丁丑丌丕丑丌丁下 get_onSelectionChange()
    {
        return (世丁丑丌丕丑丌丁下)this.丆不丐丐东丁丌丁丁;
    }
    public void set_onSelectionChange(UIPopupList.世丁丑丌丕丑丌丁下 丙业与丙丗丝不丈东)
    {
        this.丆不丐丐东丁丌丁丁 = 丙业与丙丗丝不丈东;
    }
    public static bool get_isOpen()
    {
        var val_5;
        float val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        val_6 = UIPopupList.专三丆三与下丕丆不;
        if(val_6 == 0)
        {
            goto label_5;
        }
        
        val_7 = null;
        val_7 = null;
        val_6 = UIPopupList.丙专万丙丏业下丛丛;
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        val_8 = 1;
        return (bool)(UIPopupList.丅丕三三且业丅丆丈 > UnityEngine.Time.unscaledTime) ? 1 : 0;
        label_5:
        val_8 = 0;
        return (bool)(UIPopupList.丅丕三三且业丅丆丈 > UnityEngine.Time.unscaledTime) ? 1 : 0;
        label_10:
        val_9 = null;
        val_9 = null;
        return (bool)(UIPopupList.丅丕三三且业丅丆丈 > UnityEngine.Time.unscaledTime) ? 1 : 0;
    }
    public virtual string get_value()
    {
        return (string)this.mSelectedItem;
    }
    public virtual void set_value(string 丙业与丙丗丝不丈东)
    {
        this.mSelectedItem = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        this.丆丌不丈且丈世上丌();
    }
    public virtual object get_data()
    {
        int val_1 = this.items.IndexOf(item:  this.mSelectedItem);
        if((val_1 & 2147483648) != 0)
        {
                return 0;
        }
        
        if(val_1 >= this.itemData.Count)
        {
                return 0;
        }
        
        if(this.itemData != null)
        {
                return this.itemData.Item[val_1];
        }
        
        return this.itemData.Item[val_1];
    }
    public bool get_isColliderEnabled()
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        if(val_1 != 0)
        {
                if(val_1 != null)
        {
                return val_1.enabled;
        }
        
            return val_1.enabled;
        }
        
        UnityEngine.Collider2D val_3 = this.GetComponent<UnityEngine.Collider2D>();
        if(val_3 == 0)
        {
                return false;
        }
        
        if(val_3 != null)
        {
                return val_3.enabled;
        }
        
        return val_3.enabled;
    }
    public string get_selection()
    {
        goto typeof(UIPopupList).__il2cppRuntimeField_168;
    }
    public void set_selection(string 丙业与丙丗丝不丈东)
    {
        goto typeof(UIPopupList).__il2cppRuntimeField_178;
    }
    private bool 业三丐专世上下丌丁()
    {
        if(this.bitmapFont == 0)
        {
                return UnityEngine.Object.op_Inequality(x:  this.trueTypeFont, y:  0);
        }
        
        return true;
    }
    private int 丐且丒丅不不丙丞丐()
    {
        if(this.trueTypeFont != 0)
        {
                return (int)this.fontSize;
        }
        
        if(this.bitmapFont == 0)
        {
                return (int)this.fontSize;
        }
        
        if(this.bitmapFont != null)
        {
                return this.bitmapFont.defaultSize;
        }
        
        return this.bitmapFont.defaultSize;
    }
    private float 丈万丒丈下丌三丄七()
    {
        int val_5;
        float val_6;
        val_5 = this;
        val_6 = 1f;
        if(this.trueTypeFont != 0)
        {
                return (float)val_6;
        }
        
        if(this.bitmapFont == 0)
        {
                return (float)val_6;
        }
        
        val_5 = this.fontSize;
        val_6 = (float)val_5 / (float)this.bitmapFont.defaultSize;
        return (float)val_6;
    }
    public virtual void Clear()
    {
        this.items.Clear();
        this.itemData.Clear();
    }
    public virtual void AddItem(string 丕丗丘丑丛与丑业丒)
    {
        this.items.Add(item:  丕丗丘丑丛与丑业丒);
        this.itemData.Add(item:  0);
    }
    public virtual void AddItem(string 丕丗丘丑丛与丑业丒, object 一丐丗丁丞丆丅丟丄)
    {
        this.items.Add(item:  丕丗丘丑丛与丑业丒);
        this.itemData.Add(item:  一丐丗丁丞丆丅丟丄);
    }
    public virtual void RemoveItem(string 丕丗丘丑丛与丑业丒)
    {
        int val_1 = this.items.IndexOf(item:  丕丗丘丑丛与丑业丒);
        if(val_1 == 1)
        {
                return;
        }
        
        this.items.RemoveAt(index:  val_1);
        this.itemData.RemoveAt(index:  val_1);
    }
    public virtual void RemoveItemByData(object 一丐丗丁丞丆丅丟丄)
    {
        int val_1 = this.itemData.IndexOf(item:  一丐丗丁丞丆丅丟丄);
        if(val_1 == 1)
        {
                return;
        }
        
        this.items.RemoveAt(index:  val_1);
        this.itemData.RemoveAt(index:  val_1);
    }
    protected void 丆丌不丈且丈世上丌()
    {
        var val_4;
        string val_5;
        var val_6;
        if(this.七丐丐上七与丞丄与 == true)
        {
                return;
        }
        
        this.七丐丐上七与丞丄与 = true;
        val_4 = null;
        val_4 = null;
        UIPopupList.专三丆三与下丕丆不 = this;
        if(this.丆不丐丐东丁丌丁丁 != null)
        {
                this.丆不丐丐东丁丌丁丁.Invoke(下下丏一丙不丘丌丞:  this.mSelectedItem);
        }
        
        val_5 = 1152921505092681728;
        if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this.onChange)) != false)
        {
                EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onChange);
        }
        else
        {
                if(this.eventReceiver != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.functionName)) != true)
        {
                val_5 = this.functionName;
            this.eventReceiver.SendMessage(methodName:  val_5, value:  this.mSelectedItem, options:  1);
        }
        
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        UIPopupList.专三丆三与下丕丆不 = UIPopupList.专三丆三与下丕丆不;
        this.七丐丐上七与丞丄与 = false;
    }
    protected virtual void OnEnable()
    {
        bool val_14;
        int val_15;
        if((EventDelegate.丑丕丈丈不不且丑且(丝丘丑业丛万丞丌丝:  this.onChange)) != false)
        {
                this.eventReceiver = 0;
            this.functionName = 0;
        }
        
        if(this.font == 0)
        {
            goto label_6;
        }
        
        if(this.font.isDynamic == false)
        {
            goto label_8;
        }
        
        this.trueTypeFont = this.font.dynamicFont;
        this.fontStyle = this.font.dynamicFontStyle;
        val_14 = 1;
        goto label_11;
        label_8:
        if(this.bitmapFont != 0)
        {
            goto label_14;
        }
        
        val_14 = false;
        this.bitmapFont = this.font;
        label_11:
        this.丛丌七业丛不专丅丝 = val_14;
        label_14:
        this.font = 0;
        label_6:
        if(this.textScale != 0f)
        {
                if(this.bitmapFont != 0)
        {
                float val_14 = (float)this.bitmapFont.defaultSize;
            val_14 = this.textScale * val_14;
            val_15 = 0;
            int val_9 = UnityEngine.Mathf.RoundToInt(f:  val_14);
        }
        else
        {
                val_15 = 16;
        }
        
            this.fontSize = val_15;
            this.textScale = 0f;
        }
        
        if(this.trueTypeFont != 0)
        {
                return;
        }
        
        if(this.bitmapFont == 0)
        {
                return;
        }
        
        if(this.bitmapFont.isDynamic == false)
        {
                return;
        }
        
        this.bitmapFont = 0;
        this.trueTypeFont = this.bitmapFont.dynamicFont;
    }
    protected virtual void OnValidate()
    {
        this.bitmapFont = 0;
        this.trueTypeFont = 0;
        if(this.trueTypeFont != 0)
        {
                if((this.bitmapFont == 0) || (this.丛丌七业丛不专丅丝 == false))
        {
            goto label_7;
        }
        
        }
        
        if(this.bitmapFont == 0)
        {
            goto label_10;
        }
        
        if(this.bitmapFont.isDynamic == false)
        {
            goto label_12;
        }
        
        if(this.bitmapFont == null)
        {
            goto label_13;
        }
        
        this.trueTypeFont = this.bitmapFont.dynamicFont;
        this.fontStyle = this.bitmapFont.dynamicFontStyle;
        goto label_14;
        label_7:
        this.bitmapFont = 0;
        label_10:
        this.trueTypeFont = this.trueTypeFont;
        label_16:
        label_15:
        this.丛丌七业丛不专丅丝 = true;
        return;
        label_12:
        this.bitmapFont = this.bitmapFont;
        goto label_15;
        label_13:
        this.trueTypeFont = 0.dynamicFont;
        this.fontStyle = 0.dynamicFontStyle;
        label_14:
        this.fontSize = this.bitmapFont.defaultSize;
        goto label_16;
    }
    protected virtual void Start()
    {
        if(this.textLabel != 0)
        {
                EventDelegate val_3 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this.textLabel, 丛丌丙世专世东丕下:  public System.Void UILabel::SetCurrentSelection()));
            this.textLabel = 0;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mSelectedItem)) != false)
        {
                if(this.items.Count >= 1)
        {
                this.mSelectedItem = this.items.Item[0];
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mSelectedItem)) != false)
        {
                return;
        }
        
        this.丆丌不丈且丈世上丌();
    }
    protected virtual void 丅万且下丄丗万丐且()
    {
        if(this.isLocalized == false)
        {
                return;
        }
        
        this.丆丌不丈且丈世上丌();
    }
    protected virtual void 丁专丛丛七丄丄七一(UILabel 与丅丟东丗上丅丕三, bool 丌丝丌丁下丐丞丆一)
    {
        if(this.mHighlight == 0)
        {
                return;
        }
        
        this.mHighlightedLabel = 与丅丟东丗上丅丕三;
        if(this.mHighlight.GetAtlasSprite() == null)
        {
                return;
        }
        
        if((丌丝丌丁下丐丞丆一 == true) || (this.isAnimated == false))
        {
            goto label_7;
        }
        
        TweenPosition val_4 = TweenPosition.Begin(丝三丁东丈丒世丅业:  this.mHighlight.gameObject, 与丈业丛丝丒丙一丏:  0.1f, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        mem2[0] = 2;
        if(this.业丐不丞丝三万丂丈 == false)
        {
            goto label_10;
        }
        
        return;
        label_7:
        this.mHighlight.cachedTransform.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        return;
        label_10:
        this.业丐不丞丝三万丂丈 = true;
        UnityEngine.Coroutine val_6 = this.StartCoroutine(methodName:  "UpdateTweenPosition");
    }
    protected virtual UnityEngine.Vector3 不丟不丐丟与七丞七()
    {
        if((this.mHighlightedLabel != 0) && (this.mHighlight != 0))
        {
                if(this.mHighlight.GetAtlasSprite() != null)
        {
                float val_4 = this.atlas.pixelSize;
            float val_5 = val_4 * (float)val_3.borderLeft;
            float val_6 = val_4 * (float)val_3.borderTop;
            this = this.mHighlightedLabel.cachedTransform;
            UnityEngine.Vector3 val_8 = this.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    protected virtual System.Collections.IEnumerator UpdateTweenPosition()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UIPopupList.丛丌丝丂业丄上丕丈();
    }
    protected virtual void 东丏丙不丛世丌丞丞(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丟丆丕且丆丈丂丌丘)
    {
        var val_8;
        var val_9;
        var val_10;
        val_9 = 丟丆丕且丆丈丂丌丘;
        val_10 = this;
        if(mem[137165081] == false)
        {
            goto label_0;
        }
        
        if(val_9 == false)
        {
                return;
        }
        
        label_3:
        UILabel val_1 = 丝三丁东丈丒世丅业.GetComponent<UILabel>();
        val_10 = ???;
        val_8 = ???;
        val_9 = ???;
        goto typeof(UIPopupList).__il2cppRuntimeField_228;
        label_0:
        mem2[0] = 1;
        if((val_9 & 1) != 0)
        {
            goto label_3;
        }
    
    }
    protected virtual void 业丈丌东丘万丕丄丕(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丆丟专丑丁丒丁上丙)
    {
        UnityEngine.AudioClip val_7;
        int val_8;
        var val_9;
        val_7 = 丆丟专丑丁丒丁上丙;
        if(val_7 == false)
        {
                return;
        }
        
        UILabel val_1 = 丝三丁东丈丒世丅业.GetComponent<UILabel>();
        UIEventListener val_2 = 丝三丁东丈丒世丅业.GetComponent<UIEventListener>();
        if(val_2.parameter != null)
        {
                var val_3 = (null == null) ? val_2.parameter : 0;
        }
        
        if(val_4.Length < 1)
        {
            goto typeof(UIPopupList).__il2cppRuntimeField_2B8;
        }
        
        val_8 = val_4.Length & 4294967295;
        val_9 = 0;
        goto label_10;
        label_16:
        val_8 = val_4.Length;
        val_9 = 1;
        label_10:
        if((X26 + 32) == 0)
        {
                val_7 = mem[X26 + 24];
            val_7 = X26 + 24;
            UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_7, 与丁万东丌丑下丏丕:  X26 + 36, 丟与不丄丕丞专下丛:  1f);
        }
        
        if((val_8 - 1) != val_9)
        {
            goto label_16;
        }
        
        goto typeof(UIPopupList).__il2cppRuntimeField_2B8;
    }
    private void 丂三丛下丐丆丒三丗(UILabel 与丅丟东丗上丅丕三, bool 丌丝丌丁下丐丞丆一)
    {
        bool val_1 = 丌丝丌丁下丐丞丆一;
        goto typeof(UIPopupList).__il2cppRuntimeField_228;
    }
    protected virtual void 丁丛上万专三丗丅丏(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        float val_14;
        UnityEngine.Object val_15;
        var val_16;
        val_15 = this;
        if(this.enabled == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_14 = UIPopupList.专三丆三与下丕丆不;
        if(val_14 != this)
        {
                return;
        }
        
        System.Collections.Generic.List<UILabel> val_14 = this.mLabelList;
        int val_3 = val_14.IndexOf(item:  this.mHighlightedLabel);
        val_14 = (val_3 == 1) ? 0 : (val_3);
        if(下上丐丆丝丟丝丒不 == 274)
        {
            goto label_8;
        }
        
        if(下上丐丆丝丟丝丒不 != 273)
        {
                return;
        }
        
        if(下上丐丆丝丟丝丒不 < 273)
        {
                return;
        }
        
        label_13:
        UILabel val_5 = this.mLabelList.Item[val_14 - 1];
        val_15 = ???;
        val_14 = ???;
        goto typeof(UIPopupList).__il2cppRuntimeField_228;
        label_8:
        if((val_14 + 1) < (val_15 + 208.Count))
        {
            goto label_13;
        }
    
    }
    protected virtual void OnKey(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        float val_9;
        UnityEngine.Object val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        UICamera val_15;
        val_10 = this;
        if(this.enabled == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_9 = UIPopupList.专三丆三与下丕丆不;
        if(val_9 != this)
        {
                return;
        }
        
        val_12 = 1152921505096622080;
        val_13 = null;
        val_13 = null;
        if(UICamera.current.cancelKey0 != 下上丐丆丝丟丝丒不)
        {
                val_14 = null;
            val_14 = null;
            val_15 = UICamera.current;
            if(UICamera.current.cancelKey1 != 下上丐丆丝丟丝丒不)
        {
                return;
        }
        
        }
        
        val_10 = ???;
        val_9 = ???;
        goto typeof(UIPopupList).__il2cppRuntimeField_2A8;
    }
    protected virtual void OnDisable()
    {
        goto typeof(UIPopupList).__il2cppRuntimeField_2B8;
    }
    protected virtual void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(丞丈丌且东丆丅丗万 == false)
        {
            goto typeof(UIPopupList).__il2cppRuntimeField_2B8;
        }
    
    }
    public static void Close()
    {
        var val_2;
        float val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        val_3 = UIPopupList.专三丆三与下丕丆不;
        if(val_3 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = UIPopupList.专三丆三与下丕丆不;
        UIPopupList.专三丆三与下丕丆不 = 0f;
        UIPopupList.专三丆三与下丕丆不.__il2cppRuntimeField_3 = 0;
    }
    public virtual void CloseSelf()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        int val_17;
        var val_18;
        var val_20;
        var val_21;
        int val_22;
        var val_23;
        var val_24;
        float val_25;
        var val_26;
        var val_27;
        val_13 = null;
        val_13 = null;
        if(UIPopupList.丙专万丙丏业下丛丛 == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(UIPopupList.专三丆三与下丕丆不 != this)
        {
                return;
        }
        
        this.StopCoroutine(methodName:  "CloseIfUnselected");
        this.世丄且专下世七丄丈 = 0;
        this.mLabelList.Clear();
        val_15 = null;
        if(this.isAnimated == false)
        {
            goto label_12;
        }
        
        val_16 = null;
        if(val_3.Length < 1)
        {
            goto label_17;
        }
        
        val_17 = val_3.Length & 4294967295;
        val_18 = 0;
        goto label_18;
        label_23:
        val_17 = val_3.Length;
        val_18 = 1;
        label_18:
        UnityEngine.Color val_5 = X21.color;
        val_20 = TweenColor.Begin(丝三丁东丈丒世丅业:  X21.gameObject, 与丈业丛丝丒丙一丏:  0.15f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = 0f});
        mem2[0] = 2;
        if((val_17 - 1) != val_18)
        {
            goto label_23;
        }
        
        label_17:
        val_21 = null;
        val_21 = null;
        if(val_8.Length < 1)
        {
            goto label_28;
        }
        
        val_22 = val_8.Length & 4294967295;
        val_23 = 0;
        goto label_29;
        label_32:
        val_22 = val_8.Length;
        val_23 = 1;
        label_29:
        val_20.enabled = false;
        if((val_22 - 1) != val_23)
        {
            goto label_32;
        }
        
        label_28:
        val_24 = null;
        val_24 = null;
        UnityEngine.Object.Destroy(obj:  UIPopupList.丙专万丙丏业下丛丛, t:  0.15f);
        val_25 = UnityEngine.Time.unscaledTime + (UnityEngine.Mathf.Max(a:  0.1f, b:  0.15f));
        goto label_39;
        label_12:
        val_26 = null;
        UnityEngine.Object.Destroy(obj:  UIPopupList.丙专万丙丏业下丛丛);
        val_25 = UnityEngine.Time.unscaledTime + 0.1f;
        label_39:
        val_27 = null;
        UIPopupList.丅丕三三且业丅丆丈 = val_25;
        this.mBackground = 0;
        this.mHighlight = 0;
        val_27 = null;
        UIPopupList.丙专万丙丏业下丛丛 = 0;
        UIPopupList.专三丆三与下丕丆不 = 0f;
        UIPopupList.专三丆三与下丕丆不.__il2cppRuntimeField_3 = 0;
    }
    protected virtual void 丆丒且东下丛不丘丞(UIWidget 世丌丌丙丞丟下东丞)
    {
        UnityEngine.Color val_1 = 世丌丌丙丞丟下东丞.color;
        世丌丌丙丞丟下东丞.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        TweenColor val_3 = TweenColor.Begin(丝三丁东丈丒世丅业:  世丌丌丙丞丟下东丞.gameObject, 与丈业丛丝丒丙一丏:  0.15f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        mem2[0] = 2;
    }
    protected virtual void 丐万丘丁世不三丟丂(UIWidget 世丌丌丙丞丟下东丞, bool 丛三丕丈丝丆业丏丙, float 专丙丗业世丐与丝丙)
    {
        UnityEngine.Vector3 val_2 = 世丌丌丙丞丟下东丞.cachedTransform.localPosition;
        if(丛三丕丈丝丆业丏丙 != false)
        {
            
        }
        else
        {
            
        }
        
        世丌丌丙丞丟下东丞.cachedTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        TweenPosition val_5 = TweenPosition.Begin(丝三丁东丈丒世丅业:  世丌丌丙丞丟下东丞.gameObject, 与丈业丛丝丒丙一丏:  0.15f, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        mem2[0] = 2;
    }
    protected virtual void 丒一丞丌丙丅专丝丙(UIWidget 世丌丌丙丞丟下东丞, bool 丛三丕丈丝丆业丏丙, float 专丙丗业世丐与丝丙)
    {
        UnityEngine.GameObject val_13;
        if(世丌丌丙丞丟下东丞 != null)
        {
                val_13 = 世丌丌丙丞丟下东丞.gameObject;
        }
        else
        {
                val_13 = 0.gameObject;
        }
        
        UnityEngine.Transform val_3 = 世丌丌丙丞丟下东丞.cachedTransform;
        float val_5 = this.丈万丒丈下丌三丄七();
        float val_13 = this.mBgBorder;
        val_5 = val_5 * (float)this.丐且丒丅不不丙丞丐();
        val_13 = val_13 + val_13;
        float val_6 = val_5 + val_13;
        val_13 = val_6 / (float)世丌丌丙丞丟下东丞.height;
        val_3.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        TweenScale val_9 = TweenScale.Begin(丝三丁东丈丒世丅业:  val_13, 与丈业丛丝丒丙一丏:  0.15f, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        mem2[0] = 2;
        if(丛三丕丈丝丆业丏丙 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_10 = val_3.localPosition;
        float val_14 = (float)世丌丌丙丞丟下东丞.height;
        val_14 = val_10.y - val_14;
        val_10.y = val_6 + val_14;
        val_3.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_13 = TweenPosition.Begin(丝三丁东丈丒世丅业:  val_13, 与丈业丛丝丒丙一丏:  0.15f, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        mem2[0] = 2;
    }
    private void 一丏丕丅丐丑且丏丐(UIWidget 世丌丌丙丞丟下东丞, bool 丛三丕丈丝丆业丏丙, float 专丙丗业世丐与丝丙)
    {
        bool val_1 = 丛三丕丈丝丆业丏丙;
        goto typeof(UIPopupList).__il2cppRuntimeField_2D8;
    }
    protected virtual void OnClick()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = this;
        if(this.万丁丑丟丒丒丙一丟 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = 1152921504848912384;
        if(UIPopupList.丙专万丙丏业下丛丛 == 0)
        {
                if((this.openOn - 2) < 2)
        {
                return;
        }
        
            if(this.openOn == 1)
        {
                val_14 = null;
            val_14 = null;
            if(UICamera.currentTouchID != 2)
        {
                return;
        }
        
        }
        
            val_11 = ???;
            val_13 = ???;
        }
        else
        {
                if((val_11 + 200) == 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_5 = val_11 + 200.gameObject;
        }
    
    }
    protected virtual void OnDoubleClick()
    {
        if(this.openOn != 2)
        {
                return;
        }
        
        goto typeof(UIPopupList).__il2cppRuntimeField_318;
    }
    private System.Collections.IEnumerator CloseIfUnselected()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UIPopupList.专与丁丏丆三与下丈();
    }
    public virtual void Show()
    {
        float val_41;
        int val_146;
        float val_148;
        float val_149;
        float val_150;
        var val_153;
        UnityEngine.Transform val_154;
        float val_155;
        float val_156;
        float val_157;
        float val_159;
        float val_160;
        float val_161;
        float val_162;
        var val_163;
        float val_164;
        float val_165;
        var val_166;
        double val_167;
        float val_168;
        double val_170;
        float val_171;
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(UIPopupList.丙专万丙丏业下丛丛 != 0)
        {
                return;
        }
        
        if(this.atlas == 0)
        {
                return;
        }
        
        if(this.业三丐专世上下丌丁() == false)
        {
                return;
        }
        
        if(this.items.Count < 1)
        {
                return;
        }
        
        this.mLabelList.Clear();
        this.StopCoroutine(methodName:  "CloseIfUnselected");
        UICamera.selectedObject = this.gameObject;
        this.世丄且专下世七丄丈 = UICamera.selectedObject;
        UnityEngine.GameObject val_11 = UICamera.selectedObject;
        this.source = val_11;
        if(val_11 == 0)
        {
                UnityEngine.Debug.LogError(message:  "Popup list needs a source object...");
            return;
        }
        
        this.万丁丑丟丒丒丙一丟 = UnityEngine.Time.frameCount;
        if(this.mPanel == 0)
        {
                UIPanel val_16 = UIPanel.Find(丄上七丟不丗丕下丟:  this.transform);
            this.mPanel = val_16;
            if(val_16 == 0)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_18 = new UnityEngine.GameObject(name:  "Drop-down List");
        UIPopupList.丙专万丙丏业下丛丛 = val_18;
        val_18.layer = this.gameObject.layer;
        if(this.separatePanel != false)
        {
                if((this.GetComponent<UnityEngine.Collider>()) != 0)
        {
                val_18.AddComponent<UnityEngine.Rigidbody>().isKinematic = true;
        }
        else
        {
                if((this.GetComponent<UnityEngine.Collider2D>()) != 0)
        {
                val_18.AddComponent<UnityEngine.Rigidbody2D>().isKinematic = true;
        }
        
        }
        
            val_18.AddComponent<UIPanel>().depth = 1000000;
        }
        
        UIPopupList.专三丆三与下丕丆不 = this;
        UnityEngine.Transform val_28 = val_18.transform;
        val_28.parent = this.mPanel.cachedTransform;
        if((this.openOn != 3) || (this.世丄且专下世七丄丈 == this.gameObject))
        {
            goto label_68;
        }
        
        UnityEngine.Vector2 val_32 = UICamera.lastEventPosition;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y});
        this.mPanel.ResetAnchors();
        UnityEngine.Vector3 val_35 = this.mPanel.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        UnityEngine.Vector3 val_36 = this.mPanel.cachedTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
        if(val_28 == null)
        {
            goto label_78;
        }
        
        val_28.localPosition = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
        goto label_79;
        label_68:
        UnityEngine.Bounds val_39 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  this.mPanel.cachedTransform, 三丏丑不业丏不丂丈:  this.transform, 三世与丌丈丈丅丒三:  false, 丄丗丘丈丗丌丕丒世:  false);
        if(val_28 != null)
        {
                val_28.localPosition = new UnityEngine.Vector3() {x = val_41, y = V1.16B, z = V2.16B};
        }
        else
        {
                0.localPosition = new UnityEngine.Vector3() {x = val_41, y = V1.16B, z = V2.16B};
        }
        
        UnityEngine.Vector3 val_42 = val_28.position;
        goto label_83;
        label_78:
        0.localPosition = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
        label_79:
        UnityEngine.Vector3 val_43 = val_28.position;
        label_83:
        UnityEngine.Coroutine val_44 = this.StartCoroutine(methodName:  "CloseIfUnselected");
        UnityEngine.Quaternion val_45 = UnityEngine.Quaternion.identity;
        val_28.localRotation = new UnityEngine.Quaternion() {x = val_45.x, y = val_45.y, z = val_45.z, w = val_45.w};
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.one;
        val_28.localScale = new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z};
        if(this.separatePanel != false)
        {
            
        }
        
        UISprite val_49 = 不丌丂丁丄一与丆丙.世丑丒万不丕丕三丆(丝三丁东丈丒世丅业:  val_18, 不丗丐丘业专丂丝上:  this.atlas, 万丑丞一丝丌丐丒丘:  this.backgroundSprite, 丟丕丞丁丝丂上丄上:  不丌丂丁丄一与丆丙.丒与万丘且丕丙丏丛(丝三丁东丈丒世丅业:  this.mPanel.gameObject));
        this.mBackground = val_49;
        val_49.pivot = 0;
        this.mBackground.color = new UnityEngine.Color() {r = this.backgroundColor, g = val_46.y, b = val_46.z, a = val_45.z};
        this.mBgBorder = val_46.y;
        val_41 = 0;
        this.mBackground.cachedTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UISprite val_53 = 不丌丂丁丄一与丆丙.世丑丒万不丕丕三丆(丝三丁东丈丒世丅业:  val_18, 不丗丐丘业专丂丝上:  this.atlas, 万丑丞一丝丌丐丒丘:  this.highlightSprite, 丟丕丞丁丝丂上丄上:  this.mBackground.depth + 1);
        this.mHighlight = val_53;
        val_53.pivot = 0;
        this.mHighlight.color = new UnityEngine.Color() {r = this.highlightColor, g = val_46.y, b = val_46.z, a = val_45.z};
        if(this.mHighlight.GetAtlasSprite() == null)
        {
                return;
        }
        
        val_146 = val_54.borderTop;
        System.Collections.Generic.List<UILabel> val_57 = new System.Collections.Generic.List<UILabel>();
        if((this.items.Contains(item:  this.mSelectedItem)) != true)
        {
                this.mSelectedItem = 0;
        }
        
        val_148 = (float)this.丐且丒丅不不丙丞丐();
        float val_59 = this.丈万丒丈下丌三丄七() * val_148;
        val_149 = -val_46.y;
        int val_60 = this.items.Count;
        val_150 = 0f;
        if(0 >= val_60)
        {
            goto label_114;
        }
        
        label_147:
        string val_61 = this.items.Item[0];
        UILabel val_64 = 不丌丂丁丄一与丆丙.丞丝业一丟世丒上且<UILabel>(丝三丁东丈丒世丅业:  val_18, 丟丕丞丁丝丂上丄上:  this.mBackground.depth + 2);
        string val_65 = 0.ToString();
        if(val_64 != null)
        {
                val_64.name = val_65;
            val_64.pivot = 0;
            val_64.bitmapFont = this.bitmapFont;
            val_64.trueTypeFont = this.trueTypeFont;
            val_64.fontSize = this.fontSize;
        }
        else
        {
                0.name = val_65;
            val_64.pivot = 0;
            val_64.bitmapFont = this.bitmapFont;
            val_64.trueTypeFont = this.trueTypeFont;
            val_64.fontSize = this.fontSize;
        }
        
        val_64.fontStyle = this.fontStyle;
        if(this.isLocalized == false)
        {
            goto label_123;
        }
        
        if(val_64 != null)
        {
            goto label_129;
        }
        
        label_130:
        label_129:
        val_64.text = 丛丝丝丈丝丞丒业丝.丐下下丅与上东丙丑(下上丐丆丝丟丝丒不:  val_61);
        if(val_64 == null)
        {
            goto label_127;
        }
        
        val_64.color = new UnityEngine.Color() {r = this.textColor, g = val_46.y, b = V15.16B, a = val_148};
        UnityEngine.Transform val_67 = val_64.cachedTransform;
        goto label_128;
        label_123:
        if(val_64 != null)
        {
            goto label_129;
        }
        
        goto label_130;
        label_127:
        val_64.color = new UnityEngine.Color() {r = this.textColor, g = val_46.y, b = V15.16B, a = val_148};
        label_128:
        UnityEngine.Vector2 val_69 = val_64.pivotOffset;
        UnityEngine.Color val_138 = this.backgroundColor;
        val_138 = val_138 + this.padding;
        val_69.x = val_138 - val_69.x;
        val_41 = 0;
        val_64.cachedTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(val_64 != null)
        {
                val_64.overflowMethod = 2;
        }
        else
        {
                val_64.overflowMethod = 2;
        }
        
        val_64.alignment = this.alignment;
        val_57.Add(item:  val_64);
        UnityEngine.Vector2 val_70 = val_64.printedSize;
        val_146 = val_150;
        val_150 = UnityEngine.Mathf.Max(a:  val_146, b:  val_70.x);
        val_73.onHover = new UIEventListener.下丈业丑世丟丘丅下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(UIPopupList).__il2cppRuntimeField_260);
        UIEventListener.下丈业丑世丟丘丅下 val_75 = new UIEventListener.下丈业丑世丟丘丅下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(UIPopupList).__il2cppRuntimeField_270);
        if((UIEventListener.Get(丝三丁东丈丒世丅业:  val_64.gameObject)) != null)
        {
                val_73.onPress = val_75;
        }
        else
        {
                mem[64] = val_75;
        }
        
        val_73.parameter = val_61;
        if((System.String.op_Equality(a:  this.mSelectedItem, b:  val_61)) != false)
        {
            
        }
        else
        {
                if(0 == 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.mSelectedItem)) == true)
        {
            goto label_144;
        }
        
        }
        
        }
        
        label_144:
        val_149 = (val_149 - val_59) - val_148;
        this.mLabelList.Add(item:  val_64);
        if(1 < val_60)
        {
            goto label_147;
        }
        
        label_114:
        float val_139 = val_36.x;
        val_139 = val_36.x - val_139;
        UnityEngine.Color val_140 = this.backgroundColor;
        val_140 = val_140 + this.padding;
        val_140 = val_140 * (-2f);
        val_140 = val_139 + val_140;
        float val_79 = UnityEngine.Mathf.Max(a:  val_150, b:  val_140);
        float val_144 = val_79;
        float val_141 = -0.5f;
        val_79 = val_144 * 0.5f;
        val_141 = val_59 * val_141;
        float val_80 = val_59 + val_79;
        int val_81 = val_57.Count;
        if(val_81 >= 1)
        {
                var val_142 = 0;
            do
        {
            UILabel val_82 = val_57.Item[0];
            不丌丂丁丄一与丆丙.世丞业且三丗丘三丑(丝三丁东丈丒世丅业:  val_82.gameObject);
            if(val_82 != null)
        {
                mem2[0] = 0;
        }
        else
        {
                mem[200] = 0;
        }
        
            UnityEngine.BoxCollider val_84 = val_82.GetComponent<UnityEngine.BoxCollider>();
            if(val_84 != 0)
        {
                UnityEngine.Vector3 val_86 = val_84.center;
            val_84.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_86.z};
            val_84.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        else
        {
                UnityEngine.BoxCollider2D val_87 = val_82.GetComponent<UnityEngine.BoxCollider2D>();
            UnityEngine.Vector2 val_88 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_86.z});
            val_87.offset = new UnityEngine.Vector2() {x = val_88.x, y = val_88.y};
            UnityEngine.Vector2 val_89 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_87.size = new UnityEngine.Vector2() {x = val_89.x, y = val_89.y};
        }
        
            val_142 = val_142 + 1;
        }
        while(val_81 != val_142);
        
        }
        
        UnityEngine.Vector2 val_143 = this.padding;
        val_143 = this.backgroundColor + val_143;
        val_143 = val_143 + val_143;
        val_144 = val_144 + val_143;
        float val_91 = val_149 - val_46.y;
        this.mBackground.width = UnityEngine.Mathf.RoundToInt(f:  val_144);
        this.mBackground.height = UnityEngine.Mathf.RoundToInt(f:  val_46.y - val_91);
        int val_95 = val_57.Count;
        if(val_95 >= 1)
        {
                var val_145 = 0;
            do
        {
            UILabel val_96 = val_57.Item[0];
            if(val_96 != null)
        {
                val_96.overflowMethod = 0;
        }
        else
        {
                val_96.overflowMethod = 0;
        }
        
            val_96.width = UnityEngine.Mathf.RoundToInt(f:  val_144);
            val_145 = val_145 + 1;
        }
        while(val_95 != val_145);
        
        }
        
        float val_97 = this.atlas.pixelSize;
        UnityEngine.Vector2 val_146 = this.padding;
        val_146 = this.backgroundColor + val_146;
        val_153 = 1152921504848912384;
        val_154 = val_28;
        val_97 = val_97 + val_97;
        val_146 = val_146 + val_146;
        val_155 = val_144 - val_146;
        val_156 = val_97 * ((float)val_54 + 40);
        float val_99 = val_97 * (float)val_146;
        val_99 = val_59 + val_99;
        this.mHighlight.width = UnityEngine.Mathf.RoundToInt(f:  val_155 + val_156);
        val_157 = val_99;
        this.mHighlight.height = UnityEngine.Mathf.RoundToInt(f:  val_157);
        var val_102 = (this.position == 1) ? 1 : 0;
        if(this.position == 0)
        {
                UICamera val_104 = UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  this.世丄且专下世七丄丈.layer);
            if(val_104 != 0)
        {
                val_155 = val_43.y;
            val_157 = val_43.x;
            val_156 = val_43.z;
            UnityEngine.Vector3 val_107 = val_104.cachedCamera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_157, y = val_155, z = val_156});
        }
        
        }
        
        if(this.isAnimated == false)
        {
            goto label_197;
        }
        
        if(UnityEngine.Time.timeScale == 0f)
        {
            goto label_196;
        }
        
        val_155 = 0.1f;
        if(UnityEngine.Time.timeScale < val_155)
        {
            goto label_197;
        }
        
        label_196:
        float val_111 = val_59 + val_91;
        int val_112 = val_57.Count;
        if(val_112 >= 1)
        {
                var val_147 = 0;
            do
        {
            UILabel val_113 = val_57.Item[0];
            val_147 = val_147 + 1;
        }
        while(val_112 != val_147);
        
        }
        
        val_153 = 1152921504848912384;
        val_154 = val_28;
        label_197:
        if(((val_107.y < 0) ? 1 : 0) != 0)
        {
                val_159 = val_36.z;
            val_160 = val_36.x;
            val_161 = val_36.y - val_46.y;
            val_162 = val_161 + (float)this.mBackground.height;
            val_163 = this.mBackground.width;
            float val_116 = val_162 - val_46.y;
            val_41 = 0;
            val_164 = 0f;
            val_155 = 0f;
            val_156 = 0f;
            val_154.localPosition = new UnityEngine.Vector3() {x = val_164, y = val_155, z = val_156};
        }
        else
        {
                val_159 = val_36.z;
            val_160 = val_36.x;
            val_164 = val_36.y;
            val_162 = val_164 + val_46.y;
            val_161 = val_162 - (float)this.mBackground.height;
            val_163 = this.mBackground.width;
        }
        
        UnityEngine.Transform val_120 = this.mPanel.cachedTransform.parent;
        val_165 = val_160 + (float)val_163;
        if(val_120 != 0)
        {
                UnityEngine.Vector3 val_123 = this.mPanel.cachedTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_160, y = val_161, z = val_36.z});
            UnityEngine.Vector3 val_125 = this.mPanel.cachedTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_165, y = val_162, z = val_159});
            UnityEngine.Vector3 val_126 = val_120.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_123.x, y = val_123.y, z = val_123.z});
            val_160 = val_126.x;
            val_161 = val_126.y;
            val_164 = val_125.x;
            val_155 = val_125.y;
            val_156 = val_125.z;
            UnityEngine.Vector3 val_127 = val_120.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_164, y = val_155, z = val_156});
            val_165 = val_127.x;
            val_162 = val_127.y;
            val_159 = val_127.z;
        }
        
        if(this.mPanel.hasClipping != false)
        {
                val_166 = 1152921504838316032;
            UnityEngine.Vector3 val_129 = UnityEngine.Vector3.zero;
        }
        else
        {
                val_166 = 1152921504838316032;
            UnityEngine.Vector2 val_130 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_160, y = val_161, z = val_126.z});
            UnityEngine.Vector2 val_131 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_165, y = val_162, z = val_159});
            val_164 = val_130.x;
            val_155 = val_130.y;
            val_156 = val_131.x;
        }
        
        UnityEngine.Vector3 val_132 = val_154.localPosition;
        UnityEngine.Vector3 val_133 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_132.x, y = val_132.y, z = val_132.z}, b:  new UnityEngine.Vector3() {x = val_164, y = val_155, z = val_156});
        if(val_133.x >= 0f)
        {
            goto label_233;
        }
        
        if((double)val_133.x != (-0.5))
        {
            goto label_234;
        }
        
        val_167 = val_41;
        val_168 = -1f;
        goto label_235;
        label_233:
        if((double)val_133.x != 0.5)
        {
            goto label_236;
        }
        
        val_167 = val_41;
        val_168 = 1f;
        label_235:
        val_168 = (float)val_167 + val_168;
        var val_134 = ((0 & (1.401298E-45f)) != 0) ? ((float)val_167) : (val_168);
        goto label_238;
        label_234:
        float val_148 = -0.5f;
        val_148 = val_133.x + val_148;
        goto label_238;
        label_236:
        float val_135 = val_133.x + 0.5f;
        label_238:
        if(val_133.y >= 0f)
        {
            goto label_239;
        }
        
        if((double)val_133.y != (-0.5))
        {
            goto label_240;
        }
        
        val_170 = val_41;
        val_171 = -1f;
        goto label_241;
        label_239:
        if((double)val_133.y != 0.5)
        {
            goto label_242;
        }
        
        val_170 = val_41;
        val_171 = 1f;
        label_241:
        val_171 = (float)val_170 + val_171;
        if(val_154 != 0)
        {
            goto label_247;
        }
        
        label_248:
        label_247:
        val_154.localPosition = new UnityEngine.Vector3() {x = val_133.x, y = ((0 & (1.401298E-45f)) != 0) ? ((float)val_170) : (val_171), z = val_133.z};
        return;
        label_240:
        float val_149 = -0.5f;
        val_149 = val_133.y + val_149;
        if(val_154 != 0)
        {
            goto label_247;
        }
        
        goto label_248;
        label_242:
        float val_137 = val_133.y + 0.5f;
        if(val_154 != 0)
        {
            goto label_247;
        }
        
        goto label_248;
    }
    public UIPopupList()
    {
        this.fontSize = 16;
        this.alignment = 1;
        this.items = new System.Collections.Generic.List<System.String>();
        this.itemData = new System.Collections.Generic.List<System.Object>();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.padding = val_3;
        mem[1152921531116122996] = val_3.y;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.textColor = val_4;
        mem[1152921531116123004] = val_4.g;
        mem[1152921531116123008] = val_4.b;
        mem[1152921531116123012] = val_4.a;
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        this.backgroundColor = val_5;
        mem[1152921531116123020] = val_5.g;
        mem[1152921531116123024] = val_5.b;
        mem[1152921531116123028] = val_5.a;
        this.isAnimated = 1;
        this.separatePanel = 1;
        this.highlightColor = 0;
        mem[1152921531116123036] = 0;
        mem[1152921531116123044] = 0;
        this.onChange = new System.Collections.Generic.List<EventDelegate>();
        this.mLabelList = new System.Collections.Generic.List<UILabel>();
        this.functionName = "OnSelectionChange";
    }
    private static UIPopupList()
    {
    
    }

}
