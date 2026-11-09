using UnityEngine;
private class AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid : AmazonMobileAdsImpl.AmazonMobileAdsUnityBase
{
    // Properties
    public static com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid Instance { get; }
    
    // Methods
    private static extern string nativeRegisterCallbackGameObject(string name)
    {
        if(100730744 != 0)
        {
                return (string)name;
        }
    
    }
    private static extern string nativeInit()
    {
        if(100730744 != 0)
        {
                return (string);
        }
    
    }
    private static extern string nativeSetApplicationKeyJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeRegisterApplicationJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeEnableLoggingJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeEnableTestingJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeEnableGeoLocationJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeCreateFloatingBannerAdJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeCreateInterstitialAdJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeLoadAndShowFloatingBannerAdJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeLoadInterstitialAdJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeShowInterstitialAdJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeCloseFloatingBannerAdJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeIsInterstitialAdReadyJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeAreAdsEqualJson(string jsonMessage)
    {
        if(100730744 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    public static com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid get_Instance()
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityBase.getInstance<AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid>();
    }
    protected override void NativeInit()
    {
        string val_1 = AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeInit();
    }
    protected override void RegisterCallback()
    {
        string val_3 = AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeRegisterCallbackGameObject(name:  this.gameObject.name);
    }
    protected override void RegisterEventListener()
    {
        string val_3 = AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeRegisterCallbackGameObject(name:  this.gameObject.name);
    }
    protected override void NativeRegisterCrossPlatformTool(string crossPlatformTool)
    {
    
    }
    protected override string NativeSetApplicationKeyJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeSetApplicationKeyJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeRegisterApplicationJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeRegisterApplicationJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeEnableLoggingJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeEnableLoggingJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeEnableTestingJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeEnableTestingJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeEnableGeoLocationJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeEnableGeoLocationJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeCreateFloatingBannerAdJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeCreateFloatingBannerAdJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeCreateInterstitialAdJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeCreateInterstitialAdJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeLoadAndShowFloatingBannerAdJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeLoadAndShowFloatingBannerAdJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeLoadInterstitialAdJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeLoadInterstitialAdJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeShowInterstitialAdJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeShowInterstitialAdJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeCloseFloatingBannerAdJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeCloseFloatingBannerAdJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeIsInterstitialAdReadyJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeIsInterstitialAdReadyJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeAreAdsEqualJson(string jsonMessage)
    {
        return AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid.nativeAreAdsEqualJson(jsonMessage:  jsonMessage);
    }
    public AmazonMobileAdsImpl.AmazonMobileAdsUnityAndroid()
    {
    
    }

}
