using UnityEngine;
internal sealed class BPChallengesController : MonoBehaviour
{
    // Fields
    private static System.Action 丒丌丟专丂丈七丕丞;
    private static System.Action<int> 七七且上丕丅丝下与;
    private const string 丁丂下丟一丁丄丗七 = "ACtiveChallenges.BPChallengesController";
    private const string 丒东业业丘丛丅丌且 = "ChallengesConfig.BPChallengesController";
    internal const string 丏三丐丒丏下且丂丟 = "ChallengesProgress.BPChallengesController";
    internal const string 丏三丑丁东丞丟丐业 = "Challenges.UngivenRewards_V2_170818";
    internal const string 上丏丐七丈上世丝不 = "Challenges.NotIsNewIds";
    internal const char 丁七丈丆丂丞丕丌丐 = '\x7c';
    private static BPChallengesController 世丒丞七专三与万丕;
    private System.Collections.Generic.List<int> 丌东丞东丁万业丆丏;
    private PGCompany.BattlePass.BPChallangeDOList 丐下不且丕丟丝与丌;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>> 丘业业丒一丅东专丅;
    private static System.Action 丌丕丆三丅丛丞丈丛;
    private static System.Action<int> 与丁与丗丐丆丕丗丏;
    private UnityEngine.Coroutine 丁丌丐丏且丛丒丂丌;
    private UnityEngine.WaitForSecondsRealtime 世上三丘丒不上丆丝;
    
    // Properties
    internal static BPChallengesController 丆丕丝丒不丙且丐丗 { get; }
    internal int 丌丗丏丝丈丒一一丞 { get; }
    internal int 万丛丏丟世万上丏丌 { get; }
    internal int 丒三万上丞丕丁丏丛 { get; }
    internal System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄 { get; }
    internal bool 不丈下丄丏与丕丆一 { get; }
    
