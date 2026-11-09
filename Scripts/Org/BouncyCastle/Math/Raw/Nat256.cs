using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat256
    {
        // Fields
        private const ulong M = 4294967295;
        
        // Methods
        public static uint Add(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_19 = y;
            uint val_3 = x[0];
            val_3 = val_19[0] + val_3;
            z[0] = val_3;
            val_3 = val_3 >> 32;
            uint val_1 = val_3 + x[0];
            val_3 = val_1 + val_19[0];
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_19[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[1];
            val_3 = val_1 + val_19[1];
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_3 = val_1 + val_19[2];
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[2];
            val_3 = val_1 + val_19[2];
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[3];
            val_3 = val_1 + val_19[3];
            z[3] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + x[3];
            val_19 = val_1 + val_19[3];
            z[3] = val_19;
            return (uint)val_19 >> 32;
        }
        public static uint Add(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_26 = x[((long)(int)(xOff)) << 2];
            val_26 = (y[((long)(int)(yOff)) << 2]) + val_26;
            z[((long)(int)(zOff)) << 2] = val_26;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_26 = val_26 >> 32;
            uint val_3 = val_26 + (x[((long)(int)((xOff + 1))) << 2]);
            int val_4 = zOff + 1;
            val_26 = val_3 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_26;
            int val_5 = xOff + 2;
            int val_6 = yOff + 2;
            val_26 = val_26 >> 32;
            val_3 = val_26 + (x[((long)(int)((xOff + 2))) << 2]);
            int val_7 = zOff + 2;
            val_26 = val_3 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_26;
            int val_8 = xOff + 3;
            int val_9 = yOff + 3;
            val_26 = val_26 >> 32;
            val_3 = val_26 + (x[((long)(int)((xOff + 3))) << 2]);
            int val_10 = zOff + 3;
            val_26 = val_3 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_26;
            int val_11 = xOff + 4;
            int val_12 = yOff + 4;
            val_26 = val_26 >> 32;
            val_3 = val_26 + (x[((long)(int)((xOff + 4))) << 2]);
            int val_13 = zOff + 4;
            val_26 = val_3 + (y[((long)(int)((yOff + 4))) << 2]);
            z[((long)(int)((zOff + 4))) << 2] = val_26;
            int val_14 = xOff + 5;
            int val_15 = yOff + 5;
            val_26 = val_26 >> 32;
            val_3 = val_26 + (x[((long)(int)((xOff + 5))) << 2]);
            int val_16 = zOff + 5;
            val_26 = val_3 + (y[((long)(int)((yOff + 5))) << 2]);
            z[((long)(int)((zOff + 5))) << 2] = val_26;
            int val_17 = xOff + 6;
            int val_18 = yOff + 6;
            val_26 = val_26 >> 32;
            val_3 = val_26 + (x[((long)(int)((xOff + 6))) << 2]);
            int val_19 = zOff + 6;
            val_26 = val_3 + (y[((long)(int)((yOff + 6))) << 2]);
            z[((long)(int)((zOff + 6))) << 2] = val_26;
            int val_20 = xOff + 7;
            int val_21 = yOff + 7;
            val_3 = (val_26 >> 32) + (x[((long)(int)((xOff + 7))) << 2]);
            int val_23 = zOff + 7;
            uint val_24 = val_3 + (y[((long)(int)((yOff + 7))) << 2]);
            z[((long)(int)((zOff + 7))) << 2] = val_24;
            return (uint)val_24 >> 32;
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
            int val_10;
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
            val_3 = val_3 >> 32;
            if(val_9 <= 6)
            {
                    val_9 = z.Length;
            }
            
            val_1 = val_3 + x[3];
            val_1 = val_1 + y[3];
            val_3 = val_1 + z[3];
            z[3] = val_3;
            val_10 = z.Length;
            uint val_25 = y[3];
            val_3 = val_3 >> 32;
            if(val_10 <= 7)
            {
                    val_10 = z.Length;
            }
            
            val_1 = val_3 + x[3];
            val_1 = val_1 + val_25;
            val_25 = val_1 + z[3];
            z[3] = val_25;
            return (uint)val_25 >> 32;
        }
        public static uint AddBothTo(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            uint val_19 = x[((long)(int)(xOff)) << 2];
            val_19 = z.Length;
            if(val_19 <= zOff)
            {
                    val_19 = z.Length;
            }
            
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + val_19;
            val_19 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_19;
            int val_2 = xOff + 1;
            int val_23 = yOff;
            val_23 = val_23 + 1;
            val_20 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 1) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 1))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 1))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_19;
            int val_4 = xOff + 2;
            int val_27 = yOff;
            val_27 = val_27 + 2;
            val_21 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 2) >= val_21)
            {
                    val_21 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 2))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 2))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_19;
            int val_6 = xOff + 3;
            int val_31 = yOff;
            val_31 = val_31 + 3;
            val_22 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 3) >= val_22)
            {
                    val_22 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 3))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 3))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_19;
            int val_8 = xOff + 4;
            int val_35 = yOff;
            val_35 = val_35 + 4;
            val_23 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 4) >= val_23)
            {
                    val_23 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 4))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 4))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_19;
            int val_10 = xOff + 5;
            int val_39 = yOff;
            val_39 = val_39 + 5;
            val_24 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 5) >= val_24)
            {
                    val_24 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 5))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 5))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_19;
            int val_12 = xOff + 6;
            int val_43 = yOff;
            val_43 = val_43 + 6;
            val_25 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 6) >= val_25)
            {
                    val_25 = z.Length;
            }
            
            val_1 = val_19 + (x[((long)(int)((xOff + 6))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 6))) << 2]);
            val_19 = val_1 + (z[((long)(int)((zOff + 6))) << 2]);
            mem2[0] = val_19;
            int val_14 = xOff + 7;
            int val_47 = yOff;
            val_47 = val_47 + 7;
            val_26 = z.Length;
            if((zOff + 7) >= val_26)
            {
                    val_26 = z.Length;
            }
            
            val_1 = (val_19 >> 32) + (x[((long)(int)((xOff + 7))) << 2]);
            val_1 = val_1 + (y[((long)(int)((yOff + 7))) << 2]);
            uint val_17 = val_1 + (z[((long)(int)((zOff + 7))) << 2]);
            mem2[0] = val_17;
            return (uint)val_17 >> 32;
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
            int val_10;
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
            val_3 = val_3 >> 32;
            if(val_9 <= 6)
            {
                    val_9 = z.Length;
            }
            
            val_1 = val_3 + x[3];
            val_3 = val_1 + z[3];
            z[3] = val_3;
            val_10 = z.Length;
            uint val_17 = x[3];
            val_3 = val_3 >> 32;
            if(val_10 <= 7)
            {
                    val_10 = z.Length;
            }
            
            val_1 = val_3 + val_17;
            val_17 = val_1 + z[3];
            z[3] = val_17;
            return (uint)val_17 >> 32;
        }
        public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
        {
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            uint val_21 = cIn;
            val_19 = z.Length;
            if(val_19 <= zOff)
            {
                    val_19 = z.Length;
            }
            
            uint val_1 = (x[((long)(int)(xOff)) << 2]) + val_21;
            val_21 = val_1 + (z[((long)(int)(zOff)) << 2]);
            mem2[0] = val_21;
            int val_2 = xOff + 1;
            val_20 = z.Length;
            val_21 = val_21 >> 32;
            if((zOff + 1) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            val_1 = val_21 + (x[((long)(int)((xOff + 1))) << 2]);
            val_21 = val_1 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_21;
            int val_4 = xOff + 2;
            val_21 = z.Length;
            val_21 = val_21 >> 32;
            if((zOff + 2) >= val_21)
            {
                    val_21 = z.Length;
            }
            
            val_1 = val_21 + (x[((long)(int)((xOff + 2))) << 2]);
            val_21 = val_1 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_21;
            int val_6 = xOff + 3;
            val_22 = z.Length;
            val_21 = val_21 >> 32;
            if((zOff + 3) >= val_22)
            {
                    val_22 = z.Length;
            }
            
            val_1 = val_21 + (x[((long)(int)((xOff + 3))) << 2]);
            val_21 = val_1 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_21;
            int val_8 = xOff + 4;
            val_23 = z.Length;
            val_21 = val_21 >> 32;
            if((zOff + 4) >= val_23)
            {
                    val_23 = z.Length;
            }
            
            val_1 = val_21 + (x[((long)(int)((xOff + 4))) << 2]);
            val_21 = val_1 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_21;
            int val_10 = xOff + 5;
            val_24 = z.Length;
            val_21 = val_21 >> 32;
            if((zOff + 5) >= val_24)
            {
                    val_24 = z.Length;
            }
            
            val_1 = val_21 + (x[((long)(int)((xOff + 5))) << 2]);
            val_21 = val_1 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_21;
            int val_12 = xOff + 6;
            val_25 = z.Length;
            val_21 = val_21 >> 32;
            if((zOff + 6) >= val_25)
            {
                    val_25 = z.Length;
            }
            
            val_1 = val_21 + (x[((long)(int)((xOff + 6))) << 2]);
            val_21 = val_1 + (z[((long)(int)((zOff + 6))) << 2]);
            mem2[0] = val_21;
            int val_14 = xOff + 7;
            val_26 = z.Length;
            if((zOff + 7) >= val_26)
            {
                    val_26 = z.Length;
            }
            
            val_1 = (val_21 >> 32) + (x[((long)(int)((xOff + 7))) << 2]);
            uint val_17 = val_1 + (z[((long)(int)((zOff + 7))) << 2]);
            mem2[0] = val_17;
            return (uint)val_17 >> 32;
        }
        public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
        {
            System.UInt32[] val_34 = u;
            uint val_18 = val_34[((long)(int)(uOff)) << 2];
            val_18 = (v[((long)(int)(vOff)) << 2]) + val_18;
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_1 = uOff + 1;
            int val_2 = vOff + 1;
            val_18 = val_18 >> 32;
            uint val_3 = val_18 + (val_34[((long)(int)((uOff + 1))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 1))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_4 = uOff + 2;
            int val_5 = vOff + 2;
            val_18 = val_18 >> 32;
            val_3 = val_18 + (val_34[((long)(int)((uOff + 2))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 2))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_6 = uOff + 3;
            int val_7 = vOff + 3;
            val_18 = val_18 >> 32;
            val_3 = val_18 + (val_34[((long)(int)((uOff + 3))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 3))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_8 = uOff + 4;
            int val_9 = vOff + 4;
            val_18 = val_18 >> 32;
            val_3 = val_18 + (val_34[((long)(int)((uOff + 4))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 4))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_10 = uOff + 5;
            int val_11 = vOff + 5;
            val_18 = val_18 >> 32;
            val_3 = val_18 + (val_34[((long)(int)((uOff + 5))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 5))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_12 = uOff + 6;
            int val_13 = vOff + 6;
            val_18 = val_18 >> 32;
            val_3 = val_18 + (val_34[((long)(int)((uOff + 6))) << 2]);
            val_18 = val_3 + (v[((long)(int)((vOff + 6))) << 2]);
            mem2[0] = val_18;
            mem2[0] = val_18;
            int val_14 = uOff + 7;
            int val_15 = vOff + 7;
            val_3 = (val_18 >> 32) + (val_34[((long)(int)((uOff + 7))) << 2]);
            val_34 = val_3 + (v[((long)(int)((vOff + 7))) << 2]);
            mem2[0] = val_34;
            mem2[0] = val_34;
            return (uint)val_34 >> 32;
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
            z[3] = x[3];
        }
        public static void Copy64(ulong[] x, ulong[] z)
        {
            z[0] = x[0];
            z[1] = x[1];
            z[2] = x[2];
            z[3] = x[3];
        }
        public static uint[] Create()
        {
            uint[] val_1 = new uint[8];
        }
        public static ulong[] Create64()
        {
            ulong[] val_1 = new ulong[4];
        }
        public static uint[] CreateExt()
        {
            uint[] val_1 = new uint[16];
        }
        public static ulong[] CreateExt64()
        {
            ulong[] val_1 = new ulong[8];
        }
        public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_4;
            if((Org.BouncyCastle.Math.Raw.Nat256.Gte(x:  x, xOff:  xOff, y:  y, yOff:  yOff)) != false)
            {
                    int val_2 = Org.BouncyCastle.Math.Raw.Nat256.Sub(x:  x, xOff:  xOff, y:  y, yOff:  yOff, z:  z, zOff:  zOff);
                val_4 = 1;
                return (bool)val_4;
            }
            
            int val_3 = Org.BouncyCastle.Math.Raw.Nat256.Sub(x:  y, xOff:  yOff, y:  x, yOff:  xOff, z:  z, zOff:  zOff);
            val_4 = 0;
            return (bool)val_4;
        }
        public static bool Eq(uint[] x, uint[] y)
        {
            var val_1;
            var val_2;
            val_1 = 15;
            label_5:
            if(x[3] != y[3])
            {
                goto label_4;
            }
            
            val_1 = val_1 - 1;
            if(7 > 0)
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
            val_1 = 7;
            label_5:
            if(x[3] != y[3])
            {
                goto label_4;
            }
            
            val_1 = val_1 - 1;
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
        public static uint[] FromBigInteger(Org.BouncyCastle.Math.BigInteger x)
        {
            Org.BouncyCastle.Math.BigInteger val_8 = x;
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 257))
            {
                goto label_4;
            }
            
            System.UInt32[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.Create();
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
            if(((val_8.SignValue & 2147483648) != 0) || (val_8.BitLength >= 257))
            {
                goto label_4;
            }
            
            System.UInt64[] val_3 = Org.BouncyCastle.Math.Raw.Nat256.Create64();
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
            
            if((val_3 & 4294967040) != 0)
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
            val_1 = 15;
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
            val_3 = 7;
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
            if(val_3 < 7)
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
            if(val_1 < 7)
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
            int val_16;
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
            if(val_7 <= 6)
            {
                    val_7 = y.Length;
            }
            
            uint val_16 = y[3];
            uint val_17 = y[3];
            uint val_18 = x[0];
            uint val_1 = val_18 * val_10;
            val_8 = zz.Length;
            if(val_8 == 0)
            {
                    val_8 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_19 = val_11;
            val_19 = val_18 * val_19;
            val_1 = val_19 + (val_1 >> 32);
            if(val_8 <= 1)
            {
                    val_8 = zz.Length;
            }
            
            zz[0] = val_1;
            uint val_20 = val_12;
            val_20 = val_18 * val_20;
            val_1 = val_20 + (val_1 >> 32);
            if(val_8 <= 2)
            {
                    val_8 = zz.Length;
            }
            
            zz[1] = val_1;
            uint val_21 = val_13;
            val_21 = val_18 * val_21;
            val_1 = val_21 + (val_1 >> 32);
            if(val_8 <= 3)
            {
                    val_8 = zz.Length;
            }
            
            zz[1] = val_1;
            uint val_22 = val_14;
            val_22 = val_18 * val_22;
            val_1 = val_22 + (val_1 >> 32);
            if(val_8 <= 4)
            {
                    val_8 = zz.Length;
            }
            
            zz[2] = val_1;
            val_1 = (val_18 * val_15) + (val_1 >> 32);
            if(val_8 <= 5)
            {
                    val_8 = zz.Length;
            }
            
            zz[2] = val_1;
            val_1 = (val_18 * val_16) + (val_1 >> 32);
            if(val_8 <= 6)
            {
                    val_8 = zz.Length;
            }
            
            val_18 = (val_18 * val_17) + (val_1 >> 32);
            zz[3] = val_1;
            if(val_8 <= 7)
            {
                    val_8 = zz.Length;
            }
            
            zz[3] = val_18;
            val_18 = val_18 >> 32;
            zz[4] = val_18;
            do
            {
                var val_5 = 9 - 8;
                val_9 = zz.Length;
                uint val_23 = x[0];
                if(val_5 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_6 = null + (val_23 * val_10);
                mem2[0] = val_6;
                val_10 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                uint val_24 = val_11;
                val_24 = val_6 + (val_23 * val_24);
                val_6 = val_24 + 1152921505741541488;
                mem2[0] = val_6;
                val_11 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                uint val_25 = val_12;
                val_25 = val_6 + (val_23 * val_25);
                val_6 = val_25 + 1152921505741541488;
                mem2[0] = val_6;
                val_12 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                uint val_26 = val_13;
                val_26 = val_6 + (val_23 * val_26);
                val_6 = val_26 + 1152921505741541488;
                mem2[0] = val_6;
                val_13 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                uint val_27 = val_14;
                val_27 = val_6 + (val_23 * val_27);
                val_6 = val_27 + 1152921505741541488;
                mem2[0] = val_6;
                val_14 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_14)
            {
                    val_14 = zz.Length;
            }
            
                val_27 = val_6 + (val_23 * val_15);
                val_6 = val_27 + 1152921505741541488;
                mem2[0] = val_6;
                val_15 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_15)
            {
                    val_15 = zz.Length;
            }
            
                val_27 = val_6 + (val_23 * val_16);
                val_6 = val_27 + 1152921505741541488;
                mem2[0] = val_6;
                val_16 = zz.Length;
                val_5 = val_5 + 1;
                val_6 = val_6 >> 32;
                if(val_5 >= val_16)
            {
                    val_16 = zz.Length;
            }
            
                val_27 = val_6 + (val_23 * val_17);
                val_6 = val_27 + 1152921505741541488;
                mem2[0] = val_6;
                mem2[0] = val_6 >> 32;
                var val_9 = 9 + 1;
            }
            while((val_5 + 1) != 15);
        
        }
        public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_40;
            int val_41;
            int val_42;
            int val_43;
            int val_44;
            int val_45;
            int val_46;
            int val_47;
            int val_48;
            val_40 = y.Length;
            if(val_40 <= yOff)
            {
                    val_40 = y.Length;
            }
            
            uint val_40 = y[((long)(int)(yOff)) << 2];
            if((yOff + 1) >= val_40)
            {
                    val_40 = y.Length;
            }
            
            uint val_41 = y[((long)(int)((yOff + 1))) << 2];
            if((yOff + 2) >= val_40)
            {
                    val_40 = y.Length;
            }
            
            uint val_42 = y[((long)(int)((yOff + 2))) << 2];
            if((yOff + 3) >= val_40)
            {
                    val_40 = y.Length;
            }
            
            uint val_43 = y[((long)(int)((yOff + 3))) << 2];
            if((yOff + 4) >= val_40)
            {
                    val_40 = y.Length;
            }
            
            uint val_44 = y[((long)(int)((yOff + 4))) << 2];
            if((yOff + 5) >= val_40)
            {
                    val_40 = y.Length;
            }
            
            uint val_45 = y[((long)(int)((yOff + 5))) << 2];
            if((yOff + 6) >= val_40)
            {
                    val_40 = y.Length;
            }
            
            uint val_46 = y[((long)(int)((yOff + 6))) << 2];
            int val_7 = yOff + 7;
            uint val_47 = y[((long)(int)((yOff + 7))) << 2];
            uint val_48 = x[((long)(int)(xOff)) << 2];
            uint val_8 = val_48 * val_40;
            zz[((long)(int)(zzOff)) << 2] = val_8;
            uint val_49 = val_41;
            val_49 = val_48 * val_49;
            uint val_9 = val_49 + (val_8 >> 32);
            int val_10 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = val_9;
            uint val_50 = val_42;
            val_50 = val_48 * val_50;
            val_9 = val_50 + (val_9 >> 32);
            int val_11 = zzOff + 2;
            zz[((long)(int)((zzOff + 2))) << 2] = val_9;
            uint val_51 = val_43;
            val_51 = val_48 * val_51;
            val_9 = val_51 + (val_9 >> 32);
            int val_12 = zzOff + 3;
            zz[((long)(int)((zzOff + 3))) << 2] = val_9;
            uint val_52 = val_44;
            val_52 = val_48 * val_52;
            val_9 = val_52 + (val_9 >> 32);
            int val_13 = zzOff + 4;
            zz[((long)(int)((zzOff + 4))) << 2] = val_9;
            uint val_53 = val_45;
            val_53 = val_48 * val_53;
            val_9 = val_53 + (val_9 >> 32);
            int val_14 = zzOff + 5;
            zz[((long)(int)((zzOff + 5))) << 2] = val_9;
            uint val_54 = val_46;
            val_54 = val_48 * val_54;
            val_9 = val_54 + (val_9 >> 32);
            int val_15 = zzOff + 6;
            zz[((long)(int)((zzOff + 6))) << 2] = val_9;
            val_9 = (val_48 * val_47) + (val_9 >> 32);
            int val_17 = zzOff + 7;
            zz[((long)(int)((zzOff + 7))) << 2] = val_9;
            int val_18 = zzOff + 8;
            val_9 = val_9 >> 32;
            var val_70 = -7;
            zz[((long)(int)((zzOff + 8))) << 2] = val_9;
            do
            {
                int val_22 = (xOff + 1) + val_70;
                val_22 = val_22 + 7;
                val_41 = zz.Length;
                uint val_55 = x[((long)(int)((((xOff + 1) + -7) + 7))) << 2];
                if(((zzOff + val_70) + 8) >= val_41)
            {
                    val_41 = zz.Length;
            }
            
                uint val_23 = (zz[((long)(int)(((zzOff + -7) + 8))) << 2]) + (val_55 * val_40);
                mem2[0] = val_23;
                val_42 = zz.Length;
                uint val_25 = val_23 >> 32;
                if(((zzOff + val_70) + 9) >= val_42)
            {
                    val_42 = zz.Length;
            }
            
                uint val_58 = val_41;
                val_58 = val_25 + (val_55 * val_58);
                val_25 = val_58 + (zz[((long)(int)(((zzOff + -7) + 9))) << 2]);
                mem2[0] = val_25;
                val_43 = zz.Length;
                val_25 = val_25 >> 32;
                if(((zzOff + val_70) + 10) >= val_43)
            {
                    val_43 = zz.Length;
            }
            
                uint val_60 = val_42;
                val_60 = val_25 + (val_55 * val_60);
                val_25 = val_60 + (zz[((long)(int)(((zzOff + -7) + 10))) << 2]);
                mem2[0] = val_25;
                val_44 = zz.Length;
                val_25 = val_25 >> 32;
                if(((zzOff + val_70) + 11) >= val_44)
            {
                    val_44 = zz.Length;
            }
            
                uint val_62 = val_43;
                val_62 = val_25 + (val_55 * val_62);
                val_25 = val_62 + (zz[((long)(int)(((zzOff + -7) + 11))) << 2]);
                mem2[0] = val_25;
                val_45 = zz.Length;
                val_25 = val_25 >> 32;
                if(((zzOff + val_70) + 12) >= val_45)
            {
                    val_45 = zz.Length;
            }
            
                uint val_64 = val_44;
                val_64 = val_25 + (val_55 * val_64);
                val_25 = val_64 + (zz[((long)(int)(((zzOff + -7) + 12))) << 2]);
                mem2[0] = val_25;
                val_46 = zz.Length;
                val_25 = val_25 >> 32;
                if(((zzOff + val_70) + 13) >= val_46)
            {
                    val_46 = zz.Length;
            }
            
                uint val_66 = val_45;
                val_66 = val_25 + (val_55 * val_66);
                val_25 = val_66 + (zz[((long)(int)(((zzOff + -7) + 13))) << 2]);
                mem2[0] = val_25;
                val_47 = zz.Length;
                val_25 = val_25 >> 32;
                if(((zzOff + val_70) + 14) >= val_47)
            {
                    val_47 = zz.Length;
            }
            
                uint val_68 = val_46;
                val_68 = val_25 + (val_55 * val_68);
                val_25 = val_68 + (zz[((long)(int)(((zzOff + -7) + 14))) << 2]);
                mem2[0] = val_25;
                val_48 = zz.Length;
                val_25 = val_25 >> 32;
                if(((zzOff + val_70) + 15) >= val_48)
            {
                    val_48 = zz.Length;
            }
            
                val_68 = val_25 + (val_55 * val_47);
                val_25 = val_68 + (zz[((long)(int)(((zzOff + -7) + 15))) << 2]);
                mem2[0] = val_25;
                int val_39 = zzOff + val_70;
                val_39 = val_39 + 16;
                val_25 = val_25 >> 32;
                val_70 = val_70 + 1;
                zz[((long)(int)(((zzOff + -7) + 16))) << 2] = val_25;
            }
            while(val_70 != 0);
        
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
            int val_14;
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
            
            if(val_5 <= 6)
            {
                    val_5 = y.Length;
            }
            
            var val_15 = 0;
            do
            {
                val_6 = zz.Length;
                if(val_15 >= val_6)
            {
                    val_6 = zz.Length;
            }
            
                System.UInt32[] val_1 = null + (1152921505741541488 * y[0]);
                mem2[0] = val_1;
                val_7 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_7)
            {
                    val_7 = zz.Length;
            }
            
                uint val_16 = y[0];
                val_16 = val_1 + (1152921505741541488 * val_16);
                mem2[0] = val_1;
                val_8 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_8)
            {
                    val_8 = zz.Length;
            }
            
                uint val_17 = y[1];
                val_17 = val_1 + (1152921505741541488 * val_17);
                mem2[0] = val_1;
                val_9 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_9)
            {
                    val_9 = zz.Length;
            }
            
                uint val_18 = y[1];
                val_18 = val_1 + (1152921505741541488 * val_18);
                mem2[0] = val_1;
                val_10 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_10)
            {
                    val_10 = zz.Length;
            }
            
                uint val_19 = y[2];
                val_19 = val_1 + (1152921505741541488 * val_19);
                mem2[0] = val_1;
                val_11 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_11)
            {
                    val_11 = zz.Length;
            }
            
                uint val_20 = y[2];
                val_20 = val_1 + (1152921505741541488 * val_20);
                mem2[0] = val_1;
                val_12 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_12)
            {
                    val_12 = zz.Length;
            }
            
                System.UInt32[] val_2 = val_1 + (1152921505741541488 * y[3]);
                mem2[0] = val_1;
                val_13 = zz.Length;
                val_15 = val_15 + 1;
                val_1 = val_1 >> 32;
                if(val_15 >= val_13)
            {
                    val_13 = zz.Length;
            }
            
                System.UInt32[] val_3 = val_1 + (1152921505741541488 * y[3]);
                mem2[0] = val_1;
                val_14 = zz.Length;
                var val_4 = val_15 + 1;
                System.UInt32[] val_5 = val_1 >> 32;
                if(val_4 >= val_14)
            {
                    val_14 = zz.Length;
            }
            
                mem2[0] = 0;
            }
            while((val_4 - 7) != 8);
            
            return 0;
        }
        public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            int val_27;
            int val_28;
            int val_27 = zzOff;
            val_19 = y.Length;
            if(val_19 <= yOff)
            {
                    val_19 = y.Length;
            }
            
            if((yOff + 1) >= val_19)
            {
                    val_19 = y.Length;
            }
            
            if((yOff + 2) >= val_19)
            {
                    val_19 = y.Length;
            }
            
            if((yOff + 3) >= val_19)
            {
                    val_19 = y.Length;
            }
            
            if((yOff + 4) >= val_19)
            {
                    val_19 = y.Length;
            }
            
            if((yOff + 5) >= val_19)
            {
                    val_19 = y.Length;
            }
            
            if((yOff + 6) >= val_19)
            {
                    val_19 = y.Length;
            }
            
            int val_7 = yOff + 7;
            uint val_45 = 0;
            var val_46 = -8;
            do
            {
                int val_9 = xOff + val_46;
                val_9 = val_9 + 8;
                val_27 = (val_27 + val_46) + 8;
                uint val_28 = x[((long)(int)(((xOff + -8) + 8))) << 2];
                val_20 = zz.Length;
                if(val_27 >= val_20)
            {
                    val_20 = zz.Length;
            }
            
                uint val_10 = (zz[((long)(int)(((zzOff + -8) + 8))) << 2]) + (val_28 * (y[((long)(int)(yOff)) << 2]));
                mem2[0] = val_10;
                val_21 = zz.Length;
                int val_11 = val_27 + val_46;
                val_11 = val_11 + 9;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_21)
            {
                    val_21 = zz.Length;
            }
            
                uint val_31 = y[((long)(int)((yOff + 1))) << 2];
                val_31 = val_10 + (val_28 * val_31);
                val_10 = val_31 + (zz[((long)(int)(((zzOff + -8) + 9))) << 2]);
                mem2[0] = val_10;
                val_22 = zz.Length;
                int val_12 = val_27 + val_46;
                val_12 = val_12 + 10;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_22)
            {
                    val_22 = zz.Length;
            }
            
                uint val_33 = y[((long)(int)((yOff + 2))) << 2];
                val_33 = val_10 + (val_28 * val_33);
                val_10 = val_33 + (zz[((long)(int)(((zzOff + -8) + 10))) << 2]);
                mem2[0] = val_10;
                val_23 = zz.Length;
                int val_13 = val_27 + val_46;
                val_13 = val_13 + 11;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_23)
            {
                    val_23 = zz.Length;
            }
            
                uint val_35 = y[((long)(int)((yOff + 3))) << 2];
                val_35 = val_10 + (val_28 * val_35);
                val_10 = val_35 + (zz[((long)(int)(((zzOff + -8) + 11))) << 2]);
                mem2[0] = val_10;
                val_24 = zz.Length;
                int val_14 = val_27 + val_46;
                val_14 = val_14 + 12;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_24)
            {
                    val_24 = zz.Length;
            }
            
                uint val_37 = y[((long)(int)((yOff + 4))) << 2];
                val_37 = val_10 + (val_28 * val_37);
                val_10 = val_37 + (zz[((long)(int)(((zzOff + -8) + 12))) << 2]);
                mem2[0] = val_10;
                val_25 = zz.Length;
                int val_15 = val_27 + val_46;
                val_15 = val_15 + 13;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_25)
            {
                    val_25 = zz.Length;
            }
            
                uint val_39 = y[((long)(int)((yOff + 5))) << 2];
                val_39 = val_10 + (val_28 * val_39);
                val_10 = val_39 + (zz[((long)(int)(((zzOff + -8) + 13))) << 2]);
                mem2[0] = val_10;
                val_26 = zz.Length;
                int val_16 = val_27 + val_46;
                val_16 = val_16 + 14;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_26)
            {
                    val_26 = zz.Length;
            }
            
                uint val_41 = y[((long)(int)((yOff + 6))) << 2];
                val_41 = val_10 + (val_28 * val_41);
                val_10 = val_41 + (zz[((long)(int)(((zzOff + -8) + 14))) << 2]);
                mem2[0] = val_10;
                val_27 = zz.Length;
                int val_17 = val_27 + val_46;
                val_17 = val_17 + 15;
                val_27 = val_27 + 1;
                val_10 = val_10 >> 32;
                if(val_27 >= val_27)
            {
                    val_27 = zz.Length;
            }
            
                uint val_43 = y[((long)(int)((yOff + 7))) << 2];
                val_43 = val_10 + (val_28 * val_43);
                val_28 = val_43 + (zz[((long)(int)(((zzOff + -8) + 15))) << 2]);
                mem2[0] = val_28;
                val_28 = zz.Length;
                int val_18 = val_27 + val_46;
                val_18 = val_18 + 16;
                val_27 = val_27 + 1;
                val_28 = val_28 >> 32;
                if(val_27 >= val_28)
            {
                    val_28 = zz.Length;
            }
            
                val_43 = val_28 + val_45;
                val_45 = val_43 + (zz[((long)(int)(((zzOff + -8) + 16))) << 2]);
                mem2[0] = val_45;
                val_46 = val_46 + 1;
                val_45 = val_45 >> 32;
            }
            while(val_46 != 0);
            
            return (uint)val_45;
        }
        public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_34 = x[((long)(int)(xOff)) << 2];
            uint val_1 = (y[((long)(int)(yOff)) << 2]) + (val_34 * w);
            z[((long)(int)(zOff)) << 2] = val_1;
            int val_2 = xOff + 1;
            uint val_3 = val_1 >> 32;
            uint val_36 = x[((long)(int)((xOff + 1))) << 2];
            int val_4 = yOff + 1;
            uint val_5 = val_3 + val_34;
            int val_6 = zOff + 1;
            val_5 = val_5 + (val_36 * w);
            val_34 = val_5 + (y[((long)(int)((yOff + 1))) << 2]);
            z[((long)(int)((zOff + 1))) << 2] = val_34;
            int val_7 = xOff + 2;
            val_3 = val_34 >> 32;
            uint val_38 = x[((long)(int)((xOff + 2))) << 2];
            int val_8 = yOff + 2;
            uint val_9 = val_3 + val_36;
            int val_10 = zOff + 2;
            val_9 = val_9 + (val_38 * w);
            val_36 = val_9 + (y[((long)(int)((yOff + 2))) << 2]);
            z[((long)(int)((zOff + 2))) << 2] = val_36;
            int val_11 = xOff + 3;
            val_3 = val_36 >> 32;
            uint val_40 = x[((long)(int)((xOff + 3))) << 2];
            int val_12 = yOff + 3;
            uint val_13 = val_3 + val_38;
            int val_14 = zOff + 3;
            val_13 = val_13 + (val_40 * w);
            val_38 = val_13 + (y[((long)(int)((yOff + 3))) << 2]);
            z[((long)(int)((zOff + 3))) << 2] = val_38;
            int val_15 = xOff + 4;
            val_3 = val_38 >> 32;
            uint val_42 = x[((long)(int)((xOff + 4))) << 2];
            int val_16 = yOff + 4;
            uint val_17 = val_3 + val_40;
            int val_18 = zOff + 4;
            val_17 = val_17 + (val_42 * w);
            val_40 = val_17 + (y[((long)(int)((yOff + 4))) << 2]);
            z[((long)(int)((zOff + 4))) << 2] = val_40;
            int val_19 = xOff + 5;
            val_3 = val_40 >> 32;
            uint val_44 = x[((long)(int)((xOff + 5))) << 2];
            int val_20 = yOff + 5;
            uint val_21 = val_3 + val_42;
            int val_22 = zOff + 5;
            val_21 = val_21 + (val_44 * w);
            val_42 = val_21 + (y[((long)(int)((yOff + 5))) << 2]);
            z[((long)(int)((zOff + 5))) << 2] = val_42;
            int val_23 = xOff + 6;
            val_3 = val_42 >> 32;
            uint val_46 = x[((long)(int)((xOff + 6))) << 2];
            int val_24 = yOff + 6;
            uint val_25 = val_3 + val_44;
            int val_26 = zOff + 6;
            val_25 = val_25 + (val_46 * w);
            val_44 = val_25 + (y[((long)(int)((yOff + 6))) << 2]);
            z[((long)(int)((zOff + 6))) << 2] = val_44;
            int val_27 = xOff + 7;
            uint val_48 = x[((long)(int)((xOff + 7))) << 2];
            int val_28 = yOff + 7;
            uint val_30 = (val_44 >> 32) + val_46;
            int val_31 = zOff + 7;
            val_30 = val_30 + (val_48 * w);
            uint val_32 = val_30 + (y[((long)(int)((yOff + 7))) << 2]);
            z[((long)(int)((zOff + 7))) << 2] = val_32;
            return (ulong)val_48 + (val_32 >> 32);
        }
        public static uint MulByWord(uint x, uint[] z)
        {
            int val_3;
            uint val_11 = x;
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            uint val_1 = z[0] * val_11;
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
            
            val_1 = val_1 + (z[0] * val_11);
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
            
            val_1 = val_1 + (z[1] * val_11);
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
            
            val_1 = val_1 + (z[1] * val_11);
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
            
            val_1 = val_1 + (z[2] * val_11);
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
            
            val_1 = val_1 + (z[2] * val_11);
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
            
            val_1 = val_1 + (z[3] * val_11);
            if(val_3 <= 6)
            {
                    val_3 = z.Length;
            }
            
            z[3] = val_1;
            val_1 = val_1 >> 32;
            if(val_3 <= 7)
            {
                    val_3 = z.Length;
            }
            
            val_11 = val_1 + (z[3] * val_11);
            z[3] = val_11;
            return (uint)val_11 >> 32;
        }
        public static uint MulByWordAddTo(uint x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            System.UInt32[] val_19 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            val_3 = val_19[0] + (val_3 * x);
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            uint val_1 = val_3 + (z[0] * x);
            val_3 = val_1 + val_19[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + (z[1] * x);
            val_3 = val_1 + val_19[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_6 = z.Length;
            val_1 = val_3 + (z[1] * x);
            val_3 = val_1 + val_19[1];
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_7 = z.Length;
            val_1 = val_3 + (z[2] * x);
            val_3 = val_1 + val_19[2];
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_8 = z.Length;
            val_1 = val_3 + (z[2] * x);
            val_3 = val_1 + val_19[2];
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_9 = z.Length;
            val_1 = val_3 + (z[3] * x);
            val_3 = val_1 + val_19[3];
            if(val_9 <= 6)
            {
                    val_9 = z.Length;
            }
            
            z[3] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + (z[3] * x);
            val_19 = val_1 + val_19[3];
            z[3] = val_19;
            return (uint)val_19 >> 32;
        }
        public static uint MulWordAddTo(uint x, uint[] y, int yOff, uint[] z, int zOff)
        {
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            uint val_19 = y[((long)(int)(yOff)) << 2];
            val_19 = z.Length;
            if(val_19 <= zOff)
            {
                    val_19 = z.Length;
            }
            
            val_19 = (z[((long)(int)(zOff)) << 2]) + (val_19 * x);
            mem2[0] = val_19;
            int val_1 = yOff + 1;
            val_20 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 1) >= val_20)
            {
                    val_20 = z.Length;
            }
            
            uint val_3 = val_19 + ((y[((long)(int)((yOff + 1))) << 2]) * x);
            val_19 = val_3 + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_19;
            int val_4 = yOff + 2;
            val_21 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 2) >= val_21)
            {
                    val_21 = z.Length;
            }
            
            val_3 = val_19 + ((y[((long)(int)((yOff + 2))) << 2]) * x);
            val_19 = val_3 + (z[((long)(int)((zOff + 2))) << 2]);
            mem2[0] = val_19;
            int val_6 = yOff + 3;
            val_22 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 3) >= val_22)
            {
                    val_22 = z.Length;
            }
            
            val_3 = val_19 + ((y[((long)(int)((yOff + 3))) << 2]) * x);
            val_19 = val_3 + (z[((long)(int)((zOff + 3))) << 2]);
            mem2[0] = val_19;
            int val_8 = yOff + 4;
            val_23 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 4) >= val_23)
            {
                    val_23 = z.Length;
            }
            
            val_3 = val_19 + ((y[((long)(int)((yOff + 4))) << 2]) * x);
            val_19 = val_3 + (z[((long)(int)((zOff + 4))) << 2]);
            mem2[0] = val_19;
            int val_10 = yOff + 5;
            val_24 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 5) >= val_24)
            {
                    val_24 = z.Length;
            }
            
            val_3 = val_19 + ((y[((long)(int)((yOff + 5))) << 2]) * x);
            val_19 = val_3 + (z[((long)(int)((zOff + 5))) << 2]);
            mem2[0] = val_19;
            int val_12 = yOff + 6;
            val_25 = z.Length;
            val_19 = val_19 >> 32;
            if((zOff + 6) >= val_25)
            {
                    val_25 = z.Length;
            }
            
            val_3 = val_19 + ((y[((long)(int)((yOff + 6))) << 2]) * x);
            val_19 = val_3 + (z[((long)(int)((zOff + 6))) << 2]);
            mem2[0] = val_19;
            int val_14 = yOff + 7;
            val_26 = z.Length;
            if((zOff + 7) >= val_26)
            {
                    val_26 = z.Length;
            }
            
            val_3 = (val_19 >> 32) + ((y[((long)(int)((yOff + 7))) << 2]) * x);
            uint val_17 = val_3 + (z[((long)(int)((zOff + 7))) << 2]);
            mem2[0] = val_17;
            return (uint)val_17 >> 32;
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  8, z:  z, zOff:  zOff, zPos:  4);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  8, z:  z, zOff:  zOff, zPos:  3);
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
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  8, z:  z, zOff:  zOff, zPos:  3);
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
            while(val_3 != 8);
            
            return (uint)val_2;
        }
        public static void Square(uint[] x, uint[] zz)
        {
            int val_36;
            int val_37;
            int val_38;
            int val_39;
            int val_40;
            int val_41;
            int val_42;
            uint val_39 = x[0];
            var val_42 = 0;
            var val_41 = 15;
            do
            {
                var val_2 = val_42 + 15;
                uint val_3 = x[3] * x[3];
                zz[0] = val_3 >> 33;
                var val_5 = val_42 + 14;
                zz[0] = val_3 >> 1;
                val_41 = val_41 - 1;
                val_42 = val_42 - 2;
            }
            while((val_41 - 8) > 1);
            
            uint val_7 = val_39 * val_39;
            zz[0] = val_7;
            uint val_8 = val_7 >> 33;
            val_36 = zz.Length;
            uint val_43 = x[0];
            if(val_36 <= 2)
            {
                    val_36 = zz.Length;
            }
            
            uint val_44 = zz[1];
            val_8 = val_8 + (val_43 * val_39);
            zz[0] = (ulong)(val_7 >> 32) & 1;
            val_37 = zz.Length;
            uint val_45 = x[1];
            if(val_37 <= 3)
            {
                    val_37 = zz.Length;
            }
            
            uint val_46 = zz[1];
            val_44 = val_44 + (val_8 >> 32);
            if(val_37 <= 4)
            {
                    val_37 = zz.Length;
            }
            
            uint val_47 = zz[2];
            val_44 = val_44 + (val_45 * val_39);
            zz[1] = val_8 >> 31;
            val_8 = (val_45 * val_43) + (val_44 >> 32);
            val_38 = zz.Length;
            uint val_48 = x[1];
            val_46 = val_8 + val_46;
            if(val_38 <= 5)
            {
                    val_38 = zz.Length;
            }
            
            uint val_49 = zz[2];
            val_45 = val_46 & 4294967295;
            if(val_38 <= 6)
            {
                    val_38 = zz.Length;
            }
            
            uint val_50 = zz[3];
            val_46 = val_45 + (val_48 * val_39);
            zz[1] = val_44 >> 31;
            uint val_13 = (val_46 >> 32) + val_47;
            val_13 = val_13 + (val_48 * val_43);
            uint val_14 = val_13 + (val_46 >> 32);
            uint val_15 = val_48 * val_45;
            val_39 = zz.Length;
            uint val_51 = x[2];
            val_15 = val_15 + (val_14 >> 32);
            if(val_39 <= 7)
            {
                    val_39 = zz.Length;
            }
            
            val_49 = val_15 + val_49;
            val_46 = val_14 & 4294967295;
            if(val_39 <= 8)
            {
                    val_39 = zz.Length;
            }
            
            val_47 = val_49 >> 32;
            val_14 = val_49 & 4294967295;
            uint val_56 = val_51;
            val_46 = val_46 + (val_56 * val_39);
            zz[2] = val_46 >> 31;
            uint val_54 = val_43;
            uint val_17 = val_47 + val_50;
            val_54 = val_14 + (val_56 * val_54);
            val_14 = val_54 + (val_46 >> 32);
            val_17 = val_17 + (val_56 * val_45);
            val_50 = val_17 + (val_14 >> 32);
            uint val_18 = val_56 * val_48;
            val_40 = zz.Length;
            uint val_55 = x[2];
            val_18 = val_18 + (val_50 >> 32);
            if(val_40 <= 9)
            {
                    val_40 = zz.Length;
            }
            
            val_56 = val_18 + zz[3];
            val_46 = val_14 & 4294967295;
            if(val_40 <= 10)
            {
                    val_40 = zz.Length;
            }
            
            val_47 = val_56 >> 32;
            val_14 = val_56 & 4294967295;
            uint val_64 = val_55;
            val_50 = val_50 & 4294967295;
            val_46 = val_46 + (val_64 * val_39);
            zz[2] = val_46 >> 31;
            uint val_60 = val_45;
            uint val_59 = val_43;
            val_59 = val_50 + (val_64 * val_59);
            val_50 = val_59 + (val_46 >> 32);
            val_60 = val_14 + (val_64 * val_60);
            val_14 = val_60 + (val_50 >> 32);
            uint val_20 = val_47 + zz[4];
            val_20 = val_20 + (val_64 * val_48);
            val_41 = zz.Length;
            uint val_61 = x[3];
            uint val_23 = val_64 * val_51;
            if(val_41 <= 11)
            {
                    val_41 = zz.Length;
            }
            
            val_23 = val_23 + zz[4];
            val_46 = val_50 & 4294967295;
            if(val_41 <= 12)
            {
                    val_41 = zz.Length;
            }
            
            val_64 = val_14 & 4294967295;
            val_14 = (val_20 + (val_14 >> 32)) & 4294967295;
            val_46 = val_46 + (val_61 * val_39);
            zz[3] = val_46 >> 31;
            uint val_65 = val_43;
            uint val_66 = val_48;
            uint val_67 = zz[5];
            val_65 = val_64 + (val_61 * val_65);
            val_66 = (val_23 & 4294967295) + (val_61 * val_66);
            uint val_29 = val_61;
            uint val_68 = val_51;
            val_67 = (val_23 >> 32) + val_67;
            val_23 = val_66 + (val_29 >> 32);
            val_68 = val_67 + (val_61 * val_68);
            uint val_30 = val_68 + (val_23 >> 32);
            uint val_31 = val_61 * val_55;
            val_42 = zz.Length;
            uint val_69 = x[3];
            val_31 = val_31 + (val_30 >> 32);
            if(val_42 <= 13)
            {
                    val_42 = zz.Length;
            }
            
            val_46 = val_46 >> 31;
            uint val_32 = val_65 + (val_46 >> 32);
            val_31 = val_31 + zz[5];
            if(val_42 <= 14)
            {
                    val_42 = zz.Length;
            }
            
            uint val_33 = val_29 & 4294967295;
            val_23 = val_23 & 4294967295;
            val_29 = val_30 & 4294967295;
            val_30 = val_31 >> 32;
            val_31 = val_31 & 4294967295;
            if(val_42 <= 7)
            {
                    val_42 = zz.Length;
            }
            
            zz[3] = val_46;
            uint val_74 = val_45;
            uint val_72 = val_43;
            uint val_73 = val_51;
            uint val_75 = val_48;
            uint val_76 = zz[6];
            val_72 = val_33 + (val_69 * val_72);
            val_73 = val_31 + (val_69 * val_73);
            uint val_35 = val_72 + (val_69 >> 32);
            val_74 = val_23 + (val_69 * val_74);
            val_75 = val_29 + (val_69 * val_75);
            uint val_36 = val_74 + (val_35 >> 32);
            val_76 = val_30 + val_76;
            val_23 = val_75 + (val_36 >> 32);
            uint val_37 = val_76 + (val_69 * val_55);
            if(val_42 <= 8)
            {
                    val_42 = zz.Length;
            }
            
            val_37 = val_37 + ((val_73 + (val_23 >> 32)) >> 32);
            val_69 = val_69 * val_61;
            zz[4] = val_33;
            if(val_42 <= 9)
            {
                    val_42 = zz.Length;
            }
            
            val_69 = val_69 + (val_37 >> 32);
            zz[4] = val_35;
            if(val_42 <= 10)
            {
                    val_42 = zz.Length;
            }
            
            zz[5] = val_35;
            val_36 = val_69 + zz[6];
            if(val_42 <= 11)
            {
                    val_42 = zz.Length;
            }
            
            zz[5] = val_35;
            val_69 = zz[7] + (val_36 >> 32);
            if(val_42 <= 12)
            {
                    val_42 = zz.Length;
            }
            
            zz[6] = val_35;
            if(val_42 <= 13)
            {
                    val_42 = zz.Length;
            }
            
            zz[6] = val_35;
            if(val_42 <= 14)
            {
                    val_42 = zz.Length;
            }
            
            zz[7] = val_35;
            val_35 = val_69 >> 31;
            if(val_42 <= 15)
            {
                    val_42 = zz.Length;
            }
            
            uint val_77 = zz[7];
            val_74 = val_69 >> 32;
            val_77 = val_77 + val_74;
            zz[7] = val_35;
        }
        public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
        {
            int val_73;
            int val_74;
            var val_75;
            int val_76;
            uint val_77;
            var val_78;
            int val_79;
            var val_80;
            var val_81;
            int val_82;
            uint val_73 = x[((long)(int)(xOff)) << 2];
            int val_2 = zzOff + 15;
            do
            {
                int val_3 = (xOff + 7) + 8;
                val_3 = val_3 - 8;
                uint val_4 = (x[((long)(int)((((xOff + 7) + 8) - 8))) << 2]) * (x[((long)(int)((((xOff + 7) + 8) - 8))) << 2]);
                zz[((long)(int)((zzOff + 15))) << 2] = val_4 >> 33;
                int val_6 = val_2 - 1;
                val_2 = val_2 - 2;
                zz[((long)(int)(((zzOff + 15) - 1))) << 2] = val_4 >> 1;
            }
            while(7 > 1);
            
            uint val_8 = val_73 * val_73;
            zz[((long)(int)(zzOff)) << 2] = val_8;
            int val_75 = xOff;
            val_75 = val_75 + 1;
            uint val_76 = x[((long)(int)((xOff + 1))) << 2];
            int val_10 = zzOff + 2;
            uint val_11 = (val_8 >> 33) + (val_76 * val_73);
            int val_12 = zzOff + 1;
            zz[((long)(int)((zzOff + 1))) << 2] = (ulong)(val_8 >> 32) & 1;
            int val_78 = xOff;
            val_78 = val_78 + 2;
            uint val_79 = x[((long)(int)((xOff + 2))) << 2];
            int val_13 = zzOff + 3;
            uint val_80 = zz[((long)(int)((zzOff + 3))) << 2];
            int val_15 = zzOff + 4;
            val_76 = val_11 >> 31;
            uint val_16 = ((zz[((long)(int)((zzOff + 2))) << 2]) + (val_11 >> 32)) + (val_79 * val_73);
            mem2[0] = val_76;
            uint val_82 = val_76;
            val_82 = val_79 * val_82;
            int val_83 = xOff;
            val_83 = val_83 + 3;
            uint val_84 = x[((long)(int)((xOff + 3))) << 2];
            val_80 = (val_82 + (val_16 >> 32)) + val_80;
            int val_18 = zzOff + 5;
            uint val_85 = zz[((long)(int)((zzOff + 5))) << 2];
            val_80 = val_80 >> 32;
            uint val_22 = (val_80 & 4294967295) + (val_84 * val_73);
            var val_88 = val_84;
            mem2[0] = val_16 >> 31;
            uint val_87 = zz[((long)(int)((zzOff + 4))) << 2];
            val_87 = val_80 + val_87;
            val_87 = val_87 + (val_88 * val_76);
            val_88 = val_87 + (val_22 >> 32);
            int val_23 = xOff + 4;
            uint val_24 = val_88 * val_79;
            uint val_89 = x[((long)(int)((xOff + 4))) << 2];
            val_73 = zz.Length;
            val_24 = val_24 + (val_88 >> 32);
            if((zzOff + 7) >= val_73)
            {
                    val_73 = zz.Length;
            }
            
            val_85 = val_24 + val_85;
            val_22 = val_22 >> 31;
            val_88 = val_88 & 4294967295;
            if((zzOff + 8) >= val_73)
            {
                    val_73 = zz.Length;
            }
            
            val_24 = val_85 >> 32;
            val_85 = val_85 & 4294967295;
            uint val_27 = val_88 + (val_89 * val_73);
            var val_94 = val_89;
            mem2[0] = val_22;
            uint val_92 = zz[((long)(int)((zzOff + 6))) << 2];
            val_92 = val_24 + val_92;
            uint val_29 = (val_85 + (val_94 * val_76)) + (val_27 >> 32);
            uint val_93 = val_79;
            val_93 = val_92 + (val_94 * val_93);
            uint val_30 = val_93 + (val_29 >> 32);
            val_94 = val_94 * val_84;
            int val_31 = xOff + 5;
            uint val_95 = x[((long)(int)((xOff + 5))) << 2];
            val_74 = zz.Length;
            val_94 = val_94 + (val_30 >> 32);
            int val_32 = zzOff + 9;
            val_75 = (long)val_32;
            if(val_32 >= val_74)
            {
                    val_74 = zz.Length;
                val_75 = val_75;
            }
            
            uint val_33 = val_94 + (zz[((long)(int)((zzOff + 7))) << 2]);
            if((zzOff + 10) >= val_74)
            {
                    val_74 = zz.Length;
            }
            
            uint val_97 = zz[((long)(int)((zzOff + 10))) << 2];
            uint val_98 = val_95;
            val_27 = val_30 & 4294967295;
            val_29 = val_33 >> 32;
            val_33 = val_33 & 4294967295;
            uint val_37 = (val_29 & 4294967295) + (val_98 * val_73);
            mem2[0] = val_27 >> 31;
            uint val_99 = zz[((long)(int)((zzOff + 8))) << 2];
            val_98 = (val_27 + (val_98 * val_76)) + (val_37 >> 32);
            uint val_100 = val_84;
            val_27 = (val_33 + (val_98 * val_79)) + (val_98 >> 32);
            val_99 = val_29 + val_99;
            val_100 = val_99 + (val_98 * val_100);
            val_29 = val_100;
            uint val_40 = val_98 * val_89;
            int val_101 = xOff;
            val_101 = val_101 + 6;
            val_76 = zz.Length;
            val_77 = x[((long)(int)((xOff + 6))) << 2];
            int val_41 = zzOff + 11;
            val_40 = val_40 + (val_29 >> 32);
            val_78 = (long)val_41;
            if(val_41 >= val_76)
            {
                    val_77 = val_77;
                val_76 = zz.Length;
                val_78 = val_78;
            }
            
            uint val_43 = val_40 + (zz[((long)(int)((zzOff + 9))) << 2]);
            if((zzOff + 12) >= val_76)
            {
                    val_77 = val_77;
                val_76 = zz.Length;
            }
            
            val_27 = val_27 & 4294967295;
            val_29 = val_43 >> 32;
            val_43 = val_43 & 4294967295;
            uint val_47 = (val_98 & 4294967295) + (val_77 * val_73);
            if(((long)zzOff + 6) >= val_76)
            {
                    val_77 = val_77;
            }
            
            mem2[0] = val_37 >> 31;
            uint val_50 = val_77 + (val_47 >> 32);
            uint val_51 = val_29;
            uint val_55 = val_77;
            uint val_56 = val_77 * val_95;
            uint val_57 = val_77 + (val_55 >> 32);
            int val_104 = xOff;
            val_104 = val_104 + 7;
            val_79 = zz.Length;
            uint val_105 = x[((long)(int)((xOff + 7))) << 2];
            val_56 = val_56 + (val_57 >> 32);
            int val_58 = zzOff + 13;
            val_80 = (long)val_58;
            if(val_58 >= val_79)
            {
                    val_79 = zz.Length;
                val_80 = val_80;
            }
            
            val_56 = val_56 + (zz[((long)(int)((zzOff + 11))) << 2]);
            val_50 = val_50 & 4294967295;
            int val_60 = zzOff + 14;
            val_81 = (long)val_60;
            if(val_60 >= val_79)
            {
                    val_79 = zz.Length;
                val_81 = val_81;
            }
            
            uint val_62 = (val_29 & 4294967295) + (val_77 * val_79);
            uint val_63 = val_55 & 4294967295;
            val_55 = val_56 >> 32;
            val_56 = val_56 & 4294967295;
            mem2[0] = val_47 >> 31;
            uint val_108 = val_79;
            uint val_111 = val_89;
            uint val_109 = val_84;
            uint val_110 = zz[((long)(int)((zzOff + 12))) << 2];
            val_108 = val_63 + (val_105 * val_108);
            val_109 = (val_57 & 4294967295) + (val_105 * val_109);
            uint val_66 = val_105 + (val_105 >> 32);
            uint val_67 = val_108 + (val_66 >> 32);
            val_110 = val_55 + val_110;
            val_111 = val_56 + (val_105 * val_111);
            uint val_68 = val_110 + (val_105 * val_95);
            val_68 = val_68 + ((val_111 + ((val_109 + (val_67 >> 32)) >> 32)) >> 32);
            mem2[0] = val_63;
            val_105 = val_105 * val_77;
            val_105 = val_105 + (val_68 >> 32);
            mem2[0] = val_66;
            mem2[0] = val_67;
            mem2[0] = val_67;
            val_105 = (zz[((long)(int)((zzOff + 14))) << 2]) + ((val_105 + (zz[((long)(int)((zzOff + 13))) << 2])) >> 32);
            mem2[0] = val_67;
            mem2[0] = val_67;
            mem2[0] = val_67;
            val_82 = zz.Length;
            val_67 = val_105 >> 31;
            if((zzOff + 15) >= val_82)
            {
                    val_82 = zz.Length;
            }
            
            uint val_112 = zz[((long)(int)((zzOff + 15))) << 2];
            val_109 = val_105 >> 32;
            val_112 = val_112 + val_109;
            mem2[0] = val_67;
        }
        public static int Sub(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_18 = y;
            uint val_2 = x[0];
            val_2 = val_2 - val_18[0];
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_18[0];
            val_5 = x[0] - val_5;
            val_2 = val_5 + val_2;
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_18[1];
            val_7 = x[1] - val_7;
            val_2 = val_7 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_18[1];
            val_9 = x[1] - val_9;
            val_2 = val_9 + val_2;
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_18[2];
            val_11 = x[2] - val_11;
            val_2 = val_11 + val_2;
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_13 = val_18[2];
            val_13 = x[2] - val_13;
            val_2 = val_13 + val_2;
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_15 = val_18[3];
            val_15 = x[3] - val_15;
            val_2 = val_15 + val_2;
            z[3] = val_2;
            val_2 = val_2 >> 32;
            uint val_17 = val_18[3];
            val_17 = x[3] - val_17;
            val_18 = val_17 + val_2;
            z[3] = val_18;
            return (int)val_18 >> 32;
        }
        public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            uint val_25 = x[((long)(int)(xOff)) << 2];
            val_25 = val_25 - (y[((long)(int)(yOff)) << 2]);
            z[((long)(int)(zOff)) << 2] = val_25;
            int val_1 = xOff + 1;
            int val_2 = yOff + 1;
            val_25 = val_25 >> 32;
            uint val_28 = y[((long)(int)((yOff + 1))) << 2];
            int val_3 = zOff + 1;
            val_28 = (x[((long)(int)((xOff + 1))) << 2]) - val_28;
            val_25 = val_28 + val_25;
            z[((long)(int)((zOff + 1))) << 2] = val_25;
            int val_4 = xOff + 2;
            int val_5 = yOff + 2;
            val_25 = val_25 >> 32;
            uint val_30 = y[((long)(int)((yOff + 2))) << 2];
            int val_6 = zOff + 2;
            val_30 = (x[((long)(int)((xOff + 2))) << 2]) - val_30;
            val_25 = val_30 + val_25;
            z[((long)(int)((zOff + 2))) << 2] = val_25;
            int val_7 = xOff + 3;
            int val_8 = yOff + 3;
            val_25 = val_25 >> 32;
            uint val_32 = y[((long)(int)((yOff + 3))) << 2];
            int val_9 = zOff + 3;
            val_32 = (x[((long)(int)((xOff + 3))) << 2]) - val_32;
            val_25 = val_32 + val_25;
            z[((long)(int)((zOff + 3))) << 2] = val_25;
            int val_10 = xOff + 4;
            int val_11 = yOff + 4;
            val_25 = val_25 >> 32;
            uint val_34 = y[((long)(int)((yOff + 4))) << 2];
            int val_12 = zOff + 4;
            val_34 = (x[((long)(int)((xOff + 4))) << 2]) - val_34;
            val_25 = val_34 + val_25;
            z[((long)(int)((zOff + 4))) << 2] = val_25;
            int val_13 = xOff + 5;
            int val_14 = yOff + 5;
            val_25 = val_25 >> 32;
            uint val_36 = y[((long)(int)((yOff + 5))) << 2];
            int val_15 = zOff + 5;
            val_36 = (x[((long)(int)((xOff + 5))) << 2]) - val_36;
            val_25 = val_36 + val_25;
            z[((long)(int)((zOff + 5))) << 2] = val_25;
            int val_16 = xOff + 6;
            int val_17 = yOff + 6;
            val_25 = val_25 >> 32;
            uint val_38 = y[((long)(int)((yOff + 6))) << 2];
            int val_18 = zOff + 6;
            val_38 = (x[((long)(int)((xOff + 6))) << 2]) - val_38;
            val_25 = val_38 + val_25;
            z[((long)(int)((zOff + 6))) << 2] = val_25;
            int val_19 = xOff + 7;
            int val_20 = yOff + 7;
            uint val_40 = y[((long)(int)((yOff + 7))) << 2];
            int val_22 = zOff + 7;
            val_40 = (x[((long)(int)((xOff + 7))) << 2]) - val_40;
            uint val_23 = val_40 + (val_25 >> 32);
            z[((long)(int)((zOff + 7))) << 2] = val_23;
            return (int)val_23 >> 32;
        }
        public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
        {
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            int val_9;
            System.UInt32[] val_27 = y;
            uint val_3 = z[0];
            val_3 = z.Length;
            uint val_1 = val_3 - x[0];
            val_3 = val_1 - val_27[0];
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_4 = z.Length;
            val_1 = val_3 + z[0];
            val_1 = val_1 - x[0];
            val_3 = val_1 - val_27[0];
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            val_5 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_27[1];
            if(val_5 <= 2)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_6 = z.Length;
            val_1 = val_3 + z[1];
            val_1 = val_1 - x[1];
            val_3 = val_1 - val_27[1];
            if(val_6 <= 3)
            {
                    val_6 = z.Length;
            }
            
            z[1] = val_3;
            val_3 = val_3 >> 32;
            val_7 = z.Length;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_3 = val_1 - val_27[2];
            if(val_7 <= 4)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_8 = z.Length;
            val_1 = val_3 + z[2];
            val_1 = val_1 - x[2];
            val_3 = val_1 - val_27[2];
            if(val_8 <= 5)
            {
                    val_8 = z.Length;
            }
            
            z[2] = val_3;
            val_3 = val_3 >> 32;
            val_9 = z.Length;
            val_1 = val_3 + z[3];
            val_1 = val_1 - x[3];
            val_3 = val_1 - val_27[3];
            if(val_9 <= 6)
            {
                    val_9 = z.Length;
            }
            
            z[3] = val_3;
            val_3 = val_3 >> 32;
            val_1 = val_3 + z[3];
            val_1 = val_1 - x[3];
            val_27 = val_1 - val_27[3];
            z[3] = val_27;
            return (int)val_27 >> 32;
        }
        public static int SubFrom(uint[] x, uint[] z)
        {
            int val_2;
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            System.UInt32[] val_18 = x;
            uint val_2 = z[0];
            val_2 = z.Length;
            val_2 = val_2 - val_18[0];
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_5 = val_18[0];
            val_3 = z.Length;
            val_5 = z[0] - val_5;
            val_2 = val_5 + val_2;
            if(val_3 <= 1)
            {
                    val_3 = z.Length;
            }
            
            z[0] = val_2;
            val_2 = val_2 >> 32;
            uint val_7 = val_18[1];
            val_4 = z.Length;
            val_7 = z[1] - val_7;
            val_2 = val_7 + val_2;
            if(val_4 <= 2)
            {
                    val_4 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_9 = val_18[1];
            val_5 = z.Length;
            val_9 = z[1] - val_9;
            val_2 = val_9 + val_2;
            if(val_5 <= 3)
            {
                    val_5 = z.Length;
            }
            
            z[1] = val_2;
            val_2 = val_2 >> 32;
            uint val_11 = val_18[2];
            val_6 = z.Length;
            val_11 = z[2] - val_11;
            val_2 = val_11 + val_2;
            if(val_6 <= 4)
            {
                    val_6 = z.Length;
            }
            
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_13 = val_18[2];
            val_7 = z.Length;
            val_13 = z[2] - val_13;
            val_2 = val_13 + val_2;
            if(val_7 <= 5)
            {
                    val_7 = z.Length;
            }
            
            z[2] = val_2;
            val_2 = val_2 >> 32;
            uint val_15 = val_18[3];
            val_8 = z.Length;
            val_15 = z[3] - val_15;
            val_2 = val_15 + val_2;
            if(val_8 <= 6)
            {
                    val_8 = z.Length;
            }
            
            z[3] = val_2;
            val_2 = val_2 >> 32;
            uint val_17 = val_18[3];
            val_17 = z[3] - val_17;
            val_18 = val_17 + val_2;
            z[3] = val_18;
            return (int)val_18 >> 32;
        }
        public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
        {
            System.UInt32[] val_33 = z;
            uint val_1 = (val_33[((long)(int)(zOff)) << 2]) - (x[((long)(int)(xOff)) << 2]);
            mem2[0] = val_1;
            int val_2 = zOff + 1;
            int val_3 = xOff + 1;
            val_1 = val_1 >> 32;
            uint val_20 = x[((long)(int)((xOff + 1))) << 2];
            val_20 = (val_33[((long)(int)((zOff + 1))) << 2]) - val_20;
            val_1 = val_20 + val_1;
            mem2[0] = val_1;
            int val_4 = zOff + 2;
            int val_5 = xOff + 2;
            val_1 = val_1 >> 32;
            uint val_22 = x[((long)(int)((xOff + 2))) << 2];
            val_22 = (val_33[((long)(int)((zOff + 2))) << 2]) - val_22;
            val_1 = val_22 + val_1;
            mem2[0] = val_1;
            int val_6 = zOff + 3;
            int val_7 = xOff + 3;
            val_1 = val_1 >> 32;
            uint val_24 = x[((long)(int)((xOff + 3))) << 2];
            val_24 = (val_33[((long)(int)((zOff + 3))) << 2]) - val_24;
            val_1 = val_24 + val_1;
            mem2[0] = val_1;
            int val_8 = zOff + 4;
            int val_9 = xOff + 4;
            val_1 = val_1 >> 32;
            uint val_26 = x[((long)(int)((xOff + 4))) << 2];
            val_26 = (val_33[((long)(int)((zOff + 4))) << 2]) - val_26;
            val_1 = val_26 + val_1;
            mem2[0] = val_1;
            int val_10 = zOff + 5;
            int val_11 = xOff + 5;
            val_1 = val_1 >> 32;
            uint val_28 = x[((long)(int)((xOff + 5))) << 2];
            val_28 = (val_33[((long)(int)((zOff + 5))) << 2]) - val_28;
            val_1 = val_28 + val_1;
            mem2[0] = val_1;
            int val_12 = zOff + 6;
            int val_13 = xOff + 6;
            val_1 = val_1 >> 32;
            uint val_30 = x[((long)(int)((xOff + 6))) << 2];
            val_30 = (val_33[((long)(int)((zOff + 6))) << 2]) - val_30;
            val_1 = val_30 + val_1;
            mem2[0] = val_1;
            int val_14 = zOff + 7;
            int val_15 = xOff + 7;
            val_1 = val_1 >> 32;
            uint val_32 = x[((long)(int)((xOff + 7))) << 2];
            val_32 = (val_33[((long)(int)((zOff + 7))) << 2]) - val_32;
            val_33 = val_32 + val_1;
            mem2[0] = val_33;
            return (int)val_33 >> 32;
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
        {
            byte[] val_1 = new byte[32];
            var val_3 = 0;
            var val_4 = 28;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  1134694512, bs:  val_1, off:  28);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 4;
            }
            while(val_3 != 8);
            
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_1);
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
        {
            byte[] val_1 = new byte[32];
            var val_3 = 0;
            var val_4 = 24;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  null, bs:  val_1, off:  24);
            }
            
                val_3 = val_3 + 1;
                val_4 = val_4 - 8;
            }
            while(val_3 != 4);
            
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
            if(val_1 <= 6)
            {
                    val_1 = z.Length;
            }
            
            z[3] = 0;
            z[3] = 0;
        }
        protected Nat256()
        {
        
        }
    
    }

}
