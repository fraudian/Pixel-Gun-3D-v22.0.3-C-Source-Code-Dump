using UnityEngine;
private sealed class GachaRewardedVideo.丑丝七丈丌丆不三丏.丏丝丑且业丏丂丝丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GachaRewardedVideo.丑丝七丈丌丆不三丏 丝且与丝丒丟万丁专;
    private Rilisoft.GachaRewardedVideo.丑丝七丈丌丆不三丏.丗丛丘丑丐不丌丑丙 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GachaRewardedVideo.丑丝七丈丌丆不三丏.丏丝丑且业丏丂丝丑(int 丗丏丅丕丆世丁专丟)
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
        this.丄丌丂东丘丗一万且 = new GachaRewardedVideo.丑丝七丈丌丆不三丏.丗丛丘丑丐不丌丑丙();
        .与丕丁三万专世不丅 = this.丝且与丝丒丟万丁专.丂丌丈丗东专丒丒丐();
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean GachaRewardedVideo.丑丝七丈丌丆不三丏.丗丛丘丑丐不丌丑丙::与丞丌三丌东丘丈丌()));
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丄丌丂东丘丗一万且.与丕丁三万专世不丅.IsFaulted != true) && (this.丄丌丂东丘丗一万且.与丕丁三万专世不丅.IsCanceled != true))
        {
                val_9 = this.丄丌丂东丘丗一万且.与丕丁三万专世不丅;
            if((System.String.op_Equality(a:  val_9.Result, b:  "CLOSE_FINISHED")) != false)
        {
                val_9 = this.丝且与丝丒丟万丁专.丗丆丆丟丑上三丛七;
            val_11 = null;
            val_11 = null;
            val_10 = this.丝且与丝丒丟万丁专.丗丆丆丟丑上三丛七.丁上丂万丄七丞丅三;
            if(val_10 == null)
        {
                return (bool)val_10;
        }
        
            val_10.Invoke(sender:  val_9, e:  System.EventArgs.Empty);
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
