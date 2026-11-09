using UnityEngine;
internal sealed class AutoAimTurretRocket : BaseMovementTurretRocket
{
    // Methods
    private void Awake()
    {
        mem[1152921540130149024] = this.GetComponent<UnityEngine.Rigidbody>();
    }
    protected override void 世丙丟丗丆丂东且三()
    {
        this.世丙丟丗丆丂东且三();
        if(137125888 == 0)
        {
                return;
        }
        
        if(137125888 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.丌丟丄业且三丛丕丄();
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = val_3.position;
        UnityEngine.Transform val_6 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_7 = val_6.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  27f);
        val_6.AddForce(force:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_10 = val_6.velocity;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  27f);
        val_6.velocity = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        this = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_13 = val_6.velocity;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        this.rotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
    }
    public AutoAimTurretRocket()
    {
    
    }

}
