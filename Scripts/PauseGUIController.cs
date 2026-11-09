using UnityEngine;
internal sealed class PauseGUIController : MonoBehaviour
{
    // Fields
    private UIGrid _buttonsGrid;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UIPanel 丆七东一丐三业且万;
    private float 东丐丐丕世丏万东丑;
    private Rilisoft.专丕丝丏丒一一万丏<PauseNGUIController> 丗丅一丟专与一丟丌;
    private bool 一丛东丛丏丘丘丟丄;
    private static PauseGUIController <不丁丄七丛不丆丁丕>k__BackingField;
    private UnityEngine.Transform _battlePassHolder;
    private UnityEngine.Transform _pixelPassHolder;
    private PGCompany.PixelPass.PixelPassTasksInGameUI 丈丟丂七丛丟三丛丝;
    private UnityEngine.GameObject customPrivateGameInfo;
    private UnityEngine.GameObject roomNameObj;
    private UILabel roomNameLabel;
    private UIButton _btnResume;
    private UIButton _btnExit;
    private UIButton _btnFinish;
    private UIButton _btnSettings;
    private UIButton _btnBank;
    private UnityEngine.GameObject _btnsPanel;
    private PenaltyConfirmDialog _confirmDialogPanel;
    private Rilisoft.PrefabHandler _settingsPrefab;
    private UIButton _guiVisibilityButton;
    
    // Properties
    internal static PauseGUIController 丆丕丝丒不丙且丐丗 { get; set; }
    public PauseNGUIController 丛上丛丒业一丞丌万 { get; }
    private UIPanel 丛丁丐丛丝丟业丁丒 { get; }
    public bool 业万丁丏下且三丆丝 { get; }
    private bool 业丝专世业上丒丒丘 { get; }
    
    // Methods
    internal static PauseGUIController 丑七不且上丗丁一世()
    {
        return (PauseGUIController)PauseGUIController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(PauseGUIController 丙业与丙丗丝不丈东)
    {
        PauseGUIController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public PauseNGUIController get_SettingsPanel()
    {
        Rilisoft.专丕丝丏丒一一万丏<PauseNGUIController> val_4 = this.丗丅一丟专与一丟丌;
        if(val_4 != null)
        {
                return val_3.世三丞丅丑丌丈丈一();
        }
        
        Rilisoft.专丕丝丏丒一一万丏<PauseNGUIController> val_3 = null;
        val_4 = val_3;
        val_3 = new Rilisoft.专丕丝丏丒一一万丏<PauseNGUIController>(丆万丕丏与丈与丒丗:  this._settingsPrefab.ResourcePath, 丆丏七丟不丒与七专:  InGameGUI.丙丞专丌丁丞与不丐.SubpanelsContainer);
        this.丗丅一丟专与一丟丌 = val_4;
        if(val_4 != null)
        {
                return val_3.世三丞丅丑丌丈丈一();
        }
        
        return val_3.世三丞丅丑丌丈丈一();
    }
    private UIPanel 一东丘业丌丌丐七东()
    {
        if(this.丆七东一丐三业且万 != 0)
        {
                return (UIPanel)this.丆七东一丐三业且万;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return (UIPanel)this.丆七东一丐三业且万;
        }
        
        this.丆七东一丐三业且万 = InGameGUI.丙丞专丌丁丞与不丐.GetComponent<UIPanel>();
        return (UIPanel)this.丆七东一丐三业且万;
    }
    public bool get_IsPaused()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    private bool 丌丄丂上丘丂丘丑世()
    {
        InGameGUI val_3 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
        val_3 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        if(val_3 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return 业丘世丆且世丄丟丈();
        }
        
        return 业丘世丆且世丄丟丈();
    }
    public void OnGuiVisibilityButtonClicked()
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_2 = new object[1];
            val_2[0] = this.GetType();
            UnityEngine.Debug.LogFormat(format:  "{0}.OnGuiVisibilityButtonClicked()", args:  val_2);
        }
        
        if(PGCompany.专一万七业一丟丛丕.丑七不且上丗丁一世().东丞丟万一世且业丅() != false)
        {
                if(this.一东丘业丌丌丐七东() != 0)
        {
                UIPanel val_8 = this.一东丘业丌丌丐七东();
        }
        
        }
        
        this.丗丟万丂丘丈专丄丂();
    }
    private void 业一万丏世丑丆丙丐()
    {
        ButtonClickSound val_6 = ButtonClickSound.丆丕丝丒不丙且丐丗;
        val_6.PlayClick();
        if(GameConnect.丆丕丒与丂七与下上() == false)
        {
                return;
        }
        
        val_6 = CheckpointController.丄丘七三上丕世丞业;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = CheckpointController.丄丘七三上丕世丞业;
        if(CheckpointController.丄丘七三上丕世丞业.runFinishedOnce == false)
        {
                return;
        }
        
        val_6 = MiniGamesController.丑七不且上丗丁一世();
        if(val_6 == 0)
        {
                return;
        }
        
        MiniGamesController.丑七不且上丗丁一世().FinishGame();
    }
    internal void 丂丅丆专七丛丆丄丟()
    {
        var val_3;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_4 != null)
        {
                val_4 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_4 == null)
        {
                val_4 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = val_4.丌不丅不丞东万专专();
            if((val_1.HasValue.丙东专丂世丈丏丁丂() == 2) && (((-455155064) & 1) != 0))
        {
                val_5 = null;
            val_5 = null;
            GameConnect.丈丝丂丐丟万丙丑丕.丅不东丁下丒丆东下();
        }
        
        }
        
