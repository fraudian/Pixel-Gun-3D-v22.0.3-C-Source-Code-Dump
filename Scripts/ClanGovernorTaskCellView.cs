using UnityEngine;
internal class ClanGovernorTaskCellView : PGBehaviour
{
    // Fields
    private ClanGovernorMainUI mainUI;
    private GovernorCellChangeTaskBunner changeTaskBunner;
    private UnityEngine.GameObject devUI;
    private UILabel devLockedByLevel;
    private PGCompany.GameTaskView gameTaskView;
    private System.Collections.Generic.List<UISprite> rarityBG;
    private PGCompany.TimerUI lockedByTimeTimer;
    private IRewardListView rewardListView;
    private IRewardView hammersView;
    private UILabel taskType;
    private UnityEngine.GameObject state_CanCollectReward;
    private UnityEngine.GameObject state_Opend;
    private UnityEngine.GameObject state_CanOpen;
    private UnityEngine.GameObject state_LockedByLevel;
    private UnityEngine.GameObject state_LockedByCount;
    private UnityEngine.GameObject state_LockedByTime;
    internal 丛丗丅丆万不丕七丏 三下丌且与丘丆丏且;
    internal ClanGovernorTaskCellView.丙丙世七丆丝七丗丐 丝丘丆世丞上丆丙丑;
    internal ClanGovernorTaskCellView.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    
    // Methods
    private void OnEnable()
    {
        if(this.三下丌且与丘丆丏且 == null)
        {
                return;
        }
        
        this.三下丌且与丘丆丏且.丘丙丁下丕丑丈丒不(丙业与丙丗丝不丈东:  new System.Action<丛丗丅丆万不丕七丏>(object:  this, method:  System.Void ClanGovernorTaskCellView::丌丆七丈丌丗一下万(丛丗丅丆万不丕七丏 世丝专丝与丑业丑万)));
    }
    private void OnDisable()
    {
        if(this.三下丌且与丘丆丏且 == null)
        {
                return;
        }
        
        this.三下丌且与丘丆丏且.丏丙不世七丁东丒世(丙业与丙丗丝不丈东:  new System.Action<丛丗丅丆万不丕七丏>(object:  this, method:  System.Void ClanGovernorTaskCellView::丌丆七丈丌丗一下万(丛丗丅丆万不丕七丏 世丝专丝与丑业丑万)));
    }
    internal void 丈且东丑丂且万丒丅(丛丗丅丆万不丕七丏 三下丌且与丘丆丏且)
    {
        this.三下丌且与丘丆丏且 = 三下丌且与丘丆丏且;
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.devLockedByLevel, 丏业丟一东丂东丘丛:  false);
        if(this.三下丌且与丘丆丏且 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丄丁一丐丕与丝一丈:  this.rarityBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)this.三下丌且与丘丆丏且.七东与丄丕丁丛世三()], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)this.三下丌且与丘丆丏且.七东与丄丕丁丛世三()], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)this.三下丌且与丘丆丏且.七东与丄丕丁丛世三()], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)this.三下丌且与丘丆丏且.七东与丄丕丁丛世三()]});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskType, 丕丗丘丑丛与丑业丒:  this.三下丌且与丘丆丏且.丈万丏丐丛一丟丅丏());
        this.丝丘丆世丞上丆丙丑 = this.且上丘丄丘业丐丅业;
        this.且上丘丄丘业丐丅业 = this.丄丆专丁丕丆丐丝丝();
        this.不东丈丕不丝一东丙();
        丙丙世七丆丝七丗丐 val_9 = this.且上丘丄丘业丐丅业;
        val_9 = val_9 - 1;
        if(val_9 > 5)
        {
                return;
        }
        
        var val_10 = 106037568 + ((this.且上丘丄丘业丐丅业 - 1)) << 2;
        val_10 = val_10 + 106037568;
        goto (106037568 + ((this.且上丘丄丘业丐丅业 - 1)) << 2 + 106037568);
    }
    private ClanGovernorTaskCellView.丙丙世七丆丝七丗丐 丄丆专丁丕丆丐丝丝()
    {
        丛丗丅丆万不丕七丏 val_7;
        丛丗丅丆万不丕七丏 val_8;
        val_7 = this;
        val_8 = this.三下丌且与丘丆丏且;
        if(val_8 == null)
        {
                return (丙丙世七丆丝七丗丐)(val_7.丙七丟丂世丕不与丐() != true) ? 5 : 3;
        }
        
        if(val_8.丂丝丕东东世三丅与() != false)
        {
                val_8 = 1;
            return (丙丙世七丆丝七丗丐)(val_7.丙七丟丂世丕不与丐() != true) ? 5 : 3;
        }
        
        if(this.三下丌且与丘丆丏且.东丄丕丂七三丅丏世() != false)
        {
                val_8 = 6;
            return (丙丙世七丆丝七丗丐)(val_7.丙七丟丂世丕不与丐() != true) ? 5 : 3;
        }
        
        if(this.三下丌且与丘丆丏且.丗丙丐下丏丝丁丘三() != false)
        {
                val_8 = 2;
            return (丙丙世七丆丝七丗丐)(val_7.丙七丟丂世丕不与丐() != true) ? 5 : 3;
        }
        
        if(this.三下丌且与丘丆丏且.丗丞丅且丙丈丂丙不() != false)
        {
                val_8 = 4;
            return (丙丙世七丆丝七丗丐)(val_7.丙七丟丂世丕不与丐() != true) ? 5 : 3;
        }
        
        val_7 = this.三下丌且与丘丆丏且;
        return (丙丙世七丆丝七丗丐)(val_7.丙七丟丂世丕不与丐() != true) ? 5 : 3;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanCollectReward, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Opend, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByLevel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByCount, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByTime, 丏业丟一东丂东丘丛:  false);
        this.rewardListView.Clear();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.hammersView, 丏业丟一东丂东丘丛:  false);
    }
    private void 三丟丗丅下七不不丏()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanCollectReward, 丏业丟一东丂东丘丛:  true);
        this.rewardListView.Setup(上业丟世三与七七三:  this.三下丌且与丘丆丏且.一丈万丌丝一丄丟东());
        if(this.三下丌且与丘丆丏且.下丄丏丂且丘下丒丞() == null)
        {
                return;
        }
        
        this.hammersView.Setup(丗七丟丈三不丕一三:  this.三下丌且与丘丆丏且.下丄丏丂且丘下丒丞());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.hammersView, 丏业丟一东丂东丘丛:  true);
    }
    private void 业丙丗东丗专丟东一()
    {
        IRewardView val_8;
        System.Collections.Generic.List<PGCompany.与丏丛丏丏丞丐丌丙> val_9;
        val_8 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Opend, 丏业丟一东丂东丘丛:  true);
        if(this.三下丌且与丘丆丏且.丝丄丕世下世且东丂() != null)
        {
                this.gameTaskView.业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  this.三下丌且与丘丆丏且.丝丄丕世下世且东丂().丟下丄东上下丑与丆(), 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        }
        
        this.gameTaskView.丝一丅丆三东丂丞七();
        val_9 = this.三下丌且与丘丆丏且.一丈万丌丝一丄丟东();
        this.rewardListView.Setup(上业丟世三与七七三:  val_9);
        if(this.三下丌且与丘丆丏且.下丄丏丂且丘下丒丞() == null)
        {
                return;
        }
        
        val_9 = this.三下丌且与丘丆丏且.下丄丏丂且丘下丒丞();
        this.hammersView.Setup(丗七丟丈三不丕一三:  val_9);
        val_8 = this.hammersView;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
    }
    private void 下丆业七下丗专丆丄()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CanOpen, 丏业丟一东丂东丘丛:  true);
        this.rewardListView.Setup(上业丟世三与七七三:  this.三下丌且与丘丆丏且.一丈万丌丝一丄丟东());
    }
    private void 丈丛丈丐丐东上丁下()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.devLockedByLevel, 丕丗丘丑丛与丑业丒:  "DEV NeedLevel: "("DEV NeedLevel: ") + this.三下丌且与丘丆丏且.丘丆丐不丟丛丞丝与());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByLevel, 丏业丟一东丂东丘丛:  true);
    }
    private void 上丝丄东丁丝丁专与()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByCount, 丏业丟一东丂东丘丛:  true);
    }
    private void 丒丆丒丛下丟丁丄专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_LockedByTime, 丏业丟一东丂东丘丛:  true);
        this.lockedByTimeTimer.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_9171");
        this.lockedByTimeTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.三下丌且与丘丆丏且.一丂七丕丁下下丗丕(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ClanGovernorTaskCellView::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    private void 丌丆七丈丌丗一下万(丛丗丅丆万不丕七丏 世丝专丝与丑业丑万)
    {
        if(this.三下丌且与丘丆丏且 != 世丝专丝与丑业丑万)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public void U_OpenCell()
    {
        if(PGCompany.ClanGovernorController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        if((PGCompany.ClanGovernorController.丑七不且上丗丁一世().丐丏世丒丞丟丞世丑(业丌丆业丘丟丆丁丛:  this.三下丌且与丘丆丏且.业东丅东丌上丗丑不())) == false)
        {
                return;
        }
        
        this.mainUI.AnimateCellsCount();
    }
    public void U_ChangeTask()
    {
        UnityEngine.Debug.LogError(message:  "U_ChangeTask ClanGovernorTaskCellView");
        this.changeTaskBunner.丈且东丑丂且万丒丅(三下丌且与丘丆丏且:  this.三下丌且与丘丆丏且);
        if(this.changeTaskBunner == null)
        {
            
        }
    
    }
    public void U_CollectReward()
    {
        UnityEngine.Debug.LogError(message:  "U_CollectReward");
        bool val_1 = this.三下丌且与丘丆丏且.丙丛丘上万丆丝丄七();
    }
    public void DEV_IncrementTask()
    {
    
    }
    public void DEV_CompeteTask()
    {
    
    }
    public void U_TryOpenButton()
    {
        this.mainUI.AnimateCellsCount();
    }
    public ClanGovernorTaskCellView()
    {
    
    }

}
