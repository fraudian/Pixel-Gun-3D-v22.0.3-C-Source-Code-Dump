using UnityEngine;
[Serializable]
public class AlternativeAttackSettings
{
    // Fields
    public 三丛丏丒不专丈万业 typeAlternativeAttack;
    public float damage;
    public float radiusDamageable;
    public System.Collections.Generic.List<UnityEngine.Transform> pointForShoot;
    public float bulletSpeed;
    public float lifeTimeProjectile;
    public bool isProjectileExplosion;
    public UnityEngine.GameObject effectExplosion;
    public bool isFriendlyFire;
    private BulletForBot _projectile;
    public bool isMoveByPhysics;
    public float angle;
    public float force;
    private int countPoolProjectile;
    public float heathRegenPercent;
    public float disableAfterDelay;
    private DisableWithDelay particleObject;
    public string nameAnimation;
    public bool subscribeOnActionAnimation;
    public float damageAfterDelay;
    
    // Properties
    internal BulletForBot Projectile { get; }
    public int CountPoolProjectile { get; }
    internal DisableWithDelay ParticleObject { get; }
    
    // Methods
    internal BulletForBot get_Projectile()
    {
        return (BulletForBot)this._projectile;
    }
    public int get_CountPoolProjectile()
    {
        return (int)this.countPoolProjectile;
    }
    internal DisableWithDelay get_ParticleObject()
    {
        return (DisableWithDelay)this.particleObject;
    }
    public AlternativeAttackSettings()
    {
        this.countPoolProjectile = 4;
    }

}
