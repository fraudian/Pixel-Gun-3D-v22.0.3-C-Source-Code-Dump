using UnityEngine;

namespace Org.BouncyCastle.Crypto.Utilities
{
    internal sealed class Pack
    {
        // Methods
        private Pack()
        {
        
        }
        internal static void UInt16_To_BE(ushort n, byte[] bs)
        {
            int val_2 = bs.Length;
            if(val_2 == 0)
            {
                    val_2 = bs.Length;
            }
            
            bs[0] = n >> 8;
            bs[0] = n;
        }
        internal static void UInt16_To_BE(ushort n, byte[] bs, int off)
        {
            bs[(long)off] = n >> 8;
            bs[(long)off + 1] = n;
        }
        internal static ushort BE_To_UInt16(byte[] bs)
        {
            int val_1 = bs.Length;
            if(val_1 == 0)
            {
                    val_1 = bs.Length;
            }
            
            byte val_1 = bs[0];
            return (ushort)bs[0];
        }
        internal static ushort BE_To_UInt16(byte[] bs, int off)
        {
            int val_2 = bs.Length;
            if(val_2 <= off)
            {
                    val_2 = bs.Length;
            }
            
            byte val_2 = bs[(long)off];
            return (ushort)bs[(long)off + 1];
        }
        internal static byte[] UInt32_To_BE(uint n)
        {
            byte[] val_1 = new byte[4];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n, bs:  val_1, off:  0);
            return (System.Byte[])val_1;
        }
        internal static void UInt32_To_BE(uint n, byte[] bs)
        {
            int val_4 = bs.Length;
            if(val_4 == 0)
            {
                    val_4 = bs.Length;
            }
            
            bs[0] = n >> 24;
            if(val_4 <= 1)
            {
                    val_4 = bs.Length;
            }
            
            bs[0] = n >> 16;
            if(val_4 <= 2)
            {
                    val_4 = bs.Length;
            }
            
            bs[0] = n >> 8;
            bs[0] = n;
        }
        internal static void UInt32_To_BE(uint n, byte[] bs, int off)
        {
            bs[(long)off] = n >> 24;
            bs[(long)off + 1] = n >> 16;
            bs[(long)off + 2] = n >> 8;
            bs[(long)off + 3] = n;
        }
        internal static byte[] UInt32_To_BE(uint[] ns)
        {
            byte[] val_1 = new byte[0];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns:  ns, bs:  val_1, off:  0);
            return (System.Byte[])val_1;
        }
        internal static void UInt32_To_BE(uint[] ns, byte[] bs, int off)
        {
            int val_1;
            var val_2;
            val_1 = off;
            val_2 = 0;
            goto label_0;
            label_3:
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  ns[0], bs:  bs, off:  val_1);
            val_1 = val_1 + 4;
            val_2 = 1;
            label_0:
            if(val_2 < ns.Length)
            {
                goto label_3;
            }
        
        }
        internal static uint BE_To_UInt32(byte[] bs)
        {
            int val_2 = bs.Length;
            if(val_2 == 0)
            {
                    val_2 = bs.Length;
            }
            
            if(val_2 <= 1)
            {
                    val_2 = bs.Length;
            }
            
            byte val_3 = bs[0];
            if(val_2 <= 2)
            {
                    val_2 = bs.Length;
            }
            
            byte val_4 = bs[0];
            bs = (bs[0] << 24) | bs[0];
            return (uint)bs;
        }
        internal static uint BE_To_UInt32(byte[] bs, int off)
        {
            int val_5 = bs.Length;
            if(val_5 <= off)
            {
                    val_5 = bs.Length;
            }
            
            int val_1 = off + 1;
            if(val_1 >= val_5)
            {
                    val_5 = bs.Length;
            }
            
            byte val_6 = bs[(long)val_1];
            int val_2 = off + 2;
            if(val_2 >= val_5)
            {
                    val_5 = bs.Length;
            }
            
            byte val_7 = bs[(long)val_2];
            bs = (bs[(long)off] << 24) | (bs[(long)off + 3]);
            return (uint)bs;
        }
        internal static void BE_To_UInt32(byte[] bs, int off, uint[] ns)
        {
            var val_2;
            int val_2 = off;
            val_2 = 0;
            goto label_0;
            label_3:
            val_2 = val_2 + 4;
            val_2 = 1;
            ns[0] = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  val_2);
            label_0:
            if(val_2 < ns.Length)
            {
                goto label_3;
            }
        
        }
        internal static byte[] UInt64_To_BE(ulong n)
        {
            byte[] val_1 = new byte[8];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n >> 32, bs:  val_1, off:  0);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n, bs:  val_1, off:  4);
            return (System.Byte[])val_1;
        }
        internal static void UInt64_To_BE(ulong n, byte[] bs)
        {
            n = n >> 32;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n, bs:  bs);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n, bs:  bs, off:  4);
        }
        internal static void UInt64_To_BE(ulong n, byte[] bs, int off)
        {
            n = n >> 32;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n, bs:  bs, off:  off);
            off = off + 4;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  n, bs:  bs, off:  off);
        }
        internal static byte[] UInt64_To_BE(ulong[] ns)
        {
            byte[] val_1 = new byte[0];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(ns:  ns, bs:  val_1, off:  0);
            return (System.Byte[])val_1;
        }
        internal static void UInt64_To_BE(ulong[] ns, byte[] bs, int off)
        {
            int val_2;
            var val_3;
            val_2 = off;
            val_3 = 0;
            goto label_0;
            label_3:
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  ns[0], bs:  bs, off:  val_2);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  ns[0], bs:  bs, off:  val_2 + 4);
            val_3 = 1;
            val_2 = val_2 + 8;
            label_0:
            if(val_3 < ns.Length)
            {
                goto label_3;
            }
        
        }
        internal static ulong BE_To_UInt64(byte[] bs)
        {
            uint val_1 = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs);
            return (ulong)Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  4);
        }
        internal static ulong BE_To_UInt64(byte[] bs, int off)
        {
            uint val_1 = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  off);
            off = off + 4;
            return (ulong)Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  off);
        }
        internal static void BE_To_UInt64(byte[] bs, int off, ulong[] ns)
        {
            int val_3;
            var val_4;
            val_3 = off;
            val_4 = 0;
            goto label_0;
            label_3:
            uint val_1 = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  val_3);
            val_3 = val_3 + 4;
            val_4 = 1;
            val_3 = val_3 + 4;
            ns[0] = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  bs, off:  val_3);
            label_0:
            if(val_4 < ns.Length)
            {
                goto label_3;
            }
        
        }
        internal static void UInt16_To_LE(ushort n, byte[] bs)
        {
            int val_2 = bs.Length;
            if(val_2 == 0)
            {
                    val_2 = bs.Length;
            }
            
            bs[0] = n;
            bs[0] = n >> 8;
        }
        internal static void UInt16_To_LE(ushort n, byte[] bs, int off)
        {
            bs[(long)off] = n;
            bs[(long)off + 1] = n >> 8;
        }
        internal static ushort LE_To_UInt16(byte[] bs)
        {
            int val_1 = bs.Length;
            if(val_1 == 0)
            {
                    val_1 = bs.Length;
            }
            
            byte val_2 = bs[0];
            return (ushort)bs[0];
        }
        internal static ushort LE_To_UInt16(byte[] bs, int off)
        {
            int val_2 = bs.Length;
            if(val_2 <= off)
            {
                    val_2 = bs.Length;
            }
            
            byte val_3 = bs[(long)off + 1];
            return (ushort)bs[(long)off];
        }
        internal static byte[] UInt32_To_LE(uint n)
        {
            byte[] val_1 = new byte[4];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n, bs:  val_1, off:  0);
            return (System.Byte[])val_1;
        }
        internal static void UInt32_To_LE(uint n, byte[] bs)
        {
            int val_4 = bs.Length;
            if(val_4 == 0)
            {
                    val_4 = bs.Length;
            }
            
            bs[0] = n;
            if(val_4 <= 1)
            {
                    val_4 = bs.Length;
            }
            
            bs[0] = n >> 8;
            if(val_4 <= 2)
            {
                    val_4 = bs.Length;
            }
            
            bs[0] = n >> 16;
            bs[0] = n >> 24;
        }
        internal static void UInt32_To_LE(uint n, byte[] bs, int off)
        {
            bs[(long)off] = n;
            bs[(long)off + 1] = n >> 8;
            bs[(long)off + 2] = n >> 16;
            bs[(long)off + 3] = n >> 24;
        }
        internal static byte[] UInt32_To_LE(uint[] ns)
        {
            byte[] val_1 = new byte[0];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns:  ns, bs:  val_1, off:  0);
            return (System.Byte[])val_1;
        }
        internal static void UInt32_To_LE(uint[] ns, byte[] bs, int off)
        {
            int val_1;
            var val_2;
            val_1 = off;
            val_2 = 0;
            goto label_0;
            label_3:
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  ns[0], bs:  bs, off:  val_1);
            val_1 = val_1 + 4;
            val_2 = 1;
            label_0:
            if(val_2 < ns.Length)
            {
                goto label_3;
            }
        
        }
        internal static uint LE_To_UInt32(byte[] bs)
        {
            int val_1 = bs.Length;
            if(val_1 == 0)
            {
                    val_1 = bs.Length;
            }
            
            if(val_1 <= 1)
            {
                    val_1 = bs.Length;
            }
            
            byte val_2 = bs[0];
            if(val_1 <= 2)
            {
                    val_1 = bs.Length;
            }
            
            byte val_3 = bs[0];
            byte val_4 = bs[0];
            return (uint)bs[0];
        }
        internal static uint LE_To_UInt32(byte[] bs, int off)
        {
            int val_4 = bs.Length;
            if(val_4 <= off)
            {
                    val_4 = bs.Length;
            }
            
            int val_1 = off + 1;
            if(val_1 >= val_4)
            {
                    val_4 = bs.Length;
            }
            
            byte val_5 = bs[(long)val_1];
            int val_2 = off + 2;
            if(val_2 >= val_4)
            {
                    val_4 = bs.Length;
            }
            
            byte val_6 = bs[(long)val_2];
            byte val_7 = bs[(long)off + 3];
            return (uint)bs[(long)off];
        }
        internal static void LE_To_UInt32(byte[] bs, int off, uint[] ns)
        {
            var val_2;
            int val_2 = off;
            val_2 = 0;
            goto label_0;
            label_3:
            val_2 = val_2 + 4;
            val_2 = 1;
            ns[0] = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs, off:  val_2);
            label_0:
            if(val_2 < ns.Length)
            {
                goto label_3;
            }
        
        }
        internal static void LE_To_UInt32(byte[] bs, int bOff, uint[] ns, int nOff, int count)
        {
            var val_2;
            int val_3;
            val_2 = nOff;
            val_3 = bOff;
            if(count < 1)
            {
                    return;
            }
            
            int val_2 = count;
            do
            {
                val_3 = val_3 + 4;
                val_2 = val_2 - 1;
                val_2 = val_2 + 1;
                ns[((long)(int)(nOff)) << 2] = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs, off:  val_3);
            }
            while(val_2 != 0);
        
        }
        internal static uint[] LE_To_UInt32(byte[] bs, int off, int count)
        {
            int val_3;
            var val_4;
            val_3 = off;
            uint[] val_1 = new uint[0];
            val_4 = 0;
            goto label_1;
            label_4:
            val_3 = val_3 + 4;
            val_4 = 1;
            val_1[0] = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs, off:  val_3);
            label_1:
            if(val_4 < val_1.Length)
            {
                goto label_4;
            }
            
            return (System.UInt32[])val_1;
        }
        internal static byte[] UInt64_To_LE(ulong n)
        {
            byte[] val_1 = new byte[8];
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n, bs:  val_1, off:  0);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n >> 32, bs:  val_1, off:  4);
            return (System.Byte[])val_1;
        }
        internal static void UInt64_To_LE(ulong n, byte[] bs)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n, bs:  bs);
            n = n >> 32;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n, bs:  bs, off:  4);
        }
        internal static void UInt64_To_LE(ulong n, byte[] bs, int off)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n, bs:  bs, off:  off);
            off = off + 4;
            n = n >> 32;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  n, bs:  bs, off:  off);
        }
        internal static ulong LE_To_UInt64(byte[] bs)
        {
            uint val_2 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs, off:  4);
            return (ulong)Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs);
        }
        internal static ulong LE_To_UInt64(byte[] bs, int off)
        {
            off = off + 4;
            uint val_2 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs, off:  off);
            return (ulong)Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bs, off:  off);
        }
    
    }

}
