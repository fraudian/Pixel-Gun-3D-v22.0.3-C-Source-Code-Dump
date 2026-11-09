using UnityEngine;
public class CustomPanelConnectScene : MonoBehaviour
{
    // Fields
    private static CustomPanelConnectScene 丝业丆丁业三丈丟东;
    public UnityEngine.GameObject customPanel;
    public SetHeadLabelText headCustomPanel;
    public UIScrollView scrollGames;
    public UIGrid gridGames;
    public UISprite fonGames;
    public UnityEngine.Transform gridGamesTransform;
    public DisableObjectFromTimer gameIsfullLabel;
    public DisableObjectFromTimer incorrectPasswordLabel;
    public UnityEngine.GameObject gameInfoItemPrefab;
    public UnityEngine.GameObject showSearchPanelBtn;
    public UnityEngine.GameObject chooseMapLabelSmall;
    public UnityEngine.GameObject connectToWiFIInCustomLabel;
    public UnityEngine.GameObject createRoomBtn;
    public UIButton createRoomUIBtn;
    public UnityEngine.GameObject customizeBtn;
    public UIButton customizeUIBtn;
    public UnityEngine.GameObject createCustomRoomBtn;
    public UIButton createCustomRoomUIBtn;
    public UnityEngine.GameObject sharedBackButton;
    public UnityEngine.GameObject createPanel;
    public UIInput nameServerInput;
    public UIInput setPasswordInput;
    public DisableObjectFromTimer nameAlreadyUsedLabel;
    public UnityEngine.GameObject goToCreateRoomBtn;
    public UnityEngine.GameObject connectToWiFIInCreateLabel;
    public UnityEngine.GameObject tryCreateRoomAgain;
    public UnityEngine.GameObject searchPanel;
    public UIInput searchInput;
    public UnityEngine.GameObject searchBtn;
    public UnityEngine.GameObject enterPasswordPanel;
    public UIInput enterPasswordInput;
    public UnityEngine.GameObject joinRoomFromEnterPasswordBtn;
    public UnityEngine.GameObject enterPasswordCustomPanel;
    public UIInput enterPasswordCustomInput;
    public UnityEngine.GameObject joinCustomRoomFromEnterPasswordBtn;
    public UnityEngine.GameObject customizePanel;
    private bool 丈与万不丗东业下下;
    private bool 丄东丑与丕东七丆丈;
    private UnityEngine.Vector3 丏丘丞丆与丕三丝丘;
    private string 东丅丒丛丏丄丒丞专;
    private string 丁丆上丁业丈丙丈东;
    private 丞丘丒一上与丕丒且 一世东丄丗丆丘丛丂;
    private readonly System.Collections.Generic.List<丞丘丒一上与丕丒且> 丑丐丅丟下丞三丛且;
    public System.Collections.Generic.List<UnityEngine.GameObject> gamesInfo;
    private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 下丒丏丙一不七丕丏;
    private string 上下丟七丗业丁丒丕;
    private MapPreviewController 丑业业业丒丏丈丞下;
    private System.IDisposable 丟七丕丙三丂七万丟;
    private int 丄丈丟丙不世与丅丈;
    private int 丕专丗万上丁世丝丁;
    private float 丒丙丘丟且丈丗且丞;
    private float 丏丝丕丈丑丙丄丁业;
    private float 丐与丒丐七丙丌三不;
    private bool 上丐丐丆丝丕丟一丁;
    private float 七与丌三丙丈丅丕丕;
    private UnityEngine.Vector3 丙一不且丑丆丆丂丆;
    
    // Properties
    internal static CustomPanelConnectScene 丆丕丝丒不丙且丐丗 { get; }
    private ConnectSceneSelectMap 万丒专丐专丏丐丄丑 { get; }
    private string 七七丙不丞丕丘世与 { get; }
    
