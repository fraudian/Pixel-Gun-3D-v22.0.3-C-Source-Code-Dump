using UnityEngine;
private sealed class AuthSceneController.东丛丞东丅三丁丈一<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.Task<T> 东且丘且丟万丘丛丅;
    public AuthSceneController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.东丛丞东丅三丁丈一<T>(int 丗丏丅丕丆世丁专丟)
    {
        mem[1152921536254812496] = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_15;
        var val_16;
        string val_6 = 0;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_31;
        }
        
        mem[1152921536255069744] = 0;
        mem[1152921536255069752] = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  137162752);
        val_16 = 1;
        mem[1152921536255069744] = val_16;
        return (bool)val_16;
        label_1:
        mem[1152921536255069744] = 0;
        if(AuthSceneController.丄丙丂丝丄丌丗丂丅() != 13)
        {
            goto label_31;
        }
        
        if(this == null)
        {
            goto label_9;
        }
        
        if(this.丆丆丆不丂丑丂丙丅() == false)
        {
            goto label_10;
        }
        
        label_19:
        if(((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  this.业丑丁丆丕丆丂丅万(), 下上丐丆丝丟丝丒不:  "error", 丙业与丙丗丝不丈东: out  val_6)) == false) || ((val_6.Contains(value:  "server closed the connection unexpectedly")) == false))
        {
            goto label_15;
        }
        
        val_15 = "Server send incorrect response on event init_progress: "("Server send incorrect response on event init_progress: ") + val_6 + ". Restart authorization.";
        UnityEngine.Debug.LogError(message:  val_15);
        丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        goto label_31;
        label_9:
        if(this.丆丆丆不丂丑丂丙丅() == true)
        {
            goto label_19;
        }
        
        label_10:
        if(this.世丁丄不丑丝丟丅丞() != 1504)
        {
            goto label_20;
        }
        
        丐专丂世丌丙丙专一(丏业丟一东丂东丘丛:  10);
        NewVersionBanner.专丘丕一丏一三丆东(丙业与丙丗丝不丈东:  true);
        val_15 = 丏丑丐丌丗三丆且专();
        NewVersionBanner.下与丞三丅丛丄七丕(丅专与丒丈丗丒丘丌:  val_12.UpdateBannerPoint, 丆丑丞丅不丕丐丙丂:  0);
        goto label_31;
        label_15:
        Progress.七七世万专丕丁上业.丛丄丌丞丟丂一丙七(业下丌下三丕丙丌下:  this.业丑丁丆丕丆丂丅万());
        丐东丆不一丂一丐东();
        goto label_31;
        label_20:
        int val_14 = this.世丁丄不丑丝丟丅丞();
        丗丗与丙丛丛七丅丅();
        label_31:
        val_16 = 0;
        return (bool)val_16;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
