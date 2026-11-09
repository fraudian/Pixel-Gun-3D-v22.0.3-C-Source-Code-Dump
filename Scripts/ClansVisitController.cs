using UnityEngine;
internal class ClansVisitController : Singleton<ClansVisitController>
{
    // Fields
    private static 丞丂丘丒丟丞丑下丄 丐丗丕丞丅且丁与业;
    private static bool 不丁丕七业万七丏丈;
    internal bool 丕丁不丅丒丑丁丁世;
    internal bool 丂丁一业丟丙且丄万;
    internal bool 万三业丐丝业丝丕丏;
    internal bool 丁下且丙丟上丗丘丅;
    internal bool 丝与丗丅不丏丙丙丅;
    internal bool 丑且丂七丛且世万业;
    internal 丛业下业丁丈丐一业 丈万丂丘丂下丒丌七;
    internal LeaderboardsGui.一丐丛丏东上专丆丐 丞丌丕丛丒丟丐丏下;
    private LeaderboardsGui.一丐丛丏东上专丆丐 丐丌上丌万丂专丒丐;
    internal string 万丄丅丝三丈丆世丟;
    internal Rilisoft.万丑丆且世与丁下且 丕不丗丈且丟丟丕世;
    internal System.Action<bool> 丑丟丅一丟七丛三丏;
    
    // Properties
    public bool 丁专丆丗一丂与丈丒 { get; set; }
    public 丞丂丘丒丟丞丑下丄 丂丈丆且丏且丆一丒 { get; set; }
    
