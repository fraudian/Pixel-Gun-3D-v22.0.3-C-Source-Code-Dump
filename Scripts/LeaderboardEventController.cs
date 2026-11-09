using UnityEngine;
internal sealed class LeaderboardEventController : PGBehaviour
{
    // Fields
    internal static LeaderboardEventController 丆丕丝丒不丙且丐丗;
    private static System.Action<int> 丘丛业丅丄与丕丟丗;
    private static System.Action 万丒东万不丑丗丞丛;
    private const string 丑丙丕丙丏不丁七东 = "leaderboard_event_tournament";
    private const string 丛丆丗万与丘上丗万 = "leaderboard_event_tournament_last_request_full_data";
    private const string 东丅丆不丆东丟业专 = "leaderboard_event_tournament_no_issued_rewards";
    private const float 丈丂丗七万七丅上丄 = 5;
    private const float 丑丐丄丆丛丁丟丗丅 = 1200;
    private int 下丗丏丑丛上丟且丒;
    private System.Collections.Generic.List<LeaderboardEventTournament> 丁七丈丌丈丂世万下;
    private System.Collections.Generic.List<LeaderboardEventController.RewardParameters> 丏丁且丒世丂丘三业;
    private System.Collections.Generic.Dictionary<int, UnityEngine.Coroutine> 丐丏世与三丒业丆丏;
    private System.Collections.Generic.Dictionary<int, int> 丁世丏与东下万丕三;
    private UnityEngine.Coroutine 丅东三丒且丅丄丐丒;
    
    // Properties
    private string 丄丒与与丁丌东丆七 { get; }
    
