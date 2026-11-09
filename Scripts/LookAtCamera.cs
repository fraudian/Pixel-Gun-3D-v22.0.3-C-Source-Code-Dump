using UnityEngine;
public class LookAtCamera : MonoBehaviour
{
    // Methods
    private void Update()
    {
        UnityEngine.Quaternion val_4 = UnityEngine.Camera.main.transform.rotation;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    public LookAtCamera()
    {
    
    }

}
