using UnityEngine;
public class SeasonEndView : MonoBehaviour
{
    // Fields
    private static SeasonEndView 丄丘七三上丕世丞业;
    private static UnityEngine.Transform 丈东丘丏与丌东东下;
    private const string 业丄丛且丝三丗丏丅 = "NguiWindows/LeagueStep";
    private System.Action 三丁丕丈丅丏丅丕丌;
    private System.Nullable<bool> 三丝上丁丆丒丌与且;
    internal static bool 世丑丗上丘丟丐丂丕;
    internal static bool 丄与丙丛丙丕丑专丄;
    private static int <丗丗丛三丆丙三丕丟>k__BackingField;
    public SeasonEndView.丗丞下丌丝丒与与不 ViewState;
    public UILabel[] SeasonTitle;
    public UILabel[] LeagueTitle;
    public UILabel[] ResultPlace;
    public UILabel[] ResultScore;
    public UILabel[] SeasonSubtitle;
    public UILabel[] LeagueSubtitle;
    public UILabel[] ScoreSubtitle;
    public UILabel[] RewardTitle;
    public UILabel[] UnlockedItemsTitle;
    private UnityEngine.GameObject[] _trophyItemsObjects;
    private UIBasicSprite[] _trophyItemsTextures;
    private UILabel[] _trophyItemsNames;
    private UnityEngine.AudioClip _anyLeagueUpSound;
    private UnityEngine.AudioClip _anyLeagueDownSound;
    private UnityEngine.AudioClip[] _leagueStaySounds;
    internal PGCompany.InventoryItemView[] RewardObjects;
    private ShieldView _oldShield;
    private ShieldView _newShield;
    private UnityEngine.Transform _shieldsParent;
    private UnityEngine.GameObject[] _shieldsOne;
    private UnityEngine.GameObject[] _shieldsTwo;
    private UnityEngine.GameObject rewardObj;
    private UITable _rewardsTable;
    private UITable _itemsTable;
    public UnityEngine.Animator InterfaceAnimator;
    private UnityEngine.Transform targetCoins;
    private UnityEngine.Transform targetGems;
    private FrameResizer[] _frameResizers;
    private UILabel _resetTrophiesLeabel;
    public Rilisoft.ButtonHandler ButtonBackground;
    private SeasonEndView.且丒七专丐丞丗丟丕 丏丝丏丛丌丝丑丈专;
    private TournamentReward 丁丏丈丑下丞丛丘丈;
    private static int 上专业丘丝丕丆丘七;
    private static Rilisoft.OfferItem 且丆七下且丐丁与丌;
    private static Rilisoft.OfferItem 丘丙丌丂丕丞丏丁丒;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private int 丆丞丘与一丄丘丙三;
    private int 且与丒三丆下专世丆;
    private UnityEngine.Camera cupsCamera;
    private UnityEngine.GameObject tapToContinueLableObject;
    private static UnityEngine.Coroutine 且丙七丕丛专业丁丕;
    
    // Properties
    internal static int 丂丂万与一丑不且丟 { get; set; }
    public static SeasonEndView 丆丕丝丒不丙且丐丗 { get; }
    public UIBasicSprite[] 丄丂丙万丄丛丛丞丄 { get; }
    public UnityEngine.Transform 东丒七万东丏丘七万 { get; }
    public UnityEngine.Transform 丞丗三丘丛下丅丁丆 { get; }
    public UnityEngine.AudioClip[] 不丕上丆丑不丐丅与 { get; }
    public UnityEngine.AudioClip 下丕东丏丙丁丄丏东 { get; }
    public UnityEngine.AudioClip 丏丙丆丞丌丝万业上 { get; }
    
