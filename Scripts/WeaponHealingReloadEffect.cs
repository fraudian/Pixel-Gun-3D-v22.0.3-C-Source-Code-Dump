using UnityEngine;
public class WeaponHealingReloadEffect : WeaponReloadEffect
{
    // Fields
    private float healtValue;
    private bool healTeammate;
    private float healTeammateValue;
    private float healTeammateRadius;
    private UnityEngine.Coroutine 三世丛丛与下上三丁;
    
    // Methods
    internal override void 丄丄丛万丁丐丐与丏()
    {
        var val_9 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丒七丅丟丟丐业上丄
        三丈丟与丏丘丈丐万 val_2 = 下丏丆下丙与丘上丁().万三与一丈三丐丅且(丞世不丒下上上丝丑:  WeaponManager.丟丗丄业丘丗业丗七.丒七丅丟丟丐业上丄);
        Player_move_c val_3 = WeaponManager.丟丗丄业丘丗业丗七.丒七丅丟丟丐业上丄.下丏丆下丙与丘上丁();
        if(val_3.丟丌下三七丁与丟丑() != true)
        {
                Player_move_c val_5 = val_3.下丏丆下丙与丘上丁();
            if(val_5.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        }
        
        if(val_2.丄万上丈下丘丑丁丒() != false)
        {
                return;
        }
        
        if(this.三世丛丛与下上三丁 != null)
        {
                this.StopCoroutine(routine:  this.三世丛丛与下上三丁);
        }
        
        this.三世丛丛与下上三丁 = this.StartCoroutine(routine:  this.丙丁三上七丄丌丗丏());
        val_2.上东万丒丁丑丄丈与(丙业与丙丗丝不丈东:  true);
    }
    private System.Collections.IEnumerator 丙丁三上七丄丌丗丏()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponHealingReloadEffect.丘万丄丈丞丈丛丐丘();
    }
    public WeaponHealingReloadEffect()
    {
        this.healtValue = 5f;
        this.healTeammateValue = 5f;
        this.healTeammateRadius = 3f;
    }

}
