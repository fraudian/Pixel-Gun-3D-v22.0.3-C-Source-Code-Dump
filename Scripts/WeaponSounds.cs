using UnityEngine;
public sealed class WeaponSounds : PGBehaviour
{
    // Fields
    internal const string 业丂丟且与丅不丈丈 = "RememberedTierWhenObtainGun_";
    internal static readonly System.Collections.Generic.Dictionary<WeaponSounds.丈不三丛七丑丈丑丆, System.ValueTuple<string, string, string>> 丟三与丒东丙丞业丗;
    internal static readonly System.Collections.Generic.Dictionary<PGCompany.丕万丁不丁丑东丌七, System.Collections.Generic.KeyValuePair<string, string>> 丑丝三丙业丑世丝丟;
    internal static readonly string 丄丘一专与丄下且丞;
    internal static readonly string 七丘丌丅三丕与下丆;
    internal static readonly string 丁与且丅丕丏业且不;
    internal static readonly string 且不丄丄丐丁万三与;
    internal static readonly string 丆丛且丞东丌丏丑丄;
    internal static readonly string 丑丅与丒丝且万丞丙;
    internal static readonly string 三丕一东丕东丁丘丁;
    internal static readonly string 且万丗丂下丁万万丙;
    public int categoryNabor;
    public int[] filterMap;
    public WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    public int ammoInClip;
    public int InitialAmmo;
    public int maxAmmo;
    public int ammoForBonusShotMelee;
    public int ammoFromBonus;
    public string localizeWeaponKey;
    public string alternativeName;
    public UnityEngine.Vector2 startZone;
    public float maxKoof;
    public float tekKoof;
    public float upKoofFire;
    public float downKoofFirst;
    public float downKoof;
    internal float 三且丞万与世丏与一;
    private float timerForTekKoofVisual;
    private float timerForTekKoofVisualByFireRate;
    private const float 丛三丁万丟七七丈丆 = 5;
    private const float 三丘丒万丛丞与一不 = 10;
    public float timeForTekKoofVisual;
    private bool firstShotScatter;
    internal float 丌丑下丆东与东业丆;
    private float moveScatterCoeff;
    private bool instantHorizontalMoveScatterCoeff;
    private bool instantVerticalMoveScatterCoeff;
    private bool scatterInversion;
    private float recoilCoeff;
    private bool enableRocketScatter;
    public bool isZooming;
    public bool zoomXray;
    internal Player_move_c.下丏与丈丟丝七万一 xRayType;
    public UnityEngine.GameObject iRayEffect;
    private float fieldOfViewZomm;
    public bool considerScopeValues;
    public float scopeCircleRadius;
    public float scopePointsSpeed;
    public float scopeMovementSpeed;
    public float scopeTrashHoldForDistanceToPoint;
    public float scopeStartValueSpeedIncreace;
    public float scopeIncreaceStep;
    public UnityEngine.Vector2 startZoneZoom;
    public float maxKoofZoom;
    public float upKoofFireZoom;
    public float downKoofFirstZoom;
    public float downKoofZoom;
    internal float 丏丄一业丆一丆丐丝;
    private bool firstShotScatterZoom;
    private float moveScatterCoeffZoom;
    private bool instantHorizontalMoveScatterCoeffZoom;
    private bool instantVerticalMoveScatterCoeffZoom;
    private bool scatterInversionZoom;
    private float recoilCoeffZoom;
    public bool ignoreBarrier;
    public bool ignoreSlyWolf;
    public bool ignoreReflector;
    public bool bazooka;
    public bool raycastOnRocketFire;
    private bool isMomentumProjectile;
    public float bazookaDelay;
    public int rocketNum;
    public float stepTimeInSeriaBazooka;
    public string bazookaExplosionName;
    public float bazookaExplosionRadius;
    public float bazookaExplosionRadiusSelf;
    public float bazookaImpulseRadius;
    public bool bazookaUseGunFlashDirection;
    public bool isLightning;
    public bool isGhost;
    public bool grenadeLauncher;
    public int countInSeriaBazooka;
    public bool useAmmoForEachRocketInSeriaBazooka;
    public float impulseForce;
    public float impulseForceSelf;
    public bool isDifferentffectsInSeria;
    public bool fanRocketShoot;
    public float fangAngle;
    public int[] bazookaRandomRockets;
    public bool bazookaUltimateShoot;
    public bool isMelee;
    public bool isMeleeSlasher;
    public float radiusRoundMelee;
    public float meleeAngle;
    public float meleeAttackTimeModifier;
    public bool gradualExplosions;
    public bool isRoundMelee;
    public bool useAngleForRoundMelee;
    public int meleePunchesCount;
    public int countShots;
    public WeaponSounds.丏丑丄上丆丅与丘丒 typeTracer;
    public bool bulletBreakout;
    public bool bulletExplode;
    public bool isShotGun;
    public bool bulletSuperBreakout;
    public float bulletDelay;
    public float shootDelay;
    public bool freezer;
    public int countReflectionRay;
    public bool railgun;
    public string railName;
    public bool railgunStopAtWall;
    public bool useSpawnPointRotationOnFreezer;
    public bool isCharging;
    public bool useOneAmmoOnCHarge;
    public bool isChargeOrbital;
    public UnityEngine.GameObject chargeEffect;
    public bool chargeLoop;
    public bool crossfadeChargeAnim;
    public float crossfadeSpeed;
    public int chargeMax;
    public float chargeTime;
    public bool invisWhenCharged;
    public bool isDamageHeal;
    public float damageHealMultiplier;
    public bool isGadgetDisabler;
    public float gadgetDisableTime;
    public bool isPoisoning;
    private int poisonCount;
    public float poisonDamageMultiplier;
    private float poisonTime;
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    internal bool isIgnoreIgnoreDamage;
    public bool healer;
    public bool jumpDisabler;
    public float jumpDisableTime;
    public bool isCursing;
    public float curseTime;
    public float curseDamageMultiplier;
    public bool isSlowdown;
    public float slowdownCoeff;
    public float slowdownTime;
    public bool isSlowdownStack;
    public int maxStack;
    public bool fireImmunity;
    public bool enemyMarker;
    public bool enemyMarkerWhenAiming;
    public bool enemyMarkerWhenShot;
    public float enemyMarketChargeTime;
    public float enemyMarkerAngle;
    public float enemyMarkerTriangleCathetLength;
    public bool isHeadMagnifier;
    public float headMagnifierTime;
    public bool isBlindEffect;
    internal Player_move_c.丏丙丘丒上丝丒丁且 blindEffect;
    public float isBlindEffectTime;
    public bool isCharm;
    public float charmTime;
    public bool isWeaknessEffect;
    public float weaknessEffectTime;
    public bool teammateDamageBoostBuff;
    public float teammateDamageBoostRadius;
    public float teammateDamageBoostMultiplier;
    public float teammateDamageBoostZoneTime;
    public float teammateDamageBoostBuffTime;
    public bool isDash;
    public float dashMaxImpulse;
    public float dashDecaySpeed;
    public float dashDeltaImpact;
    public bool harpoon;
    public UnityEngine.Transform harpoonStartPoint;
    public float harpoonImpulse;
    public float harpoonDeltaUp;
    public float harpooneMaxImpulse;
    public float harpooneMinImpulse;
    public float harpoonDecaySpeed;
    public float harpoonMaxDelta;
    public float harpoonMaxDistance;
    public float harpoonDeltaImpact;
    public float harpoonMinDistance;
    public bool polymorpher;
    public float polymorphDuarationTime;
    public WeaponSounds.丘丅东一下丁丌丛丈 polymorphType;
    public float polymorphMaxHealth;
    public bool snowStorm;
    public float snowStormBonusMultiplier;
    public float snowStormBonusRange;
    public string armoryPreviewName;
    public bool useTextureSkinForArmoryPreview;
    public bool isDamageReflection;
    public bool isDamageAbsorption;
    public float damageReflectionValue;
    public bool isKilledTargetExplode;
    public float killedTargetExplosionRadiusDamage;
    public float killedTargetExplosionRadiusDamageSelf;
    public float killedTargetExplosionDamageMultiplier;
    public string explosionNameForKilledTarget;
    public bool isCoinDrop;
    public float coinDropChance;
    public bool ammoRestoreShootTemplate;
    public float ammoRestorePercent;
    public bool isAmmoRestore;
    public int ammoRestoreNumber;
    public float ammoRestoreTime;
    public bool flamethrower;
    public bool isSimpleFlamethrower;
    internal float 丞丄万世丏三与丐丅;
    public bool dotFlamethrower;
    public float dotTimeFlamethrower;
    public bool dotFlameTimeIsDependedOnChargeTime;
    public bool dotFlameDamageIsDependedOnChargeTime;
    public bool isFrostSword;
    public float frostDamageMultiplier;
    public float frostRadius;
    public bool isFrostSwordUseAngle;
    public float frostSwordAngle;
    public bool isInvisibleReload;
    public bool isInvisibleAfterKill;
    public float invisibleAfterKillTime;
    public bool firstKillCritical;
    public bool isBuffPoints;
    public float buffPointsRevenge;
    public bool buffPointsRevengeDesigner;
    public float buffBonusPointsForKill;
    public bool buffPointsKillDesigner;
    public float buffBonusPointsForAssist;
    public bool buffPointsAssistDesigner;
    public float buffPointsOther;
    public float shotgunMaxDamageDistance;
    public float shotgunMinDamageCoef;
    public float shotgunOverDamageDistance;
    public float shotgunOverDamageCoef;
    public bool isSectorsAOE;
    public float sectorsAOEAngleFront;
    public float sectorsAOEAngleBack;
    public float sectorsAOEDamageMultiplierFront;
    public float sectorsAOEDamageMultiplierSide;
    public float sectorsAOEDamageMultiplierBack;
    public float sectorsAOERadiusSectorsAoE;
    public bool portalGun;
    public bool isPortalExplosion;
    public UnityEngine.Gradient portalGunGradient;
    internal PortalChainManager.业一丐专丞东世丞七 portalType;
    public bool isArmorRegeneration;
    public float armorRegenerationPercent;
    public float armorRegenerationTime;
    public bool isAmmoSteal;
    public float ammoStealPercent;
    public bool loseFlagWhenShoot;
    public bool isUnlimitedAmmo;
    public bool isShotMelee;
    public bool isMeleeShotAndReloaded;
    public bool isSpleef;
    public bool seriesShoot;
    public bool isBurstShooting;
    public bool isDamageFromDamageCollider;
    public bool isDaterWeapon;
    public bool isDoubleShot;
    public bool isDoubleSyncShot;
    public bool isCameraInCenter;
    public bool isExoskelet;
    public bool isGrenadeWeapon;
    public bool isLoopShoot;
    public bool isDoubleJump;
    public bool isMechWeapon;
    public int criticalHitChance;
    public float criticalHitCoef;
    public bool shocker;
    public float shockerDamageMultiplier;
    public float shockerRange;
    public bool isDoubleShoot2Rockets;
    public bool isAnimReloadAfterShoot;
    public bool useOnGroundEffectWithoutParent;
    public bool weaponIsNotFromConfig;
    public float lengthShootFromPrefab;
    public UnityEngine.Vector3 bonusLocalPosition;
    public UnityEngine.Vector3 bonusLocalScale;
    public System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> InShopEffects;
    public bool IsActiveAim;
    private float 丅三丌不业丟丗丒万;
    private BearInnerWeaponPars 一丌丙世丈三丐丙丒;
    private float 专丆下丈丌一丝上一;
    private float 丌丒不上不专且上丕;
    private float 不上业丞丕业丏丁丅;
    private InnerWeaponPars _innerWeaponPars;
    private UnityEngine.SkinnedMeshRenderer[] 丄丗东丆丞三丛三世;
    private Player_move_c 上丑丆上丌东不世丏;
    private FirstPersonControlSharp 丁丏丝丙七丁丕丘丒;
    private MinigunController <丝丟丞丟丏丏丟不丙>k__BackingField;
    private bool isWeaponInsideHands;
    internal bool useLowAvatarArms;
    private WeaponReloadEffect _reloadEffect;
    private WeaponSecondTimeFireAction _secondTimeFireAction;
    private WeaponChargeShield _chargeShield;
    private WeaponSkinChanger skinChanger;
    internal WeaponUltimateAbility weaponUltimate;
    private bool <与丁丑丂丛丒与丁丞>k__BackingField;
    public string ShopId;
    public UnityEngine.Vector3 positionShop;
    public UnityEngine.Vector3 rotationShop;
    public float scaleShop;
    private UnityEngine.AnimationState 丈不丒丄世丟一不丛;
    public int armorPercent;
    internal System.Collections.Generic.Dictionary<int, float> 三世丗丆丕万丐且三;
    internal float 丙且丕丝三丞下丞丌;
    internal bool healingArea;
    internal bool healingHimSelf;
    internal float radiusHealing;
    private System.Nullable<float> 三丌丗丐丐丑专一与;
    private bool 三丒丘丂一丈丂丙不;
    private UnityEngine.GameObject 丆七丁世且丗不上世;
    public bool Blik;
    public bool campaignOnly;
    public bool CanBuy;
    public int countShootInBurst;
    public float delayInBurstShooting;
    internal float 丅丟万丕东专丘丆三;
    public float[] damageByTier;
    public UnityEngine.Vector2 damageRange;
    public DamageWeaponCollider damageWeaponCollider;
    public string daterMessage;
    public float[] dpses;
    public float ragdollImpulse;
    public bool DPSRememberWhenGet;
    public int fireRateShop;
    public float grenadeThrowTime;
    public float grenadeUseTime;
    public System.Collections.Generic.List<BulletSpawnPoint> bulletSpawnPoints;
    public UnityEngine.Vector3 gunPosition;
    public int inAppExtensionModifier;
    public bool IsRoyaleWeapon;
    public float loudnessScale;
    public UnityEngine.GameObject MechAnimationObject;
    public UnityEngine.GameObject[] noFillObjects;
    public int Probability;
    public float protectionEffectValue;
    public float range;
    public ItemRarity rarity;
    public int scopeNum;
    public float shootDistance;
    public WeaponSounds.丘一丄丕上丘一且丂 specialEffect;
    public float speedModifier;
    public string StorageId;
    public string Tag;
    public int tier;
    private float 丆丑丅丂丏一丞上上;
    private float 丘世丒丅丂丙丙丒丞;
    public bool UseImagesFromFirstUpgrade;
    internal string 丝三丛且丘不丌丙下;
    public int zoomShop;
    public bool useLegacyIdleAnimation;
    public bool useLegacyWalkAnimation;
    public bool disableDirectionAnimation;
    private bool 专与丛丟世丐丒丄东;
    private bool is3CatSpam;
    private 三丅丁丗丗丝丂万且 丅丗世丝丌与与丕下;
    private bool 丟丌丏丌丒丙三不丟;
    private int 万丙丟三丏丘专专丏;
    private int 下专丘与丟三且丕下;
    private System.Nullable<ItemRarity> 下与丗丟且业丆丂东;
    private float 上业东业七丙丗丒业;
    private float 下万丏下七万丕下不;
    private float 七万丏丛且丆丁世丁;
    private UnityEngine.Animation 丘丟丕丏下丌专业下;
    private WeaponAnimParticleEffects <丄丗丌丆专业专丙丞>k__BackingField;
    private UnityEngine.Transform 丏丄丌丁丝丗丄丗万;
    private string 上丐三三丁丈专丘丌;
    private float 丐不丈丏丞丒丘丁丁;
    private bool 丄丄不七丙上业业上;
    
