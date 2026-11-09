using UnityEngine;
public class CarShop : MonoBehaviour
{
    // Fields
    public string ShopAnimationClipName;
    public UnityEngine.Animation Animation;
    public UnityEngine.Transform PlayerPoint;
    public float ShopYOffsetRight;
    public float ShopXOffsetUp;
    public UnityEngine.Quaternion InitialRotation;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Quaternion val_2 = this.transform.rotation;
        this.InitialRotation = val_2;
        mem[1152921525580613420] = val_2.y;
        mem[1152921525580613424] = val_2.z;
        mem[1152921525580613428] = val_2.w;
    }
    public CarShop()
    {
        this.ShopAnimationClipName = "Profile";
    }

}
