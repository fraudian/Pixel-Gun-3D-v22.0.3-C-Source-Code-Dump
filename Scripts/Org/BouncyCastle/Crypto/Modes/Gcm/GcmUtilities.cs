using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
    internal abstract class GcmUtilities
    {
        // Fields
        private const uint E1 = 3774873600;
        private const ulong E1L = 16212958658533785600;
        private static readonly uint[] LOOKUP;
        
        // Methods
        private static uint[] GenerateLookup()
        {
            uint val_2;
            uint[] val_1 = new uint[256];
            var val_4 = 0;
            do
            {
                var val_3 = 0;
                val_2 = 0;
                do
            {
                var val_2 = 0;
                val_2 = val_2 & val_4;
                if(val_2 != 0)
            {
                    val_2 = 0 ^ val_2;
            }
            
                val_3 = val_3 + 1;
            }
            while(7 > 0);
            
                val_4 = val_4 + 1;
                val_1[0] = val_2;
            }
            while(val_4 != 256);
            
            return (System.UInt32[])val_1;
        }
        internal static byte[] OneAsBytes()
        {
            byte[] val_1 = new byte[16];
            val_1[0] = 128;
            return (System.Byte[])val_1;
        }
        internal static uint[] OneAsUints()
        {
            uint[] val_1 = new uint[4];
            val_1[0] = -2147483648;
            return (System.UInt32[])val_1;
        }
        internal static ulong[] OneAsUlongs()
        {
            ulong[] val_1 = new ulong[2];
            val_1[0] = -9223372036854775808;
            return (System.UInt64[])val_1;
        }
        internal static byte[] AsBytes(uint[] x)
        {
            return Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns:  x);
        }
        internal static void AsBytes(uint[] x, byte[] z)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns:  x, bs:  z, off:  0);
        }
        internal static byte[] AsBytes(ulong[] x)
        {
            byte[] val_1 = new byte[16];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(ns:  x, bs:  val_1, off:  0);
            return (System.Byte[])val_1;
        }
        internal static void AsBytes(ulong[] x, byte[] z)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(ns:  x, bs:  z, off:  0);
        }
        internal static uint[] AsUints(byte[] bs)
        {
            uint[] val_1 = new uint[4];
            Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  0, ns:  val_1);
            return (System.UInt32[])val_1;
        }
        internal static void AsUints(byte[] bs, uint[] output)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  0, ns:  output);
        }
        internal static ulong[] AsUlongs(byte[] x)
        {
            ulong[] val_1 = new ulong[2];
            Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(bs:  x, off:  0, ns:  val_1);
            return (System.UInt64[])val_1;
        }
        public static void AsUlongs(byte[] x, ulong[] z)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(bs:  x, off:  0, ns:  z);
        }
        internal static void Multiply(byte[] x, byte[] y)
        {
            System.UInt32[] val_1 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUints(bs:  x);
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(x:  val_1, y:  Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUints(bs:  y));
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns:  val_1, bs:  x, off:  0);
        }
        internal static void Multiply(uint[] x, uint[] y)
        {
            System.UInt32[] val_7;
            int val_8;
            var val_9;
            if(x == null)
            {
                    val_7 = y;
            }
            
            val_8 = x.Length;
            if(val_8 == 0)
            {
                    val_7 = y;
                val_8 = x.Length;
            }
            
            uint val_7 = x[0];
            if(val_8 <= 1)
            {
                    val_7 = y;
                val_8 = x.Length;
            }
            
            if(val_8 <= 2)
            {
                    val_7 = y;
                val_8 = x.Length;
            }
            
            if(val_8 <= 3)
            {
                    val_7 = y;
            }
            
            uint val_10 = x[1];
            var val_17 = 0;
            uint val_11 = 0;
            uint val_13 = 0;
            uint val_12 = 0;
            uint val_15 = 0;
            do
            {
                if(val_7 == 0)
            {
                    val_7 = y;
            }
            
                if(val_17 >= (y + 24))
            {
                    val_7 = y;
            }
            
                System.UInt32[] val_1 = val_7 + 0;
                var val_14 = (y + 0) + 32;
                var val_16 = 32;
                do
            {
                val_11 = (val_7 & (val_14 >> 31)) ^ val_11;
                val_12 = (x[1] & (val_14 >> 31)) ^ val_12;
                uint val_5 = val_10 << 31;
                val_13 = (x[0] & (val_14 >> 31)) ^ val_13;
                val_5 = 3774873600 & (val_5 >> 8);
                val_14 = val_14 << 1;
                val_15 = (val_10 & (val_14 >> 31)) ^ val_15;
                val_16 = val_16 - 1;
                val_7 = val_5 ^ (val_7 >> 1);
            }
            while(val_16 != 0);
            
                val_17 = val_17 + 1;
            }
            while(val_17 != 4);
            
            val_9 = mem[x + 24];
            val_9 = x + 24;
            if(val_9 == 0)
            {
                    val_9 = mem[x + 24];
                val_9 = x + 24;
            }
            
            mem2[0] = val_11;
            if(val_9 <= 1)
            {
                    val_9 = mem[x + 24];
                val_9 = x + 24;
            }
            
            mem2[0] = val_13;
            if(val_9 <= 2)
            {
                    val_9 = mem[x + 24];
                val_9 = x + 24;
            }
            
            mem2[0] = val_12;
            mem2[0] = val_15;
        }
        internal static void Multiply(ulong[] x, ulong[] y)
        {
            int val_5;
            int val_6;
            val_5 = x.Length;
            if(val_5 == 0)
            {
                    val_5 = x.Length;
            }
            
            ulong val_5 = x[0];
            ulong val_6 = x[1];
            var val_11 = 0;
            ulong val_8 = 0;
            ulong val_9 = 0;
            do
            {
                ulong val_7 = y[val_11];
                var val_10 = 64;
                do
            {
                val_8 = (val_5 & (val_7 >> 63)) ^ val_8;
                val_7 = val_7 << 1;
                val_9 = (val_6 & (val_7 >> 63)) ^ val_9;
                val_10 = val_10 - 1;
                val_5 = ((-2233785415175766016) & ((val_6 << 63) >> 8)) ^ (val_5 >> 1);
            }
            while(val_10 != 0);
            
                val_11 = val_11 + 1;
            }
            while(val_11 != 2);
            
            val_6 = x.Length;
            if(val_6 == 0)
            {
                    val_6 = x.Length;
            }
            
            x[0] = val_8;
            x[1] = val_9;
        }
        internal static void MultiplyP(uint[] x)
        {
            uint val_3 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ShiftRight(x:  x);
            val_3 = val_3 >> 8;
            uint val_4 = x[0];
            val_4 = val_4 ^ (val_3 & 3774873600);
            x[0] = val_4;
        }
        internal static void MultiplyP(uint[] x, uint[] z)
        {
            uint val_3 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ShiftRight(x:  x, z:  z);
            val_3 = val_3 >> 8;
            uint val_4 = z[0];
            val_4 = val_4 ^ (val_3 & 3774873600);
            z[0] = val_4;
        }
        internal static void MultiplyP8(uint[] x)
        {
            uint val_4 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ShiftRightN(x:  x, n:  8);
            val_4 = val_4 >> 24;
            System.UInt32[] val_2 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.LOOKUP + (((val_1 >> 24)) << 2);
            uint val_5 = (Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.LOOKUP + ((val_1 >> 24)) << 2) + 32;
            val_5 = val_5 ^ x[0];
            x[0] = val_5;
        }
        internal static void MultiplyP8(uint[] x, uint[] y)
        {
            uint val_4 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ShiftRightN(x:  x, n:  8, z:  y);
            val_4 = val_4 >> 24;
            System.UInt32[] val_2 = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.LOOKUP + (((val_1 >> 24)) << 2);
            uint val_5 = (Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.LOOKUP + ((val_1 >> 24)) << 2) + 32;
            val_5 = val_5 ^ y[0];
            y[0] = val_5;
        }
        internal static uint ShiftRight(uint[] x)
        {
            int val_4 = x.Length;
            if(val_4 == 0)
            {
                    val_4 = x.Length;
            }
            
            uint val_4 = x[0];
            if(val_4 == 0)
            {
                    val_4 = x.Length;
            }
            
            x[0] = val_4 >> 1;
            uint val_2 = val_4 << 31;
            if(val_4 <= 1)
            {
                    val_4 = x.Length;
            }
            
            uint val_5 = x[0];
            val_2 = val_2 | (val_5 >> 1);
            if(val_4 <= 1)
            {
                    val_4 = x.Length;
            }
            
            x[0] = val_2;
            uint val_3 = val_5 << 31;
            if(val_4 <= 2)
            {
                    val_4 = x.Length;
            }
            
            uint val_6 = x[1];
            val_3 = val_3 | (val_6 >> 1);
            if(val_4 <= 2)
            {
                    val_4 = x.Length;
            }
            
            val_6 = val_6 << 31;
            x[1] = val_3;
            if(val_4 <= 3)
            {
                    val_4 = x.Length;
            }
            
            uint val_7 = x[1];
            val_6 = val_6 | (val_7 >> 1);
            x[1] = val_6;
            x = val_7 << 31;
            return (uint)x;
        }
        internal static uint ShiftRight(uint[] x, uint[] z)
        {
            uint val_5 = x[0];
            z[0] = val_5 >> 1;
            uint val_2 = val_5 << 31;
            uint val_6 = x[0];
            val_2 = val_2 | (val_6 >> 1);
            z[0] = val_2;
            uint val_3 = val_6 << 31;
            uint val_7 = x[1];
            val_3 = val_3 | (val_7 >> 1);
            z[1] = val_3;
            val_7 = val_7 << 31;
            uint val_8 = x[1];
            val_7 = val_7 | (val_8 >> 1);
            z[1] = val_7;
            return (uint)val_8 << 31;
        }
        internal static uint ShiftRightN(uint[] x, int n)
        {
            int val_7;
            int val_8 = n;
            val_7 = x.Length;
            if(val_7 == 0)
            {
                    val_7 = x.Length;
            }
            
            uint val_7 = x[0];
            var val_9 = -val_8;
            val_8 = val_8 & 31;
            if(val_7 == 0)
            {
                    val_7 = x.Length;
            }
            
            val_9 = val_9 & 31;
            x[0] = val_7 >> val_8;
            uint val_2 = val_7 << val_9;
            if(val_7 <= 1)
            {
                    val_7 = x.Length;
            }
            
            uint val_10 = x[0];
            val_2 = (val_10 >> val_8) | val_2;
            if(val_7 <= 1)
            {
                    val_7 = x.Length;
            }
            
            x[0] = val_2;
            uint val_4 = val_10 << val_9;
            if(val_7 <= 2)
            {
                    val_7 = x.Length;
            }
            
            uint val_11 = x[1];
            val_4 = (val_11 >> val_8) | val_4;
            if(val_7 <= 2)
            {
                    val_7 = x.Length;
            }
            
            val_11 = val_11 << val_9;
            x[1] = val_4;
            if(val_7 <= 3)
            {
                    val_7 = x.Length;
            }
            
            uint val_12 = x[1];
            val_8 = (val_12 >> val_8) | val_11;
            x[1] = val_8;
            x = val_12 << val_9;
            return (uint)x;
        }
        internal static uint ShiftRightN(uint[] x, int n, uint[] z)
        {
            int val_9 = n;
            uint val_8 = x[0];
            var val_10 = -val_9;
            val_9 = val_9 & 31;
            z[0] = val_8 >> val_9;
            val_10 = val_10 & 31;
            uint val_2 = val_8 << val_10;
            uint val_11 = x[0];
            val_2 = (val_11 >> val_9) | val_2;
            z[0] = val_2;
            uint val_4 = val_11 << val_10;
            uint val_12 = x[1];
            val_4 = (val_12 >> val_9) | val_4;
            z[1] = val_4;
            val_12 = val_12 << val_10;
            uint val_13 = x[1];
            val_9 = (val_13 >> val_9) | val_12;
            z[1] = val_9;
            return (uint)val_13 << val_10;
        }
        internal static void Xor(byte[] x, byte[] y)
        {
            var val_7 = 0;
            do
            {
                mem2[0] = 1152921505721910208 ^ 1152921505721910208;
                var val_2 = val_7 + 1;
                val_2 = val_2 + 1;
                mem2[0] = 1152921505721910208 ^ W26;
                val_2 = val_2 + 1;
                mem2[0] = 1152921505721910208 ^ W26;
                val_7 = val_2 + 1;
                mem2[0] = 1152921505721910208 ^ W26;
            }
            while((val_2 - 3) < 12);
        
        }
        internal static void Xor(byte[] x, byte[] y, int yOff, int yLen)
        {
            int val_1 = yLen - 1;
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            var val_5 = (long)val_1;
            do
            {
                byte val_4 = y[(long)yOff + val_5];
                val_5 = val_5 - 1;
                val_4 = val_4 ^ x[val_5];
                x[val_5] = val_4;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        internal static void Xor(byte[] x, byte[] y, byte[] z)
        {
            var val_5 = 0;
            do
            {
                mem2[0] = 1152921505721910208 ^ 1152921505721910208;
                var val_2 = val_5 + 1;
                System.Byte[] val_3 = 1152921505721910208 ^ 1152921505721910208;
                mem2[0] = val_3;
                val_2 = val_2 + 1;
                val_3 = 1152921505721910208 ^ val_3;
                mem2[0] = val_3;
                val_2 = val_2 + 1;
                val_3 = 1152921505721910208 ^ val_3;
                mem2[0] = val_3;
                val_5 = val_2 + 1;
            }
            while((val_2 - 3) < 12);
        
        }
        internal static void Xor(uint[] x, uint[] y)
        {
            uint val_2 = y[0];
            val_2 = val_2 ^ x[0];
            x[0] = val_2;
            uint val_4 = y[0];
            val_4 = val_4 ^ x[0];
            x[0] = val_4;
            uint val_6 = y[1];
            val_6 = val_6 ^ x[1];
            x[1] = val_6;
            uint val_8 = y[1];
            val_8 = val_8 ^ x[1];
            x[1] = val_8;
        }
        internal static void Xor(uint[] x, uint[] y, uint[] z)
        {
            System.UInt32[] val_9 = y;
            uint val_1 = x[0];
            val_1 = val_9[0] ^ val_1;
            z[0] = val_1;
            uint val_3 = x[0];
            val_3 = val_9[0] ^ val_3;
            z[0] = val_3;
            uint val_5 = x[1];
            val_5 = val_9[1] ^ val_5;
            z[1] = val_5;
            val_9 = val_9[1] ^ x[1];
            z[1] = val_9;
        }
        internal static void Xor(ulong[] x, ulong[] y)
        {
            ulong val_2 = y[0];
            val_2 = val_2 ^ x[0];
            x[0] = val_2;
            ulong val_4 = y[1];
            val_4 = val_4 ^ x[1];
            x[1] = val_4;
        }
        internal static void Xor(ulong[] x, ulong[] y, ulong[] z)
        {
            System.UInt64[] val_5 = y;
            ulong val_1 = x[0];
            val_1 = val_5[0] ^ val_1;
            z[0] = val_1;
            val_5 = val_5[1] ^ x[1];
            z[1] = val_5;
        }
        protected GcmUtilities()
        {
        
        }
        private static GcmUtilities()
        {
            Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.LOOKUP = Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.GenerateLookup();
        }
    
    }

}
