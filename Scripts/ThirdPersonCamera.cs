using UnityEngine;
internal class ThirdPersonCamera : BaseCamera
{
    // Fields
    public static float startMouseXForShattle;
    public UnityEngine.Transform gunPivot;
    public UnityEngine.Transform cameraVisualPivot;
    public float TimeRotationCam;
    public float distanceMin;
    public float mouseSpeed;
    public float mouseScroll;
    public float mouseSmoothingFactor;
    public float camDistanceSpeed;
    public float camBottomDistance;
    public float firstPersonThreshold;
    public float characterFadeThreshold;
    private float 丄丐丆丕三七丁丆与;
    public float speedRotateXOnGo;
    public bool isDragging;
    private bool 不丄丑丑丒三专万丏;
    private UnityEngine.Vector3 东东丙世丆东丕不丗;
    public float desiredDistance;
    public float offsetMaxDistance;
    public float offsetY;
    public float lastDistance;
    public float deltaMouseX;
    private float 业丙丒一丝下一丞丛;
    private float 丕上丒丟专丅丄七丘;
    public float mouseYSmooth;
    private float 丕东丂丞世上丐丛丂;
    public float mouseYMin;
    public float mouseYMax;
    private float 丂丞丙不丛下丐丆丈;
    private bool 不业丅丝丅专丞丄专;
    private static float 丝丝业东丕丂丌丁三;
    private static float 丒不世丞丁丘丞七万;
    private static float 丙丆丄丏丛业丌一丕;
    private static float 下丁丒一丂丐丞丕丞;
    internal float 丑七且丞丌东一丗丙;
    public UnityEngine.Vector2 controlVector;
    public UnityEngine.Vector3 curTargetEulerAngles;
    private bool 丒下丏丙丁一一世丆;
    private bool 丘下丛一丞丗不丑丐;
    private float clipMoveTime;
    private UnityEngine.RaycastHit 丂七丑世丏丐丅不丌;
    private float 丅丗丘丗丐不七丕丅;
    public UnityEngine.LayerMask collisionLayer;
    private UnityEngine.Vector3 丏丟丘不一专丄上七;
    private UnityEngine.Quaternion 丏专万丘七丁一万丈;
    private float shoulderZoomCamDistance;
    private float shoulderZoomCamSpeed;
    private float shoulderZoomFovChangeSpeed;
    private UnityEngine.Coroutine 一上丝丘丌丞丐三丟;
    private float 丁丗丟丗丐丂且不丕;
    private float 丈世上与且丏一丁丅;
    private bool 专丄丐东丑丒丈业七;
    public float z;
    public UnityEngine.Vector3 offsetLook;
    private bool 丆专业七三丂丑丘丄;
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        if(GameConnect.丆丕丒与丂七与下上() != false)
        {
                mem[1152921539918064072] = 1089680179;
        }
        
