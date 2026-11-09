using UnityEngine;
public class AGSRequestScoreForPlayerResponse : AGSRequestScoreResponse
{
    // Fields
    public string playerId;
    
    // Methods
    public static AGSRequestScoreForPlayerResponse FromJSON(string json)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        string val_20;
        new AGSRequestScoreForPlayerResponse() = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_15 = val_2.ToString();
        if(new AGSRequestScoreForPlayerResponse() != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_15 = "";
        if(new AGSRequestScoreForPlayerResponse() != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524050111520] = val_15;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_16 = 0;
        }
        
        mem[1152921524050111528] = val_16;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_17 = "";
        }
        
        mem[1152921524050111536] = val_17;
        if((val_2 & 1) != 0)
        {
                int val_8 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_18 = 0;
        }
        
        mem[1152921524050111548] = val_18;
        if((val_2 & 1) != 0)
        {
                long val_10 = System.Int64.Parse(s:  val_2.ToString());
        }
        else
        {
                val_19 = 0;
        }
        
        mem[1152921524050111552] = val_19;
        object val_13 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_2.ToString());
        mem[1152921524050111544] = null;
        if((val_2 & 1) != 0)
        {
                string val_14 = val_2.ToString();
        }
        else
        {
                val_20 = "";
        }
        
        .playerId = val_20;
        return (AGSRequestScoreForPlayerResponse)new AGSRequestScoreForPlayerResponse();
    }
    public static AGSRequestScoreForPlayerResponse GetBlankResponseWithError(string error, string leaderboardId = "", string playerId = "", LeaderboardScope scope = 0, int userData = 0)
    {
        AGSRequestScoreForPlayerResponse val_1 = new AGSRequestScoreForPlayerResponse();
        if(val_1 != null)
        {
                mem[1152921524050305440] = error;
            mem[1152921524050305448] = userData;
            mem[1152921524050305456] = leaderboardId;
            mem[1152921524050305472] = 0;
            .playerId = playerId;
            mem[1152921524050305464] = scope;
            mem[1152921524050305468] = 0;
            return val_1;
        }
        
        mem[16] = error;
        mem[56] = playerId;
        mem[24] = userData;
        mem[32] = leaderboardId;
        mem[40] = scope;
        mem[44] = 0;
    }
    public static AGSRequestScoreForPlayerResponse GetPlatformNotSupportedResponse(string leaderboardId, string playerId, LeaderboardScope scope, int userData)
    {
        return AGSRequestScoreForPlayerResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", leaderboardId:  leaderboardId, playerId:  playerId, scope:  scope, userData:  userData);
    }
    public AGSRequestScoreForPlayerResponse()
    {
        val_1 = new System.Object();
    }

}
