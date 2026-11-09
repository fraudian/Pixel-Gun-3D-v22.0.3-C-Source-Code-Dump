using UnityEngine;
private abstract class AmazonMobileAdsImpl.AmazonMobileAdsDelegatesBase : AmazonMobileAdsImpl.AmazonMobileAdsBase
{
    // Fields
    private const string CrossPlatformTool = "XAMARIN";
    protected com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.CallbackDelegate callbackDelegate;
    protected com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.CallbackDelegate eventDelegate;
    
    // Methods
    protected override void Init()
    {
        goto typeof(AmazonMobileAdsImpl.AmazonMobileAdsDelegatesBase).__il2cppRuntimeField_5B8;
    }
    protected override void RegisterCallback()
    {
        mem[1152921524207704240] = 0;
        mem[1152921524207704248] = public static System.Void com.amazon.mas.cpt.ads.AmazonMobileAdsImpl::callback(string jsonMessage);
        mem[1152921524207704224] = public static System.Void com.amazon.mas.cpt.ads.AmazonMobileAdsImpl::callback(string jsonMessage);
        this.callbackDelegate = new AmazonMobileAdsImpl.CallbackDelegate();
        goto typeof(AmazonMobileAdsImpl.AmazonMobileAdsDelegatesBase).__il2cppRuntimeField_5C8;
    }
    protected override void RegisterEventListener()
    {
        mem[1152921524207825456] = 0;
        mem[1152921524207825464] = public static System.Void com.amazon.mas.cpt.ads.AmazonMobileAdsImpl::FireEvent(string jsonMessage);
        mem[1152921524207825440] = public static System.Void com.amazon.mas.cpt.ads.AmazonMobileAdsImpl::FireEvent(string jsonMessage);
        this.eventDelegate = new AmazonMobileAdsImpl.CallbackDelegate();
        goto typeof(AmazonMobileAdsImpl.AmazonMobileAdsDelegatesBase).__il2cppRuntimeField_5D8;
    }
    protected override void RegisterCrossPlatformTool()
    {
        goto typeof(AmazonMobileAdsImpl.AmazonMobileAdsDelegatesBase).__il2cppRuntimeField_5E8;
    }
    public override void UnityFireEvent(string jsonMessage)
    {
        System.NotSupportedException val_1 = new System.NotSupportedException(message:  "UnityFireEvent is not supported");
    }
    protected abstract void NativeInit(); // 0
    protected abstract void NativeRegisterCallback(com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.CallbackDelegate callback); // 0
    protected abstract void NativeRegisterEventListener(com.amazon.mas.cpt.ads.AmazonMobileAdsImpl.CallbackDelegate callback); // 0
    protected abstract void NativeRegisterCrossPlatformTool(string crossPlatformTool); // 0
    protected AmazonMobileAdsImpl.AmazonMobileAdsDelegatesBase()
    {
    
    }

}
