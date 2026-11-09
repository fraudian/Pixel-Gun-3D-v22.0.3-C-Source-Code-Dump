using UnityEngine;
public class RPG_Camera : PGBehaviour
{
    // Fields
    public static RPG_Camera instance;
    public UnityEngine.Transform cameraPivot;
    public float TimeRotationCam;
    public float distance;
    public float distanceMin;
    public float distanceMax;
    public float mouseSpeed;
    public float mouseScroll;
    public float mouseSmoothingFactor;
    public float camDistanceSpeed;
    public float camBottomDistance;
    public float firstPersonThreshold;
    public float characterFadeThreshold;
    private float 丄丐丆丕三七丁丆与;
    public bool isDragging;
    private UnityEngine.Vector3 东东丙世丆东丕不丗;
    public float desiredDistance;
    public float offsetMaxDistance;
    public float offsetY;
    public float lastDistance;
    public float mouseX;
    public float deltaMouseX;
    private float 业丙丒一丝下一丞丛;
    private float 丕上丒丟专丅丄七丘;
    public float mouseY;
    public float mouseYSmooth;
    private float 丕东丂丞世上丐丛丂;
    private float 丌七丅三丑丅丁丆丗;
    private float 丄上专与东世七丛专;
    private float 丂丞丙不丛下丐丆丈;
    private bool 不业丅丝丅专丞丄专;
    private bool 丗丌一一丐丞上丕丒;
    private static float 丝丝业东丕丂丌丁三;
    private static float 丒不世丞丁丘丞七万;
    private static float 丙丆丄丏丛业丌一丕;
    private static float 下丁丒一丂丐丞丕丞;
    public UnityEngine.Vector2 controlVector;
    public UnityEngine.Vector3 curTargetEulerAngles;
    private bool 丒下丏丙丁一一世丆;
    private bool 丘下丛一丞丗不丑丐;
    private UnityEngine.RaycastHit 丂七丑世丏丐丅不丌;
    public static UnityEngine.Camera cam;
    private float 丅丗丘丗丐不七丕丅;
    public UnityEngine.LayerMask collisionLayer;
    
