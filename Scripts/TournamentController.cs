using UnityEngine;
public sealed class TournamentController : Singleton<TournamentController>
{
    // Fields
    internal const string 专丐丟丗丆丅丆与丘 = "DivisionsTournament.LeaderboardCacheKey_v3";
    internal const string 丏丙丐与丘丝七丑且 = "DivisionsTournament.LastPhaseKey_v3";
    internal const string 丌七丗丞丆丒一丏丐 = "DivisionsTournament.SettingsConfigKey_v3";
    internal const string 丒丅丄丆丌丗丘且下 = "DivisionsTournament.LastViewedLeagueAndPlaceInitializedKey_v3";
    internal const string 丛世丛丒丅丗丝丄万 = "DivisionsTournament.LastViewedPlaceKey_v3";
    internal const string 丂丁七丗丄万丗丕丆 = "DivisionsTournament.LastViewedLeagueKey_v3";
    private const string 丘丛丗丗且与丕一丞 = "key_lastTournamentSeason_ended_v3";
    internal const string 丌丗且丐丛不丛上丂 = "key_tournament_lastValidLeaderboard_v3";
    private string 世上丅丄丄七三丟丝;
    private UnityEngine.Coroutine 万丘业丞丙丌丒丆丌;
    private TournamentReward 丐丑专三丐丞业丂丝;
    private PGCompany.东丟东且丅与丞丌万 丁三丕七丟万丈丂丏;
    private static Rilisoft.且丈丞一丞丟与上七 万与世一东丆丙丙一;
    private static Rilisoft.且丈丞一丞丟与上七 丄丄东丈丐上丟丂丑;
    private static Rilisoft.且丈丞一丞丟与上七 丙丘丕丙丑专丗丈丛;
    private UnityEngine.Coroutine 七上且丈七丄丈上世;
    private int 丞下丒丄上丅世下丌;
    private bool 丂东万丏丒丑七且丄;
    private static bool 丙丐丄丛东七丑万丙;
    private TournamentController.且丛丈丒万与丁丟丟 丌丘丕丟丄丙丛丕丄;
    private int <世万三丅上不且丞世>k__BackingField;
    private int <丐丂丕业丌丞万丁东>k__BackingField;
    internal long 丝丌业丕丈一业丟三;
    private static int <丌下且丆一丑且丈丒>k__BackingField;
    private TournamentLeaderboard <上丄丆丗丂丞万上丌>k__BackingField;
    private static System.Action 丗丗丒丁下且丘且丒;
    private static System.Action 下世丄三且七东丅丞;
    private static System.Action 丛丝丆丝丏七丗下丄;
    private static System.Action<TournamentReward> 丞丏世上世丙丄三丄;
    private PGCompany.丌七丒万丝丄东且七 丈丕丝丄丗一七丞丑;
    private TournamentController.七丗三上丗下丄三丛 <一东丌丁下东专丄上>k__BackingField;
    
    // Properties
    internal static bool 丂丄上丈丝上丏万世 { get; }
    internal static bool 丞丌丕且丈丙业三丁 { get; }
    internal static bool 丘丕丄与丈七与下三 { get; set; }
    internal TournamentController.且丛丈丒万与丁丟丟 世丄丘丂且丌丑与不 { get; set; }
    internal string 且丐丐丁丐丒丌丗丙 { get; set; }
    internal int 东万丌万世丕一丆丆 { get; set; }
    internal int 丂丞万丄丌丙丐丁东 { get; set; }
    internal int 丙专丝丌丌下上下丝 { get; }
    internal Rilisoft.丝丑丂丛万丐丈丘且 丟丁东世三丆丛丞丂 { get; }
    internal int 世丗与丒世丏丙丙丑 { get; }
    internal static int 不丕丆上业丗丈七丂 { get; set; }
    internal TournamentLeaderboard 丙丙丆万丐万丕丞丙 { get; set; }
    internal TournamentReward 专业丞丙丁下丟丈且 { get; }
    internal bool 下东丆丁下上丙丘丐 { get; }
    internal static bool 丘世丑东丈丘丛业世 { get; set; }
    internal static int 一与业一丗丅丂丙三 { get; set; }
    internal static int 丅业丟一丑丒与丗丈 { get; set; }
    internal PGCompany.丌七丒万丝丄东且七 丌七丒万丝丄东且七 { get; }
    internal TournamentController.七丗三上丗下丄三丛 丆丅丌丑一丆万丂万 { get; set; }
    
    // Methods
    internal static bool 七东丕丌且丟丙丈下()
    {
        null = null;
        return (bool)ABTestController.丝与丆丞东丘丈东丘;
    }
    internal static bool 丅丑万丛丟与丆丘丈()
    {
        return TournamentController.丏一东丏与丙且丅丄();
    }
    internal static bool 丌万丘丙万世丗丈丏()
    {
        null = null;
        return (bool)TournamentController.丙丐丄丛东七丑万丙;
    }
    private static void 世丗与丛丅不丘丄丁(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentController.丙丐丄丛东七丑万丙 = 丙业与丙丗丝不丈东;
    }
    internal TournamentController.且丛丈丒万与丁丟丟 万与丛世丒丅下上丁()
    {
        return (且丛丈丒万与丁丟丟)this.丌丘丕丟丄丙丛丕丄;
    }
    private void 万世七三下丁丙与丈(TournamentController.且丛丈丒万与丁丟丟 丙业与丙丗丝不丈东)
    {
        this.丌丘丕丟丄丙丛丕丄 = 丙业与丙丗丝不丈东;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "DivisionsTournament.LastPhaseKey_v3", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal string 一且丌业东且丁丝丞()
    {
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) == null)
        {
                return (string)this.世上丅丄丄七三丟丝;
        }
        
