using UnityEngine;
internal sealed class WeaponReloadShieldEffect : WeaponReloadEffect
{
    // Fields
    private float damageAbsorption;
    private float duration;
    
    // Methods
    internal override void 丄丄丛万丁丐丐与丏()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丙丁三上七丄丌丗丏().GetEnumerator());
    }
    private System.Collections.IEnumerable 丙丁三上七丄丌丗丏()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new WeaponReloadShieldEffect.下丟丟不丞丘与东丂();
    }
    public WeaponReloadShieldEffect()
    {
    
    }

}
