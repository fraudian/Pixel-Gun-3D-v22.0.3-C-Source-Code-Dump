using UnityEngine;
public class 专丐下丁丘万丑丆万
{
    // Fields
    private static 专丐下丁丘万丑丆万 丝业丆丁业三丈丟东;
    internal static string 七丐三丝且与东丆丗;
    private System.Collections.Generic.List<int> 三丙下丂世一下丂三;
    private bool 丁丌丆丛业专丄丗万;
    
    // Properties
    internal static 专丐下丁丘万丑丆万 丄丘七三上丕世丞业 { get; }
    internal System.Collections.Generic.List<int> 丙丛丐专丆东丘丘七 { get; }
    
    // Methods
    internal static 专丐下丁丘万丑丆万 与一丅丝不丈业与丙()
    {
        专丐下丁丘万丑丆万 val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(专丐下丁丘万丑丆万.丝业丆丁业三丈丟东 == null)
        {
                专丐下丁丘万丑丆万 val_1 = new 专丐下丁丘万丑丆万();
            val_4 = null;
            val_4 = null;
            专丐下丁丘万丑丆万.丝业丆丁业三丈丟东 = val_1;
            val_2 = 专丐下丁丘万丑丆万.丝业丆丁业三丈丟东;
            val_1.上丛丌丆丑上七世三();
            val_3 = null;
        }
        
        val_3 = null;
        return (专丐下丁丘万丑丆万)专丐下丁丘万丑丆万.丝业丆丁业三丈丟东;
    }
    internal System.Collections.Generic.List<int> 东丞丈不下世丌丅业()
    {
        return (System.Collections.Generic.List<System.Int32>)this.三丙下丂世一下丂三;
    }
    internal void 上丛丌丆丑上七世三()
    {
        var val_7 = null;
        this.三丙下丂世一下丂三 = new System.Collections.Generic.List<System.Int32>(capacity:  100);
    }
    internal void 且专丞东丄丘万丁丄(CategoryNames 七丆丒与丗丌丄且丂)
    {
        if(this.三丙下丂世一下丂三.Count >= 100)
        {
                this.三丙下丂世一下丂三.RemoveAt(index:  0);
        }
        
        this.三丙下丂世一下丂三.Add(item:  七丆丒与丗丌丄且丂);
        this.丁丌丆丛业专丄丗万 = true;
    }
    internal void 丂且不业丂专丛丆东()
    {
        var val_2;
        if(this.丁丌丆丛业专丄丗万 == false)
        {
                return;
        }
        
        this.丁丌丆丛业专丄丗万 = false;
        val_2 = null;
        val_2 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  专丐下丁丘万丑丆万.七丐三丝且与东丆丗, 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.三丙下丂世一下丂三));
    }
    public 专丐下丁丘万丑丆万()
    {
    
    }
    private static 专丐下丁丘万丑丆万()
    {
        专丐下丁丘万丑丆万.七丐三丝且与东丆丗 = "WCS_key";
    }

}
