using UnityEngine;
private class SkinnedMeshCombiner.万丅丐不且丌专与丐
{
    // Fields
    public UnityEngine.Texture2D 丌三丘丗下东丐东丑;
    public UnityEngine.Rect[] 七丛丄丕丅万万丘丑;
    public UnityEngine.Texture2D[] 业丑世丏专世丐丟丐;
    
    // Methods
    public int 与丈丑万丕世世丑业(UnityEngine.Texture2D 与万丆丛丒万丝丙丑)
    {
        var val_2 = 0;
        do
        {
            if(val_2 >= this.业丑世丏专世丐丟丐.Length)
        {
                return (int)val_2 - 1;
        }
        
            val_2 = val_2 + 1;
        }
        while(this.业丑世丏专世丐丟丐[0] != 与万丆丛丒万丝丙丑);
        
        return (int)val_2 - 1;
    }
    public SkinnedMeshCombiner.万丅丐不且丌专与丐()
    {
        this.丌三丘丗下东丐东丑 = new UnityEngine.Texture2D(width:  16, height:  16);
        this.七丛丄丕丅万万丘丑 = new UnityEngine.Rect[0];
        this.业丑世丏专世丐丟丐 = new UnityEngine.Texture2D[0];
    }

}
