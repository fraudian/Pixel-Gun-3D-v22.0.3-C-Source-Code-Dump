using UnityEngine;
public class AGSPlayerClient : MonoBehaviour
{
    // Fields
    private static AmazonJavaWrapper JavaObject;
    private static readonly string PROXY_CLASS_NAME;
    private static System.Action<AGSRequestPlayerResponse> RequestLocalPlayerCompleted;
    private static System.Action<AGSRequestFriendIdsResponse> RequestFriendIdsCompleted;
    private static System.Action<AGSRequestBatchFriendsResponse> RequestBatchFriendsCompleted;
    private static System.Action<bool> OnSignedInStateChangedEvent;
    private static System.Action<AGSPlayer> PlayerReceivedEvent;
    private static System.Action<string> PlayerFailedEvent;
    
    // Methods
    public static void add_RequestLocalPlayerCompleted(System.Action<AGSRequestPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSPlayerClient.RequestLocalPlayerCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.RequestLocalPlayerCompleted != 1152921505015689232);
    
    }
    public static void remove_RequestLocalPlayerCompleted(System.Action<AGSRequestPlayerResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSPlayerClient.RequestLocalPlayerCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.RequestLocalPlayerCompleted != 1152921505015689232);
    
    }
    public static void add_RequestFriendIdsCompleted(System.Action<AGSRequestFriendIdsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSPlayerClient.RequestFriendIdsCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.RequestFriendIdsCompleted != 1152921505015689240);
    
    }
    public static void remove_RequestFriendIdsCompleted(System.Action<AGSRequestFriendIdsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSPlayerClient.RequestFriendIdsCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.RequestFriendIdsCompleted != 1152921505015689240);
    
    }
    public static void add_RequestBatchFriendsCompleted(System.Action<AGSRequestBatchFriendsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSPlayerClient.RequestBatchFriendsCompleted, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.RequestBatchFriendsCompleted != 1152921505015689248);
    
    }
    public static void remove_RequestBatchFriendsCompleted(System.Action<AGSRequestBatchFriendsResponse> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSPlayerClient.RequestBatchFriendsCompleted, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.RequestBatchFriendsCompleted != 1152921505015689248);
    
    }
    public static void add_OnSignedInStateChangedEvent(System.Action<bool> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSPlayerClient.OnSignedInStateChangedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.OnSignedInStateChangedEvent != 1152921505015689256);
    
    }
    public static void remove_OnSignedInStateChangedEvent(System.Action<bool> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSPlayerClient.OnSignedInStateChangedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.OnSignedInStateChangedEvent != 1152921505015689256);
    
    }
    private static AGSPlayerClient()
    {
        var val_10;
        UnityEngine.AndroidJavaObject val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 1152921505015685120;
        AGSPlayerClient.PROXY_CLASS_NAME = "com.amazon.ags.api.unity.PlayerClientProxyImpl";
        AGSPlayerClient.JavaObject = new AmazonJavaWrapper();
        UnityEngine.AndroidJavaClass val_2 = null;
        val_12 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  AGSPlayerClient.PROXY_CLASS_NAME);
        if((System.IntPtr.op_Equality(value1:  val_2.GetRawClass(), value2:  0)) != false)
        {
                AGSClient.LogGameCircleWarning(errorMessage:  "No java class " + AGSPlayerClient.PROXY_CLASS_NAME + " present, can\'t use AGSPlayerClient");
            val_13 = 0;
            val_14 = 0;
        }
        else
        {
                val_11 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            val_13 = 0;
            val_14 = 0;
            mem[1152921524053500432] = val_11;
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
    public static void RequestLocalPlayer(int userData = 0)
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
        AGSPlayerClient.JavaObject.Call(method:  "requestLocalPlayer", args:  val_1);
    }
    public static void RequestFriendIds(int userData = 0)
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
        AGSPlayerClient.JavaObject.Call(method:  "requestLocalPlayerFriends", args:  val_1);
    }
    public static void RequestBatchFriends(System.Collections.Generic.List<string> friendIds, int userData = 0)
    {
        var val_4;
        string val_2 = MiniJSON.jsonEncode(json:  friendIds.ToArray());
        val_4 = null;
        val_4 = null;
        object[] val_3 = new object[2];
        if(val_3 == null)
        {
            goto label_6;
        }
        
        if(val_2 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_2 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        val_3[0] = val_2;
        val_3[1] = userData;
        AGSPlayerClient.JavaObject.Call(method:  "requestBatchFriends", args:  val_3);
    }
    public static void LocalPlayerFriendsComplete(string json)
    {
        null = null;
        if(AGSPlayerClient.RequestFriendIdsCompleted == null)
        {
                return;
        }
        
        AGSPlayerClient.RequestFriendIdsCompleted.Invoke(obj:  AGSRequestFriendIdsResponse.FromJSON(json:  json));
    }
    public static void BatchFriendsRequestComplete(string json)
    {
        null = null;
        if(AGSPlayerClient.RequestBatchFriendsCompleted == null)
        {
                return;
        }
        
        AGSPlayerClient.RequestBatchFriendsCompleted.Invoke(obj:  AGSRequestBatchFriendsResponse.FromJSON(json:  json));
    }
    public static void PlayerReceived(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestPlayerResponse> val_5;
        AGSRequestPlayerResponse val_1 = AGSRequestPlayerResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != false)
        {
                val_3 = null;
            val_3 = null;
            if(AGSPlayerClient.PlayerReceivedEvent != null)
        {
                AGSPlayerClient.PlayerReceivedEvent.Invoke(obj:  val_1.player);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSPlayerClient.RequestLocalPlayerCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSPlayerClient.RequestLocalPlayerCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static void PlayerFailed(string json)
    {
        var val_3;
        var val_4;
        System.Action<AGSRequestPlayerResponse> val_5;
        AGSRequestPlayerResponse val_1 = AGSRequestPlayerResponse.FromJSON(json:  json);
        if((System.String.IsNullOrEmpty(value:  val_1)) != true)
        {
                val_3 = null;
            val_3 = null;
            if(AGSPlayerClient.PlayerFailedEvent != null)
        {
                AGSPlayerClient.PlayerFailedEvent.Invoke(obj:  1152921505015685120);
        }
        
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = AGSPlayerClient.RequestLocalPlayerCompleted;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = AGSPlayerClient.RequestLocalPlayerCompleted;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke(obj:  val_1);
    }
    public static bool IsSignedIn()
    {
        null = null;
        if(AGSPlayerClient.JavaObject != null)
        {
                return AGSPlayerClient.JavaObject.Call<System.Boolean>(method:  "isSignedIn", args:  System.Array.Empty<System.Object>());
        }
        
        return AGSPlayerClient.JavaObject.Call<System.Boolean>(method:  "isSignedIn", args:  System.Array.Empty<System.Object>());
    }
    public static void OnSignedInStateChanged(bool isSignedIn)
    {
        var val_2;
        System.Action<System.Boolean> val_3;
        val_2 = null;
        val_2 = null;
        val_3 = AGSPlayerClient.OnSignedInStateChangedEvent;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = AGSPlayerClient.OnSignedInStateChangedEvent;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke(obj:  isSignedIn);
    }
    public static void add_PlayerReceivedEvent(System.Action<AGSPlayer> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSPlayerClient.PlayerReceivedEvent, b:  value);
            if((val_4 != null) && (null != "fallDamageMinHeight"))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.PlayerReceivedEvent != 1152921505015689264);
    
    }
    public static void remove_PlayerReceivedEvent(System.Action<AGSPlayer> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSPlayerClient.PlayerReceivedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.PlayerReceivedEvent != 1152921505015689264);
    
    }
    public static void add_PlayerFailedEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSPlayerClient.PlayerFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.PlayerFailedEvent != 1152921505015689272);
    
    }
    public static void remove_PlayerFailedEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSPlayerClient.PlayerFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSPlayerClient.PlayerFailedEvent != 1152921505015689272);
    
    }
    public AGSPlayerClient()
    {
    
    }

}
