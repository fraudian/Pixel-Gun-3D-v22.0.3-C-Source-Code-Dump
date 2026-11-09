using UnityEngine;
private sealed class AuthSceneController.一丗不丅七丏丝丘且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 不丁一丁丁丛丘丌丅;
    public AuthSceneController 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, object>> 一丑丂丟丟丞丙一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AuthSceneController.一丗不丅七丏丝丘且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Object>> val_20;
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Object>> val_21;
        int val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.一丑丂丟丟丞丙一万 = 万与下丝东下丕万丈.丄且丙丂丆不一万七(丄丒且丙三丆丟与丏:  this.不丁一丁丁丛丘丌丅);
        val_20 = this.一丑丂丟丟丞丙一万;
        val_21 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_21.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  val_20);
        val_22 = 1;
        this.丗丏丅丕丆世丁专丟 = val_22;
        return (bool)val_22;
        label_1:
        val_20 = this.丝且与丝丒丟万丁专;
        val_21 = this.一丑丂丟丟丞丙一万;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_21.IsCanceled == true)
        {
            goto label_10;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = Progress.七七世万专丕丁上业.七丑丂丛丛丏丒丄丁();
        if(val_20 != null)
        {
                val_23 = val_20;
            this.丝且与丝丒丟万丁专.丛丘丞丅丝下三丗丟 = val_6;
        }
        else
        {
                val_23 = 40;
            mem[40] = val_6;
        }
        
        this.丝且与丝丒丟万丁专.丁丌且东丆七丄且丏 = this.一丑丂丟丟丞丙一万.Result;
        if(((new Progress.三丕丕业丗七东专丗(丑七丏专丗丛丟专世:  false, 丅丞东丄万一七一丛:  专丈专业丆且且业下.丆七丙丛上丑丒不丅())) & 1) == 0)
        {
            goto label_17;
        }
        
        if(this.丝且与丝丒丟万丁专.丁丌且东丆七丄且丏.Count != 3)
        {
            goto label_19;
        }
        
        System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> val_10 = null;
        val_24 = val_10;
        val_10 = new System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒>();
        val_21 = new 上丌一东丈丟与丘丒();
        val_25 = 1;
        val_26 = 0;
        goto label_20;
        label_17:
        System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒> val_11 = null;
        val_24 = val_11;
        val_11 = new System.Threading.Tasks.TaskCompletionSource<上丌一东丈丟与丘丒>();
        上丌一东丈丟与丘丒 val_12 = null;
        val_21 = val_12;
        val_26 = 1;
        val_25 = 0;
        label_20:
        val_12 = new 上丌一东丈丟与丘丒(丁世一与丝丐丏丒丁:  false, 丛上东七七丌丛丛丕:  true);
        if(val_24 != null)
        {
                bool val_13 = val_11.TrySetResult(result:  val_12);
        }
        else
        {
                bool val_14 = val_11.TrySetResult(result:  val_12);
        }
        
        System.Threading.Tasks.Task<TResult> val_15 = val_11.Task;
        goto label_23;
        label_19:
        val_16.LocalProgressView.一丞一丝丘丕且丒丆(一丐丗丁丞丆丅丟丄:  Progress.不丗丕万上万丟与专.丄且不丒丐下丑专丙(丆丁且东业丝丌丞丞:  mem[40]));
        val_21 = val_16.ServerProgressView;
        val_21.一丞一丝丘丕且丒丆(一丐丗丁丞丆丅丟丄:  Progress.不丗丕万上万丟与专.丄且不丒丐下丑专丙(丆丁且东业丝丌丞丞:  this.丝且与丝丒丟万丁专.丁丌且东丆七丄且丏));
        label_23:
        val_20.丞丂七业不丏丅丑业<上丌一东丈丟与丘丒>(万不且且丛丆东丒业:  ChooseProgressWindow.下与丞三丅丛丄七丕(一丟丄丞不丕丟丌丟:  this.丝且与丝丒丟万丁专._authInterface.UpdateBannerPoint, 丆且丄丁一丆丗且丅:  2).丛三一与丙万七丝不());
        label_10:
        val_22 = 0;
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
