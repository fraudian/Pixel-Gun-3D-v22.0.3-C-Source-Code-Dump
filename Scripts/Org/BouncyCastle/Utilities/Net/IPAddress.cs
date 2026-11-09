using UnityEngine;

namespace Org.BouncyCastle.Utilities.Net
{
    public class IPAddress
    {
        // Methods
        public static bool IsValid(string address)
        {
            if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address:  address)) == false)
            {
                    return Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(address:  address);
            }
            
            return true;
        }
        public static bool IsValidWithNetMask(string address)
        {
            if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4WithNetmask(address:  address)) == false)
            {
                    return Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6WithNetmask(address:  address);
            }
            
            return true;
        }
        public static bool IsValidIPv4(string address)
        {
            return (bool)Org.BouncyCastle.Utilities.Net.IPAddress.unsafeIsValidIPv4(address:  address);
        }
        private static bool unsafeIsValidIPv4(string address)
        {
            string val_10;
            var val_11;
            int val_12;
            var val_13;
            val_10 = address;
            val_11 = val_10;
            if(val_11.Length == 0)
            {
                    return (bool)(val_13 == 0) ? 1 : 0;
            }
            
            val_10 = val_10 + ".";
            val_12 = 0;
            val_13 = 4;
            goto label_3;
            label_10:
            if((System.Int32.Parse(s:  val_10.Substring(startIndex:  0, length:  W22))) > 255)
            {
                goto label_5;
            }
            
            val_12 = W21 + 1;
            val_13 = 3;
            label_3:
            int val_5 = val_10.Length;
            if(val_12 >= val_5)
            {
                    return (bool)(val_13 == 0) ? 1 : 0;
            }
            
            int val_7 = (val_10.IndexOf(value:  '.', startIndex:  val_12)) - val_12;
            if(val_12 <= val_5)
            {
                    return (bool)(val_13 == 0) ? 1 : 0;
            }
            
            if(val_13 != 0)
            {
                goto label_10;
            }
            
            label_5:
            val_11 = 0;
            return (bool)(val_13 == 0) ? 1 : 0;
        }
        public static bool IsValidIPv4WithNetmask(string address)
        {
            int val_8;
            var val_9;
            if(address != null)
            {
                    val_8 = address.IndexOf(value:  '/');
            }
            else
            {
                    val_8 = 0.IndexOf(value:  '/');
            }
            
            string val_4 = address.Substring(startIndex:  val_8 + 1);
            if(val_8 >= 1)
            {
                    val_9 = 0;
                if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address:  address.Substring(startIndex:  0, length:  val_8))) == false)
            {
                    return (bool)val_9;
            }
            
                if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address:  val_4)) == false)
            {
                    return Org.BouncyCastle.Utilities.Net.IPAddress.IsMaskValue(component:  val_4, size:  32);
            }
            
                val_9 = 1;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public static bool IsValidIPv6WithNetmask(string address)
        {
            int val_8;
            var val_9;
            if(address != null)
            {
                    val_8 = address.IndexOf(value:  '/');
            }
            else
            {
                    val_8 = 0.IndexOf(value:  '/');
            }
            
            string val_4 = address.Substring(startIndex:  val_8 + 1);
            if(val_8 >= 1)
            {
                    val_9 = 0;
                if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(address:  address.Substring(startIndex:  0, length:  val_8))) == false)
            {
                    return (bool)val_9;
            }
            
                if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(address:  val_4)) == false)
            {
                    return Org.BouncyCastle.Utilities.Net.IPAddress.IsMaskValue(component:  val_4, size:  128);
            }
            
                val_9 = 1;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        private static bool IsMaskValue(string component, int size)
        {
            int val_1 = System.Int32.Parse(s:  component);
            val_1 = ((val_1 <= size) ? 1 : 0) & ((val_1 >= 0) ? 1 : 0);
            return (bool)val_1;
        }
        public static bool IsValidIPv6(string address)
        {
            return (bool)Org.BouncyCastle.Utilities.Net.IPAddress.unsafeIsValidIPv6(address:  address);
        }
        private static bool unsafeIsValidIPv6(string address)
        {
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            string val_24;
            var val_25;
            val_19 = address;
            if(val_19.Length == 0)
            {
                goto label_21;
            }
            
            val_19 = val_19 + ":"(":");
            val_20 = 0;
            val_21 = 0;
            val_22 = 0;
            goto label_3;
            label_23:
            int val_3 = val_19.IndexOf(value:  ':', startIndex:  0);
            if(val_3 < val_20)
            {
                goto label_5;
            }
            
            if(val_22 == 8)
            {
                goto label_21;
            }
            
            int val_4 = val_3 - val_20;
            if(val_22 != 8)
            {
                goto label_7;
            }
            
            if(val_20 != 1)
            {
                goto label_8;
            }
            
            val_23 = 0;
            goto label_9;
            label_7:
            if(val_19 == null)
            {
                goto label_10;
            }
            
            val_24 = val_19.Substring(startIndex:  0, length:  val_4);
            goto label_11;
            label_8:
            var val_8 = (val_20 != (val_19.Length - 1)) ? 1 : 0;
            label_9:
            val_8 = val_8 & val_21;
            if(val_8 != 0)
            {
                goto label_21;
            }
            
            val_21 = 1;
            goto label_19;
            label_10:
            val_24 = 0.Substring(startIndex:  0, length:  val_4);
            label_11:
            if((val_3 != (val_19.Length - 1)) || ((val_24.IndexOf(value:  '.')) < 1))
            {
                goto label_17;
            }
            
            if((Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address:  val_24)) == false)
            {
                goto label_21;
            }
            
            goto label_19;
            label_17:
            if((System.Int32.Parse(s:  val_19.Substring(startIndex:  0, length:  val_4), style:  512)) >= 65536)
            {
                goto label_21;
            }
            
            label_19:
            val_20 = val_3 + 1;
            val_22 = val_22 + 1;
            label_3:
            if(val_20 < val_19.Length)
            {
                goto label_23;
            }
            
            label_5:
            val_25 = val_21 | ((val_22 == 8) ? 1 : 0);
            return (bool)val_25 & 1;
            label_21:
            val_25 = 0;
            return (bool)val_25 & 1;
        }
        public IPAddress()
        {
        
        }
    
    }

}