    // Methods
    internal static void 万丅丞丐丒世专丆丅(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LeaderboardEventController.丘丛业丅丄与丕丟丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LeaderboardEventController.丘丛业丅丄与丕丟丗 != 1152921505173942280);
    
    }
    internal static void 不丛丞丌三丗丁丄东(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LeaderboardEventController.丘丛业丅丄与丕丟丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LeaderboardEventController.丘丛业丅丄与丕丟丗 != 1152921505173942280);
    
    }
    internal static void 丆业丑三一丝丒一丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  LeaderboardEventController.万丒东万不丑丗丞丛, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LeaderboardEventController.万丒东万不丑丗丞丛 != 1152921505173942288);
    
    }
    internal static void 丂且丁世一不丈丑丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  LeaderboardEventController.万丒东万不丑丗丞丛, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(LeaderboardEventController.万丒东万不丑丗丞丛 != 1152921505173942288);
    
    }
    private void 万专业一丐东丆万业()
    {
        this.下丗丏丑丛上丟且丒 = 丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}.{1}", arg0:  "leaderboard_event_tournament_last_request_full_data", arg1:  this.丏东上丛丐丒丈世丞()), 丞丌丑丛上丕丙丕下:  0);
    }
    private void 不三世上丄丛世丄丈(int 丙业与丙丗丝不丈东)
    {
        this.下丗丏丑丛上丟且丒 = 丙业与丙丗丝不丈东;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}.{1}", arg0:  "leaderboard_event_tournament_last_request_full_data", arg1:  this.丏东上丛丐丒丈世丞()), 下下丏一丙不丘丌丞:  this.下丗丏丑丛上丟且丒, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丐丒专世下丑丁东丛()
    {
        this.丁七丈丌丈丂世万下 = 0;
        string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}.{1}", arg0:  "leaderboard_event_tournament", arg1:  this.丏东上丛丐丒丈世丞()), 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if(((System.String.IsNullOrEmpty(value:  val_3)) != true) && ((UnityEngine.JsonUtility.FromJson<LeaderboardEventDataHandler>(json:  val_3)) != null))
        {
                this.丁七丈丌丈丂世万下 = val_5.Data;
            if(val_5.Data != null)
        {
                return;
        }
        
        }
        else
        {
                if(this.丁七丈丌丈丂世万下 != null)
        {
                return;
        }
        
        }
        
        this.丁七丈丌丈丂世万下 = new System.Collections.Generic.List<LeaderboardEventTournament>();
    }
    private void 丅丆丙业下丙且丌丙()
    {
        this.丏丁且丒世丂丘三业 = 0;
        string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}.{1}", arg0:  "leaderboard_event_tournament_no_issued_rewards", arg1:  this.丏东上丛丐丒丈世丞()), 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) != true) && ((UnityEngine.JsonUtility.FromJson<RewardDataHandler>(json:  val_3)) != null))
        {
                this.丏丁且丒世丂丘三业 = val_5.Data;
            if(val_5.Data != null)
        {
                return;
        }
        
        }
        else
        {
                if(this.丏丁且丒世丂丘三业 != null)
        {
                return;
        }
        
        }
        
        this.丏丁且丒世丂丘三业 = new System.Collections.Generic.List<RewardParameters>();
    }
    private string 丏东上丛丐丒丈世丞()
    {
        return FriendsController.不丝丕丒丂丆丘丙丙();
    }
    internal System.Collections.Generic.List<LeaderboardEventController.RewardParameters> 丛丑丐三三丄与丞丗()
    {
        return (System.Collections.Generic.List<RewardParameters>)this.丏丁且丒世丂丘三业;
    }
    private static string 丞丘东丗三丒丂七丞(string 与丌丞丞丅丒丟一一)
    {
        null = null;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  与丌丞丞丅丒丟一一)) == false)
        {
                return 丄丛丏丄不一丆丐丑.丙不东丁东下丁丐且 + "?action="("?action=") + 与丌丞丞丅丒丟一一;
        }
        
        return (string)丄丛丏丄不一丆丐丑.丙不东丁东下丁丐且;
    }
    private void Awake()
    {
        if(LeaderboardEventController.丑丐丄丆丛丁丟丗丅 != 0)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this);
            return;
        }
        
        LeaderboardEventController.丑丐丄丆丛丁丟丗丅 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        this.东丘丛丑丈丒丞且万();
        PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.三丘三丑七万丏世三(丙业与丙丗丝不丈东:  new 丅丑丘七且丄丂丘下.丟与三丆三丙丁一丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void LeaderboardEventController::丂东不丛丈三下丑七(int 丟丟丄专上丟丁丐丝)));
        PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.且丞丝丕丛上上丘丈(丙业与丙丗丝不丈东:  new 丅丑丘七且丄丂丘下.丟与三丆三丙丁一丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void LeaderboardEventController::丂东不丛丈三下丑七(int 丟丟丄专上丟丁丐丝)));
        专丈专业丆且且业下.丄与东丌丟下丑与丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardEventController::东丘丛丑丈丒丞且万()));
        专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardEventController::东丘丛丑丈丒丞且万()));
    }
    private void 东丘丛丑丈丒丞且万()
    {
        var val_4;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丐丏世与三丒业丆丏.GetEnumerator();
        label_6:
        if(((-1800445792) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        CoroutineRunner.Instance.StopCoroutine(routine:  val_5._value._obj);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丐丒专世下丑丁东丛();
        this.万专业一丐东丆万业();
        this.丅丆丙业下丙且丌丙();
        if(this.丅东三丒且丅丄丐丒 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丅东三丒且丅丄丐丒);
        }
        
        this.丅东三丒且丅丄丐丒 = CoroutineRunner.Instance.StartCoroutine(routine:  this.上世上东与与丞丗一());
    }
    private System.Collections.IEnumerator 上世上东与与丞丗一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LeaderboardEventController.丒丐不世丕专丕上丑();
    }
    private void OnDestroy()
    {
        PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.三丘三丑七万丏世三(丙业与丙丗丝不丈东:  new 丅丑丘七且丄丂丘下.丟与三丆三丙丁一丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void LeaderboardEventController::丂东不丛丈三下丑七(int 丟丟丄专上丟丁丐丝)));
        专丈专业丆且且业下.丄与东丌丟下丑与丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeaderboardEventController::东丘丛丑丈丒丞且万()));
    }
    internal int 丁上丁专东丌东丐丞(int 丟丟丄专上丟丁丐丝)
    {
        System.Collections.Generic.List<TournamentPlayer> val_6;
        var val_7;
        if((this.不专万丅世万世丙丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝)) == null)
        {
            goto label_3;
        }
        
        label_9:
        val_6 = val_1._topPlayers;
        if(0 >= val_6.Count)
        {
            goto label_3;
        }
        
        TournamentPlayer val_3 = val_1._topPlayers.Item[0];
        val_6 = val_3.id;
        val_7 = 0 + 1;
        if((val_6.Equals(value:  FriendsController.不丝丕丒丂丆丘丙丙())) == false)
        {
            goto label_9;
        }
        
        return (int)val_7;
        label_3:
        val_7 = 0;
        return (int)val_7;
    }
    internal void 丂业丂业万业万丏丆(int 丟丟丄专上丟丁丐丝, ref int 且丒丛与丞世丙丕丌, ref int 万且丒下丕丝专丟上)
    {
        string val_7;
        var val_8;
        int val_9;
        val_8 = this.不专万丅世万世丙丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        if(val_8 == null)
        {
                return;
        }
        
        val_9 = 1;
        goto label_2;
        label_10:
        TournamentPlayer val_2 = val_1._topPlayers.Item[-1799838336];
        val_7 = val_2.id;
        if((val_7.Equals(value:  FriendsController.不丝丕丒丂丆丘丙丙())) == true)
        {
            goto label_8;
        }
        
        val_9 = 2;
        label_2:
        val_7 = val_1._topPlayers;
        if((val_9 - 1) < val_7.Count)
        {
            goto label_10;
        }
        
        return;
        label_8:
        val_8 = val_1._topPlayers.Item[-1799838336];
        万且丒下丕丝专丟上 = val_7.score;
        且丒丛与丞世丙丕丌 = val_9;
    }
    internal void 丗万业不丛与丕丟丒(int 丟丟丄专上丟丁丐丝)
    {
        this.丝丐七丐丒下丒丕世(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        this.丛丝丙丛世丈丙丘与(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        this.丌专七丗丛丛丆丕丁(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
    }
    internal System.Collections.Generic.List<丂丟丙丌丞七东丑丁> 与丝丁丘世丏丆丏丙(int 丟丟丄专上丟丁丐丝, ref TournamentPlayer 丒丒且丟东七世丐丆, ref int 七丂一与丏丂七万丛, ref int 丅丕世与丁丘丆专三)
    {
        var val_9;
        var val_24;
        int val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_24 = 1152921537167133632;
        val_25 = 丟丟丄专上丟丁丐丝;
        val_26 = 1152921505052479488;
        val_27 = static_value_081DACA8;
        val_27 = static_value_081DACA8;
        val_28 = 0;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return (System.Collections.Generic.List<丂丟丙丌丞七东丑丁>)val_28;
        }
        
        val_29 = static_value_081DACA8;
        val_29 = static_value_081DACA8;
        val_28 = 0;
        if((static_value_081DACA8 + 184 + 16 + 48) == 0)
        {
                return (System.Collections.Generic.List<丂丟丙丌丞七东丑丁>)val_28;
        }
        
        val_30 = static_value_081DACA8;
        val_30 = static_value_081DACA8;
        val_28 = 0;
        if((static_value_081DACA8 + 184 + 16 + 48 + 136) == 0)
        {
                return (System.Collections.Generic.List<丂丟丙丌丞七东丑丁>)val_28;
        }
        
        val_31 = static_value_081DACA8;
        val_31 = static_value_081DACA8;
        if((this.不专万丅世万世丙丑(丟丟丄专上丟丁丐丝:  val_25)) == null)
        {
            goto label_25;
        }
        
        System.Collections.Generic.List<丂丟丙丌丞七东丑丁> val_5 = null;
        val_28 = val_5;
        val_5 = new System.Collections.Generic.List<丂丟丙丌丞七东丑丁>();
        val_32 = static_value_081DACA8;
        val_32 = static_value_081DACA8;
        List.Enumerator<T> val_7 = static_value_081DACA8 + 184 + 16 + 48 + 136 + 408.一丒不业丁且丒三不().GetEnumerator();
        val_25 = 1152921537167014272;
        val_26 = 1152921537167015296;
        label_57:
        if(((-1799503904) & 1) == 0)
        {
            goto label_33;
        }
        
        string val_10 = val_9.丐丏七丌丕丗业且上();
        new 丂丟丙丌丞七东丑丁() = new 丂丟丙丌丞七东丑丁();
        .七丑一丙丂丘且丏丆 = 0 + 1;
        .丂丌丕与业丛专丗专 = val_10.三丛丗丛业不丂丐且();
        int val_24 = 0;
        label_53:
        val_24 = val_24 + 1;
        if(((val_24 < val_10.丏万与万业丈丄东东()) || (((val_24 & 2147483648) != 0) || (val_24 >= val_10.丘丄丅丑三丙七与丐()))) || (val_24 >= val_4._topPlayers.Count))
        {
            goto label_42;
        }
        
        TournamentPlayer val_17 = val_4._topPlayers.Item[0];
        if((val_17.id.Equals(value:  FriendsController.不丝丕丒丂丆丘丙丙())) != false)
        {
                七丂一与丏丂七万丛 = val_5.Count;
            丒丒且丟东七世丐丆 = val_4._topPlayers.Item[0];
            丅丕世与丁丘丆专三 = val_24;
        }
        
        mem[1152921537167154080].Add(item:  val_4._topPlayers.Item[0]);
        goto label_53;
        label_42:
        if(mem[1152921537167154080].Count < 1)
        {
            goto label_57;
        }
        
        val_5.Add(item:  new 丂丟丙丌丞七东丑丁());
        goto label_57;
        label_25:
        val_28 = 0;
        return (System.Collections.Generic.List<丂丟丙丌丞七东丑丁>)val_28;
        label_33:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<丂丟丙丌丞七东丑丁>)val_28;
    }
    internal void 丏丑万丌丘万三丙与(int 丟丟丄专上丟丁丐丝 = -1)
    {
        UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  this.三专丐丂丒丗丌丅丝(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝));
    }
    private System.Collections.IEnumerator 三专丐丂丒丗丌丅丝(int 丟丟丄专上丟丁丐丝)
    {
        LeaderboardEventController.专丑丆丕不不世丏业 val_1 = new LeaderboardEventController.专丑丆丕不不世丏业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丟丟丄专上丟丁丐丝 = 丟丟丄专上丟丁丐丝;
        return (System.Collections.IEnumerator)val_1;
    }
    private System.Collections.IEnumerator 丟三丂丒丏不丌丝与(int 丟丟丄专上丟丁丐丝, bool 丛专下丞丒丛下下与 = True)
    {
        LeaderboardEventController.不丁丈一丅丏上丘丁 val_1 = new LeaderboardEventController.不丁丈一丅丏上丘丁();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丟丟丄专上丟丁丐丝 = 丟丟丄专上丟丁丐丝;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丟丟丄专上丟丁丐丝;
        }
        
        .丛专下丞丒丛下下与 = 丛专下丞丒丛下下与;
        return (System.Collections.IEnumerator)val_1;
    }
    private UnityEngine.WWW 业丁丛丕不丗丘七不(int 丟丟丄专上丟丁丐丝, string 丟丏东丅且丅丌一上, int 一丏一世丘丐丁丄丟)
    {
        var val_9;
        UnityEngine.WWWForm val_1 = new UnityEngine.WWWForm();
        val_1.AddField(fieldName:  "action", value:  "get_event_leaderboard");
        val_9 = null;
        val_9 = null;
        val_1.AddField(fieldName:  "app_version", value:  System.String.Format(format:  "{0}:{1}", arg0:  ProtocolListGetter.丅三专丐丗丅与丆丑(), arg1:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒));
        val_1.AddField(fieldName:  "uniq_id", value:  FriendsController.不丝丕丒丂丆丘丙丙());
        string val_5 = FriendsController.三且丞七丗东不丘丝(七丐丅专且专七三丆:  "get_event_leaderboard", 不丒三业下丑不丞业:  0);
        if(val_1 != null)
        {
                val_1.AddField(fieldName:  "auth", value:  val_5);
            val_1.AddField(fieldName:  "leaderboard_id", value:  丟丏东丅且丅丌一上);
            val_1.AddField(fieldName:  "timestamp", i:  一丏一世丘丐丁丄丟);
        }
        else
        {
                val_1.AddField(fieldName:  "auth", value:  val_5);
            val_1.AddField(fieldName:  "leaderboard_id", value:  丟丏东丅且丅丌一上);
            val_1.AddField(fieldName:  "timestamp", i:  一丏一世丘丐丁丄丟);
        }
        
        val_1.AddField(fieldName:  "event_id", i:  丟丟丄专上丟丁丐丝);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return (UnityEngine.WWW)Rilisoft.与丄丁丄丙丞下下丙.与丛七丞且专丄丛世(七丙不丅丛丘丗万与:  LeaderboardEventController.丞丘东丗三丒丂七丞(与丌丞丞丅丒丟一一:  "get_event_leaderboard"), 丛丁且丏丁丄上上丄:  val_1, 丐丆丐七一上专三丑:  "");
        }
        
        val_1.AddField(fieldName:  "test", i:  1);
        return (UnityEngine.WWW)Rilisoft.与丄丁丄丙丞下下丙.与丛七丞且专丄丛世(七丙不丅丛丘丗万与:  LeaderboardEventController.丞丘东丗三丒丂七丞(与丌丞丞丅丒丟一一:  "get_event_leaderboard"), 丛丁且丏丁丄上上丄:  val_1, 丐丆丐七一上专三丑:  "");
    }
    private System.Collections.IEnumerator 丙丌不一丁丑丂下不(UnityEngine.WWW 东丞丒丙世丏三下丟, int 且丙丂丕丆丛业丌不)
    {
        LeaderboardEventController.丕七一下专丆与丟万 val_1 = new LeaderboardEventController.丕七一下专丆与丟万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .东丞丒丙世丏三下丟 = 东丞丒丙世丏三下丟;
        }
        else
        {
                mem[48] = this;
            mem[32] = 东丞丒丙世丏三下丟;
        }
        
        .且丙丂丕丆丛业丌不 = 且丙丂丕丆丛业丌不;
        return (System.Collections.IEnumerator)val_1;
    }
    private bool 一丞丞三专丐丗三丌(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄, int 一丏一世丘丐丁丄丟)
    {
        var val_3;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = 一丐丗丁丞丆丅丟丄;
        List.Enumerator<T> val_1 = val_12.GetEnumerator();
        val_13 = 1152921516630043280;
        val_14 = 0;
        label_20:
        if(((-1798618240) & 1) == 0)
        {
            goto label_2;
        }
        
        val_12 = val_3.丐丏七丌丕丗业且上();
        UnityEngine.Debug.LogError(message:  "[LeaderboardEvent] --------- updDictionary  == null");
        goto label_20;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_14 & 1) == 0)
        {
            
        }
        else
        {
                if(LeaderboardEventController.万丒东万不丑丗丞丛 != null)
        {
                LeaderboardEventController.万丒东万不丑丗丞丛.Invoke();
        }
        
        }
        
        val_15 = 1;
        return (bool)val_15;
    }
    private bool 丆丗丏丁丕下丁丘丏(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅)
    {
        int val_13;
        var val_14;
        object val_15;
        if((不丅丕丏下丏万丁丅.ContainsKey(key:  "event_id")) == false)
        {
            goto label_2;
        }
        
        int val_3 = System.Convert.ToInt32(value:  不丅丕丏下丏万丁丅.Item["event_id"]);
        val_13 = "place_player";
        if((不丅丕丏下丏万丁丅.ContainsKey(key:  "place_player")) == false)
        {
            goto label_7;
        }
        
        int val_6 = System.Convert.ToInt32(value:  不丅丕丏下丏万丁丅.Item["place_player"]);
        val_13 = this.丏一丝且丟丈丑世丅(丟丟丄专上丟丁丐丝:  val_3);
        if((不丅丕丏下丏万丁丅.ContainsKey(key:  "reward_config")) == false)
        {
            goto label_12;
        }
        
        object val_9 = 不丅丕丏下丏万丁丅.Item["reward_config"];
        val_14 = 0;
        goto label_18;
        label_2:
        val_15 = "[LeaderboardEvent] --------- GetRequestCoroutine not key event_id";
        goto label_24;
        label_7:
        val_15 = "[LeaderboardEvent] --------- GetRequestCoroutine not key place_player";
        goto label_24;
        label_12:
        val_15 = "[LeaderboardEvent] --------- GetRequestCoroutine not key reward_config";
        label_24:
        UnityEngine.Debug.LogError(message:  val_15);
        return false;
        label_18:
        .EventId = val_3;
        .Place = val_6;
        .Score = val_13;
        .RewardConfig = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.丑丑丙专丙丌丛丑丗(东丛丁丛丈丞丕下丄:  null, 且丒丛与丞世丙丕丌:  val_6);
        this.丏丁且丒世丂丘三业.Add(item:  new LeaderboardEventController.RewardParameters());
        this.万丗不下丌一丕与丟();
        return false;
    }
    private bool 丁世不丑下与业丆丂(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, int 一丏一世丘丐丁丄丟, int 世不下丟世一丝丐丗)
    {
        int val_15;
        System.Collections.Generic.List<T> val_16;
        object val_17;
        var val_18;
        val_15 = "season_end";
        if((不丅丕丏下丏万丁丅.ContainsKey(key:  "season_end")) == false)
        {
            goto label_2;
        }
        
        val_16 = 1152921516622706448;
        val_15 = System.Convert.ToInt32(value:  不丅丕丏下丏万丁丅.Item["season_end"]);
        if((不丅丕丏下丏万丁丅.ContainsKey(key:  "leaderboard_id")) == false)
        {
            goto label_7;
        }
        
        string val_6 = System.Convert.ToString(value:  不丅丕丏下丏万丁丅.Item["leaderboard_id"]);
        System.Collections.Generic.List<TournamentPlayer> val_7 = null;
        val_16 = val_7;
        val_7 = new System.Collections.Generic.List<TournamentPlayer>();
        .id = FriendsController.不丝丕丒丂丆丘丙丙();
        .nickname = ProfileController.丆三丂丂丆上丆丕专();
        .score = 0;
        val_7.Add(item:  new TournamentPlayer());
        bool val_11 = val_6.Equals(value:  System.String.alignConst);
        if(val_11 != true)
        {
                val_11.丐丝不上丛丐世丘丝(不丅丕丏下丏万丁丅:  不丅丕丏下丏万丁丅, 下上丐丆丝丟丝丒不:  "score_players", 与丝丂丏丘丛丒丄丘: ref  val_7);
            val_11.丐丝不上丛丐世丘丝(不丅丕丏下丏万丁丅:  不丅丕丏下丏万丁丅, 下上丐丆丝丟丝丒不:  "data_players", 与丝丂丏丘丛丒丄丘: ref  val_7);
        }
        
        LeaderboardEventTournament val_13 = this.不专万丅世万世丙丑(丟丟丄专上丟丁丐丝:  世不下丟世一丝丐丗);
        if(val_13 == null)
        {
            goto label_19;
        }
        
        val_13.不下丌丆东丑丈丕丝(丞丅上丏丂且下丅与:  val_6, 世且三七世丂丈丆一:  一丏一世丘丐丁丄丟, 丟不上三世丁丁丈专:  val_15, 丗丗丁丌且丂丌世与:  val_7, 东丗丌七丌不一业丟:  val_11.丄不丆丝丙丕丟丄丞(不丅丕丏下丏万丁丅:  不丅丕丏下丏万丁丅));
        if(LeaderboardEventController.丘丛业丅丄与丕丟丗 != null)
        {
                LeaderboardEventController.丘丛业丅丄与丕丟丗.Invoke(obj:  世不下丟世一丝丐丗);
        }
        
        this.万下丁七世丅与下专();
        goto label_29;
        label_2:
        val_17 = "[LeaderboardEvent] --------- GetRequestCoroutine not key season_end";
        goto label_24;
        label_7:
        val_17 = "[LeaderboardEvent] --------- GetRequestCoroutine not key leaderboard_id";
        label_24:
        UnityEngine.Debug.LogError(message:  val_17);
        val_18 = 0;
        return (bool)val_18;
        label_19:
        this.丁七丈丌丈丂世万下.Add(item:  new LeaderboardEventTournament(丞丅上丏丂且下丅与:  val_6, 世且三七世丂丈丆一:  一丏一世丘丐丁丄丟, 丟不上三世丁丁丈专:  val_15, 丟丟丄专上丟丁丐丝:  世不下丟世一丝丐丗, 丗丗丁丌且丂丌世与:  val_7));
        this.万下丁七世丅与下专();
        if(LeaderboardEventController.丘丛业丅丄与丕丟丗 != null)
        {
                LeaderboardEventController.丘丛业丅丄与丕丟丗.Invoke(obj:  世不下丟世一丝丐丗);
        }
        
        label_29:
        val_18 = 1;
        return (bool)val_18;
    }
    private void 丐丝不上丛丐世丘丝(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅, string 下上丐丆丝丟丝丒不, ref System.Collections.Generic.List<TournamentPlayer> 与丝丂丏丘丛丒丄丘)
    {
        var val_5;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        val_22 = 1152921537168585424;
        string val_21 = 下上丐丆丝丟丝丒不;
        val_23 = 不丅丕丏下丏万丁丅;
        if((val_23.ContainsKey(key:  val_21)) == false)
        {
                return;
        }
        
        object val_2 = val_23.Item[val_21];
        if(val_2 == null)
        {
                return;
        }
        
        val_21 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        List.Enumerator<T> val_3 = val_21.GetEnumerator();
        label_46:
        label_15:
        if(((-1798052240) & 1) == 0)
        {
            goto label_8;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        UnityEngine.Debug.LogError(message:  "[LeaderboardEvent] --------- playerScore wrong format");
        goto label_15;
        label_30:
        if(((-1798052272) & 1) == 0)
        {
            goto label_27;
        }
        
        string val_17 = val_5.丐丏七丌丕丗业且上();
        if((val_17.m_stringLength.Equals(value:  null)) == false)
        {
            goto label_30;
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                mem2[0] = 0;
        }
        
        if(val_24 >= 1)
        {
                mem2[0] = val_24;
        }
        
        val_25 = 0;
        val_26 = 271;
        val_27 = 1;
        goto label_33;
        label_27:
        val_25 = 0;
        val_26 = 271;
        val_27 = 0;
        label_33:
        val_25 = val_25 + 1;
        mem2[0] = 271;
        val_28 = public System.Void List.Enumerator<TournamentPlayer>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_23 = val_25;
        if((val_23 == 1) || ((1152921537168532992 + ((val_25 + 1)) << 2) != 271))
        {
            goto label_40;
        }
        
        var val_22 = 0;
        val_22 = val_22 ^ (val_23 >> 31);
        val_23 = val_23 + val_22;
        if(( & 1) != 0)
        {
            goto label_46;
        }
        
        goto label_42;
        label_40:
        if(val_5 != 0)
        {
                val_28 = 0;
        }
        
        if(( & 1) != 0)
        {
            goto label_46;
        }
        
        label_42:
        new TournamentPlayer() = new TournamentPlayer(且丙不丟业七万东丗:  null, 丂且丑世一一不万世:  0, 与专且三丛不丄丗丂:  0, 且丒丛与丞世丙丕丌:  0);
        与丝丂丏丘丛丒丄丘.Add(item:  new TournamentPlayer());
        goto label_46;
        label_8:
        val_29 = 0;
        val_23 = 0;
        val_22 = val_23 + 1;
        mem2[0] = 321;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921537168532992 + (((val_25 + 1) + (0 ^ ((int)(val_25 + 1)) >> 31))) << 2) == 321)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private System.Collections.Generic.List<string> 丄不丆丝丙丕丟丄丞(System.Collections.Generic.Dictionary<string, object> 不丅丕丏下丏万丁丅)
    {
        var val_8;
        var val_12;
        var val_13;
        if((不丅丕丏下丏万丁丅.ContainsKey(key:  "removed_players")) != false)
        {
                object val_2 = 不丅丕丏下丏万丁丅.Item["removed_players"];
            val_12 = 0;
        }
        else
        {
                System.Collections.Generic.List<System.String> val_3 = null;
            val_13 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            return (System.Collections.Generic.List<System.String>)val_13;
        }
        
        System.Collections.Generic.List<System.String> val_5 = null;
        val_13 = val_5;
        val_5 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_6 = GetEnumerator();
        label_13:
        if(((-1797866432) & 1) == 0)
        {
            goto label_9;
        }
        
        val_5.Add(item:  System.Convert.ToString(value:  val_8.丐丏七丌丕丗业且上()));
        goto label_13;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<System.String>)val_13;
    }
    internal void 丆丂世丟上且上丆丆(int 丟丟丄专上丟丁丐丝, int 万且丒下丕丝专丟上)
    {
        LeaderboardEventTournament val_13 = this.不专万丅世万世丙丑(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        if(val_13 == null)
        {
            goto label_1;
        }
        
        if((val_13.丆丂世丟上且上丆丆(万且丒下丕丝专丟上:  万且丒下丕丝专丟上)) == true)
        {
            goto label_2;
        }
        
        object[] val_3 = new object[2];
        val_3[0] = 丟丟丄专上丟丁丐丝;
        val_3[1] = 万且丒下丕丝专丟上;
        UnityEngine.Debug.LogFormat(format:  "[LeaderboardEvent] --------- UpdateMyPlayerScore no update score event id: {0} value: {1}", args:  val_3);
        return;
        label_1:
        System.Collections.Generic.List<TournamentPlayer> val_4 = new System.Collections.Generic.List<TournamentPlayer>();
        val_4.Add(item:  new TournamentPlayer(且丙不丟业七万东丗:  FriendsController.不丝丕丒丂丆丘丙丙(), 丂且丑世一一不万世:  ProfileController.丆三丂丂丆上丆丕专(), 与专且三丛不丄丗丂:  万且丒下丕丝专丟上, 且丒丛与丞世丙丕丌:  0));
        LeaderboardEventTournament val_8 = null;
        val_13 = val_8;
        val_8 = new LeaderboardEventTournament(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丗丗丁丌且丂丌世与:  val_4);
        this.丁七丈丌丈丂世万下.Add(item:  val_8);
        label_2:
        CoroutineRunner val_10 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_12 = val_10.StartCoroutine(routine:  val_10.丕丂丏丅丏万丁下东(东丞丒丙世丏三下丟:  this.丁七丈丌丈丂世万下.丞丕一丏专下丅专世(丄丝丒丁丅丅丏下不:  val_8, 万且丒下丕丝专丟上:  万且丒下丕丝专丟上)));
        this.丂丗丌丞丛丂丁丁丘(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 万且丒下丕丝专丟上:  万且丒下丕丝专丟上);
        this.万下丁七世丅与下专();
    }
    private UnityEngine.WWW 丞丕一丏专下丅专世(LeaderboardEventTournament 丄丝丒丁丅丅丏下不, int 万且丒下丕丝专丟上)
    {
        var val_9;
        UnityEngine.WWWForm val_1 = new UnityEngine.WWWForm();
        val_1.AddField(fieldName:  "action", value:  "update_event_score");
        val_9 = null;
        val_9 = null;
        val_1.AddField(fieldName:  "app_version", value:  System.String.Format(format:  "{0}:{1}", arg0:  ProtocolListGetter.丅三专丐丗丅与丆丑(), arg1:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒));
        val_1.AddField(fieldName:  "uniq_id", value:  FriendsController.不丝丕丒丂丆丘丙丙());
        val_1.AddField(fieldName:  "auth", value:  FriendsController.三且丞七丗东不丘丝(七丐丅专且专七三丆:  "update_event_score", 不丒三业下丑不丞业:  0));
        val_1.AddField(fieldName:  "leaderboard_id", value:  丄丝丒丁丅丅丏下不._id);
        if(val_1 != null)
        {
                val_1.AddField(fieldName:  "event_id", i:  丄丝丒丁丅丅丏下不._eventId);
        }
        else
        {
                val_1.AddField(fieldName:  "event_id", i:  丄丝丒丁丅丅丏下不._eventId);
        }
        
        val_1.AddField(fieldName:  "score", i:  万且丒下丕丝专丟上);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return (UnityEngine.WWW)Rilisoft.与丄丁丄丙丞下下丙.与丛七丞且专丄丛世(七丙不丅丛丘丗万与:  LeaderboardEventController.丞丘东丗三丒丂七丞(与丌丞丞丅丒丟一一:  "update_event_score"), 丛丁且丏丁丄上上丄:  val_1, 丐丆丐七一上专三丑:  "");
        }
        
        val_1.AddField(fieldName:  "test", i:  1);
        return (UnityEngine.WWW)Rilisoft.与丄丁丄丙丞下下丙.与丛七丞且专丄丛世(七丙不丅丛丘丗万与:  LeaderboardEventController.丞丘东丗三丒丂七丞(与丌丞丞丅丒丟一一:  "update_event_score"), 丛丁且丏丁丄上上丄:  val_1, 丐丆丐七一上专三丑:  "");
    }
    private System.Collections.IEnumerator 丕丂丏丅丏万丁下东(UnityEngine.WWW 东丞丒丙世丏三下丟)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .东丞丒丙世丏三下丟 = 东丞丒丙世丏三下丟;
        return (System.Collections.IEnumerator)new LeaderboardEventController.上上丕丁丒丛丟不东();
    }
    private void 丛丝丙丛世丈丙丘与(int 丟丟丄专上丟丁丐丝)
    {
        System.Collections.Generic.List<LeaderboardEventTournament> val_5 = this.丁七丈丌丈丂世万下;
        if(val_5.Count == 0)
        {
                return;
        }
        
        val_5 = 0;
        goto label_3;
        label_8:
        LeaderboardEventTournament val_2 = this.丁七丈丌丈丂世万下.Item[0];
        if((val_2._eventId.Equals(obj:  丟丟丄专上丟丁丐丝)) == true)
        {
            goto label_6;
        }
        
        val_5 = 1;
        label_3:
        if(val_5 < this.丁七丈丌丈丂世万下.Count)
        {
            goto label_8;
        }
        
        return;
        label_6:
        if(val_5 == 1)
        {
                return;
        }
        
        this.丁七丈丌丈丂世万下.RemoveAt(index:  0);
        this.万下丁七世丅与下专();
    }
    private void 丌专七丗丛丛丆丕丁(int 丟丟丄专上丟丁丐丝)
    {
        if(this.丏丁且丒世丂丘三业 == null)
        {
                return;
        }
        
        RewardParameters val_1 = this.上七与丘丑丑丝丏丐(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝);
        if(val_1 == null)
        {
                return;
        }
        
        bool val_2 = this.丏丁且丒世丂丘三业.Remove(item:  val_1);
        this.万丗不下丌一丕与丟();
    }
    private void 丂东不丛丈三下丑七(int 丟丟丄专上丟丁丐丝)
    {
        System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Coroutine> val_6;
        if((this.上七与丘丑丑丝丏丐(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝)) != null)
        {
                return;
        }
        
        val_6 = this.丐丏世与三丒业丆丏;
        if((val_6.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                return;
        }
        
        this.丐丏世与三丒业丆丏.set_Item(key:  丟丟丄专上丟丁丐丝, value:  CoroutineRunner.Instance.StartCoroutine(routine:  this.一专下丂七不七丈丌(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝)));
    }
    private LeaderboardEventController.RewardParameters 上七与丘丑丑丝丏丐(int 丟丟丄专上丟丁丐丝)
    {
        int val_5;
        var val_6;
        var val_7;
        val_5 = 丟丟丄专上丟丁丐丝;
        val_6 = 0;
        goto label_1;
        label_6:
        RewardParameters val_1 = this.丏丁且丒世丂丘三业.Item[0];
        if((val_1.EventId.Equals(obj:  val_5)) == true)
        {
            goto label_4;
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < this.丏丁且丒世丂丘三业.Count)
        {
            goto label_6;
        }
        
        val_7 = 0;
        return (RewardParameters)val_5.Item[0];
        label_4:
        val_5 = this.丏丁且丒世丂丘三业;
        return (RewardParameters)val_5.Item[0];
    }
    private System.Collections.IEnumerator 一专下丂七不七丈丌(int 丟丟丄专上丟丁丐丝)
    {
        LeaderboardEventController.不与三三上且业丕丘 val_1 = new LeaderboardEventController.不与三三上且业丕丘();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丟丟丄专上丟丁丐丝 = 丟丟丄专上丟丁丐丝;
        return (System.Collections.IEnumerator)val_1;
    }
    private int 丏一丝且丟丈丑世丅(int 丟丟丄专上丟丁丐丝)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = this.丁世丏与东下万丕三;
        if(val_3 == null)
        {
                this.专丅丈丏丑专丗丂且();
            val_3 = this.丁世丏与东下万丕三;
            if(val_3 == null)
        {
            goto label_11;
        }
        
        }
        
        label_11:
        if((val_3.ContainsKey(key:  丟丟丄专上丟丁丐丝)) != false)
        {
                if(0 == 0)
        {
                return val_3.Item[丟丟丄专上丟丁丐丝];
        }
        
            return val_3.Item[丟丟丄专上丟丁丐丝];
        }
        
        object[] val_2 = new object[1];
        val_2[0] = 丟丟丄专上丟丁丐丝;
        UnityEngine.Debug.LogFormat(format:  "[LeaderboardEvent] --------- GetScoreFromSlot dictionaryScores no contains key: {0}", args:  val_2);
        return 0;
    }
    private void 丝丐七丐丒下丒丕世(int 丟丟丄专上丟丁丐丝)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = this.丁世丏与东下万丕三;
        if(val_4 == null)
        {
                this.专丅丈丏丑专丗丂且();
            val_4 = this.丁世丏与东下万丕三;
        }
        
        bool val_1 = val_4.Remove(key:  丟丟丄专上丟丁丐丝);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  76, 丙业与丙丗丝不丈东:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
    }
    private void 丂丗丌丞丛丂丁丁丘(int 丟丟丄专上丟丁丐丝, int 万且丒下丕丝专丟上)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4;
        object[] val_1 = new object[2];
        val_1[0] = 丟丟丄专上丟丁丐丝;
        val_1[1] = 万且丒下丕丝专丟上;
        UnityEngine.Debug.LogFormat(format:  "[LeaderboardEvent] --------- UpdateScoreInSlot on event id {0} value: {1}", args:  val_1);
        val_4 = this.丁世丏与东下万丕三;
        if(val_4 == null)
        {
                this.专丅丈丏丑专丗丂且();
            val_4 = this.丁世丏与东下万丕三;
        }
        
        val_4.set_Item(key:  丟丟丄专上丟丁丐丝, value:  万且丒下丕丝专丟上);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  76, 丙业与丙丗丝不丈东:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
    }
    private System.Collections.Generic.Dictionary<int, int> 专丈一丞且丅丙三三()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = this.丁世丏与东下万丕三;
        if(val_1 != null)
        {
                return val_1;
        }
        
        this.专丅丈丏丑专丗丂且();
        val_1 = this.丁世丏与东下万丕三;
        return val_1;
    }
    private void 专丅丈丏丑专丗丂且()
    {
        var val_15;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_16;
        var val_17;
        val_15 = this;
        object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  76);
        if(val_2 == null)
        {
            goto label_4;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = null;
        val_16 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.丁世丏与东下万丕三 = val_16;
        val_17 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  System.Convert.ToString(value:  val_2));
        if(val_17 == null)
        {
            goto label_7;
        }
        
        val_16 = 1152921504689381376;
        val_17 = 0;
        goto label_12;
        label_4:
        this.丁世丏与东下万丕三 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        return;
        label_7:
        label_12:
        Dictionary.Enumerator<TKey, TValue> val_10 = val_17.GetEnumerator();
        label_18:
        if(((-1795836112) & 1) == 0)
        {
            goto label_14;
        }
        
        ConfiguredValueTaskAwaiter val_11 = 0.GetAwaiter();
        this.丁世丏与东下万丕三.set_Item(key:  System.Convert.ToInt32(value:  val_11._value._obj.丐丏七丌丕丗业且上()), value:  System.Convert.ToInt32(value:  val_11._value._obj));
        goto label_18;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 万下丁七世丅与下专()
    {
        .Data = this.丁七丈丌丈丂世万下;
        string val_2 = UnityEngine.JsonUtility.ToJson(obj:  new LeaderboardEventController.LeaderboardEventDataHandler());
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}.{1}", arg0:  "leaderboard_event_tournament", arg1:  val_2.丏东上丛丐丒丈世丞()), 下下丏一丙不丘丌丞:  val_2);
    }
    private void 万丗不下丌一丕与丟()
    {
        .Data = this.丏丁且丒世丂丘三业;
        string val_2 = UnityEngine.JsonUtility.ToJson(obj:  new LeaderboardEventController.RewardDataHandler());
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}.{1}", arg0:  "leaderboard_event_tournament_no_issued_rewards", arg1:  val_2.丏东上丛丐丒丈世丞()), 下下丏一丙不丘丌丞:  val_2);
    }
    internal void 世丞丕东世不丈下丕()
    {
        this.丁七丈丌丈丂世万下 = new System.Collections.Generic.List<LeaderboardEventTournament>();
        this.万下丁七世丅与下专();
        this.不三世上丄丛世丄丈(丙业与丙丗丝不丈东:  0);
        this.丏丁且丒世丂丘三业 = new System.Collections.Generic.List<RewardParameters>();
        this.万丗不下丌一丕与丟();
    }
    private LeaderboardEventTournament 不专万丅世万世丙丑(int 丟丟丄专上丟丁丐丝)
    {
        int val_4;
        var val_5;
        val_4 = 丟丟丄专上丟丁丐丝;
        List.Enumerator<T> val_1 = this.丁七丈丌丈丂世万下.GetEnumerator();
        label_4:
        if(((-1795244680) & 1) == 0)
        {
            goto label_2;
        }
        
        val_5 = 0.丐丏七丌丕丗业且上();
        if((0.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_4})) == false)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (LeaderboardEventTournament);
    }
    private LeaderboardEventTournament 不专万丅世万世丙丑(string 丌丝与丏丒与专东丟)
    {
        int val_4;
        string val_5;
        var val_6;
        val_5 = 丌丝与丏丒与专东丟;
        List.Enumerator<T> val_1 = this.丁七丈丌丈丂世万下.GetEnumerator();
        label_5:
        if(((-1795112216) & 1) == 0)
        {
            goto label_2;
        }
        
        val_6 = 0.丐丏七丌丕丗业且上();
        val_4 = val_2.m_stringLength;
        if((val_4.Equals(value:  val_5)) == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_2:
        val_6 = 0;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (LeaderboardEventTournament);
    }
    public LeaderboardEventController()
    {
        this.下丗丏丑丛上丟且丒 = 0;
        this.丐丏世与三丒业丆丏 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.Coroutine>();
    }

}
