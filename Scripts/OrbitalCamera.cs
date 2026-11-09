using UnityEngine;
internal sealed class OrbitalCamera : PGBehaviour, 业丆七世丟上下丌不
{
    // Fields
    public static OrbitalCamera instance;
    public UnityEngine.Camera camera;
    public UnityEngine.Transform pivot;
    public DragGesture dragGesture;
    public PinchGesture pinchGesture;
    public float rotateSensitivity;
    public float minZoomValue;
    public float maxZoomValue;
    private float 丛丑上丝丆丆丁且丄;
    private float 丆与丄且丐丆不专不;
    private bool 丈丆丄下丄丆丛丙上;
    private float 丄世丈丌丝丟丈丗丁;
    private float 丄丙下丁丒丗三上世;
    private bool 丑丌丞一丛不丌不丄;
    private UnityEngine.Quaternion 专丕且万专三丂丗上;
    private float 丅丅三与三七与丐上;
    private UnityEngine.GameObject 丄丁下丕丄丞丛丌丑;
    
    // Properties
    public float 丟一七东一丕与丛丕 { get; set; }
    public static float 丞丂丘东丌且丌丛丌 { get; set; }
    public UnityEngine.Transform 丒丌丞丕丐丁丛专东 { get; }
    
    // Methods
    public float get_ZoomValue()
    {
        return (float)this.丛丑上丝丆丆丁且丄;
    }
    public void set_ZoomValue(float 丙业与丙丗丝不丈东)
    {
        if((System.Single.IsNaN(f:  丙业与丙丗丝不丈东)) == true)
        {
                return;
        }
        
        if((System.Single.IsInfinity(f:  丙业与丙丗丝不丈东)) == true)
        {
                return;
        }
        
        this.丛丑上丝丆丆丁且丄 = UnityEngine.Mathf.Clamp(value:  丙业与丙丗丝不丈东, min:  this.minZoomValue, max:  this.maxZoomValue);
        this.camera.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static float get_ZoomValue01()
    {
        OrbitalCamera val_3;
        float val_4;
        val_3 = OrbitalCamera.instance;
        if(val_3 == 0)
        {
                return (float)val_3;
        }
        
        val_3 = OrbitalCamera.instance;
        if(val_3 == null)
        {
            goto label_4;
        }
        
        val_4 = mem[OrbitalCamera.instance + 116];
        val_4 = OrbitalCamera.instance.丛丑上丝丆丆丁且丄;
        goto label_5;
        label_4:
        val_4 = mem[OrbitalCamera.instance + 116];
        val_4 = OrbitalCamera.instance.丛丑上丝丆丆丁且丄;
        if(OrbitalCamera.instance == null)
        {
            goto label_6;
        }
        
        val_3 = OrbitalCamera.instance;
        label_5:
        label_7:
        label_8:
        float val_3 = OrbitalCamera.instance.maxZoomValue;
        val_3 = val_3 - OrbitalCamera.instance.minZoomValue;
        val_3 = (val_4 - OrbitalCamera.instance.minZoomValue) / val_3;
        return (float)val_3;
        label_6:
        if(OrbitalCamera.instance != null)
        {
            goto label_7;
        }
        
        if(OrbitalCamera.instance != null)
        {
            goto label_8;
        }
    
    }
    public static void set_ZoomValue01(float 丙业与丙丗丝不丈东)
    {
        if(OrbitalCamera.instance != null)
        {
            goto label_1;
        }
        
        OrbitalCamera.instance = OrbitalCamera.instance;
        if(OrbitalCamera.instance == null)
        {
            goto label_2;
        }
        
        label_1:
        OrbitalCamera.instance.ZoomValue = UnityEngine.Mathf.Lerp(a:  OrbitalCamera.instance.minZoomValue, b:  OrbitalCamera.instance.maxZoomValue, t:  丙业与丙丗丝不丈东);
        return;
        label_2:
    }
    private void Awake()
    {
        OrbitalCamera.instance = this;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = this.camera.transform.localPosition;
        this.丛丑上丝丆丆丁且丄 = val_2.y;
        this.pinchGesture.add_onStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void OrbitalCamera::丑丛上丈丞丆丈一丑()));
    }
    private void OnDisable()
    {
        this.pinchGesture.remove_onStart(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void OrbitalCamera::丑丛上丈丞丆丈一丑()));
    }
    private void 丑丛上丈丞丆丈一丑()
    {
        this.丆与丄且丐丆不专不 = this.丛丑上丝丆丆丁且丄;
    }
    private void 万丒丄丐下与丙丗与()
    {
        if(this.丈丆丄下丄丆丛丙上 != false)
        {
                OrbitalCamera.ZoomValue01 = UnityEngine.Mathf.Lerp(a:  OrbitalCamera.ZoomValue01, b:  this.丄世丈丌丝丟丈丗丁, t:  UnityEngine.Time.deltaTime * this.丄丙下丁丒丗三上世);
            if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  OrbitalCamera.ZoomValue01, 丒丈丙丐丏丕丆万丗:  this.丄世丈丌丝丟丈丗丁, 丌丕丗七丒丛万丒东:  0.01f)) == false)
        {
                return;
        }
        
            this.丈丆丄下丄丆丛丙上 = false;
            return;
        }
        
        if(this.pinchGesture.Occurring == false)
        {
                return;
        }
        
        float val_8 = this.pinchGesture.PinchFactor;
        val_8 = this.丆与丄且丐丆不专不 * val_8;
        this.ZoomValue = val_8;
    }
    private void 丞世丂丆且与丅三丝()
    {
        var val_15;
        float val_16;
        float val_17;
        val_15 = this;
        if(this.丑丌丞一丛不丌不丄 != false)
        {
                UnityEngine.Quaternion val_2 = this.transform.rotation;
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.丅丅三与三七与丐上 * val_3;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, b:  new UnityEngine.Quaternion() {x = this.专丕且万专三丂丗上, y = V12.16B, z = V13.16B, w = V14.16B}, t:  val_3);
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            UnityEngine.Quaternion val_7 = this.transform.rotation;
            val_16 = val_7.x;
            val_17 = val_7.z;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_16, y = val_7.y, z = val_17}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) >= 0)
        {
                return;
        }
        
            this.丑丌丞一丛不丌不丄 = false;
            return;
        }
        
        if(this.dragGesture.Occurring == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_11 = this.transform.localEulerAngles;
        float val_15 = val_11.y;
        UnityEngine.Vector2 val_12 = this.dragGesture.Delta;
        val_12.x = val_12.x * this.rotateSensitivity;
        val_15 = val_15 + val_12.x;
        val_15 = this.transform;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_11.x, y = val_15, z = val_11.z});
        val_16 = val_14.x;
        val_17 = val_14.z;
        val_15.localRotation = new UnityEngine.Quaternion() {x = val_16, y = val_14.y, z = val_17, w = val_14.w};
    }
    public UnityEngine.Transform get_CameraTransform()
    {
        return this.transform;
    }
    public void SmoothZoom(float 上世东专丅丙一世与, float 丟丞一专丕三东丗一)
    {
        this.丈丆丄下丄丆丛丙上 = true;
        this.丄世丈丌丝丟丈丗丁 = UnityEngine.Mathf.Clamp(value:  上世东专丅丙一世与, min:  0f, max:  1f);
        this.丄丙下丁丒丗三上世 = UnityEngine.Mathf.Max(a:  0.1f, b:  丟丞一专丕三东丗一);
    }
    public void SmoothMove(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 东丗上东丘丄东丘世)
    {
    
    }
    public void SmoothRotate(UnityEngine.Quaternion 专丕且万专三丂丗上, float 丅丅三与三七与丐上)
    {
        this.专丕且万专三丂丗上 = 专丕且万专三丂丗上;
        mem[1152921536914263616] = 专丕且万专三丂丗上.y;
        mem[1152921536914263620] = 专丕且万专三丂丗上.z;
        mem[1152921536914263624] = 专丕且万专三丂丗上.w;
        this.丑丌丞一丛不丌不丄 = true;
        this.丅丅三与三七与丐上 = 丅丅三与三七与丐上;
    }
    public void SmoothRotate(UnityEngine.Vector3 丟世丁世丏丅业下七, float 丅丅三与三七与丐上)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 丟世丁世丏丅业下七.x, y = 丟世丁世丏丅业下七.y, z = 丟世丁世丏丅业下七.z});
        this.专丕且万专三丂丗上 = val_1;
        mem[1152921536914375616] = val_1.y;
        mem[1152921536914375620] = val_1.z;
        mem[1152921536914375624] = val_1.w;
        this.丑丌丞一丛不丌不丄 = true;
        this.丅丅三与三七与丐上 = 丅丅三与三七与丐上;
    }
    public void SmoothRotateY(UnityEngine.Vector3 丟世丁世丏丅业下七, float 丅丅三与三七与丐上)
    {
    
    }
    public void SmoothRotateX(UnityEngine.Vector3 丟世丁世丏丅业下七, float 丅丅三与三七与丐上)
    {
    
    }
    private void LateUpdate()
    {
        if(this.pinchGesture.Occurring != false)
        {
                this.万丒丄丐下与丙丗与();
            return;
        }
        
        this.丞世丂丆且与丅三丝();
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
    public OrbitalCamera()
    {
        this.rotateSensitivity = ;
        this.minZoomValue = ;
        this.maxZoomValue = 15f;
        this.丛丑上丝丆丆丁且丄 = 10f;
    }

}
