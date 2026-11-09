using UnityEngine;
internal class 世丝丛丕下业业丗丛 : IEqualityComparer<SquareFieldCellData>
{
    // Methods
    public bool Equals(SquareFieldCellData 三丟东丕丄丄下下丑, SquareFieldCellData 丒丒丄丁且丄丆丂丌)
    {
        if(三丟东丕丄丄下下丑 == null)
        {
                return false;
        }
        
        if(丒丒丄丁且丄丆丂丌 == null)
        {
                return false;
        }
        
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  new UnityEngine.Vector3() {x = 三丟东丕丄丄下下丑.Position, y = V9.16B, z = V13.16B}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = 丒丒丄丁且丄丆丂丌.Position, y = V10.16B, z = V11.16B}, 丞丞丙且丄不丈丌三:  0.001f)) == false)
        {
                return false;
        }
        
        if(三丟东丕丄丄下下丑.Rotation != 丒丒丄丁且丄丆丂丌.Rotation)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.itemSettingsId, b:  丒丒丄丁且丄丆丂丌.itemSettingsId);
    }
    public int GetHashCode(SquareFieldCellData 万且万且丑丗且丌丆)
    {
        var val_10;
        int val_10 = (int)万且万且丑丗且丌丆.Position.丙东专丂世丈丏丁丂();
        int val_5 = val_10 + ((int)万且万且丑丗且丌丆.Position.丙东专丂世丈丏丁丂() * 23);
        val_10 = (int)万且万且丑丗且丌丆.Position.丙东专丂世丈丏丁丂() + (val_5 * 23);
        if(万且万且丑丗且丌丆.ItemSettings != null)
        {
                val_10 = 万且万且丑丗且丌丆.ItemSettings.Index.GetHashCode();
        }
        else
        {
                val_10 = 0;
        }
        
        val_10 = 4757297 + (val_10 * 23);
        int val_9 = 万且万且丑丗且丌丆.Rotation.GetHashCode();
        val_5 = val_10 + val_10;
        val_9 = val_9 + (val_5 * 23);
        return (int)val_9;
    }
    public 世丝丛丕下业业丗丛()
    {
    
    }

}
