using UnityEngine;
internal sealed class MainStoreView : PGBehaviour
{
    // Fields
    private static System.Action 与业丑丅丁丌丛丑丒;
    private static System.Action 丝上丂一不专丂丄不;
    private static System.Action<PGCompany.MainStore.世专丟丕丝丝专东一> 丑下丄上丞丙丒三三;
    private static MainStoreView 丝业丆丁业三丈丟东;
    private System.Collections.Generic.List<MainStoreView.MainStoreTypeSettings> storeTypeSettingsList;
    private UILabel headerLabel;
    private BannerWindowWithBack _bannerWindow;
    private UnityEngine.GameObject _holder;
    private MainStoreSectionTab sectionTab;
    private MiniPoolMonoBehaviour sectionViewPool;
    private WidgetLayout widgetLayout;
    private ScrollViewHelper srollViewHelper;
    private UnityEngine.Transform selectSectionPoint;
    private float scrollDelta;
    private float tutorialDelta;
    private MiniPoolGroup storePromotionPoolGroup;
    private UnityEngine.Transform promotionInfoUIHolder;
    private PGCompany.StorePromotionInfoUIAbstract currentPromotionInfoUI;
    private System.Collections.Generic.List<UIRect> holderPanels;
    private PanelAnchor panelAnchor;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private UIWidget lauputWidget;
    private System.Collections.Generic.List<UnityEngine.GameObject> showToNonPaingUsers;
    private GuiApplyersGroup guiApplyersGroup;
    private float messageTime;
    private UnityEngine.GameObject purchaseConfirmationHolder;
    private UnityEngine.GameObject messageLabelHolder;
    private UILabel messageLabel;
    private LoadingAnimation loadingAnimation;
    private Rilisoft.BankBannersHolder bannersHolder;
    private UnityEngine.GameObject loginMessageHolder;
    private UILabel loginMessageLabel;
    private UILabel messageLable;
    private ItemListFromInventoryUI currencyUI;
    private string <丑丈丆丑下丘上上丑>k__BackingField;
    private readonly System.Collections.Generic.Dictionary<string, PGCompany.MainStore.世专丟丕丝丝专东一> 与丐三丞丕且丕三专;
    private System.Collections.Generic.List<PGCompany.MainStore.丐丑丂上丑丑东丒丞> 丟世世丞丘业丌丒丆;
    private readonly System.Collections.Generic.Dictionary<string, MainStoreSectionView> 丘丄丑丂丄下丝丝业;
    private MainStoreSectionView 不丑一丗丌丒不丐一;
    private System.Collections.Generic.Dictionary<string, string> 丞三东业丝丌丈丞丐;
    private static bool <不丟东上丂丘一不万>k__BackingField;
    private bool 丑丑丏丒世七丈东与;
    private string 丆与与丄与业丈与三;
    private UnityEngine.Color 不丂丝丘丅三且与丒;
    private bool 丛一上丗世丅丂丑丈;
    private bool 万丆丒七丑不丈世丈;
    private PreviewOfferPackController _previewOfferPackController;
    private PGCompany.东丑丆丗丏丐丟下丄 与丈万一三不丁下上;
    internal float TMP_ScrollToRightDelta;
    private string 丌丆世丏丙丛丙七丞;
    
    // Properties
    internal static MainStoreView 丆丕丝丒不丙且丐丗 { get; }
    internal UnityEngine.GameObject 不丏丌丈丈丗万七丏 { get; }
    internal string 七丈东不东专丅丈与 { get; set; }
    internal MainStoreSectionView 丏上丄世三丅东丝不 { get; }
    private System.Collections.Generic.Dictionary<string, string> 丁丝丈丄上不不与且 { get; }
    internal static bool 丅业东万丌丕上丌丄 { get; set; }
    
