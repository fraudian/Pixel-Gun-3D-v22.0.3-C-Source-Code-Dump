using UnityEngine;
private sealed class AgentLinkMover.东丟丙丂丅上丏上丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅;
    private UnityEngine.Vector3 丒三东东丟丏丕不丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AgentLinkMover.东丟丙丂丅上丏上丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        float val_21;
        UnityEngine.AI.NavMeshAgent val_22;
        UnityEngine.Vector3 val_23;
        float val_24;
        float val_25;
        int val_26;
        val_21 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_12;
        }
        
        val_22 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.AI.OffMeshLinkData val_1 = this.七丘东丞世丆丕丙丅.currentOffMeshLinkData;
        UnityEngine.Vector3 val_5 = val_4.velocity;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.七丘东丞世丆丕丙丅.baseOffset);
        val_21 = val_5.x;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        this.丒三东东丟丏丕不丛 = val_9;
        mem[1152921538518022188] = val_9.y;
        mem[1152921538518022192] = val_9.z;
        goto label_7;
        label_1:
        val_22 = this.七丘东丞世丆丕丙丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        UnityEngine.Vector3 val_11 = mem[this.七丘东丞世丆丕丙丅].transform.position;
        val_23 = this.丒三东东丟丏丕不丛;
        val_25 = val_11.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_25, y = val_11.y, z = val_11.z}, rhs:  new UnityEngine.Vector3() {x = val_23, y = V11.16B, z = V10.16B})) != false)
        {
                UnityEngine.Vector3 val_15 = mem[this.七丘东丞世丆丕丙丅].transform.position;
            val_22 = this.七丘东丞世丆丕丙丅;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, target:  new UnityEngine.Vector3() {x = this.丒三东东丟丏丕不丛, y = V11.16B, z = val_23}, maxDistanceDelta:  val_22.speed * UnityEngine.Time.deltaTime);
            val_25 = val_19.x;
            val_24 = val_19.z;
            mem[this.七丘东丞世丆丕丙丅].transform.position = new UnityEngine.Vector3() {x = val_25, y = val_19.y, z = val_24};
            val_26 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_26;
            return (bool)val_26;
        }
        
        label_12:
        val_26 = 0;
        return (bool)val_26;
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
