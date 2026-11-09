using UnityEngine;
public class AGSSubmitScoreResponse : AGSRequestResponse
{
    // Fields
    public string leaderboardId;
    
    // Methods
    public static AGSSubmitScoreResponse FromJSON(string json)
    {
        var val_7;
        var val_8;
        string val_9;
        new AGSSubmitScoreResponse() = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_7 = val_2.ToString();
        if(new AGSSubmitScoreResponse() != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_7 = "";
        if(new AGSSubmitScoreResponse() != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524051918544] = val_7;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_8 = 0;
        }
        
        mem[1152921524051918552] = val_8;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_9 = "";
        }
        
        .leaderboardId = val_9;
        return (AGSSubmitScoreResponse)new AGSSubmitScoreResponse();
    }
    public static AGSSubmitScoreResponse GetBlankResponseWithError(string error, string leaderboardId = "", int userData = 0)
    {
        AGSSubmitScoreResponse val_1 = new AGSSubmitScoreResponse();
        if(val_1 != null)
        {
                mem[1152921524052071504] = error;
            mem[1152921524052071512] = userData;
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
        }
        
        .leaderboardId = leaderboardId;
        return val_1;
    }
    public static AGSSubmitScoreResponse GetPlatformNotSupportedResponse(string leaderboardId, int userData)
    {
        return AGSSubmitScoreResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", leaderboardId:  leaderboardId, userData:  userData);
    }
    public AGSSubmitScoreResponse()
    {
        val_1 = new System.Object();
    }

}
