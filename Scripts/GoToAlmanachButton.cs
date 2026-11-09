using UnityEngine;
public class GoToAlmanachButton : MonoBehaviour
{
    // Fields
    private int 下且与丐上丟七丑丏;
    internal 丙且上东下丏丏丟下 丂三下七万丛一丁丕;
    internal CategoryNames 三丟三丈丛且不丄七;
    internal FilterMaps 丙业丟七丕丑丄丗东;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(int 丞世不丒下上上丝丑)
    {
        this.下且与丐上丟七丑丏 = 丞世不丒下上上丝丑;
    }
    internal void 丈且东丑丂且万丒丅(丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 一专七丟丏且丑丄下, FilterMaps 专丆丌丛东一不丑丙)
    {
        this.丂三下七万丛一丁丕 = 丑丝丏丂且不下一东;
        this.三丟三丈丛且不丄七 = 一专七丟丏且丑丄下;
        this.丙业丟七丕丑丄丗东 = 专丆丌丛东一不丑丙;
        this.下且与丐上丟七丑丏 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丑丝丏丂且不下一东.业上丙丞丐丄丆丅七()).业东丅东丌上丗丑不();
    }
    public void GoToAlmanach()
    {
        object val_8;
        var val_9;
        var val_10;
        var val_11;
        PGCompany.丆下丐丁丏世丈上丟 val_12;
        val_8 = this;
        if(上且丁万与丌下丐上.丑与七丁丏丘丁丂且() == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  public System.Void GoToAlmanachButton::GoToAlmanach()))) == true)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_9 = null;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丁七丁丞丞丟丒业丅 = this.丂三下七万丛一丁丕;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_9 = null;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丌不丒万万丟丞上与 = this.三丟三丈丛且不丄七;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丕丏丑丏丏丂与东丏 = this.丙业丟七丕丑丄丗东;
        val_10 = null;
        val_10 = null;
        AlmanachMainUI.丈七丝丑丑七且丏丗 = this.下且与丐上丟七丑丏;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_8 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_11 = 37;
        }
        else
        {
                val_8 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_11 = 37;
            val_12;
        }
        
        val_8.ForceShowBanner(丌丅丕一丛丛丄一万:  37, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public GoToAlmanachButton()
    {
        this.下且与丐上丟七丑丏 = 0;
        this.丙业丟七丕丑丄丗东 = 0;
    }

}
