using UnityEngine;
public class AGSWhispersyncClient : MonoBehaviour
{
    // Fields
    private static AmazonJavaWrapper javaObject;
    private static readonly string PROXY_CLASS_NAME;
    private static System.Action OnNewCloudDataEvent;
    private static System.Action OnDataUploadedToCloudEvent;
    private static System.Action OnThrottledEvent;
    private static System.Action OnDiskWriteCompleteEvent;
    private static System.Action OnFirstSynchronizeEvent;
    private static System.Action OnAlreadySynchronizedEvent;
    private static System.Action OnSyncFailedEvent;
    public static string failReason;
    
    // Methods
    public static void add_OnNewCloudDataEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnNewCloudDataEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnNewCloudDataEvent != 1152921505016381456);
    
    }
    public static void remove_OnNewCloudDataEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnNewCloudDataEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnNewCloudDataEvent != 1152921505016381456);
    
    }
    public static void add_OnDataUploadedToCloudEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnDataUploadedToCloudEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnDataUploadedToCloudEvent != 1152921505016381464);
    
    }
    public static void remove_OnDataUploadedToCloudEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnDataUploadedToCloudEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnDataUploadedToCloudEvent != 1152921505016381464);
    
    }
    public static void add_OnThrottledEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnThrottledEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnThrottledEvent != 1152921505016381472);
    
    }
    public static void remove_OnThrottledEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnThrottledEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnThrottledEvent != 1152921505016381472);
    
    }
    public static void add_OnDiskWriteCompleteEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnDiskWriteCompleteEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnDiskWriteCompleteEvent != 1152921505016381480);
    
    }
    public static void remove_OnDiskWriteCompleteEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnDiskWriteCompleteEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnDiskWriteCompleteEvent != 1152921505016381480);
    
    }
    public static void add_OnFirstSynchronizeEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnFirstSynchronizeEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnFirstSynchronizeEvent != 1152921505016381488);
    
    }
    public static void remove_OnFirstSynchronizeEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnFirstSynchronizeEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnFirstSynchronizeEvent != 1152921505016381488);
    
    }
    public static void add_OnAlreadySynchronizedEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnAlreadySynchronizedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnAlreadySynchronizedEvent != 1152921505016381496);
    
    }
    public static void remove_OnAlreadySynchronizedEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnAlreadySynchronizedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnAlreadySynchronizedEvent != 1152921505016381496);
    
    }
    public static void add_OnSyncFailedEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSWhispersyncClient.OnSyncFailedEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnSyncFailedEvent != 1152921505016381504);
    
    }
    public static void remove_OnSyncFailedEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSWhispersyncClient.OnSyncFailedEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSWhispersyncClient.OnSyncFailedEvent != 1152921505016381504);
    
    }
    private static AGSWhispersyncClient()
    {
        var val_10;
        UnityEngine.AndroidJavaObject val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 1152921505016377344;
        AGSWhispersyncClient.javaObject = 0;
        AGSWhispersyncClient.PROXY_CLASS_NAME = "com.amazon.ags.api.unity.WhispersyncClientProxyImpl";
        AGSWhispersyncClient.failReason = 0;
        AGSWhispersyncClient.javaObject = new AmazonJavaWrapper();
        UnityEngine.AndroidJavaClass val_2 = null;
        val_12 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  AGSWhispersyncClient.PROXY_CLASS_NAME);
        if((System.IntPtr.op_Equality(value1:  val_2.GetRawClass(), value2:  0)) != false)
        {
                AGSClient.LogGameCircleWarning(errorMessage:  "No java class " + AGSWhispersyncClient.PROXY_CLASS_NAME + " present, can\'t use AGSWhispersyncClient");
            val_13 = 0;
            val_14 = 0;
        }
        else
        {
                val_11 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            val_13 = 0;
            val_14 = 0;
            mem[1152921524073315568] = val_11;
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
        
        if((val_14 == 0) || (126 == 126))
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
    public static AGSGameDataMap GetGameData()
    {
        var val_5;
        UnityEngine.AndroidJavaObject val_6;
        val_5 = null;
        val_5 = null;
        val_6 = AGSWhispersyncClient.javaObject.Call<UnityEngine.AndroidJavaObject>(method:  "getGameData", args:  System.Array.Empty<System.Object>());
        if(val_6 == null)
        {
                return (AGSGameDataMap)val_6;
        }
        
        .jo = val_6;
        AGSGameDataMap val_4 = null;
        val_6 = val_4;
        val_4 = new AGSGameDataMap();
        mem[1152921524073576160] = new AmazonJavaWrapper();
        return (AGSGameDataMap)val_6;
    }
    public static void Synchronize()
    {
        null = null;
        AGSWhispersyncClient.javaObject.Call(method:  "synchronize", args:  System.Array.Empty<System.Object>());
    }
    public static void Flush()
    {
        null = null;
        AGSWhispersyncClient.javaObject.Call(method:  "flush", args:  System.Array.Empty<System.Object>());
    }
    public static void OnNewCloudData()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = AGSWhispersyncClient.OnNewCloudDataEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnNewCloudDataEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void OnDataUploadedToCloud()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = AGSWhispersyncClient.OnDataUploadedToCloudEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnDataUploadedToCloudEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void OnThrottled()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = AGSWhispersyncClient.OnThrottledEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnThrottledEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void OnDiskWriteComplete()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = AGSWhispersyncClient.OnDiskWriteCompleteEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnDiskWriteCompleteEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void OnFirstSynchronize()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = AGSWhispersyncClient.OnFirstSynchronizeEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnFirstSynchronizeEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void OnAlreadySynchronized()
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        val_2 = AGSWhispersyncClient.OnAlreadySynchronizedEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnAlreadySynchronizedEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void OnSyncFailed(string failReason)
    {
        var val_1;
        System.Action val_2;
        val_1 = null;
        val_1 = null;
        AGSWhispersyncClient.failReason = failReason;
        val_2 = AGSWhispersyncClient.OnSyncFailedEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSWhispersyncClient.OnSyncFailedEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public AGSWhispersyncClient()
    {
    
    }

}