    // Properties
    internal bool 七七七丈丂三丄丂丁 { get; }
    public float 三丛丛业丌丞世万丝 { get; }
    internal bool 丌丆丅东世丄丂丕丆 { get; }
    internal float 丆丅七一丕世且丅丈 { get; }
    public int 东一上丟丆丞丛七丐 { get; }
    public float 丆丑丛丞丛丟下不丑 { get; }
    public float 丂丐丏丙不七丛下丞 { get; }
    public bool 丞丆丁三丕丌丝下丅 { get; }
    public float 丄丁上丘丁丏丛专三 { get; }
    public float 下七三丂丁丂三丏不 { get; }
    internal float 丕丄丛丟丗丏丒丄丏 { get; }
    internal MinigunController 丈丐且一丝丆丐丐丟 { get; set; }
    public bool 与一丆丌丅与丒丄丆 { get; }
    internal WeaponReloadEffect 丄丕丏下世丗上业且 { get; }
    internal WeaponSecondTimeFireAction 一丆丙丂丌丙丄丞丈 { get; }
    internal WeaponChargeShield 专三七丐丙与上丂丕 { get; }
    internal bool 上一丆丛丐三业下业 { get; set; }
    internal int 业丒丆丟与丌与万业 { get; }
    internal bool 丝丈与世丕一丒七上 { get; }
    internal float 业三丝丐丟丌一丅业 { get; }
    public float 丝世三丟丁东丄丒丝 { get; }
    internal bool 丗丑丈丐丛丟东不一 { get; }
    internal float 七一专丟丅丞万丌下 { get; }
    internal 三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且 { get; }
    public int 上丂下丅丂丗上丈丌 { get; }
    internal float 不万一丅世且丗一三 { get; }
    internal float 一丙丑丆丛下与丌一 { get; }
    internal float 丁丟丈丌丌丗三三丟 { get; }
    internal float 丈不丛丙丘万丗三与 { get; }
    public float 东丞下丏三世丘丒丑 { get; }
    internal float 丕与丄一丌与丈丙丘 { get; }
    internal float 丆世世下丘与丑丞丙 { get; }
    internal UnityEngine.GameObject 丞世丁丑丞丝丒丛丑 { get; }
    private UnityEngine.SkinnedMeshRenderer[] 与且三世丏丞下丙丗 { get; }
    internal UnityEngine.GameObject 业专丗丅不丗东一丁 { get; }
    internal UnityEngine.Animation 丂一丒丅丂丅专丙万 { get; }
    internal UnityEngine.Texture 丑与丅东万丟世丄丌 { get; }
    internal UnityEngine.AudioClip 丐丐七丐下丞丌世与 { get; }
    internal UnityEngine.AudioClip 丞丝专丟丏与三丑丌 { get; }
    internal UnityEngine.AudioClip 三丘东丟丝丈丈丛丏 { get; }
    internal UnityEngine.AudioClip 丄丟丌且七丕丅丗下 { get; }
    internal UnityEngine.AudioClip 丈丝丈丐业丅丆东丄 { get; }
    internal UnityEngine.AudioClip 丑下丞三丗丑丈丆世 { get; }
    internal UnityEngine.AudioClip 世不丌丗丏东下丝丅 { get; }
    internal UnityEngine.AudioClip 万一与下丄七丙丟专 { get; }
    internal UnityEngine.AudioClip 丐丞三丛丒丏丝丄丞 { get; }
    internal UnityEngine.AudioClip 丝丘三三丗丙丑且三 { get; }
    internal UnityEngine.AudioClip 丒丈丄与丗且一丟丌 { get; }
    internal UnityEngine.GameObject 丌七一且丐三丄丈丆 { get; }
    internal UnityEngine.GameObject 丈且三丞万与一丁上 { get; }
    internal UnityEngine.Transform 丄丞下且业与上专丈 { get; }
    internal UnityEngine.Transform 七丏丕一与丕业世丗 { get; }
    internal UnityEngine.Transform 丟三丆丝丐世丅下丅 { get; }
    internal UnityEngine.Transform[] 七万丞万一丙丘丅七 { get; }
    public InnerWeaponPars 丑专丕一上丅丁世三 { get; }
    internal WeaponAnimParticleEffects 上丏丒丄且七丅丘丗 { get; set; }
    internal float 一业三丟一丛丗丑丐 { get; }
    internal bool 丂上丂丟丁丏丅丂丂 { get; }
    internal bool 一下丌丁不丂丒丆丗 { get; }
    internal bool 丏丑丌丒世丙丝丈下 { get; }
    internal UnityEngine.Vector2 丈且丝七专不丆丝丐 { get; }
    private float 丞下丅上丙丏丅不七 { get; }
    private float 与上且且丕丐丛七七 { get; }
    private FirstPersonControlSharp 丈世丈丏东一丞下三 { get; }
    private float 丏不丝丝世丂丌丈不 { get; }
    private float 丐七丛丌丄丁丞丟丌 { get; }
    private float 上丒丁七专专丛世一 { get; }
    private float 丛业不丒与丁丌专世 { get; }
    private float 丁一专丙丒丄东丏下 { get; }
    private float 丟东丈七上丄丞世丂 { get; }
    internal Player_move_c 世丗丑一丝且丐丏丆 { get; }
    internal string 万不三丗丕上丌与专 { get; }
    private bool 下丁丘丁且丞丂且丞 { get; }
    private float 丄丞专丂丑世下三丟 { get; }
    internal bool 东丆下丂丟与与世丏 { get; }
    
