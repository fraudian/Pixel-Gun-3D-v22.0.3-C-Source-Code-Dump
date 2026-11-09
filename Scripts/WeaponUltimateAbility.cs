using UnityEngine;
internal class WeaponUltimateAbility : MonoBehaviour
{
    // Fields
    internal int countHitsToActivateAbility;
    internal bool isBulletGun;
    internal bool onlyUltimateAbility;
    internal WeaponSounds weaponSounds;
    internal float damageMultiplier;
    internal bool useSpecialRocket;
    internal int specialRocketNum;
    internal string specialRocketExplosionName;
    internal bool useUltimateAnimation;
    internal string ultimateAnimationName;
    internal int ultimateFireFlashNum;
    internal bool useUltimateShotSound;
    internal UnityEngine.AudioClip shotClip;
    internal bool useUltimateIdleSound;
    internal UnityEngine.AudioSource idleAudioSource;
    internal UnityEngine.GameObject effectOnFullCharge;
    internal float delayShoot;
    private bool 丂七三东上与丑且东;
    
    // Properties
    internal int 东丁丈世丞上三丒丗 { get; }
    
    // Methods
    internal int 下丌业不丈丒不丒下()
    {
        int val_3;
        int val_4;
        val_3 = this;
        if(this.weaponSounds.丌丆丈丈丌不丈丄丗() != false)
        {
                val_3 = this.weaponSounds.weaponUltimate.countHitsToActivateAbility;
            float val_3 = (float)val_3;
            val_3 = val_3 / 10f;
            val_4 = (UnityEngine.Mathf.CeilToInt(f:  val_3)) + 1;
            return val_4;
        }
        
        val_4 = this.countHitsToActivateAbility;
        return val_4;
    }
    protected virtual void Awake()
    {
        this.weaponSounds = this.GetComponent<WeaponSounds>();
    }
    internal virtual void 丟丄不丄丝业专丅丙(WeaponSounds 丌丝下丄业一丄不三)
    {
    
    }
    internal void 丟丕不丟世业七丕丟()
    {
        if(this.effectOnFullCharge != 0)
        {
                this.effectOnFullCharge.SetActive(value:  true);
        }
        
        if(this.useUltimateIdleSound == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.idleAudioSource.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丆专与丐丁世不与丕()
    {
        if(this.effectOnFullCharge != 0)
        {
                this.effectOnFullCharge.SetActive(value:  false);
        }
        
        this.丌丕专且丐丟上丛丂();
    }
    internal void 丌丕专且丐丟上丛丂()
    {
        if(this.useUltimateIdleSound == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.idleAudioSource.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丂丂专丞与上丅丕丕()
    {
        if(this.delayShoot <= 0f)
        {
                return;
        }
        
        if(this.丂七三东上与丑且东 != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.专一丏专上东丑丗丂());
    }
    private System.Collections.IEnumerator 专一丏专上东丑丗丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponUltimateAbility.丅丆专丑与万丕七丟();
    }
    internal void 世与且专丝丗丝丟丄()
    {
        this.丂七三东上与丑且东 = false;
    }
    internal bool 不丟且不丘丙丙三丑()
    {
        return (bool)this.丂七三东上与丑且东;
    }
    public WeaponUltimateAbility()
    {
        this.countHitsToActivateAbility = 3;
        this.damageMultiplier = 1f;
    }

}
