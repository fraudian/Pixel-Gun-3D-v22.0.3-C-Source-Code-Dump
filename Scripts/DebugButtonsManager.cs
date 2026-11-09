using UnityEngine;
internal sealed class DebugButtonsManager : MonoBehaviour
{
    // Fields
    private static DebugButtonsManager 丝业丆丁业三丈丟东;
    private static DebugWindow 丌丅丆一丈丞世丙丘;
    private bool 丝不丁与丑丟丂上丆;
    private static bool 丘丂丁与丂东不丑下;
    internal static bool 丟丒丙下业丐丒业且;
    
    // Properties
    public static DebugWindow 丅丕且丌一不丈不上 { get; set; }
    private bool 业万丁丏下且三丆丝 { get; }
    public static bool 丛丈世不丘三丝丘不 { get; }
    
    // Methods
    public static DebugWindow get_MainDebugPanel()
    {
        null = null;
        return (DebugWindow)DebugButtonsManager.丌丅丆一丈丞世丙丘;
    }
    private static void 上一一丏丐下丒丙七(DebugWindow 丙业与丙丗丝不丈东)
    {
        null = null;
        DebugButtonsManager.丌丅丆一丈丞世丙丘 = 丙业与丙丗丝不丈东;
    }
    private bool 丛丑丅上且业世不丆()
    {
        var val_3;
        WeaponManager val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_4 == 0)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return false;
        }
        
        val_6 = null;
        val_6 = null;
        if(null != 0)
        {
                return 丆丗丂三丐不东且丏();
        }
        
        return 丆丗丂三丐不东且丏();
    }
    public static bool get_InterfaceAvailable()
    {
        null = null;
        return (bool)DebugButtonsManager.丘丂丁与丂东不丑下;
    }
    private void Awake()
    {
        null = null;
        DebugButtonsManager.丝业丆丁业三丈丟东 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void OnDestroy()
    {
        null = null;
        DebugButtonsManager.丝业丆丁业三丈丟东 = 0;
        DebugButtonsManager.丌丅丆一丈丞世丙丘 = 0;
    }
    private void 丒丄丝丄丗丁丟丅丕()
    {
    
    }
    private void 下丐丛丐与丐业与丒()
    {
    
    }
    private void 丑不丂丛上万一丐丗()
    {
    
    }
    public DebugButtonsManager()
    {
        this.丝不丁与丑丟丂上丆 = true;
    }
    private static DebugButtonsManager()
    {
        DebugButtonsManager.丘丂丁与丂东不丑下 = true;
    }

}
