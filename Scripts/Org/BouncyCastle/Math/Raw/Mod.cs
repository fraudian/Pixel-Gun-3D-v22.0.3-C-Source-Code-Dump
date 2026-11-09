using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Mod
    {
        // Fields
        private static readonly Org.BouncyCastle.Security.SecureRandom RandomSource;
        
        // Methods
        public static void Invert(uint[] p, uint[] x, uint[] z)
        {
            System.UInt32[] val_21;
            System.UInt32[] val_22;
            int val_23;
            System.UInt32[] val_24;
            System.UInt32[] val_25;
            var val_26;
            val_21 = x;
            if((Org.BouncyCastle.Math.Raw.Nat.IsZero(len:  p.Length, x:  val_21)) == true)
            {
                goto label_2;
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IsOne(len:  p.Length, x:  val_21)) != false)
            {
                    System.Array.Copy(sourceArray:  val_21, sourceIndex:  0, destinationArray:  z, destinationIndex:  0, length:  p.Length);
                return;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat.Copy(len:  p.Length, x:  val_21);
            val_21 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  p.Length);
            val_21[0] = 1;
            int val_5 = 0;
            if((val_3[0] & 1) == 0)
            {
                    Org.BouncyCastle.Math.Raw.Mod.InversionStep(p:  p, u:  val_3, uLen:  p.Length, x:  val_21, xc: ref  val_5);
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.IsOne(len:  p.Length, x:  val_3)) == false)
            {
                goto label_12;
            }
            
            val_22 = p;
            val_23 = val_5;
            val_24 = val_21;
            val_25 = z;
            goto label_15;
            label_12:
            System.UInt32[] val_7 = Org.BouncyCastle.Math.Raw.Nat.Copy(len:  p.Length, x:  p);
            System.UInt32[] val_8 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  p.Length);
            label_30:
            int val_9 = p.Length - 1;
            label_28:
            if(null == null)
            {
                    if((val_7[val_9 << 2][32]) == 0)
            {
                goto label_30;
            }
            
            }
            
            if((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  p.Length, x:  val_3, y:  val_7)) == false)
            {
                goto label_21;
            }
            
            int val_11 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  p.Length, x:  val_7, z:  val_3);
            val_26 = val_5;
            int val_22 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  p.Length, x:  val_8, z:  val_21);
            val_22 = val_22 + val_26;
            val_22 = val_22 - 0;
            int val_13 = val_22;
            Org.BouncyCastle.Math.Raw.Mod.InversionStep(p:  p, u:  val_3, uLen:  p.Length, x:  val_21, xc: ref  val_13);
            if((Org.BouncyCastle.Math.Raw.Nat.IsOne(len:  p.Length, x:  val_3)) == false)
            {
                goto label_28;
            }
            
            goto label_25;
            label_21:
            int val_15 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  p.Length, x:  val_3, z:  val_7);
            val_26 = 0;
            int val_23 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  p.Length, x:  val_21, z:  val_8);
            val_23 = val_23 + val_26;
            val_23 = val_23 - val_13;
            int val_17 = val_23;
            Org.BouncyCastle.Math.Raw.Mod.InversionStep(p:  p, u:  val_7, uLen:  p.Length, x:  val_8, xc: ref  val_17);
            if((Org.BouncyCastle.Math.Raw.Nat.IsOne(len:  p.Length, x:  val_7)) == false)
            {
                goto label_28;
            }
            
            val_21 = val_17;
            val_22 = p;
            val_23 = val_21;
            val_24 = val_8;
            goto label_33;
            label_25:
            val_22 = p;
            val_23 = val_13;
            val_24 = val_21;
            label_33:
            val_25 = z;
            label_15:
            Org.BouncyCastle.Math.Raw.Mod.InversionResult(p:  val_22, ac:  val_23, a:  val_24, z:  val_25);
            return;
            label_2:
            System.ArgumentException val_19 = new System.ArgumentException(message:  "cannot be 0", paramName:  "x");
        }
        public static uint[] Random(uint[] p)
        {
            var val_7;
            System.UInt32[] val_1 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  p.Length);
            int val_2 = p.Length - 1;
            uint val_7 = p[((long)(int)((p.Length - 1))) << 2];
            val_7 = val_7 | (val_7 >> 1);
            val_7 = val_7 | (val_7 >> 2);
            val_7 = val_7 | (val_7 >> 4);
            val_7 = val_7 | (val_7 >> 8);
            do
            {
                val_7 = null;
                val_7 = null;
                Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  new byte[0], off:  0, ns:  val_1);
                mem2[0] = 1152921505741541488 & (val_7 | (val_7 >> 16));
            }
            while((Org.BouncyCastle.Math.Raw.Nat.Gte(len:  p.Length, x:  val_1, y:  p)) == true);
            
            return val_1;
        }
        public static void Add(uint[] p, uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat.Add(len:  p.Length, x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            int val_2 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  p.Length, x:  p, z:  z);
        }
        public static void Subtract(uint[] p, uint[] x, uint[] y, uint[] z)
        {
            if((Org.BouncyCastle.Math.Raw.Nat.Sub(len:  p.Length, x:  x, y:  y, z:  z)) == 0)
            {
                    return;
            }
            
            uint val_2 = Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  p.Length, x:  p, z:  z);
        }
        private static void InversionResult(uint[] p, int ac, uint[] a, uint[] z)
        {
            if(p == null)
            {
                goto label_0;
            }
            
            if((ac & 2147483648) != 0)
            {
                goto label_1;
            }
            
            label_2:
            System.Array.Copy(sourceArray:  a, sourceIndex:  0, destinationArray:  z, destinationIndex:  0, length:  p.Length);
            return;
            label_0:
            if((ac & 2147483648) == 0)
            {
                goto label_2;
            }
            
            label_1:
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat.Add(len:  p.Length, x:  a, y:  p, z:  z);
        }
        private static void InversionStep(uint[] p, uint[] u, int uLen, uint[] x, ref int xc)
        {
            System.UInt32[] val_6;
            var val_7;
            uint val_8;
            int val_9;
            val_6 = u;
            val_7 = 0;
            goto label_2;
            label_5:
            uint val_1 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownWord(len:  uLen, z:  val_6, c:  0);
            val_7 = 32;
            label_2:
            val_8 = val_6[0];
            if(val_8 == 0)
            {
                goto label_5;
            }
            
            if(u.Length == 0)
            {
                    val_8 = val_6[0];
            }
            
            if((val_8 & 1) == 0)
            {
                    int val_6 = 0;
                do
            {
                val_8 = val_8 >> 1;
                val_6 = val_6 + 1;
            }
            while((val_8 & 1) == 0);
            
                if(val_6 >= 1)
            {
                    uint val_2 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBits(len:  uLen, z:  val_6, bits:  val_6, c:  0);
                val_7 = val_7 + val_6;
            }
            
            }
            
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                val_6 = xc;
                if((x[0] & 1) != 0)
            {
                    if((val_6 & 2147483648) == 0)
            {
                    val_9 = p.Length;
                int val_3 = Org.BouncyCastle.Math.Raw.Nat.SubFrom(len:  val_9, x:  p, z:  x);
            }
            else
            {
                    val_9 = p.Length;
            }
            
                val_6 = (Org.BouncyCastle.Math.Raw.Nat.AddTo(len:  val_9, x:  p, z:  x)) + val_6;
                xc = val_6;
            }
            
                uint val_5 = Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(len:  p.Length, z:  x, c:  val_6);
                val_7 = val_7 - 1;
            }
            while(val_7 != 0);
        
        }
        private static int GetTrailingZeroes(uint x)
        {
            var val_1 = 0;
            if((x & 1) != 0)
            {
                    return (int)val_1;
            }
            
            do
            {
                x = x >> 1;
                val_1 = val_1 + 1;
            }
            while((x & 1) == 0);
            
            return (int)val_1;
        }
        protected Mod()
        {
        
        }
        private static Mod()
        {
            Org.BouncyCastle.Math.Raw.Mod.RandomSource = new Org.BouncyCastle.Security.SecureRandom();
        }
    
    }

}
