using UnityEngine;
internal sealed class TurretControllerScene_PoisonPlant : TurretControllerScene_Tower
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    private UnityEngine.GameObject chargePrefab;
    private float chargeSpeed;
    public UnityEngine.Transform shotPoint;
    public float angle;
    
    // Methods
    protected override void 丅丙业不丏丟丄丕丝()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一丘三三丐不三不世());
    }
    private System.Collections.IEnumerator 一丘三三丐不三不世()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretControllerScene_PoisonPlant.专七万世不丞丄丟丌();
    }
    public TurretControllerScene_PoisonPlant()
    {
        this.chargeSpeed = 30f;
        mem[1152921540627544840] = ;
        mem[1152921540627544856] = ;
        mem[1152921540627544876] = 1110704128;
        val_1 = new TurretControllerScene();
    }

}
