using UnityEngine;
internal class RocketSettings : PGBehaviour
{
    // Fields
    public RocketSettings.丄丟丄业丟丙丂丅丏 typeFly;
    public WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    internal Player_move_c.世不丟丂上丟与丌下 typeKilsIconChat;
    public float lifeTime;
    internal bool rayToTarget;
    private float startForce;
    internal string explosionName;
    internal string explosionWallName;
    internal float 丂万丞丁不专丝三丟;
    public float ghostNextTartgetDamageMultipler;
    public bool useGravity;
    public bool velocityBasedRotation;
    public bool spiralTrajectory;
    public bool isHarpoonProjectile;
    public bool isAreaDamage;
    public bool isPoisonAreaDamage;
    public bool dontDoSelfDamage;
    public bool throughWalls;
    public UnityEngine.GameObject flyParticle;
    public UnityEngine.TrailRenderer trail;
    public ZeichenKraftwerk.Rotator droneRotator;
    public UnityEngine.GameObject droneParticle;
    public UnityEngine.GameObject[] smokeEffects;
    public UnityEngine.Vector3 sizeBoxCollider;
    public UnityEngine.Vector3 centerBoxCollider;
    private bool dynamicCollisionCollider;
    public bool isChainLightMine;
    public float chainlightMineDamage;
    public float chainlightMineRadius;
    public float autoRocketForce;
    public float raduisDetectTarget;
    public float toxicHitTime;
    public float toxicDamageMultiplier;
    public bool isDamageExplosionToxicBomb;
    public Player_move_c.世不丟丂上丟与丌下 tickDamageTypeForToxicBomb;
    public UnityEngine.GameObject stickedParticle;
    public float stickyDetectRadiusMultiplier;
    public int countJumpLightning;
    public float raduisDetectTargetLightning;
    public float[] lightningDamageMultipliers;
    public float chargeScaleMin;
    public float chargeScaleMax;
    internal float chargeMinSartForceModifire;
    public UnityEngine.Transform cameraPoint;
    public string singularityName;
    public int clustersCount;
    public int clustersRocketNum;
    public float clusterBombsRadiusAppearance;
    public float clustersDamageMultipier;
    public float clustersRadiusDamage;
    public float minYScatter;
    public float maxYScatter;
    public bool spiralRandomStartAngle;
    public float spiralLateralSpeed;
    public float spiralAngularSpeed;
    public bool isRickochet;
    public int rickochetsCount;
    public UnityEngine.AudioSource ricochetAudio;
    public UnityEngine.ParticleSystem ricochetParticles;
    public bool timeDamage;
    public float timeDamageDuration;
    public int timeDamageTicks;
    public float timeDamageRadius;
    public float timeDamageRadiusToOwnerMultiplier;
    public bool noStraightDamage;
    public bool GradualExplosions;
    public float gradualFlyDistance;
    public int gradualExplosionsCount;
    public float autoHomingAngle;
    public bool isPoisoning;
    public int poisonCount;
    public float poisonDamageMultiplier;
    public float poisonTime;
    internal Rilisoft.丏丏专丙世丝万丅且 poisonType;
    internal bool isIgnoreIgnoreDamage;
    public float boomerangDistance;
    public bool rotateRocketAfterReturn;
    public bool boomerangUseTrail;
    public bool useShootReturn;
    public bool useRandomLifeTime;
    public float minLifeTime;
    public float maxLifeTime;
    public float stepRandomLifeTime;
    public bool isBFG;
    public float bfgRadius;
    public float bfgPlayerDamageMultiplier;
    public float bfgMobDamageMultiplier;
    public float bfgLightningTimeLife;
    public UnityEngine.AudioSource bfgLightningAudio;
    public BFGLightning[] bfgLightnings;
    private float 丟下七与丝丝丄丝丈;
    private UnityEngine.Vector3 三与丐丝丕东七三与;
    private UnityEngine.Vector3 丆业丗丑丂世七丝丏;
    private UnityEngine.Vector3 世丝丟且业丗上东专;
    private UnityEngine.Vector3 丑丘丈专丌与丕且丁;
    private float 丞业三三丟业三丘丌;
    private Rocket 丂世一丙七丛丌丐丑;
    
    // Properties
    internal float 业丛丝三业丂丏丏丟 { get; }
    public bool 丝万丑下丞丝七丞丝 { get; }
    private Rocket 丏丞业丗丑丕丌且丄 { get; }
    
    // Methods
    internal float 与丕丒丂丗一且不丁()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_17;
        float val_18;
        var val_19;
        val_17 = this;
        if(this.丐丗丗丁与丕丙丌丘() == 0)
        {
            goto label_5;
        }
        
