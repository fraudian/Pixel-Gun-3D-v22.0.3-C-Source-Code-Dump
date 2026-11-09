using UnityEngine;
internal sealed class FortTrapClasterExplosion : FortTrapExposion
{
    // Fields
    private int clusterCount;
    private UnityEngine.Transform clusterBombPoint;
    private UnityEngine.GameObject clusterPrefab;
    private float clusterBombSpeed;
    private float offsetMultiplier;
    
    // Methods
    public override void StartDeactivate()
    {
        this.StartDeactivate();
        this.丞丌丝丅万世丅丛丄();
    }
    private void 丞丌丝丅万世丅丛丄()
    {
        int val_4 = this.clusterCount;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if(this.clusterCount < 1)
        {
                return;
        }
        
        float val_5 = 360f;
        float val_3 = (float)val_4;
        val_3 = val_5 / val_3;
        val_3 = val_3 * 3.141593f;
        float val_2 = val_3 / 180f;
        var val_7 = 0;
        val_4 = val_2 * 0.5f;
        do
        {
            float val_6 = this.offsetMultiplier;
            val_5 = val_4 * val_6;
            val_6 = val_4 * val_6;
            this.专不丞丒丁与丈业丙(丛上丙丄丄七丈且丅:  new UnityEngine.Vector3() {x = val_5, y = val_1.y, z = val_6});
            val_7 = val_7 + 1;
            val_4 = val_2 + val_4;
        }
        while(val_7 < this.clusterCount);
    
    }
    private void 专不丞丒丁与丈业丙(UnityEngine.Vector3 丛上丙丄丄七丈且丅)
    {
        UnityEngine.Vector3 val_1 = this.clusterBombPoint.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = 丛上丙丄丄七丈且丅.x, y = 丛上丙丄丄七丈且丅.y, z = 丛上丙丄丄七丈且丅.z});
        UnityEngine.Quaternion val_3 = this.clusterBombPoint.rotation;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.clusterPrefab, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        BaseMovementTurretRocket val_5 = val_4.GetComponent<BaseMovementTurretRocket>();
        UnityEngine.Vector3 val_7 = this.clusterBombPoint.forward;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  2f);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 丛上丙丄丄七丈且丅.x, y = 丛上丙丄丄七丈且丅.y, z = 丛上丙丄丄七丈且丅.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.clusterBombSpeed);
        val_4.GetComponent<UnityEngine.Rigidbody>().velocity = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        if((val_4.GetComponent<BaseAttackTurretRocket>()) == null)
        {
            
        }
    
    }
    public FortTrapClasterExplosion()
    {
        this.clusterBombSpeed = Infinityf;
        this.offsetMultiplier = 1f;
    }

}
