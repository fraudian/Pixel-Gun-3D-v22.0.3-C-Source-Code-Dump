using UnityEngine;
public class VehicleLandingPoint : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform thisTransform;
    
    // Methods
    public bool IsFree(UnityEngine.BoxCollider 三丒丐丟世丈丆丗丑)
    {
        UnityEngine.Transform val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_25;
        val_21 = this.thisTransform;
        UnityEngine.Vector3 val_1 = val_21.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.305f);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        val_22 = val_4.x;
        val_23 = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  1.39f);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_4.y, z = val_23}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_24 = val_7.y;
        if((UnityEngine.Physics.CheckCapsule(start:  new UnityEngine.Vector3() {x = val_22, y = val_4.y, z = val_23}, end:  new UnityEngine.Vector3() {x = val_7.x, y = val_24, z = val_7.z}, radius:  0.61f, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) == false)
        {
            goto label_6;
        }
        
        label_23:
        val_25 = 0;
        return (bool)val_25;
        label_6:
        if((UnityEngine.Object.op_Implicit(exists:  三丒丐丟世丈丆丗丑)) == false)
        {
            goto label_20;
        }
        
        UnityEngine.Vector3 val_12 = 三丒丐丟世丈丆丗丑.transform.position;
        UnityEngine.Vector3 val_13 = 三丒丐丟世丈丆丗丑.center;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_21 = this.thisTransform;
        UnityEngine.Vector3 val_15 = val_21.position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        val_22 = val_16.x;
        val_23 = val_16.z;
        UnityEngine.Vector3 val_17 = this.thisTransform.position;
        val_24 = val_17.y;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_17.x, y = val_24, z = val_17.z}, direction:  new UnityEngine.Vector3() {x = val_22, y = val_16.y, z = val_23}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  Infinityf, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) == false)
        {
            goto label_20;
        }
        
        if(0 != 三丒丐丟世丈丆丗丑)
        {
            goto label_23;
        }
        
        label_20:
        val_25 = 1;
        return (bool)val_25;
    }
    public VehicleLandingPoint()
    {
    
    }

}
