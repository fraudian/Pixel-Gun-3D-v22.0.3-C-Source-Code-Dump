using UnityEngine;
public class PetsInfoDesigner : MonoBehaviour
{
    // Fields
    public PetInfo.丙上东业丘丗丗上丁 Behaviour;
    public ItemRarity Rarity;
    public string Lkey;
    public UnityEngine.Vector3 positionInBanners;
    public UnityEngine.Vector3 rotationInBanners;
    public System.Collections.Generic.List<一丁丒与丁丂丈七丆> parameters;
    public System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> effects;
    public float AttackDistance;
    public float AttackStopDistance;
    public float MinToOwnerDistance;
    public float MaxToOwnerDistance;
    public float TargetDetectRange;
    public float OffenderDetectRange;
    public float ToTargetTeleportDistance;
    public bool poisonEnabled;
    public Rilisoft.丏丏专丙世丝万丅且 poisonType;
    public int poisonCount;
    public float poisonTime;
    public float poisonDamagePercent;
    public int criticalHitChance;
    public float criticalHitCoef;
    public float HealDelaySecs;
    public float HealPowerSelf;
    public float HealPowerOwner;
    public float VampiricDamageMultiplier;
    public bool petExplode;
    public bool petDisablerExplode;
    public float disablerDuration;
    public float explosionRadius;
    public float explosionImpulse;
    public float explosionDamageMultiplier;
    public string explosionPrefabName;
    public bool UsePartialDamage;
    public int DamagePartsCount;
    public bool DoNotDropFromEgg;
    public string AlternativeId;
    public float AnimationAttackMoment;
    public float ragdollImpulse;
    public bool slowdownTargets;
    public float slowdownCoef;
    public float slowdownTime;
    public bool radiusDamage;
    
    // Methods
    public PetsInfoDesigner()
    {
        this.OffenderDetectRange = 10f;
        this.ToTargetTeleportDistance = 7f;
        this.poisonCount = 3;
        this.poisonTime = 2f;
        this.poisonDamagePercent = 0.033f;
        this.criticalHitCoef = 2f;
        this.DamagePartsCount = 3;
        this.AnimationAttackMoment = 0.1f;
        this.ragdollImpulse = 1f;
        this.disablerDuration = ;
        this.explosionRadius = ;
        this.explosionImpulse = 50f;
        this.explosionDamageMultiplier = 1f;
        this.slowdownCoef = 1f;
        this.slowdownTime = 1f;
    }

}
