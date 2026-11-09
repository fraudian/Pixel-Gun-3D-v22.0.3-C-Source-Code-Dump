using UnityEngine;
public class AGSRequestBatchFriendsResponse : AGSRequestResponse
{
    // Fields
    public System.Collections.Generic.List<AGSPlayer> friends;
    
    // Methods
    public static AGSRequestBatchFriendsResponse FromJSON(string json)
    {
        object val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Collections.Hashtable val_26;
        var val_27;
        val_18 = new AGSRequestBatchFriendsResponse();
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
        mem[1152921524056334480] = val_19;
        if((val_2 & 1) != 0)
        {
                int val_5 = System.Int32.Parse(s:  val_2.ToString());
        }
        else
        {
                val_20 = 0;
        }
        
        mem[1152921524056334488] = val_20;
        System.Collections.Generic.List<AGSPlayer> val_6 = new System.Collections.Generic.List<AGSPlayer>();
        .friends = null;
        val_21 = "friends";
        if((val_2 & 1) == 0)
        {
                return (AGSRequestBatchFriendsResponse)val_18;
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
        
        (AGSRequestBatchFriendsResponse)[1152921524056334464].friends.Add(item:  AGSPlayer.fromHashtable(playerDataAsHashtable:  val_26));
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
                return (AGSRequestBatchFriendsResponse)val_18;
        }
        
            if(205 != 205)
        {
                return (AGSRequestBatchFriendsResponse)val_18;
        }
        
            return (AGSRequestBatchFriendsResponse)val_18;
        }
        
        if( == false)
        {
                return (AGSRequestBatchFriendsResponse)val_18;
        }
        
        return (AGSRequestBatchFriendsResponse)val_18;
    }
    public static AGSRequestBatchFriendsResponse GetBlankResponseWithError(string error, System.Collections.Generic.List<string> friendIdsRequested, int userData = 0)
    {
        mem[1152921524056520256] = error;
        .friends = new System.Collections.Generic.List<AGSPlayer>();
        if(friendIdsRequested == null)
        {
            goto label_11;
        }
        
        List.Enumerator<T> val_3 = friendIdsRequested.GetEnumerator();
        label_6:
        if(((-2025215512) & 1) == 0)
        {
            goto label_4;
        }
        
        (AGSRequestBatchFriendsResponse)[1152921524056520240].friends.Add(item:  AGSPlayer.BlankPlayerWithID(playerId:  0.丐丏七丌丕丗业且上()));
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_11:
        mem[1152921524056520264] = userData;
        return (AGSRequestBatchFriendsResponse)new AGSRequestBatchFriendsResponse();
    }
    public static AGSRequestBatchFriendsResponse GetPlatformNotSupportedResponse(System.Collections.Generic.List<string> friendIdsRequested, int userData)
    {
        return AGSRequestBatchFriendsResponse.GetBlankResponseWithError(error:  "PLATFORM_NOT_SUPPORTED", friendIdsRequested:  friendIdsRequested, userData:  userData);
    }
    public AGSRequestBatchFriendsResponse()
    {
        val_1 = new System.Object();
    }

}
