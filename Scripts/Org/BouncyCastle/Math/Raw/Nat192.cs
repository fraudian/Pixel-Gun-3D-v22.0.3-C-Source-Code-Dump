using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat192
    {
        // Fields
        private const ulong M = 4294967295;
        
        // Methods
        public static uint Add(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_15 = y;
            uint val_3 = x[0];
            val_3 = val_15[0] + val_3;
            z[0] = val_3;
            val_3 = val_3 >> 32;
            uint val_1 = val_3 + x[0];
            val_3 = val_1 + val_15[0];
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_15[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_15[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_3 = val_1 + val_15[2];
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_15 = val_1 + val_15[2];
            z[2] = val_15;
            return (uint)val_15 >> 32;
        }
        public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
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
            val_3 = val_3 >> 32;
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            val_1 = val_3 + x[1];
            val_1 = val_1 + y[1];
            val_3 = val_1 + z[1];
            z[1] = val_3;
            val_7 = z.Length;
            val_3 = val_3 >> 32;
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            val_1 = val_3 + x[2];
            val_1 = val_1 + y[2];
            val_3 = val_1 + z[2];
            z[2] = val_3;
            val_8 = z.Length;
            uint val_19 = y[2];
            val_3 = val_3 >> 32;
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            val_1 = val_3 + x[2];
            val_1 = val_1 + val_19;
            val_19 = val_1 + z[2];
            z[2] = val_19;
            return (uint)val_19 >> 32;
        }
        public static uint AddTo(uint[] x, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
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
            val_3 = val_3 >> 32;
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            val_1 = val_3 + x[1];
            val_3 = val_1 + z[1];
            z[1] = val_3;
            val_7 = z.Length;
            val_3 = val_3 >> 32;
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            val_1 = val_3 + x[2];
            val_3 = val_1 + z[2];
            z[2] = val_3;
            val_8 = z.Length;
            uint val_13 = x[2];
            val_3 = val_3 >> 32;
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            val_1 = val_3 + val_13;
            val_13 = val_1 + z[2];
            z[2] = val_13;
            return (uint)val_13 >> 32;
        }
        public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
        {
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            uint val_17 = cIn;
            val_15 = z.Length;
            if(val_15 <= zOff)
            {
                    val_15 = z.Length;
            }
            
            uint val_1 = (x[((long)(int)(xOff)) << 2]) + val_17;
            val_17 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_17;
            int val_2 = xOff + 1;
            val_16 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 1) >= val_16)
            {
                    val_16 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 1))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_17;
            int val_4 = xOff + 2;
            val_17 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 2) >= val_17)
            {
                    val_17 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 2))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_17;
            int val_6 = xOff + 3;
            val_18 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 3) >= val_18)
            {
                    val_18 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 3))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_17;
            int val_8 = xOff + 4;
            val_19 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 4) >= val_19)
            {
                    val_19 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 4))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_17;
            int val_10 = xOff + 5;
            val_20 = z.Length;
            if((zOff + 5) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            val_1 = (val_17 >> 32) + (x[((long)(int)((xOff + 5))) << 2]);
            uint val_13 = val_1 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_13;
            return (uint)val_13 >> 32;
        }
        public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
        {
            System.UInt32[] val_26 = u;
            uint val_14 = val_26[((long)(int)(uOff)) << 2];
            val_14 = (v[((long)(int)(vOff)) << 2]) + val_14;
            mem2[0] = val_14;
            mem2[0] = val_14;
            int val_1 = uOff + 1;
            int val_2 = vOff + 1;
            val_14 = val_14 >> 32;
            uint val_3 = val_14 + (val_26[((long)(int)((uOff + 1))) << 2]);
            val_14 = val_3 + (v[((long)(int)((vOff + 1))) << 2]);
            mem2[0] = val_14;
            mem2[0] = val_14;
            int val_4 = uOff + 2;
            int val_5 = vOff + 2;
            val_14 = val_14 >> 32;
            val_3 = val_14 + (val_26[((long)(int)((uOff + 2))) << 2]);
            val_14 = val_3 + (v[((long)(int)((vOff + 2))) << 2]);
            mem2[0] = val_14;
            mem2[0] = val_14;
            int val_6 = uOff + 3;
            int val_7 = vOff + 3;
            val_14 = val_14 >> 32;
            val_3 = val_14 + (val_26[((long)(int)((uOff + 3))) << 2]);
            val_14 = val_3 + (v[((long)(int)((vOff + 3))) << 2]);
            mem2[0] = val_14;
            mem2[0] = val_14;
            int val_8 = uOff + 4;
            int val_9 = vOff + 4;
            val_14 = val_14 >> 32;
            val_3 = val_14 + (val_26[((long)(int)((uOff + 4))) << 2]);
            val_14 = val_3 + (v[((long)(int)((vOff + 4))) << 2]);
            mem2[0] = val_14;
            mem2[0] = val_14;
            int val_10 = uOff + 5;
            int val_11 = vOff + 5;
            val_3 = (val_14 >> 32) + (val_26[((long)(int)((uOff + 5))) << 2]);
            val_26 = val_3 + (v[((long)(int)((vOff + 5))) << 2]);
            mem2[0] = val_26;
            mem2[0] = val_26;
            return (uint)val_26 >> 32;
        }
        public static void Copy(uint[] x, uint[] z)
        {
            z[0] = x[0];
            z[0] = x[0];
            z[1] = x[1];
            z[1] = x[1];
            z[2] = x[2];
            z[2] = x[2];
        }
        public static void Copy64(ulong[] x, ulong[] z)
        {
            z[0] = x[0];
            z[1] = x[1];
            z[2] = x[2];
        }
        public static uint[] Create()
        {
            uint[] val_1 = new uint[6];
        }
        public static ulong[] Create64()
        {
            ulong[] val_1 = new ulong[3];
        }
        public static uint[] CreateExt()
        {
            uint[] val_1 = new uint[12];
        }
        public static ulong[] CreateExt64()
        {
            ulong[] val_1 = new ulong[6];
        }
        public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat192.Gte(x:  x, xOff:  xOff, y:  y, yOff:  yOff)) != false)
            {
                    int val_2 = Org.BouncyCastle.Math.Raw.Nat192.Sub(x:  x, xOff:  xOff, y:  y, yOff:  yOff, z:  z, zOff:  zOff);
                val_4 = 1;
                return (bool)val_4;
            }
            
            int val_3 = Org.BouncyCastle.Math.Raw.Nat192.Sub(x:  y, xOff:  yOff, y:  x, yOff:  xOff, z:  z, zOff:  zOff);
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool Eq(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 13;
            label_5:
            if(x[2] != y[2])
            {
                goto label_4;
            }
            
            val_1 = 13 - 1;
            if(5 > 0)
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
            val_1 = 6;
            label_5:
            if(x[2] != y[2])
            {
                goto label_4;
            }
            
            val_1 = val_1 - 1;
            if(2 > 0)
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
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 193))
            {
                goto label_4;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat192.Create();
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
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 193))
            {
                goto label_4;
            }
            
            System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat192.Create64();
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
            var val_4;
            uint val_5;
            int val_3 = bit;
            if(val_3 != 0)
            {
                    val_4 = 0;
                if((val_3 >> 5) > 5)
            {
                    return (uint)val_4;
            }
            
                if((val_3 >> 31) != 0)
            {
                    return (uint)val_4;
            }
            
                val_3 = val_3 & 31;
                val_5 = (x[((long)(int)((bit >> 5))) << 2]) >> val_3;
            }
            else
            {
                    val_5 = x[0];
            }
            
            val_4 = val_5 & 1;
            return (uint)val_4;
        }
        public static bool Gte(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 13;
            label_6:
            uint val_2 = x[2];
            uint val_3 = y[2];
            if(val_2 < val_3)
            {
                goto label_4;
            }
            
            val_2 = 1;
            if(val_2 > val_3)
            {
                    return (bool)val_2;
            }
            
            val_1 = 13 - 1;
            if(((13 - 9) & 2147483648) == 0)
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
            val_3 = 5;
            label_6:
            int val_1 = xOff + 5;
            uint val_3 = x[((long)(int)((xOff + 5))) << 2];
            int val_2 = yOff + 5;
            uint val_4 = y[((long)(int)((yOff + 5))) << 2];
            if(val_3 < val_4)
            {
                goto label_4;
            }
            
            val_4 = 1;
            if(val_3 > val_4)
            {
                    return (bool)val_4;
            }
            
            val_3 = 5 - 1;
            if(5 > 0)
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
            if(val_3 < 5)
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
            if(val_3 < 2)
            {
                goto label_5;
            }
            
            val_1 = 1;
            return (bool)val_1;
            label_4:
            val_1 = 0;
            return (bool)val_1;
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
            if(val_1 < 5)
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
            if(val_1 < 2)
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
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            int val_13;
            int val_14;
            val_7 = y.Length;
            if(val_7 == 0)
            {
                    val_7 = y.Length;
            }
            
            uint val_10 = y[0];
            if(val_7 <= 1)
            {
                    val_7 = y.Length;
            }
            
            uint val_11 = y[0];
            if(val_7 <= 2)
            {
                    val_7 = y.Length;
            }
            
            uint val_12 = y[1];
            if(val_7 <= 3)
            {
                    val_7 = y.Length;
            }
            
            uint val_13 = y[1];
            if(val_7 <= 4)
            {
                    val_7 = y.Length;
            }
            
            uint val_14 = y[2];
            uint val_15 = y[2];
            uint val_16 = x[0];
            uint val_1 = val_16 * val_10;
            val_8 = zz.Length;
            if(val_8 == 0)
            {
                    val_8 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_17 = val_11;
            val_17 = val_16 * val_17;
            val_1 = val_17 + (val_1 >> 32);
            if(val_8 <= 1)
            {
                    val_8 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_18 = val_12;
            val_18 = val_16 * val_18;
            val_1 = val_18 + (val_1 >> 32);
            if(val_8 <= 2)
            {
                    val_8 = zz.Length;
            }
            
            zz[1] = val_1;
            val_1 = (val_16 * val_13) + (val_1 >> 32);
            if(val_8 <= 3)
            {
                    val_8 = zz.Length;
            }
            
            zz[1] = val_1;
            val_1 = (val_16 * val_14) + (val_1 >> 32);
            if(val_8 <= 4)
            {
                    val_8 = zz.Length;
            }
            
            val_16 = (val_16 * val_15) + (val_1 >> 32);
            zz[2] = val_1;
            if(val_8 <= 5)
            {
                    val_8 = zz.Length;
            }
            
            zz[2] = val_16;
            val_16 = val_16 >> 32;
            zz[3] = val_16;
            do
            {
                var val_5 = 9 - 8;
                val_9 = zz.Length;
                uint val_19 = x[0];
                if(val_5 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_6 = null + (val_19 * val_10);
                mem2[0] = val_6;
                val_10 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                uint val_20 = val_11;
                val_20 = val_6 + (val_19 * val_20);
                val_6 = val_20 + 1152921505741541488;
                mem2[0] = val_6;
                val_11 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                uint val_21 = val_12;
                val_21 = val_6 + (val_19 * val_21);
                val_6 = val_21 + 1152921505741541488;
                mem2[0] = val_6;
                val_12 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                val_21 = val_6 + (val_19 * val_13);
                val_6 = val_21 + 1152921505741541488;
                mem2[0] = val_6;
                val_13 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                val_21 = val_6 + (val_19 * val_14);
                val_6 = val_21 + 1152921505741541488;
                mem2[0] = val_6;
                val_14 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_14)
            {
                    val_14 = zz.Length;
            }
            
                val_21 = val_6 + (val_19 * val_15);
                val_6 = val_21 + 1152921505741541488;
                mem2[0] = val_6;
                mem2[0] = val_6 >> 32;
                var val_9 = 9 + 1;
            }
            while((val_5 + 1) != 11);
        
        }
        public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_37;
            int val_38;
            int val_39;
            int val_40;
            int val_41;
            int val_42;
            int val_43;
            val_37 = y.Length;
            if(val_37 <= yOff)
            {
                    val_37 = y.Length;
            }
            
            uint val_37 = y[((long)(int)(yOff)) << 2];
            if((yOff + 1) >= val_37)
            {
                    val_37 = y.Length;
            }
            
            uint val_38 = y[((long)(int)((yOff + 1))) << 2];
            if((yOff + 2) >= val_37)
            {
                    val_37 = y.Length;
            }
            
            uint val_39 = y[((long)(int)((yOff + 2))) << 2];
            if((yOff + 3) >= val_37)
            {
                    val_37 = y.Length;
            }
            
            uint val_40 = y[((long)(int)((yOff + 3))) << 2];
            if((yOff + 4) >= val_37)
            {
                    val_37 = y.Length;
            }
            
            uint val_41 = y[((long)(int)((yOff + 4))) << 2];
            int val_5 = yOff + 5;
            uint val_42 = y[((long)(int)((yOff + 5))) << 2];
            uint val_43 = x[((long)(int)(xOff)) << 2];
            uint val_6 = val_43 * val_37;
            zz[((long)(int)(zzOff)) << 2] = val_6;
            uint val_44 = val_38;
            val_44 = val_43 * val_44;
            val_6 = val_44 + (val_6 >> 32);
            int val_7 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = val_6;
            uint val_45 = val_39;
            val_45 = val_43 * val_45;
            val_6 = val_45 + (val_6 >> 32);
            int val_8 = zzOff + 2;
            zz[((long)(int)((zzOff + 2))) << 2] = val_6;
            uint val_46 = val_40;
            val_46 = val_43 * val_46;
            val_6 = val_46 + (val_6 >> 32);
            int val_9 = zzOff + 3;
            zz[((long)(int)((zzOff + 3))) << 2] = val_6;
            uint val_47 = val_41;
            val_47 = val_43 * val_47;
            val_6 = val_47 + (val_6 >> 32);
            int val_10 = zzOff + 4;
            zz[((long)(int)((zzOff + 4))) << 2] = val_6;
            uint val_12 = (val_43 * val_42) + (val_6 >> 32);
            int val_13 = zzOff + 5;
            zz[((long)(int)((zzOff + 5))) << 2] = val_12;
            int val_14 = zzOff + 6;
            val_12 = val_12 >> 32;
            var val_59 = -5;
            zz[((long)(int)((zzOff + 6))) << 2] = val_12;
            do
            {
                int val_18 = (xOff + 1) + val_59;
                val_18 = val_18 + 5;
                val_38 = zz.Length;
                uint val_48 = x[((long)(int)((((xOff + 1) + -5) + 5))) << 2];
                if(((zzOff + val_59) + 6) >= val_38)
            {
                    val_38 = zz.Length;
            }
            
                uint val_19 = (zz[((long)(int)(((zzOff + -5) + 6))) << 2]) + (val_48 * val_37);
                mem2[0] = val_19;
                val_39 = zz.Length;
                uint val_21 = val_19 >> 32;
                if(((zzOff + val_59) + 7) >= val_39)
            {
                    val_39 = zz.Length;
            }
            
                uint val_51 = val_38;
                val_51 = val_21 + (val_48 * val_51);
                uint val_23 = val_51 + (zz[((long)(int)(((zzOff + -5) + 7))) << 2]);
                mem2[0] = val_23;
                val_40 = zz.Length;
                val_21 = val_23 >> 32;
                if(((zzOff + val_59) + 8) >= val_40)
            {
                    val_40 = zz.Length;
            }
            
                uint val_53 = val_39;
                val_53 = val_21 + (val_48 * val_53);
                uint val_26 = val_53 + (zz[((long)(int)(((zzOff + -5) + 8))) << 2]);
                mem2[0] = val_26;
                val_41 = zz.Length;
                val_21 = val_26 >> 32;
                if(((zzOff + val_59) + 9) >= val_41)
            {
                    val_41 = zz.Length;
            }
            
                uint val_55 = val_40;
                val_55 = val_21 + (val_48 * val_55);
                uint val_29 = val_55 + (zz[((long)(int)(((zzOff + -5) + 9))) << 2]);
                mem2[0] = val_29;
                val_42 = zz.Length;
                val_21 = val_29 >> 32;
                if(((zzOff + val_59) + 10) >= val_42)
            {
                    val_42 = zz.Length;
            }
            
                uint val_57 = val_41;
                val_57 = val_21 + (val_48 * val_57);
                uint val_32 = val_57 + (zz[((long)(int)(((zzOff + -5) + 10))) << 2]);
                mem2[0] = val_32;
                val_43 = zz.Length;
                val_21 = val_32 >> 32;
                if(((zzOff + val_59) + 11) >= val_43)
            {
                    val_43 = zz.Length;
            }
            
                val_57 = val_21 + (val_48 * val_42);
                val_48 = val_57 + (zz[((long)(int)(((zzOff + -5) + 11))) << 2]);
                mem2[0] = val_48;
                int val_35 = zzOff + val_59;
                val_35 = val_35 + 12;
                val_59 = val_59 + 1;
                zz[((long)(int)(((zzOff + -5) + 12))) << 2] = val_48 >> 32;
            }
            while(val_59 != 0);
        
        }
        public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
        {
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            val_5 = y.Length;
            if(val_5 == 0)
            {
                    val_5 = y.Length;
            }
            
            if(val_5 <= 1)
            {
                    val_5 = y.Length;
            }
            
            if(val_5 <= 2)
            {
                    val_5 = y.Length;
            }
            
            if(val_5 <= 3)
            {
                    val_5 = y.Length;
            }
            
            if(val_5 <= 4)
            {
                    val_5 = y.Length;
            }
            
            var val_13 = 0;
            do
            {
                val_6 = zz.Length;
                if(val_13 >= val_6)
            {
                    val_6 = zz.Length;
            }
            
                System.UInt32[] val_1 = null + (1152921505741541488 * y[0]);
                mem2[0] = val_1;
                val_7 = zz.Length;
                val_13 = val_13 + 1;
                val_1 = val_1 >> 32;
                if(val_13 >= val_7)
            {
                    val_7 = zz.Length;
            }
            
                uint val_14 = y[0];
                val_14 = val_1 + (1152921505741541488 * val_14);
                mem2[0] = val_1;
                val_8 = zz.Length;
                val_13 = val_13 + 1;
                val_1 = val_1 >> 32;
                if(val_13 >= val_8)
            {
                    val_8 = zz.Length;
            }
            
                uint val_15 = y[1];
                val_15 = val_1 + (1152921505741541488 * val_15);
                mem2[0] = val_1;
                val_9 = zz.Length;
                val_13 = val_13 + 1;
                val_1 = val_1 >> 32;
                if(val_13 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_16 = y[1];
                val_16 = val_1 + (1152921505741541488 * val_16);
                mem2[0] = val_1;
                val_10 = zz.Length;
                val_13 = val_13 + 1;
                val_1 = val_1 >> 32;
                if(val_13 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                System.UInt32[] val_2 = val_1 + (1152921505741541488 * y[2]);
                mem2[0] = val_1;
                val_11 = zz.Length;
                val_13 = val_13 + 1;
                val_1 = val_1 >> 32;
                if(val_13 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                System.UInt32[] val_3 = val_1 + (1152921505741541488 * y[2]);
                mem2[0] = val_1;
                val_12 = zz.Length;
                var val_4 = val_13 + 1;
                System.UInt32[] val_5 = val_1 >> 32;
                if(val_4 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                mem2[0] = 0;
            }
            while((val_4 - 5) != 6);
            
            return 0;
        }
        public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            System.UInt32[] val_25 = y;
            val_17 = y.Length;
            if(val_17 <= yOff)
            {
                    val_17 = y.Length;
            }
            
            if((yOff + 1) >= val_17)
            {
                    val_17 = y.Length;
            }
            
            if((yOff + 2) >= val_17)
            {
                    val_17 = y.Length;
            }
            
            if((yOff + 3) >= val_17)
            {
                    val_17 = y.Length;
            }
            
            if((yOff + 4) >= val_17)
            {
                    val_17 = y.Length;
            }
            
            int val_5 = yOff + 5;
            uint val_37 = 0;
            var val_38 = 5;
            do
            {
                int val_7 = xOff + val_38;
                val_7 = val_7 + 6;
                int val_8 = (zzOff + val_38) + 6;
                uint val_23 = x[((long)(int)(((xOff + 5) + 6))) << 2];
                val_18 = zz.Length;
                if(val_8 >= val_18)
            {
                    val_18 = zz.Length;
            }
            
                val_25 = (zz[((long)(int)(((zzOff + 5) + 6))) << 2]) + (val_23 * (val_25[((long)(int)(yOff)) << 2]));
                mem2[0] = val_25;
                val_19 = zz.Length;
                int val_9 = zzOff + val_38;
                val_9 = val_9 + 7;
                val_8 = val_8 + 1;
                uint val_10 = val_25 >> 32;
                if(val_8 >= val_19)
            {
                    val_19 = zz.Length;
            }
            
                uint val_27 = val_25[((long)(int)((yOff + 1))) << 2];
                val_27 = val_10 + (val_23 * val_27);
                val_10 = val_27 + (zz[((long)(int)(((zzOff + 5) + 7))) << 2]);
                mem2[0] = val_10;
                val_20 = zz.Length;
                int val_11 = zzOff + val_38;
                val_11 = val_11 + 8;
                val_8 = val_8 + 1;
                val_10 = val_10 >> 32;
                if(val_8 >= val_20)
            {
                    val_20 = zz.Length;
            }
            
                uint val_29 = val_25[((long)(int)((yOff + 2))) << 2];
                val_29 = val_10 + (val_23 * val_29);
                val_10 = val_29 + (zz[((long)(int)(((zzOff + 5) + 8))) << 2]);
                mem2[0] = val_10;
                val_21 = zz.Length;
                int val_12 = zzOff + val_38;
                val_12 = val_12 + 9;
                val_8 = val_8 + 1;
                val_10 = val_10 >> 32;
                if(val_8 >= val_21)
            {
                    val_21 = zz.Length;
            }
            
                uint val_31 = val_25[((long)(int)((yOff + 3))) << 2];
                val_31 = val_10 + (val_23 * val_31);
                val_10 = val_31 + (zz[((long)(int)(((zzOff + 5) + 9))) << 2]);
                mem2[0] = val_10;
                val_22 = zz.Length;
                int val_13 = zzOff + val_38;
                val_13 = val_13 + 10;
                val_8 = val_8 + 1;
                val_10 = val_10 >> 32;
                if(val_8 >= val_22)
            {
                    val_22 = zz.Length;
            }
            
                uint val_33 = val_25[((long)(int)((yOff + 4))) << 2];
                val_33 = val_10 + (val_23 * val_33);
                val_10 = val_33 + (zz[((long)(int)(((zzOff + 5) + 10))) << 2]);
                mem2[0] = val_10;
                val_23 = zz.Length;
                int val_14 = zzOff + val_38;
                val_14 = val_14 + 11;
                val_8 = val_8 + 1;
                val_10 = val_10 >> 32;
                if(val_8 >= val_23)
            {
                    val_23 = zz.Length;
            }
            
                uint val_35 = val_25[((long)(int)((yOff + 5))) << 2];
                val_35 = val_10 + (val_23 * val_35);
                val_10 = val_35 + (zz[((long)(int)(((zzOff + 5) + 11))) << 2]);
                mem2[0] = val_10;
                val_24 = zz.Length;
                int val_15 = zzOff + val_38;
                val_15 = val_15 + 12;
                val_10 = val_10 >> 32;
                if((val_8 + 1) >= val_24)
            {
                    val_24 = zz.Length;
            }
            
                val_35 = val_10 + val_37;
                val_37 = val_35 + (zz[((long)(int)(((zzOff + 5) + 12))) << 2]);
                mem2[0] = val_37;
                val_38 = val_38 + 1;
                val_37 = val_37 >> 32;
            }
            while(val_38 != 0);
            
            return (uint)val_37;
        }
        public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_26 = x[((long)(int)(xOff)) << 2];
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + (val_26 * w);
            z[((long)(int)(zOff)) << 2] = val_1;
            int val_2 = xOff + 1;
            uint val_3 = val_1 >> 32;
            uint val_28 = x[((long)(int)((xOff + 1))) << 2];
            int val_4 = yOff + 1;
            uint val_5 = val_3 + val_26;
            int val_6 = zOff + 1;
            val_5 = val_5 + (val_28 * w);
            val_26 = val_5 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_26;
            int val_7 = xOff + 2;
            val_3 = val_26 >> 32;
            uint val_30 = x[((long)(int)((xOff + 2))) << 2];
            int val_8 = yOff + 2;
            uint val_9 = val_3 + val_28;
            int val_10 = zOff + 2;
            val_9 = val_9 + (val_30 * w);
            val_28 = val_9 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_28;
            int val_11 = xOff + 3;
            val_3 = val_28 >> 32;
            uint val_32 = x[((long)(int)((xOff + 3))) << 2];
            int val_12 = yOff + 3;
            uint val_13 = val_3 + val_30;
            int val_14 = zOff + 3;
            val_13 = val_13 + (val_32 * w);
            val_30 = val_13 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_30;
            int val_15 = xOff + 4;
            val_3 = val_30 >> 32;
            uint val_34 = x[((long)(int)((xOff + 4))) << 2];
            int val_16 = yOff + 4;
            uint val_17 = val_3 + val_32;
            int val_18 = zOff + 4;
            val_17 = val_17 + (val_34 * w);
            val_32 = val_17 + (y[((long)(int)((yOff + 4))) << 2]);
            z[((long)(int)((zOff + 4))) << 2] = val_32;
            int val_19 = xOff + 5;
            uint val_36 = x[((long)(int)((xOff + 5))) << 2];
            int val_20 = yOff + 5;
            uint val_22 = (val_32 >> 32) + val_34;
            int val_23 = zOff + 5;
            val_22 = val_22 + (val_36 * w);
            uint val_24 = val_22 + (y[((long)(int)((yOff + 5))) << 2]);
            z[((long)(int)((zOff + 5))) << 2] = val_24;
            return (ulong)val_36 + (val_24 >> 32);
        }
        public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
        {
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            uint val_15 = yy[((long)(int)(yyOff)) << 2];
            val_15 = zz.Length;
            if(val_15 <= zzOff)
            {
                    val_15 = zz.Length;
            }
            
            val_15 = (zz[((long)(int)(zzOff)) << 2]) + (val_15 * x);
            mem2[0] = val_15;
            int val_1 = yyOff + 1;
            val_16 = zz.Length;
            val_15 = val_15 >> 32;
            if((zzOff + 1) >= val_16)
            {
                    val_16 = zz.Length;
            }
            
            uint val_3 = val_15 + ((yy[((long)(int)((yyOff + 1))) << 2]) * x);
            val_15 = val_3 + (zz[((long)(int)((zzOff + 1))) << 2]);
            mem2[0] = val_15;
            int val_4 = yyOff + 2;
            val_17 = zz.Length;
            val_15 = val_15 >> 32;
            if((zzOff + 2) >= val_17)
            {
                    val_17 = zz.Length;
            }
            
            val_3 = val_15 + ((yy[((long)(int)((yyOff + 2))) << 2]) * x);
            val_15 = val_3 + (zz[((long)(int)((zzOff + 2))) << 2]);
            mem2[0] = val_15;
            int val_6 = yyOff + 3;
            val_18 = zz.Length;
            val_15 = val_15 >> 32;
            if((zzOff + 3) >= val_18)
            {
                    val_18 = zz.Length;
            }
            
            val_3 = val_15 + ((yy[((long)(int)((yyOff + 3))) << 2]) * x);
            val_15 = val_3 + (zz[((long)(int)((zzOff + 3))) << 2]);
            mem2[0] = val_15;
            int val_8 = yyOff + 4;
            val_19 = zz.Length;
            val_15 = val_15 >> 32;
            if((zzOff + 4) >= val_19)
            {
                    val_19 = zz.Length;
            }
            
            val_3 = val_15 + ((yy[((long)(int)((yyOff + 4))) << 2]) * x);
            val_15 = val_3 + (zz[((long)(int)((zzOff + 4))) << 2]);
            mem2[0] = val_15;
            int val_10 = yyOff + 5;
            val_20 = zz.Length;
            if((zzOff + 5) >= val_20)
            {
                    val_20 = zz.Length;
            }
            
            val_3 = (val_15 >> 32) + ((yy[((long)(int)((yyOff + 5))) << 2]) * x);
            uint val_13 = val_3 + (zz[((long)(int)((zzOff + 5))) << 2]);
            mem2[0] = val_13;
            return (uint)val_13 >> 32;
        }
        public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
        {
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            ulong val_9 = y;
            uint val_11 = x;
            val_8 = z.Length;
            ulong val_1 = val_9 & 4294967295;
            if(val_8 <= zOff)
            {
                    val_8 = z.Length;
            }
            
            ulong val_2 = (z[((long)(int)(zOff)) << 2]) + (val_1 * val_11);
            mem2[0] = val_2;
            val_9 = z.Length;
            val_2 = val_2 >> 32;
            val_9 = val_9 >> 32;
            if((zOff + 1) >= val_9)
            {
                    val_9 = z.Length;
            }
            
            ulong val_4 = val_1 + (val_9 * val_11);
            val_4 = val_4 + val_2;
            val_11 = val_4 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_11;
            val_10 = z.Length;
            val_1 = val_11 >> 32;
            if((zOff + 2) >= val_10)
            {
                    val_10 = z.Length;
            }
            
            val_4 = val_1 + val_9;
            val_9 = val_4 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_9;
            val_11 = z.Length;
            val_9 = val_9 >> 32;
            if((zOff + 3) >= val_11)
            {
                    val_11 = z.Length;
            }
            
            val_9 = val_9 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_9;
            if((val_9 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  6, z:  z, zOff:  zOff, zPos:  4);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  6, z:  z, zOff:  zOff, zPos:  3);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  6, z:  z, zOff:  zOff, zPos:  3);
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
            while(val_3 != 6);
            
            return (uint)val_2;
        }
        public static void Square(uint[] x, uint[] zz)
        {
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            int val_27;
            uint val_27 = x[0];
            var val_29 = 0;
            do
            {
                var val_2 = val_29 + 11;
                uint val_3 = x[2] * x[2];
                zz[0] = val_3 >> 33;
                var val_5 = val_29 + 10;
                zz[0] = val_3 >> 1;
                var val_7 = 13 - 1;
                val_29 = val_29 - 2;
            }
            while((13 - 8) > 1);
            
            uint val_8 = val_27 * val_27;
            zz[0] = val_8;
            uint val_9 = val_8 >> 33;
            val_23 = zz.Length;
            uint val_30 = x[0];
            if(val_23 <= 2)
            {
                    val_23 = zz.Length;
            }
            
            uint val_31 = zz[1];
            uint val_10 = val_9 + (val_30 * val_27);
            zz[0] = (ulong)(val_8 >> 32) & 1;
            val_24 = zz.Length;
            uint val_32 = x[1];
            if(val_24 <= 3)
            {
                    val_24 = zz.Length;
            }
            
            val_9 = val_10 >> 31;
            val_31 = val_31 + (val_10 >> 32);
            if(val_24 <= 4)
            {
                    val_24 = zz.Length;
            }
            
            val_31 = val_31 + (val_32 * val_27);
            zz[1] = val_9;
            uint val_12 = (val_32 * val_30) + (val_31 >> 32);
            val_25 = zz.Length;
            uint val_35 = x[1];
            val_12 = val_12 + zz[1];
            if(val_25 <= 5)
            {
                    val_25 = zz.Length;
            }
            
            val_27 = val_31 >> 31;
            val_31 = val_12 & 4294967295;
            if(val_25 <= 6)
            {
                    val_25 = zz.Length;
            }
            
            val_12 = val_12 >> 32;
            val_31 = val_31 + (val_35 * val_27);
            zz[1] = val_27;
            uint val_13 = val_12 + zz[2];
            val_13 = val_13 + (val_35 * val_30);
            val_12 = val_13 + (val_31 >> 32);
            val_32 = val_35 * val_32;
            val_26 = zz.Length;
            uint val_38 = x[2];
            val_32 = val_32 + (val_12 >> 32);
            if(val_26 <= 7)
            {
                    val_26 = zz.Length;
            }
            
            val_30 = val_32 + zz[2];
            val_31 = val_12 & 4294967295;
            if(val_26 <= 8)
            {
                    val_26 = zz.Length;
            }
            
            val_32 = val_30 >> 32;
            val_12 = val_30 & 4294967295;
            val_31 = val_31 + (val_38 * val_27);
            zz[2] = val_31 >> 31;
            uint val_41 = val_30;
            uint val_42 = zz[3];
            val_41 = val_12 + (val_38 * val_41);
            val_12 = val_41 + (val_31 >> 32);
            val_42 = val_32 + val_42;
            val_42 = val_42 + (val_38 * val_32);
            uint val_15 = val_42 + (val_12 >> 32);
            uint val_16 = val_38 * val_35;
            val_27 = zz.Length;
            uint val_43 = x[2];
            val_16 = val_16 + (val_15 >> 32);
            if(val_27 <= 9)
            {
                    val_27 = zz.Length;
            }
            
            uint val_44 = zz[4];
            val_30 = val_16 + zz[3];
            val_31 = val_31 >> 31;
            if(val_27 <= 10)
            {
                    val_27 = zz.Length;
            }
            
            uint val_18 = val_15 & 4294967295;
            val_12 = val_30 >> 32;
            val_30 = val_30 & 4294967295;
            if(val_27 <= 5)
            {
                    val_27 = zz.Length;
            }
            
            zz[2] = val_31;
            uint val_47 = val_32;
            uint val_46 = val_30;
            uint val_48 = zz[4];
            val_46 = val_18 + (val_43 * val_46);
            val_47 = val_30 + (val_43 * val_47);
            val_48 = val_12 + val_48;
            val_38 = val_46 + (((val_12 & 4294967295) + (val_43 * val_27)) >> 32);
            val_18 = val_47 + (val_38 >> 32);
            val_12 = (val_48 + (val_43 * val_35)) + (val_18 >> 32);
            if(val_27 <= 6)
            {
                    val_27 = zz.Length;
            }
            
            zz[3] = val_43;
            if(val_27 <= 7)
            {
                    val_27 = zz.Length;
            }
            
            zz[3] = val_35;
            uint val_24 = zz[5];
            if(val_27 <= 8)
            {
                    val_27 = zz.Length;
            }
            
            zz[4] = val_18;
            if(val_27 <= 9)
            {
                    val_27 = zz.Length;
            }
            
            zz[4] = val_12;
            if(val_27 <= 10)
            {
                    val_27 = zz.Length;
            }
            
            zz[5] = (val_43 * val_38) + (val_12 >> 32);
            if(val_27 <= 11)
            {
                    val_27 = zz.Length;
            }
            
            uint val_49 = zz[5];
            val_49 = val_49 + (val_24 >> 32);
            zz[5] = val_24 >> 31;
        }
        public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
        {
            int val_42;
            int val_43;
            int val_44;
            var val_45;
            int val_46;
            var val_47;
            int val_48;
            var val_49;
            var val_50;
            int val_51;
            uint val_42 = x[((long)(int)(xOff)) << 2];
            int val_2 = zzOff + 11;
            var val_44 = 6;
            do
            {
                int val_3 = (xOff + 5) + val_44;
                val_3 = val_3 - 6;
                uint val_4 = (x[((long)(int)((((xOff + 5) + 6) - 6))) << 2]) * (x[((long)(int)((((xOff + 5) + 6) - 6))) << 2]);
                zz[((long)(int)((zzOff + 11))) << 2] = val_4 >> 33;
                int val_6 = val_2 - 1;
                val_44 = val_44 - 1;
                val_2 = val_2 - 2;
                zz[((long)(int)(((zzOff + 11) - 1))) << 2] = val_4 >> 1;
            }
            while(val_44 > 1);
            
            uint val_8 = val_42 * val_42;
            zz[((long)(int)(zzOff)) << 2] = val_8;
            int val_9 = xOff + 1;
            uint val_10 = val_8 >> 33;
            val_42 = zz.Length;
            uint val_45 = x[((long)(int)((xOff + 1))) << 2];
            if((zzOff + 2) >= val_42)
            {
                    val_42 = zz.Length;
            }
            
            val_45 = val_10 + (val_45 * val_42);
            int val_12 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = (ulong)(val_8 >> 32) & 1;
            int val_13 = xOff + 2;
            uint val_47 = x[((long)(int)((xOff + 2))) << 2];
            val_43 = zz.Length;
            if((zzOff + 3) >= val_43)
            {
                    val_43 = zz.Length;
            }
            
            val_10 = val_45 >> 31;
            val_45 = (zz[((long)(int)((zzOff + 2))) << 2]) + (val_45 >> 32);
            uint val_48 = zz[((long)(int)((zzOff + 3))) << 2];
            if((zzOff + 4) >= val_43)
            {
                    val_43 = zz.Length;
            }
            
            val_45 = val_45 + (val_47 * val_42);
            mem2[0] = val_10;
            uint val_50 = val_45;
            val_50 = val_47 * val_50;
            int val_51 = xOff;
            val_51 = val_51 + 3;
            uint val_52 = x[((long)(int)((xOff + 3))) << 2];
            val_44 = zz.Length;
            val_48 = (val_50 + (val_45 >> 32)) + val_48;
            if((zzOff + 5) >= val_44)
            {
                    val_44 = zz.Length;
            }
            
            val_45 = val_48 & 4294967295;
            int val_19 = zzOff + 6;
            val_45 = (long)val_19;
            if(val_19 >= val_44)
            {
                    val_44 = zz.Length;
                val_45 = val_45;
            }
            
            val_45 = val_45 + (val_52 * val_42);
            mem2[0] = val_45 >> 31;
            uint val_55 = zz[((long)(int)((zzOff + 4))) << 2];
            val_55 = (val_48 >> 32) + val_55;
            val_55 = val_55 + (val_52 * val_45);
            uint val_21 = val_55 + (val_45 >> 32);
            uint val_22 = val_52 * val_47;
            int val_56 = xOff;
            val_56 = val_56 + 4;
            val_46 = zz.Length;
            uint val_57 = x[((long)(int)((xOff + 4))) << 2];
            int val_23 = zzOff + 7;
            val_22 = val_22 + (val_21 >> 32);
            val_47 = (long)val_23;
            if(val_23 >= val_46)
            {
                    val_46 = zz.Length;
                val_47 = val_47;
            }
            
            uint val_24 = val_22 + (zz[((long)(int)((zzOff + 5))) << 2]);
            uint val_58 = zz[((long)(int)((zzOff + 7))) << 2];
            val_21 = val_21 & 4294967295;
            if((zzOff + 8) >= val_46)
            {
                    val_46 = zz.Length;
            }
            
            val_22 = val_24 >> 32;
            val_24 = val_24 & 4294967295;
            uint val_27 = val_21 + (val_57 * val_42);
            mem2[0] = val_45 >> 31;
            uint val_60 = val_45;
            uint val_61 = zz[((long)(int)((zzOff + 6))) << 2];
            val_60 = val_24 + (val_57 * val_60);
            val_21 = val_60 + (val_27 >> 32);
            uint val_62 = val_47;
            val_61 = val_22 + val_61;
            val_62 = val_61 + (val_57 * val_62);
            uint val_28 = val_62 + (val_21 >> 32);
            uint val_29 = val_57 * val_52;
            int val_63 = xOff;
            val_63 = val_63 + 5;
            val_48 = zz.Length;
            uint val_64 = x[((long)(int)((xOff + 5))) << 2];
            int val_30 = zzOff + 9;
            val_29 = val_29 + (val_28 >> 32);
            val_49 = (long)val_30;
            if(val_30 >= val_48)
            {
                    val_48 = zz.Length;
                val_49 = val_49;
            }
            
            uint val_31 = val_21 & 4294967295;
            val_58 = val_29 + val_58;
            val_27 = val_27 >> 31;
            int val_32 = zzOff + 10;
            val_50 = (long)val_32;
            if(val_32 >= val_48)
            {
                    val_48 = zz.Length;
                val_50 = val_50;
            }
            
            uint val_33 = val_28 & 4294967295;
            uint val_34 = val_58 >> 32;
            val_28 = val_58 & 4294967295;
            val_31 = val_31 + (val_64 * val_42);
            mem2[0] = val_27;
            uint val_67 = val_45;
            uint val_68 = val_47;
            uint val_69 = zz[((long)(int)((zzOff + 8))) << 2];
            val_67 = val_33 + (val_64 * val_67);
            val_33 = val_67 + (val_31 >> 32);
            uint val_70 = val_52;
            val_68 = val_28 + (val_64 * val_68);
            val_69 = val_34 + val_69;
            uint val_35 = val_68 + (val_33 >> 32);
            val_70 = val_69 + (val_64 * val_70);
            val_34 = val_70;
            val_64 = (val_64 * val_57) + (val_34 >> 32);
            mem2[0] = val_31;
            val_64 = val_64 + (zz[((long)(int)((zzOff + 9))) << 2]);
            mem2[0] = val_33;
            uint val_37 = (zz[((long)(int)((zzOff + 10))) << 2]) + (val_64 >> 32);
            mem2[0] = val_33;
            mem2[0] = val_33;
            mem2[0] = val_33;
            val_51 = zz.Length;
            if((zzOff + 11) >= val_51)
            {
                    val_51 = zz.Length;
            }
            
            uint val_40 = val_37 >> 32;
            uint val_41 = zz[((long)(int)((zzOff + 11))) << 2];
            mem2[0] = val_37 >> 31;
        }
        public static int Sub(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_14 = y;
            uint val_2 = x[0];
            val_2 = val_2 - val_14[0];
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_14[0];
            val_5 = x[0] - val_5;
            val_2 = val_5 + val_2;
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_14[1];
            val_7 = x[1] - val_7;
            val_2 = val_7 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_14[1];
            val_9 = x[1] - val_9;
            val_2 = val_9 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_14[2];
            val_11 = x[2] - val_11;
            val_2 = val_11 + val_2;
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_13 = val_14[2];
            val_13 = x[2] - val_13;
            val_14 = val_13 + val_2;
            z[2] = val_14;
            return (int)val_14 >> 32;
        }
        public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_19 = x[((long)(int)(xOff)) << 2];
            val_19 = val_19 - (y[((long)(int)(yOff)) << 2]);
            z[((long)(int)(zOff)) << 2] = val_19;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_19 = val_19 >> 32;
            uint val_22 = y[((long)(int)((yOff + 1))) << 2];
            int val_3 = zOff + 1;
            val_22 = (x[((long)(int)((xOff + 1))) << 2]) - val_22;
            val_19 = val_22 + val_19;
            z[((long)(int)((zOff + 1))) << 2] = val_19;
            int val_4 = xOff + 2;
            int val_5 = yOff + 2;
            val_19 = val_19 >> 32;
            uint val_24 = y[((long)(int)((yOff + 2))) << 2];
            int val_6 = zOff + 2;
            val_24 = (x[((long)(int)((xOff + 2))) << 2]) - val_24;
            val_19 = val_24 + val_19;
            z[((long)(int)((zOff + 2))) << 2] = val_19;
            int val_7 = xOff + 3;
            int val_8 = yOff + 3;
            val_19 = val_19 >> 32;
            uint val_26 = y[((long)(int)((yOff + 3))) << 2];
            int val_9 = zOff + 3;
            val_26 = (x[((long)(int)((xOff + 3))) << 2]) - val_26;
            val_19 = val_26 + val_19;
            z[((long)(int)((zOff + 3))) << 2] = val_19;
            int val_10 = xOff + 4;
            int val_11 = yOff + 4;
            val_19 = val_19 >> 32;
            uint val_28 = y[((long)(int)((yOff + 4))) << 2];
            int val_12 = zOff + 4;
            val_28 = (x[((long)(int)((xOff + 4))) << 2]) - val_28;
            val_19 = val_28 + val_19;
            z[((long)(int)((zOff + 4))) << 2] = val_19;
            int val_13 = xOff + 5;
            int val_14 = yOff + 5;
            uint val_30 = y[((long)(int)((yOff + 5))) << 2];
            int val_16 = zOff + 5;
            val_30 = (x[((long)(int)((xOff + 5))) << 2]) - val_30;
            uint val_17 = val_30 + (val_19 >> 32);
            z[((long)(int)((zOff + 5))) << 2] = val_17;
            return (int)val_17 >> 32;
        }
        public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            System.UInt32[] val_21 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            uint val_1 = val_3 - x[0];
            val_3 = val_1 - val_21[0];
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            val_1 = val_3 + z[0];
            val_1 = val_1 - x[0];
            val_3 = val_1 - val_21[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_21[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_6 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_21[1];
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_7 = z.Length;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_3 = val_1 - val_21[2];
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_21 = val_1 - val_21[2];
            z[2] = val_21;
            return (int)val_21 >> 32;
        }
        public static int SubFrom(uint[] x, uint[] z)
        {
            int val_2;
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            System.UInt32[] val_14 = x;
            uint val_2 = z[0];
            val_2 = z.Length;
            val_2 = val_2 - val_14[0];
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_14[0];
            val_3 = z.Length;
            val_5 = z[0] - val_5;
            val_2 = val_5 + val_2;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_14[1];
            val_4 = z.Length;
            val_7 = z[1] - val_7;
            val_2 = val_7 + val_2;
            if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_14[1];
            val_5 = z.Length;
            val_9 = z[1] - val_9;
            val_2 = val_9 + val_2;
            if(val_5 <= 3)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_14[2];
            val_6 = z.Length;
            val_11 = z[2] - val_11;
            val_2 = val_11 + val_2;
            if(val_6 <= 4)
            {
                    val_6 = z.Length;
            }
            
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_13 = val_14[2];
            val_13 = z[2] - val_13;
            val_14 = val_13 + val_2;
            z[2] = val_14;
            return (int)val_14 >> 32;
        }
        public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
        {
            System.UInt32[] val_25 = z;
            uint val_1 = (val_25[((long)(int)(zOff)) << 2]) - (x[((long)(int)(xOff)) << 2]);
            mem2[0] = val_1;
            int val_2 = zOff + 1;
            int val_3 = xOff + 1;
            val_1 = val_1 >> 32;
            uint val_16 = x[((long)(int)((xOff + 1))) << 2];
            val_16 = (val_25[((long)(int)((zOff + 1))) << 2]) - val_16;
            val_1 = val_16 + val_1;
            mem2[0] = val_1;
            int val_4 = zOff + 2;
            int val_5 = xOff + 2;
            val_1 = val_1 >> 32;
            uint val_18 = x[((long)(int)((xOff + 2))) << 2];
            val_18 = (val_25[((long)(int)((zOff + 2))) << 2]) - val_18;
            val_1 = val_18 + val_1;
            mem2[0] = val_1;
            int val_6 = zOff + 3;
            int val_7 = xOff + 3;
            val_1 = val_1 >> 32;
            uint val_20 = x[((long)(int)((xOff + 3))) << 2];
            val_20 = (val_25[((long)(int)((zOff + 3))) << 2]) - val_20;
            val_1 = val_20 + val_1;
            mem2[0] = val_1;
            int val_8 = zOff + 4;
            int val_9 = xOff + 4;
            val_1 = val_1 >> 32;
            uint val_22 = x[((long)(int)((xOff + 4))) << 2];
            val_22 = (val_25[((long)(int)((zOff + 4))) << 2]) - val_22;
            val_1 = val_22 + val_1;
            mem2[0] = val_1;
            int val_10 = zOff + 5;
            int val_11 = xOff + 5;
            val_1 = val_1 >> 32;
            uint val_24 = x[((long)(int)((xOff + 5))) << 2];
            val_24 = (val_25[((long)(int)((zOff + 5))) << 2]) - val_24;
            val_25 = val_24 + val_1;
            mem2[0] = val_25;
            return (int)val_25 >> 32;
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
        {
            byte[] val_1 = new byte[24];
            var val_4 = 0;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  1134694512, bs:  val_1, off:  20);
            }
            
                val_4 = val_4 + 1;
                var val_2 = 20 - 4;
            }
            while(val_4 != 6);
            
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1);
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
        {
            byte[] val_1 = new byte[24];
            var val_3 = 0;
            var val_4 = 16;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  null, bs:  val_1, off:  16);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 8;
            }
            while(val_3 != 3);
            
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
            if(val_1 <= 3)
            {
                    val_1 = z.Length;
            }
            
            z[1] = 0;
            if(val_1 <= 4)
            {
                    val_1 = z.Length;
            }
            
            z[2] = 0;
            z[2] = 0;
        }
        protected Nat192()
        {
        
        }
    
    }

}
