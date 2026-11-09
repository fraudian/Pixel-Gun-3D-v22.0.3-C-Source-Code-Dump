using UnityEngine;
private sealed class ShopNGUIController.丈丝丏丄丗世丄七一
{
    // Fields
    public ShopNGUIController 丝且与丝丒丟万丁专;
    public 丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞;
    
    // Methods
    public ShopNGUIController.丈丝丏丄丗世丄七一()
    {
    
    }
    internal void 业一丄丑丙丗东丈一()
    {
        var val_7;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UIPlaySound val_2 = this.丝且与丝丒丟万丁专.unlockButton.GetComponent<UIPlaySound>();
            if(val_2 != 0)
        {
                val_2.Play();
        }
        
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  26);
        this.丝且与丝丒丟万丁专.不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  "CustomSkinID", 七丆丒与丗丌丄且丂:  8));
        Rilisoft.一丟专且三万丞丁丂.丐丌丟与丈丒丅丑丘(丒世丘丘上丆丝东丞:  this.丒世丘丘上丆丝东丞);
        if(this.丝且与丝丒丟万丁专.丁丝丁上丂上专丐业 == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad != false)
        {
                return;
        }
        
        this.丝且与丝丒丟万丁专.下一一丅丏下东丄丏();
    }
    internal void 丅世丒丄万七丕且丈()
    {
        this.丝且与丝丒丟万丁专.专丞丑丑丂丟下丌丁();
    }

}
