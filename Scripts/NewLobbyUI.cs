using UnityEngine;
internal sealed class NewLobbyUI : PGBehaviour
{
    // Fields
    private static NewLobbyUI 丝业丆丁业三丈丟东;
    private UnityEngine.GameObject onlineMode;
    private UnityEngine.GameObject offlineMode;
    private UniversalMiniBannerListUI miniBannerListUI;
    private System.Collections.Generic.List<LobbyButton> 丌且丘万丅丙业丏业;
    private System.Collections.Generic.List<GuiApplyersGroup> storeButtonApplyerGroups;
    private bool 丗三丒丞丝丐丆东丈;
    
    // Properties
    internal static NewLobbyUI 丆丕丝丒不丙且丐丗 { get; }
    internal UniversalMiniBannerListUI 丝一丂下丙丙且丝下 { get; }
    internal System.Collections.Generic.List<LobbyButton> 专且业丂三业专丐丕 { get; }
    
    // Methods
    internal static NewLobbyUI 丑七不且上丗丁一世()
    {
        return (NewLobbyUI)NewLobbyUI.丝业丆丁业三丈丟东;
    }
    internal UniversalMiniBannerListUI 丂东下与丐丕丌且丏()
    {
        return (UniversalMiniBannerListUI)this.miniBannerListUI;
    }
    internal System.Collections.Generic.List<LobbyButton> 七三万七业世丅丐丆()
    {
        if(this.丌且丘万丅丙业丏业 != null)
        {
                return (System.Collections.Generic.List<LobbyButton>)val_2;
        }
        
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<LobbyButton>(source:  this.GetComponentsInChildren<LobbyButton>(includeInactive:  true));
        this.丌且丘万丅丙业丏业 = val_2;
        return (System.Collections.Generic.List<LobbyButton>)val_2;
    }
    private void OnEnable()
    {
        NewLobbyUI.丝业丆丁业三丈丟东 = this;
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丙丑丘业丕丗丗不丘()));
        ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丙丑丘业丕丗丗不丘()));
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        Rilisoft.三一丈七且丄与丝东.丙业万专世丐丘丁三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        PGCompany.MainStore.万丝丞东丘丒丌七专.丛丑丂且丘丙丆东专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丙丑丘业丕丗丗不丘()));
        ExpController.丄丂一丛丅丄丄丘且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丙丑丘业丕丗丗不丘()));
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        Rilisoft.三一丈七且丄与丝东.三万丌丝丒与不丁丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
        PGCompany.MainStore.万丝丞东丘丒丌七专.丞丞丂丁与七下一不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NewLobbyUI::丝一丅丆三东丂丞七()));
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.onlineMode, 丏业丟一东丂东丘丛:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.offlineMode, 丏业丟一东丂东丘丛:  与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆());
        this.丙丑丘业丕丗丗不丘();
        this.丏丛万丌专丞一丅丟();
    }
    internal void 丙丑丘业丕丗丗不丘()
    {
        if(this.七三万七业世丅丐丆() == null)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = this.七三万七业世丅丐丆().GetEnumerator();
        this = 1152921539869742432;
        label_5:
        if((903176200 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        if(val_4 == null)
        {
            goto label_5;
        }
        
        val_4.丝一丅丆三东丂丞七();
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丏丛万丌专丞一丅丟()
    {
        List.Enumerator<T> val_1 = this.storeButtonApplyerGroups.GetEnumerator();
        label_5:
        if((903320936 & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_5;
        }
        
        string val_4 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().七且丈专三丟丟丘东();
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void LobbyButtonClicked(LobbyButton 丟丒丞丐丐丘丒丄东)
    {
        if((丟丒丞丐丐丘丒丄东.丒丑丕丄丘与丗丕不() - 1) > 25)
        {
                return;
        }
        
        var val_39 = 106029540 + ((val_1 - 1)) << 2;
        val_39 = val_39 + 106029540;
        goto (106029540 + ((val_1 - 1)) << 2 + 106029540);
    }
    public void GoToArmory()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleShopClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    public void GoToCraft()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.丞丒丅东丞丄丝丄丒(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    public void GoToAutoTest()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.丝丌丛与下丛七丒且(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    public void GoToMainStore()
    {
        var val_4;
        var val_5;
        var val_6;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丞上一丞丁丂丝丐丞;
        val_4 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        val_4.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  PGCompany.丁东丌世与丕东丆上.丁且丅丕专与丅且丄(丟丘不丒上丐丗与丅:  0), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丞上一丞丁丂丝丐丞, 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    public void GoToEventChests()
    {
        Rilisoft.三一丈七且丄与丝东 val_7 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
        Rilisoft.丛且世丐丆上七业丁 val_2 = val_7.丂三丞下专一下丛万(且下丕七丙丗丄不七:  100);
        if(val_2 == null)
        {
                return;
        }
        
        val_7 = val_2.业上丙丞丐丄丆丅七();
        UnityEngine.Vector3 val_6 = this.gameObject.transform.position;
        Rilisoft.GameEventGuiHandler.丞丙丗丁丙丏七专丑(丟丟丄专上丟丁丐丝:  val_7, 业万与下且万丕丈丑:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, 丈丈不丒丗与丝不丗:  false);
    }
    public void GoToEventRoulette()
    {
        var val_9;
        var val_10;
        val_9 = this;
        val_10 = 0;
        if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  200)) == null)
        {
                val_10 = 0;
            Rilisoft.丛且世丐丆上七业丁 val_4 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  44);
            if(val_4 == null)
        {
                return;
        }
        
        }
        
        val_9 = this.gameObject.transform;
        UnityEngine.Vector3 val_8 = val_9.position;
        Rilisoft.GameEventGuiHandler.丞丙丗丁丙丏七专丑(丟丟丄专上丟丁丐丝:  val_4.业上丙丞丐丄丆丅七(), 业万与下且万丕丈丑:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, 丈丈不丒丗与丝不丗:  false);
    }
    public void GoToClans()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleClansClicked();
    }
    public void GoToTaskBook()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleTaskBookClicked();
    }
    public void GoToTournament()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleLeaderboardsClicked();
    }
    public void GoToSettings()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.专丕与丙丆丕丝丘丘(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    public void GoToMailBox()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleNewsButtonClicked(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    public void GoToFriends()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.丈丑丏下七世丆不万(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    public void GoToConnectScene()
    {
        var val_2;
        if(this.丗三丒丞丝丐丆东丈 == true)
        {
                return;
        }
        
        if(PGCompany.丁东丌世与丕东丆上.丈万丅不丗七丛上与() != false)
        {
                this.丗三丒丞丝丐丆东丈 = true;
            return;
        }
        
        val_2 = null;
        val_2 = null;
        MainMenuController.丄丞丁丈与业上丞丟.OnClickMultiplyerButton();
    }
    public void GoToBattlePass()
    {
        UnityEngine.Debug.LogError(message:  "GoTo BattlePass");
    }
    public void GoToArena()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleSurvivalClicked();
    }
    public void GoToExtremeRun()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.StartSpeedrunButton();
    }
    public void GoToPixelGunClassic()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleClassicArenaClicked();
    }
    public void GoToCampaign()
    {
        null = null;
        MainMenuController.丄丞丁丈与业上丞丟.OnClickMiniGamesButton();
    }
    public void GoToDevConsole()
    {
    
    }
    public void GoToDevEventHub()
    {
    
    }
    public NewLobbyUI()
    {
        this.storeButtonApplyerGroups = new System.Collections.Generic.List<GuiApplyersGroup>();
    }

}
