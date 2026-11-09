using UnityEngine;
[Serializable]
public class WeaponAnimEffectData
{
    // Fields
    public string animationName;
    public bool enabled;
    public bool blockAtPlay;
    public int EmitCount;
    public bool isLoop;
    public UnityEngine.ParticleSystem[] particleSystems;
    private float <animationLength>k__BackingField;
    private bool <isPlaying>k__BackingField;
    
    // Properties
    public float animationLength { get; set; }
    public bool isPlaying { get; set; }
    
    // Methods
    public float get_animationLength()
    {
        return (float)this.<animationLength>k__BackingField;
    }
    public void set_animationLength(float 丙业与丙丗丝不丈东)
    {
        this.<animationLength>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_isPlaying()
    {
        return (bool)this.<isPlaying>k__BackingField;
    }
    public void set_isPlaying(bool 丙业与丙丗丝不丈东)
    {
        this.<isPlaying>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public WeaponAnimEffectData()
    {
        this.enabled = true;
        this.blockAtPlay = true;
        this.EmitCount = 0;
        this.isLoop = true;
    }

}
