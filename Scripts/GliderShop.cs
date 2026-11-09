using UnityEngine;
public class GliderShop : MonoBehaviour
{
    // Fields
    public 丝东丗丞且不且上丙 GliderType;
    public string ShopAnimationClipName;
    public UnityEngine.SkinnedMeshRenderer Arms;
    public UnityEngine.GameObject StopObjectForSkinSetting;
    public UnityEngine.Animation Animation;
    public string customNameShopPersAnimation;
    public float ShopYOffset;
    public UnityEngine.Quaternion InitialRotation;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Quaternion val_2 = this.transform.rotation;
        this.InitialRotation = val_2;
        mem[1152921526168501552] = val_2.y;
        mem[1152921526168501556] = val_2.z;
        mem[1152921526168501560] = val_2.w;
    }
    public GliderShop()
    {
        this.ShopAnimationClipName = "Profile";
    }

}
