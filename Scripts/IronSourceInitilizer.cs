using UnityEngine;
public class IronSourceInitilizer
{
    // Methods
    private static void Initilize()
    {
        string val_7;
        IronSourceMediationSettings val_1 = UnityEngine.Resources.Load<IronSourceMediationSettings>(path:  "IronSourceMediationSettings");
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1 != null)
        {
                val_7 = val_1.AndroidAppKey;
        }
        else
        {
                val_7 = 28563616;
        }
        
        if(val_1.EnableIronsourceSDKInitAPI != false)
        {
                if((val_7.Equals(value:  System.String.alignConst)) != false)
        {
                UnityEngine.Debug.LogWarning(message:  "IronSourceInitilizer Cannot init without AppKey");
        }
        else
        {
                丐上丐丐丆万丈丑万.丕丛一丌丛上丝丆东().七东丐丟世丕丏丞且(万下丈世丏业丛丕不:  val_7);
        }
        
        }
        
        if(val_1.EnableAdapterDebug != false)
        {
                丐上丐丐丆万丈丑万.丕丛一丌丛上丝丆东().丐丁丅丝业丛丝丌业(丝三丄专丗丞丄丄丌:  true);
        }
        
        if(val_1.EnableIntegrationHelper == false)
        {
                return;
        }
        
        丐上丐丐丆万丈丑万.丕丛一丌丛上丝丆东().万丟丄东丛丘七与丐();
    }
    public IronSourceInitilizer()
    {
    
    }

}
