using UnityEngine;
private sealed class 与三七丝丆一且东丝.丌七丕丒与上丕下万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public System.Action 丝丝万丄丏丝世三丏;
    public float 丂三丟丂丈丐丆丗丟;
    public System.Action<float> 丄丙丞丁世上丄与与;
    public System.Action 丄丆丙业世丏与丞丛;
    private float 上上丄一丙万丟丛丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 与三七丝丆一且东丝.丌七丕丒与上丕下万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        float val_4;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(System.Math.Abs(this.丕丕世且下一与丝与) <= 0.001f)
        {
            goto label_6;
        }
        
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        val_4 = this.上上丄一丙万丟丛丄;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        if(this.丝丝万丄丏丝世三丏 != null)
        {
                this.丝丝万丄丏丝世三丏.Invoke();
        }
        
        this.上上丄一丙万丟丛丄 = 0f;
        val_4 = 0f;
        label_8:
        if(val_4 < 0)
        {
            goto label_10;
        }
        
        val_3 = this.丄丆丙业世丏与丞丛;
        if(val_3 == null)
        {
                return (bool)val_3;
        }
        
        val_3.Invoke();
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_10:
        float val_2 = UnityEngine.Time.unscaledDeltaTime;
        val_2 = val_4 + val_2;
        this.上上丄一丙万丟丛丄 = val_2;
        if(this.丄丙丞丁世上丄与与 != null)
        {
                val_2 = val_2 / this.丂三丟丂丈丐丆丗丟;
            this.丄丙丞丁世上丄与与.Invoke(obj:  val_2);
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_3 = 1;
        return (bool)val_3;
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
