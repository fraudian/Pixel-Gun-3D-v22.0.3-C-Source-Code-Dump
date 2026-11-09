using UnityEngine;
public sealed class IDFAPermissionsPlugin
{
    // Fields
    private static System.Action<IdfaBannerResult> ClosedIdfaBanner;
    private static bool _initializedCallback;
    
    // Methods
    public static void add_ClosedIdfaBanner(System.Action<IdfaBannerResult> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  IDFAPermissionsPlugin.ClosedIdfaBanner, b:  value);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void remove_ClosedIdfaBanner(System.Action<IdfaBannerResult> value)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  IDFAPermissionsPlugin.ClosedIdfaBanner, value:  value);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void RequestPermissionForIDFA()
    {
    
    }
    public static bool CanShowIDFADialog()
    {
        return false;
    }
    public static bool IsAuthorized()
    {
        return false;
    }
    public IDFAPermissionsPlugin()
    {
    
    }
    private static IDFAPermissionsPlugin()
    {
    
    }

}
