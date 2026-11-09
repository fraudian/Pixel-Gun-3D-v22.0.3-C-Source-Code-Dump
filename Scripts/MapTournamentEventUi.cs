using UnityEngine;
internal sealed class MapTournamentEventUi : PGBehaviour
{
    // Fields
    private SimpleRewardWindowUi _simpleRewardWindowUi;
    private UnityEngine.Transform defaultContainer;
    private UnityEngine.Transform scoreContainer;
    private UnityEngine.Transform mainWindow;
    private LeaderboardEventControllerUi leaderboardEventControllerUi;
    private Rilisoft.ButtonHandler closeWindowButton;
    private Rilisoft.ButtonHandler goToBattleButton;
    private Rilisoft.ButtonHandler infoButton;
    private UnityEngine.GameObject GoToBattleButtonGo;
    private UnityEngine.GameObject GoToFirstBattleButtonGo;
    private UILabel discriptionLabel;
    private UILabel taskLabel;
    private UILabel endTournamentDate;
    private System.Collections.Generic.List<UILabel> eventNames;
    private UILabel attempsResetLabel;
    private UILabel attempsLabel;
    private UITexture eventPicture;
    private UnityEngine.GameObject attempsPointsPanel;
    private System.Collections.Generic.List<UnityEngine.GameObject> attempsPoints;
    private Rilisoft.ButtonHandler restProgressButton;
    private UnityEngine.Animator _mainContainerAnimator;
    private UILabel priceRestProgressLabel;
    private UnityEngine.GameObject buyAttempsPanel;
    private UITexture itemBuyAttempsIcon;
    private UnityEngine.GameObject deactivatePlayButton;
    private float _waitAnimationTime;
    private System.IDisposable 丂丈下丌不丅业丅丅;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    private UnityEngine.Coroutine 丏丄丏且丞与世丘下;
    private UnityEngine.GameObject _blockGoForAnimation;
    
    // Methods
    internal void 下丗丒丆丗丗丆东丈(System.Action 一丈下丕丗不丂丒世, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 与不下三丈专丘丂世, System.Action 东丅丛丐丁与丑丟丘)
    {
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_16;
        var val_17;
        SceneInfoController val_18;
        var val_19;
        MapTournamentEventUi.世丘丛上丞丆丟丟丐 val_1 = new MapTournamentEventUi.世丘丛上丞丆丟丟丐();
        if(val_1 != null)
        {
                .一丈下丕丗不丂丒世 = 一丈下丕丗不丂丒世;
            .丝且与丝丒丟万丁专 = this;
            .东丅丛丐丁与丑丟丘 = 东丅丛丐丁与丑丟丘;
        }
        else
        {
                mem[16] = 一丈下丕丗不丂丒世;
            mem[24] = this;
            mem[32] = 东丅丛丐丁与丑丟丘;
        }
        
        .与不下三丈专丘丂世 = 与不下三丈专丘丂世;
        this.closeWindowButton.ClearEvents();
        this.goToBattleButton.ClearEvents();
        this.restProgressButton.ClearEvents();
        this.infoButton.ClearEvents();
        if(this.closeWindowButton != 0)
        {
                this.closeWindowButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void MapTournamentEventUi.世丘丛上丞丆丟丟丐::丒丏丅一丆不上不世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.closeWindowButton.noSound = true;
        }
        
        if(this.goToBattleButton != 0)
        {
                this.goToBattleButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void MapTournamentEventUi.世丘丛上丞丆丟丟丐::丌万丛丘上下丂万丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.infoButton != 0)
        {
                this.infoButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void MapTournamentEventUi.世丘丛上丞丆丟丟丐::丏业与丐专且丅且不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.restProgressButton != 0)
        {
                this.restProgressButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void MapTournamentEventUi.世丘丛上丞丆丟丟丐::丌下丛丅丛与丛丒且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        val_16 = (MapTournamentEventUi.世丘丛上丞丆丟丟丐)[1152921537678916656].与不下三丈专丘丂世;
        this.丐且丘丑与万丞丑丅 = val_16;
        val_17 = null;
        val_17 = null;
        val_16 = this.丐且丘丑与万丞丑丅;
        val_18 = SceneInfoController.丄丘七三上丕世丞业;
        SceneInfo val_11 = val_18.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_16.丕丆丞丂业东与上丅());
        if(val_11 != 0)
        {
                val_18 = this.eventPicture;
            if(val_18 != 0)
        {
                val_18 = this.eventPicture;
            val_19 = static_value_081DACA8;
            val_19 = static_value_081DACA8;
            UnityEngine.Texture val_15 = static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_11.丙且上丒不下丑下丞());
        }
        
        }
        
