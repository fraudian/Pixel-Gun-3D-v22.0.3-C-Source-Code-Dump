using UnityEngine;
public sealed class PropertiesArmoryItemContainer : MonoBehaviour
{
    // Fields
    private UIButton propertiesPopupButton;
    private UIButton propertiesPopupMeleeButton;
    private UIButton propertiesPopupCraftButton;
    private PropertiesPopupController propertiesPopupController;
    private System.Collections.Generic.List<PGCompany.FreeUpCategoryGuiNotification> freeUpUpgradeButtonIndicators;
    public UnityEngine.GameObject petsAndEggsEmptyProperties;
    public UILabel eggNameLabel;
    public UnityEngine.GameObject hatchingOtherEgg;
    public SpeedupEggButton speedupEggForGold;
    public UILabel hatchEggTimeLabel;
    public UILabel speedupEggTimeAdvertiesementRewards;
    public UILabel instantHatchEggPrice;
    public UnityEngine.GameObject eggHatchButton;
    public UnityEngine.GameObject eggInstantButton;
    public UnityEngine.GameObject eggSpeedupButton;
    public UnityEngine.GameObject eggSpeedupAdButton;
    public UnityEngine.GameObject boughtArmorClosedByDivision;
    public UILabel boughtArmorClosedByDivisionLabel;
    public UISprite boughtArmorClosedByDivisionShield;
    public UILabel emptyPropertiesDescriptionLabel;
    public UnityEngine.GameObject infoScreenDivisionShieldContainer;
    public UISprite infoScreenDivisionShield;
    public UnityEngine.GameObject closedByDivisionGunProperties;
    public UILabel closedByDivisionGunPropertiesLabel;
    public UILabel closedByDivisionGunPropertiesHeader;
    public UIButton goToClans;
    public UnityEngine.GameObject goToClansDisabled;
    public UILabel goToClansLevelRequired;
    public UnityEngine.GameObject goToClansGetParts;
    public UpgradeWeaponButton maxUpgradeWeaponBtn;
    public UpgradeWeaponButton oneUpgradeWeaponBtn;
    public UpgradeWeaponButton rarityUpgradeWeaponBtn;
    public UnityEngine.GameObject offlineUpgradeBtn;
    public EfficiencyBar efficiencyWeaponBar;
    public UnityEngine.GameObject maxUpgradeWeaponGoToTraiderBtn;
    public UILabel maxUpgradeWeaponGoToTraiderDays;
    public UnityEngine.GameObject rarityUpgradeWeaponGoToTraiderBtn;
    public UILabel rarityUpgradeWeaponGoToTraiderDays;
    public UnityEngine.GameObject weaponBackground;
    public UnityEngine.GameObject background;
    public UnityEngine.GameObject shopRightContainer;
    public UnityEngine.GameObject shopProperties;
    public PGCompany.LoopCustomUiSetter loopUiSetter;
    public PGCompany.LoopCustomUiSetter loopUiBgSetter;
    public UnityEngine.GameObject settingPlashka;
    public UnityEngine.GameObject targetActionTimerContainer;
    public UILabel targetActionTimer;
    public UnityEngine.GameObject tournamentProPlashka;
    public UILabel battleRoyaleDescription;
    public UnityEngine.GameObject LevelRequirdForGrayedItems;
    public UILabel LevelRequirdForGrayedItemsLabels;
    public UIButton discountButtonTargetActions;
    public UnityEngine.GameObject goToCraftEventSectionButton;
    public UnityEngine.GameObject winSetButton;
    public UnityEngine.GameObject goToEventRouletButton;
    public UIButton goToTournamentButton;
    public UnityEngine.GameObject goToGatchaButton;
    public UnityEngine.GameObject goToChestsEventButton;
    public UnityEngine.GameObject goToContestButton;
    public UIButton freeBattlePassButton;
    public UIButton paidBattlePassButton;
    public UnityEngine.GameObject setTip;
    public UILabel craftSetName;
    public UILabel craftSetDescription;
    public UILabel craftAvatarName;
    public UnityEngine.GameObject categoryBackground;
    public UILabel categoryLabel;
    public System.Collections.Generic.List<UILabel> noviceArmorMatchesLeft;
    public UnityEngine.GameObject eventStoreUniquePlashka;
    public UnityEngine.GameObject eventStoreTimerContainer;
    public UILabel eventStoreTimer;
    public UnityEngine.GameObject eventStoreBackground;
    public UnityEngine.GameObject[] craftEventAvatarItemContainers;
    public UILabel[] craftEventAvatarItemNames;
    public UILabel[] craftEventAvatarItemProperties;
    public UnityEngine.GameObject craftSetsProperties;
    public UnityEngine.GameObject craftEventAvatarProperties;
    public UnityEngine.GameObject buyDetailsButton;
    public UnityEngine.GameObject itemIsCrafted;
    public UILabel gunInRentLabel;
    public UILabel armorDurability;
    public SpeedUpButtonControl speedupCraft;
    public SpeedUpButtonControl speedupArmor;
    public bool disableAnimations;
    public UnityEngine.GameObject freeUp;
    public UnityEngine.GameObject freeUpWeapon;
    public UnityEngine.GameObject gemPrice;
    public UnityEngine.GameObject coinPrice;
    public UILabel priceLabel;
    public UIToggle skinsButton;
    public UISprite tierShieldSprite;
    public UILabel upgradingToLevel;
    public UILabel upgradingTimeRemains;
    public UIButton craftButton;
    public UIButton crateLootButton;
    public UIButton openCrateButton;
    public UnityEngine.GameObject needTierPet;
    public UILabel needTierPetLabel;
    public UnityEngine.GameObject needMoreTrophiesPanel;
    public UnityEngine.GameObject renamePetButton;
    public UITable specialTable;
    public UITable gadgetPropertyTable;
    public UITable armorPropertyTable;
    public UnityEngine.GameObject specialVehicleContainer;
    public SetHeadLabelText transportLevelLabel;
    public UnityEngine.GameObject specialParamsBackground;
    public UnityEngine.GameObject weaponProperties;
    public UnityEngine.GameObject meleeProperties;
    public UnityEngine.GameObject specialParams;
    public UnityEngine.GameObject nonArmorWearProperties;
    public UnityEngine.GameObject armorWearProperties;
    public UnityEngine.GameObject skinProperties;
    public UnityEngine.GameObject gadgetProperties;
    public UnityEngine.GameObject leagueSkinProperties;
    public UnityEngine.GameObject battleRoyaleProperties;
    public UnityEngine.GameObject emptyWeaponProperties;
    public UnityEngine.GameObject armorProperties;
    public UnityEngine.GameObject miscProperties;
    public UILabel fireRate;
    public UILabel fireRateMElee;
    public UILabel mobility;
    public UILabel mobilityMelee;
    public UILabel capacity;
    public UILabel damage;
    public UILabel efficiencyDamage;
    public UILabel damageMelee;
    public UILabel damageInHead;
    public UILabel weaponsRarityLabel;
    public UILabel descriptionGadget;
    public System.Collections.Generic.List<UILabel> weaponEfficiency;
    public System.Collections.Generic.List<UnityEngine.GameObject> weaponEfficiencyArrowUp;
    public System.Collections.Generic.List<UnityEngine.GameObject> weaponEfficiencyArrowDown;
    public System.Collections.Generic.List<UIWidget> weaponEfficiencyColorRessivers;
    public UnityEngine.GameObject gadgetEfficiencyContainer;
    public System.Collections.Generic.List<UILabel> gadgetEfficiency;
    public UnityEngine.GameObject armorEfficiencyContainer;
    public System.Collections.Generic.List<UILabel> armorEfficiency;
    public UnityEngine.GameObject miniArmorInfoRarityContainer;
    public System.Collections.Generic.List<UILabel> miniArmorInfoRarity;
    public UnityEngine.GameObject miniMiscInfoRarityContainer;
    public System.Collections.Generic.List<UILabel> miniMiscInfoRarity;
    public UnityEngine.GameObject miniGadgetInfoRarityContainer;
    public System.Collections.Generic.List<UILabel> miniGadgetInfoRarity;
    public System.Collections.Generic.List<UILabel> miniWeaponInfoRarity;
    public System.Collections.Generic.List<UILabel> energy;
    public System.Collections.Generic.List<UILabel> energyCount;
    public UILabel[] efficiencyDamageFormatted;
    public UIButton upgradeButton;
    public UIButton speedUpButton;
    public UIButton trainButton;
    public UIButton buyButton;
    public UIButton equipButton;
    public UIButton unequipButton;
    public UIButton infoButton;
    public UIButton editButton;
    public UIButton deleteButton;
    public UIButton enableButton;
    public UIButton createButton;
    public UIButton tryGun;
    public UIButton watchAdvertisement;
    public UnityEngine.GameObject equipDisabledButton;
    public UIButton toWeapon;
    public UnityEngine.GameObject weaponWillBeAvailableSoon;
    public UIButton buyWeaponSkin;
    public UIButton getWeaponSkin;
    public UnityEngine.GameObject weaponSkinWillBeAvailableSoon;
    public System.Collections.Generic.List<UILabel> upgradeButtonLabels;
    public System.Collections.Generic.List<UILabel> upgradeButtonLabelsCenter;
    public SetHeadLabelText speedUpToLevelLabel;
    public UILabel upgradeToLevelLabel;
    public UnityEngine.Transform upgradeLabel;
    public UnityEngine.GameObject equipped;
    public UnityEngine.GameObject needTier;
    public UILabel needTierLabel;
    public System.Collections.Generic.List<UILabel> needTierLabelAdditional;
    public UnityEngine.GameObject needTierWeapon;
    public UILabel needTierWeaponLabel;
    public UnityEngine.GameObject needBuyPrevious;
    public UILabel needBuyPreviousLabel;
    public System.Collections.Generic.List<UISprite> effectsSprites;
    public System.Collections.Generic.List<UILabel> effectsLabels;
    public System.Collections.Generic.List<UILabel> armorEffectDescriptionLabel;
    public System.Collections.Generic.List<UILabel> miscDescriptionLabel;
    public UILabel maxLevelLabel;
    public System.Collections.Generic.List<GadgetPropertyItem> gadgetsPropertiesList;
    public System.Collections.Generic.List<GadgetPropertyItem> armorPropertiesList;
    public UILabel nonArmorWearDEscription;
    public UILabel armorWearDescription;
    public UILabel armorCountLabel;
    public UILabel gadgetNameLabel;
    public UILabel armorName;
    public UnityEngine.GameObject tryGunPanel;
    public UILabel tryGunMatchesCount;
    public UILabel tryGunDiscountTime;
    public PriceContainer price;
    public PriceLabel priceUp;
    public System.Collections.Generic.List<UILabel> weaponCurrentLevel;
    public UnityEngine.GameObject damageUpForSettingsLabel;
    public UnityEngine.GameObject damageUpForSettingsBackground;
    public UnityEngine.GameObject superUpDiscount;
    public UnityEngine.GameObject discountPanel;
    public UILabel discountLabel;
    public float MaxDPS;
    public float MinDPS;
    public float MaxDPSPrevTier;
    public float MinDPSPrevTier;
    public float CurDPS;
    public float NextDPS;
    public float SettingsDPS;
    internal ItemRarity 丈下丑丆上丏丗丈专;
    public bool isItemCurrentTier;
    public PriceContainer armoryPrice;
    public UILabel descriptionText;
    public UnityEngine.GameObject addDPSContainer;
    public UILabel addDpsLabel;
    public UnityEngine.GameObject combatLevelGO;
    public UILabel[] combatLevelLabel;
    public UISprite rightButtonBlockSprite;
    public UnityEngine.GameObject offlineIndicator;
    public UILabel upgradeButtonBlockedLable;
    public bool isSimplySkinMode;
    public UnityEngine.GameObject skinNameContainer;
    public UILabel skinNameText;
    public UnityEngine.GameObject skinDescriptionContainer;
    
