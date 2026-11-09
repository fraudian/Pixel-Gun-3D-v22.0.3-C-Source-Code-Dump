using UnityEngine;
public class AGSAchievementsClient : MonoBehaviour
{
    // Fields
    private static AmazonJavaWrapper JavaObject;
    private static readonly string PROXY_CLASS_NAME;
    private static System.Action<AGSUpdateAchievementResponse> UpdateAchievementCompleted;
    private static System.Action<AGSRequestAchievementsResponse> RequestAchievementsCompleted;
    private static System.Action<AGSRequestAchievementsForPlayerResponse> RequestAchievementsForPlayerCompleted;
    private static System.Action<string, string> UpdateAchievementFailedEvent;
    private static System.Action<string> UpdateAchievementSucceededEvent;
    private static System.Action<System.Collections.Generic.List<AGSAchievement>> RequestAchievementsSucceededEvent;
    private static System.Action<string> RequestAchievementsFailedEvent;
    
    // Methods
    public static void add_UpdateAchievementCompleted(System.Action<AGSUpdateAchievementResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.UpdateAchievementCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.UpdateAchievementCompleted != 1152921505014571024);
    
    }
    public static void remove_UpdateAchievementCompleted(System.Action<AGSUpdateAchievementResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.UpdateAchievementCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.UpdateAchievementCompleted != 1152921505014571024);
    
    }
    public static void add_RequestAchievementsCompleted(System.Action<AGSRequestAchievementsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.RequestAchievementsCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsCompleted != 1152921505014571032);
    
    }
    public static void remove_RequestAchievementsCompleted(System.Action<AGSRequestAchievementsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.RequestAchievementsCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsCompleted != 1152921505014571032);
    
    }
    public static void add_RequestAchievementsForPlayerCompleted(System.Action<AGSRequestAchievementsForPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.RequestAchievementsForPlayerCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsForPlayerCompleted != 1152921505014571040);
    
    }
    public static void remove_RequestAchievementsForPlayerCompleted(System.Action<AGSRequestAchievementsForPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.RequestAchievementsForPlayerCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsForPlayerCompleted != 1152921505014571040);
    
    }
    private static AGSAchievementsClient()
    {
        var val_10;
        UnityEngine.AndroidJavaObject val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 1152921505014566912;
        AGSAchievementsClient.JavaObject = 0;
        AGSAchievementsClient.PROXY_CLASS_NAME = "com.amazon.ags.api.unity.AchievementsClientProxyImpl";
        AGSAchievementsClient.JavaObject = new AmazonJavaWrapper();
        UnityEngine.AndroidJavaClass val_2 = null;
        val_12 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  AGSAchievementsClient.PROXY_CLASS_NAME);
        if((System.IntPtr.op_Equality(value1:  val_2.GetRawClass(), value2:  0)) != false)
        {
                AGSClient.LogGameCircleWarning(errorMessage:  System.String.Format(format:  "No java class {0} present, can\'t use AGSAchievementsClient", arg0:  AGSAchievementsClient.PROXY_CLASS_NAME));
            val_13 = 0;
            val_14 = 0;
        }
        else
        {
                val_11 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            val_13 = 0;
            val_14 = 0;
            mem[1152921524027253664] = val_11;
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
        
        if((val_14 == 0) || (115 == 115))
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
    public static void UpdateAchievementProgress(string achievementId, float progress, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(achievementId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(achievementId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = achievementId;
        val_1[1] = progress;
        val_1[2] = userData;
        AGSAchievementsClient.JavaObject.Call(method:  "updateAchievementProgress", args:  val_1);
    }
    public static void RequestAchievements(int userData = 0)
    {
        null = null;
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(userData != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(userData == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = userData;
        AGSAchievementsClient.JavaObject.Call(method:  "requestAchievements", args:  val_1);
    }
    public static void RequestAchievementsForPlayer(string playerId, int userData = 0)
    {
        null = null;
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(playerId != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(playerId == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = playerId;
        val_1[1] = userData;
        AGSAchievementsClient.JavaObject.Call(method:  "requestAchievementsForPlayer", args:  val_1);
    }
    public static void ShowAchievementsOverlay()
    {
        null = null;
        AGSAchievementsClient.JavaObject.Call(method:  "showAchievementsOverlay", args:  System.Array.Empty<System.Object>());
    }
    public static void RequestAchievementsSucceeded(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestAchievementsResponse> val_5;
        AGSRequestAchievementsResponse val_1 = AGSRequestAchievementsResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = null;
            val_3 = null;
            if(AGSAchievementsClient.RequestAchievementsSucceededEvent != null)
        {
                AGSAchievementsClient.RequestAchievementsSucceededEvent.Invoke(obj:  val_1.achievements);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSAchievementsClient.RequestAchievementsCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSAchievementsClient.RequestAchievementsCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestAchievementsFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestAchievementsResponse> val_5;
        AGSRequestAchievementsResponse val_1 = AGSRequestAchievementsResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSAchievementsClient.RequestAchievementsFailedEvent != null)
        {
                AGSAchievementsClient.RequestAchievementsFailedEvent.Invoke(obj:  1152921505014566912);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSAchievementsClient.RequestAchievementsCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSAchievementsClient.RequestAchievementsCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void UpdateAchievementFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSUpdateAchievementResponse> val_5;
        AGSUpdateAchievementResponse val_1 = AGSUpdateAchievementResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSAchievementsClient.UpdateAchievementFailedEvent != null)
        {
                AGSAchievementsClient.UpdateAchievementFailedEvent.Invoke(arg1:  val_1.achievementId, arg2:  X21);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSAchievementsClient.UpdateAchievementCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSAchievementsClient.UpdateAchievementCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void UpdateAchievementSucceeded(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSUpdateAchievementResponse> val_5;
        AGSUpdateAchievementResponse val_1 = AGSUpdateAchievementResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = null;
            val_3 = null;
            if(AGSAchievementsClient.UpdateAchievementSucceededEvent != null)
        {
                AGSAchievementsClient.UpdateAchievementSucceededEvent.Invoke(obj:  val_1.achievementId);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSAchievementsClient.UpdateAchievementCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSAchievementsClient.UpdateAchievementCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void RequestAchievementsForPlayerComplete(string json)
    {
        null = null;
        if(AGSAchievementsClient.RequestAchievementsForPlayerCompleted == null)
        {
                return;
        }
        
        AGSAchievementsClient.RequestAchievementsForPlayerCompleted.Invoke(obj:  AGSRequestAchievementsForPlayerResponse.FromJSON(json:  json));
    }
    public static void add_UpdateAchievementFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.UpdateAchievementFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.UpdateAchievementFailedEvent != 1152921505014571048);
    
    }
    public static void remove_UpdateAchievementFailedEvent(System.Action<string, string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.UpdateAchievementFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.UpdateAchievementFailedEvent != 1152921505014571048);
    
    }
    public static void add_UpdateAchievementSucceededEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.UpdateAchievementSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.UpdateAchievementSucceededEvent != 1152921505014571056);
    
    }
    public static void remove_UpdateAchievementSucceededEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.UpdateAchievementSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.UpdateAchievementSucceededEvent != 1152921505014571056);
    
    }
    public static void add_RequestAchievementsSucceededEvent(System.Action<System.Collections.Generic.List<AGSAchievement>> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.RequestAchievementsSucceededEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsSucceededEvent != 1152921505014571064);
    
    }
    public static void remove_RequestAchievementsSucceededEvent(System.Action<System.Collections.Generic.List<AGSAchievement>> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.RequestAchievementsSucceededEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsSucceededEvent != 1152921505014571064);
    
    }
    public static void add_RequestAchievementsFailedEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSAchievementsClient.RequestAchievementsFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsFailedEvent != 1152921505014571072);
    
    }
    public static void remove_RequestAchievementsFailedEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSAchievementsClient.RequestAchievementsFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSAchievementsClient.RequestAchievementsFailedEvent != 1152921505014571072);
    
    }
    public AGSAchievementsClient()
    {
    
    }

}
