using UnityEngine;
internal class MiniGamesController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private static readonly System.Collections.Generic.IDictionary<Rilisoft.七丕丟丏三丈一丄世, MiniGamesController.一下三丙丒东与一丏> 丞下丕东世丁上东七;
    private static MiniGamesController 丝业丆丁业三丈丟东;
    public bool isStartGame;
    public bool isStartTimer;
    public bool isShowGo;
    public bool isGo;
    public bool theEnd;
    public bool isRunPlayer;
    public bool playerDead;
    public float startTimer;
    public float goTimer;
    public float gameTimer;
    public float timeInGame;
    private float 丅与丅七丘丁丗七丁;
    private float 丁业且丛丁丂且丈丄;
    private int 上丗丑丞丌万丆业丂;
    public int minCountPlayer;
    public bool isEnd;
    public bool isDraw;
    private int 三丞丈丅丅且丕丐与;
    public int playersOnStart;
    public PhotonView photonView;
    internal System.Collections.Generic.Dictionary<string, 丈万且丗丂丝丙一东> 上丄丈丙丐丘丙丁与;
    private string 专丁丈丛丂上丟上一;
    private string 丌业下与丗东丈丌丑;
    private string 丗丏与丂世丝丐丁且;
    private double 丘丘丑丟丏与丕丝丛;
    internal bool 丒与丟世七专丘三丛;
    
    // Properties
    internal static MiniGamesController 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static MiniGamesController 丑七不且上丗丁一世()
    {
        null = null;
        return (MiniGamesController)MiniGamesController.丝业丆丁业三丈丟东;
    }
    private void Awake()
    {
        var val_20;
        int val_21;
        var val_23;
        var val_24;
        var val_26;
        var val_27;
        if(GameConnect.不专专丂万丝上东丐() != true)
        {
                if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_6;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = GameConnect.丑丌丛丈丅丅与不业();
        var val_22 = 0;
        val_22 = val_22 + 1;
        goto label_15;
        label_6:
        this.gameObject.SetActive(value:  false);
        return;
        label_15:
        val_23 = public System.Boolean System.Collections.Generic.IDictionary<TKey, TValue>::ContainsKey(TKey key);
        if((MiniGamesController.丞下丕东世丁上东七.ContainsKey(key:  ???)) != false)
        {
                val_24 = null;
            val_24 = null;
            val_21 = GameConnect.丑丌丛丈丅丅与不业();
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_23 = 0;
            TValue val_9 = MiniGamesController.丞下丕东世丁上东七.Item[???];
            this.startTimer = val_9;
            this.goTimer = val_9 >> 32;
            this.minCountPlayer = val_21;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                this.上丗丑丞丌万丆业丂 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丄丁丗丞丏丞世丕业();
            val_26 = null;
            val_26 = null;
            val_21 = GameConnect.丟下丗丙丕丁丞丞丛;
            var val_24 = 60;
            val_24 = (System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_21])) * val_24;
            this.gameTimer = (float)val_24;
        }
        
        this.photonView = this.GetComponent<PhotonView>();
        val_27 = null;
        val_27 = null;
        MiniGamesController.丝业丆丁业三丈丟东 = this;
        this.专丁丈丛丂上丟上一 = 丟丏下丂七三下丗丕.与丘专三丌丐世丝且();
        this.丌业下与丗东丈丌丑 = 丟丏下丂七三下丗丕.丂丙丂不世三世丟丛();
        this.丗丏与丂世丝丐丁且 = 丟丏下丂七三下丗丕.不丝一上丑丒丟丝不();
    }
    private void Start()
    {
        var val_3;
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == false)
        {
                return;
        }
        
        this.丛丅丈丄七丞丟丂丕();
    }
    internal void 业丒丈丏一万不丏世(NetworkStartTable 不且上一上丐三万丛)
    {
        string val_7;
        NetworkStartTable val_8 = 不且上一上丐三万丛;
        if((System.String.IsNullOrEmpty(value:  不且上一上丐三万丛.丈三世丞丕万丄七丂)) == true)
        {
                return;
        }
        
        val_7 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        if((val_7.Equals(value:  "-1")) == true)
        {
                return;
        }
        
        val_7 = System.String.Format(format:  "{0}-{1}", arg0:  不且上一上丐三万丛.丈三世丞丕万丄七丂, arg1:  不且上一上丐三万丛.业丏三七专东丁丕丂);
        if((this.上丄丈丙丐丘丙丁与.ContainsKey(key:  val_7)) != false)
        {
                this.上丄丈丙丐丘丙丁与.Item[val_7].丑七下业与丕丛丅丕(不且上一上丐三万丛:  val_8 = 不且上一上丐三万丛);
            return;
        }
        
        val_8 = this.上丄丈丙丐丘丙丁与;
        val_8.Add(key:  val_7, value:  new 丈万且丗丂丝丙一东(不且上一上丐三万丛:  val_8));
    }
    private void OnDestroy()
    {
        null = null;
        MiniGamesController.丝业丆丁业三丈丟东 = 0;
    }
    private void OnDisable()
    {
    
    }
    private void Update()
    {
        float val_42;
        var val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_47;
        object val_48;
        float val_49;
        string val_50;
        var val_51;
        var val_52;
        var val_53;
        int val_54;
        var val_55;
        int val_56;
        if((this.isStartTimer != false) && (this.startTimer > 0f))
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.startTimer - val_1;
            this.startTimer = val_1;
        }
        
        val_42 = this.goTimer;
        if((this.isStartGame != false) && (val_42 > 0f))
        {
                val_42 = val_42 - UnityEngine.Time.deltaTime;
            this.goTimer = val_42;
        }
        
        if(val_42 < 0)
        {
                this.goTimer = 0f;
        }
        
        if(this.isShowGo == false)
        {
            goto label_9;
        }
        
        val_42 = this.丁业且丛丁丂且丈丄;
        if(val_42 < 0f)
        {
            goto label_7;
        }
        
        val_42 = val_42 - UnityEngine.Time.deltaTime;
        this.丁业且丛丁丂且丈丄 = val_42;
        if(this.isShowGo == false)
        {
            goto label_9;
        }
        
        label_7:
        if(val_42 < 0)
        {
                this.isShowGo = false;
        }
        
        label_9:
        if(((GameConnect.且丘丄丛下丆丟万丕() != true) && (this.isGo != false)) && (this.gameTimer > 0f))
        {
                val_43 = null;
            val_43 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count >= 1)
        {
                val_42 = this.gameTimer;
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = val_42 - val_6;
            this.gameTimer = val_6;
        }
        
        }
        
        val_44 = this.gameTimer;
        if((val_44 > 0f) || (this.theEnd == true))
        {
            goto label_26;
        }
        
        val_45 = null;
        val_45 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_26;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_29;
        }
        
        val_46 = null;
        val_46 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == true)
        {
            goto label_32;
        }
        
        label_29:
        this.下万丆七丙下与丂丞();
        label_32:
        MiniGamesController val_10 = MiniGamesController.丑七不且上丗丁一世();
        val_42 = val_10.timeInGame;
        val_44 = val_42;
        Rilisoft.一丟专且三万丞丁丂.丄与下一不丐丘丗丆(丂三丟丂丈丐丆丗丟:  val_44);
        label_26:
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_88;
        }
        
        val_42 = this.丅与丅七丘丁丗七丁;
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = val_42 - val_12;
        this.丅与丅七丘丁丗七丁 = val_12;
        if((val_12 < 0) && (this.isGo != false))
        {
                if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                this.丅与丅七丘丁丗七丁 = 0.5f;
            object[] val_14 = new object[1];
            val_14[0] = this.gameTimer;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  108, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_14);
        }
        
        }
        
        val_47 = null;
        val_47 = null;
        int val_15 = Count;
        if(this.isStartGame == false)
        {
            goto label_55;
        }
        
        val_44 = this.丅与丅七丘丁丗七丁;
        if(val_44 < 0)
        {
                this.丅与丅七丘丁丗七丁 = 0.5f;
            object[] val_16 = new object[1];
            val_16[0] = this.goTimer;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  149, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_16);
        }
        
        if(this.isGo == true)
        {
            goto label_88;
        }
        
        val_42 = this.goTimer;
        val_44 = val_42;
        if((UnityEngine.Mathf.FloorToInt(f:  val_44)) > 0)
        {
            goto label_88;
        }
        
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  26, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        goto label_88;
        label_55:
        if((this.isStartTimer != true) && (val_15 >= this.minCountPlayer))
        {
                object[] val_19 = new object[1];
            val_48 = true;
            val_19[0] = val_48;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  136, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_19);
        }
        
        val_44 = this.丅与丅七丘丁丗七丁;
        if(val_44 < 0)
        {
                this.丅与丅七丘丁丗七丁 = 0.5f;
            object[] val_20 = new object[1];
            val_48 = this.startTimer;
            val_20[0] = val_48;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  115, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_20);
        }
        
        if(this.isStartGame == true)
        {
            goto label_93;
        }
        
        if(this.isStartTimer == false)
        {
            goto label_94;
        }
        
        val_44 = this.startTimer;
        if(val_44 < 0)
        {
                if(val_15 >= this.minCountPlayer)
        {
            goto label_84;
        }
        
        }
        
        if(val_15 == 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丄丁丗丞丏丞世丕业())
        {
                label_84:
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  99, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丄东丅丘东不丘丝丟(丙业与丙丗丝不丈东:  false);
        }
        
        label_88:
        if(this.isStartGame == true)
        {
            goto label_93;
        }
        
        if(this.isStartTimer == false)
        {
            goto label_94;
        }
        
        val_49 = this.startTimer;
        if(val_49 <= 0f)
        {
            goto label_95;
        }
        
        object[] val_25 = new object[4];
        val_25[0] = this.丌业下与丗东丈丌丑;
        val_42 = val_49 / 60f;
        val_48 = 1152921504622075904;
        val_25[1] = UnityEngine.Mathf.FloorToInt(f:  val_42);
        var val_40 = 60;
        val_40 = (UnityEngine.Mathf.FloorToInt(f:  val_42)) * val_40;
        float val_41 = (float)val_40;
        val_41 = val_49 - val_41;
        val_25[2] = ((UnityEngine.Mathf.FloorToInt(f:  val_41)) < 10) ? "0" : "";
        var val_42 = 60;
        val_42 = (UnityEngine.Mathf.FloorToInt(f:  val_42)) * val_42;
        val_44 = val_49 - (float)val_42;
        val_25[3] = UnityEngine.Mathf.FloorToInt(f:  val_44);
        val_49 = this.startTimer;
        val_50 = System.String.Format(format:  "{0} {1}:{2}{3}", args:  val_25);
        goto label_113;
        label_94:
        val_50 = this.专丁丈丛丂上丟上一;
        goto label_116;
        label_95:
        val_50 = "";
        label_113:
        if((val_49 < 0) && (this.isStartGame != true))
        {
                val_50 = this.丗丏与丂世丝丐丁且;
        }
        
        label_116:
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                text = val_50;
        }
        
        if(this.isStartGame == false)
        {
            goto label_135;
        }
        
        label_93:
        if((this.isRunPlayer != true) && (this.isEnd != true))
        {
                val_51 = null;
            val_51 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_52 = null;
            val_52 = null;
            UnityEngine.Debug.Log(message:  "Start minigames player");
            this.isRunPlayer = true;
            this.isDraw = false;
            丞丞下丒丅丅丛世丕();
        }
        
        }
        
        label_135:
        if(this.theEnd != true)
        {
                val_53 = null;
            val_53 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_42 = this.timeInGame;
            float val_36 = UnityEngine.Time.deltaTime;
            val_36 = val_42 + val_36;
            this.timeInGame = val_36;
        }
        
        }
        
        val_54 = 1152921505189646336;
        GameController val_37 = GameController.丑七不且上丗丁一世();
        if(val_37.万丕丘七丟丞丏不专 != false)
        {
                val_55 = null;
            val_55 = null;
            val_54 = Count;
            val_56 = this.三丞丈丅丅且丕丐与;
            int val_39 = UnityEngine.Mathf.Max(a:  val_56, b:  val_54);
        }
        else
        {
                val_56 = 0;
        }
        
        this.三丞丈丅丅且丕丐与 = val_56;
        if(this.isGo == false)
        {
                return;
        }
        
        this.UpdatePlayerScores();
    }
    public void UpdatePlayerScores()
    {
        var val_4;
        var val_5;
        var val_6;
        GameController val_1 = GameController.丑七不且上丗丁一世();
        if(val_1.万丕丘七丟丞丏不专 == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_5;
        label_14:
        val_5 = null;
        val_5 = null;
        this.业丒丈丏一万不丏世(不且上一上丐三万丛:  Item[0]);
        val_4 = 1;
        label_5:
        val_6 = null;
        val_6 = null;
        if(val_4 < Count)
        {
            goto label_14;
        }
    
    }
    private void 丞丞下丒丅丅丛世丕()
    {
        null = null;
        GameController.onlineMode.丟丛专七不七丆三万();
    }
    private void 丛丅丈丄七丞丟丂丕()
    {
        var val_6;
        var val_7;
        var val_8;
        this.isShowGo = true;
        this.isGo = true;
        GameController val_1 = GameController.丑七不且上丗丁一世();
        if(val_1.万丕丘七丟丞丏不专 != false)
        {
                val_6 = null;
            val_6 = null;
            this.playersOnStart = Count;
        }
        
        val_7 = 1152921505066536960;
        if(GameConnect.丆丕丒与丂七与下上() == false)
        {
            goto label_11;
        }
        
        label_18:
        CheckpointController.丄丘七三上丕世丞业.StartRun();
        return;
        label_11:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
                return;
        }
        
        val_7 = 1152921505169678336;
        val_8 = null;
        val_8 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == true)
        {
            goto label_18;
        }
    
    }
    public void FinishGame()
    {
        if(GameConnect.丆丕丒与丂七与下上() != false)
        {
                CheckpointController.丄丘七三上丕世丞业.EndRun();
        }
        
        this.下万丆七丙下与丂丞();
    }
    private void 下万丆七丙下与丂丞()
    {
        var val_3;
        var val_4;
        if(this.theEnd != false)
        {
                return;
        }
        
        this.theEnd = true;
        this.isDraw = true;
        if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                ZombiManager.丟丗丄业丘丗业丗七.EndMatch();
            return;
        }
        
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        下丁不丌丈下上丙丁();
    }
    private void 下丘三丘下下丞且丟()
    {
    
    }
    public void OnPlayerRespawn()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(GameConnect.与丈丘丈上丌丝丝丛() != false)
        {
                this.playerDead = true;
            val_7 = null;
            val_7 = null;
            一业丟丟三丁丆丞丅();
            this.下万丆七丙下与丂丞();
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) ? 1 : 0);
        }
        
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                this.playerDead = true;
            val_10 = null;
            val_10 = null;
            丂丛丆万丐丝下东丑();
            this.下万丆七丙下与丂丞();
            val_11 = null;
            val_11 = null;
            val_12 = null;
            val_12 = null;
            丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) ? 1 : 0);
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
                return;
        }
        
        this.playerDead = true;
        val_13 = null;
        val_13 = null;
        丂丛丆万丐丝下东丑();
        val_14 = null;
        val_14 = null;
        if(GameController.mode != null)
        {
                GameController.mode.七丁丕一一丒丂七丑();
            val_14 = null;
        }
        
        val_14 = null;
        val_15 = null;
        val_15 = null;
        丟丙不上丝丂丄丗三(丗丛丘万世丟丅不与:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) ? 1 : 0);
    }
    protected virtual void 丐丈丌不丌丁东丒且()
    {
        var val_7;
        var val_8;
        var val_9;
        if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_7 = activeSelf ^ 1;
        }
        else
        {
                val_7 = 1;
        }
        
        if(this.三丞丈丅丅且丕丐与 < 2)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count != 1)
        {
                return;
        }
        
        if(this.isGo == false)
        {
                return;
        }
        
        var val_5 = (this.timeInGame > 10f) ? 1 : 0;
        val_5 = val_7 & val_5;
        if(val_5 != 1)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        且丘不业丞一七丁丐();
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        bool val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 > 108)
        {
            goto label_1;
        }
        
        if(val_1 == 26)
        {
            goto label_2;
        }
        
        if(val_1 == 99)
        {
            goto label_3;
        }
        
        if(val_1 != 108)
        {
            goto label_10;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        this.gameTimer = null;
        goto label_19;
        label_1:
        if(val_1 == 115)
        {
            goto label_8;
        }
        
        if(val_1 == 149)
        {
            goto label_9;
        }
        
        if(val_1 != 136)
        {
            goto label_10;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        this.isStartTimer = null;
        goto label_19;
        label_10:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        this.丛丅丈丄七丞丟丂丕();
        goto label_19;
        label_3:
        val_2 = true;
        this.isStartGame = val_2;
        return (bool)val_2;
        label_8:
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        this.startTimer = null;
        goto label_19;
        label_9:
        object val_5 = 专丒丌丆下丐丞丟丞[0];
        this.goTimer = null;
        label_19:
        val_2 = 1;
        return (bool)val_2;
    }
    internal void 丞丝下丄丆且丌丈丐(bool 丟丌丟丑丂丅丙丕一)
    {
        this.isStartTimer = 丟丌丟丑丂丅丙丕一;
    }
    internal void 丆丁一丐一丄丘一丑(float 丘上三丁与丘世专丝)
    {
        this.startTimer = 丘上三丁与丘世专丝;
    }
    internal void 丂业丟丂三丐东下与(float 业丄丘一上三东丁丈)
    {
        this.goTimer = 业丄丘一上三东丁丈;
    }
    internal void 丞下下业丌丘丌丟专(float 丁业丏一与下丛业下)
    {
        this.gameTimer = 丁业丏一与下丛业下;
    }
    internal void 丛丛业丈下下丐丟丒()
    {
        this.isStartGame = true;
    }
    internal void 丗丑丟丛丛丘三世丙()
    {
        this.丛丅丈丄七丞丟丂丕();
    }
    public MiniGamesController()
    {
        this.startTimer = 30f;
        this.goTimer = 10.5f;
        this.gameTimer = 600f;
        this.丅与丅七丘丁丗七丁 = Infinityf;
        this.丁业且丛丁丂且丈丄 = 1f;
        this.上丗丑丞丌万丆业丂 = 10;
        this.minCountPlayer = 2;
        this.上丄丈丙丐丘丙丁与 = new System.Collections.Generic.Dictionary<System.String, 丈万且丗丂丝丙一东>(capacity:  10);
    }
    private static MiniGamesController()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 一下三丙丒东与一丏> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, 一下三丙丒东与一丏>();
        if(val_1 != null)
        {
                val_1.Add(key:  1, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 15f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 2});
            val_1.Add(key:  3, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 15f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 4});
            val_1.Add(key:  10, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 10f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 1});
            val_1.Add(key:  14, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 15f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 3});
            val_1.Add(key:  21, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 3.003922f, 丏丟世丑丆世丆丌专 = 0f, 专丆丒丆七丕丒丌专 = 4});
        }
        else
        {
                val_1.Add(key:  1, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 15f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 2});
            val_1.Add(key:  3, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 15f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 4});
            val_1.Add(key:  10, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 10f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 1});
            val_1.Add(key:  14, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 15f, 丏丟世丑丆世丆丌专 = 6f, 专丆丒丆七丕丒丌专 = 3});
            val_1.Add(key:  21, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 3.003922f, 丏丟世丑丆世丆丌专 = 0f, 专丆丒丆七丕丒丌专 = 4});
        }
        
        val_1.Add(key:  23, value:  new 一下三丙丒东与一丏() {丛丁丈与丛万一丝万 = 3f, 丏丟世丑丆世丆丌专 = 10f, 专丆丒丆七丕丒丌专 = 4});
        MiniGamesController.丞下丕东世丁上东七 = val_1;
    }

}
