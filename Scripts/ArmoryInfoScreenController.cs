using UnityEngine;
internal sealed class ArmoryInfoScreenController : MonoBehaviour
{
    // Fields
    private System.Action 丄丑上丕丂丈丘丙七;
    private UnityEngine.GameObject _galleryTutorialHint;
    public UnityEngine.GameObject skinsButton;
    public WeaponSkinsShopUI skinsUI;
    private UILabel _newSkinsCountLabel;
    private UnityEngine.GameObject _newSkinsCountContainer;
    private bool 万丐丒不一万与丟丈;
    private bool <丗丝三丟丕丄万丂丛>k__BackingField;
    internal bool 丙业丁丅丗万丞丙且;
    private bool <丅丁七不丑丅丐丞不>k__BackingField;
    private static bool <丟丆丙下上丁丘业三>k__BackingField;
    public UnityEngine.GameObject freeUpSign;
    public UnityEngine.GameObject freeUpBonusLabel;
    public UnityEngine.GameObject freeUpgradeLabelForTraining;
    public UnityEngine.GameObject freeSpeedupLabelForTraining;
    public UnityEngine.GameObject normalSpeedupLabelOnButton;
    public UILabel upLabel;
    public UISprite craftPlashka;
    public UILabel craftDetails;
    private GoToAlmanachButton goToAlmanachButton;
    public UnityEngine.GameObject mainPanelForBank;
    public UILabel[] rarity;
    internal static ArmoryInfoScreenController 丄丞丁丈与业上丞丟;
    public PropertiesArmoryItemContainer propertiesContainer;
    public SetHeadLabelText itemNameLabel;
    public UILabel rarityLabel;
    public UIScrollView itemsScroll;
    public UIGrid itemsGrid;
    public UISprite[] frameSprites;
    public UpgradeWindow[] upgradesWindows;
    public UnityEngine.GameObject CraftParticles;
    public UnityEngine.GameObject UpgradeParticles;
    public UnityEngine.GameObject BarAnimSprite;
    public UnityEngine.GameObject UpgradingLabel;
    public UnityEngine.GameObject UpgradeFinishedParticles;
    public UnityEngine.GameObject labelFirstBuy;
    public PriceContainer priceContainer;
    public UnityEngine.GameObject priceLable;
    public UnityEngine.GameObject discountContainer;
    public UILabel discountLabel;
    public UnityEngine.GameObject previewPrefab;
    public UILabel infoDev;
    public UnityEngine.GameObject modulesTutorialHintGoToModules;
    public UnityEngine.GameObject modulesTutorialHintClose;
    public bool SelfDestroyOnClose;
    private System.Collections.Generic.List<ItemPreviewInArmoryInfoScreen> 下且丅丞不三三不且;
    private ItemPreviewInArmoryInfoScreen 丛丞专万丈业业七丟;
    private PGCompany.丟丝世万东万丆丟上 上不丟丗丕专专丗丆;
    private int 丄丞丞丌三万丛丂不;
    private ArmoryInfoScreenController.下业丗丛丕世专丒三 与丄丏丞不丐丘丗丘;
    private System.IDisposable 丆丒与丝且丑丞丒丆;
    private System.Collections.Generic.List<string> 万七丁丙丝下七三丙;
    private 丙且上东下丏丏丟下 丟丘丅业丝丆丟丝丟;
    private UnityEngine.GameObject previewContainer;
    private WeaponSkinChanger 丟丁丛丏三且丞一丘;
    public bool AnimationIsRunning;
    private float 业丕下三丆世与丝丄;
    private UnityEngine.GameObject _simpleBGContainer;
    private float _simpleMainPanelY;
    private UnityEngine.GameObject _battlePassBGContainer;
    private float _battlePassMainPanelY;
    private PGCompany.ModuleArmoryInfoScreen _moduleArmoryInfoScreen;
    private System.Collections.Generic.List<UnityEngine.GameObject> _weightObjects;
    
    // Properties
    internal bool 丏丅丌丌丘丛丘丗丅 { get; set; }
    internal bool 丂且丟丝丙丘丁丏丁 { set; }
    internal WeaponSkinsShopUI 不丈且丐专世且丕与 { get; }
    internal bool 丕丐东东上一下丘业 { get; set; }
    internal static bool 且丙丏七丏业三丒丙 { get; set; }
    internal 丙且上东下丏丏丟下 丞丅丗丟丂世东丁丟 { get; }
    internal WeaponSkinChanger 丝三丌丏东丕丈丅丝 { get; }
    
