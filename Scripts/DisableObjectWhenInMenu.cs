using UnityEngine;
internal sealed class DisableObjectWhenInMenu : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> disabledObjects;
    
    // Methods
    private void Update()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                this.enabled = false;
            return;
        }
        
        val_5 = null;
        val_5 = null;
        if(activeInHierarchy != false)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_13;
        }
        
        }
        
        this.下三与丙丒一丞丐丒();
        return;
        label_13:
        this.丆上丛专万丑与丄下();
    }
    private void 丟上丟丈七万丒丝丒(bool 下丞丌下专丘丗丂一)
    {
        if(下丞丌下专丘丗丂一 != false)
        {
                this.丆上丛专万丑与丄下();
            return;
        }
        
        this.下三与丙丒一丞丐丒();
    }
    private void 下三与丙丒一丞丐丒()
    {
        goto label_1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disabledObjects.Item[0], 丏业丟一东丂东丘丛:  true);
        0 = 1;
        label_1:
        if(0 < this.disabledObjects.Count)
        {
            goto label_6;
        }
    
    }
    private void 丆上丛专万丑与丄下()
    {
        goto label_1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.disabledObjects.Item[0], 丏业丟一东丂东丘丛:  false);
        0 = 1;
        label_1:
        if(0 < this.disabledObjects.Count)
        {
            goto label_6;
        }
    
    }
    public DisableObjectWhenInMenu()
    {
    
    }

}
