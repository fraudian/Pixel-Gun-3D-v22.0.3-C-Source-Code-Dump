using UnityEngine;
public sealed class LeaderboardsController : Singleton<LeaderboardsController>
{
    // Fields
    private const int 丈下与丕丑下丝东丄 = 14400;
    private const int 一三丑万丗丒且丞丟 = 14400;
    private static System.Action 丒丄丒上专丙世丄丙;
    private System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丂世丁下且丛专丄丕;
    private const string 丈丗三万世丛丕业丞 = "top-clans-cache";
    private const string 万东世丗万丅上丈丈 = "top-clans-cache-pulled-time";
    private LeaderboardsController.丐丗丘一丁专东丞世 丅丕丘业丞丟丕万丅;
    private const string 丒下与丁专万丏丅不 = "top-players-cache";
    private const string 七与业下三丁且上丏 = "top-players-all-and-cache-pulled-time";
    
    // Methods
    internal static void 万丅丙七丛丘丙丝与(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  LeaderboardsController.七与业下三丁且上丏, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 一丒一不丗丝不丅下(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  LeaderboardsController.七与业下三丁且上丏, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private static string 丙业丌丄三一七丘丄(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (string)"top-players-league-pulled-"("top-players-league-pulled-") + 丙丑七万丆万丆且丌.ToString();
    }
    internal System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丂丂丛与丟世丁且丒()
    {
        System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_1 = this.丂世丁下且丛专丄丕;
        if(val_1 != null)
        {
                return val_1;
        }
        
        this.丅丝丑丟与丂丅丈七();
        val_1 = this.丂世丁下且丛专丄丕;
        return val_1;
    }
    internal System.Collections.Generic.Dictionary<RatingSystem.RatingLeague, System.Collections.Generic.List<TournamentPlayer>> 一与七丗丝不东丙且()
    {
        丐丗丘一丁专东丞世 val_1 = this.丅丕丘业丞丟丕万丅;
        if(val_1 != null)
        {
                return (System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>>)this.丅丕丘业丞丟丕万丅.data;
        }
        
        this.丞丝丆丁三丙世丑丐();
        val_1 = this.丅丕丘业丞丟丕万丅;
        if(val_1 != null)
        {
                return (System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>>)this.丅丕丘业丞丟丕万丅.data;
        }
    
    }
    internal void 丐丅丝下与丌上业丑()
    {
        if((PixelTime.丙丅丅业丟丁世丁丗() - (丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "top-clans-cache-pulled-time", 丞丌丑丛上丕丙丕下:  0))) < 14401)
        {
                return;
        }
        
        this.专丆万下上万业丘七(丂丕上丄一丘丞且丙:  true, 业丙下丙丁七丄世与:  false, 下丞上丙专丈万三丅:  0);
    }
    internal void 丆丅丒丐丁丞丐丁下()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if((PixelTime.丙丅丅业丟丁世丁丗() - (丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "top-players-all-and-cache-pulled-time", 丞丌丑丛上丕丙丕下:  0))) < 14401)
        {
                return;
        }
        
        this.专丆万下上万业丘七(丂丕上丄一丘丞且丙:  false, 业丙下丙丁七丄世与:  true, 下丞上丙专丈万三丅:  0);
        val_6 = 丞东丑专丛丆丄丝世.丞丏丞丗不丐与一丌<RatingLeague>();
        val_7 = 0;
        goto label_8;
        label_13:
        丌丝世丞世丛丆丅丟.万丈丛丞丕业丙东丄(下上丐丆丝丟丝丒不:  LeaderboardsController.丙业丌丄三一七丘丄(丙丑七万丆万丆且丌:  val_6[0]), 下下丏一丙不丘丌丞:  false, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        val_7 = 1;
        label_8:
        if(val_7 < val_4.Length)
        {
            goto label_13;
        }
    
    }
    internal void 丂丐丂丌丂丂丄七丒(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        if((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  LeaderboardsController.丙业丌丄三一七丘丄(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌), 丞丌丑丛上丕丙丕下:  0)) == 1)
        {
                return;
        }
        
