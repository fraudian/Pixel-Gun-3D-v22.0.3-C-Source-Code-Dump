using UnityEngine;
public class AGSRequestAchievementsForPlayerResponse : AGSRequestAchievementsResponse
{
    // Fields
    public string playerId;
    
    // Methods
    public static AGSRequestAchievementsForPlayerResponse FromJSON(string json)
    {
        object val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Collections.Hashtable val_26;
        var val_27;
        var val_28;
        string val_32;
        val_19 = new AGSRequestAchievementsForPlayerResponse();
        val_19 = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_20 = val_2.ToString();
        if(val_19 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_20 = "";
        if(val_19 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524030643568] = val_20;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_21 = 0;
        }
        
        mem[1152921524030643576] = val_21;
        System.Collections.Generic.List<AGSAchievement> val_6 = new System.Collections.Generic.List<AGSAchievement>();
        mem[1152921524030643584] = null;
        if((val_2 & 1) == 0)
        {
            goto label_66;
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
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_26 = Current;
        if(val_26 != null)
        {
                val_26 = 0;
        }
        
        X23.Add(item:  AGSAchievement.fromHashtable(hashtable:  val_26));
        goto label_33;
        label_22:
        val_27 = 0;
        val_28 = 0;
        var val_20 = 0;
        val_20 = val_20 + 1;
        Dispose();
        if( == 1)
        {
            goto label_62;
        }
        
        if( == false)
        {
            goto label_66;
        }
        
        if(205 != 205)
        {
            goto label_64;
        }
        
        goto label_66;
        label_62:
        if( == false)
        {
            goto label_66;
        }
        
        label_64:
        label_66:
        if((val_2 & 1) == 0)
        {
            goto label_68;
        }
        
        val_32 = val_2.ToString();
        if(val_19 != null)
        {
            goto label_72;
        }
        
        goto label_71;
        label_68:
        val_32 = "";
        if(val_19 != null)
        {
            goto label_72;
        }
        
        label_71:
        label_72:
        .playerId = val_32;
        return (AGSRequestAchievementsForPlayerResponse)val_19;
    }
    public static AGSRequestAchievementsForPlayerResponse GetBlankResponseWithError(string error, string playerId = "", int userData = 0)
    {
        AGSRequestAchievementsForPlayerResponse val_1 = new AGSRequestAchievementsForPlayerResponse();
        if(val_1 != null)
        {
                mem[1152921524030817056] = error;
            .playerId = playerId;
        }
        else
        {
                mem[16] = error;
            mem[40] = playerId;
        }
        
        mem[1152921524030817064] = userData;
        mem[1152921524030817072] = new System.Collections.Generic.List<AGSAchievement>();
        return val_1;
    }
    public static AGSRequestAchievementsForPlayerResponse GetPlatformNotSupportedResponse(string playerId, int userData)
    {
        return AGSRequestAchievementsForPlayerResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", playerId:  playerId, userData:  userData);
    }
    public AGSRequestAchievementsForPlayerResponse()
    {
        val_1 = new System.Object();
    }

}
