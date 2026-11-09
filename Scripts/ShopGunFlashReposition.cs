using UnityEngine;
public class ShopGunFlashReposition : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 shopPosition;
    
    // Methods
    public void Reposition()
    {
        this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = this.shopPosition, y = V9.16B, z = V10.16B};
    }
    public ShopGunFlashReposition()
    {
    
    }

}