    // Methods
    internal bool 且且丈丗丗丏丛专丑()
    {
        return (bool)this.enableRocketScatter;
    }
    public float get_ZoomFOV()
    {
        float val_5;
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  20)) != false)
        {
                val_5 = this.三世丗丆丕万丐且三.Item[20];
        }
        else
        {
                val_5 = 1f;
        }
        
        float val_4 = Player_move_c.且丒丗丑万丐丗丅三();
        val_4 = val_4 - this.fieldOfViewZomm;
        val_4 = val_5 * val_4;
        val_4 = Player_move_c.且丒丗丑万丐丗丅三() - val_4;
        return (float)val_4;
    }
    internal bool 三专丏丘丟丞与与下()
    {
        return (bool)this.isMomentumProjectile;
    }
    internal float 一丕丌业与业七丗丒()
    {
        return (float)this.poisonTime;
    }
    public int get_PoisonCount()
    {
        var val_3;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_4;
        float val_5;
        var val_6;
        float val_7;
        val_4 = this;
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  18)) != false)
        {
                val_4 = this.三世丗丆丕万丐且三;
            val_5 = val_4.Item[18];
        }
        else
        {
                val_5 = 1f;
        }
        
        val_5 = val_5 * (float)this.poisonCount;
        if(val_5 >= 0f)
        {
            goto label_7;
        }
        
        if((double)val_5 != (-0.5))
        {
            goto label_8;
        }
        
        val_6 = val_3;
        val_7 = -1f;
        goto label_9;
        label_7:
        if((double)val_5 != 0.5)
        {
            goto label_10;
        }
        
        val_6 = val_3;
        val_7 = 1f;
        label_9:
        float val_4 = (float)val_6;
        val_7 = val_4 + val_7;
        val_4 = (((long)val_6 & 1) != 0) ? (val_4) : (val_7);
        return (int)(int)val_6;
        label_8:
        float val_5 = -0.5f;
        val_5 = val_5 + val_5;
        return (int)(int)val_6;
        label_10:
        float val_6 = 0.5f;
        val_6 = val_5 + val_6;
        return (int)(int)val_6;
    }
    internal bool 丕丗丒不一且丛业丟()
    {
        return (bool)this.isSimpleFlamethrower;
    }
    public float get_AutoAimDistance()
    {
        if(this.isMelee != true)
        {
                if(this.flamethrower == false)
        {
            goto label_2;
        }
        
        }
        
        float val_4 = this.range;
        val_4 = val_4 + 2f;
        return (float)val_4;
        label_2:
        if(((GameConnect.万不丒丌丙万丗东不() != false) && (this.categoryNabor == 5)) && (this.isZooming != false))
        {
                PlayerCoreSettingsStorager val_2 = PlayerCoreSettingsStorager.Instance;
            if(val_2 != null)
        {
                return val_2.AutoAimBRSnipeZoomDistanceGetter;
        }
        
            return val_2.AutoAimBRSnipeZoomDistanceGetter;
        }
        
        PlayerCoreSettingsStorager val_3 = PlayerCoreSettingsStorager.Instance;
        if(val_3 != null)
        {
                return val_3.AutoAimDistanceGetter;
        }
        
        return val_3.AutoAimDistanceGetter;
    }
    public float get_MinDistanceAutoAim()
    {
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                PlayerCoreSettingsStorager val_2 = PlayerCoreSettingsStorager.Instance;
            if(val_2 != null)
        {
                return val_2.BRMinDistanceAutoAimGetter;
        }
        
            return val_2.BRMinDistanceAutoAimGetter;
        }
        
        PlayerCoreSettingsStorager val_3 = PlayerCoreSettingsStorager.Instance;
        if(val_3 != null)
        {
                return val_3.MinDistanceAutoAimGetter;
        }
        
        return val_3.MinDistanceAutoAimGetter;
    }
    public bool get_IsDistanceBlockOn()
    {
        PlayerCoreSettingsStorager val_1 = PlayerCoreSettingsStorager.Instance;
        if(val_1 != null)
        {
                return val_1.IsDistanceBlockOnGetter;
        }
        
        return val_1.IsDistanceBlockOnGetter;
    }
    public float get_EffectiveDistance()
    {
        一三专丈世丑丆丑丐 val_1 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_1 != null)
        {
                return val_1.丈东丝丄丕丗世三上();
        }
        
        return val_1.丈东丝丄丕丗世三上();
    }
    public float get_RadiusAutoAim()
    {
        PlayerCoreSettingsStorager val_1 = PlayerCoreSettingsStorager.Instance;
        if(val_1 != null)
        {
                return val_1.RadiusAutoAimGetter;
        }
        
        return val_1.RadiusAutoAimGetter;
    }
    internal float 丙丂专丂丗丒丈丝不()
    {
        float val_11;
        float val_12;
        this.丅三丌不业丟丗丒万 = -1f;
        if((UnityEngine.Mathf.Approximately(a:  -1f, b:  -1f)) == false)
        {
            goto label_3;
        }
        
        PlayerCoreSettingsStorager val_2 = PlayerCoreSettingsStorager.Instance;
        if(this.isCharging == false)
        {
            goto label_7;
        }
        
        val_11 = this.丛丆丑丁下丆丘丏丝() / this.chargeTime;
        goto label_8;
        label_3:
        val_12 = this.丅三丌不业丟丗丒万;
        goto label_9;
        label_7:
        val_11 = this.且丈丗丗丞且丑丐专();
        label_8:
        val_12 = UnityEngine.Mathf.Clamp(value:  val_2.AUTOSHOOT_DEPENDENCE_MULTI * val_11, min:  0f, max:  PlayerCoreSettingsStorager.dynamicSettings.且七上丄丑万丁丛上());
        this.丅三丌不业丟丗丒万 = val_12;
        label_9:
        一三专丈世丑丆丑丐 val_9 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_10 = val_9.丞七丟丛丐丂丗丟丛;
        val_10 = val_12 * val_10;
        return (float)val_10;
    }
    internal MinigunController 一与上丙一丙丅丐业()
    {
        return (MinigunController)this.<丝丟丞丟丏丏丟不丙>k__BackingField;
    }
    private void 丆上不世丕丑丄丞丙(MinigunController 丙业与丙丗丝不丈东)
    {
        this.<丝丟丞丟丏丏丟不丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_IsWeaponInsideHands()
    {
        return (bool)this.isWeaponInsideHands;
    }
    internal WeaponReloadEffect 丒丒丁丕东丆丙丕上()
    {
        return (WeaponReloadEffect)this._reloadEffect;
    }
    internal WeaponSecondTimeFireAction 东上专丘丏丕丝丑丆()
    {
        return (WeaponSecondTimeFireAction)this._secondTimeFireAction;
    }
    internal WeaponChargeShield 丄丞丑丙丟丟一丏东()
    {
        return (WeaponChargeShield)this._chargeShield;
    }
    internal bool 丕丆万丝上丕下丙业()
    {
        return (bool)this.<与丁丑丂丛丒与丁丞>k__BackingField;
    }
    private void 专万一业七七且业专(bool 丙业与丙丗丝不丈东)
    {
        this.<与丁丑丂丛丒与丁丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 上丈一万东三东世东(PGCompany.丟丝世万东万丆丟上 三丕上下丗丘丌专丒)
    {
        string val_22;
        WeaponSkinChanger val_23;
        UnityEngine.Renderer val_24;
        UnityEngine.Object val_25;
        if(三丕上下丗丘丌专丒 != null)
        {
                val_22 = 三丕上下丗丘丌专丒.上专丗丏丛丁专丑丄().WeaponPrefabName;
            if((System.String.op_Inequality(a:  val_22, b:  this.三与丛丑且丐丈业丌())) == true)
        {
                return;
        }
        
            val_23 = this.skinChanger;
        }
        else
        {
                val_22 = this.skinChanger;
            val_23 = this.skinChanger;
            if(val_22 == 0)
        {
                return;
        }
        
        }
        
        if(mem[this.skinChanger] == 0)
        {
                WeaponSkinChanger val_8 = this.gameObject.GetComponent<WeaponSkinChanger>();
            mem2[0] = val_8;
            if(val_8 == 0)
        {
                mem2[0] = this.gameObject.AddComponent<WeaponSkinChanger>();
            val_24 = 0;
            if(this.业丑丂业东丁一丝丁() != 0)
        {
                val_24 = this.业丑丂业东丁一丝丁().GetComponent<UnityEngine.Renderer>();
        }
        
            val_11.weaponMeshRenderer = val_24;
        }
        
        }
        
        val_25 = mem[this.skinChanger];
        if(val_25 != 0)
        {
                val_25 = mem[mem[this.skinChanger] + 24];
            val_25 = mem[this.skinChanger] + 24;
            if(val_25 == 0)
        {
                val_25 = 0;
            if(this.业丑丂业东丁一丝丁() != 0)
        {
                val_25 = this.业丑丂业东丁一丝丁().GetComponent<UnityEngine.Renderer>();
        }
        
            this.skinChanger.weaponMeshRenderer = val_25;
        }
        
        }
        
        mem[this.skinChanger].上丈一万东三东世东(三丕上下丗丘丌专丒:  三丕上下丗丘丌专丒, 丄丕且丆与业下业下:  0);
    }
    internal int 丏世上东一丌丙世七()
    {
        if(this.skinChanger == 0)
        {
                return 0;
        }
        
        if((this.skinChanger.<丏丈且丑业丏丏丟丞>k__BackingField) == null)
        {
                return 0;
        }
        
        if((this.skinChanger.<丏丈且丑业丏丏丟丞>k__BackingField) != null)
        {
                return this.skinChanger.<丏丈且丑业丏丏丟丞>k__BackingField.业东丅东丌上丗丑不();
        }
        
        return this.skinChanger.<丏丈且丑业丏丏丟丞>k__BackingField.业东丅东丌上丗丑不();
    }
    internal bool 且丒丞丐丗丐七丝业()
    {
        if((this.<丝丟丞丟丏丏丟不丙>k__BackingField) == 0)
        {
                return true;
        }
        
        if((this.<丝丟丞丟丏丏丟不丙>k__BackingField) != null)
        {
                return this.<丝丟丞丟丏丏丟不丙>k__BackingField.丐与七丄七丈丞丁业();
        }
        
        return this.<丝丟丞丟丏丏丟不丙>k__BackingField.丐与七丄七丈丞丁业();
    }
    internal float 丈专世世丙丅东且一()
    {
        string val_13;
        if(((UnityEngine.TrackedReference.op_Equality(x:  this.丈不丒丄世丟一不丛, y:  0)) != false) && (this.丐丗丑丑丏万上业下() != 0))
        {
                UnityEngine.Animation val_5 = this.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
            if(val_5 != 0)
        {
                if(this.isDoubleShot != false)
        {
                val_13 = "Shoot1";
        }
        else
        {
                val_13 = "Shoot";
        }
        
            if((UnityEngine.TrackedReference.op_Inequality(x:  val_5.Item[val_13], y:  0)) != false)
        {
                this.丈不丒丄世丟一不丛 = val_5.Item["Shoot"];
        }
        
        }
        
        }
        
        if((UnityEngine.TrackedReference.op_Equality(x:  this.丈不丒丄世丟一不丛, y:  0)) == true)
        {
                return (float)val_12;
        }
        
        float val_12 = this.七丈与丑丏丁上丗且();
        val_12 = this.丈不丒丄世丟一不丛.length / val_12;
        return (float)val_12;
    }
    public float get_TeammateHealMultiplier()
    {
        if((this.三丌丗丐丐丑专一与 & 1) == 0)
        {
                System.Nullable<System.Single> val_3 = BalanceController.丙上丄万丗丂丕丏丆(东七丛丝丑专世丏三:  this.丌上丗丕不七世丅丁().业东丅东丌上丗丑不());
            mem2[0] = val_3.HasValue;
        }
        
        float val_4 = 0f;
        if((this.三丌丗丐丐丑专一与 & 1) == 0)
        {
                return (float)val_4;
        }
        
        val_4 = val_4 / 100f;
        return (float)val_4;
    }
    internal bool 七丆丗丘丈丞丁丞丞()
    {
        var val_5;
        if(this.is3CatSpam != false)
        {
                val_5 = 1;
            return (bool)(this.丌上丗丕不七世丅丁().丒万丕七专不丏丞丌() == 4) ? 1 : 0;
        }
        
        if(this.丌上丗丕不七世丅丁() == null)
        {
                return (bool)(this.丌上丗丕不七世丅丁().丒万丕七专不丏丞丌() == 4) ? 1 : 0;
        }
        
        return (bool)(this.丌上丗丕不七世丅丁().丒万丕七专不丏丞丌() == 4) ? 1 : 0;
    }
    internal float 丕丑丘丗丆丗丛丄东()
    {
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  15)) == false)
        {
                return 1f;
        }
        
        if(this.三世丗丆丕万丐且三 != null)
        {
                return this.三世丗丆丕万丐且三.Item[15];
        }
        
        return this.三世丗丆丕万丐且三.Item[15];
    }
    internal 三丅丁丗丗丝丂万且 丌上丗丕不七世丅丁()
    {
        三丅丁丗丗丝丂万且 val_3;
        if(this.丟丌丏丌丒丙三不丟 != false)
        {
                val_3 = this.丅丗世丝丌与与丕下;
            return val_2;
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.三与丛丑且丐丈业丌());
        this.丅丗世丝丌与与丕下 = val_2;
        this.丟丌丏丌丒丙三不丟 = true;
        return val_2;
    }
    public int get_AmmoInClip()
    {
        三丅丁丗丗丝丂万且 val_1 = this.丌上丗丕不七世丅丁();
        if(val_1 != null)
        {
                return val_1.与丑丕丗丟下丝上七();
        }
        
        return val_1.与丑丕丗丟下丝上七();
    }
    public void SetArmRarity()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if(GameController.onlineMode == null)
        {
            goto label_3;
        }
        
        val_4 = null;
        if(null == val_4)
        {
            goto label_4;
        }
        
        label_3:
        val_5 = null;
        goto label_5;
        label_4:
        val_5 = val_4;
        label_5:
        var val_1 = (val_4 == val_5) ? GameController.onlineMode : 0;
        七专丟丒七丆下丂丛 val_2 = val_4 == val_5 ? GameController.onlineMode : 0 + 536.CurrentWeapon;
        mem2[0] = val_2.rare;
    }
    internal float 丙下业七一一下世万()
    {
        float val_18;
        if(this.不上业丞丕业丏丁丅 >= 0)
        {
                return val_18;
        }
        
        if(this.丌上丗丕不七世丅丁() == null)
        {
            goto label_2;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_5;
        }
        
        this.SetArmRarity();
        float val_4 = this.丌上丗丕不七世丅丁().丄丑丕丕万丏丐下万(丈下丑丆上丏丗丈专:  new System.Nullable<ItemRarity>() {HasValue = this.下与丗丟且业丆丂东.HasValue});
        goto label_24;
        label_2:
        val_18 = 0f;
        goto label_8;
        label_5:
        if((GameConnect.丄丏丒丏上东业丒一() == false) || (this.下丏丆下丙与丘上丁() == 0))
        {
            goto label_17;
        }
        
        Player_move_c val_8 = this.下丏丆下丙与丘上丁();
        if(val_8.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
        {
            goto label_17;
        }
        
        float val_11 = this.丌上丗丕不七世丅丁().丌丟一丌七世世丏丂();
        goto label_24;
        label_17:
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_12 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        三丅丁丗丗丝丂万且 val_13 = this.丌上丗丕不七世丅丁();
        if(val_13 == null)
        {
            goto label_22;
        }
        
        if(val_12 == null)
        {
            goto label_23;
        }
        
        label_25:
        float val_14 = val_13.丄一专世丌世不专丛();
        goto label_24;
        label_22:
        if(val_12 != null)
        {
            goto label_25;
        }
        
        label_23:
        float val_15 = val_13.丙下业七一一下世万();
        label_24:
        this.不上业丞丕业丏丁丅 = val_15;
        val_18 = val_15 * this.丌上丗丕不七世丅丁().业丘丐丕丘业下丝下();
        label_8:
        this.不上业丞丕业丏丁丅 = val_18;
        return val_18;
    }
    internal float 丞与丁丝丅丄丒丒丁()
    {
        float val_15;
        if(this.不上业丞丕业丏丁丅 >= 0)
        {
                return val_15;
        }
        
        if(this.丌上丗丕不七世丅丁() == null)
        {
            goto label_2;
        }
        
        if((GameConnect.丄丏丒丏上东业丒一() == false) || (this.下丏丆下丙与丘上丁() == 0))
        {
            goto label_11;
        }
        
        Player_move_c val_5 = this.下丏丆下丙与丘上丁();
        if(val_5.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
        {
            goto label_11;
        }
        
        float val_8 = this.丌上丗丕不七世丅丁().丌丟一丌七世世丏丂();
        goto label_18;
        label_11:
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_9 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        三丅丁丗丗丝丂万且 val_10 = this.丌上丗丕不七世丅丁();
        if(val_10 == null)
        {
            goto label_16;
        }
        
        if(val_9 == null)
        {
            goto label_17;
        }
        
        label_20:
        float val_11 = val_10.丄一专世丌世不专丛();
        goto label_18;
        label_2:
        val_15 = 0f;
        goto label_19;
        label_16:
        if(val_9 != null)
        {
            goto label_20;
        }
        
        label_17:
        float val_12 = val_10.丞与丁丝丅丄丒丒丁();
        label_18:
        this.不上业丞丕业丏丁丅 = val_12;
        val_15 = val_12 * this.丌上丗丕不七世丅丁().业丘丐丕丘业下丝下();
        label_19:
        this.不上业丞丕业丏丁丅 = val_15;
        return val_15;
    }
    internal float 七丈与丑丏丁上丗且()
    {
        float val_5 = this.上业东业七丙丗丒业;
        if(val_5 >= 0)
        {
                return val_5;
        }
        
        if(this.丌上丗丕不七世丅丁() != null)
        {
                float val_4 = BalanceController.一丝丙丙不一丞丕丟(丟丈一下东业一丝丆:  this.丌上丗丕不七世丅丁().业东丅东丌上丗丑不());
        }
        else
        {
                val_5 = 1f;
        }
        
        this.上业东业七丙丗丒业 = val_5;
        return val_5;
    }
    internal float 且丈丗丗丞且丑丐专()
    {
        float val_32;
        UnityEngine.Object val_33;
        string val_34;
        float val_35;
        val_32 = this.丌丒不上不专且上丕;
        if(val_32 >= 0)
        {
            goto label_34;
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.三与丛丑且丐丈业丌());
        if(val_2 == null)
        {
            goto label_4;
        }
        
        val_33 = this.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
        bool val_6 = UnityEngine.Object.op_Inequality(x:  val_33.GetClip(name:  "Shoot"), y:  0);
        if(val_33 == null)
        {
            goto label_9;
        }
        
        if(val_6 == false)
        {
            goto label_10;
        }
        
        label_13:
        val_34 = "Shoot";
        goto label_11;
        label_4:
        this.丌丒不上不专且上丕 = 0f;
        return (float)val_32;
        label_9:
        if(val_6 == true)
        {
            goto label_13;
        }
        
        label_10:
        val_34 = "Shoot1";
        label_11:
        UnityEngine.AnimationClip val_7 = val_33.GetClip(name:  val_34);
        val_35 = 0.length;
        float val_10 = BalanceController.一丝丙丙不一丞丕丟(丟丈一下东业一丝丆:  val_2.业东丅东丌上丗丑不());
        val_10 = val_35 / val_10;
        float val_11 = val_10 + 0.05f;
        this.丌丒不上不专且上丕 = val_11;
        if(((val_2.下世下丂丂丌丑丝世() >= 1) && (this.isMelee != true)) && (this.isShotMelee != true))
        {
                val_32 = val_11 * (float)val_2.下世下丂丂丌丑丝世();
            if(val_32 < 0)
        {
                val_33 = this.下丏丆下丙与丘上丁();
            val_35 = (val_33.GetClip(name:  "Reload").length) / (BalanceController.不丟丄丗七丙丕世丆(丟丈一下东业一丝丆:  this.丌上丗丕不七世丅丁().业东丅东丌上丗丑不()));
            if(val_33 != 0)
        {
                val_33 = this.下丏丆下丙与丘上丁().不丌丁丁与上丘丌丈();
            if((val_33.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  32)) != false)
        {
                val_33 = this.下丏丆下丙与丘上丁().不丌丁丁与上丘丌丈();
            val_35 = val_35 / (val_33.七丐下东丂丅丝不丕(丂丑丑与与丘丁与丙:  32));
        }
        
        }
        
            float val_29 = val_11 * (float)val_2.下世下丂丂丌丑丝世();
            val_29 = val_35 + val_29;
            val_32 = val_29 / (float)val_2.下世下丂丂丌丑丝世();
            this.丌丒不上不专且上丕 = val_32;
        }
        
        }
        
        if(this.isCharging != false)
        {
                this.丌丒不上不专且上丕 = this.chargeTime;
        }
        
        label_34:
        if(this.isMelee == false)
        {
                return (float)val_32;
        }
        
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  15)) != false)
        {
                float val_31 = this.三世丗丆丕万丐且三.Item[15];
        }
        else
        {
                val_32 = 1f;
        }
        
        val_32 = this.丌丒不上不专且上丕 / val_32;
        return (float)val_32;
    }
    public float get_reloadLength()
    {
        UnityEngine.AnimationClip val_3 = this.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>().GetClip(name:  "Reload");
        if(val_3 != null)
        {
                return val_3.length;
        }
        
        return val_3.length;
    }
    internal float 业丂丛丟上且丂东丂(float 一上丞专业丝丟丘业 = 1, float 丆专三丈丛丗丑且东 = 0, bool 业一一七丂丞丁丝丝 = False)
    {
        float val_10;
        System.Single[] val_11;
        float val_12;
        val_10 = 丆专三丈丛丗丑且东;
        val_11 = this;
        val_12 = 0f;
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return val_13;
        }
        
        if(this.丌上丗丕不七世丅丁() == null)
        {
            goto label_4;
        }
        
        if(业一一七丂丞丁丝丝 == false)
        {
            goto label_5;
        }
        
        val_10 = this.丞与丁丝丅丄丒丒丁();
        goto label_6;
        label_4:
        val_11 = this.damageByTier;
        float val_10 = val_11[0];
        return val_13;
        label_5:
        val_12 = this.丌上丗丕不七世丅丁().业丘丐丕丘业下丝下() * val_10;
        val_10 = (this.丙下业七一一下世万() * 一上丞专业丝丟丘业) + val_12;
        label_6:
        float val_8 = this.且丈丗丗丞且丑丐专();
        val_8 = val_10 * val_8;
        this.专丆下丈丌一丝上一 = val_8;
        if(this.isShotGun != false)
        {
                if(BalanceController.专丑不七丅丅丄七三() != true)
        {
                float val_11 = this.专丆下丈丌一丝上一;
            val_11 = val_11 / 10f;
            this.专丆下丈丌一丝上一 = val_11;
        }
        
        }
        
        if(this.bazooka != true)
        {
                if(this.seriesShoot == false)
        {
            goto label_17;
        }
        
        }
        
        float val_12 = (float)this.countInSeriaBazooka;
        val_12 = this.专丆下丈丌一丝上一 / val_12;
        this.专丆下丈丌一丝上一 = val_12;
        label_17:
        float val_13 = this.专丆下丈丌一丝上一;
        if(this.isDamageFromDamageCollider == false)
        {
                return val_13;
        }
        
        val_13 = val_13 / (float)this.countInSeriaBazooka;
        this.专丆下丈丌一丝上一 = val_13;
        return val_13;
    }
    internal float 丛丆丑丁下丆丘丏丝()
    {
        var val_14;
        string val_16;
        string val_17;
        float val_18;
        val_14 = 1152921504848912384;
        if(((this.<丝丟丞丟丏丏丟不丙>k__BackingField) != 0) && ((this.<丝丟丞丟丏丏丟不丙>k__BackingField.instantMinigun) != false))
        {
                if((this.<丝丟丞丟丏丏丟不丙>k__BackingField.丐丅世世万丒东丕且()) > 0f)
        {
                if((this.<丝丟丞丟丏丏丟不丙>k__BackingField) != null)
        {
                return this.<丝丟丞丟丏丏丟不丙>k__BackingField.丐丅世世万丒东丕且();
        }
        
            return this.<丝丟丞丟丏丏丟不丙>k__BackingField.丐丅世世万丒东丕且();
        }
        
        }
        
        if(this.weaponIsNotFromConfig != false)
        {
                return val_18;
        }
        
        if(this.下万丏下七万丕下不 >= 0)
        {
                return val_18;
        }
        
        UnityEngine.Animation val_4 = this.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
        val_16 = "Shoot";
        UnityEngine.AnimationClip val_5 = val_4.GetClip(name:  "Shoot");
        if(this.isSimpleFlamethrower == false)
        {
            goto label_14;
        }
        
        val_14 = UnityEngine.Object.op_Inequality(x:  val_5, y:  0);
        if(val_4 == null)
        {
            goto label_17;
        }
        
        if(val_14 == false)
        {
            goto label_18;
        }
        
        label_28:
        val_17 = "Shoot";
        goto label_19;
        label_14:
        if(val_5 == 0)
        {
                val_16 = "Shoot1";
        }
        
        val_14 = val_4.GetClip(name:  val_16);
        UnityEngine.AnimationState val_10 = val_4.Item["Shoot1"];
        val_18 = val_14.length / 0.speed;
        goto label_27;
        label_17:
        if(val_14 == true)
        {
            goto label_28;
        }
        
        label_18:
        val_17 = "Shoot1";
        label_19:
        UnityEngine.AnimationClip val_12 = val_4.GetClip(name:  val_17);
        float val_13 = 0.length;
        this.下万丏下七万丕下不 = val_13;
        val_18 = val_13 / this.丞丄万世丏三与丐丅;
        label_27:
        val_18 = val_18 + 0.03333f;
        this.下万丏下七万丕下不 = val_18;
        return val_18;
    }
    internal float 丕丙丟丙丟丈丙丝东()
    {
        float val_3 = this.七万丏丛且丆丁世丁;
        if(val_3 >= 0)
        {
                return val_3;
        }
        
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  14)) != false)
        {
                float val_2 = this.三世丗丆丕万丐且三.Item[14];
        }
        else
        {
                val_3 = 1f;
        }
        
        this.七万丏丛且丆丁世丁 = val_3;
        return val_3;
    }
    internal UnityEngine.GameObject 下丁世一丟丝且丒专()
    {
        return (UnityEngine.GameObject)this.丆七丁世且丗不上世;
    }
    private UnityEngine.SkinnedMeshRenderer[] 下丄且万三业不下丗()
    {
        if(this.丄丗东丆丞三丛三世 != null)
        {
                return (UnityEngine.SkinnedMeshRenderer[])val_1;
        }
        
        T[] val_1 = this.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>(includeInactive:  true);
        this.丄丗东丆丞三丛三世 = val_1;
        return (UnityEngine.SkinnedMeshRenderer[])val_1;
    }
    internal UnityEngine.GameObject 丐丗丑丑丏万上业下()
    {
        var val_4;
        UnityEngine.GameObject val_5;
        var val_6;
        val_4 = this;
        if(this.isMechWeapon != false)
        {
                val_5 = this.MechAnimationObject;
        }
        else
        {
                if(this.三丒丘丂一丈丂丙不 != false)
        {
                val_5 = this.丆七丁世且丗不上世;
        }
        else
        {
                val_6 = 0;
            if(this._innerPars == 0)
        {
                return (UnityEngine.GameObject)val_6;
        }
        
            val_4 = this._innerPars;
            val_5 = val_3.animationObject;
        }
        
        }
        
        val_6 = mem[val_3.animationObject];
        return (UnityEngine.GameObject)val_6;
    }
    internal UnityEngine.Animation 丌丙丆下专丝丑且丈()
    {
        if(this.丘丟丕丏下丌专业下 != 0)
        {
                return (UnityEngine.Animation)this.丘丟丕丏下丌专业下;
        }
        
        if(this.丐丗丑丑丏万上业下() == 0)
        {
                return (UnityEngine.Animation)this.丘丟丕丏下丌专业下;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>())) == false)
        {
                return (UnityEngine.Animation)this.丘丟丕丏下丌专业下;
        }
        
        this.丘丟丕丏下丌专业下 = this.丐丗丑丑丏万上业下().GetComponent<UnityEngine.Animation>();
        return (UnityEngine.Animation)this.丘丟丕丏下丌专业下;
    }
    internal UnityEngine.Texture 丌且丛丅丙丕丘丕世()
    {
        var val_4;
        UnityEngine.Texture val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.preview;
        return val_5;
    }
    internal UnityEngine.AudioClip 丁与东东丂三丈丙世()
    {
        BearInnerWeaponPars val_6;
        UnityEngine.AudioClip val_7;
        var val_8;
        val_6 = this;
        if(((this.三丒丘丂一丈丂丙不 != false) && (this.一丌丙世丈三丐丙丒 != 0)) && (this.一丌丙世丈三丐丙丒.shoot != 0))
        {
                val_6 = this.一丌丙世丈三丐丙丒;
            val_7 = this.一丌丙世丈三丐丙丒.shoot;
        }
        else
        {
                val_8 = 0;
            if(this._innerPars == 0)
        {
                return (UnityEngine.AudioClip)val_8;
        }
        
            val_6 = this._innerPars;
            val_7 = val_5.shoot;
        }
        
        val_8 = mem[val_5.shoot];
        return (UnityEngine.AudioClip)val_8;
    }
    internal UnityEngine.AudioClip 丑丁一丟丒丗万丆一()
    {
        BearInnerWeaponPars val_6;
        UnityEngine.AudioClip val_7;
        var val_8;
        val_6 = this;
        if(((this.三丒丘丂一丈丂丙不 != false) && (this.一丌丙世丈三丐丙丒 != 0)) && (this.一丌丙世丈三丐丙丒.shoot != 0))
        {
                val_6 = this.一丌丙世丈三丐丙丒;
            val_7 = this.一丌丙世丈三丐丙丒.shoot;
        }
        else
        {
                val_8 = 0;
            if(this._innerPars == 0)
        {
                return (UnityEngine.AudioClip)val_8;
        }
        
            val_6 = this._innerPars;
            val_7 = val_5.shootSecond;
        }
        
        val_8 = mem[val_5.shootSecond];
        return (UnityEngine.AudioClip)val_8;
    }
    internal UnityEngine.AudioClip 丛东丒丛三业业业且()
    {
        BearInnerWeaponPars val_6;
        UnityEngine.AudioClip val_7;
        var val_8;
        val_6 = this;
        if(((this.三丒丘丂一丈丂丙不 != false) && (this.一丌丙世丈三丐丙丒 != 0)) && (this.一丌丙世丈三丐丙丒.reload != 0))
        {
                val_6 = this.一丌丙世丈三丐丙丒;
            val_7 = this.一丌丙世丈三丐丙丒.reload;
        }
        else
        {
                val_8 = 0;
            if(this._innerPars == 0)
        {
                return (UnityEngine.AudioClip)val_8;
        }
        
            val_6 = this._innerPars;
            val_7 = val_5.reload;
        }
        
        val_8 = mem[val_5.reload];
        return (UnityEngine.AudioClip)val_8;
    }
    internal UnityEngine.AudioClip 丏丅丟丂丐丛丛不丆()
    {
        BearInnerWeaponPars val_6;
        UnityEngine.AudioClip val_7;
        var val_8;
        val_6 = this;
        if(((this.三丒丘丂一丈丂丙不 != false) && (this.一丌丙世丈三丐丙丒 != 0)) && (this.一丌丙世丈三丐丙丒.empty != 0))
        {
                val_6 = this.一丌丙世丈三丐丙丒;
            val_7 = this.一丌丙世丈三丐丙丒.empty;
        }
        else
        {
                val_8 = 0;
            if(this._innerPars == 0)
        {
                return (UnityEngine.AudioClip)val_8;
        }
        
            val_6 = this._innerPars;
            val_7 = val_5.empty;
        }
        
        val_8 = mem[val_5.empty];
        return (UnityEngine.AudioClip)val_8;
    }
    internal UnityEngine.AudioClip 丆丛专丑丘专丌不且()
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.idle;
        return val_5;
    }
    internal UnityEngine.AudioClip 丌丏下万丄一丏世不()
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.zoomIn;
        return val_5;
    }
    internal UnityEngine.AudioClip 东万丘丗万丗丆丈丕()
    {
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = 0;
        if(this._innerPars == 0)
        {
                return (UnityEngine.AudioClip)val_8;
        }
        
        InnerWeaponPars val_3 = this._innerPars;
        val_7 = this._innerPars;
        val_8 = mem[val_4 != true ? val_5.zoomOut : val_5.zoomIn];
        val_8 = (val_3.zoomOut == 0) ? val_5.zoomOut : val_5.zoomIn;
        return (UnityEngine.AudioClip)val_8;
    }
    internal UnityEngine.AudioClip 且且东专三丛专上东()
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.charge;
        return val_5;
    }
    internal UnityEngine.AudioClip 且业丆一丙丗丞与丕()
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.loading;
        return val_5;
    }
    internal UnityEngine.AudioClip 丙丈丄丑丕丂丏丑与()
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.shootStart;
        return val_5;
    }
    internal UnityEngine.AudioClip 丄丙丛且丄丕丒不丂()
    {
        var val_4;
        UnityEngine.AudioClip val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.shootEnd;
        return val_5;
    }
    internal UnityEngine.GameObject 业丑丂业东丁一丝丁()
    {
        var val_4;
        UnityEngine.GameObject val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.bonusPrefab;
        return val_5;
    }
    internal UnityEngine.GameObject 丒丝且七丌丆丂上七()
    {
        var val_4;
        UnityEngine.GameObject val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.fakeGrenade;
        return val_5;
    }
    internal UnityEngine.Transform 丛丑丂丌与丗东下专()
    {
        var val_4;
        UnityEngine.Transform val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.LeftArmorHand;
        return val_5;
    }
    internal UnityEngine.Transform 丘万专丌丕与上丅丁()
    {
        var val_4;
        UnityEngine.Transform val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.RightArmorHand;
        return val_5;
    }
    internal UnityEngine.Transform 丞丗丒丒丗丘东丗丝()
    {
        BearInnerWeaponPars val_5;
        UnityEngine.Transform val_6;
        var val_7;
        val_5 = this;
        if((this.三丒丘丂一丈丂丙不 != false) && (this.一丌丙世丈三丐丙丒 != 0))
        {
                val_5 = this.一丌丙世丈三丐丙丒;
            val_6 = this.一丌丙世丈三丐丙丒.grenatePoint;
        }
        else
        {
                val_7 = 0;
            if(this._innerPars == 0)
        {
                return (UnityEngine.Transform)val_7;
        }
        
            val_5 = this._innerPars;
            val_6 = val_4.grenatePoint;
        }
        
        val_7 = mem[val_4.grenatePoint];
        return (UnityEngine.Transform)val_7;
    }
    internal UnityEngine.Transform[] 丏丒丟世丑七丑丅丐()
    {
        var val_4;
        UnityEngine.Transform[] val_5;
        val_4 = this;
        val_5 = 0;
        if(this._innerPars == 0)
        {
                return val_5;
        }
        
        val_4 = this._innerPars;
        val_5 = val_3.grenadePoints;
        return val_5;
    }
    public InnerWeaponPars get__innerPars()
    {
        InnerWeaponPars val_3;
        if(this._innerWeaponPars == 0)
        {
                this._innerWeaponPars = this.GetComponentInChildren<InnerWeaponPars>();
            return val_3;
        }
        
        val_3 = this._innerWeaponPars;
        return val_3;
    }
    internal WeaponAnimParticleEffects 专且七丝上丄且不业()
    {
        return (WeaponAnimParticleEffects)this.<丄丗丌丆专业专丙丞>k__BackingField;
    }
    private void 下丝丅且丐三万不丒(WeaponAnimParticleEffects 丙业与丙丗丝不丈东)
    {
        this.<丄丗丌丆专业专丙丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal float 丕丟丕业丑三下专丑()
    {
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
                return (float)this.shootDistance;
        }
        
        return (float)this.shootDistance;
    }
    internal bool 世丆丙七丈与丝丁丐()
    {
        if(this.isZooming == false)
        {
                return this.丏世上丏世不东丆与();
        }
        
        return true;
    }
    internal bool 丏世上丏世不东丆与()
    {
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return false;
        }
        
        if(this.下丏丆下丙与丘上丁() == 0)
        {
                return false;
        }
        
        Player_move_c val_4 = this.下丏丆下丙与丘上丁();
        if(val_4.mySkinName.firstPersonControl.丂丕丁且世丗丕丛专() == true)
        {
                return false;
        }
        
        if(this.isMelee != false)
        {
                return false;
        }
        
        var val_6 = (this.isRoundMelee == false) ? 1 : 0;
        return false;
    }
    internal bool 丙丗丏丙三丙上丝与()
    {
        return (bool)this.isZooming;
    }
    internal UnityEngine.Vector2 世丆丈丐东东丁丁丗()
    {
        UnityEngine.Vector2 val_8;
        var val_9;
        float val_10;
        float val_11;
        var val_12;
        WeaponManager val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        if(this.下丏丆下丙与丘上丁() == null)
        {
            goto label_3;
        }
        
        Player_move_c val_2 = this.下丏丆下丙与丘上丁();
        if(val_2.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_3;
        }
        
        val_8 = this.startZoneZoom;
        val_9 = 1152921540317951476;
        goto label_4;
        label_3:
        val_8 = this.startZone;
        val_9 = 1152921540317951364;
        label_4:
        val_10 = mem[this.startZone];
        val_10 = this.startZone.x;
        val_12 = null;
        val_12 = null;
        val_13 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_13 == 0)
        {
                return new UnityEngine.Vector2() {x = val_10, y = val_11};
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_13 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_13 == 0)
        {
                return new UnityEngine.Vector2() {x = val_10, y = val_11};
        }
        
        val_15 = null;
        val_15 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
                return new UnityEngine.Vector2() {x = val_10, y = val_11};
        }
        
        val_16 = null;
        val_16 = null;
        val_13 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_13 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        if(val_13 == 0)
        {
                return new UnityEngine.Vector2() {x = val_10, y = val_11};
        }
        
        val_17 = null;
        val_17 = null;
        val_13 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_13 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_10, y = 2.940981E-13f}, d:  typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 188);
        val_10 = val_7.x;
        val_11 = val_7.y;
        return new UnityEngine.Vector2() {x = val_10, y = val_11};
    }
    private float 不丛丆丝丗丒丞丄丅()
    {
        float val_9;
        float val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.下丏丆下丙与丘上丁() == null)
        {
            goto label_3;
        }
        
        Player_move_c val_2 = this.下丏丆下丙与丘上丁();
        if(val_2.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_3;
        }
        
        val_9 = this.maxKoofZoom;
        goto label_4;
        label_3:
        val_9 = this.maxKoof;
        label_4:
        val_10 = mem[this.maxKoof];
        val_10 = val_9;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_11 = null;
            val_11 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_12 = null;
            val_12 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_13 = null;
            val_13 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_628 != 0)
        {
                val_14 = null;
            val_14 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) != 0)
        {
                val_15 = null;
            val_15 = null;
            val_10 = val_10 * (typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 184);
        }
        
        }
        
        }
        
        }
        
        }
        
        float val_8 = this.丏七专丌丈丐丌丘三();
        val_8 = val_10 * val_8;
        return (float)val_8;
    }
    private float 丕世与丏不丏一丆下()
    {
        UnityEngine.Vector2 val_1 = this.世丆丈丐东东丁丁丗();
        float val_4 = this.一丛专七业不专丘丟();
        float val_5 = 5f;
        val_5 = val_1.y / val_5;
        val_5 = this.丁且三丂丄丒下东丐() * val_5;
        val_5 = this.世丐丈丟七且与与丑() * val_5;
        val_4 = val_4 * val_5;
        return (float)val_4;
    }
    private FirstPersonControlSharp 丐丂丝万七专丛东丝()
    {
        FirstPersonControlSharp val_7;
        if(this.丁丏丝丙七丁丕丘丒 == 0)
        {
                val_7 = 0;
            if(this.下丏丆下丙与丘上丁() != 0)
        {
                Player_move_c val_4 = this.下丏丆下丙与丘上丁();
            val_7 = 0;
            if(val_4.mySkinName != 0)
        {
                Player_move_c val_6 = this.下丏丆下丙与丘上丁();
            val_7 = val_6.mySkinName.firstPersonControl;
        }
        
        }
        
            this.丁丏丝丙七丁丕丘丒 = val_7;
            return val_7;
        }
        
        val_7 = this.丁丏丝丙七丁丕丘丒;
        return val_7;
    }
    private float 世丐丈丟七且与与丑()
    {
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  21)) == false)
        {
                return 1f;
        }
        
        if(this.三世丗丆丕万丐且三 != null)
        {
                return this.三世丗丆丕万丐且三.Item[21];
        }
        
        return this.三世丗丆丕万丐且三.Item[21];
    }
    private float 丁且三丂丄丒下东丐()
    {
        丄丁丂丗不一丐丐丙 val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = this;
        if(this.下丏丆下丙与丘上丁() == 0)
        {
                return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.专丌业丞业丛丗丌丄;
        }
        
        if(this.categoryNabor != 5)
        {
                return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.专丌业丞业丛丗丌丄;
        }
        
        Player_move_c val_3 = this.下丏丆下丙与丘上丁();
        val_5 = null;
        if(val_3.丄丁丑丞丅一三丌丆 != false)
        {
                val_6 = null;
            val_4 = PlayerCoreSettingsStorager.recoildAndScopeSettings;
            if(val_4 != null)
        {
                return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.专丌业丞业丛丗丌丄;
        }
        
            return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.专丌业丞业丛丗丌丄;
        }
        
        val_7 = null;
        val_4 = PlayerCoreSettingsStorager.recoildAndScopeSettings;
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.专丌业丞业丛丗丌丄;
    }
    private float 一丛专七业不专丘丟()
    {
        float val_3;
        if(this.下丏丆下丙与丘上丁() != null)
        {
                Player_move_c val_2 = this.下丏丆下丙与丘上丁();
            if(val_2.丄丁丑丞丅一三丌丆 != false)
        {
                val_3 = this.recoilCoeffZoom;
            return val_3;
        }
        
        }
        
        val_3 = this.recoilCoeff;
        return val_3;
    }
    private float 下丌东丒丝业上丗丄()
    {
        var val_1;
        丄丁丂丗不一丐丐丙 val_2;
        var val_4;
        if(this.专与丛丟世丐丒丄东 != false)
        {
                if(this.categoryNabor != 5)
        {
            goto label_2;
        }
        
        }
        
        val_1 = null;
        val_1 = null;
        val_2 = PlayerCoreSettingsStorager.recoildAndScopeSettings;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.与与东与丆丅丏丒丘
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.一且且丛与七丅世专;
        label_2:
        val_4 = null;
        val_4 = null;
        val_2 = PlayerCoreSettingsStorager.recoildAndScopeSettings;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.一且且丛与七丅世专
        return (float)PlayerCoreSettingsStorager.recoildAndScopeSettings.一且且丛与七丅世专;
    }
    private float 丞丆丒丛丁丝一丏丙()
    {
        null = null;
        UnityEngine.Vector2 val_3 = this.世丆丈丐东东丁丁丗();
        float val_5 = this.一丛专七业不专丘丟();
        float val_6 = 5f;
        val_6 = val_3.y / val_6;
        val_6 = val_6 / 3f;
        val_6 = (PlayerCoreSettingsStorager.recoildAndScopeSettings.丞丂与不不专丑一丝 * this.世丐丈丟七且与与丑()) * val_6;
        val_6 = this.丁且三丂丄丒下东丐() * val_6;
        val_5 = val_5 * val_6;
        return (float)val_5;
    }
    private float 丒七丅丆东丛丒丐三()
    {
        var val_6;
        float val_7;
        if(this.丐丂丝万七专丛东丝() != 0)
        {
                val_6 = null;
            val_6 = null;
            val_7 = mem[PlayerCoreSettingsStorager.recoildAndScopeSettings + 16];
            val_7 = PlayerCoreSettingsStorager.recoildAndScopeSettings.上丙丅一东上丛丘世;
        }
        else
        {
                val_7 = 0.5f;
        }
        
        float val_4 = this.一丛专七业不专丘丟();
        val_4 = (val_7 * this.丁且三丂丄丒下东丐()) * val_4;
        return (float)val_4;
    }
    internal Player_move_c 下丏丆下丙与丘上丁()
    {
        Player_move_c val_10;
        if(this == 0)
        {
                return (Player_move_c)this.上丑丆上丌东不世丏;
        }
        
        if(this.isMechWeapon == true)
        {
                return (Player_move_c)this.上丑丆上丌东不世丏;
        }
        
        if(this.丌丟丄业且三丛丕丄() == 0)
        {
                return (Player_move_c)this.上丑丆上丌东不世丏;
        }
        
        if(this.上丑丆上丌东不世丏 != 0)
        {
                return (Player_move_c)this.上丑丆上丌东不世丏;
        }
        
        UnityEngine.Transform val_6 = this.丌丟丄业且三丛丕丄().parent;
        if(val_6 == 0)
        {
                return (Player_move_c)this.上丑丆上丌东不世丏;
        }
        
        if(this.丏丄丌丁丝丗丄丗万 == val_6)
        {
                return (Player_move_c)this.上丑丆上丌东不世丏;
        }
        
        if((val_6.GetComponent<GetMyPlayerUtility>()) != null)
        {
                val_10 = val_9.myPlayer;
        }
        else
        {
                val_10 = 0;
        }
        
        this.上丑丆上丌东不世丏 = val_10;
        this.丏丄丌丁丝丗丄丗万 = val_6;
        return (Player_move_c)this.上丑丆上丌东不世丏;
    }
    internal string 三与丛丑且丐丈业丌()
    {
        if(this.上丐三三丁丈专丘丌 != null)
        {
                return val_2;
        }
        
        string val_2 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        this.上丐三三丁丈专丘丌 = val_2;
        return val_2;
    }
    internal void 丛与专丕丑万万丒丈(bool 丛与丙丒丒下丌丟且)
    {
        UnityEngine.SkinnedMeshRenderer val_5;
        var val_6;
        var val_7;
        val_6 = this;
        if(this.下丄且万三业不下丗() == null)
        {
                return;
        }
        
        val_6 = this.下丄且万三业不下丗();
        val_7 = 0;
        goto label_2;
        label_9:
        val_5 = val_6[0];
        if(val_5 != 0)
        {
                val_5.enabled = 丛与丙丒丒下丌丟且;
        }
        
        val_7 = 1;
        label_2:
        if(val_7 < val_2.Length)
        {
            goto label_9;
        }
    
    }
    internal void 不丑世丁丈业丕丑丘(bool 上万一丈丅丏业丂不)
    {
        bool val_7;
        if(上万一丈丅丏业丂不 != false)
        {
                val_7 = UnityEngine.Object.op_Inequality(x:  this.丆七丁世且丗不上世, y:  0);
        }
        else
        {
                val_7 = false;
        }
        
        this.三丒丘丂一丈丂丙不 = val_7;
        InnerWeaponPars val_2 = this._innerPars;
        val_2.animationObject.SetActive(value:  (this.三丒丘丂一丈丂丙不 == false) ? 1 : 0);
        if(this.丆七丁世且丗不上世 == 0)
        {
                return;
        }
        
        this.丆七丁世且丗不上世.SetActive(value:  (this.三丒丘丂一丈丂丙不 == true) ? 1 : 0);
    }
    private void Awake()
    {
        WeaponSounds val_37;
        float val_38;
        UnityEngine.GameObject val_39;
        val_37 = this;
        this.<与丁丑丂丛丒与丁丞>k__BackingField = UnityEngine.Object.op_Inequality(x:  this.weaponUltimate, y:  0);
        if(this._reloadEffect != 0)
        {
                this._reloadEffect.丌丝下丄业一丄不三 = val_37;
        }
        
        if(this._secondTimeFireAction != 0)
        {
                this._secondTimeFireAction.丌丝下丄业一丄不三 = val_37;
        }
        
        if(this._chargeShield != 0)
        {
                this._chargeShield.丌丝下丄业一丄不三 = val_37;
        }
        
        if(this._innerPars != 0)
        {
                InnerWeaponPars val_8 = this._innerPars;
            val_8.丌丝下丄业一丄不三 = val_37;
        }
        
        this.万丙丟三丏丘专专丏 = ExpController.东东丒丈丛丈七丘不() + 1;
        this.下专丘与丟三且丕下 = Player_move_c.丞丐且丄丆丙丝丅丐() + 1;
        this.丘世丒丅丂丙丙丒丞 = this.tekKoof;
        val_38 = this.timeForTekKoofVisual;
        if(this.且丈丗丗丞且丑丐专() < 0)
        {
                val_38 = this.且丈丗丗丞且丑丐专();
        }
        
        this.timerForTekKoofVisualByFireRate = val_38;
        this.<丝丟丞丟丏丏丟不丙>k__BackingField = this.GetComponent<MinigunController>();
        if(this._innerPars != 0)
        {
                this.<丄丗丌丆专业专丙丞>k__BackingField = this._innerPars.GetComponent<WeaponAnimParticleEffects>();
        }
        
        this.timerForTekKoofVisual = this.timeForTekKoofVisual;
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        val_39 = this.gameObject.name;
        UnityEngine.Object val_25 = UnityEngine.Resources.Load(path:  "MechBearWeapons/"("MechBearWeapons/") + val_39.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst)(val_39.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst)) + "_MechBear");
        if(val_25 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_29 = this.gameObject.transform.position;
        UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.identity;
        UnityEngine.Object val_31 = UnityEngine.Object.Instantiate(original:  val_25, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w});
        if(val_31 != null)
        {
                if(null == null)
        {
            goto label_41;
        }
        
        }
        
        val_39 = this.丆七丁世且丗不上世;
        this.丆七丁世且丗不上世 = 0;
        goto label_42;
        label_41:
        val_39 = this.丆七丁世且丗不上世;
        this.丆七丁世且丗不上世 = val_31;
        label_42:
        this.一丌丙世丈三丐丙丒 = val_31.GetComponent<BearInnerWeaponPars>();
        this.丆七丁世且丗不上世.transform.parent = this.gameObject.transform;
        val_37 = mem[this.丆七丁世且丗不上世];
        val_37.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        if(this._innerPars != 0)
        {
                UnityEngine.Object.Destroy(obj:  this._innerPars.gameObject);
        }
        
        if(this.iRayEffect == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.iRayEffect.gameObject);
    }
    private void Start()
    {
        if((System.String.IsNullOrEmpty(value:  this.bazookaExplosionName)) != false)
        {
                this.bazookaExplosionName = this.gameObject.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        }
        
        this.丅丟万丕东专丘丆三 = 0f;
        if((GameConnect.与不丗丏万丙丞丌丑() != false) && (this.下丏丆下丙与丘上丁() != 0))
        {
                if(this.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() != false)
        {
                this.SetArmRarity();
        }
        
        }
        
        this.业丘丗世世东下丟一();
    }
    internal void 业丘丗世世东下丟一()
    {
        float val_10;
        if(this.下丏丆下丙与丘上丁() == 0)
        {
            goto label_10;
        }
        
        Player_move_c val_3 = this.下丏丆下丙与丘上丁();
        if(val_3.丄丁丑丞丅一三丌丆 != false)
        {
                if(this.scatterInversionZoom == true)
        {
            goto label_6;
        }
        
        }
        
        Player_move_c val_4 = this.下丏丆下丙与丘上丁();
        if(val_4.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_8;
        }
        
        label_10:
        val_10 = 1f;
        this.tekKoof = 1f;
        goto label_9;
        label_8:
        if(this.scatterInversion == false)
        {
            goto label_10;
        }
        
        label_6:
        Player_move_c val_5 = this.下丏丆下丙与丘上丁();
        this.tekKoof = (val_5.丄丁丑丞丅一三丌丆 == true) ? this.maxKoofZoom : this.maxKoof;
        Player_move_c val_8 = this.下丏丆下丙与丘上丁();
        val_10 = this.不丛丆丝丗丒丞丄丅() + ((val_8.丄丁丑丞丅一三丌丆 == false) ? this.downKoofFirst : this.downKoofFirstZoom);
        label_9:
        this.三且丞万与世丏与一 = val_10;
    }
    private bool 丑与东丙丆丑丄七一()
    {
        if((this.丌丙丆下专丝丑且丈().IsPlaying(name:  "Shoot1")) == true)
        {
                return true;
        }
        
        if((this.丌丙丆下专丝丑且丈().IsPlaying(name:  "Shoot2")) != false)
        {
                return true;
        }
        
        UnityEngine.Animation val_5 = this.丌丙丆下专丝丑且丈();
        if(val_5 != null)
        {
                return val_5.IsPlaying(name:  "Shoot");
        }
        
        return val_5.IsPlaying(name:  "Shoot");
    }
    private void Update()
    {
        float val_75;
        float val_76;
        float val_77;
        float val_78;
        float val_79;
        float val_80;
        float val_81;
        float val_82;
        float val_83;
        float val_84;
        float val_85;
        float val_86;
        float val_87;
        float val_88;
        if(this.下丏丆下丙与丘上丁() == 0)
        {
            goto label_43;
        }
        
        Player_move_c val_3 = this.下丏丆下丙与丘上丁();
        if(val_3.丁丑丅丏丒不七上丁 != false)
        {
                if(this.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() != true)
        {
                if(this.下丏丆下丙与丘上丁().一丝丌丏万丐丌丆东() == false)
        {
            goto label_43;
        }
        
        }
        
        }
        
        val_75 = UnityEngine.Time.deltaTime;
        val_76 = 0f;
        this.丅丟万丕东专丘丆三 = UnityEngine.Mathf.Lerp(a:  this.丅丟万丕东专丘丆三, b:  val_76, t:  this.下丌东丒丝业上丗丄() * val_75);
        this.丟丌世丞业下丌七世();
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = this.丆丑丅丂丏一丞上上 + val_12;
        this.丆丑丅丂丏一丞上上 = val_12;
        Player_move_c val_13 = this.下丏丆下丙与丘上丁();
        if(val_13.丄丁丑丞丅一三丌丆 != false)
        {
                if(this.scatterInversionZoom == true)
        {
            goto label_14;
        }
        
        }
        
        Player_move_c val_14 = this.下丏丆下丙与丘上丁();
        if(val_14.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_16;
        }
        
        label_24:
        val_77 = this.丆丑丅丂丏一丞上上;
        float val_15 = this.丈专世世丙丅东且一();
        val_78 = this.tekKoof;
        if(val_77 >= 0)
        {
            goto label_17;
        }
        
        val_79 = 1f;
        if(val_78 <= val_79)
        {
            goto label_18;
        }
        
        Player_move_c val_16 = this.下丏丆下丙与丘上丁();
        val_75 = mem[val_16.丄丁丑丞丅一三丌丆 == false ? this.downKoofFirst : this.downKoofFirstZoom];
        val_75 = (val_16.丄丁丑丞丅一三丌丆 == false) ? this.downKoofFirst : this.downKoofFirstZoom;
        val_77 = UnityEngine.Time.deltaTime;
        float val_19 = this.丈专世世丙丅东且一();
        val_76 = val_75 * val_77;
        val_19 = val_76 / val_19;
        val_79 = val_78 - val_19;
        this.tekKoof = val_79;
        goto label_40;
        label_17:
        val_79 = 1f;
        if(val_78 <= val_79)
        {
            goto label_21;
        }
        
        Player_move_c val_20 = this.下丏丆下丙与丘上丁();
        val_75 = mem[val_20.丄丁丑丞丅一三丌丆 == false ? this.downKoof : this.downKoofZoom];
        val_75 = (val_20.丄丁丑丞丅一三丌丆 == false) ? this.downKoof : this.downKoofZoom;
        val_77 = UnityEngine.Time.deltaTime;
        float val_23 = this.丈专世世丙丅东且一();
        val_76 = val_75 * val_77;
        val_23 = val_76 / val_23;
        val_79 = val_78 - val_23;
        goto label_38;
        label_16:
        if(this.scatterInversion == false)
        {
            goto label_24;
        }
        
        label_14:
        val_75 = this.tekKoof;
        val_77 = this.丈专世世丙丅东且一();
        Player_move_c val_25 = this.下丏丆下丙与丘上丁();
        val_80 = this.maxKoof;
        val_78 = this.tekKoof;
        float val_26 = (val_25.丄丁丑丞丅一三丌丆 == true) ? this.maxKoofZoom : (val_80);
        Player_move_c val_27 = this.下丏丆下丙与丘上丁();
        if(this.丆丑丅丂丏一丞上上 >= 0)
        {
            goto label_26;
        }
        
        if(val_75 >= 0)
        {
            goto label_28;
        }
        
        val_75 = mem[val_27.丄丁丑丞丅一三丌丆 == true ? this.downKoofFirstZoom : this.downKoofFirst];
        val_75 = (val_27.丄丁丑丞丅一三丌丆 == true) ? this.downKoofFirstZoom : this.downKoofFirst;
        val_77 = UnityEngine.Time.deltaTime;
        float val_30 = this.丈专世世丙丅东且一();
        val_76 = val_75 * val_77;
        val_30 = val_76 / val_30;
        val_79 = val_78 + val_30;
        this.tekKoof = val_79;
        goto label_40;
        label_26:
        if(val_75 >= 0)
        {
            goto label_31;
        }
        
        val_75 = mem[val_27.丄丁丑丞丅一三丌丆 == true ? this.downKoofZoom : this.downKoof];
        val_75 = (val_27.丄丁丑丞丅一三丌丆 == true) ? this.downKoofZoom : this.downKoof;
        val_77 = UnityEngine.Time.deltaTime;
        float val_33 = this.丈专世世丙丅东且一();
        val_76 = val_75 * val_77;
        val_33 = val_76 / val_33;
        val_79 = val_78 + val_33;
        goto label_38;
        label_28:
        val_79 = mem[val_27.丄丁丑丞丅一三丌丆 == true ? this.maxKoofZoom : this.maxKoof];
        val_79 = (val_27.丄丁丑丞丅一三丌丆 == true) ? this.maxKoofZoom : (val_80);
        if(val_78 <= val_79)
        {
            goto label_40;
        }
        
        Player_move_c val_35 = this.下丏丆下丙与丘上丁();
        this.tekKoof = (val_35.丄丁丑丞丅一三丌丆 == true) ? this.maxKoofZoom : (val_80);
        goto label_40;
        label_31:
        val_79 = mem[val_27.丄丁丑丞丅一三丌丆 == true ? this.maxKoofZoom : this.maxKoof];
        val_79 = (val_27.丄丁丑丞丅一三丌丆 == true) ? this.maxKoofZoom : (val_80);
        if(val_78 <= val_79)
        {
            goto label_41;
        }
        
        Player_move_c val_38 = this.下丏丆下丙与丘上丁();
        val_79 = mem[val_38.丄丁丑丞丅一三丌丆 == true ? this.maxKoofZoom : this.maxKoof];
        val_79 = (val_38.丄丁丑丞丅一三丌丆 == true) ? this.maxKoofZoom : (val_80);
        goto label_38;
        label_18:
        if(val_78 >= 0)
        {
            goto label_40;
        }
        
        this.tekKoof = 1f;
        goto label_40;
        label_21:
        if(val_78 >= 0)
        {
            goto label_41;
        }
        
        label_38:
        this.tekKoof = val_79;
        label_41:
        this.专与丛丟世丐丒丄东 = false;
        label_40:
        if(this.下丏丆下丙与丘上丁().一丝丌丏万丐丌丆东() == true)
        {
            goto label_43;
        }
        
        Player_move_c val_42 = this.下丏丆下丙与丘上丁();
        if(this.timerForTekKoofVisual >= 0)
        {
            goto label_45;
        }
        
        if(val_42.丄丁丑丞丅一三丌丆 != false)
        {
                if(this.scatterInversionZoom == true)
        {
            goto label_47;
        }
        
        }
        
        Player_move_c val_43 = this.下丏丆下丙与丘上丁();
        if(val_43.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_49;
        }
        
        label_60:
        float val_69 = this.三且丞万与世丏与一;
        Player_move_c val_44 = this.下丏丆下丙与丘上丁();
        if(val_44.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_51;
        }
        
        val_81 = this.upKoofFireZoom;
        val_82 = this.downKoofFirstZoom;
        goto label_52;
        label_45:
        if(val_42.丄丁丑丞丅一三丌丆 != false)
        {
                if(this.scatterInversionZoom == true)
        {
            goto label_54;
        }
        
        }
        
        Player_move_c val_45 = this.下丏丆下丙与丘上丁();
        if(val_45.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_56;
        }
        
        label_64:
        val_83 = this.三且丞万与世丏与一;
        val_79 = 1f;
        if(val_83 <= val_79)
        {
            goto label_57;
        }
        
        Player_move_c val_46 = this.下丏丆下丙与丘上丁();
        val_84 = mem[val_46.丄丁丑丞丅一三丌丆 == false ? this.downKoof : this.downKoofZoom];
        val_84 = (val_46.丄丁丑丞丅一三丌丆 == false) ? this.downKoof : this.downKoofZoom;
        float val_48 = UnityEngine.Time.deltaTime;
        val_85 = -10f;
        goto label_59;
        label_49:
        if(this.scatterInversion == false)
        {
            goto label_60;
        }
        
        label_47:
        Player_move_c val_49 = this.下丏丆下丙与丘上丁();
        if(val_49.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_62;
        }
        
        val_86 = this.upKoofFireZoom;
        val_87 = this.downKoofFirstZoom;
        goto label_63;
        label_56:
        if(this.scatterInversion == false)
        {
            goto label_64;
        }
        
        label_54:
        float val_50 = this.不丛丆丝丗丒丞丄丅();
        val_83 = this.三且丞万与世丏与一;
        if(this.三且丞万与世丏与一 >= 0)
        {
            goto label_65;
        }
        
        Player_move_c val_51 = this.下丏丆下丙与丘上丁();
        val_84 = mem[val_51.丄丁丑丞丅一三丌丆 == false ? this.downKoof : this.downKoofZoom];
        val_84 = (val_51.丄丁丑丞丅一三丌丆 == false) ? this.downKoof : this.downKoofZoom;
        val_85 = 10f;
        label_59:
        val_85 = val_84 * val_85;
        val_88 = val_85 * UnityEngine.Time.deltaTime;
        goto label_67;
        label_65:
        if(val_83 <= this.不丛丆丝丗丒丞丄丅())
        {
            goto label_73;
        }
        
        float val_55 = this.不丛丆丝丗丒丞丄丅();
        goto label_69;
        label_62:
        val_86 = this.upKoofFire;
        val_87 = this.downKoofFirst;
        label_63:
        val_75 = val_86 + val_87;
        val_87 = val_75 * UnityEngine.Time.deltaTime;
        val_79 = 1f;
        val_87 = val_87 * 5f;
        val_87 = val_87 * ((this.且丈丗丗丞且丑丐专() > 1.5f) ? 5f : (val_79));
        val_87 = this.三且丞万与世丏与一 - val_87;
        this.三且丞万与世丏与一 = val_87;
        label_57:
        if(val_87 >= 0)
        {
            goto label_73;
        }
        
        this.三且丞万与世丏与一 = 1f;
        goto label_73;
        label_51:
        val_81 = this.upKoofFire;
        val_82 = this.downKoofFirst;
        label_52:
        val_75 = val_81 + val_82;
        val_82 = val_75 * UnityEngine.Time.deltaTime;
        val_82 = val_82 * 5f;
        float val_61 = (this.且丈丗丗丞且丑丐专() > 1.5f) ? 5f : 1f;
        val_61 = val_82 * val_61;
        val_69 = val_69 + val_61;
        this.三且丞万与世丏与一 = val_69;
        Player_move_c val_63 = this.下丏丆下丙与丘上丁();
        val_80 = this.downKoofFirstZoom;
        val_79 = this.不丛丆丝丗丒丞丄丅() + ((val_63.丄丁丑丞丅一三丌丆 == false) ? this.downKoofFirst : (val_80));
        if(val_69 <= val_79)
        {
            goto label_73;
        }
        
        val_83 = this.不丛丆丝丗丒丞丄丅();
        Player_move_c val_66 = this.下丏丆下丙与丘上丁();
        val_88 = mem[val_66.丄丁丑丞丅一三丌丆 == false ? this.downKoofFirst : this.downKoofFirstZoom];
        val_88 = (val_66.丄丁丑丞丅一三丌丆 == false) ? this.downKoofFirst : (val_80);
        label_67:
        val_79 = val_83 + val_88;
        label_69:
        this.三且丞万与世丏与一 = val_79;
        label_73:
        val_77 = this.timerForTekKoofVisual;
        float val_68 = UnityEngine.Time.deltaTime;
        val_68 = val_77 + val_68;
        this.timerForTekKoofVisual = val_68;
        label_43:
        this.东丟丝丘一丆丕世一();
    }
    internal void 丘丘丆七世万丂丄丟()
    {
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        this.丅丟万丕东专丘丆三 = UnityEngine.Mathf.Clamp(value:  this.丅丟万丕东专丘丆三 + this.丞丆丒丛丁丝一丏丙(), min:  0f, max:  this.丕世与丏不丏一丆下());
        this.专与丛丟世丐丒丄东 = true;
    }
    private void LateUpdate()
    {
        this.与丕上上万丆专业丄();
    }
    internal void 与丕上上万丆专业丄()
    {
        if(this.丌丟丄业且三丛丕丄().parent == 0)
        {
                return;
        }
        
        if(this.下丏丆下丙与丘上丁() == 0)
        {
                return;
        }
        
        if(this.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == true)
        {
                return;
        }
        
        Player_move_c val_8 = this.下丏丆下丙与丘上丁();
        if(val_8.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        Player_move_c val_11 = this.下丏丆下丙与丘上丁();
        var val_12 = (val_11.万万一与丝业七专下 == true) ? 1 : 0;
        val_12 = this.丐丗丑丑丏万上业下().activeSelf ^ val_12;
        if(val_12 != false)
        {
                return;
        }
        
        Player_move_c val_14 = this.下丏丆下丙与丘上丁();
        this.丐丗丑丑丏万上业下().SetActive(value:  (val_14.万万一与丝业七专下 == false) ? 1 : 0);
    }
    private void 东丟丝丘一丆丕世一()
    {
        var val_10;
        var val_11;
        var val_13;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.下丏丆下丙与丘上丁() == 0)
        {
                return;
        }
        
        if(this.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == true)
        {
                return;
        }
        
        UnityEngine.Animation val_6 = this._innerPars.GetComponent<UnityEngine.Animation>();
        if(val_6.isPlaying == true)
        {
                return;
        }
        
        val_10 = this.下丏丆下丙与丘上丁();
        if(val_8.丏世万万上一下丕万 != false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        bool val_9 = val_6.Play(animation:  WeaponSounds.丄丘一专与丄下且丞);
    }
    private float 丏七专丌丈丐丌丘三()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_13;
        var val_14;
        float val_15;
        var val_16;
        var val_17;
        float val_18;
        var val_19;
        UnityEngine.Object val_20;
        var val_21;
        var val_22;
        var val_24;
        val_13 = this;
        val_14 = null;
        val_14 = null;
        val_15 = 1f;
        if(PlayerEffectContainer.丗上与丈丕丁且七世 != true)
        {
                val_16 = null;
            val_16 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_17 = null;
            val_17 = null;
            val_18 = 1f;
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != val_20)
        {
                val_21 = null;
            val_21 = null;
            val_20 = 21;
            if((不丌丁丁与上丘丌丈().丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  21)) != false)
        {
                val_22 = null;
            val_22 = null;
            val_20 = 21;
            val_15 = (((typeof(Player_move_c).__il2cppRuntimeField_628.IsSetEquipped(丂万丏专丒下丈丂丟:  4096)) != true) ? 0.5f : (val_18)) * (不丌丁丁与上丘丌丈().丛万丟丕丗丒七不丄(丂丑丑与与丘丁与丙:  21));
        }
        
        }
        
        if(丘丐丘万丌丟丞下丝.丕丆丒丆一丕世丘丘() != false)
        {
                val_24 = null;
            val_24 = null;
            float val_10 = 东丟丟万下丛丆丛丟.丟丛丙七一与专上丆.丒丞丌丒业丐丏丑丟();
            val_10 = 100f - val_10;
            val_18 = val_10 / 100f;
            val_15 = val_15 * val_18;
        }
        
        if((this.三世丗丆丕万丐且三.ContainsKey(key:  8)) == false)
        {
                return (float)val_15;
        }
        
        val_13 = this.三世丗丆丕万丐且三;
        val_15 = val_15 * val_13.Item[8];
        return (float)val_15;
    }
    internal void 丝丅业且丆东与丗不()
    {
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
                return;
        }
        
        this.丆丑丅丂丏一丞上上 = 0f;
        if(this.下丏丆下丙与丘上丁() == null)
        {
            goto label_4;
        }
        
        Player_move_c val_3 = this.下丏丆下丙与丘上丁();
        if(val_3.丄丁丑丞丅一三丌丆 != false)
        {
                if(this.scatterInversionZoom == true)
        {
            goto label_7;
        }
        
        }
        
        Player_move_c val_4 = this.下丏丆下丙与丘上丁();
        if(val_4.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_9;
        }
        
        label_15:
        Player_move_c val_5 = this.下丏丆下丙与丘上丁();
        if(val_5.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_11;
        }
        
        val_17 = this.upKoofFireZoom;
        val_18 = this.downKoofFirstZoom;
        goto label_12;
        label_4:
        float val_16 = this.upKoofFire;
        val_16 = val_16 + this.downKoofFirst;
        val_19 = this.tekKoof + val_16;
        this.tekKoof = val_19;
        float val_6 = this.不丛丆丝丗丒丞丄丅();
        val_6 = val_6 + this.downKoofFirst;
        if(val_19 <= val_6)
        {
            goto label_22;
        }
        
        val_20 = this.不丛丆丝丗丒丞丄丅() + this.downKoofFirst;
        goto label_14;
        label_9:
        if(this.scatterInversion == false)
        {
            goto label_15;
        }
        
        label_7:
        val_19 = this.tekKoof;
        Player_move_c val_8 = this.下丏丆下丙与丘上丁();
        if(val_8.丄丁丑丞丅一三丌丆 != false)
        {
                val_21 = this.upKoofFireZoom;
            val_22 = this.downKoofFirstZoom;
        }
        else
        {
                val_21 = this.upKoofFire;
            val_22 = this.downKoofFirst;
        }
        
        val_21 = val_21 + val_22;
        val_21 = val_19 - val_21;
        this.tekKoof = val_21;
        if(val_21 >= 0)
        {
            goto label_22;
        }
        
        this.tekKoof = 1f;
        goto label_22;
        label_11:
        val_17 = this.upKoofFire;
        val_18 = this.downKoofFirst;
        label_12:
        val_17 = val_17 + val_18;
        float val_9 = this.tekKoof + val_17;
        this.tekKoof = val_9;
        val_19 = this.不丛丆丝丗丒丞丄丅();
        Player_move_c val_11 = this.下丏丆下丙与丘上丁();
        float val_17 = (val_11.丄丁丑丞丅一三丌丆 == false) ? this.downKoofFirst : this.downKoofFirstZoom;
        val_17 = val_19 + val_17;
        if(val_9 <= val_17)
        {
            goto label_22;
        }
        
        val_19 = this.不丛丆丝丗丒丞丄丅();
        Player_move_c val_14 = this.下丏丆下丙与丘上丁();
        val_20 = val_19 + ((val_14.丄丁丑丞丅一三丌丆 == false) ? this.downKoofFirst : this.downKoofFirstZoom);
        label_14:
        this.tekKoof = val_20;
        label_22:
        this.timerForTekKoofVisual = 0f;
    }
    public bool NextHitCritical()
    {
        return (bool)this.丄丄不七丙上业业上;
    }
    public void SetNextHitCritical(bool 三丟东丕丄丄下下丑)
    {
        this.丄丄不七丙上业业上 = 三丟东丕丄丄下下丑;
    }
    internal bool 丑且丏丗丗丟专丗世()
    {
        var val_4;
        if(this.下丏丆下丙与丘上丁() == null)
        {
            goto label_4;
        }
        
        Player_move_c val_2 = this.下丏丆下丙与丘上丁();
        if(val_2.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_2;
        }
        
        if(this.firstShotScatterZoom == true)
        {
            goto label_6;
        }
        
        goto label_4;
        label_2:
        if(this.firstShotScatter == true)
        {
            goto label_6;
        }
        
        label_4:
        if(this.tekKoof == this.丘世丒丅丂丙丙丒丞)
        {
                var val_3 = (this.丆丑丅丂丏一丞上上 >= 0.5f) ? 1 : 0;
            return (bool)val_4;
        }
        
        label_6:
        val_4 = 0;
        return (bool)val_4;
    }
    internal System.Collections.Generic.List<UnityEngine.GameObject> 与东七万丘东丙丄丟()
    {
        if(this._innerPars == 0)
        {
                return 0;
        }
        
        this = this._innerPars.GetComponent<WeaponAnimParticleEffects>();
        if(this == 0)
        {
                return 0;
        }
        
        if(this != null)
        {
                return this.GetListAnimEffects();
        }
        
        return this.GetListAnimEffects();
    }
    internal void 丗丂丟丟丒一丐丆丆()
    {
        this.下万丏下七万丕下不 = -1f;
    }
    internal bool 丌丆丈丈丌不丈丄丗()
    {
        if(this.isShotGun == false)
        {
                return false;
        }
        
        return BalanceController.专丑不七丅丅丄七三();
    }
    internal bool 丄丛丈丗业丘三丛上()
    {
        if(this.isDoubleShot == true)
        {
                return true;
        }
        
        if(this.isExoskelet == false)
        {
                return (bool)(this.isCameraInCenter == true) ? 1 : 0;
        }
        
        return true;
    }
    internal float 丁丕丕七丁丏专丟业()
    {
        var val_3;
        if(this.isMelee == true)
        {
                return (float)this.range;
        }
        
        if(this.isSectorsAOE != false)
        {
                return (float)this.range;
        }
        
        if(this.flamethrower != true)
        {
                if(this.snowStorm == false)
        {
            goto label_4;
        }
        
        }
        
        float val_3 = this.range;
        val_3 = val_3 + (-0.15f);
        return (float)this.range;
        label_4:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return this.丕丟丕业丑三下专丑();
        }
        
        if(this.categoryNabor != 5)
        {
                return this.丕丟丕业丑三下专丑();
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丄丁丑丞丅一三丌丆 == false)
        {
                return this.丕丟丕业丑三下专丑();
        }
        
        if(与丂丏丛丞丞丒丟丄.东不丟丗业上业丈丄() != 2)
        {
                return this.丕丟丕业丑三下专丑();
        }
        
        return (float)this.range;
    }
    internal bool 丙七丟丕且丒丅丟丅()
    {
        return (bool)this.isExoskelet;
    }
    private void 丟丌世丞业下丌七世()
    {
        float val_17;
        float val_18;
        float val_19;
        Player_move_c val_1 = this.下丏丆下丙与丘上丁();
        if(val_1.mySkinName.firstPersonControl.世丟丈丏丕万丝丆万.isGrounded == true)
        {
            goto label_20;
        }
        
        Player_move_c val_3 = this.下丏丆下丙与丘上丁();
        UnityEngine.Vector3 val_4 = val_3.mySkinName.firstPersonControl.丞业不不与与世丞上();
        float val_17 = val_4.y;
        Player_move_c val_5 = this.下丏丆下丙与丘上丁();
        UnityEngine.Vector3 val_6 = val_5.mySkinName.firstPersonControl.丞业不不与与世丞上();
        Player_move_c val_7 = this.下丏丆下丙与丘上丁();
        UnityEngine.Vector3 val_8 = val_7.mySkinName.firstPersonControl.丞业不不与与世丞上();
        Player_move_c val_9 = this.下丏丆下丙与丘上丁();
        val_17 = val_17 * val_6.y;
        UnityEngine.Vector3 val_10 = val_9.mySkinName.firstPersonControl.丞业不不与与世丞上();
        if(System.Math.Abs(val_17) <= val_8.x)
        {
            goto label_20;
        }
        
        Player_move_c val_11 = this.下丏丆下丙与丘上丁();
        if(val_11.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_22;
        }
        
        if(this.instantVerticalMoveScatterCoeffZoom == false)
        {
            goto label_23;
        }
        
        val_17 = this.moveScatterCoeffZoom;
        goto label_33;
        label_20:
        Player_move_c val_12 = this.下丏丆下丙与丘上丁();
        if(val_12.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_32;
        }
        
        label_23:
        if(this.instantHorizontalMoveScatterCoeffZoom == false)
        {
            goto label_34;
        }
        
        Player_move_c val_13 = this.下丏丆下丙与丘上丁();
        float val_14 = val_13.mySkinName.firstPersonControl.丁丅且七丝丆不万丐();
        val_18 = this.moveScatterCoeffZoom;
        goto label_31;
        label_22:
        if(this.instantVerticalMoveScatterCoeff == false)
        {
            goto label_32;
        }
        
        val_17 = this.moveScatterCoeff;
        goto label_33;
        label_32:
        if(this.instantHorizontalMoveScatterCoeff == false)
        {
            goto label_34;
        }
        
        Player_move_c val_15 = this.下丏丆下丙与丘上丁();
        val_18 = this.moveScatterCoeff;
        label_31:
        val_17 = val_15.mySkinName.firstPersonControl.丁丅且七丝丆不万丐() * val_18;
        label_33:
        val_19 = val_17 + 1f;
        goto label_38;
        label_34:
        val_19 = 1f;
        label_38:
        this.丌丑下丆东与东业丆 = val_19;
    }
    public WeaponSounds()
    {
        this.ammoInClip = ;
        this.InitialAmmo = ;
        this.maxAmmo = 42949673044;
        this.ammoForBonusShotMelee = 10;
        this.categoryNabor = 1;
        this.maxKoof = ;
        this.tekKoof = ;
        this.upKoofFire = 0.5f;
        this.downKoofFirst = 0.2f;
        this.scopeCircleRadius = ;
        this.scopePointsSpeed = ;
        this.scopeMovementSpeed = 0.03f;
        this.scopeTrashHoldForDistanceToPoint = 1f;
        this.downKoof = 0.2f;
        this.三且丞万与世丏与一 = 1f;
        this.timeForTekKoofVisual = 0.4f;
        this.fieldOfViewZomm = 75f;
        this.scopeStartValueSpeedIncreace = 10f;
        this.scopeIncreaceStep = 5.510186E-41f;
        this.alternativeName = "Weapon1";
        this.丌丑下丆东与东业丆 = 1f;
        this.instantVerticalMoveScatterCoeff = 1;
        this.recoilCoeff = 1f;
        this.maxKoofZoom = ;
        this.upKoofFireZoom = ;
        this.downKoofFirstZoom = 0.2f;
        this.downKoofZoom = 0.2f;
        this.丏丄一业丆一丆丐丝 = 1f;
        this.instantVerticalMoveScatterCoeffZoom = 1;
        this.recoilCoeffZoom = 1f;
        this.stepTimeInSeriaBazooka = 0.2f;
        this.bazookaImpulseRadius = 6f;
        this.impulseForce = 90f;
        this.impulseForceSelf = 3.673364E-41f;
        this.fangAngle = 15f;
        this.bazookaExplosionName = "Weapon75";
        this.bazookaExplosionRadius = 5f;
        this.bazookaExplosionRadiusSelf = 2.5f;
        this.countInSeriaBazooka = 1;
        mem2[0] = 1084227584;
        this.meleeAttackTimeModifier = 0.57f;
        this.meleePunchesCount = 1;
        this.countShots = 15;
        this.countReflectionRay = 1;
        this.railName = "Weapon77";
        mem2[0] = 1045220557;
        this.poisonDamageMultiplier = 0.1f;
        this.poisonTime = 2f;
        this.curseTime = 3f;
        this.curseDamageMultiplier = 2f;
        this.jumpDisableTime = 3f;
        this.enemyMarketChargeTime = 2f;
        this.enemyMarkerAngle = 10f;
        this.enemyMarkerTriangleCathetLength = 1.5f;
        this.blindEffect = 23;
        this.chargeTime = 2f;
        this.damageHealMultiplier = 0.1f;
        this.gadgetDisableTime = 2f;
        this.poisonCount = 3;
        this.poisonType = 1;
        this.isBlindEffectTime = 5f;
        this.charmTime = 5f;
        this.weaknessEffectTime = 5f;
        mem2[0] = ;
        this.dashMaxImpulse = 100f;
        mem2[0] = 2145386496;
        mem2[0] = ;
        mem2[0] = ;
        this.polymorphDuarationTime = 7f;
        this.polymorphMaxHealth = 20f;
        this.harpoonMinDistance = 2f;
        this.snowStormBonusMultiplier = 0.1f;
        this.snowStormBonusRange = 2.5f;
        mem2[0] = 4611686019501129728;
        this.killedTargetExplosionDamageMultiplier = 2f;
        this.dotTimeFlamethrower = 0.2f;
        this.coinDropChance = 0.1f;
        this.explosionNameForKilledTarget = "Explosion501";
        this.frostSwordAngle = 90f;
        this.ammoRestoreTime = 1f;
        this.丞丄万世丏三与丐丅 = 1f;
        this.buffPointsRevenge = 1f;
        this.buffBonusPointsForKill = 1f;
        this.buffBonusPointsForAssist = 1f;
        mem2[0] = ;
        this.shotgunOverDamageCoef = 1.2f;
        mem2[0] = ;
        mem2[0] = 1048576000;
        this.criticalHitCoef = 2f;
        this.shockerDamageMultiplier = 0.1f;
        this.shockerRange = 2.5f;
        this.bonusLocalPosition = 0;
        mem[1152921540323455008] = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.bonusLocalScale = val_1;
        mem[1152921540323455016] = val_1.y;
        mem[1152921540323455020] = val_1.z;
        this.InShopEffects = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        this.IsActiveAim = 1;
        this.丅三丌不业丟丗丒万 = -1f;
        this.专丆下丈丌一丝上一 = -1f;
        this.丌丒不上不专且上丕 = -1f;
        this.不上业丞丕业丏丁丅 = -1f;
        this.scaleShop = 150f;
        this.三世丗丆丕万丐且三 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        this.radiusHealing = 5f;
        this.countShootInBurst = 3;
        this.delayInBurstShooting = 1f;
        this.damageByTier = new float[6] {6.896631E-41f, 6.896631E-41f, 6.896631E-41f, 6.896631E-41f, 6.896631E-41f, 6.896631E-41f};
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  -15f, y:  15f);
        this.damageRange = val_5.x;
        mem[1152921540323455284] = val_5.y;
        this.daterMessage = System.String.alignConst;
        this.dpses = new float[6] {6.896631E-41f, 6.896631E-41f, 6.896631E-41f, 6.896631E-41f, 6.896631E-41f, 6.896631E-41f};
        this.ragdollImpulse = 1f;
        mem2[0] = 1049136359;
        this.bulletSpawnPoints = new System.Collections.Generic.List<BulletSpawnPoint>();
        this.inAppExtensionModifier = 10;
        this.gunPosition = 0;
        this.Probability = 1;
        this.loudnessScale = 1f;
        mem[1152921540323455352] = 0;
        mem2[0] = 1065353216;
        this.shootDistance = 100f;
        this.specialEffect = 0;
        this.speedModifier = 1f;
        this.丆丑丅丂丏一丞上上 = 1000f;
        mem2[0] = -1082130432;
        this.七万丏丛且丆丁世丁 = -1f;
    }
    private static WeaponSounds()
    {
        System.Collections.Generic.Dictionary<丈不三丛七丑丈丑丆, System.ValueTuple<System.String, System.String, System.String>> val_2 = new System.Collections.Generic.Dictionary<丈不三丛七丑丈丑丆, System.ValueTuple<System.String, System.String, System.String>>(capacity:  100, comparer:  new WeaponSounds.丟业业丗丕一丂丅丛());
        val_2.Add(key:  0, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  1, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  2, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  3, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  4, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  5, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  6, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  7, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  8, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  9, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  10, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  11, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  12, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  13, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  14, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  15, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  16, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  17, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  18, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  19, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  20, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  21, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  22, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  23, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  24, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  25, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  26, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  27, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  28, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  29, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  30, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  31, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  32, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  33, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  34, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  35, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  36, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  37, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  38, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  39, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  40, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  41, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  42, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  43, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  44, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  45, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  46, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  47, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  48, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  49, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  50, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  51, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  52, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  53, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  54, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  55, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  56, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  57, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  58, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  59, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  60, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  61, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  62, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  63, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  64, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  65, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  66, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  67, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  68, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  69, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  70, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  71, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  72, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  73, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  74, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  75, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  76, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  77, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  78, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  79, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  80, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  81, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  82, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  83, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  84, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  85, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  86, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  87, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  88, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  89, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  90, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  91, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  92, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  93, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  94, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  95, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  96, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  97, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  98, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  99, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  100, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  101, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  102, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  103, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  104, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  105, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  106, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  107, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  108, value:  new System.ValueTuple<System.String, System.String, System.String>());
        val_2.Add(key:  109, value:  new System.ValueTuple<System.String, System.String, System.String>());
        WeaponSounds.三丘丒万丛丞与一不 = val_2;
        System.Collections.Generic.Dictionary<PGCompany.丕万丁不丁丑东丌七, System.Collections.Generic.KeyValuePair<System.String, System.String>> val_4 = new System.Collections.Generic.Dictionary<PGCompany.丕万丁不丁丑东丌七, System.Collections.Generic.KeyValuePair<System.String, System.String>>(capacity:  3, comparer:  new WeaponSounds.专世丈下业世丟丛业());
        MoonSharp.Interpreter.TablePair val_5 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_fire_rate", val:  "Key_0435");
        val_4.Add(key:  1, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_5.key});
        MoonSharp.Interpreter.TablePair val_6 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_capacity", val:  "Key_0434");
        val_4.Add(key:  2, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_6.key});
        MoonSharp.Interpreter.TablePair val_7 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_mobility", val:  "Key_0432");
        val_4.Add(key:  3, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_7.key});
        MoonSharp.Interpreter.TablePair val_8 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_atk_speed", val:  "Key_0439");
        val_4.Add(key:  4, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_8.key});
        MoonSharp.Interpreter.TablePair val_9 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_cooldown", val:  "Key_2499");
        val_4.Add(key:  5, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_9.key});
        MoonSharp.Interpreter.TablePair val_10 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_lifetime", val:  "Key_2501");
        val_4.Add(key:  6, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_10.key});
        MoonSharp.Interpreter.TablePair val_11 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_healing", val:  "Key_2500");
        val_4.Add(key:  7, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_11.key});
        MoonSharp.Interpreter.TablePair val_12 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_dmg", val:  "Key_0437");
        val_4.Add(key:  8, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_12.key});
        MoonSharp.Interpreter.TablePair val_13 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_mobility", val:  "Key_0361");
        val_4.Add(key:  9, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_13.key});
        MoonSharp.Interpreter.TablePair val_14 = new MoonSharp.Interpreter.TablePair(key:  "shop_stats_jump", val:  "Key_8043");
        val_4.Add(key:  10, value:  new System.Collections.Generic.KeyValuePair<System.Object, System.Object>() {Value = val_14.key});
        WeaponSounds.丑丝三丙业丑世丝丟 = val_4;
        WeaponSounds.丄丘一专与丄下且丞 = "Idle";
        WeaponSounds.七丘丌丅三丕与下丆 = "Walk";
        WeaponSounds.丁与且丅丕丏业且不 = "Shoot";
        WeaponSounds.且不丄丄丐丁万三与 = "Shoot1";
        WeaponSounds.丆丛且丞东丌丏丑丄 = "Shoot2";
        WeaponSounds.丑丅与丒丝且万丞丙 = "Peg";
        WeaponSounds.三丕一东丕东丁丘丁 = "Shoot_start";
        WeaponSounds.且万丗丂下丁万万丙 = "Shoot_end";
    }

}
