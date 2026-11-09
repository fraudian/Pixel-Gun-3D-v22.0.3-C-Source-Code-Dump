using UnityEngine;
public class GiftBannerWindow : BannerWindow, 丑且丆万丏丝丘丙丟
{
    // Fields
    internal const string 东丌丅丈丌一万七丈 = "OpenGiftPanel";
    internal const string 丆丁丅丛丈丘丒三丌 = "OpenGiftBtnRelease";
    internal const string 丐丝与丟丝丞丁万丕 = "GiftInfoShow";
    internal const string 东丐丁一丐丒丙丝三 = "GiftInfoClose";
    internal static GiftBannerWindow 丄丘七三上丕世丞业;
    internal static bool 丆且丌且丘上丁丄七;
    internal static bool 与丌东下丙丕业三且;
    internal static bool 丘丆且七丑丘且专丟;
    private ArmoryInfoScreenController 下丏丗且丅丟丄丂与;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private Rilisoft.TextGroup _freeSpinsText;
    private Rilisoft.PrefabHandler _prefabHandler;
    private bool 丑丑丆丂丒丆丐丛东;
    public UnityEngine.Animator animatorBanner;
    private SlotInfo 丞与丝专一业丆丙且;
    public UIButton BankButton;
    public UnityEngine.Transform bankShopView;
    public UnityEngine.GameObject bannerObj;
    public UnityEngine.GameObject butBuy;
    public UnityEngine.GameObject butGift;
    private bool 且上丁一丞丞上不上;
    private UnityEngine.Coroutine 万三与丗丑丅不业丅;
    public GiftBannerWindow.丟七丄丟下丗丐丝东 curStateAnimAward;
    private float 业丈丅下专东丛七上;
    public GiftHUDItem giftInfoView;
    public GiftHUDItem giftRewardView;
    private bool 三三万丈丕丁丅丏丆;
    public UILabel[] lbPriceForBuy;
    public UILabel[] lbTimer;
    public UILabel[] ChestNameLabel;
    public UILabel NextChestTimerLabel;
    public UILabel NextChestNameLabel;
    public UITextureMasked NextChestTextureComponent;
    public UnityEngine.Transform leftBoarderScroll;
    public bool needForceShowAwardGift;
    private bool 丈丙丈丞一七且丟且;
    private bool 丟与与三丝万丟丅丁;
    public UnityEngine.GameObject objLabelTapGift;
    public UnityEngine.GameObject objSound;
    public UnityEngine.Transform rightBoarderScroll;
    public GiftScroll scrollGift;
    public float speedAnimCenter;
    public UISprite sprDarkFon;
    public UISprite sprFonScroll;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private UnityEngine.Coroutine 丂丑丘丕万专丌丆丒;
    private System.Collections.Generic.Dictionary<GiftSettingType, string[]> 东业丙丙丑丘世三下;
    private readonly string 丘丒东不丄业下丆东;
    private readonly string 上丑丁丑世丞丂七东;
    private static System.Action 丟不丒万丝与丂上丘;
    private static System.Action 不七丄丂丌丘丘丈丈;
    private static System.Action 丐三一丛专丁丈丙丅;
    private static System.Action 丛与丗丙上丟丂三丏;
    internal static System.Action 丕丄丝丂丅东丆与不;
    
    // Properties
    internal static bool 下丐丙专丕丙丗万丕 { get; }
    
    // Methods
    internal static bool 丛世丛与丌不丈丐丐()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.GameObject val_2 = GiftBannerWindow.丄丘七三上丕世丞业.gameObject;
        if(val_2 != null)
        {
                return val_2.activeInHierarchy;
        }
        
