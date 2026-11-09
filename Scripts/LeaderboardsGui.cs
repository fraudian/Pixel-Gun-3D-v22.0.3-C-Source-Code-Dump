using UnityEngine;
public class LeaderboardsGui : MonoBehaviour, 丑且丆万丏丝丘丙丟
{
    // Fields
    private const string 业丄丛且丝三丗丏丅 = "NguiWindows/Leaderboards_Competition";
    private static LeaderboardsGui <丄且丂丙丒且七丈丆>k__BackingField;
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private RadioToggle tournamentToggleButton;
    private RadioToggle topClansToggleButton;
    private RadioToggle topPlayersToggleButton;
    private RadioToggle storeToggleButton;
    private UnityEngine.GameObject tournamentTabContainer;
    private Competition.CompetitionPanel competitionPanel;
    private UnityEngine.GameObject tournamentContainer;
    private UnityEngine.GameObject tournamentJoinInfo;
    private UnityEngine.GameObject[] tournamentJoinInfoLeagues;
    private UnityEngine.GameObject[] tournamentLeagueHeaders;
    private UnityEngine.GameObject[] tournamentLeagueJoinCups;
    private UnityEngine.GameObject tournamentRewardNotificationObject;
    private UnityEngine.GameObject tournamentInfoButtonObject;
    private UnityEngine.GameObject tournamentJoinInfoBattleButtonObj;
    private Rilisoft.TextGroup tournamentJoinInfoLabel;
    private UnityEngine.GameObject tournamentJoinInfoUpdatingObj;
    private System.Collections.Generic.List<UILabel> _leagueNamesLabels;
    private System.Collections.Generic.List<UILabel> _leagueNamesBackgroundLabels;
    private PGCompany.TimerUI _competitionTimerInContainerPlayOneMatch;
    private UILabel _registrationEndsMessageInContainerPlayOneMatch;
    private bool 丗一下丕丛一丙一专;
    private System.Action 三丁丕丈丅丏丅丕丌;
    private UnityEngine.GameObject topPlayersTabContainer;
    private GlobalCompetitionLeaderboardUi topPlayersUi;
    private UnityEngine.GameObject storeTabContainer;
    private StoreInfoInCompetition storeInfoInCompetition;
    private System.Collections.Generic.List<下下业丟丝七丘丏丕> 丐丝丄专丌丂丁不丙;
    private System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丟丕且东丂东丆丟丟;
    private static readonly int 丝三不丑上七丅且丆;
    private static LeaderboardsGui.一丐丛丏东上专丆丐 <丂丕与丂丏丟世丙专>k__BackingField;
    
    // Properties
    internal static LeaderboardsGui 丄丘七三上丕世丞业 { get; set; }
    internal static LeaderboardsGui.一丐丛丏东上专丆丐 丁且丘下丘丑丌丞丂 { get; set; }
    internal static bool 丘丈万丌丆世且专且 { get; }
    
