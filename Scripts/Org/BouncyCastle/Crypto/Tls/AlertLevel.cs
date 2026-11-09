using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class AlertLevel
    {
        // Fields
        public const byte warning = 1;
        public const byte fatal = 2;
        
        // Methods
        public static string GetName(byte alertDescription)
        {
            byte val_1 = alertDescription & 255;
            val_1 = (val_1 == 1) ? "warning" : ((val_1 != 2) ? "UNKNOWN" : "fatal");
            return (string)val_1;
        }
        public static string GetText(byte alertDescription)
        {
            object[] val_1 = new object[4];
            byte val_2 = alertDescription & 255;
            val_2 = (val_2 == 1) ? "warning" : ((val_2 != 2) ? "UNKNOWN" : "fatal");
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = "(";
            val_1[2] = alertDescription;
            val_1[3] = ")";
            return (string)+val_1;
        }
        protected AlertLevel()
        {
        
        }
    
    }

}
