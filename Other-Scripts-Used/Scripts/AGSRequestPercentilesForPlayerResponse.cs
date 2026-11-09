using UnityEngine;
public class AGSRequestPercentilesForPlayerResponse : AGSRequestPercentilesResponse
{
    // Fields
    public string playerId;
    
    // Methods
    public static AGSRequestPercentilesForPlayerResponse FromJSON(string json)
    {
        object val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_34;
        var val_35;
        System.Collections.Hashtable val_38;
        var val_39;
        var val_40;
        var val_44;
        string val_45;
        val_28 = new AGSRequestPercentilesForPlayerResponse();
        val_28 = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_29 = val_2.ToString();
        if(val_28 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_29 = "";
        if(val_28 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524048797584] = val_29;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_30 = 0;
        }
        
        mem[1152921524048797592] = val_30;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_31 = "";
        }
        
        mem[1152921524048797600] = val_31;
        if((val_2 & 1) == 0)
        {
            goto label_13;
        }
        
        val_32 = val_2;
        if(val_32 == null)
        {
            goto label_16;
        }
        
        val_32 = 0;
        goto label_16;
        label_13:
        AGSLeaderboard val_7 = AGSLeaderboard.GetBlankLeaderboard();
        goto label_17;
        label_16:
        label_17:
        mem[1152921524048797608] = AGSLeaderboard.fromHashtable(hashtable:  null);
        System.Collections.Generic.List<AGSLeaderboardPercentile> val_10 = new System.Collections.Generic.List<AGSLeaderboardPercentile>();
        mem[1152921524048797616] = null;
        if((val_2 & 1) == 0)
        {
            goto label_81;
        }
        
        if(val_2 != null)
        {
                val_34 = null;
        }
        
        if(val_2 != null)
        {
                val_34 = null;
        }
        
        val_35 = 0;
        label_41:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        val_38 = Current;
        if(val_38 != null)
        {
                val_38 = 0;
        }
        
        X23.Add(item:  AGSLeaderboardPercentile.fromHashTable(percentilesHashtable:  val_38));
        goto label_41;
        label_30:
        val_39 = 0;
        val_40 = 0;
        var val_29 = 0;
        val_29 = val_29 + 1;
        Dispose();
        if( == 1)
        {
            goto label_77;
        }
        
        if( == false)
        {
            goto label_81;
        }
        
        if(300 != 300)
        {
            goto label_79;
        }
        
        goto label_81;
        label_77:
        if( == false)
        {
            goto label_81;
        }
        
        label_79:
        label_81:
        if((val_2 & 1) == 0)
        {
            goto label_83;
        }
        
        val_44 = System.Int32.Parse(s:  val_2.ToString());
        if(val_28 != null)
        {
            goto label_87;
        }
        
        goto label_86;
        label_83:
        val_44 = 0;
        if(val_28 != null)
        {
            goto label_87;
        }
        
        label_86:
        label_87:
        mem[1152921524048797624] = val_44;
        object val_24 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_2.ToString());
        mem[1152921524048797628] = null;
        if((val_2 & 1) != 0)
        {
                string val_25 = val_2.ToString();
        }
        else
        {
                val_45 = "";
        }
        
        .playerId = val_45;
        return (AGSRequestPercentilesForPlayerResponse)val_28;
    }
    public static AGSRequestPercentilesForPlayerResponse GetBlankResponseWithError(string error, string leaderboardId = "", string playerId = "", LeaderboardScope scope = 0, int userData = 0)
    {
        var val_5;
        AGSLeaderboard val_6;
        var val_7;
        AGSRequestPercentilesForPlayerResponse val_1 = new AGSRequestPercentilesForPlayerResponse();
        if(val_1 != null)
        {
                mem[1152921524049024328] = userData;
            val_5 = val_1;
            mem[1152921524049024320] = error;
            mem[1152921524049024336] = leaderboardId;
            mem[1152921524049024364] = scope;
            val_6 = AGSLeaderboard.GetBlankLeaderboard();
            val_7 = val_1;
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
            mem[32] = leaderboardId;
            val_5 = 60;
            mem[60] = scope;
            val_6 = AGSLeaderboard.GetBlankLeaderboard();
            val_7 = 0;
        }
        
        mem[40] = val_6;
        System.Collections.Generic.List<AGSLeaderboardPercentile> val_4 = new System.Collections.Generic.List<AGSLeaderboardPercentile>();
        if(val_1 != null)
        {
                mem[48] = val_4;
            mem[56] = 0;
            mem[60] = scope;
        }
        else
        {
                mem[48] = val_4;
            mem[56] = 0;
            mem[60] = scope;
        }
        
        .playerId = playerId;
        return val_1;
    }
    public static AGSRequestPercentilesForPlayerResponse GetPlatformNotSupportedResponse(string leaderboardId, string playerId, LeaderboardScope scope, int userData)
    {
        return AGSRequestPercentilesForPlayerResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", leaderboardId:  leaderboardId, playerId:  playerId, scope:  scope, userData:  userData);
    }
    public AGSRequestPercentilesForPlayerResponse()
    {
        val_1 = new System.Object();
    }

}
