using UnityEngine;
internal sealed class MobDamageModificator : PGBehaviour
{
    // Fields
    private float _damageModificator;
    
    // Properties
    internal float 且丏不专且专下与丏 { get; }
    
    // Methods
    internal float 一丕丑丘丘丗丐与丂()
    {
        return (float)this._damageModificator;
    }
    public MobDamageModificator()
    {
        this._damageModificator = 1f;
    }

}