        this.丅丗丘丗丐不七丕丅 = this.camera.nearClipPlane;
        mem[1152921539918064088] = 1097859072;
        mem[1152921539918064064] = this.camera.fieldOfView;
        mem[1152921539918064068] = 0;
    }
    private void Start()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_15 = null;
        val_15 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  UnityEngine.Application.loadedLevelName)) != 0)
        {
                mem2[0] = val_2.positionCam;
            mem[1152921539918205052] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_2.rotationCam, y = V8.16B, z = V9.16B});
            this.丏专万丘七丁一万丈 = val_4;
            mem[1152921539918205060] = val_4.y;
            mem[1152921539918205064] = val_4.z;
            mem[1152921539918205068] = val_4.w;
        }
        
        float val_5 = UnityEngine.Mathf.Clamp(value:  V9.16B, min:  this.distanceMin, max:  V8.16B);
        mem[1152921539918204748] = val_5;
        this.desiredDistance = val_5;
        val_16 = null;
        val_16 = null;
        float val_16 = 0.01745329f;
        float val_15 = 0.5f;
        val_15 = this.camera.fieldOfView * val_15;
        val_16 = val_15 * val_16;
        ThirdPersonCamera.丝丝业东丕丂丌丁三 = val_16;
        ThirdPersonCamera.丒不世丞丁丘丞七万 = this.camera.aspect;
        float val_17 = ThirdPersonCamera.丝丝业东丕丂丌丁三;
        val_17 = this.camera.nearClipPlane * val_17;
        ThirdPersonCamera.丙丆丄丏丛业丌一丕 = val_17;
        float val_18 = ThirdPersonCamera.丒不世丞丁丘丞七万;
        val_18 = ThirdPersonCamera.丙丆丄丏丛业丌一丕 * val_18;
        ThirdPersonCamera.下丁丒一丂丐丞丕丞 = val_18;
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_18 = null;
            val_18 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_19 = null;
            val_19 = null;
            this.mouseYMin = -55f;
            this.mouseYMax = 75f;
        }
        
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
                return;
        }
        
        this.mouseYMin = -10f;
        this.mouseYMax = 30f;
    }
    internal override void OnDestroy()
    {
        this.OnDestroy();
        if(this.一上丝丘丌丞丐三丟 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.一上丝丘丌丞丐三丟);
        this.一上丝丘丌丞丐三丟 = 0;
    }
    private void LateUpdate()
    {
        float val_23;
        UnityEngine.Quaternion val_24;
        float val_25;
        bool val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        if(static_value_082C3000 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = position;
        val_23 = -5000f;
        if(val_2.y < 0)
        {
                this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = this.丏丟丘不一专丄上七, y = V9.16B, z = V10.16B};
            val_24 = this.丏专万丘七丁一万丈;
            this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_24, y = V9.16B, z = V10.16B, w = V11.16B};
            val_26 = 1;
        }
        else
        {
                if(this.gunPivot != 0)
        {
                UnityEngine.Quaternion val_7 = this.gunPivot.parent.rotation;
            mem[1152921539918490196] = val_7.y;
            UnityEngine.Quaternion val_8 = this.gunPivot.localRotation;
            val_23 = val_8.x + 12f;
            mem[1152921539918490200] = val_23;
        }
        
            if(this.cameraVisualPivot != 0)
        {
                UnityEngine.Vector3 val_10 = this.cameraVisualPivot.position;
            val_25 = val_10.z;
            UnityEngine.Vector3 val_12 = this.transform.position;
            val_28 = val_25;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_28}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_27 = val_13.x;
        }
        
            val_29 = 0f;
            if(val_27 >= 0)
        {
                val_29 = 1f;
            if(val_27 <= val_29)
        {
                float val_20 = -0.6f;
            val_20 = val_27 + val_20;
            val_29 = val_20 / 0.4f;
        }
        
        }
        
            float val_21 = 0.01f;
            val_24 = val_29 + val_21;
            val_30 = 0.02f;
            val_21 = this.丈世上与且丏一丁丅 - val_24;
            val_31 = System.Math.Abs(val_21);
            if(val_31 > val_30)
        {
                val_32 = null;
            val_32 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_33 = null;
            val_33 = null;
            val_34 = null;
            val_34 = null;
            val_35 = null;
            val_35 = null;
            val_31 = 0.2f;
            val_28 = 1f;
            val_30 = UnityEngine.Mathf.Clamp(value:  val_24, min:  val_31, max:  val_28);
            丑丂丛丐丟丈下丕丌(世丂丞下丅且丕上丝:  val_30);
            this.丈世上与且丏一丁丅 = val_24;
        }
        
        }
        
            if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                val_36 = null;
            val_36 = null;
            if(丑丈上东丗丐丆世上() != true)
        {
                val_37 = null;
            val_37 = null;
            val_31 = 0.2f;
            val_28 = 1f;
            val_24 = UnityEngine.Mathf.Clamp(value:  0.3f, min:  val_31, max:  val_28);
            val_30 = val_24;
            丑丂丛丐丟丈下丕丌(世丂丞下丅且丕上丝:  val_30);
        }
        
        }
        
            UnityEngine.Vector3 val_19 = eulerAngles;
            this.curTargetEulerAngles = val_19;
            mem[1152921539918490416] = val_19.y;
            mem[1152921539918490420] = val_19.z;
            this.desiredDistance = -3.531914E+36f;
            this.世丂丆丘上与丁丑且();
            this.丕丐与丂东与丒丏丄();
            val_26 = false;
        }
        
        this.专丄丐东丑丒丈业七 = val_26;
    }
    private void 世且丘丏丑丙下丁丒()
    {
        var val_24;
        float val_25;
        float val_26;
        if((double)S0 <= 0.1)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.camBottomDistance);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        bool val_10 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, end:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        this.不业丅丝丅专丞丄专 = val_10;
        if(val_10 == false)
        {
            goto label_6;
        }
        
        label_11:
        UnityEngine.Transform val_11 = this.transform;
        UnityEngine.Vector3 val_12 = val_11.position;
        UnityEngine.Vector3 val_14 = val_11.transform.position;
        var val_16 = ((val_12.y - val_14.y) <= 0f) ? 1 : 0;
        goto label_10;
        label_1:
        if(this.不业丅丝丅专丞丄专 == true)
        {
            goto label_11;
        }
        
        label_6:
        val_24 = 0;
        label_10:
        mem[1152921539918651352] = this.不世丟丏与世东丟东(一不丅与丟丌丏丟东:  (double)S0, 丒丛七丄世业东丝丁:  -25f, 七丝东丛东丝且丆不:  89.5f);
        this.业丙丒一丝下一丞丛 = UnityEngine.Mathf.SmoothDamp(current:  this.业丙丒一丝下一丞丛, target:  V9.16B, currentVelocity: ref  this.丕上丒丟专丅丄七丘, smoothTime:  this.mouseSmoothingFactor);
        if(val_24 != 0)
        {
            
        }
        else
        {
                val_25 = -89.5f;
        }
        
        val_26 = this.desiredDistance;
        this.mouseYMin = val_25;
        if(val_26 > this.mouseSmoothingFactor)
        {
                val_26 = this.mouseSmoothingFactor;
            this.desiredDistance = this.mouseSmoothingFactor;
        }
        
        if(val_26 < 0)
        {
                this.desiredDistance = this.distanceMin;
        }
        
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.zero;
        this.controlVector = val_20;
        mem[1152921539918651560] = val_20.y;
    }
    private void 世丂丆丘上与丁丑且()
    {
        float val_23;
        var val_24;
        float val_25;
        var val_26;
        float val_27;
        float val_28;
        float val_29;
        mem[1152921539918792012] = this.desiredDistance;
        UnityEngine.Vector3 val_1 = this.丘丆丛丕丟丙东丈七(丈七与丒丗丑下丘丈:  null, 丕丒丒丝万丆丐丈丘:  null, 丌七丒世丄上丞丞丁:  this.desiredDistance);
        this.东东丙世丆东丕不丗 = val_1;
        mem[1152921539918792164] = val_1.y;
        mem[1152921539918792168] = val_1.z;
        UnityEngine.Vector3 val_2 = position;
        float val_3 = this.丑与不丒丙丗丌丐万(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = this.东东丙世丆东丕不丗});
        val_23 = -1f;
        if(val_3 == val_23)
        {
                val_24 = 0;
        }
        else
        {
                mem[1152921539918792012] = val_3;
            UnityEngine.Vector3 val_4 = this.丘丆丛丕丟丙东丈七(丈七与丒丗丑下丘丈:  val_23, 丕丒丒丝万丆丐丈丘:  val_2.y, 丌七丒世丄上丞丞丁:  val_3);
            val_24 = 1;
            this.东东丙世丆东丕不丗 = val_4;
            mem[1152921539918792164] = val_4.y;
            mem[1152921539918792168] = val_4.z;
        }
        
        val_25 = S8 - this.camera.nearClipPlane;
        mem[1152921539918792012] = val_25;
        var val_7 = (this.lastDistance > val_25) ? 1 : 0;
        val_7 = val_24 & val_7;
        if(val_7 != 0)
        {
                val_26 = 1152921504838422528;
            val_27 = this.clipMoveTime;
        }
        else
        {
                val_26 = 1152921504838422528;
            val_27 = this.camDistanceSpeed;
        }
        
        float val_9 = UnityEngine.Mathf.SmoothDamp(current:  this.lastDistance, target:  val_25, currentVelocity: ref  this.丂丞丙不丛下丐丆丈, smoothTime:  val_27);
        val_28 = val_9;
        mem[1152921539918792012] = val_28;
        if(val_28 < 0)
        {
                val_28 = this.distanceMin;
            mem[1152921539918792012] = this.distanceMin;
        }
        
        this.lastDistance = val_28;
        UnityEngine.Vector3 val_10 = this.丘丆丛丕丟丙东丈七(丈七与丒丗丑下丘丈:  val_9, 丕丒丒丝万丆丐丈丘:  this.distanceMin, 丌七丒世丄上丞丞丁:  val_28);
        this.东东丙世丆东丕不丗 = val_10;
        mem[1152921539918792164] = val_10.y;
        mem[1152921539918792168] = val_10.z;
        if(this.东东丙世丆东丕不丗 < 0)
        {
                val_25 = val_10.x;
            val_27 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_29 = val_25;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_29, y = val_10.y, z = val_27}, rhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) != false)
        {
                val_25 = this.东东丙世丆东丕不丗;
            float val_20 = this.offsetY;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29, y = val_10.y, z = val_27}, d:  val_20);
            val_20 = 4f - val_20;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_20);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.25f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25, y = val_10.y, z = val_27}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this.东东丙世丆东丕不丗 = val_16;
            mem[1152921539918792164] = val_16.y;
            mem[1152921539918792168] = val_16.z;
            this.丘下丛一丞丗不丑丐 = true;
            return;
        }
        
        }
        
        this.丘下丛一丞丗不丑丐 = false;
        if(this.camera.nearClipPlane == this.丅丗丘丗丐不七丕丅)
        {
                return;
        }
        
        this.camera.nearClipPlane = this.丅丗丘丗丐不七丕丅;
    }
    private void 丕丐与丂东与丒丏丄()
    {
        var val_11;
        UnityEngine.Vector3 val_12;
        float val_13;
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                val_11 = null;
            val_11 = null;
            if(PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.TaskIsOpen == true)
        {
                return;
        }
        
        }
        
        if(this.丆专业七三丂丑丘丄 != false)
        {
                val_12 = this.东东丙世丆东丕不丗;
            this.transform.position = new UnityEngine.Vector3() {x = val_12, y = V9.16B, z = V10.16B};
        }
        
        if(val_12 <= 0f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = X21.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.offsetLook, y = V11.16B, z = V10.16B});
        this.丌丟丄业且三丛丕丄().LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Transform val_7 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_8 = val_7.eulerAngles;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_12 = val_9.x;
        val_13 = val_9.z;
        val_7.eulerAngles = new UnityEngine.Vector3() {x = val_12, y = val_9.y, z = val_13};
        this.丌丟丄业且三丛丕丄().Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
    }
    internal override void 一上丘丞丕丅丝丑丄(UnityEngine.Vector2 丞且丅三三东不丄且, float 丗丝业万与丆七东丁, bool 丝业丈不丙丄丝一一, bool 与丒下丅丛丏丘世丘 = False, bool 丅与万万丌一丑丟丒 = False)
    {
        float val_2;
        float val_3;
        if(与丒下丅丛丏丘世丘 != true)
        {
                丞且丅三三东不丄且.x = 丞且丅三三东不丄且.x * 丗丝业万与丆七东丁;
            丞且丅三三东不丄且.x = 丞且丅三三东不丄且.x / 24f;
            val_2 = 丞且丅三三东不丄且.x + S3;
        }
        
        mem[1152921539919061076] = val_2;
        if(val_2 > 360f)
        {
                do
        {
            val_2 = val_2 + (-360f);
        }
        while(val_2 > 360f);
        
            mem[1152921539919061076] = val_2;
        }
        
        if(val_2 < 0)
        {
                do
        {
            val_2 = val_2 + 360f;
        }
        while(val_2 < 0);
        
            mem[1152921539919061076] = val_2;
        }
        
        if(丅与万万丌一丑丟丒 != true)
        {
                丞且丅三三东不丄且.y = 丞且丅三三东不丄且.y * 丗丝业万与丆七东丁;
            丞且丅三三东不丄且.y = 丞且丅三三东不丄且.y * ((丝业丈不丙丄丝一一 != true) ? 1f : -1f);
            丞且丅三三东不丄且.y = 丞且丅三三东不丄且.y / 24f;
            val_3 = 丞且丅三三东不丄且.y + val_2;
        }
        
        mem[1152921539919061080] = val_3;
        if(val_3 < 0)
        {
                val_3 = this.mouseYMin;
            mem[1152921539919061080] = this.mouseYMin;
        }
        
        if(val_3 <= this.mouseYMax)
        {
                return;
        }
        
        mem[1152921539919061080] = this.mouseYMax;
    }
    private void 丈丌丈丆丗不上业丘()
    {
        var val_34;
        var val_39;
        float val_40;
        if(RPG_Animation.instance == 0)
        {
                return;
        }
        
        if(S8 < 0)
        {
                RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().enabled = false;
            return;
        }
        
        RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().enabled = true;
        if(S8 < 0)
        {
                float val_5 = this.characterFadeThreshold - S2;
            val_5 = val_5 / (this.characterFadeThreshold - this.firstPersonThreshold);
            val_5 = 1f - val_5;
            UnityEngine.Color val_8 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            if(val_8.a == val_5)
        {
                return;
        }
        
            val_34 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material;
            UnityEngine.Color val_13 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            UnityEngine.Color val_16 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            UnityEngine.Color val_19 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            val_39 = val_16.g;
            val_40 = val_5;
        }
        else
        {
                UnityEngine.Color val_22 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            if(val_22.a == 1f)
        {
                return;
        }
        
            val_34 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material;
            UnityEngine.Color val_27 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            UnityEngine.Color val_30 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            UnityEngine.Color val_33 = RPG_Animation.instance.GetComponent<UnityEngine.Renderer>().material.color;
            val_40 = 1f;
            val_39 = val_30.g;
        }
        
        val_34.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private UnityEngine.Vector3 丘丆丛丕丟丙东丈七(float 丈七与丒丗丑下丘丈, float 丕丒丒丝万丆丐丈丘, float 丌七丒世丄上丞丞丁)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(x:  丈七与丒丗丑下丘丈, y:  丕丒丒丝万丆丐丈丘, z:  0f);
        UnityEngine.Vector3 val_2 = this.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    private float 丑与不丒丙丗丌丐万(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        var val_2;
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        var val_105;
        UnityEngine.RaycastHit val_106;
        float val_107;
        float val_108;
        float val_109;
        float val_110;
        float val_111;
        float val_112;
        float val_113;
        var val_114;
        float val_115;
        float val_116;
        float val_117;
        var val_118;
        var val_119;
        float val_121;
        var val_122;
        val_105 = this;
        丕丆丒丒丁丗丛丟丞 val_1 = this.GetClipPlaneAt(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z});
        val_106 = this.丂七丑世丏丐丅不丌;
        bool val_15 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, end:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_Normal = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_FaceID = val_106, m_Distance = val_106, m_UV = new UnityEngine.Vector2() {x = val_106, y = val_106}, m_Collider = val_106}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        val_107 = -1f;
        if(val_15 == false)
        {
            goto label_1;
        }
        
        if((val_15.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) == false)
        {
            goto label_4;
        }
        
        val_107 = val_106.targetValue - this.camera.nearClipPlane;
        goto label_4;
        label_1:
        label_4:
        UnityEngine.Vector3 val_21 = this.transform.right;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_25 = this.transform.up;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        bool val_29 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, end:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_Normal = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_FaceID = val_106, m_Distance = val_106, m_UV = new UnityEngine.Vector2() {x = val_106, y = val_106}, m_Collider = val_106}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if((val_29 != false) && ((val_29.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) != false))
        {
                float val_31 = val_106.targetValue;
            val_108 = 丈丗与丞一上且上上.y;
            val_109 = 丈丗与丞一上且上上.z;
            val_110 = 丈丗与丞一上且上上.x;
            if(val_107 != (-1f))
        {
                if(val_31 >= 0)
        {
            goto label_21;
        }
        
        }
        
            UnityEngine.Vector3 val_33 = this.transform.right;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31, y = -1f, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            UnityEngine.Vector3 val_37 = this.transform.up;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            val_110 = 丈丗与丞一上且上上.x;
            val_108 = 丈丗与丞一上且上上.y;
            val_109 = 丈丗与丞一上且上上.z;
            val_107 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_110, y = val_108, z = val_109});
        }
        else
        {
                val_108 = 丈丗与丞一上且上上.y;
            val_109 = 丈丗与丞一上且上上.z;
            val_110 = 丈丗与丞一上且上上.x;
        }
        
        label_21:
        UnityEngine.Vector3 val_42 = this.transform.right;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_110, y = val_108, z = val_109}, b:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
        UnityEngine.Vector3 val_46 = this.transform.up;
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
        val_111 = val_48.x;
        val_112 = val_48.y;
        val_113 = val_48.z;
        bool val_50 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_111, y = val_112, z = val_113}, end:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_Normal = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_FaceID = val_106, m_Distance = val_106, m_UV = new UnityEngine.Vector2() {x = val_106, y = val_106}, m_Collider = val_106}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if((val_50 != false) && ((val_50.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) != false))
        {
                float val_52 = val_106.targetValue;
            val_112 = -1f;
            if(val_107 != val_112)
        {
                if(val_52 >= 0)
        {
            goto label_31;
        }
        
        }
        
            UnityEngine.Vector3 val_54 = this.transform.right;
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_52, y = val_112, z = val_113}, b:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z});
            UnityEngine.Vector3 val_58 = this.transform.up;
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
            val_111 = val_56.x;
            val_112 = val_56.y;
            val_113 = val_56.z;
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_111, y = val_112, z = val_113}, b:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
            val_110 = 丈丗与丞一上且上上.x;
            val_108 = 丈丗与丞一上且上上.y;
            val_109 = 丈丗与丞一上且上上.z;
            val_107 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, b:  new UnityEngine.Vector3() {x = val_110, y = val_108, z = val_109});
        }
        
        label_31:
        UnityEngine.Vector3 val_63 = this.transform.right;
        val_114 = null;
        val_114 = null;
        UnityEngine.Vector3 val_64 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_110, y = val_108, z = val_109}, b:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z});
        UnityEngine.Vector3 val_67 = this.transform.up;
        UnityEngine.Vector3 val_68 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_69 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, b:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z});
        val_115 = val_69.x;
        val_116 = val_69.y;
        val_117 = val_69.z;
        bool val_71 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = val_117}, end:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_Normal = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_FaceID = val_106, m_Distance = val_106, m_UV = new UnityEngine.Vector2() {x = val_106, y = val_106}, m_Collider = val_106}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if((val_71 != false) && ((val_71.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) != false))
        {
                float val_73 = val_106.targetValue;
            val_116 = -1f;
            if(val_107 != val_116)
        {
                if(val_73 >= 0)
        {
            goto label_47;
        }
        
        }
        
            UnityEngine.Vector3 val_75 = this.transform.right;
            val_118 = null;
            val_118 = null;
            UnityEngine.Vector3 val_76 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_73, y = val_116, z = val_117}, b:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z});
            UnityEngine.Vector3 val_79 = this.transform.up;
            UnityEngine.Vector3 val_80 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
            val_115 = val_77.x;
            val_116 = val_77.y;
            val_117 = val_77.z;
            UnityEngine.Vector3 val_81 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_115, y = val_116, z = val_117}, b:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z});
            val_110 = 丈丗与丞一上且上上.x;
            val_108 = 丈丗与丞一上且上上.y;
            val_109 = 丈丗与丞一上且上上.z;
            val_107 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_81.x, y = val_81.y, z = val_81.z}, b:  new UnityEngine.Vector3() {x = val_110, y = val_108, z = val_109});
        }
        
        label_47:
        UnityEngine.Vector3 val_84 = this.transform.right;
        val_119 = null;
        val_119 = null;
        UnityEngine.Vector3 val_85 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_84.x, y = val_84.y, z = val_84.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_86 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_110, y = val_108, z = val_109}, b:  new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z});
        UnityEngine.Vector3 val_88 = this.transform.up;
        UnityEngine.Vector3 val_89 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_88.x, y = val_88.y, z = val_88.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_90 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_86.z}, b:  new UnityEngine.Vector3() {x = val_89.x, y = val_89.y, z = val_89.z});
        val_121 = val_90.x;
        bool val_92 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_121, y = val_90.y, z = val_90.z}, end:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_Normal = new UnityEngine.Vector3() {x = val_106, y = val_106, z = val_106}, m_FaceID = val_106, m_Distance = val_106, m_UV = new UnityEngine.Vector2() {x = val_106, y = val_106}, m_Collider = val_106}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if(val_92 == false)
        {
                return (float)val_107;
        }
        
        if((val_92.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) == false)
        {
                return (float)val_107;
        }
        
        float val_94 = val_106.targetValue;
        if(val_107 != (-1f))
        {
                if(val_94 >= 0)
        {
                return (float)val_107;
        }
        
        }
        
        UnityEngine.Vector3 val_96 = this.transform.right;
        val_122 = null;
        val_108 = val_96.y;
        val_122 = null;
        UnityEngine.Vector3 val_97 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_96.x, y = val_108, z = val_96.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_98 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_94, y = -1f, z = val_90.z}, b:  new UnityEngine.Vector3() {x = val_97.x, y = val_97.y, z = val_97.z});
        val_121 = val_98.x;
        val_105 = this.transform;
        UnityEngine.Vector3 val_100 = val_105.up;
        UnityEngine.Vector3 val_101 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_100.x, y = val_100.y, z = val_100.z}, d:  ThirdPersonCamera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_102 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_121, y = val_98.y, z = val_98.z}, b:  new UnityEngine.Vector3() {x = val_101.x, y = val_101.y, z = val_101.z});
        val_107 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_102.x, y = val_102.y, z = val_102.z}, b:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z});
        return (float)val_107;
    }
    private bool 专丒丁万业丒且丐丕(UnityEngine.RaycastHit 丛丈丑东且业丈丗万)
    {
        return System.String.op_Inequality(a:  丛丈丑东且业丈丗万.m_Point.x.tag, b:  "Player");
    }
    private float 不世丟丏与世东丟东(float 一不丅与丟丌丏丟东, float 丒丛七丄世业东丝丁, float 七丝东丛东丝且丆不)
    {
        goto label_1;
        label_3:
        float val_2 = (100655104 != 1) ? (一不丅与丟丌丏丟东 + 360f) : (一不丅与丟丌丏丟东);
        一不丅与丟丌丏丟东 = (val_2 > 360f) ? (val_2 + (-360f)) : (val_2);
        label_1:
        var val_4 = (一不丅与丟丌丏丟东 < 0) ? 1 : 0;
        if((一不丅与丟丌丏丟东 > 360f) || (一不丅与丟丌丏丟东 < 0))
        {
            goto label_3;
        }
        
        return UnityEngine.Mathf.Clamp(value:  一不丅与丟丌丏丟东, min:  丒丛七丄世业东丝丁, max:  七丝东丛东丝且丆不);
    }
    public ThirdPersonCamera.丕丆丒丒丁丗丛丟丞 GetClipPlaneAt(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        float val_44;
        UnityEngine.Object val_45;
        var val_46;
        float val_47;
        float val_48;
        float val_49;
        float val_50;
        float val_51;
        float val_52;
        float val_53;
        float val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        var val_59;
        丕丆丒丒丁丗丛丟丞 val_0;
        val_44 = 下业丕七东丌丝下且.y;
        val_45 = this.camera;
        val_46 = null;
        val_47 = 0f;
        val_48 = 0f;
        val_49 = 0f;
        val_50 = 0f;
        val_51 = 0f;
        val_52 = 0f;
        val_53 = 0f;
        val_54 = 0f;
        val_55 = 0f;
        val_56 = 0f;
        val_57 = 0f;
        val_58 = 0f;
        if(val_45 != 0)
        {
                val_45 = this.camera.transform;
            float val_6 = this.camera.nearClipPlane;
            UnityEngine.Vector3 val_7 = val_45.right;
            val_59 = null;
            val_59 = null;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  ThirdPersonCamera.下丁丒一丂丐丞丕丞 + this.丑七且丞丌东一丗丙);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = val_44, z = 下业丕七东丌丝下且.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = val_45.up;
            float val_44 = ThirdPersonCamera.丙丆丄丏丛业丌一丕;
            val_44 = val_44 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_44);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = val_45.forward;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_6);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = val_45.right;
            float val_45 = ThirdPersonCamera.下丁丒一丂丐丞丕丞;
            val_45 = val_45 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  val_45);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = val_44, z = 下业丕七东丌丝下且.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_20 = val_45.up;
            float val_46 = ThirdPersonCamera.丙丆丄丏丛业丌一丕;
            val_46 = val_46 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  val_46);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = val_45.forward;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_6);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            val_51 = val_25.y;
            val_52 = val_25.z;
            UnityEngine.Vector3 val_26 = val_45.right;
            float val_47 = ThirdPersonCamera.下丁丒一丂丐丞丕丞;
            val_47 = val_47 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  val_47);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = val_44, z = 下业丕七东丌丝下且.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            UnityEngine.Vector3 val_29 = val_45.up;
            float val_48 = ThirdPersonCamera.丙丆丄丏丛业丌一丕;
            val_48 = val_48 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  val_48);
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            UnityEngine.Vector3 val_32 = val_45.forward;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  val_6);
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            val_53 = val_34.x;
            val_54 = val_34.y;
            val_55 = val_34.z;
            UnityEngine.Vector3 val_35 = val_45.right;
            float val_49 = ThirdPersonCamera.下丁丒一丂丐丞丕丞;
            val_49 = val_49 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  val_49);
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = val_44, z = 下业丕七东丌丝下且.z}, b:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            UnityEngine.Vector3 val_38 = val_45.up;
            float val_50 = ThirdPersonCamera.丙丆丄丏丛业丌一丕;
            val_50 = val_50 + this.丑七且丞丌东一丗丙;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, d:  val_50);
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
            val_44 = val_40.y;
            UnityEngine.Vector3 val_41 = val_45.forward;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, d:  val_6);
            val_56 = val_40.x;
            val_57 = val_44;
            val_58 = val_40.z;
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_56, y = val_57, z = val_58}, b:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z});
            val_48 = val_16.y;
            val_47 = val_16.x;
            val_50 = val_25.x;
            val_49 = val_16.z;
        }
        
        val_0.丐丌丟丐丐丏丒七业.x = val_47;
        val_0.丐丌丟丐丐丏丒七业.y = val_48;
        val_0.丐丌丟丐丐丏丒七业.z = val_49;
        val_0.丌丂丐丄丏上业上丂.x = val_50;
        val_0.丌丂丐丄丏上业上丂.y = val_51;
        val_0.丌丂丐丄丏上业上丂.z = val_52;
        val_0.丒世七丏一丙不丙丌.x = val_53;
        val_0.丒世七丏一丙不丙丌.y = val_54;
        val_0.丒世七丏一丙不丙丌.z = val_55;
        val_0.丌东丘丌一丐万丕且.x = val_43.x;
        val_0.丌东丘丌一丐万丕且.y = val_43.y;
        val_0.丌东丘丌一丐万丕且.z = val_43.z;
        return val_0;
    }
    public void SetFollowPivot()
    {
        this.丆专业七三丂丑丘丄 = true;
    }
    internal override void 且丁不丒业丏丌丄丈()
    {
        this.丆专业七三丂丑丘丄 = false;
    }
    internal override void 丗丂东丌丙一丕业丙(UnityEngine.Vector2 丞且丅三三东不丄且, bool 万业丒丞丅一丂丈业 = False)
    {
        this.不丄丑丑丒三专万丏 = 万业丒丞丅一丂丈业;
        if(true == 3)
        {
                float val_3 = this.与丈丏东一丘丆丁三() * this.丁丗丟丗丐丂且不丕;
            return;
        }
        
        if(0 == 6)
        {
                float val_6 = this.一一上与丗专丗丏丌();
            val_6 = 丞且丅三三东不丄且.x * val_6;
            val_6 = val_6 * 30f;
            val_6 = ((0 != 0) ? -1f : 1f) * val_6;
            val_6 = val_6 / ((万业丒丞丅一丂丈业 != true) ? 1280f : ((float)UnityEngine.Screen.width));
            val_6 = S4 + val_6;
            mem[1152921539920466228] = val_6;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  0f, y:  丞且丅三三东不丄且.y);
            float val_17 = this.丁丗丟丗丐丂且不丕;
            val_17 = this.一一上与丗专丗丏丌() * val_17;
            return;
        }
        
        if(this.东丛丆丕丟东丐丄一() == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_14 = this.东丛丆丕丟东丐丄一().transform.rotation;
        UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_14.y, y:  丞且丅三三东不丄且.y);
        float val_18 = this.丁丗丟丗丐丂且不丕;
        val_18 = this.与丈丏东一丘丆丁三() * val_18;
    }
    internal override void 丝丏一丆丐丄丙七一(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不)
    {
        float val_1;
        var val_2;
        this.丝丏一丆丐丄丙七一(七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.丆专业七三丂丑丘丄 = true;
        if(true == 7)
        {
                val_1 = 7.6f;
        }
        else
        {
                val_2 = null;
            val_2 = null;
            val_1 = FirstPersonControlSharp.且丝不世丞世丅丌丗;
        }
        
        mem[1152921539920590504] = val_1;
        mem[1152921539920590516] = 0f;
        mem[1152921539920590520] = 1097859072;
        this.mouseYSmooth = 15f;
    }
    internal override void 丒丙且丌丆丙丞万丙(UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
    {
        mem[1152921539920702520] = 1109393408;
        mem[1152921539920702516] = 丙丆与丅丈丑一且丏.y;
    }
    internal override void 丞与三丞丗且丟下七(UnityEngine.Transform 不丌丕不七丗丞万万, UnityEngine.Transform 丗丈丑丅丑丕丘丂丐)
    {
        this.丞与三丞丗且丟下七(不丌丕不七丗丞万万:  不丌丕不七丗丞万万, 丗丈丑丅丑丕丘丂丐:  丗丈丑丅丑丕丘丂丐);
        this.cameraVisualPivot = 丗丈丑丅丑丕丘丂丐;
    }
    internal override void 世丑丅丈丙万丌丐丝()
    {
        mem[1152921539920942888] = this.shoulderZoomCamDistance;
        this.camDistanceSpeed = this.shoulderZoomCamSpeed;
        this.世丑丅丈丙万丌丐丝();
    }
    internal override void 专业丗丟丆丅丟丗专()
    {
        mem[1152921539921054888] = 1077936128;
        this.camDistanceSpeed = this.shoulderZoomCamSpeed;
        this.专业丗丟丆丅丟丗专();
    }
    internal override void 丒一丅下丐丆丛丆丁()
    {
        mem[1152921539921166888] = 1036831949;
        this.camDistanceSpeed = 0f;
        this.丒一丅下丐丆丛丆丁();
    }
    internal override void 下丐丕丌世丕丅丞不()
    {
        mem[1152921539921278888] = 1093664768;
        this.offsetLook = 0;
        mem[1152921539921279264] = 0;
        this.下丐丕丌世丕丅丞不();
    }
    internal override void 丙丛且丙丅丂丁丆三()
    {
        mem[1152921539921390888] = 1084227584;
        this.distanceMin = 0.1f;
        this.mouseYMin = -89f;
        this.camDistanceSpeed = 0.4f;
        this.丙丛且丙丅丂丁丆三();
    }
    internal override void 不丈丐不丙丅丁丐下()
    {
        var val_1;
        mem[1152921539921502888] = 1109393408;
        this.distanceMin = 40f;
        this.mouseYMax = 89f;
        mem[1152921539921502904] = 1113325568;
        this.mouseYMin = -89f;
        val_1 = null;
        val_1 = null;
        mem[1152921539921502900] = ThirdPersonCamera.startMouseXForShattle;
        this.不丈丐不丙丅丁丐下();
    }
    internal override void 万丌丑万世专丐与丕()
    {
        float val_3;
        this.丆专业七三丂丑丘丄 = true;
        mem[1152921539921614888] = 1089680179;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.offsetLook = val_1;
        val_3 = 40f;
        mem[1152921539921615260] = val_1.y;
        mem[1152921539921615264] = val_1.z;
        this.mouseYMin = -55f;
        this.mouseYMax = 75f;
        if(S3 > val_3)
        {
            goto label_3;
        }
        
        val_3 = -55f;
        if(S3 >= 0)
        {
            goto label_4;
        }
        
        label_3:
        mem[1152921539921614904] = val_3;
        label_4:
        this.z = 0f;
        this.丏丄丕三丆一丛丞丗(丁丌业三东不东东丙:  Player_move_c.且丒丗丑万丐丗丅三(), 丟丞一专丕三东丗一:  0f);
        this.万丌丑万世专丐与丕();
    }
    internal override void 丁丆且丑丙丛上丛万()
    {
        var val_5;
        float val_6;
        this.丆专业七三丂丑丘丄 = true;
        val_5 = null;
        val_5 = null;
        mem[1152921539921726888] = FirstPersonControlSharp.且丝不世丞世丅丌丗;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.offsetLook = val_1;
        val_6 = 40f;
        mem[1152921539921727260] = val_1.y;
        mem[1152921539921727264] = val_1.z;
        this.mouseYMin = -55f;
        this.mouseYMax = 75f;
        if(S3 > val_6)
        {
            goto label_5;
        }
        
        val_6 = -55f;
        if(S3 >= 0)
        {
            goto label_6;
        }
        
        label_5:
        mem[1152921539921726904] = val_6;
        label_6:
        this.z = 0f;
        if(106012672 == 2)
        {
                this.camDistanceSpeed = this.shoulderZoomCamSpeed;
            float val_2 = Player_move_c.且丒丗丑万丐丗丅三();
        }
        else
        {
                this.camDistanceSpeed = 0.7f;
        }
        
        this.丏丄丕三丆一丛丞丗(丁丌业三东不东东丙:  Player_move_c.且丒丗丑万丐丗丅三(), 丟丞一专丕三东丗一:  0f);
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                mem[1152921539921726888] = 1084227584;
            this.distanceMin = 0.1f;
            this.mouseYMin = -89f;
            this.camDistanceSpeed = 0.4f;
        }
        
        this.丁丆且丑丙丛上丛万();
    }
    internal override void 三丐丝丕不世丘七丛()
    {
        mem[1152921539921838888] = 1092616192;
        this.三丐丝丕不世丘七丛();
    }
    private void 丗丅丙业丌东丕丑一()
    {
        if(this.一上丝丘丌丞丐三丟 != null)
        {
                this.StopCoroutine(routine:  this.一上丝丘丌丞丐三丟);
        }
        
        this.一上丝丘丌丞丐三丟 = this.StartCoroutine(routine:  this.下业丄业丞专丁东专());
    }
    private System.Collections.IEnumerator 下业丄业丞专丁东专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ThirdPersonCamera.丂丐丞丆丗丏丒丝东();
    }
    public ThirdPersonCamera()
    {
        this.mouseYMin = -25f;
        this.mouseYMax = 89.5f;
        this.speedRotateXOnGo = 60f;
        this.shoulderZoomCamDistance = 2f;
        this.shoulderZoomCamSpeed = 7.346868E-41f;
        this.clipMoveTime = 0.1f;
        this.characterFadeThreshold = 1.8f;
        this.丄丐丆丕三七丁丆与 = 180f;
        this.丒下丏丙丁一一世丆 = true;
        this.shoulderZoomFovChangeSpeed = 1f;
        this.丁丗丟丗丐丂且不丕 = 0.4f;
        this.丈世上与且丏一丁丅 = 1f;
        this.TimeRotationCam = ;
        this.distanceMin = ;
        this.mouseSpeed = 8f;
        this.mouseScroll = 15f;
        this.mouseSmoothingFactor = ;
        this.camDistanceSpeed = ;
        this.camBottomDistance = 1f;
        this.firstPersonThreshold = 0.8f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.offsetLook = val_1;
        mem[1152921539922208028] = val_1.y;
        mem[1152921539922208032] = val_1.z;
        this.丆专业七三丂丑丘丄 = true;
    }
    private static ThirdPersonCamera()
    {
    
    }

}
