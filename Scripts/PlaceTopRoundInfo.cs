using UnityEngine;
internal sealed class PlaceTopRoundInfo : PGBehaviour, 丏下一丌且三与丘丘
{
    // Fields
    private string _iconName;
    private int 东七丛丝丑专世丏三;
    
    // Methods
    public string GetInfo()
    {
        var val_6;
        WeaponManager val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        val_7 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_7 != 0)
        {
                val_8 = null;
            val_8 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            if(val_7 != 0)
        {
                val_9 = null;
            val_9 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            string val_5 = 业七业丅丅丝万丕丝() + 1.ToString();
            return (string)val_10;
        }
        
        }
        
        val_10 = "1";
        return (string)val_10;
    }
    public string GetNameSprite()
    {
        return (string)this._iconName;
    }
    public void SetIndexMiniPool(int 丞世不丒下上上丝丑)
    {
        this.东七丛丝丑专世丏三 = 丞世不丒下上上丝丑;
    }
    public int GetIndexMiniPool()
    {
        return (int)this.东七丛丝丑专世丏三;
    }
    public PlaceTopRoundInfo()
    {
        this._iconName = "";
    }

}
