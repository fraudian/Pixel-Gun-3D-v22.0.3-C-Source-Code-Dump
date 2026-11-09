using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class SkipjackEngine : IBlockCipher
    {
        // Fields
        private const int BLOCK_SIZE = 8;
        private static readonly short[] ftable;
        private int[] key0;
        private int[] key1;
        private int[] key2;
        private int[] key3;
        private bool encrypting;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            if(parameters != null)
            {
                    System.Byte[] val_1 = parameters.GetKey();
                this.encrypting = forEncryption;
                var val_21 = 32;
                this.key0 = new int[32];
                this.key1 = new int[32];
                this.key2 = new int[32];
                var val_22 = 0;
                this.key3 = new int[32];
                do
            {
                var val_7 = val_21 - 32;
                int val_17 = val_1.Length;
                uint8_t val_8 = Org.BouncyCastle.Crypto.Parameters.KeyParameter.__il2cppRuntimeField_typeHierarchyDepth >> 63;
                Org.BouncyCastle.Crypto.Parameters.KeyParameter.__il2cppRuntimeField_typeHierarchyDepth = Org.BouncyCastle.Crypto.Parameters.KeyParameter.__il2cppRuntimeField_typeHierarchyDepth >> 34;
                this.key0[0] = val_1[(long)(long)(int)((32 - 32) - (((Org.BouncyCastle.Crypto.Parameters.KeyParameter.__il2cppRuntimeField_typeHierarchyDepth >> 34) + (Org.BouncyCastle.Crypto.Parameters.KeyParameter.__il2cppRuntimeField_typeHierarchyDepth >> 63)) * 10))];
                var val_9 = val_21 - 31;
                int val_10 = val_17 >> 63;
                val_17 = val_17 >> 34;
                val_17 = val_17 + val_10;
                val_9 = val_9 - (val_17 * 10);
                this.key1[0] = val_1[(long)val_9];
                var val_11 = val_21 - 30;
                val_10 = val_17 >> 32;
                val_17 = val_17 >> 63;
                val_17 = val_17 + (val_10 >> 2);
                val_11 = val_11 - (val_17 * 10);
                this.key2[0] = val_1[(long)val_11];
                var val_12 = val_21 - 29;
                val_10 = val_17 >> 63;
                val_17 = val_17 >> 34;
                val_17 = val_17 + val_10;
                val_12 = val_12 - (val_17 * 10);
                this.key3[0] = val_1[(long)val_12];
                val_21 = val_21 + 4;
                val_22 = val_22 + 1;
            }
            while(val_21 != 160);
            
                return;
            }
            
            System.ArgumentException val_15 = new System.ArgumentException(message:  "invalid parameter passed to SKIPJACK init - "("invalid parameter passed to SKIPJACK init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public virtual string get_AlgorithmName()
        {
            return "SKIPJACK";
        }
        public virtual bool get_IsPartialBlockOkay()
        {
            return false;
        }
        public virtual int GetBlockSize()
        {
            return 8;
        }
        public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            if(this.key1 != null)
            {
                    Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  inOff, len:  8, msg:  "input buffer too short");
                Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  8, msg:  "output buffer too short");
                if(this.encrypting == false)
            {
                    return 8;
            }
            
                return 8;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "SKIPJACK engine not initialised");
        }
        public virtual void Reset()
        {
        
        }
        private int G(int k, int w)
        {
            null = null;
            int val_1 = w & 255;
            int val_2 = this.key0[(long)k] ^ val_1;
            System.Int16[] val_3 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key0[(long)(int)(k)][0] ^ (w & 255)))) << 1);
            var val_14 = (uint)(w >> 8) & 255;
            val_14 = val_14 ^ ((Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key0[(long)(int)(k)][0] ^ (w & 255)))) << 1) + 32);
            int val_4 = this.key1[(long)k] ^ val_14;
            System.Int16[] val_5 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key1[(long)(int)(k)][0] ^ ((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key0[(long)(int)(k)][0] ^ (w & 255)))) << 1) + 32)))) << 1);
            val_1 = val_1 ^ ((Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key1[(long)(int)(k)][0] ^ ((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((th + 32);
            int val_6 = this.key2[(long)k] ^ val_1;
            System.Int16[] val_7 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key2[(long)(int)(k)][0] ^ ((w & 255) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key1[(long)(int)(k)][0] ^ ((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Eng)) << 1);
            var val_8 = val_14 ^ ((Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key2[(long)(int)(k)][0] ^ ((w & 255) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key1[(lon + 32);
            int val_9 = this.key3[(long)k] ^ val_8;
            System.Int16[] val_10 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key3[(long)(int)(k)][0] ^ (((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key0[(long)(int)(k)][0] ^ (w & 255)))) << 1) + 32) ^ (Org.BouncyCa)) << 1);
            var val_17 = (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key3[(long)(int)(k)][0] ^ (((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((t + 32;
            val_17 = val_1 ^ val_17;
            return (int)val_17 + (val_8 << 8);
        }
        public virtual int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            int val_22 = input.Length;
            if(val_22 <= inOff)
            {
                    val_22 = input.Length;
            }
            
            byte val_26 = input[(long)inOff];
            int val_1 = inOff + 1;
            if(val_1 >= val_22)
            {
                    val_22 = input.Length;
            }
            
            int val_2 = inOff + 2;
            if(val_2 >= val_22)
            {
                    val_22 = input.Length;
            }
            
            byte val_28 = input[(long)val_2];
            int val_3 = inOff + 3;
            if(val_3 >= val_22)
            {
                    val_22 = input.Length;
            }
            
            byte val_29 = input[(long)val_3];
            int val_4 = inOff + 4;
            if(val_4 >= val_22)
            {
                    val_22 = input.Length;
            }
            
            byte val_30 = input[(long)val_4];
            int val_5 = inOff + 5;
            if(val_5 >= val_22)
            {
                    val_22 = input.Length;
            }
            
            byte val_31 = input[(long)val_5];
            int val_6 = inOff + 6;
            if(val_6 >= val_22)
            {
                    val_22 = input.Length;
            }
            
            byte val_32 = input[(long)val_6];
            var val_38 = 0;
            var val_37 = 0;
            do
            {
                var val_34 = 0;
                int val_35 = input[(long)val_1];
                do
            {
                int val_8 = val_38 + val_34;
                int val_9 = this.G(k:  val_8, w:  val_35);
                var val_10 = val_8 + 1;
                val_34 = val_34 + 1;
                val_10 = val_10 ^ (input[(long)inOff + 7]);
                val_35 = val_10 ^ val_9;
            }
            while(val_34 != 8);
            
                var val_36 = -8;
                do
            {
                var val_11 = val_38 + val_36;
                val_11 = val_11 + 17;
                val_11 = val_9 ^ val_11;
                int val_13 = val_11 ^ val_35;
                int val_14 = this.G(k:  val_11 + 16, w:  val_35);
                val_36 = val_36 + 1;
            }
            while(val_36 != 0);
            
                val_37 = val_37 + 1;
                val_38 = val_38 + 16;
            }
            while(val_37 != 2);
            
            outBytes[(long)outOff] = val_31 >> 8;
            outBytes[(long)outOff + 1] = val_31;
            outBytes[(long)outOff + 2] = val_14 >> 8;
            outBytes[(long)outOff + 3] = val_14;
            outBytes[(long)outOff + 4] = val_13 >> 8;
            outBytes[(long)outOff + 5] = val_13;
            outBytes[(long)outOff + 6] = val_29 >> 8;
            outBytes[(long)outOff + 7] = val_29;
            return 8;
        }
        private int H(int k, int w)
        {
            var val_11;
            int val_12 = w;
            val_11 = null;
            val_11 = null;
            var val_15 = (uint)(val_12 >> 8) & 255;
            int val_1 = this.key3[(long)k] ^ val_15;
            System.Int16[] val_2 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key3[(long)(int)(k)][0] ^ (uint)((w>>8) & 0xFF)))) << 1);
            val_12 = val_12 & 255;
            val_12 = val_12 ^ ((Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key3[(long)(int)(k)][0] ^ (uint)((w>>8) & 0xFF)))) << 1) + 32);
            int val_3 = this.key2[(long)k] ^ val_12;
            System.Int16[] val_4 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key2[(long)(int)(k)][0] ^ ((w & 255) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key3[(long)(int)(k)][0] ^ (uint)((w>>8) & 0xFF)))) << 1) + 32)))) << 1);
            val_15 = val_15 ^ ((Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key2[(long)(int)(k)][0] ^ ((w & 255) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key3[(lon + 32);
            int val_5 = this.key1[(long)k] ^ val_15;
            System.Int16[] val_6 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key1[(long)(int)(k)][0] ^ ((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key2[(long)(int)(k)][0] ^ ((w & 255) ^ (Org.BouncyCastle.Crypto.Eng)) << 1);
            int val_7 = val_12 ^ ((Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key1[(long)(int)(k)][0] ^ ((uint)((w>>8) & 0xFF) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((th + 32);
            int val_8 = this.key0[(long)k] ^ val_7;
            System.Int16[] val_9 = Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + (((long)(int)((this.key0[(long)(int)(k)][0] ^ (((w & 255) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key3[(long)(int)(k)][0] ^ (uint)((w>>8) & 0xFF)))) << 1) + 32) ^ (Org.BouncyCa)) << 1);
            var val_17 = (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key0[(long)(int)(k)][0] ^ (((w & 255) ^ (Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable + ((long)(int)((this.key3[(lo + 32;
            val_17 = val_15 ^ val_17;
            return (int)val_7 + (val_17 << 8);
        }
        public virtual int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            int val_27 = input.Length;
            if(val_27 <= inOff)
            {
                    val_27 = input.Length;
            }
            
            byte val_31 = input[(long)inOff];
            int val_1 = inOff + 1;
            if(val_1 >= val_27)
            {
                    val_27 = input.Length;
            }
            
            byte val_32 = input[(long)val_1];
            int val_2 = inOff + 2;
            if(val_2 >= val_27)
            {
                    val_27 = input.Length;
            }
            
            byte val_33 = input[(long)val_2];
            int val_3 = inOff + 3;
            if(val_3 >= val_27)
            {
                    val_27 = input.Length;
            }
            
            int val_4 = inOff + 4;
            if(val_4 >= val_27)
            {
                    val_27 = input.Length;
            }
            
            byte val_35 = input[(long)val_4];
            int val_5 = inOff + 5;
            if(val_5 >= val_27)
            {
                    val_27 = input.Length;
            }
            
            int val_6 = inOff + 6;
            if(val_6 >= val_27)
            {
                    val_27 = input.Length;
            }
            
            byte val_37 = input[(long)val_6];
            byte val_38 = input[(long)inOff + 7];
            var val_43 = 0;
            var val_42 = 31;
            do
            {
                var val_39 = 0;
                int val_40 = input[(long)val_3];
                do
            {
                int val_8 = val_42 + val_39;
                int val_9 = this.H(k:  val_8, w:  val_40);
                var val_10 = val_8 + 1;
                val_39 = val_39 - 1;
                val_10 = input[(long)val_5] ^ val_10;
                val_40 = val_10 ^ val_9;
            }
            while(val_39 != 8);
            
                var val_41 = 0;
                do
            {
                var val_11 = val_43 + val_41;
                val_11 = val_11 + 24;
                val_11 = val_40 ^ val_11;
                byte val_13 = val_11 ^ val_9;
                int val_14 = this.H(k:  val_11 + 23, w:  val_40);
                val_41 = val_41 - 1;
            }
            while(val_41 != 8);
            
                val_42 = val_42 - 16;
                val_43 = val_43 - 16;
            }
            while(1 != 2);
            
            System.Byte[] val_16 = outBytes + (long)outOff;
            mem2[0] = val_14 >> 8;
            System.Byte[] val_18 = outBytes + ((long)outOff + 1);
            mem2[0] = val_14;
            int val_19 = outOff + 2;
            val_19 = outBytes + (long)val_19;
            mem2[0] = val_38 >> 8;
            System.Byte[] val_22 = outBytes + ((long)outOff + 3);
            mem2[0] = val_38;
            int val_23 = outOff + 4;
            val_23 = outBytes + (long)val_23;
            mem2[0] = val_32 >> 8;
            System.Byte[] val_26 = outBytes + ((long)outOff + 5);
            mem2[0] = val_32;
            int val_27 = outOff + 6;
            val_27 = outBytes + (long)val_27;
            mem2[0] = val_13 >> 8;
            System.Byte[] val_30 = outBytes + ((long)outOff + 7);
            mem2[0] = val_13;
            return 8;
        }
        public SkipjackEngine()
        {
        
        }
        private static SkipjackEngine()
        {
            Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable = new short[256] {163, 215, 9, 131, 248, 72, 246, 244, 179, 33, 21, 120, 153, 177, 175, 249, 231, 45, 77, 138, 206, 76, 202, 46, 82, 149, 217, 30, 78, 56, 68, 40, 10, 223, 2, 160, 23, 241, 96, 104, 18, 183, 122, 195, 233, 250, 61, 83, 150, 132, 107, 186, 242, 99, 154, 25, 124, 174, 229, 245, 247, 22, 106, 162, 57, 182, 123, 15, 193, 147, 129, 27, 238, 180, 26, 234, 208, 145, 47, 184, 85, 185, 218, 133, 63, 65, 191, 224, 90, 88, 128, 95, 102, 11, 216, 144, 53, 213, 192, 167, 51, 6, 101, 105, 69, 0, 148, 86, 109, 152, 155, 118, 151, 252, 178, 194, 176, 254, 219, 32, 225, 235, 214, 228, 221, 71, 74, 29, 66, 237, 158, 110, 73, 60, 205, 67, 39, 210, 7, 212, 222, 199, 103, 24, 137, 203, 48, 31, 141, 198, 143, 170, 200, 116, 220, 201, 93, 92, 49, 164, 112, 136, 97, 44, 159, 13, 43, 135, 80, 130, 84, 100, 38, 125, 3, 64, 52, 75, 28, 115, 209, 196, 253, 59, 204, 251, 127, 171, 230, 62, 91, 165, 173, 4, 35, 156, 20, 81, 34, 240, 41, 121, 113, 126, 255, 140, 14, 226, 12, 239, 188, 114, 117, 111, 55, 161, 236, 211, 142, 98, 139, 134, 16, 232, 8, 119, 17, 190, 146, 79, 36, 197, 50, 54, 157, 207, 243, 166, 187, 172, 94, 108, 169, 19, 87, 37, 181, 227, 189, 168, 58, 1, 5, 89, 42, 70};
        }
    
    }

}
