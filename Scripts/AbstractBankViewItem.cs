using UnityEngine;
internal abstract class AbstractBankViewItem : MonoBehaviour
{
    // Fields
    private static System.Globalization.NumberFormatInfo 丐丛丁丛丄且世丅下;
    private static int 丛丑下丆丁丏丑丟专;
    private static int 丐七丛世世丒且丏三;
    private UnityEngine.Collider 丄丞不上丛七三丆七;
    public UnityEngine.GameObject aDFree;
    public Blinking BlinkingObj;
    public UIButton btnBuy;
    public UIButton btnInfo;
    private float 丐七丐下丙丞不丁东;
    public System.Collections.Generic.List<UnityEngine.Collider> disableIfScrollMoving;
    public UIWidget dragWidget;
    public System.Collections.Generic.List<UILabel> headerLabels;
    public UIBasicSprite icon;
    private float 不世与丅丟万丅上丗;
    private 不东丌丈丞丗丏丝丅 东丈丕丁丝丙丏丄丛;
    private System.Collections.Generic.Dictionary<string, object> 与下丘专丅丞丐专丅;
    private Rilisoft.与丗丌丑专业丝丛丏 丛丈不东丁东丑丞下;
    private Rilisoft.业丙丘丆东丈丕丂丄 万丏东丐丝丁不丕七;
    private PGCompany.丘丒下东丗丏丁丅业 世丁丑七丟丙丒上一;
    private Rilisoft.ButtonHandler 丈与丁丏丕丈不丏丟;
    public UILabel priceLabel;
    public 丘丝丑丐丆丑七不丙 purchaseInfo;
    public UnityEngine.GameObject[] usualElements;
    public UnityEngine.GameObject[] x3Elements;
    private System.EventHandler <丕业与丄丐丝丞丅万>k__BackingField;
    private System.EventHandler <一七丘丝丐丞丄专东>k__BackingField;
    private UIScrollView <丟丈上万丆丈世丌丐>k__BackingField;
    private UIPanel 丏丝丛丕丆专丘丌丌;
    private static string 业丛丐丞万上业丏丒;
    
    // Properties
    protected UnityEngine.Collider 丄七丞一丑与上丘三 { get; }
    public System.Collections.Generic.Dictionary<string, object> 下专丏丘丄丂业专丂 { get; set; }
    public Rilisoft.业丙丘丆东丈丕丂丄 业丙丘丆东丈丕丂丄 { get; set; }
    public PGCompany.丘丒下东丗丏丁丅业 丘丒下东丗丏丁丅业 { get; set; }
    public 不东丌丈丞丗丏丝丅 万丗丆丌与七三丈上 { get; set; }
    public virtual string 丒丆丕丁丟业上七丅 { set; }
    protected Rilisoft.与丗丌丑专业丝丛丏 丛丁三丝上丈丏丅东 { get; set; }
    protected System.EventHandler 丄东丐上下不丑丈且 { get; set; }
    protected System.EventHandler 丞丏上业丅丄丝不三 { get; set; }
    private Rilisoft.ButtonHandler 三世丂七世丝丒丝丄 { get; }
    protected UIScrollView 上丛不专丂丐丝丛一 { get; set; }
    private static System.Globalization.NumberFormatInfo 下丝上七丛丒丂丝丏 { get; }
    protected UIPanel 七丐丌专万世世丁丐 { get; }
    
