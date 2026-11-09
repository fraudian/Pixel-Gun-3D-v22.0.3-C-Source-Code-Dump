using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    internal abstract class Enums
    {
        // Methods
        internal static System.Enum GetEnumValue(System.Type enumType, string s)
        {
            var val_11;
            if((s.Length >= 1) && ((System.Char.IsLetter(c:  s.Chars[0])) != false))
            {
                    if(((s.IndexOf(value:  ',')) & 2147483648) != 0)
            {
                    if((System.Enum.Parse(enumType:  enumType, value:  s.Replace(oldChar:  '-', newChar:  '_').Replace(oldChar:  '/', newChar:  '_'), ignoreCase:  false)) == null)
            {
                    return (System.Enum)val_11;
            }
            
                val_11 = 0;
                return (System.Enum)val_11;
            }
            
            }
            
            System.ArgumentException val_10 = new System.ArgumentException();
        }
        internal static System.Array GetEnumValues(System.Type enumType)
        {
            return System.Enum.GetValues(enumType:  enumType);
        }
        internal static System.Enum GetArbitraryValue(System.Type enumType)
        {
            var val_9;
            System.Array val_1 = Org.BouncyCastle.Utilities.Enums.GetEnumValues(enumType:  enumType);
            long val_9 = Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs();
            int val_3 = val_1.Length;
            long val_4 = val_9 & 2147483647;
            val_9 = val_4 - ((val_4 / val_3) * val_3);
            if((val_1.GetValue(index:  val_9)) == null)
            {
                    return (System.Enum)val_9;
            }
            
            val_9 = 0;
            return (System.Enum)val_9;
        }
        internal static bool IsEnumType(System.Type t)
        {
            if(t == null)
            {
                
            }
        
        }
        protected Enums()
        {
        
        }
    
    }

}
