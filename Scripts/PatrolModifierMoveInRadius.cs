using UnityEngine;
internal sealed class PatrolModifierMoveInRadius : PatrolModifierController
{
    // Fields
    private float 丘丐业与三上丁三万;
    private UnityEngine.Vector3 丗与与丌丈与一丁丆;
    private int 万丆专下一丟不世与;
    
    // Methods
    internal void 丆业丙丘与丄专七不(float 且丛上丕业丂丒与一, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        this.丘丐业与三上丁三万 = 且丛上丕业丂丒与一;
        this.丗与与丌丈与一丁丆 = 业丒丝丗与丐丛丟丏;
        mem[1152921540030115568] = 业丒丝丗与丐丛丟丏.y;
        mem[1152921540030115572] = 业丒丝丗与丐丛丟丏.z;
    }
    internal override UnityEngine.Vector3 专业业丐与丕丂万丘()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Random.insideUnitSphere;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.丘丐业与三上丁三万);
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丗与与丌丈与一丁丆, y = val_2.y, z = V5.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = 0f, z = val_2.z});
    }
    internal override bool 不丝与下丙丙不丆丙(UnityEngine.Vector3 上丝丁业世且丆丑丁)
    {
        return (bool)((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 上丝丁业世且丆丑丁.x, y = 上丝丁业世且丆丑丁.y, z = 上丝丁业世且丆丑丁.z}, b:  new UnityEngine.Vector3() {x = this.丗与与丌丈与一丁丆, y = V11.16B, z = V12.16B})) < 0) ? 1 : 0;
    }
    internal override bool 与丄万丟丐丝丕丄专()
    {
        return false;
    }
    internal override void 与丞丕丝上三不丞与()
    {
    
    }
    public PatrolModifierMoveInRadius()
    {
        val_1 = new PGBehaviour();
    }

}
