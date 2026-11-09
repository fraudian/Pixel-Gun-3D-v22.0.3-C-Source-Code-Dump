using UnityEngine;
public class AppsFlyerObjectScript : MonoBehaviour, 下三丒丆丌下丘且丟
{
    // Fields
    public string devKey;
    public string appID;
    public bool isDebug;
    public bool getConversionData;
    
    // Methods
    private void Start()
    {
        AppsFlyerSDK.AppsFlyer.setIsDebug(丅丘丘丙丘丛世七一:  (this.isDebug == true) ? 1 : 0);
        AppsFlyerSDK.AppsFlyer.initSDK(丁上东丄不丂东万专:  this.devKey, 丛七丞专丛丁丑万丆:  null, 下丐三丆丝与不丗丕:  (this.getConversionData == true) ? (this) : 0);
        AppsFlyerSDK.AppsFlyer.startSDK();
    }
    private void Update()
    {
    
    }
    public void onConversionDataSuccess(string 丒丟世丕三三丅一丗)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(丑与丆丝丕东丛丄丝:  "didReceiveConversionData", 下业七不丑丂丏丟东:  丒丟世丕三三丅一丗);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(下业七不丑丂丏丟东:  丒丟世丕三三丅一丗);
    }
    public void onConversionDataFail(string 丂七东不不丈一丐不)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(丑与丆丝丕东丛丄丝:  "didReceiveConversionDataWithError", 下业七不丑丂丏丟东:  丂七东不不丈一丐不);
    }
    public void onAppOpenAttribution(string 且丆丆丒丆七丁不丌)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(丑与丆丝丕东丛丄丝:  "onAppOpenAttribution", 下业七不丑丂丏丟东:  且丆丆丒丆七丁不丌);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = AppsFlyerSDK.AppsFlyer.CallbackStringToDictionary(下业七不丑丂丏丟东:  且丆丆丒丆七丁不丌);
    }
    public void onAppOpenAttributionFailure(string 丂七东不不丈一丐不)
    {
        AppsFlyerSDK.AppsFlyer.AFLog(丑与丆丝丕东丛丄丝:  "onAppOpenAttributionFailure", 下业七不丑丂丏丟东:  丂七东不不丈一丐不);
    }
    public AppsFlyerObjectScript()
    {
    
    }

}