    // Methods
    internal static LeaderboardsGui 与一丅丝不丈业与丙()
    {
        null = null;
        return (LeaderboardsGui)LeaderboardsGui.<丄且丂丙丒且七丈丆>k__BackingField;
    }
    private static void 丑一上丟丙不东与业(LeaderboardsGui 丙业与丙丗丝不丈东)
    {
        null = null;
        LeaderboardsGui.<丄且丂丙丒且七丈丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static LeaderboardsGui.一丐丛丏东上专丆丐 丑丌丞东业丂东丌丕()
    {
        null = null;
        return (一丐丛丏东上专丆丐)LeaderboardsGui.<丂丕与丂丏丟世丙专>k__BackingField;
    }
    private static void 丆一丑丑丑丆且丙丆(LeaderboardsGui.一丐丛丏东上专丆丐 丙业与丙丗丝不丈东)
    {
        null = null;
        LeaderboardsGui.<丂丕与丂丏丟世丙专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丑丙丗世丏丞万世丒()
    {
        if(LeaderboardsGui.与一丅丝不丈业与丙() == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_4 = LeaderboardsGui.与一丅丝不丈业与丙().gameObject;
        if(val_4 != null)
        {
                return val_4.activeInHierarchy;
        }
        
        return val_4.activeInHierarchy;
    }
    internal static void 丌万丗与七丄丕不丁(LeaderboardsGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业, System.Action 丛丝与丂世丌丌丝丂)
    {
        var val_12;
        if(LeaderboardsGui.与一丅丝不丈业与丙() == 0)
        {
                val_12 = null;
            val_12 = null;
            LeaderboardsGui.丑一上丟丙不东与业(丙业与丙丗丝不丈东:  丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕(丑与丞三且丛与丟业:  "NguiWindows/Leaderboards_Competition", 七万上丐一丈丏丏专:  gameObject, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<LeaderboardsGui>());
            LeaderboardsGui.丆一丑丑丑丆且丙丆(丙业与丙丗丝不丈东:  3);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  LeaderboardsGui.与一丅丝不丈业与丙().gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  LeaderboardsGui.与一丅丝不丈业与丙());
        LeaderboardsGui val_10 = LeaderboardsGui.与一丅丝不丈业与丙();
        val_10.三丁丕丈丅丏丅丕丌 = 丛丝与丂世丌丌丝丂;
        LeaderboardsGui.与一丅丝不丈业与丙().万七丄东丞丅丆三东(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业);
    }
    internal static void 丗丟万丂丘丈专丄丂()
    {
        var val_6 = null;
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == false)
        {
                return;
        }
        
        LeaderboardsGui val_2 = LeaderboardsGui.与一丅丝不丈业与丙();
        if(val_2.三丁丕丈丅丏丅丕丌 != null)
        {
                LeaderboardsGui val_3 = LeaderboardsGui.与一丅丝不丈业与丙();
            val_3.三丁丕丈丅丏丅丕丌.Invoke();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  LeaderboardsGui.与一丅丝不丈业与丙().gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 万七丄东丞丅丆三东(LeaderboardsGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业)
    {
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.丗一下丕丛一丙一专 = false;
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丅七一上丕丁丗与丞:  false);
    }
    private void 丛丅专丁上一丞丄丈(LeaderboardsGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业, bool 丅七一上丕丁丗与丞 = False)
    {
        UnityEngine.Object val_9 = this;
        if(LeaderboardsGui.丑丌丞东业丂东丌丕() == 丐丅丒专丛丏上与业)
        {
                if(this.丗一下丕丛一丙一专 == true)
        {
                return;
        }
        
        }
        
        LeaderboardsGui.丆一丑丑丑丆且丙丆(丙业与丙丗丝不丈东:  丐丅丒专丛丏上与业);
        this.丗一下丕丛一丙一专 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topPlayersTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.storeTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfo, 丏业丟一东丂东丘丛:  false);
        if(LeaderboardsGui.丑丌丞东业丂东丌丕() == 3)
        {
                this.丘丙专与万丁东七丈(丅七一上丕丁丗与丞:  false);
        }
        else
        {
                if(LeaderboardsGui.丑丌丞东业丂东丌丕() == 2)
        {
                this.丅丛与丒专丅丆丅世();
        }
        else
        {
                if(LeaderboardsGui.丑丌丞东业丂东丌丕() == 0)
        {
                this.丁丄丙丘世丏丆丗丆();
        }
        
        }
        
        }
        
        val_9 = Rilisoft.Singleton<ClansVisitController>.Instance;
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = Rilisoft.Singleton<ClansVisitController>.Instance;
        val_7.丞丌丕丛丒丟丐丏下 = LeaderboardsGui.丑丌丞东业丂东丌丕();
    }
    private void 丘丙专与万丁东七丈(bool 丅七一上丕丁丗与丞 = False)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  82);
        this.tournamentToggleButton.state = true;
        this.东下丙丝下专丏丟丐();
        if(this.丟世丄与三丛丑与丈() == true)
        {
                return;
        }
        
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                Rilisoft.Singleton<TournamentController>.Instance.丞丕丙丁丞丏丞七一();
        }
        
        this.丌丐东丞丟丂丕一东();
        if(PGCompany.Banners.NewCompetitionBanner.丁七下丌丏丄丟上三() == false)
        {
                return;
        }
        
        this = BannerWindowController.与丅与丒丅专丙丐丗();
        this.ForceShowBanner(丌丅丕一丛丛丄一万:  101, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void 不七东丐业丕世丟丂(System.Action 七丐丅专且专七三丆)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        System.Func<System.Boolean> val_10;
        val_5 = 1152921505080860672;
        val_6 = null;
        val_6 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_7 = null;
            val_7 = null;
            if(activeInHierarchy != false)
        {
                val_8 = null;
            val_8 = null;
            val_10 = LeaderboardsGui.<>c.<>9__47_0;
            if(val_10 == null)
        {
                System.Func<System.Boolean> val_3 = null;
            val_10 = val_3;
            val_3 = new System.Func<System.Boolean>(object:  LeaderboardsGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LeaderboardsGui.<>c::且业七世丄且专丆丟());
            LeaderboardsGui.<>c.<>9__47_0 = val_10;
        }
        
            UnityEngine.Coroutine val_4 = CoroutineRunner.丆万七与丏丁丞丂专(且丐丈丕三丟丕丙丒:  val_3, 一丏丘业丅丈东东丄:  七丐丅专且专七三丆);
            return;
        }
        
        }
        
        if(七丐丅专且专七三丆 == null)
        {
                return;
        }
        
        七丐丅专且专七三丆.Invoke();
    }
    private void 丁丄丙丘世丏丆丗丆()
    {
        this.topPlayersToggleButton.state = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.topPlayersToggleButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topPlayersTabContainer, 丏业丟一东丂东丘丛:  true);
        Rilisoft.Singleton<LeaderboardsController>.Instance.丆丅丒丐丁丞丐丁下();
        this.topPlayersUi.Open();
    }
    private void 丅丛与丒专丅丆丅世()
    {
        this.storeToggleButton.state = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.storeToggleButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.storeTabContainer, 丏业丟一东丂东丘丛:  true);
        this.storeInfoInCompetition.UpdateView();
    }
    private void 且一丙丕万万专丒丌()
    {
        var val_4 = null;
        if(LeaderboardsGui.丑丙丗世丏丞万世丒() == false)
        {
                return;
        }
        
        if(LeaderboardsGui.丑丌丞东业丂东丌丕() != 0)
        {
                return;
        }
        
        if(this.丐丝丄专丌丂丁不丙 == null)
        {
                return;
        }
        
        int val_3 = this.丐丝丄专丌丂丁不丙.Count;
    }
    private void 东下丙丝下专丏丟丐()
    {
        RatingLeague val_2 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.tournamentLeagueHeaders, 丏业丟一东丂东丘丛:  false);
        if(((val_2 & 2147483648) == 0) && (val_2 < this.tournamentLeagueHeaders.Length))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentLeagueHeaders[(long)val_2], 丏业丟一东丂东丘丛:  true);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._leagueNamesLabels, 丕丗丘丑丛与丑业丒:  LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()));
        this.业三丏丛丛三丈上丌();
    }
    private void 世丁与丕丄丕丂丆丟()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._leagueNamesLabels, 丕丗丘丑丛与丑业丒:  LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()));
        this.业三丏丛丛三丈上丌();
    }
    private void 业三丏丛丛三丈上丌()
    {
        LeaderboardsGui.丞丘世丐丏丟业丕丒 val_1 = new LeaderboardsGui.丞丘世丐丏丟业丕丒();
        UnityEngine.Color val_4 = LeaguesGUIController.与丅七丒丗丞丙且丑(丙丑七万丆万丆且丌:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        .丑丞丈丗丄丙丟万丄 = val_4;
        mem[1152921538234810452] = val_4.g;
        mem[1152921538234810456] = val_4.b;
        mem[1152921538234810460] = val_4.a;
        this._leagueNamesLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void LeaderboardsGui.丞丘世丐丏丟业丕丒::丂丞丘丆不下丗丝下(UILabel 三丟东丕丄丄下下丑)));
        UnityEngine.Color.RGBToHSV(rgbColor:  new UnityEngine.Color() {r = (LeaderboardsGui.丞丘世丐丏丟业丕丒)[1152921538234810432].丑丞丈丗丄丙丟万丄, g = val_4.g, b = val_4.b, a = val_4.a}, H: out  float val_6 = -3.871115E+12f, S: out  float val_7 = -3.871114E+12f, V: out  float val_8 = -3.871102E+12f);
        float val_11 = 0f;
        val_11 = val_11 * 0.5f;
        UnityEngine.Color val_9 = UnityEngine.Color.HSVToRGB(H:  0f, S:  0f, V:  val_11);
        .一与丘丅万丟丅业丌 = val_9;
        mem[1152921538234810468] = val_9.g;
        mem[1152921538234810472] = val_9.b;
        mem[1152921538234810476] = 1152921538234744192;
        this._leagueNamesBackgroundLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void LeaderboardsGui.丞丘世丐丏丟业丕丒::万丞上丘丈丂与丅万(UILabel 三丟东丕丄丄下下丑)));
    }
    private void 丄世东世万丑丈丂万()
    {
        var val_27;
        var val_28;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentTabContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfo, 丏业丟一东丂东丘丛:  true);
        this.三丆丛丐丏丐丂三丘();
        if(TournamentController.七东丕丌且丟丙丈下() == false)
        {
            goto label_12;
        }
        
        if(TournamentController.七东丕丌且丟丙丈下() != false)
        {
                if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) != false)
        {
                if(TournamentController.丌万丘丙万世丗丈丏() == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfoBattleButtonObj, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tournamentJoinInfoLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfoUpdatingObj, 丏业丟一东丂东丘丛:  false);
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) == false)
        {
            goto label_15;
        }
        
        string val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11481");
        goto label_18;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfoBattleButtonObj, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tournamentJoinInfoLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfoUpdatingObj, 丏业丟一东丂东丘丛:  true);
        goto label_21;
        label_15:
        label_18:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(丟丅丘丂丆丘三丟丄:  this.tournamentJoinInfoLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.tournament")));
        label_21:
        this.丁丅专万不与丅丄丁();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.tournamentLeagueJoinCups, 丏业丟一东丂东丘丛:  false);
        System.Action val_10 = new System.Action(object:  this, method:  System.Void LeaderboardsGui::丆丞上丈丞万丘丆丟());
        val_10.不七东丐业丕世丟丂(七丐丅专且专七三丆:  val_10);
        this.世丁与丕丄丕丂丆丟();
        var val_28 = 0;
        label_41:
        if(val_28 >= val_13.Length)
        {
            goto label_35;
        }
        
        UnityEngine.Material val_14 = this.tournamentJoinInfoLeagues[(long)RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()].GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true)[0].sharedMaterial;
        val_27 = null;
        val_27 = null;
        val_28 = val_28 + 1;
        if((val_14.HasProperty(nameID:  LeaderboardsGui.丝三不丑上七丅且丆)) == false)
        {
            goto label_41;
        }
        
        val_28 = null;
        val_28 = null;
        val_14.SetFloat(nameID:  LeaderboardsGui.丝三不丑上七丅且丆, value:  1f);
        label_35:
        Rilisoft.丝丑丂丛万丐丈丘且 val_17 = Rilisoft.Singleton<TournamentController>.Instance.丞丁下丛丒一丈丌丑();
        System.TimeSpan val_18 = System.TimeSpan.FromSeconds(value:  1.15292150460685E+18);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._registrationEndsMessageInContainerPlayOneMatch, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12516"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_18._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
        Rilisoft.丝丑丂丛万丐丈丘且 val_23 = Rilisoft.Singleton<TournamentController>.Instance.丞丁下丛丒一丈丌丑();
        Rilisoft.丝丑丂丛万丐丈丘且 val_24 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        专丙东上不丟丘东丝.丌专世丟丂东下东丕 val_29 = val_23.上万三丆专丏丒丗业;
        val_29 = Rilisoft.丝丑丂丛万丐丈丘且.上丆丟万丒丈且丈丝(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_23.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_23.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_29}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_24.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_24.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_24.上万三丆专丏丒丗业});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._registrationEndsMessageInContainerPlayOneMatch, 丏业丟一东丂东丘丛:  val_29);
    }
    private void 三丆丛丐丏丐丂三丘()
    {
        var val_5 = null;
        this._competitionTimerInContainerPlayOneMatch.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  System.Math.Max(val1:  Rilisoft.Singleton<TournamentController>.Instance.丂与丐下一丟丆丌与(), val2:  0), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  new System.Func<System.Int32, System.String>(object:  LeaderboardsGui.<>c.<>9, method:  System.String LeaderboardsGui.<>c::丆丄上一七东且丆丝(int 三丐东三丒丛丗丅三)), 与丌一丑且丗三丙一:  0);
    }
    private void 丁丅专万不与丅丄丁()
    {
        UnityEngine.GameObject[] val_3;
        RatingLeague val_2 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        val_3 = this.tournamentJoinInfoLeagues;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
        if((val_2 & 2147483648) != 0)
        {
                return;
        }
        
        val_3 = this.tournamentJoinInfoLeagues;
        if(val_2 >= this.tournamentJoinInfoLeagues.Length)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfoLeagues[(long)val_2], 丏业丟一东丂东丘丛:  true);
    }
    private void 丅丐丞丕丂丆丌七丟()
    {
        var val_10;
        if(Progress.七上上丟丗丏一不与.丑丈丌三丘丐上丕丐() == true)
        {
            goto label_3;
        }
        
        val_10 = TournamentLeaderboard.丟与业下丟丗丗万丕(下丕世不丈专万丗万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "key_tournament_lastValidLeaderboard_v3"));
        if(val_10 != null)
        {
            goto label_6;
        }
        
        label_3:
        val_10 = Rilisoft.Singleton<TournamentController>.Instance.丕丑与丏丌丝下上丛();
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentTabContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfo, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_6 = val_5.players.GetEnumerator();
        goto label_12;
        label_14:
        string val_7 = 0.丐丏七丌丕丗业且上();
        mem2[0] = 1;
        label_12:
        if(((-730593448) & 1) != 0)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.competitionPanel.下与丞三丅丛丄七丕(丐七且丕三世下丄丕:  Competition.丄世丌丕丒丏上世丞.丑七不且上丗丁一世().丛丟丑丅上丑且丂东(丆丝丑丝上丂丛不下:  val_5.players));
    }
    private void 丌丐东丞丟丂丕一东()
    {
        TournamentController.丁丟丂七与丏丛丐丄(丙业与丙丗丝不丈东:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  Rilisoft.Singleton<TournamentController>.Instance.下丐丕东七丞丅丙丝());
        if(((((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 0) || ((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 3)) || (TournamentController.七东丕丌且丟丙丈下() == false)) || ((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) == false))
        {
            goto label_14;
        }
        
        if((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) != 2)
        {
            goto label_16;
        }
        
        this.世丄三丁不世万与丅();
        return;
        label_14:
        this.丄世东世万丑丈丂万();
        return;
        label_16:
        this.丅丐丞丕丂丆丌七丟();
    }
    private void 世丄三丁不世万与丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentTabContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentJoinInfo, 丏业丟一东丂东丘丛:  false);
        this.competitionPanel.与丌丑一丅世丈丄丏(丆丈丒与丄不丙丌与:  TournamentController.丝丘丙丙世丁丈丟世());
    }
    private void 丂不丐七世丟专丅世()
    {
        if(LeaderboardsGui.丑丌丞东业丂东丌丕() != 3)
        {
                return;
        }
        
        this.丌丐东丞丟丂丕一东();
        if((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) != 0)
        {
                return;
        }
        
        if(this.丟世丄与三丛丑与丈() != false)
        {
                return;
        }
        
        this.丌丐东丞丟丂丕一东();
    }
    private bool 丟世丄与三丛丑与丈()
    {
        TournamentReward val_10;
        object val_11;
        var val_12;
        var val_13;
        val_11 = this;
        if(Progress.七上上丟丗丏一不与.丑丈丌三丘丐上丕丐() != false)
        {
                val_10 = Rilisoft.Singleton<TournamentController>.Instance.丄万丐丑丌三丆丝丑();
            if(val_10 == null)
        {
                return (bool)val_12;
        }
        
            this.gameObject.SetActive(value:  false);
            val_13 = null;
            val_13 = null;
            val_11 = transform;
            SeasonEndView.丌万丗与七丄丕不丁(丕专上丁丅丅丏万丌:  val_11, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::丈丟丞丌丄世且且丁()), 丗七丟丈三不丕一三:  val_10);
            val_10 = Rilisoft.Singleton<TournamentController>.Instance;
            if(val_10 != 0)
        {
                val_10 = Rilisoft.Singleton<TournamentController>.Instance;
            val_10.丁丄丐东上丄丘丙丞();
        }
        
            val_12 = 1;
            return (bool)val_12;
        }
        
        val_12 = 0;
        return (bool)val_12;
    }
    public void U_TournamenthToggleButtonClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  3, 丅七一上丕丁丗与丞:  false);
    }
    public void U_TopPlayersToggleButtonClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  0, 丅七一上丕丁丗与丞:  false);
    }
    public void U_StoreToggleButtonClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.丛丅专丁上一丞丄丈(丐丅丒专丛丏上与业:  2, 丅七一上丕丁丗与丞:  false);
    }
    public void U_TournamentRulesButtonClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  101, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public void U_TournamentRulesCloseClick()
    {
        bool val_1 = this.丝东丐丝东三丈世丝();
    }
    public void U_ToBattleClick()
    {
        PGCompany.丌不丞丐世丞三丘丌 val_11;
        if((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 3)
        {
                val_11 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_11.ForceShowBanner(丌丅丕一丛丛丄一万:  108, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
        }
        
        PGCompany.丌不丞丐世丞三丘丌 val_4 = null;
        val_11 = val_4;
        val_4 = new PGCompany.丌不丞丐世丞三丘丌();
        if(val_11 != null)
        {
                .Type = 11;
        }
        else
        {
                mem[16] = 11;
        }
        
        .GameModeGroup = 26;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_4)) == null)
        {
                return;
        }
        
        val_11 = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public void U_BackRequest()
    {
        bool val_1 = this.丝东丐丝东三丈世丝();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  LeaderboardsGui.与一丅丝不丈业与丙());
    }
    private bool 丝东丐丝东三丈世丝()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        LeaderboardsGui.丗丟万丂丘丈专丄丂();
        return true;
    }
    private void Update()
    {
        bool val_4;
        if(LeaderboardsGui.丑丌丞东业丂东丌丕() == 3)
        {
                val_4 = 0;
        }
        else
        {
                val_4 = Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentRewardNotificationObject, 丏业丟一东丂东丘丛:  val_4);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tournamentInfoButtonObject, 丏业丟一东丂东丘丛:  true);
    }
    private void OnEnable()
    {
        int val_9;
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void LeaderboardsGui::U_BackRequest()), 与且专丈不万东一万:  "Leaderboards");
        }
        
        val_9 = 1152921505274736640;
        TournamentController.业业三与丌下且与不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::丂不丐七世丟专丅世()));
        LeaderboardsController.万丅丙七丛丘丙丝与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::且一丙丕万万专丒丌()));
        if((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 2)
        {
                val_9 = TournamentController.丝丘丙丙世丁丈丟世();
            this.competitionPanel.与丌丑一丅世丈丄丏(丆丈丒与丄不丙丌与:  val_9);
        }
        
        this.三丆丛丐丏丐丂三丘();
    }
    private void OnDisable()
    {
        if(this.且丂七丑丈丞丈三丑 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.且丂七丑丈丞丈三丑.Dispose();
            this.且丂七丑丈丞丈三丑 = 0;
        }
        
        TournamentController.丝东丁丁丌丄丅且丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::丂不丐七世丟专丅世()));
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::且一丙丕万万专丒丌()));
    }
    private void OnDestroy()
    {
        TournamentController.丝东丁丁丌丄丅且丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::丂不丐七世丟专丅世()));
        LeaderboardsController.一丒一不丗丝不丅下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardsGui::且一丙丕万万专丒丌()));
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public LeaderboardsGui()
    {
    
    }
    private static LeaderboardsGui()
    {
        LeaderboardsGui.丝三不丑上七丅且丆 = UnityEngine.Shader.PropertyToID(name:  "_Disolve");
    }
    private void 丆丞上丈丞万丘丆丟()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.tournamentLeagueJoinCups, 丏业丟一东丂东丘丛:  true);
    }
    private void 丈丟丞丌丄世且且丁()
    {
        this.gameObject.SetActive(value:  true);
        this.丘丙专与万丁东七丈(丅七一上丕丁丗与丞:  false);
    }

}
