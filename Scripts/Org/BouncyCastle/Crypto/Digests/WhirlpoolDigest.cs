using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public sealed class WhirlpoolDigest : IDigest, IMemoable
    {
        // Fields
        private const int BYTE_LENGTH = 64;
        private const int DIGEST_LENGTH_BYTES = 64;
        private const int ROUNDS = 10;
        private const int REDUCTION_POLYNOMIAL = 285;
        private static readonly int[] SBOX;
        private static readonly long[] C0;
        private static readonly long[] C1;
        private static readonly long[] C2;
        private static readonly long[] C3;
        private static readonly long[] C4;
        private static readonly long[] C5;
        private static readonly long[] C6;
        private static readonly long[] C7;
        private readonly long[] _rc;
        private static readonly short[] EIGHT;
        private const int BITCOUNT_ARRAY_SIZE = 32;
        private byte[] _buffer;
        private int _bufferPos;
        private short[] _bitCount;
        private long[] _hash;
        private long[] _K;
        private long[] _L;
        private long[] _block;
        private long[] _state;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        private static WhirlpoolDigest()
        {
            var val_47;
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.BITCOUNT_ARRAY_SIZE = new int[256] {24, 35, 198, 232, 135, 184, 1, 79, 54, 166, 210, 245, 121, 111, 145, 82, 96, 188, 155, 142, 163, 12, 123, 53, 29, 224, 215, 194, 46, 75, 254, 87, 21, 119, 55, 229, 159, 240, 74, 218, 88, 201, 41, 10, 177, 160, 107, 133, 189, 93, 16, 244, 203, 62, 5, 103, 228, 39, 65, 139, 167, 125, 149, 216, 251, 238, 124, 102, 221, 23, 71, 158, 202, 45, 191, 7, 173, 90, 131, 51, 99, 2, 170, 113, 200, 25, 73, 217, 242, 227, 91, 136, 154, 38, 50, 176, 233, 15, 213, 128, 190, 205, 52, 72, 255, 122, 144, 95, 32, 104, 26, 174, 180, 84, 147, 34, 100, 241, 115, 18, 64, 8, 195, 236, 219, 161, 141, 61, 151, 0, 207, 43, 118, 130, 214, 27, 181, 175, 106, 80, 69, 243, 48, 239, 63, 85, 162, 234, 101, 186, 47, 192, 222, 28, 253, 77, 146, 117, 6, 138, 178, 230, 14, 31, 98, 212, 168, 150, 249, 197, 37, 89, 132, 114, 57, 76, 94, 120, 56, 140, 209, 165, 226, 97, 179, 33, 156, 30, 67, 199, 252, 4, 81, 153, 109, 13, 250, 223, 126, 36, 59, 171, 206, 17, 143, 78, 183, 235, 60, 129, 148, 247, 185, 19, 44, 211, 231, 110, 196, 3, 86, 68, 127, 169, 42, 187, 193, 83, 220, 11, 157, 108, 49, 116, 246, 70, 172, 137, 20, 225, 22, 58, 105, 9, 112, 182, 208, 237, 204, 66, 152, 164, 40, 92, 248, 134};
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7 = new long[256];
            Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.EIGHT = new short[32];
            var val_55 = 0;
            mem[1152921553379114254] = 8;
            do
            {
                System.Int32[] val_11 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.BITCOUNT_ARRAY_SIZE;
                var val_52 = (val_1 + 0) + 32;
                var val_12 = val_52 << 1;
                var val_14 = val_52 << 48;
                val_14 = val_14 ^ (((val_1 + 0) + 32) << 56);
                var val_15 = (val_12 > 255) ? (285 ^ (val_52 << 1)) : (val_12);
                var val_17 = val_15 << 1;
                var val_50 = (long)val_15;
                var val_19 = (val_17 > 255) ? (285 ^ (val_15 << 1)) : (val_17);
                var val_20 = (val_14 ^ (((val_1 + 0) + 32) << 32)) ^ (((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1))) << 8);
                var val_21 = val_19 << 1;
                val_15 = val_19 ^ val_52;
                val_17 = 285 ^ (val_19 << 1);
                val_20 = val_20 ^ ((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) << 40);
                var val_22 = (val_21 > 255) ? (val_17) : (val_21);
                val_20 = val_20 ^ (((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) ^ (val_1 + )) << 16);
                val_21 = val_22 ^ val_52;
                var val_51 = (long)val_22;
                var val_23 = val_20 ^ (((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) <<  : (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 1))) << 24);
                val_23 = val_23 ^ (long)val_21;
                mem2[0] = val_23;
                var val_48 = val_14;
                val_47 = (long)val_21 & 4294967295;
                val_48 = val_48 ^ (((val_1 + 0) + 32) << 40);
                var val_24 = val_48 ^ (((long)(int)((val_1 + 0) + 32)) << 24);
                val_24 = val_24 ^ val_50;
                val_24 = val_24 ^ ((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) << 32);
                val_24 = val_24 ^ (((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) ^ (val_1 + )) << 8);
                var val_25 = val_24 ^ (((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) <<  : (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 1))) << 16);
                if(Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1 == null)
            {
                    val_47 = val_47;
            }
            
                var val_26 = val_52 << 32;
                var val_27 = val_52 << 40;
                val_25 = val_25 ^ ((((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((va) << 56);
                if(val_55 >= mem[1152921553379071176])
            {
                    val_47 = val_47;
            }
            
                mem2[0] = val_25;
                var val_49 = val_27;
                val_49 = val_26 ^ val_49;
                val_50 = val_50 & 4294967295;
                var val_28 = val_49 ^ (((long)(int)((val_1 + 0) + 32)) << 16);
                val_28 = val_28 ^ ((((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) & 4294967295)) << 56);
                val_28 = val_28 ^ (((long)(int)(val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1))) << 24);
                val_28 = val_28 ^ (long)val_15;
                if(Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2 == null)
            {
                    val_47 = val_47;
            }
            
                var val_30 = (long)val_52 << 24;
                if(val_55 >= mem[1152921553379077320])
            {
                    val_47 = val_47;
            }
            
                mem2[0] = (val_28 ^ (((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) <<  : (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 1))) << 8)) ^ ((((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((va) << 48);
                var val_32 = (long)val_15 & 4294967295;
                var val_34 = val_30 ^ val_26 ^ (((long)(int)((val_1 + 0) + 32)) << 8);
                val_34 = val_34 ^ ((((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) & 4294967295)) << 48);
                val_34 = val_34 ^ (((long)(int)(val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1))) << 16);
                val_34 = val_34 ^ ((((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 56);
                var val_35 = val_34 ^ val_51;
                if(Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3 == null)
            {
                    val_47 = val_47;
            }
            
                var val_36 = (long)val_52 << 16;
                val_35 = val_35 ^ ((((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((va) << 40);
                if(val_55 >= mem[1152921553379083464])
            {
                    val_47 = val_47;
            }
            
                mem2[0] = val_35;
                val_51 = val_51 & 4294967295;
                var val_38 = val_30 ^ (long)val_52 ^ val_36;
                val_38 = val_38 ^ ((((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) & 4294967295)) << 40);
                val_38 = val_38 ^ (((long)(int)(val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1))) << 8);
                val_38 = val_38 ^ ((((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 48);
                var val_39 = val_38 ^ ((((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val) << 56);
                if(Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4 == null)
            {
                    val_47 = val_47;
            }
            
                val_52 = val_52 << 56;
                var val_40 = (long)val_52 << 8;
                val_39 = val_39 ^ ((((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((va) << 32);
                mem2[0] = val_39;
                var val_42 = val_36 ^ val_52 ^ val_40;
                val_42 = val_42 ^ ((((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) & 4294967295)) << 32);
                val_42 = val_42 ^ (long)val_19;
                val_42 = val_42 ^ ((((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 40);
                var val_43 = val_42 ^ ((((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val) << 48);
                val_43 = val_43 ^ (((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32)) << 24);
                mem2[0] = val_43;
                var val_53 = val_14;
                val_53 = val_53 ^ (long)val_52;
                var val_44 = val_53 ^ val_40;
                val_44 = val_44 ^ (((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1))) << 24);
                val_44 = val_44 ^ ((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) << 56);
                val_44 = val_44 ^ ((((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) << 32);
                var val_45 = val_44 ^ ((((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val) << 40);
                val_45 = val_45 ^ (((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32)) << 16);
                mem2[0] = val_45;
                var val_54 = val_27;
                val_54 = val_52 ^ (long)val_52 ^ val_54;
                val_54 = val_54 ^ (((long)(int)(val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1))) << 16);
                val_54 = val_54 ^ ((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1)) << 48);
                val_54 = val_54 ^ (((long)(int)((val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1) << 1) ^ (val_1 + )) << 24);
                var val_47 = val_54 ^ ((((long)(int)(val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val) << 32);
                val_47 = val_47 ^ (((long)(int)((val_21 > 0xFF ? (285 ^ (val_17 > 0xFF ? (285 ^ (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32 << 1)) << 1) : (val_12 > 0xFF ? (285 ^ ((val_1 + 0) + 32) << 1) : ((val_1 + 0) + 32)) << 8);
                val_55 = val_55 + 1;
                mem2[0] = val_47;
            }
            while(val_55 != 256);
        
        }
        public WhirlpoolDigest()
        {
            var val_10;
            this._rc = new long[11];
            this._buffer = new byte[64];
            this._bitCount = new short[32];
            this._hash = new long[8];
            this._K = new long[8];
            this._L = new long[8];
            this._block = new long[8];
            this._state = new long[8];
            this._rc[0] = 0;
            var val_24 = 0;
            var val_25 = 1;
            do
            {
                val_10 = null;
                val_10 = null;
                var val_9 = val_24 + 1;
                var val_10 = val_24 + 2;
                var val_11 = val_24 + 3;
                var val_12 = val_24 + 4;
                var val_13 = val_24 + 5;
                long val_23 = (0 + 5) + 72;
                var val_14 = val_24 + 6;
                var val_15 = val_24 + 7;
                var val_22 = (0 + 1) + 40;
                var val_21 = X9 + 32;
                val_21 = val_21 & (-72057594037927936);
                val_22 = val_22 & 71776119061217280;
                val_21 = val_22 | val_21;
                val_21 = val_21 | (((0 + 2) + 48) & 280375465082880);
                val_21 = val_21 | (((0 + 3) + 56) & 1095216660480);
                val_21 = val_21 | (((0 + 4) + 64) & 4278190080);
                val_21 = val_21 | (val_23 & 16711680);
                val_21 = (((0 + 6) + 80) & 65280) ^ val_21;
                val_23 = val_21 ^ (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7.Length + 88);
                this._rc[val_24] = val_23;
                val_24 = val_24 + 8;
                val_25 = val_25 + 1;
            }
            while(val_24 != 80);
        
        }
        private static long packIntoLong(int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0)
        {
            int val_1 = b6 << 48;
            val_1 = val_1 ^ ((b7) << 56);
            val_1 = val_1 ^ ((b5) << 40);
            val_1 = val_1 ^ ((b4) << 32);
            val_1 = val_1 ^ (((long)(int)(b3)) << 24);
            val_1 = val_1 ^ (((long)(int)(b2)) << 16);
            val_1 = val_1 ^ (((long)(int)(b1)) << 8);
            return (long)val_1 ^ (long)b0;
        }
        private static int maskWithReductionPolynomial(int input)
        {
            input = (input > 255) ? (input ^ 285) : input;
            return (int)input;
        }
        public WhirlpoolDigest(Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest originalDigest)
        {
            this._rc = new long[11];
            this._buffer = new byte[64];
            this._bitCount = new short[32];
            this._hash = new long[8];
            this._K = new long[8];
            this._L = new long[8];
            this._block = new long[8];
            this._state = new long[8];
            this.Reset(other:  originalDigest);
        }
        public string get_AlgorithmName()
        {
            return "Whirlpool";
        }
        public int GetDigestSize()
        {
            return 64;
        }
        public int DoFinal(byte[] output, int outOff)
        {
            int val_3 = outOff;
            this.finish();
            var val_2 = 0;
            do
            {
                Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.convertLongToByteArray(inputLong:  this._hash[val_2], outputArray:  output, offSet:  val_3);
                val_2 = val_2 + 1;
                val_3 = val_3 + 8;
            }
            while(val_2 != 8);
            
            this.Reset();
            return 64;
        }
        public void Reset()
        {
            this._bufferPos = 0;
            System.Array.Clear(array:  this._bitCount, index:  0, length:  this._bitCount.Length);
            System.Array.Clear(array:  this._buffer, index:  0, length:  this._buffer.Length);
            System.Array.Clear(array:  this._hash, index:  0, length:  this._hash.Length);
            System.Array.Clear(array:  this._K, index:  0, length:  this._K.Length);
            System.Array.Clear(array:  this._L, index:  0, length:  this._L.Length);
            System.Array.Clear(array:  this._block, index:  0, length:  this._block.Length);
            System.Array.Clear(array:  this._state, index:  0, length:  this._state.Length);
        }
        private void processFilledBuffer()
        {
            goto label_1;
            label_7:
            0 = 1;
            this._block[0] = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.bytesToLongFromBuffer(buffer:  this._buffer, startPos:  0);
            label_1:
            if(0 < this._state.Length)
            {
                goto label_7;
            }
            
            this.processBlock();
            this._bufferPos = 0;
            System.Array.Clear(array:  this._buffer, index:  0, length:  this._buffer.Length);
        }
        private static long bytesToLongFromBuffer(byte[] buffer, int startPos)
        {
            int val_9 = buffer.Length;
            if(val_9 <= startPos)
            {
                    val_9 = buffer.Length;
            }
            
            int val_1 = startPos + 1;
            if(val_1 >= val_9)
            {
                    val_9 = buffer.Length;
            }
            
            byte val_10 = buffer[(long)val_1];
            int val_2 = startPos + 2;
            if(val_2 >= val_9)
            {
                    val_9 = buffer.Length;
            }
            
            byte val_11 = buffer[(long)val_2];
            int val_3 = startPos + 3;
            if(val_3 >= val_9)
            {
                    val_9 = buffer.Length;
            }
            
            byte val_12 = buffer[(long)val_3];
            int val_4 = startPos + 4;
            if(val_4 >= val_9)
            {
                    val_9 = buffer.Length;
            }
            
            byte val_13 = buffer[(long)val_4];
            int val_5 = startPos + 5;
            if(val_5 >= val_9)
            {
                    val_9 = buffer.Length;
            }
            
            byte val_14 = buffer[(long)val_5];
            int val_6 = startPos + 6;
            if(val_6 >= val_9)
            {
                    val_9 = buffer.Length;
            }
            
            byte val_15 = buffer[(long)val_6];
            buffer = (buffer[(long)startPos] << 56) | (buffer[(long)startPos + 7]);
            return (long)buffer;
        }
        private static void convertLongToByteArray(long inputLong, byte[] outputArray, int offSet)
        {
            int val_4 = offSet;
            var val_3 = 56;
            do
            {
                val_3 = val_3 - 8;
                val_4 = val_4 + 1;
                outputArray[(long)val_4] = inputLong >> (val_3 & 56);
            }
            while(val_3 != 8);
        
        }
        private void processBlock()
        {
            var val_19;
            var val_20;
            var val_49 = 4;
            do
            {
                var val_1 = val_49 - 4;
                long val_48 = this._hash[0];
                this._K[0] = val_48;
                this._state[0] = val_48 ^ this._block[0];
                val_49 = val_49 + 1;
            }
            while(val_49 != 12);
            
            var val_103 = 1;
            do
            {
                var val_72 = 0;
                do
            {
                this._L[val_72] = 0;
                val_19 = null;
                val_19 = null;
                long val_51 = this._K[val_72];
                val_51 = val_51 >> 56;
                System.Int64[] val_3 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0 + (((this._K[0x0][0] >> 56)) << 3);
                long val_52 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0 + ((this._K[0x0][0] >> 56)) << 3) + 32;
                val_52 = val_52 ^ this._L[val_72];
                this._L[val_72] = val_52;
                long val_54 = this._K[(val_72 + 7) & 7];
                System.Int64[] val_6 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1 + (((ulong)((this._K[((0 + 7) & 7)][0]>>48) & 0xFF)) << 3);
                long val_55 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1 + ((ulong)((this._K[((0 + 7) & 7)][0]>>48) & 0xFF)) << 3) + 32;
                val_55 = val_55 ^ this._L[val_72];
                this._L[val_72] = val_55;
                long val_57 = this._K[(val_72 + 6) & 7];
                System.Int64[] val_9 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2 + (((ulong)((this._K[((0 + 6) & 7)][0]>>40) & 0xFF)) << 3);
                long val_58 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2 + ((ulong)((this._K[((0 + 6) & 7)][0]>>40) & 0xFF)) << 3) + 32;
                val_58 = val_58 ^ this._L[val_72];
                this._L[val_72] = val_58;
                long val_60 = this._K[(val_72 + 5) & 7];
                System.Int64[] val_12 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3 + (((ulong)((this._K[((0 + 5) & 7)][0]>>32) & 0xFF)) << 3);
                long val_61 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3 + ((ulong)((this._K[((0 + 5) & 7)][0]>>32) & 0xFF)) << 3) + 32;
                val_61 = val_61 ^ this._L[val_72];
                this._L[val_72] = val_61;
                long val_63 = this._K[(val_72 + 4) & 7];
                System.Int64[] val_15 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4 + (((ulong)((this._K[((0 + 4) & 7)][0]>>24) & 0xFF)) << 3);
                long val_64 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4 + ((ulong)((this._K[((0 + 4) & 7)][0]>>24) & 0xFF)) << 3) + 32;
                val_64 = val_64 ^ this._L[val_72];
                this._L[val_72] = val_64;
                long val_66 = this._K[(val_72 + 3) & 7];
                System.Int64[] val_18 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5 + (((ulong)((this._K[((0 + 3) & 7)][0]>>16) & 0xFF)) << 3);
                long val_67 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5 + ((ulong)((this._K[((0 + 3) & 7)][0]>>16) & 0xFF)) << 3) + 32;
                val_67 = val_67 ^ this._L[val_72];
                this._L[val_72] = val_67;
                long val_69 = this._K[(val_72 + 2) & 7];
                System.Int64[] val_21 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6 + (((ulong)((this._K[((0 + 2) & 7)][0]>>8) & 0xFF)) << 3);
                long val_70 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6 + ((ulong)((this._K[((0 + 2) & 7)][0]>>8) & 0xFF)) << 3) + 32;
                val_70 = val_70 ^ this._L[val_72];
                this._L[val_72] = val_70;
                val_72 = val_72 + 1;
                long val_73 = this._K[val_72 & 7];
                System.Int64[] val_23 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7 + ((this._K[((0 + 1) & 7)][0]) << 3);
                long val_74 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7 + (this._K[((0 + 1) & 7)][0]) << 3) + 32;
                val_74 = val_74 ^ this._L[val_72];
                this._L[val_72] = val_74;
            }
            while(val_72 != 8);
            
                System.Array.Copy(sourceArray:  this._L, sourceIndex:  0, destinationArray:  this._K, destinationIndex:  0, length:  this._K.Length);
                long val_76 = this._rc[val_103];
                val_76 = val_76 ^ this._K[0];
                this._K[0] = val_76;
                var val_100 = 0;
                do
            {
                this._L[val_100] = this._K[val_100];
                val_20 = null;
                val_20 = null;
                long val_79 = this._state[val_100];
                val_79 = val_79 >> 56;
                System.Int64[] val_24 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0 + (((this._state[0x0][0] >> 56)) << 3);
                long val_80 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0 + ((this._state[0x0][0] >> 56)) << 3) + 32;
                val_80 = val_80 ^ this._L[val_100];
                this._L[val_100] = val_80;
                long val_82 = this._state[(val_100 + 7) & 7];
                System.Int64[] val_27 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1 + (((ulong)((this._state[((0 + 7) & 7)][0]>>48) & 0xFF)) << 3);
                long val_83 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1 + ((ulong)((this._state[((0 + 7) & 7)][0]>>48) & 0xFF)) << 3) + 32;
                val_83 = val_83 ^ this._L[val_100];
                this._L[val_100] = val_83;
                long val_85 = this._state[(val_100 + 6) & 7];
                System.Int64[] val_30 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2 + (((ulong)((this._state[((0 + 6) & 7)][0]>>40) & 0xFF)) << 3);
                long val_86 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2 + ((ulong)((this._state[((0 + 6) & 7)][0]>>40) & 0xFF)) << 3) + 32;
                val_86 = val_86 ^ this._L[val_100];
                this._L[val_100] = val_86;
                long val_88 = this._state[(val_100 + 5) & 7];
                System.Int64[] val_33 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3 + (((ulong)((this._state[((0 + 5) & 7)][0]>>32) & 0xFF)) << 3);
                long val_89 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3 + ((ulong)((this._state[((0 + 5) & 7)][0]>>32) & 0xFF)) << 3) + 32;
                val_89 = val_89 ^ this._L[val_100];
                this._L[val_100] = val_89;
                long val_91 = this._state[(val_100 + 4) & 7];
                System.Int64[] val_36 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4 + (((ulong)((this._state[((0 + 4) & 7)][0]>>24) & 0xFF)) << 3);
                long val_92 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4 + ((ulong)((this._state[((0 + 4) & 7)][0]>>24) & 0xFF)) << 3) + 32;
                val_92 = val_92 ^ this._L[val_100];
                this._L[val_100] = val_92;
                long val_94 = this._state[(val_100 + 3) & 7];
                System.Int64[] val_39 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5 + (((ulong)((this._state[((0 + 3) & 7)][0]>>16) & 0xFF)) << 3);
                long val_95 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5 + ((ulong)((this._state[((0 + 3) & 7)][0]>>16) & 0xFF)) << 3) + 32;
                val_95 = val_95 ^ this._L[val_100];
                this._L[val_100] = val_95;
                long val_97 = this._state[(val_100 + 2) & 7];
                System.Int64[] val_42 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6 + (((ulong)((this._state[((0 + 2) & 7)][0]>>8) & 0xFF)) << 3);
                long val_98 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6 + ((ulong)((this._state[((0 + 2) & 7)][0]>>8) & 0xFF)) << 3) + 32;
                val_98 = val_98 ^ this._L[val_100];
                this._L[val_100] = val_98;
                val_100 = val_100 + 1;
                long val_101 = this._state[val_100 & 7];
                System.Int64[] val_44 = Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7 + ((this._state[((0 + 1) & 7)][0]) << 3);
                long val_102 = (Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7 + (this._state[((0 + 1) & 7)][0]) << 3) + 32;
                val_102 = val_102 ^ this._L[val_100];
                this._L[val_100] = val_102;
            }
            while(val_100 != 8);
            
                System.Array.Copy(sourceArray:  this._L, sourceIndex:  0, destinationArray:  this._state, destinationIndex:  0, length:  this._state.Length);
                val_103 = val_103 + 1;
            }
            while(val_103 != 11);
            
            var val_107 = 4;
            do
            {
                var val_45 = val_107 - 4;
                long val_106 = this._block[0];
                val_106 = this._state[0] ^ this._hash[0] ^ val_106;
                this._hash[0] = val_106;
                val_107 = val_107 + 1;
            }
            while(val_107 != 12);
        
        }
        public void Update(byte input)
        {
            this._buffer[this._bufferPos] = input;
            int val_1 = this._bufferPos + 1;
            this._bufferPos = val_1;
            if(val_1 == this._buffer.Length)
            {
                    this.processFilledBuffer();
            }
            
            this.increment();
        }
        private void increment()
        {
            var val_5;
            int val_7 = this._bitCount.Length;
            val_7 = val_7 - 1;
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            var val_1 = (long)val_7 + 16;
            do
            {
                var val_2 = val_1 - 16;
                val_5 = null;
                var val_3 = val_1 << 1;
                val_5 = null;
                System.Int16[] val_4 = 0 + 1152921506263291232;
                mem2[0] = 1152921506263291232 & 255;
                val_1 = val_1 - 1;
            }
            while(((val_1 - 16) & 2147483648) == 0);
        
        }
        public void BlockUpdate(byte[] input, int inOff, int length)
        {
            int val_2 = inOff;
            if(length < 1)
            {
                    return;
            }
            
            int val_1 = length + 1;
            do
            {
                this.Update(input:  input[(long)val_2]);
                val_1 = val_1 - 1;
                val_2 = val_2 + 1;
            }
            while(val_1 > 1);
        
        }
        private void finish()
        {
            this._bufferPos = this._bufferPos + 1;
            byte val_3 = this._buffer[this._bufferPos];
            val_3 = val_3 | 128;
            this._buffer[this._bufferPos] = val_3;
            if(this._bufferPos == this._buffer.Length)
            {
                    this.processFilledBuffer();
            }
            
            if(this._bufferPos >= 33)
            {
                    do
            {
                this.Update(input:  0);
            }
            while(this._bufferPos != 0);
            
                do
            {
                this.Update(input:  0);
            }
            while(this._bufferPos < 33);
            
                System.Array.Copy(sourceArray:  this.copyBitLength(), sourceIndex:  0, destinationArray:  this._buffer, destinationIndex:  32, length:  val_1.Length);
                this.processFilledBuffer();
            }
        
        }
        private byte[] copyBitLength()
        {
            var val_2;
            byte[] val_1 = new byte[32];
            val_2 = 0;
            goto label_1;
            label_6:
            val_2 = 1;
            val_1[0] = this._bitCount[0];
            label_1:
            if(val_2 < val_1.Length)
            {
                goto label_6;
            }
            
            return (System.Byte[])val_1;
        }
        public int GetByteLength()
        {
            return 64;
        }
        public Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest(originalDigest:  this);
        }
        public void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            Org.BouncyCastle.Utilities.IMemoable val_2 = other;
            if(val_2 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            System.Array.Copy(sourceArray:  11993091, sourceIndex:  0, destinationArray:  this._rc, destinationIndex:  0, length:  this._rc.Length);
            System.Array.Copy(sourceArray:  28563616, sourceIndex:  0, destinationArray:  this._buffer, destinationIndex:  0, length:  this._buffer.Length);
            this._bufferPos = 64;
            System.Array.Copy(sourceArray:  135970152, sourceIndex:  0, destinationArray:  this._bitCount, destinationIndex:  0, length:  this._bitCount.Length);
            System.Array.Copy(sourceArray:  0, sourceIndex:  0, destinationArray:  this._hash, destinationIndex:  0, length:  this._hash.Length);
            System.Array.Copy(sourceArray:  4194311, sourceIndex:  0, destinationArray:  this._K, destinationIndex:  0, length:  this._K.Length);
            System.Array.Copy(sourceArray:  1, sourceIndex:  0, destinationArray:  this._L, destinationIndex:  0, length:  this._L.Length);
            System.Array.Copy(sourceArray:  0, sourceIndex:  0, destinationArray:  this._block, destinationIndex:  0, length:  this._block.Length);
            System.Array.Copy(sourceArray:  0, sourceIndex:  0, destinationArray:  this._state, destinationIndex:  0, length:  this._state.Length);
        }
    
    }

}
