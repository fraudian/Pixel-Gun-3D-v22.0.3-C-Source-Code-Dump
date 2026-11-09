using UnityEngine;
public sealed class FirstPersonControlSharp : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private FirstPersonCamera firstPersonCamera;
    private UnityEngine.GameObject thirdPersonCameraPrefab;
    private ThirdPersonCamera 且丛丈丂丒丟丘丅丄;
    private FirstPersonControlSharp.万丙专丟丆专东丟丕 <且丂一与且丐丕丗丈>k__BackingField;
    private UnityEngine.Coroutine 丅业上丙丗丂东与一;
    internal static float 三丅不丙丗丙业专不;
    internal static float 丗丟丈一丁七丛丞丙;
    private const string 丟世世且丞丌丝丏专 = "NinjaJumpsCount";
    private int 丟一万丗上不下丕丌;
    private const string 丑三东世且东丏丐上 = "NewbieJumperAchievement";
    private static float 三专专世丆丏丌不七;
    private float 丗丒丅一丗丑丌丂万;
    private float 万丑且丄丘丕丆七丆;
    public float accuracyMoveModifier;
    public UnityEngine.Transform areaVisitMonitor;
    public DetectColliderHit detectHeadColliderHit;
    public UnityEngine.GameObject dustParticle;
    public PlayerGliderSettings[] glidersSettings;
    public UnityEngine.AudioClip jumpClip;
    public float ladderSpeed;
    public UnityEngine.GameObject playerGameObject;
    public System.Collections.Generic.List<SlowdownCollider> slowdownList;
    public UnityEngine.Transform thirdCameraPivodInBattleRoyale;
    public UnityEngine.GameObject thirdCameraPrefab;
    public UnityEngine.Transform weaponBonusForavard;
    public UnityEngine.Transform weaponBonusPoint;
    internal Player_move_c _moveC;
    internal float 专与丛七与丏丝上丅;
    internal float 丁下丏一业丗业丗三;
    internal UnityEngine.Vector3 丁下丁丕丞丒专业一;
    internal int 丝三丟且三三与且世;
    internal float 不丕丐七丞丄丕丒丙;
    internal UnityEngine.CharacterController 世丟丈丏丕万丝丆万;
    internal TransportControllerBase 丌专丒丒丛丐丘上丄;
    internal float 万丗丈丗三不丌不丆;
    internal float 七七丌七丄丄丄与七;
    internal bool 丑丞丒丟丞丟丆丁一;
    internal bool 丛丗丑丝丕丌七与丆;
    internal UnityEngine.Vector2 丕丅东丁丛丌上丛丌;
    internal float 世丅上丁丂丝丆丗丞;
    internal float 万世东丞丑丟丒世三;
    internal float 一丐丒一丒丈丛丐丂;
    internal byte 下丈丞丝与上下丝丙;
    internal bool 且丆丅丏丌丗丛丄丌;
    internal bool 下丅丂丘丏丟世且丐;
    internal bool 丅丁丝丞丄丏三丌三;
    internal bool 上丛七丂丐下一丐丗;
    internal bool 丐丂丕丂丑三丑丒一;
    internal bool 一三丌与丑丑丞丈丟;
    internal bool 丝且与丘七丆专且丂;
    internal bool 丌且下丕下下丌万丞;
    internal bool 丈丛丅丟丒下世三丝;
    internal bool 丛世下丝业丞丐丅丅;
    internal bool 丝丝丐业不业与丐下;
    internal UnityEngine.Vector2 一与东三世丘丞丙丐;
    internal bool 世丂丁丟世丄丕丆丄;
    internal UnityEngine.Vector2 业不三丈一专丑不业;
    internal bool 万丆丏下专一业与丅;
    internal UnityEngine.Vector3 与世东丙丕一上丁与;
    internal float 丈丝丟丌丈丄一上丆;
    internal float 丏丆丆丒丗丗丙丈丁;
    internal string 丏七世丐丂丝丞丛上;
    internal SkinName 丞丗丄丂丆业丈丑业;
    internal bool 一丙专丄丗东丟丞丂;
    internal System.Action<FirstPersonControlSharp, float> 不丐丝丕上世上与丌;
    internal bool 上丘丂丌丑东上且丗;
    internal UnityEngine.Vector2 丅丅三与三七与丐上;
    internal float 丝丄世三丐丏与专丂;
    internal float 下丒上丞丐丂丏丑丕;
    internal float 丗丕丙丘丟与丒丗七;
    internal float 上不丑丁世丏丗丛与;
    public float speedCoefInjured;
    internal float 丗专丌三丘丟丄丆丞;
    internal float 丛万丑东丌万不丑世;
    internal float 万丟丗且专丁丟与丏;
    public BaseCamera playerCamera;
    internal float 上丝世丌丕万丈丒丕;
    internal float 万与丏丑世业丒丒丞;
    internal float 丑丌东丆世丁丟东丟;
    internal float 与丌丆下丝下丘丏丗;
    internal int 七三不三万丟与万丞;
    internal bool 一七不三丌专三丆一;
    internal PlayerBotController 业丌东七七丒世丞万;
    private UnityEngine.Vector2 丛丟丞丆丂三丈丄三;
    private bool 丘丄丐下丏丐丞丞丈;
    private bool 丝丝丟丝世且丆丞世;
    private bool 业不丟专业丁丏丄丗;
    private float 丟不七七七丟业专专;
    private UnityEngine.Vector3 世丂业专专丕丗丘丕;
    private float 三丙三且世下丆丅丆;
    private float accuracyChangeSpeed;
    private float 万丐丕丄业丗丛专丁;
    private float 丙丟下丒与上业专丘;
    private float 丌丌丄与丞丛世丙下;
    private float 三丒丁丒业丛丑丟业;
    private UnityEngine.Transform 丘丘丑东丆丞丄七业;
    private float batleRoyaleAdditionalLandingGravity;
    private bool 丆丒世丁七下一不丈;
    private float 丐东丁东一丙丈丘丐;
    private float 业丙专丒丕与世丄丄;
    private UnityEngine.Vector2 丗丈丂丐丁丟丙丝东;
    private float 丁丆丞万丂丌丐丑丕;
    private float 业丆东东丟丝万与下;
    private float 上且专下丈下丕七丄;
    private float <万丅丄丛上丕丝三上>k__BackingField;
    private float 丟三丂业丌丘丐丟世;
    private float 三丟丟丄丘丂七丆三;
    private float 丂丛万丑不上东不丛;
    private float 世七丂不丙一丆丝丌;
    private float 丕不专丞万一丏丄丟;
    private float 丝丌业丌上丞上七不;
    private float 世丌业丄丄丗丕上丆;
    private UnityEngine.Rect 丏上三下丛业丛丌下;
    private int 专不专丈丘专丘丟世;
    private bool 丑且丕丞上丂丙业七;
    private bool 丝丙七丒且丂丝与丏;
    private bool 丁丑丅丏丒不七上丁;
    private bool 丅三世万丕丄丗丑三;
    private float joystickDeadZone;
    internal float 不丄丒七业丏丙丕三;
    private bool 且丂丙丞丆七丌上世;
    private UnityEngine.Rect 丅丟丒一专上丒丌丌;
    private UnityEngine.Vector3 丙与丁且且七丒世不;
    private UnityEngine.Vector3 丙丛丞专丄丗三丂丄;
    private UnityEngine.Vector2 与不丌丒丂丆丒丒丟;
    private float 上世丈丗专丆东丙丂;
    private float 丞专三不不世丏丅丐;
    private UnityEngine.Vector3 丞丌丆丐丂与下丁万;
    private float 丅下东丛丈丞丟丘丞;
    private bool 东丁丑丙万七丌万丅;
    private int 丛丄世丑丐一丂不万;
    private int 丂与丑且万下丕丅丙;
    private float 丗七丘与丟万丆丛丁;
    private float 且丏丟世东丟下且丈;
    private int 专万且七丐丗丆丐丑;
    private float 丘丐丆丝丝丄丘丑丌;
    private UnityEngine.Vector3 丛下业专丂东丙世丝;
    private float royalePlayerSpeedFromJoystickModifier;
    private float runJoystickAngle;
    private float runJoystickAngleDeadZone;
    private bool 万丒丘丛世上丈丁东;
    private bool 七下丟丄丌业专万且;
    private float 丐一万丐东上与丟丑;
    private float 丄丁七丘丟上丞丞世;
    private float 丏丐丝丌丌丂七上专;
    private float 且万下丙丏不万丙丈;
    internal SniperScopeMovement 丂万业丟丑丅丈且丕;
    private SniperShotImpulse 丞丝丂丌丄丏丏上丘;
    public float speedCoefFlyOnGliderByJoystik;
    public float speedFlyDownOnGlider;
    public float speedFlyDown;
    public float speedCoefFlyByJoystik;
    public float speedCoefFlyDownInDine;
    private float 七且东丌丛丕丁丘丒;
    private float 七不东丘丐专且丐丛;
    private float 丆丕与丁且三丕丞世;
    private bool 七七七丗丕丒三丄一;
    internal float freePlayHeightDifferenceForFly;
    internal float freePlayMinHeightForFly;
    internal float freePlayMinHeightForGlide;
    internal float freePlayLandHeight;
    private float 丅下不丏丅丛世丗七;
    private float 一不万丈专丄七世丕;
    private float 丗丌不丁丁丁与丐与;
    private float 丕一下下七丒丂丘丁;
    private float 且丘丘丒丂与东丗且;
    private float 丁丅丅且丅专丑丑丐;
    private float 世丈丂丌一丅上世丛;
    private float 不丛丙且丑专丒东业;
    private float 丄丛东一三且业与丅;
    private float 不丒东业丙丘业下丁;
    private float 丘丑丗与丛丂丞丑丘;
    private float 与丐丕丐七丒上丈与;
    private float standingIdleTimeout;
    private bool 丙丞上三丝一丙丗丂;
    private UnityEngine.Vector3 丒上七丘且丕不七丙;
    private UnityEngine.Transform <丗专丟丑万丙与专丌>k__BackingField;
    private float 丙一三业丂丁专丛万;
    private float 万世丆丘不丏丐上丄;
    private float 三与丐丏东世丄丂丑;
    private float 丝与与丈不丆万且丛;
    private float 丈世丁丑不丄丗三丈;
    private float 丅丏丆下丞丟丏七丙;
    private float 与丗丑丟丅丌且万专;
    private System.Collections.Generic.List<UnityEngine.ParticleSystemRenderer> 丛丐世丟丆丙专丛一;
    private System.Collections.Generic.List<UnityEngine.ParticleSystemRenderer> 丄下丅不且丐专东丁;
    private UnityEngine.Vector3 丏丄业丆业丅且丏丗;
    private float 丅丗下东且万丌丈丞;
    private float 不万丈丙丏且万丁七;
    private float 丌丑丟三上丅丝上丑;
    private float 三丅丙丕东丂丘世不;
    private UnityEngine.Transform weaponPoint;
    private float weaponsFeedbackForceSens;
    private TweenPosition camTweenerJump;
    private TweenPosition camTweenerLanding;
    private TweenPosition weaponTweenerJump;
    private TweenPosition weaponTweenerLanding;
    private TweenRotation camTweenerFallDamage;
    private float jumpEffectDuration;
    private float landingEffectDuration;
    private float jumpCamEffectWeapon;
    private float jumpCamEffectMech;
    private bool 万丗与与丘丗丑丁丈;
    internal bool 丕不丛丕丛丘丙丑丂;
    private float 丕丘专三丘丗下丌丗;
    private bool <丒丟丄下丙丐丏东七>k__BackingField;
    private UnityEngine.Vector2 丙丁丂上三三丌与丕;
    private bool 丕丅业东丞且三丁不;
    private bool 不七丏丒丑且丕丂业;
    private bool <丒丆与丒丘与丒业与>k__BackingField;
    private bool <与丝丁不且东丘丙丞>k__BackingField;
    private bool <丂丑丅丂不丂丕丏丂>k__BackingField;
    private 丟东世三丁丏丛下丆[] 三万丟丁万丄一三丛;
    private int 专丕上万丒丗丕与业;
    internal bool 下丝丝丈世丟丘丄专;
    internal bool 且丈丟丏专业丕丗丆;
    private float 且与丒丏东万丂业下;
    private float 丑丒丞丒丟丕丁一一;
    private float 七丏与下且与丏丏丛;
    private float 三丛三丞上丐丝七丛;
    private float weaponFollowLagSensitive;
    private float maxWeaponFollowLag;
    private float weaponFollowLagSpped;
    private bool 丛丕世丛东丞丗丈上;
    private bool 丏不丞丐与丅丂与丒;
    public bool cableCarMoving;
    public CableCar currentCableCar;
    private float 丞丐丒丁丌丘丄下丄;
    private bool 下不丁丗丑丈丌东东;
    private float 丆不丟丕万丑且丘丏;
    private UnityEngine.Coroutine 世丅万一丟丆东业丏;
    internal bool 丏丛丞丗丈七丏丈七;
    private UnityEngine.Vector3 丄丘丘丗丅丅不万一;
    private float 三丐上不丐专世与丝;
    internal float velocityDownFallMultiplier;
    internal float jumpUpMultiplier;
    private float secondJumpUpMultiplierAfterImpact;
    internal float maxNegativeVelocityYPerFrame;
    internal float maxPositiveVelocityYPerFrame;
    private UnityEngine.Vector3 下丒万丌丆丞一丄丅;
    private UnityEngine.Vector3 七丑丄丅丂丒一世专;
    private bool 且丌丐丝业丅丘丛丙;
    private bool 丑下丟丑丅专不丐不;
    private bool 丙丞三丆丁业丘丑业;
    internal static readonly float 三丏丅丐丏与下世丗;
    private float jetpackUsingDurationModifier;
    private float 东丂七丕万丞丞丒丄;
    internal bool 七丞三丑丈一东丑丙;
    private bool 七丏丙丌丒一七丂丆;
    private const float 丗世与丞丘丙丕丅丅 = 0.3333;
    private const float 丌不与丐万丌丐一专 = 0.6666;
    private const float 与七丌一丁下丆一东 = 0.3;
    private const float 丞丐且丁不丆上业丈 = 0.6;
    private const float 丄专业丙丄丂丒下丏 = 0.2;
    private const float 丅丘三不上丅世丒丕 = 0.7;
    private const float 丞丁丟七万丝丞上丙 = 0.3;
    private const float 丐丂丄丅丐七上丄与 = 0.6;
    private static string 丙业万一丅丝丅七业;
    private static string 下丁丑丐与丗世上不;
    private static string 丏世丑丘丑丕一丟且;
    private static string 一三世上丞丈丘丝丞;
    private static string 万丄专丒丆下一丌万;
    private static string 七下丌不丂丑丁三丝;
    private const float 且丝不世丞世丅丌丗 = 1.45;
    private static float 与上丒丛三万丌万上;
    private static 丑业丗三丘丟丑上丈.丙丟与丐三丐万万丆 世丟丑丗上万与专且;
    private static bool 上丒丂丑丙一丗丅丞;
    private static bool 丂七与丅丟丁且丁万;
    internal static bool 丟丆丒三不且丐丕丑;
    private static float 丏丕一丟丑世丕丙丁;
    internal static bool 专丗丏且丕丏世专与;
    private static bool 丗丞丂丘丂世丐丑丒;
    private static bool 三七丁丕丁万万三不;
    private float gliderMinigameSpeed;
    private float gliderMinigameSpeedChange;
    private float gliderStartRotationXMinigame;
    private UnityEngine.Vector2 gliderMaxRotationMinigame;
    private float gliderRotationTimeMinigame;
    private UnityEngine.Vector2 moveRotationGliderMinigame;
    private float camRotationYOnMovementMultiplierGliderMinigame;
    private float camRotationZOnMovementMultiplierGliderMinigame;
    private float camFovGliderMinigame;
    private float camFovChangeGliderMinigame;
    private float enviromentEffectsLerpSpeedGlider;
    internal UnityEngine.Transform camPivotGliderMiniGame;
    private float gliderSlowdownPenaltyValue;
    private float gliderSlowdownPenaltySpeed;
    private float gliderSlowdownPenaltyTime;
    private float 丆不丑专丛丈世丁丘;
    private float 下丟丆丅丅丅丅不丒;
    private float 三丟丛丌一丐丂丆一;
    
    // Properties
    internal FirstPersonControlSharp.万丙专丟丆专东丟丕 丒七不丂万万丒丞丂 { get; set; }
    internal UnityEngine.Transform 丙与不不丞丑丁一丈 { get; }
    internal bool 丁丒不与业三丅丗万 { get; }
    internal bool 丝丕下丛丞丝下丘上 { get; }
    private bool 丞丏丄与七丁且丈丒 { get; }
    internal float 丝丗丏丟丈丕丐专七 { get; set; }
    internal UnityEngine.Vector3 下丞丟丄丛丁丁丏丙 { get; }
    internal bool 专业丂丅世丁丆丟七 { get; }
    internal bool 丝丞丄丌丂丅丕下丝 { get; }
    internal UnityEngine.Transform 万一丂丐丄丁上与丟 { get; set; }
    public float 世万丘专丁丟丛丒丞 { get; set; }
    internal bool 丅一丘专丕七丈丅且 { get; set; }
    internal bool 业下七丌丁东丟丟丛 { get; }
    internal bool 下且丗丐丙万不与不 { get; }
    internal bool 东丑丌丄丝世丞丘三 { get; }
    internal bool 万一丝下业七丞上七 { get; }
    internal bool 丈丑一且不丒一丝丘 { get; }
    internal bool 丙丌丅丆丅世世七丛 { get; }
    internal bool 世不上丅三丛丒丌丌 { get; }
    internal float 丄丛上专丝不不丁专 { get; }
    internal float 丁一丄丐丏七丗世东 { get; }
    private bool 上世丈丘丌万七万丄 { get; set; }
    internal UnityEngine.Vector2 丝万丈且丙丅丟业七 { get; set; }
    private bool 专丗下丘丈与丑丕万 { get; set; }
    internal bool 七世丂与丏下东下丝 { get; }
    internal bool 一丅丑丙丄不丟丂丁 { get; set; }
    internal bool 业丈世丌丝世丛丙上 { get; set; }
    internal bool 丛万丛丘丂三一丈丏 { get; set; }
    internal bool 丌与七上丙且专且丝 { get; }
    internal bool 丛七专丘丘丌丌丗丏 { get; set; }
    internal bool 丒丝丝丙七世三与万 { get; }
    internal bool 不丙丞丟专丗丝一丐 { get; }
    internal bool 丗丏丌丙丈丌丛丄丛 { get; }
    internal bool 丐丐丙丆丝世且专丏 { get; }
    internal bool 且业三丙丒东丝丟丆 { get; }
    private static bool 丘丏上丞丑不专丄丈 { get; }
    public static bool 丞丁丟且丈下丘下业 { get; }
    
    // Methods
    internal FirstPersonControlSharp.万丙专丟丆专东丟丕 丗丗世三丛万丆丞丗()
    {
        return (万丙专丟丆专东丟丕)this.<且丂一与且丐丕丗丈>k__BackingField;
    }
    private void 丒丂丟下丝万不丞不(FirstPersonControlSharp.万丙专丟丆专东丟丕 丙业与丙丗丝不丈东)
    {
        this.<且丂一与且丐丕丗丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Transform 丟不丂丕业与七专三()
    {
        if(this.firstPersonCamera != null)
        {
                return this.firstPersonCamera.transform;
        }
        
        return this.firstPersonCamera.transform;
    }
    internal bool 丂丕丁且世丗丕丛专()
    {
        return (bool)((this.<且丂一与且丐丕丗丈>k__BackingField) == 1) ? 1 : 0;
    }
    internal bool 丘丂三东丁且丙世七()
    {
        return (bool)((this.<且丂一与且丐丕丗丈>k__BackingField) == 2) ? 1 : 0;
    }
    private void 丁东下丁三丏丈丁业(bool 丝三丄专丗丞丄丄丌)
    {
        丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
        this._moveC.playerHeadRenderer.enabled = 丝三丄专丗丞丄丄丌;
        this._moveC.playerBodyRenderer.enabled = 丝三丄专丗丞丄丄丌;
        this._moveC.playerLegsRenderer.enabled = 丝三丄专丗丞丄丄丌;
        this.丞丗丄丂丆业丈丑业.hatsPoint.SetActive(value:  丝三丄专丗丞丄丄丌);
        this.丞丗丄丂丆业丈丑业.capesPoint.SetActive(value:  丝三丄专丗丞丄丄丌);
        this.丞丗丄丂丆业丈丑业.LeftBootPoint.SetActive(value:  丝三丄专丗丞丄丄丌);
        this.丞丗丄丂丆业丈丑业.RightBootPoint.SetActive(value:  丝三丄专丗丞丄丄丌);
        this.丞丗丄丂丆业丈丑业.maskPoint.SetActive(value:  丝三丄专丗丞丄丄丌);
    }
    internal void 上且丈丒与专上丝业(FirstPersonControlSharp.万丙专丟丆专东丟丕 丆丝下丒上一丙丄丞)
    {
        万丙专丟丆专东丟丕 val_4 = 丆丝下丒上一丙丄丞;
        if((val_4 == 1) && ((this.<与丝丁不且东丘丙丞>k__BackingField) != false))
        {
                if((this._moveC.万丝一万丐且丌业丛 != true) && (this._moveC.东丑丌丄丝世丞丘三 != true))
        {
                if(this.丝丝丟丝世且丆丞世 == false)
        {
            goto label_17;
        }
        
        }
        
            val_4 = 2;
        }
        
        label_17:
        if((this.<且丂一与且丐丕丗丈>k__BackingField) != val_4)
        {
            goto label_8;
        }
        
        if(this.丅业上丙丗丂东与一 != null)
        {
            goto label_9;
        }
        
        return;
        label_8:
        if(this.丅业上丙丗丂东与一 == null)
        {
            goto label_11;
        }
        
        label_9:
        this.StopCoroutine(routine:  this.丅业上丙丗丂东与一);
        label_11:
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.丅业上丙丗丂东与一 = this.StartCoroutine(routine:  this.七丑万丏丝丒丏丐业(丆丝下丒上一丙丄丞:  val_4).GetEnumerator());
    }
    private System.Collections.IEnumerable 七丑万丏丝丒丏丐业(FirstPersonControlSharp.万丙专丟丆专东丟丕 丆丝下丒上一丙丄丞)
    {
        FirstPersonControlSharp.丙三丙世丁上下丝上 val_1 = new FirstPersonControlSharp.丙三丙世丁上下丝上(丗丏丅丕丆世丁专丟:  -2);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .万且丅七丏且丑丞丒 = 丆丝下丒上一丙丄丞;
        return (System.Collections.IEnumerable)val_1;
    }
    internal void 丅专丟上丗且丈丛上(BaseCamera.万丙专丟丆专东丟丕 丆丝下丒上一丙丄丞)
    {
        ThirdPersonCamera val_10;
        UnityEngine.Transform val_11;
        UnityEngine.Transform val_12;
        var val_13;
        val_10 = this;
        val_11 = this.thirdCameraPivodInBattleRoyale;
        val_12 = this.丞丗丄丂丆业丈丑业.headObj.transform;
        if((UnityEngine.Object.op_Implicit(exists:  this.且丛丈丂丒丟丘丅丄)) != false)
        {
                this.且丛丈丂丒丟丘丅丄.丑七且丞丌东一丗丙 = 0f;
        }
        
        if(丆丝下丒上一丙丄丞 == 3)
        {
            goto label_10;
        }
        
        if(丆丝下丒上一丙丄丞 == 7)
        {
            goto label_11;
        }
        
        if(丆丝下丒上一丙丄丞 != 6)
        {
            goto label_12;
        }
        
        BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
        val_11 = val_3.shutle;
        BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
        val_12 = val_4.shutle;
        this.世丟丈丏丕万丝丆万.enabled = false;
        goto label_39;
        label_10:
        if(this.丌专丒丒丛丐丘上丄 == null)
        {
            goto label_19;
        }
        
        val_13 = val_12;
        if(val_12 != null)
        {
            goto label_39;
        }
        
        if(val_13 == null)
        {
            goto label_23;
        }
        
        goto label_39;
        label_12:
        if((丆丝下丒上一丙丄丞 != 4) || (this.playerCamera.东丅东专不三丆上七 != 7))
        {
            goto label_27;
        }
        
        label_11:
        val_11 = this.丞丗丄丂丆业丈丑业.headObj.transform;
        UnityEngine.Transform val_6 = this.丞丗丄丂丆业丈丑业.headObj.transform;
        goto label_32;
        label_27:
        if(丆丝下丒上一丙丄丞 != 8)
        {
            goto label_39;
        }
        
        val_11 = this._moveC.丑丝丂丗丝丛与不七.tpsCamPivot;
        val_12 = this._moveC.丑丝丂丗丝丛与不七.tpsCamVisualPivot;
        goto label_39;
        label_19:
        val_11 = this.丌专丒丒丛丐丘上丄.transform;
        label_32:
        val_12 = this.丌专丒丒丛丐丘上丄.transform;
        label_39:
        if(丆丝下丒上一丙丄丞 != 3)
        {
                return;
        }
        
        if(this.丌专丒丒丛丐丘上丄 == null)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.且丛丈丂丒丟丘丅丄)) == false)
        {
                return;
        }
        
        mem2[0] = 1103626240;
        val_10 = this.且丛丈丂丒丟丘丅丄;
        this.且丛丈丂丒丟丘丅丄.丑七且丞丌东一丗丙 = 20f;
        return;
        label_23:
    }
    private bool 丗丄丑丙丛与丂丝与()
    {
        return (bool)(this.丝三丟且三三与且世 > 0) ? 1 : 0;
    }
    internal float 丁丅且七丝丆不万丐()
    {
        return (float)this.<万丅丄丛上丕丝三上>k__BackingField;
    }
    private void 下丝一丒上丙丂丝丅(float 丙业与丙丗丝不丈东)
    {
        this.<万丅丄丛上丕丝三上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Vector3 丞业不不与与世丞上()
    {
        return new UnityEngine.Vector3() {x = this.七丑丄丅丂丒一世专};
    }
    internal bool 丐丁丂丛万丂丒下不()
    {
        return (bool)(this.丞丗丄丂丆业丈丑业.playerAnimation.丕专丅东下丙丙丌万() > 0f) ? 1 : 0;
    }
    internal bool 下三业三丌世丆丂丏()
    {
        var val_3;
        var val_4;
        val_3 = this.丞丗丄丂丆业丈丑业.playerAnimation.丕专丅东下丙丙丌万();
        if(System.Math.Abs(val_3) <= 0.1f)
        {
                var val_2 = (System.Math.Abs(val_3) > 0.1f) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 1;
        return (bool)val_4;
    }
    internal UnityEngine.Transform 丗且丙丄七东丟丝下()
    {
        return (UnityEngine.Transform)this.<丗专丟丑万丙与专丌>k__BackingField;
    }
    private void 丄世丐与丒丆丒下专(UnityEngine.Transform 丙业与丙丗丝不丈东)
    {
        this.<丗专丟丑万丙与专丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public float get_MoveSpeedMultiplier()
    {
        return (float)this.丕丘专三丘丗下丌丗;
    }
    public void set_MoveSpeedMultiplier(float 丙业与丙丗丝不丈东)
    {
        this.丕丘专三丘丗下丌丗 = 丙业与丙丗丝不丈东;
    }
    internal bool 万丘丏丐且丝一上丏()
    {
        return (bool)this.<丒丟丄下丙丐丏东七>k__BackingField;
    }
    private void 万丂丗七丅丗丘东丂(bool 丙业与丙丗丝不丈东)
    {
        this.<丒丟丄下丙丐丏东七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丈业丆丌万丛丌丌丄()
    {
        ImpactReceiver val_1 = this._moveC.丙世丞丈丁丝丙丌丞();
        if(val_1 != null)
        {
                return val_1.丈业丆丌万丛丌丌丄();
        }
        
        return val_1.丈业丆丌万丛丌丌丄();
    }
    internal bool 丒七下丁丛不丄丅一()
    {
        var val_6;
        if(this.世丟丈丏丕万丝丆万.isGrounded != true)
        {
                if(this._moveC.与丏下丝万上三丛不() != true)
        {
                if(this.cableCarMoving == false)
        {
            goto label_6;
        }
        
        }
        
        }
        
        if(this.丆丒世丁七下一不丈 == false)
        {
            goto label_6;
        }
        
        label_15:
        val_6 = 1;
        return (bool)(this.七丞三丑丈一东丑丙 == true) ? 1 : 0;
        label_6:
        if(丘丐丘万丌丟丞下丝.三丆丈丗丘丒丅下万() == false)
        {
                return (bool)(this.七丞三丑丈一东丑丙 == true) ? 1 : 0;
        }
        
        if(this.一丙专丄丗东丟丞丂 != false)
        {
                return (bool)(this.七丞三丑丈一东丑丙 == true) ? 1 : 0;
        }
        
        if(this.万丒丘丛世上丈丁东 == false)
        {
                return (bool)(this.七丞三丑丈一东丑丙 == true) ? 1 : 0;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_15;
        }
        
        return (bool)(this.七丞三丑丈一东丑丙 == true) ? 1 : 0;
    }
    internal bool 不丕与下丄丟丕丄丛()
    {
        var val_2;
        if(this._moveC.东丑丌丄丝世丞丘三 == false)
        {
                return (bool)(this.丝丝丟丝世且丆丞世 == true) ? 1 : 0;
        }
        
        val_2 = 1;
        return (bool)(this.丝丝丟丝世且丆丞世 == true) ? 1 : 0;
    }
    internal bool 丏世丂丁丞业丗丐下()
    {
        return (bool)(this.丙一三业丂丁专丛万 <= 0f) ? 1 : 0;
    }
    internal bool 且东丞东丑丗下与丝()
    {
        float val_2 = this.丘丑丗与丛丂丞丑丘;
        val_2 = val_2 + 0.1f;
        return (bool)(this.不丒东业丙丘业下丁 > val_2) ? 1 : 0;
    }
    internal bool 东丌丏丗丁丟丘不丆()
    {
        if(this._moveC != null)
        {
                return (bool)this._moveC.丙丌丅丆丅世世七丛;
        }
        
        return (bool)this._moveC.丙丌丅丆丅世世七丛;
    }
    internal bool 下上且丏世丈丞丏东()
    {
        if(this._moveC != null)
        {
                return this._moveC.与丏下丝万上三丛不();
        }
        
        return this._moveC.与丏下丝万上三丛不();
    }
    internal float 七丞丗丙且上三丁世()
    {
        float val_1 = 90f;
        val_1 = val_1 - this.runJoystickAngle;
        val_1 = val_1 * 0.01745329f;
    }
    internal float 丕丛丆丙上丈上丁丌()
    {
        float val_1 = 90f;
        val_1 = val_1 - this.runJoystickAngleDeadZone;
        val_1 = val_1 * 0.01745329f;
    }
    private bool 与丅世不丂七七三丏()
    {
        return (bool)this.丝丝丟丝世且丆丞世;
    }
    private void 丞不丈世东丞且世丕(bool 丙业与丙丗丝不丈东)
    {
        var val_3;
        this.丝丝丟丝世且丆丞世 = 丙业与丙丗丝不丈东;
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.丞丗丄丂丆业丈丑业.armsRoot.SetActive(value:  丙业与丙丗丝不丈东);
        val_3 = null;
        val_3 = null;
        typeof(Player_move_c).__il2cppRuntimeField_5D8.SetActive(value:  (~丙业与丙丗丝不丈东) & 1);
    }
    internal UnityEngine.Vector2 丁丕下丛专丏丅丂专()
    {
        return new UnityEngine.Vector2() {x = this.丙丁丂上三三丌与丕};
    }
    internal void 丂万丟丑丅丕世丙且(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        this.丙丁丂上三三丌与丕 = 丙业与丙丗丝不丈东;
        mem[1152921540404274136] = 丙业与丙丗丝不丈东.y;
    }
    private bool 丘丈三且万丗丘丗三()
    {
        null = null;
        return (bool)与丂丏丛丞丞丒丟丄.世丂丁丟世丄丕丆丄;
    }
    private void 且不一且丗东丁丕丙(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        与丂丏丛丞丞丒丟丄.世丂丁丟世丄丕丆丄 = 丙业与丙丗丝不丈东;
    }
    internal bool 丘东一丟丝丙丄丏与()
    {
        var val_11;
        var val_12;
        var val_13;
        if(this._moveC.丙不丅丕三丂业东丕() == 0)
        {
                return false;
        }
        
        WeaponSounds val_3 = this._moveC.丙不丅丕三丂业东丕();
        if(val_3.categoryNabor != 5)
        {
                return false;
        }
        
        WeaponSounds val_4 = this._moveC.丙不丅丕三丂业东丕();
        val_11 = null;
        val_11 = null;
        if((System.String.op_Equality(a:  val_4.Tag, b:  与世丁丙且丑下丌不.丅丈且丗丅一与丘丐)) != true)
        {
                WeaponSounds val_6 = this._moveC.丙不丅丕三丂业东丕();
            val_12 = null;
            val_12 = null;
            if((System.String.op_Equality(a:  val_6.Tag, b:  与世丁丙且丑下丌不.丈万上一丝上上业丁)) != true)
        {
                WeaponSounds val_8 = this._moveC.丙不丅丕三丂业东丕();
            val_13 = null;
            val_13 = null;
            if((System.String.op_Equality(a:  val_8.Tag, b:  与世丁丙且丑下丌不.东下丁丒业丝下世且)) == false)
        {
                return false;
        }
        
        }
        
        }
        
        if(this._moveC.丗丞业丐丛三上丄丕() == false)
        {
                return false;
        }
        
        if(this._moveC != null)
        {
                return this._moveC.且丂一丁丆丒与丁业();
        }
        
        return this._moveC.且丂一丁丆丒与丁业();
    }
    internal bool 丛业七丆万丕一丟丏()
    {
        return (bool)this.<丒丆与丒丘与丒业与>k__BackingField;
    }
    private void 下丒丝东丛一丟丗专(bool 丙业与丙丗丝不丈东)
    {
        this.<丒丆与丒丘与丒业与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丌丙丁丝七丕丐上丛()
    {
        return (bool)this.<与丝丁不且东丘丙丞>k__BackingField;
    }
    private void 万丏丂丌不丆丞丛下(bool 丙业与丙丗丝不丈东)
    {
        this.<与丝丁不且东丘丙丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 不一一丕丘丆且丈下()
    {
        return (bool)this.<丂丑丅丂不丂丕丏丂>k__BackingField;
    }
    internal void 丐丞专业丈不丕丝丟(bool 丙业与丙丗丝不丈东)
    {
        this.<丂丑丅丂不丂丕丏丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void 丗丙东专世万丌丝丛(UnityEngine.Vector3 业丘丆丟下一丛丅丒, float 且丝丒丈丐东丛丝丞, PlayerAnimationWrapper.丂专丅一业东丘东丈 专丞丅业丆丐丕不七)
    {
        if(this.dustParticle == 0)
        {
                return;
        }
        
        if((this.<且丂一与且丐丕丗丈>k__BackingField) == 2)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            if((double)业丘丆丟下一丛丅丒.y < 0)
        {
                if((this.丒上七丘且丕不七丙 & 1) == 0)
        {
            goto label_8;
        }
        
        }
        
            if((专丞丅业丆丐丕不七 <= 1) && (this.丘丑丗与丛丂丞丑丘 < 0))
        {
                label_8:
            if((this.下上且丏世丈丞丏东() != true) && ((double)this.与丌丆下丝下丘丏丗 < 0))
        {
                if(this.丅丁丝丞丄丏三丌三 == false)
        {
            goto label_18;
        }
        
        }
        
        }
        
        }
        
        label_18:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dustParticle, 丏业丟一东丂东丘丛:  false);
    }
    internal void 下丝丁一不丑专丆丝(bool 丑丒业丘丑东丕世丅)
    {
        SkinName val_6 = this.丞丗丄丂丆业丈丑业;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = this._moveC;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = this._moveC.丆丐不丈七七不业丒;
        if(val_6 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丞丗丄丂丆业丈丑业.armsRoot, 丏业丟一东丂东丘丛:  丑丒业丘丑东丕世丅);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._moveC.丆丐不丈七七不业丒, 丏业丟一东丂东丘丛:  (~丑丒业丘丑东丕世丅) & 1);
    }
    internal void 丈下丘万丙丌且丄且()
    {
        bool val_4 = this.丛丗丑丝丕丌七与丆;
        val_4 = val_4 ^ 1;
        this.丛丗丑丝丕丌七与丆 = val_4;
        UnityEngine.Debug.Log(message:  "flyOnGlider ="("flyOnGlider =") + this.丛丗丑丝丕丌七与丆.ToString());
        this.业丌上丙不丕丝丂丒(丗丛不丕且与世丏丑:  true);
        this.丞丗丄丂丆业丈丑业.playerMoveC.丏丌丑丅七丗丘一丅(丛丗丑丝丕丌七与丆:  (this.丛丗丑丝丕丌七与丆 == true) ? 1 : 0, 专丞上七七且丝七丗:  0);
    }
    internal void 丅丏丒三上东丏一专(TransportControllerBase 不下业丞丌世专且丈, int 丝一东丄丕丁不一丕)
    {
        UnityEngine.Object val_25;
        var val_26;
        var val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_31;
        var val_32;
        float val_33;
        var val_34;
        float val_35;
        val_25 = 不下业丞丌世专且丈;
        val_26 = this;
        if(this.下丅丂丘丏丟世且丐 == true)
        {
                return;
        }
        
        val_27 = 1152921504848912384;
        if(val_25 == 0)
        {
                return;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(this.丞丗丄丂丆业丈丑业.playerMoveC.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.东丑丌丄丝世丞丘三 == true)
        {
                return;
        }
        
        if(this._moveC.东丗丒丝丐且丞丄丏 == true)
        {
                return;
        }
        
        if(this.丐丂丕丂丑三丑丒一 != false)
        {
                this.丌丛丄丗丂丙丛七丄();
        }
        
        this.丌专丒丒丛丐丘上丄 = val_25;
        if(不下业丞丌世专且丈.minVelocityHitPlayer == 0)
        {
                this.<丗专丟丑万丙与专丌>k__BackingField.parent = this.丌专丒丒丛丐丘上丄;
        }
        
        this.<丗专丟丑万丙与专丌>k__BackingField.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        val_28 = val_3.x;
        val_29 = val_3.y;
        val_30 = val_3.z;
        this.<丗专丟丑万丙与专丌>k__BackingField.localRotation = new UnityEngine.Quaternion() {x = val_28, y = val_29, z = val_30, w = val_3.w};
        val_25 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        if((this.丌专丒丒丛丐丘上丄 & 1) != 0)
        {
                this.丞丗丄丂丆业丈丑业.armsRoot.SetActive(value:  true);
            if(this.丞丗丄丂丆业丈丑业.playerMoveC.丆丐不丈七七不业丒 != 0)
        {
                this.丞丗丄丂丆业丈丑业.playerMoveC.丆丐不丈七七不业丒.SetActive(value:  false);
        }
        
        }
        
        this.下丅丂丘丏丟世且丐 = true;
        if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_110;
        }
        
        if(this._moveC != 0)
        {
                this._moveC.丏丈丈一丌丐丒丟丕(丕与不不万与丄与丟:  false);
            this._moveC.丕丛丗丝专下丑丐丘(丏丛丆丙专丘上丄东:  0);
        }
        
        this.世丟丈丏丕万丝丆万.enabled = false;
        val_27 = 1152921505253916672;
        string val_6 = 丛且丗丌丏下七下丈.丗丘丌丘七丏丝下七();
        if((this.丌专丒丒丛丐丘上丄 & 1) == 0)
        {
            goto label_51;
        }
        
        val_31 = 0;
        goto label_52;
        label_59:
        TransportControllerBase.__il2cppRuntimeField_byval_arg.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "MyPlayer");
        val_31 = 1;
        label_52:
        if(val_31 < null)
        {
            goto label_59;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  InGameGUI.丙丞专丌丁丞与不丐.aimCrosshair, 丏业丟一东丂东丘丛:  false);
        丒七丌七丘东业丟丅();
        丒七丌七丘东业丟丅();
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                if(this.丌专丒丒丛丐丘上丄 != null)
        {
                this.丌专丒丒丛丐丘上丄.SetVehicleParams(丏丆丕丏丘业东万下:  val_6, 丌丐丟丟丆丁丌丌丝:  丛且丗丌丏下七下丈.丑丈业上万一丁丛丂(七丙丈丆丕丄丐业丟:  val_6), 下万下丌且丙七丝丆:  false);
        }
        
            if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_32 = null;
            val_32 = null;
            val_33 = VehicleController.recoverCarAfterDisconnect;
            if(val_33 > 0f)
        {
                val_33 = VehicleController.recoverCarAfterDisconnect;
            val_34 = val_33;
        }
        
        }
        
        }
        
        if((System.String.op_Inequality(a:  val_6, b:  "royale_car_basic")) != false)
        {
                bool val_12 = GameConnect.丝丆世丕丂丄万东且();
        }
        
        this.上且丈丒与专上丝业(丆丝下丒上一丙丄丞:  2);
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  this.丌专丒丒丛丐丘上丄);
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  3);
        val_25 = this.丌专丒丒丛丐丘上丄.transform;
        UnityEngine.Quaternion val_15 = val_25.rotation;
        if((this.<与丝丁不且东丘丙丞>k__BackingField) == false)
        {
            goto label_99;
        }
        
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_15.y, y:  20f);
        val_35 = val_16.x;
        val_29 = val_16.y;
        val_30 = 0f;
        goto label_101;
        label_51:
        if((this.<与丝丁不且东丘丙丞>k__BackingField) != false)
        {
                this.上且丈丒与专上丝业(丆丝下丒上一丙丄丞:  2);
            UnityEngine.Quaternion val_18 = this.丌专丒丒丛丐丘上丄.transform.rotation;
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_18.y, y:  20f);
            val_35 = val_19.x;
            val_29 = val_19.y;
            val_30 = 0f;
        }
        
        val_25 = this.丌专丒丒丛丐丘上丄;
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  val_25);
        goto label_110;
        label_99:
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_15.y, y:  0f);
        val_35 = val_21.x;
        val_29 = val_21.y;
        val_30 = 0f;
        label_101:
        label_110:
        val_26 = this._moveC.fpsPlayerBody.transform;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        val_26.localRotation = new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w};
    }
    internal void 专业上七丏三丟且丆()
    {
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        this.丟丑丌丆丕丒丞三丏(丝一东丄丕丁不一丕:  0);
    }
    internal void 丟丑丌丆丕丒丞三丏(int 丝一东丄丕丁不一丕 = -1)
    {
        TransportControllerBase val_3;
        int val_4;
        var val_5;
        var val_6;
        val_4 = 丝一东丄丕丁不一丕;
        if(this.丛世下丝业丞丐丅丅 == true)
        {
                return;
        }
        
        if(this.下丅丂丘丏丟世且丐 == true)
        {
                return;
        }
        
        val_3 = this.丌专丒丒丛丐丘上丄;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        val_3 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.东丑丌丄丝世丞丘三 != false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(JoystickController.丘万丏三丏丑世丐丏 != null)
        {
                if((JoystickController.丘万丏三丏丑世丐丏.carTouch & 1) == 0)
        {
                return;
        }
        
        }
        
        if(val_4 == 1)
        {
                UnityEngine.Vector3 val_2 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
            val_4 = this.丌专丒丒丛丐丘上丄;
            if(val_4 == 1)
        {
                return;
        }
        
        }
        
        this.专丕上万丒丗丕与业 = val_4;
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丄丁丑丞丅一三丌丆 != false)
        {
                this.丞丗丄丂丆业丈丑业.playerMoveC.专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        }
        
        val_6 = null;
        val_6 = null;
        if(JoystickController.丗三丄与丂丟丌专东 != null)
        {
                JoystickController.丗三丄与丂丟丌专东.且丑一丄下三东七专();
        }
        
        this.丛世下丝业丞丐丅丅 = true;
        if(this.丌专丒丒丛丐丘上丄 == null)
        {
            
        }
    
    }
    internal void 世丁万三丂与丂下三()
    {
        if(this.丌专丒丒丛丐丘上丄 == 1)
        {
                return;
        }
        
        this.丟丑丌丆丕丒丞三丏(丝一东丄丕丁不一丕:  this.丌专丒丒丛丐丘上丄);
    }
    internal void 丏丞丙丒丗与且丗丕(bool 东三丈下丌丑丂世丛 = True)
    {
        UnityEngine.GameObject val_13;
        BaseCamera val_14;
        float val_17;
        float val_18;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        val_14 = this;
        if(this.下丅丂丘丏丟世且丐 == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        val_17 = val_1.x;
        val_18 = val_1.z;
        this.<丗专丟丑万丙与专丌>k__BackingField.parent = 0;
        this.下丅丂丘丏丟世且丐 = false;
        if(this.丌且下丕下下丌万丞 != false)
        {
                if(this._moveC.丘七业丒丐世丂丅丒() <= 0f)
        {
                if(this._moveC.丐下丘丟丁丆丟丆丈() <= 0f)
        {
            goto label_8;
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_20 = val_4.x;
        val_21 = val_4.y;
        val_22 = val_4.z;
        this._moveC.myPlayerTransform.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        label_8:
        this.丞丗丄丂丆业丈丑业.armsRoot.SetActive(value:  false);
        val_13 = this.丞丗丄丂丆业丈丑业.playerMoveC.丆丐不丈七七不业丒;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                val_13 = this.丌专丒丒丛丐丘上丄;
            if((val_13 & 1) != 0)
        {
                val_13 = this.丞丗丄丂丆业丈丑业.playerMoveC;
            val_21 = 0f;
            val_22 = 0f;
            val_23 = 0f;
            val_20 = val_20;
            val_13.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  val_20, 丗东丏与上丆丌不且:  1, 与丘丂下丘丁丅与东:  0, 丞丂丂丁丝丄万一丞:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, 丝三丛且丘不丌丙下:  "", 丞丗且下世丐业丌丙:  0);
        }
        
        }
        
        if(东三丈下丌丑丂世丛 != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_31;
        }
        
        }
        
        val_24 = 0;
        goto label_32;
        label_39:
        TransportControllerBase.__il2cppRuntimeField_byval_arg.layer = 0;
        val_24 = 1;
        label_32:
        if(val_24 < null)
        {
            goto label_39;
        }
        
        val_13 = this.丌专丒丒丛丐丘上丄;
        this.<丗专丟丑万丙与专丌>k__BackingField.position = new UnityEngine.Vector3() {x = val_17, y = val_1.y, z = val_18};
        UnityEngine.Quaternion val_7 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_17 = val_8.x;
        val_18 = val_8.z;
        val_20 = val_17;
        val_21 = val_8.y;
        val_22 = val_18;
        val_23 = val_8.w;
        this.<丗专丟丑万丙与专丌>k__BackingField.rotation = new UnityEngine.Quaternion() {x = val_20, y = val_21, z = val_22, w = val_23};
        label_31:
        this.世丟丈丏丕万丝丆万.enabled = true;
        if(this.丌专丒丒丛丐丘上丄 != null)
        {
                三丅丟三丑七上丂不 val_9 = null;
            val_20 = 0f;
            val_21 = 0f;
            val_13 = val_9;
            val_9 = new 三丅丟三丑七上丂不(丁东丂丅业上丁丙丕:  val_20, 丝丞世且下丁三世三:  val_21);
        }
        
        this.丌专丒丒丛丐丘上丄 = 0;
        if((this._moveC.东丑丌丄丝世丞丘三 != true) && (this._moveC.万丝一万丐且丌业丛 != true))
        {
                val_13 = 1152921505219145728;
            丒七丌七丘东业丟丅();
            丒七丌七丘东业丟丅();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  InGameGUI.丙丞专丌丁丞与不丐.aimCrosshair, 丏业丟一东丂东丘丛:  true);
        }
        
        if((this.<与丝丁不且东丘丙丞>k__BackingField) != false)
        {
                this.上且丈丒与专上丝业(丆丝下丒上一丙丄丞:  1);
        }
        
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  2);
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  0);
        val_14 = this.playerCamera;
        UnityEngine.Quaternion val_11 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11.y, y:  0f);
    }
    internal void 世丏丏东丌七与东丁(bool 丘上丅丝丄三一丕丁 = False)
    {
        if(this.丛世下丝业丞丐丅丅 != false)
        {
                return;
        }
        
        if(this.下丅丂丘丏丟世且丐 == false)
        {
                return;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丄丁丑丞丅一三丌丆 != false)
        {
                this.丞丗丄丂丆业丈丑业.playerMoveC.专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        }
        
        this.丛世下丝业丞丐丅丅 = true;
        bool val_1 = 丘上丅丝丄三一丕丁;
        goto typeof(TransportControllerBase).__il2cppRuntimeField_3F8;
    }
    internal void 一丘丛不丞丂七丝不(bool 丕丞七丑丙丙丅丌丂 = True)
    {
        float val_8;
        var val_9;
        int val_10;
        if(this.丌且下丕下下丌万丞 != false)
        {
                val_8 = 3f;
            FpsManager.Reset(丕丕世且下一与丝与:  val_8);
        }
        
        this.丑丞丒丟丞丟丆丁一 = false;
        this.丛丗丑丝丕丌七与丆 = false;
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  2);
        if(丕丞七丑丙丙丅丌丂 != false)
        {
                this.业丌上丙不丕丝丂丒(丗丛不丕且与世丏丑:  true);
        }
        
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  0);
        val_9 = null;
        val_9 = null;
        if((PGCompany.GamepadCoreController.GamePadEnabled != false) && (InGameGUI.丙丞专丌丁丞与不丐 != 0))
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七 != 0)
        {
                ShowWorldMap(丛与丙丒丒下丌丟且:  false, 丞三业丕世丂丁丐专:  true);
        }
        
        }
        
        丒七丌七丘东业丟丅();
        丒七丌七丘东业丟丅();
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丆丐不丈七七不业丒 != 0)
        {
                this.丞丗丄丂丆业丈丑业.playerMoveC.丆丐不丈七七不业丒.SetActive(value:  true);
        }
        
        this.丞丗丄丂丆业丈丑业.playerMoveC.一一丝专东丘丅一丌(丘丘丘专业丁丙丘丁:  System.String.alignConst, 专丞上七七且丝七丗:  0);
        val_10 = System.String.alignConst;
        this.丞丗丄丂丆业丈丑业.playerMoveC.三上丅与丈丞丄不丗 = val_10;
        SetActive(value:  true);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5472");
            val_8 = 5f;
            Show(丕丗丘丑丛与丑业丒:  val_10, 丂三丟丂丈丐丆丗丟:  val_8, 丂丝且专丒三世丞丐:  true);
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_7;
        mem[1152921540407759492] = val_7.y;
        mem[1152921540407759496] = val_7.z;
        SetActive(value:  true);
        this.丞丗丄丂丆业丈丑业.playerMoveC.万丛世且下且丄专且(丈专丗且下丁丂丏丑:  false);
    }
    internal void 且丘丘丌丁丂丒丟丈()
    {
        bool val_22;
        var val_23;
        UnityEngine.Transform val_1 = this.transform;
        if(this.万丆丏下专一业与丅 == false)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_55;
        }
        
        label_56:
        label_55:
        val_1.position = new UnityEngine.Vector3() {x = this.与世东丙丕一上丁与, y = V9.16B, z = V10.16B};
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  this.playerCamera.丐丒丆业丁丄三丕不, z:  0f);
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        this.万丆丏下专一业与丅 = false;
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  5);
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  5);
        if((PGCompany.GamepadCoreController.GamePadEnabled != false) && (InGameGUI.丙丞专丌丁丞与不丐 != 0))
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七 != 0)
        {
                ShowWorldMap(丛与丙丒丒下丌丟且:  false, 丞三业丕世丂丁丐专:  true);
        }
        
        }
        
        this.且丆丅丏丌丗丛丄丌 = false;
        this.丑丞丒丟丞丟丆丁一 = true;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_7;
        mem[1152921540408011876] = val_7.y;
        mem[1152921540408011880] = val_7.z;
        this.世丟丈丏丕万丝丆万.enabled = true;
        BattleRoyaleController val_8 = BattleRoyaleController.丑七不且上丗丁一世();
        ShuttleController val_9 = val_8.shutle.GetComponent<ShuttleController>();
        val_9.inShuttle = false;
        val_22 = 0;
        this.丛丗丑丝丕丌七与丆 = false;
        if(this.丞丗丄丂丆业丈丑业 == null)
        {
                val_22 = this.丛丗丑丝丕丌七与丆;
        }
        
        this.丞丗丄丂丆业丈丑业.playerMoveC.丏丌丑丅七丗丘一丅(丛丗丑丝丕丌七与丆:  (val_22 == true) ? 1 : 0, 专丞上七七且丝七丗:  0);
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        NJGMapItem val_15 = AddMiniMapIcon(业丟丏上丛与不一丝:  transform.root.gameObject, 下丗丁丒丘东丂不丑:  1);
        SetMiniMapTarget(业丟丏上丛与不一丝:  transform.root.gameObject);
        Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5469"), 丂三丟丂丈丐丆丗丟:  5f, 丂丝且专丒三世丞丐:  true);
        return;
        label_1:
        BattleRoyaleController val_20 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_21 = val_20.shutle.position;
        if(val_1 != null)
        {
            goto label_55;
        }
        
        goto label_56;
    }
    internal void 与丅七丈丌且七丐丟()
    {
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  5);
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  5);
        this.丞丗丄丂丆业丈丑业.playerMoveC.丏丌丑丅七丗丘一丅(丛丗丑丝丕丌七与丆:  (this.丛丗丑丝丕丌七与丆 == true) ? 1 : 0, 专丞上七七且丝七丗:  0);
        this.丞丗丄丂丆业丈丑业.playerMoveC.业丕且丌丌东七且与(丗上专丞丌丗丑丙一:  true, 专丞上七七且丝七丗:  0);
    }
    internal void 丙东一不丕丆下丏丂()
    {
        this.且丆丅丏丌丗丛丄丌 = false;
        this.丑丞丒丟丞丟丆丁一 = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_1;
        mem[1152921540408379236] = val_1.y;
        mem[1152921540408379240] = val_1.z;
        if(this.丌且下丕下下丌万丞 != false)
        {
                this.世丟丈丏丕万丝丆万.enabled = true;
            this.丞丗丄丂丆业丈丑业.playerMoveC.世丄丟与丕世丙下丈();
        }
        
        this.丛丗丑丝丕丌七与丆 = false;
        this.丛丐世丟丆丙专丛一 = 0;
        this.丞丗丄丂丆业丈丑业.世下丗丅丗丆万丝上 = false;
        this._moveC.TrySetLandingTrails();
        if(this.丛丗丑丝丕丌七与丆 != false)
        {
                float val_2 = this.不丄丒七业丏丙丕三;
            val_2 = val_2 * 0.7f;
            val_2 = val_2 + 0.3f;
            this.丘丗与业丅业下丕丅(丐丌一丈丒一丕丐丙:  val_2);
            return;
        }
        
        float val_3 = this.丟三丂业丌丘丐丟世;
        val_3 = val_3 * 0.6f;
        val_3 = val_3 / 90f;
        val_3 = val_3 + 0.4f;
        this.丙丒丘与不三业丅上(丐丌一丈丒一丕丐丙:  val_3);
    }
    internal void 丝丆丁丅丐丂丞丟丌()
    {
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  5);
        this.且丆丅丏丌丗丛丄丌 = false;
        this.丑丞丒丟丞丟丆丁一 = true;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_2;
        mem[1152921540408519908] = val_2.y;
        mem[1152921540408519912] = val_2.z;
        this.世丟丈丏丕万丝丆万.enabled = true;
        this.丈下丘万丙丌且丄且();
    }
    internal void 七丌七丈丝专丘丘丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this.与世东丙丕一上丁与 = 业丒丝丗与丐丛丟丏;
        mem[1152921540408639456] = 业丒丝丗与丐丛丟丏.y;
        mem[1152921540408639460] = 业丒丝丗与丐丛丟丏.z;
        this.万丆丏下专一业与丅 = true;
    }
    internal void 丗丂东丌丙一丕业丙(UnityEngine.Vector2 丞且丅三三东不丄且, bool 万业丒丞丅一丂丈业 = False)
    {
        var val_58;
        int val_59;
        var val_60;
        float val_61;
        float val_62;
        var val_63;
        var val_64;
        float val_65;
        UnityEngine.GameObject val_66;
        var val_67;
        int val_68;
        float val_70;
        float val_71;
        float val_72;
        float val_74;
        float val_75;
        val_60 = 万业丒丞丅一丂丈业;
        val_61 = 丞且丅三三东不丄且.y;
        val_62 = 丞且丅三三东不丄且.x;
        val_63 = this;
        val_64 = 1152921505066536960;
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                val_59 = SpeedrunTrackController.丛专与丅下丌丆世丒;
            if(val_59 != 0)
        {
                val_59 = SpeedrunTrackController.丛专与丅下丌丆世丒;
            if((SpeedrunTrackController.丛专与丅下丌丆世丒 + 164) == 0)
        {
                return;
        }
        
        }
        
        }
        
        if(SelectionControlMode.IsShowing != false)
        {
                return;
        }
        
        if(val_62 == 0f)
        {
                if(val_61 == 0f)
        {
            goto label_11;
        }
        
        }
        
        this.与丐丕丐七丒上丈与 = 0f;
        label_11:
        if(((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true) && (TrainingController.丁丑七与丙丐丘丌下() == 1))
        {
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            val_65 = val_62;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_65, y = val_61}, rhs:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y})) != false)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  1);
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  16);
        }
        
        }
        
        val_66 = this.丞丗丄丂丆业丈丑业.playerMoveC.丌下不丐丅丗专丙且;
        val_67 = 0;
        if(val_66 != 0)
        {
                val_66 = this.丞丗丄丂丆业丈丑业.playerMoveC.丌下不丐丅丗专丙且.GetComponent<Rocket>();
            val_67 = 0;
            val_66.丙三与丄丞七丗三业(七东丙丘丑丛丒丄丑:  new UnityEngine.Vector2() {x = val_62, y = val_61}, 丗丈专下丆七丛丂上:  this.playerCamera.与丈丏东一丘丆丁三(), 丈丝丝丈丂丆一丘世:  (this.playerCamera.丝业丈不丙丄丝一一 == true) ? 1 : 0);
        }
        else
        {
                if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(this.且丆丅丏丌丗丛丄丌 == false)
        {
            goto label_42;
        }
        
        }
        
        }
        
        }
        
        label_116:
        bool val_15 = val_60;
        val_65 = val_62;
        val_58 = ???;
        val_63 = ???;
        val_60 = ???;
        val_64 = ???;
        val_62 = ???;
        val_61 = ???;
        goto typeof(BaseCamera).__il2cppRuntimeField_1D8;
        label_42:
        if((val_63 + 266) != 0)
        {
                if(((val_63 + 224) & 1) != 0)
        {
            goto label_116;
        }
        
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
            goto label_116;
        }
        
        if(((GameConnect.且丘丄丛下丆丟万丕() == true) || (GameConnect.丙丌丒丈东七丒上丌() == true)) || (GameConnect.丟丆丏上丌一丝丟业() == true))
        {
            goto label_59;
        }
        
        float val_58 = System.Math.Abs(val_62 / UnityEngine.Time.deltaTime);
        float val_26 = val_63 + 400.一一上与丗专丗丏丌();
        float val_27 = 与丂丏丛丞丞丒丟丄.万丕丘丈下丘万世丆() * (val_63 + 400.一一上与丗专丗丏丌());
        val_27 = val_58 - val_27;
        val_26 = (与丂丏丛丞丞丒丟丄.万丛丆丟万丄丝丝丅() - 与丂丏丛丞丞丒丟丄.万丕丘丈下丘万世丆()) * val_26;
        float val_61 = 1f;
        val_26 = val_27 / val_26;
        float val_59 = UnityEngine.Mathf.Clamp(value:  val_26, min:  0f, max:  val_61);
        val_59 = val_59 * ((float)System.Math.Sign(value:  val_62));
        val_68 = 与丂丏丛丞丞丒丟丄.丂丏丂丂七世丗丛丄;
        float val_60 = (float)val_68;
        val_60 = val_59 * val_60;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_73;
        }
        
        }
        
        val_68 = 与丂丏丛丞丞丒丟丄.丒丙丕丘七丆三丐丝() * 与丂丏丛丞丞丒丟丄.丑丐三丙七下丁丈丛;
        goto label_76;
        label_73:
        label_76:
        val_70 = mem[val_63 + 68];
        val_70 = val_63 + 68;
        float val_35 = val_70 + (-3.402823E+38f);
        val_61 = val_60 * 与丂丏丛丞丞丒丟丄.上丌丑丂丕丗上丞丅();
        mem2[0] = -3.402823E+38f;
        if((val_35 < 0) && (val_35 > (-1f)))
        {
                val_70 = val_61;
            mem2[0] = val_61;
        }
        
        if((UnityEngine.Mathf.Sign(f:  val_70)) == (UnityEngine.Mathf.Sign(f:  val_61)))
        {
                val_71 = mem[val_63 + 68];
            val_71 = val_63 + 68;
        }
        else
        {
                val_71 = 0f;
        }
        
        mem2[0] = val_71;
        val_58 = (System.Math.Abs(val_62) > 5f) ? (val_61) : 0f;
        mem2[0] = val_58;
        float val_44 = val_63 + 400.一一上与丗专丗丏丌();
        float val_45 = 与丂丏丛丞丞丒丟丄.万丕丘丈下丘万世丆() * (val_63 + 400.一一上与丗专丗丏丌());
        val_45 = (System.Math.Abs(val_61 / UnityEngine.Time.deltaTime)) - val_45;
        val_44 = (与丂丏丛丞丞丒丟丄.万丛丆丟万丄丝丝丅() - 与丂丏丛丞丞丒丟丄.万丕丘丈下丘万世丆()) * val_44;
        float val_68 = 1f;
        val_44 = val_45 / val_44;
        float val_65 = UnityEngine.Mathf.Clamp(value:  val_44, min:  0f, max:  val_68);
        float val_64 = (float)System.Math.Sign(value:  val_61);
        val_64 = val_65 * val_64;
        float val_66 = 与丂丏丛丞丞丒丟丄.丆丕丆丒专业丆一丕;
        val_72 = (float)与丂丏丛丞丞丒丟丄.丂丏丂丂七世丗丛丄;
        val_65 = val_64 * val_72;
        val_66 = val_66 * val_65;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_100;
        }
        
        }
        
        val_72 = 与丂丏丛丞丞丒丟丄.丒丙丕丘七丆三丐丝() * 与丂丏丛丞丞丒丟丄.丑丐三丙七下丁丈丛;
        goto label_103;
        label_100:
        label_103:
        val_74 = mem[val_63 + 72];
        val_74 = val_63 + 72;
        float val_67 = val_58 + -52;
        val_67 = val_74 + val_67;
        val_68 = val_66 * 与丂丏丛丞丞丒丟丄.上丌丑丂丕丗上丞丅();
        if((val_67 < 0) && (val_67 > (-1f)))
        {
                val_74 = val_68;
            mem2[0] = val_68;
        }
        
        if((UnityEngine.Mathf.Sign(f:  val_74)) == (UnityEngine.Mathf.Sign(f:  val_68)))
        {
                val_75 = mem[val_63 + 72];
            val_75 = val_63 + 72;
        }
        else
        {
                val_75 = 0f;
        }
        
        mem2[0] = val_75;
        float val_55 = (System.Math.Abs(val_61) > 5f) ? (val_68) : 0f;
        val_62 = val_62 + val_58;
        val_61 = val_61 + val_55;
        mem2[0] = val_55;
        label_59:
        val_63.上丝丂丄丗丝上丘一(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_62, y = val_61}, 世专专丙世丒上丁丌:  val_63 + 400.与丈丏东一丘丆丁三(), 丝业丈不丙丄丝一一:  val_63 + 400 + 108, 万业丒丞丅一丂丈业:  val_60 & 1);
        goto label_116;
    }
    internal void 丌丛丄丗丂丙丛七丄()
    {
        if(this._moveC.东丗丒丝丐且丞丄丏 == true)
        {
                return;
        }
        
        bool val_2 = this.cableCarMoving;
        val_2 = val_2 + 3;
        var val_3 = ~val_2;
        val_3 = val_3 & 3;
        if(val_3 != 0)
        {
                return;
        }
        
        bool val_4 = this.丐丂丕丂丑三丑丒一;
        var val_1 = (val_4 == false) ? 1 : 0;
        val_4 = val_4 ^ 1;
        this.丐丂丕丂丑三丑丒一 = val_4;
        this.世丟丈丏丕万丝丆万.height = 106019880 + this.丐丂丕丂丑三丑丒一 == false ? 1 : 0;
        this = this.世丟丈丏丕万丝丆万;
        if(this.丐丂丕丂丑三丑丒一 != false)
        {
            
        }
        
        this.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal void 丞丐丒丕不丐不下丘()
    {
        if(this.丐丂丕丂丑三丑丒一 == false)
        {
                return;
        }
        
        this.丐丂丕丂丑三丑丒一 = false;
        this.世丟丈丏丕万丝丆万.height = 1.8f;
        this = this.世丟丈丏丕万丝丆万;
        this.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal void 丄且丒丟丌东丒东丌(byte 七丛丌丞丐丆丐专丛)
    {
        byte val_1 = 七丛丌丞丐丆丐专丛 & 255;
        PlatformController[] val_2 = PlatformsList.丄丘七三上丕世丞业.platforms + (((七丛丌丞丐丆丐专丛 & 255)) << 3);
        this.丘丘丑东丆丞丄七业 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((七丛丌丞丐丆丐专丛 & 255)) << 3) + 32].transform;
        this.上丘丂丌丑东上且丗 = true;
        this.下丈丞丝与上下丝丙 = 七丛丌丞丐丆丐专丛;
    }
    internal void 不丄丏不业且专丂丌(int 七丛丌丞丐丆丐专丛)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丙与丁且且七丒世不 = val_1;
        mem[1152921540409347236] = val_1.y;
        mem[1152921540409347240] = val_1.z;
        this.丘丘丑东丆丞丄七业 = 0;
        this.上丘丂丌丑东上且丗 = false;
    }
    internal void 丗一丈世业七丆丄万()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_1;
        mem[1152921540409459556] = val_1.y;
        mem[1152921540409459560] = val_1.z;
    }
    internal void 丐七东一万万丆专上()
    {
        this.不丒东业丙丘业下丁 = this.丘丑丗与丛丂丞丑丘;
        this.丙一三业丂丁专丛万 = (this.丝且与丘七丆专且丂 == false) ? this.万世丆丘不丏丐上丄 : this.三与丐丏东世丄丂丑;
    }
    internal void 业下丂不与丂三丐三()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.丗丈丂丐丁丟丙丝东 = val_1;
        mem[1152921540409683132] = val_1.y;
    }
    private void 丂且丁丟七丝丌丘不()
    {
        this.丈世丁丑不丄丗三丈 = this.丅丏丆下丞丟丏七丙;
    }
    internal bool 丒丏丁丛丅丙丂丄且()
    {
        var val_8;
        var val_9;
        var val_10;
        LeftFireTouchButton val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_8 = null;
        val_8 = null;
        if(JoystickController.世万丁丆业业丘丘丌 == 0)
        {
            goto label_11;
        }
        
        val_9 = null;
        val_9 = null;
        if(JoystickController.世万丁丆业业丘丘丌.fireTouch == 0)
        {
            goto label_11;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = mem[JoystickController.世万丁丆业业丘丘丌 + 40];
        val_11 = JoystickController.世万丁丆业业丘丘丌.fireTouch;
        if(isPressed == true)
        {
            goto label_16;
        }
        
        label_11:
        val_12 = null;
        val_12 = null;
        if(JoystickController.丘万丏三丏丑世丐丏 == 0)
        {
            goto label_32;
        }
        
        val_13 = null;
        val_13 = null;
        if(JoystickController.丘万丏三丏丑世丐丏.fireTouch == 0)
        {
            goto label_32;
        }
        
        val_14 = null;
        val_14 = null;
        val_11 = mem[JoystickController.丘万丏三丏丑世丐丏 + 160];
        val_11 = JoystickController.丘万丏三丏丑世丐丏.fireTouch;
        if(isPressed == false)
        {
            goto label_32;
        }
        
        label_16:
        val_15 = 1;
        return (bool)(JoystickController.丘万丏三丏丑世丐丏.isShootingPressure == true) ? 1 : 0;
        label_32:
        val_16 = null;
        val_16 = null;
        val_11 = JoystickController.丘万丏三丏丑世丐丏;
        return (bool)(JoystickController.丘万丏三丏丑世丐丏.isShootingPressure == true) ? 1 : 0;
    }
    internal void 七丈且丘三万且丏上(float 下丞丅丗丌一丛丗丞, PlayerAnimationWrapper.丂专丅一业东丘东丈 专丞丅业丆丐丕不七)
    {
        var val_22;
        float val_23;
        float val_24;
        float val_25;
        val_22 = null;
        val_22 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_20;
        }
        
        bool val_2 = 丏丑业丛七七丘丅万();
        if(val_2 == true)
        {
            goto label_20;
        }
        
        if(val_2.丒丏丁丛丅丙丂丄且() != false)
        {
                if(this.且丈丟丏专业丕丗丆 == true)
        {
            goto label_20;
        }
        
        }
        
        if(this.专万且七丐丗丆丐丑 == UnityEngine.Time.frameCount)
        {
            goto label_23;
        }
        
        if(专丞丅业丆丐丕不七 == 7)
        {
            goto label_12;
        }
        
        val_23 = 0f;
        if((专丞丅业丆丐丕不七 != 0) || (this.丙一三业丂丁专丛万 > 0f))
        {
            goto label_14;
        }
        
        label_12:
        val_23 = this.丂丛万丑不上东不丛;
        this.下丝丝丈世丟丘丄专 = true;
        label_14:
        val_24 = this.万丗丈丗三不丌不丆;
        this.万丗丈丗三不丌不丆 = UnityEngine.Mathf.MoveTowardsAngle(current:  val_24, target:  val_23, maxDelta:  UnityEngine.Time.deltaTime * this.丆丕与丁且三丕丞世);
        if(this.playerCamera == null)
        {
                val_24 = this.万丗丈丗三不丌不丆;
        }
        
        float val_22 = this.playerCamera.下丁丂丐丙万丞丂丞;
        val_25 = this.丞专三不不世丏丅丐;
        val_22 = val_22 + val_24;
        if(val_22 <= val_25)
        {
            goto label_18;
        }
        
        if(this.playerCamera == null)
        {
                val_25 = this.丞专三不不世丏丅丐;
        }
        
        val_24 = this.playerCamera.下丁丂丐丙万丞丂丞;
        if(val_24 >= 0)
        {
            goto label_20;
        }
        
        val_24 = val_25 - this.playerCamera.下丁丂丐丙万丞丂丞;
        this.万丗丈丗三不丌不丆 = val_24;
        label_18:
        if(val_24 == 0f)
        {
            goto label_22;
        }
        
        goto label_23;
        label_20:
        this.万丗丈丗三不丌不丆 = 0f;
        label_22:
        this.下丝丝丈世丟丘丄专 = false;
        label_23:
        this.且丈丟丏专业丕丗丆 = this._moveC.且丂一丁丆丒与丁业();
        this.专万且七丐丗丆丐丑 = UnityEngine.Time.frameCount;
        UnityEngine.Vector3 val_13 = this.playerCamera.transform.position;
        UnityEngine.Vector3 val_15 = this.playerCamera.transform.forward;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  1000f);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        this.playerGameObject.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Quaternion val_20 = this.playerGameObject.transform.localRotation;
        float val_23 = -12f;
        val_23 = val_20.x + val_23;
        val_23 = this.万丗丈丗三不丌不丆 + val_23;
        UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.Euler(x:  val_23, y:  10f, z:  0f);
        this.playerGameObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w};
    }
    private System.Collections.IEnumerable 一丈丝世万丕丝七七()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new FirstPersonControlSharp.与丆且上东丛世世丗(丗丏丅丕丆世丁专丟:  -2);
    }
    private void 丘三丁丛万丕丄且丆(float 一丘丏丆不丕丈丈丒, float 丂万丕下一丄丈丁丙, bool 丆万丞丏丙业丐丙丆 = True, bool 不丆丗丛丙丁丌丂东 = True)
    {
        this.<丗专丟丑万丙与专丌>k__BackingField.Rotate(xAngle:  0f, yAngle:  一丘丏丆不丕丈丈丒, zAngle:  0f, relativeTo:  1);
        if(丆万丞丏丙业丐丙丆 != false)
        {
                UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  丂万丕下一丄丈丁丙, y:  一丘丏丆不丕丈丈丒);
            this.丙丁丂上三三丌与丕 = val_1.x;
            mem[1152921540410378840] = val_1.y;
        }
        
        if(不丆丗丛丙丁丌丂东 == false)
        {
                return;
        }
        
        if(this.一丆世业上丄专下丟() == false)
        {
                return;
        }
        
        this.七丏与下且与丏丏丛 = UnityEngine.Mathf.Clamp(value:  this.weaponFollowLagSensitive * 丂万丕下一丄丈丁丙, min:  -this.maxWeaponFollowLag, max:  this.maxWeaponFollowLag);
        this.三丛三丞上丐丝七丛 = UnityEngine.Mathf.Clamp(value:  this.weaponFollowLagSensitive * 一丘丏丆不丕丈丈丒, min:  -this.maxWeaponFollowLag, max:  this.maxWeaponFollowLag);
    }
    internal void 丙丝世东不万丗万丗()
    {
        Player_move_c val_20;
        PlayerAnimationWrapper val_21;
        float val_22;
        if((this._moveC == 0) || (this._moveC.myWeaponTransform == 0))
        {
            goto label_31;
        }
        
        UnityEngine.Quaternion val_3 = this.playerCamera.且与东丕专七万丕不.rotation;
        this._moveC.myWeaponTransform.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        val_20 = this._moveC;
        if(this._moveC != null)
        {
            goto label_12;
        }
        
        val_20 = this._moveC;
        if(val_20 == null)
        {
            goto label_13;
        }
        
        label_12:
        this._moveC.myWeaponTransform.Rotate(xAngle:  this._moveC.丅丄下丛东丙且且丞 - this.且与丒丏东万丂业下, yAngle:  0f, zAngle:  0f);
        this._moveC.myWeaponTransform.Rotate(xAngle:  0f, yAngle:  -this.丑丒丞丒丟丕丁一一, zAngle:  0f);
        val_21 = this.丞丗丄丂丆业丈丑业.playerAnimation;
        val_22 = 0f;
        this._moveC.myWeaponTransform.Rotate(xAngle:  val_22, yAngle:  0f, zAngle:  this.丞丗丄丂丆业丈丑业.playerAnimation.currentWeaponDirectionRotationZ);
        if((this._moveC.东丗丒丝丐且丞丄丏 != false) && (this._moveC.丑丝丂丗丝丛与不七 != 0))
        {
                if(this._moveC.丑丝丂丗丝丛与不七.gun != 0)
        {
                UnityEngine.Quaternion val_8 = this.playerCamera.且与东丕专七万丕不.rotation;
            this._moveC.丑丝丂丗丝丛与不七.gun.transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
            val_21 = this._moveC;
            this._moveC.丑丝丂丗丝丛与不七.gun.transform.Rotate(xAngle:  this._moveC.丅丄下丛东丙且且丞 - this.且与丒丏东万丂业下, yAngle:  0f, zAngle:  0f);
            val_22 = 0f;
            this._moveC.丑丝丂丗丝丛与不七.gun.transform.Rotate(xAngle:  val_22, yAngle:  -this.丑丒丞丒丟丕丁一一, zAngle:  0f);
        }
        
        }
        
        label_31:
        this.且与丒丏东万丂业下 = UnityEngine.Mathf.Lerp(a:  this.且与丒丏东万丂业下, b:  this.七丏与下且与丏丏丛, t:  this.weaponFollowLagSpped * UnityEngine.Time.deltaTime);
        this.丑丒丞丒丟丕丁一一 = UnityEngine.Mathf.Lerp(a:  this.丑丒丞丒丟丕丁一一, b:  this.三丛三丞上丐丝七丛, t:  this.weaponFollowLagSpped * UnityEngine.Time.deltaTime);
        this.七丏与下且与丏丏丛 = 0f;
        this.三丛三丞上丐丝七丛 = 0f;
        return;
        label_13:
    }
    private void 上丝丂丄丗丝上丘一(UnityEngine.Vector2 丞且丅三三东不丄且, float 世专专丙世丒上丁丌, bool 丝业丈不丙丄丝一一, bool 万业丒丞丅一丂丈业 = False)
    {
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, d:  世专专丙世丒上丁丌);
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  30f);
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  (万业丒丞丅一丂丈业 != true) ? 1280f : ((float)UnityEngine.Screen.width));
        float val_7 = 1f;
        val_7 = ((丝业丈不丙丄丝一一 != true) ? (val_7) : -1f) * val_5.y;
        this.丘三丁丛万丕丄且丆(一丘丏丆不丕丈丈丒:  val_5.x, 丂万丕下一丄丈丁丙:  val_7, 丆万丞丏丙业丐丙丆:  true, 不丆丗丛丙丁丌丂东:  true);
    }
    private void 丁不丏丒丆丘丙丌与()
    {
        BaseCamera val_13;
        float val_15;
        float val_16;
        var val_17;
        var val_18;
        var val_20;
        var val_21;
        var val_22;
        float val_23;
        float val_24;
        val_13 = this;
        float val_13 = UnityEngine.Time.deltaTime;
        if(丘丐丘万丌丟丞下丝.一丆一下七丏万丟业() == false)
        {
            goto label_3;
        }
        
        val_15 = this.上世丈丗专丆东丙丂;
        val_16 = 0f;
        goto label_4;
        label_3:
        if(this._moveC.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_6;
        }
        
        WeaponSounds val_3 = this._moveC.丙不丅丕三丂业东丕();
        if(val_3.categoryNabor != 5)
        {
            goto label_9;
        }
        
        val_17 = null;
        if(this.丘东一丟丝丙丄丏与() == false)
        {
            goto label_10;
        }
        
        val_18 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.与专下东一丐丌一丏
        goto label_22;
        label_6:
        val_20 = null;
        val_20 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.一丝丟丒丟专业不丏
        goto label_22;
        label_9:
        val_21 = null;
        val_21 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.丈丝丛丝业丘丗专与
        goto label_22;
        label_10:
        val_22 = null;
        PlayerCoreSettingsStorager.recoildAndScopeSettings.丕丄且业丅丏丞且丅
        label_22:
        float val_14 = PlayerCoreSettingsStorager.recoildAndScopeSettings.丕丄且业丅丏丞且丅;
        val_23 = 0f;
        if(this._moveC != 0)
        {
                if(this._moveC.丙不丅丕三丂业东丕() != 0)
        {
                WeaponSounds val_8 = this._moveC.丙不丅丕三丂业东丕();
            val_23 = val_8.丅丟万丕东专丘丆三;
        }
        
        }
        
        val_13 = val_13 * val_14;
        val_15 = this.上世丈丗专丆东丙丂;
        val_16 = UnityEngine.Mathf.Clamp(value:  val_23 - this.上世丈丗专丆东丙丂, min:  -val_13, max:  val_13);
        label_4:
        val_14 = val_16 + this.上世丈丗专丆东丙丂;
        if((this.<且丂一与且丐丕丗丈>k__BackingField) == 2)
        {
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0f, y:  val_16);
            val_24 = this.weaponsFeedbackForceSens;
            if(this.playerCamera != null)
        {
            goto label_39;
        }
        
        }
        else
        {
                val_24 = -val_16;
            this.丘三丁丛万丕丄且丆(一丘丏丆不丕丈丈丒:  0f, 丂万丕下一丄丈丁丙:  val_24, 丆万丞丏丙业丐丙丆:  false, 不丆丗丛丙丁丌丂东:  false);
            val_13 = this.playerCamera;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  0f, y:  val_24);
        }
        
        label_39:
        mem2[0] = val_14;
    }
    private void 丗七丞丄万丏专丆丕()
    {
        Player_move_c val_18;
        var val_19;
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return;
        }
        
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return;
        }
        
        if(this.丌专丒丒丛丐丘上丄 != 0)
        {
                val_18 = this.丞丗丄丂丆业丈丑业.playerMoveC;
            if((this.丌专丒丒丛丐丘上丄 & 1) != 0)
        {
                return;
        }
        
        }
        
        一三专丈世丑丆丑丐 val_4 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_4.丌丘丞丛专上丐且七 == false)
        {
            goto label_16;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this._moveC.丙不丅丕三丂业东丕() != 0)
        {
                WeaponSounds val_8 = this._moveC.丙不丅丕三丂业东丕();
            val_18 = 1152921505322766336;
            val_19 = null;
            val_19 = null;
            if((System.String.op_Equality(a:  val_8.Tag, b:  与世丁丙且丑下丌不.丈且丞世业丕丐丅三)) == true)
        {
                return;
        }
        
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        }
        else
        {
                UnityEngine.Vector2 val_12 = this.丞丝丂丌丄丏丏上丘.丙一万不一丛且丄下();
        }
        
        bool val_13 = GameConnect.万不丒丌丙万丗东不();
        UnityEngine.Vector2 val_14 = this.丂万业丟丑丅丈且丕.丙一万不一丛且丄下();
        this.丘三丁丛万丕丄且丆(一丘丏丆不丕丈丈丒:  val_14.x, 丂万丕下一丄丈丁丙:  val_14.y, 丆万丞丏丙业丐丙丆:  false, 不丆丗丛丙丁丌丂东:  false);
        if((this.<且丂一与且丐丕丗丈>k__BackingField) == 2)
        {
                val_18 = this.<丗专丟丑万丙与专丌>k__BackingField;
            UnityEngine.Quaternion val_15 = val_18.rotation;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_15.y, y:  -val_14.y);
            if(this.playerCamera != null)
        {
            goto label_42;
        }
        
        }
        
        label_42:
        label_16:
        一三专丈世丑丆丑丐 val_17 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_17.丘东丝丛三丟上丅丅 == false)
        {
                return;
        }
        
        this.丁不丏丒丆丘丙丌与();
    }
    private void Awake()
    {
        bool val_56;
        bool val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        PlayerBotController val_2 = PlayerBotController.不世丂丏丒万世东丂(丁世丛业丟下丕三丟:  PhotonView.Get(丑丅丈东丐丐丕丞丙:  this));
        this.业丌东七七丒世丞万 = val_2;
        this.一七不三丌专三丆一 = UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
        this.<丒丟丄下丙丐丏东七>k__BackingField = System.String.op_Equality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), b:  "PlayerBattleRoyale");
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_9 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  16);
        if(val_9 != null)
        {
                this.丕丅业东丞且三丁不 = val_9.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool");
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_12 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_12 != null)
        {
                var val_14 = ((val_12.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) == 103) ? 1 : 0;
        }
        else
        {
                val_56 = false;
        }
        
        this.<丒丆与丒丘与丒业与>k__BackingField = val_56;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_15 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  14);
        if(val_15 != null)
        {
                this.不七丏丒丑且丕丂业 = ((val_15.丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom")) == 2) ? 1 : 0;
            if((this.<丒丆与丒丘与丒业与>k__BackingField) != true)
        {
                this.<丒丆与丒丘与丒业与>k__BackingField = ((val_15.丛丅下丆丗丏三丁丕<EventMovementScheme>(丒丑丂丐丕丒丕东与:  "custom")) == 4) ? 1 : 0;
        }
        
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_20 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  19);
        if((val_20 != null) && (GameConnect.万不丒丌丙万丗东不() != false))
        {
                val_57 = val_20.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool");
        }
        else
        {
                val_57 = false;
        }
        
        this.<与丝丁不且东丘丙丞>k__BackingField = val_57;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_23 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  17);
        if(val_23 != null)
        {
                this.丝丝丐业不业与丐下 = val_23.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool");
        }
        
        val_58 = null;
        val_58 = null;
        if(GameController.mode.IsThirdPersonMode != false)
        {
                this.丝丝丐业不业与丐下 = true;
        }
        
        val_59 = null;
        val_59 = null;
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        this.丁丑丅丏丒不七上丁 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_32;
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if((PhotonView.Get(丑丅丈东丐丐丕丞丙:  this).isMine) == false)
        {
            goto label_35;
        }
        
        }
        
        bool val_55 = this.一七不三丌专三丆一;
        val_55 = val_55 ^ 1;
        val_60 = val_55 & 255;
        goto label_36;
        label_35:
        val_60 = 0;
        label_36:
        this.丌且下丕下下丌万丞 = (val_60 != 0) ? 1 : 0;
        label_32:
        if(this.丞丗丄丂丆业丈丑业 == 0)
        {
                this.丞丗丄丂丆业丈丑业 = this.GetComponent<SkinName>();
        }
        
        SniperScopeMovement val_31 = this.GetComponent<SniperScopeMovement>();
        this.丂万业丟丑丅丈且丕 = val_31;
        val_31.世上专丐丂业世世丂(世下丐丌一丗一丞丌:  true);
        this.丞丝丂丌丄丏丏上丘 = this.GetComponent<SniperShotImpulse>();
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                bool val_34 = GameConnect.丛专丌且丕不专丈下();
        }
        
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  false, 丆下丘丕丐丗丅丅不:  23);
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 6;
        }
        else
        {
                val_63 = null;
            val_63 = null;
            if(GameController.mode.IsControllerBattleRoyalType != false)
        {
                val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 2;
        }
        else
        {
                if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 9;
        }
        else
        {
                if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 10;
        }
        else
        {
                if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 19;
        }
        else
        {
                if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 8;
        }
        else
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_96;
        }
        
        }
        
            val_61 = PGCompany.GamepadCoreController.Instance;
            val_62 = 21;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_115:
        label_119:
        val_61.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  21);
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void FirstPersonControlSharp::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
        return;
        label_96:
        if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_104;
        }
        
        if(PGCompany.GamepadCoreController.Instance != null)
        {
            goto label_115;
        }
        
        goto label_115;
        label_104:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_111;
        }
        
        if(PGCompany.GamepadCoreController.Instance != null)
        {
            goto label_115;
        }
        
        goto label_115;
        label_111:
        if(PGCompany.GamepadCoreController.Instance != null)
        {
            goto label_119;
        }
        
        goto label_119;
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        WeaponManager val_86;
        Player_move_c val_87;
        var val_91;
        val_86 = 丙业与丙丗丝不丈东;
        val_87 = this;
        if(val_86 == null)
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
        
        if(null != null)
        {
                return;
        }
        
        if(七丐丅专且专七三丆 != 7)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_86 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        丕丏丂世下丛丑下丏(丙业与丙丗丝不丈东:  21884928);
        return;
        label_2:
        if(null != 1)
        {
            goto label_12;
        }
        
        if((七丐丅专且专七三丆 - 4) > 20)
        {
                return;
        }
        
        var val_87 = 106019896 + ((七丐丅专且专七三丆 - 4)) << 2;
        val_87 = val_87 + 106019896;
        goto (106019896 + ((七丐丅专且专七三丆 - 4)) << 2 + 106019896);
        label_3:
        if(七丐丅专且专七三丆 != 22)
        {
                return;
        }
        
        this.业不三丈一专丑不业 = new UnityEngine.Vector2();
        mem[1152921540411916372] = ???;
        return;
        label_12:
        if((七丐丅专且专七三丆 == 5) && (null == 3))
        {
                val_87 = this.丞丗丄丂丆业丈丑业.playerMoveC;
            if(this.丞丗丄丂丆业丈丑业.playerMoveC.丄丁丑丞丅一三丌丆 == false)
        {
                return;
        }
        
            val_91 = null;
            val_91 = null;
            专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
            return;
        }
        
        if(七丐丅专且专七三丆 != 4)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(((this.丞丗丄丂丆业丈丑业 == 0) || (this.丞丗丄丂丆业丈丑业.playerMoveC == 0)) || (this.丞丗丄丂丆业丈丑业.playerMoveC.丘七业丒丐世丂丅丒() <= 0f))
        {
            goto label_63;
        }
        
        val_87 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丘七业丒丐世丂丅丒() <= 0f)
        {
            goto label_67;
        }
        
        this.丞丗丄丂丆业丈丑业.playerMoveC.与丂丆丛专不丕专丛 = ((1152921504628731904 & 1095216660480) != 0) ? 1 : 0;
        return;
        label_63:
        val_87 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        label_67:
        this.丞丗丄丂丆业丈丑业.playerMoveC.与丂丆丛专不丕专丛 = false;
    }
    private void 七丘且且东丗丒不一()
    {
        var val_26;
        float val_27;
        var val_28;
        var val_29;
        bool val_30;
        bool val_31;
        var val_32;
        var val_33;
        if(this.丘丄丐下丏丐丞丞丈 != true)
        {
                if(this.世丟丈丏丕万丝丆万.isGrounded == false)
        {
            goto label_16;
        }
        
        }
        
        bool val_2 = (this.丝三丟且三三与且世 < 1) ? 1 : 0;
        label_16:
        this.丘丄丐下丏丐丞丞丈 = val_2;
        if(val_2 == 0)
        {
                return;
        }
        
        bool val_3 = this.专丗丑三丛丝丏丗不();
        if(this.cableCarMoving != false)
        {
                UnityEngine.Vector3 val_5 = this.transform.position;
            this.丟不七七七丟业专专 = val_5.y;
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                if(this.丕不丛丕丛丘丙丑丂 == false)
        {
            goto label_9;
        }
        
        }
        
        val_26 = this.transform;
        UnityEngine.Vector3 val_8 = val_26.position;
        val_27 = val_8.y;
        if(val_3 == false)
        {
            goto label_11;
        }
        
        this.丟不七七七丟业专专 = UnityEngine.Mathf.Max(a:  val_27, b:  this.丟不七七七丟业专专);
        goto label_15;
        label_11:
        this.丟不七七七丟业专专 = val_27;
        goto label_15;
        label_9:
        if(this.业不丟专业丁丏丄丗 == false)
        {
            goto label_21;
        }
        
        UnityEngine.Vector3 val_11 = this.transform.position;
        float val_13 = UnityEngine.Mathf.Clamp(value:  this.丟不七七七丟业专专 - val_11.y, min:  0f, max:  3.402823E+38f);
        float val_14 = (val_13 < 0) ? 0f : (val_13);
        if(val_14 <= 0f)
        {
            goto label_21;
        }
        
        if(this.不丐丝丕上世上与丌 != null)
        {
                this.不丐丝丕上世上与丌.Invoke(arg1:  this, arg2:  val_14);
        }
        
        val_28 = null;
        val_28 = null;
        if(GameController.onlineMode != 0)
        {
                val_29 = null;
            val_29 = null;
            val_30 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_30 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_30 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_18 = BattleRoyaleController.丑七不且上丗丁一世();
            val_31 = val_18.squadMode;
        }
        else
        {
                val_31 = 0;
        }
        
        val_32 = null;
        val_32 = null;
        if(GameController.onlineMode != 0)
        {
                val_33 = null;
            val_33 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_49;
        }
        
        }
        
        }
        
        label_53:
        var val_20 = val_31 | val_30;
        val_20 = val_20 | 0;
        Rilisoft.丞丛七上丕专丏丌丈.专且万丈丞七万世丞(丌七丒世丄上丞丞丁:  (int)val_14, 丙专七丘与丒丛丅丆:  (val_20 != 0) ? 1 : 0);
        label_21:
        val_26 = this.transform;
        UnityEngine.Vector3 val_23 = val_26.position;
        this.丟不七七七丟业专专 = val_23.y;
        this.业不丟专业丁丏丄丗 = false;
        label_15:
        this.业不丟专业丁丏丄丗 = val_3;
        return;
        label_49:
        bool val_26 = GameController.onlineMode.丄丗三丌世东业上丌();
        goto label_53;
    }
    private UnityEngine.Vector2 丟三丗七专丝丌丆三()
    {
        float val_6;
        float val_7;
        var val_8;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_6 = val_1.x;
        val_7 = val_1.y;
        val_8 = null;
        val_8 = null;
        if(JoystickController.丘万丏三丏丑世丐丏 == 0)
        {
                return new UnityEngine.Vector2() {x = val_6, y = val_7};
        }
        
        UnityEngine.Vector2 val_3 = JoystickController.丘万丏三丏丑世丐丏.GrabDeltaPosition();
        val_6 = val_3.x;
        val_7 = val_3.y;
        return new UnityEngine.Vector2() {x = val_6, y = val_7};
    }
    internal bool 丞丙丟下专万丟丂丄()
    {
        return (bool)this.丏不丞丐与丅丂与丒;
    }
    internal void 丐世丙丁下上上丆丙(bool 丙业与丙丗丝不丈东)
    {
        this.丏不丞丐与丅丂与丒 = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        this.丛丕世丛东丞丗丈上 = false;
    }
    private bool 专丗丑三丛丝丏丗不()
    {
        if(this.世丟丈丏丕万丝丆万.isGrounded == true)
        {
                return false;
        }
        
        if(((((this._moveC.与丏下丝万上三丛不() == true) || (this.下丅丂丘丏丟世且丐 == true)) || (this.且丆丅丏丌丗丛丄丌 == true)) || (this.丑丞丒丟丞丟丆丁一 == true)) || (this.丏不丞丐与丅丂与丒 == true))
        {
                return false;
        }
        
        if(this.七丏丙丌丒一七丂丆 != false)
        {
                return false;
        }
        
        var val_3 = (this.丕不丛丕丛丘丙丑丂 == false) ? 1 : 0;
        return false;
    }
    private void 丕丗丁丄专丏三东不()
    {
        var val_17;
        string val_19;
        if(PGCompany.丁东丌世与丕东丆上.丅世专业下不丞丝七() != true)
        {
                val_17 = null;
            val_17 = null;
            TrainingController.丟丄且丕丄丟丄东丛 = 1000f;
            TrainingController.与丄丘世丏上三下丁();
            HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "press_jump");
        }
        
        this.丆丒世丁七下一不丈 = false;
        if(this.丐丂丕丂丑三丑丒一 != false)
        {
                this.丌丛丄丗丂丙丛七丄();
            return;
        }
        
        bool val_3 = 丘丐丘万丌丟丞下丝.丘丏万丆丗万丐丞下();
        if(val_3 == true)
        {
                return;
        }
        
        val_3.且不一且丗东丁丕丙(丙业与丙丗丝不丈东:  true);
        if(this.七丞三丑丈一东丑丙 != true)
        {
                Rilisoft.丞丛七上丕专丏丌丈.下七丞与丒下丙世丈(丄上一丄与丁丆丗丌:  this._moveC.三丂不东丗丒丏三丟());
            if(this.丞丗丄丂丆业丈丑业.playerAnimation != 0)
        {
                this.丞丗丄丂丆业丈丑业.playerAnimation.丌业丈丏东上丕丟世();
            this.丞丗丄丂丆业丈丑业.interpolateScript.丘丟丄丗丞丝丘东七 = true;
        }
        
            if(this._moveC.七且不东世与且丒丛 != false)
        {
                this._moveC.专与丅丄不丛丗丛丂(一上丒丏丌丏丘且丑:  false);
        }
        
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丛不丆丕且丗丏丑丒() == false)
        {
                return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
                return;
        }
        
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(UnityEngine.Social.localUser.authenticated == false)
        {
                return;
        }
        
        if(this.丛丄世丑丐一丂不万 >= this.丟一万丗上不下丕丌)
        {
                return;
        }
        
        int val_12 = this.丛丄世丑丐一丂不万 + 1;
        this.丛丄世丑丐一丂不万 = val_12;
        if(val_12 != this.丟一万丗上不下丕丌)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  "NewbieJumperAchievement", value:  val_12);
        .丕与丑七与万丄丂丂 = 100f;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
        {
                if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_45;
        }
        
        }
        
        val_19 = "Jumper_id";
        goto label_46;
        label_45:
        val_19 = "CgkIr8rGkPIJEAIQAQ";
        label_46:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
        {
                AGSAchievementsClient.UpdateAchievementProgress(achievementId:  val_19, progress:  (FirstPersonControlSharp.丂丐丌世丅丘一七丐)[1152921540412954368].丕与丑七与万丄丂丂, userData:  0);
            return;
        }
        
        UnityEngine.Social.ReportProgress(achievementID:  val_19, progress:  (double)(FirstPersonControlSharp.丂丐丌世丅丘一七丐)[1152921540412954368].丕与丑七与万丄丂丂, callback:  new System.Action<System.Boolean>(object:  new FirstPersonControlSharp.丂丐丌世丅丘一七丐(), method:  System.Void FirstPersonControlSharp.丂丐丌世丅丘一七丐::丂丄丌不丌丒且丐丝(bool 丐万丗丒下七丟丁三)));
    }
    private void LateUpdate()
    {
        float val_26;
        float val_27;
        PlayerSynchStream val_28;
        float val_29;
        float val_30;
        var val_31;
        UnityEngine.Transform val_32;
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerAnimation == 0)
        {
            goto label_5;
        }
        
        丂专丅一业东丘东丈 val_2 = this.丞丗丄丂丆业丈丑业.playerAnimation.丞丆丛丐万丁丈万万();
        if(val_2 != 7)
        {
                if(val_2 != 0)
        {
            goto label_16;
        }
        
        }
        
        if((this.不丄丒七业丏丙丕三 < 0) && (this._moveC.与丏下丝万上三丛不() != true))
        {
                if((this._moveC.丗丞业丐丛三上丄丕() != true) && (this._moveC.丆丂丕专丒丌三一七 != true))
        {
                if(this._moveC.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_18;
        }
        
        }
        
        }
        
        label_16:
        val_26 = 0f;
        this.与丐丕丐七丒上丈与 = 0f;
        label_50:
        val_27 = this.standingIdleTimeout;
        this.丞丗丄丂丆业丈丑业.playerAnimation.丌七丗东三丏东丅丕(丙业与丙丗丝不丈东:  (val_26 > val_27) ? 7 : (val_2));
        this.丞丗丄丂丆业丈丑业.playerAnimation.一丙世丐且东与丁丘(丙业与丙丗丝不丈东:  this.世丟丈丏丕万丝丆万.isGrounded);
        this.丞丗丄丂丆业丈丑业.playerAnimation.丌万下世丟丅丁七丐(丂丛不丐丏丂丕丙丞:  (this.上丘丂丌丑东上且丗 == true) ? 1 : 0, 丘丒丌下丕专且七专:  this.下丈丞丝与上下丝丙);
        label_5:
        val_28 = this.丞丗丄丂丆业丈丑业.interpolateScript;
        this.丞丗丄丂丆业丈丑业.interpolateScript.业丂万丏丒丛丒万且 = this.世丟丈丏丕万丝丆万.isGrounded;
        if(this.丑且丕丞上丂丙业七 != true)
        {
                if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                val_28 = this.transform;
            UnityEngine.Vector3 val_13 = val_28.position;
            val_29 = val_13.x;
            val_30 = val_13.z;
            val_26 = val_29;
            val_27 = val_13.y;
            this.丞丗丄丂丆业丈丑业.interpolateScript.三丕丌丟丛东一丁丏(丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_30});
        }
        
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                val_31 = 1;
            val_32 = this.<丗专丟丑万丙与专丌>k__BackingField;
        }
        else
        {
                val_32 = this.<丗专丟丑万丙与专丌>k__BackingField;
            UnityEngine.Vector3 val_15 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
            val_29 = val_15.y;
            if((val_29 < this.且丏丟世东丟下且丈) && (this.东丁丑丙万七丌万丅 != false))
        {
                val_28 = this.transform;
            UnityEngine.Vector3 val_17 = val_28.position;
            val_30 = val_17.y;
            val_27 = val_30;
            this.丞丗丄丂丆业丈丑业.interpolateScript.三丕丌丟丛东一丁丏(丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = val_17.x, y = val_27, z = val_17.z});
        }
        
        }
        
        this.东丁丑丙万七丌万丅 = (val_29 >= this.且丏丟世东丟下且丈) ? 1 : 0;
        UnityEngine.Vector3 val_19 = mem[this.<丗专丟丑万丙与专丌>k__BackingField].position;
        this.且丏丟世东丟下且丈 = val_19.y;
        this.丑且丕丞上丂丙业七 = this.世丟丈丏丕万丝丆万.isGrounded;
        this.丕不丛丕丛丘丙丑丂 = false;
        if((this.世丟丈丏丕万丝丆万.isGrounded != false) && (this.丛丕世丛东丞丗丈上 != false))
        {
                this.丏不丞丐与丅丂与丒 = false;
            if((this.<丒丆与丒丘与丒业与>k__BackingField) != false)
        {
                UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  this.一三丟上丌一丄丙丅());
        }
        
        }
        
        this.丕不丛丕丛丘丙丑丂 = false;
        this.丛丕世丛东丞丗丈上 = this.丏不丞丐与丅丂与丒;
        return;
        label_18:
        float val_25 = UnityEngine.Time.deltaTime;
        val_25 = this.与丐丕丐七丒上丈与 + val_25;
        this.与丐丕丐七丒上丈与 = val_25;
        goto label_50;
    }
    private System.Collections.IEnumerator 一三丟上丌一丄丙丅()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FirstPersonControlSharp.丐与丑丗一丝东丛不(丗丏丅丕丆世丁专丟:  0);
    }
    private void OnControllerColliderHit(UnityEngine.ControllerColliderHit 丁丂丝不丟丛丟一丂)
    {
        bool val_1 = GameConnect.万不丒丌丙万丗东不();
    }
    private void OnDestroy()
    {
        if(this.丌且下丕下下丌万丞 != false)
        {
                PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void FirstPersonControlSharp::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
        if(this.playerCamera == 0)
        {
                return;
        }
        
        if(this.playerCamera == null)
        {
                return;
        }
    
    }
    private void 丅丆丛专且不丂丆丆()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_18;
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        if((UnityEngine.Object.op_Implicit(exists:  JoystickController.丗三丄与丂丟丌专东)) != false)
        {
                val_8 = null;
            val_8 = null;
            JoystickController.丗三丄与丂丟丌专东.transform.parent.gameObject.SetActive(value:  false);
        }
        
        val_9 = null;
        val_9 = null;
        if((UnityEngine.Object.op_Implicit(exists:  JoystickController.丘万丏三丏丑世丐丏)) != false)
        {
                val_10 = null;
            val_10 = null;
            JoystickController.丘万丏三丏丑世丐丏.gameObject.SetActive(value:  false);
        }
        
        label_18:
        this.enabled = false;
    }
    private void 丅丑与丄不丅七丑丆()
    {
        var val_9;
        var val_11;
        System.Action<System.Boolean> val_13;
        val_9 = this;
        var val_10 = 0;
        val_10 = val_10 + 1;
        if(UnityEngine.Social.localUser.authenticated == false)
        {
                return;
        }
        
        int val_4 = this.丂与丑且万下丕丅丙 + 1;
        if(this.丂与丑且万下丕丅丙 <= 49)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "NinjaJumpsCount", 下下丏一丙不丘丌丞:  val_4, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        this.丂与丑且万下丕丅丙 = val_4;
        if(val_4 < 50)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ParkourNinjaAchievementCompleted")) == true)
        {
                return;
        }
        
        if((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11) && (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2))
        {
                val_9 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世();
            val_11 = null;
            val_11 = null;
            val_13 = FirstPersonControlSharp.<>c.<>9__345_0;
            if(val_13 == null)
        {
                System.Action<System.Boolean> val_9 = null;
            val_13 = val_9;
            val_9 = new System.Action<System.Boolean>(object:  FirstPersonControlSharp.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FirstPersonControlSharp.<>c::丐不丆世一丛丒丏丌(bool 丐万丗丒下七丟丁三));
            FirstPersonControlSharp.<>c.<>9__345_0 = val_13;
        }
        
            val_9.丘丌万丂丟丒且丘上(专丅且丌一万且上七:  "CgkIr8rGkPIJEAIQAw", 不丕丝下丐丐丄丟丙:  1, 业丏丈世世世丞丒世:  val_9);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "ParkourNinjaAchievementCompleted", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 业丌上丙不丕丝丂丒(bool 丗丛不丕且与世丏丑 = False)
    {
        UnityEngine.Transform val_54;
        float val_55;
        float val_56;
        var val_57;
        UnityEngine.Vector2 val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        float val_64;
        float val_65;
        float val_66;
        float val_67;
        float val_71;
        if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                this.丕丅东丁丛丌上丛丌 = this.gliderMaxRotationMinigame.x;
            this.世丅上丁丂丝丆丗丞 = this.gliderRotationTimeMinigame;
        }
        
        if(丗丛不丕且与世丏丑 != false)
        {
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            val_55 = val_4.x;
            val_56 = val_4.z;
            this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_55, y = val_4.y, z = val_56, w = val_4.w};
            this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.丟三丂业丌丘丐丟世 = 0f;
            this.三丟丟丄丘丂七丆三 = 0f;
        }
        
        if(this.丑丞丒丟丞丟丆丁一 == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
        val_57 = null;
        val_57 = null;
        if(this.丛丗丑丝丕丌七与丆 == false)
        {
            goto label_21;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丒丘不丞丗丞丌不丏() == 0)
        {
            goto label_26;
        }
        
        this.playerCamera.丛不丟丙世万三万丆 = 5f;
        GliderSettings val_10 = this.丞丗丄丂丆业丈丑业.playerMoveC.丒丘不丞丗丞丌不丏();
        if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_33;
        }
        
        val_58 = this.丕丅东丁丛丌上丛丌;
        val_60 = val_7.x * val_58;
        val_61 = this.一与东三世丘丞丙丐 * val_4.w;
        this.丁丆丞万丂丌丐丑丕 = val_60;
        this.业丆东东丟丝万与下 = val_61;
        goto label_54;
        label_21:
        val_62 = JoystickController.丗三丄与丂丟丌专东 + 192 + 4;
        goto label_35;
        label_26:
        val_62 = JoystickController.丗三丄与丂丟丌专东 + 192 + 4;
        label_35:
        if(val_62 < 0)
        {
                val_62 = 0f;
        }
        
        float val_12 = this.七丞丗丙且上三丁世();
        this.一三丌与丑丑丞丈丟 = (val_62 > val_12) ? 1 : 0;
        if(val_62 > val_12)
        {
                float val_54 = 1.5f;
            val_54 = JoystickController.丗三丄与丂丟丌专东.value.sqrMagnitude * val_54;
            val_54 = val_54 + 5f;
            this.playerCamera.丛不丟丙世万三万丆 = val_54;
            val_64 = this.丟三丂业丌丘丐丟世;
            float val_18 = UnityEngine.Time.deltaTime;
            float val_55 = this.七且东丌丛丕丁丘丒;
            float val_19 = UnityEngine.Time.deltaTime * this.七且东丌丛丕丁丘丒;
            val_19 = this.丟三丂业丌丘丐丟世 - val_19;
            val_18 = val_18 * val_55;
            val_55 = val_64 + val_18;
            this.丟三丂业丌丘丐丟世 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Max(a:  this.playerCamera.下丁丂丐丙万丞丂丞 + (-15f), b:  0f), min:  val_19, max:  val_55);
        }
        else
        {
                this.playerCamera.丛不丟丙世万三万丆 = 3f;
            val_65 = this.丟三丂业丌丘丐丟世;
            if(val_65 > 0f)
        {
                float val_21 = UnityEngine.Time.deltaTime;
            val_21 = val_21 * this.七且东丌丛丕丁丘丒;
            val_65 = val_65 - val_21;
            this.丟三丂业丌丘丐丟世 = val_65;
        }
        
            if(val_65 < 0)
        {
                this.丟三丂业丌丘丐丟世 = 0f;
        }
        
        }
        
        float val_57 = 106019872 + (this.一三丌与丑丑丞丈丟) << 2;
        float val_22 = -(JoystickController.丗三丄与丂丟丌专东.value * val_57);
        if(this.三丟丟丄丘丂七丆三 != val_22)
        {
            goto label_46;
        }
        
        float val_56 = 0f;
        val_56 = this.三丟丟丄丘丂七丆三 + val_56;
        this.三丟丟丄丘丂七丆三 = val_56;
        goto label_56;
        label_46:
        val_57 = val_22 - this.三丟丟丄丘丂七丆三;
        float val_24 = UnityEngine.Time.deltaTime;
        float val_58 = 70f;
        val_24 = val_24 * val_58;
        val_58 = (UnityEngine.Mathf.Sign(f:  val_57)) * val_24;
        val_24 = this.三丟丟丄丘丂七丆三 + val_58;
        this.三丟丟丄丘丂七丆三 = val_24;
        if(val_58 >= 0)
        {
            goto label_50;
        }
        
        if(val_24 < 0)
        {
            goto label_51;
        }
        
        goto label_56;
        label_33:
        float val_59 = 0f;
        val_59 = val_59 * this.丕丅东丁丛丌上丛丌;
        val_61 = -(JoystickController.丗三丄与丂丟丌专东.value * val_4.w);
        val_58 = 0f;
        val_60 = this.世丅上丁丂丝丆丗丞;
        if(val_60 != 0f)
        {
            goto label_53;
        }
        
        this.丁丆丞万丂丌丐丑丕 = 0f;
        this.业丆东东丟丝万与下 = 0f;
        goto label_54;
        label_50:
        if((val_58 <= 0f) || (val_24 <= val_22))
        {
            goto label_56;
        }
        
        label_51:
        this.三丟丟丄丘丂七丆三 = val_22;
        label_56:
        float val_60 = 90f;
        val_60 = this.丟三丂业丌丘丐丟世 + val_60;
        UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.Euler(x:  val_60, y:  0f, z:  0f);
        UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Euler(x:  0f, y:  this.三丟丟丄丘丂七丆三, z:  0f);
        UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w}, rhs:  new UnityEngine.Quaternion() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w});
        val_55 = val_29.x;
        val_56 = val_29.z;
        this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_55, y = val_29.y, z = val_56, w = val_29.w};
        return;
        label_53:
        float val_61 = this.丁丆丞万丂丌丐丑丕;
        float val_32 = UnityEngine.Time.deltaTime;
        val_32 = val_32 / this.世丅上丁丂丝丆丗丞;
        val_32 = (UnityEngine.Mathf.Sign(f:  0f - val_61)) * val_32;
        val_61 = this.丕丅东丁丛丌上丛丌 * val_32;
        float val_35 = UnityEngine.Time.deltaTime;
        float val_62 = this.世丅上丁丂丝丆丗丞;
        float val_63 = this.丁丆丞万丂丌丐丑丕;
        val_35 = val_35 / val_62;
        val_35 = (UnityEngine.Mathf.Sign(f:  0f - this.业丆东东丟丝万与下)) * val_35;
        val_62 = 0f * val_35;
        val_63 = val_61 + val_63;
        val_35 = val_62 + this.业丆东东丟丝万与下;
        this.丁丆丞万丂丌丐丑丕 = val_63;
        this.业丆东东丟丝万与下 = val_35;
        if(val_61 >= 0)
        {
            goto label_66;
        }
        
        val_66 = 0f;
        if(val_63 < 0)
        {
            goto label_67;
        }
        
        goto label_70;
        label_66:
        if(val_61 <= 0f)
        {
            goto label_70;
        }
        
        val_66 = 0f;
        if(val_63 <= val_66)
        {
            goto label_70;
        }
        
        label_67:
        this.丁丆丞万丂丌丐丑丕 = val_66;
        label_70:
        if(val_62 >= 0)
        {
            goto label_71;
        }
        
        val_67 = 0f;
        if(val_35 < 0)
        {
            goto label_72;
        }
        
        goto label_75;
        label_71:
        if(val_62 <= 0f)
        {
            goto label_75;
        }
        
        val_67 = 0f;
        if(val_35 <= val_67)
        {
            goto label_75;
        }
        
        label_72:
        this.业丆东东丟丝万与下 = val_67;
        label_75:
        UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_60 = val_38.x;
        val_61 = val_38.y;
        val_58 = val_38.z;
        val_59 = val_38.w;
        this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_60, y = val_61, z = val_58, w = val_59};
        label_54:
        UnityEngine.Transform val_40 = this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent;
        UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.identity;
        val_40.localRotation = new UnityEngine.Quaternion() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w};
        val_40.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_44 = val_10.上七丑丗世丛万不丑.rotationPoint.position;
        bool val_45 = GameConnect.丁丁丗丐东丄丞一丛();
        if(val_10.上七丑丗世丛万不丑.rotationPoint == null)
        {
            goto label_96;
        }
        
        if(val_45 == false)
        {
            goto label_97;
        }
        
        label_99:
        UnityEngine.Vector3 val_46 = val_10.上七丑丗世丛万不丑.rotationPoint.up;
        goto label_98;
        label_96:
        if(val_45 == true)
        {
            goto label_99;
        }
        
        label_97:
        UnityEngine.Vector3 val_47 = val_10.上七丑丗世丛万不丑.rotationPoint.forward;
        label_98:
        this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.RotateAround(point:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, axis:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, angle:  this.业丆东东丟丝万与下);
        UnityEngine.Vector3 val_50 = val_10.上七丑丗世丛万不丑.rotationPoint.position;
        val_54 = val_10.上七丑丗世丛万不丑.rotationPoint;
        val_55 = val_50.x;
        val_56 = val_50.z;
        UnityEngine.Vector3 val_51 = val_54.right;
        val_64 = val_51.y;
        val_71 = 0f;
        if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                val_71 = this.gliderStartRotationXMinigame;
        }
        
        this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.RotateAround(point:  new UnityEngine.Vector3() {x = val_55, y = val_50.y, z = val_56}, axis:  new UnityEngine.Vector3() {x = val_51.x, y = val_64, z = val_51.z}, angle:  this.丁丆丞万丂丌丐丑丕 + val_71);
    }
    private void 世丂丝且七与丁丒丂(string 丘丘丅东丆丗世上丟)
    {
        this.丏七世丐丂丝丞丛上 = 丘丘丅东丆丗世上丟;
    }
    private void 丘丗与业丅业下丕丅(float 丐丌一丈丒一丕丐丙)
    {
        var val_12;
        var val_13;
        if(this.丛丐世丟丆丙专丛一 == null)
        {
            goto label_1;
        }
        
        label_39:
        val_12 = 0;
        goto label_2;
        label_10:
        float val_2 = UnityEngine.Mathf.Max(a:  0.2f, b:  丐丌一丈丒一丕丐丙);
        val_2 = this.丞丗丄丂丆业丈丑业.playerMoveC.丘丕东一丒丞丅丒丄 / val_2;
        this.丛丐世丟丆丙专丛一.Item[0].velocityScale = val_2;
        val_12 = 1;
        label_2:
        if(val_12 < this.丛丐世丟丆丙专丛一.Count)
        {
            goto label_10;
        }
        
        return;
        label_1:
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.万上东丑上丁世丐丘 == 0)
        {
                return;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丒丘不丞丗丞丌不丏() == 0)
        {
                return;
        }
        
        GliderSettings val_7 = this.丞丗丄丂丆业丈丑业.playerMoveC.丒丘不丞丗丞丌不丏();
        if(val_7.丛丞丛丘下世业丅丑 == false)
        {
                return;
        }
        
        this.丛丐世丟丆丙专丛一 = new System.Collections.Generic.List<UnityEngine.ParticleSystemRenderer>();
        GliderSettings val_9 = this.丞丗丄丂丆业丈丑业.playerMoveC.丒丘不丞丗丞丌不丏();
        val_13 = 0;
        goto label_29;
        label_38:
        UnityEngine.Transform val_12 = val_9.trailPoints[0];
        if(val_12 != 0)
        {
                T[] val_11 = val_12.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>();
            if(val_11 != null)
        {
                this.丛丐世丟丆丙专丛一.AddRange(collection:  val_11);
        }
        
        }
        
        val_13 = 1;
        label_29:
        if(val_13 < val_9.trailPoints.Length)
        {
            goto label_38;
        }
        
        goto label_39;
    }
    private void 丙丒丘与不三业丅上(float 丐丌一丈丒一丕丐丙)
    {
        var val_7;
        var val_8;
        if(this.丄下丅不且丐专东丁 != null)
        {
            goto label_1;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.万上东丑上丁世丐丘 == 0)
        {
                return;
        }
        
        this.丄下丅不且丐专东丁 = new System.Collections.Generic.List<UnityEngine.ParticleSystemRenderer>();
        val_7 = 0;
        goto label_7;
        label_16:
        T[] val_3 = this.丞丗丄丂丆业丈丑业.trailPoints[0].GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>();
        if(val_3 != null)
        {
                this.丄下丅不且丐专东丁.AddRange(collection:  val_3);
        }
        
        val_7 = 1;
        label_7:
        if(val_7 < this.丞丗丄丂丆业丈丑业.trailPoints.Length)
        {
            goto label_16;
        }
        
        label_1:
        val_8 = 0;
        goto label_17;
        label_25:
        float val_5 = UnityEngine.Mathf.Max(a:  0.2f, b:  丐丌一丈丒一丕丐丙);
        val_5 = this.丞丗丄丂丆业丈丑业.playerMoveC.丘丕东一丒丞丅丒丄 / val_5;
        this.丄下丅不且丐专东丁.Item[0].velocityScale = val_5;
        val_8 = 1;
        label_17:
        if(val_8 < this.丄下丅不且丐专东丁.Count)
        {
            goto label_25;
        }
    
    }
    private void Start()
    {
        var val_58;
        float val_59;
        var val_60;
        var val_61;
        var val_62;
        bool val_63;
        var val_64;
        Player_move_c val_65;
        var val_67;
        var val_68;
        PhotonView val_1 = this.GetComponent<PhotonView>();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start Start FirstPersonControlSharp " + val_1.ownerId);
        this.世丟丈丏丕万丝丆万 = this.GetComponent<UnityEngine.CharacterController>();
        if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_80;
        }
        
        this.丈丘且丄丝世且三上();
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_10;
        }
        
        }
        
        this.万丗与与丘丗丑丁丈 = true;
        val_58 = null;
        val_58 = null;
        val_59 = FirstPersonControlSharp.丗丟丈一丁七丛丞丙;
        label_82:
        this.世丟丈丏丕万丝丆万.slopeLimit = val_59;
        label_80:
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_19;
        }
        
        }
        
        val_60 = 0;
        goto label_20;
        label_28:
        this.丞丗丄丂丆业丈丑业.trailPoints[0].gameObject.SetActive(value:  false);
        val_60 = 1;
        label_20:
        if(val_60 < this.丞丗丄丂丆业丈丑业.trailPoints.Length)
        {
            goto label_28;
        }
        
        label_19:
        this.<丗专丟丑万丙与专丌>k__BackingField = this.GetComponent<UnityEngine.Transform>();
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == true)
        {
            goto label_40;
        }
        
        }
        
        if(this.detectHeadColliderHit != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.detectHeadColliderHit);
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == true)
        {
            goto label_40;
        }
        
        }
        
        if(this.dustParticle != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.dustParticle);
        }
        
        label_40:
        if(this.丞丗丄丂丆业丈丑业.armsRoot != 0)
        {
                if(this.丞丗丄丂丆业丈丑业.playerMoveC.丒丘不丞丗丞丌不丏() == 0)
        {
                this.丞丗丄丂丆业丈丑业.armsRoot.SetActive(value:  false);
        }
        
        }
        
        val_61 = null;
        val_61 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_57;
        }
        
        }
        
        val_62 = null;
        val_62 = null;
        val_63 = 1;
        if(GameController.mode.IsThirdPersonView == true)
        {
            goto label_68;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_67;
        }
        
        if(((this.<与丝丁不且东丘丙丞>k__BackingField) != false) && (this.且丆丅丏丌丗丛丄丌 != true))
        {
                if(this.丑丞丒丟丞丟丆丁一 == false)
        {
            goto label_67;
        }
        
        }
        
        val_63 = 1;
        goto label_68;
        label_57:
        this.firstPersonCamera.gameObject.SetActive(value:  false);
        this.世丟丈丏丕万丝丆万.enabled = false;
        goto label_126;
        label_10:
        val_64 = null;
        val_64 = null;
        if(((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  UnityEngine.Application.loadedLevelName)) == 0) || (val_18.playerSurfacesSlidingEnabled == false))
        {
            goto label_80;
        }
        
        this.万丗与与丘丗丑丁丈 = true;
        if(this.世丟丈丏丕万丝丆万 != null)
        {
            goto label_82;
        }
        
        goto label_82;
        label_67:
        val_63 = this.丝丝丐业不业与丐下;
        label_68:
        this.上且丈丒与专上丝业(丆丝下丒上一丙丄丞:  (val_63 == true) ? (1 + 1) : 1);
        if((GameConnect.丆丕丒与丂七与下上() != true) && (GameConnect.丛专丌且丕不专丈下() != true))
        {
                if(GameConnect.丁丁丗丐东丄丞一丛() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_94;
        }
        
        }
        
        }
        
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  7);
        label_241:
        if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                val_59 = this.camFovGliderMinigame;
        }
        
        if((GameConnect.丙丌丒丈东七丒上丌() == false) || (this.丌且下丕下下丌万丞 == false))
        {
            goto label_102;
        }
        
        if(this._moveC.丟三丏丅世一丟丟上 == 0)
        {
            goto label_126;
        }
        
        this.丞丗丄丂丆业丈丑业.playerMoveC.上下丝且丛丐丒丂丝(与丟丅七丞且且丛丕:  this._moveC.丟三丏丅世一丟丟上.万丑一东丅上丗一东(), 专丞上七七且丝七丗:  0);
        this._moveC.丟三丏丅世一丟丟上.丄丑不业东丗不不丁();
        goto label_126;
        label_102:
        if((GameConnect.一业上七丟业且业丙() == false) || (this.丌且下丕下下丌万丞 == false))
        {
            goto label_117;
        }
        
        val_65 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        string val_30 = RedLightController.Instance.丞七丕且丈丙上万下();
        goto label_120;
        label_117:
        if((GameConnect.丛专丌且丕不专丈下() == true) || (GameConnect.丆丕丒与丂七与下上() == true))
        {
            goto label_126;
        }
        
        val_65 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        label_120:
        val_65.上下丝且丛丐丒丂丝(与丟丅七丞且且丛丕:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈(), 专丞上七七且丝七丗:  0);
        label_126:
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
            goto label_132;
        }
        
        }
        
        this.丛丄世丑丐一丂不万 = UnityEngine.PlayerPrefs.GetInt(key:  "NewbieJumperAchievement", defaultValue:  0);
        this.丂与丑且万下丕丅丙 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "NinjaJumpsCount", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        label_132:
        PhotonView val_36 = this.GetComponent<PhotonView>();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "End Start FirstPersonControlSharp " + val_36.ownerId);
        val_67 = null;
        val_67 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (this.丌且下丕下下丌万丞 != false))
        {
                if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                this.丞丗丄丂丆业丈丑业.playerMoveC.丟万一丅丈七丙丛丟(丆丟万丈与三丑且丆:  丛且丗丌丏下七下丈.七且丐丅与丝丙一丄(), 专丞上七七且丝七丗:  0);
            this.丞丗丄丂丆业丈丑业.playerMoveC.一一丝专东丘丅一丌(丘丘丘专业丁丙丘丁:  丛且丗丌丏下七下丈.万丗丐不不三丁且丟(), 专丞上七七且丝七丗:  0);
            this.丙世丙丘丁不丈且丑(丌丟丝丙丑上丟业丘:  丛且丗丌丏下七下丈.万丗丐不不三丁且丟(), 丗丁丟与丞与丏丐丂:  丛且丗丌丏下七下丈.丑丈业上万一丁丛丂(七丙丈丆丕丄丐业丟:  丛且丗丌丏下七下丈.万丗丐不不三丁且丟()));
            this.丝丆丁丅丐丂丞丟丌();
        }
        
        }
        
        val_68 = null;
        val_68 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (this.丌且下丕下下丌万丞 != false))
        {
                if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                this.七丈丟世丄下丂丝丏();
        }
        
        }
        
        丟东世三丁丏丛下丆[] val_45 = new 丟东世三丁丏丛下丆[4];
        string[] val_46 = new string[3];
        val_46[0] = "show_ui_pause";
        val_46[1] = "show_ui_scoreContainer";
        val_46[2] = "show_ui_rightTopAnchor";
        val_45[0] = new 丟东世三丁丏丛下丆(丕业且东下丄丅三丛:  val_46, 丙丐丛上且丆丅三丏:  true);
        string[] val_48 = new string[3];
        val_48[0] = "show_ui_chat";
        val_48[1] = "show_ui_killStreaks";
        val_48[2] = "show_ui_scoreMessages";
        val_45[1] = new 丟东世三丁丏丛下丆(丕业且东下丄丅三丛:  val_48, 丙丐丛上且丆丅三丏:  true);
        string[] val_50 = new string[3];
        val_50[0] = "show_ui_weaponToggles";
        val_50[1] = "show_ui_leftJoystickPanel";
        val_50[2] = "show_ui_rightJoystickPanel";
        val_45[2] = new 丟东世三丁丏丛下丆(丕业且东下丄丅三丛:  val_50, 丙丐丛上且丆丅三丏:  true);
        string[] val_52 = new string[9];
        val_52[0] = "show_ui_pause";
        val_52[1] = "show_ui_scoreContainer";
        val_52[2] = "show_ui_rightTopAnchor";
        val_52[3] = "show_ui_chat";
        val_52[4] = "show_ui_killStreaks";
        val_52[5] = "show_ui_scoreMessages";
        val_52[6] = "show_ui_weaponToggles";
        val_52[7] = "show_ui_leftJoystickPanel";
        val_52[8] = "show_ui_rightJoystickPanel";
        val_45[3] = new 丟东世三丁丏丛下丆(丕业且东下丄丅三丛:  val_52, 丙丐丛上且丆丅三丏:  true);
        this.三万丟丁万丄一三丛 = val_45;
        return;
        label_94:
        if((this.<且丂一与且丐丕丗丈>k__BackingField) != 2)
        {
            goto label_241;
        }
        
        this.areaVisitMonitor.parent = this.transform;
        if(this.且丆丅丏丌丗丛丄丌 == false)
        {
            goto label_231;
        }
        
        this.丅专丟上丗且丈丛上(丆丝下丒上一丙丄丞:  6);
        this.丞丗丄丂丆业丈丑业.playerMoveC.丟万一丅丈七丙丛丟(丆丟万丈与三丑且丆:  丛且丗丌丏下七下丈.七且丐丅与丝丙一丄(), 专丞上七七且丝七丗:  0);
        this.丞丗丄丂丆业丈丑业.playerMoveC.一一丝专东丘丅一丌(丘丘丘专业丁丙丘丁:  丛且丗丌丏下七下丈.万丗丐不不三丁且丟(), 专丞上七七且丝七丗:  0);
        goto label_241;
        label_231:
        UnityEngine.Quaternion val_57 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        if(this.playerCamera != null)
        {
            goto label_241;
        }
        
        goto label_241;
    }
    internal void 七丈丟世丄下丂丝丏()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Quaternion val_4 = this.transform.rotation;
        丅丒丗丑丒丙丛不丆.业丕丝丝万丕丛下三(丟丈一下东业一丝丆:  "RacingCar", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, 不丝丄丒丌丐一一与:  0).GetComponent<VehicleController>().七东丗丂世三七丞丌(丞丅上丏丂且下丅与:  this.丞丗丄丂丆业丈丑业.playerMoveC.photonView.ownerId, 与丈丂丂一丁业丂上:  0, 丅丏丟一不丛丝丟丗:  true, 丛丑丘不世七丛且丙:  false);
    }
    public void SetCurrentCableCar(CableCar 丁丂专业丁丅丅丈丙)
    {
        this.currentCableCar = 丁丂专业丁丅丅丈丙;
    }
    internal bool 与丞丄专丌世丕万丈()
    {
        var val_3;
        if(((this.下丅丂丘丏丟世且丐 == true) || (this.丛丗丑丝丕丌七与丆 == true)) || (this.丑丞丒丟丞丟丆丁一 == true))
        {
                return (bool)0 & 1;
        }
        
        val_3 = null;
        val_3 = null;
        if((((与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 != true) && (this.丞丗丄丂丆业丈丑业.playerMoveC.丆不业专丑三万丞丂 != true)) && (this.丞丗丄丂丆业丈丑业.playerMoveC.东丗丒丝丐且丞丄丏 != true)) && (this._moveC.东丑丌丄丝世丞丘三 != true))
        {
                if(this.丝丝丟丝世且丆丞世 == false)
        {
            goto label_15;
        }
        
        }
        
        return (bool)0 & 1;
        label_15:
        bool val_3 = this.丞丗丄丂丆业丈丑业.playerMoveC.丂七一业下丈业丕丒.IsDead() ^ 1;
        return (bool)0 & 1;
    }
    internal void 世东丈七丕丟上丗且(CableCar 丁丂专业丁丅丅丈丙)
    {
        this.且不一且丗东丁丕丙(丙业与丙丗丝不丈东:  false);
        this.丆不丟丕万丑且丘丏 = 0f;
        this.下不丁丗丑丈丌东东 = false;
        this.且丆丅丏丌丗丛丄丌 = false;
        this.cableCarMoving = true;
        this.丑丞丒丟丞丟丆丁一 = false;
        this.丛丗丑丝丕丌七与丆 = false;
        this.世丅万一丟丆东业丏 = this.StartCoroutine(routine:  this.万丗丟丁丁丈三专三());
        this.丞丗丄丂丆业丈丑业.playerMoveC.SetDefaultAnimatorController();
        this.丞丐丒丕不丐不下丘();
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        this.丞丐丒丁丌丘丄下丄 = this.currentCableCar.cableStartSpeed;
    }
    private void 专丌丑丘丂丅万丐丁()
    {
        Player_move_c val_25;
        var val_26;
        float val_27;
        float val_28;
        CableCar val_29;
        float val_30;
        float val_31;
        float val_32;
        val_25 = this;
        if(this.cableCarMoving == false)
        {
                return;
        }
        
        if(this.丘丈三且万丗丘丗三() != false)
        {
                val_26 = null;
            val_26 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
            val_25 = this.丞丗丄丂丆业丈丑业.playerMoveC;
            val_25.丑丒东业丕专丈与丆(丘七丐下一丐丒丗下:  false, 专丞上七七且丝七丗:  0);
            return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_2;
        mem[1152921540417140308] = val_2.y;
        mem[1152921540417140312] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.世丂业专专丕丗丘丕 = val_3;
        mem[1152921540417139820] = val_3.y;
        mem[1152921540417139824] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_27 = val_4.x;
        val_28 = val_4.z;
        bool val_5 = this.世丟丈丏丕万丝丆万.SimpleMove(speed:  new UnityEngine.Vector3() {x = val_27, y = val_4.y, z = val_28});
        if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if(this.下不丁丗丑丈丌东东 == false)
        {
            goto label_14;
        }
        
        val_29 = this.currentCableCar;
        if(this.丆不丟丕万丑且丘丏 >= 0)
        {
            goto label_16;
        }
        
        UnityEngine.Vector3 val_6 = val_29.startPos;
        val_29 = this.currentCableCar;
        UnityEngine.Vector3 val_7 = val_29.endPos;
        val_30 = val_7.y;
        val_31 = val_7.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_30, z = val_31}, t:  this.丆不丟丕万丑且丘丏);
        this.<丗专丟丑万丙与专丌>k__BackingField.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_32 = this.currentCableCar.cableTopSpeed;
        if(this.丞丐丒丁丌丘丄下丄 < 0)
        {
                float val_25 = this.丞丐丒丁丌丘丄下丄;
            float val_9 = UnityEngine.Time.deltaTime;
            val_9 = this.currentCableCar.cableAcceleration * val_9;
            val_25 = val_25 + val_9;
            this.丞丐丒丁丌丘丄下丄 = val_25;
            val_32 = this.currentCableCar.cableTopSpeed;
            if(val_25 > val_32)
        {
                this.丞丐丒丁丌丘丄下丄 = this.currentCableCar.cableTopSpeed;
        }
        
        }
        
        val_28 = this.丞丐丒丁丌丘丄下丄;
        val_27 = this.currentCableCar.length;
        float val_11 = UnityEngine.Time.deltaTime;
        val_11 = (val_28 / val_27) * val_11;
        val_11 = this.丆不丟丕万丑且丘丏 + val_11;
        this.丆不丟丕万丑且丘丏 = val_11;
        if(val_11 <= 1f)
        {
                return;
        }
        
        this.丆不丟丕万丑且丘丏 = 1f;
        return;
        label_14:
        UnityEngine.Vector3 val_13 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        UnityEngine.Vector3 val_14 = this.currentCableCar.startPos;
        val_29 = this.<丗专丟丑万丙与专丌>k__BackingField;
        UnityEngine.Vector3 val_15 = val_29.position;
        val_31 = val_15.x;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_31, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  4f);
        val_30 = val_17.z;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_30}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        this.<丗专丟丑万丙与专丌>k__BackingField.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Vector3 val_21 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        val_27 = val_21.x;
        val_28 = val_21.z;
        UnityEngine.Vector3 val_22 = this.currentCableCar.startPos;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_27, y = val_21.y, z = val_28}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z})) >= 0)
        {
                return;
        }
        
        this.丒且不上万丌不专三();
        return;
        label_16:
        UnityEngine.Vector3 val_24 = val_29.endPos;
        val_27 = val_24.x;
        val_28 = val_24.z;
        this.<丗专丟丑万丙与专丌>k__BackingField.position = new UnityEngine.Vector3() {x = val_27, y = val_24.y, z = val_28};
        this.与不上丝三业三丄丟();
    }
    private void 丒且不上万丌不专三()
    {
        SkinName val_3;
        if(this.丌且下丕下下丌万丞 != false)
        {
                UnityEngine.Vector3 val_1 = this.currentCableCar.startPos;
            this.<丗专丟丑万丙与专丌>k__BackingField.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.下不丁丗丑丈丌东东 = true;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_3 = this.丞丗丄丂丆业丈丑业;
        if(this.丞丗丄丂丆业丈丑业 != null)
        {
            goto label_7;
        }
        
        val_3 = this.丞丗丄丂丆业丈丑业;
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_7:
        this.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.PlayOneShot(clip:  this.丞丗丄丂丆业丈丑业.cableCarAttachAudio);
        return;
        label_8:
    }
    internal void 与不上丝三业三丄丟()
    {
        SkinName val_6;
        if(this.cableCarMoving == false)
        {
                return;
        }
        
        this.cableCarMoving = false;
        this.丞丐丒丁丌丘丄下丄 = 0f;
        this.currentCableCar = 0;
        this.下不丁丗丑丈丌东东 = false;
        if(this.丌且下丕下下丌万丞 != false)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.丏丄业丆业丅且丏丗 = val_1;
            mem[1152921540417503572] = val_1.y;
            mem[1152921540417503576] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_2;
            mem[1152921540417503084] = val_2.y;
            mem[1152921540417503088] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            bool val_4 = this.世丟丈丏丕万丝丆万.SimpleMove(speed:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this.世丅万一丟丆东业丏 != null)
        {
                this.StopCoroutine(routine:  this.世丅万一丟丆东业丏);
        }
        
        val_6 = this.丞丗丄丂丆业丈丑业;
        if(this.丞丗丄丂丆业丈丑业 != null)
        {
            goto label_10;
        }
        
        val_6 = this.丞丗丄丂丆业丈丑业;
        if(val_6 == null)
        {
            goto label_11;
        }
        
        label_10:
        this.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.PlayOneShot(clip:  this.丞丗丄丂丆业丈丑业.cableCarDetachAudio);
        return;
        label_11:
    }
    private System.Collections.IEnumerator 万丗丟丁丁丈三专三()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FirstPersonControlSharp.不不专上丈丌业业丞(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 七三丟七丑专下万丗(bool 丝且与丘七丆专且丂)
    {
        UnityEngine.Object val_21;
        UnityEngine.GameObject val_22;
        if(this.一丆世业上丄专下丟() == false)
        {
                return;
        }
        
        UnityEngine.Object val_3 = (丝且与丘七丆专且丂 != true) ? this.camTweenerLanding : this.camTweenerJump;
        val_21 = mem[丝且与丘七丆专且丂 != true ? this.weaponTweenerLanding : this.weaponTweenerJump];
        val_21 = (丝且与丘七丆专且丂 != true) ? this.weaponTweenerLanding : this.weaponTweenerJump;
        if(val_3 != 0)
        {
                val_22 = mem[this.camTweenerJump];
            if(val_22.enabled != true)
        {
                val_22 = mem[this.camTweenerLanding];
            if(val_22.enabled != true)
        {
                val_22 = this.丞丗丄丂丆业丈丑业.playerMoveC.丌下不丐丅丗专丙且;
            if(val_22 == 0)
        {
                float val_21 = (this.丞丗丄丂丆业丈丑业.playerAnimation.一七丟丘丕且一丁丘() != true) ? this.jumpCamEffectMech : this.jumpCamEffectWeapon;
            val_21 = (丝且与丘七丆专且丂 != true ? this.camTweenerLanding : this.camTweenerJump + 124) + val_21;
            mem2[0] = val_21;
            float val_12 = PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三();
            val_12 = ((丝且与丘七丆专且丂 != true) ? this.landingEffectDuration : this.jumpEffectDuration) / val_12;
            mem2[0] = val_12;
            mem[this.camTweenerJump].ResetToBeginning();
            val_22 = mem[this.camTweenerLanding];
            val_22.ResetToBeginning();
            val_3.PlayForward();
        }
        
        }
        
        }
        
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerAnimation.一七丟丘丕且一丁丘() == true)
        {
                return;
        }
        
        if(val_21 == 0)
        {
                return;
        }
        
        if(mem[this.weaponTweenerJump].enabled == true)
        {
                return;
        }
        
        if(mem[this.weaponTweenerLanding].enabled == true)
        {
                return;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丌下不丐丅丗专丙且 != 0)
        {
                return;
        }
        
        float val_20 = PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三();
        val_20 = ((丝且与丘七丆专且丂 != true) ? this.landingEffectDuration : this.jumpEffectDuration) / val_20;
        mem2[0] = val_20;
        mem[this.weaponTweenerJump].ResetToBeginning();
        mem[this.weaponTweenerLanding].ResetToBeginning();
        val_21.PlayForward();
    }
    internal void 业专丌三丒丌业上丑()
    {
        if(this.camTweenerFallDamage == 0)
        {
                return;
        }
        
        if(this.camTweenerFallDamage.enabled == true)
        {
                return;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丌下不丐丅丗专丙且 != 0)
        {
                return;
        }
        
        float val_7 = System.Math.Abs(UnityEngine.Random.Range(min:  -15f, max:  15f));
        val_7 = 15f - val_7;
        val_7 = val_7 * (((UnityEngine.Random.Range(min:  0, max:  2)) == 1) ? -1f : 1f);
        this.camTweenerFallDamage.to = 0;
        mem2[0] = 0;
        this.camTweenerFallDamage.ResetToBeginning();
        this = this.camTweenerFallDamage;
        this.PlayForward();
    }
    internal void 丆丕丗丘丛三下且与()
    {
        if(this.weaponTweenerJump != 0)
        {
                this.weaponTweenerJump.ResetToBeginning();
        }
        
        if(this.weaponTweenerLanding != 0)
        {
                this.weaponTweenerLanding.ResetToBeginning();
        }
        
        if(this.camTweenerFallDamage == 0)
        {
                return;
        }
        
        this.camTweenerFallDamage.ResetToBeginning();
    }
    internal bool 丄万下上丕丕丗丑丅()
    {
        if((GameConnect.万不丒丌丙万丗东不() == false) || (this.丏丛丞丗丈七丏丈七 == false))
        {
                return GameConnect.丝丆世丕丂丄万东且();
        }
        
        return true;
    }
    private void Update()
    {
        UnityEngine.Transform val_568;
        UnityEngine.Transform val_569;
        float val_571;
        float val_572;
        float val_573;
        bool val_574;
        var val_575;
        float val_576;
        bool val_577;
        float val_580;
        float val_581;
        float val_582;
        float val_586;
        float val_587;
        float val_588;
        float val_589;
        float val_590;
        var val_591;
        var val_592;
        var val_594;
        var val_595;
        var val_596;
        var val_597;
        var val_598;
        var val_599;
        var val_600;
        var val_601;
        var val_602;
        var val_603;
        var val_604;
        var val_605;
        var val_606;
        var val_607;
        var val_608;
        var val_609;
        var val_610;
        var val_611;
        var val_612;
        var val_613;
        var val_614;
        var val_615;
        float val_618;
        float val_619;
        float val_620;
        val_569 = this;
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
        bool val_562 = this.丞丗丄丂丆业丈丑业.playerMoveC.万丝一万丐且丌业丛;
        val_562 = val_562 + 3;
        var val_563 = ~val_562;
        val_563 = val_563 & 3;
        if(val_563 != 0)
        {
                return;
        }
        
        this.丝丌业丌上丞上七不 = 0f;
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                this.丏丛丞丗丈七丏丈七 = true;
        }
        
        this.专丌丑丘丂丅万丐丁();
        if(this.世丟丈丏丕万丝丆万.isGrounded != true)
        {
                if(this.下上且丏世丈丞丏东() != true)
        {
                if(this.cableCarMoving == false)
        {
            goto label_11;
        }
        
        }
        
        }
        
        this.丅下不丏丅丛世丗七 = 0f;
        this.丕一下下七丒丂丘丁 = this.丗丌不丁丁丁与丐与;
        label_117:
        if((((this.丄万下上丕丕丗丑丅() != false) && (this.丅下不丏丅丛世丗七 > this.丗丌不丁丁丁与丐与)) && (与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 != true)) && (this.下丅丂丘丏丟世且丐 != true))
        {
                UnityEngine.Vector3 val_6 = this.transform.position;
            float val_564 = this.一不万丈专丄七世丕;
            val_564 = val_564 - this.freePlayHeightDifferenceForFly;
            if(val_6.y < 0)
        {
                UnityEngine.Vector3 val_8 = this.transform.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_571 = val_10.x;
            val_572 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
            val_573 = val_11.y;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_571, y = val_10.y, z = val_572}, direction:  new UnityEngine.Vector3() {x = val_11.x, y = val_573, z = val_11.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1000f, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) != false)
        {
                val_568 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  0.root.gameObject).Equals(value:  "PlayerBattleRoyale")) != true)
        {
                if((((丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  0.root.gameObject).Contains(value:  "Trampolin")) != true) && (this.丝三丟且三三与且世 <= 0)) && ((this._moveC.丂七一业下丈业丕丒.IsDead() != true) && (this._moveC.丆不业专丑三万丞丂 != true)))
        {
                if(this.丑丞丒丟丞丟丆丁一 != true)
        {
                if(this.丛丗丑丝丕丌七与丆 == false)
        {
            goto label_45;
        }
        
        }
        
            if(((丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  0.root.gameObject).Contains(value:  "Trampolin")) != true) && (this.丝三丟且三三与且世 <= 0))
        {
                if(this._moveC.丂七一业下丈业丕丒.IsDead() != true)
        {
                if(this._moveC.丆不业专丑三万丞丂 == false)
        {
            goto label_1277;
        }
        
        }
        
        }
        
            UnityEngine.Debug.LogError(message:  "Grounding because of special situation");
            this.一丘丛不丞丂七丝不(丕丞七丑丙丙丅丌丂:  true);
        }
        
        }
        
        }
        
        }
        
        }
        
        label_1277:
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (this.丌且下丕下下丌万丞 != false))
        {
                if((GameConnect.万不丒丌丙万丗东不() != false) && (this.万丆丏下专一业与丅 != false))
        {
                this.且丘丘丌丁丂丒丟丈();
        }
        
        }
        
        if((this.世丟丈丏丕万丝丆万.enabled != true) && (this.且丆丅丏丌丗丛丄丌 != true))
        {
                if(this.下丅丂丘丏丟世且丐 == false)
        {
                return;
        }
        
        }
        
        val_574 = 1152921505077186560;
        val_575 = 1152921504848912384;
        if(JoystickController.丗三丄与丂丟丌专东 == 0)
        {
                return;
        }
        
        if(JoystickController.丘万丏三丏丑世丐丏 == 0)
        {
                return;
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                if(this._moveC.与丏下丝万上三丛不() == false)
        {
            goto label_85;
        }
        
        }
        
        this.不丕丐七丞丄丕丒丙 = 0f;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
        this.丒上七丘且丕不七丙 = val_34;
        mem[1152921540419633856] = val_34.y;
        mem[1152921540419633860] = val_34.z;
        label_85:
        if(((GameConnect.万不丒丌丙万丗东不() != false) && ((this.<与丝丁不且东丘丙丞>k__BackingField) != false)) && (this.七七七丗丕丒三丄一 != false))
        {
                if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                this.七七七丗丕丒三丄一 = false;
            this.上且丈丒与专上丝业(丆丝下丒上一丙丄丞:  1);
        }
        
        }
        
        if((this.丑丞丒丟丞丟丆丁一 == false) || (GameConnect.丁丁丗丐东丄丞一丛() == true))
        {
            goto label_126;
        }
        
        UnityEngine.Vector3 val_39 = this.transform.position;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
        val_572 = val_41.y;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.down;
        val_573 = val_42.x;
        val_576 = val_42.z;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_41.x, y = val_572, z = val_41.z}, direction:  new UnityEngine.Vector3() {x = val_573, y = val_42.y, z = val_576}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1000f, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) != false)
        {
                if((丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  0.root.gameObject).Equals(value:  "PlayerBattleRoyale")) != true)
        {
                float val_49 = 0.targetValue;
        }
        
        }
        
        if(this.丄万下上丕丕丗丑丅() == false)
        {
            goto label_111;
        }
        
        goto label_112;
        label_11:
        if(this.丅下不丏丅丛世丗七 == 0f)
        {
                UnityEngine.Vector3 val_52 = this.transform.position;
            this.一不万丈专丄七世丕 = val_52.y;
            this.丕一下下七丒丂丘丁 = this.丗丌不丁丁丁与丐与;
        }
        
        float val_53 = UnityEngine.Time.deltaTime;
        val_53 = this.丅下不丏丅丛世丗七 + val_53;
        this.丅下不丏丅丛世丗七 = val_53;
        float val_54 = UnityEngine.Time.deltaTime;
        val_54 = this.丕一下下七丒丂丘丁 - val_54;
        this.丕一下下七丒丂丘丁 = val_54;
        if(val_54 > 0f)
        {
            goto label_117;
        }
        
        val_54 = val_54 + this.丗丌不丁丁丁与丐与;
        this.丕一下下七丒丂丘丁 = val_54;
        UnityEngine.Vector3 val_56 = this.transform.position;
        this.一不万丈专丄七世丕 = val_56.y;
        goto label_117;
        label_111:
        label_112:
        if(val_49 < 0)
        {
                this.上丛七丂丐下一丐丗 = false;
            if(this.丛丗丑丝丕丌七与丆 != true)
        {
                this.丈下丘万丙丌且丄且();
        }
        
        }
        
        if(this.丄万下上丕丕丗丑丅() != false)
        {
            
        }
        
        if(val_49 < 0)
        {
                this.一丘丛不丞丂七丝不(丕丞七丑丙丙丅丌丂:  true);
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded == true)
        {
            goto label_124;
        }
        
        UnityEngine.Vector3 val_59 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        if(val_59.y != this.丗七丘与丟万丆丛丁)
        {
            goto label_126;
        }
        
        label_124:
        this.一丘丛不丞丂七丝不(丕丞七丑丙丙丅丌丂:  true);
        label_126:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_152;
        }
        
        BattleRoyaleController val_61 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_61.road == 0)
        {
            goto label_152;
        }
        
        UnityEngine.Vector3 val_63 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        if(val_63.y <= 100f)
        {
            goto label_137;
        }
        
        UnityEngine.QualitySettings.lodBias = 0.8f;
        BattleRoyaleController val_64 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_65 = val_64.shutle.position;
        UnityEngine.Vector3 val_66 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        val_573 = val_66.y;
        BattleRoyaleController val_67 = BattleRoyaleController.丑七不且上丗丁一世();
        BattleRoyaleController val_68 = BattleRoyaleController.丑七不且上丗丁一世();
        BattleRoyaleController val_69 = BattleRoyaleController.丑七不且上丗丁一世();
        float val_565 = -100f;
        val_66.y = val_573 + val_565;
        val_565 = val_65.y + val_565;
        val_565 = val_66.y / val_565;
        val_66.y = val_565 * val_69.deltaPosRoadInFly;
        float val_70 = UnityEngine.Mathf.Max(a:  0f, b:  val_66.y);
        UnityEngine.Vector3 val_71 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_68.initPosRoad, y = val_572, z = val_41.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_572 = val_71.z;
        if(val_67.road != null)
        {
            goto label_384;
        }
        
        label_385:
        label_384:
        val_67.road.position = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_572};
        goto label_152;
        label_137:
        UnityEngine.QualitySettings.lodBias = 0.3f;
        if(this.七下丟丄丌业专万且 != true)
        {
                if(this.且丆丅丏丌丗丛丄丌 == false)
        {
            goto label_153;
        }
        
        }
        
        label_152:
        if(this.丑丞丒丟丞丟丆丁一 != false)
        {
                UnityEngine.Vector3 val_72 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
            this.丗七丘与丟万丆丛丁 = val_72.y;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.专下丕三丛丆丂三丆 != false)
        {
                if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                this.丞丗丄丂丆业丈丑业.playerMoveC.专下丕三丛丆丂三丆 = false;
        }
        
        }
        
        if(RedLightController.丑不专七丗丛丅与丟() != true)
        {
                if(JoystickController.丗三丄与丂丟丌专东 == null)
        {
                if(JoystickController.丗三丄与丂丟丌专东 == null)
        {
            goto label_659;
        }
        
        }
        
            UnityEngine.Vector2 val_75 = new UnityEngine.Vector2(x:  JoystickController.丗三丄与丂丟丌专东.value, y:  JoystickController.丗三丄与丂丟丌专东 + 196);
            this.一与东三世丘丞丙丐 = val_75.x;
            mem[1152921540419633256] = val_75.y;
        }
        
        if(this.下丅丂丘丏丟世且丐 == false)
        {
            goto label_168;
        }
        
        if((this.丌专丒丒丛丐丘上丄 & 1) == 0)
        {
            goto label_171;
        }
        
        if(this.playerCamera == null)
        {
            goto label_172;
        }
        
        if(this.playerCamera.丐丒丆业丁丄三丕不 >= 0)
        {
            goto label_173;
        }
        
        label_213:
        float val_76 = this.playerCamera.丐丒丆业丁丄三丕不 + 360f;
        goto label_215;
        label_168:
        if(((this.丑丞丒丟丞丟丆丁一 != false) && (this.丛丗丑丝丕丌七与丆 != true)) && (JoystickController.丗三丄与丂丟丌专东.value < 0))
        {
                mem[1152921540419633256] = 0;
        }
        
        val_577 = 1152921505286238208;
        if(与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 == false)
        {
            goto label_184;
        }
        
        goto label_185;
        label_171:
        val_568 = this.<丗专丟丑万丙与专丌>k__BackingField;
        UnityEngine.Quaternion val_78 = val_568.rotation;
        UnityEngine.Vector2 val_79 = new UnityEngine.Vector2(x:  val_78.y, y:  0f);
        UnityEngine.Vector3 val_81 = this.丌专丒丒丛丐丘上丄.七上不且且丑丂丟东().velocity;
        val_571 = val_81.x;
        float val_82 = UnityEngine.Time.deltaTime;
        val_82 = val_82 * (float)(int)val_571;
        val_82 = this.丕不专丞万一丏丄丟 + val_82;
        this.丕不专丞万一丏丄丟 = val_82;
        if(val_82 < 1f)
        {
            goto label_439;
        }
        
        if(GameController.onlineMode == 0)
        {
            goto label_196;
        }
        
        if(GameController.丆丘丂丈世丏丟丑丏 != null)
        {
            goto label_200;
        }
        
        goto label_200;
        label_184:
        bool val_84 = (typeof(Player_move_c).__il2cppRuntimeField_570 != 0) ? 1 : 0;
        val_84 = (丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  4)) & val_84;
        label_185:
        this.七丞三丑丈一东丑丙 = val_84;
        if(isPressed == false)
        {
            goto label_210;
        }
        
        goto label_211;
        label_172:
        if(this.playerCamera.丐丒丆业丁丄三丕不 < 0)
        {
            goto label_213;
        }
        
        label_173:
        float val_566 = this.playerCamera.丐丒丆业丁丄三丕不;
        if(this.playerCamera.丐丒丆业丁丄三丕不 > 360f)
        {
                val_566 = val_566 + (-360f);
        }
        
        label_215:
        UnityEngine.Quaternion val_86 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        if(val_86.y >= 0)
        {
            goto label_217;
        }
        
        goto label_218;
        label_217:
        float val_567 = val_86.y;
        if(val_86.y <= 360f)
        {
            goto label_219;
        }
        
        label_218:
        val_567 = val_567 + (-360f);
        label_219:
        UnityEngine.Vector3 val_88 = this.丌专丒丒丛丐丘上丄.七上不且且丑丂丟东().velocity;
        UnityEngine.Vector3 val_90 = this.丌专丒丒丛丐丘上丄.丌丟丄业且三丛丕丄().forward;
        float val_91 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_92 = val_567 + 180f;
        val_567 = (val_91 > 90f) ? (val_92) : (val_567);
        val_92 = val_566 - val_567;
        if(System.Math.Abs(val_92) <= 180f)
        {
            goto label_232;
        }
        
        if(val_566 <= val_567)
        {
            goto label_231;
        }
        
        val_567 = val_567 + 360f;
        goto label_232;
        label_210:
        label_211:
        this.七丏丙丌丒一七丂丆 = JoystickController.世万丁丆业业丘丘丌.isJumpPressed;
        this.丝且与丘七丆专且丂 = false;
        if(this.下上且丏世丈丞丏东() != false)
        {
                this.与丌丆下丝下丘丏丗 = 0f;
            this.丈丝丟丌丈丄一上丆 = 0f;
        }
        else
        {
                if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                if(this.与丌丆下丝下丘丏丗 > 0.5f)
        {
                this.七三丟七丑专下万丗(丝且与丘七丆专且丂:  true);
            if(this.丈丝丟丌丈丄一上丆 > 2.5f)
        {
                this.丝且与丘七丆专且丂 = true;
            this.丞丗丄丂丆业丈丑业.丌专丏丂丝丕世丅丟();
        }
        
        }
        
            this.与丌丆下丝下丘丏丗 = 0f;
        }
        else
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(this._moveC.专下丕三丛丆丂三丆 == true)
        {
            goto label_251;
        }
        
        }
        
        }
        
            UnityEngine.Vector3 val_97 = this.世丟丈丏丕万丝丆万.velocity;
            this.丈丝丟丌丈丄一上丆 = -val_97.y;
            float val_98 = UnityEngine.Time.deltaTime;
            val_98 = this.与丌丆下丝下丘丏丗 + val_98;
            this.与丌丆下丝下丘丏丗 = val_98;
        }
        
        }
        
        label_251:
        if(this._moveC.与丏下丝万上三丛不() == true)
        {
            goto label_268;
        }
        
        一三专丈世丑丆丑丐 val_100 = PlayerCoreSettingsStorager.dynamicSettings;
        if(((((val_100.业世丝丒丕东三丁丗 == false) || ((this.<丒丆与丒丘与丒业与>k__BackingField) == true)) || (GameConnect.丛专丌且丕不专丈下() == true)) || (GameConnect.丆丕丒与丂七与下上() == true)) || (GameConnect.万七丄丛丈丟专一丑() == true))
        {
            goto label_268;
        }
        
        if((this.<与丝丁不且东丘丙丞>k__BackingField) == false)
        {
            goto label_269;
        }
        
        if(PlayerCoreSettingsStorager.dynamicSettings != null)
        {
            goto label_273;
        }
        
        goto label_273;
        label_196:
        label_200:
        if(BattleRoyaleController.丑七不且上丗丁一世() == 0)
        {
            goto label_278;
        }
        
        BattleRoyaleController val_107 = BattleRoyaleController.丑七不且上丗丁一世();
        val_574 = val_107.squadMode;
        goto label_282;
        label_231:
        val_566 = val_566 + 360f;
        label_232:
        UnityEngine.Vector3 val_109 = UnityEngine.Vector3.zero;
        bool val_110 = UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_109.x, y = val_109.y, z = val_109.z});
        float val_111 = UnityEngine.Time.deltaTime;
        val_111 = val_111 * 0f;
        val_111 = this.世七丂不丙一丆丝丌 + val_111;
        this.世七丂不丙一丆丝丌 = val_111;
        if(val_111 < 1f)
        {
            goto label_286;
        }
        
        if(GameController.onlineMode == 0)
        {
            goto label_291;
        }
        
        if(GameController.丆丘丂丈世丏丟丑丏 != null)
        {
            goto label_295;
        }
        
        goto label_295;
        label_278:
        val_574 = 0;
        label_282:
        if((GameController.onlineMode != 0) && (GameController.onlineMode != null))
        {
                if(null == null)
        {
            goto label_304;
        }
        
        }
        
        val_568 = 0;
        label_378:
        Rilisoft.丞丛七上丕专丏丌丈.丅丅世丏不丆丅丈丝(丙专七丘与丒丛丅丆:  (0 != 0) ? 1 : 0, 丕丐三丌丄万世万丁:  this.丌专丒丒丛丐丘上丄);
        float val_569 = this.丕不专丞万一丏丄丟;
        val_569 = val_569 + (-1f);
        this.丕不专丞万一丏丄丟 = val_569;
        goto label_439;
        label_291:
        label_295:
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_117 = BattleRoyaleController.丑七不且上丗丁一世();
            val_577 = val_117.squadMode;
        }
        else
        {
                val_577 = 0;
        }
        
        if((GameController.onlineMode != 0) && (GameController.onlineMode != null))
        {
                if(null == null)
        {
            goto label_326;
        }
        
        }
        
        val_575 = 0;
        label_379:
        Rilisoft.丞丛七上丕专丏丌丈.七且且七一丐丗东与(丙专七丘与丒丛丅丆:  (0 != 0) ? 1 : 0, 丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丕丐三丌丄万世万丁:  this.丌专丒丒丛丐丘上丄);
        float val_570 = this.世七丂不丙一丆丝丌;
        val_570 = val_570 + (-1f);
        this.世七丂不丙一丆丝丌 = val_570;
        label_286:
        if(this.playerCamera == null)
        {
            goto label_332;
        }
        
        val_576 = -1f;
        goto label_333;
        label_332:
        val_576 = -1f;
        if(this.playerCamera == null)
        {
            goto label_334;
        }
        
        label_333:
        label_375:
        label_376:
        float val_127 = UnityEngine.Mathf.Lerp(a:  this.playerCamera.丘丁世业丒丙上丈丗(), b:  UnityEngine.Mathf.Lerp(a:  this.playerCamera.丑万下丟丝丕丈丁上, b:  this.playerCamera.东万丌丌与丘丝丈上, t:  (0f - this.playerCamera.丒丏专丄丌丅丛丞专) / this.playerCamera.业丕专三一丙不丄下), t:  UnityEngine.Time.deltaTime + UnityEngine.Time.deltaTime);
        if(this.playerCamera != null)
        {
            
        }
        
        float val_571 = this.不万丈丙丏且万丁七;
        if(0f > val_571)
        {
                if(0f < this.丅丗下东且万丌丈丞)
        {
                val_571 = this.丅丗下东且万丌丈丞 - val_571;
            val_571 = (0f - val_571) / val_571;
            val_571 = val_571 * (this.且丘丘丒丂与东丗且 - this.丁丅丅且丅专丑丑丐);
            float val_130 = this.丁丅丅且丅专丑丑丐 + val_571;
        }
        else
        {
                float val_575 = this.且丘丘丒丂与东丗且;
        }
        
        }
        
        float val_572 = val_567;
        float val_574 = this.丙丟下丒与上业专丘;
        val_572 = val_566 - val_572;
        float val_573 = System.Math.Abs(val_572);
        if(val_573 > val_574)
        {
                if(val_573 < this.万丐丕丄业丗丛专丁)
        {
                val_574 = this.万丐丕丄业丗丛专丁 - val_574;
            val_574 = (val_573 - val_574) / val_574;
            val_574 = val_574 * (this.丐东丁东一丙丈丘丐 - this.业丙专丒丕与世丄丄);
            val_574 = this.业丙专丒丕与世丄丄 + val_574;
        }
        
        }
        
        val_575 = val_575 * this.丐东丁东一丙丈丘丐;
        float val_133 = UnityEngine.Time.deltaTime;
        val_133 = val_575 * val_133;
        if(val_573 > val_133)
        {
                float val_134 = UnityEngine.Time.deltaTime;
            val_134 = ((val_566 > val_567) ? -1f : 1f) * val_134;
            val_134 = val_575 * val_134;
            float val_135 = this.playerCamera.丐丒丆业丁丄三丕不 + val_134;
        }
        else
        {
                UnityEngine.Quaternion val_136 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        }
        
        float val_576 = this.三丅丙丕东丂丘世不;
        if(0f <= val_576)
        {
            goto label_356;
        }
        
        if(0f >= this.丌丑丟三上丅丝上丑)
        {
            goto label_357;
        }
        
        val_576 = this.丌丑丟三上丅丝上丑 - val_576;
        val_576 = (0f - val_576) / val_576;
        val_576 = val_576 * (this.世丈丂丌一丅上世丛 - this.不丛丙且丑专丒东业);
        val_571 = this.不丛丙且丑专丒东业 + val_576;
        goto label_359;
        label_356:
        val_571 = this.不丛丙且丑专丒东业;
        goto label_359;
        label_357:
        val_571 = this.世丈丂丌一丅上世丛;
        label_359:
        val_568 = this.playerCamera;
        val_573 = this.playerCamera.下丁丂丐丙万丞丂丞;
        float val_143 = UnityEngine.Time.deltaTime;
        val_143 = val_571 * val_143;
        if((System.Math.Abs(val_573 - this.丅下东丛丈丞丟丘丞)) > val_143)
        {
                float val_144 = UnityEngine.Time.deltaTime;
            val_144 = ((this.playerCamera.下丁丂丐丙万丞丂丞 < 0) ? 1f : (val_576)) * val_144;
            val_144 = val_571 * val_144;
            float val_145 = this.playerCamera.下丁丂丐丙万丞丂丞 + val_144;
        }
        
        UnityEngine.Vector2 val_146 = new UnityEngine.Vector2(x:  ((val_91 > 90f) ? 180f : 0f) + val_136.y, y:  this.丅下东丛丈丞丟丘丞);
        if(this.丌专丒丒丛丐丘上丄 == null)
        {
            goto label_439;
        }
        
        if(PGCompany.GamepadCoreController.GamePadEnabled == false)
        {
            goto label_373;
        }
        
        goto label_374;
        label_334:
        if(this.playerCamera != null)
        {
            goto label_375;
        }
        
        if(this.playerCamera != null)
        {
            goto label_376;
        }
        
        goto label_659;
        label_304:
        bool val_148 = GameController.onlineMode.丄丗三丌世东业上丌();
        goto label_378;
        label_326:
        bool val_150 = GameController.onlineMode.丄丗三丌世东业上丌();
        goto label_379;
        label_153:
        this.七下丟丄丌业专万且 = true;
        BattleRoyaleController val_151 = BattleRoyaleController.丑七不且上丗丁一世();
        BattleRoyaleController val_152 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_151.road != null)
        {
            goto label_384;
        }
        
        goto label_385;
        label_373:
        if(丟丌丁且且世丈丈丟.丙丘下丝一下丝丆不() == false)
        {
            goto label_388;
        }
        
        if(isPressed == false)
        {
            goto label_402;
        }
        
        goto label_403;
        label_388:
        label_374:
        label_446:
        UnityEngine.Quaternion val_158 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        val_158.y = this.playerCamera.丐丒丆业丁丄三丕不 - val_158.y;
        float val_579 = System.Math.Abs(val_158.y);
        if((System.Math.Abs(JoystickController.丗三丄与丂丟丌专东 + 192 + 4)) >= 0)
        {
                if(System.Math.Abs(JoystickController.丗三丄与丂丟丌专东.value) >= 0)
        {
            goto label_414;
        }
        
        }
        
        this.丅三世万丕丄丗丑三 = true;
        this.专不专丈丘专丘丟世 = (val_579 >= 0) ? (-true) : true;
        label_441:
        UnityEngine.Vector2 val_581 = JoystickController.丗三丄与丂丟丌专东.value;
        val_571 = JoystickController.丗三丄与丂丟丌专东 + 192 + 4;
        val_581 = val_581 * (float)this.专不专丈丘专丘丟世;
        float val_582 = System.Math.Abs(val_581);
        UnityEngine.Vector2 val_160 = new UnityEngine.Vector2(x:  val_582, y:  System.Math.Abs(val_571));
        val_572 = val_582;
        if(val_572 > this.丌专丒丒丛丐丘上丄.maxVelocityHitPlayer)
        {
                val_573 = UnityEngine.Mathf.Sign(f:  val_581);
            val_572 = UnityEngine.Mathf.Sign(f:  val_571);
            if(val_582 > this.丌专丒丒丛丐丘上丄.maxVelocityHitPlayer)
        {
                float val_165 = UnityEngine.Mathf.Lerp(a:  val_573 * this.丌专丒丒丛丐丘上丄.maxDamageHitPlayer, b:  val_573, t:  val_581 * val_573);
        }
        
            val_571 = UnityEngine.Mathf.Lerp(a:  val_572 * this.丌专丒丒丛丐丘上丄.minDamageHitPlayer, b:  val_572, t:  val_571 * val_572);
            val_568 = new 三丅丟三丑七上丂不();
        }
        else
        {
                三丅丟三丑七上丂不 val_169 = null;
            val_568 = val_169;
        }
        
        val_169 = new 三丅丟三丑七上丂不(丁东丂丅业上丁丙丕:  0f, 丝丞世且下丁三世三:  0f);
        if(this.丌专丒丒丛丐丘上丄 != null)
        {
            goto label_439;
        }
        
        goto label_439;
        label_414:
        if(this.丅三世万丕丄丗丑三 == false)
        {
            goto label_441;
        }
        
        this.丅三世万丕丄丗丑三 = false;
        this.专不专丈丘专丘丟世 = (val_579 >= 0) ? (-1) : 1;
        goto label_441;
        label_402:
        label_403:
        UnityEngine.Vector2 val_173 = new UnityEngine.Vector2(x:  (isPressed != true) ? 1f : 0f, y:  (isPressed != true) ? 1f : 0f);
        goto label_446;
        label_269:
        一三专丈世丑丆丑丐 val_174 = PlayerCoreSettingsStorager.dynamicSettings;
        label_273:
        if((this.丑丞丒丟丞丟丆丁一 == false) || (this.丛丗丑丝丕丌七与丆 == false))
        {
            goto label_451;
        }
        
        if(PlayerCoreSettingsStorager.dynamicSettings != null)
        {
            goto label_460;
        }
        
        goto label_460;
        label_451:
        if(this.七丏丙丌丒一七丂丆 == false)
        {
            goto label_456;
        }
        
        if(PlayerCoreSettingsStorager.dynamicSettings != null)
        {
            goto label_460;
        }
        
        goto label_460;
        label_456:
        val_577 = val_577;
        if((与丂丏丛丞丞丒丟丄.世丂丁丟世丄丕丆丄 != true) && (this.丏不丞丐与丅丂与丒 != true))
        {
                if(this.与丌丆下丝下丘丏丗 <= 0.2f)
        {
            goto label_465;
        }
        
        }
        
        一三专丈世丑丆丑丐 val_177 = PlayerCoreSettingsStorager.dynamicSettings;
        val_577 = val_577;
        label_460:
        label_465:
        一三专丈世丑丆丑丐 val_178 = PlayerCoreSettingsStorager.dynamicSettings;
        if(mem[val_177.丌东丌且与与东丝上] == val_178.丕丅业丑丁世丂丂下)
        {
            goto label_472;
        }
        
        一三专丈世丑丆丑丐 val_179 = PlayerCoreSettingsStorager.dynamicSettings;
        if(mem[val_177.丌东丌且与与东丝上] != val_179.丒丏丕丒丘东丂上丑)
        {
            goto label_478;
        }
        
        label_472:
        if(this.一与东三世丘丞丙丐 != 0f)
        {
            goto label_478;
        }
        
        var val_180 = (this.一与东三世丘丞丙丐 == 0f) ? 1 : 0;
        if(this.一与东三世丘丞丙丐 != 0f)
        {
            goto label_478;
        }
        
        一三专丈世丑丆丑丐 val_181 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_181.丕万不业专不且与丐 <= 0f)
        {
            goto label_868;
        }
        
        if(PlayerCoreSettingsStorager.dynamicSettings != null)
        {
            goto label_491;
        }
        
        goto label_491;
        label_478:
        label_868:
        float val_584 = System.Math.Abs(this.丗丈丂丐丁丟丙丝东);
        if(mem[val_177.丌东丌且与与东丝上] == 0)
        {
            goto label_489;
        }
        
        if(val_584 >= 0)
        {
            goto label_490;
        }
        
        label_492:
        var val_183 = mem[val_177.丌东丌且与与东丝上] + 16;
        goto label_491;
        label_489:
        if(val_584 < 0)
        {
            goto label_492;
        }
        
        label_490:
        float val_184 = mem[val_177.丌东丌且与与东丝上] + 20;
        label_491:
        float val_188 = val_184 * UnityEngine.Time.deltaTime;
        val_188 = this.丗丈丂丐丁丟丙丝东.x + val_188;
        this.一与东三世丘丞丙丐 = UnityEngine.Mathf.Clamp(value:  this.一与东三世丘丞丙丐, min:  this.丗丈丂丐丁丟丙丝东.x - (val_184 * UnityEngine.Time.deltaTime), max:  val_188);
        if(0 == 0)
        {
            goto label_499;
        }
        
        一三专丈世丑丆丑丐 val_191 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_191.丕万不业专不且与丐 <= 0f)
        {
            goto label_499;
        }
        
        if(PlayerCoreSettingsStorager.dynamicSettings != null)
        {
            goto label_508;
        }
        
        goto label_508;
        label_499:
        float val_585 = System.Math.Abs(this.一与东三世丘丞丙丐);
        if(mem[val_177.丌东丌且与与东丝上] == 0)
        {
            goto label_506;
        }
        
        if(val_585 >= 0)
        {
            goto label_507;
        }
        
        label_509:
        var val_193 = mem[val_177.丌东丌且与与东丝上] + 16;
        goto label_508;
        label_506:
        if(val_585 < 0)
        {
            goto label_509;
        }
        
        label_507:
        float val_194 = mem[val_177.丌东丌且与与东丝上] + 20;
        label_508:
        float val_195 = UnityEngine.Time.deltaTime;
        val_572 = UnityEngine.Time.deltaTime;
        float val_198 = val_194 * val_572;
        val_198 = null + val_198;
        float val_200 = UnityEngine.Mathf.Clamp(value:  val_585, min:  null - (val_194 * val_195), max:  val_198);
        mem[1152921540419633256] = val_200;
        mem2[0] = this.一与东三世丘丞丙丐;
        mem[1152921540419633500] = val_200;
        label_268:
        this.不丄丒七业丏丙丕三 = val_200;
        if((this.丑丞丒丟丞丟丆丁一 != true) && (val_200 < 0))
        {
                JoystickController.丗三丄与丂丟丌专东.value
            if(((val_200 < 0) && (JoystickController.丗三丄与丂丟丌专东.value != 0f)) && ((JoystickController.丗三丄与丂丟丌专东 + 196) != 0f))
        {
                this.不丄丒七业丏丙丕三 = 0f;
            mem2[0] = 0;
        }
        
        }
        
        val_568 = 1152921504838422528;
        val_571 = mem[this.一与东三世丘丞丙丐];
        val_571 = this.一与东三世丘丞丙丐.x;
        UnityEngine.Vector2 val_201 = new UnityEngine.Vector2(x:  System.Math.Abs(val_571), y:  System.Math.Abs(this.joystickDeadZone));
        if(this.丑丞丒丟丞丟丆丁一 != false)
        {
                this.业丌上丙不丕丝丂丒(丗丛不丕且与世丏丑:  false);
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_531;
        }
        
        if(Player_move_c.丗丒丕专丛丆丈万一() == false)
        {
            goto label_534;
        }
        
        this.下丆东丝丁丝且下下();
        goto label_535;
        label_531:
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() == false)
        {
            goto label_541;
        }
        
        }
        
        val_568 = 1152921504850403328;
        UnityEngine.Vector2 val_206 = UnityEngine.Vector2.zero;
        if((this.一与东三世丘丞丙丐 & 1) != 0)
        {
                if(this.丈丛丅丟丒下世三丝 == false)
        {
            goto label_601;
        }
        
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                UnityEngine.Vector2 val_208 = UnityEngine.Vector2.zero;
            this.一与东三世丘丞丙丐 = val_208;
            mem[1152921540419633256] = val_208.y;
        }
        
        UnityEngine.Vector2 val_209 = UnityEngine.Vector2.zero;
        val_573 = 0f;
        if((this.一与东三世丘丞丙丐 & 1) != 0)
        {
            goto label_574;
        }
        
        UnityEngine.Vector2 val_210 = UnityEngine.Vector2.up;
        float val_211 = UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_210.x, y = val_210.y}, to:  new UnityEngine.Vector2() {x = this.一与东三世丘丞丙丐, y = val_573});
        val_573 = 0f;
        if(val_211 < 0)
        {
            goto label_573;
        }
        
        if(val_211 <= 163f)
        {
            goto label_557;
        }
        
        val_573 = 180f;
        goto label_573;
        label_534:
        UnityEngine.Vector2 val_212 = UnityEngine.Vector2.zero;
        val_571 = val_212.x;
        label_535:
        this.一丞丗丄丕上丕丟丄();
        this.一丘丅专专丏丆且丝();
        return;
        label_541:
        if((((this.丑丞丒丟丞丟丆丁一 == true) || (this.丙一三业丂丁专丛万 > 0f)) || (val_571 > this.七丞丗丙且上三丁世())) || (val_571 < this.丕丛丆丙上丈上丁丌()))
        {
            goto label_566;
        }
        
        float val_215 = 90f - this.runJoystickAngle;
        if(this.一与东三世丘丞丙丐 <= 0f)
        {
            goto label_567;
        }
        
        float val_216 = val_215 * 0.01745329f;
        goto label_570;
        label_557:
        if(val_211 <= 90f)
        {
            goto label_571;
        }
        
        val_573 = val_211;
        if(val_211 <= 90f)
        {
            goto label_573;
        }
        
        val_211 = val_211 + (-90f);
        val_211 = val_211 * 1.232877f;
        val_573 = val_211 + 90f;
        goto label_573;
        label_571:
        val_211 = val_211 + (-17f);
        val_573 = val_211 * 1.232877f;
        label_573:
        if(this.一与东三世丘丞丙丐.x < 0)
        {
                val_573 = -val_573;
        }
        
        label_574:
        UnityEngine.Quaternion val_217 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        UnityEngine.Quaternion val_219 = this.playerCamera.transform.rotation;
        val_219.y = val_573 + val_219.y;
        UnityEngine.Quaternion val_220 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_221 = UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_217.x, y = val_217.y, z = val_217.z, w = val_217.w}, b:  new UnityEngine.Quaternion() {x = val_220.x, y = val_220.y, z = val_220.z, w = val_220.w});
        float val_222 = UnityEngine.Time.deltaTime;
        val_222 = val_222 * 1080f;
        if(val_221 > val_222)
        {
                float val_223 = UnityEngine.Time.deltaTime;
            val_223 = val_223 * 1080f;
            float val_224 = val_223 / val_221;
        }
        
        UnityEngine.Quaternion val_225 = this.<丗专丟丑万丙与专丌>k__BackingField.rotation;
        UnityEngine.Quaternion val_227 = this.playerCamera.transform.rotation;
        val_227.y = val_573 + val_227.y;
        UnityEngine.Quaternion val_228 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_229 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_225.x, y = val_225.y, z = val_225.z, w = val_225.w}, b:  new UnityEngine.Quaternion() {x = val_228.x, y = val_228.y, z = val_228.z, w = val_228.w}, t:  1f);
        val_577 = val_577;
        this.<丗专丟丑万丙与专丌>k__BackingField.rotation = new UnityEngine.Quaternion() {x = val_229.x, y = val_229.y, z = val_229.z, w = val_229.w};
        val_568 = this.<丗专丟丑万丙与专丌>k__BackingField;
        UnityEngine.Vector3 val_230 = val_568.TransformDirection(direction:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.世丂业专专丕丗丘丕 = val_230;
        mem[1152921540419633436] = val_230.y;
        mem[1152921540419633440] = val_230.z;
        this.丝丌业丌上丞上七不 = 1f;
        goto label_603;
        label_567:
        float val_588 = 180f;
        val_588 = val_588 - val_215;
        val_588 = val_588 * 0.01745329f;
        label_570:
        UnityEngine.Vector2 val_232 = new UnityEngine.Vector2(x:  val_588, y:  val_215 * 0.01745329f);
        UnityEngine.Vector2 val_233 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_232.x, y = val_232.y}, d:  this.不丄丒七业丏丙丕三);
        this.一与东三世丘丞丙丐 = val_233;
        mem[1152921540419633256] = val_233.y;
        label_566:
        val_568 = this.<丗专丟丑万丙与专丌>k__BackingField;
        UnityEngine.Vector3 val_234 = val_568.TransformDirection(direction:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.世丂业专专丕丗丘丕 = val_234;
        mem[1152921540419633436] = val_234.y;
        mem[1152921540419633440] = val_234.z;
        this.丝丌业丌上丞上七不 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(this.丑丞丒丟丞丟丆丁一 == false)
        {
            goto label_601;
        }
        
        UnityEngine.Vector2 val_236 = UnityEngine.Vector2.zero;
        if(((this.一与东三世丘丞丙丐 & 1) == 0) || (this.丛丗丑丝丕丌七与丆 == false))
        {
            goto label_601;
        }
        
        val_568 = this.<丗专丟丑万丙与专丌>k__BackingField;
        UnityEngine.Vector3 val_237 = val_568.TransformDirection(direction:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.世丂业专专丕丗丘丕 = val_237;
        mem[1152921540419633436] = val_237.y;
        mem[1152921540419633440] = val_237.z;
        this.丝丌业丌上丞上七不 = 0f;
        goto label_603;
        label_601:
        label_603:
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(Player_move_c.丗丒丕专丛丆丈万一() != false)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_612;
        }
        
        }
        
            UnityEngine.Vector3 val_241 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_241;
            mem[1152921540419633436] = val_241.y;
            mem[1152921540419633440] = val_241.z;
            this.丝丌业丌上丞上七不 = 0f;
        }
        
        label_612:
        if(this.且丆丅丏丌丗丛丄丌 != false)
        {
                val_569 = this.<丗专丟丑万丙与专丌>k__BackingField;
            BattleRoyaleController val_242 = BattleRoyaleController.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_244 = val_242.shutle.transform.position;
            UnityEngine.Vector3 val_245 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_246 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_245.x, y = val_245.y, z = val_245.z}, d:  2f);
            UnityEngine.Vector3 val_247 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_244.x, y = val_244.y, z = val_244.z}, b:  new UnityEngine.Vector3() {x = val_246.x, y = val_246.y, z = val_246.z});
            val_571 = val_247.x;
            val_572 = val_247.z;
            val_569.position = new UnityEngine.Vector3() {x = val_571, y = val_247.y, z = val_572};
            return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                if(TrainingController.丁丑七与丙丐丘丌下() <= 1)
        {
                UnityEngine.Vector3 val_251 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_251;
            mem[1152921540419633436] = val_251.y;
            mem[1152921540419633440] = val_251.z;
            this.丝丌业丌上丞上七不 = 0f;
        }
        
        }
        
        if(PlantTheBombController.BlockControls != true)
        {
                if(MutationController.丑不专七丗丛丅与丟() == false)
        {
            goto label_635;
        }
        
        }
        
        UnityEngine.Vector3 val_254 = UnityEngine.Vector3.zero;
        this.世丂业专专丕丗丘丕 = val_254;
        mem[1152921540419633436] = val_254.y;
        mem[1152921540419633440] = val_254.z;
        label_635:
        if((RedLightController.丑不专七丗丛丅与丟() != false) && (RedLightController.Instance != 0))
        {
                if(RedLightController.Instance.disableAnyMoving != false)
        {
                UnityEngine.Vector3 val_258 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_258;
            mem[1152921540419633436] = val_258.y;
            mem[1152921540419633440] = val_258.z;
        }
        
        }
        
        if(SelectionControlMode.IsShowing != false)
        {
                UnityEngine.Vector3 val_260 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_260;
            mem[1152921540419633436] = val_260.y;
            mem[1152921540419633440] = val_260.z;
            this.丝丌业丌上丞上七不 = 0f;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                if(TrainingController.丁丑七与丙丐丘丌下() == 2)
        {
                UnityEngine.Vector3 val_264 = UnityEngine.Vector3.zero;
            bool val_265 = UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = val_571, z = val_195}, rhs:  new UnityEngine.Vector3() {x = val_264.x, y = val_264.y, z = val_264.z});
        }
        
        }
        
        mem[1152921540419633436] = 0;
        if(JoystickController.丗三丄与丂丟丌专东 == null)
        {
                if(JoystickController.丗三丄与丂丟丌专东 == null)
        {
            goto label_659;
        }
        
        }
        
        if(this._moveC.与丏下丝万上三丛不() == false)
        {
            goto label_661;
        }
        
        if((this.世丟丈丏丕万丝丆万.isGrounded != false) && (0f < 0))
        {
                UnityEngine.Vector3 val_268 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
            UnityEngine.Vector3 val_271 = this._moveC.东三上专丅东业丛丐().transform.position;
            if(val_268.y < 0)
        {
                this._moveC.丄丙丁且丅且一且丏(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.丝丆世丕丂丄万东且() != true)) && ((this._moveC.丙且丐丆专丅丈丏专(丆丂东不七丗下丆丅:  this.丏丆丆丒丗丗丙丈丁)) != true))
        {
                if((丞东丑专丛丆丄丝世.丕丄丅丆丄丘业且丂(下下丏一丙不丘丌丞:  0f)) != false)
        {
                if((丞东丑专丛丆丄丝世.丕丄丅丆丄丘业且丂(下下丏一丙不丘丌丞:  0f)) == true)
        {
            goto label_684;
        }
        
        }
        
            this._moveC.丄丙丁且丅且一且丏(丙业与丙丗丝不丈东:  false);
        }
        
        label_684:
        if((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.丝丆世丕丂丄万东且() != true))
        {
                if(System.Math.Abs(0f) > this.下丒上丞丐丂丏丑丕)
        {
                this._moveC.丄丙丁且丅且一且丏(丙业与丙丗丝不丈东:  false);
        }
        
        }
        
        if(this._moveC.与丏下丝万上三丛不() == false)
        {
            goto label_707;
        }
        
        label_712:
        this.丝丌业丌上丞上七不 = 0f;
        this.世丂业专专丕丗丘丕 = 0;
        mem[1152921540419633440] = 0f;
        goto label_707;
        label_661:
        if(((this._moveC.东三上专丅东业丛丐() == 0) || ((this.世丟丈丏丕万丝丆万.isGrounded == false) || (0f <= (1.401298E-45f)))) || ((this._moveC.丙且丐丆专丅丈丏专(丆丂东不七丗下丆丅:  this.丏丆丆丒丗丗丙丈丁)) == false))
        {
            goto label_707;
        }
        
        if(this.丑丞丒丟丞丟丆丁一 != true)
        {
                if(this.丛丗丑丝丕丌七与丆 == false)
        {
            goto label_709;
        }
        
        }
        
        this._moveC.丅丌三丆东丘丁七丒();
        label_709:
        this._moveC.丄丙丁且丅且一且丏(丙业与丙丗丝不丈东:  true);
        goto label_712;
        label_707:
        if(this.丝丌业丌上丞上七不 > 0f)
        {
                this.丝丌业丌上丞上七不 = 1f;
        }
        
        if((isPressed != false) && (JoystickController.丗三丄与丂丟丌专东.isLock != true))
        {
                UnityEngine.Vector2 val_285 = new UnityEngine.Vector2(x:  0f, y:  0f);
        }
        
        if(this.丈丛丅丟丒下世三丝 == false)
        {
            goto label_723;
        }
        
        float val_590 = this.丝丄世三丐丏与专丂;
        if(this.上且专下丈下丕七丄 < 0)
        {
                float val_286 = UnityEngine.Time.deltaTime;
            val_286 = (val_590 - FirstPersonControlSharp.三丏丅丐丏与下世丗) * val_286;
            val_590 = this.上且专下丈下丕七丄 + val_286;
        }
        
        this.上且专下丈下丕七丄 = val_590;
        goto label_727;
        label_723:
        this.上且专下丈下丕七丄 = FirstPersonControlSharp.三丏丅丐丏与下世丗;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_737;
        }
        
        }
        
        if((this.丑丞丒丟丞丟丆丁一 == true) || (this.丙一三业丂丁专丛万 <= 0f))
        {
            goto label_737;
        }
        
        float val_593 = this.royalePlayerSpeedFromJoystickModifier;
        float val_592 = this.不丄丒七业丏丙丕三;
        float val_591 = 1f;
        val_591 = val_591 - val_593;
        val_592 = val_591 * val_592;
        val_593 = val_593 + val_592;
        goto label_738;
        label_737:
        三丈丟与丏丘丈丐万 val_291 = this._moveC.万三与一丈三丐丅且(丞世不丒下上上丝丑:  WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万());
        if(((GameConnect.万不丒丌丙万丗东不() == true) || (GameConnect.丝丆世丕丂丄万东且() == true)) || ((val_291 == null) || (this._moveC.丙不丅丕三丂业东丕() == 0)))
        {
            goto label_761;
        }
        
        WeaponSounds val_296 = this._moveC.丙不丅丕三丂业东丕();
        if(val_296.isMelee == true)
        {
            goto label_761;
        }
        
        WeaponSounds val_297 = this._moveC.丙不丅丕三丂业东丕();
        val_577 = 1152921505286238208;
        if(val_297.isRoundMelee == true)
        {
            goto label_761;
        }
        
        val_577 = 1152921505286238208;
        if(this._moveC.丗丞业丐丛三上丄丕() == false)
        {
            goto label_761;
        }
        
        val_577 = 1152921505286238208;
        if(this._moveC.丆丂丕专丒丌三一七 == false)
        {
            goto label_763;
        }
        
        label_761:
        float val_594 = 1f;
        label_1283:
        val_594 = this.不丄丒七业丏丙丕三 * val_594;
        label_738:
        this.<万丅丄丛上丕丝三上>k__BackingField = val_594;
        if((this._moveC.丙不丅丕三丂业东丕() == 0) || (this._moveC.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东() == 0))
        {
            goto label_772;
        }
        
        if(this._moveC.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东().丑丛丛丌丝丘东七业() != false)
        {
                if(this._moveC.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东() != null)
        {
            goto label_780;
        }
        
        }
        else
        {
                float val_595 = 1f;
        }
        
        label_780:
        val_595 = (this.<万丅丄丛上丕丝三上>k__BackingField) * val_595;
        mem2[0] = val_595;
        label_772:
        float val_596 = typeof(Player_move_c).__il2cppRuntimeField_AB0 + 56;
        val_596 = (this.<万丅丄丛上丕丝三上>k__BackingField) * val_596;
        mem2[0] = val_596;
        if(GameConnect.一业上七丟业且业丙() != false)
        {
                float val_597 = RedLightController.Instance.speedCoef;
            val_597 = (this.<万丅丄丛上丕丝三上>k__BackingField) * val_597;
            mem2[0] = val_597;
        }
        
        if((this.丑丞丒丟丞丟丆丁一 != false) && ((this.<万丅丄丛上丕丝三上>k__BackingField) <= FirstPersonControlSharp.三专专世丆丏丌不七))
        {
                mem2[0] = FirstPersonControlSharp.三专专世丆丏丌不七;
        }
        
        if((0 & 1) == 0)
        {
            goto label_801;
        }
        
        label_727:
        mem2[0] = 0f;
        label_801:
        if(this._moveC.与丏下丝万上三丛不() != false)
        {
                this.上且专下丈下丕七丄 = this.ladderSpeed;
        }
        
        if(this.丐丂丕丂丑三丑丒一 != false)
        {
                float val_598 = this.上且专下丈下丕七丄;
            val_598 = val_598 * this.丗专丌三丘丟丄丆丞;
            this.上且专下丈下丕七丄 = val_598;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丄丁丑丞丅一三丌丆 != false)
        {
                float val_311 = (this.丞丗丄丂丆业丈丑业.playerMoveC.七且不东世与且丒丛 == true) ? 0.8f : 0.5f;
            val_311 = this.上且专下丈下丕七丄 * val_311;
            this.上且专下丈下丕七丄 = val_311;
        }
        
        if(this.slowdownList.Count >= 1)
        {
                SlowdownCollider val_313 = this.slowdownList.Item[0];
            float val_599 = val_313.slowCoef;
            val_599 = this.上且专下丈下丕七丄 * val_599;
            this.上且专下丈下丕七丄 = val_599;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(this.丕丅业东丞且三丁不 == false)
        {
            goto label_867;
        }
        
        }
        
        }
        
        this.专与丛七与丏丝上丅 = 1f;
        WeaponSounds val_316 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_316.isMelee == true)
        {
            goto label_867;
        }
        
        WeaponSounds val_317 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_317.flamethrower == true)
        {
            goto label_867;
        }
        
        WeaponSounds val_318 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_318.bazooka == false)
        {
            goto label_835;
        }
        
        var val_319 = (this.丐丂丕丂丑三丑丒一 == true) ? 1 : 0;
        goto label_836;
        label_835:
        WeaponSounds val_320 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        if(val_320.isShotGun != true)
        {
            goto label_842;
        }
        
        label_836:
        float val_601 = 0.9f;
        float val_322 = (((this.丐丂丕丂丑三丑丒一 == true) ? 1 : 0) != 0) ? (val_601) : 1f;
        float val_600 = this.不丄丒七业丏丙丕三;
        val_600 = val_600 * 0.2f;
        val_600 = val_600 + 1f;
        val_601 = ((this.丞丗丄丂丆业丈丑业.playerMoveC.七且不东世与且丒丛 == true) ? (val_322 * val_601) : (val_322)) * val_600;
        label_867:
        if(((((this.不七丏丒丑且丕丂业 == true) || (GameConnect.万不丒丌丙万丗东不() == true)) || (GameConnect.丝丆世丕丂丄万东且() == false)) || (GameConnect.丛专丌且丕不专丈下() == true)) || ((GameConnect.丆丕丒与丂七与下上() == true) || ((this.<且丂一与且丐丕丗丈>k__BackingField) == 2)))
        {
            goto label_871;
        }
        
        if(this.camTweenerJump.enabled == true)
        {
            goto label_863;
        }
        
        if(this.camTweenerLanding.enabled == false)
        {
            goto label_862;
        }
        
        goto label_863;
        label_842:
        float val_603 = 1f;
        var val_331 = (this.丐丂丕丂丑三丑丒一 == true) ? 0.8f : (val_603);
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.七且不东世与且丒丛 != false)
        {
                var val_332 = (this.不丄丒七业丏丙丕三 < 0) ? 1 : 0;
            float val_334 = val_603 / (106019888 + this.不丄丒七业丏丙丕三 < 0 ? 1 : 0);
            val_334 = val_334 * ((this.丐丂丕丂丑三丑丒一 == true) ? 0.8f : (val_603));
            this.专与丛七与丏丝上丅 = val_334;
        }
        
        float val_602 = this.accuracyMoveModifier;
        val_602 = val_602 + (-1f);
        val_602 = this.不丄丒七业丏丙丕三 * val_602;
        val_602 = val_602 + val_603;
        val_603 = (106019888 + this.不丄丒七业丏丙丕三 < 0 ? 1 : 0) * val_602;
        goto label_867;
        label_862:
        label_863:
        if(0 != 0)
        {
                if(0 != 0)
        {
            
        }
        
            UnityEngine.Vector3 val_337 = 0.value;
            val_601 = val_601 * (UnityEngine.Mathf.Lerp(a:  1f, b:  2f, t:  (System.Math.Abs((8.407791E-45f) - (1.651491E-34f))) / System.Math.Abs(val_337.y)));
        }
        
        label_871:
        this.丁下丏一业丗业丗三 = UnityEngine.Mathf.MoveTowards(current:  this.丁下丏一业丗业丗三, target:  val_601, maxDelta:  this.accuracyChangeSpeed * UnityEngine.Time.deltaTime);
        if(this.万丗与与丘丗丑丁丈 == false)
        {
            goto label_878;
        }
        
        UnityEngine.Vector3 val_343 = this.世丟丈丏丕万丝丆万.velocity;
        if(val_343.x != 0f)
        {
            goto label_880;
        }
        
        UnityEngine.Vector3 val_344 = this.世丟丈丏丕万丝丆万.velocity;
        if(val_344.z == 0f)
        {
            goto label_882;
        }
        
        label_880:
        UnityEngine.Vector3 val_345 = this.世丟丈丏丕万丝丆万.velocity;
        UnityEngine.Vector3 val_346 = this.世丟丈丏丕万丝丆万.velocity;
        mem2[0] = 0;
        mem[1152921540419634148] = 0;
        label_882:
        UnityEngine.Vector3 val_348 = this.transform.position;
        UnityEngine.Vector3 val_349 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_350 = UnityEngine.Vector3.down;
        UnityEngine.Color val_351 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_348.x, y = val_348.y, z = val_348.z}, dir:  new UnityEngine.Vector3() {x = val_350.x, y = val_350.y, z = val_350.z}, color:  new UnityEngine.Color() {r = val_351.r, g = val_351.b, b = UnityEngine.Time.deltaTime}, duration:  null, depthTest:  false);
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  6f)) == false)
        {
            goto label_897;
        }
        
        if(this.丈丛丅丟丒下世三丝 == true)
        {
            goto label_1145;
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                if(this.世丂业专专丕丗丘丕.x != 0f)
        {
            goto label_895;
        }
        
        }
        
        if(this.世丂业专专丕丗丘丕.x != 0f)
        {
            goto label_895;
        }
        
        label_1145:
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                if(this.下上且丏世丈丞丏东() == false)
        {
            goto label_898;
        }
        
        }
        
        label_897:
        this.不丕丐七丞丄丕丒丙 = 0f;
        label_974:
        UnityEngine.Vector3 val_357 = UnityEngine.Vector3.zero;
        label_981:
        this.丒上七丘且丕不七丙 = val_357;
        mem[1152921540419633856] = val_357.y;
        mem[1152921540419633860] = val_357.z;
        label_878:
        if(((GameConnect.万不丒丌丙万丗东不() == true) || (GameConnect.丝丆世丕丂丄万东且() == true)) || (WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗() == 0))
        {
            goto label_912;
        }
        
        float val_606 = this.丘一丟丌三世上且丟();
        一三专丈世丑丆丑丐 val_363 = PlayerCoreSettingsStorager.dynamicSettings;
        val_606 = val_606 * (this.<万丅丄丛上丕丝三上>k__BackingField);
        if(val_363.丟丏丐下世且业丙一 != 1)
        {
            goto label_1017;
        }
        
        if(this.丝且与丘七丆专且丂 == false)
        {
            goto label_917;
        }
        
        this.丈世丁丑不丄丗三丈 = this.丅丏丆下丞丟丏七丙;
        goto label_918;
        label_912:
        if(this.丑丞丒丟丞丟丆丁一 == true)
        {
            goto label_919;
        }
        
        if(val_285.x.sqrMagnitude < 0)
        {
            goto label_939;
        }
        
        float val_365 = this.丕丛丆丙上丈上丁丌();
        if(val_351.b < 0)
        {
            goto label_939;
        }
        
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_930;
        }
        
        bool val_367 = 丏丑业丛七七丘丅万();
        if(val_367 == true)
        {
            goto label_939;
        }
        
        if(val_367.丒丏丁丛丅丙丂丄且() != false)
        {
                if(this.且丈丟丏专业丕丗丆 == true)
        {
            goto label_939;
        }
        
        }
        
        label_930:
        if((this.丝且与丘七丆专且丂 != true) && (this._moveC.与丏下丝万上三丛不() != true))
        {
                val_577 = val_577;
            if(this._moveC.丄丁丑丞丅一三丌丆 != true)
        {
                val_577 = val_577;
            if(this.丞丗丄丂丆业丈丑业.playerMoveC.东丑丌丄丝世丞丘三 != true)
        {
                if(this.丝丝丟丝世且丆丞世 == false)
        {
            goto label_940;
        }
        
        }
        
        }
        
        }
        
        label_939:
        this.不丒东业丙丘业下丁 = this.丘丑丗与丛丂丞丑丘;
        this.丙一三业丂丁专丛万 = (this.丝且与丘七丆专且丂 == false) ? this.万世丆丘不丏丐上丄 : this.三与丐丏东世丄丂丑;
        label_1288:
        UnityEngine.Vector2 val_371 = UnityEngine.Vector2.zero;
        if((this.一与东三世丘丞丙丐 & 1) != 0)
        {
                this.丘丐丆丝丝丄丘丑丌 = 0f;
        }
        
        float val_372 = UnityEngine.Time.deltaTime;
        val_372 = val_372 * this.三丙三且世下丆丅丆;
        float val_607 = UnityEngine.Mathf.Min(a:  this.不丒东业丙丘业下丁, b:  this.丘丐丆丝丝丄丘丑丌 + val_372);
        this.丘丐丆丝丝丄丘丑丌 = val_607;
        float val_375 = this.丘一丟丌三世上且丟();
        val_375 = val_375 * (this.<万丅丄丛上丕丝三上>k__BackingField);
        val_607 = val_607 * val_375;
        UnityEngine.Vector3 val_376 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = val_372, z = this.丘丐丆丝丝丄丘丑丌}, d:  val_607);
        mem[1152921540419633436] = val_376.y;
        this.世丂业专专丕丗丘丕 = val_376;
        mem[1152921540419633440] = val_376.z;
        this.丝丌业丌上丞上七不 = val_607 * this.丝丌业丌上丞上七不;
        if(this.丑丞丒丟丞丟丆丁一 == true)
        {
            goto label_989;
        }
        
        if(this.丙一三业丂丁专丛万 <= 0f)
        {
            goto label_950;
        }
        
        UnityEngine.Vector3 val_380 = this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.forward;
        UnityEngine.Vector3 val_383 = this.gameObject.transform.forward;
        UnityEngine.Vector3 val_389 = this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent.forward;
        UnityEngine.Vector3 val_392 = this.gameObject.transform.forward;
        float val_393 = UnityEngine.Time.deltaTime;
        val_393 = val_393 * this.七不东丘丐专且丐丛;
        UnityEngine.Vector3 val_395 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_389.x, y = val_389.y, z = val_389.z}, b:  new UnityEngine.Vector3() {x = val_392.x, y = val_392.y, z = val_392.z}, t:  val_393 / (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_380.x, y = val_380.y, z = val_380.z}, to:  new UnityEngine.Vector3() {x = val_383.x, y = val_383.y, z = val_383.z})));
        if(this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent != null)
        {
            goto label_993;
        }
        
        goto label_969;
        label_898:
        UnityEngine.Vector3 val_396 = UnityEngine.Vector3.up;
        this.不丕丐七丞丄丕丒丙 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕.x, y = val_348.y, z = val_348.z}, to:  new UnityEngine.Vector3() {x = val_396.x, y = val_396.y, z = val_396.z});
        UnityEngine.Vector3 val_398 = UnityEngine.Vector3.up;
        UnityEngine.Quaternion val_399 = UnityEngine.Quaternion.AngleAxis(angle:  90f, axis:  new UnityEngine.Vector3() {x = val_398.x, y = val_398.y, z = val_398.z});
        UnityEngine.Vector3 val_400 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_399.x, y = val_399.y, z = val_399.z, w = val_399.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(this.不丕丐七丞丄丕丒丙 <= 45f)
        {
            goto label_974;
        }
        
        UnityEngine.Color val_401 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_400.x, y = val_400.y, z = val_400.z}, dir:  new UnityEngine.Vector3() {x = val_400.x, y = val_400.y, z = val_400.z}, color:  new UnityEngine.Color() {r = val_401.r, g = val_401.b, b = 2f}, duration:  null);
        UnityEngine.Quaternion val_402 = UnityEngine.Quaternion.AngleAxis(angle:  90f, axis:  new UnityEngine.Vector3() {x = val_400.x, y = val_400.y, z = val_400.z});
        UnityEngine.Vector3 val_403 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_402.x, y = val_402.y, z = val_402.z, w = val_402.w}, point:  new UnityEngine.Vector3() {x = val_402.x, y = val_402.y, z = val_402.z});
        float val_608 = -45f;
        val_608 = this.不丕丐七丞丄丕丒丙 + val_608;
        val_608 = val_608 * (this.丐一万丐东上与丟丑 - this.丄丁七丘丟上丞丞世);
        UnityEngine.Vector3 val_406 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_403.x, y = val_403.y, z = val_403.z}, d:  this.丄丁七丘丟上丞丞世 + val_608);
        this.丒上七丘且丕不七丙 = val_406;
        mem[1152921540419633856] = val_406.y;
        mem[1152921540419633860] = val_406.z;
        goto label_981;
        label_950:
        UnityEngine.Transform val_408 = this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent;
        UnityEngine.Vector3 val_409 = val_408.forward;
        UnityEngine.Vector3 val_411 = val_408.forward;
        float val_412 = UnityEngine.Time.deltaTime;
        val_412 = val_412 * this.七不东丘丐专且丐丛;
        UnityEngine.Vector3 val_414 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_411.x, y = val_411.y, z = val_411.z}, b:  new UnityEngine.Vector3() {x = val_376.x, y = 0f, z = val_376.z}, t:  val_412 / (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_409.x, y = val_409.y, z = val_409.z}, to:  new UnityEngine.Vector3() {x = val_376.x, y = 0f, z = val_376.z})));
        UnityEngine.Vector3 val_415 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_414.x, y = val_414.y, z = val_414.z}, rhs:  new UnityEngine.Vector3() {x = val_415.x, y = val_415.y, z = val_415.z})) == false)
        {
            goto label_989;
        }
        
        UnityEngine.Transform val_418 = this.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.parent;
        if(val_418 != null)
        {
            goto label_993;
        }
        
        label_969:
        label_993:
        val_418.forward = new UnityEngine.Vector3() {x = val_414.x, y = val_414.y, z = val_414.z};
        label_989:
        WeaponSounds val_419 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        UnityEngine.Vector3 val_422 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = val_414.x, z = val_414.z}, d:  丘丐丘万丌丟丞下丝.丘三三丌丅丆丄丐丝(七上丟东丂业丑丁丆:  val_419.categoryNabor - 1));
        this.世丂业专专丕丗丘丕 = val_422;
        mem[1152921540419633436] = val_422.y;
        mem[1152921540419633440] = val_422.z;
        WeaponSounds val_423 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        float val_425 = 丘丐丘万丌丟丞下丝.丘三三丌丅丆丄丐丝(七上丟东丂业丑丁丆:  val_423.categoryNabor - 1);
        val_425 = this.丝丌业丌上丞上七不 * val_425;
        goto label_1004;
        label_895:
        UnityEngine.Vector3 val_426 = UnityEngine.Vector3.down;
        float val_609 = val_426.x;
        UnityEngine.Quaternion val_427 = UnityEngine.Quaternion.Euler(x:  0f, y:  90f, z:  0f);
        UnityEngine.Vector3 val_428 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_427.x, y = val_427.y, z = val_427.z, w = val_427.w}, point:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = val_350.z, z = 1000f});
        val_609 = 180f - (CompasController.东东丂七专丁丆丛丁(一不丝丟世业丑丙一:  new UnityEngine.Vector3() {x = val_609, y = val_426.y, z = val_426.z}, 丘丑丛丕下丈世下丂:  new UnityEngine.Vector3() {x = val_426.x, y = val_426.y, z = val_426.z}, 丏丟万且丝丒丝丅东:  new UnityEngine.Vector3() {x = val_428.x, y = val_428.z, z = 2f}));
        if((val_609 <= 0f) || (val_609 >= 0))
        {
            goto label_1145;
        }
        
        if(val_609 >= FirstPersonControlSharp.丗丟丈一丁七丛丞丙)
        {
            goto label_1013;
        }
        
        float val_610 = 0.01745329f;
        val_610 = val_609 * val_610;
        val_610 = this.上且专下丈下丕七丄 * val_610;
        this.上且专下丈下丕七丄 = val_610;
        goto label_1145;
        label_917:
        float val_430 = UnityEngine.Time.deltaTime;
        float val_431 = this.丈世丁丑不丄丗三丈 - val_430;
        this.丈世丁丑不丄丗三丈 = val_431;
        if(val_431 <= 0f)
        {
            goto label_1017;
        }
        
        val_430 = this.丅丏丆下丞丟丏七丙 - val_431;
        float val_433 = UnityEngine.Mathf.Clamp(value:  val_430, min:  0f, max:  1f - this.与丗丑丟丅丌且万专);
        val_433 = this.与丗丑丟丅丌且万专 + val_433;
        label_918:
        val_606 = val_606 * val_433;
        label_1017:
        UnityEngine.Vector3 val_434 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = this.与丗丑丟丅丌且万专, z = val_431}, d:  val_606);
        this.世丂业专专丕丗丘丕 = val_434;
        mem[1152921540419633436] = val_434.y;
        mem[1152921540419633440] = val_434.z;
        label_1004:
        this.丝丌业丌上丞上七不 = val_606 * this.丝丌业丌上丞上七不;
        label_919:
        this.丒上丌丐且丟丒丘丅();
        if((丅万丝丘三业世丆丞(丏不丂丆且三丞丆丏:  12)) != false)
        {
                mem[1152921540419633924] = 1103626240;
        }
        
        val_574 = 1152921504838316032;
        val_576 = PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三();
        UnityEngine.Vector3 val_439 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丏丄业丆业丅且丏丗, y = this.与丗丑丟丅丌且万专, z = val_350.y}, d:  val_576);
        UnityEngine.Vector3 val_440 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = this.世丂业专专丕丗丘丕, z = val_431}, b:  new UnityEngine.Vector3() {x = val_439.x, y = val_439.y, z = val_439.z});
        this.世丂业专专丕丗丘丕 = val_440;
        mem[1152921540419633436] = val_440.y;
        mem[1152921540419633440] = val_440.z;
        UnityEngine.Vector3 val_441 = UnityEngine.Physics.gravity;
        UnityEngine.Vector3 val_442 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_441.x, y = val_441.y, z = val_441.z}, d:  this.万世东丞丑丟丒世三);
        val_573 = val_442.y;
        UnityEngine.Vector3 val_445 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_442.x, y = val_573, z = val_442.z}, d:  PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三());
        UnityEngine.Vector3 val_446 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_445.x, y = val_445.y, z = val_445.z}, b:  new UnityEngine.Vector3() {x = this.丁下丁丕丞丒专业一, y = val_439.y, z = val_439.z});
        val_580 = val_440.x;
        val_581 = val_440.y;
        val_582 = val_440.z;
        UnityEngine.Vector3 val_447 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_580, y = val_581, z = val_582}, b:  new UnityEngine.Vector3() {x = val_446.x, y = val_446.y, z = val_446.z});
        val_586 = val_447.x;
        val_587 = val_447.y;
        val_588 = val_447.z;
        this.世丂业专专丕丗丘丕 = val_447;
        mem[1152921540419633436] = val_587;
        mem[1152921540419633440] = val_588;
        if(this.万丗与与丘丗丑丁丈 != false)
        {
                val_580 = val_586;
            val_581 = val_587;
            val_582 = val_588;
            UnityEngine.Vector3 val_448 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_580, y = val_581, z = val_582}, b:  new UnityEngine.Vector3() {x = this.丒上七丘且丕不七丙, y = val_442.x, z = val_573});
            val_586 = val_448.x;
            val_587 = val_448.y;
            val_588 = val_448.z;
            this.世丂业专专丕丗丘丕 = val_448;
            mem[1152921540419633436] = val_587;
            mem[1152921540419633440] = val_588;
        }
        
        if(this.丑丞丒丟丞丟丆丁一 != false)
        {
                if(this.丛丗丑丝丕丌七与丆 != false)
        {
                float val_611 = this.speedCoefFlyOnGliderByJoystik;
            val_611 = val_611 * this.不丄丒七业丏丙丕三;
            val_589 = this.丛万丑东丌万不丑世 + val_611;
        }
        else
        {
                if(this.一三丌与丑丑丞丈丟 != false)
        {
                float val_612 = this.丟三丂业丌丘丐丟世;
            val_612 = 90f - val_612;
            val_612 = this.speedCoefFlyDownInDine * val_612;
            val_590 = val_612 / 90f;
        }
        else
        {
                val_590 = this.speedCoefFlyByJoystik * val_448.x;
        }
        
            val_589 = val_590 + 1f;
        }
        
            UnityEngine.Vector3 val_449 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_586, y = val_587, z = val_588}, d:  val_589);
            this.世丂业专专丕丗丘丕 = val_449;
            mem[1152921540419633436] = val_449.y;
            mem[1152921540419633440] = val_449.z;
            if(this.丛丗丑丝丕丌七与丆 != false)
        {
                val_581 = this.不丄丒七业丏丙丕三;
            val_582 = 0.7f;
            mem[1152921540419633436] = -this.speedFlyDownOnGlider;
            val_580 = (val_581 * val_582) + 0.3f;
            this.丘丗与业丅业下丕丅(丐丌一丈丒一丕丐丙:  val_580);
        }
        else
        {
                float val_613 = this.speedCoefFlyDownInDine;
            float val_615 = this.丟三丂业丌丘丐丟世;
            float val_614 = this.speedFlyDown;
            val_613 = val_613 * val_615;
            val_613 = val_613 / 90f;
            val_614 = val_614 + val_613;
            val_581 = 0.4f;
            val_615 = val_615 * 0.6f;
            val_582 = val_615 / 90f;
            mem[1152921540419633436] = -val_614;
            val_580 = val_582 + val_581;
            this.丙丒丘与不三业丅上(丐丌一丈丒一丕丐丙:  val_580);
        }
        
        }
        
        val_591 = null;
        val_591 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (GameConnect.丙丘不世专且万丄丐() == true))
        {
            goto label_1065;
        }
        
        val_592 = null;
        if((((丏下丙丞丕丕丏丕丞() == true) || (GameConnect.且丞丁东丝丗上丈业() == true)) || (GameConnect.丅丟下专不丁一丈七() == true)) || (GameConnect.七丂万专且丏丘一丙() == true))
        {
            goto label_1065;
        }
        
        UnityEngine.Vector3 val_456 = UnityEngine.Vector3.zero;
        val_594 = 0;
        goto label_1068;
        label_1141:
        val_595 = null;
        val_595 = null;
        SingularityHole val_457 = Initializer.丂丈丗与丕三不丑七.Item[0];
        val_596 = null;
        val_596 = null;
        if((val_457.owner.Equals(other:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == true)
        {
            goto label_1137;
        }
        
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_1080;
        }
        
        val_597 = null;
        val_597 = null;
        val_598 = null;
        val_598 = null;
        SingularityHole val_461 = Initializer.丂丈丗与丕三不丑七.Item[0];
        if(丘丑丅三丆丑丌且丝() == val_461.owner.丘丑丅三丆丑丌且丝())
        {
            goto label_1137;
        }
        
        label_1080:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_1093;
        }
        
        val_599 = null;
        val_599 = null;
        SingularityHole val_464 = Initializer.丂丈丗与丕三不丑七.Item[0];
        if(val_464.owner.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
            goto label_1137;
        }
        
        label_1093:
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_1103;
        }
        
        val_600 = null;
        val_600 = null;
        SingularityHole val_466 = Initializer.丂丈丗与丕三不丑七.Item[0];
        if(val_466.owner.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
            goto label_1137;
        }
        
        label_1103:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_1113;
        }
        
        val_601 = null;
        val_601 = null;
        val_602 = null;
        val_602 = null;
        SingularityHole val_469 = Initializer.丂丈丗与丕三不丑七.Item[0];
        if(且世专不丄丏七下万() ^ val_469.owner.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
        {
            goto label_1137;
        }
        
        label_1113:
        val_603 = null;
        val_603 = null;
        SingularityHole val_472 = Initializer.丂丈丗与丕三不丑七.Item[0];
        UnityEngine.Vector3 val_474 = val_472.transform.position;
        UnityEngine.Vector3 val_476 = this.transform.position;
        val_573 = val_476.y;
        UnityEngine.Vector3 val_477 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_474.x, y = val_474.y, z = val_474.z}, b:  new UnityEngine.Vector3() {x = val_476.x, y = val_573, z = val_476.z});
        val_580 = val_477.x;
        float val_478 = val_472.GetForce(丌七丒世丄上丞丞丁:  val_580);
        if(val_478 > 0f)
        {
                val_573 = val_478;
            val_576 = val_477.z;
            UnityEngine.Vector3 val_479 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_573, y = val_477.y, z = val_576}, d:  val_478);
            val_580 = val_456.x;
            UnityEngine.Vector3 val_480 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_580, y = val_456.y, z = val_456.z}, b:  new UnityEngine.Vector3() {x = val_479.x, y = val_479.y, z = val_479.z});
        }
        
        label_1137:
        val_594 = 1;
        label_1068:
        val_604 = null;
        val_604 = null;
        if(val_594 < Initializer.丂丈丗与丕三不丑七.Count)
        {
            goto label_1141;
        }
        
        if(val_480.x < 0f)
        {
            goto label_1142;
        }
        
        var val_482 = (val_480.y > 0f) ? 1 : 0;
        val_482 = 1 | val_482;
        if((val_482 & 1) == 0)
        {
            goto label_1143;
        }
        
        val_605 = 0f;
        mem[1152921540419633436] = 0;
        mem[1152921540419633924] = 0;
        goto label_1144;
        label_1013:
        this.上且专下丈下丕七丄 = 0f;
        goto label_1145;
        label_1143:
        label_1144:
        val_580 = this.世丂业专专丕丗丘丕;
        UnityEngine.Vector3 val_483 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_580, y = val_456.x, z = val_573}, b:  new UnityEngine.Vector3() {x = val_480.x, y = val_480.y, z = val_480.z});
        this.世丂业专专丕丗丘丕 = val_483;
        mem[1152921540419633436] = val_483.y;
        mem[1152921540419633440] = val_483.z;
        label_1142:
        val_577 = 1152921525487174064;
        val_606 = 0;
        goto label_1148;
        label_1214:
        val_607 = null;
        val_607 = null;
        if((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丅万丝丘三业世丆丞(丏不丂丆且三丞丆丏:  9)) != false)
        {
                val_608 = null;
            val_608 = null;
            Player_move_c val_486 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            UnityEngine.Vector3 val_487 = val_486.myPlayerTransform.position;
            Player_move_c val_488 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            UnityEngine.Vector3 val_489 = val_488.myPlayerTransform.forward;
            val_576 = val_489.x;
            UnityEngine.Vector3 val_490 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_576, y = val_489.y, z = val_489.z}, d:  1.2f);
            UnityEngine.Vector3 val_491 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_487.x, y = val_487.y, z = val_487.z}, b:  new UnityEngine.Vector3() {x = val_490.x, y = val_490.y, z = val_490.z});
            UnityEngine.Vector3 val_493 = this.transform.position;
            UnityEngine.Vector3 val_494 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_491.x, y = val_491.y, z = val_491.z}, b:  new UnityEngine.Vector3() {x = val_493.x, y = val_493.y, z = val_493.z});
            UnityEngine.Vector3 val_495 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_494.x, y = val_494.y, z = val_494.z}, d:  5f);
            val_580 = this.世丂业专专丕丗丘丕;
            UnityEngine.Vector3 val_496 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_580, y = val_491.x, z = val_491.y}, b:  new UnityEngine.Vector3() {x = val_495.x, y = val_495.y, z = val_495.z});
            this.世丂业专专丕丗丘丕 = val_496;
            mem[1152921540419633436] = val_496.y;
            mem[1152921540419633440] = val_496.z;
        }
        
        val_609 = null;
        val_609 = null;
        if((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  14)) != false)
        {
                val_610 = null;
            val_610 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0] != this.丞丗丄丂丆业丈丑业.playerMoveC)
        {
                val_611 = null;
            val_611 = null;
            Player_move_c val_501 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if((val_501.丂七一业下丈业丕丒.IsEnemyTo(专丞上七七且丝七丗:  this.丞丗丄丂丆业丈丑业.playerMoveC)) != false)
        {
                val_612 = null;
            val_612 = null;
            丂丑丂七丞丞丅丂东 val_504 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].与七丑丐专丈丅丄丈(丏不丂丆且三丞丆丏:  14);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                丕丈丏丝丗下丟丅丂 val_507 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[0];
            if(val_507 != null)
        {
                val_613 = null;
            val_613 = null;
            Player_move_c val_508 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            UnityEngine.Vector3 val_509 = val_508.myPlayerTransform.position;
            val_573 = val_509.y;
            UnityEngine.Vector3 val_511 = this.transform.position;
            val_576 = val_511.x;
            val_580 = val_509.x;
            UnityEngine.Vector3 val_512 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_580, y = val_573, z = val_509.z}, b:  new UnityEngine.Vector3() {x = val_576, y = val_511.y, z = val_511.z});
            if(val_512.x > 2.25f)
        {
                val_580 = val_507.丏丕丄东世丕三丆丘() * val_507.丏丕丄东世丕三丆丘();
            if(val_512.x < 0)
        {
                val_614 = null;
            val_614 = null;
            Player_move_c val_514 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            UnityEngine.Vector3 val_515 = val_514.myPlayerTransform.position;
            UnityEngine.Vector3 val_517 = this.transform.position;
            val_576 = val_517.x;
            UnityEngine.Vector3 val_518 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_515.x, y = val_515.y, z = val_515.z}, b:  new UnityEngine.Vector3() {x = val_576, y = val_517.y, z = val_517.z});
            UnityEngine.Vector3 val_519 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_518.x, y = val_518.y, z = val_518.z}, d:  10f);
            val_580 = this.世丂业专专丕丗丘丕;
            UnityEngine.Vector3 val_520 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_580, y = val_515.x, z = val_515.y}, b:  new UnityEngine.Vector3() {x = val_519.x, y = val_519.y, z = val_519.z});
            this.世丂业专专丕丗丘丕 = val_520;
            mem[1152921540419633436] = val_520.y;
            mem[1152921540419633440] = val_520.z;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_606 = 1;
        label_1148:
        val_615 = null;
        val_615 = null;
        if(val_606 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_1214;
        }
        
        label_1065:
        float val_522 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_523 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = 1.2f, z = this.世丂业专专丕丗丘丕}, d:  val_522);
        val_571 = this.丝丌业丌上丞上七不;
        this.世丂业专专丕丗丘丕 = val_523;
        mem[1152921540419633436] = val_523.y;
        mem[1152921540419633440] = val_523.z;
        float val_524 = UnityEngine.Time.deltaTime;
        val_524 = val_571 * val_524;
        this.丝丌业丌上丞上七不 = val_524;
        if(this.丘丘丑东丆丞丄七业 != 0)
        {
                UnityEngine.Vector3 val_526 = UnityEngine.Vector3.zero;
            val_618 = this.丙与丁且且七丒世不;
            val_619 = val_571;
            val_620 = 1.2f;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_618, y = val_619, z = 1.2f}, rhs:  new UnityEngine.Vector3() {x = val_526.x, y = val_526.y, z = val_526.z})) != false)
        {
                UnityEngine.Vector3 val_529 = this.丘丘丑东丆丞丄七业.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = this.丙丛丞专丄丗三丂丄, y = 1.2f, z = this.丙与丁且且七丒世不});
            val_573 = this.丙与丁且且七丒世不;
            UnityEngine.Vector3 val_530 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_529.x, y = val_529.y, z = val_529.z}, b:  new UnityEngine.Vector3() {x = val_573, y = val_522, z = this.丙与丁且且七丒世不});
            UnityEngine.Transform val_531 = this.transform;
            UnityEngine.Vector3 val_532 = val_531.position;
            UnityEngine.Vector3 val_533 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_532.x, y = val_532.y, z = val_532.z}, b:  new UnityEngine.Vector3() {x = val_530.x, y = val_530.y, z = val_530.z});
            val_618 = val_533.x;
            val_619 = val_533.y;
            val_620 = val_533.z;
            val_531.position = new UnityEngine.Vector3() {x = val_618, y = val_619, z = val_620};
        }
        
            UnityEngine.Vector3 val_535 = this.transform.position;
            this.丙与丁且且七丒世不 = val_535;
            mem[1152921540419633604] = val_535.y;
            mem[1152921540419633608] = val_535.z;
            UnityEngine.Vector3 val_537 = this.transform.position;
            val_571 = val_537.x;
            val_572 = val_537.z;
            UnityEngine.Vector3 val_538 = this.丘丘丑东丆丞丄七业.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_571, y = val_537.y, z = val_572});
            this.丙丛丞专丄丗三丂丄 = val_538;
            mem[1152921540419633616] = val_538.y;
            mem[1152921540419633620] = val_538.z;
        }
        
        if(this.与丌丆下丝下丘丏丗 >= 0)
        {
            goto label_1232;
        }
        
        UnityEngine.Vector2 val_539 = new UnityEngine.Vector2(x:  this.世丂业专专丕丗丘丕, y:  0.2f);
        var val_541 = (val_539.x.sqrMagnitude > 0f) ? 1 : 0;
        if(this._moveC != null)
        {
            goto label_1235;
        }
        
        goto label_1234;
        label_1232:
        val_568 = 0;
        if(this._moveC != null)
        {
            goto label_1235;
        }
        
        label_1234:
        label_1235:
        this._moveC.丏丈丈一丌丐丒丟丕(丕与不不万与丄与丟:  false);
        if((((GameConnect.东且三丆丑世世丘丟() != true) && (GameConnect.丆丕丒与丂七与下上() != true)) && (GameConnect.与丈丘丈上丌丝丝丛() != true)) && (GameConnect.丟丆丏上丌一丝丟业() != true))
        {
                if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                this.七丘且且东丗丒不一();
        }
        
        }
        
        this.一丞丗丄丕上丕丟丄();
        label_439:
        this.丗七丞丄万丏专丆丕();
        return;
        label_45:
        if(0.targetValue <= this.freePlayMinHeightForFly)
        {
            goto label_1277;
        }
        
        this.上丛七丂丐下一丐丗 = true;
        if(this.丑丞丒丟丞丟丆丁一 == true)
        {
            goto label_1277;
        }
        
        this.丞丗丄丂丆业丈丑业.playerMoveC.丟万一丅丈七丙丛丟(丆丟万丈与三丑且丆:  丛且丗丌丏下七下丈.七且丐丅与丝丙一丄(), 专丞上七七且丝七丗:  0);
        this.丞丗丄丂丆业丈丑业.playerMoveC.一一丝专东丘丅一丌(丘丘丘专业丁丙丘丁:  丛且丗丌丏下七下丈.万丗丐不不三丁且丟(), 专丞上七七且丝七丗:  0);
        this.与丅七丈丌且七丐丟();
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.weaponToggles != 0)
        {
                丒七丌七丘东业丟丅();
        }
        
        }
        
        if((InGameGUI.丙丞专丌丁丞与不丐 == 0) || (InGameGUI.丙丞专丌丁丞与不丐.weaponTogglesForCharacter == 0))
        {
            goto label_1277;
        }
        
        丒七丌七丘东业丟丅();
        goto label_1277;
        label_763:
        if(val_291.下世万丆丛专丒丑丙() <= 0)
        {
            goto label_1278;
        }
        
        label_1293:
        label_1296:
        一三专丈世丑丆丑丐 val_555 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_556 = val_555.丕丘丘丅丟世下上万.丝丙丐且丟丅三丛七();
        goto label_1283;
        label_940:
        if(this.不丒东业丙丘业下丁 >= 0)
        {
            goto label_1288;
        }
        
        float val_557 = UnityEngine.Time.deltaTime;
        val_557 = this.丙一三业丂丁专丛万 - val_557;
        this.丙一三业丂丁专丛万 = val_557;
        if(val_557 >= 0)
        {
            goto label_1288;
        }
        
        float val_558 = UnityEngine.Time.deltaTime;
        val_558 = val_558 * this.丄丛东一三且业与丅;
        val_558 = this.不丒东业丙丘业下丁 + val_558;
        this.不丒东业丙丘业下丁 = UnityEngine.Mathf.Clamp(value:  val_558, min:  this.丘丑丗与丛丂丞丑丘, max:  this.万丟丗且专丁丟与丏);
        goto label_1288;
        label_1278:
        WeaponSounds val_560 = this._moveC.丙不丅丕三丂业东丕();
        if(val_560.isCharging != false)
        {
                if(this._moveC.一丝丘三上丕丒万一 > 0f)
        {
            goto label_1293;
        }
        
        }
        
        WeaponSounds val_561 = this._moveC.丙不丅丕三丂业东丕();
        if(val_561.isMelee == true)
        {
            goto label_1296;
        }
        
        goto label_1283;
        label_659:
    }
    internal void 丝丌丆丙丑丟不丞不(float 且下世丈丟丒万东丘)
    {
        且下世丈丟丒万东丘 = this.万世东丞丑丟丒世三 * 且下世丈丟丒万东丘;
        this.万世东丞丑丟丒世三 = 且下世丈丟丒万东丘;
    }
    private float 丘一丟丌三世上且丟()
    {
        var val_65;
        float val_66;
        var val_67;
        float val_68;
        float val_69;
        float val_70;
        UnityEngine.Vector2 val_71;
        float val_72;
        float val_73;
        float val_74;
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return (float)this.上且专下丈下丕七丄;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                return (float)this.上且专下丈下丕七丄;
        }
        
        val_65 = null;
        val_65 = null;
        WeaponSounds val_3 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        int val_63 = val_3.categoryNabor;
        if(丘丐丘万丌丟丞下丝.业业与丈丈丝丞丟丑() == 0f)
        {
                val_66 = 0.01f;
        }
        else
        {
                val_66 = 丘丐丘万丌丟丞下丝.业业与丈丈丝丞丟丑();
        }
        
        int val_6 = ExperienceController.丞丞丘业东丙丏七丌();
        val_67 = null;
        val_67 = null;
        val_63 = val_63 - 1;
        val_68 = this.上且专下丈下丕七丄 / val_66;
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
            goto label_78;
        }
        
        val_66 = val_68 / FirstPersonControlSharp.三丏丅丐丏与下世丗;
        if(this.一与东三世丘丞丙丐 <= 0f)
        {
            goto label_24;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_28;
        }
        
        if((PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_49;
        }
        
        float val_11 = PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        goto label_34;
        label_24:
        if(this.一与东三世丘丞丙丐 >= 0)
        {
            goto label_49;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_39;
        }
        
        if((PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_49;
        }
        
        float val_15 = PGCompany.GamepadCoreController.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        goto label_45;
        label_28:
        float val_17 = PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        label_34:
        val_17 = val_66 * val_17;
        val_17 = val_17 - val_68;
        val_17 = this.一与东三世丘丞丙丐 * val_17;
        val_68 = val_68 + val_17;
        goto label_49;
        label_39:
        float val_19 = PlayerCoreSettingsStorager.dynamicSettings.且丑丙不且七东专丘(丄与丘不丘七业丗一:  val_6);
        label_45:
        val_19 = val_66 * val_19;
        val_19 = val_19 - val_68;
        val_19 = this.一与东三世丘丞丙丐 * val_19;
        val_68 = val_68 - val_19;
        label_49:
        if(val_19 <= 0f)
        {
            goto label_53;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_57;
        }
        
        if((PGCompany.GamepadCoreController.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_78;
        }
        
        float val_23 = PGCompany.GamepadCoreController.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6);
        goto label_63;
        label_53:
        if(val_19 >= 0)
        {
            goto label_78;
        }
        
        if((PlayerCoreSettingsStorager.dynamicSettings.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6)) != 0f)
        {
            goto label_68;
        }
        
        if((PGCompany.GamepadCoreController.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6)) == 0f)
        {
            goto label_78;
        }
        
        float val_27 = PGCompany.GamepadCoreController.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6);
        goto label_74;
        label_57:
        float val_29 = PlayerCoreSettingsStorager.dynamicSettings.上丒丅丑万专三丛东(丄与丘不丘七业丗一:  val_6);
        label_63:
        val_29 = val_66 * val_29;
        val_29 = val_29 - val_68;
        val_69 = this.一与东三世丘丞丙丐 * val_29;
        val_68 = val_68 + val_69;
        goto label_78;
        label_68:
        float val_31 = PlayerCoreSettingsStorager.dynamicSettings.一丆上丐且且丄丒一(丄与丘不丘七业丗一:  val_6);
        label_74:
        val_31 = val_66 * val_31;
        val_31 = val_31 - val_68;
        val_69 = this.一与东三世丘丞丙丐 * val_31;
        val_68 = val_68 - val_69;
        label_78:
        一三专丈世丑丆丑丐 val_33 = PlayerCoreSettingsStorager.dynamicSettings;
        val_70 = val_68 * (丘丐丘万丌丟丞下丝.上一且丝丂上丆丞万(七上丟东丂业丑丁丆:  val_63));
        if(((val_63 & 2147483648) == 0) && (val_63 < val_33.业专丂丘丆丂丌业丏.Length))
        {
                一三专丈世丑丆丑丐 val_34 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_34.业专丂丘丆丂丌业丏[(long)val_63] != 0f)
        {
                一三专丈世丑丆丑丐 val_35 = PlayerCoreSettingsStorager.dynamicSettings;
            val_70 = val_70 * val_35.业专丂丘丆丂丌业丏[(long)val_63];
        }
        
        }
        
        一三专丈世丑丆丑丐 val_36 = PlayerCoreSettingsStorager.dynamicSettings;
        if(((val_63 & 2147483648) == 0) && (val_63 < val_36.七丂东丛下丒丒下丂.Length))
        {
                一三专丈世丑丆丑丐 val_37 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_37.七丂东丛下丒丒下丂[(long)val_63] != 0f)
        {
                一三专丈世丑丆丑丐 val_38 = PlayerCoreSettingsStorager.dynamicSettings;
            float val_67 = val_38.七丂东丛下丒丒下丂[(long)val_63];
            if(val_70 < 0)
        {
                一三专丈世丑丆丑丐 val_39 = PlayerCoreSettingsStorager.dynamicSettings;
            val_70 = val_39.七丂东丛下丒丒下丂[(long)val_63];
        }
        
        }
        
            一三专丈世丑丆丑丐 val_40 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_40.专丙下专丂丕丑丕一[(long)val_63] != 0f)
        {
                一三专丈世丑丆丑丐 val_41 = PlayerCoreSettingsStorager.dynamicSettings;
            float val_69 = val_41.专丙下专丂丕丑丕一[(long)val_63];
            if(val_70 < 0)
        {
                一三专丈世丑丆丑丐 val_42 = PlayerCoreSettingsStorager.dynamicSettings;
            val_70 = val_42.专丙下专丂丕丑丕一[(long)val_63];
        }
        
        }
        
        }
        
        一三专丈世丑丆丑丐 val_43 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_43.丁丝丁东七丘丟丐与 != 0f)
        {
                一三专丈世丑丆丑丐 val_44 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_70 < 0)
        {
                一三专丈世丑丆丑丐 val_45 = PlayerCoreSettingsStorager.dynamicSettings;
            val_70 = val_45.丁丝丁东七丘丟丐与;
        }
        
        }
        
        一三专丈世丑丆丑丐 val_46 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_46.丄丝丞专东丂丏业世 != 0f)
        {
                一三专丈世丑丆丑丐 val_47 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_70 > val_47.丄丝丞专东丂丏业世)
        {
                一三专丈世丑丆丑丐 val_48 = PlayerCoreSettingsStorager.dynamicSettings;
            val_70 = val_48.丄丝丞专东丂丏业世;
        }
        
        }
        
        val_71 = this.一与东三世丘丞丙丐;
        if(val_71 <= 0f)
        {
            goto label_163;
        }
        
        一三专丈世丑丆丑丐 val_49 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_49.丞上上七丟丌三丒上 != 0f)
        {
            goto label_167;
        }
        
        val_71 = this.一与东三世丘丞丙丐;
        label_163:
        val_72 = 1f;
        if(val_71 >= 0)
        {
            goto label_176;
        }
        
        一三专丈世丑丆丑丐 val_50 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_50.丁丈与万七丛东丛丂 == 0f)
        {
            goto label_176;
        }
        
        一三专丈世丑丆丑丐 val_51 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_70 = val_51.丁丈与万七丛东丛丂;
        val_70 = val_70 + (-1f);
        val_70 = this.一与东三世丘丞丙丐 * val_70;
        val_72 = 1f - val_70;
        goto label_176;
        label_167:
        一三专丈世丑丆丑丐 val_52 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_71 = val_52.丞上上七丟丌三丒上;
        val_71 = val_71 + (-1f);
        val_71 = val_71 * this.一与东三世丘丞丙丐;
        val_72 = val_71 + 1f;
        label_176:
        if(val_71 <= 0f)
        {
            goto label_180;
        }
        
        一三专丈世丑丆丑丐 val_53 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_53.丏东丐丑丙不万丏专 != 0f)
        {
            goto label_184;
        }
        
        label_180:
        if(val_53.丏东丐丑丙不万丏专 >= 0)
        {
            goto label_193;
        }
        
        一三专丈世丑丆丑丐 val_54 = PlayerCoreSettingsStorager.dynamicSettings;
        val_73 = val_54.下世丙丘丑业丁丒丁;
        if(val_73 == 0f)
        {
            goto label_193;
        }
        
        一三专丈世丑丆丑丐 val_55 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_72 = val_55.下世丙丘丑业丁丒丁;
        val_72 = val_72 - val_72;
        val_73 = 1f * val_72;
        val_72 = val_72 - val_73;
        goto label_193;
        label_184:
        一三专丈世丑丆丑丐 val_56 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_73 = val_56.丏东丐丑丙不万丏专;
        val_73 = val_73 - val_72;
        val_73 = val_73 * 1f;
        val_72 = val_72 + val_73;
        label_193:
        if(this._moveC.与丏下丝万上三丛不() != false)
        {
                val_74 = this.ladderSpeed;
        }
        else
        {
                val_74 = (val_70 * val_72) * 丘丐丘万丌丟丞下丝.业业与丈丈丝丞丟丑();
        }
        
        if(this.丐丂丕丂丑三丑丒一 != false)
        {
                val_74 = val_74 * this.丗专丌三丘丟丄丆丞;
        }
        
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.东丑丌丄丝世丞丘三 != true)
        {
                if(this.丝丝丟丝世且丆丞世 == false)
        {
            goto label_206;
        }
        
        }
        
        val_74 = val_74 * this.speedCoefInjured;
        label_206:
        if(this.丞丗丄丂丆业丈丑业.playerMoveC.丄丁丑丞丅一三丌丆 != false)
        {
                val_74 = val_74 * ((this.丞丗丄丂丆业丈丑业.playerMoveC.七且不东世与且丒丛 == true) ? 0.8f : 0.5f);
        }
        
        if(this.slowdownList.Count < 1)
        {
                return (float)this.上且专下丈下丕七丄;
        }
        
        SlowdownCollider val_62 = this.slowdownList.Item[0];
        val_74 = val_74 * val_62.slowCoef;
        return (float)this.上且专下丈下丕七丄;
    }
    private float 丝丏七丕三丞丘丂东()
    {
        var val_22;
        float val_23;
        float val_24;
        var val_25;
        val_22 = null;
        val_22 = null;
        WeaponSounds val_1 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
        int val_22 = val_1.categoryNabor;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_10;
        }
        
        }
        
        val_23 = 15f;
        goto label_11;
        label_10:
        val_23 = 14f;
        label_11:
        val_22 = val_22 - 1;
        一三专丈世丑丆丑丐 val_6 = PlayerCoreSettingsStorager.dynamicSettings;
        val_24 = val_23 * PlayerCoreSettingsStorager.dynamicSettings.丞丑丆业东世不丕世();
        if(((val_22 & 2147483648) == 0) && (val_22 < val_6.上专丏万丐丐万丑下.Length))
        {
                一三专丈世丑丆丑丐 val_7 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_7.上专丏万丐丐万丑下[(long)val_22] != 0f)
        {
                一三专丈世丑丆丑丐 val_8 = PlayerCoreSettingsStorager.dynamicSettings;
            val_24 = val_24 * val_8.上专丏万丐丐万丑下[(long)val_22];
        }
        
        }
        
        一三专丈世丑丆丑丐 val_9 = PlayerCoreSettingsStorager.dynamicSettings;
        if(((val_22 & 2147483648) == 0) && (val_22 < val_9.丘一丏丌不丟丐世丘.Length))
        {
                一三专丈世丑丆丑丐 val_10 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_10.丘一丏丌不丟丐世丘[(long)val_22] != 0f)
        {
                一三专丈世丑丆丑丐 val_11 = PlayerCoreSettingsStorager.dynamicSettings;
            float val_26 = val_11.丘一丏丌不丟丐世丘[(long)val_22];
            if(val_24 < 0)
        {
                一三专丈世丑丆丑丐 val_12 = PlayerCoreSettingsStorager.dynamicSettings;
            val_24 = val_12.丘一丏丌不丟丐世丘[(long)val_22];
        }
        
        }
        
            一三专丈世丑丆丑丐 val_13 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_13.丛丝万丞业东世丂丏[(long)val_22] != 0f)
        {
                一三专丈世丑丆丑丐 val_14 = PlayerCoreSettingsStorager.dynamicSettings;
            float val_28 = val_14.丛丝万丞业东世丂丏[(long)val_22];
            if(val_24 < 0)
        {
                一三专丈世丑丆丑丐 val_15 = PlayerCoreSettingsStorager.dynamicSettings;
            val_24 = val_15.丛丝万丞业东世丂丏[(long)val_22];
        }
        
        }
        
        }
        
        一三专丈世丑丆丑丐 val_16 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_16.与万万丁丙上丗丒业 != 0f)
        {
                一三专丈世丑丆丑丐 val_17 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_24 < 0)
        {
                一三专丈世丑丆丑丐 val_18 = PlayerCoreSettingsStorager.dynamicSettings;
            val_24 = val_18.与万万丁丙上丗丒业;
        }
        
        }
        
        val_25 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_19.专丞丑三且专专丄万 == 0f)
        {
                return val_24;
        }
        
        val_25 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_24 <= val_20.专丞丑三且专专丄万)
        {
                return val_24;
        }
        
        val_25 = PlayerCoreSettingsStorager.dynamicSettings;
        val_24 = val_21.专丞丑三且专专丄万;
        return val_24;
    }
    private void 丒上丌丐且丟丒丘丅()
    {
        float val_67;
        TouchPadInJoystick val_68;
        var val_69;
        var val_70;
        TouchPadInJoystick val_71;
        var val_72;
        var val_73;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        float val_80;
        var val_81;
        float val_82;
        float val_83;
        float val_84;
        float val_85;
        float val_86;
        float val_87;
        float val_88;
        var val_89;
        float val_90;
        var val_91;
        bool val_1 = GameConnect.丟丆丏上丌一丝丟业();
        if(val_1 == true)
        {
                return;
        }
        
        val_67 = val_1.丝丏七丕三丞丘丂东();
        if(this.世丟丈丏丕万丝丆万.isGrounded != true)
        {
                if(this._moveC.与丏下丝万上三丛不() != true)
        {
                if(this.cableCarMoving == false)
        {
            goto label_8;
        }
        
        }
        
        }
        
        val_68 = 1152921505311105024;
        bool val_5 = 丘丐丘万丌丟丞下丝.三丆丈丗丘丒丅下万();
        if(val_5 != false)
        {
                this.一丙专丄丗东丟丞丂 = false;
        }
        
        this.丆丒世丁七下一不丈 = true;
        val_5.且不一且丗东丁丕丙(丙业与丙丗丝不丈东:  false);
        val_69 = null;
        val_69 = null;
        if(this.丆丒世丁七下一不丈 == false)
        {
            goto label_27;
        }
        
        val_69 = JoystickController.丘万丏三丏丑世丐丏.jumpTouch;
        val_70 = 0;
        if(isPressed == true)
        {
            goto label_22;
        }
        
        val_69 = null;
        val_69 = null;
        val_71 = JoystickController.世万丁丆业业丘丘丌;
        if(val_71 == null)
        {
                val_69 = 0;
        }
        
        if((JoystickController.世万丁丆业业丘丘丌.isJumpPressed == true) || (this.世丂丁丟世丄丕丆丄 == true))
        {
            goto label_22;
        }
        
        val_69 = JoystickController.丘万丏三丏丑世丐丏;
        val_70 = 0;
        if(val_69.上三丌丞丅丐丅丐丘() == false)
        {
            goto label_27;
        }
        
        label_22:
        if(this.丞丗丄丂丆业丈丑业 == null)
        {
                val_69 = 0;
        }
        
        val_71 = this.丞丗丄丂丆业丈丑业.playerMoveC;
        if(val_71 == null)
        {
                val_69 = 0;
        }
        
        if((this.丞丗丄丂丆业丈丑业.playerMoveC.东丑丌丄丝世丞丘三 != true) && (this.不丕丐七丞丄丕丒丙 < 0))
        {
                val_69 = this;
            this.丕丗丁丄专丏三东不();
        }
        
        label_27:
        if(this.丘丈三且万丗丘丗三() == false)
        {
            goto label_30;
        }
        
        this.万丒丘丛世上丈丁东 = false;
        this.世丂丁丟世丄丕丆丄 = false;
        val_72 = null;
        val_72 = null;
        if(JoystickController.世万丁丆业业丘丘丌.isJumpPressed == false)
        {
            goto label_34;
        }
        
        this.且丂丙丞丆七丌上世 = true;
        goto label_35;
        label_30:
        if((GameConnect.丆丕丒与丂七与下上() != true) && (GameConnect.丛专丌且丕不专丈下() != true))
        {
                val_73 = null;
            val_73 = null;
            if((System.String.op_Inequality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                UnityEngine.Vector3 val_12 = UnityEngine.Physics.gravity;
            float val_67 = -0.95f;
            val_67 = val_12.y * val_67;
            val_67 = this.万世东丞丑丟丒世三 * val_67;
            val_67 = S3 + val_67;
            mem[1152921540423399636] = val_67;
        }
        
        }
        
        if(this.丑丞丒丟丞丟丆丁一 == false)
        {
                return;
        }
        
        mem[1152921540423399636] = 0;
        return;
        label_34:
        var val_68 = 0;
        val_68 = val_68 + 1;
        goto label_51;
        label_8:
        val_75 = null;
        val_75 = null;
        if((JoystickController.世万丁丆业业丘丘丌.isJumpPressed != true) && (this.且丂丙丞丆七丌上世 != false))
        {
                this.万丒丘丛世上丈丁东 = true;
            this.且丂丙丞丆七丌上世 = false;
        }
        
        val_76 = null;
        val_76 = null;
        val_68 = JoystickController.世万丁丆业业丘丘丌;
        val_71 = mem[JoystickController.丘万丏三丏丑世丐丏 + 320];
        val_71 = JoystickController.丘万丏三丏丑世丐丏.jumpTouch;
        val_77 = 0;
        if(((isPressed == true) || (JoystickController.世万丁丆业业丘丘丌.isJumpPressed == true)) || (this.世丂丁丟世丄丕丆丄 == true))
        {
            goto label_64;
        }
        
        val_77 = 0;
        if(JoystickController.丘万丏三丏丑世丐丏.上三丌丞丅丐丅丐丘() == false)
        {
            goto label_73;
        }
        
        label_64:
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(丘丐丘万丌丟丞下丝.三丆丈丗丘丒丅下万() != false)
        {
                if(this.一丙专丄丗东丟丞丂 == false)
        {
            goto label_72;
        }
        
        }
        
        }
        
        label_188:
        if(this.七丞三丑丈一东丑丙 == false)
        {
            goto label_73;
        }
        
        val_68 = this.七丞三丑丈一东丑丙;
        label_189:
        this.一丙专丄丗东丟丞丂 = true;
        this.丆丒世丁七下一不丈 = false;
        label_193:
        val_78 = null;
        val_78 = null;
        if(东丟丟万下丛丆丛丟.专丅业三丑万不业丂 == null)
        {
            goto label_194;
        }
        
        val_79 = null;
        val_79 = null;
        if(PlayerEffectContainer.丗上与丈丕丁且七世 == false)
        {
            goto label_79;
        }
        
        val_80 = this.jetpackUsingDurationModifier;
        if((this.丞丗丄丂丆业丈丑业 != 0) && (this.丞丗丄丂丆业丈丑业.playerMoveC != 0))
        {
                if((this.丞丗丄丂丆业丈丑业.playerMoveC.不丌丁丁与上丘丌丈().丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  12)) != false)
        {
                val_80 = this.丞丗丄丂丆业丈丑业.playerMoveC.不丌丁丁与上丘丌丈().丛万丟丕丗丒七不丄(丂丑丑与与丘丁与丙:  12);
        }
        
        }
        
        val_81 = null;
        val_81 = null;
        float val_24 = UnityEngine.Time.deltaTime;
        val_82 = val_24;
        if(东丟丟万下丛丆丛丟.专丅业三丑万不业丂 != null)
        {
            goto label_186;
        }
        
        label_187:
        label_186:
        val_24 = val_80 * val_82;
        label_194:
        val_71 = this.世丟丈丏丕万丝丆万;
        val_77 = 0;
        UnityEngine.Vector3 val_25 = val_71.velocity;
        val_83 = System.Math.Abs(val_25.y);
        if(val_83 <= 0.05f)
        {
            goto label_100;
        }
        
        if(this.丈业丆丌万丛丌丌丄() == false)
        {
            goto label_101;
        }
        
        val_84 = 1f;
        if((val_68 != true) && (this.丑下丟丑丅专不丐不 != false))
        {
                val_84 = this.secondJumpUpMultiplierAfterImpact;
        }
        
        float val_69 = 1.1f;
        val_69 = this.jumpUpMultiplier * val_69;
        val_82 = val_84 * val_69;
        val_85 = 1f;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                float val_29 = 丘丐丘万丌丟丞下丝.丟不丄丝丞丏丁丒万();
            val_85 = val_29;
        }
        
        }
        
        val_29 = val_67 * val_85;
        val_86 = val_82 * val_29;
        goto label_158;
        label_51:
        UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  this.一丈丝世万丕丝七七().GetEnumerator());
        label_35:
        this._moveC.丄丙丁且丅且一且丏(丙业与丙丗丝不丈东:  false);
        this.七三丟七丑专下万丗(丝且与丘七丆专且丂:  false);
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_33;
        mem[1152921540423399636] = val_33.y;
        mem[1152921540423399640] = val_33.z;
        if(this.丈业丆丌万丛丌丌丄() != false)
        {
                float val_70 = this.jumpUpMultiplier;
            val_70 = val_67 * val_70;
            val_67 = 1f;
            if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                val_67 = 丘丐丘万丌丟丞下丝.丟不丄丝丞丏丁丒万();
        }
        
        }
        
            val_87 = val_70 * val_67;
        }
        else
        {
                val_88 = 1f;
            if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                val_88 = 丘丐丘万丌丟丞下丝.丟不丄丝丞丏丁丒万();
        }
        
        }
        
            val_87 = val_67 * val_88;
        }
        
        mem[1152921540423399636] = val_87;
        if(this._moveC.丅下万丏丘东丄丌万 != false)
        {
                float val_71 = this._moveC.且三丄上丗丅丗丈一.丆丛与丒专丁不上丘;
            val_71 = val_67 * val_71;
            mem[1152921540423399636] = val_71;
        }
        
        if(GameConnect.一业上七丟业且业丙() != false)
        {
                float val_72 = RedLightController.Instance.jumpCoef;
            val_72 = val_67 * val_72;
            mem[1152921540423399636] = val_72;
        }
        
        if(this.cableCarMoving == false)
        {
                return;
        }
        
        val_89 = null;
        val_89 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        }
        
        this.丞丗丄丂丆业丈丑业.playerMoveC.丑丒东业丕专丈与丆(丘七丐下一丐丒丗下:  false, 专丞上七七且丝七丗:  0);
        return;
        label_73:
        if(this.丈业丆丌万丛丌丌丄() == true)
        {
            goto label_153;
        }
        
        val_71 = this.世丟丈丏丕万丝丆万;
        val_77 = 0;
        UnityEngine.Vector3 val_43 = val_71.velocity;
        val_67 = val_43.y;
        val_86 = 0.05f;
        val_83 = System.Math.Abs(val_67);
        if(val_83 > val_86)
        {
            goto label_153;
        }
        
        UnityEngine.Vector3 val_44 = UnityEngine.Physics.gravity;
        float val_73 = this.万世东丞丑丟丒世三;
        val_73 = val_44.y * val_73;
        val_73 = val_73 + val_44.z;
        val_86 = val_73 * (-0.9f);
        goto label_158;
        label_100:
        UnityEngine.Vector3 val_45 = UnityEngine.Physics.gravity;
        val_67 = val_45.y;
        val_71 = PlayerCoreSettingsStorager.dynamicSettings;
        val_77 = 0;
        float val_48 = val_71.丘丏丌丏三丕不丞三();
        val_45.y = val_67 * this.万世东丞丑丟丒世三;
        val_48 = UnityEngine.Time.deltaTime * val_48;
        val_83 = val_45.y + val_82;
        val_48 = val_48 + 1f;
        val_86 = -(val_83 * val_48);
        goto label_158;
        label_101:
        val_90 = 1f;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                val_90 = 丘丐丘万丌丟丞下丝.丟不丄丝丞丏丁丒万();
        }
        
        }
        
        val_83 = val_67 * val_90;
        val_86 = val_83 * 1.1f;
        label_158:
        mem[1152921540423399636] = val_86;
        label_153:
        if(this.七丞三丑丈一东丑丙 != true)
        {
                this.世丂丁丟世丄丕丆丄 = false;
        }
        
        if(this.丈业丆丌万丛丌丌丄() != true)
        {
                UnityEngine.Vector3 val_53 = this.世丟丈丏丕万丝丆万.velocity;
            val_67 = val_53.y;
            val_86 = 0.05f;
            val_83 = System.Math.Abs(val_67);
            if(val_83 > val_86)
        {
                UnityEngine.Vector3 val_54 = UnityEngine.Physics.gravity;
            val_67 = val_54.y;
            float val_57 = PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三();
            val_54.y = val_67 * this.万世东丞丑丟丒世三;
            val_54.y = val_54.y + S12;
            val_83 = val_54.y * UnityEngine.Time.deltaTime;
            val_57 = val_83 * val_57;
            val_86 = val_82 + val_57;
            mem[1152921540423399636] = val_86;
        }
        
        }
        
        if(this.丈业丆丌万丛丌丌丄() == false)
        {
                return;
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_60 = UnityEngine.Physics.gravity;
        val_67 = val_60.y;
        float val_63 = PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三();
        val_60.y = val_67 * this.万世东丞丑丟丒世三;
        val_60.y = val_60.y + val_82;
        val_60.y = val_60.y * UnityEngine.Time.deltaTime;
        val_63 = val_60.y * val_63;
        val_63 = val_63 * this.velocityDownFallMultiplier;
        val_63 = S3 + val_63;
        mem[1152921540423399636] = val_63;
        return;
        label_79:
        val_91 = null;
        val_91 = null;
        float val_64 = UnityEngine.Time.deltaTime;
        var val_65 = (this.丞丗丄丂丆业丈丑业.世丐七东上万丌丌丛 == false) ? this.jetpackUsingDurationModifier : this.东丂七丕万丞丞丒丄;
        if(东丟丟万下丛丆丛丟.专丅业三丑万不业丂 != null)
        {
            goto label_186;
        }
        
        goto label_187;
        label_72:
        if(this.万丒丘丛世上丈丁东 == false)
        {
            goto label_188;
        }
        
        if(this.七丞三丑丈一东丑丙 == true)
        {
            goto label_189;
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.下七丞与丒下丙世丈(丄上一丄与丁丆丗丌:  this._moveC.三丂不东丗丒丏三丟());
        this.丅丑与丄不丅七丑丆();
        this.一丙专丄丗东丟丞丂 = true;
        this.丆丒世丁七下一不丈 = false;
        if(this.七丞三丑丈一东丑丙 == true)
        {
            goto label_193;
        }
        
        this.七三丟七丑专下万丗(丝且与丘七丆专且丂:  false);
        goto label_194;
    }
    private void 一丞丗丄丕上丕丟丄()
    {
        RPG_Camera val_40;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        var val_47;
        float val_48;
        float val_49;
        float val_50;
        float val_52;
        UnityEngine.Vector3 val_53;
        var val_54;
        var val_55;
        var val_56;
        val_40 = this;
        UnityEngine.Vector2 val_1 = this.丟三丗七专丝丌丆三();
        val_43 = val_1.x;
        val_44 = val_1.y;
        if(this.世丟丈丏丕万丝丆万.enabled == false)
        {
                return;
        }
        
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                val_46 = UnityEngine.Mathf.Min(a:  0f, b:  V10.16B);
            val_47 = 0f;
            val_48 = 0f;
            this.丝丌业丌上丞上七不 = 0f;
            this.世丂业专专丕丗丘丕 = 0;
            mem[1152921540423724160] = 0;
        }
        
        if(this._moveC.与丏下丝万上三丛不() == false)
        {
            goto label_9;
        }
        
        this.世丂业专专丕丗丘丕 = 0;
        UnityEngine.Vector3 val_8 = this._moveC.东三上专丅东业丛丐().transform.up;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = V10.16B}, toDirection:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, point:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = val_8.z});
        val_45 = val_10.x;
        val_49 = val_10.z;
        val_50 = val_45;
        val_46 = val_10.y;
        val_48 = val_49;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48}, d:  UnityEngine.Mathf.Sign(f:  val_8.z));
        this.世丂业专专丕丗丘丕 = val_12;
        mem[1152921540423724156] = val_12.y;
        mem[1152921540423724160] = val_12.z;
        if(this.丈业丆丌万丛丌丌丄() != true)
        {
                val_45 = this.世丂业专专丕丗丘丕;
            val_50 = val_45;
            val_46 = val_10.y;
            val_48 = val_49;
            UnityEngine.CollisionFlags val_14 = this.世丟丈丏丕万丝丆万.Move(motion:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_15;
            mem[1152921540423724156] = val_15.y;
            mem[1152921540423724160] = val_15.z;
        }
        
        this.丝丌业丌上丞上七不 = 0f;
        goto label_39;
        label_9:
        if(this.丞丗丄丂丆业丈丑业.丐世丑丘丞下丏丑丘 != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_28;
        }
        
        }
        
        if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_31;
        }
        
        this.丙丞上三丝一丙丗丂 = true;
        val_52 = (float)RedLightController.Instance.inertionCoef;
        this.三丐上不丐专世与丝 = val_52;
        goto label_33;
        label_31:
        if(this.丙丞上三丝一丙丗丂 == false)
        {
            goto label_34;
        }
        
        label_33:
        val_53 = this.丛下业专丂东丙世丝;
        val_45 = this.世丂业专专丕丗丘丕;
        label_91:
        val_50 = val_53;
        val_46 = V15.16B;
        val_48 = V13.16B;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48}, target:  new UnityEngine.Vector3() {x = val_45, y = V11.16B, z = V12.16B}, maxDistanceDelta:  this.三丐上不丐专世与丝 * UnityEngine.Time.deltaTime);
        this.丛下业专丂东丙世丝 = val_20;
        mem[1152921540423724412] = val_20.z;
        mem[1152921540423724408] = null;
        val_44 = val_44;
        val_43 = val_43;
        if(this.丈业丆丌万丛丌丌丄() == true)
        {
            goto label_39;
        }
        
        val_45 = this.丛下业专丂东丙世丝;
        val_50 = val_45;
        val_46 = V11.16B;
        val_48 = V12.16B;
        UnityEngine.CollisionFlags val_22 = this.世丟丈丏丕万丝丆万.Move(motion:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48});
        goto label_39;
        label_28:
        if(this.丞丗丄丂丆业丈丑业.且丟三丘丒丈丝丆丝 != false)
        {
                val_45 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丞丗丄丂丆业丈丑业.丅丁丏丅丄丌专丟丕, y = V14.16B, z = V15.16B}, d:  val_45);
            val_50 = this.世丂业专专丕丗丘丕;
            val_46 = V11.16B;
            val_48 = V12.16B;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            this.世丂业专专丕丗丘丕 = val_25;
            mem[1152921540423724156] = val_25.y;
            mem[1152921540423724160] = val_25.z;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_54;
        }
        
        }
        
        if(this.丑丞丒丟丞丟丆丁一 != true)
        {
                val_50 = this.与丌丆下丝下丘丏丗;
            val_46 = 0.2f;
            if(val_50 > val_46)
        {
                UnityEngine.Vector3 val_28 = this.世丟丈丏丕万丝丆万.velocity;
            if(val_28.y <= 0f)
        {
                val_46 = this.batleRoyaleAdditionalLandingGravity;
            val_50 = val_28.x - val_46;
            mem[1152921540423724156] = val_50;
        }
        
        }
        
        }
        
        label_54:
        if(this.丈业丆丌万丛丌丌丄() != true)
        {
                val_45 = this.世丂业专专丕丗丘丕;
            val_50 = val_45;
            val_46 = V11.16B;
            val_48 = V12.16B;
            UnityEngine.CollisionFlags val_30 = this.世丟丈丏丕万丝丆万.Move(motion:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48});
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
            this.世丂业专专丕丗丘丕 = val_31;
            mem[1152921540423724156] = val_31.y;
            mem[1152921540423724160] = val_31.z;
        }
        
        this.丙丞上三丝一丙丗丂 = false;
        label_39:
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                if(this._moveC.丟三丏丅世一丟丟上.丑丈上东丗丐丆世上() != true)
        {
                val_49 = this.世丂业专专丕丗丘丕;
            val_50 = val_49;
            val_46 = val_45;
            val_48 = V11.16B;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_50, y = val_46, z = val_48}, d:  1.5f);
            this.世丂业专专丕丗丘丕 = val_34;
            mem[1152921540423724156] = val_34.y;
            mem[1152921540423724160] = val_34.z;
        }
        
        }
        
        if(this.丈业丆丌万丛丌丌丄() != false)
        {
                this.丕丘丅丙世丝丒东丌();
        }
        
        if(this.丈业丆丌万丛丌丌丄() != true)
        {
                if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                UnityEngine.Vector3 val_38 = UnityEngine.Vector3.zero;
            this.丏丄业丆业丅且丏丗 = val_38;
            mem[1152921540423724644] = val_38.y;
            mem[1152921540423724648] = val_38.z;
        }
        else
        {
                if(this.丞丗丄丂丆业丈丑业.丐世丑丘丞下丏丑丘 != false)
        {
                mem2[0] = this.世丂业专专丕丗丘丕;
            mem[1152921540423724412] = 0;
        }
        
            this.丞丗丄丂丆业丈丑业.且丟三丘丒丈丝丆丝 = false;
        }
        
        }
        
        val_54 = null;
        val_54 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                val_55 = null;
            val_55 = null;
            if(与丂丏丛丞丞丒丟丄.丏七丛世丟丞丄万世 != false)
        {
                this.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_43, y = val_44}, 万业丒丞丅一丂丈业:  false);
        }
        
        }
        
        val_40 = 1152921505171275776;
        val_56 = null;
        val_56 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_40 = mem[CameraSceneController.丄丞丁丈与业上丞丟 + 64];
        val_40 = CameraSceneController.丄丞丁丈与业上丞丟.killCamController;
        if(enabled == false)
        {
                return;
        }
        
        val_40 = mem[CameraSceneController.丄丞丁丈与业上丞丟 + 64];
        val_40 = CameraSceneController.丄丞丁丈与业上丞丟.killCamController;
        UpdateMouseX();
        return;
        label_34:
        this.丛下业专丂东丙世丝 = this.世丂业专专丕丗丘丕;
        mem[1152921540423724408] = 0;
        mem[1152921540423724412] = ???;
        this.丙丞上三丝一丙丗丂 = true;
        goto label_91;
    }
    internal void 丅上上丕丗丂丕万与()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丏丄业丆业丅且丏丗 = val_1;
        mem[1152921540423918564] = val_1.y;
        mem[1152921540423918568] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丛下业专丂东丙世丝 = val_2;
        mem[1152921540423918328] = val_2.y;
        mem[1152921540423918332] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.世丂业专专丕丗丘丕 = val_3;
        mem[1152921540423918076] = val_3.y;
        mem[1152921540423918080] = val_3.z;
        this.上且专下丈下丕七丄 = 0f;
    }
    internal void 与丕丑丑丛万业丝丝()
    {
        this.丏丄业丆业丅且丏丗 = 0;
        mem[1152921540424030564] = 0;
        mem[1152921540424030568] = 0;
        this.丛下业专丂东丙世丝 = 0;
        mem[1152921540424030328] = 0;
        mem[1152921540424030332] = 0;
        this.上且专下丈下丕七丄 = 0f;
        this.世丂业专专丕丗丘丕 = 0;
        mem[1152921540424030076] = 0;
        mem[1152921540424030080] = 0;
    }
    internal bool 丄丕丗丗七上丕丒万()
    {
        var val_6;
        var val_7;
        var val_8;
        if((GameConnect.丒丗丁丙丗丄丙不丐() != true) && (GameConnect.一与东丝万上三丆丏() != true))
        {
                if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return false;
        }
        
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return false;
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = null;
        val_8 = null;
        return UnityEngine.Object.op_Equality(x:  NetworkStartTable.__il2cppRuntimeField_typeDefinition, y:  this._moveC);
    }
    internal bool 世丈丝丌丟丞三三丗()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        return UnityEngine.Object.op_Equality(x:  NetworkStartTable.__il2cppRuntimeField_typeDefinition, y:  this._moveC);
    }
    internal bool 一丆世业上丄专下丟()
    {
        var val_3;
        if((this.<且丂一与且丐丕丗丈>k__BackingField) == 1)
        {
                val_3 = GameConnect.万七丄丛丈丟专一丑() ^ 1;
            return (bool)val_3 & 1;
        }
        
        val_3 = 0;
        return (bool)val_3 & 1;
    }
    internal void 且丏丄丄上万与丑与(UnityEngine.Vector3 下丒万丌丆丞一丄丅)
    {
        this.下丒万丌丆丞一丄丅 = 下丒万丌丆丞一丄丅;
        mem[1152921540424503396] = 下丒万丌丆丞一丄丅.y;
        mem[1152921540424503400] = 下丒万丌丆丞一丄丅.z;
    }
    private void 丕丘丅丙世丝丒东丌()
    {
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        if(this.cableCarMoving == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_20 = this.世丂业专专丕丗丘丕;
        float val_21 = this.丕丘专三丘丗下丌丗;
        val_20 = val_20 * val_21;
        val_21 = val_21 * S3;
        val_20 = 0f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = val_20, z = 0f}, d:  this.丕丘专三丘丗下丌丗);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.下丒万丌丆丞一丄丅});
        val_21 = val_2.y;
        val_22 = this.maxPositiveVelocityYPerFrame * UnityEngine.Time.deltaTime;
        if(val_21 <= val_22)
        {
            goto label_4;
        }
        
        val_23 = this.maxPositiveVelocityYPerFrame;
        goto label_5;
        label_4:
        val_22 = this.maxNegativeVelocityYPerFrame * UnityEngine.Time.deltaTime;
        if(val_21 >= 0)
        {
            goto label_6;
        }
        
        val_23 = this.maxNegativeVelocityYPerFrame;
        label_5:
        float val_5 = UnityEngine.Time.deltaTime;
        val_21 = val_23 * val_5;
        label_6:
        if(this.世丟丈丏丕万丝丆万.isGrounded != true)
        {
                val_20 = 0.1f;
            if(val_5 > val_20)
        {
                this.丑下丟丑丅专不丐不 = true;
        }
        
        }
        
        this.七丑丄丅丂丒一世专 = val_2;
        mem[1152921540424680944] = val_21;
        mem[1152921540424680948] = val_2.z;
        UnityEngine.Vector3 val_8 = this.世丟丈丏丕万丝丆万.transform.position;
        UnityEngine.CollisionFlags val_9 = this.世丟丈丏丕万丝丆万.Move(motion:  new UnityEngine.Vector3() {x = this.七丑丄丅丂丒一世专, y = V12.16B, z = V13.16B});
        UnityEngine.Vector3 val_11 = this.世丟丈丏丕万丝丆万.transform.position;
        this.丞丄丝丌东丞东丐丆(与且丒丑丅不专丘七:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 万丕与不丏与不丁上:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        if((this.世丟丈丏丕万丝丆万.isGrounded != true) && (this.丙丞三丆丁业丘丑业 != true))
        {
                this.丙丞三丆丁业丘丑业 = true;
        }
        
        if((this.世丟丈丏丕万丝丆万.isGrounded != false) && (this.丙丞三丆丁业丘丑业 != false))
        {
                this.丙丞三丆丁业丘丑业 = false;
            this._moveC.丙世丞丈丁丝丙丌丞().丙业丁三丈与丈丅丛();
            this._moveC.丙世丞丈丁丝丙丌丞().丆丆丝世三丁三东业();
            this.丑下丟丑丅专不丐不 = false;
        }
        
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            this.丏丄业丆业丅且丏丗 = val_17;
            mem[1152921540424680676] = val_17.y;
            mem[1152921540424680680] = val_17.z;
        }
        else
        {
                if(this.丞丗丄丂丆业丈丑业.丐世丑丘丞下丏丑丘 != false)
        {
                mem2[0] = this.世丂业专专丕丗丘丕;
            mem[1152921540424680444] = ???;
        }
        
            this.丞丗丄丂丆业丈丑业.且丟三丘丒丈丝丆丝 = false;
        }
        
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        this.世丂业专专丕丗丘丕 = val_18;
        mem[1152921540424680188] = val_18.y;
        mem[1152921540424680192] = val_18.z;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
        this.下丒万丌丆丞一丄丅 = val_19;
        mem[1152921540424680932] = val_19.y;
        mem[1152921540424680936] = val_19.z;
    }
    private void 丞丄丝丌东丞东丐丆(UnityEngine.Vector3 与且丒丑丅不专丘七, UnityEngine.Vector3 万丕与不丏与不丁上)
    {
        float val_12;
        var val_13;
        var val_14;
        bool val_15;
        bool val_16;
        var val_17;
        var val_18;
        this.丝丌业丌上丞上七不 = System.Math.Min(val1:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 与且丒丑丅不专丘七.x, y = 0f, z = 与且丒丑丅不专丘七.z}, b:  new UnityEngine.Vector3() {x = 万丕与不丏与不丁上.x, y = 0f, z = 万丕与不丏与不丁上.z}), val2:  this.丝丌业丌上丞上七不);
        if(this.世丟丈丏丕万丝丆万.isGrounded != false)
        {
                val_12 = this.丝丌业丌上丞上七不;
        }
        else
        {
                val_12 = 0f;
            this.丝丌业丌上丞上七不 = 0f;
        }
        
        val_12 = this.世丌业丄丄丗丕上丆 + val_12;
        this.世丌业丄丄丗丕上丆 = val_12;
        if(val_12 <= 1f)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(GameController.onlineMode != 0)
        {
                val_14 = null;
            val_14 = null;
            val_15 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_15 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_15 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_7 = BattleRoyaleController.丑七不且上丗丁一世();
            val_16 = val_7.squadMode;
        }
        else
        {
                val_16 = 0;
        }
        
        val_17 = null;
        val_17 = null;
        if(GameController.onlineMode != 0)
        {
                val_18 = null;
            val_18 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_35;
        }
        
        }
        
        }
        
        label_38:
        var val_9 = val_16 | val_15;
        val_9 = val_9 | 0;
        Rilisoft.丞丛七上丕专丏丌丈.丄万丞丌丆与丛丘丝(丙专七丘与丒丛丅丆:  (val_9 != 0) ? 1 : 0);
        float val_13 = this.世丌业丄丄丗丕上丆;
        val_13 = val_13 + (-1f);
        this.世丌业丄丄丗丕上丆 = val_13;
        return;
        label_35:
        bool val_12 = GameController.onlineMode.丄丗三丌世东业上丌();
        goto label_38;
    }
    private void 丈丘且丄丝世且三上()
    {
        一三专丈世丑丆丑丐 val_1 = PlayerCoreSettingsStorager.dynamicSettings;
        this.丕丘专三丘丗下丌丗 = val_1.丞业丏专丝世业丙东;
        一三专丈世丑丆丑丐 val_2 = PlayerCoreSettingsStorager.dynamicSettings;
        if((UnityEngine.Mathf.Approximately(a:  val_2.丘东丁丑丙不东丘丈, b:  0f)) != true)
        {
                一三专丈世丑丆丑丐 val_4 = PlayerCoreSettingsStorager.dynamicSettings;
            this.maxNegativeVelocityYPerFrame = val_4.丘东丁丑丙不东丘丈;
        }
        
        一三专丈世丑丆丑丐 val_5 = PlayerCoreSettingsStorager.dynamicSettings;
        if((UnityEngine.Mathf.Approximately(a:  val_5.丌丛丝丙丁丂丁丁三, b:  0f)) != true)
        {
                一三专丈世丑丆丑丐 val_7 = PlayerCoreSettingsStorager.dynamicSettings;
            this.maxPositiveVelocityYPerFrame = val_7.丌丛丝丙丁丂丁丁三;
        }
        
        一三专丈世丑丆丑丐 val_8 = PlayerCoreSettingsStorager.dynamicSettings;
        if((UnityEngine.Mathf.Approximately(a:  val_8.上丂与丘丒丙丕丗丁, b:  0f)) != true)
        {
                一三专丈世丑丆丑丐 val_10 = PlayerCoreSettingsStorager.dynamicSettings;
            this.jumpUpMultiplier = val_10.上丂与丘丒丙丕丗丁;
        }
        
        一三专丈世丑丆丑丐 val_11 = PlayerCoreSettingsStorager.dynamicSettings;
        if((UnityEngine.Mathf.Approximately(a:  val_11.不与且丗七一丙丗丛, b:  0f)) == true)
        {
                return;
        }
        
        一三专丈世丑丆丑丐 val_13 = PlayerCoreSettingsStorager.dynamicSettings;
        this.velocityDownFallMultiplier = val_13.不与且丗七一丙丗丛;
    }
    private static bool 不不七东世丝专不丐()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if((FirstPersonControlSharp.丟丆丒三不且丐丕丑 != false) && (CoreHapticsUnity.CoreHapticsUnityProxy.IsSupported != false))
        {
                if(与丂丏丛丞丞丒丟丄.业丙三不且业丗丐丂() != false)
        {
                val_6 = null;
            val_6 = null;
            if(FirstPersonControlSharp.丏丕一丟丑世丕丙丁 <= 0f)
        {
                return (bool)val_8;
        }
        
            val_7 = null;
            val_7 = null;
            float val_5 = FirstPersonControlSharp.丏丕一丟丑世丕丙丁;
            val_5 = UnityEngine.Time.realtimeSinceStartup - val_5;
            var val_4 = (val_5 > 0.05f) ? 1 : 0;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public static void NeedHitTaptick()
    {
        var val_2;
        var val_3;
        val_2 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        FirstPersonControlSharp.专丗丏且丕丏世专与 = true;
    }
    private static string 与丐丌万丘三专丆丆(丑业丗三丘丟丑上丈.丙丟与丐三丐万万丆 丟丄丈上丌东丑丝三)
    {
        string val_42;
        var val_43;
        var val_44;
        float val_45;
        var val_46;
        var val_47;
        CoreHapticsUnity.IEvent val_48;
        var val_49;
        var val_51;
        var val_52;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_42 = 丟丄丈上丌东丑丝三;
        if(val_42 != 1)
        {
            goto label_1;
        }
        
        val_43 = null;
        val_43 = null;
        val_42 = FirstPersonControlSharp.万丄专丒丆下一丌万;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_42)) == false)
        {
            goto label_6;
        }
        
        CoreHapticsUnity.HapticsPattern val_2 = new CoreHapticsUnity.HapticsPattern(capacity:  4);
        CoreHapticsUnity.EventParameter[] val_3 = new CoreHapticsUnity.EventParameter[2];
        val_44 = 1152921505021542400;
        val_3[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.2f);
        CoreHapticsUnity.EventParameter val_5 = null;
        val_45 = 0.4f;
        val_5 = new CoreHapticsUnity.EventParameter(id:  1, value:  val_45);
        val_3[1] = val_5;
        val_46 = 1152921505021329408;
        val_2.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0f, eventType:  1, parameters:  val_3, duration:  1f));
        val_47 = 1152921508642644400;
        CoreHapticsUnity.ParameterCurveControlPoint[] val_7 = new CoreHapticsUnity.ParameterCurveControlPoint[2];
        val_7[0] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0f, value:  0.2f);
        val_7[1] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.5f, value:  0f);
        val_2.AddEvent(_event:  new CoreHapticsUnity.HapticParameterCurve(time:  0.5f, id:  0, points:  val_7));
        CoreHapticsUnity.ParameterCurveControlPoint[] val_11 = new CoreHapticsUnity.ParameterCurveControlPoint[2];
        val_11[0] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0f, value:  val_45);
        val_11[1] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.5f, value:  0f);
        val_2.AddEvent(_event:  new CoreHapticsUnity.HapticParameterCurve(time:  0.5f, id:  1, points:  val_11));
        CoreHapticsUnity.EventParameter[] val_15 = new CoreHapticsUnity.EventParameter[2];
        val_15[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0f);
        val_15[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0f);
        CoreHapticsUnity.HapticEvent val_18 = null;
        val_48 = val_18;
        val_18 = new CoreHapticsUnity.HapticEvent(time:  1.5f, eventType:  0, parameters:  val_15, duration:  0f);
        val_49 = 0;
        val_2.AddEvent(_event:  val_18);
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_49 = 0;
        goto label_45;
        label_1:
        if((val_42 & 4294967294) != 2)
        {
            goto label_46;
        }
        
        val_51 = null;
        val_51 = null;
        val_42 = FirstPersonControlSharp.七下丌不丂丑丁三丝;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_42)) == false)
        {
            goto label_51;
        }
        
        CoreHapticsUnity.HapticsPattern val_22 = new CoreHapticsUnity.HapticsPattern(capacity:  4);
        CoreHapticsUnity.EventParameter[] val_23 = new CoreHapticsUnity.EventParameter[2];
        val_44 = 1152921505021542400;
        val_23[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.5f);
        CoreHapticsUnity.EventParameter val_25 = null;
        val_45 = 0.4f;
        val_25 = new CoreHapticsUnity.EventParameter(id:  1, value:  val_45);
        val_23[1] = val_25;
        val_46 = 1152921505021329408;
        val_22.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0f, eventType:  1, parameters:  val_23, duration:  0.6f));
        val_47 = 1152921508642644400;
        CoreHapticsUnity.ParameterCurveControlPoint[] val_27 = new CoreHapticsUnity.ParameterCurveControlPoint[2];
        val_27[0] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0f, value:  0.5f);
        val_27[1] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.2f, value:  0f);
        val_22.AddEvent(_event:  new CoreHapticsUnity.HapticParameterCurve(time:  val_45, id:  0, points:  val_27));
        CoreHapticsUnity.ParameterCurveControlPoint[] val_31 = new CoreHapticsUnity.ParameterCurveControlPoint[2];
        val_31[0] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0f, value:  val_45);
        val_31[1] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.2f, value:  0f);
        val_22.AddEvent(_event:  new CoreHapticsUnity.HapticParameterCurve(time:  val_45, id:  1, points:  val_31));
        CoreHapticsUnity.EventParameter[] val_35 = new CoreHapticsUnity.EventParameter[2];
        val_35[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0f);
        val_35[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0f);
        CoreHapticsUnity.HapticEvent val_38 = null;
        val_48 = val_38;
        val_38 = new CoreHapticsUnity.HapticEvent(time:  0.8f, eventType:  0, parameters:  val_35, duration:  0f);
        val_52 = 0;
        val_22.AddEvent(_event:  val_38);
        var val_45 = 0;
        val_45 = val_45 + 1;
        val_52 = 0;
        goto label_90;
        label_6:
        val_54 = null;
        goto label_91;
        label_46:
        val_55 = 0;
        return (string)val_57;
        label_51:
        val_56 = null;
        goto label_93;
        label_45:
        val_54 = null;
        val_42 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_2);
        val_54 = null;
        FirstPersonControlSharp.万丄专丒丆下一丌万 = val_42;
        label_91:
        val_54 = null;
        val_57 = 1152921505325273136;
        return (string)val_57;
        label_90:
        val_56 = null;
        val_42 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_22);
        val_56 = null;
        FirstPersonControlSharp.七下丌不丂丑丁三丝 = val_42;
        label_93:
        val_56 = null;
        val_57 = 1152921505325273144;
        return (string)val_57;
    }
    internal static void 世万丈一丅上下丂与(丑业丗三丘丟丑上丈.丙丟与丐三丐万万丆 丟丄丈上丌东丑丝三)
    {
        var val_9;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        if(FirstPersonControlSharp.世丟丑丗上万与专且 != 丟丄丈上丌东丑丝三)
        {
                val_9 = null;
            FirstPersonControlSharp.世丟丑丗上万与专且 = 丟丄丈上丌东丑丝三;
        }
        
        val_9 = null;
        if(FirstPersonControlSharp.上丒丂丑丙一丗丅丞 != false)
        {
                CoreHapticsUnity.CoreHapticsUnityProxy.StopPlayer();
            val_9 = null;
            val_9 = null;
            float val_9 = -0.1f;
            val_9 = UnityEngine.Time.realtimeSinceStartup + val_9;
            FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_9;
            FirstPersonControlSharp.上丒丂丑丙一丗丅丞 = false;
        }
        
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(FirstPersonControlSharp.丂七与丅丟丁且丁万 == true)
        {
                return;
        }
        
        string val_3 = FirstPersonControlSharp.与丐丌万丘三专丆丆(丟丄丈上丌东丑丝三:  丟丄丈上丌东丑丝三);
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_3)) == false)
        {
                return;
        }
        
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayPattern(json:  val_3);
        CoreHapticsUnity.CoreHapticsUnityProxy.remove_OnPatternStopped(value:  new CoreHapticsUnityProxy.HapticStoppedReasonDelegate(object:  0, method:  static System.Void FirstPersonControlSharp::东丝丛丈万丂下丁丛(int 专丏不丏东丏丈丆上)));
        CoreHapticsUnity.CoreHapticsUnityProxy.add_OnPatternStopped(value:  new CoreHapticsUnityProxy.HapticStoppedReasonDelegate(object:  0, method:  static System.Void FirstPersonControlSharp::东丝丛丈万丂下丁丛(int 专丏不丏东丏丈丆上)));
        val_12 = null;
        val_12 = null;
        FirstPersonControlSharp.上丒丂丑丙一丗丅丞 = true;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = UnityEngine.Time.realtimeSinceStartup;
        if(FirstPersonControlSharp.世丟丑丗上万与专且 == 丟丄丈上丌东丑丝三)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        FirstPersonControlSharp.与上丒丛三万丌万上 = UnityEngine.Time.realtimeSinceStartup;
    }
    private static void 东丝丛丈万丂下丁丛(int 专丏不丏东丏丈丆上)
    {
        var val_4;
        HapticStoppedReasonDelegate val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        FirstPersonControlSharp.上丒丂丑丙一丗丅丞 = false;
        CoreHapticsUnityProxy.HapticStoppedReasonDelegate val_1 = null;
        val_5 = val_1;
        val_1 = new CoreHapticsUnityProxy.HapticStoppedReasonDelegate(object:  0, method:  static System.Void FirstPersonControlSharp::东丝丛丈万丂下丁丛(int 专丏不丏东丏丈丆上));
        CoreHapticsUnity.CoreHapticsUnityProxy.remove_OnPatternStopped(value:  val_1);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = System.String.Format(format:  "[CoreHapticsUnity] {0}: {1}", arg0:  "lowHpPatternIsPlaying", arg1:  FirstPersonControlSharp.上丒丂丑丙一丗丅丞);
        UnityEngine.Debug.Log(message:  val_5);
    }
    internal static void 且丛三丕专专丙专万(丑业丗三丘丟丑上丈.丙丟与丐三丐万万丆 丟丄丈上丌东丑丝三)
    {
        var val_13;
        var val_16;
        var val_17;
        val_13 = null;
        val_13 = null;
        if(FirstPersonControlSharp.世丟丑丗上万与专且 == 丟丄丈上丌东丑丝三)
        {
                float val_1 = UnityEngine.Time.realtimeSinceStartup;
            if(丟丄丈上丌东丑丝三 == 0)
        {
                return;
        }
        
            float val_13 = 1.45f;
            val_13 = FirstPersonControlSharp.与上丒丛三万丌万上 + val_13;
            if(val_13 < 0)
        {
                return;
        }
        
            val_13 = null;
        }
        else
        {
                if(丟丄丈上丌东丑丝三 == 0)
        {
                return;
        }
        
        }
        
        val_13 = null;
        if(FirstPersonControlSharp.上丒丂丑丙一丗丅丞 == true)
        {
                return;
        }
        
        val_13 = null;
        if(FirstPersonControlSharp.丂七与丅丟丁且丁万 == true)
        {
                return;
        }
        
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        if(PauseGUIController.丑七不且上丗丁一世() != 0)
        {
                if(PauseGUIController.丑七不且上丗丁一世().IsPaused == true)
        {
                return;
        }
        
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC == 0)
        {
                return;
        }
        
        if(业丘世丆且世丄丟丈() != false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if(PauseNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                val_17 = null;
            val_17 = null;
            if(PauseNGUIController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == true)
        {
                return;
        }
        
        }
        
        FirstPersonControlSharp.世万丈一丅上下丂与(丟丄丈上丌东丑丝三:  丟丄丈上丌东丑丝三);
    }
    internal static void 一丏丌丑且且丐且业()
    {
        object val_38;
        var val_39;
        CoreHapticsUnity.IEvent val_40;
        var val_42;
        var val_43;
        float val_44;
        float val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_51;
        var val_52;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[8];
            val_2[0] = "lowHpIsPlaying";
            val_39 = null;
            val_39 = null;
            val_40 = 1152921504617656320;
            val_2[1] = FirstPersonControlSharp.丂七与丅丟丁且丁万;
            val_2[2] = "lastTapticTime";
            val_2[3] = FirstPersonControlSharp.丏丕一丟丑世丕丙丁;
            val_2[4] = "realtimeSinceStartup";
            val_2[5] = UnityEngine.Time.realtimeSinceStartup;
            val_2[6] = "canFireTaptic";
            val_2[7] = FirstPersonControlSharp.不不七东世丝专不丐();
            val_38 = System.String.Format(format:  "[CoreHapticUnity] {0}: {1}, {2}: {3}, {4}: {5}, {6}: {7}", args:  val_2);
            UnityEngine.Debug.Log(message:  val_38);
        }
        
        val_42 = null;
        val_42 = null;
        if(FirstPersonControlSharp.丂七与丅丟丁且丁万 != false)
        {
                CoreHapticsUnity.CoreHapticsUnityProxy.StopPlayer();
            val_43 = null;
            val_44 = UnityEngine.Time.realtimeSinceStartup;
            val_43 = null;
            val_45 = val_44 + (-0.1f);
            FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_45;
            FirstPersonControlSharp.丂七与丅丟丁且丁万 = false;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_9 = new object[8];
            val_9[0] = "lowHpIsPlaying";
            val_46 = null;
            val_46 = null;
            val_40 = 1152921504617656320;
            val_9[1] = FirstPersonControlSharp.丂七与丅丟丁且丁万;
            val_9[2] = "lastTapticTime";
            val_9[3] = FirstPersonControlSharp.丏丕一丟丑世丕丙丁;
            val_9[4] = "realtimeSinceStartup";
            val_9[5] = UnityEngine.Time.realtimeSinceStartup;
            val_9[6] = "canFireTaptic";
            val_9[7] = FirstPersonControlSharp.不不七东世丝专不丐();
            val_38 = System.String.Format(format:  "[CoreHapticUnity] {0}: {1}, {2}: {3}, {4}: {5}, {6}: {7}", args:  val_9);
            UnityEngine.Debug.Log(message:  val_38);
        }
        
        }
        
        val_47 = null;
        val_47 = null;
        if(FirstPersonControlSharp.上丒丂丑丙一丗丅丞 != false)
        {
                FirstPersonControlSharp.世万丈一丅上下丂与(丟丄丈上丌东丑丝三:  0);
            val_47 = null;
        }
        
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        val_48 = null;
        val_48 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  FirstPersonControlSharp.丏世丑丘丑丕一丟且)) != false)
        {
                CoreHapticsUnity.HapticsPattern val_16 = new CoreHapticsUnity.HapticsPattern(capacity:  4);
            CoreHapticsUnity.EventParameter[] val_17 = new CoreHapticsUnity.EventParameter[2];
            val_17[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
            val_17[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.4f);
            val_16.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0f, eventType:  0, parameters:  val_17, duration:  0f));
            CoreHapticsUnity.EventParameter[] val_21 = new CoreHapticsUnity.EventParameter[2];
            val_21[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
            val_21[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.4f);
            CoreHapticsUnity.HapticEvent val_24 = null;
            val_44 = 0.015f;
            val_24 = new CoreHapticsUnity.HapticEvent(time:  val_44, eventType:  1, parameters:  val_21, duration:  0.25f);
            val_16.AddEvent(_event:  val_24);
            CoreHapticsUnity.ParameterCurveControlPoint[] val_25 = new CoreHapticsUnity.ParameterCurveControlPoint[3];
            val_25[0] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0f, value:  1f);
            val_25[1] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.1f, value:  0.5f);
            val_25[2] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.25f, value:  0f);
            val_16.AddEvent(_event:  new CoreHapticsUnity.HapticParameterCurve(time:  val_44, id:  0, points:  val_25));
            CoreHapticsUnity.ParameterCurveControlPoint[] val_30 = new CoreHapticsUnity.ParameterCurveControlPoint[2];
            val_30[0] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0f, value:  1f);
            val_30[1] = new CoreHapticsUnity.ParameterCurveControlPoint(time:  0.25f, value:  -0.3f);
            CoreHapticsUnity.HapticParameterCurve val_33 = null;
            val_45 = val_44;
            val_40 = val_33;
            val_33 = new CoreHapticsUnity.HapticParameterCurve(time:  val_44, id:  1, points:  val_30);
            val_49 = 0;
            val_16.AddEvent(_event:  val_33);
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_49 = 0;
            val_51 = null;
            val_51 = null;
            FirstPersonControlSharp.丏世丑丘丑丕一丟且 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_16);
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "[CoreHapticUnity] Play DeadSelf");
        }
        
        val_52 = null;
        val_52 = null;
        val_38 = FirstPersonControlSharp.丏世丑丘丑丕一丟且;
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayPattern(json:  val_38);
        float val_38 = UnityEngine.Time.realtimeSinceStartup;
        val_38 = val_38 + 2f;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_38;
    }
    internal static void 丘丅丛且丄丗丄丑世()
    {
        FirstPersonControlSharp.<>c val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_62;
        var val_63;
        val_58 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        val_59 = null;
        val_59 = null;
        if(FirstPersonControlSharp.上丒丂丑丙一丗丅丞 != false)
        {
                FirstPersonControlSharp.世万丈一丅上下丂与(丟丄丈上丌东丑丝三:  0);
            val_59 = null;
        }
        
        val_59 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  FirstPersonControlSharp.下丁丑丐与丗世上不)) == false)
        {
            goto label_13;
        }
        
        CoreHapticsUnity.HapticsPattern val_3 = new CoreHapticsUnity.HapticsPattern(capacity:  4);
        CoreHapticsUnity.EventParameter[] val_4 = new CoreHapticsUnity.EventParameter[2];
        val_4[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_4[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.2f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0f, eventType:  0, parameters:  val_4, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_8 = new CoreHapticsUnity.EventParameter[2];
        val_8[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  1f);
        val_8[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.3f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.013f, eventType:  0, parameters:  val_8, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_12 = new CoreHapticsUnity.EventParameter[2];
        val_12[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_12[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.1f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.22f, eventType:  0, parameters:  val_12, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_16 = new CoreHapticsUnity.EventParameter[2];
        val_16[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.7f);
        val_16[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.255f, eventType:  0, parameters:  val_16, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_20 = new CoreHapticsUnity.EventParameter[2];
        val_20[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_20[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.2f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.75f, eventType:  0, parameters:  val_20, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_24 = new CoreHapticsUnity.EventParameter[2];
        val_24[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  1f);
        val_24[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.3f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.763f, eventType:  0, parameters:  val_24, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_28 = new CoreHapticsUnity.EventParameter[2];
        val_28[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_28[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.1f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.97f, eventType:  0, parameters:  val_28, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_32 = new CoreHapticsUnity.EventParameter[2];
        val_32[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.7f);
        val_32[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  1.005f, eventType:  0, parameters:  val_32, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_36 = new CoreHapticsUnity.EventParameter[2];
        val_36[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_36[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.2f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  1.5f, eventType:  0, parameters:  val_36, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_40 = new CoreHapticsUnity.EventParameter[2];
        val_40[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  1f);
        val_40[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.3f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  1.513f, eventType:  0, parameters:  val_40, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_44 = new CoreHapticsUnity.EventParameter[2];
        val_44[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_44[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.1f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  1.72f, eventType:  0, parameters:  val_44, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_48 = new CoreHapticsUnity.EventParameter[2];
        val_48[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.7f);
        val_48[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0f);
        val_60 = 0;
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  1.755f, eventType:  0, parameters:  val_48, duration:  0f));
        var val_58 = 0;
        val_58 = val_58 + 1;
        val_60 = 0;
        goto label_116;
        label_13:
        val_62 = null;
        goto label_117;
        label_116:
        val_62 = null;
        val_62 = null;
        FirstPersonControlSharp.下丁丑丐与丗世上不 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_3);
        label_117:
        val_62 = null;
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayPattern(json:  FirstPersonControlSharp.下丁丑丐与丗世上不);
        FirstPersonControlSharp.丂七与丅丟丁且丁万 = true;
        val_63 = null;
        val_63 = null;
        CoreHapticsUnity.CoreHapticsUnityProxy.remove_OnPatternStopped(value:  new CoreHapticsUnityProxy.HapticStoppedReasonDelegate(object:  FirstPersonControlSharp.<>c.<>9, method:  System.Void FirstPersonControlSharp.<>c::专丈业丛丄业三丙丐(int 专丏不丏东丏丈丆上)));
        val_57 = FirstPersonControlSharp.<>c.<>9;
        CoreHapticsUnity.CoreHapticsUnityProxy.add_OnPatternStopped(value:  new CoreHapticsUnityProxy.HapticStoppedReasonDelegate(object:  val_57, method:  System.Void FirstPersonControlSharp.<>c::专丈业丛丄业三丙丐(int 专丏不丏东丏丈丆上)));
        float val_57 = UnityEngine.Time.realtimeSinceStartup;
        val_57 = val_57 + 2f;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_57;
    }
    internal static void 丄丑不万丏一一丄万()
    {
        string val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_28;
        val_24 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  FirstPersonControlSharp.丙业万一丅丝丅七业)) == false)
        {
            goto label_8;
        }
        
        CoreHapticsUnity.HapticsPattern val_3 = new CoreHapticsUnity.HapticsPattern(capacity:  4);
        CoreHapticsUnity.EventParameter[] val_4 = new CoreHapticsUnity.EventParameter[2];
        val_4[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.8f);
        val_4[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.6f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0f, eventType:  0, parameters:  val_4, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_8 = new CoreHapticsUnity.EventParameter[2];
        val_8[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.4f);
        val_8[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.4f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.015f, eventType:  0, parameters:  val_8, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_12 = new CoreHapticsUnity.EventParameter[2];
        val_12[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.3f);
        val_12[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.3f);
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.03f, eventType:  0, parameters:  val_12, duration:  0f));
        CoreHapticsUnity.EventParameter[] val_16 = new CoreHapticsUnity.EventParameter[2];
        val_16[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.2f);
        val_16[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.2f);
        val_26 = 0;
        val_3.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.045f, eventType:  0, parameters:  val_16, duration:  0f));
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_26 = 0;
        goto label_47;
        label_8:
        val_28 = null;
        goto label_48;
        label_47:
        val_28 = null;
        val_28 = null;
        FirstPersonControlSharp.丙业万一丅丝丅七业 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_3);
        label_48:
        val_28 = null;
        val_23 = FirstPersonControlSharp.丙业万一丅丝丅七业;
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayPattern(json:  val_23);
        float val_23 = UnityEngine.Time.realtimeSinceStartup;
        val_23 = val_23 + 0.06f;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_23;
    }
    internal static void 三与丏上下上下丘丘()
    {
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        val_15 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if(FirstPersonControlSharp.一三世上丞丈丘丝丞 == null)
        {
                CoreHapticsUnity.HapticsPattern val_2 = new CoreHapticsUnity.HapticsPattern(capacity:  2);
            CoreHapticsUnity.EventParameter[] val_3 = new CoreHapticsUnity.EventParameter[2];
            val_3[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.45f);
            val_3[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.75f);
            val_2.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0f, eventType:  0, parameters:  val_3, duration:  0f));
            CoreHapticsUnity.EventParameter[] val_7 = new CoreHapticsUnity.EventParameter[2];
            val_7[0] = new CoreHapticsUnity.EventParameter(id:  0, value:  0.4f);
            val_7[1] = new CoreHapticsUnity.EventParameter(id:  1, value:  0.75f);
            val_17 = 0;
            val_2.AddEvent(_event:  new CoreHapticsUnity.HapticEvent(time:  0.15f, eventType:  0, parameters:  val_7, duration:  0f));
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_17 = 0;
            val_16 = null;
            val_16 = null;
            FirstPersonControlSharp.一三世上丞丈丘丝丞 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_2);
        }
        
        val_16 = null;
        val_14 = FirstPersonControlSharp.一三世上丞丈丘丝丞;
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayPattern(json:  val_14);
        float val_14 = UnityEngine.Time.realtimeSinceStartup;
        val_14 = val_14 + 0.03f;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_14;
    }
    internal static void 丑丅丆丌专上丛丑丆(float 丐不丁专业丌七东丕, float 丘丞丌丙上万丒上丁, float 万丟三且一丗丗丙不)
    {
        var val_3;
        var val_4;
        val_3 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayContinuous(intensity:  丐不丁专业丌七东丕, sharpness:  丘丞丌丙上万丒上丁, durationInSeconds:  万丟三且一丗丗丙不);
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_4 = null;
        val_4 = null;
        val_2 = val_2 + 万丟三且一丗丗丙不;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_2;
    }
    internal static void 上三丈世丟业一丘丘(float 丐不丁专业丌七东丕, float 丘丞丌丙上万丒上丁)
    {
        float val_3;
        var val_4;
        var val_5;
        val_3 = 丘丞丌丙上万丒上丁;
        val_4 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayTransient(intensity:  丐不丁专业丌七东丕, sharpness:  val_3);
        val_5 = null;
        val_3 = UnityEngine.Time.realtimeSinceStartup;
        val_5 = null;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_3;
    }
    internal static void 丌世丂丅专业丛丁丙(float 丟丙丗业与下丅业丛, float 丘丞丐丘三丕与丙丁)
    {
        float val_3 = 0.5f;
        val_3 = val_3 / 丘丞丐丘三丕与丙丁;
        val_3 = val_3 * 丟丙丗业与下丅业丛;
        val_3 = val_3 * 10f;
        float val_4 = 0.3f;
        val_4 = val_4 / 丘丞丐丘三丕与丙丁;
        val_4 = val_4 * 丟丙丗业与下丅业丛;
        val_4 = val_4 * 10f;
        FirstPersonControlSharp.上三丈世丟业一丘丘(丐不丁专业丌七东丕:  UnityEngine.Mathf.Clamp01(value:  val_3), 丘丞丌丙上万丒上丁:  UnityEngine.Mathf.Clamp01(value:  val_4));
    }
    public static void TapticHit(float 丐不丁专业丌七东丕, float 丘丞丌丙上万丒上丁)
    {
        float val_5;
        var val_6;
        float val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_5 = 丐不丁专业丌七东丕;
        val_6 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        if(CoreHapticsUnity.CoreHapticsUnityProxy.IsSupported == false)
        {
            goto label_6;
        }
        
        val_7 = val_5;
        CoreHapticsUnity.CoreHapticsUnityProxy.PlayTransient(intensity:  val_7, sharpness:  丘丞丌丙上万丒上丁);
        goto label_9;
        label_6:
        val_7 = 0.3333f;
        if(val_5 <= val_7)
        {
            goto label_10;
        }
        
        val_7 = 0.6666f;
        if(val_5 <= val_7)
        {
            goto label_11;
        }
        
        val_8 = 2;
        goto label_12;
        label_10:
        val_9 = 0;
        goto label_13;
        label_11:
        val_9 = 1;
        label_13:
        val_10 = null;
        val_10 = null;
        label_12:
        TapticPlugin.丛专丟下专丆丈三丘.丌万且与丝丁业丝世(丆丂东丙业丛下丝丌:  (FirstPersonControlSharp.专丗丏且丕丏世专与 == false) ? (val_9) : (0 + 1));
        label_9:
        val_11 = null;
        val_5 = UnityEngine.Time.realtimeSinceStartup;
        val_11 = null;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = val_5;
        FirstPersonControlSharp.专丗丏且丕丏世专与 = false;
    }
    public static void TapticFall(float 丗且丘与世与三一丝)
    {
        var val_5;
        var val_6;
        float val_5 = 丗且丘与世与三一丝;
        val_5 = null;
        if(FirstPersonControlSharp.不不七东世丝专不丐() == false)
        {
                return;
        }
        
        if(CoreHapticsUnity.CoreHapticsUnityProxy.IsSupported != false)
        {
                val_5 = (val_5 * 0.3f) + 0.3f;
            CoreHapticsUnity.CoreHapticsUnityProxy.PlayTransient(intensity:  val_5, sharpness:  val_5);
        }
        else
        {
                TapticPlugin.丛专丟下专丆丈三丘.丟丄丗丛三一且丐丗(丆丂东丙业丛下丝丌:  1);
        }
        
        val_6 = null;
        val_6 = null;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 == false)
        {
                return;
        }
        
        CoreHapticsUnity.CoreHapticsUnityProxy.Stop();
    }
    public static bool get_IsTapticSupports()
    {
        return false;
    }
    internal void 丕丛丞丙下丛丈丂丛()
    {
        this.丆不丑专丛丈世丁丘 = this.gliderSlowdownPenaltyValue;
        this.三丟丛丌一丐丂丆一 = this.gliderSlowdownPenaltyTime;
    }
    private void 下丆东丝丁丝且下下()
    {
        var val_45;
        float val_46;
        float val_47;
        var val_48;
        if(this.三丟丛丌一丐丂丆一 > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.三丟丛丌一丐丂丆一 - val_1;
            this.三丟丛丌一丐丂丆一 = val_1;
            if(val_1 <= 0f)
        {
                this.三丟丛丌一丐丂丆一 = 0f;
            this.丆不丑专丛丈世丁丘 = 1f;
        }
        
        }
        
        float val_4 = UnityEngine.Mathf.MoveTowards(current:  this.下丟丆丅丅丅丅不丒, target:  this.丆不丑专丛丈世丁丘, maxDelta:  this.gliderSlowdownPenaltySpeed * UnityEngine.Time.deltaTime);
        float val_45 = this.gliderMinigameSpeed;
        float val_44 = this.gliderMinigameSpeedChange;
        this.下丟丆丅丅丅丅不丒 = val_4;
        float val_46 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_7 = this.transform.position;
        float val_47 = val_7.y;
        val_45 = null;
        val_45 = null;
        val_44 = val_45 * val_44;
        UnityEngine.Vector3 val_10 = this.transform.position;
        val_45 = val_45 + (val_44 * this.gliderSlowdownPenaltySpeed);
        val_45 = val_4 * val_45;
        UnityEngine.Vector3 val_13 = this.transform.position;
        val_46 = val_46 * val_45;
        val_47 = val_47 - (GliderTrackController.丄丘七三上丕世丞业.GetMinHeightForPoint(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}));
        UnityEngine.Vector3 val_16 = this.transform.position;
        float val_17 = (GliderTrackController.丄丘七三上丕世丞业.GetMaxHeightForPoint(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) - val_16.y;
        if(val_47 < 0)
        {
                val_46 = (val_47 / val_46) * 57.29578f;
        }
        else
        {
                val_46 = 360f;
        }
        
        if(val_17 < 0)
        {
                val_47 = (val_47 / val_46) * (-57.29578f);
        }
        else
        {
                val_47 = -360f;
        }
        
        UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.Euler(x:  UnityEngine.Mathf.Clamp(value:  val_17 * this.moveRotationGliderMinigame, min:  val_47, max:  val_46), y:  0f, z:  0f);
        val_48 = null;
        val_48 = null;
        UnityEngine.Vector3 val_23 = GliderTrackController.丄丘七三上丕世丞业.GetMoveVector();
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_46);
        UnityEngine.Vector3 val_25 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, point:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        this.世丂业专专丕丗丘丕 = val_25;
        mem[1152921540428564460] = val_25.y;
        mem[1152921540428564464] = val_25.z;
        float val_26 = this.一与东三世丘丞丙丐 * val_24.x;
        UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_26, z:  0f);
        UnityEngine.Vector3 val_28 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w}, point:  new UnityEngine.Vector3() {x = this.世丂业专专丕丗丘丕, y = val_24.y, z = val_24.z});
        this.世丂业专专丕丗丘丕 = val_28;
        float val_48 = this.camRotationYOnMovementMultiplierGliderMinigame;
        mem[1152921540428564460] = val_28.y;
        val_48 = val_26 * val_48;
        mem[1152921540428564464] = val_28.z;
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_48, y:  0f);
        val_26 = val_26 * this.camRotationZOnMovementMultiplierGliderMinigame;
        mem2[0] = UnityEngine.Mathf.Lerp(a:  val_22.x, b:  val_26, t:  UnityEngine.Time.deltaTime * this.enviromentEffectsLerpSpeedGlider);
        float val_49 = this.camFovGliderMinigame;
        val_49 = val_49 + (this.camFovChangeGliderMinigame * val_26);
        float val_43 = UnityEngine.Mathf.Lerp(a:  this.playerCamera.camera.fieldOfView, b:  val_49, t:  UnityEngine.Time.deltaTime * this.enviromentEffectsLerpSpeedGlider);
        if(this.playerCamera != null)
        {
                return;
        }
    
    }
    private void 一丘丅专专丏丆且丝()
    {
        var val_17;
        UnityEngine.Vector3 val_3 = this.transform.position;
        val_17 = null;
        val_17 = null;
        float val_17 = 0.5f;
        val_17 = GliderTrackController.trackWidth * val_17;
        float val_5 = UnityEngine.Mathf.Clamp(value:  val_3.x, min:  GliderTrackController.trackWidth * (-0.5f), max:  val_17);
        UnityEngine.Vector3 val_7 = this.transform.position;
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Vector3 val_12 = this.transform.position;
        float val_14 = UnityEngine.Mathf.Clamp(value:  val_7.y, min:  GliderTrackController.丄丘七三上丕世丞业.GetMinHeightForPoint(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}), max:  GliderTrackController.丄丘七三上丕世丞业.GetMaxHeightForPoint(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}));
        UnityEngine.Vector3 val_16 = this.transform.position;
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丙世丙丘丁不丈且丑(string 丌丟丝丙丑上丟业丘, int 丗丁丟与丞与丏丐丂)
    {
        int val_7 = 丗丁丟与丞与丏丐丂;
        if(val_7 == 1)
        {
                UnityEngine.Debug.LogError(message:  "ERROR: GliderUp -1");
            val_7 = 0;
        }
        
        float val_7 = -100f;
        val_7 = ((float)BalanceController.东丞三万丂丅丑丏丆(丆万一不丌且东丐丐:  丌丟丝丙丑上丟业丘, 丞丌东丟且丒丐丑丂:  0)) / val_7;
        val_7 = val_7 + val_7;
        val_7 = val_7 + 3f;
        this.gliderSlowdownPenaltyTime = val_7;
        一三专丈世丑丆丑丐 val_4 = PlayerCoreSettingsStorager.dynamicSettings;
        val_4.丘上世丛丅丈丞丂丆.丗丆丞三丙专七且丆 = 1f;
        一三专丈世丑丆丑丐 val_5 = PlayerCoreSettingsStorager.dynamicSettings;
        float val_8 = 100f;
        float val_6 = ((float)BalanceController.上丞七东丝三丄东世(丆万一不丌且东丐丐:  丌丟丝丙丑上丟业丘, 丞丌东丟且丒丐丑丂:  0)) / val_8;
        val_8 = ((float)BalanceController.三丞丛且丐丏丕丅丅(丆万一不丌且东丐丐:  丌丟丝丙丑上丟业丘, 丞丌东丟且丒丐丑丂:  0)) / val_8;
        float val_9 = 1f;
        val_6 = val_6 * 3f;
        val_8 = val_8 * 20f;
        val_9 = val_6 + val_9;
        val_8 = val_8 + 60f;
        val_5.丘上世丛丅丈丞丂丆.不万丟且上东丅丙且 = val_9;
        this.gliderMinigameSpeed = val_8;
    }
    public FirstPersonControlSharp()
    {
        this.丟一万丗上不下丕丌 = 10;
        this.丗丒丅一丗丑丌丂万 = 3.402823E+38f;
        this.万丑且丄丘丕丆七丆 = 9.183409E-41f;
        this.accuracyMoveModifier = 2f;
        this.ladderSpeed = 2f;
        this.slowdownList = new System.Collections.Generic.List<SlowdownCollider>();
        this.专与丛七与丏丝上丅 = 1f;
        this.丁下丏一业丗业丗三 = 1f;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  30f, y:  30f);
        this.丕丅东丁丛丌上丛丌 = val_2.x;
        mem[1152921540429028360] = val_2.y;
        this.世丅上丁丂丝丆丗丞 = 0.6f;
        this.万世东丞丑丟丒世三 = 1f;
        this.一丐丒一丒丈丛丐丂 = 0.25f;
        this.上丛七丂丐下一丐丗 = true;
        this.丏丆丆丒丗丗丙丈丁 = 60f;
        this.一丙专丄丗东丟丞丂 = true;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  100f, y:  50f);
        mem[1152921540429028472] = val_3.y;
        this.丅丅三与三七与丐上 = val_3.x;
        mem2[0] = ;
        mem2[0] = 1050253722;
        this.上丝世丌丕万丈丒丕 = 0.4f;
        this.万与丏丑世业丒丒丞 = 5.510186E-41f;
        this.万丟丗且专丁丟与丏 = 1.2f;
        this.丑丌东丆世丁丟东丟 = 0.1f;
        mem2[0] = 1073741824;
        this.万丐丕丄业丗丛专丁 = 180f;
        mem2[0] = 1119092736;
        this.batleRoyaleAdditionalLandingGravity = 0.2f;
        this.丆丒世丁七下一不丈 = true;
        this.丐东丁东一丙丈丘丐 = 0f;
        this.业丙专丒丕与世丄丄 = 1f;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        this.丗丈丂丐丁丟丙丝东 = val_4;
        mem[1152921540429028636] = val_4.y;
        this.专不专丈丘专丘丟世 = true;
        this.丑且丕丞上丂丙业七 = true;
        this.丅三世万丕丄丗丑三 = true;
        this.joystickDeadZone = 0.2f;
        this.丂丛万丑不上东不丛 = 30f;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.丙与丁且且七丒世不 = val_5;
        mem[1152921540429028740] = val_5.y;
        mem[1152921540429028744] = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.丙丛丞专丄丗三丂丄 = val_6;
        mem[1152921540429028752] = val_6.y;
        mem[1152921540429028756] = val_6.z;
        this.丞专三不不世丏丅丐 = 50f;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.丅下东丛丈丞丟丘丞 = 20f;
        this.runJoystickAngleDeadZone = 45f;
        mem[1152921540429028784] = val_7.z;
        this.丗七丘与丟万丆丛丁 = -1000f;
        this.专万且七丐丗丆丐丑 = 0;
        this.freePlayMinHeightForGlide = 12f;
        this.丞丌丆丐丂与下丁万 = val_7;
        mem[1152921540429028780] = val_7.y;
        this.runJoystickAngle = 30f;
        this.世丈丂丌一丅上世丛 = 50f;
        this.不丒东业丙丘业下丁 = 0.8f;
        this.丘丑丗与丛丂丞丑丘 = 7.346868E-41f;
        this.royalePlayerSpeedFromJoystickModifier = 0.7f;
        this.freePlayMinHeightForFly = 16f;
        this.freePlayHeightDifferenceForFly = 4f;
        this.freePlayLandHeight = 4f;
        this.万丒丘丛世上丈丁东 = true;
        this.七七七丗丕丒三丄一 = true;
        this.丗丌不丁丁丁与丐与 = 1f;
        this.且丘丘丒丂与东丗且 = 10f;
        this.丄丛东一三且业与丅 = 1f;
        this.丐一万丐东上与丟丑 = ;
        this.丄丁七丘丟上丞丞世 = ;
        this.丏丐丝丌丌丂七上专 = 2f;
        this.且万下丙丏不万丙丈 = 1f;
        this.speedCoefFlyOnGliderByJoystik = ;
        this.speedFlyDownOnGlider = ;
        this.speedFlyDown = 7f;
        this.speedCoefFlyByJoystik = 3f;
        this.speedCoefFlyDownInDine = ;
        this.七且东丌丛丕丁丘丒 = ;
        this.七不东丘丐专且丐丛 = 360f;
        this.丆丕与丁且三丕丞世 = 120f;
        this.standingIdleTimeout = 0.5f;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        this.丙一三业丂丁专丛万 = 0.2f;
        this.万世丆丘不丏丐上丄 = 2.938803E-41f;
        this.与丗丑丟丅丌且万专 = 0.74f;
        this.丒上七丘且丕不七丙 = val_8;
        this.三与丐丏东世丄丂丑 = 0.075f;
        this.丅丏丆下丞丟丏七丙 = 0.3f;
        mem[1152921540429028992] = val_8.y;
        mem[1152921540429028996] = val_8.z;
        this.丅丗下东且万丌丈丞 = 10f;
        this.weaponsFeedbackForceSens = 1f;
        this.不万丈丙丏且万丁七 = 5f;
        this.丌丑丟三上丅丝上丑 = 15f;
        mem2[0] = ;
        this.丕丘专三丘丗下丌丗 = 1f;
        this.且丈丟丏专业丕丗丆 = true;
        this.weaponFollowLagSensitive = 1f;
        this.maxWeaponFollowLag = 5f;
        this.weaponFollowLagSpped = 5f;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
        this.丄丘丘丗丅丅不万一 = val_9;
        mem[1152921540429029280] = val_9.y;
        mem[1152921540429029284] = val_9.z;
        mem2[0] = ;
        this.maxNegativeVelocityYPerFrame = -15f;
        this.maxPositiveVelocityYPerFrame = 15f;
        mem2[0] = 2143289344;
        this.gliderMinigameSpeed = 0f;
        this.gliderMinigameSpeedChange = 0.5f;
        this.gliderStartRotationXMinigame = 10f;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  15f, y:  30f);
        this.gliderRotationTimeMinigame = 0.6f;
        this.gliderMaxRotationMinigame = val_10.x;
        mem[1152921540429029368] = val_10.y;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  30f, y:  30f);
        this.moveRotationGliderMinigame = val_11.x;
        mem[1152921540429029380] = val_11.y;
        mem2[0] = ;
        this.enviromentEffectsLerpSpeedGlider = 3f;
        mem2[0] = ;
        this.下丟丆丅丅丅丅不丒 = 1f;
    }
    private static FirstPersonControlSharp()
    {
        FirstPersonControlSharp.且丝不世丞世丅丌丗 = 3.7f;
        FirstPersonControlSharp.丗丟丈一丁七丛丞丙 = 63f;
        FirstPersonControlSharp.三专专世丆丏丌不七 = 0.2f;
        FirstPersonControlSharp.三丏丅丐丏与下世丗 = 6.5f;
        FirstPersonControlSharp.与上丒丛三万丌万上 = -1f;
        FirstPersonControlSharp.世丟丑丗上万与专且 = 0;
        FirstPersonControlSharp.上丒丂丑丙一丗丅丞 = false;
        FirstPersonControlSharp.丂七与丅丟丁且丁万 = false;
        FirstPersonControlSharp.丟丆丒三不且丐丕丑 = true;
        FirstPersonControlSharp.丏丕一丟丑世丕丙丁 = -1f;
        FirstPersonControlSharp.专丗丏且丕丏世专与 = false;
        FirstPersonControlSharp.丗丞丂丘丂世丐丑丒 = false;
        FirstPersonControlSharp.三七丁丕丁万万三不 = false;
    }

}
