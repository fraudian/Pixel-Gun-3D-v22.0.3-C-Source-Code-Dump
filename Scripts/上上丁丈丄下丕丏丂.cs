using UnityEngine;
public class 上上丁丈丄下丕丏丂
{
    // Fields
    private PhotonTransformViewPositionModel 丆丘不丛丁丅丙丙东;
    private float 下丛丛丗上上丁丏丑;
    private double 丙世丆丈丆丂丈丒东;
    private UnityEngine.Vector3 万丙与丞且专丐专丂;
    private float 丅丄丟丛丏专丙世丕;
    private UnityEngine.Vector3 专丝丄且丝东丆丂与;
    private System.Collections.Generic.Queue<UnityEngine.Vector3> 丗一与世丟七七丄丌;
    private bool 丒业丗东丕东丌丞丐;
    
    // Methods
    public 上上丁丈丄下丕丏丂(PhotonTransformViewPositionModel 丟丞丄万丂丗丟丆七)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.万丙与丞且专丐专丂 = val_1;
        mem[1152921535603072700] = val_1.y;
        mem[1152921535603072704] = val_1.z;
        this.丗一与世丟七七丄丌 = new System.Collections.Generic.Queue<UnityEngine.Vector3>();
        this.丒业丗东丕东丌丞丐 = true;
        this.丆丘不丛丁丅丙丙东 = 丟丞丄万丂丗丟丆七;
    }
    private UnityEngine.Vector3 三丁与且丈三丑上丅()
    {
        System.Collections.Generic.Queue<UnityEngine.Vector3> val_3;
        UnityEngine.Vector3 val_4;
        float val_5;
        float val_6;
        val_3 = this;
        val_4 = this.专丝丄且丝东丆丂与;
        if(this.丗一与世丟七七丄丌.Count < 1)
        {
                return new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        }
        
        val_3 = this.丗一与世丟七七丄丌;
        UnityEngine.Vector3 val_2 = val_3.Peek();
        val_4 = val_2.x;
        val_5 = val_2.y;
        val_6 = val_2.z;
        return new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
    }
    public void 丙七丆丆上丁丘不丈(UnityEngine.Vector3 丟丞一专丕三东丗一, float 丄丒丄丌丆丞专丌下)
    {
        this.万丙与丞且专丐专丂 = 丟丞一专丕三东丗一;
        mem[1152921535603323324] = 丟丞一专丕三东丗一.y;
        mem[1152921535603323328] = 丟丞一专丕三东丗一.z;
        this.丅丄丟丛丏专丙世丕 = 丄丒丄丌丆丞专丌下;
    }
    public UnityEngine.Vector3 七丒下丂丝且丕丌东(UnityEngine.Vector3 丒不三丁丒丏丂丒丈)
    {
        float val_18;
        float val_19;
        float val_23;
        float val_24;
        float val_25;
        val_18 = 丒不三丁丒丏丂丒丈.z;
        UnityEngine.Vector3 val_1 = this.万一丌与丞丕丑丂不();
        val_19 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.专丝丄且丝东丆丂与, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_19});
        val_23 = val_2.y;
        val_24 = 丒不三丁丒丏丂丒丈.y;
        val_25 = 丒不三丁丒丏丂丒丈.x;
        if(this.丆丘不丛丁丅丙丙东.InterpolateOption <= 4)
        {
                var val_18 = 106031064 + (this.丆丘不丛丁丅丙丙东.InterpolateOption) << 2;
            val_18 = val_18 + 106031064;
        }
        else
        {
                if(this.丆丘不丛丁丅丙丙东.TeleportEnabled == false)
        {
                return new UnityEngine.Vector3() {x = val_25};
        }
        
            val_23 = this.专丝丄且丝东丆丂与;
            val_19 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {}, b:  new UnityEngine.Vector3() {x = val_23, z = val_2.z});
            if(val_19 <= this.丆丘不丛丁丅丙丙东.TeleportIfDistanceGreaterThan)
        {
                return new UnityEngine.Vector3() {x = val_25};
        }
        
            val_25 = this.专丝丄且丝东丆丂与;
            return new UnityEngine.Vector3() {x = val_25};
        }
    
    }
    public UnityEngine.Vector3 丕丘东丏丂下丕丐丟()
    {
        return new UnityEngine.Vector3() {x = this.专丝丄且丝东丆丂与};
    }
    public UnityEngine.Vector3 万一丌与丞丕丑丂不()
    {
        PhotonTransformViewPositionModel val_16;
        double val_17;
        float val_18;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_33;
        float val_34;
        float val_35;
        val_16 = this;
        val_17 = this.丙世丆丈丆丂丈丒东;
        val_18 = (float)丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - val_17;
        if(this.丆丘不丛丁丅丙丙东.ExtrapolateIncludingRoundTripTime != false)
        {
                float val_16 = 1000f;
            val_17 = (float)丅丒丗丑丒丙丛不丆.丒丘丞东丝东七一丛();
            val_16 = val_17 / val_16;
            val_18 = val_16 + val_18;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_22 = val_4.x;
        val_23 = val_4.y;
        val_24 = val_4.z;
        if(this.丆丘不丛丁丅丙丙东.ExtrapolateOption == 3)
        {
            goto label_10;
        }
        
        if(this.丆丘不丛丁丅丙丙东.ExtrapolateOption == 2)
        {
            goto label_11;
        }
        
        if(this.丆丘不丛丁丅丙丙东.ExtrapolateOption != 1)
        {
                return new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24};
        }
        
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_18 * this.丅丄丟丛丏专丙世丕, z:  0f);
        val_26 = val_6.w;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.万丙与丞且专丐专丂, y = V14.16B, z = V13.16B}, d:  val_18);
        val_27 = val_6.x;
        val_28 = val_6.y;
        val_29 = val_6.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_27, y = val_28, z = val_29, w = val_26}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        goto label_17;
        label_10:
        UnityEngine.Vector3 val_9 = this.三丁与且丈三丑上丅();
        val_26 = val_9.x;
        val_25 = val_9.z;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.专丝丄且丝东丆丂与, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_26, y = val_9.y, z = val_25});
        val_16 = this.丆丘不丛丁丅丙丙东;
        val_33 = val_10.x;
        val_34 = val_10.y;
        val_35 = val_10.z;
        if(val_16 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_11:
        UnityEngine.Vector3 val_11 = this.三丁与且丈三丑上丅();
        val_26 = val_11.x;
        val_25 = val_11.z;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.专丝丄且丝东丆丂与, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_26, y = val_11.y, z = val_25});
        val_33 = val_12.x;
        val_34 = val_12.y;
        val_35 = val_12.z;
        label_21:
        val_27 = val_33;
        val_28 = val_34;
        val_29 = val_35;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, d:  (float)丅丒丗丑丒丙丛不丆.丑上丞丒丞丁七丌七());
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_18);
        label_17:
        val_22 = val_15.x;
        val_23 = val_15.y;
        val_24 = val_15.z;
        return new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24};
    }
    public void 丁万丂丝丘业丈丛丘(UnityEngine.Vector3 丒不三丁丒丏丂丒丈, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(this.丆丘不丛丁丅丙丙东.SynchronizeEnabled == false)
        {
                return;
        }
        
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                this.丆一丆丙三丅世专丐(丒不三丁丒丏丂丒丈:  new UnityEngine.Vector3() {x = 丒不三丁丒丏丂丒丈.x, y = 丒不三丁丒丏丂丒丈.y, z = 丒不三丁丒丏丂丒丈.z}, 东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 不丟丗丏丛丕不丁丌 = 东一丁世丑丞业丄丐.不丟丗丏丛丕不丁丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        }
        else
        {
                this.丘丙丂丈丟上丌丟丙(东业丄丅丅且世七丄:  东业丄丅丅且世七丄, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东() {丒世丗丐专世丛丞丌 = 东一丁世丑丞业丄丐.丒世丗丐专世丛丞丌, 不丟丗丏丛丕不丁丌 = 东一丁世丑丞业丄丐.不丟丗丏丛丕不丁丌, 丄丈丑丐丆丞丘与丗 = 东一丁世丑丞业丄丐.丄丈丑丐丆丞丘与丗});
        }
        
        this.丙世丆丈丆丂丈丒东 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.丒业丗东丕东丌丞丐 = false;
    }
    private void 丆一丆丙三丅世专丐(UnityEngine.Vector3 丒不三丁丒丏丂丒丈, 下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        PhotonTransformViewPositionModel val_1;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丒不三丁丒丏丂丒丈);
        this.专丝丄且丝东丆丂与 = 丒不三丁丒丏丂丒丈;
        mem[1152921535604068588] = 丒不三丁丒丏丂丒丈.y;
        mem[1152921535604068592] = 丒不三丁丒丏丂丒丈.z;
        if(this.丆丘不丛丁丅丙丙东.ExtrapolateOption != 1)
        {
                val_1 = this.丆丘不丛丁丅丙丙东;
            if(this.丆丘不丛丁丅丙丙东.InterpolateOption != 3)
        {
                return;
        }
        
        }
        
        val_1 = this.万丙与丞且专丐专丂;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.万丙与丞且专丐专丂);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丅丄丟丛丏专丙世丕);
    }
    private void 丘丙丂丈丟上丌丟丙(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        float val_7;
        var val_8;
        UnityEngine.Vector3 val_9;
        float val_10;
        object val_1 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        if(this.丆丘不丛丁丅丙丙东.ExtrapolateOption != 1)
        {
                if(this.丆丘不丛丁丅丙丙东.InterpolateOption != 3)
        {
            goto label_5;
        }
        
        }
        
        object val_2 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.万丙与丞且专丐专丂 = new UnityEngine.Vector3();
        mem[1152921535604294160] = ???;
        object val_3 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丅丄丟丛丏专丙世丕 = null;
        label_5:
        if(this.丗一与世丟七七丄丌.Count != 0)
        {
                val_8 = 1152921535604294176;
            val_9 = this.专丝丄且丝东丆丂与;
        }
        else
        {
                mem[1152921535604294176] = ???;
            val_8 = 1152921535604294176;
            this.专丝丄且丝东丆丂与 = new UnityEngine.Vector3();
            mem[1152921535604294172] = ???;
            val_9 = 3.782474E-38f;
            val_10 = W22;
            val_7 = W23;
        }
        
        this.丗一与世丟七七丄丌.Enqueue(item:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_7});
        this.专丝丄且丝东丆丂与 = new UnityEngine.Vector3();
        mem[1152921535604294172] = ???;
        mem[1152921535604294176] = ???;
        goto label_12;
        label_16:
        UnityEngine.Vector3 val_5 = this.丗一与世丟七七丄丌.Dequeue();
        label_12:
        if(this.丗一与世丟七七丄丌.Count > this.丆丘不丛丁丅丙丙东.ExtrapolateNumberOfStoredPositions)
        {
            goto label_16;
        }
    
    }

}
