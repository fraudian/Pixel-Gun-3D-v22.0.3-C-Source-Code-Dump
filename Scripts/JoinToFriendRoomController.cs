using UnityEngine;
internal sealed class JoinToFriendRoomController : MonoBehaviour
{
    // Fields
    internal static JoinToFriendRoomController 丆丕丝丒不丙且丐丗;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private bool 丁丌丞不丗丕丅丏一;
    private bool 与丕丑丕万丟丑丆丁;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    private string 东丞丕东丛世专上丂;
    private float 丛丟世万业世丝丁一;
    public UITexture backgroundConnectTexture;
    public UnityEngine.GameObject connectPanel;
    public int gameMode;
    public UnityEngine.GameObject infoBoxContainer;
    public UILabel infoBoxLabel;
    public UIInput inputPasswordLabel;
    private bool 丆丗七丙丁且业一丝;
    public UnityEngine.GameObject passwordPanel;
    public string roomName;
    public UnityEngine.GameObject wrongPasswordLabel;
    
    // Methods
    private void Awake()
    {
        this.inputPasswordLabel.onSubmit.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void JoinToFriendRoomController::丌丅万丆丗丅丈丛东())));
    }
    private void Start()
    {
        JoinToFriendRoomController.丆丕丝丒不丙且丐丗 = this;
    }
    private void OnEnable()
    {
        this.丝丅七丑上丟业不东();
    }
    private void 且丆七世丕丌丄丏七()
    {
        var val_2;
        GameConnect.下与业丒丝丕丙丘丙();
        if(JoinToFriendRoomController.丆丕丝丒不丙且丐丗 != 0)
        {
                this.closeConnectPanel();
            this.东丞丒丗专业且专丒();
            return;
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.业万且与丘与与三丕 = true;
        ConnectScene.上丄与丂不且丑丞丛();
    }
    private void OnDisable()
    {
        this.与丆丈丗丄丒东丈丘();
    }
    private void OnDestroy()
    {
        JoinToFriendRoomController.丆丕丝丒不丙且丐丗 = 0;
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
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void JoinToFriendRoomController::OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_14 = null;
            val_13 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_13;
        val_16 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂与丁东业上丄丛一, b:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void JoinToFriendRoomController::OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_15;
        val_18 = null;
        val_19 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丄业丅东丑且三七上, b:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::OnConnectedToMaster()))) != null) && (null != val_19))
        {
                val_18 = null;
            val_19 = null;
            val_17 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_17;
        val_21 = null;
        val_22 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::OnDisconnectedFromPhoton()))) != null) && (null != val_22))
        {
                val_21 = null;
            val_22 = null;
            val_20 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_20;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::OnJoinedRoom()))) != null) && (null != null))
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
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void JoinToFriendRoomController::OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)))) != null) && (null != null))
        {
                val_14 = null;
            val_13 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_13;
        val_16 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂与丁东业上丄丛一, value:  new GameConnect.丑丕与三丟且三丈丌(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void JoinToFriendRoomController::OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)))) != null) && (null != null))
        {
                val_16 = null;
            val_15 = 0;
        }
        
        GameConnect.丂与丁东业上丄丛一 = val_15;
        val_18 = null;
        val_19 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丄业丅东丑且三七上, value:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::OnConnectedToMaster()))) != null) && (null != val_19))
        {
                val_18 = null;
            val_19 = null;
            val_17 = 0;
        }
        
        GameConnect.丄业丅东丑且三七上 = val_17;
        val_21 = null;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::OnDisconnectedFromPhoton()))) != null) && (null != val_22))
        {
                val_21 = null;
            val_22 = null;
            val_20 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_20;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_23 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_23;
    }
    public void BackFromPasswordButton()
    {
        this.丁丌丞不丗丕丅丏一 = true;
        this.丘且丁万上下世东东(丝三丄专丗丞丄丄丌:  false);
        GameConnect.下与业丒丝丕丙丘丙();
        this.东丞丒丗专业且专丒();
    }
    public void OnClickAcceptPassword()
    {
        this.且业上上丂丁专丝丞(丙七一丒丛丈丁丏专:  this.inputPasswordLabel.value);
    }
    private void 且业上上丂丁专丝丞(string 丙七一丒丛丈丁丏专)
    {
        if((System.String.op_Equality(a:  丙七一丒丛丈丁丏专, b:  this.东丞丕东丛世专上丂)) != false)
        {
                丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丝业丗上上丘丐与丗());
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
            return;
        }
        
        this.丛丟世万业世丝丁一 = 3f;
        this.wrongPasswordLabel.SetActive(value:  true);
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
        this.三三丆下东丏丌丅上.transform.parent = this.backgroundConnectTexture.transform.parent;
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
    internal void 一业丁丁丌万丄七专(int 丌丝不东上丅东丏丒, string 丁丛东丝丗丐丐万且, string 丞丁丑丏丄丏七丂不, string 丌业三世且丛丘丌丟)
    {
        var val_27;
        int val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        System.Action val_36;
        this.丆丗七丙丁且业一丝 = true;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void JoinToFriendRoomController::且丆七世丕丌丄丏七()), 与且专丈不万东一万:  "Connect To Friend");
        InfoWindowController.一丘丕上丈一丂丐丌();
        this.丘且丁万上下世东东(丝三丄专丗丞丄丄丌:  false);
        val_27 = null;
        val_27 = null;
        SceneInfo val_6 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丞丁丑丏丄丏七丂不));
        if(val_6.isPremium != false)
        {
                if((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  val_6.丙且上丒不下丑下丞() + "Key", 丝丒上丑一三丑丐丛:  true)) == false)
        {
            goto label_18;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  丌业三世且丛丘丌丟)) != false)
        {
                val_28 = 0;
        }
        else
        {
                val_28 = System.Int32.Parse(s:  丌业三世且丛丘丌丟);
        }
        
        if(丌丝不东上丅东丏丒 <= 99)
        {
            goto label_21;
        }
        
        val_29 = this;
        this.gameMode = 0;
        val_30 = 0;
        mem[1152921537357542624] = 丁丛东丝丗丐丐万且;
        if(丌丝不东上丅东丏丒 < 10000)
        {
            goto label_22;
        }
        
        int val_12 = 丌丝不东上丅东丏丒 + 4294867296;
        val_12 = val_12 >> 44;
        val_31 = val_12 + (val_12 >> 63);
        goto label_23;
        label_21:
        val_29 = this;
        this.gameMode = 0;
        val_30 = 0;
        mem[1152921537357542624] = 丁丛东丝丗丐丐万且;
        label_22:
        val_31 = 0;
        label_23:
        val_32 = null;
        val_32 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = true;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = true;
        if(0 == 6)
        {
                UnityEngine.Debug.LogError(message:  "Wrong gamemode!");
            return;
        }
        
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  this.gameMode);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        this.connectPanel.SetActive(value:  true);
        this.infoBoxLabel.gameObject.SetActive(value:  false);
        this.infoBoxContainer.SetActive(value:  false);
        val_33 = null;
        val_33 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  (GameConnect.丑丌丛丈丅丅与不业() == 31) ? 105 : val_6.AvaliableWeapon);
        this.不丕与世七丛万东万();
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  val_6.丙且上丒不下丑下丞(), 丐且丘丑与万丞丑丅:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_28));
        丅丒丗丑丒丙丛不丆.丌三七与不丐丅丞上(丙业与丙丗丝不丈东:  false);
        if(val_31 != 3)
        {
            goto label_47;
        }
        
        bool val_20 = GameConnect.七丑三不丙丄丄东丞(业万上丆丐丞且丒七:  0);
        return;
        label_18:
        val_34 = null;
        val_34 = null;
        val_36 = JoinToFriendRoomController.<>c.<>9__31_0;
        if(val_36 == null)
        {
                System.Action val_21 = null;
            val_36 = val_21;
            val_21 = new System.Action(object:  JoinToFriendRoomController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void JoinToFriendRoomController.<>c::丅丄三丆丒丅丞丒丂());
            JoinToFriendRoomController.<>c.<>9__31_0 = val_36;
        }
        
        this.专丌一丝丒东丛丒一(一丗与与丌七丆丂不:  val_21, 丂一丏丙下丝丘丆丗:  val_6.丙且上丒不下丑下丞());
        return;
        label_47:
        bool val_24 = GameConnect.丆下丅丟下丂一不丙(业万上丆丐丞且丒七:  0, 丛丈丑丏与上丄丝丌:  true, 丐且丘丑与万丞丑丅:  (val_28 != 1) ? 1 : 0);
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
        this.infoBoxLabel.gameObject.SetActive(value:  false);
        this.infoBoxContainer.SetActive(value:  false);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.丆丗七丙丁且业一丝 = false;
    }
    private void 丆丘丆上不丒丐不世(string 丕丗丘丑丛与丑业丒)
    {
        if(this.connectPanel.activeSelf == false)
        {
                return;
        }
        
        this.infoBoxLabel.text = 丕丗丘丑丛与丑业丒;
        this.infoBoxLabel.gameObject.SetActive(value:  true);
        this.infoBoxContainer.SetActive(value:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.Invoke(methodName:  "closeConnectPanel", time:  3f);
    }
    private void OnDisconnectedFromPhoton()
    {
        bool val_3;
        this.丆丗七丙丁且业一丝 = false;
        if(this.与丕丑丕万丟丑丆丁 != false)
        {
                this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1410"));
            val_3 = this.丁丌丞不丗丕丅丏一;
        }
        else
        {
                val_3 = this;
            if(this.丁丌丞不丗丕丅丏一 != false)
        {
                this.closeConnectPanel();
        }
        else
        {
                this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1410"));
        }
        
        }
        
        this.与丕丑丕万丟丑丆丁 = false;
        this.丁丌丞不丗丕丅丏一 = false;
    }
    private void OnFailedToConnectToPhoton(int 丗丟上上丒丐丗丞丙)
    {
        if(this.丆丗七丙丁且业一丝 == false)
        {
                return;
        }
        
        this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1411"));
        UnityEngine.Debug.Log(message:  "OnFailedToConnectToPhoton. StatusCode: "("OnFailedToConnectToPhoton. StatusCode: ") + 丗丟上上丒丐丗丞丙);
        this.丆丗七丙丁且业一丝 = false;
    }
    private bool 丐不上不丑一万丅丟()
    {
        var val_10;
        var val_11;
        val_10 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_3;
        }
        
        int val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒();
        int val_5 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下();
        val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丞丙上丝世且且世丒();
        if(val_10 >= 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丕丏业且丒丂上七下())
        {
            goto label_10;
        }
        
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_10:
        val_11 = 1;
        return (bool)val_11;
    }
    private void OnConnectedToMaster()
    {
        if(this.丆丗七丙丁且业一丝 == false)
        {
                return;
        }
        
        this.ConnectToRoom();
    }
    public void OnJoinedLobby()
    {
        if(this.丆丗七丙丁且业一丝 == false)
        {
                return;
        }
        
        this.ConnectToRoom();
    }
    private void ConnectToRoom()
    {
        丅丒丗丑丒丙丛不丆.丅丗业与万且不丐丈(丙业与丙丗丝不丈东:  ProfileController.丆三丂丂丆上丆丕专());
        UnityEngine.Debug.Log(message:  "OnJoinedLobby " + this.roomName);
        bool val_3 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  this.roomName);
    }
    private void OnPhotonJoinRoomFailed(bool 丒七丛丟丅丝丛丟万)
    {
        string val_3;
        if(this.丆丗七丙丁且业一丝 == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "[Join_ToFriendRoomController] On_PhotonJoinRoomFailed => init");
        this.与丕丑丕万丟丑丆丁 = true;
        GameConnect.下与业丒丝丕丙丘丙();
        if(this.丐不上不丑一万丅丟() != false)
        {
                val_3 = "Key_0137";
        }
        else
        {
                val_3 = "Key_10508";
        }
        
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3));
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
        var val_4;
        丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
        this.passwordPanel.SetActive(value:  丝三丄专丗丞丄丄丌);
        if(this.三三丆下东丏丌丅上 == 0)
        {
                return;
        }
        
        if(丝三丄专丗丞丄丄丌 == false)
        {
            goto label_5;
        }
        
        val_4 = this.三三丆下东丏丌丅上.loadingNGUITexture;
        if(this.backgroundConnectTexture != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_5:
        val_4 = 0;
        if(this.backgroundConnectTexture != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        this.三三丆下东丏丌丅上.gameObject.SetActive(value:  (~丝三丄专丗丞丄丄丌) & 1);
    }
    private void OnJoinedRoom()
    {
        var val_11;
        var val_12;
        if(this.丆丗七丙丁且业一丝 == false)
        {
                return;
        }
        
        this.丆丗七丙丁且业一丝 = false;
        UnityEngine.Debug.Log(message:  "On Joined Room - init");
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_6;
        }
        
        val_11 = null;
        val_11 = null;
        this.东丞丕东丛世专上丂 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七];
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        if((this.东丞丕东丛世专上丂.Equals(value:  "")) == true)
        {
            goto label_15;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.String.Equals(a:  this.东丞丕东丛世专上丂, b:  GameConnect.丂万且丟丛丈与丞丏)) == false)
        {
            goto label_18;
        }
        
        label_15:
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丝业丗上上丘丐与丗());
        return;
        label_6:
        GameConnect.下与业丒丝丕丙丘丙();
        this.丆丘丆上不丒丐不世(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1410"));
        return;
        label_18:
        UnityEngine.Debug.Log(message:  "Show Password Panel " + this.东丞丕东丛世专上丂);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        this.inputPasswordLabel.value = System.String.alignConst;
        this.丘且丁万上下世东东(丝三丄专丗丞丄丄丌:  true);
    }
    private System.Collections.IEnumerator 丝业丗上上丘丐与丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new JoinToFriendRoomController.丂丂上丛专三丐丑三();
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
        val_12 = this.丛丟世万业世丝丁一;
        if(val_12 > 0f)
        {
                val_12 = this.丛丟世万业世丝丁一;
            if(this.wrongPasswordLabel.activeSelf != false)
        {
                val_12 = val_12 - UnityEngine.Time.deltaTime;
            this.丛丟世万业世丝丁一 = val_12;
        }
        
        }
        
        if(val_12 > 0f)
        {
                return;
        }
        
        if(this.wrongPasswordLabel.activeSelf == false)
        {
                return;
        }
        
        this.wrongPasswordLabel.SetActive(value:  false);
    }
    private void 专丌一丝丒东丛丒一(System.Action 一丗与与丌七丆丂不, string 丂一丏丙下丝丘丆丗)
    {
        string val_19;
        object val_20;
        var val_21;
        var val_22;
        UnityEngine.Object val_23;
        val_19 = 丂一丏丙下丝丘丆丗;
        JoinToFriendRoomController.上丏三丌丂丙丅且丘 val_1 = null;
        val_20 = val_1;
        val_1 = new JoinToFriendRoomController.上丏三丌丂丙丅且丘();
        if(val_20 != null)
        {
                val_21 = val_20;
            .丂一丏丙下丝丘丆丗 = val_19;
            mem[1152921537359818416] = this;
            mem[1152921537359818432] = 一丗与与丌七丆丂不;
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
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_19.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_19.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
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
        val_19 = new System.EventHandler(object:  val_1, method:  System.Void JoinToFriendRoomController.上丏三丌丂丙丅且丘::专丂上与不一丈三丆(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        mem[24].add_ClosePressed(丙业与丙丗丝不丈东:  val_19);
        val_20 = mem[24];
        val_20.add_UnlockPressed(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void JoinToFriendRoomController.上丏三丌丂丙丅且丘::业丙万且且一丟丅丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丈上丂世丞丄丁丘丛(UnlockPremiumMapView 专三世丆丏万丄上丏)
    {
        this.closeConnectPanel();
        UnityEngine.Object.Destroy(obj:  专三世丆丏万丄上丏.gameObject);
    }
    private void 丅专下下世丑丈丟与(UnlockPremiumMapView 专三世丆丏万丄上丏, System.Action 一丗与与丌七丆丂不, string 丂一丏丙下丝丘丆丗)
    {
        var val_10;
        string val_11;
        var val_12;
        System.Action val_14;
        JoinToFriendRoomController.丝业丞丕丟万万丝丙 val_1 = new JoinToFriendRoomController.丝业丞丕丟万万丝丙();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .专三世丆丏万丄上丏 = 专三世丆丏万丄上丏;
        mem[1152921537360163264] = 丂一丏丙下丝丘丆丗;
        mem[1152921537360163272] = 一丗与与丌七丆丂不;
        if(专三世丆丏万丄上丏 != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        int val_2 = 专三世丆丏万丄上丏.Price;
        val_10 = null;
        val_10 = null;
        val_11 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        val_12 = null;
        val_12 = null;
        val_14 = JoinToFriendRoomController.<>c.<>9__48_1;
        if(val_14 == null)
        {
                System.Action val_9 = null;
            val_14 = val_9;
            val_9 = new System.Action(object:  JoinToFriendRoomController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void JoinToFriendRoomController.<>c::丘下丐丁丈不丐丌上());
            JoinToFriendRoomController.<>c.<>9__48_1 = val_14;
        }
        
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.transform.root.gameObject, 丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  .专三世丆丏万丄上丏.Price, 丏丂不专上丘丂不丅:  val_11), 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void JoinToFriendRoomController.丝业丞丕丟万万丝丙::世丄下丄丁丟上不丗()), 丝丏丗丄丗与丐丌三:  val_9, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  82);
        return;
        label_1:
        mem[16] = 丂一丏丙下丝丘丆丗;
        mem[24] = 一丗与与丌七丆丂不;
        mem[32] = 专三世丆丏万丄上丏;
        if(mem[32] != 0)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    public JoinToFriendRoomController()
    {
    
    }
    private void 丌丅万丆丗丅丈丛东()
    {
        this.且业上上丂丁专丝丞(丙七一丒丛丈丁丏专:  this.inputPasswordLabel.value);
    }

}
