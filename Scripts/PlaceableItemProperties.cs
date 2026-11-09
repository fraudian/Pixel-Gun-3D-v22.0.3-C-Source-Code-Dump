using UnityEngine;
[Serializable]
internal class PlaceableItemProperties
{
    // Fields
    internal string ItemId;
    internal float sortingWeight;
    internal 一一万丒与专丙丁丛 clanDivision;
    internal ItemRarity ItemRarity;
    internal PGCompany.三东丏不丗世丅丌丄 price;
    internal Rilisoft.丝丑丂丛万丐丈丘且 energy;
    internal System.Collections.Generic.List<PlaceableItemProperties.Upgrade> Upgrades;
    
    // Methods
    public PlaceableItemProperties()
    {
        this.sortingWeight = 999f;
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this.energy = val_1;
        mem[1152921536759048072] = val_1.上万三丆专丏丒丗业;
        this.Upgrades = new System.Collections.Generic.List<Upgrade>();
    }

}
