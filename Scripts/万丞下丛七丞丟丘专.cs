using UnityEngine;
private sealed class ReusableRewardedVideo.丑丝七丈丌丆不三丏.万丞下丛七丞丟丘专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ReusableRewardedVideo.丑丝七丈丌丆不三丏 丝且与丝丒丟万丁专;
    private Rilisoft.ReusableRewardedVideo.丑丝七丈丌丆不三丏.业东下丕世丗丏万丏 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReusableRewardedVideo.丑丝七丈丌丆不三丏.万丞下丛七丞丟丘专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.Task<System.String> val_9;
        int val_10;
        var val_11;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_14;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new ReusableRewardedVideo.丑丝七丈丌丆不三丏.业东下丕世丗丏万丏();
        .与丕丁三万专世不丅 = this.丝且与丝丒丟万丁专.丂丌丈丗东专丒丒丐();
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean ReusableRewardedVideo.丑丝七丈丌丆不三丏.业东下丕世丗丏万丏::与丞丌三丌东丘丈丌()));
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丄丌丂东丘丗一万且.与丕丁三万专世不丅.IsFaulted != true) && (this.丄丌丂东丘丗一万且.与丕丁三万专世不丅.IsCanceled != true))
        {
                val_9 = this.丄丌丂东丘丗一万且.与丕丁三万专世不丅;
            if((System.String.op_Equality(a:  val_9.Result, b:  "CLOSE_FINISHED")) != false)
        {
                val_11 = null;
            val_11 = null;
            if(0 == 0)
        {
                return (bool)val_10;
        }
        
            0.Invoke(sender:  val_9, e:  System.EventArgs.Empty);
        }
        
        }
        
        label_14:
        val_10 = 0;
        return (bool)val_10;
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
