using UnityEngine;
internal sealed class WeaponReloadDisableGadgetsEffect : WeaponReloadEffect
{
    // Fields
    private float effectRadius;
    private float gadgetDisableTime;
    private float 丆丝业且丌丕丕一一;
    
    // Methods
    internal override void 丄丄丛万丁丐丐与丏()
    {
        if(下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
                return;
        }
        
        if((val_1.不不丂丗丁丛丟丛丑.ContainsKey(key:  18)) != false)
        {
                float val_4 = val_1.不不丂丗丁丛丟丛丑 + 1184.Item[18];
        }
        
        this.丆丝业且丌丕丕一一 = 1f;
        var val_9 = 0;
        val_9 = val_9 + 1;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丙丁三上七丄丌丗丏().GetEnumerator());
    }
    private System.Collections.IEnumerable 丙丁三上七丄丌丗丏()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerable)new WeaponReloadDisableGadgetsEffect.丙丌丘丌丘七丐丂丙();
    }
    public WeaponReloadDisableGadgetsEffect()
    {
        this.effectRadius = 2f;
        this.gadgetDisableTime = 2f;
    }
    private void 专三丟丆专万丈上上()
    {
    
    }

}
