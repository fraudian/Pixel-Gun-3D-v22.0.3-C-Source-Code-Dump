using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat448
    {
        // Methods
        public static void Copy64(ulong[] x, ulong[] z)
        {
            z[0] = x[0];
            z[1] = x[1];
            z[2] = x[2];
            z[3] = x[3];
            z[4] = x[4];
            z[5] = x[5];
            z[6] = x[6];
        }
        public static ulong[] Create64()
        {
            ulong[] val_1 = new ulong[7];
        }
        public static ulong[] CreateExt64()
        {
            ulong[] val_1 = new ulong[14];
        }
        public static bool Eq64(ulong[] x, ulong[] y)
        {
            var val_1;
            var val_2;
            val_1 = 10;
            label_5:
            if(x[6] != y[6])
            {
                goto label_4;
            }
            
            val_1 = 10 - 1;
            if(6 > 0)
            {
                goto label_5;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_4:
            val_2 = 0;
            return (bool)val_2;
        }
        public static ulong[] FromBigInteger64(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_8 = x;
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 449))
            {
                goto label_4;
            }
            
            System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat448.Create64();
            goto label_5;
            label_11:
            val_3[0] = val_8.LongValue;
            val_8 = val_8.ShiftRight(n:  64);
            label_5:
            if(val_8.SignValue != 0)
            {
                goto label_11;
            }
            
            return val_3;
            label_4:
            System.ArgumentException val_7 = new System.ArgumentException();
        }
        public static bool IsOne64(ulong[] x)
        {
            var val_1;
            if(x[0] != 1)
            {
                goto label_4;
            }
            
            var val_3 = 0;
            label_5:
            var val_1 = val_3 + 1;
            if(null != null)
            {
                goto label_4;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < 6)
            {
                goto label_5;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_4:
            val_1 = 0;
            return (bool)val_1;
        }
        public static bool IsZero64(ulong[] x)
        {
            var val_1;
            var val_1 = 0;
            label_3:
            if(null != null)
            {
                goto label_2;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < 6)
            {
                goto label_3;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_2:
            val_1 = 0;
            return (bool)val_1;
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
        {
            byte[] val_1 = new byte[56];
            var val_3 = 0;
            var val_4 = 48;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  null, bs:  val_1, off:  48);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 8;
            }
            while(val_3 != 7);
            
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1);
        }
        protected Nat448()
        {
        
        }
    
    }

}
