using UnityEngine;
internal class 七一丕下丐丒且丞丞 : IEqualityComparer<FortFieldItemInfo>
{
    // Methods
    public bool Equals(FortFieldItemInfo 三丟东丕丄丄下下丑, FortFieldItemInfo 丒丒丄丁且丄丆丂丌)
    {
        if(三丟东丕丄丄下下丑 == null)
        {
                return false;
        }
        
        if(丒丒丄丁且丄丆丂丌 == null)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.name, b:  丒丒丄丁且丄丆丂丌.name);
    }
    public int GetHashCode(FortFieldItemInfo 万且万且丑丗且丌丆)
    {
        var val_4;
        var val_5;
        var val_6;
        if(万且万且丑丗且丌丆.name != null)
        {
                val_4 = 0;
        }
        else
        {
                val_4 = 0;
        }
        
        if((1842527328 & 1) != 0)
        {
                int val_2 = val_4.丙东专丂世丈丏丁丂() + 391;
            val_5 = 0;
        }
        else
        {
                val_5 = 0;
        }
        
        if((1842527336 & 1) != 0)
        {
                int val_3 = val_5.丙东专丂世丈丏丁丂();
            return (int)val_6;
        }
        
        val_6 = 0;
        return (int)val_6;
    }
    public 七一丕下丐丒且丞丞()
    {
    
    }

}
