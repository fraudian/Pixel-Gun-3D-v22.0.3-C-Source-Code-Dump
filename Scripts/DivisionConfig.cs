using UnityEngine;
[Serializable]
internal class ClanLootBoxData.DivisionConfig
{
    // Fields
    internal Rilisoft.丝丑丂丛万丐丈丘且 CurrencyMin;
    internal Rilisoft.丝丑丂丛万丐丈丘且 CurrencyMax;
    internal Rilisoft.丝丑丂丛万丐丈丘且 Points;
    internal string CurrencyId;
    internal double CurrencyProbability;
    internal int ModuleSettings;
    internal System.Collections.Generic.Dictionary<ItemRarity, int> CardChanceSettings;
    internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.Dictionary<ItemRarity, float>> CardRatioSettings;
    internal System.Collections.Generic.Dictionary<ItemRarity, float> CardCoefSettings;
    internal System.Collections.Generic.Dictionary<ItemRarity, int> CardCountSettings;
    internal System.Collections.Generic.List<string> Weapons;
    internal System.Collections.Generic.Dictionary<ItemRarity, int> WeaponChanceSettings;
    internal System.Collections.Generic.Dictionary<ItemRarity, int> WeaponDetailsSettings;
    internal System.Collections.Generic.List<string> Gadgets;
    internal System.Collections.Generic.Dictionary<ItemRarity, int> GadgetChanceSettings;
    internal System.Collections.Generic.Dictionary<ItemRarity, int> GadgetDetailsSettings;
    
    // Methods
    public ClanLootBoxData.DivisionConfig()
    {
    
    }

}
