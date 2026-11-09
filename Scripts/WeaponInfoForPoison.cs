using UnityEngine;
[Serializable]
internal class DamageInRadiusEffect.WeaponInfoForPoison
{
    // Fields
    public Rilisoft.丏丏专丙世丝万丅且 poisonType;
    public float poisonTime;
    public int poisonCount;
    internal string weaponName;
    public WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    public float poisonDamageMultiplier;
    public bool isIgnoreIgnoreDamage;
    
    // Methods
    internal DamageInRadiusEffect.WeaponInfoForPoison(Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, float 丒丙丘丕且一丞丕丑, float 丂丐丈丕丞下丁下丘, int 丂上上不一丐业一丕, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, bool 丌丛丑三丆丘万丘丛)
    {
        val_1 = new System.Object();
        this.poisonType = 三一丝且丝丛不丄丐;
        this.poisonDamageMultiplier = 丒丙丘丕且一丞丕丑;
        this.poisonTime = 丂丐丈丕丞下丁下丘;
        this.poisonCount = 丂上上不一丐业一丕;
        this.weaponName = val_1.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        this.typeDead = 东丏业丞丞业下丄世;
        this.isIgnoreIgnoreDamage = 丌丛丑三丆丘万丘丛;
    }

}
