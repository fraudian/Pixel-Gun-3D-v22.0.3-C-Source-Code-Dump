using UnityEngine;
public class TrainingController : MonoBehaviour
{
    // Fields
    private static System.Action<丘丌丒丑一七丁丑一> 丆世万一丞丐丞丟丕;
    private UnityEngine.GameObject capturePointsController;
    private UnityEngine.GameObject roofLight;
    private UnityEngine.GameObject zombiesLight;
    private UnityEngine.GameObject helicopterLight;
    private UnityEngine.GameObject nickLabelRobbie;
    private UnityEngine.GameObject tapToMoveLines;
    private UnityEngine.GameObject doTheJumpLines;
    private UnityEngine.GameObject goToPortalLines;
    private 丘丌丒丑一七丁丑一 且丞丄丙丏上丂丁丒;
    private static bool <丞丂丛与七丒丈丝丄>k__BackingField;
    internal static TrainingController 丄丞丁丈与业上丞丟;
    internal const string 丛下专丑万下世丛丌 = "TrainingController.NewTrainingStageHolderKey";
    public UnityEngine.GameObject swipeToRotateOverlay;
    public UnityEngine.GameObject dragToMoveOverlay;
    public UnityEngine.GameObject pickupGunOverlay;
    public UnityEngine.GameObject touch3dPressGun;
    public UnityEngine.GameObject wellDoneOverlay;
    public UnityEngine.GameObject getCoinOverlay;
    public UnityEngine.GameObject enterShopOverlay;
    public UnityEngine.GameObject shopArrowOverlay;
    public UnityEngine.GameObject swipeToChangeWeaponOverlay;
    public UnityEngine.GameObject tapToChangeWeaponOverlay;
    public UnityEngine.GameObject shootReloadOverlay;
    public UnityEngine.GameObject selectGrenadeOverlay;
    public UnityEngine.GameObject buyGrenadeArrowOverlay;
    public UnityEngine.GameObject throwGrenadeOverlay;
    public UnityEngine.GameObject throwGrenadeArrowOverlay;
    public UnityEngine.GameObject overlaysRoot;
    public UnityEngine.GameObject joystickFingerOverlay;
    public UnityEngine.GameObject joystickShadowOverlay;
    public UnityEngine.GameObject touchpadOverlay;
    public UnityEngine.GameObject touchpadFingerOverlay;
    public UnityEngine.GameObject jumpOverlay;
    public UnityEngine.GameObject jumpFingerOverlay;
    public UnityEngine.GameObject jumpOverlayCircle;
    public UnityEngine.GameObject shootOverlay;
    public UnityEngine.GameObject swipeWeaponFingerOverlay;
    public UnityEngine.GameObject tapWeaponArrowOverlay;
    private bool 丁丘丞一且七业万上;
    public UnityEngine.GameObject swipeToRotateCont;
    public UnityEngine.GameObject tapToJumpCont;
    public UnityEngine.GameObject tapToShootCont;
    public UnityEngine.GameObject dragToMoveCont;
    public UnityEngine.GameObject wellDoneCont;
    public UnityEngine.GameObject goToHelicopterCont;
    public UnityEngine.GameObject enemyPrototype;
    public UnityEngine.GameObject[] enemies;
    public UnityEngine.Transform teleportTransform;
    public UnityEngine.Transform weaponTransform;
    public UnityEngine.Transform playerTransform;
    public UnityEngine.GameObject helicopter;
    public UnityEngine.Animator craneAndRobot;
    public UnityEngine.GameObject trainingOverlaysNew;
    private bool 专丏丕一丒丆丏丄万;
    private static readonly UnityEngine.Vector3 丂丟丛丕东丈丛丒丌;
    private UnityEngine.GameObject[] 一万业专丙丑丂下丙;
    private static 丘丌丒丑一七丁丑一 丅一丝一丆专一东丆;
    internal static System.Collections.Generic.Dictionary<string, 丘丌丒丑一七丁丑一> 万丑下丗业且万丄下;
    private static 丘丌丒丑一七丁丑一 专丅三七丈与下世丙;
    internal static bool 丙专丆丏七丕丄上丗;
    internal static bool 世下丐丌一丗一丞丌;
    private UnityEngine.Rect 万丕与与下丅不与丙;
    private static bool 丐丒丞丌万丙丂万丏;
    private UnityEngine.GameObject 丌丄丑三上三丟一丒;
    private UnityEngine.Texture2D[] 丄万丒丞丞丝丞丆万;
    private static int 世丒丗上不丑东丌丞;
    private static int 丟且丏丙丆丒上丟丐;
    private static bool 且业丌丄丑丄丏丟丙;
    private float 与专不丗丕丐不且丝;
    private static 丘丌丒丑一七丁丑一 不丌丄丙万丅且丛丛;
    private UnityEngine.Texture2D 丑上丅丏七万东丗丕;
    private UnityEngine.Texture2D 丆丑丒丅丆东上丙业;
    private bool 丕业丄业丁业丈七世;
    private static 丘丌丒丑一七丁丑一 七丄丅上下丒丘丈万;
    private UIButton 丟专丏丒丗七丈一七;
    private static System.Nullable<bool> 丏丝下丁丒丈不万下;
    private Rilisoft.丝丄丄不丏丘丝世丗 丞不丝丈丌丙丅世丟;
    private readonly System.Collections.Generic.List<Rilisoft.TrainingEnemy> 三东丙万丝丟丛丅丏;
    private UIButton 丕丕丑世专上业丏丅;
    private int 下丂万丒丏专丁丌丑;
    private bool 丅万丄丞东上丐三不;
    internal static 丘丌丒丑一七丁丑一 七专业一丂万丛丝上;
    private float 与三丝丈丑丑丟丗丁;
    private UnityEngine.Transform positionNeedTapToMove;
    private static float 与东丗丘丈丙丝世三;
    private float 丁丛丟丕丐丏丟丗丌;
    private float 专不丂且丅丒七且丘;
    private UISprite 七丕万丈丆与丂丟丄;
    private RilisoftBot.MeleeBot[] 丝业且丈万丏丒三万;
    private SelectionControlMode selectionControlMode;
    public bool forceHideArrow;
    internal static float 丟丄且丕丄丟丄东丛;
    internal static float 丐与丟不丆丂业丛丙;
    private bool 丌丏上东丐丝丂不丙;
    private bool 且丒丘下三业丘丏东;
    private bool 与下丏丅丁且丁丈丒;
    internal static bool 丏丛世丄丈丙不丄丞;
    private float 丐丝丞丂丐丘丗丈一;
    private float 七一丑且丑丌下丂丞;
    private float 不世丄丛丞七丘丝丏;
    private float 丕世且丄丐丝丏丆丆;
    private UnityEngine.GameObject teleportObj;
    private UnityEngine.GameObject 丌丝下丄业一丄不三;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<PlayerArrowToPortalController> 丄丞丂丟与丌丁三东;
    internal static readonly 丈丞丕丘丕丗与上一 丈不丄世丙丁三丏丂;
    internal static readonly 丈丞丕丘丕丗与上一 丟丘与丌丛丏与三丞;
    internal static readonly 丈丞丕丘丕丗与上一 业丆丐丈丅丗且东七;
    
    // Properties
    public static bool 丈丆不三一丆丘丛且 { get; }
    internal static bool 丄丏东丘丏丕丞且丈 { get; set; }
    public UnityEngine.Vector3 丏丒丕且三丟丆上且 { get; }
    internal static UnityEngine.Vector3 不三与专丏丗丏丐世 { get; }
    internal float 与丒专丗丆专七丌世 { get; }
    internal static 丘丌丒丑一七丁丑一 丗丈下业且丛一丂丗 { get; set; }
    internal static 丘丌丒丑一七丁丑一 丞业丟万丞丈丕丌下 { get; set; }
    internal static System.Nullable<bool> 丆丗丌专丅丆三丒上 { get; set; }
    internal static bool 丄丘丆丁丘东丗专丟 { get; }
    public bool 下丗丌丞丄丞丕不一 { get; }
    private int 丕丞丄丈万丟丟业丑 { get; }
    private bool 丅丅专丄业丒丆丘丞 { get; }
    
