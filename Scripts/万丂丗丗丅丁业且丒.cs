using UnityEngine;
private sealed class ClanGovernorController.万丂丗丗丅丁业且丒
{
    // Fields
    public System.Collections.Generic.KeyValuePair<ItemRarity, int> 丐丏东世不丅丌且万;
    
    // Methods
    public ClanGovernorController.万丂丗丗丅丁业且丒()
    {
    
    }
    internal bool 三丄丆丐丙丛不丅丄(PGCompany.丟丒且且一丛丝丐丞.丂丅上与丑丁与丕丝 丐丁丒三一丘不丞丙)
    {
        var val_8;
        var val_9;
        val_8 = 丐丁丒三一丘不丞丙;
        if((val_8.丝且丘丒不丌且丂丈().ContainsKey(下上丐丆丝丟丝丒不:  this.丐丏东世不丅丌且万.丙东专丂世丈丏丁丂())) != false)
        {
                val_8 = val_8.丝且丘丒不丌且丂丈();
            var val_7 = (val_8.Item[this.丐丏东世不丅丌且万.丙东专丂世丈丏丁丂()] > 0) ? 1 : 0;
            return (bool)val_9;
        }
        
        val_9 = 0;
        return (bool)val_9;
    }

}
