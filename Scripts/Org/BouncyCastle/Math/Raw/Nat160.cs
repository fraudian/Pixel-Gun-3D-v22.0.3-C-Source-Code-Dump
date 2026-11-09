using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat160
    {
        // Fields
        private const ulong M = 4294967295;
        
        // Methods
        public static uint Add(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_13 = y;
            uint val_3 = x[0];
            val_3 = val_13[0] + val_3;
            z[0] = val_3;
            val_3 = val_3 >> 32;
            uint val_1 = val_3 + x[0];
            val_3 = val_1 + val_13[0];
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_13[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_13[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_13 = val_1 + val_13[2];
            z[2] = val_13;
            return (uint)val_13 >> 32;
        }
        public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
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
            uint val_16 = y[2];
            val_3 = val_3 >> 32;
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            val_1 = val_3 + x[2];
            val_1 = val_1 + val_16;
            val_16 = val_1 + z[2];
            z[2] = val_16;
            return (uint)val_16 >> 32;
        }
        public static uint AddTo(uint[] x, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
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
            uint val_11 = x[2];
            val_3 = val_3 >> 32;
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            val_1 = val_3 + val_11;
            val_11 = val_1 + z[2];
            z[2] = val_11;
            return (uint)val_11 >> 32;
        }
        public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
        {
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            uint val_16 = cIn;
            val_14 = z.Length;
            if(val_14 <= zOff)
            {
                    val_14 = z.Length;
            }
            
            uint val_1 = (x[((long)(int)(xOff)) << 2]) + val_16;
            val_16 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_16;
            int val_2 = xOff + 1;
            val_15 = z.Length;
            val_16 = val_16 >> 32;
            if((zOff + 1) >= val_15)
            {
                    val_15 = z.Length;
            }
            
            val_1 = val_16 + (x[((long)(int)((xOff + 1))) << 2]);
            val_16 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_16;
            int val_4 = xOff + 2;
            val_16 = z.Length;
            val_16 = val_16 >> 32;
            if((zOff + 2) >= val_16)
            {
                    val_16 = z.Length;
            }
            
            val_1 = val_16 + (x[((long)(int)((xOff + 2))) << 2]);
            val_16 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_16;
            int val_6 = xOff + 3;
            val_17 = z.Length;
            val_16 = val_16 >> 32;
            if((zOff + 3) >= val_17)
            {
                    val_17 = z.Length;
            }
            
            val_1 = val_16 + (x[((long)(int)((xOff + 3))) << 2]);
            val_16 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_16;
            int val_8 = xOff + 4;
            val_18 = z.Length;
            val_16 = val_16 >> 32;
            if((zOff + 4) >= val_18)
            {
                    val_18 = z.Length;
            }
            
            val_1 = val_16 + (x[((long)(int)((xOff + 4))) << 2]);
            val_16 = val_1 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_16;
            int val_10 = xOff + 5;
            val_16 = val_16 >> 32;
            int val_11 = zOff + 5;
            return (uint)(val_16 + (x[((long)(int)((xOff + 5))) << 2])) + (z[((long)(int)((zOff + 5))) << 2]);
        }
        public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
        {
            System.UInt32[] val_22 = u;
            uint val_12 = val_22[((long)(int)(uOff)) << 2];
            val_12 = (v[((long)(int)(vOff)) << 2]) + val_12;
            mem2[0] = val_12;
            mem2[0] = val_12;
            int val_1 = uOff + 1;
            int val_2 = vOff + 1;
            val_12 = val_12 >> 32;
            uint val_3 = val_12 + (val_22[((long)(int)((uOff + 1))) << 2]);
            val_12 = val_3 + (v[((long)(int)((vOff + 1))) << 2]);
            mem2[0] = val_12;
            mem2[0] = val_12;
            int val_4 = uOff + 2;
            int val_5 = vOff + 2;
            val_12 = val_12 >> 32;
            val_3 = val_12 + (val_22[((long)(int)((uOff + 2))) << 2]);
            val_12 = val_3 + (v[((long)(int)((vOff + 2))) << 2]);
            mem2[0] = val_12;
            mem2[0] = val_12;
            int val_6 = uOff + 3;
            int val_7 = vOff + 3;
            val_12 = val_12 >> 32;
            val_3 = val_12 + (val_22[((long)(int)((uOff + 3))) << 2]);
            val_12 = val_3 + (v[((long)(int)((vOff + 3))) << 2]);
            mem2[0] = val_12;
            mem2[0] = val_12;
            int val_8 = uOff + 4;
            int val_9 = vOff + 4;
            val_3 = (val_12 >> 32) + (val_22[((long)(int)((uOff + 4))) << 2]);
            val_22 = val_3 + (v[((long)(int)((vOff + 4))) << 2]);
            mem2[0] = val_22;
            mem2[0] = val_22;
            return (uint)val_22 >> 32;
        }
        public static void Copy(uint[] x, uint[] z)
        {
            z[0] = x[0];
            z[0] = x[0];
            z[1] = x[1];
            z[1] = x[1];
            z[2] = x[2];
        }
        public static uint[] Create()
        {
            uint[] val_1 = new uint[5];
        }
        public static uint[] CreateExt()
        {
            uint[] val_1 = new uint[10];
        }
        public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat160.Gte(x:  x, xOff:  xOff, y:  y, yOff:  yOff)) != false)
            {
                    int val_2 = Org.BouncyCastle.Math.Raw.Nat160.Sub(x:  x, xOff:  xOff, y:  y, yOff:  yOff, z:  z, zOff:  zOff);
                val_4 = 1;
                return (bool)val_4;
            }
            
            int val_3 = Org.BouncyCastle.Math.Raw.Nat160.Sub(x:  y, xOff:  yOff, y:  x, yOff:  xOff, z:  z, zOff:  zOff);
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool Eq(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 12;
            label_5:
            if(x[2] != y[2])
            {
                goto label_4;
            }
            
            val_1 = val_1 - 1;
            if(4 > 0)
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
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 161))
            {
                goto label_4;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat160.Create();
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
        public static uint GetBit(uint[] x, int bit)
        {
            var val_4;
            uint val_5;
            int val_3 = bit;
            if(val_3 != 0)
            {
                    val_4 = 0;
                if((val_3 >> 5) > 4)
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
            val_1 = 12;
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
            
            val_1 = val_1 - 1;
            if(((val_1 - 9) & 2147483648) == 0)
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
            val_3 = 4;
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
            if(val_3 < 4)
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
            if(val_1 < 4)
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
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            val_6 = y.Length;
            if(val_6 == 0)
            {
                    val_6 = y.Length;
            }
            
            uint val_8 = y[0];
            if(val_6 <= 1)
            {
                    val_6 = y.Length;
            }
            
            uint val_9 = y[0];
            if(val_6 <= 2)
            {
                    val_6 = y.Length;
            }
            
            uint val_10 = y[1];
            if(val_6 <= 3)
            {
                    val_6 = y.Length;
            }
            
            uint val_11 = y[1];
            uint val_12 = y[2];
            uint val_13 = x[0];
            uint val_1 = val_13 * val_8;
            val_7 = zz.Length;
            if(val_7 == 0)
            {
                    val_7 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_14 = val_9;
            val_14 = val_13 * val_14;
            val_1 = val_14 + (val_1 >> 32);
            if(val_7 <= 1)
            {
                    val_7 = zz.Length;
            }
            
            zz[0] = val_1;
            val_1 = (val_13 * val_10) + (val_1 >> 32);
            if(val_7 <= 2)
            {
                    val_7 = zz.Length;
            }
            
            zz[1] = val_1;
            val_1 = (val_13 * val_11) + (val_1 >> 32);
            if(val_7 <= 3)
            {
                    val_7 = zz.Length;
            }
            
            zz[1] = val_1;
            val_1 = (val_13 * val_12) + (val_1 >> 32);
            if(val_7 <= 4)
            {
                    val_7 = zz.Length;
            }
            
            zz[2] = val_1;
            val_1 = val_1 >> 32;
            zz[2] = val_1;
            do
            {
                var val_5 = 9 - 8;
                val_8 = zz.Length;
                uint val_15 = x[0];
                if(val_5 >= val_8)
            {
                    val_8 = zz.Length;
            }
            
                uint val_6 = null + (val_15 * val_8);
                mem2[0] = val_6;
                val_9 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_16 = val_9;
                val_16 = val_6 + (val_15 * val_16);
                val_6 = val_16 + 1152921505741541488;
                mem2[0] = val_6;
                val_10 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                val_16 = val_6 + (val_15 * val_10);
                val_6 = val_16 + 1152921505741541488;
                mem2[0] = val_6;
                val_11 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                val_16 = val_6 + (val_15 * val_11);
                val_6 = val_16 + 1152921505741541488;
                mem2[0] = val_6;
                val_12 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                val_16 = val_6 + (val_15 * val_12);
                val_6 = val_16 + 1152921505741541488;
                mem2[0] = val_6;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                mem2[0] = val_6;
                var val_7 = 9 + 1;
            }
            while(val_5 != 9);
        
        }
        public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_29;
            int val_30;
            int val_31;
            int val_32;
            int val_33;
            int val_34;
            int val_38 = xOff;
            val_29 = y.Length;
            if(val_29 <= yOff)
            {
                    val_29 = y.Length;
            }
            
            uint val_29 = y[((long)(int)(yOff)) << 2];
            if((yOff + 1) >= val_29)
            {
                    val_29 = y.Length;
            }
            
            uint val_30 = y[((long)(int)((yOff + 1))) << 2];
            if((yOff + 2) >= val_29)
            {
                    val_29 = y.Length;
            }
            
            uint val_31 = y[((long)(int)((yOff + 2))) << 2];
            if((yOff + 3) >= val_29)
            {
                    val_29 = y.Length;
            }
            
            uint val_32 = y[((long)(int)((yOff + 3))) << 2];
            int val_4 = yOff + 4;
            uint val_33 = y[((long)(int)((yOff + 4))) << 2];
            uint val_34 = x[((long)(int)(xOff)) << 2];
            uint val_5 = val_34 * val_29;
            zz[((long)(int)(zzOff)) << 2] = val_5;
            uint val_35 = val_30;
            val_35 = val_34 * val_35;
            val_5 = val_35 + (val_5 >> 32);
            int val_6 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = val_5;
            uint val_36 = val_31;
            val_36 = val_34 * val_36;
            val_5 = val_36 + (val_5 >> 32);
            int val_7 = zzOff + 2;
            zz[((long)(int)((zzOff + 2))) << 2] = val_5;
            uint val_37 = val_32;
            val_37 = val_34 * val_37;
            val_5 = val_37 + (val_5 >> 32);
            int val_8 = zzOff + 3;
            zz[((long)(int)((zzOff + 3))) << 2] = val_5;
            val_34 = (val_34 * val_33) + (val_5 >> 32);
            int val_10 = zzOff + 4;
            zz[((long)(int)((zzOff + 4))) << 2] = val_34;
            int val_11 = zzOff + 5;
            val_34 = val_34 >> 32;
            val_38 = val_38 + 1;
            zz[((long)(int)((zzOff + 5))) << 2] = val_34;
            var val_48 = -4;
            do
            {
                int val_14 = val_38 + val_48;
                val_14 = val_14 + 4;
                val_30 = zz.Length;
                uint val_39 = x[((long)(int)((((xOff + 1) + -4) + 4))) << 2];
                if(((zzOff + val_48) + 5) >= val_30)
            {
                    val_30 = zz.Length;
            }
            
                uint val_15 = (zz[((long)(int)(((zzOff + -4) + 5))) << 2]) + (val_39 * val_29);
                mem2[0] = val_15;
                val_31 = zz.Length;
                uint val_17 = val_15 >> 32;
                if(((zzOff + val_48) + 6) >= val_31)
            {
                    val_31 = zz.Length;
            }
            
                uint val_42 = val_30;
                val_42 = val_17 + (val_39 * val_42);
                uint val_19 = val_42 + (zz[((long)(int)(((zzOff + -4) + 6))) << 2]);
                mem2[0] = val_19;
                val_32 = zz.Length;
                val_17 = val_19 >> 32;
                if(((zzOff + val_48) + 7) >= val_32)
            {
                    val_32 = zz.Length;
            }
            
                uint val_44 = val_31;
                val_44 = val_17 + (val_39 * val_44);
                uint val_22 = val_44 + (zz[((long)(int)(((zzOff + -4) + 7))) << 2]);
                mem2[0] = val_22;
                val_33 = zz.Length;
                val_17 = val_22 >> 32;
                if(((zzOff + val_48) + 8) >= val_33)
            {
                    val_33 = zz.Length;
            }
            
                uint val_46 = val_32;
                val_46 = val_17 + (val_39 * val_46);
                uint val_25 = val_46 + (zz[((long)(int)(((zzOff + -4) + 8))) << 2]);
                mem2[0] = val_25;
                val_34 = zz.Length;
                val_17 = val_25 >> 32;
                if(((zzOff + val_48) + 9) >= val_34)
            {
                    val_34 = zz.Length;
            }
            
                val_46 = val_17 + (val_39 * val_33);
                val_39 = val_46 + (zz[((long)(int)(((zzOff + -4) + 9))) << 2]);
                mem2[0] = val_39;
                int val_28 = zzOff + val_48;
                val_28 = val_28 + 10;
                val_39 = val_39 >> 32;
                val_48 = val_48 + 1;
                zz[((long)(int)(((zzOff + -4) + 10))) << 2] = val_39;
            }
            while(val_48 != 0);
        
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
            
            var val_12 = 0;
            do
            {
                val_6 = zz.Length;
                if(val_12 >= val_6)
            {
                    val_6 = zz.Length;
            }
            
                System.UInt32[] val_1 = null + (1152921505741541488 * y[0]);
                mem2[0] = val_1;
                val_7 = zz.Length;
                val_12 = val_12 + 1;
                val_1 = val_1 >> 32;
                if(val_12 >= val_7)
            {
                    val_7 = zz.Length;
            }
            
                uint val_13 = y[0];
                val_13 = val_1 + (1152921505741541488 * val_13);
                mem2[0] = val_1;
                val_8 = zz.Length;
                val_12 = val_12 + 1;
                val_1 = val_1 >> 32;
                if(val_12 >= val_8)
            {
                    val_8 = zz.Length;
            }
            
                uint val_14 = y[1];
                val_14 = val_1 + (1152921505741541488 * val_14);
                mem2[0] = val_1;
                val_9 = zz.Length;
                val_12 = val_12 + 1;
                val_1 = val_1 >> 32;
                if(val_12 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                System.UInt32[] val_2 = val_1 + (1152921505741541488 * y[1]);
                mem2[0] = val_1;
                val_10 = zz.Length;
                val_12 = val_12 + 1;
                val_1 = val_1 >> 32;
                if(val_12 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                System.UInt32[] val_3 = val_1 + (1152921505741541488 * y[2]);
                mem2[0] = val_1;
                val_11 = zz.Length;
                var val_4 = val_12 + 1;
                System.UInt32[] val_5 = val_1 >> 32;
                if(val_4 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                mem2[0] = 0;
            }
            while((val_4 - 4) != 5);
            
            return 0;
        }
        public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            val_14 = y.Length;
            if(val_14 <= yOff)
            {
                    val_14 = y.Length;
            }
            
            if((yOff + 1) >= val_14)
            {
                    val_14 = y.Length;
            }
            
            if((yOff + 2) >= val_14)
            {
                    val_14 = y.Length;
            }
            
            if((yOff + 3) >= val_14)
            {
                    val_14 = y.Length;
            }
            
            int val_4 = yOff + 4;
            uint val_30 = 0;
            var val_31 = -5;
            do
            {
                int val_6 = xOff + val_31;
                val_6 = val_6 + 5;
                int val_7 = (zzOff + val_31) + 5;
                uint val_19 = x[((long)(int)(((xOff + -5) + 5))) << 2];
                val_15 = zz.Length;
                if(val_7 >= val_15)
            {
                    val_15 = zz.Length;
            }
            
                uint val_8 = (zz[((long)(int)(((zzOff + -5) + 5))) << 2]) + (val_19 * (y[((long)(int)(yOff)) << 2]));
                mem2[0] = val_8;
                val_16 = zz.Length;
                int val_9 = zzOff + val_31;
                val_9 = val_9 + 6;
                val_7 = val_7 + 1;
                val_8 = val_8 >> 32;
                if(val_7 >= val_16)
            {
                    val_16 = zz.Length;
            }
            
                uint val_22 = y[((long)(int)((yOff + 1))) << 2];
                val_22 = val_8 + (val_19 * val_22);
                val_8 = val_22 + (zz[((long)(int)(((zzOff + -5) + 6))) << 2]);
                mem2[0] = val_8;
                val_17 = zz.Length;
                int val_10 = zzOff + val_31;
                val_10 = val_10 + 7;
                val_7 = val_7 + 1;
                val_8 = val_8 >> 32;
                if(val_7 >= val_17)
            {
                    val_17 = zz.Length;
            }
            
                uint val_24 = y[((long)(int)((yOff + 2))) << 2];
                val_24 = val_8 + (val_19 * val_24);
                val_8 = val_24 + (zz[((long)(int)(((zzOff + -5) + 7))) << 2]);
                mem2[0] = val_8;
                val_18 = zz.Length;
                int val_11 = zzOff + val_31;
                val_11 = val_11 + 8;
                val_7 = val_7 + 1;
                val_8 = val_8 >> 32;
                if(val_7 >= val_18)
            {
                    val_18 = zz.Length;
            }
            
                uint val_26 = y[((long)(int)((yOff + 3))) << 2];
                val_26 = val_8 + (val_19 * val_26);
                val_8 = val_26 + (zz[((long)(int)(((zzOff + -5) + 8))) << 2]);
                mem2[0] = val_8;
                val_19 = zz.Length;
                int val_12 = zzOff + val_31;
                val_12 = val_12 + 9;
                val_7 = val_7 + 1;
                val_8 = val_8 >> 32;
                if(val_7 >= val_19)
            {
                    val_19 = zz.Length;
            }
            
                uint val_28 = y[((long)(int)((yOff + 4))) << 2];
                val_28 = val_8 + (val_19 * val_28);
                val_19 = val_28 + (zz[((long)(int)(((zzOff + -5) + 9))) << 2]);
                mem2[0] = val_19;
                val_20 = zz.Length;
                int val_13 = zzOff + val_31;
                val_13 = val_13 + 10;
                val_7 = val_7 + 1;
                val_19 = val_19 >> 32;
                if(val_7 >= val_20)
            {
                    val_20 = zz.Length;
            }
            
                val_28 = val_19 + val_30;
                val_30 = val_28 + (zz[((long)(int)(((zzOff + -5) + 10))) << 2]);
                mem2[0] = val_30;
                val_31 = val_31 + 1;
                val_30 = val_30 >> 32;
            }
            while(val_31 != 0);
            
            return (uint)val_30;
        }
        public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_22 = x[((long)(int)(xOff)) << 2];
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + (val_22 * w);
            z[((long)(int)(zOff)) << 2] = val_1;
            int val_2 = xOff + 1;
            uint val_3 = val_1 >> 32;
            uint val_24 = x[((long)(int)((xOff + 1))) << 2];
            int val_4 = yOff + 1;
            uint val_5 = val_3 + val_22;
            int val_6 = zOff + 1;
            val_5 = val_5 + (val_24 * w);
            val_22 = val_5 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_22;
            int val_7 = xOff + 2;
            val_3 = val_22 >> 32;
            uint val_26 = x[((long)(int)((xOff + 2))) << 2];
            int val_8 = yOff + 2;
            uint val_9 = val_3 + val_24;
            int val_10 = zOff + 2;
            val_9 = val_9 + (val_26 * w);
            val_24 = val_9 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_24;
            int val_11 = xOff + 3;
            val_3 = val_24 >> 32;
            uint val_28 = x[((long)(int)((xOff + 3))) << 2];
            int val_12 = yOff + 3;
            uint val_13 = val_3 + val_26;
            int val_14 = zOff + 3;
            val_13 = val_13 + (val_28 * w);
            val_26 = val_13 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_26;
            int val_15 = xOff + 4;
            uint val_30 = x[((long)(int)((xOff + 4))) << 2];
            int val_16 = yOff + 4;
            uint val_18 = (val_26 >> 32) + val_28;
            int val_19 = zOff + 4;
            val_18 = val_18 + (val_30 * w);
            uint val_20 = val_18 + (y[((long)(int)((yOff + 4))) << 2]);
            z[((long)(int)((zOff + 4))) << 2] = val_20;
            return (ulong)val_30 + (val_20 >> 32);
        }
        public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
        {
            int val_13;
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            uint val_13 = yy[((long)(int)(yyOff)) << 2];
            val_13 = zz.Length;
            if(val_13 <= zzOff)
            {
                    val_13 = zz.Length;
            }
            
            val_13 = (zz[((long)(int)(zzOff)) << 2]) + (val_13 * x);
            mem2[0] = val_13;
            int val_1 = yyOff + 1;
            val_14 = zz.Length;
            val_13 = val_13 >> 32;
            if((zzOff + 1) >= val_14)
            {
                    val_14 = zz.Length;
            }
            
            uint val_3 = val_13 + ((yy[((long)(int)((yyOff + 1))) << 2]) * x);
            val_13 = val_3 + (zz[((long)(int)((zzOff + 1))) << 2]);
            mem2[0] = val_13;
            int val_4 = yyOff + 2;
            val_15 = zz.Length;
            val_13 = val_13 >> 32;
            if((zzOff + 2) >= val_15)
            {
                    val_15 = zz.Length;
            }
            
            val_3 = val_13 + ((yy[((long)(int)((yyOff + 2))) << 2]) * x);
            val_13 = val_3 + (zz[((long)(int)((zzOff + 2))) << 2]);
            mem2[0] = val_13;
            int val_6 = yyOff + 3;
            val_16 = zz.Length;
            val_13 = val_13 >> 32;
            if((zzOff + 3) >= val_16)
            {
                    val_16 = zz.Length;
            }
            
            val_3 = val_13 + ((yy[((long)(int)((yyOff + 3))) << 2]) * x);
            val_13 = val_3 + (zz[((long)(int)((zzOff + 3))) << 2]);
            mem2[0] = val_13;
            int val_8 = yyOff + 4;
            val_17 = zz.Length;
            if((zzOff + 4) >= val_17)
            {
                    val_17 = zz.Length;
            }
            
            val_3 = (val_13 >> 32) + ((yy[((long)(int)((yyOff + 4))) << 2]) * x);
            uint val_11 = val_3 + (zz[((long)(int)((zzOff + 4))) << 2]);
            mem2[0] = val_11;
            return (uint)val_11 >> 32;
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  5, z:  z, zOff:  zOff, zPos:  4);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  5, z:  z, zOff:  zOff, zPos:  3);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  5, z:  z, zOff:  zOff, zPos:  3);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  5, z:  z, zOff:  zOff, zPos:  2);
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
            while(val_3 != 5);
            
            return (uint)val_2;
        }
        public static void Square(uint[] x, uint[] zz)
        {
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            uint val_18 = x[0];
            var val_21 = 0;
            var val_20 = 12;
            do
            {
                var val_2 = val_21 + 9;
                uint val_3 = x[2] * x[2];
                zz[0] = val_3 >> 33;
                var val_5 = val_21 + 8;
                zz[0] = val_3 >> 1;
                val_20 = val_20 - 1;
                val_21 = val_21 - 2;
            }
            while((val_20 - 8) > 1);
            
            uint val_7 = val_18 * val_18;
            zz[0] = val_7;
            uint val_8 = val_7 >> 33;
            val_15 = zz.Length;
            uint val_22 = x[0];
            if(val_15 <= 2)
            {
                    val_15 = zz.Length;
            }
            
            uint val_9 = val_8 + (val_22 * val_18);
            zz[0] = (ulong)(val_7 >> 32) & 1;
            val_16 = zz.Length;
            uint val_24 = x[1];
            if(val_16 <= 3)
            {
                    val_16 = zz.Length;
            }
            
            val_8 = val_9 >> 31;
            val_7 = zz[1] + (val_9 >> 32);
            if(val_16 <= 4)
            {
                    val_16 = zz.Length;
            }
            
            val_18 = val_7 + (val_24 * val_18);
            zz[1] = val_8;
            uint val_11 = (val_24 * val_22) + (val_18 >> 32);
            val_17 = zz.Length;
            uint val_27 = x[1];
            val_11 = val_11 + zz[1];
            if(val_17 <= 5)
            {
                    val_17 = zz.Length;
            }
            
            val_7 = val_11 & 4294967295;
            if(val_17 <= 6)
            {
                    val_17 = zz.Length;
            }
            
            val_11 = val_11 >> 32;
            val_18 = val_7 + (val_27 * val_18);
            zz[1] = val_18 >> 31;
            uint val_13 = val_11 + zz[2];
            uint val_14 = val_27 * val_24;
            val_13 = val_13 + (val_27 * val_22);
            val_11 = val_13 + (val_18 >> 32);
            val_18 = zz.Length;
            uint val_30 = x[2];
            val_14 = val_14 + (val_11 >> 32);
            if(val_18 <= 7)
            {
                    val_18 = zz.Length;
            }
            
            val_14 = val_14 + zz[2];
            val_18 = val_18 >> 31;
            uint val_15 = val_11 & 4294967295;
            if(val_18 <= 8)
            {
                    val_18 = zz.Length;
            }
            
            val_11 = val_14 >> 32;
            val_14 = val_14 & 4294967295;
            val_15 = val_15 + (val_30 * val_18);
            if(val_18 <= 4)
            {
                    val_18 = zz.Length;
            }
            
            zz[2] = val_18;
            uint val_34 = zz[3];
            uint val_33 = val_22;
            val_33 = val_14 + (val_30 * val_33);
            val_34 = val_11 + val_34;
            val_27 = val_33 + (val_15 >> 32);
            uint val_17 = val_34 + (val_30 * val_24);
            val_14 = val_17 + (val_27 >> 32);
            val_17 = (val_30 * val_27) + (val_14 >> 32);
            val_11 = val_17 + zz[3];
            if(val_18 <= 5)
            {
                    val_18 = zz.Length;
            }
            
            val_30 = zz[4] + (val_11 >> 32);
            zz[2] = val_24;
            if(val_18 <= 6)
            {
                    val_18 = zz.Length;
            }
            
            zz[3] = val_24;
            if(val_18 <= 7)
            {
                    val_18 = zz.Length;
            }
            
            zz[3] = val_14;
            if(val_18 <= 8)
            {
                    val_18 = zz.Length;
            }
            
            zz[4] = val_11;
            val_11 = val_30 >> 31;
            if(val_18 <= 9)
            {
                    val_18 = zz.Length;
            }
            
            uint val_35 = zz[4];
            val_34 = val_30 >> 32;
            val_35 = val_35 + val_34;
            zz[4] = val_11;
        }
        public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
        {
            int val_30;
            int val_31;
            int val_32;
            uint val_33;
            var val_34;
            int val_35;
            var val_36;
            uint val_37;
            var val_38;
            uint val_39;
            int val_40;
            int val_32 = xOff;
            System.UInt32[] val_48 = x;
            uint val_31 = val_48[((long)(int)(xOff)) << 2];
            val_32 = val_32 + 4;
            int val_1 = zzOff + 9;
            do
            {
                int val_2 = val_32 + 5;
                val_2 = val_2 - 5;
                uint val_3 = (val_48[((long)(int)((((xOff + 4) + 5) - 5))) << 2]) * (val_48[((long)(int)((((xOff + 4) + 5) - 5))) << 2]);
                zz[((long)(int)((zzOff + 9))) << 2] = val_3 >> 33;
                int val_5 = val_1 - 1;
                val_1 = val_1 - 2;
                zz[((long)(int)(((zzOff + 9) - 1))) << 2] = val_3 >> 1;
            }
            while((5 - 1) > 1);
            
            uint val_8 = val_31 * val_31;
            zz[((long)(int)(zzOff)) << 2] = val_8;
            int val_34 = val_32;
            uint val_9 = val_8 >> 33;
            val_34 = val_34 + 1;
            val_30 = zz.Length;
            uint val_35 = val_48[((long)(int)((xOff + 1))) << 2];
            if((zzOff + 2) >= val_30)
            {
                    val_30 = zz.Length;
            }
            
            val_9 = val_9 + (val_35 * val_31);
            int val_11 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = (ulong)(val_8 >> 32) & 1;
            int val_37 = val_32;
            val_37 = val_37 + 2;
            uint val_38 = val_48[((long)(int)((xOff + 2))) << 2];
            val_31 = zz.Length;
            if((zzOff + 3) >= val_31)
            {
                    val_31 = zz.Length;
            }
            
            int val_14 = zzOff + 4;
            if(val_14 >= val_31)
            {
                    val_31 = zz.Length;
            }
            
            val_9 = ((zz[((long)(int)((zzOff + 2))) << 2]) + (val_9 >> 32)) + (val_38 * val_31);
            mem2[0] = val_9 >> 31;
            uint val_41 = val_35;
            val_41 = val_38 * val_41;
            uint val_16 = val_41 + (val_9 >> 32);
            int val_42 = val_32;
            val_42 = val_42 + 3;
            val_32 = zz.Length;
            val_16 = val_16 + (zz[((long)(int)((zzOff + 3))) << 2]);
            val_33 = val_48[((long)(int)((xOff + 3))) << 2];
            int val_17 = zzOff + 5;
            val_34 = (long)val_17;
            if(val_17 >= val_32)
            {
                    val_32 = zz.Length;
                val_34 = val_34;
            }
            
            if((zzOff + 6) >= val_32)
            {
                    val_32 = zz.Length;
            }
            
            uint val_21 = (val_16 & 4294967295) + (val_33 * val_31);
            val_16 = val_16 >> 32;
            mem2[0] = val_9 >> 31;
            uint val_45 = zz[((long)(int)((zzOff + 4))) << 2];
            val_45 = val_16 + val_45;
            val_45 = val_45 + (val_33 * val_35);
            val_16 = val_45 + (val_21 >> 32);
            uint val_22 = val_33 * val_38;
            int val_46 = val_32;
            val_46 = val_46 + 4;
            val_35 = zz.Length;
            uint val_47 = val_48[((long)(int)((xOff + 4))) << 2];
            val_22 = val_22 + (val_16 >> 32);
            if((zzOff + 7) >= val_35)
            {
                    val_35 = zz.Length;
            }
            
            val_37 = zz[((long)(int)((zzOff + 7))) << 2];
            uint val_24 = val_22 + (zz[((long)(int)((zzOff + 5))) << 2]);
            val_48 = val_21 >> 31;
            uint val_26 = val_16 & 4294967295;
            if((zzOff + 8) >= val_35)
            {
                    val_35 = zz.Length;
                val_37 = val_37;
            }
            
            val_21 = val_24 >> 32;
            uint val_27 = val_24 & 4294967295;
            val_39 = zz[((long)(int)((zzOff + 8))) << 2];
            val_26 = val_26 + (val_47 * val_31);
            if((long)val_14 >= val_35)
            {
                    val_37 = val_37;
                val_33 = val_33;
                val_39 = val_39;
                val_36 = zz[((long)(int)((zzOff + 7))) << 2] + 32;
                val_38 = zz[((long)(int)((zzOff + 8))) << 2] + 32;
            }
            
            mem2[0] = val_48;
            uint val_49 = val_35;
            uint val_50 = zz[((long)(int)((zzOff + 6))) << 2];
            val_49 = val_27 + (val_47 * val_49);
            val_50 = val_21 + val_50;
            uint val_51 = val_38;
            val_51 = val_50 + (val_47 * val_51);
            uint val_29 = val_51 + ((val_49 + (val_26 >> 32)) >> 32);
            uint val_30 = val_47 * val_33;
            val_30 = val_30 + (val_29 >> 32);
            val_47 = val_30 + val_37;
            val_27 = val_39 + (val_47 >> 32);
            mem2[0] = val_26;
            mem2[0] = val_26;
            mem2[0] = val_26;
            mem2[0] = val_26;
            int val_52 = zzOff;
            val_40 = zz.Length;
            val_29 = val_27 >> 31;
            val_52 = val_52 + 9;
            if(val_52 >= val_40)
            {
                    val_40 = zz.Length;
            }
            
            uint val_53 = zz[((long)(int)((zzOff + 9))) << 2];
            val_37 = val_27 >> 32;
            val_53 = val_53 + val_37;
            mem2[0] = val_29;
        }
        public static int Sub(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_12 = y;
            uint val_2 = x[0];
            val_2 = val_2 - val_12[0];
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_12[0];
            val_5 = x[0] - val_5;
            val_2 = val_5 + val_2;
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_12[1];
            val_7 = x[1] - val_7;
            val_2 = val_7 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_12[1];
            val_9 = x[1] - val_9;
            val_2 = val_9 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_12[2];
            val_11 = x[2] - val_11;
            val_12 = val_11 + val_2;
            z[2] = val_12;
            return (int)val_12 >> 32;
        }
        public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_16 = x[((long)(int)(xOff)) << 2];
            val_16 = val_16 - (y[((long)(int)(yOff)) << 2]);
            z[((long)(int)(zOff)) << 2] = val_16;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_16 = val_16 >> 32;
            uint val_19 = y[((long)(int)((yOff + 1))) << 2];
            int val_3 = zOff + 1;
            val_19 = (x[((long)(int)((xOff + 1))) << 2]) - val_19;
            val_16 = val_19 + val_16;
            z[((long)(int)((zOff + 1))) << 2] = val_16;
            int val_4 = xOff + 2;
            int val_5 = yOff + 2;
            val_16 = val_16 >> 32;
            uint val_21 = y[((long)(int)((yOff + 2))) << 2];
            int val_6 = zOff + 2;
            val_21 = (x[((long)(int)((xOff + 2))) << 2]) - val_21;
            val_16 = val_21 + val_16;
            z[((long)(int)((zOff + 2))) << 2] = val_16;
            int val_7 = xOff + 3;
            int val_8 = yOff + 3;
            val_16 = val_16 >> 32;
            uint val_23 = y[((long)(int)((yOff + 3))) << 2];
            int val_9 = zOff + 3;
            val_23 = (x[((long)(int)((xOff + 3))) << 2]) - val_23;
            val_16 = val_23 + val_16;
            z[((long)(int)((zOff + 3))) << 2] = val_16;
            int val_10 = xOff + 4;
            int val_11 = yOff + 4;
            uint val_25 = y[((long)(int)((yOff + 4))) << 2];
            int val_13 = zOff + 4;
            val_25 = (x[((long)(int)((xOff + 4))) << 2]) - val_25;
            uint val_14 = val_25 + (val_16 >> 32);
            z[((long)(int)((zOff + 4))) << 2] = val_14;
            return (int)val_14 >> 32;
        }
        public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            System.UInt32[] val_18 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            uint val_1 = val_3 - x[0];
            val_3 = val_1 - val_18[0];
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            val_1 = val_3 + z[0];
            val_1 = val_1 - x[0];
            val_3 = val_1 - val_18[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_18[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_6 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_18[1];
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_18 = val_1 - val_18[2];
            z[2] = val_18;
            return (int)val_18 >> 32;
        }
        public static int SubFrom(uint[] x, uint[] z)
        {
            int val_2;
            int val_3;
            int val_4;
            int val_5;
            System.UInt32[] val_12 = x;
            uint val_2 = z[0];
            val_2 = z.Length;
            val_2 = val_2 - val_12[0];
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_12[0];
            val_3 = z.Length;
            val_5 = z[0] - val_5;
            val_2 = val_5 + val_2;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_12[1];
            val_4 = z.Length;
            val_7 = z[1] - val_7;
            val_2 = val_7 + val_2;
            if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_12[1];
            val_5 = z.Length;
            val_9 = z[1] - val_9;
            val_2 = val_9 + val_2;
            if(val_5 <= 3)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_12[2];
            val_11 = z[2] - val_11;
            val_12 = val_11 + val_2;
            z[2] = val_12;
            return (int)val_12 >> 32;
        }
        public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
        {
            System.UInt32[] val_21 = z;
            uint val_1 = (val_21[((long)(int)(zOff)) << 2]) - (x[((long)(int)(xOff)) << 2]);
            mem2[0] = val_1;
            int val_2 = zOff + 1;
            int val_3 = xOff + 1;
            val_1 = val_1 >> 32;
            uint val_14 = x[((long)(int)((xOff + 1))) << 2];
            val_14 = (val_21[((long)(int)((zOff + 1))) << 2]) - val_14;
            val_1 = val_14 + val_1;
            mem2[0] = val_1;
            int val_4 = zOff + 2;
            int val_5 = xOff + 2;
            val_1 = val_1 >> 32;
            uint val_16 = x[((long)(int)((xOff + 2))) << 2];
            val_16 = (val_21[((long)(int)((zOff + 2))) << 2]) - val_16;
            val_1 = val_16 + val_1;
            mem2[0] = val_1;
            int val_6 = zOff + 3;
            int val_7 = xOff + 3;
            val_1 = val_1 >> 32;
            uint val_18 = x[((long)(int)((xOff + 3))) << 2];
            val_18 = (val_21[((long)(int)((zOff + 3))) << 2]) - val_18;
            val_1 = val_18 + val_1;
            mem2[0] = val_1;
            int val_8 = zOff + 4;
            int val_9 = xOff + 4;
            val_1 = val_1 >> 32;
            uint val_20 = x[((long)(int)((xOff + 4))) << 2];
            val_20 = (val_21[((long)(int)((zOff + 4))) << 2]) - val_20;
            val_21 = val_20 + val_1;
            mem2[0] = val_21;
            return (int)val_21 >> 32;
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
        {
            byte[] val_1 = new byte[20];
            var val_3 = 0;
            var val_4 = 16;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  1134694512, bs:  val_1, off:  16);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 4;
            }
            while(val_3 != 5);
            
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
            z[2] = 0;
        }
        protected Nat160()
        {
        
        }
    
    }

}
