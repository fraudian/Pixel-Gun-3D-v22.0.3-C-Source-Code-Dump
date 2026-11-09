using UnityEngine;
internal sealed class ProfileView : MonoBehaviour
{
    // Fields
    private System.EventHandler<ProfileView.上丟丁丏丕上不不丒> 丌丈丛丏丁七丂丂下;
    internal static ProfileView 丄丞丁丈与业上丞丟;
    public UnityEngine.GameObject hintNameNotValid;
    public UILabel pixelgunFriendsID;
    public UnityEngine.GameObject interfaceHolder;
    public UIRoot interfaceHolder2d;
    public UnityEngine.GameObject worldHolder3d;
    public UILabel dungeonsWinCount;
    public UILabel dungeonsEasyWinCount;
    public UILabel dungeonsMediumWinCount;
    public UILabel dungeonsHardWinCount;
    public UILabel totalWeeklyWinsCount;
    public UILabel deathmatchWinCount;
    public UILabel teamBattleWinCount;
    public UILabel capturePointCount;
    public UILabel battleRoyaleWinCount;
    public UILabel deadlyGamesWinCount;
    public UILabel flagCaptureWinCount;
    public UILabel duelCount;
    public UILabel teamDuelCount;
    public UILabel totalWinCount;
    public UILabel totalLikeCount;
    public UILabel freePlayWinCount;
    public UILabel lbGameTotalKills;
    public UILabel lbGameKillrate;
    public UILabel lbGameAccuracy;
    public UILabel lbGameLikes;
    public UILabel coopTimeSurvivalPointCount;
    public UILabel waveCountLabel;
    public UILabel killedCountLabel;
    public UILabel survivalScoreLabel;
    public UILabel box1StarsLabel;
    public UILabel box2StarsLabel;
    public UILabel box3StarsLabel;
    public UILabel box4StarsLabel;
    public UILabel secretCoinsLabel;
    public UILabel secretGemsLabel;
    public UILabel battleRoyaleKillRate;
    public UILabel sevenMatchesKillRate;
    public UILabel thirtyMatchesKillRate;
    public UIInputRilisoft nicknameInput;
    public UILabel nicknameOffline;
    public UITexture clanLogo;
    public Rilisoft.ButtonHandler backButton;
    public UIButton achievementsButton;
    public UIButton leaderboardsButton;
    public UIButton copyIdButton;
    public UIButton userCharactersButton;
    public CharacterView characterView;
    private Rilisoft.ButtonHandler _openNewsBtn;
    private Rilisoft.PrefabHandler _newsPrefab;
    private UnreadNewsCounter[] _unreadNewsCounters;
    private Rilisoft.专丕丝丏丒一一万丏<PGCompany.NewsLobbyController> 世专丟丆丙丂丙万丂;
    private UnityEngine.GameObject _subwindowsHandler;
    public UnityEngine.GameObject newsIndicator;
    public UnityEngine.AudioClip newsLobbyButtonSound;
    public bool _isCancellationRequested;
    private ExpView 丟丑丗丈丄七丞丕与;
    private UnityEngine.GameObject devChangeServer;
    private PGCompany.Clans.ClanRankSimpleView clanRank;
    
