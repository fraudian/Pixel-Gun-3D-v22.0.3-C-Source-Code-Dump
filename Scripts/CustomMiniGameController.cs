using UnityEngine;
internal sealed class CustomMiniGameController : MonoBehaviour
{
    // Fields
    internal static string 丑业业业丒丏丈丞下;
    private UnityEngine.GameObject _customPanel;
    private string 丂丝丕三东丏三且下;
    private float 丏丝丕丈丑丙丄丁业;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    private UnityEngine.GameObject _miniGamePanel;
    private float 丐与丒丐七丙丌三不;
    private UnityEngine.GameObject _selectMapPanel;
    private float 丒丙丘丟且丈丗且丞;
    private float 七与丌三丙丈丅丕丕;
    private bool 三丅丅不丅丂业丙丄;
    private int 丕专丗万上丁世丝丁;
    private int 丄丈丟丙不世与丅丈;
    private int 一丁丈丗丄丛丑丗业;
    private int 上丁丈丛丌上不丟与;
    private int 上丞且不七丙万万丘;
    private int 丗丌上丁且专丈上世;
    private int 七一丟丆丟丞专丆东;
    private System.Collections.Generic.List<丞丘丒一上与丕丒且> 丑丐丅丟下丞三丛且;
    private bool 丘丛上丑丗上世专业;
    public UISprite fonMapPreview;
    public string gameNameFilter;
    public System.Collections.Generic.List<UnityEngine.GameObject> gamesInfo;
    private string 上下丟七丗业丁丒丕;
    public UnityEngine.GameObject grid;
    private bool 丏上丒专丞丑东且丞;
    private bool 丙丅七下丑丒下丆一;
    private bool 世与且不丝丘业丑丘;
    private bool 上丐丐丆丝丕丟一丁;
    private bool 丄东丑与丕东七丆丈;
    private bool 丙世丁三三丄丟丅丙;
    private bool 七七丁丄丗丈与东万;
    private bool 丌业业丛丞业七丘万;
    private 丞丘丒一上与丕丒且 一世东丄丗丆丘丛丂;
    private UnityEngine.GameObject loadingMapPanel;
    private System.IDisposable 丙世丈且丆丒下下丌;
    private float 丟丗不丈七下丗与三;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 下丒丏丙一不七丕丏;
    public UnityEngine.GameObject mapPreviewTexture;
    private int 上丁丆丆三且丅丕丒;
    private StartMiniGameGuiController miniGameController;
    private string 东丅丒丛丏丄丒丞专;
    private UnityEngine.Vector3 丙一不且丑丆丆丂丆;
    private UnityEngine.Texture 丗丗丈一世丞丏丙丟;
    private bool 丛丗丆丏丟丞东丝丒;
    public UnityEngine.Transform scrollViewSelectMapTransform;
    public MapPreviewController selectMap;
    public UnityEngine.Transform selectMapPanelTransform;
    public DisableObjectFromTimer serverIsNotAvalible;
    private UnityEngine.Vector3 丏丘丞丆与丕三丝丘;
    private static CustomMiniGameController <丗专丁丞丞丄东七丘>k__BackingField;
    
    // Properties
    internal static CustomMiniGameController 丄丞丁丈与业上丞丟 { get; set; }
    internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌 { get; }
    public bool 丝三丞丕七丈丅丐世 { get; }
    