    // Methods
    internal static CustomPanelConnectScene 丑七不且上丗丁一世()
    {
        var val_22;
        UnityEngine.Transform val_23;
        CustomPanelConnectScene val_24;
        var val_25;
        UnityEngine.GameObject val_26;
        var val_27;
        var val_28;
        var val_30;
        val_22 = null;
        val_22 = null;
        val_23 = 1152921504848912384;
        val_24 = CustomPanelConnectScene.丝业丆丁业三丈丟东;
        if(val_24 == 0)
        {
                val_25 = static_value_081DACA8;
            val_25 = static_value_081DACA8;
            val_24 = mem[static_value_081DACA8 + 184 + 16];
            val_24 = static_value_081DACA8 + 184 + 16;
            if(val_24 != 0)
        {
                UnityEngine.Object val_3 = UnityEngine.Resources.Load(path:  "ConnectScene/CustomPanelConnectScene");
            if(val_3 != null)
        {
                val_3 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_26 = 0;
        }
        
            val_27 = null;
            val_27 = null;
            CustomPanelConnectScene.丝业丆丁业三丈丟东 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_26).GetComponent<CustomPanelConnectScene>();
            val_28 = static_value_081DACA8;
            val_28 = static_value_081DACA8;
            CustomPanelConnectScene.丝业丆丁业三丈丟东.transform.parent = static_value_081DACA8 + 184 + 16.transform.GetChild(index:  0);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            CustomPanelConnectScene.丝业丆丁业三丈丟东.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            CustomPanelConnectScene.丝业丆丁业三丈丟东.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  (null == null) ? UnityEngine.Resources.Load(path:  "ConnectScene/BackgroundConnectScene") : 0);
            val_23 = CustomPanelConnectScene.丝业丆丁业三丈丟东.transform;
            val_15.transform.parent = val_23;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            val_15.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            val_24 = val_15.transform;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
            val_24.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        }
        
        }
        
        val_30 = null;
        val_30 = null;
        return (CustomPanelConnectScene)CustomPanelConnectScene.丝业丆丁业三丈丟东;
    }
    private ConnectSceneSelectMap 丝三丅丙且上丅丂丏()
    {
        return ConnectSceneSelectMap.丑七不且上丗丁一世();
    }
    internal void 七丝丕丂丑丌丟万不(MapPreviewController 丞丁丑丏丄丏七丂不)
    {
        this.丑业业业丒丏丈丞下 = 丞丁丑丏丄丏七丂不;
    }
    internal void 丘丁丛丟丟东七东上()
    {
        this.incorrectPasswordLabel.timer = 3f;
        this.incorrectPasswordLabel.gameObject.SetActive(value:  true);
        var val_6 = 0;
        do
        {
            if(val_6 >= val_2.Length)
        {
                return;
        }
        
            T val_5 = this.incorrectPasswordLabel.GetComponents<I2.Loc.Localize>()[0];
            val_6 = val_6 + 1;
        }
        while((System.String.op_Equality(a:  val_5.Term, b:  "Key_0142")) == false);
        
        val_5.SetTerm(丂专丟专丕丈丘丘丌:  "Key_3482", 丟丛不丞丞丏丏丁丕:  "Key_3482");
    }
    internal void 丑专业丅三丈丏下丝(bool 丙业与丙丗丝不丈东)
    {
        DisableObjectFromTimer val_6;
        var val_7;
        var val_8;
        val_6 = this.incorrectPasswordLabel;
        if(val_6 == null)
        {
            goto label_1;
        }
        
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_2;
        }
        
        label_13:
        var val_6 = 0;
        label_7:
        if(val_6 >= val_1.Length)
        {
            goto label_4;
        }
        
        val_6 = val_6.GetComponents<I2.Loc.Localize>()[0];
        val_6 = val_6 + 1;
        if((System.String.op_Equality(a:  val_6.Term, b:  "Key_3482")) == false)
        {
            goto label_7;
        }
        
        val_6.SetTerm(丂专丟专丕丈丘丘丌:  "Key_0142", 丟丛不丞丞丏丏丁丕:  "Key_0142");
        label_4:
        this.incorrectPasswordLabel.timer = 3f;
        val_7 = this.incorrectPasswordLabel.gameObject;
        val_8 = 1;
        goto label_12;
        label_1:
        if(丙业与丙丗丝不丈东 == true)
        {
            goto label_13;
        }
        
        label_2:
        this.incorrectPasswordLabel.timer = -1f;
        val_7 = this.incorrectPasswordLabel.gameObject;
        val_8 = 0;
        label_12:
        val_7.SetActive(value:  false);
    }
    private void OnDisable()
    {
        var val_4;
        System.Action val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丐丗丈下三与丝丙业, value:  new System.Action(object:  this, method:  System.Void CustomPanelConnectScene::OnReceivedRoomListUpdate()))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_5;
    }
    private void OnEnable()
    {
        var val_8;
        System.Action val_9;
        if(GameConnect.丑丌丛丈丅丅与不业() == 9)
        {
                this.searchPanel.gameObject.SetActive(value:  false);
            this.createPanel.gameObject.SetActive(value:  false);
            this.customPanel.gameObject.SetActive(value:  false);
        }
        
        this.SetRandomRoomName();
        val_8 = null;
        val_8 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丐丗丈下三与丝丙业, b:  new System.Action(object:  this, method:  System.Void CustomPanelConnectScene::OnReceivedRoomListUpdate()))) != null) && (null != null))
        {
                val_9 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_9;
    }
    private void OnReceivedRoomListUpdate()
    {
        var val_3;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_1.customPanel.activeSelf == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
    }
    public void SetRandomRoomName()
    {
        this.nameServerInput.value = "Room#" + UnityEngine.Random.Range(min:  0, max:  1000000).ToString(format:  "000000")(UnityEngine.Random.Range(min:  0, max:  1000000).ToString(format:  "000000"));
    }
    public void CopyRoomNameAndPassword()
    {
        UIInput val_11;
        string val_12;
        if(this.nameServerInput.value == null)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Char>(丑东与丅丐丅丂丞业:  this.nameServerInput.value)) != false)
        {
                return;
        }
        
        val_11 = this.setPasswordInput;
        val_12 = this.nameServerInput.value;
        if(val_11.value != null)
        {
                val_11 = this.setPasswordInput.value;
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Char>(丑东与丅丐丅丂丞业:  val_11)) != true)
        {
                val_12 = val_12 + " pass:"(" pass:") + this.setPasswordInput.value;
        }
        
        }
        
        string val_10 = "Copying [" + val_12 + "]";
        UnityEngine.Debug.LogError(message:  val_10);
        val_10.下三丐丅丟丈丂业丑();
        UnityEngine.GUIUtility.systemCopyBuffer = val_12;
    }
    private void 下三丐丅丟丈丂业丑()
    {
        string val_1 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11124");
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true) ? "#Копировано в буфер" : (val_1));
    }
    private void Update()
    {
        var val_18;
        var val_19;
        var val_20;
        val_18 = this;
        val_19 = null;
        val_19 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                if(this.connectToWiFIInCreateLabel.activeSelf != false)
        {
                this.connectToWiFIInCreateLabel.SetActive(value:  false);
        }
        
            if(this.connectToWiFIInCreateLabel.activeSelf == false)
        {
                return;
        }
        
            this.connectToWiFIInCustomLabel.SetActive(value:  false);
            return;
        }
        
        CustomPanelConnectScene val_3 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_3.customPanel.activeSelf != false)
        {
                if(this.丈与万不丗东业下下 != false)
        {
                val_20 = static_value_081DACA8;
            val_20 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.UpdateLocalServersList();
        }
        else
        {
                this.丈与万不丗东业下下 = true;
        }
        
        }
        
        this.connectToWiFIInCreateLabel.SetActive(value:  (UnityEngine.Application.internetReachability != 2) ? 1 : 0);
        this.connectToWiFIInCustomLabel.SetActive(value:  (UnityEngine.Application.internetReachability != 2) ? 1 : 0);
        var val_10 = (UnityEngine.Application.internetReachability == 2) ? 1 : 0;
        val_10 = this.createRoomUIBtn ^ val_10;
        if((val_10 & 1) == 0)
        {
                return;
        }
        
        val_18 = ???;
        var val_12 = (UnityEngine.Application.internetReachability == 2) ? 1 : 0;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private bool 丒七不丁丙三世丆万()
    {
        return (bool)(UnityEngine.Application.internetReachability == 2) ? 1 : 0;
    }
    private void 下丐丅丑丘专丑丈丑()
    {
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        this.东丅丒丛丏丄丒丞专 = val_1.setPasswordInput.value;
    }
    internal static bool 丌丌一丅丂丐不丆丛(丞丘丒一上与丕丒且 东七上世万下丗丄丛)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 东七上世万下丗丄丛;
        val_6 = null;
        val_6 = null;
        if(val_5.丑丗三丛丛丆丟丌丆().Item[GameConnect.不丕丂三丙与丈且三] != null)
        {
                val_7 = null;
            val_5 = val_5.丑丗三丛丛丆丟丌丆();
            val_7 = null;
            if(val_5.Item[GameConnect.不丕丂三丙与丈且三] != "")
        {
                val_8 = 1;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public void JoinToRoomPhoton(丞丘丒一上与丕丒且 世东丈丙丘下丝丌三)
    {
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        if(世东丈丙丘下丝丌三 != null)
        {
                val_38 = 世东丈丙丘下丝丌三.丞丙上丝世且且世丒();
        }
        else
        {
                val_38 = 0.丞丙上丝世且且世丒();
        }
        
        if(val_38 == 世东丈丙丘下丝丌三.丕丏业且丒丂上七下())
        {
                CustomPanelConnectScene val_4 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_4.gameIsfullLabel.timer = 3f;
            CustomPanelConnectScene val_5 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_5.gameIsfullLabel.gameObject.SetActive(value:  true);
            CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
            return;
        }
        
        this.一世东丄丗丆丘丛丂 = 世东丈丙丘下丝丌三;
        if((CustomPanelConnectScene.丌丌一丅丂丐不丆丛(东七上世万下丗丄丛:  世东丈丙丘下丝丌三)) == false)
        {
            goto label_14;
        }
        
        val_39 = null;
        val_39 = null;
        object val_10 = this.一世东丄丗丆丘丛丂.丑丗三丛丛丆丟丌丆().Item[GameConnect.不丕丂三丙与丈且三];
        UnityEngine.Debug.LogError(message:  val_10);
        System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> val_11 = PGCompany.GameModeEvents.下丑一丈与丝与丐丛.丝与业丘丌业丄东万(丏丛与丅丛丌万专丌:  val_10);
        val_40 = 0;
        goto label_24;
        label_32:
        UnityEngine.Debug.LogError(message:  val_11.Item[0].丆丂丙丞一丛丞丄丘() + " is icon, description: "(" is icon, description: ") + val_11.Item[0].东且丏丆万与东丙万());
        val_40 = 1;
        label_24:
        if(val_40 < val_11.Count)
        {
            goto label_32;
        }
        
        label_14:
        val_41 = null;
        val_41 = null;
        if((System.String.Equals(a:  世东丈丙丘下丝丌三.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七], b:  GameConnect.丂万且丟丛丈与丞丏)) != false)
        {
                this.JoinToRoomPhotonAfterCheck();
            return;
        }
        
        CustomPanelConnectScene val_21 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_21.gameIsfullLabel.timer = -1f;
        CustomPanelConnectScene val_22 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_22.gameIsfullLabel.gameObject.SetActive(value:  false);
        CustomPanelConnectScene val_24 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_24.enterPasswordInput.value = System.String.alignConst;
        CustomPanelConnectScene val_25 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_25.enterPasswordCustomInput.value = System.String.alignConst;
        if((CustomPanelConnectScene.丌丌一丅丂丐不丆丛(东七上世万下丗丄丛:  世东丈丙丘下丝丌三)) == false)
        {
            goto label_50;
        }
        
        CustomPanelConnectScene val_27 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_27.enterPasswordCustomPanel.SetActive(value:  true);
        CustomPanelConnectScene val_28 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_28.enterPasswordPanel.SetActive(value:  false);
        CustomPanelConnectScene val_29 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_29.enterPasswordCustomPanel.GetComponent<JoinPrivateGameInfoWindow>().ReadRoomNextFrame(东七上世万下丗丄丛:  世东丈丙丘下丝丌三);
        CustomPanelConnectScene val_31 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_31.enterPasswordCustomInput.isSelected = false;
        CustomPanelConnectScene val_32 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_32.enterPasswordCustomInput != null)
        {
            goto label_77;
        }
        
        label_78:
        label_77:
        val_32.enterPasswordCustomInput.isSelected = true;
        CustomPanelConnectScene val_33 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_33.customPanel.SetActive(value:  false);
        return;
        label_50:
        CustomPanelConnectScene val_34 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_34.enterPasswordPanel.SetActive(value:  true);
        CustomPanelConnectScene val_35 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_35.enterPasswordCustomPanel.SetActive(value:  false);
        CustomPanelConnectScene val_36 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_36.enterPasswordInput.isSelected = false;
        CustomPanelConnectScene val_37 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_37.enterPasswordInput != null)
        {
            goto label_77;
        }
        
        goto label_78;
    }
    private void 丐丛丈丅丌一丌丑丝()
    {
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.enterPasswordInput.RemoveFocus();
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_2.enterPasswordInput.isSelected = false;
        this.Invoke(methodName:  "EnterPassInput", time:  0.1f);
    }
    public void JoinToRoomPhotonAfterCheck()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_10 = static_value_081DACA8;
        val_10 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丏丑不七丕丄丅东丆(七丆丂丂下丈且丟世:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  this.一世东丄丗丆丘丛丂.丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆])).丙且上丒不下丑下丞());
        static_value_081DACA8 + 184 + 16 + 152.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  2849");
        bool val_7 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  this.一世东丄丗丆丘丛丂.东丙上东业丆不丟丘());
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
    }
    private bool 七丛丛丁丕丄丕丅东(int 丒三东丆丕专丞且一, bool 东一业丝丁专丄下东 = False, bool 且丈三且七上一丏丞 = False)
    {
        var val_5 = null;
        return UnityEngine.Object.op_Inequality(x:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丐丝丟丙丛下专丐万:  (且丈三且七上一丏丞 != true) ? 16 : ((东一业丝丁专丄下东 != true) ? 8 : PGCompany.GameModeHub.丙丙与东一丐丂丐上.丐丐丟三丑丁东丐丕()), 丈东丅万丟丞丒不丒:  丒三东丆丕专丞且一), y:  0);
    }
    private string 七丈丌三丘丕丈丈丏()
    {
        var val_2;
        if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() == false)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        val_2 = "/Hi";
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    internal UnityEngine.Texture 丂丐业丘丑丒三万丒(string 七丆丂丂下丈且丟世)
    {
        var val_7;
        bool val_1 = this.下丒丏丙一不七丕丏.ContainsKey(key:  七丆丂丂下丈且丟世);
        if(val_1 != false)
        {
                val_7 = this.下丒丏丙一不七丕丏.Item[七丆丂丂下丈且丟世];
            return (UnityEngine.Texture);
        }
        
        UnityEngine.Object val_5 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Loading_{1}", arg0:  val_1.七丈丌三丘丕丈丈丏(), arg1:  七丆丂丂下丈且丟世));
        val_7 = 0;
        if( == 0)
        {
                return (UnityEngine.Texture);
        }
        
        this.下丒丏丙一不七丕丏.Add(key:  七丆丂丂下丈且丟世, value:  null);
        return (UnityEngine.Texture);
    }
    private void 丆丝丁东丆与上上不(GameInfo 专专丂丝且万丂不世, int 丞世不丒下上上丝丑)
    {
        丞丘丒一上与丕丒且 val_27;
        string val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        专专丂丝且万丂不世.index = 丞世不丒下上上丝丑;
        UnityEngine.GameObject val_2 = 专专丂丝且万丂不世.gameObject;
        if(this.丑丐丅丟下丞三丛且.Count <= 丞世不丒下上上丝丑)
        {
            goto label_3;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
        val_27 = this.丑丐丅丟下丞三丛且.Item[丞世不丒下上上丝丑];
        val_28 = val_27.东丙上东业丆不丟丘();
        if((val_28.Length == 36) && ((val_28.IndexOf(value:  "-")) == 8))
        {
                if((val_28.LastIndexOf(value:  "-")) == 23)
        {
                val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0088");
        }
        
        }
        
        专专丂丝且万丂不世.serverNameLabel.text = val_28;
        专专丂丝且万丂不世.countPlayersLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  val_27.丞丙上丝世且且世丒(), arg1:  val_27.丕丏业且丒丂上七下());
        val_29 = null;
        val_29 = null;
        string val_27 = GameConnect.丂万且丟丛丈与丞丏;
        bool val_14 = System.String.Equals(a:  val_27.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七], b:  val_27);
        val_27 = val_14;
        专专丂丝且万丂不世.openSprite.SetActive(value:  val_27);
        专专丂丝且万丂不世.closeSprite.SetActive(value:  (~val_14) & 1);
        val_30 = null;
        val_30 = null;
        SceneInfo val_19 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  val_27.丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]));
        专专丂丝且万丂不世.mapNameLabel.SetText(丕丗丘丑丛与丑业丒:  val_19.七丛一丛专七丈丅专());
        专专丂丝且万丂不世.roomInfo = val_27;
        UnityEngine.Texture val_22 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_19.丙且上丒不下丑下丞());
        专专丂丝且万丂不世.丏丛与业丆丝世丒丗(万丁世丗丒丐丙丄丆:  val_19);
        专专丂丝且万丂不世.SetCustomizedIconVision(三丟东丕丄丄下下丑:  false);
        if(val_27.丑丗三丛丛丆丟丌丆().Item[GameConnect.不丕丂三丙与丈且三] == null)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        val_27 = GameConnect.不丕丂三丙与丈且三;
        if(val_27.丑丗三丛丛丆丟丌丆().Item[val_27] == "")
        {
            goto label_44;
        }
        
        val_32 = 1;
        goto label_45;
        label_3:
        val_2.SetActive(value:  false);
        return;
        label_44:
        val_32 = 0;
        label_45:
        专专丂丝且万丂不世.SetCustomizedIconVision(三丟东丕丄丄下下丑:  false);
    }
    private void 丘丒丛丙丏丟世不丘(string 丞丘与万丞三丁丘丙)
    {
        var val_104;
        var val_105;
        var val_107;
        var val_108;
        var val_109;
        var val_110;
        var val_111;
        int val_112;
        var val_113;
        var val_114;
        int val_115;
        var val_116;
        float val_117;
        var val_118;
        float val_119;
        this.丑丐丅丟下丞三丛且.Clear();
        丞丘丒一上与丕丒且[] val_1 = 丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑();
        bool val_2 = System.String.IsNullOrEmpty(value:  丞丘与万丞三丁丘丙);
        val_104 = 0;
        goto label_4;
        label_86:
        if(val_2 == false)
        {
            goto label_5;
        }
        
        if(val_1[0].三不万不丕丑一上与() == (val_1[0x0] + 32.丄丁丗丞丏丞世丕业()))
        {
            goto label_72;
        }
        
        label_5:
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
            goto label_13;
        }
        
        val_105 = null;
        val_105 = null;
        if((System.String.IsNullOrEmpty(value:  (null == null) ? val_1[0].丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七] : 0)) == true)
        {
            goto label_72;
        }
        
        label_13:
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
            goto label_37;
        }
        
        val_107 = null;
        val_107 = null;
        if(val_1[0].丑丗三丛丛丆丟丌丆().Item[GameConnect.万与丅且专丕丐丑且] == null)
        {
            goto label_37;
        }
        
        val_108 = null;
        val_108 = null;
        if((val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且].Equals(value:  GameConnect.丅丕专丗东东丏专世.ToString())) == true)
        {
            goto label_37;
        }
        
        val_109 = null;
        val_109 = null;
        if((val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且].Equals(value:  3.ToString())) == false)
        {
            goto label_72;
        }
        
        label_37:
        if(val_2 == false)
        {
            goto label_46;
        }
        
        label_84:
        val_110 = null;
        val_110 = null;
        if((val_1[0].丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆].七丛丛丁丕丄丕丅东(丒三东丆丕专丞且一:  21884928, 东一业丝丁专丄下东:  (GameConnect.丑丌丛丈丅丅与不业() == 8) ? 1 : 0, 且丈三且七上一丏丞:  (GameConnect.丑丌丛丈丅丅与不业() == 16) ? 1 : 0)) == false)
        {
            goto label_72;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_55;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_72;
        }
        
        val_111 = null;
        val_111 = null;
        if((System.String.IsNullOrEmpty(value:  val_1[0x0] + 32.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七])) == true)
        {
            goto label_72;
        }
        
        label_55:
        this.丑丐丅丟下丞三丛且.Add(item:  val_1[0x0] + 32);
        goto label_72;
        label_46:
        if((val_1[0].东丙上东业丆不丟丘().Contains(value:  丞丘与万丞三丁丘丙)) != false)
        {
                if((((val_1[0x0] + 32.东丙上东业丆不丟丘().Length) != 36) || ((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().IndexOf(value:  "-")) != 8)) || ((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().LastIndexOf(value:  "-")) != 23))
        {
            goto label_84;
        }
        
        }
        
        label_72:
        val_104 = 1;
        label_4:
        if(val_104 < val_1.Length)
        {
            goto label_86;
        }
        
        if(this.丄丈丟丙不世与丅丈 >= 11)
        {
                this.丄丈丟丙不世与丅丈 = 1;
        }
        
        this.丄丈丟丙不世与丅丈 = 50;
        val_112 = this.丄丈丟丙不世与丅丈;
        if(this.丑丐丅丟下丞三丛且.Count >= val_112)
        {
            goto label_91;
        }
        
        val_112 = this.丑丐丅丟下丞三丛且.Count;
        this.丄丈丟丙不世与丅丈 = val_112;
        goto label_91;
        label_102:
        if(this.gamesInfo != null)
        {
                val_113 = this.gamesInfo.Count;
        }
        else
        {
                val_113 = 0.Count;
        }
        
        UnityEngine.GameObject val_46 = this.gamesInfo.Item[val_113 - 1];
        if(val_46 != 0)
        {
                UnityEngine.Object.Destroy(obj:  val_46);
        }
        
        if(this.gamesInfo != null)
        {
                val_114 = this.gamesInfo.Count;
        }
        else
        {
                val_114 = 0.Count;
        }
        
        this.gamesInfo.RemoveAt(index:  val_114 - 1);
        val_112 = this.丄丈丟丙不世与丅丈;
        label_91:
        if(val_112 < this.gamesInfo.Count)
        {
            goto label_102;
        }
        
        val_115 = this.丄丈丟丙不世与丅丈;
        val_116 = public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::get_Count();
        if(val_115 <= this.gamesInfo.Count)
        {
            goto label_104;
        }
        
        float val_109 = (float)UnityEngine.Screen.width;
        val_109 = val_109 / (float)UnityEngine.Screen.height;
        this.丕专丗万上丁世丝丁 = (val_109 < 0) ? 3 : 4;
        val_104 = 1152921505055887360;
        CustomPanelConnectScene val_56 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_57 = val_56.fonGames.localSize;
        int val_58 = this.丕专丗万上丁世丝丁 + (this.丕专丗万上丁世丝丁 << 2);
        val_58 = val_58 << 1;
        val_57.x = val_57.x - (float)val_58;
        val_117 = (float)this.丕专丗万上丁世丝丁;
        val_57.x = val_57.x / val_117;
        this.丒丙丘丟且丈丗且丞 = val_57.x;
        if(this.丄丈丟丙不世与丅丈 <= this.gamesInfo.Count)
        {
            goto label_110;
        }
        
        CustomPanelConnectScene val_60 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_118 = 1;
        goto label_115;
        label_140:
        CustomPanelConnectScene val_61 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.GameObject val_62 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_61.gameInfoItemPrefab);
        string val_64 = "GameInfo_" + this.gamesInfo.Count;
        if(val_62 != null)
        {
                val_62.name = val_64;
        }
        else
        {
                0.name = val_64;
        }
        
        CustomPanelConnectScene val_66 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_62.transform.SetParent(parent:  val_66.gridGamesTransform, worldPositionStays:  false);
        GameInfo val_67 = val_62.GetComponent<GameInfo>();
        UnityEngine.Vector2 val_68 = val_67.mapTexture.localSize;
        val_68.x = this.丒丙丘丟且丈丗且丞 / val_68.x;
        this.丐与丒丐七丙丌三不 = val_68.x;
        GameInfo val_69 = val_62.GetComponent<GameInfo>();
        UnityEngine.Vector2 val_70 = val_69.mapTexture.localSize;
        float val_110 = this.丐与丒丐七丙丌三不;
        val_110 = val_70.y * val_110;
        this.丏丝丕丈丑丙丄丁业 = val_110;
        val_117 = 0f;
        val_62.transform.GetChild(index:  0).transform.localScale = new UnityEngine.Vector3() {x = 0f, y = val_117, z = 0f};
        this.gamesInfo.Add(item:  val_62);
        CustomPanelConnectScene val_74 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_118 = 0;
        label_115:
        val_74.gameInfoItemPrefab.SetActive(value:  false);
        label_110:
        if(this.丄丈丟丙不世与丅丈 > this.gamesInfo.Count)
        {
            goto label_140;
        }
        
        CustomPanelConnectScene val_76 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_76.gameInfoItemPrefab.activeSelf != false)
        {
                CustomPanelConnectScene val_78 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_78.gameInfoItemPrefab.SetActive(value:  false);
        }
        
        CustomPanelConnectScene val_79 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_116 = public UIGrid UnityEngine.Component::GetComponent<UIGrid>();
        if((val_79.gridGames.GetComponent<UIGrid>()) != null)
        {
                val_80.cellWidth = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
            float val_111 = this.丏丝丕丈丑丙丄丁业;
            val_117 = this.七与丌三丙丈丅丕丕;
            val_111 = val_111 + val_117;
            val_80.cellHeight = val_111;
            val_115 = this.丕专丗万上丁世丝丁;
        }
        else
        {
                mem[40] = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
            val_80.cellHeight = this.丏丝丕丈丑丙丄丁业 + this.七与丌三丙丈丅丕丕;
            val_115 = this.丕专丗万上丁世丝丁;
        }
        
        val_80.maxPerLine = val_115;
        label_104:
        CustomPanelConnectScene val_84 = CustomPanelConnectScene.丑七不且上丗丁一世();
        CustomPanelConnectScene val_86 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_88 = val_86.scrollGames.GetComponent<UIPanel>().GetViewSize();
        CustomPanelConnectScene val_89 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_119 = val_117 + val_117;
        if(val_119 >= 0)
        {
                if(this.上丐丐丆丝丕丟一丁 == true)
        {
            goto label_166;
        }
        
        }
        
        CustomPanelConnectScene val_90 = CustomPanelConnectScene.丑七不且上丗丁一世();
        CustomPanelConnectScene val_92 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_94 = val_92.gridGames.transform.localPosition;
        val_119 = val_94.y;
        CustomPanelConnectScene val_95 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_115 = val_95.gridGames.transform;
        UnityEngine.Vector3 val_97 = val_115.localPosition;
        float val_112 = (float)this.丕专丗万上丁世丝丁;
        val_112 = val_112 * 0.5f;
        float val_98 = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
        val_112 = val_112 + (-0.5f);
        val_98 = -(val_98 * val_112);
        val_90.gridGames.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        CustomPanelConnectScene val_99 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_99.scrollGames.ResetPosition();
        this.上丐丐丆丝丕丟一丁 = true;
        label_166:
        if(this.丄丈丟丙不世与丅丈 >= 1)
        {
                var val_113 = 0;
            do
        {
            val_115 = this.gamesInfo.Item[0];
            this.丆丝丁东丆与上上不(专专丂丝且万丂不世:  val_115.GetComponent<GameInfo>(), 丞世不丒下上上丝丑:  0);
            val_113 = val_113 + 1;
        }
        while(val_113 < this.丄丈丟丙不世与丅丈);
        
        }
        
        CustomPanelConnectScene val_102 = CustomPanelConnectScene.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_102.scrollGames, 丏业丟一东丂东丘丛:  false);
        CustomPanelConnectScene val_103 = CustomPanelConnectScene.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_103.scrollGames, 丏业丟一东丂东丘丛:  true);
    }
    internal void UpdateFilteredRoomListInvoke()
    {
        this.丘丒丛丙丏丟世不丘(丞丘与万丞三丁丘丙:  this.丁丆上丁业丈丙丈东);
    }
    public void HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_17 = null;
        val_17 = null;
        val_18 = this.一世东丄丗丆丘丛丂.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七];
        if((val_1.enterPasswordInput.value.Equals(value:  val_18)) == true)
        {
            goto label_11;
        }
        
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19 = null;
        val_19 = null;
        val_18 = this.一世东丄丗丆丘丛丂.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七];
        if((val_6.enterPasswordCustomInput.value.Equals(value:  val_18)) == false)
        {
            goto label_22;
        }
        
        label_11:
        this.JoinToRoomPhotonAfterCheck();
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
        return;
        label_22:
        CustomPanelConnectScene val_12 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_12.enterPasswordPanel.SetActive(value:  false);
        CustomPanelConnectScene val_13 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_13.enterPasswordCustomPanel.SetActive(value:  false);
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  true);
        val_20 = null;
        val_20 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_21 = null;
            val_21 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        CustomPanelConnectScene val_16 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_16.customPanel.SetActive(value:  true);
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
    }
    private void EnterPassInput()
    {
        this.HandleJoinRoomFromEnterPasswordBtnClicked(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 上下丙专丌下丄丈丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.customPanel.SetActive(value:  false);
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_2.searchInput != 0)
        {
                CustomPanelConnectScene val_4 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_4.searchInput.value = this.丁丆上丁业丈丙丈东;
        }
        
        CustomPanelConnectScene val_5 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_5.searchPanel.SetActive(value:  true);
    }
    private void 上一丝三丗且丆下丟()
    {
        var val_10;
        ConnectSceneSelectMap val_1 = this.丝三丅丙且上丅丂丏();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.customButtonsContainer, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Transform val_3 = val_1.customButtonsContainer.丝三丅丙且上丅丂丏().transform;
        UnityEngine.Vector3 val_4 = val_3.localPosition;
        this.丙一不且丑丆丆丂丆 = val_4;
        mem[1152921525869829520] = val_4.y;
        mem[1152921525869829524] = val_4.z;
        val_10 = val_3.丝三丅丙且上丅丂丏().transform;
        val_10.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        bool val_7 = GameConnect.东且三丆丑世世丘丟();
        if(val_7 == false)
        {
                return;
        }
        
        val_10 = val_7.丝三丅丙且上丅丂丏().transform;
        val_10.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 且上不丘丘丏且丌丙(Rilisoft.七丕丟丏三丈一丄世 业丞丟万不丄丂丘丑, int 丌丝万上丅丒一丈丘, SceneInfo 丄不东丁丂丅万丒丟, bool 丗丂世丗丄不丟丘万, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        ConnectSceneSelectMap val_1 = this.丝三丅丙且上丅丂丏();
        UnityEngine.GameObject val_4 = val_1.grid.transform.GetChild(index:  丌丝万上丅丒一丈丘).gameObject;
        if(val_4.activeSelf != true)
        {
                val_4.SetActive(value:  true);
        }
        
        val_4.GetComponent<MapPreviewController>().上东与丛丞下丈专丈(业丞丟万不丄丂丘丑:  业丞丟万不丄丂丘丑, 丄不东丁丂丅万丒丟:  丄不东丁丂丅万丒丟, 丗丂世丗丄不丟丘万:  丗丂世丗丄不丟丘万, 专且丆东且丁丂丝上:  丐且丘丑与万丞丑丅, 丈三丆丏丄三丏丛丒:  false);
    }
    private System.Collections.IEnumerator 丛业万丕三丌丑万上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CustomPanelConnectScene.丄丛丛上丄丛丆丙丘();
    }
    private void 上上丂东不丐丈丌丞()
    {
        CustomPanelConnectScene val_63;
        var val_64;
        var val_65;
        System.Collections.Generic.List<SceneInfo> val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        float val_71;
        var val_72;
        float val_73;
        float val_74;
        int val_75;
        float val_76;
        int val_77;
        UnityEngine.GameObject val_78;
        var val_79;
        val_63 = this;
        val_64 = null;
        val_64 = null;
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_9;
        }
        
        val_65 = null;
        val_65 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  PGCompany.GameModeHub.丙丙与东一丐丂丐上.丐丐丟三丑丁东丐丕())) == null)
        {
            goto label_9;
        }
        
        val_66 = val_3.avaliableScenes;
        if(val_66 != null)
        {
            goto label_10;
        }
        
        label_9:
        System.Collections.Generic.List<SceneInfo> val_4 = null;
        val_66 = val_4;
        val_4 = new System.Collections.Generic.List<SceneInfo>();
        if(val_66 == null)
        {
            goto label_11;
        }
        
        label_10:
        val_67 = 0;
        goto label_12;
        label_11:
        val_67 = 1;
        label_12:
        val_68 = 1152921525776312064;
        int val_5 = val_4.Count;
        val_69 = val_5;
        ConnectSceneSelectMap val_6 = val_5.丝三丅丙且上丅丂丏();
        val_70 = val_6.grid.transform;
        if(val_70.childCount >= val_69)
        {
            goto label_16;
        }
        
        val_71 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
        if(val_71 < 0)
        {
                val_72 = 3;
        }
        else
        {
                int val_12 = UnityEngine.Screen.height;
            float val_64 = (float)UnityEngine.Screen.width;
            val_64 = val_64 / (float)val_12;
            val_71 = (double)val_64;
            if(val_71 < 0)
        {
                val_72 = 4;
        }
        else
        {
                val_72 = 5;
        }
        
        }
        
        ConnectSceneSelectMap val_13 = val_12.丝三丅丙且上丅丂丏();
        UnityEngine.Vector2 val_14 = val_13.fonMapPreviewPrivate.localSize;
        float val_65 = val_14.x;
        ConnectSceneSelectMap val_15 = val_13.fonMapPreviewPrivate.丝三丅丙且上丅丂丏();
        val_73 = -15f;
        float val_16 = 5f * val_73;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15.mapPreviewTexture, 丏业丟一东丂东丘丛:  true);
        ConnectSceneSelectMap val_17 = val_15.mapPreviewTexture.丝三丅丙且上丅丂丏();
        val_65 = val_65 + val_16;
        val_65 = val_65 + val_73;
        val_16 = val_65 / 5f;
        val_74 = 1f;
        val_75 = val_17.grid.transform.childCount;
        val_76 = val_74;
        goto label_29;
        label_48:
        UnityEngine.GameObject val_21 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this);
        UnityEngine.Transform val_22 = val_21.transform;
        ConnectSceneSelectMap val_23 = val_22.丝三丅丙且上丅丂丏();
        val_22.SetParent(parent:  val_23.grid.transform, worldPositionStays:  false);
        UnityEngine.Vector2 val_26 = val_25.mapPreviewTexture.localSize;
        UnityEngine.Vector2 val_27 = val_25.mapPreviewTexture.localSize;
        val_73 = val_16 / val_26.x;
        val_21.transform.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_21.name = "Map_" + val_75;
        int val_31 = val_75 / 5;
        val_31 = val_75 - (val_31 * 5);
        if(val_31 < 1)
        {
            goto label_44;
        }
        
        var val_33 = (val_31 == (5 - 1)) ? (1 + 1) : 1;
        if(((val_31 > 0) ? val_21.GetComponent<MapPreviewController>() : 0) != 0)
        {
            goto label_45;
        }
        
        goto label_46;
        label_44:
        val_77 = 0;
        label_45:
        val_76 = val_73 * val_27.y;
        val_75 = val_75 + 1;
        val_25.业上与丏上丑丘上下 = val_77;
        label_29:
        ConnectSceneSelectMap val_34 = val_21.丝三丅丙且上丅丂丏();
        if(val_75 < val_69)
        {
            goto label_48;
        }
        
        val_34.mapPreviewTexture.SetActive(value:  false);
        ConnectSceneSelectMap val_35 = val_34.mapPreviewTexture.丝三丅丙且上丅丂丏();
        val_70 = val_35.grid.GetComponent<UIGrid>();
        if(val_70 != null)
        {
                float val_66 = 15f;
            val_66 = val_76 + val_66;
            val_36.cellWidth = val_16 + val_66;
            val_36.cellHeight = val_66;
            val_36.maxPerLine = 5;
        }
        else
        {
                val_74 = 15f;
            mem[40] = val_16 + val_74;
            val_36.cellHeight = val_76 + val_74;
            val_36.maxPerLine = 5;
        }
        
        val_63 = val_63;
        val_68 = 1152921525776312064;
        label_16:
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_56;
        }
        
        SceneInfo val_41 = val_4.Item[0];
        ConnectSceneSelectMap val_42 = val_41.丝三丅丙且上丅丂丏();
        Rilisoft.七丕丟丏三丈一丄世 val_43 = GameConnect.丑丌丛丈丅丅与不业();
        val_42.FreePlayMapPanel.mapPreview.上东与丛丞下丈专丈(业丞丟万不丄丂丘丑:  val_43, 丄不东丁丂丅万丒丟:  val_41, 丗丂世丗丄不丟丘万:  false, 专且丆东且丁丂丝上:  0, 丈三丆丏丄三丏丛丒:  false);
        ConnectSceneSelectMap val_44 = val_42.FreePlayMapPanel.mapPreview.丝三丅丙且上丅丂丏();
        val_66 = val_44.FreePlayMapPanel.mapPreview;
        val_66.丐丝万丈丞业丙丐丆(七丆丂丂下丈且丟世:  val_41.丙且上丒不下丑下丞());
        mem[1152921525870525920] = val_46.FreePlayMapPanel.mapPreview;
        val_78 = this.丝三丅丙且上丅丂丏().gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_78, 丏业丟一东丂东丘丛:  false);
        return;
        label_83:
        ConnectSceneSelectMap val_49 = val_78.丝三丅丙且上丅丂丏();
        UnityEngine.GameObject val_52 = val_49.grid.transform.GetChild(index:  val_43).gameObject;
        if(val_52.activeSelf != false)
        {
                val_52.SetActive(value:  false);
        }
        
        val_69 = val_43 + 1;
        label_56:
        ConnectSceneSelectMap val_54 = val_52.丝三丅丙且上丅丂丏();
        val_70 = val_54.grid.transform;
        if(val_69 < val_70.childCount)
        {
            goto label_83;
        }
        
        val_79 = 0;
        goto label_84;
        label_87:
        SceneInfo val_57 = val_66.Item[0];
        val_57.且上不丘丘丏且丌丙(业丞丟万不丄丂丘丑:  val_66.丝三丅丙且上丅丂丏(), 丌丝万上丅丒一丈丘:  0, 丄不东丁丂丅万丒丟:  val_57, 丗丂世丗丄不丟丘万:  false, 丐且丘丑与万丞丑丅:  0);
        val_79 = 1;
        label_84:
        int val_58 = val_66.Count;
        if(val_79 < val_58)
        {
            goto label_87;
        }
        
        ConnectSceneSelectMap val_59 = val_58.丝三丅丙且上丅丂丏();
        UnityEngine.Transform val_61 = val_59.grid.transform.GetChild(index:  0);
        mem[1152921525870525920] = val_61.GetComponent<MapPreviewController>();
        val_78 = val_61.GetComponent<UIToggle>();
        val_78.value = true;
        return;
        label_46:
    }
    private void 丗世丌丘不丕丆丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_21;
        var val_22;
        var val_23;
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
        this.上一丝三丗且丆下丟();
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.createPanel.SetActive(value:  true);
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(GameConnect.丑丌丛丈丅丅与不业() != 1)
        {
            goto label_8;
        }
        
        val_21 = 0;
        if(val_2.customizeBtn != null)
        {
            goto label_13;
        }
        
        goto label_10;
        label_8:
        if(val_2.customizeBtn != null)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_2.customizeBtn.SetActive(value:  (GameConnect.丑丌丛丈丅丅与不业() != 31) ? 1 : 0);
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_22 = null;
        val_22 = null;
        val_6.setPasswordInput.gameObject.SetActive(value:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0);
        CustomPanelConnectScene val_9 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Transform val_10 = val_9.nameServerInput.transform;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_23;
        }
        
        if(val_10 != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        val_10.localPosition = new UnityEngine.Vector3() {x = this.丏丘丞丆与丕三丝丘, y = V9.16B, z = V10.16B};
        UnityEngine.GameObject val_12 = val_10.丝三丅丙且上丅丂丏().gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  true);
        val_23 = null;
        val_23 = null;
        val_12.丝三丅丙且上丅丂丏().SetWideBg(三丟东丕丄丄下下丑:  (GameConnect.丛丑世丕丌上丑丂丈 == true) ? 1 : 0);
        UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.丛业万丕三丌丑万上());
        CustomPanelConnectScene val_17 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_17.customPanel.SetActive(value:  false);
        CustomPanelConnectScene val_18 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_18.nameAlreadyUsedLabel.timer = -1f;
        CustomPanelConnectScene val_19 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19.nameAlreadyUsedLabel.gameObject.SetActive(value:  false);
        return;
        label_23:
        if(val_10 != null)
        {
            goto label_40;
        }
        
        goto label_41;
    }
    private void 丑丅丅下丌丅七世万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        if(CreatePrivateGameWindow.instance == 0)
        {
                return;
        }
        
        CreatePrivateGameWindow.instance.SaveCurrentSettingsToStorager();
        val_2 = null;
        val_2 = null;
        GameConnect.东丒丗丄一丐且丆丝 = true;
        this.HandleCreateRoomBtnClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    private void 丘丆万丆七丗不丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_11;
        var val_12;
        val_11 = null;
        val_11 = null;
        if(GameConnect.丛丑世丕丌上丑丂丈 != false)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1.nameServerInput.value)) != false)
        {
                string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4927");
            InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true) ? "#Все поля должны быть заполнены" : (val_4));
            return;
        }
        
        }
        
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_7.customizePanel.SetActive(value:  true);
        CustomPanelConnectScene val_8 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_12 = null;
        val_12 = null;
        val_8.customizePanel.GetComponent<CreatePrivateGameWindow>().ReadMapInfoNextFrame(丄不东丁丂丅万丒丟:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  this.丑业业业丒丏丈丞下.mapID));
    }
    public void HandleCreateRoomBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_43;
        SceneInfoController val_44;
        var val_45;
        string val_46;
        var val_47;
        int val_48;
        var val_49;
        var val_50;
        int val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        FilterMaps val_59;
        var val_60;
        val_43 = null;
        val_43 = null;
        if(GameConnect.丛丑世丕丌上丑丂丈 != false)
        {
                CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1.nameServerInput.value)) != false)
        {
                string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4927");
            InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true) ? "#Все поля должны быть заполнены" : (val_4));
            return;
        }
        
        }
        
        val_45 = null;
        val_45 = null;
        val_44 = SceneInfoController.丄丘七三上丕世丞业;
        SceneInfo val_7 = val_44.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  this.丑业业业丒丏丈丞下.mapID);
        if(val_7 == 0)
        {
                return;
        }
        
        string val_10 = val_7.gameObject.name;
        CustomPanelConnectScene val_11 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_46 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_11.nameServerInput.value);
        val_47 = null;
        val_47 = 1152921505171275776;
        val_48 = 丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑();
        var val_44 = 0;
        label_43:
        if(val_44 >= val_14.Length)
        {
            goto label_39;
        }
        
        val_44 = val_44 + 1;
        if((val_48[0].东丙上东业丆不丟丘().Equals(value:  val_46)) == false)
        {
            goto label_43;
        }
        
        CustomPanelConnectScene val_17 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_17.customizePanel.SetActive(value:  false);
        CustomPanelConnectScene val_18 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_18.nameAlreadyUsedLabel.timer = 3f;
        CustomPanelConnectScene val_19 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_19.nameAlreadyUsedLabel.gameObject.SetActive(value:  true);
        CustomPanelConnectScene.丑七不且上丗丁一世().SetRandomRoomName();
        CustomPanelConnectScene val_22 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_22.tryCreateRoomAgain.gameObject.SetActive(value:  true);
        val_49 = static_value_081DACA8;
        val_49 = static_value_081DACA8;
        val_44 = mem[static_value_081DACA8 + 184 + 16];
        val_44 = static_value_081DACA8 + 184 + 16;
        val_44.HandleBackBtnClicked();
        return;
        label_39:
        this.上下丟七丗业丁丒丕 = val_10;
        UnityEngine.PlayerPrefs.SetString(key:  "MapName", value:  val_10);
        UnityEngine.PlayerPrefs.SetString(key:  "MaxKill", value:  "4");
        val_50 = static_value_081DACA8;
        val_50 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丏丑不七丕丄丅东丆(七丆丂丂下丈且丟世:  this.上下丟七丗业丁丒丕);
        static_value_081DACA8 + 184 + 16 + 152.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  1176");
        Rilisoft.七丕丟丏三丈一丄世 val_24 = GameConnect.丑丌丛丈丅丅与不业();
        if(val_24 == 20)
        {
                ConnectSceneSelectMap val_25 = val_24.丝三丅丙且上丅丂丏();
            val_51 = val_25.selectMap.mapID;
            int val_26 = GameConnect.丈东丛丝丞不丒一世(丛丝丁丗且丘丂与万:  val_51);
        }
        else
        {
                int val_28 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        }
        
        val_48 = GameConnect.丏丝一丁丛丕且丐丈(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        val_52 = null;
        val_52 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                val_53 = static_value_081DACA8;
            val_53 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16 + 152.SetActive(value:  true);
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  1183");
            val_44 = val_7.indexMap;
            CustomPanelConnectScene val_31 = CustomPanelConnectScene.丑七不且上丗丁一世();
            GameConnect.万丐丑上丟丞丞丏丑(丅一丞万丑专丅丅与:  val_46, 丞与一东丈世且丐丕:  val_28, 丛且丞与丕业下丏丞:  val_44, 丗一丁丅与专丐一世:  val_48, 专业丛丆丟丆丛业丆:  GameConnect.丐业丏丁业且丏上世(专业丛丆丟丆丛业丆:  val_31.setPasswordInput.value), 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丟丑业丌丙丙丑下丑:  false, 下下东且万业丞丅丒:  true, 丙丘东丏三丆丄丁丟:  0, 丐且丘丑与万丞丑丅:  0, 七专丙丏丘丌丌下与:  0, 丕丑专丗万丕与专丐:  1);
            return;
        }
        
        val_54 = null;
        val_54 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        UnityEngine.PlayerPrefs.SetString(key:  "ServerName", value:  ((System.String.IsNullOrEmpty(value:  val_46)) != true) ? "Server" : (val_46));
        UnityEngine.PlayerPrefs.SetString(key:  "PlayersLimits", value:  val_28.ToString());
        val_46 = 1152921505286238208;
        val_55 = null;
        val_55 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_103;
        }
        
        val_56 = null;
        val_56 = null;
        val_57 = null;
        val_57 = null;
        val_46 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑;
        if((val_46.ContainsKey(key:  val_10)) == false)
        {
            goto label_109;
        }
        
        val_58 = null;
        val_58 = null;
        val_46 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑;
        val_59 = val_46.Item[val_10];
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_115;
        }
        
        goto label_114;
        label_109:
        val_59 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_115;
        }
        
        label_114:
        label_115:
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  val_59);
        label_103:
        val_44 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance;
        val_60 = null;
        val_60 = null;
        UnityEngine.AsyncOperation val_42 = val_44.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟, 丂丛丑东不丅丈一东:  0);
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
    }
    public void HandleSearchBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        string val_8;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.customPanel.SetActive(value:  true);
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_2.searchInput != 0)
        {
                CustomPanelConnectScene val_4 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_8 = val_4.searchInput.value;
            this.丁丆上丁业丈丙丈东 = val_8;
        }
        else
        {
                val_8 = this.丁丆上丁业丈丙丈东;
        }
        
        this.丘丒丛丙丏丟世不丘(丞丘与万丞三丁丘丙:  val_8);
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_6.scrollGames.ResetPosition();
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_7.searchPanel.SetActive(value:  false);
    }
    internal void 且丝丌与丗丝丈一丟()
    {
        var val_79;
        string val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        val_79 = 1152921504624312320;
        this.丁丆上丁业丈丙丈东 = System.String.alignConst;
        PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<Rilisoft.七丕丟丏三丈一丄世>.万世丅七一专丕丞不();
        PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_2 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丘专丒丈丌丁且丁丟();
        PGCompany.GameModeHub.丂丕且丟丌丐万东丗.专丅专丈丛丙一丂丒(不丝丄丒丌丐一一与:  val_2.丐丂丄丘丈专七万下, 专丂丕丗丗东世丞下: ref  val_3);
        if(val_3.Count < 1)
        {
                return;
        }
        
        val_80 = 1152921525786468128;
        if(val_3.Item[0] == 100)
        {
                return;
        }
        
        val_81 = static_value_081DACA8;
        val_81 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丁丁世一不业丈上丑(丙业与丙丗丝不丈东:  false);
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  val_3.Item[0]);
        val_82 = null;
        val_82 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
        }
        
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_83 = null;
        val_83 = null;
        val_7.showSearchPanelBtn.SetActive(value:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0);
        CustomPanelConnectScene val_9 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_84 = 0;
        if(val_9.sharedBackButton != 0)
        {
                CustomPanelConnectScene val_11 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_84 = 0;
            val_11.sharedBackButton.SetActive(value:  true);
        }
        
        CustomPanelConnectScene.丑七不且上丗丁一世().下与丞三丅丛丄七丕();
        CustomPanelConnectScene val_13 = CustomPanelConnectScene.丑七不且上丗丁一世();
        Rilisoft.七丕丟丏三丈一丄世 val_15 = GameConnect.丑丌丛丈丅丅与不业();
        var val_80 = 0;
        val_80 = val_80 + 1;
        val_84 = 0;
        val_80 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]);
        val_13.headCustomPanel.SetText(丕丗丘丑丛与丑业丒:  val_80);
        CustomPanelConnectScene.丑七不且上丗丁一世().丑专业丅三丈丏下丝(丙业与丙丗丝不丈东:  false);
        CustomPanelConnectScene val_20 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_20.gameIsfullLabel.timer = -1f;
        CustomPanelConnectScene val_21 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_21.gameIsfullLabel.gameObject.SetActive(value:  false);
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
        if(this.丄东丑与丕东七丆丈 == true)
        {
                return;
        }
        
        CustomPanelConnectScene val_23 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_25 = val_23.nameServerInput.transform.localPosition;
        this.丏丘丞丆与丕三丝丘 = val_25;
        mem[1152921525872665264] = val_25.y;
        mem[1152921525872665268] = val_25.z;
        CustomPanelConnectScene val_26 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_79 = 1152921505092788224;
        val_26.setPasswordInput.onSubmit.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CustomPanelConnectScene::丂且世丛丅丁丐丄丄())));
        CustomPanelConnectScene val_29 = CustomPanelConnectScene.丑七不且上丗丁一世();
        EventDelegate val_31 = null;
        val_80 = val_31;
        val_31 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CustomPanelConnectScene::丐丛丈丅丌一丌丑丝()));
        val_29.enterPasswordInput.onSubmit.Add(item:  val_31);
        this.丄东丑与丕东七丆丈 = true;
        CustomPanelConnectScene val_32 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_32.showSearchPanelBtn != 0)
        {
                CustomPanelConnectScene val_34 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_35 = val_34.showSearchPanelBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_35 != 0)
        {
                System.EventHandler val_37 = null;
            val_80 = val_37;
            val_37 = new System.EventHandler(object:  this, method:  System.Void CustomPanelConnectScene::上下丙专丌下丄丈丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_35.add_Clicked(丙业与丙丗丝不丈东:  val_37);
        }
        
        }
        
        CustomPanelConnectScene val_38 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_38.createRoomBtn != 0)
        {
                CustomPanelConnectScene val_40 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_41 = val_40.createRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_41 != 0)
        {
                System.EventHandler val_43 = null;
            val_80 = val_43;
            val_43 = new System.EventHandler(object:  this, method:  System.Void CustomPanelConnectScene::丗世丌丘不丕丆丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_41.add_Clicked(丙业与丙丗丝不丈东:  val_43);
        }
        
        }
        
        CustomPanelConnectScene val_44 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_44.createCustomRoomBtn != 0)
        {
                CustomPanelConnectScene val_46 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_47 = val_46.createCustomRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_47 != 0)
        {
                System.EventHandler val_49 = null;
            val_80 = val_49;
            val_49 = new System.EventHandler(object:  this, method:  System.Void CustomPanelConnectScene::丑丅丅下丌丅七世万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_47.add_Clicked(丙业与丙丗丝不丈东:  val_49);
        }
        
        }
        
        CustomPanelConnectScene val_50 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_50.customizeBtn != 0)
        {
                CustomPanelConnectScene val_52 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_53 = val_52.customizeBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_53 != 0)
        {
                System.EventHandler val_55 = null;
            val_80 = val_55;
            val_55 = new System.EventHandler(object:  this, method:  System.Void CustomPanelConnectScene::丘丆万丆七丗不丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_53.add_Clicked(丙业与丙丗丝不丈东:  val_55);
        }
        
        }
        
        CustomPanelConnectScene val_56 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_56.goToCreateRoomBtn != 0)
        {
                CustomPanelConnectScene val_58 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_59 = val_58.goToCreateRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_59 != 0)
        {
                System.EventHandler val_61 = null;
            val_80 = val_61;
            val_61 = new System.EventHandler(object:  this, method:  public System.Void CustomPanelConnectScene::HandleCreateRoomBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_59.add_Clicked(丙业与丙丗丝不丈东:  val_61);
        }
        
        }
        
        CustomPanelConnectScene val_62 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_62.searchBtn != 0)
        {
                CustomPanelConnectScene val_64 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_65 = val_64.searchBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_65 != 0)
        {
                System.EventHandler val_67 = null;
            val_80 = val_67;
            val_67 = new System.EventHandler(object:  this, method:  public System.Void CustomPanelConnectScene::HandleSearchBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_65.add_Clicked(丙业与丙丗丝不丈东:  val_67);
        }
        
        }
        
        CustomPanelConnectScene val_68 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_68.joinRoomFromEnterPasswordBtn != 0)
        {
                CustomPanelConnectScene val_70 = CustomPanelConnectScene.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_71 = val_70.joinRoomFromEnterPasswordBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_71 != 0)
        {
                System.EventHandler val_73 = null;
            val_80 = val_73;
            val_73 = new System.EventHandler(object:  this, method:  public System.Void CustomPanelConnectScene::HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_71.add_Clicked(丙业与丙丗丝不丈东:  val_73);
        }
        
        }
        
        CustomPanelConnectScene val_74 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_74.joinCustomRoomFromEnterPasswordBtn == 0)
        {
                return;
        }
        
        CustomPanelConnectScene val_76 = CustomPanelConnectScene.丑七不且上丗丁一世();
        Rilisoft.ButtonHandler val_77 = val_76.joinCustomRoomFromEnterPasswordBtn.GetComponent<Rilisoft.ButtonHandler>();
        if(val_77 == 0)
        {
                return;
        }
        
        System.EventHandler val_79 = null;
        val_80 = val_79;
        val_79 = new System.EventHandler(object:  this, method:  public System.Void CustomPanelConnectScene::HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        val_77.add_Clicked(丙业与丙丗丝不丈东:  val_79);
    }
    private void 下与丞三丅丛丄七丕()
    {
        var val_7;
        UnityEngine.Object val_8;
        var val_9;
        val_7 = static_value_081DACA8;
        val_7 = static_value_081DACA8;
        val_8 = mem[static_value_081DACA8 + 184 + 16 + 64];
        val_8 = static_value_081DACA8 + 184 + 16 + 64;
        if( != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        val_9 = static_value_081DACA8;
        val_9 = static_value_081DACA8;
        mem2[0] = 1;
        CustomPanelConnectScene val_3 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_3.customPanel.SetActive(value:  true);
        if(this.丟七丕丙三丂七万丟 != null)
        {
                return;
        }
        
        this.丟七丕丙三丂七万丟 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void CustomPanelConnectScene::BackButton()), 与且专丈不万东一万:  "Private games window");
    }
    private void 丆世与丑丆丅丐万且()
    {
        if(this.丟七丕丙三丂七万丟 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丟七丕丙三丂七万丟.Dispose();
            this.丟七丕丙三丂七万丟 = 0;
        }
        
        CustomPanelConnectScene val_2 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_2.customPanel.SetActive(value:  false);
    }
    public void BackButton()
    {
        var val_42;
        var val_43;
        bool val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        UnityEngine.GameObject val_49;
        var val_50;
        var val_51;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_1.customPanel == 0)
        {
            goto label_11;
        }
        
        CustomPanelConnectScene val_3 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_3.customPanel.activeSelf == false)
        {
            goto label_11;
        }
        
        val_42 = static_value_081DACA8;
        val_42 = static_value_081DACA8;
        mem2[0] = 0;
        val_43 = null;
        val_43 = null;
        GameConnect.丛丑世丕丌上丑丂丈 = false;
        CustomPanelConnectScene val_5 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_5.connectToWiFIInCreateLabel.SetActive(value:  false);
        CustomPanelConnectScene val_6 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_6.connectToWiFIInCustomLabel.SetActive(value:  false);
        CustomPanelConnectScene val_7 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_44 = true;
        val_45 = null;
        val_45 = null;
        与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 = val_44;
        this.丆世与丑丆丅丐万且();
        goto label_27;
        label_42:
        CustomPanelConnectScene val_8 = CustomPanelConnectScene.丑七不且上丗丁一世();
        UnityEngine.Transform val_9 = val_8.gridGamesTransform.GetChild(index:  0);
        if(val_9 != null)
        {
                val_9.parent = 0;
            val_44 = this.gamesInfo;
        }
        else
        {
                0.parent = 0;
            val_44 = this.gamesInfo;
        }
        
        bool val_11 = val_44.Remove(item:  val_9.gameObject);
        UnityEngine.Object.Destroy(obj:  val_9.gameObject);
        label_27:
        CustomPanelConnectScene val_13 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_13.gridGamesTransform.childCount > 0)
        {
            goto label_42;
        }
        
        val_46 = static_value_081DACA8;
        val_46 = static_value_081DACA8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  static_value_081DACA8 + 184 + 16 + 64.gameObject, 丏业丟一东丂东丘丛:  true);
        GameConnect.下与业丒丝丕丙丘丙();
        static_value_081DACA8 + 184 + 16.丁丁世一不业丈上丑(丙业与丙丗丝不丈东:  true);
        label_11:
        CustomPanelConnectScene val_16 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_16.searchPanel != 0)
        {
                CustomPanelConnectScene val_18 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_18.searchPanel.activeSelf != false)
        {
                CustomPanelConnectScene val_20 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_20.searchInput.value = this.丁丆上丁业丈丙丈东;
            CustomPanelConnectScene val_21 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_21.searchPanel.SetActive(value:  false);
            CustomPanelConnectScene val_22 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_22.customPanel.SetActive(value:  true);
        }
        
        }
        
        CustomPanelConnectScene val_23 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_23.createPanel != 0)
        {
                CustomPanelConnectScene val_25 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_25.createPanel.activeSelf != false)
        {
                CustomPanelConnectScene.丑七不且上丗丁一世().上丁且丐与万七丌丞();
        }
        
        }
        
        CustomPanelConnectScene val_28 = CustomPanelConnectScene.丑七不且上丗丁一世();
        if(val_28.enterPasswordPanel != 0)
        {
                CustomPanelConnectScene val_30 = CustomPanelConnectScene.丑七不且上丗丁一世();
            if(val_30.enterPasswordPanel.activeSelf != false)
        {
                CustomPanelConnectScene val_32 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_32.enterPasswordPanel.SetActive(value:  false);
            CustomPanelConnectScene val_33 = CustomPanelConnectScene.丑七不且上丗丁一世();
            val_33.customPanel.SetActive(value:  true);
            val_47 = null;
            val_47 = null;
            if(ExperienceController.sharedController != 0)
        {
                val_48 = null;
            val_48 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        }
        
        CustomPanelConnectScene val_35 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_49 = val_35.enterPasswordCustomPanel;
        if(val_49 == 0)
        {
                return;
        }
        
        CustomPanelConnectScene val_37 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_49 = val_37.enterPasswordCustomPanel;
        if(val_49.activeSelf == false)
        {
                return;
        }
        
        CustomPanelConnectScene val_39 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_39.enterPasswordCustomPanel.SetActive(value:  false);
        CustomPanelConnectScene val_40 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_40.customPanel.SetActive(value:  true);
        val_50 = null;
        val_50 = null;
        val_49 = ExperienceController.sharedController;
        if(val_49 == 0)
        {
                return;
        }
        
        val_51 = null;
        val_51 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
    }
    internal void 上丁且丐与万七丌丞()
    {
        var val_5;
        var val_6;
        var val_7;
        CustomPanelConnectScene val_1 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_1.createPanel.SetActive(value:  false);
        val_5 = static_value_081DACA8;
        val_5 = static_value_081DACA8;
        val_6 = mem[static_value_081DACA8 + 184];
        val_6 = static_value_081DACA8 + 184;
        val_6 = mem[static_value_081DACA8 + 184];
        val_6 = static_value_081DACA8 + 184;
        if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_7 = static_value_081DACA8;
            val_7 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.三万丛上丞丐业丕世();
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5.丝三丅丙且上丅丂丏(), 丏业丟一东丂东丘丛:  false);
        }
        
        CustomPanelConnectScene val_4 = CustomPanelConnectScene.丑七不且上丗丁一世();
        val_4.customPanel.SetActive(value:  true);
    }
    private void OnDestroy()
    {
        null = null;
        CustomPanelConnectScene.丝业丆丁业三丈丟东 = 0;
    }
    public CustomPanelConnectScene()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丏丘丞丆与丕三丝丘 = val_1;
        mem[1152921525874243664] = val_1.y;
        mem[1152921525874243668] = val_1.z;
        this.丑丐丅丟下丞三丛且 = new System.Collections.Generic.List<丞丘丒一上与丕丒且>();
        this.gamesInfo = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.下丒丏丙一不七丕丏 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        this.丄丈丟丙不世与丅丈 = 3;
        this.丕专丗万上丁世丝丁 = 3;
        this.丒丙丘丟且丈丗且丞 = 0f;
        this.丏丝丕丈丑丙丄丁业 = 1f;
        this.丐与丒丐七丙丌三不 = 1f;
        this.七与丌三丙丈丅丕丕 = 10f;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  10000f);
        this.丙一不且丑丆丆丂丆 = val_6;
        mem[1152921525874243776] = val_6.y;
        mem[1152921525874243780] = val_6.z;
    }
    private static CustomPanelConnectScene()
    {
    
    }
    private void 丂且世丛丅丁丐丄丄()
    {
        this.下丐丅丑丘专丑丈丑();
    }

}
