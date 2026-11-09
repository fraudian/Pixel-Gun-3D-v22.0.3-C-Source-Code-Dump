using UnityEngine;
private sealed class AgentLinkMover.丞上丑丝丁丂丄世丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅;
    public float 丟丌丐丘丆丙丑丑一;
    public float 与丈业丛丝丒丙一丏;
    private UnityEngine.Vector3 丟丘丐一下丗丑丘且;
    private UnityEngine.Vector3 丘上三丈丏丑丙丘丄;
    private float 丞与上丅丗丏丙丆世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AgentLinkMover.丞上丑丝丁丂丄世丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        float val_22;
        int val_23;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.AI.OffMeshLinkData val_1 = this.七丘东丞世丆丕丙丅.currentOffMeshLinkData;
        UnityEngine.Vector3 val_6 = this.七丘东丞世丆丕丙丅.transform.position;
        this.丟丘丐一下丗丑丘且 = val_6;
        mem[1152921538518781236] = val_6.y;
        mem[1152921538518781240] = val_6.z;
        UnityEngine.Vector3 val_7 = val_4.velocity;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.七丘东丞世丆丕丙丅.baseOffset);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        this.丘上三丈丏丑丙丘丄 = val_11;
        mem[1152921538518781248] = val_11.y;
        val_22 = 0f;
        mem[1152921538518781252] = val_11.z;
        this.丞与上丅丗丏丙丆世 = 0f;
        goto label_10;
        label_1:
        val_22 = this.丞与上丅丗丏丙丆世;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_22 < 0)
        {
            goto label_10;
        }
        
        label_2:
        val_23 = 0;
        return (bool)val_23;
        label_10:
        float val_13 = this.丟丌丐丘丆丙丑丑一 * 4f;
        val_13 = (val_22 - (val_22 * val_22)) * val_13;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丟丘丐一下丗丑丘且, y = val_7.z, z = V15.16B}, b:  new UnityEngine.Vector3() {x = this.丘上三丈丏丑丙丘丄, y = val_8.z, z = val_8.x}, t:  this.丞与上丅丗丏丙丆世);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  val_13, a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        this.七丘东丞世丆丕丙丅.transform.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        float val_20 = UnityEngine.Time.deltaTime;
        val_23 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_23;
        val_20 = val_20 / this.与丈业丛丝丒丙一丏;
        val_20 = this.丞与上丅丗丏丙丆世 + val_20;
        this.丞与上丅丗丏丙丆世 = val_20;
        return (bool)val_23;
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
