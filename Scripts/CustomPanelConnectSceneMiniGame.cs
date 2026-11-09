using UnityEngine;
public class CustomPanelConnectSceneMiniGame : MonoBehaviour
{
    // Fields
    private static CustomPanelConnectSceneMiniGame 丝业丆丁业三丈丟东;
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
    public UnityEngine.GameObject headLabel;
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
    private bool 丈与万不丗东业下下;
    
    // Properties
    internal static CustomPanelConnectSceneMiniGame 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static CustomPanelConnectSceneMiniGame 丑七不且上丗丁一世()
    {
        var val_13;
        CustomPanelConnectSceneMiniGame val_14;
        var val_15;
        UnityEngine.GameObject val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = null;
        val_13 = null;
        val_14 = CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东;
        if(val_14 == 0)
        {
                val_15 = static_value_081DACA8;
            val_15 = static_value_081DACA8;
            val_14 = mem[static_value_081DACA8 + 184 + 16];
            val_14 = static_value_081DACA8 + 184 + 16;
            if(val_14 != 0)
        {
                UnityEngine.Object val_3 = UnityEngine.Resources.Load(path:  "ConnectScene/CustomPanelConnectSceneMiniGame");
            if(val_3 != null)
        {
                val_3 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_16 = 0;
        }
        
            val_17 = null;
            val_17 = null;
            CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_16).GetComponent<CustomPanelConnectSceneMiniGame>();
            val_18 = static_value_081DACA8;
            val_18 = static_value_081DACA8;
            CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东.transform.parent = static_value_081DACA8 + 184 + 16.transform.GetChild(index:  0);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_14 = CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_14.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        
        }
        
        val_19 = null;
        val_19 = null;
        return (CustomPanelConnectSceneMiniGame)CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东;
    }
    private void OnEnable()
    {
        if(GameConnect.丑丌丛丈丅丅与不业() == 9)
        {
                this.searchPanel.gameObject.SetActive(value:  false);
            this.createPanel.gameObject.SetActive(value:  false);
            this.customPanel.gameObject.SetActive(value:  true);
        }
        
        this.SetRandomRoomName();
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
        
        CustomPanelConnectSceneMiniGame val_3 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
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
    private void OnDestroy()
    {
        null = null;
        CustomPanelConnectSceneMiniGame.丝业丆丁业三丈丟东 = 0;
    }
    public CustomPanelConnectSceneMiniGame()
    {
    
    }
    private static CustomPanelConnectSceneMiniGame()
    {
    
    }

}
