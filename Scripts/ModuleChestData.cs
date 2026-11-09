using UnityEngine;
[Serializable]
internal class ModuleChestData
{
    // Fields
    private string _id;
    internal 且七丏丆万丑丞一丂 Type;
    internal Rilisoft.丝丑丂丛万丐丈丘且 openTime;
    internal 丈丞丕丘丕丗与上一 openPrice;
    internal Rilisoft.丝丑丂丛万丐丈丘且 modulesCount;
    internal Rilisoft.丝丑丂丛万丐丈丘且 modulesTypesCount;
    internal Rilisoft.丝丑丂丛万丐丈丘且 currencyReward;
    internal 丛丁三丕丏丒丆世丄 modulesList;
    
    // Properties
    internal string id { get; }
    internal 一丙丄丑一上与丏七 dropType { get; }
    
    // Methods
    internal string get_id()
    {
        string val_2 = this._id;
        if(val_2 != null)
        {
                return val_2;
        }
        
        val_2 = this.Type.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this._id = val_2;
        this.Type = null;
        return val_2;
    }
    internal 一丙丄丑一上与丏七 get_dropType()
    {
        return (一丙丄丑一上与丏七)(this.Type == 6) ? 1 : 0;
    }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丙丐不与丏丁下丑七()
    {
        System.Collections.Generic.List<Rilisoft.OfferItem> val_6;
        var val_7;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = null;
        val_6 = val_1;
        val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        if(this.Type == 6)
        {
                val_6 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丒丄丝丒丕丂丏丟丙();
            val_7 = null;
            return Rilisoft.下丐丒一丝丈丝三丞.丝丅与丅丐专丁丌下(丑七不与丛丆一丂丞:  val_1);
        }
        
        val_1.AddRange(collection:  this.modulesList.丙丐不与丏丁下丑七(东丂万丌丑上丝丅丝:  this.modulesCount, 专丗不丏下丑万丞一:  this.modulesTypesCount));
        val_1.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  242, 丞一丁业丄一一业且:  "", 丂丕丂丏专丂丄丕且:  this.currencyReward));
        val_7 = null;
        return Rilisoft.下丐丒一丝丈丝三丞.丝丅与丅丐专丁丌下(丑七不与丛丆一丂丞:  val_1);
    }
    public ModuleChestData()
    {
        this.modulesList = new 丛丁三丕丏丒丆世丄();
    }

}
