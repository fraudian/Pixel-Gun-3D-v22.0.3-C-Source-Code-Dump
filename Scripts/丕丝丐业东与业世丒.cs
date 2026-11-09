using UnityEngine;
private sealed class AimCrosshairController.丕丝丐业东与业世丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AimCrosshairController 丝且与丝丒丟万丁专;
    public UnityEngine.Color 丑丞丈丗丄丙丟万丄;
    public System.Action 业丏丈世世世丞丒世;
    private float 上上丄一丙万丟丛丄;
    private UnityEngine.Color 专丏且丝丂丈丑丁丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AimCrosshairController.丕丝丐业东与业世丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        float val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        val_4 = this;
        this.上上丄一丙万丟丛丄 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this.上上丄一丙万丟丛丄;
        this.专丏且丝丂丈丑丁丈 = this.丝且与丝丒丟万丁专.丄与丏且丟世丞丟专;
        mem[1152921538077117176] = ???;
        mem[1152921538077117184] = ???;
        goto label_4;
        label_0:
        val_4 = this;
        val_5 = this.上上丄一丙万丟丛丄;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(val_5 <= this.丝且与丝丒丟万丁专.crosshairColorLerpSpeed)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.SetCrosshairColor(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丑丞丈丗丄丙丟万丄});
        if(this.业丏丈世世世丞丒世 != null)
        {
                this.业丏丈世世世丞丒世.Invoke();
        }
        
        val_6 = 0;
        this.丝且与丝丒丟万丁专.一上丒不丈丁七丟丗 = 0;
        return (bool)val_6;
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_5:
        float val_2 = this.上上丄一丙万丟丛丄 + UnityEngine.Time.deltaTime;
        this.上上丄一丙万丟丛丄 = val_2;
        val_2 = val_2 / this.丝且与丝丒丟万丁专.crosshairColorLerpSpeed;
        UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.专丏且丝丂丈丑丁丈}, b:  new UnityEngine.Color() {r = this.丑丞丈丗丄丙丟万丄}, t:  val_2);
        this.专丏且丝丂丈丑丁丈 = val_3;
        mem[1152921538077117176] = val_3.g;
        mem[1152921538077117180] = val_3.b;
        mem[1152921538077117184] = val_3.a;
        this.丝且与丝丒丟万丁专.SetCrosshairColor(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
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
