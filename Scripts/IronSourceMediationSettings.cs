using UnityEngine;
public class IronSourceMediationSettings : ScriptableObject
{
    // Fields
    public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH;
    public string AndroidAppKey;
    public string IOSAppKey;
    public bool EnableIronsourceSDKInitAPI;
    public bool AddIronsourceSkadnetworkID;
    public bool EnableAdapterDebug;
    public bool EnableIntegrationHelper;
    
    // Methods
    public IronSourceMediationSettings()
    {
        this.AndroidAppKey = System.String.alignConst;
        this.IOSAppKey = System.String.alignConst;
    }
    private static IronSourceMediationSettings()
    {
        IronSourceMediationSettings.IRONSOURCE_SETTINGS_ASSET_PATH = System.IO.Path.Combine(path1:  "Assets/IronSource/Resources", path2:  "IronSourceMediationSettings.asset");
    }

}