    // Methods
    internal static void 丒丁丞丁丂丞丁丛丙(System.Action<丘丌丒丑一七丁丑一> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  TrainingController.丛下专丑万下世丛丌, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 且万丕丈一丈丒与下(System.Action<丘丌丒丑一七丁丑一> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  TrainingController.丛下专丑万下世丛丌, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static bool get_NeedTraining()
    {
        bool val_2 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    internal static void 丂世万业丌七丂万丁()
    {
        TrainingController.丄丑七下丈丅丂三与(丙业与丙丗丝不丈东:  0);
        TrainingController.七专业一丂万丛丝上 = TrainingController.丁丑七与丙丐丘丌下();
    }
    internal static void 丛丒丝丅丞丁且业上(丘丌丒丑一七丁丑一 丏丘丙丆三丕丕上丌)
    {
        null = null;
        if(TrainingController.丛下专丑万下世丛丌 == null)
        {
                return;
        }
        
        TrainingController.丛下专丑万下世丛丌.Invoke(obj:  丏丘丙丆三丕丕上丌);
    }
    internal static bool 丆世东丐丑东丙丂丝()
    {
        null = null;
        return (bool)TrainingController.<丞丂丛与七丒丈丝丄>k__BackingField;
    }
    internal static void 世丏丑下丕丟丆丗丛(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        TrainingController.<丞丂丛与七丒丈丝丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Vector3 get_PlayerDesiredPosition()
    {
        var val_2;
        if(this.playerTransform != 0)
        {
                if(this.playerTransform != null)
        {
                return this.playerTransform.position;
        }
        
            return this.playerTransform.position;
        }
        
        val_2 = null;
        val_2 = null;
        return new UnityEngine.Vector3() {x = TrainingController.丂丟丛丕东丈丛丒丌, y = TrainingController.丛下专丑万下世丛丌.__il2cppRuntimeField_1C, z = TrainingController.丛下专丑万下世丛丌.__il2cppRuntimeField_20};
    }
    internal static UnityEngine.Vector3 丘世与且万丟与丑一()
    {
        null = null;
        return new UnityEngine.Vector3() {x = TrainingController.丂丟丛丕东丈丛丒丌, y = TrainingController.丛下专丑万下世丛丌.__il2cppRuntimeField_1C, z = TrainingController.丛下专丑万下世丛丌.__il2cppRuntimeField_20};
    }
    internal float 三专丁不丝丄丒丅东()
    {
        UnityEngine.Quaternion val_1 = this.playerTransform.localRotation;
        return (float)val_1.y;
    }
    internal static 丘丌丒丑一七丁丑一 丁丑七与丙丐丘丌下()
    {
        null = null;
        return (丘丌丒丑一七丁丑一)TrainingController.丅一丝一丆专一东丆;
    }
    private static void 丄丑七下丈丅丂三与(丘丌丒丑一七丁丑一 丙业与丙丗丝不丈东)
    {
        null = null;
        TrainingController.丅一丝一丆专一东丆 = 丙业与丙丗丝不丈东;
    }
    internal static 丘丌丒丑一七丁丑一 丟丑丆丁下丛丂丕丝()
    {
        null = null;
        return (丘丌丒丑一七丁丑一)TrainingController.专丅三七丈与下世丙;
    }
    internal static void 丝丅七丁丂下丘丞世(丘丌丒丑一七丁丑一 丙业与丙丗丝不丈东)
    {
        null = null;
        TrainingController.专丅三七丈与下世丙 = 丙业与丙丗丝不丈东;
    }
    internal static System.Nullable<bool> 万丑万专丑三专丏丟()
    {
        null = null;
        return (System.Nullable<System.Boolean>)TrainingController.丏丝下丁丒丈不万下;
    }
    internal static void 与丅一丂专东丘丈世(System.Nullable<bool> 丙业与丙丗丝不丈东)
    {
        null = null;
        TrainingController.丏丝下丁丒丈不万下 = 丙业与丙丗丝不丈东.HasValue;
    }
    private static TrainingController()
    {
        var val_5;
        TrainingController.丄丞丁丈与业上丞丟 = 0;
        TrainingController.丂丟丛丕东丈丛丒丌 = 0;
        TrainingController.丛下专丑万下世丛丌.__il2cppRuntimeField_20 = 0;
        TrainingController.丅一丝一丆专一东丆 = 0;
        System.Collections.Generic.Dictionary<System.String, 丘丌丒丑一七丁丑一> val_1 = new System.Collections.Generic.Dictionary<System.String, 丘丌丒丑一七丁丑一>(capacity:  10);
        TrainingController.万丑下丗业且万丄下 = val_1;
        TrainingController.专丅三七丈与下世丙 = 0;
        TrainingController.世下丐丌一丗一丞丌 = false;
        TrainingController.丐丒丞丌万丙丂万丏 = false;
        TrainingController.不丌丄丙万丅且丛丛 = 0;
        TrainingController.丟丄且丕丄丟丄东丛 = 0f;
        TrainingController.丐与丟不丆丂业丛丙 = 0f;
        TrainingController.丏丛世丄丈丙不丄丞 = false;
        val_5 = null;
        val_5 = null;
        TrainingController.丈不丄世丙丁三丏丂 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  10, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        TrainingController.丟丘与丌丛丏与三丞 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  3, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        TrainingController.业丆丐丈丅丗且东七 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  1, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        val_1.Add(key:  "TapToMove", value:  2);
        val_1.Add(key:  "GetTheGun", value:  3);
        val_1.Add(key:  "WellDone", value:  4);
        val_1.Add(key:  "Shop", value:  107);
        val_1.Add(key:  "TapToSelectWeapon", value:  108);
        val_1.Add(key:  "TapToShoot", value:  109);
        val_1.Add(key:  "TapToThrowGrenade", value:  110);
        val_1.Add(key:  "KillZombi", value:  5);
        val_1.Add(key:  "GoToPortal", value:  6);
    }
    public TrainingController()
    {
        var val_7;
        System.Action val_9;
        var val_10;
        System.Func<PlayerArrowToPortalController> val_12;
        this.一万业专丙丑丂下丙 = new UnityEngine.GameObject[0];
        val_7 = null;
        val_7 = null;
        val_9 = TrainingController.<>c.<>9__104_1;
        if(val_9 == null)
        {
                System.Action val_2 = null;
            val_9 = val_2;
            val_2 = new System.Action(object:  TrainingController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TrainingController.<>c::一与丂下丘七丅万专());
            TrainingController.<>c.<>9__104_1 = val_9;
        }
        
        this.丞不丝丈丌丙丅世丟 = new Rilisoft.丝丄丄不丏丘丝世丗(七丐丅专且专七三丆:  val_2);
        this.三东丙万丝丟丛丅丏 = new System.Collections.Generic.List<Rilisoft.TrainingEnemy>(capacity:  3);
        this.与三丝丈丑丑丟丗丁 = 2f;
        this.forceHideArrow = true;
        this.七一丑且丑丌下丂丞 = 2f;
        this.丕世且丄丐丝丏丆丆 = 2f;
        val_10 = null;
        val_10 = null;
        val_12 = TrainingController.<>c.<>9__104_0;
        if(val_12 == null)
        {
                System.Func<PlayerArrowToPortalController> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Func<PlayerArrowToPortalController>(object:  TrainingController.<>c.__il2cppRuntimeField_static_fields, method:  PlayerArrowToPortalController TrainingController.<>c::且东丄与三丅丗丝丏());
            TrainingController.<>c.<>9__104_0 = val_12;
        }
        
        this.丄丞丂丟与丌丁三东 = new Rilisoft.七丞丞丅东丞专丙丝<PlayerArrowToPortalController>(丙丂丌且丌世丒丐三:  val_5);
    }
    internal static void 三世丈且一三且丕丌()
    {
        var val_5;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "InstallTime_after_12_6_1_Key")) != true)
        {
                System.DateTime val_2 = 专七专下且专三一且.丐世丈专与东丏丛丑();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "InstallTime_after_12_6_1_Key", 下下丏一丙不丘丌丞:  val_2.dateData);
        }
        
        与丂丏丛丞丞丒丟丄.与丅且丅丐丄与丅丗(丙业与丙丗丝不丈东:  true);
        val_5 = null;
        val_5 = null;
        ABTestController.丄丘七三上丕世丞业.丐丄世丆丈丝一丞丂();
        业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
        丘丒丄丗丄丒丆不丄.与一丅丝不丈业与丙().三世丈且一三且丕丌();
    }
    internal static bool 下且丌丑丟丒丒丗丞()
    {
        return (bool)(TrainingController.丁丑七与丙丐丘丌下() > 4) ? 1 : 0;
    }
    internal static void 丗丞三一丆业三丝丝()
    {
        TrainingController.七丄丅上下丒丘丈万 = TrainingController.丁丑七与丙丐丘丌下();
        TrainingController.丄丑七下丈丅丂三与(丙业与丙丗丝不丈东:  0);
        TrainingController.丙专丆丏七丕丄上丗 = true;
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        TrainingController.丏丝下丁丒丈不万下 = 0;
        Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "Training complete", 丛东不丒丏丈丄且丕:  new System.Collections.Generic.Dictionary<System.String, System.String>());
    }
    internal static void 丗丙下丑丐不一世丝()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        TrainingController.且业丌丄丑丄丏丟丙 = false;
        TrainingController.丙专丆丏七丕丄上丗 = false;
        TrainingController.丄丑七下丈丅丂三与(丙业与丙丗丝不丈东:  TrainingController.七丄丅上下丒丘丈万);
        TrainingController val_2 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "TrainingController").GetComponent<TrainingController>();
        val_4 = null;
        if(TrainingController.丐丒丞丌万丙丂万丏 != false)
        {
                TrainingController.丐丒丞丌万丙丂万丏 = false;
            val_2.StartNextStepTraning();
            val_4 = null;
        }
        
        val_4 = null;
        if(val_2 == null)
        {
            goto label_10;
        }
        
        if(TrainingController.世丒丗上不丑东丌丞 == 0)
        {
            goto label_11;
        }
        
        label_12:
        val_2.NextStepAnim();
        return;
        label_10:
        if(TrainingController.世丒丗上不丑东丌丞 != 0)
        {
            goto label_12;
        }
        
        label_11:
        val_2.FirstStep();
    }
    private void 下专专丈与丒丄丌丅()
    {
        if((UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.不东丞专三丄丏丕丕(), defaultValue:  0)) != 1)
        {
                return;
        }
        
        if(this.shootReloadOverlay == 0)
        {
                return;
        }
        
        this = this.shootReloadOverlay.transform;
        UnityEngine.Vector3 val_6 = this.shootReloadOverlay.transform.localPosition;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private System.Collections.IEnumerator 丕世七丐丆丝专上丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TrainingController.丑丏丐丘丅世丛丟丅();
    }
    private void 上丌三且丐三与下丞()
    {
        var val_10;
        var val_11;
        float val_12;
        float val_13;
        float val_14;
        var val_15;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        val_13 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f) * (float)与丂丏丛丞丞丒丟丄.丂丁丑丈万丛丞丅丗;
        val_14 = (float)与丂丏丛丞丞丒丟丄.丙丆丒丟万丈一与丕;
        if(this.dragToMoveCont != 0)
        {
                this.dragToMoveCont.SetActive(value:  true);
        }
        
        val_15 = null;
        val_15 = null;
        UnityEngine.Vector3[] val_4 = Load.丏丙上丞丏丆丏丙不(丒丘丏上丙丟丑丕丈:  ControlsSettingsBase.且一不丅上三丗丒一);
        if((val_4 != null) && (val_4.Length >= 5))
        {
                UnityEngine.Vector3 val_11 = val_4[7];
        }
        
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_14 = 5f;
            val_13 = val_4[6] + val_14;
        }
        
        if(this.joystickShadowOverlay == 0)
        {
                return;
        }
        
        val_10 = this.joystickShadowOverlay.transform;
        UnityEngine.Vector3 val_9 = transform.position;
        val_12 = val_9.x;
        val_10.position = new UnityEngine.Vector3() {x = val_12, y = val_9.y, z = val_9.z};
    }
    private void 三丌专与万业丙与下()
    {
        var val_19;
        var val_23;
        var val_24;
        float val_25;
        UnityEngine.Object val_26;
        float val_27;
        float val_28;
        UnityEngine.Object val_29;
        val_19 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_23 = null;
        val_23 = null;
        UnityEngine.Vector3[] val_2 = Load.丏丙上丞丏丆丏丙不(丒丘丏上丙丟丑丕丈:  ControlsSettingsBase.且一不丅上三丗丒一);
        if((val_2 != null) && (val_2.Length > 5))
        {
                UnityEngine.Vector3 val_19 = val_2[7];
            UnityEngine.Vector3 val_20 = val_2[8];
        }
        else
        {
                val_24 = null;
            val_24 = null;
            float val_21 = (float)与丂丏丛丞丞丒丟丄.业丆上丆三世丆丑不;
            val_21 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 1f : -1f) * val_21;
        }
        
        val_26 = 0;
        if(this.buyGrenadeArrowOverlay != 0)
        {
                val_26 = this.buyGrenadeArrowOverlay.GetComponent<TrainingArrow>();
        }
        
        if(val_26 != 0)
        {
                val_27 = 0f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = val_19, z = val_20}, b:  new UnityEngine.Vector3() {x = 0f, y = val_27, z = 0f});
            val_25 = val_8.x;
            val_28 = val_8.y;
            val_26.SetAnchoredPosition(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_25, y = val_28, z = val_8.z});
        }
        
        val_29 = 0;
        if(this.throwGrenadeArrowOverlay != 0)
        {
                val_29 = this.throwGrenadeArrowOverlay.GetComponent<TrainingArrow>();
        }
        
        if(val_29 != 0)
        {
                val_27 = 0f;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = val_19, z = val_20}, b:  new UnityEngine.Vector3() {x = 0f, y = val_27, z = 0f});
            val_25 = val_12.x;
            val_28 = val_12.y;
            val_29.SetAnchoredPosition(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_25, y = val_28, z = val_12.z});
        }
        
        if(this.selectGrenadeOverlay != 0)
        {
                val_27 = 0f;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = val_19, z = val_20}, b:  new UnityEngine.Vector3() {x = 0f, y = val_27, z = 0f});
            val_25 = val_15.x;
            val_28 = val_15.y;
            this.selectGrenadeOverlay.transform.localPosition = new UnityEngine.Vector3() {x = val_25, y = val_28, z = val_15.z};
        }
        
        if(this.throwGrenadeOverlay == 0)
        {
                return;
        }
        
        val_19 = this.throwGrenadeOverlay.transform;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = val_19, z = val_20}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_25 = val_18.x;
        val_19.localPosition = new UnityEngine.Vector3() {x = val_25, y = val_18.y, z = val_18.z};
    }
    private void Awake()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        TrainingController.丄丞丁丈与业上丞丟 = this;
        TrainingController.丏丛世丄丈丙不丄丞 = false;
        与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  true);
        this.tapToMoveLines.SetActive(value:  false);
        this.doTheJumpLines.SetActive(value:  false);
        this.goToPortalLines.SetActive(value:  false);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丕世七丐丆丝专上丘());
        this.丝业且丈万丏丒三万 = new RilisoftBot.MeleeBot[0];
        val_6 = 0;
        goto label_9;
        label_20:
        RilisoftBot.MeleeBot val_4 = this.enemies[0].GetComponent<RilisoftBot.MeleeBot>();
        if(this.丝业且丈万丏丒三万 == null)
        {
            goto label_13;
        }
        
        if(val_4 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_4 == null)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        val_6 = 1;
        this.丝业且丈万丏丒三万[0] = val_4;
        label_9:
        if(val_6 < this.enemies.Length)
        {
            goto label_20;
        }
    
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TrainingController::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
        if(TrainingController.丁丑七与丙丐丘丌下() > 5)
        {
                return;
        }
        
        FpsManager.丒丗一丟丌下七丗丒();
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TrainingController::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TrainingController.丕丄七丏与丕丝丆丄();
    }
    private void OnDestroy()
    {
        null = null;
        TrainingController.丄丞丁丈与业上丞丟 = 0;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.丕丕丑世专上业丏丅, y:  0);
        this.丞不丝丈丌丙丅世丟.Dispose();
    }
    private void 丌丗丙丅丆且丑不不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下丂万丒丏专丁丌丑 >= 1)
        {
                if(TrainingController.丁丑七与丙丐丘丌下() == 108)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  108);
        }
        
        }
        
        int val_2 = this.下丂万丒丏专丁丌丑;
        val_2 = val_2 + 1;
        this.下丂万丒丏专丁丌丑 = val_2;
    }
    public void StartNextStepTraning()
    {
        var val_13;
        var val_14;
        float val_17;
        var val_18;
        val_13 = null;
        val_13 = null;
        if(GameController.丒且丅丙丏丙不丒丙 == true)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        if(TrainingController.丙专丆丏七丕丄上丗 != false)
        {
                TrainingController.丐丒丞丌万丙丂万丏 = true;
            return;
        }
        
        丘丌丒丑一七丁丑一 val_1 = TrainingController.丁丑七与丙丐丘丌下();
        this.且丞丄丙丏上丂丁丒 = ((val_1 + 1) == 4) ? (val_1 + 2) : (val_1 + 1);
        val_17 = 0f;
        if((TrainingController.丁丑七与丙丐丘丌下() == 0) || (TrainingController.丁丑七与丙丐丘丌下() == 4))
        {
            goto label_34;
        }
        
        TrainingController.丄丑七下丈丅丂三与(丙业与丙丗丝不丈东:  4);
        if(TrainingController.丁丑七与丙丐丘丌下() != 4)
        {
                if(TrainingController.丁丑七与丙丐丘丌下() != 105)
        {
            goto label_22;
        }
        
        }
        
        HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "press_jump");
        val_18 = null;
        val_18 = null;
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        TrainingController.丟且丏丙丆丒上丟丐 = true;
        this.与专不丗丕丐不且丝 = 1f;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        val_17 = 2.5f;
        if(this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一() == 0)
        {
            goto label_34;
        }
        
        this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一().一专丘东三丞东丁三();
        goto label_34;
        label_22:
        val_17 = 2.5f;
        label_34:
        this.与三丝丈丑丑丟丗丁 = 0f;
        this.Invoke(methodName:  "ResumeNextStepTraining", time:  val_17);
    }
    private void ResumeNextStepTraining()
    {
        Rilisoft.TrainingEnemy val_130;
        Rilisoft.TrainingEnemy val_131;
        float val_132;
        float val_133;
        float val_134;
        float val_135;
        float val_136;
        float val_137;
        float val_138;
        int val_139;
        var val_140;
        UnityEngine.GameObject val_141;
        var val_142;
        var val_143;
        var val_144;
        var val_145;
        var val_146;
        var val_147;
        var val_148;
        UnityEngine.Object val_149;
        var val_150;
        var val_151;
        var val_152;
        UnityEngine.Object val_153;
        var val_154;
        var val_155;
        var val_156;
        var val_157;
        var val_158;
        var val_159;
        UnityEngine.Texture2D[] val_160;
        UnityEngine.Object val_161;
        var val_162;
        var val_163;
        UnityEngine.Object val_164;
        var val_165;
        TrainingController.丄丑七下丈丅丂三与(丙业与丙丗丝不丈东:  this.且丞丄丙丏上丂丁丒);
        this.丅万丄丞东上丐三不 = false;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if(TrainingController.丁丑七与丙丐丘丌下() != 1)
        {
            goto label_47;
        }
        
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        TrainingController.丟且丏丙丆丒上丟丐 = 13;
        this.与专不丗丕丐不且丝 = 0.5f;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        if((this.enemies == null) || (this.enemies.Length == 0))
        {
            goto label_9;
        }
        
        if(this.enemies.Length < 1)
        {
            goto label_47;
        }
        
        val_130 = 1152921540550587104;
        do
        {
            UnityEngine.GameObject val_126 = this.enemies[0];
            val_131 = val_126.GetComponent<Rilisoft.TrainingEnemy>();
            if(val_131 == null)
        {
                val_131 = val_126.AddComponent<Rilisoft.TrainingEnemy>();
        }
        
            this.三东丙万丝丟丛丅丏.Add(item:  val_131);
        }
        while(1 < this.enemies.Length);
        
        goto label_47;
        label_9:
        if(this.enemyPrototype != 0)
        {
                UnityEngine.Behaviour[] val_6 = new UnityEngine.Behaviour[3];
            val_6[0] = this.enemyPrototype.GetComponent<RilisoftBot.BotAiController>();
            val_6[1] = this.enemyPrototype.GetComponent<RilisoftBot.MeleeBot>();
            val_6[2] = this.enemyPrototype.GetComponent<UnityEngine.AI.NavMeshAgent>();
            if(val_6.Length >= 1)
        {
                do
        {
            UnityEngine.Behaviour val_127 = val_6[0];
            if(val_127 != 0)
        {
                val_127.enabled = false;
            UnityEngine.Object.Destroy(obj:  val_127);
        }
        
        }
        while(1 < val_6.Length);
        
        }
        
            UnityEngine.GameObject val_11 = new UnityEngine.GameObject(name:  "DynamicEnemies");
            val_132 = 0f;
            val_133 = 0f;
            val_134 = 0f;
            val_11.transform.localPosition = new UnityEngine.Vector3() {x = val_132, y = val_133, z = val_134};
            val_131 = 丟丌丁且且世丈丈丟.丆丂丆丂上丄下丒丒();
            if(val_131 >= 1)
        {
                val_135 = -60f;
            val_136 = 60f;
            do
        {
            UnityEngine.GameObject val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.enemyPrototype);
            val_14.transform.parent = val_11.transform;
            UnityEngine.Vector2 val_17 = UnityEngine.Random.insideUnitCircle;
            float val_128 = 0f;
            val_128 = val_17.x + val_128;
            val_14.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.AngleAxis(angle:  (UnityEngine.Random.Range(min:  val_135, max:  val_136)) + 180f, axis:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            val_137 = val_23.x;
            val_138 = val_23.z;
            val_132 = val_137;
            val_133 = val_23.y;
            val_134 = val_138;
            val_14.transform.localRotation = new UnityEngine.Quaternion() {x = val_132, y = val_133, z = val_134, w = val_23.w};
            val_130 = val_14.GetComponent<Rilisoft.TrainingEnemy>();
            if(val_130 == null)
        {
                val_130 = val_14.AddComponent<Rilisoft.TrainingEnemy>();
        }
        
            this.三东丙万丝丟丛丅丏.Add(item:  val_130);
            val_131 = val_131 - 1;
        }
        while(val_131 != 0);
        
        }
        
        }
        
        label_47:
        val_139 = 1152921505331179520;
        if(TrainingController.丁丑七与丙丐丘丌下() != 2)
        {
            goto label_82;
        }
        
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        TrainingController.丟且丏丙丆丒上丟丐 = 19;
        this.与专不丗丕丐不且丝 = 0.5f;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        goto label_71;
        label_77:
        if(this.丄万丒丞丞丝丞丆万 == null)
        {
            goto label_72;
        }
        
        val_131 = this.丄万丒丞丞丝丞丆万;
        if(0 != ((val_13 - 1) + 24))
        {
            goto label_78;
        }
        
        goto label_75;
        label_72:
        val_131 = 0;
        if(0 == ((val_13 - 1) + 24))
        {
            goto label_75;
        }
        
        label_78:
        mem[32] = 0;
        label_71:
        val_131 = this.丄万丒丞丞丝丞丆万;
        if(val_131 == null)
        {
            goto label_77;
        }
        
        if(1 != this.丄万丒丞丞丝丞丆万.Length)
        {
            goto label_78;
        }
        
        label_75:
        if(val_131[0] != 0)
        {
                val_135 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_131 = this.丄万丒丞丞丝丞丆万[0].height;
            float val_31 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_131 = -51f;
            val_134 = val_135 * (-10f);
            val_131 = (float)val_131 + val_131;
            val_31 = val_31 * val_131;
            val_133 = (float)UnityEngine.Screen.height - val_31;
            val_132 = val_134;
            UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_132, y:  val_133);
        }
        
        label_82:
        if(TrainingController.丁丑七与丙丐丘丌下() != 3)
        {
            goto label_90;
        }
        
        val_140 = null;
        val_140 = null;
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        TrainingController.丟且丏丙丆丒上丟丐 = 2;
        this.与专不丗丕丐不且丝 = 0.2f;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        UnityEngine.Vector3 val_34 = this.weaponTransform.position;
        if(this.丌丝下丄业一丄不三 != 0)
        {
            goto label_96;
        }
        
        val_141 = BonusCreator.下不三上与丂丅三世(丆与丕丕丂下丟一丈:  WeaponManager.上业丅丂丘不且丕丌(), 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
        this.丌丝下丄业一丄不三 = val_141;
        if(val_141 != null)
        {
            goto label_101;
        }
        
        goto label_100;
        label_96:
        val_141 = this.丌丝下丄业一丄不三;
        if(val_141 != null)
        {
            goto label_101;
        }
        
        label_100:
        label_101:
        val_141.transform.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        if(this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一() != 0)
        {
                this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一().一专丘东三丞东丁三();
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Multiply(d:  0f, a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
            this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一().丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  this.丌丝下丄业一丄不三.transform, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
        }
        
        bool val_46 = UnityEngine.Object.op_Inequality(x:  this.丌丝下丄业一丄不三, y:  0);
        val_131 = this.丌丝下丄业一丄不三.transform;
        UnityEngine.Vector3 val_49 = val_131.position;
        val_138 = 0f;
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, b:  new UnityEngine.Vector3() {x = val_138, y = 0f, z = 0f});
        val_135 = val_50.x;
        val_136 = val_50.y;
        val_137 = val_50.z;
        val_132 = val_135;
        val_133 = val_136;
        this.丌丝下丄业一丄不三.transform.position = new UnityEngine.Vector3() {x = val_132, y = val_133, z = val_137};
        label_90:
        if(TrainingController.丁丑七与丙丐丘丌下() == 104)
        {
                if(this.丌丄丑三上三丟一丒 != 0)
        {
                this.丌丄丑三上三丟一丒.SetActive(value:  true);
            this.丌丄丑三上三丟一丒.GetComponent<CoinBonus>().SetPlayer();
        }
        
            val_142 = null;
            val_142 = null;
            TrainingController.且业丌丄丑丄丏丟丙 = true;
            TrainingController.丟且丏丙丆丒上丟丐 = 2;
            this.与专不丗丕丐不且丝 = 3f;
            TrainingController.世丒丗上不丑东丌丞 = 0;
        }
        else
        {
                val_142 = null;
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() == 106)
        {
                this.丕业丄业丁业丈七世 = false;
            this.AnimShop();
            val_143 = null;
            val_143 = null;
            TrainingController.且业丌丄丑丄丏丟丙 = true;
            TrainingController.丟且丏丙丆丒上丟丐 = 13;
            this.与专不丗丕丐不且丝 = 0.3f;
            TrainingController.世丒丗上不丑东丌丞 = 0;
            if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Cursor.lockState = 0;
            UnityEngine.Cursor.visible = true;
        }
        
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() != 108)
        {
            goto label_142;
        }
        
        .丝且与丝丒丟万丁专 = this;
        val_144 = null;
        val_144 = null;
        val_131 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_131 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        .业且与丄丐丟丈丆一 = val_131;
        if(val_131 == 0)
        {
            goto label_151;
        }
        
        (TrainingController.丏丄丕丞丆万专且丆)[1152921540551832784].业且与丄丐丟丈丆一.下三业丆丅丈专丁丘(丙业与丙丗丝不丈东:  new System.EventHandler<System.EventArgs>(object:  this, method:  System.Void TrainingController::丌丗丙丅丆且丑不不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        System.Action val_60 = null;
        val_131 = val_60;
        val_60 = new System.Action(object:  new TrainingController.丏丄丕丞丆万专且丆(), method:  System.Void TrainingController.丏丄丕丞丆万专且丆::丗丟丄且万丛丂世丗());
        this.丞不丝丈丌丙丅世丟 = new Rilisoft.丝丄丄不丏丘丝世丗(七丐丅专且专七三丆:  val_60);
        goto label_151;
        label_142:
        this.丞不丝丈丌丙丅世丟.Dispose();
        label_151:
        if(TrainingController.丁丑七与丙丐丘丌下() == 109)
        {
                this.下专专丈与丒丄丌丅();
            val_145 = null;
            val_145 = null;
            TrainingController.且业丌丄丑丄丏丟丙 = true;
            TrainingController.丟且丏丙丆丒上丟丐 = 2;
            this.与专不丗丕丐不且丝 = 3f;
            TrainingController.世丒丗上不丑东丌丞 = 0;
            if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Cursor.lockState = 1;
        }
        
        }
        
        val_146 = null;
        val_146 = null;
        if(((TrainingController.万丑下丗业且万丄下.TryGetValue(key:  "SwipeWeapon", value: out  0)) == false) || (0 != TrainingController.丁丑七与丙丐丘丌下()))
        {
            goto label_179;
        }
        
        val_147 = null;
        val_147 = null;
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        val_148 = 0;
        TrainingController.丟且丏丙丆丒上丟丐 = 13;
        this.与专不丗丕丐不且丝 = 0.3f;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        goto label_168;
        label_174:
        if(this.丄万丒丞丞丝丞丆万 == null)
        {
            goto label_169;
        }
        
        val_131 = this.丄万丒丞丞丝丞丆万;
        if(val_148 != val_131)
        {
            goto label_175;
        }
        
        goto label_172;
        label_169:
        val_131 = 0;
        if(val_148 == val_131)
        {
            goto label_172;
        }
        
        label_175:
        var val_67 = val_131 + 0;
        val_148 = 1;
        mem2[0] = 0;
        label_168:
        val_131 = this.丄万丒丞丞丝丞丆万;
        if(val_131 == null)
        {
            goto label_174;
        }
        
        if(val_148 != this.丄万丒丞丞丝丞丆万.Length)
        {
            goto label_175;
        }
        
        label_172:
        val_149 = 0;
        if(val_131[0] != val_149)
        {
                if(this.丄万丒丞丞丝丞丆万.Length == 0)
        {
                val_149 = 0;
        }
        
            val_131 = this.丄万丒丞丞丝丞丆万[0].width;
            float val_71 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_71 = val_71 * (float)val_131;
            val_132 = (float)UnityEngine.Screen.width - val_71;
            val_133 = 0f;
            UnityEngine.Vector2 val_72 = new UnityEngine.Vector2(x:  val_132, y:  val_133);
        }
        
        label_179:
        if(TrainingController.丁丑七与丙丐丘丌下() == 5)
        {
                val_131 = true;
            SetActive(value:  true);
            val_150 = null;
            val_150 = null;
            TrainingController.且业丌丄丑丄丏丟丙 = val_131;
            TrainingController.丟且丏丙丆丒上丟丐 = 2;
            this.与专不丗丕丐不且丝 = 3f;
            TrainingController.世丒丗上不丑东丌丞 = 0;
            if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Cursor.lockState = 1;
        }
        
            UnityEngine.Coroutine val_76 = this.StartCoroutine(routine:  this.丟世丞下丂丆不丟丒());
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() == 6)
        {
                this.七丑丙丗与丑丑丐丞();
            val_132 = 7f;
            this.Invoke(methodName:  "ShowGoToPortalLines", time:  val_132);
            val_130 = 1152921504848912384;
            if(this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一() != 0)
        {
                TrainingController.丕不丆三七丛丙世丈 val_80 = new TrainingController.丕不丆三七丛丙世丈();
            .丝且与丝丒丟万丁专 = this;
            this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一().一专丘东三丞东丁三();
            UnityEngine.Vector3 val_84 = this.teleportTransform.position;
            UnityEngine.Vector3 val_88 = this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一().七丒丝丗与东丆丞丂().transform.position;
            UnityEngine.Vector3 val_89 = this.teleportTransform.position;
            new UnityEngine.GameObject(name:  "Teleport Replacement").transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_91 = UnityEngine.Vector3.zero;
            val_135 = val_91.x;
            val_136 = val_91.y;
            val_137 = val_91.z;
            val_132 = val_135;
            this.丄丞丂丟与丌丁三东.世三丞丅丑丌丈丈一().丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  this.teleportTransform, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_132, y = val_136, z = val_137});
            val_131 = this.teleportTransform.GetComponentInChildren<GotToNextLevel>();
            .万上上下一且世丌丗 = val_131;
            if(val_131 != 0)
        {
                TrainingController.丑丆七丘丗丏丟丈丛 val_94 = new TrainingController.丑丆七丘丗丏丟丈丛();
            if(val_94 != null)
        {
                val_151 = val_94;
            .东丟且丗且三专丙丁 = val_80;
        }
        else
        {
                val_151 = 24;
            mem[24] = val_80;
        }
        
            .丕丒上丄丒业丕丕丐 = 0;
            System.EventHandler val_95 = new System.EventHandler(object:  val_94, method:  System.Void TrainingController.丑丆七丘丗丏丟丈丛::丅与三上下丝丙丟东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            if(val_94 != null)
        {
                .丕丒上丄丒业丕丕丐 = val_95;
        }
        else
        {
                .丕丒上丄丒业丕丕丐 = val_95;
        }
        
            val_131 = (TrainingController.丑丆七丘丗丏丟丈丛)[1152921540552074448].丕丒上丄丒业丕丕丐;
            .万上上下一且世丌丗.add_Invoked(丙业与丙丗丝不丈东:  val_131);
        }
        
        }
        
            UnityEngine.PlayerPrefs.SetInt(key:  "PendingGooglePlayGamesSync", value:  1);
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() == 108)
        {
                val_152 = null;
            val_152 = null;
            TrainingController.且业丌丄丑丄丏丟丙 = true;
            TrainingController.丟且丏丙丆丒上丟丐 = 19;
            this.与专不丗丕丐不且丝 = 0.5f;
            val_131 = 1152921525914766672;
            TrainingController.世丒丗上不丑东丌丞 = 0;
            this.丄万丒丞丞丝丞丆万[0] = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "Training/ob_change_0");
            this.丄万丒丞丞丝丞丆万[1] = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "Training/ob_change_1");
            val_153 = 0;
            if(this.丄万丒丞丞丝丞丆万[0] != val_153)
        {
                val_135 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            if(this.丄万丒丞丞丝丞丆万.Length == 0)
        {
                val_153 = 0;
        }
        
            val_154 = public System.Int32 UnityEngine.Texture::get_width();
            val_131 = this.丄万丒丞丞丝丞丆万[0].width;
            val_136 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            if(this.丄万丒丞丞丝丞丆万.Length == 0)
        {
                val_154 = 0;
        }
        
            val_130 = this.丄万丒丞丞丝丞丆万[0].height;
            float val_137 = (float)UnityEngine.Screen.width;
            float val_138 = 0.5f;
            val_137 = val_137 * val_138;
            float val_139 = -164f;
            val_138 = (float)val_131 * val_138;
            float val_140 = 112f;
            val_139 = val_135 * val_139;
            val_138 = val_136 * val_138;
            val_140 = (float)val_130 + val_140;
            val_137 = val_137 + val_139;
            val_140 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_140;
            val_132 = val_137 - val_138;
            UnityEngine.Vector2 val_108 = new UnityEngine.Vector2(x:  val_132, y:  (float)UnityEngine.Screen.height - val_140);
        }
        
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() != 110)
        {
            goto label_254;
        }
        
        val_155 = null;
        val_155 = null;
        val_131 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_156 = null;
            val_156 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_157 = null;
            val_157 = null;
            丏与丝三一丕三一下(丙业与丙丗丝不丈东:  10);
        }
        
        }
        
        this.三丌专与万业丙与下();
        val_158 = null;
        val_158 = null;
        val_159 = 0;
        TrainingController.且业丌丄丑丄丏丟丙 = true;
        val_160 = this.丄万丒丞丞丝丞丆万;
        TrainingController.丟且丏丙丆丒上丟丐 = 19;
        this.与专不丗丕丐不且丝 = 0.5f;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        goto label_272;
        label_276:
        val_130 = 0;
        var val_112 = mem[this.丄万丒丞丞丝丞丆万] + 0;
        val_159 = 1;
        mem2[0] = 0;
        label_272:
        if(val_159 != (mem[this.丄万丒丞丞丝丞丆万] + 24))
        {
            goto label_276;
        }
        
        与丂丏丛丞丞丒丟丄.丟丄丄上万三丆一丌(丆丛丄专丂丟世丈一:  false);
        val_161 = 0;
        if((mem[this.丄万丒丞丞丝丞丆万] + 32) == val_161)
        {
            goto label_292;
        }
        
        val_162 = null;
        val_162 = null;
        val_139 = 与丂丏丛丞丞丒丟丄.业丆上丆三世丆丑不;
        if((mem[this.丄万丒丞丞丝丞丆万] + 24) == 0)
        {
                val_161 = 0;
        }
        
        val_163 = mem[mem[this.丄万丒丞丞丝丞丆万] + 32 + 360 + 8];
        val_163 = mem[this.丄万丒丞丞丝丞丆万] + 32 + 360 + 8;
        val_131 = mem[this.丄万丒丞丞丝丞丆万] + 32;
        val_135 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        if((mem[this.丄万丒丞丞丝丞丆万] + 24) == 0)
        {
                val_163 = 0;
        }
        
        val_130 = mem[this.丄万丒丞丞丝丞丆万] + 32;
        float val_141 = 80f;
        float val_142 = -80f;
        val_141 = ((float)val_131 - val_139) + val_141;
        val_142 = ((float)val_130 + 与丂丏丛丞丞丒丟丄.丏东业丌丝丂丌东丄) + val_142;
        val_141 = val_135 * val_141;
        val_142 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_142;
        val_132 = (float)UnityEngine.Screen.width - val_141;
        UnityEngine.Vector2 val_121 = new UnityEngine.Vector2(x:  val_132, y:  (float)UnityEngine.Screen.height - val_142);
        goto label_292;
        label_254:
        val_160 = this.丄万丒丞丞丝丞丆万;
        label_292:
        val_164 = 0;
        if((mem[this.丄万丒丞丞丝丞丆万] + 32) != val_164)
        {
                val_135 = val_121.x;
            if((mem[this.丄万丒丞丞丝丞丆万] + 24) == 0)
        {
                val_164 = 0;
        }
        
            val_165 = mem[mem[this.丄万丒丞丞丝丞丆万] + 32 + 360 + 8];
            val_165 = mem[this.丄万丒丞丞丝丞丆万] + 32 + 360 + 8;
            val_137 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            if((mem[this.丄万丒丞丞丝丞丆万] + 24) == 0)
        {
                val_165 = 0;
        }
        
            val_131 = mem[this.丄万丒丞丞丝丞丆万] + 32;
            float val_143 = (float)val_131;
            float val_125 = val_137 * ((float)mem[this.丄万丒丞丞丝丞丆万] + 32);
            val_143 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_143;
            this.万丕与与下丅不与丙 = 0;
            mem[1152921540551424364] = 0;
            mem[1152921540551424372] = 0;
        }
        
        this.Invoke(methodName:  "FirstStep", time:  1f);
    }
    private void 七丑丙丗与丑丑丐丞()
    {
        this.nickLabelRobbie.SetActive(value:  true);
    }
    private void ShowGoToPortalLines()
    {
        this.goToPortalLines.SetActive(value:  true);
    }
    private void AnimShop()
    {
        UIButton val_3;
        bool val_3 = this.丕业丄业丁业丈七世;
        val_3 = val_3 ^ 1;
        this.丕业丄业丁业丈七世 = val_3;
        val_3 = this.丟专丏丒丗七丈一七;
        if(this.丟专丏丒丗七丈一七 != null)
        {
            goto label_4;
        }
        
        val_3 = this.丟专丏丒丗七丈一七;
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_4:
        this.丟专丏丒丗七丈一七.pressedSprite = this.丟专丏丒丗七丈一七.normalSprite;
        this.丟专丏丒丗七丈一七.normalSprite = this.丟专丏丒丗七丈一七.pressedSprite;
        if(TrainingController.丁丑七与丙丐丘丌下() != 106)
        {
                return;
        }
        
        this.Invoke(methodName:  "AnimShop", time:  0.3f);
        return;
        label_5:
    }
    private void FirstStep()
    {
        null = null;
        TrainingController.且业丌丄丑丄丏丟丙 = false;
        TrainingController.世丒丗上不丑东丌丞 = 0;
        this.NextStepAnim();
    }
    private void NextStepAnim()
    {
        var val_3;
        var val_5;
        var val_6;
        var val_7;
        this.CancelInvoke(methodName:  "NextStepAnim");
        val_3 = null;
        val_3 = null;
        if(TrainingController.且业丌丄丑丄丏丟丙 != false)
        {
                return;
        }
        
        int val_3 = TrainingController.世丒丗上不丑东丌丞;
        val_3 = val_3 + 1;
        TrainingController.世丒丗上不丑东丌丞 = val_3;
        val_5 = null;
        if(TrainingController.丁丑七与丙丐丘丌下() != 4)
        {
            goto label_6;
        }
        
        val_5 = null;
        if(TrainingController.世丒丗上不丑东丌丞 >= TrainingController.丟且丏丙丆丒上丟丐)
        {
            goto label_9;
        }
        
        label_6:
        if(TrainingController.丁丑七与丙丐丘丌下() != 105)
        {
            goto label_12;
        }
        
        val_6 = null;
        val_6 = null;
        if(TrainingController.世丒丗上不丑东丌丞 >= TrainingController.丟且丏丙丆丒上丟丐)
        {
            goto label_15;
        }
        
        label_12:
        this.Invoke(methodName:  "NextStepAnim", time:  this.与专不丗丕丐不且丝);
        return;
        label_9:
        val_7 = 4;
        goto label_18;
        label_15:
        val_7 = 105;
        label_18:
        TrainingController.丝丅七丁丂下丘丞世(丙业与丙丗丝不丈东:  105);
    }
    internal static void 与丄丘世丏上三下丁()
    {
        null = null;
        TrainingController.与东丗丘丈丙丝世三 = 1000f;
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  101)) == false)
        {
                return;
        }
        
        this.不不丘丑上一丞世丒();
    }
    public bool get_tapToShootTextAllowed()
    {
        bool val_1 = 与丂丏丛丞丞丒丟丄.三上丕丟丛世世专丁();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    private int 丂丟丅世不专三丐丞()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        val_3 = 0;
        goto label_1;
        label_12:
        if(this.丝业且丈万丏丒三万[0] != 0)
        {
                RilisoftBot.MeleeBot val_3 = this.丝业且丈万丏丒三万[0];
            if(S0 > 0f)
        {
                val_3 = 1;
        }
        
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < this.丝业且丈万丏丒三万.Length)
        {
            goto label_12;
        }
        
        return (int)val_3;
    }
    private System.Collections.IEnumerator 丟世丞下丂丆不丟丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TrainingController.丑业丛丕不专丅丒东();
    }
    private void 不不丘丑上一丞世丒()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        val_4 = this;
        val_5 = 0;
        goto label_1;
        label_10:
        val_4 = this.enemies[0];
        if(val_4 != 0)
        {
                val_4 = val_4.GetComponent<RilisoftBot.BaseBot>();
            if(val_2.health > 0f)
        {
                val_2.health = val_4.maxHealth;
        }
        
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < this.enemies.Length)
        {
            goto label_10;
        }
    
    }
    private void Update()
    {
        float val_56;
        float val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        float val_66;
        var val_68;
        var val_69;
        var val_70;
        string val_71;
        var val_72;
        if((InGameGUI.丙丞专丌丁丞与不丐 != 0) && (InGameGUI.丙丞专丌丁丞与不丐.rightFireButton != 0))
        {
                if(this.专不丂且丅丒七且丘 == 0f)
        {
                this.丁丛丟丕丐丏丟丗丌 = 107f;
            this.专不丂且丅丒七且丘 = 107f;
            if(this.七丕万丈丆与丂丟丄 == 0)
        {
                this.七丕万丈丆与丂丟丄 = GetComponent<UISprite>();
        }
        
        }
        
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  (float)this.七丕万丈丆与丂丟丄.width / this.专不丂且丅丒七且丘);
            val_56 = val_9.z;
            this.shootOverlay.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_56};
            val_57 = (float)this.七丕万丈丆与丂丟丄.width;
            if(this.丁丛丟丕丐丏丟丗丌 != val_57)
        {
                val_57 = (float)this.七丕万丈丆与丂丟丄.width;
            this.丁丛丟丕丐丏丟丗丌 = val_57;
        }
        
        }
        
        val_58 = null;
        val_58 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_59 = null;
            val_59 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_60 = null;
            val_60 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_628 != 0)
        {
                val_61 = null;
            val_61 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) != 0)
        {
                val_62 = null;
            val_62 = null;
            val_63 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丒七下丁丛不丄丅一()) != false)
        {
                val_64 = null;
            TrainingController.与东丗丘丈丙丝世三 = 0f;
        }
        else
        {
                val_65 = null;
            val_57 = TrainingController.与东丗丘丈丙丝世三 + UnityEngine.Time.deltaTime;
            TrainingController.与东丗丘丈丙丝世三 = val_57;
        }
        
        }
        
        }
        
        }
        
        }
        
        if(TrainingController.丁丑七与丙丐丘丌下() > TrainingController.七专业一丂万丛丝上)
        {
                if(TrainingController.丁丑七与丙丐丘丌下() != 4)
        {
                TrainingController.七专业一丂万丛丝上 = TrainingController.丁丑七与丙丐丘丌下();
        }
        
        }
        
        val_66 = this.与三丝丈丑丑丟丗丁;
        float val_21 = UnityEngine.Time.deltaTime;
        val_21 = val_66 + val_21;
        this.与三丝丈丑丑丟丗丁 = val_21;
        if((UnityEngine.Input.GetKeyDown(key:  116)) != false)
        {
                val_68 = null;
            val_68 = null;
            东丙丂丕世一与丙丆(丟且丒丁丞万专丙三:  42, 丟业下东与东专专业:  true);
        }
        
        丘丌丒丑一七丁丑一 val_23 = TrainingController.丁丑七与丙丐丘丌下();
        this.capturePointsController.SetActive(value:  true);
        this.zombiesLight.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 5) ? 1 : 0);
        this.roofLight.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 2) ? 1 : 0);
        this.helicopterLight.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 6) ? 1 : 0);
        if(TrainingController.丁丑七与丙丐丘丌下() == 2)
        {
                UnityEngine.Vector3 val_31 = this.positionNeedTapToMove.position;
            val_69 = null;
            val_69 = null;
            UnityEngine.Vector3 val_33 = transform.position;
            UnityEngine.Vector3 val_34 = this.positionNeedTapToMove.position;
            UnityEngine.Vector3 val_36 = transform.position;
            val_56 = 0f;
            val_66 = val_36.x;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_66, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_56})) < 0)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  2);
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  17);
        }
        
        }
        
        this.tapToMoveLines.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 2) ? 1 : 0);
        this.doTheJumpLines.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 3) ? 1 : 0);
        val_70 = null;
        val_70 = null;
        if(GameController.丒且丅丙丏丙不丒丙 != false)
        {
                return;
        }
        
        if(TrainingController.丟丑丆丁下丛丂丕丝() <= TrainingController.不丌丄丙万丅且丛丛)
        {
            goto label_114;
        }
        
        TrainingController.不丌丄丙万丅且丛丛 = TrainingController.丟丑丆丁下丛丂丕丝();
        if(TrainingController.丁丑七与丙丐丘丌下() != 1)
        {
            goto label_109;
        }
        
        val_71 = "StartNextStepTraning";
        goto label_110;
        label_109:
        if(TrainingController.丁丑七与丙丐丘丌下() != 109)
        {
            goto label_113;
        }
        
        val_71 = "StartNextStepTraning";
        label_110:
        this.Invoke(methodName:  val_71, time:  3f);
        goto label_114;
        label_113:
        this.StartNextStepTraning();
        label_114:
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                val_72 = null;
            val_72 = null;
            if(TrainingController.世下丐丌一丗一丞丌 == false)
        {
                return;
        }
        
        }
        
        if(this.shopArrowOverlay != 0)
        {
                this.shopArrowOverlay.SetActive(value:  false);
        }
        
        if(this.buyGrenadeArrowOverlay != 0)
        {
                this.buyGrenadeArrowOverlay.SetActive(value:  false);
        }
        
        if(this.throwGrenadeArrowOverlay != 0)
        {
                this.throwGrenadeArrowOverlay.SetActive(value:  false);
        }
        
        if(this.joystickFingerOverlay != 0)
        {
                this.joystickFingerOverlay.SetActive(value:  false);
        }
        
        if(this.joystickShadowOverlay != 0)
        {
                this.joystickShadowOverlay.SetActive(value:  false);
        }
        
        if(this.touchpadOverlay != 0)
        {
                this.touchpadOverlay.SetActive(value:  false);
        }
        
        if(this.touchpadFingerOverlay != 0)
        {
                this.touchpadFingerOverlay.SetActive(value:  false);
        }
        
        if(this.swipeWeaponFingerOverlay != 0)
        {
                this.swipeWeaponFingerOverlay.SetActive(value:  false);
        }
        
        if(this.tapWeaponArrowOverlay == 0)
        {
                return;
        }
        
        this.tapWeaponArrowOverlay.SetActive(value:  false);
    }
    private void LateUpdate()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        float val_14;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_10 = null;
            val_10 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_11 = null;
            val_11 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_628 != 0)
        {
                val_12 = null;
            val_12 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456) != 0)
        {
                val_13 = null;
            val_13 = null;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 276, y = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 280}, rhs:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y})) != false)
        {
                val_14 = this.丕世且丄丐丝丏丆丆;
            float val_7 = UnityEngine.Time.deltaTime;
            val_7 = val_14 + val_7;
            this.丕世且丄丐丝丏丆丆 = val_7;
        }
        else
        {
                val_14 = this.不世丄丛丞七丘丝丏;
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_14 + val_8;
            this.不世丄丛丞七丘丝丏 = val_8;
            this.丕世且丄丐丝丏丆丆 = 0f;
        }
        
        }
        
        }
        
        }
        
        }
        
        this.丟丑丞丟世丒不下业();
    }
    public void Hide3dTouchJump()
    {
        if(this.touch3dPressGun.activeSelf == false)
        {
                return;
        }
        
        UITweener val_2 = this.touch3dPressGun.GetComponent<UITweener>();
        if(val_2 == 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.touch3dPressGun, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        val_2.PlayForward();
    }
    private bool 丒东丄世丌丁专丌丏()
    {
        var val_3;
        var val_4;
        if(TrainingController.丁丑七与丙丐丘丌下() == 3)
        {
                val_3 = null;
            val_3 = null;
            var val_2 = (TrainingController.与东丗丘丈丙丝世三 < 0) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    private void 丟丑丞丟世丒不下业()
    {
        InGameGUI val_148;
        float val_149;
        float val_150;
        float val_151;
        float val_152;
        bool val_153;
        var val_154;
        var val_155;
        var val_156;
        System.Collections.Generic.Dictionary<System.String, 丘丌丒丑一七丁丑一> val_157;
        var val_158;
        System.Func<UnityEngine.GameObject, System.Boolean> val_160;
        var val_164;
        var val_165;
        var val_166;
        var val_167;
        var val_168;
        var val_169;
        var val_171;
        val_148 = this;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.专丏丕一丒丆丏丄万 != true)
        {
                this.trainingOverlaysNew.transform.SetParent(p:  InGameGUI.丙丞专丌丁丞与不丐.SubpanelsContainer.transform);
            typeof(UIPanel).__il2cppRuntimeField_A2 = 0;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.trainingOverlaysNew.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            this.trainingOverlaysNew.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            TrainingOverlaysNew val_9 = this.trainingOverlaysNew.GetComponent<TrainingOverlaysNew>();
            val_9.leftAnchorTrans.SetParent(p:  InGameGUI.丙丞专丌丁丞与不丐.midLeftAnchor);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_9.leftAnchorTrans.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_9.rightAnchorTrans.SetParent(p:  InGameGUI.丙丞专丌丁丞与不丐.midRightAnchor);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_9.rightAnchorTrans.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            val_9.centerAnchorTrans.SetParent(p:  InGameGUI.丙丞专丌丁丞与不丐.midCenterAnchor);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_9.centerAnchorTrans.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.jumpFingerOverlay.transform.SetParent(p:  this.jumpOverlay.transform);
            UnityEngine.Vector3 val_17 = this.jumpFingerOverlay.transform.localPosition;
            val_149 = val_17.x;
            UnityEngine.Vector3 val_19 = this.jumpFingerOverlay.transform.localPosition;
            float val_150 = -2f;
            val_150 = val_149 + val_150;
            val_150 = 0f;
            val_151 = 0f;
            val_152 = 0f;
            this.jumpFingerOverlay.transform.localPosition = new UnityEngine.Vector3() {x = val_150, y = val_151, z = val_152};
            this.trainingOverlaysNew.SetActive(value:  false);
            val_153 = true;
            this.trainingOverlaysNew.SetActive(value:  true);
            this.专丏丕一丒丆丏丄万 = val_153;
        }
        
        val_154 = null;
        val_154 = null;
        if(TrainingController.世下丐丌一丗一丞丌 == true)
        {
                return;
        }
        
        if(this.丁丘丞一且七业万上 != true)
        {
                this.jumpOverlay.transform.parent = transform;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
            this.jumpOverlay.transform.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
            float val_151 = (float)this.jumpOverlayCircle.gameObject.GetComponent<UITexture>().width;
            val_151 = val_151 * 0.75f;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  ((float)this.jumpOverlay.transform.parent.gameObject.GetComponent<UISprite>().width) / val_151);
            this.jumpOverlay.transform.localScale = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
            this.shootOverlay.transform.parent = transform;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.zero;
            val_149 = val_39.x;
            val_154 = this.shootOverlay.transform;
            val_150 = val_149;
            val_151 = val_39.y;
            val_152 = val_39.z;
            val_154.localPosition = new UnityEngine.Vector3() {x = val_150, y = val_151, z = val_152};
            this.丁丘丞一且七业万上 = true;
        }
        
        this.jumpOverlay.SetActive(value:  val_154.丒东丄世丌丁专丌丏());
        this.jumpFingerOverlay.SetActive(value:  this.jumpOverlay.丒东丄世丌丁专丌丏());
        if(this.jumpFingerOverlay.丒东丄世丌丁专丌丏() == false)
        {
            goto label_69;
        }
        
        val_149 = this.丐丝丞丂丐丘丗丈一;
        val_151 = this.七一丑且丑丌下丂丞;
        val_150 = val_149 + UnityEngine.Time.deltaTime;
        this.丐丝丞丂丐丘丗丈一 = val_150;
        if(val_150 <= val_151)
        {
            goto label_73;
        }
        
        this.丐丝丞丂丐丘丗丈一 = 0f;
        this.jumpFingerOverlay.SetActive(value:  false);
        this.jumpFingerOverlay.SetActive(value:  true);
        goto label_73;
        label_69:
        this.丐丝丞丂丐丘丗丈一 = 0f;
        label_73:
        if(TrainingController.丁丑七与丙丐丘丌下() != 5)
        {
            goto label_76;
        }
        
        val_155 = null;
        val_155 = null;
        val_156 = (~丗丞业丐丛三上丄丕()) & 1;
        if(this.shootOverlay != null)
        {
            goto label_83;
        }
        
        goto label_82;
        label_76:
        val_156 = 0;
        if(this.shootOverlay != null)
        {
            goto label_83;
        }
        
        label_82:
        label_83:
        this.shootOverlay.SetActive(value:  false);
        if(TrainingController.丁丑七与丙丐丘丌下() != 4)
        {
                if(TrainingController.丁丑七与丙丐丘丌下() != 105)
        {
            goto label_89;
        }
        
        }
        
        label_173:
        val_158 = null;
        val_158 = null;
        val_160 = TrainingController.<>c.<>9__162_0;
        if(val_160 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_52 = null;
            val_160 = val_52;
            val_52 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  TrainingController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TrainingController.<>c::丅万一丗丝不丌丕且(UnityEngine.GameObject 丄三丅七丆丛与与上));
            TrainingController.<>c.<>9__162_0 = val_160;
        }
        
        var val_152 = 0;
        val_152 = val_152 + 1;
        System.Collections.Generic.IEnumerator<T> val_55 = System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  this.一万业专丙丑丂下丙, predicate:  val_52).GetEnumerator();
        label_112:
        var val_153 = 0;
        val_153 = val_153 + 1;
        if(val_55.MoveNext() == false)
        {
            goto label_105;
        }
        
        var val_154 = 0;
        val_154 = val_154 + 1;
        T val_59 = val_55.Current;
        val_59.SetActive(value:  (((SelectionControlMode.IsShowing != true) ? 0 : this.wellDoneCont) == val_59) ? 1 : 0);
        goto label_112;
        label_89:
        val_164 = null;
        if(TrainingController.丁丑七与丙丐丘丌下() != 6)
        {
            goto label_115;
        }
        
        val_164 = null;
        if(TrainingController.丏丛世丄丈丙不丄丞 == false)
        {
            goto label_173;
        }
        
        goto label_173;
        label_105:
        val_165 = 0;
        val_166 = 0;
        if(val_55 != null)
        {
            goto label_120;
        }
        
        goto label_177;
        label_115:
        if(TrainingController.丁丑七与丙丐丘丌下() != 1)
        {
            goto label_124;
        }
        
        goto label_173;
        label_124:
        if(TrainingController.丁丑七与丙丐丘丌下() != 2)
        {
            goto label_128;
        }
        
        goto label_173;
        label_128:
        if(TrainingController.丁丑七与丙丐丘丌下() != 3)
        {
            goto label_133;
        }
        
        if(与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != true)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_173;
        }
        
        }
        
        val_167 = null;
        val_167 = null;
        float val_67 = UnityEngine.Time.deltaTime;
        val_67 = TrainingController.丟丄且丕丄丟丄东丛 + val_67;
        TrainingController.丟丄且丕丄丟丄东丛 = val_67;
        if(this.touch3dPressGun.activeSelf != false)
        {
                val_168 = null;
            val_168 = null;
            float val_69 = UnityEngine.Time.deltaTime;
            val_69 = TrainingController.丐与丟不丆丂业丛丙 + val_69;
            TrainingController.丐与丟不丆丂业丛丙 = val_69;
            if(TrainingController.丐与丟不丆丂业丛丙 > 4f)
        {
                this.Hide3dTouchJump();
        }
        
        }
        
        if(this.丌丏上东丐丝丂不丙 == true)
        {
            goto label_173;
        }
        
        val_169 = null;
        val_169 = null;
        if(TrainingController.丟丄且丕丄丟丄东丛 <= 4f)
        {
            goto label_173;
        }
        
        this.丌丏上东丐丝丂不丙 = true;
        HintController.与一丅丝不丈业与丙().三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  "press_jump");
        this.touch3dPressGun.SetActive(value:  true);
        goto label_173;
        label_133:
        if(TrainingController.丁丑七与丙丐丘丌下() != 104)
        {
            goto label_156;
        }
        
        goto label_173;
        label_156:
        if(TrainingController.丁丑七与丙丐丘丌下() != 106)
        {
            goto label_160;
        }
        
        goto label_173;
        label_160:
        if(TrainingController.丁丑七与丙丐丘丌下() != 109)
        {
            goto label_164;
        }
        
        goto label_173;
        label_164:
        if(TrainingController.丁丑七与丙丐丘丌下() != 110)
        {
            goto label_168;
        }
        
        goto label_173;
        label_168:
        if(TrainingController.丁丑七与丙丐丘丌下() != 5)
        {
            goto label_173;
        }
        
        goto label_173;
        label_120:
        var val_155 = 0;
        val_155 = val_155 + 1;
        this.shootOverlay.Dispose();
        label_177:
        int val_78 = UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.不东丞专三丄丏丕丕(), defaultValue:  0);
        if(this.swipeToChangeWeaponOverlay != 0)
        {
                this.swipeToChangeWeaponOverlay.SetActive(value:  ((val_78 == 1) ? 1 : 0) & ((TrainingController.丁丑七与丙丐丘丌下() == 108) ? 1 : 0));
        }
        
        if(this.tapToChangeWeaponOverlay != 0)
        {
                bool val_85 = (val_78 != 1) ? 1 : 0;
            val_85 = ((TrainingController.丁丑七与丙丐丘丌下() == 108) ? 1 : 0) & val_85;
            this.tapToChangeWeaponOverlay.SetActive(value:  val_85);
        }
        
        if(this.shopArrowOverlay != 0)
        {
                this.shopArrowOverlay.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 106) ? 1 : 0);
        }
        
        if(this.throwGrenadeArrowOverlay != 0)
        {
                val_157 = TrainingController.万丑下丗业且万丄下.Item["TapToThrowGrenade"];
            this.throwGrenadeArrowOverlay.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == val_157) ? 1 : 0);
        }
        
        if(this.joystickFingerOverlay == 0)
        {
            goto label_213;
        }
        
        if((this.与下丏丅丁且丁丈丒 != true) && (TrainingController.丁丑七与丙丐丘丌下() == TrainingController.万丑下丗业且万丄下.Item["TapToMove"]))
        {
                val_171 = null;
            val_171 = null;
            val_152 = 0f;
            if(this.dragToMoveCont != 0)
        {
                this.dragToMoveCont.SetActive(value:  true);
        }
        
            this.与下丏丅丁且丁丈丒 = true;
        }
        
        val_157 = TrainingController.万丑下丗业且万丄下;
        if(TrainingController.丁丑七与丙丐丘丌下() == val_157.Item["TapToMove"])
        {
            goto label_228;
        }
        
        val_157 = TrainingController.万丑下丗业且万丄下;
        if(TrainingController.丁丑七与丙丐丘丌下() != val_157.Item["GoToPortal"])
        {
            goto label_232;
        }
        
        label_228:
        val_150 = this.丕世且丄丐丝丏丆丆;
        val_151 = 2f;
        if(this.joystickFingerOverlay != null)
        {
            goto label_310;
        }
        
        label_311:
        label_310:
        this.joystickFingerOverlay.SetActive(value:  (val_150 >= val_151) ? 1 : 0);
        label_213:
        if(this.joystickShadowOverlay == 0)
        {
            goto label_236;
        }
        
        if((this.且丒丘下三业丘丏东 != true) && (TrainingController.丁丑七与丙丐丘丌下() == TrainingController.万丑下丗业且万丄下.Item["TapToMove"]))
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.joystickShadowOverlay.transform.parent.GetComponent<UIJoystick>())) != true)
        {
                this.joystickShadowOverlay.transform.SetParent(p:  UnityEngine.Object.FindObjectOfType<UIJoystick>().transform);
            UnityEngine.Vector3 val_116 = transform.localPosition;
            this.joystickShadowOverlay.transform.localPosition = new UnityEngine.Vector3() {x = val_116.x, y = val_116.y, z = val_116.z};
            UnityEngine.Vector3 val_122 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_128 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_122.x, y = val_122.y, z = val_122.z}, d:  ((float)this.joystickShadowOverlay.transform.parent.gameObject.GetComponent<UISprite>().width) / ((float)this.joystickShadowOverlay.gameObject.GetComponent<UITexture>().width));
            val_149 = val_128.x;
            this.joystickShadowOverlay.transform.localScale = new UnityEngine.Vector3() {x = val_149, y = val_128.y, z = val_128.z};
            this.且丒丘下三业丘丏东 = true;
        }
        
        }
        
        val_157 = TrainingController.万丑下丗业且万丄下;
        if(TrainingController.丁丑七与丙丐丘丌下() == val_157.Item["TapToMove"])
        {
            goto label_273;
        }
        
        val_157 = TrainingController.万丑下丗业且万丄下;
        if(TrainingController.丁丑七与丙丐丘丌下() != val_157.Item["GoToPortal"])
        {
            goto label_277;
        }
        
        label_273:
        if(this.joystickShadowOverlay != null)
        {
            goto label_312;
        }
        
        label_313:
        label_312:
        this.joystickShadowOverlay.SetActive(value:  (this.丕世且丄丐丝丏丆丆 >= 2f) ? 1 : 0);
        label_236:
        if(this.touchpadOverlay != 0)
        {
                this.touchpadOverlay.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 1) ? 1 : 0);
        }
        
        if(this.touchpadFingerOverlay != 0)
        {
                this.touchpadFingerOverlay.SetActive(value:  (TrainingController.丁丑七与丙丐丘丌下() == 1) ? 1 : 0);
        }
        
        if(this.swipeWeaponFingerOverlay != 0)
        {
                this.swipeWeaponFingerOverlay.SetActive(value:  ((val_78 == 1) ? 1 : 0) & ((TrainingController.丁丑七与丙丐丘丌下() == 108) ? 1 : 0));
        }
        
        val_153 = this.tapWeaponArrowOverlay;
        if(val_153 != 0)
        {
                bool val_146 = (val_78 != 1) ? 1 : 0;
            val_146 = ((TrainingController.丁丑七与丙丐丘丌下() == 108) ? 1 : 0) & val_146;
            this.tapWeaponArrowOverlay.SetActive(value:  val_146);
        }
        
        val_148 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_148 == 0)
        {
                return;
        }
        
        SetActive(value:  false);
        val_148 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 400];
        val_148 = InGameGUI.丙丞专丌丁丞与不丐.rightAnchor;
        SetActive(value:  false);
        return;
        label_232:
        if(this.joystickFingerOverlay != null)
        {
            goto label_310;
        }
        
        goto label_311;
        label_277:
        if(this.joystickShadowOverlay != null)
        {
            goto label_312;
        }
        
        goto label_313;
    }
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  与丂丏丛丞丞丒丟丄.丗丄丛丆七丁丗丗专())) == false)
        {
                return;
        }
        
        System.GC.Collect();
        this.丌丝下丄业一丄不三 = BonusCreator.下不三上与丂丅三世(丆与丕丕丂下丟一丈:  WeaponManager.上业丅丂丘不且丕丌(), 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    private bool 丄丏丆上三丞丁丘下()
    {
        return (bool)(this.丂丟丅世不专三丐丞() == 2) ? 1 : 0;
    }
    private bool 丄与丑三丄上丄丁丁()
    {
        bool val_2 = this.selectionControlMode.gameObject.activeSelf;
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    private bool 丒丘与丙三丞丂丛丐()
    {
        return (bool)(this.丂丟丅世不专三丐丞() == 1) ? 1 : 0;
    }
    private bool 丙与丁东丏丏丛丑万()
    {
        bool val_2 = this.selectionControlMode.gameObject.activeSelf;
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }

}
