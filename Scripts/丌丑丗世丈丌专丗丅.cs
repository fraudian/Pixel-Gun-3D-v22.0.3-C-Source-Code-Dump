using UnityEngine;
private sealed class VehicleView.丌丑丗世丈丌专丗丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public VehicleView 丝且与丝丒丟万丁专;
    private UnityEngine.Color 丙业不丒丄下与丄丝;
    private float 与丑东丄且丝丕三丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VehicleView.丌丑丗世丈丌专丗丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        var val_6;
        float val_7;
        int val_8;
        float val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = 0.4f;
        val_5 = 0f;
        val_6 = this;
        this.与丑东丄且丝丕三丒 = 0f;
        mem[1152921536159637016] = 0;
        mem[1152921536159637020] = 0;
        mem[1152921536159637028] = 0;
        goto label_3;
        label_0:
        val_6 = this;
        val_7 = this.与丑东丄且丝丕三丒;
        val_4 = 1f;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_7 < 0)
        {
            goto label_3;
        }
        
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 * 3f;
        val_1 = val_5 + val_1;
        this.与丑东丄且丝丕三丒 = val_1;
        UnityEngine.Color val_2 = UnityEngine.Color.black;
        UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, b:  new UnityEngine.Color() {r = this.丙业不丒丄下与丄丝}, t:  this.与丑东丄且丝丕三丒);
        val_9 = val_3.r;
        this.丝且与丝丒丟万丁专.color = new UnityEngine.Color() {r = val_9, g = val_3.g, b = val_3.b, a = val_3.a};
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
