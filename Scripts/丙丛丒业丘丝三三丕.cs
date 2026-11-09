using UnityEngine;
private sealed class ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗.丙丛丒业丘丝三三丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗 丝且与丝丒丟万丁专;
    private float 业不丌万丛丁丒丟丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReusableRewardedVideo.丑丝七丈丌丆不三丏.丞丂万丅不丒丘丟丗.丙丛丒业丘丝三三丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<System.String> val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + 1f;
        this.业不丌万丛丁丒丟丐 = val_1;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(this.丝且与丝丒丟万丁专.丈一丝丁不丂不七三.IsCompleted != true)
        {
                if(UnityEngine.Time.time < 0)
        {
            goto label_8;
        }
        
        }
        
        val_8 = this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专.丈丐丘丐丘丘丂不与;
        if((val_8.TrySetResult(result:  "CLOSE_ABORTED")) == true)
        {
                return false;
        }
        
        val_8 = "[ReusableRewardedVideo.Watching.Enter+onAdClosed+WaitThenSetResultCoroutine] Failed to set result for _adClosedPromise: CLOSE_ABORTED, Status: "("[ReusableRewardedVideo.Watching.Enter+onAdClosed+WaitThenSetResultCoroutine] Failed to set result for _adClosedPromise: CLOSE_ABORTED, Status: ") + this.丝且与丝丒丟万丁专.丝且与丝丒丟万丁专.丈丐丘丐丘丘丂不与.Task.Result;
        UnityEngine.Debug.LogWarning(message:  val_8);
        return false;
        label_8:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
