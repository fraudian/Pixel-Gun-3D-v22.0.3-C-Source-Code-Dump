using UnityEngine;
public class AGSRequestPlayerResponse : AGSRequestResponse
{
    // Fields
    public AGSPlayer player;
    
    // Methods
    public static AGSRequestPlayerResponse FromJSON(string json)
    {
        var val_9;
        var val_10;
        var val_11;
        new AGSRequestPlayerResponse() = new System.Object();
        System.Collections.Hashtable val_2 = MiniJsonExtensions.hashtableFromJson(json:  json);
        if((val_2 & 1) == 0)
        {
            goto label_2;
        }
        
        val_9 = val_2.ToString();
        if(new AGSRequestPlayerResponse() != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_9 = "";
        if(new AGSRequestPlayerResponse() != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        mem[1152921524057460096] = val_9;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_10 = 0;
        }
        
        mem[1152921524057460104] = val_10;
        if((val_2 & 1) == 0)
        {
            goto label_10;
        }
        
        val_11 = val_2;
        if(val_11 == null)
        {
            goto label_13;
        }
        
        val_11 = 0;
        goto label_13;
        label_10:
        AGSPlayer val_6 = AGSPlayer.GetBlankPlayer();
        goto label_14;
        label_13:
        label_14:
        .player = AGSPlayer.fromHashtable(playerDataAsHashtable:  null);
        return (AGSRequestPlayerResponse)new AGSRequestPlayerResponse();
    }
    public static AGSRequestPlayerResponse GetBlankResponseWithError(string error, int userData = 0)
    {
        AGSPlayer val_4;
        AGSRequestPlayerResponse val_1 = new AGSRequestPlayerResponse();
        if(val_1 != null)
        {
                mem[1152921524057617152] = error;
            mem[1152921524057617160] = userData;
            val_4 = AGSPlayer.GetBlankPlayer();
        }
        else
        {
                mem[16] = error;
            mem[24] = userData;
            val_4 = AGSPlayer.GetBlankPlayer();
        }
        
        .player = val_4;
        return val_1;
    }
    public static AGSRequestPlayerResponse GetPlatformNotSupportedResponse(int userData)
    {
        return AGSRequestPlayerResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", userData:  userData);
    }
    public AGSRequestPlayerResponse()
    {
        val_1 = new System.Object();
    }

}