    // Methods
    protected UnityEngine.Collider 丛丘万七丏与丐丕丙()
    {
        if(this.丄丞不上丛七三丆七 != 0)
        {
                return (UnityEngine.Collider)this.丄丞不上丛七三丆七;
        }
        
        if(this.btnBuy == 0)
        {
                return (UnityEngine.Collider)this.丄丞不上丛七三丆七;
        }
        
        this.丄丞不上丛七三丆七 = this.btnBuy.GetComponent<UnityEngine.Collider>();
        return (UnityEngine.Collider)this.丄丞不上丛七三丆七;
    }
    public System.Collections.Generic.Dictionary<string, object> get_InappBonusParameters()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.与下丘专丅丞丐专丅;
    }
    protected void 丝丈丛三世与世专一(System.Collections.Generic.Dictionary<string, object> 丙业与丙丗丝不丈东)
    {
        this.与下丘专丅丞丐专丅 = 丙业与丙丗丝不丈东;
    }
    public Rilisoft.业丙丘丆东丈丕丂丄 get_Offer()
    {
        return (Rilisoft.业丙丘丆东丈丕丂丄)this.万丏东丐丝丁不丕七;
    }
    protected void 三七丏丁专丘三丄丂(Rilisoft.业丙丘丆东丈丕丂丄 丙业与丙丗丝不丈东)
    {
        this.万丏东丐丝丁不丕七 = 丙业与丙丗丝不丈东;
    }
    public PGCompany.丘丒下东丗丏丁丅业 get_Product()
    {
        return (PGCompany.丘丒下东丗丏丁丅业)this.世丁丑七丟丙丒上一;
    }
    protected void 丒丐丆不丞七且世丙(PGCompany.丘丒下东丗丏丁丅业 丙业与丙丗丝不丈东)
    {
        this.世丁丑七丟丙丒上一 = 丙业与丙丗丝不丈东;
    }
    public 不东丌丈丞丗丏丝丅 get_ExchangeInfo()
    {
        return (不东丌丈丞丗丏丝丅)this.东丈丕丁丝丙丏丄丛;
    }
    protected void 世丑一丝丞东三丗丆(不东丌丈丞丗丏丝丅 丙业与丙丗丝不丈东)
    {
        this.东丈丕丁丝丙丏丄丛 = 丙业与丙丗丝不丈东;
    }
    public virtual void set_Price(string 丙业与丙丗丝不丈东)
    {
        if(this.priceLabel == 0)
        {
                return;
        }
        
        this.priceLabel.text = (丙业与丙丗丝不丈东 == null) ? "" : 丙业与丙丗丝不丈东;
    }
    protected Rilisoft.与丗丌丑专业丝丛丏 丄丑且丆上丛丁且七()
    {
        return (Rilisoft.与丗丌丑专业丝丛丏)this.丛丈不东丁东丑丞下;
    }
    protected void 业丙万丕且七一丄丟(Rilisoft.与丗丌丑专业丝丛丏 丙业与丙丗丝不丈东)
    {
        this.丛丈不东丁东丑丞下 = 丙业与丙丗丝不丈东;
    }
    protected System.EventHandler 万丗万丆丐三丐丝东()
    {
        return (System.EventHandler)this.<丕业与丄丐丝丞丅万>k__BackingField;
    }
    protected void 世一丕丂且丆丟丑丁(System.EventHandler 丙业与丙丗丝不丈东)
    {
        this.<丕业与丄丐丝丞丅万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected System.EventHandler 丕业万丂世下专丒丈()
    {
        return (System.EventHandler)this.<一七丘丝丐丞丄专东>k__BackingField;
    }
    protected void 专丄丅丌丞丛丁业丄(System.EventHandler 丙业与丙丗丝不丈东)
    {
        this.<一七丘丝丐丞丄专东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private Rilisoft.ButtonHandler 丌业丅丟丙丄东丆丂()
    {
        if(this.丈与丁丏丕丈不丏丟 != 0)
        {
                return (Rilisoft.ButtonHandler)this.丈与丁丏丕丈不丏丟;
        }
        
        if(this.btnBuy == 0)
        {
                return (Rilisoft.ButtonHandler)this.丈与丁丏丕丈不丏丟;
        }
        
        Rilisoft.ButtonHandler val_3 = this.btnBuy.GetComponent<Rilisoft.ButtonHandler>();
        this.丈与丁丏丕丈不丏丟 = val_3;
        if(val_3 != 0)
        {
                return (Rilisoft.ButtonHandler)this.丈与丁丏丕丈不丏丟;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "BankViewItem.PurchaseButtonScript: m_purchaseButtonScript == null", args:  System.Array.Empty<System.Object>());
        return (Rilisoft.ButtonHandler)this.丈与丁丏丕丈不丏丟;
    }
    protected UIScrollView 丂三专丂丂下丙丆丏()
    {
        return (UIScrollView)this.<丟丈上万丆丈世丌丐>k__BackingField;
    }
    protected void 丄丒一丌丒一丗丅丂(UIScrollView 丙业与丙丗丝不丈东)
    {
        this.<丟丈上万丆丈世丌丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private static System.Globalization.NumberFormatInfo 上丗东三下丑丟丗丝()
    {
        System.Globalization.NumberFormatInfo val_4;
        var val_5;
        var val_6;
        System.Globalization.NumberFormatInfo val_7;
        val_5 = null;
        val_5 = null;
        if(AbstractBankViewItem.丐丛丁丛丄且世丅下 == null)
        {
                val_6 = null;
            val_7 = System.Globalization.CultureInfo.InvariantCulture.Clone();
            val_6 = null;
            if((val_7 != null) && (null != null))
        {
                val_7 = 0;
        }
        
            AbstractBankViewItem.丐丛丁丛丄且世丅下 = val_7;
            val_4 = AbstractBankViewItem.丐丛丁丛丄且世丅下;
            val_4.NumberGroupSeparator = " ";
            val_5 = null;
        }
        
        val_5 = null;
        return (System.Globalization.NumberFormatInfo)AbstractBankViewItem.丐丛丁丛丄且世丅下;
    }
    protected UIPanel 不丘丁专丙丈万丌丑()
    {
        UIPanel val_4;
        if(this.丏丝丛丕丆专丘丌丌 == 0)
        {
                this.丏丝丛丕丆专丘丌丌 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject);
            return val_4;
        }
        
        val_4 = this.丏丝丛丕丆专丘丌丌;
        return val_4;
    }
    public virtual void UpdateUi()
    {
    
    }
    public virtual void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丛与世且丑丅丟下丛)
    {
        this.<丟丈上万丆丈世丌丐>k__BackingField = this.GetComponentInParent<UIScrollView>();
        this.purchaseInfo = 上业一丄三与丂丄丏;
        this.东丈丕丁丝丙丏丄丛 = 丆不丁且丙丅丂专丟;
        this.与下丘专丅丞丐专丅 = 七一丂丟东丟万丙丘;
        this.万丏东丐丝丁不丕七 = 丙业丞丑七丗下丟丌;
        this.世丁丑七丟丙丒上一 = 丕东不丐世丕丐万上;
        this.东万万下丁一丄丈丗();
        this.<丕业与丄丐丝丞丅万>k__BackingField = 丄丆丘丏万三丞丐丏;
        this.<一七丘丝丐丞丄专东>k__BackingField = 丛与世且丑丅丟下丛;
        this.丌丐丙丑世三一丟且();
    }
    public void Blink(int 丂丘丘丒下丄丞业丝, System.Action 丏丅丁七与丝万东七)
    {
        Blinking val_6;
        float val_7;
        AbstractBankViewItem.丂丒丝上丐丟丄下世 val_1 = new AbstractBankViewItem.丂丒丝上丐丟丄下世();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丏丅丁七与丝万东七 = 丏丅丁七与丝万东七;
        if(this.BlinkingObj == 0)
        {
                if((AbstractBankViewItem.丂丒丝上丐丟丄下世)[1152921537928267584].丏丅丁七与丝万东七 == null)
        {
                return;
        }
        
            (AbstractBankViewItem.丂丒丝上丐丟丄下世)[1152921537928267584].丏丅丁七与丝万东七.Invoke();
            return;
        }
        
        val_6 = this.BlinkingObj;
        if(val_6 != null)
        {
                val_7 = this.BlinkingObj.halfCycle;
        }
        else
        {
                val_7 = this.BlinkingObj.halfCycle;
            if(this.BlinkingObj != null)
        {
                val_6 = this.BlinkingObj;
        }
        else
        {
                val_6 = 0;
        }
        
        }
        
        val_6.gameObject.SetActive(value:  true);
        float val_6 = (float)丂丘丘丒下丄丞业丝;
        val_6 = val_7 * val_6;
        UnityEngine.Coroutine val_5 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  val_6, 丌专业且丛丏丞丝且:  new System.Action(object:  val_1, method:  System.Void AbstractBankViewItem.丂丒丝上丐丟丄下世::上不丑丁丐丄丁丝丗()));
    }
    protected virtual bool 丌下丟一不丕专丟专()
    {
        return false;
    }
    protected static bool 七丙丏丐万业丈丄且()
    {
        string val_8;
        long val_9;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  "Last Payment Time", defaultValue:  System.String.alignConst);
        val_8 = val_1;
        if(((System.String.IsNullOrEmpty(value:  val_1)) != true) && ((System.DateTime.TryParse(s:  val_8, result: out  new System.DateTime())) != false))
        {
                System.DateTime val_4 = System.DateTime.UtcNow;
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_4.dateData}, d2:  new System.DateTime());
            val_8 = val_5._ticks;
            System.TimeSpan val_6 = System.TimeSpan.FromDays(value:  14);
            val_9 = val_8;
            bool val_7 = System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_9}, t2:  new System.TimeSpan() {_ticks = val_6._ticks});
        }
        else
        {
                val_9 = 0;
        }
        
        val_9 = val_9 & 1;
        return (bool)val_9;
    }
    protected virtual void Awake()
    {
        this.丛丝丑不丄万一不丗(丝上世丏丅业丅丏丂:  false);
    }
    protected abstract void OnEnable(); // 0
    protected abstract void OnDisable(); // 0
    protected virtual void Update()
    {
        var val_13;
        float val_23;
        float val_24;
        var val_25;
        this.丛丝丑不丄万一不丗(丝上世丏丅业丅丏丂:  true);
        if((this.<丟丈上万丆丈世丌丐>k__BackingField) == 0)
        {
                return;
        }
        
        if((this.<丟丈上万丆丈世丌丐>k__BackingField.isDragging) != false)
        {
                UnityEngine.Vector2 val_3 = UICamera.lastEventPosition;
            val_23 = val_3.x;
            val_3.x = val_23 - this.不世与丅丟万丅上丗;
            val_24 = System.Math.Abs(val_3.x);
            this.丐七丐下丙丞不丁东 = val_24;
        }
        
        if((this.<丟丈上万丆丈世丌丐>k__BackingField.isDragging) != false)
        {
                UnityEngine.Vector2 val_5 = UICamera.lastEventPosition;
            val_23 = val_5.x;
            val_5.x = val_23 - this.不世与丅丟万丅上丗;
            val_24 = System.Math.Abs(val_5.x);
            var val_6 = (val_24 > 5f) ? 1 : 0;
        }
        else
        {
                val_25 = 0;
        }
        
        if(this.丛丘万七丏与丐丕丙() != 0)
        {
                this.丛丘万七丏与丐丕丙().enabled = (val_25 == 0) ? 1 : 0;
        }
        
        if(this.disableIfScrollMoving == null)
        {
            goto label_28;
        }
        
        List.Enumerator<T> val_11 = this.disableIfScrollMoving.GetEnumerator();
        label_24:
        if(((-1037807376) & 1) == 0)
        {
            goto label_22;
        }
        
        val_13.丐丏七丌丕丗业且上().enabled = (val_25 == 0) ? 1 : 0;
        goto label_24;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_28:
        if((((this.<丟丈上万丆丈世丌丐>k__BackingField.isDragging) != false) && (this.btnBuy != 0)) && (this.btnBuy.enabled != false))
        {
                if(this.btnBuy.state != 2)
        {
                if(this.btnBuy.state != 1)
        {
            goto label_39;
        }
        
        }
        
            this.btnBuy.state = 0;
        }
        
        label_39:
        UnityEngine.Vector2 val_21 = UICamera.lastEventPosition;
        this.不世与丅丟万丅上丗 = val_21.x;
    }
    protected virtual void OnDestroy()
    {
        this.东万万下丁一丄丈丗();
    }
    protected bool 丌丕一丞丞且世专丞()
    {
        if(this.purchaseInfo == null)
        {
                return (bool)(this.purchaseInfo.丌业业业丞丆与丐丆() > 0) ? 1 : 0;
        }
        
        return (bool)(this.purchaseInfo.丌业业业丞丆与丐丆() > 0) ? 1 : 0;
    }
    protected abstract void 丞业与下丛万丁下丙(); // 0
    protected void 丌丐丙丑世三一丟且()
    {
        if(this.丌业丅丟丙丄东丆丂() == 0)
        {
                return;
        }
        
        if((this.<丕业与丄丐丝丞丅万>k__BackingField) == null)
        {
                return;
        }
        
        this = this.<丕业与丄丐丝丞丅万>k__BackingField;
        this.丌业丅丟丙丄东丆丂().add_Clicked(丙业与丙丗丝不丈东:  this);
    }
    protected void 东万万下丁一丄丈丗()
    {
        if(this.丌业丅丟丙丄东丆丂() == 0)
        {
                return;
        }
        
        if((this.<丕业与丄丐丝丞丅万>k__BackingField) == null)
        {
                return;
        }
        
        this.丌业丅丟丙丄东丆丂().remove_Clicked(丙业与丙丗丝不丈东:  this.<丕业与丄丐丝丞丅万>k__BackingField);
        this.<丕业与丄丐丝丞丅万>k__BackingField = 0;
    }
    public void U_OnBtnInfoClicked()
    {
        var val_1;
        if((this.<一七丘丝丐丞丄专东>k__BackingField) == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        this.<一七丘丝丐丞丄专东>k__BackingField.Invoke(sender:  this, e:  System.EventArgs.Empty);
    }
    internal static bool 丄与丄世丂下丂丂七()
    {
        bool val_2 = AbstractBankViewItem.七丅万丞且丒三东与(丁丂丕与丁丒丕丟丞: out  0);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    private void 丛丝丑不丄万一不丗(bool 丝上世丏丅业丅丏丂)
    {
        UnityEngine.GameObject val_10;
        UIScrollView val_11;
        val_10 = 丝上世丏丅业丅丏丂;
        string val_4 = 0;
        if((this.<丟丈上万丆丈世丌丐>k__BackingField) != 0)
        {
                val_11 = this.<丟丈上万丆丈世丌丐>k__BackingField;
            if(val_11.isDragging == true)
        {
                return;
        }
        
        }
        
        val_11 = this.aDFree;
        if(val_11 == 0)
        {
                return;
        }
        
        if((this & 1) != 0)
        {
                val_10 = this.aDFree;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        val_11 = AbstractBankViewItem.七丅万丞且丒三东与(丁丂丕与丁丒丕丟丞: out  val_4);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.aDFree, 丏业丟一东丂东丘丛:  (~val_11) & 1);
        if((val_11 & (~val_10)) == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        val_10 = "[AbstractBankView.UpdateAdFree] " + val_4;
        UnityEngine.Debug.Log(message:  val_10);
    }
    internal static string 上世业丒上丁三下万(int 下下丏一丙不丘丌丞)
    {
        int val_5;
        System.IFormatProvider val_6;
        val_5 = 下下丏一丙不丘丌丞;
        if(val_5 <= 999)
        {
                return (string)val_5.ToString();
        }
        
        val_6 = AbstractBankViewItem.上丗东三下丑丟丗丝();
        val_5 = "#,0";
        if(val_6 == null)
        {
                val_6 = System.Globalization.CultureInfo.InvariantCulture;
        }
        
        string val_3 = val_5.ToString(format:  val_5, provider:  val_6);
        return (string)val_5.ToString();
    }
    private static bool 丌丁丌丕丑下丞专丞(out string 丁丂丕与丁丒丕丟丞)
    {
        string val_15;
        var val_16;
        var val_17;
        PGCompany.DataObjects.万丞丘丏丆丆丝与与 val_2 = 0;
        上丒上丛业丕东世七 val_4 = 0;
        string val_3 = 0;
        万丞丘丏丆丆丝与与.一专丕丆东丝上丐丞 val_10 = 0;
        if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().下丅专丘且丘一丛七(上世丏丁世丟世丆业: out  val_2, 七丆丒与丗丌丄且丂: out  val_3, 丟丐丗万丅下丗丝万: out  val_4, 丏丞专丏业丗丝七丝: out  string val_5 = 丁丂丕与丁丒丕丟丞)) == false)
        {
            goto label_4;
        }
        
        if((PGCompany.DataObjects.丏下与丝一专丞七丌.丐丅且丗东丘上与丏(丟丐丗万丅下丗丝万:  val_4)) == false)
        {
            goto label_5;
        }
        
        val_15 = UnityEngine.SystemInfo.deviceModel;
        if((PGCompany.DataObjects.丏下与丝一专丞七丌.丑丄丙一丑丅专丅上(丟丐丗万丅下丗丝万:  val_4, 下一丆丏丝丄东三三:  val_15)) == false)
        {
            goto label_6;
        }
        
        goto label_9;
        label_4:
        val_16 = 1;
        return (bool)val_16;
        label_5:
        label_35:
        val_15 = "IsEnabled: false";
        label_9:
        val_16 = 1;
        label_32:
        丁丂丕与丁丒丕丟丞 = val_15;
        return (bool)val_16;
        label_6:
        if(((PGCompany.DataObjects.三丛丂丟与不专丛丏.丝东丈专丞丛丑万丗(上世丏丁世丟世丆业:  val_2, 七丆丒与丗丌丄且丂:  val_3, 丅专与丒丈丗丒丘丌:  "ReturnInConnectScene", 丌东丙丝丂一丅三丞: out  val_10)) == false) || ((PGCompany.DataObjects.丄丂七下东丝东丛上.丐丅且丗东丘上与丏(丌东丙丝丂一丅三丞:  val_10)) == false))
        {
            goto label_35;
        }
        
        val_17 = null;
        val_17 = null;
        if(ExperienceController.sharedController != 0)
        {
            goto label_19;
        }
        
        goto label_35;
        label_19:
        if(ExperienceController.丞丞丘业东丙丏七丌() <= 7)
        {
            goto label_35;
        }
        
        goto label_32;
    }
    private static bool 七丅万丞且丒三东与(out string 丁丂丕与丁丒丕丟丞)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        if((AbstractBankViewItem.丐七丛世世丒且丏三 & 2147483648) != 0)
        {
            goto label_3;
        }
        
        val_7 = null;
        val_7 = null;
        int val_6 = AbstractBankViewItem.丐七丛世世丒且丏三;
        val_6 = UnityEngine.Time.frameCount - val_6;
        if(val_6 < 15)
        {
            goto label_6;
        }
        
        label_3:
        val_6 = null;
        bool val_3 = AbstractBankViewItem.丌丁丌丕丑下丞专丞(丁丂丕与丁丒丕丟丞: out  1152921505210044432);
        val_8 = null;
        AbstractBankViewItem.丐七丛世世丒且丏三 = UnityEngine.Time.frameCount;
        label_6:
        val_8 = null;
        丁丂丕与丁丒丕丟丞 = AbstractBankViewItem.业丛丐丞万上业丏丒;
        return (bool)(AbstractBankViewItem.业丛丐丞万上业丏丒 != null) ? 1 : 0;
    }
    protected AbstractBankViewItem()
    {
    
    }
    private static AbstractBankViewItem()
    {
        AbstractBankViewItem.丐七丛世世丒且丏三 = 0;
    }
    internal static bool 上丈丕丛丈万一丅丕(string 东丒丝不上丛丒丌丄, out string 丄丙下丝丛丒七丂丘)
    {
        丄丙下丝丛丒七丂丘 = 东丒丝不上丛丒丌丄;
        return true;
    }

}
