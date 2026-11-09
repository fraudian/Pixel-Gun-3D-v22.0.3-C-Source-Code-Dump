using UnityEngine;
internal sealed class VeteranlLootBoxUI : LootBoxUI
{
    // Fields
    internal VeteranlLootBoxUI.且世丈业丘丆不上丄 丁三世不世专丏丐丘;
    
    // Properties
    internal VeteranlLootBoxUI.且世丈业丘丆不上丄 与下丞丏专丅丐一丕 { get; }
    
    // Methods
    internal VeteranlLootBoxUI.且世丈业丘丆不上丄 丄一专丛丙不业三丞()
    {
        return (且世丈业丘丆不上丄)this.丁三世不世专丏丐丘;
    }
    internal override void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 一与且丐丝丘与丆丑)
    {
        this.丈且东丑丂且万丒丅(一与且丐丝丘与丆丑:  一与且丐丝丘与丆丑);
        this.丁三世不世专丏丐丘 = this.三丟丛一丑丂丈东一();
    }
    private VeteranlLootBoxUI.且世丈业丘丆不上丄 三丟丛一丑丂丈东一()
    {
        var val_6;
        if(PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丄丛丒业丙万丅丏丌() != false)
        {
                var val_5 = ((PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丐下专丑丕一丁丛东() & true) != 0) ? (1 + 1) : 1;
            return (且世丈业丘丆不上丄)val_6;
        }
        
        val_6 = 3;
        return (且世丈业丘丆不上丄)val_6;
    }
    public VeteranlLootBoxUI()
    {
    
    }

}
