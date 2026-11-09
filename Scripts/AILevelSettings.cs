using UnityEngine;
[Serializable]
public class 上且下一丁丑丑丟丟.AILevelSettings
{
    // Fields
    public System.Collections.Generic.List<string> weapons;
    public float minRandomValueForAim;
    public float maxRandomValueForAim;
    public float attackRange;
    public float rotationSpeedMinSkirmish;
    public float rotationSpeedMaxSkirmish;
    public int dodge;
    public int dodgeWithMelee;
    public int jumpOnDodje;
    public int jumpOnDodjeWithMelee;
    public int straightDodje;
    public int switchOnTarget;
    public int switchOnTargetWhenHaveTarget;
    public int takeMeleeWeapon;
    public int goForBonus;
    public int rotateWhenStand;
    public int choosePlayerAsTarget;
    public int doDamageOnShoot;
    public int changeWeaponOnReload;
    public int pauseOnShoot;
    public int throwGrenade;
    
    // Methods
    internal 上且下一丁丑丑丟丟.AILevelSettings 专丕丕丈不丑丘与丗()
    {
        float val_3;
        float val_4;
        上且下一丁丑丑丟丟.AILevelSettings val_1 = new 上且下一丁丑丑丟丟.AILevelSettings();
        if(val_1 != null)
        {
                .dodge = this.dodge;
            .dodgeWithMelee = this.dodgeWithMelee;
            .jumpOnDodje = this.jumpOnDodje;
            .jumpOnDodjeWithMelee = this.jumpOnDodjeWithMelee;
            .straightDodje = this.straightDodje;
            .switchOnTarget = this.switchOnTarget;
            .switchOnTargetWhenHaveTarget = this.switchOnTargetWhenHaveTarget;
            .takeMeleeWeapon = this.takeMeleeWeapon;
            .goForBonus = this.goForBonus;
            .rotateWhenStand = this.rotateWhenStand;
            .choosePlayerAsTarget = this.choosePlayerAsTarget;
            .doDamageOnShoot = this.doDamageOnShoot;
            .changeWeaponOnReload = this.changeWeaponOnReload;
            .pauseOnShoot = this.pauseOnShoot;
            .throwGrenade = this.throwGrenade;
            .minRandomValueForAim = this.minRandomValueForAim;
            .maxRandomValueForAim = this.maxRandomValueForAim;
            val_3 = this.attackRange;
        }
        else
        {
                .dodge = this.dodge;
            mem[48] = this.dodgeWithMelee;
            .jumpOnDodje = this.jumpOnDodje;
            mem[56] = this.jumpOnDodjeWithMelee;
            .straightDodje = this.straightDodje;
            mem[64] = this.switchOnTarget;
            .switchOnTargetWhenHaveTarget = this.switchOnTargetWhenHaveTarget;
            mem[72] = this.takeMeleeWeapon;
            .goForBonus = this.goForBonus;
            mem[80] = this.rotateWhenStand;
            .choosePlayerAsTarget = this.choosePlayerAsTarget;
            mem[88] = this.doDamageOnShoot;
            .changeWeaponOnReload = this.changeWeaponOnReload;
            mem[96] = this.pauseOnShoot;
            .throwGrenade = this.throwGrenade;
            mem[24] = this.minRandomValueForAim;
            .maxRandomValueForAim = this.maxRandomValueForAim;
            val_3 = this.attackRange;
        }
        
        .attackRange = val_3;
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.String>(source:  this.weapons);
        if(val_1 != null)
        {
                .weapons = val_2;
            .rotationSpeedMinSkirmish = this.rotationSpeedMinSkirmish;
            val_4 = this.rotationSpeedMaxSkirmish;
        }
        else
        {
                mem[16] = val_2;
            .rotationSpeedMinSkirmish = this.rotationSpeedMinSkirmish;
            val_4 = this.rotationSpeedMaxSkirmish;
        }
        
        .rotationSpeedMaxSkirmish = val_4;
        return (AILevelSettings)val_1;
    }
    public 上且下一丁丑丑丟丟.AILevelSettings()
    {
        this.weapons = new System.Collections.Generic.List<System.String>();
    }

}
