using UnityEngine;
public class AGSRequestPercentilesResponse : AGSRequestResponse
{
    // Fields
    public string leaderboardId;
    public AGSLeaderboard leaderboard;
    public System.Collections.Generic.List<AGSLeaderboardPercentile> percentiles;
    public int userIndex;
    public LeaderboardScope scope;
    
    // Methods
    public static AGSRequestPercentilesResponse FromJSON(string json)
    {
        object val_27;
        var val_28;
        var val_29;
        string val_30;
        var val_31;
        var val_33;
        var val_34;
        System.Collections.Hashtable val_37;
        var val_38;
        var val_39;
        int val_43;
        val_27 = new AGSRequestPercentilesResponse();
        val_27 = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_28 = val_2.ToString();
        if(val_27 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_28 = "";
        if(val_27 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524049470960] = val_28;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_29 = 0;
        }
        
        mem[1152921524049470968] = val_29;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_30 = "";
        }
        
        .leaderboardId = val_30;
        if((val_2 & 1) == 0)
        {
            goto label_13;
        }
        
        val_31 = val_2;
        if(val_31 == null)
        {
            goto label_16;
        }
        
        val_31 = 0;
        goto label_16;
        label_13:
        AGSLeaderboard val_7 = AGSLeaderboard.GetBlankLeaderboard();
        goto label_17;
        label_16:
        label_17:
        .leaderboard = AGSLeaderboard.fromHashtable(hashtable:  null);
        System.Collections.Generic.List<AGSLeaderboardPercentile> val_10 = new System.Collections.Generic.List<AGSLeaderboardPercentile>();
        .percentiles = null;
        if((val_2 & 1) == 0)
        {
            goto label_81;
        }
        
        if(val_2 != null)
        {
                val_33 = null;
        }
        
        if(val_2 != null)
        {
                val_33 = null;
        }
        
        val_34 = 0;
        label_41:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_37 = Current;
        if(val_37 != null)
        {
                val_37 = 0;
        }
        
        (AGSRequestPercentilesResponse)[1152921524049470944].percentiles.Add(item:  AGSLeaderboardPercentile.fromHashTable(percentilesHashtable:  val_37));
        goto label_41;
        label_30:
        val_38 = 0;
        val_39 = 0;
        var val_28 = 0;
        val_28 = val_28 + 1;
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
        
        val_43 = System.Int32.Parse(s:  val_2.ToString());
        if(val_27 != null)
        {
            goto label_87;
        }
        
        goto label_86;
        label_83:
        val_43 = 0;
        if(val_27 != null)
        {
            goto label_87;
        }
        
        label_86:
        label_87:
        .userIndex = val_43;
        object val_24 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_2.ToString());
        .scope = null;
        return (AGSRequestPercentilesResponse)val_27;
    }
    public static AGSRequestPercentilesResponse GetBlankResponseWithError(string error, string leaderboardId = "", LeaderboardScope scope = 0, int userData = 0)
    {
        AGSLeaderboard val_5;
        AGSRequestPercentilesResponse val_1 = new AGSRequestPercentilesResponse();
        if(val_1 != null)
        {
                mem[1152921524049689504] = error;
            mem[1152921524049689512] = userData;
            .leaderboardId = leaderboardId;
            .scope = scope;
            val_5 = AGSLeaderboard.GetBlankLeaderboard();
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
            mem[32] = leaderboardId;
            .scope = scope;
            val_5 = AGSLeaderboard.GetBlankLeaderboard();
        }
        
        .leaderboard = val_5;
        System.Collections.Generic.List<AGSLeaderboardPercentile> val_4 = new System.Collections.Generic.List<AGSLeaderboardPercentile>();
        if(val_1 != null)
        {
                .percentiles = val_4;
            .userIndex = 0;
        }
        else
        {
                mem[48] = val_4;
            mem[56] = 0;
        }
        
        .scope = scope;
        return val_1;
    }
    public static AGSRequestPercentilesResponse GetPlatformNotSupportedResponse(string leaderboardId, LeaderboardScope scope, int userData)
    {
        return AGSRequestPercentilesResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", leaderboardId:  leaderboardId, scope:  scope, userData:  userData);
    }
    public AGSRequestPercentilesResponse()
    {
        val_1 = new System.Object();
    }

}