    // Methods
    internal static void 一与与一世丑丒与丛(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  MainStoreView.与业丑丅丁丌丛丑丒, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丟丂万与万与丆丄丌(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  MainStoreView.与业丑丅丁丌丛丑丒, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 东丑业丒且业丌丝丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  MainStoreView.丝上丂一不专丂丄不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(MainStoreView.丝上丂一不专丂丄不 != 1152921505270693896);
    
    }
    internal static void 丝七一不与不丙丕丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  MainStoreView.丝上丂一不专丂丄不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(MainStoreView.丝上丂一不专丂丄不 != 1152921505270693896);
    
    }
    internal static void 专丝丅三丕丌丑丌丅(System.Action<PGCompany.MainStore.世专丟丕丝丝专东一> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  MainStoreView.丑下丄上丞丙丒三三, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(MainStoreView.丑下丄上丞丙丒三三 != 1152921505270693904);
    
    }
    internal static void 丑丐万丅下万丟万万(System.Action<PGCompany.MainStore.世专丟丕丝丝专东一> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  MainStoreView.丑下丄上丞丙丒三三, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(MainStoreView.丑下丄上丞丙丒三三 != 1152921505270693904);
    
    }
    internal static MainStoreView 丑七不且上丗丁一世()
    {
        return (MainStoreView)MainStoreView.丝业丆丁业三丈丟东;
    }
    internal UnityEngine.GameObject 三下且丁专业丝丅丙()
    {
        return (UnityEngine.GameObject)this._holder;
    }
    internal string 丈丑丏三丅丟丈东下()
    {
        return (string)this.<丑丈丆丑下丘上上丑>k__BackingField;
    }
    private void 丂丛丟丌丈世丗丟一(string 丙业与丙丗丝不丈东)
    {
        this.<丑丈丆丑下丘上上丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal MainStoreSectionView 丛丝东丟丁下丘与丘()
    {
        return (MainStoreSectionView)this.不丑一丗丌丒不丐一;
    }
    private System.Collections.Generic.Dictionary<string, string> 丟丆不上丝丁专一丅()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.丞三东业丝丌丈丞丐;
        if(val_2 != null)
        {
                return val_2;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        this.丞三东业丝丌丈丞丐 = val_1;
        val_1.Add(key:  "GemsCurrency", value:  "gems");
        this.丞三东业丝丌丈丞丐.Add(key:  "Gems", value:  "gems");
        this.丞三东业丝丌丈丞丐.Add(key:  "CoinsCurrency", value:  "coins");
        this.丞三东业丝丌丈丞丐.Add(key:  "Coins", value:  "coins");
        this.丞三东业丝丌丈丞丐.Add(key:  "EventStore", value:  "event");
        this.丞三东业丝丌丈丞丐.Add(key:  "Event", value:  "event");
        this.丞三东业丝丌丈丞丐.Add(key:  "offers", value:  "adaptive");
        this.丞三东业丝丌丈丞丐.Add(key:  "ClanSilver", value:  "silver");
        this.丞三东业丝丌丈丞丐.Add(key:  "lobby", value:  "offerslobby");
        this.丞三东业丝丌丈丞丐.Add(key:  "pixelcurrency", value:  "pixelcurrency");
        this.丞三东业丝丌丈丞丐.Add(key:  "PixelPassCurrency", value:  "pixelcurrency");
        this.丞三东业丝丌丈丞丐.Add(key:  "subscriptions_v2", value:  "subscriptions_v2");
        val_2 = this.丞三东业丝丌丈丞丐;
        return val_2;
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        return (bool)MainStoreView.<不丟东上丂丘一不万>k__BackingField;
    }
    private static void 七丝丆丂丞丙丆丟三(bool 丙业与丙丗丝不丈东)
    {
        MainStoreView.<不丟东上丂丘一不万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void OnEnable()
    {
        MainStoreView.丝业丆丁业三丈丟东 = this;
    }
    internal void 丝东丐丝东三丈世丝()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.currentPromotionInfoUI, y:  0);
        if(this._bannerWindow == null)
        {
            
        }
    
    }
    internal void 业丙丘丈七不下下丐()
    {
        this.与丟丅丌丘且丞业丞(丛丅丘一丏丙且丌上:  false);
        UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        this.不丂丝丘丅三且与丒 = val_1;
        mem[1152921539266901268] = val_1.g;
        mem[1152921539266901272] = val_1.b;
        mem[1152921539266901276] = val_1.a;
        this.丛一上丗世丅丂丑丈 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        this.丅七丐不丒丛丞三丌(丙业与丙丗丝不丈东:  true);
        this.丌丞下万丈丒丑万丅();
        this.丑丏上丈丒丂且丞丛();
        MainStoreView.<不丟东上丂丘一不万>k__BackingField = true;
        if(MainStoreView.与业丑丅丁丌丛丑丒 == null)
        {
                return;
        }
        
        MainStoreView.与业丑丅丁丌丛丑丒.Invoke();
    }
    internal void 丛丄业丘不丆丄三丞()
    {
        this.丌丞下万丈丒丑万丅();
        this.丅七丐不丒丛丞三丌(丙业与丙丗丝不丈东:  false);
        this.与丟丅丌丘且丞业丞(丛丅丘一丏丙且丌上:  true);
        this.不丑一丗丌丒不丐一 = 0;
        MainStoreView.<不丟东上丂丘一不万>k__BackingField = false;
        if(MainStoreView.丝上丂一不专丂丄不 == null)
        {
                return;
        }
        
        MainStoreView.丝上丂一不专丂丄不.Invoke();
    }
    private void 丑丏上丈丒丂且丞丛()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.世不丅丆丁下丁丌东(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void MainStoreView::万丈下丞专丁丙一丈(string 不丝丐与丑一丈丌世)));
        PGCompany.StorePromotionInfoUIAbstract.世丌下与丁与与丛丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void MainStoreView::丙丈东且丛丞上丏不(PGCompany.StorePromotionInfoUIAbstract 专上丄丂丙下丑东丆)));
        PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void MainStoreView::丈丝下丛专三丐丛且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 万且万且丑丗且丌丆)));
        Rilisoft.丗下丙丅且丐丞丙世.业丕上上东东丒七丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆下丐丁丏世丈上丟>(object:  this, method:  System.Void MainStoreView::七世且丙业丑丐丐东(PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)));
        StoreKitEventListener.一万丟丌东丈丄三一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void MainStoreView::丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)));
        this.srollViewHelper.丞且丐丂丞丆三丈丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreView::且丙三业丏丘且一世()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreView::业丕丐丝与丄丏丆丂()));
        PGCompany.MainStore.下一丁业丝专丈三三.七下不丅一一丛不丐(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void MainStoreView::东丅不丕丌上不三丙(string 丈丐丈不丞丑世专下)));
    }
    private void 丌丞下万丈丒丑万丅()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.丗与下丕三专业丟业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void MainStoreView::万丈下丞专丁丙一丈(string 不丝丐与丑一丈丌世)));
        PGCompany.StorePromotionInfoUIAbstract.丆丘世丁丈丅万业专(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void MainStoreView::丙丈东且丛丞上丏不(PGCompany.StorePromotionInfoUIAbstract 专上丄丂丙下丑东丆)));
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void MainStoreView::丈丝下丛专三丐丛且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 万且万且丑丗且丌丆)));
        Rilisoft.丗下丙丅且丐丞丙世.丅下丞丕丆丅世丐丒(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆下丐丁丏世丈上丟>(object:  this, method:  System.Void MainStoreView::七世且丙业丑丐丐东(PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)));
        StoreKitEventListener.丛丈专丑上丙丕丗丝(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void MainStoreView::丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)));
        this.srollViewHelper.下一专业丞万丒丝不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreView::且丙三业丏丘且一世()));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreView::业丕丐丝与丄丏丆丂()));
        PGCompany.MainStore.下一丁业丝专丈三三.世三丂丙不丅丛丈丑(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void MainStoreView::东丅不丕丌上不三丙(string 丈丐丈不丞丑世专下)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丕丐世下万丛丛丅丞 丌丟丝丟丆丂世丝丆)
    {
        var val_43;
        PGCompany.MainStore.世专丟丕丝丝专东一 val_44;
        string val_45;
        MainStoreView.丑丆丟丈上与丁丕下 val_1 = new MainStoreView.丑丆丟丈上与丁丕下();
        .丝且与丝丒丟万丁专 = this;
        this.<丑丈丆丑下丘上上丑>k__BackingField = 丌丟丝丟丆丂世丝丆.丝丈丞不东丄下丄世;
        this.业丙丘丈七不下下丐();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.loginMessageLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10046"), arg0:  "Google Play"));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.loginMessageHolder, 丏业丟一东丂东丘丛:  (~coinsShop.七三丗丏丑丗三丆世()) & 1);
        this.丆专丐丅下世一丛丝(不下丙丘丈下下丏一:  丌丟丝丟丆丂世丝丆.丝丈丞不东丄下丄世);
        if(this.guiApplyersGroup != null)
        {
                string val_7 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丅上万丛一丐上上丕();
        }
        
        this.下不丅丕东丏丝丝丆();
        this.丁与不七与丕丄丁丛();
        .丘丛丑丅丝丂丌丗万 = 0;
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业)) != false)
        {
                bool val_9 = this.与丐三丞丕且丕三专.TryGetValue(key:  丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业, value: out  .丘丛丑丅丝丂丌丗万);
        }
        
        if((.丘丛丑丅丝丂丌丗万 == null) && ((System.String.IsNullOrEmpty(value:  丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业)) != true))
        {
                if((this.丟丆不上丝丁专一丅().ContainsKey(key:  丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业)) != false)
        {
                val_43 = this.丟丆不上丝丁专一丅();
            bool val_15 = this.与丐三丞丕且丕三专.TryGetValue(key:  val_43.Item[丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业], value: out  .丘丛丑丅丝丂丌丗万);
        }
        
        }
        
        if((丌丟丝丟丆丂世丝丆.丆丁且丆丘丞丅丒不 == false) || ((this.丟丆不上丝丁专一丅().ContainsKey(key:  丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业)) == false))
        {
            goto label_30;
        }
        
        val_43 = 1152921523762453280;
        UnityEngine.Debug.LogError(message:  "Lack Of Currency. section: "("Lack Of Currency. section: ") + this.丟丆不上丝丁专一丅().Item[丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业]);
        if((System.String.op_Equality(a:  this.丟丆不上丝丁专一丅().Item[丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业], b:  "coins")) != true)
        {
                if((System.String.op_Equality(a:  this.丟丆不上丝丁专一丅().Item[丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业], b:  "gems")) == false)
        {
            goto label_30;
        }
        
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<PGCompany.MainStore.丐丑丂上丑丑东丒丞>(source:  this.丟世世丞丘业丌丒丆, predicate:  new System.Func<PGCompany.MainStore.丐丑丂上丑丑东丒丞, System.Boolean>(object:  val_1, method:  System.Boolean MainStoreView.丑丆丟丈上与丁丕下::一丄业丐丄丒下丏丞(PGCompany.MainStore.丐丑丂上丑丑东丒丞 三丟东丕丄丄下下丑)))) == null)
        {
            goto label_30;
        }
        
        val_44 = System.Linq.Enumerable.FirstOrDefault<PGCompany.MainStore.世专丟丕丝丝专东一>(source:  val_28.东不丘万丐丌世七丝);
        mem[1152921539267739712] = val_44;
        if(val_44 != null)
        {
            goto label_33;
        }
        
        goto label_32;
        label_30:
        val_44 = mem[1152921539267739712];
        if(val_44 != 0)
        {
            goto label_33;
        }
        
        label_32:
        System.Collections.Generic.KeyValuePair<System.String, PGCompany.MainStore.世专丟丕丝丝专东一> val_30 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.String, PGCompany.MainStore.世专丟丕丝丝专东一>>(source:  this.与丐三丞丕且丕三专);
        val_44;
        mem[1152921539267739712] = val_44;
        label_33:
        if(this.丑丑丏丒世七丈东与 != false)
        {
                this.丁丂业丏七丁丏且丌(丞且丌三三万七丛万:  val_30.Value);
            UnityEngine.Coroutine val_32 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void MainStoreView.丑丆丟丈上与丁丕下::丆一且世上丗上一丗()), 业丗七丕万万不丈丗:  1);
        }
        else
        {
                this.万丗丞丂丒世丁丟丟(丞且丌三三万七丛万:  val_30.Value, 丌与丟丁万丝丞丄丏:  false, 丛丁三七丅且丝丏丙:  false);
        }
        
        this.丑丑丏丒世七丈东与 = false;
        if(val_30.Value != 0)
        {
                val_45 = val_30.Value.丙业丆丘万丙专万丟();
        }
        else
        {
                val_45 = "";
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.丏世丄丞丂上丗三丑(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丐丅丒专丛丏上与业:  val_45, 世丁丙世丄一万丆三:  丌丟丝丟丆丂世丝丆.且业与与丒一丌与业);
        this.loadingAnimation.丆世与丑丆丅丐万且();
        if(StoreKitEventListener.三丘丈不丝丕丞东丌() != false)
        {
                val_45 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0853");
            this.loadingAnimation.下与丞三丅丛丄七丕(丕丗丘丑丛与丑业丒:  val_45, 丂三丟丂丈丐丆丗丟:  -1f);
        }
        
        if(val_30.Value != 0)
        {
                val_45 = "piggy";
            if((System.String.op_Equality(a:  丌丟丝丟丆丂世丝丆.丒专丈丗丆不业丁业, b:  "piggy")) != false)
        {
                if((System.String.op_Equality(a:  val_30.Value.丙业丆丘万丙专万丟(), b:  "piggy")) != false)
        {
                System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_40 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
            bool val_41 = val_30.Value.丗不丞一且丟丈丈丗(专丂丕丗丗东世丞下: ref  val_40, 三不丟丈丐丟丏专丁:  0, 丁丏且丝丞丙万丗与:  3);
            this.丛下丈丙万丈万丅且(丐丆丝业丙丈下世丁:  System.Linq.Enumerable.FirstOrDefault<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_40));
        }
        
        }
        
        }
        
        this.丏七且一丘丕丂万丆(丞且丌三三万七丛万:  val_30.Value, 一丗与一专丙丙丅丄:  丌丟丝丟丆丂世丝丆.丙丁丑丙丆丐丂业丈);
    }
    private void 丏七且一丘丕丂万丆(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万, PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_7;
        TagSystem.三与下丘七丘丌丏丄 val_8;
        val_7 = 丞且丌三三万七丛万;
        if(val_7 == null)
        {
                return;
        }
        
        if(一丗与一专丙丙丅丄 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_1 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
        val_8 = 0;
        bool val_2 = val_7.丗不丞一且丟丈丈丗(专丂丕丗丗东世丞下: ref  val_1, 三不丟丈丐丟丏专丁:  val_8, 丁丏且丝丞丙万丗与:  3);
        List.Enumerator<T> val_3 = val_1.GetEnumerator();
        label_11:
        if((301394296 & 1) == 0)
        {
            goto label_4;
        }
        
        val_7 = 0.丐丏七丌丕丗业且上();
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_8 = 0;
        if((val_7.七丈丒丒下下且万与().Equals(other:  null)) == false)
        {
            goto label_11;
        }
        
        goto label_12;
        label_4:
        val_7 = 0;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛下丈丙万丈万丅且(丐丆丝业丙丈下世丁:  null);
    }
    private void 下不丅丕东丏丝丝丆()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.showToNonPaingUsers, 丏业丟一东丂东丘丛:  this.丏一丁丟三丅万丛且());
        this.上东与丛丞下丈专丈();
    }
    private void 上东与丛丞下丈专丈()
    {
        var val_8;
        string val_28;
        MainStoreSectionTab val_29;
        var val_30;
        var val_31;
        string val_32;
        var val_33;
        var val_34;
        this.世业丒万丘丆专丘丐();
        this.与丐三丞丕且丕三专.Clear();
        if(coinsShop.世丞三丑一丈三世丗() != false)
        {
                UnityEngine.Debug.LogError(message:  "!!!!!! читер детектед !!!!!!");
            val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0279");
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.messageLable, 丕丗丘丑丛与丑业丒:  val_28);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.messageLable, 丏业丟一东丂东丘丛:  true);
            val_29 = this.sectionTab;
            val_29.世业丒万丘丆专丘丐();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.messageLable, 丏业丟一东丂东丘丛:  false);
        val_30 = 1152921505630273536;
        val_31 = 1152921539268246256;
        PGCompany.东丑丒丗一丞下丙丙<T> val_5 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.世专丟丕丝丝专东一>.万世丅七一专丕丞不();
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().不丈丒且丐丝丟丛丅(且下丒丒丑与不丛业:  this.<丑丈丆丑下丘上上丑>k__BackingField, 万丆丛世丈上丕东丗: ref  val_5);
        List.Enumerator<T> val_6 = val_5.GetEnumerator();
        val_33 = 1152921539268260592;
        goto label_33;
        label_47:
        string val_9 = val_8.丐丏七丌丕丗业且上();
        if((this.与丐三丞丕且丕三专.ContainsKey(key:  val_9.丙业丆丘万丙专万丟())) == false)
        {
            goto label_23;
        }
        
        val_32 = " allready exists";
        UnityEngine.Debug.LogError(message:  "section with name " + val_9.丙业丆丘万丙专万丟() + val_32);
        goto label_33;
        label_23:
        this.与丐三丞丕且丕三专.Add(key:  val_9.丙业丆丘万丙专万丟(), value:  val_9);
        val_32 = 0;
        if((val_9.丙业丆丘万丙专万丟().Equals(value:  "Advert")) != false)
        {
                if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.adschest")) == false)
        {
            goto label_33;
        }
        
        }
        
        MainStoreSectionView val_18 = this.sectionViewPool.Get<MainStoreSectionView>();
        val_18.transform.SetParent(p:  this.widgetLayout.transform);
        this.丘丄丑丂丄下丝丝业.Add(key:  val_9.丙业丆丘万丙专万丟(), value:  val_18);
        val_18.丕丘一上丞丂丆丑丏 = val_9;
        val_18.丏丗丄丐业丂上且丁 = this.storePromotionPoolGroup;
        val_18.下不丅丕东丏丝丝丆();
        val_30 = val_30;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  true);
        val_31 = val_31;
        this.widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_18);
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_22 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStoreView::丏丁丕丘一东丝丕丙(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁));
        val_32 = 0;
        System.Delegate val_23 = System.Delegate.Combine(a:  val_18.showInfoRequired, b:  null);
        if(val_23 == null)
        {
            goto label_44;
        }
        
        if(null == null)
        {
            goto label_45;
        }
        
        val_33 = 1152921539268260592;
        val_32 = 0;
        val_34 = 0;
        goto label_46;
        label_44:
        label_45:
        val_33 = 1152921539268260592;
        label_46:
        val_18.showInfoRequired = val_23;
        label_33:
        if((301802144 & 1) != 0)
        {
            goto label_47;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.东丑丒丗一丞下丙丙<T> val_24 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.世专丟丕丝丝专东一>.万世丅七一专丕丞不();
        this.widgetLayout.Reposition();
        val_28 = this.<丑丈丆丑下丘上上丑>k__BackingField;
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丟丞与丘丐丟丒丗丆(且下丒丒丑与不丛业:  val_28, 丐万丂丞万丌丐丞世: ref  this.丟世世丞丘业丌丒丆);
        val_29 = this.丟世世丞丘业丌丒丆;
        this.sectionTab.上东与丛丞下丈专丈(业丝丅专丟世一丁七:  val_29);
    }
    private void 万丈下丞专丁丙一丈(string 不丝丐与丑一丈丌世)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  不丝丐与丑一丈丌世)) != false)
        {
                return;
        }
        
        PGCompany.MainStore.世专丟丕丝丝专东一 val_3 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丗与与且丕万丘三丛(丙丐万丗丁丏丞专丄:  不丝丐与丑一丈丌世);
        if(val_3 != null)
        {
                this.丘一丘丕丈一不丈丒(丞且丌三三万七丛万:  val_3);
            return;
        }
        
        this.东丙丂丕丑丌丗丂且(不丝丐与丑一丈丌世:  不丝丐与丑一丈丌世);
    }
    private void 丘一丘丕丈一不丈丒(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
    {
        if(丞且丌三三万七丛万 == null)
        {
                return;
        }
        
        this.下不丅丕东丏丝丝丆();
        if((System.String.op_Equality(a:  this.丌丆世丏丙丛丙七丞, b:  丞且丌三三万七丛万.丙业丆丘万丙专万丟())) != false)
        {
                this.万丗丞丂丒世丁丟丟(丟丘不丒上丐丗与丅:  this.丌丆世丏丙丛丙七丞, 丌与丟丁万丝丞丄丏:  false);
        }
        
        this.丌丆世丏丙丛丙七丞 = "";
    }
    private void 东丙丂丕丑丌丗丂且(string 不丝丐与丑一丈丌世)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  不丝丐与丑一丈丌世)) != false)
        {
                return;
        }
        
        this.下不丅丕东丏丝丝丆();
    }
    internal void 世业丒万丘丆专丘丐()
    {
        var val_4;
        var val_8;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丘丄丑丂丄下丝丝业.GetEnumerator();
        label_8:
        if((302498960 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_6 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void MainStoreView::丏丁丕丘一东丝丕丙(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁));
        if(((System.Delegate.Remove(source:  ???, value:  null)) != null) && (null != null))
        {
                val_8 = 0;
        }
        
        val_5._value._obj.世业丒万丘丆专丘丐();
        this.sectionViewPool.Return(万且万且丑丗且丌丆:  val_5._value._obj);
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.与丐三丞丕且丕三专.Clear();
        this.丟世世丞丘业丌丒丆.Clear();
        this.丘丄丑丂丄下丝丝业.Clear();
        this.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    internal void 业不不且丐且与不与()
    {
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丘丄丑丂丄下丝丝业.GetEnumerator();
        label_4:
        if((302647880 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        val_2._value._obj.业不不且丐且与不与();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 万丗丞丂丒世丁丟丟(string 丟丘不丒上丐丗与丅, bool 丌与丟丁万丝丞丄丏)
    {
        string val_9;
        PGCompany.MainStore.世专丟丕丝丝专东一 val_10;
        val_9 = 丟丘不丒上丐丗与丅;
        PGCompany.MainStore.世专丟丕丝丝专东一 val_6 = 0;
        val_10 = 0;
        if((System.String.IsNullOrEmpty(value:  val_9)) != true)
        {
                if((this.丟丆不上丝丁专一丅().ContainsKey(key:  val_9)) != false)
        {
                val_9 = this.丟丆不上丝丁专一丅().Item[val_9];
            bool val_7 = this.与丐三丞丕且丕三专.TryGetValue(key:  val_9, value: out  val_6);
            val_10 = val_6;
        }
        else
        {
                val_10 = 0;
        }
        
        }
        
        this.万丗丞丂丒世丁丟丟(丞且丌三三万七丛万:  val_10, 丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏, 丛丁三七丅且丝丏丙:  false);
    }
    internal void 万丗丞丂丒世丁丟丟(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万, bool 丌与丟丁万丝丞丄丏, bool 丛丁三七丅且丝丏丙 = False)
    {
        UnityEngine.Object val_17;
        ScrollViewHelper val_18;
        float val_19;
        this.丁丂业丏七丁丏且丌(丞且丌三三万七丛万:  丞且丌三三万七丛万);
        if(丞且丌三三万七丛万 == null)
        {
                return;
        }
        
        this.丁丂业丏七丁丏且丌(丞且丌三三万七丛万:  丞且丌三三万七丛万);
        MainStoreSectionView val_2 = 0;
        bool val_3 = this.丘丄丑丂丄下丝丝业.TryGetValue(key:  丞且丌三三万七丛万.丙业丆丘万丙专万丟(), value: out  val_2);
        val_17 = val_2;
        if(val_17 == 0)
        {
                return;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, MainStoreSectionView> val_5 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, MainStoreSectionView>>(source:  this.丘丄丑丂丄下丝丝业);
        val_18 = this.srollViewHelper;
        if(val_5.Value == val_2)
        {
            goto label_8;
        }
        
        this.srollViewHelper.scrollDelta = this.scrollDelta;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  8)) == false)
        {
            goto label_11;
        }
        
        System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<MainStoreSectionView>(source:  this.丘丄丑丂丄下丝丝业.Values);
        MainStoreSectionView val_17 = val_2;
        val_17 = (val_10.IndexOf(item:  val_17)) - 1;
        if((val_17 & 2147483648) != 0)
        {
            goto label_14;
        }
        
        MainStoreSectionView val_12 = val_10.Item[val_17];
        if(val_12.丆丈三丅丌上丂与万.Count >= 2)
        {
            goto label_18;
        }
        
        label_14:
        val_18 = this.srollViewHelper;
        if(val_18 == null)
        {
            goto label_21;
        }
        
        val_19 = this.tutorialDelta;
        goto label_26;
        label_8:
        val_19 = 0f;
        if(val_18 == null)
        {
            goto label_21;
        }
        
        label_26:
        this.srollViewHelper.scrollDelta = val_19;
        label_11:
        val_17 = this.srollViewHelper;
        val_17.ScrollTo(不七丘丘丒万七丄丒:  val_2.transform, 丌与丟丁万丝丞丄丏:  丌与丟丁万丝丞丄丏);
        if(丛丁三七丅且丝丏丙 == false)
        {
                return;
        }
        
        this.丒丛丐丐丑丈世专丑(丞且丌三三万七丛万:  丞且丌三三万七丛万);
        return;
        label_18:
        float val_16 = this.tutorialDelta + this.tutorialDelta;
        goto label_26;
        label_21:
    }
    private void 丁丂业丏七丁丏且丌(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
    {
        if(丞且丌三三万七丛万 == null)
        {
                return;
        }
        
        this.sectionTab.丁丂业丏七丁丏且丌(丞且丌三三万七丛万:  丞且丌三三万七丛万);
    }
    private void 且丙三业丏丘且一世()
    {
        this.sectionTab.OnScrollSmooothEnded();
    }
    private void 丏丁丕丘一东丝丕丙(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        var val_5;
        if(丐丆丝业丙丈下世丁 == null)
        {
                return;
        }
        
        if(丐丆丝业丙丈下世丁.与不丞丑七丘丁丂丛() != null)
        {
                val_5 = 丐丆丝业丙丈下世丁.与不丞丑七丘丁丂丛();
            string[] val_3 = new string[2];
            val_3[0] = "state.purchased";
            val_3[1] = "state.disable-info-if-purchased";
            if((val_5.上万丘丙一丛丕与下(丏上业丞上丈丄丈不:  val_3)) != false)
        {
                return;
        }
        
        }
        
        this.丛下丈丙万丈万丅且(丐丆丝业丙丈下世丁:  丐丆丝业丙丈下世丁);
    }
    private void 丛下丈丙万丈万丅且(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        PGCompany.StorePromotionInfoUIAbstract val_11;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.currentPromotionInfoUI, y:  0);
        if(丐丆丝业丙丈下世丁 == null)
        {
                return;
        }
        
        PGCompany.StorePromotionInfoUIAbstract val_3 = this.storePromotionPoolGroup.Get<PGCompany.StorePromotionInfoUIAbstract>(丛丄业丕且丗下一万:  丐丆丝业丙丈下世丁.丐万丐丌丌丆丒丐丝());
        this.currentPromotionInfoUI = val_3;
        if(val_3 != 0)
        {
            goto label_9;
        }
        
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "No info prefab with name: {0} for promotion: {1}", arg0:  丐丆丝业丙丈下世丁.丐万丐丌丌丆丒丐丝(), arg1:  丐丆丝业丙丈下世丁.七丈丒丒下下且万与()));
        val_11 = this.storePromotionPoolGroup.Get<PGCompany.StorePromotionInfoUIAbstract>(丛丄业丕且丗下一万:  "MainStorePromotion/MainStorePromo_InfoUI");
        this.currentPromotionInfoUI = val_11;
        if(val_11 != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_9:
        val_11 = this.currentPromotionInfoUI;
        if(val_11 != null)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        val_11.transform.SetParent(p:  this.promotionInfoUIHolder);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.currentPromotionInfoUI.transform);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.currentPromotionInfoUI, 丏业丟一东丂东丘丛:  true);
        if(this.currentPromotionInfoUI == null)
        {
            
        }
    
    }
    private void 丙丈东且丛丞上丏不(PGCompany.StorePromotionInfoUIAbstract 专上丄丂丙下丑东丆)
    {
        PGCompany.StorePromotionInfoUIAbstract val_4 = this.currentPromotionInfoUI;
        if(专上丄丂丙下丑东丆 != val_4)
        {
                return;
        }
        
        if(this.currentPromotionInfoUI == 0)
        {
                return;
        }
        
        val_4 = this.currentPromotionInfoUI;
        this.storePromotionPoolGroup.Return(丛丄业丕且丗下一万:  this.currentPromotionInfoUI.name, 万且万且丑丗且丌丆:  val_4);
        this.currentPromotionInfoUI = 0;
    }
    private void 丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)
    {
        if((丞东丑专丛丆丄丝世.丆丏万丄专丕丄丌上(万且万且丑丗且丌丆:  this.loadingAnimation)) != false)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 != false)
        {
                this.loadingAnimation.下与丞三丅丛丄七丕(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0853"), 丂三丟丂丈丐丆丗丟:  -1f);
            return;
        }
        
        this.loadingAnimation.丆世与丑丆丅丐万且();
    }
    private void 丈丝下丛专三丐丛且(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不, object 万且万且丑丗且丌丆)
    {
        var val_14;
        var val_15;
        UniversalRewardController.丑三不丕丘丞不丏下 val_16;
        丈下专丂丑不丑丗丁 val_17;
        丑丒专丄三三业丏丏 val_18;
        val_14 = this;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.currentPromotionInfoUI, y:  0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.showToNonPaingUsers, 丏业丟一东丂东丘丛:  this.丏一丁丟三丅万丛且());
        val_15 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世();
        if((val_15.与丛七丙丛且丙丄下(且丒丛与丞世丙丕丌:  5)) == false)
        {
            goto label_8;
        }
        
        val_14 = 且丘丏丁丑与丙与丁.丘丑下丆上业丛一丄().Settings;
        val_16 = val_7.UniversalRewardParams;
        val_17 = 5;
        val_18 = 1;
        goto label_12;
        label_8:
        val_15 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世();
        if((val_15.与丛七丙丛且丙丄下(且丒丛与丞世丙丕丌:  14)) == false)
        {
            goto label_14;
        }
        
        val_17 = 14;
        goto label_15;
        label_14:
        val_15 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世();
        if((val_15.与丛七丙丛且丙丄下(且丒丛与丞世丙丕丌:  16)) == false)
        {
            goto label_17;
        }
        
        val_17 = 16;
        label_15:
        val_18 = 1;
        val_16 = 0;
        label_12:
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  val_17, 丌世丕丗不丘世丞专:  val_18, 一七丁不丝丈丕丑丒:  val_16);
        return;
        label_17:
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "show_purchase_confirmation")) == false)
        {
                return;
        }
        
        this.丈专丕丅丆丗丌丏丐(且丘丏丁丑与丙与丁:  "show_purchase_confirmation", 丈丄不七三万丄丁不:  0);
    }
    private bool 丏一丁丟三丅万丛且()
    {
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                return false;
        }
        
        if(与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专() == false)
        {
                return System.String.op_Inequality(a:  this.<丑丈丆丑下丘上上丑>k__BackingField, b:  "ShopCompetition");
        }
        
        return false;
    }
    private void 业丕丐丝与丄丏丆丂()
    {
        var val_2;
        if((System.String.op_Equality(a:  this.<丑丈丆丑下丘上上丑>k__BackingField, b:  "Clan")) == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.丞丟丂三丝丆丌丌丗 = true;
        丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
    }
    private void 丈专丕丅丆丗丌丏丐(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Show Purchase Confirmation");
        this.purchaseConfirmationHolder.SetActive(value:  true);
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void MainStoreView::万丕一丏丈丑七丒七()), 丆丐七丅丆丗丛上与:  this.messageTime);
    }
    private void 丁与不七与丕丄丁丛()
    {
        this.panelAnchor.Apply();
        UIPanel val_1 = this.panelAnchor.Panel;
        UnityEngine.Vector3 val_3 = this.lauputWidget.transform.position;
        this.lauputWidget.transform.position = new UnityEngine.Vector3() {x = V8.16B, y = val_3.y, z = val_3.z};
        this.srollViewHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
    }
    public void ShowMessage(string 丄丙下丝丛丒七丂丘)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.messageLabelHolder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.messageLabel, 丕丗丘丑丛与丑业丒:  丄丙下丝丛丒七丂丘);
        一丛丟世丗丈丘丏万 val_2 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "MainStoreView_ShowMessage", 丘丁三丅丆与丆业业:  this.messageTime, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void MainStoreView::丐丅丕丞丞下丏丂丕()));
    }
    private void 上丐下丁专丛七丟丛()
    {
        var val_4;
        MainStoreSectionTab val_13;
        UnityEngine.Object val_14;
        val_13 = this;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.丘丄丑丂丄下丝丝业.Values.GetEnumerator();
        val_14 = 0;
        goto label_10;
        label_11:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_7 = val_5.transform.position;
        UnityEngine.Vector3 val_9 = this.selectSectionPoint.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) < 0)
        {
                val_14 = val_5;
        }
        
        label_10:
        if((305116272 & 1) != 0)
        {
            goto label_11;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_14 == this.不丑一丗丌丒不丐一)
        {
                return;
        }
        
        this.不丑一丗丌丒不丐一 = val_14;
        if(val_14 == 0)
        {
                return;
        }
        
        val_13 = this.sectionTab;
        val_13.丁丂业丏七丁丏且丌(丞且丌三三万七丛万:  this.不丑一丗丌丒不丐一.丕丘一上丞丂丆丑丏);
    }
    private void 丒丛丐丐丑丈世专丑(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
    {
        string val_11 = this.丆与与丄与业丈与三;
        if((System.String.op_Equality(a:  val_11 = this.丆与与丄与业丈与三, b:  丞且丌三三万七丛万.丙业丆丘万丙专万丟())) == true)
        {
                return;
        }
        
        if(丞且丌三三万七丛万 != null)
        {
                this.丆与与丄与业丈与三 = 丞且丌三三万七丛万.丙业丆丘万丙专万丟();
            System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一> val_4 = new System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一>();
        }
        else
        {
                this.丆与与丄与业丈与三 = 0.丙业丆丘万丙专万丟();
            System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一> val_6 = new System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一>();
        }
        
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丟丞与丘丐丟丒丗丆(且下丒丒丑与不丛业:  this.<丑丈丆丑下丘上上丑>k__BackingField, 丆万一不丌且东丐丐:  丞且丌三三万七丛万.与不丞丑七丘丁丂丛().丘下丗丘业且七七丞(丆万一不丌且东丐丐:  "navigation"), 且丕万丒丑丂丙丂丐: ref  val_6);
        val_11 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        PGCompany.Analytics.一业丗丆世世上丁且.丛且万丙丒专丑上丅(丆丛丑世下一丐且丕:  val_11, 丈丑丕丑上丙丝业丌:  丞且丌三三万七丛万, 东丒丙不丏不且丗丐:  val_6);
    }
    internal void 丅七丐不丒丛丞三丌(bool 丙业与丙丗丝不丈东)
    {
        bool val_2;
        if(丙业与丙丗丝不丈东 != false)
        {
                UnityEngine.Color val_1 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            val_2 = 0;
        }
        else
        {
                PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.不丂丝丘丅三且与丒});
            val_2 = this.丛一上丗世丅丂丑丈;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  val_2);
    }
    private void Update()
    {
        this.上丐下丁专丛七丟丛();
    }
    private void 与丟丅丌丘且丞业丞(bool 丛丅丘一丏丙且丌上)
    {
        var val_9;
        MainMenuController val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = null;
        val_9 = null;
        val_10 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_10 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        val_10 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_10.一丑丟世丛丌丁下不() != false)
        {
                return;
        }
        
        val_12 = null;
        if(丛丅丘一丏丙且丌上 != false)
        {
                val_13 = null;
            val_14 = MainMenuController.丄丞丁丈与业上丞丟.gameObject;
            var val_4 = (this.万丆丒七丑不丈世丈 == true) ? 1 : 0;
        }
        else
        {
                val_16 = null;
            this.万丆丒七丑不丈世丈 = MainMenuController.丄丞丁丈与业上丞丟.gameObject.activeSelf;
            val_14 = MainMenuController.丄丞丁丈与业上丞丟.gameObject;
            val_15 = 0;
        }
        
        val_14.SetActive(value:  false);
    }
    internal void 丏丈丁丌丈丅丙且丒(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        if(丐丆丝业丙丈下世丁 == null)
        {
                return;
        }
        
        this.与丈万一三不丁下上 = 丐丆丝业丙丈下世丁;
        this._previewOfferPackController.业东丑丅丆三丕丏一(丐丆丝业丙丈下世丁:  丐丆丝业丙丈下世丁);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
        this = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(this == 0)
        {
                return;
        }
        
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  false, 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
    }
    internal void 上丌万丛东丒丝丞丁(bool 丑三三下一丝丞丐世)
    {
        this.与丈万一三不丁下上 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
    }
    internal void 专万万一丁业丘下丕(BannerWindowType 三丕丏下丞丄丆丟世, PGCompany.丆下丐丁丏世丈上丟 丟丛丟丗一丂下上下)
    {
        this.bannersHolder.ShowBanner(丌丅丕一丛丛丄一万:  三丕丏下丞丄丆丟世, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        if((UnityEngine.Object.op_Implicit(exists:  this.bannersHolder.CurrentBanner)) == false)
        {
                return;
        }
        
        this = this.bannersHolder.CurrentBanner;
        丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  this, 丙业与丙丗丝不丈东:  136);
    }
    private void 七世且丙业丑丐丐东(PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
    {
        this.专万万一丁业丘下丕(三丕丏下丞丄丆丟世:  68, 丟丛丟丗一丂下上下:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丆不七一丐且不七三 = ???, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void 丆专丐丅下世一丛丝(string 不下丙丘丈下下丏一)
    {
        var val_4;
        string val_16;
        .不下丙丘丈下下丏一 = 不下丙丘丈下下丏一;
        List.Enumerator<T> val_2 = this.storeTypeSettingsList.GetEnumerator();
        label_7:
        if((306801808 & 1) == 0)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_4.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_7;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.Linq.Enumerable.FirstOrDefault<MainStoreTypeSettings>(source:  this.storeTypeSettingsList, predicate:  new System.Func<MainStoreTypeSettings, System.Boolean>(object:  new MainStoreView.丑且丐丄业且丅业丅(), method:  System.Boolean MainStoreView.丑且丐丄业且丅业丅::业且丁丞东丝一下且(MainStoreView.MainStoreTypeSettings 三丟东丕丄丄下下丑)))) == null)
        {
                if((System.Linq.Enumerable.FirstOrDefault<MainStoreTypeSettings>(source:  this.storeTypeSettingsList)) == null)
        {
            goto label_14;
        }
        
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_8.objectsToEnable, 丏业丟一东丂东丘丛:  true);
        label_14:
        val_16 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝丈且万丐丟丗七一().丒一丂上丛丕丄丏丐(丌业专专丞专专丆丌:  (MainStoreView.丑且丐丄业且丅业丅)[1152921539273435344].不下丙丘丈下下丏一);
        if(val_16 == null)
        {
            goto label_20;
        }
        
        if(this.currencyUI != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        this.currencyUI.丈且东丑丂且万丒丅(丞丂世丌世丅丗丁丂:  val_16.一丂丗丄丅丏三万一());
        if(val_16 != null)
        {
                val_16 = val_16.下丘丄丂与丅丑万丌();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.headerLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_16));
        return;
        label_20:
        if(this.currencyUI != null)
        {
            goto label_27;
        }
        
        goto label_28;
    }
    internal void 万丄下丈丏一不丑七()
    {
        if(MainStoreView.丝业丆丁业三丈丟东 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.srollViewHelper.transform.localPosition;
        float val_6 = val_3.x;
        float val_5 = this.TMP_ScrollToRightDelta;
        val_5 = val_5 + (float)UnityEngine.Screen.width;
        val_6 = val_6 - val_5;
        this.srollViewHelper.ScrollTo(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_6, y = val_3.y, z = val_3.z}, 七丙不一下丞与丞一:  0f, 丌与丟丁万丝丞丄丏:  false);
    }
    private void 东丅不丕丌上不三丙(string 丈丐丈不丞丑世专下)
    {
        this.丌丆世丏丙丛丙七丞 = 丈丐丈不丞丑世专下;
        this.万丗丞丂丒世丁丟丟(丟丘不丒上丐丗与丅:  丈丐丈不丞丑世专下, 丌与丟丁万丝丞丄丏:  false);
    }
    public MainStoreView()
    {
        this.scrollDelta = 50f;
        this.tutorialDelta = 4.591775E-41f;
        this.messageTime = 3f;
        this.与丐三丞丕且丕三专 = new System.Collections.Generic.Dictionary<System.String, PGCompany.MainStore.世专丟丕丝丝专东一>();
        this.丟世世丞丘业丌丒丆 = new System.Collections.Generic.List<PGCompany.MainStore.丐丑丂上丑丑东丒丞>();
        this.丘丄丑丂丄下丝丝业 = new System.Collections.Generic.Dictionary<System.String, MainStoreSectionView>();
        this.丑丑丏丒世七丈东与 = true;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.不丂丝丘丅三且与丒 = val_4;
        mem[1152921539273861572] = val_4.g;
        mem[1152921539273861576] = val_4.b;
        mem[1152921539273861580] = val_4.a;
        this.万丆丒七丑不丈世丈 = true;
    }
    private void 万丕一丏丈丑七丒七()
    {
        if(this == 0)
        {
                return;
        }
        
        this.purchaseConfirmationHolder.SetActive(value:  false);
    }
    private void 丐丅丕丞丞下丏丂丕()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.messageLabelHolder, 丏业丟一东丂东丘丛:  false);
    }

}
