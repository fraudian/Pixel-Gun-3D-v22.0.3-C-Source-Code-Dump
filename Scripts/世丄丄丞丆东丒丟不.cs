using UnityEngine;
private sealed class ShopNGUIController.世丄丄丞丆东丒丟不
{
    // Fields
    public System.EventHandler 丑丘丐丂不丐丒丟且;
    public ShopNGUIController.丄东丐丈丈三不上不 东丟且丗且三专丙丁;
    
    // Methods
    public ShopNGUIController.世丄丄丞丆东丒丟不()
    {
    
    }
    internal void 丂丑丗东万丑且丛丝(object 专丙丏丄与丛下丛丒, System.EventArgs 丏一丕七丆丘一世丙)
    {
        string val_27;
        bool val_28;
        ShopNGUIController.丄东丐丈丈三不上不 val_29;
        丙且上东下丏丏丟下 val_30;
        if(BankController.丑七不且上丗丁一世().上丌业丘下丞丂下丐() != false)
        {
                UnityEngine.Debug.LogWarning(message:  "InterfaceEnabledCoroutineLocked");
            return;
        }
        
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  this.丑丘丐丂不丐丒丟且);
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        if(this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.mainPanel != 0)
        {
                this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.mainPanel.SetActive(value:  true);
        }
        
        if(this.东丟且丗且三专丙丁.丒七丒丌世丘丑丂七 != null)
        {
                this.东丟且丗且三专丙丁.丒七丒丌世丘丑丂七.Invoke();
        }
        
        if(this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() == null)
        {
                return;
        }
        
        if(this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑() == null)
        {
            goto label_44;
        }
        
        if(this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌() != 150000)
        {
                if(this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().丒万丕七专不丏丞丌() != 140000)
        {
            goto label_44;
        }
        
        }
        
        丛且专丞丗丆丙丒万 val_15 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七()];
        if(val_15.上七不丅丈丁不丛丝 == null)
        {
            goto label_44;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_15.上七不丅丈丁不丛丝.丟丁业专下丈专丐七)) == false)
        {
            goto label_47;
        }
        
        val_27 = 0;
        goto label_48;
        label_44:
        val_27 = 0;
        val_28 = 0;
        goto label_49;
        label_47:
        val_27 = val_15.上七不丅丈丁不丛丝.丟丁业专下丈专丐七;
        label_48:
        val_28 = 1;
        label_49:
        val_29 = this.东丟且丗且三专丙丁;
        if(this.东丟且丗且三专丙丁 != null)
        {
            goto label_51;
        }
        
        val_29 = this.东丟且丗且三专丙丁;
        if(val_29 == null)
        {
            goto label_52;
        }
        
        label_51:
        if(val_28 != 0)
        {
                val_28 = (~(丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑().业上丙丞丐丄丆丅七()))) & 1;
        }
        
        this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.丅上下万专丕丝丅丙(与丝丕与丙不与丗丆:  this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑(), 丒七丞丄丟且丂丆下:  val_27, 下丈丝丁丟下世丐丒:  val_28);
        this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.丙丑丘业丕丗丗不丘();
        val_30 = 1152921505035919360;
        if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟 != 0)
        {
                if(ArmoryInfoScreenController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy != false)
        {
                val_30 = this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.东丂丈与丄丛万丞丑();
            ArmoryInfoScreenController.丄丞丁丈与业上丞丟.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_30, 丁业丗丈丂七丟东与:  (~ShopNGUIController.丛世丛与丌不丈丐丐()) & 1, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
        }
        
        }
        
        this.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.gridScrollView.Restrict();
        return;
        label_52:
    }

}
