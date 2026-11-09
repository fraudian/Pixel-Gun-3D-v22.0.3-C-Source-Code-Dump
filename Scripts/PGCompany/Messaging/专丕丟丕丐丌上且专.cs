using UnityEngine;

namespace PGCompany.Messaging
{
    internal static class 专丕丟丕丐丌上且专
    {
        // Fields
        private static string 业且丅丒丁丗丄丘丟;
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        
        // Methods
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        internal static string 三丌下丄丈与七丙丙()
        {
            var val_6;
            string val_7;
            val_6 = 1152921505652264960;
            val_7 = PGCompany.Messaging.专丕丟丕丐丌上且专.业且丅丒丁丗丄丘丟;
            if(val_7 != null)
            {
                    return (string)val_7;
            }
            
            if(UnityEngine.Application.platform == 11)
            {
                    string val_4 = Rilisoft.丅丒三丐不丏业丛万.丞三丅丈上丘丕且丈().ToString(provider:  PGCompany.Messaging.专丕丟丕丐丌上且专.丙专丝世不业下丂丈());
            }
            else
            {
                    if(UnityEngine.SystemInfo.operatingSystem == null)
            {
                    val_7 = System.String.alignConst;
            }
            
            }
            
            PGCompany.Messaging.专丕丟丕丐丌上且专.业且丅丒丁丗丄丘丟 = val_7;
            return (string)val_7;
        }
    
    }

}
