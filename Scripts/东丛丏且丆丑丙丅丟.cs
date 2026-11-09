using UnityEngine;
internal class 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟 : ICloneable
{
    // Fields
    internal int 丒专下与丑丁丆丟业;
    public int 下丄丈不与世丐业专;
    internal bool 丗丕丂丄丝丄且丄且;
    internal System.Collections.Generic.List<string> 丅三丙专丆丆丈丗且;
    internal ItemRarity 且丐丟专丛丗丏上丙;
    internal int 丌且丐下不丂丒与丘;
    
    // Methods
    public object Clone()
    {
        int val_3;
        System.Collections.Generic.List<System.String> val_4;
        七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟 val_1 = null;
        .丒专下与丑丁丆丟业 = 1;
        val_1 = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟();
        if(val_1 != null)
        {
                .丒专下与丑丁丆丟业 = this.丒专下与丑丁丆丟业;
            .下丄丈不与世丐业专 = this.下丄丈不与世丐业专;
            .丗丕丂丄丝丄且丄且 = this.丗丕丂丄丝丄且丄且;
            .且丐丟专丛丗丏上丙 = this.且丐丟专丛丗丏上丙;
            val_3 = this.丌且丐下不丂丒与丘;
        }
        else
        {
                .丒专下与丑丁丆丟业 = this.丒专下与丑丁丆丟业;
            .下丄丈不与世丐业专 = this.下丄丈不与世丐业专;
            mem[24] = this.丗丕丂丄丝丄且丄且;
            mem[40] = this.且丐丟专丛丗丏上丙;
            val_3 = this.丌且丐下不丂丒与丘;
        }
        
        .丌且丐下不丂丒与丘 = val_3;
        val_4 = this.丅三丙专丆丆丈丗且;
        .丅三丙专丆丆丈丗且 = System.Linq.Enumerable.ToList<System.String>(source:  val_4);
        return (object)val_1;
    }
    public 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟()
    {
        this.丒专下与丑丁丆丟业 = 1;
    }

}