    // Methods
    internal static void 下专丒丌与丙不一与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  BPChallengesController.丁七丈丆丂丞丕丌丐, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 与万丟不丝丗丒东丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  BPChallengesController.丁七丈丆丂丞丕丌丐, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丈专丈下世上七丛丐(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BPChallengesController.七七且上丕丅丝下与, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BPChallengesController.七七且上丕丅丝下与 != 1152921505136775176);
    
    }
    internal static void 丟一丑丐下丙丐世三(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BPChallengesController.七七且上丕丅丝下与, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BPChallengesController.七七且上丕丅丝下与 != 1152921505136775176);
    
    }
    internal static System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<int, PGCompany.BattlePass.BPChallangeProgress>> 丙东丅上世丏丏七上()
    {
        var val_10;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Boolean> val_12;
        var val_13;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Int32> val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>> val_17;
        var val_18;
        System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅> val_2 = Progress.七七世万专丕丁上业.上业丑丅业不东丛业().丄丞丟三业丒丁且丛();
        if(val_2 != null)
        {
                val_10 = null;
            val_10 = null;
            val_12 = BPChallengesController.<>c.<>9__16_0;
            if(val_12 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Boolean> val_3 = null;
            val_12 = val_3;
            val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Boolean>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPChallengesController.<>c::丈一丏且一丄丙一三(System.Collections.Generic.KeyValuePair<int, PGCompany.BattlePass.三专下业丒七丑丒丅> 丈丏万丄丒业丅丒一));
            BPChallengesController.<>c.<>9__16_0 = val_12;
        }
        
            val_13 = null;
            val_13 = null;
            val_15 = BPChallengesController.<>c.<>9__16_1;
            if(val_15 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Int32> val_5 = null;
            val_15 = val_5;
            val_5 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Int32>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BPChallengesController.<>c::丕三丒丂丅丙三丗丈(System.Collections.Generic.KeyValuePair<int, PGCompany.BattlePass.三专下业丒七丑丒丅> 丈丏万丄丒业丅丒一));
            val_13 = null;
            BPChallengesController.<>c.<>9__16_1 = val_15;
        }
        
            val_13 = null;
            val_17 = BPChallengesController.<>c.<>9__16_2;
            if(val_17 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>> val_6 = null;
            val_17 = val_6;
            val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress> BPChallengesController.<>c::丟丄丘与丘丘丂丛与(System.Collections.Generic.KeyValuePair<int, PGCompany.BattlePass.三专下业丒七丑丒丅> 丈丏万丄丒业丅丒一));
            BPChallengesController.<>c.<>9__16_2 = val_17;
        }
        
            val_18 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>, System.Int32, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.BattlePass.三专下业丒七丑丒丅>>(source:  val_2, predicate:  val_3), keySelector:  val_5, elementSelector:  val_6);
            return (System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>>)val_18;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "Get_Challe_ngesForCl_oudMig_ration seasons == null", args:  System.Array.Empty<System.Object>());
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>> val_9 = null;
        val_18 = val_9;
        val_9 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>>();
        return (System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.Int32, PGCompany.BattlePass.BPChallangeProgress>>)val_18;
    }
    internal static BPChallengesController 丑七不且上丗丁一世()
    {
        var val_4;
        BPChallengesController val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = BPChallengesController.世丒丞七专三与万丕;
        if(val_5 == 0)
        {
                UnityEngine.GameObject val_2 = null;
            val_5 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "BPChallengesController");
            val_6 = null;
            val_6 = null;
            BPChallengesController.世丒丞七专三与万丕 = val_2.AddComponent<BPChallengesController>();
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        }
        
        val_7 = null;
        val_7 = null;
        return (BPChallengesController)BPChallengesController.世丒丞七专三与万丕;
    }
    internal int 万上丁一丞业业万东()
    {
        this.东丅业丅不上七丁丙();
        if(this.丐下不且丕丟丝与丌 != null)
        {
                return (int)this.丐下不且丕丟丝与丌.SeasonId;
        }
        
        return (int)this.丐下不且丕丟丝与丌.SeasonId;
    }
    internal int 丒丑丅丑丕万丞丅丟()
    {
        ulong val_8;
        int val_9;
        val_8 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_8 != null)
        {
                System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
            if((1703228704 & 1) != 0)
        {
                System.DateTime val_4 = val_8.丟万丌丕丅下万丆七();
            System.DateTime val_5 = val_8.丟万丌丕丅下万丆七();
            val_8 = val_5.dateData;
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {dateData = val_8});
            val_9 = (int)val_6._ticks.TotalDays;
            return (int)val_9;
        }
        
        }
        
        val_9 = 0;
        return (int)val_9;
    }
    internal int 丏丁三丛上且丝丑丞()
    {
        ulong val_7;
        int val_8;
        val_7 = Rilisoft.Singleton<BattlePassController>.Instance;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = val_7.丛东丛丕东丟丂丈丝();
        if(val_2 != null)
        {
                System.DateTime val_3 = val_2.丒万丐不丆且丒与丒();
            val_7 = val_3.dateData;
            System.DateTime val_4 = val_2.丟万丌丕丅下万丆七();
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {dateData = val_4.dateData});
            val_8 = (int)val_5._ticks.TotalDays;
            return (int)val_8;
        }
        
        val_8 = 0;
        return (int)val_8;
    }
    internal System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丄丄丆东丑三丝专丂()
    {
        var val_11;
        this.东丅业丅不上七丁丙();
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_6 = 0;
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) != null)
        {
                bool val_7 = this.丘业业丒一丅东专丅.TryGetValue(key:  Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().万上丁一丞业业万东(), value: out  val_6);
        }
        
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) != null)
        {
                val_11 = val_6;
            if(val_11 != 0)
        {
                return (System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)val_11;
        }
        
        }
        
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_10 = null;
        val_11 = val_10;
        val_10 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
        return (System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)val_11;
    }
    internal bool 丄三丞丟丝东业业丌()
    {
        return (bool)(this.丑专丘三丟丐丅上上().Count > 0) ? 1 : 0;
    }
    internal static void 丄且丆世上丈不丄丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BPChallengesController.丌丕丆三丅丛丞丈丛, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BPChallengesController.丌丕丆三丅丛丞丈丛 != 1152921505136775192);
    
    }
    internal static void 丒丈不上丞专丕丛丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BPChallengesController.丌丕丆三丅丛丞丈丛, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BPChallengesController.丌丕丆三丅丛丞丈丛 != 1152921505136775192);
    
    }
    internal static void 丛丄丂与丄丈丟丂丒(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  BPChallengesController.与丁与丗丐丆丕丗丏, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BPChallengesController.与丁与丗丐丆丕丗丏 != 1152921505136775200);
    
    }
    internal static void 丈丁丟专丕七上不七(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  BPChallengesController.与丁与丗丐丆丕丗丏, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(BPChallengesController.与丁与丗丐丆丕丗丏 != 1152921505136775200);
    
    }
    internal System.Collections.Generic.IEnumerable<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丁丐万丆丕下下专万(System.Collections.Generic.IEnumerable<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丈丆丕与丒丌丘丕且, int 三丈丏丑一丞下丄丂)
    {
        .三丈丏丑一丞下丄丂 = 三丈丏丑一丞下丄丂;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_3 == null)
        {
                return (System.Collections.Generic.IEnumerable<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  丈丆丕与丒丌丘丕且, predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BPChallengesController.丑丗东丞三且丂丄丒(), method:  System.Boolean BPChallengesController.丑丗东丞三且丂丄丒::丝丛不丏丐丌丏七丝(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
        }
        
        System.DateTime val_4 = val_3.丟万丌丕丅下万丆七();
        System.DateTime val_5 = val_4.dateData.AddDays(value:  (double)(BPChallengesController.丑丗东丞三且丂丄丒)[1152921536375984432].三丈丏丑一丞下丄丂);
        return (System.Collections.Generic.IEnumerable<PGCompany.BattlePass.三丛上丁丗丌丆丌东>)System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  丈丆丕与丒丌丘丕且, predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BPChallengesController.丑丗东丞三且丂丄丒(), method:  System.Boolean BPChallengesController.丑丗东丞三且丂丄丒::丝丛不丏丐丌丏七丝(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
    }
    internal int 七丞丏与丞丙丈丛丆(System.DateTime 丑丙万一丏丅丁专丏)
    {
        int val_7;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 != null)
        {
                System.DateTime val_3 = val_2.丟万丌丕丅下万丆七();
            System.DateTime val_4 = val_2.丟万丌丕丅下万丆七();
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 丑丙万一丏丅丁专丏.dateData}, d2:  new System.DateTime() {dateData = val_4.dateData});
            val_7 = (int)val_5._ticks.TotalDays;
            return (int)val_7;
        }
        
        val_7 = 0;
        return (int)val_7;
    }
    internal System.Nullable<System.DateTime> 丏万业丁一丆丛丗下(int 丟丒业且万上丁三丆)
    {
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_2 == null)
        {
                return 0;
        }
        
        System.DateTime val_3 = val_2.丟万丌丕丅下万丆七();
        System.DateTime val_4 = val_3.dateData.AddDays(value:  (double)丟丒业且万上丁三丆);
        0 = val_4.dateData;
        return 0;
    }
    internal int 丝一丁丏一丐丕丂丏(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丟专三丙丒丄丂下与)
    {
        if(丟专三丙丒丄丂下与 == null)
        {
                return 0;
        }
        
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
        {
                return 0;
        }
        
        return 丟专三丙丒丄丂下与.三万七与东丄业丐丙();
    }
    internal void 不一丘丅且丆不七上(int 世不下丟世一丝丐丗, System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> 丂东丞丕丛丘且业丝)
    {
        var val_11;
        var val_12;
        System.Action<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_14;
        System.Object[] val_15;
        string val_16;
        BPChallengesController.且不丘丝丕业下万一 val_1 = new BPChallengesController.且不丘丝丕业下万一();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_11 = val_1;
        .世不下丟世一丝丐丗 = 世不下丟世一丝丐丗;
        mem[1152921536376643664] = this;
        if((世不下丟世一丝丐丗 & 2147483648) != 0)
        {
            goto label_2;
        }
        
        label_16:
        if(丂东丞丕丛丘且业丝 == null)
        {
            goto label_3;
        }
        
        this.东丅业丅不上七丁丙();
        if((this.丘业业丒一丅东专丅.ContainsKey(key:  .世不下丟世一丝丐丗)) != true)
        {
                System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_3 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
            this.丘业业丒一丅东专丅.set_Item(key:  .世不下丟世一丝丐丗, value:  null);
        }
        
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_4 = this.丘业业丒一丅东专丅.Item[.世不下丟世一丝丐丗];
        val_12 = null;
        val_12 = null;
        val_14 = BPChallengesController.<>c.<>9__39_0;
        if(val_14 == null)
        {
            goto label_13;
        }
        
        if(val_4 != null)
        {
            goto label_24;
        }
        
        goto label_15;
        label_1:
        mem[16] = this;
        val_11 = 24;
        mem[24] = 世不下丟世一丝丐丗;
        if((mem[24] & 2147483648) == 0)
        {
            goto label_16;
        }
        
        label_2:
        val_15 = System.Array.Empty<System.Object>();
        val_16 = "Apply_Data seasonId < 0";
        goto label_19;
        label_3:
        val_15 = System.Array.Empty<System.Object>();
        val_16 = "Apply_Data bpChalle_ngesData == null";
        label_19:
        UnityEngine.Debug.LogErrorFormat(format:  val_16, args:  val_15);
        return;
        label_13:
        val_14 = null;
        val_14 = new System.Action<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPChallengesController.<>c::七不丐一上世丐业丈(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
        BPChallengesController.<>c.<>9__39_0 = val_14;
        if(val_4 != null)
        {
            goto label_24;
        }
        
        label_15:
        label_24:
        val_4.ForEach(action:  null);
        this.丘业业丒一丅东专丅.Item[.世不下丟世一丝丐丗].Clear();
        System.Action<PGCompany.BattlePass.BPChallangeDO> val_9 = new System.Action<PGCompany.BattlePass.BPChallangeDO>(object:  val_1, method:  System.Void BPChallengesController.且不丘丝丕业下万一::不丌丙上丄下丆与丏(PGCompany.BattlePass.BPChallangeDO 三丟东丕丄丄下下丑));
        丂东丞丕丛丘且业丝.ForEach(action:  null);
        new PGCompany.BattlePass.BPChallangeDOList() = new PGCompany.BattlePass.BPChallangeDOList();
        if(new PGCompany.BattlePass.BPChallangeDOList() != null)
        {
                .SeasonId = .世不下丟世一丝丐丗;
        }
        else
        {
                mem[24] = .世不下丟世一丝丐丗;
        }
        
        .BpChallengeDos = 丂东丞丕丛丘且业丝;
        this.丐下不且丕丟丝与丌 = new PGCompany.BattlePass.BPChallangeDOList();
        this.丌丙下丅七万丑丝丞(丐丕丙丛丐下丘不丙:  true);
        this.一丞世且一万丐丅专();
    }
    internal void 一丞世且一万丐丅专()
    {
        var val_6;
        var val_14;
        var val_15;
        var val_16;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        Dictionary.Enumerator<TKey, TValue> val_3 = this.丘业业丒一丅东专丅.GetEnumerator();
        val_14 = 0;
        val_15 = 0;
        var val_14 = 0;
        label_22:
        if((1705247056 & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((val_2 == null) || ((val_7._value._obj.丙东专丂世丈丏丁丂() != val_2.万上丁一丞业业万东()) || (val_7._value._obj == 0)))
        {
            goto label_22;
        }
        
        List.Enumerator<T> val_10 = val_7._value._obj.GetEnumerator();
        label_12:
        if((1705247008 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_11 = val_6.丐丏七丌丕丗业且上();
        if((val_11 == null) || (val_11.丄上丝丌上下丒上丙() == null))
        {
            goto label_12;
        }
        
        val_11.丄上丝丌上下丒上丙().丐三上丏丈丕且且丞();
        goto label_12;
        label_8:
        val_14 = val_14 + 1;
        mem2[0] = 134;
        val_16 = val_15;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_14 == 1) || ((1152921536376864992 + ((0 + 1)) << 2) != 134))
        {
            goto label_19;
        }
        
        var val_15 = 0;
        val_15 = val_15 ^ (val_14 >> 31);
        val_14 = val_14 + val_15;
        goto label_22;
        label_19:
        if( == 0)
        {
            goto label_22;
        }
        
        goto label_22;
        label_3:
        val_14 = val_14 + 1;
        mem2[0] = 159;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_14 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921536376864992 + ((0 + 1)) << 2) == 159)
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
    private void Start()
    {
        this.东丅业丅不上七丁丙();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丛丁世上与丐丙丙业());
        PGCompany.BattlePass.丘丄上丏不丝不丐丐.丅万七世东丂下丙世(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void BPChallengesController::丘丙不丒丌且世丗三(丘上上万专丙万丟丑 丆丌丏且下丈丗丗丗)));
        PGCompany.BattlePass.丘丄上丏不丝不丐丐.丌专业七丝上上丕丅(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void BPChallengesController::与与三下丂丘丌丝丗(丘上上万专丙万丟丑 丐与万三丘丌东丅丞)));
        FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丞世丆丏且一丌丏下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.一丁专下一丆丞丟世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丄丁丁丟万不丄七且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        BattlePassController.丙七一丄下专丏不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.BPTutorialController.丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.BattlePassGuiHandler.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::下丞一丆丁七丏三且()));
    }
    private void OnDestroy()
    {
        PGCompany.BattlePass.BPTutorialController.不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.东丌丄世专丏丘丗丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丆丑专一丟下丆丙七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.上丕丁专三丗丝万丆.丐丑丑丐丅丈丝丄世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        BattlePassController.业丏专与丝不东丁一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::丌丙下丅七万丑丝丞()));
        PGCompany.BattlePass.丘丄上丏不丝不丐丐.专丒七世一丘丌万七(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void BPChallengesController::丘丙不丒丌且世丗三(丘上上万专丙万丟丑 丆丌丏且下丈丗丗丗)));
        PGCompany.BattlePass.丘丄上丏不丝不丐丐.丝丝世丗下丐与丄丞(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void BPChallengesController::与与三下丂丘丌丝丗(丘上上万专丙万丟丑 丐与万三丘丌东丅丞)));
        PGCompany.BattlePass.BattlePassGuiHandler.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BPChallengesController::下丞一丆丁七丏三且()));
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == false)
        {
                return;
        }
        
        this.业丗上丑丐丑不上且();
    }
    private void OnApplicationQuit()
    {
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        this.业丗上丑丐丑不上且();
    }
    private void 业丗上丑丐丑不上且()
    {
        this.东丅业丅不上七丁丙();
        this.不一丁丝丕丅且东丞();
        this.丅丈丘丒丙丑丝与与();
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ACtiveChallenges.BPChallengesController", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丌东丞东丁万业丆丏));
    }
    private void 丘丙不丒丌且世丗三(丘上上万专丙万丟丑 丆丌丏且下丈丗丗丗)
    {
        var val_65;
        var val_66;
        object val_67;
        var val_68;
        System.Object[] val_70;
        System.Object[] val_71;
        string val_72;
        var val_73;
        var val_74;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_76;
        var val_77;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.业专丒丟且丝七丑丁> val_79;
        int val_80;
        string val_81;
        BPChallengesController.上丏三丌丂丙丅且丘 val_1 = new BPChallengesController.上丏三丌丂丙丅且丘();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_65 = val_1;
        .丆丌丏且下丈丗丗丗 = 丆丌丏且下丈丗丗丗;
        if(丆丌丏且下丈丗丗丗 == null)
        {
            goto label_2;
        }
        
        label_30:
        if(this.丄丄丆东丑三丝专丂().Count == 0)
        {
            goto label_4;
        }
        
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_6 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.丄丄丆东丑三丝专丂(), predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  val_1, method:  System.Boolean BPChallengesController.上丏三丌丂丙丅且丘::且丁与丛且丛丆丏丑(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑)));
        if(val_1 == null)
        {
            goto label_5;
        }
        
        val_66 = val_1;
        .丟专三丙丒丄丂下与 = val_6;
        if(val_6 == null)
        {
            goto label_6;
        }
        
        label_37:
        if(val_1 == null)
        {
            goto label_7;
        }
        
        label_48:
        if(val_6.丈丏丁东上与东丙丕() == null)
        {
            goto label_9;
        }
        
        if(.丟专三丙丒丄丂下与.丈丏丁东上与东丙丕().Count == 0)
        {
                object[] val_10 = new object[1];
            val_10[0] = .丆丌丏且下丈丗丗丗.业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogWarningFormat(format:  "BPChallenge_Condition_OnChalleng_eCompleted chal_lnege.Rewards.Count == 0  {0}", args:  val_10);
        }
        
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_13 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_13 == null)
        {
            goto label_29;
        }
        
        if(val_13.专丟专一丒且丘与丌() == 0)
        {
            goto label_24;
        }
        
        InfoWindowController.丆丏丈七丗且丈且丟(丏不丄丑丝丁丘万不:  .丟专三丙丒丄丂下与.丒万丁丌一丙专丐丞());
        goto label_29;
        label_1:
        val_65 = 16;
        mem[16] = 丆丌丏且下丈丗丗丗;
        if(mem[16] != 0)
        {
            goto label_30;
        }
        
        label_2:
        val_67 = System.Array.Empty<System.Object>();
        val_68 = "BPChalleng_eCondition_OnChallenge_Completed progressOfComp_letedChallenge == null";
        goto label_33;
        label_4:
        val_67 = System.Array.Empty<System.Object>();
        val_68 = "BPChalleng_eCondition_OnChalleng_eCompleted emp_ty _chal_lenges";
        label_33:
        val_70 = val_67;
        goto label_36;
        label_5:
        val_66 = 24;
        mem[24] = val_6;
        if(mem[24] != 0)
        {
            goto label_37;
        }
        
        label_6:
        val_71 = new object[1];
        val_67 = .丆丌丏且下丈丗丗丗.业上丙丞丐丄丆丅七();
        val_71[0] = val_67;
        val_72 = "BPChalleng_eCondition_OnChallengeCo_mpleted chal_lnege == null  {0}";
        goto label_232;
        label_7:
        if(.丟专三丙丒丄丂下与 != null)
        {
            goto label_48;
        }
        
        goto label_48;
        label_9:
        object[] val_20 = new object[1];
        val_71 = val_20;
        val_67 = .丆丌丏且下丈丗丗丗.业上丙丞丐丄丆丅七();
        val_71[0] = val_67;
        val_72 = "BPChallenge_Condition_OnChallengeC_ompleted chall_nege.Rewards == null  {0}";
        label_232:
        val_70 = val_71;
        label_36:
        UnityEngine.Debug.LogErrorFormat(format:  val_72, args:  val_20);
        return;
        label_24:
        InfoWindowController.丕丆丌世丞丞丞一丐(丏不丄丑丝丁丘万不:  .丟专三丙丒丄丂下与.丒万丁丌一丙专丐丞(), 与万丆丛丒万丝丙丑:  0);
        label_29:
        System.Collections.Generic.List<Rilisoft.OfferItem> val_24 = this.丑专丘三丟丐丅上上(且丂七下丙丆三丐三:  .丟专三丙丒丄丂下与.业上丙丞丐丄丆丅七());
        if((PGCompany.丞丒专七世下丅万丂.一不丂专一下丑业不<Rilisoft.OfferItem>(丈丆丕与丒丌丘丕且:  val_24)) != false)
        {
                val_73 = null;
            val_73 = null;
            if(BPChallengesController.七七且上丕丅丝下与 != null)
        {
                BPChallengesController.七七且上丕丅丝下与.Invoke(obj:  .丟专三丙丒丄丂下与.业上丙丞丐丄丆丅七());
        }
        
        }
        
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_28 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  val_1, method:  System.Boolean BPChallengesController.上丏三丌丂丙丅且丘::丟丆丂东三丆丑东万(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
        val_74 = null;
        val_74 = null;
        val_76 = BPChallengesController.<>c.<>9__46_2;
        if(val_76 == null)
        {
                val_76 = null;
            val_76 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BPChallengesController.<>c::三丌万下丈万丟丘丕(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            BPChallengesController.<>c.<>9__46_2 = val_76;
        }
        
        val_77 = null;
        val_77 = null;
        val_79 = BPChallengesController.<>c.<>9__46_3;
        if(val_79 == null)
        {
                val_79 = null;
            val_79 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.业专丒丟且丝七丑丁>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.业专丒丟且丝七丑丁 BPChallengesController.<>c::丏丐丗丕三专丆丅丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
            BPChallengesController.<>c.<>9__46_3 = val_79;
        }
        
        val_80 = System.String.alignConst;
        int val_38 = (System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.ThenBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.业专丒丟且丝七丑丁>(source:  System.Linq.Enumerable.OrderBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.丄丄丆东丑三丝专丂(), predicate:  null), keySelector:  null), keySelector:  null)).IndexOf(item:  .丟专三丙丒丄丂下与)) + 1;
        int val_39 = .丟专三丙丒丄丂下与.三万七与东丄业丐丙() + 1;
        if(.丟专三丙丒丄丂下与.三丝丄丈丆丂专丄东() != 10)
        {
            goto label_85;
        }
        
        val_81 = "Daily Challenges";
        val_80 = System.String.Format(format:  "daily_day_{0}_{1}", arg0:  val_39, arg1:  val_38);
        goto label_97;
        label_85:
        if(.丟专三丙丒丄丂下与.三丝丄丈丆丂专丄东() != 20)
        {
            goto label_89;
        }
        
        if(.丟专三丙丒丄丂下与.丏丐七上业丆与丘专() == 0)
        {
            goto label_92;
        }
        
        val_81 = "Paid Challenges";
        val_80 = System.String.Format(format:  "paid_day_{0}_{1}", arg0:  val_39, arg1:  val_38);
        goto label_97;
        label_89:
        val_81 = val_80;
        if(.丟专三丙丒丄丂下与.三丝丄丈丆丂专丄东() != 30)
        {
            goto label_97;
        }
        
        val_81 = "Upgraded Pass Challenges";
        val_80 = System.String.Format(format:  "upgraded_challenge_{0}", arg0:  val_38);
        goto label_97;
        label_92:
        val_81 = "Free Challenges";
        val_80 = System.String.Format(format:  "free_day_{0}_{1}", arg0:  val_39, arg1:  val_38);
        label_97:
        if(val_13.专丟专一丒且丘与丌() == 100)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.BattlePass.BPChallangeDO val_54 = .丟专三丙丒丄丂下与.丁专丗万三上丟三丆();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            PGCompany.Analytics.一业丗丆世世上丁且.业丙丝且丐丁且七上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞丅上丏丂且下丅与:  .丟专三丙丒丄丂下与.业上丙丞丐丄丆丅七(), 丗与丘不且万丟丙丑:  (float).丟专三丙丒丄丂下与.丄上丝丌上下丒上丙(), 丟丒业且万上丁三丆:  val_39, 上业丟世三与七七三:  val_24, 丂丛丑东不丅丈一东:  .丟专三丙丒丄丂下与.丄上丝丌上下丒上丙().丘丛丆丕且丂业世丌().ToString(), 万丒丑且丈丂丘东丑:  val_54.ConditionType.ToString());
            Rilisoft.一丟专且三万丞丁丂.上丕丁专三丗丝万丆(丞丙丕不丕丆丁下万:  true, 丆且丁丒丒丆丁三丆:  val_81, 丙业与丙丗丝不丈东:  val_80);
            return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.BattlePass.BPChallangeDO val_62 = .丟专三丙丒丄丂下与.丁专丗万三上丟三丆();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        PGCompany.Analytics.一业丗丆世世上丁且.业丙丝且丐丁且七上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞丅上丏丂且下丅与:  .丟专三丙丒丄丂下与.业上丙丞丐丄丆丅七(), 丗与丘不且万丟丙丑:  (float).丟专三丙丒丄丂下与.丄上丝丌上下丒上丙(), 丟丒业且万上丁三丆:  val_39, 上业丟世三与七七三:  val_24, 丂丛丑东不丅丈一东:  .丟专三丙丒丄丂下与.丄上丝丌上下丒上丙().丘丛丆丕且丂业世丌().ToString(), 万丒丑且丈丂丘东丑:  val_62.ConditionType.ToString());
        Rilisoft.一丟专且三万丞丁丂.上丕丁专三丗丝万丆(丞丙丕不丕丆丁下万:  false, 丆且丁丒丒丆丁三丆:  val_81, 丙业与丙丗丝不丈东:  val_80);
    }
    private void 与与三下丂丘丌丝丗(丘上上万专丙万丟丑 丐与万三丘丌东丅丞)
    {
        丘上上万专丙万丟丑 val_31;
        object val_32;
        var val_33;
        val_31 = 丐与万三丘丌东丅丞;
        BPChallengesController.丕丘丅三丛丘专世一 val_1 = null;
        val_32 = val_1;
        val_1 = new BPChallengesController.丕丘丅三丛丘专世一();
        if(val_32 == null)
        {
            goto label_1;
        }
        
        val_33 = val_32;
        .丐与万三丘丌东丅丞 = val_31;
        if(val_31 == null)
        {
            goto label_2;
        }
        
        label_25:
        val_31 = this.丄丄丆东丑三丝专丂();
        if(val_31.Count == 0)
        {
            goto label_4;
        }
        
        val_31 = null;
        val_31 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  val_1, method:  System.Boolean BPChallengesController.丕丘丅三丛丘专世一::丁丗丄一万三丗丏丑(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_6 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.丄丄丆东丑三丝专丂(), predicate:  null);
        if(val_6 == null)
        {
            goto label_5;
        }
        
        val_31 = Rilisoft.Singleton<BattlePassController>.Instance;
        if(val_31 == 0)
        {
                return;
        }
        
        val_31 = Rilisoft.Singleton<BattlePassController>.Instance;
        if(val_31.丛东丛丕东丟丂丈丝() == null)
        {
                return;
        }
        
        if(val_6.丑丆丘三与丑丙丐三() != 1)
        {
                return;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_13 = val_6.丄上丝丌上下丒上丙().丑业丞丙丏丌丐且丌();
        val_31;
        if(val_31 == .丐与万三丘丌东丅丞.且专丂丐丟一不丌丟())
        {
                return;
        }
        
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().专丟专一丒且丘与丌()) == 0)
        {
            goto label_18;
        }
        
        val_31 = val_6.丒万丁丌一丙专丐丞();
        Rilisoft.丝丑丂丛万丐丈丘且 val_20 = val_6.丄上丝丌上下丒上丙().丑业丞丙丏丌丐且丌();
        val_32 = .丐与万三丘丌东丅丞.且专丂丐丟一不丌丟();
        InfoWindowController.丁丆三丗东丂丅专万(丏不丄丑丝丁丘万不:  val_31, 且下丆丕丝丄丑三三:  1707081040, 丗丛万下丙丕上专丌:  val_32);
        return;
        label_1:
        mem[16] = val_31;
        val_33 = 16;
        val_31 = mem[16];
        if(val_31 != 0)
        {
            goto label_25;
        }
        
        label_2:
        val_32 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "BPChallenge_Condition_OnChallengePr_ogressChanged progressOfComp_letedChallenge == null", args:  val_32);
        return;
        label_4:
        val_32 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeC_ondition_OnChallenge_ProgressChanged emp_ty _chall_enges", args:  val_32);
        return;
        label_5:
        object[] val_24 = new object[1];
        val_32 = .丐与万三丘丌东丅丞.业上丙丞丐丄丆丅七();
        val_24[0] = val_32;
        UnityEngine.Debug.LogErrorFormat(format:  "BPChallenge_Condition_OnChallengeP_rogressChanged challnege == null  {0}", args:  val_24);
        return;
        label_18:
        Rilisoft.丝丑丂丛万丐丈丘且 val_28 = val_6.丄上丝丌上下丒上丙().丑业丞丙丏丌丐且丌();
        InfoWindowController.世丌与丅与丏丌东丐(丏不丄丑丝丁丘万不:  val_6.丒万丁丌一丙专丐丞(), 且下丆丕丝丄丑三三:  1707081040, 丗丛万下丙丕上专丌:  .丐与万三丘丌东丅丞.且专丂丐丟一不丌丟());
    }
    private System.Collections.IEnumerator 丛丁世上与丐丙丙业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BPChallengesController.丆东丏七丅上业丅丙();
    }
    internal void 丌丙下丅七万丑丝丞()
    {
        this.丌丙下丅七万丑丝丞(丐丕丙丛丐下丘不丙:  false);
    }
    private void 丌丙下丅七万丑丝丞(bool 丐丕丙丛丐下丘不丙)
    {
        if(this.丁丌丐丏且丛丒丂丌 != null)
        {
                return;
        }
        
        this.丁丌丐丏且丛丒丂丌 = this.StartCoroutine(routine:  this.丕丆丙一丏且丂丞不(丐丕丙丛丐下丘不丙:  false));
    }
    private System.Collections.IEnumerator 丕丆丙一丏且丂丞不(bool 丐丕丙丛丐下丘不丙)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BPChallengesController.丝丒丛丘丛丄丐丝丑();
    }
    private void 不一丁丝丕丅且东丞()
    {
        if(this.丐下不且丕丟丝与丌 != null)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ChallengesConfig.BPChallengesController", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  this.丐下不且丕丟丝与丌));
            return;
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "SaveCha_llenges challen_geData == null", args:  System.Array.Empty<System.Object>());
    }
    private void 东丅业丅不上七丁丙()
    {
        object val_11;
        PGCompany.BattlePass.BPChallangeDOList val_12;
        val_11 = this;
        if(this.丐下不且丕丟丝与丌 != null)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ChallengesConfig.BPChallengesController")) != true)
        {
                new PGCompany.BattlePass.BPChallangeDOList() = new PGCompany.BattlePass.BPChallangeDOList();
            .SeasonId = 0;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO> val_3 = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallangeDO>();
            .BpChallengeDos = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ChallengesConfig.BPChallengesController", 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  new PGCompany.BattlePass.BPChallangeDOList()));
        }
        
        PGCompany.BattlePass.BPChallangeDOList val_6 = UnityEngine.JsonUtility.FromJson<PGCompany.BattlePass.BPChallangeDOList>(json:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "ChallengesConfig.BPChallengesController"));
        val_12 = val_6;
        this.丐下不且丕丟丝与丌 = val_6;
        if(val_6 == null)
        {
                val_12 = this.丐下不且丕丟丝与丌;
        }
        
        System.Func<PGCompany.BattlePass.BPChallangeDO, PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_7 = new System.Func<PGCompany.BattlePass.BPChallangeDO, PGCompany.BattlePass.三丛上丁丗丌丆丌东>(object:  this, method:  PGCompany.BattlePass.三丛上丁丗丌丆丌东 BPChallengesController::丌下与一丗丙丒丑丏(PGCompany.BattlePass.BPChallangeDO 世丁丏不丌世一丞丕));
        this.丘业业丒一丅东专丅.set_Item(key:  val_6.SeasonId, value:  System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPChallangeDO, PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.丐下不且丕丟丝与丌.BpChallengeDos, selector:  null)));
        val_11 = "ACtiveChallenges.BPChallengesController";
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "ACtiveChallenges.BPChallengesController")) == true)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "ACtiveChallenges.BPChallengesController", 下下丏一丙不丘丌丞:  "[]");
    }
    private void 丅丈丘丒丙丑丝与与()
    {
        string val_10;
        var val_11;
        System.Predicate<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_13;
        var val_15;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.String> val_17;
        val_10 = this.丄丄丆东丑三丝专丂();
        if(val_10.Count == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_3 = this.丄丄丆东丑三丝专丂();
        val_11 = null;
        val_11 = null;
        val_13 = BPChallengesController.<>c.<>9__55_0;
        if(val_13 == null)
        {
            goto label_5;
        }
        
        if(val_3 != null)
        {
            goto label_10;
        }
        
        goto label_7;
        label_5:
        val_13 = null;
        val_13 = new System.Predicate<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPChallengesController.<>c::七上丞丛丄丒丁专与(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
        BPChallengesController.<>c.<>9__55_0 = val_13;
        if(val_3 != null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_15 = null;
        val_15 = null;
        val_17 = BPChallengesController.<>c.<>9__55_1;
        if(val_17 == null)
        {
                val_17 = null;
            val_17 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.String>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.String BPChallengesController.<>c::不世且专丏丒世丅丌(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
            BPChallengesController.<>c.<>9__55_1 = val_17;
        }
        
        val_10 = System.String.Join(separator:  124, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.String>(source:  val_3.FindAll(match:  null), selector:  null)));
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "Challenges.NotIsNewIds", 下下丏一丙不丘丌丞:  val_10);
    }
    private void 下丞一丆丁七丏三且()
    {
        if(PGCompany.BattlePass.三丛上丁丗丌丆丌东.且丗专七七丟丕丆七() == false)
        {
                return;
        }
        
        this.丅丈丘丒丙丑丝与与();
        PGCompany.BattlePass.三丛上丁丗丌丆丌东.且丘丝丆业丁丙丟丅(丙业与丙丗丝不丈东:  false);
    }
    internal bool 下万丅上丒丁丑丐丟(int 且丂七下丙丆三丐三)
    {
        .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_2 = this.丑专丘三丟丐丅上上();
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        return System.Linq.Enumerable.Any<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_2, predicate:  new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  new BPChallengesController.丏丑丅丙世东丈丑丆(), method:  System.Boolean BPChallengesController.丏丑丅丙世东丈丑丆::万不丂丞丘上丁丏与(PGCompany.BattlePass.BPChallengeRememberedReward 东七上世万下丗丄丛)));
    }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丑专丘三丟丐丅上上(int 且丂七下丙丆三丐三)
    {
        System.Collections.Generic.List<Rilisoft.OfferItem> val_5;
        .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_2 = this.丑专丘三丟丐丅上上();
        if(val_2 == null)
        {
                return val_5;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_2, predicate:  new System.Func<丟丄七万东与上丒丟, System.Boolean>(object:  new BPChallengesController.丑丌与七下丈丅一丐(), method:  System.Boolean BPChallengesController.丑丌与七下丈丅一丐::丄且丄与东丒丕专丅(PGCompany.BattlePass.BPChallengeRememberedReward 东七上世万下丗丄丛)))) == null)
        {
                return val_5;
        }
        
        val_5 = val_4.Rewards;
        return val_5;
    }
    internal void 世丗丟丆丒丈万丕丈(int 丞丅上丏丂且下丅与)
    {
        System.Collections.Generic.IEnumerable<TSource> val_12;
        var val_13;
        System.Action<Rilisoft.OfferItem> val_15;
        System.Object[] val_16;
        .丞丅上丏丂且下丅与 = 丞丅上丏丂且下丅与;
        val_12 = this.丑专丘三丟丐丅上上();
        if(val_12 == null)
        {
            goto label_2;
        }
        
        System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean> val_3 = new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  new BPChallengesController.下世丗丈丞丂丐丐丘(), method:  System.Boolean BPChallengesController.下世丗丈丞丂丐丐丘::丗丏丁丏丈万丂丐与(PGCompany.BattlePass.BPChallengeRememberedReward 三丟东丕丄丄下下丑));
        val_12 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_12, predicate:  null);
        if(val_12 == null)
        {
            goto label_3;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  36);
        val_12 = val_4.Rewards;
        if(val_12 != null)
        {
                val_13 = null;
            val_13 = null;
            val_15 = BPChallengesController.<>c.<>9__59_1;
            if(val_15 == null)
        {
                val_15 = null;
            val_15 = new System.Action<Rilisoft.OfferItem>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPChallengesController.<>c::丄丒丈东业丗七世丒(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            BPChallengesController.<>c.<>9__59_1 = val_15;
        }
        
            val_12.ForEach(action:  null);
        }
        
        bool val_7 = this.上丒丄丌丞东丄上丛(且丂七下丙丆三丐三:  (BPChallengesController.下世丗丈丞丂丐丐丘)[1152921536380660064].丞丅上丏丂且下丅与, 丂丂丟丘丆东丟丄丒:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  54);
        val_16 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_16.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_2:
        val_16 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "GiveRewardFo_rChallenge rewards == null || rewards.ChallengeR_ewardsList == null", args:  val_16);
        return;
        label_3:
        object[] val_11 = new object[1];
        val_16 = val_11;
        val_16[0] = (BPChallengesController.下世丗丈丞丂丐丐丘)[1152921536380660064].丞丅上丏丂且下丅与;
        UnityEngine.Debug.LogErrorFormat(format:  "GiveReward_ForChallenge r == null id = {0}", args:  val_11);
    }
    internal bool 上丒丄丌丞东丄上丛(int 且丂七下丙丆三丐三, bool 丂丂丟丘丆东丟丄丒 = True)
    {
        System.Action<System.Int32> val_10;
        System.Collections.Generic.IEnumerable<TSource> val_11;
        var val_12;
        var val_13;
        val_10 = 丂丂丟丘丆东丟丄丒;
        .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
        val_11 = this.丄丄丆东丑三丝专丂();
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_3 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new BPChallengesController.一三下世一丁丘丁丝(), method:  System.Boolean BPChallengesController.一三下世一丁丘丁丝::丛世丁丟不丟丑丄东(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_11, predicate:  null);
        if(val_4 != null)
        {
                val_11 = Progress.七七世万专丕丁上业.上业丑丅业不东丛业();
            val_11.专丟丁丅七下丞三业(世不下丟世一丝丐丗:  val_4.万上丁一丞业业万东(), 且丂七下丙丆三丐三:  val_4.业上丙丞丐丄丆丅七());
            if(val_10 != false)
        {
                val_11 = 1152921505136771072;
            val_12 = null;
            val_12 = null;
            val_10 = BPChallengesController.与丁与丗丐丆丕丗丏;
            if(val_10 != null)
        {
                val_10 = BPChallengesController.与丁与丗丐丆丕丗丏;
            int val_8 = val_4.业上丙丞丐丄丆丅七();
            val_10.Invoke(obj:  val_8);
        }
        
        }
        
            val_13 = 1;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    internal PGCompany.BattlePass.三丛上丁丗丌丆丌东 七丗丒丟一一丅业丑()
    {
        var val_4;
        System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_6;
        this.东丅业丅不上七丁丙();
        val_4 = null;
        val_4 = null;
        val_6 = BPChallengesController.<>c.<>9__61_0;
        if(val_6 != null)
        {
                return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.丄丄丆东丑三丝专丂(), predicate:  null);
        }
        
        val_6 = null;
        val_6 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BPChallengesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPChallengesController.<>c::三与上上万上专丌丌(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑));
        BPChallengesController.<>c.<>9__61_0 = val_6;
        return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.丄丄丆东丑三丝专丂(), predicate:  null);
    }
    internal bool 一万丘丁三丆下丝丞(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丟专三丙丒丄丂下与)
    {
        var val_7;
        if(丟专三丙丒丄丂下与 != null)
        {
                if((PGCompany.BattlePass.万丈上下三丅丘丛丒.丏一丗丐丂万丈丟丆(万丒丑且丈丂丘东丑:  丟专三丙丒丄丂下与.不业丙丒丂丞下丆丙())) != false)
        {
                if(丟专三丙丒丄丂下与.丄上丝丌上下丒上丙() == null)
        {
                return (bool)val_7;
        }
        
            if(丟专三丙丒丄丂下与.丄上丝丌上下丒上丙() == null)
        {
                return (bool)val_7;
        }
        
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    internal bool 丕业与丅丟七七世不()
    {
        object val_8;
        System.Collections.Generic.IEnumerable<TSource> val_9;
        val_8 = new BPChallengesController.丝丝下不丗专丅丒下();
        val_8 = new System.Object();
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_2 = this.七丗丒丟一一丅业丑();
        if(val_2 != null)
        {
                .丞丅上丏丂且下丅与 = val_2.业上丙丞丐丄丆丅七();
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_4 = this.丑专丘三丟丐丅上上();
            if(val_4 != null)
        {
                System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean> val_5 = new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  new BPChallengesController.丝丝下不丗专丅丒下(), method:  System.Boolean BPChallengesController.丝丝下不丗专丅丒下::丗专丂一丅丆上丝与(PGCompany.BattlePass.BPChallengeRememberedReward 丁丂专业丁丅丅丈丙));
            val_9 = val_4;
        }
        else
        {
                val_9 = 0;
        }
        
        }
        
        val_9 = val_9 & 1;
        return (bool)val_9;
    }
    internal System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> 丑专丘三丟丐丅上上()
    {
        var val_25;
        int val_26;
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_1 = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward>();
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_2 = this.丄丄丆东丑三丝专丂();
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_4 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_4 == null)
        {
                return val_1;
        }
        
        val_25 = 0;
        goto label_3;
        label_35:
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_5 = val_2.Item[0];
        if(val_5.世丑丐丅丆丂丘不丁() != false)
        {
                if(val_5.丏丐七上业丆与丘专() == 1)
        {
                if(val_4.专丟专一丒且丘与丌() == 0)
        {
            goto label_28;
        }
        
        }
        
            val_26 = val_5.业上丙丞丐丄丆丅七();
            if((Progress.七七世万专丕丁上业.上业丑丅业不东丛业().专东专丄丆丙与丘丆(世不下丟世一丝丐丗:  val_5.万上丁一丞业业万东()).七丒丕业丐丐丕丑丏().Contains(item:  val_26)) != true)
        {
                if(val_5.业上丙丞丐丄丆丅七() == 9999)
        {
                if(Progress.七七世万专丕丁上业.上业丑丅业不东丛业().丑丆丏丟丗丌丄丟丝() == true)
        {
            goto label_28;
        }
        
        }
        
            if(val_5.丈丏丁东上与东丙丕().Count != 0)
        {
                if(val_5.三丝丄丈丆丂专丄东() != 30)
        {
                PGCompany.BattlePass.BPChallangeDO val_22 = val_5.丁专丗万三上丟三丆();
            val_26 = val_22.Id;
            .Id = val_26;
            .Rewards = val_5.丈丏丁东上与东丙丕();
            .Challenge = val_5;
            val_1.Add(item:  new PGCompany.BattlePass.BPChallengeRememberedReward());
        }
        
        }
        
        }
        
        }
        
        label_28:
        val_25 = 1;
        label_3:
        if(val_25 < val_2.Count)
        {
            goto label_35;
        }
        
        return val_1;
    }
    public BPChallengesController()
    {
        this.丌东丞东丁万业丆丏 = new System.Collections.Generic.List<System.Int32>();
        this.丘业业丒一丅东专丅 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>>();
    }
    private static BPChallengesController()
    {
    
    }
    private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丌下与一丗丙丒丑丏(PGCompany.BattlePass.BPChallangeDO 世丁丏不丌世一丞丕)
    {
        return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)new PGCompany.BattlePass.三丛上丁丗丌丆丌东(一丐丗丁丞丆丅丟丄:  世丁丏不丌世一丞丕, 世不下丟世一丝丐丗:  this.丐下不且丕丟丝与丌.SeasonId, 上丕丈丞丌丘丅不与:  Progress.七七世万专丕丁上业.上业丑丅业不东丛业().专东专丄丆丙与丘丆(世不下丟世一丝丐丗:  this.丐下不且丕丟丝与丌.SeasonId).三业万丁丕丒专丒且(且丂七下丙丆三丐三:  世丁丏不丌世一丞丕.Id));
    }

}
