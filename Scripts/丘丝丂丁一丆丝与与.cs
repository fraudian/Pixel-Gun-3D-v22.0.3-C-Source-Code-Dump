using UnityEngine;
private sealed class 业丂丏与世一丏业不.丘丝丂丁一丆丝与与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private string 丆丟丁丙专丈丞三丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 业丂丏与世一丏业不.丘丝丂丁一丆丝与与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_9;
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        int val_14;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = null;
        val_10 = null;
        if(FriendsController.业丂一丙东与丅一丛 == false)
        {
            goto label_5;
        }
        
        val_11 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        val_12 = val_9;
        this.丆丟丁丙专丈丞三丁 = val_11;
        goto label_6;
        label_1:
        val_12 = val_9;
        val_11 = this.丆丟丁丙专丈丞三丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_6:
        if((((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)) || (MainMenuController.丈一丏一丂丟三且丌() == false))
        {
            goto label_14;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_6 = null;
        val_9 = val_6;
        val_6 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_6.set_Item(key:  "id", value:  this.丆丟丁丙专丈丞三丁);
        val_13 = null;
        val_13 = null;
        int val_8 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.专丟丁丄上万丂丝万, 一丐丗丁丞丆丅丟丄:  val_6);
        label_5:
        val_14 = 0;
        return (bool)val_14;
        label_14:
        val_14 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_14;
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
