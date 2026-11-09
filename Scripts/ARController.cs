using UnityEngine;
public class ARController : MonoBehaviour
{
    // Fields
    private static System.Action 丗丟丟业丑世丁下一;
    public UnityEngine.Transform quadForVideo;
    public UnityEngine.GameObject container;
    public UnityEngine.Transform arCamera;
    public UnityEngine.Transform planePrefab;
    public UnityEngine.GameObject placeButton;
    public UnityEngine.GameObject shootButton;
    public UILabel label;
    public UILabel[] header;
    private ShopShootingController 七丛丅不丗丈丏下不;
    private System.Collections.Generic.List<UnityEngine.Camera> 丟丌丞万丕万丐丐上;
    private const string 丑丑丘丑业上不丏与 = "Key_7564";
    private const string 丂丑下丙世丌丕丝不 = "Key_7565";
    private UnityEngine.WaitForSecondsRealtime 世七丙丐丌丏丄世世;
    private float 七丝丕东不东丝丆丝;
    private UnityEngine.Transform 丛丄上世丒丝丂丗丑;
    private 三丅丁丗丗丝丂万且 与下丝丐丁丂三且下;
    private UnityEngine.Transform 丁丆丒一一丒丗丙丛;
    private UnityEngine.Transform 丏丘丒丛不七一与专;
    private UnityEngine.Color 丑丕世丟丟丝丅丗丁;
    private static ARController 世丒丞七专三与万丕;
    private UnityEngine.XR.iOS.丐七丆七丑丞丄丘上 丝不丙丄丒三丟东与;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private int 丌世丁丄丄丗万丈不;
    
    // Properties
    public static bool 与三丄不丈丌丛万丙 { get; }
    public UnityEngine.XR.iOS.丐七丆七丑丞丄丘上 丈丕丁丛万丟一丌丝 { get; }
    public static ARController 丆丕丝丒不丙且丐丗 { get; }
    internal ShopShootingController 丂且丟业丁上丐丑下 { get; }
    public bool 不丁丄丌丒上丅丂丟 { get; }
    
