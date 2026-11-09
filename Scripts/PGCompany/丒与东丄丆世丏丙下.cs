using UnityEngine;

namespace PGCompany
{
    internal static class 丒与东丄丆世丏丙下
    {
        // Methods
        internal static string 万丂丙丄三世专世丞(byte[] 三丒丂世丕丟东丆丏, int 丛上丙丄丄七丈且丅, int 丏上万丅丏一不不丕)
        {
            var val_9;
            string val_11;
            var val_12;
            val_9 = 丏上万丅丏一不不丕;
            if(三丒丂世丕丟东丆丏 == null)
            {
                goto label_1;
            }
            
            if(三丒丂世丕丟东丆丏.Length <= 丛上丙丄丄七丈且丅)
            {
                goto label_2;
            }
            
            if((val_9 & 2147483648) == 0)
            {
                    if((val_9 + 丛上丙丄丄七丈且丅) < 三丒丂世丕丟东丆丏.Length)
            {
                    System.Text.StringBuilder val_3 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  val_9 << 1);
                if(val_9 == 0)
            {
                    return (string)PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_3);
            }
            
                do
            {
                System.Text.StringBuilder val_4 = val_3.AppendFormat(format:  "{0:x2}", arg0:  三丒丂世丕丟东丆丏[(long)丛上丙丄丄七丈且丅]);
                val_9 = val_9 - 1;
                var val_5 = (long)丛上丙丄丄七丈且丅 + 1;
            }
            while(val_9 != 0);
            
                return (string)PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_3);
            }
            
            }
            
            val_11 = "length";
            goto label_9;
            label_1:
            System.ArgumentNullException val_7 = null;
            val_12 = val_7;
            val_7 = new System.ArgumentNullException(paramName:  "array");
            goto label_10;
            label_2:
            System.ArgumentOutOfRangeException val_8 = null;
            val_11 = "offset";
            label_9:
            val_12 = val_8;
            val_8 = new System.ArgumentOutOfRangeException(paramName:  val_11);
            label_10:
        }
    
    }

}