        return val_2.activeInHierarchy;
    }
    internal static void 丘丌世专丌专丕丂丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftBannerWindow.丟不丒万丝与丂上丘, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.丟不丒万丝与丂上丘 != 1152921505204400144);
    
    }
    internal static void 不丛丛丌上丕丏专三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftBannerWindow.丟不丒万丝与丂上丘, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.丟不丒万丝与丂上丘 != 1152921505204400144);
    
    }
    internal static void 业三专丝丘丄丒丄三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftBannerWindow.不七丄丂丌丘丘丈丈, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.不七丄丂丌丘丘丈丈 != 1152921505204400152);
    
    }
    internal static void 丕东与一丛业上丐丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftBannerWindow.不七丄丂丌丘丘丈丈, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.不七丄丂丌丘丘丈丈 != 1152921505204400152);
    
    }
    internal static void 东世世丂丗丙且上丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftBannerWindow.丐三一丛专丁丈丙丅, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.丐三一丛专丁丈丙丅 != 1152921505204400160);
    
    }
    internal static void 丈专七丁专专丗万丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftBannerWindow.丐三一丛专丁丈丙丅, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.丐三一丛专丁丈丙丅 != 1152921505204400160);
    
    }
    internal static void 丌七丘与丁丏丈三丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  GiftBannerWindow.丛与丗丙上丟丂三丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.丛与丗丙上丟丂三丏 != 1152921505204400168);
    
    }
    internal static void 丐与丏东丑且专丈丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  GiftBannerWindow.丛与丗丙上丟丂三丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(GiftBannerWindow.丛与丗丙上丟丂三丏 != 1152921505204400168);
    
    }
    private void Awake()
    {
        GiftBannerWindow val_30;
        var val_31;
        UIButton val_32;
        var val_33;
        var val_34;
        var val_35;
        UnityEngine.Transform val_36;
        val_30 = this;
        val_31 = null;
        val_31 = null;
        GiftBannerWindow.丄丘七三上丕世丞业 = val_30;
        val_32 = 1152921504848912384;
        if(this.animatorBanner != 0)
        {
                this.animatorBanner = this.GetComponent<UnityEngine.Animator>();
        }
        
        GiftController.丝丝丑丄世丑专丞丝(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GiftBannerWindow::丁丕丅丗东业丁业丆(string 且万万东丏且万下丐)));
        GiftController.世丌专上丟丄三上丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftBannerWindow::丅专丁丑丅丒东丑丛()));
        GiftController.丛丁丆丒业丆丌丛三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftBannerWindow::丟丞丄丙丕丈世专丏()));
        GiftController.丐东丏丙丂丐丄万且(丙业与丙丗丝不丈东:  new System.Action<System.TimeSpan>(object:  this, method:  System.Void GiftBannerWindow::业下丞丙七与丝东丘(System.TimeSpan 丂三丟丂丈丐丆丗丟)));
        GiftController.下丅丕丈丗丅上不一(丙业与丙丗丝不丈东:  new System.Action<GiftSettingType, GiftSettingType>(object:  this, method:  System.Void GiftBannerWindow::丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏)));
        if(this._prefabHandler.Prefab == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._prefabHandler.Prefab);
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_11, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_11.transform.SetParent(p:  this.bankShopView);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        val_11.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
        val_11.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        Rilisoft.BankShopView val_19 = val_11.GetComponent<Rilisoft.BankShopView>();
        if(val_19 != null)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_19.ShopButton, 丏业丟一东丂东丘丛:  false);
            val_33 = val_19;
            val_34 = 0;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_19.BankButton, 丏业丟一东丂东丘丛:  true);
        }
        else
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  130718704, 丏业丟一东丂东丘丛:  false);
            val_33 = 80;
            val_34 = 0;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  0, 丏业丟一东丂东丘丛:  true);
        }
        
        UIButton val_20 = 0.GetComponent<UIButton>();
        var val_22 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        if(val_19 != null)
        {
                val_35 = val_19;
            val_36 = val_19.ObjectForCenter;
        }
        else
        {
                val_35 = 184;
            val_36 = 130653168;
        }
        
        UnityEngine.Vector3 val_24 = 0.transform.localPosition;
        UnityEngine.Vector3 val_25 = 130653168.localPosition;
        UnityEngine.Vector3 val_26 = 130653168.localPosition;
        val_36.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(val_19 != null)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_19.BgSimple, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_19.BgX3, 丏业丟一东丂东丘丛:  true);
        }
        else
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  0, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  123372880, 丏业丟一东丂东丘丛:  true);
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_19.FrameX3Bank, 丏业丟一东丂东丘丛:  true);
        val_32 = this.BankButton;
        mem2[0] = val_19.BankButtonScript;
        val_19.BankButtonCollider.enabled = false;
        val_30 = val_19.BankButtonScript;
        val_30.enabled = false;
    }
    private void OnDestroy()
    {
        var val_6;
        GiftController.丈专丟不上丆丁丑丝(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GiftBannerWindow::丁丕丅丗东业丁业丆(string 且万万东丏且万下丐)));
        GiftController.上上丂丙丒三丅丑与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftBannerWindow::丅专丁丑丅丒东丑丛()));
        GiftController.一且丑万业丛东丅丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GiftBannerWindow::丟丞丄丙丕丈世专丏()));
        GiftController.丟丌万下丗丟丑下一(丙业与丙丗丝不丈东:  new System.Action<System.TimeSpan>(object:  this, method:  System.Void GiftBannerWindow::业下丞丙七与丝东丘(System.TimeSpan 丂三丟丂丈丐丆丗丟)));
        GiftController.丘丏丂专业丙上丒丗(丙业与丙丗丝不丈东:  new System.Action<GiftSettingType, GiftSettingType>(object:  this, method:  System.Void GiftBannerWindow::丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏)));
        val_6 = null;
        val_6 = null;
        GiftBannerWindow.丘丆且七丑丘且专丟 = false;
        GiftBannerWindow.丕丄丝丂丅东丆与不 = 0;
        GiftBannerWindow.丄丘七三上丕世丞业 = 0;
    }
    private void OnEnable()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        GiftController val_26;
        var val_27;
        System.Action val_28;
        if(this.bannerObj.activeSelf != true)
        {
                this.丈丙丈丞一七且丟且 = true;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.objSound)) != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.objSound, 丏业丟一东丂东丘丛:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗());
        }
        
        this.七上丄不丛不丘丐丈();
        this.丏上丂且世东丌丄丛();
        val_22 = null;
        val_22 = null;
        GiftBannerWindow.丆且丌且丘上丁丄七 = false;
        val_23 = null;
        val_23 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_44;
        }
        
        val_24 = null;
        val_24 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift == false)
        {
            goto label_20;
        }
        
        val_25 = null;
        val_25 = null;
        GiftController.丆丕丝丒不丙且丐丗.丒世且丄万丕三一丝();
        GiftController.丆丕丝丒不丙且丐丗.CheckAvaliableSlots();
        val_26 = GiftController.丆丕丝丒不丙且丐丗;
        if(GiftController.丆丕丝丒不丙且丐丗 != null)
        {
            goto label_25;
        }
        
        val_26 = GiftController.丆丕丝丒不丙且丐丗;
        if(val_26 == null)
        {
            goto label_26;
        }
        
        label_25:
        this.丟丘东丆丘与丈丗下(上丞丕专丈业丁世专:  GiftController.丆丕丝丒不丙且丐丗.丁东丑丏丐丗丝七一, 丗丕下东丅丏丕上丏:  GiftController.丆丕丝丒不丙且丐丗.丐与丛丆世丌丌丑三);
        System.TimeSpan val_7 = GiftController.丆丕丝丒不丙且丐丗.三东丌与下丕丏丕且();
        this.业下丞丙七与丝东丘(丂三丟丂丈丐丆丗丟:  new System.TimeSpan() {_ticks = val_7._ticks});
        if(Progress.七七世万专丕丁上业.丐丐上丟丑丆丐专丗().七丝上丝丘三丅下丈() == true)
        {
            goto label_44;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐下丈丒上七丘东丑();
        goto label_44;
        label_20:
        this.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
        val_27 = null;
        val_27 = null;
        GiftBannerWindow.丆且丌且丘上丁丄七 = true;
        val_28 = GiftBannerWindow.丟不丒万丝与丂上丘;
        if(val_28 != null)
        {
                val_28 = GiftBannerWindow.丟不丒万丝与丂上丘;
            if(val_28 == null)
        {
                val_28 = 0;
        }
        
            val_28.Invoke();
        }
        
        if(MainMenuHeroCamera.丑七不且上丗丁一世() != 0)
        {
                MainMenuHeroCamera.丑七不且上丗丁一世().PlayCloseGift();
        }
        
        label_44:
        if(Rilisoft.GachaRewardedVideoController.丑七不且上丗丁一世() != 0)
        {
                Rilisoft.GachaRewardedVideoController.丑七不且上丗丁一世().RefreshGui();
        }
        
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void GiftBannerWindow::CloseBanner()), 与且专丈不万东一万:  "Gift (Gotcha)");
        UniversalRewardBanner.丒丏丏丛丕丐丂丛丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void GiftBannerWindow::OnClickGift()));
        return;
        label_26:
    }
    private void 业下丞丙七与丝东丘(System.TimeSpan 丂三丟丂丈丐丆丗丟)
    {
        this.NextChestTimerLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6776"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = 丂三丟丂丈丐丆丗丟._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
    }
    private void 丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏)
    {
        GiftSettingType val_11;
        var val_12;
        System.Collections.Generic.Dictionary<GiftSettingType, System.String[]> val_13;
        val_11 = 丗丕下东丅丏丕上丏;
        if((this.东业丙丙丑丘世三下.TryGetValue(key:  上丞丕专丈业丁世专, value: out  0)) == false)
        {
            goto label_2;
        }
        
        val_12 = 0;
        goto label_3;
        label_11:
        this.ChestNameLabel[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  64);
        val_12 = 1;
        label_3:
        if(val_12 < this.ChestNameLabel.Length)
        {
            goto label_11;
        }
        
        label_2:
        val_13 = this.东业丙丙丑丘世三下;
        if((val_13.TryGetValue(key:  val_11, value: out  0)) == false)
        {
                return;
        }
        
        this.NextChestNameLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  135970152);
        val_13 = this.NextChestTextureComponent;
        val_11 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.IO.Path.Combine(path1:  this.丘丒东不丄业下丆东, path2:  this.上丑丁丑世丞丂七东 + val_11).ToLowerInvariant());
    }
    protected override void OnDisable()
    {
        var val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftInfoView.gameObject, 丏业丟一东丂东丘丛:  false);
        val_4 = null;
        val_4 = null;
        BankController.丂七上业下丆丄东丄 = true;
        this.丈丙丈丞一七且丟且 = true;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        UniversalRewardBanner.丝七丘丌丝业一丟丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void GiftBannerWindow::OnClickGift()));
        this.OnDisable();
    }
    public void ShowShop()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_1 = null;
        val_1 = null;
        if(GiftBannerWindow.丆且丌且丘上丁丄七 != false)
        {
                return;
        }
        
        this.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
        this.丑丑丆丂丒丆丐丛东 = true;
        val_2 = null;
        val_2 = null;
        GiftBannerWindow.丕丄丝丂丅东丆与不 = 0;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丏不丗不丁丏丞;
        val_5 = null;
        val_5 = null;
        MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  true, 丆丟七丝丏业丅上丄:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丘丏不丗不丁丏丞, 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
    }
    private void Update()
    {
        var val_11;
        var val_12;
        if(this.丑丑丆丂丒丆丐丛东 == false)
        {
            goto label_9;
        }
        
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() == false)
        {
            goto label_3;
        }
        
        if(MainStoreView.丈丐丞丐上丑且丕万() == false)
        {
            goto label_4;
        }
        
        goto label_9;
        label_3:
        if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
            goto label_9;
        }
        
        label_4:
        this.丑丑丆丂丒丆丐丛东 = false;
        this.丈丙丈丞一七且丟且 = true;
        this.OpenBannerWindow(丈丈不丒丗与丝不丗:  false);
        label_9:
        if(this.bannerObj.activeInHierarchy == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(GiftBannerWindow.丆且丌且丘上丁丄七 != false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.butBuy, 丏业丟一东丂东丘丛:  (~GiftController.丆丕丝丒不丙且丐丗.CanGetGift) & 1);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.butGift, 丏业丟一东丂东丘丛:  GiftController.丆丕丝丒不丙且丐丗.CanGetGift);
    }
    public void GetGift()
    {
        null = null;
        if(GiftBannerWindow.丆且丌且丘上丁丄七 != false)
        {
                return;
        }
        
        this.丏业丆丂与七与一万(丁七丑下丝不不丏丑:  false, 丒世丘丘上丆丝东丞:  0);
        this.丏上丂且世东丌丄丛();
    }
    public void OpenBannerWindow(bool 丈丈不丒丗与丝不丗 = True)
    {
        var val_2;
        var val_3;
        if(this.丑丑丆丂丒丆丐丛东 == true)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(GiftBannerWindow.与丌东下丙丕业三且 != false)
        {
                return;
        }
        
        if(丈丈不丒丗与丝不丗 != false)
        {
                PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        }
        
        if(this.丈丙丈丞一七且丟且 == false)
        {
                return;
        }
        
        this.SetVisibleBanner(下下丏一丙不丘丌丞:  true);
        this.丈丙丈丞一七且丟且 = false;
        this.scrollGift.SetCanDraggable(下下丏一丙不丘丌丞:  true);
        this.animatorBanner.SetTrigger(name:  "OpenGiftPanel");
        val_3 = null;
        val_3 = null;
        if(GiftScroll.丌一丆丛世业专三丑 == false)
        {
                return;
        }
        
        this.scrollGift.Sort(三丅万丒与丑且世业:  true);
    }
    private void 丏业丆丂与七与一万(bool 丁七丑下丝不不丏丑, 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞)
    {
        bool val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        GiftController val_35;
        var val_36;
        object val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        val_29 = 丁七丑下丝不不丏丑;
        val_30 = this;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  10);
        if(val_29 != true)
        {
                val_31 = null;
            val_31 = null;
            if(GiftController.丆丕丝丒不丙且丐丗.CanGetGift == false)
        {
                return;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() != false)
        {
                if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "GachaTrainingCompletedKey_180418", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 0)
        {
                val_32 = null;
            val_32 = null;
            MainMenuController.丄丞丁丈与业上丞丟.丛丟丒丈丅下且丙下(世三丐七丑丅专丏丞:  "gacha");
        }
        
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "GachaTrainingCompletedKey_180418", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_33 = null;
            val_33 = null;
            HideSmallHint();
            QuestsGSMAnager.丑七不且上丗丁一世().Check_NewsBox_Task();
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        BankController.且丗丛丏丂丒世丒业();
        BankController.丂七上业下丆丄东丄 = false;
        val_34 = null;
        val_34 = null;
        Rilisoft.丝丑丂丛万丐丈丘且 val_6 = GiftController.丆丕丝丒不丙且丐丗.万业丞丙丅丗东丁七();
        val_35 = GiftController.丆丕丝丒不丙且丐丗;
        SlotInfo val_8 = val_35.GetGift(丑丘丈丆丅丟丛丘丑:  val_29);
        if(val_8 == null)
        {
            goto label_34;
        }
        
        SlotInfo val_9 = val_8.世丘丙七世丕丌丄丌(专不丟丕丞丗三世丂:  val_8);
        this.丞与丝专一业丆丙且 = val_9;
        if(val_9 == null)
        {
            goto label_35;
        }
        
        if(val_9.gift == null)
        {
            goto label_36;
        }
        
        val_36 = null;
        val_36 = null;
        val_35 = this.丞与丝专一业丆丙且.gift.Id;
        Rilisoft.一丟专且三万丞丁丂.丄下丙丏丁丆丌七丙(三三专一业丘七丏丅:  val_29, 丑丞业丗丒三丂且东:  val_35, 丌丒丝东丌下丕丁丅:  this.丞与丝专一业丆丙且.gift.Count);
        Rilisoft.一丟专且三万丞丁丂.业丙世世世丛世丛丒(丏业丂七丈丆丛丏上:  -1187210752);
        Rilisoft.一丟专且三万丞丁丂.丛丒与丟丄丆丒世不(丏业丂七丈丆丛丏上:  丒世丘丘上丆丝东丞);
        goto label_46;
        label_35:
        val_37 = "GetGiftCore: awardSlot = null";
        goto label_49;
        label_36:
        val_37 = "GetGiftCore: awardSlot.gift = null";
        label_49:
        UnityEngine.Debug.LogError(message:  val_37);
        label_46:
        val_38 = null;
        val_38 = null;
        GiftBannerWindow.丆且丌且丘上丁丄七 = true;
        this.scrollGift.SetCanDraggable(下下丏一丙不丘丌丞:  false);
        this.scrollGift.AnimScrollGift(丙丐一丕丗万丁下一:  this.丞与丝专一业丆丙且.numInScroll);
        this.animatorBanner.SetTrigger(name:  "OpenGiftBtnRelease");
        val_39 = null;
        val_39 = null;
        GiftScroll.丌一丆丛世业专三丑 = false;
        val_40 = null;
        val_40 = null;
        GiftController.丆丕丝丒不丙且丐丗.ReCreateSlotsIfPossible();
        this.StartShowAwardGift();
        if(GiftBannerWindow.不七丄丂丌丘丘丈丈 != null)
        {
                0.Invoke();
        }
        
        this._freeSpinsText.gameObject.SetActive(value:  false);
        if(this.objSound == 0)
        {
            goto label_83;
        }
        
        if(this.丞下上且一上丙不丏 == 0)
        {
                UnityEngine.GameObject val_15 = 丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  this.objSound, 丒丘丏上丙丟丑丕丈:  "SoundGatchaInfoShow", 丟丝七七一丁丏丏丙:  true);
            if(val_15 != 0)
        {
                this.丞下上且一上丙不丏 = val_15.GetComponent<UnityEngine.AudioSource>();
        }
        
        }
        
        if(this.丞下上且一上丙不丏 == 0)
        {
            goto label_83;
        }
        
        GiftCategory val_19 = this.丞与丝专一业丆丙且.category;
        if(val_19.Type == 1)
        {
            goto label_89;
        }
        
        GiftCategory val_20 = this.丞与丝专一业丆丙且.category;
        if(val_20.Type == 2)
        {
            goto label_89;
        }
        
        GiftCategory val_21 = this.丞与丝专一业丆丙且.category;
        if(val_21.Type != 3)
        {
            goto label_92;
        }
        
        label_89:
        if(this.丞下上且一上丙不丏 != null)
        {
            goto label_105;
        }
        
        label_106:
        label_105:
        this.丞下上且一上丙不丏.enabled = false;
        label_83:
        val_41 = null;
        val_41 = null;
        val_29 = GiftController.丆丕丝丒不丙且丐丗.丅丒东丝上丌丗丒丞();
        GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丂丆一下丘丒丄万(一世与业专丅丕万丁:  GiftController.丆丕丝丒不丙且丐丗.丌三世丗一丙丂七丕(), 专与与丗七专丁丌丑:  val_29, 三一东世丆丕丞丂丞:  GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏);
        val_30 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_30.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_92:
        GiftCategory val_26 = this.丞与丝专一业丆丙且.category;
        var val_27 = (val_26.Type != 4) ? 1 : 0;
        if(this.丞下上且一上丙不丏 != null)
        {
            goto label_105;
        }
        
        goto label_106;
        label_34:
        System.Exception val_28 = new System.Exception(message:  "failed get gift");
    }
    private SlotInfo 世丘丙七世丕丌丄丌(SlotInfo 专不丟丕丞丗三世丂)
    {
        var val_5;
        int val_6;
        System.Collections.Generic.List<GiftCategory> val_7;
        SlotInfo val_1 = new SlotInfo();
        GiftInfo val_2 = new GiftInfo();
        if(val_1 != null)
        {
                val_5 = val_1;
            .gift = val_2;
        }
        else
        {
                val_5 = 40;
            mem[40] = val_2;
        }
        
        mem[1152921537779748832] = 专不丟丕丞丗三世丂.gift.Id;
        mem[1152921537779748816] = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>(collection:  专不丟丕丞丗三世丂.gift.Counts);
        mem[1152921537779748840] = 专不丟丕丞丗三世丂.gift.KeyTranslateInfo;
        val_6 = 专不丟丕丞丗三世丂.CountGift;
        if(val_1 != null)
        {
                val_1.CountGift = val_6;
            .numInScroll = 专不丟丕丞丗三世丂.numInScroll;
            val_7 = 专不丟丕丞丗三世丂.gifts;
        }
        else
        {
                val_1.CountGift = val_6;
            val_6 = 专不丟丕丞丗三世丂.numInScroll;
            mem[56] = val_6;
            val_7 = 专不丟丕丞丗三世丂.gifts;
        }
        
        .gifts = val_7;
        return val_1;
    }
    public void BuyCanGetGift()
    {
        object val_18;
        var val_19;
        var val_20;
        var val_21;
        丈丞丕丘丕丗与上一 val_22;
        丈丞丕丘丕丗与上一 val_23;
        var val_24;
        System.Action val_26;
        var val_27;
        var val_28;
        var val_29;
        GiftBannerWindow.丐上丆丙且丕上不专 val_1 = null;
        val_18 = val_1;
        val_1 = new GiftBannerWindow.丐上丆丙且丕上不专();
        .丝且与丝丒丟万丁专 = this;
        val_19 = null;
        val_19 = null;
        if(GiftBannerWindow.丆且丌且丘上丁丄七 == true)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = GiftController.丆丕丝丒不丙且丐丗.万业丞丙丅丗东丁七();
        val_21 = null;
        val_21 = null;
        丈丞丕丘丕丗与上一 val_3 = null;
        val_22 = val_3;
        val_3 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  -1186658928, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        .丄丛丟丒丞专丟丞丗 = val_22;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  (GiftBannerWindow.丐上丆丙且丕上不专)[1152921537779970528].丄丛丟丒丞专丟丞丗.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_14;
        }
        
        }
        
        .丕与丄丂七丁与万丂 = false;
        val_23 = (GiftBannerWindow.丐上丆丙且丕上不专)[1152921537779970528].丄丛丟丒丞专丟丞丗;
        System.Action val_12 = null;
        val_22 = val_12;
        val_12 = new System.Action(object:  val_1, method:  System.Void GiftBannerWindow.丐上丆丙且丕上不专::三一丌三丝万丞不且());
        val_24 = null;
        val_24 = null;
        val_26 = GiftBannerWindow.<>c.<>9__76_1;
        if(val_26 == null)
        {
                System.Action val_13 = null;
            val_26 = val_13;
            val_13 = new System.Action(object:  GiftBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GiftBannerWindow.<>c::丄且丞且世丌丁上丁());
            GiftBannerWindow.<>c.<>9__76_1 = val_26;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.transform.root.gameObject, 丒世丘丘上丆丝东丞:  val_23, 七丒上且丝业业下七:  val_12, 丝丏丗丄丗与丐丌三:  val_13, 丒七丒丌世丘丑丂七:  new System.Action(object:  val_1, method:  System.Void GiftBannerWindow.丐上丆丙且丕上不专::一丄丞一丒丞丟专不()), 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  75);
        if((GiftBannerWindow.丐上丆丙且丕上不专)[1152921537779970528].丕与丄丂七丁与万丂 != true)
        {
                this.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
        }
        
        this.七上丄不丛不丘丐丈();
        return;
        label_14:
        UnityEngine.Debug.LogError(message:  "Gatcha (not enough currency) -> GoToMainStore");
        this.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
        this.丑丑丆丂丒丆丐丛东 = true;
        val_27 = null;
        val_27 = null;
        GiftBannerWindow.丕丄丝丂丅东丆与不 = 0;
        val_28 = null;
        val_28 = null;
        val_29 = null;
        val_29 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.七东丐丁丏丑丑丄与;
        val_18 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        val_23 = (GiftBannerWindow.丐上丆丙且丕上不专)[1152921537779970528].丄丛丟丒丞专丟丞丗.东与三丌丅三丒丏业();
        val_18.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_23, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.七东丐丁丏丑丑丄与, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    public void StartShowAwardGift()
    {
        if(this.丞与丝专一业丆丙且 != null)
        {
                this.且上丁一丞丞上不上 = false;
            this.curStateAnimAward = 1;
            AnimationGift.丄丘七三上丕世丞业.StartAnimForGetGift();
            if(this.丂丑丘丕万专丌丆丒 != null)
        {
                this.StopCoroutine(routine:  this.丂丑丘丕万专丌丆丒);
        }
        
            var val_5 = 0;
            val_5 = val_5 + 1;
        }
        else
        {
                this.CloseInfoGift(丘上丅丝丄三一丕丁:  false);
            return;
        }
        
        this.丂丑丘丕万专丌丆丒 = this.StartCoroutine(routine:  this.与东三东丌丙且七与(丕丕世且下一与丝与:  this.业丈丅下专东丛七上).GetEnumerator());
    }
    public void OnClickGift()
    {
        if(this.且上丁一丞丞上不上 == false)
        {
                return;
        }
        
        this.丑与丛世丘丌三丒世();
    }
    private System.Collections.IEnumerable 与东三东丌丙且七与(float 丕丕世且下一与丝与)
    {
        GiftBannerWindow.丂丄丆丏丞世丘丛专 val_1 = new GiftBannerWindow.丂丄丆丏丞世丘丛专();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    private void 丑与丛世丘丌三丒世()
    {
        goto label_0;
        label_2:
        if(this.丂丑丘丕万专丌丆丒 != null)
        {
                this.StopCoroutine(routine:  this.丂丑丘丕万专丌丆丒);
        }
        
        this.curStateAnimAward = 2;
        this.curStateAnimAward = this.curStateAnimAward;
        label_0:
        if(this.curStateAnimAward == 1)
        {
            goto label_2;
        }
        
        if(this.curStateAnimAward != 2)
        {
                if(this.curStateAnimAward != 3)
        {
                return;
        }
        
            this.CloseInfoGift(丘上丅丝丄三一丕丁:  false);
            return;
        }
        
        this.万三与丗丑丅不业丅 = this.StartCoroutine(routine:  this.丅万丘且丒丗丞丈丁());
    }
    public void ShowInfo(SlotInfo 与丂上上下丗上一三)
    {
        this.giftInfoView.gameObject.SetActive(value:  false);
        GiftCategory val_2 = 与丂上上下丗上一三.category;
        if(val_2.Type == 9)
        {
            goto label_102;
        }
        
        GiftCategory val_3 = 与丂上上下丗上一三.category;
        if(val_3.Type == 10)
        {
            goto label_102;
        }
        
        GiftCategory val_4 = 与丂上上下丗上一三.category;
        if(val_4.Type == 15)
        {
            goto label_102;
        }
        
        GiftCategory val_5 = 与丂上上下丗上一三.category;
        if(val_5.Type == 66)
        {
            goto label_102;
        }
        
        GiftCategory val_6 = 与丂上上下丗上一三.category;
        if(val_6.Type == 67)
        {
            goto label_102;
        }
        
        GiftCategory val_7 = 与丂上上下丗上一三.category;
        if(val_7.Type == 70)
        {
            goto label_102;
        }
        
        GiftCategory val_8 = 与丂上上下丗上一三.category;
        if(val_8.Type == 68)
        {
            goto label_102;
        }
        
        GiftCategory val_9 = 与丂上上下丗上一三.category;
        if(val_9.Type == 69)
        {
            goto label_102;
        }
        
        GiftCategory val_10 = 与丂上上下丗上一三.category;
        if(val_10.Type != 71)
        {
            goto label_29;
        }
        
        label_102:
        三丅丁丗丗丝丂万且 val_11 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与丂上上下丗上一三.gift.Id);
        if(val_11 != null)
        {
                if(val_11.东七与与不丅丙上上() == false)
        {
            goto label_35;
        }
        
        }
        
        label_103:
        this.giftInfoView.丂业丑丆丈上且丞丂(丘丌丛业丄丘丗世丐:  与丂上上下丗上一三);
        return;
        label_35:
        ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  true);
        UnityEngine.Object val_18 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForEvent"));
        if(val_18 != null)
        {
                var val_19 = (null == null) ? (val_18) : 0;
        }
        
        ArmoryInfoScreenController val_20 = 0.GetComponent<ArmoryInfoScreenController>();
        this.下丏丗且丅丟丄丂与 = val_20;
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_20.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Banners"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>().depth = 110;
        this.下丏丗且丅丟丄丂与.transform.parent = this.transform;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.下丏丗且丅丟丄丂与.丙业丁丅丗万丞丙且 = true;
        this.下丏丗且丅丟丄丂与.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_11.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_11.万上丄下业丛丌不丈() - 1), 丁业丗丈丂七丟东与:  true, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
        return;
        label_29:
        GiftCategory val_30 = 与丂上上下丗上一三.category;
        if(val_30.Type < 16)
        {
            goto label_60;
        }
        
        GiftCategory val_31 = 与丂上上下丗上一三.category;
        if(val_31.Type < 66)
        {
            goto label_102;
        }
        
        label_60:
        GiftCategory val_32 = 与丂上上下丗上一三.category;
        if(val_32.Type < 78)
        {
            goto label_66;
        }
        
        GiftCategory val_33 = 与丂上上下丗上一三.category;
        if(val_33.Type < 128)
        {
            goto label_102;
        }
        
        label_66:
        GiftCategory val_34 = 与丂上上下丗上一三.category;
        if(val_34.Type < 128)
        {
            goto label_72;
        }
        
        GiftCategory val_35 = 与丂上上下丗上一三.category;
        if(val_35.Type < 178)
        {
            goto label_102;
        }
        
        label_72:
        GiftCategory val_36 = 与丂上上下丗上一三.category;
        if(val_36.Type == 73)
        {
            goto label_102;
        }
        
        GiftCategory val_37 = 与丂上上下丗上一三.category;
        if(val_37.Type == 72)
        {
            goto label_102;
        }
        
        GiftCategory val_38 = 与丂上上下丗上一三.category;
        if(val_38.Type == 77)
        {
            goto label_102;
        }
        
        GiftCategory val_39 = 与丂上上下丗上一三.category;
        if(val_39.Type == 76)
        {
            goto label_102;
        }
        
        GiftCategory val_40 = 与丂上上下丗上一三.category;
        if(val_40.Type == 75)
        {
            goto label_102;
        }
        
        GiftCategory val_41 = 与丂上上下丗上一三.category;
        if(val_41.Type == 74)
        {
            goto label_102;
        }
        
        GiftCategory val_42 = 与丂上上下丗上一三.category;
        if(val_42.Type == 11)
        {
            goto label_102;
        }
        
        GiftCategory val_43 = 与丂上上下丗上一三.category;
        if(val_43.Type == 12)
        {
            goto label_102;
        }
        
        GiftCategory val_44 = 与丂上上下丗上一三.category;
        if(val_44.Type == 9999)
        {
            goto label_102;
        }
        
        goto label_103;
    }
    private System.Collections.IEnumerator 丅万丘且丒丗丞丈丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftBannerWindow.丄世不专丛万下丝丙();
    }
    public void CloseInfoGift(bool 丘上丅丝丄三一丕丁 = False)
    {
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Action val_28;
        var val_29;
        var val_30;
        this.且上丁一丞丞上不上 = true;
        if(this.丂丑丘丕万专丌丆丒 != null)
        {
                this.StopCoroutine(routine:  this.丂丑丘丕万专丌丆丒);
        }
        
        SpringPanel val_1 = this.scrollGift.GetComponent<SpringPanel>();
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
        {
                UnityEngine.Object.Destroy(obj:  val_1);
        }
        
        if(this.万三与丗丑丅不业丅 != null)
        {
                this.StopCoroutine(routine:  this.万三与丗丑丅不业丅);
        }
        
        this.animatorBanner.SetTrigger(name:  "GiftInfoClose");
        this.万三与丗丑丅不业丅 = 0;
        this.curStateAnimAward = 0;
        if(this.三三万丈丕丁丅丏丆 != false)
        {
                this.CloseBanner();
        }
        
        val_21 = null;
        val_21 = null;
        GiftScroll.丌一丆丛世业专三丑 = true;
        this.七上丄不丛不丘丐丈();
        this.丏上丂且世东丌丄丛();
        val_22 = null;
        val_22 = null;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.butBuy, 丏业丟一东丂东丘丛:  (~GiftController.丆丕丝丒不丙且丐丗.CanGetGift) & 1);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.butGift, 丏业丟一东丂东丘丛:  GiftController.丆丕丝丒不丙且丐丗.CanGetGift);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丕丕七世丁丘东与丒(丕丕世且下一与丝与:  1.5f));
        if(Rilisoft.GachaRewardedVideoController.丑七不且上丗丁一世() != 0)
        {
                Rilisoft.GachaRewardedVideoController.丑七不且上丗丁一世().RefreshGui();
        }
        
        if(this.scrollGift != 0)
        {
                this.scrollGift.UpdateListButton();
        }
        
        val_23 = null;
        val_23 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.丟专不专丑丆且丗丕 == false)
        {
            goto label_30;
        }
        
        val_24 = 1152921537781501472;
        val_25 = 0;
        goto label_31;
        label_37:
        this.scrollGift.listButton.Item[0].丟丈丂丗丘丂丗丏一(丐业丂丕丅一丟不且:  true);
        val_25 = 1;
        label_31:
        if(val_25 < this.scrollGift.listButton.Count)
        {
            goto label_37;
        }
        
        goto label_38;
        label_30:
        val_24 = 1152921537781501472;
        val_26 = 0;
        goto label_39;
        label_45:
        this.scrollGift.listButton.Item[0].世丁丛三东七丁丁丟(丕丕世且下一与丝与:  1f, 世东不与七丗丒业一:  0.7f);
        val_26 = 1;
        label_39:
        if(val_26 < this.scrollGift.listButton.Count)
        {
            goto label_45;
        }
        
        label_38:
        val_27 = null;
        val_27 = null;
        val_28 = GiftBannerWindow.丐三一丛专丁丈丙丅;
        if(val_28 != null)
        {
                val_28 = GiftBannerWindow.丐三一丛专丁丈丙丅;
            if(val_28 == null)
        {
                val_28 = 0;
        }
        
            val_28.Invoke();
        }
        
        UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.丄丐丒丗且丝下与丑());
        if(丘上丅丝丄三一丕丁 != true)
        {
                if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
                AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
            this.ForceCloseAll();
        }
        
        }
        
        val_29 = null;
        val_29 = null;
        if(GiftController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        GiftController.丆丕丝丒不丙且丐丗.CheckIfAllItemsGot(东丙丗专丒丆与丕丒:  true);
    }
    private System.Collections.IEnumerator 丄丐丒丗且丝下与丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftBannerWindow.丅丞专丑丄丑丝且丅();
    }
    private System.Collections.IEnumerator 丕丕七世丁丘东与丒(float 丕丕世且下一与丝与)
    {
        GiftBannerWindow.丝丑丑丂三丘万不丄 val_1 = new GiftBannerWindow.丝丑丑丂三丘万不丄();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    public void CloseBanner()
    {
        var val_8;
        var val_9;
        System.Action val_10;
        if(this.丑丑丆丂丒丆丐丛东 == true)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(GiftBannerWindow.丆且丌且丘上丁丄七 != false)
        {
                if(this.三三万丈丕丁丅丏丆 == false)
        {
                return;
        }
        
        }
        
        if((((UnityEngine.Object.op_Implicit(exists:  BannerWindowController.与丅与丒丅专丙丐丗())) != false) && (this.bannerObj != 0)) && (this.bannerObj.activeSelf != false))
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            this.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
            val_9 = null;
            val_9 = null;
            val_10 = GiftBannerWindow.丟不丒万丝与丂上丘;
            if(val_10 != null)
        {
                val_10 = GiftBannerWindow.丟不丒万丝与丂上丘;
            if(val_10 == null)
        {
                val_10 = 0;
        }
        
            val_10.Invoke();
            val_9 = null;
        }
        
            val_9 = null;
            GiftBannerWindow.丘丆且七丑丘且专丟 = false;
            MainMenuHeroCamera.丑七不且上丗丁一世().PlayCloseGift();
            UnityEngine.Coroutine val_7 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void GiftBannerWindow::丙丟丙一丙上丙专丝()), 丆丐七丅丆丗丛上与:  0.7f);
        }
        
        this.三三万丈丕丁丅丏丆 = false;
    }
    public void CloseBannerEndAnimtion()
    {
        var val_4;
        var val_5;
        var val_6;
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        this.SetVisibleBanner(下下丏一丙不丘丌丞:  true);
        val_4 = null;
        val_4 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_5 = null;
            val_5 = null;
            MainMenuController.丄丞丁丈与业上丞丟.ShowSavePanel(丁丗丏东七不丞丒丄:  true);
        }
        
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
        val_6 = null;
        val_6 = null;
        if(GiftBannerWindow.丕丄丝丂丅东丆与不 == null)
        {
                return;
        }
        
        GiftBannerWindow.丕丄丝丂丅东丆与不.Invoke();
    }
    public void SetVisibleBanner(bool 下下丏一丙不丘丌丞)
    {
        if(this.bannerObj == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.bannerObj, 丏业丟一东丂东丘丛:  下下丏一丙不丘丌丞);
    }
    private void 七上丄不丛不丘丐丈()
    {
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        object val_19;
        var val_20;
        bool val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_15 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2196");
        val_16 = null;
        val_16 = null;
        GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏
        if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift != false)
        {
                var val_3 = (GiftController.丆丕丝丒不丙且丐丗.业丁业世丐七丗丄丐 == true) ? 1 : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        val_18 = null;
        val_18 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.CanGetFreeSpinGift != false)
        {
                if(GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏.七丄不丐丗三丝丑一 > 1)
        {
                val_19 = GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏.七丄不丐丗三丝丑一.ToString();
        }
        else
        {
                val_19 = "";
        }
        
            val_15 = System.String.Format(format:  val_15, arg0:  val_19);
        }
        
        this._freeSpinsText.Text = val_15;
        val_20 = null;
        val_20 = null;
        val_21 = GiftController.丆丕丝丒不丙且丐丗.CanGetFreeSpinGift & ((GiftController.丆丕丝丒不丙且丐丗.丈不万丑丙丟丙丒丏.七丄不丐丗三丝丑一 > 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeSpinsText.gameObject, 丏业丟一东丂东丘丛:  val_21);
        val_22 = 0;
        goto label_22;
        label_34:
        val_23 = null;
        val_23 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift != false)
        {
                var val_12 = (GiftController.丆丕丝丒不丙且丐丗.业丁业世丐七丗丄丐 == true) ? 1 : 0;
        }
        else
        {
                val_21 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lbTimer[0].gameObject, 丏业丟一东丂东丘丛:  val_21 ^ 1);
        val_22 = 1;
        label_22:
        if(val_22 < this.lbTimer.Length)
        {
            goto label_34;
        }
        
        val_24 = null;
        val_24 = null;
        if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift != false)
        {
                var val_15 = (GiftController.丆丕丝丒不丙且丐丗.业丁业世丐七丗丄丐 == false) ? 1 : 0;
        }
        else
        {
                val_25 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.objLabelTapGift, 丏业丟一东丂东丘丛:  true);
    }
    private void 丏上丂且世东丌丄丛()
    {
        var val_3;
        var val_4;
        val_3 = 0;
        goto label_1;
        label_8:
        val_4 = null;
        val_4 = null;
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = GiftController.丆丕丝丒不丙且丐丗.万业丞丙丅丗东丁七();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.lbPriceForBuy, 丕丗丘丑丛与丑业丒:  val_1.七丄不丐丗三丝丑一.ToString());
        val_3 = 1;
        label_1:
        if(val_3 < this.lbPriceForBuy.Length)
        {
            goto label_8;
        }
    
    }
    public void ShowDarkFon()
    {
    
    }
    public void HideDarkFon()
    {
    
    }
    public void AnimFonShow(bool 下下丏一丙不丘丌丞)
    {
        if(this.sprDarkFon == 0)
        {
                return;
        }
        
        if(下下丏一丙不丘丌丞 != false)
        {
            
        }
        
        TweenAlpha val_3 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this.sprDarkFon.gameObject, 与丈业丛丝丒丙一丏:  0.1f, 与专丌丅丙上丌一丄:  0f);
    }
    private void 丁丕丅丗东业丁业丆(string 且万万东丏且万下丐)
    {
        var val_1;
        this.七上丄不丛不丘丐丈();
        val_1 = 0;
        goto label_1;
        label_7:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lbTimer[0], 丕丗丘丑丛与丑业丒:  且万万东丏且万下丐);
        val_1 = 1;
        label_1:
        if(val_1 < this.lbTimer.Length)
        {
            goto label_7;
        }
    
    }
    private void 丅专丁丑丅丒东丑丛()
    {
        this.七上丄不丛不丘丐丈();
    }
    private void 丟丞丄丙丕丈世专丏()
    {
        if(this.curStateAnimAward != 0)
        {
                this.三三万丈丕丁丅丏丆 = true;
            return;
        }
        
        this.CloseBanner();
    }
    private void OnApplicationPause(bool 丄七丙不丟丛与丏丐)
    {
        this.giftInfoView.gameObject.SetActive(value:  false);
        if(this.下丏丗且丅丟丄丂与 != 0)
        {
            goto label_5;
        }
        
        if(丄七丙不丟丛与丏丐 == false)
        {
            goto label_6;
        }
        
        return;
        label_5:
        this.下丏丗且丅丟丄丂与.Close();
        if(丄七丙不丟丛与丏丐 == true)
        {
                return;
        }
        
        label_6:
        this.ForceCloseAll();
    }
    public void ForceCloseAll()
    {
        var val_9;
        var val_10;
        var val_12;
        var val_13;
        if(MainStoreView.丈丐丞丐上丑且丕万() != true)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == false)
        {
            goto label_5;
        }
        
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "ForceCloseAll return");
        return;
        label_5:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "ForceCloseAll CLOSE");
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.giftInfoView.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this.下丏丗且丅丟丄丂与 != 0)
        {
                this.下丏丗且丅丟丄丂与.Close();
        }
        
        val_9 = null;
        val_9 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(this.curStateAnimAward != 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(GiftBannerWindow.丘丆且七丑丘且专丟 == false)
        {
                return;
        }
        
        val_10 = null;
        GiftBannerWindow.丘丆且七丑丘且专丟 = false;
        GiftBannerWindow.与丌东下丙丕业三且 = true;
        this.丈丙丈丞一七且丟且 = true;
        GiftBannerWindow.丆且丌且丘上丁丄七 = false;
        val_12 = null;
        val_12 = null;
        BankController.丂七上业下丆丄东丄 = true;
        this.且上丁一丞丞上不上 = true;
        this.CloseInfoGift(丘上丅丝丄三一丕丁:  true);
        this.SetVisibleBanner(下下丏一丙不丘丌丞:  false);
        val_13 = null;
        val_13 = null;
        MainMenuController.丞且丙丛丞不世专七 = true;
        if(GiftBannerWindow.丟不丒万丝与丂上丘 != null)
        {
                0.Invoke();
        }
        
        MainMenuHeroCamera.丑七不且上丗丁一世().PlayCloseGift();
        if(AnimationGift.丄丘七三上丕世丞业 != 0)
        {
                AnimationGift.丄丘七三上丕世丞业.ResetAnimation();
            AnimationGift.丄丘七三上丕世丞业.CheckVisibleGift();
        }
        
        this.curStateAnimAward = 0;
    }
    public void UpdateSizeScroll()
    {
        var val_11;
        var val_12;
        int val_1 = this.scrollGift.listButton.Count;
        var val_2 = (val_1 < 7) ? (val_1) : 7;
        int val_11 = this.scrollGift.wrapScript.itemSize;
        val_2 = val_2 - 1;
        UIPanel val_3 = this.scrollGift.scrollView.panel;
        val_11 = val_11 * val_2;
        UnityEngine.Vector2 val_4 = this.sprFonScroll.localSize;
        this.sprFonScroll.SetDimensions(与丘东下丈东丛丂万:  val_11 + 30, 一丗世三专三万丞丞:  (int)val_4.y);
        if(val_3 != null)
        {
                UnityEngine.Vector4 val_6 = val_3.baseClipRegion;
            val_11 = val_6.x;
            UnityEngine.Vector4 val_7 = val_3.baseClipRegion;
            val_12 = val_7.y;
        }
        else
        {
                UnityEngine.Vector4 val_8 = 0.baseClipRegion;
            val_11 = val_8.x;
            UnityEngine.Vector4 val_9 = 0.baseClipRegion;
            val_12 = val_9.y;
        }
        
        UnityEngine.Vector4 val_10 = val_3.baseClipRegion;
        val_3.baseClipRegion = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    private void 丒丒丛且丌丁丗丂一()
    {
        this.ForceCloseAll();
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return true;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public GiftBannerWindow()
    {
        this._prefabHandler = new Rilisoft.PrefabHandler();
        this.且上丁一丞丞上不上 = true;
        this.业丈丅下专东丛七上 = 6.5f;
        this.丈丙丈丞一七且丟且 = true;
        this.speedAnimCenter = 2f;
        System.Collections.Generic.Dictionary<GiftSettingType, System.String[]> val_2 = new System.Collections.Generic.Dictionary<GiftSettingType, System.String[]>();
        string[] val_3 = new string[2];
        val_3[0] = "Key_6767";
        val_3[1] = "Key_6777";
        val_2.Add(key:  2, value:  val_3);
        string[] val_4 = new string[2];
        val_4[0] = "Key_6768";
        val_4[1] = "Key_6778";
        val_2.Add(key:  3, value:  val_4);
        string[] val_5 = new string[2];
        val_5[0] = "Key_6769";
        val_5[1] = "Key_6779";
        val_2.Add(key:  4, value:  val_5);
        string[] val_6 = new string[2];
        val_6[0] = "Key_6770";
        val_6[1] = "Key_6780";
        val_2.Add(key:  5, value:  val_6);
        this.东业丙丙丑丘世三下 = val_2;
        this.丘丒东不丄业下丆东 = "LuckyChest";
        this.上丑丁丑世丞丂七东 = "lucky_chest_next_";
    }
    private static GiftBannerWindow()
    {
    
    }
    private void 丙丟丙一丙上丙专丝()
    {
        if(this == 0)
        {
                return;
        }
        
        this.HideSelf();
    }

}
