using UnityEngine;
public class SupportAimController : MonoBehaviour, 丗丅丑专一上专不丘
{
    // Fields
    private SupportAimSettingsContainer settings;
    private bool <丕七下万丏不且上东>k__BackingField;
    private bool <丞与丞七且丏丑丄丆>k__BackingField;
    private bool <丆丅上万丈不不丟丐>k__BackingField;
    private Player_move_c _playerController;
    private float 三世丏丘丏丗上丐丗;
    public TargetFinderController _targetController;
    private 丅一丝丟丒丝东丅不 <丑丙且不丌世丞丏丏>k__BackingField;
    private static bool 丁万东下且丏三丂丟;
    private static UnityEngine.Vector3 丂丗丑专丒业丟丂丁;
    private float 不业世丏与上丏三丑;
    private UnityEngine.Vector3 丛丁丑丛丕丅丒丑丏;
    private bool 上丕三丅下世丗丏丆;
    internal static float 丝丈世丑丄东丟丏丝;
    internal static float 专丈专丁与不且丄丂;
    private float 丙一丑丏丁一且丒业;
    private UnityEngine.Vector2 世丙丟丒万七三丛丘;
    private static float 世下丝七与丁业丂丘;
    private static float 丒丝丑世丂丅丛丅丘;
    
    // Properties
    public SupportAimSettingsContainer 丁一丄丑专万丐丐丌 { get; }
    public 丘丐丗丐七丑丏丒丗 丅万丂世不丘丕下一 { get; }
    public bool 丏丒丝丏上一丙一业 { get; set; }
    public bool 丘丈丝丙丝丄与与业 { get; set; }
    internal bool 与下丐东业丝丏丄下 { get; set; }
    public float 丌且万丘一丄下丝且 { get; }
    private TouchPadController 丈丟世下丙丝丒丙丁 { get; }
    public 丅一丝丟丒丝东丅不 不丘且丘专与丐丄丂 { get; set; }
    private UnityEngine.Camera 上万丗丘丌东丟丌与 { get; }
    private UnityEngine.Transform 丄下丞与万且不丒万 { get; }
    public static UnityEngine.Vector3 丐东丘丄七丂丝丛下 { get; }
    private float 东丂东七三丕丌丛丟 { get; }
    private float 业丁丐丛丅与三世丛 { get; }
    private bool 丈丘丒世上丁丁丄丒 { get; }
    