        Rocket val_3 = this.丐丗丗丁与丕丙丌丘();
        if(val_3.丅丂专丄世丒丙丁丒 <= 0f)
        {
            goto label_5;
        }
        
        Rocket val_4 = this.丐丗丗丁与丕丙丌丘();
        val_18 = val_4.丅丂专丄世丒丙丁丒;
        goto label_7;
        label_5:
        val_18 = this.startForce;
        label_7:
        if(this.丐丗丗丁与丕丙丌丘() == 0)
        {
                return (float)val_19;
        }
        
        if(this.丐丗丗丁与丕丙丌丘().丗丌丘三丌下丌丗上() == false)
        {
                return (float)val_19;
        }
        
        WeaponSounds val_12 = this.丐丗丗丁与丕丙丌丘().下业丑万丟丁与丕不();
        if((val_12.三世丗丆丕万丐且三.ContainsKey(key:  24)) == false)
        {
                return (float)val_19;
        }
        
        WeaponSounds val_15 = this.丐丗丗丁与丕丙丌丘().下业丑万丟丁与丕不();
        val_17 = val_15.三世丗丆丕万丐且三;
        val_19 = ((this.丂万丞丁不专丝三丟 > 0f) ? (val_18 * this.丂万丞丁不专丝三丟) : (val_18)) * val_17.Item[24];
        return (float)val_19;
    }
    public bool get_DynamicCollisionCollider()
    {
        var val_8;
        if(this.dynamicCollisionCollider == false)
        {
            goto label_1;
        }
        
        label_7:
        val_8 = 1;
        return (bool)val_8;
        label_1:
        if(this.丐丗丗丁与丕丙丌丘() == 0)
        {
            goto label_9;
        }
        
        Rocket val_3 = this.丐丗丗丁与丕丙丌丘();
        if(val_3.丅丂专丄世丒丙丁丒 > 0f)
        {
            goto label_7;
        }
        
        if(this.丐丗丗丁与丕丙丌丘().丗丌丘三丌下丌丗上() != false)
        {
                WeaponSounds val_7 = this.丐丗丗丁与丕丙丌丘().下业丑万丟丁与丕不();
            if(val_7.三世丗丆丕万丐且三 != null)
        {
                return val_7.三世丗丆丕万丐且三.ContainsKey(key:  24);
        }
        
            return val_7.三世丗丆丕万丐且三.ContainsKey(key:  24);
        }
        
        label_9:
        val_8 = 0;
        return (bool)val_8;
    }
    private Rocket 丐丗丗丁与丕丙丌丘()
    {
        Rocket val_8;
        if(this.丂世一丙七丛丌丐丑 == 0)
        {
                val_8 = 0;
            this.丂世一丙七丛丌丐丑 = this.transform.parent.GetComponent<Rocket>();
            return val_8;
        }
        
        val_8 = this.丂世一丙七丛丌丐丑;
        return val_8;
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.三与丐丝丕东七三与 = val_1;
        mem[1152921536141107160] = val_1.y;
        mem[1152921536141107164] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.丆业丗丑丂世七丝丏 = val_2;
        mem[1152921536141107172] = val_2.y;
        mem[1152921536141107176] = val_2.z;
        this.丟下七与丝丝丄丝丈 = 0f;
    }
    private void 七东业丅丗下一丄丘()
    {
        this.丗丆三丂丁万专丕丞();
    }
    private void FixedUpdate()
    {
        this.丗丆三丂丁万专丕丞();
    }
    internal void 丗丆三丂丁万专丕丞()
    {
        var val_24;
        float val_25;
        val_24 = this;
        if(this.丐丗丗丁与丕丙丌丘() == 0)
        {
                return;
        }
        
        Rocket val_3 = this.丐丗丗丁与丕丙丌丘();
        if(val_3.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if(this.DynamicCollisionCollider == false)
        {
                return;
        }
        
        if(this.丞业三三丟业三丘丌 == this.与丕丒丂丗一且不丁())
        {
                float val_6 = UnityEngine.Time.fixedDeltaTime;
            val_25 = val_6;
            val_6 = this.丟下七与丝丝丄丝丈 / val_25;
            val_6 = 1f - val_6;
            if((double)System.Math.Abs(val_6) <= 0.1)
        {
                return;
        }
        
        }
        
        float val_25 = this.与丕丒丂丗一且不丁();
        float val_11 = UnityEngine.Time.fixedDeltaTime;
        val_25 = (val_25 / this.丐丗丗丁与丕丙丌丘().丂丝不一丑下三七业().mass) * UnityEngine.Time.fixedDeltaTime;
        float val_14 = UnityEngine.Time.fixedDeltaTime;
        this.丟下七与丝丝丄丝丈 = val_14;
        val_14 = val_25 * val_14;
        float val_15 = val_14 * 1.1f;
        this.三与丐丝丕东七三与 = this.sizeBoxCollider;
        mem[1152921536141480024] = 1852731203;
        mem[1152921536141480028] = val_15;
        float val_26 = System.Math.Abs(S12);
        float val_16 = val_15 * 0.5f;
        val_26 = val_26 * 0.5f;
        val_16 = val_16 - val_26;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.centerBoxCollider, y = V10.16B, z = val_25}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.丆业丗丑丂世七丝丏 = val_17;
        mem[1152921536141480036] = val_17.y;
        mem[1152921536141480040] = val_17.z;
        if(this.丐丗丗丁与丕丙丌丘() == 0)
        {
                return;
        }
        
        this.丐丗丗丁与丕丙丌丘().丆丑丘专上业一丟丗().size = new UnityEngine.Vector3() {x = this.三与丐丝丕东七三与, y = this.centerBoxCollider, z = V10.16B};
        val_25 = this.丆业丗丑丂世七丝丏;
        val_24 = this.丐丗丗丁与丕丙丌丘().丆丑丘专上业一丟丗();
        val_24.center = new UnityEngine.Vector3() {x = val_25, y = this.centerBoxCollider, z = V10.16B};
    }
    public static float CalcVelocity(float 七丆丟丗世丟且丒丆, float 东丅丁丕东丐丂与万, float 丌丗丙丛上丐丝专丙)
    {
        float val_1 = UnityEngine.Time.fixedDeltaTime;
        东丅丁丕东丐丂与万 = 七丆丟丗世丟且丒丆 / 东丅丁丕东丐丂与万;
        val_1 = 东丅丁丕东丐丂与万 * val_1;
        return (float)val_1;
    }
    public RocketSettings()
    {
        this.typeDead = 3;
        this.lifeTime = 7f;
        this.rayToTarget = true;
        this.startForce = 190f;
        this.explosionName = System.String.alignConst;
        this.explosionWallName = System.String.alignConst;
        this.丂万丞丁不专丝三丟 = 1f;
        this.ghostNextTartgetDamageMultipler = 1.836682E-41f;
        this.sizeBoxCollider = 0;
        mem[1152921536141748848] = 0;
        this.autoRocketForce = 15f;
        this.raduisDetectTarget = 5f;
        this.toxicHitTime = 1f;
        this.toxicDamageMultiplier = 7.346868E-41f;
        this.tickDamageTypeForToxicBomb = 12;
        this.stickyDetectRadiusMultiplier = 0.5f;
        this.countJumpLightning = 2;
        this.raduisDetectTargetLightning = 5f;
        this.centerBoxCollider = 0;
        mem[1152921536141748860] = 0;
        this.lightningDamageMultipliers = new float[5] {4.600603E-41f, 8.82818E-44f, 4.600463E-41f, 8.68805E-44f, 4.600323E-41f};
        this.chargeScaleMin = 0.7f;
        this.chargeScaleMax = 5.510186E-41f;
        this.clustersCount = 4;
        this.clusterBombsRadiusAppearance = 5f;
        this.clustersDamageMultipier = 0.25f;
        this.clustersRadiusDamage = 10f;
        this.minYScatter = 0.25f;
        this.autoHomingAngle = 55f;
        this.clustersRocketNum = 109;
        this.chargeMinSartForceModifire = 1f;
        this.maxYScatter = 1f;
        this.rickochetsCount = 5;
        this.spiralLateralSpeed = 3f;
        this.spiralAngularSpeed = 180f;
        this.poisonCount = 3;
        mem2[0] = 1036831949;
        this.poisonType = true;
        this.boomerangDistance = 15f;
        mem2[0] = ;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.三与丐丝丕东七三与 = val_2;
        mem[1152921536141749160] = val_2.y;
        mem[1152921536141749164] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.丆业丗丑丂世七丝丏 = val_3;
        mem[1152921536141749172] = val_3.y;
        mem[1152921536141749176] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.世丝丟且业丗上东专 = val_4;
        mem[1152921536141749184] = val_4.y;
        mem[1152921536141749188] = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.丑丘丈专丌与丕且丁 = val_5;
        mem[1152921536141749196] = val_5.y;
        mem[1152921536141749200] = val_5.z;
    }

}
