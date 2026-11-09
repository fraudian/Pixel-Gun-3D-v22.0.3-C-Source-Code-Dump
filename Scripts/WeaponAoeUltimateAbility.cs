using UnityEngine;
internal class WeaponAoeUltimateAbility : WeaponUltimateAbility
{
    // Fields
    internal float startDelay;
    internal string onGroundEffectName;
    internal float damageRadius;
    internal WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    internal bool isPoison;
    internal DamageInRadiusEffect.WeaponInfoForPoison poisonSettings;
    internal bool isEnemyGroundEffectOnUltimate;
    private UnityEngine.Coroutine 丐丑丕丞丗且丟且丞;
    
    // Methods
    private void OnDestroy()
    {
        if(this.丐丑丕丞丗且丟且丞 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丐丑丕丞丗且丟且丞);
        this.丐丑丕丞丗且丟且丞 = 0;
    }
    internal override void 丟丄不丄丝业专丅丙(WeaponSounds 丌丝下丄业一丄不三)
    {
        this.丟丄不丄丝业专丅丙(丌丝下丄业一丄不三:  丌丝下丄业一丄不三);
        this.丐丑丕丞丗且丟且丞 = this.StartCoroutine(routine:  this.丙丈丂万丙丞丗丐业(丌丝下丄业一丄不三:  丌丝下丄业一丄不三));
    }
    private System.Collections.IEnumerator 丙丈丂万丙丞丗丐业(WeaponSounds 丌丝下丄业一丄不三)
    {
        WeaponAoeUltimateAbility.丄丂三与且下丂丞且 val_1 = new WeaponAoeUltimateAbility.丄丂三与且下丂丞且();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丌丝下丄业一丄不三 = 丌丝下丄业一丄不三;
        return (System.Collections.IEnumerator)val_1;
    }
    public WeaponAoeUltimateAbility()
    {
        this.damageRadius = 2f;
        this.onGroundEffectName = System.String.alignConst;
    }

}
