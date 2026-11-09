using UnityEngine;

namespace Org.BouncyCastle.Math.Raw
{
    internal abstract class Interleave
    {
        // Fields
        private const ulong M32 = 1431655765;
        private const ulong M64 = 6148914691236517205;
        
        // Methods
        internal static uint Expand8to16(uint x)
        {
            uint val_1 = x & 255;
            val_1 = val_1 | (val_1 << 4);
            val_1 = val_1 & 3855;
            val_1 = val_1 | (val_1 << 2);
            val_1 = val_1 & 13107;
            val_1 = val_1 | (val_1 << 1);
            x = val_1 & 21845;
            return (uint)x;
        }
        internal static uint Expand16to32(uint x)
        {
            uint val_1 = x & 65535;
            val_1 = val_1 | (val_1 << 8);
            val_1 = val_1 & 16711935;
            val_1 = val_1 | (val_1 << 4);
            val_1 = val_1 & 252645135;
            val_1 = val_1 | (val_1 << 2);
            val_1 = val_1 & 858993459;
            val_1 = val_1 | (val_1 << 1);
            x = val_1 & 1431655765;
            return (uint)x;
        }
        internal static ulong Expand32to64(uint x)
        {
            var val_1 = 0;
            val_1 = val_1 ^ x;
            val_1 = 0 ^ val_1;
            val_1 = 0 ^ val_1;
            var val_2 = 0;
            val_1 = val_2 ^ val_1;
            val_2 = val_1 >> 1;
            val_2 = val_2 & 1431655765;
            val_1 = val_1 & 1431655765;
            x = val_1 | (((((0 ^ (0 ^ (0 ^ (0 ^ x)))) >> 1) & 1431655765)) << 32);
            return (ulong)x;
        }
        internal static void Expand64To128(ulong x, ulong[] z, int zOff)
        {
            ulong val_1 = x >> 16;
            val_1 = val_1 ^ x;
            val_1 = val_1 & 4294901760;
            ulong val_2 = val_1 >> 16;
            val_1 = val_1 ^ x;
            val_1 = 0 ^ val_1;
            val_1 = 0 ^ val_1;
            val_1 = 0 ^ val_1;
            ulong val_3 = 0 ^ val_1;
            z[(long)zOff] = val_3 & 6148914691236517205;
            val_3 = (val_3 >> 1) & 6148914691236517205;
            z[(long)zOff + 1] = val_3;
        }
        internal static ulong Unshuffle(ulong x)
        {
            var val_2 = 0;
            val_2 = val_2 ^ x;
            val_2 = 0 ^ val_2;
            val_2 = 0 ^ val_2;
            var val_3 = 0;
            val_2 = val_3 ^ val_2;
            val_3 = val_2 >> 16;
            val_3 = val_3 ^ val_2;
            val_3 = val_3 & 4294901760;
            ulong val_1 = val_3 >> 16;
            x = val_3 ^ val_2;
            return (ulong)x;
        }
        protected Interleave()
        {
        
        }
    
    }

}
