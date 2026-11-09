using UnityEngine;
private sealed class InhouseAnalyticsController.丙丘丞丅丟丅万丈丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丑丁丒一丘丞业丗七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InhouseAnalyticsController.丙丘丞丅丟丅万丈丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_6;
        var val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        if(val_6.丕且一与专丘丄上上() == false)
        {
            goto label_3;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = null;
        val_6 = val_3;
        val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_3.set_Item(key:  "Log", value:  this.丑丁丒一丘丞业丗七);
        val_7 = null;
        val_7 = null;
        int val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丆丟丟三丗东一丆三, 一丐丗丁丞丆丅丟丄:  val_3);
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
