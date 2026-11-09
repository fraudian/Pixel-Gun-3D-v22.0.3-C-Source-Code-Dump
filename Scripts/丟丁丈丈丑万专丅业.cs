using UnityEngine;
private sealed class AuthSceneController.丟丁丈丈丑万专丅业 : IEnumerator<object>, IEnumerator, IDisposable
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
    public AuthSceneController.丟丁丈丈丑万专丅业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Object>> val_11;
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Object>> val_12;
        int val_13;
        var val_14;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_15;
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
        val_11 = this.一丑丂丟丟丞丙一万;
        val_12 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_12.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  val_11);
        val_13 = 1;
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        val_11 = this.丝且与丝丒丟万丁专;
        val_12 = this.一丑丂丟丟丞丙一万;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_12.IsCanceled != true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = this.一丑丂丟丟丞丙一万.Result;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = Progress.七七世万专丕丁上业.七丑丂丛丛丏丒丄丁();
            if(val_11 != null)
        {
                val_14 = val_11;
            this.丝且与丝丒丟万丁专.丛丘丞丅丝下三丗丟 = val_6;
            val_15 = this.丝且与丝丒丟万丁专 + 40;
            mem2[0] = val_5;
        }
        else
        {
                val_14 = 40;
            mem[40] = val_6;
            val_15 = 48;
            mem[48] = val_5;
        }
        
            val_7.LocalProgressView.一丞一丝丘丕且丒丆(一丐丗丁丞丆丅丟丄:  Progress.不丗丕万上万丟与专.丄且不丒丐下丑专丙(丆丁且东业丝丌丞丞:  mem[40]));
            val_12 = val_7.ServerProgressView;
            val_12.一丞一丝丘丕且丒丆(一丐丗丁丞丆丅丟丄:  Progress.不丗丕万上万丟与专.丄且不丒丐下丑专丙(丆丁且东业丝丌丞丞:  val_15));
            val_11.丙且三丂丟丙七且东<上丌一东丈丟与丘丒>(万不且且丛丆东丒业:  ChooseProgressWindow.下与丞三丅丛丄七丕(一丟丄丞不丕丟丌丟:  this.丝且与丝丒丟万丁专._authInterface.UpdateBannerPoint, 丆且丄丁一丆丗且丅:  2).丛三一与丙万七丝不());
        }
        
        label_10:
        val_13 = 0;
        return (bool)val_13;
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
