using UnityEngine;
internal static class 丄一世专一丞丙丌丏
{
    // Fields
    private static bool 丄且丆丛丗丆丗丙丙;
    
    // Methods
    private static 丄一世专一丞丙丌丏()
    {
        var val_6;
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 丄一世专一丞丙丌丏::不下丑丆丐且丆下与()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 丄一世专一丞丙丌丏::丆与丂且丐与丝且丅()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 丄一世专一丞丙丌丏::丞丟业丙与丅丏丞丑()));
        Progress.下丁下丂七丆丙七一.丂丏万丛丑丑一且丂(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 丄一世专一丞丙丌丏::丒丒丒七业丐丛不一()));
        val_6 = null;
        val_6 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙丟丏东七丌丘丟丄, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void 丄一世专一丞丙丌丏::七世丟三丕丏丘丟专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private static void 丞丟业丙与丅丏丞丑()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        丄一世专一丞丙丌丏.丄且丆丛丗丆丗丙丙 = false;
        val_3 = null;
        val_3 = null;
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙丟丏东七丌丘丟丄);
    }
    internal static void 不下丑丆丐且丆下与()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 与丂丅三丂且不不与.丑七不且上丗丁一世();
        if(val_9.丈丏丒丈丐丌丗上丂() == 1)
        {
                return;
        }
        
        val_9 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
        if(val_9.下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        val_9 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        val_10 = null;
        val_10 = null;
        if(val_9 != null)
        {
                if(丄一世专一丞丙丌丏.丄且丆丛丗丆丗丙丙 == true)
        {
                return;
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(val_9 == null)
        {
                if(丕丆上下业与丄不与.丈丂万一丛不丗丙丆() == false)
        {
                return;
        }
        
        }
        
        丄一世专一丞丙丌丏.丅丆丑丙下专一上与();
        丄一世专一丞丙丌丏.丄且丆丛丗丆丗丙丙 = true;
    }
    private static void 丆与丂且丐与丝且丅()
    {
        null = null;
        丄一世专一丞丙丌丏.丄且丆丛丗丆丗丙丙 = false;
    }
    private static void 丅丆丑丙下专一上与()
    {
        var val_7;
        var val_8;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        丞丂丘丒丟丞丑下丄 val_3 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_3 == null)
        {
            goto label_3;
        }
        
        string val_4 = val_3.丒丄东丌一丑丘丆丈();
        if(val_4 == null)
        {
            goto label_3;
        }
        
        label_13:
        val_1.set_Item(key:  "lh", value:  val_4);
        val_7 = null;
        val_7 = null;
        val_1.set_Item(key:  "last_timeStamp", value:  ChatController.丄丒上业丛丒丟丗丆);
        val_1.set_Item(key:  "last_timeStamp_service", value:  ChatController.丁与丗万丁丐丙丅丘);
        val_8 = null;
        val_8 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_6 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丙丟丏东七丌丘丟丄, 一丐丗丁丞丆丅丟丄:  val_1);
        return;
        label_3:
        if(val_1 != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    private static void 七世丟三丕丏丘丟专(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                return;
        }
        
        PGCompany.Clans.Network.丗七不丒丏丝丟万丂.且东丅且七三不且一 = true;
        Rilisoft.Singleton<ClansController>.Instance.丘世丛东丈丒丕丝丁(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗, 与与丂丅业丕丂丞丕:  false);
    }
    private static void 丒丒丒七业丐丛不一()
    {
        null = null;
        丄一世专一丞丙丌丏.丄且丆丛丗丆丗丙丙 = false;
    }

}
