using UnityEngine;
internal sealed class PlayerLikeController : PGBehaviour
{
    // Fields
    internal static PlayerLikeController 丄丘七三上丕世丞业;
    internal static string 丘且丞丗丆丝丂业丁;
    internal static string 丝且丘丈一丗下一丅;
    internal static string 丙上世丛丗丑丐丞丁;
    internal static string 且与丙丘万世丗丅丆;
    internal static int 丛丟丙三丆不与丘丒;
    internal static int 丌上业下丁丁丝七丏;
    public static System.Action<string, 七丈丆丝三丌七专丙> GetLikeFromPlayer;
    private UnityEngine.Texture2D 丏业与且丏七丄且丅;
    private UnityEngine.AudioClip 丟且万七专世丛丗丄;
    private Rilisoft.丅丟丒丟丑丈丒三丆 丘下不丐专丁丘丈下;
    private Rilisoft.且丈丞一丞丟与上七 丘丗丝丆丌丐上与东;
    private System.Collections.Generic.Dictionary<string, PlayerLike> 丗丆七且丌丕丏东丒;
    private UnityEngine.Coroutine 七丞东世丗世一丛一;
    private System.Collections.Generic.List<string> 丂丏丐丅丁业丘且不;
    
    // Properties
    public UnityEngine.Texture2D 丟丁丁丏丂丌世专三 { get; set; }
    public UnityEngine.AudioClip 丂业丒丏不世下丘丝 { get; set; }
    public static string 与下丌三上世且丏丈 { get; set; }
    public static string 丈万丞丄丙丆东丌丈 { get; set; }
    public System.Collections.Generic.Dictionary<string, PlayerLike> 东丕丂一丛万一丅丐 { get; set; }
    internal int 丏丌且丆丂丑专丏专 { get; set; }
    
    // Methods
    public UnityEngine.Texture2D get_LikeTexture()
    {
        var val_3;
        UnityEngine.Texture2D val_4;
        if(this.丏业与且丏七丄且丅 == 0)
        {
                val_3 = null;
            val_3 = null;
            this.丏业与且丏七丄且丅 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  PlayerLikeController.丙上世丛丗丑丐丞丁);
            return val_4;
        }
        
