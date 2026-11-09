using UnityEngine;
internal class PlayerBotInstance : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    internal NetworkStartTable 世丌丐丁丂一丘丂一;
    internal PlayerBotController 不丕丅丝七丂丐丗丄;
    internal string 丞丞下东且丗丄丒丏;
    private string 专丏丗丈东丗丏丘丞;
    internal bool 业丙一丛一世丆丐七;
    internal int 丟丛万丛三三业世丘;
    internal int 丗不三丟世丅专七丏;
    public bool isScenarioBot;
    public int scenarioAILevel;
    public float scenarioFirstSpawnTime;
    internal string 丅丑丗丙三丄丐丛丂;
    internal int 丅且丁与与丗丛七丆;
    private float 丘业丂丗三业且丙丅;
    public string controllerPrefab;
    private int 且丘丌丟丘丆丂专世;
    internal string 且业丞丁丁且丒下丕;
    private bool 丝与丆丞东丘丈东丘;
    private bool 东丙丆上一丂丑三丂;
    internal bool 丌丞三丕不丒业丆业;
    private int 丁丏世万丑不丒丗丛;
    private PGCompany.Matchmaking.Server.与丟下丒丝上丅丗丐 丗万三专丌丞七丁丆;
    internal bool 丅下万丏丘东丄丌万;
    internal 下丐专一下不不上与 且三丄上丗丅丗丈一;
    public 三丈丟与丏丘丈丐万[] charWeapon;
    public 三丈丟与丏丘丈丐万 charWeaponCurrent;
    private System.Collections.Generic.Dictionary<string, object> 且丒丈丟丅丕丟丟且;
    private Rilisoft.丝丑丂丛万丐丈丘且 丗业丐丐丐丅丑丙丁;
    internal int 不丝丛丘与丁万丟丈;
    private Rilisoft.丝丑丂丛万丐丈丘且 丐专丒丛丅丕一丁丙;
    internal int 丙专万丅丑丈丆丕丟;
    private Rilisoft.丝丑丂丛万丐丈丘且 下丄丕丕世万专业丑;
    internal int 丕丑丌丛丗东三七丈;
    private float 丆丈丆下丆专不且万;
    private int 丄与丒丏丘七上丕丒;
    private int 丙丞七丕东丒上世一;
    
    // Properties
    public int 丅丘丛上上丘丑丏丂 { get; }
    internal int 且丄世专丆丕丐丒上 { get; set; }
    internal int 丈丟东丌业丑丑万三 { get; set; }
    internal int 万且丒下丕丝专丟上 { get; set; }
    
    // Methods
    internal PlayerBotInstance()
    {
        this.scenarioFirstSpawnTime = 20f;
        this.且丘丌丟丘丆丂专世 = 0;
        this.专丏丗丈东丗丏丘丞 = "0";
        this.且业丞丁丁且丒下丕 = "-1";
        this.charWeapon = new 三丈丟与丏丘丈丐万[2];
        this.且丒丈丟丅丕丟丟且 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        this.不丝丛丘与丁万丟丈 = 0;
        this.丙专万丅丑丈丆丕丟 = 0;
        this.丕丑丌丛丗东三七丈 = 0;
        this.丆丈丆下丆专不且万 = -1f;
        this.丄与丒丏丘七上丕丒 = 5;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PlayerBotInstance::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_5 = this.与丑丌丌丌丁丌不丕();
        val_5.丑业丆三上东丆七丒 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PlayerBotInstance::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_7 = this.与丑丌丌丌丁丌不丕();
        val_7.丐丕丁丞丑丙丅丐丈 = new System.Action<System.Object[]>(object:  this, method:  System.Void PlayerBotInstance::丐丕丁丞丑丙丅丐丈(object[] 业丐世丛丐一丌业不));
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        int val_13;
        var val_14;
        val_13 = 丞世不丒下上上丝丑;
        byte val_1 = val_13 & 255;
        if(val_1 > 117)
        {
            goto label_1;
        }
        
        if(val_1 == 116)
        {
            goto label_2;
        }
        
        if(val_1 != 117)
        {
            goto label_12;
        }
        
        val_13 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.不丝丛丘与丁万丟丈 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[1]);
        this.丗业丐丐丐丅丑丙丁 = 0;
        mem[1152921538670615520] = 0;
        goto label_31;
        label_1:
        if(val_1 == 123)
        {
            goto label_10;
        }
        
        if(val_1 == 132)
        {
            goto label_11;
        }
        
        if(val_1 != 146)
        {
            goto label_12;
        }
        
        val_13 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        int val_7 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丙专万丅丑丈丆丕丟 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[1]);
        this.丐专丒丛丅丕一丁丙 = 0;
        mem[1152921538670615544] = 0;
        goto label_31;
        label_12:
        val_14 = 0;
        return (bool)val_14;
        label_2:
        val_13 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        this.丟丛万丛三三业世丘 = val_13;
        this.丗不三丟世丅专七丏 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[1]);
        goto label_31;
        label_10:
        val_13 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        int val_12 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丕丑丌丛丗东三七丈 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[1]);
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921538670615568] = 0;
        goto label_31;
        label_11:
        this.丅丞丛丑丗下丌丐下();
        label_31:
        val_14 = 1;
        return (bool)val_14;
    }
    public int get_BotIndex()
    {
        return (int)this.且丘丌丟丘丆丂专世;
    }
    public void ApplyCharacterProperties(string 丘丘丕丄丑丗丕一世)
    {
        var val_5;
        NetworkStartTable val_9;
        下丐专一下不不上与 val_10;
        var val_11;
        val_9 = this;
        UnityEngine.Debug.LogError(message:  "ApplyCharacterProperties");
        this.丅下万丏丘东丄丌万 = true;
        val_10 = 万且三丛丗丐且东丑.丑七不且上丗丁一世().丄丗丟丕三丑丗不丅();
        List.Enumerator<T> val_3 = val_10.GetEnumerator();
        label_10:
        if(((-295626768) & 1) == 0)
        {
            goto label_7;
        }
        
        val_10 = val_5.丐丏七丌丕丗业且上();
        if((val_6.m_stringLength.Equals(value:  丘丘丕丄丑丗丕一世)) == false)
        {
            goto label_10;
        }
        
        this.且三丄上丗丅丗丈一 = val_10;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.且三丄上丗丅丗丈一 != null)
        {
                this.丏世丛丈丛上丑丂丗();
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                this.不丕丅丝七丂丐丗丄.wear.丟丄丆丝丁丘丙业丟 = false;
            this.不丕丅丝七丂丐丗丄.wear.UpdateWear();
            this.不丕丅丝七丂丐丗丄.player.丁七东丂丟与且且丗(专丞上七七且丝七丗:  0);
        }
        
            this.不丕丅丝七丂丐丗丄.player.SetCharacterWeapons();
            val_11 = null;
            val_11 = null;
            val_10 = this.丞丞下东且丗丄丒丏;
            val_9 = this.世丌丐丁丂一丘丂一;
            MutationController.丆丕丝丒不丙且丐丗.ShowMessageNameBecameAMutant(丗七专丝一七丏与丏:  val_10, 丙丒七丄上与丏丙丙:  val_9);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "ApplyCharacterProperties: characterProperties == null");
    }
    private void Awake()
    {
        object val_30;
        var val_31;
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        if(this.isScenarioBot != false)
        {
                System.Object[] val_3 = this.丄丈丑丐丆丞丘与丗.instantiationData;
            if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(val_3 != null)
        {
                System.Object[] val_4 = this.丄丈丑丐丆丞丘与丗.instantiationData;
            if(val_4.Length != 0)
        {
                val_30 = this.丄丈丑丐丆丞丘与丗.instantiationData[0];
            this.丅丑丗丙三丄丐丛丂 = (null == null) ? (val_30) : 0;
        }
        
        }
        
            if(this.不与丌丛丌且三丞丝() != null)
        {
                this.scenarioAILevel = val_7.aiLevel;
        }
        
            this.丅且丁与与丗丛七丆 = FortGameFieldController.丄丘七三上丕世丞业.丝丐丁上三业丂东三(丞丅上丏丂且下丅与:  this.丅丑丗丙三丄丐丛丂);
        }
        else
        {
                if(val_3 != null)
        {
                System.Object[] val_9 = this.丄丈丑丐丆丞丘与丗.instantiationData;
            if(val_9.Length != 0)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.丄丈丑丐丆丞丘与丗.instantiationData[0]);
            this.且丘丌丟丘丆丂专世 = null;
        }
        
        }
        
            七不丆丘三与丛上业 val_15 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().丏丘下丞丘不丑万丏().Item[(GameConnect.丅丟下专不丁一丈七() != true) ? "FortDefence" : "FortAttack"];
            if(val_15 != null)
        {
                this.scenarioFirstSpawnTime = val_15.丙丒丛业丆一七上丂();
        }
        else
        {
                this.scenarioFirstSpawnTime = val_15.丙丒丛业丆一七上丂();
        }
        
            this.scenarioAILevel = val_15.与丗丒一一与丌丆世();
        }
        
        }
        
        if((GameConnect.丛上丆一丂业丕丈丐() != false) && (this.丄丈丑丐丆丞丘与丗.instantiationData != null))
        {
                System.Object[] val_21 = this.丄丈丑丐丆丞丘与丗.instantiationData;
            if(val_21.Length != 0)
        {
                object val_31 = this.丄丈丑丐丆丞丘与丗.instantiationData[0];
            val_31 = 0;
            this.且丒丈丟丅丕丟丟且 = ;
            this.丗万三专丌丞七丁丆 = new PGCompany.Matchmaking.Server.与丟下丒丝上丅丗丐(万丘丁丛下丈丘丆丌:  null);
            this.丌丞三丕不丒业丆业 = true;
        }
        
        }
        
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        if(PlayerBotsManager.与一丅丝不丈业与丙() == 0)
        {
                PlayerBotsManager val_27 = new UnityEngine.GameObject(name:  "PlayerBotsManager").AddComponent<PlayerBotsManager>();
        }
        
        PlayerBotsManager val_28 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_28.与上且丗丄七丑丆丑.Add(item:  this);
    }
    private void 丏世丛丈丛上丑丂丗()
    {
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        var val_33;
        var val_34;
        var val_35;
        string val_36;
        var val_38;
        var val_39;
        var val_40;
        string val_41;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        string val_47;
        object val_48;
        var val_49;
        var val_50;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>(dictionary:  this.且丒丈丟丅丕丟丟且);
        val_28 = null;
        val_28 = null;
        val_1.set_Item(key:  MatchmakingConnect.丕一业丌丄下丈丂专, value:  this.且三丄上丗丅丗丈一.一丗丆专丆上七不不());
        val_29 = null;
        if((System.String.IsNullOrEmpty(value:  this.且三丄上丗丅丗丈一.丆丗丗不丄万丆业丏())) != false)
        {
                val_30 = null;
            val_31 = MatchmakingConnect.丐丄一专丑丌世丞不;
            string val_5 = 与丂丏丛丞丞丒丟丄.丄丄丏丛且丛丙且丑();
        }
        else
        {
                val_33 = null;
            val_31 = MatchmakingConnect.丐丄一专丑丌世丞不;
        }
        
        val_1.set_Item(key:  val_31, value:  this.且三丄上丗丅丗丈一.丆丗丗不丄万丆业丏());
        val_1.set_Item(key:  MatchmakingConnect.丁丛丂丕与丅丏不上, value:  "false");
        val_34 = null;
        if((System.String.IsNullOrEmpty(value:  this.且三丄上丗丅丗丈一.丙丙东丕丂丁丗丑且())) != false)
        {
                val_35 = null;
            val_36 = MatchmakingConnect.万丛丄一专丌丄东丟;
            string val_9 = 与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业();
        }
        else
        {
                val_38 = null;
            val_36 = MatchmakingConnect.万丛丄一专丌丄东丟;
        }
        
        val_1.set_Item(key:  val_36, value:  this.且三丄上丗丅丗丈一.丙丙东丕丂丁丗丑且());
        val_1.set_Item(key:  MatchmakingConnect.丄万丞七三丕丅丌丕, value:  "false");
        val_39 = null;
        if((System.String.IsNullOrEmpty(value:  this.且三丄上丗丅丗丈一.丟三丟丑丆专七丅丕())) != false)
        {
                val_40 = null;
            val_41 = MatchmakingConnect.且丌专一丟一丄丁丏;
            string val_13 = 与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟();
        }
        else
        {
                val_43 = null;
            val_41 = MatchmakingConnect.且丌专一丟一丄丁丏;
        }
        
        val_1.set_Item(key:  val_41, value:  this.且三丄上丗丅丗丈一.丟三丟丑丆专七丅丕());
        val_1.set_Item(key:  MatchmakingConnect.丈丅三丗丅且丅丏丄, value:  "false");
        val_44 = null;
        if((System.String.IsNullOrEmpty(value:  this.且三丄上丗丅丗丈一.丆七丐丗东上丐上丛())) != false)
        {
                val_45 = null;
            val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_47 = MatchmakingConnect.专一丈丑丆下东丕丙;
            val_48 = "MaskNoneEquipped";
        }
        else
        {
                val_49 = null;
            val_46 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::set_Item(System.String key, System.Object value);
            val_47 = MatchmakingConnect.专一丈丑丆下东丕丙;
            val_48 = this.且三丄上丗丅丗丈一.丆七丐丗东上丐上丛();
        }
        
        val_1.set_Item(key:  val_47, value:  val_48);
        val_1.set_Item(key:  MatchmakingConnect.世世上万丗丞丕且丝, value:  "false");
        System.Collections.Generic.List<System.Int32> val_18 = new System.Collections.Generic.List<System.Int32>();
        val_18.Add(item:  System.Int32.Parse(s:  this.且三丄上丗丅丗丈一.世丏专不万丏世丌丞().Replace(oldValue:  "Weapon", newValue:  "")));
        if((System.String.IsNullOrEmpty(value:  this.且三丄上丗丅丗丈一.丛丈丒七丈丑丑丅丏())) != true)
        {
                val_18.Add(item:  System.Int32.Parse(s:  this.且三丄上丗丅丗丈一.丛丈丒七丈丑丑丅丏().Replace(oldValue:  "Weapon", newValue:  "")));
        }
        
        val_50 = null;
        val_50 = null;
        val_1.set_Item(key:  MatchmakingConnect.三不三三丆丅世丞三, value:  val_18);
        val_1.set_Item(key:  MatchmakingConnect.丛丟丅丒丒一一丅业, value:  "");
        this.丗万三专丌丞七丁丆 = new PGCompany.Matchmaking.Server.与丟下丒丝上丅丗丐(万丘丁丛下丈丘丆丌:  val_1);
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        PlayerBotsManager val_1 = PlayerBotsManager.与一丅丝不丈业与丙();
        bool val_2 = val_1.与上且丗丄七丑丆丑.Remove(item:  this);
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        this.且丆丅丗丘不东一丝();
        if(this.世丌丐丁丂一丘丂一 == 0)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.世丌丐丁丂一丘丂一.gameObject);
    }
    private void Start()
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        this.东丞下与丛丙世丘丒();
    }
    private void Update()
    {
        var val_5;
        var val_6;
        this.丂丆丄丛丂三丘业一();
        this.三丑丟一丂丞下下丌();
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(this.不丕丅丝七丂丐丗丄 == 0)
        {
                return;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(MutationController.丆丕丝丒不丙且丐丗.不丗丆丌丘一丙七丒() == true)
        {
                return;
        }
        
        if(this.丅下万丏丘东丄丌万 != false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        MutationController.丆丕丝丒不丙且丐丗.不丅专丛不东丈专三();
    }
    private void 丂丕下与丄业丘业且(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, PhotonTargets 丞下万上三丘上与专, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.世丌丐丁丂一丘丂一 == 0)
        {
                return;
        }
        
        this.世丌丐丁丂一丘丂一.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 丞下万上三丘上与专:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    private void 丂丕下与丄业丘业且(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, 与丅丕丈丘东丝世丟 丞下万上三丘上与专, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.世丌丐丁丂一丘丂一 == 0)
        {
                return;
        }
        
        this.世丌丐丁丂一丘丂一.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 万丌万丅专丞业丈万:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    private void 东丞下与丛丙世丘丒()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        object[] val_3 = new object[1];
        int val_4 = this.丄丈丑丐丆丞丘与丗.viewID;
        if(val_3 == null)
        {
            goto label_6;
        }
        
        if(val_4 != 0)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_4 == 0)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_3[0] = val_4;
        UnityEngine.GameObject val_5 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "NetworkTable", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_3);
    }
    internal void 上丌丝丗丐三丌丙丌(NetworkStartTable 不且上一上丐三万丛)
    {
        this.世丌丐丁丂一丘丂一 = 不且上一上丐三万丛;
        if(this.丄丈丑丐丆丞丘与丗.isMine != false)
        {
                this.丑丟下丅丈丐业丝专();
            return;
        }
        
        if(this.东丙丆上一丂丑三丂 == false)
        {
                return;
        }
        
        this.丞丘丐丞丞下上七丈();
    }
    internal static string 专不业业下东丆不世()
    {
        var val_3;
        System.String[] val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ProfileController.丘与业丟且世丒丕万;
        if(val_4 == null)
        {
                return "Player";
        }
        
        val_4 = ProfileController.丘与业丟且世丒丕万;
        if(val_4 != null)
        {
                if(ProfileController.丘与业丟且世丒丕万.Length == 0)
        {
                return "Player";
        }
        
            val_5 = null;
            val_5 = null;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  ProfileController.丘与业丟且世丒丕万.Length);
            System.String[] val_2 = ProfileController.丘与业丟且世丒丕万 + (((long)(int)(val_1)) << 3);
            return I2.Loc.丗丈下丕丟丟丙七丞.世业丗东丒一丁上不(与专丒七不丈上丐上:  (ProfileController.丘与业丟且世丒丕万 + ((long)(int)(val_1)) << 3) + 32);
        }
    
    }
    private void 丑丟下丅丈丐业丝专()
    {
        string val_17;
        var val_18;
        string val_19;
        var val_20;
        var val_21;
        var val_22;
        SkinsController val_23;
        string val_24;
        if(this.丝与丆丞东丘丈东丘 == true)
        {
                return;
        }
        
        if(this.丌丞三丕不丒业丆业 == false)
        {
            goto label_2;
        }
        
        if(this.丗万三专丌丞七丁丆 == null)
        {
            goto label_3;
        }
        
        val_17 = this.丗万三专丌丞七丁丆.丝万丙上且丒且丂三;
        val_18 = this;
        this.且业丞丁丁且丒下丕 = val_17;
        goto label_4;
        label_2:
        val_19 = this;
        this.且业丞丁丁且丒下丕 = UnityEngine.Random.Range(min:  100000, max:  1000000).ToString();
        if(this.isScenarioBot == false)
        {
            goto label_5;
        }
        
        val_20 = "Enemy";
        goto label_6;
        label_3:
        val_18 = this;
        this.且业丞丁丁且丒下丕 = 28563616;
        val_17 = this.且业丞丁丁且丒下丕;
        label_4:
        this.丞丞下东且丗丄丒丏 = this.丗万三专丌丞七丁丆.丛三三与丁丘丄丑下;
        if((System.String.IsNullOrEmpty(value:  val_17)) != true)
        {
                if((System.String.op_Inequality(a:  this.且业丞丁丁且丒下丕, b:  "0")) == true)
        {
            goto label_8;
        }
        
        }
        
        int val_17 = this.且丘丌丟丘丆丂专世;
        val_17 = val_17 + 1000;
        this.且业丞丁丁且丒下丕 = val_17.ToString();
        label_8:
        this.专丏丗丈东丗丏丘丞 = this.丗万三专丌丞七丁丆.万丐丆丗丏丝七东专;
        this.丁丏世万丑不丒丗丛 = this.丗万三专丌丞七丁丆.七一丞丈万丛下丘上;
        this.七丆下丆且业丝丐丕(专丞上七七且丝七丗:  0);
        this.专丟丛七丙下不丐世(专丞上七七且丝七丗:  0);
        val_19 = this.且业丞丁丁且丒下丕;
        goto label_9;
        label_5:
        label_6:
        this.丞丞下东且丗丄丒丏 = PlayerBotInstance.专不业业下东丆不世();
        val_21 = null;
        val_21 = null;
        if(SkinsController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_14;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = SkinsController.丄丞丁丈与业上丞丟;
        if(SkinsController.丄丞丁丈与业上丞丟 != null)
        {
            goto label_17;
        }
        
        val_23 = SkinsController.丄丞丁丈与业上丞丟;
        if(val_23 == null)
        {
            goto label_18;
        }
        
        label_17:
        int val_8 = UnityEngine.Random.Range(min:  0, max:  SkinItem[].__il2cppRuntimeField_namespaze);
        SkinItem[] val_9 = SkinsController.丄丞丁丈与业上丞丟.skinItems + (((long)(int)(val_8)) << 3);
        val_24 = this;
        this.专丏丗丈东丗丏丘丞 = mem[(SkinsController.丄丞丁丈与业上丞丟.skinItems + ((long)(int)(val_8)) << 3) + 32].name;
        goto label_23;
        label_14:
        val_24 = this.专丏丗丈东丗丏丘丞;
        label_23:
        object[] val_11 = new object[1];
        val_11[0] = mem[this.专丏丗丈东丗丏丘丞];
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  80, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_11);
        label_9:
        object[] val_12 = new object[1];
        val_12[0] = this.且业丞丁丁且丒下丕;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  83, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
        object[] val_13 = new object[1];
        val_13[0] = this.丞丞下东且丗丄丒丏;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  81, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_13);
        bool val_14 = GameConnect.丆丁上丟丛业丄丅丝();
        if(val_14 != false)
        {
                this.丟丛万丛三三业世丘 = val_14.丈下丁丄丆丟丏丁专();
            this.且上丒一三且丄下丆(专丞上七七且丝七丗:  0);
        }
        
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  132, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        this.丝与丆丞东丘丈东丘 = true;
        return;
        label_18:
    }
    private void 丞丘丐丞丞下上七丈()
    {
        NetworkStartTable val_1 = this.世丌丐丁丂一丘丂一;
        if(val_1 == null)
        {
            goto label_0;
        }
        
        this.且业丞丁丁且丒下丕 = this.世丌丐丁丂一丘丂一.丈三世丞丕万丄七丂;
        goto label_1;
        label_0:
        this.且业丞丁丁且丒下丕 = this.世丌丐丁丂一丘丂一.丈三世丞丕万丄七丂;
        if(this.世丌丐丁丂一丘丂一 == null)
        {
            goto label_2;
        }
        
        val_1 = this.世丌丐丁丂一丘丂一;
        label_1:
        this.丞丞下东且丗丄丒丏 = this.世丌丐丁丂一丘丂一.丂丈丐不丏万三七丐;
        label_3:
        this.丝与丆丞东丘丈东丘 = true;
        this.专丏丗丈东丗丏丘丞 = this.世丌丐丁丂一丘丂一.丁丌丑丙丒丘与丙一;
        return;
        label_2:
        this.丞丞下东且丗丄丒丏 = this.世丌丐丁丂一丘丂一.丂丈丐不丏万三七丐;
        if(this.世丌丐丁丂一丘丂一 != null)
        {
            goto label_3;
        }
    
    }
    private void 万丂三丒丅丙丘东丗()
    {
        this.丟丛万丛三三业世丘 = this.丈下丁丄丆丟丏丁专();
        this.且上丒一三且丄下丆(专丞上七七且丝七丗:  0);
    }
    private int 丈下丁丄丆丟丏丁专()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = 0;
        val_11 = 0;
        val_12 = 0;
        goto label_1;
        label_16:
        val_13 = null;
        val_13 = null;
        val_14 = null;
        var val_3 = (Item[0].丘丑丅三丆丑丌且丝() == 1) ? (val_12 + 1) : (val_12);
        val_14 = null;
        var val_6 = (Item[0].丘丑丅三丆丑丌且丝() == 2) ? (val_11 + 1) : (val_11);
        val_10 = 1;
        label_1:
        val_15 = null;
        val_15 = null;
        if(val_10 < Count)
        {
            goto label_16;
        }
        
        if(val_6 < val_3)
        {
                val_16 = 2;
            return (int)val_16;
        }
        
        if(val_6 <= val_3)
        {
                val_10 = 1152921505066536960;
            if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
                return UnityEngine.Random.Range(min:  1, max:  3);
        }
        
        }
        
        }
        
        val_16 = 1;
        return (int)val_16;
    }
    private void 且上丒一三且丄下丆(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_4;
        System.Object[] val_5;
        object[] val_1 = new object[2];
        if(专丞上七七且丝七丗 != null)
        {
                val_1[0] = this.丟丛万丛三三业世丘;
            val_4 = this.丗不三丟世丅专七丏;
            val_1[1] = val_4;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  116, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
            object[] val_2 = new object[2];
            val_5 = val_2;
            val_5[0] = this.丟丛万丛三三业世丘;
            val_5[1] = this.丗不三丟世丅专七丏;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  116, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        val_4 = 1152921504622075904;
        val_1[0] = this.丟丛万丛三三业世丘;
        val_1[1] = this.丗不三丟世丅专七丏;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  116, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        object[] val_3 = new object[2];
        val_3[0] = this.丟丛万丛三三业世丘;
        val_5 = this.丗不三丟世丅专七丏;
        val_3[1] = val_5;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  116, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void 丒七丟丏东三丛丗丐(int 七一丞丈万丛下丘上, int 丕丘丗上不丑丟丗世)
    {
        this.丟丛万丛三三业世丘 = 七一丞丈万丛下丘上;
        this.丗不三丟世丅专七丏 = 丕丘丗上不丑丟丗世;
    }
    private void 丄专丁丅丛丐丆三丏(int 丗丘东丆丘丆世丑丒, int 丄万丈下一丘丙丐东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.不丝丛丘与丁万丟丈 = 丄万丈下一丘丙丐东;
        this.丗业丐丐丐丅丑丙丁 = 0;
        mem[1152921538674700000] = 0;
    }
    private void 丅丈丛三且丙丑丒世(int 丘七丐丌丁东万丘一, int 不万丛丆专丗三上丕)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丙专万丅丑丈丆丕丟 = 不万丛丆专丗三上丕;
        this.丐专丒丛丅丕一丁丙 = 0;
        mem[1152921538674812024] = 0;
    }
    private void 丒丛丑与一东丅丒一(int 下丄丕丕世万专业丑, int 丌下丟丂一丛七专丏)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丕丑丌丛丗东三七丈 = 丌下丟丂一丛七专丏;
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921538674924048] = 0;
    }
    private void 丅丞丛丑丗下丌丐下()
    {
        this.东丙丆上一丂丑三丂 = true;
        if(this.世丌丐丁丂一丘丂一 == 0)
        {
                return;
        }
        
        this.丞丘丐丞丞下上七丈();
    }
    private void 三丑丟一丂丞下下丌()
    {
        if(this.isScenarioBot != false)
        {
                if(this.业丙一丛一世丆丐七 != true)
        {
                if((this.世七丌丟丞且丛七且() != false) && (this.丘业丂丗三业且丙丅 <= 0f))
        {
                this.丘业丂丗三业且丙丅 = this.scenarioFirstSpawnTime;
        }
        
        }
        
            if(this.丘业丂丗三业且丙丅 > 0f)
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.丘业丂丗三业且丙丅 - val_2;
            this.丘业丂丗三业且丙丅 = val_2;
        }
        
        }
        
        bool val_3 = this.丄丈丑丐丆丞丘与丗.isMine;
        if(val_3 == false)
        {
                return;
        }
        
        if(this.业丙一丛一世丆丐七 == true)
        {
                return;
        }
        
        if(val_3.世七丌丟丞且丛七且() == false)
        {
                return;
        }
        
        if(this.isScenarioBot != false)
        {
                if(this.丘业丂丗三业且丙丅 > 0f)
        {
                return;
        }
        
        }
        
        this.业丙一丛一世丆丐七 = true;
        if(this.不丕丅丝七丂丐丗丄 != 0)
        {
                return;
        }
        
        this.不业不丕丘丕丌丘丟();
    }
    internal bool 世七丌丟丞且丛七且()
    {
        null = null;
        if(GameController.onlineMode == null)
        {
            
        }
    
    }
    internal void 不上丙下下东丁丅业()
    {
        if(this.业丙一丛一世丆丐七 != false)
        {
                if(this.不丕丅丝七丂丐丗丄 != 0)
        {
                this.不丕丅丝七丂丐丗丄.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.丕丑丌丛丗东三七丈 = this.下丄丕丕世万专业丑;
        int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921538675408912] = 0;
        this.不丝丛丘与丁万丟丈 = this.丗业丐丐丐丅丑丙丁;
        int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丗业丐丐丐丅丑丙丁 = 0;
        mem[1152921538675408864] = 0;
        this.丙专万丅丑丈丆丕丟 = this.丐专丒丛丅丕一丁丙;
        int val_5 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丐专丒丛丅丕一丁丙 = 0;
        mem[1152921538675408888] = 0;
        this.专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        this.丞上丕一丝七丌丑专(专丞上七七且丝七丗:  0);
        this.丑万丝丛丌丆一且且(专丞上七七且丝七丗:  0);
    }
    internal void 丝丝丒东丈丗下丑丏()
    {
        if(this.业丙一丛一世丆丐七 != false)
        {
                if(this.不丕丅丝七丂丐丗丄 != 0)
        {
                this.不丕丅丝七丂丐丗丄.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.不上丙下下东丁丅业();
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
                return;
        }
        
        this.丗不三丟世丅专七丏 = this.丟丛万丛三三业世丘;
        this.且上丒一三且丄下丆(专丞上七七且丝七丗:  0);
    }
    internal void 丛三丒丄且丘万丟丘()
    {
        if(this.业丙一丛一世丆丐七 == false)
        {
                return;
        }
        
        this.业丙一丛一世丆丐七 = false;
        this.且丆丅丗丘不东一丝();
    }
    internal void 七七且与丈不三丒丙(PlayerBotController 丛世丕丘七东下丌丄)
    {
        this.不丕丅丝七丂丐丗丄 = 丛世丕丘七东下丌丄;
    }
    private void 不业不丕丘丕丌丘丟()
    {
        this.丕丑丌丛丗东三七丈 = 0;
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.不丝丛丘与丁万丟丈 = 0;
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921538675906064] = 0;
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丙专万丅丑丈丆丕丟 = 0;
        this.丗业丐丐丐丅丑丙丁 = 0;
        mem[1152921538675906016] = 0;
        int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丐专丒丛丅丕一丁丙 = 0;
        mem[1152921538675906040] = 0;
        this.专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        this.丞上丕一丝七丌丑专(专丞上七七且丝七丗:  0);
        this.丑万丝丛丌丆一且且(专丞上七七且丝七丗:  0);
        if(GameConnect.丑丌丛丈丅丅与不业() == 16)
        {
                return;
        }
        
        this.七丝丑丁丑丂七丏丕();
    }
    internal void 七丝丑丁丑丂七丏丕()
    {
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
            val_27 = 10000f;
            val_28 = val_2.x;
            val_29 = val_2.y;
            val_30 = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  val_27, a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30});
            val_31 = val_3.x;
            val_32 = val_3.y;
            val_33 = val_3.z;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        }
        else
        {
                PlayerSpawnPoint val_5 = this.世丌丐丁丂一丘丂一.丑丆丘丗世不丌丅丒(丕丅不业专丑丁上丅:  true);
            UnityEngine.Vector3 val_6 = val_5.boxCollider.size;
            UnityEngine.Vector3 val_7 = val_5.万东万丆专丌丕丐丗.localScale;
            UnityEngine.Vector3 val_8 = val_5.boxCollider.size;
            UnityEngine.Vector3 val_9 = val_5.万东万丆专丌丕丐丗.localScale;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_6.x * val_7.x, y:  val_8.z * val_9.z);
            UnityEngine.Vector3 val_13 = val_5.万东万丆专丌丕丐丗.position;
            UnityEngine.Vector3 val_14 = val_5.万东万丆专丌丕丐丗.position;
            val_30 = val_12.y;
            float val_26 = 0.5f;
            float val_15 = val_12.x * val_26;
            val_15 = val_13.x - val_15;
            val_26 = val_30 * val_26;
            val_26 = val_14.z - val_26;
            float val_16 = 0.x;
            UnityEngine.Vector3 val_18 = val_5.万东万丆专丌丕丐丗.position;
            val_29 = val_18.x + (UnityEngine.Random.Range(min:  0f, max:  val_18.x));
            val_27 = val_16 + (UnityEngine.Random.Range(min:  0f, max:  val_16));
            val_28 = val_18.y;
            UnityEngine.Quaternion val_21 = val_5.万东万丆专丌丕丐丗.rotation;
            val_31 = val_31;
            val_32 = val_32;
            val_33 = val_33;
        }
        
        object[] val_23 = new object[1];
        int val_24 = this.丄丈丑丐丆丞丘与丗.viewID;
        if(val_23 == null)
        {
            goto label_20;
        }
        
        if(val_24 != 0)
        {
            goto label_21;
        }
        
        goto label_24;
        label_20:
        if(val_24 == 0)
        {
            goto label_24;
        }
        
        label_21:
        label_24:
        val_23[0] = val_24;
        UnityEngine.GameObject val_25 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  (this.isScenarioBot == true) ? this.controllerPrefab : "Bots/PlayerBot", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_33}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_23);
    }
    private void 且丆丅丗丘不东一丝()
    {
        if(this.不丕丅丝七丂丐丗丄 == 0)
        {
                return;
        }
        
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        PlayerBotsManager.与一丅丝不丈业与丙().丛丘东世丂万丕丂世(业丘东且七丕丞东不:  this.不丕丅丝七丂丐丗丄);
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.不丕丅丝七丂丐丗丄.gameObject);
        this.业丙一丛一世丆丐七 = false;
    }
    internal FortAttackBotSet 丗丆东丗丕上丆上丂()
    {
        int val_3;
        var val_4;
        var val_5;
        val_3 = this;
        if(this.且丘丌丟丘丆丂专世 == 1)
        {
            goto label_8;
        }
        
        val_4 = null;
        val_4 = null;
        if(GameController.mode == null)
        {
            goto label_6;
        }
        
        if(this.且丘丌丟丘丆丂专世 < (GameController.mode + 504.Count))
        {
                val_3 = this.且丘丌丟丘丆丂专世;
            FortAttackBotSet val_2 = GameController.mode + 504.Item[val_3];
            return (FortAttackBotSet)val_5;
        }
        
        label_8:
        val_5 = 0;
        return (FortAttackBotSet)val_5;
        label_6:
    }
    internal PGCompany.Matchmaking.Server.与丟下丒丝上丅丗丐 丒丄上丌丌与丒丗丌()
    {
        return (PGCompany.Matchmaking.Server.与丟下丒丝上丅丗丐)this.丗万三专丌丞七丁丆;
    }
    internal FortBotSet 不与丌丛丌且三丞丝()
    {
        var val_3;
        var val_4;
        if((System.String.IsNullOrEmpty(value:  this.丅丑丗丙三丄丐丛丂)) != false)
        {
                return 0;
        }
        
        val_3 = null;
        val_3 = null;
        if(GameController.mode == null)
        {
                return 0.一丝丞丆且上丛丆与(丈丑丟专丒世一丙下:  this.丅丑丗丙三丄丐丛丂);
        }
        
        val_4 = null;
        val_4 = null;
        var val_2 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (FortAttackController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_4) ? GameController.mode : 0;
        return 0.一丝丞丆且上丛丆与(丈丑丟专丒世一丙下:  this.丅丑丗丙三丄丐丛丂);
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        PhotonView val_5 = this.丄丈丑丐丆丞丘与丗;
        if(val_5.isMine == false)
        {
                return;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = this.且业丞丁丁且丒下丕;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  83, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        object[] val_3 = new object[1];
        val_5 = val_3;
        val_5[0] = this.丞丞下东且丗丄丒丏;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  81, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        this.且上丒一三且丄下丆(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.专丅世与下丕且且丕(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.丞上丕一丝七丌丑专(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.丑万丝丛丌丆一且且(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.七丆下丆且业丝丐丕(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.专丟丛七丙下不丐世(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if(this.丝与丆丞东丘丈东丘 == false)
        {
                return;
        }
        
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  132, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    private void 七丆下丆且业丝丐丕(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.丌丞三丕不丒业丆业 == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丗万三专丌丞七丁丆.专下不丘丘丝丅七三)) != false)
        {
                return;
        }
        
        object[] val_2 = new object[4];
        val_2[0] = this.丗万三专丌丞七丁丆.专丐下一且丕丟丐一;
        val_2[1] = "-1";
        val_2[2] = this.丗万三专丌丞七丁丆.专下不丘丘丝丅七三;
        val_2[3] = "-1";
        if(专丞上七七且丝七丗 != null)
        {
                this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  79, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  79, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 专丟丛七丙下不丐世(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        System.Object[] val_7;
        if(this.丌丞三丕不丒业丆业 != true)
        {
                object[] val_1 = new object[1];
            val_7 = val_1;
            val_7[0] = this.专丏丗丈东丗丏丘丞;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  80, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
            if(this.丌丞三丕不丒业丆业 == false)
        {
                return;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丗万三专丌丞七丁丆.万丐丆丗丏丝七东专)) != true)
        {
                object[] val_3 = new object[1];
            val_7 = val_3;
            val_7[0] = this.丗万三专丌丞七丁丆.万丐丆丗丏丝七东专;
            if(专丞上七七且丝七丗 != null)
        {
                this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  80, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        }
        else
        {
                this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  80, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
        }
        
        }
        
        if(this.丗万三专丌丞七丁丆.丘专丅丞七且丗东丁 != null)
        {
                object[] val_4 = new object[1];
            val_7 = val_4;
            val_7[0] = this.丗万三专丌丞七丁丆.丘专丅丞七且丗东丁;
            if(专丞上七七且丝七丗 != null)
        {
                this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  80, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_4);
        }
        else
        {
                this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  80, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丗万三专丌丞七丁丆.丛丗丅丆丕丅上丑三)) != false)
        {
                return;
        }
        
        object[] val_6 = new object[1];
        val_6[0] = this.丗万三专丌丞七丁丆.丛丗丅丆丕丅上丑三;
        if(专丞上七七且丝七丗 != null)
        {
                this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  187, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_6);
            return;
        }
        
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  187, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_6);
    }
    private void OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        if(this.丝与丆丞东丘丈东丘 == true)
        {
                return;
        }
        
        if(this.世丌丐丁丂一丘丂一 == 0)
        {
                return;
        }
        
        this.丑丟下丅丈丐业丝专();
    }
    private void 丐丕丁丞丑丙丅丐丈(object[] 业丐世丛丐一丌业不)
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        if(this.丝与丆丞东丘丈东丘 == true)
        {
                return;
        }
        
        if(this.世丌丐丁丂一丘丂一 == 0)
        {
                return;
        }
        
        this.丑丟下丅丈丐业丝专();
    }
    internal int 丑丛丆三丆丄七丐万()
    {
    
    }
    internal void 丆专世丒七丒东丕世(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丗业丐丐丐丅丑丙丁 = 0;
        mem[1152921538677976416] = 0;
    }
    internal int 丒丛丈丌丒万丆丟丄()
    {
    
    }
    internal void 丏丙丄丑丄丗丏丟丆(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丐专丒丛丅丕一丁丙 = 0;
        mem[1152921538678200440] = 0;
    }
    internal int 丝丈丅一丆丗丝丝丘()
    {
    
    }
    internal void 东且世丈丒丄世三丈(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921538678424464] = 0;
    }
    internal void 一丆一专丆丛专丘丌()
    {
        if(GameConnect.丘丐丅丌上与丒丞万() == true)
        {
                return;
        }
        
        this.不丕丅丝七丂丐丗丄.丌丕下东七丗丛丞下.myPlayerBotEntity.丗三七丕丏万丘丐与.CancelTarget();
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丗业丐丐丐丅丑丙丁 = 0;
        mem[1152921538678552800] = 0;
        this.专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        this.世不不丝万世且上丒();
    }
    internal void 丗下丞七丐一丐一丛()
    {
        if(GameConnect.丘丐丅丌上与丒丞万() == true)
        {
                return;
        }
        
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丐专丒丛丅丕一丁丙 = 0;
        mem[1152921538678681208] = 0;
        this.丞上丕一丝七丌丑专(专丞上七七且丝七丗:  0);
        this.世不不丝万世且上丒();
    }
    internal void 专丅世与下丕且且丕(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_4;
        object[] val_1 = new object[2];
        if(专丞上七七且丝七丗 != null)
        {
                val_1[0] = this.丗业丐丐丐丅丑丙丁;
            val_1[1] = this.不丝丛丘与丁万丟丈;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  117, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
            object[] val_2 = new object[2];
            val_2[0] = this.丗业丐丐丐丅丑丙丁;
            val_4 = this.不丝丛丘与丁万丟丈;
            val_2[1] = val_4;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  117, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        val_1[0] = this.丗业丐丐丐丅丑丙丁;
        val_1[1] = this.不丝丛丘与丁万丟丈;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  117, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        object[] val_3 = new object[2];
        val_3[0] = this.丗业丐丐丐丅丑丙丁;
        val_4 = this.不丝丛丘与丁万丟丈;
        val_3[1] = val_4;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  117, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 丞上丕一丝七丌丑专(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_4;
        object[] val_1 = new object[2];
        if(专丞上七七且丝七丗 != null)
        {
                val_1[0] = this.丐专丒丛丅丕一丁丙;
            val_1[1] = this.丙专万丅丑丈丆丕丟;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  146, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
            object[] val_2 = new object[2];
            val_2[0] = this.丐专丒丛丅丕一丁丙;
            val_4 = this.丙专万丅丑丈丆丕丟;
            val_2[1] = val_4;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  146, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        val_1[0] = this.丐专丒丛丅丕一丁丙;
        val_1[1] = this.丙专万丅丑丈丆丕丟;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  146, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        object[] val_3 = new object[2];
        val_3[0] = this.丐专丒丛丅丕一丁丙;
        val_4 = this.丙专万丅丑丈丆丕丟;
        val_3[1] = val_4;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  146, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    private void 丑万丝丛丌丆一且且(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_4;
        object[] val_1 = new object[2];
        if(专丞上七七且丝七丗 != null)
        {
                val_1[0] = this.下丄丕丕世万专业丑;
            val_1[1] = this.丕丑丌丛丗东三七丈;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  123, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
            object[] val_2 = new object[2];
            val_2[0] = this.下丄丕丕世万专业丑;
            val_4 = this.丕丑丌丛丗东三七丈;
            val_2[1] = val_4;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  123, 丞下万上三丘上与专:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        val_1[0] = this.下丄丕丕世万专业丑;
        val_1[1] = this.丕丑丌丛丗东三七丈;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  123, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        object[] val_3 = new object[2];
        val_3[0] = this.下丄丕丕世万专业丑;
        val_4 = this.丕丑丌丛丗东三七丈;
        val_3[1] = val_4;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  123, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 一东三丗丛不与丈丂(丅世一丈七丆业丝丘 丐丘丌三丏与丙且东, float 专上丝且丂世丛丝丒 = 1)
    {
        var val_6;
        丅世一丈七丆业丝丘[] val_7;
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_6 = null;
            val_6 = null;
            var val_6 = 0;
            val_7 = MutationController.MutationScoreEvents;
            do
        {
            if(val_6 >= MutationController.MutationScoreEvents.Length)
        {
                return;
        }
        
            val_6 = val_6 + 1;
        }
        while((MutationController.MutationScoreEvents.Length + 32) != 丐丘丌三丏与丙且东);
        
        }
        
        val_7 = this.下丄丕丕世万专业丑;
        int val_4 = UnityEngine.Mathf.Max(a:  0, b:  val_7 + (PlayerScoreController.丄丈丏丒万丝丐上丘(丐丘丌三丏与丙且东:  丐丘丌三丏与丙且东, 专上丝且丂世丛丝丒:  专上丝且丂世丛丝丒)));
        int val_5 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.下丄丕丕世万专业丑 = 0;
        mem[1152921538679453104] = 0;
        if(this.丆丈丆下丆专不且万 >= 0)
        {
                return;
        }
        
        this.丆丈丆下丆专不且万 = 1f;
    }
    internal void 丆丂东丏与不与不丟()
    {
        if(this.丆丈丆下丆专不且万 >= 0)
        {
                return;
        }
        
        this.丆丈丆下丆专不且万 = 1f;
    }
    private void 丂丆丄丛丂三丘业一()
    {
        if(this.丆丈丆下丆专不且万 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丆丈丆下丆专不且万 - val_1;
        this.丆丈丆下丆专不且万 = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.丑万丝丛丌丆一且且(专丞上七七且丝七丗:  0);
    }
    private void 世不不丝万世且上丒()
    {
        if(GameConnect.丛上丆一丂业丕丈丐() == false)
        {
                return;
        }
        
        int val_3 = this.丄与丒丏丘七上丕丒;
        int val_4 = this.丙丞七丕东丒上世一;
        val_3 = (this.丗业丐丐丐丅丑丙丁 + this.丐专丒丛丅丕一丁丙) / val_3;
        if(val_3 <= val_4)
        {
                return;
        }
        
        val_4 = val_4 + 1;
        this.丙丞七丕东丒上世一 = val_4;
        float val_5 = (float)this.丗业丐丐丐丅丑丙丁;
        val_5 = val_5 / (float)this.丐专丒丛丅丕一丁丙;
        this.不丕丅丝七丂丐丗丄.丌丕下东七丗丛丞下.且万丄与丌万丈丛丝(丗丘丆丄丝与东下上:  val_5);
    }
    internal void 丛丞丑丌丈业与丝丈(int 丆丐万丑上丄上丂三)
    {
        this.丄与丒丏丘七上丕丒 = 丆丐万丑上丄上丂三;
    }

}
