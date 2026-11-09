using UnityEngine;
public sealed class JoinRoomFromFrends : MonoBehaviour
{
    // Fields
    public int game_mode;
    public string room_name;
    internal static JoinRoomFromFrends 丞丗丞丂三下丏丈丛;
    public UnityEngine.GameObject friendsPanel;
    public UnityEngine.GameObject connectPanel;
    internal static UnityEngine.GameObject 丈不丄专与丘不丕且;
    public UILabel label;
    public UnityEngine.GameObject plashkaLabel;
    private bool 丁丘丐上专丟丛丌丕;
    private bool 丞下七业丗丞丑丑丐;
    private bool 丄专丝与丕丞丅一丞;
    public UITexture fonConnectTexture;
    private string 万丘三丞丆丄丙下丕;
    public UnityEngine.GameObject WrongPasswordLabel;
    private float 专丝丞下且丗丟上丆;
    public UnityEngine.GameObject PasswordPanel;
    private bool 丑丏丌丁丝丕丂七世;
    public UIInput inputPassworLabel;
    public UnityEngine.GameObject objectForOffWhenUlockDialog;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    
    // Methods
    private void Start()
    {
        null = null;
        JoinRoomFromFrends.丞丗丞丂三下丏丈丛 = this;
    }
    private void OnEnable()
    {
        this.丝丅七丑上丟业不东();
    }
    private void 且丆七世丕丌丄丏七()
    {
        GameConnect.下与业丒丝丕丙丘丙();
        this.closeConnectPanel();
        this.东丞丒丗专业且专丒();
    }
    private void OnDisable()
    {
        this.与丆丈丗丄丒东丈丘();
    }
    private void OnDestroy()
    {
        null = null;
        JoinRoomFromFrends.丞丗丞丂三下丏丈丛 = 0;
    }
    private void 丝丅七丑上丟业不东()
    {
        var val_12;
        System.Action<System.Boolean> val_13;
        var val_14;
        丑丕与三丟且三丈丌 val_15;
        var val_16;
        System.Action val_17;
        var val_18;
        var val_19;
        System.Action val_20;
        var val_21;
        var val_22;
        System.Action val_23;
        val_12 = null;
        val_12 = null;
        val_14 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void JoinRoomFromFrends::OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_14 = null;
            val_13 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_13;
        val_16 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void JoinRoomFromFrends::OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_15;
        val_18 = null;
        val_19 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  public System.Void JoinRoomFromFrends::OnConnectedToMaster()))) != null) && (null != val_19))
        {
                val_18 = null;
            val_19 = null;
            val_17 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_17;
        val_21 = null;
        val_22 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void JoinRoomFromFrends::OnDisconnectedFromPhoton()))) != null) && (null != val_22))
        {
                val_21 = null;
            val_22 = null;
            val_20 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_20;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void JoinRoomFromFrends::OnJoinedRoom()))) != null) && (null != null))
        {
                val_23 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_23;
    }
    private void 与丆丈丗丄丒东丈丘()
    {
        var val_12;
        System.Action<System.Boolean> val_13;
        var val_14;
        丑丕与三丟且三丈丌 val_15;
        var val_16;
        System.Action val_17;
        var val_18;
        var val_19;
        System.Action val_20;
        var val_21;
        var val_22;
        System.Action val_23;
        val_12 = null;
        val_12 = null;
        val_14 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void JoinRoomFromFrends::OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_14 = null;
            val_13 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_13;
        val_16 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void JoinRoomFromFrends::OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_15;
        val_18 = null;
        val_19 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  public System.Void JoinRoomFromFrends::OnConnectedToMaster()))) != null) && (null != val_19))
        {
                val_18 = null;
            val_19 = null;
            val_17 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_17;
        val_21 = null;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void JoinRoomFromFrends::OnDisconnectedFromPhoton()))) != null) && (null != val_22))
        {
                val_21 = null;
            val_22 = null;
            val_20 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_20;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void JoinRoomFromFrends::OnJoinedRoom()))) != null) && (null != null))
        {
                val_23 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_23;
    }
    public void BackFromPasswordButton()
    {
        this.丑丏丌丁丝丕丂七世 = true;
        this.丘且丁万上下世东东(丝三丄专丗丞丄丄丌:  false);
        GameConnect.下与业丒丝丕丙丘丙();
        this.东丞丒丗专业且专丒();
        UnityEngine.Debug.Log(message:  "BackFromPasswordButton");
    }
    public void EnterPassword(string 丙七一丒丛丈丁丏专)
    {
        if((System.String.op_Equality(a:  丙七一丒丛丈丁丏专, b:  this.万丘三丞丆丄丙下丕)) != false)
        {
                丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丝业丗上上丘丐与丗());
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
            return;
        }
        
        this.专丝丞下且丗丟上丆 = 3f;
        this.WrongPasswordLabel.SetActive(value:  true);
    }
    private void 上丌万丙丝世三丌丝(string 丛丘七丂且丟丁一丙, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        LoadingNGUIController val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        this.三三丆下东丏丌丅上 = val_3;
        val_3.SceneToLoad = 丛丘七丂且丟丁一丙;
        string[] val_4 = new string[5];
        val_4[0] = "LevelLoadings";
        val_4[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
        val_4[2] = "/Loading_";
        val_4[3] = (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Mine_" : "";
        val_4[4] = 丛丘七丂且丟丁一丙;
        this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  +val_4));
        this.三三丆下东丏丌丅上.transform.parent = this.fonConnectTexture.transform.parent;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        this.三三丆下东丏丌丅上.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        this.三三丆下东丏丌丅上.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅);
    }
    private void 不丕与世七丛万东万()
    {
        if(this.三三丆下东丏丌丅上 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.三三丆下东丏丌丅上.gameObject);
        this.三三丆下东丏丌丅上 = 0;
    }
    private void 丅丟丘专丞丁丄丌丗(string 丛丘七丂且丟丁一丙 = "", bool 丑一丈丐专丑且丞丅 = False, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        this.不丕与世七丛万东万();
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙, 丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅);
    }
    public void ConnectToRoom(int 丗七丏专丁丐一丘丆, string 丛丟丘丞丟丞不丂上, string 丛丝丁丗且丘丂与万, string 丌业三世且丛丘丌丟)
    {
        var val_31;
        int val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void JoinRoomFromFrends::且丆七世丕丌丄丏七()), 与且专丈不万东一万:  "Connect To Friend");
        InfoWindowController.一丘丕上丈一丂丐丌();
        this.丘且丁万上下世东东(丝三丄专丗丞丄丄丌:  false);
        val_31 = null;
        val_31 = null;
        if((System.String.IsNullOrEmpty(value:  丌业三世且丛丘丌丟)) != false)
        {
                val_32 = 0;
        }
        else
        {
                val_32 = System.Int32.Parse(s:  丌业三世且丛丘丌丟);
        }
        
        string val_9 = val_31 >> 32;
        val_31 = val_31 >> 63;
        this.room_name = 丛丟丘丞丟丞不丂上;
        this.game_mode = 丗七丏专丁丐一丘丆 - (((Klass->__il2cppRuntimeField_interfaceOffsets[].offset >> 63) + ((int)(Klass->__il2cppRuntimeField_interfaceOffsets[].offset >> 32)) >> 5) * 100);
        val_33 = null;
        val_33 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = true;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = true;
        if((this.game_mode & 4294967294) == 6)
        {
                UnityEngine.Debug.LogError(message:  "Wrong gamemode!");
            return;
        }
        
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  this.game_mode);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        this.丞下七业丗丞丑丑丐 = this.friendsPanel.activeSelf;
        val_34 = null;
        val_34 = null;
        if(JoinRoomFromFrends.丈不丄专与丘不丕且 != 0)
        {
                val_35 = null;
            val_35 = null;
            this.丄专丝与丕丞丅一丞 = JoinRoomFromFrends.丈不丄专与丘不丕且.activeSelf;
        }
        
        this.connectPanel.SetActive(value:  true);
        this.friendsPanel.SetActive(value:  false);
        val_36 = null;
        val_36 = null;
        if(JoinRoomFromFrends.丈不丄专与丘不丕且 != 0)
        {
                val_37 = null;
            val_37 = null;
            JoinRoomFromFrends.丈不丄专与丘不丕且.SetActive(value:  false);
        }
        
        this.label.gameObject.SetActive(value:  false);
        this.plashkaLabel.SetActive(value:  false);
        val_38 = null;
        val_38 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.东且三丆丑世世丘丟() != true) ? 3 : 0);
        this.不丕与世七丛万东万();
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丛丝丁丗且丘丂与万)).丙且上丒不下丑下丞(), 丐且丘丑与万丞丑丅:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_32));
        if(丗七丏专丁丐一丘丆 < 10000)
        {
                val_39 = 0;
        }
        else
        {
                int val_24 = 丗七丏专丁丐一丘丆 + 4294867296;
            val_24 = val_24 >> 44;
            val_39 = val_24 + (val_24 >> 63);
        }
        
        int val_26 = 0 + 0;
        丅丒丗丑丒丙丛不丆.丌三七与不丐丅丞上(丙业与丙丗丝不丈东:  false);
        if(val_39 == 3)
        {
                bool val_27 = GameConnect.七丑三不丙丄丄东丞(业万上丆丐丞且丒七:  val_26);
            return;
        }
        
        bool val_29 = GameConnect.丆下丅丟下丂一不丙(业万上丆丐丞且丒七:  val_26, 丛丈丑丏与上丄丝丌:  true, 丐且丘丑与万丞丑丅:  (val_32 != 1) ? 1 : 0);
    }
    private void Update()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        float val_12;
        val_7 = null;
        val_7 = null;
        val_8 = 1152921504848912384;
        if(coinsPlashka.专丆专上丗万世丒七 == 0)
        {
            goto label_5;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        if(coinsShop.专丆专上丗万世丒七 == 0)
        {
            goto label_12;
        }
        
        val_11 = null;
        val_11 = null;
        val_8 = coinsShop.专丆专上丗万世丒七.enabled;
        if(coinsPlashka.专丆专上丗万世丒七 != null)
        {
            goto label_18;
        }
        
        goto label_17;
        label_12:
        val_8 = 0;
        if(coinsPlashka.专丆专上丗万世丒七 != null)
        {
            goto label_18;
        }
        
        label_17:
        label_18:
        coinsPlashka.专丆专上丗万世丒七.enabled = false;
        label_5:
        val_12 = this.专丝丞下且丗丟上丆;
        if(val_12 > 0f)
        {
                val_12 = this.专丝丞下且丗丟上丆;
            if(this.WrongPasswordLabel.activeSelf != false)
        {
                val_12 = val_12 - UnityEngine.Time.deltaTime;
            this.专丝丞下且丗丟上丆 = val_12;
        }
        
        }
        
        if(val_12 > 0f)
        {
                return;
        }
        
        if(this.WrongPasswordLabel.activeSelf == false)
        {
                return;
        }
        
        this.WrongPasswordLabel.SetActive(value:  false);
    }
    private void 专丌一丝丒东丛丒一(System.Action 一丗与与丌七丆丂不, string 丂一丏丙下丝丘丆丗)
    {
        string val_19;
        object val_20;
        var val_21;
        var val_22;
        UnityEngine.Object val_23;
        val_19 = 丂一丏丙下丝丘丆丗;
        JoinRoomFromFrends.丑丗东丞三且丂丄丒 val_1 = null;
        val_20 = val_1;
        val_1 = new JoinRoomFromFrends.丑丗东丞三且丂丄丒();
        if(val_20 != null)
        {
                val_21 = val_20;
            .丂一丏丙下丝丘丆丗 = val_19;
            mem[1152921530773711728] = this;
            mem[1152921530773711744] = 一丗与与丌七丆丂不;
        }
        else
        {
                mem[16] = this;
            mem[32] = 一丗与与丌七丆丂不;
            val_21 = 40;
            mem[40] = val_19;
            val_19 = mem[40];
        }
        
        if((System.String.IsNullOrEmpty(value:  val_19)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Level name shoul not be empty.");
            return;
        }
        
        val_19 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "UnlockPremiumMapView"));
        if(val_19 != null)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_19 = 0;
        val_22 = 1;
        goto label_11;
        label_10:
        val_22 = 0;
        label_11:
        val_19.transform.parent = this.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        val_19.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        val_19.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_19, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        UnlockPremiumMapView val_13 = val_19.GetComponent<UnlockPremiumMapView>();
        if(val_20 != null)
        {
                val_23 = val_20;
            .专三世丆丏万丄上丏 = val_13;
        }
        else
        {
                val_23 = 24;
            mem[24] = val_13;
        }
        
        if(val_23 == 0)
        {
                UnityEngine.Debug.LogError(message:  "UnlockPremiumMapView should not be null.");
            return;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        bool val_18 = 与丂丏丛丞丞丒丟丄.丛丑丙业丟丙丏丒丙().TryGetValue(key:  null, value: out  TValue val_17 = null);
        mem[24].Price = 0;
        System.EventHandler val_19 = null;
        val_19 = val_19;
        val_19 = new System.EventHandler(object:  val_1, method:  System.Void JoinRoomFromFrends.丑丗东丞三且丂丄丒::专丂上与不一丈三丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        mem[24].add_ClosePressed(丙业与丙丗丝不丈东:  val_19);
        val_20 = mem[24];
        val_20.add_UnlockPressed(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void JoinRoomFromFrends.丑丗东丞三且丂丄丒::业丙万且且一丟丅丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丈上丂世丞丄丁丘丛(UnlockPremiumMapView 专三世丆丏万丄上丏)
    {
        UnityEngine.GameObject val_3 = this.objectForOffWhenUlockDialog;
        if(val_3 != 0)
        {
                val_3 = this.objectForOffWhenUlockDialog;
            val_3.SetActive(value:  true);
        }
        
        this.closeConnectPanel();
        UnityEngine.Object.Destroy(obj:  专三世丆丏万丄上丏.gameObject);
    }
    private void 丅专下下世丑丈丟与(UnlockPremiumMapView 专三世丆丏万丄上丏, System.Action 一丗与与丌七丆丂不, string 丂一丏丙下丝丘丆丗)
    {
        var val_9;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        System.Action val_15;
        JoinRoomFromFrends.丟丑不七不丆业丐丛 val_1 = new JoinRoomFromFrends.丟丑不七不丆业丐丛();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .专三世丆丏万丄上丏 = 专三世丆丏万丄上丏;
        mem[1152921530774064768] = 丂一丏丙下丝丘丆丗;
        mem[1152921530774064776] = 一丗与与丌七丆丂不;
        if(专三世丆丏万丄上丏 != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        int val_2 = 专三世丆丏万丄上丏.Price;
        val_9 = null;
        val_9 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_7;
        }
        
        val_10 = null;
        val_10 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        val_11 = null;
        val_11 = null;
        val_12 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        val_13 = null;
        val_13 = null;
        val_15 = JoinRoomFromFrends.<>c.<>9__37_1;
        if(val_15 == null)
        {
                System.Action val_8 = null;
            val_15 = val_8;
            val_8 = new System.Action(object:  JoinRoomFromFrends.<>c.__il2cppRuntimeField_static_fields, method:  System.Void JoinRoomFromFrends.<>c::丟三丝丐丄且丕丑丝());
            JoinRoomFromFrends.<>c.<>9__37_1 = val_15;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  FriendsWindowGUI.丆丕丝丒不丙且丐丗.gameObject, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  .专三世丆丏万丄上丏.Price, 丏丂不专上丘丂不丅:  val_12), 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void JoinRoomFromFrends.丟丑不七不丆业丐丛::世丄下丄丁丟上不丗()), 丝丏丗丄丗与丐丌三:  val_8, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  82);
        return;
        label_7:
        if(.专三世丆丏万丄上丏 != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_1:
        mem[16] = 丂一丏丙下丝丘丆丗;
        mem[24] = 一丗与与丌七丆丂不;
        mem[32] = 专三世丆丏万丄上丏;
        if(mem[32] != 0)
        {
            goto label_25;
        }
        
        goto label_26;
    }
    public void closeConnectPanel()
    {
        this.CancelInvoke(methodName:  "closeConnectPanel");
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.不丕与世七丛万东万();
        this.connectPanel.SetActive(value:  false);
        this.label.gameObject.SetActive(value:  false);
        this.plashkaLabel.SetActive(value:  false);
        this.friendsPanel.SetActive(value:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    private void 丆丘丆上不丒丐不世(string 丕丗丘丑丛与丑业丒)
    {
        if(this.connectPanel.activeSelf == false)
        {
                return;
        }
        
        this.label.text = 丕丗丘丑丛与丑业丒;
        this.label.gameObject.SetActive(value:  true);
        this.plashkaLabel.SetActive(value:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.Invoke(methodName:  "closeConnectPanel", time:  3f);
    }
    private void OnDisconnectedFromPhoton()
    {
        bool val_1;
        if(this.丁丘丐上专丟丛丌丕 != false)
        {
                this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  "Game is unavailable...");
            val_1 = this.丑丏丌丁丝丕丂七世;
        }
        else
        {
                val_1 = this;
            if(this.丑丏丌丁丝丕丂七世 != false)
        {
                this.closeConnectPanel();
        }
        else
        {
                this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  "Can\'t connect ...");
        }
        
        }
        
        this.丁丘丐上专丟丛丌丕 = false;
        this.丑丏丌丁丝丕丂七世 = false;
        UnityEngine.Debug.Log(message:  "On Disconnected From Photon");
    }
    private void OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)
    {
        this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  "Can\'t connect ...");
        UnityEngine.Debug.Log(message:  "On Failed To Connect To Photon. StatusCode: "("On Failed To Connect To Photon. StatusCode: ") + 丗丟上上丒丐丗丞丙);
    }
    public void OnConnectedToMaster()
    {
        this.ConnectToRoom();
    }
    public void OnJoinedLobby()
    {
        this.ConnectToRoom();
    }
    private void ConnectToRoom()
    {
        if((System.String.IsNullOrEmpty(value:  this.room_name)) != false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.丅丗业与万且不丐丈(丙业与丙丗丝不丈东:  ProfileController.丆三丂丂丆上丆丕专());
        UnityEngine.Debug.Log(message:  "OnJoinedLobby " + this.room_name);
        bool val_4 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  this.room_name);
    }
    private void OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)
    {
        UnityEngine.Debug.Log(message:  "[Join_RoomFromFrends] On_PhotonJoinRoomFailed => init");
        this.丁丘丐上专丟丛丌丕 = true;
        GameConnect.下与业丒丝丕丙丘丙();
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0137"));
        InfoWindowController.丏三万丏世丛业丒丒(丂三丟丂丈丐丆丗丟:  3f);
        this.东丞丒丗专业且专丒();
    }
    private void 东丞丒丗专业且专丒()
    {
        var val_1;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
        val_1 = null;
        val_1 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
    }
    private void 丘且丁万上下世东东(bool 丝三丄专丗丞丄丄丌)
    {
        var val_6;
        丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
        this.PasswordPanel.SetActive(value:  丝三丄专丗丞丄丄丌);
        if(this.三三丆下东丏丌丅上 == 0)
        {
                return;
        }
        
        this.fonConnectTexture.gameObject.SetActive(value:  丝三丄专丗丞丄丄丌);
        val_6 = 0;
        if(丝三丄专丗丞丄丄丌 != false)
        {
                val_6 = this.三三丆下东丏丌丅上.loadingNGUITexture;
        }
        
        this.三三丆下东丏丌丅上.gameObject.SetActive(value:  (~丝三丄专丗丞丄丄丌) & 1);
    }
    private void OnJoinedRoom()
    {
        var val_10;
        var val_11;
        UnityEngine.Debug.Log(message:  "On Joined Room - init");
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_5;
        }
        
        val_10 = null;
        val_10 = null;
        this.万丘三丞丆丄丙下丕 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七];
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        if((this.万丘三丞丆丄丙下丕.Equals(value:  "")) == true)
        {
            goto label_14;
        }
        
        val_11 = null;
        val_11 = null;
        if((System.String.Equals(a:  this.万丘三丞丆丄丙下丕, b:  GameConnect.丂万且丟丛丈与丞丏)) == false)
        {
            goto label_17;
        }
        
        label_14:
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丝业丗上上丘丐与丗());
        return;
        label_5:
        GameConnect.下与业丒丝丕丙丘丙();
        this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  "Game is unavailable...");
        return;
        label_17:
        UnityEngine.Debug.Log(message:  "Show Password Panel " + this.万丘三丞丆丄丙下丕);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.inputPassworLabel.value = "";
        this.丘且丁万上下世东东(丝三丄专丗丞丄丄丌:  true);
    }
    private System.Collections.IEnumerator 丝业丗上上丘丐与丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new JoinRoomFromFrends.上与丟丄丞丕丛不丆();
    }
    public JoinRoomFromFrends()
    {
    
    }
    private static JoinRoomFromFrends()
    {
    
    }

}
