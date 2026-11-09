using UnityEngine;
private sealed class 万丄丑丆上丁丂且东.丘七丅一丛丁丝丁且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Progress.万丄丑丆上丁丂且东 丝且与丝丒丟万丁专;
    private System.Collections.Generic.Dictionary<object, object> 丈七丂七万三丈丌丗;
    private System.Threading.Tasks.Task<System.Collections.Generic.HashSet<string>> 业丄专丄丗业丟丌丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 万丄丑丆上丁丂且东.丘七丅一丛丁丝丁且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_12;
        string val_13;
        int val_14;
        var val_15;
        val_12 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丈七丂七万三丈丌丗 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        this.业丄专丄丗业丟丌丞 = 万与下丝东下丕万丈.且丌三业丌世丑且且(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        val_13 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_13.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.业丄专丄丗业丟丌丞);
        val_14 = 1;
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Collections.Generic.HashSet<System.String> val_7 = Progress.七七世万专丕丁上业.丙一丕七与七丛丝业();
        val_7.ExceptWith(other:  this.业丄专丄丗业丟丌丞.Result);
        Progress.下丁下丂七丆丙七一 val_8 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        this.丈七丂七万三丈丌丗.set_Item(key:  "index", value:  val_8.<一丞丟且丈丟专丛丂>k__BackingField);
        this.丈七丂七万三丈丌丗.set_Item(key:  "slots", value:  0.不不东上丕上三丝丌(与丝丁丒丘丂下七丁:  val_7));
        val_15 = null;
        val_15 = null;
        val_12 = this.丈七丂七万三丈丌丗;
        val_13 = Rilisoft.WebSocket.业丛世业世不丄丐三.丙丈专东上一丒一且;
        int val_11 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  val_13, 一丐丗丁丞丆丅丟丄:  val_12);
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
