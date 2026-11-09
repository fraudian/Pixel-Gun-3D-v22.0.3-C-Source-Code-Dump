using UnityEngine;
public class ArmoryCell : BaseArmoryCellWithEquips
{
    // Fields
    private static readonly UnityEngine.Color32 丅三丞且丄丗七丙丛;
    private static readonly UnityEngine.Color 丝丝丐且丒丑世丌专;
    private static readonly UnityEngine.Color 世业专丅丝上且丙东;
    private static readonly UnityEngine.Color 不一丟丕一丘丆丗下;
    private static readonly UnityEngine.Color 丘万丙丑丒丏丂丏且;
    private static readonly UnityEngine.Color 丁丆三丗丈丐丝丙丗;
    private static readonly UnityEngine.Color 三丄三万丆丐与专丁;
    private UnityEngine.GameObject _newSkinsIndicator;
    private UnityEngine.GameObject _clanDivisionOpenedItemContainer;
    private UISprite _clanDivisionShield;
    private UnityEngine.GameObject weaponSkinsIndicator;
    private PGCompany.InventoryItemViewController itemViewController;
    public UnityEngine.GameObject leagueWeaponIcon;
    public UnityEngine.GameObject getLevelToUnlockWeaponContainer;
    public UILabel getLevelToUnlockWeaponLabel;
    public UnityEngine.GameObject lockedByLeagueContainer;
    public UISprite lockedByLeagueSprite;
    public UnityEngine.Transform eventStoreGuiHandler;
    public UnityEngine.GameObject setMiniIconsHolder;
    public UISprite setMiniIconWeapon;
    public UISprite setMiniIconElse;
    public UILabel craftingTimer;
    public UILabel detailsCount;
    public UISprite detailsCountContainer;
    public UISprite detailsCountDarkenLayer;
    public UnityEngine.GameObject enoughDetailsCheckmark;
    public UnityEngine.GameObject craftedLabel;
    public UnityEngine.GameObject craftingLAbel;
    public System.Collections.Generic.List<UILabel> upgradingWeaponTime;
    public UnityEngine.GameObject upgrading;
    public UnityEngine.GameObject unlocked;
    public UISprite bottomBorderIndicatorSprite;
    public UISprite topBorderIndicatorSprite;
    public UnityEngine.GameObject darkForeground;
    public UnityEngine.GameObject championEggImage;
    public System.Collections.Generic.List<UILabel> leagueRating;
    public UnityEngine.GameObject selectionIndicator;
    public System.Collections.Generic.List<UILabel> petName;
    public System.Collections.Generic.List<UILabel> petLevel;
    public System.Collections.Generic.List<UILabel> eggCondition;
    public UnityEngine.GameObject topSeller;
    public UnityEngine.MeshRenderer capeRenderer;
    public UnityEngine.GameObject newSkinLabel;
    public UnityEngine.GameObject rented;
    public UnityEngine.GameObject isPriceForUpgrade;
    public UnityEngine.GameObject equipped;
    public UILabel rentedMatchesLeft;
    public UnityEngine.GameObject modelForSkin;
    public UnityEngine.GameObject upgradesContainer;
    public System.Collections.Generic.List<UISprite> upgrades;
    public UILabel priceLabel;
    public UILabel freePriceLabel;
    public UnityEngine.GameObject gemSprite;
    public UnityEngine.GameObject coinSprite;
    private UnityEngine.GameObject priceCurrencyContainer;
    public UILabel discountLabel;
    public UISprite discountSprite;
    public UISprite coloredBorder;
    public UISprite boughtIndicator;
    public bool isEmpty;
    public UnityEngine.GameObject localCustomSkin;
    public UnityEngine.GameObject serverCustomSkin;
    private UIWidget bg;
    private PGCompany.ModuleStorageView _moduleStorageView;
    private System.Collections.Generic.List<UILabel> _weaponLevel;
    private System.Collections.Generic.List<UIWidget> _weaponLevelBG;
    private UnityEngine.GameObject _petCardsContainer;
    private UILabel _petCardsLabel;
    private UISprite _petCardsSprite;
    private UnityEngine.GameObject _equippedCheckmark;
    private UnityEngine.GameObject _eventItemBadge;
    private UnityEngine.GameObject _leagueItemBadge;
    private UnityEngine.GameObject _greenWeaponBottomLeftIndicator;
    private UnityEngine.GameObject _rarityTopLeftDiagonalBadge;
    private UITexture _rarityTopLeftDiagonalBadgeIcon;
    private UITexture _itemCategoryTopLeftIcon;
    private UnityEngine.Texture 丛且丒丄丁上万一丘;
    public UnityEngine.GameObject MiscEquipContainer;
    private UnityEngine.GameObject 丘万丑下丘丁万丅丁;
    private bool <不丕丌丛与丄万世丐>k__BackingField;
    private bool <丑丐与丅丅丛专丑丂>k__BackingField;
    private string 丒丒三丅丈万丝不丞;
    internal int 万上东不上专世丂三;
    private string 丈且丟丙丆丘业丈不;
    private string 丈丄七丅下丛丐且丏;
    private int 丑丒丌且丟下丝丈七;
    private System.Nullable<bool> 丘三不丟丏东丘丕丁;
    private System.Nullable<bool> 丟丁丏丏专丄业万下;
    private System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 丈丑三丁丕丏三丐三;
    private System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 丟业万丞丌丙丙丏丅;
    
    // Properties
    internal TagSystem.CompoundTagBehaviour 丞业丐丁上且丞丞丌 { get; }
    public bool 业不丌丟丁东专丟丄 { get; }
    private bool 丛丏丞丈丟世丞丌丛 { get; set; }
    private bool 三丂丌万专丆且丆丄 { get; set; }
    private System.Nullable<bool> 丙丒丝丆丗丗丑万丞 { get; set; }
    private System.Nullable<bool> 上丞丝丞丗世专丑东 { get; set; }
    private System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 世丟丒丑万七丈丄丁 { get; set; }
    private System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 与丌丗丑丅丏丌三丛 { get; set; }
    