        this.世上丅丄丄七三丟丝 = this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
        return (string)this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
    }
    private void 丆丆业丅一七东世东(string 丙业与丙丗丝不丈东)
    {
        if((System.String.op_Inequality(a:  this.世上丅丄丄七三丟丝, b:  丙业与丙丗丝不丈东)) != false)
        {
                TournamentController.世丗与丛丅不丘丄丁(丙业与丙丗丝不丈东:  false);
        }
        
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID = 丙业与丙丗丝不丈东;
        }
        
        this.世上丅丄丄七三丟丝 = 丙业与丙丗丝不丈东;
    }
    private void 一东上丏万万世世丑(string 一丑不东丒下丂丞丙)
    {
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID = 一丑不东丒下丂丞丙;
        }
        
        this.世上丅丄丄七三丟丝 = 一丑不东丒下丂丞丙;
        if((System.String.op_Inequality(a:  this.世上丅丄丄七三丟丝, b:  一丑不东丒下丂丞丙)) == false)
        {
                return;
        }
        
        this.丆丑丛丑一与丗丆业();
    }
    internal int 丂三下丒丒丁不上东()
    {
        return (int)this.<世万三丅上不且丞世>k__BackingField;
    }
    private void 东丝丈丟丅专七丕丏(int 丙业与丙丗丝不丈东)
    {
        this.<世万三丅上不且丞世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 下丙万万丕上丘专丞()
    {
        return (int)this.<丐丂丕业丌丞万丁东>k__BackingField;
    }
    private void 且与丝七丆丟丛一丑(int 丙业与丙丗丝不丈东)
    {
        this.<丐丂丕业丌丞万丁东>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丂与丐下一丟丆丌与()
    {
        var val_3;
        if(PixelTime.丒丙专丟世丟丌丁上() != false)
        {
                long val_2 = PixelTime.丙丅丅业丟丁世丁丗();
        }
        else
        {
                val_3 = 0;
        }
        
        val_3 = (this.<丐丂丕业丌丞万丁东>k__BackingField) - val_3;
        return (int)val_3;
    }
    internal Rilisoft.丝丑丂丛万丐丈丘且 丞丁下丛丒一丈丌丑()
    {
        if(this.丁三丕七丟万丈丂丏 == null)
        {
                return Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.丁三丕七丟万丈丂丏);
        }
        
        return this.丁三丕七丟万丈丂丏.丞丁下丛丒一丈丌丑();
    }
    internal int 下丐丕东七丞丅丙丝()
    {
        if(this.丌丘丕丟丄丙丛丕丄 != 1)
        {
                return 0;
        }
        
        return (int)this.丞下丒丄上丅世下丌;
    }
    internal static int 丝丘丙丙世丁丈丟世()
    {
        null = null;
        return (int)TournamentController.<丌下且丆一丑且丈丒>k__BackingField;
    }
    private static void 丄丙丗丙专且丏丗丁(int 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentController.<丌下且丆一丑且丈丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal TournamentLeaderboard 丕丑与丏丌丝下上丛()
    {
        return (TournamentLeaderboard)this.<上丄丆丗丂丞万上丌>k__BackingField;
    }
    private void 丄万三丑万丞丏下一(TournamentLeaderboard 丙业与丙丗丝不丈东)
    {
        this.<上丄丆丗丂丞万上丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal TournamentReward 丄万丐丑丌三丆丝丑()
    {
        return (TournamentReward)this.丐丑专三丐丞业丂丝;
    }
    internal bool 丁业世丄专一丁专丙()
    {
        return (bool)(this.丐丑专三丐丞业丂丝 != 0) ? 1 : 0;
    }
    internal static bool 不专丟丁下丈丕丑三()
    {
        null = null;
        return (bool)(TournamentController.万与世一东丆丙丙一.世三丞丅丑丌丈丈一() != 0) ? 1 : 0;
    }
    private static void 丂丛丕丑丌上下一三(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentController.万与世一东丆丙丙一.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal static int 世丆丐且上丁丝丏丛()
    {
        null = null;
        if(TournamentController.丄丄东丈丐上丟丂丑 != null)
        {
                return TournamentController.丄丄东丈丐上丟丂丑.世三丞丅丑丌丈丈一();
        }
        
        return TournamentController.丄丄东丈丐上丟丂丑.世三丞丅丑丌丈丈一();
    }
    internal static void 丁丟丂七与丏丛丐丄(int 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentController.丄丄东丈丐上丟丂丑.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        TournamentController.丂丛丕丑丌上下一三(丙业与丙丗丝不丈东:  true);
    }
    internal static int 丅下丈丙丝丛业丘三()
    {
        null = null;
        if(TournamentController.丙丘丕丙丑专丗丈丛 != null)
        {
                return TournamentController.丙丘丕丙丑专丗丈丛.世三丞丅丑丌丈丈一();
        }
        
        return TournamentController.丙丘丕丙丑专丗丈丛.世三丞丅丑丌丈丈一();
    }
    internal static void 七丅三丏三丛专丅与(int 丙业与丙丗丝不丈东)
    {
        null = null;
        TournamentController.丙丘丕丙丑专丗丈丛.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        TournamentController.丂丛丕丑丌上下一三(丙业与丙丗丝不丈东:  true);
    }
    internal static void 业业三与丌下且与不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  TournamentController.丗丗丒丁下且丘且丒, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.丗丗丒丁下且丘且丒 != 1152921505274740768);
    
    }
    internal static void 丝东丁丁丌丄丅且丑(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  TournamentController.丗丗丒丁下且丘且丒, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.丗丗丒丁下且丘且丒 != 1152921505274740768);
    
    }
    internal static void 业一三丟丒丕丂丏丝(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  TournamentController.下世丄三且七东丅丞, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.下世丄三且七东丅丞 != 1152921505274740776);
    
    }
    internal static void 一丝世丛丈丙丂丈丆(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  TournamentController.下世丄三且七东丅丞, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.下世丄三且七东丅丞 != 1152921505274740776);
    
    }
    internal static void 丟下丂且且世丑世丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  TournamentController.丛丝丆丝丏七丗下丄, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.丛丝丆丝丏七丗下丄 != 1152921505274740784);
    
    }
    internal static void 丅丈丞丁丏专丈丕与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  TournamentController.丛丝丆丝丏七丗下丄, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.丛丝丆丝丏七丗下丄 != 1152921505274740784);
    
    }
    internal static void 七万丝世丐丅丘丁丝(System.Action<TournamentReward> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  TournamentController.丞丏世上世丙丄三丄, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.丞丏世上世丙丄三丄 != 1152921505274740792);
    
    }
    internal static void 丐丁丁业且丟丄一丑(System.Action<TournamentReward> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  TournamentController.丞丏世上世丙丄三丄, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(TournamentController.丞丏世上世丙丄三丄 != 1152921505274740792);
    
    }
    internal static void 下且与一万丙丗且丁()
    {
        且丛丈丒万与丁丟丟 val_10;
        string val_11;
        var val_12;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Tournament: Wipe.");
        }
        
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                TournamentController val_4 = Rilisoft.Singleton<TournamentController>.Instance;
            val_10 = val_4.丌丘丕丟丄丙丛丕丄;
        }
        else
        {
                val_10 = 0;
        }
        
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                UnityEngine.Object.Destroy(obj:  Rilisoft.Singleton<TournamentController>.Instance.gameObject);
        }
        
        if((val_10 & 4294967294) == 2)
        {
                val_11 = "DivisionsTournament.LastPhaseKey_v3";
            val_12 = val_10;
        }
        else
        {
                val_11 = "DivisionsTournament.LastPhaseKey_v3";
            val_12 = 0;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_11, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DivisionsTournament.LeaderboardCacheKey_v3", 下下丏一丙不丘丌丞:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DivisionsTournament.SettingsConfigKey_v3", 下下丏一丙不丘丌丞:  System.String.alignConst);
        TournamentController.丂丛丕丑丌上下一三(丙业与丙丗丝不丈东:  false);
        TournamentController.丁丟丂七与丏丛丐丄(丙业与丙丗丝不丈东:  0);
        TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  0);
        TournamentController val_10 = Rilisoft.Singleton<TournamentController>.Instance;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
    }
    internal static void Reset()
    {
        var val_6;
        UnityEngine.Debug.Log(message:  "Tournament: Reset.");
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                UnityEngine.Object.Destroy(obj:  Rilisoft.Singleton<TournamentController>.Instance.gameObject);
        }
        
        TournamentController val_5 = Rilisoft.Singleton<TournamentController>.Instance;
        val_6 = null;
        val_6 = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
    }
    internal void 丒且丙不一丒丏丆丂(TournamentReward 丗七丟丈三不丕一三)
    {
        var val_3;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丆丙丆丝世与丘万(上丗业丂丑三丏上丏:  TournamentController.丙丞丁一丑上万丏丆(丙丑七万丆万丆且丌:  丗七丟丈三不丕一三.newLeague), 丆丞下七丛上丐世丌:  丗七丟丈三不丕一三.newScores);
        val_3 = null;
        val_3 = null;
        FriendsController.丄丞丁丈与业上丞丟.SynchRatingTiers(上且丗一丏丏万丅丌:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    internal static RatingSystem.RatingLeague 丙丞丁一丑上万丏丆(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        if(RatingSystem.丒东丆丞七与丁东丒() > 丙丑七万丆万丆且丌)
        {
                return RatingSystem.丒东丆丞七与丁东丒();
        }
        
        if(RatingSystem.丒丐丁一丈丏丗丅东() >= 丙丑七万丆万丆且丌)
        {
                return (RatingLeague)丙丑七万丆万丆且丌;
        }
        
        return RatingSystem.丒丐丁一丈丏丗丅东();
    }
    private void 丆丛丌丁丛丂丞丘丌(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        if(RatingSystem.丒东丆丞七与丁东丒() > 丙丑七万丆万丆且丌)
        {
                RatingLeague val_4 = RatingSystem.丒东丆丞七与丁东丒();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丆丙丆丝世与丘万(上丗业丂丑三丏上丏:  RatingSystem.丒东丆丞七与丁东丒(), 丆丞下七丛上丐世丌:  0);
        }
        
        if(RatingSystem.丒丐丁一丈丏丗丅东() >= 丙丑七万丆万丆且丌)
        {
                return;
        }
        
        RatingLeague val_8 = RatingSystem.丒丐丁一丈丏丗丅东();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丆丙丆丝世与丘万(上丗业丂丑三丏上丏:  RatingSystem.丒丐丁一丈丏丗丅东(), 丆丞下七丛上丐世丌:  0);
    }
    protected override void Awake()
    {
        this.Awake();
        RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丑三一丛丈专丈专丛()));
        TournamentController.业一三丟丒丕丂丏丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::七丟丕一丕不上业丕()));
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丈与丄下且万丙丗丌()));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void TournamentController::丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::上与丐丏丕一世丒丄()));
        bool val_7 = AuthSceneController.一不丆丏与丐丏丈丄();
        if(val_7 != false)
        {
                val_7.上与丐丏丕一世丒丄();
        }
        
        业丞丝东丅丞丐丌专.专丁丂与丘丈丅不丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丛丒丅丄三万丐业丏()));
        Progress.七上上丟丗丏一不与.上且丏且七丒专丘丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::专不丁丁上丒三三丙()));
        Progress.七上上丟丗丏一不与.丂丐上丝丞丙万丟且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丘丘下丈丘丂下且三()));
        TournamentController.世丗与丛丅不丘丄丁(丙业与丙丗丝不丈东:  false);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Tournament: Start Initialize Coroutine");
        }
        
        this.七丕不丏丂丌世丑丏();
        this.丈丏一一世丂丒上下();
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.上丛丌丆丑上七世三());
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.丗一丘丝丐三七丅丈());
    }
    private System.Collections.IEnumerator 丗一丘丝丐三七丅丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TournamentController.丄丅丝丞丞丕丕与丏();
    }
    private void 丛丒丅丄三万丐业丏()
    {
        TournamentController.下且与一万丙丗且丁();
    }
    private void 丈与丄下且万丙丗丌()
    {
        this.东丙丗万下丌不下丏();
        this.七丕不丏丂丌世丑丏();
    }
    private void 不三东丒丟东不丝丘()
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Tournament: Updating on progress synch");
        }
        
        FriendsController.一丂丝丝丂丕丑丄与();
        if((this.<上丄丆丗丂丞万上丌>k__BackingField.league) == RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏())
        {
                TournamentController.Reset();
            return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Tournament: Player league was changed from progress");
        }
        
        TournamentController.下且与一万丙丗且丁();
    }
    private void 世一丐丘丏上业东专()
    {
        TournamentController.Reset();
    }
    private void OnDestroy()
    {
        if(this.七上且丈七丄丈上世 != null)
        {
                this.StopCoroutine(routine:  this.七上且丈七丄丈上世);
        }
        
        RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丑三一丛丈专丈专丛()));
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丈与丄下且万丙丗丌()));
        PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void TournamentController::丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        TournamentController.一丝世丛丈丙丂丈丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::七丟丕一丕不上业丕()));
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::不三东丒丟东不丝丘()));
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::上与丐丏丕一世丒丄()));
        AuthSceneController.丛丌上丐丘不且丙七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::世一丐丘丏上业东专()));
        业丞丝东丅丞丐丌专.七丙三业且与七专不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丛丒丅丄三万丐业丏()));
        Progress.七上上丟丗丏一不与.世上丗世且丆不业一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::专不丁丁上丒三三丙()));
        Progress.七上上丟丗丏一不与.且丘丝丈业且丗丑丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void TournamentController::丘丘下丈丘丂下且三()));
        this.丐丞不下不丈且丂丂();
    }
    private void 丘丘下丈丘丂下且三()
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "TournamentController: Is Disabled Progress.");
    }
    private void 专不丁丁上丒三三丙()
    {
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "TournamentController: Is Enabled Progress. Get Leaderboard...");
        }
        
        this.万业七专丈丘丁丑东();
    }
    internal static bool 丅业东万丌丕上丌丄()
    {
        var val_2 = null;
        if(TournamentController.七东丕丌且丟丙丈下() == false)
        {
                return false;
        }
        
        return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament");
    }
    internal void 七七丂东丌世且丈丈()
    {
        var val_3;
        if(this.丌丘丕丟丄丙丛丕丄 == 2)
        {
                return;
        }
        
        val_3 = null;
        if(TournamentController.七东丕丌且丟丙丈下() == false)
        {
                return;
        }
        
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.tournament")) == false)
        {
                return;
        }
        
        if(this.丐丑专三丐丞业丂丝 != null)
        {
                return;
        }
        
        this.丒丝业不专丏与丆丑();
    }
    private System.Collections.IEnumerator 上丛丌丆丑上七世三()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TournamentController.下一七世三三丏丈世(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 东丙丗万下丌不下丏()
    {
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_17;
        var val_18;
        var val_19;
        Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_20;
        var val_21;
        val_17 = this;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        val_18 = 1152921505122766848;
        if(RatingSystem.与一丅丝不丈业与丙() == 0)
        {
                return;
        }
        
        Rilisoft.Singleton<TournamentController>.Instance.世丂丒丐上丞丆丁丘();
        this.丝丌业丕丈一业丟三 = PixelTime.丝丗专上三不丄丑丑();
        val_19 = null;
        val_19 = null;
        Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_6 = null;
        val_20 = val_6;
        val_6 = new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void TournamentController::业丗丝丏三东丅万丐(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丆下丐东东丗丛丗丝, 七丐丅专且专七三丆:  val_6);
        if((this.<世万三丅上不且丞世>k__BackingField) != 0)
        {
                if(((this.<世万三丅上不且丞世>k__BackingField) - FriendsController.丝丗专上三不丄丑丑()) < 1)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_9 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_9.Add(key:  "leaderboard_id", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.id);
        val_18 = 1152921504622075904;
        val_9.Add(key:  "league", value:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        val_9.Add(key:  "lb_time", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.scoresTimestamp);
        val_9.Add(key:  "dt_time", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.dataTimestamp);
        val_9.Add(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑());
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_9.Add(key:  "test", value:  1);
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_14 = null;
        val_17 = val_14;
        val_14 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_14.set_Item(key:  "param", value:  val_9);
        val_21 = null;
        val_21 = null;
        val_20 = Rilisoft.WebSocket.业丛世业世不丄丐三.丆下丐东东丗丛丗丝;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_16 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  val_20, 一丐丗丁丞丆丅丟丄:  val_14);
    }
    internal void 万业七专丈丘丁丑东()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = this;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
                return;
        }
        
        if(RatingSystem.与一丅丝不丈业与丙() == 0)
        {
                return;
        }
        
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return;
        }
        
        val_16 = null;
        if((TournamentController.丅丑万丛丟与丆丘丈() != true) && (this.丂东万丏丒丑七且丄 != true))
        {
                if(FriendsController.丝丗专上三不丄丑丑() >= (this.<世万三丅上不且丞世>k__BackingField))
        {
                if(this.丐丑专三丐丞业丂丝 == null)
        {
            goto label_17;
        }
        
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
        return;
        label_17:
        this.丝丌业丕丈一业丟三 = FriendsController.丝丗专上三不丄丑丑();
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_8 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_8.Add(key:  "leaderboard_id", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.id);
        val_8.Add(key:  "league", value:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        val_8.Add(key:  "lb_time", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.scoresTimestamp);
        val_8.Add(key:  "dt_time", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.dataTimestamp);
        val_8.Add(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑());
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_8.Add(key:  "test", value:  1);
        }
        
        val_15 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_18 = null;
        val_18 = null;
        int val_14 = val_15.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丆下丐东东丗丛丗丝, 一丐丗丁丞丆丅丟丄:  val_8);
    }
    internal void 丞丕丙丁丞丏丞七一()
    {
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
                return;
        }
        
        long val_4 = this.丝丌业丕丈一业丟三;
        val_4 = FriendsController.丝丗专上三不丄丑丑() - val_4;
        if(val_4 < 30)
        {
                return;
        }
        
        if(this.丐丑专三丐丞业丂丝 != null)
        {
                return;
        }
        
        this.丝丌业丕丈一业丟三 = FriendsController.丝丗专上三不丄丑丑();
        this.万业七专丈丘丁丑东();
    }
    private System.Collections.IEnumerator 丞丅丘丈丏丏丆丄一()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TournamentController.丈上丆三世三丅下丛(丗丏丅丕丆世丁专丟:  0);
    }
    private void 世丂丒丐上丞丆丁丘()
    {
        var val_6;
        var val_7;
        if(this.七上且丈七丄丈上世 != null)
        {
                this.StopCoroutine(routine:  this.七上且丈七丄丈上世);
        }
        
        val_6 = null;
        if(TournamentController.丅丑万丛丟与丆丘丈() == true)
        {
                return;
        }
        
        if(this.丂东万丏丒丑七且丄 == true)
        {
                return;
        }
        
        System.Random val_2 = new System.Random();
        int val_6 = this.<世万三丅上不且丞世>k__BackingField;
        val_6 = val_6 - FriendsController.丝丗专上三不丄丑丑();
        val_7 = val_2;
        if(val_6 <= 351)
        {
                val_7 = val_2;
        }
        
        this.七上且丈七丄丈上世 = this.StartCoroutine(routine:  this.下丂业三丁丗万上丐(丕丂丈丆丑丄七七丕:  394105456));
    }
    internal void 丁丄丐东上丄丘丙丞()
    {
        if(this.七上且丈七丄丈上世 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.七上且丈七丄丈上世);
    }
    private System.Collections.IEnumerator 下丂业三丁丗万上丐(int 丕丂丈丆丑丄七七丕)
    {
        TournamentController.三七三丕丘世下且东 val_1 = new TournamentController.三七三丕丘世下且东(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丕丂丈丆丑丄七七丕 = 丕丂丈丆丑丄七七丕;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 七丕不丏丂丌世丑丏()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TournamentController::专上不丙专丞丄三丄(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    internal static void 三丘与丈丒世丒与一()
    {
        var val_7;
        if((Rilisoft.Singleton<TournamentController>.Instance) != 0)
        {
                if(val_3.七上且丈七丄丈上世 != null)
        {
                Rilisoft.Singleton<TournamentController>.Instance.StopCoroutine(routine:  val_3.七上且丈七丄丈上世);
        }
        
            TournamentController val_4 = Rilisoft.Singleton<TournamentController>.Instance;
            val_4.丂东万丏丒丑七且丄 = false;
        }
        
        val_7 = null;
        val_7 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丆下丐东东丗丛丗丝, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void TournamentController::业丗丝丏三东丅万丐(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丆下丐东东丗丛丗丝);
    }
    internal void 丐丞不下不丈且丂丂()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void TournamentController::专上不丙专丞丄三丄(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private static void 业丗丝丏三东丅万丐(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_40;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_114;
        var val_115;
        var val_116;
        string val_117;
        七丗三上丗下丄三丛 val_118;
        var val_121;
        System.Collections.Generic.List<TournamentPlayer> val_122;
        var val_123;
        且丛丈丒万与丁丟丟 val_124;
        var val_126;
        var val_127;
        var val_128;
        string val_129;
        var val_130;
        val_114 = 丑与丂丌世丕丆一丗;
        bool val_4 = false;
        int val_8 = 0;
        string val_6 = 0;
        int val_31 = 0;
        string val_29 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_81 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_78 = 0;
        string val_43 = 0;
        int val_45 = 0;
        string val_56 = 0;
        string val_54 = 0;
        int val_83 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_88 = 0;
        if((Rilisoft.Singleton<TournamentController>.Instance) == 0)
        {
                return;
        }
        
        val_115 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "Callback UpdatedLeaderboard executed.");
        }
        
        val_116 = null;
        val_116 = null;
        val_117 = Rilisoft.WebSocket.业丛世业世不丄丐三.丆下丐东东丗丛丗丝;
        if((TournamentController.丂三丈东不丙丟丏一(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "result", 万丏丏丞一丈上不丑: out  val_4)) == false)
        {
                return;
        }
        
        if(val_4 == 0)
        {
            goto label_14;
        }
        
        if((TournamentController.七丈下丕丐三丄丌专(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "season_id", 万丏丏丞一丈上不丑: out  val_6)) == false)
        {
                return;
        }
        
        if((TournamentController.丕不丄东丛且丈丛丈(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "season_end", 万丏丏丞一丈上不丑: out  val_8)) == false)
        {
                return;
        }
        
        TournamentController val_10 = Rilisoft.Singleton<TournamentController>.Instance;
        val_10.<世万三丅上不且丞世>k__BackingField = 0;
        bool val_11 = TournamentController.丕不丄东丛且丈丛丈(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "current_season_end", 万丏丏丞一丈上不丑: out  val_8);
        TournamentController val_12 = Rilisoft.Singleton<TournamentController>.Instance;
        val_12.<丐丂丕业丌丞万丁东>k__BackingField = 0;
        TournamentController val_13 = Rilisoft.Singleton<TournamentController>.Instance;
        if((val_13.<上丄丆丗丂丞万上丌>k__BackingField.scoresTimestamp) == 0)
        {
                TournamentController val_14 = Rilisoft.Singleton<TournamentController>.Instance;
            if((val_14.<上丄丆丗丂丞万上丌>k__BackingField.dataTimestamp) == 0)
        {
                TournamentController val_15 = Rilisoft.Singleton<TournamentController>.Instance;
            val_15.<上丄丆丗丂丞万上丌>k__BackingField.players = new System.Collections.Generic.List<TournamentPlayer>();
            TournamentController val_17 = Rilisoft.Singleton<TournamentController>.Instance;
            .id = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            .nickname = ProfileController.丆三丂丂丆上丆丕专();
            val_118 = RatingSystem.与一丅丝不丈业与丙();
            .score = val_118.万与一丂丗丞一世丅();
            .place = 1;
            val_17.<上丄丆丗丂丞万上丌>k__BackingField.players.Add(item:  new TournamentPlayer());
        }
        
        }
        
        TournamentController val_23 = Rilisoft.Singleton<TournamentController>.Instance;
        bool val_25 = TournamentController.丕不丄东丛且丈丛丈(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "lb_time", 万丏丏丞一丈上不丑: out  val_23.<上丄丆丗丂丞万上丌>k__BackingField.scoresTimestamp);
        TournamentController val_26 = Rilisoft.Singleton<TournamentController>.Instance;
        bool val_28 = TournamentController.丕不丄东丛且丈丛丈(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "dt_time", 万丏丏丞一丈上不丑: out  val_26.<上丄丆丗丂丞万上丌>k__BackingField.dataTimestamp);
        if((TournamentController.七丈下丕丐三丄丌专(丏丂万业丙专丏丒丒:  val_114, 三丛且一丛不丟业世:  val_117, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "leaderboard_id", 万丏丏丞一丈上不丑: out  val_29)) == false)
        {
                return;
        }
        
        bool val_32 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_114, 下上丐丆丝丟丝丒不:  "disabled", 丙业与丙丗丝不丈东: out  val_31);
        bool val_33 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_114, 下上丐丆丝丟丝丒不:  "disable_end", 丙业与丙丗丝不丈东: out  val_31);
        TournamentController.丄丙丗丙专且丏丗丁(丙业与丙丗丝不丈东:  0);
        if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_29)) == false) || ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6)) == false))
        {
            goto label_262;
        }
        
        if((val_114.ContainsKey(key:  "leaderboard")) == false)
        {
            goto label_95;
        }
        
        object val_37 = val_114.Item["leaderboard"];
        if(val_37 == null)
        {
            goto label_95;
        }
        
        List.Enumerator<T> val_38 = val_37.GetEnumerator();
        label_81:
        if((395165856 & 1) == 0)
        {
            goto label_63;
        }
        
        string val_41 = val_40.丐丏七丌丕丗业且上();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_81;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Tournament: get_leaderboard leaderboard item wrong format");
        goto label_81;
        label_14:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Tournament: get_leaderboard result is FALSE");
        return;
        label_63:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_114 != null)
        {
            goto label_96;
        }
        
        goto label_89;
        label_95:
        if(val_114 != null)
        {
            goto label_96;
        }
        
        label_89:
        label_96:
        if((val_114.ContainsKey(key:  "players")) == false)
        {
            goto label_128;
        }
        
        object val_50 = val_114.Item["players"];
        if(val_50 == null)
        {
            goto label_128;
        }
        
        List.Enumerator<T> val_51 = val_50.GetEnumerator();
        label_120:
        if((395165856 & 1) == 0)
        {
            goto label_102;
        }
        
        string val_52 = val_40.丐丏七丌丕丗业且上();
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_120;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Tournament: get_leaderboard players item wrong format");
        goto label_120;
        label_102:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_114 != null)
        {
            goto label_129;
        }
        
        goto label_122;
        label_128:
        if(val_114 != null)
        {
            goto label_129;
        }
        
        label_122:
        label_129:
        if((val_114.ContainsKey(key:  "removed_players")) == false)
        {
            goto label_262;
        }
        
        object val_60 = val_114.Item["removed_players"];
        if(val_60 == null)
        {
            goto label_262;
        }
        
        List.Enumerator<T> val_61 = val_60.GetEnumerator();
        label_170:
        if((395165856 & 1) == 0)
        {
            goto label_135;
        }
        
        new TournamentController.丟一丛丑丘上丗下东() = new TournamentController.丟一丛丑丘上丗下东();
        .业上上丏丄不上丅丈 = System.Convert.ToString(value:  val_40.丐丏七丌丕丗业且上());
        TournamentController val_65 = Rilisoft.Singleton<TournamentController>.Instance;
        System.Predicate<TournamentPlayer> val_66 = new System.Predicate<TournamentPlayer>(object:  new TournamentController.丟一丛丑丘上丗下东(), method:  System.Boolean TournamentController.丟一丛丑丘上丗下东::丅丁丑丂专七丆下且(TournamentPlayer 专丞上七七且丝七丗));
        int val_67 = val_65.<上丄丆丗丂丞万上丌>k__BackingField.players.FindIndex(match:  null);
        if((val_67 & 2147483648) != 0)
        {
            goto label_170;
        }
        
        TournamentController val_68 = Rilisoft.Singleton<TournamentController>.Instance;
        val_68.<上丄丆丗丂丞万上丌>k__BackingField.players.RemoveAt(index:  val_67);
        goto label_170;
        label_135:
        val_121 = 0;
        val_122 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_179;
        }
        
        if(( == 0) || (1010 == 1010))
        {
            goto label_262;
        }
        
        label_261:
        label_262:
        TournamentController val_71 = Rilisoft.Singleton<TournamentController>.Instance;
        TournamentController val_72 = Rilisoft.Singleton<TournamentController>.Instance;
        val_71.丞下丒丄上丅世下丌 = val_72.<上丄丆丗丂丞万上丌>k__BackingField.丆丏业专与万丑三丂();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == false)
        {
            goto label_190;
        }
        
        val_123 = null;
        if(TournamentController.丅丑万丛丟与丆丘丈() == false)
        {
            goto label_190;
        }
        
        TournamentController val_76 = Rilisoft.Singleton<TournamentController>.Instance;
        val_124 = 0;
        goto label_192;
        label_190:
        val_124 = 1;
        label_192:
        Rilisoft.Singleton<TournamentController>.Instance.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  val_124);
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_114, 下上丐丆丝丟丝丒不:  "reward", 丙业与丙丗丝不丈东: out  val_78)) != false)
        {
                TournamentReward val_80 = TournamentController.丘丌一东丕世七三上(丝丒丅东三丞三丐七:  val_78);
            val_117 = val_80;
            TournamentController.丗丟七丁不丟一业下(专丟丏丝丛一丂与下:  val_80);
        }
        else
        {
                val_117 = 0;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_114, 下上丐丆丝丟丝丒不:  "v2v3_migration_reward", 丙业与丙丗丝不丈东: out  val_81)) == false)
        {
            goto label_202;
        }
        
        val_115 = 1152921524472663264;
        bool val_84 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_81, 下上丐丆丝丟丝丒不:  "place", 丙业与丙丗丝不丈东: out  val_83);
        bool val_85 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_81, 下上丐丆丝丟丝丒不:  "score", 丙业与丙丗丝不丈东: out  val_83);
        bool val_87 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_81, 下上丐丆丝丟丝丒不:  "league", 丙业与丙丗丝不丈东: out  0);
        bool val_89 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_81, 下上丐丆丝丟丝丒不:  "reward_config", 丙业与丙丗丝不丈东: out  val_88);
        val_118 = TournamentController.业丛丐七与丆不丙丆(且七丙丁与丌丗与上:  0, 丝丞且丘丝丙业丏东:  0, 专丂丌丝下丙丁丌丞:  0, 丟上丞丗与一丒不上:  TournamentController.丝业三东丈丞丁三丟(丛丘专下且与丕丆丈:  val_88));
        val_126 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_126 != null)
        {
            goto label_208;
        }
        
        goto label_208;
        label_202:
        val_126 = Rilisoft.Singleton<TournamentController>.Instance;
        val_118 = 0;
        label_208:
        val_93.<一东丌丁下东专丄上>k__BackingField = val_118;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
        {
                val_127 = null;
            if(TournamentController.丅丑万丛丟与丆丘丈() != true)
        {
                TournamentController val_96 = Rilisoft.Singleton<TournamentController>.Instance;
            if(val_96.丐丑专三丐丞业丂丝 == null)
        {
                TournamentController.丝丁七丅且且不丂丆(不丘丅丝且丏上一丒:  true);
        }
        
            Rilisoft.Singleton<TournamentController>.Instance.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  0);
        }
        
        }
        
        if(0 == 1)
        {
                Rilisoft.Singleton<TournamentController>.Instance.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  2);
            TournamentController.三上不丟丌专丈专丝();
        }
        
        Rilisoft.Singleton<TournamentController>.Instance.与三不东丝世丝丏下();
        Rilisoft.Singleton<TournamentController>.Instance.一东上丏万万世世丑(一丑不东丒下丂丞丙:  val_6);
        TournamentController val_101 = Rilisoft.Singleton<TournamentController>.Instance;
        val_101.<上丄丆丗丂丞万上丌>k__BackingField.id = val_29;
        TournamentController val_102 = Rilisoft.Singleton<TournamentController>.Instance;
        val_128 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_102.丌丘丕丟丄丙丛丕丄 == 0)
        {
            goto label_235;
        }
        
        val_128 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_103.丌丘丕丟丄丙丛丕丄 == 2)
        {
            goto label_235;
        }
        
        if(val_104.丌丘丕丟丄丙丛丕丄 != 3)
        {
            goto label_234;
        }
        
        val_128 = Rilisoft.Singleton<TournamentController>.Instance;
        label_235:
        val_105.<上丄丆丗丂丞万上丌>k__BackingField.players.Clear();
        label_234:
        TournamentController val_106 = Rilisoft.Singleton<TournamentController>.Instance;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DivisionsTournament.LeaderboardCacheKey_v3", 下下丏一丙不丘丌丞:  val_106.<上丄丆丗丂丞万上丌>k__BackingField.丂丆丑世一不丘丏七());
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_29)) != false)
        {
                TournamentController val_109 = Rilisoft.Singleton<TournamentController>.Instance;
            if((val_109.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                val_129 = val_109.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
            val_109.世上丅丄丄七三丟丝 = val_129;
        }
        else
        {
                val_129 = val_109.世上丅丄丄七三丟丝;
        }
        
            if(((val_117 != 0) && ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_129)) != false)) && (28563616 == 0))
        {
                TournamentController val_111 = Rilisoft.Singleton<TournamentController>.Instance;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "key_tournament_lastValidLeaderboard_v3", 下下丏一丙不丘丌丞:  val_111.<上丄丆丗丂丞万上丌>k__BackingField.丂丆丑世一不丘丏七());
        }
        
        }
        
        val_130 = null;
        val_130 = null;
        TournamentController.下世丄三且七东丅丞.Invoke();
        val_114 = TournamentController.丗丗丒丁下且丘且丒;
        val_114.Invoke();
        return;
        label_179:
        if( != 0)
        {
            goto label_261;
        }
        
        goto label_262;
    }
    private static void 三上不丟丌专丈专丝()
    {
        TournamentController val_1 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_1.万丘业丞丙丌丒丆丌 != null)
        {
                Rilisoft.Singleton<TournamentController>.Instance.StopCoroutine(routine:  Rilisoft.Singleton<TournamentController>.Instance.丞丅丘丈丏丏丆丄一());
        }
        
        TournamentController val_5 = Rilisoft.Singleton<TournamentController>.Instance;
        val_5.万丘业丞丙丌丒丆丌 = Rilisoft.Singleton<TournamentController>.Instance.StartCoroutine(routine:  Rilisoft.Singleton<TournamentController>.Instance.丞丅丘丈丏丏丆丄一());
    }
    internal static System.Collections.Generic.List<TournamentPlayer> 丌丝丕世丌三丕东丕()
    {
        System.Collections.Generic.List<TournamentPlayer> val_1 = new System.Collections.Generic.List<TournamentPlayer>(capacity:  50);
        do
        {
            TournamentPlayer val_6 = null;
            var val_4 = 50 - 0;
            val_4 = val_4 + (val_4 << 2);
            val_6 = new TournamentPlayer(且丙不丟业七万东丗:  0.ToString(), 丂且丑世一一不万世:  System.String.Format(format:  "Игрок {0}", arg0:  1), 与专且三丛不丄丗丂:  val_4 << 1, 且丒丛与丞世丙丕丌:  1);
            val_1.Add(item:  val_6);
        }
        while(1 < 50);
        
        return val_1;
    }
    private static void 丗丟七丁不丟一业下(TournamentReward 专丟丏丝丛一丂与下)
    {
        TournamentReward val_7;
        Rilisoft.Singleton<TournamentController>.Instance.丆丑丛丑一与丗丆业();
        TournamentController val_2 = Rilisoft.Singleton<TournamentController>.Instance;
        val_2.丂东万丏丒丑七且丄 = true;
        TournamentController.七丅三丏三丛专丅与(丙业与丙丗丝不丈东:  0);
        val_7 = 专丟丏丝丛一丂与下.Clone();
        if((Rilisoft.Singleton<TournamentController>.Instance) == null)
        {
            goto label_6;
        }
        
        if(val_7 != null)
        {
            goto label_7;
        }
        
        goto label_11;
        label_6:
        if(val_7 == null)
        {
            goto label_11;
        }
        
        label_7:
        val_7 = 0;
        label_11:
        val_3.丐丑专三丐丞业丂丝 = val_7;
    }
    internal static void 丟七丟丘丒不丙世丙()
    {
        null = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
    }
    private static TournamentReward 丘丌一东丕世七三上(System.Collections.Generic.Dictionary<string, object> 丝丒丅东三丞三丐七)
    {
        var val_15;
        System.Func<System.Object, PGCompany.三东丏不丗世丅丌丄> val_17;
        var val_18;
        var val_19;
        int val_1 = 0;
        int val_4 = 0;
        int val_8 = 0;
        System.Collections.Generic.List<System.Object> val_6 = 0;
        bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丝丒丅东三丞三丐七, 下上丐丆丝丟丝丒不:  "result_place", 丙业与丙丗丝不丈东: out  val_1);
        bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丝丒丅东三丞三丐七, 下上丐丆丝丟丝丒不:  "result_score", 丙业与丙丗丝不丈东: out  val_1);
        bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丝丒丅东三丞三丐七, 下上丐丆丝丟丝丒不:  "new_league", 丙业与丙丗丝不丈东: out  val_4);
        bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  丝丒丅东三丞三丐七, 下上丐丆丝丟丝丒不:  "reward", 丙业与丙丗丝不丈东: out  val_6);
        bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丝丒丅东三丞三丐七, 下上丐丆丝丟丝丒不:  "new_score", 丙业与丙丗丝不丈东: out  val_8);
        bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丝丒丅东三丞三丐七, 下上丐丆丝丟丝丒不:  "season", 丙业与丙丗丝不丈东: out  val_8);
        val_15 = null;
        val_15 = null;
        val_17 = TournamentController.<>c.<>9__114_0;
        if(val_17 == null)
        {
                System.Func<System.Object, PGCompany.三东丏不丗世丅丌丄> val_11 = null;
            val_17 = val_11;
            val_11 = new System.Func<System.Object, PGCompany.三东丏不丗世丅丌丄>(object:  TournamentController.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.三东丏不丗世丅丌丄 TournamentController.<>c::一丁丑丈世专丑丏丆(object 三丟东丕丄丄下下丑));
            TournamentController.<>c.<>9__114_0 = val_17;
        }
        
        System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  System.Linq.Enumerable.Select<System.Object, PGCompany.三东丏不丗世丅丌丄>(source:  val_6, selector:  val_11));
        TournamentReward val_14 = new TournamentReward();
        val_18 = 0;
        if(val_14 != null)
        {
                .reward = val_13;
            .newLeague = 0;
            .newScores = 0;
            .resultPlace = 0;
            .seasonId = 0;
            val_19 = 0;
        }
        else
        {
                mem[24] = val_18;
            val_18 = val_4;
            mem[16] = val_18;
            mem[40] = val_13;
            .newScores = 0;
            mem[32] = 0;
            val_19 = 0;
        }
        
        .resultScores = 0;
        return val_14;
    }
    private void 七丟丕一丕不上业丕()
    {
        var val_5;
        string val_6;
        val_5 = null;
        if(TournamentController.丌万丘丙万世丗丈丏() != false)
        {
                return;
        }
        
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                val_6 = this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
            this.世上丅丄丄七三丟丝 = val_6;
        }
        else
        {
                val_6 = this.世上丅丄丄七三丟丝;
        }
        
        bool val_2 = System.String.IsNullOrEmpty(value:  val_6);
        PGCompany.丒丒丛丙不万专三丆 val_3 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世();
        System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> val_4 = new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void TournamentController::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且));
        if(val_3 == null)
        {
            goto label_6;
        }
        
        if(val_2 == false)
        {
            goto label_7;
        }
        
        label_10:
        val_3.丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  val_4);
        TournamentController.世丗与丛丅不丘丄丁(丙业与丙丗丝不丈东:  true);
        return;
        label_6:
        if(val_2 == true)
        {
            goto label_10;
        }
        
        label_7:
        val_3.丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  val_4);
        this.丆丑丛丑一与丗丆业();
    }
    private void 丒丝业不专丏与丆丑()
    {
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_13;
        var val_14;
        var val_15;
        if(this.丌丘丕丟丄丙丛丕丄 == 2)
        {
                return;
        }
        
        if(this.丌丘丕丟丄丙丛丕丄 == 0)
        {
                this.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  1);
            this.<上丄丆丗丂丞万上丌>k__BackingField.players = new System.Collections.Generic.List<TournamentPlayer>();
            this.丞下丒丄上丅世下丌 = this.<上丄丆丗丂丞万上丌>k__BackingField.丆丏业专与万丑三丂();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DivisionsTournament.LeaderboardCacheKey_v3", 下下丏一丙不丘丌丞:  this.<上丄丆丗丂丞万上丌>k__BackingField.丂丆丑世一不丘丏七());
            val_14 = null;
            val_14 = null;
            TournamentController.丗丗丒丁下且丘且丒.Invoke();
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_4 = null;
        val_13 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_4.Add(key:  "score", value:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
        val_4.Add(key:  "league", value:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        val_4.Add(key:  "leaderboard_id", value:  this.<上丄丆丗丂丞万上丌>k__BackingField.id);
        val_4.Add(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑());
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_4.Add(key:  "test", value:  1);
        }
        
        val_15 = null;
        val_15 = null;
        int val_12 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一, 一丐丗丁丞丆丅丟丄:  val_4);
    }
    private void 专上不丙专丞丄三丄(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_28;
        var val_29;
        string val_30;
        var val_31;
        var val_32;
        七丗三上丗下丄三丛 val_34;
        val_28 = 丑与丂丌世丕丆一丗;
        int val_5 = 0;
        string val_3 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_20 = 0;
        val_29 = null;
        val_29 = null;
        val_30 = Rilisoft.WebSocket.业丛世业世不丄丐三.丂丆丄丛丂三丘业一;
        bool val_1 = false;
        if((TournamentController.丂三丈东不丙丟丏一(丏丂万业丙专丏丒丒:  val_28, 三丛且一丛不丟业世:  val_30, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "result", 万丏丏丞一丈上不丑: out  val_1)) == false)
        {
                return;
        }
        
        if(val_1 == 0)
        {
            goto label_6;
        }
        
        if((TournamentController.七丈下丕丐三丄丌专(丏丂万业丙专丏丒丒:  val_28, 三丛且一丛不丟业世:  val_30, 丗丑东丅丗三三丂丕:  System.String.alignConst, 世丘下丐丐丅一丑丙:  "season_id", 万丏丏丞一丈上不丑: out  val_3)) == false)
        {
                return;
        }
        
        bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_28, 下上丐丆丝丟丝丒不:  "disabled", 丙业与丙丗丝不丈东: out  val_5);
        bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_28, 下上丐丆丝丟丝丒不:  "disable_end", 丙业与丙丗丝不丈东: out  val_5);
        TournamentController.丄丙丗丙专且丏丗丁(丙业与丙丗丝不丈东:  0);
        val_31 = null;
        if(TournamentController.丅丑万丛丟与丆丘丈() != false)
        {
                TournamentController.丝丁七丅且且不丂丆(不丘丅丝且丏上一丒:  false);
        }
        
        this.丆丆业丅一七东世东(丙业与丙丗丝不丈东:  val_3);
        val_32 = null;
        val_32 = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
        val_30 = 1152921524466961824;
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_28, 下上丐丆丝丟丝丒不:  "reward", 丙业与丙丗丝不丈东: out  val_9)) != false)
        {
                TournamentController.丗丟七丁不丟一业下(专丟丏丝丛一丂与下:  TournamentController.丘丌一东丕世七三上(丝丒丅东三丞三丐七:  val_9));
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_28, 下上丐丆丝丟丝丒不:  "v2v3_migration_reward", 丙业与丙丗丝不丈东: out  val_12)) == false)
        {
            goto label_29;
        }
        
        bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "place", 丙业与丙丗丝不丈东: out  0);
        bool val_17 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "score", 丙业与丙丗丝不丈东: out  0);
        bool val_19 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "league", 丙业与丙丗丝不丈东: out  0);
        bool val_21 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_12, 下上丐丆丝丟丝丒不:  "reward_config", 丙业与丙丗丝不丈东: out  val_20);
        val_34 = TournamentController.业丛丐七与丆不丙丆(且七丙丁与丌丗与上:  0, 丝丞且丘丝丙业丏东:  0, 专丂丌丝下丙丁丌丞:  0, 丟上丞丗与一丒不上:  TournamentController.丝业三东丈丞丁三丟(丛丘专下且与丕丆丈:  val_20));
        val_28 = Rilisoft.Singleton<TournamentController>.Instance;
        if(val_28 != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_6:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Tournament: update_score result is FALSE");
        return;
        label_29:
        val_28 = Rilisoft.Singleton<TournamentController>.Instance;
        val_34 = 0;
        label_35:
        val_26.<一东丌丁下东专丄上>k__BackingField = val_34;
        if(0 != 1)
        {
                return;
        }
        
        val_28 = Rilisoft.Singleton<TournamentController>.Instance;
        val_28.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  2);
        TournamentController.三上不丟丌专丈专丝();
    }
    private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        string val_8;
        string val_9;
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 36)
        {
                if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 37)
        {
                return;
        }
        
        }
        
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                val_8 = this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
            this.世上丅丄丄七三丟丝 = val_8;
        }
        else
        {
                val_8 = this.世上丅丄丄七三丟丝;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_8)) == true)
        {
                return;
        }
        
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                val_9 = this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
            this.世上丅丄丄七三丟丝 = val_9;
        }
        else
        {
                val_9 = this.世上丅丄丄七三丟丝;
        }
        
        bool val_5 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_9, 丙业与丙丗丝不丈东: out  0);
        if(36 != 丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝())
        {
                return;
        }
        
        this.丆丑丛丑一与丗丆业();
    }
    internal void 世三丝业下三丗七丕()
    {
        this.丐丑专三丐丞业丂丝 = 0;
    }
    internal int 七丌专万专与丗丛一(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        return 0;
    }
    private void 丑三一丛丈专丈专丛()
    {
        var val_2;
        if(this.丌丘丕丟丄丙丛丕丄 != 1)
        {
                return;
        }
        
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) == null)
        {
                return;
        }
        
        this.丞下丒丄上丅世下丌 = this.<上丄丆丗丂丞万上丌>k__BackingField.丆丏业专与万丑三丂();
        val_2 = null;
        val_2 = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
    }
    internal static void 丝丁七丅且且不丂丆(bool 不丘丅丝且丏上一丒)
    {
        if((不丘丅丝且丏上一丒 != false) && ((Rilisoft.Singleton<TournamentController>.Instance) != 0))
        {
                if(val_3.七上且丈七丄丈上世 != null)
        {
                Rilisoft.Singleton<TournamentController>.Instance.StopCoroutine(routine:  val_3.七上且丈七丄丈上世);
        }
        
        }
        
        丌丝世丞世丛丆丅丟.万丈丛丞丕业丙东丄(下上丐丆丝丟丝丒不:  "key_lastTournamentSeason_ended_v3-"("key_lastTournamentSeason_ended_v3-") + FriendsController.不丝丕丒丂丆丘丙丙(), 下下丏一丙不丘丌丞:  不丘丅丝且丏上一丒, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private static bool 丏一东丏与丙且丅丄()
    {
        return 丌丝世丞世丛丆丅丟.丙不下丝与丏世世三(下上丐丆丝丟丝丒不:  "key_lastTournamentSeason_ended_v3-"("key_lastTournamentSeason_ended_v3-") + FriendsController.不丝丕丒丂丆丘丙丙(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    private void 上与丐丏丕一世丒丄()
    {
        int val_16;
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  84)) != false)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  164);
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  78)) != false)
        {
                val_16 = TournamentController.丏上丈上丐丅丌七业(丙丑七万丆万丆且丌:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
            if((val_16 & 2147483648) != 0)
        {
                val_16 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        }
        
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丆丙丆丝世与丘万(上丗业丂丑三丏上丏:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏(), 丆丞下七丛上丐世丌:  val_16);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  84);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    internal static void 丝丂丐丞丄丑丗丐一(TournamentReward 丗七丟丈三不丕一三)
    {
        null = null;
        if(TournamentController.丞丏世上世丙丄三丄 == null)
        {
                return;
        }
        
        TournamentController.丞丏世上世丙丄三丄.Invoke(obj:  丗七丟丈三不丕一三);
    }
    private void Update()
    {
        this.与三不东丝世丝丏下();
        this.丐且与三一丝丙丌丘();
    }
    private void 与三不东丝世丝丏下()
    {
        var val_8;
        if(this.丌丘丕丟丄丙丛丕丄 != 0)
        {
                return;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.丂与丐下一丟丆丌与());
        Rilisoft.丝丑丂丛万丐丈丘且 val_3 = this.丞丁下丛丒一丈丌丑();
        if((Rilisoft.丝丑丂丛万丐丈丘且.万丟丏丄丄三丝业丞(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_2.上万三丆专丏丒丗业}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_3.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_3.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_3.上万三丆专丏丒丗业})) == false)
        {
                return;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_5 = this.丞丁下丛丒一丈丌丑();
        Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        if((Rilisoft.丝丑丂丛万丐丈丘且.上丆丟万丒丈且丈丝(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_5.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_5.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_5.上万三丆专丏丒丗业}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_6.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_6.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_6.上万三丆专丏丒丗业})) == false)
        {
                return;
        }
        
        this.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  3);
        val_8 = null;
        val_8 = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
    }
    private void 丐且与三一丝丙丌丘()
    {
        var val_5;
        if(this.丌丘丕丟丄丙丛丕丄 != 3)
        {
                return;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.丂与丐下一丟丆丌与());
        Rilisoft.丝丑丂丛万丐丈丘且 val_3 = this.丞丁下丛丒一丈丌丑();
        if((Rilisoft.丝丑丂丛万丐丈丘且.上丆丟万丒丈且丈丝(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_2.上万三丆专丏丒丗业}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_3.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_3.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_3.上万三丆专丏丒丗业})) == false)
        {
                return;
        }
        
        this.万世七三下丁丙与丈(丙业与丙丗丝不丈东:  0);
        val_5 = null;
        val_5 = null;
        TournamentController.丗丗丒丁下且丘且丒.Invoke();
    }
    private void 丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 141)
        {
                return;
        }
        
        this.丈丏一一世丂丒上下();
    }
    private void 丈丏一一世丂丒上下()
    {
        string val_3 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  141);
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.丁三丕七丟万丈丂丏 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
    }
    internal static bool 丐丒丑丆丒且东与世(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = TournamentController.丞丄丕七丆上丙丛世();
        if(val_1 == null)
        {
                return (bool)val_1;
        }
        
        return val_1.ContainsKey(key:  丙丑七万丆万丆且丌);
    }
    internal static void 三丏丄丌且下丗一东(RatingSystem.RatingLeague 丙丑七万丆万丆且丌, int 万且丒下丕丝专丟上)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_6 = TournamentController.丞丄丕七丆上丙丛世();
        if(val_6 == null)
        {
                System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = null;
            val_6 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if(val_6 == null)
        {
            goto label_12;
        }
        
        }
        
        label_12:
        bool val_4 = val_2.TryGetValue(key:  丙丑七万丆万丆且丌, value: out  0);
        if(val_4 != false)
        {
                if(0 < 万且丒下丕丝专丟上)
        {
            goto label_6;
        }
        
        }
        
        if(val_4 == true)
        {
                return;
        }
        
        label_6:
        val_2.set_Item(key:  丙丑七万丆万丆且丌, value:  万且丒下丕丝专丟上);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  155, 丙业与丙丗丝不丈东:  val_2);
    }
    internal static int 专丌丙丘三万下丙丑(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        var val_4;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = TournamentController.丞丄丕七丆上丙丛世();
        int val_2 = 0;
        if(val_1 == null)
        {
                return (int)val_4;
        }
        
        bool val_3 = val_1.TryGetValue(key:  丙丑七万丆万丆且丌, value: out  val_2);
        val_4 = val_2;
        return (int)val_4;
    }
    private static System.Collections.Generic.Dictionary<int, int> 丞丄丕七丆上丙丛世()
    {
        Progress.丘东丅丌东丒上七丁 val_15 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if((val_15.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  155)) == false)
        {
                return 0;
        }
        
        val_15 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  155);
        UnityEngine.Debug.LogError(message:  "Cannot cast to Dictionary");
        return 0;
    }
    internal PGCompany.丌七丒万丝丄东且七 丕与且世丙丟丐一世()
    {
        return (PGCompany.丌七丒万丝丄东且七)this.丈丕丝丄丗一七丞丑;
    }
    internal static PGCompany.ConfigId 且不丘世丞丗下丞丝(bool 丘丈七丝一下下丒七)
    {
        return (PGCompany.ConfigId)((丘丈七丝一下下丒七 & true) != 0) ? (36 + 1) : 36;
    }
    private void 丆丑丛丑一与丗丆业()
    {
        System.Action val_7;
        string val_8;
        var val_9;
        string val_10;
        val_7 = this;
        if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                val_8 = this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
            this.世上丅丄丄七三丟丝 = val_8;
        }
        else
        {
                val_8 = this.世上丅丄丄七三丟丝;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != false)
        {
                val_9 = 36;
        }
        else
        {
                if((this.<上丄丆丗丂丞万上丌>k__BackingField) != null)
        {
                val_10 = this.<上丄丆丗丂丞万上丌>k__BackingField.SeasonID;
            this.世上丅丄丄七三丟丝 = val_10;
        }
        else
        {
                val_10 = this.世上丅丄丄七三丟丝;
        }
        
            bool val_3 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_10, 丙业与丙丗丝不丈东: out  0);
        }
        
        if((this.丛不丄与丅丘丙丁与(丌下业东与下丅丞七:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  36))) == false)
        {
                return;
        }
        
        TournamentController.世丗与丛丅不丘丄丁(丙业与丙丗丝不丈东:  true);
        val_7 = TournamentController.丗丗丒丁下且丘且丒;
        val_7.Invoke();
        if(TournamentController.丛丝丆丝丏七丗下丄 == null)
        {
                return;
        }
        
        TournamentController.丛丝丆丝丏七丗下丄.Invoke();
    }
    private bool 丛不丄与丅丘丙丁与(string 丌下业东与下丅丞七)
    {
        DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.丈丕丝丄丗一七丞丑 = val_1;
        return (bool)(val_1 != 0) ? 1 : 0;
    }
    internal static int 丏上丈上丐丅丌七业(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        object val_15;
        System.Func<TSource, System.Boolean> val_16;
        TournamentController.丘且丆丙不七业丛丒 val_1 = null;
        val_15 = val_1;
        val_1 = new TournamentController.丘且丆丙不七业丛丒();
        .丙丑七万丆万丆且丌 = 丙丑七万丆万丆且丌;
        string val_3 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  36);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) == true)
        {
                return 0;
        }
        
        val_16 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_16 == null)
        {
                return 0;
        }
        
        System.Func<上丅且且万丅丞三丗, System.Boolean> val_7 = null;
        val_16 = val_7;
        val_7 = new System.Func<上丅且且万丅丞三丗, System.Boolean>(object:  val_1, method:  System.Boolean TournamentController.丘且丆丙不七业丛丒::丁三丛专三东丒丁丛(PGCompany.丌七丒万丝丄东且七.上丅且且万丅丞三丗 丏丛与丅丛丌万专丌));
        if((System.Linq.Enumerable.FirstOrDefault<上丅且且万丅丞三丗>(source:  val_3, predicate:  val_7)) == null)
        {
                return 0;
        }
        
        val_15 = ???;
        val_16 = ???;
        return 0;
    }
    private static bool 丕不丄东丛且丈丛丈(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒, string 三丛且一丛不丟业世, string 丗丑东丅丗三三丂丕, string 世丘下丐丐丅一丑丙, out int 万丏丏丞一丈上不丑)
    {
        object val_7;
        int val_8;
        var val_9;
        val_7 = 丏丂万业丙专丏丒丒;
        万丏丏丞一丈上不丑 = 0;
        val_8 = System.String.alignConst;
        if((System.String.IsNullOrEmpty(value:  丗丑东丅丗三三丂丕)) != true)
        {
                val_8 = " at " + 丗丑东丅丗三三丂丕;
        }
        
        if((val_7.ContainsKey(key:  世丘下丐丐丅一丑丙)) != false)
        {
                val_7 = val_7.Item[世丘下丐丐丅一丑丙];
            万丏丏丞一丈上不丑 = System.Convert.ToInt32(value:  val_7);
            val_9 = 1;
            return (bool)val_9;
        }
        
        object[] val_6 = new object[3];
        val_6[0] = 三丛且一丛不丟业世;
        val_6[1] = 世丘下丐丐丅一丑丙;
        val_6[2] = val_8;
        UnityEngine.Debug.LogWarningFormat(format:  "Tournament: {0} can\'t find {1} field{2}", args:  val_6);
        val_9 = 0;
        return (bool)val_9;
    }
    private static bool 七丈下丕丐三丄丌专(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒, string 三丛且一丛不丟业世, string 丗丑东丅丗三三丂丕, string 世丘下丐丐丅一丑丙, out string 万丏丏丞一丈上不丑)
    {
        object val_7;
        int val_8;
        var val_9;
        val_7 = 丏丂万业丙专丏丒丒;
        万丏丏丞一丈上不丑 = "";
        val_8 = System.String.alignConst;
        if((System.String.IsNullOrEmpty(value:  丗丑东丅丗三三丂丕)) != true)
        {
                val_8 = " at " + 丗丑东丅丗三三丂丕;
        }
        
        if((val_7.ContainsKey(key:  世丘下丐丐丅一丑丙)) != false)
        {
                val_7 = val_7.Item[世丘下丐丐丅一丑丙];
            万丏丏丞一丈上不丑 = System.Convert.ToString(value:  val_7);
            val_9 = 1;
            return (bool)val_9;
        }
        
        object[] val_6 = new object[3];
        val_6[0] = 三丛且一丛不丟业世;
        val_6[1] = 世丘下丐丐丅一丑丙;
        val_6[2] = val_8;
        UnityEngine.Debug.LogWarningFormat(format:  "Tournament: {0} can\'t find {1} field{2}", args:  val_6);
        val_9 = 0;
        return (bool)val_9;
    }
    private static bool 丂三丈东不丙丟丏一(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒, string 三丛且一丛不丟业世, string 丗丑东丅丗三三丂丕, string 世丘下丐丐丅一丑丙, out bool 万丏丏丞一丈上不丑)
    {
        object val_8;
        int val_9;
        var val_10;
        val_8 = 丏丂万业丙专丏丒丒;
        万丏丏丞一丈上不丑 = false;
        val_9 = System.String.alignConst;
        if((System.String.IsNullOrEmpty(value:  丗丑东丅丗三三丂丕)) != true)
        {
                val_9 = " at " + 丗丑东丅丗三三丂丕;
        }
        
        if((val_8.ContainsKey(key:  世丘下丐丐丅一丑丙)) != false)
        {
                val_8 = val_8.Item[世丘下丐丐丅一丑丙];
            val_10 = 1;
            万丏丏丞一丈上不丑 = System.Convert.ToBoolean(value:  val_8);
            return (bool)val_10;
        }
        
        object[] val_7 = new object[3];
        val_7[0] = 三丛且一丛不丟业世;
        val_7[1] = 世丘下丐丐丅一丑丙;
        val_7[2] = val_9;
        UnityEngine.Debug.LogWarningFormat(format:  "Tournament: {0} can\'t find {1} field{2}", args:  val_7);
        val_10 = 0;
        return (bool)val_10;
    }
    internal TournamentController.七丗三上丗下丄三丛 丅万丞三丏丒丅丝丁()
    {
        return (七丗三上丗下丄三丛)this.<一东丌丁下东专丄上>k__BackingField;
    }
    internal void 上万丅丈丟丁丗上丙(TournamentController.七丗三上丗下丄三丛 丙业与丙丗丝不丈东)
    {
        this.<一东丌丁下东专丄上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private static System.Collections.Generic.List<TournamentController.七丙丄丁七丑丛丙丄> 丝业三东丈丞丁三丟(System.Collections.Generic.Dictionary<string, object> 丛丘专下且与丕丆丈)
    {
        var val_5;
        var val_89;
        var val_90;
        object val_91;
        var val_92;
        System.Collections.Generic.List<七丙丄丁七丑丛丙丄> val_1 = null;
        val_89 = val_1;
        val_1 = new System.Collections.Generic.List<七丙丄丁七丑丛丙丄>();
        if(丛丘专下且与丕丆丈 == null)
        {
            goto label_1;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = 丛丘专下且与丕丆丈.GetEnumerator();
        val_90 = 1152921539367468208;
        goto label_85;
        label_89:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        System.Nullable<T> val_8 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<RatingLeague>(下业七不丑丂丏丟东:  val_6._value._obj.丐丏七丌丕丗业且上(), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
        if((401060648 & 1) != 0)
        {
                if(val_6._value._obj != 0)
        {
                val_91 = new TournamentController.七丙丄丁七丑丛丙丄();
            val_91 = new System.Object();
            .丙丑七万丆万丆且丌 = ;
            val_1.Add(item:  new TournamentController.七丙丄丁七丑丛丙丄());
            if((val_6._value._obj.ContainsKey(key:  "TotalPlayer")) != false)
        {
                bool val_13 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TotalPlayer"], 丙业与丙丗丝不丈东: out  (TournamentController.七丙丄丁七丑丛丙丄)[1152921539367702448].专且与丏丝与上丟丕);
        }
        
            if((val_6._value._obj.ContainsKey(key:  "TOPPlayer")) != false)
        {
                bool val_17 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOPPlayer"], 丙业与丙丗丝不丈东: out  (TournamentController.七丙丄丁七丑丛丙丄)[1152921539367702448].丅丘丝丂万丟丄东丟);
        }
        
            if((val_6._value._obj.ContainsKey(key:  "TOPRating")) != false)
        {
                bool val_21 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOPRating"], 丙业与丙丗丝不丈东: out  (TournamentController.七丙丄丁七丑丛丙丄)[1152921539367702448].一丗丁丙上丟三丅丗);
        }
        
            if((val_6._value._obj.ContainsKey(key:  "LOWPlayer")) != false)
        {
                bool val_25 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["LOWPlayer"], 丙业与丙丗丝不丈东: out  (TournamentController.七丙丄丁七丑丛丙丄)[1152921539367702448].丐丄上丂专七丙专丝);
        }
        
            if((val_6._value._obj.ContainsKey(key:  "TOPGems")) != false)
        {
                .丛下丅丘丞丙万丟与 = 0;
            .业专丟丒丆丐一丁丏 = 0;
            .丛且丕丛丂世下一丂 = 0;
            new TournamentController.七丗三上丗下丄三丛() = new System.Object();
            .且丆丂丄不丆与不丟 = new TournamentController.七丗三上丗下丄三丛();
            .丂丐下丕丄专丞世丘 = 1;
            .七七丛丅一专丒东不 = ((TournamentController.七丙丄丁七丑丛丙丄)[1152921539367702448].丙丑七万丆万丆且丌 < RatingSystem.丒丐丁一丈丏丗丅东()) ? 1 : 0;
            bool val_32 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOPGems"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367722928].下丅丌丌丆不东专丁);
            bool val_35 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOPCoins"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367722928].一七东丑丘世丑丙不);
            .三万万丒丏丒不丐丙 = TournamentController.东一丕上世与不丈丟(丒东丝业下七丆丙丛:  val_6._value._obj.Item["TOPEggs"]);
            if((val_6._value._obj.ContainsKey(key:  "TOPSuper1")) != false)
        {
                .且丆七下且丐丁与丌 = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOPSuper1"], 丝七丄丛丂丒丘不丛:  ',');
        }
        
            if((val_6._value._obj.ContainsKey(key:  "TOPSuper2")) != false)
        {
                .丘丙丌丂丕丞丏丁丒 = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOPSuper2"], 丝七丄丛丂丒丘不丛:  ',');
        }
        
            if((val_6._value._obj.ContainsKey(key:  "TOP1Chest")) != false)
        {
                bool val_47 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOP1Chest"], 丙业与丙丗丝不丈东: out  1152921539367722944);
        }
        
            val_90 = 1152921539367468208;
            if((val_6._value._obj.ContainsKey(key:  "TOP2Chest")) != false)
        {
                bool val_51 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOP2Chest"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367722928].业专丟丒丆丐一丁丏);
        }
        
            if((val_6._value._obj.ContainsKey(key:  "TOP3Chest")) != false)
        {
                bool val_55 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["TOP3Chest"], 丙业与丙丗丝不丈东: out  1152921539367722952);
        }
        
        }
        
            val_92 = 1152921516630043280;
            if((val_6._value._obj.ContainsKey(key:  "AVGGems")) != false)
        {
                .丛下丅丘丞丙万丟与 = 0;
            .业专丟丒丆丐一丁丏 = 0;
            .丛且丕丛丂世下一丂 = 0;
            new TournamentController.七丗三上丗下丄三丛() = new System.Object();
            .丙万不丗七丞上丏丒 = new TournamentController.七丗三上丗下丄三丛();
            .丂丐下丕丄专丞世丘 = 0;
            .七七丛丅一专丒东不 = 0;
            bool val_60 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["AVGGems"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367780272].下丅丌丌丆不东专丁);
            bool val_63 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["AVGCoins"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367780272].一七东丑丘世丑丙不);
            .三万万丒丏丒不丐丙 = TournamentController.东一丕上世与不丈丟(丒东丝业下七丆丙丛:  val_6._value._obj.Item["AVGEggs"]);
            val_92 = 1152921516630043280;
            if((val_6._value._obj.ContainsKey(key:  "AVGSuper1")) != false)
        {
                .且丆七下且丐丁与丌 = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_6._value._obj.Item["AVGSuper1"], 丝七丄丛丂丒丘不丛:  ',');
            val_92 = 1152921516630043280;
        }
        
            if((val_6._value._obj.ContainsKey(key:  "AVGSuper2")) != false)
        {
                .丘丙丌丂丕丞丏丁丒 = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_6._value._obj.Item["AVGSuper2"], 丝七丄丛丂丒丘不丛:  ',');
            val_92 = 1152921516630043280;
        }
        
        }
        
            if((val_6._value._obj.ContainsKey(key:  "LOWGems")) != false)
        {
                .丛下丅丘丞丙万丟与 = 0;
            .业专丟丒丆丐一丁丏 = 0;
            .丛且丕丛丂世下一丂 = 0;
            new TournamentController.七丗三上丗下丄三丛() = new System.Object();
            .丄丙丕不七丈丝业丟 = new TournamentController.七丗三上丗下丄三丛();
            .丂丐下丕丄专丞世丘 = 0;
            bool val_76 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["LOWGems"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367817136].下丅丌丌丆不东专丁);
            bool val_79 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.Item["LOWCoins"], 丙业与丙丗丝不丈东: out  (TournamentController.七丗三上丗下丄三丛)[1152921539367817136].一七东丑丘世丑丙不);
            val_91 = val_6._value._obj.Item["LOWEggs"];
            .三万万丒丏丒不丐丙 = TournamentController.东一丕上世与不丈丟(丒东丝业下七丆丙丛:  val_91);
            val_92 = 1152921516630043280;
            if((val_6._value._obj.ContainsKey(key:  "LOWSuper1")) != false)
        {
                val_91 = val_6._value._obj.Item["LOWSuper1"];
            .且丆七下且丐丁与丌 = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_91, 丝七丄丛丂丒丘不丛:  ',');
        }
        
            if((val_6._value._obj.ContainsKey(key:  "LOWSuper2")) != false)
        {
                .丘丙丌丂丕丞丏丁丒 = Rilisoft.OfferItem.丂丂且丝丆丄丘丙丝(丞丕丒专一下丙业上:  val_6._value._obj.Item["LOWSuper2"], 丝七丄丛丂丒丘不丛:  ',');
        }
        
        }
        
        }
        
        }
        
        label_85:
        if((401060672 & 1) != 0)
        {
            goto label_89;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<七丙丄丁七丑丛丙丄>)val_89;
        label_1:
        val_89 = 0;
        return (System.Collections.Generic.List<七丙丄丁七丑丛丙丄>)val_89;
    }
    private static string 东一丕上世与不丈丟(string 丒东丝业下七丆丙丛)
    {
        var val_7;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丒东丝业下七丆丙丛)) == true)
        {
                return (string)System.String.alignConst;
        }
        
        string val_2 = 丒东丝业下七丆丙丛.ToLower();
        if((System.String.op_Equality(a:  val_2, b:  "wood")) != false)
        {
                val_7 = "wooden";
        }
        else
        {
                string val_5 = ((System.String.op_Equality(a:  val_2, b:  "gold")) != true) ? "golden" : (val_2);
        }
        
        if((System.String.op_Inequality(a:  val_5, b:  "none")) == false)
        {
                return (string)System.String.alignConst;
        }
        
        return System.String.Format(format:  "egg_tournament_{0}", arg0:  val_5);
    }
    private static TournamentController.七丗三上丗下丄三丛 业丛丐七与丆不丙丆(int 且七丙丁与丌丗与上, int 丝丞且丘丝丙业丏东, int 专丂丌丝下丙丁丌丞, System.Collections.Generic.List<TournamentController.七丙丄丁七丑丛丙丄> 丟上丞丗与一丒不上)
    {
        var val_5;
        var val_6;
        .专丂丌丝下丙丁丌丞 = 专丂丌丝下丙丁丌丞;
        if((System.Linq.Enumerable.FirstOrDefault<七丙丄丁七丑丛丙丄>(source:  丟上丞丗与一丒不上, predicate:  new System.Func<七丙丄丁七丑丛丙丄, System.Boolean>(object:  new TournamentController.丟东丗丒丝丕丅丆东(), method:  System.Boolean TournamentController.丟东丗丒丝丕丅丆东::丈丞丌且世丈丝丂丈(TournamentController.七丙丄丁七丑丛丙丄 东七上世万下丗丄丛)))) == null)
        {
            goto label_2;
        }
        
        int val_5 = val_3.专且与丏丝与上丟丕;
        if(val_5 >= 且七丙丁与丌丗与上)
        {
            goto label_3;
        }
        
        label_2:
        val_5 = 0;
        return (七丗三上丗下丄三丛)val_5;
        label_3:
        if(val_3.丅丘丝丂万丟丄东丟 >= 且七丙丁与丌丗与上)
        {
                if(val_3.一丗丁丙上丟三丅丗 <= 丝丞且丘丝丙业丏东)
        {
            goto label_6;
        }
        
        }
        
        val_5 = val_5 - val_3.丐丄上丂专七丙专丝;
        var val_4 = (val_5 >= 且七丙丁与丌丗与上) ? (1 + 1) : 1;
        goto label_7;
        label_6:
        val_6 = 3;
        label_7:
        val_5 = mem[val_3.丅丘丝丂万丟丄东丟 + 8];
        val_5 = val_3.丅丘丝丂万丟丄东丟 + 8;
        mem2[0] = 且七丙丁与丌丗与上;
        return (七丗三上丗下丄三丛)val_5;
    }
    public TournamentController()
    {
    
    }
    private static TournamentController()
    {
        var val_8;
        TournamentController.万与世一东丆丙丙一 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "DivisionsTournament.LastViewedLeagueAndPlaceInitializedKey_v3");
        TournamentController.丄丄东丈丐上丟丂丑 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "DivisionsTournament.LastViewedPlaceKey_v3");
        TournamentController.丙丘丕丙丑专丗丈丛 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "DivisionsTournament.LastViewedLeagueKey_v3");
        val_8 = null;
        val_8 = null;
        TournamentController.丗丗丒丁下且丘且丒 = new System.Action(object:  TournamentController.<>c.<>9, method:  System.Void TournamentController.<>c::专业下丄丏丂七不丒());
        TournamentController.下世丄三且七东丅丞 = new System.Action(object:  TournamentController.<>c.<>9, method:  System.Void TournamentController.<>c::七丝世与三丙丐万专());
        TournamentController.丛丝丆丝丏七丗下丄 = new System.Action(object:  TournamentController.<>c.<>9, method:  System.Void TournamentController.<>c::丗世丞丛一丐七七上());
        TournamentController.丞丏世上世丙丄三丄 = new System.Action<TournamentReward>(object:  TournamentController.<>c.<>9, method:  System.Void TournamentController.<>c::丝不丗三丛丅丐丗丝(TournamentReward 世丗丈丗丂业丙一不));
    }

}
