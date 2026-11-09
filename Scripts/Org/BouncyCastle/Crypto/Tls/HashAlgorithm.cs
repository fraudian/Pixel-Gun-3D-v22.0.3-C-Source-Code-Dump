using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class HashAlgorithm
    {
        // Fields
        public const byte none = 0;
        public const byte md5 = 1;
        public const byte sha1 = 2;
        public const byte sha224 = 3;
        public const byte sha256 = 4;
        public const byte sha384 = 5;
        public const byte sha512 = 6;
        
        // Methods
        public static string GetName(byte hashAlgorithm)
        {
            var val_2;
            if((hashAlgorithm & 255) <= 6)
            {
                    val_2 = mem[130713056 + ((int)(sbyte)((hashAlgorithm) & 0xFF)) << 3];
                val_2 = 130713056 + ((int)(sbyte)((hashAlgorithm) & 0xFF)) << 3;
                return (string)val_2;
            }
            
            val_2 = "UNKNOWN";
            return (string)val_2;
        }
        public static string GetText(byte hashAlgorithm)
        {
            object[] val_1 = new object[4];
            string val_2 = Org.BouncyCastle.Crypto.Tls.HashAlgorithm.GetName(hashAlgorithm:  hashAlgorithm);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = "(";
            val_1[2] = hashAlgorithm;
            val_1[3] = ")";
            return (string)+val_1;
        }
        public static bool IsPrivate(byte hashAlgorithm)
        {
            return (bool)((hashAlgorithm & 255) > 223) ? 1 : 0;
        }
        protected HashAlgorithm()
        {
        
        }
    
    }

}