    // Properties
    public bool 丏丈下丛丌上丐丅丙 { get; }
    public string 丅上丄丝丕三丘东丁 { get; set; }
    public string 专业丕不丞丄东丛三 { get; set; }
    public string 丟七业不丂丆与上与 { get; set; }
    public string 东丗丕专丁丌丙上丞 { get; set; }
    public string 世专一丝东丞一丂丟 { get; set; }
    public string 丒不丗万丙东丑丌丐 { get; set; }
    public string 丄万下世丁下丏一上 { get; set; }
    public string 丌丛丛丝且丆上丗专 { get; set; }
    public string 丄世丝丞丌业丁不上 { get; set; }
    public string 一丘丅丆丝三不万上 { get; set; }
    public string 东且丕丟丂丒不丐丛 { get; set; }
    public string 丛丌丂丘丙丌丝丟丏 { get; set; }
    public string 丕与丌丄三丞丘丛丗 { get; set; }
    public string 业丂丆一丂丛下丗且 { get; set; }
    public string 业丛丂下丘丟七丐丗 { get; set; }
    public string 丈与丙世不业专丗一 { get; set; }
    public string 丗丂下丐丆丏丅丘上 { get; set; }
    public string 下丟七丝丕不下上丑 { get; set; }
    public string 丗丞丈丅丗丟丌丕丆 { get; set; }
    public string 丒丙不与丂上世不丂 { get; set; }
    public string 上丝七丅世七上丛丕 { get; set; }
    public string 上丞东一万且世丈丙 { get; set; }
    public string 丛一不东丘丄丘丟三 { get; set; }
    public string 丂丒上丂丒与丌七丝 { get; set; }
    public string 且与丛丙下万丆丟丑 { get; set; }
    public string 丐一上三东丗丁专丗 { get; set; }
    public string 丛下世丂下下丐一丗 { get; set; }
    public string 丈万丟与业不丘东丄 { get; set; }
    public string 丌专万丘丄丙丒丂丈 { get; set; }
    private bool 丙丏且丑业丐七丄丏 { get; }
    
