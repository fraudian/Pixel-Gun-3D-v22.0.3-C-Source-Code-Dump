using UnityEngine;
internal sealed class ConnectToClanSiegeButton : MonoBehaviour
{
    // Fields
    public Rilisoft.ButtonHandler connectBtn;
    public Rilisoft.ButtonHandler cancelBtn;
    public UILabel labelNickFull;
    public UILabel labelNick;
    public AchieveBox achieveBox;
    public UISprite timeoutProgress;
    private UIButton 上丗上丅丂丝丟世丂;
    private string 丁世且东丒丕万丟下;
    private float 丆丏丏丟丙丑丙丗丕;
    
    // Methods
    private void Update()
    {
        this.东丞丝且丐丄业丄丏();
    }
    internal void 业东三丒丝丐丏丐且(string 不丆业丏上丐与丌业)
    {
        this.丁世且东丒丕万丟下 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5697"), arg0:  System.String.Format(format:  "[FFFF01]{0}[-]", arg0:  不丆业丏上丐与丌业));
        this.上丗上丅丂丝丟世丂 = this.connectBtn.GetComponent<UIButton>();
        this.丆丏丏丟丙丑丙丗丕 = 10f;
        this.东丞丝且丐丄业丄丏();
    }
    internal void 业东三丒丝丐丏丐且()
    {
        this.丁世且东丒丕万丟下 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4723");
        this.上丗上丅丂丝丟世丂 = this.connectBtn.GetComponent<UIButton>();
        this.丆丏丏丟丙丑丙丗丕 = 10f;
        this.东丞丝且丐丄业丄丏();
    }
    private void 东丞丝且丐丄业丄丏()
    {
        bool val_1 = ConnectToClanSiegeButton.专丈业丑万丆丟世丗();
        this.connectBtn.gameObject.SetActive(value:  val_1);
        this.cancelBtn.gameObject.SetActive(value:  val_1);
        bool val_7 = ConnectToClanSiegeButton.丟东七丕专丙丈丘丂();
        this.labelNick.gameObject.SetActive(value:  val_1);
        this.labelNickFull.gameObject.SetActive(value:  (~val_1) & 1);
        this.labelNickFull.text = this.丁世且东丒丕万丟下;
        this.labelNick.text = this.丁世且东丒丕万丟下;
        if(((val_1 & this.labelNick.丟丄与丆三丅万丟丅()) != false) && ((this.上丗上丅丂丝丟世丂 & 1) != 0))
        {
                this.achieveBox.丁丛丝丆丘丞丕丈三();
        }
        
        float val_15 = 10f;
        val_15 = this.丆丏丏丟丙丑丙丗丕 / val_15;
        this.timeoutProgress.fillAmount = val_15;
        float val_14 = UnityEngine.Time.deltaTime;
        val_14 = this.丆丏丏丟丙丑丙丗丕 - val_14;
        this.丆丏丏丟丙丑丙丗丕 = val_14;
    }
    private bool 丟丄与丆三丅万丟丅()
    {
        string val_12;
        var val_13;
        val_12 = Rilisoft.PushNotifications.PushNotificationHandler.丑七不且上丗丁一世();
        if(val_12.Active == false)
        {
            goto label_13;
        }
        
        val_12 = Rilisoft.Singleton<ClansController>.Instance;
        if(val_12.丞丗丑丈一丅丗丌丟() == null)
        {
            goto label_4;
        }
        
        if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.东专世且丈下下丒丘() == false)
        {
            goto label_13;
        }
        