    // Methods
    internal static int 丙丏下且丛丘丅丁丕()
    {
        null = null;
        return (int)SeasonEndView.<丗丗丛三丆丙三丕丟>k__BackingField;
    }
    private static void 丄丛且丛丏丗丒丘下(int 丙业与丙丗丝不丈东)
    {
        null = null;
        SeasonEndView.<丗丗丛三丆丙三丕丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public static SeasonEndView get_Instance()
    {
        null = null;
        return (SeasonEndView)SeasonEndView.业丄丛且丝三丗丏丅;
    }
    public UIBasicSprite[] get_TrophyItemsTextures()
    {
        var val_3;
        UIBasicSprite[] val_1 = new UIBasicSprite[0];
        val_3 = 0;
        goto label_2;
        label_14:
        UIBasicSprite val_2 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._trophyItemsTextures[0]);
        if(val_1 == null)
        {
            goto label_7;
        }
        
        if(val_2 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_2 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        val_3 = 1;
        val_1[0] = val_2;
        label_2:
        if(val_3 < this._trophyItemsTextures.Length)
        {
            goto label_14;
        }
        
        this._trophyItemsTextures = val_1;
        return val_1;
    }
    public UnityEngine.Transform get_TargetCoins()
    {
        return (UnityEngine.Transform)this.targetCoins;
    }
    public UnityEngine.Transform get_TargetGems()
    {
        return (UnityEngine.Transform)this.targetGems;
    }
    public UnityEngine.AudioClip[] get_LeagueStayClips()
    {
        return (UnityEngine.AudioClip[])this._leagueStaySounds;
    }
    public UnityEngine.AudioClip get_LeagueUpClip()
    {
        return (UnityEngine.AudioClip)this._anyLeagueUpSound;
    }
    public UnityEngine.AudioClip get_LeagueDownClip()
    {
        return (UnityEngine.AudioClip)this._anyLeagueDownSound;
    }
    private void Awake()
    {
        this.ButtonBackground.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void SeasonEndView::HandleContinueClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SeasonEndView::丞三丂丅丛丗专丟一()), 与且专丈不万东一万:  "Back From Season End View");
        Rilisoft.ItemViewer.add_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SeasonEndView::丟世丅丄专一丘丒丒()));
        Progress.七上上丟丗丏一不与.丂丐上丝丞丙万丟且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SeasonEndView::丘丘下丈丘丂下且三()));
    }
    private void 丘丘下丈丘丂下且三()
    {
        this.Close();
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        Progress.七上上丟丗丏一不与.且丘丝丈业且丗丑丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SeasonEndView::丘丘下丈丘丂下且三()));
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SeasonEndView::丟世丅丄专一丘丒丒()));
    }
    internal static void 丌万丗与七丄丕不丁(UnityEngine.Transform 丕专上丁丅丅丏万丌, System.Action 丛丝与丂世丌丌丝丂, TournamentReward 丗七丟丈三不丕一三)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(SeasonEndView.且丙七丕丛专业丁丕 != null)
        {
                val_6 = null;
            val_6 = null;
            CoroutineRunner.Instance.StopCoroutine(routine:  SeasonEndView.且丙七丕丛专业丁丕);
        }
        
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  SeasonEndView.丁与且丁丟万丑万丌(丕专上丁丅丅丏万丌:  丕专上丁丅丅丏万丌, 丛丝与丂世丌丌丝丂:  丛丝与丂世丌丌丝丂, 丗七丟丈三不丕一三:  丗七丟丈三不丕一三));
    }
    private static System.Collections.IEnumerator 丁与且丁丟万丑万丌(UnityEngine.Transform 丕专上丁丅丅丏万丌, System.Action 丛丝与丂世丌丌丝丂, TournamentReward 丗七丟丈三不丕一三)
    {
        SeasonEndView.丗上不东丌与丕丙丟 val_1 = new SeasonEndView.丗上不东丌与丕丙丟();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丕专上丁丅丅丏万丌 = 丕专上丁丅丅丏万丌;
            .丛丝与丂世丌丌丝丂 = 丛丝与丂世丌丌丝丂;
        }
        else
        {
                mem[32] = 丕专上丁丅丅丏万丌;
            mem[40] = 丛丝与丂世丌丌丝丂;
        }
        
        .丗七丟丈三不丕一三 = 丗七丟丈三不丕一三;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丏上丘与下丏世丗丗(TournamentReward 丏丕丕丕丛丘世东丟)
    {
        this.ViewState = 0;
        this.丁丏丈丑下丞丛丘丈 = 丏丕丕丕丛丘世东丟;
    }
    private void 丙丁丏丛且万下丏丂()
    {
        var val_8;
        var val_9;
        System.Action<FrameResizer> val_11;
        val_8 = null;
        val_8 = null;
        SeasonEndView.世丑丗上丘丟丐丂丕 = true;
        this.ViewState = true;
        this.丒一丝与丏丝万丘且();
        this.丝丒东丈七专下一一();
        this.七丘丈丞世业东上七();
        this.丘丗丗东丙丐丏丕丘(丗七丟丈三不丕一三:  this.丁丏丈丑下丞丛丘丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._resetTrophiesLeabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11695"), arg0:  this.丁丏丈丑下丞丛丘丈.newScores));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.ResultPlace, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11686"), arg0:  this.丁丏丈丑下丞丛丘丈.resultPlace));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.ResultScore, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12373"), arg0:  this.丁丏丈丑下丞丛丘丈.resultScores));
        this.丅丞丛专丐三东世不(丈万丆丌东丘三丑不:  this._oldShield, 丘世丅丕丑专丞三丌:  this.丆丞丘与一丄丘丙三, 且丒丛丕丞丌丏东丑:  this._shieldsOne);
        this.丅丞丛专丐三东世不(丈万丆丌东丘三丑不:  this._newShield, 丘世丅丕丑专丞三丌:  this.丁丏丈丑下丞丛丘丈.newLeague, 且丒丛丕丞丌丏东丑:  this._shieldsTwo);
        val_9 = null;
        val_9 = null;
        val_11 = SeasonEndView.<>c.<>9__76_0;
        if(val_11 == null)
        {
                System.Action<FrameResizer> val_7 = null;
            val_11 = val_7;
            val_7 = new System.Action<FrameResizer>(object:  SeasonEndView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SeasonEndView.<>c::丄七丙丟丆七上丒丒(FrameResizer 三丟东丕丄丄下下丑));
            SeasonEndView.<>c.<>9__76_0 = val_11;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<FrameResizer>(丌丛丏业世丄丞三丌:  this._frameResizers, 七丐丅专且专七三丆:  val_7);
        this.InterfaceAnimator.enabled = false;
        this.InterfaceAnimator.enabled = true;
    }
    private void 业丑东上与东丘丈且()
    {
        var val_6;
        var val_7;
        System.Action<FrameResizer> val_9;
        TournamentReward val_10;
        int val_11;
        UnityEngine.Animator val_13;
        string val_14;
        val_6 = null;
        val_6 = null;
        SeasonEndView.世丑丗上丘丟丐丂丕 = true;
        SeasonEndView.丄与丙丛丙丕丑专丄 = false;
        this.ViewState = 2;
        this.一世上丝业丙万丆下(丗七丟丈三不丕一三:  null);
        this.丒一丝与丏丝万丘且();
        this.丝丒东丈七专下一一();
        this.七丘丈丞世业东上七();
        val_7 = null;
        val_7 = null;
        val_9 = SeasonEndView.<>c.<>9__77_0;
        if(val_9 == null)
        {
                System.Action<FrameResizer> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Action<FrameResizer>(object:  SeasonEndView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SeasonEndView.<>c::丞上丆丐丅丗七丐丆(FrameResizer 三丟东丕丄丄下下丑));
            SeasonEndView.<>c.<>9__77_0 = val_9;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<FrameResizer>(丌丛丏业世丄丞三丌:  this._frameResizers, 七丐丅专且专七三丆:  val_1);
        val_10 = this.丁丏丈丑下丞丛丘丈;
        if(val_10 == null)
        {
            goto label_11;
        }
        
        val_11 = this.丆丞丘与一丄丘丙三;
        var val_2 = (this.丆丞丘与一丄丘丙三 == this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0;
        goto label_12;
        label_11:
        val_10 = this.丁丏丈丑下丞丛丘丈;
        val_11 = this.丆丞丘与一丄丘丙三;
        if(val_10 == null)
        {
            goto label_13;
        }
        
        label_12:
        label_24:
        if(val_11 > this.丁丏丈丑下丞丛丘丈.newLeague)
        {
                val_13 = this.InterfaceAnimator;
            val_14 = "Down";
        }
        else
        {
                if(((this.丆丞丘与一丄丘丙三 == this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0) != 0)
        {
                this.InterfaceAnimator.SetTrigger(name:  "Stay");
            SeasonEndView.丄丛且丛丏丗丒丘下(丙业与丙丗丝不丈东:  this.丆丞丘与一丄丘丙三);
            return;
        }
        
            if(((val_11 < this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0) == 0)
        {
                return;
        }
        
            val_13 = this.InterfaceAnimator;
            val_14 = "Up";
        }
        
        val_13.SetTrigger(name:  val_14);
        return;
        label_13:
        var val_5 = (val_11 < this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0;
        if(this.丁丏丈丑下丞丛丘丈 == null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_23:
    }
    private void 一世上丝业丙万丆下(TournamentReward 丗七丟丈三不丕一三)
    {
        TournamentReward val_8;
        var val_9;
        val_8 = this.丁丏丈丑下丞丛丘丈;
        if(this.丆丞丘与一丄丘丙三 >= this.丁丏丈丑下丞丛丘丈.newLeague)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_8 = this.七上上下丆丞不丙七(丙丑七万丆万丆且丌:  this.丁丏丈丑下丞丛丘丈.newLeague, 丟丆丗丞丂丈丛且业:  val_1);
        val_9 = 0;
        goto label_4;
        label_26:
        UnityEngine.GameObject val_8 = this._trophyItemsObjects[0];
        if(val_9 < val_8.Count)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._trophyItemsNames[0], 丏业丟一东丂东丘丛:  true);
            UIBasicSprite val_10 = this.TrophyItemsTextures[0];
            UnityEngine.Texture val_5 = val_8.Item[0];
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._trophyItemsNames[0], 丕丗丘丑丛与丑业丒:  val_1.Item[0]);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._trophyItemsNames[0], 丏业丟一东丂东丘丛:  false);
        }
        
        val_9 = 1;
        label_4:
        UIBasicSprite[] val_7 = this.TrophyItemsTextures;
        if(val_9 < val_7.Length)
        {
            goto label_26;
        }
    
    }
    private void 丒一丝与丏丝万丘且()
    {
        UILabel[] val_3;
        string val_4;
        UILabel[] val_5;
        string val_6;
        int val_7;
        TournamentReward val_8;
        string val_9;
        val_3 = this;
        if(this.ViewState == 2)
        {
            goto label_1;
        }
        
        if(this.ViewState == 1)
        {
            goto label_2;
        }
        
        if(this.ViewState != 0)
        {
                return;
        }
        
        val_4 = "";
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SeasonTitle, 丕丗丘丑丛与丑业丒:  "");
        val_5 = this.LeagueTitle;
        val_6 = "";
        goto label_20;
        label_1:
        val_4 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SeasonTitle, 丕丗丘丑丛与丑业丒:  "");
        val_7 = this.丆丞丘与一丄丘丙三;
        val_8 = this.丁丏丈丑下丞丛丘丈;
        if(this.丁丏丈丑下丞丛丘丈 != null)
        {
            goto label_9;
        }
        
        val_8 = this.丁丏丈丑下丞丛丘丈;
        if(val_8 == null)
        {
            goto label_10;
        }
        
        val_7 = this.丆丞丘与一丄丘丙三;
        label_9:
        if(val_7 >= this.丁丏丈丑下丞丛丘丈.newLeague)
        {
            goto label_11;
        }
        
        val_3 = this.LeagueTitle;
        val_9 = "Key_1984";
        goto label_14;
        label_2:
        val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11685");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SeasonTitle, 丕丗丘丑丛与丑业丒:  val_4);
        val_5 = this.LeagueTitle;
        val_6 = "";
        goto label_20;
        label_11:
        val_3 = this.SeasonTitle;
        val_9 = "Key_11685";
        label_14:
        val_5 = val_3;
        val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9);
        label_20:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_5, 丕丗丘丑丛与丑业丒:  val_6);
        return;
        label_10:
    }
    private void 丝丒东丈七专下一一()
    {
        UILabel[] val_13;
        string val_14;
        UILabel[] val_15;
        string val_16;
        TournamentReward val_17;
        int val_18;
        string val_21;
        val_13 = this;
        if(this.ViewState == 2)
        {
            goto label_1;
        }
        
        if(this.ViewState == 1)
        {
            goto label_2;
        }
        
        if(this.ViewState != 0)
        {
                return;
        }
        
        val_14 = "";
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SeasonSubtitle, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.LeagueSubtitle, 丕丗丘丑丛与丑业丒:  "");
        val_15 = this.ScoreSubtitle;
        val_16 = "";
        goto label_34;
        label_1:
        val_14 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SeasonSubtitle, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.ScoreSubtitle, 丕丗丘丑丛与丑业丒:  "");
        val_17 = this.丁丏丈丑下丞丛丘丈;
        if(val_17 == null)
        {
            goto label_9;
        }
        
        val_18 = this.丆丞丘与一丄丘丙三;
        var val_1 = (this.丆丞丘与一丄丘丙三 == this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0;
        goto label_10;
        label_2:
        val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5264");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.SeasonSubtitle, 丕丗丘丑丛与丑业丒:  val_14);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.LeagueSubtitle, 丕丗丘丑丛与丑业丒:  "");
        val_15 = this.ScoreSubtitle;
        val_16 = "";
        goto label_34;
        label_9:
        val_17 = this.丁丏丈丑下丞丛丘丈;
        val_18 = this.丆丞丘与一丄丘丙三;
        if(val_17 == null)
        {
            goto label_16;
        }
        
        label_10:
        var val_4 = (val_18 < this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0;
        label_36:
        if(val_18 <= this.丁丏丈丑下丞丛丘丈.newLeague)
        {
            goto label_17;
        }
        
        val_13 = this.LeagueSubtitle;
        string val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丞与且丘丂丒上七丞(丙丑七万丆万丆且丌:  this.丁丏丈丑下丞丛丘丈.newLeague));
        goto label_21;
        label_17:
        if(((this.丆丞丘与一丄丘丙三 == this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0) == 0)
        {
            goto label_22;
        }
        
        var val_8 = (this.丁丏丈丑下丞丛丘丈.newLeague == RatingSystem.丒丐丁一丈丏丗丅东()) ? 1 : 0;
        val_8 = val_4 & val_8;
        if(val_8 != 1)
        {
            goto label_26;
        }
        
        val_21 = "Key_6478";
        goto label_29;
        label_22:
        if(val_4 == 0)
        {
                return;
        }
        
        val_13 = this.LeagueSubtitle;
        label_21:
        val_15 = val_13;
        val_16 = this.万丛且丐一世上与且(丙丑七万丆万丆且丌:  this.丁丏丈丑下丞丛丘丈.newLeague);
        goto label_34;
        label_16:
        var val_10 = (val_18 < this.丁丏丈丑下丞丛丘丈.newLeague) ? 1 : 0;
        if(this.丁丏丈丑下丞丛丘丈 == null)
        {
            goto label_35;
        }
        
        goto label_36;
        label_26:
        val_21 = this.东丆丂丆丆业丌丗丄(丙丑七万丆万丆且丌:  this.丁丏丈丑下丞丛丘丈.newLeague);
        label_29:
        val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_21);
        val_15 = this.LeagueSubtitle;
        val_16 = val_13;
        label_34:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_15, 丕丗丘丑丛与丑业丒:  val_16);
        return;
        label_35:
    }
    private void 丘丗丗东丙丐丏丕丘(TournamentReward 丗七丟丈三不丕一三)
    {
        var val_4;
        PGCompany.丗丟丄丈东丝丕丄世 val_5;
        var val_6;
        val_4 = 0;
        goto label_1;
        label_7:
        val_5 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.RewardObjects[val_5], 丏业丟一东丂东丘丛:  false);
        val_4 = 1;
        label_1:
        if(val_4 < this.RewardObjects.Length)
        {
            goto label_7;
        }
        
        if(丗七丟丈三不丕一三 == null)
        {
            goto label_8;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardObj, 丏业丟一东丂东丘丛:  true);
        val_6 = 0;
        goto label_11;
        label_25:
        if(val_6 < this.RewardObjects.Length)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.RewardObjects[0], 丏业丟一东丂东丘丛:  true);
            val_5 = PGCompany.丁丑上丞业丞丟丛上.丞丆三丙业丅丙丕丘(不丕三丌万丈丟丆世:  丗七丟丈三不丕一三.reward.Item[0]);
            this.RewardObjects[0].Setup(与且专丈不万东一万:  val_5);
        }
        
        val_6 = 1;
        label_11:
        if(val_6 < 丗七丟丈三不丕一三.reward.Count)
        {
            goto label_25;
        }
        
        return;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardObj, 丏业丟一东丂东丘丛:  false);
    }
    private void 七丘丈丞世业东上七()
    {
        UILabel[] val_3;
        UILabel[] val_4;
        string val_5;
        val_3 = this;
        if(this.ViewState == 2)
        {
            goto label_1;
        }
        
        if(this.ViewState == 1)
        {
            goto label_2;
        }
        
        if(this.ViewState != 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.RewardTitle, 丕丗丘丑丛与丑业丒:  "");
        val_4 = this.UnlockedItemsTitle;
        val_5 = "";
        goto label_11;
        label_1:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.RewardTitle, 丕丗丘丑丛与丑业丒:  "");
        val_3 = this.UnlockedItemsTitle;
        val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2145");
        val_4 = val_3;
        goto label_11;
        label_2:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.RewardTitle, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0291"));
        val_4 = this.UnlockedItemsTitle;
        val_5 = "";
        label_11:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_4, 丕丗丘丑丛与丑业丒:  val_5);
    }
    private void 丅丞丛专丐三东世不(ShieldView 丈万丆丌东丘三丑不, int 丘世丅丕丑专丞三丌, UnityEngine.GameObject[] 且丒丛丕丞丌丏东丑)
    {
        var val_19;
        var val_20;
        System.Collections.IEnumerator val_1 = 丈万丆丌东丘三丑不.shieldPoint.GetEnumerator();
        goto label_15;
        label_22:
        var val_19 = 0;
        val_19 = val_19 + 1;
        object val_3 = val_1.Current;
        0.parent = this._shieldsParent;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        0.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        label_15:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_1.MoveNext() == true)
        {
            goto label_22;
        }
        
        val_19 = 0;
        val_20 = 0;
        if(val_1 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_1.Dispose();
        }
        
        UnityEngine.GameObject val_22 = 且丒丛丕丞丌丏东丑[(long)UnityEngine.Mathf.Clamp(value:  丘世丅丕丑专丞三丌, min:  0, max:  7)];
        val_22.transform.parent = 丈万丆丌东丘三丑不.shieldPoint;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        val_22.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.identity;
        val_22.transform.localRotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w};
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  0.4f);
        val_22.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
    }
    private System.Collections.Generic.List<UnityEngine.Texture> 七上上下丆丞不丙七(RatingSystem.RatingLeague 丙丑七万丆万丆且丌, System.Collections.Generic.List<string> 丟丆丗丞丂丈丛且业)
    {
        RatingLeague val_19;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem> val_29;
        .丙丑七万丆万丆且丌 = 丙丑七万丆万丆且丌;
        System.Collections.Generic.List<UnityEngine.Texture> val_2 = new System.Collections.Generic.List<UnityEngine.Texture>();
        System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<System.String>> val_3 = 七丌丞万七万丁丐丙.丈不丌下与丐丕东丟();
        System.Collections.Generic.List<System.String> val_4 = null;
        val_24 = val_4;
        val_4 = new System.Collections.Generic.List<System.String>();
        if((val_3.ContainsKey(key:  (SeasonEndView.丅一丑三一一丅丑丌)[1152921539730610144].丙丑七万丆万丆且丌)) != false)
        {
                val_24 = val_3.Item[(SeasonEndView.丅一丑三一一丅丑丌)[1152921539730610144].丙丑七万丆万丆且丌];
        }
        
        val_25 = 0;
        goto label_7;
        label_15:
        val_2.Add(item:  丏丄丑上丛不丈且万.丛丒一丑丌一专业与(丕丁下丌不万丅丞丛:  val_24.Item[0]));
        丟丆丗丞丂丈丛且业.Add(item:  丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_24.Item[0], 七丆丒与丗丌丄且丂:  6));
        val_25 = 1;
        label_7:
        if(val_25 < val_24.Count)
        {
            goto label_15;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = null;
        val_27 = null;
        val_29 = SeasonEndView.<>c.<>9__84_1;
        if(val_29 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem> val_14 = null;
            val_29 = val_14;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem>(object:  SeasonEndView.<>c.__il2cppRuntimeField_static_fields, method:  SkinItem SeasonEndView.<>c::丘丌丙丝丄上丈丞三(System.Collections.Generic.KeyValuePair<string, SkinItem> 丈丏万丄丒业丅丒一));
            SeasonEndView.<>c.<>9__84_1 = val_29;
        }
        
        List.Enumerator<T> val_17 = System.Linq.Enumerable.ToList<SkinItem>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, SkinItem>>(source:  SkinsController.丄丞丁丈与业上丞丟.丛万丘丐丛与丏丗且, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, System.Boolean>(object:  new SeasonEndView.丅一丑三一一丅丑丌(), method:  System.Boolean SeasonEndView.丅一丑三一一丅丑丌::三丆一丄丈丏丐专业(System.Collections.Generic.KeyValuePair<string, SkinItem> 丈丏万丄丒业丅丒一))), selector:  val_14)).GetEnumerator();
        label_32:
        if((763972480 & 1) == 0)
        {
            goto label_25;
        }
        
        val_19 = .丙丑七万丆万丆且丌;
        val_2.Add(item:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "LeagueSkinsProfileImages/league{0}_skin_profile", arg0:  val_19)));
        丟丆丗丞丂丈丛且业.Add(item:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_19.丐丏七丌丕丗业且上()));
        goto label_32;
        label_25:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
    }
    public void HandleContinueClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        if(this.ViewState == 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(SeasonEndView.丄与丙丛丙丕丑专丄 == false)
        {
                return;
        }
        
        if(this.丏丝丏丛丌丝丑丈专 != 0)
        {
                return;
        }
        
        if(this.ViewState != 2)
        {
                if(this.ViewState != 1)
        {
                return;
        }
        
            this.丏丝丏丛丌丝丑丈专 = this.ViewState;
            this.且业上丞丄丁专不丙(丕下一七东丁丌丂专:  new System.Action(object:  this, method:  System.Void SeasonEndView::业丑东上与东丘丈且()));
            TournamentController.丝丁七丅且且不丂丆(不丘丅丝且丏上一丒:  true);
            TournamentController.下且与一万丙丗且丁();
            return;
        }
        
        this.Close();
    }
    private void 丞三丂丅丛丗专丟一()
    {
        this.HandleContinueClicked(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 且业上丞丄丁专不丙(System.Action 丕下一七东丁丌丂专)
    {
        int val_22;
        System.Collections.Generic.List<丑不且丁丌专不东丂> val_23;
        var val_24;
        .丕下一七东丁丌丂专 = 丕下一七东丁丌丂专;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  159);
        Rilisoft.Singleton<TournamentController>.Instance.世三丝业下三丗七丕();
        NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  4);
        if((this.丁丏丈丑下丞丛丘丈 != null) && (this.丁丏丈丑下丞丛丘丈.reward != null))
        {
                bool val_4 = Competition.丄世丌丕丒丏上世丞.丛丆世丏丒丕丅丁东(上业丟世三与七七三:  this.丁丏丈丑下丞丛丘丈.reward);
        }
        
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                Rilisoft.Singleton<TournamentController>.Instance.丒且丙不一丒丏丆丂(丗七丟丈三不丕一三:  this.丁丏丈丑下丞丛丘丈);
            TournamentController.丝丂丐丞丄丑丗丐一(丗七丟丈三不丕一三:  this.丁丏丈丑下丞丛丘丈);
        }
        
        TournamentController.三丏丄丌且下丗一东(丙丑七万丆万丆且丌:  this.丆丞丘与一丄丘丙三, 万且丒下丕丝专丟上:  this.且与丒三丆下专世丆);
        val_22 = this.且与丒三丆下专世丆;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丘上专丐丙丆丅丕下(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 且丒丛与丞世丙丕丌:  this.丁丏丈丑下丞丛丘丈.resultPlace, 一丟下丝且丈丆业上:  val_22, 丈丘丙丛丗不七专丟:  this.丆丞丘与一丄丘丙三.ToString(), 丈丐丒丐丕丛东丑业:  this.丁丏丈丑下丞丛丘丈.newLeague.ToString(), 上业丟世三与七七三:  this.丁丏丈丑下丞丛丘丈, 且丐丐丁丐丒丌丗丙:  this.丁丏丈丑下丞丛丘丈.seasonId);
        if((Competition.丄世丌丕丒丏上世丞.七下七丞一丛世丑丝(且丒丛与丞世丙丕丌:  this.丁丏丈丑下丞丛丘丈.resultPlace, 丙丑七万丆万丆且丌:  this.丆丞丘与一丄丘丙三)) == null)
        {
            goto label_30;
        }
        
        val_23 = val_11.AttributeDatas;
        if(val_23 != null)
        {
            goto label_31;
        }
        
        label_30:
        System.Collections.Generic.List<丑不且丁丌专不东丂> val_12 = null;
        val_23 = val_12;
        val_12 = new System.Collections.Generic.List<丑不且丁丌专不东丂>();
        label_31:
        val_24 = 0;
        goto label_32;
        label_44:
        丑不且丁丌专不东丂 val_15 = val_12.Item[0];
        val_22 = PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  val_12.Item[0].万东丏一且丛东丐丛(), 丙业与丙丗丝不丈东:  val_15.Value);
        丑不且丁丌专不东丂 val_17 = val_12.Item[0];
        PGCompany.AttributeSystem.丞丂丄丗丟万丞丕丆<T> val_18 = PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丈丄专丙丝丑丒丗丈<System.Int32>(世三三丁丕丐丘丐丟:  val_17.Type, 上丄业丑且一万丁丞:  val_22, 专丒丌丆下丐丞丟丞:  0, 一丗丈丛万丄世一丘:  0);
        val_24 = 1;
        label_32:
        if(val_24 < val_12.Count)
        {
            goto label_44;
        }
        
        UniversalRewardBanner.丒丏丏丛丕丐丂丛丐(丙业与丙丗丝不丈东:  new System.Action(object:  new SeasonEndView.丝丞与丞不丝一丁丒(), method:  System.Void SeasonEndView.丝丞与丞不丝一丁丒::丟东不丕万丄丟丛丄()));
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        mem[1152921539731183736] = 0;
    }
    public void Close()
    {
        var val_4;
        var val_5;
        ExperienceController val_6;
        var val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        val_4 = null;
        val_4 = null;
        SeasonEndView.世丑丗上丘丟丐丂丕 = false;
        if((this.三丝上丁丆丒丌与且 & 1) != 0)
        {
                val_5 = null;
            val_5 = null;
            val_6 = ExperienceController.sharedController;
            if(val_6 != 0)
        {
                val_7 = null;
            val_7 = null;
            val_6 = ExperienceController.sharedController;
            val_6.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  this.三丝上丁丆丒丌与且 & 1);
        }
        
            mem2[0] = 0;
        }
        
        if(this.三丁丕丈丅丏丅丕丌 == null)
        {
                return;
        }
        
        this.三丁丕丈丅丏丅丕丌.Invoke();
    }
    private void 万东三丈上丙丈丆下(Rilisoft.OfferItem 丗七丟丈三不丕一三)
    {
        if(丗七丟丈三不丕一三 == null)
        {
                return;
        }
        
        if((Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丏且丕丄丁丟丆丏丁:  丗七丟丈三不丕一三, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false)) == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cupsCamera.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToContinueLableObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丟世丅丄专一丘丒丒()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cupsCamera.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToContinueLableObject, 丏业丟一东丂东丘丛:  true);
    }
    private string 丆不丄丝丏三丌丏丄()
    {
        return "Key_11685";
    }
    private string 万丛且丐一世上与且(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11687"), arg0:  LeaguesGUIController.丅且万专丁丘不三丑(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
    }
    private string 丞与且丘丂丒上七丞(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11689"), arg0:  LeaguesGUIController.丅且万专丁丘不三丑(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
    }
    private string 东丆丂丆丆业丌丗丄(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        return System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11688"), arg0:  LeaguesGUIController.丅且万专丁丘不三丑(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
    }
    private void OnDestroy()
    {
        var val_4;
        var val_5;
        ExperienceController val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        SeasonEndView.世丑丗上丘丟丐丂丕 = false;
        if((this.三丝上丁丆丒丌与且 & 1) != 0)
        {
                val_5 = null;
            val_5 = null;
            val_6 = ExperienceController.sharedController;
            if(val_6 != 0)
        {
                val_7 = null;
            val_7 = null;
            val_6 = ExperienceController.sharedController;
            val_6.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  this.三丝上丁丆丒丌与且 & 1);
        }
        
            mem2[0] = 0;
        }
        
        Rilisoft.ItemViewer.remove_OnViewerHided(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SeasonEndView::丟世丅丄专一丘丒丒()));
    }
    public SeasonEndView()
    {
    
    }
    private static SeasonEndView()
    {
        SeasonEndView.丈东丘丏与丌东东下 = 0;
        SeasonEndView.上专业丘丝丕丆丘七 = 0;
        SeasonEndView.且丙七丕丛专业丁丕 = 0;
    }

}
