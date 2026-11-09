using UnityEngine;
private sealed class AgentLinkMover.丞业丐丆专三丘不丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅;
    public UnityEngine.AnimationCurve 专一上世业丗丒丘不;
    public float 与丈业丛丝丒丙一丏;
    private UnityEngine.Vector3 丟丘丐一下丗丑丘且;
    private UnityEngine.Vector3 丘上三丈丏丑丙丘丄;
    private float 丞与上丅丗丏丙丆世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AgentLinkMover.丞业丐丆专三丘不丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        float val_20;
        float val_21;
        int val_22;
        float val_23;
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
        mem[1152921538519548472] = val_6.y;
        mem[1152921538519548476] = val_6.z;
        UnityEngine.Vector3 val_7 = val_4.velocity;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.七丘东丞世丆丕丙丅.baseOffset);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_20 = 0f;
        this.丘上三丈丏丑丙丘丄 = val_11;
        mem[1152921538519548484] = val_11.y;
        mem[1152921538519548488] = val_11.z;
        this.丞与上丅丗丏丙丆世 = 0f;
        goto label_10;
        label_1:
        val_21 = this.丞与上丅丗丏丙丆世;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_21 < 0)
        {
            goto label_10;
        }
        
        label_2:
        val_22 = 0;
        return (bool)val_22;
        label_10:
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丟丘丐一下丗丑丘且, y = val_7.z, z = V15.16B}, b:  new UnityEngine.Vector3() {x = this.丘上三丈丏丑丙丘丄, y = val_8.z, z = val_8.x}, t:  this.丞与上丅丗丏丙丆世);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(d:  this.专一上世业丗丒丘不.Evaluate(time:  val_20), a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        this.七丘东丞世丆丕丙丅.transform.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        val_23 = this.丞与上丅丗丏丙丆世;
        float val_18 = UnityEngine.Time.deltaTime;
        val_22 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_22;
        val_18 = val_18 / this.与丈业丛丝丒丙一丏;
        val_18 = val_23 + val_18;
        this.丞与上丅丗丏丙丆世 = val_18;
        return (bool)val_22;
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
