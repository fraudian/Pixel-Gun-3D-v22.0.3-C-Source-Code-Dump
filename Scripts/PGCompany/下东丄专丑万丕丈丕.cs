using UnityEngine;

namespace PGCompany
{
    public class 下东丄专丑万丕丈丕
    {
        // Fields
        private static readonly string[] 世丐丝业丐丅丄丕世;
        
        // Methods
        internal static string 三丂万丒丞业专业下(long 丝丆丁丞丛三丁丑丙)
        {
            double val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = (double)丝丆丁丞丛三丁丑丙;
            val_3 = 0;
            goto label_1;
            label_8:
            val_4 = null;
            val_4 = null;
            int val_2 = PGCompany.下东丄专丑万丕丈丕.世丐丝业丐丅丄丕世.Length;
            val_2 = val_2 - 1;
            if(val_3 >= val_2)
            {
                goto label_5;
            }
            
            val_2 = val_2 * 0.0009765625;
            val_3 = 1;
            label_1:
            if(System.Math.Abs(val_2) >= 1024)
            {
                goto label_8;
            }
            
            label_5:
            val_5 = null;
            val_5 = null;
            return (string)System.String.Format(format:  "{0:0.00} {1}", arg0:  val_2, arg1:  PGCompany.下东丄专丑万丕丈丕.世丐丝业丐丅丄丕世.Length + 32);
        }
        public 下东丄专丑万丕丈丕()
        {
        
        }
        private static 下东丄专丑万丕丈丕()
        {
            string[] val_1 = new string[6];
            val_1[0] = "bytes";
            val_1[1] = "KB";
            val_1[2] = "MB";
            val_1[3] = "GB";
            val_1[4] = "TB";
            val_1[5] = "PB";
            PGCompany.下东丄专丑万丕丈丕.世丐丝业丐丅丄丕世 = val_1;
        }
    
    }

}
