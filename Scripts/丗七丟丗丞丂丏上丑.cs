using UnityEngine;
private sealed class WindowAnimator.丗七丟丗丞丂丏上丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.WindowAnimator 丝且与丝丒丟万丁专;
    public UnityEngine.Vector3 丈丗与丞一上且上上;
    public UnityEngine.Vector3 专丂丕丗丗东世丞下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WindowAnimator.丗七丟丗丞丂丏上丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        var val_8;
        var val_9;
        UnityEngine.Vector3 val_10;
        float val_11;
        int val_12;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.<一三七丑丆丐丙丈一>k__BackingField = 0f;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        label_8:
        val_8 = this.丝且与丝丒丟万丁专;
        if((this.丝且与丝丒丟万丁专.<一三七丑丆丐丙丈一>k__BackingField) <= 1f)
        {
            goto label_9;
        }
        
        mem2[0] = 1065353216;
        goto label_7;
        label_3:
        mem[52] = 0f;
        label_4:
        this.丝且与丝丒丟万丁专.丏丙丒专世东丕丛丈(下丐丈丄丗丞丕业丆:  true);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        label_5:
        val_8 = 52;
        if(mem[52] <= 1f)
        {
            goto label_9;
        }
        
        mem[52] = 1065353216;
        label_7:
        val_9 = this.丝且与丝丒丟万丁专.gameObject;
        val_10 = this.专丂丕丗丗东世丞下;
        val_7 = val_9.transform;
        val_7.localPosition = new UnityEngine.Vector3() {x = val_10, y = V9.16B, z = V10.16B};
        this.丝且与丝丒丟万丁专.丑世丒丑丟三丝丁丑 = 0;
        this.丝且与丝丒丟万丁专.丏丙丒专世东丕丛丈(下丐丈丄丗丞丕业丆:  false);
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_9:
        val_9 = this.丝且与丝丒丟万丁专.gameObject.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丈丗与丞一上且上上, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.专丂丕丗丗东世丞下, y = V12.16B, z = V13.16B}, t:  this.丝且与丝丒丟万丁专 + 52);
        val_11 = val_5.z;
        val_9.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_11};
        val_10 = mem[this.丝且与丝丒丟万丁专 + 52];
        val_10 = this.丝且与丝丒丟万丁专 + 52;
        float val_6 = UnityEngine.Time.deltaTime;
        float val_7 = 1f;
        val_7 = val_7 / this.丝且与丝丒丟万丁专._animationTime;
        val_6 = val_7 * val_6;
        val_12 = 1;
        val_6 = val_10 + val_6;
        mem2[0] = val_6;
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
