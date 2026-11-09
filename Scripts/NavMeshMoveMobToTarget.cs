using UnityEngine;
internal class NavMeshMoveMobToTarget : MoveMobToTarget
{
    // Fields
    private System.Action 专丈丄七丄与东丐业;
    private System.Action 丕丑不丐丙万业上且;
    private float 丕丛丘丞且不三专世;
    private UnityEngine.Vector3 丛丞丐七丌三七万东;
    
    // Methods
    internal void 万世丙下丏下东丒丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专丈丄七丄与东丐业, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丈丄七丄与东丐业 != 1152921540026830544);
    
    }
    internal void 丐丐东一丟业丕丝且(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专丈丄七丄与东丐业, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丈丄七丄与东丐业 != 1152921540026967120);
    
    }
    internal void 不丗业丁专一丁上不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕丑不丐丙万业上且, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丑不丐丙万业上且 != 1152921540027103704);
    
    }
    internal void 丄丂丐丙丁丝下且与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕丑不丐丙万业上且, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丑不丐丙万业上且 != 1152921540027240280);
    
    }
    public override void SetTarget(UnityEngine.Transform 丞下万上三丘上与专, object[] 丗专丆万丏万丂丂丆)
    {
        this.SetTarget(丞下万上三丘上与专:  丞下万上三丘上与专, 丗专丆万丏万丂丂丆:  丗专丆万丏万丂丂丆);
        if(丗专丆万丏万丂丂丆.Length == 0)
        {
                return;
        }
        
        object val_1 = 丗专丆万丏万丂丂丆[0];
        this.丕丛丘丞且不三专世 = null;
    }
    public override void MoveToTarget()
    {
        var val_14;
        float val_15;
        float val_16;
        float val_17;
        val_14 = 1152921504848912384;
        if((static_value_082C0000 == 0) && (this.丕丑不丐丙万业上且 != null))
        {
                this.丕丑不丐丙万业上且.Invoke();
        }
        
        if(static_value_082C0000 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = position;
        val_15 = val_3.x;
        val_16 = val_3.z;
        val_17 = this.丕丛丘丞且不三专世;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_15, y = val_3.y, z = val_16}, b:  new UnityEngine.Vector3() {x = this.丛丞丐七丌三七万东, y = V11.16B, z = V10.16B})) > val_17)
        {
                UnityEngine.Vector3 val_5 = position;
            this.丛丞丐七丌三七万东 = val_5;
            mem[1152921540027591272] = val_5.y;
            mem[1152921540027591276] = val_5.z;
            UnityEngine.AI.NavMeshAgent val_6 = 丅不丂下丐专丙丗丗();
            UnityEngine.Vector3 val_7 = position;
            val_15 = val_7.x;
            val_17 = val_7.y;
            val_16 = val_7.z;
            bool val_8 = val_6.SetDestination(target:  new UnityEngine.Vector3() {x = val_15, y = val_17, z = val_16});
        }
        
        UnityEngine.Vector3 val_9 = val_6.position;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = val_10.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) >= 0)
        {
                return;
        }
        
        if(this.专丈丄七丄与东丐业 == null)
        {
                return;
        }
        
        val_10.丅不丂下丐专丙丗丗().isStopped = true;
        this.专丈丄七丄与东丐业.Invoke();
    }
    public NavMeshMoveMobToTarget()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  1000f);
        this.丛丞丐七丌三七万东 = val_2;
        mem[1152921540027727848] = val_2.y;
        mem[1152921540027727852] = val_2.z;
    }

}
