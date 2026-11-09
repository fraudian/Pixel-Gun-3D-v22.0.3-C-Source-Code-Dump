using UnityEngine;

namespace PGCompany
{
    public sealed class UIDeviceManaged
    {
        // Methods
        public static void SetBatteryMonitoringEnabled(bool value)
        {
            bool val_1 = UnityEngine.Application.isEditor;
        }
        public static float GetBatteryLevel()
        {
            bool val_1 = UnityEngine.Application.isEditor;
            return -1f;
        }
        public static int GetBatteryState()
        {
            bool val_1 = UnityEngine.Application.isEditor;
            return 0;
        }
        public UIDeviceManaged()
        {
        
        }
    
    }

}
