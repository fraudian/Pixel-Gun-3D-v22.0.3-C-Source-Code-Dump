using UnityEngine;
public class VehicleEngine : TransportEngineBase
{
    // Fields
    public float carGrip;
    public UnityEngine.Rigidbody carRigidbody;
    public UnityEngine.Transform CenterOfMass;
    private bool 丝丘丛丁万上东且业;
    internal int 丁上丈丘丁丙丌东丑;
    public float dotProd;
    public float gearChangeTime;
    public float gearTime;
    public float gearTorque;
    public float horizontal;
    private bool 丆上丈丞不丙丐丑丛;
    public bool isBrake;
    private bool 业丘丝丂三丑丑不丕;
    public bool isGrounded;
    public float maxSpeed;
    public UnityEngine.GameObject[] sideColliders;
    public float startAssistance;
    public float startAssistanceStopSpeed;
    private float prewarmAssistTimeAction;
    private float prewarmAssistTimeGetting;
    internal float 且业丐丝专与丁丐且;
    private float 丁丈丈丑丄东丘丂丂;
    public float torque;
    public UnityEngine.GameObject unflipCollider;
    private VehicleController vehicleController;
    public float vertical;
    public VehicleView view;
    private UnityEngine.WheelHit 且七丏丙世与丟万万;
    private float 丂丁三丂丕下丗丞万;
    public float wheelSteerAngle;
    public UnityEngine.WheelCollider[] wheels;
    private float 业专丛丘丒世丂丅丝;
    private float 丌丟万丅丄丙丌专世;
    internal float 丁一丌上丆丑丈不丐;
    internal float 丅专专丝业不丈专丐;
    internal float 业丛东丟丗丘丙东丅;
    private int 上丑丈丟上万一丙专;
    private string 丙丐东七丝世东丅丗;
    private UnityEngine.Coroutine 丗丞丟东不丝一丝下;
    
    // Properties
    internal override float 上丛丕丏东不丝丛三 { get; }
    internal override float 丕丟一东三丏丝丞丞 { get; }
    private bool 丌与上丒丝且专丙世 { get; }
    
    // Methods
    internal override float 丟不丑丈丆丏一丐丁()
    {
        return (float)this.maxSpeed;
    }
    internal override float 东万丝丞丄丐丕丌万()
    {
        if(UnityEngine.Time.frameCount == W8)
        {
                return val_3.x;
        }
        
        mem[1152921536147765288] = UnityEngine.Time.frameCount;
        UnityEngine.Vector3 val_3 = this.carRigidbody.velocity;
        val_3.x = val_3.x * 2.236936f;
        mem[1152921536147765292] = val_3.x;
        return val_3.x;
    }
    protected override void Awake()
    {
        this.Awake();
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
                return;
        }
        
        if(isMine == false)
        {
                return;
        }
        
