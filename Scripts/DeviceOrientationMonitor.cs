using UnityEngine;
internal sealed class DeviceOrientationMonitor : MonoBehaviour
{
    // Fields
    internal static float 专丟丕丄丈丒丘丟丘;
    private static UnityEngine.DeviceOrientation <丙丗上与丆丄丟丕丌>k__BackingField;
    private static System.Action<UnityEngine.DeviceOrientation> 七丝丌七世丙丗丐上;
    
    // Properties
    internal static UnityEngine.DeviceOrientation 丈丘丙丞上与丂丗世 { get; set; }
    
    // Methods
    internal static UnityEngine.DeviceOrientation 丞丌七丞丕丄丗丝丅()
    {
        null = null;
        return (UnityEngine.DeviceOrientation)DeviceOrientationMonitor.<丙丗上与丆丄丟丕丌>k__BackingField;
    }
    private static void 丑丌丄丘与一丗丒丟(UnityEngine.DeviceOrientation 丙业与丙丗丝不丈东)
    {
        null = null;
        DeviceOrientationMonitor.<丙丗上与丆丄丟丕丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 丟丈东丑丒业丞业丌(System.Action<UnityEngine.DeviceOrientation> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  DeviceOrientationMonitor.七丝丌七世丙丗丐上, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DeviceOrientationMonitor.七丝丌七世丙丗丐上 != 1152921505171865608);
    
    }
    internal static void 丕丆丁丆丟丈上万丝(System.Action<UnityEngine.DeviceOrientation> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  DeviceOrientationMonitor.七丝丌七世丙丗丐上, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(DeviceOrientationMonitor.七丝丌七世丙丗丐上 != 1152921505171865608);
    
    }
    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丟丒丝丘下万下丑丒());
    }
    private void OnDisable()
    {
        this.StopAllCoroutines();
    }
    private System.Collections.IEnumerator 丟丒丝丘下万下丑丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new DeviceOrientationMonitor.丘丈丁三与丙东上上();
    }
    public DeviceOrientationMonitor()
    {
    
    }
    private static DeviceOrientationMonitor()
    {
        var val_2;
        DeviceOrientationMonitor.专丟丕丄丈丒丘丟丘 = 0.5f;
        val_2 = null;
        val_2 = null;
        DeviceOrientationMonitor.七丝丌七世丙丗丐上 = new System.Action<UnityEngine.DeviceOrientation>(object:  DeviceOrientationMonitor.<>c.<>9, method:  System.Void DeviceOrientationMonitor.<>c::专丛三丑丏丝丝丆业(UnityEngine.DeviceOrientation 丄三丅七丆丛与与上));
    }

}