    // Properties
    internal System.Collections.Generic.List<PGCompany.FreeUpCategoryGuiNotification> 丙一丄丝且丂丆专下 { get; }
    internal PropertiesPopupController 丒一丏东丁丑下且丈 { get; }
    internal UIButton 丘丒丕丒丂丅丌丂三 { get; }
    internal UIButton 丟丗丘不丞专丛丒世 { get; }
    internal UIButton 丑丒丟丝丛丟丆上丝 { get; }
    
    // Methods
    internal System.Collections.Generic.List<PGCompany.FreeUpCategoryGuiNotification> 东丐丘专上丅世丙丁()
    {
        return (System.Collections.Generic.List<PGCompany.FreeUpCategoryGuiNotification>)this.freeUpUpgradeButtonIndicators;
    }
    internal PropertiesPopupController 丛且丒万丞丝丞丝丕()
    {
        return (PropertiesPopupController)this.propertiesPopupController;
    }
    internal UIButton 业丝丆丙丂东丁东业()
    {
        return (UIButton)this.propertiesPopupButton;
    }
    internal UIButton 七东丅丅且东东丑丌()
    {
        return (UIButton)this.propertiesPopupMeleeButton;
    }
    internal UIButton 丆专丗专七万丟丌丏()
    {
        return (UIButton)this.propertiesPopupCraftButton;
    }
    public void ToggleRightInfo(bool 丛与丙丒丒下丌丟且)
    {
        if(this.shopRightContainer != 0)
        {
                this.shopRightContainer.SetActive(value:  丛与丙丒丒下丌丟且);
        }
        
        if(this.shopProperties == 0)
        {
                return;
        }
        
        this.shopProperties.SetActive(value:  丛与丙丒丒下丌丟且);
    }
    public PropertiesArmoryItemContainer()
    {
    
    }

}
