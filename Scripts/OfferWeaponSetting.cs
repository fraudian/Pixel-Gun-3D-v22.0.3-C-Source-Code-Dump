using UnityEngine;
[Serializable]
internal class 七丞丄丘七丌上下丘.OfferWeaponSetting
{
    // Fields
    internal string Rarity;
    internal string Unique;
    internal int Count;
    
    // Methods
    public override string ToString()
    {
        return (string)System.String.Format(format:  "[rarity={0} unique={1} count={2}]", arg0:  this.Rarity, arg1:  this.Unique, arg2:  this.Count);
    }
    public 七丞丄丘七丌上下丘.OfferWeaponSetting()
    {
    
    }

}
