using UnityEngine;
public class TouchPadInJoystick : MonoBehaviour
{
    // Fields
    private bool 丟丈七丏三业丄业丌;
    private bool 丟丈丝下世上世业万;
    private System.Collections.Generic.List<GadgetCategory> 且丌不业下丌且东专;
    public LeftFireTouchButton fireTouch;
    public VehicleSpawnTouchButton vehicleSpawnTouch;
    public bool isJumpPressed;
    public UnityEngine.GameObject joystickSprite;
    public UnityEngine.Transform jumpSprite;
    public VehiclePedalTouchButton leftPedalVehicle;
    private bool 丟且七丝三丕丌丞丟;
    private bool 丙业与丂丈丅三七丂;
    public VehiclePedalTouchButton rightPedalVehicle;
    public GadgetTouchButton additionalGadgetButton;
    private UnityEngine.Rect 丄与丘上业丄丂丛且;
    public System.Collections.Generic.List<TouchButton> listTouchButtons;
    private bool <上七丂下丛丞丌三专>k__BackingField;
    private System.Collections.Generic.List<TouchButton> 东丘万丏不丘不丐丑;
    private UnityEngine.Transform _uiRoot;
    private UIPanel _uiPanel;
    private UnityEngine.BoxCollider _collider;
    
    // Properties
    private Player_move_c 丕丁丘丆万丄世专丛 { get; }
    internal bool 不丑东上丌丏专丑丆 { get; set; }
    
