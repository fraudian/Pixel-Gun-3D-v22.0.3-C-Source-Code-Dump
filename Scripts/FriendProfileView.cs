using UnityEngine;
internal sealed class FriendProfileView : MonoBehaviour
{
    // Fields
    private const string 丝丒专丄东丙丐丗丙 = "-";
    internal static FriendProfileView 丐丕丝上丅丈丐丞专;
    private static UnityEngine.Vector3 世丛丝丅丟与东丈丛;
    private readonly Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Rect> 丕丅丅一丝丅丛丝与;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private bool 丆丐丕丈业丛丆丐业;
    public UISprite addClanButtonSentState;
    public UISprite addFrienButtonSentState;
    public UIButton addFriendButton;
    public UILabel addOrRemoveButtonLabel;
    public UISprite askedOpenChestsButton;
    public UIButton askOpenChestsButton;
    public UIButton backButton;
    public UnityEngine.GameObject loadingClan;
    public UnityEngine.GameObject background;
    public UnityEngine.GameObject allInterfacePanel;
    public UnityEngine.GameObject panelSeeLobby;
    public UnityEngine.GameObject playerModelLightObj;
    public UnityEngine.GameObject[] bootsPoint;
    public UITable buttonAlignContainer;
    private CharacterInterfaceV2 东丗丏世丑与丌丒丄;
    public UIButton chatButton;
    public UIButton clanButton;
    public UITexture clanLogo;
    public UILabel clanName;
    public UILabel clanRoleLabel;
    public UISprite clanRoleSprite;
    public PGCompany.Clans.ClanRankSimpleView clanRank;
    private UnityEngine.GameObject connectingPanel;
    public ConnectionControl connectionControl;
    private UnityEngine.GameObject 丗上丏丟丆专与丗丆;
    public UILabel friendCountLabel;
    public UILabel friendCupsCount;
    public UILabel friendGameModeLabel;
    public UILabel friendIdLabel;
    public UILabel friendLocationLabel;
    public UILabel friendNameLabel;
    private float 东世七上东丐丁丑东;
    public UISprite inFriendState;
    public UISprite offlineState;
    public UISprite playingState;
    public UISprite CupSprite;
    public UILabel inFriendStateLabel;
    public UILabel offlineStateLabel;
    public UILabel playingStateLabel;
    public UILabel squadStateLabel;
    private System.Nullable<UnityEngine.Vector3> 丁上丄与丑与丌与且;
    private System.Nullable<UnityEngine.Vector3> 丗东丙丙世丒丑与丅;
    private System.Nullable<UnityEngine.Vector3> 丄丈且丕丈且丂七丄;
    private System.Nullable<UnityEngine.Vector3> 三丐丄东丌丌丑业与;
    public UIButton inviteToClanButton;
    public bool isSeeLobbyEnable;
    public UIButton joinButton;
    public UIButton joinSquadButton;
    private float 东丌丆一专与丝丕丝;
    private string 丌丛下丕万丆丏与与;
    public UIButton levelRequiredButton;
    public UnityEngine.GameObject likeContainer;
    public UnityEngine.GameObject dislikeContainer;
    public UIButton likeLobby;
    public UIButton dislikeLobby;
    public UILabel likesCount;
    private System.Collections.Generic.List<string> 丅下丕不丑丁三上丅;
    internal bool 上丐丈专且三丑丁丑;
    private bool 丘丁丘丐一丕丑丆丘;
    private System.IDisposable 丈上丅丗丙丘丞七丐;
    public UIButton makeClanLeaderButton;
    public UIButton makeClanOfficerButton;
    public UIButton makeClanSoldierButton;
    public UISprite notConnectJoinButtonSprite;
    public UnityEngine.Transform pers;
    public UILabel[] playerNameSeeLobby;
    public UnityEngine.GameObject playingStateInfoContainer;
    private System.Collections.Generic.List<object> 与七三丟丝三丙丌万;
    public UILabel rankLable;
    public UISprite rankSprite;
    public UIButton removeFriendButton;
    public UIButton removeFromClanButton;
    public UIButton seeLobby;
    public UIButton sendMyIdButton;
    public UILabel survivalScoreLabel;
    public UILabel[] titlesLabel;
    public UILabel totalWinCountLabel;
    public UILabel winCountLabel;
    private int <丌且丕专丗丙且丑丞>k__BackingField;
    private int <丘丛东上丌丁丗不业>k__BackingField;
    private bool <丟丗丘丞丕世丑丒上>k__BackingField;
    private string <专丈且且丏丄丘丗丞>k__BackingField;
    private int <丌丝下上三丙且万东>k__BackingField;
    private string <丛丞三丈专不丗三丁>k__BackingField;
    private Rilisoft.七下上丝三丛三上一 <丞丈丝世丗丕丂东丞>k__BackingField;
    private int <业丕三丞丘一丒丙丈>k__BackingField;
    private int <丅丐上且且丆丞不丅>k__BackingField;
    private int <七丁丌且世丈丛丝丂>k__BackingField;
    private int <丒丟与专万与丅丙万>k__BackingField;
    private string <丟丈丅上三丆丝东丑>k__BackingField;
    private int <丅丕丅三丈丄丐与丑>k__BackingField;
    private int <且丑丏丗丟专丏东三>k__BackingField;
    private string <且丆上三丒上丐丞丒>k__BackingField;
    private string <丘万世丂丅丐丂丛丌>k__BackingField;
    private string <丌丅丌上丒丑丌一七>k__BackingField;
    private static System.Action<bool> 七丏七丌丝丄业丌不;
    private System.Action 七三丏下上丑丘丑丙;
    private System.Action 丒不丁业丒不丌下且;
    private System.Action 丏世丌丂丒丁丏专丗;
    private System.Action 不七丆丄上丈丙丗丁;
    private System.Action 与丗且丒丐丏不丐丝;
    private System.Action 东丐丐且丛丟丅丞丘;
    private System.Action 丝七丘丌丂丑丌丁丁;
    private System.Action 下万不丂丗丅不丞丌;
    private System.Action 丐丏专上一丈丁丈丅;
    private System.Action 丙丝业万三丌丏丆丐;
    private System.Action 丕万与丂一世上万专;
    private System.Action 丅且上丅丌且专下丙;
    private System.Action 丛丈且丝丅丈丞丂丗;
    private System.Action 三丈丞丘世下丏与丟;
    private System.Action 东丆一丛万丑东丞丘;
    private System.Action 丘丝不丈丟丈丐丙万;
    private System.Action 上丗专丂丐下丙丕丈;
    
    // Properties
    internal static bool 三丝丈丄丘丗丟丙丂 { get; }
    public int 丙丈丗丞丛丆丙丅三 { get; set; }
    public int 上丝七丟丘丂丑丈丈 { get; set; }
    public UnityEngine.GameObject 丄上世丟万丛不丆下 { get; }
    public bool 丘丕丕与七与丕丈不 { get; set; }
    public string 丟专与且丕丌下专东 { get; set; }
    public int 丞且丂丛丝丟丒丒丙 { get; set; }
    public string 东丆丒丒丅丁丐丗丈 { get; set; }
    public Rilisoft.七下上丝三丛三上一 丌丘丐丅丘专与丄不 { get; set; }
    public int 三专丞丄东丂丟七与 { get; set; }
    public int 丄丄丞专万下东丆丐 { get; set; }
    public int 专丂丗东丞七丐丙丑 { get; set; }
    public int 丏七三且丄丗七丑丐 { get; set; }
    public string 世丘上丁万与丙丄丌 { get; set; }
    public int 不丗一业丄丐丐丌丟 { get; set; }
    public int 丛丌丂丘丙丌丝丟丏 { get; set; }
    public string 丐丁丂世丙丁丄丂专 { get; set; }
    public string 丗万三丟丙丏万丅世 { get; set; }
    public string 一且与专丏丄丆丁下 { get; set; }
    
