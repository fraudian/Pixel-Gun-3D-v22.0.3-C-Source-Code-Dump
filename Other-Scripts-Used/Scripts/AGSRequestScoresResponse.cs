using UnityEngine;
public class AGSRequestScoresResponse : AGSRequestResponse
{
    // Fields
    public string leaderboardId;
    public AGSLeaderboard leaderboard;
    public LeaderboardScope scope;
    public System.Collections.Generic.List<AGSScore> scores;
    
    // Methods
    public static AGSRequestScoresResponse FromJSON(string json)
    {
        object val_25;
        var val_26;
        var val_27;
        string val_28;
        var val_29;
        var val_31;
        var val_32;
        System.Collections.Hashtable val_35;
        var val_36;
        var val_37;
        val_25 = new AGSRequestScoresResponse();
        val_25 = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_26 = val_2.ToString();
        if(val_25 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_26 = "";
        if(val_25 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524051323040] = val_26;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_27 = 0;
        }
        
        mem[1152921524051323048] = val_27;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_28 = "";
        }
        
        .leaderboardId = val_28;
        if((val_2 & 1) == 0)
        {
            goto label_13;
        }
        
        val_29 = val_2;
        if(val_29 == null)
        {
            goto label_16;
        }
        
        val_29 = 0;
        goto label_16;
        label_13:
        AGSLeaderboard val_7 = AGSLeaderboard.GetBlankLeaderboard();
        goto label_17;
        label_16:
        label_17:
        .leaderboard = AGSLeaderboard.fromHashtable(hashtable:  null);
        System.Collections.Generic.List<AGSScore> val_10 = new System.Collections.Generic.List<AGSScore>();
        .scores = null;
        if((val_2 & 1) == 0)
        {
            goto label_81;
        }
        
        if(val_2 != null)
        {
                val_31 = null;
        }
        
        if(val_2 != null)
        {
                val_31 = null;
        }
        
        val_32 = 0;
        label_41:
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_35 = Current;
        if(val_35 != null)
        {
                val_35 = 0;
        }
        
        (AGSRequestScoresResponse)[1152921524051323024].scores.Add(item:  AGSScore.fromHashtable(scoreHashTable:  val_35));
        goto label_41;
        label_30:
        val_36 = 0;
        val_37 = 0;
        var val_26 = 0;
        val_26 = val_26 + 1;
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
        object val_22 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_2.ToString());
        .scope = null;
        return (AGSRequestScoresResponse)val_25;
    }
    public static AGSRequestScoresResponse GetBlankResponseWithError(string error, string leaderboardId = "", LeaderboardScope scope = 0, int userData = 0)
    {
        AGSRequestScoresResponse val_1 = new AGSRequestScoresResponse();
        if(val_1 != null)
        {
                mem[1152921524051529296] = error;
            mem[1152921524051529304] = userData;
            .leaderboardId = leaderboardId;
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
            mem[32] = leaderboardId;
        }
        
        .scope = scope;
        .scores = new System.Collections.Generic.List<AGSScore>();
        return val_1;
    }
    public static AGSRequestScoresResponse GetPlatformNotSupportedResponse(string leaderboardId, LeaderboardScope scope, int userData)
    {
        return AGSRequestScoresResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", leaderboardId:  leaderboardId, scope:  scope, userData:  userData);
    }
    public AGSRequestScoresResponse()
    {
        val_1 = new System.Object();
    }

}
