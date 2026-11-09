using UnityEngine;
public class OpenModuleChestUIController : MonoBehaviour
{
    // Fields
    private OnOpenModuleChestUI 与丝丁世万丈三不丅;
    
    // Properties
    private OnOpenModuleChestUI 丗丟丛世丅丛丘东丐 { get; }
    
    // Methods
    private OnOpenModuleChestUI 丄丂丅丐丆业世东丕()
    {
        OnOpenModuleChestUI val_5;
        if(this.与丝丁世万丈三不丅 == 0)
        {
                OnOpenModuleChestUI val_2 = UnityEngine.Resources.Load<OnOpenModuleChestUI>(path:  "Modules/OpenModuleChestUI");
            this.与丝丁世万丈三不丅 = val_2;
            this.与丝丁世万丈三不丅 = UnityEngine.Object.Instantiate<OnOpenModuleChestUI>(original:  val_2, parent:  this.transform);
            return val_5;
        }
        
        val_5 = this.与丝丁世万丈三不丅;
        return val_5;
    }
    private void Awake()
    {
        丐东不丅丂丂丅丙不.不丂业丆下不丗万丁(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三丘丌上丁万丏丛丟, System.Collections.Generic.List<Rilisoft.OfferItem>>(object:  this, method:  System.Void OpenModuleChestUIController::三丞丕丙下丘不丛不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)));
    }
    private void OnDestroy()
    {
        丐东不丅丂丂丅丙不.丑丂丁丘且万东丙东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三丘丌上丁万丏丛丟, System.Collections.Generic.List<Rilisoft.OfferItem>>(object:  this, method:  System.Void OpenModuleChestUIController::三丞丕丙下丘不丛不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)));
    }
    private void 三丞丕丙下丘不丛不(PGCompany.三丘丌上丁万丏丛丟 丐下丝丘丑丟丟丗丌, System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三)
    {
        UnityEngine.Transform val_10;
        var val_11;
        UnityEngine.Object val_12;
        val_10 = 0;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_11 = null;
            val_11 = null;
            val_10 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 1504];
            val_10 = ShopNGUIController.丏丙丅丕一丑丕丑丑.moduleInsertPanelTransform;
        }
        
        val_12 = BankController.丑七不且上丗丁一世();
        if(val_12 != 0)
        {
                val_12 = BankController.丑七不且上丗丁一世();
            if(val_12.上丙丆不丂丂丄一丂() != false)
        {
                BankController val_6 = BankController.丑七不且上丗丁一世();
            val_10 = val_6.bankViewCommon.transform;
        }
        
        }
        
        if(val_10 == 0)
        {
                return;
        }
        
        this.丄丂丅丐丆业世东丕().三丞丕丙下丘不丛不(丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 上业丟世三与七七三:  上业丟世三与七七三, 丈东丘丏与丌东东下:  val_10);
    }
    public OpenModuleChestUIController()
    {
    
    }

}
