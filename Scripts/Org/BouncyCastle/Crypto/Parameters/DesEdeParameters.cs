using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DesEdeParameters : DesParameters
    {
        // Fields
        public const int DesEdeKeyLength = 24;
        
        // Methods
        private static byte[] FixKey(byte[] key, int keyOff, int keyLen)
        {
            var val_6;
            var val_7;
            System.Array val_8;
            int val_9;
            System.Array val_10;
            var val_11;
            var val_12;
            byte[] val_1 = new byte[24];
            if(keyLen == 24)
            {
                goto label_1;
            }
            
            if(keyLen != 16)
            {
                goto label_2;
            }
            
            System.Array.Copy(sourceArray:  key, sourceIndex:  keyOff, destinationArray:  val_1, destinationIndex:  0, length:  16);
            val_6 = 16;
            val_7 = 8;
            val_8 = key;
            val_9 = keyOff;
            val_10 = val_1;
            goto label_3;
            label_1:
            val_7 = 24;
            val_8 = key;
            val_9 = keyOff;
            val_10 = val_1;
            val_6 = 0;
            label_3:
            System.Array.Copy(sourceArray:  val_8, sourceIndex:  val_9, destinationArray:  val_1, destinationIndex:  0, length:  24);
            if((Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(key:  val_1)) == true)
            {
                goto label_4;
            }
            
            return (System.Byte[])val_1;
            label_2:
            val_11 = 1152921551335235856;
            val_12 = new System.ArgumentException(message:  "Bad length for DESede key: "("Bad length for DESede key: ") + keyLen, paramName:  "keyLen");
            goto label_5;
            label_4:
            val_11 = 1152921551335235856;
            val_12 = new System.ArgumentException(message:  "attempt to create weak DESede key");
            label_5:
        }
        public DesEdeParameters(byte[] key)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.FixKey(key:  key, keyOff:  0, keyLen:  key.Length);
        }
        public DesEdeParameters(byte[] key, int keyOff, int keyLen)
        {
            System.Byte[] val_1 = Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.FixKey(key:  key, keyOff:  keyOff, keyLen:  keyLen);
        }
        public static bool IsWeakKey(byte[] key, int offset, int length)
        {
            var val_2;
            int val_2 = offset;
            if(val_2 >= length)
            {
                goto label_1;
            }
            
            label_5:
            if((Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key:  key, offset:  val_2)) == true)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 8;
            if(val_2 < length)
            {
                goto label_5;
            }
            
            label_1:
            val_2 = 0;
            return (bool)val_2;
            label_4:
            val_2 = 1;
            return (bool)val_2;
        }
        public static bool IsWeakKey(byte[] key, int offset)
        {
            return Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(key:  key, offset:  offset, length:  key.Length - offset);
        }
        public static bool IsWeakKey(byte[] key)
        {
            if(key != null)
            {
                    return Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(key:  key, offset:  0, length:  key.Length);
            }
            
            return Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsWeakKey(key:  key, offset:  0, length:  key.Length);
        }
        public static bool IsRealEdeKey(byte[] key, int offset)
        {
            if(key.Length != 16)
            {
                    return Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsReal3Key(key:  key, offset:  offset);
            }
            
            return Org.BouncyCastle.Crypto.Parameters.DesEdeParameters.IsReal2Key(key:  key, offset:  offset);
        }
        public static bool IsReal2Key(byte[] key, int offset)
        {
            int val_5;
            var val_8 = 0;
            do
            {
                val_5 = key.Length;
                if(offset >= val_5)
            {
                    val_5 = key.Length;
            }
            
                int val_2 = offset + 8;
                var val_7 = (long)val_2;
                val_2 = val_7 - 8;
                val_7 = val_7 - 7;
                val_8 = val_8 | ((key[(long)offset] != key[val_7]) ? 1 : 0);
            }
            while(val_2 != (offset + 7));
            
            return (bool)val_8 & 1;
        }
        public static bool IsReal3Key(byte[] key, int offset)
        {
            int val_12;
            var val_16 = 0;
            var val_17 = 0;
            var val_18 = 0;
            do
            {
                val_12 = key.Length;
                if(offset >= val_12)
            {
                    val_12 = key.Length;
            }
            
                int val_2 = offset + 8;
                var val_14 = (long)val_2;
                if(val_2 >= val_12)
            {
                    val_12 = key.Length;
            }
            
                val_14 = val_14 - 8;
                if(val_14 >= val_12)
            {
                    val_12 = key.Length;
            }
            
                val_14 = val_14 + 16;
                if(val_14 >= val_12)
            {
                    val_12 = key.Length;
            }
            
                val_14 = val_14 - 8;
                if(val_14 >= val_12)
            {
                    val_12 = key.Length;
            }
            
                val_16 = val_16 | ((key[(long)offset] != key[val_14]) ? 1 : 0);
                var val_6 = val_14 + 8;
                val_17 = val_17 | (((key[(long)(int)(offset)] + 32) != (key[(long)offset + 16])) ? 1 : 0);
                var val_8 = val_6 - 15;
                val_18 = val_18 | (((key[(long)(int)((offset + 8))] + 32) != (key[(long)(int)((offset + 16))] + 32)) ? 1 : 0);
            }
            while((val_6 - 16) != (offset + 7));
            
            var val_10 = val_17 & val_16;
            val_10 = val_18 & val_10;
            return (bool)val_10 & 1;
        }
    
    }

}
