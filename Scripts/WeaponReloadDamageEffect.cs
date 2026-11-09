using UnityEngine;
public class WeaponReloadDamageEffect : WeaponReloadEffect
{
    // Fields
    private float damageRadius;
    private float damageMultiplier;
    private WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    private bool isPoison;
    private DamageInRadiusEffect.WeaponInfoForPoison poisonSettings;
    private UnityEngine.Coroutine 三世丛丛与下上三丁;
    
    // Methods
    internal override void 丄丄丛万丁丐丐与丏()
    {
        var val_11 = null;
        int val_2 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        三丈丟与丏丘丈丐万 val_3 = 下丏丆下丙与丘上丁().万三与一丈三丐丅且(丞世不丒下上上丝丑:  val_2);
        Player_move_c val_4 = val_2.下丏丆下丙与丘上丁();
        if(val_4.丟丌下三七丁与丟丑() != true)
        {
                Player_move_c val_6 = val_4.下丏丆下丙与丘上丁();
            if(val_6.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        }
        
        if(val_3.丄万上丈下丘丑丁丒() != false)
        {
                return;
        }
        
        if(this.三世丛丛与下上三丁 != null)
        {
                this.StopCoroutine(routine:  this.三世丛丛与下上三丁);
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        this.三世丛丛与下上三丁 = this.StartCoroutine(routine:  this.丙丁三上七丄丌丗丏().GetEnumerator());
        val_3.上东万丒丁丑丄丈与(丙业与丙丗丝不丈东:  true);
    }
    private System.Collections.IEnumerable 丙丁三上七丄丌丗丏()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new WeaponReloadDamageEffect.且上丙世丅世丕丆丒();
    }
    public WeaponReloadDamageEffect()
    {
        this.damageRadius = Infinityf;
        this.damageMultiplier = 1f;
    }

}