        this.专丆万下上万业丘七(丂丕上丄一丘丞且丙:  false, 业丙下丙丁七丄世与:  false, 下丞上丙专丈万三丅:  丙丑七万丆万丆且丌);
        丌丝世丞世丛丆丅丟.万丈丛丞丕业丙东丄(下上丐丆丝丟丝丒不:  LeaderboardsController.丙业丌丄三一七丘丄(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌), 下下丏一丙不丘丌丞:  true, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 专丆万下上万业丘七(bool 丂丕上丄一丘丞且丙, bool 业丙下丙丁七丄世与, RatingSystem.RatingLeague 下丞上丙专丈万三丅)
    {
        var val_13;
        LeaderboardsController.三丅丞丒丕丅专一丅 val_1 = new LeaderboardsController.三丅丞丒丕丅专一丅();
        if(val_1 != null)
        {
                .丂丕上丄一丘丞且丙 = 丂丕上丄一丘丞且丙;
            .业丙下丙丁七丄世与 = 业丙下丙丁七丄世与;
        }
        else
        {
                mem[16] = 丂丕上丄一丘丞且丙;
            .业丙下丙丁七丄世与 = 业丙下丙丁七丄世与;
        }
        
        .下丞上丙专丈万三丅 = 下丞上丙专丈万三丅;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.Object, System.Object>(丏丂万业丙专丏丒丒:  val_6, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean LeaderboardsController.三丅丞丒丕丅专一丅::七丙东三下丑不丏丏()), 下上丐丆丝丟丝丒不:  "cl", 丙业与丙丗丝不丈东:  1);
        丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.Object, System.Object>(丏丂万业丙专丏丒丒:  val_6, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean LeaderboardsController.三丅丞丒丕丅专一丅::丝专丞丛上丆丐丘丁()), 下上丐丆丝丟丝丒不:  "comp", 丙业与丙丗丝不丈东:  1);
        丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.Object, System.Object>(丏丂万业丙专丏丒丒:  val_6, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean LeaderboardsController.三丅丞丒丕丅专一丅::丘东丟业七丝丅丄丒()), 下上丐丆丝丟丝丒不:  "league", 丙业与丙丗丝不丈东:  (LeaderboardsController.三丅丞丒丕丅专一丅)[1152921538230201152].下丞上丙专丈万三丅);
        val_13 = null;
        val_13 = null;
        int val_12 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒丞丗丕七与丏东丙, 一丐丗丁丞丆丅丟丄:  val_6, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void LeaderboardsController::丁丏丘丌上丛丌万东(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 丁丏丘丌上丛丌万东(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_9;
        object val_5 = 0;
        object val_2 = 0;
        object val_7 = 0;
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) == true)
        {
                return;
        }
        
        if((丑与丂丌世丕丆一丗.TryGetValue(key:  "data", value: out  val_2)) == false)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                return;
        }
        
        val_9 = 1152921504689381376;
        var val_4 = (((mem[282584257676871] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        if(((val_4.TryGetValue(key:  "top_clans", value: out  val_5)) != false) && (val_5 != 0))
        {
                this.丏且丈与不丘丏丝丅(丟专世上丄下丟三丈:  val_5);
        }
        
        if(((val_4.TryGetValue(key:  "top_competitions", value: out  val_7)) != false) && (val_7 != 0))
        {
                this.丂丁丈丄与丌丂丅丆(七一丑丕三东下丟丞:  val_7);
        }
        
        if(LeaderboardsController.七与业下三丁且上丏 == null)
        {
                return;
        }
        
        LeaderboardsController.七与业下三丁且上丏.Invoke();
    }
    private void 丅丝丑丟与丂丅丈七()
    {
        var val_5;
        if((Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "top-clans-cache", 丞丌丑丛上丕丙丕下:  System.String.alignConst))) != null)
        {
                val_5 = 0;
        }
        
        this.丂世丁下且丛专丄丕 = LeaderboardsController.丒丗下丂丅东不专下(丙丑万丐丐丟丐丕丌:  null);
    }
    private void 丞丝丆丁三丙世丑丐()
    {
        string val_1 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "top-players-cache", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        DataSystem.丈且丈上不下且丝丒 val_2 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_5 = 0;
        val_5 = val_5 + 1;
        if(val_2 == null)
        {
            goto label_10;
        }
        
        label_13:
        this.丅丕丘业丞丟丕万丅 = val_2;
        return;
        label_10:
        LeaderboardsController.丐丗丘一丁专东丞世 val_4 = new LeaderboardsController.丐丗丘一丁专东丞世();
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    private void 丏且丈与不丘丏丝丅(System.Collections.Generic.List<object> 丟专世上丄下丟三丈)
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "top-clans-cache", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丟专世上丄下丟三丈));
        this.丂世丁下且丛专丄丕 = LeaderboardsController.丒丗下丂丅东不专下(丙丑万丐丐丟丐丕丌:  丟专世上丄下丟三丈);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "top-clans-cache-pulled-time", 下下丏一丙不丘丌丞:  PixelTime.丙丅丅业丟丁世丁丗(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丂丁丈丄与丌丂丅丆(System.Collections.Generic.Dictionary<string, object> 七一丑丕三东下丟丞)
    {
        var val_5;
        丐丗丘一丁专东丞世 val_13;
        var val_14;
        System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>> val_1 = this.丁东丏丑业专丈下丂(万丝且丘不丑丝下丑:  七一丑丕三东下丟丞);
        if(val_1 == null)
        {
            goto label_15;
        }
        
        if(this.丅丕丘业丞丟丕万丅 == null)
        {
            goto label_2;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = val_1.GetEnumerator();
        label_6:
        if(((-735683568) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        this.丅丕丘业丞丟丕万丅.data.set_Item(key:  val_6._value._obj.丙东专丂世丈丏丁丂(), value:  val_6._value._obj);
        goto label_6;
        label_2:
        LeaderboardsController.丐丗丘一丁专东丞世 val_8 = null;
        val_13 = val_8;
        val_8 = new LeaderboardsController.丐丗丘一丁专东丞世();
        .data = val_1;
        this.丅丕丘业丞丟丕万丅 = val_13;
        goto label_15;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_15:
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = 0;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "top-players-cache", 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丅丕丘业丞丟丕万丅));
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "top-players-all-and-cache-pulled-time", 下下丏一丙不丘丌丞:  PixelTime.丙丅丅业丟丁世丁丗(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    internal static System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> 丒丗下丂丅东不专下(System.Collections.Generic.List<object> 丙丑万丐丐丟丐丕丌)
    {
        int val_41;
        int val_42;
        int val_43;
        var val_44;
        var val_45;
        object val_12 = 0;
        object val_10 = 0;
        object val_16 = 0;
        object val_14 = 0;
        object val_22 = 0;
        object val_19 = 0;
        System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_1 = new System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>();
        if(丙丑万丐丐丟丐丕丌 == null)
        {
                return val_1;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = System.Linq.Enumerable.OfType<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  丙丑万丐丐丟丐丕丌).GetEnumerator();
        label_75:
        var val_41 = 0;
        val_41 = val_41 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_42 = 0;
        val_42 = val_42 + 1;
        T val_8 = val_4.Current;
        new 丞丂丘丒丟丞丑下丄() = new 丞丂丘丒丟丞丑下丄(丞丅上丏丂且下丅与:  System.String.alignConst, 丒丘丏上丙丟丑丕丈:  System.String.alignConst, 丌万丌丅丐丗丘专丒:  System.String.alignConst, 丁丅丈丌丟世丗丗丟:  1);
        if((val_8.TryGetValue(key:  "id", value: out  val_10)) == false)
        {
            goto label_75;
        }
        
        val_41 = val_10;
        if(val_41 != 0)
        {
                if(1179403647 == null)
        {
            goto label_21;
        }
        
        }
        
        val_41 = System.String.alignConst;
        label_21:
        new 丞丂丘丒丟丞丑下丄().下东丄丄丟丞东丁丅(丙业与丙丗丝不丈东:  val_41);
        if((val_8.TryGetValue(key:  "logo", value: out  val_12)) == false)
        {
            goto label_24;
        }
        
        val_42 = val_12;
        if(val_42 != 0)
        {
                if(1179403647 == null)
        {
            goto label_26;
        }
        
        }
        
        val_42 = System.String.alignConst;
        label_26:
        new 丞丂丘丒丟丞丑下丄().丑丛丟丗专丈丄专丞(丙业与丙丗丝不丈东:  val_42);
        goto label_28;
        label_24:
        new 丞丂丘丒丟丞丑下丄().丑丛丟丗专丈丄专丞(丙业与丙丗丝不丈东:  System.String.alignConst);
        label_28:
        if((val_8.TryGetValue(key:  "name", value: out  val_14)) == false)
        {
            goto label_31;
        }
        
        val_43 = val_14;
        if(val_43 != 0)
        {
                if(1179403647 == null)
        {
            goto label_33;
        }
        
        }
        
        val_43 = System.String.alignConst;
        label_33:
        new 丞丂丘丒丟丞丑下丄().丌丏上丏东且丄丑丌(丙业与丙丗丝不丈东:  val_43);
        goto label_35;
        label_31:
        new 丞丂丘丒丟丞丑下丄().丌丏上丏东且丄丑丌(丙业与丙丗丝不丈东:  System.String.alignConst);
        label_35:
        if((val_8.TryGetValue(key:  "member_cnt", value: out  val_16)) != false)
        {
                .不一一丙丘专丟丌丌 = System.Convert.ToInt32(value:  val_16);
        }
        
        if((val_8.TryGetValue(key:  "officers_cnt", value: out  val_19)) != false)
        {
                .上丞三七业世且丆世 = System.Convert.ToInt32(value:  val_19);
        }
        
        if((val_8.TryGetValue(key:  "currency", value: out  val_22)) != false)
        {
                new 丞丂丘丒丟丞丑下丄().丁丐七丘且丗丘业七(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_22));
        }
        else
        {
                if((val_8.TryGetValue(key:  "siege_won_cnt", value: out  val_22)) != false)
        {
                new 丞丂丘丒丟丞丑下丄().丁丐七丘且丗丘业七(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  val_22));
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  new 丞丂丘丒丟丞丑下丄().业丐丐三丕一丗丛丁())) == true)
        {
            goto label_75;
        }
        
        PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_30 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
        if((val_30.丂丕万一丄一丂丗丒.ContainsKey(key:  new 丞丂丘丒丟丞丑下丄().业丐丐三丕一丗丛丁())) != false)
        {
                PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_34 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
            val_34.丂丕万一丄一丂丗丒.set_Item(key:  new 丞丂丘丒丟丞丑下丄().业丐丐三丕一丗丛丁(), value:  new 丞丂丘丒丟丞丑下丄());
        }
        else
        {
                PGCompany.Clans.Network.丞丝世上丏与丂丒上 val_37 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().上丕与与世丁丛丛丑();
            val_37.丂丕万一丄一丂丗丒.Add(key:  new 丞丂丘丒丟丞丑下丄().业丐丐三丕一丗丛丁(), value:  new 丞丂丘丒丟丞丑下丄());
        }
        
        val_1.Add(item:  new 丞丂丘丒丟丞丑下丄());
        goto label_75;
        label_12:
        val_44 = 0;
        val_45 = 0;
        if(val_4 == null)
        {
            
        }
        else
        {
                var val_43 = 0;
            val_43 = val_43 + 1;
            val_4.Dispose();
        }
        
        if( != 1)
        {
                if(null == null)
        {
                return val_1;
        }
        
            if(466 == 466)
        {
                return val_1;
        }
        
            return val_1;
        }
        
        if(null != null)
        {
                return val_1;
        }
        
        return val_1;
    }
    private System.Collections.Generic.Dictionary<RatingSystem.RatingLeague, System.Collections.Generic.List<TournamentPlayer>> 丁东丏丑业专丈下丂(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
    {
        var val_5;
        System.Collections.Generic.Dictionary<TKey, TValue> val_26;
        int val_27;
        int val_8 = 0;
        string val_16 = 0;
        string val_14 = 0;
        int val_18 = 0;
        System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>> val_1 = null;
        val_26 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>>();
        if(万丝且丘不丑丝下丑 == null)
        {
                return (System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>>);
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = 万丝且丘不丑丝下丑.GetEnumerator();
        label_30:
        if(((-735245120) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if((val_6._value._obj == 0) || ((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_6._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  val_8)) == false))
        {
            goto label_30;
        }
        
        System.Collections.Generic.List<TournamentPlayer> val_11 = new System.Collections.Generic.List<TournamentPlayer>(capacity:  val_6._value._obj.Count);
        var val_26 = 0;
        label_13:
        if(val_26 >= val_6._value._obj.Count)
        {
            goto label_9;
        }
        
        object val_13 = val_6._value._obj.Item[0];
        label_28:
        val_26 = val_26 + 1;
        goto label_13;
        label_21:
        val_27 = 2;
        int val_22 = val_27 - 1;
        if(val_22 >= null.Count)
        {
            goto label_18;
        }
        
        TournamentPlayer val_23 = null.Item[val_22];
        if(val_23.score > 0)
        {
            goto label_21;
        }
        
        .place = val_27;
        null.Insert(index:  val_22, item:  new TournamentPlayer());
        goto label_28;
        label_18:
        .place = null.Count + 1;
        null.Add(item:  new TournamentPlayer());
        goto label_28;
        label_9:
        val_1.set_Item(key:  val_8, value:  null);
        goto label_30;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_26 = val_26;
        return (System.Collections.Generic.Dictionary<RatingLeague, System.Collections.Generic.List<TournamentPlayer>>);
    }
    public LeaderboardsController()
    {
    
    }

}