    // Methods
    private void Awake()
    {
        RPG_Camera.instance = this;
        RPG_Camera.cam = this.GetComponent<UnityEngine.Camera>();
        this.丅丗丘丗丐不七丕丅 = RPG_Camera.cam.nearClipPlane;
    }
    private void Start()
    {
        float val_1 = UnityEngine.Mathf.Clamp(value:  this.distance, min:  this.distanceMin, max:  this.distanceMax);
        this.distance = val_1;
        this.desiredDistance = val_1;
        float val_2 = RPG_Camera.cam.fieldOfView;
        val_2 = val_2 * 0.5f;
        val_2 = val_2 * 0.01745329f;
        RPG_Camera.丝丝业东丕丂丌丁三 = val_2;
        RPG_Camera.丒不世丞丁丘丞七万 = RPG_Camera.cam.aspect;
        float val_5 = RPG_Camera.丝丝业东丕丂丌丁三;
        val_5 = RPG_Camera.cam.nearClipPlane * val_5;
        RPG_Camera.丙丆丄丏丛业丌一丕 = val_5;
        float val_6 = RPG_Camera.丒不世丞丁丘丞七万;
        val_6 = RPG_Camera.丙丆丄丏丛业丌一丕 * val_6;
        RPG_Camera.下丁丒一丂丐丞丕丞 = val_6;
        this.mouseY = 15f;
    }
    private void OnDestroy()
    {
        RPG_Camera.cam = 0;
    }
    public static void CameraSetup()
    {
        var val_14;
        var val_15;
        if(RPG_Camera.cam == 0)
        {
            goto label_3;
        }
        
        val_14 = RPG_Camera.cam.gameObject;
        if(val_14 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_3:
        UnityEngine.GameObject val_3 = null;
        val_14 = val_3;
        val_3 = new UnityEngine.GameObject(name:  "Main Camera");
        if(val_14 != null)
        {
                UnityEngine.Camera val_4 = val_3.AddComponent<UnityEngine.Camera>();
        }
        else
        {
                UnityEngine.Camera val_5 = val_3.AddComponent<UnityEngine.Camera>();
        }
        
        val_3.tag = "MainCamera";
        if(val_14 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        if((UnityEngine.Object.op_Implicit(exists:  val_3.GetComponent(type:  "RPG_Camera"))) != true)
        {
                RPG_Camera val_8 = val_3.AddComponent<RPG_Camera>();
        }
        
        UnityEngine.Component val_9 = val_3.GetComponent(type:  "RPG_Camera");
        if(val_9 != null)
        {
                val_15 = null;
        }
        
        val_15 = null;
        var val_13 = (((UnityEngine.Component.__il2cppRuntimeField_typeHierarchy + RPG_Camera.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_15) ? (val_9) : 0;
        mem2[0] = UnityEngine.GameObject.Find(name:  "cameraPivot").transform;
    }
    private void Update()
    {
        var val_4;
        float val_5;
        float val_6;
        if(this.cameraPivot == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(RotatorKillCam.丘丐三与东业丛丝丒 != true)
        {
                val_5 = this.distance;
            val_6 = 2f;
            if(val_5 < 0)
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_6 = this.丄丐丆丕三七丁丆与;
            val_2 = val_2 * val_6;
            val_5 = this.deltaMouseX + val_2;
            this.deltaMouseX = val_5;
        }
        
        }
        
        UnityEngine.Vector3 val_3 = this.cameraPivot.eulerAngles;
        this.curTargetEulerAngles = val_3;
        mem[1152921539855016904] = val_3.y;
        mem[1152921539855016908] = val_3.z;
        this.世且丘丏丑丙下丁丒();
        this.世丂丆丘上与丁丑且();
        this.丕丐与丂东与丒丏丄();
    }
    private void 世且丘丏丑丙下丁丒()
    {
        var val_27;
        float val_28;
        float val_29;
        if((double)this.distance <= 0.1)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().position;
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
        UnityEngine.Vector3 val_12 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_14 = this.cameraPivot.transform.position;
        var val_16 = ((val_12.y - val_14.y) <= 0f) ? 1 : 0;
        goto label_10;
        label_1:
        if(this.不业丅丝丅专丞丄专 == true)
        {
            goto label_11;
        }
        
        label_6:
        val_27 = 0;
        label_10:
        val_28 = -89.5f;
        this.mouseY = this.不世丟丏与世东丟东(一不丅与丟丌丏丟东:  this.mouseY, 丒丛七丄世业东丝丁:  val_28, 七丝东丛东丝且丆不:  89.5f);
        this.业丙丒一丝下一丞丛 = UnityEngine.Mathf.SmoothDamp(current:  this.业丙丒一丝下一丞丛, target:  this.mouseX, currentVelocity: ref  this.丕上丒丟专丅丄七丘, smoothTime:  this.mouseSmoothingFactor);
        float val_20 = this.丕东丂丞世上丐丛丂;
        float val_21 = UnityEngine.Mathf.SmoothDamp(current:  this.mouseYSmooth, target:  this.mouseY, currentVelocity: ref  val_20, smoothTime:  this.mouseSmoothingFactor);
        this.mouseYSmooth = val_21;
        if(val_27 != 0)
        {
                val_28 = this.mouseY;
        }
        
        this.丌七丅三丑丅丁丆丗 = val_28;
        val_29 = this.desiredDistance;
        this.mouseYSmooth = val_20.不世丟丏与世东丟东(一不丅与丟丌丏丟东:  val_21, 丒丛七丄世业东丝丁:  val_28, 七丝东丛东丝且丆不:  this.丄上专与东世七丛专);
        if(val_29 > this.distanceMax)
        {
                val_29 = this.distanceMax;
            this.desiredDistance = this.distanceMax;
        }
        
        if(val_29 < 0)
        {
                this.desiredDistance = this.distanceMin;
        }
        
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.zero;
        this.controlVector = val_23;
        mem[1152921539855157568] = val_23.y;
    }
    private void 世丂丆丘上与丁丑且()
    {
        float val_18;
        float val_20;
        float val_21;
        float val_22;
        UnityEngine.Vector3 val_23;
        this.distance = this.desiredDistance;
        UnityEngine.Vector3 val_1 = this.丘丆丛丕丟丙东丈七(丈七与丒丗丑下丘丈:  this.mouseYSmooth, 丕丒丒丝万丆丐丈丘:  this.mouseX, 丌七丒世丄上丞丞丁:  this.desiredDistance);
        this.东东丙世丆东丕不丗 = val_1;
        mem[1152921539855294072] = val_1.y;
        mem[1152921539855294076] = val_1.z;
        this.丗丌一一丐丞上丕丒 = false;
        UnityEngine.Vector3 val_2 = this.cameraPivot.position;
        float val_3 = this.丑与不丒丙丗丌丐万(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = this.东东丙世丆东丕不丗});
        val_18 = -1f;
        if(val_3 != val_18)
        {
                val_18 = this.mouseYSmooth;
            this.distance = val_3;
            UnityEngine.Vector3 val_4 = this.丘丆丛丕丟丙东丈七(丈七与丒丗丑下丘丈:  val_18, 丕丒丒丝万丆丐丈丘:  this.mouseX, 丌七丒世丄上丞丞丁:  val_3);
            this.东东丙世丆东丕不丗 = val_4;
            mem[1152921539855294072] = val_4.y;
            mem[1152921539855294076] = val_4.z;
            this.丗丌一一丐丞上丕丒 = true;
        }
        
        val_20 = this.distance - RPG_Camera.cam.nearClipPlane;
        this.distance = val_20;
        if(this.lastDistance >= 0)
        {
                if(this.丗丌一一丐丞上丕丒 == true)
        {
            goto label_5;
        }
        
        }
        
        val_21 = this.camDistanceSpeed;
        val_20 = UnityEngine.Mathf.SmoothDamp(current:  this.lastDistance, target:  val_20, currentVelocity: ref  this.丂丞丙不丛下丐丆丈, smoothTime:  val_21);
        this.distance = val_20;
        label_5:
        if(val_20 < 0)
        {
                val_20 = this.distanceMin;
            this.distance = this.distanceMin;
        }
        
        val_22 = this.mouseYSmooth;
        this.lastDistance = val_20;
        UnityEngine.Vector3 val_8 = this.丘丆丛丕丟丙东丈七(丈七与丒丗丑下丘丈:  val_22, 丕丒丒丝万丆丐丈丘:  this.mouseX, 丌七丒世丄上丞丞丁:  val_20);
        this.东东丙世丆东丕不丗 = val_8;
        mem[1152921539855294072] = val_8.y;
        mem[1152921539855294076] = val_8.z;
        if(this.distance < 0)
        {
                val_21 = val_8.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_22 = val_8.x;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_22, y = val_8.y, z = val_21}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) != false)
        {
                val_23 = this.东东丙世丆东丕不丗;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22, y = val_8.y, z = val_21}, d:  this.offsetY);
            float val_16 = this.distance;
            val_16 = 4f - val_16;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_16);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  0.25f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = val_8.y, z = val_21}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            this.东东丙世丆东丕不丗 = val_14;
            mem[1152921539855294072] = val_14.y;
            mem[1152921539855294076] = val_14.z;
            this.丘下丛一丞丗不丑丐 = true;
            return;
        }
        
        }
        
        this.丘下丛一丞丗不丑丐 = false;
        val_23 = this.丅丗丘丗丐不七丕丅;
        if(RPG_Camera.cam.nearClipPlane == val_23)
        {
                return;
        }
        
        RPG_Camera.cam.nearClipPlane = val_23;
    }
    private void 丕丐与丂东与丒丏丄()
    {
        var val_6;
        UnityEngine.Vector3 val_7;
        val_6 = this;
        val_7 = this.东东丙世丆东丕不丗;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_7, y = V9.16B, z = V10.16B};
        if(this.distance <= this.distanceMin)
        {
                return;
        }
        
        this.丌丟丄业且三丛丕丄().LookAt(target:  this.cameraPivot);
        val_6 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_4 = val_6.eulerAngles;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_7 = val_5.x;
        val_6.eulerAngles = new UnityEngine.Vector3() {x = val_7, y = val_5.y, z = val_5.z};
    }
    public void UpdateMouseX()
    {
        if(this.cameraPivot == 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_2 = this.cameraPivot.rotation;
        float val_3 = 150f;
        val_3 = this.deltaMouseX + val_3;
        val_3 = val_3 + val_2.y;
        this.mouseX = val_3;
        if(val_3 <= 360f)
        {
                return;
        }
        
        do
        {
            val_3 = val_3 + (-360f);
        }
        while(val_3 > 360f);
        
        this.mouseX = val_3;
    }
    private UnityEngine.Vector3 丘丆丛丕丟丙东丈七(float 丈七与丒丗丑下丘丈, float 丕丒丒丝万丆丐丈丘, float 丌七丒世丄上丞丞丁)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(x:  丈七与丒丗丑下丘丈, y:  丕丒丒丝万丆丐丈丘, z:  0f);
        UnityEngine.Vector3 val_2 = this.cameraPivot.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    private float 丑与不丒丙丗丌丐万(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
    {
        float val_2;
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
        float val_92;
        float val_93;
        UnityEngine.Camera val_94;
        float val_95;
        UnityEngine.RaycastHit val_96;
        float val_98;
        var val_99;
        float val_100;
        float val_101;
        float val_102;
        float val_103;
        float val_104;
        float val_105;
        float val_109;
        float val_110;
        float val_111;
        val_92 = 专丂丕丗丗东世丞下.y;
        val_93 = 丈丗与丞一上且上上.z;
        val_94 = this;
        丕丆丒丒丁丗丛丟丞 val_1 = this.GetClipPlaneAt(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = val_92, z = 专丂丕丗丗东世丞下.z});
        val_95 = val_3;
        val_96 = this.丂七丑世丏丐丅不丌;
        bool val_15 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = val_93}, end:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = val_92, z = 专丂丕丗丗东世丞下.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_Normal = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_FaceID = val_96, m_Distance = val_96, m_UV = new UnityEngine.Vector2() {x = val_96, y = val_96}, m_Collider = val_96}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if(val_15 != false)
        {
                if((val_15.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) != false)
        {
                val_94 = RPG_Camera.cam;
            val_98 = val_96.targetValue - val_94.nearClipPlane;
            return (float)val_98;
        }
        
        }
        
        UnityEngine.Vector3 val_20 = this.丌丟丄业且三丛丕丄().right;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
        val_93 = val_93;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = val_93}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        val_99 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_24 = val_99.up;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        bool val_28 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, end:  new UnityEngine.Vector3() {x = val_95, y = val_4, z = val_2}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_Normal = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_FaceID = val_96, m_Distance = val_96, m_UV = new UnityEngine.Vector2() {x = val_96, y = val_96}, m_Collider = val_96}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if((val_28 == false) || ((val_28.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) == false))
        {
            goto label_10;
        }
        
        val_100 = 丈丗与丞一上且上上.y;
        UnityEngine.Vector3 val_32 = this.丌丟丄业且三丛丕丄().right;
        val_93 = val_32.y;
        val_95 = val_32.z;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_93, z = val_95}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
        val_101 = val_96.targetValue;
        val_102 = val_26.y;
        val_103 = val_26.z;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_101, y = val_102, z = val_103}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        goto label_14;
        label_10:
        val_100 = 丈丗与丞一上且上上.y;
        UnityEngine.Vector3 val_36 = this.丌丟丄业且三丛丕丄().right;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = val_100, z = val_93}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
        val_99 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_40 = val_99.up;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
        bool val_44 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z}, end:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_Normal = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_FaceID = val_96, m_Distance = val_96, m_UV = new UnityEngine.Vector2() {x = val_96, y = val_96}, m_Collider = val_96}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if((val_44 == false) || ((val_44.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) == false))
        {
            goto label_20;
        }
        
        UnityEngine.Vector3 val_48 = this.丌丟丄业且三丛丕丄().right;
        val_93 = val_48.y;
        val_95 = val_48.z;
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_93, z = val_95}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
        val_101 = val_96.targetValue;
        val_102 = val_42.y;
        val_103 = val_42.z;
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_101, y = val_102, z = val_103}, b:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
        label_14:
        val_92 = val_50.z;
        val_94 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_52 = val_94.up;
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
        val_104 = val_53.x;
        val_105 = val_50.x;
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_105, y = val_50.y, z = val_92}, b:  new UnityEngine.Vector3() {x = val_104, y = val_53.y, z = val_53.z});
        goto label_25;
        label_20:
        UnityEngine.Vector3 val_56 = this.丌丟丄业且三丛丕丄().right;
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = val_100, z = val_93}, b:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z});
        val_99 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_60 = val_99.up;
        UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
        UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, b:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
        bool val_64 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, end:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_Normal = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_FaceID = val_96, m_Distance = val_96, m_UV = new UnityEngine.Vector2() {x = val_96, y = val_96}, m_Collider = val_96}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
        if((val_64 != false) && ((val_64.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) != false))
        {
                UnityEngine.Vector3 val_68 = this.丌丟丄业且三丛丕丄().right;
            val_93 = val_68.y;
            val_95 = val_68.z;
            UnityEngine.Vector3 val_69 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_68.x, y = val_93, z = val_95}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            val_109 = val_96.targetValue;
            val_110 = val_62.y;
            val_111 = val_62.z;
            UnityEngine.Vector3 val_70 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_109, y = val_110, z = val_111}, b:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z});
        }
        else
        {
                UnityEngine.Vector3 val_72 = this.丌丟丄业且三丛丕丄().right;
            UnityEngine.Vector3 val_73 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_74 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = val_100, z = val_93}, b:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z});
            val_99 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_76 = val_99.up;
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
            UnityEngine.Vector3 val_78 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z}, b:  new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z});
            val_92 = val_78.z;
            bool val_80 = UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_92}, end:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_Normal = new UnityEngine.Vector3() {x = val_96, y = val_96, z = val_96}, m_FaceID = val_96, m_Distance = val_96, m_UV = new UnityEngine.Vector2() {x = val_96, y = val_96}, m_Collider = val_96}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}));
            val_98 = -1f;
            if(val_80 == false)
        {
                return (float)val_98;
        }
        
            if((val_80.专丒丁万业丒且丐丕(丛丈丑东且业丈丗万:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = this.丂七丑世丏丐丅不丌.m_Point, z = this.丂七丑世丏丐丅不丌.m_Point}, m_Normal = new UnityEngine.Vector3() {x = this.丂七丑世丏丐丅不丌.m_Point, y = mem[this.丂七丑世丏丐丅不丌 + 16], z = mem[this.丂七丑世丏丐丅不丌 + 16]}, m_FaceID = mem[this.丂七丑世丏丐丅不丌 + 16], m_Distance = mem[this.丂七丑世丏丐丅不丌 + 16], m_UV = new UnityEngine.Vector2()})) == false)
        {
                return (float)val_98;
        }
        
            UnityEngine.Vector3 val_84 = this.丌丟丄业且三丛丕丄().right;
            val_93 = val_84.y;
            val_95 = val_84.z;
            UnityEngine.Vector3 val_85 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_84.x, y = val_93, z = val_95}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            val_109 = val_96.targetValue;
            val_110 = val_78.y;
            val_111 = val_92;
            UnityEngine.Vector3 val_86 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_109, y = val_110, z = val_111}, b:  new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z});
        }
        
        val_92 = val_86.z;
        val_94 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_88 = val_94.up;
        UnityEngine.Vector3 val_89 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_88.x, y = val_88.y, z = val_88.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
        val_104 = val_89.x;
        val_105 = val_86.x;
        UnityEngine.Vector3 val_90 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_105, y = val_86.y, z = val_92}, b:  new UnityEngine.Vector3() {x = val_104, y = val_89.y, z = val_89.z});
        label_25:
        val_98 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_90.x, y = val_90.y, z = val_90.z}, b:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = val_100, z = val_93});
        return (float)val_98;
    }
    private bool 专丒丁万业丒且丐丕(UnityEngine.RaycastHit 丛丈丑东且业丈丗万)
    {
        bool val_1 = 丛丈丑东且业丈丗万.m_Point.x.CompareTag(tag:  "Player");
        val_1 = (~val_1) & 1;
        return (bool)val_1;
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
    public RPG_Camera.丕丆丒丒丁丗丛丟丞 GetClipPlaneAt(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        float val_52;
        UnityEngine.Camera val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        float val_63;
        float val_64;
        float val_65;
        float val_66;
        丕丆丒丒丁丗丛丟丞 val_0;
        val_52 = 下业丕七东丌丝下且.z;
        val_54 = RPG_Camera.cam;
        val_55 = 0f;
        val_56 = 0f;
        val_57 = 0f;
        val_58 = 0f;
        val_59 = 0f;
        val_60 = 0f;
        val_61 = 0f;
        val_62 = 0f;
        val_63 = 0f;
        val_64 = 0f;
        val_65 = 0f;
        val_66 = 0f;
        if(val_54 != 0)
        {
                UnityEngine.Transform val_2 = RPG_Camera.cam.transform;
            float val_3 = RPG_Camera.cam.nearClipPlane;
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().right;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = val_52}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_13 = this.丌丟丄业且三丛丕丄().forward;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  val_3);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector3 val_17 = this.丌丟丄业且三丛丕丄().right;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = val_52}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_21 = this.丌丟丄业且三丛丕丄().up;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            UnityEngine.Vector3 val_25 = this.丌丟丄业且三丛丕丄().forward;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_3);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_59 = val_27.y;
            val_60 = val_27.z;
            UnityEngine.Vector3 val_29 = this.丌丟丄业且三丛丕丄().right;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = val_52}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            UnityEngine.Vector3 val_33 = this.丌丟丄业且三丛丕丄().up;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            UnityEngine.Vector3 val_37 = this.丌丟丄业且三丛丕丄().forward;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  val_3);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            val_61 = val_39.x;
            val_62 = val_39.y;
            val_63 = val_39.z;
            UnityEngine.Vector3 val_41 = this.丌丟丄业且三丛丕丄().right;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, d:  RPG_Camera.下丁丒一丂丐丞丕丞);
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = val_52}, b:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z});
            val_54 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_45 = val_54.up;
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  RPG_Camera.丙丆丄丏丛业丌一丕);
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, b:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z});
            val_52 = val_47.y;
            UnityEngine.Vector3 val_49 = this.丌丟丄业且三丛丕丄().forward;
            UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, d:  val_3);
            val_64 = val_47.x;
            val_65 = val_52;
            val_66 = val_47.z;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_64, y = val_65, z = val_66}, b:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
            val_56 = val_15.y;
            val_55 = val_15.x;
            val_58 = val_27.x;
            val_57 = val_15.z;
        }
        
        val_0.丐丌丟丐丐丏丒七业.x = val_55;
        val_0.丐丌丟丐丐丏丒七业.y = val_56;
        val_0.丐丌丟丐丐丏丒七业.z = val_57;
        val_0.丌丂丐丄丏上业上丂.x = val_58;
        val_0.丌丂丐丄丏上业上丂.y = val_59;
        val_0.丌丂丐丄丏上业上丂.z = val_60;
        val_0.丒世七丏一丙不丙丌.x = val_61;
        val_0.丒世七丏一丙不丙丌.y = val_62;
        val_0.丒世七丏一丙不丙丌.z = val_63;
        val_0.丌东丘丌一丐万丕且.x = val_51.x;
        val_0.丌东丘丌一丐万丕且.y = val_51.y;
        val_0.丌东丘丌一丐万丕且.z = val_51.z;
        return val_0;
    }
    public void RotateWithCharacter()
    {
        float val_2 = RPG_Controller.instance.turnSpeed;
        val_2 = (UnityEngine.Input.GetAxis(axisName:  "Horizontal")) * val_2;
        val_2 = this.mouseX + val_2;
        this.mouseX = val_2;
    }
    public RPG_Camera()
    {
        this.TimeRotationCam = ;
        this.distance = ;
        this.distanceMin = 1f;
        this.distanceMax = 30f;
        this.mouseSpeed = ;
        this.mouseScroll = ;
        this.mouseSmoothingFactor = 0.08f;
        this.camDistanceSpeed = 0.7f;
        this.丌七丅三丑丅丁丆丗 = -89.5f;
        this.丄上专与东世七丛专 = 89.5f;
        this.camBottomDistance = ;
        this.firstPersonThreshold = ;
        this.characterFadeThreshold = 1.8f;
        this.丄丐丆丕三七丁丆与 = 180f;
        this.丒下丏丙丁一一世丆 = true;
    }

}
