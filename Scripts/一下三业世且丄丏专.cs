using UnityEngine;
private sealed class 下丘且东丅万丗丞丞.一下三业世且丄丏专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private float 上上丄一丙万丟丛丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 下丘且东丅万丗丞丞.一下三业世且丄丏专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        var val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = this.上上丄一丙万丟丛丄;
        goto label_3;
        label_1:
        val_4 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.上上丄一丙万丟丛丄 - val_1;
        this.上上丄一丙万丟丛丄 = val_1;
        if(val_1 > 0f)
        {
            goto label_4;
        }
        
        val_5 = null;
        val_5 = null;
        int val_3 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丅丏丝丁专世丝丒丑);
        label_3:
        this.上上丄一丙万丟丛丄 = 600f;
        label_4:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
