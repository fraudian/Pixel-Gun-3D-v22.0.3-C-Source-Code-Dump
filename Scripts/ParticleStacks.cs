using UnityEngine;
public class ParticleStacks : MonoBehaviour
{
    // Fields
    internal static ParticleStacks 丄丘七三上丕世丞业;
    public ParticleStackController fireStack;
    public ParticleStackController lightningStack;
    public ParticleStackController charmStack;
    public HitStackController hitStack;
    public HitStackController poisonHitStack;
    public HitStackController resistStack;
    public HitStackController criticalHitStack;
    public HitStackController bleedHitStack;
    public HitStackController jumpDustStack;
    public HitStackController moduleResistStack;
    public UnityEngine.GameObject dragonPrefab;
    
    // Methods
    private void Awake()
    {
        ParticleStacks.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        ParticleStacks.丄丘七三上丕世丞业 = 0;
    }
    public ParticleStacks()
    {
    
    }

}
