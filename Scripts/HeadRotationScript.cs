using UnityEngine;
public class HeadRotationScript : PGBehaviour
{
    // Fields
    public UnityEngine.Transform gunPoint;
    private float 三且丆丐丝丆七丙丝;
    
    // Methods
    private void Start()
    {
        this.三且丆丐丝丆七丙丝 = 0f;
    }
    private void LateUpdate()
    {
        UnityEngine.Quaternion val_1 = this.gunPoint.localRotation;
        val_1.x = val_1.x * (-0.5f);
        float val_5 = 180f;
        val_5 = val_1.x + val_5;
        this.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        this.三且丆丐丝丆七丙丝 = UnityEngine.Mathf.Lerp(a:  this.三且丆丐丝丆七丙丝, b:  (val_1.x < 0) ? (val_5) : (val_1.x), t:  0.2f);
    }
    public HeadRotationScript()
    {
    
    }

}
