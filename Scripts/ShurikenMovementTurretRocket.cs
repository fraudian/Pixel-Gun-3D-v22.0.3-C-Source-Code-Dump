using UnityEngine;
internal sealed class ShurikenMovementTurretRocket : BaseMovementTurretRocket
{
    // Fields
    private TurretControllerScene_BoomerangRocketLauncher 丁下丘七丙世东丗丅;
    private UnityEngine.Vector3 startPosition;
    private UnityEngine.Vector3 targetPosition;
    private float distance;
    private bool nowMoveToTarget;
    private float distanceDelta;
    private UnityEngine.Vector3 丆东丑上丟丅丐丟丑;
    private bool 丙不专下丟与世业万;
    private float 丏丂丁一丑丟丏三东;
    private UnityEngine.Vector3 丕三丘七丘一丐业丌;
    private RotatorOnOff rotator;
    
    // Methods
    protected override void 世丙丟丗丆丂东且三()
    {
        this.下丏且一三丐一丐不();
    }
    private void 下丏且一三丐一丐不()
    {
        float val_10;
        float val_11;
        float val_12;
        UnityEngine.Vector3 val_16;
        float val_17;
        float val_18;
        if(this.丙不专下丟与世业万 == false)
        {
            goto label_1;
        }
        
        float val_10 = 0.02f;
        val_10 = S12 * val_10;
        val_10 = val_10 * UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  val_10, a:  new UnityEngine.Vector3() {x = this.丕三丘七丘一丐业丌, y = V9.16B, z = V8.16B});
        val_10 = val_2.x;
        val_11 = val_2.y;
        val_12 = val_2.z;
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().position;
        if(this.nowMoveToTarget == false)
        {
            goto label_5;
        }
        
        goto label_8;
        label_1:
        if(this.丁下丘七丙世东丗丅 == 0)
        {
                return;
        }
        
        this.丁下丘七丙世东丗丅.且丌万七丞丏丂丑上();
        return;
        label_5:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
        val_10 = val_6.x;
        val_11 = val_6.y;
        val_12 = val_6.z;
        label_8:
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
        val_16 = val_7.x;
        val_17 = val_7.y;
        val_18 = val_7.z;
        if((this.丈不丒丐下丝下三万(且丌上七丅东与丁万:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) != true)
        {
                val_16 = this.startPosition;
        }
        
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18};
    }
    private bool 丈不丒丐下丝下三万(UnityEngine.Vector3 且丌上七丅东与丁万)
    {
        UnityEngine.Vector3 val_9;
        float val_10;
        bool val_11;
        val_9 = 且丌上七丅东与丁万.x;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        if(this.nowMoveToTarget != false)
        {
                val_9 = this.startPosition;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_9, y = 且丌上七丅东与丁万.z, z = 且丌上七丅东与丁万.y})) > this.distance)
        {
                this.nowMoveToTarget = false;
        }
        
            val_11 = 1;
            return (bool)val_11;
        }
        
        val_10 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_9, y = 且丌上七丅东与丁万.y, z = 且丌上七丅东与丁万.z});
        UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
        val_11 = true;
        if(val_10 <= (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = this.startPosition, y = 且丌上七丅东与丁万.y, z = 且丌上七丅东与丁万.z})))
        {
                return (bool)val_11;
        }
        
        this.nowMoveToTarget = val_11;
        this.丙不专下丟与世业万 = false;
        val_10 = this.startPosition;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_10, y = 且丌上七丅东与丁万.y, z = val_9};
        this.丁丆丏上丂丒丒丏上();
        val_11 = 0;
        return (bool)val_11;
    }
    internal override void 丐且丞丕丞三丏丌丄(UnityEngine.Vector3 上不一丗下世丂丞与, float 丟丞一专丕三东丗一, float 丌七丒世丄上丞丞丁)
    {
        mem[1152921540135781616] = 丟丞一专丕三东丗一;
        mem[1152921540135781652] = 上不一丗下世丂丞与.z;
        this.distance = 丌七丒世丄上丞丞丁;
        this.nowMoveToTarget = true;
        this.丙不专下丟与世业万 = true;
        this.targetPosition = 上不一丗下世丂丞与;
        mem[1152921540135781648] = 上不一丗下世丂丞与.y;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        this.startPosition = val_2;
        mem[1152921540135781636] = val_2.y;
        mem[1152921540135781640] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 上不一丗下世丂丞与.x, y = 上不一丗下世丂丞与.y, z = 上不一丗下世丂丞与.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.丕三丘七丘一丐业丌 = val_3;
        mem[1152921540135781692] = val_3.y;
        mem[1152921540135781696] = val_3.z;
        this.rotator.丒丕丝丄与不三丅丘();
    }
    internal void 世业丄丐三丂丛丈世(TurretControllerScene_BoomerangRocketLauncher 丁下丘七丙世东丗丅)
    {
        this.丁下丘七丙世东丗丅 = 丁下丘七丙世东丗丅;
    }
    private void 丁丆丏上丂丒丒丏上()
    {
        this.丁下丘七丙世东丗丅.丁丆丏上丂丒丒丏上();
    }
    internal void 世丛丗丛丂丌丒丑专()
    {
        if(this == 0)
        {
                return;
        }
        
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = this.startPosition, y = V9.16B, z = V10.16B};
        this.丙不专下丟与世业万 = false;
        if(this.rotator == 0)
        {
                return;
        }
        
        this.rotator.且丐丐丞丘丐丐丗丏();
    }
    public ShurikenMovementTurretRocket()
    {
        this.distance = 10f;
        this.distanceDelta = 0.2f;
    }

}
