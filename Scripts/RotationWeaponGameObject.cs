using UnityEngine;
public class RotationWeaponGameObject : MonoBehaviour
{
    // Fields
    public RotationWeaponGameObject.七丘丟丑丞丟丁丌丒 axis;
    public float min;
    public float max;
    private FirstPersonControlSharp firstPersonControlToUpdateRotations;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    private UnityEngine.Vector3 丁丈丈一万三丌上丕;
    private UnityEngine.Quaternion 丘丛丟丘万上丁丌丌;
    private UnityEngine.Quaternion 丐丝丝丛业世丅丂丂;
    private float 下丈丌三且三丝丄与;
    
    // Methods
    private void Start()
    {
        七丘丟丑丞丟丁丌丒 val_13;
        UnityEngine.Transform val_14;
        float val_19;
        val_13 = this.axis;
        val_14 = this.transform;
        this.万一丂丐丄丁上与丟 = val_14;
        if(val_13 == 2)
        {
            goto label_1;
        }
        
        if(val_13 == 1)
        {
            goto label_2;
        }
        
        if(val_13 != 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
        goto label_9;
        label_1:
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
        goto label_9;
        label_2:
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        label_9:
        val_13 = this.axis;
        val_14 = this.万一丂丐丄丁上与丟;
        this.丁丈丈一万三丌上丕 = val_4;
        mem[1152921536142943788] = val_4.y;
        mem[1152921536142943792] = val_4.z;
        if(val_13 == 0)
        {
            goto label_12;
        }
        
        label_3:
        UnityEngine.Quaternion val_5 = val_14.localRotation;
        val_19 = val_5.z;
        if(val_13 != 1)
        {
            goto label_15;
        }
        
        val_19 = val_5.y;
        goto label_15;
        label_12:
        UnityEngine.Quaternion val_6 = val_14.localRotation;
        val_19 = val_6.x;
        label_15:
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.AngleAxis(angle:  val_19, axis:  new UnityEngine.Vector3() {x = this.丁丈丈一万三丌上丕, y = V9.16B, z = V10.16B});
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.AngleAxis(angle:  this.min, axis:  new UnityEngine.Vector3() {x = this.丁丈丈一万三丌上丕, y = val_7.z, z = V4.16B});
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, rhs:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        this.丘丛丟丘万上丁丌丌 = val_9;
        mem[1152921536142943800] = val_9.y;
        mem[1152921536142943804] = val_9.z;
        mem[1152921536142943808] = val_9.w;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.AngleAxis(angle:  this.max, axis:  new UnityEngine.Vector3() {x = this.丁丈丈一万三丌上丕, y = val_8.z, z = val_8.w});
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, rhs:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
        this.丐丝丝丛业世丅丂丂 = val_11;
        mem[1152921536142943816] = val_11.y;
        mem[1152921536142943820] = val_11.z;
        mem[1152921536142943824] = val_11.w;
        this.下丈丌三且三丝丄与 = this.max - this.min;
    }
    private void SetActiveFalse()
    {
        this.enabled = false;
    }
    private void LateUpdate()
    {
        FirstPersonControlSharp val_8;
        var val_9;
        var val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        七丘丟丑丞丟丁丌丒 val_15;
        float val_16;
        七丘丟丑丞丟丁丌丒 val_17;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_10 = null;
            val_10 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_668 != 0)
        {
                return;
        }
        
        }
        
        UnityEngine.Quaternion val_3 = this.万一丂丐丄丁上与丟.localRotation;
        if(this.axis == 0)
        {
            goto label_15;
        }
        
        if(this.axis != 1)
        {
            goto label_16;
        }
        
        val_11 = val_3.y;
        goto label_18;
        label_15:
        val_11 = val_3.x;
        goto label_18;
        label_16:
        val_11 = val_3.z;
        label_18:
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  val_11, axis:  new UnityEngine.Vector3() {x = this.丁丈丈一万三丌上丕, y = V9.16B, z = V10.16B});
        val_12 = val_4.x;
        float val_5 = UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, b:  new UnityEngine.Quaternion() {x = this.丘丛丟丘万上丁丌丌});
        float val_6 = UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_12, y = val_4.y, z = val_4.z, w = val_4.w}, b:  new UnityEngine.Quaternion() {x = this.丐丝丝丛业世丅丂丂});
        val_13 = val_6;
        if(val_5 <= this.下丈丌三且三丝丄与)
        {
                if(val_13 <= this.下丈丌三且三丝丄与)
        {
            goto label_22;
        }
        
        }
        
        val_14 = val_6;
        val_15 = this.axis;
        if(val_5 <= val_13)
        {
            goto label_23;
        }
        
        if(val_15 == 0)
        {
                val_15 = this.axis;
            val_14 = val_6;
        }
        
        if(val_15 != 1)
        {
            goto label_25;
        }
        
        val_15 = this.axis;
        val_16 = this.下丈丌三且三丝丄与;
        goto label_26;
        label_23:
        if(val_15 == 0)
        {
                val_17 = this.axis;
            val_14 = val_6;
        }
        
        if(val_17 != 1)
        {
            goto label_28;
        }
        
        val_17 = this.axis;
        val_16 = this.下丈丌三且三丝丄与;
        goto label_29;
        label_25:
        val_16 = this.下丈丌三且三丝丄与;
        label_26:
        if(val_15 != 2)
        {
            goto label_32;
        }
        
        goto label_33;
        label_28:
        val_16 = this.下丈丌三且三丝丄与;
        label_29:
        if(val_17 != 2)
        {
            goto label_32;
        }
        
        goto label_33;
        label_32:
        label_33:
        val_12 = val_14;
        val_13 = val_4.z;
        this.万一丂丐丄丁上与丟.localEulerAngles = new UnityEngine.Vector3() {x = val_12, y = this.下丈丌三且三丝丄与, z = val_13};
        label_22:
        if(this.firstPersonControlToUpdateRotations == 0)
        {
                return;
        }
        
        val_8 = this.firstPersonControlToUpdateRotations;
        val_8.丙丝世东不万丗万丗();
    }
    public RotationWeaponGameObject()
    {
    
    }

}
