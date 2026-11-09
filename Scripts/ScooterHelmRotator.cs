using UnityEngine;
public class ScooterHelmRotator : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform helmBone;
    private float maxRotation;
    private float rotationModifier;
    
    // Methods
    private void LateUpdate()
    {
        UnityEngine.Quaternion val_1 = this.helmBone.localRotation;
        UnityEngine.Quaternion val_3 = this.transform.rotation;
        float val_7 = -360f;
        val_7 = val_3.z + val_7;
        val_7 = this.rotationModifier * ((val_3.z > 180f) ? (val_7) : val_3.z);
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  val_1.x, y:  val_1.y, z:  UnityEngine.Mathf.Clamp(value:  val_7, min:  -this.maxRotation, max:  this.maxRotation));
        this.helmBone.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }
    public ScooterHelmRotator()
    {
        this.maxRotation = 0f;
        this.rotationModifier = 1f;
    }

}
