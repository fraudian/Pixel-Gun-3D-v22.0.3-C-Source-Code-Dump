using UnityEngine;
internal sealed class GestureCamera : PGBehaviour, 业丆七世丟上下丌不
{
    // Fields
    public static GestureCamera instance;
    public UnityEngine.Camera camera;
    public UnityEngine.Transform pivot;
    public DragGesture dragGesture;
    public PinchGesture pinchGesture;
    public RotateGesture rotateGesture;
    public UnityEngine.Vector3 cameraMoveStart;
    public bool limitByRadius;
    public float Radius;
    public UnityEngine.Vector3 cameraMoveRect;
    public float minZoomValue;
    public float maxZoomValue;
    private float 丛丑上丝丆丆丁且丄;
    public bool isClanWar;
    internal float minZoomForTopDownView;
    internal bool 丕丑丅丛上丄丁丏丈;
    internal bool 丏业丄丏丞丕世丑业;
    private float 丈上丄丑七七丕不万;
    private UnityEngine.GameObject 丄丁下丕丄丞丛丌丑;
    private UnityEngine.Vector3 丑丘且业七丛不一丄;
    private float 丆与丄且丐丆不专不;
    private bool 丙专丙丒丘万三丐丐;
    private float 丙万丌丌丏丅丗丌丛;
    private float 七丟专七丞不丐三世;
    private bool 丅丟丟不三丆丁世万;
    private UnityEngine.Vector3 且丌上七丅东与丁万;
    private float 丒丑万与丛专丞丄丙;
    private bool 丅丄丗上丁东专且丝;
    private UnityEngine.Quaternion 七世丙丈专下不丗丂;
    private bool 丁丙业专丄丑丄丈丛;
    private UnityEngine.Quaternion 且与与三丙丆丗与上;
    private float 丅丅三与三七与丐上;
    
    // Properties
    public UnityEngine.Transform 丒丌丞丕丐丁丛专东 { get; }
    public float 丟一七东一丕与丛丕 { get; set; }
    public static float 丞丂丘东丌且丌丛丌 { get; set; }
    public UnityEngine.Vector3 丘丂不不下丕丁下丟 { get; set; }
    
    // Methods
    public UnityEngine.Transform get_CameraTransform()
    {
        return this.transform;
    }
    public float get_ZoomValue()
    {
        return (float)this.丛丑上丝丆丆丁且丄;
    }
    public void set_ZoomValue(float 丙业与丙丗丝不丈东)
    {
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_24;
        UnityEngine.Transform val_25;
        float val_29;
        float val_30;
        float val_31;
        val_17 = 丙业与丙丗丝不丈东;
        if((System.Single.IsNaN(f:  val_17)) == true)
        {
                return;
        }
        
        if((System.Single.IsInfinity(f:  val_17)) == true)
        {
                return;
        }
        
        val_18 = this.minZoomValue;
        val_19 = val_17;
        val_20 = this.maxZoomValue;
        this.丛丑上丝丆丆丁且丄 = UnityEngine.Mathf.Clamp(value:  val_19, min:  val_18, max:  val_20);
        if(this.isClanWar != false)
        {
                float val_4 = val_17 - this.minZoomValue;
            val_4 = val_4 / (this.maxZoomValue - this.minZoomValue);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_4);
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_17 = val_7.x;
            val_18 = val_7.z;
            val_19 = val_17;
            val_20 = val_18;
            val_24 = val_7.w;
            this.pivot.localRotation = new UnityEngine.Quaternion() {x = val_19, y = val_7.y, z = val_20, w = val_24};
        }
        
