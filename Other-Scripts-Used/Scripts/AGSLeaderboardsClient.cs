using UnityEngine;
public class AGSLeaderboardsClient : MonoBehaviour
{
    // Fields
    private static AmazonJavaWrapper JavaObject;
    private static readonly string PROXY_CLASS_NAME;
    private static System.Action<AGSSubmitScoreResponse> SubmitScoreCompleted;
    private static System.Action<AGSRequestLeaderboardsResponse> RequestLeaderboardsCompleted;
    private static System.Action<AGSRequestScoreResponse> RequestLocalPlayerScoreCompleted;
    private static System.Action<AGSRequestScoreForPlayerResponse> RequestScoreForPlayerCompleted;
    private static System.Action<AGSRequestScoresResponse> RequestScoresCompleted;
    private static System.Action<AGSRequestPercentilesResponse> RequestPercentileRanksCompleted;
    private static System.Action<AGSRequestPercentilesForPlayerResponse> RequestPercentileRanksForPlayerCompleted;
    private static System.Action<string, string> SubmitScoreFailedEvent;
    private static System.Action<string> SubmitScoreSucceededEvent;
    private static System.Action<string> RequestLeaderboardsFailedEvent;
    private static System.Action<System.Collections.Generic.List<AGSLeaderboard>> RequestLeaderboardsSucceededEvent;
    private static System.Action<string, string> RequestLocalPlayerScoreFailedEvent;
    private static System.Action<string, int, long> RequestLocalPlayerScoreSucceededEvent;
    private static System.Action<string, string> RequestPercentileRanksFailedEvent;
    private static System.Action<AGSLeaderboard, System.Collections.Generic.List<AGSLeaderboardPercentile>, int> RequestPercentileRanksSucceededEvent;
    
