using UnityEngine;
internal class 丟丒且且一丛丝丐丞.丂丅上与丑丁与丕丝
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 _id;
    internal string Description;
    internal PGCompany.一丄丗与一丗丐丙一 Category;
    internal PGCompany.GameTaskActionSettings ActionSettings;
    private System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且> _neededCountRarityParse;
    private PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丁丘三且且丑丞丈万;
    
    // Properties
    internal int 下丄丈不与世丐业专 { get; set; }
    internal PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丗上丏专上世丘丘与 { get; set; }
    
    // Methods
    internal int 业上丙丞丐丄丆丅七()
    {
    
    }
    internal void 丒丞东丈丁丄丑丅且(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this._id = val_1;
        mem[1152921554036606968] = val_1.上万三丆专丏丒丗业;
    }
    internal PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丝且丘丒不丌且丂丈()
    {
        if(this.丁丘三且且丑丞丈万 != null)
        {
                return (PGCompany.丒且丌丑丆上一丘丆<ItemRarity>)val_1;
        }
        
        PGCompany.丒且丌丑丆上一丘丆<TKey> val_1 = PGCompany.丒且丌丑丆上一丘丆<ItemRarity>.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  this._neededCountRarityParse);
        this.丁丘三且且丑丞丈万 = val_1;
        return (PGCompany.丒且丌丑丆上一丘丆<ItemRarity>)val_1;
    }
    internal void 丅丏丙丂丞丟丟丅丐(PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丙业与丙丗丝不丈东)
    {
        this.丁丘三且且丑丞丈万 = 丙业与丙丗丝不丈东;
    }
    public 丟丒且且一丛丝丐丞.丂丅上与丑丁与丕丝()
    {
    
    }

}
