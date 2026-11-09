using UnityEngine;
public class HelicopterEngine : TransportEngineBase
{
    // Fields
    public UnityEngine.Transform body;
    public UnityEngine.Transform centerOfMass;
    public UnityEngine.BoxCollider[] skiColliders;
    public float minRotorForce;
    public float rotorForce;
    public float maxRotorForce;
    public float tailRotorForce;
    public float rotorRotationVelocity;
    public float maxRotorSpeed;
    public float startingDelayTime;
    internal float 且专三丞丞丂且不丝;
    private float 丌丌丝丈丕丝丅丑丅;
    private bool 丁一世七丁不丌丆丁;
    private float 丙丟丞丗丟丌丕与上;
    public float maxUpSpeed;
    public float maxDownSpeed;
    public float maxVerticalSpeedTime;
    public float verticalSpeedLossTime;
    public float descentDelayTime;
    private float 万丞东一世丌丞万丟;
    private float 丅丆丌丄不一与丕丑;
    private float 丅世丝丄且丛丏丒丈;
    private float 下丈业七丆一丙丈东;
    private float 丆世上丌丞世丒丛丘;
    public float maxRotationSpeed;
    public float maxRotationSpeedTime;
    public float rotationSpeedLossTime;
    private float 世丂与下三不不丒丅;
    private float 一丁丏丁丟丒业不丄;
    private float 丒东与丟丑丑且丈丝;
    private float 下业七丛世业丂万丟;
    public float maxForwardSpeed;
    public float maxBackwardSpeed;
    public float maxHorizontalSpeedTime;
    public float horizontalSpeedLossTime;
    private float 丂丄不业丛丆丌丞三;
    private float 丈丑不专丝东丄丄丌;
    private float 丑丈丏丕东且丞不丙;
    private float 丞丒丈丝上三丏丏丘;
    private UnityEngine.Vector3 丟丛丁丆丆丌丄一且;
    private float 万专丌丘上丑丙丙丅;
    private float 丌下与丈三丞七丒丈;
    private float 丝丆丐万丕丅东业丂;
    private bool 丌丌丅丒东万丘丛丘;
    private float <丙不丂丛一丕丈丝丘>k__BackingField;
    private float <丞三丕三上且丆丆丒>k__BackingField;
    private float <业丗丅丑业一与下丁>k__BackingField;
    private bool <东丂丗丞丗丑丂丂业>k__BackingField;
    private HelicopterController 丆丟与丝丘东丝丒且;
    
    // Properties
    private float 世下丙丌世丌丅丒不 { get; set; }
    private float 万丛一专丅丛丕专丁 { get; set; }
    private float 与丙丛丙丄一万丅丘 { get; set; }
    internal bool 丒丛丒丝丟丒丄不万 { get; set; }
    internal bool 丏丏丘丄丟丆丝丗丄 { get; }
    internal override float 上丛丕丏东不丝丛三 { get; }
    