    // Methods
    public SupportAimSettingsContainer get_AimSettingsForGui()
    {
        return (SupportAimSettingsContainer)this.settings;
    }
    public 丘丐丗丐七丑丏丒丗 get_Settings()
    {
        return (丘丐丗丐七丑丏丒丗)this.settings;
    }
    public bool get_InRect()
    {
        return (bool)this.<丕七下万丏不且上东>k__BackingField;
    }
    private void 丆业丞丈三丕丒丟万(bool 丙业与丙丗丝不丈东)
    {
        this.<丕七下万丏不且上东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_InPlayerRect()
    {
        return (bool)this.<丞与丞七且丏丑丄丆>k__BackingField;
    }
    private void 专丁丝丐丑丅丙丟业(bool 丙业与丙丗丝不丈东)
    {
        this.<丞与丞七且丏丑丄丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 万与丌丂与丁上且下()
    {
        return (bool)this.<丆丅上万丈不不丟丐>k__BackingField;
    }
    private void 三专专且丌不不丌丛(bool 丙业与丙丗丝不丈东)
    {
        this.<丆丅上万丈不不丟丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public float get_AutoTargetRotateSpeed()
    {
        return (float)this.三世丏丘丏丗上丐丗;
    }
    private TouchPadController 业丘丅丝丗丄丒丌丟()
    {
        null = null;
        return (TouchPadController)JoystickController.丘万丏三丏丑世丐丏;
    }
    public 丅一丝丟丒丝东丅不 get_CurrentTarget()
    {
        return (丅一丝丟丒丝东丅不)this.<丑丙且不丌世丞丏丏>k__BackingField;
    }
    private void 东东专丒三东丂一丕(丅一丝丟丒丝东丅不 丙业与丙丗丝不丈东)
    {
        this.<丑丙且不丌世丞丏丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private UnityEngine.Camera 丝专丅业丗丁业世三()
    {
        BaseCamera val_1 = this._playerController.丝丙与东丈不丙三丟();
        if(val_1 != null)
        {
                return val_1.camera;
        }
        
        return val_1.camera;
    }
    private UnityEngine.Transform 丈丁丌丗与下丕丒上()
    {
        if(this._playerController.丝丙与东丈不丙三丟() != null)
        {
                return (UnityEngine.Transform)val_1.且与东丕专七万丕不;
        }
        
        return (UnityEngine.Transform)val_1.且与东丕专七万丕不;
    }
    public static UnityEngine.Vector3 get_CenterOfScreen()
    {
        var val_4;
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(SupportAimController.丁万东下且丏三丂丟 != true)
        {
                val_4 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  0.5f);
            val_6 = null;
            val_6 = null;
            SupportAimController.丂丗丑专丒业丟丂丁 = val_3.x;
            SupportAimController.丁万东下且丏三丂丟.__il2cppRuntimeField_8 = val_3.y;
            SupportAimController.丁万东下且丏三丂丟.__il2cppRuntimeField_C = val_3.z;
            val_5 = null;
        }
        
        val_5 = null;
        return new UnityEngine.Vector3() {x = SupportAimController.丂丗丑专丒业丟丂丁, y = SupportAimController.丁万东下且丏三丂丟.__il2cppRuntimeField_8, z = SupportAimController.丁万东下且丏三丂丟.__il2cppRuntimeField_C};
    }
    private void Start()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._playerController.mySkinName.firstPersonControl)) != false)
        {
                this._targetController.add_TargetChaged(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SupportAimController::丙下万丗丌丒一不丅()));
            this._targetController.add_TargetMissed(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SupportAimController::丝丏一丘下世丘上上()));
            PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_4 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  23);
            if(val_4 == null)
        {
                return;
        }
        
            this.上丕三丅下世丗丏丆 = val_4.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool");
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  this);
    }
    private void 丝丏一丘下世丘上上()
    {
        this.<丑丙且不丌世丞丏丏>k__BackingField = 0;
    }
    private void 丙下万丗丌丒一不丅()
    {
        this.<丑丙且不丌世丞丏丏>k__BackingField = this._targetController.Target;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丛丁丑丛丕丅丒丑丏 = val_2;
        mem[1152921539892712096] = val_2.y;
        mem[1152921539892712100] = val_2.z;
    }
    private float 东三世丅丅不丛专丑()
    {
        SupportAimSharedSettingsContainer val_1;
        var val_2;
        float val_4;
        val_1 = this;
        val_2 = null;
        val_2 = null;
        if(SupportAimController.丝丈世丑丄东丟丏丝 != 0f)
        {
                val_4 = 1152921505301098512;
            return val_4;
        }
        
        val_1 = this.settings.supportAimSharedSettingsContainer;
        val_4 = this.settings.supportAimSharedSettingsContainer.RotateSpeed;
        return val_4;
    }
    private float 一丙丅业业三业下且()
    {
        SupportAimSharedSettingsContainer val_1;
        var val_2;
        float val_4;
        val_1 = this;
        val_2 = null;
        val_2 = null;
        if(SupportAimController.专丈专丁与不且丄丂 != 0f)
        {
                val_4 = 1152921505301098516;
            return val_4;
        }
        
        val_1 = this.settings.supportAimSharedSettingsContainer;
        val_4 = this.settings.supportAimSharedSettingsContainer.playerMult;
        return val_4;
    }
    private void OnDestroy()
    {
        this.<丑丙且不丌世丞丏丏>k__BackingField = 0;
    }
    private bool 一丐丅丕丕上丞丈上()
    {
        return true;
    }
    private void Update()
    {
        float val_40;
        var val_110;
        var val_111;
        var val_112;
        var val_113;
        bool val_114;
        float val_115;
        float val_116;
        float val_117;
        float val_119;
        float val_120;
        float val_121;
        float val_122;
        float val_124;
        float val_125;
        if((GameConnect.下丅丏丄丕丐丞丞丁() != false) && ((与丂丏丛丞丞丒丟丄.七一三丄丝丒上三且() != false) && (this.上丕三丅下世丗丏丆 != true)))
        {
                if((((this._playerController.丕丞丈世丆丒业业丕() != false) && ((this.<丑丙且不丌世丞丏丏>k__BackingField) != null)) && ((this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专) != null)) && (((this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专) & 1) == 0))
        {
                if(S0 <= 15f)
        {
            goto label_23;
        }
        
        }
        
        }
        
        this.<丕七下万丏不且上东>k__BackingField = false;
        this.<丆丅上万丈不不丟丐>k__BackingField = false;
        return;
        label_23:
        if((this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专) == 0)
        {
                this.<丑丙且不丌世丞丏丏>k__BackingField = 0;
            return;
        }
        
        UnityEngine.Transform val_8 = this.transform;
        UnityEngine.Rect val_11 = SupportAimController.AimHelpRect(丁丂专业丁丅丅丈丙:  this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专, 与三丕东七丟丝丈万:  this.settings.supportAimSharedSettingsContainer, 丈七丅上丟丑专丅丝:  0, 丙与丝丘世上东且丁:  this.丝专丅业丗丁业世三(), 丕业丅丄丟丄专丌丂:  this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专);
        UnityEngine.Rect val_13 = this.丂丒丞丙三丒三丁丒(丁丂专业丁丅丅丈丙:  this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专, 丕业丅丄丟丄专丌丂:  this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专);
        UnityEngine.Vector3 val_14 = SupportAimController.CenterOfScreen;
        this.<丕七下万丏不且上东>k__BackingField = false;
        UnityEngine.Vector3 val_15 = SupportAimController.CenterOfScreen;
        UnityEngine.Vector3 val_16 = SupportAimController.CenterOfScreen;
        this.<丞与丞七且丏丑丄丆>k__BackingField = false;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, maxLength:  UnityEngine.Time.deltaTime * 12f);
        UnityEngine.Vector3 val_21 = this._playerController.mySkinName.playerAnimation.丞世专丒上专且东东();
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, maxLength:  UnityEngine.Time.deltaTime * 12f);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丛丁丑丛丕丅丒丑丏, y = 12f, z = V15.16B}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, t:  UnityEngine.Time.deltaTime * this.settings.supportAimSharedSettingsContainer.velocityFactorChangeSpeed);
        this.丛丁丑丛丕丅丒丑丏 = val_28;
        mem[1152921539893571168] = val_28.y;
        mem[1152921539893571172] = val_28.z;
        val_110 = null;
        val_110 = null;
        if(PGCompany.GamepadCoreController.GamePadEnabled == false)
        {
            goto label_65;
        }
        
        val_111 = 1;
        val_112 = 1;
        if((val_111 & 1) != 0)
        {
            goto label_66;
        }
        
        goto label_73;
        label_65:
        val_113 = null;
        val_113 = null;
        int val_29 = JoystickController.丗三丄与丂丟丌专东.TouchFingerID;
        val_111 = val_29.业丘丅丝丗丄丒丌丟().HasTouchFinger;
        if(val_111 == false)
        {
            goto label_73;
        }
        
        label_66:
        if((this.<丕七下万丏不且上东>k__BackingField) != false)
        {
                this.不业世丏与上丏三丑 = UnityEngine.Time.time;
        }
        
        label_73:
        float val_34 = UnityEngine.Time.time;
        if((val_111 | ((val_29 != 1) ? 1 : 0)) == false)
        {
            goto label_74;
        }
        
        val_114 = this.<丆丅上万丈不不丟丐>k__BackingField;
        float val_36 = val_34 - this.不业世丏与上丏三丑;
        if(val_36 >= 0)
        {
            goto label_75;
        }
        
        mem2[0] = 1;
        val_34 = val_36 / this.settings.supportAimSharedSettingsContainer.DropAutoAimTime;
        UnityEngine.Bounds val_38 = this.<丑丙且不丌世丞丏丏>k__BackingField.丞下万上三丘上与专.bounds;
        UnityEngine.Vector3 val_42 = this.丈丁丌丗与下丕丒上().position;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, d:  0.69f);
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, b:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
        val_115 = val_40;
        val_116 = this.不业世丏与上丏三丑;
        val_117 = this.settings.supportAimSharedSettingsContainer.DropAutoAimTime;
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = val_117}, b:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, b:  new UnityEngine.Vector3() {x = this.丛丁丑丛丕丅丒丑丏, y = val_45.y, z = val_45.z});
        if((this.<丞与丞七且丏丑丄丆>k__BackingField) == false)
        {
            goto label_82;
        }
        
        UnityEngine.Vector3 val_49 = this.丈丁丌丗与下丕丒上().forward;
        UnityEngine.Vector3 val_51 = this.丈丁丌丗与下丕丒上().forward;
        val_40 = 0;
        UnityEngine.Vector2 val_52 = new UnityEngine.Vector2(x:  val_49.x, y:  val_51.z);
        val_117 = val_52.x;
        float val_53 = UnityEngine.Vector2.SignedAngle(from:  new UnityEngine.Vector2() {x = this.世丙丟丒万七三丛丘, y = val_42.y}, to:  new UnityEngine.Vector2() {x = val_117, y = val_52.y});
        val_116 = this.settings.supportAimSharedSettingsContainer.lerpTime;
        this.丙一丑丏丁一且丒业 = UnityEngine.Mathf.Min(a:  this.丙一丑丏丁一且丒业 + UnityEngine.Time.deltaTime, b:  val_116);
        val_115 = -val_53;
        if((UnityEngine.Mathf.Sign(f:  val_14.x - val_15.x)) == (UnityEngine.Mathf.Sign(f:  val_115)))
        {
            goto label_99;
        }
        
        val_116 = 1.5f;
        val_115 = UnityEngine.Time.deltaTime * val_116;
        if(System.Math.Abs(val_53) < val_115)
        {
            goto label_99;
        }
        
        float val_108 = -4f;
        val_108 = UnityEngine.Time.deltaTime * val_108;
        val_108 = val_108 * this.settings.supportAimSharedSettingsContainer.lerpTime;
        val_115 = this.丙一丑丏丁一且丒业 + val_108;
        val_116 = 0f;
        this.丙一丑丏丁一且丒业 = UnityEngine.Mathf.Max(a:  val_115, b:  val_116);
        goto label_99;
        label_74:
        val_114 = this.<丆丅上万丈不不丟丐>k__BackingField;
        label_75:
        mem2[0] = 0;
        return;
        label_82:
        this.丙一丑丏丁一且丒业 = 0f;
        label_99:
        UnityEngine.Vector3 val_64 = this.丈丁丌丗与下丕丒上().forward;
        UnityEngine.Quaternion val_65 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z}, toDirection:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
        UnityEngine.Quaternion val_66 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, toDirection:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
        val_119 = this.丙一丑丏丁一且丒业 / this.settings.supportAimSharedSettingsContainer.lerpTime;
        if(this._playerController.丄丁丑丞丅一三丌丆 != false)
        {
                val_119 = UnityEngine.Mathf.Min(a:  val_119, b:  0.2f);
        }
        
        UnityEngine.Quaternion val_68 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_66.x, y = val_66.y, z = val_66.z, w = val_66.w}, b:  new UnityEngine.Quaternion() {x = val_65.x, y = val_65.y, z = val_65.z, w = val_65.w}, t:  val_119);
        val_120 = UnityEngine.Mathf.Lerp(a:  1f, b:  this.一丙丅业业三业下且(), t:  val_119);
        UnityEngine.Quaternion val_71 = this.东一丈丄不丞业七丄();
        UnityEngine.Quaternion val_72 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_68.x, y = val_68.y, z = val_68.z, w = val_68.w}, rhs:  new UnityEngine.Quaternion() {x = val_71.x, y = val_71.y, z = val_71.z, w = val_71.w});
        val_72.x = 7f - val_72.x;
        float val_74 = UnityEngine.Mathf.Lerp(a:  val_72.x, b:  0f, t:  val_72.x * 0.25f);
        UnityEngine.Vector3 val_76 = this.丈丁丌丗与下丕丒上().eulerAngles;
        UnityEngine.Quaternion val_80 = this.东一丈丄不丞业七丄();
        float val_81 = this.东三世丅丅不丛专丑();
        if(this._playerController.丙不丅丕三丂业东丕() != 0)
        {
                val_121 = val_81 * 180f;
        }
        else
        {
                val_121 = val_120 * val_81;
            val_120 = 180f;
        }
        
        val_121 = val_120 * val_121;
        val_121 = val_74 * val_121;
        val_121 = (1f - (UnityEngine.Mathf.Clamp01(value:  val_34))) * val_121;
        val_121 = UnityEngine.Time.deltaTime * val_121;
        val_122 = val_80.y;
        UnityEngine.Quaternion val_83 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_80.x, y = val_122, z = val_80.z, w = val_80.w}, b:  new UnityEngine.Quaternion() {x = val_72.x, y = val_72.y, z = val_72.z, w = val_72.w}, t:  val_121);
        UnityEngine.Quaternion val_85 = this._playerController.mySkinName.firstPersonControl.transform.rotation;
        float val_109 = val_85.y;
        val_109 = val_85.y - val_109;
        if(this.三世丏丘丏丗上丐丗 <= 1.1f)
        {
            goto label_127;
        }
        
        val_124 = val_109 * 1.05f;
        val_125 = System.Math.Abs(val_124);
        if(val_125 <= 0.95f)
        {
            goto label_136;
        }
        
        val_125 = val_124;
        val_124 = (UnityEngine.Mathf.Sign(f:  val_125)) * 0.95f;
        goto label_136;
        label_127:
        val_125 = 0.2f;
        val_122 = System.Math.Abs(val_109);
        val_124 = 0f;
        if(val_122 > val_125)
        {
                val_124 = val_109;
        }
        
        label_136:
        this._playerController.mySkinName.firstPersonControl.transform.Rotate(xAngle:  0f, yAngle:  val_124, zAngle:  0f, relativeTo:  1);
        UnityEngine.Transform val_88 = this.丈丁丌丗与下丕丒上();
        if((this.<丞与丞七且丏丑丄丆>k__BackingField) == false)
        {
            goto label_147;
        }
        
        UnityEngine.Quaternion val_89 = this.东一丈丄不丞业七丄();
        UnityEngine.Quaternion val_90 = this.东一丈丄不丞业七丄();
        UnityEngine.Quaternion val_91 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_66.x, y = val_66.y, z = val_66.z, w = val_66.w}, rhs:  new UnityEngine.Quaternion() {x = val_90.x, y = val_90.y, z = val_90.z, w = val_90.w});
        UnityEngine.Quaternion val_92 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_89.x, y = val_89.y, z = val_89.z, w = val_89.w}, b:  new UnityEngine.Quaternion() {x = val_91.x, y = val_91.y, z = val_91.z, w = val_91.w}, t:  val_74);
        if(val_88 != null)
        {
            goto label_155;
        }
        
        label_156:
        label_155:
        val_88.rotation = new UnityEngine.Quaternion() {x = val_92.x, y = val_92.y, z = val_92.z, w = val_92.w};
        UnityEngine.Vector3 val_95 = this.丈丁丌丗与下丕丒上().eulerAngles;
        UnityEngine.Vector3 val_97 = this.丈丁丌丗与下丕丒上().eulerAngles;
        val_40 = 0;
        this.丈丁丌丗与下丕丒上().eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_147:
        if(val_88 != null)
        {
            goto label_155;
        }
        
        goto label_156;
        label_174:
        do
        {
            val_40 = 0;
            UnityEngine.Vector2 val_106 = new UnityEngine.Vector2(x:  0f, y:  -);
            if(this._playerController.mySkinName.firstPersonControl.playerCamera != null)
        {
                return;
        }
        
            return;
        }
        while(this._playerController != null);
        
        goto label_174;
    }
    private void LateUpdate()
    {
        UnityEngine.Vector3 val_2 = this.丈丁丌丗与下丕丒上().forward;
        UnityEngine.Vector3 val_4 = this.丈丁丌丗与下丕丒上().forward;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_2.x, y:  val_4.z);
        this.世丙丟丒万七三丛丘 = val_5.x;
        mem[1152921539893949492] = val_5.y;
    }
    private UnityEngine.Quaternion 东一丈丄不丞业七丄()
    {
        UnityEngine.Quaternion val_3 = this.丈丁丌丗与下丕丒上().rotation;
        if(this._playerController.mySkinName.firstPersonControl.丘丂三东丁且丙世七() == false)
        {
                return new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        }
        
        UnityEngine.Quaternion val_5 = this.丈丁丌丗与下丕丒上().rotation;
        this = this.丈丁丌丗与下丕丒上();
        UnityEngine.Quaternion val_7 = this.rotation;
        float val_9 = -2f;
        val_9 = val_3.x + val_9;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  val_9, y:  val_5.y, z:  val_7.z);
        return new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
    }
    internal UnityEngine.Rect 丂丒丞丙三丒三丁丒(UnityEngine.Collider 丁丂专业丁丅丅丈丙, UnityEngine.Collider 丕业丅丄丟丄专丌丂)
    {
        float val_3;
        UnityEngine.Bounds val_1 = 丁丂专业丁丅丅丈丙.bounds;
        if(丕业丅丄丟丄专丌丂 != 0)
        {
                UnityEngine.Bounds val_5 = 丕业丅丄丟丄专丌丂.bounds;
        }
        
        UnityEngine.Vector3 val_8 = this.丝专丅业丗丁业世三().transform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        float val_28 = val_9.x;
        UnityEngine.Vector3 val_11 = this.丝专丅业丗丁业世三().WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        float val_27 = val_11.x;
        float val_16 = val_27 / (SupportAimController.GetSizeFactorByFOV(丁丌业三东不东东丙:  this.丝专丅业丗丁业世三().fieldOfView));
        val_16 = val_16 / val_28;
        val_16 = val_16 * (float)UnityEngine.Screen.width;
        val_27 = val_16 * this.settings.supportAimSharedSettingsContainer.width;
        val_16 = val_16 / (SupportAimController.GetSizeFactorByFOV(丁丌业三东不东东丙:  this.丝专丅业丗丁业世三().fieldOfView));
        val_16 = val_16 / val_28;
        val_16 = val_16 * (float)UnityEngine.Screen.height;
        val_28 = this.settings.supportAimSharedSettingsContainer.height * val_16;
        float val_22 = (float)UnityEngine.Screen.height - val_11.y;
        val_3 = 0;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_27, y:  val_28);
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    public static UnityEngine.Rect AimHelpRect(UnityEngine.Collider 丁丂专业丁丅丅丈丙, SupportAimSettingsContainer.SupportAimSharedSettingsContainer 与三丕东七丟丝丈万, UnityEngine.Transform 丈七丅上丟丑专丅丝, UnityEngine.Camera 丙与丝丘世上东且丁, UnityEngine.Collider 丕业丅丄丟丄专丌丂)
    {
        float val_3;
        UnityEngine.Bounds val_1 = 丁丂专业丁丅丅丈丙.bounds;
        if(丕业丅丄丟丄专丌丂 != 0)
        {
                UnityEngine.Bounds val_5 = 丕业丅丄丟丄专丌丂.bounds;
        }
        
        UnityEngine.Vector3 val_7 = 丙与丝丘世上东且丁.transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        float val_30 = val_8.x;
        UnityEngine.Vector3 val_9 = 丙与丝丘世上东且丁.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        float val_28 = val_9.x;
        float val_11 = SupportAimController.GetSizeFactorByFOV(丁丌业三东不东东丙:  丙与丝丘世上东且丁.fieldOfView);
        val_11 = val_28 / val_11;
        val_11 = val_11 / val_30;
        val_28 = val_11 * (float)UnityEngine.Screen.width;
        float val_29 = (float)UnityEngine.Screen.width;
        val_28 = val_28 * 与三丕东七丟丝丈万.width;
        float val_14 = SupportAimController.GetSizeFactorByFOV(丁丌业三东不东东丙:  丙与丝丘世上东且丁.fieldOfView);
        val_14 = val_29 / val_14;
        float val_31 = 与三丕东七丟丝丈万.helpWidth;
        val_14 = val_14 / val_30;
        val_14 = val_14 * (float)UnityEngine.Screen.height;
        val_29 = 与三丕东七丟丝丈万.height * val_14;
        val_30 = val_30 / 50f;
        float val_16 = UnityEngine.Mathf.Clamp01(value:  val_30);
        float val_32 = 与三丕东七丟丝丈万.helpHeight;
        val_16 = val_28 * val_16;
        val_16 = val_16 + val_16;
        val_31 = (val_28 * val_31) + val_16;
        float val_18 = UnityEngine.Mathf.Clamp01(value:  val_30);
        val_18 = val_29 * val_18;
        val_18 = val_18 + val_18;
        val_32 = (val_29 * val_32) + val_18;
        float val_23 = (float)UnityEngine.Screen.height - val_9.y;
        val_3 = 0;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Max(a:  val_28, b:  val_31), y:  UnityEngine.Mathf.Max(a:  val_29, b:  val_32));
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    internal UnityEngine.Rect 上丄丛下丑下丌且丄(UnityEngine.Collider 丁丂专业丁丅丅丈丙, UnityEngine.Collider 丕业丅丄丟丄专丌丂)
    {
        float val_3;
        UnityEngine.Bounds val_1 = 丁丂专业丁丅丅丈丙.bounds;
        if(丕业丅丄丟丄专丌丂 != 0)
        {
                UnityEngine.Bounds val_5 = 丕业丅丄丟丄专丌丂.bounds;
        }
        
        UnityEngine.Vector3 val_7 = this.丝专丅业丗丁业世三().WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_3, y = V1.16B, z = V2.16B});
        UnityEngine.Vector3 val_10 = this.丝专丅业丗丁业世三().transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        float val_28 = val_11.x;
        float val_27 = val_11.x;
        float val_16 = val_27 / (SupportAimController.GetSizeFactorByFOV(丁丌业三东不东东丙:  this.丝专丅业丗丁业世三().fieldOfView));
        val_16 = val_16 / val_28;
        val_16 = val_16 * (float)UnityEngine.Screen.width;
        val_27 = val_16 * this.settings.supportAimSharedSettingsContainer.width;
        val_16 = val_16 / (SupportAimController.GetSizeFactorByFOV(丁丌业三东不东东丙:  this.丝专丅业丗丁业世三().fieldOfView));
        val_16 = val_16 / val_28;
        val_16 = val_16 * (float)UnityEngine.Screen.height;
        val_28 = this.settings.supportAimSharedSettingsContainer.height * val_16;
        float val_22 = (float)UnityEngine.Screen.height - val_7.y;
        val_3 = 0;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_27, y:  val_28);
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    public static float GetSizeFactorByFOV(float 丁丌业三东不东东丙)
    {
        var val_5;
        float val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if(SupportAimController.世下丝七与丁业丂丘 == 丁丌业三东不东东丙)
        {
                val_7 = SupportAimController.丒丝丑世丂丅丛丅丘;
            return val_7;
        }
        
        float val_1 = 丁丌业三东不东东丙 * 0.5f;
        float val_4 = (90f - val_1) * 0.01745329f;
        val_8 = null;
        val_4 = (val_1 * 0.01745329f) / val_4;
        val_4 = val_4 + val_4;
        val_7 = System.Math.Abs(val_4);
        val_8 = null;
        SupportAimController.世下丝七与丁业丂丘 = 丁丌业三东不东东丙;
        SupportAimController.丒丝丑世丂丅丛丅丘 = val_7;
        return val_7;
    }
    public SupportAimController()
    {
        this.三世丏丘丏丗上丐丗 = 1f;
    }
    private static SupportAimController()
    {
        SupportAimController.丁万东下且丏三丂丟 = false;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        SupportAimController.丂丗丑专丒业丟丂丁 = val_1.x;
        SupportAimController.丁万东下且丏三丂丟.__il2cppRuntimeField_8 = val_1.y;
        SupportAimController.丁万东下且丏三丂丟.__il2cppRuntimeField_C = val_1.z;
        SupportAimController.世下丝七与丁业丂丘 = -1f;
        SupportAimController.丒丝丑世丂丅丛丅丘 = 0f;
    }

}