        this.eventPicture.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        this.eventPicture.SetDirty();
        this.丝上丗不丒且世丌丑();
        this.丅丐丆丑世七丈丕丂();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        this.丏丈丞丐业专不世丝();
    }
    private void 丏丈丞丐业专不世丝()
    {
        this.丏东丄丞丛七世业丟();
        this.丏丄丏且丞与世丘下 = CoroutineRunner.Instance.StartCoroutine(routine:  this.且一丏丏专不丙东丁());
    }
    private void 丏东丄丞丛七世业丟()
    {
        if(this.丏丄丏且丞与世丘下 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丏丄丏且丞与世丘下);
    }
    private System.Collections.IEnumerator 且一丏丏专不丙东丁()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MapTournamentEventUi.东丏万丐业七丒丌且(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丅丐丆丑世七丈丕丂()
    {
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        if((this.丐且丘丑与万丞丑丅.丗丌且丅丗丅丝一丑() & 2147483648) != 0)
        {
            goto label_2;
        }
        
        this.leaderboardEventControllerUi.下与丞三丅丛丄七丕();
        if(this.mainWindow.parent == this.scoreContainer)
        {
                return;
        }
        
        this.GoToFirstBattleButtonGo.SetActive(value:  false);
        this.GoToBattleButtonGo.SetActive(value:  true);
        if(this.mainWindow != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        this.mainWindow.SetParent(p:  this.scoreContainer);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.mainWindow.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        return;
        label_2:
        if(this.mainWindow.parent == this.defaultContainer)
        {
                return;
        }
        
        this.GoToFirstBattleButtonGo.SetActive(value:  true);
        this.GoToBattleButtonGo.SetActive(value:  false);
        this.leaderboardEventControllerUi.丗丟万丂丘丈专丄丂();
        if(this.mainWindow != null)
        {
            goto label_21;
        }
        
        goto label_22;
    }
    internal void 丝上丗不丒且世丌丑()
    {
        int val_16;
        UILabel val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        UILabel val_50;
        var val_51;
        UnityEngine.GameObject val_52;
        UILabel val_53;
        var val_54;
        val_45 = this;
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        val_46 = 1152921505660731392;
        bool val_2 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.上万世丒丁万下丌丛(丏丒丒丌一丌东丘丝:  this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七(), 万且丕业与丗丗丝七:  true);
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_45 = this.丐且丘丑与万丞丑丅;
        string val_3 = val_45.丒丗丝不丕丈世丏丞();
        val_47 = "";
        val_45 = (val_3 == null) ? "" : (val_3);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.discriptionLabel, 丕丗丘丑丛与丑业丒:  val_45);
        string val_4 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丑世七丟丈丈业世丕(丏专丘丗下三丗丟丟:  this.丐且丘丑与万丞丑丅.丏专丘丗下三丗丟丟);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskLabel, 丕丗丘丑丛与丑业丒:  (val_4 == null) ? "" : (val_4));
        丈丞丕丘丕丗与上一 val_6 = 丈丞丕丘丕丗与上一.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  this.丐且丘丑与万丞丑丅.丙专且丂七与三丘丙);
        val_48 = 1152921504622075904;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.priceRestProgressLabel, 丕丗丘丑丛与丑业丒:  val_6.丟丂丞不专丆万丒世());
        UnityEngine.Texture val_13 = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  System.String.Format(format:  "{0}::{1}", arg0:  val_6.东与三丌丅三丒丏业().Replace(oldValue:  "Currency", newValue:  System.String.alignConst), arg1:  val_6.丟丂丞不专丆万丒世())).Icon;
        List.Enumerator<T> val_14 = this.eventNames.GetEnumerator();
        val_49 = 1152921526277221440;
        label_26:
        if(((-1286618848) & 1) == 0)
        {
            goto label_22;
        }
        
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_46 = this.丐且丘丑与万丞丑丅;
        string val_18 = val_46.东丙上东业丆不丟丘();
        val_46 = (val_18 == null) ? "" : (val_18);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_16.丐丏七丌丕丗业且上(), 丕丗丘丑丛与丑业丒:  val_46);
        goto label_26;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        int val_20 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丙一万东万丟东丝丑(丆业丗丁丕且上下丙:  this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        val_50 = this.attempsLabel;
        val_16 = val_20;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_50, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_20.丕不丞丏上与下一丟(下上丐丆丝丟丝丒不:  "Key_7944"), arg0:  val_16));
        if(val_20 == 0)
        {
            goto label_36;
        }
        
        val_49 = 1152921519068977584;
        val_50 = this.attempsPoints.Count - 1;
        val_47 = 1;
        goto label_38;
        label_57:
        UnityEngine.GameObject val_24 = this.attempsPoints.Item[val_50];
        if(val_20 < val_47)
        {
                val_51 = 1;
            val_52 = val_24;
        }
        else
        {
                val_52 = val_24;
            val_51 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_52, 丏业丟一东丂东丘丛:  false);
        if(this.attempsPoints.Item[val_50] != 0)
        {
                if((this.attempsPoints.Item[val_50].GetComponent<AnimatedAlpha>()) != 0)
        {
                val_28.alpha = 1f;
        }
        
        }
        
        val_50 = val_50 - 1;
        val_47 = 2;
        label_38:
        if((val_47 - 1) < this.attempsPoints.Count)
        {
            goto label_57;
        }
        
        this.上万一丄且丅万丅丌(下下丏一丙不丘丌丞:  false);
        val_48 = 1152921504622075904;
        val_46 = 1152921505660731392;
        goto label_58;
        label_36:
        this.上万一丄且丅万丅丌(下下丏一丙不丘丌丞:  true);
        label_58:
        System.TimeSpan val_33 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.业一上且丒且且丞丂(丆业丗丁丕且上下丙:  this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        if(val_33._ticks.TotalSeconds > 0f)
        {
                val_16 = val_33._ticks.Hours;
            val_50 = System.String.Format(format:  val_33._ticks.丕不丞丏上与下一丟(下上丐丆丝丟丝丒不:  "Key_7943"), arg0:  val_16, arg1:  val_33._ticks.Minutes);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.attempsResetLabel, 丕丗丘丑丛与丑业丒:  val_50);
            val_53 = this.attempsResetLabel;
            val_54 = 1;
        }
        else
        {
                val_53 = this.attempsResetLabel;
            val_54 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_53, 丏业丟一东丂东丘丛:  false);
        System.Nullable<System.TimeSpan> val_39 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        if(((-1286618824) & 1) == 0)
        {
                return;
        }
        
        val_45 = this.endTournamentDate;
        val_16 = val_39.HasValue.Days;
        val_50 = val_16;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_45, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_39.HasValue.丕不丞丏上与下一丟(下上丐丆丝丟丝丒不:  "Key_3394"), arg0:  val_16, arg1:  val_39.HasValue.Hours, arg2:  val_39.HasValue.Minutes));
    }
    private string 丕不丞丏上与下一丟(string 下上丐丆丝丟丝丒不)
    {
        return I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  下上丐丆丝丟丝丒不);
    }
    internal void 丗丟万丂丘丈专丄丂()
    {
        bool val_1 = this.丟三三业丆业丄丞且();
    }
    internal bool 丟三三业丆业丄丞且()
    {
        UnityEngine.MonoBehaviour val_3;
        var val_4;
        val_3 = this;
        if(this._blockGoForAnimation != 0)
        {
                if(this._blockGoForAnimation.activeSelf != false)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        }
        
        this.closeWindowButton.ClearEvents();
        this.goToBattleButton.ClearEvents();
        this.restProgressButton.ClearEvents();
        this.infoButton.ClearEvents();
        this.丏东丄丞丛七世业丟();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        val_3 = this._simpleRewardWindowUi;
        val_3.Close();
        val_4 = 1;
        return (bool)val_4;
    }
    public void ShowRewardsFromBox()
    {
        this._simpleRewardWindowUi.Show(丞丑丘丂不不丝丈丞:  PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丂七下丘丕丂三丅丅(与不下三丈专丘丂世:  this.丐且丘丑与万丞丑丅, 且丒丛与丞世丙丕丌:  1));
    }
    private void 上万一丄且丅万丅丌(bool 下下丏一丙不丘丌丞)
    {
        bool val_1 = 下下丏一丙不丘丌丞;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.deactivatePlayButton, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.attempsPointsPanel, 丏业丟一东丂东丘丛:  (~下下丏一丙不丘丌丞) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.restProgressButton, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buyAttempsPanel, 丏业丟一东丂东丘丛:  val_1);
    }
    private void 丒丟丏丟丗下万一专()
    {
    
    }
    public MapTournamentEventUi()
    {
        this._waitAnimationTime = 2f;
    }

}
