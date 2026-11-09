using UnityEngine;
public sealed class BackFromNetworkTable : MonoBehaviour
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void BackFromNetworkTable::OnClick()), 与且专丈不万东一万:  "Back From Network Table");
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnClick()
    {
        ExperienceController val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                val_14 = BankController.丑七不且上丗丁一世();
            if(val_14.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                val_14 = ExpController.丑七不且上丗丁一世();
            if(val_14.下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_14 = 1152921505079742464;
        val_15 = null;
        val_15 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_14 = ExperienceController.sharedController;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 != false)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myTable != 0)
        {
                val_18 = null;
            val_18 = null;
            GetComponent<NetworkStartTable>().丗一丄七世不专丞丟();
            return;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        bool val_13 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丞丁丛丐不丞丗丒三();
    }
    public BackFromNetworkTable()
    {
    
    }

}