    // Methods
    public static void add_SubmitScoreCompleted(System.Action<AGSSubmitScoreResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.SubmitScoreCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.SubmitScoreCompleted != 1152921505015103504);
    
    }
    public static void remove_SubmitScoreCompleted(System.Action<AGSSubmitScoreResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.SubmitScoreCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.SubmitScoreCompleted != 1152921505015103504);
    
    }
    public static void add_RequestLeaderboardsCompleted(System.Action<AGSRequestLeaderboardsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestLeaderboardsCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLeaderboardsCompleted != 1152921505015103512);
    
    }
    public static void remove_RequestLeaderboardsCompleted(System.Action<AGSRequestLeaderboardsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestLeaderboardsCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLeaderboardsCompleted != 1152921505015103512);
    
    }
    public static void add_RequestLocalPlayerScoreCompleted(System.Action<AGSRequestScoreResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted != 1152921505015103520);
    
    }
    public static void remove_RequestLocalPlayerScoreCompleted(System.Action<AGSRequestScoreResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted != 1152921505015103520);
    
    }
    public static void add_RequestScoreForPlayerCompleted(System.Action<AGSRequestScoreForPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestScoreForPlayerCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestScoreForPlayerCompleted != 1152921505015103528);
    
    }
    public static void remove_RequestScoreForPlayerCompleted(System.Action<AGSRequestScoreForPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestScoreForPlayerCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestScoreForPlayerCompleted != 1152921505015103528);
    
    }
    public static void add_RequestScoresCompleted(System.Action<AGSRequestScoresResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestScoresCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestScoresCompleted != 1152921505015103536);
    
    }
    public static void remove_RequestScoresCompleted(System.Action<AGSRequestScoresResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestScoresCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestScoresCompleted != 1152921505015103536);
    
    }
    public static void add_RequestPercentileRanksCompleted(System.Action<AGSRequestPercentilesResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestPercentileRanksCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksCompleted != 1152921505015103544);
    
    }
    public static void remove_RequestPercentileRanksCompleted(System.Action<AGSRequestPercentilesResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestPercentileRanksCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksCompleted != 1152921505015103544);
    
    }
    public static void add_RequestPercentileRanksForPlayerCompleted(System.Action<AGSRequestPercentilesForPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestPercentileRanksForPlayerCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksForPlayerCompleted != 1152921505015103552);
    
    }
    public static void remove_RequestPercentileRanksForPlayerCompleted(System.Action<AGSRequestPercentilesForPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestPercentileRanksForPlayerCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksForPlayerCompleted != 1152921505015103552);
    
    }
    private static AGSLeaderboardsClient()
    {
        var val_10;
        UnityEngine.AndroidJavaObject val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 1152921505015099392;
        AGSLeaderboardsClient.PROXY_CLASS_NAME = "com.amazon.ags.api.unity.LeaderboardsClientProxyImpl";
        AGSLeaderboardsClient.JavaObject = new AmazonJavaWrapper();
        UnityEngine.AndroidJavaClass val_2 = null;
        val_12 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  AGSLeaderboardsClient.PROXY_CLASS_NAME);
        if((System.IntPtr.op_Equality(value1:  val_2.GetRawClass(), value2:  0)) != false)
        {
                AGSClient.LogGameCircleWarning(errorMessage:  "No java class " + AGSLeaderboardsClient.PROXY_CLASS_NAME + " present, can\'t use AGSLeaderboardsClient");
            val_13 = 0;
            val_14 = 0;
        }
        else
        {
                val_11 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            val_13 = 0;
            val_14 = 0;
            mem[1152921524041358848] = val_11;
        }
        
        if(val_12 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
        }
        
        if(val_13 == 1)
        {
            goto label_13;
        }
        
        if((val_14 == 0) || (114 == 114))
        {
            goto label_15;
        }
        
        label_16:
        val_10 = ???;
        val_14 = ???;
        val_12 = ???;
        val_11 = ???;
        val_13 = ???;
        label_13:
        if(val_14 != 0)
        {
            goto label_16;
        }
        
        label_15:
        var val_9 = val_10 - 48;
    }
    public static void SubmitScore(string leaderboardId, long score, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(leaderboardId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(leaderboardId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = leaderboardId;
        val_1[1] = score;
        val_1[2] = userData;
        AGSLeaderboardsClient.JavaObject.Call(method:  "submitScore", args:  val_1);
    }
    public static void ShowLeaderboardsOverlay()
    {
        null = null;
        AGSLeaderboardsClient.JavaObject.Call(method:  "showLeaderboardsOverlay", args:  System.Array.Empty<System.Object>());
    }
    public static void RequestLeaderboards(int userData = 0)
    {
        null = null;
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(0 != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(0 == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = 0;
        AGSLeaderboardsClient.JavaObject.Call(method:  "requestLeaderboards", args:  val_1);
    }
    public static void RequestLocalPlayerScore(string leaderboardId, LeaderboardScope scope, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(leaderboardId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(leaderboardId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = leaderboardId;
        val_1[1] = scope;
        val_1[2] = 0;
        AGSLeaderboardsClient.JavaObject.Call(method:  "requestLocalPlayerScore", args:  val_1);
    }
    public static void RequestScoreForPlayer(string leaderboardId, string playerId, LeaderboardScope scope, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(leaderboardId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(leaderboardId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = leaderboardId;
        val_1[1] = playerId;
        val_1[2] = scope;
        val_1[3] = userData;
        AGSLeaderboardsClient.JavaObject.Call(method:  "requestScoreForPlayer", args:  val_1);
    }
    public static void RequestScores(string leaderboardId, LeaderboardScope scope, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(leaderboardId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(leaderboardId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = leaderboardId;
        val_1[1] = scope;
        val_1[2] = userData;
        AGSLeaderboardsClient.JavaObject.Call(method:  "requestScores", args:  val_1);
    }
    public static void RequestPercentileRanks(string leaderboardId, LeaderboardScope scope, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(leaderboardId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(leaderboardId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = leaderboardId;
        val_1[1] = scope;
        val_1[2] = userData;
        AGSLeaderboardsClient.JavaObject.Call(method:  "requestPercentileRanks", args:  val_1);
    }
    public static void RequestPercentileRanksForPlayer(string leaderboardId, string playerId, LeaderboardScope scope, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(leaderboardId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(leaderboardId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = leaderboardId;
        val_1[1] = playerId;
        val_1[2] = scope;
        val_1[3] = userData;
        AGSLeaderboardsClient.JavaObject.Call(method:  "requestPercentileRanksForPlayer", args:  val_1);
    }
    public static void SubmitScoreFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSSubmitScoreResponse> val_5;
        AGSSubmitScoreResponse val_1 = AGSSubmitScoreResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSLeaderboardsClient.SubmitScoreFailedEvent != null)
        {
                AGSLeaderboardsClient.SubmitScoreFailedEvent.Invoke(arg1:  val_1.leaderboardId, arg2:  X21);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSLeaderboardsClient.SubmitScoreCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSLeaderboardsClient.SubmitScoreCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void SubmitScoreSucceeded(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSSubmitScoreResponse> val_5;
        AGSSubmitScoreResponse val_1 = AGSSubmitScoreResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = null;
            val_3 = null;
            if(AGSLeaderboardsClient.SubmitScoreSucceededEvent != null)
        {
                AGSLeaderboardsClient.SubmitScoreSucceededEvent.Invoke(obj:  val_1.leaderboardId);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSLeaderboardsClient.SubmitScoreCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSLeaderboardsClient.SubmitScoreCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestLeaderboardsFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestLeaderboardsResponse> val_5;
        AGSRequestLeaderboardsResponse val_1 = AGSRequestLeaderboardsResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSLeaderboardsClient.RequestLeaderboardsFailedEvent != null)
        {
                AGSLeaderboardsClient.RequestLeaderboardsFailedEvent.Invoke(obj:  1152921505015099392);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSLeaderboardsClient.RequestLeaderboardsCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSLeaderboardsClient.RequestLeaderboardsCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestLeaderboardsSucceeded(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestLeaderboardsResponse> val_5;
        AGSRequestLeaderboardsResponse val_1 = AGSRequestLeaderboardsResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = null;
            val_3 = null;
            if(AGSLeaderboardsClient.RequestLeaderboardsSucceededEvent != null)
        {
                AGSLeaderboardsClient.RequestLeaderboardsSucceededEvent.Invoke(obj:  val_1.leaderboards);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSLeaderboardsClient.RequestLeaderboardsCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSLeaderboardsClient.RequestLeaderboardsCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestLocalPlayerScoreFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestScoreResponse> val_5;
        AGSRequestScoreResponse val_1 = AGSRequestScoreResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSLeaderboardsClient.RequestLocalPlayerScoreFailedEvent != null)
        {
                AGSLeaderboardsClient.RequestLocalPlayerScoreFailedEvent.Invoke(arg1:  val_1.leaderboardId, arg2:  X21);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestLocalPlayerScoreSucceeded(string json)
    {
        string val_3;
        var val_4;
        System.Action<System.String, System.Int32, System.Int64> val_5;
        var val_6;
        System.Action<AGSRequestScoreResponse> val_7;
        AGSRequestScoreResponse val_1 = AGSRequestScoreResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = 1152921505015099392;
            val_4 = null;
            val_4 = null;
            val_5 = AGSLeaderboardsClient.RequestLocalPlayerScoreSucceededEvent;
            if(val_5 != null)
        {
                val_5 = AGSLeaderboardsClient.RequestLocalPlayerScoreSucceededEvent;
            val_3 = val_1.leaderboardId;
            val_5.Invoke(arg1:  val_3, arg2:  val_1.rank, arg3:  val_1.score);
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted;
        if(val_7 == null)
        {
                return;
        }
        
        val_7 = AGSLeaderboardsClient.RequestLocalPlayerScoreCompleted;
        if(val_7 == null)
        {
                val_7 = 0;
        }
        
        val_7.Invoke(obj:  val_1);
    }
    public static void RequestScoreForPlayerComplete(string json)
    {
        null = null;
        if(AGSLeaderboardsClient.RequestScoreForPlayerCompleted == null)
        {
                return;
        }
        
        AGSLeaderboardsClient.RequestScoreForPlayerCompleted.Invoke(obj:  AGSRequestScoreForPlayerResponse.FromJSON(json:  json));
    }
    public static void RequestScoresSucceeded(string json)
    {
        null = null;
        if(AGSLeaderboardsClient.RequestScoresCompleted == null)
        {
                return;
        }
        
        AGSLeaderboardsClient.RequestScoresCompleted.Invoke(obj:  AGSRequestScoresResponse.FromJSON(json:  json));
    }
    public static void RequestScoresFailed(string json)
    {
        null = null;
        if(AGSLeaderboardsClient.RequestScoresCompleted == null)
        {
                return;
        }
        
        AGSLeaderboardsClient.RequestScoresCompleted.Invoke(obj:  AGSRequestScoresResponse.FromJSON(json:  json));
    }
    public static void RequestPercentileRanksFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestPercentilesResponse> val_5;
        AGSRequestPercentilesResponse val_1 = AGSRequestPercentilesResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSLeaderboardsClient.RequestPercentileRanksFailedEvent != null)
        {
                AGSLeaderboardsClient.RequestPercentileRanksFailedEvent.Invoke(arg1:  val_1.leaderboardId, arg2:  X21);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSLeaderboardsClient.RequestPercentileRanksCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSLeaderboardsClient.RequestPercentileRanksCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestPercentileRanksSucceeded(string json)
    {
        AGSLeaderboard val_3;
        var val_4;
        System.Action<AGSLeaderboard, System.Collections.Generic.List<AGSLeaderboardPercentile>, System.Int32> val_5;
        var val_6;
        System.Action<AGSRequestPercentilesResponse> val_7;
        AGSRequestPercentilesResponse val_1 = AGSRequestPercentilesResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = 1152921505015099392;
            val_4 = null;
            val_4 = null;
            val_5 = AGSLeaderboardsClient.RequestPercentileRanksSucceededEvent;
            if(val_5 != null)
        {
                val_5 = AGSLeaderboardsClient.RequestPercentileRanksSucceededEvent;
            val_3 = val_1.leaderboard;
            val_5.Invoke(arg1:  val_3, arg2:  val_1.percentiles, arg3:  val_1.userIndex);
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = AGSLeaderboardsClient.RequestPercentileRanksCompleted;
        if(val_7 == null)
        {
                return;
        }
        
        val_7 = AGSLeaderboardsClient.RequestPercentileRanksCompleted;
        if(val_7 == null)
        {
                val_7 = 0;
        }
        
        val_7.Invoke(obj:  val_1);
    }
    public static void RequestPercentileRanksForPlayerComplete(string json)
    {
        null = null;
        if(AGSLeaderboardsClient.RequestPercentileRanksForPlayerCompleted == null)
        {
                return;
        }
        
        AGSLeaderboardsClient.RequestPercentileRanksForPlayerCompleted.Invoke(obj:  AGSRequestPercentilesForPlayerResponse.FromJSON(json:  json));
    }
    public static void add_SubmitScoreFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.SubmitScoreFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.SubmitScoreFailedEvent != 1152921505015103560);
    
    }
    public static void remove_SubmitScoreFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.SubmitScoreFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.SubmitScoreFailedEvent != 1152921505015103560);
    
    }
    public static void add_SubmitScoreSucceededEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.SubmitScoreSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.SubmitScoreSucceededEvent != 1152921505015103568);
    
    }
    public static void remove_SubmitScoreSucceededEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.SubmitScoreSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.SubmitScoreSucceededEvent != 1152921505015103568);
    
    }
    public static void add_RequestLeaderboardsFailedEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestLeaderboardsFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLeaderboardsFailedEvent != 1152921505015103576);
    
    }
    public static void remove_RequestLeaderboardsFailedEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestLeaderboardsFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLeaderboardsFailedEvent != 1152921505015103576);
    
    }
    public static void add_RequestLeaderboardsSucceededEvent(System.Action<System.Collections.Generic.List<AGSLeaderboard>> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestLeaderboardsSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLeaderboardsSucceededEvent != 1152921505015103584);
    
    }
    public static void remove_RequestLeaderboardsSucceededEvent(System.Action<System.Collections.Generic.List<AGSLeaderboard>> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestLeaderboardsSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLeaderboardsSucceededEvent != 1152921505015103584);
    
    }
    public static void add_RequestLocalPlayerScoreFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestLocalPlayerScoreFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLocalPlayerScoreFailedEvent != 1152921505015103592);
    
    }
    public static void remove_RequestLocalPlayerScoreFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestLocalPlayerScoreFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLocalPlayerScoreFailedEvent != 1152921505015103592);
    
    }
    public static void add_RequestLocalPlayerScoreSucceededEvent(System.Action<string, int, long> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestLocalPlayerScoreSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLocalPlayerScoreSucceededEvent != 1152921505015103600);
    
    }
    public static void remove_RequestLocalPlayerScoreSucceededEvent(System.Action<string, int, long> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestLocalPlayerScoreSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestLocalPlayerScoreSucceededEvent != 1152921505015103600);
    
    }
    public static void add_RequestPercentileRanksFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestPercentileRanksFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksFailedEvent != 1152921505015103608);
    
    }
    public static void remove_RequestPercentileRanksFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestPercentileRanksFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksFailedEvent != 1152921505015103608);
    
    }
    public static void add_RequestPercentileRanksSucceededEvent(System.Action<AGSLeaderboard, System.Collections.Generic.List<AGSLeaderboardPercentile>, int> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSLeaderboardsClient.RequestPercentileRanksSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksSucceededEvent != 1152921505015103616);
    
    }
    public static void remove_RequestPercentileRanksSucceededEvent(System.Action<AGSLeaderboard, System.Collections.Generic.List<AGSLeaderboardPercentile>, int> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSLeaderboardsClient.RequestPercentileRanksSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSLeaderboardsClient.RequestPercentileRanksSucceededEvent != 1152921505015103616);
    
    }
    public AGSLeaderboardsClient()
    {
    
    }

}
