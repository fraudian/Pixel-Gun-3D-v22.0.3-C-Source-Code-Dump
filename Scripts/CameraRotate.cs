using UnityEngine;
public class CameraRotate : PGBehaviour
{
    // Fields
    public float Speed;
    
    // Methods
    private void FixedUpdate()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        this.丌丟丄业且三丛丕丄().Rotate(axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, angle:  this.Speed * UnityEngine.Time.deltaTime, relativeTo:  0);
    }
    public CameraRotate()
    {
        this.Speed = 8f;
    }

}
