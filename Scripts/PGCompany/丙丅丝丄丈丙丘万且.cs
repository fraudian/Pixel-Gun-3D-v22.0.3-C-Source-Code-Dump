using UnityEngine;

namespace PGCompany
{
    internal sealed class 丙丅丝丄丈丙丘万且 : 不丄上丘丆业丟丕七
    {
        // Fields
        private static PGCompany.丙丅丝丄丈丙丘万且 世丒丞七专三与万丕;
        
        // Properties
        internal static PGCompany.丙丅丝丄丈丙丘万且 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.丙丅丝丄丈丙丘万且 丑七不且上丗丁一世()
        {
            PGCompany.丙丅丝丄丈丙丘万且 val_2;
            PGCompany.丙丅丝丄丈丙丘万且 val_3 = PGCompany.丙丅丝丄丈丙丘万且.世丒丞七专三与万丕;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.丙丅丝丄丈丙丘万且 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.丙丅丝丄丈丙丘万且();
            PGCompany.丙丅丝丄丈丙丘万且.世丒丞七专三与万丕 = val_2;
            val_3 = PGCompany.丙丅丝丄丈丙丘万且.世丒丞七专三与万丕;
            return val_3;
        }
        public PGCompany.七丙上丛七万且丁丟 丘丑丗丛下丒丁丙上()
        {
            var val_4;
            if((UnityEngine.Application.isEditor != true) && (UnityEngine.Application.platform == 8))
            {
                    PGCompany.UIDeviceManaged.SetBatteryMonitoringEnabled(value:  true);
                if(PGCompany.UIDeviceManaged.GetBatteryState() < 4)
            {
                    val_4 = mem[106032352 + (val_3) << 2];
                val_4 = 106032352 + (val_3) << 2;
                return (PGCompany.七丙上丛七万且丁丟)val_4;
            }
            
            }
            
            val_4 = 0;
            return (PGCompany.七丙上丛七万且丁丟)val_4;
        }
        public PGCompany.丌丛万丅丕丞业丌丄 丁丐丘丟丈丌丞世丒()
        {
            var val_6;
            PGCompany.丌丛万丅丕丞业丌丄 val_0;
            if(UnityEngine.Application.isEditor != false)
            {
                
            }
            else
            {
                    if(UnityEngine.Application.platform == 8)
            {
                    PGCompany.UIDeviceManaged.SetBatteryMonitoringEnabled(value:  true);
                if(PGCompany.UIDeviceManaged.GetBatteryState() <= 3)
            {
                    val_6 = mem[106032352 + (val_3) << 2];
                val_6 = 106032352 + (val_3) << 2;
            }
            else
            {
                    val_6 = 0;
            }
            
                float val_4 = PGCompany.UIDeviceManaged.GetBatteryLevel();
                if(val_4 < 0)
            {
                
            }
            else
            {
                    float val_6 = 10000f;
                val_6 = val_4 * val_6;
                int val_5 = System.Convert.ToInt32(value:  val_6);
            }
            
            }
            
            }
            
            val_0.<丟不丆上与三不不丞>k__BackingField = 0;
            val_0.<丗丈世七七丗丙万丒>k__BackingField = 0;
            val_0.<丐下丘丟丂丁丘丄下>k__BackingField = 0;
            return val_0;
        }
        private PGCompany.七丙上丛七万且丁丟 丝丆且且丛业丑下丙(int 丕一业世与丗丞丘七)
        {
            if(丕一业世与丗丞丘七 > 3)
            {
                    return 0;
            }
            
            return (PGCompany.七丙上丛七万且丁丟)106032352 + (丕一业世与丗丞丘七) << 2;
        }
        public 丙丅丝丄丈丙丘万且()
        {
        
        }
    
    }

}