    // Methods
    internal TagSystem.CompoundTagBehaviour 丂丆丙世专丕东三业()
    {
        UnityEngine.GameObject val_1 = this.bg.gameObject;
        if(val_1 != null)
        {
                return val_1.GetComponent<TagSystem.CompoundTagBehaviour>();
        }
        
        return val_1.GetComponent<TagSystem.CompoundTagBehaviour>();
    }
    public bool get_IsFullyVisible()
    {
        if(this.bottomBorderIndicatorSprite.isVisible == false)
        {
                return false;
        }
        
        if(this.topBorderIndicatorSprite != null)
        {
                return this.topBorderIndicatorSprite.isVisible;
        }
        
        return this.topBorderIndicatorSprite.isVisible;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "ArmoryCell: itemid={0}, category={1}", arg0:  this.ItemId, arg1:  this.Category);
    }
    public void MakeCellEmpty()
    {
        this.itemViewController.丆世与丑丆丅丐万且();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponSkinsIndicator, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newSkinsIndicator, 丏业丟一东丂东丘丛:  false);
        this.<不丕丌丛与丄万世丐>k__BackingField = false;
        this.<丑丐与丅丅丛专丑丂>k__BackingField = false;
        this.专丞万丄专业三丘丙(丙业与丙丗丝不丈东:  false);
        this.isEmpty = true;
        this.StopAllCoroutines();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectionIndicator, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topSeller, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newSkinLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rented, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.isPriceForUpgrade, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipped, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.modelForSkin, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.priceLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.freePriceLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemSprite, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.coinSprite, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.discountSprite.gameObject, 丏业丟一东丂东丘丛:  false);
        this.boughtIndicator.alpha = 0.01f;
        this.Icon.enabled = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.petName, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.petLevel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.leagueRating, 丏业丟一东丂东丘丛:  false);
        this.丝且丟丁一丒丑丏与();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedByLeagueContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.darkForeground, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unlocked, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgrading, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.upgradingWeaponTime, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.detailsCountContainer.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enoughDetailsCheckmark, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftedLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftingLAbel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setMiniIconsHolder.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.getLevelToUnlockWeaponContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leagueWeaponIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleStorageView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.eventStoreGuiHandler, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petCardsContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._equippedCheckmark, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventItemBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leagueItemBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._greenWeaponBottomLeftIndicator, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rarityTopLeftDiagonalBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rarityTopLeftDiagonalBadgeIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCategoryTopLeftIcon, 丏业丟一东丂东丘丛:  false);
        this.丛且丒丄丁上万一丘 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MiscEquipContainer, 丏业丟一东丂东丘丛:  false);
        this.丝丞且一下上丐三丞();
        this.丕一东万丟上下丘下();
        mem[1152921524389882276] = 0;
        mem2[0] = 0;
    }
    private void 丕一东万丟上下丘下()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanDivisionOpenedItemContainer, 丏业丟一东丂东丘丛:  false);
    }
    private void 丝且丟丁一丒丑丏与()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.eggCondition, 丏业丟一东丂东丘丛:  false);
    }
    private void 丑下丘世丏丈三丘丞()
    {
        object val_76;
        bool val_77;
        var val_78;
        UnityEngine.GameObject val_79;
        var val_80;
        var val_81;
        UnityEngine.GameObject val_82;
        bool val_83;
        string val_84;
        bool val_85;
        var val_86;
        string val_87;
        var val_88;
        int val_89;
        string val_90;
        var val_91;
        val_76 = this;
        丕丈丏丝丗下丟丅丂 val_30 = 0;
        val_77 = 1152921505253916672;
        if((丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  this.ItemId)) != false)
        {
                val_78 = 丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId);
        }
        else
        {
                val_78 = 0;
        }
        
        val_79 = 1152921505264353280;
        bool val_6 = 丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  this.ItemId);
        if(this.Category != 250000)
        {
            goto label_11;
        }
        
        val_80 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
        if((val_80.丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  this.ItemId))) == false)
        {
            goto label_11;
        }
        
        val_80 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世();
        val_81 = (~(val_80.专专丏下不丙丈丘丌(丞丅上丏丂且下丅与:  this.ItemId))) & 1;
        if(val_81 == 0)
        {
            goto label_13;
        }
        
        goto label_16;
        label_11:
        val_81 = 0;
        if(val_81 != 0)
        {
            goto label_16;
        }
        
        label_13:
        bool val_72 = this.<丑丐与丅丅丛专丑丂>k__BackingField;
        val_72 = val_72 ^ 1;
        val_72 = val_72 & 255;
        val_72 = val_78 | val_72;
        if(val_72 == false)
        {
            goto label_16;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.detailsCountContainer.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.darkForeground, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enoughDetailsCheckmark, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftedLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftingLAbel, 丏业丟一东丂东丘丛:  false);
        val_82 = this.leagueWeaponIcon;
        val_83 = 0;
        goto label_20;
        label_16:
        val_84 = this.ItemId;
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                丛且专丞丗丆丙丒万 val_22 = System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  this, method:  System.Boolean ArmoryCell::与不上丄丕丙上上丒(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)));
            val_84 = val_22.下丄丈不与世丐业专;
        }
        
        if(val_6 != true)
        {
                if((WeaponManager.七世丂丁丆丙丐丆丌().Contains(item:  val_84)) == false)
        {
            goto label_33;
        }
        
        }
        
        val_85 = 0;
        goto label_34;
        label_33:
        val_86 = null;
        val_86 = null;
        val_85 = System.String.op_Inequality(a:  val_84, b:  WeaponManager.丙丟丂丗丛丟丑东丑);
        label_34:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.detailsCountContainer.gameObject, 丏业丟一东丂东丘丛:  val_85);
        三丅丁丗丗丝丂万且 val_27 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_84);
        bool val_31 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  this.ItemId, value: out  val_30);
        if(val_27 == null)
        {
            goto label_44;
        }
        
        val_87 = val_27.三与丛丑且丐丈业丌();
        val_88 = val_27;
        goto label_45;
        label_44:
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.ItemId)) == false)
        {
            goto label_49;
        }
        
        val_88 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[this.ItemId].七东与丄丕丁丛世三();
        goto label_54;
        label_49:
        if(val_30 == 0)
        {
            goto label_55;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_42 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  70, 丞丅上丏丂且下丅与:  this.ItemId);
        if(val_42 == null)
        {
            goto label_65;
        }
        
        label_67:
        val_88 = val_42;
        var val_44 = (val_42 == 0) ? 1 : 0;
        label_68:
        val_89 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_42.业东丅东丌上丗丑不());
        if((((val_42 != 0) ? 1 : 0) & 1) == 0)
        {
            goto label_95;
        }
        
        val_90 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
        int val_50 = val_90.七丏万丞且丛丌专丞(丞世不丒下上上丝丑:  val_42.业东丅东丌上丗丑不());
        goto label_62;
        label_55:
        if(val_81 == 0)
        {
            goto label_65;
        }
        
        PGCompany.丘三丏丌丗丒万丏丈 val_53 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞丅上丏丂且下丅与:  this.ItemId);
        if(val_53 == null)
        {
            goto label_65;
        }
        
        if((RecipeSystem.三专丒七丌万丂业下.丑七不且上丗丁一世().丘丛世专专丝丂丘丕(丞世不丒下上上丝丑:  val_53.业东丅东丌上丗丑不())) == true)
        {
            goto label_67;
        }
        
        PGCompany.丄丂丌丞丁丙七丆三 val_57 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
        goto label_68;
        label_65:
        val_88 = 5;
        label_54:
        val_87 = val_84;
        label_45:
        val_89 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_84);
        label_95:
        val_90 = val_87;
        int val_59 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_90);
        label_62:
        if(this.detailsCountContainer.gameObject.activeSelf != false)
        {
                this.detailsCountContainer.color = new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5]};
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.detailsCountDarkenLayer, 丏业丟一东丂东丘丛:  (val_89 == 0) ? 1 : 0);
            this.detailsCount.text = System.String.Format(format:  "{0}/{1}", arg0:  val_89, arg1:  val_59);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.darkForeground, 丏业丟一东丂东丘丛:  false);
        val_79 = this.enoughDetailsCheckmark;
        val_77 = 0;
        if(((val_6 | ((val_89 < 1) ? 1 : 0)) != true) && (val_89 >= val_59))
        {
                val_77 = (~(WeaponManager.七世丂丁丆丙丐丆丌().Contains(item:  val_84))) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_79, 丏业丟一东丂东丘丛:  val_77);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftedLabel, 丏业丟一东丂东丘丛:  val_6);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftingLAbel, 丏业丟一东丂东丘丛:  false);
        val_80 = 1152921505286238208;
        val_76 = this.ItemId;
        val_91 = null;
        val_91 = null;
        val_83 = System.String.op_Equality(a:  val_76, b:  WeaponManager.丙丟丂丗丛丟丑东丑);
        val_82 = this.leagueWeaponIcon;
        label_20:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_82, 丏业丟一东丂东丘丛:  val_83);
    }
    private void 万丐三丒丑丑东丄丈()
    {
        System.Collections.Generic.List<UIWidget> val_68;
        object val_69;
        string val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        object val_75;
        丕丑丙丑丙东丌丘丕 val_76;
        var val_77;
        System.Action<T> val_78;
        IntPtr val_80;
        int val_81;
        val_68 = this;
        ArmoryCell.上世丑丐丄世丏三丗 val_1 = null;
        val_69 = val_1;
        val_1 = new ArmoryCell.上世丑丐丄世丏三丗();
        .丝丂丁丌丆三丆专且 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId);
        bool val_7 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  this.ItemId, value: out  (ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丙丗丕丟七丟上丈丌);
        val_70 = this.Category;
        val_71 = null;
        val_72 = 0;
        if((Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  this.ItemId)) != true)
        {
                val_71 = 1152921524391131888;
            val_72 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.ItemId);
        }
        
        if((ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丙丗丕丟七丟上丈丌 == null)
        {
            goto label_11;
        }
        
        label_17:
        if((ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丝丂丁丌丆三丆专且 != null)
        {
                if((ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丝丂丁丌丆三丆专且.东七与与不丅丙上上() == true)
        {
            goto label_13;
        }
        
        }
        
        val_73 = 0;
        goto label_14;
        label_11:
        if(((val_70 == 7) || (val_72 != null)) || ((ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丝丂丁丌丆三丆专且 != null))
        {
            goto label_17;
        }
        
        label_13:
        val_73 = 1;
        label_14:
        if(mem[(ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丙丗丕丟七丟上丈丌] != 0)
        {
                val_73 = val_73 | ((((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) - 1) < 2) ? 1 : 0);
        }
        
        if(val_70 == 7)
        {
                val_73 = val_73 | ((((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId)) - 1) < 2) ? 1 : 0);
        }
        
        if((ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丝丂丁丌丆三丆专且 == null)
        {
            goto label_24;
        }
        
        if((val_73 & 1) != 0)
        {
            goto label_99;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_28;
        }
        
        val_74 = null;
        val_74 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且() == 170000)
        {
            goto label_99;
        }
        
        label_28:
        if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) == 2)
        {
            goto label_99;
        }
        
        if((ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丝丂丁丌丆三丆专且 == null)
        {
            goto label_50;
        }
        
        ArmoryCell.丕丟丝丝上丑丈三丟 val_27 = null;
        val_75 = val_27;
        val_27 = new ArmoryCell.丕丟丝丝上丑丈三丟();
        val_76 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.ItemId);
        if(val_75 == null)
        {
            goto label_40;
        }
        
        val_70 = val_75;
        .且丙丙丁丅丐七丌丐 = val_76;
        if(val_76 == null)
        {
            goto label_41;
        }
        
        label_93:
        if(val_75 == null)
        {
                val_76 = .且丙丙丁丅丐七丌丐;
        }
        
        val_70 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_70, arg0:  val_76.丈一下下丞世三丑丄()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  true);
        val_68 = this._weaponLevelBG;
        val_77 = 1152921524391237456;
        val_78 = new System.Action<UIWidget>(object:  val_27, method:  System.Void ArmoryCell.丕丟丝丝上丑丈三丟::七丅丕丆丙丕专丑七(UIWidget 三丟东丕丄丄下下丑));
        goto label_49;
        label_24:
        if(val_73 == 0)
        {
            goto label_50;
        }
        
        label_99:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  false);
        return;
        label_50:
        if(mem[(ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丙丗丕丟七丟上丈丌] == 0)
        {
            goto label_53;
        }
        
        int val_37 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  mem[(ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丙丗丕丟七丟上丈丌].业东丅东丌上丗丑不());
        if(val_37 == 0)
        {
            goto label_58;
        }
        
        val_70 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_70, arg0:  val_37));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  true);
        val_68 = this._weaponLevelBG;
        val_80 = 1152921524391275344;
        goto label_108;
        label_53:
        if(val_70 != 7)
        {
            goto label_64;
        }
        
        ArmoryCell.且丐与丛丁业世一三 val_40 = null;
        val_69 = val_40;
        val_40 = new ArmoryCell.且丐与丛丁业世一三();
        .且丂丟丈丈丑东丈丙 = 七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.ItemId);
        if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  (ArmoryCell.且丐与丛丁业世一三)[1152921524391654928].且丂丟丈丈丑东丈丙)) <= 0)
        {
            goto label_71;
        }
        
        val_81 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
        int val_46 = val_81.三三三东丑丁且与万(丞世不丒下上上丝丑:  (ArmoryCell.且丐与丛丁业世一三)[1152921524391654928].且丂丟丈丈丑东丈丙);
        goto label_75;
        label_58:
        if((丁下万丟且丟丛下业.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) == true)
        {
            goto label_99;
        }
        
        val_70 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_70, arg0:  mem[(ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丙丗丕丟七丟上丈丌].专丂丏世且丗丏丌丝()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  true);
        val_68 = this._weaponLevelBG;
        val_80 = 1152921524391325520;
        goto label_108;
        label_64:
        if(val_72 == null)
        {
                return;
        }
        
        val_75 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  val_72.CurrentLevel);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  val_75);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  true);
        val_68 = this._weaponLevelBG;
        UnityEngine.Color val_55 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_13.Rarity);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  val_68, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_55.r, g = val_55.g, b = val_55.b, a = val_55.a});
        return;
        label_40:
        val_70 = 16;
        mem[16] = val_76;
        if(mem[16] != 0)
        {
            goto label_93;
        }
        
        label_41:
        if(((WeaponManager.丒上丙丕一丘三万丄(三不三丟专丘东东丂:  this.ItemId)) == true) || ((WeaponManager.丕下丘丆万丌丝丟丞(丒东业不丐丑丕丄丆:  this.ItemId)) == true))
        {
            goto label_99;
        }
        
        if(val_70 != 0)
        {
                return;
        }
        
        val_70 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_70, arg0:  (ArmoryCell.上世丑丐丄世丏三丗)[1152921524391486992].丝丂丁丌丆三丆专且.丐七丐丝与丒七丈丐().丈一下下丞世三丑丄()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  true);
        val_68 = this._weaponLevelBG;
        val_80 = 1152921524391400272;
        goto label_108;
        label_71:
        val_81 = (ArmoryCell.且丐与丛丁业世一三)[1152921524391654928].且丂丟丈丈丑东丈丙;
        label_75:
        val_70 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._weaponLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_70, arg0:  BalanceController.丒丐丘丒丂丛业七丁(丞世不丒下上上丝丑:  val_81)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this._weaponLevel, 丏业丟一东丂东丘丛:  true);
        val_68 = this._weaponLevelBG;
        System.Action<UIWidget> val_67 = null;
        val_80 = 1152921524391429968;
        label_108:
        val_75 = val_67;
        val_67 = new System.Action<UIWidget>(object:  val_40, method:  val_80);
        val_77 = 1152921524391237456;
        val_78 = val_75;
        label_49:
        val_68.ForEach(action:  val_67);
    }
    private void 丑万丅丂丈东专丞东(bool 一且上丗三丝丈业七)
    {
        var val_2 = (一且上丗三丝丈业七 != true) ? -43f : 45f;
        var val_3 = (一且上丗三丝丈业七 != true) ? 34.3f : 62.5f;
        UnityEngine.Vector3 val_5 = this.unlocked.transform.localPosition;
        this.unlocked.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(this._eventItemBadge != 0)
        {
                if(this._eventItemBadge.activeInHierarchy == true)
        {
            goto label_9;
        }
        
        }
        
        if(this._leagueItemBadge == 0)
        {
                return;
        }
        
        if(this._leagueItemBadge.activeInHierarchy == false)
        {
                return;
        }
        
        label_9:
        this = this.unlocked.transform;
        UnityEngine.Vector3 val_12 = this.unlocked.transform.localPosition;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private bool 业丌不丞业世丞丗丗()
    {
        string val_120;
        var val_121;
        var val_124;
        string val_125;
        var val_126;
        var val_127;
        var val_128;
        bool val_129;
        var val_130;
        var val_131;
        string val_132;
        string val_133;
        var val_134;
        var val_135;
        System.Func<PGCompany.GameplayLoop.业丒丅丂丗丁业上且, System.Boolean> val_137;
        var val_138;
        System.Func<PGCompany.GameplayLoop.业丒丅丂丗丁业上且, System.Boolean> val_140;
        string val_142;
        string val_143;
        UnityEngine.Object val_144;
        string val_145;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.eventStoreGuiHandler, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventItemBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leagueItemBadge, 丏业丟一东丂东丘丛:  false);
        val_120 = this.ItemId;
        if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false)
        {
            goto label_14;
        }
        
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_6 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  this, method:  System.Boolean ArmoryCell::丗与丒丑业丕丕丝与(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑));
            丛且专丞丗丆丙丒万 val_7 = System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  null);
            val_120 = val_7.下丄丈不与世丐业专;
        }
        
        if(((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false) || ((与丑丛万不东专丅丙.上东世丏七东丌丕不(丞一丁业丄一一业且:  val_120)) == false))
        {
            goto label_14;
        }
        
        val_121 = 1;
        goto label_29;
        label_14:
        if(this.与三丏丏且上丂丄丂() != null)
        {
                var val_12 = (this.与三丏丏且上丂丄丂().Count > 0) ? 1 : 0;
        }
        else
        {
                val_121 = 0;
        }
        
        label_29:
        if(this.Category == 240000)
        {
                System.Nullable<System.Boolean> val_14 = this.三丕丆丛丈东丅丗丅();
            val_121 = val_121 | 0;
        }
        
        val_124 = 196608;
        val_124 = 3;
        三丅丁丗丗丝丂万且 val_16 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId);
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.ItemId)) != null)
        {
            goto label_120;
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  this.Category).Contains(item:  this.ItemId)) == true)
        {
            goto label_120;
        }
        
        }
        
        if((丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  this.ItemId)) != true)
        {
                if(val_16 != null)
        {
                val_125 = val_16.三与丛丑且丐丈业丌();
        }
        else
        {
                val_125 = this.ItemId;
        }
        
            if((Rilisoft.丕七东丗丁丐丂三下.丏丐下丌东不上丂丑(上与丕专世专上万三:  this.ItemId, 东丒不专丞丙三丘丄:  val_125)) != true)
        {
                if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) != false)
        {
                if((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  this.ItemId, 丝丒上丑一三丑丐丛:  true)) == true)
        {
            goto label_120;
        }
        
        }
        
            if((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.ItemId)) != false)
        {
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId)) == null)
        {
                if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.ItemId)) == true)
        {
            goto label_120;
        }
        
        }
        
        }
        
            if(this.Category != 25000)
        {
                if(this.Category != 30000)
        {
            goto label_71;
        }
        
        }
        
        }
        
        }
        
        label_120:
        label_124:
        var val_47 = (val_121 != 0) ? 1 : 0;
        var val_49 = ((1 != 0) ? 1 : 0) ^ 1;
        bool val_120 = 上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId);
        val_126 = null;
        val_126 = null;
        val_47 = val_47 & val_49;
        val_120 = val_120 ^ 1;
        val_47 = val_47 & val_120;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_127 = null;
            val_127 = null;
            val_128 = (~(WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  this.ItemId))) & 1;
        }
        else
        {
                val_128 = 1;
        }
        
        val_129 = val_128 & val_47;
        if(this.Category != 240000)
        {
                if(this.Category != 250000)
        {
            goto label_84;
        }
        
        }
        
        if(this.Category != 250000)
        {
            goto label_85;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_58 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  this.ItemId);
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_58)) == false)
        {
            goto label_87;
        }
        
        val_130 = (~(PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_58.业东丅东丌上丗丑不()))) & 1;
        goto label_90;
        label_84:
        val_131 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.eventStoreGuiHandler, 丏业丟一东丂东丘丛:  val_129);
        val_132 = val_120;
        if(val_129 == false)
        {
                return (bool)(val_129 == true) ? 1 : 0;
        }
        
        if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false)
        {
            goto label_103;
        }
        
        val_133 = val_132;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                val_133 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId).三与丛丑且丐丈业丌();
        }
        
        if((Rilisoft.丕七东丗丁丐丂三下.丏丐下丌东不上丂丑(上与丕专世专上万三:  val_132, 东丒不专丞丙三丘丄:  val_133)) == false)
        {
            goto label_103;
        }
        
        val_134 = 0;
        goto label_104;
        label_87:
        val_130 = 1;
        label_90:
        val_129 = val_130 & val_129;
        label_85:
        val_135 = null;
        val_135 = null;
        val_137 = ArmoryCell.<>c.<>9__90_1;
        if(val_137 == null)
        {
                System.Func<PGCompany.GameplayLoop.业丒丅丂丗丁业上且, System.Boolean> val_72 = null;
            val_137 = val_72;
            val_72 = new System.Func<PGCompany.GameplayLoop.业丒丅丂丗丁业上且, System.Boolean>(object:  ArmoryCell.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmoryCell.<>c::丛丈与上丌东丕丝与(PGCompany.GameplayLoop.业丒丅丂丗丁业上且 三丟东丕丄丄下下丑));
            ArmoryCell.<>c.<>9__90_1 = val_137;
        }
        
        val_138 = null;
        val_138 = null;
        val_140 = ArmoryCell.<>c.<>9__90_2;
        if(val_140 == null)
        {
                System.Func<PGCompany.GameplayLoop.业丒丅丂丗丁业上且, System.Boolean> val_75 = null;
            val_140 = val_75;
            val_75 = new System.Func<PGCompany.GameplayLoop.业丒丅丂丗丁业上且, System.Boolean>(object:  ArmoryCell.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmoryCell.<>c::丐丁丙下丑丟丆上丞(PGCompany.GameplayLoop.业丒丅丂丗丁业上且 三丟东丕丄丄下下丑));
            ArmoryCell.<>c.<>9__90_2 = val_140;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventItemBadge, 丏业丟一东丂东丘丛:  ((val_129 == true) ? 1 : 0) & (System.Linq.Enumerable.Any<PGCompany.GameplayLoop.业丒丅丂丗丁业上且>(source:  this.丘丘丌丌不丘专丘上(), predicate:  val_75)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leagueItemBadge, 丏业丟一东丂东丘丛:  (System.Linq.Enumerable.Any<PGCompany.GameplayLoop.业丒丅丂丗丁业上且>(source:  this.丘丘丌丌不丘专丘上(), predicate:  val_72)) & val_49);
        this.丑万丅丂丈东专丞东(一且上丗三丝丈业七:  false);
        return (bool)(val_129 == true) ? 1 : 0;
        label_71:
        if(this.Category == 240000)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.ItemId)) == true)
        {
            goto label_120;
        }
        
        }
        
        if(this.Category != 250000)
        {
            goto label_124;
        }
        
        bool val_88 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  this.ItemId);
        goto label_124;
        label_103:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topSeller, 丏业丟一东丂东丘丛:  false);
        val_134 = 1;
        label_104:
        if(0 != 0)
        {
                val_142 = "sale_basic";
        }
        else
        {
                val_132 = this.ItemId;
            PGCompany.GameplayLoop.业丒丅丂丗丁业上且 val_91 = System.Linq.Enumerable.First<PGCompany.GameplayLoop.业丒丅丂丗丁业上且>(source:  this.与三丏丏且上丂丄丂());
            if(val_91 != null)
        {
                PGCompany.GameplayLoop.GameplayLoopType val_92 = val_91.不业丙丒丂丞下丆丙();
        }
        
            val_142 = val_91.丅丆丁世丏万与下丏();
        }
        
        string val_96 = "armory_cell_loop_" + val_142.ToLowerInvariant();
        if(this.丘万丑下丘丁万丅丁 != 0)
        {
                if((System.String.op_Inequality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁), b:  val_96)) != false)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁);
            this.丘万丑下丘丁万丅丁 = 0;
        }
        
        }
        
        if(this.丘万丑下丘丁万丅丁 == 0)
        {
                if((0 & 1) != 0)
        {
                val_143 = "sale";
        }
        else
        {
                val_143 = val_91.不业丙丒丂丞下丆丙().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_131 = 1152921505284374528;
        }
        
            val_144 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoopContent/"("LoopContent/") + val_143 + "_gui/"("_gui/") + val_96.ToLowerInvariant());
            if((val_144 == 0) && (1081360384 == 2))
        {
                if((0 & 1) != 0)
        {
                val_145 = "sale";
        }
        else
        {
                val_145 = null.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_131 = 1152921505284374528;
        }
        
            val_144 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoopContent/"("LoopContent/") + val_145 + "_gui/armory_cell_loop_default"("_gui/armory_cell_loop_default").ToLowerInvariant());
            if(val_144 != 0)
        {
                val_144.name = val_96;
        }
        
        }
        
            val_132 = val_132;
            val_134 = val_134;
            if(val_144 != 0)
        {
                int val_112 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            UnityEngine.GameObject val_113 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_144, 丈东丘丏与丌东东下:  this.eventStoreGuiHandler, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            this.丘万丑下丘丁万丅丁 = val_113;
            LoopGuiBase val_114 = val_113.AddComponent<LoopGuiBase>();
        }
        
        }
        
        if(this.丘万丑下丘丁万丅丁 == 0)
        {
                return (bool)(val_129 == true) ? 1 : 0;
        }
        
        LoopGuiBase val_116 = this.丘万丑下丘丁万丅丁.GetComponent<LoopGuiBase>();
        if((System.String.op_Inequality(a:  val_116.丐丙世七丅丅丐下丙(), b:  val_132)) == false)
        {
                return (bool)(val_129 == true) ? 1 : 0;
        }
        
        val_116.丈且东丑丂且万丒丅(丞一丁业丄一一业且:  val_132, 七丆丒与丗丌丄且丂:  this.Category, 上丒一丂丞丅丏丅丂:  null, 丗丄专丐三丞与丏专:  "Key_6743", 丑丗丕丈丒不丙专丐:  true, 一丏且丏东丌丈丄且:  true, 专丐丛丑丞丕丌与丛:  0);
        return (bool)(val_129 == true) ? 1 : 0;
    }
    public void SetupEmptyCellCategory(CategoryNames 七丆丒与丗丌丄且丂)
    {
        UnityEngine.GameObject val_46;
        UnityEngine.Texture val_47;
        var val_48;
        string val_50;
        if(七丆丒与丗丌丄且丂 != 230000)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  137105408, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.serverCustomSkin != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.serverCustomSkin, 丏业丟一东丂东丘丛:  false);
        }
        
        val_46 = this.localCustomSkin;
        if(val_46 != 0)
        {
                val_46 = this.localCustomSkin;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_46, 丏业丟一东丂东丘丛:  false);
        }
        
        this.与丘丑丒丅丕丞七丈(丙业与丙丗丝不丈东:  七丆丒与丗丌丄且丂);
        CategoryNames val_3 = this.Category;
        if(val_3 <= 110000)
        {
            goto label_14;
        }
        
        if(val_3 <= 180000)
        {
            goto label_15;
        }
        
        if(val_3 <= 210000)
        {
            goto label_16;
        }
        
        if(val_3 == 220000)
        {
            goto label_17;
        }
        
        if(val_3 == 240000)
        {
            goto label_18;
        }
        
        if(val_3 != 250000)
        {
            goto label_98;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Icon, 丏业丟一东丂东丘丛:  true);
        val_47 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Empty_spray_icon");
        val_48 = this.Icon;
        goto label_22;
        label_14:
        if(val_3 <= 13000)
        {
            goto label_23;
        }
        
        if(val_3 <= 35000)
        {
            goto label_24;
        }
        
        if(val_3 == 40000)
        {
            goto label_97;
        }
        
        if(val_3 == 45000)
        {
            goto label_45;
        }
        
        if(val_3 != 110000)
        {
            goto label_98;
        }
        
        goto label_50;
        label_15:
        if(val_3 <= 150000)
        {
            goto label_29;
        }
        
        if(val_3 == 160000)
        {
            goto label_30;
        }
        
        if(val_3 == 170000)
        {
            goto label_31;
        }
        
        goto label_32;
        label_23:
        if(val_3 <= 2100)
        {
            goto label_33;
        }
        
        if(val_3 == 2200)
        {
            goto label_38;
        }
        
        if(val_3 == 12500)
        {
            goto label_45;
        }
        
        if(val_3 != 13000)
        {
            goto label_98;
        }
        
        goto label_45;
        label_16:
        if(val_3 == 190000)
        {
            goto label_38;
        }
        
        if(val_3 == 200000)
        {
            goto label_39;
        }
        
        if(val_3 != 210000)
        {
            goto label_98;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_9 = this.Icon;
        val_50 = "OfferIcons/Empty_Transport_Icon";
        goto label_95;
        label_24:
        if(val_3 == 13500)
        {
            goto label_45;
        }
        
        if(val_3 == 30000)
        {
            goto label_46;
        }
        
        if(val_3 != 35000)
        {
            goto label_98;
        }
        
        goto label_96;
        label_29:
        if((val_3 == 135000) || (val_3 == 141000))
        {
            goto label_50;
        }
        
        label_32:
        if(val_3 == 150000)
        {
            goto label_97;
        }
        
        goto label_98;
        label_33:
        if(val_3 > 12)
        {
            goto label_91;
        }
        
        var val_46 = 1;
        val_46 = val_46 << val_3;
        if((val_46 & 63) != 0)
        {
            goto label_96;
        }
        
        val_46 = val_46 & 5824;
        if(val_46 == 0)
        {
            goto label_55;
        }
        
        label_97:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_13 = this.Icon;
        val_50 = "OfferIcons/Empty_Wear_Icon";
        goto label_95;
        label_45:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_16 = this.Icon;
        val_50 = "OfferIcons/Empty_Gadget_Icon";
        goto label_95;
        label_50:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_19 = this.Icon;
        val_50 = "OfferIcons/Empty_Craft_Icon1";
        goto label_95;
        label_17:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_22 = this.Icon;
        val_50 = "OfferIcons/Empty_Module_Icon";
        goto label_95;
        label_18:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Icon, 丏业丟一东丂东丘丛:  true);
        val_47 = 0;
        label_22:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.Icon, 与万丆丛丒万丝丙丑:  val_47);
        goto label_98;
        label_30:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_27 = this.Icon;
        val_50 = "OfferIcons/Empty_Glider_Icon";
        goto label_95;
        label_31:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_30 = this.Icon;
        val_50 = "OfferIcons/Empty_Shovel_Icon";
        goto label_95;
        label_39:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_33 = this.Icon;
        val_50 = "OfferIcons/Empty_Trails_Icon";
        goto label_95;
        label_46:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_36 = this.Icon;
        val_50 = "OfferIcons/Empty_Egg_Icon";
        goto label_95;
        label_55:
        if(val_3 != 8)
        {
            goto label_91;
        }
        
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_39 = this.Icon;
        val_50 = "OfferIcons/Empty_Skin_Icon";
        goto label_95;
        label_91:
        if(val_3 == 2000)
        {
            goto label_96;
        }
        
        if(val_3 == 2100)
        {
            goto label_97;
        }
        
        goto label_98;
        label_96:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Icon.gameObject, 丏业丟一东丂东丘丛:  true);
        UIBasicSprite val_42 = this.Icon;
        val_50 = "OfferIcons/Empty_Weapon_Icon";
        label_95:
        val_46 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_50);
        label_98:
        UnityEngine.Shader val_45 = UnityEngine.Shader.Find(name:  "Unlit/TransparentRGBMasked");
        if(this.Icon == null)
        {
            
        }
    
    }
    public override void OnPostSelect()
    {
        string val_5;
        float val_6;
        var val_7;
        this.丆世东七专丕且业丛();
        val_5 = 0;
        if(value != false)
        {
                val_6 = 1f;
        }
        else
        {
                val_7 = null;
            val_7 = null;
            val_5 = this.ItemId;
        }
        
        this.discountSprite.alpha = ((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  val_5)) != true) ? 1f : 0f;
    }
    private bool 业丙丈丈丄丏丝丁专()
    {
        return (bool)this.<不丕丌丛与丄万世丐>k__BackingField;
    }
    private void 丈丌丅丑七丙不不丞(bool 丙业与丙丗丝不丈东)
    {
        this.<不丕丌丛与丄万世丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private bool 下东丑丞丑下下丑丈()
    {
        return (bool)this.<丑丐与丅丅丛专丑丂>k__BackingField;
    }
    private void 三且丁丆与专丈与丁(bool 丙业与丙丗丝不丈东)
    {
        this.<丑丐与丅丅丛专丑丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public override void Setup(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丑丙丈三丞一丙丕丅, bool 丆丗一丛丌一与丅且, bool 与上七丈丁三丂世丟)
    {
        var val_30;
        var val_31;
        val_30 = null;
        val_30 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑() != 下丅丙一丂丗丅丝七)
        {
                丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  ShopNGUIController.丏丙丅丕一丑丕丑丑, 丏业丟一东丂东丘丛:  false);
        }
        
        bool val_2 = 丑丙丈三丞一丙丕丅;
        bool val_3 = 丆丗一丛丌一与丅且;
        bool val_4 = 与上七丈丁三丂世丟;
        this.Setup(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丑丙丈三丞一丙丕丅:  val_2, 丆丗一丛丌一与丅且:  val_3, 与上七丈丁三丂世丟:  val_4);
        this.<不丕丌丛与丄万世丐>k__BackingField = val_2;
        this.<丑丐与丅丅丛专丑丂>k__BackingField = val_3;
        this.专丞万丄专业三丘丙(丙业与丙丗丝不丈东:  val_4);
        this.isEmpty = false;
        this.丈丄七丅下丛丐且丏 = "";
        this.丂丅丅丕东丛丌东丑();
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_9;
        }
        
        label_24:
        label_44:
        this.丈丄七丅下丛丐且丏 = WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.ItemId);
        label_39:
        this.丏不丂与丝丕东三世();
        this.且与丁丆丂万丂丟上();
        if(this.Category == 220000)
        {
                UIBasicSprite val_10 = this.Icon;
        }
        
        this.丑丒丌且丟下丝丈七 = 0;
        val_31 = null;
        val_31 = null;
        if((System.String.op_Equality(a:  丏丄丑上丛不丈且万.丕丄东丘丐上丄丕丄(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七()), b:  与世丁丙且丑下丌不.七丒丞丙丏三业丐丙)) == false)
        {
            goto label_20;
        }
        
        this.丏与上东不不下世不();
        return;
        label_9:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if(this.Category != 7)
        {
            goto label_24;
        }
        
        }
        
        if(this.Category != 7)
        {
            goto label_25;
        }
        
        if((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.ItemId))) < 1)
        {
            goto label_44;
        }
        
        label_42:
        string val_22 = this.ItemId;
        goto label_44;
        label_20:
        this.丁丘丄丌上丘丐丒丏();
        return;
        label_25:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) == false)
        {
            goto label_35;
        }
        
        string val_26 = 丁下万丟且丟丛下业.丆丏丒丆万丄且丗丛(丗丑丐丕丟丝且下丕:  this.ItemId);
        goto label_44;
        label_35:
        if(this.Category != 25000)
        {
            goto label_39;
        }
        
        if((Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  this.ItemId)) == false)
        {
            goto label_42;
        }
        
        goto label_44;
    }
    public override void OnReuseWhenExists()
    {
        this.丈丈万万上丒丙上上();
    }
    private static UnityEngine.Color32 七丒丒业下丕丅丕三()
    {
        null = null;
        return new UnityEngine.Color32() {r = ArmoryCell.丅三丞且丄丗七丙丛, g = ArmoryCell.丅三丞且丄丗七丙丛, b = ArmoryCell.丅三丞且丄丗七丙丛, a = ArmoryCell.丅三丞且丄丗七丙丛};
    }
    private void 且丁万世丂丛丙丞三()
    {
        var val_34;
        var val_35;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        var val_44;
        var val_45;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_3;
        }
        
        val_34 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId);
        if(val_34 == null)
        {
            goto label_6;
        }
        
        new ArmoryCell.丟丗东丛丘丂丌七丑() = new ArmoryCell.丟丗东丛丘丂丌七丑();
        .丟丈一下东业一丝丆 = val_34.三与丛丑且丐丈业丌();
        if(this.丗丙丗丄丛丞丛且不() == false)
        {
            goto label_8;
        }
        
        string val_34 = val_34.三与丛丑且丐丈业丌();
        val_34 = System.String.op_Equality(a:  WeaponManager.七丄丄业丛万丄下上(), b:  val_34);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_34);
        goto label_23;
        label_3:
        if(this.Category == 25000)
        {
            goto label_25;
        }
        
        bool val_12 = this.下丙丄不丙丂丗丛丌();
        if(val_12 == false)
        {
            goto label_13;
        }
        
        val_35 = null;
        UnityEngine.Color32 val_13 = ArmoryCell.七丒丒业下丕丅丕三();
        val_13.r = val_13.r & 4294967295;
        UnityEngine.Color val_14 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_13.r, g = val_13.r, b = val_13.r, a = val_13.r});
        val_40 = val_14.r;
        val_41 = val_14.g;
        val_42 = val_14.b;
        val_43 = val_14.a;
        goto label_16;
        label_6:
        if((this.丗丙丗丄丛丞丛且不() == false) || ((丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) == false))
        {
            goto label_23;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        goto label_23;
        label_8:
        if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false)
        {
            goto label_22;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        goto label_23;
        label_13:
        UnityEngine.Color val_18 = val_12.丏丟丏与且丛丅丁不(丈下丑丆上丏丗丈专:  0);
        val_40 = val_18.r;
        val_41 = val_18.g;
        val_42 = val_18.b;
        val_43 = val_18.a;
        label_16:
        this.coloredBorder.color = new UnityEngine.Color() {r = val_40, g = val_41, b = val_42, a = val_43};
        goto label_25;
        label_22:
        val_44 = null;
        val_44 = null;
        val_34 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        System.Predicate<三丈丟与丏丘丈丐万> val_20 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  new ArmoryCell.丟丗东丛丘丂丌七丑(), method:  System.Boolean ArmoryCell.丟丗东丛丘丂丌七丑::东业世专下业专丘丑(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  ((val_34.FindIndex(match:  null)) != 1) ? 1 : 0);
        label_23:
        val_45 = null;
        UnityEngine.Color32 val_23 = ArmoryCell.七丒丒业下丕丅丕三();
        val_23.r = val_23.r & 4294967295;
        UnityEngine.Color val_24 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_23.r, g = val_23.r, b = val_23.r, a = val_23.r});
        val_40 = val_24.r;
        val_42 = val_24.b;
        this.coloredBorder.color = new UnityEngine.Color() {r = val_40, g = val_24.g, b = val_42, a = val_24.a};
        label_25:
        if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) == 0)
        {
                if((丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) == 0)
        {
                if((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) == 0)
        {
            goto label_41;
        }
        
        }
        
        }
        
        label_45:
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        return;
        label_41:
        if(this.Category != 7)
        {
                return;
        }
        
        if((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId)) != 0)
        {
            goto label_45;
        }
    
    }
    private void 丈丈万万上丒丙上上()
    {
        object val_178;
        UISprite val_179;
        UnityEngine.GameObject val_180;
        string val_181;
        string val_182;
        var val_183;
        var val_184;
        var val_185;
        var val_186;
        var val_187;
        UnityEngine.GameObject val_188;
        bool val_189;
        var val_190;
        var val_191;
        UnityEngine.Object val_192;
        val_178 = this;
        mem[1152921524395523796] = 0;
        mem2[0] = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._equippedCheckmark, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventItemBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leagueItemBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._greenWeaponBottomLeftIndicator, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rarityTopLeftDiagonalBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rarityTopLeftDiagonalBadgeIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCategoryTopLeftIcon, 丏业丟一东丂东丘丛:  false);
        this.丛且丒丄丁上万一丘 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MiscEquipContainer, 丏业丟一东丂东丘丛:  false);
        if(this.serverCustomSkin != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.serverCustomSkin, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.localCustomSkin != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.localCustomSkin, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.isEmpty == true)
        {
                return;
        }
        
        this.丅丛丑且不丐丌丑上();
        if(this.Category == 25000)
        {
                string val_178 = this.ItemId;
            val_178 = (~(Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  val_178))) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectionIndicator, 丏业丟一东丂东丘丛:  true);
        if((System.String.op_Equality(a:  this.ItemId, b:  "cape_Custom")) != false)
        {
                System.Collections.Generic.List<System.String> val_179 = 七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  this.Category);
            val_179 = val_179.Contains(item:  "cape_Custom");
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.capeRenderer.gameObject, 丏业丟一东丂东丘丛:  false);
        if((System.String.op_Equality(a:  this.ItemId, b:  "CustomSkinID")) != false)
        {
                var val_15 = (~this.丞丂丄万专丈丁业专()) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newSkinLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petCardsContainer, 丏业丟一东丂东丘丛:  false);
        goto label_32;
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.petName.Item[0].gameObject, 丏业丟一东丂东丘丛:  (this.Category == 30000) ? 1 : 0);
        label_32:
        if(1 < this.petName.Count)
        {
            goto label_38;
        }
        
        if(((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.Category)) != false) && ((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.ItemId)) != false))
        {
                var val_30 = (Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丈业七下丐丅丙东上() != (丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  this.ItemId))) ? 1 : 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.petLevel, 丏业丟一东丂东丘丛:  false);
        if(this.Category != 30000)
        {
            goto label_56;
        }
        
        System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_33 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄();
        if(val_33 == null)
        {
            goto label_56;
        }
        
        PGCompany.EggIncubatorProgress val_35 = val_33.Find(match:  new System.Predicate<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Boolean ArmoryCell::丁丅东丏丑丕丕丄丆(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且)));
        goto label_57;
        label_63:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eggCondition.Item[0].gameObject, 丏业丟一东丂东丘丛:  (val_35 != 0) ? 1 : 0);
        label_57:
        if(1 < this.eggCondition.Count)
        {
            goto label_63;
        }
        
        if(val_35 != null)
        {
            goto label_71;
        }
        
        object[] val_40 = new object[1];
        string val_41 = this.ItemId;
        val_40[0] = (val_41 == null) ? "null" : (val_41);
        UnityEngine.Debug.LogErrorFormat(format:  "UpdateAllAndStartUpdateCoroutine: egg == null, ItemId = {0}", args:  val_40);
        goto label_71;
        label_56:
        this.丝且丟丁一丒丑丏与();
        label_71:
        if(this.Category == 8)
        {
                var val_45 = (~this.丞丂丄万专丈丁业专()) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.modelForSkin, 丏业丟一东丂东丘丛:  false);
        丆丘丞不丒七丆与不 val_47 = WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId);
        val_179 = 丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId);
        丆丘丞不丒七丆与不 val_51 = 丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId);
        if(this.Category == 7)
        {
                丆丘丞不丒七丆与不 val_54 = ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId);
        }
        
        if((((val_47 != 2) && (val_179 != 2)) && (val_51 != 2)) && (0 != 2))
        {
                if(((System.String.op_Inequality(a:  this.ItemId, b:  "cape_Custom")) != true) && ((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  this.Category).Contains(item:  "cape_Custom")) != false))
        {
            
        }
        else
        {
                if(this.Category == 8)
        {
                bool val_62 = this.丞丂丄万专丈丁业专();
        }
        
        }
        
        }
        
        val_180 = this.Icon.gameObject;
        val_181 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_180, 丏业丟一东丂东丘丛:  true);
        this.丕一东万丟上下丘下();
        if(this.Category != 7)
        {
            goto label_106;
        }
        
        val_180 = 1152921505290498048;
        if((BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.ItemId))) == false)
        {
            goto label_106;
        }
        
        val_180 = 七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.ItemId);
        val_181 = 0;
        var val_73 = ((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_180)) > 0) ? 1 : 0;
        goto label_112;
        label_106:
        var val_180 = 0;
        label_112:
        var val_74 = (0 == 1) ? 1 : 0;
        var val_75 = (val_47 == 1) ? 1 : 0;
        val_75 = val_75 | ((val_179 == 1) ? 1 : 0);
        val_75 = val_75 | ((val_51 == 1) ? 1 : 0);
        val_74 = val_74 | val_75;
        val_180 = val_180 | val_74;
        if(val_180 != 0)
        {
                if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                int val_82 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId).业东丅东丌上丗丑不();
        }
        else
        {
                if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) != false)
        {
                int val_88 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.ItemId].业东丅东丌上丗丑不();
        }
        else
        {
                if(this.Category == 7)
        {
                int val_91 = 七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.ItemId);
        }
        else
        {
                int val_95 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[this.ItemId].业东丅东丌上丗丑不();
        }
        
        }
        
        }
        
            if(this.Category == 7)
        {
                一一万丒与专丙丁丛 val_97 = BalanceController.不丝丁万丁丁三专且(丞世不丒下上上丝丑:  val_95);
        }
        else
        {
                bool val_101 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().TryGetValue(下上丐丆丝丟丝丒不:  val_95, 丙业与丙丗丝不丈东: out  0);
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanDivisionOpenedItemContainer, 丏业丟一东丂东丘丛:  true);
            val_179 = this._clanDivisionShield;
            val_181 = 0;
            val_179.spriteName = System.String.Format(format:  "cup{0}_mini_thin", arg0:  val_100.世丝丌一且丝专丑丛() + 1);
        }
        
        this.丝丞且一下上丐三丞();
        val_182 = 0;
        if(this.Category != 8)
        {
            goto label_149;
        }
        
        if(this.丞丂丄万专丈丁业专() == true)
        {
            goto label_170;
        }
        
        if((System.String.op_Equality(a:  this.ItemId, b:  "CustomSkinID")) == false)
        {
            goto label_153;
        }
        
        val_179 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "skins_maker_skin");
        goto label_154;
        label_149:
        val_182 = "cape_Custom";
        val_181 = 0;
        if((System.String.op_Equality(a:  this.ItemId, b:  val_182)) == false)
        {
            goto label_170;
        }
        
        val_182 = "cape_Custom";
        val_181 = public System.Boolean System.Collections.Generic.List<System.String>::Contains(System.String item);
        if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  this.Category).Contains(item:  val_182)) == false)
        {
            goto label_170;
        }
        
        val_179 = 1152921505039646720;
        val_183 = null;
        val_183 = null;
        val_181 = 0;
        if(SkinsController.丌七丞东丟丌世且不 == 0)
        {
            goto label_170;
        }
        
        val_184 = null;
        val_184 = null;
        val_179 = SkinsController.丌七丞东丟丌世且不;
        val_181 = 0;
        this.capeRenderer.material.mainTexture = val_179;
        goto label_170;
        label_153:
        val_185 = null;
        val_185 = null;
        val_179 = SkinsController.与业七丙三三万丕上.Item[this.ItemId];
        label_154:
        val_181 = 0;
        this.modelForSkin.GetComponent<UnityEngine.MeshRenderer>().material.mainTexture = val_179;
        label_170:
        this.且丁万世丂丛丙丞三();
        if(this.Category != 2000)
        {
            goto label_187;
        }
        
        if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  this.ItemId)) == null)
        {
            goto label_178;
        }
        
        if(val_123.ToWeapons.Length == 0)
        {
                val_181 = 0;
        }
        
        三丅丁丗丗丝丂万且 val_124 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_123.ToWeapons[0]);
        if(val_124 == null)
        {
            goto label_183;
        }
        
        val_179 = val_124.三与丛丑且丐丈业丌();
        val_181 = Rilisoft.上丑业三丆丆丅丕三.丒业三七丗上丗丆丌(丝三丛且丘不丌丙下:  val_179);
        this.世丙丁丕丟丗丂丛丌(三与世丈丂丕丏三上:  val_124, 且丘世丏丛丛万丟万:  val_181);
        goto label_187;
        label_178:
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        goto label_187;
        label_183:
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        label_187:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if(this.Category != 7)
        {
                CategoryNames val_131 = this.Category;
            val_179 = val_131;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_182 = this.ItemId;
            val_181 = 0;
            val_182 = System.String.op_Equality(a:  Progress.七七世万专丕丁上业.专万不七丒丌丛丆三().丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  3, 下上丐丆丝丟丝丒不:  val_131.ToString()), b:  val_182);
            this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_182);
        }
        
        }
        
        if(this.Category == 7)
        {
                string val_183 = this.ItemId;
            val_181 = 0;
            val_183 = System.String.op_Equality(a:  丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7), b:  val_183);
            this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_183);
        }
        
        if((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                label_207:
            val_179 = this.Category;
            CategoryNames val_184 = val_179;
            val_181 = 0;
            val_184 = 丛且丗丌丏下七下丈.丁万丐东丂丙丙丕不(丞一丁业丄一一业且:  this.ItemId, 七丆丒与丗丌丄且丂:  val_184);
            this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_184);
        }
        else
        {
                if(this.Category == 2)
        {
                if(this.丗丙丗丄丛丞丛且不() == true)
        {
            goto label_207;
        }
        
        }
        
        }
        
        if(this.Category == 240000)
        {
                this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        }
        
        if(this.Category == 8)
        {
                val_186 = null;
            val_186 = null;
            this.丒上丑丞且专七丌丗(世万丗不丘丙丆世万:  (SkinsController.丂下丅丑丗一不东丘 == null) ? "" : SkinsController.丂下丅丑丗一不东丘, 万丗丈丙丐一三丈丌:  val_181);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.serverCustomSkin, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.localCustomSkin, 丏业丟一东丂东丘丛:  false);
            val_187 = null;
            val_187 = null;
            val_179 = this.ItemId;
            if((SkinsController.丄丞丁丈与业上丞丟.丂丗丌丐专丅丂丆丂(丞丅上丏丂且下丅与:  val_179)) != false)
        {
                val_188 = this.serverCustomSkin;
            val_189 = 1;
        }
        else
        {
                val_190 = null;
            val_188 = this.localCustomSkin;
            val_190 = null;
            val_179 = SkinsController.丄丞丁丈与业上丞丟.丞丄且丘丄且且丑丑(丞丅上丏丂且下丅与:  this.ItemId);
            val_189 = val_179;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_188, 丏业丟一东丂东丘丛:  val_189);
        }
        
        if(this.Category != 2000)
        {
                if(this.Category != 30000)
        {
            goto label_228;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  false);
        label_228:
        if(this.Category == 25000)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  false);
            string val_185 = this.ItemId;
            val_185 = System.String.op_Equality(a:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏(), b:  val_185);
            this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_185);
            val_179 = this.ItemId;
            if((丟下七丘下下丙丗丅.一三专丞丒丅上业上().ContainsKey(key:  val_179)) != false)
        {
                val_191 = null;
            UnityEngine.Color32 val_164 = ArmoryCell.七丒丒业下丕丅丕三();
            val_164.r = val_164.r & 4294967295;
            UnityEngine.Color val_165 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_164.r, g = val_164.r, b = val_164.r, a = val_164.r});
            this.coloredBorder.color = new UnityEngine.Color() {r = val_165.r, g = val_165.g, b = val_165.b, a = val_165.a};
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) != false)
        {
                val_179 = this.Category;
            string val_186 = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  val_179, 专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七());
            val_186 = System.String.op_Equality(a:  this.ItemId, b:  val_186);
            this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_186);
        }
        
        if(this.Category == 30000)
        {
                this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        }
        
        if(this.Category == 150000)
        {
                this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        }
        
        this.丟丂丁丄三不且丒丝();
        this.与业丄与丏上下专业();
        this.丗下三与七且丁丈万();
        this.丅万丆且丙丗丝业专();
        this.丏丈丞丐业专不世丝();
        this.丕丆世业丄且丈且上();
        this.丟世不一丏丞专上三();
        this.一丘丈丘丒丏与丙业();
        this.丈上上丆丄且七丘丁();
        this.丏专丈下上丒七世丅();
        this.不丐丆上业三东七万();
        val_192 = 0;
        if(this.priceCurrencyContainer != 0)
        {
                val_178 = this.priceCurrencyContainer;
            val_192 = val_178.GetComponent<UIWidget>();
        }
        
        if(val_192 == 0)
        {
                return;
        }
        
        val_192.UpdateAnchors();
    }
    internal void 丅丛丑且不丐丌丑上()
    {
        var val_4;
        if(this.Category != 25000)
        {
            goto label_1;
        }
        
        val_4 = (~(Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  this.ItemId))) & 1;
        if(!=0)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        val_4 = 1;
        if(!=0)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        enabled = true;
    }
    private void 丗下三与七且丁丈万()
    {
        UnityEngine.GameObject val_8;
        bool val_2 = 上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId);
        val_8 = this.getLevelToUnlockWeaponContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  val_2);
        if(val_2 == false)
        {
                return;
        }
        
        val_8 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}", arg0:  上丑三丁丄丛丁万丑.丝丈丐丘丟丁丘万丙(丞一丁业丄一一业且:  this.ItemId));
        this.getLevelToUnlockWeaponLabel.text = val_8;
    }
    protected override void 丂不丒丅丂丆一上万()
    {
        this.丆丝专丗世丅上丞且();
        this.丆世东七专丕且业丛();
    }
    private void 丆丒丟丏上丅下业丙(bool 下下东且万业丞丅丒)
    {
        this.discountSprite.alpha = (下下东且万业丞丅丒 != true) ? 1f : 0f;
    }
    private void 世丙丁丕丟丗丂丛丌(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上, string 且丘世丏丛丛万丟万)
    {
        if((且丘世丏丛丛万丟万 != null) && (三与世丈丂丕丏三上 != null))
        {
                if(this.Category != 2000)
        {
                return;
        }
        
            Rilisoft.WeaponSkin val_3 = Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  this.ItemId);
            if(val_3 == null)
        {
                return;
        }
        
            if((val_3.三万丘丙丆丛且上世(丝三丛且丘不丌丙下:  三与世丈丂丕丏三上.三与丛丑且丐丈业丌())) == false)
        {
                return;
        }
        
            string val_8 = this.ItemId;
            val_8 = System.String.op_Equality(a:  且丘世丏丛丛万丟万, b:  val_8);
            this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_8);
            return;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
    }
    private void 丒上丑丞且专七丌丗(string 世万丗不丘丙丆世万, string 万丗丈丙丐一三丈丌)
    {
        bool val_10;
        string val_10 = 世万丗不丘丙丆世万;
        if(((System.String.op_Equality(a:  this.ItemId, b:  "CustomSkinID")) == false) || (this.Category != 8))
        {
            goto label_2;
        }
        
        val_10 = 0;
        goto label_3;
        label_2:
        if(this.Category != 8)
        {
                return;
        }
        
        string val_5 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        if((System.String.op_Equality(a:  val_5, b:  "")) != true)
        {
                if((System.String.op_Equality(a:  val_5, b:  "EMPTY_ROYALE_AVATAR")) == false)
        {
            goto label_8;
        }
        
        }
        
        val_10 = System.String.op_Equality(a:  val_10, b:  this.ItemId);
        if(this != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        val_10 = val_10;
        label_3:
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_10);
        return;
        label_8:
        if(this != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }
    private void 丏丈丞丐业专不世丝()
    {
        if(this.ItemId == null)
        {
                return;
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丑丁不万丈丟万且业());
    }
    private void OnEnable()
    {
        if(this.isEmpty != false)
        {
                return;
        }
        
        this.业丟丞丟世与专丁丈();
        this.丈丈万万上丒丙上上();
    }
    private void OnDisable()
    {
        goto typeof(ArmoryCell).__il2cppRuntimeField_218;
    }
    protected override void 丁世丒专丟丙与丛丅()
    {
        this.丁世丒专丟丙与丛丅();
        SkinsController.万东丞东丕丝丄丛七(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void ArmoryCell::丒上丑丞且专七丌丗(string 世万丗不丘丙丆世万, string 万丗丈丙丐一三丈丌)));
        Rilisoft.上丑业三丆丆丅丕三.一丆丗丕上丘不丛丈(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且, System.String>(object:  this, method:  System.Void ArmoryCell::世丙丁丕丟丗丂丛丌(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上, string 且丘世丏丛丛万丟万)));
        丆丟七丌丞东丆丕丌.丆专丙丛与丗东下不(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, GadgetCategory, FilterMaps>(object:  this, method:  System.Void ArmoryCell::与业丑下上丆丟与三(string 业丝专丙丆世丞下丛, string 丒丂与丙丁丝丅丑世, GadgetCategory 丗且世丆上丏专与丐, FilterMaps 专丆丌丛东一不丑丙)));
        丛且丗丌丏下七下丈.丐丑三专且丑丆不不(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丅丕丙丙丁丅丄丘专(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.丏丒丌丑专三世与丟(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丏丛丄丟世业上丆丘(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.丕丞东上丗丄丞东丈(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::与丐丑丄丕东专一丘(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.丑丌下丟且丒三丝丙(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丝丗丞下下上且丌丅(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.专丗丁丙丂与丅丆一(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::业丟丒三丞丑丞丕丆(string 万且万且丑丗且丌丆)));
        WeaponManager.丛丞三丂丂东丌丝丗(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丏东丐不丝三与下与(string 万且万且丑丗且丌丆)));
    }
    private void 业丟丒三丞丑丞丕丆(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 200000)
        {
                return;
        }
        
        string val_4 = this.ItemId;
        val_4 = System.String.op_Equality(a:  万且万且丑丗且丌丆, b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    private void 丏东丐不丝三与下与(string 万且万且丑丗且丌丆)
    {
        if(this.丗丙丗丄丛丞丛且不() == false)
        {
                return;
        }
        
        if(this.Category != 2)
        {
                return;
        }
        
        string val_7 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId).三与丛丑且丐丈业丌();
        val_7 = System.String.op_Equality(a:  万且万且丑丗且丌丆, b:  val_7);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_7);
    }
    protected override void 上丄一丐丗丛东丈丌()
    {
        this.上丄一丐丗丛东丈丌();
        SkinsController.丑丛世丐丑丆专专上(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String>(object:  this, method:  System.Void ArmoryCell::丒上丑丞且专七丌丗(string 世万丗不丘丙丆世万, string 万丗丈丙丐一三丈丌)));
        Rilisoft.上丑业三丆丆丅丕三.一万丐三丅与万万丛(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且, System.String>(object:  this, method:  System.Void ArmoryCell::世丙丁丕丟丗丂丛丌(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上, string 且丘世丏丛丛万丟万)));
        丆丟七丌丞东丆丕丌.丂丌业一专业丑丛丛(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, GadgetCategory, FilterMaps>(object:  this, method:  System.Void ArmoryCell::与业丑下上丆丟与三(string 业丝专丙丆世丞下丛, string 丒丂与丙丁丝丅丑世, GadgetCategory 丗且世丆上丏专与丐, FilterMaps 专丆丌丛东一不丑丙)));
        丛且丗丌丏下七下丈.丞丟下丂丟东三丝丆(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丅丕丙丙丁丅丄丘专(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.丄丈丆与世丏专丞丕(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丏丛丄丟世业上丆丘(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.世丄业三一丞丅丌七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::与丐丑丄丕东专一丘(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.上丛丗丐下丅专东丟(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丝丗丞下下上且丌丅(string 万且万且丑丗且丌丆)));
        丛且丗丌丏下七下丈.丌上七七丏丅丑一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::业丟丒三丞丑丞丕丆(string 万且万且丑丗且丌丆)));
        WeaponManager.下丁丘世丏世丅丘丌(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ArmoryCell::丏东丐不丝三与下与(string 万且万且丑丗且丌丆)));
    }
    private void 丅丕丙丙丁丅丄丘专(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 160000)
        {
                return;
        }
        
        string val_4 = this.ItemId;
        val_4 = System.String.op_Equality(a:  万且万且丑丗且丌丆, b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    private void 丏丛丄丟世业上丆丘(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 210000)
        {
                return;
        }
        
        string val_4 = this.ItemId;
        val_4 = System.String.op_Equality(a:  万且万且丑丗且丌丆, b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    private void 与丐丑丄丕东专一丘(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 180000)
        {
                return;
        }
        
        string val_4 = this.ItemId;
        val_4 = System.String.op_Equality(a:  万且万且丑丗且丌丆, b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    private void 丝丗丞下下上且丌丅(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 190000)
        {
                if(this.Category != 8)
        {
                return;
        }
        
        }
        
        string val_5 = this.ItemId;
        val_5 = System.String.op_Equality(a:  万且万且丑丗且丌丆, b:  val_5);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_5);
    }
    protected override void 世且丞丞丁丅丟世丞(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 25000)
        {
                return;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
    }
    private void 与业丑下上丆丟与三(string 业丝专丙丆世丞下丛, string 丒丂与丙丁丝丅丑世, GadgetCategory 丗且世丆上丏专与丐, FilterMaps 专丆丌丛东一不丑丙)
    {
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  丗且世丆上丏专与丐)) == false)
        {
                return;
        }
        
        if(this.Category != 丗且世丆上丏专与丐)
        {
                return;
        }
        
        if(ShopNGUIController.丛丐丛专丟丞万三七() != 专丆丌丛东一不丑丙)
        {
                return;
        }
        
        string val_7 = this.ItemId;
        val_7 = System.String.op_Equality(a:  丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  丗且世丆上丏专与丐, 专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙), b:  val_7);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_7);
    }
    protected override void 且专下万东丄不万且(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)
    {
        if(this.Category != 25000)
        {
                return;
        }
        
        string val_4 = 一丕且丌业下丂丏且;
        val_4 = System.String.op_Equality(a:  this.ItemId, b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    private void 与东丕万丗丛专丈丁()
    {
        bool val_10;
        var val_11;
        if(this.Category != 8)
        {
                return;
        }
        
        if(this.丞丂丄万专丈丁业专() != true)
        {
                if((SkinsController.专万丒丅丐三丗东丂(且丘世丏丛丛万丟万:  this.ItemId)) == false)
        {
            goto label_5;
        }
        
        }
        
        val_10 = 0;
        goto label_6;
        label_5:
        val_10 = (~(SkinsController.七丞丌丁丂丌丏丟丘(专丑丐丅世丒不七丈:  this.ItemId))) & 1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedByLeagueContainer, 丏业丟一东丂东丘丛:  val_10);
        if(val_10 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        SkinItem val_8 = Item[this.ItemId];
        RatingLeague val_10 = val_8.currentLeague;
        val_10 = val_10 + 1;
        this.lockedByLeagueSprite.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  val_10);
    }
    private void 与上丂丕丗丄丘不丏()
    {
        UnityEngine.GameObject val_11;
        bool val_12;
        val_11 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponSkinsIndicator, 丏业丟一东丂东丘丛:  false);
        CategoryNames val_1 = this.Category;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_1)) != false)
        {
                this.七万丄丙丗丂丙丞下();
        }
        else
        {
                if(val_1 == 7)
        {
                this.一世七丆丁丗一三世();
        }
        
        }
        
        if(this.Category != 2000)
        {
                return;
        }
        
        if((Rilisoft.上丑业三丆丆丅丕三.丏丏与七东一丞世丄(且丘世丏丛丛万丟万:  this.ItemId)) != false)
        {
                val_12 = 0;
        }
        else
        {
                val_12 = (~(Rilisoft.上丑业三丆丆丅丕三.下丒丙七下丌且专丆(且丘世丏丛丛万丟万:  this.ItemId))) & 1;
        }
        
        val_11 = this.lockedByLeagueContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  val_12);
        if(val_12 == 0)
        {
                return;
        }
        
        Rilisoft.WeaponSkin val_9 = Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  this.ItemId);
        RatingLeague val_11 = val_9.ForLeague;
        val_11 = val_11 + 1;
        val_11 = System.String.Format(format:  "cup{0}_1", arg0:  val_11);
        this.lockedByLeagueSprite.spriteName = val_11;
    }
    private void 七万丄丙丗丂丙丞下()
    {
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  业上丙丞丐丄丆丅七());
        if(val_2 == null)
        {
                return;
        }
        
        if((丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  val_2.三与丛丑且丐丈业丌()).Count) < 1)
        {
                return;
        }
        
        PGCompany.丟丝东丈丐丙三下丛 val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝东丈丐丙三下丛>(丞世不丒下上上丝丑:  val_2.业东丅东丌上丗丑不());
        if(val_8 == null)
        {
                return;
        }
        
        if(val_8.丄丕三丄专丆丛丙专() != false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponSkinsIndicator, 丏业丟一东丂东丘丛:  true);
    }
    private void 一世七丆丁丗一三世()
    {
        if((PGCompany.丈三丁三丂一丅丆丆.丑七不且上丗丁一世().三丟丐东丗上东下万(且丂丟丈丈丑东丈丙:  七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  this.ItemId)).Count) < 2)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponSkinsIndicator, 丏业丟一东丂东丘丛:  true);
    }
    private void 丞世丗丁世与三上万()
    {
        var val_12;
        UnityEngine.GameObject val_13;
        if(this.Category != 6)
        {
                return;
        }
        
        int val_3 = 七丌丞万七万丁丐丙.丝丆丌丘丄丛与丆不(七丆丒与丗丌丄且丂:  6, 丝丒丞丙丐一一丅三:  this.ItemId);
        if(val_3 > RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏())
        {
                val_12 = (七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  this.Category).Contains(item:  this.ItemId)) ^ 1;
        }
        else
        {
                val_12 = 0;
        }
        
        val_13 = this.lockedByLeagueContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  val_12 & 1);
        if((val_12 & 1) == 0)
        {
                return;
        }
        
        val_13 = this.lockedByLeagueSprite;
        val_13.spriteName = System.String.Format(format:  "cup{0}_1", arg0:  val_3 + 1);
    }
    private void 丏不丂与丝丕东三世()
    {
        if(丕丙丆丐丗丙丆丐丅() != false)
        {
                this.itemViewController.丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  PGCompany.万丞丘与丕丞下万丌.与丒上与丄丒丝三七(丑丝丏丂且不下一东:  X21), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}));
            return;
        }
        
        this.itemViewController.丆世与丑丆丅丐万且();
    }
    private void 丄丂丏丏丝上丐丞万()
    {
        if(this.Category != 220000)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.detailsCountContainer, 丏业丟一东丂东丘丛:  false);
        this.equipped.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.petName, 丏业丟一东丂东丘丛:  false);
        this.丏不丂与丝丕东三世();
    }
    private void 三丆业丐东上东丅丂()
    {
        if(this.Category != 230000)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.detailsCountContainer, 丏业丟一东丂东丘丛:  false);
        this.equipped.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  this.petName, 丏业丟一东丂东丘丛:  false);
        this.丏不丂与丝丕东三世();
    }
    private void 丈业世丝丙专丘丟丕()
    {
        UILabel val_43;
        CategoryNames val_44;
        var val_45;
        var val_46;
        var val_47;
        val_43 = this;
        if(this.Category != 25000)
        {
            goto label_1;
        }
        
        if((Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  this.ItemId)) == false)
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petCardsContainer, 丏业丟一东丂东丘丛:  false);
        return;
        label_1:
        if(this.Category != 30000)
        {
            goto label_7;
        }
        
        if(val_7.IncubationStart < 1)
        {
            goto label_10;
        }
        
        string val_10 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丆丙丆不丟且三丗丕(丞丅上丏丂且下丅与:  this.ItemId)), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        goto label_14;
        label_4:
        PetInfo val_13 = 丟下七丘下下丙丗丅.一三专丞丒丅上业上().Item[this.ItemId];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petCardsContainer, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Color val_14 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_13.Rarity);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._petCardsSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a});
        if(val_13.CurrentLevel != (BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  val_13.Index)))
        {
            goto label_25;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._petCardsLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3701"));
        return;
        label_7:
        val_44 = this.Category;
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  val_44)) == false)
        {
                return;
        }
        
        val_44 = 丛且丗丌丏下七下丈.丑丈业上万一丁丛丂(七丙丈丆丕丄丐业丟:  this.ItemId);
        if((val_44 & 2147483648) != 0)
        {
                return;
        }
        
        val_44 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2496"), arg0:  val_44 + 1);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.petLevel, 丕丗丘丑丛与丑业丒:  val_44);
        return;
        label_25:
        七下下业三丞专丈丛 val_32 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.ItemId);
        val_43 = this._petCardsLabel;
        val_44 = val_32.专下与丑三丏丂不丆;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_43, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_32.专下与丑三丏丂不丆, arg1:  BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_13.Index, 且万丛丒丁丏七丅东:  val_13.CurrentLevel, 丐丏上业丈丂与万丞:  false)));
        return;
        label_10:
        if((BalanceController.万丒丘三丌万丛丟与(丈丕丁丘七丙丞不丙:  val_7.DataId)) != null)
        {
                val_45 = val_34.与丐丄丑上丌丑丅丘;
        }
        else
        {
                val_45 = 1;
        }
        
        label_14:
        val_46 = 0;
        goto label_54;
        label_58:
        this.eggCondition.Item[0].text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_45 * 60, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_46 = 1;
        label_54:
        if(val_46 < this.eggCondition.Count)
        {
            goto label_58;
        }
        
        val_47 = 0;
        goto label_65;
        label_69:
        this.petName.Item[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  val_7.DataId).丞与丏世丅专丄丝丛());
        val_47 = 1;
        label_65:
        if(val_47 < this.petName.Count)
        {
            goto label_69;
        }
    
    }
    private System.Collections.IEnumerator 丑丁不万丈丟万且业()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ArmoryCell.且丑丂丁丐丆丏上东(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丟丂丁丄三不且丒丝()
    {
        var val_14;
        System.Func<WeaponSkinSettings, System.Boolean> val_16;
        var val_17;
        System.Func<WeaponSkinSettings, System.Boolean> val_19;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newSkinsIndicator, 丏业丟一东丂东丘丛:  false);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.ItemId)) == true)
        {
                return;
        }
        
        if((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) == true)
        {
                return;
        }
        
        string val_6 = 丏丄丑上丛不丈且万.丘与丗业丁丞专丝世(丆万一不丌且东丐丐:  this.ItemId);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = ArmoryCell.<>c.<>9__137_0;
        if(val_16 == null)
        {
                System.Func<WeaponSkinSettings, System.Boolean> val_9 = null;
            val_16 = val_9;
            val_9 = new System.Func<WeaponSkinSettings, System.Boolean>(object:  ArmoryCell.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmoryCell.<>c::丄丆七下业东丒一丙(WeaponSkinSettings 三丟东丕丄丄下下丑));
            ArmoryCell.<>c.<>9__137_0 = val_16;
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = ArmoryCell.<>c.<>9__137_1;
        if(val_19 == null)
        {
                System.Func<WeaponSkinSettings, System.Boolean> val_11 = null;
            val_19 = val_11;
            val_11 = new System.Func<WeaponSkinSettings, System.Boolean>(object:  ArmoryCell.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmoryCell.<>c::万丕丟丞丟丙万丈丘(WeaponSkinSettings 三丟东丕丄丄下下丑));
            ArmoryCell.<>c.<>9__137_1 = val_19;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._newSkinsIndicator, 丏业丟一东丂东丘丛:  System.Linq.Enumerable.Any<WeaponSkinSettings>(source:  System.Linq.Enumerable.Where<WeaponSkinSettings>(source:  丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  val_6), predicate:  val_9), predicate:  val_11));
    }
    private bool 丁丁丏丛丏丅丁世丏()
    {
        var val_12;
        var val_13;
        string val_1 = this.ItemId;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
        {
                return (bool)0 & 1;
        }
        
        if((丆丞丐三与丞专丈丌.丗丅丁一丁丁不万丞(丞一丁业丄一一业且:  val_1)) == false)
        {
                return (bool)0 & 1;
        }
        
        if(this.Category == 30000)
        {
                return (bool)0 & 1;
        }
        
        val_12 = null;
        val_12 = null;
        if((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且())) != true)
        {
                if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == true)
        {
                return (bool)0 & 1;
        }
        
        }
        
        if((this.<不丕丌丛与丄万世丐>k__BackingField) != true)
        {
                if((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) == false)
        {
            goto label_18;
        }
        
        }
        
        return (bool)0 & 1;
        label_18:
        val_13 = null;
        val_13 = null;
        bool val_12 = (WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  this.ItemId)) ^ 1;
        return (bool)0 & 1;
    }
    private void 上丕丑丕丗万专丝丐()
    {
        var val_26;
        var val_27;
        丕丈丏丝丗下丟丅丂 val_10 = 0;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_3;
        }
        
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId);
        if(val_4 != null)
        {
                if(val_4.东七与与不丅丙上上() == false)
        {
            goto label_7;
        }
        
        }
        
        val_26 = 0;
        goto label_8;
        label_3:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) == false)
        {
            goto label_11;
        }
        
        val_27 = 0;
        if((val_10 == 0) || (((丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  this.ItemId, value: out  val_10)) ^ 1) == true))
        {
            goto label_32;
        }
        
        if((val_10.上东丌丂丟不下丒业(专丆丌丛东一不丑丙:  ShopNGUIController.丛丐丛专丟丞万三七())) == false)
        {
            goto label_19;
        }
        
        label_11:
        val_27 = 0;
        goto label_32;
        label_7:
        var val_25 = ~(val_4.上东丌丂丟不下丒业(丟丐上丟丆丙丄丗丈:  ShopNGUIController.丛丐丛专丟丞万三七()));
        val_26 = val_25 & 1;
        label_8:
        val_25 = (this.丗丙丗丄丛丞丛且不() != true) ? 0 : (val_26);
        var val_18 = (val_25 != 0) ? 1 : 0;
        label_32:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.darkForeground, 丏业丟一东丂东丘丛:  ((val_4 <= ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0) & 1);
        return;
        label_19:
        bool val_24 = (丁下万丟且丟丛下业.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) ^ 1;
        goto label_32;
    }
    private void 丆丆丞一丛丝丞丘丗()
    {
        mem[1152921524401717108] = 0;
        mem2[0] = 0;
    }
    private void 丈上丝丑东丈业万丅()
    {
    
    }
    private void 与业丄与丏上下专业()
    {
        var val_66;
        var val_67;
        string val_68;
        UnityEngine.GameObject val_69;
        var val_70;
        string val_71;
        var val_72;
        string val_73;
        string val_74;
        var val_75;
        var val_76;
        if(this.ItemId == null)
        {
            goto label_5;
        }
        
        val_66 = null;
        val_66 = null;
        if((WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  this.ItemId)) == false)
        {
            goto label_5;
        }
        
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_5 = WeaponManager.万一丛七丙丑丄丆丑();
        if((System.String.op_Inequality(a:  val_5.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  this.ItemId)) == false)
        {
            goto label_8;
        }
        
        if(this.与三丏丏且上丂丄丂() == null)
        {
            goto label_9;
        }
        
        var val_11 = (this.与三丏丏且上丂丄丂().Count == 0) ? 1 : 0;
        goto label_11;
        label_5:
        if(this.Category != 150000)
        {
            goto label_12;
        }
        
        val_68 = this.ItemId;
        label_57:
        System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_15 = WeaponManager.万一丛七丙丑丄丆丑();
        if((System.String.op_Inequality(a:  val_15.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  this.ItemId)) == false)
        {
            goto label_15;
        }
        
        if(this.与三丏丏且上丂丄丂() == null)
        {
            goto label_16;
        }
        
        var val_21 = (this.与三丏丏且上丂丄丂().Count == 0) ? 1 : 0;
        goto label_42;
        label_12:
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_29;
        }
        
        val_70 = null;
        val_70 = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  this.ItemId)) == false)
        {
            goto label_29;
        }
        
        System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_28 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  this, method:  System.Boolean ArmoryCell::丈丟丄丟东丈丞与丂(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑));
        if((System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  null)) == null)
        {
            goto label_29;
        }
        
        string val_30 = this.ItemId;
        goto label_57;
        label_29:
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_56;
        }
        
        new ArmoryCell.丘且丆丙不七业丛丒() = new ArmoryCell.丘且丆丙不七业丛丒();
        System.Predicate<System.Collections.Generic.List<System.String>> val_37 = new System.Predicate<System.Collections.Generic.List<System.String>>(object:  this, method:  System.Boolean ArmoryCell::丞丈丝丐世不万不丌(System.Collections.Generic.List<string> 丝丘丑业丛万丞丌丝));
        System.Collections.Generic.List<System.String> val_38 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().Item[this.Category].Find(match:  null);
        if(val_38 == null)
        {
            goto label_38;
        }
        
        val_71 = val_38.Item[0];
        if(new ArmoryCell.丘且丆丙不七业丛丒() == null)
        {
            goto label_39;
        }
        
        label_49:
        .丟万世世丆丘丞丁丈 = val_71;
        goto label_40;
        label_8:
        val_72 = 0;
        goto label_41;
        label_16:
        val_69 = 1;
        goto label_42;
        label_9:
        val_67 = 1;
        label_11:
        bool val_40 = (val_67 != 0) ? 1 : 0;
        label_41:
        val_69 = this.setMiniIconsHolder;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_69, 丏业丟一东丂东丘丛:  val_40);
        if(val_40 == 0)
        {
            goto label_60;
        }
        
        val_69 = "offer_icon_gacha_mini";
        this.setMiniIconWeapon.spriteName = "offer_icon_gacha_mini";
        this.setMiniIconElse.spriteName = "offer_icon_gacha_mini";
        goto label_60;
        label_38:
        val_73 = 0;
        if(new ArmoryCell.丘且丆丙不七业丛丒() != null)
        {
            goto label_49;
        }
        
        label_39:
        .丟万世世丆丘丞丁丈 = val_73;
        val_74 = (ArmoryCell.丘且丆丙不七业丛丒)[1152921524402287856].丟万世世丆丘丞丁丈;
        label_40:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_74)) == true)
        {
            goto label_56;
        }
        
        System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_44 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  new ArmoryCell.丘且丆丙不七业丛丒(), method:  System.Boolean ArmoryCell.丘且丆丙不七业丛丒::丐丗业丗丌万七一不(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑));
        if((System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  null)) == null)
        {
            goto label_56;
        }
        
        goto label_57;
        label_56:
        val_68 = 0;
        label_15:
        val_69 = 0;
        label_42:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setMiniIconsHolder, 丏业丟一东丂东丘丛:  false);
        if(val_69 != 0)
        {
                this.setMiniIconWeapon.spriteName = 丙丞丟丑丗丅专丈一.丝世丝丌丝丝万丌七(丐世下不一丁丟丅专:  val_68);
            val_69 = this.setMiniIconElse;
            val_69.spriteName = 丙丞丟丑丗丅专丈一.丝世丝丌丝丝万丌七(丐世下不一丁丟丅专:  val_68);
        }
        
        label_60:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.setMiniIconWeapon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.setMiniIconElse, 丏业丟一东丂东丘丛:  true);
        if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) == 2)
        {
                return;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
                return;
        }
        
        val_69 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId).业东丅东丌上丗丑不();
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_69)) == null)
        {
            goto label_79;
        }
        
        label_97:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.setMiniIconWeapon, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.setMiniIconElse, 丏业丟一东丂东丘丛:  false);
        return;
        label_79:
        val_75 = null;
        val_75 = null;
        val_69 = this.ItemId;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_69)) == true)
        {
                return;
        }
        
        val_69 = this.ItemId;
        if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_69)) == true)
        {
                return;
        }
        
        if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.ItemId)) == true)
        {
                return;
        }
        
        val_76 = null;
        val_76 = null;
        val_69 = this.ItemId;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_69)) == false)
        {
            goto label_97;
        }
    
    }
    private void 且与丁丆丂万丂丟上()
    {
        var val_13;
        if((this._moduleStorageView != 0) && ((System.Array.IndexOf<CategoryNames>(array:  WeaponManager.万三不丄丈丙与丁不(), value:  this.Category)) != 1))
        {
                val_13 = null;
            val_13 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且() != 170000)
        {
                if((Rilisoft.Singleton<PGCompany.ModulesController>.Instance.与丁上丌丝丟丑一丏()) != false)
        {
                if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) != 2)
        {
            goto label_15;
        }
        
        }
        
        }
        
        }
        
        label_26:
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleStorageView, 丏业丟一东丂东丘丛:  false);
        return;
        label_15:
        PGCompany.丗丟丅七东丄丙丟上 val_12 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丈丁丄丘丛世七丙丝:  this.ItemId);
        if(val_12 == null)
        {
            goto label_26;
        }
        
        this._moduleStorageView.丈且东丑丂且万丒丅(丑专丆丟丟丐丆一丕:  val_12);
        goto label_23;
    }
    protected override void 丂丗上专丘丌丙丛丏(string 丈丄丁丂丞丑下下丄, CategoryNames 上丌丛不业与世丑丏, string 与丑与丒丟丗万丙丁)
    {
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  与丑与丒丟丗万丙丁, b:  this.ItemId)) != false)
        {
                this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
        }
        
        if((System.String.op_Equality(a:  丈丄丁丂丞丑下下丄, b:  this.ItemId)) == false)
        {
                return;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  true);
    }
    protected override void 丌丌且东丒丈丐丌丌(CategoryNames 上丌丛不业与世丑丏, string 与丑与丒丟丗万丙丁)
    {
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  与丑与丒丟丗万丙丁, b:  this.ItemId)) == false)
        {
                return;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
    }
    internal override void 丐且专丙三丕丞专丅(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        if(this.丗丙丗丄丛丞丛且不() == true)
        {
                return;
        }
        
        if(this.Category != 丆丐七世世且丏丐业.丒万丕七专不丏丞丌())
        {
                return;
        }
        
        string val_7 = this.ItemId;
        val_7 = System.String.op_Equality(a:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), b:  val_7);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_7);
    }
    public void UpdateNewAndTopSeller()
    {
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        bool val_2 = 丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.ItemId);
        if(val_2 != false)
        {
                var val_5 = ((丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) == 2) ? 1 : 0;
        }
        else
        {
                val_56 = 0;
        }
        
        val_57 = 1152921505259880448;
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) != false)
        {
                var val_10 = ((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) == 2) ? 1 : 0;
        }
        else
        {
                val_58 = 0;
        }
        
        if(this.Category == 7)
        {
                var val_14 = ((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId)) != 2) ? 1 : 0;
        }
        else
        {
                val_59 = 1;
        }
        
        if(((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) != true) && ((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != true))
        {
                if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) != true)
        {
                if(this.Category != 8)
        {
            goto label_26;
        }
        
        }
        
        }
        
        val_60 = 1;
        if(val_2 == false)
        {
            goto label_31;
        }
        
        label_35:
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.ItemId)) == false)
        {
            goto label_31;
        }
        
        val_61 = 丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.ItemId);
        goto label_34;
        label_26:
        val_60 = val_2 & (((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false) ? 1 : 0);
        if(val_2 == true)
        {
            goto label_35;
        }
        
        label_31:
        val_61 = (丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丄七丅下丛丐且丏)) ^ 1;
        label_34:
        if((val_61 | this.equipped.activeSelf) != false)
        {
                val_62 = 0;
        }
        else
        {
                if(this.Category == 8)
        {
                val_62 = (~(SkinsController.七丞丌丁丂丌丏丟丘(专丑丐丅世丒不七丈:  this.ItemId))) & 1;
        }
        else
        {
                val_62 = 1;
        }
        
        }
        
        if((this.rented.activeSelf != true) && ((this.<丑丐与丅丅丛专丑丂>k__BackingField) != true))
        {
                if(this.unlocked.activeSelf == false)
        {
            goto label_49;
        }
        
        }
        
        label_67:
        val_63 = 0 & val_62;
        if(val_63 == 0)
        {
            goto label_70;
        }
        
        if(((丅且东丙业丏丛东丛.丑七不且上丗丁一世() == null) || ((丅且东丙业丏丛东丛.丑七不且上丗丁一世().上上上丑丝且专丄东(丞一丁业丄一一业且:  this.ItemId)) == false)) || ((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) == true))
        {
            goto label_60;
        }
        
        val_57 = 1152921505286238208;
        val_64 = null;
        val_64 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  this.ItemId)) == false)
        {
            goto label_64;
        }
        
        label_60:
        val_63 = 0;
        label_70:
        var val_46 = ((val_56 | val_58) == 0) ? 1 : 0;
        val_46 = val_46 & ((val_59 != 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topSeller, 丏业丟一东丂东丘丛:  val_46 & (((val_63 & val_60) == true) ? 1 : 0));
        return;
        label_49:
        var val_51 = (this.Category != 30000) ? 1 : 0;
        goto label_67;
        label_64:
        var val_54 = ((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) != 2) ? 1 : 0;
        goto label_70;
    }
    private bool 下丙丄不丙丂丗丛丌()
    {
        var val_39;
        string val_67;
        bool val_68;
        string val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        val_67 = this;
        val_68 = this.<丑丐与丅丅丛专丑丂>k__BackingField;
        string val_1 = this.ItemId;
        if(val_68 == false)
        {
            goto label_1;
        }
        
        val_69 = val_1;
        bool val_2 = 丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  val_69);
        goto label_34;
        label_1:
        val_68 = 1152921505259880448;
        if((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  val_1)) == true)
        {
            goto label_32;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_10;
        }
        
        val_68 = 1152921505286238208;
        if(((WeaponManager.丒上丙丕一丘三万丄(三不三丟专丘东东丂:  this.ItemId)) == true) || ((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) == 2))
        {
            goto label_32;
        }
        
        label_10:
        if(((丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) == 2) || ((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) == 2))
        {
            goto label_32;
        }
        
        if(this.Category == 7)
        {
                if((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId)) == 2)
        {
            goto label_32;
        }
        
        }
        
        if(this.Category != 250000)
        {
            goto label_27;
        }
        
        val_67 = this.ItemId;
        var val_21 = ((PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丏丗丗丛上丂一且丏(丞丅上丏丂且下丅与:  val_67)) != 0) ? 1 : 0;
        goto label_34;
        label_27:
        if(this.Category != 240000)
        {
            goto label_30;
        }
        
        val_68 = this.ItemId;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_68)) == false)
        {
            goto label_32;
        }
        
        label_81:
        val_69 = this.value ^ 1;
        goto label_34;
        label_30:
        if(this.Category == 8)
        {
                if(this.丞丂丄万专丈丁业专() != true)
        {
                if((SkinsController.七丞丌丁丂丌丏丟丘(专丑丐丅世丒不七丈:  this.ItemId)) == false)
        {
            goto label_39;
        }
        
        }
        
        }
        
        label_55:
        if(this.Category == 2000)
        {
                val_70 = (~(Rilisoft.上丑业三丆丆丅丕三.下丒丙七下丌且专丆(且丘世丏丛丛万丟万:  this.ItemId))) & 1;
        }
        else
        {
                val_70 = 0;
        }
        
        if(this.Category != 6)
        {
            goto label_61;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_36 = 七丌丞万七万丁丐丙.丈不丌下与丐丕东丟().GetEnumerator();
        label_50:
        if(((-1677900416) & 1) == 0)
        {
            goto label_48;
        }
        
        ConfiguredValueTaskAwaiter val_40 = val_39.GetAwaiter();
        if((val_40._value._obj.Contains(item:  this.ItemId)) == false)
        {
            goto label_50;
        }
        
        val_71 = 1;
        goto label_51;
        label_39:
        val_72 = null;
        val_72 = null;
        bool val_45 = SkinsController.丄万丘不丐丆东丕三.Contains(item:  this.ItemId);
        goto label_55;
        label_48:
        val_71 = 0;
        label_51:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_56;
        label_61:
        val_71 = 0;
        label_56:
        if(((this.Category != 160000) && (this.Category != 180000)) && (this.Category != 190000))
        {
                if(this.Category != 200000)
        {
                if(this.Category != 210000)
        {
            goto label_82;
        }
        
        }
        
        }
        
        label_82:
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丄七丅下丛丐且丏)) != false) && (this.丏丅丑丛东专丁丐七() != false))
        {
                val_68 = (~(Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.Category))) & 1;
        }
        else
        {
                val_68 = 0;
        }
        
        if(this.Category == 25000)
        {
                val_73 = Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  this.ItemId);
        }
        else
        {
                val_73 = 0;
        }
        
        var val_64 = val_70 | 0;
        val_64 = val_64 | val_71;
        val_64 = val_64 | ((~(丛且丗丌丏下七下丈.丞丈丐丈丂丕丐丌丂(丞一丁业丄一一业且:  this.ItemId))) & 1);
        val_64 = val_64 | ((this.Category == 30000) ? 1 : 0);
        val_64 = val_64 | val_68;
        val_73 = val_64 | val_73;
        if(val_73 == 0)
        {
            goto label_81;
        }
        
        label_32:
        val_69 = 0;
        label_34:
        val_69 = val_69 & 1;
        return (bool)val_69;
    }
    private void 丅万丆且丙丗丝业专()
    {
        this.boughtIndicator.alpha = (this.下丙丄不丙丂丗丛丌() != true) ? 1f : 0.01f;
        this.且丁万世丂丛丙丞三();
    }
    private void 丆世东七专丕且业丛()
    {
        bool val_17;
        var val_18;
        int val_7 = 0;
        this.丅万丆且丙丗丝业专();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  false);
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if(this.Category != 7)
        {
                if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false)
        {
            goto label_7;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  false);
        return;
        label_7:
        CategoryNames val_5 = this.Category;
        int val_8 = 七丌丞万七万丁丐丙.丐丛万丗丅丒业丐丙(丞丅上丏丂且下丅与:  this.ItemId, 下不东三七丘万丌业: out  false, 丁丂专业丁丅丅丈丙:  val_5, 业丟七丅丌三且与丛: out  val_7);
        if(val_8 > 0)
        {
                val_17 = 1;
        }
        else
        {
                if(val_7 < 2)
        {
                val_17 = 0;
        }
        else
        {
                val_17 = val_5.value;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradesContainer, 丏业丟一东丂东丘丛:  val_17);
        if(val_17 == false)
        {
                return;
        }
        
        val_18 = 0;
        goto label_20;
        label_31:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgrades.Item[0].gameObject, 丏业丟一东丂东丘丛:  (val_18 < val_7) ? 1 : 0);
        this.upgrades.Item[0].spriteName = (val_18 < val_8) ? "Lev_comp_gold_star" : "Lev_comp_gray_star";
        val_18 = 1;
        label_20:
        if(val_18 < this.upgrades.Count)
        {
            goto label_31;
        }
    
    }
    private void 丕丆世业丄且丈且上()
    {
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.GameObject val_24;
        世专丂一一丌万丅丆 val_15 = 0;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_8;
        }
        
        val_21 = null;
        val_21 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_8;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  this.ItemId);
        goto label_12;
        label_8:
        val_23 = 0;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rented, 丏业丟一东丂东丘丛:  false);
        val_24 = this.topSeller;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  ((val_23 == 0) ? 1 : 0) & val_24.activeSelf);
        if(val_23 == 0)
        {
                return;
        }
        
        if(this.rentedMatchesLeft == 0)
        {
                return;
        }
        
        val_24 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈一丂丏下东丑丂丘();
        if(val_15 == 0)
        {
                return;
        }
        
        if(((val_24.TryGetValue(key:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId).业东丅东丌上丗丑不(), value: out  val_15)) ^ 1) == true)
        {
                return;
        }
        
        val_24 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5048"), arg0:  val_15.与丏东丂丂丄丒丙丁());
        this.rentedMatchesLeft.text = val_24;
    }
    private static string 丕丈丞丞丏丘万丘丟(bool 丌丌东东丙丘丕丈丌)
    {
        return (string)(丌丌东东丙丘丕丈丌 != true) ? "Lev_comp_gold_star" : "Lev_comp_gray_star";
    }
    private bool 丏丅丑丛东专丁丐七()
    {
        var val_82;
        var val_83;
        bool val_69 = false;
        val_82 = 0;
        if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == true)
        {
                return (bool)val_82 & 1;
        }
        
        System.Nullable<System.Boolean> val_1 = this.三丕丆丛丈东丅丗丅();
        if(((-1676728548) & 1) == 0)
        {
            goto label_2;
        }
        
        label_67:
        var val_3 = (this.Category != 240000) ? 1 : 0;
        return (bool)val_82 & 1;
        label_2:
        if((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId)) == false)
        {
            goto label_6;
        }
        
        label_63:
        val_82 = 0;
        return (bool)val_82 & 1;
        label_6:
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if(((WeaponManager.丒上丙丕一丘三万丄(三不三丟专丘东东丂:  this.ItemId)) == true) || ((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  this.ItemId)) != 0))
        {
            goto label_63;
        }
        
        }
        
        丆丘丞不丒七丆与不 val_14 = 丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId);
        if(val_14 == 2)
        {
            goto label_63;
        }
        
        if(val_14 == 1)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_63;
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  this.Category)) != false)
        {
                if((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) != 0)
        {
            goto label_63;
        }
        
        }
        
        if(this.Category == 7)
        {
                if((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId)) != 0)
        {
            goto label_63;
        }
        
        }
        
        CategoryNames val_26 = this.Category;
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_34;
        }
        
        if(((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_26)) == false) || ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.ItemId).与丕丒世七丁万丂丛()) == true))
        {
            goto label_45;
        }
        
        goto label_98;
        label_34:
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_26)) == true)
        {
            goto label_45;
        }
        
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if(this.Category != 7)
        {
            goto label_49;
        }
        
        }
        
        if(this.Category != 7)
        {
            goto label_50;
        }
        
        label_45:
        bool val_36 = System.String.op_Inequality(a:  this.丈且丟丙丆丘业丈不, b:  this.丈丄七丅下丛丐且丏);
        label_95:
        label_98:
        if(this.Category != 180000)
        {
                if(this.Category != 190000)
        {
                if(this.Category != 200000)
        {
            goto label_53;
        }
        
        }
        
        }
        
        bool val_42 = (丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.ItemId)) ^ 1;
        return (bool)val_82 & 1;
        label_53:
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.Category)) == false)
        {
                return (bool)val_82 & 1;
        }
        
        int val_47 = 丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  this.ItemId);
        if((丛且丗丌丏下七下丈.丁专丌丕丕七一下丛(丞一丁业丄一一业且:  this.ItemId)) == true)
        {
            goto label_63;
        }
        
        int val_51 = Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丈业七下丐丅丙东上();
        goto label_67;
        label_50:
        if(this.Category != 8)
        {
            goto label_68;
        }
        
        if(this.丞丂丄万专丈丁业专() == false)
        {
            goto label_69;
        }
        
        goto label_98;
        label_49:
        System.Collections.Generic.Dictionary<丒丌上丈专丟丘丕丅, System.Collections.Generic.List<System.String>> val_54 = 七丌丞万七万丁丐丙.且下丈与丈一丙上万();
        if((val_54.Item[1].Contains(item:  this.ItemId)) == false)
        {
            goto label_75;
        }
        
        val_83 = val_54.Item[2].Contains(item:  this.ItemId);
        goto label_78;
        label_68:
        if(this.Category != 2000)
        {
            goto label_79;
        }
        
        bool val_64 = Rilisoft.上丑业三丆丆丅丕三.丕丟与丙丈一一丑丁(丂丒丘丅专丗丂世丛:  Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  this.ItemId));
        goto label_98;
        label_75:
        val_83 = 1;
        label_78:
        val_83 = val_83 & (System.String.op_Inequality(a:  this.丈且丟丙丆丘业丈不, b:  this.丈丄七丅下丛丐且丏));
        goto label_98;
        label_69:
        if((SkinsController.三不丛丏丟业丆一专(且丘世丏丛丛万丟万:  this.ItemId)) == true)
        {
            goto label_98;
        }
        
        var val_71 = (val_69 == 0) ? 1 : 0;
        val_71 = (SkinsController.七丞丌丁丂丌丏丟丘(专丑丐丅世丒不七丈:  this.ItemId, 丘七丟且丒七万丁下: out  val_69)) | val_71;
        if(val_71 == true)
        {
            goto label_98;
        }
        
        bool val_73 = SkinsController.专万丒丅丐三丗东丂(且丘世丏丛丛万丟万:  this.ItemId);
        goto label_98;
        label_79:
        if(this.Category != 250000)
        {
            goto label_93;
        }
        
        bool val_77 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丁丝丐三丄丟丟丄七(丞丅上丏丂且下丅与:  this.ItemId);
        goto label_95;
        label_93:
        if(this.Category != 240000)
        {
            goto label_98;
        }
        
        PGCompany.世东三上七丂丌下丑 val_83 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        val_83 = (val_83.不丌丝丗丒丛丏丙丌(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.ItemId)) ^ 1;
        goto label_98;
    }
    private bool 丏丅丑丛东专丁丐七(out bool 上一丁丑上丈丕丏丑)
    {
        string val_54;
        bool val_55;
        string val_56;
        var val_57;
        int val_58;
        val_54 = this;
        val_55 = this.丏丅丑丛东专丁丐七();
        上一丁丑上丈丕丏丑 = val_55;
        System.Nullable<System.Boolean> val_3 = this.三丕丆丛丈东丅丗丅();
        if(((-1676288964) & 1) != 0)
        {
                上一丁丑上丈丕丏丑 = false;
            return val_55;
        }
        
        System.Nullable<System.Boolean> val_4 = this.丑丄一上东丄万丑三();
        val_56 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
        if((val_56.ContainsKey(key:  this.ItemId)) == false)
        {
            goto label_9;
        }
        
        val_56 = this.ItemId;
        if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  val_56)) == false)
        {
            goto label_9;
        }
        
        val_56 = this.ItemId;
        val_57 = (~(丛且丗丌丏下七下丈.丁专丌丕丕七一下丛(丞一丁业丄一一业且:  val_56))) & 1;
        goto label_12;
        label_9:
        val_57 = 0;
        label_12:
        var val_12 = (val_57 == 0) ? 1 : 0;
        val_12 =  & val_12;
        if(val_12 == 1)
        {
                if(val_55 != false)
        {
                if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.ItemId))) == false)
        {
            goto label_22;
        }
        
        }
        
        }
        
            val_55 = 0;
            return val_55;
        }
        
        label_22:
        if((this.Category != 25000) || ((Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  this.ItemId)) == true))
        {
            goto label_27;
        }
        
        PetInfo val_23 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.ItemId);
        上一丁丑上丈丕丏丑 = ((BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  val_23.Index, 且万丛丒丁丏七丅东:  val_23.CurrentLevel, 丐丏上业丈丂与万丞:  false)) <= ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.ItemId)) == null)
        {
            goto label_36;
        }
        
        val_58 = val_31.专下与丑三丏丂不丆;
        if(val_23 != null)
        {
            goto label_39;
        }
        
        goto label_38;
        label_36:
        val_58 = 0;
        if(val_23 != null)
        {
            goto label_39;
        }
        
        label_38:
        label_39:
        bool val_35 = (上一丁丑上丈丕丏丑 == true) ? 1 : 0;
        val_35 = ((val_58 >= (BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_23.Index, 且万丛丒丁丏七丅东:  val_23.CurrentLevel, 丐丏上业丈丂与万丞:  false))) ? 1 : 0) & val_35;
        上一丁丑上丈丕丏丑 = val_35;
        label_27:
        if(((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false) && (this.Category != 7))
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.ItemId))) != false)
        {
                上一丁丑上丈丕丏丑 = false;
        }
        else
        {
                上一丁丑上丈丕丏丑 = ((七丌丞万七万丁丐丙.丅上业丛丛丈丒丝丐(与丘东下丈东丛丂万:  WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  this.ItemId))) <= ExpController.万上一丝丆且七丅丅()) ? 1 : 0;
        }
        
        }
        
        val_56 = this.Category;
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  val_56)) == false)
        {
                return val_55;
        }
        
        val_54 = this.ItemId;
        bool val_54 = ~(丛且丗丌丏下七下丈.丁专丌丕丕七一下丛(丞一丁业丄一一业且:  val_54));
        val_54 = val_54 & 1;
        上一丁丑上丈丕丏丑 = val_54;
        return val_55;
    }
    private void 丆丝专丗世丅上丞且()
    {
        UILabel val_98;
        UnityEngine.MonoBehaviour val_99;
        bool val_100;
        string val_102;
        var val_103;
        var val_104;
        UnityEngine.GameObject val_105;
        var val_106;
        var val_107;
        var val_108;
        var val_109;
        var val_110;
        int val_111;
        string val_112;
        var val_113;
        var val_114;
        var val_115;
        string val_116;
        string val_117;
        float val_118;
        var val_119;
        bool val_1 = false;
        bool val_2 = this.丏丅丑丛东专丁丐七(上一丁丑上丈丕丏丑: out  val_1);
        System.Nullable<System.Boolean> val_3 = this.三丕丆丛丈东丅丗丅();
        var val_5 = 1152921524405924264 & (((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false) ? 1 : 0);
        if(val_2 != false)
        {
                if(this.Category != 220000)
        {
            goto label_2;
        }
        
        }
        
        val_98 = this.priceLabel;
        val_99 = val_98;
        val_100 = 0;
        goto label_5;
        label_2:
        if((val_5 & 1) == 0)
        {
            goto label_6;
        }
        
        丈丞丕丘丕丗与上一 val_8 = PGCompany.GameplayLoop.丕与七丐丞丕丑业世.与丒一且丛丙丞丂专(丞一丁业丄一一业且:  this.ItemId);
        goto label_9;
        label_6:
        if(this.Category != 8)
        {
                if(this.Category != 2000)
        {
            goto label_11;
        }
        
        }
        
        val_102 = this.ItemId;
        goto label_12;
        label_11:
        val_102 = this.丈且丟丙丆丘业丈不;
        label_12:
        label_9:
        val_98 = 上丑三丁丄丛丁万丑.丟丘世丁丐丑丄丁丂(不三丙万与丗丌七丈:  this.Category, 丞一丁业丄一一业且:  val_102);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.priceLabel, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_98.丟丂丞不专丆万丒世()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gemSprite, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.coinSprite, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.freePriceLabel, 丏业丟一东丂东丘丛:  false);
        val_103 = null;
        val_103 = null;
        if((System.String.op_Equality(a:  val_98.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_23;
        }
        
        val_104 = null;
        val_105 = this.gemSprite;
        goto label_31;
        label_23:
        val_106 = null;
        val_106 = null;
        if((System.String.op_Equality(a:  val_98.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
        {
            goto label_29;
        }
        
        val_104 = null;
        val_105 = this.coinSprite;
        label_31:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_105, 丏业丟一东丂东丘丛:  true);
        label_50:
        val_107 = 1152921505369411584;
        if((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  this.Category)) == false)
        {
            goto label_35;
        }
        
        int val_98 = 丛且丗丌丏下七下丈.业丅万上丌专丄下丛(丙万丅万丅七丕业下:  this.ItemId);
        if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.ItemId)) != false)
        {
                if((丛且丗丌丏下七下丈.丁专丌丕丕七一下丛(丞一丁业丄一一业且:  this.ItemId)) == false)
        {
            goto label_41;
        }
        
        }
        
        val_108 = 0;
        goto label_42;
        label_35:
        if(this.Category != 8)
        {
                if(this.Category != 2000)
        {
            goto label_44;
        }
        
        }
        
        val_109 = 0;
        goto label_96;
        label_29:
        if((System.String.op_Equality(a:  val_98.东与三丌丅三丒丏业(), b:  "Free")) == false)
        {
            goto label_50;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.freePriceLabel, 丏业丟一东丂东丘丛:  true);
        goto label_50;
        label_41:
        label_42:
        var val_36 = (((Progress.七七世万专丕丁上业.丞万上丂丐万丏丕丟().丈业七下丐丅丙东上() != val_98) ? 1 : 0) != 0) ? 1 : 0;
        label_96:
        val_36 = val_1 & val_36;
        val_98 = val_36 & 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.isPriceForUpgrade, 丏业丟一东丂东丘丛:  val_98);
        val_100 = System.String.op_Inequality(a:  val_98.东与三丌丅三丒丏业(), b:  "Free");
        val_99 = this.priceLabel;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_99, 丏业丟一东丂东丘丛:  val_100);
        if((this.<丑丐与丅丅丛专丑丂>k__BackingField) == true)
        {
            goto label_100;
        }
        
        val_98 = this.ItemId;
        if((上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  val_98)) == true)
        {
            goto label_100;
        }
        
        if(this.Category == 8)
        {
                if((System.String.op_Equality(a:  this.ItemId, b:  "CustomSkinID")) != false)
        {
                if(this.丞丂丄万专丈丁业专() == false)
        {
            goto label_100;
        }
        
        }
        
        }
        
        if(this.Category == 30000)
        {
            goto label_100;
        }
        
        if(this.Category != 8)
        {
            goto label_65;
        }
        
        val_98 = this.ItemId;
        if((SkinsController.专万丒丅丐三丗东丂(且丘世丏丛丛万丟万:  val_98)) == false)
        {
            goto label_100;
        }
        
        label_65:
        if(this.Category != 2000)
        {
            goto label_69;
        }
        
        val_98 = this.ItemId;
        if((Rilisoft.上丑业三丆丆丅丕三.丏丏与七东一丞世丄(且丘世丏丛丛万丟万:  val_98)) == false)
        {
            goto label_100;
        }
        
        label_69:
        if(this.Category != 25000)
        {
            goto label_73;
        }
        
        val_98 = this.ItemId;
        if((Rilisoft.PetsManager.丕东丗下与丝丏丟一(世丐丗专丅三丝丑丆:  val_98)) == true)
        {
            goto label_100;
        }
        
        label_73:
        val_107 = 1152921505286238208;
        val_98 = this.ItemId;
        if((WeaponManager.万七丂丑丙丘丌丙丟(丞一丁业丄一一业且:  val_98)) != 0)
        {
            goto label_100;
        }
        
        val_98 = this.ItemId;
        if((丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  val_98)) == 2)
        {
            goto label_100;
        }
        
        if((丛且丗丌丏下七下丈.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  this.ItemId)) != 1)
        {
            goto label_85;
        }
        
        val_98 = Rilisoft.Singleton<ClansController>.Instance;
        if(val_98.丞丗丑丈一丅丗丌丟() == null)
        {
            goto label_100;
        }
        
        label_85:
        val_98 = this.ItemId;
        if((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  val_98)) == 0)
        {
            goto label_90;
        }
        
        label_100:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.discountSprite.gameObject, 丏业丟一东丂东丘丛:  false);
        return;
        label_44:
        bool val_67 = (丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丄七丅下丛丐且丏)) ^ 1;
        goto label_96;
        label_90:
        if(this.Category == 7)
        {
                if((ShopNGUIController.丙丑丐丈丆丝丐且丗(丙丄不丈专丕与万万:  this.ItemId)) != 0)
        {
            goto label_100;
        }
        
        }
        
        if(val_5 != 0)
        {
                val_110 = PGCompany.GameplayLoop.丕与七丐丞丕丑业世.丞丁丌丗七丒丗丅业(丞一丁业丄一一业且:  this.ItemId);
            val_111 = 0;
        }
        else
        {
                if(this.Category == 8)
        {
                val_112 = this.ItemId;
        }
        else
        {
                val_112 = this.丈且丟丙丆丘业丈不;
        }
        
            val_111 = 上丑三丁丄丛丁万丑.丅专万丅丟丈丏专丅(丕丁下丌不万丅丞丛:  val_112, 与业与丗专丂丆与业: out  false);
            val_110 = 0;
        }
        
        val_113 = null;
        val_113 = null;
        if((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  this.ItemId)) == false)
        {
            goto label_112;
        }
        
        label_117:
        val_114 = 1;
        goto label_120;
        label_112:
        var val_79 = (val_111 > 0) ? 1 : 0;
        val_79 = val_79 | ((val_110 > 0) ? 1 : 0);
        val_79 = val_2 & val_79;
        if(val_79 != true)
        {
            goto label_114;
        }
        
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) == false)
        {
            goto label_117;
        }
        
        var val_85 = ((WeaponManager.上丐一丏丞丈三丙丗(丒东业不丐丑丕丄丆:  this.ItemId)) == null) ? 1 : 0;
        goto label_120;
        label_114:
        val_114 = 0;
        label_120:
        if(val_114 != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_125;
        }
        
        }
        
        val_115 = 0;
        goto label_126;
        label_125:
        label_126:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.discountSprite.gameObject, 丏业丟一东丂东丘丛:  (this.Category != 220000) ? 1 : 0);
        if(val_114 == 0)
        {
                return;
        }
        
        if(this.Category == 220000)
        {
                return;
        }
        
        if((val_5 & 1) != 0)
        {
                string val_99 = this.ItemId;
            string val_92 = PGCompany.GameplayLoop.丕与七丐丞丕丑业世.丂世丗丟丞丒丂万一(丞一丁业丄一一业且:  val_99);
            val_99 = (val_92 == null) ? "" : (val_92);
        }
        else
        {
                val_116 = System.String.Format(format:  "{0}%", arg0:  val_111);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.discountLabel, 丕丗丘丑丛与丑业丒:  val_116);
        val_117 = 0;
        if(this.discountLabel.value != false)
        {
                val_118 = 1f;
        }
        else
        {
                val_119 = null;
            val_119 = null;
            val_117 = this.ItemId;
        }
        
        this.discountSprite.alpha = ((WeaponManager.丟丗丄业丘丗业丗七.世世丟上三与东丘不(丒东业不丐丑丕丄丆:  val_117)) != true) ? 1f : 0f;
    }
    private bool 丞丂丄万专丈丁业专()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if((System.String.op_Equality(a:  this.ItemId, b:  "CustomSkinID")) != false)
        {
                val_6 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            val_7 = (val_6.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  26)) ^ 1;
            return (bool)val_7 & 1;
        }
        
        val_7 = 0;
        return (bool)val_7 & 1;
    }
    private void 丞丁丑且丞丈不上丑(bool 丗丛不丁丑专专丂且)
    {
        bool val_12;
        var val_13;
        int val_14;
        var val_15;
        val_12 = 0;
        if(((this.<丑丐与丅丅丛专丑丂>k__BackingField) != true) && (丗丛不丁丑专专丂且 != false))
        {
                val_12 = (~(上丑三丁丄丛丁万丑.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.ItemId))) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipped, 丏业丟一东丂东丘丛:  val_12);
        this.UpdateNewAndTopSeller();
        this.丑万丅丂丈东专丞东(一且上丗三丝丈业七:  this.业丌不丞业世丞丗丗());
        var val_5 = (this.万上东不上专世丂三 == 1) ? 1 : 0;
        val_5 = val_12 & val_5;
        if(val_5 == 0)
        {
            goto label_7;
        }
        
        this.万上东不上专世丂三 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  val_12);
        label_21:
        val_13 = null;
        val_13 = null;
        label_25:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丞丘丒与上丄丗上一(丌丝万上丅丒一丈丘:  this.transform);
        return;
        label_7:
        val_14 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  val_12);
        this.万上东不上专世丂三 = val_14;
        if((丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  this.万上东不上专世丂三)) == false)
        {
            goto label_15;
        }
        
        if((丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  val_14)) == false)
        {
            goto label_18;
        }
        
        val_14 = this.万上东不上专世丂三;
        label_15:
        if((丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  val_14)) == true)
        {
            goto label_21;
        }
        
        return;
        label_18:
        val_15 = null;
        val_15 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
            goto label_25;
        }
        
        goto label_25;
    }
    private UnityEngine.Color 丏丟丏与且丛丅丁不(ItemRarity 丈下丑丆上丏丗丈专)
    {
        var val_1;
        float val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        if(丈下丑丆上丏丗丈专 <= 4)
        {
                var val_1 = 106015044 + (丈下丑丆上丏丗丈专) << 2;
            val_1 = val_1 + 106015044;
        }
        else
        {
                val_1 = 1152921505035493376;
            val_7 = null;
            val_7 = null;
            val_3 = 1152921505035497556;
            val_4 = 1152921505035497560;
            val_5 = 1152921505035497564;
            val_6 = 1152921505035497568;
            return new UnityEngine.Color() {g = mem[1152921505035497544], b = mem[1152921505035497548], a = mem[1152921505035497552]};
        }
    
    }
    private void 丂丅丅丕东丛丌东丑()
    {
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  this.Category)) != false)
        {
                if(this.Category != 7)
        {
            goto label_4;
        }
        
        }
        
        string val_4 = this.ItemId;
        goto label_5;
        label_4:
        label_5:
        this.丈且丟丙丆丘业丈不 = WeaponManager.一丅丅万丄丅丘丆专(丒东业不丐丑丕丄丆:  this.ItemId);
    }
    protected override void OnDoubleClick()
    {
        var val_9;
        this.OnDoubleClick();
        if((System.String.op_Inequality(a:  this.ItemId, b:  "cape_Custom")) != false)
        {
                if((System.String.op_Inequality(a:  this.ItemId, b:  "CustomSkinID")) != false)
        {
                if(this.Category != 8)
        {
                return;
        }
        
            val_9 = null;
            val_9 = null;
            if(SkinsController.东与一丕专万丞丕与 == null)
        {
                return;
        }
        
            if((SkinsController.东与一丕专万丞丕与.Contains(item:  this.ItemId)) == false)
        {
                return;
        }
        
        }
        
        }
        
        this.丒丒丂七丈丂不丄三();
    }
    private bool 万下丝东七丙万丒业()
    {
        return PGCompany.GameplayLoop.丕与七丐丞丕丑业世.万下丝东七丙万丒业(丞一丁业丄一一业且:  this.ItemId);
    }
    private System.Nullable<bool> 三丕丆丛丈东丅丗丅()
    {
        if((this.丘三不丟丏东丘丕丁 & 1) == 0)
        {
                bool val_2 = this.万下丝东七丙万丒业();
            this.丘三不丟丏东丘丕丁 = 0;
        }
        
        System.Nullable<System.Boolean> val_3 = this.丘三不丟丏东丘丕丁 & 1;
        return 0;
    }
    private void 丙丝业丙丞丞丙下丅(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        this.丘三不丟丏东丘丕丁 = 丙业与丙丗丝不丈东.HasValue;
    }
    private System.Nullable<bool> 丑丄一上东丄万丑三()
    {
        if((this.丟丁丏丏专丄业万下 & 1) == 0)
        {
                string val_5 = this.ItemId;
            val_5 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丅世丘业丙丞丆丕丞(下丅丙一丂丗丅丝七:  val_5);
            mem2[0] = 0;
        }
        
        System.Nullable<System.Boolean> val_4 = this.丟丁丏丏专丄业万下 & 1;
        return 0;
    }
    private void 丑丟东一上丅不丗上(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        this.丟丁丏丏专丄业万下 = 丙业与丙丗丝不丈东.HasValue;
    }
    private System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 丘丘丌丌不丘专丘上()
    {
        if(this.丈丑三丁丕丏三丐三 != null)
        {
                return val_3;
        }
        
        System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_3 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().七丏专丆丐丘专丕丝(下丅丙一丂丗丅丝七:  this.ItemId);
        this.丈丑三丁丕丏三丐三 = val_3;
        return val_3;
    }
    private void 丈丌丅丅丄丕丅业不(System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 丙业与丙丗丝不丈东)
    {
        this.丈丑三丁丕丏三丐三 = 丙业与丙丗丝不丈东;
    }
    private System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 与三丏丏且上丂丄丂()
    {
        if(this.丟业万丞丌丙丙丏丅 != null)
        {
                return val_3;
        }
        
        System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_3 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世().丐丕业丙丗业丏丛且(下丅丙一丂丗丅丝七:  this.ItemId);
        this.丟业万丞丌丙丙丏丅 = val_3;
        return val_3;
    }
    private void 丗丁丄丗一丙业丁丒(System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 丙业与丙丗丝不丈东)
    {
        this.丟业万丞丌丙丙丏丅 = 丙业与丙丗丝不丈东;
    }
    private void 丁丘丄丌上丘丐丒丏()
    {
        TagSystem.CompoundTagBehaviour val_2 = this.bg.gameObject.GetComponent<TagSystem.CompoundTagBehaviour>();
        if(val_2 == 0)
        {
                return;
        }
        
        val_2.与上丒丆丟与丘与丑();
    }
    private void 丏与上东不不下世不()
    {
        TagSystem.CompoundTagBehaviour val_8 = this.bg.gameObject.GetComponent<TagSystem.CompoundTagBehaviour>();
        if(val_8 == 0)
        {
                val_8 = this.bg.gameObject.AddComponent<TagSystem.CompoundTagBehaviour>();
        }
        
        if((val_8.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "ArmoryCellM16")) != false)
        {
                return;
        }
        
        val_8.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  "ArmoryCellM16");
    }
    private void 丟世不一丏丞专上三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._equippedCheckmark, 丏业丟一东丂东丘丛:  false);
        if(this.Category != 240000)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._equippedCheckmark, 丏业丟一东丂东丘丛:  丏丞丛上七丁丞丛万.与丏丘丏丆丗丌专丅(丞丝丌七丁万丗丐一:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.ItemId)));
    }
    private void 丈上上丆丄且七丘丁()
    {
        UnityEngine.GameObject val_15;
        PGCompany.三东丏不丗世丅丌丄 val_16;
        var val_17;
        val_15 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._greenWeaponBottomLeftIndicator, 丏业丟一东丂东丘丛:  false);
        if(this.Category != 240000)
        {
                return;
        }
        
        PGCompany.丟丝世万东万丆丟上 val_5 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.ItemId);
        if(val_5 != null)
        {
                val_16 = val_5.上专丗丏丛丁专丑丄().ItemWeapon.丑丐丙丄丅世世丑丒();
        }
        else
        {
                val_16 = 0;
        }
        
        if(this._equippedCheckmark != 0)
        {
                val_17 = (~this._equippedCheckmark.activeInHierarchy) & 1;
        }
        else
        {
                val_17 = 1;
        }
        
        val_15 = this._greenWeaponBottomLeftIndicator;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  (PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_16, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false})) & ((val_17 != 0) ? 1 : 0));
    }
    private void 不丐丆上业三东七万()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MiscEquipContainer, 丏业丟一东丂东丘丛:  false);
        if(this.Category != 250000)
        {
                return;
        }
        
        string val_5 = this.ItemId;
        val_5 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().专专丏下不丙丈丘丌(丞丅上丏丂且下丅与:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MiscEquipContainer, 丏业丟一东丂东丘丛:  val_5);
    }
    private void 一丘丈丘丒丏与丙业()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rarityTopLeftDiagonalBadge, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rarityTopLeftDiagonalBadgeIcon, 丏业丟一东丂东丘丛:  false);
        if(this.Category == 240000)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.ItemId)) != null)
        {
            
        }
        else
        {
                UnityEngine.Color val_5 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  0);
        }
        
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rarityTopLeftDiagonalBadgeIcon, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rarityTopLeftDiagonalBadge, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rarityTopLeftDiagonalBadgeIcon, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.Category != 250000)
        {
                return;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  this.ItemId)) != null)
        {
            
        }
        else
        {
                UnityEngine.Color val_10 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  0);
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rarityTopLeftDiagonalBadgeIcon, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rarityTopLeftDiagonalBadge, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rarityTopLeftDiagonalBadgeIcon, 丏业丟一东丂东丘丛:  true);
    }
    private void 丏专丈下上丒七世丅()
    {
        int val_6;
        string val_7;
        UnityEngine.Texture val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCategoryTopLeftIcon, 丏业丟一东丂东丘丛:  false);
        val_6 = System.String.alignConst;
        CategoryNames val_1 = this.Category;
        if(val_1 == 250000)
        {
            goto label_3;
        }
        
        if(val_1 != 240000)
        {
            goto label_4;
        }
        
        val_7 = "icon_shop_misc_skins_mini";
        goto label_7;
        label_3:
        val_7 = "icon_shop_misc_graffiti_mini";
        label_7:
        val_6 = System.IO.Path.Combine(path1:  "Textures", path2:  val_7);
        label_4:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
        {
                return;
        }
        
        if(this.丛且丒丄丁上万一丘 == 0)
        {
                val_8 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_6);
            this.丛且丒丄丁上万一丘 = val_8;
        }
        else
        {
                val_8 = this.丛且丒丄丁上万一丘;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._itemCategoryTopLeftIcon, 与万丆丛丒万丝丙丑:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemCategoryTopLeftIcon, 丏业丟一东丂东丘丛:  true);
    }
    protected override void OnClick()
    {
        this.OnClick();
        if(this.Category != 250000)
        {
                return;
        }
        
        PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丒丌三东丄且业丞丞(丞丅上丏丂且下丅与:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  190, 丞丅上丏丂且下丅与:  this.ItemId).业东丅东丌上丗丑不());
    }
    public ArmoryCell()
    {
        this.万上东不上专世丂三 = 0;
        this.丒丒三丅丈万丝不丞 = "";
        this.丈且丟丙丆丘业丈不 = "";
        this.丈丄七丅下丛丐且丏 = "";
    }
    private static ArmoryCell()
    {
        ArmoryCell.丅三丞且丄丗七丙丛 = 0;
        ArmoryCell.丝丝丐且丒丑世丌专 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_8 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_10 = 0;
        ArmoryCell.世业专丅丝上且丙东 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_18 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_20 = 0;
        ArmoryCell.不一丟丕一丘丆丗下 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_28 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_30 = 0;
        ArmoryCell.丘万丙丑丒丏丂丏且 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_38 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_40 = 0;
        ArmoryCell.丁丆三丗丈丐丝丙丗 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_48 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_50 = 0;
        ArmoryCell.三丄三万丆丐与专丁 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_58 = 0;
        ArmoryCell.丅三丞且丄丗七丙丛.__il2cppRuntimeField_60 = 0;
    }
    private bool 与不上丄丕丙上上丒(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)
    {
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝 == null)
        {
                return false;
        }
        
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
        {
                return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.ItemId);
        }
        
        return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.ItemId);
    }
    private bool 丗与丒丑业丕丕丝与(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)
    {
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝 == null)
        {
                return false;
        }
        
        if(万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
        {
                return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.ItemId);
        }
        
        return 万丗丅七丘丗与丈丑.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  this.ItemId);
    }
    private bool 丁丅东丏丑丕丕丄丆(PGCompany.EggIncubatorProgress 丗丛不丁丑专专丂且)
    {
        return System.String.op_Equality(a:  丗丛不丁丑专专丂且.Id.ToString(), b:  this.ItemId);
    }
    private bool 丈丟丄丟东丈丞与丂(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)
    {
        if(万丗丅七丘丗与丈丑.丝丈不丗丐不丙丟丁 == null)
        {
                return (bool)万丗丅七丘丗与丈丑.丝丈不丗丐不丙丟丁;
        }
        
        return System.Linq.Enumerable.Contains<System.String>(source:  万丗丅七丘丗与丈丑.丝丈不丗丐不丙丟丁.Values, value:  this.ItemId);
    }
    private bool 丞丈丝丐世不万不丌(System.Collections.Generic.List<string> 丝丘丑业丛万丞丌丝)
    {
        if(丝丘丑业丛万丞丌丝 != null)
        {
                return 丝丘丑业丛万丞丌丝.Contains(item:  this.ItemId);
        }
        
        return 丝丘丑业丛万丞丌丝.Contains(item:  this.ItemId);
    }

}