    // Methods
    internal void 丘万丟丕业不万丂丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != 1152921524413816776);
    
    }
    internal void 丅七丅丐丗丛一丑丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丑上丕丂丈丘丙七 != 1152921524413953352);
    
    }
    internal bool 丆三丈下且丈丟丑丆()
    {
        return (bool)this.<丗丝三丟丕丄万丂丛>k__BackingField;
    }
    internal void 丁丒丟世丙丛一丕丂(bool 丙业与丙丗丝不丈东)
    {
        this.<丗丝三丟丕丄万丂丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丞丘一专七丘万丟七(bool 丙业与丙丗丝不丈东)
    {
        this.万丐丒不一万与丟丈 = 丙业与丙丗丝不丈东;
        丙业与丙丗丝不丈东 = (~丙业与丙丗丝不丈东) & 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.skinsUI.hideButton, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    internal WeaponSkinsShopUI 丏丁专不七丒上七丁()
    {
        return (WeaponSkinsShopUI)this.skinsUI;
    }
    internal bool 上且丑且专丑丟万东()
    {
        return (bool)this.<丅丁七不丑丅丐丞不>k__BackingField;
    }
    internal void 丂且不丝丘丈丗丂丘(bool 丙业与丙丗丝不丈东)
    {
        this.<丅丁七不丑丅丐丞不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丈丛丁丅丈三与专丈()
    {
        return (bool)ArmoryInfoScreenController.<丟丆丙下上丁丘业三>k__BackingField;
    }
    internal static void 丘万丕丟丄丂丁东丈(bool 丙业与丙丗丝不丈东)
    {
        ArmoryInfoScreenController.<丟丆丙下上丁丘业三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void HandlePropertiesPopupButton()
    {
        if(this.propertiesContainer == null)
        {
                return;
        }
        
        PropertiesPopupController val_3 = this.propertiesContainer.丛且丒万丞丝丞丝丕();
        if(val_3 == null)
        {
                return;
        }
        
        val_3.丈且东丑丂且万丒丅(丒东业不丐丑丕丄丆:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七(), 丟丕丞丁丝丂上丄上:  (this.GetComponent<UIPanel>().depth) + 1);
    }
    public void HandleGoToClans()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleGoToClans();
    }
    internal static void 丅丐万丏丑丈七丟业(bool 丛与丙丒丒下丌丟且)
    {
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.itemsGrid == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  丛与丙丒丒下丌丟且);
    }
    internal void 丟丙且丝万与不丑丐()
    {
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.GameObject val_15;
        var val_16;
        var val_17;
        var val_18;
        val_12 = null;
        val_12 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_11;
        }
        
        val_13 = null;
        val_13 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上 == 0)
        {
            goto label_11;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = this.modulesTutorialHintGoToModules;
        if(isActiveAndEnabled == false)
        {
            goto label_16;
        }
        
        val_16 = 0;
        val_17 = 1;
        goto label_22;
        label_11:
        val_15 = this.modulesTutorialHintGoToModules;
        label_16:
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 3)
        {
                val_17 = 0;
            val_16 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_17 = 0;
            val_16 = 0;
        }
        
        label_22:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  false);
        if(((val_17 & 1) == 0) && (业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 4))
        {
                val_18 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_18 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.modulesTutorialHintClose, 丏业丟一东丂东丘丛:  false);
    }
    public void HandleGoToTargetAction()
    {
        var val_2;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_2 = null;
        val_2 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌丌丈不万七丆丙丗(丞丅上丏丂且下丅与:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
    }
    public void HandleGoToTournamentClicked()
    {
        var val_6;
        var val_7;
        CategoryNames val_8;
        .Type = 8;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_6 = null;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丁七丁丞丞丟丒业丅 = this.丟丘丅业丝丆丟丝丟;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_7 = 0;
            val_8 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且();
        }
        else
        {
                val_7 = 0;
            val_8 = 0.丗丛丐丑丛丅丞七且();
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌不丒万万丟丞上与 = val_8;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丕丏丑丏丏丂与东丏 = ShopNGUIController.丛丐丛专丟丞万三七();
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public void CloseByHardwareBack()
    {
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 3)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
                return;
        }
        
        }
        
        this.Close();
    }
    public void Close()
    {
        var val_3;
        var val_4;
        UnityEngine.Transform val_5;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(this.SelfDestroyOnClose != false)
        {
                this.丞丏世丆丄上丆一七();
        }
        
        if(this.丄丑上丕丂丈丘丙七 != null)
        {
                this.丄丑上丕丂丈丘丙七.Invoke();
        }
        
        val_3 = null;
        val_3 = null;
        ShopNGUIController.东丁丝丝丘且丌丅丗 = false;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_5 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1592];
            val_5 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丟丞下不丙丒丝上一;
        }
        else
        {
                val_5 = 0;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丞丘丒与上丄丗上一(丌丝万上丅丒一丈丘:  val_5);
    }
    public void UI_Move()
    {
        if(this.丟丘丅业丝丆丟丝丟 == null)
        {
                return;
        }
        
        this = this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七();
        CategoryNames val_2 = this.丟丘丅业丝丆丟丝丟.丒万丕七专不丏丞丌();
        PGCompany.BattlePass.世下东丌三专上下万.下丏且一三丐一丐不(丕丁下丌不万丅丞丛:  this, 业丈世与下丘丛丐且:  new System.Nullable<CategoryNames>() {HasValue = false});
    }
    public void HandleBattlePassButton()
    {
        var val_3;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_3 = null;
        val_3 = null;
        PGCompany.BattlePass.BattlePassGuiHandler.丙丂丂丕专丞世下与(丑丝丏丂且不下一东:  this.丟丘丅业丝丆丟丝丟, 七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
    }
    internal void 丞丏世丆丄上丆一七()
    {
        if(this.gameObject.activeInHierarchy != false)
        {
                this.transform.parent = 0;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void Awake()
    {
        if(Rilisoft.WeaponSpeedUpController.丑七不且上丗丁一世() != 0)
        {
                Rilisoft.WeaponSpeedUpController.丑七不且上丗丁一世().SetRewardParent(丈东丘丏与丌东东下:  this.gameObject);
        }
        
        上且丁万与丌下丐上.丈与丞丒丂丟丗一丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丟丝东丈丐丙三下丛>(object:  this, method:  System.Void ArmoryInfoScreenController::丙丏丙丞东不丑业不(PGCompany.丟丝东丈丐丙三下丛 万且万且丑丗且丌丆)));
    }
    private void 丙丏丙丞东不丑业不(PGCompany.丟丝东丈丐丙三下丛 万且万且丑丗且丌丆)
    {
        this.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.丟丘丅业丝丆丟丝丟, 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    private void Start()
    {
        var val_2;
        var val_3;
        ArmoryInfoScreenController.丄丞丁丈与业上丞丟 = this;
        val_2 = null;
        val_2 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丟丙且丝万与不丑丐();
    }
    private void OnEnable()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        this.上丕丆丒世丒丞丗丞();
        this.丆丒与丝且丑丞丒丆 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ArmoryInfoScreenController::CloseByHardwareBack()), 与且专丈不万东一万:  "Info screen in Armory");
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().东丏一丁下丄丙丙丂();
        }
        
        val_23 = null;
        val_23 = null;
        ShopNGUIController.东丁丝丝丘且丌丅丗 = true;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_24 = null;
            val_24 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丞丘丒与上丄丗上一(丌丝万上丅丒一丈丘:  0);
        }
        
        if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false)
        {
                return;
        }
        
        if(this.goToAlmanachButton == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        if(SquadController.丄丘七三上丕世丞业 != 0)
        {
                val_27 = null;
            val_27 = null;
            if(SquadController.丄丘七三上丕世丞业.inSquad != false)
        {
                return;
        }
        
        }
        
        if((AlmanachTutorialManager.TutorialFinished == true) || (ShopNGUIController.丛世丛与丌不丈丐丐() == false))
        {
            goto label_57;
        }
        
        val_28 = null;
        val_28 = null;
        if(((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且())) == false) || (丅丛丟上丁丆上丛专.不七不丙丏上与三一() == null))
        {
            goto label_57;
        }
        
        var val_22 = (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count < 2) ? 1 : 0;
        goto label_62;
        label_57:
        val_29 = 0;
        label_62:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._galleryTutorialHint, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        if(HintController.与一丅丝不丈业与丙() != 0)
        {
                HintController.与一丅丝不丈业与丙().丙万丞丄丐丂下丅丘();
        }
        
        this.上丕丆丒世丒丞丗丞();
    }
    private void OnDestroy()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        ArmoryInfoScreenController.丄丞丁丈与业上丞丟 = 0;
        val_3 = null;
        ArmoryInfoScreenController.<丟丆丙下上丁丘业三>k__BackingField = false;
        this.上丕丆丒世丒丞丗丞();
        val_4 = null;
        val_4 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_5 = null;
            val_5 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丟丙且丝万与不丑丐();
        }
        
        上且丁万与丌下丐上.丑丄丘万万丄丑丁业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丟丝东丈丐丙三下丛>(object:  this, method:  System.Void ArmoryInfoScreenController::丙丏丙丞东不丑业不(PGCompany.丟丝东丈丐丙三下丛 万且万且丑丗且丌丆)));
    }
    internal void 上丕丆丒世丒丞丗丞()
    {
        if(this.丆丒与丝且丑丞丒丆 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丆丒与丝且丑丞丒丆.Dispose();
        this.丆丒与丝且丑丞丒丆 = 0;
    }
    private void 丘下丟丁上丏丛且且(ItemPreviewInArmoryInfoScreen 丁丑丞不丗专丑业万, CategoryNames 七丆丒与丗丌丄且丂, 丙且上东下丏丏丟下 万丞丁不丏丌七专万, string 丙丂丒一丗下丘下丟, int 丄丄丒丘丏一丗丆与 = 0, int 世七与业一七世丂丒 = 0)
    {
        var val_3;
        丙且上东下丏丏丟下 val_14;
        CategoryNames val_15;
        ItemPreviewInArmoryInfoScreen val_16;
        string val_17;
        var val_18;
        ShopNGUIController val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_14 = 万丞丁不丏丌七专万;
        val_15 = 七丆丒与丗丌丄且丂;
        val_16 = 丁丑丞不丗专丑业万;
        List.Enumerator<T> val_1 = this.下且丅丞不三三不且.GetEnumerator();
        label_4:
        if(((-1664132384) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        val_4.SetSelected(丏丈丞丙七丛东七丌:  val_4 & 1, 东丝三一丞下业丂丝:  false);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.itemNameLabel.SetText(丕丗丘丑丛与丑业丒:  丁丑丞不丗专丑业万.headName);
        this.丛丞专万丈业业七丟 = val_16;
        val_17 = 丁丑丞不丗专丑业万.id;
        if((val_14 == null) && ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_15)) != false))
        {
                val_17 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  丁丑丞不丗专丑业万.id);
            if(val_17 == null)
        {
                val_17 = 丁丑丞不丗专丑业万.id;
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        val_19 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_19 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑() != null)
        {
                val_21 = null;
            val_21 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌() == 240000)
        {
                丙且上东下丏丏丟下 val_12 = null;
            val_14 = val_12;
            val_12 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丁丑丞不丗专丑业万.id, 七丆丒与丗丌丄且丂:  val_15);
        }
        
        }
        
        val_22 = null;
        val_22 = null;
        val_19 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_15 == 150000)
        {
                if(val_19.丗丛丐丑丛丅丞七且() == 7)
        {
                return;
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        val_16 = 丁丑丞不丗专丑业万.id;
        val_15 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_15.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  val_17, 丂丒丒丆且丝丘丈丟:  val_16, 丘丐丝丟业丘丏东专:  this.propertiesContainer, 东丈丒三丞与业世一:  false, 丐丙丒丈丄不一丈与:  val_12, 丑丂丟丆丗丒丙业丕:  false, 丙丂丒一丗下丘下丟:  丙丂丒一丗下丘下丟, 丄丄丒丘丏一丗丆与:  丄丄丒丘丏一丗丆与, 世七与业一七世丂丒:  世七与业一七世丂丒);
    }
    private void 上丈一丅丏专丌丝丌(in CategoryNames 七丆丒与丗丌丄且丂, ItemPreviewInArmoryInfoScreen 丁丑丞不丗专丑业万)
    {
    
    }
    internal 丙且上东下丏丏丟下 丈丒丛东上丘丅世三()
    {
        return (丙且上东下丏丏丟下)this.丟丘丅业丝丆丟丝丟;
    }
    internal WeaponSkinChanger 世丏万丐丞东丁丆丏()
    {
        if(this.丟丁丛丏三且丞一丘 != 0)
        {
                return (WeaponSkinChanger)this.丟丁丛丏三且丞一丘;
        }
        
        if(this.previewContainer == 0)
        {
                return (WeaponSkinChanger)this.丟丁丛丏三且丞一丘;
        }
        
        this.丟丁丛丏三且丞一丘 = this.previewContainer.GetComponentInChildren<WeaponSkinChanger>(includeInactive:  true);
        return (WeaponSkinChanger)this.丟丁丛丏三且丞一丘;
    }
    internal void 上业丞丂专与专且三(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        PGCompany.丟丝世万东万丆丟上 val_8 = 0;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌())) == false)
        {
            goto label_4;
        }
        
        val_8 = this.上不丟丗丕专专丗丆;
        if(val_8 == null)
        {
            goto label_5;
        }
        
        label_4:
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        if(下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌() == 7)
        {
                val_8 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        }
        
        this.丒万丅业丝丟丁丄丏(三丕上下丗丘丌专丒:  val_8);
        return;
        label_5:
        PGCompany.丟丝世万东万丆丟上 val_7 = 丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  下丅丙一丂丗丅丝七.三与丛丑且丐丈业丌());
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    private void 丒万丅业丝丟丁丄丏(PGCompany.丗丟丄丈东丝丕丄世 三丕上下丗丘丌专丒)
    {
        if(三丕上下丗丘丌专丒 == null)
        {
                return;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if(null == null)
        {
            goto label_3;
        }
        
        return;
        label_2:
        this.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  三丕上下丗丘丌专丒);
        return;
        label_3:
        this.丟业丞丙万下与丏丅(三丕上下丗丘丌专丒:  三丕上下丗丘丌专丒);
    }
    internal void 且一丞丗三一丄万丝(PGCompany.丟丝世万东万丆丟上 三丕上下丗丘丌专丒)
    {
        WeaponSkinChanger val_7 = this.世丏万丐丞东丁丆丏();
        if(val_7 == 0)
        {
                if(this.丛丞专万丈业业七丟 != 0)
        {
                val_7 = this.丛丞专万丈业业七丟.gameObject.GetComponentInChildren<WeaponSkinChanger>();
        }
        
        }
        
        if(val_7 == 0)
        {
                return;
        }
        
        val_7.上丈一万东三东世东(三丕上下丗丘丌专丒:  三丕上下丗丘丌专丒, 丄丕且丆与业下业下:  0);
    }
    internal void 丟业丞丙万下与丏丅(PGCompany.丙丕丑丑丆丂丗丗丟 三丕上下丗丘丌专丒)
    {
        this.丌丐三不丙与丘丟七(七丆丒与丗丌丄且丂:  7, 专丝丏世万东东业且:  三丕上下丗丘丌专丒.业上丙丞丐丄丆丅七(), 丌且丁丌丕丞丙丗与:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
    }
    private void 丛丂丐与下下三东丞(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        UnityEngine.GameObject val_26;
        UnityEngine.GameObject val_27;
        var val_28;
        System.Func<WeaponSkinSettings, System.Boolean> val_30;
        var val_31;
        System.Func<WeaponSkinSettings, System.Boolean> val_33;
        int val_34;
        val_26 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.skinsButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newSkinsCountContainer, 丏业丟一东丂东丘丛:  false);
        val_27 = this.skinsButton;
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        if(val_27 == 0)
        {
                return;
        }
        
        val_27 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_27)) != false)
        {
                val_27 = 丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  下丅丙一丂丗丅丝七.三与丛丑且丐丈业丌());
            if(val_27.Count >= 1)
        {
                val_27 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_27.丂世三丅一万东三三(不七丆万丁一丞七下:  164)) != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.skinsButton, 丏业丟一东丂东丘丛:  true);
            val_27 = 丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  下丅丙一丂丗丅丝七.三与丛丑且丐丈业丌());
            val_28 = null;
            val_28 = null;
            val_30 = ArmoryInfoScreenController.<>c.<>9__98_0;
            if(val_30 == null)
        {
                System.Func<WeaponSkinSettings, System.Boolean> val_11 = null;
            val_30 = val_11;
            val_11 = new System.Func<WeaponSkinSettings, System.Boolean>(object:  ArmoryInfoScreenController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmoryInfoScreenController.<>c::丙丘丕丞一丝万丙丘(WeaponSkinSettings 三丟东丕丄丄下下丑));
            ArmoryInfoScreenController.<>c.<>9__98_0 = val_30;
        }
        
            WeaponSkinSettings val_12 = System.Linq.Enumerable.FirstOrDefault<WeaponSkinSettings>(source:  val_27, predicate:  val_11);
            val_31 = null;
            val_31 = null;
            val_33 = ArmoryInfoScreenController.<>c.<>9__98_1;
            if(val_33 == null)
        {
                System.Func<WeaponSkinSettings, System.Boolean> val_14 = null;
            val_33 = val_14;
            val_14 = new System.Func<WeaponSkinSettings, System.Boolean>(object:  ArmoryInfoScreenController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmoryInfoScreenController.<>c::七七丆丒专万一丝丄(WeaponSkinSettings 三丟东丕丄丄下下丑));
            ArmoryInfoScreenController.<>c.<>9__98_1 = val_33;
        }
        
            val_34 = val_27.Count - (System.Linq.Enumerable.Count<WeaponSkinSettings>(source:  val_27, predicate:  val_14));
            if(val_12 != 0)
        {
                val_27 = Progress.七七世万专丕丁上业.丙丌丒丌丞且丌专丂();
            var val_26 = ~(val_27.万万上上丕七丑丙丐(专丙丐世与丐下不丑:  val_12.SkinIndex));
            val_26 = val_26 & 1;
            val_34 = val_34 - val_26;
        }
        
            if(val_34 >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newSkinsCountContainer, 丏业丟一东丂东丘丛:  true);
            val_27 = this._newSkinsCountLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_27, 丕丗丘丑丛与丑业丒:  val_34);
        }
        
        }
        
        }
        
        }
        
        if(下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌() != 7)
        {
                return;
        }
        
        val_27 = PGCompany.丈三丁三丂一丅丆丆.丑七不且上丗丁一世();
        if((val_27.三丟丐东丗上东下万(且丂丟丈丈丑东丈丙:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())).Count) < 2)
        {
                return;
        }
        
        val_26 = this.skinsButton;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_26, 丏业丟一东丂东丘丛:  true);
    }
    public void ShowSkinsUI()
    {
        var val_9;
        var val_10;
        string val_11;
        var val_12;
        PGCompany.丗丟丄丈东丝丕丄世 val_13;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._galleryTutorialHint, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.skinsUI, 丏业丟一东丂东丘丛:  true);
        CategoryNames val_1 = this.丟丘丅业丝丆丟丝丟.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_1)) == false)
        {
            goto label_6;
        }
        
        val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        val_10 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世();
        val_11 = this.丟丘丅业丝丆丟丝丟.丞一丁业丄一一业且;
        val_12 = 10;
        goto label_11;
        label_6:
        if(val_1 != 7)
        {
            goto label_12;
        }
        
        val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        val_10 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世();
        val_11 = this.丟丘丅业丝丆丟丝丟.丞一丁业丄一一业且;
        val_12 = 20;
        label_11:
        val_13 = val_9.一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_10.丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  20, 丞一丁业丄一一业且:  val_11));
        goto label_18;
        label_12:
        val_13 = 0;
        label_18:
        this.skinsUI.丌丑世三丑丁丗丞万(下丅丙一丂丗丅丝七:  val_13);
    }
    public void HideSkinsUI()
    {
        UnityEngine.GameObject val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false)
        {
            goto label_31;
        }
        
        val_20 = 1152921504848912384;
        if(this.goToAlmanachButton == 0)
        {
            goto label_31;
        }
        
        val_21 = null;
        val_21 = null;
        if((MainMenuController.丄丞丁丈与业上丞丟 == 0) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
        {
            goto label_31;
        }
        
        val_22 = null;
        val_22 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_19;
        }
        
        val_23 = null;
        val_23 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == true)
        {
            goto label_31;
        }
        
        label_19:
        val_20 = 1152921505132351488;
        if((丅丛丟上丁丆上丛专.不七不丙丏上与三一() == null) || (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count > 1))
        {
            goto label_31;
        }
        
        if((AlmanachTutorialManager.TutorialFinished == true) || (ShopNGUIController.丛世丛与丌不丈丐丐() == false))
        {
            goto label_46;
        }
        
        val_24 = null;
        val_24 = null;
        if(((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且())) == false) || (丅丛丟上丁丆上丛专.不七不丙丏上与三一() == null))
        {
            goto label_46;
        }
        
        var val_19 = (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count < 2) ? 1 : 0;
        goto label_51;
        label_46:
        val_25 = 0;
        label_51:
        val_20 = this._galleryTutorialHint;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_20, 丏业丟一东丂东丘丛:  false);
        label_31:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.skinsUI, 丏业丟一东丂东丘丛:  false);
        this.上业丞丂专与专且三(下丅丙一丂丗丅丝七:  this.丟丘丅业丝丆丟丝丟);
    }
    private void 三丗上丛万丅与丘万(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        GoToAlmanachButton val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_19 = this.goToAlmanachButton;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_19, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._galleryTutorialHint, 丏业丟一东丂东丘丛:  false);
        if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false)
        {
                return;
        }
        
        val_19 = this.goToAlmanachButton;
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        if(val_19 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_19 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_19 == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        if(SquadController.丄丘七三上丕世丞业 != 0)
        {
                val_22 = null;
            val_22 = null;
            val_19 = SquadController.丄丘七三上丕世丞业;
            if(val_19.inSquad == true)
        {
                return;
        }
        
        }
        
        val_19 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_19)) == false)
        {
                return;
        }
        
        val_19 = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
        if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_19)) == null)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        this.goToAlmanachButton.丈且东丑丂且万丒丅(丑丝丏丂且不下一东:  下丅丙一丂丗丅丝七, 一专七丟丏且丑丄下:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.goToAlmanachButton, 丏业丟一东丂东丘丛:  true);
        if((AlmanachTutorialManager.TutorialFinished != true) && (丅丛丟上丁丆上丛专.不七不丙丏上与三一() != null))
        {
                var val_18 = (丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count < 2) ? 1 : 0;
        }
        else
        {
                val_24 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._galleryTutorialHint, 丏业丟一东丂东丘丛:  false);
    }
    internal void 东丌丟三丞世一一丑(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丁业丗丈丂七丟东与 = False, Rilisoft.ItemViewer.一丗丟丛丈专丙三丌 下丗丐丙丙丞与与三 = 0, string 丙丂丒一丗下丘下丟, PGCompany.丟丝世万东万丆丟上 丝丞丄丝一丞丗丄丛)
    {
        string val_33;
        CategoryNames val_34;
        string val_35;
        CategoryNames val_36;
        丙且上东下丏丏丟下 val_37;
        int val_38;
        this.上不丟丗丕专专丗丆 = 丝丞丄丝一丞丗丄丛;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._weightObjects, 丏业丟一东丂东丘丛:  false);
        if(下丅丙一丂丗丅丝七 != null)
        {
                CategoryNames val_7 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        }
        
        this.丟丘丅业丝丆丟丝丟 = 下丅丙一丂丗丅丝七;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌())) != false)
        {
                this.一丝丟丞丅不丑丈丂(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丁业丗丈丂七丟东与:  丁业丗丈丂七丟东与);
        }
        else
        {
                if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌())) != false)
        {
                this.丒丝上业丑丐万丘丈(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        }
        else
        {
                if((丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) != false)
        {
                this.丈丌七专丌丛与丆下(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丁业丗丈丂七丟东与:  丁业丗丈丂七丟东与);
        }
        else
        {
                if(0.丒万丕七专不丏丞丌() == 7)
        {
                this.丈丆丅不丁世丞丒丝(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        }
        else
        {
                if((丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) != false)
        {
                this.不与不丏与丕丈一丘(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        }
        
        }
        
        }
        
        }
        
        }
        
        this.丁专丑万业丟专丐一(下丗丐丙丙丞与与三:  下丗丐丙丙丞与与三);
        this.丟丙且丝万与不丑丐();
        this.丛丂丐与下下三东丞(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        this.三丗上丛万丅与丘万(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        System.Collections.Generic.List<System.String> val_13 = new System.Collections.Generic.List<System.String>();
        val_13.Add(item:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        this.万七丁丙丝下七三丙 = val_13;
        if(下丅丙一丂丗丅丝七 != null)
        {
                val_33 = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_33 = 0.业上丙丞丐丄丆丅七();
        }
        
        if(下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌() != 7)
        {
            goto label_32;
        }
        
        PGCompany.丙丕丑丑丆丂丗丗丟 val_19 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        if(val_19 == null)
        {
            goto label_31;
        }
        
        val_33 = val_19.业上丙丞丐丄丆丅七();
        if(val_33 != null)
        {
            goto label_32;
        }
        
        label_31:
        val_33 = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
        label_32:
        if(下丅丙一丂丗丅丝七 != null)
        {
                val_34 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        }
        else
        {
                val_34 = 0.丒万丕七专不丏丞丌();
        }
        
        if(this.丛丞专万丈业业七丟 != 0)
        {
                val_35 = this.丛丞专万丈业业七丟.id;
        }
        
        this.丌丐三不丙与丘丟七(七丆丒与丗丌丄且丂:  val_34, 专丝丏世万东东业且:  val_33, 丌且丁丌丕丞丙丗与:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), 东丒上一上不丈丌上:  0, 丞丑丙丒专丅下业丁:  System.String.__il2cppRuntimeField_static_fields);
        this.HideSkinsUI();
        if(this.丛丞专万丈业业七丟 == 0)
        {
                return;
        }
        
        this.丛丞专万丈业业七丟.SetSelected(丏丈丞丙七丛东七丌:  true, 东丝三一丞下业丂丝:  true);
        if(下丅丙一丂丗丅丝七 != null)
        {
                val_36 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
            var val_28 = (丁业丗丈丂七丟东与 != true) ? 下丅丙一丂丗丅丝七 : 0;
            val_38 = 下丅丙一丂丗丅丝七.丅世且与丏丆下丝丒();
        }
        else
        {
                val_36 = 下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
            val_38 = 0.丅世且与丏丆下丝丒();
            val_37 = 0;
        }
        
        this.丘下丟丁上丏丛且且(丁丑丞不丗专丑业万:  this.丛丞专万丈业业七丟, 七丆丒与丗丌丄且丂:  val_36, 万丞丁不丏丌七专万:  val_37, 丙丂丒一丗下丘下丟:  丙丂丒一丗下丘下丟, 丄丄丒丘丏一丗丆与:  val_38, 世七与业一七世丂丒:  下丅丙一丂丗丅丝七.丝七丘丏丂丂丏上且());
    }
    private void 丁专丑万业丟专丐一(in Rilisoft.ItemViewer.一丗丟丛丈专丙三丌 下丗丐丙丙丞与与三)
    {
        float val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._simpleBGContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._battlePassBGContainer, 丏业丟一东丂东丘丛:  false);
        if(null == 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._battlePassBGContainer, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Transform val_1 = this.transform;
            val_4 = this._battlePassMainPanelY;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._simpleBGContainer, 丏业丟一东丂东丘丛:  true);
            val_4 = this._simpleMainPanelY;
        }
        
        this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丈丆丅不丁世丞丒丝(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        int val_10 = UnityEngine.Mathf.Min(a:  下丅丙一丂丗丅丝七.丝七丘丏丂丂丏上且() + (BalanceController.丕且丄丑世丕丟丅七(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七()))), b:  System.Linq.Enumerable.Max<ItemRarity>(source:  System.Linq.Enumerable.Cast<ItemRarity>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))));
        丞东丑专丛丆丄丝世.丝业丙丟丙丅丐世万<UILabel>(不丗上三丛丒上东丑:  this.rarity, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.rarity, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0428")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0428")) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_10)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_10)));
        this.且且专丏下丄丝丌东(东东世丝业丝一丂丄:  val_10);
        this.上上丈丗丁丆世万丐(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.craftPlashka, 丏业丟一东丂东丘丛:  false);
    }
    private void 不与不丏与丕丈一丘(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        var val_14;
        UILabel val_15;
        string val_16;
        val_14 = 1152921505253916672;
        val_15 = 丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.craftPlashka, 丏业丟一东丂东丘丛:  val_15 ^ 1);
        if(val_15 != true)
        {
                val_14 = (long)丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七()].七东与丄丕丁丛世三();
            this.craftPlashka.color = new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_14], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_14], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_14], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_14]};
            val_15 = this.craftDetails;
            if(下丅丙一丂丗丅丝七 != null)
        {
                val_16 = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_16 = 0.业上丙丞丐丄丆丅七();
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_15, 丕丗丘丑丛与丑业丒:  丆丐三丅丆丗东丑世.三下丏丕丑丘丐丄丛(丐丗丝丕上三丞丝上:  val_16, 丞一丁业丄一一业且:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七()));
        }
        
        丞东丑专丛丆丄丝世.丝业丙丟丙丅丐世万<UILabel>(不丗上三丛丒上东丑:  this.rarity, 丏业丟一东丂东丘丛:  false);
    }
    private void 丒丝上业丑丐万丘丈(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        UISprite val_28;
        ItemRarity val_29;
        var val_30;
        UISprite val_31;
        val_28 = this;
        int val_2 = 丁下万丟且丟丛下业.一丗上丄丆丞三东业(丞丅上丏丂且下丅与:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        val_29 = UnityEngine.Mathf.Min(a:  下丅丙一丂丗丅丝七.丝七丘丏丂丂丏上且() + (BalanceController.丘丛丄业丒一丝丆东(丞世不丒下上上丝丑:  val_2)), b:  System.Linq.Enumerable.Max<ItemRarity>(source:  System.Linq.Enumerable.Cast<ItemRarity>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.rarity, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.一丝丆七丁三三上丒(七丆丒与丗丌丄且丂:  下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌())(上丑三丁丄丛丁万丑.一丝丆七丁三三上丒(七丆丒与丗丌丄且丂:  下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌())) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_29)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_29)));
        丞东丑专丛丆丄丝世.丝业丙丟丙丅丐世万<UILabel>(不丗上三丛丒上东丑:  this.rarity, 丏业丟一东丂东丘丛:  true);
        this.且且专丏下丄丝丌东(东东世丝业丝一丂丄:  val_29);
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丞世不丒下上上丝丑:  val_2)) != false)
        {
                var val_20 = ((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_2), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == 0) ? 1 : 0;
        }
        else
        {
                val_30 = 0;
        }
        
        val_31 = this.craftPlashka;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_31, 丏业丟一东丂东丘丛:  false);
        if(val_30 == 0)
        {
                return;
        }
        
        val_31 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().七丏万丞且丛丌专丞(丞世不丒下上上丝丑:  val_2);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.craftDetails, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_2), arg1:  val_31));
        val_28 = this.craftPlashka;
        val_29 = (long)val_29;
        val_28.color = new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_29], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_29], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_29], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[val_29]};
    }
    private void 丈丌七专丌丛与丆下(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丁业丗丈丂七丟东与)
    {
        丙且上东下丏丏丟下 val_8;
        string val_9;
        val_8 = 下丅丙一丂丗丅丝七;
        if(丁业丗丈丂七丟东与 != false)
        {
                丙且上东下丏丏丟下 val_3 = null;
            val_8 = val_3;
            val_3 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.丟丘丅业丝丆丟丝丟.丒万丕七专不丏丞丌());
            val_3.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  this.丟丘丅业丝丆丟丝丟.丒专丘丙丌业丑丛三());
        }
        
        丞东丑专丛丆丄丝世.丝业丙丟丙丅丐世万<UILabel>(不丗上三丛丒上东丑:  this.rarity, 丏业丟一东丂东丘丛:  false);
        this.且且专丏下丄丝丌东(东东世丝业丝一丂丄:  0);
        this.上上丈丗丁丆世万丐(下丅丙一丂丗丅丝七:  val_3);
        if(val_8 != null)
        {
                val_9 = val_3.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_9 = 0.业上丙丞丐丄丆丅七();
        }
        
        this.丒丗丌万丅丟三丗世(下丅丙一丂丗丅丝七:  val_3, 丅下一丞丝丟丁丁丌:  this.propertiesContainer, 东东世丝业丝一丂丄:  5, 七丁丗丞丄丅东丝丒:  val_9, 丞一丁业丄一一业且:  val_3.业上丙丞丐丄丆丅七());
    }
    private void 一丝丟丞丅不丑丈丂(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丁业丗丈丂七丟东与)
    {
        var val_25;
        string val_26;
        if(丁业丗丈丂七丟东与 == true)
        {
            goto label_1;
        }
        
        label_18:
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        丕丑丙丑丙东丌丘丕 val_3 = 下丅丙一丂丗丅丝七.丒专丘丙丌业丑丛三();
        if(val_3 == null)
        {
            goto label_6;
        }
        
        ItemRarity val_4 = val_3.七东与丄丕丁丛世三();
        goto label_7;
        label_1:
        丙且上东下丏丏丟下 val_7 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.丟丘丅业丝丆丟丝丟.丒万丕七专不丏丞丌());
        val_7.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  this.丟丘丅业丝丆丟丝丟.丒专丘丙丌业丑丛三());
        val_7.丅丟业下与丏专万且(丙业与丙丗丝不丈东:  this.丟丘丅业丝丆丟丝丟.丅世且与丏丆下丝丒());
        val_7.丄七丙丙丝东丆丄下(丙业与丙丗丝不丈东:  this.丟丘丅业丝丆丟丝丟.丝七丘丏丂丂丏上且());
        if(val_7 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_6:
        val_25 = val_2;
        label_7:
        int val_17 = UnityEngine.Mathf.Min(a:  下丅丙一丂丗丅丝七.丝七丘丏丂丂丏上且() + val_25, b:  System.Linq.Enumerable.Max<ItemRarity>(source:  System.Linq.Enumerable.Cast<ItemRarity>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.rarity, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.世丞丞上世丗丒丏丈(丟丆丏且专不丕上专:  val_2.丒万丕七专不丏丞丌())(上丑三丁丄丛丁万丑.世丞丞上世丗丒丏丈(丟丆丏且专不丕上专:  val_2.丒万丕七专不丏丞丌())) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_17)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_17)));
        丞东丑专丛丆丄丝世.丝业丙丟丙丅丐世万<UILabel>(不丗上三丛丒上东丑:  this.rarity, 丏业丟一东丂东丘丛:  true);
        this.且且专丏下丄丝丌东(东东世丝业丝一丂丄:  val_17);
        this.上上丈丗丁丆世万丐(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
        if(val_2 != null)
        {
                val_26 = val_2.与不丞丑七丘丁丂丛();
        }
        else
        {
                val_26 = 0.与不丞丑七丘丁丂丛();
        }
        
        this.丒丗丌万丅丟三丗世(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丅下一丞丝丟丁丁丌:  this.propertiesContainer, 东东世丝业丝一丂丄:  val_2, 七丁丗丞丄丅东丝丒:  val_26, 丞一丁业丄一一业且:  val_2.三与丛丑且丐丈业丌());
    }
    private void 丒丗丌万丅丟三丗世(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, PropertiesArmoryItemContainer 丅下一丞丝丟丁丁丌, ItemRarity 东东世丝业丝一丂丄, string 七丁丗丞丄丅东丝丒, string 丞一丁业丄一一业且)
    {
        string val_4;
        UILabel val_5;
        UISprite val_6;
        val_4 = 丞一丁业丄一一业且;
        val_5 = 东东世丝业丝一丂丄;
        丙且上东下丏丏丟下 val_4 = 下丅丙一丂丗丅丝七;
        bool val_1 = this.丑丘下丒丘丌万专丁(下丅丙一丂丗丅丝七:  val_4);
        val_6 = this.craftPlashka;
        val_4 = val_1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  val_4);
        if(val_1 == false)
        {
                return;
        }
        
        val_6 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
        this.craftPlashka.color = new UnityEngine.Color() {r = val_6[(long)val_5], g = val_6[(long)val_5], b = val_6[(long)val_5], a = val_6[(long)val_5]};
        val_5 = this.craftDetails;
        val_4 = 丆丐三丅丆丗东丑世.三下丏丕丑丘丐丄丛(丐丗丝丕上三丞丝上:  七丁丗丞丄丅东丝丒, 丞一丁业丄一一业且:  val_4);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  val_4);
        if(this.丙业丁丅丗万丞丙且 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丅下一丞丝丟丁丁丌.descriptionText, 丏业丟一东丂东丘丛:  false);
    }
    private void 上上丈丗丁丆世万丐(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        if(this._moduleArmoryInfoScreen == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleArmoryInfoScreen.不丞丄三丗且不东丆(), 丏业丟一东丂东丘丛:  Rilisoft.Singleton<PGCompany.ModulesController>.Instance.与丁上丌丝丟丑一丏());
        this._moduleArmoryInfoScreen.东丌丟三丞世一一丑(丑丝丏丂且不下一东:  下丅丙一丂丗丅丝七);
    }
    internal void 丞丛丗丈且丟丒七丅(bool 丘万丙丂与丕丅世丅 = False)
    {
        object val_29;
        CategoryNames val_30;
        string val_31;
        var val_32;
        var val_33;
        string val_34;
        var val_35;
        var val_36;
        ShopNGUIController val_37;
        var val_38;
        ArmoryInfoScreenController.丗丟且丘丙三丏且专 val_1 = null;
        val_29 = val_1;
        val_1 = new ArmoryInfoScreenController.丗丟且丘丙三丏且专();
        val_30 = 1152921505066536960;
        if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(this.万七丁丙丝下七三丙 == null)
        {
                return;
        }
        
        if(this.万七丁丙丝下七三丙.Count == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  142);
        string val_7 = this.万七丁丙丝下七三丙.Item[0];
        if(val_29 != null)
        {
                val_31 = val_29;
            .丘丂世不丌上且且一 = val_7;
        }
        else
        {
                val_31 = 16;
            mem[16] = val_7;
        }
        
        WeaponManager.三万不上上三一丟丕(丒东业不丐丑丕丄丆:  val_31, 七丆丟丗世丟且丒丆:  false, 丒三且丟丈七丈丙丏:  false, 不丌丟专丙丈丟丘专:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true});
        this.丞丏世丆丄上丆一七();
        bool val_8 = 丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  mem[16]);
        if((val_8 | (WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  mem[16]))) == false)
        {
            goto label_25;
        }
        
        val_32 = null;
        val_32 = null;
        if((WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  mem[16])) == false)
        {
            goto label_30;
        }
        
        label_25:
        if(val_29 != null)
        {
            goto label_49;
        }
        
        label_50:
        label_49:
        int val_12 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  mem[16]);
        if(0 == 0)
        {
            goto label_34;
        }
        
        var val_30 = val_16.丝丈不丗丐不丙丟丁.Count;
        if(val_16.上七不丅丈丁不丛丝 == null)
        {
            goto label_40;
        }
        
        val_33 = val_16.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁;
        int val_19 = val_33.Count;
        goto label_42;
        label_34:
        val_34 = val_31;
        val_30 = val_12;
        if(val_29 != null)
        {
            goto label_57;
        }
        
        goto label_44;
        label_30:
        val_35 = null;
        val_35 = null;
        string val_29 = mem[16];
        val_29 = (~(WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_29))) & 1;
        if(val_29 != null)
        {
            goto label_49;
        }
        
        goto label_50;
        label_40:
        val_33 = 0;
        label_42:
        val_30 = val_33 + val_30;
        if(((丙丞丟丑丗丅专丈一.丂丙丟丅七七丗丄与(丂万丏专丒下丈丂丟:  System.Linq.Enumerable.First<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  val_1, method:  System.Boolean ArmoryInfoScreenController.丗丟且丘丙三丏且专::丈丆丅丌丟丅丄七丙(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌)))).Count) != val_30) || (上丑三丁丄丛丁万丑.不三丛丂世且丗丑东() == false))
        {
            goto label_55;
        }
        
        val_34 = val_16.下丄丈不与世丐业专;
        val_30 = 131072;
        val_30 = 2;
        goto label_57;
        label_55:
        var val_23 = (val_29 != 0) ? 1 : 0;
        val_23 = val_8 | val_23;
        var val_24 = (val_8 != true) ? "Armor_Army_1" : (val_31);
        var val_25 = (val_8 != true) ? 7 : (val_12);
        if(val_23 == true)
        {
            goto label_57;
        }
        
        label_44:
        val_34 = val_31;
        val_30 = val_12;
        label_57:
        val_36 = null;
        val_36 = null;
        val_37 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_37 != 0)
        {
                val_38 = null;
            val_38 = null;
            val_37 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            val_37.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  val_30, 与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_34, 七丆丒与丗丌丄且丂:  val_30), 七丑业业丒七一丂丆:  false);
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            val_30 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            val_30.丆丗世且丆丛丏丞上(丈丌丌万上丅丌丒不:  mem[16], 七丆丒与丗丌丄且丂:  val_12);
        }
        
        val_29 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_29.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void RunUpgradeCompleteAnimation()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.上专丗七丛丝丂丛丐());
    }
    private System.Collections.IEnumerator 上专丗七丛丝丂丛丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ArmoryInfoScreenController.七万丙丏丝业丏专东();
    }
    internal static void 丌世丒万丈丒且丙一()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/upgrade_weapon_end_sound"));
    }
    internal void 丌丐三不丙与丘丟七(CategoryNames 七丆丒与丗丌丄且丂, string 专丝丏世万东东业且, string 丌且丁丌丕丞丙丗与)
    {
        string val_2;
        if(this.与丄丏丞不丐丘丗丘 == null)
        {
                return;
        }
        
        if(this.丛丞专万丈业业七丟 != 0)
        {
                val_2 = this.丛丞专万丈业业七丟.id;
        }
        
        this.丌丐三不丙与丘丟七(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 专丝丏世万东东业且:  专丝丏世万东东业且, 丌且丁丌丕丞丙丗与:  丌且丁丌丕丞丙丗与, 东丒上一上不丈丌上:  0, 丞丑丙丒专丅下业丁:  System.String.__il2cppRuntimeField_static_fields);
    }
    private void 丌丐三不丙与丘丟七(CategoryNames 七丆丒与丗丌丄且丂, string 专丝丏世万东东业且, string 丌且丁丌丕丞丙丗与, int 东丒上一上不丈丌上, string 丞丑丙丒专丅下业丁)
    {
        CategoryNames val_67;
        ItemPreviewInArmoryInfoScreen val_68;
        var val_69;
        var val_70;
        CategoryNames val_71;
        string val_72;
        CategoryNames val_73;
        CategoryNames val_74;
        下业丗丛丕世专丒三 val_75;
        下业丗丛丕世专丒三 val_76;
        int val_77;
        string val_78;
        string val_79;
        string val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        ItemPreviewInArmoryInfoScreen val_87;
        ItemPreviewInArmoryInfoScreen val_88;
        bool val_89;
        ItemPreviewInArmoryInfoScreen val_90;
        System.Collections.Generic.List<ItemPreviewInArmoryInfoScreen> val_91;
        UnityEngine.GameObject val_92;
        var val_93;
        val_67 = 七丆丒与丗丌丄且丂;
        ArmoryInfoScreenController.丂世丁下东业丘且七 val_1 = new ArmoryInfoScreenController.丂世丁下东业丘且七();
        if(val_1 != null)
        {
                val_68 = val_1;
            .七丆丒与丗丌丄且丂 = val_67;
            mem[1152921524423756264] = this;
            mem[1152921524423756280] = 专丝丏世万东东业且;
        }
        else
        {
                mem[24] = this;
            mem[32] = val_67;
            val_68 = 40;
            mem[40] = 专丝丏世万东东业且;
            val_67 = mem[32];
        }
        
        bool val_2 = 上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_67);
        if(val_1 != null)
        {
                val_69 = val_1;
            .丟丁且丝一丕丂三一 = val_2;
            CategoryNames val_67 = mem[32];
            val_70 = 上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  mem[32]);
            val_67 = 上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_67);
            mem[1152921524423756288] = val_67;
            val_71 = mem[32];
            val_72 = mem[40];
            val_73 = val_71;
            val_74 = val_71;
        }
        else
        {
                val_69 = val_1;
            .丟丁且丝一丕丂三一 = val_2;
            val_70 = 上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  mem[32]);
            mem[48] = 上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  mem[32]);
            val_73 = mem[32];
            val_74 = mem[32];
            val_72 = mem[40];
            val_71 = mem[32];
        }
        
        ArmoryInfoScreenController.下业丗丛丕世专丒三 val_10 = null;
        val_75 = val_10;
        val_10 = new ArmoryInfoScreenController.下业丗丛丕世专丒三();
        .丞一丁业丄一一业且 = val_72;
        .七丆丒与丗丌丄且丂 = val_71;
        val_76 = this.与丄丏丞不丐丘丗丘;
        if(val_75 == null)
        {
            goto label_7;
        }
        
        if(val_76 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_76 == null)
        {
            goto label_11;
        }
        
        label_8:
        if((System.String.Equals(a:  (ArmoryInfoScreenController.下业丗丛丕世专丒三)[1152921524423760336].丞一丁业丄一一业且, b:  this.与丄丏丞不丐丘丗丘.丞一丁业丄一一业且)) == false)
        {
            goto label_11;
        }
        
        this.与丄丏丞不丐丘丗丘 = val_75;
        if((ArmoryInfoScreenController.下业丗丛丕世专丒三)[1152921524423760336].七丆丒与丗丌丄且丂 != this.与丄丏丞不丐丘丗丘.七丆丒与丗丌丄且丂)
        {
            goto label_14;
        }
        
        return;
        label_11:
        this.与丄丏丞不丐丘丗丘 = val_75;
        goto label_14;
        label_22:
        丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.itemsGrid.transform.GetChild(index:  0).gameObject);
        label_14:
        if(this.itemsGrid.transform.childCount > 0)
        {
            goto label_22;
        }
        
        this.下且丅丞不三三不且.Clear();
        val_77 = System.String.alignConst;
        if(.丟丁且丝一丕丂三一 != false)
        {
                val_76 = WeaponManager.丄丟上一上丐丄与丆(三不三丟专丘东东丂:  mem[40]);
            val_75 = val_76.GetComponent<WeaponSounds>();
            val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  丌且丁丌丕丞丙丗与, 七丆丒与丗丌丄且丂:  mem[32]);
        }
        else
        {
                val_76 = 0;
            val_75 = 0;
        }
        
        if(mem[32] == 7)
        {
            goto label_34;
        }
        
        val_78 = 丌且丁丌丕丞丙丗与;
        if(val_70 ^ 1 == true)
        {
            goto label_38;
        }
        
        if(val_1 == null)
        {
            goto label_36;
        }
        
        val_79 = mem[40];
        goto label_37;
        label_34:
        val_78 = 丌且丁丌丕丞丙丗与;
        goto label_38;
        label_36:
        val_79 = mem[40];
        label_37:
        val_76 = 丏丄丑上丛不丈且万.丝丛世与丌上三上不(丒丘丏上丙丟丑丕丈:  val_79, 七丆丒与丗丌丄且丂:  mem[32]);
        val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_78, 七丆丒与丗丌丄且丂:  mem[32]);
        label_38:
        if(mem[32] == 7)
        {
                if(val_1 != null)
        {
                val_80 = mem[40];
        }
        else
        {
                val_80 = mem[40];
        }
        
            val_76 = 丏丄丑上丛不丈且万.丝丛世与丌上三上不(丒丘丏上丙丟丑丕丈:  val_80, 七丆丒与丗丌丄且丂:  mem[32]);
            val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_78, 七丆丒与丗丌丄且丂:  mem[32]);
        }
        
        if(mem[48] != false)
        {
                val_76 = 丁下万丟且丟丛下业.丟不与不丞丛丒丅万(丞丅上丏丂且下丅与:  mem[40]);
            val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_78, 七丆丒与丗丌丄且丂:  mem[32]);
        }
        
        if(mem[32] == 150000)
        {
                val_76 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Avatars/"("Avatars/") + mem[40]);
            val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_78, 七丆丒与丗丌丄且丂:  mem[32]);
        }
        
        if(val_73 == 160000)
        {
                val_76 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Gliders_Shop/"("Gliders_Shop/") + mem[40]);
            val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_78, 七丆丒与丗丌丄且丂:  mem[32]);
        }
        
        if(val_74 == 210000)
        {
                val_76 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "VehicleBattleRoyale/Vehicle_Shop/"("VehicleBattleRoyale/Vehicle_Shop/") + mem[40]);
            val_77 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_78, 七丆丒与丗丌丄且丂:  mem[32]);
        }
        
        UnityEngine.GameObject val_37 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.previewPrefab, parent:  this.itemsGrid.transform, worldPositionStays:  true);
        if(val_1 != null)
        {
                val_81 = val_1;
            .丑与丅东万丟世丄丌 = val_37;
        }
        else
        {
                val_81 = 16;
            mem[16] = val_37;
        }
        
        val_81.SetActive(value:  true);
        mem[16].name = "item_0";
        val_82 = null;
        if((System.String.op_Equality(a:  mem[40], b:  丞丑丙丒专丅下业丁)) != false)
        {
                val_83 = null;
        }
        else
        {
                val_85 = null;
            val_84 = 1152921505075273732;
        }
        
        mem[16].transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.zero;
        mem[16].transform.localPosition = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z};
        if((System.String.op_Equality(a:  mem[40], b:  "cape_Custom")) != false)
        {
                val_86 = null;
            val_86 = null;
            Rilisoft.与丄丁丄丙丞下下丙.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  mem[16], 丐丅丁丂丐下丘世丄:  SkinsController.丌七丞东丟丌世且不, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
        }
        
        ItemPreviewInArmoryInfoScreen val_44 = mem[16].GetComponent<ItemPreviewInArmoryInfoScreen>();
        if(val_1 != null)
        {
                val_70 = val_1;
            .丂下业与且丈丟与专 = val_44;
        }
        else
        {
                val_70 = 56;
            mem[56] = val_44;
        }
        
        mem2[0] = 丌且丁丌丕丞丙丗与;
        if(val_1 != null)
        {
                val_87 = mem[56];
        }
        else
        {
                val_87 = mem[56];
        }
        
        mem2[0] = mem[32];
        mem2[0] = val_77;
        mem2[0] = 东丒上一上不丈丌上;
        if(val_1 != null)
        {
                val_88 = mem[56];
            val_89 = .丟丁且丝一丕丂三一;
        }
        else
        {
                val_88 = mem[56];
            val_89 = .丟丁且丝一丕丂三一;
        }
        
        var val_46 = (mem[32] == 150000) ? 1 : 0;
        val_46 = val_46 | (((mem[48] | val_89) == true) ? 1 : 0);
        val_46 = ((mem[32] == 7) ? 1 : 0) | val_46;
        mem2[0] = val_46;
        if(val_1 != null)
        {
                val_90 = mem[56];
        }
        else
        {
                val_90 = mem[56];
        }
        
        mem2[0] = (mem[32] != 160000) ? 1 : 0;
        mem[56].add_OnSelect(丙业与丙丗丝不丈东:  new System.Action<ItemPreviewInArmoryInfoScreen, CategoryNames, 丙且上东下丏丏丟下, System.String, System.Int32, System.Int32>(object:  this, method:  System.Void ArmoryInfoScreenController::丘下丟丁上丏丛且且(ItemPreviewInArmoryInfoScreen 丁丑丞不丗专丑业万, CategoryNames 七丆丒与丗丌丄且丂, 丙且上东下丏丏丟下 万丞丁不丏丌七专万, string 丙丂丒一丗下丘下丟, int 丄丄丒丘丏一丗丆与, int 世七与业一七世丂丒)));
        if(val_1 != null)
        {
                val_91 = this.下且丅丞不三三不且;
            this.丛丞专万丈业业七丟 = mem[56];
        }
        else
        {
                val_91 = this.下且丅丞不三三不且;
            this.丛丞专万丈业业七丟 = mem[56];
        }
        
        val_68 = mem[56];
        val_91.Add(item:  val_68);
        if(val_75 != 0)
        {
                if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_126;
        }
        
        }
        
        丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_76, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void ArmoryInfoScreenController.丂世丁下东业丘且七::丒丙与万业丄丏丌丘(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  mem[32], 丐丑七万丌丂专与丌:  val_75);
        return;
        label_126:
        UnityEngine.Object val_55 = UnityEngine.Resources.Load(path:  "Weapons/"("Weapons/") + 0);
        if(val_55 != null)
        {
                var val_57 = (null == null) ? (val_55) : 0;
        }
        else
        {
                val_92 = 0;
        }
        
        UnityEngine.GameObject val_58 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_92, parent:  mem[16].transform, worldPositionStays:  true);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_58, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        mem2[0] = val_58.transform;
        UnityEngine.Quaternion val_63 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_58.transform.localRotation = new UnityEngine.Quaternion() {x = val_63.x, y = val_63.y, z = val_63.z, w = val_63.w};
        val_58.transform.localPosition = new UnityEngine.Vector3() {x = 5.156778E-43f, y = 7.987401E-43f, z = 7.188661E-43f};
        val_58.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        if(41 == 0)
        {
                return;
        }
        
        val_93 = null;
        val_93 = null;
        Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_58, 丐丅丁丂丐下丘世丄:  SkinsController.丌与世丂丘且下丒丑, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
    }
    public void UpgradeButtonOnClick()
    {
        this.UpgradeButtonHandler(丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
    }
    public void FullUpgradeButtonOnClick()
    {
        this.UpgradeButtonHandler(丐丏上业丈丂与万丞:  true, 丗业丕七且丝丆丝丘:  false);
    }
    public void RarityUpgradeButtonOnClick()
    {
        this.UpgradeButtonHandler(丐丏上业丈丂与万丞:  true, 丗业丕七且丝丆丝丘:  true);
    }
    public void UpgradeButtonHandler(bool 丐丏上业丈丂与万丞, bool 丗业丕七且丝丆丝丘 = False)
    {
        ArmoryInfoScreenController val_9;
        var val_10;
        val_9 = this;
        .丝且与丝丒丟万丁专 = val_9;
        if(this.AnimationIsRunning == true)
        {
                return;
        }
        
        .七丆丒与丗丌丄且丂 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
        val_10 = null;
        val_10 = null;
        val_9 = this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七();
        ShopNGUIController.丏丙丅丕一丑丕丑丑.东丌丙世且丂七丗上(丏世丑万世一七丟丞:  val_9, 下东丒且世万上丏且:  0, 丘世丅丞丌丟丏下丙:  ((this.<丅丁七不丑丅丐丞不>k__BackingField) == true) ? 1 : 0, 丄丒下丁丏丐专万丝:  0, 丐丏上业丈丂与万丞:  丐丏上业丈丂与万丞, 丗业丕七且丝丆丝丘:  丗业丕七且丝丆丝丘, 丟丟丟三东丛丌丘且:  new System.Action(object:  new ArmoryInfoScreenController.丆丕丒不丕不丘丞丒(), method:  System.Void ArmoryInfoScreenController.丆丕丒不丕不丘丞丒::一丂丗不不丞丁丘万()));
    }
    public void BuyButtonButtonOnClick()
    {
        var val_21;
        var val_22;
        var val_23;
        string val_24;
        var val_25;
        var val_26;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        val_21 = null;
        val_21 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七())) != false)
        {
                val_22 = null;
            val_22 = null;
            不丑世不专上专专丝.东一专丅下丌丟上东(丆丐七世世且丏丐业:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七()), 丅专与丒丈丗丒丘丌:  this.transform, 丘不七东下丌丑丁丂:  UnityEngine.LayerMask.LayerToName(layer:  this.gameObject.layer), 丏丄下东丁丝与丌不:  new System.Action(object:  0, method:  static System.Void ShopNGUIController::丅丝一丐丒丙丕丁丏()), 且上丌丏三丏丑七丌:  new System.Action(object:  ShopNGUIController.丏丙丅丕一丑丕丑丑, method:  System.Void ShopNGUIController::专丞丑丑丂丟下丌丁()), 业丑丒丅丝丆丝丕丑:  true);
            return;
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七();
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丘丈丗上丑丞业丁与(丏世丑万世一七丟丞:  val_24, 下东丒且世万上丏且:  0, 丘世丅丞丌丟丏下丙:  ((this.<丅丁七不丑丅丐丞不>k__BackingField) == true) ? 1 : 0);
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  220)) != false)
        {
                val_25 = null;
            val_25 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleEquipButton();
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_24 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且();
        }
        else
        {
                val_24 = 0.丗丛丐丑丛丅丞七且();
        }
        
            ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_24, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
            this.丞丏世丆丄上丆一七();
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        this.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑(), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    public void EquipButtonOnClick()
    {
        var val_5;
        ItemPreviewInArmoryInfoScreen val_6;
        string val_7;
        var val_8;
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        val_5 = null;
        val_5 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.HandleEquipButton();
        val_6 = this.丛丞专万丈业业七丟;
        if(val_6 == null)
        {
            goto label_8;
        }
        
        if(this.丛丞专万丈业业七丟.category != 7)
        {
            goto label_9;
        }
        
        goto label_23;
        label_8:
        if(this.丛丞专万丈业业七丟 == null)
        {
            goto label_11;
        }
        
        val_6 = this.丛丞专万丈业业七丟;
        if(this.丛丞专万丈业业七丟.category == 7)
        {
            goto label_23;
        }
        
        label_9:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.丛丞专万丈业业七丟.category)) == false)
        {
            goto label_16;
        }
        
        val_7 = 丁下万丟且丟丛下业.丆丏丒丆万丄且丗丛(丗丑丐丕丟丝且下丕:  this.丛丞专万丈业业七丟.id);
        goto label_22;
        label_16:
        val_7 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.丛丞专万丈业业七丟.id);
        if(val_7 != null)
        {
            goto label_22;
        }
        
        val_6 = this.丛丞专万丈业业七丟;
        label_23:
        val_7 = this.丛丞专万丈业业七丟.id;
        label_22:
        val_8 = null;
        val_8 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  val_7, 丂丒丒丆且丝丘丈丟:  this.丛丞专万丈业业七丟.id, 丘丐丝丟业丘丏东专:  this.propertiesContainer, 东丈丒三丞与业世一:  false, 丐丙丒丈丄不一丈与:  0, 丑丂丟丆丗丒丙业丕:  false, 丙丂丒一丗下丘下丟:  0, 丄丄丒丘丏一丗丆与:  0, 世七与业一七世丂丒:  0);
        return;
        label_11:
    }
    public void WatchAdvertisementButtonOnClick()
    {
        if(Rilisoft.WeaponSpeedUpController.丑七不且上丗丁一世() == null)
        {
            
        }
    
    }
    public void TryGunOnClick()
    {
    
    }
    public void RotateSelectedItem(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.丛丞专万丈业业七丟 == 0)
        {
                return;
        }
        
        this.丛丞专万丈业业七丟.DragRotate(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    public void HandleCraftButtonClicked()
    {
        var val_2;
        ButtonClickSound.丁业上丏不丕三丗不();
        val_2 = null;
        val_2 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丅丁与上丝丆七业丄(丏世丑万世一七丟丞:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七(), 下东丒且世万上丏且:  0, 丄丒下丁丏丐专万丝:  0);
        this.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.丟丘丅业丝丆丟丝丟, 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    public void HandleBuyDetailsButtonClicked()
    {
        null = null;
        bool val_2 = ShopNGUIController.丏丙丅丕一丑丕丑丑.下丕三丄三丕丘东丒(丆万一不丌且东丐丐:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
    }
    public void HandleGoToGatchaButtonClicked()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐东丕专一世丆丑且(丏世丑万世一七丟丞:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
    }
    public void HandleGoToContestButtonClicked()
    {
        上丑三丁丄丛丁万丑.一下丛三与丙丅丘三();
        .Type = 14;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
        {
                return;
        }
        
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public void HandleGoToRouletteButtonClicked()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丞丘三世丌丕业丝丞(丏世丑万世一七丟丞:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
    }
    public void HandleGoToChestsEventButtonClicked()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.业丄丘丗丏丒与三专(丑丝丏丂且不下一东:  this.丟丘丅业丝丆丟丝丟);
    }
    public void HandleGoToEventStoreButtonClicked()
    {
        null = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丛丈丌丒下丘专不万(丞丅上丏丂且下丅与:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七());
    }
    public void SpeedUpButtonOnClick()
    {
        var val_3;
        if(this.AnimationIsRunning != false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丝丂丒丛丙不三且不(丞一丁业丄一一业且:  this.丟丘丅业丝丆丟丝丟.业上丙丞丐丄丆丅七(), 丛丘丑丗万丞上下丆:  0, 丘世丅丞丌丟丏下丙:  ((this.<丅丁七不丑丅丐丞不>k__BackingField) == true) ? 1 : 0, 丈丂丑七丆三丙一丕:  false);
    }
    private System.Collections.IEnumerator 丞丏世丆丄上丆一七(float 丆丐七丅丆丗丛上与)
    {
        ArmoryInfoScreenController.丆丞丐专丂丑丙东七 val_1 = new ArmoryInfoScreenController.丆丞丐专丂丑丙东七();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 且且专丏下丄丝丌东(ItemRarity 东东世丝业丝一丂丄)
    {
        .东东世丝业丝一丂丄 = 东东世丝业丝一丂丄;
        if(this.frameSprites == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UISprite>(丌丛丏业世丄丞三丌:  this.frameSprites, 七丐丅专且专七三丆:  new System.Action<UISprite>(object:  new ArmoryInfoScreenController.丒丕丕丕且丙下丐丞(), method:  System.Void ArmoryInfoScreenController.丒丕丕丕且丙下丐丞::专与丘丞丙下与丒且(UISprite 与丄丈丘丟丕丏丐丁)));
    }
    private bool 丑丘下丒丘丌万专丁(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        丙且上东下丏丏丟下 val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        System.Func<TSource, System.Boolean> val_60;
        var val_61;
        var val_62;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Collections.Generic.IEnumerable<Rilisoft.OfferItem>> val_64;
        val_49 = 下丅丙一丂丗丅丝七;
        ArmoryInfoScreenController.丞丘东万万专万丆丏 val_1 = new ArmoryInfoScreenController.丞丘东万万专万丆丏();
        .下丅丙一丂丗丅丝七 = val_49;
        val_50 = 1152921505286238208;
        val_51 = null;
        val_51 = null;
        val_49 = (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七;
        if(((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  val_49.业上丙丞丐丄丆丅七())) == true) || ((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == true))
        {
            goto label_21;
        }
        
        val_52 = null;
        val_52 = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_21;
        }
        
        val_53 = null;
        val_53 = null;
        if((WeaponManager.丁丟丟一下专万丒丒.Contains(item:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_21;
        }
        
        val_54 = null;
        val_54 = null;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_37;
        }
        
        label_21:
        if((丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_30;
        }
        
        label_37:
        val_55 = 0;
        goto label_31;
        label_30:
        if(this.丙业丁丅丗万丞丙且 != false)
        {
                if((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) <= 0)
        {
                if(this.丙业丁丅丗万丞丙且 == true)
        {
            goto label_37;
        }
        
        }
        
        }
        
        val_56 = null;
        val_56 = null;
        val_55 = System.String.op_Inequality(a:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), b:  WeaponManager.丙丟丂丗丛丟丑东丑);
        label_31:
        丕东上一丏丛丝世丒 val_20 = 业丌丐丈丛丙丐三下.专丆丙丂丞丕丞上丟(下丅丙一丂丗丅丝七:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        bool val_21 = (val_20.<业丌丛丅丁丌万丏丛>k__BackingField) >> 48;
        bool val_22 = (val_20.<业丌丛丅丁丌万丏丛>k__BackingField) >> 32;
        if(( & 1) != 0)
        {
                val_57 = 1;
        }
        else
        {
                val_57 = 0;
        }
        
        var val_23 = (val_57 == 0) ? 1 : 0;
        if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) != true)
        {
                val_59 = null;
            val_59 = null;
            val_58 = WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  (ArmoryInfoScreenController.丞丘东万万专万丆丏)[1152921524426944464].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        }
        
        var val_29 = (val_55 == true) ? 1 : 0;
        val_58 = val_58 ^ 1;
        val_29 = val_29 & val_58;
        val_60 = val_29 & 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() ^ 1;
        if(PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() == false)
        {
            goto label_55;
        }
        
        var val_35 = (PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().下丆丅丕丒上世业丘() != 6) ? 1 : 0;
        val_35 = val_60 & val_35;
        if(val_35 == true)
        {
            goto label_59;
        }
        
        label_61:
        val_61 = 0;
        goto label_60;
        label_55:
        if(val_60 == false)
        {
            goto label_61;
        }
        
        label_59:
        val_62 = null;
        val_62 = null;
        val_64 = ArmoryInfoScreenController.<>c.<>9__138_0;
        if(val_64 == null)
        {
                System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Collections.Generic.IEnumerable<Rilisoft.OfferItem>> val_38 = null;
            val_64 = val_38;
            val_38 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Collections.Generic.IEnumerable<Rilisoft.OfferItem>>(object:  ArmoryInfoScreenController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.OfferItem> ArmoryInfoScreenController.<>c::丟丕世丒三丑丞丒丆(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            ArmoryInfoScreenController.<>c.<>9__138_0 = val_64;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_39 = System.Linq.Enumerable.SelectMany<Rilisoft.业丙丘丆东丈丕丂丄, Rilisoft.OfferItem>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40), selector:  val_38);
        val_50 = 1152921504616005632;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_45 = null;
        val_60 = val_45;
        val_45 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean ArmoryInfoScreenController.丞丘东万万专万丆丏::一丟且专丂丞丑万丌(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
        bool val_46 = System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_39, predicate:  val_45);
        val_61 = (((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_39, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean ArmoryInfoScreenController.丞丘东万万专万丆丏::丟丘丛丅不丑丝丝丙(Rilisoft.OfferItem 三丟东丕丄丄下下丑)))) | (System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_39, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_1, method:  System.Boolean ArmoryInfoScreenController.丞丘东万万专万丆丏::丅七丕丈丙丛丐丈万(Rilisoft.OfferItem 三丟东丕丄丄下下丑))))) & val_46) ^ 1;
        label_60:
        val_46 = val_61;
        return (bool)val_46;
    }
    public ArmoryInfoScreenController()
    {
        this.SelfDestroyOnClose = true;
        this.下且丅丞不三三不且 = new System.Collections.Generic.List<ItemPreviewInArmoryInfoScreen>();
        this.业丕下三丆世与丝丄 = 1f;
        this._battlePassMainPanelY = 24f;
    }

}