        if((this.丕丑丅丛上丄丁丏丈 != false) && (this.isClanWar != true))
        {
                if(GestureCamera.ZoomValue01 > this.minZoomForTopDownView)
        {
                val_25 = this.pivot;
            float val_18 = this.minZoomForTopDownView;
            float val_17 = GestureCamera.ZoomValue01;
            val_17 = 1f - val_17;
            val_18 = 1f - val_18;
            UnityEngine.Quaternion val_10 = val_25.localRotation;
            val_17 = val_17 / val_18;
            UnityEngine.Quaternion val_11 = this.pivot.localRotation;
            val_24 = 0f;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_24, y = 0f, z = 0f}, t:  val_17);
            val_29 = val_12.x;
            val_30 = val_12.y;
            val_31 = val_12.z;
        }
        else
        {
                val_25 = this.pivot;
            UnityEngine.Quaternion val_14 = val_25.transform.localRotation;
            val_29 = 0f;
            val_30 = 0f;
            val_31 = 0f;
        }
        
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_31});
            val_17 = val_15.x;
            val_18 = val_15.z;
            val_25.localRotation = new UnityEngine.Quaternion() {x = val_17, y = val_15.y, z = val_18, w = val_15.w};
        }
        
        this.camera.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static float get_ZoomValue01()
    {
        GestureCamera val_3;
        float val_4;
        val_3 = GestureCamera.instance;
        if(val_3 == 0)
        {
                return (float)val_3;
        }
        
        val_3 = GestureCamera.instance;
        if(val_3 == null)
        {
            goto label_4;
        }
        
        val_4 = mem[GestureCamera.instance + 152];
        val_4 = GestureCamera.instance.丛丑上丝丆丆丁且丄;
        goto label_5;
        label_4:
        val_4 = mem[GestureCamera.instance + 152];
        val_4 = GestureCamera.instance.丛丑上丝丆丆丁且丄;
        if(GestureCamera.instance == null)
        {
            goto label_6;
        }
        
        val_3 = GestureCamera.instance;
        label_5:
        label_7:
        label_8:
        float val_3 = GestureCamera.instance.maxZoomValue;
        val_3 = val_3 - GestureCamera.instance.minZoomValue;
        val_3 = (val_4 - GestureCamera.instance.minZoomValue) / val_3;
        return (float)val_3;
        label_6:
        if(GestureCamera.instance != null)
        {
            goto label_7;
        }
        
        if(GestureCamera.instance != null)
        {
            goto label_8;
        }
    
    }
    public static void set_ZoomValue01(float 丙业与丙丗丝不丈东)
    {
        if(GestureCamera.instance != null)
        {
            goto label_1;
        }
        
        GestureCamera.instance = GestureCamera.instance;
        if(GestureCamera.instance == null)
        {
            goto label_2;
        }
        
        label_1:
        GestureCamera.instance.ZoomValue = UnityEngine.Mathf.Lerp(a:  GestureCamera.instance.minZoomValue, b:  GestureCamera.instance.maxZoomValue, t:  丙业与丙丗丝不丈东);
        return;
        label_2:
    }
    public UnityEngine.Vector3 get_Position()
    {
        UnityEngine.Transform val_1 = this.丌丟丄业且三丛丕丄();
        if(val_1 != null)
        {
                return val_1.position;
        }
        
        return val_1.position;
    }
    public void set_Position(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        UnityEngine.Vector3 val_2 = this.丌丒丟且丐丘丌一世(且丌上七丅东与丁万:  new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z});
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    private void Awake()
    {
        GestureCamera.instance = this;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = this.camera.transform.localPosition;
        this.丛丑上丝丆丆丁且丄 = val_2.y;
        this.dragGesture.add_onStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GestureCamera::丐丟业丑丈丈丄丏且()));
        this.dragGesture.add_onEnd(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GestureCamera::丝丑丂丒丟下丆万不()));
        this.pinchGesture.add_onStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GestureCamera::丑丛上丈丞丆丈一丑()));
    }
    private void OnDisable()
    {
        this.dragGesture.remove_onStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GestureCamera::丐丟业丑丈丈丄丏且()));
        this.dragGesture.remove_onEnd(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GestureCamera::丝丑丂丒丟下丆万不()));
        this.pinchGesture.remove_onStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GestureCamera::丑丛上丈丞丆丈一丑()));
    }
    internal UnityEngine.Vector3 七丅丗丘万丈丄万丙(UnityEngine.Vector2 专世丐丆丗丙万七下, bool 丁万世丞丙丟丏专丆 = False)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专世丐丆丗丙万七下.x, y = 专世丐丆丗丙万七下.y});
        UnityEngine.Ray val_2 = this.camera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_7 = this.camera.transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_10 = this.pivot.transform.position;
        bool val_11 = 丌且丄七上业七丒且.世与丅东与业一上丄(三万丐丄丁三丟丕与: out  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 丙丞下丒丌丘七东丆:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 万丆丙世丌丞万与丗:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 与一世丌丝丙专丐丁:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.z, z = val_10.x}, 丘丄丅丒丂业丞丘与:  new UnityEngine.Vector3() {x = val_10.z, z = val_7.x});
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    private void 丐丟业丑丈丈丄丏且()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丑丘且业七丛不一丄 = val_1;
        mem[1152921536907846124] = val_1.y;
        mem[1152921536907846128] = val_1.z;
    }
    private void 丝丑丂丒丟下丆万不()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丑丘且业七丛不一丄 = val_1;
        mem[1152921536907958124] = val_1.y;
        mem[1152921536907958128] = val_1.z;
    }
    private void 丑丛上丈丞丆丈一丑()
    {
        this.丆与丄且丐丆不专不 = this.丛丑上丝丆丆丁且丄;
    }
    private void 丞世丂丆且与丅三丝()
    {
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        if(this.丅丟丟不三丆丁世万 != false)
        {
                UnityEngine.Vector3 val_1 = this.Position;
            val_20 = UnityEngine.Time.deltaTime;
            val_21 = val_1.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_21}, b:  new UnityEngine.Vector3() {x = this.且丌上七丅东与丁万, y = V11.16B, z = V12.16B}, t:  this.丒丑万与丛专丞丄丙 * val_20);
            val_22 = val_4.x;
            val_23 = val_4.z;
            float val_5 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.且丌上七丅东与丁万, y = V11.16B, z = V12.16B});
            val_24 = 0.1f;
            if(val_5 < 0)
        {
                this.丅丟丟不三丆丁世万 = false;
            this.Position = new UnityEngine.Vector3() {x = this.且丌上七丅东与丁万, y = val_24, z = val_4.z};
        }
        
            val_25 = this.丈上丄丑七七丕不万;
            if(val_5 < 0)
        {
                val_25 = val_22;
            val_24 = val_4.y;
            val_21 = val_23;
            this.Position = new UnityEngine.Vector3() {x = val_25, y = val_24, z = val_21};
            this.丈上丄丑七七丕不万 = val_5;
        }
        else
        {
                this.丅丟丟不三丆丁世万 = false;
        }
        
        }
        
        if(this.dragGesture.Occurring == false)
        {
                return;
        }
        
        if(this.丏业丄丏丞丕世丑业 == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_7 = this.dragGesture.Position;
        UnityEngine.Vector3 val_8 = this.七丅丗丘万丈丄万丙(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, 丁万世丞丙丟丏专丆:  false);
        val_22 = val_8.x;
        val_23 = val_8.z;
        UnityEngine.Vector2 val_9 = this.dragGesture.Delta;
        val_19 = val_9.y;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        val_26 = val_10.x;
        val_27 = val_9.x;
        val_28 = val_19;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_27, y = val_28}, rhs:  new UnityEngine.Vector2() {x = val_26, y = val_10.y})) != false)
        {
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_27 = this.丑丘且业七丛不一丄;
            val_28 = val_9.x;
            val_26 = val_19;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_26}, rhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) != false)
        {
                UnityEngine.Vector3 val_14 = this.Position;
            val_19 = val_14.y;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丑丘且业七丛不一丄, y = this.丒丑万与丛专丞丄丙, z = val_20}, b:  new UnityEngine.Vector3() {x = val_22, y = val_8.y, z = val_23});
            val_27 = val_14.x;
            val_28 = val_19;
            val_26 = val_14.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_26}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this.Position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        
        }
        
        UnityEngine.Vector2 val_17 = this.dragGesture.Position;
        UnityEngine.Vector3 val_18 = this.七丅丗丘万丈丄万丙(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, 丁万世丞丙丟丏专丆:  false);
        this.丑丘且业七丛不一丄 = val_18;
        mem[1152921536908198508] = val_18.y;
        mem[1152921536908198512] = val_18.z;
    }
    private void 万丒丄丐下与丙丗与()
    {
        if(this.丙专丙丒丘万三丐丐 != false)
        {
                GestureCamera.ZoomValue01 = UnityEngine.Mathf.Lerp(a:  GestureCamera.ZoomValue01, b:  this.丙万丌丌丏丅丗丌丛, t:  UnityEngine.Time.deltaTime * this.七丟专七丞不丐三世);
            if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  GestureCamera.ZoomValue01, 丒丈丙丐丏丕丆万丗:  this.丙万丌丌丏丅丗丌丛, 丌丕丗七丒丛万丒东:  0.01f)) == false)
        {
                return;
        }
        
            this.丙专丙丒丘万三丐丐 = false;
            return;
        }
        
        if(this.pinchGesture.Occurring == false)
        {
                return;
        }
        
        if(this.丏业丄丏丞丕世丑业 == false)
        {
                return;
        }
        
        float val_8 = this.pinchGesture.PinchFactor;
        val_8 = this.丆与丄且丐丆不专不 * val_8;
        this.ZoomValue = val_8;
    }
    private void 丂东丌上一丞万丁丏()
    {
        RotateGesture val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        val_15 = this;
        if(this.丅丄丗上丁东专且丝 != false)
        {
                UnityEngine.Quaternion val_2 = this.transform.rotation;
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.丅丅三与三七与丐上 * val_3;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, b:  new UnityEngine.Quaternion() {x = this.七世丙丈专下不丗丂, y = V12.16B, z = V13.16B, w = V14.16B}, t:  val_3);
            this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            UnityEngine.Quaternion val_7 = this.丌丟丄业且三丛丕丄().rotation;
            val_17 = val_7.x;
            val_18 = val_7.z;
            val_19 = val_7.y;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_17, y = val_7.y, z = val_18}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_19, z = val_7.z})) >= 0)
        {
                return;
        }
        
            this.丅丄丗上丁东专且丝 = false;
            return;
        }
        
        if(this.rotateGesture.Occurring == false)
        {
                return;
        }
        
        if(this.丏业丄丏丞丕世丑业 == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_11 = this.rotateGesture.RotateAround;
        UnityEngine.Vector3 val_12 = this.七丅丗丘万丈丄万丙(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, 丁万世丞丙丟丏专丆:  false);
        val_17 = val_12.x;
        val_18 = val_12.z;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
        val_15 = this.rotateGesture;
        val_19 = val_13.y;
        val_16 = val_15.AngleDelta;
        this.丌丟丄业且三丛丕丄().RotateAround(point:  new UnityEngine.Vector3() {x = val_17, y = val_12.y, z = val_18}, axis:  new UnityEngine.Vector3() {x = val_13.x, y = val_19, z = val_13.z}, angle:  val_16);
    }
    private void 东万且世不三不丈丆()
    {
        if(this.丁丙业专丄丑丄丈丛 == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_1 = this.pivot.localRotation;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丅丅三与三七与丐上 * val_2;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, b:  new UnityEngine.Quaternion() {x = this.且与与三丙丆丗与上, y = V12.16B, z = V13.16B, w = V14.16B}, t:  val_2);
        this.pivot.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        UnityEngine.Quaternion val_4 = this.pivot.localRotation;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) >= 0)
        {
                return;
        }
        
        this.丁丙业专丄丑丄丈丛 = false;
    }
    public void SmoothZoom(float 上世东专丅丙一世与, float 丟丞一专丕三东丗一)
    {
        this.丙专丙丒丘万三丐丐 = true;
        this.丙万丌丌丏丅丗丌丛 = UnityEngine.Mathf.Clamp(value:  上世东专丅丙一世与, min:  0f, max:  1f);
        this.七丟专七丞不丐三世 = UnityEngine.Mathf.Max(a:  0.1f, b:  丟丞一专丕三东丗一);
    }
    public void SmoothMove(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 东丗上东丘丄东丘世)
    {
        this.丈上丄丑七七丕不万 = -1.175494E-38f;
        this.丅丟丟不三丆丁世万 = true;
        UnityEngine.Vector3 val_1 = this.丌丒丟且丐丘丌一世(且丌上七丅东与丁万:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        this.且丌上七丅东与丁万 = val_1;
        mem[1152921536908873228] = val_1.y;
        mem[1152921536908873232] = val_1.z;
        this.丒丑万与丛专丞丄丙 = 东丗上东丘丄东丘世;
    }
    public void SmoothRotate(UnityEngine.Vector3 丟世丁世丏丅业下七, float 丅丅三与三七与丐上)
    {
        this.SmoothRotateX(丟世丁世丏丅业下七:  new UnityEngine.Vector3() {x = 丟世丁世丏丅业下七.x, y = 丟世丁世丏丅业下七.y, z = 丟世丁世丏丅业下七.z}, 丅丅三与三七与丐上:  丅丅三与三七与丐上);
        this.SmoothRotateY(丟世丁世丏丅业下七:  new UnityEngine.Vector3() {x = 丟世丁世丏丅业下七.x, y = 丟世丁世丏丅业下七.y, z = 丟世丁世丏丅业下七.z}, 丅丅三与三七与丐上:  丅丅三与三七与丐上);
    }
    public void SmoothRotateY(UnityEngine.Vector3 丟世丁世丏丅业下七, float 丅丅三与三七与丐上)
    {
        this.丅丅三与三七与丐上 = 丅丅三与三七与丐上;
        this.丅丄丗上丁东专且丝 = true;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.七世丙丈专下不丗丂 = val_1;
        mem[1152921536909097248] = val_1.y;
        mem[1152921536909097252] = val_1.z;
        mem[1152921536909097256] = val_1.w;
    }
    public void SmoothRotateX(UnityEngine.Vector3 丟世丁世丏丅业下七, float 丅丅三与三七与丐上)
    {
        this.丅丅三与三七与丐上 = 丅丅三与三七与丐上;
        this.丁丙业专丄丑丄丈丛 = true;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.且与与三丙丆丗与上 = val_1;
        mem[1152921536909209268] = val_1.y;
        mem[1152921536909209272] = val_1.z;
        mem[1152921536909209276] = val_1.w;
    }
    internal void 丌丏丈丈世丙七丅一(UnityEngine.Vector3 三丈且丌丝丛丞业不)
    {
        UnityEngine.Quaternion val_2 = this.丌丟丄业且三丛丕丄().rotation;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 三丈且丌丝丛丞业不.x, y = 三丈且丌丝丛丞业不.y, z = 三丈且丌丝丛丞业不.z});
        this.SmoothRotateY(丟世丁世丏丅业下七:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丅丅三与三七与丐上:  10f);
    }
    public void SmoothRotate(UnityEngine.Quaternion 专丕且万专三丂丗上, float 丅丅三与三七与丐上)
    {
    
    }
    private void LateUpdate()
    {
        this.万丒丄丐下与丙丗与();
        this.丞世丂丆且与丅三丝();
        this.丂东丌上一丞万丁丏();
        this.东万且世不三不丈丆();
    }
    internal UnityEngine.Vector3 丌丒丟且丐丘丌一世(UnityEngine.Vector3 且丌上七丅东与丁万)
    {
        float val_10;
        float val_11;
        float val_12;
        float val_16;
        var val_17;
        var val_18;
        float val_19;
        float val_20;
        val_10 = 且丌上七丅东与丁万.z;
        val_11 = 且丌上七丅东与丁万.y;
        val_12 = 且丌上七丅东与丁万.x;
        if(this.limitByRadius != false)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = 0f, z = val_10}, b:  new UnityEngine.Vector3() {x = this.cameraMoveStart, y = V11.16B, z = V12.16B});
            val_16 = this.Radius;
            if(val_1.x <= val_16)
        {
            goto label_7;
        }
        
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12, y = 0f, z = val_10}, d:  val_16 / val_1.x);
            val_17 = val_3.x;
            val_18 = val_3.z;
        }
        else
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.cameraMoveRect, y = V11.16B, z = V12.16B}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) == true)
        {
                return new UnityEngine.Vector3() {x = val_19, y = val_11, z = val_20};
        }
        
            val_16 = this.cameraMoveStart;
            float val_6 = val_16 - this.cameraMoveRect;
            float val_7 = this.cameraMoveRect + val_16;
            float val_8 = UnityEngine.Mathf.Clamp(value:  val_12, min:  val_6, max:  val_7);
            val_6 = val_7 - val_8;
            val_7 = val_8 + val_7;
            float val_9 = UnityEngine.Mathf.Clamp(value:  val_10, min:  val_6, max:  val_7);
        }
        
        label_7:
        val_19 = val_12;
        val_11 = val_11;
        val_20 = val_10;
        return new UnityEngine.Vector3() {x = val_19, y = val_11, z = val_20};
    }
    public GestureCamera()
    {
        this.Radius = 5f;
        this.minZoomValue = 2f;
        this.maxZoomValue = 15f;
        this.丛丑上丝丆丆丁且丄 = 10f;
        this.minZoomForTopDownView = 0.95f;
        this.丕丑丅丛上丄丁丏丈 = true;
        this.丏业丄丏丞丕世丑业 = true;
        this.cameraMoveRect = 0;
        mem[1152921536909777340] = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丑丘且业七丛不一丄 = val_1;
        mem[1152921536909777388] = val_1.y;
        mem[1152921536909777392] = val_1.z;
    }

}