    // Methods
    private Player_move_c 丝三丁七丟丅丝丒上()
    {
        null = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                return (Player_move_c)WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        return (Player_move_c)WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
    }
    internal bool 丝三丙丗丏七万不丟()
    {
        return (bool)this.<上七丂下丛丞丌三专>k__BackingField;
    }
    private void 丅下丏丏丐丐七丛丛(bool 丙业与丙丗丝不丈东)
    {
        this.<上七丂下丛丞丌三专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void SetJoystickActive(bool 丛丅丘一丏丙且丌上)
    {
        bool val_1 = 丛丅丘一丏丙且丌上;
        this.丟丈丝下世上世业万 = val_1;
        if(val_1 == true)
        {
                return;
        }
        
        this.leftPedalVehicle.Reset();
        this.rightPedalVehicle.Reset();
        this.isJumpPressed = false;
    }
    private void Awake()
    {
        this.丁业丁与丟丐丈业丆();
    }
    private void Start()
    {
        UnityEngine.Object val_10 = 0;
        if(this._collider == val_10)
        {
                val_10 = public UnityEngine.BoxCollider UnityEngine.Component::GetComponent<UnityEngine.BoxCollider>();
            this._collider = this.GetComponent<UnityEngine.BoxCollider>();
        }
        
        UnityEngine.Vector3 val_3 = this._uiRoot.position;
        float val_11 = val_3.x;
        float val_10 = 384f;
        val_10 = (S9 - val_11) * val_10;
        val_10 = val_10 + val_10;
        val_11 = ((float)UnityEngine.Mathf.FloorToInt(f:  val_10)) + 0.5f;
        float val_12 = -164f;
        val_12 = val_11 + val_12;
        val_11 = (东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != true) ? (val_12) : (val_11);
        UnityEngine.Vector3 val_7 = this._collider.size;
        UnityEngine.Vector3 val_8 = this._collider.size;
        this._collider.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_9 = this._collider.center;
        this._collider.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void CalculateTouchRect()
    {
        float val_6 = (float)UnityEngine.Screen.width;
        val_6 = val_6 * 0.5f;
        if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != false)
        {
                int val_3 = UnityEngine.Screen.height;
        }
        else
        {
                int val_5 = UnityEngine.Screen.height;
            float val_7 = (float)UnityEngine.Screen.width;
            val_7 = val_7 - val_6;
        }
        
        this.丄与丘上业丄丂丛且 = 0;
        mem[1152921540292435492] = 0;
        mem[1152921540292435500] = 0;
    }
    private void 丁业丁与丟丐丈业丆()
    {
        var val_24;
        var val_25;
        this.且丌不业下丌且东专.Clear();
        if(GameConnect.丟丆丏上丌一丝丟业() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_47;
        }
        
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        System.Collections.Generic.IEnumerator<T> val_7 = System.Linq.Enumerable.OfType<GadgetCategory>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))).GetEnumerator();
        label_33:
        var val_25 = 0;
        val_25 = val_25 + 1;
        if(val_7.MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        T val_11 = val_7.Current;
        var val_14 = (val_11 == 13000) ? 1 : 0;
        val_14 = val_14 & (东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().ContainsKey(key:  val_11));
        if(val_14 == false)
        {
            goto label_33;
        }
        
        this.且丌不业下丌且东专.Add(item:  200);
        goto label_33;
        label_22:
        val_24 = 0;
        val_25 = 0;
        if(val_7 == null)
        {
            
        }
        else
        {
                var val_27 = 0;
            val_27 = val_27 + 1;
            val_7.Dispose();
        }
        
        label_47:
        if(this.且丌不业下丌且东专.Count >= 1)
        {
                不丘丄丝丗丒丙一丌 val_19 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[this.且丌不业下丌且东专.Item[0]];
            this.additionalGadgetButton.丐不世丘丁丘下七一(丅东丕丄与一丛丂世:  丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_19.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.且丌不业下丌且东专.Item[0], 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false), 东一丁世丑丞业丄丐:  val_19, 七丆丒与丗丌丄且丂:  this.且丌不业下丌且东专.Item[0]);
            return;
        }
        
        this.additionalGadgetButton.DeactivateGadgetButton();
    }
    private void OnEnable()
    {
        this.leftPedalVehicle.Reset();
        this.rightPedalVehicle.Reset();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.七丌且下七丁丒下丞());
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void TouchPadInJoystick::丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  System.Void TouchPadInJoystick::丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void 丂丑丁丝丂丏丁丑世(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        GadgetTouchButton val_4;
        var val_5;
        var val_6;
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if((七丐丅专且专七三丆 - 27) > 2)
        {
            goto label_3;
        }
        
        if(null == 3)
        {
            goto label_4;
        }
        
        if(null != 1)
        {
                return;
        }
        
        val_4 = this.additionalGadgetButton;
        val_5 = 1;
        goto label_7;
        label_3:
        if(七丐丅专且专七三丆 != 9)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((JoystickController.丘万丏三丏丑世丐丏.jumpTouch & 1) == 0)
        {
                return;
        }
        
        this.isJumpPressed = (null != 0) ? 1 : 0;
        return;
        label_4:
        val_4 = this.additionalGadgetButton;
        val_5 = 0;
        label_7:
        bool val_3 = val_4.Press(丆且上丘世下丅且丞:  false);
    }
    private System.Collections.IEnumerator 七丌且下七丁丒下丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TouchPadInJoystick.万三业七丞丈丞丌丗();
    }
    private bool 丙下七专丝专丅丌且()
    {
        var val_7;
        丄丆一上丗世丞丛丘 val_9;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
                return false;
        }
        
        val_7 = null;
        val_7 = null;
        if(与丂丏丛丞丞丒丟丄.丑丛下丁不丌丏一下 != false)
        {
                return false;
        }
        
        val_7 = null;
        val_9 = 与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐;
        if(val_9 == 1)
        {
                return false;
        }
        
        val_9 = 与丂丏丛丞丞丒丟丄.丗丟丒世七世丟七丐;
        if(val_9 != 0)
        {
                return false;
        }
        
        bool val_4 = UnityEngine.Object.op_Inequality(x:  null.丝三丁七丟丅丝丒上(), y:  0);
        if(val_4 == false)
        {
                return false;
        }
        
        if(val_5.丄丁丑丞丅一三丌丆 == false)
        {
                return false;
        }
        
        Player_move_c val_6 = val_4.丝三丁七丟丅丝丒上().丝三丁七丟丅丝丒上();
        if(val_6.七且不东世与且丒丛 == true)
        {
                return false;
        }
        
        return false;
    }
    private void Update()
    {
        UnityEngine.Transform val_22;
        var val_23;
        var val_24;
        UnityEngine.GameObject val_25;
        var val_26;
        var val_27;
        var val_28;
        val_22 = this;
        if(this.丟丈丝下世上世业万 == false)
        {
            goto label_1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fireTouch.gameObject, 丏业丟一东丂东丘丛:  this.fireTouch & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.vehicleSpawnTouch.gameObject, 丏业丟一东丂东丘丛:  this.vehicleSpawnTouch & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.additionalGadgetButton.gameObject, 丏业丟一东丂东丘丛:  this.additionalGadgetButton & 1);
        if((this.leftPedalVehicle & 1) == 0)
        {
            goto label_12;
        }
        
        val_23 = (~this.joystickSprite.activeSelf) & 1;
        goto label_14;
        label_1:
        this.leftPedalVehicle.Reset();
        this.rightPedalVehicle.Reset();
        this.isJumpPressed = false;
        return;
        label_12:
        val_23 = 0;
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leftPedalVehicle.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.rightPedalVehicle & 1) != 0)
        {
                val_24 = (~this.joystickSprite.activeSelf) & 1;
        }
        else
        {
                val_24 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rightPedalVehicle.gameObject, 丏业丟一东丂东丘丛:  false);
        bool val_11 = GameConnect.丛专丌且丕不专丈下();
        val_25 = this.jumpSprite.gameObject;
        if(val_11 ^ val_25.activeSelf == false)
        {
                return;
        }
        
        val_25 = this.jumpSprite.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  val_11);
        if(val_11 == false)
        {
                return;
        }
        
        val_22 = this.jumpSprite;
        val_26 = null;
        val_26 = null;
        val_25 = 与丂丏丛丞丞丒丟丄.万万丅与丞一丙丄丁;
        val_27 = null;
        val_27 = null;
        val_28 = null;
        val_28 = null;
        UnityEngine.Vector3 val_20 = transform.localPosition;
        float val_21 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? -1f : 1f) * (float)val_25;
        val_22.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void OnPressure(float pressure)
    {
        var val_7;
        var val_8;
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return;
        }
        
        if((与丂丏丛丞丞丒丟丄.下丁丙丐丞丈与下丄() != false) && (与丂丏丛丞丞丒丟丄.丑万万世丘丏下世丆() != false))
        {
                if(与丂丏丛丞丞丒丟丄.丛丗丅丐丌且与丁与() < 0)
        {
                if((this.<上七丂下丛丞丌三专>k__BackingField) == false)
        {
            goto label_16;
        }
        
        }
        
        }
        
        this.丟且七丝三丕丌丞丟 = false;
        this.isJumpPressed = false;
        return;
        label_16:
        if(this.丟且七丝三丕丌丞丟 == true)
        {
                return;
        }
        
        this.丟且七丝三丕丌丞丟 = true;
        this.isJumpPressed = true;
        val_7 = null;
        val_7 = null;
        if(TrainingController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        TrainingController.丄丞丁丈与业上丞丟.Hide3dTouchJump();
    }
    private void OnPress(bool 丆且上丘世下丅且丞)
    {
        var val_13;
        UnityEngine.Object val_19;
        System.Collections.Generic.List<TouchButton> val_20;
        var val_21;
        val_20 = this;
        bool val_1 = GameConnect.丛专丌且丕不专丈下();
        if(val_1 != false)
        {
                this.isJumpPressed = 丆且上丘世下丅且丞;
            return;
        }
        
        if(this.丟丈丝下世上世业万 == false)
        {
                return;
        }
        
        val_19 = val_1.丝三丁七丟丅丝丒上();
        if(val_19 == 0)
        {
                return;
        }
        
        if(this.丟丈七丏三业丄业丌 == true)
        {
                return;
        }
        
        bool val_5 = 丆且上丘世下丅且丞;
        this.<上七丂下丛丞丌三专>k__BackingField = this.丙丝三丈业业丞丘不(丆且上丘世下丅且丞:  val_5);
        if(val_5 != false)
        {
                UnityEngine.Vector2 val_8 = UICamera.lastTouchPosition;
            if((this.丄与丘上业丄丂丛且 & 1) == 0)
        {
                return;
        }
        
            val_20 = this.东丘万丏不丘不丐丑;
            val_21 = null;
            val_21 = null;
            val_20.Add(item:  JoystickController.丘万丏三丏丑世丐丏.丙丝三丈业业丞丘不(丆且上丘世下丅且丞:  true));
            return;
        }
        
        if(this.东丘万丏不丘不丐丑.Count < 1)
        {
            goto label_20;
        }
        
        List.Enumerator<T> val_11 = this.东丘万丏不丘不丐丑.GetEnumerator();
        val_19 = 1152921540287358560;
        label_31:
        if((1327416400 & 1) == 0)
        {
            goto label_22;
        }
        
        string val_14 = val_13.丐丏七丌丕丗业且上();
        if(val_14 == 0)
        {
            goto label_31;
        }
        
        UnityEngine.Vector2 val_16 = UICamera.lastTouchPosition;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        if(val_14 != null)
        {
            goto label_31;
        }
        
        goto label_31;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.东丘万丏不丘不丐丑.Clear();
        label_20:
        this.丟且七丝三丕丌丞丟 = false;
        this.isJumpPressed = false;
    }
    internal bool 丙丝三丈业业丞丘不(bool 丆且上丘世下丅且丞)
    {
        var val_16;
        var val_18;
        var val_19;
        var val_20;
        UnityEngine.Vector2 val_1 = UICamera.lastTouchPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        丆且上丘世下丅且丞 = 丆且上丘世下丅且丞;
        val_16 = val_2.x;
        val_18 = val_2.y;
        val_19 = val_2.z;
        if((this.fireTouch & 1) != 0)
        {
                val_20 = 1;
        }
        else
        {
                UnityEngine.Vector2 val_3 = UICamera.lastTouchPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            bool val_5 = 丆且上丘世下丅且丞;
            val_16 = val_4.x;
            val_18 = val_4.y;
            val_19 = val_4.z;
            val_20 = this.vehicleSpawnTouch & 1;
        }
        
        UnityEngine.Vector2 val_6 = UICamera.lastTouchPosition;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector2 val_9 = UICamera.lastTouchPosition;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        bool val_11 = this.leftPedalVehicle.OnPress(丆且上丘世下丅且丞:  丆且上丘世下丅且丞, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector2 val_12 = UICamera.lastTouchPosition;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        bool val_15 = this.rightPedalVehicle.OnPress(丆且上丘世下丅且丞:  丆且上丘世下丅且丞, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        return (bool)val_20;
    }
    internal TouchButton 丙三丆丞丝丗丕丒丑(bool 丆且上丘世下丅且丞)
    {
        var val_7;
        var val_8;
        int val_1 = this.listTouchButtons.Count;
        if(val_1 != 0)
        {
                val_7 = 0;
            bool val_2 = 丆且上丘世下丅且丞;
            do
        {
            val_8 = this.listTouchButtons.Item[0];
            if(val_8.enabled != false)
        {
                UnityEngine.Vector2 val_5 = UICamera.lastTouchPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            if(val_3.丄东不且丘丏上与业 != true)
        {
                if((val_8 & 1) != 0)
        {
                return (TouchButton)val_8;
        }
        
        }
        
        }
        
            val_7 = val_7 + 1;
        }
        while(val_1 != val_7);
        
        }
        
        val_8 = 0;
        return (TouchButton)val_8;
    }
    private bool 丕丒丝上丄丏世丅丟(float 丑丅世丐丒丏丐三丅, float 东丏丕丗丕丞丁三丌, float 世万丈与丑专丝一丞)
    {
        return (bool)((丑丅世丐丒丏丐三丅 <= 世万丈与丑专丝一丞) ? 1 : 0) & ((丑丅世丐丒丏丐三丅 >= 东丏丕丗丕丞丁三丌) ? 1 : 0);
    }
    public void UpdateButtonsPosition()
    {
        var val_35;
        float val_36;
        float val_37;
        bool val_38;
        var val_39;
        var val_40;
        bool val_44;
        int val_45;
        float val_46;
        val_35 = null;
        val_35 = null;
        下丂世丂不丛专一一 val_3 = 下丂世丂不丛专一一.丏丛丌世专丒丆不世(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
        JoystickController.丗三丄与丂丟丌专东.transform.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        JoystickController.丗三丄与丂丟丌专东.丘丟七丕丏丑丆三一(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        this.fireTouch.transform.localPosition = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        val_36 = V0.16B;
        val_37 = V1.16B;
        this.vehicleSpawnTouch.transform.localPosition = new UnityEngine.Vector3() {x = val_36, y = val_37, z = V2.16B};
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                UnityEngine.Vector3 val_9 = JoystickController.丗三丄与丂丟丌专东.transform.position;
            val_38 = mem[null + 472 + 8];
            val_38 = .丕丞且与东不万丟丁;
            val_38 = 0;
            if(JoystickController.丗三丄与丂丟丌专东 != null)
        {
                val_39 = JoystickController.丗三丄与丂丟丌专东.transform;
        }
        else
        {
                val_39 = JoystickController.丗三丄与丂丟丌专东.transform;
        }
        
            UnityEngine.Vector3 val_13 = JoystickController.丗三丄与丂丟丌专东.transform.localPosition;
            UnityEngine.Vector3 val_15 = JoystickController.丗三丄与丂丟丌专东.transform.localPosition;
            val_40 = JoystickController.丗三丄与丂丟丌专东.transform;
            UnityEngine.Vector3 val_18 = val_40.localPosition;
            float val_35 = (float)height;
            float val_36 = 1.5f;
            val_35 = val_35 / val_36;
            val_36 = val_15.y + val_35;
            val_36 = 0f;
            val_37 = 0f;
            val_39.localPosition = new UnityEngine.Vector3() {x = val_36, y = val_37, z = 0f};
            UnityEngine.Vector3 val_20 = this.fireTouch.transform.position;
            val_44 = mem[null + 472 + 8];
            val_44 = .丕丞且与东不万丟丁;
            val_44 = 0;
            UnityEngine.Vector3 val_23 = this.fireTouch.transform.localPosition;
            UnityEngine.Vector3 val_25 = this.fireTouch.transform.localPosition;
            val_40 = this.fireTouch.transform;
            UnityEngine.Vector3 val_28 = val_40.localPosition;
            float val_37 = (float)height;
            float val_38 = 1.5f;
            val_37 = val_37 / val_38;
            val_38 = val_25.y + val_37;
            this.fireTouch.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        var val_30 = (丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? 53f : -53f;
        this.additionalGadgetButton.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.fireTouch.SetButtonSize(丟丒且一专丟丙下一:  val_3);
        this.fireTouch.丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  0f);
        val_45 = val_3;
        this.vehicleSpawnTouch.SetButtonSize(丟丒且一专丟丙下一:  val_45);
        val_46 = 0f;
        this.vehicleSpawnTouch.丝丆且下丁三不丘世(下丌丟丏丏丘专丒专:  0f);
        this.additionalGadgetButton.SetButtonSize(丟丒且一专丟丙下一:  80);
        this.leftPedalVehicle.SetButtonSize(丟丒且一专丟丙下一:  150);
        this.rightPedalVehicle.SetButtonSize(丟丒且一专丟丙下一:  150);
        if(JoystickController.丗三丄与丂丟丌专东 != 0)
        {
                float val_32 = JoystickController.丗三丄与丂丟丌专东.radius / 144f;
            if(JoystickController.丗三丄与丂丟丌专东 != null)
        {
                float val_39 = (float)val_3;
            val_39 = val_32 * val_39;
            JoystickController.丗三丄与丂丟丌专东.ActualRadius = val_39;
        }
        else
        {
                float val_40 = (float)val_3;
            val_40 = val_32 * val_40;
            0.ActualRadius = val_40;
        }
        
            UISprite val_33 = JoystickController.丗三丄与丂丟丌专东.GetComponent<UISprite>();
            mem2[0] = 1;
            if(val_33 != null)
        {
                val_33.width = val_3;
        }
        else
        {
                val_33.width = val_3;
        }
        
            val_45 = val_33.width;
            JoystickController.丗三丄与丂丟丌专东.丅七上丂七丆一丞丂 = (float)val_45;
            val_46 = (float)val_45;
            val_33.alpha = val_46;
        }
        
        this.丙业与丂丈丅三七丂 = false;
    }
    private void 丅丛下业业丆丈七丒()
    {
        var val_11;
        if(this.丙业与丂丈丅三七丂 == true)
        {
                return;
        }
        
        UnityEngine.Camera val_6 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject).transform.GetChild(index:  0).GetChild(index:  0).GetComponent<UnityEngine.Camera>();
        this.fireTouch.CalculateButtonRect(丆丏一专不丝丈丗上:  val_6);
        this.additionalGadgetButton.CalculateButtonRect(丆丏一专不丝丈丗上:  val_6);
        this.vehicleSpawnTouch.CalculateButtonRect(丆丏一专不丝丈丗上:  val_6);
        this.leftPedalVehicle.CalculateButtonRect(丆丏一专不丝丈丗上:  val_6);
        this.rightPedalVehicle.CalculateButtonRect(丆丏一专不丝丈丗上:  val_6);
        LeftFireTouchButton val_7 = this.fireTouch + 24;
        if((1328390188 & 1) != 0)
        {
                val_11 = 0;
        }
        
        this.丙业与丂丈丅三七丂 = (UnityEngine.Screen.width > UnityEngine.Screen.height) ? 1 : 0;
        this.CalculateTouchRect();
    }
    private void LateUpdate()
    {
        this.丅丛下业业丆丈七丒();
    }
    public TouchPadInJoystick()
    {
        this.丟丈七丏三业丄业丌 = true;
        this.丟丈丝下世上世业万 = true;
        this.且丌不业下丌且东专 = new System.Collections.Generic.List<GadgetCategory>(capacity:  3);
        this.listTouchButtons = new System.Collections.Generic.List<TouchButton>();
        this.东丘万丏不丘不丐丑 = new System.Collections.Generic.List<TouchButton>();
    }

}
