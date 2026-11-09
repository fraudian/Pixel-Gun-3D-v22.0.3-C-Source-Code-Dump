using UnityEngine;
private sealed class AppsMenu.且东丘丙东丂丘丁东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public AppsMenu 丝且与丝丒丟万丁专;
    public float 丅世丗丛万下下专丕;
    private UnityEngine.Color 东七丄不不世世世丆;
    private float 丞丂三丘丘专丝下丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AppsMenu.且东丘丙东丂丘丁东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        int val_17;
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
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        val_13 = this;
        this.丞丂三丘丘专丝下丁 = 0f;
        mem[1152921524383554636] = val_1.r;
        mem[1152921524383554640] = val_1.g;
        mem[1152921524383554644] = val_1.b;
        mem[1152921524383554648] = val_1.a;
        val_14 = 1152921524383554632;
        val_15 = 0f;
        goto label_4;
        label_1:
        val_16 = this.丞丂三丘丘专丝下丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_2:
        val_13 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "WaitForEndOfFrame="("WaitForEndOfFrame=") + this.丞丂三丘丘专丝下丁);
        val_14 = this;
        float val_4 = UnityEngine.Mathf.Clamp01(value:  this.丞丂三丘丘专丝下丁 / this.丅世丗丛万下下专丕);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Draw tm="("Draw tm=") + this.丞丂三丘丘专丝下丁);
        val_15 = this.丞丂三丘丘专丝下丁;
        label_4:
        if(val_15 < 0)
        {
            goto label_11;
        }
        
        this.丝且与丝丒丟万丁专.丁丒丂丘丌丛丕丕丟();
        this.丞丂三丘丘专丝下丁 = this.丅世丗丛万下下专丕;
        val_16 = this.丅世丗丛万下下专丕;
        label_5:
        if(val_16 > 0f)
        {
            goto label_13;
        }
        
        label_3:
        val_17 = 0;
        return (bool)val_17;
        label_11:
        val_14 = 1152921504624205824;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  System.String.Format(format:  "Start Draw tm={0} deltatime = {1}", arg0:  val_15, arg1:  UnityEngine.Time.deltaTime));
        val_16 = this.丞丂三丘丘专丝下丁;
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = val_16 + val_8;
        this.丞丂三丘丘专丝下丁 = val_8;
        val_17 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_17;
        label_13:
        float val_10 = UnityEngine.Time.deltaTime;
        val_16 = val_16 - val_10;
        this.丞丂三丘丘专丝下丁 = val_16;
        val_10 = val_16 / this.丅世丗丛万下下专丕;
        float val_11 = UnityEngine.Mathf.Clamp01(value:  val_10);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_17 = 1;
        return (bool)val_17;
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
