using UnityEngine;
private abstract class AmazonIapV2Impl.AmazonIapV2DelegatesBase : AmazonIapV2Impl.AmazonIapV2Base
{
    // Fields
    private const string CrossPlatformTool = "XAMARIN";
    protected com.amazon.device.iap.cpt.AmazonIapV2Impl.CallbackDelegate callbackDelegate;
    protected com.amazon.device.iap.cpt.AmazonIapV2Impl.CallbackDelegate eventDelegate;
    
    // Methods
    protected override void Init()
    {
        goto typeof(AmazonIapV2Impl.AmazonIapV2DelegatesBase).__il2cppRuntimeField_3B8;
    }
    protected override void RegisterCallback()
    {
        mem[1152921524236157408] = 0;
        mem[1152921524236157416] = public static System.Void com.amazon.device.iap.cpt.AmazonIapV2Impl::callback(string jsonMessage);
        mem[1152921524236157392] = public static System.Void com.amazon.device.iap.cpt.AmazonIapV2Impl::callback(string jsonMessage);
        this.callbackDelegate = new AmazonIapV2Impl.CallbackDelegate();
        goto typeof(AmazonIapV2Impl.AmazonIapV2DelegatesBase).__il2cppRuntimeField_3C8;
    }
    protected override void RegisterEventListener()
    {
        mem[1152921524236278624] = 0;
        mem[1152921524236278632] = public static System.Void com.amazon.device.iap.cpt.AmazonIapV2Impl::FireEvent(string jsonMessage);
        mem[1152921524236278608] = public static System.Void com.amazon.device.iap.cpt.AmazonIapV2Impl::FireEvent(string jsonMessage);
        this.eventDelegate = new AmazonIapV2Impl.CallbackDelegate();
        goto typeof(AmazonIapV2Impl.AmazonIapV2DelegatesBase).__il2cppRuntimeField_3D8;
    }
    protected override void RegisterCrossPlatformTool()
    {
        goto typeof(AmazonIapV2Impl.AmazonIapV2DelegatesBase).__il2cppRuntimeField_3E8;
    }
    public override void UnityFireEvent(string jsonMessage)
    {
        System.NotSupportedException val_1 = new System.NotSupportedException(message:  "UnityFireEvent is not supported");
    }
    protected abstract void NativeInit(); // 0
    protected abstract void NativeRegisterCallback(com.amazon.device.iap.cpt.AmazonIapV2Impl.CallbackDelegate callback); // 0
    protected abstract void NativeRegisterEventListener(com.amazon.device.iap.cpt.AmazonIapV2Impl.CallbackDelegate callback); // 0
    protected abstract void NativeRegisterCrossPlatformTool(string crossPlatformTool); // 0
    protected AmazonIapV2Impl.AmazonIapV2DelegatesBase()
    {
    
    }

}
