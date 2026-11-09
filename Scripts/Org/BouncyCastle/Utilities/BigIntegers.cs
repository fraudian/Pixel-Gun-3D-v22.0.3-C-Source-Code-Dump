using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    public abstract class BigIntegers
    {
        // Fields
        private const int MaxIterations = 1000;
        
        // Methods
        public static byte[] AsUnsignedByteArray(Org.BouncyCastle.Math.BigInteger n)
        {
            if(n != null)
            {
                    return n.ToByteArrayUnsigned();
            }
            
            return n.ToByteArrayUnsigned();
        }
        public static byte[] AsUnsignedByteArray(int length, Org.BouncyCastle.Math.BigInteger n)
        {
            System.Byte[] val_5 = n.ToByteArrayUnsigned();
            if(val_1.Length <= length)
            {
                    if(val_1.Length == length)
            {
                    return (System.Byte[])val_5;
            }
            
                byte[] val_2 = new byte[0];
                System.Array.Copy(sourceArray:  val_5 = n.ToByteArrayUnsigned(), sourceIndex:  0, destinationArray:  val_2, destinationIndex:  val_2.Length - val_1.Length, length:  val_1.Length);
                val_5 = val_2;
                return (System.Byte[])val_5;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "standard length exceeded", paramName:  "n");
        }
        public static Org.BouncyCastle.Math.BigInteger CreateRandomInRange(Org.BouncyCastle.Math.BigInteger min, Org.BouncyCastle.Math.BigInteger max, Org.BouncyCastle.Security.SecureRandom random)
        {
            Org.BouncyCastle.Math.BigInteger val_15;
            var val_16;
            var val_17;
            val_15 = max;
            int val_1 = min.CompareTo(value:  val_15);
            if((val_1 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            if(val_1 != 0)
            {
                goto label_3;
            }
            
            return (Org.BouncyCastle.Math.BigInteger)min;
            label_2:
            int val_3 = val_15.BitLength;
            if(min.BitLength > (((val_3 < 0) ? (val_3 + 1) : (val_3)) >> 1))
            {
                    val_16 = null;
                val_16 = null;
                Org.BouncyCastle.Math.BigInteger val_5 = val_15.Subtract(n:  min);
                if(Org.BouncyCastle.Math.BigInteger.Zero != null)
            {
                    return val_13.Add(value:  min);
            }
            
                return val_13.Add(value:  min);
            }
            
            val_17 = 0;
            goto label_13;
            label_19:
            Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  val_15.BitLength, random:  random);
            if(((val_7.CompareTo(value:  min)) & 2147483648) == 0)
            {
                    if((val_7.CompareTo(value:  val_15)) < 1)
            {
                    return (Org.BouncyCastle.Math.BigInteger)min;
            }
            
            }
            
            val_17 = 1;
            label_13:
            if(val_17 < 1000)
            {
                goto label_19;
            }
            
            Org.BouncyCastle.Math.BigInteger val_13 = null;
            val_15 = val_13;
            val_13 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  (val_15.Subtract(n:  min).BitLength) - 1, random:  random);
            return val_13.Add(value:  min);
            label_3:
            System.ArgumentException val_14 = new System.ArgumentException(message:  "\'min\' may not be greater than \'max\'");
        }
        protected BigIntegers()
        {
        
        }
    
    }

}