    // Methods
    internal static bool 丆三丅上丏下三丘丑()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(FriendProfileView.丐丕丝上丅丈丐丞专 != null)
        {
                var val_1 = (FriendProfileView.丐丕丝上丅丈丐丞专.isSeeLobbyEnable == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public int get_LikesNumFromServer()
    {
        return (int)this.<丌且丕专丗丙且丑丞>k__BackingField;
    }
    public void set_LikesNumFromServer(int 丙业与丙丗丝不丈东)
    {
        this.<丌且丕专丗丙且丑丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_LikesNumAdding()
    {
        return (int)this.<丘丛东上丌丁丗不业>k__BackingField;
    }
    public void set_LikesNumAdding(int 丙业与丙丗丝不丈东)
    {
        this.<丘丛东上丌丁丗不业>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.GameObject get_characterModel()
    {
        if(this.东丗丏世丑与丌丒丄 != null)
        {
                return this.东丗丏世丑与丌丒丄.gameObject;
        }
        
        return this.东丗丏世丑与丌丒丄.gameObject;
    }
    public bool get_IsCanConnectToFriend()
    {
        return (bool)this.<丟丗丘丞丕世丑丒上>k__BackingField;
    }
    public void set_IsCanConnectToFriend(bool 丙业与丙丗丝不丈东)
    {
        this.<丟丗丘丞丕世丑丒上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_FriendLocation()
    {
        return (string)this.<专丈且且丏丄丘丗丞>k__BackingField;
    }
    public void set_FriendLocation(string 丙业与丙丗丝不丈东)
    {
        this.<专丈且且丏丄丘丗丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_FriendCount()
    {
        return (int)this.<丌丝下上三丙且万东>k__BackingField;
    }
    public void set_FriendCount(int 丙业与丙丗丝不丈东)
    {
        this.<丌丝下上三丙且万东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_FriendName()
    {
        return (string)this.<丛丞三丈专不丗三丁>k__BackingField;
    }
    public void set_FriendName(string 丙业与丙丗丝不丈东)
    {
        this.<丛丞三丈专不丗三丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public Rilisoft.七下上丝三丛三上一 get_Online()
    {
        return (Rilisoft.七下上丝三丛三上一)this.<丞丈丝世丗丕丂东丞>k__BackingField;
    }
    public void set_Online(Rilisoft.七下上丝三丛三上一 丙业与丙丗丝不丈东)
    {
        this.<丞丈丝世丗丕丂东丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_Rank()
    {
        return (int)this.<业丕三丞丘一丒丙丈>k__BackingField;
    }
    public void set_Rank(int 丙业与丙丗丝不丈东)
    {
        this.<业丕三丞丘一丒丙丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_Cups()
    {
        return (int)this.<丅丐上且且丆丞不丅>k__BackingField;
    }
    public void set_Cups(int 丙业与丙丗丝不丈东)
    {
        this.<丅丐上且且丆丞不丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_League()
    {
        return (int)this.<七丁丌且世丈丛丝丂>k__BackingField;
    }
    public void set_League(int 丙业与丙丗丝不丈东)
    {
        this.<七丁丌且世丈丛丝丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_SurvivalScore()
    {
        return (int)this.<丒丟与专万与丅丙万>k__BackingField;
    }
    public void set_SurvivalScore(int 丙业与丙丗丝不丈东)
    {
        this.<丒丟与专万与丅丙万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_Username()
    {
        return (string)this.<丟丈丅上三丆丝东丑>k__BackingField;
    }
    public void set_Username(string 丙业与丙丗丝不丈东)
    {
        this.<丟丈丅上三丆丝东丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_WinCount()
    {
        return (int)this.<丅丕丅三丈丄丐与丑>k__BackingField;
    }
    public void set_WinCount(int 丙业与丙丗丝不丈东)
    {
        this.<丅丕丅三丈丄丐与丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int get_TotalWinCount()
    {
        return (int)this.<且丑丏丗丟专丏东三>k__BackingField;
    }
    public void set_TotalWinCount(int 丙业与丙丗丝不丈东)
    {
        this.<且丑丏丗丟专丏东三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_FriendGameMode()
    {
        return (string)this.<且丆上三丒上丐丞丒>k__BackingField;
    }
    public void set_FriendGameMode(string 丙业与丙丗丝不丈东)
    {
        this.<且丆上三丒上丐丞丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_FriendId()
    {
        return (string)this.<丘万世丂丅丐丂丛丌>k__BackingField;
    }
    public void set_FriendId(string 丙业与丙丗丝不丈东)
    {
        this.<丘万世丂丅丐丂丛丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_NotConnectCondition()
    {
        return (string)this.<丌丅丌上丒丑丌一七>k__BackingField;
    }
    public void set_NotConnectCondition(string 丙业与丙丗丝不丈东)
    {
        this.<丌丅丌上丒丑丌一七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 下不丅丈丑丝丁丅丗(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  FriendProfileView.七丏七丌丝丄业丌不, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendProfileView.七丏七丌丝丄业丌不 != 1152921505179959320);
    
    }
    internal static void 世不丟丌丕丞丝丗丅(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  FriendProfileView.七丏七丌丝丄业丌不, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(FriendProfileView.七丏七丌丝丄业丌不 != 1152921505179959320);
    
    }
    public void add_OnDisableEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.七三丏下上丑丘丑丙, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七三丏下上丑丘丑丙 != this.七三丏下上丑丘丑丙);
    
    }
    public void remove_OnDisableEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.七三丏下上丑丘丑丙, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七三丏下上丑丘丑丙 != this.七三丏下上丑丘丑丙);
    
    }
    public void add_BackButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒不丁业丒不丌下且, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒不丁业丒不丌下且 != this.丒不丁业丒不丌下且);
    
    }
    public void remove_BackButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒不丁业丒不丌下且, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒不丁业丒不丌下且 != this.丒不丁业丒不丌下且);
    
    }
    public void add_LevelRequiredClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏世丌丂丒丁丏专丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏世丌丂丒丁丏专丗 != this.丏世丌丂丒丁丏专丗);
    
    }
    public void remove_LevelRequiredClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏世丌丂丒丁丏专丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏世丌丂丒丁丏专丗 != this.丏世丌丂丒丁丏专丗);
    
    }
    public void add_OpenClanClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.不七丆丄上丈丙丗丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.不七丆丄上丈丙丗丁 != this.不七丆丄上丈丙丗丁);
    
    }
    public void remove_OpenClanClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.不七丆丄上丈丙丗丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.不七丆丄上丈丙丗丁 != this.不七丆丄上丈丙丗丁);
    
    }
    public void add_JoinButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.与丗且丒丐丏不丐丝, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.与丗且丒丐丏不丐丝 != this.与丗且丒丐丏不丐丝);
    
    }
    public void remove_JoinButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.与丗且丒丐丏不丐丝, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.与丗且丒丐丏不丐丝 != this.与丗且丒丐丏不丐丝);
    
    }
    public void add_JoinSquadButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.东丐丐且丛丟丅丞丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.东丐丐且丛丟丅丞丘 != this.东丐丐且丛丟丅丞丘);
    
    }
    public void remove_JoinSquadButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.东丐丐且丛丟丅丞丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.东丐丐且丛丟丅丞丘 != this.东丐丐且丛丟丅丞丘);
    
    }
    public void add_CopyMyIdButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丝七丘丌丂丑丌丁丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝七丘丌丂丑丌丁丁 != this.丝七丘丌丂丑丌丁丁);
    
    }
    public void remove_CopyMyIdButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丝七丘丌丂丑丌丁丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丝七丘丌丂丑丌丁丁 != this.丝七丘丌丂丑丌丁丁);
    
    }
    public void add_ChatButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.下万不丂丗丅不丞丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.下万不丂丗丅不丞丌 != this.下万不丂丗丅不丞丌);
    
    }
    public void remove_ChatButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.下万不丂丗丅不丞丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.下万不丂丗丅不丞丌 != this.下万不丂丗丅不丞丌);
    
    }
    public void add_AddButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐丏专上一丈丁丈丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丏专上一丈丁丈丅 != this.丐丏专上一丈丁丈丅);
    
    }
    public void remove_AddButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐丏专上一丈丁丈丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丏专上一丈丁丈丅 != this.丐丏专上一丈丁丈丅);
    
    }
    public void add_RemoveButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丙丝业万三丌丏丆丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙丝业万三丌丏丆丐 != this.丙丝业万三丌丏丆丐);
    
    }
    public void remove_RemoveButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丙丝业万三丌丏丆丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丙丝业万三丌丏丆丐 != this.丙丝业万三丌丏丆丐);
    
    }
    public void add_InviteToClanButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕万与丂一世上万专, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕万与丂一世上万专 != this.丕万与丂一世上万专);
    
    }
    public void remove_InviteToClanButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕万与丂一世上万专, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕万与丂一世上万专 != this.丕万与丂一世上万专);
    
    }
    public void add_RemoveFromClanButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅且上丅丌且专下丙, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅且上丅丌且专下丙 != this.丅且上丅丌且专下丙);
    
    }
    public void remove_RemoveFromClanButtonClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅且上丅丌且专下丙, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅且上丅丌且专下丙 != this.丅且上丅丌且专下丙);
    
    }
    public void add_UpdateRequested(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛丈且丝丅丈丞丂丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丈且丝丅丈丞丂丗 != this.丛丈且丝丅丈丞丂丗);
    
    }
    public void remove_UpdateRequested(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛丈且丝丅丈丞丂丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丈且丝丅丈丞丂丗 != this.丛丈且丝丅丈丞丂丗);
    
    }
    public void add_AskOpenChestsClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三丈丞丘世下丏与丟, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三丈丞丘世下丏与丟 != this.三丈丞丘世下丏与丟);
    
    }
    public void remove_AskOpenChestsClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三丈丞丘世下丏与丟, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三丈丞丘世下丏与丟 != this.三丈丞丘世下丏与丟);
    
    }
    public void add_MakeClanLeaderClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.东丆一丛万丑东丞丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.东丆一丛万丑东丞丘 != this.东丆一丛万丑东丞丘);
    
    }
    public void remove_MakeClanLeaderClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.东丆一丛万丑东丞丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.东丆一丛万丑东丞丘 != this.东丆一丛万丑东丞丘);
    
    }
    public void add_MakeClanOfficerClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丘丝不丈丟丈丐丙万, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘丝不丈丟丈丐丙万 != this.丘丝不丈丟丈丐丙万);
    
    }
    public void remove_MakeClanOfficerClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丘丝不丈丟丈丐丙万, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘丝不丈丟丈丐丙万 != this.丘丝不丈丟丈丐丙万);
    
    }
    public void add_MakeClanSoldierClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上丗专丂丐下丙丕丈, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丗专丂丐下丙丕丈 != this.上丗专丂丐下丙丕丈);
    
    }
    public void remove_MakeClanSoldierClickEvent(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上丗专丂丐下丙丕丈, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上丗专丂丐下丙丕丈 != this.上丗专丂丐下丙丕丈);
    
    }
    public void SetLobby(System.Collections.Generic.List<string> 三三丟丁丙丝专丅业)
    {
        System.Collections.IEnumerator val_12;
        string val_13;
        var val_14;
        val_12 = this;
        val_13 = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
        if(三三丟丁丙丝专丅业 == null)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  val_13, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        if(三三丟丁丙丝专丅业.Count == 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = FriendProfileView.<>c.<>9__210_0;
        if(val_13 == null)
        {
                val_13 = null;
            val_13 = new System.Func<System.String, System.String>(object:  FriendProfileView.<>c.__il2cppRuntimeField_static_fields, method:  System.String FriendProfileView.<>c::丕丘丛东下丐丘丄三(string 三丟东丕丄丄下下丑));
            FriendProfileView.<>c.<>9__210_0 = val_13;
        }
        
        System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  三三丟丁丙丝专丅业, keySelector:  null));
        if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  val_7, second:  this.丅下丕不丑丁三上丅)) == true)
        {
                return;
        }
        
        this.丅下丕不丑丁三上丅 = val_7;
        val_12 = this.丆丒丈丑业丅丝丘七();
        UnityEngine.Coroutine val_11 = CoroutineRunner.Instance.StartCoroutine(routine:  val_12);
    }
    public void HandleLikeClicked()
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丘万世丂丅丐丂丛丌>k__BackingField)) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "HandleLikeClicked friend id is null or empty", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        与与一丆专丕丄丆丗.丑七不且上丗丁一世().丄且三丗下业丟万上(丄丒且丙三丆丟与丏:  this.<丘万世丂丅丐丂丛丌>k__BackingField);
    }
    public void HandleDislikeClicked()
    {
        null = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丘万世丂丅丐丂丛丌>k__BackingField)) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "HandleDislikeClicked friend id is null or empty", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        与与一丆专丕丄丆丗.丑七不且上丗丁一世().丘且业丄专丆东东万(丄丒且丙三丆丟与丏:  this.<丘万世丂丅丐丂丛丌>k__BackingField);
    }
    public void HandleSeeLobby()
    {
        this.丗三丒上万丅业一丒(丝三丄专丗丞丄丄丌:  true);
    }
    public void HandleBackSeeLobby()
    {
        this.丗三丒上万丅业一丒(丝三丄专丗丞丄丄丌:  false);
    }
    private void 丗三丒上万丅业一丒(bool 丝三丄专丗丞丄丄丌)
    {
        bool val_88;
        bool val_89;
        bool val_90;
        bool val_91;
        var val_92;
        var val_93;
        var val_94;
        bool val_95;
        var val_96;
        var val_97;
        bool val_98;
        var val_99;
        bool val_100;
        float val_101;
        var val_102;
        float val_106;
        float val_107;
        float val_108;
        UnityEngine.Object val_109;
        var val_110;
        FriendProfileView.万丂上丂丝下丘世专 val_1 = new FriendProfileView.万丂上丂丝下丘世专();
        if(val_1 != null)
        {
                val_88 = 丝三丄专丗丞丄丄丌;
            val_89 = val_1;
            .丝三丄专丗丞丄丄丌 = val_88;
            mem[1152921537296665528] = this;
            val_90 = this.isSeeLobbyEnable;
            val_91 = this.isSeeLobbyEnable;
        }
        else
        {
                val_89 = true;
            mem[16] = 丝三丄专丗丞丄丄丌;
            mem[24] = this;
            val_90 = this.isSeeLobbyEnable;
            val_91 = this.isSeeLobbyEnable;
            val_88 = mem[16];
        }
        
        if(((val_90 == true) ? 1 : 0) == ((val_88 == true) ? 1 : 0))
        {
                return;
        }
        
        mem2[0] = val_89;
        AmongUsButtonLobby.Instance.丕丕业七丙七丅丈丄();
        RedLightButtonInLobby.丑上丞不与丄丗丌一();
        val_92 = 1152921504848912384;
        val_91 = this.background;
        if(val_91 == 0)
        {
                return;
        }
        
        val_91 = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
        if((System.String.op_Inequality(a:  val_91, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        this.丙七业东丕下七丛丙();
        if(mem[16] != false)
        {
                this.丈上丅丗丙丘丞七丐 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void FriendProfileView::HandleBackSeeLobby()), 与且专丈不万东一万:  "FriendProfileView HandleBackSeeLobby");
            val_93 = null;
            val_93 = null;
            this.丘丁丘丐一丕丑丆丘 = gameObject.activeSelf;
            this.丌丛下丕万丆丏与与 = UnityEngine.LayerMask.LayerToName(layer:  this.东丗丏世丑与丌丒丄.gameObject.layer);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.background, 丏业丟一东丂东丘丛:  (mem[16] == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.allInterfacePanel, 丏业丟一东丂东丘丛:  (mem[16] == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.panelSeeLobby, 丏业丟一东丂东丘丛:  mem[16]);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerModelLightObj, 丏业丟一东丂东丘丛:  (mem[16] == false) ? 1 : 0);
        val_94 = null;
        val_94 = null;
        if(mem[16] != false)
        {
                val_95 = 1;
        }
        else
        {
                val_95 = this.丘丁丘丐一丕丑丆丘;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  (val_95 == true) ? 1 : 0);
        val_96 = null;
        val_96 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟.一丑丟世丛丌丁下不() != false)
        {
                if(mem[16] != false)
        {
                val_97 = null;
            val_97 = null;
            GetChild(index:  0).gameObject.SetActive(value:  (mem[16] == false) ? 1 : 0);
        }
        
            MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = (mem[16] == true) ? 1 : 0;
        }
        
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_98 = mem[16];
            if(val_98 != false)
        {
                Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.与丅丒丝七丛丑丅丞(与丝东万丙丞丝丟七:  this.丅下丕不丑丁三上丅, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  false);
            val_99 = null;
            val_99 = null;
            LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  (this.上丐丈专且三丑丁丑 == true) ? 1 : 0);
        }
        else
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != null)
        {
                val_100 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂();
        }
        else
        {
                val_100 = 0.上丙丆不丂丂丄一丂();
        }
        
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  val_100, 丒丞丐丘且不且丟东:  true);
            val_98 = 1152921524490355520;
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
        }
        
        }
        
        if((this.丁上丄与丑与丌与且 & 1) == 0)
        {
                UnityEngine.Vector3 val_42 = PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐().transform.position;
            this.丁上丄与丑与丌与且 = 0;
            mem[1152921537296633880] = 0;
            UnityEngine.Vector3 val_44 = this.东丗丏世丑与丌丒丄.transform.position;
            this.丗东丙丙世丒丑与丅 = 0;
            mem[1152921537296633896] = 0;
            UnityEngine.Vector3 val_48 = PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐().transform.localScale;
            this.丄丈且丕丈且丂七丄 = 0;
            mem[1152921537296633912] = 0;
            UnityEngine.Vector3 val_50 = this.东丗丏世丑与丌丒丄.transform.localScale;
            this.三丐丄东丌丌丑业与 = 0;
            mem[1152921537296633928] = 0;
        }
        
        UnityEngine.Transform val_53 = PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐().transform;
        UnityEngine.Vector3 val_54 = val_53.localPosition;
        if(mem[16] != false)
        {
            
        }
        
        val_101 = 0f;
        val_102 = 0f;
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_101, z = 0f});
        val_106 = val_55.x;
        val_107 = val_55.y;
        val_108 = val_55.z;
        val_53.localPosition = new UnityEngine.Vector3() {x = val_106, y = val_107, z = val_108};
        CharacterInterfaceV2 val_87 = PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐();
        UnityEngine.Object val_58 = val_87.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  13);
        if(val_58 != null)
        {
                val_87 = (null == null) ? (val_58) : 0;
        }
        else
        {
                val_109 = 0;
        }
        
        if(val_109 != 0)
        {
                UnityEngine.Transform val_60 = val_109.transform;
            UnityEngine.Vector3 val_61 = val_60.localPosition;
            if(mem[16] != false)
        {
            
        }
        
            val_101 = 0f;
            val_102 = 0f;
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_101, z = 0f});
            val_106 = val_62.x;
            val_107 = val_62.y;
            val_108 = val_62.z;
            val_60.localPosition = new UnityEngine.Vector3() {x = val_106, y = val_107, z = val_108};
        }
        
        UnityEngine.Transform val_63 = this.东丗丏世丑与丌丒丄.transform;
        if(mem[16] == false)
        {
            goto label_106;
        }
        
        if(val_63 != null)
        {
            goto label_140;
        }
        
        label_141:
        label_140:
        val_63.parent = PersConfigurator.下一丁七丅丕七万丑().丗丛丄丁丛丅与丘丐().transform.parent;
        val_92 = 1152921536988104224;
        var val_69 = (mem[16] == true) ? this.丁上丄与丑与丌与且 : this.丗东丙丙世丒丑与丅;
        this.东丗丏世丑与丌丒丄.transform.position = new UnityEngine.Vector3() {x = val_106, y = val_107, z = val_108};
        UnityEngine.Quaternion val_71 = UnityEngine.Quaternion.identity;
        this.东丗丏世丑与丌丒丄.transform.localRotation = new UnityEngine.Quaternion() {x = val_71.x, y = val_71.y, z = val_71.z, w = val_71.w};
        val_110 = null;
        val_110 = null;
        UnityEngine.Quaternion val_73 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = FriendProfileView.世丛丝丅丟与东丈丛, y = FriendProfileView.丐丕丝上丅丈丐丞专.__il2cppRuntimeField_C, z = FriendProfileView.丐丕丝上丅丈丐丞专.__il2cppRuntimeField_10});
        this.pers.transform.rotation = new UnityEngine.Quaternion() {x = val_73.x, y = val_73.y, z = val_73.z, w = val_73.w};
        UnityEngine.Vector3 val_76 = MainMenuController.七业丛与且丈丟东一();
        UnityEngine.Quaternion val_77 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z});
        PersConfigurator.下一丁七丅丕七万丑().transform.localRotation = new UnityEngine.Quaternion() {x = val_77.x, y = val_77.y, z = val_77.z, w = val_77.w};
        var val_79 = (mem[16] == true) ? this.丄丈且丕丈且丂七丄 : this.三丐丄东丌丌丑业与;
        this.东丗丏世丑与丌丒丄.transform.localScale = new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z};
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.东丗丏世丑与丌丒丄.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  (mem[16] == true) ? "Default" : this.丌丛下丕万丆丏与与), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_91 = Rilisoft.丛丅丘业丏丕下业丏.丂一丕丞一丑下丈世(三丛东丒三丝丅丌丁:  false);
        System.Action<UnityEngine.GameObject> val_84 = new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void FriendProfileView.万丂上丂丝下丘世专::丅丑丐不一丝丟万东(UnityEngine.GameObject 丄三丅七丆丛与与上));
        val_91.ForEach(action:  null);
        if(mem[16] == false)
        {
                return;
        }
        
        val_91 = this.playerNameSeeLobby;
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  val_91, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void FriendProfileView.万丂上丂丝下丘世专::专丐丈东丒丙丙且七(UILabel 丐三丞七丝丅不万丛)));
        this.上东世丕丏东丕丗不();
        return;
        label_106:
        if(val_63 != null)
        {
            goto label_140;
        }
        
        goto label_141;
    }
    private void 上东世丕丏东丕丗不()
    {
        System.Object[] val_20;
        var val_21;
        val_20 = this;
        if((System.String.op_Inequality(a:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        if(FriendsController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丘万世丂丅丐丂丛丌>k__BackingField)) != false)
        {
                val_20 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "UpdateLikes FriendId.IsNullOrEmpty()", args:  val_20);
            return;
        }
        
        string val_20 = this.<丘万世丂丅丐丂丛丌>k__BackingField;
        bool val_9 = 与与一丆专丕丄丆丗.丑七不且上丗丁一世().不一不下世丝丝丅丒().Contains(item:  val_20);
        val_20 = val_9;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dislikeContainer, 丏业丟一东丂东丘丛:  val_20);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.likeContainer, 丏业丟一东丂东丘丛:  (~val_9) & 1);
        string val_21 = this.<丘万世丂丅丐丂丛丌>k__BackingField;
        bool val_13 = (与与一丆专丕丄丆丗.丑七不且上丗丁一世().不专七丄专丝丂下上(丄丒且丙三丆丟与丏:  val_21)) ^ 1;
        val_21 = val_13;
        bool val_14 = val_13;
        this.likesCount.text = UnityEngine.Mathf.Max(a:  0, b:  (this.<丘丛东上丌丁丗不业>k__BackingField) + (this.<丌且丕专丗丙且丑丞>k__BackingField)).ToString();
        var val_18 = mem[this.likeLobby] & 1;
        val_20 = this.dislikeLobby;
        UIButton val_19 = val_20 & 1;
    }
    private void 丙七业东丕下七丛丙()
    {
        if(this.丈上丅丗丙丘丞七丐 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丈上丅丗丙丘丞七丐.Dispose();
        this.丈上丅丗丙丘丞七丐 = 0;
    }
    internal void 丏且不丛丌丗丟三丆()
    {
        var val_11;
        string val_12;
        string val_13;
        string val_14;
        if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
        {
            goto label_8;
        }
        
        丌丌丄丂丕丑专万丆 val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  this.<丘万世丂丅丐丂丛丌>k__BackingField);
        if(val_7 == 1)
        {
            goto label_8;
        }
        
        if(val_7 == 0)
        {
            goto label_9;
        }
        
        if(val_7 == 2)
        {
            goto label_10;
        }
        
        if(val_7 != 1)
        {
            goto label_11;
        }
        
        val_11 = "clan_leader_icon1";
        val_12 = "Key_5817";
        goto label_21;
        label_8:
        label_28:
        this.clanRoleLabel.gameObject.SetActive(value:  false);
        this.clanRoleSprite.gameObject.SetActive(value:  false);
        return;
        label_9:
        val_11 = "clan_fighter_icon";
        val_12 = "Key_5816";
        goto label_21;
        label_10:
        val_11 = "clan_officer_icon";
        val_12 = "Key_5815";
        label_21:
        val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_12);
        goto label_24;
        label_11:
        val_13 = "";
        val_14 = val_13;
        label_24:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanRoleLabel, 丕丗丘丑丛与丑业丒:  val_14);
        this.clanRoleSprite.spriteName = val_13;
        goto label_28;
    }
    private void 丞丞丈丏与丙丅不丕()
    {
        if(this.makeClanSoldierButton == null)
        {
            
        }
    
    }
    public System.Collections.IEnumerator WaitChangeRole(string 丁业世丅丌丛上下与, 七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 三丞丕上丞三丑丘丏, FriendProfileView.丑丙上一且不世一与 丏丅七丒一业七上不)
    {
        FriendProfileView.且丕丂七丘丙丒与丗 val_1 = new FriendProfileView.且丕丂七丘丙丒与丗(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丁业世丅丌丛上下与 = 丁业世丅丌丛上下与;
            .三丞丕上丞三丑丘丏 = 三丞丕上丞三丑丘丏;
        }
        else
        {
                mem[32] = this;
            mem[48] = 丁业世丅丌丛上下与;
            mem[56] = 三丞丕上丞三丑丘丏;
        }
        
        .丏丅七丒一业七上不 = 丏丅七丒一业七上不;
        return (System.Collections.IEnumerator)val_1;
    }
    public void Reset()
    {
        this.<丟丗丘丞丕世丑丒上>k__BackingField = false;
        this.<丌丝下上三丙且万东>k__BackingField = 0;
        this.<专丈且且丏丄丘丗丞>k__BackingField = System.String.alignConst;
        this.<丛丞三丈专不丗三丁>k__BackingField = System.String.alignConst;
        this.<业丕三丞丘一丒丙丈>k__BackingField = 0;
        this.<七丁丌且世丈丛丝丂>k__BackingField = 0;
        this.<丒丟与专万与丅丙万>k__BackingField = 0;
        this.<丞丈丝世丗丕丂东丞>k__BackingField = (((FriendsController.专丁丟丛丆万丟万丆(丄丒且丙三丆丟与丏:  this.<丘万世丂丅丐丂丛丌>k__BackingField)) & true) != 0) ? (4 + 1) : 4;
        this.<丟丈丅上三丆丝东丑>k__BackingField = System.String.alignConst;
        this.<丅丕丅三丈丄丐与丑>k__BackingField = 0;
        this.<且丑丏丗丟专丏东三>k__BackingField = 0;
        this.clanName.text = System.String.alignConst;
        this.clanRoleLabel.text = System.String.alignConst;
        this.clanRoleSprite.spriteName = "";
        this.friendCupsCount.text = System.String.alignConst;
        this.friendNameLabel.text = 0;
        this.rankSprite.spriteName = "";
        this.rankLable.text = "--";
        this.丏且不丛丌丗丟三丆();
        this.clanRank.丞不丒丑下丏万丁世(专世专丟丝丌与丘上:  0);
        if(this.characterModel != 0)
        {
                UnityEngine.Texture val_7 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.与丘丈丙丄与丁丅丟(), 丌丗丏丏丛东专丁且:  "multi_skin_1"));
            if(val_7 != 0)
        {
                this.东丗丏世丑与丌丒丄.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  val_7);
        }
        
        }
        
        this.丒丆七与丗丁且丄丝(丑丈丌业下丂下丑丘:  this.<丞丈丝世丗丕丂东丞>k__BackingField);
        this.东丗丏世丑与丌丒丄.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.东丗丏世丑与丌丒丄.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.东丗丏世丑与丌丒丄.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.东丗丏世丑与丌丒丄.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  System.String.alignConst);
        this.东丗丏世丑与丌丒丄.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  System.String.alignConst);
        this.SetEnableAddButton(丑丒业丘丑东丕世丅:  true);
        this.SetEnableInviteClanButton(丑丒业丘丑东丕世丅:  true);
    }
    public void SetBoots(string 丒丘丏上丙丟丑丕丈)
    {
        this.东丗丏世丑与丌丒丄.上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  丒丘丏上丙丟丑丕丈);
    }
    private void 丒丆七与丗丁且丄丝(Rilisoft.七下上丝三丛三上一 丑丈丌业下丂下丑丘)
    {
        var val_32;
        ClansWindowGUI val_33;
        var val_34;
        var val_35;
        var val_36;
        UIButton val_37;
        var val_39;
        FriendProfileView.丅七丑下世七上丌丝 val_1 = new FriendProfileView.丅七丑下世七上丌丝();
        if(val_1 != null)
        {
                .七丁丗丅且上与丘丆 = (丑丈丌业下丂下丑丘 == 4) ? 1 : 0;
            .丝丝丈丝丝丝丁不丁 = (丑丈丌业下丂下丑丘 == 2) ? 1 : 0;
        }
        else
        {
                mem[16] = (丑丈丌业下丂下丑丘 == 4) ? 1 : 0;
            .丝丝丈丝丝丝丁不丁 = (丑丈丌业下丂下丑丘 == 2) ? 1 : 0;
        }
        
        .丝与上丈丛丆丐丐东 = (丑丈丌业下丂下丑丘 == 0) ? 1 : 0;
        UILabel val_8 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UILabel>(丄三丅七丆丛与与上:  this.offlineStateLabel, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void FriendProfileView.丅七丑下世七上丌丝::三上不丈万专丁丙丑(UILabel 丐三丞七丝丅不万丛)));
        UILabel val_10 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UILabel>(丄三丅七丆丛与与上:  this.inFriendStateLabel, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void FriendProfileView.丅七丑下世七上丌丝::且丄丌丌万丄七丏丂(UILabel 丐三丞七丝丅不万丛)));
        UILabel val_12 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UILabel>(丄三丅七丆丛与与上:  this.playingStateLabel, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void FriendProfileView.丅七丑下世七上丌丝::上丈一丈七丕东万三(UILabel 丐三丞七丝丅不万丛)));
        UISprite val_14 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UISprite>(丄三丅七丆丛与与上:  this.offlineState, 七丐丅专且专七三丆:  new System.Action<UISprite>(object:  val_1, method:  System.Void FriendProfileView.丅七丑下世七上丌丝::不丄上丛上丅丘丝丒(UISprite 丐三丞七丝丅不万丛)));
        UISprite val_16 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UISprite>(丄三丅七丆丛与与上:  this.inFriendState, 七丐丅专且专七三丆:  new System.Action<UISprite>(object:  val_1, method:  System.Void FriendProfileView.丅七丑下世七上丌丝::丞丌丄不上丆丘东丑(UISprite 丐三丞七丝丅不万丛)));
        UISprite val_18 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UISprite>(丄三丅七丆丛与与上:  this.playingState, 七丐丅专且专七三丆:  new System.Action<UISprite>(object:  val_1, method:  System.Void FriendProfileView.丅七丑下世七上丌丝::丙丞丟上丒丕丛一丒(UISprite 丐三丞七丝丅不万丛)));
        if(this.playingStateInfoContainer == 0)
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        val_33 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_33 == 0)
        {
            goto label_14;
        }
        
        val_34 = null;
        val_34 = null;
        val_33 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
        if(val_33.InterfaceEnabled == false)
        {
            goto label_14;
        }
        
        val_33 = Rilisoft.Singleton<ClansController>.Instance;
        var val_24 = (val_33.丞丗丑丈一丅丗丌丟() != 0) ? 1 : 0;
        goto label_16;
        label_14:
        val_35 = 0;
        label_16:
        val_35 = val_35 & ((丑丈丌业下丂下丑丘 == 6) ? 1 : 0);
        if(val_35 == 0)
        {
            goto label_17;
        }
        
        val_36 = null;
        val_36 = null;
        val_33 = this.<丘万世丂丅丐丂丛丌>k__BackingField;
        if((FriendProfileView.丅七丑下世七上丌丝)[1152921537298581776].丝与上丈丛丆丐丐东 == true)
        {
            goto label_21;
        }
        
        val_33 = FriendsController.丄丞丁丈与业上丞丟.HaveSquadInviteFromPlayer(丞丅上丏丂且下丅与:  val_33);
        goto label_22;
        label_17:
        if((FriendProfileView.丅七丑下世七上丌丝)[1152921537298581776].丝与上丈丛丆丐丐东 == false)
        {
            goto label_23;
        }
        
        label_21:
        this.playingStateInfoContainer.SetActive(value:  true);
        label_40:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.joinButton.gameObject, 丏业丟一东丂东丘丛:  true);
        val_37 = this.joinSquadButton;
        UnityEngine.GameObject val_28 = val_37.gameObject;
        val_39 = 0;
        goto label_29;
        label_23:
        val_33 = 0;
        label_22:
        if(this.playingStateInfoContainer == null)
        {
            goto label_30;
        }
        
        if(val_33 == 0)
        {
            goto label_31;
        }
        
        label_36:
        this.playingStateInfoContainer.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.joinButton.gameObject, 丏业丟一东丂东丘丛:  false);
        val_37 = this.joinSquadButton;
        val_39 = 1;
        label_29:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_37.gameObject, 丏业丟一东丂东丘丛:  true);
        return;
        label_30:
        if(val_33 != 0)
        {
            goto label_36;
        }
        
        label_31:
        this.playingStateInfoContainer.SetActive(value:  false);
        UnityEngine.GameObject val_31 = this.joinButton.gameObject;
        goto label_40;
    }
    public void SetStockCape(string 世七丅世下丏丒丈丈)
    {
        if((System.String.IsNullOrEmpty(value:  世七丅世下丏丒丈丈)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Name of cape should not be empty.");
            return;
        }
        
        this.东丗丏世丑与丌丒丄.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  世七丅世下丏丒丈丈);
    }
    public void SetCustomCape(byte[] 丕专丝世一丗丙一七)
    {
        System.Byte[] val_4 = 丕专丝世一丗丙一七;
        if(val_4 == null)
        {
                byte[] val_1 = new byte[0];
            val_4 = val_1;
        }
        
        UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  12, height:  16, textureFormat:  5, mipChain:  false);
        bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  val_1, markNonReadable:  true);
        val_2.filterMode = 0;
        this.东丗丏世丑与丌丒丄.丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  "cape_Custom", 三丆业丘丑万丘世下:  val_2);
    }
    public void SetArmor(string 丈丗丛丕丟丑丑丞丘)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丈丗丛丕丟丑丑丞丘)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Name of armor should not be empty.");
            return;
        }
        
        this.东丗丏世丑与丌丒丄.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  丈丗丛丕丟丑丑丞丘);
    }
    public void SetHat(string 丛且丁且丛万丌丙丄)
    {
        if((System.String.IsNullOrEmpty(value:  丛且丁且丛万丌丙丄)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Name of hat should not be empty.");
            return;
        }
        
        this.东丗丏世丑与丌丒丄.丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  丛且丁且丛万丌丙丄);
    }
    public void SetMask(string 丄下丏丛丁丙不丙丌)
    {
        if((System.String.IsNullOrEmpty(value:  丄下丏丛丁丙不丙丌)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "Name of mask should not be empty.");
            return;
        }
        
        this.东丗丏世丑与丌丒丄.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  丄下丏丛丁丙不丙丌);
    }
    public void SetSkin(byte[] 丙上丕东三七丝丟万)
    {
        System.Byte[] val_9;
        var val_10;
        val_9 = 丙上丕东三七丝丟万;
        if(val_9 == null)
        {
                byte[] val_1 = new byte[0];
            val_9 = val_1;
        }
        
        if(this.characterModel == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if((FriendProfileView.<>c.<>9__230_0) == null)
        {
            goto label_7;
        }
        
        label_15:
        if(val_1.Length == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Texture2D val_4 = FriendProfileView.<>c.<>9__230_0.Invoke(arg:  val_1);
        goto label_11;
        label_7:
        FriendProfileView.<>c.<>9__230_0 = new System.Func<System.Byte[], UnityEngine.Texture2D>(object:  FriendProfileView.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Texture2D FriendProfileView.<>c::丝丈一丐丗丗丛丅东(byte[] 丝丆丁丞丛三丁丑丙));
        if(val_9 != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_9:
        label_11:
        this.东丗丏世丑与丌丒丄.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.与丘丈丙丄与丁丅丟(), 丌丗丏丏丛东专丁且:  "multi_skin_1")));
    }
    private void Awake()
    {
        UnityEngine.GameObject val_73;
        UnityEngine.GameObject val_74;
        int val_75;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "ConnectPanel");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_73 = 0;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_73);
        this.丗上丏丟丆专与丗丆 = val_3;
        val_3.transform.SetParent(parent:  this.allInterfacePanel.transform, worldPositionStays:  false);
        this.丗上丏丟丆专与丗丆.SetActive(value:  false);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丗上丏丟丆专与丗丆, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        this.connectionControl = this.丗上丏丟丆专与丗丆.AddComponent<ConnectionControl>();
        val_8.dontResetGameMode = true;
        this.connectionControl.SetConnectPanel(丛丘下丗业丂一且业:  this.丗上丏丟丆专与丗丆.GetComponent<ConnectPanel>());
        this.下下丙七丝丅丌丕丄();
        if((System.String.op_Inequality(a:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) != false)
        {
                if(this.seeLobby != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.seeLobby.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        UnityEngine.Object val_15 = UnityEngine.Resources.Load(path:  "Character_model_V2");
        if(val_15 != null)
        {
                var val_16 = (null == null) ? (val_15) : 0;
        }
        else
        {
                val_74 = 0;
        }
        
        CharacterInterfaceV2 val_18 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_74).GetComponent<CharacterInterfaceV2>();
        this.东丗丏世丑与丌丒丄 = val_18;
        val_18.transform.SetParent(parent:  this.pers, worldPositionStays:  false);
        this.东丗丏世丑与丌丒丄.丘丑东丁与丕丆业丛();
        val_75 = this.pers.gameObject.layer;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.东丗丏世丑与丌丒丄.gameObject, 不东丛三丂丌丑专丆:  val_75);
        Holoville.HOTween.HOTween.Init(p_permanentInstance:  true, p_renameInstanceToCountTweens:  true, p_allowOverwriteManager:  true);
        Holoville.HOTween.HOTween.EnableOverwriteManager(logWarnings:  true);
        this.Reset();
        if(this.backButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_24 = null;
            val_75 = val_24;
            val_24 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void FriendProfileView::OnBackButtonClick());
            EventDelegate val_25 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.backButton.onClick, 业丏丈世世世丞丒世:  val_24);
        }
        
        if(this.joinButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_27 = null;
            val_75 = val_27;
            val_27 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::下业丈东丏丄一丘丗());
            EventDelegate val_28 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.joinButton.onClick, 业丏丈世世世丞丒世:  val_27);
        }
        
        if(this.joinSquadButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_30 = null;
            val_75 = val_30;
            val_30 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::一专上丌且丈丏世丘());
            EventDelegate val_31 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.joinSquadButton.onClick, 业丏丈世世世丞丒世:  val_30);
        }
        
        if(this.levelRequiredButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_33 = null;
            val_75 = val_33;
            val_33 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丟丟丌专丗丏丅丟丗());
            EventDelegate val_34 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.levelRequiredButton.onClick, 业丏丈世世世丞丒世:  val_33);
        }
        
        if(this.clanButton != 0)
        {
                if((this.clanButton.GetComponent<UIButton>()) != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_38 = null;
            val_75 = val_38;
            val_38 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::且丟且上丌不业丆丄());
            EventDelegate val_39 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_36.onClick, 业丏丈世世世丞丒世:  val_38);
        }
        else
        {
                UnityEngine.Debug.Log(message:  "No Button on ClanLogo");
        }
        
        }
        
        if(this.sendMyIdButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_41 = null;
            val_75 = val_41;
            val_41 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::上七业丘七三丟七丗());
            EventDelegate val_42 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.sendMyIdButton.onClick, 业丏丈世世世丞丒世:  val_41);
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
                this.sendMyIdButton.gameObject.SetActive(value:  false);
        }
        
        }
        
        if(this.chatButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_46 = null;
            val_75 = val_46;
            val_46 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丕世上丘丝上七不丅());
            EventDelegate val_47 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.chatButton.onClick, 业丏丈世世世丞丒世:  val_46);
        }
        
        if(this.addFriendButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_49 = null;
            val_75 = val_49;
            val_49 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丄上丞丙丆万丈不丛());
            EventDelegate val_50 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.addFriendButton.onClick, 业丏丈世世世丞丒世:  val_49);
        }
        
        if(this.askOpenChestsButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_52 = null;
            val_75 = val_52;
            val_52 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丙丒专丞丘丛丙丈一());
            EventDelegate val_53 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.askOpenChestsButton.onClick, 业丏丈世世世丞丒世:  val_52);
        }
        
        if(this.makeClanLeaderButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_55 = null;
            val_75 = val_55;
            val_55 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丅三丁一万下丁业且());
            EventDelegate val_56 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.makeClanLeaderButton.onClick, 业丏丈世世世丞丒世:  val_55);
        }
        
        if(this.makeClanOfficerButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_58 = null;
            val_75 = val_58;
            val_58 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::一丈丗丈丙且不丆丘());
            EventDelegate val_59 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.makeClanOfficerButton.onClick, 业丏丈世世世丞丒世:  val_58);
        }
        
        if(this.makeClanSoldierButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_61 = null;
            val_75 = val_61;
            val_61 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丂丛与下丏一丙丕丏());
            EventDelegate val_62 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.makeClanSoldierButton.onClick, 业丏丈世世世丞丒世:  val_61);
        }
        
        if(this.removeFriendButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_64 = null;
            val_75 = val_64;
            val_64 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::不一丌丒丙丝丕丐专());
            EventDelegate val_65 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.removeFriendButton.onClick, 业丏丈世世世丞丒世:  val_64);
        }
        
        if(this.inviteToClanButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_67 = null;
            val_75 = val_67;
            val_67 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FriendProfileView::丝丈专丐与丅丘丟丏());
            EventDelegate val_68 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.inviteToClanButton.onClick, 业丏丈世世世丞丒世:  val_67);
        }
        
        if(this.removeFromClanButton != 0)
        {
                EventDelegate.丒万业丛丏东专世丟 val_70 = null;
            val_75 = val_70;
            val_70 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void FriendProfileView::OnRemoveFromClanButtonClick());
            EventDelegate val_71 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.removeFromClanButton.onClick, 业丏丈世世世丞丒世:  val_70);
        }
        
        与与一丆专丕丄丆丗.丙丘三一东丝万下丗(丙业与丙丗丝不丈东:  new System.Action<System.String, System.Boolean, System.Int32>(object:  this, method:  System.Void FriendProfileView::与下丆七丏与丘丅丟(string 丄丒且丙三丆丟与丏, bool 七世下丐丑东专世丕, int 丝丑丏上丑业丞万七)));
    }
    private void 与下丆七丏与丘丅丟(string 丄丒且丙三丆丟与丏, bool 七世下丐丑东专世丕, int 丝丑丏上丑业丞万七)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丘万世丂丅丐丂丛丌>k__BackingField)) != false)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "FriendsController_OnSendLikeLobby friend id is null or empty", args:  System.Array.Empty<System.Object>());
            return;
        }
        
        if((System.String.op_Inequality(a:  this.<丘万世丂丅丐丂丛丌>k__BackingField, b:  丄丒且丙三丆丟与丏)) == true)
        {
                return;
        }
        
        this.<丌且丕专丗丙且丑丞>k__BackingField = 丝丑丏上丑业丞万七;
    }
    private void OnDestroy()
    {
        与与一丆专丕丄丆丗.不业万专丝丟丘丙专(丙业与丙丗丝不丈东:  new System.Action<System.String, System.Boolean, System.Int32>(object:  this, method:  System.Void FriendProfileView::与下丆七丏与丘丅丟(string 丄丒且丙三丆丟与丏, bool 七世下丐丑东专世丕, int 丝丑丏上丑业丞万七)));
    }
    private void OnDisable()
    {
        var val_7;
        System.Action<System.Boolean> val_8;
        this.StopCoroutine(methodName:  "RequestUpdate");
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        if(this.connectingPanel != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectingPanel, 丏业丟一东丂东丘丛:  false);
        }
        
        if((System.String.op_Equality(a:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) != false)
        {
                this.与七三丟丝三丙丌万.Clear();
        }
        
        if(this.七三丏下上丑丘丑丙 != null)
        {
                this.七三丏下上丑丘丑丙.Invoke();
        }
        
        val_7 = null;
        val_7 = null;
        val_8 = FriendProfileView.七丏七丌丝丄业丌不;
        if(val_8 != null)
        {
                val_8 = FriendProfileView.七丏七丌丝丄业丌不;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
            val_8.Invoke(obj:  false);
            val_7 = null;
        }
        
        val_7 = null;
        FriendProfileView.丐丕丝上丅丈丐丞专 = 0;
        this.丞丞丈丏与丙丅不丕();
    }
    private void OnEnable()
    {
        var val_12;
        var val_14;
        System.Action<System.Boolean> val_15;
        val_12 = null;
        val_12 = null;
        FriendProfileView.丐丕丝上丅丈丐丞专 = this;
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "RequestUpdate");
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_2 = val_2 + 1000000f;
        this.东世七上东丐丁丑东 = val_2;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void FriendProfileView::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Friend Profile");
        if((System.String.op_Equality(a:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) != false)
        {
                this.与七三丟丝三丙丌万.Clear();
        }
        
        if(this.connectingPanel != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectingPanel, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丅下丕不丑丁三上丅 = new System.Collections.Generic.List<System.String>();
        this.UpdateSeeLobbyButton();
        val_14 = null;
        val_14 = null;
        val_15 = FriendProfileView.七丏七丌丝丄业丌不;
        if(val_15 == null)
        {
                return;
        }
        
        val_15 = FriendProfileView.七丏七丌丝丄业丌不;
        if(val_15 == null)
        {
                val_15 = 0;
        }
        
        val_15.Invoke(obj:  true);
    }
    private System.Collections.IEnumerator 丆丒丈丑业丅丝丘七()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FriendProfileView.丛丘世万业专丌下东(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        if(InfoWindowController.丈丐丞丐上丑且丕万() == true)
        {
                return;
        }
        
        this.丆丐丕丈业丛丆丐业 = true;
    }
    public void SetLevelRequiredLabel(string 丄丙下丝丛丒七丂丘)
    {
        this.levelRequiredButton.GetComponent<UILabel>().text = 丄丙下丝丛丒七丂丘;
    }
    public void OnBackButtonClick()
    {
        if(this.丒不丁业丒不丌下且 == null)
        {
                return;
        }
        
        this.丗三丒上万丅业一丒(丝三丄专丗丞丄丄丌:  false);
        this.丒不丁业丒不丌下且.Invoke();
    }
    private void 丟丟丌专丗丏丅丟丗()
    {
        if(this.丏世丌丂丒丁丏专丗 == null)
        {
                return;
        }
        
        this.丏世丌丂丒丁丏专丗.Invoke();
    }
    private void 且丟且上丌不业丆丄()
    {
        if(this.不七丆丄上丈丙丗丁 == null)
        {
                return;
        }
        
        this.丗三丒上万丅业一丒(丝三丄专丗丞丄丄丌:  false);
        this.不七丆丄上丈丙丗丁.Invoke();
    }
    private void 下业丈东丏丄一丘丗()
    {
        if(this.与丗且丒丐丏不丐丝 == null)
        {
                return;
        }
        
        this.与丗且丒丐丏不丐丝.Invoke();
    }
    private void 一专上丌且丈丏世丘()
    {
        if(this.东丐丐且丛丟丅丞丘 == null)
        {
                return;
        }
        
        this.东丐丐且丛丟丅丞丘.Invoke();
    }
    private void 上七业丘七三丟七丗()
    {
        if(this.丝七丘丌丂丑丌丁丁 == null)
        {
                return;
        }
        
        this.丝七丘丌丂丑丌丁丁.Invoke();
    }
    private void 丕世上丘丝上七不丅()
    {
        if(this.下万不丂丗丅不丞丌 == null)
        {
                return;
        }
        
        this.下万不丂丗丅不丞丌.Invoke();
    }
    private void 丄上丞丙丆万丈不丛()
    {
        if(this.丐丏专上一丈丁丈丅 == null)
        {
                return;
        }
        
        this.丐丏专上一丈丁丈丅.Invoke();
    }
    private void 丙丒专丞丘丛丙丈一()
    {
        if(this.三丈丞丘世下丏与丟 == null)
        {
                return;
        }
        
        this.三丈丞丘世下丏与丟.Invoke();
    }
    private void 丅三丁一万下丁业且()
    {
        if(this.东丆一丛万丑东丞丘 == null)
        {
                return;
        }
        
        this.东丆一丛万丑东丞丘.Invoke();
    }
    private void 一丈丗丈丙且不丆丘()
    {
        if(this.丘丝不丈丟丈丐丙万 == null)
        {
                return;
        }
        
        this.丘丝不丈丟丈丐丙万.Invoke();
    }
    private void 丂丛与下丏一丙丕丏()
    {
        if(this.上丗专丂丐下丙丕丈 == null)
        {
                return;
        }
        
        this.上丗专丂丐下丙丕丈.Invoke();
    }
    private void 不一丌丒丙丝丕丐专()
    {
        if(this.丙丝业万三丌丏丆丐 == null)
        {
                return;
        }
        
        this.丙丝业万三丌丏丆丐.Invoke();
    }
    private void 丝丈专丐与丅丘丟丏()
    {
        if(this.丕万与丂一世上万专 == null)
        {
                return;
        }
        
        this.丕万与丂一世上万专.Invoke();
    }
    public void OnRemoveFromClanButtonClick()
    {
        if(this.丅且上丅丌且专下丙 == null)
        {
                return;
        }
        
        this.丅且上丅丌且专下丙.Invoke();
    }
    private System.Collections.IEnumerator RequestUpdate()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FriendProfileView.万专一丄丅丐世且丗(丗丏丅丕丆世丁专丟:  0);
    }
    private void 下下丙七丝丅丌丕丄()
    {
        if((System.String.op_Equality(a:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), b:  "Clans")) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.removeFriendButton.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        var val_12;
        var val_13;
        var val_14;
        float val_15;
        var val_16;
        if(this.丆丐丕丈业丛丆丐业 != false)
        {
                this.丆丐丕丈业丛丆丐业 = false;
            this.OnBackButtonClick();
            return;
        }
        
        this.且上丏下丞丌一丈与();
        UnityEngine.Rect val_2 = this.丕丅丅一丝丅丛丝与.世三丞丅丑丌丈丈一();
        if((this.panelSeeLobby != 0) && (this.panelSeeLobby.activeSelf != false))
        {
                val_12 = null;
            val_12 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_13 = null;
            val_13 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy != true)
        {
                val_14 = null;
            val_14 = null;
            MainMenuController.丄丞丁丈与业上丞丟.丒丌丄丛丟丏丒世丄(丝丛业丑专业一丁上:  0);
        }
        
        }
        
            this.上东世丕丏东丕丗不();
            val_15 = this.东世七上东丐丁丑东;
        }
        else
        {
                val_15 = this.东世七上东丐丁丑东;
            RilisoftRotator.丒丌丄丛丟丏丒世丄(世丟丈丏丕万丝丆万:  this.pers, 丄七丛丝丏丈丒丝业:  RilisoftRotator.丙丂专一丄丞丛业上(), 丕丏丘七丗丘万丟丛:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, 丑丗丘丞丗丌三丈丆: ref  val_15, 三丕丂且一丝丈三一: ref  this.东丌丆一专与丝丕丝, 丝丛业丑专业一丁上:  0);
        }
        
        val_16 = null;
        val_16 = null;
        if((UnityEngine.Time.realtimeSinceStartup - val_15) > ShopNGUIController.上丈丂丁三丂业丛丝)
        {
                this.丘不专丘上丘丟丟丆();
        }
        
        this.下下丙七丝丅丌丕丄();
        this.UpdateSeeLobbyButton();
    }
    public void UpdateSeeLobbyButton()
    {
        var val_19;
        var val_20;
        bool val_21;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丘万世丂丅丐丂丛丌>k__BackingField)) != false)
        {
                val_19 = 0;
        }
        else
        {
                val_19 = System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  this.<丘万世丂丅丐丂丛丌>k__BackingField);
        }
        
        if(this.seeLobby == 0)
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.seeLobby.gameObject, 丏业丟一东丂东丘丛:  (val_19 == false) ? 1 : 0);
        if((this.丅下丕不丑丁三上丅 == null) || (this.丅下丕不丑丁三上丅.Count < 1))
        {
            goto label_12;
        }
        
        var val_8 = (val_19 == false) ? 1 : 0;
        if(this.seeLobby != null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_12:
        if(val_19 == false)
        {
            goto label_15;
        }
        
        val_20 = 0;
        if(this.seeLobby != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        label_7:
        if(this.seeLobby == 0)
        {
                return;
        }
        
        if(this.totalWinCountLabel == 0)
        {
                return;
        }
        
        if(this.connectingPanel == 0)
        {
                return;
        }
        
        if(((this.totalWinCountLabel.text.Equals(value:  "-")) == true) || (this.seeLobby.gameObject.activeInHierarchy == false))
        {
            goto label_31;
        }
        
        val_21 = 0;
        goto label_32;
        label_15:
        var val_16 = (this.上丐丈专且三丑丁丑 == true) ? 1 : 0;
        if(this.seeLobby != null)
        {
            goto label_33;
        }
        
        goto label_34;
        label_31:
        val_21 = val_19 ^ 1;
        label_32:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectingPanel, 丏业丟一东丂东丘丛:  val_21);
    }
    private void 丘不专丘上丘丟丟丆()
    {
        var val_9;
        int val_1 = Holoville.HOTween.HOTween.Kill(p_target:  this.pers);
        float val_9 = this.东世七上东丐丁丑东;
        val_9 = val_9 + 1000000f;
        this.东世七上东丐丁丑东 = val_9;
        val_9 = null;
        val_9 = null;
        Holoville.HOTween.Tweener val_8 = Holoville.HOTween.HOTween.To(p_target:  this.pers, p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Vector3() {x = FriendProfileView.世丛丝丅丟与东丈丛, y = FriendProfileView.丐丕丝上丅丈丐丞专.__il2cppRuntimeField_C, z = FriendProfileView.丐丕丝上丅丈丐丞专.__il2cppRuntimeField_10})).Ease(p_easeType:  0).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void FriendProfileView::业丁丈丘丑丅丑七丗())));
    }
    private void 且上丏下丞丌一丈与()
    {
        string val_31;
        string val_32;
        string val_33;
        var val_34;
        UnityEngine.GameObject val_35;
        val_31 = this;
        if(this.friendLocationLabel == 0)
        {
            goto label_3;
        }
        
        val_32 = this.<专丈且且丏丄丘丗丞>k__BackingField;
        if(val_32 == null)
        {
            goto label_4;
        }
        
        label_36:
        this.friendLocationLabel.text = val_32;
        label_3:
        if(this.friendCountLabel == 0)
        {
            goto label_8;
        }
        
        if(((this.<丌丝下上三丙且万东>k__BackingField) & 2147483648) != 0)
        {
            goto label_9;
        }
        
        val_32 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丌丝下上三丙且万东>k__BackingField);
        if(this.friendCountLabel != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        this.friendCountLabel.text = val_32;
        label_8:
        if(this.friendNameLabel == 0)
        {
            goto label_15;
        }
        
        val_32 = this.<丛丞三丈专不丗三丁>k__BackingField;
        if(val_32 == null)
        {
            goto label_16;
        }
        
        label_40:
        this.friendNameLabel.text = val_32;
        label_15:
        this.丒丆七与丗丁且丄丝(丑丈丌业下丂下丑丘:  this.<丞丈丝世丗丕丂东丞>k__BackingField);
        this.notConnectJoinButtonSprite.alpha = ((this.<丟丗丘丞丕世丑丒上>k__BackingField) == true) ? 0f : 1f;
        if(this.rankSprite != 0)
        {
                string val_7 = "Rank_" + this.<业丕三丞丘一丒丙丈>k__BackingField(this.<业丕三丞丘一丒丙丈>k__BackingField);
            val_32 = this.rankSprite.spriteName;
            if((val_32.Equals(value:  val_7)) != true)
        {
                val_32 = this.rankSprite;
            val_32.spriteName = val_7;
        }
        
        }
        
        if(this.rankLable == 0)
        {
            goto label_31;
        }
        
        val_32 = this.<业丕三丞丘一丒丙丈>k__BackingField.ToString();
        if((this.rankLable.text.Equals(value:  val_32)) == true)
        {
            goto label_31;
        }
        
        if((this.<业丕三丞丘一丒丙丈>k__BackingField) == 1)
        {
            goto label_32;
        }
        
        val_32 = this.<业丕三丞丘一丒丙丈>k__BackingField.ToString();
        val_33 = val_32;
        goto label_34;
        label_4:
        if(this.friendLocationLabel != null)
        {
            goto label_36;
        }
        
        goto label_36;
        label_9:
        if(this.friendCountLabel != null)
        {
            goto label_37;
        }
        
        goto label_38;
        label_16:
        if(this.friendNameLabel != null)
        {
            goto label_40;
        }
        
        goto label_40;
        label_32:
        val_33 = "--";
        label_34:
        this.rankLable.text = val_33;
        label_31:
        if(this.friendCupsCount == 0)
        {
            goto label_44;
        }
        
        if(((this.<丅丐上且且丆丞不丅>k__BackingField) & 2147483648) != 0)
        {
            goto label_45;
        }
        
        val_32 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅丐上且且丆丞不丅>k__BackingField);
        if(this.friendCupsCount != null)
        {
            goto label_68;
        }
        
        label_69:
        label_68:
        this.friendCupsCount.text = val_32;
        label_44:
        if(this.survivalScoreLabel == 0)
        {
            goto label_51;
        }
        
        if(((this.<丒丟与专万与丅丙万>k__BackingField) & 2147483648) != 0)
        {
            goto label_52;
        }
        
        val_32 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丒丟与专万与丅丙万>k__BackingField);
        if(this.survivalScoreLabel != null)
        {
            goto label_70;
        }
        
        label_71:
        label_70:
        this.survivalScoreLabel.text = val_32;
        label_51:
        if(this.CupSprite == 0)
        {
            goto label_58;
        }
        
        int val_31 = this.<七丁丌且世丈丛丝丂>k__BackingField;
        if((val_31 & 2147483648) != 0)
        {
            goto label_59;
        }
        
        val_31 = val_31 + 1;
        string val_20 = System.String.Format(format:  "cup{0}_1", arg0:  val_31);
        val_32 = this.CupSprite.spriteName;
        if((val_32.Equals(value:  val_20)) != true)
        {
                val_32 = this.CupSprite;
            val_32.spriteName = val_20;
        }
        
        val_34 = 1;
        val_35 = this.CupSprite.gameObject;
        goto label_67;
        label_45:
        if(this.friendCupsCount != null)
        {
            goto label_68;
        }
        
        goto label_69;
        label_52:
        if(this.survivalScoreLabel != null)
        {
            goto label_70;
        }
        
        goto label_71;
        label_59:
        val_35 = this.CupSprite.gameObject;
        val_34 = 0;
        label_67:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  false);
        label_58:
        if(this.winCountLabel == 0)
        {
            goto label_77;
        }
        
        if(((this.<丅丕丅三丈丄丐与丑>k__BackingField) & 2147483648) != 0)
        {
            goto label_78;
        }
        
        val_32 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<丅丕丅三丈丄丐与丑>k__BackingField);
        if(this.winCountLabel != null)
        {
            goto label_97;
        }
        
        label_98:
        label_97:
        this.winCountLabel.text = val_32;
        label_77:
        if(this.totalWinCountLabel == 0)
        {
            goto label_84;
        }
        
        if(((this.<且丑丏丗丟专丏东三>k__BackingField) & 2147483648) != 0)
        {
            goto label_85;
        }
        
        val_32 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.<且丑丏丗丟专丏东三>k__BackingField);
        if(this.totalWinCountLabel != null)
        {
            goto label_99;
        }
        
        label_100:
        label_99:
        this.totalWinCountLabel.text = val_32;
        label_84:
        if(this.friendGameModeLabel != 0)
        {
                val_32 = this.<且丆上三丒上丐丞丒>k__BackingField;
            this.friendGameModeLabel.text = val_32;
        }
        
        if(this.friendIdLabel == 0)
        {
                return;
        }
        
        val_31 = this.<丘万世丂丅丐丂丛丌>k__BackingField;
        this.friendIdLabel.text = val_31;
        return;
        label_78:
        if(this.winCountLabel != null)
        {
            goto label_97;
        }
        
        goto label_98;
        label_85:
        if(this.totalWinCountLabel != null)
        {
            goto label_99;
        }
        
        goto label_100;
    }
    public void SetTitle(string 丞业丂且专丘丐丁下)
    {
        goto label_0;
        label_5:
        this.titlesLabel[0].text = 丞业丂且专丘丐丁下;
        0 = 1;
        label_0:
        if(0 < this.titlesLabel.Length)
        {
            goto label_5;
        }
    
    }
    private void 专丟专丅丞上且丐丆(UnityEngine.GameObject 丟丒丞丐丐丘丒丄东, bool 东丅丞丁丗万且丁丗)
    {
        var val_5;
        if(丟丒丞丐丐丘丒丄东 != null)
        {
                val_5 = 丟丒丞丐丐丘丒丄东.activeSelf;
        }
        else
        {
                val_5 = 0.activeSelf;
        }
        
        丟丒丞丐丐丘丒丄东.SetActive(value:  东丅丞丁丗万且丁丗);
        if(val_5 ^ 东丅丞丁丗万且丁丗 == false)
        {
                return;
        }
        
        this.buttonAlignContainer.repositionNow = true;
    }
    public void SetActiveChatButton(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.chatButton.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveInviteButton(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.inviteToClanButton.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveAddButton(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.addFriendButton.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveAddButtonSent(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.addFrienButtonSentState.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveAddClanButtonSent(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.addClanButtonSentState.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveRemoveFromClanButton(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.removeFromClanButton.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveRemoveButton(bool 东丅丞丁丗万且丁丗)
    {
        this.专丟专丅丞上且丐丆(丟丒丞丐丐丘丒丄东:  this.removeFriendButton.gameObject, 东丅丞丁丗万且丁丗:  东丅丞丁丗万且丁丗);
    }
    public void SetActiveAskOpenChestsButton(bool 东丅丞丁丗万且丁丗, bool 丝三丄专丗丞丄丄丌)
    {
        if(this.askedOpenChestsButton == 0)
        {
                return;
        }
        
        if(this.askOpenChestsButton == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.askedOpenChestsButton.gameObject, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌 ^ 1 & 东丅丞丁丗万且丁丗);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.askOpenChestsButton.gameObject, 丏业丟一东丂东丘丛:  东丅丞丁丗万且丁丗 & 丝三丄专丗丞丄丄丌);
    }
    public void SetActiveChangeClanRoleButton(UIButton 丟丒丞丐丐丘丒丄东, bool 东丅丞丁丗万且丁丗, bool 丝三丄专丗丞丄丄丌)
    {
        if(丟丒丞丐丐丘丒丄东 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丟丒丞丐丐丘丒丄东.gameObject, 丏业丟一东丂东丘丛:  东丅丞丁丗万且丁丗);
        bool val_4 = 丝三丄专丗丞丄丄丌;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void SetEnableAddButton(bool 丑丒业丘丑东丕世丅)
    {
        bool val_8 = 丑丒业丘丑东丕世丅;
        if(this.addFriendButton == 0)
        {
                return;
        }
        
        bool val_2 = val_8;
        val_8 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void SetEnableRemoveButton(bool 丑丒业丘丑东丕世丅)
    {
        bool val_8 = 丑丒业丘丑东丕世丅;
        if(this.removeFriendButton == 0)
        {
                return;
        }
        
        bool val_2 = val_8;
        val_8 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void SetEnableInviteClanButton(bool 丑丒业丘丑东丕世丅)
    {
        bool val_8 = 丑丒业丘丑东丕世丅;
        if(this.inviteToClanButton == 0)
        {
                return;
        }
        
        bool val_2 = val_8;
        val_8 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public void SetEnableRemoveFromClanButton(bool 丑丒业丘丑东丕世丅)
    {
        bool val_8 = 丑丒业丘丑东丕世丅;
        if(this.removeFromClanButton == 0)
        {
                return;
        }
        
        bool val_2 = val_8;
        val_8 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public FriendProfileView()
    {
        var val_5;
        System.Func<UnityEngine.Rect> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = FriendProfileView.<>c.<>9__275_0;
        if(val_7 == null)
        {
                System.Func<UnityEngine.Rect> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<UnityEngine.Rect>(object:  FriendProfileView.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Rect FriendProfileView.<>c::专一丘万丐丏一丌丏());
            FriendProfileView.<>c.<>9__275_0 = val_7;
        }
        
        this.丕丅丅一丝丅丛丝与 = new Rilisoft.七丞丞丅东丞专丙丝<UnityEngine.Rect>(丙丂丌且丌世丒丐三:  val_1);
        this.丅下丕不丑丁三上丅 = new System.Collections.Generic.List<System.String>();
        this.与七三丟丝三丙丌万 = new System.Collections.Generic.List<System.Object>();
    }
    private static FriendProfileView()
    {
        FriendProfileView.世丛丝丅丟与东丈丛 = 0;
        FriendProfileView.丐丕丝上丅丈丐丞专.__il2cppRuntimeField_10 = 0;
    }
    private void 业丁丈丘丑丅丑七丗()
    {
        float val_1 = this.东世七上东丐丁丑东;
        val_1 = val_1 + 1000000f;
        this.东世七上东丐丁丑东 = val_1;
    }

}
