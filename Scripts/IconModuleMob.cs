using UnityEngine;
internal class IconModuleMob : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _energyModuleIcon;
    private UnityEngine.GameObject _magicModuleIcon;
    private UnityEngine.GameObject _kinetickModuleIcon;
    
    // Methods
    internal void 丈丛丘丟丟丛丈下丆(RilisoftBot.七一丙世丏下丐丕世 丗与丟上上丑专世丗)
    {
        this._energyModuleIcon.SetActive(value:  false);
        this._kinetickModuleIcon.SetActive(value:  false);
        this._magicModuleIcon.SetActive(value:  false);
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        if(丗与丟上上丑专世丗 == 1)
        {
            goto label_7;
        }
        
        if(丗与丟上上丑专世丗 == 3)
        {
            goto label_8;
        }
        
        if(丗与丟上上丑专世丗 != 2)
        {
                return;
        }
        
        if(this._energyModuleIcon != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        this._energyModuleIcon.SetActive(value:  true);
        return;
        label_7:
        if(this._kinetickModuleIcon != null)
        {
            goto label_13;
        }
        
        goto label_14;
        label_8:
        if(this._magicModuleIcon != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    public IconModuleMob()
    {
    
    }

}
