using UnityEngine;
public class AGSRequestAchievementsResponse : AGSRequestResponse
{
    // Fields
    public System.Collections.Generic.List<AGSAchievement> achievements;
    
    // Methods
    public static AGSRequestAchievementsResponse FromJSON(string json)
    {
        object val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Collections.Hashtable val_26;
        var val_27;
        val_18 = new AGSRequestAchievementsResponse();
        val_18 = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_19 = val_2.ToString();
        if(val_18 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_19 = "";
        if(val_18 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524031210560] = val_19;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_20 = 0;
        }
        
        mem[1152921524031210568] = val_20;
        System.Collections.Generic.List<AGSAchievement> val_6 = new System.Collections.Generic.List<AGSAchievement>();
        .achievements = null;
        val_21 = "achievements";
        if((val_2 & 1) == 0)
        {
                return (AGSRequestAchievementsResponse)val_18;
        }
        
        if(val_2 != null)
        {
                val_22 = null;
        }
        
        if(val_2 != null)
        {
                val_22 = null;
        }
        
        val_23 = 0;
        label_33:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_26 = Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        (AGSRequestAchievementsResponse)[1152921524031210544].achievements.Add(item:  AGSAchievement.fromHashtable(hashtable:  val_26));
        goto label_33;
        label_22:
        val_27 = 0;
        val_21 = 0;
        var val_19 = 0;
        val_19 = val_19 + 1;
        Dispose();
        if( != 1)
        {
                if( == false)
        {
                return (AGSRequestAchievementsResponse)val_18;
        }
        
            if(205 != 205)
        {
                return (AGSRequestAchievementsResponse)val_18;
        }
        
            return (AGSRequestAchievementsResponse)val_18;
        }
        
        if( == false)
        {
                return (AGSRequestAchievementsResponse)val_18;
        }
        
        return (AGSRequestAchievementsResponse)val_18;
    }
    public static AGSRequestAchievementsResponse GetBlankResponseWithError(string error, int userData = 0)
    {
        AGSRequestAchievementsResponse val_1 = new AGSRequestAchievementsResponse();
        if(val_1 != null)
        {
                mem[1152921524031375856] = error;
        }
        else
        {
                mem[16] = error;
        }
        
        mem[1152921524031375864] = userData;
        .achievements = new System.Collections.Generic.List<AGSAchievement>();
        return val_1;
    }
    public static AGSRequestAchievementsResponse GetPlatformNotSupportedResponse(int userData)
    {
        return AGSRequestAchievementsResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", userData:  userData);
    }
    public AGSRequestAchievementsResponse()
    {
        val_1 = new System.Object();
    }

}
