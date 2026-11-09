using UnityEngine;
internal class 丙万丝丙与下丄丑丗 : IEqualityComparer<丙专丒丄丅一丘上丌>
{
    // Methods
    public bool Equals(丙专丒丄丅一丘上丌 丏丆丑丗七丄丙丝与, 丙专丒丄丅一丘上丌 丒丈丙丐丏丕丆万丗)
    {
        var val_5;
        if(丏丆丑丗七丄丙丝与 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
        }
        else
        {
                val_5 = 0;
            return (bool)(丏丆丑丗七丄丙丝与.GiftCategoryType == 丒丈丙丐丏丕丆万丗.GiftCategoryType) ? 1 : 0;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        return (bool)(丏丆丑丗七丄丙丝与.GiftCategoryType == 丒丈丙丐丏丕丆万丗.GiftCategoryType) ? 1 : 0;
    }
    public int GetHashCode(丙专丒丄丅一丘上丌 丁丅丈丌丟世丗丗丟)
    {
        var val_4;
        if(丁丅丈丌丟世丗丗丟 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            return (int)丁丅丈丌丟世丗丗丟.GiftCategoryType.丙东专丂世丈丏丁丂();
        }
        
        val_4 = 0;
        return (int)丁丅丈丌丟世丗丗丟.GiftCategoryType.丙东专丂世丈丏丁丂();
    }
    public 丙万丝丙与下丄丑丗()
    {
    
    }

}
