using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Nat
    {
        // Fields
        private const ulong M = 4294967295;
        
        // Methods
        public static uint Add(int len, uint[] x, uint[] y, uint[] z)
        {
            var val_1;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                System.UInt32[] val_1 = 0 + 1152921505741541488;
                mem2[0] = 0;
                val_2 = val_2 + 1;
                val_1 = 0;
            }
            while(len != val_2);
            
                return (uint)val_1;
            }
            
            val_1 = 0;
            return (uint)val_1;
        }
        public static uint Add33At(int len, uint x, uint[] z, int zPos)
        {
            int val_6;
            int val_7;
            uint val_7 = x;
            val_6 = z.Length;
            if(val_6 <= zPos)
            {
                    val_6 = z.Length;
            }
            
            val_7 = (z[((long)(int)(zPos)) << 2]) + val_7;
            mem2[0] = val_7;
            val_7 = z.Length;
            if((zPos + 1) >= val_7)
            {
                    val_7 = z.Length;
            }
            
            uint val_8 = z[((long)(int)((zPos + 1))) << 2];
            val_8 = (val_7 >> 32) + val_8;
            uint val_3 = val_8 + 1;
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  zPos + 2);
        }
        public static uint Add33At(int len, uint x, uint[] z, int zOff, int zPos)
        {
            int val_7;
            int val_8;
            uint val_8 = x;
            val_7 = z.Length;
            int val_1 = zPos + zOff;
            if(val_1 >= val_7)
            {
                    val_7 = z.Length;
            }
            
            val_8 = (z[((long)(int)((zPos + zOff))) << 2]) + val_8;
            mem2[0] = val_8;
            val_8 = z.Length;
            if(((long)val_1 + 1) >= val_8)
            {
                    val_8 = z.Length;
            }
            
            uint val_9 = z[((long)(int)(((long)(int)((zPos + zOff)) + 1))) << 2];
            val_9 = (val_8 >> 32) + val_9;
            uint val_4 = val_9 + 1;
            mem2[0] = val_4;
            if((val_4 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zOff:  zOff, zPos:  zPos + 2);
        }
        public static uint Add33To(int len, uint x, uint[] z)
        {
            int val_2;
            uint val_3 = x;
            val_2 = z.Length;
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            val_3 = z[0] + val_3;
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            if(val_2 <= 1)
            {
                    val_2 = z.Length;
            }
            
            uint val_4 = z[0];
            val_4 = val_3 + val_4;
            val_3 = val_4 + 1;
            z[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  2);
        }
        public static uint Add33To(int len, uint x, uint[] z, int zOff)
        {
            int val_5;
            int val_6;
            uint val_6 = x;
            val_5 = z.Length;
            if(val_5 <= zOff)
            {
                    val_5 = z.Length;
            }
            
            val_6 = (z[((long)(int)(zOff)) << 2]) + val_6;
            mem2[0] = val_6;
            val_6 = z.Length;
            if((zOff + 1) >= val_6)
            {
                    val_6 = z.Length;
            }
            
            uint val_7 = z[((long)(int)((zOff + 1))) << 2];
            val_7 = (val_6 >> 32) + val_7;
            uint val_3 = val_7 + 1;
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zOff:  zOff, zPos:  2);
        }
        public static uint AddBothTo(int len, uint[] x, uint[] y, uint[] z)
        {
            int val_1;
            var val_2;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                val_1 = z.Length;
                if(val_2 >= val_1)
            {
                    val_1 = z.Length;
            }
            
                System.UInt32[] val_1 = 0 + 1152921505741541488;
                mem2[0] = 0;
                val_2 = val_2 + 1;
                val_2 = 0;
            }
            while(len != val_2);
            
                return (uint)val_2;
            }
            
            val_2 = 0;
            return (uint)val_2;
        }
        public static uint AddBothTo(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_2;
            var val_3;
            var val_4;
            int val_5;
            var val_6;
            val_2 = zOff;
            val_3 = yOff;
            val_4 = xOff;
            if(len >= 1)
            {
                    uint val_5 = 0;
                int val_6 = len;
                do
            {
                val_5 = z.Length;
                if(val_2 >= val_5)
            {
                    val_5 = z.Length;
            }
            
                uint val_1 = val_5 + (x[((long)(int)(xOff)) << 2]);
                val_1 = val_1 + (y[((long)(int)(yOff)) << 2]);
                val_5 = val_1 + (z[((long)(int)(zOff)) << 2]);
                mem2[0] = val_5;
                val_6 = val_5 >> 32;
                val_2 = val_2 + 1;
                val_3 = val_3 + 1;
                val_6 = val_6 - 1;
                val_4 = val_4 + 1;
            }
            while(val_6 != 0);
            
                return (uint)val_6;
            }
            
            val_6 = 0;
            return (uint)val_6;
        }
        public static uint AddDWordAt(int len, ulong x, uint[] z, int zPos)
        {
            int val_6;
            int val_7;
            ulong val_8 = x;
            val_6 = z.Length;
            if(val_6 <= zPos)
            {
                    val_6 = z.Length;
            }
            
            uint val_1 = (z[((long)(int)(zPos)) << 2]) + val_8;
            mem2[0] = val_1;
            val_7 = z.Length;
            val_1 = val_1 >> 32;
            if((zPos + 1) >= val_7)
            {
                    val_7 = z.Length;
            }
            
            val_8 = (val_1 + (val_8 >> 32)) + (z[((long)(int)((zPos + 1))) << 2]);
            mem2[0] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  zPos + 2);
        }
        public static uint AddDWordAt(int len, ulong x, uint[] z, int zOff, int zPos)
        {
            int val_8;
            int val_9;
            ulong val_10 = x;
            val_8 = z.Length;
            int val_1 = zPos + zOff;
            if(val_1 >= val_8)
            {
                    val_8 = z.Length;
            }
            
            uint val_2 = (z[((long)(int)((zPos + zOff))) << 2]) + val_10;
            mem2[0] = val_2;
            val_9 = z.Length;
            if(((long)val_1 + 1) >= val_9)
            {
                    val_9 = z.Length;
            }
            
            val_10 = ((val_2 >> 32) + (val_10 >> 32)) + (z[((long)(int)(((long)(int)((zPos + zOff)) + 1))) << 2]);
            mem2[0] = val_10;
            if((val_10 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zOff:  zOff, zPos:  zPos + 2);
        }
        public static uint AddDWordTo(int len, ulong x, uint[] z)
        {
            int val_4;
            ulong val_6 = x;
            val_4 = z.Length;
            if(val_4 == 0)
            {
                    val_4 = z.Length;
            }
            
            uint val_1 = z[0] + val_6;
            if(val_4 == 0)
            {
                    val_4 = z.Length;
            }
            
            z[0] = val_1;
            val_1 = val_1 >> 32;
            if(val_4 <= 1)
            {
                    val_4 = z.Length;
            }
            
            val_6 = (val_1 + (val_6 >> 32)) + z[0];
            z[0] = val_6;
            if((val_6 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  2);
        }
        public static uint AddDWordTo(int len, ulong x, uint[] z, int zOff)
        {
            int val_5;
            int val_6;
            ulong val_7 = x;
            val_5 = z.Length;
            if(val_5 <= zOff)
            {
                    val_5 = z.Length;
            }
            
            uint val_1 = (z[((long)(int)(zOff)) << 2]) + val_7;
            mem2[0] = val_1;
            val_6 = z.Length;
            val_1 = val_1 >> 32;
            if((zOff + 1) >= val_6)
            {
                    val_6 = z.Length;
            }
            
            val_7 = (val_1 + (val_7 >> 32)) + (z[((long)(int)((zOff + 1))) << 2]);
            mem2[0] = val_7;
            if((val_7 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zOff:  zOff, zPos:  2);
        }
        public static uint AddTo(int len, uint[] x, uint[] z)
        {
            int val_1;
            var val_2;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                val_1 = z.Length;
                if(val_2 >= val_1)
            {
                    val_1 = z.Length;
            }
            
                System.UInt32[] val_1 = 0 + 1152921505741541488;
                mem2[0] = 0;
                val_2 = val_2 + 1;
                val_2 = 0;
            }
            while(len != val_2);
            
                return (uint)val_2;
            }
            
            val_2 = 0;
            return (uint)val_2;
        }
        public static uint AddTo(int len, uint[] x, int xOff, uint[] z, int zOff)
        {
            var val_2;
            var val_3;
            int val_4;
            var val_5;
            val_2 = zOff;
            val_3 = xOff;
            if(len >= 1)
            {
                    uint val_4 = 0;
                int val_5 = len;
                do
            {
                val_4 = z.Length;
                if(val_2 >= val_4)
            {
                    val_4 = z.Length;
            }
            
                val_4 = (val_4 + (x[((long)(int)(xOff)) << 2])) + (z[((long)(int)(zOff)) << 2]);
                mem2[0] = val_4;
                val_5 = val_4 >> 32;
                val_2 = val_2 + 1;
                val_5 = val_5 - 1;
                val_3 = val_3 + 1;
            }
            while(val_5 != 0);
            
                return (uint)val_5;
            }
            
            val_5 = 0;
            return (uint)val_5;
        }
        public static uint AddWordAt(int len, uint x, uint[] z, int zPos)
        {
            int val_3;
            uint val_4 = x;
            val_3 = z.Length;
            if(val_3 <= zPos)
            {
                    val_3 = z.Length;
            }
            
            val_4 = (z[((long)(int)(zPos)) << 2]) + val_4;
            mem2[0] = val_4;
            if((val_4 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  zPos + 1);
        }
        public static uint AddWordAt(int len, uint x, uint[] z, int zOff, int zPos)
        {
            int val_4;
            uint val_5 = x;
            val_4 = z.Length;
            if((zPos + zOff) >= val_4)
            {
                    val_4 = z.Length;
            }
            
            val_5 = (z[((long)(int)((zPos + zOff))) << 2]) + val_5;
            mem2[0] = val_5;
            if((val_5 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zOff:  zOff, zPos:  zPos + 1);
        }
        public static uint AddWordTo(int len, uint x, uint[] z)
        {
            int val_2;
            uint val_3 = x;
            val_2 = z.Length;
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            val_3 = z[0] + val_3;
            z[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  1);
        }
        public static uint AddWordTo(int len, uint x, uint[] z, int zOff)
        {
            int val_2;
            uint val_3 = x;
            val_2 = z.Length;
            if(val_2 <= zOff)
            {
                    val_2 = z.Length;
            }
            
            val_3 = (z[((long)(int)(zOff)) << 2]) + val_3;
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zOff:  zOff, zPos:  1);
        }
        public static void Copy(int len, uint[] x, uint[] z)
        {
            System.Array.Copy(sourceArray:  x, sourceIndex:  0, destinationArray:  z, destinationIndex:  0, length:  len);
        }
        public static uint[] Copy(int len, uint[] x)
        {
            uint[] val_1 = new uint[0];
            System.Array.Copy(sourceArray:  x, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  len);
            return (System.UInt32[])val_1;
        }
        public static uint[] Create(int len)
        {
            uint[] val_1 = new uint[0];
        }
        public static ulong[] Create64(int len)
        {
            ulong[] val_1 = new ulong[0];
        }
        public static int Dec(int len, uint[] z)
        {
            var val_1;
            if(len < 1)
            {
                goto label_0;
            }
            
            var val_2 = 0;
            label_4:
            mem2[0] = 1152921505741541488 - 1;
            if(null != null)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (long)len)
            {
                goto label_4;
            }
            
            label_0:
            val_1 = 0;
            return (int)val_1;
            label_3:
            val_1 = 0;
            return (int)val_1;
        }
        public static int Dec(int len, uint[] x, uint[] z)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = len;
            var val_4 = 0;
            label_5:
            if(val_4 >= val_3)
            {
                goto label_0;
            }
            
            val_4 = 0;
            uint val_3 = x[0];
            val_4 = val_4 + 1;
            z[0] = val_3 - 1;
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            if(val_4 < val_3)
            {
                    var val_2 = (long)val_3 - (val_4 << );
                do
            {
                mem2[0] = null;
                val_2 = val_2 - 1;
                val_4 = val_4 + 1;
            }
            while(val_2 != 0);
            
            }
            
            val_5 = 0;
            return (int)val_5;
            label_0:
            val_5 = 0;
            return (int)val_5;
        }
        public static int DecAt(int len, uint[] z, int zPos)
        {
            var val_2;
            if(zPos >= len)
            {
                goto label_0;
            }
            
            var val_3 = (long)zPos;
            label_4:
            uint val_2 = z[((long)(int)(zPos)) << 2];
            z[((long)(int)(zPos)) << 2] = val_2 - 1;
            if(val_2 != 0)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(val_3 < (long)len)
            {
                goto label_4;
            }
            
            label_0:
            val_2 = 0;
            return (int)val_2;
            label_3:
            val_2 = 0;
            return (int)val_2;
        }
        public static int DecAt(int len, uint[] z, int zOff, int zPos)
        {
            var val_3;
            if(zPos >= len)
            {
                goto label_0;
            }
            
            var val_4 = (long)zPos;
            int val_1 = zPos + zOff;
            label_4:
            uint val_3 = z[((long)(int)((zPos + zOff))) << 2];
            z[((long)(int)((zPos + zOff))) << 2] = val_3 - 1;
            if(val_3 != 0)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_1 = val_1 + 1;
            if(val_4 < (long)len)
            {
                goto label_4;
            }
            
            label_0:
            val_3 = 0;
            return (int)val_3;
            label_3:
            val_3 = 0;
            return (int)val_3;
        }
        public static bool Eq(int len, uint[] x, uint[] y)
        {
            var val_2;
            var val_3;
            val_2 = len - 1;
            label_5:
            if((val_2 & 2147483648) != 0)
            {
                goto label_0;
            }
            
            val_2 = val_2 - 1;
            if((x[((long)(int)((len - 1))) << 2]) == (y[((long)(int)((len - 1))) << 2]))
            {
                goto label_5;
            }
            
            val_3 = 0;
            return (bool)val_3;
            label_0:
            val_3 = 1;
            return (bool)val_3;
        }
        public static uint[] FromBigInteger(int bits, Org.BouncyCastle.Math.BigInteger x)
        {
            uint val_10;
            Org.BouncyCastle.Math.BigInteger val_11 = x;
            if(((val_11.SignValue & 2147483648) != 0) || (val_11.BitLength > bits))
            {
                goto label_4;
            }
            
            System.UInt32[] val_5 = Org.BouncyCastle.Math.Raw.Nat.Create(len:  (bits + 31) >> 5);
            goto label_5;
            label_11:
            val_10 = val_11.IntValue;
            val_5[0] = val_10;
            val_11 = val_11.ShiftRight(n:  32);
            label_5:
            if(val_11.SignValue != 0)
            {
                goto label_11;
            }
            
            return val_5;
            label_4:
            System.ArgumentException val_9 = new System.ArgumentException();
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
            
            if(((val_3 >> 31) != 0) || ((val_3 >> 5) >= x.Length))
            {
                goto label_3;
            }
            
            val_3 = val_3 & 31;
            val_4 = (x[((long)(int)((bit >> 5))) << 2]) >> val_3;
            goto label_5;
            label_3:
            val_5 = 0;
            return (uint)val_5;
            label_0:
            val_4 = x[0];
            label_5:
            val_5 = val_4 & 1;
            return (uint)val_5;
        }
        public static bool Gte(int len, uint[] x, uint[] y)
        {
            var val_2;
            var val_3;
            val_2 = len - 1;
            label_6:
            if((val_2 & 2147483648) != 0)
            {
                goto label_0;
            }
            
            uint val_1 = x[((long)(int)((len - 1))) << 2];
            uint val_2 = y[((long)(int)((len - 1))) << 2];
            if(val_1 < val_2)
            {
                goto label_5;
            }
            
            val_2 = val_2 - 1;
            if(val_1 <= val_2)
            {
                goto label_6;
            }
            
            label_0:
            val_3 = 1;
            return (bool)val_3;
            label_5:
            val_3 = 0;
            return (bool)val_3;
        }
        public static uint Inc(int len, uint[] z)
        {
            var val_1;
            if(len < 1)
            {
                goto label_0;
            }
            
            var val_1 = 0;
            label_4:
            mem2[0] = null;
            if(null != null)
            {
                goto label_3;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < (long)len)
            {
                goto label_4;
            }
            
            label_0:
            val_1 = 1;
            return (uint)val_1;
            label_3:
            val_1 = 0;
            return (uint)val_1;
        }
        public static uint Inc(int len, uint[] x, uint[] z)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = len;
            var val_4 = 0;
            label_5:
            if(val_4 >= val_3)
            {
                goto label_0;
            }
            
            val_4 = 0;
            uint val_1 = x[0] + 1;
            val_4 = val_4 + 1;
            z[0] = val_1;
            if(val_1 == 0)
            {
                goto label_5;
            }
            
            if(val_4 < val_3)
            {
                    var val_2 = (long)val_3 - (val_4 << );
                do
            {
                mem2[0] = null;
                val_2 = val_2 - 1;
                val_4 = val_4 + 1;
            }
            while(val_2 != 0);
            
            }
            
            val_5 = 0;
            return (uint)val_5;
            label_0:
            val_5 = 1;
            return (uint)val_5;
        }
        public static uint IncAt(int len, uint[] z, int zPos)
        {
            var val_1;
            if(zPos >= len)
            {
                goto label_0;
            }
            
            var val_2 = (long)zPos;
            label_4:
            uint val_1 = z[((long)(int)(zPos)) << 2];
            val_1 = val_1 + 1;
            z[((long)(int)(zPos)) << 2] = val_1;
            if(val_1 != 0)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (long)len)
            {
                goto label_4;
            }
            
            label_0:
            val_1 = 1;
            return (uint)val_1;
            label_3:
            val_1 = 0;
            return (uint)val_1;
        }
        public static uint IncAt(int len, uint[] z, int zOff, int zPos)
        {
            var val_2;
            if(zPos >= len)
            {
                goto label_0;
            }
            
            var val_3 = (long)zPos;
            int val_1 = zPos + zOff;
            label_4:
            uint val_2 = z[((long)(int)((zPos + zOff))) << 2];
            val_2 = val_2 + 1;
            z[((long)(int)((zPos + zOff))) << 2] = val_2;
            if(val_2 != 0)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_1 = val_1 + 1;
            if(val_3 < (long)len)
            {
                goto label_4;
            }
            
            label_0:
            val_2 = 1;
            return (uint)val_2;
            label_3:
            val_2 = 0;
            return (uint)val_2;
        }
        public static bool IsOne(int len, uint[] x)
        {
            var val_1;
            if(x[0] != 1)
            {
                goto label_5;
            }
            
            if(len < 2)
            {
                goto label_3;
            }
            
            label_6:
            var val_1 = 9 - 8;
            if(x[0] != 0)
            {
                goto label_5;
            }
            
            var val_3 = 9 + 1;
            if((9 - 7) < (long)len)
            {
                goto label_6;
            }
            
            label_3:
            val_1 = 1;
            return (bool)val_1;
            label_5:
            val_1 = 0;
            return (bool)val_1;
        }
        public static bool IsZero(int len, uint[] x)
        {
            var val_1;
            if(x[0] == 0)
            {
                goto label_2;
            }
            
            label_6:
            val_1 = 0;
            return (bool)val_1;
            label_2:
            if(len < 2)
            {
                goto label_4;
            }
            
            label_7:
            var val_1 = 9 - 8;
            if(x[0] != 0)
            {
                goto label_6;
            }
            
            var val_3 = 9 + 1;
            if((9 - 7) < (long)len)
            {
                goto label_7;
            }
            
            label_4:
            val_1 = 1;
            return (bool)val_1;
        }
        public static void Mul(int len, uint[] x, uint[] y, uint[] zz)
        {
            uint val_5 = Org.BouncyCastle.Math.Raw.Nat.MulWord(len:  len, x:  x[0], y:  y, z:  zz);
            zz[((long)(int)(len)) << 2] = val_5;
            if(len < 2)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                var val_3 = val_8 + 1;
                int val_6 = len + val_8;
                val_6 = val_6 + 1;
                val_5 = Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len:  len, x:  1134694512, y:  y, yOff:  0, z:  zz, zOff:  val_8 + 1);
                val_8 = val_8 + 1;
                zz[((long)(int)(((len + 0) + 1))) << 2] = val_5;
            }
            while((len - 1) != val_8);
        
        }
        public static void Mul(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
        {
            int val_8;
            int val_9;
            var val_10;
            val_8 = zzOff;
            val_9 = len;
            val_10 = (long)val_8 + val_9;
            zz[((long)(int)((zzOff + len))) << 2] = Org.BouncyCastle.Math.Raw.Nat.MulWord(len:  val_9, x:  x[((long)(int)(xOff)) << 2], y:  y, yOff:  yOff, z:  zz, zOff:  val_8);
            if(val_9 < 2)
            {
                    return;
            }
            
            val_10 = val_8;
            val_9 = val_10 + val_9;
            var val_10 = 1;
            do
            {
                int val_3 = xOff + val_10;
                int val_6 = val_9 + val_10;
                int val_7 = val_9 + val_10;
                val_8 = Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len:  val_9, x:  x[((long)(int)((xOff + 1))) << 2], y:  y, yOff:  yOff, z:  zz, zOff:  val_10 + val_10);
                val_10 = val_10 + 1;
                zz[((long)(int)(((zzOff + len) + 1))) << 2] = val_8;
            }
            while(val_9 != val_10);
        
        }
        public static uint Mul31BothAdd(int len, uint a, uint[] x, uint b, uint[] y, uint[] z, int zOff)
        {
            int val_2;
            var val_6 = 0;
            System.UInt32[] val_5 = 0;
            System.UInt32[] val_2 = x[32];
            do
            {
                val_2 = z.Length;
                if((zOff + val_6) >= val_2)
            {
                    val_2 = z.Length;
            }
            
                uint val_4 = a;
                val_4 = val_5 + ((x[0x20] + 0) * val_4);
                val_4 = val_4 + (1152921505741541488 * b);
                val_5 = val_4 + (z[((long)(int)((zOff + 0))) << 2]);
                mem2[0] = val_5;
                val_6 = val_6 + 1;
                val_5 = val_5 >> 32;
            }
            while(val_6 < (long)len);
            
            return (uint)val_5;
        }
        public static uint MulWord(int len, uint x, uint[] y, uint[] z)
        {
            var val_2 = 0;
            System.UInt32[] val_1 = 0;
            do
            {
                val_1 = val_1 + (1152921505741541488 * x);
                mem2[0] = val_1;
                val_2 = val_2 + 1;
                val_1 = val_1 >> 32;
            }
            while(val_2 < (long)len);
            
            return (uint)val_1;
        }
        public static uint MulWord(int len, uint x, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_5 = 0;
            uint val_4 = 0;
            do
            {
                int val_1 = yOff + val_5;
                val_4 = val_4 + ((y[((long)(int)((yOff + 0))) << 2]) * x);
                int val_2 = zOff + val_5;
                val_5 = val_5 + 1;
                z[((long)(int)((zOff + 0))) << 2] = val_4;
                val_4 = val_4 >> 32;
            }
            while(val_5 < (long)len);
            
            return (uint)val_4;
        }
        public static uint MulWordAddTo(int len, uint x, uint[] y, int yOff, uint[] z, int zOff)
        {
            int val_3;
            var val_7 = 0;
            uint val_6 = 0;
            do
            {
                int val_1 = yOff + val_7;
                val_3 = z.Length;
                if((zOff + val_7) >= val_3)
            {
                    val_3 = z.Length;
            }
            
                uint val_5 = x;
                val_5 = val_6 + ((y[((long)(int)((yOff + 0))) << 2]) * val_5);
                val_6 = val_5 + (z[((long)(int)((zOff + 0))) << 2]);
                val_7 = val_7 + 1;
                mem2[0] = val_6;
                val_6 = val_6 >> 32;
            }
            while(val_7 < (long)len);
            
            return (uint)val_6;
        }
        public static uint MulWordDwordAddAt(int len, uint x, ulong y, uint[] z, int zPos)
        {
            int val_8;
            int val_9;
            int val_10;
            ulong val_10 = y;
            val_8 = z.Length;
            if(val_8 <= zPos)
            {
                    val_8 = z.Length;
            }
            
            ulong val_2 = (z[((long)(int)(zPos)) << 2]) + ((val_10 & 4294967295) * x);
            mem2[0] = val_2;
            val_9 = z.Length;
            val_2 = val_2 >> 32;
            if((zPos + 1) >= val_9)
            {
                    val_9 = z.Length;
            }
            
            ulong val_4 = val_10 >> 32;
            val_4 = val_2 + (val_4 * x);
            val_10 = val_4 + (z[((long)(int)((zPos + 1))) << 2]);
            mem2[0] = val_10;
            val_10 = z.Length;
            val_10 = val_10 >> 32;
            if((zPos + 2) >= val_10)
            {
                    val_10 = z.Length;
            }
            
            val_10 = val_10 + (z[((long)(int)((zPos + 2))) << 2]);
            mem2[0] = val_10;
            if((val_10 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.IncAt(len:  len, z:  z, zPos:  zPos + 3);
        }
        public static uint ShiftDownBit(int len, uint[] z, uint c)
        {
            int val_3;
            uint val_4;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    var val_3 = (long)val_1;
                do
            {
                val_3 = z.Length;
                if(val_3 >= val_3)
            {
                    val_3 = z.Length;
            }
            
                val_4 = z[((long)(int)((len - 1))) << 2];
                val_3 = val_3 - 1;
                z[((long)(int)((len - 1))) << 2] = c;
            }
            while((val_3 & 2147483648) == 0);
            
                return (uint)val_4 << 31;
            }
            
            val_4 = c;
            return (uint)val_4 << 31;
        }
        public static uint ShiftDownBit(int len, uint[] z, int zOff, uint c)
        {
            uint val_4;
            int val_5;
            uint val_6;
            val_4 = c;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    do
            {
                val_5 = z.Length;
                if((zOff + val_1) >= val_5)
            {
                    val_5 = z.Length;
            }
            
                val_6 = z[((long)(int)((zOff + (len - 1)))) << 2];
                val_1 = val_1 - 1;
                mem2[0] = val_4;
                val_4 = val_6;
            }
            while((val_1 & 2147483648) == 0);
            
                return (uint)val_6 << 31;
            }
            
            val_6 = val_4;
            return (uint)val_6 << 31;
        }
        public static uint ShiftDownBit(int len, uint[] x, uint c, uint[] z)
        {
            uint val_6;
            var val_7;
            val_6 = c;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    var val_2 = (long)val_1 + 8;
                do
            {
                var val_3 = val_2 - 8;
                mem2[0] = val_6;
                val_2 = val_2 - 1;
                val_6 = 1152921505741541488;
            }
            while(((val_2 - 8) & 2147483648) == 0);
            
                return (uint)val_7 << 31;
            }
            
            val_7 = val_6;
            return (uint)val_7 << 31;
        }
        public static uint ShiftDownBit(int len, uint[] x, int xOff, uint c, uint[] z, int zOff)
        {
            uint val_5;
            uint val_6;
            val_5 = c;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    do
            {
                int val_2 = xOff + val_1;
                val_6 = x[((long)(int)((xOff + (len - 1)))) << 2];
                int val_3 = zOff + val_1;
                val_1 = val_1 - 1;
                z[((long)(int)((zOff + (len - 1)))) << 2] = val_5;
                val_5 = val_6;
            }
            while((val_1 & 2147483648) == 0);
            
                return (uint)val_6 << 31;
            }
            
            val_6 = val_5;
            return (uint)val_6 << 31;
        }
        public static uint ShiftDownBits(int len, uint[] z, int bits, uint c)
        {
            uint val_7;
            var val_8;
            int val_9;
            val_7 = c;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    var val_6 = -bits;
                val_8 = val_6 & 31;
                var val_7 = (long)val_1;
                do
            {
                val_9 = z.Length;
                if(val_7 >= val_9)
            {
                    val_9 = z.Length;
            }
            
                uint val_5 = z[((long)(int)((len - 1))) << 2];
                val_6 = val_7 << val_8;
                val_7 = (val_5 >> (bits & 31)) | val_6;
                val_7 = val_7 - 1;
                z[((long)(int)((len - 1))) << 2] = val_7;
            }
            while((val_7 & 2147483648) == 0);
            
                val_7 = val_5;
                return (uint)val_7 << val_8;
            }
            
            val_8 = (-bits) & 31;
            return (uint)val_7 << val_8;
        }
        public static uint ShiftDownBits(int len, uint[] z, int zOff, int bits, uint c)
        {
            uint val_9;
            var val_10;
            var val_11;
            int val_12;
            val_9 = c;
            val_10 = len - 1;
            if((val_10 & 2147483648) == 0)
            {
                    val_11 = (-bits) & 31;
                do
            {
                val_12 = z.Length;
                if((zOff + val_10) >= val_12)
            {
                    val_12 = z.Length;
            }
            
                uint val_6 = z[((long)(int)((zOff + (len - 1)))) << 2];
                val_9 = (val_6 >> (bits & 31)) | (val_9 << val_11);
                val_10 = val_10 - 1;
                mem2[0] = val_9;
            }
            while((val_10 & 2147483648) == 0);
            
                val_9 = val_6;
                return (uint)val_9 << val_11;
            }
            
            val_11 = (-bits) & 31;
            return (uint)val_9 << val_11;
        }
        public static uint ShiftDownBits(int len, uint[] x, int bits, uint c, uint[] z)
        {
            System.UInt32[] val_11;
            var val_12;
            val_11 = c;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    val_12 = (-bits) & 31;
                var val_3 = (long)val_1 + 8;
                do
            {
                var val_4 = val_3 - 8;
                val_11 = (1152921505741541488 >> (bits & 31)) | (val_11 << val_12);
                mem2[0] = val_11;
                val_3 = val_3 - 1;
            }
            while(((val_3 - 8) & 2147483648) == 0);
            
                val_11 = 1152921505741541488;
                return (uint)val_11 << val_12;
            }
            
            val_12 = (-bits) & 31;
            return (uint)val_11 << val_12;
        }
        public static uint ShiftDownBits(int len, uint[] x, int xOff, int bits, uint c, uint[] z, int zOff)
        {
            uint val_10;
            var val_11;
            var val_12;
            val_10 = c;
            val_11 = len - 1;
            if((val_11 & 2147483648) == 0)
            {
                    val_12 = (-bits) & 31;
                do
            {
                int val_2 = xOff + val_11;
                uint val_7 = x[((long)(int)((xOff + (len - 1)))) << 2];
                int val_3 = zOff + val_11;
                val_10 = (val_7 >> (bits & 31)) | (val_10 << val_12);
                val_11 = val_11 - 1;
                z[((long)(int)((zOff + (len - 1)))) << 2] = val_10;
            }
            while((val_11 & 2147483648) == 0);
            
                val_10 = val_7;
                return (uint)val_10 << val_12;
            }
            
            val_12 = (-bits) & 31;
            return (uint)val_10 << val_12;
        }
        public static uint ShiftDownWord(int len, uint[] z, uint c)
        {
            uint val_2;
            int val_3;
            uint val_4;
            val_2 = c;
            int val_1 = len - 1;
            if((val_1 & 2147483648) == 0)
            {
                    var val_2 = (long)val_1;
                do
            {
                val_3 = z.Length;
                if(val_2 >= val_3)
            {
                    val_3 = z.Length;
            }
            
                val_4 = z[((long)(int)((len - 1))) << 2];
                val_2 = val_2 - 1;
                z[((long)(int)((len - 1))) << 2] = val_2;
                val_2 = val_4;
            }
            while((val_2 & 2147483648) == 0);
            
                return (uint)val_4;
            }
            
            val_4 = val_2;
            return (uint)val_4;
        }
        public static uint ShiftUpBit(int len, uint[] z, uint c)
        {
            int val_2;
            var val_3;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                val_2 = z.Length;
                if(val_2 >= val_2)
            {
                    val_2 = z.Length;
            }
            
                mem2[0] = c;
                val_2 = val_2 + 1;
            }
            while(len != val_2);
            
                return (uint)val_3 >> 31;
            }
            
            val_3 = c;
            return (uint)val_3 >> 31;
        }
        public static uint ShiftUpBit(int len, uint[] z, int zOff, uint c)
        {
            uint val_2;
            var val_3;
            int val_4;
            uint val_5;
            val_2 = c;
            val_3 = zOff;
            if(len >= 1)
            {
                    int val_2 = len;
                do
            {
                val_4 = z.Length;
                if(val_3 >= val_4)
            {
                    val_4 = z.Length;
            }
            
                val_5 = z[((long)(int)(zOff)) << 2];
                mem2[0] = val_2;
                val_2 = val_2 - 1;
                val_3 = val_3 + 1;
                val_2 = val_5;
            }
            while(val_2 != 0);
            
                return (uint)val_5 >> 31;
            }
            
            val_5 = val_2;
            return (uint)val_5 >> 31;
        }
        public static uint ShiftUpBit(int len, uint[] x, uint c, uint[] z)
        {
            uint val_2;
            var val_3;
            val_2 = c;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                mem2[0] = val_2;
                val_2 = val_2 + 1;
                val_2 = 1152921505741541488;
            }
            while(len != val_2);
            
                return (uint)val_3 >> 31;
            }
            
            val_3 = val_2;
            return (uint)val_3 >> 31;
        }
        public static uint ShiftUpBit(int len, uint[] x, int xOff, uint c, uint[] z, int zOff)
        {
            var val_2;
            uint val_3;
            var val_4;
            uint val_5;
            val_2 = zOff;
            val_3 = c;
            val_4 = xOff;
            if(len >= 1)
            {
                    int val_2 = len;
                do
            {
                val_5 = x[((long)(int)(xOff)) << 2];
                val_2 = val_2 + 1;
                val_2 = val_2 - 1;
                z[((long)(int)(zOff)) << 2] = val_3;
                val_4 = val_4 + 1;
                val_3 = val_5;
            }
            while(val_2 != 0);
            
                return (uint)val_5 >> 31;
            }
            
            val_5 = val_3;
            return (uint)val_5 >> 31;
        }
        public static ulong ShiftUpBit64(int len, ulong[] x, int xOff, ulong c, ulong[] z, int zOff)
        {
            var val_2;
            ulong val_3;
            var val_4;
            ulong val_5;
            val_2 = zOff;
            val_3 = c;
            val_4 = xOff;
            if(len >= 1)
            {
                    int val_2 = len;
                do
            {
                val_5 = x[(long)val_4];
                val_2 = val_2 + 1;
                val_2 = val_2 - 1;
                z[(long)val_2] = val_3;
                val_4 = val_4 + 1;
                val_3 = val_5;
            }
            while(val_2 != 0);
            
                return (ulong)val_5 >> 63;
            }
            
            val_5 = val_3;
            return (ulong)val_5 >> 63;
        }
        public static uint ShiftUpBits(int len, uint[] z, int bits, uint c)
        {
            System.UInt32[] val_7;
            var val_8;
            int val_9;
            val_7 = c;
            if(len > 0)
            {
                    var val_5 = 0;
                val_8 = (-bits) & 31;
                do
            {
                val_9 = z.Length;
                if(val_5 >= val_9)
            {
                    val_9 = z.Length;
            }
            
                val_7 = (1152921505741541488 << (bits & 31)) | (val_7 >> val_8);
                mem2[0] = val_7;
                val_5 = val_5 + 1;
            }
            while(len != val_5);
            
                val_7 = 1152921505741541488;
                return (uint)val_7 >> val_8;
            }
            
            val_8 = (-bits) & 31;
            return (uint)val_7 >> val_8;
        }
        public static uint ShiftUpBits(int len, uint[] z, int zOff, int bits, uint c)
        {
            uint val_7;
            var val_8;
            var val_9;
            int val_10;
            val_7 = c;
            val_8 = zOff;
            if(len > 0)
            {
                    val_9 = (-bits) & 31;
                int val_6 = len;
                do
            {
                val_10 = z.Length;
                if(val_8 >= val_10)
            {
                    val_10 = z.Length;
            }
            
                uint val_5 = z[((long)(int)(zOff)) << 2];
                val_7 = (val_5 << (bits & 31)) | (val_7 >> val_9);
                mem2[0] = val_7;
                val_6 = val_6 - 1;
                val_8 = val_8 + 1;
            }
            while(val_6 != 0);
            
                val_7 = val_5;
                return (uint)val_7 >> val_9;
            }
            
            val_9 = (-bits) & 31;
            return (uint)val_7 >> val_9;
        }
        public static ulong ShiftUpBits64(int len, ulong[] z, int zOff, int bits, ulong c)
        {
            ulong val_7;
            var val_8;
            var val_9;
            int val_10;
            val_7 = c;
            val_8 = zOff;
            if(len > 0)
            {
                    val_9 = (-bits) & 63;
                int val_6 = len;
                do
            {
                val_10 = z.Length;
                if(val_8 >= val_10)
            {
                    val_10 = z.Length;
            }
            
                ulong val_5 = z[(long)val_8];
                val_7 = (val_5 << (bits & 63)) | (val_7 >> val_9);
                mem2[0] = val_7;
                val_6 = val_6 - 1;
                val_8 = val_8 + 1;
            }
            while(val_6 != 0);
            
                val_7 = val_5;
                return (ulong)val_7 >> val_9;
            }
            
            val_9 = (-bits) & 63;
            return (ulong)val_7 >> val_9;
        }
        public static uint ShiftUpBits(int len, uint[] x, int bits, uint c, uint[] z)
        {
            System.UInt32[] val_7;
            var val_8;
            val_7 = c;
            if(len > 0)
            {
                    var val_5 = 0;
                val_8 = (-bits) & 31;
                do
            {
                val_7 = (1152921505741541488 << (bits & 31)) | (val_7 >> val_8);
                mem2[0] = val_7;
                val_5 = val_5 + 1;
            }
            while(len != val_5);
            
                val_7 = 1152921505741541488;
                return (uint)val_7 >> val_8;
            }
            
            val_8 = (-bits) & 31;
            return (uint)val_7 >> val_8;
        }
        public static uint ShiftUpBits(int len, uint[] x, int xOff, int bits, uint c, uint[] z, int zOff)
        {
            var val_7;
            uint val_8;
            var val_9;
            var val_10;
            val_7 = zOff;
            val_8 = c;
            val_9 = xOff;
            if(len > 0)
            {
                    val_10 = (-bits) & 31;
                int val_6 = len;
                do
            {
                uint val_5 = x[((long)(int)(xOff)) << 2];
                val_8 = (val_5 << (bits & 31)) | (val_8 >> val_10);
                val_7 = val_7 + 1;
                val_6 = val_6 - 1;
                z[((long)(int)(zOff)) << 2] = val_8;
                val_9 = val_9 + 1;
            }
            while(val_6 != 0);
            
                val_8 = val_5;
                return (uint)val_8 >> val_10;
            }
            
            val_10 = (-bits) & 31;
            return (uint)val_8 >> val_10;
        }
        public static ulong ShiftUpBits64(int len, ulong[] x, int xOff, int bits, ulong c, ulong[] z, int zOff)
        {
            var val_7;
            ulong val_8;
            var val_9;
            var val_10;
            val_7 = zOff;
            val_8 = c;
            val_9 = xOff;
            if(len > 0)
            {
                    val_10 = (-bits) & 63;
                int val_6 = len;
                do
            {
                ulong val_5 = x[(long)val_9];
                val_8 = (val_5 << (bits & 63)) | (val_8 >> val_10);
                val_7 = val_7 + 1;
                val_6 = val_6 - 1;
                z[(long)val_7] = val_8;
                val_9 = val_9 + 1;
            }
            while(val_6 != 0);
            
                val_8 = val_5;
                return (ulong)val_8 >> val_10;
            }
            
            val_10 = (-bits) & 63;
            return (ulong)val_8 >> val_10;
        }
        public static void Square(int len, uint[] x, uint[] zz)
        {
            var val_9;
            int val_2 = len << 1;
            int val_3 = val_2 - 2;
            int val_12 = len;
            do
            {
                val_12 = val_12 - 1;
                int val_4 = val_3 + 1;
                System.UInt32[] val_5 = 1152921505741541488 * 1152921505741541488;
                zz[((long)(int)((((len << 1) - 2) + 1))) << 2] = val_5 >> 33;
                val_9 = val_3 - 2;
                zz[((long)(int)(((len << 1) - 2))) << 2] = val_5 >> 1;
                x[(len - 1) << 2][32] = (x[(len - 1) << 2][32]) - 4;
            }
            while(val_12 > 0);
            
            if(len >= 2)
            {
                    var val_13 = 2;
                do
            {
                uint val_9 = Org.BouncyCastle.Math.Raw.Nat.AddWordAt(len:  val_2, x:  Org.BouncyCastle.Math.Raw.Nat.SquareWordAdd(x:  x, xPos:  1, z:  zz), z:  zz, zPos:  2);
                val_9 = 1 + 1;
                val_13 = val_13 + 2;
            }
            while(len != val_9);
            
            }
            
            uint val_11 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  val_2, z:  zz, c:  x[0] << 31);
        }
        public static void Square(int len, uint[] x, int xOff, uint[] zz, int zzOff)
        {
            var val_15;
            int val_1 = len << 1;
            int val_3 = xOff + len;
            int val_4 = (zzOff + (len << 1)) - 1;
            do
            {
                val_3 = (val_3 - 1) + 0;
                uint val_6 = (x[((long)(int)((((xOff + len) - 1) + 0))) << 2]) * (x[((long)(int)((((xOff + len) - 1) + 0))) << 2]);
                zz[((long)(int)(((zzOff + (len) << 1) - 1))) << 2] = val_6 >> 33;
                int val_8 = val_4 - 1;
                val_15 = 0 - 1;
                zz[((long)(int)((((zzOff + (len) << 1) - 1) - 1))) << 2] = val_6 >> 1;
                val_4 = val_4 - 2;
            }
            while((len + val_15) > 0);
            
            if(len >= 2)
            {
                    var val_16 = 2;
                do
            {
                uint val_12 = Org.BouncyCastle.Math.Raw.Nat.AddWordAt(len:  val_1, x:  Org.BouncyCastle.Math.Raw.Nat.SquareWordAdd(x:  x, xOff:  xOff, xPos:  1, z:  zz, zOff:  zzOff), z:  zz, zOff:  zzOff, zPos:  2);
                val_15 = 1 + 1;
                val_16 = val_16 + 2;
            }
            while(len != val_15);
            
            }
            
            uint val_14 = Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(len:  val_1, z:  zz, zOff:  zzOff, c:  (x[((long)(int)(xOff)) << 2]) << 31);
        }
        public static uint SquareWordAdd(uint[] x, int xPos, uint[] z)
        {
            int val_3;
            var val_5 = 0;
            System.UInt32[] val_4 = 0;
            do
            {
                val_3 = z.Length;
                if((xPos + val_5) >= val_3)
            {
                    val_3 = z.Length;
            }
            
                System.UInt32[] val_3 = val_4 + (1152921505741541488 * val_3);
                val_4 = val_3 + (z[((long)(int)((xPos + 0))) << 2]);
                val_5 = val_5 + 1;
                mem2[0] = val_4;
                val_4 = val_4 >> 32;
            }
            while(val_5 < (long)xPos);
            
            return (uint)val_4;
        }
        public static uint SquareWordAdd(uint[] x, int xOff, int xPos, uint[] z, int zOff)
        {
            int val_4;
            int val_5 = zOff;
            int val_1 = xPos + xOff;
            var val_10 = 0;
            uint val_9 = 0;
            val_5 = val_5 + xPos;
            do
            {
                int val_2 = xOff + val_10;
                val_4 = z.Length;
                if((val_5 + val_10) >= val_4)
            {
                    val_4 = z.Length;
            }
            
                uint val_8 = x[((long)(int)((xPos + xOff))) << 2];
                val_8 = val_9 + ((x[((long)(int)((xOff + 0))) << 2]) * val_8);
                val_9 = val_8 + (z[((long)(int)(((zOff + xPos) + 0))) << 2]);
                val_10 = val_10 + 1;
                mem2[0] = val_9;
                val_9 = val_9 >> 32;
            }
            while(val_10 < (long)xPos);
            
            return (uint)val_9;
        }
        public static int Sub(int len, uint[] x, uint[] y, uint[] z)
        {
            var val_1;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                System.UInt32[] val_1 = 1152921505741541488 - 1152921505741541488;
                mem2[0] = null;
                val_2 = val_2 + 1;
            }
            while(len != val_2);
            
                val_1 = 0;
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public static int Sub(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = zOff;
            val_4 = yOff;
            val_5 = xOff;
            if(len >= 1)
            {
                    int val_4 = len;
                do
            {
                uint val_2 = x[((long)(int)(xOff)) << 2];
                uint val_3 = y[((long)(int)(yOff)) << 2];
                val_3 = val_2 - val_3;
                val_2 = val_3 + 0;
                uint val_1 = val_2 >> 32;
                val_3 = val_3 + 1;
                val_4 = val_4 + 1;
                val_4 = val_4 - 1;
                val_5 = val_5 + 1;
                z[((long)(int)(zOff)) << 2] = val_2;
            }
            while(val_4 != 0);
            
                val_6 = val_2 >> 32;
                return (int)val_6;
            }
            
            val_6 = 0;
            return (int)val_6;
        }
        public static int Sub33At(int len, uint x, uint[] z, int zPos)
        {
            int val_6;
            int val_7;
            uint val_7 = x;
            val_6 = z.Length;
            if(val_6 <= zPos)
            {
                    val_6 = z.Length;
            }
            
            val_7 = (z[((long)(int)(zPos)) << 2]) - val_7;
            mem2[0] = val_7;
            val_7 = z.Length;
            if((zPos + 1) >= val_7)
            {
                    val_7 = z.Length;
            }
            
            uint val_8 = z[((long)(int)((zPos + 1))) << 2];
            val_8 = (val_7 >> 32) + val_8;
            uint val_3 = val_8 - 1;
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zPos:  zPos + 2);
        }
        public static int Sub33At(int len, uint x, uint[] z, int zOff, int zPos)
        {
            int val_7;
            int val_8;
            uint val_8 = x;
            val_7 = z.Length;
            int val_1 = zPos + zOff;
            if(val_1 >= val_7)
            {
                    val_7 = z.Length;
            }
            
            val_8 = (z[((long)(int)((zPos + zOff))) << 2]) - val_8;
            mem2[0] = val_8;
            val_8 = z.Length;
            if(((long)val_1 + 1) >= val_8)
            {
                    val_8 = z.Length;
            }
            
            uint val_9 = z[((long)(int)(((long)(int)((zPos + zOff)) + 1))) << 2];
            val_9 = (val_8 >> 32) + val_9;
            uint val_4 = val_9 - 1;
            mem2[0] = val_4;
            if((val_4 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zOff:  zOff, zPos:  zPos + 2);
        }
        public static int Sub33From(int len, uint x, uint[] z)
        {
            int val_2;
            uint val_3 = x;
            val_2 = z.Length;
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            val_3 = z[0] - val_3;
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            z[0] = val_3;
            val_3 = val_3 >> 32;
            if(val_2 <= 1)
            {
                    val_2 = z.Length;
            }
            
            uint val_4 = z[0];
            val_4 = val_3 + val_4;
            val_3 = val_4 - 1;
            z[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zPos:  2);
        }
        public static int Sub33From(int len, uint x, uint[] z, int zOff)
        {
            int val_5;
            int val_6;
            uint val_6 = x;
            val_5 = z.Length;
            if(val_5 <= zOff)
            {
                    val_5 = z.Length;
            }
            
            val_6 = (z[((long)(int)(zOff)) << 2]) - val_6;
            mem2[0] = val_6;
            val_6 = z.Length;
            if((zOff + 1) >= val_6)
            {
                    val_6 = z.Length;
            }
            
            uint val_7 = z[((long)(int)((zOff + 1))) << 2];
            val_7 = (val_6 >> 32) + val_7;
            uint val_3 = val_7 - 1;
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zOff:  zOff, zPos:  2);
        }
        public static int SubBothFrom(int len, uint[] x, uint[] y, uint[] z)
        {
            var val_1;
            if(len >= 1)
            {
                    var val_3 = 0;
                var val_4 = 0;
                do
            {
                System.UInt32[] val_1 = val_4 + 1152921505741541488;
                val_1 = val_1 - 1152921505741541488;
                System.UInt32[] val_2 = val_1 - 1152921505741541488;
                mem2[0] = val_2;
                val_3 = val_3 + 1;
                val_4 = val_2 >> 32;
            }
            while(len != val_3);
            
                val_1 = val_2 >> 32;
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public static int SubBothFrom(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = zOff;
            val_3 = yOff;
            val_4 = xOff;
            if(len >= 1)
            {
                    var val_5 = 0;
                int val_6 = len;
                do
            {
                uint val_2 = x[((long)(int)(xOff)) << 2];
                uint val_4 = z[((long)(int)(zOff)) << 2];
                val_4 = val_5 + val_4;
                val_4 = val_4 - val_2;
                val_2 = val_4 - (y[((long)(int)(yOff)) << 2]);
                mem2[0] = val_2;
                val_5 = val_2 >> 32;
                val_3 = val_3 + 1;
                val_4 = val_4 + 1;
                val_6 = val_6 - 1;
                val_2 = val_2 + 1;
            }
            while(val_6 != 0);
            
                val_5 = val_2 >> 32;
                return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public static int SubDWordAt(int len, ulong x, uint[] z, int zPos)
        {
            int val_6;
            int val_7;
            ulong val_8 = x;
            val_6 = z.Length;
            if(val_6 <= zPos)
            {
                    val_6 = z.Length;
            }
            
            uint val_1 = (z[((long)(int)(zPos)) << 2]) - val_8;
            mem2[0] = val_1;
            val_7 = z.Length;
            if((zPos + 1) >= val_7)
            {
                    val_7 = z.Length;
            }
            
            uint val_7 = z[((long)(int)((zPos + 1))) << 2];
            val_7 = val_7 - (val_8 >> 32);
            val_8 = val_7 + (val_1 >> 32);
            mem2[0] = val_8;
            if((val_8 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zPos:  zPos + 2);
        }
        public static int SubDWordAt(int len, ulong x, uint[] z, int zOff, int zPos)
        {
            int val_7;
            int val_8;
            ulong val_9 = x;
            val_7 = z.Length;
            int val_1 = zPos + zOff;
            if(val_1 >= val_7)
            {
                    val_7 = z.Length;
            }
            
            uint val_2 = (z[((long)(int)((zPos + zOff))) << 2]) - val_9;
            mem2[0] = val_2;
            val_8 = z.Length;
            if(((long)val_1 + 1) >= val_8)
            {
                    val_8 = z.Length;
            }
            
            uint val_8 = z[((long)(int)(((long)(int)((zPos + zOff)) + 1))) << 2];
            val_8 = val_8 - (val_9 >> 32);
            val_9 = val_8 + (val_2 >> 32);
            mem2[0] = val_9;
            if((val_9 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zOff:  zOff, zPos:  zPos + 2);
        }
        public static int SubDWordFrom(int len, ulong x, uint[] z)
        {
            int val_3;
            ulong val_5 = x;
            val_3 = z.Length;
            if(val_3 == 0)
            {
                    val_3 = z.Length;
            }
            
            uint val_1 = z[0] - val_5;
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
            
            uint val_4 = z[0];
            val_4 = val_4 - (val_5 >> 32);
            val_5 = val_4 + val_1;
            z[0] = val_5;
            if((val_5 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zPos:  2);
        }
        public static int SubDWordFrom(int len, ulong x, uint[] z, int zOff)
        {
            int val_5;
            int val_6;
            ulong val_7 = x;
            val_5 = z.Length;
            if(val_5 <= zOff)
            {
                    val_5 = z.Length;
            }
            
            uint val_1 = (z[((long)(int)(zOff)) << 2]) - val_7;
            mem2[0] = val_1;
            val_6 = z.Length;
            if((zOff + 1) >= val_6)
            {
                    val_6 = z.Length;
            }
            
            uint val_6 = z[((long)(int)((zOff + 1))) << 2];
            val_6 = val_6 - (val_7 >> 32);
            val_7 = val_6 + (val_1 >> 32);
            mem2[0] = val_7;
            if((val_7 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zOff:  zOff, zPos:  2);
        }
        public static int SubFrom(int len, uint[] x, uint[] z)
        {
            var val_1;
            if(len >= 1)
            {
                    var val_2 = 0;
                do
            {
                System.UInt32[] val_1 = 1152921505741541488 - 1152921505741541488;
                mem2[0] = null;
                val_2 = val_2 + 1;
            }
            while(len != val_2);
            
                val_1 = 0;
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public static int SubFrom(int len, uint[] x, int xOff, uint[] z, int zOff)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = zOff;
            val_3 = xOff;
            if(len >= 1)
            {
                    var val_3 = 0;
                int val_4 = len;
                do
            {
                uint val_1 = z[((long)(int)(zOff)) << 2];
                uint val_2 = x[((long)(int)(xOff)) << 2];
                val_2 = val_1 - val_2;
                val_1 = val_2 + val_3;
                val_3 = val_1 >> 32;
                val_3 = val_3 + 1;
                val_4 = val_4 - 1;
                val_2 = val_2 + 1;
                mem2[0] = val_1;
            }
            while(val_4 != 0);
            
                val_4 = val_1 >> 32;
                return (int)val_4;
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        public static int SubWordAt(int len, uint x, uint[] z, int zPos)
        {
            int val_3;
            uint val_4 = x;
            val_3 = z.Length;
            if(val_3 <= zPos)
            {
                    val_3 = z.Length;
            }
            
            val_4 = (z[((long)(int)(zPos)) << 2]) - val_4;
            mem2[0] = val_4;
            if((val_4 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zPos:  zPos + 1);
        }
        public static int SubWordAt(int len, uint x, uint[] z, int zOff, int zPos)
        {
            int val_4;
            uint val_5 = x;
            val_4 = z.Length;
            if((zPos + zOff) >= val_4)
            {
                    val_4 = z.Length;
            }
            
            val_5 = (z[((long)(int)((zPos + zOff))) << 2]) - val_5;
            mem2[0] = val_5;
            if((val_5 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zOff:  zOff, zPos:  zPos + 1);
        }
        public static int SubWordFrom(int len, uint x, uint[] z)
        {
            int val_2;
            uint val_3 = x;
            val_2 = z.Length;
            if(val_2 == 0)
            {
                    val_2 = z.Length;
            }
            
            val_3 = z[0] - val_3;
            z[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zPos:  1);
        }
        public static int SubWordFrom(int len, uint x, uint[] z, int zOff)
        {
            int val_2;
            uint val_3 = x;
            val_2 = z.Length;
            if(val_2 <= zOff)
            {
                    val_2 = z.Length;
            }
            
            val_3 = (z[((long)(int)(zOff)) << 2]) - val_3;
            mem2[0] = val_3;
            if((val_3 >> 32) == 0)
            {
                    return 0;
            }
            
            return Org.BouncyCastle.Math.Raw.Nat.DecAt(len:  len, z:  z, zOff:  zOff, zPos:  1);
        }
        public static Org.BouncyCastle.Math.BigInteger ToBigInteger(int len, uint[] x)
        {
            int val_4 = len;
            byte[] val_2 = new byte[0];
            if(val_4 < 1)
            {
                    return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_2);
            }
            
            var val_4 = 0;
            val_4 = (val_4 << 2) - 4;
            do
            {
                if(null != null)
            {
                    Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  1134694512, bs:  val_2, off:  val_4);
            }
            
                val_4 = val_4 + 1;
                val_4 = val_4 - 4;
            }
            while(val_4 != val_4);
            
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_2);
        }
        public static void Zero(int len, uint[] z)
        {
            if(len < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            do
            {
                mem2[0] = 0;
                val_1 = val_1 + 1;
            }
            while(len != val_1);
        
        }
        protected Nat()
        {
        
        }
    
    }

}
