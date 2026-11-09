using UnityEngine;
internal class SimpleMoveMobToTarget : MoveMobToTarget
{
    // Methods
    public override void MoveToTarget()
    {
        UnityEngine.Transform val_1 = transform;
        UnityEngine.Vector3 val_2 = val_1.position;
        UnityEngine.Vector3 val_3 = val_1.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, t:  (UnityEngine.Time.deltaTime * val_5.attackingSpeed) * 0.1f);
        UnityEngine.Transform val_9 = val_1.七与世丄丞丒一七三().transform;
        val_9.position = new UnityEngine.Vector3() {x = val_8.x, y = val_2.z, z = val_8.z};
        UnityEngine.Vector3 val_10 = val_9.position;
        UnityEngine.Vector3 val_12 = this.transform.position;
        this.七与世丄丞丒一七三().OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_10.x, y = val_12.y, z = val_10.z});
    }
    public SimpleMoveMobToTarget()
    {
    
    }

}
