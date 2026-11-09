using UnityEngine;
internal class 丛丂世丟丘丏万丛业 : IEqualityComparer<ClanTankEquipInfo>
{
    // Methods
    public bool Equals(ClanTankEquipInfo 三丟东丕丄丄下下丑, ClanTankEquipInfo 丒丒丄丁且丄丆丂丌)
    {
        if(三丟东丕丄丄下下丑 == null)
        {
                return false;
        }
        
        if(丒丒丄丁且丄丆丂丌 == null)
        {
                return false;
        }
        
        if(三丟东丕丄丄下下丑.placeId != 丒丒丄丁且丄丆丂丌.placeId)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.itemSettingsId, b:  丒丒丄丁且丄丆丂丌.itemSettingsId);
    }
    public int GetHashCode(ClanTankEquipInfo 万且万且丑丗且丌丆)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 万且万且丑丗且丌丆.placeId.GetHashCode();
        if(万且万且丑丗且丌丆.itemSettingsId != null)
        {
                val_6 = 0;
        }
        else
        {
                val_6 = 0;
        }
        
        if(((-2094711696) & 1) != 0)
        {
                val_5 = 8993 + (val_5 * 23);
            int val_3 = val_5 + val_6.丙东专丂世丈丏丁丂();
            val_7 = 0;
        }
        else
        {
                val_7 = 0;
        }
        
        if(((-2094711688) & 1) != 0)
        {
                int val_4 = val_7.丙东专丂世丈丏丁丂();
            return (int)val_8;
        }
        
        val_8 = 0;
        return (int)val_8;
    }
    public 丛丂世丟丘丏万丛业()
    {
    
    }

}
