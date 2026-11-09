using UnityEngine;

namespace PGCompany
{
    public sealed class SKStoreReviewControllerManaged
    {
        // Methods
        public static void RequestReview()
        {
            bool val_1 = UnityEngine.Application.isEditor;
        }
        public static bool IsRequestReviewSupported(string iosVersion)
        {
            string val_10;
            var val_11;
            val_10 = iosVersion;
            int val_5 = 0;
            val_11 = 0;
            if((System.String.IsNullOrEmpty(value:  val_10)) == true)
            {
                    return (bool)val_11;
            }
            
            char[] val_2 = new char[1];
            val_2[0] = '.';
            val_10 = val_10.Split(separator:  val_2, options:  0);
            if((val_3.Length >= 1) && (((System.Int32.TryParse(s:  val_10[0], style:  7, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_5)) != false) && (0 >= 10)))
            {
                    if(0 != 10)
            {
                    return (bool)val_11;
            }
            
                if(val_3.Length >= 2)
            {
                    val_10 = val_10[1];
                if((System.Int32.TryParse(s:  val_10, style:  7, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_5)) != false)
            {
                    var val_9 = (0 > 2) ? 1 : 0;
                return (bool)val_11;
            }
            
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        public static string IosVersion()
        {
            if(UnityEngine.Application.isEditor == false)
            {
                    return (string)System.String.alignConst;
            }
            
            return UnityEngine.SystemInfo.operatingSystem;
        }
        public SKStoreReviewControllerManaged()
        {
        
        }
    
    }

}
