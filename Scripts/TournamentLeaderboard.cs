using UnityEngine;
[Serializable]
public sealed class TournamentLeaderboard
{
    // Fields
    public int dataTimestamp;
    public string id;
    public string SeasonID;
    public System.Collections.Generic.List<TournamentPlayer> players;
    public int scoresTimestamp;
    public RatingSystem.RatingLeague league;
    
    // Methods
    public void 丐丅万丑丂丄丘丘三(string 丏世丑万世一七丟丞, int 下丄丕丕世万专业丑)
    {
        List.Enumerator<T> val_1 = this.players.GetEnumerator();
        label_4:
        if((407993512 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_2.m_stringLength, b:  丏世丑万世一七丟丞)) == false)
        {
            goto label_4;
        }
        
        mem2[0] = 下丄丕丕世万专业丑;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this = this.players;
        TournamentPlayer val_4 = new TournamentPlayer();
        if(val_4 != null)
        {
                .id = 丏世丑万世一七丟丞;
        }
        else
        {
                mem[16] = 丏世丑万世一七丟丞;
        }
        
        .score = 下丄丕丕世万专业丑;
        this.Add(item:  val_4);
    }
    public void 丙丐丂丞丙丐上不上(string 丏世丑万世一七丟丞, string 丆丆丂业丒丈丙丒丅, string 丞丌丐丞丞丘丏专下)
    {
        string val_7;
        System.Collections.Generic.List<TournamentPlayer> val_8;
        val_7 = 丆丆丂业丒丈丙丒丅;
        val_8 = this;
        if((System.String.op_Equality(a:  丏世丑万世一七丟丞, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
        {
                return;
        }
        
        val_8 = this.players;
        List.Enumerator<T> val_3 = val_8.GetEnumerator();
        label_5:
        if((408150568 & 1) == 0)
        {
            goto label_6;
        }
        
        val_8 = 0.丐丏七丌丕丗业且上();
        if((System.String.op_Equality(a:  val_4.m_stringLength, b:  丏世丑万世一七丟丞)) == false)
        {
            goto label_5;
        }
        
        if((System.String.op_Inequality(a:  val_7, b:  System.String.alignConst)) != false)
        {
                mem2[0] = val_7;
        }
        
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public int 丆丏业专与万丑三丂()
    {
        var val_16;
        var val_18;
        System.Func<TournamentPlayer, System.Int32> val_20;
        var val_21;
        val_16 = null;
        val_16 = null;
        if((TournamentLeaderboard.<>c.<>9__8_0) == null)
        {
            goto label_3;
        }
        
        label_15:
        if((this.players.Find(match:  TournamentLeaderboard.<>c.<>9__8_0)) == null)
        {
            goto label_5;
        }
        
        val_1.nickname = ProfileController.丆三丂丂丆上丆丕专();
        val_1.score = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        goto label_11;
        label_3:
        TournamentLeaderboard.<>c.<>9__8_0 = new System.Predicate<TournamentPlayer>(object:  TournamentLeaderboard.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TournamentLeaderboard.<>c::丅丛七下一丑丑丑丆(TournamentPlayer 专丞上七七且丝七丗));
        if(this.players != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_5:
        .id = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        .nickname = ProfileController.丆三丂丂丆上丆丕专();
        .score = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
        this.players.Add(item:  new TournamentPlayer());
        label_11:
        val_18 = null;
        val_18 = null;
        val_20 = TournamentLeaderboard.<>c.<>9__8_1;
        if(val_20 == null)
        {
                System.Func<TournamentPlayer, System.Int32> val_11 = null;
            val_20 = val_11;
            val_11 = new System.Func<TournamentPlayer, System.Int32>(object:  TournamentLeaderboard.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TournamentLeaderboard.<>c::一不东丒丟丟丈丕丟(TournamentPlayer 专丞上七七且丝七丗));
            TournamentLeaderboard.<>c.<>9__8_1 = val_20;
        }
        
        System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<TournamentPlayer>(source:  System.Linq.Enumerable.OrderByDescending<TournamentPlayer, System.Int32>(source:  this.players, keySelector:  val_11));
        this.players = val_13;
        val_21 = null;
        val_21 = null;
        if((TournamentLeaderboard.<>c.<>9__8_2) == null)
        {
            goto label_30;
        }
        
        label_35:
        int val_14 = val_13.FindIndex(match:  TournamentLeaderboard.<>c.<>9__8_2);
        val_14 = val_14 + 1;
        return (int)val_14;
        label_30:
        TournamentLeaderboard.<>c.<>9__8_2 = new System.Predicate<TournamentPlayer>(object:  TournamentLeaderboard.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TournamentLeaderboard.<>c::丌丁丄不丅丏丂丌丄(TournamentPlayer 专丞上七七且丝七丗));
        if(val_13 != null)
        {
            goto label_35;
        }
        
        goto label_35;
    }
    internal string 丂丆丑世一不丘丏七()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    internal static TournamentLeaderboard 丟与业下丟丗丗万丕(string 下丕世不丈专万丗万)
    {
        var val_3;
        if(下丕世不丈专万丗万 != null)
        {
                val_3 = 0;
            if((System.String.op_Equality(a:  下丕世不丈专万丗万, b:  System.String.alignConst)) == true)
        {
                return (TournamentLeaderboard)val_3;
        }
        
            TournamentLeaderboard val_2 = UnityEngine.JsonUtility.FromJson<TournamentLeaderboard>(json:  下丕世不丈专万丗万);
            return (TournamentLeaderboard)val_3;
        }
        
        val_3 = 0;
        return (TournamentLeaderboard)val_3;
    }
    internal static TournamentLeaderboard 业三世丝且丈丐丄丁(string 下丕世不丈专万丗万)
    {
        var val_6;
        if(下丕世不丈专万丗万 != null)
        {
                if((System.String.op_Equality(a:  下丕世不丈专万丗万, b:  System.String.alignConst)) == false)
        {
            goto label_2;
        }
        
        }
        
        TournamentLeaderboard val_2 = null;
        val_6 = val_2;
        val_2 = new TournamentLeaderboard();
        RatingLeague val_4 = RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        if(val_6 == null)
        {
            goto label_6;
        }
        
        .league = val_4;
        goto label_7;
        label_2:
        val_6 = UnityEngine.JsonUtility.FromJson<TournamentLeaderboard>(json:  下丕世不丈专万丗万);
        if(val_6 == null)
        {
            goto label_8;
        }
        
        label_7:
        val_5.dataTimestamp = 0;
        goto label_9;
        label_6:
        .league = val_4;
        label_8:
        mem[16] = 0;
        label_9:
        .scoresTimestamp = 0;
        return (TournamentLeaderboard)val_6;
    }
    public TournamentLeaderboard()
    {
        this.id = System.String.alignConst;
        this.SeasonID = System.String.alignConst;
        this.players = new System.Collections.Generic.List<TournamentPlayer>();
        this.league = 0;
    }

}
