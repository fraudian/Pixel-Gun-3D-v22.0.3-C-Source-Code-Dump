using UnityEngine;
internal class 丟丒且且一丛丝丐丞.上丂且万丌业丑丈丞
{
    // Fields
    internal PGCompany.东丕丐一与丏东丘下 Type;
    private Rilisoft.丝丑丂丛万丐丈丘且 _itemIndex;
    private System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且> _weightsParse;
    private PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丆丐丈丗一丘丌且不;
    private System.Collections.Generic.Dictionary<ItemRarity, Rilisoft.丝丑丂丛万丐丈丘且> _countsParse;
    private PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 万丁丝丁丞下上万丝;
    
    // Properties
    internal int 三丌上丁一丟丐丟丈 { get; set; }
    internal PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 且三丒丕东丑丙业丞 { get; set; }
    internal PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丒七丈丑丙丁丂丛一 { get; set; }
    
    // Methods
    internal int 丝一丙丘专七丕不上()
    {
    
    }
    internal void 丂丙丗丗三与丌丙世(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this._itemIndex = val_1;
        mem[1152921554035756416] = val_1.上万三丆专丏丒丗业;
    }
    internal PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 三丘三丝世丌丂世丞()
    {
        if(this.丆丐丈丗一丘丌且不 != null)
        {
                return (PGCompany.丒且丌丑丆上一丘丆<ItemRarity>)val_1;
        }
        
        PGCompany.丒且丌丑丆上一丘丆<TKey> val_1 = PGCompany.丒且丌丑丆上一丘丆<ItemRarity>.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  this._weightsParse);
        this.丆丐丈丗一丘丌且不 = val_1;
        return (PGCompany.丒且丌丑丆上一丘丆<ItemRarity>)val_1;
    }
    internal void 丝丗丗丟东丂丐三不(PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丙业与丙丗丝不丈东)
    {
        this.丆丐丈丗一丘丌且不 = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丅丛上丞丁且丗丟一()
    {
        if(this.万丁丝丁丞下上万丝 != null)
        {
                return (PGCompany.丒且丌丑丆上一丘丆<ItemRarity>)val_1;
        }
        
        PGCompany.丒且丌丑丆上一丘丆<TKey> val_1 = PGCompany.丒且丌丑丆上一丘丆<ItemRarity>.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  this._countsParse);
        this.万丁丝丁丞下上万丝 = val_1;
        return (PGCompany.丒且丌丑丆上一丘丆<ItemRarity>)val_1;
    }
    internal void 丄下丐丌万下上且丆(PGCompany.丒且丌丑丆上一丘丆<ItemRarity> 丙业与丙丗丝不丈东)
    {
        this.万丁丝丁丞下上万丝 = 丙业与丙丗丝不丈东;
    }
    public 丟丒且且一丛丝丐丞.上丂且万丌业丑丈丞()
    {
    
    }

}
