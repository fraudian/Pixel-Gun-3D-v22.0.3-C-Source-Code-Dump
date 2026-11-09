using UnityEngine;
public class ShopShootButtonController : MonoBehaviour
{
    // Fields
    private bool <丈且丞丟丏七丈丑丝>k__BackingField;
    
    // Properties
    public bool 丆丟专丑丁丒丁上丙 { get; set; }
    
    // Methods
    public bool get_isPressed()
    {
        return (bool)this.<丈且丞丟丏七丈丑丝>k__BackingField;
    }
    private void 丌丞丏丁丝丙丅专丞(bool 丙业与丙丗丝不丈东)
    {
        this.<丈且丞丟丏七丈丑丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        this.<丈且丞丟丏七丈丑丝>k__BackingField = 万东丂丒且丅丛丑丕;
    }
    private void OnDisable()
    {
        this.<丈且丞丟丏七丈丑丝>k__BackingField = false;
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == false)
        {
                return;
        }
        
        this.<丈且丞丟丏七丈丑丝>k__BackingField = false;
    }
    public ShopShootButtonController()
    {
    
    }

}
