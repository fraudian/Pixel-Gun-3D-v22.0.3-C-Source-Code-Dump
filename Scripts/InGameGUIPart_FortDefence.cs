using UnityEngine;
internal sealed class InGameGUIPart_FortDefence : InGameGUIPartContainer
{
    // Fields
    private ProgressBarUI _progressBar;
    private TopRoundInfo _topRoundInfo;
    private FortDefenceGeneratorOneLineUI _fortDefenceGeneratorUI;
    private GameStageEvent _fortDefenceMainLabel;
    private GameStageEvent _fortDefenceLabel;
    private GameStageEvent _fortDefenceTimeLabel;
    private UnityEngine.GameObject _injuryPanel;
    private Rilisoft.ButtonHandler _respawnNowButton;
    public FortKilledByUI killedByUI;
    
    // Properties
    internal ProgressBarUI 且丟专万不世丆下丄 { get; }
    internal TopRoundInfo 一丂丟与丂丝丘丁世 { get; }
    internal FortDefenceGeneratorOneLineUI 丏丞万丄丒丌丑东丞 { get; }
    internal GameStageEvent 丝丅丕丌丒丞丙不业 { get; }
    internal GameStageEvent 万丏七专东且与三业 { get; }
    internal GameStageEvent 丝丁丘丏且丏不东三 { get; }
    internal UnityEngine.GameObject 丏丐丂业与与丘一丌 { get; }
    internal Rilisoft.ButtonHandler 丆与业东丄上丁世丏 { get; }
    
    // Methods
    internal ProgressBarUI 丐七丆丐丏丁东丅专()
    {
        return (ProgressBarUI)this._progressBar;
    }
    internal TopRoundInfo 丂东丒不与丅丏丝丒()
    {
        return (TopRoundInfo)this._topRoundInfo;
    }
    internal FortDefenceGeneratorOneLineUI 下丝且丐丞丘一丁丂()
    {
        return (FortDefenceGeneratorOneLineUI)this._fortDefenceGeneratorUI;
    }
    internal GameStageEvent 且丕万丑下业丙丂丗()
    {
        return (GameStageEvent)this._fortDefenceMainLabel;
    }
    internal GameStageEvent 丌丗一丁与丐丟丗三()
    {
        return (GameStageEvent)this._fortDefenceLabel;
    }
    internal GameStageEvent 丙三丛不丌丙三七丞()
    {
        return (GameStageEvent)this._fortDefenceTimeLabel;
    }
    internal UnityEngine.GameObject 丄且丈丘丄丆丌丗丏()
    {
        return (UnityEngine.GameObject)this._injuryPanel;
    }
    internal Rilisoft.ButtonHandler 丛三且三专丞上丂丒()
    {
        return (Rilisoft.ButtonHandler)this._respawnNowButton;
    }
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.专丝丘丆丛丅万丞三 = this;
        this._injuryPanel.SetActive(value:  false);
        this._respawnNowButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void InGameGUIPart_FortDefence::丘与丘丙上丄丞三丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丘与丘丙上丄丞三丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_6 = null;
        val_6 = null;
        业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丆丛不丄丂下且不丏(), 丗东丏与上丆丌不且:  0, 与丘丂下丘丁丅与东:  0, 丞丂丂丁丝丄万一丞:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丝三丛且丘不丌丙下:  "", 丞丗且下世丐业丌丙:  0);
    }
    public InGameGUIPart_FortDefence()
    {
    
    }

}
