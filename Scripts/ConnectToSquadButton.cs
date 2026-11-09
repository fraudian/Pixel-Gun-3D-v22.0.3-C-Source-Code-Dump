using UnityEngine;
internal sealed class ConnectToSquadButton : MonoBehaviour
{
    // Fields
    private string 万丐丂丌与丐且丈丘;
    private int 丗专不丒丕丐丐不丗;
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
    internal void 业东三丒丝丐丏丐且(string 不丆业丏上丐与丌业, string 丅一丞万丑专丅丅与, int 丄东七丄一丄万丕丟)
    {
        this.丁世且东丒丕万丟下 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3381"), arg0:  不丆业丏上丐与丌业);
        this.万丐丂丌与丐且丈丘 = 丅一丞万丑专丅丅与;
        this.丗专不丒丕丐丐不丗 = 丄东七丄一丄万丕丟;
        this.上丗上丅丂丝丟世丂 = this.connectBtn.GetComponent<UIButton>();
        this.丆丏丏丟丙丑丙丗丕 = 10f;
        this.东丞丝且丐丄业丄丏();
    }
    private void 东丞丝且丐丄业丄丏()
    {
        bool val_1 = ConnectToSquadButton.专丈业丑万丆丟世丗();
        this.connectBtn.gameObject.SetActive(value:  val_1);
        this.cancelBtn.gameObject.SetActive(value:  val_1);
        bool val_7 = ConnectToSquadButton.丟东七丕专丙丈丘丂();
        this.labelNick.gameObject.SetActive(value:  val_1);
        this.labelNickFull.gameObject.SetActive(value:  (~val_1) & 1);
        this.labelNickFull.text = this.丁世且东丒丕万丟下;
        this.labelNick.text = this.丁世且东丒丕万丟下;
        if(((val_1 & this.丟丄与丆三丅万丟丅()) != false) && ((this.上丗上丅丂丝丟世丂 & 1) != 0))
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
        string val_7;
        var val_8;
        val_7 = this;
        if((Rilisoft.PushNotifications.PushNotificationHandler.丑七不且上丗丁一世().Active != false) && (Rilisoft.PushNotifications.下丝丛三与专丄东丐.丌专丌一下丏丐丄丐() != false))
        {
                bool val_5 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  0);
            val_7 = this.万丐丂丌与丐且丈丘;
            if((val_4.Equals(value:  val_7)) != false)
        {
                val_8 = 1;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    private void OnClick()
    {
        if((System.String.IsNullOrEmpty(value:  this.万丐丂丌与丐且丈丘)) == true)
        {
                return;
        }
        
        this.achieveBox.丁丛丝丆丘丞丕丈三();
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void ConnectToSquadButton::丌与丄东丈丄丝三且()))) != false)
        {
                return;
        }
        
        this.丌与丄东丈丄丝三且();
    }
    private void 丌与丄东丈丄丝三且()
    {
        var val_16;
        var val_17;
        System.Action val_19;
        var val_20;
        string val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_16 = null;
        val_16 = null;
        MainMenuController.丂世丗丌丌一丐丝丛 = true;
        val_17 = null;
        val_17 = null;
        val_19 = ConnectToSquadButton.<>c.<>9__16_0;
        if(val_19 == null)
        {
                System.Action val_1 = null;
            val_19 = val_1;
            val_1 = new System.Action(object:  ConnectToSquadButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ConnectToSquadButton.<>c::三丗不丑丏丆丟丗丐());
            ConnectToSquadButton.<>c.<>9__16_0 = val_19;
        }
        
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  val_1, 丆丐七丅丆丗丛上与:  10f);
        val_20 = null;
        val_20 = null;
        val_21 = 1152921504848912384;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_19;
        }
        
        val_22 = null;
        val_22 = null;
        if(activeInHierarchy == false)
        {
            goto label_19;
        }
        
        val_23 = null;
        val_23 = null;
        val_21 = this.万丐丂丌与丐且丈丘;
        MainMenuController.丄丞丁丈与业上丞丟.JoinToSquadPoint(丅一丞万丑专丅丅与:  val_21);
        goto label_74;
        label_19:
        val_24 = static_value_081DACA8;
        val_24 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
            goto label_34;
        }
        
        val_25 = static_value_081DACA8;
        val_25 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16 + 64.gameObject.activeInHierarchy) == false)
        {
            goto label_34;
        }
        
        val_26 = static_value_081DACA8;
        val_26 = static_value_081DACA8;
        val_21 = this.万丐丂丌与丐且丈丘;
        static_value_081DACA8 + 184 + 16.丌丐丒丞且丌丒丂丛(丅一丞万丑专丅丅与:  val_21);
        goto label_74;
        label_34:
        if((ChooseMiniGameController.丄丞丁丈与业上丞丟 == 0) || (ChooseMiniGameController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == false))
        {
            goto label_44;
        }
        
        val_21 = this.万丐丂丌与丐且丈丘;
        ChooseMiniGameController.丄丞丁丈与业上丞丟.JoinToSquadPoint(丅一丞万丑专丅丅与:  val_21);
        goto label_74;
        label_44:
        val_27 = null;
        val_27 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_55;
        }
        
        val_28 = null;
        val_28 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
        {
            goto label_55;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = null;
        val_30 = null;
        val_21 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 512];
        val_21 = MainMenuController.丄丞丁丈与业上丞丟.丝丆业上世丅丞且丙;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.JoinToSquadPoint(丙不丅丝丙专丕世丐:  val_21, 丅一丞万丑专丅丅与:  this.万丐丂丌与丐且丈丘);
        goto label_74;
        label_55:
        if(FriendsWindowController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_31 = null;
            val_31 = null;
            if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_32 = null;
            val_32 = null;
            if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() != false)
        {
                val_21 = this.万丐丂丌与丐且丈丘;
            FriendsWindowController.丆丕丝丒不丙且丐丗.丆丙丄上七与一东丒(丒丘丏上丙丟丑丕丈:  val_21);
        }
        
        }
        
        }
        
        label_74:
        val_33 = null;
        val_33 = null;
        SquadController.丘丘丙丗东丟丑业丟 = this.丗专不丒丕丐丐不丗;
    }
    private void 丞东丝万三丆丕丁下()
    {
        this.achieveBox.丁丛丝丆丘丞丕丈三();
    }
    private void Awake()
    {
        this.connectBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ConnectToSquadButton::东七七上上三丟与专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.cancelBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ConnectToSquadButton::上且业丙丅丞专丛丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal static bool 专丈业丑万丆丟世丗()
    {
        FriendProfileView val_43;
        var val_44;
        var val_45;
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
        var val_56;
        var val_57;
        val_43 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
        if(val_43.丌丗丑业丁上丆万七() == true)
        {
                return false;
        }
        
        val_43 = 1152921505150189568;
        val_44 = null;
        val_44 = null;
        if(ClansController.丑丏丛不丂丄上且丈 == true)
        {
                return false;
        }
        
        val_45 = null;
        val_45 = null;
        val_43 = FriendProfileView.丐丕丝上丅丈丐丞专;
        if(val_43 != 0)
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
        
        val_46 = null;
        val_46 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_41;
        }
        
        val_47 = null;
        val_47 = null;
        if(activeInHierarchy == true)
        {
            goto label_74;
        }
        
        label_41:
        val_48 = static_value_081DACA8;
        val_48 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
            goto label_51;
        }
        
        val_49 = static_value_081DACA8;
        val_49 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16 + 64.gameObject.activeInHierarchy) == true)
        {
            goto label_74;
        }
        
        label_51:
        if(ChooseMiniGameController.丄丞丁丈与业上丞丟 != 0)
        {
                if(ChooseMiniGameController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy == true)
        {
            goto label_74;
        }
        
        }
        
        val_50 = null;
        val_50 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
        {
                val_51 = null;
            val_51 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled != false)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
            goto label_74;
        }
        
        }
        
        }
        
        if(FriendsWindowController.丆丕丝丒不丙且丐丗 == 0)
        {
                return false;
        }
        
        val_52 = null;
        val_52 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                return false;
        }
        
        val_53 = null;
        val_53 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == false)
        {
                return false;
        }
        
        label_74:
        if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return false;
        }
        
        val_54 = null;
        val_54 = null;
        if(SquadController.丄丘七三上丕世丞业 != 0)
        {
                val_55 = null;
            val_55 = null;
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
        
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return false;
        }
        
        if(NurseryGuiController.丛世丛与丌不丈丐丐() == true)
        {
                return false;
        }
        
        if(PGCompany.TaskBookMainUI.丛世丛与丌不丈丐丐() == true)
        {
                return false;
        }
        
        if(PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() == true)
        {
                return false;
        }
        
        if(AlmanachMainUI.丛世丛与丌不丈丐丐() == true)
        {
                return false;
        }
        
        if(ActivityIndicator.丙专三丙丌丝丏丌丅() == true)
        {
                return false;
        }
        
        val_56 = null;
        val_56 = null;
        if(SquadPanelGUI.丄丘七三上丕世丞业 == 0)
        {
                return false;
        }
        
        val_57 = null;
        val_57 = null;
        var val_42 = (SquadPanelGUI.丄丘七三上丕世丞业.isActive == false) ? 1 : 0;
        return false;
    }
    internal static bool 丟东七丕专丙丈丘丂()
    {
        bool val_1 = MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public ConnectToSquadButton()
    {
        this.万丐丂丌与丐且丈丘 = "";
        this.丁世且东丒丕万丟下 = "";
    }
    private void 东七七上上三丟与专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.OnClick();
    }
    private void 上且业丙丅丞专丛丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丞东丝万三丆丕丁下();
    }

}
