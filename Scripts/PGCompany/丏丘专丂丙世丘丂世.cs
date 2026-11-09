using UnityEngine;

namespace PGCompany
{
    internal static class 丏丘专丂丙世丘丂世
    {
        // Fields
        private static long 丌下丞专三丐丝丝三;
        
        // Methods
        internal static string 三丄丅丄丌丈丈丑下()
        {
            string val_16 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    val_16 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != false)
            {
                    val_16 = new System.Random(Seed:  专七专下且专三一且.上且一丈丐三丄一丆()).ToString();
            }
            
            if(PixelTime.丝丗专上三不丄丑丑() > 0)
            {
                    string val_10 = PixelTime.丝丗专上三不丄丑丑().ToString();
            }
            else
            {
                
            }
            
            long val_16 = PGCompany.丏丘专丂丙世丘丂世.丌下丞专三丐丝丝三;
            val_16 = val_16 + 1;
            PGCompany.丏丘专丂丙世丘丂世.丌下丞专三丐丝丝三 = val_16;
            string[] val_14 = new string[5];
            val_14[0] = val_16;
            val_14[1] = ".";
            val_14[2] = System.String.Format(format:  "{0}.l", arg0:  专七专下且专三一且.上且一丈丐三丄一丆());
            val_14[3] = ".";
            val_14[4] = val_16.ToString();
            return (string)+val_14;
        }
    
    }

}
