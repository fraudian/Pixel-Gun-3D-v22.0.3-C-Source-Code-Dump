using UnityEngine;
private sealed class ReusableRewardedVideo.丑丝七丈丌丆不三丏.不不丝三丝丐丌丂丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ReusableRewardedVideo.丑丝七丈丌丆不三丏 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReusableRewardedVideo.丑丝七丈丌丆不三丏.不不丝三丝丐丌丂丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_12;
        int val_13;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_13 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_13;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ReusableRewardedVideo.Watching.SimulateWatchingCoroutine]");
        }
        
            UnityEngine.WaitForSeconds val_2 = null;
            val_12 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  1f);
            val_13 = 1;
            this.丒上七丌业七丟与丐 = val_12;
            this.丗丏丅丕丆世丁专丟 = val_13;
            return (bool)val_13;
        }
        
        val_12 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ReusableRewardedVideo.Watching.SimulateWatchingCoroutine] IsCompleted: "("[ReusableRewardedVideo.Watching.SimulateWatchingCoroutine] IsCompleted: ") + val_12.丂丌丈丗东专丒丒丐().IsCompleted.ToString());
        }
        
        if(val_12.丂丌丈丗东专丒丒丐().IsCompleted != true)
        {
                val_12 = this.丝且与丝丒丟万丁专.丈丐丘丐丘丘丂不与;
            bool val_11 = val_12.TrySetResult(result:  "CLOSE_FINISHED");
        }
        
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
