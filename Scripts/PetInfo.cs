using UnityEngine;
[Serializable]
public class PetInfo
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 _indexContainer;
    public string AlternativeId;
    public float AnimationAttackMoment;
    public float AttackDistance;
    public float AttackStopDistance;
    public PetInfo.丙上东业丘丗丗上丁 Behaviour;
    public int criticalHitChance;
    public float criticalHitCoef;
    public int DamagePartsCount;
    public float disablerDuration;
    public bool DoNotDropFromEgg;
    public System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> Effects;
    public float explosionDamageMultiplier;
    public float explosionDelay;
    public float explosionImpulse;
    public string explosionPrefabName;
    public float explosionRadius;
    public float HealDelaySecs;
    public float HealPowerOwner;
    public float HealPowerSelf;
    public string Id;
    public string Lkey;
    private UnityEngine.Vector3 m_positionInBanners;
    private UnityEngine.Vector3 m_rotationInBanners;
    public float MaxToOwnerDistance;
    public float MinToOwnerDistance;
    public float OffenderDetectRange;
    public System.Collections.Generic.List<一丁丒与丁丂丈七丆> Parameters;
    public bool petDisablerExplode;
    public bool petExplode;
    public int poisonCount;
    public float poisonDamagePercent;
    public bool poisonEnabled;
    public float poisonTime;
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    internal ItemRarity Rarity;
    public float TargetDetectRange;
    public float ragdollImpulse;
    public float VampiricDamageMultiplier;
    public bool slowdownTargets;
    public float slowdownCoef;
    public float slowdownTime;
    public float ToTargetTeleportDistance;
    public bool UsePartialDamage;
    public bool radiusDamage;
    
    // Properties
    public int Index { get; set; }
    public int CurrentLevel { get; }
    internal float HP { get; }
    internal float Attack { get; }
    internal float SpeedModif { get; }
    internal float RespawnTime { get; }
    internal float Cashback { get; }
    internal UnityEngine.Vector3 PositionInBanners { get; set; }
    internal UnityEngine.Vector3 RotationInBanners { get; set; }
    
    // Methods
    public int get_Index()
    {
    
    }
    public void set_Index(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this._indexContainer = val_1;
        mem[1152921538531915832] = val_1.上万三丆专丏丒丗业;
    }
    public int get_CurrentLevel()
    {
        int val_4;
        var val_5;
        var val_6;
        int val_7;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_6 = null;
            val_6 = null;
            val_7 = 0;
            return val_7;
        }
        
        val_4 = this._indexContainer;
        if((Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().且丒丑丙万东业丟丕(丄丈丞丒且东丝下一:  val_4)) == null)
        {
                return val_7;
        }
        
        val_7 = val_3.万丄丅丛下丐丒丞上;
        return val_7;
    }
    internal float get_HP()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_8 = BalanceController.丈丅丙世丘且丄丁丕.Item[UnityEngine.Mathf.Clamp(value:  ExperienceController.丞丞丘业东丙丏七丌() - this.CurrentLevel, min:  0, max:  BalanceController.丈丅丙世丘且丄丁丕.Count - 1)];
        float val_10 = 100f;
        float val_9 = 1.152922E+18f;
        val_9 = (BalanceController.下专丁丁东下丟丐丑(世丐丗专丅三丝丑丆:  this.Id)) * val_9;
        val_10 = val_9 / val_10;
        return (float)val_10;
    }
    internal float get_Attack()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_8 = BalanceController.丝丑丟不丒丌丐丕下.Item[UnityEngine.Mathf.Clamp(value:  ExperienceController.丞丞丘业东丙丏七丌() - this.CurrentLevel, min:  0, max:  BalanceController.丝丑丟不丒丌丐丕下.Count - 1)];
        float val_10 = 100f;
        float val_9 = 1.152922E+18f;
        val_9 = (BalanceController.丏下丌世且七丟七业(世丐丗专丅三丝丑丆:  this.Id)) * val_9;
        val_10 = val_9 / val_10;
        return (float)val_10;
    }
    internal float get_SpeedModif()
    {
        return BalanceController.丑一丌丟万丛丝丕丆(世丐丗专丅三丝丑丆:  this.Id);
    }
    internal float get_RespawnTime()
    {
        return BalanceController.丝一丄丙三且丞丞一(世丐丗专丅三丝丑丆:  this.Id);
    }
    internal float get_Cashback()
    {
        return (float)(float)BalanceController.丒专丝丗三上丝丌丞(世丐丗专丅三丝丑丆:  this.Id);
    }
    internal UnityEngine.Vector3 get_PositionInBanners()
    {
        return new UnityEngine.Vector3() {x = this.m_positionInBanners};
    }
    internal void set_PositionInBanners(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.m_positionInBanners = 丙业与丙丗丝不丈东;
        mem[1152921538532869300] = 丙业与丙丗丝不丈东.y;
        mem[1152921538532869304] = 丙业与丙丗丝不丈东.z;
    }
    internal UnityEngine.Vector3 get_RotationInBanners()
    {
        return new UnityEngine.Vector3() {x = this.m_rotationInBanners};
    }
    internal void set_RotationInBanners(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.m_rotationInBanners = 丙业与丙丗丝不丈东;
        mem[1152921538533093312] = 丙业与丙丗丝不丈东.y;
        mem[1152921538533093316] = 丙业与丙丗丝不丈东.z;
    }
    internal string 丘丕丂万丝丁丌丞业()
    {
        return System.String.Format(format:  "Pets/Content/{0}", arg0:  this.Id);
    }
    internal static string 丏且上丒且丂东丂专(string 世丐丗专丅三丝丑丆)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  世丐丗专丅三丝丑丆)) == false)
        {
                return System.String.Format(format:  "OfferIcons/{0}_icon1_big", arg0:  世丐丗专丅三丝丑丆);
        }
        
        return 0;
    }
    public PetInfo()
    {
        this.AnimationAttackMoment = 0.1f;
        this.explosionDelay = 0.5f;
        this.OffenderDetectRange = 10f;
        this.ragdollImpulse = 1f;
        this.slowdownCoef = 1f;
        this.slowdownTime = 1f;
    }

}
