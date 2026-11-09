using UnityEngine;

namespace Org.BouncyCastle.Utilities.Encoders
{
    public sealed class Base64
    {
        // Methods
        private Base64()
        {
        
        }
        public static string ToBase64String(byte[] data)
        {
            return System.Convert.ToBase64String(inArray:  data, offset:  0, length:  data.Length);
        }
        public static string ToBase64String(byte[] data, int off, int length)
        {
            return System.Convert.ToBase64String(inArray:  data, offset:  off, length:  length);
        }
        public static byte[] Encode(byte[] data)
        {
            if(data != null)
            {
                    return Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data:  data, off:  0, length:  data.Length);
            }
            
            return Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data:  data, off:  0, length:  data.Length);
        }
        public static byte[] Encode(byte[] data, int off, int length)
        {
            return Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  System.Convert.ToBase64String(inArray:  data, offset:  off, length:  length));
        }
        public static int Encode(byte[] data, System.IO.Stream outStream)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data:  data);
            if(val_1 == null)
            {
                goto label_0;
            }
            
            label_4:
            if(val_1 != null)
            {
                    return (int)val_1.Length;
            }
            
            return (int)val_1.Length;
            label_0:
            if(outStream != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        public static int Encode(byte[] data, int off, int length, System.IO.Stream outStream)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Utilities.Encoders.Base64.Encode(data:  data, off:  off, length:  length);
            if(val_1 == null)
            {
                goto label_0;
            }
            
            label_4:
            if(val_1 != null)
            {
                    return (int)val_1.Length;
            }
            
            return (int)val_1.Length;
            label_0:
            if(outStream != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        public static byte[] Decode(byte[] data)
        {
            return System.Convert.FromBase64String(s:  Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  data));
        }
        public static byte[] Decode(string data)
        {
            return System.Convert.FromBase64String(s:  data);
        }
        public static int Decode(string data, System.IO.Stream outStream)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Utilities.Encoders.Base64.Decode(data:  data);
            if(val_1 == null)
            {
                goto label_0;
            }
            
            label_4:
            if(val_1 != null)
            {
                    return (int)val_1.Length;
            }
            
            return (int)val_1.Length;
            label_0:
            if(outStream != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
    
    }

}
