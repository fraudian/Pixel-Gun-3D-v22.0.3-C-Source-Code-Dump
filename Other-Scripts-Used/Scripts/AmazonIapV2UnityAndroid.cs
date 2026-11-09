using UnityEngine;
private class AmazonIapV2Impl.AmazonIapV2UnityAndroid : AmazonIapV2Impl.AmazonIapV2UnityBase
{
    // Properties
    public static com.amazon.device.iap.cpt.AmazonIapV2Impl.AmazonIapV2UnityAndroid Instance { get; }
    
    // Methods
    private static extern string nativeRegisterCallbackGameObject(string name)
    {
        if(100653588 != 0)
        {
                return (string)name;
        }
    
    }
    private static extern string nativeInit()
    {
        if(100653588 != 0)
        {
                return (string);
        }
    
    }
    private static extern string nativeGetUserDataJson(string jsonMessage)
    {
        if(100653588 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativePurchaseJson(string jsonMessage)
    {
        if(100653588 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeGetProductDataJson(string jsonMessage)
    {
        if(100653588 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeGetPurchaseUpdatesJson(string jsonMessage)
    {
        if(100653588 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    private static extern string nativeNotifyFulfillmentJson(string jsonMessage)
    {
        if(100653588 != 0)
        {
                return (string)jsonMessage;
        }
    
    }
    public static com.amazon.device.iap.cpt.AmazonIapV2Impl.AmazonIapV2UnityAndroid get_Instance()
    {
        return AmazonIapV2Impl.AmazonIapV2UnityBase.getInstance<AmazonIapV2Impl.AmazonIapV2UnityAndroid>();
    }
    protected override void NativeInit()
    {
        string val_1 = AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeInit();
    }
    protected override void RegisterCallback()
    {
        string val_3 = AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeRegisterCallbackGameObject(name:  this.gameObject.name);
    }
    protected override void RegisterEventListener()
    {
        string val_3 = AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeRegisterCallbackGameObject(name:  this.gameObject.name);
    }
    protected override void NativeRegisterCrossPlatformTool(string crossPlatformTool)
    {
    
    }
    protected override string NativeGetUserDataJson(string jsonMessage)
    {
        return AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeGetUserDataJson(jsonMessage:  jsonMessage);
    }
    protected override string NativePurchaseJson(string jsonMessage)
    {
        return AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativePurchaseJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeGetProductDataJson(string jsonMessage)
    {
        return AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeGetProductDataJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeGetPurchaseUpdatesJson(string jsonMessage)
    {
        return AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeGetPurchaseUpdatesJson(jsonMessage:  jsonMessage);
    }
    protected override string NativeNotifyFulfillmentJson(string jsonMessage)
    {
        return AmazonIapV2Impl.AmazonIapV2UnityAndroid.nativeNotifyFulfillmentJson(jsonMessage:  jsonMessage);
    }
    public AmazonIapV2Impl.AmazonIapV2UnityAndroid()
    {
    
    }

}
