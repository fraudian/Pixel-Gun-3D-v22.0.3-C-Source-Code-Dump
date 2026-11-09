using UnityEngine;
public class RPG_Controller : MonoBehaviour
{
    // Fields
    public static RPG_Controller instance;
    public UnityEngine.CharacterController characterController;
    public float walkSpeed;
    public float turnSpeed;
    public float jumpHeight;
    public float gravity;
    public float fallingThreshold;
    private UnityEngine.Vector3 丝三丈丈不丑业丁丕;
    private UnityEngine.Vector3 丘下丈世世丂万万丒;
    private UnityEngine.Vector3 七丅丗丆丒丌丑丝不;
    
    // Methods
    private void Awake()
    {
        var val_3;
        RPG_Controller.instance = this;
        UnityEngine.Component val_1 = this.GetComponent(type:  "CharacterController");
        val_3 = 0;
        this.characterController = ;
        RPG_Camera.CameraSetup();
    }
    private void Update()
    {
        if(UnityEngine.Camera.main == 0)
        {
                return;
        }
        
        if(this.characterController == 0)
        {
                UnityEngine.Debug.Log(message:  "Error: No Character Controller component found! Please add one to the GameObject which has this script attached.");
            return;
        }
        
        this.世且丘丏丑丙下丁丒();
        this.且丞丄下且丅三与不();
    }
    private void 世且丘丏丑丙下丁丒()
    {
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        var val_32;
        var val_33;
        val_27 = 0f;
        val_28 = 0f;
        if((UnityEngine.Input.GetButton(buttonName:  "Horizontal Strafe")) != false)
        {
                if((UnityEngine.Input.GetAxis(axisName:  "Horizontal Strafe")) < 0)
        {
                val_28 = -1f;
        }
        else
        {
                val_28 = 0f;
            if((UnityEngine.Input.GetAxis(axisName:  "Horizontal Strafe")) > 0f)
        {
                val_28 = 1f;
        }
        
        }
        
        }
        
        if((UnityEngine.Input.GetButton(buttonName:  "Vertical")) != false)
        {
                if((UnityEngine.Input.GetAxis(axisName:  "Vertical")) < 0)
        {
                val_27 = -1f;
        }
        else
        {
                if((UnityEngine.Input.GetAxis(axisName:  "Vertical")) > 0f)
        {
                val_27 = 1f;
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  val_28, a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_29 = val_11.x;
        val_30 = val_11.y;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  ((UnityEngine.Input.GetMouseButton(button:  1)) != true) ? 1f : (val_27), a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_31 = val_29;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        this.丝三丈丈不丑业丁丕 = val_14;
        mem[1152921539856978328] = val_14.y;
        mem[1152921539856978332] = val_14.z;
        if(RPG_Animation.instance != 0)
        {
                val_27 = this.丝三丈丈不丑业丁丕;
            if(val_29 > 0f)
        {
                var val_16 = (val_27 > 0f) ? 6 : (0 + 1);
            val_33 = 5;
        }
        else
        {
                if(val_29 < 0)
        {
                var val_17 = (val_27 > 0f) ? 8 : 2;
            val_33 = 7;
        }
        else
        {
                val_32 = ((val_27 > 0f) ? 1 : 0) << 2;
            val_33 = 3;
        }
        
        }
        
            RPG_Animation.instance.currentMoveDir = (val_27 < 0) ? (val_33) : (val_32);
        }
        
        if(this.characterController.isGrounded != false)
        {
                UnityEngine.Vector3 val_22 = this.transform.TransformDirection(direction:  new UnityEngine.Vector3() {x = this.丝三丈丈不丑业丁丕, y = val_29, z = val_30});
            this.丘下丈世世丂万万丒 = val_22;
            mem[1152921539856978340] = val_22.y;
            mem[1152921539856978344] = val_22.z;
            float val_28 = System.Math.Abs(val_22.x);
            val_28 = System.Math.Abs(this.丝三丈丈不丑业丁丕) + val_28;
            val_31 = this.丘下丈世世丂万万丒;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = this.丝三丈丈不丑业丁丕}, d:  this.walkSpeed);
            this.丘下丈世世丂万万丒 = val_23;
            mem[1152921539856978344] = val_23.z;
            mem[1152921539856978340] = this.fallingThreshold;
            if((UnityEngine.Input.GetButtonDown(buttonName:  "Jump")) != false)
        {
                mem[1152921539856978340] = this.jumpHeight;
            if(RPG_Animation.instance != 0)
        {
                RPG_Animation.instance.Jump();
        }
        
        }
        
        }
        
        float val_26 = UnityEngine.Input.GetAxis(axisName:  "Horizontal");
        val_26 = val_26 * this.turnSpeed;
        mem[1152921539856978352] = val_26;
    }
    private void 且丞丄下且丅三与不()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.gravity * val_1;
        float val_2 = S10 - val_1;
        mem[1152921539857110820] = val_2;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丘下丈世世丂万万丒, y = val_2, z = V8.16B}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.CollisionFlags val_5 = this.characterController.Move(motion:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = this.七丅丗丆丒丌丑丝不, y = val_4.y, z = val_4.z});
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                return;
        }
        
        null.RotateWithCharacter();
    }
    public RPG_Controller()
    {
        this.fallingThreshold = -6f;
        this.walkSpeed = ;
        this.turnSpeed = ;
        this.jumpHeight = 10f;
        this.gravity = 20f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.七丅丗丆丒丌丑丝不 = val_1;
        mem[1152921539857235120] = val_1.y;
        mem[1152921539857235124] = val_1.z;
    }

}