        val_4 = this.丏业与且丏七丄且丅;
        return val_4;
    }
    public void set_LikeTexture(UnityEngine.Texture2D 丙业与丙丗丝不丈东)
    {
        this.丏业与且丏七丄且丅 = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.AudioClip get_LikeGetSound()
    {
        var val_3;
        UnityEngine.AudioClip val_4;
        if(this.丟且万七专世丛丗丄 == 0)
        {
                val_3 = null;
            val_3 = null;
            this.丟且万七专世丛丗丄 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  PlayerLikeController.且与丙丘万世丗丅丆);
            return val_4;
        }
        
        val_4 = this.丟且万七专世丛丗丄;
        return val_4;
    }
    public void set_LikeGetSound(UnityEngine.AudioClip 丙业与丙丗丝不丈东)
    {
        this.丟且万七专世丛丗丄 = 丙业与丙丗丝不丈东;
    }
    public static string get_KeyLikeStory()
    {
        null = null;
        return System.String.Format(format:  PlayerLikeController.丘且丞丗丆丝丂业丁, arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    public static void set_KeyLikeStory(string 丙业与丙丗丝不丈东)
    {
        null = null;
        PlayerLikeController.丘且丞丗丆丝丂业丁 = 丙业与丙丗丝不丈东;
    }
    public static string get_KeyLikeCount()
    {
        null = null;
        return System.String.Format(format:  PlayerLikeController.丝且丘丈一丗下一丅, arg0:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
    }
    public static void set_KeyLikeCount(string 丙业与丙丗丝不丈东)
    {
        null = null;
        PlayerLikeController.丝且丘丈一丗下一丅 = 丙业与丙丗丝不丈东;
    }
    internal static void 丙丌专东丌丏东丗丕()
    {
        var val_6;
        PlayerLikeController val_7;
        var val_8;
        val_6 = null;
        val_6 = null;
        val_7 = PlayerLikeController.丄丘七三上丕世丞业;
        if(val_7 != 0)
        {
                return;
        }
        
        System.Type[] val_2 = new System.Type[1];
        val_2[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "PlayerLikeController", components:  val_2);
        UnityEngine.Object.DontDestroyOnLoad(target:  val_4);
        val_8 = null;
        val_7 = val_4.GetComponent<PlayerLikeController>();
        val_8 = null;
        PlayerLikeController.丄丘七三上丕世丞业 = val_7;
    }
    public System.Collections.Generic.Dictionary<string, PlayerLike> get_LikeStory()
    {
        System.Collections.Generic.Dictionary<System.String, PlayerLike> val_7 = this.丗丆七且丌丕丏东丒;
        if(val_7 != null)
        {
                return val_6;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丘下不丐专丁丘丈下.世三丞丅丑丌丈丈一())) != false)
        {
                System.Collections.Generic.Dictionary<System.String, PlayerLike> val_3 = new System.Collections.Generic.Dictionary<System.String, PlayerLike>();
            this.丗丆七且丌丕丏东丒 = val_3;
            this.丘下不丐专丁丘丈下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_3));
            val_7 = this.丗丆七且丌丕丏东丒;
            return val_6;
        }
        
        System.Collections.Generic.Dictionary<System.String, PlayerLike> val_6 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<System.String, PlayerLike>>(value:  this.丘下不丐专丁丘丈下.世三丞丅丑丌丈丈一());
        this.丗丆七且丌丕丏东丒 = val_6;
        return val_6;
    }
    public void set_LikeStory(System.Collections.Generic.Dictionary<string, PlayerLike> 丙业与丙丗丝不丈东)
    {
        this.丗丆七且丌丕丏东丒 = 丙业与丙丗丝不丈东;
    }
    internal int 丏东丟丅丒丄丑丆与()
    {
        if(this.丘丗丝丆丌丐上与东 != null)
        {
                return this.丘丗丝丆丌丐上与东.世三丞丅丑丌丈丈一();
        }
        
        return this.丘丗丝丆丌丐上与东.世三丞丅丑丌丈丈一();
    }
    internal void 且丐东丑丁丈丗丁丏(int 丙业与丙丗丝不丈东)
    {
        this.丘丗丝丆丌丐上与东.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void OnEnable()
    {
        if(this.七丞东世丗世一丛一 == null)
        {
                this.七丞东世丗世一丛一 = this.StartCoroutine(routine:  this.世上专丘丐丝东丌不());
        }
        
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                this.不下丑丆丐且丆下与();
        }
        
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlayerLikeController::不下丑丆丐且丆下与()));
    }
    private void Start()
    {
        PGCompany.丒丒丛丙不万专三丆 val_1 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        val_1.丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PlayerLikeController::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        val_1.丟丈上丛丙丕业丁丐();
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        PGCompany.ConfigId val_1 = 丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝();
        if(val_1 != 106)
        {
                return;
        }
        
        val_1.丟丈上丛丙丕业丁丐();
    }
    private void 丟丈上丛丙丕业丁丐()
    {
        int val_10;
        var val_11;
        var val_12;
        object val_7 = 0;
        object val_4 = 0;
        val_10 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_10.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  106));
        if(val_3 == null)
        {
                return;
        }
        
        val_10 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        if((val_10.TryGetValue(key:  "timeResetUpdate", value: out  val_4)) != false)
        {
                val_11 = null;
            val_11 = null;
            PlayerLikeController.丛丟丙三丆不与丘丒 = System.Convert.ToInt32(value:  val_4);
        }
        
        if((val_10.TryGetValue(key:  "timeToReset", value: out  val_7)) == false)
        {
                return;
        }
        
        val_10 = System.Convert.ToInt32(value:  val_7);
        val_12 = null;
        val_12 = null;
        PlayerLikeController.丌上业下丁丁丝七丏 = val_10;
    }
    private void 不下丑丆丐且丆下与()
    {
        var val_8;
        this.LikeStory.Clear();
        this.丘下不丐专丁丘丈下 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  PlayerLikeController.KeyLikeStory);
        this.丘丗丝丆丌丐上与东 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  PlayerLikeController.KeyLikeCount);
        val_8 = null;
        val_8 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丐业丟万丐不丈与丈, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PlayerLikeController::七丄七七丘丆丁丑丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丐业丟万丐不丈与丈);
    }
    private void OnDisable()
    {
        var val_3;
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlayerLikeController::不下丑丆丐且丆下与()));
        if(this.七丞东世丗世一丛一 != null)
        {
                this.StopCoroutine(routine:  this.七丞东世丗世一丛一);
        }
        
        val_3 = null;
        val_3 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丐业丟万丐不丈与丈, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PlayerLikeController::七丄七七丘丆丁丑丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    internal 七丈丆丝三丌七专丙 丌七丙丆丟丑业且世(string 丏世丑万世一七丟丞, string 下世丆且世丗与不下)
    {
        七丈丆丝三丌七专丙 val_19;
        var val_20;
        long val_21;
        var val_22;
        if((this.LikeStory.ContainsKey(key:  丏世丑万世一七丟丞)) != false)
        {
                PlayerLike val_4 = this.LikeStory.Item[丏世丑万世一七丟丞];
            var val_5 = (val_4.likeType == 2) ? 3 : (0 + 1);
        }
        else
        {
                val_19 = 1;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() != 1)
        {
                val_20 = null;
            val_20 = null;
            val_21 = FriendsController.丝丗专上三不丄丑丑() + PlayerLikeController.丌上业下丁丁丝七丏;
        }
        else
        {
                val_21 = 0;
        }
        
        .playerId = 丏世丑万世一七丟丞;
        .playerName = 下世丆且世丗与不下;
        .timeToDelete = val_21;
        .likeType = val_19;
        this.LikeStory.set_Item(key:  丏世丑万世一七丟丞, value:  new PlayerLike());
        this.丘下不丐专丁丘丈下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.LikeStory));
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_12 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if(val_12 != null)
        {
                val_12.set_Item(key:  "liked_p_id", value:  丏世丑万世一七丟丞);
        }
        else
        {
                val_12.set_Item(key:  "liked_p_id", value:  丏世丑万世一七丟丞);
        }
        
        val_12.set_Item(key:  "sender_name", value:  下世丆且世丗与不下);
        val_22 = null;
        val_22 = null;
        int val_14 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丗丂世七业与丟七丏, 一丐丗丁丞丆丅丟丄:  val_12);
        PGCompany.Analytics.一业丗丆世世上丁且.丗丄七丒专东丏丟三(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 下七丆上一丏丌丟丈:  1, 丞丅上丏丂且下丅与:  丏世丑万世一七丟丞);
        if(this.LikeStory.Item[丏世丑万世一七丟丞] != null)
        {
                return (七丈丆丝三丌七专丙)val_17.likeType;
        }
        
        return (七丈丆丝三丌七专丙)val_17.likeType;
    }
    internal void 七丄七七丘丆丁丑丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_11;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "likes_cnt")) != false)
        {
                this.且丐东丑丁丈丗丁丏(丙业与丙丗丝不丈东:  System.Int32.Parse(s:  丑与丂丌世丕丆一丗.Item["likes_cnt"]));
        }
        
        val_11 = "last_like";
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "last_like")) == false)
        {
                return;
        }
        
        if(丑与丂丌世丕丆一丗.Item["last_like"] == null)
        {
                return;
        }
        
        object val_6 = 丑与丂丌世丕丆一丗.Item["last_like"];
        if(val_6 == null)
        {
                return;
        }
        
        val_11 = "who_id";
        if((val_6.ContainsKey(key:  "who_id")) == false)
        {
                return;
        }
        
        if((val_6.ContainsKey(key:  "sender_name")) == false)
        {
                return;
        }
        
        this.丏丛丈万业丑万丙七(丏世丑万世一七丟丞:  val_6.Item["who_id"], 下世丆且世丗与不下:  val_6.Item["sender_name"]);
    }
    internal void 丏丛丈万业丑万丙七(string 丏世丑万世一七丟丞, string 下世丆且世丗与不下)
    {
        七丈丆丝三丌七专丙 val_22;
        var val_23;
        long val_24;
        string val_25;
        var val_26;
        if((this.LikeStory.ContainsKey(key:  丏世丑万世一七丟丞)) != false)
        {
                PlayerLike val_4 = this.LikeStory.Item[丏世丑万世一七丟丞];
            var val_5 = (val_4.likeType == 1) ? (2 + 1) : 2;
        }
        else
        {
                val_22 = 2;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() != 1)
        {
                val_23 = null;
            val_23 = null;
            val_24 = FriendsController.丝丗专上三不丄丑丑() + PlayerLikeController.丌上业下丁丁丝七丏;
        }
        else
        {
                val_24 = 0;
        }
        
        .playerId = 丏世丑万世一七丟丞;
        .playerName = 下世丆且世丗与不下;
        .timeToDelete = val_24;
        .likeType = val_22;
        this.LikeStory.set_Item(key:  丏世丑万世一七丟丞, value:  new PlayerLike());
        val_25 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.LikeStory);
        this.丘下不丐专丁丘丈下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_25);
        PGCompany.Analytics.一业丗丆世世上丁且.丗丄七丒专东丏丟三(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 下七丆上一丏丌丟丈:  2, 丞丅上丏丂且下丅与:  丏世丑万世一七丟丞);
        val_26 = null;
        val_26 = null;
        if(PlayerLikeController.GetLikeFromPlayer != null)
        {
                val_25 = this.LikeStory.Item[丏世丑万世一七丟丞];
            PlayerLikeController.GetLikeFromPlayer.Invoke(arg1:  丏世丑万世一七丟丞, arg2:  val_14.likeType);
        }
        
        if((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0) && (NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 != false))
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
            UnityEngine.AudioSource val_18 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.LikeGetSound, 与丁万东丌丑下丏丕:  1f, 丟与不丄丕丞专下丛:  1f);
            return;
        }
        
        InfoWindowController.七丏不丕丈丁丗丒不(丕丗丘丑丛与丑业丒:  下世丆且世丗与不下, 世丙丁丗业丝世丕丈:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9687"), 不且丁丐不丌丟上丌:  this.LikeTexture, 不上丏上丝丆一丛丑:  "");
    }
    internal System.Collections.Generic.List<string> 丕丂下且丏东业丂三()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.LikeStory.GetEnumerator();
        label_8:
        if(((-260841112) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        if(0 == 3)
        {
            goto label_4;
        }
        
        if(0 != 2)
        {
            goto label_8;
        }
        
        label_4:
        val_1.Add(item:  val_4._value._obj.丐丏七丌丕丗业且上());
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal System.Collections.Generic.List<string> 万不一不一与不万三()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.LikeStory.GetEnumerator();
        label_8:
        if(((-260704536) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        if(0 == 3)
        {
            goto label_4;
        }
        
        if(0 != 1)
        {
            goto label_8;
        }
        
        label_4:
        val_1.Add(item:  val_4._value._obj.丐丏七丌丕丗业且上());
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal 七丈丆丝三丌七专丙 一且丈丅丏丏丟丌世(string 丞丅上丏丂且下丅与)
    {
        string val_5;
        七丈丆丝三丌七专丙 val_6;
        val_5 = 丞丅上丏丂且下丅与;
        if((this.LikeStory.ContainsKey(key:  val_5)) != false)
        {
                val_5 = this.LikeStory.Item[val_5];
            val_6 = val_4.likeType;
            return (七丈丆丝三丌七专丙)val_6;
        }
        
        val_6 = 0;
        return (七丈丆丝三丌七专丙)val_6;
    }
    private System.Collections.IEnumerator 世上专丘丐丝东丌不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerLikeController.丕丕东专丘丆丄丝不();
    }
    public PlayerLikeController()
    {
        this.丘下不丐专丁丘丈下 = new Rilisoft.丅丟丒丟丑丈丒三丆(丟东丟丑丕丄丂丟丙:  PlayerLikeController.KeyLikeStory);
        this.丘丗丝丆丌丐上与东 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  PlayerLikeController.KeyLikeCount);
        this.丂丏丐丅丁业丘且不 = new System.Collections.Generic.List<System.String>();
    }
    private static PlayerLikeController()
    {
        PlayerLikeController.丘且丞丗丆丝丂业丁 = "LikePlayer_LikeStory_{0}";
        PlayerLikeController.丝且丘丈一丗下一丅 = "LikePlayer_LikeCount_{0}";
        PlayerLikeController.丙上世丛丗丑丐丞丁 = "Textures/icon_like";
        PlayerLikeController.且与丙丘万世丗丅丆 = "Snd/like_to_you";
        PlayerLikeController.丛丟丙三丆不与丘丒 = 60;
        PlayerLikeController.丌上业下丁丁丝七丏 = 86400;
    }

}
