using UnityEngine;
internal class ConnectionLostChecker : MonoBehaviour
{
    // Fields
    private static ConnectionLostChecker <不丁丄七丛不丆丁丕>k__BackingField;
    private static LossReason <丄上万不丆丌万丕下>k__BackingField;
    private static bool 丂丗丒丘一与丕丂上;
    private static bool 丗丅丝丘丙七不丆七;
    private bool 上一万丁不七七业丛;
    private bool 上丅丝丄且东丆上丛;
    private bool 丛丄不丞且丟丐世丝;
    private bool 丈三丟下且世七丌丞;
    
    // Properties
    internal static ConnectionLostChecker 丆丕丝丒不丙且丐丗 { get; set; }
    internal static LossReason 丘不丌丈丅丄丏丑不 { get; set; }
    internal bool 万东业丈丑丝丆丈东 { get; }
    internal static bool 与丁丒下专上丝一丌 { get; set; }
    internal bool 丈丌丆丆东丟丌丛丑 { get; }
    internal static bool 丁丂丂丒不丞丏业且 { get; }
    internal static bool 丗丆丈上七丛万三丌 { get; }
    internal static bool 丁丘七三东七东一东 { get; }
    
    // Methods
    internal static ConnectionLostChecker 丑七不且上丗丁一世()
    {
        return (ConnectionLostChecker)ConnectionLostChecker.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(ConnectionLostChecker 丙业与丙丗丝不丈东)
    {
        ConnectionLostChecker.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static LossReason 且三世专下丂丏与下()
    {
        return (LossReason)ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField;
    }
    private static void 丑丙丝专丐丟丘丘丁(LossReason 丙业与丙丗丝不丈东)
    {
        ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 东不丙丅丏丘丄东丘()
    {
        var val_3;
        if(下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄() != false)
        {
                var val_2 = (this.丛丄不丞且丟丐世丝 == false) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal static bool 丅丌丌丏丆丌丕不东()
    {
        return (bool)ConnectionLostChecker.丗丅丝丘丙七不丆七;
    }
    internal static void 下丗万丆世丄丝不丕(bool 丙业与丙丗丝不丈东)
    {
        ConnectionLostChecker.丂丗丒丘一与丕丂上 = false;
        ConnectionLostChecker.丗丅丝丘丙七不丆七 = 丙业与丙丗丝不丈东;
    }
    internal bool 一丅丑万丈东业丂丕()
    {
        return (bool)this.丈三丟下且世七丌丞;
    }
    internal static bool 世丁世丆丙丅丄丑丌()
    {
        var val_4;
        var val_6;
        if(Initializer.丑七不且上丗丁一世() != 0)
        {
                val_4 = null;
            val_4 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                var val_3 = (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal static bool 丐丒丟一丆丛万丟业()
    {
        if(GameConnect.上丏丈七丘丁与丅丏() == true)
        {
                return true;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
                return true;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
                return GameConnect.万七丄丛丈丟专一丑();
        }
        
        return true;
    }
    internal static bool 业丌丗丘一丆丝且丞()
    {
        var val_4;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                var val_3 = (丅丒丗丑丒丙丛不丆.丒丘丞东丝东七一丛() > 1000) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 1;
        return (bool)val_4;
    }
    internal void 丌丝丅七丕丞丏丑不(bool 丂且丏丘丗上丑丘丕)
    {
        this.丈三丟下且世七丌丞 = 丂且丏丘丗上丑丘丕;
    }
    private void Awake()
    {
        var val_4;
        if((ConnectionLostChecker.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        ConnectionLostChecker.<不丁丄七丛不丆丁丕>k__BackingField = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField = 0;
        val_4 = null;
        val_4 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒丈下下丈与丏丅丑, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectionLostChecker::与丒丈丘万丅东业且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void OnDestroy()
    {
        var val_2;
        ConnectionLostChecker.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        val_2 = null;
        val_2 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒丈下下丈与丏丅丑, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ConnectionLostChecker::与丒丈丘万丅东业且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 与丒丈丘万丅东业且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = 丑与丂丌世丕丆一丗;
        if((val_4.ContainsKey(key:  "reason")) == false)
        {
                return;
        }
        
        val_4 = val_4.Item["reason"];
        if((System.Convert.ToInt32(value:  val_4)) != 1)
        {
                return;
        }
        
        ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField = 1;
    }
    private void 丆与丘三丘丙丒世丝()
    {
        if((ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField) == 1)
        {
                label_14:
            if(ConnectionLostChecker.丂丗丒丘一与丕丂上 == false)
        {
                return;
        }
        
            if(AuthSceneController.丏丌丏丞丄与上丌丂() == false)
        {
                return;
        }
        
            if(ConnectionLostChecker.丗丅丝丘丙七不丆七 == false)
        {
                return;
        }
        
            丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  false);
            this.丈三丟下且世七丌丞 = false;
            return;
        }
        
        if(this.丈三丟下且世七丌丞 == true)
        {
                return;
        }
        
        if((Rilisoft.Singleton<QuietAuthorization>.Instance.丝丞与丏七丈丆丕丒()) == true)
        {
                return;
        }
        
        if(ConnectionLostChecker.世丁世丆丙丅丄丑丌() != false)
        {
                if(ConnectionLostChecker.业丌丗丘一丆丝且丞() == false)
        {
                return;
        }
        
        }
        
        if(ConnectionLostChecker.丐丒丟一丆丛万丟业() == false)
        {
            goto label_14;
        }
    
    }
    private void 且与丄丂丆丕丏下丂()
    {
        bool val_10;
        bool val_1 = 下丟世丏三东万丘丏.东丗业一丌且丟世一();
        bool val_3 = ConnectionLostChecker.世丁世丆丙丅丄丑丌() ^ 1;
        val_10 = val_1 & val_3;
        if((val_1 != false) && (val_3 != true))
        {
                val_10 = ConnectionLostChecker.业丌丗丘一丆丝且丞();
        }
        
        if(InfoWindowController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        InfoWindowController.丑七不且上丗丁一世().丐专丅世专万丒丑丝(世丁万下丗专世万丅:  val_10);
    }
    private void Update()
    {
        var val_20;
        this.且与丄丂丆丕丏下丂();
        if(下丟世丏三东万丘丏.丆丐不上三专丝丌不() != false)
        {
                if((((this.上丅丝丄且东丆上丛 == true) ? 1 : 0) ^ 下丟世丏三东万丘丏.丆丐不上三专丝丌不()) != false)
        {
                val_20 = null;
            ConnectionLostChecker.丂丗丒丘一与丕丂上 = false;
            ConnectionLostChecker.丗丅丝丘丙七不丆七 = true;
            val_20 = null;
            ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField = 0;
        }
        
        }
        
        if(下丟世丏三东万丘丏.丆丐不上三专丝丌不() != false)
        {
                ConnectionLostChecker.丂丗丒丘一与丕丂上 = true;
        }
        
        if(下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄() != false)
        {
                bool val_7 = 下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄();
        }
        
        if(下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄() != false)
        {
                if((ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField) == 1)
        {
                ConnectionLostChecker.<丄上万不丆丌万丕下>k__BackingField = 0;
        }
        
            if(((Rilisoft.Singleton<QuietAuthorization>.Instance) != 0) && ((Rilisoft.Singleton<QuietAuthorization>.Instance.丗与丄万丈与丐专业()) != false))
        {
                Rilisoft.Singleton<QuietAuthorization>.Instance.丛世东丛丐丅七丙丗();
        }
        else
        {
                this.丆与丘三丘丙丒世丝();
        }
        
        }
        
        this.上丅丝丄且东丆上丛 = 下丟世丏三东万丘丏.丆丐不上三专丝丌不();
        this.上一万丁不七七业丛 = 下丟世丏三东万丘丏.东丗业一丌且丟世一();
        this.丛丄不丞且丟丐世丝 = 下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄();
    }
    public ConnectionLostChecker()
    {
    
    }

}