    // Methods
    public bool get_NewsOpened()
    {
        if(this.世专丟丆丙丂丙万丂 == null)
        {
                return (bool)this.世专丟丆丙丂丙万丂;
        }
        
        return this.世专丟丆丙丂丙万丂.丅专七丞东丐丒丒丗();
    }
    public string get_DeathmatchWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.deathmatchWinCount);
    }
    public void set_DeathmatchWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.deathmatchWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_TotalWeeklyWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.totalWeeklyWinsCount);
    }
    public void set_TotalWeeklyWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.totalWeeklyWinsCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_TeamBattleWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.teamBattleWinCount);
    }
    public void set_TeamBattleWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.teamBattleWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_CapturePointWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.capturePointCount);
    }
    public void set_CapturePointWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.capturePointCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_DuelWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.duelCount);
    }
    public void set_DuelWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.duelCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_TeamDuelWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.teamDuelCount);
    }
    public void set_TeamDuelWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.teamDuelCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_FreePlayWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.freePlayWinCount);
    }
    public void set_FreePlayWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.freePlayWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_DeadlyGamesWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.deadlyGamesWinCount);
    }
    public void set_DeadlyGamesWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.deadlyGamesWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_BattleRoyaleWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.battleRoyaleWinCount);
    }
    public void set_BattleRoyaleWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.battleRoyaleWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_DungeonWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.dungeonsWinCount);
    }
    public void set_DungeonWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.dungeonsWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_FlagCaptureWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.flagCaptureWinCount);
    }
    public void set_FlagCaptureWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.flagCaptureWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_TotalWinCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.totalWinCount);
    }
    public void set_TotalWinCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.totalWinCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_TotalLikeCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.totalLikeCount);
    }
    public void set_TotalLikeCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.totalLikeCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_PixelgunFriendsID()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.pixelgunFriendsID);
    }
    public void set_PixelgunFriendsID(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.pixelgunFriendsID, 丙业与丙丗丝不丈东:  "ID: "("ID: ") + 丙业与丙丗丝不丈东);
    }
    public string get_CoopTimeSurvivalPointCount()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.coopTimeSurvivalPointCount);
    }
    public void set_CoopTimeSurvivalPointCount(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.coopTimeSurvivalPointCount, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_GameTotalKills()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.lbGameTotalKills);
    }
    public void set_GameTotalKills(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lbGameTotalKills, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_GameKillrate()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.lbGameKillrate);
    }
    public void set_GameKillrate(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lbGameKillrate, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_GameAccuracy()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.lbGameAccuracy);
    }
    public void set_GameAccuracy(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lbGameAccuracy, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_GameLikes()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.lbGameLikes);
    }
    public void set_GameLikes(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lbGameLikes, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_WaveCountLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.waveCountLabel);
    }
    public void set_WaveCountLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.waveCountLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_KilledCountLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.killedCountLabel);
    }
    public void set_KilledCountLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.killedCountLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_SurvivalScoreLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.survivalScoreLabel);
    }
    public void set_SurvivalScoreLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.survivalScoreLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public string get_Box1StarsLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.box1StarsLabel);
    }
    public void set_Box1StarsLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.box1StarsLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(this.box1StarsLabel == 0)
        {
                return;
        }
        
        UISprite val_2 = this.box1StarsLabel.GetComponentInChildren<UISprite>();
        if(val_2 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.box1StarsLabel.transform.localPosition;
        this = val_2.transform;
        int val_7 = this.box1StarsLabel.width;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintNameNotValid, 丏业丟一东丂东丘丛:  false);
    }
    public void HideNotifValidation()
    {
        this.StopCoroutine(routine:  this.丐且丑丅丈丒丝东不());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hintNameNotValid, 丏业丟一东丂东丘丛:  false);
    }
    internal System.Collections.IEnumerator 丐且丑丅丈丒丝东不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ProfileView.丑丗下一三丁丞丟丝();
    }
    public string get_Box2StarsLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.box2StarsLabel);
    }
    public void set_Box2StarsLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.box2StarsLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(this.box2StarsLabel == 0)
        {
                return;
        }
        
        UISprite val_2 = this.box2StarsLabel.GetComponentInChildren<UISprite>();
        if(val_2 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.box2StarsLabel.transform.localPosition;
        this = val_2.transform;
        int val_7 = this.box2StarsLabel.width;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public string get_Box3StarsLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.box3StarsLabel);
    }
    public void set_Box3StarsLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.box3StarsLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(this.box3StarsLabel == 0)
        {
                return;
        }
        
        UISprite val_2 = this.box3StarsLabel.GetComponentInChildren<UISprite>();
        if(val_2 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.box3StarsLabel.transform.localPosition;
        this = val_2.transform;
        int val_7 = this.box3StarsLabel.width;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public string get_Box4StarsLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.box4StarsLabel);
    }
    public void set_Box4StarsLabel(string 丙业与丙丗丝不丈东)
    {
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.box4StarsLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(this.box4StarsLabel == 0)
        {
                return;
        }
        
        UISprite val_2 = this.box4StarsLabel.GetComponentInChildren<UISprite>();
        if(val_2 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.box4StarsLabel.transform.localPosition;
        this = val_2.transform;
        int val_7 = this.box4StarsLabel.width;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public string get_SecretCoinsLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.secretCoinsLabel);
    }
    public void set_SecretCoinsLabel(string 丙业与丙丗丝不丈东)
    {
        var val_8;
        UILabel val_9;
        val_8 = this;
        val_9 = this.secretCoinsLabel;
        if(val_9 == 0)
        {
                return;
        }
        
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.secretCoinsLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        UISprite val_2 = this.secretCoinsLabel.GetComponentInChildren<UISprite>();
        if(val_2 == 0)
        {
                return;
        }
        
        val_9 = this.secretCoinsLabel.transform;
        UnityEngine.Vector3 val_5 = val_9.localPosition;
        val_8 = val_2.transform;
        int val_7 = this.secretCoinsLabel.width;
        val_8.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public string get_SecretGemsLabel()
    {
        return ProfileView.万丌丂上丈三丗丟丑(七丐丞丑丑丕世丙七:  this.secretGemsLabel);
    }
    public void set_SecretGemsLabel(string 丙业与丙丗丝不丈东)
    {
        var val_8;
        UILabel val_9;
        val_8 = this;
        val_9 = this.secretGemsLabel;
        if(val_9 == 0)
        {
                return;
        }
        
        ProfileView.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.secretGemsLabel, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        UISprite val_2 = this.secretGemsLabel.GetComponentInChildren<UISprite>();
        if(val_2 == 0)
        {
                return;
        }
        
        val_9 = this.secretGemsLabel.transform;
        UnityEngine.Vector3 val_5 = val_9.localPosition;
        val_8 = val_2.transform;
        int val_7 = this.secretGemsLabel.width;
        val_8.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public string get_Nickname()
    {
        UIInputRilisoft val_3;
        int val_4;
        val_3 = this;
        if(this.nicknameInput != 0)
        {
                val_3 = this.nicknameInput;
            if(val_3.value != null)
        {
                return (string)val_4;
        }
        
        }
        
        val_4 = System.String.alignConst;
        return (string)val_4;
    }
    public void set_Nickname(string 丙业与丙丗丝不丈东)
    {
        if(this.nicknameOffline == 0)
        {
            goto label_3;
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_4;
        }
        
        label_12:
        this.nicknameOffline.text = 丙业与丙丗丝不丈东;
        label_3:
        if(this.nicknameInput == 0)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_9;
        }
        
        label_14:
        this.nicknameInput.value = 丙业与丙丗丝不丈东;
        return;
        label_4:
        if(this.nicknameOffline != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_9:
        if(this.nicknameInput != null)
        {
            goto label_14;
        }
        
        goto label_14;
    }
    private bool 丁丞东丆丑丟丆丄与()
    {
        bool val_2 = System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    private void Awake()
    {
        ProfileView.丄丞丁丈与业上丞丟 = this;
        if(this.copyIdButton != 0)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                this.copyIdButton.gameObject.SetActive(value:  false);
        }
        
        }
        
        this.世专丟丆丙丂丙万丂 = new Rilisoft.专丕丝丏丒一一万丏<PGCompany.NewsLobbyController>(丆万丕丏与丈与丒丗:  this._newsPrefab.ResourcePath, 丆丏七丟不丒与七专:  this._subwindowsHandler);
    }
    private void Start()
    {
        var val_9;
        var val_10;
        MainMenuController val_11;
        if(this.世专丟丆丙丂丙万丂 != null)
        {
                if(this.世专丟丆丙丂丙万丂.丅专七丞东丐丒丒丗() != false)
        {
                this.世专丟丆丙丂丙万丂.世三丞丅丑丌丈丈一().gameObject.SetActive(value:  false);
        }
        
        }
        
        if(this._openNewsBtn != 0)
        {
                this._openNewsBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void ProfileView::HandleNewsButtonClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(MailBoxMessagesController.丄丞丁丈与业上丞丟 != null)
        {
                MailBoxMessagesController.丄丞丁丈与业上丞丟.丛丑不三丂东下专丌(三万专丛丟上丏丅下:  "");
        }
        
        val_9 = null;
        val_9 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        System.Array.Resize<UnreadNewsCounter>(array: ref  this._unreadNewsCounters, newSize:  (UnreadNewsCounter[].__il2cppRuntimeField_namespaze + this._unreadNewsCounters.Length)>>0&0xFFFFFFFF);
        val_11 = MainMenuController.丄丞丁丈与业上丞丟;
        if(MainMenuController.丄丞丁丈与业上丞丟 != null)
        {
            goto label_21;
        }
        
        val_11 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_11 == null)
        {
            goto label_22;
        }
        
        label_21:
        System.Array.Copy(sourceArray:  MainMenuController.丄丞丁丈与业上丞丟._unreadNewsCounters, sourceIndex:  0, destinationArray:  mem[this._unreadNewsCounters], destinationIndex:  this._unreadNewsCounters.Length, length:  UnreadNewsCounter[].__il2cppRuntimeField_namespaze);
        return;
        label_22:
    }
    internal void 丞丁丞丘丛不丑与万()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.clanRank, 丏业丟一东丂东丘丛:  丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans"));
    }
    internal void 下东丂下丗上丐且上()
    {
        if(this.nicknameOffline == 0)
        {
                return;
        }
        
        if(this.nicknameInput == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nicknameOffline.gameObject, 丏业丟一东丂东丘丛:  与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.nicknameInput.gameObject, 丏业丟一东丂东丘丛:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
    }
    private void Update()
    {
        if(this._isCancellationRequested == false)
        {
                return;
        }
        
        this.CloseNews();
        this._isCancellationRequested = false;
    }
    public void CloseNews()
    {
        ExperienceController val_5;
        var val_6;
        var val_7;
        val_5 = this;
        if(this.NewsOpened == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.世专丟丆丙丂丙万丂.世三丞丅丑丌丈丈一().gameObject, 丏业丟一东丂东丘丛:  false);
        this.世专丟丆丙丂丙万丂.丙不丂丝丒丐专丝丆();
        val_6 = null;
        val_6 = null;
        val_5 = ExperienceController.sharedController;
        if(val_5 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
    }
    public void SetUnreadNewsCount(int 丌丒丝东丌下丕丁丅)
    {
        goto label_1;
        label_8:
        UnreadNewsCounter val_2 = this._unreadNewsCounters[0];
        if(val_2 != 0)
        {
                val_2.UpdateUnreadNewsCount(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
        }
        
        0 = 1;
        label_1:
        if(0 < this._unreadNewsCounters.Length)
        {
            goto label_8;
        }
    
    }
    public void HandleNewsButtonClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        ExperienceController val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.newsLobbyButtonSound);
        }
        
        this.世专丟丆丙丂丙万丂.世三丞丅丑丌丈丈一().gameObject.SetActive(value:  true);
        val_9 = null;
        val_9 = null;
        val_7 = ExperienceController.sharedController;
        if(val_7 == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
    }
    public void OnSubmit()
    {
        if(this.nicknameInput == 0)
        {
                return;
        }
        
        if(this.丌丈丛丏丁七丂丂下 == null)
        {
                return;
        }
        
        this.丌丈丛丏丁七丂丂下.Invoke(sender:  this, e:  new ProfileView.上丟丁丏丕上不不丒(丗丄下丈丑七丗丞专:  this.nicknameInput.value));
    }
    public void OnCopyIdClick()
    {
        FriendsController.丅七丈丁丗丁与丐七();
    }
    public void add_BackButtonPressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.backButton == 0)
        {
                return;
        }
        
        this.backButton.add_Clicked(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void remove_BackButtonPressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        if(this.backButton == 0)
        {
                return;
        }
        
        this.backButton.remove_Clicked(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public void FireBackPressed()
    {
        if(this.backButton == 0)
        {
                return;
        }
        
        this.backButton.DoClick();
    }
    public void U_HandleUserCharactersClicked()
    {
        var val_1;
        this.FireBackPressed();
        val_1 = null;
        val_1 = null;
        MainMenuController.丄丞丁丈与业上丞丟.OpenUserCharactersWindowFromLobby();
    }
    public void add_NicknameInput(System.EventHandler<ProfileView.上丟丁丏丕上不不丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌丈丛丏丁七丂丂下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌丈丛丏丁七丂丂下 != 1152921538757824216);
    
    }
    public void remove_NicknameInput(System.EventHandler<ProfileView.上丟丁丏丕上不不丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌丈丛丏丁七丂丂下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌丈丛丏丁七丂丂下 != 1152921538757960792);
    
    }
    public void SetClanLogo(string 一丘上丟丝丆丕丐丁)
    {
        if(this.clanLogo == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "clanLogo == null");
            return;
        }
        
        bool val_3 = UnityEngine.Object.op_Equality(x:  CharacterView.丅丒丒丑东丑丅七业(一丘上丟丝丆丕丐丁:  一丘上丟丝丆丕丐丁), y:  0);
        if(this.clanLogo == null)
        {
            goto label_8;
        }
        
        if(val_3 == false)
        {
            goto typeof(UITexture).__il2cppRuntimeField_2E8;
        }
        
        label_13:
        this.clanLogo.transform.parent.gameObject.SetActive(value:  false);
        return;
        label_8:
        if(val_3 == true)
        {
            goto label_13;
        }
        
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
    }
    public void SetWeaponAndSkin(string 丒东业不丐丑丕丄丆)
    {
        var val_5 = null;
        this.characterView.一三上三丆丂东丟三(三不三丟专丘东东丂:  丒东业不丐丑丕丄丆, 丅专丕三且丑丘专下:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  丏丄丑上丛不丈且万.丘与丗业丁丞专丝世(丆万一不丌且东丐丐:  丒东业不丐丑丕丄丆)), 丐万三丘东丌丝丗下:  SkinsController.丌与世丂丘且下丒丑, 七一丐上丙丂丑丅丁:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈(), 下且丆且丂七丛与一:  false);
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.characterView.gameObject);
    }
    public void UpdateHat(string 上丈专丌万丕丙万丘)
    {
        this.characterView.UpdateHat(上丈专丌万丕丙万丘:  上丈专丌万丕丙万丘, 丅丞七丟丘丆丟丘丞:  false);
    }
    public void RemoveHat()
    {
        this.characterView.RemoveHat();
    }
    public void UpdateMask(string 丟世丟丐且丐丟七上)
    {
        this.characterView.UpdateMask(丟世丟丐且丐丟七上:  丟世丟丐且丐丟七上, 丅丞七丟丘丆丟丘丞:  false);
    }
    public void RemoveMask()
    {
        this.characterView.RemoveMask();
    }
    public void UpdateCape(string 丈丐丕业下丟业丛一)
    {
        this.characterView.UpdateCape(丈丐丕业下丟业丛一:  丈丐丕业下丟业丛一, 下万东丕丏丟丟丝丗:  0, 丅丞七丟丘丆丟丘丞:  false);
    }
    public void RemoveCape()
    {
        this.characterView.RemoveCape();
    }
    public void UpdateBoots(string 上世丘丐东万丐丆不)
    {
        this.characterView.UpdateBoots(上世丘丐东万丐丆不:  上世丘丐东万丐丆不, 丅丞七丟丘丆丟丘丞:  false);
    }
    public void RemoveBoots()
    {
        this.characterView.RemoveBoots();
    }
    public void UpdateArmor(string 与丙丕丛一丌丛丆丈)
    {
        this.characterView.七丑世万东专丂与丏(与丙丕丛一丌丛丆丈:  与丙丕丛一丌丛丆丈, 丛丆世丂丒丁不世不:  丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  与丙丕丛一丌丛丆丈));
        ShopNGUIController.丙丗丐丁丆不丈上丈(世丟丈丏丕万丝丆万:  this.characterView.万丟一丙丙丅丗丒且(), 下丈丝丁丟下世丐丒:  false);
    }
    public void RemoveArmor()
    {
        this.characterView.RemoveArmor();
    }
    private static string 万丌丂上丈三丗丟丑(UILabel 七丐丞丑丑丕世丙七)
    {
        int val_3;
        if(七丐丞丑丑丕世丙七 != 0)
        {
                if(七丐丞丑丑丕世丙七.text != null)
        {
                return (string)val_3;
        }
        
        }
        
        val_3 = System.String.alignConst;
        return (string)val_3;
    }
    private static void 丒丁丅一下丂专万不(UILabel 七丐丞丑丑丕世丙七, string 丙业与丙丗丝不丈东)
    {
        if(七丐丞丑丑丕世丙七 == 0)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_4;
        }
        
        label_7:
        七丐丞丑丑丕世丙七.text = 丙业与丙丗丝不丈东;
        return;
        label_4:
        if(七丐丞丑丑丕世丙七 != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    public void CheckBtnCopy()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.与丘与丄丐丏丙丄三());
    }
    private System.Collections.IEnumerator 与丘与丄丐丏丙丄三()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ProfileView.上世下专不丆丅丂丛();
    }
    public void U_ChangeServer()
    {
    
    }
    public ProfileView()
    {
    
    }

}
