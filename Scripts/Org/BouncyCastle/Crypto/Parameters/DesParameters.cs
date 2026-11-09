using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DesParameters : KeyParameter
    {
        // Fields
        public const int DesKeyLength = 8;
        private const int N_DES_WEAK_KEYS = 16;
        private static readonly byte[] DES_weak_keys;
        
        // Methods
        public DesParameters(byte[] key)
        {
            if((Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key:  key)) != true)
            {
                    return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "attempt to create weak DES key");
        }
        public DesParameters(byte[] key, int keyOff, int keyLen)
        {
            if((Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key:  key, offset:  keyOff)) != true)
            {
                    return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "attempt to create weak DES key");
        }
        public static bool IsWeakKey(byte[] key, int offset)
        {
            var val_3;
            var val_4;
            var val_5;
            int val_4 = key.Length;
            val_4 = val_4 - offset;
            if(val_4 < 8)
            {
                goto label_2;
            }
            
            val_3 = 0;
            var val_8 = 0;
            label_11:
            var val_7 = 0;
            label_9:
            val_4 = null;
            val_4 = null;
            int val_6 = Org.BouncyCastle.Crypto.Parameters.DesParameters.DES_weak_keys.Length;
            var val_2 = val_3 + val_7;
            val_6 = val_6 + val_7;
            if((key[(long)offset + val_7]) != ((Org.BouncyCastle.Crypto.Parameters.DesParameters.DES_weak_keys.Length + 0) + 32))
            {
                goto label_8;
            }
            
            val_7 = val_7 + 1;
            if(val_7 <= 6)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            val_8 = val_8 + 1;
            val_3 = val_3 + 8;
            if(val_8 <= 14)
            {
                goto label_11;
            }
            
            val_5 = 0;
            return (bool)val_5;
            label_10:
            val_5 = 1;
            return (bool)val_5;
            label_2:
            System.ArgumentException val_3 = new System.ArgumentException(message:  "key material too short.");
        }
        public static bool IsWeakKey(byte[] key)
        {
            return Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key:  key, offset:  0);
        }
        public static byte SetOddParity(byte b)
        {
            b = 0 ^ (b & 255);
            return (byte)b;
        }
        public static void SetOddParity(byte[] bytes)
        {
            goto label_1;
            label_7:
            byte val_1 = bytes[0];
            var val_2 = 0;
            val_2 = val_2 ^ 1;
            val_1 = 0 ^ val_1;
            0 = 1;
            mem2[0] = val_1;
            label_1:
            if(0 < bytes.Length)
            {
                goto label_7;
            }
        
        }
        public static void SetOddParity(byte[] bytes, int off, int len)
        {
            var val_1;
            var val_2;
            val_1 = len;
            val_2 = off;
            if(val_1 < 1)
            {
                    return;
            }
            
            do
            {
                byte val_1 = bytes[(long)val_2];
                var val_2 = 0;
                val_2 = val_2 ^ 1;
                val_1 = 0 ^ val_1;
                val_1 = val_1 - 1;
                val_2 = val_2 + 1;
                mem2[0] = val_1;
            }
            while(val_1 != 0);
        
        }
        private static DesParameters()
        {
            Org.BouncyCastle.Crypto.Parameters.DesParameters.DES_weak_keys = new byte[128] {1, 1, 1, 1, 1, 1, 1, 1, 31, 31, 31, 31, 14, 14, 14, 14, 224, 224, 224, 224, 241, 241, 241, 241, 254, 254, 254, 254, 254, 254, 254, 254, 1, 254, 1, 254, 1, 254, 1, 254, 31, 224, 31, 224, 14, 241, 14, 241, 1, 224, 1, 224, 1, 241, 1, 241, 31, 254, 31, 254, 14, 254, 14, 254, 1, 31, 1, 31, 1, 14, 1, 14, 224, 254, 224, 254, 241, 254, 241, 254, 254, 1, 254, 1, 254, 1, 254, 1, 224, 31, 224, 31, 241, 14, 241, 14, 224, 1, 224, 1, 241, 1, 241, 1, 254, 31, 254, 31, 254, 14, 254, 14, 31, 1, 31, 1, 14, 1, 14, 1, 254, 224, 254, 224, 254, 241, 254, 241};
        }
    
    }

}
