using UnityEngine;
public class AGSRequestScoreResponse : AGSRequestResponse
{
    // Fields
    public string leaderboardId;
    public LeaderboardScope scope;
    public int rank;
    public long score;
    
    // Methods
    public static AGSRequestScoreResponse FromJSON(string json)
    {
        var val_14;
        var val_15;
        string val_16;
        int val_17;
        long val_18;
        new AGSRequestScoreResponse() = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_14 = val_2.ToString();
        if(new AGSRequestScoreResponse() != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_14 = "";
        if(new AGSRequestScoreResponse() != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524050719264] = val_14;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_15 = 0;
        }
        
        mem[1152921524050719272] = val_15;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_16 = "";
        }
        
        .leaderboardId = val_16;
        if((val_2 & 1) != 0)
        {
                int val_8 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_17 = 0;
        }
        
        .rank = val_17;
        if((val_2 & 1) != 0)
        {
                long val_10 = System.Int64.Parse(s:  val_2.ToString());
        }
        else
        {
                val_18 = 0;
        }
        
        .score = val_18;
        object val_13 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_2.ToString());
        .scope = null;
        return (AGSRequestScoreResponse)new AGSRequestScoreResponse();
    }
    public static AGSRequestScoreResponse GetBlankResponseWithError(string error, string leaderboardId = "", LeaderboardScope scope = 0, int userData = 0)
    {
        AGSRequestScoreResponse val_1 = new AGSRequestScoreResponse();
        if(val_1 != null)
        {
                mem[1152921524050900896] = error;
            mem[1152921524050900904] = userData;
            .leaderboardId = leaderboardId;
            .scope = scope;
            .rank = 0;
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
            mem[32] = leaderboardId;
            mem[40] = scope;
            .rank = 0;
        }
        
        .score = 0;
        return val_1;
    }
    public static AGSRequestScoreResponse GetPlatformNotSupportedResponse(string leaderboardId, LeaderboardScope scope, int userData)
    {
        return AGSRequestScoreResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", leaderboardId:  leaderboardId, scope:  scope, userData:  userData);
    }
    public AGSRequestScoreResponse()
    {
        val_1 = new System.Object();
    }

}