    // Methods
    internal static CustomMiniGameController 丂丞丛丙东丗丈业丑()
    {
        null = null;
        return (CustomMiniGameController)CustomMiniGameController.<丗专丁丞丞丄东七丘>k__BackingField;
    }
    private static void 丕丆上三世丘不丂丂(CustomMiniGameController 丙业与丙丗丝不丈东)
    {
        null = null;
        CustomMiniGameController.<丗专丁丞丞丄东七丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.七丕丟丏三丈一丄世 丘丛丆丕且丂业世丌()
    {
        if(this.miniGameController == 0)
        {
                return 9;
        }
        
        if(this.miniGameController != null)
        {
                return this.miniGameController.Type;
        }
        
        return this.miniGameController.Type;
    }
    public bool get_InCustomPanel()
    {
        return (bool)this.丏上丒专丞丑东且丞;
    }
    public void CustomMiniGameStart()
    {
        var val_10;
        var val_11;
        System.Action val_12;
        var val_13;
        var val_14;
        this.世与且不丝丘业丑丘 = true;
        val_10 = static_value_081DACA8;
        val_10 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16 + 384.CancelBtn();
        this.三丅丅不丅丂业丙丄 = true;
        val_11 = null;
        val_11 = null;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  StartMiniGameGuiController.万与丈世丝丙万丕一);
        GameConnect.丛丑世丕丌上丑丂丈 = true;
        if(((System.Delegate.Combine(a:  GameConnect.丂丐与丞丗丒丘丑上, b:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::丂丐与丞丗丒丘丑上()))) != null) && (null != null))
        {
                val_12 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_12;
        if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_13 = static_value_081DACA8;
            val_13 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16 + 384) != 0)
        {
                val_14 = static_value_081DACA8;
            val_14 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16 + 384.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::丗丑丛且与丅七丟丏()), 丟丌丘世丟丛下万东:  true, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
        }
        
        }
        
        this.丙世丈且丆丒下下丌 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void CustomMiniGameController::HandleBackButtonPressed()), 与且专丈不万东一万:  "CustomMiniGameGuiController");
    }
    private void 下丙丗下丛丐与丞且()
    {
        if(this._customPanel != 0)
        {
                this._customPanel.SetActive(value:  true);
        }
        
        if(this._miniGamePanel != 0)
        {
                this._miniGamePanel.SetActive(value:  false);
        }
        
        if(this._selectMapPanel == 0)
        {
                return;
        }
        
        this._selectMapPanel.SetActive(value:  false);
    }
    private void OnEnable()
    {
        this.ShowMiniGames();
    }
    private void Start()
    {
        if(this.serverIsNotAvalible == 0)
        {
                return;
        }
        
        if(this.serverIsNotAvalible.gameObject == 0)
        {
                return;
        }
        
        if(this.serverIsNotAvalible.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.serverIsNotAvalible.gameObject.SetActive(value:  false);
    }
    public void ShowMiniGames()
    {
        if(this._customPanel != 0)
        {
                this._customPanel.SetActive(value:  false);
        }
        
        if(this._miniGamePanel != 0)
        {
                this._miniGamePanel.SetActive(value:  true);
        }
        
        if(this._selectMapPanel == 0)
        {
                return;
        }
        
        this._selectMapPanel.SetActive(value:  false);
    }
    internal void 与丄东世东业丏下丘()
    {
        var val_14;
        if(this.世与且不丝丘业丑丘 == false)
        {
                return;
        }
        
        if(this.grid == 0)
        {
                return;
        }
        
        if(this.grid.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_14 = 0;
        goto label_8;
        label_22:
        if((this.grid.transform.GetChild(index:  0).gameObject.activeSelf) != false)
        {
                MapPreviewController val_10 = this.grid.transform.GetChild(index:  0).GetComponent<MapPreviewController>();
            if(val_10.mapID != 1)
        {
                if(val_10.isActiveAndEnabled != false)
        {
                val_10.丅丂丙丁业丅丆且世();
        }
        
        }
        
        }
        
        val_14 = 1;
        label_8:
        if(val_14 < this.grid.transform.childCount)
        {
            goto label_22;
        }
    
    }
    public void HandleBackButtonPressed()
    {
        System.Action val_27;
        var val_28;
        System.Action<System.Boolean> val_29;
        var val_30;
        System.Action val_31;
        var val_32;
        var val_33;
        System.Action val_34;
        var val_35;
        if(this.三丅丅不丅丂业丙丄 != false)
        {
                return;
        }
        
        if(this._miniGamePanel != 0)
        {
                if(this._miniGamePanel.activeInHierarchy != false)
        {
                this.gameObject.GetComponent<StartMiniGameGuiController>().HandleBackButtonPressed();
            return;
        }
        
        }
        
        if(this.丙丅七下丑丒下丆一 != false)
        {
                if(this.丙世丁三三丄丟丅丙 == false)
        {
            goto label_10;
        }
        
        }
        
        if(this.七七丁丄丗丈与东万 != true)
        {
                if(this.丙世丁三三丄丟丅丙 == false)
        {
            goto label_12;
        }
        
        }
        
        this.丙世丁三三丄丟丅丙 = false;
        this.七七丁丄丗丈与东万 = false;
        if(this._customPanel != 0)
        {
                this._customPanel.SetActive(value:  true);
        }
        
        CustomPanelConnectSceneMiniGame val_6 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_6.chooseMapLabelSmall.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame val_7 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_7.incorrectPasswordLabel.gameObject.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_9 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_9.searchPanel.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_10 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_10.enterPasswordPanel != null)
        {
            goto label_44;
        }
        
        label_45:
        label_44:
        val_10.enterPasswordPanel.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_11 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_11.customPanel.SetActive(value:  true);
        this.UpdateFilteredRoomList(丞丘与万丞三丁丘丙:  this.gameNameFilter);
        this._miniGamePanel.SetActive(value:  false);
        if(this._selectMapPanel == 0)
        {
                return;
        }
        
        this._selectMapPanel.SetActive(value:  false);
        return;
        label_10:
        this.丙丅七下丑丒下丆一 = false;
        if(this._customPanel != 0)
        {
                this._customPanel.SetActive(value:  true);
        }
        
        CustomPanelConnectSceneMiniGame val_14 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_14.chooseMapLabelSmall.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame val_15 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_15.createPanel != null)
        {
            goto label_44;
        }
        
        goto label_45;
        label_12:
        GameConnect.下与业丒丝丕丙丘丙();
        this.世与且不丝丘业丑丘 = false;
        val_28 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_28 = null;
            val_27 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_27;
        val_30 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void CustomMiniGameController::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_30 = null;
            val_29 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_29;
        val_32 = null;
        val_33 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::丂丐与丞丗丒丘丑上()))) != null) && (null != val_33))
        {
                val_32 = null;
            val_33 = null;
            val_31 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_31;
        if(((System.Delegate.Remove(source:  GameConnect.丐丗丈下三与丝丙业, value:  new System.Action(object:  this, method:  public System.Void CustomMiniGameController::OnReceivedRoomListUpdate()))) != null) && (null != null))
        {
                val_34 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_34;
        val_35 = static_value_081DACA8;
        val_35 = static_value_081DACA8;
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  static_value_081DACA8 + 184 + 4);
        MapPopularityController.东丝丑专七丑丆丒上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::与丄东世东业丏下丘()));
        this.ShowMiniGames();
        if(this.丙世丈且丆丒下下丌 == null)
        {
                return;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        this.丙世丈且丆丒下下丌.Dispose();
        this.丙世丈且丆丒下下丌 = 0;
    }
    private void OnDisable()
    {
        var val_13;
        System.Action val_14;
        var val_15;
        System.Action<System.Boolean> val_16;
        var val_17;
        System.Action val_18;
        var val_19;
        var val_20;
        System.Action val_21;
        var val_22;
        if(this.丙世丈且丆丒下下丌 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            this.丙世丈且丆丒下下丌.Dispose();
            this.丙世丈且丆丒下下丌 = 0;
        }
        
        val_13 = null;
        val_13 = null;
        val_15 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_15 = null;
            val_14 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_14;
        val_17 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void CustomMiniGameController::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_17 = null;
            val_16 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_16;
        val_19 = null;
        val_20 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::丂丐与丞丗丒丘丑上()))) != null) && (null != val_20))
        {
                val_19 = null;
            val_20 = null;
            val_18 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_18;
        val_22 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丐丗丈下三与丝丙业, value:  new System.Action(object:  this, method:  public System.Void CustomMiniGameController::OnReceivedRoomListUpdate()))) != null) && (null != val_22))
        {
                val_22 = null;
            val_21 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_21;
        MapPopularityController.东丝丑专七丑丆丒上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::与丄东世东业丏下丘()));
    }
    private void 丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)
    {
        UnityEngine.Object val_13;
        UnityEngine.GameObject val_14;
        var val_15;
        val_14 = this;
        if(this.世与且不丝丘业丑丘 == false)
        {
                return;
        }
        
        this.三丅丅不丅丂业丙丄 = false;
        val_13 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_13 == 0)
        {
                return;
        }
        
        if(丟丄下上丈丗丙丞世 != false)
        {
                CustomPanelConnectSceneMiniGame val_3 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_3.nameAlreadyUsedLabel.timer = 3f;
            CustomPanelConnectSceneMiniGame val_4 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            UnityEngine.GameObject val_5 = val_4.nameAlreadyUsedLabel.gameObject;
            val_15 = 1;
        }
        else
        {
                CustomPanelConnectSceneMiniGame val_6 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_6.gameIsfullLabel.timer = 3f;
            CustomPanelConnectSceneMiniGame val_7 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_7.gameIsfullLabel.gameObject.SetActive(value:  true);
            CustomPanelConnectSceneMiniGame val_9 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_9.incorrectPasswordLabel.timer = -1f;
            CustomPanelConnectSceneMiniGame val_10 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_15 = 0;
        }
        
        val_10.incorrectPasswordLabel.gameObject.SetActive(value:  false);
        if(this.loadingMapPanel != 0)
        {
                val_14 = this.loadingMapPanel;
            val_14.SetActive(value:  false);
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    private void 丂丐与丞丗丒丘丑上()
    {
        object val_32;
        var val_33;
        System.Action val_34;
        var val_35;
        System.Action<System.Boolean> val_36;
        var val_37;
        System.Action val_38;
        var val_39;
        var val_40;
        System.Action val_41;
        var val_42;
        var val_43;
        System.Collections.Generic.List<UnityEngine.GameObject> val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        val_32 = this;
        val_33 = null;
        val_33 = null;
        val_35 = null;
        if(((System.Delegate.Remove(source:  GameConnect.三丟丏东且与丗世专, value:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_35 = null;
            val_34 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_34;
        val_37 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丝丛丅专上业与丞七, value:  new System.Action<System.Boolean>(object:  this, method:  System.Void CustomMiniGameController::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_37 = null;
            val_36 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_36;
        val_39 = null;
        val_40 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丂丐与丞丗丒丘丑上, value:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::丂丐与丞丗丒丘丑上()))) != null) && (null != val_40))
        {
                val_39 = null;
            val_40 = null;
            val_38 = 0;
        }
        
        GameConnect.丂丐与丞丗丒丘丑上 = val_38;
        val_42 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丐丗丈下三与丝丙业, value:  new System.Action(object:  this, method:  public System.Void CustomMiniGameController::OnReceivedRoomListUpdate()))) != null) && (null != val_42))
        {
                val_42 = null;
            val_41 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_41;
        MapPopularityController.东丝丑专七丑丆丒上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::与丄东世东业丏下丘()));
        this.世与且不丝丘业丑丘 = false;
        UnityEngine.Debug.Log(message:  "On Disconnected From Photon");
        GameConnect.七七丈东丅上丝丒万 = false;
        this.三丅丅不丅丂业丙丄 = false;
        this.七七丁丄丗丈与东万 = false;
        this.丙世丁三三丄丟丅丙 = false;
        this.丙丅七下丑丒下丆一 = false;
        if(this.loadingMapPanel != 0)
        {
                if(this.loadingMapPanel.activeSelf == true)
        {
            goto label_19;
        }
        
        }
        
        if((this._miniGamePanel == 0) || (this._miniGamePanel.activeSelf == true))
        {
            goto label_28;
        }
        
        label_19:
        if(this.丘丛上丑丗上世专业 == false)
        {
            goto label_28;
        }
        
        val_43 = null;
        val_43 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_28;
        }
        
        if(CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世() == 0)
        {
            goto label_40;
        }
        
        CustomPanelConnectSceneMiniGame val_17 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_17.createPanel.SetActive(value:  false);
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  true, 丕丈丌丐下丅三七丌:  false);
        CustomPanelConnectSceneMiniGame val_18 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_18.customPanel.SetActive(value:  false);
        if(this.丏上丒专丞丑东且丞 == false)
        {
            goto label_40;
        }
        
        CustomPanelConnectSceneMiniGame val_19 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_19.searchPanel.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_20 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_20.enterPasswordPanel.SetActive(value:  false);
        goto label_47;
        label_62:
        CustomPanelConnectSceneMiniGame val_21 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        UnityEngine.Transform val_22 = val_21.gridGamesTransform.GetChild(index:  0);
        if(val_22 != null)
        {
                val_22.parent = 0;
            val_44 = this.gamesInfo;
        }
        else
        {
                0.parent = 0;
            val_44 = this.gamesInfo;
        }
        
        bool val_24 = val_44.Remove(item:  val_22.gameObject);
        UnityEngine.Object.Destroy(obj:  val_22.gameObject);
        label_47:
        CustomPanelConnectSceneMiniGame val_26 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_26.gridGamesTransform.childCount > 0)
        {
            goto label_62;
        }
        
        label_40:
        val_45 = null;
        val_45 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_46 = null;
            val_46 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        this.丕丛丟丅丂东业丆丆();
        this.serverIsNotAvalible.timer = 3f;
        this.serverIsNotAvalible.gameObject.SetActive(value:  true);
        UICamera.selectedObject = 0;
        label_28:
        this.ShowMiniGames();
        val_47 = null;
        val_47 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_48 = null;
            val_48 = null;
            WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  0);
        }
        
        if(this.loadingMapPanel != 0)
        {
                val_32 = this.loadingMapPanel;
            val_32.SetActive(value:  false);
        }
        
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
    }
    private void UpdateFilteredRoomListInvoke()
    {
        this.UpdateFilteredRoomList(丞丘与万丞三丁丘丙:  this.gameNameFilter);
    }
    private void Awake()
    {
        CustomMiniGameController.丕丆上三世丘不丂丂(丙业与丙丗丝不丈东:  this);
    }
    private void 丗丑丛且与丅七丟丏()
    {
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_72;
        System.Action val_73;
        var val_74;
        System.Action<System.Boolean> val_75;
        var val_76;
        System.Action val_77;
        var val_78;
        this.丘丛上丑丗上世专业 = true;
        if(this.世与且不丝丘业丑丘 != false)
        {
                val_67 = 1152921504624312320;
            this.gameNameFilter = System.String.alignConst;
            val_68 = null;
            val_68 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
        }
        
            CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_69 = null;
            val_69 = null;
            val_1.showSearchPanelBtn.SetActive(value:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0);
            CustomPanelConnectSceneMiniGame val_3 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_70 = 0;
            val_3.customPanel.SetActive(value:  true);
            this.下丙丗下丛丐与丞且();
            this.丏上丒专丞丑东且丞 = true;
            CustomPanelConnectSceneMiniGame val_4 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            Rilisoft.七丕丟丏三丈一丄世 val_6 = GameConnect.丑丌丛丈丅丅与不业();
            var val_68 = 0;
            val_68 = val_68 + 1;
            val_70 = 0;
        }
        else
        {
                GameConnect.下与业丒丝丕丙丘丙();
            return;
        }
        
        val_4.headCustomPanel.SetText(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[???]));
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
        CustomPanelConnectSceneMiniGame val_10 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_10.incorrectPasswordLabel.timer = -1f;
        CustomPanelConnectSceneMiniGame val_11 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_11.incorrectPasswordLabel.gameObject.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_13 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_13.gameIsfullLabel.timer = -1f;
        CustomPanelConnectSceneMiniGame val_14 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_14.gameIsfullLabel.gameObject.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世().gameObject.transform.parent = this._customPanel.gameObject.transform;
        if(this.丄东丑与丕东七丆丈 != true)
        {
                CustomPanelConnectSceneMiniGame val_21 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_23 = val_21.nameServerInput.transform.localPosition;
            this.丏丘丞丆与丕三丝丘 = val_23;
            mem[1152921538341570484] = val_23.y;
            mem[1152921538341570488] = val_23.z;
            CustomPanelConnectSceneMiniGame val_24 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_67 = 1152921505092788224;
            val_24.setPasswordInput.onSubmit.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CustomMiniGameController::业下业丛丝丑丒丂东())));
            CustomPanelConnectSceneMiniGame val_27 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_27.enterPasswordInput.onSubmit.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CustomMiniGameController::丐丛丈丅丌一丌丑丝())));
            this.丄东丑与丕东七丆丈 = true;
            CustomPanelConnectSceneMiniGame val_30 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_30.showSearchPanelBtn != 0)
        {
                CustomPanelConnectSceneMiniGame val_32 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_33 = val_32.showSearchPanelBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_33 != 0)
        {
                val_33.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CustomMiniGameController::上下丙专丌下丄丈丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
            CustomPanelConnectSceneMiniGame val_36 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_36.createRoomBtn != 0)
        {
                CustomPanelConnectSceneMiniGame val_38 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_39 = val_38.createRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_39 != 0)
        {
                val_39.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void CustomMiniGameController::丗世丌丘不丕丆丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
            CustomPanelConnectSceneMiniGame val_42 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_42.goToCreateRoomBtn != 0)
        {
                CustomPanelConnectSceneMiniGame val_44 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_45 = val_44.goToCreateRoomBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_45 != 0)
        {
                val_45.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void CustomMiniGameController::HandleCreateRoomBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
            CustomPanelConnectSceneMiniGame val_48 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_48.searchBtn != 0)
        {
                CustomPanelConnectSceneMiniGame val_50 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_51 = val_50.searchBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_51 != 0)
        {
                val_51.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void CustomMiniGameController::HandleSearchBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
            CustomPanelConnectSceneMiniGame val_54 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_54.joinRoomFromEnterPasswordBtn != 0)
        {
                CustomPanelConnectSceneMiniGame val_56 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            Rilisoft.ButtonHandler val_57 = val_56.joinRoomFromEnterPasswordBtn.GetComponent<Rilisoft.ButtonHandler>();
            if(val_57 != 0)
        {
                val_57.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void CustomMiniGameController::HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        }
        
        val_72 = null;
        val_72 = null;
        val_74 = null;
        if(((System.Delegate.Combine(a:  GameConnect.三丟丏东且与丗世专, b:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::OnJoinedRoom()))) != null) && (null != null))
        {
                val_74 = null;
            val_73 = 0;
        }
        
        GameConnect.三丟丏东且与丗世专 = val_73;
        val_76 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丝丛丅专上业与丞七, b:  new System.Action<System.Boolean>(object:  this, method:  System.Void CustomMiniGameController::丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)))) != null) && (null != null))
        {
                val_76 = null;
            val_75 = 0;
        }
        
        GameConnect.丝丛丅专上业与丞七 = val_75;
        val_78 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丐丗丈下三与丝丙业, b:  new System.Action(object:  this, method:  public System.Void CustomMiniGameController::OnReceivedRoomListUpdate()))) != null) && (null != val_78))
        {
                val_78 = null;
            val_77 = 0;
        }
        
        GameConnect.丐丗丈下三与丝丙业 = val_77;
        MapPopularityController.丅丄不丌丑世且丒七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CustomMiniGameController::与丄东世东业丏下丘()));
        this.三丅丅不丅丂业丙丄 = false;
    }
    private void 丗世丌丘不丕丆丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_14;
        this.东丅丒丛丏丄丒丞专 = System.String.alignConst;
        this.上一丝三丗且丆下丟();
        CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.headLabel, 丏业丟一东丂东丘丛:  (GameConnect.丑丌丛丈丅丅与不业() != 30) ? 1 : 0);
        CustomPanelConnectSceneMiniGame val_4 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_4.createPanel.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame val_5 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_14 = null;
        val_14 = null;
        val_5.setPasswordInput.gameObject.SetActive(value:  (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true) ? 1 : 0);
        CustomPanelConnectSceneMiniGame val_8 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        UnityEngine.Transform val_9 = val_8.nameServerInput.transform;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_17;
        }
        
        if(val_9 != null)
        {
            goto label_29;
        }
        
        label_30:
        label_29:
        val_9.localPosition = new UnityEngine.Vector3() {x = this.丏丘丞丆与丕三丝丘, y = V9.16B, z = V10.16B};
        this._selectMapPanel.SetActive(value:  true);
        this.丗丘专三丒丙丑世丗(丈三丑丛丅丑丁丁丙:  false, 丕丈丌丐下丅三七丌:  false);
        CustomPanelConnectSceneMiniGame val_10 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_10.customPanel.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_11 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_11.nameAlreadyUsedLabel.timer = -1f;
        CustomPanelConnectSceneMiniGame val_12 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_12.nameAlreadyUsedLabel.gameObject.SetActive(value:  false);
        this.丙丅七下丑丒下丆一 = true;
        return;
        label_17:
        if(val_9 != null)
        {
            goto label_29;
        }
        
        goto label_30;
    }
    private void 上一丝三丗且丆下丟()
    {
        UnityEngine.Transform val_2 = this.gameObject.transform;
        this.selectMapPanelTransform = val_2;
        UnityEngine.Vector3 val_3 = val_2.localPosition;
        this.丙一不且丑丆丆丂丆 = val_3;
        mem[1152921538342302340] = val_3.y;
        mem[1152921538342302344] = val_3.z;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                this.selectMapPanelTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        float val_9 = 768f;
        val_9 = (float)UnityEngine.Screen.width * val_9;
        val_9 = val_9 / (float)UnityEngine.Screen.height;
        val_9 = val_9 + 10f;
        this.fonMapPreview.width = UnityEngine.Mathf.RoundToInt(f:  val_9);
        this.fonMapPreview.height = 120;
        CustomPanelConnectSceneMiniGame val_8 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_8.chooseMapLabelSmall.SetActive(value:  false);
    }
    public void HandleCreateRoomBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_44;
        Rilisoft.七丕丟丏三丈一丄世 val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        if(this.三丅丅不丅丂业丙丄 == true)
        {
                return;
        }
        
        this.三丅丅不丅丂业丙丄 = true;
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        val_44 = null;
        val_44 = null;
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        if(GameConnect.丛丑世丕丌上丑丂丈 == false)
        {
            goto label_13;
        }
        
        CustomPanelConnectSceneMiniGame val_2 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_45 = 1152921505284374528;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2.nameServerInput.value)) == false)
        {
            goto label_13;
        }
        
        string val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4927");
        InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != true) ? "#Все поля должны быть заполнены" : (val_5));
        goto label_32;
        label_13:
        val_45 = 1152921505254395904;
        val_46 = null;
        val_46 = null;
        if(SceneInfoController.丄丘七三上丕世丞业 == 0)
        {
            goto label_32;
        }
        
        val_47 = null;
        val_47 = null;
        val_45 = GameConnect.丑丌丛丈丅丅与不业();
        if(((SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  val_45)) == null) || (val_10.avaliableScenes == null))
        {
            goto label_32;
        }
        
        val_45 = val_10.avaliableScenes.Find(match:  new System.Predicate<SceneInfo>(object:  this, method:  System.Boolean CustomMiniGameController::万丘一丒三丘下与且(SceneInfo 三丟东丕丄丄下下丑)));
        if(val_45 != 0)
        {
            goto label_35;
        }
        
        label_32:
        this.三丅丅不丅丂业丙丄 = false;
        return;
        label_35:
        string val_15 = val_45.gameObject.name;
        CustomPanelConnectSceneMiniGame val_16 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        string val_18 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_16.nameServerInput.value);
        val_48 = null;
        val_48 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_50;
        }
        
        var val_45 = 0;
        label_54:
        if(val_45 >= val_19.Length)
        {
            goto label_50;
        }
        
        val_45 = val_45 + 1;
        if((丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑()[0].丙丆丌丝丛丏丝丕业().Equals(value:  val_18)) == false)
        {
            goto label_54;
        }
        
        CustomPanelConnectSceneMiniGame val_22 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_22.nameAlreadyUsedLabel.timer = 3f;
        CustomPanelConnectSceneMiniGame val_23 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_23.nameAlreadyUsedLabel.gameObject.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世().SetRandomRoomName();
        this.三丅丅不丅丂业丙丄 = false;
        CustomPanelConnectSceneMiniGame val_26 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_26.tryCreateRoomAgain.gameObject.SetActive(value:  true);
        this.HandleBackButtonPressed();
        return;
        label_50:
        this.上下丟七丗业丁丒丕 = val_15;
        UnityEngine.PlayerPrefs.SetString(key:  "MapName", value:  val_15);
        UnityEngine.PlayerPrefs.SetString(key:  "MaxKill", value:  "4");
        this.SetFonLoadingWaitForReset(丛丘七丂且丟丁一丙:  this.上下丟七丗业丁丒丕, 丑一丈丐专丑且丞丅:  false);
        this.loadingMapPanel.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  1176");
        int val_29 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        val_49 = null;
        val_49 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                this.loadingMapPanel.SetActive(value:  true);
            AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  1183");
            ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
            CustomPanelConnectSceneMiniGame val_32 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            GameConnect.万丐丑上丟丞丞丏丑(丅一丞万丑专丅丅与:  val_18, 丞与一东丈世且丐丕:  val_29, 丛且丞与丕业下丏丞:  val_12.indexMap, 丗一丁丅与专丐一世:  GameConnect.丏丝一丁丛丕且丐丈(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业()), 专业丛丆丟丆丛业丆:  GameConnect.丐业丏丁业且丏上世(专业丛丆丟丆丛业丆:  val_32.setPasswordInput.value), 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丟丑业丌丙丙丑下丑:  false, 下下东且万业丞丅丒:  true, 丙丘东丏三丆丄丁丟:  0, 丐且丘丑与万丞丑丅:  0, 七专丙丏丘丌丌下与:  0, 丕丑专丗万丕与专丐:  1);
            return;
        }
        
        val_50 = null;
        val_50 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        UnityEngine.PlayerPrefs.SetString(key:  "ServerName", value:  ((System.String.IsNullOrEmpty(value:  val_18)) != true) ? "Server" : (val_18));
        UnityEngine.PlayerPrefs.SetString(key:  "PlayersLimits", value:  val_29.ToString());
        val_51 = null;
        val_51 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_94;
        }
        
        val_52 = null;
        val_52 = null;
        val_53 = null;
        val_53 = null;
        if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  val_15)) == false)
        {
            goto label_100;
        }
        
        val_54 = null;
        val_54 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_109;
        }
        
        label_110:
        label_109:
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[val_15]);
        label_94:
        val_55 = null;
        val_55 = null;
        UnityEngine.AsyncOperation val_43 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟, 丂丛丑东不丅丈一东:  0);
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        return;
        label_100:
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_109;
        }
        
        goto label_110;
    }
    private void OnJoinedRoom()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(this.世与且不丝丘业丑丘 == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆() == null)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆] == null)
        {
                return;
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "On JoinedRoom");
        if(UnityEngine.Application.isEditor != false)
        {
                val_21 = null;
            val_21 = null;
            UnityEngine.Debug.Log(message:  "On Joined Room " + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]);
        }
        
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        NotificationController.下世东丘且丏丙丐与();
        val_22 = null;
        val_22 = null;
        val_23 = null;
        val_23 = null;
        SceneInfo val_16 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.七丟丞不丆万上业丆]));
        if(val_16 != null)
        {
                this.上下丟七丗业丁丒丕 = val_16.丙且上丒不下丑下丞();
        }
        else
        {
                this.上下丟七丗业丁丒丕 = 0.丙且上丒不下丑下丞();
        }
        
        this.丝业丗上上丘丐与丗(丂丗一丆丂丌下丛丐:  val_16.丙且上丒不下丑下丞());
    }
    private void 丝业丗上上丘丐与丗(string 丂丗一丆丂丌下丛丐)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        FilterMaps val_14;
        var val_15;
        var val_16;
        ShopNGUIController.上万丐丞丂丐丌丛丆(丁丅丟丒丙丐丅与丂:  false);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start MoveToGameScene");
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Move To Game Scene="("Move To Game Scene=") + 丂丗一丆丂丌下丛丐);
        }
        
        val_8 = null;
        val_8 = null;
        与丂丏丛丞丞丒丟丄.丁丟丑丆三丆业一丅 = 0;
        与丂丏丛丞丞丒丟丄.丘专丞丄丙业上且不 = false;
        与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 = false;
        与丂丏丛丞丞丒丟丄.丗丄丏丘丅丒业丟世 = false;
        与丂丏丛丞丞丒丟丄.丗业世丆丁上万丌东 = false;
        val_9 = null;
        val_9 = null;
        GameConnect.七七丈东丅上丝丒万 = true;
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_16;
        }
        
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_12 = null;
        if((与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.ContainsKey(key:  丂丗一丆丂丌下丛丐)) == false)
        {
            goto label_22;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = 与丂丏丛丞丞丒丟丄.丄丑七与丘丆丞丞丑.Item[丂丗一丆丂丌下丛丐];
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_28;
        }
        
        goto label_27;
        label_22:
        val_14 = 0;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_28;
        }
        
        label_27:
        label_28:
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  val_14);
        label_16:
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "mapPreview clear");
        if(this.三三丆下东丏丌丅上 == 0)
        {
                this.SetFonLoadingWaitForReset(丛丘七丂且丟丁一丙:  丂丗一丆丂丌下丛丐, 丑一丈丐专丑且丞丅:  true);
        }
        
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "SetFonLoadingWaitForReset");
        this.loadingMapPanel.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  2651");
        val_15 = null;
        val_15 = null;
        与丂丏丛丞丞丒丟丄.丝丂丌丅丛丘与丌丏 = true;
        val_16 = null;
        val_16 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = false;
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  丂丗一丆丂丌下丛丐);
    }
    private void 上下丙专丌下丄丈丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.七七丁丄丗丈与东万 = true;
        CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_1.customPanel.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_2 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_2.searchInput != 0)
        {
                CustomPanelConnectSceneMiniGame val_4 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_4.searchInput.value = this.gameNameFilter;
        }
        
        CustomPanelConnectSceneMiniGame val_5 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_5.searchPanel.SetActive(value:  true);
    }
    private void 下丐丅丑丘专丑丈丑()
    {
        CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        this.东丅丒丛丏丄丒丞专 = val_1.setPasswordInput.value;
    }
    private void 丐丛丈丅丌一丌丑丝()
    {
        CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_1.enterPasswordInput.RemoveFocus();
        CustomPanelConnectSceneMiniGame val_2 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_2.enterPasswordInput.isSelected = false;
        this.Invoke(methodName:  "EnterPassInput", time:  0.1f);
    }
    private void EnterPassInput()
    {
        this.HandleJoinRoomFromEnterPasswordBtnClicked(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    public void HandleJoinRoomFromEnterPasswordBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        var val_10;
        var val_11;
        CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_9 = null;
        val_9 = null;
        if((val_1.enterPasswordInput.value.Equals(value:  this.一世东丄丗丆丘丛丂.丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七])) != false)
        {
                this.JoinToRoomPhotonAfterCheck();
            return;
        }
        
        CustomPanelConnectSceneMiniGame val_6 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_6.enterPasswordPanel.SetActive(value:  false);
        val_10 = null;
        val_10 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_11 = null;
            val_11 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        CustomPanelConnectSceneMiniGame val_8 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_8.customPanel.SetActive(value:  true);
        this.丙世丁三三丄丟丅丙 = false;
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
    }
    public void JoinToRoomPhoton(丞丘丒一上与丕丒且 世东丈丙丘下丝丌三)
    {
        var val_27;
        UnityEngine.GameObject val_28;
        var val_29;
        string val_30;
        var val_31;
        string val_32;
        if(世东丈丙丘下丝丌三 != null)
        {
                val_27 = 世东丈丙丘下丝丌三.三不万不丕丑一上与();
        }
        else
        {
                val_27 = 0.三不万不丕丑一上与();
        }
        
        if(val_27 != 世东丈丙丘下丝丌三.丄丁丗丞丏丞世丕业())
        {
            goto label_3;
        }
        
        CustomPanelConnectSceneMiniGame val_4 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_4.gameIsfullLabel.timer = 3f;
        CustomPanelConnectSceneMiniGame val_5 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_5.gameIsfullLabel.gameObject.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame val_7 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_7.incorrectPasswordLabel.timer = -1f;
        CustomPanelConnectSceneMiniGame val_8 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_28 = val_8.incorrectPasswordLabel.gameObject;
        if(val_28 != null)
        {
            goto label_50;
        }
        
        goto label_16;
        label_3:
        this.一世东丄丗丆丘丛丂 = 世东丈丙丘下丝丌三;
        val_29 = null;
        val_29 = null;
        val_30 = 世东丈丙丘下丝丌三.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七];
        if((System.String.IsNullOrEmpty(value:  val_30)) == true)
        {
            goto label_22;
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = GameConnect.丗三丅丞丏七与上七;
        if((System.String.Equals(a:  世东丈丙丘下丝丌三.丑丗三丛丛丆丟丌丆().Item[val_32], b:  GameConnect.丂万且丟丛丈与丞丏)) == false)
        {
            goto label_28;
        }
        
        label_22:
        this.JoinToRoomPhotonAfterCheck();
        return;
        label_28:
        this.丙世丁三三丄丟丅丙 = true;
        CustomPanelConnectSceneMiniGame val_16 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_16.gameIsfullLabel.timer = -1f;
        CustomPanelConnectSceneMiniGame val_17 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_17.gameIsfullLabel.gameObject.SetActive(value:  false);
        CustomPanelConnectSceneMiniGame val_19 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_19.incorrectPasswordLabel.timer = 3f;
        CustomPanelConnectSceneMiniGame val_20 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_20.incorrectPasswordLabel.gameObject.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame val_22 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_22.enterPasswordInput.value = System.String.alignConst;
        CustomPanelConnectSceneMiniGame val_23 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_23.enterPasswordPanel.SetActive(value:  true);
        CustomPanelConnectSceneMiniGame val_24 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_24.enterPasswordInput.isSelected = false;
        CustomPanelConnectSceneMiniGame val_25 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_25.enterPasswordInput.isSelected = true;
        CustomPanelConnectSceneMiniGame val_26 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_28 = val_26.customPanel;
        if(val_28 != null)
        {
            goto label_50;
        }
        
        label_16:
        label_50:
        val_28.SetActive(value:  false);
    }
    public void JoinToRoomPhotonAfterCheck()
    {
        string val_9;
        var val_10;
        var val_11;
        val_9 = this;
        if(this.三丅丅不丅丂业丙丄 == true)
        {
                return;
        }
        
        this.三丅丅不丅丂业丙丄 = true;
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        val_10 = null;
        val_10 = null;
        MainMenuController.丂不三丈丕丑丌业下 = 0;
        val_11 = null;
        val_11 = null;
        this.SetFonLoadingWaitForReset(丛丘七丂且丟丁一丙:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  this.一世东丄丗丆丘丛丂.丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆])).丙且上丒不下丑下丞(), 丑一丈丐专丑且丞丅:  false);
        this.loadingMapPanel.SetActive(value:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "loadingMapPanel  2849");
        val_9 = this.一世东丄丗丆丘丛丂.丙丆丌丝丛丏丝丕业();
        bool val_8 = 丅丒丗丑丒丙丛不丆.丂三丁业丒上丛丈丆(丅一丞万丑专丅丅与:  val_9);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
    }
    public void SetFonLoadingWaitForReset(string 丛丘七丂且丟丁一丙 = "", bool 丑一丈丐专丑且丞丅 = False)
    {
        LoadingNGUIController val_3;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "start SetFonLoadingWaitForReset");
        丑一丈丐专丑且丞丅 = 丑一丈丐专丑且丞丅;
        this.丆丆业丂专与丙丐不(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙, 丑一丈丐专丑且丞丅:  丑一丈丐专丑且丞丅);
        val_3 = this.三三丆下东丏丌丅上;
        if(val_3 != 0)
        {
                val_3 = this.三三丆下东丏丌丅上.gameObject;
            UnityEngine.Object.Destroy(obj:  val_3);
            this.三三丆下东丏丌丅上 = 0;
        }
        
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "End SetFonLoadingWaitForReset");
    }
    private void 丆丆业丂专与丙丐不(string 丛丘七丂且丟丁一丙, bool 丑一丈丐专丑且丞丅)
    {
        string val_29;
        object val_31;
        var val_32;
        UnityEngine.Texture val_33;
        var val_34;
        UnityEngine.Debug.Log(message:  "setFonLoading " + 丛丘七丂且丟丁一丙);
        if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                int val_3 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunCoop", defaultValue:  0);
            if(丑一丈丐专丑且丞丅 != false)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "CountRunCoop", value:  (UnityEngine.PlayerPrefs.GetInt(key:  "CountRunCoop", defaultValue:  0)) + 1);
        }
        
            int val_29 = this.上丁丈丛丌上不丟与;
            val_29 = val_3 - ((val_3 / val_29) * val_29);
            UnityEngine.Object val_8 = UnityEngine.Resources.Load(path:  "NoteLoadings/note_Time_Survival_"("NoteLoadings/note_Time_Survival_") + val_29);
        }
        else
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 2)
        {
                val_29 = "CountRunCompany";
            int val_10 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunCompany", defaultValue:  0);
            int val_30 = this.一丁丈丗丄丛丑丗业;
            val_30 = val_10 - ((val_10 / val_30) * val_30);
            val_31 = "NoteLoadings/note_Team_Battle_";
        }
        else
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 3)
        {
                val_29 = "CountRunHunger";
            int val_13 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunHunger", defaultValue:  0);
            int val_31 = this.七一丟丆丟丞专丆东;
            val_31 = val_13 - ((val_13 / val_31) * val_31);
            val_31 = "NoteLoadings/note_Deadly_Games_";
        }
        else
        {
                if(GameConnect.丑丌丛丈丅丅与不业() == 4)
        {
                val_29 = "CountRunFlag";
            int val_16 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunFlag", defaultValue:  0);
            int val_32 = this.丗丌上丁且专丈上世;
            val_32 = val_16 - ((val_16 / val_32) * val_32);
            val_31 = "NoteLoadings/note_Flag_Capture_";
        }
        else
        {
                val_29 = "CountRunDeadmath";
            int val_18 = UnityEngine.PlayerPrefs.GetInt(key:  "CountRunDeadmath", defaultValue:  0);
            int val_33 = this.上丞且不七丙万万丘;
            val_33 = val_18 - ((val_18 / val_33) * val_33);
            val_31 = "NoteLoadings/note_Deathmatch_";
        }
        
        }
        
        }
        
            UnityEngine.Object val_21 = UnityEngine.Resources.Load(path:  val_31 + val_33);
            if(丑一丈丐专丑且丞丅 != false)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  "CountRunDeadmath", value:  (UnityEngine.PlayerPrefs.GetInt(key:  val_29, defaultValue:  0)) + 1);
        }
        
        }
        
        UnityEngine.Object val_27 = UnityEngine.Resources.Load(path:  "LevelLoadings" + (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : ""((东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "") + "/Loading_"("/Loading_") + 丛丘七丂且丟丁一丙);
        val_32 = null;
        val_32 = null;
        if(val_27 != null)
        {
                var val_28 = (null == null) ? (val_27) : 0;
        }
        else
        {
                val_33 = 0;
        }
        
        LoadConnectScene.上三丕下一丅丘上丝 = val_33;
        val_34 = null;
        val_34 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = LoadConnectScene.上三丕下一丅丘上丝;
        LoadConnectScene.丞丗专丝丙专丂上丗 = 丛丘七丂且丟丁一丙;
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
    }
    private bool 七丛丛丁丕丄丕丅东(int 丒三东丆丕专丞且一)
    {
        null = null;
        return UnityEngine.Object.op_Inequality(x:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丐丝丟丙丛下专丐万:  this.丘丛丆丕且丂业世丌(), 丈东丅万丟丞丒不丒:  丒三东丆丕专丞且一), y:  0);
    }
    private static int 丞丐世丅丆世丘丞业(丞丘丒一上与丕丒且 三丟东丕丄丄下下丑, 丞丘丒一上与丕丒且 丒丒丄丁且丄丆丂丌)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        val_12 = 丒丒丄丁且丄丆丂丌;
        int val_3 = I2.Loc.丗丈下丕丟丟丙七丞.丑丂丕专丛丅丅不丈(丞丞丐丝丝丏丐丛丞:  UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.丗七丏三万丛丙丟业(), defaultValue:  System.String.alignConst), 丒一上业三丛丐专丘:  true);
        val_13 = null;
        val_13 = null;
        if((三丟东丕丄丄下下丑.丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丕丄丟丌丕丈丘丄丟)) == false)
        {
            goto label_9;
        }
        
        val_14 = null;
        val_14 = null;
        object val_7 = 三丟东丕丄丄下下丑.丑丗三丛丛丆丟丌丆().Item[GameConnect.丕丄丟丌丕丈丘丄丟];
        if(val_12 != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_9:
        val_15 = 0;
        if(val_12 != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        val_16 = null;
        val_17 = val_12.丑丗三丛丛丆丟丌丆();
        val_16 = null;
        if((val_17.ContainsKey(key:  GameConnect.丕丄丟丌丕丈丘丄丟)) != false)
        {
                val_18 = null;
            val_12 = val_12.丑丗三丛丛丆丟丌丆();
            val_18 = null;
            val_17 = GameConnect.丕丄丟丌丕丈丘丄丟;
            object val_11 = val_12.Item[val_17];
        }
        else
        {
                val_19 = 0;
        }
        
        if(val_15 != val_19)
        {
            goto label_26;
        }
        
        label_30:
        val_20 = 0;
        return (int)val_20;
        label_26:
        if(val_15 == val_3)
        {
                val_20 = 0;
            return (int)val_20;
        }
        
        if(val_19 != val_3)
        {
            goto label_30;
        }
        
        val_20 = 1;
        return (int)val_20;
    }
    public void UpdateFilteredRoomList(string 丞丘与万丞三丁丘丙)
    {
        var val_98;
        var val_99;
        var val_100;
        var val_102;
        var val_103;
        var val_104;
        var val_105;
        var val_106;
        int val_107;
        var val_108;
        var val_109;
        int val_110;
        var val_111;
        float val_112;
        var val_113;
        GameInfo val_114;
        float val_115;
        this.丑丐丅丟下丞三丛且.Clear();
        丞丘丒一上与丕丒且[] val_1 = 丅丒丗丑丒丙丛不丆.丘上业丗丈丌下不丑();
        bool val_2 = System.String.IsNullOrEmpty(value:  丞丘与万丞三丁丘丙);
        val_98 = 1152921505066536960;
        val_99 = 0;
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
        
        val_100 = null;
        val_100 = null;
        if((System.String.IsNullOrEmpty(value:  (null == null) ? val_1[0].丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七] : 0)) == true)
        {
            goto label_72;
        }
        
        label_13:
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
            goto label_37;
        }
        
        val_102 = null;
        val_102 = null;
        if(val_1[0].丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且] == null)
        {
            goto label_37;
        }
        
        val_103 = null;
        val_103 = null;
        if((val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.万与丅且专丕丐丑且].Equals(value:  GameConnect.丅丕专丗东东丏专世.ToString())) == true)
        {
            goto label_37;
        }
        
        val_104 = null;
        val_104 = null;
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
        val_105 = null;
        val_105 = null;
        object val_22 = val_1[0].丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆];
        if((this.七丛丛丁丕丄丕丅东(丒三东丆丕专丞且一:  21884928)) == false)
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
        
        val_106 = null;
        val_106 = null;
        if((System.String.IsNullOrEmpty(value:  val_1[0x0] + 32.丂丂丁丕专丂丏与丌().Item[GameConnect.丗三丅丞丏七与上七])) == true)
        {
            goto label_72;
        }
        
        label_55:
        this.丑丐丅丟下丞三丛且.Add(item:  val_1[0x0] + 32);
        goto label_72;
        label_46:
        if((val_1[0].丙丆丌丝丛丏丝丕业().Contains(value:  丞丘与万丞三丁丘丙)) != false)
        {
                if((((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().Length) != 36) || ((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().IndexOf(value:  "-")) != 8)) || ((val_1[0x0] + 32.丙丆丌丝丛丏丝丕业().LastIndexOf(value:  "-")) != 23))
        {
            goto label_84;
        }
        
        }
        
        label_72:
        val_99 = 1;
        label_4:
        if(val_99 < val_1.Length)
        {
            goto label_86;
        }
        
        this.丄丈丟丙不世与丅丈 = 50;
        if(GameConnect.丑丌丛丈丅丅与不业() == 30)
        {
                this.丑丐丅丟下丞三丛且.Sort(comparison:  new System.Comparison<丞丘丒一上与丕丒且>(object:  0, method:  static System.Int32 CustomMiniGameController::丞丐世丅丆世丘丞业(丞丘丒一上与丕丒且 三丟东丕丄丄下下丑, 丞丘丒一上与丕丒且 丒丒丄丁且丄丆丂丌)));
        }
        
        val_107 = this.丄丈丟丙不世与丅丈;
        if(this.丑丐丅丟下丞三丛且.Count >= val_107)
        {
            goto label_94;
        }
        
        val_107 = this.丑丐丅丟下丞三丛且.Count;
        this.丄丈丟丙不世与丅丈 = val_107;
        goto label_94;
        label_102:
        if(this.gamesInfo != null)
        {
                val_108 = this.gamesInfo.Count;
        }
        else
        {
                val_108 = 0.Count;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gamesInfo.Item[val_108 - 1]);
        if(this.gamesInfo != null)
        {
                val_109 = this.gamesInfo.Count;
        }
        else
        {
                val_109 = 0.Count;
        }
        
        this.gamesInfo.RemoveAt(index:  val_109 - 1);
        val_107 = this.丄丈丟丙不世与丅丈;
        label_94:
        if(val_107 < this.gamesInfo.Count)
        {
            goto label_102;
        }
        
        val_110 = this.丄丈丟丙不世与丅丈;
        val_111 = public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::get_Count();
        if(val_110 <= this.gamesInfo.Count)
        {
            goto label_104;
        }
        
        float val_103 = (float)UnityEngine.Screen.width;
        val_103 = val_103 / (float)UnityEngine.Screen.height;
        this.丕专丗万上丁世丝丁 = (val_103 < 0) ? 3 : 4;
        val_98 = 1152921505055993856;
        CustomPanelConnectSceneMiniGame val_53 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        UnityEngine.Vector2 val_54 = val_53.fonGames.localSize;
        int val_55 = this.丕专丗万上丁世丝丁 + (this.丕专丗万上丁世丝丁 << 2);
        val_55 = val_55 << 1;
        val_54.x = val_54.x - (float)val_55;
        val_112 = (float)this.丕专丗万上丁世丝丁;
        val_54.x = val_54.x / val_112;
        this.丒丙丘丟且丈丗且丞 = val_54.x;
        if(this.丄丈丟丙不世与丅丈 <= this.gamesInfo.Count)
        {
            goto label_110;
        }
        
        CustomPanelConnectSceneMiniGame val_57 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_113 = 1;
        goto label_115;
        label_138:
        CustomPanelConnectSceneMiniGame val_58 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        UnityEngine.GameObject val_59 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_58.gameInfoItemPrefab);
        string val_61 = "GameInfo_" + this.gamesInfo.Count;
        if(val_59 != null)
        {
                val_59.name = val_61;
        }
        else
        {
                0.name = val_61;
        }
        
        CustomPanelConnectSceneMiniGame val_63 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_59.transform.SetParent(parent:  val_63.gridGamesTransform, worldPositionStays:  false);
        GameInfo val_64 = val_59.GetComponent<GameInfo>();
        UnityEngine.Vector2 val_65 = val_64.mapTexture.localSize;
        val_65.x = this.丒丙丘丟且丈丗且丞 / val_65.x;
        this.丐与丒丐七丙丌三不 = val_65.x;
        UnityEngine.Vector2 val_66 = val_64.mapTexture.localSize;
        float val_104 = this.丐与丒丐七丙丌三不;
        val_104 = val_66.y * val_104;
        this.丏丝丕丈丑丙丄丁业 = val_104;
        val_112 = 0f;
        val_59.transform.GetChild(index:  0).transform.localScale = new UnityEngine.Vector3() {x = 0f, y = val_112, z = 0f};
        this.gamesInfo.Add(item:  val_59);
        CustomPanelConnectSceneMiniGame val_70 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_113 = 0;
        label_115:
        val_70.gameInfoItemPrefab.SetActive(value:  false);
        label_110:
        if(this.丄丈丟丙不世与丅丈 > this.gamesInfo.Count)
        {
            goto label_138;
        }
        
        CustomPanelConnectSceneMiniGame val_72 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_72.gameInfoItemPrefab.activeSelf != false)
        {
                CustomPanelConnectSceneMiniGame val_74 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_74.gameInfoItemPrefab.SetActive(value:  false);
        }
        
        CustomPanelConnectSceneMiniGame val_75 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_111 = public UIGrid UnityEngine.Component::GetComponent<UIGrid>();
        if((val_75.gridGames.GetComponent<UIGrid>()) != null)
        {
                val_76.cellWidth = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
            float val_105 = this.丏丝丕丈丑丙丄丁业;
            val_112 = this.七与丌三丙丈丅丕丕;
            val_105 = val_105 + val_112;
            val_76.cellHeight = val_105;
            val_110 = this.丕专丗万上丁世丝丁;
        }
        else
        {
                mem[40] = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
            val_76.cellHeight = this.丏丝丕丈丑丙丄丁业 + this.七与丌三丙丈丅丕丕;
            val_110 = this.丕专丗万上丁世丝丁;
        }
        
        val_76.maxPerLine = val_110;
        label_104:
        CustomPanelConnectSceneMiniGame val_80 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        CustomPanelConnectSceneMiniGame val_82 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_114 = 0;
        UnityEngine.Vector2 val_84 = val_82.scrollGames.GetComponent<UIPanel>().GetViewSize();
        if(this.丄丈丟丙不世与丅丈 >= 1)
        {
                var val_106 = 0;
            do
        {
            val_110 = this.gamesInfo.Item[0];
            val_114 = val_110.GetComponent<GameInfo>();
            this.丆丝丁东丆与上上不(专专丂丝且万丂不世:  val_114, 丞世不丒下上上丝丑:  0);
            val_106 = val_106 + 1;
        }
        while(val_106 < this.丄丈丟丙不世与丅丈);
        
        }
        
        CustomPanelConnectSceneMiniGame val_87 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_115 = val_112 + val_112;
        if(val_115 >= 0)
        {
                if(this.上丐丐丆丝丕丟一丁 == true)
        {
                return;
        }
        
        }
        
        CustomPanelConnectSceneMiniGame val_88 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        CustomPanelConnectSceneMiniGame val_90 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_92 = val_90.gridGames.transform.localPosition;
        val_115 = val_92.y;
        CustomPanelConnectSceneMiniGame val_93 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_110 = val_93.gridGames.transform;
        UnityEngine.Vector3 val_95 = val_110.localPosition;
        float val_107 = (float)this.丕专丗万上丁世丝丁;
        val_107 = val_107 * 0.5f;
        float val_96 = this.丒丙丘丟且丈丗且丞 + this.七与丌三丙丈丅丕丕;
        val_107 = val_107 + (-0.5f);
        val_96 = -(val_96 * val_107);
        val_88.gridGames.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        CustomPanelConnectSceneMiniGame val_97 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_97.scrollGames.ResetPosition();
        this.上丐丐丆丝丕丟一丁 = true;
    }
    private void 丆丝丁东丆与上上不(GameInfo 专专丂丝且万丂不世, int 丞世不丒下上上丝丑)
    {
        int val_26;
        string val_27;
        var val_28;
        var val_29;
        var val_30;
        val_26 = 丞世不丒下上上丝丑;
        if(专专丂丝且万丂不世 == 0)
        {
                return;
        }
        
        专专丂丝且万丂不世.index = val_26;
        UnityEngine.GameObject val_3 = 专专丂丝且万丂不世.gameObject;
        if(this.丑丐丅丟下丞三丛且.Count > val_26)
        {
                val_3.SetActive(value:  true);
            val_26 = this.丑丐丅丟下丞三丛且.Item[val_26];
            val_27 = val_26.丙丆丌丝丛丏丝丕业();
            if((val_27.Length == 36) && ((val_27.IndexOf(value:  "-")) == 8))
        {
                if((val_27.LastIndexOf(value:  "-")) == 23)
        {
                val_27 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0088");
        }
        
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  专专丂丝且万丂不世.serverNameLabel, 丏业丟一东丂东丘丛:  true);
            专专丂丝且万丂不世.serverNameLabel.text = val_27;
            专专丂丝且万丂不世.countPlayersLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  val_26.三不万不丕丑一上与(), arg1:  val_26.丄丁丗丞丏丞世丕业());
            val_28 = null;
            val_28 = null;
            string val_26 = GameConnect.丂万且丟丛丈与丞丏;
            bool val_15 = System.String.Equals(a:  val_26.丑丗三丛丛丆丟丌丆().Item[GameConnect.丗三丅丞丏七与上七], b:  val_26);
            val_26 = val_15;
            专专丂丝且万丂不世.openSprite.SetActive(value:  val_26);
            专专丂丝且万丂不世.closeSprite.SetActive(value:  (~val_15) & 1);
            var val_18 = (GameConnect.丑丌丛丈丅丅与不业() == 30) ? 1 : 0;
            val_18 = val_15 & val_18;
            if(val_18 == true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  专专丂丝且万丂不世.serverNameLabel, 丏业丟一东丂东丘丛:  false);
        }
        
            val_29 = null;
            val_29 = null;
            val_30 = null;
            val_30 = null;
            SceneInfo val_22 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  System.Int32.Parse(s:  val_26.丂丂丁丕专丂丏与丌().Item[GameConnect.七丟丞不丆万上业丆]));
            专专丂丝且万丂不世.mapNameLabel.SetText(丕丗丘丑丛与丑业丒:  val_22.七丛一丛专七丈丅专());
            专专丂丝且万丂不世.roomInfo = val_26;
            UnityEngine.Texture val_25 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_22.丙且上丒不下丑下丞());
            专专丂丝且万丂不世.丏丛与业丆丝世丒丗(万丁世丗丒丐丙丄丆:  val_22);
            return;
        }
        
        val_3.SetActive(value:  false);
    }
    private UnityEngine.Texture 丂丐业丘丑丒三万丒(string 七丆丂丂下丈且丟世)
    {
        var val_7;
        if((this.下丒丏丙一不七丕丏.ContainsKey(key:  七丆丂丂下丈且丟世)) != false)
        {
                val_7 = this.下丒丏丙一不七丕丏.Item[七丆丂丂下丈且丟世];
            return (UnityEngine.Texture);
        }
        
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Loading_{1}", arg0:  this.丂丝丕三东丏三且下, arg1:  七丆丂丂下丈且丟世));
        val_7 = 0;
        if( == 0)
        {
                return (UnityEngine.Texture);
        }
        
        this.下丒丏丙一不七丕丏.Add(key:  七丆丂丂下丈且丟世, value:  null);
        return (UnityEngine.Texture);
    }
    public void HandleSearchBtnClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        string val_8;
        CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.customPanel, 丏业丟一东丂东丘丛:  true);
        CustomPanelConnectSceneMiniGame val_2 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        if(val_2.searchInput != 0)
        {
                CustomPanelConnectSceneMiniGame val_4 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            val_8 = val_4.searchInput.value;
            this.gameNameFilter = val_8;
        }
        else
        {
                val_8 = this.gameNameFilter;
        }
        
        this.UpdateFilteredRoomList(丞丘与万丞三丁丘丙:  val_8);
        CustomPanelConnectSceneMiniGame val_6 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        val_6.scrollGames.ResetPosition();
        CustomPanelConnectSceneMiniGame val_7 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7.searchPanel, 丏业丟一东丂东丘丛:  false);
        this.七七丁丄丗丈与东万 = false;
    }
    private void 丗丘专三丒丙丑世丗(bool 丈三丑丛丅丑丁丁丙 = True, bool 丕丈丌丐下丅三七丌 = False)
    {
        var val_67;
        UnityEngine.GameObject val_68;
        SceneInfoController val_69;
        var val_70;
        System.Collections.Generic.List<SceneInfo> val_71;
        UnityEngine.GameObject val_72;
        var val_73;
        var val_74;
        string val_75;
        string val_76;
        int val_77;
        UIPanel val_1 = this.scrollViewSelectMapTransform.GetComponent<UIPanel>();
        this.丌业业丛丞业七丘万 = true;
        val_67 = null;
        val_67 = null;
        int val_2 = SceneInfoController.丄丘七三上丕世丞业.丕三与丌丂业丄世上();
        val_68 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.grid, 丏业丟一东丂东丘丛:  (GameConnect.丑丌丛丈丅丅与不业() != 30) ? 1 : 0);
        val_69 = SceneInfoController.丄丘七三上丕世丞业;
        if(val_69 == 0)
        {
            goto label_19;
        }
        
        val_70 = null;
        val_70 = null;
        val_69 = SceneInfoController.丄丘七三上丕世丞业.丒业东下专丐七与三(丐丝丟丙丛下专丐万:  GameConnect.丑丌丛丈丅丅与不业());
        if(val_69 == null)
        {
            goto label_19;
        }
        
        if((与丂丏丛丞丞丒丟丄.下与丐东丟东丄丘丑() == true) || (ExperienceController.丞丞丘业东丙丏七丌() >= 2))
        {
            goto label_25;
        }
        
        val_71 = System.Linq.Enumerable.ToList<SceneInfo>(source:  丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<SceneInfo>(丅东丗丒丄东丛业丄:  val_7.avaliableScenes, 丂丆且一丛丙丑七丒:  0));
        if(丈三丑丛丅丑丁丁丙 == true)
        {
            goto label_28;
        }
        
        goto label_41;
        label_19:
        UnityEngine.Debug.LogError(message:  "modeInfo == null");
        return;
        label_25:
        val_71 = val_7.avaliableScenes;
        if(丈三丑丛丅丑丁丁丙 == false)
        {
            goto label_41;
        }
        
        label_28:
        if((GameConnect.丑丌丛丈丅丅与不业() != 14) && (GameConnect.丑丌丛丈丅丅与不业() != 17))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 20)
        {
                MapPreviewController val_18 = this.grid.transform.GetChild(index:  0).gameObject.GetComponent<MapPreviewController>();
            val_18.curSceneInfo = 0;
            val_18.NameMapLbl.GetComponent<SetHeadLabelText>().SetText(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2463"));
            val_72 = val_18.bottomPanel;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_72, 丏业丟一东丂东丘丛:  false);
            val_18.mapID = 0;
            val_18.sceneMapName = "Random";
        }
        
        }
        
        label_41:
        val_73 = 0;
        goto label_122;
        label_131:
        SceneInfo val_21 = val_71.Item[0];
        UnityEngine.Transform val_22 = this.grid.transform;
        if(丈三丑丛丅丑丁丁丙 != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 14)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
            goto label_63;
        }
        
        }
        
        }
        
        if(val_22 != null)
        {
            goto label_125;
        }
        
        label_126:
        label_125:
        UnityEngine.GameObject val_27 = val_22.GetChild(index:  0 + val_73).gameObject;
        if(val_27.activeSelf != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_27, 丏业丟一东丂东丘丛:  true);
        }
        
        val_72 = val_27.GetComponent<MapPreviewController>();
        if(val_29.bottomPanel.activeSelf != true)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.bottomPanel, 丏业丟一东丂东丘丛:  true);
        }
        
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  val_29.业丞丟万不丄丂丘丑)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.bottomPanel, 丏业丟一东丂东丘丛:  false);
        }
        
        val_29.curSceneInfo = val_21;
        UnityEngine.Texture val_34 = this.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_21.丙且上丒不下丑下丞());
        val_29.NameMapLbl.GetComponent<SetHeadLabelText>().SetText(丕丗丘丑丛与丑业丒:  val_21.七丛一丛专七丈丅专());
        val_72.丏丛与业丆丝世丒丗();
        if(val_21 != null)
        {
                val_29.mapID = val_21.indexMap;
            val_29.sceneMapName = val_21.丙且上丒不下丑下丞();
        }
        else
        {
                val_29.mapID = 4194311;
            val_29.sceneMapName = val_21.丙且上丒不下丑下丞();
        }
        
        if(val_21.AvaliableWeapon == 2)
        {
            goto label_89;
        }
        
        if(val_21.AvaliableWeapon != 1)
        {
            goto label_90;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.milee, 丏业丟一东丂东丘丛:  true);
        val_74 = val_29.milee.GetComponent<UILabel>();
        val_75 = "Key_0096";
        goto label_111;
        label_89:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.milee, 丏业丟一东丂东丘丛:  true);
        val_74 = val_29.milee.GetComponent<UILabel>();
        val_75 = "Key_0949";
        goto label_111;
        label_90:
        if(GameConnect.丑丌丛丈丅丅与不业() != 14)
        {
            goto label_105;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.milee, 丏业丟一东丂东丘丛:  true);
        val_74 = val_29.milee.GetComponent<UILabel>();
        val_75 = "Key_3498";
        goto label_111;
        label_105:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_114;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.milee, 丏业丟一东丂东丘丛:  true);
        val_74 = val_29.milee.GetComponent<UILabel>();
        val_75 = "Key_1421";
        label_111:
        val_74.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_75);
        label_129:
        if(val_72.isActiveAndEnabled != false)
        {
                val_72.丅丂丙丁业丅丆且世();
        }
        
        val_73 = 1;
        goto label_122;
        label_63:
        var val_48 = (GameConnect.丑丌丛丈丅丅与不业() != 20) ? 1 : 0;
        if(val_22 != null)
        {
            goto label_125;
        }
        
        goto label_126;
        label_114:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.milee, 丏业丟一东丂东丘丛:  false);
        goto label_129;
        label_122:
        if(val_73 < val_71.Count)
        {
            goto label_131;
        }
        
        if(val_1 != 0)
        {
                val_1.SetDirty();
            val_1.Refresh();
        }
        else
        {
                val_1.SetDirty();
            val_1.Refresh();
        }
        
        val_1.ResetAndUpdateAnchors();
        if(this.selectMap != 0)
        {
                val_76 = this.selectMap.sceneMapName;
        }
        
        this.丆丒丆丂与丈上丏丕(丞丁丑丏丄丏七丂不:  System.String.__il2cppRuntimeField_static_fields);
        if(丈三丑丛丅丑丁丁丙 != false)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 14)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 17)
        {
            goto label_146;
        }
        
        }
        
        }
        
        label_174:
        int val_54 = 0 + val_71.Count;
        val_77 = val_54;
        goto label_147;
        label_157:
        UnityEngine.GameObject val_57 = this.grid.transform.GetChild(index:  val_77).gameObject;
        if(val_57.activeSelf != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_57, 丏业丟一东丂东丘丛:  false);
        }
        
        val_77 = val_77 + 1;
        label_147:
        if(val_77 < this.grid.transform.childCount)
        {
            goto label_157;
        }
        
        UIGrid val_62 = this.grid.GetComponent<UIGrid>();
        float val_68 = 15f;
        val_68 = this.丒丙丘丟且丈丗且丞 + val_68;
        val_62.cellWidth = val_68;
        UIGrid val_63 = this.grid.GetComponent<UIGrid>();
        val_63.cellHeight = 225f;
        UIGrid val_64 = this.grid.GetComponent<UIGrid>();
        val_64.maxPerLine = UnityEngine.Mathf.Min(a:  val_54, b:  3);
        UIGrid val_65 = this.grid.GetComponent<UIGrid>();
        this.丛丗丆丏丟丞东丝丒 = true;
        this.丟丗不丈七下丗与三 = this.丏丝丕丈丑丙丄丁业;
        if(丕丈丌丐下丅三七丌 != false)
        {
                val_68 = this._selectMapPanel;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_68, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丌业业丛丞业七丘万 = false;
        return;
        label_146:
        var val_67 = (GameConnect.丑丌丛丈丅丅与不业() != 20) ? 1 : 0;
        goto label_174;
    }
    private void 丒专丏丄与与丏丆丌(string 丛丘七丂且丟丁一丙 = "", bool 丑一丈丐专丑且丞丅 = False)
    {
        LoadingNGUIController val_3;
        丑一丈丐专丑且丞丅 = 丑一丈丐专丑且丞丅;
        this.丆丆业丂专与丙丐不(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙, 丑一丈丐专丑且丞丅:  丑一丈丐专丑且丞丅);
        val_3 = this.三三丆下东丏丌丅上;
        if(val_3 != 0)
        {
                val_3 = this.三三丆下东丏丌丅上.gameObject;
            UnityEngine.Object.Destroy(obj:  val_3);
            this.三三丆下东丏丌丅上 = 0;
        }
        
        this.上丌万丙丝世三丌丝(丛丘七丂且丟丁一丙:  丛丘七丂且丟丁一丙);
    }
    private void 上丌万丙丝世三丌丝(string 丛丘七丂且丟丁一丙)
    {
        var val_9;
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindowNoShowNext();
        LoadingNGUIController val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        this.三三丆下东丏丌丅上 = val_4;
        val_4.SceneToLoad = 丛丘七丂且丟丁一丙;
        val_9 = null;
        val_9 = null;
        this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  LoadConnectScene.上三丕下一丅丘上丝);
        this.三三丆下东丏丌丅上.transform.parent = this.loadingMapPanel.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        this.三三丆下东丏丌丅上.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        this.三三丆下东丏丌丅上.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  0);
    }
    private void 丆丒丆丂与丈上丏丕(string 丞丁丑丏丄丏七丂不)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_23;
        var val_25;
        var val_29;
        val_19 = this;
        val_20 = null;
        val_20 = null;
        CustomMiniGameController.丑业业业丒丏丈丞下 = 丞丁丑丏丄丏七丂不;
        val_21 = this.grid.transform.GetChild(index:  0);
        if((System.String.IsNullOrEmpty(value:  CustomMiniGameController.丑业业业丒丏丈丞下)) != false)
        {
                val_21.GetComponent<UIToggle>().value = true;
            this.selectMap = this.grid.transform.GetChild(index:  0).GetComponent<MapPreviewController>();
            return;
        }
        
        System.Collections.IEnumerator val_9 = this.grid.transform.GetEnumerator();
        goto label_27;
        label_35:
        var val_21 = 0;
        val_21 = val_21 + 1;
        object val_11 = val_9.Current;
        MapPreviewController val_14 = 0.GetComponent<MapPreviewController>();
        val_23 = null;
        val_23 = null;
        if((CustomMiniGameController.丑业业业丒丏丈丞下.Equals(value:  val_14.sceneMapName)) == false)
        {
            goto label_27;
        }
        
        goto label_28;
        label_27:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_9.MoveNext() == true)
        {
            goto label_35;
        }
        
        val_25 = 0;
        val_21 = 0;
        goto label_40;
        label_28:
        0.GetComponent<UIToggle>().value = true;
        val_25 = 0;
        val_21 = 0;
        this.selectMap = 0.GetComponent<MapPreviewController>();
        label_40:
        val_19 = val_9;
        if(val_19 != null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_19.Dispose();
        }
        
        if( == 1)
        {
            goto label_58;
        }
        
        if((null == null) || (148 == 148))
        {
            goto label_64;
        }
        
        label_63:
        label_64:
        val_29 = null;
        val_29 = null;
        CustomMiniGameController.丑业业业丒丏丈丞下 = "";
        return;
        label_58:
        if(null != null)
        {
            goto label_63;
        }
        
        goto label_64;
    }
    private void 丕丛丟丅丂东业丆丆()
    {
        UnityEngine.Transform val_3;
        var val_4;
        val_3 = this;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_3 = this.selectMapPanelTransform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_4 = val_2.x;
            if(val_3 != null)
        {
            goto label_7;
        }
        
        }
        else
        {
                if(S8 >= 0)
        {
                return;
        }
        
        }
        
        label_7:
        this.selectMapPanelTransform.localPosition = new UnityEngine.Vector3() {x = this.丙一不且丑丆丆丂丆, y = V8.16B, z = V9.16B};
    }
    public void OnReceivedRoomListUpdate()
    {
        var val_3;
        if(this.世与且不丝丘业丑丘 == false)
        {
                return;
        }
        
        if(this.丏上丒专丞丑东且丞 != false)
        {
                CustomPanelConnectSceneMiniGame val_1 = CustomPanelConnectSceneMiniGame.丑七不且上丗丁一世();
            if(val_1.customPanel.activeSelf == false)
        {
                return;
        }
        
        }
        
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        this.Invoke(methodName:  "UpdateFilteredRoomListInvoke", time:  0.03f);
    }
    public CustomMiniGameController()
    {
        this.丏丝丕丈丑丙丄丁业 = 1f;
        this.丐与丒丐七丙丌三不 = 1f;
        this.丒丙丘丟且丈丗且丞 = 282f;
        this.七与丌三丙丈丅丕丕 = 10f;
        this.上丞且不七丙万万丘 = 5;
        this.丗丌上丁且专丈上世 = 5;
        this.七一丟丆丟丞专丆东 = 5;
        this.丕专丗万上丁世丝丁 = ;
        this.丄丈丟丙不世与丅丈 = ;
        this.一丁丈丗丄丛丑丗业 = 21474836485;
        this.上丁丈丛丌上不丟与 = 5;
        this.丂丝丕三东丏三且下 = System.String.alignConst;
        this.丑丐丅丟下丞三丛且 = new System.Collections.Generic.List<丞丘丒一上与丕丒且>();
        this.gamesInfo = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.下丒丏丙一不七丕丏 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        this.上丁丆丆三且丅丕丒 = 1;
        this.东丅丒丛丏丄丒丞专 = "";
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  10000f);
        this.丙一不且丑丆丆丂丆 = val_5;
        mem[1152921538348822740] = val_5.y;
        mem[1152921538348822744] = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.丏丘丞丆与丕三丝丘 = val_6;
        mem[1152921538348822804] = val_6.y;
        mem[1152921538348822808] = val_6.z;
    }
    private static CustomMiniGameController()
    {
        CustomMiniGameController.丑业业业丒丏丈丞下 = "";
    }
    private void 业下业丛丝丑丒丂东()
    {
        this.下丐丅丑丘专丑丈丑();
    }
    private bool 万丘一丒三丘下与且(SceneInfo 三丟东丕丄丄下下丑)
    {
        if(this.selectMap != null)
        {
                return System.String.op_Equality(a:  三丟东丕丄丄下下丑.丙且上丒不下丑下丞(), b:  this.selectMap.sceneMapName);
        }
        
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.丙且上丒不下丑下丞(), b:  this.selectMap.sceneMapName);
    }

}
