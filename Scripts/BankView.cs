using UnityEngine;
internal class BankView : AbstractBankView
{
    // Fields
    private UnityEngine.GameObject btnTabContainer;
    private AbstractBankViewItem goldItemPrefab;
    private AbstractBankViewItem gemsItemPrefab;
    private AbstractBankViewItem vipItemPrefab;
    private AbstractBankViewItem inappBonusItemPrefab;
    private AbstractBankViewItem lobbyItemPrefab;
    private AbstractBankViewItem constructablePrefab;
    private AbstractBankViewItem eventStoreItemPrefab;
    private AbstractBankViewItem eventStoreSkinItemPrefab;
    private AbstractBankViewItem modulesItemPrefab;
    private AbstractBankViewItem modulesOfferItemPrefab;
    private AbstractBankViewItem clanItemPrefab;
    private AbstractBankViewItem subscribeItemPrefab;
    private UnityEngine.GameObject noOffersIndicator;
    private UnityEngine.GameObject _x3TimerContainer;
    private UnityEngine.GameObject _eventstoreContainer;
    private UILabel _eventstoreTimeLeftLabel;
    private UnityEngine.Transform _eventStoreCustomGuiHandler;
    private Rilisoft.BankShopViewGuiElement _shopGui;
    private UnityEngine.GameObject _clanCurrencyPanel;
    private WidgetLayout _tabsLayout;
    private bool 下丏上上东丗丆丙丞;
    private System.Collections.Generic.List<BankView.BankViewStateSettings> _states;
    private bool 不世丅上世东七丏丆;
    private bool 丂上丗且上丝丝且丅;
    private bool 丕专丏七三东丏丐丝;
    private bool 丛三专丂丏丈专专且;
    internal static string 丗一专业丘丙丟丄万;
    private bool 下且丏丈上丌东世丆;
    private readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<AbstractBankViewItem>> 丑丙不与上丌丗丙丅;
    private int 丕丈丆丑丈丌与丆七;
    private readonly System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule> 丅丂东与与丗丙丅丙;
    private string 丅专丆三丈丘丈上丞;
    private string 且丞上丆专万丟七东;
    private UnityEngine.GameObject 丘万丑下丘丁万丅丁;
    
    // Properties
    public override bool 世丌且丟丗丆三与不 { get; set; }
    private bool 与丘丙丅一专且不且 { get; set; }
    