    // Methods
    internal void 不丂东万丟丆丄丕七(string 上七专丛丙丕且丗丕, Rilisoft.万丑丆且世与丁下且 丁丅丈丌丟世丗丗丟, System.Action<bool> 丅丗专丕丑上丝下丕)
    {
        this.万丄丅丝三丈丆世丟 = 上七专丛丙丕且丗丕;
        this.丕不丗丈且丟丟丕世 = 丁丅丈丌丟世丗丗丟;
        this.丑丟丅一丟七丛三丏 = 丅丗专丕丑上丝下丕;
    }
    public bool get_IsVisitClan()
    {
        return (bool)ClansVisitController.不丁丕七业万七丏丈;
    }
    public void set_IsVisitClan(bool 丙业与丙丗丝不丈东)
    {
        ClansVisitController.不丁丕七业万七丏丈 = 丙业与丙丗丝不丈东;
    }
    public 丞丂丘丒丟丞丑下丄 get_VisitClan()
    {
        return (丞丂丘丒丟丞丑下丄)ClansVisitController.丐丗丕丞丅且丁与业;
    }
    public void set_VisitClan(丞丂丘丒丟丞丑下丄 丙业与丙丗丝不丈东)
    {
        ClansVisitController.丐丗丕丞丅且丁与业 = 丙业与丙丗丝不丈东;
    }
    public void UpdateClanData()
    {
        if(ClansVisitController.不丁丕七业万七丏丈 == false)
        {
                return;
        }
        
        if(ClansVisitController.__il2cppRuntimeField_static_fields == null)
        {
                return;
        }
        
        ClansController val_1 = Rilisoft.Singleton<ClansController>.Instance;
        val_1.<专丄下丒丝丆丌丐东>k__BackingField.上丟与与七丈丛丝丒(世丂七与丙与丞丐东:  ClansVisitController.丐丗丕丞丅且丁与业.丌丂专不丁七一丙丗(), 东丕丞世丘丛上世丏:  true);
    }
    public void ClearClan()
    {
        ClansVisitController.不丁丕七业万七丏丈 = false;
        null = null;
        ClansVisitController.丐丗丕丞丅且丁与业 = 0;
    }
    internal System.Collections.Generic.List<ClanTankEquipInfo> 不世丗七不下丑丕丆()
    {
        if(null == 0)
        {
                return (System.Collections.Generic.List<ClanTankEquipInfo>)new System.Collections.Generic.List<ClanTankEquipInfo>();
        }
        
        return null.丒丗不丙业丟丄丏丂();
    }
    internal void 不三丘三与丏下丂丞()
    {
        var val_6;
        var val_7;
        if((Rilisoft.Singleton<ClansController>.Instance) == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.HideInterface();
        val_7 = null;
        val_7 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  false);
        int val_5 = ClansWindowInfoViewController.与且丂丐万丝丘三下(丕专上丁丅丅丏万丌:  MainMenuController.丄丞丁丈与业上丞丟.gameObject, 丞丌丐丞丞丘丏专下:  ClansVisitController.丐丗丕丞丅且丁与业, 丘丗不丁丘丒丅丌不:  new System.Action(object:  this, method:  System.Void ClansVisitController::丕七专丘丙丁丛三七()), 世丟七丕且丝丅不上:  true, 不丆丁且丕丅不丕七:  false);
    }
    public ClansVisitController()
    {
    
    }
    private void 丕七专丘丙丁丛三七()
    {
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
        if(ClansWindowInfoViewController.丄丘七三上丕世丞业 == 0)
        {
            goto label_3;
        }
        
        ClansWindowInfoViewController.丄丘七三上丕世丞业.remove_OnClose(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClansVisitController::丕七专丘丙丁丛三七()));
        val_21 = 1152921505080860672;
        val_22 = null;
        val_22 = null;
        val_23 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  true);
        this.gameObject.SetActive(value:  true);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.万丄丅丝三丈丆世丟)) != true)
        {
                if(this.丕不丗丈且丟丟丕世 == 0)
        {
            goto label_12;
        }
        
        }
        
        label_49:
        if(this.丈万丂丘丂下丒丌七 == 1)
        {
            goto label_13;
        }
        
        if(this.丈万丂丘丂下丒丌七 != 2)
        {
            goto label_14;
        }
        
        val_24 = null;
        val_24 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleClansClickedCore(三丂东专丕专业丏万:  false);
        Rilisoft.ClansLobbyGui.丑七不且上丗丁一世().ShowLeaders();
        goto label_19;
        label_3:
        UnityEngine.Debug.Log(message:  "No ClansWindowInstance");
        return;
        label_13:
        val_25 = null;
        val_25 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleLeaderboardsClicked();
        label_19:
        val_23 = 1152921505152532480;
        if((this.丞丌丕丛丒丟丐丏下 != 1) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == ClansVisitController.丐丗丕丞丅且丁与业))
        {
            goto label_28;
        }
        
        LeaderboardsClans.与一丅丝不丈业与丙().丛丅专丁上一丞丄丈();
        goto label_72;
        label_14:
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_36;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != ClansVisitController.丐丗丕丞丅且丁与业)
        {
                if(this.丁下且丙丟上丗丘丅 == false)
        {
            goto label_36;
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        MainMenuController.丄丞丁丈与业上丞丟.HandleClansClickedCore(三丂东专丕专业丏万:  false);
        goto label_72;
        label_28:
        if((this.丞丌丕丛丒丟丐丏下 != 3) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == ClansVisitController.丐丗丕丞丅且丁与业))
        {
            goto label_44;
        }
        
        LeaderboardsGui.与一丅丝不丈业与丙().U_TournamenthToggleButtonClick();
        goto label_72;
        label_12:
        if(this.丑丟丅一丟七丛三丏 == null)
        {
            goto label_49;
        }
        
        val_27 = null;
        val_27 = null;
        MainMenuController.丄丞丁丈与业上丞丟.丒丄业七不丂不丞丝(且丂丗七丕上丄丘与:  0, 丈丈不丒丗与丝不丗:  true);
        val_21 = this.万丄丅丝三丈丆世丟;
        FriendsWindowController.丆丕丝丒不丙且丐丗.世专丌业丘丒丛丅上(丑三丅丒丕丗三丏丁:  val_21, 丁丑丞不丗专丑业万:  0);
        this.万丄丅丝三丈丆世丟 = 0;
        this.丕不丗丈且丟丟丕世 = 2;
        this.丑丟丅一丟七丛三丏 = 0;
        goto label_72;
        label_36:
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == ClansVisitController.丐丗丕丞丅且丁与业)
        {
            goto label_72;
        }
        
        val_28 = null;
        val_28 = null;
        val_29 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 == false)
        {
            goto label_60;
        }
        
        val_30 = null;
        MainMenuController.丄丞丁丈与业上丞丟.丐丐世三丆东丆丌丛();
        goto label_72;
        label_44:
        if((this.丞丌丕丛丒丟丐丏下 != 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == ClansVisitController.丐丗丕丞丅且丁与业))
        {
            goto label_72;
        }
        
        LeaderboardsGui.与一丅丝不丈业与丙().U_TopPlayersToggleButtonClick();
        goto label_72;
        label_60:
        val_31 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  MainMenuController.丄丞丁丈与业上丞丟.mainPanel, 丏业丟一东丂东丘丛:  true);
        label_72:
        if(ClansVisitController.不丁丕七业万七丏丈 == false)
        {
                return;
        }
        
        if(ClansVisitController.__il2cppRuntimeField_static_fields == null)
        {
                return;
        }
        
        this.丕丁不丅丒丑丁丁世 = false;
        this.丁下且丙丟上丗丘丅 = false;
        this.ClearClan();
    }

}
