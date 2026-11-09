using UnityEngine;
private sealed class 丟丘丈丄丟丙丐丞丈.下东且万丑上下不下.丛丘专丙三丑世丑上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.MatchmakingRequest.丆三不丈丛业丏万丙 丘丙业丕不上丙丏丄;
    public System.Threading.CancellationToken 不丒三业下丑不丞业;
    public System.Threading.Tasks.TaskCompletionSource<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> 三丈丅丕丕丘丈丐丞;
    private System.Collections.Generic.Dictionary<object, object> 丁一丄三世丙丛丒丞;
    private System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> 丏丕丅三丛丁丏丞三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丟丘丈丄丟丙丐丞丈.下东且万丑上下不下.丛丘专丙三丑世丑上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<PGCompany.MatchmakingRequest.丛丛丗下丌丐丝七不> val_30;
        int val_35;
        val_30 = this;
        string val_23 = 0;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_30 = 106032368 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_30 = val_30 + 106032368;
        }
        else
        {
                val_35 = 0;
            return (bool);
        }
    
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
