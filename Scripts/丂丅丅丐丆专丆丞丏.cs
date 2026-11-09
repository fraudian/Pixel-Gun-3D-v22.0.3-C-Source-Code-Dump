using UnityEngine;
private sealed class 丟丘丈丄丟丙丐丞丈.丂丅丅丐丆专丆丞丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.MatchmakingRequest.丟丘丈丄丟丙丐丞丈 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<与丟丆一七丛丆且丟> 一丑丂丟丟丞丙一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丟丘丈丄丟丙丐丞丈.丂丅丅丐丆专丆丞丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.一丑丂丟丟丞丙一万 = this.丝且与丝丒丟万丁专.丆不丘上丐丗东丁丘();
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.一丑丂丟丟丞丙一万);
        val_7 = 1;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.一丑丂丟丟丞丙一万.IsCanceled != true)
        {
                if(this.一丑丂丟丟丞丙一万.IsFaulted == false)
        {
            goto label_11;
        }
        
        }
        
        val_7 = 0;
        this.丝且与丝丒丟万丁专.下丅丒丛三且不丆丙 = 0;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_11:
        this.丝且与丝丒丟万丁专.下丅丒丛三且不丆丙 = this.一丑丂丟丟丞丙一万.Result;
        return (bool)val_7;
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