        this.carRigidbody.interpolation = 1;
    }
    private void Start()
    {
        this.丘上丐世丆丑且丞丒();
    }
    internal void 丅业丝下不三丝三丏(string 丏丆丕丏丘业东万下, int 丌丐丟丟丆丁丌丌丝, bool 下万下丌且丙七丝丆)
    {
        int val_11 = 丌丐丟丟丆丁丌丌丝;
        if(val_11 == 1)
        {
                UnityEngine.Debug.LogError(message:  "ERROR: VehicleUp -1");
            val_11 = 0;
        }
        
        if((((System.String.op_Equality(a:  丏丆丕丏丘业东万下, b:  this.丙丐东七丝世东丅丗)) != false) && (val_11 == this.上丑丈丟上万一丙专)) && (下万下丌且丙七丝丆 != true))
        {
                return;
        }
        
        this.丙丐东七丝世东丅丗 = 丏丆丕丏丘业东万下;
        this.上丑丈丟上万一丙专 = val_11;
        float val_11 = (float)BalanceController.丑丒不丐丁丆丛东且(丆万一不丌且东丐丐:  丏丆丕丏丘业东万下, 丞丌东丟且丒丐丑丂:  0);
        float val_14 = 0.7f;
        float val_12 = (float)BalanceController.世世丛三丈丝丅丄一(丆万一不丌且东丐丐:  丏丆丕丏丘业东万下, 丞丌东丟且丒丐丑丂:  0);
        float val_13 = 2f;
        val_11 = val_11 + 300f;
        val_12 = val_12 / 100f;
        val_13 = val_13 - (((float)BalanceController.东丞三万丂丅丑丏丆(丆万一不丌且东丐丐:  丏丆丕丏丘业东万下, 丞丌东丟且丒丐丑丂:  0)) / 100f);
        float val_7 = ((float)BalanceController.上丞七东丝三丄东世(丆万一不丌且东丐丐:  丏丆丕丏丘业东万下, 丞丌东丟且丒丐丑丂:  0)) / 100f;
        val_14 = val_12 * val_14;
        val_7 = val_7 + 0.3f;
        float val_8 = val_13 + val_13;
        float val_9 = val_14 + 0.3f;
        this.丅专专丝业不丈专丐 = val_7;
        this.丁一丌上丆丑丈不丐 = val_8;
        this.业丛东丟丗丘丙东丅 = val_9;
        this.且丄丂丌且七丞专专(三东丏丞丗丙丘丗丅:  val_8, 丒丌且丁丄丛丌丘万:  val_7, 七与丑丁丝七丒下七:  val_9);
        this.vehicleController.丒不万三业丒不七丟(丙业与丙丗丝不丈东:  val_11);
        this.vehicleController.丑丂万丐丞丌业万一(丙业与丙丗丝不丈东:  100f / val_11);
        this.vehicleController.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  val_11);
    }
    internal void 且丄丂丌且七丞专专(float 三东丏丞丗丙丘丗丅, float 丒丌且丁丄丛丌丘万, float 七与丑丁丝七丒下七)
    {
        float val_2;
        float val_3;
        this.gearChangeTime = 三东丏丞丗丙丘丗丅;
        goto label_0;
        label_8:
        UnityEngine.WheelFrictionCurve val_1 = this.wheels[0].sidewaysFriction;
        val_2.x = 丒丌且丁丄丛丌丘万;
        this.wheels[0].sidewaysFriction = new UnityEngine.WheelFrictionCurve() {m_ExtremumSlip = val_2, m_ExtremumValue = val_2, m_AsymptoteSlip = val_2, m_AsymptoteValue = val_2, m_Stiffness = val_3};
        0 = 1;
        label_0:
        if(0 < this.wheels.Length)
        {
            goto label_8;
        }
        
        this.业专丛丘丒世丂丅丝 = 七与丑丁丝七丒下七;
    }
    private void 丑丄三丌且丝上丘世()
    {
        float val_11 = this.gearTime;
        float val_11 = System.Math.Abs(this.vertical);
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * (-10f);
        float val_3 = (val_11 > 0.01f) ? (val_11 * val_1) : (val_1);
        val_3 = val_11 + val_3;
        this.gearTime = val_3;
        if((isMine != false) && (GameConnect.且丘丄丛下丆丟万丕() != false))
        {
                if(Player_move_c.丗丒丕专丛丆丈万一() != true)
        {
                val_11 = this.gearTime;
            this.gearTime = UnityEngine.Mathf.Clamp(value:  val_11, min:  0f, max:  this.gearChangeTime);
        }
        
        }
        
        this.丁上丈丘丁丙丌东丑 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.RoundToInt(f:  this.gearTime / this.gearChangeTime), min:  0, max:  5);
    }
    private void 丘上丐世丆丑且丞丒()
    {
        UnityEngine.Vector3 val_1 = this.CenterOfMass.localPosition;
        this.carRigidbody.centerOfMass = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    private void Update()
    {
        VehicleView val_32;
        var val_33;
        float val_34;
        float val_35;
        var val_36;
        bool val_37;
        var val_38;
        var val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        val_32 = this;
        if(this.vehicleController.丑丒丙与不丆三丏丌() != false)
        {
                if(this.view != 0)
        {
            goto label_5;
        }
        
        }
        
        if(this.view == 0)
        {
                return;
        }
        
        val_32 = this.view;
        val_32.Stop();
        return;
        label_5:
        this.丁丏丞丙丟丛丆世一();
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_33 = Player_move_c.丗丒丕专丛丆丈万一();
        }
        else
        {
                val_33 = 1;
        }
        
        if(X21.isMine == false)
        {
            goto label_18;
        }
        
        label_40:
        UnityEngine.Vector3 val_8 = this.丌丟丄业且三丛丕丄().forward;
        UnityEngine.Vector3 val_9 = this.carRigidbody.velocity;
        val_34 = val_9.y;
        val_35 = val_8.x;
        float val_10 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_35, y = val_8.y, z = val_8.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_34, z = val_9.z});
        this.dotProd = val_10;
        if((val_33 & this.carRigidbody.isMine) == false)
        {
            goto label_24;
        }
        
        val_35 = this.且业丐丝专与丁丐且;
        var val_13 = (val_35 > 0f) ? 1 : 0;
        goto label_25;
        label_18:
        val_37 = 1152921505286238208;
        val_38 = null;
        val_38 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_41;
        }
        
        val_39 = null;
        val_39 = null;
        UnityEngine.Vector3 val_15 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_40 = val_15.x;
        val_41 = val_15.z;
        UnityEngine.Vector3 val_17 = this.丌丟丄业且三丛丕丄().position;
        val_34 = val_17.y;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_40, y = val_15.y, z = val_41}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_34, z = val_17.z});
        val_42 = 10000f;
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z})) < 0)
        {
            goto label_40;
        }
        
        goto label_41;
        label_24:
        val_36 = 0;
        label_25:
        val_41 = val_10;
        this.view.UpdateVisuals(丝东七一丛丅丏且三:  (this.isBrake == true) ? 1 : 0, 与丐丌万丁丒不业丕:  this.horizontal, 丛丄三丞世丝三丘丂:  this.dotProd, 丕丟一东三丏丝丞丞:  val_41, 业丂万丏丒丛丒万且:  (this.isGrounded == true) ? 1 : 0, 丑丝七丆丙丅业丌丅:  false);
        val_37 = this.isBrake;
        val_40 = this.horizontal;
        val_43 = 0f;
        if(val_36 != 0)
        {
                val_43 = this.且业丐丝专与丁丐且 / this.startAssistance;
        }
        
        val_42 = val_43;
        this.vehicleController.UpdateSoundEffects(丕丟一东三丏丝丞丞:  val_40, 丝东七一丛丅丏且三:  (val_37 == true) ? 1 : 0, 业丂万丏丒丛丒万且:  (this.isGrounded == true) ? 1 : 0, 丝专丛丐专上丞丟三:  val_42);
        label_41:
        if(val_36.isMine != true)
        {
                if(null == null)
        {
                return;
        }
        
        }
        
        if((val_33 & 1) != 0)
        {
                this.丑丄三丌且丝上丘世();
            this.丌丝与丄业丝业丄丏();
            return;
        }
        
        UnityEngine.Vector3 val_25 = this.carRigidbody.velocity;
        this.carRigidbody.velocity = new UnityEngine.Vector3() {x = 0f, y = val_25.y, z = 0f};
        this.gearTime = 0f;
        float val_27 = UnityEngine.Mathf.Clamp(value:  this.startAssistance * this.vertical, min:  0f, max:  this.startAssistance);
        val_27 = val_27 - this.且业丐丝专与丁丐且;
        val_41 = this.startAssistance;
        val_40 = UnityEngine.Mathf.Sign(f:  val_27);
        float val_29 = UnityEngine.Time.deltaTime;
        val_29 = (val_41 / this.prewarmAssistTimeGetting) * val_29;
        val_29 = val_40 * val_29;
        val_29 = this.且业丐丝专与丁丐且 + val_29;
        this.且业丐丝专与丁丐且 = val_29;
    }
    private void 丁丏丞丙丟丛丆世一()
    {
        bool val_11;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        val_11 = this.丝丘丛丁万上东且业;
        bool val_5 = ((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) < 0) ? 1 : 0;
        this.业丘丝丂三丑丑不丕 = val_5;
        var val_6 = (val_11 == true) ? 1 : 0;
        val_6 = val_5 ^ val_6;
        if((val_6 & 1) != 0)
        {
                return;
        }
        
        this.unflipCollider.SetActive(value:  (val_11 == true) ? 1 : 0);
        bool val_11 = this.业丘丝丂三丑丑不丕;
        val_11 = 0;
        val_11 = val_11 ^ 1;
        this.丝丘丛丁万上东且业 = val_11;
        goto label_6;
        label_11:
        this.sideColliders[0].SetActive(value:  (this.丝丘丛丁万上东且业 == true) ? 1 : 0);
        val_11 = 1;
        label_6:
        if(val_11 < this.sideColliders.Length)
        {
            goto label_11;
        }
        
        if(this.vehicleController.viewCollider == 0)
        {
                return;
        }
        
        this.vehicleController.viewCollider.SetActive(value:  (this.丝丘丛丁万上东且业 == true) ? 1 : 0);
    }
    private void 丌丝与丄业丝业丄丏()
    {
        this.丛且丞业丄丄七丐且();
        this.一下丘丈丗丄丙丁且();
        this.一丞与丅丑丆丒丈丁();
    }
    private void 一下丘丈丗丄丙丁且()
    {
        UnityEngine.WheelCollider val_14;
        UnityEngine.Rigidbody val_15;
        float val_16;
        float val_18;
        float val_19;
        float val_20;
        var val_21;
        float val_23;
        float val_24;
        val_14 = this;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_15 = this.carRigidbody;
        UnityEngine.Vector3 val_4 = val_15.velocity;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_4.x);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.carGrip);
        val_16 = 1f;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  (this.丗丞丟东不丝一丝下 != 0) ? 0f : (val_16));
        val_18 = val_8.x;
        val_19 = val_18;
        this.carRigidbody.AddForce(force:  new UnityEngine.Vector3() {x = val_19, y = val_8.y, z = val_8.z});
        if(this.isGrounded == false)
        {
                return;
        }
        
        val_20 = this.maxSpeed;
        val_21 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.vehicleController.且丏丄丒丟丅丟丗丂())) != false)
        {
                val_21 = 0;
            SlowdownZoneTriggerTransport val_11 = this.vehicleController.且丏丄丒丟丅丟丗丂();
            val_19 = val_11.slowCoef;
            val_16 = 2f;
            val_20 = val_20 * val_19;
        }
        
        if(val_19 <= 10f)
        {
            goto label_15;
        }
        
        if(System.Math.Abs(this.dotProd) >= 0)
        {
            goto label_18;
        }
        
        label_51:
        val_23 = 20000f;
        this.gearTime = 0f;
        this.isBrake = true;
        goto label_27;
        label_15:
        val_24 = this.vertical;
        goto label_20;
        label_18:
        val_24 = val_14;
        if((UnityEngine.Mathf.Sign(f:  this.dotProd)) != (UnityEngine.Mathf.Sign(f:  this.vertical)))
        {
            goto label_23;
        }
        
        label_20:
        label_50:
        if(this.vertical != 0f)
        {
            goto label_24;
        }
        
        val_23 = 0f;
        if(this.vertical == 0f)
        {
            goto label_27;
        }
        
        val_23 = 500f;
        goto label_27;
        label_24:
        this.isBrake = false;
        val_23 = 0f;
        if(this.vertical > val_20)
        {
                val_23 = 1000f;
        }
        
        label_27:
        val_18 = val_16 * val_23;
        if((this.vehicleController == 1) && (val_20 == this.maxSpeed))
        {
                this.wheels[1].brakeTorque = 0f;
            this.wheels[0].brakeTorque = 0f;
            val_15 = this.wheels;
            val_14 = this.wheels[2];
            val_15[3].brakeTorque = val_18;
            val_14.brakeTorque = val_18;
            return;
        }
        
        val_15 = 0;
        goto label_44;
        label_49:
        this.wheels[0].brakeTorque = val_18;
        val_15 = 1;
        label_44:
        if(val_15 < this.wheels.Length)
        {
            goto label_49;
        }
        
        return;
        label_23:
        if(this.vertical == 0f)
        {
            goto label_50;
        }
        
        goto label_51;
    }
    private void 丛且丞业丄丄七丐且()
    {
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        int val_26;
        var val_27;
        float val_28;
        var val_29;
        val_22 = 0f;
        this.isGrounded = false;
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_3;
        }
        
        val_22 = this.vertical;
        if(val_22 <= 0f)
        {
            goto label_4;
        }
        
        val_23 = this.且业丐丝专与丁丐且;
        val_24 = this.prewarmAssistTimeAction;
        val_22 = (this.startAssistance / val_24) * UnityEngine.Time.deltaTime;
        val_25 = val_23 - val_22;
        if(val_25 >= 0)
        {
            goto label_5;
        }
        
        label_4:
        val_25 = 0f;
        label_5:
        this.且业丐丝专与丁丐且 = val_25;
        goto label_7;
        label_3:
        label_7:
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_10;
        }
        
        val_26 = 1152921536150140576;
        val_27 = 0;
        val_23 = 0f;
        goto label_11;
        label_31:
        UnityEngine.Vector3 val_6 = this.wheels[0].transform.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
        val_28 = 1f;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  5f)) != false)
        {
                if((val_22.gameObject.GetComponent<RacingSurfaceTorqueModifier>()) != 0)
        {
                val_28 = val_10.torqueModifier;
        }
        else
        {
                val_28 = 1f;
            if((val_22.gameObject.CompareTag(tag:  "RacingRoad")) != true)
        {
                val_28 = this.业专丛丘丒世丂丅丝;
        }
        
        }
        
        }
        
        val_27 = 1;
        val_22 = val_28 / (float)this.wheels.Length;
        val_23 = val_23 + val_22;
        label_11:
        if(val_27 < this.wheels.Length)
        {
            goto label_31;
        }
        
        val_24 = UnityEngine.Time.deltaTime;
        this.丂丁三丂丕下丗丞万 = UnityEngine.Mathf.Lerp(a:  this.丂丁三丂丕下丗丞万, b:  val_23, t:  val_24 * this.丌丟万丅丄丙丌专世);
        label_10:
        val_29 = 0;
        goto label_34;
        label_43:
        UnityEngine.WheelCollider val_21 = this.wheels[0];
        if(this.isGrounded != true)
        {
                this.wheels[0] = val_21.GetGroundHit(hit: out  new UnityEngine.WheelHit() {m_Point = new UnityEngine.Vector3() {x = this.且七丏丙世与丟万万, y = this.且七丏丙世与丟万万, z = this.且七丏丙世与丟万万}, m_Normal = new UnityEngine.Vector3() {x = this.且七丏丙世与丟万万, y = this.且七丏丙世与丟万万, z = this.且七丏丙世与丟万万}, m_ForwardDir = new UnityEngine.Vector3() {x = this.且七丏丙世与丟万万, y = this.且七丏丙世与丟万万, z = this.且七丏丙世与丟万万}, m_SidewaysDir = new UnityEngine.Vector3() {x = this.且七丏丙世与丟万万, y = this.且七丏丙世与丟万万, z = this.且七丏丙世与丟万万}, m_Force = this.且七丏丙世与丟万万, m_ForwardSlip = this.且七丏丙世与丟万万, m_SidewaysSlip = this.且七丏丙世与丟万万, m_Collider = this.且七丏丙世与丟万万});
            this.isGrounded = this.wheels[0];
        }
        
        val_24 = this.torque;
        val_26 = this.丁上丈丘丁丙丌东丑;
        val_23 = this.丂丁三丂丕下丗丞万;
        float val_22 = (float)val_26;
        float val_18 = this.startAssistance + val_24;
        val_22 = this.gearTorque * val_22;
        val_18 = val_18 + val_22;
        val_18 = val_23 * val_18;
        val_18 = this.vertical * val_18;
        val_21.motorTorque = val_18;
        if(val_29 <= 1)
        {
                val_23 = this.wheelSteerAngle;
            val_21.steerAngle = val_23 * this.horizontal;
        }
        
        val_29 = 1;
        label_34:
        if(val_29 < this.wheels.Length)
        {
            goto label_43;
        }
    
    }
    private void 一丞与丅丑丆丒丈丁()
    {
        float val_7;
        float val_8;
        val_7 = 0.5f;
        if(System.Math.Abs(this.vertical) <= val_7)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_1 = this.carRigidbody.velocity;
        if(val_1.x >= 0)
        {
            goto label_5;
        }
        
        val_8 = this;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丁丈丈丑丄东丘丂丂 + val_2;
        this.丁丈丈丑丄东丘丂丂 = val_2;
        if(val_2 <= val_7)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().forward;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  3f);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.vertical);
        val_7 = val_6.x;
        this.carRigidbody.velocity = new UnityEngine.Vector3() {x = val_7, y = val_6.y, z = val_6.z};
        goto label_11;
        label_5:
        val_8 = this.丁丈丈丑丄东丘丂丂;
        label_11:
        mem2[0] = 0;
    }
    private bool 丁业丁世丙丏丝东丁()
    {
        return (bool)(this.丗丞丟东不丝一丝下 != 0) ? 1 : 0;
    }
    internal void 丌丆丅丑世丌一不丈()
    {
        if(this.丗丞丟东不丝一丝下 != null)
        {
                return;
        }
        
        this.丗丞丟东不丝一丝下 = this.StartCoroutine(routine:  this.下丈丕世丟与丂七丟());
    }
    private System.Collections.IEnumerator 下丈丕世丟与丂七丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleEngine.丛丟丑丈专丐丈丂业();
    }
    public VehicleEngine()
    {
        this.丝丘丛丁万上东且业 = true;
        this.gearTorque = 50f;
        this.丂丁三丂丕下丗丞万 = 1f;
        this.carGrip = 90f;
        this.startAssistance = ;
        this.startAssistanceStopSpeed = ;
        this.prewarmAssistTimeAction = 3f;
        this.prewarmAssistTimeGetting = 1f;
        this.gearChangeTime = 2f;
        this.maxSpeed = 80f;
        this.torque = 200f;
        this.wheelSteerAngle = 45f;
        mem2[0] = ;
        this.业丛东丟丗丘丙东丅 = 0.5f;
        this.上丑丈丟上万一丙专 = 0;
        this.丙丐东七丝世东丅丗 = System.String.alignConst;
    }

}
