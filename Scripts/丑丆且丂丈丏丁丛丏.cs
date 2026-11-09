using UnityEngine;
internal class 丑丆且丂丈丏丁丛丏
{
    // Fields
    private static 丑丆且丂丈丏丁丛丏 世丒丞七专三与万丕;
    private System.Collections.Generic.Dictionary<int, 丑丆且丂丈丏丁丛丏.丈丅丂世丕不上下丙> 丟七东丌丞丝与丏丙;
    private static System.Action 丛专万丄三不与丛上;
    
    // Properties
    internal static 丑丆且丂丈丏丁丛丏 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal 丑丆且丂丈丏丁丛丏()
    {
        this.丟七东丌丞丝与丏丙 = new System.Collections.Generic.Dictionary<System.Int32, 丈丅丂世丕不上下丙>();
        this.丒丝丒与丄丕三丁丒();
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丑丆且丂丈丏丁丛丏::下丅东丏与丛与三丌()));
    }
    internal static 丑丆且丂丈丏丁丛丏 丑七不且上丗丁一世()
    {
        丑丆且丂丈丏丁丛丏 val_2;
        丑丆且丂丈丏丁丛丏 val_3 = 丑丆且丂丈丏丁丛丏.世丒丞七专三与万丕;
        if(val_3 != null)
        {
                return val_3;
        }
        
        丑丆且丂丈丏丁丛丏 val_1 = null;
        val_2 = val_1;
        val_1 = new 丑丆且丂丈丏丁丛丏();
        丑丆且丂丈丏丁丛丏.世丒丞七专三与万丕 = val_2;
        val_3 = 丑丆且丂丈丏丁丛丏.世丒丞七专三与万丕;
        return val_3;
    }
    internal static void 丑丑不下丗丛上七三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  丑丆且丂丈丏丁丛丏.丛专万丄三不与丛上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(丑丆且丂丈丏丁丛丏.丛专万丄三不与丛上 != 1152921505180545032);
    
    }
    internal static void 丑七七丌东不下上丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  丑丆且丂丈丏丁丛丏.丛专万丄三不与丛上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(丑丆且丂丈丏丁丛丏.丛专万丄三不与丛上 != 1152921505180545032);
    
    }
    internal void 万丟丏与丞丈七丂丕(string 丄丂万与一丒丗不丕, 丑丆且丂丈丏丁丛丏.丈丅丂世丕不上下丙 业丏丈世世世丞丒世)
    {
        object val_5;
        var val_6;
        val_5 = 丄丂万与一丒丗不丕;
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_3.set_Item(key:  "acceptee_id", value:  val_5);
        val_5 = val_3.与不丕不丏丄丟业七(一丐丗丁丞丆丅丟丄:  val_3);
        if(val_5 == 1)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        FriendsController.丄丞丁丈与业上丞丟.三丟东丗丑丒丞东下();
        this.丟七东丌丞丝与丏丙.set_Item(key:  val_5, value:  业丏丈世世世丞丒世);
    }
    private void 丒丝丒与丄丕三丁丒()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丄丄丙丕丑不丅与丈, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丑丆且丂丈丏丁丛丏::丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 下丅东丏与丛与三丌()
    {
        this.丟七东丌丞丝与丏丙.Clear();
    }
    private void 丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((this.丂丐丟丂七专丈丑丄(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟, 丁不七丙下七丐与不:  丁不七丙下七丐与不)) != 0)
        {
                return;
        }
        
        if(丑丆且丂丈丏丁丛丏.丛专万丄三不与丛上 == null)
        {
                return;
        }
        
        丑丆且丂丈丏丁丛丏.丛专万丄三不与丛上.Invoke();
    }
    private uint 丂丐丟丂七专丈丑丄(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_22;
        object val_23;
        System.Collections.Generic.Dictionary<System.Int32, 丈丅丂世丕不上下丙> val_24;
        var val_25;
        var val_26;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_22 = 东丞丒丙世丏三下丟;
        val_22 = null;
        val_22 = null;
        FriendsController.丄丞丁丈与业上丞丟.下下三丐专下一三丈();
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                val_23 = 丑与丂丌世丕丆一丗.Item["err_code"];
            uint val_3 = System.Convert.ToUInt32(value:  val_23);
        }
        else
        {
                val_23 = 0;
        }
        
        var val_4 = (val_22 == 0) ? 1401 : (val_23);
        object val_5 = val_22.Item["acceptee_id"];
        if(val_5 == null)
        {
            goto label_11;
        }
        
        val_22 = (null == null) ? (val_5) : 0;
        if(丑与丂丌世丕丆一丗 != null)
        {
            goto label_41;
        }
        
        label_42:
        label_41:
        int val_7 = System.Convert.ToInt32(value:  丑与丂丌世丕丆一丗.Item["req_id"]);
        if((this.丟七东丌丞丝与丏丙.ContainsKey(key:  val_7)) == false)
        {
            goto label_16;
        }
        
        val_24 = this.丟七东丌丞丝与丏丙;
        val_25 = this.丟七东丌丞丝与丏丙.Item[val_7];
        bool val_10 = val_24.Remove(key:  val_7);
        if(val_4 == 0)
        {
            goto label_19;
        }
        
        label_22:
        if(val_25 == null)
        {
                return (uint)val_4;
        }
        
        val_26 = 0;
        goto label_21;
        label_16:
        val_25 = 0;
        if(val_4 != 0)
        {
            goto label_22;
        }
        
        label_19:
        val_24 = 1152921516734113248;
        if((且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万().Contains(item:  val_22)) != false)
        {
                bool val_16 = 且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万().Remove(item:  val_22);
            FriendsWindowController.丆丕丝丒不丙且丐丗.下不世丞丞丝丟不丒();
        }
        
        if((丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Contains(item:  val_22)) != true)
        {
                丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Add(item:  val_22);
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.丄专丏上与上丄丐丗(与丂丒丄丟丌丆丁丕:  "addFriend");
        if(val_25 == 0)
        {
                return (uint)val_4;
        }
        
        val_26 = 1;
        label_21:
        val_25.Invoke(东丏丂丙丑丁丞丞万:  true);
        return (uint)val_4;
        label_11:
        if(丑与丂丌世丕丆一丗 != null)
        {
            goto label_41;
        }
        
        goto label_42;
    }
    private int 与不丕不丏丄丟业七(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_2;
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return 0;
        }
        
        Rilisoft.WebSocket.WebSocketManager val_1 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_2 = null;
        val_2 = null;
        if(val_1 != null)
        {
                return val_1.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丄丄丙丕丑不丅与丈, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        
        return val_1.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丄丄丙丕丑不丅与丈, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }

}
