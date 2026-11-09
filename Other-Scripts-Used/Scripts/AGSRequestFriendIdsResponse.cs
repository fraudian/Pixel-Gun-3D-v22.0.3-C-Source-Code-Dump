using UnityEngine;
public class AGSRequestFriendIdsResponse : AGSRequestResponse
{
    // Fields
    public System.Collections.Generic.List<string> friendIds;
    
    // Methods
    public static AGSRequestFriendIdsResponse FromJSON(string json)
    {
        object val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        string val_24;
        var val_25;
        val_16 = new AGSRequestFriendIdsResponse();
        val_16 = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_17 = val_2.ToString();
        if(val_16 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_17 = "";
        if(val_16 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524056921936] = val_17;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_18 = 0;
        }
        
        mem[1152921524056921944] = val_18;
        System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
        .friendIds = null;
        val_19 = "friendIds";
        if((val_2 & 1) == 0)
        {
                return (AGSRequestFriendIdsResponse)val_16;
        }
        
        if(val_2 != null)
        {
                val_20 = null;
        }
        
        if(val_2 != null)
        {
                val_20 = null;
        }
        
        val_21 = 0;
        label_32:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(MoveNext() == false)
        {
            goto label_22;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_24 = Current;
        if((val_24 != null) && (null != null))
        {
                val_24 = 0;
        }
        
        (AGSRequestFriendIdsResponse)[1152921524056921920].friendIds.Add(item:  val_24);
        goto label_32;
        label_22:
        val_25 = 0;
        val_19 = 0;
        var val_17 = 0;
        val_17 = val_17 + 1;
        Dispose();
        if( != 1)
        {
                if( == false)
        {
                return (AGSRequestFriendIdsResponse)val_16;
        }
        
            if(200 != 200)
        {
                return (AGSRequestFriendIdsResponse)val_16;
        }
        
            return (AGSRequestFriendIdsResponse)val_16;
        }
        
        if( == false)
        {
                return (AGSRequestFriendIdsResponse)val_16;
        }
        
        return (AGSRequestFriendIdsResponse)val_16;
    }
    public static AGSRequestFriendIdsResponse GetBlankResponseWithError(string error, int userData = 0)
    {
        AGSRequestFriendIdsResponse val_1 = new AGSRequestFriendIdsResponse();
        if(val_1 != null)
        {
                mem[1152921524057083136] = error;
        }
        else
        {
                mem[16] = error;
        }
        
        mem[1152921524057083144] = userData;
        .friendIds = new System.Collections.Generic.List<System.String>();
        return val_1;
    }
    public static AGSRequestFriendIdsResponse GetPlatformNotSupportedResponse(int userData)
    {
        return AGSRequestFriendIdsResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", userData:  userData);
    }
    public AGSRequestFriendIdsResponse()
    {
        val_1 = new System.Object();
    }

}
