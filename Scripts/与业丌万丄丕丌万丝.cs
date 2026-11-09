using UnityEngine;
private sealed class GameEventPlayerGot.与业丌万丄丕丌万丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝;
    public Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄;
    public int 丌丒丝东丌下丕丁丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventPlayerGot.与业丌万丄丕丌万丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_16;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅东专与不三丂丁丝 == null)
        {
                return false;
        }
        
        if(this.一丐丗丁丞丆丅丟丄.Type == 400)
        {
                return false;
        }
        
        if(this.一丐丗丁丞丆丅丟丄.Type == 500)
        {
                if(this.丌丒丝东丌下丕丁丅 < 100)
        {
                return false;
        }
        
            if((this.一丐丗丁丞丆丅丟丄.Id.Equals(value:  "EventCurrency")) == true)
        {
                return false;
        }
        
        }
        
        if(this.一丐丗丁丞丆丅丟丄.Type == 800)
        {
                if(this.丌丒丝东丌下丕丁丅 < 50)
        {
                return false;
        }
        
        }
        
        if(this.一丐丗丁丞丆丅丟丄.Type == 900)
        {
                return false;
        }
        
        if(this.一丐丗丁丞丆丅丟丄.Type == 1400)
        {
                return false;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_8.Add(key:  "nick", value:  ProfileController.丆三丂丂丆上丆丕专());
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8.Add(key:  "category", value:  this.一丐丗丁丞丆丅丟丄.Type.ToString());
        val_8.Add(key:  "sub_type", value:  this.一丐丗丁丞丆丅丟丄.SubType);
        val_8.Add(key:  "id_item", value:  this.一丐丗丁丞丆丅丟丄.Id);
        val_8.Add(key:  "count", value:  this.丌丒丝东丌下丕丁丅);
        Rilisoft.GameEventData val_13 = this.丅东专与不三丂丁丝.丁专丗万三上丟三丆();
        val_8.Add(key:  "id_event", value:  val_13.EventId);
        val_16 = null;
        val_16 = null;
        int val_15 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.世丈东下丂丐丂一与, 一丐丗丁丞丆丅丟丄:  val_8);
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