    // Methods
    private float 不与丒与下丏一上丁()
    {
        return (float)this.<丙不丂丛一丕丈丝丘>k__BackingField;
    }
    private void 丏专世丝且不不丟七(float 丙业与丙丗丝不丈东)
    {
        this.<丙不丂丛一丕丈丝丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private float 丞丁下丛且丞丁丆丗()
    {
        return (float)this.<丞三丕三上且丆丆丒>k__BackingField;
    }
    private void 业七丗丝不丕七丟一(float 丙业与丙丗丝不丈东)
    {
        this.<丞三丕三上且丆丆丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private float 丐与不专丕丌丐丄丐()
    {
        return (float)this.<业丗丅丑业一与下丁>k__BackingField;
    }
    private void 丛专丂丙七丑丞与且(float 丙业与丙丗丝不丈东)
    {
        this.<业丗丅丑业一与下丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 三丅丘丈专且东丙三()
    {
        return (bool)this.<东丂丗丞丗丑丂丂业>k__BackingField;
    }
    private void 丟不丟丐丘三丁丝丟(bool 丙业与丙丗丝不丈东)
    {
        this.<东丂丗丞丗丑丂丂业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 不下丐一丟丈丕丒丒()
    {
        if(this.丆丟与丝丘东丝丒且 == null)
        {
            
        }
    
    }
    protected override void Awake()
    {
        this.Awake();
        this.丆丟与丝丘东丝丒且 = this.GetComponent<HelicopterController>();
    }
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.centerOfMass.localPosition;
        this.七上不且且丑丂丟东().centerOfMass = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.rotorForce = this.minRotorForce;
        this.丌下与丈三丞七丒丈 = this.maxUpSpeed;
        this.丝丆丐万丕丅东业丂 = this.maxForwardSpeed;
    }
    private void Update()
    {
        this.丌丌丅丒东万丘丛丘 = this.丆丟与丝丘东丝丒且 & 1;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_2 * 5f;
        this.万专丌丘上丑丙丙丅 = val_2;
        if(this.丌丌丅丒东万丘丛丘 != true)
        {
                mem2[0] = 0;
            this.<业丗丅丑业一与下丁>k__BackingField = 0f;
        }
        
        this.丝丒丝下业丌丌三丈();
        this.上东三丑世与万丛丕();
        this.丁丘丛世专业不不与();
        if(this.丆丟与丝丘东丝丒且.isMine == false)
        {
                return;
        }
        
        if(this.丌丌丅丒东万丘丛丘 != false)
        {
                if(this.丁一世七丁不丌丆丁 == true)
        {
                return;
        }
        
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.丌丌丝丈丕丝丅丑丅 + val_4;
            this.丌丌丝丈丕丝丅丑丅 = val_4;
            this.丁一世七丁不丌丆丁 = (val_4 > this.startingDelayTime) ? 1 : 0;
            if(this.丌丌丅丒东万丘丛丘 == true)
        {
                return;
        }
        
        }
        
        this.丌丌丝丈丕丝丅丑丅 = 0f;
        this.丁一世七丁不丌丆丁 = false;
    }
    private void 丁丘丛世专业不不与()
    {
        var val_9;
        float val_11;
        float val_12;
        if(isMine == false)
        {
            goto label_2;
        }
        
        if(this.丌丌丅丒东万丘丛丘 == false)
        {
            goto label_3;
        }
        
        val_9 = this;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.rotorRotationVelocity * val_2;
        val_11 = this.且专三丞丞丂且不丝 + val_2;
        goto label_4;
        label_3:
        if(((this.<东丂丗丞丗丑丂丂业>k__BackingField) == true) || (S0 <= 0.1f))
        {
            goto label_6;
        }
        
        val_9 = this;
        val_11 = this.且专三丞丞丂且不丝;
        float val_9 = this.maxRotorSpeed;
        val_9 = val_9 * 0.5f;
        if(val_11 <= val_9)
        {
            goto label_7;
        }
        
        label_6:
        val_9 = this;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.rotorRotationVelocity * val_3;
        val_11 = this.且专三丞丞丂且不丝 - val_3;
        label_4:
        this.且专三丞丞丂且不丝 = val_11;
        label_7:
        this.且专三丞丞丂且不丝 = UnityEngine.Mathf.Clamp(value:  val_11, min:  0f, max:  this.maxRotorSpeed);
        label_2:
        if((this.丆丟与丝丘东丝丒且 & 1) != 0)
        {
                val_12 = 0f;
            this.且专三丞丞丂且不丝 = 0f;
        }
        else
        {
                val_12 = this.且专三丞丞丂且不丝;
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_12 * val_5;
        val_5 = this.丙丟丞丗丟丌丕与上 + val_5;
        this.丙丟丞丗丟丌丕与上 = val_5;
        this.丙丟丞丗丟丌丕与上 = val_5;
        if((UnityEngine.Object.op_Implicit(exists:  this.丆丟与丝丘东丝丒且.view)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
        this.丛与东世丄丑丐不丘(丟丄万丗丟丄丗丘丟:  this.丆丟与丝丘东丝丒且.view.mainRotor, 丒丈丘业丛丁丏丙丘:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
        this.丛与东世丄丑丐不丘(丟丄万丗丟丄丗丘丟:  this.丆丟与丝丘东丝丒且.view.tailRotor, 丒丈丘业丛丁丏丙丘:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
    }
    private void 上东三丑世与万丛丕()
    {
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_11 = this.丝丆丐万丕丅东业丂;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = (val_11 * System.Math.Abs(this.丂丄不业丛丆丌丞三)) * val_1;
        float val_10 = this.万专丌丘上丑丙丙丅;
        float val_12 = this.丂丄不业丛丆丌丞三;
        val_10 = val_10 * 5f;
        val_11 = (val_1 < 0) ? (val_10) : (val_1);
        val_10 = 0f;
        val_11 = (UnityEngine.Mathf.Sign(f:  val_12)) * this.丞丒丈丝上三丏丏丘;
        val_12 = (this.丞丒丈丝上三丏丏丘 > 0.5f) ? (val_11) : (val_10);
        if(this.丞丒丈丝上三丏丏丘 > 0.5f)
        {
                val_11 = this.<丙不丂丛一丕丈丝丘>k__BackingField;
            val_10 = -(this.丞丒丈丝上三丏丏丘 * val_11);
        }
        
        float val_6 = UnityEngine.Mathf.Lerp(a:  V11.16B, b:  val_10, t:  UnityEngine.Time.deltaTime * 3f);
        val_13 = val_6;
        if((((this.<东丂丗丞丗丑丂丂业>k__BackingField) != true) && (val_6 > 0.1f)) && ((this.丆丟与丝丘东丝丒且 & 1) == 0))
        {
                if(this.丌丌丅丒东万丘丛丘 == true)
        {
            goto label_12;
        }
        
        }
        
        val_13 = 0f;
        val_12 = 0f;
        label_12:
        this.丟丛丁丆丆丌丄一且 = UnityEngine.Mathf.MoveTowards(current:  this.丟丛丁丆丆丌丄一且, target:  val_12, maxDelta:  val_11);
        float val_8 = UnityEngine.Mathf.MoveTowards(current:  val_12, target:  val_13, maxDelta:  val_11);
        mem[1152921539390823032] = val_8;
        this.body.localEulerAngles = new UnityEngine.Vector3() {x = this.丟丛丁丆丆丌丄一且, y = val_13, z = val_8};
    }
    private void 丛与东世丄丑丐不丘(UnityEngine.Transform 丟丄万丗丟丄丗丘丟, UnityEngine.Vector3 丒丈丘业丛丁丏丙丘)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丒丈丘业丛丁丏丙丘.x, y = 丒丈丘业丛丁丏丙丘.y, z = 丒丈丘业丛丁丏丙丘.z}, d:  this.丙丟丞丗丟丌丕与上);
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        丟丄万丗丟丄丗丘丟.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
    }
    private void FixedUpdate()
    {
        if(isMine == false)
        {
                return;
        }
        
        if((this.丆丟与丝丘东丝丒且 & 1) != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.七上不且且丑丂丟东().velocity;
        float val_20 = val_3.y;
        this.丌下与丈三丞七丒丈 = ((UnityEngine.Mathf.Sign(f:  val_20)) > 0f) ? this.maxUpSpeed : this.maxDownSpeed;
        this.丝丆丐万丕丅东业丂 = (val_3.x > 0f) ? this.maxForwardSpeed : this.maxBackwardSpeed;
        if(this.丌丌丅丒东万丘丛丘 != false)
        {
                if(this.丁一世七丁不丌丆丁 == false)
        {
                return;
        }
        
            this.丒世三丙丛一丐丙丆(与丐丌万丁丒不业丕:  this.<丙不丂丛一丕丈丝丘>k__BackingField, 丌丝三丌丗丄丌丈且:  this.<丞三丕三上且丆丆丒>k__BackingField, 丗业丗丌不丌丏丏三:  this.<业丗丅丑业一与下丁>k__BackingField);
            this.下丏且一三丐一丐不(与丐丌万丁丒不业丕:  this.<丙不丂丛一丕丈丝丘>k__BackingField, 丌丝三丌丗丄丌丈且:  this.<丞三丕三上且丆丆丒>k__BackingField, 丗业丗丌不丌丏丏三:  this.<业丗丅丑业一与下丁>k__BackingField);
            this.丗丗业丆三丐丈丕万(与丐丌万丁丒不业丕:  this.<丙不丂丛一丕丈丝丘>k__BackingField);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().up;
            if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, to:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) >= 0)
        {
                return;
        }
        
            UnityEngine.Quaternion val_12 = this.丌丟丄业且三丛丕丄().localRotation;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_12.y, z:  0f);
            float val_18 = this.万专丌丘上丑丙丙丅;
            val_18 = val_18 + val_18;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, b:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, t:  val_18);
            this.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
            return;
        }
        
        if(System.Math.Abs(val_20) < this.丌下与丈三丞七丒丈)
        {
                return;
        }
        
        val_20 = this.丌下与丈三丞七丒丈 * (UnityEngine.Mathf.Sign(f:  val_20));
        this.七上不且且丑丂丟东().velocity = new UnityEngine.Vector3() {x = val_3.x, y = val_20, z = val_3.z};
    }
    private void 丗丗业丆三丐丈丕万(float 与丐丌万丁丒不业丕)
    {
        float val_10;
        float val_11;
        UnityEngine.Vector3 val_2 = this.七上不且且丑丂丟东().angularVelocity;
        if(与丐丌万丁丒不业丕 == 0f)
        {
                val_10 = this.tailRotorForce;
            val_11 = -(val_2.y * val_10);
        }
        else
        {
                float val_3 = this.maxRotationSpeed / 10f;
            if(System.Math.Abs(val_2.y) >= 0)
        {
                return;
        }
        
            val_10 = this.tailRotorForce;
            val_11 = val_10 * this.世丂与下三不不丒丅;
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  val_11);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  UnityEngine.Time.deltaTime);
        this.七上不且且丑丂丟东().AddRelativeTorque(torque:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, mode:  5);
    }
    private void 下丏且一三丐一丐不(float 与丐丌万丁丒不业丕, float 丌丝三丌丗丄丌丈且, float 丗业丗丌不丌丏丏三)
    {
        float val_37;
        float val_38;
        float val_39;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_51;
        var val_52;
        float val_53;
        float val_54;
        var val_55;
        var val_56;
        var val_57;
        float val_58;
        val_37 = 丗业丗丌不丌丏丏三;
        val_38 = 0f;
        if(((与丐丌万丁丒不业丕 == 0f) && (丌丝三丌丗丄丌丈且 == 0f)) && (val_37 == 0f))
        {
                val_38 = this.万丞东一世丌丞万丟 + UnityEngine.Time.deltaTime;
        }
        
        this.万丞东一世丌丞万丟 = val_38;
        if(val_37 == 0f)
        {
                val_39 = this.rotorForce;
            float val_4 = UnityEngine.Mathf.Lerp(a:  val_39, b:  this.minRotorForce, t:  UnityEngine.Time.deltaTime * this.丌下与丈三丞七丒丈);
        }
        else
        {
                float val_5 = UnityEngine.Mathf.Sign(f:  this.丅丆丌丄不一与丕丑);
            val_41 = this.minRotorForce;
            if(val_5 > 0f)
        {
                val_41 = this.maxRotorForce;
        }
        
            val_39 = this.minRotorForce + (this.minRotorForce * this.丅丆丌丄不一与丕丑);
            float val_8 = UnityEngine.Mathf.Clamp(value:  val_39, min:  (val_5 > 0f) ? this.minRotorForce : (-this.minRotorForce), max:  val_41);
        }
        
        this.rotorForce = val_8;
        float val_37 = UnityEngine.Mathf.Clamp(value:  val_8, min:  -this.maxRotorForce, max:  this.maxRotorForce);
        this.rotorForce = val_37;
        val_37 = val_37 * UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_37);
        UnityEngine.Vector3 val_14 = UnityEngine.Physics.gravity;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        val_42 = val_15.x;
        val_43 = val_15.y;
        val_44 = val_15.z;
        this.七上不且且丑丂丟东().AddRelativeForce(force:  new UnityEngine.Vector3() {x = val_42, y = val_43, z = val_44}, mode:  5);
        if(丌丝三丌丗丄丌丈且 != 0f)
        {
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  this.maxRotorForce * this.丂丄不业丛丆丌丞三);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  UnityEngine.Time.deltaTime);
            val_42 = val_21.x;
            val_43 = val_21.y;
            val_44 = val_21.z;
            this.七上不且且丑丂丟东().AddRelativeForce(force:  new UnityEngine.Vector3() {x = val_42, y = val_43, z = val_44}, mode:  5);
        }
        
        UnityEngine.Vector3 val_23 = this.七上不且且丑丂丟东().velocity;
        val_45 = val_23.x;
        val_46 = val_23.y;
        val_47 = val_23.z;
        UnityEngine.Vector3 val_25 = this.丌丟丄业且三丛丕丄().position;
        if((val_37 <= 0f) || (val_25.y < 250f))
        {
            goto label_25;
        }
        
        val_37 = this.万专丌丘上丑丙丙丅;
        val_46 = UnityEngine.Mathf.Lerp(a:  val_46, b:  0f, t:  val_37);
        val_51 = this.descentDelayTime;
        goto label_34;
        label_25:
        val_51 = this;
        if((this.万丞东一世丌丞万丟 > this.descentDelayTime) || (val_37 != 0f))
        {
            goto label_30;
        }
        
        val_52 = null;
        val_53 = this.丆世上丌丞世丒丛丘;
        goto label_31;
        label_30:
        val_53 = this.丌下与丈三丞七丒丈;
        if(System.Math.Abs(val_46) < val_53)
        {
            goto label_34;
        }
        
        val_52 = null;
        label_31:
        val_37 = this.丅丆丌丄不一与丕丑;
        val_46 = UnityEngine.Mathf.Lerp(a:  val_46, b:  val_53 * (UnityEngine.Mathf.Sign(f:  val_37)), t:  this.万专丌丘上丑丙丙丅);
        label_34:
        if((this.万丞东一世丌丞万丟 > this.descentDelayTime) || (丌丝三丌丗丄丌丈且 != 0f))
        {
            goto label_38;
        }
        
        val_54 = this.丝丆丐万丕丅东业丂;
        float val_30 = val_54 * this.丂丄不业丛丆丌丞三;
        val_55 = 0f;
        val_56 = 0f;
        val_57 = 0f;
        goto label_41;
        label_38:
        val_58 = this.丝丆丐万丕丅东业丂;
        if(this.万丞东一世丌丞万丟 < (val_58 * val_58))
        {
            goto label_42;
        }
        
        val_54 = 0f;
        val_55 = val_54;
        val_56 = 0f;
        val_57 = 0f;
        label_41:
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_54, y = 0f, z = 0f}, maxLength:  val_58);
        val_58 = val_32.x;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_58, y = val_32.y, z = val_32.z}, t:  UnityEngine.Time.deltaTime + UnityEngine.Time.deltaTime);
        val_45 = val_35.x;
        val_47 = val_35.z;
        label_42:
        this.七上不且且丑丂丟东().velocity = new UnityEngine.Vector3() {x = val_45, y = val_46, z = val_47};
    }
    private void 丒世三丙丛一丐丙丆(float 与丐丌万丁丒不业丕, float 丌丝三丌丗丄丌丈且, float 丗业丗丌不丌丏丏三)
    {
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        float val_35 = this.丅丆丌丄不一与丕丑;
        float val_1 = 1f / this.maxVerticalSpeedTime;
        this.丅世丝丄且丛丏丒丈 = val_1;
        this.下丈业七丆一丙丈东 = 1f / this.verticalSpeedLossTime;
        float val_3 = UnityEngine.Time.deltaTime;
        float val_36 = this.下丈业七丆一丙丈东;
        丗业丗丌不丌丏丏三 = val_1 * 丗业丗丌不丌丏丏三;
        val_3 = 丗业丗丌不丌丏丏三 * val_3;
        val_3 = val_35 + val_3;
        if(丗业丗丌不丌丏丏三 == 0f)
        {
                val_35 = 0;
            val_36 = this;
            val_37 = val_3;
            val_38 = val_36;
        }
        else
        {
                val_36 = 0;
            val_35 = 1;
            val_37 = 0f;
            val_38 = 0f;
        }
        
        var val_4 = (val_35 != 0) ? (this) : (val_36);
        val_35 = (val_35 != 0) ? (val_3) : (val_37);
        float val_8 = UnityEngine.Time.deltaTime;
        val_36 = ((val_35 != 0) ? 0f : 1f) * ((val_35 != 0) ? (val_36) : (val_38));
        val_36 = val_36 * (UnityEngine.Mathf.Sign(f:  this.丅丆丌丄不一与丕丑));
        val_8 = val_36 * val_8;
        val_8 = val_35 - val_8;
        mem2[0] = UnityEngine.Mathf.Clamp(value:  val_8, min:  -1f, max:  1f);
        float val_37 = this.maxRotationSpeedTime;
        float val_38 = this.世丂与下三不不丒丅;
        this.丆世上丌丞世丒丛丘 = UnityEngine.Mathf.Lerp(a:  0f, b:  (this.丅丆丌丄不一与丕丑 > 0f) ? this.maxUpSpeed : this.maxDownSpeed, t:  this.丅丆丌丄不一与丕丑 * (UnityEngine.Mathf.Sign(f:  this.丅丆丌丄不一与丕丑)));
        float val_14 = 1f / val_37;
        this.一丁丏丁丟丒业不丄 = val_14;
        this.丒东与丟丑丑且丈丝 = 1f / this.rotationSpeedLossTime;
        float val_16 = UnityEngine.Time.deltaTime;
        val_37 = val_14 * 与丐丌万丁丒不业丕;
        val_16 = val_37 * val_16;
        val_38 = val_38 + val_16;
        float val_19 = UnityEngine.Time.deltaTime;
        float val_20 = ((与丐丌万丁丒不业丕 == 0f) ? 1f : 0f) * this.丒东与丟丑丑且丈丝;
        val_20 = val_20 * (UnityEngine.Mathf.Sign(f:  this.世丂与下三不不丒丅));
        val_19 = val_20 * val_19;
        val_19 = val_38 - val_19;
        float val_39 = 1f;
        float val_21 = UnityEngine.Mathf.Clamp(value:  val_19, min:  -1f, max:  val_39);
        this.世丂与下三不不丒丅 = val_21;
        val_39 = val_21 * (UnityEngine.Mathf.Sign(f:  val_21));
        float val_40 = this.maxHorizontalSpeedTime;
        float val_41 = this.丂丄不业丛丆丌丞三;
        this.下业七丛世业丂万丟 = UnityEngine.Mathf.Lerp(a:  0f, b:  this.maxRotationSpeed, t:  val_39);
        float val_24 = 1f / val_40;
        this.丈丑不专丝东丄丄丌 = val_24;
        this.丑丈丏丕东且丞不丙 = 1f / this.horizontalSpeedLossTime;
        float val_26 = UnityEngine.Time.deltaTime;
        val_40 = val_24 * 丌丝三丌丗丄丌丈且;
        val_26 = val_40 * val_26;
        val_41 = val_41 + val_26;
        float val_29 = UnityEngine.Time.deltaTime;
        float val_30 = ((丌丝三丌丗丄丌丈且 == 0f) ? 1f : 0f) * this.丑丈丏丕东且丞不丙;
        val_30 = val_30 * (UnityEngine.Mathf.Sign(f:  this.丂丄不业丛丆丌丞三));
        val_29 = val_30 * val_29;
        val_29 = val_41 - val_29;
        float val_42 = 1f;
        float val_31 = UnityEngine.Mathf.Clamp(value:  val_29, min:  -1f, max:  val_42);
        this.丂丄不业丛丆丌丞三 = val_31;
        val_42 = val_31 * (UnityEngine.Mathf.Sign(f:  val_31));
        this.丞丒丈丝上三丏丏丘 = UnityEngine.Mathf.Lerp(a:  0f, b:  (val_31 > 0f) ? this.maxForwardSpeed : this.maxBackwardSpeed, t:  val_42);
    }
    private void 丝丒丝下业丌丌三丈()
    {
        var val_14;
        bool val_15;
        var val_15 = 0;
        label_13:
        if(val_15 >= this.skiColliders.Length)
        {
            goto label_2;
        }
        
        UnityEngine.BoxCollider val_14 = this.skiColliders[0];
        if(val_14 != null)
        {
                val_14 = val_14.transform;
        }
        else
        {
                val_14 = 0.transform;
        }
        
        UnityEngine.Vector3 val_3 = val_14.size;
        UnityEngine.Vector3 val_5 = val_14.up;
        float val_6 = (val_3.y * 0.5f) + 0.05f;
        UnityEngine.Vector3 val_7 = val_14.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  val_6);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Quaternion val_11 = val_14.rotation;
        if((UnityEngine.Physics.BoxCast(center:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, halfExtents:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, direction:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.z, z = val_11.x}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, orientation:  new UnityEngine.Quaternion() {x = val_11.z, y = 0.5f}, maxDistance:  val_3.z)) == false)
        {
            goto label_12;
        }
        
        val_15 = val_15 + 1;
        if(0.targetValue <= val_6)
        {
            goto label_13;
        }
        
        label_12:
        val_15 = 0;
        goto label_14;
        label_2:
        val_15 = true;
        label_14:
        this.<东丂丗丞丗丑丂丂业>k__BackingField = val_15;
    }
    internal void 下丏且一三丐一丐不(丑与且丂下不万三业 丏丂丄丆丂东丝丆丏)
    {
        if(丏丂丄丆丂东丝丆丏 != null)
        {
                this.<丙不丂丛一丕丈丝丘>k__BackingField = 丏丂丄丆丂东丝丆丏.不与丒与下丏一上丁();
            this.<丞三丕三上且丆丆丒>k__BackingField = 丏丂丄丆丂东丝丆丏.丞丁下丛且丞丁丆丗();
        }
        else
        {
                this.<丙不丂丛一丕丈丝丘>k__BackingField = 0.不与丒与下丏一上丁();
            this.<丞三丕三上且丆丆丒>k__BackingField = 0.丞丁下丛且丞丁丆丗();
        }
        
        this.<业丗丅丑业一与下丁>k__BackingField = 丏丂丄丆丂东丝丆丏.丐与不专丕丌丐丄丐();
    }
    internal override float 丟不丑丈丆丏一丐丁()
    {
        return 20f;
    }
    public HelicopterEngine()
    {
        this.maxRotorForce = ;
        this.tailRotorForce = ;
        this.rotorRotationVelocity = 400f;
        this.maxRotorSpeed = 1005f;
        this.minRotorForce = 960f;
        this.startingDelayTime = 2f;
        this.descentDelayTime = 2f;
        this.maxRotationSpeed = 10f;
        this.maxRotationSpeedTime = 0.2f;
        this.rotationSpeedLossTime = 0.2f;
        this.maxForwardSpeed = 12f;
        this.maxBackwardSpeed = 12f;
        this.maxHorizontalSpeedTime = 1f;
        this.horizontalSpeedLossTime = 1f;
        this.maxUpSpeed = ;
        this.maxDownSpeed = ;
        this.maxVerticalSpeedTime = 0.5f;
        this.verticalSpeedLossTime = 0.5f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丟丛丁丆丆丌丄一且 = val_1;
        mem[1152921539392134132] = val_1.y;
        mem[1152921539392134136] = val_1.z;
        this.<东丂丗丞丗丑丂丂业>k__BackingField = true;
    }

}
