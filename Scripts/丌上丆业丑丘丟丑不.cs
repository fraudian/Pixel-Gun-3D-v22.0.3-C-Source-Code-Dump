using UnityEngine;
private sealed class InfoWindowController.丌上丆业丑丘丟丑不 : InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private readonly string 三丄丗世丄丒丟丒丞;
    
    // Methods
    public InfoWindowController.丌上丆业丑丘丟丑不(AchieveBox 不丌丗丂丆业丂丏世, string 三丕业丛丛丙专专丙)
    {
        int val_2 = val_1;
        val_1 = new System.Object();
        mem[1152921538052320984] = 不丌丗丂丆业丂丏世;
        if(val_2 == null)
        {
                val_2 = System.String.alignConst;
        }
        
        this.三丄丗世丄丒丟丒丞 = val_2;
    }
    public override void 一丌一丞世不下丄专()
    {
        InfoWindowController val_1 = InfoWindowController.丑七不且上丗丁一世();
        if(val_1._clanSiegeMessagePanel == 0)
        {
                return;
        }
        
        InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
        val_3._clanSiegeMessagePanel.业东三丒丝丐丏丐且(不丆业丏上丐与丌业:  this.三丄丗世丄丒丟丒丞);
        this.一丌一丞世不下丄专();
    }

}
