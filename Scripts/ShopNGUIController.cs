using UnityEngine;
public sealed class ShopNGUIController : MonoBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    private UnityEngine.GameObject 东丗丘丄东丒七下下;
    public ArmorViewController armorViewController;
    public MyCenterOnChild carouselCenter;
    public int itemIndexInCarousel;
    public UIPanel scrollViewPanel;
    public UIGrid wrapContent;
    private static System.Action 丞丁丝丆丕下三且与;
    private static System.Action 丗丟万丂丘丈专丄丂;
    private System.EventHandler 丏丂丙一业一一不专;
    internal Rilisoft.BankBannersHolder bannersHolder;
    public UnityEngine.GameObject _tutorialHintsContainer;
    public UnityEngine.GameObject _tutorialHintsExtContainer;
    public UnityEngine.GameObject _cellHintObjectToMoveBuyTutorial;
    public UnityEngine.GameObject _petTutorialHintsContainer;
    public UnityEngine.GameObject _upgradeTutorialHintsContainer;
    public UnityEngine.GameObject _cellHintObjectToMoveUpgradesTutorial;
    public UnityEngine.GameObject _blockersPetTutorial;
    public UnityEngine.GameObject _blockersUpgradeTutorial;
    private UnityEngine.AudioClip buyUpgradeWear;
    private UIGrid modulesCategoriesGrid;
    private System.Collections.Generic.List<UnityEngine.GameObject> moduleObjects;
    public PGCompany.InventoryItemInfoController inventoryItemInfoContoller;
    private const float 万丄丕丛丞不三业丐 = 12;
    internal static ShopNGUIController 丏丙丅丕一丑丕丑丑;
    internal static float 上丈丂丁三丂业丛丝;
    private static System.Collections.Generic.List<UnityEngine.Camera> 丟丌丞万丕万丐丐上;
    private static bool 下丙丟且丕丆丌东业;
    private static int 丟与丌三世丂下丗万;
    private static bool 专丏丄丙一一丆丌三;
    private readonly System.Collections.Generic.Dictionary<世丕丑七且丝七不不, bool> 不丞丝丑一东丅七丏;
    private readonly System.Collections.Generic.Dictionary<世丕丑七且丝七不不, CategoryNames> 且七丆不专世丂丒三;
    private string 丗世一丄专丌丆丐丘;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private ShopItemsRowContainer[] 上丟丞且丞丏丑上丏;
    private bool 万世丛三万丘丙丗丘;
    private bool 万丞丂三下世丌丑丗;
    private System.Collections.Generic.List<丙且上东下丏丏丟下> 万丕丛丝丑丗下丁丘;
    private System.Collections.Generic.HashSet<int> 丅丐丄专丏世丝七丞;
    private UnityEngine.GameObject 丆丘一丕丒丁业丅丞;
    private UnityEngine.Material[] 丘丙丕丈七下丏且丆;
    private float 不上专丞丆七七丏业;
    private bool 业且丌下七万丑丑丈;
    private bool 万专丁丒丛与东七丁;
    private UnityEngine.Texture 专专不丈丛丆丌丝丒;
    private bool 丏且丛七丗丛丗丞丘;
    private System.Nullable<UnityEngine.Color> 与丕专丛世丛丅丒东;
    private System.Nullable<bool> 专丆丐丙丒丌七东丙;
    private bool 丄且丆丛丗丆丗丙丙;
    private float 丙丘丙丆万丘上丘丌;
    private int 专丏丒世丄且业三丕;
    private UnityEngine.Rect 丘下丆丅与下丑丑三;
    public UnityEngine.GameObject ActiveObject;
    public AnimationCoroutineRunner animationCoroutineRunner;
    public UnityEngine.GameObject armorLock;
    public UIPanel armoryRootPanel;
    public UIButton backButton;
    public UnityEngine.GameObject backButtonBlocker;
    public System.Collections.Generic.List<UILabel> backupWeaponsUnlockedItems;
    public System.Collections.Generic.List<UILabel> armorUnlockedItems;
    public System.Collections.Generic.List<UILabel> wearSupercategoryUnlockedItems;
    public System.Collections.Generic.List<UILabel> modulesSupercategoryUnlockedItems;
    public Rilisoft.BankShopViewGuiElement bankShopView;
    public UnityEngine.Transform bottomPointForShader;
    public UnityEngine.Transform topPointForShader;
    public System.Collections.Generic.List<UnityEngine.Transform> buttonContainers;
    internal System.Action<string> 且与丛丈丁丟专丈丑;
    internal System.Action<string> 丅丝业丑丑丆丆丞丈;
    public UILabel caption;
    private bool 东且丅丏三下下丂万;
    public CategoryNames CategoryToChoose;
    private CharacterInterfaceV2 丘丌丞丑业丑丗上丟;
    public UnityEngine.Transform characterPoint;
    public UnityEngine.GameObject craftUnavailable;
    public UnityEngine.GameObject royaleUnavailable;
    public UnityEngine.GameObject gadgesUnavailable;
    public UnityEngine.GameObject modulesUnavailable;
    private UnityEngine.Transform 丕丐东下丒与一丈丆;
    public bool EnableConfigurePos;
    public UnityEngine.GameObject equipped;
    public UIButton facebookLoginLockedSkinButton;
    public UIButton upgradeButton;
    public UIButton buyButton;
    public UIButton equipButton;
    public UIButton unequipButton;
    public UIButton infoButton;
    public UIButton unlockButton;
    public UIButton createButton;
    public UIGrid firstGrid;
    public float firstOFfset;
    public FixedSlider fixedSlider;
    public UnityEngine.GameObject gadgetBlocker;
    public System.Collections.Generic.List<UILabel> gadgetsSupercategoryUnlockedItems;
    public System.Collections.Generic.List<UILabel> glidersNewItems;
    public UnityEngine.GameObject grid1Header;
    public UnityEngine.GameObject grid2Header;
    public UIScrollView gridScrollView;
    public UnityEngine.GameObject gridSlider;
    public UITable gridsTable;
    public PropertiesHideSHow hideButton;
    private float 东世七上东丐丁丑东;
    private UnityEngine.Transform <七且丆丙丌丞丂丘丗>k__BackingField;
    internal static bool 东丁丝丝丘且丌丅丗;
    internal ArmoryInfoScreenController 上三不丑业七不万上;
    private UnityEngine.Transform 丗丛丝丄丁丟丅丁丟;
    private UnityEngine.Transform 丒丁丗丙丝不丆丘七;
    private bool 丁丝丁上丂上专丐业;
    private int 丗上一丂且丛业丐丄;
    private int 世丂丟丒且丅上业丒;
    public UIGrid itemsGrid;
    public UIWrapContent itemsWrapContainer;
    private float 东丌丆一专与丝丕丝;
    public UnityEngine.GameObject leagueLock;
    private 丙且上东下丏丏丟下 且丛丌丌七丈丝丒丈;
    private bool 下丏七丑丙丘且丈丒;
    private 丙且上东下丏丏丟下 专丑下东丙丞丏七丄;
    private float 丐丕东业丏丂丘丏与;
    private float 丈丞专丒丒上丝三丏;
    private float 丙七丛丝七丆七丛七;
    public UnityEngine.GameObject mainPanel;
    public System.Collections.Generic.List<UILabel> meleeWeaponsUnlockedItems;
    public UnityEngine.GameObject moreSetsAreComingSoon;
    public System.Collections.Generic.List<UnityEngine.Light> mylights;
    public UILabel noItemLabel;
    public UnityEngine.GameObject noEggs;
    public UnityEngine.GameObject noOffersAtThisTime;
    public System.Collections.Generic.List<UnityEngine.Camera> ourCameras;
    public UnityEngine.GameObject panelProperties;
    public UnityEngine.GameObject returnEveryDay;
    public AnimationCoroutineRunner petProfileAnimationRunner;
    public UISprite petUpgradeIndicator;
    public System.Collections.Generic.List<UILabel> petUpgradePointsLabels;
    public UnityEngine.GameObject petUpgradesInSpecial;
    public System.Collections.Generic.List<UILabel> premiumWeaponsUnlockedItems;
    public System.Collections.Generic.List<UILabel> primaryWeaponsUnlockedItems;
    public PropertiesArmoryItemContainer propertiesContainer;
    public UnityEngine.GameObject purchaseSuccessful;
    public System.Collections.Generic.List<UILabel> purchaseSuccessfulLabels;
    public UnityEngine.Transform rentScreenPoint;
    internal System.Action 丏丐世且丑丅丘丅丟;
    public System.Collections.Generic.List<UILabel> royaleAvatarsNewItems;
    public System.Collections.Generic.List<UILabel> royaleHatsNewItems;
    public System.Collections.Generic.List<UILabel> royaleSupercategoryUnlockedItems;
    public UnityEngine.GameObject hintGalleryTapOnGun;
    public UnityEngine.GameObject hintGalleryTapOnWeaponsCategory;
    public UnityEngine.Vector3 offsetHintTapOnGun;
    public float secondOffset;
    public UISprite setMiniIconInProperties;
    private UIButton shootButton;
    public System.Collections.Generic.List<UILabel> shovelsRoyaleNewItems;
    public UIToggle showArmorButton;
    public UIToggle showMaskButton;
    public UIToggle showHatButton;
    public UIToggle showCapeButton;
    public UIToggle showBootsButton;
    public UIToggle showAltArmorButton;
    public UIToggle showAltArmorExoPilotButton;
    public UIToggle showAltArmorHalloween2018Button;
    public UIToggle showAltArmorPilgrim2018Button;
    public UIToggle showAllWeaponSkinsToggle;
    public UnityEngine.GameObject sniperCategorBlinkForTutorial;
    public UnityEngine.GameObject armorCategoryBlinkForTutorial;
    public System.Collections.Generic.List<UILabel> sniperWeaponsUnlockedItems;
    public System.Collections.Generic.List<UILabel> specialWeaponsUnlockedItems;
    public UnityEngine.GameObject stub;
    public CategoryButtonsController superCategoriesButtonController;
    public UnityEngine.GameObject superIncubatorButton;
    private bool 丐下上丆丈丌丌丗三;
    public System.Collections.Generic.List<UILabel> moduleChestUnlockedItems;
    public System.Collections.Generic.List<UILabel> modulesUnlockedItems;
    public System.Collections.Generic.List<UILabel> supportGadgetsUnlockedItems;
    public System.Collections.Generic.List<UILabel> throwingGadgetsUnlockedItems;
    private float 丙丗丅上三三与丑丙;
    public System.Collections.Generic.List<UILabel> toolsGadgetsUnlockedItems;
    public System.Collections.Generic.List<UILabel> trailsRoyaleNewItems;
    public System.Collections.Generic.List<UILabel> transportNewItems;
    public UIButton tryGun;
    private bool 一世丏丏丆专与丐丞;
    private float 业丕下三丆世与丝丄;
    public UnityEngine.AudioClip upgradeBtnSound;
    public UnityEngine.AudioClip upgradeBtnPetSound;
    public UnityEngine.GameObject UpgradeFinishedParticles;
    public UnityEngine.GameObject UpgradeParticles;
    public UnityEngine.GameObject upgradingArmorIndicator;
    public UnityEngine.GameObject[] upgradingIndicators;
    public UnityEngine.GameObject[] upgradingVehicleIndicators;
    public UIGrid miscCategoriesGrid;
    public UIGrid weaponCategoriesGrid;
    public UIGrid wearCategoriesGrid;
    public UIGrid gridCategoriesLeague;
    public UIGrid petsGrid;
    public UIGrid gadgetsGrid;
    public UIGrid bestCategoriesGrid;
    public UIGrid craftCategoriesGrid;
    public UIGrid battleRoyaleCategoriesGrid;
    public System.Collections.Generic.List<UILabel> weaponSupercategoryUnlockedItems;
    public UnityEngine.GameObject weaponBlocker;
    public UILabel weaponBlockerLabel;
    public UnityEngine.GameObject wearBlocker;
    public System.Collections.Generic.List<UILabel> wearNameLabels;
    public System.Collections.Generic.List<UILabel> skinNameLabels;
    public System.Collections.Generic.List<UILabel> armorNameLabels;
    public System.Collections.Generic.List<UIRect> widgetsToUpdateAnchorsOnStart;
    public UnityEngine.Transform moduleInsertPanelTransform;
    internal PGCompany.ModuleInsertPanel 丆一丂丕三丄丞丆上;
    private PGCompany.ShopItemInfoUI _shopItemInfoUI;
    private System.Collections.Generic.List<string> 丅丛丟七上丅丑世东;
    private UnityEngine.GameObject _openLoadoutsButton;
    private UnityEngine.Transform _loadoutsUiPoint;
    private float 专丝丈丝万不丁不专;
    private bool <丌世专万丞不丞丒与>k__BackingField;
    private CategoryNames <东丒不且丟丞丆丑丈>k__BackingField;
    private CategoryNames <与一丐丟丗三一东丂>k__BackingField;
    internal System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 东万丟丏丁丐丘丁丕;
    private static FilterMaps 丑万与丞丄丟丁丑丗;
    private static System.Action<bool> 上丒丅丅丅不丕丘丁;
    private CraftNewItemWindowController 专丐与东下专丄与世;
    private bool 丗业世丌与丂且与丂;
    private static bool 丆丂丘且下世上丆丁;
    private static UnityEngine.Coroutine 上专丕丐东丙丛丘上;
    private bool 丈丌丐丄丆丑业专七;
    private static System.Action 丄丆下万丛丅丒丘七;
    private static System.Action 丈丘下丏丆丐业丌丄;
    private static System.Action<string> 丑丑业万万东丅丑丟;
    internal UnityEngine.Transform 丟丞下不丙丒丝上一;
    internal static bool 丞业丙三丙丄丏丞丘;
    internal 丙且上东下丏丏丟下 丁七丁丞丞丟丒业丅;
    internal CategoryNames 丌不丒万万丟丞上与;
    internal FilterMaps 丕丏丑丏丏丂与东丏;
    internal bool 专丂丏丟丙丂丘丛丟;
    private PGCompany.Ads.丂丐与不丘不下丂上 业丈丌丌七丛丆丝上;
    private UnityEngine.Vector3 丛丏专专世下丘丈上;
    private UnityEngine.Vector3 丆丌丟丅丘丑业丒丄;
    private UnityEngine.Vector3 丁丝世下一丟丅万东;
    private UnityEngine.Transform 专丟世一丟丐丞丙丈;
    private UnityEngine.Vector3 下世一丒世三丂专丗;
    private UnityEngine.Vector3 丝上丏丕丟与丑丆一;
    private UnityEngine.Vector3 丆下丒东丐丐丕丌丟;
    private UnityEngine.Vector3 丐且且一三业东丛丛;
    private UnityEngine.Coroutine 丅七丏一丒下丏丏丆;
    private float 专三不丅丂丌一万七;
    public UnityEngine.GameObject modulesTutorialChooseCraft;
    public UnityEngine.GameObject modulesTutorialChooseChestsCategory;
    public UnityEngine.GameObject modulesTutorialStartOpeningChest;
    public UnityEngine.GameObject modulesTutorialSpeedupChest;
    public UnityEngine.GameObject modulesTutorialOpenChest;
    public UnityEngine.GameObject modulesTutorialChooseWeapons;
    public UnityEngine.GameObject modulesTutorialChooseWeaponConcreteCategory;
    public UnityEngine.GameObject modulesTutorialGoInfo;
    public UnityEngine.GameObject modulesTutorialChooseWear;
    public UnityEngine.GameObject modulesTutorialChooseArmorCategory;
    public UnityEngine.GameObject modulesTutorialEnterArmorModules;
    public UnityEngine.Transform weaponCategoryHint;
    public UnityEngine.Transform modulesTutorialArmoryCellHoleContainer;
    public UnityEngine.Transform modulesTutorialArmoryCellHole;
    private UnityEngine.GameObject[] 万丂丘丘与丝丁万上;
    internal System.Action 丙丟丝丂不丈专丅丅;
    private static System.Action 丙丕丕丕且丕丐丛业;
    
    // Properties
    internal bool 丆一丏世丕业业与七 { get; }
    public UnityEngine.Transform 丞不丌不丏世丐专与 { get; set; }
    internal PGCompany.ShopItemInfoUI 丛一丑丙丌丟丈丆丟 { get; }
    public UIGrid[] 且不一丈三世丏丟东 { get; }
    internal 丙且上东下丏丏丟下 与丛专丁一不丟丒丐 { get; set; }
    internal bool 丏专一七丏三丛丟丞 { get; set; }
    internal CategoryNames 且丁丟业万丒丑丐丑 { get; set; }
    internal CategoryNames 丄且丒丂丏丘且丂丝 { get; set; }
    internal UnityEngine.Camera 丝业丑世专丟三不丗 { get; }
    internal bool 丆三丗丕丘丄七丝下 { get; }
    internal System.Collections.Generic.List<BaseArmoryCell> 三七与丟万东丒丟丕 { get; }
    internal System.Collections.Generic.List<BaseArmoryCell> 丐丙丘世丗丏丒七丙 { get; }
    internal 世丕丑七且丝七不不 不丘上三三丒丘且东 { get; }
    internal static FilterMaps 丗丅下丞不丗与丗丞 { get; }
    internal static bool 下丐丙专丕丙丗万丕 { get; }
    internal CharacterInterfaceV2 丛丝七丐丈丟丏丗丂 { get; }
    internal UnityEngine.Transform 丂下专丌丘丛下丝丝 { get; }
    internal UnityEngine.Transform 丁东丌丐丁丞上丑丝 { get; }
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    internal static bool 丁丞丅三丒三丆业丏 { get; set; }
    internal static bool 丙丑丑下丙专丘丘丒 { get; set; }
    
    // Methods
    internal void 一丅世下丆丂丘丒与(丙且上东下丏丏丟下 与丝丕与丙不与丗丆, bool 丅且丝上丑与丑丑不 = False)
    {
    
    }
    private void 丞世与与丆一与丗上()
    {
        this.丞世与与丆一与丗上(专丐丌东万与丌丕丘:  this.carouselCenter.centeredObject);
    }
    private void 丞世与与丆一与丗上(UnityEngine.GameObject 专丐丌东万与丌丕丘)
    {
        UnityEngine.GameObject val_7;
        if(专丐丌东万与丌丕丘 != 0)
        {
                val_7 = this.东丗丘丄东丒七下下;
            if(专丐丌东万与丌丕丘 != val_7)
        {
                this.东丗丘丄东丒七下下 = 专丐丌东万与丌丕丘;
            ShopCarouselElement val_3 = 专丐丌东万与丌丕丘.GetComponent<ShopCarouselElement>();
            val_7 = val_3.itemID;
            丙且上东下丏丏丟下 val_4 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_7, 七丆丒与丗丌丄且丂:  7);
        }
        
        }
        
        if(this.EnableConfigurePos == false)
        {
                return;
        }
        
        if(专丐丌东万与丌丕丘 == 0)
        {
                return;
        }
        
        专丐丌东万与丌丕丘.GetComponent<ShopCarouselElement>().SetPos(丅丐下东不丅专下丆:  1f, 丛上丙丄丄七丈且丅:  null);
    }
    internal static void 三东丌专丟万且业上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  ShopNGUIController.万丄丕丛丞不三业丐, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丏一不世下丂丁三丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  ShopNGUIController.万丄丕丛丞不三业丐, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal void 一丛丈上且不丟丑万()
    {
        null = null;
        if(ShopNGUIController.万丄丕丛丞不三业丐 == 0)
        {
                return;
        }
        
        ShopNGUIController.万丄丕丛丞不三业丐.Invoke();
    }
    public static void add_Close(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ShopNGUIController.丗丟万丂丘丈专丄丂, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丗丟万丂丘丈专丄丂 != 1152921505261215752);
    
    }
    public static void remove_Close(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ShopNGUIController.丗丟万丂丘丈专丄丂, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丗丟万丂丘丈专丄丂 != 1152921505261215752);
    
    }
    internal void 且丘三丛丕不万丒七(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏丂丙一业一一不专, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏丂丙一业一一不专 != 1152921539050888808);
    
    }
    internal void 与万丐世七丞七丟丛(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏丂丙一业一一不专, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏丂丙一业一一不专 != 1152921539051025384);
    
    }
    internal bool 丙丘万丒丏丂七丘丙()
    {
        return (bool)this.万世丛三万丘丙丗丘;
    }
    public UnityEngine.Transform get_infoScreen()
    {
        return (UnityEngine.Transform)this.<七且丆丙丌丞丂丘丗>k__BackingField;
    }
    private void 丛一丅丘上万不丛丅(UnityEngine.Transform 丙业与丙丗丝不丈东)
    {
        this.<七且丆丙丌丞丂丘丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.ShopItemInfoUI 且万不世丄世业丌丙()
    {
        return (PGCompany.ShopItemInfoUI)this._shopItemInfoUI;
    }
    public UIGrid[] get_categoriesGrids()
    {
        UIGrid[] val_1 = new UIGrid[7];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.weaponCategoriesGrid != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.weaponCategoriesGrid == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.weaponCategoriesGrid;
        val_1[1] = this.wearCategoriesGrid;
        val_1[2] = this.gadgetsGrid;
        val_1[3] = this.miscCategoriesGrid;
        val_1[4] = this.battleRoyaleCategoriesGrid;
        val_1[5] = this.petsGrid;
        val_1[6] = this.craftCategoriesGrid;
        return val_1;
    }
    public void HandlePropertiesPopupButton()
    {
        if(this.propertiesContainer == null)
        {
                return;
        }
        
        PropertiesPopupController val_1 = this.propertiesContainer.丛且丒万丞丝丞丝丕();
        if(val_1 == null)
        {
                return;
        }
        
        val_1.丈且东丑丂且万丒丅(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
    }
    public void HandleGoToClans()
    {
        var val_9;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null) || (this.且丛丌丌七丈丝丒丈 == null))
        {
            goto label_3;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_6;
        }
        
        val_9 = 3;
        goto label_7;
        label_3:
        this.HandleGoToClanLobbyButton();
        return;
        label_6:
        label_7:
        上丑三丁丄丛丁万丑.与丒丐丗丝一万丒业(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七(), 且丂专丄丄丕丝丈一:  (((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) & true) != 0) ? (4 + 1) : 4);
    }
    private void 丙丁丗专丕丙丅业上()
    {
        ArmoryInfoScreenController val_10 = this;
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
                return;
        }
        
        if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丆与与七丛丁七业丛(丁丅丈丌丟世丗丗丟:  0, 下丅丙一丂丗丅丝七:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
                return;
        }
        
        this.丙丑丘业丕丗丗不丘();
        val_10 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject;
        if(val_10.activeInHierarchy == false)
        {
                return;
        }
        
        val_10 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_10.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_10.丈丒丛东上丘丅世三(), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ShopNGUIController.丟三东一丑专丟东丈(丗丏丅丕丆世丁专丟:  0);
    }
    internal static void 下丈专丛不丐丝与丞()
    {
        var val_9;
        System.Object[] val_10;
        var val_11;
        var val_12;
        var val_13;
        UnityEngine.GameObject val_14;
        val_9 = null;
        val_9 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                val_10 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "MoveTo_Tour_name_ntsFr_omArmory MainMenuC_ontroller.sharedC_ontroller == null", args:  val_10);
            return;
        }
        
        if((ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0) && (ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject != 0))
        {
                if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy != false)
        {
                ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
        }
        
        }
        
        if(ConnectScene.丈丘丂丙不丛业丟三() != false)
        {
                val_11 = static_value_081DACA8;
            val_11 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.HandleResumeFromShop();
            static_value_081DACA8 + 184 + 16.HandleBackBtnClicked();
        }
        else
        {
                val_12 = null;
            val_12 = null;
            MainMenuController.丄丞丁丈与业上丞丟.HandleResumeFromShopCore(丞七丅丏丁丘世丌丙:  false);
        }
        
        val_13 = null;
        val_13 = null;
        val_10 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_10 != null)
        {
                val_14 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_14 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        }
        else
        {
                val_14 = 106574280;
        }
        
        val_10.丙七丄与与万世丞丏(世下不上丛丅丌一七:  val_14, 丐丅丒专丛丏上与业:  3, 三丂东专丕专业丏万:  true);
    }
    private bool 丟世丟丗三东丛一且()
    {
        System.Collections.Generic.List<System.String> val_18;
        var val_19;
        var val_20;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_22;
        var val_23;
        System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.String> val_25;
        var val_26;
        System.Func<System.String, System.String> val_28;
        val_18 = this;
        if(FriendsController.丝丗专上三不丄丑丑() > 0)
        {
                System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40));
            if((val_6 != null) && (val_6.Count != 0))
        {
                val_20 = null;
            val_20 = null;
            val_22 = ShopNGUIController.<>c.<>9__232_0;
            if(val_22 == null)
        {
                val_22 = null;
            val_22 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丗丈丗下丐三丐丝上(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            ShopNGUIController.<>c.<>9__232_0 = val_22;
        }
        
            val_23 = null;
            val_23 = null;
            val_25 = ShopNGUIController.<>c.<>9__232_1;
            if(val_25 == null)
        {
                val_25 = null;
            val_25 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.String>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ShopNGUIController.<>c::丈且丁不三业丝丌不(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            ShopNGUIController.<>c.<>9__232_1 = val_25;
        }
        
            val_26 = null;
            val_26 = null;
            val_28 = ShopNGUIController.<>c.<>9__232_2;
            if(val_28 == null)
        {
                val_28 = null;
            val_28 = new System.Func<System.String, System.String>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ShopNGUIController.<>c::丐专丅下丄丂丐丑丂(string 丞丅上丏丂且下丅与));
            ShopNGUIController.<>c.<>9__232_2 = val_28;
        }
        
            System.Collections.Generic.List<TSource> val_14 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.业丙丘丆东丈丕丂丄, System.String>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_6, predicate:  null), selector:  null), keySelector:  null));
            bool val_15 = System.Linq.Enumerable.SequenceEqual<System.String>(first:  this.丅丛丟七上丅丑世东, second:  val_14);
            val_19 = val_15 ^ 1;
            if(val_15 == true)
        {
                return (bool)((this.丅丛丟七上丅丑世东.Count > 0) ? 1 : 0) & 1;
        }
        
            this.丅丛丟七上丅丑世东 = val_14;
            return (bool)((this.丅丛丟七上丅丑世东.Count > 0) ? 1 : 0) & 1;
        }
        
            val_18 = this.丅丛丟七上丅丑世东;
            val_18.Clear();
            return (bool)((this.丅丛丟七上丅丑世东.Count > 0) ? 1 : 0) & 1;
        }
        
        val_18 = this.丅丛丟七上丅丑世东;
        val_18.Clear();
        return (bool)((this.丅丛丟七上丅丑世东.Count > 0) ? 1 : 0) & 1;
    }
    private void Update()
    {
        var val_119;
        float val_120;
        float val_121;
        float val_124;
        var val_125;
        float val_128;
        float val_129;
        var val_130;
        var val_131;
        var val_132;
        var val_133;
        var val_134;
        var val_135;
        var val_136;
        var val_137;
        var val_138;
        float val_139;
        var val_140;
        float val_141;
        float val_142;
        var val_143;
        float val_144;
        var val_145;
        var val_146;
        bool val_147;
        val_119 = this;
        if(this.ActiveObject.activeInHierarchy == false)
        {
                return;
        }
        
        if(this.hintGalleryTapOnGun.activeSelf != false)
        {
                if(this.丟丞下不丙丒丝上一 != 0)
        {
                UnityEngine.Vector3 val_5 = this.丟丞下不丙丒丝上一.position;
            val_121 = this.offsetHintTapOnGun;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_121, y = V11.16B, z = V12.16B});
            val_124 = val_6.z;
            this.hintGalleryTapOnGun.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_124};
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.UpgradeParticles, 丏业丟一东丂东丘丛:  false);
        float val_7 = UnityEngine.Time.realtimeSinceStartup;
        val_7 = val_7 - this.丐丕东业丏丂丘丏与;
        if(val_7 < 1f)
        {
            goto label_96;
        }
        
        this.丐丕东业丏丂丘丏与 = UnityEngine.Time.realtimeSinceStartup;
        丞丑七丙业万与七丟 val_10 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().与丟三三丐丝丑万业();
        goto label_19;
        label_39:
        if(val_10.丙万三丗丘丌业且丕() != 1)
        {
                if(((GameConnect.世丐丄三三上丅七三() != true) && (GameConnect.东且三丆丑世世丘丟() != true)) && (FriendsController.丝丗专上三不丄丑丑() != 1))
        {
                var val_16 = (0 == val_10.七不一丘丘丘丛丘上()) ? 1 : 0;
        }
        
            var val_17 = (0 != 0) ? 1 : 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradingVehicleIndicators[0], 丏业丟一东丂东丘丛:  false);
        label_19:
        if(1 < this.upgradingVehicleIndicators.Length)
        {
            goto label_39;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_18 = WeaponManager.且且丟丗丏与世万丏();
        val_125 = 0;
        goto label_42;
        label_77:
        if((val_18.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key())) == 0)
        {
            goto label_43;
        }
        
        三丅丁丗丗丝丂万且 val_21 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_18.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()));
        if((((GameConnect.世丐丄三三上丅七三() == true) || (GameConnect.东且三丆丑世世丘丟() == true)) || (FriendsController.丝丗专上三不丄丑丑() == 1)) || (val_125 != (val_21.万上丄下业丛丌不丈() - 1)))
        {
            goto label_66;
        }
        
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                if(val_21.万上丄下业丛丌不丈() != 6)
        {
            goto label_66;
        }
        
        }
        
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_66;
        }
        
        bool val_32 = val_21.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  ShopNGUIController.丛丐丛专丟丞万三七());
        goto label_70;
        label_66:
        label_70:
        var val_33 = (0 != 0) ? 1 : 0;
        goto label_71;
        label_43:
        label_71:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradingIndicators[0], 丏业丟一东丂东丘丛:  false);
        val_125 = 1;
        label_42:
        if(val_125 < this.upgradingIndicators.Length)
        {
            goto label_77;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradingArmorIndicator, 丏业丟一东丂东丘丛:  false);
        if(this.propertiesContainer.upgradingToLevel != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.propertiesContainer.upgradingToLevel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.propertiesContainer.upgradingTimeRemains != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.propertiesContainer.upgradingTimeRemains.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        label_96:
        float val_41 = UnityEngine.Time.realtimeSinceStartup;
        val_128 = 0.33f;
        val_41 = val_41 - this.专丝丈丝万不丁不专;
        if(val_41 >= val_128)
        {
                if(this.丟世丟丗三东丛一且() != false)
        {
                this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  this.且丛丌丌七丈丝丒丈, 七丑业业丒七一丂丆:  false);
        }
        
            this.专丝丈丝万不丁不专 = UnityEngine.Time.realtimeSinceStartup;
        }
        
        val_129 = UnityEngine.Time.realtimeSinceStartup - this.丙七丛丝七丆七丛七;
        if((val_129 >= 1f) && ((this.<与一丐丟丗三一东丂>k__BackingField) != 25000))
        {
                this.丙七丛丝七丆七丛七 = UnityEngine.Time.realtimeSinceStartup;
            val_130 = null;
            if(((ShopNGUIController.丛世丛与丌不丈丐丐() != false) && (this.且丛丌丌七丈丝丒丈 != null)) && (this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() != null))
        {
                val_131 = null;
            val_131 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_132 = null;
            val_132 = null;
            if((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) != false)
        {
                不丑世不专上专专丝.丝丄丗丑丌且丄上与(七万丄七丅丅丕丝丑:  this.propertiesContainer, 丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        }
        
        }
        
        }
        
        }
        
        if(this.下丏七丑丙丘且丈丒 != false)
        {
                val_128 = 0.2f;
            val_129 = UnityEngine.Time.realtimeSinceStartup - this.丈丞专丒丒上丝三丏;
            if(val_129 >= val_128)
        {
                this.丈丞专丒丒上丝三丏 = UnityEngine.Time.realtimeSinceStartup;
            this.丘丆上世丝业丛东世();
        }
        
        }
        
        this.下丏七丑丙丘且丈丒 = true;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 7)
        {
                val_133 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_133 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showArmorButton.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 12)
        {
                val_134 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_134 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showMaskButton.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 6)
        {
                val_135 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_135 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showHatButton.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 9)
        {
                val_136 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_136 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showCapeButton.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 10)
        {
                val_137 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_137 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.showBootsButton.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 240000)
        {
                val_138 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        }
        else
        {
                val_138 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.showAllWeaponSkinsToggle, 丏业丟一东丂东丘丛:  false);
        val_139 = UnityEngine.Time.realtimeSinceStartup - this.丙丘丙丆万丘上丘丌;
        if(val_139 >= 2f)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.purchaseSuccessful, 丏业丟一东丂东丘丛:  false);
        }
        
        if((this.mainPanel.activeInHierarchy != false) && ((Holoville.HOTween.HOTween.IsTweening(p_target:  this.世丈上丑东丞丐专万())) != true))
        {
                val_140 = null;
            val_140 = null;
            bool val_69 = UnityEngine.Object.op_Equality(x:  ShopNGUIController.丏丙丅丕一丑丕丑丑.上三不丑业七不万上, y:  0);
            if((val_69 != false) && (val_69.丐丏丑世丗丅不丑丗() != true))
        {
                if(this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒() != 0)
        {
                UnityEngine.Vector3 val_76 = this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒().transform.position;
            val_141 = val_76.y;
            UnityEngine.Vector3 val_79 = this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒().transform.up;
            val_121 = V11.16B;
            val_139 = this.专三不丅丂丌一万七 + (RilisoftRotator.丕不一不三丌万丁丘(世丟丈丏丕万丝丆万:  this.世丈上丑东丞丐专万(), 丄七丛丝丏丈丒丝业:  this.不上专丞丆七七丏业, 丕丏丘七丗丘万丟丛:  new UnityEngine.Rect() {m_XMin = this.丘下丆丅与下丑丑三, m_YMin = val_124, m_Width = val_121, m_Height = V12.16B}, 丑丗丘丞丗丌三丈丆: ref  this.东世七上东丐丁丑东, 三丕丂且一丝丈三一: ref  this.东丌丆一专与丝丕丝, 丝丛业丑专业一丁上:  0, 丑丆丘业不丐丌丅下:  new UnityEngine.Vector3() {x = val_76.x, y = val_141, z = val_76.z}, 丛丄丄丏丅东丙专丏:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.z, z = val_18.Value}));
            this.专三不丅丂丌一万七 = val_139;
        }
        else
        {
                val_139 = this.不上专丞丆七七丏业;
            RilisoftRotator.丒丌丄丛丟丏丒世丄(世丟丈丏丕万丝丆万:  this.世丈上丑东丞丐专万(), 丄七丛丝丏丈丒丝业:  val_139, 丕丏丘七丗丘万丟丛:  new UnityEngine.Rect() {m_XMin = this.丘下丆丅与下丑丑三, m_YMin = val_128, m_Width = val_121, m_Height = V11.16B}, 丑丗丘丞丗丌三丈丆: ref  this.东世七上东丐丁丑东, 三丕丂且一丝丈三一: ref  this.东丌丆一专与丝丕丝, 丝丛业丑专业一丁上:  0);
        }
        
        }
        
        }
        
        val_142 = UnityEngine.Time.realtimeSinceStartup;
        val_143 = null;
        val_143 = null;
        val_144 = ShopNGUIController.上丈丂丁三丂业丛丝;
        if((val_142 - this.东世七上东丐丁丑东) <= val_144)
        {
            goto label_279;
        }
        
        if((this.且丛丌丌七丈丝丒丈 == null) || (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 210000))
        {
            goto label_259;
        }
        
        if(this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒() == 0)
        {
            goto label_279;
        }
        
        float val_91 = UnityEngine.Time.deltaTime;
        this.专三不丅丂丌一万七 = UnityEngine.Mathf.MoveTowardsAngle(current:  this.专三不丅丂丌一万七, target:  0f, maxDelta:  val_91 * 360f);
        this.世丈上丑东丞丐专万().localPosition = new UnityEngine.Vector3() {x = this.丛丏专专世下丘丈上, y = val_91, z = val_124};
        UnityEngine.Quaternion val_96 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.丆丌丟丅丘丑业丒丄, y = val_91, z = this.丛丏专专世下丘丈上});
        this.世丈上丑东丞丐专万().localRotation = new UnityEngine.Quaternion() {x = val_96.x, y = val_96.y, z = val_96.z, w = val_96.w};
        this.世丈上丑东丞丐专万().localScale = new UnityEngine.Vector3() {x = this.丁丝世下一丟丅万东, y = val_96.y, z = val_96.z};
        UnityEngine.Vector3 val_101 = this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒().transform.position;
        val_142 = val_101.x;
        val_124 = val_101.z;
        UnityEngine.Vector3 val_104 = this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒().transform.up;
        val_120 = val_104.y;
        val_141 = val_104.z;
        this.世丈上丑东丞丐专万().RotateAround(point:  new UnityEngine.Vector3() {x = val_142, y = val_101.y, z = val_124}, axis:  new UnityEngine.Vector3() {x = val_104.x, y = val_120, z = val_141}, angle:  this.专三不丅丂丌一万七);
        val_144 = this.专三不丅丂丌一万七;
        if(val_144 != 0f)
        {
            goto label_279;
        }
        
        val_144 = UnityEngine.Time.realtimeSinceStartup + 1000000f;
        this.东世七上东丐丁丑东 = val_144;
        goto label_279;
        label_259:
        this.丂万丑东七业丁业丁();
        label_279:
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 9) || (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 210000))
        {
            goto label_286;
        }
        
        }
        
        val_145 = null;
        val_142 = UnityEngine.Time.realtimeSinceStartup;
        val_145 = null;
        if((val_142 - this.东世七上东丐丁丑东) > ShopNGUIController.上丈丂丁三丂业丛丝)
        {
                this.三丟业丝万专丞世丝();
        }
        
        label_286:
        val_119 = ActivityIndicator.丙专三丙丌丝丏丌丅();
        val_146 = null;
        val_146 = null;
        val_147 = StoreKitEventListener.丌丗丆丟丈丆丝丝丄;
        var val_111 = (val_147 == true) ? 1 : 0;
        val_111 = val_119 ^ val_111;
        if(val_111 == false)
        {
                return;
        }
        
        val_147 = StoreKitEventListener.丌丗丆丟丈丆丝丝丄;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  (val_147 == true) ? 1 : 0);
    }
    internal 丙且上东下丏丏丟下 东丂丈与丄丛万丞丑()
    {
        return (丙且上东下丏丏丟下)this.且丛丌丌七丈丝丒丈;
    }
    private void 与世丙与丅丕丏丈丕(丙且上东下丏丏丟下 丙业与丙丗丝不丈东)
    {
        this.且丛丌丌七丈丝丒丈 = 丙业与丙丗丝不丈东;
    }
    internal bool 一丆丗一丑丅丛东丑()
    {
        return (bool)this.<丌世专万丞不丞丒与>k__BackingField;
    }
    private void 丑下三丞丛世东丕三(bool 丙业与丙丗丝不丈东)
    {
        this.<丌世专万丞不丞丒与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal CategoryNames 丞东丐丐丞丟业丄三()
    {
        return (CategoryNames)this.<东丒不且丟丞丆丑丈>k__BackingField;
    }
    private void 七丗丕万丆业且丕丐(CategoryNames 丙业与丙丗丝不丈东)
    {
        this.<东丒不且丟丞丆丑丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal CategoryNames 丗丛丐丑丛丅丞七且()
    {
        return (CategoryNames)this.<与一丐丟丗三一东丂>k__BackingField;
    }
    private void 世丏万不丈丙七丆业(CategoryNames 丙业与丙丗丝不丈东)
    {
        this.<与一丐丟丗三一东丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Camera 丌丒丒丙与东丈丟东()
    {
        var val_3;
        System.Func<UnityEngine.Camera, System.Boolean> val_5;
        var val_6;
        if(this.ourCameras != null)
        {
                val_3 = null;
            val_3 = null;
            val_5 = ShopNGUIController.<>c.<>9__252_0;
            if(val_5 == null)
        {
                System.Func<UnityEngine.Camera, System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<UnityEngine.Camera, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::七丅丂丑丈一丌丗丙(UnityEngine.Camera 丁丂专业丁丅丅丈丙));
            ShopNGUIController.<>c.<>9__252_0 = val_5;
        }
        
            UnityEngine.Camera val_2 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.Camera>(source:  this.ourCameras, predicate:  val_1);
            return (UnityEngine.Camera)val_6;
        }
        
        val_6 = 0;
        return (UnityEngine.Camera)val_6;
    }
    internal bool 丐丏丑世丗丅不丑丗()
    {
        return HatchEggUIBanner.丈丐丞丐上丑且丕万();
    }
    internal System.Collections.Generic.List<BaseArmoryCell> 下丈不丘世丁不万丅()
    {
        var val_4;
        System.Func<BaseArmoryCell, System.String> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = ShopNGUIController.<>c.<>9__256_0;
        if(val_6 != null)
        {
                return System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.firstGrid.GetComponentsInChildren<BaseArmoryCell>(includeInactive:  true), keySelector:  System.Func<BaseArmoryCell, System.String> val_2 = null));
        }
        
        val_6 = val_2;
        val_2 = new System.Func<BaseArmoryCell, System.String>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ShopNGUIController.<>c::丛丈万丁东丈且丝丄(BaseArmoryCell 丌丝万上丅丒一丈丘));
        ShopNGUIController.<>c.<>9__256_0 = val_6;
        return System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.firstGrid.GetComponentsInChildren<BaseArmoryCell>(includeInactive:  true), keySelector:  val_2));
    }
    internal System.Collections.Generic.List<BaseArmoryCell> 丌丛丕专丝丁万专丆()
    {
        var val_4;
        System.Func<BaseArmoryCell, System.String> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = ShopNGUIController.<>c.<>9__258_0;
        if(val_6 != null)
        {
                return System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.丝丟丐丁丌丛丞东专<BaseArmoryCell>(丟丝七七一丁丏丏丙:  true), keySelector:  System.Func<BaseArmoryCell, System.String> val_2 = null));
        }
        
        val_6 = val_2;
        val_2 = new System.Func<BaseArmoryCell, System.String>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ShopNGUIController.<>c::丞一丟业三且丒万丛(BaseArmoryCell 丌丝万上丅丒一丈丘));
        ShopNGUIController.<>c.<>9__258_0 = val_6;
        return System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.丝丟丐丁丌丛丞东专<BaseArmoryCell>(丟丝七七一丁丏丏丙:  true), keySelector:  val_2));
    }
    internal 世丕丑七且丝七不不 丙丛丝丝丁不丁丗丘()
    {
        object val_2 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  this.superCategoriesButtonController.currentBtnName);
        return (世丕丑七且丝七不不)null;
    }
    internal static FilterMaps 丛丐丛专丟丞万三七()
    {
        WeaponManager val_2;
        var val_3;
        FilterMaps val_4;
        var val_5;
        var val_6;
        val_2 = 1152921505261211648;
        val_3 = null;
        val_3 = null;
        val_4 = ShopNGUIController.丑万与丞丄丟丁丑丗;
        if((val_4 & 2147483648) == 0)
        {
                val_4 = ShopNGUIController.丑万与丞丄丟丁丑丗;
            return (FilterMaps)val_4;
        }
        
        val_5 = null;
        val_5 = null;
        val_2 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_2 != 0)
        {
                val_6 = null;
            val_6 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                return WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐();
        }
        
            return WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐();
        }
        
        val_4 = 0;
        return (FilterMaps)val_4;
    }
    internal static bool 丛世丛与丌不丈丐丐()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        if(null != 0)
        {
                return activeInHierarchy;
        }
        
        return activeInHierarchy;
    }
    internal static void 世丗七丙丙业下丆与(bool 丝三丄专丗丞丄丄丌, FilterMaps 丑丕三丅丗世且七丆 = -1, bool 丌丂丁七丏不丂丁上 = True)
    {
        bool val_189;
        var val_190;
        var val_191;
        System.Object[] val_192;
        var val_193;
        bool val_194;
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_195;
        var val_196;
        var val_197;
        var val_198;
        var val_199;
        var val_200;
        var val_201;
        var val_202;
        var val_203;
        var val_204;
        var val_205;
        var val_206;
        var val_207;
        var val_208;
        var val_210;
        var val_211;
        float val_213;
        var val_214;
        var val_215;
        var val_217;
        var val_218;
        var val_219;
        System.Func<BtnCategory, System.Boolean> val_221;
        var val_223;
        var val_224;
        var val_225;
        System.Func<BtnCategory, System.Boolean> val_227;
        var val_228;
        var val_229;
        var val_230;
        System.Func<BtnCategory, System.Boolean> val_232;
        var val_233;
        var val_234;
        var val_235;
        System.Func<BtnCategory, System.Boolean> val_237;
        bool val_238;
        var val_239;
        var val_240;
        var val_241;
        var val_242;
        var val_243;
        var val_244;
        var val_245;
        var val_246;
        var val_247;
        var val_248;
        var val_249;
        var val_250;
        var val_251;
        var val_252;
        var val_253;
        var val_254;
        var val_255;
        var val_256;
        var val_257;
        var val_258;
        System.Action<BaseArmoryCell> val_260;
        var val_261;
        var val_262;
        System.Action<BaseArmoryCell> val_264;
        var val_265;
        var val_266;
        var val_267;
        var val_268;
        var val_269;
        var val_270;
        var val_271;
        丙且上东下丏丏丟下 val_272;
        var val_273;
        var val_274;
        CategoryNames val_275;
        var val_276;
        var val_277;
        var val_278;
        var val_279;
        string val_280;
        丙且上东下丏丏丟下 val_281;
        var val_282;
        System.Func<System.Collections.Generic.List<System.Collections.Generic.List<System.String>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<System.String>>> val_284;
        var val_285;
        var val_286;
        System.Action<UnityEngine.Transform> val_288;
        var val_289;
        var val_290;
        var val_291;
        var val_292;
        var val_293;
        System.Func<UnityEngine.Transform, GeneralBannerWindow> val_295;
        var val_296;
        System.Action<GeneralBannerWindow> val_298;
        var val_299;
        var val_300;
        System.Func<UnityEngine.Transform, GeneralBannerWindow> val_302;
        var val_303;
        System.Action<GeneralBannerWindow> val_305;
        var val_306;
        var val_307;
        var val_308;
        System.Collections.IEnumerator val_309;
        var val_310;
        var val_311;
        var val_312;
        var val_313;
        var val_314;
        var val_315;
        var val_316;
        var val_317;
        var val_318;
        var val_319;
        var val_320;
        val_189 = 丌丂丁七丏不丂丁上;
        val_190 = 1152921505261211648;
        val_191 = null;
        val_191 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                object[] val_3 = new object[2];
            val_192 = val_3;
            val_192[0] = 丝三丄专丗丞丄丄丌;
            val_192[1] = System.Environment.StackTrace;
            UnityEngine.Debug.LogErrorFormat(format:  "TRying to show({0}) shop when it not exists {1}", args:  val_3);
            return;
        }
        
        val_193 = null;
        val_194 = ShopNGUIController.丛世丛与丌不丈丐丐();
        if((val_194 != true) && (丝三丄专丗丞丄丄丌 != false))
        {
                val_195 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            PGCompany.Analytics.一业丗丆世世上丁且.丑万丟丙专丆且专丂(丆丛丑世下一丐且丕:  val_195, 丁丅丈丌丟世丗丗丟:  1, 丄丙丑丕不业丂丒丂:  "Other");
        }
        
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_24;
        }
        
        val_196 = null;
        val_196 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_197 = null;
            val_197 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_198 = null;
            val_198 = null;
            val_199 = null;
            val_199 = null;
            if(丙不丅丕三丂业东丕() != 0)
        {
                val_200 = null;
            val_200 = null;
            if(丙不丅丕三丂业东丕().一与上丙一丙丅丐业() != 0)
        {
                val_201 = null;
            val_201 = null;
            丙不丅丕三丂业东丕().一与上丙一丙丅丐业().万丛丂丑丑丆且丌丁();
        }
        
        }
        
        }
        
        }
        
        val_202 = null;
        val_202 = null;
        ShopNGUIController.丑万与丞丄丟丁丑丗 = 丑丕三丅丗世且七丆;
        val_203 = null;
        val_203 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_813;
        }
        
        val_204 = null;
        val_204 = null;
        val_205 = null;
        if((ShopNGUIController.丑万与丞丄丟丁丑丗 & 2147483648) != 0)
        {
            goto label_71;
        }
        
        val_205 = null;
        val_204 = null;
        val_204 = null;
        WeaponManager.丟丗丄业丘丗业丗七.下东与丌丁丝丁丘专(专丆丌丛东一不丑丙:  ShopNGUIController.丑万与丞丄丟丁丑丗);
        goto label_813;
        label_24:
        val_206 = null;
        val_206 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_840;
        }
        
        val_207 = null;
        val_207 = null;
        if((null == 0) || (ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0))
        {
            goto label_840;
        }
        
        val_208 = null;
        val_208 = null;
        System.IDisposable val_195 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_97;
        }
        
        var val_190 = mem[null + 176];
        var val_191 = 0;
        val_190 = val_190 + 8;
        label_96:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_95;
        }
        
        val_191 = val_191 + 1;
        val_190 = val_190 + 16;
        if(val_191 < (mem[null + 286]))
        {
            goto label_96;
        }
        
        goto label_97;
        label_71:
        if(WeaponManager.丄专丞东专下丑不丝() != false)
        {
                val_210 = null;
            val_210 = null;
            WeaponManager.丟丗丄业丘丗业丗七.丒丆丟丒丞下不丗与();
        }
        
        label_813:
        val_211 = null;
        val_211 = null;
        val_213 = UnityEngine.Time.realtimeSinceStartup;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.专丝丈丝万不丁不专 = val_213;
        val_214 = null;
        val_214 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        if(null == 0)
        {
            goto label_111;
        }
        
        val_215 = null;
        val_215 = null;
        System.IDisposable val_194 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_119;
        }
        
        var val_192 = mem[null + 176];
        var val_193 = 0;
        val_192 = val_192 + 8;
        label_118:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_117;
        }
        
        val_193 = val_193 + 1;
        val_192 = val_192 + 16;
        if(val_193 < (mem[null + 286]))
        {
            goto label_118;
        }
        
        goto label_119;
        label_117:
        val_194 = val_194 + (((mem[null + 176] + 8)) << 4);
        label_119:
        Dispose();
        label_111:
        val_217 = null;
        val_217 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  ShopNGUIController.丏丙丅丕一丑丕丑丑, method:  public System.Void ShopNGUIController::HandleEscape()), 与且专丈不万东一万:  "Shop");
        bool val_24 = 上丑三丁丄丛丁万丑.丌丂专丐丈丁丅丄世();
        val_218 = null;
        val_218 = null;
        val_219 = null;
        val_219 = null;
        val_221 = ShopNGUIController.<>c.<>9__266_2;
        if(val_221 == null)
        {
                val_221 = null;
            val_221 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丝且万专丞丘且专下(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__266_2 = val_221;
        }
        
        UnityEngine.GameObject val_27 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  CategoryButtonsController.__il2cppRuntimeField_byval_arg, predicate:  null).gameObject;
        if(val_24 ^ val_27.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  val_24);
            val_223 = null;
            val_223 = null;
        }
        
        bool val_31 = 上丑三丁丄丛丁万丑.下三丌丗丆丒丄丆丈();
        val_224 = null;
        val_224 = null;
        val_225 = null;
        val_225 = null;
        val_227 = ShopNGUIController.<>c.<>9__266_3;
        if(val_227 == null)
        {
                val_227 = null;
            val_227 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::三上丒丆丂丈且三丘(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__266_3 = val_227;
        }
        
        UnityEngine.GameObject val_34 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  CategoryButtonsController.__il2cppRuntimeField_byval_arg, predicate:  null).gameObject;
        if(val_31 ^ val_34.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_34, 丏业丟一东丂东丘丛:  val_31);
            val_228 = null;
            val_228 = null;
        }
        
        bool val_38 = 上丑三丁丄丛丁万丑.丒丈丈与丑七丕东业();
        val_229 = null;
        val_229 = null;
        val_230 = null;
        val_230 = null;
        val_232 = ShopNGUIController.<>c.<>9__266_4;
        if(val_232 == null)
        {
                val_232 = null;
            val_232 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丟丅丒丟丝丆丑丘丛(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__266_4 = val_232;
        }
        
        UnityEngine.GameObject val_41 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  CategoryButtonsController.__il2cppRuntimeField_byval_arg, predicate:  null).gameObject;
        if(val_38 ^ val_41.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_41, 丏业丟一东丂东丘丛:  val_38);
            val_233 = null;
            val_233 = null;
        }
        
        bool val_45 = 上丑三丁丄丛丁万丑.且丕不且丆东专三下();
        val_234 = null;
        val_234 = null;
        val_235 = null;
        val_235 = null;
        val_237 = ShopNGUIController.<>c.<>9__266_5;
        if(val_237 == null)
        {
                val_237 = null;
            val_237 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丅丞且丒东丏且丒上(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__266_5 = val_237;
        }
        
        val_195 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  CategoryButtonsController.__il2cppRuntimeField_byval_arg, predicate:  null).gameObject;
        val_189 = val_189;
        val_238 = val_194;
        if(val_45 ^ val_195.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_195, 丏业丟一东丂东丘丛:  val_45);
            val_239 = null;
            val_239 = null;
        }
        
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_840;
        }
        
        label_839:
        val_240 = null;
        val_240 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_840;
        }
        
        val_241 = null;
        val_241 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.tryGun != 0)
        {
                val_242 = null;
            val_242 = null;
            gameObject.SetActive(value:  false);
        }
        
        val_243 = null;
        val_243 = null;
        val_195 = 上丑三丁丄丛丁万丑.不丛丟丗丐丄丒丑丄();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.royaleUnavailable, 丏业丟一东丂东丘丛:  (~val_195) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.craftUnavailable, 丏业丟一东丂东丘丛:  (~上丑三丁丄丛丁万丑.不三丛丂世且丗丑东()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.modulesUnavailable, 丏业丟一东丂东丘丛:  (~上丑三丁丄丛丁万丑.世丅与丏丕丑丛上业()) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.gadgesUnavailable, 丏业丟一东丂东丘丛:  false);
        goto label_840;
        label_95:
        val_195 = val_195 + (((mem[null + 176] + 8)) << 4);
        label_97:
        Dispose();
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丆七且丞丏下三丙 = 0;
        if(丝三丄专丗丞丄丄丌 == true)
        {
            goto label_839;
        }
        
        label_840:
        FreeAwardShowHandler.万上业丄丈丁上东丟(丘丅七丝丒丐丝专七:  丝三丄专丗丞丄丄丌);
        val_244 = null;
        val_244 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_351;
        }
        
        val_245 = null;
        val_245 = null;
        bool val_63 = (~丝三丄专丗丞丄丄丌) & 1;
        this.丝丝不丛且三丏丁丗(丗丛不丁丑专专丂且:  val_63);
        val_246 = null;
        if((val_63 & 1) != 0)
        {
            goto label_250;
        }
        
        val_247 = null;
        SetActive(value:  true);
        SetActive(value:  true);
        new ShopNGUIController.世世丐世丑业东丂丕() = new ShopNGUIController.世世丐世丑业东丂丕();
        ShopNGUIController.且丐丛专与三且万且();
        val_213 = UnityEngine.Time.realtimeSinceStartup;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丙丗丅上三三与丑丙 = val_213;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        val_248 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丘丌丞丑业丑丗上丟 != 0)
        {
            goto label_264;
        }
        
        val_249 = null;
        业七不专丝丘且万丁(丙业与丙丗丝不丈东:  true);
        goto label_269;
        label_250:
        val_250 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.与丕专丛世丛丅丒东
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.与丕专丛世丛丅丒东.HasValue.HasValue != false)
        {
            
        }
        else
        {
                UnityEngine.Color val_68 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_68.r, g = val_68.g, b = val_68.b, a = val_68.a});
        if(Rilisoft.AbstractGameEventGui.InterfaceEnabled != true)
        {
                val_251 = null;
            val_251 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙
            if((ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙 & 1) != 0)
        {
                val_252 = null;
            val_252 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙
            ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙 = ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙 & 1;
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙);
        }
        
        }
        
        if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
        {
                val_253 = null;
            val_253 = null;
            if((LobbySeasonController.instance != 0) && (PGCompany.EventHub.EventHubBanner.丑七不且上丗丁一世() != 0))
        {
                val_254 = null;
            val_254 = null;
            if(LobbySeasonController.instance.FogComponent != 0)
        {
                val_255 = null;
            val_255 = null;
            LobbySeasonController.instance.FogComponent.丏世与丅东三丆丛丂();
        }
        
        }
        
        }
        
        val_256 = null;
        val_256 = null;
        SpringPanel.上丄丂丛专下丟万下 val_78 = null;
        val_195 = val_78;
        val_78 = new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  ShopNGUIController.丏丙丅丕一丑丕丑丑, 丛丌丙世专世东丕下:  System.Void ShopNGUIController::丞世与与丆一与丗上());
        val_257 = System.Delegate.Remove(source:  typeof(MyCenterOnChild).__il2cppRuntimeField_38, value:  val_78);
        if((val_257 != null) && (null != null))
        {
                val_257 = 0;
        }
        
        typeof(MyCenterOnChild).__il2cppRuntimeField_38 = val_257;
        丅且东丙业丏丛东丛.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  ShopNGUIController.丏丙丅丕一丑丕丑丑, method:  System.Void ShopNGUIController::丗丆丒丘万丈丂丑丞()));
        SetActive(value:  false);
        enabled = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丆一丂丕三丄丞丆上, 丏业丟一东丂东丘丛:  false);
        val_258 = null;
        val_258 = null;
        val_260 = ShopNGUIController.<>c.<>9__266_0;
        if(val_260 == null)
        {
                System.Action<BaseArmoryCell> val_82 = null;
            val_260 = val_82;
            val_82 = new System.Action<BaseArmoryCell>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::七丁丒丌丘丝专丈东(BaseArmoryCell 丌丝万上丅丒一丈丘));
            ShopNGUIController.<>c.<>9__266_0 = val_260;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.下丈不丘世丁不万丅().ForEach(action:  val_82);
        val_261 = null;
        val_261 = null;
        val_262 = null;
        val_262 = null;
        val_264 = ShopNGUIController.<>c.<>9__266_1;
        if(val_264 == null)
        {
                System.Action<BaseArmoryCell> val_84 = null;
            val_264 = val_84;
            val_84 = new System.Action<BaseArmoryCell>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丌丝丟丐丑业丄丗丒(BaseArmoryCell 丌丝万上丅丒一丈丘));
            ShopNGUIController.<>c.<>9__266_1 = val_264;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌丛丕专丝丁万专丆().ForEach(action:  val_84);
        val_265 = null;
        val_265 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丘丌丞丑业丑丗上丟 != 0)
        {
                val_266 = null;
            val_266 = null;
            丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  0);
        }
        
        val_267 = null;
        val_267 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丑且且丁丆丝不丒丝();
        goto label_351;
        label_264:
        val_268 = null;
        业七不专丝丘且万丁(丙业与丙丗丝不丈东:  false);
        丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏());
        业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
        label_269:
        val_269 = null;
        val_269 = null;
        if(null != 0)
        {
            goto label_364;
        }
        
        val_270 = null;
        val_270 = null;
        if( == 0)
        {
            goto label_368;
        }
        
        label_364:
        val_271 = null;
        val_271 = null;
        .与丝丕与丙不与丗丆 = ShopNGUIController.丏丙丅丕一丑丕丑丑.专丑下东丙丞丏七丄;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose != 25000)
        {
            goto label_388;
        }
        
        if((ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆 != null)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七())) != true)
        {
                if((丟下七丘下下丙丗丅.一三专丞丒丅上业上().ContainsKey(key:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_388;
        }
        
        }
        
        }
        
        if(((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈()) == null) || ((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count) < 1))
        {
            goto label_388;
        }
        
        string val_99 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏();
        if((System.String.IsNullOrEmpty(value:  val_99)) == false)
        {
            goto label_390;
        }
        
        System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛> val_103 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>>(source:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈());
        val_272 = new 丙且上东下丏丏丟下();
        val_272 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Item[val_103.Value.丙东专丂世丈丏丁丂()], 七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose);
        goto label_395;
        label_368:
        val_273 = null;
        val_273 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_404;
        }
        
        val_274 = null;
        val_274 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 != 1)
        {
            goto label_404;
        }
        
        val_275 = 2;
        goto label_613;
        label_404:
        val_276 = null;
        val_276 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_418;
        }
        
        val_277 = null;
        val_277 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 2)
        {
            goto label_414;
        }
        
        val_278 = null;
        val_278 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 != 4)
        {
            goto label_418;
        }
        
        label_414:
        val_275 = 4;
        goto label_613;
        label_390:
        val_272 = new 丙且上东下丏丏丟下();
        val_272 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_99, 七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose);
        label_395:
        .与丝丕与丙不与丗丆 = val_272;
        label_388:
        val_279 = null;
        val_279 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_279 = null;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.专丑下东丙丞丏七丄 = 0;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose = 0;
        label_624:
        if((ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆 == null)
        {
            goto label_454;
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose)) == false)
        {
            goto label_427;
        }
        
        val_280 = 丁下万丟且丟丛下业.丆丏丒丆万丄且丗丛(丗丑丐丕丟丝且下丕:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七());
        goto label_435;
        label_427:
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose == 7)
        {
            goto label_439;
        }
        
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose == 25000)
        {
                val_280 = (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_280 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七());
        }
        
        label_435:
        if(val_280 == null)
        {
            goto label_439;
        }
        
        val_281 = new 丙且上东下丏丏丟下();
        val_281 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_280, 七丆丒与丗丌丄且丂:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.丒万丕七专不丏丞丌());
        goto label_441;
        label_439:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.丒万丕七专不丏丞丌())) == false)
        {
            goto label_454;
        }
        
        val_282 = null;
        val_282 = null;
        val_284 = ShopNGUIController.<>c.<>9__266_11;
        if(val_284 == null)
        {
                val_284 = null;
            val_284 = new System.Func<System.Collections.Generic.List<System.Collections.Generic.List<System.String>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<System.String>>>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.Collections.Generic.List<System.String>> ShopNGUIController.<>c::丘万世丐丈丄丘不丛(System.Collections.Generic.List<System.Collections.Generic.List<string>> 丒不世万与上丟三丛));
            ShopNGUIController.<>c.<>9__266_11 = val_284;
        }
        
        System.Func<System.Collections.Generic.List<System.String>, System.Boolean> val_125 = new System.Func<System.Collections.Generic.List<System.String>, System.Boolean>(object:  new ShopNGUIController.世世丐世丑业东丂丕(), method:  System.Boolean ShopNGUIController.世世丐世丑业东丂丕::且丁丕不业丝丗丄丂(System.Collections.Generic.List<string> 丝丘丑业丛万丞丌丝));
        System.Collections.Generic.List<System.String> val_126 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.List<System.String>>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.List<System.Collections.Generic.List<System.String>>, System.Collections.Generic.List<System.String>>(source:  七丌丞万七万丁丐丙.且不业七三丏与丐丙().Values, selector:  null), predicate:  null);
        if(val_126 == null)
        {
            goto label_454;
        }
        
        val_281 = new 丙且上东下丏丏丟下();
        val_281 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_126.Item[0], 七丆丒与丗丌丄且丂:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆.丒万丕七专不丏丞丌());
        label_441:
        .与丝丕与丙不与丗丆 = val_281;
        label_454:
        val_285 = null;
        val_285 = null;
        val_286 = null;
        val_286 = null;
        val_288 = ShopNGUIController.<>c.<>9__266_6;
        if(val_288 == null)
        {
                val_288 = null;
            val_288 = new System.Action<UnityEngine.Transform>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::与丞丗东业东万一丛(UnityEngine.Transform 丙丒七丄上与丏丙丙));
            ShopNGUIController.<>c.<>9__266_6 = val_288;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.Transform>(丌丛丏业世丄丞三丌:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丂下且丏业丕东丛万(), 七丐丅专且专七三丆:  null);
        val_289 = null;
        val_289 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.三丈世丌丄不丈上不();
        ShopNGUIController.丏丙丅丕一丑丕丑丑.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        val_195 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_195.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose, 与丝丕与丙不与丗丆:  (ShopNGUIController.世世丐世丑业东丂丕)[1152921539056639840].与丝丕与丙不与丗丆, 七丑业业丒七一丂丆:  true);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.AdjustCategoryGridCells();
        if(val_189 != false)
        {
                val_290 = null;
            val_290 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑.上三不丑业七不万上 != 0)
        {
                val_291 = null;
            val_291 = null;
            丞丏世丆丄上丆一七();
        }
        
            if(PetInfoController.Instance != 0)
        {
                PetInfoController.Instance.Close();
        }
        
        }
        
        val_292 = null;
        val_292 = null;
        val_293 = null;
        val_293 = null;
        val_295 = ShopNGUIController.<>c.<>9__266_7;
        if(val_295 == null)
        {
                val_295 = null;
            val_295 = new System.Func<UnityEngine.Transform, GeneralBannerWindow>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  GeneralBannerWindow ShopNGUIController.<>c::丗丕下与专与丒不丈(UnityEngine.Transform 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__266_7 = val_295;
        }
        
        val_296 = null;
        val_296 = null;
        val_298 = ShopNGUIController.<>c.<>9__266_8;
        if(val_298 == null)
        {
                val_298 = null;
            val_298 = new System.Action<GeneralBannerWindow>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::世丌世丆丏专丈一丑(GeneralBannerWindow 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__266_8 = val_298;
        }
        
        GeneralBannerWindow val_139 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GeneralBannerWindow>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<GeneralBannerWindow, UnityEngine.Transform>(丞下万上三丘上与专:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丝丄丁丟丅丁丟, 丏丅丁丛一业丈专专:  null), 丌专业且丛丏丞丝且:  null);
        val_299 = null;
        val_299 = null;
        val_300 = null;
        val_300 = null;
        val_302 = ShopNGUIController.<>c.<>9__266_9;
        if(val_302 == null)
        {
                val_302 = null;
            val_302 = new System.Func<UnityEngine.Transform, GeneralBannerWindow>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  GeneralBannerWindow ShopNGUIController.<>c::丂丕业丘丕丈丁丌丏(UnityEngine.Transform 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__266_9 = val_302;
        }
        
        val_303 = null;
        val_303 = null;
        val_305 = ShopNGUIController.<>c.<>9__266_10;
        if(val_305 == null)
        {
                val_305 = null;
            val_305 = new System.Action<GeneralBannerWindow>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::东丟丟丝丌丟丛七丄(GeneralBannerWindow 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__266_10 = val_305;
        }
        
        GeneralBannerWindow val_143 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GeneralBannerWindow>(丞下万上三丘上与专:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<GeneralBannerWindow, UnityEngine.Transform>(丞下万上三丘上与专:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丒丁丗丙丝不丆丘七, 丏丅丁丛一业丈专专:  null), 丌专业且丛丏丞丝且:  null);
        val_238 = val_194;
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                val_306 = null;
            val_306 = null;
            System.Func<CategoryNames, System.Boolean> val_146 = new System.Func<CategoryNames, System.Boolean>(object:  0, method:  static System.Boolean 上丑三丁丄丛丁万丑::丂与专与业丄且东丁(CategoryNames 七上丟东丂业丑丁丆));
            val_307 = null;
            val_307 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.专丄丕丗与上丟七丅();
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丕与丈上专丒丐丟丒(与丑丕一丁丞丟与丕:  System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Where<CategoryNames>(source:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Keys, predicate:  null)));
        }
        
        val_308 = null;
        val_308 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_309 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丙与丁东丕丂丅且丒();
        }
        else
        {
                val_309 = this.丙与丁东丕丂丅且丒();
        }
        
        UnityEngine.Coroutine val_151 = ShopNGUIController.丏丙丅丕一丑丕丑丑.StartCoroutine(routine:  val_309);
        this.一丛丈上且不丟丑万();
        if(HatchEggUIBanner.丑七不且上丗丁一世() != 0)
        {
                if(HatchEggUIBanner.丈丐丞丐上丑且丕万() != false)
        {
                HatchEggUIBanner val_155 = HatchEggUIBanner.丑七不且上丗丁一世();
        }
        
        }
        
        val_310 = null;
        val_310 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丑丗丛不世丙丏丗丅();
        label_351:
        val_311 = null;
        if(val_238 ^ ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_312 = null;
            val_312 = null;
            if(ShopNGUIController.上丒丅丅丅不丕丘丁 != null)
        {
                ShopNGUIController.上丒丅丅丅不丕丘丁.Invoke(obj:  ShopNGUIController.丛世丛与丌不丈丐丐());
        }
        
        }
        
        if(丝三丄专丗丞丄丄丌 != true)
        {
                val_313 = null;
            val_313 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
        {
                val_314 = null;
            val_314 = null;
            ShopNGUIController.丑万与丞丄丟丁丑丗 = 0;
            val_315 = null;
            val_315 = null;
            if(ShopNGUIController.丑万与丞丄丟丁丑丗 != 1)
        {
                if(((UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七, y:  0)) ^ 1) != true)
        {
                val_316 = null;
            val_316 = null;
            WeaponManager.丟丗丄业丘丗业丗七.下东与丌丁丝丁丘专(专丆丌丛东一不丑丙:  0);
        }
        
        }
        
        }
        
        }
        
        val_317 = 1152921504615739392;
        System.Action val_163 = new System.Action(object:  0, method:  static System.Void ShopNGUIController::丏丝不万东东一上丂());
        if(丝三丄专丗丞丄丄丌 != false)
        {
                PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  val_163);
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void ShopNGUIController::七东丙丟丝丈丄且不()));
            PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void ShopNGUIController::丏丝不万东东一上丂()));
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void ShopNGUIController::七东丙丟丝丈丄且不()));
        }
        else
        {
                PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  val_163);
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void ShopNGUIController::七东丙丟丝丈丄且不()));
        }
        
        val_318 = null;
        val_318 = null;
        val_192 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_192 == 0)
        {
                return;
        }
        
        val_319 = null;
        val_319 = null;
        val_192 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1208];
        val_192 = ShopNGUIController.丏丙丅丕一丑丕丑丑.superCategoriesButtonController;
        val_238 = 1152921524369401056;
        val_320 = 0;
        return;
        label_418:
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_612;
        }
        
        UnityEngine.SceneManagement.Scene val_176 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_176.m_Handle.name, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == false)
        {
            goto label_612;
        }
        
        val_275 = 5;
        goto label_613;
        label_612:
        val_275 = 0;
        label_613:
        string val_196 = WeaponManager.世东一丑丆丑与丆一()[val_275];
        if(val_196 == null)
        {
            goto label_618;
        }
        
        new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_196, 七丆丒与丗丌丄且丂:  val_275);
        .与丝丕与丙不与丗丆 = new 丙且上东下丏丏丟下();
        goto label_624;
        label_618:
        new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  WeaponManager.丘丄丂与且世丕丅专(业三一丌丛丅下丗丁:  val_275, 丕丝丗丅丘上七丞万: out  5), 七丆丒与丗丌丄且丂:  5);
        .与丝丕与丙不与丗丆 = new 丙且上东下丏丏丟下();
        goto label_624;
    }
    private void 丑且且丁丆丝不丒丝()
    {
        var val_3;
        HashSet.Enumerator<T> val_1 = this.丅丐丄专丏世丝七丞.GetEnumerator();
        label_19:
        if((90585280 & 1) == 0)
        {
            goto label_2;
        }
        
        PGCompany.丟丝世万东万丆丟上 val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  val_3.丙东专丂世丈丏丁丂());
        if(val_6 == null)
        {
            goto label_19;
        }
        
        if((Progress.七七世万专丕丁上业.丙丌丒丌丞且丌专丂().万万上上丕七丑丙丐(专丙丐世与丐下不丑:  val_6.业东丅东丌上丗丑不())) != true)
        {
                int[] val_11 = new int[1];
            val_11[0] = val_6.业东丅东丌上丗丑不();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丑丈丂丈丝丛丂一下(丅专丐丝丒丕丐业丘:  val_11);
        }
        
        if((丆丞丐三与丞专丈丌.丗丅丁一丁丁不万丞(丞一丁业丄一一业且:  val_6.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_19;
        }
        
        丆丞丐三与丞专丈丌.丏丄下丈丝丅丁万世(丞一丁业丄一一业且:  val_6.业上丙丞丐丄丆丅七());
        goto label_19;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丅丐丄专丏世丝七丞.Clear();
    }
    internal CharacterInterfaceV2 丌上丏丁下丞丐丏万()
    {
        return (CharacterInterfaceV2)this.丘丌丞丑业丑丗上丟;
    }
    internal UnityEngine.Transform 丌丞丘一万丁万丌且()
    {
        if(this.丘丌丞丑业丑丗上丟 != null)
        {
                return this.丘丌丞丑业丑丗上丟.丁丝一下丁不七丗一();
        }
        
        return this.丘丌丞丑业丑丗上丟.丁丝一下丁不七丗一();
    }
    internal UnityEngine.Transform 世丈上丑东丞丐专万()
    {
        if(this.丘丌丞丑业丑丗上丟 != null)
        {
                return this.丘丌丞丑业丑丗上丟.transform;
        }
        
        return this.丘丌丞丑业丑丗上丟.transform;
    }
    internal static void 东丈且业万专丞丈丝(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ShopNGUIController.上丒丅丅丅不丕丘丁, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.上丒丅丅丅不丕丘丁 != 1152921505261215800);
    
    }
    internal static void 丒不下丑与丝专丂七(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ShopNGUIController.上丒丅丅丅不丕丘丁, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.上丒丅丅丅不丕丘丁 != 1152921505261215800);
    
    }
    public void HandleBattlePassButton()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).东七与与不丅丙上上()) == false)
        {
            goto label_9;
        }
        
        }
        
        }
        
        PGCompany.BattlePass.BattlePassGuiHandler.丙丂丂丕专丞世下与(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
        return;
        label_9:
        this.HandleInfoButton();
    }
    public void HandleBuyWeaponSkinButton()
    {
        this.OpenWeaponSkinArmoryInfoScreen(丙丂丒一丗下丘下丟:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
    }
    public void OpenWeaponSkinArmoryInfoScreen(string 丙丂丒一丗下丘下丟)
    {
        this.HandleInfoButton();
        if(this.上三不丑业七不万上 == 0)
        {
                return;
        }
        
        this.上三不丑业七不万上.丞丘一专七丘万丟七(丙业与丙丗丝不丈东:  true);
        this.上三不丑业七不万上.ShowSkinsUI();
        this.上三不丑业七不万上.丏丁专不七丒上七丁().七丞丝丆东丆一丆下(丛丆世丂丒丁不世不:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丙丂丒一丗下丘下丟));
    }
    public void HandleBuyWeaponAndWeaponSkinButton()
    {
        this.HandleInfoButton();
        if(this.上三不丑业七不万上 == 0)
        {
                return;
        }
        
        this.上三不丑业七不万上.丁丒丟世丙丛一丕丂(丙业与丙丗丝不丈东:  true);
    }
    public void HandleToWeaponButton()
    {
        string val_15;
        string val_16;
        var val_17;
        丙且上东下丏丏丟下 val_18;
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 240000)
        {
                return;
        }
        
        val_15 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        PGCompany.丟丝世万东万丆丟上 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_15);
        if(val_4 == null)
        {
                return;
        }
        
        PGCompany.丟丝东丈丐丙三下丛 val_6 = val_4.上专丗丏丛丁专丑丄().ItemWeapon;
        if(val_6 == null)
        {
                return;
        }
        
        if((上丑三丁丄丛丁万丑.且丙丌丒世不丕丆丟(七丆丒与丗丌丄且丂:  val_6, 丝丂丁丌丆三丆专且:  val_6.丐上下三丑丈丑丄丟(), 丙丑丄与丅丐一不东:  true)) != false)
        {
                val_16 = val_6;
            val_17 = val_16;
            val_18 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_6.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  val_6);
        }
        else
        {
                val_15 = val_6.业上丙丞丐丄丆丅七();
            if((上丑三丁丄丛丁万丑.专丕丆万丏三与丟一(丕丁下丌不万丅丞丛:  val_15)) == false)
        {
                return;
        }
        
            val_16 = val_6.业上丙丞丐丄丆丅七();
            丙且上东下丏丏丟下 val_14 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_16, 七丆丒与丗丌丄且丂:  val_6);
            val_17 = 131072;
            val_17 = 2;
            val_18 = val_14;
        }
        
        this.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  88, 与丝丕与丙不与丗丆:  val_14, 七丑业业丒七一丂丆:  false);
    }
    public void HandleCreateSetButton()
    {
        System.Collections.Generic.Dictionary<CategoryNames, System.String> val_28;
        var val_29;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean> val_31;
        System.Func<TSource, System.Boolean> val_32;
        System.Collections.Generic.IEnumerable<TSource> val_33;
        var val_34;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean> val_36;
        var val_37;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean> val_39;
        var val_40;
        丙且上东下丏丏丟下 val_42;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_2 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.upgradeBtnSound);
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 140000)
        {
                val_28 = val_5.丝丈不丗丐不丙丟丁;
            if(val_5.上七不丅丈丁不丛丝 != null)
        {
                System.Collections.Generic.KeyValuePair<CategoryNames, System.String>[] val_6 = new System.Collections.Generic.KeyValuePair<CategoryNames, System.String>[1];
            val_6[0] = 0;
            val_6[1] = 0;
            val_28 = System.Linq.Enumerable.Concat<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(first:  val_28, second:  val_6);
        }
        
            System.Collections.Generic.Dictionary<CategoryNames, System.String> val_8 = 丙丞丟丑丗丅专丈一.丂丙丟丅七七丗丄与(丂万丏专丒下丈丂丟:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()]);
            val_29 = null;
            val_29 = null;
            val_31 = ShopNGUIController.<>c.<>9__282_0;
            if(val_31 == null)
        {
                val_31 = null;
            val_31 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丟丏三丛丑丞丅丄丙(System.Collections.Generic.KeyValuePair<CategoryNames, string> 丈丏万丄丒业丅丒一));
            ShopNGUIController.<>c.<>9__282_0 = val_31;
        }
        
            val_32 = val_31;
            val_33 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  System.Linq.Enumerable.Except<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(first:  val_28, second:  val_8), predicate:  null);
            if(val_5.上七不丅丈丁不丛丝 != null)
        {
                val_32 = 0;
            if((丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  val_5.下丄丈不与世丐业专)) != false)
        {
                val_34 = null;
            val_34 = null;
            val_36 = ShopNGUIController.<>c.<>9__282_1;
            if(val_36 == null)
        {
                val_36 = null;
            val_36 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::三丟丐丝丂丑与业专(System.Collections.Generic.KeyValuePair<CategoryNames, string> 丈丏万丄丒业丅丒一));
            ShopNGUIController.<>c.<>9__282_1 = val_36;
        }
        
            val_32 = val_36;
            val_33 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  val_33, predicate:  null);
        }
        
        }
        
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_15 = WeaponManager.万一丛七丙丑丄丆丑();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()))) != true)
        {
                val_37 = null;
            val_37 = null;
            val_39 = ShopNGUIController.<>c.<>9__282_2;
            if(val_39 == null)
        {
                val_39 = null;
            val_39 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丐上丐丏丅丏丌丛丆(System.Collections.Generic.KeyValuePair<CategoryNames, string> 丈丏万丄丒业丅丒一));
            ShopNGUIController.<>c.<>9__282_2 = val_39;
        }
        
            val_33 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  val_33, predicate:  null);
        }
        
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  val_33)) != false)
        {
                val_40 = public static System.Collections.Generic.KeyValuePair<CategoryNames, System.String> System.Linq.Enumerable::First<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(System.Collections.Generic.IEnumerable<TSource> source);
            System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_22 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  丞东丑专丛丆丄丝世.丛且一丙七七丑东世<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(丑东与丅丐丅丂丞业:  val_33));
        }
        else
        {
                val_40 = public static System.Collections.Generic.KeyValuePair<CategoryNames, System.String> System.Linq.Enumerable::First<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(System.Collections.Generic.IEnumerable<TSource> source);
            System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_24 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  丞东丑专丛丆丄丝世.丛且一丙七七丑东世<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(丑东与丅丐丅丂丞业:  val_8));
        }
        
            val_42 = new 丙且上东下丏丏丟下();
            val_42 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_24.Value, 七丆丒与丗丌丄且丂:  val_24.Value.丙东专丂世丈丏丁丂());
        }
        else
        {
                val_42 = 0;
        }
        
        this.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  88, 与丝丕与丙不与丗丆:  val_42, 七丑业业丒七一丂丆:  false);
    }
    public void HandleWinSetButton()
    {
        FilterMaps val_5;
        ButtonClickSound.丁业上丏不丕三丗不();
        if(ShopNGUIController.丛丐丛专丟丞万三七() > 99)
        {
                val_5 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_5 = 0;
        }
        
        Rilisoft.GameEventGuiSets.丏且一丞丛丐丘丒且(且下丕七丙丗丄不七:  上丑三丁丄丛丁万丑.丈丙丏七与丙丑丌专(不与丈一上丗丄上丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()), 丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_5, 丈世丅不业丞业丁丐:  true);
    }
    internal void 丆丗世且丆丛丏丞上(string 丈丌丌万上丅丌丒不, CategoryNames 七丆丒与丗丌丄且丂)
    {
        UnityEngine.Transform val_10 = this.rentScreenPoint;
        if(val_10.childCount > 0)
        {
                return;
        }
        
        val_10 = UnityEngine.Object.Instantiate<CraftNewItemWindowController>(original:  UnityEngine.Resources.Load<CraftNewItemWindowController>(path:  "NguiWindows/CraftFinishedWindow"));
        val_10.transform.parent = this.rentScreenPoint;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        val_10.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_10.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUIShop"));
        val_10.Setup(丞一丁业丄一一业且:  丈丌丌万上丅丌丒不, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
    }
    internal void 丌丌丈不万七丆丙丗(string 丞丅上丏丂且下丅与)
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "Hand_leGo_ToTarge_tActio_n_NoI_nfo: IsExi_ting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        this.丏丄业丁丞万丛丏丘(丆丟七丝丏业丅上丄:  "offers");
    }
    internal void 丛丈丌丒下丘专不万(string 丞丅上丏丂且下丅与)
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        this.丏丄业丁丞万丛丏丘(丆丟七丝丏业丅上丄:  "EventStore");
    }
    internal void 东丌丙世且丂七丗上(string 丏世丑万世一七丟丞, UnityEngine.GameObject 下东丒且世万上丏且, bool 丘世丅丞丌丟丏下丙, UnityEngine.Transform 丄丒下丁丏丐专万丝, bool 丐丏上业丈丂与万丞 = False, bool 丗业丕七且丝丆丝丘 = False, System.Action 丟丟丟三东丛丌丘且)
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "HandleUp_gradeButton: IsExiti_ng", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        this.业三丄丝丐丌丆七丛(不丟丞丑丛丆丁东与:  true, 丏世丑万世一七丟丞:  丏世丑万世一七丟丞, 七丁上丁丒专丈七丙:  下东丒且世万上丏且, 丘世丅丞丌丟丏下丙:  false, 丟丟丟三东丛丌丘且:  丟丟丟三东丛丌丘且, 丐丏上业丈丂与万丞:  丐丏上业丈丂与万丞, 丗业丕七且丝丆丝丘:  丗业丕七且丝丆丝丘);
    }
    public void HandleSpeedupClicked()
    {
        丙且上东下丏丏丟下 val_10;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  31);
        val_10 = this.且丛丌丌七丈丝丒丈;
        PGCompany.Analytics.一业丗丆世世上丁且.丁丑三与业丏万丌丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且三丟七下丂专丈丈:  this.丙丛丝丝丁不丁丗丘(), 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 丑丝丏丂且不下一东:  val_10, 七丐丅专且专七三丆:  "speedup", 与上世丗丞丐万东丌:  "");
        ButtonClickSound.丁业上丏不丕三丗不();
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 7)
        {
            goto label_22;
        }
        
        if(((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  this.<与一丐丟丗三一东丂>k__BackingField)) == false) || (this.且丛丌丌七丈丝丒丈 == null))
        {
            goto label_12;
        }
        
        val_10 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  val_10)) == false)
        {
            goto label_17;
        }
        
        label_12:
        this.HandleInfoButton();
        label_22:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_17:
        this.丝丂丒丛丙不三且不(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 丛丘丑丗万丞上下丆:  this.mainPanel, 丘世丅丞丌丟丏下丙:  false, 丈丂丑七丆三丙一丕:  true);
        goto label_22;
    }
    internal void 丝丂丒丛丙不三且不(string 丞一丁业丄一一业且, UnityEngine.GameObject 丛丘丑丗万丞上下丆, bool 丘世丅丞丌丟丏下丙, bool 丈丂丑七丆三丙一丕 = False)
    {
        string val_19;
        bool val_20;
        丈丞丕丘丕丗与上一 val_21;
        var val_22;
        System.Action val_24;
        var val_25;
        ShopNGUIController.丏一丛下一七专专丐 val_1 = new ShopNGUIController.丏一丛下一七专专丐();
        if(val_1 != null)
        {
                val_19 = val_1;
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            mem[1152921539060351888] = this;
            val_20 = 1152921539060351864;
            mem[1152921539060351864] = 丆丐三丅丆丗东丑世.不与丗不丁丏与丄且(丞丅上丏丂且下丅与:  丞一丁业丄一一业且);
        }
        else
        {
                val_19 = 16;
            mem[16] = 丞一丁业丄一一业且;
            mem[48] = this;
            val_20 = true;
            mem[24] = 丆丐三丅丆丗东丑世.不与丗不丁丏与丄且(丞丅上丏丂且下丅与:  mem[16]);
        }
        
        bool val_6 = 丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  val_19);
        if(val_1 != null)
        {
                .丑丒专丒东不丑丕丛 = val_6;
            val_21 = SpeedUpWeaponUpWindow.丂丘下丈丐丞丝专丙(丒东业不丐丑丕丄丆:  mem[16], 丝东丌万丒丁丒世丑:  false, 丆丗一丛丌一与丅且:  val_20);
        }
        else
        {
                mem[40] = val_6;
            val_21 = SpeedUpWeaponUpWindow.丂丘下丈丐丞丝专丙(丒东业不丐丑丕丄丆:  mem[16], 丝东丌万丒丁丒世丑:  false, 丆丗一丛丌一与丅且:  mem[24]);
        }
        
        .万丐丏丐丒万不丟三 = val_21;
        bool val_19 = ~(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220));
        val_19 = val_19 & 1;
        .且丂丙世一上业三业 = val_19;
        System.Action val_13 = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丏一丛下一七专专丐::丙丅丛万丛丑东且丑());
        if((ShopNGUIController.丏一丛下一七专专丐)[1152921539060351840].且丂丙世一上业三业 != false)
        {
                val_13.Invoke();
            return;
        }
        
        if(丈丂丑七丆三丙一丕 == false)
        {
            goto label_10;
        }
        
        new System.Action() = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丏一丛下一七专专丐::丙万下丗七丏丏东丞());
        val_22 = null;
        val_22 = null;
        val_24 = ShopNGUIController.<>c.<>9__289_2;
        if(val_24 != null)
        {
            goto label_19;
        }
        
        System.Action val_15 = null;
        val_24 = val_15;
        val_15 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丆丌与万世丐丅丑且());
        ShopNGUIController.<>c.<>9__289_2 = val_24;
        goto label_19;
        label_10:
        new System.Action() = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丏一丛下一七专专丐::丌丐丛丆丗丅丅丅七());
        val_25 = null;
        val_25 = null;
        val_24 = ShopNGUIController.<>c.<>9__289_4;
        if(val_24 == null)
        {
                System.Action val_17 = null;
            val_24 = val_17;
            val_17 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丆丑业专丐丝东与世());
            ShopNGUIController.<>c.<>9__289_4 = val_24;
        }
        
        label_19:
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  丛丘丑丗万丞上下丆, 丒世丘丘上丆丝东丞:  (ShopNGUIController.丏一丛下一七专专丐)[1152921539060351840].万丐丏丐丒万不丟三, 七丒上且丝业业下七:  val_13, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(), 丞丐下东与丅万丅丁:  val_17, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  (mem[24] == true) ? 15 : 0, 丐丈上丂与上丂丒丏:  90);
    }
    public void HandleCraftClicked()
    {
        CategoryNames val_8;
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "HandleCraftClicked: IsExiting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        val_8 = this.<与一丐丟丗三一东丂>k__BackingField;
        if((val_8 == 8) || (val_8 == 250000))
        {
            goto label_16;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_6;
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 180000)
        {
            goto label_16;
        }
        
        val_8 = this.<与一丐丟丗三一东丂>k__BackingField;
        label_6:
        if(((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  val_8)) != false) && (this.且丛丌丌七丈丝丒丈 != null))
        {
                if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_16;
        }
        
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        this.HandleInfoButton();
        return;
        label_16:
        this.丅丁与上丝丆七业丄(丏世丑万世一七丟丞:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 下东丒且世万上丏且:  null, 丄丒下丁丏丐专万丝:  null);
    }
    internal void 丅丁与上丝丆七业丄(string 丏世丑万世一七丟丞, UnityEngine.GameObject 下东丒且世万上丏且, UnityEngine.Transform 丄丒下丁丏丐专万丝)
    {
        System.Object[] val_42;
        string val_43;
        ItemRarity val_44;
        var val_45;
        三丅丁丗丗丝丂万且 val_46;
        string val_47;
        string val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        string val_54;
        var val_55;
        丙且上东下丏丏丟下 val_56;
        CategoryNames val_57;
        var val_58;
        if((this.<丌世专万丞不丞丒与>k__BackingField) == false)
        {
            goto label_1;
        }
        
        val_42 = System.Array.Empty<System.Object>();
        val_43 = "Handle_CraftButton_NoInfo: IsExiting";
        goto label_4;
        label_1:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丏世丑万世一七丟丞)) == false)
        {
            goto label_7;
        }
        
        val_42 = System.Array.Empty<System.Object>();
        val_43 = "Handle_CraftButton_NoInfo _id.IsNullOrEmpty";
        label_4:
        UnityEngine.Debug.LogErrorFormat(format:  val_43, args:  val_42);
        return;
        label_7:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.upgradeBtnSound);
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 250000)
        {
                val_44 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世();
            if((val_44.丕丕丌丛丄丕丝丁下(丞丅上丏丂且下丅与:  丏世丑万世一七丟丞)) == false)
        {
                return;
        }
        
            this.丆丗世且丆丛丏丞上(丈丌丌万上丅丌丒不:  丏世丑万世一七丟丞, 七丆丒与丗丌丄且丂:  144);
            this.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
            this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  this.且丛丌丌七丈丝丒丈, 七丑业业丒七一丂丆:  false);
            return;
        }
        
        val_45 = 1152921505317388288;
        val_46 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丏世丑万世一七丟丞);
        if(val_46 != null)
        {
                string val_9 = val_46.三与丛丑且丐丈业丌();
        }
        
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_23;
        }
        
        ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丛丗丈且丟丒七丅(丘万丙丂与丕丅世丅:  false);
        goto label_29;
        label_23:
        ShopNGUIController.丞丙丅丛丟丅丝丒丏 val_11 = new ShopNGUIController.丞丙丅丛丟丅丝丒丏();
        if(val_11 == null)
        {
            goto label_26;
        }
        
        val_47 = val_11;
        .业丞丏不丕丟丁丆丒 = 丏世丑万世一七丟丞;
        val_48 = 丏世丑万世一七丟丞;
        if(val_48 != null)
        {
            goto label_27;
        }
        
        goto label_29;
        label_26:
        val_47 = 16;
        mem[16] = 丏世丑万世一七丟丞;
        val_48 = mem[16];
        if(val_48 == 0)
        {
            goto label_29;
        }
        
        label_27:
        WeaponManager.三万不上上三一丟丕(丒东业不丐丑丕丄丆:  val_47, 七丆丟丗世丟且丒丆:  false, 丒三且丟丈七丈丙丏:  false, 不丌丟专丙丈丟丘专:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true});
        val_49 = 1152921505264353280;
        bool val_12 = 丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  mem[16]);
        三丅丁丗丗丝丂万且 val_13 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  mem[16]);
        if((val_12 | (WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  mem[16]))) == false)
        {
            goto label_41;
        }
        
        val_50 = null;
        val_50 = null;
        if((WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  mem[16])) == false)
        {
            goto label_46;
        }
        
        label_41:
        val_51 = 0;
        goto label_47;
        label_46:
        val_52 = null;
        val_52 = null;
        val_51 = (~(WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  mem[16]))) & 1;
        label_47:
        int val_18 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  mem[16]);
        if(val_51 == 0)
        {
            goto label_55;
        }
        
        val_49 = 丙丞丟丑丗丅专丈一.丂丙丟丅七七丗丄与(丂万丏专丒下丈丂丟:  System.Linq.Enumerable.First<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  val_11, method:  System.Boolean ShopNGUIController.丞丙丅丛丟丅丝丒丏::丏三专丆丞业丁与丌(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌))));
        if(val_22.上七不丅丈丁不丛丝 == null)
        {
            goto label_61;
        }
        
        val_53 = val_22.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁;
        int val_25 = val_53.Count;
        goto label_63;
        label_55:
        val_54 = val_47;
        val_55 = val_18;
        if(val_11 != null)
        {
            goto label_72;
        }
        
        goto label_65;
        label_61:
        val_53 = 0;
        label_63:
        if((val_49.Count != (val_53 + val_22.丝丈不丗丐不丙丟丁.Count)) || (上丑三丁丄丛丁万丑.不三丛丂世且丗丑东() == false))
        {
            goto label_70;
        }
        
        val_54 = val_22.下丄丈不与世丐业专;
        val_55 = 131072;
        val_55 = 2;
        goto label_72;
        label_70:
        var val_29 = (val_11 != 0) ? 1 : 0;
        val_29 = val_12 | val_29;
        var val_30 = (val_12 != true) ? "Armor_Army_1" : (val_47);
        var val_31 = (val_12 != true) ? 7 : (val_18);
        if(val_29 == true)
        {
            goto label_72;
        }
        
        label_65:
        val_54 = val_47;
        val_55 = val_18;
        label_72:
        if(val_13 != 0)
        {
                CategoryNames val_33 = (val_13.东七与与不丅丙上上() != true) ? 170000 : (val_55);
        }
        
        if(val_33 == 180000)
        {
            goto label_74;
        }
        
        if(val_33 != 190000)
        {
            goto label_75;
        }
        
        丙且上东下丏丏丟下 val_34 = null;
        val_56 = val_34;
        val_34 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_54, 七丆丒与丗丌丄且丂:  48);
        val_57 = 8;
        goto label_77;
        label_74:
        丙且上东下丏丏丟下 val_35 = null;
        val_56 = val_35;
        val_35 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_54, 七丆丒与丗丌丄且丂:  32);
        val_57 = 6;
        goto label_77;
        label_75:
        丙且上东下丏丏丟下 val_36 = null;
        val_56 = val_36;
        val_36 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_54, 七丆丒与丗丌丄且丂:  val_33);
        val_57 = val_33;
        label_77:
        this.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  val_57, 与丝丕与丙不与丗丆:  val_36, 七丑业业丒七一丂丆:  false);
        this.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        val_46 = val_46;
        this.丆丗世且丆丛丏丞上(丈丌丌万上丅丌丒不:  mem[16], 七丆丒与丗丌丄且丂:  val_18);
        val_45 = 1152921505317388288;
        label_29:
        val_44 = 1152921505286238208;
        val_58 = null;
        val_58 = null;
        三丅丁丗丗丝丂万且 val_38 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丏世丑万世一七丟丞);
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  丏世丑万世一七丟丞)) != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丘丅专下世且丘丈丁(丞一丁业丄一一业且:  丏世丑万世一七丟丞);
        }
        else
        {
                if((丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  丏世丑万世一七丟丞)) != false)
        {
                Rilisoft.一丟专且三万丞丁丂.丅世不专丟丂不七业(丞一丁业丄一一业且:  丏世丑万世一七丟丞);
        }
        else
        {
                Rilisoft.一丟专且三万丞丁丂.丌业万世丘丙一丙丛(丞一丁业丄一一业且:  丏世丑万世一七丟丞);
            if(val_38 != null)
        {
                val_44 = val_38;
            Rilisoft.丞丛七上丕专丏丌丈.丁丝业万与世世丑万(丞丅上丏丂且下丅与:  val_46.丆七丄下业七丝丑丏(), 丈下丑丆上丏丗丈专:  val_44);
        }
        
        }
        
        }
        
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  this.且丛丌丌七丈丝丒丈, 七丑业业丒七一丂丆:  false);
    }
    public void HandleCrateLootClicked()
    {
    
    }
    public void HandleOpenCrateClicked()
    {
    
    }
    internal bool 丄丏丏丕丙专不丞七(string 丕丁下丌不万丅丞丛, UnityEngine.Transform 丄丒下丁丏丐专万丝)
    {
        ShopNGUIController.丅丞一丑丒丆丂业七 val_1 = new ShopNGUIController.丅丞一丑丒丆丂业七();
        if(val_1 != null)
        {
                .丕丁下丌不万丅丞丛 = 丕丁下丌不万丅丞丛;
        }
        else
        {
                mem[16] = 丕丁下丌不万丅丞丛;
        }
        
        .丄丒下丁丏丐专万丝 = 丄丒下丁丏丐专万丝;
        .丂丙丛丈丞丁丗丂丂 = new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean ShopNGUIController.丅丞一丑丒丆丂业七::世上业万丄丏丝丐丏());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丅丞一丑丒丆丂业七::世丒且丘丛丂丘业三()))) != false)
        {
                return false;
        }
        
        if((ShopNGUIController.丅丞一丑丒丆丂业七)[1152921539061517456].丂丙丛丈丞丁丗丂丂 != null)
        {
                return (ShopNGUIController.丅丞一丑丒丆丂业七)[1152921539061517456].丂丙丛丈丞丁丗丂丂.Invoke();
        }
        
        return (ShopNGUIController.丅丞一丑丒丆丂业七)[1152921539061517456].丂丙丛丈丞丁丗丂丂.Invoke();
    }
    private void 丑丟丆下丛丒丁丄丒(CategoryNames 东丕丅七丗丑丛下专, CategoryNames 专一与丘且上丟上且)
    {
        if(((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  东丕丅七丗丑丛下专)) != true) && (东丕丅七丗丑丛下专 != 8))
        {
                if(东丕丅七丗丑丛下专 != 6)
        {
                return;
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  专一与丘且上丟上且)) != false)
        {
                return;
        }
        
        if(专一与丘且上丟上且 == 6)
        {
                return;
        }
        
        if(专一与丘且上丟上且 == 8)
        {
                return;
        }
        
        if(专一与丘且上丟上且 == 250000)
        {
                return;
        }
        
        if(this.丙丟丝丂不丈专丅丅 == null)
        {
                return;
        }
        
        this.丙丟丝丂不丈专丅丅.Invoke();
    }
    internal void 丘丈丗上丑丞业丁与(string 丏世丑万世一七丟丞, UnityEngine.GameObject 下东丒且世万上丏且, bool 丘世丅丞丌丟丏下丙)
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "Handle_Buy_Button: IsExiting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        this.业三丄丝丐丌丆七丛(不丟丞丑丛丆丁东与:  false, 丏世丑万世一七丟丞:  丏世丑万世一七丟丞, 七丁上丁丒专丈七丙:  下东丒且世万上丏且, 丘世丅丞丌丟丏下丙:  false, 丟丟丟三东丛丌丘且:  0, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
    }
    public void HandleBuyButton()
    {
        var val_9;
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "Handle_BuyButton: IsExiting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_20;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true)
        {
                if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true)
        {
                if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_20;
        }
        
        }
        
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) > 189999)
        {
            goto label_17;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 170000)
        {
            goto label_20;
        }
        
        val_9 = 131072;
        val_9 = 2;
        goto label_19;
        label_17:
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 190000)
        {
            goto label_20;
        }
        
        val_9 = 196608;
        val_9 = 3;
        label_19:
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 200000)
        {
            goto label_21;
        }
        
        label_20:
        this.业三丄丝丐丌丆七丛(不丟丞丑丛丆丁东与:  false, 丏世丑万世一七丟丞:  0, 七丁上丁丒专丈七丙:  0, 丘世丅丞丌丟丏下丙:  false, 丟丟丟三东丛丌丘且:  0, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        return;
        label_21:
        ButtonClickSound.丁业上丏不丕三丗不();
        this.HandleInfoButton();
    }
    public void HandleBuyDetailsButton()
    {
        bool val_1 = this.不万丌丈且且丙丞上();
    }
    internal bool 不万丌丈且且丙丞上()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "Handle_BuyDet_ails_Button: IsExiting", args:  this);
            return false;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_13;
        }
        
        }
        
        }
        
        if(((this.<与一丐丟丗三一东丂>k__BackingField) == 141000) && (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 2))
        {
                label_13:
            string val_8 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
            return val_8.丄丏丏丕丙专不丞七(丕丁下丌不万丅丞丛:  val_8, 丄丒下丁丏丐专万丝:  this.rentScreenPoint);
        }
        
        this.HandleInfoButton();
        return false;
    }
    internal bool 下丕三丄三丕丘东丒(string 丆万一不丌且东丐丐)
    {
        UnityEngine.Transform val_4;
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "Handle_BuyDetailsButton_NoInfo: IsExiting", args:  System.Array.Empty<System.Object>());
            return false;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.<七且丆丙丌丞丂丘丗>k__BackingField, y:  0);
        if(val_2 != false)
        {
                val_4 = this.<七且丆丙丌丞丂丘丗>k__BackingField.transform;
            return val_2.丄丏丏丕丙专不丞七(丕丁下丌不万丅丞丛:  丆万一不丌且东丐丐, 丄丒下丁丏丐专万丝:  val_4 = this.rentScreenPoint);
        }
        
        return val_2.丄丏丏丕丙专不丞七(丕丁下丌不万丅丞丛:  丆万一不丌且东丐丐, 丄丒下丁丏丐专万丝:  val_4);
    }
    public void HandleGoToGatchaButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).东七与与不丅丙上上()) == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        System.Action val_6 = new System.Action(object:  this, method:  System.Void ShopNGUIController::东三上东专世丟世上());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_6)) != false)
        {
                return;
        }
        
        val_6.Invoke();
        return;
        label_10:
        this.HandleInfoButton();
    }
    public void HandleGoToContestButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).东七与与不丅丙上上()) == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        上丑三丁丄丛丁万丑.一下丛三与丙丅丘三();
        .Type = 14;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
        {
                return;
        }
        
        this = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        label_10:
        this.HandleInfoButton();
    }
    internal void 丐东丕专一世丆丑且(string 丏世丑万世一七丟丞)
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        System.Action val_1 = new System.Action(object:  this, method:  System.Void ShopNGUIController::丒丆东不丙丌下东丏());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_1)) != false)
        {
                return;
        }
        
        val_1.Invoke();
    }
    public void HandleGoToRouletteButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).东七与与不丅丙上上()) == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        System.Action val_6 = new System.Action(object:  this, method:  System.Void ShopNGUIController::丕下丕丏丞业丈丏三());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_6)) != false)
        {
                return;
        }
        
        val_6.Invoke();
        return;
        label_10:
        this.HandleInfoButton();
    }
    public void HandleGoToClanLobbyButton()
    {
        FilterMaps val_3;
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_3 = 0;
        }
        
        上丑三丁丄丛丁万丑.不专下丅世且与一丏(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_3);
    }
    internal void 丂丅世东丘丛丘丕丟(PGCompany.ClanStoreTab 且丂专丄丄丕丝丈一)
    {
        FilterMaps val_5;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_2;
        }
        
        if(ShopNGUIController.丛丐丛专丟丞万三七() < 100)
        {
            goto label_5;
        }
        
        val_5 = ShopNGUIController.丛丐丛专丟丞万三七();
        goto label_8;
        label_2:
        this.HandleGoToClanLobbyButton();
        return;
        label_5:
        val_5 = 0;
        label_8:
        上丑三丁丄丛丁万丑.与丒丐丗丝一万丒业(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_5, 且丂专丄丄丕丝丈一:  且丂专丄丄丕丝丈一);
    }
    internal void 丞丘三世丌丕业丝丞(string 丏世丑万世一七丟丞)
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        System.Action val_1 = new System.Action(object:  this, method:  System.Void ShopNGUIController::东丂丑专丆下丈丘专());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_1)) != false)
        {
                return;
        }
        
        val_1.Invoke();
    }
    public void HandleGoToChestsEventButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).东七与与不丅丙上上()) == false)
        {
            goto label_10;
        }
        
        }
        
        }
        
        System.Action val_6 = new System.Action(object:  this, method:  System.Void ShopNGUIController::东丟丏丐丏与三与丝());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_6)) != false)
        {
                return;
        }
        
        val_6.Invoke();
        return;
        label_10:
        this.HandleInfoButton();
    }
    internal void 业丄丘丗丏丒与三专(丙且上东下丏丏丟下 丑丝丏丂且不下一东)
    {
        ShopNGUIController.丝丁且丛一丗丞丏丟 val_1 = new ShopNGUIController.丝丁且丛一丗丞丏丟();
        if(val_1 != null)
        {
                .丑丝丏丂且不下一东 = 丑丝丏丂且不下一东;
        }
        else
        {
                mem[16] = 丑丝丏丂且不下一东;
        }
        
        .丝且与丝丒丟万丁专 = this;
        if((this.<丌世专万丞不丞丒与>k__BackingField) == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        System.Action val_2 = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丝丁且丛一丗丞丏丟::业丛丒专丛丕丟丘丄());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_2)) != false)
        {
                return;
        }
        
        val_2.Invoke();
    }
    public void HandleUpgradeButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "HandleUpgradeButton: IsExiting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_4;
        }
        
        if((((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true) && ((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true)) && (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 25000))
        {
                if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true)
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 7)
        {
            goto label_20;
        }
        
        }
        
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        this.HandleInfoButton();
        return;
        label_20:
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
            goto label_21;
        }
        
        label_4:
        label_21:
        this.东丌丙世且丂七丗上(丏世丑万世一七丟丞:  0.业上丙丞丐丄丆丅七(), 下东丒且世万上丏且:  this.mainPanel, 丘世丅丞丌丟丏下丙:  false, 丄丒下丁丏丐专万丝:  null, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false, 丟丟丟三东丛丌丘且:  0);
    }
    public void HandleWatchAdvertisementButton()
    {
        if(FreeAwardController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        bool val_4 = Rilisoft.ArmorSpeedUpController.丑七不且上丗丁一世().丐丟丑丄丛丟万丝万();
    }
    public void HandlePetInfoButton()
    {
        if(this.rentScreenPoint.childCount != 0)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 25000)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() == null)
        {
                return;
        }
        
        UnityEngine.Transform val_5 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "PetInfoNursery"));
        val_5.parent = this.rentScreenPoint;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_5.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        if(val_5 != null)
        {
                val_5.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        else
        {
                val_5.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        PetInfoController val_8 = val_5.GetComponent<PetInfoController>();
        val_8.WasCreated = true;
        val_8.Show(世丐丗专丅三丝丑丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 下丗丐丙丙丞与与三:  0, 上丑七与丗三丐丈丙:  true, 上世丗与丗东三丐丛:  0);
    }
    public void HandleRenamePetButton()
    {
        if(this.rentScreenPoint.childCount != 0)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 25000)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() == null)
        {
                return;
        }
        
        UnityEngine.Transform val_5 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "NguiWindows/PetRenameWindows"));
        val_5.parent = this.rentScreenPoint;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_5.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_5.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  80, 丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        new PGCompany.世丒丗丅丛丕不万丂() = new PGCompany.世丒丗丅丛丕不万丂(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
        val_5.GetComponent<PetRenameWindov>().丈且东丑丂且万丒丅(上东丞世三世且丈丌:  new PGCompany.世丒丗丅丛丕不万丂());
    }
    private bool 下业专不东丙丌丌丞()
    {
        System.Collections.Generic.IEnumerable<TSource> val_5;
        var val_6;
        var val_7;
        System.Func<ArmoryCell, System.Boolean> val_9;
        val_5 = this;
        if((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField)) != false)
        {
                val_6 = 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 7)
        {
                return (bool)val_6;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 140000)
        {
                return (bool)val_6;
        }
        
        val_5 = this.丝丟丐丁丌丛丞东专<ArmoryCell>(丟丝七七一丁丏丏丙:  false);
        if(val_5 == null)
        {
                ArmoryCell[] val_3 = new ArmoryCell[0];
            val_5 = val_3;
        }
        
        if(val_3.Length != 0)
        {
                val_7 = null;
            val_7 = null;
            val_9 = ShopNGUIController.<>c.<>9__315_0;
            if(val_9 != null)
        {
                return System.Linq.Enumerable.All<ArmoryCell>(source:  val_3, predicate:  System.Func<ArmoryCell, System.Boolean> val_4 = null);
        }
        
            val_9 = val_4;
            val_4 = new System.Func<ArmoryCell, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丝丘丅丁丞丑下丐丄(ArmoryCell 丌丝万上丅丒一丈丘));
            ShopNGUIController.<>c.<>9__315_0 = val_9;
            return System.Linq.Enumerable.All<ArmoryCell>(source:  val_3, predicate:  val_4);
        }
        
        val_6 = 1;
        return (bool)val_6;
    }
    private bool 丁世丁丌上丌丘与一(世丕丑七且丝七不不 七丆丒与丗丌丄且丂)
    {
        System.Collections.Generic.Dictionary<世丕丑七且丝七不不, System.Boolean> val_6;
        var val_7;
        val_6 = this;
        bool val_2 = false;
        if(七丆丒与丗丌丄且丂 == 0)
        {
                if(this.下业专不东丙丌丌丞() == true)
        {
            goto label_2;
        }
        
        }
        
        val_6 = this.不丞丝丑一东丅七丏;
        if((val_6.TryGetValue(key:  七丆丒与丗丌丄且丂, value: out  val_2)) != false)
        {
                var val_4 = (val_2 != 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        object[] val_5 = new object[1];
        val_6 = val_5;
        val_6[0] = 七丆丒与丗丌丄且丂;
        UnityEngine.Debug.LogErrorFormat(format:  "NeedToSh_owPro_pertiesInCategory: not found value for category {0}", args:  val_5);
        label_2:
        val_7 = 0;
        return (bool)val_7;
    }
    internal static void 丈丅丌丙丝丘一丝且(string 世丐丗专丅三丝丑丆)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_4 = null;
            val_4 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丝丂丗七丒丄丄东丐();
        }
        
        丆丟七丌丞东丆丕丌.丛丑专专世丑丗丁东(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆);
        val_5 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
    }
    public void HandleEquipButton()
    {
        世丕丑七且丝七不不 val_68;
        var val_69;
        string val_70;
        var val_71;
        string val_72;
        string val_73;
        三丅丁丗丗丝丂万且 val_74;
        string val_75;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  29);
        val_68 = this.丙丛丝丝丁不丁丗丘();
        PGCompany.Analytics.一业丗丆世世上丁且.丁丑三与业丏万丌丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且三丟七下丂专丈丈:  val_68, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丐丅专且专七三丆:  "equip", 与上世丗丞丐万东丌:  "");
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 170000)
        {
            goto label_8;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 141000)
        {
            goto label_13;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_10;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_13;
        }
        
        label_8:
        .丈丞丛且丅一丐丁丂 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        val_68 = 1152921505286238208;
        val_69 = null;
        val_69 = null;
        val_70 = (ShopNGUIController.丅丕丛丝丈丄丁一丒)[1152921539065964608].丈丞丛且丅一丐丁丂.三与丛丑且丐丈业丌();
        val_71 = null;
        if((System.String.op_Equality(a:  val_70, b:  WeaponManager.丐丙丅丒与不丘业丟())) == false)
        {
            goto label_22;
        }
        
        WeaponManager.丝丅丛丛丙丆丂丏丁(丙业与丙丗丝不丈东:  WeaponManager.丐丙丅丒与不丘业丟());
        goto label_130;
        label_13:
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
            goto label_26;
        }
        
        label_10:
        label_26:
        val_70 = 上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  0.丒万丕七专不丏丞丌());
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_29;
        }
        
        if(val_70 == false)
        {
            goto label_30;
        }
        
        label_38:
        label_133:
        this.丆丌且三丟丒丟丛丁(丈丁丄丘丛世七丙丝:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_22:
        val_71 = null;
        val_70 = WeaponManager.丟丗丄业丘丗业丗七;
        val_70.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丅下三且万丟东不下(), predicate:  new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new ShopNGUIController.丅丕丛丝丈丄丁一丒(), method:  System.Boolean ShopNGUIController.丅丕丛丝丈丄丁一丒::七七上丈上丄专丗世(三丈丟与丏丘丈丐万 丌丝下丄业一丄不三))), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  true);
        label_130:
        this.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        label_124:
        this.丙丑丘业丕丗丗不丘();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_29:
        if(val_70 == true)
        {
            goto label_38;
        }
        
        label_30:
        CategoryNames val_22 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_42;
        }
        
        val_72 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        if(val_22 == 7)
        {
            goto label_44;
        }
        
        string val_24 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  val_72);
        val_72 = val_24;
        if((System.String.IsNullOrEmpty(value:  val_24)) == true)
        {
            goto label_124;
        }
        
        label_44:
        this.三上丅丕上丈丐且丁(丒东业不丐丑丕丄丆:  val_72);
        goto label_124;
        label_42:
        if(val_22 != 8)
        {
            goto label_50;
        }
        
        上丑三丁丄丛丁万丑.丙丘丙不丟东且丌丏(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_124;
        label_50:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 2000)
        {
            goto label_55;
        }
        
        Rilisoft.上丑业三丆丆丅丕三.丘丅丕一丈丅丟一与(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_55:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 25000)
        {
            goto label_60;
        }
        
        ShopNGUIController.丈丅丌丙丝丘一丝且(世丐丗专丅三丝丑丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_124;
        label_60:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_66;
        }
        
        丆丟七丌丞东丆丕丌.丏下丕丏丘丅与丂丐(丗丑丐丕丟丝且下丕:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌(), 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七(), 且丙丄且丐上与丈丆:  false);
        goto label_130;
        label_66:
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 140000)
        {
            goto label_74;
        }
        
        this.丝丂丗七丒丄丄东丐();
        丙丞丟丑丗丅专丈一.丌丁丂不业丐上七三(丐世下不一丁丟丅专:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 专丂丘丛不且丑丘上:  false);
        goto label_130;
        label_74:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 150000)
        {
            goto label_81;
        }
        
        丙丞丟丑丗丅专丈一.丌丁丂不业丐上七三(丐世下不一丁丟丅专:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 专丂丘丛不且丑丘上:  true);
        this.丑丟业专万丂丈上丂(不与万丌一丈下丑丈:  true);
        this.丛丌且丙丏丘一下丏(不与万丌一丈下丑丈:  true);
        this.丘丈丛三丝不丅丕丆(不与万丌一丈下丑丈:  true);
        this.不丐丑丐丆丘专丙丅(不与万丌一丈下丑丈:  true);
        this.丗丁且丙世丒上丑丟(不与万丌一丈下丑丈:  true);
        this.丐不专丗丞不不丑丏();
        goto label_124;
        label_81:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 160000)
        {
            goto label_86;
        }
        
        丛且丗丌丏下七下丈.丗丏三七且丈丟丂一(丁且业丁丞下丕丄不:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_86:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 200000)
        {
            goto label_91;
        }
        
        丛且丗丌丏下七下丈.丕丐下丄丙与丌丏一(丗业一丑上七丟万且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_91:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 210000)
        {
            goto label_96;
        }
        
        丛且丗丌丏下七下丈.丟七下丂七万万世不(七不丏丗丘丘东万七:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_96:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 180000)
        {
            goto label_101;
        }
        
        丛且丗丌丏下七下丈.丈下丟丄丏丅东丛丙(丝丂七万丆丟丄上丕:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_101:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 190000)
        {
            goto label_106;
        }
        
        if((System.String.op_Inequality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  "EMPTY_ROYALE_AVATAR")) == false)
        {
            goto label_107;
        }
        
        val_73 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        goto label_109;
        label_106:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 240000)
        {
            goto label_110;
        }
        
        PGCompany.丟丝世万东万丆丟上 val_54 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        丏丞丛上七丁丞丛万.万三一且丞丏一丗七(丞丝丌七丁万丗丐一:  val_54);
        PGCompany.丟丝东丈丐丙三下丛 val_56 = val_54.上专丗丏丛丁专丑丄().ItemWeapon;
        if(val_56 == null)
        {
            goto label_118;
        }
        
        val_74 = val_56.丐上下三丑丈丑丄丟();
        val_75 = val_56.业上丙丞丐丄丆丅七();
        goto label_119;
        label_107:
        val_73 = "EMPTY_ROYALE_AVATAR";
        label_109:
        上丑三丁丄丛丁万丑.上七一丆丝丂丝且东(丞丅上丏丂且下丅与:  val_73);
        goto label_124;
        label_110:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 250000)
        {
            goto label_124;
        }
        
        PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丑丐丕丆丟与丏下丈(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        goto label_130;
        label_118:
        val_74 = 0.丐上下三丑丈丑丄丟();
        val_75 = 0.业上丙丞丐丄丆丅七();
        label_119:
        if((上丑三丁丄丛丁万丑.一世三三丈不丟不丕(世上丝且丟丕三丗东:  val_56, 世且丝丗丙丅丛丒万:  val_74, 丝东与不东与一丅丄:  val_75, 东丈丒三丞与业世一:  true, 丂丒丒丆且丝丘丈丟:  val_56.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_130;
        }
        
        string val_67 = val_54.上专丗丏丛丁专丑丄().WeaponTag;
        goto label_133;
    }
    private void 丆丌且三丟丒丟丛丁(string 丈丁丄丘丛世七丙丝)
    {
        string val_12;
        var val_13;
        int val_14;
        var val_15;
        var val_16;
        val_12 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  丈丁丄丘丛世七丙丝);
        if(val_12 == null)
        {
            goto label_3;
        }
        
        label_23:
        .丟丈一下东业一丝丆 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_12).三与丛丑且丐丈业丌();
        val_13 = null;
        val_13 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丆丌且三丟丒丟丛丁(与丘东下丈东丛丂万:  System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.丅下三且万丟东不下(), predicate:  new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new ShopNGUIController.丙丙丒丒丏东专丅丏(), method:  System.Boolean ShopNGUIController.丙丙丒丒丏东专丅丏::丟丆丙且下不丝三专(三丈丟与丏丘丈丐万 丌丝下丄业一丄不三))), 专东丅一三丏三丐丟:  true, 丂丐丕丟丕丗且东丐:  true);
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
            goto label_12;
        }
        
        val_14 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        goto label_13;
        label_3:
        val_15 = null;
        val_15 = null;
        val_12 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_12 == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_12 = WeaponManager.丟丗丄业丘丗业丗七;
        if(丈丁丄丘丛世七丙丝 == null)
        {
                return;
        }
        
        val_12 = 丈丁丄丘丛世七丙丝;
        if((val_12.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  丈丁丄丘丛世七丙丝)) == true)
        {
            goto label_23;
        }
        
        return;
        label_12:
        val_14 = 0.丈丄丙丙丈丗业丆万();
        label_13:
        WeaponManager.丟丗丄业丘丗业丗七.丘丄万上丐上丞上丆(丞世不丒下上上丝丑:  val_14);
        if(this.且与丛丈丁丟专丈丑 == null)
        {
                return;
        }
        
        this.且与丛丈丁丟专丈丑.Invoke(obj:  val_12);
    }
    public void HandleUnequipButton()
    {
        世丕丑七且丝七不不 val_29;
        bool val_30;
        int val_31;
        var val_32;
        System.Func<WeaponSkinSettings, System.Boolean> val_34;
        var val_35;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  29);
        val_29 = this.丙丛丝丝丁不丁丗丘();
        PGCompany.Analytics.一业丗丆世世上丁且.丁丑三与业丏万丌丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且三丟七下丂专丈丈:  val_29, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丐丅专且专七三丆:  "unequip", 与上世丗丞丐万东丌:  "");
        CategoryNames val_6 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_12;
        }
        
        val_30 = this.丁丝丁上丂上专丐业;
        丆丟七丌丞东丆丕丌.丗丁丅丄不下丙与下(丙丑丕丂下丏一丁专:  val_6, 丆万丐丗丅丘丆丁丌:  (val_30 == true) ? 1 : 0, 丏丘丐一丝丒丛与下:  true);
        goto label_32;
        label_12:
        val_30 = this.且丛丌丌七丈丝丒丈;
        if(val_6 != 2000)
        {
            goto label_17;
        }
        
        bool val_9 = Rilisoft.上丑业三丆丆丅丕三.丄东下丒丙东业丘七(且丘世丏丛丛万丟万:  val_30.业上丙丞丐丄丆丅七());
        goto label_32;
        label_17:
        if(val_30.丒万丕七专不丏丞丌() != 25000)
        {
            goto label_21;
        }
        
        this.丝丂丗七丒丄丄东丐();
        丆丟七丌丞东丆丕丌.世丝且万丈丝丁丁丕(世丐丗专丅三丝丑丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        this.丆与丅世下一丟不丏(下丅丙一丂丗丅丝七:  this.且丛丌丌七丈丝丒丈, 丕丝丟下丗丛一丕业:  false, 丙丑丄丟万上丙丈丘:  false);
        goto label_32;
        label_21:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 180000)
        {
            goto label_27;
        }
        
        丛且丗丌丏下七下丈.丈下丟丄丏丅东丛丙(丝丂七万丆丟丄上丕:  "");
        goto label_32;
        label_27:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 240000)
        {
            goto label_32;
        }
        
        PGCompany.丟丝世万东万丆丟上 val_16 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        if(val_16 == null)
        {
            goto label_37;
        }
        
        PGCompany.丟丝东丈丐丙三下丛 val_18 = val_16.上专丗丏丛丁专丑丄().ItemWeapon;
        if(val_18 == null)
        {
            goto label_37;
        }
        
        val_31 = val_18.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌();
        if(val_31 != null)
        {
            goto label_39;
        }
        
        label_37:
        val_31 = System.String.alignConst;
        label_39:
        val_29 = 1152921505339326464;
        val_32 = null;
        val_32 = null;
        val_34 = ShopNGUIController.<>c.<>9__320_0;
        if(val_34 == null)
        {
                System.Func<WeaponSkinSettings, System.Boolean> val_22 = null;
            val_34 = val_22;
            val_22 = new System.Func<WeaponSkinSettings, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丌且七丌万丕丗丕丟(WeaponSkinSettings 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__320_0 = val_34;
        }
        
        WeaponSkinSettings val_23 = System.Linq.Enumerable.FirstOrDefault<WeaponSkinSettings>(source:  丏丞丛上七丁丞丛万.丙且七业七专一且丈(丈丁丄丘丛世七丙丝:  val_31), predicate:  val_22);
        PGCompany.世东三上七丂丌下丑 val_24 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_23 == 0)
        {
            goto label_49;
        }
        
        val_30 = val_23.SkinIndex;
        if(val_24 != null)
        {
            goto label_55;
        }
        
        goto label_52;
        label_49:
        val_35 = null;
        val_35 = null;
        val_30 = 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东;
        if(val_24 != null)
        {
            goto label_55;
        }
        
        label_52:
        label_55:
        丏丞丛上七丁丞丛万.万三一且丞丏一丗七(丞丝丌七丁万丗丐一:  val_24.一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  val_30));
        label_32:
        this.丙丑丘业丕丗丗不丘();
        this.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void HandleEnableButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "Handle_EnableButton: IsExiting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        System.Action val_2 = new System.Action(object:  this, method:  System.Void ShopNGUIController::丆丗上上丝下丆业丕());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_2)) != false)
        {
                return;
        }
        
        val_2.Invoke();
    }
    public void HandleCreateButton()
    {
        System.Action val_1 = new System.Action(object:  this, method:  System.Void ShopNGUIController::三丝万与丈世丘三丈());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_1)) != false)
        {
                return;
        }
        
        val_1.Invoke();
    }
    public void HandleEditButton()
    {
        System.Action val_1 = new System.Action(object:  this, method:  System.Void ShopNGUIController::丘丂七丕丅丗不上下());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_1)) != false)
        {
                return;
        }
        
        val_1.Invoke();
    }
    public void HandleDeleteButton()
    {
        .丝且与丝丒丟万丁专 = this;
        .丘丂丁丏丐丂丂丂丟 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        InfoWindowController.丕丌丞七丛三一丌万(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1693"), 东不丒丗万丏世世丒:  new System.Action(object:  new ShopNGUIController.丘丕丕一万丁丐丙丏(), method:  System.Void ShopNGUIController.丘丕丕一万丁丐丙丏::专世丂丂且业丛丁丘()), 丏丙且东丑上丗丏丛:  0);
    }
    public void HandleInfoButton()
    {
        var val_17;
        Rilisoft.BankBannersHolder val_92;
        PGCompany.三丘丌上丁万丏丛丟 val_93;
        var val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        丙且上东下丏丏丟下 val_99;
        CategoryNames val_100;
        string val_101;
        var val_102;
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 220000)
        {
                return;
        }
        
        }
        
        if(this.stub != 0)
        {
                if(this.stub.activeInHierarchy == true)
        {
                return;
        }
        
        }
        
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
                return;
        }
        
            if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((ShopNGUIController.丐丅丒丞不丘专丗下(下丅丙一丂丗丅丝七:  this.且丛丌丌七丈丝丒丈)) == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.rentScreenPoint.childCount != 0)
        {
                return;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 30000)
        {
            goto label_18;
        }
        
        val_92 = this.bannersHolder;
        HatchEggUIBanner.丅下三丂不万世丗上(世丕丘丈丙世业东丕:  new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())), 丘丒丅三丞丞丛丛丌:  val_92);
        goto label_155;
        label_18:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 230000)
        {
            goto label_25;
        }
        
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == true)
        {
            goto label_155;
        }
        
        val_92 = this.且丛丌丌七丈丝丒丈.丞一丁业丄一一业且;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_92)) == null)
        {
            goto label_155;
        }
        
        if(null != null)
        {
                val_93 = 0;
        }
        
        PGCompany.ModuleChestViewer val_18 = PGCompany.ModuleChestViewer.下与丞三丅丛丄七丕(丐下丝丘丑丟丟丗丌:  val_93, 丆丏七丟不丒与七专:  this.rentScreenPoint);
        goto label_155;
        label_25:
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_36;
        }
        
        val_94 = null;
        val_94 = null;
        if((System.String.op_Inequality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  WeaponManager.丑与一世丛丄业丐丒)) == true)
        {
            goto label_66;
        }
        
        label_36:
        if(((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true) && ((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField)) != true))
        {
                if((七丌丞万七万丁丐丙.丗丗丗丐丏丟丅丛专(丝丒丞丙丐一一丅三:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) != false)
        {
                if((七丌丞万七万丁丐丙.丕与东丞丕丒丘不丂(丝丒丞丙丐一一丅三:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).专七三丘丗七丆丟丗()) != false)
        {
                if((WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == null)
        {
            goto label_66;
        }
        
        }
        
        }
        
            if(((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != true) && ((this.<与一丐丟丗三一东丂>k__BackingField) != 7))
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 240000)
        {
            goto label_68;
        }
        
        }
        
        }
        
        label_66:
        val_95 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_100;
        }
        
        val_96 = null;
        val_96 = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_88;
        }
        
        val_97 = null;
        val_97 = null;
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_88;
        }
        
        if((WeaponManager.丐上业丐丏丐万世丑().Contains(item:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) != false)
        {
                if((丈丑世东下与丕丅丁.丐且丏与丑丏丒丑丈(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
            goto label_88;
        }
        
        }
        
        val_98 = null;
        val_98 = null;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_100;
        }
        
        label_88:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 150000)
        {
                if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == null)
        {
                ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        label_100:
        UnityEngine.Transform val_54 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "ArmoryInfoScreen"));
        this.<七且丆丙丌丞丂丘丗>k__BackingField = val_54;
        val_54.parent = this.rentScreenPoint;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.zero;
        this.<七且丆丙丌丞丂丘丗>k__BackingField.localPosition = new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z};
        val_17 = 0;
        this.<七且丆丙丌丞丂丘丗>k__BackingField.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(((七丌丞万七万丁丐丙.丗丗丗丐丏丟丅丛专(丝丒丞丙丐一一丅三:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false) || ((七丌丞万七万丁丐丙.丕与东丞丕丒丘不丂(丝丒丞丙丐一一丅三:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()).专七三丘丗七丆丟丗()) == false))
        {
            goto label_116;
        }
        
        丛且专丞丗丆丙丒万 val_64 = System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  this, method:  System.Boolean ShopNGUIController::丅万丁丌三丕业丏三(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)));
        val_99 = new 丙且上东下丏丏丟下();
        val_100 = 131072;
        val_100 = 2;
        val_101 = val_64.下丄丈不与世丐业专;
        goto label_121;
        label_116:
        string val_66 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 240000)
        {
            goto label_124;
        }
        
        PGCompany.丟丝东丈丐丙三下丛 val_68 = 丏丞丛上七丁丞丛万.丆丄三丐丌世下万丟(丝与丙丘丞且丄专丅:  val_66).ItemWeapon;
        丙且上东下丏丏丟下 val_71 = null;
        val_99 = val_71;
        val_71 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_68.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_68);
        val_92 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        if(val_99 != null)
        {
            goto label_136;
        }
        
        goto label_134;
        label_124:
        丙且上东下丏丏丟下 val_76 = null;
        val_99 = val_76;
        val_101 = val_66;
        val_100 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        label_121:
        val_76 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_101, 七丆丒与丗丌丄且丂:  val_100);
        val_92 = 0;
        if(val_99 != null)
        {
            goto label_136;
        }
        
        label_134:
        label_136:
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_76.丒万丕七专不丏丞丌())) == false)
        {
            goto label_149;
        }
        
        val_102 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_76.业上丙丞丐丄丆丅七());
        if(val_102 == null)
        {
            goto label_151;
        }
        
        val_17 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_102.业东丅东丌上丗丑不()), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
        {
            goto label_149;
        }
        
        val_17 = 0;
        Rilisoft.业丙丘丆东丈丕丂丄 val_87 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().一丁丝丗业丁丑丁丒(丕上业丕丘上丘七一:  40, 丞一丁业丄一一业且:  val_102.与不丞丑七丘丁丂丛(), 下丗丁丒丘东丂不丑:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false}, 丌丒丝东丌下丕丁丅:  new System.Nullable<System.Int32>() {HasValue = false});
        if(val_87 == null)
        {
            goto label_149;
        }
        
        val_76.七丝下丈不不三丌专(丙业与丙丗丝不丈东:  Rilisoft.Offers.上一丈丏三丒三丙不.丙丈一丒三丁七丝一(丟专丑丈七与上七丞:  val_87.丏与丅专三丙与丘丒()));
        val_102 = 1;
        goto label_151;
        label_149:
        val_102 = 0;
        label_151:
        ArmoryInfoScreenController val_90 = this.<七且丆丙丌丞丂丘丗>k__BackingField.GetComponent<ArmoryInfoScreenController>();
        this.上三不丑业七不万上 = val_90;
        val_90.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_76, 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  val_92);
        label_155:
        this.丟丙且丝万与不丑丐();
        return;
        label_68:
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 25000)
        {
            goto label_155;
        }
        
        this.HandlePetInfoButton();
        goto label_155;
    }
    public void HandleFacebookButton()
    {
        var val_3;
        System.Action val_5;
        System.Action val_7;
        val_3 = null;
        val_3 = null;
        val_5 = ShopNGUIController.<>c.<>9__326_0;
        if(val_5 == null)
        {
                System.Action val_1 = null;
            val_5 = val_1;
            val_1 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丞世七丈世丅专七上());
            val_3 = null;
            ShopNGUIController.<>c.<>9__326_0 = val_5;
        }
        
        val_3 = null;
        val_7 = ShopNGUIController.<>c.<>9__326_1;
        if(val_7 == null)
        {
                System.Action val_2 = null;
            val_7 = val_2;
            val_2 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::与丌丒世丒专且丆丑());
            ShopNGUIController.<>c.<>9__326_1 = val_7;
        }
        
        MainMenuController.业业丅丘丑丁丕且专(七丐丅专且专七三丆:  val_1, 丆丒丅丁不且丛一业:  val_2);
    }
    public void HandleProfileButton()
    {
    
    }
    private void 丄万与丂丐下丆丁丂(ArmoryCell 丆丌丏丞丄丈万丒丁)
    {
        UnityEngine.Material val_1 = 丆丌丏丞丄丈万丒丁.capeRenderer.material;
        UnityEngine.Material val_3 = 丆丌丏丞丄丈万丒丁.modelForSkin.GetComponent<UnityEngine.MeshRenderer>().material;
        UnityEngine.Vector3 val_5 = this.topPointForShader.transform.localPosition;
        UnityEngine.Vector3 val_7 = this.bottomPointForShader.transform.localPosition;
        float val_12 = val_7.y;
        val_12 = val_12 + 5f;
        UnityEngine.Transform val_9 = this.gridScrollView.transform.parent;
        UnityEngine.Vector3 val_10 = val_9.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_11 = val_9.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(val_1 != null)
        {
                val_1.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        else
        {
                0.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        
        val_1.SetFloat(name:  "_BottomBorder", value:  val_11.y);
        if(val_3 != null)
        {
                val_3.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        else
        {
                0.SetFloat(name:  "_TopBorder", value:  val_10.y);
        }
        
        val_3.SetFloat(name:  "_BottomBorder", value:  val_11.y);
    }
    private void 丝丂丗七丒丄丄东丐()
    {
        this.petProfileAnimationRunner.StopAllCoroutines();
    }
    private void 东东丏世丅三丗丅丟()
    {
        this.topPointForShader.GetComponent<UIWidget>().ResetAndUpdateAnchors();
        this.bottomPointForShader.GetComponent<UIWidget>().ResetAndUpdateAnchors();
    }
    private void 业东丁业与业丐丙东()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.grid1Header, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.grid2Header, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.firstGrid.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemsGrid.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private T[] 丝丟丐丁丌丛丞东专<T>(bool 丟丝七七一丁丏丏丙)
    {
        UIWrapContent val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_19 = this.itemsWrapContainer;
        丟丝七七一丁丏丏丙 = 丟丝七七一丁丏丏丙;
        T[] val_1 = val_19.GetComponentsInChildren<ShopItemsRowContainer>(includeInactive:  丟丝七七一丁丏丏丙);
        if(val_1 == null)
        {
                return (T[])val_20;
        }
        
        if(val_1.Length < 1)
        {
            goto label_3;
        }
        
        val_21 = 1152921538461676464;
        val_22 = 0;
        label_20:
        if((val_1[0] == 0) || ((val_1[0x0] + 32.AttachedCells) == null))
        {
            goto label_10;
        }
        
        val_24 = 0;
        goto label_11;
        label_19:
        val_25 = val_1[0x0] + 32.AttachedCells.Item[0];
        var val_6 = (val_25 != 0) ? (val_22 + 1) : (val_22);
        val_24 = 1;
        label_11:
        if(val_24 < (val_1[0x0] + 32.AttachedCells.Count))
        {
            goto label_19;
        }
        
        label_10:
        if((0 + 1) < val_1.Length)
        {
            goto label_20;
        }
        
        goto label_21;
        label_3:
        val_22 = 0;
        label_21:
        val_19 = mem[__RuntimeMethodHiddenParam + 48 + 8];
        val_19 = __RuntimeMethodHiddenParam + 48 + 8;
        val_20 = val_19;
        if(val_1.Length < 1)
        {
                return (T[])val_20;
        }
        
        val_19 = 1152921538461676464;
        label_50:
        if((val_1[0] == 0) || ((val_1[0x0] + 32.AttachedCells) == null))
        {
            goto label_30;
        }
        
        val_26 = 0;
        goto label_31;
        label_49:
        if((val_1[0x0] + 32.AttachedCells.Item[0]) == null)
        {
            goto label_36;
        }
        
        BaseArmoryCell val_15 = val_1[0x0] + 32.AttachedCells.Item[0];
        if(val_15 == null)
        {
            goto label_43;
        }
        
        val_27 = val_15;
        if(val_27 != null)
        {
            goto label_44;
        }
        
        label_43:
        val_27 = 0;
        label_44:
        val_23 = val_20;
        var val_17 = val_23 + 0;
        mem2[0] = val_27;
        label_36:
        val_26 = 1;
        label_31:
        val_25 = val_1[0x0] + 32.AttachedCells;
        if(val_26 < val_25.Count)
        {
            goto label_49;
        }
        
        label_30:
        if((0 + 1) < val_1.Length)
        {
            goto label_50;
        }
        
        val_20 = val_20;
        return (T[])val_20;
    }
    private void 丙一东丄七世下业丄()
    {
        var val_25;
        System.Func<ShopItemsRowContainer, System.Int32> val_27;
        if(this.fixedSlider == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        val_27 = ShopNGUIController.<>c.<>9__333_0;
        if(val_27 == null)
        {
                System.Func<ShopItemsRowContainer, System.Int32> val_2 = null;
            val_27 = val_2;
            val_2 = new System.Func<ShopItemsRowContainer, System.Int32>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ShopNGUIController.<>c::万丄丑丐丛业丞七丝(ShopItemsRowContainer 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__333_0 = val_27;
        }
        
        if((System.Linq.Enumerable.First<ShopItemsRowContainer>(source:  System.Linq.Enumerable.OrderBy<ShopItemsRowContainer, System.Int32>(source:  this.上丟丞且丞丏丑上丏, keySelector:  val_2))) == 0)
        {
                return;
        }
        
        val_27 = val_4.丘丅下下丌上万丂且;
        if(val_27.Count < 1)
        {
                return;
        }
        
        UnityEngine.Transform val_8 = val_4.丘丅下下丌上万丂且.Item[0].transform;
        UnityEngine.Vector3 val_9 = val_8.localPosition;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  null);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  2f);
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = val_8.TransformPoint(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Vector3 val_15 = val_8.localPosition;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  val_12.x);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  2f);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Vector3 val_20 = val_8.TransformPoint(position:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
        float val_26 = (float)val_4.wrapIndex;
        val_26 = (System.Math.Abs(val_14.y - val_20.y)) * val_26;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  val_26);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        this.fixedSlider.UpdateSlider(丒不三丁丒丏丂丒丈:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
    }
    private void 丒一丄丛上七丁不丘(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
    {
        int val_3;
        ShopItemsRowContainer val_1 = 丝三丁东丈丒世丅业.GetComponent<ShopItemsRowContainer>();
        val_3 = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
        if(val_1 != null)
        {
                val_1.wrapIndex = val_3;
        }
        else
        {
                val_1.wrapIndex = val_3;
            val_3 = val_1.wrapIndex;
        }
        
        this.丈不丈丝丏丁东东丆(业丟丈丂丝丐丌丛世:  val_1, 丞世不丒下上上丝丑:  val_3);
    }
    private void 丈不丈丝丏丁东东丆(ShopItemsRowContainer 业丟丈丂丝丐丌丛世, int 丞世不丒下上上丝丑)
    {
        var val_5;
        var val_6;
        val_5 = 丞世不丒下上上丝丑;
        int val_5 = 业丟丈丂丝丐丌丛世.maxCellsCount;
        int val_1 = val_5 * val_5;
        val_5 = val_5 + val_1;
        if(val_1 >= val_5)
        {
                return;
        }
        
        do
        {
            val_6 = null;
            val_6 = null;
            业丟丈丂丝丐丌丛世.InitializeCellWithShopItem(丑丝丏丂且不下一东:  this.丟丛丒丅七丛丏丌一(一丂丐丟丅丑业万东:  val_1 + 0), 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 业丌丆业丘丟丆丁丛:  0, 丈东丘丏与丌东东下:  ShopNGUIController.丏丙丅丕一丑丕丑丑);
            int val_6 = 业丟丈丂丝丐丌丛世.maxCellsCount;
            val_5 = 0 + 1;
            val_6 = val_6 + val_1;
        }
        while((val_1 + val_5) < val_6);
    
    }
    private 丙且上东下丏丏丟下 丟丛丒丅七丛丏丌一(int 一丂丐丟丅丑业万东)
    {
        var val_3;
        if(this.万丕丛丝丑丗下丁丘.Count > 一丂丐丟丅丑业万东)
        {
                丙且上东下丏丏丟下 val_2 = this.万丕丛丝丑丗下丁丘.Item[一丂丐丟丅丑业万东];
            return (丙且上东下丏丏丟下)val_3;
        }
        
        val_3 = 0;
        return (丙且上东下丏丏丟下)val_3;
    }
    private void 丗一丝专丘七丑丏世(BaseArmoryCell 丌丝万上丅丒一丈丘, UnityEngine.Vector2 丟丒且一专丟丙下一, float 丝丕丁丏丏上丅丏且)
    {
        UnityEngine.Transform val_1 = 丌丝万上丅丒一丈丘.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        if(val_1 != null)
        {
                val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        else
        {
                0.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
        val_1.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丟丒且一专丟丙下一.x, y = 丟丒且一专丟丙下一.y});
        丌丝万上丅丒一丈丘.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UIWidget val_6 = 丌丝万上丅丒一丈丘.GetComponent<UIWidget>();
        if(val_6 != 0)
        {
                val_6.width = (int)丟丒且一专丟丙下一.x;
        }
        
        this.丞世一丄丆七丝丅业(丆丌丏丞丄丈万丒丁:  丌丝万上丅丒一丈丘);
    }
    private void 丐丄丑七专丙专丐万(BaseArmoryCell 丌丝万上丅丒一丈丘, int 业丌丆业丘丟丆丁丛, CategoryNames 七丆丒与丗丌丄且丂)
    {
        var val_3;
        if(七丆丒与丗丌丄且丂 == 140000)
        {
                val_3 = "sets_";
        }
        
        丌丝万上丅丒一丈丘.name = System.String.Format(format:  "{0}{1}", arg0:  System.String.__il2cppRuntimeField_static_fields, arg1:  业丌丆业丘丟丆丁丛.ToString(format:  "D4"));
    }
    internal static string 丆世业丂下丟丐丌丑()
    {
        return "e";
    }
    internal void 不丑丞丌丂世专丄下(丙且上东下丏丏丟下 与丝丕与丙不与丗丆)
    {
        ShopItemsRowContainer[] val_122;
        float val_123;
        float val_124;
        var val_125;
        int val_126;
        int val_127;
        var val_128;
        UIWrapContent val_129;
        bool val_130;
        var val_131;
        int val_132;
        var val_133;
        System.Func<ShopItemsRowContainer, System.Int32> val_134;
        float val_135;
        var val_136;
        UIScrollView val_138;
        var val_139;
        七丁丌丒万丄专三三 val_141;
        var val_142;
        string val_143;
        ShopNGUIController.丐丗世与丙丟丐丙丕 val_1 = new ShopNGUIController.丐丗世与丙丟丐丙丕();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .与丝丕与丙不与丗丆 = 与丝丕与丙不与丗丆;
        if(this.itemsWrapContainer.onInitializeItem == null)
        {
                this.itemsWrapContainer.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ShopNGUIController::丒一丄丛上七丁不丘(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
        }
        
        this.业东丁业与业丐丙东();
        int val_3 = 上丑三丁丄丛丁万丑.丂不丂丐丄丞丛丙丐();
        UIWidget val_6 = this.gridScrollView.transform.parent.GetComponent<UIWidget>();
        if(val_6 != null)
        {
                val_6.ResetAndUpdateAnchors();
            this.东东丏世丅三丗丅丟();
        }
        else
        {
                0.ResetAndUpdateAnchors();
            this.东东丏世丅三丗丅丟();
        }
        
        if((this.丝丟丐丁丌丛丞东专<ArmoryCell>(丟丝七七一丁丏丏丙:  true)) == null)
        {
                ArmoryCell[] val_10 = new ArmoryCell[0];
        }
        
        if(ShopNGUIController.专丏丄丙一一丆丌三 != true)
        {
                ShopNGUIController.专丏丄丙一一丆丌三 = true;
        }
        
        System.Collections.Generic.List<丙且上东下丏丏丟下> val_12 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 丙丑丄与丅丐一不东:  true);
        this.万丕丛丝丑丗下丁丘 = val_12;
        if((ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].与丝丕与丙不与丗丆 == null)
        {
            goto label_26;
        }
        
        label_204:
        val_122 = this.itemsWrapContainer.GetComponentsInChildren<ShopItemsRowContainer>(includeInactive:  true);
        float val_124 = -12f;
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.one;
        .丞丟丛丛丐丅丛丞丂 = 1;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 140000)
        {
                float val_121 = (float)val_6.width;
            val_121 = val_121 + val_124;
            val_121 = val_121 + (-20f);
            val_121 = val_121 + 10f;
            val_123 = 208f;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_121, y:  val_123);
        }
        else
        {
                float val_122 = (float)val_6.width;
            float val_123 = -10f;
            val_122 = val_122 + val_124;
            val_123 = (float)val_3 * val_123;
            val_122 = val_122 + val_123;
            val_122 = val_122 / (float)val_3;
            val_124 = val_122 / 170f;
            val_124 = val_124 * 150f;
            val_122 = val_122 + 10f;
            val_123 = val_124 + 10f;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_122, y:  val_123);
        }
        
        .丞丟丛丛丐丅丛丞丂 = val_3;
        this.itemsGrid.cellWidth = val_16.x;
        this.itemsGrid.cellHeight = val_16.y;
        this.itemsGrid.maxPerLine = (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂;
        if(val_13.Length != 5)
        {
            goto label_36;
        }
        
        val_125 = 1152921538461675440;
        goto label_37;
        label_57:
        T val_125 = val_122[0];
        if((val_13[0x0][0] + 40) != 140000)
        {
            goto label_40;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 140000)
        {
            goto label_41;
        }
        
        goto label_43;
        label_40:
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 140000)
        {
            goto label_43;
        }
        
        label_41:
        val_125.ClearContainer();
        label_43:
        mem2[0] = val_16.x;
        mem2[0] = val_16.y;
        mem2[0] = (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂;
        if(((val_13[0x0][0] + 48.Count) != 0) || ((ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂 < 1))
        {
            goto label_49;
        }
        
        do
        {
            val_125.AttachCell(丆丌丏丞丄丈万丒丁:  丆东丟下丌下丏上丌.万丒丙七丘不丁丈三(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField), 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField);
        }
        while(1 < (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂);
        
        goto label_49;
        label_55:
        val_123 = val_16.y;
        val_124 = val_124;
        this.丗一丝专丘七丑丏世(丌丝万上丅丒一丈丘:  val_13[0x0][0] + 48.Item[0], 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_16.x, y = val_123}, 丝丕丁丏丏上丅丏且:  val_124);
        this.丐丄丑七专丙专丐万(丌丝万上丅丒一丈丘:  val_13[0x0][0] + 48.Item[0], 业丌丆业丘丟丆丁丛:  0 + (0 * (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂), 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField);
        label_49:
        if(1 < (val_13[0x0][0] + 48.Count))
        {
            goto label_55;
        }
        
        val_125.丞丁下丟丆且下上丕();
        label_37:
        if(1 < val_13.Length)
        {
            goto label_57;
        }
        
        goto label_58;
        label_36:
        val_125 = 28;
        do
        {
            ShopItemsRowContainer val_23 = 丆东丟下丌下丏上丌.专一丈丅丂丆丈丒丅();
            val_23.gameObject.name = 0.ToString(format:  "D4");
            val_23.transform.SetParent(parent:  this.itemsWrapContainer.transform, worldPositionStays:  false);
            if(val_23 != null)
        {
                val_23.cellSize = val_16.x;
            mem2[0] = val_16.y;
        }
        else
        {
                mem[24] = val_16.x;
            mem[28] = val_16.y;
        }
        
            val_23.maxCellsCount = (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂;
            if((ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂 >= 1)
        {
                do
        {
            BaseArmoryCell val_28 = 丆东丟下丌下丏上丌.万丒丙七丘不丁丈三(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField);
            val_123 = val_16.y;
            val_124 = val_124;
            this.丗一丝专丘七丑丏世(丌丝万上丅丒一丈丘:  val_28, 丟丒且一专丟丙下一:  new UnityEngine.Vector2() {x = val_16.x, y = val_123}, 丝丕丁丏丏上丅丏且:  val_124);
            this.丐丄丑七专丙专丐万(丌丝万上丅丒一丈丘:  val_28, 业丌丆业丘丟丆丁丛:  0 + (0 * (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂), 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField);
            val_23.AttachCell(丆丌丏丞丄丈万丒丁:  val_28, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField);
        }
        while(1 < (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂);
        
        }
        
            val_23.丞丁下丟丆且下上丕();
        }
        while(1 < 5);
        
        val_122 = this.itemsWrapContainer.GetComponentsInChildren<ShopItemsRowContainer>(includeInactive:  true);
        label_58:
        this.上丟丞且丞丏丑上丏 = val_122;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemsWrapContainer.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Vector2 val_33 = this.gridScrollView.panel.GetViewSize();
        .丟专丏不东专世丄丄 = UnityEngine.Mathf.CeilToInt(f:  val_33.y / this.itemsGrid.cellHeight);
        val_126 = (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂;
        val_127 = this.万丕丛丝丑丗下丁丘.Count + (new System.Func<System.Collections.Generic.List<丙且上东下丏丏丟下>, System.Int32>(object:  val_1, method:  System.Int32 ShopNGUIController.丐丗世与丙丟丐丙丕::丘一丑丅一丐丙业丁(System.Collections.Generic.List<丙且上东下丏丏丟下> 丈丏东丐不丕丐东丟)).Invoke(arg:  this.万丕丛丝丑丗下丁丘));
        int val_39 = val_127 / (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂;
        if(val_39 <= (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丟专丏不东专世丄丄)
        {
            goto label_83;
        }
        
        goto label_84;
        label_90:
        val_128 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_122[0].gameObject, 丏业丟一东丂东丘丛:  true);
        label_84:
        if(1 < val_30.Length)
        {
            goto label_90;
        }
        
        val_129 = this.itemsWrapContainer;
        if(val_129 == null)
        {
            goto label_231;
        }
        
        val_130 = 1;
        goto label_92;
        label_83:
        val_131 = 0;
        goto label_93;
        label_99:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_122[0].gameObject, 丏业丟一东丂东丘丛:  (val_131 < val_39) ? 1 : 0);
        val_131 = 1;
        label_93:
        if(val_131 < val_30.Length)
        {
            goto label_99;
        }
        
        val_129 = this.itemsWrapContainer;
        if(val_129 == null)
        {
            goto label_231;
        }
        
        val_130 = false;
        label_92:
        this.itemsWrapContainer.CanOverrideRestrictWithingPanel = val_130;
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 230000)
        {
            goto label_108;
        }
        
        val_127 = UnityEngine.Mathf.Max(a:  0, b:  丐东不丅丂丂丅丙不.丑万丛丅与丆丏丌丑() - this.万丕丛丝丑丗下丁丘.Count);
        val_128 = public System.Int32 System.Collections.Generic.List<丙且上东下丏丏丟下>::get_Count();
        val_132 = val_30.Length;
        if(val_132 < 1)
        {
            goto label_108;
        }
        
        label_129:
        val_133 = 0;
        goto label_109;
        label_128:
        BaseArmoryCell val_48 = T[].__il2cppRuntimeField_this_arg.Item[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_48.emptyModuleChestGO, 丏业丟一东丂东丘丛:  false);
        int val_49 = this.万丕丛丝丑丗下丁丘.Count - 1;
        if(0 >= val_30.Length)
        {
            
        }
        else
        {
                if(0 >= val_30.Length)
        {
                BaseArmoryCell val_51 = T[].__il2cppRuntimeField_this_arg.Item[0];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_51.emptyModuleChestGO, 丏业丟一东丂东丘丛:  true);
            val_127 = val_127 - 1;
        }
        
        }
        
        val_132 = val_30.Length;
        val_133 = 1;
        label_109:
        val_128 = public System.Int32 System.Collections.Generic.List<BaseArmoryCell>::get_Count();
        if(val_133 < T[].__il2cppRuntimeField_this_arg.Count)
        {
            goto label_128;
        }
        
        val_125 = 0 + 1;
        if(val_125 < val_30.Length)
        {
            goto label_129;
        }
        
        label_108:
        this.itemsWrapContainer.cullContent = false;
        val_134 = 1152921505261211648;
        int val_128 = 1;
        val_128 = val_128 - (val_127 / val_126);
        this.itemsWrapContainer.minIndex = val_128;
        val_135 = val_16.y;
        this.itemsWrapContainer.itemSize = UnityEngine.Mathf.FloorToInt(f:  val_135);
        this.gridScrollView.restrictWithinPanel = true;
        this.gridScrollView.ResetPosition();
        val_136 = null;
        val_136 = null;
        if(ShopNGUIController.下丙丟且丕丆丌东业 != true)
        {
                ShopNGUIController.下丙丟且丕丆丌东业 = true;
            if(this.gridScrollView.panel != 0)
        {
                this.gridScrollView.panel.ResetAndUpdateAnchors();
            this.gridScrollView.panel.Refresh();
        }
        
            this.AdjustCategoryGridCells();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.fixedSlider, 丏业丟一东丂东丘丛:  (val_127 > 0) ? 1 : 0);
        val_138 = 1152921504848912384;
        if((this.fixedSlider != 0) && (this.fixedSlider.gameObject.activeSelf != false))
        {
                val_127 = 1152921505261318144;
            val_139 = null;
            val_139 = null;
            val_134 = ShopNGUIController.<>c.<>9__340_4;
            if(val_134 == null)
        {
                System.Func<ShopItemsRowContainer, System.Int32> val_63 = null;
            val_134 = val_63;
            val_63 = new System.Func<ShopItemsRowContainer, System.Int32>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ShopNGUIController.<>c::丅丑丈丏专丐丘东丄(ShopItemsRowContainer 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__340_4 = val_134;
        }
        
            if((System.Linq.Enumerable.First<ShopItemsRowContainer>(source:  System.Linq.Enumerable.OrderBy<ShopItemsRowContainer, System.Int32>(source:  this.上丟丞且丞丏丑上丏, keySelector:  val_63))) != 0)
        {
                val_134 = val_65.丘丅下下丌上万丂且;
            if(val_134.Count >= 1)
        {
                UnityEngine.Transform val_69 = val_65.丘丅下下丌上万丂且.Item[0].transform;
            UnityEngine.Vector3 val_70 = val_69.localPosition;
            UnityEngine.Vector3 val_71 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_72 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z}, d:  val_16.y);
            UnityEngine.Vector3 val_73 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z}, d:  2f);
            UnityEngine.Vector3 val_74 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z}, b:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z});
            UnityEngine.Vector3 val_75 = val_69.TransformPoint(position:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
            UnityEngine.Vector3 val_76 = val_69.localPosition;
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_78 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z}, d:  val_16.y);
            UnityEngine.Vector3 val_79 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_78.z}, d:  2f);
            UnityEngine.Vector3 val_80 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z}, b:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z});
            UnityEngine.Vector3 val_81 = val_69.TransformPoint(position:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z});
            this.fixedSlider.StartContentPosition = new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z};
            UnityEngine.Vector3 val_82 = UnityEngine.Vector3.up;
            int val_129 = (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].丞丟丛丛丐丅丛丞丂;
            val_129 = val_127 / val_129;
            UnityEngine.Vector3 val_83 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_82.x, y = val_82.y, z = val_82.z}, d:  (float)val_129);
            UnityEngine.Vector3 val_84 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, b:  new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z});
            UnityEngine.Vector3 val_85 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_83.x, y = val_83.y, z = val_83.z}, d:  val_84.y);
            this.fixedSlider.ContentSize = new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z};
            val_134 = this.fixedSlider;
            UnityEngine.Vector3 val_86 = UnityEngine.Vector3.up;
            UnityEngine.Vector2 val_88 = this.gridScrollView.panel.GetViewSize();
            UnityEngine.Vector3 val_89 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_86.z}, d:  val_88.y);
            UnityEngine.Vector3 val_90 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, b:  new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z});
            UnityEngine.Vector3 val_92 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_89.x, y = val_89.y, z = val_89.z}, d:  val_90.y / val_90.x);
            val_135 = val_92.x;
            val_134.ViewSize = new UnityEngine.Vector3() {x = val_135, y = val_92.y, z = val_92.z};
            if(this.fixedSlider.ScrollView == 0)
        {
                val_134 = this.gridScrollView;
            this.fixedSlider.ScrollView = val_134;
        }
        
            if(this.丄且丆丛丗丆丗丙丙 != true)
        {
                val_138 = this.gridScrollView;
            UIScrollView.七丁丌丒万丄专三三 val_95 = null;
            val_134 = val_95;
            val_95 = new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ShopNGUIController::丙一东丄七世下业丄());
            val_141 = System.Delegate.Combine(a:  this.gridScrollView.ScrollbarUpdating, b:  val_95);
            if((val_141 != null) && (null != null))
        {
                val_141 = 0;
        }
        
            this.gridScrollView.ScrollbarUpdating = val_141;
        }
        
        }
        
        }
        
        }
        
        if((ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].与丝丕与丙不与丗丆 == null)
        {
            goto label_196;
        }
        
        val_138 = 1152921504616005632;
        System.Func<丙且上东下丏丏丟下, System.Boolean> val_98 = null;
        val_134 = val_98;
        val_98 = new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  val_1, method:  System.Boolean ShopNGUIController.丐丗世与丙丟丐丙丕::丄丝三丏丕东不丏东(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七));
        val_127 = 1152921539071296448;
        if((System.Linq.Enumerable.Any<丙且上东下丏丏丟下>(source:  this.万丕丛丝丑丗下丁丘, predicate:  val_98)) != true)
        {
                if((System.Linq.Enumerable.Any<丙且上东下丏丏丟下>(source:  new System.Collections.Generic.List<丙且上东下丏丏丟下>(), predicate:  new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  val_1, method:  System.Boolean ShopNGUIController.丐丗世与丙丟丐丙丕::丒丐丏丙丁不三不丅(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)))) == false)
        {
            goto label_198;
        }
        
        }
        
        label_218:
        this.丆与丅世下一丟不丏(下丅丙一丂丗丅丝七:  (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].与丝丕与丙不与丗丆, 丕丝丟下丗丛一丕业:  true, 丙丑丄丟万上丙丈丘:  true);
        return;
        label_26:
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 240000)
        {
            goto label_200;
        }
        
        丙且上东下丏丏丟下 val_102 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_12);
        .与丝丕与丙不与丗丆 = val_102;
        if(val_102 != null)
        {
            goto label_204;
        }
        
        label_200:
        if((this.且丛丌丌七丈丝丒丈 == null) || ((System.Linq.Enumerable.Any<丙且上东下丏丏丟下>(source:  this.万丕丛丝丑丗下丁丘, predicate:  new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  val_1, method:  System.Boolean ShopNGUIController.丐丗世与丙丟丐丙丕::不东丆丐丞丑丞丗万(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)))) == false))
        {
            goto label_204;
        }
        
        .与丝丕与丙不与丗丆 = this.且丛丌丌七丈丝丒丈;
        goto label_204;
        label_196:
        if((((this.世丕丝丞丘丑丌丆丒() == true) || (this.下丗万丟且三丌三且() == true)) || (this.丞丁丞丌丛上丆丐丘() == true)) || (this.一丙专丘与万丏丐丑() == true))
        {
            goto label_228;
        }
        
        return;
        label_198:
        val_142 = 1152921505259880448;
        if(((this.且丛丌丌七丈丝丒丈 == null) || (this.万丕丛丝丑丗下丁丘.Count < 1)) || (PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世() == null))
        {
            goto label_216;
        }
        
        val_142 = 1152921505259880448;
        if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_216;
        }
        
        丙且上东下丏丏丟下 val_114 = this.万丕丛丝丑丗下丁丘.Item[0];
        goto label_218;
        label_216:
        val_138 = this.<与一丐丟丗三一东丂>k__BackingField;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_138)) == false)
        {
            goto label_221;
        }
        
        val_143 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  (ShopNGUIController.丐丗世与丙丟丐丙丕)[1152921539071466112].与丝丕与丙不与丗丆.业上丙丞丐丄丆丅七());
        if(val_143 != null)
        {
            goto label_227;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_226;
        }
        
        val_143 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        goto label_227;
        label_221:
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 8)
        {
                this.且丛丌丌七丈丝丒丈 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  "CustomSkinID", 七丆丒与丗丌丄且丂:  8);
            return;
        }
        
        label_228:
        this.且丛丌丌七丈丝丒丈 = 0;
        return;
        label_226:
        val_143 = 0;
        label_227:
        this.丆与丅世下一丟不丏(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_143, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField), 丕丝丟下丗丛一丕业:  true, 丙丑丄丟万上丙丈丘:  true);
        return;
        label_231:
    }
    public void HandlePropertiesHideShow(PropertiesHideSHow 丐丒丌丘丒且丑丞丘)
    {
        this.不丞丝丑一东丅七丏.set_Item(key:  this.丙丛丝丝丁不丁丗丘(), value:  (丐丒丌丘丒且丑丞丘.isHidden == false) ? 1 : 0);
        CoroutineRunner val_3 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_5 = val_3.StartCoroutine(routine:  val_3.丕丅丁丟东丏一丕丝(丐丒丌丘丒且丑丞丘:  丐丒丌丘丒且丑丞丘));
    }
    private System.Collections.IEnumerator 丕丅丁丟东丏一丕丝(PropertiesHideSHow 丐丒丌丘丒且丑丞丘)
    {
        .丐丒丌丘丒且丑丞丘 = 丐丒丌丘丒且丑丞丘;
        return (System.Collections.IEnumerator)new ShopNGUIController.丕丂丒丅丒不下丁丑(丗丏丅丕丆世丁专丟:  0);
    }
    internal BaseArmoryCell 一世下丏世下丗丒专(string 丞一丁业丄一一业且)
    {
        var val_10;
        var val_11;
        var val_12;
        .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
        System.Collections.Generic.List<BaseArmoryCell> val_2 = this.丌丛丕专丝丁万专丆();
        if(val_2 == null)
        {
                return (BaseArmoryCell)val_2.Item[0];
        }
        
        if(val_2.Count == 0)
        {
            goto label_3;
        }
        
        System.Predicate<丙且上东下丏丏丟下> val_4 = static_value_081D9E68;
        val_4 = new System.Predicate<丙且上东下丏丏丟下>(object:  new ShopNGUIController.丁丞丆七上且丏丞丘(), method:  System.Boolean ShopNGUIController.丁丞丆七上且丏丞丘::丗丛专丐下上丏丞丒(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
        int val_5 = this.万丕丛丝丑丗下丁丘.FindIndex(match:  val_4);
        if((val_5 & 2147483648) != 0)
        {
            goto label_5;
        }
        
        int val_6 = val_2.Count;
        val_11 = public BaseArmoryCell System.Collections.Generic.List<BaseArmoryCell>::get_Item(int index);
        val_12 = val_5 - ((val_5 / val_6) * val_6);
        return (BaseArmoryCell)val_2.Item[0];
        label_3:
        val_10 = 0;
        return (BaseArmoryCell)val_2.Item[0];
        label_5:
        val_12 = 0;
        val_11 = public BaseArmoryCell System.Collections.Generic.List<BaseArmoryCell>::get_Item(int index);
        return (BaseArmoryCell)val_2.Item[0];
    }
    private void 丈下东丌丈丂七东下()
    {
        this.caption.text = System.String.alignConst;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.wearNameLabels, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.skinNameLabels, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.armorNameLabels, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
    }
    private void 丟丕世丕丅下丑丛丟(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        var val_38;
        丙且上东下丏丏丟下 val_54;
        string val_55;
        string val_56;
        System.Func<TSource, System.Boolean> val_57;
        string val_58;
        var val_59;
        var val_60;
        val_54 = 下丅丙一丂丗丅丝七;
        val_55 = this;
        .下丅丙一丂丗丅丝七 = val_54;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 140000)
        {
                this.丈下东丌丈丂七东下();
            return;
        }
        
        val_56 = val_54.业上丙丞丐丄丆丅七();
        if((ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌() == 30000)
        {
                System.Func<PGCompany.EggIncubatorProgress, System.Boolean> val_6 = null;
            val_57 = val_6;
            val_6 = new System.Func<PGCompany.EggIncubatorProgress, System.Boolean>(object:  new ShopNGUIController.丙丛丗丙丒丕三丌且(), method:  System.Boolean ShopNGUIController.丙丛丗丙丒丕三丌且::丂业丞丙丞丐丈东丅(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且));
            if((System.Linq.Enumerable.FirstOrDefault<PGCompany.EggIncubatorProgress>(source:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄(), predicate:  val_6)) != null)
        {
                val_56 = val_7.DataId;
        }
        else
        {
                object[] val_8 = new object[1];
            val_57 = (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
            val_8[0] = val_57;
            UnityEngine.Debug.LogErrorFormat(format:  "ShopNguiController: idForName, egg = null, item.Id = {0}", args:  val_8);
        }
        
        }
        
        CategoryNames val_10 = (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        val_54 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_56, 七丆丒与丗丌丄且丂:  val_10);
        if(((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_10)) != false) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_54)) != true))
        {
                val_57 = 1152921504647901184;
            if(((val_54.EndsWith(value:  "up1", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) != true) && ((val_54.EndsWith(value:  "up2", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) != true))
        {
                if((val_54.EndsWith(value:  "up 1", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) != true)
        {
                if((val_54.EndsWith(value:  "up 2", ignoreCase:  true, culture:  System.Globalization.CultureInfo.InvariantCulture)) == false)
        {
            goto label_125;
        }
        
        }
        
        }
        
            val_54 = val_54.Substring(startIndex:  0, length:  val_54.Length - 4);
        }
        
        label_125:
        if((ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌() == 240000)
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_28 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
            if(val_28 != null)
        {
                val_54 = val_28;
        }
        else
        {
                val_54 = 0;
        }
        
        }
        
        if((ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌() == 250000)
        {
                PGCompany.丘三丏丌丗丒万丏丈 val_32 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞丅上丏丂且下丅与:  (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
            if(val_32 != null)
        {
                val_54 = val_32.七业丑不七丐业丟丂();
        }
        else
        {
                val_54 = 0;
        }
        
        }
        
        this.caption.text = val_54;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.wearNameLabels, 丕丗丘丑丛与丑业丒:  val_54);
        if(this.skinNameLabels == null)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 8)
        {
                val_54 = this.且丛丌丌七丈丝丒丈;
            if(val_54.丒万丕七专不丏丞丌() != 2000)
        {
                return;
        }
        
        }
        
        val_54 = this.skinNameLabels;
        List.Enumerator<T> val_36 = val_54.GetEnumerator();
        val_57 = "CustomSkinID";
        label_103:
        if((106445152 & 1) == 0)
        {
            goto label_65;
        }
        
        string val_39 = val_38.丐丏七丌丕丗业且上();
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 8)
        {
            goto label_67;
        }
        
        if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == null)
        {
            goto label_103;
        }
        
        val_39.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_42.Lkey);
        goto label_103;
        label_67:
        if((System.String.op_Equality(a:  (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七(), b:  "CustomSkinID")) != false)
        {
                val_58 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1090");
        }
        else
        {
                val_59 = null;
            val_59 = null;
            if((SkinsController.丛上不下丐丐丞丒专.ContainsKey(key:  (ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) != false)
        {
                val_60 = null;
            val_60 = null;
            val_58 = SkinsController.丛上不下丐丐丞丒专.Item[(ShopNGUIController.丙丛丗丙丒丕三丌且)[1152921539073078720].下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七()];
        }
        else
        {
                val_58 = "";
        }
        
        }
        
        val_39.text = val_58;
        goto label_103;
        label_65:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丆与丅世下一丟不丏(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丕丝丟下丗丛一丕业 = False, bool 丙丑丄丟万上丙丈丘 = False)
    {
        UIScrollView val_42;
        object val_43;
        丙且上东下丏丏丟下 val_44;
        var val_45;
        var val_46;
        System.Func<BaseArmoryCell, System.String> val_48;
        丙且上东下丏丏丟下 val_49;
        CategoryNames val_50;
        var val_51;
        float val_52;
        float val_53;
        val_42 = 丕丝丟下丗丛一丕业;
        ShopNGUIController.业丑三丟丝丄三专丌 val_1 = null;
        val_43 = val_1;
        val_1 = new ShopNGUIController.业丑三丟丝丄三专丌();
        if(val_43 == null)
        {
            goto label_1;
        }
        
        val_44 = val_43;
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        mem[1152921539073610616] = this;
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        if(下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七() == null)
        {
            goto label_3;
        }
        
        System.Collections.Generic.List<BaseArmoryCell> val_3 = this.丌丛丕专丝丁万专丆();
        System.Predicate<丙且上东下丏丏丟下> val_4 = static_value_081D9E68;
        val_4 = new System.Predicate<丙且上东下丏丏丟下>(object:  val_1, method:  System.Boolean ShopNGUIController.业丑三丟丝丄三专丌::丌丗丟东且丛丄丑丏(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
        val_45 = this.万丕丛丝丑丗下丁丘.FindIndex(match:  val_4);
        int val_6 = val_3.Count;
        val_46 = null;
        val_46 = null;
        val_48 = ShopNGUIController.<>c.<>9__346_1;
        if(val_48 != null)
        {
            goto label_9;
        }
        
        val_49 = 1152921539073610608;
        goto label_20;
        label_1:
        mem[16] = 下丅丙一丂丗丅丝七;
        mem[24] = this;
        if(mem[16] != 0)
        {
            goto label_12;
        }
        
        goto label_13;
        label_3:
        val_50 = .下丅丙一丂丗丅丝七.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_50)) == false)
        {
                return;
        }
        
        this.丅上下万专丕丝丅丙(与丝丕与丙不与丗丆:  .下丅丙一丂丗丅丝七, 丒七丞丄丟且丂丆下:  0, 下丈丝丁丟下世丐丒:  false);
        return;
        label_20:
        System.Func<BaseArmoryCell, System.String> val_10 = null;
        val_48 = val_10;
        val_10 = new System.Func<BaseArmoryCell, System.String>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ShopNGUIController.<>c::丙丗丐下万与丂丄丁(BaseArmoryCell 丌丝万上丅丒一丈丘));
        val_44 = ;
        val_42 = val_42;
        ShopNGUIController.<>c.<>9__346_1 = val_48;
        val_43 = val_43;
        label_9:
        System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<BaseArmoryCell>(source:  System.Linq.Enumerable.OrderBy<BaseArmoryCell, System.String>(source:  this.firstGrid.GetComponentsInChildren<BaseArmoryCell>(includeInactive:  false), keySelector:  val_10));
        if(val_45 == 1)
        {
            goto label_21;
        }
        
        if(val_6 == 0)
        {
            goto label_22;
        }
        
        label_60:
        BaseArmoryCell val_16 = (val_45 == 1) ? (val_12) : (val_3).Item[val_45 - ((val_45 / val_6) * val_6)];
        if(val_42 == false)
        {
            goto label_48;
        }
        
        val_51 = this.gridScrollView.panel;
        if(val_51 == null)
        {
                val_51 = this.gridScrollView.GetComponent<UIPanel>();
            if(val_51 == null)
        {
            goto label_66;
        }
        
        }
        
        label_66:
        UnityEngine.Vector2 val_19 = val_51.GetViewSize();
        val_52 = val_19.y;
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 140000)
        {
            goto label_29;
        }
        
        val_45 = 1;
        goto label_30;
        label_21:
        System.Predicate<BaseArmoryCell> val_20 = new System.Predicate<BaseArmoryCell>(object:  val_1, method:  System.Boolean ShopNGUIController.业丑三丟丝丄三专丌::丁丟丏一丌丙丟丕丅(BaseArmoryCell 丌丝万上丅丒一丈丘));
        if(val_12 == null)
        {
            goto label_31;
        }
        
        int val_21 = val_12.FindIndex(match:  val_20);
        goto label_32;
        label_29:
        val_45 = 上丑三丁丄丛丁万丑.丂不丂丐丄丞丛丙丐();
        label_30:
        float val_42 = this.itemsGrid.cellHeight;
        UnityEngine.Vector2 val_23 = val_51.clipSoftness;
        int val_24 = val_45 / val_45;
        val_24 = val_24 + 1;
        val_42 = val_42 * (float)val_24;
        val_53 = val_23.y + val_42;
        int val_26 = this.万丕丛丝丑丗下丁丘.Count;
        int val_27 = val_26 / val_45;
        int val_28 = val_45 + 1;
        val_27 = val_26 - (val_27 * val_45);
        int val_29 = val_28 / val_45;
        int val_30 = this.万丕丛丝丑丗下丁丘.Count / val_45;
        var val_32 = (val_27 != 0) ? (val_30 + 1) : (val_30);
        if((((val_28 - (val_29 * val_45)) != 0) ? (val_29 + 1) : (val_29)) < val_32)
        {
                float val_43 = this.itemsGrid.cellHeight;
            float val_44 = 3f;
            val_43 = val_43 / val_44;
            val_53 = val_53 + val_43;
        }
        
        val_42 = this.gridScrollView;
        val_44 = val_53 - val_52;
        float val_34 = UnityEngine.Mathf.Max(a:  0f, b:  val_44);
        if(val_32 >= 10)
        {
                val_52 = 0.01f;
            var val_45 = 0;
            do
        {
            val_42 = this.gridScrollView;
            val_45 = val_45 + 1;
        }
        while(val_45 < (-1));
        
        }
        
        if(this.itemsWrapContainer.onStarted == null)
        {
                UIWrapContent.专丅七丘一丄丅丞丟 val_35 = null;
            val_42 = val_35;
            val_35 = new UIWrapContent.专丅七丘一丄丅丞丟(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void ShopNGUIController.业丑三丟丝丄三专丌::丛丁世东世丅丅丈东());
            this.itemsWrapContainer.onStarted = val_42;
        }
        
        label_48:
        val_50 = 1152921504848912384;
        if(val_16 == 0)
        {
            goto label_56;
        }
        
        val_42 = val_16.GetComponent<UIToggle>();
        if(val_42 == 0)
        {
            goto label_56;
        }
        
        val_50 = val_37.onChange;
        System.Collections.Generic.List<EventDelegate> val_39 = new System.Collections.Generic.List<EventDelegate>();
        if(val_42 == null)
        {
            goto label_58;
        }
        
        val_37.onChange = val_39;
        goto label_59;
        label_31:
        int val_40 = 0.FindIndex(match:  val_20);
        label_32:
        if(val_12.Count != 0)
        {
            goto label_60;
        }
        
        label_22:
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        return;
        label_58:
        val_37.onChange = val_39;
        label_59:
        if(丙丑丄丟万上丙丈丘 != false)
        {
                val_37.instantTween = true;
        }
        
        val_42.Set(丏业丟一东丂东丘丛:  true);
        val_37.onChange = val_50;
        val_37.instantTween = val_37.instantTween;
        label_56:
        if(val_43 != 0)
        {
                this.且丛丌丌七丈丝丒丈 = val_44;
            this.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        }
        else
        {
                this.且丛丌丌七丈丝丒丈 = .下丅丙一丂丗丅丝七;
            this.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        }
        
        this.丅上下万专丕丝丅丙(与丝丕与丙不与丗丆:  .下丅丙一丂丗丅丝七, 丒七丞丄丟且丂丆下:  0, 下丈丝丁丟下世丐丒:  false);
        this.丙丑丘业丕丗丗不丘();
        this.丟丕世丕丅下丑丛丟(下丅丙一丂丗丅丝七:  .下丅丙一丂丗丅丝七);
    }
    private static void 丏丝不万东东一上丂()
    {
        ShopNGUIController.丗七一与丆丅万丆丞(丙丘丈丈三丆丂丑且:  false);
    }
    private static void 七东丙丟丝丈丄且不()
    {
        ShopNGUIController.丗七一与丆丅万丆丞(丙丘丈丈三丆丂丑且:  true);
    }
    private static void 丗七一与丆丅万丆丞(bool 丙丘丈丈三丆丂丑且)
    {
        ShopNGUIController val_14;
        var val_15;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        ShopNGUIController val_21;
        var val_22;
        var val_23;
        System.Func<丙且上东下丏丏丟下, System.Boolean> val_25;
        var val_26;
        var val_27;
        var val_28;
        CategoryNames val_29;
        var val_30;
        ShopNGUIController val_31;
        CategoryNames val_32;
        丙且上东下丏丏丟下 val_33;
        var val_34;
        var val_35;
        val_14 = 丙丘丈丈三丆丂丑且;
        val_15 = null;
        val_15 = null;
        val_16 = 1152921504848912384;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
                return;
        }
        
        val_17 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if(null == 0)
        {
                return;
        }
        
        if((ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0) && (ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三() != null))
        {
                val_16 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三().业上丙丞丐丄丆丅七();
            if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  val_16)) != false)
        {
                ArmoryInfoScreenController.丄丞丁丈与业上丞丟.Close();
        }
        
        }
        
        val_19 = null;
        if(val_14 == false)
        {
            goto label_23;
        }
        
        val_20 = null;
        val_21 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
            goto label_26;
        }
        
        val_21 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_21 == null)
        {
            goto label_50;
        }
        
        label_26:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  ShopNGUIController.丏丙丅丕一丑丕丑丑.且丛丌丌七丈丝丒丈, 七丑业业丒七一丂丆:  false);
        return;
        label_23:
        val_22 = null;
        val_23 = null;
        val_23 = null;
        val_25 = ShopNGUIController.<>c.<>9__349_0;
        if(val_25 == null)
        {
                System.Func<丙且上东下丏丏丟下, System.Boolean> val_9 = null;
            val_25 = val_9;
            val_9 = new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::与丗丒丟丆丈专与上(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__349_0 = val_25;
        }
        
        if((System.Linq.Enumerable.Any<丙且上东下丏丏丟下>(source:  ShopNGUIController.丏丙丅丕一丑丕丑丑.万丕丛丝丑丗下丁丘, predicate:  val_9)) == false)
        {
            goto label_36;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = null;
        if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  业上丙丞丐丄丆丅七())) == false)
        {
            goto label_42;
        }
        
        val_28 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
            goto label_45;
        }
        
        val_29 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1564];
        val_29 = ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField;
        goto label_46;
        label_42:
        val_30 = null;
        val_31 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
            goto label_49;
        }
        
        val_31 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_31 == null)
        {
            goto label_50;
        }
        
        label_49:
        val_32 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1564];
        val_32 = ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField;
        val_33 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 800];
        val_33 = ShopNGUIController.丏丙丅丕一丑丕丑丑.且丛丌丌七丈丝丒丈;
        goto label_51;
        label_45:
        val_29 = 314;
        label_46:
        val_32 = val_29;
        val_33 = 0;
        label_51:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_32, 与丝丕与丙不与丗丆:  val_33, 七丑业业丒七一丂丆:  false);
        label_36:
        val_34 = null;
        val_34 = null;
        val_14 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if((ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField) != 30000)
        {
                return;
        }
        
        val_35 = null;
        val_35 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丙丑丘业丕丗丗不丘();
        return;
        label_50:
    }
    private void 丐丘丁丞三丙东丒丙(bool 丆丅丟丞上丈丂上上, ref bool 丅丈下丏世丌且丂万, ref bool 丂与一东丟丁一七丆, ref bool 上丛万丛丘不且丌上, ref bool 丁上世丟丙上丟业业, bool 丕丟丅与丆丘且与上, bool 丝丄丑丄丒丐丆不上)
    {
        var val_31;
        UIButton val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        val_31 = null;
        val_31 = null;
        bool val_2 = TempItemsController.上且丗丌东丟丂世丒.ContainsKey(key:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        bool val_6 = false;
        if(this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() != null)
        {
                val_32 = 1152921539074403456;
            val_33 = val_6;
            val_34 = 七丌丞万七万丁丐丙.丐丛万丗丅丒业丐丙(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 下不东三七丘万丌业: out  val_6, 丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌(), 业丟七丅丌三且与丛: out  0);
        }
        else
        {
                val_32 = 1152921539074403456;
            val_33 = 0;
            val_34 = 0;
        }
        
        val_35 = 0;
        int val_11 = 七丌丞万七万丁丐丙.丝丆丌丘丄丛与丆不(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌(), 丝丒丞丙丐一一丅三:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        RatingLeague val_13 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        val_36 = 0;
        if(((val_34 == 0) && (val_33 == 0)) && (this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() != null))
        {
                val_35 = 0;
            if((val_2 | (~(System.String.op_Inequality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  "cape_Custom")))) != false)
        {
                val_36 = 0;
        }
        else
        {
                bool val_18 = (val_11 <= val_13) ? 1 : 0;
        }
        
        }
        
        val_18 = val_18 & 丕丟丅与丆丘且与上;
        丅丈下丏世丌且丂万 = val_18;
        var val_19 = (val_34 == 0) ? 1 : 0;
        bool val_23 = (this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() == null) ? 1 : 0;
        val_23 = ((val_33 != 0) ? 1 : 0) | val_23;
        val_23 = val_19 | val_23;
        val_23 = val_23 | val_2;
        val_23 = 丕丟丅与丆丘且与上 & (~val_23);
        丂与一东丟丁一七丆 = val_23;
        丁上世丟丙上丟业业 = val_19 & ((val_11 > val_13) ? 1 : 0);
        if(val_33 != 0)
        {
                return;
        }
        
        val_32 = this.upgradeButton;
        if(丂与一东丟丁一七丆 != false)
        {
                if(ExpController.万上一丝丆且七丅丅() < (七丌丞万七万丁丐丙.丅上业丛丛丈丒丝丐(与丘东下丈东丛丂万:  WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()))))
        {
                val_37 = 0;
            if(val_32 != null)
        {
                return;
        }
        
            return;
        }
        
        }
        
        val_37 = (~val_2) & 1;
        if(val_32 != null)
        {
                return;
        }
    
    }
    private bool 世丕丝丞丘丑丌丆丒()
    {
        var val_5;
        var val_6;
        val_5 = this;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 25000)
        {
                val_5 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈();
            var val_4 = (val_5.Count == 0) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private bool 下丗万丟且三丌三且()
    {
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 30000)
        {
                return false;
        }
        
        return ShopNGUIController.丈丄丞与丏万万丗丌();
    }
    private static bool 丈丄丞与丏万万丗丌()
    {
        var val_7;
        System.Func<PGCompany.EggIncubatorProgress, System.Boolean> val_9;
        val_7 = null;
        val_7 = null;
        val_9 = ShopNGUIController.<>c.<>9__353_0;
        if(val_9 != null)
        {
                return (bool)((System.Linq.Enumerable.Count<PGCompany.EggIncubatorProgress>(source:  System.Linq.Enumerable.Where<PGCompany.EggIncubatorProgress>(source:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄(), predicate:  System.Func<PGCompany.EggIncubatorProgress, System.Boolean> val_3 = null))) == 0) ? 1 : 0;
        }
        
        val_9 = val_3;
        val_3 = new System.Func<PGCompany.EggIncubatorProgress, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丌七丁且上业丞一丁(PGCompany.EggIncubatorProgress 三丟东丕丄丄下下丑));
        ShopNGUIController.<>c.<>9__353_0 = val_9;
        return (bool)((System.Linq.Enumerable.Count<PGCompany.EggIncubatorProgress>(source:  System.Linq.Enumerable.Where<PGCompany.EggIncubatorProgress>(source:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄(), predicate:  val_3))) == 0) ? 1 : 0;
    }
    private bool 一丙专丘与万丏丐丑()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 230000)
        {
                val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  136, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            var val_4 = (val_6.Count == 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    private bool 丞丁丞丌丛上丆丐丘()
    {
        var val_4;
        var val_5;
        val_4 = this;
        if((this.<与一丐丟丗三一东丂>k__BackingField) == 220000)
        {
                val_4 = PGCompany.七丆丆丕丂丙丕丐丂.业且丆东丝下丗东丞();
            var val_3 = (val_4.Count == 0) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal void 丙丑丘业丕丗丗不丘()
    {
        string val_15;
        丙且上东下丏丏丟下 val_16;
        bool val_1 = this.世丕丝丞丘丑丌丆丒();
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 30000)
        {
            goto label_1;
        }
        
        var val_5 = ((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄().Count) == 0) ? 1 : 0;
        val_5 = val_1 | val_5;
        if(val_5 == false)
        {
            goto label_4;
        }
        
        goto label_7;
        label_1:
        if(val_1 == true)
        {
            goto label_7;
        }
        
        label_4:
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_7;
        }
        
        val_15 = 0;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_16;
        }
        
        val_15 = WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        if(val_15 != null)
        {
            goto label_16;
        }
        
        val_15 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        goto label_16;
        label_7:
        val_15 = 0;
        label_16:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField)) == false)
        {
            goto label_19;
        }
        
        val_16 = this.且丛丌丌七丈丝丒丈;
        if(val_16 == null)
        {
            goto label_20;
        }
        
        val_15 = val_16.业上丙丞丐丄丆丅七();
        label_19:
        val_16 = this.且丛丌丌七丈丝丒丈;
        if(val_16 == null)
        {
            goto label_22;
        }
        
        string val_13 = val_16.业上丙丞丐丄丆丅七();
        goto label_22;
        label_20:
        val_15 = 0;
        label_22:
        this.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  (val_1 != true) ? 0 : (val_16), 丂丒丒丆且丝丘丈丟:  val_15, 丘丐丝丟业丘丏东专:  this.propertiesContainer, 东丈丒三丞与业世一:  true, 丐丙丒丈丄不一丈与:  0, 丑丂丟丆丗丒丙业丕:  false, 丙丂丒一丗下丘下丟:  0, 丄丄丒丘丏一丗丆与:  0, 世七与业一七世丂丒:  0);
        this.丅丞丂丗一丂丗丕东();
        this.丆丕不丟丌丐丂世丛();
        this.三不丕丈与世丝丈丙();
        this.三丟业丝万专丞世丝();
        this.丂与下丅世丆丅丐三(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丗丒东丂万丂万丟:  this.且丛丌丌七丈丝丒丈);
    }
    private bool 与丑世丈丘丅一丝丗()
    {
        SquadController val_5;
        var val_6;
        var val_7;
        val_5 = this;
        if(this.丁丝丁上丂上专丐业 == true)
        {
                return false;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = SquadController.丄丘七三上丕世丞业;
        if(val_5 == 0)
        {
                return false;
        }
        
        val_7 = null;
        val_7 = null;
        val_5 = SquadController.丄丘七三上丕世丞业;
        if(val_5.inSquad == true)
        {
                return false;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                return false;
        }
        
        PGCompany.丗三万丁三丗上专丟 val_4 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if(val_4 != null)
        {
                return val_4.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220);
        }
        
        return val_4.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220);
    }
    internal static bool 丐丅丒丞不丘专丗下(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        string val_16;
        var val_17;
        val_16 = 下丅丙一丂丗丅丝七;
        丕丈丏丝丗下丟丅丂 val_12 = 0;
        if((val_16 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16.业上丙丞丐丄丆丅七())) == true))
        {
            goto label_19;
        }
        
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_16.业上丙丞丐丄丆丅七());
        if(val_4 == null)
        {
            goto label_7;
        }
        
        if(val_4.东七与与不丅丙上上() == true)
        {
            goto label_19;
        }
        
        val_17 = val_4;
        bool val_7 = val_17.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  ShopNGUIController.丛丐丛专丟丞万三七());
        goto label_22;
        label_7:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_16.丒万丕七专不丏丞丌())) == false)
        {
            goto label_19;
        }
        
        val_16 = val_16.业上丙丞丐丄丆丅七();
        if((丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  val_16, value: out  val_12)) == false)
        {
            goto label_19;
        }
        
        val_16 = val_12;
        if(val_16 == 0)
        {
            goto label_19;
        }
        
        val_17 = val_16;
        bool val_15 = val_17.上东丌丂丟不下丒业(专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
        goto label_22;
        label_19:
        val_17 = 1;
        label_22:
        val_17 = val_17 & 1;
        return (bool)val_17;
    }
    private static bool 不业丞且世且丝三丐()
    {
        var val_5;
        MainMenuController val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        val_6 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_6 == 0)
        {
            goto label_5;
        }
        
        val_7 = null;
        val_7 = null;
        val_6 = SquadController.丄丘七三上丕世丞业;
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        val_8 = 1;
        goto label_12;
        label_5:
        val_8 = 0;
        goto label_12;
        label_10:
        val_9 = null;
        val_9 = null;
        val_6 = SquadController.丄丘七三上丕世丞业;
        bool val_3 = val_6.inSquad;
        val_8 = val_3 ^ 1;
        label_12:
        val_3 = val_8;
        return (bool)val_3;
    }
    internal void 业丆上丐东丈丂丈丈(string 丆三丝丝一丕与丝丆, string 丂丒丒丆且丝丘丈丟, PropertiesArmoryItemContainer 丘丐丝丟业丘丏东专, bool 东丈丒三丞与业世一, 丙且上东下丏丏丟下 丐丙丒丈丄不一丈与, bool 丑丂丟丆丗丒丙业丕 = False, string 丙丂丒一丗下丘下丟, int 丄丄丒丘丏一丗丆与 = 0, int 世七与业一七世丂丒 = 0)
    {
    
    }
    private static bool 丒丅世丌丛丏丒东丟()
    {
        var val_4;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) != false)
        {
                val_4 = PixelTime.丝丗专上三不丄丑丑() >> 63;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 1;
        return (bool)val_4;
    }
    private string 专丗丄与丛丁丒丑万(CategoryNames 七丆丒与丗丌丄且丂)
    {
        string val_1;
        if(七丆丒与丗丌丄且丂 <= 180000)
        {
            goto label_1;
        }
        
        if(七丆丒与丗丌丄且丂 == 190000)
        {
            goto label_2;
        }
        
        if(七丆丒与丗丌丄且丂 == 200000)
        {
            goto label_3;
        }
        
        if(七丆丒与丗丌丄且丂 != 210000)
        {
                return "";
        }
        
        val_1 = "Key_7581";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1 = "Key_5531");
        label_1:
        if(七丆丒与丗丌丄且丂 == 160000)
        {
            goto label_8;
        }
        
        if(七丆丒与丗丌丄且丂 == 170000)
        {
            goto label_9;
        }
        
        if(七丆丒与丗丌丄且丂 != 180000)
        {
                return "";
        }
        
        val_1 = "Key_5532";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        label_2:
        val_1 = "Key_5533";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        label_3:
        val_1 = "Key_5609";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        label_8:
        val_1 = "Key_7583";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        label_9:
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
    }
    private UIButton 世丒丆丙万丙丛丒丌(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_3 = 0;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return (UIButton)丝三丁东丈丒世丅业.GetComponent<UIButton>();
        }
        
        return (UIButton)丝三丁东丈丒世丅业.GetComponent<UIButton>();
    }
    internal void 丅上下万专丕丝丅丙(丙且上东下丏丏丟下 与丝丕与丙不与丗丆, string 丒七丞丄丟且丂丆下, bool 下丈丝丁丟下世丐丒)
    {
        var val_11;
        System.String[] val_82;
        string val_83;
        var val_84;
        CategoryNames val_85;
        var val_86;
        var val_87;
        var val_88;
        var val_90;
        var val_91;
        string val_92;
        val_83 = 下丈丝丁丟下世丐丒;
        val_84 = 与丝丕与丙不与丗丆;
        if(val_84 == null)
        {
            goto label_1;
        }
        
        val_85 = 131072;
        val_85 = 2;
        if(val_84.丒万丕七专不丏丞丌() != 150000)
        {
                if(val_84.丒万丕七专不丏丞丌() != 140000)
        {
            goto label_3;
        }
        
        }
        
        val_82 = 1152921505264353280;
        val_83 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[val_84.业上丙丞丐丄丆丅七()];
        if(val_5.上七不丅丈丁不丛丝 == null)
        {
            goto label_8;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_8 = val_5.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.GetEnumerator();
        val_86 = 1152921539018830256;
        label_15:
        if((110153712 & 1) == 0)
        {
            goto label_13;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_11.GetAwaiter();
        new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_13._value._obj, 七丆丒与丗丌丄且丂:  val_13._value._obj.丙东专丂世丈丏丁丂());
        bool val_16 = (丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  val_84.业上丙丞丐丄丆丅七())) ^ 1;
        goto label_15;
        label_1:
        val_86 = 1;
        goto label_16;
        label_3:
        val_86 = 0;
        label_16:
        if((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  val_84.丒万丕七专不丏丞丌())) != false)
        {
                mem[1152921539076751680].三丞丕丝业东上丅且(丕丁下丌不万丅丞丛:  System.String.alignConst);
        }
        
        val_85 = val_84.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_85)) == false)
        {
            goto label_24;
        }
        
        if(val_84 != null)
        {
            goto label_59;
        }
        
        val_82 = 1152921505286238208;
        val_87 = null;
        val_87 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count < 1)
        {
            goto label_30;
        }
        
        val_88 = null;
        val_88 = null;
        三丈丟与丏丘丈丐万 val_24 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        val_83 = val_24.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        丙且上东下丏丏丟下 val_27 = null;
        val_84 = val_27;
        val_27 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_83, 七丆丒与丗丌丄且丂:  0.丒万丕七专不丏丞丌());
        if(val_84 != null)
        {
            goto label_59;
        }
        
        label_30:
        val_84 = 0;
        label_59:
        label_118:
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  val_84.业上丙丞丐丄丆丅七(), 丅专丕三且丑丘专下:  0);
        return;
        label_24:
        val_85 = 上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_84.丒万丕七专不丏丞丌());
        if(val_85 != false)
        {
                this.丝丘丐上丈丌业世丌(不丐上专丌丒丘丟丐:  val_84.业上丙丞丐丄丆丅七());
            return;
        }
        
        CategoryNames val_32 = val_84.丒万丕七专不丏丞丌();
        if(val_32 <= 170000)
        {
            goto label_45;
        }
        
        if(val_32 <= 200000)
        {
            goto label_46;
        }
        
        if(val_32 == 210000)
        {
            goto label_47;
        }
        
        if(val_32 == 240000)
        {
            goto label_48;
        }
        
        if(val_32 != 250000)
        {
                return;
        }
        
        val_82 = 1152921504624312320;
        val_85 = this;
        mem[1152921539076751680].丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  System.String.alignConst);
        mem[1152921539076751680].丟且丏业丈七七三与(丕丁下丌不万丅丞丛:  System.String.alignConst);
        val_83 = mem[1152921539076751680];
        val_83.丛丐三不七丆七丈世(丙业与丙丗丝不丈东:  true);
        this.丁丅丏丙丝一丑与东(丞丅上丏丂且下丅与:  val_84.业上丙丞丐丄丆丅七());
        return;
        label_45:
        if(val_32 <= 2000)
        {
            goto label_55;
        }
        
        if(val_32 == 25000)
        {
            goto label_56;
        }
        
        if(val_32 == 160000)
        {
            goto label_57;
        }
        
        if(val_32 != 170000)
        {
                return;
        }
        
        if(val_84 != null)
        {
            goto label_59;
        }
        
        string val_34 = WeaponManager.丐丙丅丒与不丘业丟();
        goto label_62;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_151;
        label_46:
        if(val_32 == 180000)
        {
            goto label_64;
        }
        
        if(val_32 == 190000)
        {
            goto label_65;
        }
        
        if(val_32 != 200000)
        {
                return;
        }
        
        this.一万业丏丛专丄丞丞(丅丗万丛丈不三丒丏:  val_84.业上丙丞丐丄丆丅七());
        return;
        label_55:
        if((val_32 - 6) > 6)
        {
            goto label_69;
        }
        
        var val_81 = 106013356 + ((val_32 - 6)) << 2;
        val_81 = val_81 + 106013356;
        goto (106013356 + ((val_32 - 6)) << 2 + 106013356);
        label_64:
        this.丏丄丑一丞丟一上丂(上丈专丌万丕丙万丘:  val_84.业上丙丞丐丄丆丅七(), 下丈丝丁丟下世丐丒:  val_83);
        return;
        label_48:
        val_83 = 丏丞丛上七丁丞丛万.丆丄三丐丌世下万丟(丝与丙丘丞且丄专丅:  val_84.业上丙丞丐丄丆丅七()).WeaponTag;
        val_85 = val_84.业上丙丞丐丄丆丅七();
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  val_83, 丅专丕三且丑丘专下:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_85));
        this.且一丞丗三一丄万丝(丙丂丒一丗下丘下丟:  val_84.业上丙丞丐丄丆丅七());
        return;
        label_57:
        val_83 = mem[1152921539076751680];
        val_83.上东丐三业丙丙丒丕(丙业与丙丗丝不丈东:  true);
        this.丗世专丅丘丗世丛丗(丁且业丁丞下丕丄不:  val_84.业上丙丞丐丄丆丅七());
        return;
        label_65:
        if(val_86 == 0)
        {
            goto label_83;
        }
        
        this.且丂丕丘不丂丏七三(丐丒丈丌与丈丏不上:  0.业上丙丞丐丄丆丅七());
        goto label_84;
        label_47:
        this.不丅七不丄丝丄丝丑(丄丄丄丕丂东丈丞丐:  val_84.业上丙丞丐丄丆丅七());
        return;
        label_56:
        this.丈丕上不且世专且七(上东丞世三世且丈丌:  val_84.业上丙丞丐丄丆丅七());
        return;
        label_69:
        if(val_32 != 2000)
        {
                return;
        }
        
        if(val_84 == null)
        {
            goto label_90;
        }
        
        if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  val_84.业上丙丞丐丄丆丅七())) == null)
        {
                return;
        }
        
        val_82 = val_51.ToWeapons;
        if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_82[0])) != null)
        {
            goto label_98;
        }
        
        return;
        label_83:
        this.且丂丕丘不丂丏七三(丐丒丈丌与丈丏不上:  val_84.业上丙丞丐丄丆丅七());
        label_84:
        if((System.String.op_Equality(a:  val_84.业上丙丞丐丄丆丅七(), b:  "EMPTY_ROYALE_AVATAR")) == false)
        {
                return;
        }
        
        label_62:
        label_98:
        string val_68 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  WeaponManager.七丄丄业丛万丄下上()).与不丞丑七丘丁丂丛();
        goto label_118;
        label_90:
        val_83 = 1152921505286238208;
        val_90 = null;
        val_90 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count >= 1)
        {
                val_91 = null;
            val_91 = null;
            三丈丟与丏丘丈丐万 val_72 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
            val_92 = val_72.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        }
        else
        {
                val_92 = 0;
        }
        
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  val_92, 丅专丕三且丑丘专下:  0);
        return;
        label_151:
        丙且上东下丏丏丟下 val_75 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  "Armor_Army_1", 七丆丒与丗丌丄且丂:  7);
        val_82 = null;
        val_85 = 131072;
        val_85 = 2;
        label_8:
        if(this.丒万丕七专不丏丞丌() != 140000)
        {
                return;
        }
        
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_78 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  丞东丑专丛丆丄丝世.世一丟丞三丝不丑丆<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(丑东与丅丐丅丂丞业:  null, 丌丒丝东丌下丕丁丅:  1));
        val_83 = val_78.Value.丙东专丂世丈丏丁丂();
        丙且上东下丏丏丟下 val_80 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_78.Value, 七丆丒与丗丌丄且丂:  val_83);
    }
    internal void 丈丕上不且世专且七(string 上东丞世三世且丈丌)
    {
        this.丝丂丗七丒丄丄东丐();
        this.丘丌丞丑业丑丗上丟.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  上东丞世三世且丈丌, 丐丕与丈丘丌东不丈:  1);
        this.专东丁丙丞丂东丝丁();
    }
    internal void 丏丄丑一丞丟一上丂(string 上丈专丌万丕丙万丘, bool 下丈丝丁丟下世丐丒)
    {
        bool val_5 = 下丈丝丁丟下世丐丒;
        this.丘丌丞丑业丑丗上丟.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  上丈专丌万丕丙万丘);
        val_5 = (三丐下丁丒丆丘下丄.丟万三丁丙丅东三三() | val_5) ^ 1;
        this.丘丌丞丑业丑丗上丟.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  val_5);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  上丈专丌万丕丙万丘)) == false)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.丟丌七上业丕丈东丌(丙业与丙丗丝不丈东:  true);
    }
    internal void 一万业丏丛专丄丞丞(string 丅丗万丛丈不三丒丏)
    {
        this.丘丌丞丑业丑丗上丟.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  丅丗万丛丈不三丒丏);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  丅丗万丛丈不三丒丏)) == false)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.丁与世丕丑业丒丗业(丙业与丙丗丝不丈东:  true);
    }
    private void 世丅且丘世丒上世一(PropertiesArmoryItemContainer 万三丂且丆三且丝且)
    {
        var val_16;
        System.Action<GameLoopSpriteOnButton> val_18;
        var val_19;
        var val_21;
        System.Action<GameLoopSpriteOnButton> val_23;
        if((万三丂且丆三且丝且.goToGatchaButton != 0) && (万三丂且丆三且丝且.goToGatchaButton.activeInHierarchy != false))
        {
                val_16 = null;
            val_16 = null;
            val_18 = ShopNGUIController.<>c.<>9__368_0;
            if(val_18 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_4 = null;
            val_18 = val_4;
            val_4 = new System.Action<GameLoopSpriteOnButton>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丝专丕七七丙丐万丂(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__368_0 = val_18;
        }
        
            GameLoopSpriteOnButton val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  万三丂且丆三且丝且.goToGatchaButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_4);
        }
        
        if((万三丂且丆三且丝且.goToEventRouletButton != 0) && (万三丂且丆三且丝且.goToEventRouletButton.activeInHierarchy != false))
        {
                val_19 = null;
            val_19 = null;
            val_18 = ShopNGUIController.<>c.<>9__368_1;
            if(val_18 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_9 = null;
            val_18 = val_9;
            val_9 = new System.Action<GameLoopSpriteOnButton>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::七一业丕三上丕丁丁(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__368_1 = val_18;
        }
        
            GameLoopSpriteOnButton val_10 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  万三丂且丆三且丝且.goToEventRouletButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_9);
        }
        
        if(万三丂且丆三且丝且.goToChestsEventButton == 0)
        {
                return;
        }
        
        if(万三丂且丆三且丝且.goToChestsEventButton.activeInHierarchy == false)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_23 = ShopNGUIController.<>c.<>9__368_2;
        if(val_23 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_14 = null;
            val_23 = val_14;
            val_14 = new System.Action<GameLoopSpriteOnButton>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丌丙且上丁上丌业专(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__368_2 = val_23;
        }
        
        GameLoopSpriteOnButton val_15 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  万三丂且丆三且丝且.goToChestsEventButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_14);
    }
    internal void 专世丘不一且丈丟东(string 与丙丕丛一丌丛丆丈, string 丒七丞丄丟且丂丆下, bool 下丈丝丁丟下世丐丒)
    {
        string val_8;
        var val_9;
        CharacterInterfaceV2 val_11;
        string val_12;
        val_8 = 丒七丞丄丟且丂丆下;
        val_9 = null;
        val_9 = null;
        string val_2 = ((与丙丕丛一丌丛丆丈.StartsWith(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) != true) ? "ShopStubForClanArmorLockedByDivision" : 与丙丕丛一丌丛丆丈;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
        {
                PGCompany.丙丕丑丑丆丂丗丗丟 val_4 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_2);
            val_8 = this.丘丌丞丑业丑丗上丟;
            if(val_4 != null)
        {
                string val_5 = val_4.业上丙丞丐丄丆丅七();
        }
        
            val_11 = this.丘丌丞丑业丑丗上丟;
            val_12 = (val_5 == null) ? (val_2) : (val_5);
        }
        else
        {
                val_11 = this.丘丌丞丑业丑丗上丟;
            val_12 = val_8;
        }
        
        this.丘丌丞丑业丑丗上丟.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  val_12);
        ShopNGUIController.丙丗丐丁丆不丈上丈(世丟丈丏丕万丝丆万:  mem[this.丘丌丞丑业丑丗上丟], 下丈丝丁丟下世丐丒:  下丈丝丁丟下世丐丒);
    }
    internal void 且三丆一丁丛丝专世(string 丟世丟丐且丐丟七上, bool 下丈丝丁丟下世丐丒)
    {
        bool val_4 = 下丈丝丁丟下世丐丒;
        this.丘丌丞丑业丑丗上丟.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  丟世丟丐且丐丟七上);
        val_4 = (三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅() | val_4) ^ 1;
        this.丘丌丞丑业丑丗上丟.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  val_4);
    }
    internal void 且丞丕丙七丙丏下丐(string 丈丐丕业下丟业丛一, bool 下丈丝丁丟下世丐丒)
    {
        bool val_4 = 下丈丝丁丟下世丐丒;
        this.丘丌丞丑业丑丗上丟.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  丈丐丕业下丟业丛一);
        val_4 = (三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七() | val_4) ^ 1;
        this.丘丌丞丑业丑丗上丟.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  val_4);
    }
    internal void 丈丝专万丑丏丟一世(string 且丘世丏丛丛万丟万)
    {
        var val_2;
        if(且丘世丏丛丛万丟万 != null)
        {
                val_2 = null;
            val_2 = null;
            this.丞丗丅丐上专世丈万(丂丒丘丅专丗丂世丛:  SkinsController.与业七丙三三万丕上.Item[且丘世丏丛丛万丟万]);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Skin id should not be null!");
    }
    internal void 丞丗丅丐上专世丈万(UnityEngine.Texture 丂丒丘丅专丗丂世丛)
    {
        this.丘丌丞丑业丑丗上丟.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  丂丒丘丅专丗丂世丛);
    }
    internal void 且丂丕丘不丂丏七三(string 丐丒丈丌与丈丏不上)
    {
        null = null;
        this.丘丌丞丑业丑丗上丟.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  ((丐丒丈丌与丈丏不上.StartsWith(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) != true) ? "ShopStubForClanAvatarLockedByDivision" : 丐丒丈丌与丈丏不上);
    }
    internal void 丕三丘丐丄一丅一丏(string 上世丘丐东万丐丆不, bool 下丈丝丁丟下世丐丒)
    {
        bool val_4 = 下丈丝丁丟下世丐丒;
        this.丘丌丞丑业丑丗上丟.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  上世丘丐东万丐丆不);
        val_4 = (三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏() | val_4) ^ 1;
        this.丘丌丞丑业丑丗上丟.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  val_4);
    }
    internal void 丗世专丅丘丗世丛丗(string 丁且业丁丞下丕丄不)
    {
        this.animationCoroutineRunner.StopAllCoroutines();
        this.丘丌丞丑业丑丗上丟.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  丁且业丁丞下丕丄不);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  丁且业丁丞下丕丄不)) == false)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.七丛下专丙丈万丈不(丙业与丙丗丝不丈东:  true);
    }
    internal void 不丅七不丄丝丄丝丑(string 丄丄丄丕丂东丈丞丐)
    {
        this.丘丌丞丑业丑丗上丟.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  丄丄丄丕丂东丈丞丐);
        if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  丄丄丄丕丂东丈丞丐)) == false)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.丐上七丒丂丁丏丆丑(丙业与丙丗丝不丈东:  true);
    }
    internal void 丁丅丏丙丝一丑与东(string 丞丅上丏丂且下丅与)
    {
        this.animationCoroutineRunner.StopAllCoroutines();
        this.丘丌丞丑业丑丗上丟.三丞丕丝业东上丅且(丕丁下丌不万丅丞丛:  丞丅上丏丂且下丅与);
    }
    internal void 丝丘丐上丈丌业世丌(string 不丐上专丌丒丘丟丐)
    {
        var val_4;
        this.animationCoroutineRunner.StopAllCoroutines();
        val_4 = null;
        val_4 = null;
        string val_2 = ((不丐上专丌丒丘丟丐.StartsWith(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) != true) ? "ShopStubForClanGadgetLockedByDivision" : 不丐上专丌丒丘丟丐;
        this.丘丌丞丑业丑丗上丟.丟且丏业丈七七三与(丕丁下丌不万丅丞丛:  val_2);
        if((丁下万丟且丟丛下业.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  val_2)) == false)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.丟业不七丝七丐一丗(丙业与丙丗丝不丈东:  true);
    }
    private CategoryNames 三与且丒丑丕丐丅不(BtnCategory 丐丕丙丏丙丛丛丂丒)
    {
        System.Collections.Generic.Dictionary<世丕丑七且丝七不不, CategoryNames> val_15;
        string val_16;
        string val_17;
        var val_18;
        var val_19;
        val_15 = this;
        val_16 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_16.丂世三丅一万东三三(不七丆万丁一丞七下:  220)) == false)
        {
            goto label_6;
        }
        
        val_16 = 丐丕丙丏丙丛丛丂丒.btnName;
        val_17 = 2.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.String.op_Equality(a:  val_16, b:  val_17)) == false)
        {
            goto label_6;
        }
        
        val_17 = 1152921505284374528;
        val_18 = 0;
        goto label_7;
        label_15:
        val_16 = 丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  this.不丐不丗丑七东丙东(七丆丒与丗丌丄且丂:  new CategoryNames[5][0]).gameObject, 丒丘丏上丙丟丑丕丈:  "Pressed", 丟丝七七一丁丏丏丙:  true).GetComponent<UIWidget>();
        val_18 = 1;
        label_7:
        if(val_18 < val_5.Length)
        {
            goto label_15;
        }
        
        goto label_16;
        label_6:
        if((丐丕丙丏丙丛丛丂丒 != 0) && (丐丕丙丏丙丛丛丂丒.btnName != null))
        {
                val_15 = this.且七丆不专世丂丒三;
            val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object val_12 = System.Enum.Parse(enumType:  val_16, value:  丐丕丙丏丙丛丛丂丒.btnName);
            CategoryNames val_13 = val_15.Item[null];
            return (CategoryNames)val_19;
        }
        
        UnityEngine.Debug.LogError(message:  "Categ_oryForSup_erCategory supe_rCategory == null || superC_ategory.btnName == null");
        val_19 = 0;
        return (CategoryNames)val_19;
        label_16:
        val_19 = 7;
        return (CategoryNames)val_19;
    }
    private System.Collections.Generic.IEnumerable<UnityEngine.Transform> 丂下且丏业丕东丛万()
    {
        System.Collections.Generic.IEnumerable<TSource> val_21;
        var val_22;
        System.Func<ShopCategoryButton, UnityEngine.Transform> val_24;
        val_21 = this.craftCategoriesGrid.transform.GetComponentsInChildren<ShopCategoryButton>(includeInactive:  true);
        if(val_21 == null)
        {
                ShopCategoryButton[] val_18 = new ShopCategoryButton[0];
            val_21 = val_18;
        }
        
        val_22 = null;
        val_22 = null;
        val_24 = ShopNGUIController.<>c.<>9__381_0;
        if(val_24 != null)
        {
                return System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  this.weaponCategoriesGrid.GetChildList(), second:  this.wearCategoriesGrid.GetChildList()), second:  this.gridCategoriesLeague.GetChildList()), second:  this.gadgetsGrid.GetChildList()), second:  this.miscCategoriesGrid.GetChildList()), second:  this.petsGrid.GetChildList(丈丙丝丑丁丅上丏上:  "NotCategoryButton")), second:  this.bestCategoriesGrid.GetChildList()), second:  this.battleRoyaleCategoriesGrid.GetChildList()), second:  System.Linq.Enumerable.Select<ShopCategoryButton, UnityEngine.Transform>(source:  val_18, selector:  System.Func<ShopCategoryButton, UnityEngine.Transform> val_19 = null));
        }
        
        val_24 = val_19;
        val_19 = new System.Func<ShopCategoryButton, UnityEngine.Transform>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Transform ShopNGUIController.<>c::丗丙丕一丄丐与与丆(ShopCategoryButton 丁七丈丑下丅丒丞东));
        ShopNGUIController.<>c.<>9__381_0 = val_24;
        return System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  System.Linq.Enumerable.Concat<UnityEngine.Transform>(first:  this.weaponCategoriesGrid.GetChildList(), second:  this.wearCategoriesGrid.GetChildList()), second:  this.gridCategoriesLeague.GetChildList()), second:  this.gadgetsGrid.GetChildList()), second:  this.miscCategoriesGrid.GetChildList()), second:  this.petsGrid.GetChildList(丈丙丝丑丁丅上丏上:  "NotCategoryButton")), second:  this.bestCategoriesGrid.GetChildList()), second:  this.battleRoyaleCategoriesGrid.GetChildList()), second:  System.Linq.Enumerable.Select<ShopCategoryButton, UnityEngine.Transform>(source:  val_18, selector:  val_19));
    }
    internal UnityEngine.Transform 不丐不丗丑七东丙东(CategoryNames 七丆丒与丗丌丄且丂)
    {
        .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
        return System.Linq.Enumerable.FirstOrDefault<UnityEngine.Transform>(source:  this.丂下且丏业丕东丛万(), predicate:  new System.Func<UnityEngine.Transform, System.Boolean>(object:  new ShopNGUIController.丕丐丏专丟丛七丈丌(), method:  System.Boolean ShopNGUIController.丕丐丏专丟丛七丈丌::丛丙丝丘下丘丑丈丝(UnityEngine.Transform 丁丂专业丁丅丅丈丙)));
    }
    private void 业与丝下丝下丅丏不(CategoryNames 七丆丒与丗丌丄且丂)
    {
        System.Collections.Generic.List<EventDelegate> val_8;
        UnityEngine.Object val_9;
        var val_10;
        bool val_11;
        val_9 = this.不丐不丗丑七东丙东(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = val_9.GetComponent<UIToggle>();
        if(val_9 == 0)
        {
            goto label_7;
        }
        
        val_8 = val_3.onChange;
        System.Collections.Generic.List<EventDelegate> val_5 = new System.Collections.Generic.List<EventDelegate>();
        if(val_9 == null)
        {
            goto label_9;
        }
        
        val_3.onChange = val_5;
        val_10 = val_9;
        val_11 = val_3.instantTween;
        mem2[0] = 1;
        val_9.value = true;
        val_3.onChange = val_8;
        goto label_10;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_9 = "ChooseC_ateg_oryAndSu_perCategory: uIToggle == null: category: "("ChooseC_ateg_oryAndSu_perCategory: uIToggle == null: category: ") + 七丆丒与丗丌丄且丂.ToString();
        UnityEngine.Debug.LogError(message:  val_9);
        return;
        label_9:
        val_3.onChange = val_5;
        val_10 = val_9;
        val_11 = val_3.instantTween;
        mem2[0] = 1;
        val_9.value = true;
        val_3.onChange = val_8;
        label_10:
        mem2[0] = val_11;
    }
    internal void 丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        CategoryNames val_1 = this.三与且丒丑丕丐丅不(丐丕丙丏丙丛丛丂丒:  丐丕丙丏丙丛丛丂丒);
        PGCompany.Analytics.一业丗丆世世上丁且.丑万丟丙专丆且专丂(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  3, 丄丙丑丕不业丂丒丂:  丐丕丙丏丙丛丛丂丒.btnName);
        this.业与丝下丝下丅丏不(七丆丒与丗丌丄且丂:  val_1);
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_1, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    internal void 且世丄丄丐丌丏丞世(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        object val_5 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  丒世丅业丝东下与丗.gameObject.name, ignoreCase:  true);
        ButtonClickSound.丁业上丏不丕三丗不();
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  1152921504628731904, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    internal void 丆丑丆丟七丑且丈三(CategoryNames 七丆丒与丗丌丄且丂, 丙且上东下丏丏丟下 与丝丕与丙不与丗丆, bool 七丑业业丒七一丂丆)
    {
        string val_21;
        var val_22;
        var val_23;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_3;
        }
        
        val_21 = 1.ToString();
        val_22 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_3:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_8;
        }
        
        val_21 = 2.ToString();
        val_22 = 2;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_8:
        if((上丑三丁丄丛丁万丑.上丅丏且丄七万三七(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_13;
        }
        
        val_21 = 3.ToString();
        val_22 = 3;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_13:
        if((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_18;
        }
        
        val_21 = 5.ToString();
        val_22 = 5;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_18:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_23;
        }
        
        val_21 = 4.ToString();
        val_22 = 4;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_23:
        if(七丆丒与丗丌丄且丂 != 8)
        {
            goto label_26;
        }
        
        val_21 = 2.ToString();
        val_22 = 2;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_26:
        if((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_31;
        }
        
        label_36:
        val_21 = 6.ToString();
        val_22 = 6;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_31:
        if(七丆丒与丗丌丄且丂 > 219999)
        {
            goto label_34;
        }
        
        if((七丆丒与丗丌丄且丂 == 140000) || (七丆丒与丗丌丄且丂 == 141000))
        {
            goto label_36;
        }
        
        goto label_39;
        label_34:
        if(七丆丒与丗丌丄且丂 != 220000)
        {
                if(七丆丒与丗丌丄且丂 != 230000)
        {
            goto label_39;
        }
        
        }
        
        val_21 = 8.ToString();
        val_22 = 8;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_55:
        this.superCategoriesButtonController.BtnClicked(丟专丛丏丝万丘丄丗:  val_21, 丌丝丌丁下丐丞丆一:  true);
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  七丆丒与丗丌丄且丂, 与丝丕与丙不与丗丆:  与丝丕与丙不与丗丆, 七丑业业丒七一丂丆:  七丑业业丒七一丂丆);
        this.业与丝下丝下丅丏不(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        this.丞丘丒与上丄丗上一(丌丝万上丅丒一丈丘:  0);
        return;
        label_39:
        if((上丑三丁丄丛丁万丑.七一丏丏且丙上丞业(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == false)
        {
            goto label_44;
        }
        
        string val_17 = 9.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_44:
        if(七丆丒与丗丌丄且丂 > 199999)
        {
            goto label_47;
        }
        
        if(七丆丒与丗丌丄且丂 == 160000)
        {
            goto label_50;
        }
        
        val_23 = 131072;
        val_23 = 2;
        goto label_49;
        label_47:
        if(七丆丒与丗丌丄且丂 == 210000)
        {
            goto label_50;
        }
        
        val_23 = 196608;
        val_23 = 3;
        label_49:
        if(七丆丒与丗丌丄且丂 != 200000)
        {
            goto label_51;
        }
        
        label_50:
        string val_18 = 7.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
        label_51:
        string val_19 = 0.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_55;
    }
    internal void 丆丂丅东业丂丕世丕(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七)
    {
        this.不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  下丅丙一丂丗丅丝七);
    }
    private bool 丈丆丟不丞丆丟丞不()
    {
        CategoryNames val_10;
        var val_11;
        PropertiesHideSHow val_12;
        val_10 = this.<与一丐丟丗三一东丂>k__BackingField;
        if(val_10 != 25000)
        {
            goto label_1;
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count) == 0)
        {
            goto label_6;
        }
        
        val_10 = this.<与一丐丟丗三一东丂>k__BackingField;
        label_1:
        if((val_10 == 30000) || (this.且丛丌丌七丈丝丒丈 == null))
        {
            goto label_6;
        }
        
        val_11 = this.丁世丁丌上丌丘与一(七丆丒与丗丌丄且丂:  this.丙丛丝丝丁不丁丗丘());
        goto label_7;
        label_6:
        val_11 = 0;
        label_7:
        val_12 = this.hideButton;
        if(val_12 != null)
        {
                var val_6 = (this.hideButton.isHidden == true) ? 1 : 0;
        }
        else
        {
                val_12 = this.hideButton;
        }
        
        val_12.SetState(丁丞三七丌且丐丁丝:  val_11 & 1);
        return (bool)((this.hideButton.isHidden == true) ? 1 : 0) ^ ((this.hideButton.isHidden == true) ? 1 : 0);
    }
    internal void 丌与专丗丂丄丌上不()
    {
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 25000)
        {
                return;
        }
        
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  168, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    private void 丆且一丄丑丘东丗丘()
    {
        if(((this.<与一丐丟丗三一东丂>k__BackingField) - 8) >= 2)
        {
                if((this.<与一丐丟丗三一东丂>k__BackingField) != 40000)
        {
                return;
        }
        
        }
        
        this.东东丏世丅三丗丅丟();
        this.丂丐世丑丝丅丝丁丑();
    }
    private void 三不丕丈与世丝丈丙()
    {
        var val_26;
        CategoryNames val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        CategoryNames val_32;
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_1;
        }
        
        CategoryNames val_1 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if((((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_1)) == true) || ((((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_1)) == true) || (val_1 == 8)) || (val_1 == 2000))) || ((val_1 == 25000) || ((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_1)) == true)))
        {
            goto label_39;
        }
        
        val_26 = null;
        val_26 = null;
        if((System.String.op_Inequality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  WeaponManager.丑与一世丛丄业丐丒)) == false)
        {
            goto label_39;
        }
        
        val_27 = this.<与一丐丟丗三一东丂>k__BackingField;
        if(val_27 != 25000)
        {
            goto label_18;
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count) == 0)
        {
            goto label_39;
        }
        
        val_27 = this.<与一丐丟丗三一东丂>k__BackingField;
        label_18:
        if((val_27 == 140000) || ((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  val_27)) == true))
        {
            goto label_39;
        }
        
        val_28 = 1;
        if(val_1 <= 199999)
        {
            goto label_26;
        }
        
        if(val_1 > 229999)
        {
            goto label_27;
        }
        
        if((val_1 == 200000) || (val_1 == 210000))
        {
            goto label_39;
        }
        
        val_29 = 196608;
        val_29 = 3;
        goto label_38;
        label_1:
        val_30 = 0;
        val_28 = 0;
        goto label_85;
        label_26:
        if(val_1 <= 169999)
        {
            goto label_32;
        }
        
        if((val_1 == 170000) || (val_1 == 180000))
        {
            goto label_39;
        }
        
        goto label_35;
        label_27:
        if((val_1 == 230000) || (val_1 == 250000))
        {
            goto label_39;
        }
        
        val_29 = 196608;
        val_29 = 3;
        goto label_38;
        label_32:
        if(val_1 == 30000)
        {
            goto label_39;
        }
        
        label_35:
        val_29 = 131072;
        val_29 = 2;
        label_38:
        if(val_1 != 160000)
        {
            goto label_40;
        }
        
        label_39:
        val_31 = null;
        val_31 = null;
        val_28 = 0;
        if((System.String.op_Equality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  WeaponManager.丑与一世丛丄业丐丒)) == false)
        {
            goto label_44;
        }
        
        label_40:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 30000)
        {
            goto label_46;
        }
        
        label_44:
        val_32 = this.<与一丐丟丗三一东丂>k__BackingField;
        if((((((((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField)) == true) || (val_32 == 140000)) || ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_1)) == true)) || ((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_1)) == true)) || ((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_1)) == true)) || ((val_1 == 8) || ((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  val_1)) == true))) || ((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  val_1)) == true))
        {
            goto label_84;
        }
        
        if(val_1 > 239999)
        {
            goto label_67;
        }
        
        if(val_1 == 220000)
        {
            goto label_84;
        }
        
        goto label_69;
        label_46:
        val_32 = this.<与一丐丟丗三一东丂>k__BackingField;
        label_84:
        label_85:
        if(this.infoButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.infoButton.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.hideButton != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hideButton.gameObject, 丏业丟一东丂东丘丛:  (val_32 != 30000) ? 1 : 0);
        }
        
        if(this.丈丆丟不丞丆丟丞不() == false)
        {
                return;
        }
        
        this.丆且一丄丑丘东丗丘();
        return;
        label_67:
        if(val_1 == 250000)
        {
            goto label_84;
        }
        
        label_69:
        if(val_1 == 240000)
        {
            goto label_84;
        }
        
        goto label_85;
    }
    private void 丂与下丅世丆丅丐三(CategoryNames 七丆丒与丗丌丄且丂, 丙且上东下丏丏丟下 专丗丒东丂万丂万丟)
    {
        string val_21;
        var val_22;
        var val_23;
        string val_24;
        var val_25;
        var val_26;
        val_21 = 专丗丒东丂万丂万丟;
        val_22 = 1;
        if((七丆丒与丗丌丄且丂 == 110000) || ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  七丆丒与丗丌丄且丂)) == true))
        {
            goto label_4;
        }
        
        if(七丆丒与丗丌丄且丂 == 170000)
        {
            goto label_9;
        }
        
        if(七丆丒与丗丌丄且丂 == 141000)
        {
            goto label_6;
        }
        
        if(七丆丒与丗丌丄且丂 != 135000)
        {
            goto label_14;
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 150000)
        {
            goto label_9;
        }
        
        goto label_14;
        label_6:
        if((val_21 == null) || ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_21.丒万丕七专不丏丞丌())) == false))
        {
            goto label_14;
        }
        
        label_9:
        val_23 = 1;
        goto label_16;
        label_14:
        var val_5 = (七丆丒与丗丌丄且丂 == 240000) ? 1 : 0;
        label_4:
        var val_6 = (val_5 != 0) ? 1 : 0;
        if(七丆丒与丗丌丄且丂 != 240000)
        {
            goto label_16;
        }
        
        PGCompany.世东三上七丂丌下丑 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_21 == null)
        {
            goto label_17;
        }
        
        if(val_7 != null)
        {
            goto label_41;
        }
        
        label_42:
        label_41:
        PGCompany.丟丝世万东万丆丟上 val_9 = val_7.一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_21.业上丙丞丐丄丆丅七());
        if(val_9 == null)
        {
            goto label_21;
        }
        
        PGCompany.丟丝东丈丐丙三下丛 val_11 = val_9.上专丗丏丛丁专丑丄().ItemWeapon;
        if(val_11 == null)
        {
            goto label_21;
        }
        
        val_24 = val_11.业上丙丞丐丄丆丅七();
        goto label_22;
        label_21:
        val_24 = 0;
        label_22:
        val_23 = ((val_5 != 0) ? 1 : 0) & ((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  val_24)) ^ 1);
        label_16:
        if(GameConnect.上丏丈七丘丁与丅丏() != true)
        {
                if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_30;
        }
        
        }
        
        val_25 = 0;
        goto label_31;
        label_30:
        val_25 = (~GameConnect.丌专丌万一下丕专上()) & 1;
        label_31:
        val_25 = val_25 & val_23;
        if(val_25 != false)
        {
                if(val_21 != null)
        {
                val_21 = val_21.业上丙丞丐丄丆丅七();
        }
        
            val_26 = (~(上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  val_21))) & 1;
        }
        else
        {
                val_26 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.shootButton, 丏业丟一东丂东丘丛:  false);
        return;
        label_17:
        if(val_7 != null)
        {
            goto label_41;
        }
        
        goto label_42;
    }
    public void HandleARButton()
    {
    
    }
    internal void 业不不且丐且与不与(丙且上东下丏丏丟下 世万丐专世丕业丟东)
    {
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  (世万丐专世丕业丟东 == 0) ? this.且丛丌丌七丈丝丒丈 : 世万丐专世丕业丟东, 七丑业业丒七一丂丆:  false);
        this.一丛丈上且不丟丑万();
    }
    internal void 一丘丂世丐丒丄丂一(CategoryNames 上三丂三丈丂丆丏丝, 丙且上东下丏丏丟下 与丝丕与丙不与丗丆, bool 七丑业业丒七一丂丆 = False)
    {
        bool val_256;
        CategoryNames val_257;
        ShopNGUIController val_258;
        ShopNGUIController.丄且与丕丏丏丑世东 val_259;
        var val_260;
        var val_261;
        var val_262;
        var val_263;
        var val_264;
        var val_265;
        string val_266;
        var val_267;
        var val_268;
        var val_269;
        string val_270;
        string val_271;
        bool val_272;
        string val_273;
        string val_274;
        var val_275;
        var val_276;
        string val_277;
        CategoryNames val_278;
        CategoryNames val_279;
        System.Collections.IEnumerator val_280;
        UnityEngine.Object val_281;
        var val_282;
        UIScrollView val_283;
        var val_284;
        var val_285;
        string val_286;
        丙且上东下丏丏丟下 val_287;
        string val_288;
        var val_291;
        System.Predicate<PGCompany.丗丟丄丈东丝丕丄世> val_293;
        string val_294;
        var val_295;
        System.Collections.Generic.IEnumerable<TSource> val_297;
        var val_298;
        System.Func<丙且上东下丏丏丟下, System.Boolean> val_300;
        var val_301;
        string val_303;
        string val_304;
        string val_306;
        var val_308;
        var val_309;
        val_256 = 七丑业业丒七一丂丆;
        val_257 = 上三丂三丈丂丆丏丝;
        val_258 = this;
        ShopNGUIController.丄且与丕丏丏丑世东 val_1 = null;
        val_259 = val_1;
        val_1 = new ShopNGUIController.丄且与丕丏丏丑世东();
        .与丝丕与丙不与丗丆 = 与丝丕与丙不与丗丆;
        if((val_257 == 230000) && (业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 1))
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                丐东不丅丂丂丅丙不.丑七不且上丗丁一世().丙业业一丆且一三专();
        }
        
        }
        
        if((业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 3) && (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true))
        {
                new ShopNGUIController.丕丄一丐且下丐不丙() = new ShopNGUIController.丕丄一丐且下丐不丙();
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>> val_10 = PGCompany.业丛丈丙丂且丌丑丙.丘业七丕丂丈丟不丅();
            System.Collections.Generic.KeyValuePair<CategoryNames, System.Single> val_11 = val_10.Item[0];
            .上世丗且七下丆专三 = val_10;
            val_260 = null;
            val_260 = null;
            System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_13 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new ShopNGUIController.丕丄一丐且下丐不丙(), method:  System.Boolean ShopNGUIController.丕丄一丐且下丐不丙::丗丏与丕丏七专上丂(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
            三丈丟与丏丘丈丐万 val_14 = System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与(), predicate:  null);
            if(val_14.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == val_257)
        {
                new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_14.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_14.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌());
            .与丝丕与丙不与丗丆 = new 丙且上东下丏丏丟下();
        }
        
        }
        
        this.bankShopView.丝一丅丆三东丂丞七();
        this.noItemLabel.gameObject.SetActive(value:  false);
        if(val_257 == 7)
        {
            goto label_31;
        }
        
        val_261 = 0;
        if(val_257 != 110000)
        {
            goto label_35;
        }
        
        Rilisoft.丕七东丗丁丐丂三下.丁丙丄丏丗丁专丙丂();
        val_261 = 0;
        goto label_35;
        label_31:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.showAltArmorButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.showAltArmorExoPilotButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.showAltArmorHalloween2018Button, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.showAltArmorPilgrim2018Button, 丏业丟一东丂东丘丛:  false);
        val_261 = 1;
        label_35:
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
        this.gridScrollView.currentMomentum = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        val_262 = null;
        val_262 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.armorLock, 丏业丟一东丂东丘丛:  val_261 & GameConnect.世丐丄三三上丅七三());
        this.且七丆不专世丂丒三.set_Item(key:  this.丙丛丝丝丁不丁丗丘(), value:  val_257);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponCategoriesGrid.gameObject, 丏业丟一东丂东丘丛:  上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_257));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.wearCategoriesGrid.gameObject, 丏业丟一东丂东丘丛:  ((val_257 == 8) ? 1 : 0) | (上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_257)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gridCategoriesLeague.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetsGrid.gameObject, 丏业丟一东丂东丘丛:  上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_257));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.miscCategoriesGrid.gameObject, 丏业丟一东丂东丘丛:  上丑三丁丄丛丁万丑.七一丏丏且丙上丞业(七丆丒与丗丌丄且丂:  val_257));
        val_263 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.battleRoyaleCategoriesGrid, 丏业丟一东丂东丘丛:  (val_257 == 210000) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetBlocker, 丏业丟一东丂东丘丛:  false);
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_67;
        }
        
        if((val_261 | (~(上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_257)))) == false)
        {
            goto label_70;
        }
        
        var val_43 = (val_257 == 2100) ? 1 : 0;
        goto label_72;
        label_67:
        val_264 = 0;
        goto label_72;
        label_70:
        val_264 = 1;
        label_72:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.wearBlocker, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.petsGrid.gameObject, 丏业丟一东丂东丘丛:  上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  val_257));
        val_265 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bestCategoriesGrid.gameObject, 丏业丟一东丂东丘丛:  (val_257 == 45000) ? 1 : 0);
        bool val_252 = 上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  val_257);
        val_252 = ((val_257 == 140000) ? 1 : 0) | val_252;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftCategoriesGrid.gameObject, 丏业丟一东丂东丘丛:  val_252 | ((val_257 == 220000) ? 1 : 0));
        if(val_257 > 140999)
        {
            goto label_88;
        }
        
        if(val_257 == 135000)
        {
            goto label_91;
        }
        
        goto label_90;
        label_88:
        if(val_257 == 220000)
        {
            goto label_91;
        }
        
        label_90:
        if(val_257 != 141000)
        {
            goto label_143;
        }
        
        label_91:
        val_266 = 1;
        val_267 = this.craftCategoriesGrid.GetComponentsInChildren<UnityEngine.Transform>(includeInactive:  true);
        if(val_267 == null)
        {
                val_266 = 0;
            val_267 = new UnityEngine.Transform[0];
        }
        
        val_268 = 0;
        val_269 = 0;
        goto label_95;
        label_142:
        UnityEngine.Transform val_253 = val_267[0];
        System.Globalization.CultureInfo val_58 = System.Globalization.CultureInfo.InvariantCulture;
        if(135000 != 0)
        {
                val_270 = 135000.ToString(provider:  val_58);
        }
        else
        {
                val_270 = 135000.ToString(provider:  val_58);
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.String.op_Equality(a:  val_253.name, b:  val_270)) == true)
        {
            goto label_102;
        }
        
        System.Globalization.CultureInfo val_63 = System.Globalization.CultureInfo.InvariantCulture;
        if(140000 != 0)
        {
                val_271 = 140000.ToString(provider:  val_63);
        }
        else
        {
                val_271 = 140000.ToString(provider:  val_63);
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.String.op_Equality(a:  val_253.name, b:  val_271)) == false)
        {
            goto label_114;
        }
        
        label_102:
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.threechests")) == false)
        {
            goto label_109;
        }
        
        val_272 = 1;
        if(val_253 != null)
        {
            goto label_112;
        }
        
        goto label_111;
        label_109:
        val_272 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.roulette");
        if(val_253 != null)
        {
            goto label_112;
        }
        
        label_111:
        label_112:
        if(val_272 != val_253.gameObject.activeSelf)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_253, 丏业丟一东丂东丘丛:  val_272);
            val_269 = 1;
        }
        
        label_114:
        System.Globalization.CultureInfo val_73 = System.Globalization.CultureInfo.InvariantCulture;
        if(141000 != 0)
        {
                val_273 = 141000.ToString(provider:  val_73);
        }
        else
        {
                val_273 = 141000.ToString(provider:  val_73);
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.String.op_Equality(a:  val_253.name, b:  val_273)) != false)
        {
                bool val_77 = 上丑三丁丄丛丁万丑.丏丒七七丑丄世七丗();
            if(val_77 ^ val_253.gameObject.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_253, 丏业丟一东丂东丘丛:  val_77);
            val_269 = 1;
        }
        
        }
        
        System.Globalization.CultureInfo val_83 = System.Globalization.CultureInfo.InvariantCulture;
        if(220000 != 0)
        {
                val_274 = 220000.ToString(provider:  val_83);
        }
        else
        {
                val_274 = 220000.ToString(provider:  val_83);
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_266 = val_274;
        if((System.String.op_Equality(a:  val_253.name, b:  val_266)) != false)
        {
                bool val_87 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.modules");
            val_266 = 0;
            if(val_87 ^ val_253.gameObject.activeSelf != false)
        {
                val_266 = val_87;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_253, 丏业丟一东丂东丘丛:  val_266);
            val_269 = 1;
        }
        
        }
        
        val_268 = 1;
        label_95:
        if(val_268 < val_56.Length)
        {
            goto label_142;
        }
        
        val_258 = val_258;
        val_257 = val_257;
        val_259 = val_259;
        val_256 = val_256;
        label_143:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gridScrollView.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083238384].gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083239144], 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083239232], 丏业丟一东丂东丘丛:  ((val_257 == 30000) ? 1 : 0) & (((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丏丏且丛丘三且东丕(东万丛丆丐丌丝丞不:  false).Count) == 0) ? 1 : 0));
        if(val_257 == 30000)
        {
                val_275 = null;
            val_276 = ShopNGUIController.丈丄丞与丏万万丗丌();
        }
        else
        {
                val_276 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083239256], 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083239264], 丏业丟一东丂东丘丛:  false);
        mem[1152921539083239916] = val_257;
        mem[1152921539083239912] = mem[1152921539083239916];
        if(((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  val_257)) != true) && (mem[1152921539083239916] != 180000))
        {
                if(mem[1152921539083239916] != 8)
        {
            goto label_163;
        }
        
        }
        
        mem[1152921539083238832].丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  0);
        label_163:
        if((val_256 != true) && (mem[1152921539083239916] == 7))
        {
                this.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083239208], 丏业丟一东丂东丘丛:  false);
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  mem[1152921539083239916])) != true)
        {
                if(mem[1152921539083238832].丝丑万专丕丕丒七一() == 0)
        {
                if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  mem[1152921539083239916])) == false)
        {
            goto label_178;
        }
        
        }
        
        }
        
        label_291:
        if((上丑三丁丄丛丁万丑.丗丟丝下上业上丘且(七丆丒与丗丌丄且丂:  mem[1152921539083239916])) != false)
        {
                mem[1152921539083238832].三丞丕丝业东上丅且(丕丁下丌不万丅丞丛:  System.String.alignConst);
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  mem[1152921539083239916])) == false)
        {
            goto label_185;
        }
        
        val_277 = WeaponManager.世东一丑丆丑与丆一()[mem[1152921539083239916]];
        if(.与丝丕与丙不与丗丆 != null)
        {
            goto label_564;
        }
        
        val_278 = mem[1152921539083239916];
        if(val_277 != null)
        {
            goto label_522;
        }
        
        val_278 = mem[1152921539083239916];
        val_277 = WeaponManager.丘丄丂与且世丕丅专(业三一丌丛丅下丗丁:  val_278, 丕丝丗丅丘上七丞万: out  0);
        if(val_278 != 0)
        {
            goto label_564;
        }
        
        label_522:
        label_273:
        丙且上东下丏丏丟下 val_110 = null;
        label_411:
        val_110 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_277, 七丆丒与丗丌丄且丂:  val_278);
        mem[1152921539083278560] = val_110;
        label_564:
        mem[1152921539083238832].丛丐三不七丆七丈世(丙业与丙丗丝不丈东:  false);
        this.不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  val_110);
        if((mem[1152921539083239916] != 25000) && (mem[1152921539083239916] != 30000))
        {
                if((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  mem[1152921539083239916])) == false)
        {
            goto label_202;
        }
        
        }
        
        label_276:
        this.丙丑丘业丕丗丗不丘();
        val_279 = mem[1152921539083239916];
        label_277:
        if(val_279 != 25000)
        {
            goto label_203;
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count) == 0)
        {
            goto label_206;
        }
        
        val_279 = mem[1152921539083239916];
        label_203:
        if(val_279 != 140000)
        {
            goto label_207;
        }
        
        label_206:
        this.丈下东丌丈丂七东下();
        label_207:
        val_280 = 1152921504848912384;
        val_281 = 0;
        if(mem[1152921539083239240] != val_281)
        {
                val_281 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[1152921539083239240], 丏业丟一东丂东丘丛:  false);
        }
        
        val_282 = null;
        val_282 = null;
        val_283 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 680];
        val_283 = ShopNGUIController.丏丙丅丕一丑丕丑丑.gridScrollView;
        if((val_283 & 1) == 0)
        {
                val_284 = null;
            val_284 = null;
            val_283 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 680];
            val_283 = ShopNGUIController.丏丙丅丕一丑丕丑丑.gridScrollView;
            ResetPosition();
        }
        
        this.丑丟丆下丛丒丁丄丒(东丕丅七丗丑丛下专:  mem[1152921539083239912], 专一与丘且上丟上且:  val_257);
        if((mem[1152921539083239056] != 0) && ((mem[1152921539083239056] + 64) != 0))
        {
                UIPanel val_118 = mem[1152921539083239056] + 64.GetComponent<UIPanel>();
            if(val_118 != 0)
        {
                val_118.SetDirty();
            val_118.Refresh();
        }
        
        }
        
        this.丟丙且丝万与不丑丐();
        val_285 = null;
        val_285 = null;
        if(ShopNGUIController.丆丂丘且下世上丆丁 == false)
        {
                return;
        }
        
        val_280 = this.上与丞东丞业丕丆七();
        UnityEngine.Coroutine val_121 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_280);
        return;
        label_185:
        if(mem[1152921539083239916] <= 45000)
        {
            goto label_241;
        }
        
        if(mem[1152921539083239916] <= 170000)
        {
            goto label_242;
        }
        
        if(mem[1152921539083239916] <= 220000)
        {
            goto label_243;
        }
        
        if(mem[1152921539083239916] == 230000)
        {
            goto label_321;
        }
        
        if(mem[1152921539083239916] != 250000)
        {
            goto label_564;
        }
        
        val_286 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丞丌且不丄专专且丈();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_286)) != false)
        {
                System.Collections.Generic.List<丙且上东下丏丏丟下> val_125 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true);
            if(val_125.Count != 0)
        {
                val_286 = val_125.Item[0].业上丙丞丐丄丆丅七();
        }
        
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_286)) == true)
        {
            goto label_564;
        }
        
        丙且上东下丏丏丟下 val_130 = null;
        val_287 = val_130;
        val_130 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_286, 七丆丒与丗丌丄且丂:  mem[1152921539083239916]);
        if(val_259 != 0)
        {
            goto label_482;
        }
        
        goto label_482;
        label_241:
        if(mem[1152921539083239916] <= 13500)
        {
            goto label_261;
        }
        
        if(mem[1152921539083239916] <= 30000)
        {
            goto label_262;
        }
        
        if((mem[1152921539083239916] != 35000) && (mem[1152921539083239916] != 40000))
        {
                if(mem[1152921539083239916] != 45000)
        {
            goto label_564;
        }
        
        }
        
        System.Collections.Generic.List<丙且上东下丏丏丟下> val_131 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true);
        if(mem[1152921539083278560] != 0)
        {
                if((val_131.Contains(item:  val_110)) == true)
        {
            goto label_564;
        }
        
        }
        
        丙且上东下丏丏丟下 val_133 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_131);
        if(val_133 == null)
        {
            goto label_272;
        }
        
        string val_134 = val_133.业上丙丞丐丄丆丅七();
        CategoryNames val_135 = val_133.丒万丕七专不丏丞丌();
        goto label_273;
        label_202:
        if(((mem[1152921539083239916] == 140000) || (mem[1152921539083239916] == 230000)) || (mem[1152921539083239916] == 220000))
        {
            goto label_276;
        }
        
        goto label_277;
        label_178:
        if((((mem[1152921539083239916] == 35000) || (mem[1152921539083239916] == 45000)) || (mem[1152921539083239916] == 250000)) || ((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  mem[1152921539083239916])) == true))
        {
            goto label_291;
        }
        
        val_288 = WeaponManager.世东一丑丆丑与丆一()[0];
        if(val_288 == null)
        {
                val_288 = WeaponManager.不丁丐丌丘丐七万专();
        }
        
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  val_288, 丅专丕三且丑丘专下:  0);
        goto label_291;
        label_242:
        if(mem[1152921539083239916] <= 140000)
        {
            goto label_292;
        }
        
        if(mem[1152921539083239916] == 141000)
        {
            goto label_293;
        }
        
        if(mem[1152921539083239916] == 160000)
        {
            goto label_294;
        }
        
        if((mem[1152921539083239916] != 170000) || (mem[1152921539083278560] != 0))
        {
            goto label_564;
        }
        
        string val_139 = WeaponManager.七丄丄业丛万丄下上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_139)) == false)
        {
            goto label_302;
        }
        
        string val_143 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true)).业上丙丞丐丄丆丅七();
        goto label_306;
        label_261:
        if(mem[1152921539083239916] <= 2000)
        {
            goto label_307;
        }
        
        if((mem[1152921539083239916] != 12500) && (mem[1152921539083239916] != 13000))
        {
                if(mem[1152921539083239916] != 13500)
        {
            goto label_564;
        }
        
        }
        
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        string val_145 = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
        goto label_387;
        label_243:
        if(mem[1152921539083239916] == 200000)
        {
            goto label_318;
        }
        
        if(mem[1152921539083239916] == 210000)
        {
            goto label_319;
        }
        
        if(mem[1152921539083239916] != 220000)
        {
            goto label_564;
        }
        
        if(mem[1152921539083239912] != mem[1152921539083239916])
        {
                val_291 = null;
            val_291 = null;
            val_293 = ShopNGUIController.<>c.<>9__395_3;
            if(val_293 == null)
        {
                System.Predicate<PGCompany.丗丟丄丈东丝丕丄世> val_148 = null;
            val_293 = val_148;
            val_148 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丐丞上丌下丘七丆丗(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__395_3 = val_293;
        }
        
            mem[1152921539083239920] = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  126, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}).FindAll(match:  val_148);
        }
        
        label_321:
        this.bankShopView.丝一丅丆三东丂丞七();
        System.Collections.Generic.List<丙且上东下丏丏丟下> val_150 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true);
        if(mem[1152921539083278560] == 0)
        {
            goto label_333;
        }
        
        label_483:
        mem[1152921539083278560] = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_150, predicate:  new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  val_1, method:  System.Boolean ShopNGUIController.丄且与丕丏丏丑世东::丑丟丁丝丅丘不世丙(丙且上东下丏丏丟下 三丟东丕丄丄下下丑)));
        if(val_150 != null)
        {
            goto label_335;
        }
        
        goto label_335;
        label_262:
        if(mem[1152921539083239916] == 25000)
        {
            goto label_336;
        }
        
        if((mem[1152921539083239916] != 30000) || (mem[1152921539083278560] != 0))
        {
            goto label_564;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<PGCompany.EggIncubatorProgress>(source:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丘七上丈丘丙不丈丆())) == null)
        {
            goto label_341;
        }
        
        label_527:
        val_287 = new 丙且上东下丏丏丟下();
        val_287 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_155.Id.ToString(), 七丆丒与丗丌丄且丂:  48);
        goto label_482;
        label_292:
        if(mem[1152921539083239916] == 135000)
        {
            goto label_343;
        }
        
        if((mem[1152921539083239916] != 140000) || (mem[1152921539083278560] != 0))
        {
            goto label_564;
        }
        
        val_294 = 丙丞丟丑丗丅专丈一.丁丑与丛丒不东专丞().Item[0];
        val_287 = new 丙且上东下丏丏丟下();
        val_295 = 131072;
        val_295 = 2;
        goto label_548;
        label_307:
        if((mem[1152921539083239916] - 6) > 6)
        {
            goto label_351;
        }
        
        var val_254 = 106013312 + ((上三丂三丈丂丆丏丝 - 6)) << 2;
        val_254 = val_254 + 106013312;
        goto (106013312 + ((上三丂三丈丂丆丏丝 - 6)) << 2 + 106013312);
        label_336:
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        string val_162 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏();
        val_294 = val_162;
        if((System.String.IsNullOrEmpty(value:  val_162)) == false)
        {
            goto label_367;
        }
        
        System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛> val_166 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>>(source:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈());
        if(val_166.Value == 0)
        {
            goto label_363;
        }
        
        val_294 = 丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Item[val_166.Value.丙东专丂世丈丏丁丂()];
        goto label_367;
        label_343:
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        val_297 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true);
        val_298 = null;
        val_298 = null;
        val_300 = ShopNGUIController.<>c.<>9__395_1;
        if(val_300 != null)
        {
            goto label_394;
        }
        
        System.Func<丙且上东下丏丏丟下, System.Boolean> val_171 = null;
        val_300 = val_171;
        val_171 = new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丑丈丘丐七丟丟上业(丙且上东下丏丏丟下 丑丝丏丂且不下一东));
        ShopNGUIController.<>c.<>9__395_1 = val_300;
        goto label_394;
        label_294:
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        string val_172 = 丛且丗丌丏下七下丈.万丗丐不不三丁且丟();
        goto label_387;
        label_319:
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        string val_173 = 丛且丗丌丏下七下丈.丗丘丌丘七丏丝下七();
        goto label_387;
        label_293:
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        val_297 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true);
        val_301 = null;
        val_301 = null;
        val_300 = ShopNGUIController.<>c.<>9__395_2;
        if(val_300 == null)
        {
                System.Func<丙且上东下丏丏丟下, System.Boolean> val_175 = null;
            val_300 = val_175;
            val_175 = new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丌丙七丄下万丑三一(丙且上东下丏丏丟下 丑丝丏丂且不下一东));
            ShopNGUIController.<>c.<>9__395_2 = val_300;
        }
        
        label_394:
        mem[1152921539083278560] = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_297, predicate:  val_175);
        goto label_564;
        label_318:
        if(mem[1152921539083278560] != 0)
        {
            goto label_564;
        }
        
        label_387:
        val_303 = 丛且丗丌丏下七下丈.七且丐丅与丝丙一丄();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_303)) != false)
        {
                val_303 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  mem[1152921539083239916], 丙丑丄与丅丐一不东:  true)).业上丙丞丐丄丆丅七();
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_303)) == true)
        {
            goto label_564;
        }
        
        goto label_411;
        label_333:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        .上丟丙丙丞丑丑丝丄 = 6.ToString();
        丙且上东下丏丏丟下 val_186 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_150, predicate:  new System.Func<丙且上东下丏丏丟下, System.Boolean>(object:  new ShopNGUIController.专丌丆与七上丛丐下(), method:  System.Boolean ShopNGUIController.专丌丆与七上丛丐下::丈一丟丒丞业丛七业(丙且上东下丏丏丟下 三丟东丕丄丄下下丑)));
        mem[1152921539083278560] = val_186;
        if(val_186 == null)
        {
            goto label_415;
        }
        
        label_335:
        if(val_150.Count <= 0)
        {
                this.noItemLabel.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "No_items_" + mem[1152921539083239916]);
            this.noItemLabel.gameObject.SetActive(value:  true);
        }
        
        if(mem[1152921539083239916] != 220000)
        {
            goto label_421;
        }
        
        PGCompany.万丞丘与丕丞下万丌.世世丘丅三丁丟专丈();
        goto label_564;
        label_421:
        PGCompany.万丞丘与丕丞下万丌.丛且不丏三丁丘丁丙();
        goto label_564;
        label_272:
        val_304 = WeaponManager.世东一丑丆丑与丆一()[0];
        if(val_304 == null)
        {
                val_304 = WeaponManager.不丁丐丌丘丐七万专();
        }
        
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  val_304, 丅专丕三且丑丘专下:  0);
        goto label_564;
        label_351:
        if((mem[1152921539083239916] != 2000) || (mem[1152921539083278560] != 0))
        {
            goto label_564;
        }
        
        val_294 = System.Linq.Enumerable.FirstOrDefault<System.String>(source:  Rilisoft.上丑业三丆丆丅丕三.丈丅丆专丛丆丆丏丐());
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_294)) == true)
        {
            goto label_564;
        }
        
        val_287 = new 丙且上东下丏丏丟下();
        val_295 = 2000;
        goto label_548;
        label_543:
        mem[1152921539083278560] = ;
        goto label_564;
        label_415:
        丙且上东下丏丏丟下 val_212 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_150);
        goto label_483;
        label_302:
        label_306:
        val_294 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_139).与不丞丑七丘丁丂丛();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_294)) == true)
        {
            goto label_564;
        }
        
        val_287 = new 丙且上东下丏丏丟下();
        val_295 = 2;
        goto label_548;
        label_341:
        System.Collections.Generic.List<丙且上东下丏丏丟下> val_216 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  48, 丙丑丄与丅丐一不东:  true);
        if(val_216 == null)
        {
            goto label_498;
        }
        
        丙且上东下丏丏丟下 val_217 = System.Linq.Enumerable.FirstOrDefault<丙且上东下丏丏丟下>(source:  val_216);
        if(val_217 == null)
        {
            goto label_498;
        }
        
        val_306 = val_217.业上丙丞丐丄丆丅七();
        goto label_499;
        label_498:
        val_306 = 0;
        label_499:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_306)) == true)
        {
            goto label_564;
        }
        
        if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  val_306)) != null)
        {
            goto label_527;
        }
        
        goto label_564;
        label_540:
        val_309 = public 丙且上东下丏丏丟下 System.Collections.Generic.List<丙且上东下丏丏丟下>::get_Item(int index);
        if( >= Count)
        {
            goto label_533;
        }
        
        label_541:
        if(Item[0] != null)
        {
                if((System.String.op_Equality(a:  Item[0].业上丙丞丐丄丆丅七(), b:  业上丙丞丐丄丆丅七())) == true)
        {
            goto label_564;
        }
        
        }
        
        val_308 = 1;
        if( == null)
        {
            goto label_540;
        }
        
        val_309 = public 丙且上东下丏丏丟下 System.Collections.Generic.List<丙且上东下丏丏丟下>::get_Item(int index);
        if(val_308 < Count)
        {
            goto label_541;
        }
        
        label_533:
        丙且上东下丏丏丟下 val_244 = Item[0];
        if(val_259 != 0)
        {
            goto label_543;
        }
        
        goto label_543;
        label_363:
        val_294 = 0;
        label_367:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_294)) == true)
        {
            goto label_564;
        }
        
        val_287 = new 丙且上东下丏丏丟下();
        val_295 = 25000;
        label_548:
        val_287 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_294, 七丆丒与丗丌丄且丂:  168);
        label_482:
        mem[1152921539083278560] = val_287;
        goto label_564;
    }
    private System.Collections.IEnumerator 上与丞东丞业丕丆七()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ShopNGUIController.与上且丟且丈丞丞丟(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丆丕不丟丌丐丂世丛()
    {
        var val_9;
        var val_10;
        var val_11;
        if((this.且丛丌丌七丈丝丒丈 != null) && ((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false))
        {
                var val_4 = (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 7) ? 1 : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.propertiesContainer.nonArmorWearProperties, 丏业丟一东丂东丘丛:  false);
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                var val_6 = (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 8) ? 1 : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.propertiesContainer.skinProperties, 丏业丟一东丂东丘丛:  false);
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                var val_8 = (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 2000) ? 1 : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.propertiesContainer.leagueSkinProperties, 丏业丟一东丂东丘丛:  false);
    }
    private void 丝丐丞丘且上丒上丂(string 世丐丗专丅三丝丑丆)
    {
        var val_2 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 25000)
        {
                return;
        }
        
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  168, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    internal void 丐不专丗丞不不丑丏()
    {
        var val_13;
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this.showArmorButton, 丏业丟一东丂东丘丛:  三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁());
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this.showMaskButton, 丏业丟一东丂东丘丛:  三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅());
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this.showHatButton, 丏业丟一东丂东丘丛:  三丐下丁丒丆丘下丄.丟万三丁丙丅东三三());
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this.showCapeButton, 丏业丟一东丂东丘丛:  三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七());
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this.showBootsButton, 丏业丟一东丂东丘丛:  三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏());
        val_13 = null;
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this.showAllWeaponSkinsToggle, 丏业丟一东丂东丘丛:  (~ShopNGUIController.一丗丐丈丁丙不且且()) & 1);
    }
    internal static void 万丟丂与业丟丘一一()
    {
        var val_5;
        ShopNGUIController val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        val_6 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_6 != 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(ShopNGUIController.上专丕丐东丙丛丘上 != null)
        {
                return;
        }
        
        val_6 = CoroutineRunner.Instance;
        ShopNGUIController.上专丕丐东丙丛丘上 = val_6.StartCoroutine(routine:  ShopNGUIController.丑丘且丞丈万丂万专());
    }
    private static System.Collections.IEnumerator 丑丘且丞丈万丂万专()
    {
        return (System.Collections.IEnumerator)new ShopNGUIController.一丅世丅丟世丌丆丗(丗丏丅丕丆世丁专丟:  0);
    }
    internal static void 上万丐丞丂丐丌丛丆(bool 丁丅丟丒丙丐丅与丂 = False)
    {
        var val_9;
        var val_10;
        ShopNGUIController val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        if((((东丗上丁下业一丂丂.丆丒一专且业七丟丈 != true) && (GameConnect.万不丒丌丙万丗东不() != true)) && (GameConnect.与丂丝丟丟三丑丝万() != true)) && (GameConnect.一与东丝万上三丆丏() != true))
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_18;
        }
        
        }
        
        }
        
        label_33:
        val_10 = null;
        val_10 = null;
        val_11 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_11 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = ShopNGUIController.丏丙丅丕一丑丕丑丑.gameObject;
        UnityEngine.Object.Destroy(obj:  val_11);
        ShopNGUIController.丏丙丅丕一丑丕丑丑 = 0;
        return;
        label_18:
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
            goto label_33;
        }
        
        if(丁丅丟丒丙丐丅与丂 == false)
        {
                return;
        }
        
        goto label_33;
    }
    private void 世下丒东业丌专丌东(ShopCategoryButton 下丈万丌且与丌万丁)
    {
        this.且世丄丄丐丌丏丞世(丒世丅业丝东下与丗:  下丈万丌且与丌万丁.GetComponent<UIToggle>());
        PGCompany.Analytics.一业丗丆世世上丁且.丑万丟丙专丆且专丂(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  2, 丄丙丑丕不业丂丒丂:  下丈万丌且与丌万丁.name);
    }
    private void 七丝丏丙丘丕丝丆丛(BaseArmoryCell 丌丝万上丅丒一丈丘)
    {
        string val_24;
        if((丌丝万上丅丒一丈丘.Category == 240000) && ((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丌丝万上丅丒一丈丘.ItemId)) != false))
        {
                PGCompany.丟丝世万东万丆丟上 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丌丝万上丅丒一丈丘.ItemId);
            if((Progress.七七世万专丕丁上业.丙丌丒丌丞且丌专丂().万万上上丕七丑丙丐(专丙丐世与丐下不丑:  val_7.业东丅东丌上丗丑不())) != true)
        {
                int[] val_12 = new int[1];
            val_12[0] = val_7.业东丅东丌上丗丑不();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丑丈丂丈丝丛丂一下(丅专丐丝丒丕丐业丘:  val_12);
        }
        
            if((丆丞丐三与丞专丈丌.丗丅丁一丁丁不万丞(丞一丁业丄一一业且:  val_7.业上丙丞丐丄丆丅七())) != false)
        {
                丆丞丐三与丞专丈丌.丏丄下丈丝丅丁万世(丞一丁业丄一一业且:  val_7.业上丙丞丐丄丆丅七());
        }
        
        }
        
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if((System.String.op_Inequality(a:  丌丝万上丅丒一丈丘.ItemId, b:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
                return;
        }
        
        }
        
        if(丌丝万上丅丒一丈丘 != null)
        {
                val_24 = 丌丝万上丅丒一丈丘.ItemId;
        }
        else
        {
                val_24 = 0.ItemId;
        }
        
        this.丆与丅世下一丟不丏(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_24, 七丆丒与丗丌丄且丂:  丌丝万上丅丒一丈丘.Category), 丕丝丟下丗丛一丕业:  false, 丙丑丄丟万上丙丈丘:  false);
    }
    public void CellClicked(BaseArmoryCell 丌丝万上丅丒一丈丘)
    {
        string val_33;
        CategoryNames val_34;
        CategoryNames val_35;
        var val_36;
        CategoryNames val_37;
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        val_33 = 丌丝万上丅丒一丈丘.ItemId;
        if((System.String.op_Equality(a:  val_33, b:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
                return;
        }
        
        if(丌丝万上丅丒一丈丘 != null)
        {
                if(16843334 != 0)
        {
                return;
        }
        
        }
        
        if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  丌丝万上丅丒一丈丘.ItemId)) == 2)
        {
                return;
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) != false)
        {
                if((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == 2)
        {
                return;
        }
        
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 7)
        {
                if((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == 2)
        {
                return;
        }
        
            PGCompany.三东丏不丗世丅丌丄 val_14 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
            val_33 = BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  val_14.业东丅东丌上丗丑不());
            丞丂丘丒丟丞丑下丄 val_20 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_33 != false)
        {
                if(val_20 == null)
        {
                return;
        }
        
            if(val_20.世丝丌一且丝专丑丛() < (BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_14.业东丅东丌上丗丑不())))
        {
                return;
        }
        
        }
        
        }
        
        val_34 = this.<与一丐丟丗三一东丂>k__BackingField;
        if(val_34 == 240000)
        {
                this.OpenWeaponSkinArmoryInfoScreen(丙丂丒一丗下丘下丟:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
            return;
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == true)
        {
            goto label_40;
        }
        
        val_35 = this.<与一丐丟丗三一东丂>k__BackingField;
        if(val_35 != 45000)
        {
            goto label_41;
        }
        
        label_40:
        val_36 = null;
        val_36 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_47;
        }
        
        val_35 = this.<与一丐丟丗三一东丂>k__BackingField;
        label_41:
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  val_35)) == false)
        {
            goto label_61;
        }
        
        label_47:
        val_37 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  val_37)) == false)
        {
                return;
        }
        
        if((丛且丗丌丏下七下丈.丘东三丈丞丆丈丒丞(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) > ExperienceController.丞丞丘业东丙丏七丌())
        {
                return;
        }
        
        label_61:
        this.HandleInfoButton();
    }
    private void 丙丐丏丝丙丝丐丑丛(BaseArmoryCell 丌丝万上丅丒一丈丘)
    {
        if((System.String.op_Equality(a:  丌丝万上丅丒一丈丘.ItemId, b:  "cape_Custom")) == false)
        {
            goto label_2;
        }
        
        if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  9).Contains(item:  "cape_Custom")) == true)
        {
            goto label_9;
        }
        
        return;
        label_2:
        if((System.String.op_Equality(a:  丌丝万上丅丒一丈丘.ItemId, b:  "CustomSkinID")) != false)
        {
                if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  26)) == false)
        {
                return;
        }
        
            if(this.与丑世丈丘丅一丝丗() == false)
        {
                return;
        }
        
            this.HandleCreateButton();
            return;
        }
        
        label_9:
        if(this.与丑世丈丘丅一丝丗() == false)
        {
                return;
        }
        
        this.HandleEditButton();
    }
    private void Awake()
    {
        System.EventHandler val_47;
        var val_48;
        var val_49;
        PGCompany.丞丁丌不丌不丄丆丟.专丐世三丁丗丌丙丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress, System.Int32>(object:  this, method:  System.Void ShopNGUIController::一丈丙丕东丄丒不与(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, int 丏丂丅丟上丁东丞丂)));
        Rilisoft.EggsManager.丟丁丞丈丕丏东丅丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void ShopNGUIController::世一下世丒一下丈与(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)));
        Rilisoft.PetsManager.丂丅丌一万丞丕不东(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ShopNGUIController::丝丐丞丘且上丒上丂(string 世丐丗专丅三丝丑丆)));
        Rilisoft.丗下丙丅且丐丞丙世.世丗东丈业上万且丒(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void ShopNGUIController::丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
        ShopCategoryButton.丐丝丟上丕丛一丝三(丙业与丙丗丝不丈东:  new System.Action<ShopCategoryButton>(object:  this, method:  System.Void ShopNGUIController::世下丒东业丌专丌东(ShopCategoryButton 下丈万丌且与丌万丁)));
        BaseArmoryCell.丑一丄丐丂世丕万世(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void ShopNGUIController::七丝丏丙丘丕丝丆丛(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        BaseArmoryCell.七一丕丁丅且专一丂(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  public System.Void ShopNGUIController::CellClicked(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        BaseArmoryCell.丛丆丝一东一丙专不(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void ShopNGUIController::丙丐丏丝丙丝丐丑丛(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        PGCompany.GameplayLoop.丕与七丐丞丕丑业世.丄专丐丒丟专一丞丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丙丁丗专丕丙丅业上()));
        专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丏上丛丐且丒世丆丕()));
        Rilisoft.EggsManager.丞丈丅世丆丐丛丕丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void ShopNGUIController::丌业七丟丆东不丅三(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟)));
        Rilisoft.EggsManager.七丙丏丏东业丄丝专(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<System.String, System.Int32>, PGCompany.丝不丅丗丄丄与丌丘>(object:  this, method:  System.Void ShopNGUIController::与丆丕丙下丑丐丛专(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, System.Collections.Generic.Dictionary<string, int> 丏丂丅丟上丁东丞丂, PGCompany.丝不丅丗丄丄与丌丘 东丏上丄丙丘丘丂三)));
        PetRenameWindov.丁下专丘万丂丄世丟(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丒丗丅丛丕不万丂>(object:  this, method:  System.Void ShopNGUIController::丙丝一丞世与世丈丆(PGCompany.世丒丗丅丛丕不万丂 上东丞世三世且丈丌)));
        System.Collections.Generic.List<System.Action<BtnCategory>> val_15 = new System.Collections.Generic.List<System.Action<BtnCategory>>();
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        val_15.Add(item:  new System.Action<BtnCategory>(object:  this, method:  System.Void ShopNGUIController::丙丆丟东丟世丌丞丂(BtnCategory 丐丕丙丏丙丛丛丂丒)));
        this.superCategoriesButtonController.actions.AddRange(collection:  val_15);
        this.业丘三一丘丂不东七();
        this.不上专丞丆七七丏业 = RilisoftRotator.丙丂专一丄丞丛业上();
        if(UnityEngine.Application.isEditor != false)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                float val_47 = this.不上专丞丆七七丏业;
            val_47 = val_47 * 10f;
            this.不上专丞丆七七丏业 = val_47;
        }
        
        }
        
        val_47 = UnityEngine.Screen.height;
        int val_31 = UnityEngine.Screen.width;
        float val_48 = (float)val_47;
        float val_49 = (float)UnityEngine.Screen.width;
        val_48 = val_48 * 0.1f;
        float val_50 = (float)UnityEngine.Screen.height;
        val_49 = val_49 + (与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (-370f));
        val_50 = val_50 * 0.8f;
        this.丘下丆丅与下丑丑三 = 0;
        mem[1152921539086500848] = 0;
        mem[1152921539086500856] = 0;
        Holoville.HOTween.HOTween.Init(p_permanentInstance:  true, p_renameInstanceToCountTweens:  true, p_allowOverwriteManager:  true);
        Holoville.HOTween.HOTween.EnableOverwriteManager(logWarnings:  true);
        this.丙七丛丝七丆七丛七 = UnityEngine.Time.realtimeSinceStartup;
        this.丐不专丗丞不不丑丏();
        val_48 = null;
        val_48 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        this.ActiveObject.SetActive(value:  false);
        if(this.bankShopView != 0)
        {
                System.EventHandler val_37 = null;
            val_47 = val_37;
            val_37 = new System.EventHandler(object:  this, method:  System.Void ShopNGUIController::且七丁丕丌丗三丗丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.bankShopView.丄下与业丏丂丞不世(丙业与丙丗丝不丈东:  val_37);
        }
        
        if(this.backButton != 0)
        {
                System.EventHandler val_40 = null;
            val_47 = val_40;
            val_40 = new System.EventHandler(object:  this, method:  System.Void ShopNGUIController::丁丆东丅丒上丆下丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.backButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  val_40);
        }
        
        val_49 = null;
        val_49 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                this.丆丘一丕丒丁业丅丞 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Armor_Low");
            this.丘丙丕丈七下丏且丆 = UnityEngine.Resources.LoadAll<UnityEngine.Material>(path:  "LowPolyArmorMaterials");
        }
        
        PGCompany.GameplayLoop.丕与七丐丞丕丑业世.业丑东丛三不丌万丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丄丂七不丘丟世与丐()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.一丁专下一丆丞丟世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丞下丏丙丑万丘万丄()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丄丁丁丟万不丄七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丑下七丑丛一东丟丒()));
        WeaponManager.丐万丑丙七丒且丂上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::与七丘丅与丛丅丂丝()));
    }
    private void 一丈丙丕东丄丒不与(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, int 丏丂丅丟上丁东丞丂)
    {
        this.丙丑丘业丕丗丗不丘();
    }
    private void 丙丝一丞世与世丈丆(PGCompany.世丒丗丅丛丕不万丂 上东丞世三世且丈丌)
    {
        var val_5;
        if(上东丞世三世且丈丌 == null)
        {
                return;
        }
        
        val_5 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 25000)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  上东丞世三世且丈丌.业上丙丞丐丄丆丅七())) != false)
        {
                return;
        }
        
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  168, 与丝丕与丙不与丗丆:  this.且丛丌丌七丈丝丒丈, 七丑业业丒七一丂丆:  false);
    }
    private void 丌业七丟丆东不丅三(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟)
    {
        ShopNGUIController.丕上万丑七丗丕一丈();
    }
    private void 与七丘丅与丛丅丂丝()
    {
        ShopNGUIController.丕上万丑七丗丕一丈();
    }
    private void 丏上丛丐且丒世丆丕()
    {
        this.丞丗业丕丘丂万丙丘();
    }
    private void 丞丗业丕丘丂万丙丘()
    {
        ShopItemsRowContainer[] val_3;
        var val_4;
        var val_5;
        System.Action<ArmoryCell> val_7;
        val_3 = this.上丟丞且丞丏丑上丏;
        if(val_3 == null)
        {
                return;
        }
        
        val_4 = 0;
        goto label_2;
        label_14:
        ShopItemsRowContainer val_3 = this.上丟丞且丞丏丑上丏[0];
        val_5 = null;
        val_5 = null;
        val_7 = ShopNGUIController.<>c.<>9__416_0;
        if(val_7 == null)
        {
                System.Action<ArmoryCell> val_2 = null;
            val_7 = val_2;
            val_2 = new System.Action<ArmoryCell>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::世丛丕上上丄丄丟丐(ArmoryCell 三丟东丕丄丄下下丑));
            ShopNGUIController.<>c.<>9__416_0 = val_7;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<ArmoryCell>(丌丛丏业世丄丞三丌:  System.Linq.Enumerable.OfType<ArmoryCell>(source:  this.上丟丞且丞丏丑上丏[0x0][0].丘丅下下丌上万丂且), 七丐丅专且专七三丆:  val_2);
        val_3 = this.上丟丞且丞丏丑上丏;
        val_4 = 1;
        label_2:
        if(val_4 < this.上丟丞且丞丏丑上丏.Length)
        {
            goto label_14;
        }
    
    }
    private void 且七丁丕丌丗三丗丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void ShopNGUIController::且下一一丘专丌丄不()))) != false)
        {
                return;
        }
        
        this.丏丄业丁丞万丛丏丘(丆丟七丝丏业丅上丄:  0);
    }
    internal void 丏丄业丁丞万丛丏丘(string 丆丟七丝丏业丅上丄)
    {
        string val_18;
        var val_19;
        var val_20;
        System.Action val_21;
        var val_22;
        UnityEngine.Object val_24;
        var val_25;
        var val_26;
        UnityEngine.GameObject val_27;
        UnityEngine.GameObject val_28;
        val_18 = 丆丟七丝丏业丅上丄;
        ShopNGUIController.丄东丐丈丈三不上不 val_1 = new ShopNGUIController.丄东丐丈丈三不上不();
        .丝且与丝丒丟万丁专 = this;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                UnityEngine.Debug.LogError(message:  "Arsenal (bank button) -> GoToMainStore");
            this.丁七丁丞丞丟丒业丅 = this.且丛丌丌七丈丝丒丈;
            this.丌不丒万万丟丞上与 = this.<与一丐丟丗三一东丂>k__BackingField;
            this.丕丏丑丏丏丂与东丏 = ShopNGUIController.丛丐丛专丟丞万三七();
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_20 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万丛丝七丟世丐丄丛;
            val_21 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            val_21.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_18, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万丛丝七丟世丐丄丛, 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
            return;
        }
        
        .丒七丒丌世丘丑丂七 = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丄东丐丈丈三不上不::丘丐三丂丈丝不丘丁());
        if((((mem[(System.Action)[1152921539088084032]..ctor(object:  ShopNGUIController.丄东丐丈丈三不上不 val_1 = null, method:  System.Void ShopNGUIController.丄东丐丈丈三不上不::丘丐三丂丈丝不丘丁()) + 295]) & 2) != 0) && ((mem[(System.Action)[1152921539088084032]..ctor(object:  ShopNGUIController.丄东丐丈丈三不上不 val_1 = null, method:  System.Void ShopNGUIController.丄东丐丈丈三不上不::丘丐三丂丈丝不丘丁()) + 216]) == 0))
        {
                val_22 = null;
        }
        
        val_21 = ShopNGUIController.<>c.<>9__418_1;
        if(val_21 == null)
        {
                System.Action val_7 = null;
            val_21 = val_7;
            val_7 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丟丗丂丅一专与丘丕());
            ShopNGUIController.<>c.<>9__418_1 = val_21;
        }
        
        float val_8 = UnityEngine.Time.realtimeSinceStartup;
        val_8 = val_8 - this.丙丗丅上三三与丑丙;
        if(val_8 < 0)
        {
                return;
        }
        
        val_24 = BankController.丑七不且上丗丁一世();
        if(val_24 == 0)
        {
                return;
        }
        
        .东丟且丗且三专丙丁 = val_1;
        if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() != false)
        {
                UnityEngine.Debug.LogWarning(message:  "InterfaceEnabledCoroutineLocked");
            return;
        }
        
        .丑丘丐丂不丐丒丟且 = 0;
        .丑丘丐丂不丐丒丟且 = new System.EventHandler(object:  new ShopNGUIController.世丄丄丞丆东丒丟不(), method:  System.Void ShopNGUIController.世丄丄丞丆东丒丟不::丂丑丗东万丑且丛丝(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙));
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (ShopNGUIController.世丄丄丞丆东丒丟不)[1152921539088096320].丑丘丐丂不丐丒丟且);
        val_25 = null;
        val_25 = null;
        val_26 = null;
        val_26 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万丛丝七丟世丐丄丛;
        val_24 = BankController.丑七不且上丗丁一世();
        val_24.丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  val_18, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.万丛丝七丟世丐丄丛);
        val_27 = this.mainPanel;
        if(val_27 != 0)
        {
                val_28 = this.mainPanel;
            val_28.SetActive(value:  false);
        }
        
        if(val_21 == null)
        {
                return;
        }
        
        val_7.Invoke();
    }
    internal void 专丞丑丑丂丟下丌丁()
    {
        var val_2 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        this.不丈丛专丞一万下丑();
        this.丘丈东丝丆丁丞丑与();
        this.丝丝不丛且三丏丁丗(丗丛不丁丑专专丂且:  false);
    }
    private void 丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)
    {
        var val_10;
        var val_11;
        System.Predicate<PGCompany.丕丒丒丞丛丐东与下> val_13;
        var val_14;
        val_10 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丕丒丒丞丛丐东与下> val_3 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丞丞丟专七丛丟丝丟();
        val_11 = null;
        val_11 = null;
        val_13 = ShopNGUIController.<>c.<>9__420_0;
        if(val_13 == null)
        {
            goto label_7;
        }
        
        label_19:
        if((val_3.Exists(match:  val_13)) == true)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丕丒丒丞丛丐东与下> val_6 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丞丞丟专七丛丟丝丟();
        val_14 = null;
        val_14 = null;
        val_13 = ShopNGUIController.<>c.<>9__420_1;
        if(val_13 == null)
        {
            goto label_13;
        }
        
        label_23:
        if((val_6.Exists(match:  val_13)) == true)
        {
                return;
        }
        
        this.丈丌丐丄丆丑业专七 = true;
        return;
        label_7:
        ShopNGUIController.<>c.<>9__420_0 = new System.Predicate<PGCompany.丕丒丒丞丛丐东与下>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::业丄业丒东丕丗丒上(PGCompany.丕丒丒丞丛丐东与下 三丟东丕丄丄下下丑));
        if(val_3 != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_13:
        ShopNGUIController.<>c.<>9__420_1 = new System.Predicate<PGCompany.丕丒丒丞丛丐东与下>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::下世丈与丗丞丈上丞(PGCompany.丕丒丒丞丛丐东与下 三丟东丕丄丄下下丑));
        if(val_6 != null)
        {
            goto label_23;
        }
        
        goto label_23;
    }
    private void 丞下丏丙丑万丘万丄()
    {
        ArmoryInfoScreenController val_3;
        var val_4;
        var val_5;
        CategoryNames val_6;
        val_4 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_6 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1564];
            val_6 = ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField;
        }
        else
        {
                val_6 = 314;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_6, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        val_3 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_3.丞丏世丆丄上丆一七();
    }
    private void 丑下七丑丛一东丟丒()
    {
        ArmoryInfoScreenController val_3;
        var val_4;
        var val_5;
        CategoryNames val_6;
        val_4 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_6 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1564];
            val_6 = ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField;
        }
        else
        {
                val_6 = 314;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_6, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        val_3 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_3.丞丏世丆丄上丆一七();
    }
    private void 丄丂七不丘丟世与丐()
    {
        ArmoryInfoScreenController val_13;
        var val_14;
        val_13 = this;
        val_14 = null;
        if(((ShopNGUIController.丛世丛与丌不丈丐丐() != false) && ((this.<与一丐丟丗三一东丂>k__BackingField) == 140000)) && (this.且丛丌丌七丈丝丒丈 != null))
        {
                if(this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七() != null)
        {
                this.丙丑丘业丕丗丗不丘();
        }
        
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == true)
        {
                return;
        }
        
        if((PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丆与与七丛丁七业丛(丁丅丈丌丟世丗丗丟:  0, 下丅丙一丂丗丅丝七:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
                return;
        }
        
        this.丙丑丘业丕丗丗不丘();
        val_13 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject;
        if(val_13.activeInHierarchy == false)
        {
                return;
        }
        
        val_13 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_13.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_13.丈丒丛东上丘丅世三(), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    private void 世一下世丒一下丈与(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
    {
        var val_2 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 30000)
        {
                return;
        }
        
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  48, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    private void 下一一丅丏下东丄丏()
    {
        ShopNGUIController val_12;
        System.Action<System.String> val_13;
        string val_14;
        var val_15;
        val_12 = this;
        if(this.万丞丂三下世丌丑丗 == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "SkinEditorController"));
        val_13 = val_2.transform;
        val_13.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if((val_2.GetComponent<SkinEditorController>()) == 0)
        {
                return;
        }
        
        ShopNGUIController.丅丁丐丟下丌三丏世 val_6 = new ShopNGUIController.丅丁丐丟下丌三丏世();
        if(val_6 != null)
        {
                .丝且与丝丒丟万丁专 = val_12;
        }
        else
        {
                mem[24] = val_12;
        }
        
        .丞丒业万东专上丒丛 = 0;
        System.Action<System.String> val_7 = null;
        val_13 = val_7;
        val_7 = new System.Action<System.String>(object:  val_6, method:  System.Void ShopNGUIController.丅丁丐丟下丌三丏世::专丏一丙丙专丞下丟(string 世万丗不丘丙丆世万));
        if(val_6 != null)
        {
                .丞丒业万东专上丒丛 = val_13;
        }
        else
        {
                .丞丒业万东专上丒丛 = val_13;
            val_13 = (ShopNGUIController.丅丁丐丟下丌三丏世)[1152921539089141440].丞丒业万东专上丒丛;
        }
        
        SkinEditorController.丒丛七丘丙一东丛东(丙业与丙丗丝不丈东:  val_13);
        val_14 = 0;
        if((System.String.op_Equality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  "CustomSkinID")) != true)
        {
                val_14 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        }
        
        val_15 = null;
        val_15 = null;
        SkinEditorController.业丈下丟世丑丂丙丙 = val_14;
        val_15 = null;
        SkinEditorController.丐丁世与三丅丗不一 = ((this.<与一丐丟丗三一东丂>k__BackingField) != 8) ? 1 : 0;
        val_12 = this.mainPanel;
        val_12.SetActive(value:  false);
    }
    private void 上丐世业丏丕丄丗丟(string 丏丟万且丝丒丝丅东)
    {
        string val_3 = 丏丟万且丝丒丝丅东;
        if(val_3 == null)
        {
                if((this.<与一丐丟丗三一东丂>k__BackingField) == 8)
        {
                丙且上东下丏丏丟下 val_3 = this.且丛丌丌七丈丝丒丈;
            string val_1 = val_3.业上丙丞丐丄丆丅七();
            val_3 = (val_1 == null) ? "CustomSkinID" : (val_1);
        }
        else
        {
                val_3 = "cape_Custom";
        }
        
        }
        
        this.不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_3, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField));
        this.不丈丛专丞一万下丑();
        this.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
    }
    private static System.Collections.Generic.List<UnityEngine.Camera> 且不下丙丛丛丄丈东()
    {
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  BankController.丑七不且上丗丁一世().GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
        if(FreeAwardController.丑七不且上丗丁一世() == 0)
        {
                return (System.Collections.Generic.List<UnityEngine.Camera>)val_3;
        }
        
        FreeAwardController val_6 = FreeAwardController.丑七不且上丗丁一世();
        if(val_6.renderCamera == 0)
        {
                return (System.Collections.Generic.List<UnityEngine.Camera>)val_3;
        }
        
        FreeAwardController val_8 = FreeAwardController.丑七不且上丗丁一世();
        val_3.Add(item:  val_8.renderCamera);
        return (System.Collections.Generic.List<UnityEngine.Camera>)val_3;
    }
    internal static void 丅丝一丐丒丙丕丁丏()
    {
        var val_4;
        var val_11;
        var val_12;
        var val_13;
        val_11 = ShopNGUIController.且不下丙丛丛丄丈东();
        List.Enumerator<T> val_2 = val_11.GetEnumerator();
        label_21:
        if((123078368 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5 == 0)
        {
            goto label_21;
        }
        
        val_5.enabled = true;
        UICamera val_7 = val_5.GetComponent<UICamera>();
        if(val_7 != 0)
        {
                val_7.enabled = true;
        }
        
        val_12 = null;
        val_12 = null;
        if((ShopNGUIController.丟丌丞万丕万丐丐上.Contains(item:  val_5)) == false)
        {
            goto label_21;
        }
        
        val_13 = null;
        val_13 = null;
        bool val_10 = ShopNGUIController.丟丌丞万丕万丐丐上.Remove(item:  val_5);
        goto label_21;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丘丈东丝丆丁丞丑与()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.gridScrollView, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leagueLock, 丏业丟一东丂东丘丛:  false);
    }
    private void 业三丄丝丐丌丆七丛(bool 不丟丞丑丛丆丁东与 = False, string 丏世丑万世一七丟丞, UnityEngine.GameObject 七丁上丁丒专丈七丙, bool 丘世丅丞丌丟丏下丙 = False, System.Action 丟丟丟三东丛丌丘且, bool 丐丏上业丈丂与万丞 = False, bool 丗业丕七且丝丆丝丘 = False)
    {
        bool val_73;
        string val_74;
        ShopNGUIController val_75;
        object val_76;
        var val_77;
        var val_78;
        var val_79;
        CategoryNames val_80;
        var val_81;
        bool val_82;
        var val_83;
        丕丑丙丑丙东丌丘丕 val_84;
        int val_85;
        var val_86;
        CategoryNames val_87;
        万丆且丁业且丕七丈 val_88;
        UnityEngine.GameObject val_89;
        var val_90;
        System.Action val_92;
        UnityEngine.GameObject val_93;
        val_73 = 丐丏上业丈丂与万丞;
        val_74 = 丏世丑万世一七丟丞;
        val_75 = this;
        丕丈丏丝丗下丟丅丂 val_29 = 0;
        ShopNGUIController.丁丑丒丗丘七丟丑丆 val_1 = null;
        val_76 = val_1;
        val_1 = new ShopNGUIController.丁丑丒丗丘七丟丑丆();
        if(val_76 != null)
        {
                val_77 = val_76;
            .丐丏上业丈丂与万丞 = val_73;
            val_78 = 1152921539090177665;
            val_79 = 1152921539090177665;
            mem[1152921539090177616] = val_75;
            mem[1152921539090177636] = 不丟丞丑丛丆丁东与;
            mem[1152921539090177664] = 丗业丕七且丝丆丝丘;
        }
        else
        {
                mem[16] = val_75;
            val_78 = val_76;
            .不丟丞丑丛丆丁东与 = 不丟丞丑丛丆丁东与;
            val_79 = 64;
            mem[64] = 丗业丕七且丝丆丝丘;
            val_77 = val_76;
            .丐丏上业丈丂与万丞 = val_73;
        }
        
        .丟丟丟三东丛丌丘且 = 丟丟丟三东丛丌丘且;
        if(val_74 != null)
        {
                val_80 = val_76;
            .丌业专专丞专专丆丌 = val_74;
        }
        else
        {
                val_80 = val_76;
            .丌业专专丞专专丆丌 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
            val_74 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        }
        
        .丞一丁业丄一一业且 = val_74;
        int val_10 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_74);
        .专丄丌且一丕万与丛 = val_10;
        if(val_10 != 7)
        {
                if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_10)) != false)
        {
                string val_12 = WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  .丌业专专丞专专丆丌);
            mem[1152921539090177648] = val_12;
            mem[1152921539090177640] = val_12;
        }
        
        }
        
        if(mem[1152921539090177648] == 0)
        {
                return;
        }
        
        if((PGCompany.GameplayLoop.丕与七丐丞丕丑业世.万下丝东七丙万丒业(丞一丁业丄一一业且:  mem[1152921539090177640])) == false)
        {
            goto label_20;
        }
        
        if(val_79 == false)
        {
            goto label_19;
        }
        
        val_81 = 1;
        goto label_20;
        label_19:
        if(.不丟丞丑丛丆丁东与 == false)
        {
            goto label_21;
        }
        
        val_81 = 0;
        label_20:
        val_75 = (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].丐丏上业丈丂与万丞;
        label_95:
        .丒世丘丘上丆丝东丞 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛, 丞一丁业丄一一业且:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].丞一丁业丄一一业且, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  (val_75 == true) ? 1 : 0, 丗业丕七且丝丆丝丘:  (val_81 != 0) ? 1 : 0);
        .丄下丁东丘业丆丝上 = 0;
        val_73 = 1152921505259880448;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛)) == false)
        {
            goto label_26;
        }
        
        val_82 = .不丟丞丑丛丆丁东与;
        val_83 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  mem[1152921539090177640]);
        if((val_83 == null) || (val_82 == false))
        {
            goto label_30;
        }
        
        val_84 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_83.业东丅东丌上丗丑不());
        if(val_84 == null)
        {
            goto label_101;
        }
        
        if(mem[64] == false)
        {
            goto label_35;
        }
        
        if(val_84.七东与丄丕丁丛世三() > 4)
        {
            goto label_36;
        }
        
        丕丑丙丑丙东丌丘丕 val_26 = null;
        val_75 = val_73;
        val_26 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_84.丈一下下丞世三丑丄(), 丏丆丐丑专与丄丘丞:  val_84.七东与丄丕丁丛世三() + 1);
        .丄下丁东丘业丆丝上 = val_26;
        val_73 = val_75;
        goto label_101;
        label_26:
        val_83 = 0;
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛)) == false)
        {
            goto label_101;
        }
        
        bool val_30 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  mem[1152921539090177640], value: out  val_29);
        val_75 = .不丟丞丑丛丆丁东与;
        if(val_29 == 0)
        {
            goto label_44;
        }
        
        if(val_75 == false)
        {
            goto label_45;
        }
        
        label_53:
        val_75 = .丐丏上业丈丂与万丞;
        val_85 = val_29.业东丅东丌上丗丑不();
        int val_36 = BalanceController.与丗万世丅下丈万丁(丞世不丒下上上丝丑:  val_85, 丈丘丝一丗下丈丐不:  Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_29.业东丅东丌上丗丑不()), 丐丏上业丈丂与万丞:  (val_75 == true) ? 1 : 0);
        goto label_52;
        label_44:
        if(val_75 == true)
        {
            goto label_53;
        }
        
        label_45:
        val_85 = val_29;
        label_52:
        丕丑丙丑丙东丌丘丕 val_38 = null;
        val_84 = val_38;
        val_38 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_85.专丂丏世且丗丏丌丝(), 丏丆丐丑专与丄丘丞:  0);
        val_83 = 0;
        label_36:
        .丄下丁东丘业丆丝上 = val_84;
        label_101:
        val_82 = .不丟丞丑丛丆丁东与;
        label_30:
        if(((val_82 == false) || (.丐丏上业丈丂与万丞 == true)) || (mem[64] == true))
        {
            goto label_60;
        }
        
        val_80 = (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛;
        if(((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_80)) == false) || ((PGCompany.一丞丐丏丅万万业专.丄万且丒与且丆丕丄(七丆丒与丗丌丄且丂:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛)) < 1))
        {
            goto label_60;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  4);
        val_1.丗专不丞三丑不下上(丞业丛世丛丘丝不丌:  true, 世丙与专七丟丒丆世:  1);
        PGCompany.三东丏不丗世丅丌丄 val_42 = PGCompany.一丞丐丏丅万万业专.上万丈丒丅万丘丙一(七丆丒与丗丌丄且丂:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛);
        val_42.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  1);
        PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  val_42, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
        goto label_66;
        label_60:
        val_80 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_80.丂世三丅一万东三三(不七丆万丁一丞七下:  220)) == false)
        {
            goto label_68;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  88);
        val_86 = 32;
        goto label_72;
        label_68:
        val_80 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
        if((val_80.丂世三丅一万东三三(不七丆万丁一丞七下:  164)) == false)
        {
            goto label_74;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  94);
        val_86 = 33;
        label_72:
        val_1.丗专不丞三丑不下上(丞业丛世丛丘丝不丌:  false, 世丙与专七丟丒丆世:  33);
        label_66:
        val_76 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_76.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_74:
        val_87 = (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛;
        val_88 = 上丑三丁丄丛丁万丑.丄丁丗下不丘丝丁不(丄丕与丈万丂上万丁:  上丑三丁丄丛丁万丑.丑丝丏下丁丞丌丒丂(丈丁丐丌三丟与一丕:  (val_83.东七与与不丅丙上上() != true) ? 170000 : (val_87), 不丟丞丑丛丆丁东与:  (.不丟丞丑丛丆丁东与 == true) ? 1 : 0, 万丟丝下丟丏丑丕丐:  (mem[64] == true) ? 1 : 0));
        val_89 = 七丁上丁丒专丈七丙;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].丒世丘丘上丆丝东丞.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_86;
        }
        
        }
        
        if(val_89 == 0)
        {
                val_89 = mem[1152921539090134152];
        }
        
        val_90 = null;
        val_90 = null;
        val_92 = ShopNGUIController.<>c.<>9__431_2;
        if(val_92 != null)
        {
            goto label_90;
        }
        
        val_93 = val_89;
        goto label_102;
        label_21:
        丈丞丕丘丕丗与上一 val_64 = PGCompany.GameplayLoop.丕与七丐丞丕丑业世.与丒一且丛丙丞丂专(丞一丁业丄一一业且:  mem[1152921539090177640]);
        goto label_95;
        label_86:
        System.Action val_65 = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丁丑丒丗丘七丟丑丆::丙丙丕上丂丗丑丕东());
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_65)) == true)
        {
                return;
        }
        
        val_65.Invoke();
        return;
        label_35:
        .丄下丁东丘业丆丝上 = BalanceController.丌丛丄丙丘丈与下专(丞丌东丟且丒丐丑丂:  val_84, 丐丏上业丈丂与万丞:  (.丐丏上业丈丂与万丞 == true) ? 1 : 0);
        goto label_101;
        label_102:
        System.Action val_69 = null;
        val_92 = val_69;
        val_69 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::东东丄东丞丁丅丗丛());
        val_89 = ;
        ShopNGUIController.<>c.<>9__431_2 = val_92;
        val_88 = val_88;
        label_90:
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_89, 丒世丘丘上丆丝东丞:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丁丑丒丗丘七丟丑丆::丟丐一丌与丐七丏丂()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丁丑丒丗丘七丟丑丆::与业丘丅丙三丅且不()), 丞丐下东与丅万丅丁:  val_69, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].专丄丌且一丕万与丛)) != true) ? ((ShopNGUIController.丁丑丒丗丘七丟丑丆)[1152921539090177600].丞一丁业丄一一业且) : "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  val_88);
    }
    internal static void 丂丅上丂丞丗丘且丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ShopNGUIController.丄丆下万丛丅丒丘七, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丄丆下万丛丅丒丘七 != 1152921505261215824);
    
    }
    internal static void 丑七丕七七一丗丁万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ShopNGUIController.丄丆下万丛丅丒丘七, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丄丆下万丛丅丒丘七 != 1152921505261215824);
    
    }
    internal static void 下三万丘丁三丝一业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ShopNGUIController.丈丘下丏丆丐业丌丄, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丈丘下丏丆丐业丌丄 != 1152921505261215832);
    
    }
    internal static void 丗三丗丌丂丟一丑丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ShopNGUIController.丈丘下丏丆丐业丌丄, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丈丘下丏丆丐业丌丄 != 1152921505261215832);
    
    }
    internal void 丆且上丁世专丛专丞(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, UnityEngine.GameObject 七丁上丁丒专丈七丙, string 丞一丁业丄一一业且, System.Action 七丒上且丝业业下七, System.Action 丘丅丌丄丐丟丑丈丘, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 丐丈上丂与上丂丒丏 = 0, string 丅丑丗丐丛丂丕丏丌)
    {
        UnityEngine.GameObject val_19;
        var val_20;
        var val_21;
        System.Action val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_19 = 七丁上丁丒专丈七丙;
        ShopNGUIController.丗丏与丙丟丁万丄丒 val_1 = new ShopNGUIController.丗丏与丙丟丁万丄丒();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丘丅丌丄丐丟丑丈丘 = 丘丅丌丄丐丟丑丈丘;
        val_20 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        if(val_20.丌丄一丒且下丅丁丏() == false)
        {
            goto label_4;
        }
        
        val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if((val_20.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_7;
        }
        
        label_4:
        if(val_19 == null)
        {
                val_19 = this.mainPanel;
        }
        
        val_21 = null;
        val_21 = null;
        val_23 = ShopNGUIController.<>c.<>9__438_1;
        if(val_23 == null)
        {
                System.Action val_8 = null;
            val_23 = val_8;
            val_8 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::上丒万东且丄下丑丂());
            ShopNGUIController.<>c.<>9__438_1 = val_23;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_19, 丒世丘丘上丆丝东丞:  丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  七丒上且丝业业下七, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丗丏与丙丟丁万丄丒::丏丝世丌世丆业万丟()), 丞丐下东与丅万丅丁:  val_8, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.<与一丐丟丗三一东丂>k__BackingField)) != true) ? 丞一丁业丄一一业且 : "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  丐丈上丂与上丂丒丏);
        return;
        label_7:
        UnityEngine.Debug.LogError(message:  "Arsenal (not enough currency) -> GoToMainStore");
        this.丁七丁丞丞丟丒业丅 = this.且丛丌丌七丈丝丒丈;
        this.丌不丒万万丟丞上与 = this.<与一丐丟丗三一东丂>k__BackingField;
        this.丕丏丑丏丏丂与东丏 = ShopNGUIController.丛丐丛专丟丞万三七();
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  丅丑丗丐丛丂丕丏丌, 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        val_24 = null;
        val_24 = null;
        if((System.String.op_Equality(a:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_27;
        }
        
        val_25 = null;
        val_25 = null;
        if(ShopNGUIController.丄丆下万丛丅丒丘七 != null)
        {
            goto label_30;
        }
        
        return;
        label_27:
        val_26 = null;
        val_26 = null;
        if((System.String.op_Equality(a:  丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
                return;
        }
        
        val_27 = null;
        val_27 = null;
        if(ShopNGUIController.丈丘下丏丆丐业丌丄 == null)
        {
                return;
        }
        
        label_30:
        ShopNGUIController.丈丘下丏丆丐业丌丄.Invoke();
    }
    internal static void 上丝与丂一丌丛丞专(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ShopNGUIController.丑丑业万万东丅丑丟, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丑丑业万万东丅丑丟 != 1152921505261215840);
    
    }
    internal static void 丛丄上上丟万东世丂(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ShopNGUIController.丑丑业万万东丅丑丟, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丑丑业万万东丅丑丟 != 1152921505261215840);
    
    }
    internal static void 三丟不东丆万七三与(string 下丅丙一丂丗丅丝七)
    {
        null = null;
        if(ShopNGUIController.丑丑业万万东丅丑丟 == null)
        {
                return;
        }
        
        ShopNGUIController.丑丑业万万东丅丑丟.Invoke(obj:  下丅丙一丂丗丅丝七);
    }
    internal void 丏丘丞不丌一丁丗丑(string 丌业专专丞专专丆丌, string 丞一丁业丄一一业且, 丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, bool 不丟丞丑丛丆丁东与, 丕丑丙丑丙东丌丘丕 丄下丁东丘业丆丝上, bool 丗业丕七且丝丆丝丘 = False, bool 丐丏上业丈丂与万丞 = False, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 不丐丅丁丂七丐丘丛 = 0)
    {
        string val_63;
        object val_64;
        Rilisoft.业丙丘丆东丈丕丂丄 val_65;
        Rilisoft.OfferItem val_66;
        System.Action<System.String> val_67;
        丈丞丕丘丕丗与上一 val_68;
        string val_69;
        string val_70;
        var val_71;
        var val_72;
        val_63 = 丌业专专丞专专丆丌;
        ShopNGUIController.丈丁丑万丂专且丏丆 val_1 = null;
        val_64 = val_1;
        val_1 = new ShopNGUIController.丈丁丑万丂专且丏丆();
        if(val_64 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .不丟丞丑丛丆丁东与 = 不丟丞丑丛丆丁东与;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  3);
        .专下丅万丁丒丕丂七 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丞一丁业丄一一业且);
        if((PGCompany.GameplayLoop.丕与七丐丞丕丑业世.万下丝东七丙万丒业(丞一丁业丄一一业且:  丞一丁业丄一一业且)) == false)
        {
            goto label_17;
        }
        
        val_65 = PGCompany.GameplayLoop.丕与七丐丞丕丑业世.丗三丅七一世与一丞(丞一丁业丄一一业且:  丞一丁业丄一一业且);
        if(val_65 == null)
        {
            goto label_14;
        }
        
        System.Collections.Generic.List<Rilisoft.OfferItem> val_7 = val_65.丏与丅专三丙与丘丒();
        if(val_7 == null)
        {
            goto label_14;
        }
        
        if((val_7.Count != 1) || ((System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_7).Type) != 10))
        {
            goto label_17;
        }
        
        val_66 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  val_7);
        goto label_18;
        label_17:
        val_66 = 0;
        val_65 = 0;
        goto label_19;
        label_14:
        val_66 = 0;
        label_18:
        label_19:
        System.Action<System.String> val_13 = null;
        val_67 = val_13;
        val_13 = new System.Action<System.String>(object:  val_1, method:  System.Void ShopNGUIController.丈丁丑万丂专且丏丆::且丈丝万一与丗丅丂(string 下丅丙一丂丗丅丝七));
        val_68 = 万丐丏丐丒万不丟三;
        丐一且丝丂丟丞三丅.丟丞且下一丛丆丄丆(七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丌业专专丞专专丆丌:  val_63, 丞一丁业丄一一业且:  丞一丁业丄一一业且, 丁丒丈专且下丙三世:  new System.Action<System.String>(object:  val_1, method:  System.Void ShopNGUIController.丈丁丑万丂专且丏丆::丆不且丙丕丝一丈丝(string 下丅丙一丂丗丅丝七)), 七丝下七下丗三且丟:  val_13, 丁且丟不七下丆丒丟:  true, 丝丗不东丙不三丄专:  false, 万丐丏丐丒万不丟三:  val_68, 丄下丁东丘业丆丝上:  丄下丁东丘业丆丝上, 丐丏上业丈丂与万丞:  丐丏上业丈丂与万丞, 不丌丟专丙丈丟丘专:  new PGCompany.丛丈下且丐丝不东丈() {不丐丅丁丂七丐丘丛 = 1, 上丂丑丄丈七丆丁下 = false, 丁丁丒丆不丒下丟三 = ???, <上三与万不且且业丟>k__BackingField = ???, <丟丟丂东世下丗不丝>k__BackingField = ???, <丑丐丏丏一丛丌专丐>k__BackingField = ???, <丄东丗世丁丁世丆丏>k__BackingField = ???, <且丄丞一下丕丂东丕>k__BackingField = ???, <不丅丘丄丝丌丙丅万>k__BackingField = ???, <丘下丅丆万丕丆丂世>k__BackingField = ???}, 丁七丐丁丙丄丙不东:  ((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].不丟丞丑丛丆丁东与 == false) ? 1 : 0);
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 == 8)
        {
                this.丅东东万丘丝丅三世(丞丅上丏丂且下丅与:  val_63);
        }
        
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].不丟丞丑丛丆丁东与 != false)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) != false)
        {
                WeaponManager.东一业丅丝丕丏业世(丒东业不丐丑丕丄丆:  丞一丁业丄一一业且);
        }
        
        }
        
        var val_17 = (val_65 != 0) ? 1 : 0;
        if(val_66 != 0)
        {
                val_17 = 1 & val_17;
            if(val_17 != 0)
        {
                Rilisoft.一丟专且三万丞丁丂.且丐业一不丄丟丅与(丞一丁业丄一一业且:  丞一丁业丄一一业且, 丏丂不专上丘丂不丅:  System.String.Format(format:  "{0}_{1}", arg0:  val_65.丟丂丞不专丆万丒世().东与三丌丅三丒丏业(), arg1:  val_65.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世()));
            Rilisoft.一丟专且三万丞丁丂.业七东与东丝丑丁三(下丗丁丒丘东丂不丑:  val_66.Type, 丞一丁业丄一一业且:  丞一丁业丄一一业且, 丌丒丝东丌下丕丁丅:  1);
            Rilisoft.一丟专且三万丞丁丂.万且三丘丆丟丆丘丞(丞一丁业丄一一业且:  丞一丁业丄一一业且, 丒世丘丘上丆丝东丞:  val_65.丟丂丞不专丆万丒世());
            Rilisoft.一丟专且三万丞丁丂.丆专丛下东丌丛与丅(且丗丅上丄丕且下上:  "Armory");
            val_63 = null;
            val_68 = 万丐丏丐丒万不丟三;
            val_63 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            null.Add(item:  val_66);
            Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丁万丝与丝丘东丆丝(丙业丞丑七丗下丟丌:  val_65, 丟与丗丙丐下且丄业:  null);
        }
        
        }
        
        val_69 = 丞一丁业丄一一业且;
        if((1 & 1) != 0)
        {
            goto label_124;
        }
        
        三丅丁丗丗丝丂万且 val_27 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_69);
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) == false)
        {
            goto label_91;
        }
        
        if(丗业丕七且丝丆丝丘 == false)
        {
            goto label_47;
        }
        
        Rilisoft.一丟专且三万丞丁丂.丒丛东丙三专东丟丞(丞一丁业丄一一业且:  丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丈下丑丆上丏丗丈专:  丄下丁东丘业丆丝上.七东与丄丕丁丛世三(), 丒世丘丘上丆丝东丞:  val_68);
        goto label_91;
        label_47:
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].不丟丞丑丛丆丁东与 == false)
        {
            goto label_52;
        }
        
        Rilisoft.一丟专且三万丞丁丂.丕丆且丌丐丙万丂与(世与丂且丘丐万丗丞:  val_27, 万丛上业丘专丙业丞:  ExperienceController.丞丞丘业东丙丏七丌(), 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丒世丘丘上丆丝东丞:  val_68);
        label_91:
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 != 7)
        {
            goto label_58;
        }
        
        val_69 = 丞一丁业丄一一业且;
        Rilisoft.一丟专且三万丞丁丂.一丒丝丞业专丛三丈(万丛上业丘专丙业丞:  Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丂专下丌丈丙专丁东(丙丄不丈专丕与万万:  val_69), 丒世丘丘上丆丝东丞:  val_68);
        丙且上东下丏丏丟下 val_33 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_69, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七);
        goto label_75;
        label_58:
        val_69 = 丞一丁业丄一一业且;
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) == false)
        {
            goto label_67;
        }
        
        Rilisoft.一丟专且三万丞丁丂.丝业丛丂丛丟丐与丁(丞一丁业丄一一业且:  val_69, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丒世丘丘上丆丝东丞:  val_68);
        丙且上东下丏丏丟下 val_35 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_69, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七);
        goto label_75;
        label_67:
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 == 190000)
        {
            goto label_71;
        }
        
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 != 8)
        {
            goto label_75;
        }
        
        Rilisoft.一丟专且三万丞丁丂.一丏丕丏丂丘三与丗(且丘世丏丛丛万丟万:  val_69, 丒世丘丘上丆丝东丞:  val_68);
        丙且上东下丏丏丟下 val_36 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_69, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七);
        goto label_75;
        label_52:
        Rilisoft.一丟专且三万丞丁丂.丆世丟业世丛丛丆丘(丞一丁业丄一一业且:  丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丒世丘丘上丆丝东丞:  val_68);
        丕丑丙丑丙东丌丘丕 val_39 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_27.业东丅东丌上丗丑不());
        if((val_39 == null) || (val_39.丈一下下丞世三丑丄() >= ExperienceController.丞丞丘业东丙丏七丌()))
        {
            goto label_91;
        }
        
        Rilisoft.一丟专且三万丞丁丂.丈丟上业且丈丝丑丅(七丆丒与丗丌丄且丂:  val_27.丒万丕七专不丏丞丌(), 三丅丞世丙丒东下丌:  ExperienceController.丞丞丘业东丙丏七丌() - val_39.丈一下下丞世三丑丄());
        goto label_91;
        label_71:
        Rilisoft.一丟专且三万丞丁丂.丆丆丗专丑丑丒丙丆(丐丒丈丌与丈丏不上:  val_69, 丒世丘丘上丆丝东丞:  val_68);
        丙且上东下丏丏丟下 val_46 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_69, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七);
        label_75:
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  mem[1152921539091896780])) == true)
        {
            goto label_96;
        }
        
        val_67 = (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七;
        if(val_67 != 180000)
        {
            goto label_97;
        }
        
        label_96:
        if(mem[1152921539091896780] == 210000)
        {
            goto label_98;
        }
        
        val_70 = val_69;
        if(mem[1152921539091896780] != 160000)
        {
            goto label_99;
        }
        
        label_98:
        val_70 = System.String.Format(format:  "{0}_up{1}", arg0:  val_69, arg1:  丛且丗丌丏下七下丈.丑丈业上万一丁丛丂(七丙丈丆丕丄丐业丟:  val_69));
        label_99:
        Rilisoft.一丟专且三万丞丁丂.丐专丘专与丞上丅一(下丅丙一丂丗丅丝七:  val_70, 七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丝丘且丞丙丞丗丗丅:  val_68);
        val_67 = (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七;
        label_97:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_67)) != false)
        {
                val_67 = (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七;
            Rilisoft.一丟专且三万丞丁丂.丈下专丄且丙丂丈丄(下丅丙一丂丗丅丝七:  val_69, 七丆丒与丗丌丄且丂:  val_67, 丝丘且丞丙丞丗丗丅:  val_68);
        }
        
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].不丟丞丑丛丆丁东与 != true)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) == true)
        {
            goto label_124;
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) == false)
        {
            goto label_115;
        }
        
        label_122:
        Rilisoft.一丟专且三万丞丁丂.一丙与丅不丕三世不(七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七, 丞一丁业丄一一业且:  val_69);
        goto label_124;
        label_115:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) == false)
        {
            goto label_121;
        }
        
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 != 7)
        {
            goto label_122;
        }
        
        goto label_123;
        label_121:
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 != 7)
        {
            goto label_124;
        }
        
        label_123:
        Rilisoft.一丟专且三万丞丁丂.丘丐业丏丄丞丏与世(丞一丁业丄一一业且:  val_69);
        label_124:
        if((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].不丟丞丑丛丆丁东与 != false)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) != false)
        {
                丆三丗与丆业丑东丛.丁世丛丞丕丐七业丅(丕丁下丌不万丅丞丛:  val_69);
        }
        
        }
        
        if((((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七)) != true) && ((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 != 7)) && ((ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七 != 25000))
        {
                val_69 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  val_69);
        }
        
        val_71 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_64 = (ShopNGUIController.丈丁丑万丂专且丏丆)[1152921539091947696].专下丅万丁丒丕丂七;
            丙且上东下丏丏丟下 val_58 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_69, 七丆丒与丗丌丄且丂:  val_64);
            mem[1152921539091896016] = val_58;
            this.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  true);
            this.不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  val_58);
            if(mem[1152921539091895968] != true)
        {
                val_72 = null;
            val_72 = null;
            if(SquadController.丄丘七三上丕世丞业.inSquad != true)
        {
                if((System.String.op_Equality(a:  val_58.业上丙丞丐丄丆丅七(), b:  "cape_Custom")) != false)
        {
                this.下一一丅丏下东丄丏();
        }
        
        }
        
        }
        
            this.一丛丈上且不丟丑万();
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void 丟七丈丅丛丝丝丑丈(string 丞丅上丏丂且下丅与)
    {
        if(this.丅丝业丑丑丆丆丞丈 == null)
        {
                return;
        }
        
        this.丅丝业丑丑丆丆丞丈.Invoke(obj:  丞丅上丏丂且下丅与);
    }
    internal void 丅东东万丘丝丅三世(string 丞丅上丏丂且下丅与)
    {
        SkinsController.丞丒东上丙下专丕七(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
        this.丟七丈丅丛丝丝丑丈(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
    }
    internal void 且业丛丕丑丗不不七()
    {
        UnityEngine.AudioSource val_1 = this.GetComponent<UnityEngine.AudioSource>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.Stop();
        val_1.clip = 0;
    }
    private System.Collections.IEnumerator 丞与丑丛丙丅万世世()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ShopNGUIController.万丝丂世丈丈上丈丗(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丗丆丒丘万丈丂丑丞()
    {
        this.丙丑丘业丕丗丗不丘();
    }
    private void OnDestroy()
    {
        var val_20;
        if(this.丏丂丙一业一一不专 != null)
        {
                val_20 = null;
            val_20 = null;
            this.丏丂丙一业一一不专.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        
        this.丏丂丙一业一一不专 = 0;
        PetRenameWindov.专七丝且丞丁不丁三(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丒丗丅丛丕不万丂>(object:  this, method:  System.Void ShopNGUIController::丙丝一丞世与世丈丆(PGCompany.世丒丗丅丛丕不万丂 上东丞世三世且丈丌)));
        Rilisoft.EggsManager.丅不七不三丞丈丝七(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<System.String, System.Int32>, PGCompany.丝不丅丗丄丄与丌丘>(object:  this, method:  System.Void ShopNGUIController::与丆丕丙下丑丐丛专(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, System.Collections.Generic.Dictionary<string, int> 丏丂丅丟上丁东丞丂, PGCompany.丝不丅丗丄丄与丌丘 东丏上丄丙丘丘丂三)));
        Rilisoft.EggsManager.专七丕三业丗丑丞丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void ShopNGUIController::丌业七丟丆东不丅三(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟)));
        WeaponManager.七丕丕丒丗丄丒丌上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::与七丘丅与丛丅丂丝()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丐丑丑丐丅丈丝丄世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丑下七丑丛一东丟丒()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丆丑专一丟下丆丙七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丞下丏丙丑万丘万丄()));
        PGCompany.GameplayLoop.丕与七丐丞丕丑业世.丏东业丁不三丒丅丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丙丁丗专丕丙丅业上()));
        Rilisoft.丗下丙丅且丐丞丙世.世丟丆丞不东丅丝三(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void ShopNGUIController::丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
        Rilisoft.EggsManager.一下丗丒丛下丘丞丗(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void ShopNGUIController::世一下世丒一下丈与(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)));
        Rilisoft.PetsManager.丗丞七上专三丟丘丐(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ShopNGUIController::丝丐丞丘且上丒上丂(string 世丐丗专丅三丝丑丆)));
        专丈专业丆且且业下.丄与东丌丟下丑与丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丏上丛丐且丒世丆丕()));
        PGCompany.GameplayLoop.丕与七丐丞丕丑业世.业丐三丙丆丒丘丈丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丄丂七不丘丟世与丐()));
        if(this.bankShopView != 0)
        {
                this.bankShopView.丆世丅三下丗丆丝丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ShopNGUIController::且七丁丕丌丗三丗丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        BaseArmoryCell.丄丁丕上且三丒三世(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void ShopNGUIController::丙丐丏丝丙丝丐丑丛(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        BaseArmoryCell.不上世丙丈丅丒上丂(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  public System.Void ShopNGUIController::CellClicked(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        BaseArmoryCell.丂丁丑丏丞上丂丐丟(丙业与丙丗丝不丈东:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void ShopNGUIController::七丝丏丙丘丕丝丆丛(BaseArmoryCell 丌丝万上丅丒一丈丘)));
        ShopCategoryButton.丅丄三不三世丆丕丆(丙业与丙丗丝不丈东:  new System.Action<ShopCategoryButton>(object:  this, method:  System.Void ShopNGUIController::世下丒东业丌专丌东(ShopCategoryButton 下丈万丌且与丌万丁)));
        PGCompany.丞丁丌不丌不丄丆丟.丘丛丆丏丅万丗上丏(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress, System.Int32>(object:  this, method:  System.Void ShopNGUIController::一丈丙丕东丄丒不与(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, int 丏丂丅丟上丁东丞丂)));
    }
    private void 与丆丕丙下丑丐丛专(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, System.Collections.Generic.Dictionary<string, int> 丏丂丅丟上丁东丞丂, PGCompany.丝不丅丗丄丄与丌丘 东丏上丄丙丘丘丂三)
    {
        ShopNGUIController.丕上万丑七丗丕一丈();
    }
    private void Start()
    {
        UnityEngine.Transform val_1 = UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "ArmoryCell");
        UIPanel val_2 = this.gridScrollView.GetComponent<UIPanel>();
        int val_6 = X21 + 28;
        this.丗上一丂且丛业丐丄 = val_6;
        val_6 = val_6 + 25;
        this.世丂丟丒且丅上业丒 = val_6;
        this.专专不丈丛丆丌丝丒 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "skins_maker_skin");
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.TryToShowExpiredBanner());
        this.丕丐东下丒与一丈丆 = this.rentScreenPoint;
    }
    private void 丄丛丏丂丌丘丌丘七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.ActiveObject, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        System.Action val_13;
        System.Action val_14;
        var val_15;
        var val_16;
        System.Action val_17;
        if(((System.Delegate.Combine(a:  this.丙丟丝丂不丈专丅丅, b:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丆三下上一丌世且专()))) != null) && (null != null))
        {
                val_13 = 0;
        }
        
        this.丙丟丝丂不丈专丅丅 = val_13;
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ShopNGUIController::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::一业业七不业丈下丞()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::一业业七不业丈下丞()));
        val_14 = System.Delegate.Combine(a:  this.superCategoriesButtonController.丛万丈万丘丝丂业与, b:  new System.Action(object:  this, method:  System.Void ShopNGUIController::七丘上丆与丝七与丂()));
        val_15 = null;
        if((val_14 != null) && (null != val_15))
        {
                val_15 = null;
            val_14 = 0;
        }
        
        this.superCategoriesButtonController.丛万丈万丘丝丂业与 = val_14;
        PGCompany.ModuleInsertPanel.丒下丟丏三丛丄不丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::七丘上丆与丝七与丂()));
        PGCompany.ModuleInsertPanel.丗丑与与丗丞三丂一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::七丘上丆与丝七与丂()));
        val_16 = null;
        val_16 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丄丛丏丂丌丘丌丘七()))) != null) && (null != null))
        {
                val_17 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_17;
    }
    private void OnDisable()
    {
        System.Action val_13;
        System.Action val_14;
        var val_15;
        var val_16;
        System.Action val_17;
        if(((System.Delegate.Remove(source:  this.丙丟丝丂不丈专丅丅, value:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丆三下上一丌世且专()))) != null) && (null != null))
        {
                val_13 = 0;
        }
        
        this.丙丟丝丂不丈专丅丅 = val_13;
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ShopNGUIController::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::一业业七不业丈下丞()));
        业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::一业业七不业丈下丞()));
        val_14 = System.Delegate.Remove(source:  this.superCategoriesButtonController.丛万丈万丘丝丂业与, value:  new System.Action(object:  this, method:  System.Void ShopNGUIController::七丘上丆与丝七与丂()));
        val_15 = null;
        if((val_14 != null) && (null != val_15))
        {
                val_15 = null;
            val_14 = 0;
        }
        
        this.superCategoriesButtonController.丛万丈万丘丝丂业与 = val_14;
        PGCompany.ModuleInsertPanel.丘东不万与上东世上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::七丘上丆与丝七与丂()));
        PGCompany.ModuleInsertPanel.一下七丄专丛三丝丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::七丘上丆与丝七与丂()));
        val_16 = null;
        val_16 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丄丛丏丂丌丘丌丘七()))) != null) && (null != null))
        {
                val_17 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_17;
    }
    private System.Collections.IEnumerator TryToShowExpiredBanner()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ShopNGUIController.丞丐与与不丆专丆上(丗丏丅丕丆世丁专丟:  0);
    }
    private void 不丂专三丟丞丕丂三(string 丞一丁业丄一一业且, CategoryNames 丁丂专业丁丅丅丈丙)
    {
        UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "ArmoryInfoScreen"));
        this.<七且丆丙丌丞丂丘丗>k__BackingField = val_2;
        val_2.parent = this.rentScreenPoint;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.<七且丆丙丌丞丂丘丗>k__BackingField.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.<七且丆丙丌丞丂丘丗>k__BackingField.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        ArmoryInfoScreenController val_5 = this.<七且丆丙丌丞丂丘丗>k__BackingField.GetComponent<ArmoryInfoScreenController>();
        this.上三不丑业七不万上 = val_5;
        val_5.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  丁丂专业丁丅丅丈丙), 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    private void 丘丆上世丝业丛东世()
    {
        var val_31;
        var val_32;
        var val_33;
        T val_34;
        var val_35;
        if(this.itemsWrapContainer.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        T[] val_3 = this.丝丟丐丁丌丛丞东专<ArmoryCell>(丟丝七七一丁丏丏丙:  false);
        val_31 = "mod_";
        val_32 = 0;
        val_33 = 0;
        goto label_4;
        label_22:
        val_34 = val_3[0];
        if((((val_34 != 0) && (val_34.Category == 220000)) && (val_34.ItemId != null)) && ((val_34.ItemId.StartsWith(value:  "mod_", comparisonType:  4)) != false))
        {
                val_34 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  val_34.ItemId);
            if((val_34 != null) && (null == null))
        {
                if(val_34.丆丒七丈丅且丂丒丑() != true)
        {
                val_34.且且丛世丟丈世丄丄(丙业与丙丗丝不丈东:  true);
            val_33 = 1;
        }
        
        }
        
        }
        
        val_32 = 1;
        label_4:
        if(val_32 < val_3.Length)
        {
            goto label_22;
        }
        
        if(val_3.Length >= 1)
        {
                val_35 = 0;
            do
        {
            if((((val_3[0] != 0) && ((val_3[0x0] + 32.IsFullyVisible) != false)) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3[0x0] + 32.ItemId)) != true)) && ((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  val_3[0x0] + 32.ItemId)) != true))
        {
                val_35 = val_35 + (丆丞丐三与丞专丈丌.丅专丌丆丘丗万不上(丞一丁业丄一一业且:  val_3[0x0] + 32.ItemId));
            if((val_3[0x0] + 32.Category) == 240000)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_3[0x0] + 32.ItemId)) != false)
        {
                bool val_30 = this.丅丐丄专丏世丝七丞.Add(item:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_3[0x0] + 32.ItemId).业东丅东丌上丗丑不());
        }
        
        }
        
        }
        
            val_34 = 0 + 1;
        }
        while(val_34 < val_3.Length);
        
        }
        else
        {
                val_35 = 0;
        }
        
        if(val_33 <= 0)
        {
                if(val_35 < 1)
        {
                return;
        }
        
        }
        
        this.一丛丈上且不丟丑万();
    }
    private void LateUpdate()
    {
        object val_6;
        丙且上东下丏丏丟下 val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        int val_29;
        var val_30;
        val_23 = 1152921505261211648;
        val_24 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_23;
        }
        
        if(this.一世丏丏丆专与丐丞 != false)
        {
                this.一世丏丏丆专与丐丞 = false;
            this.gridScrollView.DisableSpring();
            bool val_2 = this.gridScrollView.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  true);
            UIPanel val_3 = this.gridScrollView.GetComponent<UIPanel>();
            if(val_3 != null)
        {
                val_3.SetDirty();
        }
        else
        {
                val_3.SetDirty();
        }
        
            val_3.Refresh();
        }
        
        if(this.东且丅丏三下下丂万 == true)
        {
            goto label_10;
        }
        
        this.AdjustCategoryGridCells();
        this.东且丅丏三下下丂万 = true;
        val_25 = null;
        val_25 = null;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_17:
        if((128150528 & 1) == 0)
        {
            goto label_15;
        }
        
        val_6.丐丏七丌丕丗业且上().ResetAndUpdateAnchors();
        goto label_17;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        this.armoryRootPanel.Refresh();
        label_10:
        if(this.专丏丒世丄且业三丕 >= 1)
        {
                bool val_8 = this.gridScrollView.RestrictWithinBounds(丌丝丌丁下丐丞丆一:  true);
            int val_22 = this.专丏丒世丄且业三丕;
            val_22 = val_22 - 1;
            this.专丏丒世丄且业三丕 = val_22;
        }
        
        label_23:
        if(this.万世丛三万丘丙丗丘 != false)
        {
                UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.丞与丑丛丙丅万世世());
            this.万世丛三万丘丙丗丘 = false;
        }
        
        val_26 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_27 = null;
            val_27 = null;
            val_29 = ShopNGUIController.丟与丌三世丂下丗万;
            if(val_29 >= 1)
        {
                val_29 = ShopNGUIController.丟与丌三世丂下丗万;
            val_29 = val_29 - 1;
            ShopNGUIController.丟与丌三世丂下丗万 = val_29;
            this.丟丙且丝万与不丑丐();
        }
        
        }
        
        if(this.丈丌丐丄丆丑业专七 == false)
        {
                return;
        }
        
        val_30 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
            if(((ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0) && (ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy != false)) && (ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三() != null))
        {
                val_23 = this.且丛丌丌七丈丝丒丈;
            if((System.String.op_Inequality(a:  ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丈丒丛东上丘丅世三().业上丙丞丐丄丆丅七(), b:  val_23.业上丙丞丐丄丆丅七())) != false)
        {
                ArmoryInfoScreenController.丄丞丁丈与业上丞丟.丞丏世丆丄上丆一七();
        }
        
        }
        
        }
        
        this.丈丌丐丄丆丑业专七 = false;
    }
    public void HandleEscape()
    {
        var val_23;
        var val_24;
        var val_25;
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() != false)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
                return;
        }
        
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ProfileController.丑七不且上丗丁一世() != 0)
        {
                if(ProfileController.丑七不且上丗丁一世().InterfaceEnabled == true)
        {
                return;
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_24 = null;
            val_24 = null;
            if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  220)) != true)
        {
                if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  164)) == false)
        {
            goto label_36;
        }
        
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        label_48:
        UnityEngine.Debug.Log(message:  "Ignoring [Escape] since Tutorial is not completed.");
        return;
        label_36:
        val_25 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                this.万世丛三万丘丙丗丘 = true;
            this.万丞丂三下世丌丑丗 = true;
            return;
        }
        
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        string val_22 = this.GetType() + ".LateUpdate():    Ignoring Escape because Shop GUI is not active."(".LateUpdate():    Ignoring Escape because Shop GUI is not active.");
        goto label_48;
    }
    internal void 丞上下与上丙不丈万()
    {
        this.万世丛三万丘丙丗丘 = true;
        this.万丞丂三下世丌丑丗 = true;
    }
    internal void 丝丞与丄丆业丛丏专(bool 丗丛不丁丑专专丂且)
    {
        this.丁丝丁上丂上专丐业 = 丗丛不丁丑专专丂且;
    }
    private System.Collections.IEnumerator 丙与丁东丕丂丅且丒()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ShopNGUIController.丞丘业丆且丁且丘丟(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 七丟与下丅上丈东业(bool 下丈丝丁丟下世丐丒)
    {
        var val_25;
        var val_26;
        CharacterInterfaceV2 val_27;
        var val_28;
        var val_29;
        丙且上东下丏丏丟下 val_30;
        var val_31;
        this.丘丌丞丑业丑丗上丟.三丞丕丝业东上丅且(丕丁下丌不万丅丞丛:  System.String.alignConst);
        bool val_2 = 下丈丝丁丟下世丐丒;
        this.丏丄丑一丞丟一上丂(上丈专丌万丕丙万丘:  丘丕万丁丞业七丛与.东专丑三丕业世业丈(), 下丈丝丁丟下世丐丒:  val_2);
        this.且丞丕丙七丙丏下丐(丈丐丕业下丟业丛一:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  9), 下丈丝丁丟下世丐丒:  val_2);
        this.丕三丘丐丄一丅一丏(上世丘丐东万丐丆不:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  10), 下丈丝丁丟下世丐丒:  val_2);
        this.且三丆一丁丛丝专世(丟世丟丐且丐丟七上:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  12), 下丈丝丁丟下世丐丒:  val_2);
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  this.<与一丐丟丗三一东丂>k__BackingField)) == true)
        {
            goto label_8;
        }
        
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_10;
        }
        
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 190000)
        {
                if((this.且丛丌丌七丈丝丒丈 == null) || (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 180000))
        {
            goto label_10;
        }
        
        }
        
        label_8:
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_11;
        }
        
        val_25 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if(val_25 != 180000)
        {
            goto label_12;
        }
        
        val_26 = 1;
        val_25 = 131072;
        val_25 = 2;
        goto label_13;
        label_10:
        this.专世丘不一且丈丟东(与丙丕丛一丌丛丆丈:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7), 丒七丞丄丟且丂丆下:  0, 下丈丝丁丟下世丐丒:  下丈丝丁丟下世丐丒);
        string val_12 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        val_27 = "EMPTY_ROYALE_AVATAR";
        if((System.String.op_Equality(a:  val_12, b:  "EMPTY_ROYALE_AVATAR")) != true)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_12)) == false)
        {
            goto label_21;
        }
        
        }
        
        this.且丂丕丘不丂丏七三(丐丒丈丌与丈丏不上:  "EMPTY_ROYALE_AVATAR");
        val_28 = null;
        val_28 = null;
        this.丈丝专万丑丏丟一世(且丘世丏丛丛万丟万:  SkinsController.丂下丅丑丗一不东丘);
        goto label_24;
        label_11:
        val_25 = 131072;
        val_25 = 2;
        label_12:
        this.丘丌丞丑业丑丗上丟.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  0);
        val_26 = 0;
        label_13:
        val_27 = this.丘丌丞丑业丑丗上丟;
        val_27.丌下丅七丅丟丏且丄(世丐丗专丅三丝丑丆:  0);
        if((160000 != 160000) && (160000 != 200000))
        {
                if(160000 != 210000)
        {
            goto label_29;
        }
        
        }
        
        if(val_26 != 0)
        {
            goto label_30;
        }
        
        goto label_48;
        label_29:
        if((val_26 & 1) == 0)
        {
            goto label_32;
        }
        
        label_30:
        this.丆三下上一丌世且专();
        label_48:
        if(160000 == 190000)
        {
            goto label_33;
        }
        
        if(160000 != 210000)
        {
                if(160000 != 200000)
        {
            goto label_35;
        }
        
        }
        
        val_27 = this.丘丌丞丑业丑丗上丟;
        val_29 = null;
        val_29 = null;
        val_27.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        label_35:
        this.且丂丕丘不丂丏七三(丐丒丈丌与丈丏不上:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈());
        if(160000 == 200000)
        {
            goto label_41;
        }
        
        label_33:
        this.一万业丏丛专丄丞丞(丅丗万丛丈不三丒丏:  System.String.alignConst);
        if(160000 == 210000)
        {
                return;
        }
        
        label_41:
        this.不丅七不丄丝丄丝丑(丄丄丄丕丂东丈丞丐:  System.String.alignConst);
        return;
        label_32:
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  WeaponManager.七丄丄业丛万丄下上()).与不丞丑七丘丁丂丛(), 丅专丕三且丑丘专下:  0);
        goto label_48;
        label_21:
        this.且丂丕丘不丂丏七三(丐丒丈丌与丈丏不上:  val_12);
        label_24:
        this.丗世专丅丘丗世丛丗(丁且业丁丞下丕丄不:  System.String.alignConst);
        this.一万业丏丛专丄丞丞(丅丗万丛丈不三丒丏:  System.String.alignConst);
        this.不丅七不丄丝丄丝丑(丄丄丄丕丂东丈丞丐:  System.String.alignConst);
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_49;
        }
        
        val_30 = this.且丛丌丌七丈丝丒丈;
        var val_20 = (this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 6) ? 1 : 0;
        if(val_30 == null)
        {
            goto label_51;
        }
        
        var val_22 = (val_30.丒万丕七专不丏丞丌() == 2100) ? 1 : 0;
        goto label_51;
        label_49:
        val_31 = 0;
        val_30 = 0;
        label_51:
        val_30 = val_30 | val_31;
        if(val_30 != 0)
        {
                this.丆三下上一丌世且专();
        }
        
        this.丈丕上不且世专且七(上东丞世三世且丈丌:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏());
    }
    private void 三丈世丌丄不丈上不()
    {
        var val_9;
        var val_10;
        上丄丂丛专下丟万下 val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        SetActive(value:  true);
        val_10 = null;
        val_10 = null;
        if(ExperienceController.sharedController != 0)
        {
                if(ExpController.丑七不且上丗丁一世() != 0)
        {
                ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        this.七丟与下丅上丈东业(下丈丝丁丟下世丐丒:  false);
        val_11 = System.Delegate.Combine(a:  this.carouselCenter.onFinished, b:  new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ShopNGUIController::丞世与与丆一与丗上()));
        if(this.carouselCenter == null)
        {
            goto label_19;
        }
        
        if(val_11 != null)
        {
            goto label_20;
        }
        
        goto label_23;
        label_19:
        if(val_11 == null)
        {
            goto label_23;
        }
        
        label_20:
        if(null != null)
        {
                val_11 = 0;
        }
        
        label_23:
        this.carouselCenter.onFinished = val_11;
        丅且东丙业丏丛东丛.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丗丆丒丘万丈丂丑丞()));
        this.不丈丛专丞一万下丑();
        val_12 = null;
        val_12 = null;
        enabled = true;
        this.专丄丕丗与上丟七丅();
    }
    internal void 不丈丛专丞一万下丑()
    {
        string val_3;
        if(this.丘丌丞丑业丑丗上丟 != null)
        {
                val_3 = this.丘丌丞丑业丑丗上丟.世不业丂三七丗与丟();
        }
        else
        {
                val_3 = 0.世不业丂三七丗与丟();
        }
        
        this.丘丌丞丑业丑丗上丟.业不丛不丞七丕东世(七不丐下丟专业万丅:  val_3);
        this.专东丁丙丞丂东丝丁();
    }
    private void 丂丐世丑丝丅丝丁丑()
    {
        this.丌丛丕专丝丁万专丆().ForEach(action:  new System.Action<BaseArmoryCell>(object:  this, method:  System.Void ShopNGUIController::丞世一丄丆七丝丅业(BaseArmoryCell 丆丌丏丞丄丈万丒丁)));
    }
    private void 丞世一丄丆七丝丅业(BaseArmoryCell 丆丌丏丞丄丈万丒丁)
    {
        if(丆丌丏丞丄丈万丒丁 == null)
        {
                return;
        }
        
        this.丄万与丂丐下丆丁丂(丆丌丏丞丄丈万丒丁:  丆丌丏丞丄丈万丒丁);
    }
    private void 丕与丈上专丒丐丟丒(System.Collections.Generic.List<CategoryNames> 与丑丕一丁丞丟与丕)
    {
        var val_25;
        var val_26;
        var val_27;
        var val_30;
        var val_31;
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_25 = 1152921504691191808;
        val_26 = 1152921505294970880;
        val_27 = this.丂下且丏业丕东丛万().GetEnumerator();
        label_25:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_27.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        T val_7 = val_27.Current;
        UIButton val_8 = val_7.GetComponent<UIButton>();
        object val_11 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_7.name);
        var val_13 = (~(与丑丕一丁丞丟与丕.Contains(item:  null))) & 1;
        goto label_25;
        label_11:
        val_30 = 0;
        val_31 = 0;
        if(val_27 == null)
        {
            
        }
        else
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_27.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_27 = ???;
        val_30 = ???;
        val_25 = ???;
        val_26 = ???;
    }
    private void 专丄丕丗与上丟七丅()
    {
        var val_20;
        System.Func<BtnCategory, System.Boolean> val_22;
        var val_23;
        System.Func<BtnCategory, System.Boolean> val_25;
        var val_26;
        System.Func<BtnCategory, System.Boolean> val_28;
        var val_29;
        val_20 = null;
        val_20 = null;
        val_22 = ShopNGUIController.<>c.<>9__469_0;
        if(val_22 == null)
        {
                val_22 = null;
            val_22 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::丗世丞业丑丛丌丆业(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__469_0 = val_22;
        }
        
        System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  this.superCategoriesButtonController.buttons, predicate:  null).GetComponent<UnityEngine.BoxCollider>().enabled = 上丑三丁丄丛丁万丑.不三丛丂世且丗丑东();
        val_23 = null;
        val_23 = null;
        val_25 = ShopNGUIController.<>c.<>9__469_1;
        if(val_25 == null)
        {
                val_25 = null;
            val_25 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::东上丝世丕丛世下专(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__469_1 = val_25;
        }
        
        System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  this.superCategoriesButtonController.buttons, predicate:  null).GetComponent<UnityEngine.BoxCollider>().enabled = 上丑三丁丄丛丁万丑.且丕不且丆东专三下();
        val_26 = null;
        val_26 = null;
        val_28 = ShopNGUIController.<>c.<>9__469_2;
        if(val_28 == null)
        {
                val_28 = null;
            val_28 = new System.Func<BtnCategory, System.Boolean>(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ShopNGUIController.<>c::且丗丌丆丙丁丝七丞(BtnCategory 东丁丈且丌丄七专三));
            ShopNGUIController.<>c.<>9__469_2 = val_28;
        }
        
        System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  this.superCategoriesButtonController.buttons, predicate:  null).GetComponent<UnityEngine.BoxCollider>().enabled = 上丑三丁丄丛丁万丑.不丛丟丗丐丄丒丑丄();
        val_29 = null;
        val_29 = null;
        this.丕与丈上专丒丐丟丒(与丑丕一丁丞丟与丕:  System.Linq.Enumerable.ToList<CategoryNames>(source:  System.Linq.Enumerable.Where<CategoryNames>(source:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Keys, predicate:  new System.Func<CategoryNames, System.Boolean>(object:  0, method:  static System.Boolean 上丑三丁丄丛丁万丑::丄丏不丄不东下一不(CategoryNames 七丆丒与丗丌丄且丂)))));
    }
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        var val_2 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        ShopNGUIController.且丐丛专与三且万且();
    }
    internal void 丝丝不丛且三丏丁丗(bool 丗丛不丁丑专专丂且)
    {
        bool val_3;
        var val_52;
        var val_54;
        var val_55;
        bool val_56;
        System.Collections.Generic.IEnumerable<T> val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        if(丗丛不丁丑专专丂且 == false)
        {
            goto label_1;
        }
        
        val_52 = null;
        val_52 = null;
        List.Enumerator<T> val_1 = ShopNGUIController.丟丌丞万丕万丐丐上.GetEnumerator();
        val_54 = 1152921524440491584;
        val_55 = 1152921504848912384;
        label_15:
        if((130739632 & 1) == 0)
        {
            goto label_5;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_15;
        }
        
        val_4.enabled = true;
        UICamera val_6 = val_4.GetComponent<UICamera>();
        if(val_6 == 0)
        {
            goto label_15;
        }
        
        val_6.enabled = true;
        goto label_15;
        label_1:
        if(UnityEngine.Camera.allCameras != null)
        {
                val_56 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  UnityEngine.Camera.allCameras);
        }
        else
        {
                System.Collections.Generic.List<UnityEngine.Camera> val_11 = null;
            val_56 = val_11;
            val_11 = new System.Collections.Generic.List<UnityEngine.Camera>();
        }
        
        bool val_12 = 丗丛不丁丑专专丂且;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(ProfileController.丑七不且上丗丁一世() == 0)
        {
                object[] val_16 = new object[1];
            val_3 = val_12;
            val_16[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherC_amerasEnabled({0}): ProfileCo_ntroller.Instance == null", args:  val_16);
        }
        
        }
        
        if(ProfileController.丑七不且上丗丁一世() == 0)
        {
            goto label_36;
        }
        
        val_57 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  ProfileController.丑七不且上丗丁一世().GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
        if(val_56 != null)
        {
            goto label_42;
        }
        
        goto label_41;
        label_36:
        System.Collections.Generic.List<UnityEngine.Camera> val_22 = null;
        val_57 = val_22;
        val_22 = new System.Collections.Generic.List<UnityEngine.Camera>();
        if(val_56 != null)
        {
            goto label_42;
        }
        
        label_41:
        label_42:
        val_11.AddRange(collection:  val_22);
        val_58 = 1152921505261211648;
        System.Collections.Generic.List<UnityEngine.Camera> val_23 = ShopNGUIController.且不下丙丛丛丄丈东();
        if(val_56 != null)
        {
                val_11.AddRange(collection:  val_23);
        }
        else
        {
                val_11.AddRange(collection:  val_23);
        }
        
        List.Enumerator<T> val_24 = val_11.GetEnumerator();
        val_59 = 1152921505719563712;
        val_55 = 1152921505175109632;
        label_129:
        if((130739632 & 1) == 0)
        {
            goto label_47;
        }
        
        string val_25 = val_3.丐丏七丌丕丗业且上();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(val_25 == 0)
        {
                object[] val_28 = new object[1];
            val_3 = val_12;
            val_28[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherC_amerasEnabled({0}): c == null", args:  val_28);
            val_60 = val_59;
            val_58 = val_58;
        }
        
        }
        
        if(val_25 == 0)
        {
            goto label_129;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if((ExpController.丑七不且上丗丁一世().丙上世与丁丙丘丞丗(丁丂专业丁丅丅丈丙:  val_25)) == true)
        {
            goto label_129;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(val_25.gameObject == 0)
        {
                object[] val_37 = new object[1];
            val_3 = val_12;
            val_37[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCa_merasEnabled({0}): c.gameObject == null", args:  val_37);
            val_60 = val_60;
            val_58 = val_58;
        }
        
        }
        
        if(val_25.gameObject != 0)
        {
                if((val_25.gameObject.CompareTag(tag:  "CamTemp")) == true)
        {
            goto label_129;
        }
        
        }
        
        val_61 = null;
        if((Contains(item:  val_25)) == true)
        {
            goto label_129;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                object[] val_46 = new object[1];
            val_3 = val_12;
            val_46[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCamer_asEnabled({0}): InfoWindowC_ontroller.Instance == null", args:  val_46);
            val_58 = val_58;
        }
        
        }
        
        if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
            goto label_115;
        }
        
        InfoWindowController val_49 = InfoWindowController.丑七不且上丗丁一世();
        if(val_49.infoWindowCamera == val_25)
        {
            goto label_129;
        }
        
        label_115:
        val_62 = null;
        ShopNGUIController.丟丌丞万丕万丐丐上.Add(item:  val_25);
        val_25.enabled = false;
        UICamera val_50 = val_25.GetComponent<UICamera>();
        if(val_50 == 0)
        {
            goto label_129;
        }
        
        val_50.enabled = false;
        goto label_129;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_169;
        label_47:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_169:
        System.Collections.Generic.List<T>._emptyArray.__il2cppRuntimeField_20.Clear();
    }
    private static void 且丐丛专与三且万且()
    {
        null = null;
        UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        ShopNGUIController.丏丙丅丕一丑丕丑丑.__unknownFiledOffset_12C = 0;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.与丕专丛世丛丅丒东
        mem2[0] = 0;
        bool val_3 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        ShopNGUIController.丏丙丅丕一丑丕丑丑.专丆丐丙丒丌七东丙 = 0;
        UnityEngine.Color val_4 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
        PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
    }
    public void AdjustCategoryGridCells()
    {
        if(this.miscCategoriesGrid == null)
        {
            
        }
    
    }
    internal void 丐丟丆世三七丏丐下(丙且上东下丏丏丟下 与丝丕与丙不与丗丆)
    {
        this.专丑下东丙丞丏七丄 = 与丝丕与丙不与丗丆;
    }
    private void 业丘三一丘丂不东七()
    {
        UnityEngine.GameObject val_1 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Character_model_V2");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
        this.丘丌丞丑业丑丗上丟 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_1).GetComponent<CharacterInterfaceV2>();
        UnityEngine.Vector3 val_6 = this.characterPoint.localPosition;
        UnityEngine.Vector3 val_7 = this.characterPoint.localPosition;
        float val_14 = (float)UnityEngine.Screen.width;
        val_14 = val_14 / (float)UnityEngine.Screen.height;
        val_14 = val_14 + (-1.333f);
        val_14 = val_14 * 0.927f;
        val_14 = val_14 + (-0.99f);
        this.characterPoint.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.丘丌丞丑业丑丗上丟.transform.SetParent(parent:  this.characterPoint.GetChild(index:  0), worldPositionStays:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丘丌丞丑业丑丗上丟, 丏业丟一东丂东丘丛:  true);
        this.丘丌丞丑业丑丗上丟.丟且丟七丌丞专七丁();
        this.丘丌丞丑业丑丗上丟.丅丑世七丙东东丒丁(丙业与丙丗丝不丈东:  1);
        this.丘丌丞丑业丑丗上丟.世丙丆下丝业丈三丒(丄上丐不专丁丄丏丐:  this.animationCoroutineRunner);
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.丘丌丞丑业丑丗上丟.gameObject);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丘丌丞丑业丑丗上丟.gameObject, 不东丛三丂丌丑专丆:  this.characterPoint.gameObject.layer);
    }
    private void 丅丞丂丗一丂丗丕东()
    {
        var val_123;
        var val_124;
        var val_125;
        var val_126;
        System.Collections.Generic.List<UnityEngine.Transform> val_127;
        var val_128;
        var val_129;
        var val_130;
        var val_131;
        string val_132;
        var val_133;
        UIButton val_134;
        var val_135;
        var val_136;
        val_123 = this;
        丕丈丏丝丗下丟丅丂 val_87 = 0;
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
                return;
        }
        
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 170000)
        {
                if((this.<与一丐丟丗三一东丂>k__BackingField) != 141000)
        {
            goto label_3;
        }
        
        }
        
        val_124 = 1152921519067103504;
        val_125 = 2;
        goto label_5;
        label_3:
        bool val_2 = 上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌());
        if(this.且丛丌丌七丈丝丒丈 == null)
        {
            goto label_8;
        }
        
        if(val_2 == false)
        {
            goto label_9;
        }
        
        label_34:
        if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) != 2)
        {
                三丅丁丗丗丝丂万且 val_6 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
            if(val_6.与丕丒世七丁万丂丛() != false)
        {
                if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_20;
        }
        
        }
        
        }
        
        label_99:
        label_118:
        if(this.buttonContainers != null)
        {
            goto label_193;
        }
        
        label_194:
        label_193:
        val_124 = 1152921519067103504;
        val_125 = 2;
        label_5:
        UnityEngine.Transform val_9 = this.buttonContainers.Item[2];
        this.equipped.transform.parent = val_9;
        UnityEngine.Transform val_11 = this.equipButton.transform;
        if(val_11 != null)
        {
            goto label_136;
        }
        
        label_137:
        label_136:
        label_89:
        val_11.parent = val_9;
        label_195:
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        this.equipped.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        this.equipButton.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        val_123 = this.unequipButton.transform;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        val_123.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        return;
        label_8:
        if(val_2 == true)
        {
            goto label_34;
        }
        
        label_9:
        CategoryNames val_20 = this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌();
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_38;
        }
        
        string val_21 = this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七();
        if(val_20 != 7)
        {
            goto label_40;
        }
        
        if((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  val_21)) == 2)
        {
            goto label_195;
        }
        
        int val_24 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        int val_26 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_24);
        if(val_26 < 1)
        {
            goto label_50;
        }
        
        var val_28 = (val_26 == (BalanceController.丄东且世丛丈丒丁丄(丞世不丒下上上丝丑:  val_24))) ? (1 + 1) : 1;
        goto label_53;
        label_38:
        if(val_20 != 8)
        {
            goto label_55;
        }
        
        if((System.String.op_Equality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  "CustomSkinID")) != true)
        {
                if((System.Linq.Enumerable.Contains<System.String>(source:  SkinsController.丙丂丌丏丑且丛不七(), value:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_60;
        }
        
        }
        
        this.equipped.transform.parent = this.buttonContainers.Item[1];
        val_127 = this.buttonContainers;
        val_128 = this.equipButton.transform;
        val_129 = public UnityEngine.Transform System.Collections.Generic.List<UnityEngine.Transform>::get_Item(int index);
        val_130 = 1;
        goto label_66;
        label_40:
        if((System.String.op_Equality(a:  val_21, b:  "cape_Custom")) == false)
        {
            goto label_67;
        }
        
        this.equipped.transform.parent = this.buttonContainers.Item[1];
        this.equipButton.transform.parent = this.buttonContainers.Item[0];
        val_128 = this.unequipButton.transform;
        val_129 = public UnityEngine.Transform System.Collections.Generic.List<UnityEngine.Transform>::get_Item(int index);
        val_130 = 0;
        goto label_183;
        label_55:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 2000)
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 30000)
        {
            goto label_79;
        }
        
        }
        
        label_172:
        this.equipped.transform.parent = this.buttonContainers.Item[0];
        label_198:
        this.equipButton.transform.parent = this.buttonContainers.Item[2];
        if(this.unequipButton != null)
        {
            goto label_161;
        }
        
        label_162:
        label_161:
        val_127 = this.buttonContainers;
        val_128 = this.unequipButton.transform;
        val_129 = public UnityEngine.Transform System.Collections.Generic.List<UnityEngine.Transform>::get_Item(int index);
        val_130 = 2;
        label_66:
        label_183:
        UnityEngine.Transform val_50 = val_127.Item[2];
        if(val_128 != null)
        {
            goto label_89;
        }
        
        goto label_89;
        label_20:
        丕丑丙丑丙东丌丘丕 val_53 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_6.业东丅东丌上丗丑不());
        if(val_53 == null)
        {
            goto label_118;
        }
        
        丕丑丙丑丙东丌丘丕 val_54 = BalanceController.丌丛丄丙丘丈与下专(丞丌东丟且丒丐丑丂:  val_53, 丐丏上业丈丂与万丞:  false);
        if(val_53.丈专七丐上一业世丕() == false)
        {
            goto label_118;
        }
        
        if((val_53.七东与丄丕丁丛世三() < 2) || (val_53.七东与丄丕丁丛世三() > 4))
        {
            goto label_99;
        }
        
        val_131 = null;
        val_131 = null;
        var val_58 = (BalanceController.丕业丒不与丗丅七一 == false) ? (1 + 1) : 1;
        goto label_118;
        label_67:
        val_132 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        if(val_132 != null)
        {
                val_132 = System.String.op_Inequality(a:  WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()), b:  val_132);
        }
        
        val_133 = 1152921519067103504;
        this.equipped.transform.parent = this.buttonContainers.Item[val_132];
        this.unequipButton.transform.parent = this.buttonContainers.Item[(val_132 == true) ? 0 : 2];
        val_134 = this.equipButton;
        if(val_134 != null)
        {
            goto label_134;
        }
        
        goto label_117;
        label_79:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 25000)
        {
            goto label_120;
        }
        
        PetInfo val_72 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count) < 1)
        {
            goto label_125;
        }
        
        if(val_72 == null)
        {
            goto label_126;
        }
        
        val_135 = val_72.CurrentLevel;
        goto label_127;
        label_50:
        val_126 = 1;
        label_53:
        val_133 = 1152921519067103504;
        this.equipped.transform.parent = this.buttonContainers.Item[1];
        this.equipButton.transform.parent = this.buttonContainers.Item[1];
        val_134 = this.unequipButton;
        if(val_134 != null)
        {
            goto label_134;
        }
        
        label_117:
        label_134:
        UnityEngine.Transform val_82 = this.buttonContainers.Item[1];
        if(val_134.transform != null)
        {
            goto label_136;
        }
        
        goto label_137;
        label_120:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_141;
        }
        
        bool val_88 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), value: out  val_87);
        if(val_87 == 0)
        {
            goto label_195;
        }
        
        int val_123 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_87.业东丅东丌上丗丑不());
        val_123 = ((val_123 == (BalanceController.丈丅三丙东丕东下丐(丞世不丒下上上丝丑:  val_87.业东丅东丌上丗丑不()))) ? 1 : 0) << 1;
        if(this.buttonContainers != null)
        {
            goto label_193;
        }
        
        goto label_194;
        label_141:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 140000)
        {
            goto label_157;
        }
        
        label_60:
        this.equipped.transform.parent = this.buttonContainers.Item[2];
        if(this.equipButton != null)
        {
            goto label_161;
        }
        
        goto label_162;
        label_125:
        val_136 = 0;
        goto label_163;
        label_157:
        if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 180000)
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 190000)
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() != 200000)
        {
            goto label_169;
        }
        
        }
        
        }
        
        UnityEngine.Transform val_101 = this.equipped.transform;
        if(this.buttonContainers != null)
        {
            goto label_172;
        }
        
        goto label_172;
        label_126:
        val_135 = 0.CurrentLevel;
        label_127:
        var val_105 = (val_135 == (BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  val_72.Index))) ? 1 : 0;
        label_163:
        this.equipped.transform.parent = this.buttonContainers.Item[1];
        this.equipButton.transform.parent = this.buttonContainers.Item[(val_105 != 0) ? (1 + 1) : 1];
        UnityEngine.Transform val_111 = this.unequipButton.transform;
        var val_112 = val_105 << 1;
        if(this.buttonContainers != null)
        {
            goto label_183;
        }
        
        goto label_183;
        label_169:
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌())) == false)
        {
            goto label_188;
        }
        
        var val_121 = ((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) != true) ? (((丛且丗丌丏下七下丈.丁专丌丕丕七一下丛(丞一丁业丄一一业且:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七())) != true) ? (1 + 1) : 1) : 2;
        if(this.buttonContainers != null)
        {
            goto label_193;
        }
        
        goto label_194;
        label_188:
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 240000)
        {
            goto label_195;
        }
        
        UnityEngine.Transform val_122 = this.equipButton.transform;
        if(this.buttonContainers != null)
        {
            goto label_198;
        }
        
        goto label_198;
    }
    public void HandleLayoutChangeFastButton()
    {
        if((this.<丌世专万丞不丞丒与>k__BackingField) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "HandleLayou_tChang_eFast_Button: IsExiting", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void ShopNGUIController::丙且丆丅丄业东一丁()))) != false)
        {
                return;
        }
        
        this.丙且丆丅丄业东一丁();
    }
    private void 七丘上丆与丝七与丂()
    {
        this.丞丘丒与上丄丗上一(丌丝万上丅丒一丈丘:  0);
    }
    private void 与丏丈丏万三且丟丂()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGalleryTapOnGun, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGalleryTapOnWeaponsCategory, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丞丘丒与上丄丗上一(UnityEngine.Transform 丌丝万上丅丒一丈丘)
    {
        var val_8;
        var val_9;
        var val_10;
        if((PGCompany.MainMenuMainPanel.丞丅与上上丁丛丟丆() == false) || (AlmanachTutorialManager.TutorialFinished == true))
        {
            goto label_22;
        }
        
        val_8 = null;
        val_8 = null;
        if((ShopNGUIController.东丁丝丝丘且丌丅丗 == true) || (上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false))
        {
            goto label_22;
        }
        
        val_9 = null;
        val_9 = null;
        if((ShopNGUIController.丞业丙三丙丄丏丞丘 == false) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  164)) == false))
        {
            goto label_22;
        }
        
        val_10 = null;
        val_10 = null;
        if(PGCompany.ModuleInsertPanel.东丅丞丁丗万且丁丗 == false)
        {
            goto label_18;
        }
        
        label_22:
        this.与丏丈丏万三且丟丂();
        label_28:
        label_25:
        this.丟丞下不丙丒丝上一 = 0;
        return;
        label_18:
        if(this.丙丛丝丝丁不丁丗丘() != 1)
        {
            goto label_19;
        }
        
        if(丌丝万上丅丒一丈丘 == 0)
        {
            goto label_22;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGalleryTapOnGun, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGalleryTapOnWeaponsCategory, 丏业丟一东丂东丘丛:  false);
        goto label_25;
        label_19:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGalleryTapOnGun, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintGalleryTapOnWeaponsCategory, 丏业丟一东丂东丘丛:  true);
        goto label_28;
    }
    private void 丙且丆丅丄业东一丁()
    {
        PGCompany.三东丏不丗世丅丌丄 val_16;
        UnityEngine.GameObject val_17;
        var val_18;
        System.Action val_20;
        var val_21;
        var val_22;
        ShopNGUIController.丈丝丏丄丗世丄七一 val_1 = new ShopNGUIController.丈丝丏丄丗世丄七一();
        .丝且与丝丒丟万丁专 = this;
        丈丞丕丘丕丗与上一 val_2 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  8, 丞一丁业丄一一业且:  "CustomSkinID", 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        .丒世丘丘上丆丝东丞 = val_2;
        int val_3 = val_2.丟丂丞不专丆万丒世();
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() == false)
        {
            goto label_7;
        }
        
        val_16 = (ShopNGUIController.丈丝丏丄丗世丄七一)[1152921539100471952].丒世丘丘上丆丝东丞.与丒上与丄丒丝三七();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_16, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_10;
        }
        
        label_7:
        val_17 = this.mainPanel;
        System.Action val_11 = null;
        val_16 = val_11;
        val_11 = new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丈丝丏丄丗世丄七一::丅世丒丄万七丕且丈());
        val_18 = null;
        val_18 = null;
        val_20 = ShopNGUIController.<>c.<>9__483_2;
        if(val_20 == null)
        {
                System.Action val_12 = null;
            val_20 = val_12;
            val_12 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丗丟下丐丐不东丄丅());
            ShopNGUIController.<>c.<>9__483_2 = val_20;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_17, 丒世丘丘上丆丝东丞:  (ShopNGUIController.丈丝丏丄丗世丄七一)[1152921539100471952].丒世丘丘上丆丝东丞, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丈丝丏丄丗世丄七一::业一丄丑丙丗东丈一()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  val_11, 丞丐下东与丅万丅丁:  val_12, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  103);
        return;
        label_10:
        UnityEngine.Debug.LogError(message:  "Arsenal (create custom skin) -> GoToMainStore");
        this.丁七丁丞丞丟丒业丅 = this.且丛丌丌七丈丝丒丈;
        this.丌不丒万万丟丞上与 = this.<与一丐丟丗三一东丂>k__BackingField;
        this.丕丏丑丏丏丂与东丏 = ShopNGUIController.丛丐丛专丟丞万三七();
        val_21 = null;
        val_21 = null;
        val_22 = null;
        val_22 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万丛丝七丟世丐丄丛;
        val_20 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        val_17 = PGCompany.Analytics.丂与丏丕一丒与丁丙.万丛丝七丟世丐丄丛;
        val_20.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  (ShopNGUIController.丈丝丏丄丗世丄七一)[1152921539100471952].丒世丘丘上丆丝东丞.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  val_17, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    private void 一业业七不业丈下丞()
    {
        if(this.bankShopView == 0)
        {
                return;
        }
        
        bool val_2 = 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        if(this.bankShopView == null)
        {
            goto label_6;
        }
        
        if(val_2 == false)
        {
            goto label_7;
        }
        
        label_9:
        this.bankShopView.InteractionEnabled = true;
        goto label_8;
        label_6:
        if(val_2 == true)
        {
            goto label_9;
        }
        
        label_7:
        this.bankShopView.InteractionEnabled = false;
        label_8:
        this.bankShopView.丝一丅丆三东丂丞七();
    }
    public void TurnOn()
    {
        var val_3;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丆一丂丕三丄丞丆上, 丏业丟一东丂东丘丛:  (this.专丂丏丟丙丂丘丛丟 == true) ? 1 : 0);
        val_3 = null;
        val_3 = null;
        MainMenuController.丄丞丁丈与业上丞丟.丐专丕丂丗丙丆丄丌(丑丝丏丂且不下一东:  this.丁七丁丞丞丟丒业丅, 一专七丟丏且丑丄下:  this.丌不丒万万丟丞上与, 丏丐世且丑丅丘丅丟:  0, 万且丟七不上丗丑丝:  false, 丄丕三丞一丌与与丅:  true, 专丆丌丛东一不丑丙:  this.丕丏丑丏丏丂与东丏, 丈丈不丒丗与丝不丗:  false, 丌丂丁七丏不丂丁上:  false);
        if(this.丁七丁丞丞丟丒业丅 == null)
        {
                return;
        }
        
        if(this.上三不丑业七不万上 == 0)
        {
                return;
        }
        
        if(this.丁七丁丞丞丟丒业丅 != this.且丛丌丌七丈丝丒丈)
        {
                return;
        }
        
        this.上三不丑业七不万上.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.丁七丁丞丞丟丒业丅, 丁业丗丈丂七丟东与:  false, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
    }
    public void TurnOff()
    {
        bool val_4;
        var val_5;
        var val_6;
        if(this.丆一丂丕三丄丞丆上 != 0)
        {
                val_4 = this.丆一丂丕三丄丞丆上.isActiveAndEnabled;
        }
        else
        {
                val_4 = false;
        }
        
        this.专丂丏丟丙丂丘丛丟 = val_4;
        val_5 = null;
        val_5 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.且业丛丕丑丗不不七();
        val_6 = null;
        val_6 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleResumeFromShopCore(丞七丅丏丁丘世丌丙:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    private void 丑丗丛不世丙丏丗丅()
    {
        UnityEngine.GameObject val_4;
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.loadout")) != false)
        {
                if(ShopNGUIController.丛丐丛专丟丞万三七() == 0)
        {
            goto label_4;
        }
        
        }
        
        val_4 = this._openLoadoutsButton;
        goto label_11;
        label_4:
        val_4 = this._openLoadoutsButton;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_15;
        }
        
        label_11:
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  false);
    }
    public void U_HandleOpenLoadouts()
    {
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        PGCompany.LoadoutsUi.下与丞三丅丛丄七丕(丈东丘丏与丌东东下:  this._loadoutsUiPoint);
    }
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    public void HandleHatchEgg()
    {
        if(PixelTime.丝丗专上三不丄丑丑() > 0)
        {
                Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丞丝下丄丆且丌丈丐(丈丕丁丘七丙丞不丙:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
            return;
        }
        
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
    }
    public void HandleInstantHatchEgg()
    {
        int val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        System.Action val_22;
        ShopNGUIController.丏丂丂丄七三东与三 val_1 = new ShopNGUIController.丏丂丂丄七三东与三();
        .丝且与丝丒丟万丁专 = this;
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_4;
        }
        
        PGCompany.丕下丆丑万世业丈丟 val_6 = new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()));
        .世丕丘丈丙世业东丕 = val_6;
        PGCompany.三东丏不丗世丅丌丄 val_7 = val_6.三丌世丕下丌业丕一();
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_15 = val_7.丂丁丏一丙丛业且丌();
        goto label_9;
        label_4:
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
        return;
        label_8:
        val_15 = 0.丂丁丏一丙丛业且丌();
        label_9:
        val_16 = null;
        if(val_7.不业丙丒丂丞下丆丙() == 1000)
        {
                val_17 = null;
            val_18 = 1152921505171281160;
        }
        else
        {
                val_19 = null;
            val_18 = 1152921505171281152;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = ShopNGUIController.<>c.<>9__500_2;
        if(val_22 == null)
        {
                System.Action val_14 = null;
            val_22 = val_14;
            val_14 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丐万七丄三东三丈丏());
            ShopNGUIController.<>c.<>9__500_2 = val_22;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.mainPanel, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_15, 丏丂不专上丘丂不丅:  val_18), 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丏丂丂丄七三东与三::一上丕专丆丁丅丑三()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丏丂丂丄七三东与三::丁丆丆业业上上丏万()), 丞丐下东与丅万丅丁:  val_14, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  257, 丐丈上丂与上丂丒丏:  130);
    }
    public void HandleSpeedupEgg()
    {
        int val_15;
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        System.Action val_22;
        ShopNGUIController.丞丈专下三三万丏丑 val_1 = new ShopNGUIController.丞丈专下三三万丏丑();
        .丝且与丝丒丟万丁专 = this;
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_4;
        }
        
        PGCompany.丕下丆丑万世业丈丟 val_6 = new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七()));
        .世丕丘丈丙世业东丕 = val_6;
        PGCompany.三东丏不丗世丅丌丄 val_7 = val_6.丈下丂丆不丕丐丌丂();
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_15 = val_7.丂丁丏一丙丛业且丌();
        goto label_9;
        label_4:
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
        return;
        label_8:
        val_15 = 0.丂丁丏一丙丛业且丌();
        label_9:
        val_16 = null;
        if(val_7.不业丙丒丂丞下丆丙() == 1000)
        {
                val_17 = null;
            val_18 = 1152921505171281160;
        }
        else
        {
                val_19 = null;
            val_18 = 1152921505171281152;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = ShopNGUIController.<>c.<>9__501_2;
        if(val_22 == null)
        {
                System.Action val_14 = null;
            val_22 = val_14;
            val_14 = new System.Action(object:  ShopNGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopNGUIController.<>c::丂丐丝丝丑且丈丌东());
            ShopNGUIController.<>c.<>9__501_2 = val_22;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.mainPanel, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_15, 丏丂不专上丘丂不丅:  val_18), 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丞丈专下三三万丏丑::丏丗丞丈万丛丌上丌()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  val_1, method:  System.Void ShopNGUIController.丞丈专下三三万丏丑::东丘丑丆丂丝丂下丕()), 丞丐下东与丅万丅丁:  val_14, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  258, 丐丈上丂与上丂丒丏:  131);
    }
    public void HandleSpeedupEggAds()
    {
        object val_22;
        var val_23;
        PGCompany.Ads.丂丐与不丘不下丂上 val_24;
        Rilisoft.ReusableRewardedVideo val_25;
        string val_9 = 0;
        ShopNGUIController.丒丈三丄丑东丈且七 val_1 = null;
        val_22 = val_1;
        val_1 = new ShopNGUIController.丒丈三丄丑东丈且七();
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
            goto label_3;
        }
        
        val_23 = null;
        if(ShopNGUIController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ShopNguiC.HandleSpeedupEggAds]");
        }
        
        if(val_22 == null)
        {
            goto label_9;
        }
        
        bool val_5 = this.一丑丄东丑上丄专丂(丛下丛下丑丞与世下: out  (ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].丛下丛下丑丞与世下);
        val_24 = (ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].丛下丛下丑丞与世下;
        goto label_10;
        label_3:
        InfoWindowController.丕丈与丒且丞丏业丗(且下丘丟丏丄丈丟万:  true, 丟丟丗专丅丝与三丝:  1f);
        return;
        label_9:
        bool val_7 = this.一丑丄东丑上丄专丂(丛下丛下丑丞与世下: out  48);
        val_24 = 0;
        label_10:
        val_25 = (ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].下丒丗丛丙丆丄丈专;
        if((val_24.丆下丟三丅丞业丝丘(下丒丗丛丙丆丄丈专: out  val_25, 丅丏七一且且世丘世: out  val_9)) != false)
        {
                bool val_11 = mem[(ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].下丒丗丛丙丆丄丈专].丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  "hatchSpeedup");
            System.DateTime val_12 = System.DateTime.Now;
            mem[(ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].下丒丗丛丙丆丄丈专].不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime() {dateData = val_12.dateData}, 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
            System.DateTimeOffset val_14 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  PixelTime.丝丗专上三不丄丑丑());
            .东丆丒东不丕丑万丂 = ;
            PGCompany.EggIncubatorProgress val_17 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
            .三万万丒丏丒不丐丙 = val_17;
            .世丕丘丈丙世业东丕 = new PGCompany.丕下丆丑万世业丈丟(三万万丒丏丒不丐丙:  val_17);
            (ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].下丒丗丛丙丆丄丈专.add_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void ShopNGUIController.丒丈三丄丑东丈且七::丅业丘丄上丝丅一三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_20 = null;
            val_25 = val_20;
            val_20 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void ShopNGUIController.丒丈三丄丑东丈且七::丂下专丈丙丅与丌丑(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
            (ShopNGUIController.丒丈三丄丑东丈且七)[1152921539102440400].下丒丗丛丙丆丄丈专.add_EnterIdle(丙业与丙丗丝不丈东:  val_20);
            return;
        }
        
        val_22 = "[ShopNguiC.HandleSpeedupEggAds] TryGetRewardedVideo failed: "("[ShopNguiC.HandleSpeedupEggAds] TryGetRewardedVideo failed: ") + val_9;
        UnityEngine.Debug.LogWarning(message:  val_22);
    }
    private bool 一丑丄东丑上丄专丂(out PGCompany.Ads.丂丐与不丘不下丂上 丛下丛下丑丞与世下)
    {
        PGCompany.Ads.丂丐与不丘不下丂上 val_6;
        .丝且与丝丒丟万丁专 = this;
        if(this.业丈丌丌七丛丆丝上 != null)
        {
                if(this.业丈丌丌七丛丆丝上.丆丞且专丈世丞丞业() == false)
        {
            goto label_3;
        }
        
        }
        
        丛下丛下丑丞与世下 = 0;
        .上丈丙世丈东丟下丕 = new PGCompany.Ads.丂丐与不丘不下丂上(丙丁丘丙丝且丄上丌:  this.rentScreenPoint.gameObject);
        this.且丘三丛丕不万丒七(丙业与丙丗丝不丈东:  new System.EventHandler(object:  new ShopNGUIController.丈丆不世丒丗三丄与(), method:  System.Void ShopNGUIController.丈丆不世丒丗三丄与::上丌三七万丝业丙一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_6 = (ShopNGUIController.丈丆不世丒丗三丄与)[1152921539102643376].上丈丙世丈东丟下丕;
        this.业丈丌丌七丛丆丝上 = val_6;
        goto label_5;
        label_3:
        val_6 = this.业丈丌丌七丛丆丝上;
        label_5:
        丛下丛下丑丞与世下 = val_6;
        return true;
    }
    private void 丁丙丕丌与万丄丛世(PropertiesArmoryItemContainer 万三丂且丆三且丝且, 丙且上东下丏丏丟下 专丗丒东丂万丂万丟, 丆丘丞不丒七丆与不 丈下七丅且下与专丒, ref bool 丆万专七丆丝且丁丐, ref bool 丆丟丘丁上丁七丐且, ref bool 世丐世东业丏上丞三, ref bool 一三专丙丘丂丂万丟)
    {
        var val_29;
        UILabel val_30;
        UILabel val_31;
        var val_32;
        bool val_33;
        string val_34;
        var val_35;
        var val_36;
        var val_37;
        int val_38;
        var val_39;
        val_29 = 1152921539102915088;
        val_30 = 1152921539102911024;
        val_31 = 万三丂且丆三且丝且;
        int val_23 = 0;
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if((丈下七丅且下与专丒 - 1) <= 1)
        {
                val_32 = null;
            val_33 = ShopNGUIController.不业丞且世且丝三丐();
        }
        else
        {
                val_33 = false;
        }
        
        丆万专七丆丝且丁丐 = val_33;
        if(val_33 != 0)
        {
                if(val_31 == null)
        {
                val_32 = 0;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  万三丂且丆三且丝且.goToClansGetParts, 丏业丟一东丂东丘丛:  false);
        }
        
        val_34 = "feature.clans";
        val_35 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  val_34);
        丆丟丘丁上丁七丐且 = ShopNGUIController.丒丅世丌丛丏丒东丟();
        世丐世东业丏上丞三 = (~val_35) & 1;
        if(val_35 != true)
        {
                val_30 = 万三丂且丆三且丝且.goToClansLevelRequired;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_30, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.clans")));
        }
        
        一三专丙丘丂丂万丟 = (丈下七丅且下与专丒 == 2) ? 1 : 0;
        if(丈下七丅且下与专丒 != 2)
        {
                return;
        }
        
        val_30 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  万三丂且丆三且丝且.closedByDivisionGunPropertiesHeader, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9136"));
        val_35 = 1152921505171275776;
        val_29 = 专丗丒东丂万丂万丟.业上丙丞丐丄丆丅七().Length;
        val_36 = null;
        val_36 = null;
        if(val_29 > (与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.Length + 4))
        {
                val_37 = null;
            val_37 = null;
            val_29 = 与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒.Length;
            bool val_24 = System.Int32.TryParse(s:  专丗丒东丂万丂万丟.业上丙丞丐丄丆丅七().Substring(startIndex:  val_29 + 4), style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_23);
            val_31 = 万三丂且丆三且丝且.closedByDivisionGunPropertiesLabel;
            val_38 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9135"), arg0:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_23));
            val_39 = null;
        }
        else
        {
                val_39 = null;
            val_31 = 万三丂且丆三且丝且.closedByDivisionGunPropertiesLabel;
            val_38 = System.String.alignConst;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_31, 丕丗丘丑丛与丑业丒:  val_38);
    }
    internal void 三丟业丝万专丞世丝()
    {
        if(this.丅七丏一丒下丏丏丆 != null)
        {
                this.StopCoroutine(routine:  this.丅七丏一丒下丏丏丆);
        }
        
        this.丅七丏一丒下丏丏丆 = this.StartCoroutine(routine:  this.丂专丅丒丟丝三万丄());
    }
    private System.Collections.IEnumerator 丂专丅丒丟丝三万丄()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ShopNGUIController.丌丑且专丈丛丐专三(丗丏丅丕丆世丁专丟:  0);
    }
    private void 下且业专丆丕丝丛丙()
    {
        UnityEngine.Vector3 val_13;
        float val_14;
        val_13 = this.丐且且一三业东丛丛;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_13, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.characterPoint.position;
        UnityEngine.Vector3 val_6 = this.ourCameras.Item[1].transform.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  3f);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.5f);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_14 = val_11.x;
        val_13 = val_11.z;
        this.丐且且一三业东丛丛 = val_11;
        mem[1152921539103352872] = val_11.y;
        mem[1152921539103352876] = val_13;
        UnityEngine.Vector3 val_12 = this.characterPoint.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_13});
        this.丐且且一三业东丛丛 = val_12;
        mem[1152921539103352872] = val_12.y;
        mem[1152921539103352876] = val_12.z;
    }
    private void 与且丏丏丘丑与丕丟()
    {
        UnityEngine.Vector3 val_20;
        UnityEngine.Vector3 val_21;
        val_20 = this.下世一丒世三丂专丗;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_20, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.ourCameras.Item[1].transform.position;
        UnityEngine.Vector3 val_6 = this.characterPoint.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  3f);
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  3f);
        this.下世一丒世三丂专丗 = val_11;
        mem[1152921539103509892] = val_11.y;
        mem[1152921539103509896] = val_11.z;
        float val_14 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
        float val_20 = -1.333333f;
        val_20 = val_14 + val_20;
        float val_16 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.5f, t:  UnityEngine.Mathf.Clamp01(value:  val_20));
        val_16 = this.下世一丒世三丂专丗 - val_16;
        this.下世一丒世三丂专丗 = val_16;
        val_21 = this.下世一丒世三丂专丗;
        UnityEngine.Vector3 val_19 = this.世丈上丑东丞丐专万().transform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_21, y = val_14, z = val_7.z});
        this.下世一丒世三丂专丗 = val_19;
        mem[1152921539103509892] = val_19.y;
        mem[1152921539103509896] = val_19.z;
    }
    private void 丂万丑东七业丁业丁()
    {
        object val_27;
        float val_28;
        float val_29;
        var val_30;
        val_27 = this;
        int val_2 = Holoville.HOTween.HOTween.Kill(p_target:  this.世丈上丑东丞丐专万());
        if(this.且丛丌丌七丈丝丒丈 != null)
        {
                if(this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌() == 210000)
        {
                this.世丈上丑东丞丐专万().localPosition = new UnityEngine.Vector3() {x = this.丛丏专专世下丘丈上, y = V9.16B, z = V10.16B};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.丆丌丟丅丘丑业丒丄, y = V9.16B, z = this.丛丏专专世下丘丈上});
            this.世丈上丑东丞丐专万().localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            this.世丈上丑东丞丐专万().localScale = new UnityEngine.Vector3() {x = this.丁丝世下一丟丅万东, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_11 = this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒().transform.position;
            val_28 = val_11.x;
            val_29 = val_11.z;
            val_30 = this.丘丌丞丑业丑丗上丟.丂丈丐且不世七丒丒().transform;
            UnityEngine.Vector3 val_14 = val_30.up;
            this.世丈上丑东丞丐专万().RotateAround(point:  new UnityEngine.Vector3() {x = val_28, y = val_11.y, z = val_29}, axis:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, angle:  this.专三不丅丂丌一万七);
            this.东世七上东丐丁丑东 = 0f;
            return;
        }
        
        }
        
        float val_15 = UnityEngine.Time.realtimeSinceStartup;
        val_15 = val_15 + 1000000f;
        this.东世七上东丐丁丑东 = val_15;
        val_28 = this.丆丌丟丅丘丑业丒丄;
        val_30 = new Holoville.HOTween.TweenParms().Prop(p_propName:  "localPosition", p_endVal:  this.丛丏专专世下丘丈上).Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Vector3() {x = val_28, y = V9.16B, z = V10.16B})).Prop(p_propName:  "localScale", p_endVal:  this.丁丝世下一丟丅万东).UpdateType(p_updateType:  3).Ease(p_easeType:  0);
        val_27 = val_30.OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void ShopNGUIController::丟专一上丏丌与丙丝()));
        Holoville.HOTween.Tweener val_26 = Holoville.HOTween.HOTween.To(p_target:  this.世丈上丑东丞丐专万(), p_duration:  0.5f, p_parms:  val_27);
    }
    private void 专东丁丙丞丂东丝丁()
    {
        System.Object[] val_15 = this;
        if(this.丘丌丞丑业丑丗上丟 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.丘丌丞丑业丑丗上丟.丐丁丟丏丄东不丘丒();
        if(val_2 == 0)
        {
                return;
        }
        
        if(上丑三丁丄丛丁万丑.东丅三丏丂丞下上丑() == true)
        {
                return;
        }
        
        UnityEngine.Animation val_7 = val_2.GetComponent<Rilisoft.PetEngine>().下七丏不丒丗业丛专().GetComponent<UnityEngine.Animation>();
        this.丝丂丗七丒丄丄东丐();
        if((val_7.GetClip(name:  "Profile")) == 0)
        {
                object[] val_10 = new object[1];
            val_15 = val_10;
            val_15[0] = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  val_2);
            UnityEngine.Debug.LogErrorFormat(format:  "Error: pet {0} has no Profile animation clip", args:  val_10);
            return;
        }
        
        if(this.petProfileAnimationRunner.gameObject.activeInHierarchy != false)
        {
                val_15 = this.petProfileAnimationRunner;
            val_15.StartPlay(丆不丝丝上一丞七业:  val_7, 七不丐下丟专业万丅:  "Profile", 丄三丗丛丑下丅丏七:  false, 丟丘丙丄丅万丏与丗:  0);
            return;
        }
        
        val_15 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "Coroutine couldn\'t be started because the the game object \'AnimationCoroutineRunner\' is inactive! (Pet)", args:  val_15);
    }
    internal void 一丌丒丆一丏三专丕(bool 丗丘丂丟丟业万业东 = False)
    {
        ShopNGUIController.丂丕丄丒且丄丂丝丒 val_1 = new ShopNGUIController.丂丕丄丒且丄丂丝丒();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .丗丘丂丟丟业万业东 = 丗丘丂丟丟业万业东;
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<CategoryNames>(丌丛丏业世丄丞三丌:  System.Linq.Enumerable.OfType<CategoryNames>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))), 七丐丅专且专七三丆:  new System.Action<CategoryNames>(object:  val_1, method:  System.Void ShopNGUIController.丂丕丄丒且丄丂丝丒::丂丑丄丛东丞下一七(CategoryNames 丙丑丕丂下丏一丁专)));
    }
    internal void 世丐丕三丞一丂三且(CategoryNames 七丆丒与丗丌丄且丂, bool 丗丘丂丟丟业万业东 = False)
    {
        var val_29;
        var val_30;
        UnityEngine.Object val_31;
        string val_32;
        var val_33;
        ShopNGUIController.丄丘业丘业丞不丈丑 val_1 = new ShopNGUIController.丄丘业丘业丞不丈丑();
        if(七丆丒与丗丌丄且丂 > 1399)
        {
            goto label_1;
        }
        
        if(七丆丒与丗丌丄且丂 <= 1099)
        {
            goto label_2;
        }
        
        if(七丆丒与丗丌丄且丂 == 1100)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 == 1200)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 == 1300)
        {
                return;
        }
        
        goto label_15;
        label_1:
        if(七丆丒与丗丌丄且丂 <= 34999)
        {
            goto label_7;
        }
        
        if(七丆丒与丗丌丄且丂 == 35000)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 == 40000)
        {
                return;
        }
        
        val_29 = 45000;
        goto label_10;
        label_2:
        if(七丆丒与丗丌丄且丂 == 11)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 == 1000)
        {
                return;
        }
        
        goto label_15;
        label_7:
        if(七丆丒与丗丌丄且丂 == 1400)
        {
                return;
        }
        
        val_29 = 30000;
        label_10:
        if(七丆丒与丗丌丄且丂 == 30000)
        {
                return;
        }
        
        label_15:
        if((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂)) == true)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 <= 179999)
        {
            goto label_19;
        }
        
        if(七丆丒与丗丌丄且丂 <= 219999)
        {
            goto label_20;
        }
        
        if(七丆丒与丗丌丄且丂 == 220000)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 == 230000)
        {
                return;
        }
        
        val_30 = 196608;
        val_30 = 3;
        goto label_23;
        label_19:
        if(七丆丒与丗丌丄且丂 > 140999)
        {
            goto label_24;
        }
        
        if(七丆丒与丗丌丄且丂 == 13500)
        {
                return;
        }
        
        goto label_28;
        label_24:
        if(七丆丒与丗丌丄且丂 == 141000)
        {
                return;
        }
        
        goto label_28;
        label_20:
        if(七丆丒与丗丌丄且丂 == 180000)
        {
                return;
        }
        
        label_28:
        val_30 = 131072;
        val_30 = 2;
        label_23:
        if(七丆丒与丗丌丄且丂 == 190000)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.不丐不丗丑七东丙东(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        if(val_3 == 0)
        {
                return;
        }
        
        ShopCategoryButton val_5 = val_3.GetComponent<ShopCategoryButton>();
        if(val_1 != null)
        {
                val_31 = val_1;
            .不丛丌丂丘丆丘丒下 = val_5;
        }
        else
        {
                val_31 = 16;
            mem[16] = val_5;
        }
        
        if(val_31 == 0)
        {
                return;
        }
        
        if(七丆丒与丗丌丄且丂 != 2000)
        {
            goto label_40;
        }
        
        if(val_1 == null)
        {
            goto label_41;
        }
        
        if(mem[16] != 0)
        {
            goto label_114;
        }
        
        label_115:
        label_114:
        if(mem[16] != 0)
        {
            goto label_112;
        }
        
        label_113:
        label_112:
        mem[16].SetIcon(与万丆丛丒万丝丙丑:  mem[16].GetTexture());
        return;
        label_40:
        if(七丆丒与丗丌丄且丂 == 9)
        {
                if((val_5 + 40) != 0)
        {
                不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  val_5 + 40);
        }
        
        }
        
        string val_9 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        if(七丆丒与丗丌丄且丂 == 8)
        {
                val_32 = val_9;
            string val_29 = "EMPTY_ROYALE_AVATAR";
            val_32 = System.String.op_Equality(a:  val_32, b:  val_29);
            val_29 = val_32;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5 + 40.gameObject, 丏业丟一东丂东丘丛:  val_29);
            string val_30 = "EMPTY_ROYALE_AVATAR";
            val_30 = System.String.op_Inequality(a:  val_9, b:  val_30);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5 + 24.gameObject, 丏业丟一东丂东丘丛:  val_30);
            if((System.String.op_Equality(a:  val_9, b:  "EMPTY_ROYALE_AVATAR")) != false)
        {
                val_33 = null;
            val_33 = null;
            Rilisoft.与丄丁丄丙丞下下丙.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_5 + 40.gameObject, 丐丅丁丂丐下丘世丄:  SkinsController.丌与世丂丘且下丒丑, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
            int val_17 = Holoville.HOTween.HOTween.Kill(p_target:  val_5 + 40);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            val_5 + 40.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            return;
        }
        
        }
        
        if((七丆丒与丗丌丄且丂 == 9) && ((System.String.op_Equality(a:  七丌丞万七万丁丐丙.一万丌东丄世上丕丟(), b:  "cape_Custom")) != false))
        {
                mem[16].SetIcon(与万丆丛丒万丝丙丑:  0);
            if((val_5 + 32) != 0)
        {
                val_5 + 32.SetActive(value:  false);
        }
        
            丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  丏丄丑上丛不丈且万.丝丛世与丌上三上不(丒丘丏上丙丟丑丕丈:  "cape_Custom", 七丆丒与丗丌丄且丂:  9), 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void ShopNGUIController.丄丘业丘业丞不丈丑::丆丌三丐三下业丌丅(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 东丘一一丐丆下丁丆, int 丌丂丆丄丅丞上丝且, int 且与丘与丐万丒七丒)), 七丆丒与丗丌丄且丂:  9, 丐丑七万丌丂专与丌:  0);
            return;
        }
        
        if((val_5 + 32) != 0)
        {
                UnityEngine.Object val_31 = 0;
            val_31 = UnityEngine.Object.op_Equality(x:  上丑三丁丄丛丁万丑.丆丌万万不下丌专丕(丂丌丌不丟东丙丝丌:  七丆丒与丗丌丄且丂, 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七()), y:  val_31);
            val_5 + 32.SetActive(value:  val_31);
        }
        
        if(mem[16] != 0)
        {
            goto label_112;
        }
        
        goto label_113;
        label_41:
        if(mem[16] != 0)
        {
            goto label_114;
        }
        
        goto label_115;
    }
    internal void 三上丅丕上丈丐且丁(string 丒东业不丐丑丕丄丆)
    {
        丆丟七丌丞东丆丕丌.丄东世丌专下丈丑丙(丒东业不丐丑丕丄丆:  丒东业不丐丑丕丄丆, 丙丑丕丂下丏一丁专:  this.且丛丌丌七丈丝丒丈.丒万丕七专不丏丞丌(), 丆万丐丗丅丘丆丁丌:  (this.丁丝丁上丂上专丐业 == true) ? 1 : 0);
    }
    internal static void 丕上万丑七丗丕一丈()
    {
        var val_4;
        ShopNGUIController val_5;
        var val_6;
        var val_7;
        CategoryNames val_8;
        val_4 = null;
        val_4 = null;
        val_5 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  false);
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
                val_8 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1564];
            val_8 = ShopNGUIController.丏丙丅丕一丑丕丑丑.<与一丐丟丗三一东丂>k__BackingField;
        }
        else
        {
                val_8 = 314;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  val_8, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        val_5 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = ArmoryInfoScreenController.丄丞丁丈与业上丞丟;
        val_5.丞丏世丆丄上丆一七();
    }
    internal static 丆丘丞不丒七丆与不 丙丑丐丈丆丝丐且丗(string 丙丄不丈专丕与万万)
    {
        string val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 丙丄不丈专丕与万万;
        if(val_11 == null)
        {
            goto label_15;
        }
        
        val_12 = null;
        val_12 = null;
        if((val_11.StartsWith(value:  与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒)) != false)
        {
                val_13 = 2;
            return (丆丘丞不丒七丆与不)val_13;
        }
        
        val_11 = 七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  val_11);
        if(((val_11 == 七丌丞万七万丁丐丙.丑丒丆与丘下丛上业) || ((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_11)) > 0)) || ((BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  val_11)) == false))
        {
            goto label_15;
        }
        
        丞丂丘丒丟丞丑下丄 val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_7 == null)
        {
            goto label_17;
        }
        
        val_14 = val_7.世丝丌一且丝专丑丛();
        goto label_18;
        label_15:
        val_13 = 0;
        return (丆丘丞不丒七丆与不)val_13;
        label_17:
        val_14 = 0;
        label_18:
        var val_10 = (val_14 < (BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_11))) ? (1 + 1) : 1;
        return (丆丘丞不丒七丆与不)val_13;
    }
    public void HandleModulesTutorialInfoButton()
    {
        this.HandleInfoButton();
    }
    internal void 丟丙且丝万与不丑丐()
    {
        this.丕丙丟三世上丅丆丕();
        this.三丅不丈一丂丌世丞();
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        if((业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() - 1) > 3)
        {
                return;
        }
        
        var val_48 = 106013340 + ((val_5 - 1)) << 2;
        val_48 = val_48 + 106013340;
        goto (106013340 + ((val_5 - 1)) << 2 + 106013340);
    }
    private 三丅丁丗丗丝丂万且 丐三丂丗丈上丗专一()
    {
        var val_7;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>> val_2 = PGCompany.业丛丈丙丂且丌丑丙.丘业七丕丂丈丟不丅();
        System.Collections.Generic.KeyValuePair<CategoryNames, System.Single> val_3 = val_2.Item[0];
        .上世丗且七下丆专三 = val_2;
        val_7 = null;
        val_7 = null;
        if((System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与(), predicate:  new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new ShopNGUIController.下丙业七一丘东丘丟(), method:  System.Boolean ShopNGUIController.下丙业七一丘东丘丟::七与业丄且丁三丑丒(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万)))) != null)
        {
                return (三丅丁丗丗丝丂万且)val_6.三丐三丞丘丕不丒专;
        }
        
        return (三丅丁丗丗丝丂万且)val_6.三丐三丞丘丕不丒专;
    }
    private void 丕丙丟三世上丅丆丕()
    {
        if(this.万丂丘丘与丝丁万上 != null)
        {
                return;
        }
        
        UnityEngine.GameObject[] val_1 = new UnityEngine.GameObject[11];
        val_1[0] = this.modulesTutorialChooseCraft;
        val_1[1] = this.modulesTutorialChooseChestsCategory;
        val_1[2] = this.modulesTutorialStartOpeningChest;
        val_1[3] = this.modulesTutorialSpeedupChest;
        val_1[4] = this.modulesTutorialOpenChest;
        val_1[5] = this.modulesTutorialChooseWeapons;
        val_1[6] = this.modulesTutorialChooseWeaponConcreteCategory;
        val_1[7] = this.modulesTutorialGoInfo;
        val_1[8] = this.modulesTutorialChooseWear;
        val_1[9] = this.modulesTutorialChooseArmorCategory;
        val_1[10] = this.modulesTutorialEnterArmorModules;
        this.万丂丘丘与丝丁万上 = val_1;
    }
    private void 三丅不丈一丂丌世丞()
    {
        var val_1;
        this.丕丙丟三世上丅丆丕();
        val_1 = 0;
        goto label_1;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.万丂丘丘与丝丁万上[0], 丏业丟一东丂东丘丛:  false);
        val_1 = 1;
        label_1:
        if(val_1 < this.万丂丘丘与丝丁万上.Length)
        {
            goto label_7;
        }
    
    }
    private void 丆三下上一丌世且专()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丗世一丄专丌丆丐丘)) != false)
        {
                return;
        }
        
        this.丙一世丞丏丌丑丟丘(三不三丟专丘东东丂:  this.丗世一丄专丌丆丐丘, 丅专丕三且丑丘专下:  0);
    }
    internal void 且一丞丗三一丄万丝(string 丙丂丒一丗下丘下丟)
    {
        if(this.丘丌丞丑业丑丗上丟 == 0)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丙丂丒一丗下丘下丟));
    }
    internal void 七丄丒丌上万万丐业(string 丅丐丞丞丐丘东丘丘)
    {
        if(this.丘丌丞丑业丑丗上丟 == 0)
        {
                return;
        }
        
        this.丘丌丞丑业丑丗上丟.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  丅丐丞丞丐丘东丘丘));
    }
    internal void 丙一世丞丏丌丑丟丘(string 三不三丟专丘东东丂, PGCompany.丟丝世万东万丆丟上 丅专丕三且丑丘专下)
    {
        PGCompany.丟丝世万东万丆丟上 val_15;
        string val_16;
        var val_17;
        val_15 = 丅专丕三且丑丘专下;
        string val_2 = ((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  三不三丟专丘东东丂)) == 2) ? "ShopStubForClanWeaponsLockedByDivision" : 三不三丟专丘东东丂;
        this.丘丌丞丑业丑丗上丟.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  val_2);
        if(val_15 == null)
        {
            goto label_4;
        }
        
        label_34:
        this.丘丌丞丑业丑丗上丟.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  val_15);
        if(三不三丟专丘东东丂 == null)
        {
                return;
        }
        
        bool val_3 = 上丑三丁丄丛丁万丑.上丅丏且丄七万三七(七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField);
        if((this.<与一丐丟丗三一东丂>k__BackingField) != 240000)
        {
                if((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  三不三丟专丘东东丂)) != true)
        {
                if((WeaponManager.丒上丙丕一丘三万丄(三不三丟专丘东东丂:  三不三丟专丘东东丂)) == false)
        {
            goto label_15;
        }
        
        }
        
            this.丘丌丞丑业丑丗上丟.丕不丙一丝丆下丗东(丙业与丙丗丝不丈东:  true);
        }
        
        label_15:
        val_15 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  三不三丟专丘东东丂);
        if(val_15 == null)
        {
                return;
        }
        
        if(val_15.东七与与不丅丙上上() == true)
        {
                return;
        }
        
        val_16 = WeaponManager.丐丙丅丒与不丘业丟();
        if((val_15.三与丛丑且丐丈业丌().Equals(value:  val_16)) == true)
        {
                return;
        }
        
        val_15 = val_15.与不丞丑七丘丁丂丛();
        val_17 = null;
        val_17 = null;
        if((val_15.Equals(value:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与)) == true)
        {
                return;
        }
        
        this.丗世一丄专丌丆丐丘 = 三不三丟专丘东东丂;
        return;
        label_4:
        PGCompany.丟丝世万东万丆丟上 val_14 = 丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  丏丄丑上丛不丈且万.丘与丗业丁丞专丝世(丆万一不丌且东丐丐:  val_2));
        if(this.丘丌丞丑业丑丗上丟 != null)
        {
            goto label_34;
        }
        
        goto label_34;
    }
    internal static void 丙上不专丝丗丁下丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  ShopNGUIController.丙丕丕丕且丕丐丛业, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丙丕丕丕且丕丐丛业 != 1152921505261215856);
    
    }
    internal static void 一丑丑丄丅丈丛丌丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  ShopNGUIController.丙丕丕丕且丕丐丛业, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(ShopNGUIController.丙丕丕丕且丕丐丛业 != 1152921505261215856);
    
    }
    internal static bool 一丗丐丈丁丙不且且()
    {
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  161)) == false)
        {
                return false;
        }
        
        return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  161));
    }
    internal static void 丛专丈丁业丄丙丒丌(bool 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  161, 丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
    }
    internal void 丑丟业专万丂丈上丂(bool 不与万丌一丈下丑丈)
    {
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        三丐下丁丒丆丘下丄.丏下专丛且丌丌丅三(丙业与丙丗丝不丈东:  不与万丌一丈下丑丈);
        ShopNGUIController.丙丗丐丁丆不丈上丈(世丟丈丏丕万丝丆万:  this.丘丌丞丑业丑丗上丟, 下丈丝丁丟下世丐丒:  false);
    }
    internal void 丛丌且丙丏丘一下丏(bool 不与万丌一丈下丑丈)
    {
        if(三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅() ^ 不与万丌一丈下丑丈 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        三丐下丁丒丆丘下丄.丛丅世丈丐丑世丆三(丙业与丙丗丝不丈东:  不与万丌一丈下丑丈);
        this.丘丌丞丑业丑丗上丟.丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  (~不与万丌一丈下丑丈) & 1);
    }
    internal void 丘丈丛三丝不丅丕丆(bool 不与万丌一丈下丑丈)
    {
        if(三丐下丁丒丆丘下丄.丟万三丁丙丅东三三() ^ 不与万丌一丈下丑丈 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        三丐下丁丒丆丘下丄.与丂业丞东丌专万不(丙业与丙丗丝不丈东:  不与万丌一丈下丑丈);
        this.丘丌丞丑业丑丗上丟.不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  (~不与万丌一丈下丑丈) & 1);
    }
    internal void 不丐丑丐丆丘专丙丅(bool 不与万丌一丈下丑丈)
    {
        if(三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七() ^ 不与万丌一丈下丑丈 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        三丐下丁丒丆丘下丄.且世丗丐一不丒三丈(丙业与丙丗丝不丈东:  不与万丌一丈下丑丈);
        this.丘丌丞丑业丑丗上丟.丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  (~不与万丌一丈下丑丈) & 1);
    }
    internal void 丗丁且丙世丒上丑丟(bool 不与万丌一丈下丑丈)
    {
        if(三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏() ^ 不与万丌一丈下丑丈 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                return;
        }
        
        三丐下丁丒丆丘下丄.与丑丗七不丄丗丗东(丙业与丙丗丝不丈东:  不与万丌一丈下丑丈);
        this.丘丌丞丑业丑丗上丟.业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  (~不与万丌一丈下丑丈) & 1);
    }
    internal void 丝丐丁丗丁一丝一与(bool 不与万丌一丈下丑丈)
    {
        ShopNGUIController.丛专丈丁业丄丙丒丌(丙业与丙丗丝不丈东:  (~不与万丌一丈下丑丈) & 1);
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        if(ShopNGUIController.丙丕丕丕且丕丐丛业 == null)
        {
                return;
        }
        
        ShopNGUIController.丙丕丕丕且丕丐丛业.Invoke();
    }
    internal static void 丙丗丐丁丆不丈上丈(CharacterInterfaceV2 世丟丈丏丕万丝丆万, bool 下丈丝丁丟下世丐丒 = False)
    {
        bool val_4 = 下丈丝丁丟下世丐丒;
        if(世丟丈丏丕万丝丆万 == 0)
        {
                return;
        }
        
        val_4 = 三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁() | val_4;
        世丟丈丏丕万丝丆万.丄丌丏三专丏丄丒丌(丙业与丙丗丝不丈东:  (~val_4) & 1);
    }
    public void HandleShowArmorButton(UIToggle 丒世丅业丝东下与丗)
    {
        this.丑丟业专万丂丈上丂(不与万丌一丈下丑丈:  丒世丅业丝东下与丗.value);
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    internal static bool 丒丛丘与丟丕丂丆丆()
    {
        var val_5;
        if(GameConnect.东且三丆丑世世丘丟() != true)
        {
                if(GameConnect.世丐丄三三上丅七三() == false)
        {
                return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "HideLowTiersWeaponsKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 0) ? 1 : 0;
        }
        
        }
        
        val_5 = 1;
        return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "HideLowTiersWeaponsKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 0) ? 1 : 0;
    }
    internal static void 丞丌丄上丈丑丒丗丁(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        val_1 = (~val_1) & 1;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "HideLowTiersWeaponsKey", 下下丏一丙不丘丌丞:  val_1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void HandleShowWeaponLowTiersButton(UIToggle 丒世丅业丝东下与丗)
    {
        ShopNGUIController.丞丌丄上丈丑丒丗丁(丙业与丙丗丝不丈东:  丒世丅业丝东下与丗.value);
        this.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  this.<与一丐丟丗三一东丂>k__BackingField, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    public void HandleShowMaskButton(UIToggle 丒世丅业丝东下与丗)
    {
        this.丛丌且丙丏丘一下丏(不与万丌一丈下丑丈:  丒世丅业丝东下与丗.value);
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public void HandleShowHatButton(UIToggle 丒世丅业丝东下与丗)
    {
        this.丘丈丛三丝不丅丕丆(不与万丌一丈下丑丈:  丒世丅业丝东下与丗.value);
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public void HandleShowCapeButton(UIToggle 丒世丅业丝东下与丗)
    {
        this.不丐丑丐丆丘专丙丅(不与万丌一丈下丑丈:  丒世丅业丝东下与丗.value);
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public void HandleShowBootsButton(UIToggle 丒世丅业丝东下与丗)
    {
        this.丗丁且丙世丒上丑丟(不与万丌一丈下丑丈:  丒世丅业丝东下与丗.value);
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public void HandleShowAllWeaponSkinsButton(UIToggle 丒世丅业丝东下与丗)
    {
        this.丝丐丁丗丁一丝一与(不与万丌一丈下丑丈:  丒世丅业丝东下与丗.value);
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public void HandleShowAlternativeArmorButton(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleShowAlternativeArmorPilotExoButton(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleShowAlternativeArmorHalloween2018Button(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public void HandleShowAlternativeArmorPilgrim2018Button(UIToggle 丒世丅业丝东下与丗)
    {
    
    }
    public ShopNGUIController()
    {
        this.itemIndexInCarousel = 0;
        System.Collections.Generic.Dictionary<世丕丑七且丝七不不, System.Boolean> val_2 = new System.Collections.Generic.Dictionary<世丕丑七且丝七不不, System.Boolean>(capacity:  7, comparer:  new 业业七丄与丅三且丂());
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  true);
            val_2.Add(key:  1, value:  true);
            val_2.Add(key:  2, value:  true);
            val_2.Add(key:  3, value:  true);
            val_2.Add(key:  4, value:  true);
            val_2.Add(key:  5, value:  true);
            val_2.Add(key:  6, value:  true);
            val_2.Add(key:  7, value:  true);
            val_2.Add(key:  8, value:  true);
        }
        else
        {
                val_2.Add(key:  0, value:  true);
            val_2.Add(key:  1, value:  true);
            val_2.Add(key:  2, value:  true);
            val_2.Add(key:  3, value:  true);
            val_2.Add(key:  4, value:  true);
            val_2.Add(key:  5, value:  true);
            val_2.Add(key:  6, value:  true);
            val_2.Add(key:  7, value:  true);
            val_2.Add(key:  8, value:  true);
        }
        
        val_2.Add(key:  9, value:  true);
        this.不丞丝丑一东丅七丏 = val_2;
        System.Collections.Generic.Dictionary<世丕丑七且丝七不不, CategoryNames> val_4 = new System.Collections.Generic.Dictionary<世丕丑七且丝七不不, CategoryNames>(capacity:  6, comparer:  new 业业七丄与丅三且丂());
        if(val_4 != null)
        {
                val_4.Add(key:  0, value:  184);
            val_4.Add(key:  1, value:  0);
            val_4.Add(key:  2, value:  7);
            val_4.Add(key:  3, value:  208);
            val_4.Add(key:  4, value:  212);
            val_4.Add(key:  5, value:  48);
            val_4.Add(key:  6, value:  200);
            val_4.Add(key:  7, value:  0);
            val_4.Add(key:  8, value:  96);
        }
        else
        {
                val_4.Add(key:  0, value:  184);
            val_4.Add(key:  1, value:  0);
            val_4.Add(key:  2, value:  7);
            val_4.Add(key:  3, value:  208);
            val_4.Add(key:  4, value:  212);
            val_4.Add(key:  5, value:  48);
            val_4.Add(key:  6, value:  200);
            val_4.Add(key:  7, value:  0);
            val_4.Add(key:  8, value:  96);
        }
        
        val_4.Add(key:  9, value:  128);
        this.且七丆不专世丂丒三 = val_4;
        this.丗世一丄专丌丆丐丘 = System.String.alignConst;
        this.丅丐丄专丏世丝七丞 = new System.Collections.Generic.HashSet<System.Int32>();
        this.firstOFfset = -50f;
        this.丁丝丁上丂上专丐业 = true;
        this.丈丞专丒丒上丝三丏 = -3.402823E+38f;
        this.secondOffset = 50f;
        this.业丕下三丆世与丝丄 = 1f;
        this.丅丛丟七上丅丑世东 = new System.Collections.Generic.List<System.String>();
        this.专丝丈丝万不丁不专 = -3.402823E+38f;
        this.东万丟丏丁丐丘丁丕 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
        this.丕丏丑丏丏丂与东丏 = 0;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        this.下世一丒世三丂专丗 = val_8;
        mem[1152921539109874308] = val_8.y;
        mem[1152921539109874312] = val_8.z;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        this.丝上丏丕丟与丑丆一 = val_9;
        mem[1152921539109874320] = val_9.y;
        mem[1152921539109874324] = val_9.z;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        this.丆下丒东丐丐丕丌丟 = val_10;
        mem[1152921539109874332] = val_10.y;
        mem[1152921539109874336] = val_10.z;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        this.丐且且一三业东丛丛 = val_11;
        mem[1152921539109874344] = val_11.y;
        mem[1152921539109874348] = val_11.z;
    }
    private static ShopNGUIController()
    {
        ShopNGUIController.丗丟万丂丘丈专丄丂 = 0;
        ShopNGUIController.上丈丂丁三丂业丛丝 = 5f;
        ShopNGUIController.丟丌丞万丕万丐丐上 = new System.Collections.Generic.List<UnityEngine.Camera>();
        ShopNGUIController.下丙丟且丕丆丌东业 = false;
        ShopNGUIController.丟与丌三世丂下丗万 = 2;
        ShopNGUIController.专丏丄丙一一丆丌三 = false;
        ShopNGUIController.东丁丝丝丘且丌丅丗 = false;
        ShopNGUIController.丑万与丞丄丟丁丑丗 = 0;
        ShopNGUIController.丆丂丘且下世上丆丁 = true;
        ShopNGUIController.上专丕丐东丙丛丘上 = 0;
        ShopNGUIController.丞业丙三丙丄丏丞丘 = false;
    }
    private void 东三上东专世丟世上()
    {
        FilterMaps val_10;
        if(((ClanLobbyItemController.丄丘七三上丕世丞业 != 0) && (ClanLobbyItemController.丄丘七三上丕世丞业.丌业丞世且三三丕东 != false)) && (Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0))
        {
                if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
        {
                ClanLobbyItemController.丄丘七三上丕世丞业.HideClanLobbyItems();
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
        }
        
        }
        
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                val_10 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_10 = 0;
        }
        
        上丑三丁丄丛丁万丑.丕与丗丕世业丞丘丙(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_10);
    }
    private void 丒丆东不丙丌下东丏()
    {
        FilterMaps val_3;
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_3 = 0;
        }
        
        上丑三丁丄丛丁万丑.丕与丗丕世业丞丘丙(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_3);
    }
    private void 丕下丕丏丞业丈丏三()
    {
        FilterMaps val_3;
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_3 = 0;
        }
        
        上丑三丁丄丛丁万丑.东七丆三万丆丝丑且(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_3);
    }
    private void 东丂丑专丆下丈丘专()
    {
        FilterMaps val_3;
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_3 = 0;
        }
        
        上丑三丁丄丛丁万丑.东七丆三万丆丝丑且(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_3);
    }
    private void 东丟丏丐丏与三与丝()
    {
        FilterMaps val_3;
        if(ShopNGUIController.丛丐丛专丟丞万三七() >= 100)
        {
                val_3 = ShopNGUIController.丛丐丛专丟丞万三七();
        }
        else
        {
                val_3 = 0;
        }
        
        上丑三丁丄丛丁万丑.专丄丙丞丘丁专丐东(丑丝丏丂且不下一东:  this.且丛丌丌七丈丝丒丈, 七丆丒与丗丌丄且丂:  this.<与一丐丟丗三一东丂>k__BackingField, 专丆丌丛东一不丑丙:  val_3);
    }
    private void 丆丗上上丝下丆业丕()
    {
        if((System.String.op_Equality(a:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), b:  "cape_Custom")) == false)
        {
                return;
        }
        
        this.业三丄丝丐丌丆七丛(不丟丞丑丛丆丁东与:  false, 丏世丑万世一七丟丞:  0, 七丁上丁丒专丈七丙:  0, 丘世丅丞丌丟丏下丙:  false, 丟丟丟三东丛丌丘且:  0, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
    }
    private void 三丝万与丈世丘三丈()
    {
        if(this.丁丝丁上丂上专丐业 != false)
        {
                return;
        }
        
        this.下一一丅丏下东丄丏();
    }
    private void 丘丂七丕丅丗不上下()
    {
        if(this.丁丝丁上丂上专丐业 != false)
        {
                return;
        }
        
        this.下一一丅丏下东丄丏();
    }
    private bool 丅万丁丌三丕业丏三(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)
    {
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝 == null)
        {
                return false;
        }
        
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
        {
                return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
        }
        
        return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七());
    }
    private void 丁丆东丅丒上丆下丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "trying to press back in shop when in bank", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        }
        
        if(this.stub != 0)
        {
                if(this.stub.activeInHierarchy != false)
        {
                return;
        }
        
        }
        
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丞与丑丛丙丅万世世());
    }
    private void 且下一一丘专丌丄不()
    {
        this.丏丄业丁丞万丛丏丘(丆丟七丝丏业丅上丄:  0);
    }
    private void 丞且东丄东丝丑上丆()
    {
        this.<丌世专万丞不丞丒与>k__BackingField = false;
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 丟专一上丏丌与丙丝()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 + 1000000f;
        this.东世七上东丐丁丑东 = val_1;
    }

}
