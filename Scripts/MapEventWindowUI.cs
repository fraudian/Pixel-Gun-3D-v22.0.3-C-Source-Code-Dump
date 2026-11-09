using UnityEngine;
public class MapEventWindowUI : PGBehaviour
{
    // Fields
    internal bool IsRatingWindow;
    internal Rilisoft.ButtonHandler ButtonHandlerExitWindow;
    internal Rilisoft.ButtonHandler ButtonHandlerExitWindowAlt;
    internal UIButton UIButtonToBattle;
    private UIButton UIButtonSearch;
    internal UILabel TrophiesMultiper;
    public UILabel[] eventNameLabel;
    public UILabel eventEndLabel;
    public UILabel eventDescriptionLabel;
    public UILabel[] modeNameLabel;
    internal UnityEngine.GameObject GetRewardLabel;
    public UITable rewardTable;
    public UIGrid modifiersGrid;
    public MapEventModifItem[] modifItems;
    public MapEventRewardItem[] rewardItems;
    public UnityEngine.GameObject rewardBGTriple;
    public UnityEngine.GameObject rewardBGDouble;
    public UITexture eventPicture;
    public UILabel[] mapNameLabels;
    public UnityEngine.GameObject specialReward;
    public UILabel attemptsLeftLabel;
    public UILabel specalRewardDescription;
    public UILabel specalRewardTimer;
    public UIBasicSprite specialRewardIcon;
    public UnityEngine.GameObject noPenalty;
    public UILabel specialRewardCount;
    public UnityEngine.GameObject specialRewardCountContainer;
    public UnityEngine.GameObject specialRewardGem;
    public UITable specialRewardTable;
    public UISprite specialRewardGear;
    public UnityEngine.GameObject specialRewardCheckmark;
    public UISprite specialProgress;
    public Rilisoft.ButtonHandler specialItemBtn;
    public UnityEngine.GameObject rateButton;
    public MapEventSettingPanel settingPanel;
    public UnityEngine.GameObject modifiersContainer;
    public MapEventWindowRate rateWindow;
    public Rilisoft.ButtonHandler rateCloseBtn;
    public UnityEngine.GameObject noRateIcon;
    public UnityEngine.GameObject dislikeRateIcon;
    public UnityEngine.GameObject likeRateIcon;
    public UnityEngine.GameObject progressSeparator;
    public UnityEngine.GameObject progressSeparatorContainer;
    private System.Collections.Generic.List<UnityEngine.GameObject> 七与七丟下丕万丁下;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    private Rilisoft.OfferItem 上丒丅丁丌七丄丐丆;
    private bool 三丟七一丈丂七丂丘;
    private bool 专下丐丙业且丗丟万;
    private bool 不丒不上丌世丄七东;
    private UnityEngine.GameObject _brawlSettings;
    private UISprite _brawlIcon;
    private UILabel _brawlLable;
    private UnityEngine.GameObject iconTeamDuel;
    private UnityEngine.GameObject iconDuel;
    private UnityEngine.GameObject iconTeamFight;
    private UnityEngine.GameObject iconDeathmatch;
    private UnityEngine.GameObject iconFlagCapture;
    private UnityEngine.GameObject iconCapturePoints;
    private Rilisoft.GameEventExtendedEventInfoView 丂且七丘丌丝丘丈一;
    private UILabel SizeMapLabel;
    private UILabel NeedReequipLabel;
    private UILabel EquipmentLabel;
    private UnityEngine.GameObject TouchToCloseLabel;
    private System.Collections.Generic.List<PGCompany.GameModeEvents.下丑一丈与丝与丐丛> 不东丁一且七业丗丟;
    private bool 且丅万业丏丛丏丅丕;
    private bool 业丆丑业丕丅业丙东;
    private System.IDisposable 世丏与丑丌丗丘丈丏;
    private System.IDisposable 丂丈下丌不丅业丅丅;
    
    // Properties
    private Rilisoft.GameEventExtendedEventInfoView 与丈丞丛丗丙上丕万 { get; }
    
    // Methods
    public void GoBattleBtnPressed()
    {
        var val_1;
        this.settingPanel.ClearAllUnequippedWeapons();
        val_1 = static_value_081DACA8;
        val_1 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.丁丗不东丛丐丟丛且();
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == null)
        {
                return;
        }
        
        PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.GoCompetitionRequest();
    }
    private void 丛与一丅上丛丝丏丏(bool 丆丄丗七丂丐世丂七)
    {
        丆丄丗七丂丐世丂七 = 丆丄丗七丂丐世丂七;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.NeedReequipLabel, 丏业丟一东丂东丘丛:  丆丄丗七丂丐世丂七);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.EquipmentLabel, 丏业丟一东丂东丘丛:  (~丆丄丗七丂丐世丂七) & 1);
        this.settingPanel.TweenReds();
    }
    public void UpdateEquipLabelStatus()
    {
        if(GameConnect.丕上丐丄三上丝专万() == false)
        {
                return;
        }
        
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        this.丛与一丅上丛丝丏丏(丆丄丗七丂丐世丂七:  this.丐且丘丑与万丞丑丅.丁丌丗丞丄丝不丄丛());
    }
    private Rilisoft.GameEventExtendedEventInfoView 丈万丝丄业丅丟世万()
    {
        if(this.专下丐丙业且丗丟万 == true)
        {
                return (Rilisoft.GameEventExtendedEventInfoView)this.丂且七丘丌丝丘丈一;
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if(val_2 != null)
        {
                Rilisoft.GameEventExtendedEventInfoView val_4 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventExtendedEventInfoView>(丅东专与不三丂丁丝:  val_2, 丒丘丏上丙丟丑丕丈:  "info", 丈东丘丏与丌东东下:  this.transform, 丛下丅丏丄且丁一业:  false);
            this.丂且七丘丌丝丘丈一 = val_4;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "NGUI"));
        }
        
        this.专下丐丙业且丗丟万 = true;
        return (Rilisoft.GameEventExtendedEventInfoView)this.丂且七丘丌丝丘丈一;
    }
    private void 丂丟丗丞丆丘与丕业(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一)
    {
        if(this.modifItems.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.modifItems[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
        this.modifItems[(long)丞世不丒下上上丝丑].上东与丛丞下丈专丈(一丙上不丌丆三丗一:  一丙上不丌丆三丗一);
    }
    private void 丈三七专上丙丙业丗(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.下丑一丈与丝与丐丛 一丙上不丌丆三丗一, System.Collections.Generic.KeyValuePair<CategoryNames, float> 丙丑丕丂下丏一丁专)
    {
        if(this.modifItems.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.modifItems[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
        this.modifItems[(long)丞世不丒下上上丝丑].七专丆世丆丑一丈丆(一丙上不丌丆三丗一:  一丙上不丌丆三丗一, 丙丑丕丂下丏一丁专:  new System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>() {Value = 丙丑丕丂下丏一丁专.Value});
    }
    private void 丗丞丆丑不丛丛丂上(int 丞世不丒下上上丝丑, PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 丗七丟丈三不丕一三)
    {
        if(this.rewardItems.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.rewardItems[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
        this.rewardItems[(long)丞世不丒下上上丝丑].上东与丛丞下丈专丈(丗七丟丈三不丕一三:  丗七丟丈三不丕一三);
    }
    internal void 丏丛与业丆丝世丒丗()
    {
        var val_11 = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  this.丐且丘丑与万丞丑丅.丕丆丞丂业东与上丅())) == 0)
        {
                return;
        }
        
        if(this.SizeMapLabel == 0)
        {
                return;
        }
        
        this.SizeMapLabel.gameObject.SetActive(value:  true);
        if(val_2.sizeMap > 3)
        {
                return;
        }
        
        var val_11 = 106029720 + (val_2.sizeMap) << 2;
        val_11 = val_11 + 106029720;
        goto (106029720 + (val_2.sizeMap) << 2 + 106029720);
    }
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅, bool 丛一丆专世丝丄丒与)
    {
        float val_186;
        bool val_243;
        var val_244;
        UnityEngine.GameObject val_245;
        bool val_246;
        var val_247;
        var val_249;
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_250;
        var val_251;
        float val_252;
        float val_253;
        float val_254;
        var val_255;
        var val_256;
        float val_257;
        float val_258;
        var val_259;
        var val_260;
        float val_263;
        bool val_264;
        var val_265;
        float val_267;
        float val_268;
        UISprite val_269;
        var val_270;
        object val_271;
        var val_273;
        string val_274;
        object val_275;
        var val_276;
        var val_277;
        UnityEngine.GameObject val_278;
        var val_279;
        var val_280;
        var val_282;
        var val_283;
        val_243 = 丛一丆专世丝丄丒与;
        this.丐且丘丑与万丞丑丅 = 丐且丘丑与万丞丑丅;
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_244 = 1152921525549507984;
        if(val_1.HasValue.丙东专丂世丈丏丁丂() == 4)
        {
                if((528237800 & 1) != 0)
        {
            goto label_3;
        }
        
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_3 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_3.HasValue.丙东专丂世丈丏丁丂() == 5) && ((528237800 & 1) != 0))
        {
                label_3:
            this.settingPanel.clearedUnequippedWeapons = false;
            this.settingPanel.丐且丘丑与万丞丑丅 = 丐且丘丑与万丞丑丅;
            this.settingPanel.UpdateInventoryPanel();
            this.丏丛与业丆丝世丒丗();
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_5 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_245 = val_5.HasValue.丙东专丂世丈丏丁丂();
        if((val_245 != 4) || ((528237800 & 1) == 0))
        {
            goto label_11;
        }
        
        this.iconDeathmatch.SetActive(value:  false);
        this.iconTeamFight.SetActive(value:  false);
        this.iconTeamDuel.SetActive(value:  false);
        this.iconDuel.SetActive(value:  false);
        this.iconCapturePoints.SetActive(value:  false);
        val_245 = this.iconFlagCapture;
        val_245.SetActive(value:  false);
        System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_7 = 丐且丘丑与万丞丑丅.业丄丄且丕丕不一万();
        if((528237792 & 1) == 0)
        {
            goto label_23;
        }
        
        int val_8 = val_7.HasValue.丙东专丂世丈丏丁丂();
        if(val_8 > 8)
        {
            goto label_20;
        }
        
        var val_245 = 106029736 + (val_8) << 2;
        val_245 = val_245 + 106029736;
        goto (106029736 + (val_8) << 2 + 106029736);
        label_20:
        if(val_8 == 16)
        {
                val_245 = this.iconTeamDuel;
            SetActive(value:  true);
        }
        
        label_23:
        this.专丑丅专万丟世业专();
        label_11:
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GetRewardLabel, 丏业丟一东丂东丘丛:  false);
        val_246 = this.丐且丘丑与万丞丑丅.不丁丄下三丝与一丘();
        goto label_33;
        label_39:
        this.modifItems[0].gameObject.SetActive(value:  false);
        label_33:
        if(1 < this.modifItems.Length)
        {
            goto label_39;
        }
        
        this.不东丁一且七业丗丟.Clear();
        this.不东丁一且七业丗丟.AddRange(collection:  丐且丘丑与万丞丑丅.丑丛业丛东业且丒下());
        this.三丟七一丈丂七丂丘 = val_243;
        if(丐且丘丑与万丞丑丅 != null)
        {
                PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_14 = 丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13);
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_16 = 丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  19);
        if((0.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13)) == null)
        {
            goto label_46;
        }
        
        this.settingPanel.gameObject.SetActive(value:  true);
        this.modifiersContainer.SetActive(value:  false);
        if(this._brawlSettings != 0)
        {
                this._brawlSettings.SetActive(value:  false);
        }
        
        this.settingPanel.丐且丘丑与万丞丑丅 = 丐且丘丑与万丞丑丅;
        this.settingPanel.UpdateInventoryPanel();
        goto label_55;
        label_62:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardItems[0].gameObject, 丏业丟一东丂东丘丛:  false);
        label_55:
        if(1 < this.rewardItems.Length)
        {
            goto label_62;
        }
        
        System.Collections.Generic.List<PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗> val_20 = 丐且丘丑与万丞丑丅.丙丐丗丏与丛丌丐丂();
        if(this.noPenalty != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noPenalty, 丏业丟一东丂东丘丛:  false);
        }
        
        val_247 = 0;
        goto label_94;
        label_127:
        if(val_20.Count <= 0)
        {
            goto label_94;
        }
        
        val_246 = val_20.Item[0];
        if(val_246 == null)
        {
            goto label_94;
        }
        
        if((val_246.不业丙丒丂丞下丆丙() != 4) || (this.IsRatingWindow == false))
        {
            goto label_75;
        }
        
        if(this.TrophiesMultiper != 0)
        {
                if(this.TrophiesMultiper.gameObject.activeSelf != false)
        {
                val_246 = System.String.Format(format:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8944"), arg0:  val_246.东丙万丌丅丙丝丕业());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.TrophiesMultiper, 丕丗丘丑丛与丑业丒:  val_246);
        }
        
        }
        
        val_247 = val_247;
        goto label_94;
        label_75:
        if(val_246.不业丙丒丂丞下丆丙() != 8)
        {
            goto label_87;
        }
        
        val_247 = val_246;
        goto label_94;
        label_87:
        if(val_246.一东丅业东丌丗不丞() == false)
        {
            goto label_94;
        }
        
        if(val_246.不业丙丒丂丞下丆丙() != 10)
        {
                if(val_246.不业丙丒丂丞下丆丙() != 2)
        {
                if(val_246.不业丙丒丂丞下丆丙() != 9)
        {
            goto label_92;
        }
        
        }
        
        }
        
        label_124:
        if(0 == 0)
        {
            goto label_93;
        }
        
        label_116:
        val_247 = val_247;
        goto label_94;
        label_93:
        if(val_246.不业丙丒丂丞下丆丙() != 16)
        {
                if(val_246.不业丙丒丂丞下丆丙() != 6)
        {
            goto label_96;
        }
        
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_39 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(((val_39 == null) || (val_39.专丁丟丏丁丏不丗三() == false)) || (val_39.丗丄上丑丑丅丐丒丌() == true))
        {
            goto label_116;
        }
        
        label_96:
        if((val_246.不业丙丒丂丞下丆丙() != 17) && (val_246.不业丙丒丂丞下丆丙() != 18))
        {
                if(val_246.不业丙丒丂丞下丆丙() != 19)
        {
                if(val_246.不业丙丒丂丞下丆丙() != 20)
        {
            goto label_104;
        }
        
        }
        
        }
        
        PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_47 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
        if((((val_47 == null) || (val_47.丞一丞上丞丞且丐丅() == false)) || (val_47.不丆丑与七下一丛丅() == false)) || (val_47.丞不丅且三丆与丕且() == false))
        {
            goto label_116;
        }
        
        label_104:
        if(val_246.不业丙丒丂丞下丆丙() != 12)
        {
                if(val_246.不业丙丒丂丞下丆丙() != 3)
        {
            goto label_111;
        }
        
        }
        
        Rilisoft.丛且世丐丆上七业丁 val_54 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
        if((val_54 == null) || (val_54.丈丐丞丐上丑且丕万() == false))
        {
            goto label_116;
        }
        
        label_111:
        var val_56 = (1 != 0) ? 1 : 0;
        if(val_246.不业丙丒丂丞下丆丙() != 7)
        {
            goto label_117;
        }
        
        if(this.noPenalty == 0)
        {
            goto label_94;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noPenalty, 丏业丟一东丂东丘丛:  true);
        goto label_94;
        label_92:
        var val_60 = (val_246.不业丙丒丂丞下丆丙() == 1) ? 1 : 0;
        goto label_124;
        label_117:
        this.丗丞丆丑不丛丛丂上(丞世不丒下上上丝丑:  0, 丗七丟丈三不丕一三:  val_246);
        label_94:
        if(0 < val_20.Count)
        {
            goto label_127;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardBGTriple, 丏业丟一东丂东丘丛:  (1 > 2) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardBGDouble, 丏业丟一东丂东丘丛:  (1 < 3) ? 1 : 0);
        val_249 = 1152921525549507984;
        goto label_130;
        label_135:
        this.eventNameLabel[0].text = 丐且丘丑与万丞丑丅.东丙上东业丆不丟丘();
        label_130:
        if(1 < this.eventNameLabel.Length)
        {
            goto label_135;
        }
        
        val_243 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  丐且丘丑与万丞丑丅.丕丆丞丂业东与上丅());
        if((val_243 == 0) || (this.eventPicture == 0))
        {
            goto label_145;
        }
        
        if(val_243 == false)
        {
            goto label_146;
        }
        
        string val_70 = val_243.丙且上丒不下丑下丞() + "_squad";
        goto label_150;
        label_46:
        UnityEngine.GameObject val_71 = this.settingPanel.gameObject;
        if(val_16 == null)
        {
            goto label_152;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_71, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.modifiersContainer, 丏业丟一东丂东丘丛:  true);
        if(this._brawlSettings != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._brawlSettings, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this._brawlIcon != 0)
        {
                this._brawlIcon.spriteName = val_16.丆丂丙丞一丛丞丄丘();
        }
        
        if(this._brawlLable == 0)
        {
            goto label_55;
        }
        
        this._brawlLable.text = val_16.东且丏丆万与东丙万();
        goto label_55;
        label_152:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_71, 丏业丟一东丂东丘丛:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this._brawlSettings)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._brawlSettings, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.modifiersContainer, 丏业丟一东丂东丘丛:  (this.不东丁一且七业丗丟.Count > 0) ? 1 : 0);
        goto label_178;
        label_183:
        if(this.不东丁一且七业丗丟.Item[0].不业丙丒丂丞下丆丙() == 7)
        {
            goto label_181;
        }
        
        label_178:
        if(1 < this.不东丁一且七业丗丟.Count)
        {
            goto label_183;
        }
        
        label_181:
        if((0 == 1) || (this.不东丁一且七业丗丟.Count < 3))
        {
            goto label_186;
        }
        
        if(this.不东丁一且七业丗丟 == null)
        {
            goto label_188;
        }
        
        val_250 = this.不东丁一且七业丗丟.Item[0];
        goto label_189;
        label_146:
        label_150:
        UnityEngine.Texture val_86 = static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_243.丙且上丒不下丑下丞());
        val_249 = 1152921525549507984;
        label_145:
        if(丐且丘丑与万丞丑丅 != null)
        {
                System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_87 = 丐且丘丑与万丞丑丅.且与业丞丞业丐丄丗();
        }
        else
        {
                System.Collections.Generic.List<PGCompany.GameModeEvents.丝一七万丗不丄丒上> val_88 = 0.且与业丞丞业丐丄丗();
        }
        
        val_251 = 1152921525549506960;
        if(丐且丘丑与万丞丑丅.且与业丞丞业丐丄丗().Count <= 0)
        {
            goto label_209;
        }
        
        PGCompany.GameModeEvents.丝一七万丗不丄丒上 val_92 = 丐且丘丑与万丞丑丅.且与业丞丞业丐丄丗().Item[0];
        if((val_247 == 0) || (val_92 == null))
        {
            goto label_202;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialReward, 丏业丟一东丂东丘丛:  true);
        val_252 = 0f;
        val_253 = 0f;
        val_254 = 0f;
        this.eventPicture.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_252, m_Width = val_253, m_Height = val_254};
        this.eventPicture.SetDirty();
        PGCompany.GameModeEvents.GMERewardConditionProgress val_93 = val_92.丄且丙丂丆不一万七(丂丘丈丈专万丈丈丆:  true, 丑丟丙丄不丟丄丗丕:  丐且丘丑与万丞丑丅);
        if(val_93 == null)
        {
            goto label_207;
        }
        
        int val_94 = val_93.Points1;
        goto label_208;
        label_202:
        val_251 = 1152921525549506960;
        label_209:
        if(this.specialReward != 0)
        {
                this.specialReward.SetActive(value:  false);
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_96 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_96.HasValue.丙东专丂世丈丏丁丂() == 4) && ((528237800 & 1) != 0))
        {
            
        }
        
        this.eventPicture.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        this.eventPicture.SetDirty();
        if((this.mapNameLabels == null) || (this.mapNameLabels.Length == 0))
        {
            goto label_221;
        }
        
        this.mapNameLabels[0].gameObject.SetActive(value:  true);
        val_255 = 0;
        goto label_225;
        label_230:
        this.mapNameLabels[1].text = val_243.上丘丙丒一丈丕丈世();
        val_255 = 2;
        label_225:
        if(val_255 < this.mapNameLabels.Length)
        {
            goto label_230;
        }
        
        label_221:
        val_256 = 0;
        goto label_231;
        label_207:
        int val_100 = 0.Points1;
        label_208:
        float val_251 = (float)val_92;
        val_257 = (float)val_93.Points / val_251;
        this.specialProgress.fillAmount = val_257;
        var val_103 = (val_92 != 1) ? (val_92 - 1) : 0;
        int val_105 = val_103 - this.七与七丟下丕万丁下.Count;
        val_258 = (float)this.specialProgress.width;
        if(val_105 >= 1)
        {
                do
        {
            UnityEngine.GameObject val_111 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.progressSeparator.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.progressSeparator.gameObject);
            val_111.SetActive(value:  true);
            this.七与七丟下丕万丁下.Add(item:  val_111);
            val_105 = val_105 - 1;
        }
        while(val_105 != 0);
        
        }
        
        val_259 = val_247;
        val_260 = 0;
        val_251 = val_258 / val_251;
        goto label_255;
        label_259:
        UnityEngine.GameObject val_112 = this.七与七丟下丕万丁下.Item[0];
        if(val_260 < val_103)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_112, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_115 = UnityEngine.Vector3.right;
            val_260 = 1;
            UnityEngine.Vector3 val_116 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_115.x, y = val_115.y, z = val_115.z}, d:  1f);
            val_254 = val_251;
            UnityEngine.Vector3 val_117 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_116.x, y = val_116.y, z = val_116.z}, d:  val_254);
            val_258 = val_117.x;
            val_263 = val_117.z;
            val_257 = val_258;
            val_252 = val_117.y;
            val_253 = val_263;
            this.七与七丟下丕万丁下.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = val_257, y = val_252, z = val_253};
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_112, 丏业丟一东丂东丘丛:  false);
            val_260 = 1;
        }
        
        label_255:
        if(val_260 < this.七与七丟下丕万丁下.Count)
        {
            goto label_259;
        }
        
        UnityEngine.Texture val_120 = val_259.丂丑丞丝且万丐万丟().Texture;
        val_264 = val_246;
        val_246 = val_93;
        if(val_259.丂丑丞丝且万丐万丟().Type != 1070)
        {
                if(val_259.丂丑丞丝且万丐万丟().Type != 1000)
        {
            goto label_265;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCountContainer, 丏业丟一东丂东丘丛:  true);
        this.specialRewardCount.text = val_259.丂丑丞丝且万丐万丟().Count.ToString();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardGear.gameObject, 丏业丟一东丂东丘丛:  (val_259.丂丑丞丝且万丐万丟().Type == 1070) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardGem, 丏业丟一东丂东丘丛:  (val_259.丂丑丞丝且万丐万丟().Type == 1000) ? 1 : 0);
        val_265 = 1152921505284374528;
        if(val_259.丂丑丞丝且万丐万丟().Type != 1070)
        {
            goto label_276;
        }
        
        System.Nullable<ItemRarity> val_138 = val_259.丂丑丞丝且万丐万丟().Rarity;
        if((528237744 & 1) == 0)
        {
            goto label_276;
        }
        
        System.Nullable<ItemRarity> val_140 = val_259.丂丑丞丝且万丐万丟().Rarity;
        UnityEngine.Color val_141 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_140.HasValue);
        val_267 = val_141.r;
        val_258 = val_141.g;
        val_268 = val_141.b;
        val_263 = val_141.a;
        this.specialRewardCount.color = new UnityEngine.Color() {r = val_267, g = val_258, b = val_268, a = val_263};
        val_269 = this.specialRewardGear;
        if(val_269 != null)
        {
            goto label_283;
        }
        
        goto label_282;
        label_276:
        val_269 = this.specialRewardCount;
        UnityEngine.Color val_142 = UnityEngine.Color.white;
        val_267 = val_142.r;
        val_258 = val_142.g;
        val_268 = val_142.b;
        val_263 = val_142.a;
        if(val_269 != null)
        {
            goto label_283;
        }
        
        label_282:
        label_283:
        val_269.color = new UnityEngine.Color() {r = val_267, g = val_258, b = val_268, a = val_263};
        goto label_284;
        label_265:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCountContainer, 丏业丟一东丂东丘丛:  (val_246.CompleteResult == 1) ? 1 : 0);
        val_265 = 1152921505284374528;
        label_284:
        if((this.mapNameLabels != null) && (this.mapNameLabels.Length != 0))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mapNameLabels[0].gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specalRewardDescription.gameObject, 丏业丟一东丂东丘丛:  (val_246.CompleteResult != 1) ? 1 : 0);
        if(val_246.CompleteResult != 1)
        {
            goto label_299;
        }
        
        val_270 = null;
        val_270 = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_259.丂丑丞丝且万丐万丟().Id)) == false)
        {
            goto label_304;
        }
        
        label_373:
        val_271 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_259.丂丑丞丝且万丐万丟().Id);
        if(val_271 == null)
        {
            goto label_308;
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_271.业东丅东丌上丗丑不())) != null)
        {
            goto label_338;
        }
        
        string val_159 = val_271.三与丛丑且丐丈业丌();
        goto label_313;
        label_299:
        val_273 = this;
        this.attemptsLeftLabel.text = val_92;
        this.specalRewardDescription.text = val_92;
        val_249 = 1152921525549507984;
        goto label_378;
        label_304:
        if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_259.丂丑丞丝且万丐万丟().Id)) == false)
        {
            goto label_321;
        }
        
        val_274 = val_259.丂丑丞丝且万丐万丟().Id;
        bool val_166 = 丙丞丟丑丗丅专丈一.专丙丄丏万业且丑上(上与三丛丛一万丘丟:  val_274);
        goto label_325;
        label_321:
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_259.丂丑丞丝且万丐万丟().Id)) == false)
        {
            goto label_334;
        }
        
        val_274 = val_259.丂丑丞丝且万丐万丟().Id;
        label_325:
        val_259 = val_259;
        if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  val_274)) == true)
        {
            goto label_338;
        }
        
        label_313:
        val_271 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_259.丂丑丞丝且万丐万丟().Id);
        val_275 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_259.丂丑丞丝且万丐万丟().Id);
        goto label_346;
        label_308:
        val_275 = 0;
        goto label_346;
        label_188:
        val_250 = 0.Item[0];
        label_189:
        this.不东丁一且七业丗丟.set_Item(index:  1, value:  val_250);
        this.不东丁一且七业丗丟.set_Item(index:  0, value:  this.不东丁一且七业丗丟.Item[1]);
        label_186:
        val_276 = 0;
        goto label_348;
        label_364:
        if(this.不东丁一且七业丗丟.Count <= val_276)
        {
            goto label_361;
        }
        
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_182 = this.不东丁一且七业丗丟.Item[0];
        if(val_182 == null)
        {
            goto label_361;
        }
        
        if(val_182.不业丙丒丂丞下丆丙() != 8)
        {
            goto label_353;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_185 = val_182.丛丅下丆丗丏三丁丕<System.Collections.Generic.Dictionary<CategoryNames, System.Single>>(丒丑丂丐丕丒丕东与:  "custom").GetEnumerator();
        goto label_355;
        label_356:
        string val_187 = 0.丐丏七丌丕丗业且上();
        this.丈三七专上丙丙业丗(丞世不丒下上上丝丑:  0, 一丙上不丌丆三丗一:  val_182, 丙丑丕丂下丏一丁专:  new System.Collections.Generic.KeyValuePair<CategoryNames, System.Single>() {Value = val_186});
        var val_255 = 1;
        label_355:
        if((528237760 & 1) != 0)
        {
            goto label_356;
        }
        
        var val_254 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_254 == 1)
        {
            goto label_360;
        }
        
        var val_253 = 0;
        val_253 = val_253 ^ 0;
        val_254 = val_254 + val_253;
        goto label_361;
        label_360:
        label_353:
        this.丂丟丗丞丆丘与丕业(丞世不丒下上上丝丑:  1, 一丙上不丌丆三丗一:  val_182);
        val_255 = val_255 + 1;
        label_361:
        val_276 = 1;
        label_348:
        if(val_276 < this.不东丁一且七业丗丟.Count)
        {
            goto label_364;
        }
        
        goto label_55;
        label_334:
        val_277 = null;
        val_259 = val_259;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_259.丂丑丞丝且万丐万丟().Id)) == true)
        {
            goto label_373;
        }
        
        label_338:
        val_275 = 0;
        val_271 = 0;
        label_346:
        val_273 = this;
        if((val_271 | val_275) != 0)
        {
                this.attemptsLeftLabel.text = System.String.Format(format:  "{0}\n{1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4573"), arg1:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4547"), arg0:  System.String.Format(format:  "{0}/{1}", arg0:  val_275, arg1:  val_271)));
            val_249 = 1152921525549507984;
            val_259 = ;
            val_246 = val_93;
            val_264 = val_246;
        }
        else
        {
                val_249 = 1152921525549507984;
            this.attemptsLeftLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4573");
        }
        
        label_378:
        if(val_246.CompleteResult == 1)
        {
            
        }
        
        this.attemptsLeftLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        System.DateTimeOffset val_200 = System.DateTimeOffset.Now;
        System.DateTime val_204 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (long)FriendsController.丝丗专上三不丄丑丑() + (int)val_200.m_dateTime.dateData.TotalSeconds);
        var val_256 = 24;
        val_256 = val_256 - val_204.dateData.Hour;
        val_243 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6794"), arg0:  UnityEngine.Mathf.Max(a:  1, b:  UnityEngine.Mathf.RoundToInt(f:  (float)val_256)));
        this.specalRewardTimer.text = val_243;
        val_251 = 1152921525549506960;
        var val_211 = (val_246.CompleteResult == 1) ? 1 : 0;
        val_211 = val_264 & val_211;
        if(val_211 != true)
        {
            goto label_398;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.attemptsLeftLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCheckmark, 丏业丟一东丂东丘丛:  true);
        UnityEngine.GameObject val_212 = this.specialRewardTable.gameObject;
        val_279 = 0;
        goto label_402;
        label_398:
        if(val_246.CompleteResult != 1)
        {
            goto label_404;
        }
        
        var val_215 = (val_246.CompleteResult != 1) ? 1 : 0;
        val_215 = val_264 | val_215;
        if(val_215 == true)
        {
            goto label_406;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.attemptsLeftLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCheckmark, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardTable.gameObject, 丏业丟一东丂东丘丛:  false);
        val_278 = this.GetRewardLabel;
        goto label_410;
        label_404:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCheckmark, 丏业丟一东丂东丘丛:  false);
        label_410:
        val_279 = 1;
        label_402:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardTable.gameObject, 丏业丟一东丂东丘丛:  true);
        label_406:
        label_231:
        this.上丒丅丁丌七丄丐丆 = val_259.丂丑丞丝且万丐万丟();
        val_280 = 0;
        if(this.eventDescriptionLabel != 0)
        {
                val_280 = 0;
            this.eventDescriptionLabel.text = 丐且丘丑与万丞丑丅.丒丗丝不丕丈世丏丞();
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_221 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((((val_221.HasValue.丙东专丂世丈丏丁丂() == 4) && ((528237800 & 1) != 0)) && (this.modeNameLabel != null)) && (this.modeNameLabel.Length >= 1))
        {
                val_243 = 1152921505066536960;
            val_246 = 1152921504691085312;
            do
        {
            if(0 >= this.modeNameLabel.Length)
        {
                val_280 = 0;
        }
        
            System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_224 = 丐且丘丑与万丞丑丅.业丄丄且丕丕不一万();
            var val_258 = 0;
            val_258 = val_258 + 1;
            val_280 = 0;
            this.modeNameLabel[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[null]);
        }
        while(1 < this.modeNameLabel.Length);
        
        }
        
        this.业丆丑业丕丅业丙东 = true;
        this.丐东丛与与上丑丛不();
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_228 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        this.七丝丏东东丘丆丒且(且下丕七丙丗丄不七:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = val_228.HasValue});
        val_244 = 1152921525549507984;
        if(this.NeedReequipLabel != 0)
        {
                this.NeedReequipLabel.gameObject.SetActive(value:  false);
            this.EquipmentLabel.gameObject.SetActive(value:  true);
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_232 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        val_245 = val_232.HasValue.丙东专丂世丈丏丁丂();
        if((val_245 == 4) && ((528237800 & 1) != 0))
        {
                this.丛与一丅上丛丝丏丏(丆丄丗七丂丐世丂七:  丐且丘丑与万丞丑丅.丁丌丗丞丄丝不丄丛());
        }
        
        if(丐且丘丑与万丞丑丅 != null)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_236 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
            val_245 = val_236.HasValue.丙东专丂世丈丏丁丂();
            if((val_245 == 4) && ((528237800 & 1) != 0))
        {
                val_282 = static_value_081DACA8;
            val_282 = static_value_081DACA8;
            val_245 = mem[static_value_081DACA8 + 184 + 16];
            val_245 = static_value_081DACA8 + 184 + 16;
            if(val_245 != 0)
        {
                val_283 = static_value_081DACA8;
            val_245 = 丐且丘丑与万丞丑丅.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13).丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
            val_283 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16.IsFiltermapWatchedInCompetition(与丕丁三万专世不丅:  val_245)) != false)
        {
                val_245 = this.settingPanel;
            val_245.ClearAllUnequippedWeapons();
        }
        
        }
        
        }
        
        }
        
        if(this.且丅万业丏丛丏丅丕 == false)
        {
                return;
        }
        
        val_245 = 丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七();
        if((MapEventWindowRate.丙丘丛丟丈丁丒业丄(丑丐丗三丒世丏东丅:  val_245)) == 0)
        {
                MapEventWindowRate.丁三丑业专丈一丛丆(丑丐丗三丒世丏东丅:  丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七(), 丙业与丙丗丝不丈东:  3);
        }
        
        this.丁丈世丟丟世丑丏丕();
    }
    internal void 七丝丏东东丘丆丒且(System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> 且下丕七丙丗丄不七)
    {
        if((529689288 & 1) != 0)
        {
                if((且下丕七丙丗丄不七.HasValue.丙东专丂世丈丏丁丂() == 1) && ((529689272 & 1) != 0))
        {
                if(this.IsRatingWindow == false)
        {
            goto label_4;
        }
        
        }
        
        }
        
        this.丕丟与丂丄万业一丈();
        return;
        label_4:
        int val_3 = MapEventWindowRate.丙丘丛丟丈丁丒业丄(丑丐丗三丒世丏东丅:  this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rateButton, 丏业丟一东丂东丘丛:  (val_3 >> 31) ^ 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noRateIcon, 丏业丟一东丂东丘丛:  ((val_3 == 0) ? 1 : 0) | ((val_3 == 3) ? 1 : 0));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.likeRateIcon, 丏业丟一东丂东丘丛:  (val_3 == 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dislikeRateIcon, 丏业丟一东丂东丘丛:  (val_3 == 2) ? 1 : 0);
        this.且丅万业丏丛丏丅丕 = (val_3 == 0) ? 1 : 0;
    }
    private void 丕丟与丂丄万业一丈()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rateButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noRateIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.likeRateIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dislikeRateIcon, 丏业丟一东丂东丘丛:  false);
        this.且丅万业丏丛丏丅丕 = false;
    }
    private void 丐东丛与与上丑丛不()
    {
        string val_17;
        int val_18;
        int val_19;
        int val_20;
        var val_21;
        val_17 = this;
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        if(this.eventEndLabel == 0)
        {
                return;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_2.HasValue.丙东专丂世丈丏丁丂() != 4) || ((530032168 & 1) == 0))
        {
            goto label_7;
        }
        
        if(this.丐且丘丑与万丞丑丅.七丂丌丈丄专丄三世() == false)
        {
            goto label_9;
        }
        
        System.Nullable<System.TimeSpan> val_6 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        if((530032152 & 1) == 0)
        {
            goto label_13;
        }
        
        System.Nullable<System.TimeSpan> val_7 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        val_18 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        goto label_17;
        label_7:
        val_19 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4959");
        System.Nullable<System.TimeSpan> val_10 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        if((530032152 & 1) == 0)
        {
            goto label_21;
        }
        
        System.Nullable<System.TimeSpan> val_11 = this.丐且丘丑与万丞丑丅.丙世丑丅丒丑业与不();
        val_20 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        goto label_25;
        label_9:
        val_19 = System.String.alignConst;
        if(this.eventEndLabel != null)
        {
            goto label_30;
        }
        
        goto label_27;
        label_21:
        val_20 = System.String.alignConst;
        label_25:
        val_17 = System.String.Format(format:  val_19, arg0:  val_20);
        this.eventEndLabel.text = val_17;
        return;
        label_13:
        val_18 = System.String.alignConst;
        label_17:
        val_19 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4959"), arg0:  val_18);
        if(this.eventEndLabel != null)
        {
            goto label_30;
        }
        
        label_27:
        label_30:
        this.eventEndLabel.text = val_19;
        if(丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且() == true)
        {
                return;
        }
        
        val_17 = this.丐且丘丑与万丞丑丅;
        if(val_17.七丂丌丈丄专丄三世() == true)
        {
                return;
        }
        
        val_21 = static_value_081DACA8;
        val_21 = static_value_081DACA8;
        val_17 = mem[static_value_081DACA8 + 184 + 16];
        val_17 = static_value_081DACA8 + 184 + 16;
        val_17.丏丐不三丘丌不丟不();
    }
    private void 丗业一丛丝丝丝丁万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        object val_4;
        var val_5;
        MapEventWindowUI.丛三上上七丒万丑丅 val_1 = new MapEventWindowUI.丛三上上七丒万丑丅();
        if(val_1 != null)
        {
                val_4 = val_1;
            .不丟丗丏丛丕不丁丌 = 不丟丗丏丛丕不丁丌;
        }
        else
        {
                val_4 = 16;
            mem[16] = 不丟丗丏丛丕不丁丌;
        }
        
        .丗丛不丁丑专专丂且 = 丗丛不丁丑专专丂且;
        if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  val_1, method:  System.Void MapEventWindowUI.丛三上上七丒万丑丅::东丒丏不与下三丘丏()))) != false)
        {
                return;
        }
        
        val_5 = static_value_081DACA8;
        val_5 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.三专丈丒丏不丄丗丌(不丟丗丏丛丕不丁丌:  val_4, 丗丛不丁丑专专丂且:  (MapEventWindowUI.丛三上上七丒万丑丅)[1152921530906934208].丗丛不丁丑专专丂且);
    }
    private void 丗世丒丕七丆丒丙一()
    {
        this.丛与一丅上丛丝丏丏(丆丄丗七丂丐世丂七:  false);
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Input.GetKeyDown(key:  119)) == false)
        {
                return;
        }
        
        this.丛与一丅上丛丝丏丏(丆丄丗七丂丐世丂七:  false);
    }
    private void Awake()
    {
        object val_16;
        System.EventHandler val_17;
        System.Action val_18;
        val_16 = this;
        if(this.ButtonHandlerExitWindow != 0)
        {
                val_17 = 1152921505704501248;
            if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 != 0)
        {
                System.EventHandler val_3 = null;
            val_17 = val_3;
            val_3 = new System.EventHandler(object:  PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业, method:  System.Void PGCompany.GameModeHub.GMHMainView::三专丈丒丏不丄丗丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.ButtonHandlerExitWindow.add_Clicked(丙业与丙丗丝不丈东:  val_3);
        }
        
        }
        
        if(this.ButtonHandlerExitWindowAlt != 0)
        {
                val_17 = 1152921505704501248;
            if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 != 0)
        {
                System.EventHandler val_6 = null;
            val_17 = val_6;
            val_6 = new System.EventHandler(object:  PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业, method:  System.Void PGCompany.GameModeHub.GMHMainView::三专丈丒丏不丄丗丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.ButtonHandlerExitWindowAlt.add_Clicked(丙业与丙丗丝不丈东:  val_6);
        }
        
        }
        
        if(this.specialItemBtn != 0)
        {
                System.EventHandler val_8 = null;
            val_17 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void MapEventWindowUI::丗丘且丂丞一丌与丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.specialItemBtn.add_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        if(this.rateCloseBtn != 0)
        {
                System.EventHandler val_10 = null;
            val_17 = val_10;
            val_10 = new System.EventHandler(object:  this, method:  System.Void MapEventWindowUI::三丘丟世丏丁丏七丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.rateCloseBtn.add_Clicked(丙业与丙丗丝不丈东:  val_10);
        }
        
        if(this.settingPanel == 0)
        {
            goto label_25;
        }
        
        System.Action val_12 = null;
        val_17 = val_12;
        val_12 = new System.Action(object:  this, method:  System.Void MapEventWindowUI::丗世丒丕七丆丒丙一());
        val_18 = System.Delegate.Combine(a:  this.settingPanel.OnUnequippedWeaponsCleared, b:  val_12);
        if(this.settingPanel == null)
        {
            goto label_27;
        }
        
        if(val_18 != null)
        {
            goto label_28;
        }
        
        goto label_31;
        label_27:
        if(val_18 == null)
        {
            goto label_31;
        }
        
        label_28:
        if(null != null)
        {
                val_18 = 0;
        }
        
        label_31:
        this.settingPanel.OnUnequippedWeaponsCleared = val_18;
        label_25:
        this.专丑丅专万丟世业专();
        if(this.UIButtonSearch == 0)
        {
                return;
        }
        
        val_16 = this.UIButtonSearch;
        val_16.enabled = false;
    }
    private void 专丑丅专万丟世业专()
    {
        System.Collections.Generic.List<EventDelegate> val_7;
        IntPtr val_8;
        丒万业丛丏东专世丟 val_9;
        object val_10;
        var val_11;
        val_7 = this;
        if(this.UIButtonToBattle == 0)
        {
                return;
        }
        
        this.UIButtonToBattle.onClick.Clear();
        if(this.丐且丘丑与万丞丑丅 == null)
        {
            goto label_8;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        if((val_2.HasValue.丙东专丂世丈丏丁丂() != 4) || ((530899384 & 1) == 0))
        {
            goto label_8;
        }
        
        val_8 = 1152921530907519744;
        val_9 = new EventDelegate.丒万业丛丏东专世丟();
        val_10 = val_7;
        goto label_9;
        label_8:
        val_11 = static_value_081DACA8;
        val_11 = static_value_081DACA8;
        EventDelegate.丒万业丛丏东专世丟 val_4 = null;
        val_8 = 1152921530907524864;
        val_9 = val_4;
        val_10 = static_value_081DACA8 + 184 + 16;
        label_9:
        val_4 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_10, 丛丌丙世专世东丕下:  val_8);
        System.Collections.Generic.List<EventDelegate> val_6 = null;
        val_7 = val_6;
        val_6 = new System.Collections.Generic.List<EventDelegate>();
        val_6.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  val_4));
        this.UIButtonToBattle.onClick = val_7;
    }
    private void 丄丞丝下丄丈丄不一()
    {
        UIButton val_20;
        if(this.丐且丘丑与万丞丑丅 == null)
        {
                return;
        }
        
        if(this.UIButtonToBattle != 0)
        {
                this.UIButtonToBattle.enabled = (~丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且()) & 1;
            val_20 = this.UIButtonSearch;
            if(val_20 != 0)
        {
                val_20 = this.UIButtonToBattle;
            if(this.UIButtonToBattle.enabled ^ val_20.enabled != false)
        {
                this.UIButtonSearch.gameObject.SetActive(value:  丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且());
            val_20 = 丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且();
            this.UIButtonToBattle.gameObject.SetActive(value:  (~val_20) & 1);
        }
        
        }
        
        }
        
        if(this.TouchToCloseLabel == 0)
        {
                return;
        }
        
        bool val_16 = 丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且();
        if(this.TouchToCloseLabel.activeSelf ^ val_16 != false)
        {
                return;
        }
        
        this.TouchToCloseLabel.SetActive(value:  val_16 ^ 1);
    }
    private void OnEnable()
    {
    
    }
    private void 且且上丝业丏丆丑业()
    {
        if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世() != null)
        {
                if((PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丅上丗丂丕丟丟与丝(丐且丘丑与万丞丑丅:  this.丐且丘丑与万丞丑丅)) != false)
        {
                this.上东与丛丞下丈专丈(丐且丘丑与万丞丑丅:  this.丐且丘丑与万丞丑丅, 丛一丆专世丝丄丒与:  this.三丟七一丈丂七丂丘);
            return;
        }
        
        }
        
        this.且丅丐七丄丄丁丙万();
    }
    private void 且丅丐七丄丄丁丙万()
    {
        if(this.上丒丅丁丌七丄丐丆 == null)
        {
                return;
        }
        
        if(this.上丒丅丁丌七丄丐丆.Type == 1130)
        {
                Rilisoft.丛且世丐丆上七业丁 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业();
            if(val_3 == null)
        {
                return;
        }
        
            this.不世万丑且丗丒一万(丐下丝丘丑丟丟丗丌:  val_3.丄三丐丟丗丄丟上丞().Item[(System.Convert.ToInt32(value:  this.上丒丅丁丌七丄丐丆.Id)) - 1]);
            return;
        }
        
        UnityEngine.Transform val_9 = this.transform;
    }
    private void Update()
    {
        this.丐东丛与与上丑丛不();
        this.丄丞丝下丄丈丄不一();
    }
    private void LateUpdate()
    {
        if(this.业丆丑业丕丅业丙东 == false)
        {
                return;
        }
        
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.rewardTable, y:  0);
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.modifiersGrid, y:  0);
        bool val_3 = UnityEngine.Object.op_Inequality(x:  this.specialRewardTable, y:  0);
        this.业丆丑业丕丅业丙东 = false;
    }
    public void OpenModificatorsInfo()
    {
        if(this.世丏与丑丌丗丘丈丏 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.世丏与丑丌丗丘丈丏.Dispose();
        }
        
        this.世丏与丑丌丗丘丈丏 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void MapEventWindowUI::HideModificatorsInfo()), 与且专丈不万东一万:  "Modificators Info");
    }
    public void HideModificatorsInfo()
    {
        if(this.世丏与丑丌丗丘丈丏 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.世丏与丑丌丗丘丈丏.Dispose();
        this.世丏与丑丌丗丘丈丏 = 0;
    }
    private void OnDisable()
    {
        this.HideModificatorsInfo();
    }
    private void 丁丈世丟丟世丑丏丕()
    {
        this.rateWindow.gameObject.SetActive(value:  true);
        this.rateWindow.丏丑丕丏丈丏丝丆丒(丐且丘丑与万丞丑丅:  this.丐且丘丑与万丞丑丅);
        if(this.丂丈下丌不丅业丅丅 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丂丈下丌不丅业丅丅.Dispose();
        }
        
        this.丂丈下丌不丅业丅丅 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void MapEventWindowUI::不丈七丏三且且且丏()), 与且专丈不万东一万:  "Rate event");
    }
    private void 不丈七丏三且且且丏()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rateWindow.gameObject, 丏业丟一东丂东丘丛:  false);
        if(this.丂丈下丌不丅业丅丅 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.丂丈下丌不丅业丅丅.Dispose();
            this.丂丈下丌不丅业丅丅 = 0;
        }
        
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_3 = this.丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
        this.七丝丏东东丘丆丒且(且下丕七丙丗丄不七:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = val_3.HasValue});
    }
    public void HandleRateButtonClick()
    {
        this.丁丈世丟丟世丑丏丕();
    }
    private void 不世万丑且丗丒一万(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
    {
        if(this.丈万丝丄业丅丟世万() == 0)
        {
                return;
        }
        
        this.丈万丝丄业丅丟世万().gameObject.SetActive(value:  true);
        this.丈万丝丄业丅丟世万().Show(丐下丝丘丑丟丟丗丌:  丐下丝丘丑丟丟丗丌, 丁丞丅上丝三丐丅丆:  true);
        this.丈万丝丄业丅丟世万().add_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MapEventWindowUI::丏专丄丏丆不丕三丒()));
    }
    private void 丏专丄丏丆不丕三丒()
    {
        if(this.专下丐丙业且丗丟万 == false)
        {
                return;
        }
        
        if(this.丈万丝丄业丅丟世万() == 0)
        {
                return;
        }
        
        this.丈万丝丄业丅丟世万().gameObject.SetActive(value:  false);
        this.丈万丝丄业丅丟世万().remove_OnCloseRequest(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MapEventWindowUI::丏专丄丏丆不丕三丒()));
    }
    public MapEventWindowUI()
    {
        this.七与七丟下丕万丁下 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.不东丁一且七业丗丟 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }
    private void 丗丘且丂丞一丌与丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.且且上丝业丏丆丑业();
    }
    private void 三丘丟世丏丁丏七丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.不丈七丏三且且且丏();
    }

}