        val_12 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
        bool val_10 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  0);
        if((val_9.Equals(value:  val_12)) == false)
        {
            goto label_13;
        }
        
        label_4:
        val_13 = 1;
        return (bool)val_13;
        label_13:
        val_13 = 0;
        return (bool)val_13;
    }
    private void OnClick()
    {
        this.achieveBox.丁丛丝丆丘丞丕丈三();
        bool val_2 = 丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void ConnectToClanSiegeButton::丛丙丕世丒丈丞丗上()));
        if(val_2 != false)
        {
                return;
        }
        
        val_2.丛丙丕世丒丈丞丗上();
    }
    private void 丛丙丕世丒丈丞丗上()
    {
        var val_7;
        var val_8;
        System.Action val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        ClansWindowGUI val_15;
        var val_16;
        var val_17;
        val_7 = null;
        val_7 = null;
        MainMenuController.丂世丗丌丌一丐丝丛 = true;
        val_8 = null;
        val_8 = null;
        val_10 = ConnectToClanSiegeButton.<>c.<>9__15_0;
        if(val_10 == null)
        {
                System.Action val_1 = null;
            val_10 = val_1;
            val_1 = new System.Action(object:  ConnectToClanSiegeButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectToClanSiegeButton.<>c::丈万丝专上且且不专());
            ConnectToClanSiegeButton.<>c.<>9__15_0 = val_10;
        }
        
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  val_1, 丆丐七丅丆丗丛上与:  10f);
        val_11 = null;
        val_11 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_12 = null;
            val_12 = null;
            if(activeInHierarchy != false)
        {
                val_13 = null;
            val_13 = null;
            MainMenuController.丄丞丁丈与业上丞丟.EnterClanSiege();
            return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_15 == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_15.InterfaceEnabled == false)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.EnterSiegeMode();
    }
    private void 丞东丝万三丆丕丁下()
    {
        this.achieveBox.丁丛丝丆丘丞丕丈三();
    }
    private void Awake()
    {
        this.connectBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ConnectToClanSiegeButton::丌丅万丆丗丅丈丛东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.cancelBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ConnectToClanSiegeButton::丞丌东丌上世东丙丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal static bool 专丈业丑万丆丟世丗()
    {
        FriendProfileView val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        val_31 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_31.丌丗丑业丁上丆万七() == true)
        {
                return false;
        }
        
        val_31 = 1152921505150189568;
        val_32 = null;
        val_32 = null;
        if(ClansController.丑丏丛不丂丄上且丈 == true)
        {
                return false;
        }
        
        val_33 = null;
        val_33 = null;
        val_31 = FriendProfileView.丐丕丝上丅丈丐丞专;
        if(val_31 != 0)
        {
                return false;
        }
        
        if(GiftBannerWindow.丛世丛与丌不丈丐丐() != true)
        {
                if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
            goto label_16;
        }
        
        }
        
        return false;
        label_16:
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return false;
        }
        
        }
        
        InfoWindowController val_10 = InfoWindowController.丑七不且上丗丁一世();
        if(val_10.restoreWindowPanel != 0)
        {
                InfoWindowController val_12 = InfoWindowController.丑七不且上丗丁一世();
            if(val_12.restoreWindowPanel.activeSelf == true)
        {
                return false;
        }
        
        }
        
        val_34 = null;
        val_34 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_41;
        }
        
        val_35 = null;
        val_35 = null;
        if(activeInHierarchy == true)
        {
            goto label_46;
        }
        
        label_41:
        val_36 = null;
        val_36 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                return false;
        }
        
        val_37 = null;
        val_37 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
                return false;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return false;
        }
        
        label_46:
        if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return false;
        }
        
        val_38 = null;
        val_38 = null;
        if(SquadController.丄丘七三上丕世丞业 != 0)
        {
                val_39 = null;
            val_39 = null;
            if(SquadController.丄丘七三上丕世丞业.IsClanSquad == true)
        {
                return false;
        }
        
        }
        
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == true)
        {
                return false;
        }
        
        if(LeaderboardsClans.丑丙丗世丏丞万世丒() == true)
        {
                return false;
        }
        
        if(NurseryGuiController.丛世丛与丌不丈丐丐() == true)
        {
                return false;
        }
        
        if(Rilisoft.ClansLobbyGui.OpenChestProcessing == true)
        {
                return false;
        }
        
        if(ActivityIndicator.丙专三丙丌丝丏丌丅() == true)
        {
                return false;
        }
        
        val_40 = null;
        val_40 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业 == 0)
        {
                return false;
        }
        
        val_41 = null;
        val_41 = null;
        var val_30 = (SquadPanelGUI.丄丘七三上丕世丞业.isActive == false) ? 1 : 0;
        return false;
    }
    internal static bool 丟东七丕专丙丈丘丂()
    {
        bool val_1 = MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public ConnectToClanSiegeButton()
    {
        this.丁世且东丒丕万丟下 = "";
    }
    private void 丌丅万丆丗丅丈丛东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.OnClick();
    }
    private void 丞丌东丌上世东丙丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丞东丝万三丆丕丁下();
    }

}
