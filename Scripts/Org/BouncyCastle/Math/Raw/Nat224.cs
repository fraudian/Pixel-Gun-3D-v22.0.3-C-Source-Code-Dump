using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat224
    {
        // Fields
        private const ulong M = 4294967295;
        
        // Methods
        public static uint Add(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_17 = y;
            uint val_3 = x[0];
            val_3 = val_17[0] + val_3;
            z[0] = val_3;
            val_3 = val_3 >> 32;
            uint val_1 = val_3 + x[0];
            val_3 = val_1 + val_17[0];
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_17[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_17[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_3 = val_1 + val_17[2];
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_3 = val_1 + val_17[2];
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[3];
            val_17 = val_1 + val_17[3];
            z[3] = val_17;
            return (uint)val_17 >> 32;
        }
        public static uint Add(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_23 = x[((long)(int)(xOff)) << 2];
            val_23 = (y[((long)(int)(yOff)) << 2]) + val_23;
            z[((long)(int)(zOff)) << 2] = val_23;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_23 = val_23 >> 32;
            uint val_3 = val_23 + (x[((long)(int)((xOff + 1))) << 2]);
            int val_4 = zOff + 1;
            val_23 = val_3 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_23;
            int val_5 = xOff + 2;
            int val_6 = yOff + 2;
            val_23 = val_23 >> 32;
            val_3 = val_23 + (x[((long)(int)((xOff + 2))) << 2]);
            int val_7 = zOff + 2;
            val_23 = val_3 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_23;
            int val_8 = xOff + 3;
            int val_9 = yOff + 3;
            val_23 = val_23 >> 32;
            val_3 = val_23 + (x[((long)(int)((xOff + 3))) << 2]);
            int val_10 = zOff + 3;
            val_23 = val_3 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_23;
            int val_11 = xOff + 4;
            int val_12 = yOff + 4;
            val_23 = val_23 >> 32;
            val_3 = val_23 + (x[((long)(int)((xOff + 4))) << 2]);
            int val_13 = zOff + 4;
            val_23 = val_3 + (y[((long)(int)((yOff + 4))) << 2]);
            z[((long)(int)((zOff + 4))) << 2] = val_23;
            int val_14 = xOff + 5;
            int val_15 = yOff + 5;
            val_23 = val_23 >> 32;
            val_3 = val_23 + (x[((long)(int)((xOff + 5))) << 2]);
            int val_16 = zOff + 5;
            val_23 = val_3 + (y[((long)(int)((yOff + 5))) << 2]);
            z[((long)(int)((zOff + 5))) << 2] = val_23;
            int val_17 = xOff + 6;
            int val_18 = yOff + 6;
            val_3 = (val_23 >> 32) + (x[((long)(int)((xOff + 6))) << 2]);
            int val_20 = zOff + 6;
            uint val_21 = val_3 + (y[((long)(int)((yOff + 6))) << 2]);
            z[((long)(int)((zOff + 6))) << 2] = val_21;
            return (uint)val_21 >> 32;
        }
        public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_9;
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
            val_3 = val_3 >> 32;
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            val_1 = val_3 + x[2];
            val_1 = val_1 + y[2];
            val_3 = val_1 + z[2];
            z[2] = val_3;
            val_9 = z.Length;
            uint val_22 = y[3];
            val_3 = val_3 >> 32;
            if(val_9 <= 6)
            {
                    val_9 = z.Length;
            }
            
            val_1 = val_3 + x[3];
            val_1 = val_1 + val_22;
            val_22 = val_1 + z[3];
            z[3] = val_22;
            return (uint)val_22 >> 32;
        }
        public static uint AddBothTo(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            uint val_17 = x[((long)(int)(xOff)) << 2];
            val_17 = z.Length;
            if(val_17 <= zOff)
            {
                    val_17 = z.Length;
            }
            
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + val_17;
            val_17 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_17;
            int val_2 = xOff + 1;
            int val_21 = yOff;
            val_21 = val_21 + 1;
            val_18 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 1) >= val_18)
            {
                    val_18 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 1))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 1))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_17;
            int val_4 = xOff + 2;
            int val_25 = yOff;
            val_25 = val_25 + 2;
            val_19 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 2) >= val_19)
            {
                    val_19 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 2))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 2))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_17;
            int val_6 = xOff + 3;
            int val_29 = yOff;
            val_29 = val_29 + 3;
            val_20 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 3) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 3))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 3))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_17;
            int val_8 = xOff + 4;
            int val_33 = yOff;
            val_33 = val_33 + 4;
            val_21 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 4) >= val_21)
            {
                    val_21 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 4))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 4))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_17;
            int val_10 = xOff + 5;
            int val_37 = yOff;
            val_37 = val_37 + 5;
            val_22 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 5) >= val_22)
            {
                    val_22 = z.Length;
            }
            
            val_1 = val_17 + (x[((long)(int)((xOff + 5))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 5))) << 2]);
            val_17 = val_1 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_17;
            int val_12 = xOff + 6;
            int val_41 = yOff;
            val_41 = val_41 + 6;
            val_23 = z.Length;
            if((zOff + 6) >= val_23)
            {
                    val_23 = z.Length;
            }
            
            val_1 = (val_17 >> 32) + (x[((long)(int)((xOff + 6))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 6))) << 2]);
            uint val_15 = val_1 + (z[((long)(int)((zOff + 6))) << 2]);
            mem2[0] = val_15;
            return (uint)val_15 >> 32;
        }
        public static uint AddTo(uint[] x, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_9;
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
            val_3 = val_3 >> 32;
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            val_1 = val_3 + x[2];
            val_3 = val_1 + z[2];
            z[2] = val_3;
            val_9 = z.Length;
            uint val_15 = x[3];
            val_3 = val_3 >> 32;
            if(val_9 <= 6)
            {
                    val_9 = z.Length;
            }
            
            val_1 = val_3 + val_15;
            val_15 = val_1 + z[3];
            z[3] = val_15;
            return (uint)val_15 >> 32;
        }
        public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
        {
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            uint val_19 = cIn;
            val_17 = z.Length;
            if(val_17 <= zOff)
            {
                    val_17 = z.Length;
            }
            
            uint val_1 = (x[((long)(int)(xOff)) << 2]) + val_19;
            val_19 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_19;
            int val_2 = xOff + 1;
            val_18 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 1) >= val_18)
            {
                    val_18 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 1))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_19;
            int val_4 = xOff + 2;
            val_19 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 2) >= val_19)
            {
                    val_19 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 2))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_19;
            int val_6 = xOff + 3;
            val_20 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 3) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 3))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_19;
            int val_8 = xOff + 4;
            val_21 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 4) >= val_21)
            {
                    val_21 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 4))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_19;
            int val_10 = xOff + 5;
            val_22 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 5) >= val_22)
            {
                    val_22 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 5))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_19;
            int val_12 = xOff + 6;
            val_23 = z.Length;
            if((zOff + 6) >= val_23)
            {
                    val_23 = z.Length;
            }
            
            val_1 = (val_19 >> 32) + (x[((long)(int)((xOff + 6))) << 2]);
            uint val_15 = val_1 + (z[((long)(int)((zOff + 6))) << 2]);
            mem2[0] = val_15;
            return (uint)val_15 >> 32;
        }
        public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
        {
            System.UInt32[] val_30 = u;
            uint val_16 = val_30[((long)(int)(uOff)) << 2];
            val_16 = (v[((long)(int)(vOff)) << 2]) + val_16;
            mem2[0] = val_16;
            mem2[0] = val_16;
            int val_1 = uOff + 1;
            int val_2 = vOff + 1;
            val_16 = val_16 >> 32;
            uint val_3 = val_16 + (val_30[((long)(int)((uOff + 1))) << 2]);
            val_16 = val_3 + (v[((long)(int)((vOff + 1))) << 2]);
            mem2[0] = val_16;
            mem2[0] = val_16;
            int val_4 = uOff + 2;
            int val_5 = vOff + 2;
            val_16 = val_16 >> 32;
            val_3 = val_16 + (val_30[((long)(int)((uOff + 2))) << 2]);
            val_16 = val_3 + (v[((long)(int)((vOff + 2))) << 2]);
            mem2[0] = val_16;
            mem2[0] = val_16;
            int val_6 = uOff + 3;
            int val_7 = vOff + 3;
            val_16 = val_16 >> 32;
            val_3 = val_16 + (val_30[((long)(int)((uOff + 3))) << 2]);
            val_16 = val_3 + (v[((long)(int)((vOff + 3))) << 2]);
            mem2[0] = val_16;
            mem2[0] = val_16;
            int val_8 = uOff + 4;
            int val_9 = vOff + 4;
            val_16 = val_16 >> 32;
            val_3 = val_16 + (val_30[((long)(int)((uOff + 4))) << 2]);
            val_16 = val_3 + (v[((long)(int)((vOff + 4))) << 2]);
            mem2[0] = val_16;
            mem2[0] = val_16;
            int val_10 = uOff + 5;
            int val_11 = vOff + 5;
            val_16 = val_16 >> 32;
            val_3 = val_16 + (val_30[((long)(int)((uOff + 5))) << 2]);
            val_16 = val_3 + (v[((long)(int)((vOff + 5))) << 2]);
            mem2[0] = val_16;
            mem2[0] = val_16;
            int val_12 = uOff + 6;
            int val_13 = vOff + 6;
            val_3 = (val_16 >> 32) + (val_30[((long)(int)((uOff + 6))) << 2]);
            val_30 = val_3 + (v[((long)(int)((vOff + 6))) << 2]);
            mem2[0] = val_30;
            mem2[0] = val_30;
            return (uint)val_30 >> 32;
        }
        public static void Copy(uint[] x, uint[] z)
        {
            z[0] = x[0];
            z[0] = x[0];
            z[1] = x[1];
            z[1] = x[1];
            z[2] = x[2];
            z[2] = x[2];
            z[3] = x[3];
        }
        public static uint[] Create()
        {
            uint[] val_1 = new uint[7];
        }
        public static uint[] CreateExt()
        {
            uint[] val_1 = new uint[14];
        }
        public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat224.Gte(x:  x, xOff:  xOff, y:  y, yOff:  yOff)) != false)
            {
                    int val_2 = Org.BouncyCastle.Math.Raw.Nat224.Sub(x:  x, xOff:  xOff, y:  y, yOff:  yOff, z:  z, zOff:  zOff);
                val_4 = 1;
                return (bool)val_4;
            }
            
            int val_3 = Org.BouncyCastle.Math.Raw.Nat224.Sub(x:  y, xOff:  yOff, y:  x, yOff:  xOff, z:  z, zOff:  zOff);
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool Eq(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 14;
            label_5:
            if(x[3] != y[3])
            {
                goto label_4;
            }
            
            val_1 = val_1 - 1;
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
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_8 = x;
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 225))
            {
                goto label_4;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat224.Create();
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
                if((val_3 >> 5) > 6)
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
            val_1 = 14;
            label_6:
            uint val_2 = x[3];
            uint val_3 = y[3];
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
            val_3 = 6;
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
            int val_15;
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
            if(val_7 <= 5)
            {
                    val_7 = y.Length;
            }
            
            uint val_15 = y[2];
            uint val_16 = y[3];
            uint val_17 = x[0];
            uint val_1 = val_17 * val_10;
            val_8 = zz.Length;
            if(val_8 == 0)
            {
                    val_8 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_18 = val_11;
            val_18 = val_17 * val_18;
            val_1 = val_18 + (val_1 >> 32);
            if(val_8 <= 1)
            {
                    val_8 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_19 = val_12;
            val_19 = val_17 * val_19;
            val_1 = val_19 + (val_1 >> 32);
            if(val_8 <= 2)
            {
                    val_8 = zz.Length;
            }
            
            zz[1] = val_1;
            uint val_20 = val_13;
            val_20 = val_17 * val_20;
            val_1 = val_20 + (val_1 >> 32);
            if(val_8 <= 3)
            {
                    val_8 = zz.Length;
            }
            
            zz[1] = val_1;
            val_1 = (val_17 * val_14) + (val_1 >> 32);
            if(val_8 <= 4)
            {
                    val_8 = zz.Length;
            }
            
            zz[2] = val_1;
            val_1 = (val_17 * val_15) + (val_1 >> 32);
            if(val_8 <= 5)
            {
                    val_8 = zz.Length;
            }
            
            val_17 = (val_17 * val_16) + (val_1 >> 32);
            zz[2] = val_1;
            if(val_8 <= 6)
            {
                    val_8 = zz.Length;
            }
            
            zz[3] = val_17;
            val_17 = val_17 >> 32;
            zz[3] = val_17;
            do
            {
                var val_5 = 9 - 8;
                val_9 = zz.Length;
                uint val_21 = x[0];
                if(val_5 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_6 = null + (val_21 * val_10);
                mem2[0] = val_6;
                val_10 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                uint val_22 = val_11;
                val_22 = val_6 + (val_21 * val_22);
                val_6 = val_22 + 1152921505741541488;
                mem2[0] = val_6;
                val_11 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                uint val_23 = val_12;
                val_23 = val_6 + (val_21 * val_23);
                val_6 = val_23 + 1152921505741541488;
                mem2[0] = val_6;
                val_12 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                uint val_24 = val_13;
                val_24 = val_6 + (val_21 * val_24);
                val_6 = val_24 + 1152921505741541488;
                mem2[0] = val_6;
                val_13 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                val_24 = val_6 + (val_21 * val_14);
                val_6 = val_24 + 1152921505741541488;
                mem2[0] = val_6;
                val_14 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_14)
            {
                    val_14 = zz.Length;
            }
            
                val_24 = val_6 + (val_21 * val_15);
                val_6 = val_24 + 1152921505741541488;
                mem2[0] = val_6;
                val_15 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_15)
            {
                    val_15 = zz.Length;
            }
            
                val_24 = val_6 + (val_21 * val_16);
                val_6 = val_24 + 1152921505741541488;
                mem2[0] = val_6;
                mem2[0] = val_6 >> 32;
                var val_9 = 9 + 1;
            }
            while((val_5 + 1) != 13);
        
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
            int val_44;
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
            if((yOff + 5) >= val_37)
            {
                    val_37 = y.Length;
            }
            
            uint val_42 = y[((long)(int)((yOff + 5))) << 2];
            int val_6 = yOff + 6;
            uint val_43 = y[((long)(int)((yOff + 6))) << 2];
            uint val_44 = x[((long)(int)(xOff)) << 2];
            uint val_7 = val_44 * val_37;
            zz[((long)(int)(zzOff)) << 2] = val_7;
            uint val_45 = val_38;
            val_45 = val_44 * val_45;
            uint val_8 = val_45 + (val_7 >> 32);
            int val_9 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = val_8;
            uint val_46 = val_39;
            val_46 = val_44 * val_46;
            val_8 = val_46 + (val_8 >> 32);
            int val_10 = zzOff + 2;
            zz[((long)(int)((zzOff + 2))) << 2] = val_8;
            uint val_47 = val_40;
            val_47 = val_44 * val_47;
            val_8 = val_47 + (val_8 >> 32);
            int val_11 = zzOff + 3;
            zz[((long)(int)((zzOff + 3))) << 2] = val_8;
            uint val_48 = val_41;
            val_48 = val_44 * val_48;
            val_8 = val_48 + (val_8 >> 32);
            int val_12 = zzOff + 4;
            zz[((long)(int)((zzOff + 4))) << 2] = val_8;
            uint val_49 = val_42;
            val_49 = val_44 * val_49;
            val_8 = val_49 + (val_8 >> 32);
            int val_13 = zzOff + 5;
            zz[((long)(int)((zzOff + 5))) << 2] = val_8;
            uint val_15 = (val_44 * val_43) + (val_8 >> 32);
            int val_16 = zzOff + 6;
            zz[((long)(int)((zzOff + 6))) << 2] = val_15;
            int val_17 = zzOff + 7;
            val_15 = val_15 >> 32;
            var val_63 = 5;
            zz[((long)(int)((zzOff + 7))) << 2] = val_15;
            do
            {
                int val_21 = (xOff + 1) + val_63;
                val_21 = val_21 + 6;
                val_38 = zz.Length;
                uint val_50 = x[((long)(int)((((xOff + 1) + 5) + 6))) << 2];
                if(((zzOff + val_63) + 7) >= val_38)
            {
                    val_38 = zz.Length;
            }
            
                uint val_22 = (zz[((long)(int)(((zzOff + 5) + 7))) << 2]) + (val_50 * val_37);
                mem2[0] = val_22;
                val_39 = zz.Length;
                val_22 = val_22 >> 32;
                if(((zzOff + val_63) + 8) >= val_39)
            {
                    val_39 = zz.Length;
            }
            
                uint val_53 = val_38;
                val_53 = val_22 + (val_50 * val_53);
                val_22 = val_53 + (zz[((long)(int)(((zzOff + 5) + 8))) << 2]);
                mem2[0] = val_22;
                val_40 = zz.Length;
                val_22 = val_22 >> 32;
                if(((zzOff + val_63) + 9) >= val_40)
            {
                    val_40 = zz.Length;
            }
            
                uint val_55 = val_39;
                val_55 = val_22 + (val_50 * val_55);
                val_22 = val_55 + (zz[((long)(int)(((zzOff + 5) + 9))) << 2]);
                mem2[0] = val_22;
                val_41 = zz.Length;
                val_22 = val_22 >> 32;
                if(((zzOff + val_63) + 10) >= val_41)
            {
                    val_41 = zz.Length;
            }
            
                uint val_57 = val_40;
                val_57 = val_22 + (val_50 * val_57);
                val_22 = val_57 + (zz[((long)(int)(((zzOff + 5) + 10))) << 2]);
                mem2[0] = val_22;
                val_42 = zz.Length;
                val_22 = val_22 >> 32;
                if(((zzOff + val_63) + 11) >= val_42)
            {
                    val_42 = zz.Length;
            }
            
                uint val_59 = val_41;
                val_59 = val_22 + (val_50 * val_59);
                val_22 = val_59 + (zz[((long)(int)(((zzOff + 5) + 11))) << 2]);
                mem2[0] = val_22;
                val_43 = zz.Length;
                val_22 = val_22 >> 32;
                if(((zzOff + val_63) + 12) >= val_43)
            {
                    val_43 = zz.Length;
            }
            
                uint val_61 = val_42;
                val_61 = val_22 + (val_50 * val_61);
                val_22 = val_61 + (zz[((long)(int)(((zzOff + 5) + 12))) << 2]);
                mem2[0] = val_22;
                val_44 = zz.Length;
                val_22 = val_22 >> 32;
                if(((zzOff + val_63) + 13) >= val_44)
            {
                    val_44 = zz.Length;
            }
            
                val_61 = val_22 + (val_50 * val_43);
                val_22 = val_61 + (zz[((long)(int)(((zzOff + 5) + 13))) << 2]);
                mem2[0] = val_22;
                int val_35 = zzOff + val_63;
                val_35 = val_35 + 14;
                val_63 = val_63 + 1;
                zz[((long)(int)(((zzOff + 5) + 14))) << 2] = val_22 >> 32;
            }
            while(val_63 != 0);
        
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
            int val_13;
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
            
            if(val_5 <= 5)
            {
                    val_5 = y.Length;
            }
            
            var val_14 = 0;
            do
            {
                val_6 = zz.Length;
                if(val_14 >= val_6)
            {
                    val_6 = zz.Length;
            }
            
                System.UInt32[] val_1 = null + (1152921505741541488 * y[0]);
                mem2[0] = val_1;
                val_7 = zz.Length;
                val_14 = val_14 + 1;
                val_1 = val_1 >> 32;
                if(val_14 >= val_7)
            {
                    val_7 = zz.Length;
            }
            
                uint val_15 = y[0];
                val_15 = val_1 + (1152921505741541488 * val_15);
                mem2[0] = val_1;
                val_8 = zz.Length;
                val_14 = val_14 + 1;
                val_1 = val_1 >> 32;
                if(val_14 >= val_8)
            {
                    val_8 = zz.Length;
            }
            
                uint val_16 = y[1];
                val_16 = val_1 + (1152921505741541488 * val_16);
                mem2[0] = val_1;
                val_9 = zz.Length;
                val_14 = val_14 + 1;
                val_1 = val_1 >> 32;
                if(val_14 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_17 = y[1];
                val_17 = val_1 + (1152921505741541488 * val_17);
                mem2[0] = val_1;
                val_10 = zz.Length;
                val_14 = val_14 + 1;
                val_1 = val_1 >> 32;
                if(val_14 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                uint val_18 = y[2];
                val_18 = val_1 + (1152921505741541488 * val_18);
                mem2[0] = val_1;
                val_11 = zz.Length;
                val_14 = val_14 + 1;
                val_1 = val_1 >> 32;
                if(val_14 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                System.UInt32[] val_2 = val_1 + (1152921505741541488 * y[2]);
                mem2[0] = val_1;
                val_12 = zz.Length;
                val_14 = val_14 + 1;
                val_1 = val_1 >> 32;
                if(val_14 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                System.UInt32[] val_3 = val_1 + (1152921505741541488 * y[3]);
                mem2[0] = val_1;
                val_13 = zz.Length;
                var val_4 = val_14 + 1;
                System.UInt32[] val_5 = val_1 >> 32;
                if(val_4 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                mem2[0] = 0;
            }
            while((val_4 - 6) != 7);
            
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
            int val_25;
            System.UInt32[] val_26 = y;
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
            
            if((yOff + 5) >= val_17)
            {
                    val_17 = y.Length;
            }
            
            int val_6 = yOff + 6;
            uint val_40 = 0;
            var val_41 = -7;
            do
            {
                int val_7 = zzOff + val_41;
                int val_8 = xOff + val_41;
                val_8 = val_8 + 7;
                val_7 = val_7 + 7;
                uint val_24 = x[((long)(int)(((xOff + -7) + 7))) << 2];
                val_18 = zz.Length;
                if(val_7 >= val_18)
            {
                    val_18 = zz.Length;
            }
            
                val_26 = (zz[((long)(int)(((zzOff + -7) + 7))) << 2]) + (val_24 * (val_26[((long)(int)(yOff)) << 2]));
                mem2[0] = val_26;
                val_19 = zz.Length;
                int val_9 = zzOff + val_41;
                val_9 = val_9 + 8;
                val_7 = val_7 + 1;
                uint val_10 = val_26 >> 32;
                if(val_7 >= val_19)
            {
                    val_19 = zz.Length;
            }
            
                uint val_28 = val_26[((long)(int)((yOff + 1))) << 2];
                val_28 = val_10 + (val_24 * val_28);
                val_10 = val_28 + (zz[((long)(int)(((zzOff + -7) + 8))) << 2]);
                mem2[0] = val_10;
                val_20 = zz.Length;
                int val_11 = zzOff + val_41;
                val_11 = val_11 + 9;
                val_7 = val_7 + 1;
                val_10 = val_10 >> 32;
                if(val_7 >= val_20)
            {
                    val_20 = zz.Length;
            }
            
                uint val_30 = val_26[((long)(int)((yOff + 2))) << 2];
                val_30 = val_10 + (val_24 * val_30);
                val_10 = val_30 + (zz[((long)(int)(((zzOff + -7) + 9))) << 2]);
                mem2[0] = val_10;
                val_21 = zz.Length;
                int val_12 = zzOff + val_41;
                val_12 = val_12 + 10;
                val_7 = val_7 + 1;
                val_10 = val_10 >> 32;
                if(val_7 >= val_21)
            {
                    val_21 = zz.Length;
            }
            
                uint val_32 = val_26[((long)(int)((yOff + 3))) << 2];
                val_32 = val_10 + (val_24 * val_32);
                val_10 = val_32 + (zz[((long)(int)(((zzOff + -7) + 10))) << 2]);
                mem2[0] = val_10;
                val_22 = zz.Length;
                int val_13 = zzOff + val_41;
                val_13 = val_13 + 11;
                val_7 = val_7 + 1;
                val_10 = val_10 >> 32;
                if(val_7 >= val_22)
            {
                    val_22 = zz.Length;
            }
            
                uint val_34 = val_26[((long)(int)((yOff + 4))) << 2];
                val_34 = val_10 + (val_24 * val_34);
                val_10 = val_34 + (zz[((long)(int)(((zzOff + -7) + 11))) << 2]);
                mem2[0] = val_10;
                val_23 = zz.Length;
                int val_14 = zzOff + val_41;
                val_14 = val_14 + 12;
                val_7 = val_7 + 1;
                val_10 = val_10 >> 32;
                if(val_7 >= val_23)
            {
                    val_23 = zz.Length;
            }
            
                uint val_36 = val_26[((long)(int)((yOff + 5))) << 2];
                val_36 = val_10 + (val_24 * val_36);
                val_10 = val_36 + (zz[((long)(int)(((zzOff + -7) + 12))) << 2]);
                mem2[0] = val_10;
                val_24 = zz.Length;
                int val_15 = zzOff + val_41;
                val_15 = val_15 + 13;
                val_7 = val_7 + 1;
                val_10 = val_10 >> 32;
                if(val_7 >= val_24)
            {
                    val_24 = zz.Length;
            }
            
                uint val_38 = val_26[((long)(int)((yOff + 6))) << 2];
                val_38 = val_10 + (val_24 * val_38);
                val_10 = val_38 + (zz[((long)(int)(((zzOff + -7) + 13))) << 2]);
                mem2[0] = val_10;
                val_25 = zz.Length;
                int val_16 = zzOff + val_41;
                val_16 = val_16 + 14;
                val_7 = val_7 + 1;
                val_10 = val_10 >> 32;
                if(val_7 >= val_25)
            {
                    val_25 = zz.Length;
            }
            
                val_38 = val_10 + val_40;
                val_40 = val_38 + (zz[((long)(int)(((zzOff + -7) + 14))) << 2]);
                mem2[0] = val_40;
                val_41 = val_41 + 1;
                val_40 = val_40 >> 32;
            }
            while(val_41 != 0);
            
            return (uint)val_40;
        }
        public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_30 = x[((long)(int)(xOff)) << 2];
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + (val_30 * w);
            z[((long)(int)(zOff)) << 2] = val_1;
            int val_2 = xOff + 1;
            uint val_3 = val_1 >> 32;
            uint val_32 = x[((long)(int)((xOff + 1))) << 2];
            int val_4 = yOff + 1;
            uint val_5 = val_3 + val_30;
            int val_6 = zOff + 1;
            val_5 = val_5 + (val_32 * w);
            val_30 = val_5 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_30;
            int val_7 = xOff + 2;
            val_3 = val_30 >> 32;
            uint val_34 = x[((long)(int)((xOff + 2))) << 2];
            int val_8 = yOff + 2;
            uint val_9 = val_3 + val_32;
            int val_10 = zOff + 2;
            val_9 = val_9 + (val_34 * w);
            val_32 = val_9 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_32;
            int val_11 = xOff + 3;
            val_3 = val_32 >> 32;
            uint val_36 = x[((long)(int)((xOff + 3))) << 2];
            int val_12 = yOff + 3;
            uint val_13 = val_3 + val_34;
            int val_14 = zOff + 3;
            val_13 = val_13 + (val_36 * w);
            val_34 = val_13 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_34;
            int val_15 = xOff + 4;
            val_3 = val_34 >> 32;
            uint val_38 = x[((long)(int)((xOff + 4))) << 2];
            int val_16 = yOff + 4;
            uint val_17 = val_3 + val_36;
            int val_18 = zOff + 4;
            val_17 = val_17 + (val_38 * w);
            val_36 = val_17 + (y[((long)(int)((yOff + 4))) << 2]);
            z[((long)(int)((zOff + 4))) << 2] = val_36;
            int val_19 = xOff + 5;
            val_3 = val_36 >> 32;
            uint val_40 = x[((long)(int)((xOff + 5))) << 2];
            int val_20 = yOff + 5;
            uint val_21 = val_3 + val_38;
            int val_22 = zOff + 5;
            val_21 = val_21 + (val_40 * w);
            val_38 = val_21 + (y[((long)(int)((yOff + 5))) << 2]);
            z[((long)(int)((zOff + 5))) << 2] = val_38;
            int val_23 = xOff + 6;
            uint val_42 = x[((long)(int)((xOff + 6))) << 2];
            int val_24 = yOff + 6;
            uint val_26 = (val_38 >> 32) + val_40;
            int val_27 = zOff + 6;
            val_26 = val_26 + (val_42 * w);
            uint val_28 = val_26 + (y[((long)(int)((yOff + 6))) << 2]);
            z[((long)(int)((zOff + 6))) << 2] = val_28;
            return (ulong)val_42 + (val_28 >> 32);
        }
        public static uint MulByWord(uint x, uint[] z)
        {
            int val_3;
            uint val_10 = x;
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            uint val_1 = z[0] * val_10;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            val_1 = val_1 + (z[0] * val_10);
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 2)
            {
                    val_3 = z.Length;
            }
            
            val_1 = val_1 + (z[1] * val_10);
            if(val_3 <= 2)
            {
                    val_3 = z.Length;
            }
            
            z[1] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 3)
            {
                    val_3 = z.Length;
            }
            
            val_1 = val_1 + (z[1] * val_10);
            if(val_3 <= 3)
            {
                    val_3 = z.Length;
            }
            
            z[1] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 4)
            {
                    val_3 = z.Length;
            }
            
            val_1 = val_1 + (z[2] * val_10);
            if(val_3 <= 4)
            {
                    val_3 = z.Length;
            }
            
            z[2] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 5)
            {
                    val_3 = z.Length;
            }
            
            val_1 = val_1 + (z[2] * val_10);
            if(val_3 <= 5)
            {
                    val_3 = z.Length;
            }
            
            z[2] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 6)
            {
                    val_3 = z.Length;
            }
            
            val_10 = val_1 + (z[3] * val_10);
            z[3] = val_10;
            return (uint)val_10 >> 32;
        }
        public static uint MulByWordAddTo(uint x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            System.UInt32[] val_17 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            val_3 = val_17[0] + (val_3 * x);
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            uint val_1 = val_3 + (z[0] * x);
            val_3 = val_1 + val_17[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + (z[1] * x);
            val_3 = val_1 + val_17[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_6 = z.Length;
            val_1 = val_3 + (z[1] * x);
            val_3 = val_1 + val_17[1];
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_7 = z.Length;
            val_1 = val_3 + (z[2] * x);
            val_3 = val_1 + val_17[2];
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_8 = z.Length;
            val_1 = val_3 + (z[2] * x);
            val_3 = val_1 + val_17[2];
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + (z[3] * x);
            val_17 = val_1 + val_17[3];
            z[3] = val_17;
            return (uint)val_17 >> 32;
        }
        public static uint MulWordAddTo(uint x, uint[] y, int yOff, uint[] z, int zOff)
        {
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            uint val_17 = y[((long)(int)(yOff)) << 2];
            val_17 = z.Length;
            if(val_17 <= zOff)
            {
                    val_17 = z.Length;
            }
            
            val_17 = (z[((long)(int)(zOff)) << 2]) + (val_17 * x);
            mem2[0] = val_17;
            int val_1 = yOff + 1;
            val_18 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 1) >= val_18)
            {
                    val_18 = z.Length;
            }
            
            uint val_3 = val_17 + ((y[((long)(int)((yOff + 1))) << 2]) * x);
            val_17 = val_3 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_17;
            int val_4 = yOff + 2;
            val_19 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 2) >= val_19)
            {
                    val_19 = z.Length;
            }
            
            val_3 = val_17 + ((y[((long)(int)((yOff + 2))) << 2]) * x);
            val_17 = val_3 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_17;
            int val_6 = yOff + 3;
            val_20 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 3) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            val_3 = val_17 + ((y[((long)(int)((yOff + 3))) << 2]) * x);
            val_17 = val_3 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_17;
            int val_8 = yOff + 4;
            val_21 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 4) >= val_21)
            {
                    val_21 = z.Length;
            }
            
            val_3 = val_17 + ((y[((long)(int)((yOff + 4))) << 2]) * x);
            val_17 = val_3 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_17;
            int val_10 = yOff + 5;
            val_22 = z.Length;
            val_17 = val_17 >> 32;
            if((zOff + 5) >= val_22)
            {
                    val_22 = z.Length;
            }
            
            val_3 = val_17 + ((y[((long)(int)((yOff + 5))) << 2]) * x);
            val_17 = val_3 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_17;
            int val_12 = yOff + 6;
            val_23 = z.Length;
            if((zOff + 6) >= val_23)
            {
                    val_23 = z.Length;
            }
            
            val_3 = (val_17 >> 32) + ((y[((long)(int)((yOff + 6))) << 2]) * x);
            uint val_15 = val_3 + (z[((long)(int)((zOff + 6))) << 2]);
            mem2[0] = val_15;
            return (uint)val_15 >> 32;
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zOff:  zOff, zPos:  4);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zOff:  zOff, zPos:  3);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  7, z:  z, zOff:  zOff, zPos:  3);
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
            while(val_3 != 7);
            
            return (uint)val_2;
        }
        public static void Square(uint[] x, uint[] zz)
        {
            int val_29;
            int val_30;
            int val_31;
            int val_32;
            int val_33;
            int val_34;
            System.UInt32[] val_56 = x;
            uint val_32 = val_56[0];
            var val_35 = 0;
            var val_34 = 14;
            do
            {
                var val_2 = val_35 + 13;
                uint val_3 = val_56[3] * val_56[3];
                zz[0] = val_3 >> 33;
                var val_5 = val_35 + 12;
                zz[0] = val_3 >> 1;
                val_34 = val_34 - 1;
                val_35 = val_35 - 2;
            }
            while((val_34 - 8) > 1);
            
            uint val_7 = val_32 * val_32;
            zz[0] = val_7;
            uint val_8 = val_7 >> 33;
            val_29 = zz.Length;
            uint val_36 = val_56[0];
            if(val_29 <= 2)
            {
                    val_29 = zz.Length;
            }
            
            uint val_37 = zz[1];
            uint val_9 = val_8 + (val_36 * val_32);
            zz[0] = (ulong)(val_7 >> 32) & 1;
            val_30 = zz.Length;
            uint val_38 = val_56[1];
            if(val_30 <= 3)
            {
                    val_30 = zz.Length;
            }
            
            uint val_39 = zz[1];
            val_8 = val_9 >> 31;
            val_37 = val_37 + (val_9 >> 32);
            if(val_30 <= 4)
            {
                    val_30 = zz.Length;
            }
            
            uint val_10 = val_37 + (val_38 * val_32);
            zz[1] = val_8;
            uint val_41 = val_36;
            val_41 = val_38 * val_41;
            val_37 = val_41 + (val_10 >> 32);
            val_31 = zz.Length;
            uint val_42 = val_56[1];
            val_39 = val_37 + val_39;
            if(val_31 <= 5)
            {
                    val_31 = zz.Length;
            }
            
            val_9 = val_10 >> 31;
            val_38 = val_39 & 4294967295;
            if(val_31 <= 6)
            {
                    val_31 = zz.Length;
            }
            
            val_39 = val_38 + (val_42 * val_32);
            zz[1] = val_9;
            uint val_12 = (val_39 >> 32) + zz[2];
            uint val_51 = val_36;
            val_12 = val_12 + (val_42 * val_51);
            uint val_13 = val_12 + (val_39 >> 32);
            uint val_14 = val_42 * val_38;
            val_32 = zz.Length;
            uint val_45 = val_56[2];
            val_14 = val_14 + (val_13 >> 32);
            if(val_32 <= 7)
            {
                    val_32 = zz.Length;
            }
            
            val_14 = val_14 + zz[2];
            val_32 = val_39 >> 31;
            val_39 = val_13 & 4294967295;
            if(val_32 <= 8)
            {
                    val_32 = zz.Length;
            }
            
            val_13 = val_14 >> 32;
            val_14 = val_14 & 4294967295;
            val_39 = val_39 + (val_45 * val_32);
            zz[2] = val_32;
            uint val_16 = (val_14 + (val_45 * val_51)) + (val_39 >> 32);
            uint val_17 = val_13 + zz[3];
            val_17 = val_17 + (val_45 * val_38);
            val_13 = val_17 + (val_16 >> 32);
            uint val_18 = val_45 * val_42;
            val_33 = zz.Length;
            uint val_48 = val_56[2];
            val_18 = val_18 + (val_13 >> 32);
            if(val_33 <= 9)
            {
                    val_33 = zz.Length;
            }
            
            val_18 = val_18 + zz[3];
            val_39 = val_16 & 4294967295;
            if(val_33 <= 10)
            {
                    val_33 = zz.Length;
            }
            
            val_51 = val_13 & 4294967295;
            val_13 = val_18 >> 32;
            val_18 = val_18 & 4294967295;
            val_39 = val_39 + (val_48 * val_32);
            zz[2] = val_39 >> 31;
            uint val_53 = val_38;
            uint val_52 = val_36;
            val_52 = val_51 + (val_48 * val_52);
            uint val_20 = val_52 + (val_39 >> 32);
            val_53 = val_18 + (val_48 * val_53);
            val_16 = val_53 + (val_20 >> 32);
            uint val_54 = zz[4];
            val_54 = val_13 + val_54;
            val_54 = val_54 + (val_48 * val_42);
            val_13 = val_54 + (val_16 >> 32);
            val_34 = zz.Length;
            uint val_55 = val_56[3];
            val_56 = val_48 * val_45;
            if(val_34 <= 11)
            {
                    val_34 = zz.Length;
            }
            
            val_39 = val_39 >> 31;
            val_51 = val_20 & 4294967295;
            val_56 = val_56 + zz[4];
            if(val_34 <= 12)
            {
                    val_34 = zz.Length;
            }
            
            uint val_22 = val_16 & 4294967295;
            val_16 = val_13;
            uint val_23 = val_56 >> 32;
            uint val_24 = val_56 & 4294967295;
            uint val_25 = val_51 + (val_55 * val_32);
            if(val_34 <= 6)
            {
                    val_34 = zz.Length;
            }
            
            zz[3] = val_39;
            uint val_59 = val_36;
            uint val_60 = val_42;
            uint val_61 = zz[5];
            uint val_26 = val_55 * val_48;
            val_59 = val_22 + (val_55 * val_59);
            uint val_62 = val_45;
            val_60 = val_24 + (val_55 * val_60);
            val_61 = val_23 + val_61;
            val_22 = val_55 + (val_59 >> 32);
            val_62 = val_61 + (val_55 * val_62);
            val_24 = val_60;
            val_23 = val_62 + (val_24 >> 32);
            if(val_34 <= 7)
            {
                    val_34 = zz.Length;
            }
            
            uint val_29 = val_26 + (val_23 >> 32);
            zz[3] = val_48;
            if(val_34 <= 8)
            {
                    val_34 = zz.Length;
            }
            
            zz[4] = val_26;
            if(val_34 <= 9)
            {
                    val_34 = zz.Length;
            }
            
            zz[4] = val_22;
            val_29 = zz[6] + ((val_29 + zz[5]) >> 32);
            if(val_34 <= 10)
            {
                    val_34 = zz.Length;
            }
            
            zz[5] = val_24;
            if(val_34 <= 11)
            {
                    val_34 = zz.Length;
            }
            
            zz[5] = val_23;
            if(val_34 <= 12)
            {
                    val_34 = zz.Length;
            }
            
            zz[6] = val_23;
            val_23 = val_29 >> 31;
            if(val_34 <= 13)
            {
                    val_34 = zz.Length;
            }
            
            uint val_63 = zz[6];
            val_63 = val_63 + (val_29 >> 32);
            zz[6] = val_23;
        }
        public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
        {
            int val_63;
            int val_64;
            int val_65;
            int val_66;
            int val_67;
            var val_68;
            int val_69;
            var val_70;
            var val_71;
            int val_72;
            uint val_63 = x[((long)(int)(xOff)) << 2];
            int val_2 = zzOff + 13;
            var val_65 = 7;
            do
            {
                int val_3 = (xOff + 6) + val_65;
                val_3 = val_3 - 7;
                uint val_4 = (x[((long)(int)((((xOff + 6) + 7) - 7))) << 2]) * (x[((long)(int)((((xOff + 6) + 7) - 7))) << 2]);
                zz[((long)(int)((zzOff + 13))) << 2] = val_4 >> 33;
                int val_6 = val_2 - 1;
                val_65 = val_65 - 1;
                val_2 = val_2 - 2;
                zz[((long)(int)(((zzOff + 13) - 1))) << 2] = val_4 >> 1;
            }
            while(val_65 > 1);
            
            uint val_8 = val_63 * val_63;
            zz[((long)(int)(zzOff)) << 2] = val_8;
            int val_66 = xOff;
            val_66 = val_66 + 1;
            val_63 = zz.Length;
            uint val_67 = x[((long)(int)((xOff + 1))) << 2];
            if((zzOff + 2) >= val_63)
            {
                    val_63 = zz.Length;
            }
            
            uint val_11 = (val_8 >> 33) + (val_67 * val_63);
            int val_12 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = (ulong)(val_8 >> 32) & 1;
            int val_69 = xOff;
            val_69 = val_69 + 2;
            uint val_70 = x[((long)(int)((xOff + 2))) << 2];
            val_64 = zz.Length;
            if((zzOff + 3) >= val_64)
            {
                    val_64 = zz.Length;
            }
            
            val_11 = (zz[((long)(int)((zzOff + 2))) << 2]) + (val_11 >> 32);
            if((zzOff + 4) >= val_64)
            {
                    val_64 = zz.Length;
            }
            
            uint val_77 = val_70;
            val_11 = val_11 + (val_77 * val_63);
            mem2[0] = val_11 >> 31;
            uint val_73 = val_67;
            val_73 = val_77 * val_73;
            int val_74 = xOff;
            val_74 = val_74 + 3;
            uint val_17 = (val_73 + (val_11 >> 32)) + (zz[((long)(int)((zzOff + 3))) << 2]);
            uint val_75 = x[((long)(int)((xOff + 3))) << 2];
            val_65 = zz.Length;
            if((zzOff + 5) >= val_65)
            {
                    val_65 = zz.Length;
            }
            
            val_77 = val_11 >> 31;
            if((zzOff + 6) >= val_65)
            {
                    val_65 = zz.Length;
            }
            
            val_17 = val_17 >> 32;
            uint val_21 = (val_17 & 4294967295) + (val_75 * val_63);
            var val_80 = val_75;
            mem2[0] = val_77;
            uint val_79 = zz[((long)(int)((zzOff + 4))) << 2];
            val_79 = val_17 + val_79;
            val_79 = val_79 + (val_80 * val_67);
            val_80 = val_79 + (val_21 >> 32);
            uint val_22 = val_80 * val_70;
            int val_23 = xOff + 4;
            uint val_81 = x[((long)(int)((xOff + 4))) << 2];
            val_66 = zz.Length;
            val_22 = val_22 + (val_80 >> 32);
            if((zzOff + 7) >= val_66)
            {
                    val_66 = zz.Length;
            }
            
            val_22 = val_22 + (zz[((long)(int)((zzOff + 5))) << 2]);
            uint val_82 = zz[((long)(int)((zzOff + 7))) << 2];
            val_21 = val_21 >> 31;
            val_80 = val_80 & 4294967295;
            if((zzOff + 8) >= val_66)
            {
                    val_66 = zz.Length;
            }
            
            val_22 = val_22 & 4294967295;
            uint val_27 = val_80 + (val_81 * val_63);
            var val_86 = val_81;
            mem2[0] = val_21;
            uint val_84 = zz[((long)(int)((zzOff + 6))) << 2];
            val_84 = (val_22 >> 32) + val_84;
            uint val_29 = (val_22 + (val_86 * val_67)) + (val_27 >> 32);
            uint val_85 = val_70;
            val_85 = val_84 + (val_86 * val_85);
            uint val_30 = val_85 + (val_29 >> 32);
            val_86 = val_86 * val_75;
            int val_31 = xOff + 5;
            uint val_87 = x[((long)(int)((xOff + 5))) << 2];
            val_67 = zz.Length;
            val_86 = val_86 + (val_30 >> 32);
            int val_32 = zzOff + 9;
            val_68 = (long)val_32;
            if(val_32 >= val_67)
            {
                    val_67 = zz.Length;
                val_68 = val_68;
            }
            
            val_82 = val_86 + val_82;
            if((zzOff + 10) >= val_67)
            {
                    val_67 = zz.Length;
            }
            
            uint val_89 = zz[((long)(int)((zzOff + 10))) << 2];
            uint val_92 = val_87;
            val_29 = val_82 >> 32;
            val_82 = val_82 & 4294967295;
            uint val_37 = (val_29 & 4294967295) + (val_92 * val_63);
            mem2[0] = val_27 >> 31;
            uint val_90 = zz[((long)(int)((zzOff + 8))) << 2];
            uint val_40 = ((val_30 & 4294967295) + (val_92 * val_67)) + (val_37 >> 32);
            uint val_91 = val_75;
            val_82 = (val_82 + (val_92 * val_70)) + (val_40 >> 32);
            val_90 = val_29 + val_90;
            val_91 = val_90 + (val_92 * val_91);
            val_92 = val_91;
            uint val_41 = val_92 * val_81;
            int val_93 = xOff;
            val_93 = val_93 + 6;
            val_69 = zz.Length;
            uint val_94 = x[((long)(int)((xOff + 6))) << 2];
            int val_42 = zzOff + 11;
            val_41 = val_41 + (val_92 >> 32);
            val_70 = (long)val_42;
            if(val_42 >= val_69)
            {
                    val_69 = zz.Length;
                val_70 = val_70;
            }
            
            uint val_44 = val_41 + (zz[((long)(int)((zzOff + 9))) << 2]);
            val_40 = val_40 & 4294967295;
            int val_45 = zzOff + 12;
            val_71 = (long)val_45;
            if(val_45 >= val_69)
            {
                    val_69 = zz.Length;
                val_71 = val_71;
            }
            
            uint val_48 = val_44 & 4294967295;
            mem2[0] = val_37 >> 31;
            uint val_97 = val_70;
            val_97 = (val_92 & 4294967295) + (val_94 * val_97);
            uint val_54 = val_44 >> 32;
            uint val_55 = val_97;
            uint val_57 = val_94 + (val_55 >> 32);
            val_94 = val_94 * val_87;
            val_94 = val_94 + (val_94 >> 32);
            mem2[0] = val_82;
            mem2[0] = val_94 + ((val_40 + (val_94 * val_63)) >> 32);
            mem2[0] = val_55;
            val_94 = (zz[((long)(int)((zzOff + 12))) << 2]) + ((val_94 + (zz[((long)(int)((zzOff + 11))) << 2])) >> 32);
            mem2[0] = val_55;
            mem2[0] = val_55;
            mem2[0] = val_55;
            val_72 = zz.Length;
            if((zzOff + 13) >= val_72)
            {
                    val_72 = zz.Length;
            }
            
            uint val_98 = zz[((long)(int)((zzOff + 13))) << 2];
            val_98 = val_98 + (val_94 >> 32);
            mem2[0] = val_94 >> 31;
        }
        public static int Sub(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_16 = y;
            uint val_2 = x[0];
            val_2 = val_2 - val_16[0];
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_16[0];
            val_5 = x[0] - val_5;
            val_2 = val_5 + val_2;
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_16[1];
            val_7 = x[1] - val_7;
            val_2 = val_7 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_16[1];
            val_9 = x[1] - val_9;
            val_2 = val_9 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_16[2];
            val_11 = x[2] - val_11;
            val_2 = val_11 + val_2;
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_13 = val_16[2];
            val_13 = x[2] - val_13;
            val_2 = val_13 + val_2;
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_15 = val_16[3];
            val_15 = x[3] - val_15;
            val_16 = val_15 + val_2;
            z[3] = val_16;
            return (int)val_16 >> 32;
        }
        public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_22 = x[((long)(int)(xOff)) << 2];
            val_22 = val_22 - (y[((long)(int)(yOff)) << 2]);
            z[((long)(int)(zOff)) << 2] = val_22;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_22 = val_22 >> 32;
            uint val_25 = y[((long)(int)((yOff + 1))) << 2];
            int val_3 = zOff + 1;
            val_25 = (x[((long)(int)((xOff + 1))) << 2]) - val_25;
            val_22 = val_25 + val_22;
            z[((long)(int)((zOff + 1))) << 2] = val_22;
            int val_4 = xOff + 2;
            int val_5 = yOff + 2;
            val_22 = val_22 >> 32;
            uint val_27 = y[((long)(int)((yOff + 2))) << 2];
            int val_6 = zOff + 2;
            val_27 = (x[((long)(int)((xOff + 2))) << 2]) - val_27;
            val_22 = val_27 + val_22;
            z[((long)(int)((zOff + 2))) << 2] = val_22;
            int val_7 = xOff + 3;
            int val_8 = yOff + 3;
            val_22 = val_22 >> 32;
            uint val_29 = y[((long)(int)((yOff + 3))) << 2];
            int val_9 = zOff + 3;
            val_29 = (x[((long)(int)((xOff + 3))) << 2]) - val_29;
            val_22 = val_29 + val_22;
            z[((long)(int)((zOff + 3))) << 2] = val_22;
            int val_10 = xOff + 4;
            int val_11 = yOff + 4;
            val_22 = val_22 >> 32;
            uint val_31 = y[((long)(int)((yOff + 4))) << 2];
            int val_12 = zOff + 4;
            val_31 = (x[((long)(int)((xOff + 4))) << 2]) - val_31;
            val_22 = val_31 + val_22;
            z[((long)(int)((zOff + 4))) << 2] = val_22;
            int val_13 = xOff + 5;
            int val_14 = yOff + 5;
            val_22 = val_22 >> 32;
            uint val_33 = y[((long)(int)((yOff + 5))) << 2];
            int val_15 = zOff + 5;
            val_33 = (x[((long)(int)((xOff + 5))) << 2]) - val_33;
            val_22 = val_33 + val_22;
            z[((long)(int)((zOff + 5))) << 2] = val_22;
            int val_16 = xOff + 6;
            int val_17 = yOff + 6;
            uint val_35 = y[((long)(int)((yOff + 6))) << 2];
            int val_19 = zOff + 6;
            val_35 = (x[((long)(int)((xOff + 6))) << 2]) - val_35;
            uint val_20 = val_35 + (val_22 >> 32);
            z[((long)(int)((zOff + 6))) << 2] = val_20;
            return (int)val_20 >> 32;
        }
        public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            System.UInt32[] val_24 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            uint val_1 = val_3 - x[0];
            val_3 = val_1 - val_24[0];
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            val_1 = val_3 + z[0];
            val_1 = val_1 - x[0];
            val_3 = val_1 - val_24[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_24[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_6 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_24[1];
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_7 = z.Length;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_3 = val_1 - val_24[2];
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_8 = z.Length;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_3 = val_1 - val_24[2];
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + z[3];
            val_1 = val_1 - x[3];
            val_24 = val_1 - val_24[3];
            z[3] = val_24;
            return (int)val_24 >> 32;
        }
        public static int SubFrom(uint[] x, uint[] z)
        {
            int val_2;
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            System.UInt32[] val_16 = x;
            uint val_2 = z[0];
            val_2 = z.Length;
            val_2 = val_2 - val_16[0];
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_16[0];
            val_3 = z.Length;
            val_5 = z[0] - val_5;
            val_2 = val_5 + val_2;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_16[1];
            val_4 = z.Length;
            val_7 = z[1] - val_7;
            val_2 = val_7 + val_2;
            if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_16[1];
            val_5 = z.Length;
            val_9 = z[1] - val_9;
            val_2 = val_9 + val_2;
            if(val_5 <= 3)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_16[2];
            val_6 = z.Length;
            val_11 = z[2] - val_11;
            val_2 = val_11 + val_2;
            if(val_6 <= 4)
            {
                    val_6 = z.Length;
            }
            
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_13 = val_16[2];
            val_7 = z.Length;
            val_13 = z[2] - val_13;
            val_2 = val_13 + val_2;
            if(val_7 <= 5)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_15 = val_16[3];
            val_15 = z[3] - val_15;
            val_16 = val_15 + val_2;
            z[3] = val_16;
            return (int)val_16 >> 32;
        }
        public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
        {
            System.UInt32[] val_29 = z;
            uint val_1 = (val_29[((long)(int)(zOff)) << 2]) - (x[((long)(int)(xOff)) << 2]);
            mem2[0] = val_1;
            int val_2 = zOff + 1;
            int val_3 = xOff + 1;
            val_1 = val_1 >> 32;
            uint val_18 = x[((long)(int)((xOff + 1))) << 2];
            val_18 = (val_29[((long)(int)((zOff + 1))) << 2]) - val_18;
            val_1 = val_18 + val_1;
            mem2[0] = val_1;
            int val_4 = zOff + 2;
            int val_5 = xOff + 2;
            val_1 = val_1 >> 32;
            uint val_20 = x[((long)(int)((xOff + 2))) << 2];
            val_20 = (val_29[((long)(int)((zOff + 2))) << 2]) - val_20;
            val_1 = val_20 + val_1;
            mem2[0] = val_1;
            int val_6 = zOff + 3;
            int val_7 = xOff + 3;
            val_1 = val_1 >> 32;
            uint val_22 = x[((long)(int)((xOff + 3))) << 2];
            val_22 = (val_29[((long)(int)((zOff + 3))) << 2]) - val_22;
            val_1 = val_22 + val_1;
            mem2[0] = val_1;
            int val_8 = zOff + 4;
            int val_9 = xOff + 4;
            val_1 = val_1 >> 32;
            uint val_24 = x[((long)(int)((xOff + 4))) << 2];
            val_24 = (val_29[((long)(int)((zOff + 4))) << 2]) - val_24;
            val_1 = val_24 + val_1;
            mem2[0] = val_1;
            int val_10 = zOff + 5;
            int val_11 = xOff + 5;
            val_1 = val_1 >> 32;
            uint val_26 = x[((long)(int)((xOff + 5))) << 2];
            val_26 = (val_29[((long)(int)((zOff + 5))) << 2]) - val_26;
            val_1 = val_26 + val_1;
            mem2[0] = val_1;
            int val_12 = zOff + 6;
            int val_13 = xOff + 6;
            val_1 = val_1 >> 32;
            uint val_28 = x[((long)(int)((xOff + 6))) << 2];
            val_28 = (val_29[((long)(int)((zOff + 6))) << 2]) - val_28;
            val_29 = val_28 + val_1;
            mem2[0] = val_29;
            return (int)val_29 >> 32;
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
        {
            byte[] val_1 = new byte[28];
            var val_3 = 0;
            var val_4 = 24;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  1134694512, bs:  val_1, off:  24);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 4;
            }
            while(val_3 != 7);
            
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
            if(val_1 <= 5)
            {
                    val_1 = z.Length;
            }
            
            z[2] = 0;
            z[3] = 0;
        }
        protected Nat224()
        {
        
        }
    
    }

}