        this.丂丄丝三且世丞丌丟();
    }
    private void 丂丄丝三且世丞丌丟()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        与丂丏丛丞丞丒丟丄.丄不丌不丐丂三东丘 = false;
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._confirmDialogPanel, 丏业丟一东丂东丘丛:  false);
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            Rilisoft.一丟专且三万丞丁丂.业丞丆下一丐一三上(丒万丟丅丌丝丟下下:  DungeonsController.丄丘七三上丕世丞业.dungeonDifficulty, 丛东与丑丌丗东丕丗:  3, 七丆丂丂下丈且丟世:  丙且上丒不下丑下丞());
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.playerMoveC != 0)
        {
                SetActive(value:  true);
        }
        
        }
        
        GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "");
    }
    private void 丆一东世业万且丕东()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.与丐丛业丟丌丑丈丞(下下东且万业丞丅丒:  false);
    }
    private void 与丐丛业丟丌丑丈丞(bool 下下东且万业丞丅丒)
    {
        if(this._confirmDialogPanel == 0)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this._btnsPanel.SetActive(value:  (~下下东且万业丞丅丒) & 1);
        this._confirmDialogPanel.gameObject.SetActive(value:  下下东且万业丞丅丒);
        if(下下东且万业丞丅丒 == false)
        {
                return;
        }
        
        this._confirmDialogPanel.丑专丈丙丄专东世丒();
    }
    private void 专丅丆且一丌丅丞世()
    {
        Rilisoft.七丕丟丏三丈一丄世 val_8;
        var val_9;
        var val_10;
        var val_11;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_13;
        val_8 = 1152921505286238208;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_10 = null;
            val_10 = null;
            typeof(NetworkStartTable).__il2cppRuntimeField_71 = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                val_8 = GameConnect.丑丌丛丈丅丅与不业();
            if((System.Linq.Enumerable.Any<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  val_8, 丞丁丑丏丄丏七丂不:  0))) != false)
        {
                val_13 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_13 != null)
        {
                val_13 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_13 == null)
        {
                val_13 = 0;
        }
        
            val_8 = val_13.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_8 = 0;
        }
        
            Rilisoft.一丟专且三万丞丁丂.世东不丅丄丁东东丛(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丑丐丗三丒世丏东丅:  0);
        }
        
        }
        
        this.丂丄丝三且世丞丌丟();
    }
    private void 丕不专丂丘丑丂丂丄()
    {
        this.丆一东世业万且丕东();
    }
    private void Awake()
    {
        var val_22;
        var val_23;
        PauseGUIController.<不丁丄七丛不丆丁丕>k__BackingField = this;
        val_22 = null;
        val_22 = null;
        if(GameConnect.东丒丗丄一丐且丆丝 != false)
        {
                if(this.customPrivateGameInfo != 0)
        {
                this.customPrivateGameInfo.SetActive(value:  true);
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        if(GameConnect.丛丑世丕丌上丑丂丈 != true)
        {
                if(GameConnect.东丒丗丄一丐且丆丝 == false)
        {
            goto label_24;
        }
        
        }
        
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null) && (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘() != null))
        {
                if(this.roomNameLabel != 0)
        {
                this.roomNameObj.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.roomNameLabel, 丕丗丘丑丛与丑业丒:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().东丙上东业丆不丟丘());
        }
        
        }
        
        label_24:
        this._btnResume.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::丐丗丟丛一丟东丟丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this._btnExit.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::丏丝一三东丞丐三下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this._btnFinish.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::上丑丒丝且丈丞丌丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this._confirmDialogPanel != 0)
        {
                this._confirmDialogPanel.且丕丈与丒丑丑业丝 = new System.Action(object:  this, method:  System.Void PauseGUIController::专丅丆且一丌丅丞世());
            this._confirmDialogPanel.丆上丙丝上上业业且 = new System.Action(object:  this, method:  System.Void PauseGUIController::丕不专丂丘丑丂丂丄());
        }
        
        if(this._btnBank != 0)
        {
                this._btnBank.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::丄丗东上丝丄丄七业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        this._btnSettings.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::上丘丄专丅丑丕丁丑(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 业专丘不丛且丆丐不()
    {
        InGameGUI val_4;
        var val_5;
        if(this.丌丄丂上丘丂丘丑世() == true)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        val_5 = null;
        val_5 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        val_4 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
        val_4 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        丗丙与丈丟一东丏不();
    }
    private void 丏丁丄三东万丝丁上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this._guiVisibilityButton == 0)
        {
                return;
        }
        
        this._guiVisibilityButton.gameObject.SetActive(value:  PGCompany.专一万七业一丟丛丕.丑七不且上丗丁一世().东丞丟万一世且业丅());
    }
    private void OnEnable()
    {
        var val_45;
        bool val_46;
        UnityEngine.Transform val_47;
        string val_48;
        PGCompany.专一万七业一丟丛丕.丑七不且上丗丁一世().世丕世丛丒丘丛上丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::丏丁丄三东万丝丁上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this._guiVisibilityButton != 0)
        {
                this._guiVisibilityButton.gameObject.SetActive(value:  PGCompany.专一万七业一丟丛丕.丑七不且上丗丁一世().东丞丟万一世且业丅());
        }
        
        if(PGCompany.专一万七业一丟丛丕.丑七不且上丗丁一世().东丞丟万一世且业丅() != false)
        {
                if(this.一东丘业丌丌丐七东() != 0)
        {
                UIPanel val_12 = this.一东丘业丌丌丐七东();
        }
        
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                if(this._btnBank != 0)
        {
                this._btnBank.gameObject.SetActive(value:  false);
        }
        
        }
        
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PauseGUIController::丗丟万丂丘丈专丄丂()), 与且专丈不万东一万:  "Pause window");
        if((GameConnect.丆丕丒与丂七与下上() != false) && (CheckpointController.丄丘七三上丕世丞业 != 0))
        {
                this._btnFinish.gameObject.SetActive(value:  (CheckpointController.丄丘七三上丕世丞业.runFinishedOnce == true) ? 1 : 0);
            val_45 = this._btnExit.gameObject;
            var val_26 = (CheckpointController.丄丘七三上丕世丞业.runFinishedOnce == false) ? 1 : 0;
        }
        else
        {
                val_45 = this._btnExit.gameObject;
            val_46 = PGCompany.丁东丌世与丕东丆上.丞一上丌丏下丛丅丁();
        }
        
        val_45.SetActive(value:  val_46);
        ShopTapReceiver.与丝丏丏丌丐万丄丙(丕丒上丄丒业丕丕丐:  new System.Action(object:  this, method:  System.Void PauseGUIController::业专丘不丛且丆丐不()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._battlePassHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._pixelPassHolder, 丏业丟一东丂东丘丛:  false);
        if(((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0) || ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万()) == null))
        {
            goto label_66;
        }
        
        PGCompany.ClanWarController val_34 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_34.万丅一丟丑丆世丞且 == null)
        {
            goto label_66;
        }
        
        System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean> val_36 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.GetTaskInfo();
        if(0 != 0)
        {
            goto label_66;
        }
        
        PGCompany.ClanWarController val_37 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_37.万丅一丟丑丆世丞且.七一丈丁专丞丛丟丌() == false)
        {
            goto label_66;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._battlePassHolder, 丏业丟一东丂东丘丛:  true);
        val_47 = this._battlePassHolder;
        val_48 = "CWConnectScene";
        goto label_69;
        label_66:
        if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._pixelPassHolder, 丏业丟一东丂东丘丛:  true);
            if(this.丈丟丂七丛丟三丛丝 != 0)
        {
                return;
        }
        
            this.丈丟丂七丛丟三丛丝 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丒丒一丕世丟三丂丌<PGCompany.PixelPass.PixelPassTasksInGameUI>(丄三下丙下世丅丘丙:  this._pixelPassHolder, 丟丈一下东业一丝丆:  "PixelPassTasksInGame");
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._battlePassHolder, 丏业丟一东丂东丘丛:  true);
        val_47 = this._battlePassHolder;
        val_48 = "BPConnectScene";
        label_69:
        PGCompany.BattlePass.万丈上下三丅丘丛丒.一丝且不丅东丗丒丙(丁丕丗丝万万上丟丌:  val_47, 丟丈一下东业一丝丆:  val_48, 上一丈丕丙世东丅丅:  false);
    }
    private void Update()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = this;
        if(this.丌丄丂上丘丂丘丑世() != false)
        {
                this.一丛东丛丏丘丘丟丄 = true;
            this.东丐丐丕世丏万东丑 = Infinityf;
            return;
        }
        
        if(this.一丛东丛丏丘丘丟丄 != false)
        {
                this.东丐丐丕世丏万东丑 = UnityEngine.Time.realtimeSinceStartup;
        }
        
        this.一丛东丛丏丘丘丟丄 = false;
        val_3 = 1152921505171275776;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
    }
    private void OnDisable()
    {
        PGCompany.专一万七业一丟丛丕.丑七不且上丗丁一世().丞丞丕一丁丐与丏丄(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseGUIController::丏丁丄三东万丝丁上(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        ShopTapReceiver.上丗丐丛下且世万世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PauseGUIController::业专丘不丛且丆丐不()));
    }
    private void 丗丟万丂丘丈专丄丂()
    {
        var val_6;
        if(this.丌丄丂上丘丂丘丑世() != false)
        {
                return;
        }
        
        this.与丐丛业丟丌丑丈丞(下下东且万业丞丅丒:  false);
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if((InGameGUI.丙丞专丌丁丞与不丐 != 0) && (InGameGUI.丙丞专丌丁丞与不丐.playerMoveC != 0))
        {
                丝丞丙上一丕业丙丒(七丆丂专丁丈丒东丐:  true);
        }
        else
        {
                this.gameObject.SetActive(value:  false);
        }
        
        val_6 = null;
        val_6 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  false);
    }
    public PauseGUIController()
    {
    
    }
    private void 丐丗丟丛一丟东丟丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丗丟万丂丘丈专丄丂();
    }
    private void 丏丝一三东丞丐三下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.丌丄丂上丘丂丘丑世() == true)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.ExitingInCampaign == true)
        {
                return;
        }
        
        }
        
        float val_11 = this.东丐丐丕世丏万东丑;
        val_11 = val_11 + 0.5f;
        if(UnityEngine.Time.realtimeSinceStartup < 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_12 = null;
            val_12 = null;
            if((上且一丁七丙丙丈丁(丝丐不丛丗七七丞一:  true)) != false)
        {
                val_13 = null;
            val_13 = null;
            if(RatingSystem.丝七丘丝丒丞丝丆世 != true)
        {
                if(RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅() < 1)
        {
            goto label_25;
        }
        
        }
        
            this.与丐丛业丟丌丑丈丞(下下东且万业丞丅丒:  true);
            return;
        }
        
        }
        
        label_25:
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_15 = null;
            val_15 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_16 = null;
            val_16 = null;
            typeof(NetworkStartTable).__il2cppRuntimeField_73 = 1;
        }
        
        }
        
        this.丂丄丝三且世丞丌丟();
    }
    private void 上丑丒丝且丈丞丌丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        bool val_1 = this.丌丄丂上丘丂丘丑世();
        if(val_1 != false)
        {
                return;
        }
        
        val_1.业一万丏世丑丆丙丐();
    }
    private void 丄丗东上丝丄丄七业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.业专丘不丛且丆丐不();
    }
    private void 上丘丄专丅丑丕丁丑(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.ExitingInCampaign != false)
        {
                return;
        }
        
        }
        
        this.SettingsPanel.gameObject.SetActive(value:  true);
    }

}