    // Methods
    public override bool get_AreBankContentsEnabled()
    {
        return (bool)this.丂上丗且上丝丝且丅;
    }
    public override void set_AreBankContentsEnabled(bool 丙业与丙丗丝不丈东)
    {
        UnityEngine.GameObject val_42;
        UnityEngine.GameObject val_43;
        BankViewTab val_44;
        bool val_1 = 丙业与丙丗丝不丈东;
        this.丂上丗且上丝丝且丅 = val_1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.btnTabContainer, 丏业丟一东丂东丘丛:  val_1);
        if(丙业与丙丗丝不丈东 != false)
        {
                if(this.丂上丗且上丝丝且丅 == true)
        {
                return;
        }
        
            UIButton val_40 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  1);
            val_42 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  6);
            UIButton val_6 = val_40 ^ 1;
            UIButton val_7 = (this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  2)) ^ 1;
            UIButton val_8 = (this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  3)) ^ 1;
            UIButton val_10 = val_6 | val_7;
            val_43 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  8);
            val_40 = ((val_10 | val_8) != 1) ? ((val_10 != 1) ? ((val_40 != 1) ? (1 + 1) : 1) : 3) : (((val_42 & 1) != 0) ? 6 : (0 + 1));
            UIScrollView val_15 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  2);
            if(val_15 != null)
        {
                val_42 = val_15.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_42, 丏业丟一东丂东丘丛:  val_7 & 1);
        }
        
            UIScrollView val_18 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  1);
            if(val_18 != null)
        {
                val_42 = val_18.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_42, 丏业丟一东丂东丘丛:  val_6 & 1);
        }
        
            UIScrollView val_21 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  3);
            if(val_21 != null)
        {
                val_42 = val_21.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_42, 丏业丟一东丂东丘丛:  val_8 & 1);
        }
        
            UIScrollView val_24 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  6);
            if(val_24 != null)
        {
                val_42 = val_42 ^ 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24.gameObject, 丏业丟一东丂东丘丛:  val_42 & 1);
        }
        
            val_44 = 8;
            UIScrollView val_27 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  val_44);
            if(val_27 != null)
        {
                val_43 = val_27.gameObject;
            val_44 = val_43 ^ 1 & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43, 丏业丟一东丂东丘丛:  val_44);
        }
        
            this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  val_40);
            return;
        }
        
        UIScrollView val_30 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  2);
        if(val_30 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        UIScrollView val_32 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  1);
        if(val_32 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        UIScrollView val_34 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  3);
        if(val_34 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_34.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        UIScrollView val_36 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  6);
        if(val_36 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        UIScrollView val_38 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  8);
        if(val_38 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_38.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private bool 东丕丈丗丛与丑且下()
    {
        return (bool)this.丛三专丂丏丈专专且;
    }
    private void 下七丘三丏丐七丄专(bool 丙业与丙丗丝不丈东)
    {
        this.丛三专丂丏丈专专且 = 丙业与丙丗丝不丈东;
        UIButton val_2 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  5);
        if(this.丛三专丂丏丈专专且 == false)
        {
            goto label_1;
        }
        
        bool val_4 = BankController.丑七不且上丗丁一世().丁且上丘业且七丌专(丐丅丒专丛丏上与业:  5);
        if(val_2 != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2.gameObject, 丏业丟一东丂东丘丛:  val_4);
        this._tabsLayout.Reposition();
        if(val_4 == true)
        {
                return;
        }
        
        if(this.GetEnabledTab() != 5)
        {
                return;
        }
        
        this.GoToTab(丐丅丒专丛丏上与业:  (BalanceController.丁与丂丛专丂丑三且() != true) ? 4 : (0 + 1), 七业业世丅一丁不丛:  0);
        this.丙丕丕下丅丐丙丅丕();
        return;
        label_1:
        if(val_2 != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    protected override void Update()
    {
        this.Update();
    }
    private UIButton 丕丂丌下丘丑丝丆丆(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        UIButton val_4;
        .丐丅丒专丛丏上与业 = 丐丅丒专丛丏上与业;
        if((System.Linq.Enumerable.FirstOrDefault<BankViewStateSettings>(source:  this._states, predicate:  new System.Func<BankViewStateSettings, System.Boolean>(object:  new BankView.且且丛丌丝三丏丙丛(), method:  System.Boolean BankView.且且丛丌丝三丏丙丛::丄丑一丈丟东丄丆丈(BankView.BankViewStateSettings 丏丛与丅丛丌万专丌)))) == null)
        {
                return val_4;
        }
        
        val_4 = val_3.button;
        return val_4;
    }
    protected UIScrollView 丂专下三一上丙丞东(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        UIScrollView val_4;
        .丐丅丒专丛丏上与业 = 丐丅丒专丛丏上与业;
        if((System.Linq.Enumerable.FirstOrDefault<BankViewStateSettings>(source:  this._states, predicate:  new System.Func<BankViewStateSettings, System.Boolean>(object:  new BankView.丟丑不七不丆业丐丛(), method:  System.Boolean BankView.丟丑不七不丆业丐丛::下上万丕且丘丞东三(BankView.BankViewStateSettings 丏丛与丅丛丌万专丌)))) == null)
        {
                return val_4;
        }
        
        val_4 = val_3.scroll;
        return val_4;
    }
    protected UIGrid 丒三丆下业丁业丗万(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        UIGrid val_4;
        .丐丅丒专丛丏上与业 = 丐丅丒专丛丏上与业;
        if((System.Linq.Enumerable.FirstOrDefault<BankViewStateSettings>(source:  this._states, predicate:  new System.Func<BankViewStateSettings, System.Boolean>(object:  new BankView.与丙丌丟一七下丏与(), method:  System.Boolean BankView.与丙丌丟一七下丏与::丌专七丄丗丏东丁丏(BankView.BankViewStateSettings 丏丛与丅丛丌万专丌)))) == null)
        {
                return val_4;
        }
        
        val_4 = val_3.grid;
        return val_4;
    }
    internal static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 丅世丌丏丈不丙且丟(丘丝丑丐丆丑七不丙.一丅丌丁丙丈丙上丙 万丐丝一万专上且丝)
    {
        if(万丐丝一万专上且丝 == 1)
        {
                return AbstractBankView.丘丅丕丂丗丞上一丐();
        }
        
        if(万丐丝一万专上且丝 == 0)
        {
                return AbstractBankView.万丏丝与专下丂丐丏();
        }
        
        if(万丐丝一万专上且丝 != 4)
        {
                return AbstractBankView.丒丁丞丝世三与七东();
        }
        
        return AbstractBankView.丌一业与七丘丒东丕();
    }
    protected static System.Collections.Generic.IList<丘丝丑丐丆丑七不丙> 世丞一丐万丄不丄丂(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        System.Collections.Generic.IEnumerable<TSource> val_5;
        var val_6;
        System.Func<丘丝丑丐丆丑七不丙, System.Boolean> val_8;
        var val_9;
        val_5 = 丐丅丒专丛丏上与业;
        if(val_5 == 3)
        {
            goto label_1;
        }
        
        if(val_5 == 2)
        {
                return AbstractBankView.万丏丝与专下丂丐丏();
        }
        
        if(val_5 != 1)
        {
            goto label_3;
        }
        
        return AbstractBankView.丘丅丕丂丗丞上一丐();
        label_1:
        val_5 = AbstractBankView.丌一业与七丘丒东丕();
        val_6 = null;
        val_6 = null;
        val_8 = BankView.<>c.<>9__40_0;
        if(val_8 == null)
        {
                System.Func<丘丝丑丐丆丑七不丙, System.Boolean> val_2 = null;
            val_8 = val_2;
            val_2 = new System.Func<丘丝丑丐丆丑七不丙, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丏丂七七丌丌丐丏丏(丘丝丑丐丆丑七不丙 东一丁世丑丞业丄丐));
            BankView.<>c.<>9__40_0 = val_8;
        }
        
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<丘丝丑丐丆丑七不丙>(source:  System.Linq.Enumerable.Where<丘丝丑丐丆丑七不丙>(source:  val_5, predicate:  val_2));
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_9;
        label_3:
        val_9 = 0;
        return (System.Collections.Generic.IList<丘丝丑丐丆丑七不丙>)val_9;
    }
    protected AbstractBankViewItem 丘丄丝且丝业专七丄(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        var val_2 = 0;
        if((丐丅丒专丛丏上与业 - 1) > 7)
        {
                return (AbstractBankViewItem);
        }
        
        var val_2 = 106029392 + ((丐丅丒专丛丏上与业 - 1)) << 2;
        val_2 = val_2 + 106029392;
        goto (106029392 + ((丐丅丒专丛丏上与业 - 1)) << 2 + 106029392);
    }
    public override void StopScrolling()
    {
        UIScrollView val_1 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  1);
        if(val_1 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_1.currentMomentum = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    protected override void OnEnable()
    {
        var val_36;
        var val_37;
        BankViewTab val_38;
        var val_39;
        string val_40;
        this.下且丏丈上丌东世丆 = false;
        if(this.DesiredCurrency == null)
        {
            goto label_1;
        }
        
        val_36 = null;
        val_36 = null;
        if((System.String.op_Equality(a:  this.DesiredCurrency, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == true)
        {
            goto label_17;
        }
        
        val_37 = null;
        val_37 = null;
        if((System.String.op_Equality(a:  this.DesiredCurrency, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_7;
        }
        
        val_38 = 2;
        goto label_63;
        label_1:
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_6 = BalanceController.下丂万丐丄丅七一东();
        if((val_6 == null) || (val_6.Count <= 0))
        {
            goto label_12;
        }
        
        val_38 = 4;
        goto label_63;
        label_12:
        if((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40)) == false)
        {
            goto label_17;
        }
        
        val_38 = 5;
        Rilisoft.一丟专且三万丞丁丂.一丞三丟丘专业丁东(丐业丝业万丞与一一:  "Bank");
        goto label_63;
        label_17:
        val_38 = 1;
        label_63:
        this.DesiredCurrency = 0;
        if(this.下丏上上东丗丆丙丞 != false)
        {
                this.下丏上上东丗丆丙丞 = false;
        }
        else
        {
                val_39 = null;
            val_39 = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丙丑丟丆丑世丁专丅(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  1, 丐丅丒专丛丏上与业:  "other", 世丁丙世丄一万丆三:  BankView.丗一专业丘丙丟丄万);
        }
        
        val_40 = BankController.丑七不且上丗丁一世();
        this.ChangeTab(丂丄丞丌丗东业丛业:  this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  ((val_40.丁且上丘业且七丌专(丐丅丒专丛丏上与业:  val_38)) != true) ? (val_38) : (0 + 1)), 七业业世丅一丁不丛:  0);
        if(val_38 != 0)
        {
                val_40 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            val_38.text = val_40;
        }
        
        this.OnEnable();
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        return;
        label_7:
        if((System.String.op_Equality(a:  this.DesiredCurrency, b:  "offers")) == false)
        {
            goto label_38;
        }
        
        var val_22 = (BalanceController.丁与丂丛专丂丑三且() != true) ? 4 : (0 + 1);
        goto label_63;
        label_38:
        if(((System.String.op_Equality(a:  this.DesiredCurrency, b:  "VipOffer")) == false) || (Rilisoft.VIPController.丌丏丄专丘丕丑上且() == false))
        {
            goto label_45;
        }
        
        goto label_63;
        label_45:
        if((System.String.op_Equality(a:  this.DesiredCurrency, b:  "EventStore")) == false)
        {
            goto label_47;
        }
        
        goto label_63;
        label_47:
        if((System.String.op_Equality(a:  this.DesiredCurrency, b:  "CraftCurrency")) == false)
        {
            goto label_49;
        }
        
        goto label_63;
        label_49:
        if((System.String.op_Equality(a:  this.DesiredCurrency, b:  "ClanSilver")) == true)
        {
            goto label_63;
        }
        
        var val_34 = ((System.String.op_Equality(a:  this.DesiredCurrency, b:  "ClanLootBoxPoints")) != true) ? 8 : (0 + 1);
        goto label_63;
    }
    private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BankView.丏丝丛丁丅丒丒与专();
    }
    private void 上东丆丛丗丁丌丟专()
    {
        long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丕丙丅丆且丒丝不丐(丅丝丗丕专丌丛丄丅:  40);
        if((((this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  5)) & 1) != 0) || (FriendsController.丝丗专上三不丄丑丑() < 1))
        {
            goto label_8;
        }
        
        if(val_2 < 1)
        {
            goto label_25;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventstoreContainer, 丏业丟一东丂东丘丛:  true);
        System.TimeSpan val_8 = System.TimeSpan.FromSeconds(value:  (double)val_2 - FriendsController.丝丗专上三不丄丑丑());
        this._eventstoreTimeLeftLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6249"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_8._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
        return;
        label_8:
        label_25:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventstoreContainer, 丏业丟一东丂东丘丛:  false);
    }
    protected override void Start()
    {
        UIScrollView val_1 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  2);
        if(val_1 != null)
        {
                UIPanel val_2 = val_1.GetComponent<UIPanel>();
            if(val_2 != null)
        {
                val_2.UpdateAnchors();
        }
        
        }
        
        UIScrollView val_3 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  1);
        if(val_3 != null)
        {
                UIPanel val_4 = val_3.GetComponent<UIPanel>();
            if(val_4 != null)
        {
                val_4.UpdateAnchors();
        }
        
        }
        
        UIScrollView val_5 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  3);
        if(val_5 != null)
        {
                UIPanel val_6 = val_5.GetComponent<UIPanel>();
            if(val_6 != null)
        {
                val_6.UpdateAnchors();
        }
        
        }
        
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  1);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  2);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  3);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  4);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  5);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  6);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  8);
        this.Start();
    }
    private void 东丞丕丄丆丈与业丌(BankView.BankViewTab 丐丅丒专丛丏上与业, bool 丆丄丘丂业丛七丁且)
    {
        UIGrid val_1 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
        if(val_1 != 0)
        {
            goto label_12;
        }
        
        return;
        label_18:
        UnityEngine.Transform val_4 = val_1.transform.GetChild(index:  0);
        val_4.gameObject.SetActive(value:  false);
        val_4.parent = val_1.transform.parent;
        if(丆丄丘丂业丛七丁且 != false)
        {
                UnityEngine.Object.Destroy(obj:  val_4.gameObject);
        }
        
        label_12:
        this = val_1.transform;
        if(this.childCount > 0)
        {
            goto label_18;
        }
    
    }
    internal bool 丏万丘丙丐七丒丄丕(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        BankViewTab val_7;
        var val_8;
        val_7 = 丐丅丒专丛丏上与业;
        if((BankController.丑七不且上丗丁一世().丁且上丘业且七丌专(丐丅丒专丛丏上与业:  val_7)) == false)
        {
            goto label_13;
        }
        
        if(val_7 == 7)
        {
            goto label_5;
        }
        
        if(val_7 == 6)
        {
            goto label_6;
        }
        
        if(val_7 != 5)
        {
                return (bool)val_8;
        }
        
        var val_3 = (this.丛三专丂丏丈专专且 == true) ? 1 : 0;
        return (bool)val_8;
        label_5:
        BankController val_4 = BankController.丑七不且上丗丁一世();
        if(val_4 != null)
        {
                return val_4.专丒丙丑丗七一世世();
        }
        
        return val_4.专丒丙丑丗七一世世();
        label_6:
        val_7 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
        if(val_7.与丁上丌丝丟丑一丏() != false)
        {
                return 丐东不丅丂丂丅丙不.世丞业下丗上三不万();
        }
        
        label_13:
        val_8 = 0;
        return (bool)val_8;
    }
    private AbstractBankViewItem 丈丆丟不一业三丁丏(AbstractBankViewItem 丄东丛丑与丄丗丂丑, string 丐专丄丒七丒上丐丈 = "")
    {
        var val_11;
        var val_12;
        System.Func<AbstractBankViewItem, System.Boolean> val_14;
        UnityEngine.Object val_15;
        val_11 = this;
        string val_2 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  丄东丛丑与丄丗丂丑)(丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  丄东丛丑与丄丗丂丑)) + "_" + 丐专丄丒七丒上丐丈;
        if((this.丑丙不与上丌丗丙丅.ContainsKey(key:  val_2)) != true)
        {
                this.丑丙不与上丌丗丙丅.set_Item(key:  val_2, value:  new System.Collections.Generic.List<AbstractBankViewItem>());
        }
        
        val_12 = null;
        val_12 = null;
        val_14 = BankView.<>c.<>9__52_0;
        if(val_14 == null)
        {
                System.Func<AbstractBankViewItem, System.Boolean> val_6 = null;
            val_14 = val_6;
            val_6 = new System.Func<AbstractBankViewItem, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::七丂丕丟丗下丗丑万(AbstractBankViewItem 三丟东丕丄丄下下丑));
            BankView.<>c.<>9__52_0 = val_14;
        }
        
        val_15 = System.Linq.Enumerable.FirstOrDefault<AbstractBankViewItem>(source:  this.丑丙不与上丌丗丙丅.Item[val_2], predicate:  val_6);
        if(val_15 != 0)
        {
                return val_15;
        }
        
        val_15 = UnityEngine.Object.Instantiate<AbstractBankViewItem>(original:  丄东丛丑与丄丗丂丑);
        val_11 = this.丑丙不与上丌丗丙丅.Item[val_2];
        val_11.Add(item:  val_15);
        return val_15;
    }
    private void 丐丘丟丒丌丂三丏七(BankView.BankViewTab 丐丅丒专丛丏上与业, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丘万丌丏丂丂丒丁丘)
    {
        var val_179;
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_180;
        BankViewTab val_181;
        UnityEngine.GameObject val_182;
        AbstractBankViewItem val_183;
        string val_185;
        var val_186;
        object val_187;
        float val_188;
        float val_189;
        float val_190;
        float val_191;
        float val_192;
        float val_193;
        var val_196;
        string val_197;
        AbstractBankViewItem val_198;
        Rilisoft.业丙丘丆东丈丕丂丄 val_199;
        var val_201;
        int val_202;
        var val_203;
        var val_205;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32> val_207;
        int val_208;
        var val_209;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_211;
        var val_212;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_214;
        BankView val_215;
        var val_216;
        var val_217;
        var val_218;
        var val_219;
        var val_220;
        var val_222;
        System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean> val_224;
        var val_225;
        var val_227;
        val_180 = 丘万丌丏丂丂丒丁丘;
        val_181 = 丐丅丒专丛丏上与业;
        object val_40 = 0;
        OfferModule val_60 = 0;
        UIGrid val_1 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  val_181);
        val_182 = BankView.世丞一丐万丄不丄丂(丐丅丒专丛丏上与业:  val_181);
        if(val_182 == null)
        {
            goto label_3;
        }
        
        val_183 = 0;
        if((val_181 - 1) > 7)
        {
            goto label_11;
        }
        
        var val_179 = 106029424 + ((丐丅丒专丛丏上与业 - 1)) << 2;
        val_179 = val_179 + 106029424;
        goto (106029424 + ((丐丅丒专丛丏上与业 - 1)) << 2 + 106029424);
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_183.gameObject, 丏业丟一东丂东丘丛:  true);
        val_179 = 1152921504838369280;
        val_185 = 0;
        goto label_15;
        label_39:
        AbstractBankViewItem val_5 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  val_183, 丐专丄丒七丒上丐丈:  "");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        val_186 = 0;
        val_5.transform.SetParent(p:  val_1.transform);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_187 = val_5.transform;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        val_188 = val_13.x;
        val_189 = val_13.z;
        val_190 = val_188;
        val_191 = val_13.y;
        val_192 = val_189;
        val_193 = val_13.w;
        val_187.localRotation = new UnityEngine.Quaternion() {x = val_190, y = val_191, z = val_192, w = val_193};
        var val_180 = 0;
        val_180 = val_180 + 1;
        val_186 = 0;
        T val_15 = val_182.Item[0];
        val_185 = 1;
        label_15:
        var val_181 = 0;
        val_181 = val_181 + 1;
        if(val_185 < val_182.Count)
        {
            goto label_39;
        }
        
        val_181 = val_181;
        val_180 = val_180;
        val_182 = val_183.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_182, 丏业丟一东丂东丘丛:  false);
        label_3:
        if(val_180 == 0)
        {
            goto label_44;
        }
        
        val_196 = 1152921524492151792;
        if(val_180.Count < 1)
        {
            goto label_44;
        }
        
        val_179 = 1152921537962402672;
        object val_20 = (val_181 == 1) ? 1 : 0;
        goto label_211;
        label_164:
        label_80:
        label_189:
        val_179 = 1152921537962402672;
        if((0 | (~(UnityEngine.Object.op_Equality(x:  0, y:  0)))) == true)
        {
            goto label_116;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921537962904560].gameObject, 丏业丟一东丂东丘丛:  true);
        AbstractBankViewItem val_24 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  mem[1152921537962904560], 丐专丄丒七丒上丐丈:  val_185);
        val_185 = val_24;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_24, 丏业丟一东丂东丘丛:  true);
        val_185.transform.SetParent(p:  val_1.transform);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
        val_185.transform.localScale = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
        val_185.transform.localPosition = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
        val_187 = val_185.transform;
        UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.identity;
        val_188 = val_32.x;
        val_189 = val_32.z;
        val_190 = val_188;
        val_191 = val_32.y;
        val_192 = val_189;
        val_193 = val_32.w;
        val_187.localRotation = new UnityEngine.Quaternion() {x = val_190, y = val_191, z = val_192, w = val_193};
        goto label_116;
        label_152:
        val_185 = new object[3];
        val_179 = 1152921537962402672;
        val_185[0] = val_20;
        string val_34 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_183);
        val_185[1] = val_34;
        val_185[2] = val_34;
        val_197 = "PopulateItemGrid inappBonusPurchaseInfo == null isGems = {0} , inappBonusAction = {1}, bonus.InappId = {2}";
        goto label_202;
        label_172:
        if((val_187.三丘丑丒丑丌丑丑丗(丏丕丌丟丑不丙七丙:  true)) == false)
        {
            goto label_80;
        }
        
        val_198 = ;
        if(val_60 <= 79)
        {
            goto label_81;
        }
        
        if(val_60 == 150)
        {
            goto label_82;
        }
        
        if(val_60 == 120)
        {
            goto label_83;
        }
        
        if(val_60 != 80)
        {
            goto label_87;
        }
        
        val_198 = mem[1152921537962904608];
        goto label_90;
        label_81:
        if(val_60 == 60)
        {
            goto label_89;
        }
        
        if(val_60 != 70)
        {
            goto label_87;
        }
        
        goto label_89;
        label_83:
        val_199 = 0;
        val_198 = mem[1152921537962904568];
        goto label_89;
        label_87:
        val_199 = 0;
        goto label_90;
        label_211:
        System.Collections.Generic.Dictionary<System.String, System.Object> val_37 = val_180.Item[0];
        if((val_37.ContainsKey(key:  "Key")) == false)
        {
            goto label_105;
        }
        
        val_185 = val_37.Item["Key"];
        if(val_37 != null)
        {
            goto label_110;
        }
        
        goto label_109;
        label_105:
        val_185 = "";
        if(val_37 != null)
        {
            goto label_110;
        }
        
        label_109:
        label_110:
        if((val_40 == 0) || (((val_37.TryGetValue(key:  "isGems", value: out  val_40)) ^ 1) == true))
        {
            goto label_112;
        }
        
        var val_44 = (val_181 == 4) ? 1 : 0;
        val_44 = val_44 ^ (System.Convert.ToBoolean(value:  val_40));
        if(val_44 == false)
        {
            goto label_115;
        }
        
        goto label_116;
        label_112:
        object[] val_45 = new object[1];
        val_45[0] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_37);
        UnityEngine.Debug.LogErrorFormat(format:  "PopulateItemGrid: no isGems key {0}", args:  val_45);
        label_115:
        val_187 = 一下丛与丛丛万万丏.丑七不且上丗丁一世().三丌丑丏一丏丙一丒(丄上下丟与不丈丏丄:  val_37);
        if(val_187 == null)
        {
            goto label_126;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_48.InappId)) == false)
        {
            goto label_129;
        }
        
        object[] val_50 = new object[2];
        val_185 = val_50;
        if(val_185 == null)
        {
            goto label_130;
        }
        
        if(val_20 == true)
        {
            goto label_131;
        }
        
        goto label_204;
        label_126:
        val_185 = new object[2];
        if(val_185 == null)
        {
            goto label_133;
        }
        
        if(val_20 == true)
        {
            goto label_134;
        }
        
        goto label_141;
        label_129:
        BankView.丞丘世丐丏丟业丕丒 val_52 = new BankView.丞丘世丐丏丟业丕丒();
        val_201 = null;
        val_201 = null;
        val_202 = System.Array.IndexOf<System.String>(array:  StoreKitEventListener.业万专三一丟且丘业, value:  val_48.InappId);
        if(val_52 == null)
        {
            goto label_138;
        }
        
        .丞丘丌与世万丌三丅 = val_202;
        goto label_139;
        label_133:
        if(val_20 == false)
        {
            goto label_141;
        }
        
        label_134:
        label_141:
        val_185[0] = val_20;
        val_185[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_37);
        val_197 = "PopulateItemGrid: bonus == null isGems = {0} , inappBonusAction = {1}";
        goto label_202;
        label_138:
        mem[16] = val_202;
        val_202 = mem[16];
        val_196 = 1152921524492151792;
        label_139:
        if(val_202 == 1)
        {
            goto label_149;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<丘丝丑丐丆丑七不丙>(source:  AbstractBankView.丒丁丞丝世三与七东(), predicate:  new System.Func<丘丝丑丐丆丑七不丙, System.Boolean>(object:  val_52, method:  System.Boolean BankView.丞丘世丐丏丟业丕丒::丛丄丛丂且丑丆专东(丘丝丑丐丆丑七不丙 一丒丆业丅七丛且丏)))) == null)
        {
            goto label_152;
        }
        
        if(((val_37.ContainsKey(key:  "offer-module")) == false) || ((丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<OfferModule>(下业七不丑丂丏丟东:  val_37.Item["offer-module"], 丄三丅七丆丛与与上: out  val_60, 且丛专世丈且一丌下:  false)) == false))
        {
            goto label_164;
        }
        
        if((-60) <= 60)
        {
                if(0 != 0)
        {
            goto label_161;
        }
        
        }
        
        if(val_60 != 150)
        {
            goto label_164;
        }
        
        label_161:
        if((val_37.ContainsKey(key:  "offer-id")) == false)
        {
            goto label_164;
        }
        
        val_199 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丅世业丂丝丁丌七丗(业丒丌东丈丏丈一不:  val_37.Item["offer-id"]);
        if((val_199 == null) || (val_199.一业丟丁上丑丘丕丄() == false))
        {
            goto label_189;
        }
        
        if(val_60 != 150)
        {
            goto label_172;
        }
        
        label_82:
        val_198 = mem[1152921537962904576];
        label_90:
        label_89:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_198.gameObject, 丏业丟一东丂东丘丛:  true);
        AbstractBankViewItem val_68 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  val_198, 丐专丄丒七丒上丐丈:  val_185);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_68, 丏业丟一东丂东丘丛:  true);
        val_68.transform.SetParent(p:  val_1.transform);
        UnityEngine.Vector3 val_72 = UnityEngine.Vector3.one;
        val_68.transform.localScale = new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z};
        UnityEngine.Vector3 val_74 = UnityEngine.Vector3.zero;
        val_68.transform.localPosition = new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z};
        UnityEngine.Quaternion val_76 = UnityEngine.Quaternion.identity;
        val_68.transform.localRotation = new UnityEngine.Quaternion() {x = val_76.x, y = val_76.y, z = val_76.z, w = val_76.w};
        goto label_189;
        label_149:
        val_185 = new object[3];
        val_185[0] = val_20;
        val_185[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_37);
        val_185[2] = val_48.InappId;
        val_197 = "PopulateItemGrid indexOfInappWithBonus == -1, isGems = {0} , inappBonusAction = {1}, bonus.InappId = {2}";
        goto label_202;
        label_130:
        if(val_20 == false)
        {
            goto label_204;
        }
        
        label_131:
        label_204:
        val_185[0] = val_20;
        val_185[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_37);
        val_197 = "PopulateItemGrid: bonus.InappId.IsNullOrEmpty() isGems = {0} , inappBonusAction = {1}";
        label_202:
        UnityEngine.Debug.LogErrorFormat(format:  val_197, args:  val_50);
        label_116:
        val_182 = 0 + 1;
        if(val_182 < val_180.Count)
        {
            goto label_211;
        }
        
        label_44:
        if(val_181 == 8)
        {
            goto label_212;
        }
        
        if(val_181 == 6)
        {
            goto label_213;
        }
        
        if(val_181 != 5)
        {
            goto label_314;
        }
        
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_82 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40);
        if(val_82 == null)
        {
            goto label_314;
        }
        
        val_203 = null;
        val_203 = null;
        val_182 = BankView.<>c.<>9__53_1;
        if(val_182 == null)
        {
                System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_83 = null;
            val_182 = val_83;
            val_83 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丆上丏丞丒下丑万丈(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            BankView.<>c.<>9__53_1 = val_182;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_82, predicate:  val_83)) == false)
        {
            goto label_314;
        }
        
        val_205 = null;
        val_205 = null;
        val_207 = BankView.<>c.<>9__53_2;
        if(val_207 == null)
        {
                System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32> val_85 = null;
            val_207 = val_85;
            val_85 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BankView.<>c::丕下丗七丞不丏丄世(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            BankView.<>c.<>9__53_2 = val_207;
        }
        
        System.Collections.Generic.List<TSource> val_87 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32>(source:  val_82, keySelector:  val_85));
        val_187 = 1152921537962617104;
        val_179 = 1152921537962618128;
        val_208 = val_87.Count - 1;
        goto label_231;
        label_238:
        Rilisoft.业丙丘丆东丈丕丂丄 val_89 = val_87.Item[val_208];
        if(val_89.世一丒专丛丏世丁丙() != false)
        {
                val_185 = val_87.Count;
            丞东丑专丛丆丄丝世.下丏且一三丐一丐不<Rilisoft.业丙丘丆东丈丕丂丄>(丝丘丑业丛万丞丌丝:  val_87, 下丅丙一丂丗丅丝七:  val_89, 丘丒丌下丕专且七专:  val_185 - 1);
        }
        
        val_208 = val_208 - 1;
        label_231:
        if((val_208 & 2147483648) == 0)
        {
            goto label_238;
        }
        
        int val_94 = val_87.Count - 1;
        if((val_94 & 2147483648) != 0)
        {
            goto label_239;
        }
        
        val_188 = 1;
        label_247:
        Rilisoft.业丙丘丆东丈丕丂丄 val_95 = val_87.Item[val_94];
        System.Nullable<System.TimeSpan> val_96 = val_95.丙世丑丅丒丑业与不();
        if(((-1003693232) & 1) != 0)
        {
                if(val_96.HasValue.TotalSeconds >= 0)
        {
            goto label_243;
        }
        
        }
        
        val_185 = val_87.Count;
        丞东丑专丛丆丄丝世.下丏且一三丐一丐不<Rilisoft.业丙丘丆东丈丕丂丄>(丝丘丑业丛万丞丌丝:  val_87, 下丅丙一丂丗丅丝七:  val_95, 丘丒丌下丕专且七专:  val_185 - 1);
        label_243:
        val_94 = val_94 - 1;
        if((val_94 & 2147483648) == 0)
        {
            goto label_247;
        }
        
        label_239:
        val_181 = val_181;
        val_182 = 0;
        goto label_248;
        label_283:
        Rilisoft.业丙丘丆东丈丕丂丄 val_100 = val_87.Item[0];
        if(val_100 == null)
        {
            goto label_250;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_101 = val_100.丏与丅专三丙与丘丒();
        if(val_101.Count > 1)
        {
            goto label_258;
        }
        
        val_209 = null;
        val_209 = null;
        val_211 = BankView.<>c.<>9__53_3;
        if(val_211 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_103 = null;
            val_211 = val_103;
            val_103 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丅与丛丗不丙丛丗与(Rilisoft.OfferItem 丛丅丐丒丈不丅丐丄));
            BankView.<>c.<>9__53_3 = val_211;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_101, predicate:  val_103)) == true)
        {
            goto label_258;
        }
        
        val_212 = null;
        val_212 = null;
        val_214 = BankView.<>c.<>9__53_4;
        if(val_214 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_105 = null;
            val_214 = val_105;
            val_105 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丞丕专丈专丌一丑丏(Rilisoft.OfferItem 丛丅丐丒丈不丅丐丄));
            BankView.<>c.<>9__53_4 = val_214;
        }
        
        val_215 = 1152921537962904584;
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_101, predicate:  val_105)) == false)
        {
            goto label_264;
        }
        
        label_258:
        val_215 = 1152921537962904592;
        label_264:
        val_185 = this.eventStoreSkinItemPrefab;
        val_179 = val_187;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_185.gameObject, 丏业丟一东丂东丘丛:  true);
        AbstractBankViewItem val_109 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  val_185, 丐专丄丒七丒上丐丈:  val_100.业上丙丞丐丄丆丅七());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_109, 丏业丟一东丂东丘丛:  true);
        val_109.transform.SetParent(p:  val_1.transform);
        UnityEngine.Vector3 val_113 = UnityEngine.Vector3.one;
        val_109.transform.localScale = new UnityEngine.Vector3() {x = val_113.x, y = val_113.y, z = val_113.z};
        UnityEngine.Vector3 val_115 = UnityEngine.Vector3.zero;
        val_109.transform.localPosition = new UnityEngine.Vector3() {x = val_115.x, y = val_115.y, z = val_115.z};
        UnityEngine.Quaternion val_117 = UnityEngine.Quaternion.identity;
        val_188 = val_117.x;
        val_189 = val_117.z;
        val_190 = val_188;
        val_191 = val_117.y;
        val_192 = val_189;
        val_193 = val_117.w;
        val_109.transform.localRotation = new UnityEngine.Quaternion() {x = val_190, y = val_191, z = val_192, w = val_193};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_185.gameObject, 丏业丟一东丂东丘丛:  false);
        val_187 = val_179;
        label_250:
        val_182 = 1;
        label_248:
        if(val_182 < val_87.Count)
        {
            goto label_283;
        }
        
        goto label_314;
        label_213:
        val_216 = 丐东不丅丂丂丅丙不.上且丕丝丙不七丄丈();
        if(val_216 == null)
        {
                System.Collections.Generic.List<PGCompany.丘丒下东丗丏丁丅业> val_121 = null;
            val_216 = val_121;
            val_121 = new System.Collections.Generic.List<PGCompany.丘丒下东丗丏丁丅业>();
        }
        
        val_182 = mem[1152921537962904600];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_182.gameObject, 丏业丟一东丂东丘丛:  true);
        val_179 = 1152921504838369280;
        val_217 = 0;
        goto label_291;
        label_310:
        val_185 = val_121.Item[0];
        if(val_185 != null)
        {
                AbstractBankViewItem val_124 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  val_182, 丐专丄丒七丒上丐丈:  "");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_124, 丏业丟一东丂东丘丛:  true);
            val_124.transform.SetParent(p:  val_1.transform);
            UnityEngine.Vector3 val_128 = UnityEngine.Vector3.one;
            val_124.transform.localScale = new UnityEngine.Vector3() {x = val_128.x, y = val_128.y, z = val_128.z};
            UnityEngine.Vector3 val_130 = UnityEngine.Vector3.zero;
            val_124.transform.localPosition = new UnityEngine.Vector3() {x = val_130.x, y = val_130.y, z = val_130.z};
            val_187 = val_124.transform;
            UnityEngine.Quaternion val_132 = UnityEngine.Quaternion.identity;
            val_188 = val_132.x;
            val_189 = val_132.z;
            val_190 = val_188;
            val_191 = val_132.y;
            val_192 = val_189;
            val_193 = val_132.w;
            val_187.localRotation = new UnityEngine.Quaternion() {x = val_190, y = val_191, z = val_192, w = val_193};
        }
        
        val_217 = 1;
        label_291:
        if(val_217 < val_121.Count)
        {
            goto label_310;
        }
        
        val_181 = val_181;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_182.gameObject, 丏业丟一东丂东丘丛:  false);
        if(val_181 != 8)
        {
            goto label_314;
        }
        
        label_212:
        val_218 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丂东三丑三丗丕丅丞();
        if(val_218 == null)
        {
                System.Collections.Generic.List<PGCompany.丘丒下东丗丏丁丅业> val_137 = null;
            val_218 = val_137;
            val_137 = new System.Collections.Generic.List<PGCompany.丘丒下东丗丏丁丅业>();
        }
        
        val_182 = mem[1152921537962904616];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_182.gameObject, 丏业丟一东丂东丘丛:  true);
        val_179 = 1152921504838369280;
        val_219 = 0;
        goto label_322;
        label_341:
        val_185 = val_137.Item[0];
        if(val_185 != null)
        {
                AbstractBankViewItem val_140 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  val_182, 丐专丄丒七丒上丐丈:  "");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_140, 丏业丟一东丂东丘丛:  true);
            val_140.transform.SetParent(p:  val_1.transform);
            UnityEngine.Vector3 val_144 = UnityEngine.Vector3.one;
            val_140.transform.localScale = new UnityEngine.Vector3() {x = val_144.x, y = val_144.y, z = val_144.z};
            UnityEngine.Vector3 val_146 = UnityEngine.Vector3.zero;
            val_140.transform.localPosition = new UnityEngine.Vector3() {x = val_146.x, y = val_146.y, z = val_146.z};
            val_187 = val_140.transform;
            UnityEngine.Quaternion val_148 = UnityEngine.Quaternion.identity;
            val_188 = val_148.x;
            val_189 = val_148.z;
            val_190 = val_188;
            val_191 = val_148.y;
            val_192 = val_189;
            val_193 = val_148.w;
            val_187.localRotation = new UnityEngine.Quaternion() {x = val_190, y = val_191, z = val_192, w = val_193};
        }
        
        val_219 = 1;
        label_322:
        if(val_219 < val_137.Count)
        {
            goto label_341;
        }
        
        val_181 = val_181;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_182.gameObject, 丏业丟一东丂东丘丛:  false);
        label_314:
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_152 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  110);
        if((val_152 == null) || ((System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_152)) == false))
        {
            goto label_375;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_154 = System.Linq.Enumerable.Cast<Rilisoft.Offers.业与丁丒业七丘丙丁>(source:  val_152);
        if(val_181 == 2)
        {
            goto label_350;
        }
        
        if(val_181 != 1)
        {
            goto label_375;
        }
        
        val_220 = null;
        val_220 = null;
        val_182 = BankView.<>c.<>9__53_5;
        if(val_182 == null)
        {
                System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean> val_155 = null;
            val_182 = val_155;
            val_155 = new System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丐丌丗丗丅丐一丒丒(Rilisoft.Offers.业与丁丒业七丘丙丁 丏丛与丅丛丌万专丌));
            BankView.<>c.<>9__53_5 = val_182;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.Offers.业与丁丒业七丘丙丁>(source:  val_154, predicate:  val_155)) == false)
        {
            goto label_375;
        }
        
        val_222 = null;
        val_222 = null;
        val_224 = BankView.<>c.<>9__53_6;
        if(val_224 != null)
        {
            goto label_372;
        }
        
        System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean> val_157 = null;
        val_224 = val_157;
        val_157 = new System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丁三下七业丗丛丅丆(Rilisoft.Offers.业与丁丒业七丘丙丁 丏丛与丅丛丌万专丌));
        BankView.<>c.<>9__53_6 = val_224;
        goto label_372;
        label_350:
        val_225 = null;
        val_225 = null;
        val_182 = BankView.<>c.<>9__53_7;
        if(val_182 == null)
        {
                System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean> val_158 = null;
            val_182 = val_158;
            val_158 = new System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丒丈丛丝专丘万丆丟(Rilisoft.Offers.业与丁丒业七丘丙丁 丏丛与丅丛丌万专丌));
            BankView.<>c.<>9__53_7 = val_182;
        }
        
        if((System.Linq.Enumerable.Any<Rilisoft.Offers.业与丁丒业七丘丙丁>(source:  val_154, predicate:  val_158)) == false)
        {
            goto label_375;
        }
        
        val_227 = null;
        val_227 = null;
        val_224 = BankView.<>c.<>9__53_8;
        if(val_224 == null)
        {
                System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean> val_160 = null;
            val_224 = val_160;
            val_160 = new System.Func<Rilisoft.Offers.业与丁丒业七丘丙丁, System.Boolean>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BankView.<>c::丝与丄万丛丒丛三丞(Rilisoft.Offers.业与丁丒业七丘丙丁 丏丛与丅丛丌万专丌));
            BankView.<>c.<>9__53_8 = val_224;
        }
        
        label_372:
        val_182 = System.Linq.Enumerable.ToList<Rilisoft.Offers.业与丁丒业七丘丙丁>(source:  System.Linq.Enumerable.Where<Rilisoft.Offers.业与丁丒业七丘丙丁>(source:  val_154, predicate:  val_160));
        if(val_182 == null)
        {
            goto label_375;
        }
        
        val_179 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921537962904624].gameObject, 丏业丟一东丂东丘丛:  true);
        List.Enumerator<T> val_164 = val_182.GetEnumerator();
        val_187 = 1152921537962836240;
        label_396:
        if(((-1003693264) & 1) == 0)
        {
            goto label_379;
        }
        
        string val_166 = val_20.丐丏七丌丕丗业且上();
        if(val_166 == null)
        {
            goto label_396;
        }
        
        AbstractBankViewItem val_168 = this.丈丆丟不一业三丁丏(丄东丛丑与丄丗丂丑:  mem[1152921537962904624], 丐专丄丒七丒上丐丈:  val_166.业上丙丞丐丄丆丅七());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_168, 丏业丟一东丂东丘丛:  true);
        val_168.transform.SetParent(p:  val_1.transform);
        UnityEngine.Vector3 val_172 = UnityEngine.Vector3.one;
        val_168.transform.localScale = new UnityEngine.Vector3() {x = val_172.x, y = val_172.y, z = val_172.z};
        UnityEngine.Vector3 val_174 = UnityEngine.Vector3.zero;
        val_168.transform.localPosition = new UnityEngine.Vector3() {x = val_174.x, y = val_174.y, z = val_174.z};
        UnityEngine.Quaternion val_176 = UnityEngine.Quaternion.identity;
        val_168.transform.localRotation = new UnityEngine.Quaternion() {x = val_176.x, y = val_176.y, z = val_176.z, w = val_176.w};
        goto label_396;
        label_379:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  false);
        label_375:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921537962904560].gameObject, 丏业丟一东丂东丘丛:  false);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  val_181);
    }
    public void OnBtnTabClick(UIButton 丂丄丞丌丗东业丛业)
    {
        this.ChangeTab(丂丄丞丌丗东业丛业:  丂丄丞丌丗东业丛业, 七业业世丅一丁不丛:  0);
    }
    public void ChangeTab(UIButton 丂丄丞丌丗东业丛业, string 七业业世丅一丁不丛)
    {
        UnityEngine.GameObject val_10;
        Rilisoft.BankShopViewGuiElement val_44;
        BankView.BankViewTab val_45;
        string val_46;
        string val_47;
        var val_49;
        var val_50;
        BankView.BankViewTab val_51;
        string val_53;
        BankView.BankViewTab val_54;
        var val_55;
        var val_56;
        BankView.BankViewTab val_57;
        var val_58;
        var val_59;
        var val_63;
        val_44 = this;
        .丂丄丞丌丗东业丛业 = 丂丄丞丌丗东业丛业;
        val_45 = 1;
        val_46 = public static BankViewStateSettings System.Linq.Enumerable::FirstOrDefault<BankViewStateSettings>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate);
        if((System.Linq.Enumerable.FirstOrDefault<BankViewStateSettings>(source:  this._states, predicate:  new System.Func<BankViewStateSettings, System.Boolean>(object:  new BankView.不丄业上万丝丒专丂(), method:  System.Boolean BankView.不丄业上万丝丒专丂::七与丘且丏丞丗丙丂(BankView.BankViewStateSettings 丏丛与丅丛丌万专丌)))) != null)
        {
                val_45 = val_3.tab;
        }
        
        if(this.丕丈丆丑丈丌与丆七 < UnityEngine.Time.frameCount)
        {
                if(val_45 == 2)
        {
                val_47 = "Coins";
        }
        else
        {
                val_47 = val_45.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        
            val_46 = val_47;
            PGCompany.Analytics.一业丗丆世世上丁且.丙丑丟丆丑世丁专丅(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  2, 丐丅丒专丛丏上与业:  val_46, 世丁丙世丄一万丆三:  七业业世丅一丁不丛);
            this.丕丈丆丑丈丌与丆七 = UnityEngine.Time.frameCount;
        }
        
        List.Enumerator<T> val_8 = this._states.GetEnumerator();
        val_49 = 1152921537963660464;
        label_21:
        if(((-1002820576) & 1) == 0)
        {
            goto label_13;
        }
        
        if(val_10.丐丏七丌丕丗业且上() != null)
        {
                val_51 = null;
        }
        else
        {
                val_50 = 64;
            val_51 = null;
        }
        
        var val_12 = (val_51 != val_11.m_stringLength) ? 1 : 0;
        if(1 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  (1 == 0) ? 0 : 1.gameObject, 丏业丟一东丂东丘丛:  (val_11.m_stringLength == null) ? 1 : 0);
        }
        
        this.丑丂丛丌业丘丞丆丈(丐丅丒专丛丏上与业:  val_11.m_stringLength, 丙业与丙丗丝不丈东:  (val_11.m_stringLength == null) ? 1 : 0);
        goto label_21;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  null);
        this.丕专丏七三东丏丐丝 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  (~(this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  3))) & 1);
        val_53 = 1152921505211211775;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  (val_53 < 2) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._x3TimerContainer, 丏业丟一东丂东丘丛:  (null != 5) ? 1 : 0);
        this.上东丆丛丗丁丌丟专();
        this.专丏丞丆丕丗丗一丙(丗丈丒丏丏丂三丕丂:  AbstractBankView.丐与丐丄七丗三专万());
        val_54 = null;
        if(val_54 == 1)
        {
                val_55 = null;
            val_55 = null;
            val_53 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            X10Manager.丑七不且上丗丁一世().丝三世丈丑丕业丈世(丏丂不专上丘丂不丅:  val_53);
            val_54 = null;
        }
        
        if(val_54 == 2)
        {
                val_56 = null;
            val_56 = null;
            val_53 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            X10Manager.丑七不且上丗丁一世().丝三世丈丑丕业丈世(丏丂不专上丘丂不丅:  val_53);
        }
        
        this.三丄专丄与不丈三丘(丅万丐丑丈丁丙丒丘:  null);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.CurrencyThatNotEnough)) == true)
        {
            goto label_47;
        }
        
        val_57 = null;
        if(604364800 != 4)
        {
            goto label_48;
        }
        
        this.CurrencyThatNotEnough = System.String.alignConst;
        label_47:
        val_57 = null;
        label_48:
        if(val_57 != 4)
        {
            goto label_141;
        }
        
        List.Enumerator<T> val_27 = this.丅丂东与与丗丙丅丙.GetEnumerator();
        val_58 = 0;
        val_59 = 0;
        var val_50 = 0;
        label_95:
        if(((-1002820608) & 1) == 0)
        {
            goto label_51;
        }
        
        int val_28 = val_10.丙东专丂世丈丏丁丂();
        if((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  val_28)) == false)
        {
            goto label_95;
        }
        
        System.Collections.Generic.IEnumerable<Rilisoft.业丙丘丆东丈丕丂丄> val_32 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  val_28);
        if(val_32 == null)
        {
            goto label_95;
        }
        
        var val_47 = 0;
        val_47 = val_47 + 1;
        System.Collections.Generic.IEnumerator<T> val_34 = val_32.GetEnumerator();
        label_78:
        var val_48 = 0;
        val_48 = val_48 + 1;
        if(val_34.MoveNext() == false)
        {
            goto label_69;
        }
        
        var val_49 = 0;
        val_49 = val_49 + 1;
        BalanceController.丑丂丏三东业丅丆丙(丝丄丟丅丑下丐丄丁:  "offer-"("offer-") + val_34.Current.业上丙丞丐丄丆丅七());
        goto label_78;
        label_69:
        val_50 = val_50 + 1;
        val_63 = val_59;
        mem2[0] = 578;
        if(val_34 == null)
        {
            
        }
        else
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_34.Dispose();
        }
        
        if((val_50 == 1) || ((-1002820672 + ((0 + 1)) << 2) != 578))
        {
            goto label_92;
        }
        
        var val_52 = 0;
        val_52 = val_52 ^ (val_50 >> 31);
        val_50 = val_50 + val_52;
        goto label_95;
        label_92:
        if( == false)
        {
            goto label_95;
        }
        
        goto label_95;
        label_51:
        val_49 = val_50 + 1;
        mem2[0] = 603;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_49 == 1)
        {
            goto label_120;
        }
        
        if(( == 0) || ((-1002820672 + ((0 + 1)) << 2) == 603))
        {
            goto label_141;
        }
        
        label_140:
        label_141:
        if((BankController.丑七不且上丗丁一世().丁且上丘业且七丌专(丐丅丒专丛丏上与业:  null)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanCurrencyPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._shopGui, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanCurrencyPanel, 丏业丟一东丂东丘丛:  false);
            if(this._shopGui != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._shopGui, 丏业丟一东丂东丘丛:  true);
            val_44 = this._shopGui;
            val_44.丝一丅丆三东丂丞七();
        }
        
        }
        
        if(null != 5)
        {
                return;
        }
        
        val_44 = PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世();
        val_44.一东丁世丆与丆万丌(丈七丄丆丅丂东丄一:  1);
        return;
        label_120:
        if( != 0)
        {
            goto label_140;
        }
        
        goto label_141;
    }
    public BankView.BankViewTab GetEnabledTab()
    {
        int val_3;
        List.Enumerator<T> val_1 = this._states.GetEnumerator();
        label_5:
        if(((-1002565080) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((137117696 & 1) != 0)
        {
            goto label_5;
        }
        
        val_3 = val_2.m_stringLength;
        goto label_6;
        label_2:
        val_3 = 1;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (BankViewTab);
    }
    private void 三丄专丄与不丈三丘(BankView.BankViewTab 丅万丐丑丈丁丙丒丘)
    {
        var val_10;
        UnityEngine.GameObject val_11;
        UnityEngine.GameObject val_12;
        bool val_13;
        if(丅万丐丑丈丁丙丒丘 == 5)
        {
            goto label_1;
        }
        
        if(丅万丐丑丈丁丙丒丘 != 4)
        {
            goto label_2;
        }
        
        if(BalanceController.下丂万丐丄丅七一东() == null)
        {
            goto label_5;
        }
        
        var val_4 = (BalanceController.下丂万丐丄丅七一东().Count == 0) ? 1 : 0;
        goto label_9;
        label_1:
        bool val_6 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40);
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_15;
        }
        
        this.下七丘三丏丐七丄专(丙业与丙丗丝不丈东:  val_6);
        return;
        label_2:
        val_11 = this.noOffersIndicator;
        val_12 = val_11;
        val_13 = 0;
        goto label_21;
        label_5:
        val_10 = 1;
        label_9:
        val_11 = this.noOffersIndicator;
        val_12 = val_11;
        val_13 = val_10;
        goto label_21;
        label_15:
        val_11 = this.noOffersIndicator;
        val_13 = (~val_6) & 1;
        val_12 = val_11;
        label_21:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  val_13);
    }
    public void GoToTab(BankView.BankViewTab 丐丅丒专丛丏上与业, string 七业业世丅一丁不丛)
    {
        UIButton val_1 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
        if(val_1 == 0)
        {
                return;
        }
        
        this.ChangeTab(丂丄丞丌丗东业丛业:  val_1, 七业业世丅一丁不丛:  七业业世丅一丁不丛);
    }
    private void 丑丂丛丌业丘丞丆丈(BankView.BankViewTab 丐丅丒专丛丏上与业, bool 丙业与丙丗丝不丈东)
    {
        UIButton val_1 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
        if(val_1 == 0)
        {
                return;
        }
        
        UIToggle val_3 = val_1.GetComponent<UIToggle>();
        if(val_3 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  val_3, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    public override void UpdateUi()
    {
        var val_6;
        var val_40;
        System.Collections.Generic.List<BankViewStateSettings> val_41;
        var val_42;
        var val_44;
        UnityEngine.GameObject val_45;
        UnityEngine.GameObject val_46;
        var val_47;
        if((System.String.op_Inequality(a:  this.丅专丆三丈丘丈上丞, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                val_40 = 1;
            this.丅专丆三丈丘丈上丞 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        }
        else
        {
                val_40 = 0;
        }
        
        val_41 = this._states;
        List.Enumerator<T> val_4 = val_41.GetEnumerator();
        label_6:
        if(((-1001886336) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        this.东丞丕丄丆丈与业丌(丐丅丒专丛丏上与业:  val_7.m_stringLength, 丆丄丘丂业丛七丁且:  false);
        goto label_6;
        label_4:
        val_42 = public System.Void List.Enumerator<BankViewStateSettings>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_40 == 0)
        {
            
        }
        else
        {
                val_42 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<AbstractBankViewItem>>::Clear();
            this.丑丙不与上丌丗丙丅.Clear();
        }
        
        if((this & 1) == 0)
        {
            goto label_15;
        }
        
        System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_8 = BalanceController.下丂万丐丄丅七一东();
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  1, 丘万丌丏丂丂丒丁丘:  val_8);
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  2, 丘万丌丏丂丂丒丁丘:  val_8);
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  3, 丘万丌丏丂丂丒丁丘:  val_8);
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  4, 丘万丌丏丂丂丒丁丘:  val_8);
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  5, 丘万丌丏丂丂丒丁丘:  val_8);
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  6, 丘万丌丏丂丂丒丁丘:  val_8);
        this.丐丘丟丒丌丂三丏七(丐丅丒专丛丏上与业:  8, 丘万丌丏丂丂丒丁丘:  val_8);
        UnityEngine.Transform val_9 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  1, 丆丗丗三丏丏丕丁丙:  val_8);
        UnityEngine.Transform val_10 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  2, 丆丗丗三丏丏丕丁丙:  val_8);
        UnityEngine.Transform val_11 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  3, 丆丗丗三丏丏丕丁丙:  val_8);
        UnityEngine.Transform val_12 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  4, 丆丗丗三丏丏丕丁丙:  val_8);
        UnityEngine.Transform val_13 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  5, 丆丗丗三丏丏丕丁丙:  val_8);
        UnityEngine.Transform val_14 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  6, 丆丗丗三丏丏丕丁丙:  val_8);
        UnityEngine.Transform val_15 = this.一七丄丟丗丗不丟世(丐丅丒专丛丏上与业:  8, 丆丗丗三丏丏丕丁丙:  val_8);
        this.三丄专丄与不丈三丘(丅万丐丑丈丁丙丒丘:  this.GetEnabledTab());
        UIButton val_17 = this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  3);
        UnityEngine.GameObject val_19 = val_17.gameObject;
        if(Rilisoft.VIPController.丄东丅丐丁丅七丅与() == false)
        {
            goto label_21;
        }
        
        val_44 = Rilisoft.VIPController.丌丏丄专丘丕丑上且();
        val_45 = val_19;
        goto label_26;
        label_15:
        this.SetXModes(且丐上且丞丒丟与丘:  false, 丅丂东丞丛丐上不三:  false);
        return;
        label_21:
        val_45 = val_19;
        val_44 = 0;
        label_26:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_45, 丏业丟一东丂东丘丛:  false);
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() != null)
        {
                val_46 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌();
        }
        else
        {
                val_46 = 0;
        }
        
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() != null)
        {
                val_47 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛();
        }
        else
        {
                val_47 = 0;
        }
        
        this.SetXModes(且丐上且丞丒丟与丘:  false, 丅丂东丞丛丐上不三:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_46, 丏业丟一东丂东丘丛:  (~val_17) & 1);
        this.丕专丏七三东丏丐丝 = true;
        this.不世丅上世东七丏丆 = true;
        this.三丄专丄与不丈三丘(丅万丐丑丈丁丙丒丘:  this.GetEnabledTab());
        if((BankController.丑七不且上丗丁一世().丁且上丘业且七丌专(丐丅丒专丛丏上与业:  5)) == false)
        {
            goto label_50;
        }
        
        this.下七丘三丏丐七丄专(丙业与丙丗丝不丈东:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40));
        if(this.丛三专丂丏丈专专且 == false)
        {
            goto label_55;
        }
        
        this.上丈专七丑丙专丂丘();
        goto label_55;
        label_50:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丕丂丌下丘丑丝丆丆(丐丅丒专丛丏上与业:  5).gameObject, 丏业丟一东丂东丘丛:  false);
        label_55:
        this.丙丕丕下丅丐丙丅丕();
    }
    internal void 丙丕丕下丅丐丙丅丕()
    {
        var val_3;
        List.Enumerator<T> val_1 = this._states.GetEnumerator();
        label_15:
        if(((-1001634048) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((this.丝丅丝下丕丘丂丕不(丐丅丒专丛丏上与业:  val_4.m_stringLength)) == false)
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  X21, 丏业丟一东丂东丘丛:  true);
        this._tabsLayout.丅丆丗上丆与东下丟(世丌丌丙丞丟下东丞:  X22, 丞世不丒下上上丝丑:  BankController.丑七不且上丗丁一世().业丗丆丂专下三丑丗().IndexOf(item:  val_4.m_stringLength));
        goto label_15;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  X21, 丏业丟一东丂东丘丛:  false);
        goto label_15;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        this._tabsLayout.Reposition();
    }
    private UnityEngine.Transform 一七丄丟丗丗不丟世(BankView.BankViewTab 丐丅丒专丛丏上与业, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丆丗丗三丏丏丕丁丙)
    {
        BankViewTab val_21;
        System.Collections.Generic.IComparer<T> val_22;
        System.Collections.Generic.IEnumerable<TSource> val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Func<AbstractBankViewItem, System.Int32> val_29;
        var val_31;
        System.Func<AbstractBankViewItem, System.Int32> val_33;
        object val_34;
        var val_35;
        val_21 = 丐丅丒专丛丏上与业;
        val_22 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  val_21).transform;
        System.Collections.Generic.List<AbstractBankViewItem> val_3 = null;
        val_23 = val_3;
        val_3 = new System.Collections.Generic.List<AbstractBankViewItem>();
        val_24 = 0;
        goto label_2;
        label_7:
        val_3.Add(item:  val_22.GetChild(index:  0).GetComponent<AbstractBankViewItem>());
        val_24 = 1;
        label_2:
        if(val_24 < val_22.childCount)
        {
            goto label_7;
        }
        
        if(val_21 == 5)
        {
            goto label_23;
        }
        
        if(val_21 != 8)
        {
            goto label_9;
        }
        
        if(StoreKitEventListener.丝丝一丟丈三丂丌丁() == false)
        {
            goto label_12;
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = null;
        if(BalanceController.上且与丑丑下丒丁与 == false)
        {
            goto label_15;
        }
        
        val_27 = null;
        val_29 = BankView.<>c.<>9__65_0;
        if(val_29 == null)
        {
                System.Func<AbstractBankViewItem, System.Int32> val_8 = null;
            val_29 = val_8;
            val_8 = new System.Func<AbstractBankViewItem, System.Int32>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BankView.<>c::丗且东丕丌三丒万丙(AbstractBankViewItem 七丞丙丒三丕且丌丟));
            BankView.<>c.<>9__65_0 = val_29;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_9 = System.Linq.Enumerable.OrderByDescending<AbstractBankViewItem, System.Int32>(source:  val_3, keySelector:  val_8);
        goto label_21;
        label_9:
        万业丘业丘丈业丈且 val_10 = null;
        val_22 = val_10;
        val_10 = new 万业丘业丘丈业丈且(丆丗丗三丏丏丕丁丙:  丆丗丗三丏丏丕丁丙);
        val_3.Sort(comparer:  val_10);
        goto label_23;
        label_12:
        val_31 = null;
        goto label_27;
        label_15:
        val_31 = null;
        label_27:
        val_33 = BankView.<>c.<>9__65_1;
        if(val_33 == null)
        {
                System.Func<AbstractBankViewItem, System.Int32> val_11 = null;
            val_33 = val_11;
            val_11 = new System.Func<AbstractBankViewItem, System.Int32>(object:  BankView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BankView.<>c::丁专丛下丛丐丆世与(AbstractBankViewItem 七丞丙丒三丕且丌丟));
            BankView.<>c.<>9__65_1 = val_33;
        }
        
        label_21:
        val_23 = System.Linq.Enumerable.ToList<AbstractBankViewItem>(source:  System.Linq.Enumerable.OrderBy<AbstractBankViewItem, System.Int32>(source:  val_3, keySelector:  val_11));
        label_23:
        val_34 = 0;
        goto label_31;
        label_36:
        val_22 = val_23.Item[0].gameObject;
        val_22.name = System.String.Format(format:  "{0:00}", arg0:  val_34);
        val_34 = 1;
        label_31:
        if(val_34 < val_23.Count)
        {
            goto label_36;
        }
        
        this.丅三丕不丈下丁丒东(丈不丘万丐丛下专下:  val_21);
        if(val_23.Count >= 1)
        {
                val_21 = val_23.Item[0];
            UnityEngine.Transform val_20 = val_21.transform;
            return (UnityEngine.Transform)val_35;
        }
        
        val_35 = 0;
        return (UnityEngine.Transform)val_35;
    }
    private void 丅三丕不丈下丁丒东(BankView.BankViewTab 丈不丘万丐丛下专下)
    {
        UIGrid val_1 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  丈不丘万丐丛下专下);
        if(val_1 == 0)
        {
                return;
        }
        
        UIScrollView val_3 = this.丂专下三一上丙丞东(丐丅丒专丛丏上与业:  丈不丘万丐丛下专下);
        if(val_3 == 0)
        {
                return;
        }
        
        if(val_3 != null)
        {
                val_3.ResetPosition();
        }
        else
        {
                0.ResetPosition();
        }
        
        float val_10 = val_1.cellWidth;
        val_10 = val_10 * (float)val_1.transform.childCount;
        var val_9 = (val_10 <= (val_3.GetComponent<UIPanel>().width)) ? 1 : 0;
        goto typeof(UIScrollView).__il2cppRuntimeField_1C8;
    }
    private void LateUpdate()
    {
        if(this.丕专丏七三东丏丐丝 != false)
        {
                this.丕专丏七三东丏丐丝 = false;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.世专丌三丁一东世丗());
        }
        
        if(this.不世丅上世东七丏丆 == false)
        {
                return;
        }
        
        this.不世丅上世东七丏丆 = false;
        this = this.GetComponent<UIPanel>();
        if(this == 0)
        {
                return;
        }
        
        if(this != null)
        {
                this.SetDirty();
        }
        else
        {
                this.SetDirty();
        }
        
        this.Refresh();
    }
    private System.Collections.IEnumerator 世专丌三丁一东世丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BankView.且丝与丝三丞丏且七();
    }
    protected override System.Collections.Generic.IEnumerable<AbstractBankViewItem> 丙万丗丑丐专且与丈()
    {
        System.Collections.Generic.IEnumerable<TSource> val_11;
        System.Collections.Generic.IEnumerable<TSource> val_12;
        System.Collections.Generic.IEnumerable<TSource> val_13;
        val_11 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  1).GetComponentsInChildren<AbstractBankViewItem>();
        if(val_11 == null)
        {
                AbstractBankViewItem[] val_3 = new AbstractBankViewItem[0];
            val_11 = val_3;
        }
        
        val_12 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  2).GetComponentsInChildren<AbstractBankViewItem>();
        if(val_12 == null)
        {
                AbstractBankViewItem[] val_6 = new AbstractBankViewItem[0];
            val_12 = val_6;
        }
        
        val_13 = this.丒三丆下业丁业丗万(丐丅丒专丛丏上与业:  3).GetComponentsInChildren<AbstractBankViewItem>();
        if(val_13 != null)
        {
                return System.Linq.Enumerable.Concat<AbstractBankViewItem>(first:  System.Linq.Enumerable.Concat<AbstractBankViewItem>(first:  val_3, second:  val_6), second:  AbstractBankViewItem[] val_10 = new AbstractBankViewItem[0]);
        }
        
        val_13 = val_10;
        return System.Linq.Enumerable.Concat<AbstractBankViewItem>(first:  System.Linq.Enumerable.Concat<AbstractBankViewItem>(first:  val_3, second:  val_6), second:  val_10);
    }
    private void 上丈专七丑丙专丂丘()
    {
        UnityEngine.GameObject val_17;
        UnityEngine.Object val_18;
        var val_19;
        string val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  40);
        if((this.且丞上丆专万丟七东 != null) && ((System.String.op_Inequality(a:  this.且丞上丆专万丟七东, b:  val_2)) != false))
        {
                if(this.丘万丑下丘丁万丅丁 != 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁);
            this.丘万丑下丘丁万丅丁 = 0;
        }
        
            this.且丞上丆专万丟七东 = 0;
        }
        
        this.且丞上丆专万丟七东 = val_2;
        val_17 = this.丘万丑下丘丁万丅丁;
        if(val_17 != 0)
        {
                return;
        }
        
        val_17 = 1152921524279436720;
        val_18 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/{0}", arg0:  System.String.Format(format:  "banktab_eventstore_{0}", arg0:  val_2.ToLower())));
        if(val_18 == 0)
        {
                val_19 = "basic";
            if("basic" == null)
        {
                val_19 = "basic";
        }
        
            val_18 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/banktab_eventstore_{0}", arg0:  ToLower()));
        }
        
        if(val_18 == 0)
        {
                return;
        }
        
        val_17 = this._eventStoreCustomGuiHandler;
        int val_15 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        this.丘万丑下丘丁万丅丁 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_18, 丈东丘丏与丌东东下:  val_17, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public BankView()
    {
        this.下丏上上东丗丆丙丞 = true;
        this._states = new System.Collections.Generic.List<BankViewStateSettings>();
        this.丛三专丂丏丈专专且 = true;
        this.丑丙不与上丌丗丙丅 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<AbstractBankViewItem>>();
        this.丕丈丆丑丈丌与丆七 = 0;
        System.Collections.Generic.List<OfferModule> val_3 = new System.Collections.Generic.List<OfferModule>();
        if(val_3 != null)
        {
                val_3.Add(item:  60);
            val_3.Add(item:  70);
            val_3.Add(item:  80);
            val_3.Add(item:  100);
            val_3.Add(item:  130);
            val_3.Add(item:  140);
        }
        else
        {
                val_3.Add(item:  60);
            val_3.Add(item:  70);
            val_3.Add(item:  80);
            val_3.Add(item:  100);
            val_3.Add(item:  130);
            val_3.Add(item:  140);
        }
        
        val_3.Add(item:  150);
        this.丅丂东与与丗丙丅丙 = val_3;
        this.丅专丆三丈丘丈上丞 = System.String.alignConst;
    }
    private static BankView()
    {
        BankView.丗一专业丘丙丟丄万 = "";
    }
    private bool 丝丅丝下丕丘丂丕不(BankView.BankViewTab 丐丅丒专丛丏上与业)
    {
        BankViewTab val_7;
        var val_8;
        val_7 = 丐丅丒专丛丏上与业;
        if((BankController.丑七不且上丗丁一世().丁且上丘业且七丌专(丐丅丒专丛丏上与业:  val_7)) == false)
        {
            goto label_13;
        }
        
        if(val_7 == 7)
        {
            goto label_5;
        }
        
        if(val_7 == 6)
        {
            goto label_6;
        }
        
        if(val_7 != 5)
        {
                return (bool)val_8;
        }
        
        var val_3 = (this.丛三专丂丏丈专专且 == true) ? 1 : 0;
        return (bool)val_8;
        label_5:
        BankController val_4 = BankController.丑七不且上丗丁一世();
        if(val_4 != null)
        {
                return val_4.专丒丙丑丗七一世世();
        }
        
        return val_4.专丒丙丑丗七一世世();
        label_6:
        val_7 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
        if(val_7.与丁上丌丝丟丑一丏() != false)
        {
                return 丐东不丅丂丂丅丙不.世丞业下丗上三不万();
        }
        
        label_13:
        val_8 = 0;
        return (bool)val_8;
    }

}
