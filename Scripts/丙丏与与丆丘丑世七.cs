using UnityEngine;
private sealed class DuelController.丙丏与与丆丘丑世七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public DuelController 丝且与丝丒丟万丁专;
    public float 丞丕丙不一丙业三丕;
    private UnityEngine.Vector3 丆三专三与丆业与丘;
    private UnityEngine.Vector3 万丒且丕丘三丝丙业;
    private float 丂丅万七丙上下丂七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DuelController.丙丏与与丆丘丑世七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        var val_13;
        UnityEngine.Vector3 val_14;
        var val_15;
        UnityEngine.Vector3 val_16;
        var val_17;
        var val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        UnityEngine.Vector3 val_23;
        var val_28;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_12 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_12;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            this.丝且与丝丒丟万丁专.丑丂丂七丘东丅七东 = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_13 = this;
            mem[1152921525937147204] = val_1.z;
            val_14 = 1152921525937147204;
            val_15 = 1152921525937147204;
            mem[1152921525937147196] = val_1.x;
            mem[1152921525937147200] = val_1.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.丞丕丙不一丙业三丕);
            val_16 = 1152921525937147208;
            val_17 = 1152921525937147212;
            mem[1152921525937147208] = val_3.x;
            mem[1152921525937147212] = val_3.y;
            val_18 = 1152921525937147216;
            mem[1152921525937147216] = val_3.z;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_4 * 5.5f;
            mem[1152921525937147220] = val_4;
        }
        else
        {
                val_14 = this.丆三专三与丆业与丘;
            val_15 = 1152921525937147200;
            val_13 = 1152921525937147204;
            val_16 = this.万丒且丕丘三丝丙业;
            val_17 = 1152921525937147212;
            val_18 = 1152921525937147216;
            this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        val_19 = mem[this.丆三专三与丆业与丘];
        val_19 = this.丆三专三与丆业与丘.x;
        val_20 = mem[this.万丒且丕丘三丝丙业];
        val_20 = this.万丒且丕丘三丝丙业.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_19, y = 9.543596E-23f, z = 9.543596E-23f}, rhs:  new UnityEngine.Vector3() {x = val_20, y = 9.543596E-23f, z = 9.543596E-23f})) == false)
        {
            goto label_9;
        }
        
        val_20 = mem[this.丆三专三与丆业与丘];
        val_20 = this.丆三专三与丆业与丘.x;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.万丒且丕丘三丝丙业.x, y = 9.543596E-23f, z = 9.543596E-23f}, b:  new UnityEngine.Vector3() {x = val_20, y = 9.543596E-23f, z = 9.543596E-23f});
        if((val_6.x == 0f) || (val_6.x <= this.丂丅万七丙上下丂七))
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_6.x);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.丂丅万七丙上下丂七);
        val_19 = val_8.x;
        val_22 = val_8.y;
        val_23 = this.丆三专三与丆业与丘;
        val_21 = val_8.z;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23, y = val_8.y, z = this.丂丅万七丙上下丂七}, b:  new UnityEngine.Vector3() {x = val_19, y = val_22, z = val_21});
        val_28 = val_9.z;
        goto label_16;
        label_9:
        val_12 = 0;
        this.丝且与丝丒丟万丁专.丑丂丂七丘东丅七东 = false;
        return (bool)val_12;
        label_13:
        val_20 = mem[this.丆三专三与丆业与丘];
        val_20 = this.丆三专三与丆业与丘.x;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.万丒且丕丘三丝丙业.x, y = 9.543596E-23f, z = 9.543596E-23f}, b:  new UnityEngine.Vector3() {x = val_20, y = 9.543596E-23f, z = 9.543596E-23f});
        val_19 = val_10.x;
        val_22 = val_10.y;
        val_23 = mem[this.万丒且丕丘三丝丙业];
        val_23 = this.万丒且丕丘三丝丙业.x;
        val_21 = val_10.z;
        label_16:
        mem2[0] = val_23;
        mem[1152921525937147200] = null;
        mem[1152921525937147204] = null;
        DuelUIController val_11 = this.丝且与丝丒丟万丁专.duelUI;
        val_11.betScrollView.MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_19, y = val_22, z = val_21});
        val_12 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
