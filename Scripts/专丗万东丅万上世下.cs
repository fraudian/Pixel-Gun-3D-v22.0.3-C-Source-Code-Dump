using UnityEngine;
private sealed class TransportViewBase.专丗万东丅万上世下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TransportViewBase 丝且与丝丒丟万丁专;
    private float 丅丁丕丏上丐东丕丆;
    private UnityEngine.Transform 丐不且专丆一丌七不;
    private UnityEngine.Vector3 丗上丛丒东世且丟丝;
    private UnityEngine.Vector3 丌不七丗丑不丈与丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TransportViewBase.专丗万东丅万上世下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TransportViewBase val_9;
        var val_10;
        float val_11;
        float val_12;
        float val_13;
        int val_14;
        val_9 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_10 = this;
        this.丅丁丕丏上丐东丕丆 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Transform val_1 = val_9.丌丟丄业且三丛丕丄();
        this.丐不且专丆一丌七不 = val_1;
        UnityEngine.Vector3 val_2 = val_1.localPosition;
        this.丗上丛丒东世且丟丝 = val_2;
        mem[1152921539416277660] = val_2.y;
        mem[1152921539416277664] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        val_11 = val_3.x;
        val_12 = val_3.z;
        UnityEngine.Vector3 val_4 = this.丐不且专丆一丌七不.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_11, y = val_3.y, z = val_12});
        this.丌不七丗丑不丈与丙 = val_4;
        mem[1152921539416277672] = val_4.y;
        mem[1152921539416277676] = val_4.z;
        goto label_8;
        label_1:
        val_10 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_5 * 1.3f;
        val_13 = this.丅丁丕丏上丐东丕丆 + val_5;
        this.丅丁丕丏上丐东丕丆 = val_13;
        if(val_9 == null)
        {
                val_13 = this.丅丁丕丏上丐东丕丆;
        }
        
        val_9 = this.丝且与丝丒丟万丁专.explosionJump;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丌不七丗丑不丈与丙, y = mem[1152921539416277672], z = mem[1152921539416277676]}, d:  val_9.Evaluate(time:  val_13));
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丗上丛丒东世且丟丝, y = mem[1152921539416277660], z = mem[1152921539416277664]}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_11 = val_8.x;
        val_12 = val_8.z;
        this.丐不且专丆一丌七不.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_8.y, z = val_12};
        label_8:
        if(this.丅丁丕丏上丐东丕丆 < 0)
        {
            goto label_14;
        }
        
        label_2:
        val_14 = 0;
        return (bool)val_14;
        label_14:
        val_14 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
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
