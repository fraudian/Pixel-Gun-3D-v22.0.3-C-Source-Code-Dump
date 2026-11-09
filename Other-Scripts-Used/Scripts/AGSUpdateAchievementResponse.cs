using UnityEngine;
public class AGSUpdateAchievementResponse : AGSRequestResponse
{
    // Fields
    public string achievementId;
    
    // Methods
    public static AGSUpdateAchievementResponse FromJSON(string json)
    {
        var val_7;
        var val_8;
        string val_9;
        new AGSUpdateAchievementResponse() = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_7 = val_2.ToString();
        if(new AGSUpdateAchievementResponse() != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_7 = "";
        if(new AGSUpdateAchievementResponse() != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524031748720] = val_7;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_8 = 0;
        }
        
        mem[1152921524031748728] = val_8;
        if((val_2 & 1) != 0)
        {
                string val_6 = val_2.ToString();
        }
        else
        {
                val_9 = "";
        }
        
        .achievementId = val_9;
        return (AGSUpdateAchievementResponse)new AGSUpdateAchievementResponse();
    }
    public static AGSUpdateAchievementResponse GetBlankResponseWithError(string error, string achievementId = "", int userData = 0)
    {
        AGSUpdateAchievementResponse val_1 = new AGSUpdateAchievementResponse();
        if(val_1 != null)
        {
                mem[1152921524031901680] = error;
            mem[1152921524031901688] = userData;
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
        }
        
        .achievementId = achievementId;
        return val_1;
    }
    public static AGSUpdateAchievementResponse GetPlatformNotSupportedResponse(string achievementId, int userData)
    {
        return AGSUpdateAchievementResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", achievementId:  achievementId, userData:  userData);
    }
    public AGSUpdateAchievementResponse()
    {
        val_1 = new System.Object();
    }

}
