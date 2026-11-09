using UnityEngine;
public class FixedRotation : PGBehaviour
{
    // Fields
    public UnityEngine.Vector3 rotation;
    
    // Methods
    private void LateUpdate()
    {
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.rotation, y = V9.16B, z = V8.16B});
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
    }
    public FixedRotation()
    {
    
    }

}
