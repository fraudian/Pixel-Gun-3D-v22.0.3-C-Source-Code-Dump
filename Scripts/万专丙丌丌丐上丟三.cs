using UnityEngine;
internal static class 万专丙丌丌丐上丟三
{
    // Fields
    private static bool 丄且丆丛丗丆丗丙丙;
    
    // Methods
    private static 万专丙丌丌丐上丟三()
    {
        var val_6;
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 万专丙丌丌丐上丟三::不下丑丆丐且丆下与()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 万专丙丌丌丐上丟三::丆与丂且丐与丝且丅()));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 万专丙丌丌丐上丟三::丞丟业丙与丅丏丞丑()));
        Progress.下丁下丂七丆丙七一.丂丏万丛丑丑一且丂(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 万专丙丌丌丐上丟三::丒丒丒七业丐丛不一()));
        val_6 = null;
        val_6 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一与专不下丝丌丈东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void 万专丙丌丌丐上丟三::万丘丟且与一丝且丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    internal static void 不下丑丆丐且丆下与()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        bool val_16;
        var val_17;
        var val_18;
        val_12 = 与丂丅三丂且不不与.丑七不且上丗丁一世();
        if(val_12.丈丏丒丈丐丌丗上丂() == 1)
        {
                return;
        }
        
        val_12 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
        if(val_12.下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        val_12 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        val_13 = null;
        val_13 = null;
        if(val_12 != null)
        {
                if(万专丙丌丌丐上丟三.丄且丆丛丗丆丗丙丙 == true)
        {
                return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_12 = PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() | (UnityEngine.Object.op_Inequality(x:  Base_BuildingUI_Controller.instance, y:  0));
        if(SquadPanelGUI.丄丘七三上丕世丞业 != 0)
        {
                val_15 = null;
            val_15 = null;
            val_16 = mem[SquadPanelGUI.丄丘七三上丕世丞业 + 592];
            val_16 = SquadPanelGUI.丄丘七三上丕世丞业.isActive;
        }
        else
        {
                val_16 = 0;
        }
        
        val_16 = val_16 | val_12;
        if(val_16 == false)
        {
                return;
        }
        
        val_12 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_17 = null;
        val_17 = null;
        val_12.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一与专不下丝丌丈东);
        val_18 = null;
        val_18 = null;
        万专丙丌丌丐上丟三.丄且丆丛丗丆丗丙丙 = true;
    }
    private static void 万丘丟且与一丝且丏(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
        {
                return;
        }
        
        Rilisoft.Singleton<ClansController>.Instance.丘世丛东丈丒丕丝丁(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗, 与与丂丅业丕丂丞丕:  false);
    }
    private static void 丞丟业丙与丅丏丞丑()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        万专丙丌丌丐上丟三.丄且丆丛丗丆丗丙丙 = false;
        val_3 = null;
        val_3 = null;
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一与专不下丝丌丈东);
    }
    private static void 丆与丂且丐与丝且丅()
    {
        null = null;
        万专丙丌丌丐上丟三.丄且丆丛丗丆丗丙丙 = false;
    }
    private static void 丒丒丒七业丐丛不一()
    {
        null = null;
        万专丙丌丌丐上丟三.丄且丆丛丗丆丗丙丙 = false;
    }

}
