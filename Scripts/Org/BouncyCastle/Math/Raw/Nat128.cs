using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat128
    {
        // Fields
        private const ulong M = 4294967295;
        
        // Methods
        public static uint Add(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_11 = y;
            uint val_3 = x[0];
            val_3 = val_11[0] + val_3;
            z[0] = val_3;
            val_3 = val_3 >> 32;
            uint val_1 = val_3 + x[0];
            val_3 = val_1 + val_11[0];
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_11[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_11 = val_1 + val_11[1];
            z[1] = val_11;
            return (uint)val_11 >> 32;
        }
        public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            uint val_3 = x[0];
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            uint val_1 = y[0] + val_3;
            val_3 = val_1 + z[0];
            z[0] = val_3;
            val_4 = z.Length;
            val_3 = val_3 >> 32;
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            val_1 = val_3 + x[0];
            val_1 = val_1 + y[0];
            val_3 = val_1 + z[0];
            z[0] = val_3;
            val_5 = z.Length;
            val_3 = val_3 >> 32;
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            val_1 = val_3 + x[1];
            val_1 = val_1 + y[1];
            val_3 = val_1 + z[1];
            z[1] = val_3;
            val_6 = z.Length;
            uint val_13 = y[1];
            val_3 = val_3 >> 32;
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            val_1 = val_3 + x[1];
            val_1 = val_1 + val_13;
            val_13 = val_1 + z[1];
            z[1] = val_13;
            return (uint)val_13 >> 32;
        }
        public static uint AddTo(uint[] x, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            uint val_3 = x[0];
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            val_3 = z[0] + val_3;
            z[0] = val_3;
            val_4 = z.Length;
            val_3 = val_3 >> 32;
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            uint val_1 = val_3 + x[0];
            val_3 = val_1 + z[0];
            z[0] = val_3;
            val_5 = z.Length;
            val_3 = val_3 >> 32;
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            val_1 = val_3 + x[1];
            val_3 = val_1 + z[1];
            z[1] = val_3;
            val_6 = z.Length;
            uint val_9 = x[1];
            val_3 = val_3 >> 32;
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            val_1 = val_3 + val_9;
            val_9 = val_1 + z[1];
            z[1] = val_9;
            return (uint)val_9 >> 32;
        }
        public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
        {
            int val_11;
            int val_12;
            int val_13;
            int val_14;
            uint val_13 = cIn;
            val_11 = z.Length;
            if(val_11 <= zOff)
            {
                    val_11 = z.Length;
            }
            
            uint val_1 = (x[((long)(int)(xOff)) << 2]) + val_13;
            val_13 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_13;
            int val_2 = xOff + 1;
            val_12 = z.Length;
            val_13 = val_13 >> 32;
            if((zOff + 1) >= val_12)
            {
                    val_12 = z.Length;
            }
            
            val_1 = val_13 + (x[((long)(int)((xOff + 1))) << 2]);
            val_13 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_13;
            int val_4 = xOff + 2;
            val_13 = z.Length;
            val_13 = val_13 >> 32;
            if((zOff + 2) >= val_13)
            {
                    val_13 = z.Length;
            }
            
            val_1 = val_13 + (x[((long)(int)((xOff + 2))) << 2]);
            val_13 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_13;
            int val_6 = xOff + 3;
            val_14 = z.Length;
            if((zOff + 3) >= val_14)
            {
                    val_14 = z.Length;
            }
            
            val_1 = (val_13 >> 32) + (x[((long)(int)((xOff + 3))) << 2]);
            uint val_9 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_9;
            return (uint)val_9 >> 32;
        }
        public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
        {
            System.UInt32[] val_18 = u;
            uint val_10 = val_18[((long)(int)(uOff)) << 2];
            val_10 = (v[((long)(int)(vOff)) << 2]) + val_10;
            mem2[0] = val_10;
            mem2[0] = val_10;
            int val_1 = uOff + 1;
            int val_2 = vOff + 1;
            val_10 = val_10 >> 32;
            uint val_3 = val_10 + (val_18[((long)(int)((uOff + 1))) << 2]);
            val_10 = val_3 + (v[((long)(int)((vOff + 1))) << 2]);
            mem2[0] = val_10;
            mem2[0] = val_10;
            int val_4 = uOff + 2;
            int val_5 = vOff + 2;
            val_10 = val_10 >> 32;
            val_3 = val_10 + (val_18[((long)(int)((uOff + 2))) << 2]);
            val_10 = val_3 + (v[((long)(int)((vOff + 2))) << 2]);
            mem2[0] = val_10;
            mem2[0] = val_10;
            int val_6 = uOff + 3;
            int val_7 = vOff + 3;
            val_3 = (val_10 >> 32) + (val_18[((long)(int)((uOff + 3))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 3))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            return (uint)val_18 >> 32;
        }
        public static void Copy(uint[] x, uint[] z)
        {
            z[0] = x[0];
            z[0] = x[0];
            z[1] = x[1];
            z[1] = x[1];
        }
        public static void Copy64(ulong[] x, ulong[] z)
        {
            z[0] = x[0];
            z[1] = x[1];
        }
        public static uint[] Create()
        {
            uint[] val_1 = new uint[4];
        }
        public static ulong[] Create64()
        {
            ulong[] val_1 = new ulong[2];
        }
        public static uint[] CreateExt()
        {
            uint[] val_1 = new uint[8];
        }
        public static ulong[] CreateExt64()
        {
            ulong[] val_1 = new ulong[4];
        }
        public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat128.Gte(x:  x, xOff:  xOff, y:  y, yOff:  yOff)) != false)
            {
                    int val_2 = Org.BouncyCastle.Math.Raw.Nat128.Sub(x:  x, xOff:  xOff, y:  y, yOff:  yOff, z:  z, zOff:  zOff);
                val_4 = 1;
                return (bool)val_4;
            }
            
            int val_3 = Org.BouncyCastle.Math.Raw.Nat128.Sub(x:  y, xOff:  yOff, y:  x, yOff:  xOff, z:  z, zOff:  zOff);
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool Eq(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 11;
            label_5:
            if(x[1] != y[1])
            {
                goto label_4;
            }
            
            val_1 = 11 - 1;
            if(3 > 0)
            {
                goto label_5;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_4:
            val_2 = 0;
            return (bool)val_2;
        }
        public static bool Eq64(ulong[] x, ulong[] y)
        {
            var val_1;
            var val_2;
            val_1 = 5;
            label_5:
            if(x[1] != y[1])
            {
                goto label_4;
            }
            
            val_1 = 5 - 1;
            if(1 > 0)
            {
                goto label_5;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_4:
            val_2 = 0;
            return (bool)val_2;
        }
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_8 = x;
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 129))
            {
                goto label_4;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat128.Create();
            goto label_5;
            label_11:
            val_3[0] = val_8.IntValue;
            val_8 = val_8.ShiftRight(n:  32);
            label_5:
            if(val_8.SignValue != 0)
            {
                goto label_11;
            }
            
            return val_3;
            label_4:
            System.ArgumentException val_7 = new System.ArgumentException();
        }
        public static ulong[] FromBigInteger64(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_8 = x;
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 129))
            {
                goto label_4;
            }
            
            System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat128.Create64();
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
        public static uint GetBit(uint[] x, int bit)
        {
            uint val_4;
            var val_5;
            int val_3 = bit;
            if(val_3 == 0)
            {
                goto label_0;
            }
            
            if((val_3 & 4294967168) != 0)
            {
                goto label_1;
            }
            
            int val_2 = val_3 >> 5;
            val_3 = val_3 & 31;
            val_4 = (x[((long)(int)((bit >> 5))) << 2]) >> val_3;
            goto label_4;
            label_0:
            val_4 = x[0];
            label_4:
            val_5 = val_4 & 1;
            return (uint)val_5;
            label_1:
            val_5 = 0;
            return (uint)val_5;
        }
        public static bool Gte(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 11;
            label_6:
            uint val_2 = x[1];
            uint val_3 = y[1];
            if(val_2 < val_3)
            {
                goto label_4;
            }
            
            val_2 = 1;
            if(val_2 > val_3)
            {
                    return (bool)val_2;
            }
            
            val_1 = 11 - 1;
            if(((11 - 9) & 2147483648) == 0)
            {
                goto label_6;
            }
            
            return (bool)val_2;
            label_4:
            val_2 = 0;
            return (bool)val_2;
        }
        public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
        {
            var val_3;
            var val_4;
            val_3 = 3;
            label_6:
            int val_1 = xOff + val_3;
            uint val_3 = x[((long)(int)((xOff + val_3))) << 2];
            int val_2 = yOff + val_3;
            uint val_4 = y[((long)(int)((yOff + val_3))) << 2];
            if(val_3 < val_4)
            {
                goto label_4;
            }
            
            val_4 = 1;
            if(val_3 > val_4)
            {
                    return (bool)val_4;
            }
            
            val_3 = val_3 - 1;
            if(val_3 > 0)
            {
                goto label_6;
            }
            
            return (bool)val_4;
            label_4:
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool IsOne(uint[] x)
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
            if(val_3 < 3)
            {
                goto label_5;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_4:
            val_1 = 0;
            return (bool)val_1;
        }
        public static bool IsOne64(ulong[] x)
        {
            var val_2;
            if(x[0] == 1)
            {
                    int val_3 = x.Length;
                val_3 = val_3 & 4294967294;
                var val_1 = (x[1] == 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public static bool IsZero(uint[] x)
        {
            var val_1;
            var val_1 = 0;
            label_3:
            if(null != null)
            {
                goto label_2;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < 3)
            {
                goto label_3;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_2:
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
            if(val_1 < 1)
            {
                goto label_3;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_2:
            val_1 = 0;
            return (bool)val_1;
        }
        public static void Mul(uint[] x, uint[] y, uint[] zz)
        {
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            int val_13;
            val_8 = y.Length;
            if(val_8 == 0)
            {
                    val_8 = y.Length;
            }
            
            uint val_11 = y[0];
            if(val_8 <= 1)
            {
                    val_8 = y.Length;
            }
            
            uint val_12 = y[0];
            if(val_8 <= 2)
            {
                    val_8 = y.Length;
            }
            
            uint val_13 = y[1];
            uint val_14 = y[1];
            uint val_15 = x[0];
            uint val_1 = val_15 * val_11;
            val_9 = zz.Length;
            if(val_9 == 0)
            {
                    val_9 = zz.Length;
            }
            
            zz[0] = val_1;
            val_1 = (val_15 * val_12) + (val_1 >> 32);
            if(val_9 <= 1)
            {
                    val_9 = zz.Length;
            }
            
            zz[0] = val_1;
            val_1 = (val_15 * val_13) + (val_1 >> 32);
            if(val_9 <= 2)
            {
                    val_9 = zz.Length;
            }
            
            val_15 = (val_15 * val_14) + (val_1 >> 32);
            zz[1] = val_1;
            if(val_9 <= 3)
            {
                    val_9 = zz.Length;
            }
            
            zz[1] = val_15;
            zz[2] = val_15 >> 32;
            do
            {
                var val_6 = 9 - 8;
                val_10 = zz.Length;
                uint val_16 = x[0];
                if(val_6 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                uint val_7 = null + (val_16 * val_11);
                mem2[0] = val_7;
                val_11 = zz.Length;
                val_6 = val_6 + 1;
                val_7 = val_7 >> 32;
                if(val_6 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                uint val_8 = val_7 + (val_16 * val_12);
                val_7 = val_8 + 1152921505741541488;
                mem2[0] = val_7;
                val_12 = zz.Length;
                val_6 = val_6 + 1;
                val_7 = val_7 >> 32;
                if(val_6 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                val_8 = val_7 + (val_16 * val_13);
                val_7 = val_8 + 1152921505741541488;
                mem2[0] = val_7;
                val_13 = zz.Length;
                val_6 = val_6 + 1;
                val_7 = val_7 >> 32;
                if(val_6 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                val_8 = val_7 + (val_16 * val_14);
                val_7 = val_8 + 1152921505741541488;
                mem2[0] = val_7;
                val_7 = val_7 >> 32;
                mem2[0] = val_7;
                var val_10 = 9 + 1;
            }
            while((val_6 + 1) != 7);
        
        }
        public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_25;
            int val_26;
            int val_27;
            int val_28;
            int val_29;
            int val_32 = xOff;
            val_25 = y.Length;
            if(val_25 <= yOff)
            {
                    val_25 = y.Length;
            }
            
            uint val_25 = y[((long)(int)(yOff)) << 2];
            if((yOff + 1) >= val_25)
            {
                    val_25 = y.Length;
            }
            
            uint val_26 = y[((long)(int)((yOff + 1))) << 2];
            if((yOff + 2) >= val_25)
            {
                    val_25 = y.Length;
            }
            
            uint val_27 = y[((long)(int)((yOff + 2))) << 2];
            int val_3 = yOff + 3;
            uint val_28 = y[((long)(int)((yOff + 3))) << 2];
            uint val_29 = x[((long)(int)(xOff)) << 2];
            uint val_4 = val_29 * val_25;
            zz[((long)(int)(zzOff)) << 2] = val_4;
            uint val_30 = val_26;
            val_30 = val_29 * val_30;
            val_4 = val_30 + (val_4 >> 32);
            int val_5 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = val_4;
            uint val_31 = val_27;
            val_31 = val_29 * val_31;
            val_4 = val_31 + (val_4 >> 32);
            int val_6 = zzOff + 2;
            zz[((long)(int)((zzOff + 2))) << 2] = val_4;
            val_29 = (val_29 * val_28) + (val_4 >> 32);
            int val_8 = zzOff + 3;
            zz[((long)(int)((zzOff + 3))) << 2] = val_29;
            int val_9 = zzOff + 4;
            val_29 = val_29 >> 32;
            val_32 = val_32 + 1;
            zz[((long)(int)((zzOff + 4))) << 2] = val_29;
            var val_40 = -3;
            do
            {
                int val_12 = val_32 + val_40;
                val_12 = val_12 + 3;
                val_26 = zz.Length;
                uint val_33 = x[((long)(int)((((xOff + 1) + -3) + 3))) << 2];
                if(((zzOff + val_40) + 4) >= val_26)
            {
                    val_26 = zz.Length;
            }
            
                uint val_13 = (zz[((long)(int)(((zzOff + -3) + 4))) << 2]) + (val_33 * val_25);
                mem2[0] = val_13;
                val_27 = zz.Length;
                uint val_15 = val_13 >> 32;
                if(((zzOff + val_40) + 5) >= val_27)
            {
                    val_27 = zz.Length;
            }
            
                uint val_36 = val_26;
                val_36 = val_15 + (val_33 * val_36);
                uint val_17 = val_36 + (zz[((long)(int)(((zzOff + -3) + 5))) << 2]);
                mem2[0] = val_17;
                val_28 = zz.Length;
                val_15 = val_17 >> 32;
                if(((zzOff + val_40) + 6) >= val_28)
            {
                    val_28 = zz.Length;
            }
            
                uint val_38 = val_27;
                val_38 = val_15 + (val_33 * val_38);
                uint val_20 = val_38 + (zz[((long)(int)(((zzOff + -3) + 6))) << 2]);
                mem2[0] = val_20;
                val_29 = zz.Length;
                val_15 = val_20 >> 32;
                if(((zzOff + val_40) + 7) >= val_29)
            {
                    val_29 = zz.Length;
            }
            
                val_38 = val_15 + (val_33 * val_28);
                uint val_23 = val_38 + (zz[((long)(int)(((zzOff + -3) + 7))) << 2]);
                mem2[0] = val_23;
                int val_24 = zzOff + val_40;
                val_24 = val_24 + 8;
                val_23 = val_23 >> 32;
                val_40 = val_40 + 1;
                zz[((long)(int)(((zzOff + -3) + 8))) << 2] = val_23;
            }
            while(val_40 != 0);
        
        }
        public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
        {
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            val_4 = y.Length;
            if(val_4 == 0)
            {
                    val_4 = y.Length;
            }
            
            if(val_4 <= 1)
            {
                    val_4 = y.Length;
            }
            
            if(val_4 <= 2)
            {
                    val_4 = y.Length;
            }
            
            var val_8 = 0;
            do
            {
                val_5 = zz.Length;
                if(val_8 >= val_5)
            {
                    val_5 = zz.Length;
            }
            
                System.UInt32[] val_1 = null + (1152921505741541488 * y[0]);
                mem2[0] = val_1;
                val_6 = zz.Length;
                val_8 = val_8 + 1;
                val_1 = val_1 >> 32;
                if(val_8 >= val_6)
            {
                    val_6 = zz.Length;
            }
            
                uint val_9 = y[0];
                val_9 = val_1 + (1152921505741541488 * val_9);
                mem2[0] = val_1;
                val_7 = zz.Length;
                val_8 = val_8 + 1;
                val_1 = val_1 >> 32;
                if(val_8 >= val_7)
            {
                    val_7 = zz.Length;
            }
            
                System.UInt32[] val_2 = val_1 + (1152921505741541488 * y[1]);
                mem2[0] = val_1;
                val_8 = zz.Length;
                val_8 = val_8 + 1;
                val_1 = val_1 >> 32;
                if(val_8 >= val_8)
            {
                    val_8 = zz.Length;
            }
            
                System.UInt32[] val_3 = val_1 + (1152921505741541488 * y[1]);
                mem2[0] = val_1;
                val_9 = zz.Length;
                val_8 = val_8 + 1;
                val_1 = val_1 >> 32;
                if(val_8 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                val_8 = val_8 - 3;
                mem2[0] = 0;
            }
            while(val_8 != 4);
            
            return 0;
        }
        public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_12;
            int val_13;
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            val_12 = y.Length;
            if(val_12 <= yOff)
            {
                    val_12 = y.Length;
            }
            
            if((yOff + 1) >= val_12)
            {
                    val_12 = y.Length;
            }
            
            if((yOff + 2) >= val_12)
            {
                    val_12 = y.Length;
            }
            
            int val_3 = yOff + 3;
            uint val_25 = 0;
            var val_26 = -4;
            do
            {
                int val_5 = xOff + val_26;
                val_5 = val_5 + 4;
                int val_6 = (zzOff + val_26) + 4;
                uint val_16 = x[((long)(int)(((xOff + -4) + 4))) << 2];
                val_13 = zz.Length;
                if(val_6 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                uint val_7 = (zz[((long)(int)(((zzOff + -4) + 4))) << 2]) + (val_16 * (y[((long)(int)(yOff)) << 2]));
                mem2[0] = val_7;
                val_14 = zz.Length;
                int val_8 = zzOff + val_26;
                val_8 = val_8 + 5;
                val_6 = val_6 + 1;
                val_7 = val_7 >> 32;
                if(val_6 >= val_14)
            {
                    val_14 = zz.Length;
            }
            
                uint val_19 = y[((long)(int)((yOff + 1))) << 2];
                val_19 = val_7 + (val_16 * val_19);
                val_7 = val_19 + (zz[((long)(int)(((zzOff + -4) + 5))) << 2]);
                mem2[0] = val_7;
                val_15 = zz.Length;
                int val_9 = zzOff + val_26;
                val_9 = val_9 + 6;
                val_6 = val_6 + 1;
                val_7 = val_7 >> 32;
                if(val_6 >= val_15)
            {
                    val_15 = zz.Length;
            }
            
                uint val_21 = y[((long)(int)((yOff + 2))) << 2];
                val_21 = val_7 + (val_16 * val_21);
                val_7 = val_21 + (zz[((long)(int)(((zzOff + -4) + 6))) << 2]);
                mem2[0] = val_7;
                val_16 = zz.Length;
                int val_10 = zzOff + val_26;
                val_10 = val_10 + 7;
                val_6 = val_6 + 1;
                val_7 = val_7 >> 32;
                if(val_6 >= val_16)
            {
                    val_16 = zz.Length;
            }
            
                uint val_23 = y[((long)(int)((yOff + 3))) << 2];
                val_23 = val_7 + (val_16 * val_23);
                val_16 = val_23 + (zz[((long)(int)(((zzOff + -4) + 7))) << 2]);
                mem2[0] = val_16;
                val_17 = zz.Length;
                int val_11 = zzOff + val_26;
                val_11 = val_11 + 8;
                val_6 = val_6 + 1;
                val_16 = val_16 >> 32;
                if(val_6 >= val_17)
            {
                    val_17 = zz.Length;
            }
            
                val_23 = val_16 + val_25;
                val_25 = val_23 + (zz[((long)(int)(((zzOff + -4) + 8))) << 2]);
                mem2[0] = val_25;
                val_26 = val_26 + 1;
                val_25 = val_25 >> 32;
            }
            while(val_26 != 0);
            
            return (uint)val_25;
        }
        public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_16 = x[((long)(int)(xOff)) << 2];
            uint val_25 = w;
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + (val_16 * val_25);
            z[((long)(int)(zOff)) << 2] = val_1;
            int val_2 = xOff + 1;
            uint val_3 = val_1 >> 32;
            uint val_18 = x[((long)(int)((xOff + 1))) << 2];
            int val_4 = yOff + 1;
            int val_20 = zOff;
            uint val_5 = val_3 + val_16;
            val_20 = val_20 + 1;
            val_5 = val_5 + (val_18 * val_25);
            val_16 = val_5 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_16;
            int val_6 = xOff + 2;
            val_3 = val_16 >> 32;
            uint val_21 = x[((long)(int)((xOff + 2))) << 2];
            int val_7 = yOff + 2;
            uint val_8 = val_3 + val_18;
            val_8 = val_8 + (val_21 * val_25);
            int val_9 = zOff + 2;
            val_18 = val_8 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_18;
            int val_10 = xOff + 3;
            uint val_23 = x[((long)(int)((xOff + 3))) << 2];
            int val_11 = yOff + 3;
            uint val_13 = (val_18 >> 32) + val_21;
            int val_14 = zOff + 3;
            val_13 = val_13 + (val_23 * val_25);
            val_25 = val_13 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_25;
            return (ulong)val_23 + (val_25 >> 32);
        }
        public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
        {
            int val_11;
            int val_12;
            int val_13;
            int val_14;
            uint val_11 = yy[((long)(int)(yyOff)) << 2];
            val_11 = zz.Length;
            if(val_11 <= zzOff)
            {
                    val_11 = zz.Length;
            }
            
            val_11 = (zz[((long)(int)(zzOff)) << 2]) + (val_11 * x);
            mem2[0] = val_11;
            int val_1 = yyOff + 1;
            val_12 = zz.Length;
            val_11 = val_11 >> 32;
            if((zzOff + 1) >= val_12)
            {
                    val_12 = zz.Length;
            }
            
            uint val_3 = val_11 + ((yy[((long)(int)((yyOff + 1))) << 2]) * x);
            val_11 = val_3 + (zz[((long)(int)((zzOff + 1))) << 2]);
            mem2[0] = val_11;
            int val_4 = yyOff + 2;
            val_13 = zz.Length;
            val_11 = val_11 >> 32;
            if((zzOff + 2) >= val_13)
            {
                    val_13 = zz.Length;
            }
            
            val_3 = val_11 + ((yy[((long)(int)((yyOff + 2))) << 2]) * x);
            val_11 = val_3 + (zz[((long)(int)((zzOff + 2))) << 2]);
            mem2[0] = val_11;
            int val_6 = yyOff + 3;
            val_14 = zz.Length;
            if((zzOff + 3) >= val_14)
            {
                    val_14 = zz.Length;
            }
            
            val_3 = (val_11 >> 32) + ((yy[((long)(int)((yyOff + 3))) << 2]) * x);
            uint val_9 = val_3 + (zz[((long)(int)((zzOff + 3))) << 2]);
            mem2[0] = val_9;
            return (uint)val_9 >> 32;
        }
        public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
        {
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            ulong val_10 = y;
            uint val_12 = x;
            val_9 = z.Length;
            ulong val_1 = val_10 & 4294967295;
            if(val_9 <= zOff)
            {
                    val_9 = z.Length;
            }
            
            ulong val_2 = (z[((long)(int)(zOff)) << 2]) + (val_1 * val_12);
            mem2[0] = val_2;
            val_10 = z.Length;
            val_2 = val_2 >> 32;
            val_10 = val_10 >> 32;
            if((zOff + 1) >= val_10)
            {
                    val_10 = z.Length;
            }
            
            ulong val_4 = val_1 + (val_10 * val_12);
            val_4 = val_4 + val_2;
            val_12 = val_4 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_12;
            val_11 = z.Length;
            val_1 = val_12 >> 32;
            if((zOff + 2) >= val_11)
            {
                    val_11 = z.Length;
            }
            
            val_4 = val_1 + val_10;
            val_10 = val_4 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_10;
            val_12 = z.Length;
            val_10 = val_10 >> 32;
            if((zOff + 3) >= val_12)
            {
                    val_12 = z.Length;
            }
            
            ulong val_7 = val_10 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_7;
            return (uint)val_7 >> 32;
        }
        public static uint Mul33WordAdd(uint x, uint y, uint[] z, int zOff)
        {
            int val_6;
            int val_7;
            int val_8;
            uint val_7 = x;
            val_6 = z.Length;
            if(val_6 <= zOff)
            {
                    val_6 = z.Length;
            }
            
            var val_9 = val_7;
            val_7 = (z[((long)(int)(zOff)) << 2]) + (y * val_9);
            mem2[0] = val_7;
            val_7 = z.Length;
            if((zOff + 1) >= val_7)
            {
                    val_7 = z.Length;
            }
            
            val_9 = (val_7 >> 32) + y;
            uint val_3 = val_9 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_3;
            val_8 = z.Length;
            val_3 = val_3 >> 32;
            if((zOff + 2) >= val_8)
            {
                    val_8 = z.Length;
            }
            
            val_3 = val_3 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  4, z:  z, zOff:  zOff, zPos:  3);
        }
        public static uint MulWordDwordAdd(uint x, ulong y, uint[] z, int zOff)
        {
            int val_6;
            int val_7;
            int val_8;
            ulong val_8 = y;
            val_6 = z.Length;
            if(val_6 <= zOff)
            {
                    val_6 = z.Length;
            }
            
            uint val_1 = (z[((long)(int)(zOff)) << 2]) + (x * val_8);
            mem2[0] = val_1;
            val_7 = z.Length;
            val_1 = val_1 >> 32;
            if((zOff + 1) >= val_7)
            {
                    val_7 = z.Length;
            }
            
            ulong val_3 = val_8 >> 32;
            val_3 = val_1 + (val_3 * x);
            val_8 = val_3 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_8;
            val_8 = z.Length;
            val_8 = val_8 >> 32;
            if((zOff + 2) >= val_8)
            {
                    val_8 = z.Length;
            }
            
            val_8 = val_8 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  4, z:  z, zOff:  zOff, zPos:  3);
        }
        public static uint MulWordsAdd(uint x, uint y, uint[] z, int zOff)
        {
            int val_3;
            int val_4;
            uint val_4 = x;
            val_3 = z.Length;
            if(val_3 <= zOff)
            {
                    val_3 = z.Length;
            }
            
            val_4 = (z[((long)(int)(zOff)) << 2]) + (y * val_4);
            mem2[0] = val_4;
            val_4 = z.Length;
            val_4 = val_4 >> 32;
            if((zOff + 1) >= val_4)
            {
                    val_4 = z.Length;
            }
            
            val_4 = val_4 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_4;
            if((val_4 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  4, z:  z, zOff:  zOff, zPos:  2);
        }
        public static uint MulWord(uint x, uint[] y, uint[] z, int zOff)
        {
            var val_3 = 0;
            uint val_2 = 0;
            do
            {
                val_2 = val_2 + (1152921505741541488 * x);
                int val_1 = zOff + val_3;
                val_3 = val_3 + 1;
                z[((long)(int)((zOff + 0))) << 2] = val_2;
                val_2 = val_2 >> 32;
            }
            while(val_3 != 4);
            
            return (uint)val_2;
        }
        public static void Square(uint[] x, uint[] zz)
        {
            int val_10;
            int val_11;
            int val_12;
            uint val_14 = x[0];
            var val_16 = 0;
            do
            {
                var val_2 = val_16 + 7;
                uint val_3 = x[1] * x[1];
                zz[0] = val_3 >> 33;
                var val_5 = val_16 + 6;
                zz[0] = val_3 >> 1;
                var val_7 = 11 - 1;
                val_16 = val_16 - 2;
            }
            while((11 - 8) > 1);
            
            uint val_8 = val_14 * val_14;
            zz[0] = val_8;
            uint val_9 = val_8 >> 33;
            val_10 = zz.Length;
            uint val_17 = x[0];
            if(val_10 <= 2)
            {
                    val_10 = zz.Length;
            }
            
            val_9 = val_9 + (val_17 * val_14);
            zz[0] = (ulong)(val_8 >> 32) & 1;
            val_11 = zz.Length;
            uint val_19 = x[1];
            if(val_11 <= 3)
            {
                    val_11 = zz.Length;
            }
            
            val_8 = zz[1] + (val_9 >> 32);
            if(val_11 <= 4)
            {
                    val_11 = zz.Length;
            }
            
            val_9 = val_8 + (val_19 * val_14);
            zz[1] = val_9 >> 31;
            val_8 = (val_19 * val_17) + (val_9 >> 32);
            val_12 = zz.Length;
            uint val_22 = x[1];
            uint val_12 = val_8 + zz[1];
            if(val_12 <= 5)
            {
                    val_12 = zz.Length;
            }
            
            val_9 = val_9 >> 31;
            val_14 = val_12 & 4294967295;
            if(val_12 <= 6)
            {
                    val_12 = zz.Length;
            }
            
            val_8 = val_12 >> 32;
            val_14 = val_14 + (val_22 * val_14);
            if(val_12 <= 3)
            {
                    val_12 = zz.Length;
            }
            
            zz[1] = val_9;
            uint val_25 = zz[2];
            uint val_13 = val_22 * val_19;
            val_25 = val_8 + val_25;
            val_25 = val_25 + (val_22 * val_17);
            val_17 = val_25 + (val_14 >> 32);
            val_25 = val_13 + (val_17 >> 32);
            val_8 = val_25 + zz[2];
            val_22 = zz[3] + (val_8 >> 32);
            if(val_12 <= 4)
            {
                    val_12 = zz.Length;
            }
            
            zz[2] = val_19;
            if(val_12 <= 5)
            {
                    val_12 = zz.Length;
            }
            
            zz[2] = val_17;
            if(val_12 <= 6)
            {
                    val_12 = zz.Length;
            }
            
            zz[3] = val_8;
            val_8 = val_22 >> 31;
            if(val_12 <= 7)
            {
                    val_12 = zz.Length;
            }
            
            uint val_26 = zz[3];
            val_13 = val_22 >> 32;
            val_26 = val_26 + val_13;
            zz[3] = val_8;
        }
        public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
        {
            int val_26;
            int val_27;
            var val_28;
            int val_29;
            int val_30;
            int val_27 = zzOff;
            uint val_26 = x[((long)(int)(xOff)) << 2];
            var val_29 = 4;
            val_27 = val_27 + 7;
            do
            {
                int val_2 = (xOff + 3) + val_29;
                val_2 = val_2 - 4;
                uint val_3 = (x[((long)(int)((((xOff + 3) + 4) - 4))) << 2]) * (x[((long)(int)((((xOff + 3) + 4) - 4))) << 2]);
                zz[((long)(int)((zzOff + 7))) << 2] = val_3 >> 33;
                int val_5 = val_27 - 1;
                val_29 = val_29 - 1;
                zz[((long)(int)(((zzOff + 7) - 1))) << 2] = val_3 >> 1;
                val_27 = val_27 - 2;
            }
            while(val_29 > 1);
            
            uint val_7 = val_26 * val_26;
            zz[((long)(int)(zzOff)) << 2] = val_7;
            int val_8 = xOff + 1;
            val_26 = zz.Length;
            uint val_30 = x[((long)(int)((xOff + 1))) << 2];
            if((val_27 + 2) >= val_26)
            {
                    val_26 = zz.Length;
            }
            
            val_30 = (val_7 >> 33) + (val_30 * val_26);
            int val_11 = val_27 + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = (ulong)(val_7 >> 32) & 1;
            int val_12 = xOff + 2;
            val_27 = zz.Length;
            uint val_32 = x[((long)(int)((xOff + 2))) << 2];
            int val_13 = val_27 + 3;
            val_28 = (long)val_13;
            if(val_13 >= val_27)
            {
                    val_27 = zz.Length;
                val_28 = val_28;
            }
            
            val_30 = (zz[((long)(int)((zzOff + 2))) << 2]) + (val_30 >> 32);
            if((val_27 + 4) >= val_27)
            {
                    val_27 = zz.Length;
            }
            
            uint val_16 = val_30 + (val_32 * val_26);
            mem2[0] = val_30 >> 31;
            uint val_35 = val_30;
            val_35 = val_32 * val_35;
            val_30 = val_35 + (val_16 >> 32);
            int val_17 = xOff + 3;
            val_29 = zz.Length;
            uint val_18 = val_30 + (zz[((long)(int)((zzOff + 3))) << 2]);
            uint val_36 = x[((long)(int)((xOff + 3))) << 2];
            if((val_27 + 5) >= val_29)
            {
                    val_29 = zz.Length;
            }
            
            uint val_37 = zz[((long)(int)((zzOff + 5))) << 2];
            val_32 = val_18 & 4294967295;
            if((val_27 + 6) >= val_29)
            {
                    val_29 = zz.Length;
            }
            
            uint val_22 = val_18 >> 32;
            uint val_38 = zz[((long)(int)((zzOff + 6))) << 2];
            val_32 = val_32 + (val_36 * val_26);
            mem2[0] = val_16 >> 31;
            uint val_39 = zz[((long)(int)((zzOff + 4))) << 2];
            uint val_40 = val_32;
            val_39 = val_22 + val_39;
            val_39 = val_39 + (val_36 * val_30);
            val_40 = val_36 * val_40;
            val_22 = val_39 + (val_32 >> 32);
            val_39 = val_40 + (val_22 >> 32);
            uint val_23 = val_39 + val_37;
            val_38 = val_38 + (val_23 >> 32);
            mem2[0] = val_37;
            mem2[0] = val_22;
            mem2[0] = val_23;
            val_30 = zz.Length;
            val_23 = val_38 >> 31;
            if((val_27 + 7) >= val_30)
            {
                    val_30 = zz.Length;
            }
            
            uint val_41 = zz[((long)(int)((zzOff + 7))) << 2];
            val_41 = val_41 + (val_38 >> 32);
            mem2[0] = val_23;
        }
        public static int Sub(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_10 = y;
            uint val_2 = x[0];
            val_2 = val_2 - val_10[0];
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_10[0];
            val_5 = x[0] - val_5;
            val_2 = val_5 + val_2;
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_10[1];
            val_7 = x[1] - val_7;
            val_2 = val_7 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_10[1];
            val_9 = x[1] - val_9;
            val_10 = val_9 + val_2;
            z[1] = val_10;
            return (int)val_10 >> 32;
        }
        public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_13 = x[((long)(int)(xOff)) << 2];
            val_13 = val_13 - (y[((long)(int)(yOff)) << 2]);
            z[((long)(int)(zOff)) << 2] = val_13;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_13 = val_13 >> 32;
            uint val_16 = y[((long)(int)((yOff + 1))) << 2];
            int val_3 = zOff + 1;
            val_16 = (x[((long)(int)((xOff + 1))) << 2]) - val_16;
            val_13 = val_16 + val_13;
            z[((long)(int)((zOff + 1))) << 2] = val_13;
            int val_4 = xOff + 2;
            int val_5 = yOff + 2;
            val_13 = val_13 >> 32;
            uint val_18 = y[((long)(int)((yOff + 2))) << 2];
            int val_6 = zOff + 2;
            val_18 = (x[((long)(int)((xOff + 2))) << 2]) - val_18;
            val_13 = val_18 + val_13;
            z[((long)(int)((zOff + 2))) << 2] = val_13;
            int val_7 = xOff + 3;
            int val_8 = yOff + 3;
            uint val_20 = y[((long)(int)((yOff + 3))) << 2];
            int val_10 = zOff + 3;
            val_20 = (x[((long)(int)((xOff + 3))) << 2]) - val_20;
            uint val_11 = val_20 + (val_13 >> 32);
            z[((long)(int)((zOff + 3))) << 2] = val_11;
            return (int)val_11 >> 32;
        }
        public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            System.UInt32[] val_15 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            uint val_1 = val_3 - x[0];
            val_3 = val_1 - val_15[0];
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            val_1 = val_3 + z[0];
            val_1 = val_1 - x[0];
            val_3 = val_1 - val_15[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_15[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_15 = val_1 - val_15[1];
            z[1] = val_15;
            return (int)val_15 >> 32;
        }
        public static int SubFrom(uint[] x, uint[] z)
        {
            int val_2;
            int val_3;
            int val_4;
            System.UInt32[] val_10 = x;
            uint val_2 = z[0];
            val_2 = z.Length;
            val_2 = val_2 - val_10[0];
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_10[0];
            val_3 = z.Length;
            val_5 = z[0] - val_5;
            val_2 = val_5 + val_2;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_10[1];
            val_4 = z.Length;
            val_7 = z[1] - val_7;
            val_2 = val_7 + val_2;
            if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_10[1];
            val_9 = z[1] - val_9;
            val_10 = val_9 + val_2;
            z[1] = val_10;
            return (int)val_10 >> 32;
        }
        public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
        {
            System.UInt32[] val_17 = z;
            uint val_1 = (val_17[((long)(int)(zOff)) << 2]) - (x[((long)(int)(xOff)) << 2]);
            mem2[0] = val_1;
            int val_2 = zOff + 1;
            int val_3 = xOff + 1;
            val_1 = val_1 >> 32;
            uint val_12 = x[((long)(int)((xOff + 1))) << 2];
            val_12 = (val_17[((long)(int)((zOff + 1))) << 2]) - val_12;
            val_1 = val_12 + val_1;
            mem2[0] = val_1;
            int val_4 = zOff + 2;
            int val_5 = xOff + 2;
            val_1 = val_1 >> 32;
            uint val_14 = x[((long)(int)((xOff + 2))) << 2];
            val_14 = (val_17[((long)(int)((zOff + 2))) << 2]) - val_14;
            val_1 = val_14 + val_1;
            mem2[0] = val_1;
            int val_6 = zOff + 3;
            int val_7 = xOff + 3;
            val_1 = val_1 >> 32;
            uint val_16 = x[((long)(int)((xOff + 3))) << 2];
            val_16 = (val_17[((long)(int)((zOff + 3))) << 2]) - val_16;
            val_17 = val_16 + val_1;
            mem2[0] = val_17;
            return (int)val_17 >> 32;
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
        {
            byte[] val_1 = new byte[16];
            var val_3 = 0;
            var val_4 = 12;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  1134694512, bs:  val_1, off:  12);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 4;
            }
            while(val_3 != 4);
            
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1);
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
        {
            byte[] val_1 = new byte[16];
            var val_3 = 0;
            var val_4 = 8;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  null, bs:  val_1, off:  8);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 8;
            }
            while(val_3 != 2);
            
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1);
        }
        public static void Zero(uint[] z)
        {
            int val_1 = z.Length;
            if(val_1 == 0)
            {
                    val_1 = z.Length;
            }
            
            z[0] = 0;
            if(val_1 <= 1)
            {
                    val_1 = z.Length;
            }
            
            z[0] = 0;
            if(val_1 <= 2)
            {
                    val_1 = z.Length;
            }
            
            z[1] = 0;
            z[1] = 0;
        }
        protected Nat128()
        {
        
        }
    
    }

}
