using UnityEngine;

namespace PGCompany.DataObjects
{
    internal static class 丑丈丂丘专丐丂丘丑
    {
        // Methods
        internal static bool 丐丅且丗东丘上与丏(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丕丄丘不专丘七专与 丌东丙丝丂一丅三丞)
        {
            if(丌东丙丝丂一丅三丞 != null)
            {
                    return 丌东丙丝丂一丅三丞.enabled.GetValueOrDefault();
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "effectivePointConfig");
        }
        internal static bool 丗丙丑三丒业与丟丛(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丕丄丘不专丘七专与 丌东丙丝丂一丅三丞, int 丞丁下丈专三丄丅一, out int 丗七丟丈三不丕一三)
        {
            int val_6;
            var val_7;
            var val_9;
            val_6 = 丞丁下丈专三丄丅一;
            if(丌东丙丝丂一丅三丞 != null)
            {
                    丗七丟丈三不丕一三 = 0;
                if(((val_6 & 2147483648) == 0) && (丌东丙丝丂一丅三丞.rewards != null))
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_7 = 0;
            }
            else
            {
                    val_9 = 0;
                return (bool)val_9;
            }
            
                val_9 = 丌东丙丝丂一丅三丞.rewards;
                if(val_9.Count == 0)
            {
                    return (bool)val_9;
            }
            
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_7 = 0;
                int val_4 = 丌东丙丝丂一丅三丞.rewards.Count;
                val_6 = val_6 - ((val_6 / val_4) * val_4);
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_7 = 0;
                丗七丟丈三不丕一三 = 丌东丙丝丂一丅三丞.rewards.Item[val_6];
                val_9 = 1;
                return (bool)val_9;
            }
            
            System.ArgumentNullException val_8 = new System.ArgumentNullException(paramName:  "effectivePointConfig");
        }
    
    }

}
