using UnityEngine;
public class AGSClient : MonoBehaviour
{
    // Fields
    private static System.Action ServiceReadyEvent;
    private static System.Action<string> ServiceNotReadyEvent;
    public const string serviceName = "AmazonGameCircle";
    public const AmazonLogging.AmazonLoggingLevel errorLevel = 5;
    public static bool ReinitializeOnFocus;
    private static bool IsReady;
    private static bool supportsAchievements;
    private static bool supportsLeaderboards;
    private static bool supportsWhispersync;
    private static AmazonJavaWrapper JavaObject;
    private static readonly string PROXY_CLASS_NAME;
    
    // Methods
    public static void add_ServiceReadyEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  AGSClient.errorLevel, b:  value);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void remove_ServiceReadyEvent(System.Action value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  AGSClient.errorLevel, value:  value);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void add_ServiceNotReadyEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AGSClient.ServiceNotReadyEvent, b:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSClient.ServiceNotReadyEvent != 1152921505014890504);
    
    }
    public static void remove_ServiceNotReadyEvent(System.Action<string> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AGSClient.ServiceNotReadyEvent, value:  value);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AGSClient.ServiceNotReadyEvent != 1152921505014890504);
    
    }
    private static AGSClient()
    {
        var val_10;
        UnityEngine.AndroidJavaObject val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = 1152921505014886400;
        AGSClient.ReinitializeOnFocus = false;
        AGSClient.IsReady = false;
        AGSClient.supportsAchievements = false;
        AGSClient.supportsLeaderboards = false;
        AGSClient.supportsWhispersync = false;
        AGSClient.PROXY_CLASS_NAME = "com.amazon.ags.api.unity.AmazonGamesClientProxyImpl";
        AGSClient.JavaObject = new AmazonJavaWrapper();
        UnityEngine.AndroidJavaClass val_2 = null;
        val_12 = val_2;
        val_2 = new UnityEngine.AndroidJavaClass(className:  AGSClient.PROXY_CLASS_NAME);
        if((System.IntPtr.op_Equality(value1:  val_2.GetRawClass(), value2:  0)) != false)
        {
                AGSClient.LogGameCircleWarning(errorMessage:  "No java class " + AGSClient.PROXY_CLASS_NAME + " present, can\'t use AGSClient");
            val_13 = 0;
            val_14 = 0;
        }
        else
        {
                val_11 = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getInstance", args:  System.Array.Empty<System.Object>());
            val_13 = 0;
            val_14 = 0;
            mem[1152921524032817168] = val_11;
        }
        
        if(val_12 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            val_2.Dispose();
        }
        
        if(val_13 == 1)
        {
            goto label_11;
        }
        
        if((val_14 == 0) || (144 == 144))
        {
            goto label_13;
        }
        
        label_14:
        val_10 = ???;
        val_14 = ???;
        val_12 = ???;
        val_11 = ???;
        val_13 = ???;
        label_11:
        if(val_14 != 0)
        {
            goto label_14;
        }
        
        label_13:
        var val_9 = val_10 - 48;
    }
    public static void Init()
    {
        null = null;
        AGSClient.Init(supportsLeaderboards:  AGSClient.supportsLeaderboards, supportsAchievements:  AGSClient.supportsAchievements, supportsWhispersync:  AGSClient.supportsWhispersync);
    }
    public static void Init(bool supportsLeaderboards, bool supportsAchievements, bool supportsWhispersync)
    {
        var val_5;
        bool val_1 = supportsLeaderboards;
        bool val_2 = supportsAchievements;
        bool val_3 = supportsWhispersync;
        val_5 = null;
        val_5 = null;
        AGSClient.ReinitializeOnFocus = true;
        AGSClient.supportsAchievements = val_2;
        AGSClient.supportsLeaderboards = val_1;
        AGSClient.supportsWhispersync = val_3;
        object[] val_4 = new object[3];
        if(val_4 == null)
        {
            goto label_3;
        }
        
        if(val_1 == true)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_1 == false)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_4[0] = val_1;
        val_4[1] = val_2;
        val_4[2] = val_3;
        AGSClient.JavaObject.Call(method:  "init", args:  val_4);
    }
    public static void SetPopUpEnabled(bool enabled)
    {
        var val_3;
        bool val_1 = enabled;
        val_3 = null;
        val_3 = null;
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_1 == true)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_1 == false)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = val_1;
        AGSClient.JavaObject.Call(method:  "setPopupEnabled", args:  val_2);
    }
    public static void SetPopUpLocation(GameCirclePopupLocation location)
    {
        null = null;
        object[] val_1 = new object[1];
        string val_2 = location.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if(val_2 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_2 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_1[0] = val_2;
        AGSClient.JavaObject.Call(method:  "setPopUpLocation", args:  val_1);
    }
    public static void ServiceReady(string empty)
    {
        AGSClient.Log(message:  "Client GameCircle - Service is ready");
        AGSClient.IsReady = true;
        if(AGSClient.errorLevel == 0)
        {
                return;
        }
        
        0.Invoke();
    }
    public static bool IsServiceReady()
    {
        null = null;
        return (bool)AGSClient.IsReady;
    }
    public static void release()
    {
        null = null;
        AGSClient.JavaObject.Call(method:  "release", args:  System.Array.Empty<System.Object>());
    }
    public static void Shutdown()
    {
        null = null;
        AGSClient.JavaObject.Call(method:  "shutdown", args:  System.Array.Empty<System.Object>());
    }
    public static void ServiceNotReady(string param)
    {
        var val_1;
        System.Action<System.String> val_2;
        val_1 = null;
        val_1 = null;
        AGSClient.IsReady = false;
        val_2 = AGSClient.ServiceNotReadyEvent;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AGSClient.ServiceNotReadyEvent;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke(obj:  param);
    }
    public static void ShowGameCircleOverlay()
    {
        null = null;
        AGSClient.JavaObject.Call(method:  "showGameCircleOverlay", args:  System.Array.Empty<System.Object>());
    }
    public static void ShowSignInPage()
    {
        null = null;
        AGSClient.JavaObject.Call(method:  "showSignInPage", args:  System.Array.Empty<System.Object>());
    }
    public static void LogGameCircleError(string errorMessage)
    {
        AmazonLogging.LogError(reportLevel:  5, service:  "AmazonGameCircle", message:  errorMessage);
    }
    public static void LogGameCircleWarning(string errorMessage)
    {
        AmazonLogging.LogWarning(reportLevel:  5, service:  "AmazonGameCircle", message:  errorMessage);
    }
    public static void Log(string message)
    {
        AmazonLogging.Log(reportLevel:  5, service:  "AmazonGameCircle", message:  message);
    }
    public AGSClient()
    {
    
    }

}
