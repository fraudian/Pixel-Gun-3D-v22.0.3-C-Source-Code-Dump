using UnityEngine;
private sealed class 丟丘丈丄丟丙丐丞丈.一万丅下世且世丅丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.Tasks.TaskCompletionSource<与丟丆一七丛丆且丟> 专丒丅丗不丟丕业丞;
    private System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> 丞一丐丙丐专丗丆东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丟丘丈丄丟丙丐丞丈.一万丅下世且世丅丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Threading.Tasks.TaskCompletionSource<与丟丆一七丛丆且丟> val_25;
        int val_26;
        var val_27;
        string val_28;
        var val_29;
        val_25 = this;
        string val_14 = 0;
        object val_12 = 0;
        int val_19 = 0;
        int val_16 = 0;
        int val_22 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_26 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_26;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            val_27 = null;
            val_27 = null;
            this.丞一丐丙丐专丗丆东 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.且丑丑丂东丈一上丏(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丌丌东丌丝丆丗专丌, 一丐丗丁丞丆丅丟丄:  new System.Collections.Generic.Dictionary<System.Object, System.Object>());
            this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.丞一丐丙丐专丗丆东);
            val_26 = 1;
            this.丗丏丅丕丆世丁专丟 = val_26;
            return (bool)val_26;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丞一丐丙丐专丗丆东.IsCanceled == true) || (this.丞一丐丙丐专丗丆东.IsFaulted == true))
        {
            goto label_23;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = this.丞一丐丙丐专丗丆东.Result.七丂丗不丝丏七丟丂();
        if((val_9.ContainsKey(key:  "err_code")) == false)
        {
            goto label_17;
        }
        
        label_23:
        val_25 = this.专丒丅丗不丟丕业丞;
        label_31:
        bool val_11 = val_25.TrySetResult(result:  0);
        val_26 = 0;
        return (bool)val_26;
        label_17:
        if((val_12 == 0) || ((val_9.TryGetValue(key:  "room", value: out  val_12)) == false))
        {
            goto label_23;
        }
        
        bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "room_id", 丙业与丙丗丝不丈东: out  val_14);
        bool val_17 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "md", 丙业与丙丗丝不丈东: out  val_16);
        bool val_18 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "mp", 丙业与丙丗丝不丈东: out  val_16);
        bool val_20 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "group", 丙业与丙丗丝不丈东: out  val_19);
        bool val_21 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "event", 丙业与丙丗丝不丈东: out  val_19);
        bool val_23 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "tm", 丙业与丙丗丝不丈东: out  val_22);
        与丟丆一七丛丆且丟 val_24 = new 与丟丆一七丛丆且丟();
        if(val_24 != null)
        {
                val_24.下东丅世丅专丝专丌(丙业与丙丗丝不丈东:  0);
            val_24.丞万丈丌三丑丙丁丈(丙业与丙丗丝不丈东:  0);
            val_28 = val_14;
        }
        else
        {
                val_24.下东丅世丅专丝专丌(丙业与丙丗丝不丈东:  0);
            val_24.丞万丈丌三丑丙丁丈(丙业与丙丗丝不丈东:  0);
            val_28 = val_14;
        }
        
        val_24.丂丏丙与丗丝丗七丅(丙业与丙丗丝不丈东:  val_28);
        if(val_24 != null)
        {
                val_24.丝丝丛专丏丑丞且万(丙业与丙丗丝不丈东:  new System.Nullable<System.Int32>() {HasValue = false});
            val_24.与丟丘丝丁一丛上丟(丙业与丙丗丝不丈东:  0);
            val_29 = val_22;
        }
        else
        {
                val_24.丝丝丛专丏丑丞且万(丙业与丙丗丝不丈东:  new System.Nullable<System.Int32>() {HasValue = false});
            val_24.与丟丘丝丁一丛上丟(丙业与丙丗丝不丈东:  0);
            val_29 = val_22;
        }
        
        val_24.丞丏丂丏与万丟七丝(丙业与丙丗丝不丈东:  0);
        if(this.专丒丅丗不丟丕业丞 != null)
        {
            goto label_31;
        }
        
        goto label_31;
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