    // Methods
    public static void add_Closed(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ARController.丂丑下丙世丌丕丝不, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    public static void remove_Closed(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ARController.丂丑下丙世丌丕丝不, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    public static bool get_IsSupported()
    {
        var val_3;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                if(UnityEngine.Application.isEditor == false)
        {
                return UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.上与丗丌丏不一丏不();
        }
        
            val_3 = 1;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public void HandlePlaceClicked()
    {
        object val_37;
        string val_38;
        var val_39;
        val_37 = this;
        if(UnityEngine.Application.isEditor != false)
        {
                val_38 = 1;
        }
        else
        {
                val_38 = UnityEngine.Object.op_Inequality(x:  this.丁丆丒一一丒丗丙丛, y:  0);
        }
        
        if(val_38 == false)
        {
                return;
        }
        
        if(this.丛丄上世丒丝丂丗丑 != 0)
        {
                return;
        }
        
        this.StopCoroutine(methodName:  "HitTestCoroutine");
        UnityEngine.GameObject val_5 = WeaponManager.丄丟上一上丐丄与丆(三不三丟专丘东东丂:  this.与下丝丐丁丂三且下.与不丞丑七丘丁丂丛());
        UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_5).GetComponent<UnityEngine.Transform>();
        this.丛丄上世丒丝丂丗丑 = val_7;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_7.gameObject, 不东丛三丂丌丑专丆:  this.arCamera.gameObject.layer);
        WeaponSounds val_11 = this.丛丄上世丒丝丂丗丑.GetComponent<WeaponSounds>();
        if(((val_11 != 0) && (val_11.IsWeaponInsideHands != true)) && (val_11._innerPars != 0))
        {
                val_39 = null;
            val_39 = null;
            if((System.String.op_Inequality(a:  val_5.name, b:  WeaponManager.业丝丛丂三丄丁与丁)) != false)
        {
                val_11._innerPars.FindArms();
            InnerWeaponPars val_19 = val_11._innerPars;
            if(val_19.renderArms != 0)
        {
                InnerWeaponPars val_21 = val_11._innerPars;
            val_21.renderArms.enabled = false;
        }
        
        }
        
        }
        
        this.丛丄上世丒丝丂丗丑.parent = this.arCamera.parent;
        UnityEngine.Vector3 val_23 = this.arCamera.forward;
        UnityEngine.Vector3 val_24 = this.arCamera.position;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = 0f, z = val_23.z}, d:  1f);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        this.丛丄上世丒丝丂丗丑.forward = new UnityEngine.Vector3() {x = val_23.x, y = 0f, z = val_23.z};
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
        this.丛丄上世丒丝丂丗丑.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.丛丄上世丒丝丂丗丑.position = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
        ShopShootingController val_29 = this.丝丌丅丘丝三三丌丄();
        val_29.CurrentWeaponObjectGetter = new System.Func<UnityEngine.GameObject>(object:  this, method:  UnityEngine.GameObject ARController::与丄万丁下丑丗丆丙());
        this.上丌与丒丟业丘世丐();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.placeButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButton, 丏业丟一东丂东丘丛:  true);
        val_38 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7564");
        this.label.text = val_38;
        val_37 = this.丝丌丅丘丝三三丌丄().丕丌七丂丈丌丄万万();
        UnityEngine.Vector3 val_34 = this.丛丄上世丒丝丂丗丑.position;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_37.position = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
    }
    public void HandleBackClicked()
    {
        var val_3;
        this.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 三丐三丞丘丕不丒专:  0);
        val_3 = null;
        val_3 = null;
        if((ARController.<>c.<>9__14_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        val_1.CurrentWeaponObjectGetter = ARController.<>c.<>9__14_0;
        return;
        label_3:
        ARController.<>c.<>9__14_0 = new System.Func<UnityEngine.GameObject>(object:  ARController.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject ARController.<>c::一丑丘丟上丐丅丗丅());
        if(this.丝丌丅丘丝三三丌丄() != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    public UnityEngine.XR.iOS.丐七丆七丑丞丄丘上 get_NativeSession()
    {
        return (UnityEngine.XR.iOS.丐七丆七丑丞丄丘上)this.丝不丙丄丒三丟东与;
    }
    public static ARController get_Instance()
    {
        return (ARController)ARController.世丒丞七专三与万丕;
    }
    internal ShopShootingController 丝丌丅丘丝三三丌丄()
    {
        ShopShootingController val_3;
        if(this.七丛丅不丗丈丏下不 == 0)
        {
                this.七丛丅不丗丈丏下不 = this.GetComponent<ShopShootingController>();
            return val_3;
        }
        
        val_3 = this.七丛丅不丗丈丏下不;
        return val_3;
    }
    public bool get_InterfaceEnabled()
    {
        if(this.container != null)
        {
                return this.container.activeSelf;
        }
        
        return this.container.activeSelf;
    }
    internal void 世丗七丙丙业下丆与(bool 丝三丄专丗丞丄丄丌, 三丅丁丗丗丝丂万且 三丐三丞丘丕不丒专)
    {
        bool val_15;
        object val_16;
        var val_17;
        val_15 = 丝三丄专丗丞丄丄丌;
        val_16 = this;
        val_17 = 1152921505284374528;
        丝三丄专丗丞丄丄丌 = val_15;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.container, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌);
        if(val_15 == false)
        {
            goto label_3;
        }
        
        float val_15 = (float)UnityEngine.Screen.width;
        float val_16 = (float)UnityEngine.Screen.height;
        val_15 = val_15 / val_16;
        val_15 = ((东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != true) ? 813f : 768f) * val_15;
        val_16 = val_15 * 3f;
        val_16 = val_16 * 0.25f;
        this.quadForVideo.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.与下丝丐丁丂三且下 = 三丐三丞丘丕不丒专;
        this.丒与丛不丏丈丏丐七();
        this.丝不丙丄丒三丟东与.丟业丅上丗万东与丌(上世丏丁世丟世丆业:  new UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕() {上丆丑丞丄上丘丗下 = false, 七丝专丆丐丗世下一 = false});
        UnityEngine.Coroutine val_5 = this.StartCoroutine(methodName:  "HitTestCoroutine");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.placeButton, 丏业丟一东丂东丘丛:  UnityEngine.Application.isEditor);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButton, 丏业丟一东丂东丘丛:  false);
        this.东三世丙丁丒丝世丕();
        System.Action val_9 = null;
        val_15 = val_9;
        val_9 = new System.Action(object:  this, method:  public System.Void ARController::HandleBackClicked());
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_9, 与且专丈不万东一万:  "AR");
        val_17 = 0;
        goto label_13;
        label_22:
        val_15 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.与下丝丐丁丂三且下.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  this.与下丝丐丁丂三且下.丒万丕七专不丏丞丌());
        this.header[0].text = val_15;
        val_17 = 1;
        label_13:
        if(val_17 < this.header.Length)
        {
            goto label_22;
        }
        
        val_16 = this.label;
        val_16.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7565");
        return;
        label_3:
        this.丝不丙丄丒三丟东与.世上专丐丂业世世丂();
        this.丒与丛不丏丈丏丐七();
        this.StopCoroutine(methodName:  "HitTestCoroutine");
        if(ARController.丂丑下丙世丌丕丝不 != null)
        {
                ARController.丂丑下丙世丌丕丝不.Invoke();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.placeButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButton, 丏业丟一东丂东丘丛:  false);
        this.东三世丙丁丒丝世丕();
    }
    private void 丒与丛不丏丈丏丐七()
    {
        if(this.丛丄上世丒丝丂丗丑 == 0)
        {
                return;
        }
        
        this.丛丄上世丒丝丂丗丑.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.丛丄上世丒丝丂丗丑.gameObject);
        this.丛丄上世丒丝丂丗丑 = 0;
    }
    private void Awake()
    {
        ARController.世丒丞七专三与万丕 = this;
        this.世七丙丐丌丏丄世世 = new UnityEngine.WaitForSecondsRealtime(time:  0.333f);
        UnityEngine.Color val_2 = UnityEngine.Color.gray;
        this.丑丕世丟丟丝丅丗丁 = val_2;
        mem[1152921524439277916] = val_2.g;
        mem[1152921524439277920] = val_2.b;
        mem[1152921524439277924] = val_2.a;
        UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丆万丗丞下丅世丒丐(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.丙丂世丝三丒东丙丝(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ARController::七与东丗丙与世丛丗(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 与业丞东丙丕且丏丈)));
        this.丝不丙丄丒三丟东与 = UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丕丕下丐丟丏三万丄();
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ARController::丙与东丏丕丞丕丐东(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.LoadSceneMode 丛丆东与丑丞丅丝专)));
    }
    private void OnDestroy()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ARController::丙与东丏丕丞丕丐东(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.LoadSceneMode 丛丆东与丑丞丅丝专)));
        UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丟丑下且丐丂丘丞七(丙业与丙丗丝不丈东:  new 丐七丆七丑丞丄丘上.丙丂世丝三丒东丙丝(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ARController::七与东丗丙与世丛丗(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 与业丞东丙丕且丏丈)));
    }
    private void 七与东丗丙与世丛丗(UnityEngine.XR.iOS.丂与与丞丈三专丈丅 与业丞东丙丕且丏丈)
    {
        var val_15;
        string val_16;
        string val_17;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[1];
            val_15 = 1152921524439644864;
            val_2[0] = -1642034240;
            UnityEngine.Debug.LogErrorFormat(format:  "TRACK STATE: {0}", args:  val_2);
        }
        else
        {
                val_15 = 1152921524439644992;
        }
        
        if((-1642034240) == 1)
        {
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_4 = new object[1];
            val_4[0] = 268435460;
            UnityEngine.Debug.LogErrorFormat(format:  "TRACK REASON {0}", args:  val_4);
        }
        
        }
        
        val_16 = "Key_7565";
        if(this.丛丄上世丒丝丂丗丑 == 0)
        {
            goto label_23;
        }
        
        val_16 = "Key_7564";
        goto label_24;
        label_23:
        if(val_15 == 2)
        {
            goto label_25;
        }
        
        if(val_15 == 1)
        {
            goto label_26;
        }
        
        if(val_15 != 0)
        {
            goto label_27;
        }
        
        val_16 = "Key_7565";
        UnityEngine.Color val_6 = UnityEngine.Color.gray;
        goto label_34;
        label_25:
        val_16 = "";
        UnityEngine.Color val_7 = UnityEngine.Color.green;
        goto label_34;
        label_26:
        val_16 = "Key_7565";
        if(268435460 > 3)
        {
            goto label_30;
        }
        
        var val_15 = mem[1179763564];
        val_15 = val_15 + 106021724;
        goto (mem[1179763564] + 106021724);
        label_27:
        UnityEngine.Color val_9 = UnityEngine.Color.white;
        goto label_34;
        label_30:
        UnityEngine.Color val_10 = UnityEngine.Color.blue;
        label_34:
        this.丑丕世丟丟丝丅丗丁 = val_12;
        mem[1152921524439613020] = val_12.g;
        mem[1152921524439613024] = val_12.b;
        mem[1152921524439613028] = val_12.a;
        label_24:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) == false)
        {
            goto label_37;
        }
        
        val_17 = "";
        if(this.label != null)
        {
            goto label_42;
        }
        
        goto label_39;
        label_37:
        val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_16);
        if(this.label != null)
        {
            goto label_42;
        }
        
        label_39:
        label_42:
        this.label.text = val_17;
    }
    private System.Collections.IEnumerator HitTestCoroutine()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ARController.丕丟丅丁东丆丑万丂();
    }
    private void 上丌与丒丟业丘世丐()
    {
        if(this.丁丆丒一一丒丗丙丛 != 0)
        {
                UnityEngine.Object val_6 = 0;
            val_6 = UnityEngine.Object.op_Equality(x:  this.丛丄上世丒丝丂丗丑, y:  val_6);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丁丆丒一一丒丗丙丛.gameObject, 丏业丟一东丂东丘丛:  val_6);
        }
        
        UnityEngine.Object val_7 = 0;
        val_7 = UnityEngine.Object.op_Equality(x:  this.丛丄上世丒丝丂丗丑, y:  val_7);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.placeButton, 丏业丟一东丂东丘丛:  val_7);
        UnityEngine.Object val_8 = 0;
        val_8 = UnityEngine.Object.op_Inequality(x:  this.丛丄上世丒丝丂丗丑, y:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.shootButton, 丏业丟一东丂东丘丛:  val_8);
    }
    private void 东丗下丂上七丞丗七()
    {
        if(this.丁丆丒一一丒丗丙丛 == 0)
        {
                return;
        }
        
        if(this.丁丆丒一一丒丗丙丛.gameObject.activeSelf == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.arCamera.position;
        UnityEngine.Vector3 val_5 = this.arCamera.forward;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  this.七丝丕东不东丝丆丝, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.丁丆丒一一丒丗丙丛.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        this = this.丁丆丒一一丒丗丙丛;
        UnityEngine.Quaternion val_8 = this.arCamera.rotation;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
    }
    private void Update()
    {
        this.东丗下丂上七丞丗七();
    }
    private void 东三世丙丁丒丝世丕()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void 丝丝不丛且三丏丁丗(bool 丗丛不丁丑专专丂且)
    {
        bool val_3;
        var val_54;
        System.Collections.Generic.IEnumerable<T> val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        System.Collections.Generic.IEnumerable<T> val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        UnityEngine.Object val_67;
        var val_68;
        var val_69;
        bool val_70;
        val_54 = this;
        if(丗丛不丁丑专专丂且 == false)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = this.丟丌丞万丕万丐丐上.GetEnumerator();
        val_56 = 1152921524440491584;
        val_57 = 1152921504848912384;
        label_13:
        if(((-1640922064) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_13;
        }
        
        val_4.enabled = true;
        UICamera val_6 = val_4.GetComponent<UICamera>();
        if(val_6 == 0)
        {
            goto label_13;
        }
        
        val_6.enabled = true;
        goto label_13;
        label_1:
        if(UnityEngine.Camera.allCameras != null)
        {
                val_58 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  UnityEngine.Camera.allCameras);
        }
        else
        {
                System.Collections.Generic.List<UnityEngine.Camera> val_11 = null;
            val_58 = val_11;
            val_11 = new System.Collections.Generic.List<UnityEngine.Camera>();
        }
        
        val_59 = 1152921505171275776;
        bool val_12 = 丗丛不丁丑专专丂且;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(ProfileController.丑七不且上丗丁一世() == 0)
        {
                object[] val_16 = new object[1];
            val_3 = val_12;
            val_16[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherC_amerasEnabled({0}): ProfileCo_ntroller.Instance == null", args:  val_16);
        }
        
        }
        
        val_60 = 1152921504848912384;
        if(ProfileController.丑七不且上丗丁一世() == 0)
        {
            goto label_34;
        }
        
        val_61 = System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  ProfileController.丑七不且上丗丁一世().GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
        if(val_58 != null)
        {
            goto label_40;
        }
        
        goto label_39;
        label_34:
        System.Collections.Generic.List<UnityEngine.Camera> val_22 = null;
        val_61 = val_22;
        val_22 = new System.Collections.Generic.List<UnityEngine.Camera>();
        if(val_58 != null)
        {
            goto label_40;
        }
        
        label_39:
        label_40:
        val_11.AddRange(collection:  val_22);
        val_56 = ARController.且不下丙丛丛丄丈东();
        if(val_58 != null)
        {
                val_11.AddRange(collection:  val_56);
        }
        else
        {
                val_11.AddRange(collection:  val_56);
        }
        
        List.Enumerator<T> val_24 = val_11.GetEnumerator();
        val_62 = 1152921524440491584;
        val_63 = 1152921524440492608;
        val_64 = 1152921505719563712;
        val_65 = 1152921505175109632;
        val_66 = 1152921524103858144;
        label_119:
        if(((-1640922064) & 1) == 0)
        {
            goto label_43;
        }
        
        val_67 = val_3.丐丏七丌丕丗业且上();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(val_67 == 0)
        {
                object[] val_28 = new object[1];
            val_3 = val_12;
            val_28[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherC_amerasEnabled({0}): c == null", args:  val_28);
            val_64 = val_64;
            val_65 = val_65;
            val_66 = val_66;
            val_63 = val_63;
            val_62 = val_62;
            val_68 = val_59;
            val_69 = val_54;
            val_60 = val_60;
            val_67 = val_67;
        }
        
        }
        
        if(val_67 == 0)
        {
            goto label_119;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if((ExpController.丑七不且上丗丁一世().丙上世与丁丙丘丞丗(丁丂专业丁丅丅丈丙:  val_67)) == true)
        {
            goto label_119;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(val_67.gameObject == 0)
        {
                object[] val_37 = new object[1];
            val_3 = val_12;
            val_37[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCa_merasEnabled({0}): c.gameObject == null", args:  val_37);
            val_64 = val_64;
            val_65 = val_65;
            val_66 = val_66;
            val_63 = val_63;
            val_62 = val_62;
            val_68 = val_68;
            val_69 = val_69;
            val_60 = val_60;
            val_67 = val_67;
        }
        
        }
        
        if(val_67.gameObject != 0)
        {
                if((val_67.gameObject.CompareTag(tag:  "CamTemp")) == true)
        {
            goto label_119;
        }
        
        }
        
        if(((this.arCamera.GetComponent<UnityEngine.Camera>()) == val_67) || ((不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UICamera>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0).GetComponent<UnityEngine.Camera>()) == val_67))
        {
            goto label_119;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                object[] val_51 = new object[1];
            val_3 = val_12;
            val_51[0] = val_3;
            UnityEngine.Debug.LogFormat(format:  "SetOtherCamer_asEnabled({0}): InfoWindowC_ontroller.Instance == null", args:  val_51);
            val_69 = val_69;
            val_60 = val_60;
            val_67 = val_67;
        }
        
        }
        
        this.丟丌丞万丕万丐丐上.Add(item:  val_67);
        val_67.enabled = false;
        UICamera val_52 = val_67.GetComponent<UICamera>();
        if(val_52 == 0)
        {
            goto label_119;
        }
        
        val_52.enabled = false;
        goto label_119;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_159;
        label_43:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_159:
        val_70 = this.丟丌丞万丕万丐丐上;
        val_70.Clear();
    }
    private static System.Collections.Generic.List<UnityEngine.Camera> 且不下丙丛丛丄丈东()
    {
        return System.Linq.Enumerable.ToList<UnityEngine.Camera>(source:  BankController.丑七不且上丗丁一世().GetComponentsInChildren<UnityEngine.Camera>(includeInactive:  true));
    }
    private void 丙与东丏丕丞丕丐东(UnityEngine.SceneManagement.Scene 丈万七丑专丝丁丅丒, UnityEngine.SceneManagement.LoadSceneMode 丛丆东与丑丞丅丝专)
    {
        this.HandleBackClicked();
    }
    public ARController()
    {
        this.丟丌丞万丕万丐丐上 = new System.Collections.Generic.List<UnityEngine.Camera>();
    }
    private UnityEngine.GameObject 与丄万丁下丑丗丆丙()
    {
        if(this.丛丄上世丒丝丂丗丑 != null)
        {
                return this.丛丄上世丒丝丂丗丑.gameObject;
        }
        
        return this.丛丄上世丒丝丂丗丑.gameObject;
    }

}
