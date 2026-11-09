using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class AesEngine : IBlockCipher
    {
        // Fields
        private static readonly byte[] S;
        private static readonly byte[] Si;
        private static readonly byte[] rcon;
        private static readonly uint[] T0;
        private static readonly uint[] Tinv0;
        private const uint m1 = 2155905152;
        private const uint m2 = 2139062143;
        private const uint m3 = 27;
        private const uint m4 = 3233857728;
        private const uint m5 = 1061109567;
        private int ROUNDS;
        private uint[][] WorkingKey;
        private uint C0;
        private uint C1;
        private uint C2;
        private uint C3;
        private bool forEncryption;
        private const int BLOCK_SIZE = 16;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        private static uint Shift(uint r, int shift)
        {
            r = r >> (shift & 31);
            return (uint)r;
        }
        private static uint FFmulX(uint x)
        {
            uint val_1 = x >> 7;
            uint val_2 = x << 1;
            val_1 = val_1 & 16843009;
            val_2 = val_2 & 4278124286;
            val_1 = val_1 * 27;
            x = val_1 ^ val_2;
            return (uint)x;
        }
        private static uint FFmulX2(uint x)
        {
            uint val_1 = x & 3233857728;
            uint val_2 = x << 2;
            val_2 = val_2 & 4244438268;
            val_2 = val_2 ^ 0;
            x = val_2 ^ 0;
            return (uint)x;
        }
        private static uint Inv_Mcol(uint x)
        {
            var val_5 = 0;
            var val_3 = 0;
            var val_4 = 0;
            val_3 = val_3 ^ x;
            val_4 = val_3 ^ val_4;
            uint val_1 = val_4 << 2;
            val_3 = val_4 & 3233857728;
            val_1 = val_1 & 4244438268;
            val_5 = val_1 ^ val_5;
            val_5 = val_5 ^ 0;
            val_5 = val_5 ^ 0;
            val_4 = val_5 ^ val_4;
            return (uint)val_4 ^ ((((((((((0 ^ x) ^ 0) << 2) & 4244438268) ^ 0) ^ 0) ^ 0)) << (32-16)) | (((((((((0 ^ x) ^ 0) << 2) & 4244438268) ^ 0) ^ 0) ^ 0)) << 16));
        }
        private static uint SubWord(uint x)
        {
            var val_6;
            uint val_6 = x;
            val_6 = null;
            val_6 = null;
            int val_2 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_6 & 255);
            int val_3 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_6 >> 8) & 255);
            int val_4 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_6 >> 16) & 255);
            val_6 = val_6 >> 24;
            int val_5 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + val_6;
            return (uint)(Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (x & 255)) + 32;
        }
        private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
        {
            uint val_59;
            uint val_60;
            Org.BouncyCastle.Crypto.Engines.AesEngine val_61;
            uint val_62;
            System.UInt32[] val_63;
            var val_64;
            int val_65 = key.Length;
            if(((val_65 - 16) > 16) || ((val_65 & 7) != 0))
            {
                goto label_3;
            }
            
            int val_3 = val_65 >> 2;
            val_65 = val_3 + 6;
            this.ROUNDS = val_65;
            int val_4 = val_3 + 7;
            System.UInt32[][] val_5 = new System.UInt32[][0];
            if((this.ROUNDS & 2147483648) != 0)
            {
                goto label_4;
            }
            
            var val_66 = 0;
            label_11:
            uint[] val_6 = new uint[4];
            if(val_5 == null)
            {
                goto label_5;
            }
            
            if(val_6 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_6 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_5[0] = val_6;
            val_66 = val_66 + 1;
            if(val_66 <= this.ROUNDS)
            {
                goto label_11;
            }
            
            label_4:
            if(val_3 == 8)
            {
                goto label_12;
            }
            
            if(val_3 == 6)
            {
                goto label_13;
            }
            
            if(val_3 != 4)
            {
                goto label_14;
            }
            
            uint val_71 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  0);
            val_5[0][0] = val_71;
            uint val_8 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  4);
            val_5[0][0] = val_8;
            uint val_72 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  8);
            val_5[0][1] = val_72;
            uint val_73 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  12);
            val_5[0][1] = val_73;
            do
            {
                var val_13 = 0 + 1;
                val_71 = (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_73 >> 8)) ^ val_71;
                val_59 = val_71 ^ ((key.Length & 7) + 32);
                typeof(System.UInt32[][]).__il2cppRuntimeField_20 = val_59;
                val_60 = val_59 ^ val_8;
                typeof(System.UInt32[][]).__il2cppRuntimeField_24 = val_60;
                val_72 = val_60 ^ val_72;
                typeof(System.UInt32[][]).__il2cppRuntimeField_28 = val_72;
                val_61 = this;
                val_73 = val_72 ^ val_73;
                typeof(System.UInt32[][]).__il2cppRuntimeField_2C = val_73;
                val_62 = 1152921505536131072;
                val_63 = 0 + 1;
            }
            while(val_63 != 10);
            
            goto label_45;
            label_12:
            uint val_14 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  0);
            val_5[0][0] = val_14;
            uint val_15 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  4);
            val_5[0][0] = val_15;
            uint val_16 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  8);
            val_5[0][1] = val_16;
            uint val_17 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  12);
            val_5[0][1] = val_17;
            uint val_18 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  16);
            val_5[1][0] = val_18;
            uint val_19 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  20);
            val_5[1][0] = val_19;
            uint val_20 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  24);
            val_5[1][1] = val_20;
            uint val_21 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  28);
            val_5[1][1] = val_21;
            var val_22 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            do
            {
                uint val_83 = val_14;
                val_83 = val_83 ^ 1 ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_21 >> 8));
                uint val_85 = val_15;
                uint val_88 = val_17;
                val_5[0][0] = val_83;
                uint val_90 = val_18;
                val_85 = val_83 ^ val_85;
                val_5[0][0] = val_85;
                uint val_27 = val_85 ^ val_16;
                val_5[0][1] = val_27;
                val_88 = val_27 ^ val_88;
                val_5[0][1] = val_88;
                val_62 = (0 + 2) + 1;
                val_90 = (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_88)) ^ val_90;
                val_5[0][0] = val_90;
                uint val_92 = val_19;
                val_92 = val_90 ^ val_92;
                val_5[0][0] = val_92;
                uint val_94 = val_20;
                val_94 = val_92 ^ val_94;
                val_5[0][1] = val_94;
                uint val_96 = val_21;
                val_96 = val_94 ^ val_96;
                val_60 = 0 + 2;
                val_5[0][1] = val_96;
                var val_30 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.__il2cppRuntimeField_126 & 512) != 0) ? 1 : 0;
            }
            while((val_62 - 1) < 12);
            
            val_61 = this;
            uint val_33 = val_83 ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_96 >> 8));
            val_33 = val_33 ^ 64;
            val_5[14][0] = val_33;
            val_27 = val_33 ^ val_85;
            val_5[14][0] = val_27;
            uint val_34 = val_33 ^ val_16;
            val_5[14][1] = val_34;
            val_63 = val_5[14];
            val_59 = val_34 ^ val_88;
            if(val_63 != null)
            {
                goto label_202;
            }
            
            goto label_111;
            label_13:
            uint val_35 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  0);
            val_5[0][0] = val_35;
            uint val_108 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  4);
            val_5[0][0] = val_108;
            uint val_111 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  8);
            val_5[0][1] = val_111;
            uint val_114 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  12);
            val_5[0][1] = val_114;
            uint val_39 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  16);
            val_5[1][0] = val_39;
            uint val_40 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  key, off:  20);
            val_5[1][0] = val_40;
            uint val_44 = (val_35 ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_40 >> 8))) ^ 1;
            val_5[1][1] = val_44;
            val_108 = val_44 ^ val_108;
            val_5[1][1] = val_108;
            uint val_45 = val_108 ^ val_111;
            val_5[2][0] = val_45;
            val_111 = val_45 ^ val_114;
            val_5[2][0] = val_111;
            uint val_46 = val_111 ^ val_39;
            val_5[2][1] = val_46;
            val_114 = val_46 ^ val_40;
            val_5[2][1] = val_114;
            var val_129 = 0;
            var val_47 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            do
            {
                uint val_124 = val_108;
                var val_48 = val_129 + 3;
                val_44 = val_44 ^ 2 ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_114 >> 8));
                val_5[val_129][0] = val_44;
                uint val_52 = val_44 ^ val_124;
                val_5[val_129][0] = val_52;
                val_52 = val_52 ^ val_45;
                val_5[val_129][1] = val_52;
                val_52 = val_52 ^ val_111;
                val_5[val_129][1] = val_52;
                val_48 = val_48 + 1;
                val_45 = val_52 ^ val_46;
                val_5[val_129][0] = val_45;
                val_52 = val_45 ^ val_114;
                val_5[val_129][0] = val_52;
                val_52 = (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_52 >> 8)) ^ 0;
                val_44 = val_52 ^ val_44;
                val_5[val_129][1] = val_44;
                val_60 = val_52 ^ val_124;
                val_5[val_129][1] = val_60;
                val_48 = val_48 + 1;
                uint val_126 = val_111;
                val_124 = val_60 ^ val_52;
                val_5[val_129][0] = val_124;
                val_126 = val_60 ^ val_126;
                val_5[val_129][0] = val_126;
                val_45 = val_126 ^ val_45;
                val_5[val_129][1] = val_45;
                val_62 = val_126 ^ val_114;
                val_5[val_129][1] = val_62;
                val_129 = val_129 + 3;
                var val_56 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.__il2cppRuntimeField_126 & 512) != 0) ? 1 : 0;
            }
            while((val_48 - 2) < 9);
            
            val_126 = val_44 ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.SubWord(x:  val_62 >> 8));
            val_61 = this;
            uint val_59 = val_126 ^ 128;
            val_5[12][0] = val_59;
            val_126 = val_59 ^ val_60;
            val_5[12][0] = val_126;
            uint val_60 = val_59 ^ val_52;
            val_5[12][1] = val_60;
            val_63 = val_5[12];
            val_59 = val_60 ^ val_126;
            if(val_63 != null)
            {
                goto label_202;
            }
            
            label_111:
            label_202:
            val_63[1] = val_59;
            label_45:
            if(forEncryption == true)
            {
                    return val_5;
            }
            
            if(this.ROUNDS < 2)
            {
                    return val_5;
            }
            
            val_59 = 1152921505536131072;
            do
            {
                do
            {
                val_63 = Org.BouncyCastle.Crypto.Engines.AesEngine.Inv_Mcol(x:  1134694512);
                mem2[0] = val_63;
                val_60 = 0 + 1;
            }
            while(val_60 != 4);
            
            }
            while((1 + 1) < this.ROUNDS);
            
            return val_5;
            label_3:
            System.ArgumentException val_63 = null;
            val_64 = val_63;
            val_63 = new System.ArgumentException(message:  "Key length not 128/192/256 bits.");
            goto label_214;
            label_14:
            System.InvalidOperationException val_64 = null;
            val_64 = val_64;
            val_64 = new System.InvalidOperationException(message:  "Should never get here");
            label_214:
        }
        public AesEngine()
        {
        
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            if(parameters != null)
            {
                    bool val_2 = forEncryption;
                this.WorkingKey = this.GenerateWorkingKey(key:  parameters.GetKey(), forEncryption:  val_2);
                this.forEncryption = val_2;
                return;
            }
            
            System.ArgumentException val_6 = new System.ArgumentException(message:  "invalid parameter passed to AES init - "("invalid parameter passed to AES init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public virtual string get_AlgorithmName()
        {
            return "AES";
        }
        public virtual bool get_IsPartialBlockOkay()
        {
            return false;
        }
        public virtual int GetBlockSize()
        {
            return 16;
        }
        public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            if(this.WorkingKey != null)
            {
                    Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  inOff, len:  16, msg:  "input buffer too short");
                Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  16, msg:  "output buffer too short");
                this.UnPackBlock(bytes:  input, off:  inOff);
                if(this.forEncryption != false)
            {
                    this.EncryptBlock(KW:  this.WorkingKey);
            }
            else
            {
                    this.DecryptBlock(KW:  this.WorkingKey);
            }
            
                this.PackBlock(bytes:  output, off:  outOff);
                return 16;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "AES engine not initialised");
        }
        public virtual void Reset()
        {
        
        }
        private void UnPackBlock(byte[] bytes, int off)
        {
            this.C0 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bytes, off:  off);
            this.C1 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bytes, off:  off + 4);
            this.C2 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bytes, off:  off + 8);
            this.C3 = Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs:  bytes, off:  off + 12);
        }
        private void PackBlock(byte[] bytes, int off)
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.C0, bs:  bytes, off:  off);
            off = off + 4;
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.C1, bs:  bytes, off:  off);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.C2, bs:  bytes, off:  off + 8);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n:  this.C3, bs:  bytes, off:  off + 12);
        }
        private void EncryptBlock(uint[][] KW)
        {
            System.UInt32[][] val_151;
            int val_152;
            var val_153;
            var val_154;
            var val_155;
            var val_156;
            var val_157;
            var val_158;
            var val_159;
            val_151 = KW;
            System.UInt32[] val_150 = val_151[0];
            val_152 = KW[0].Length;
            if(val_152 == 0)
            {
                    val_152 = KW[0].Length;
            }
            
            if(val_152 <= 1)
            {
                    val_152 = KW[0].Length;
            }
            
            if(val_152 <= 2)
            {
                    val_152 = KW[0].Length;
            }
            
            val_153 = val_150[0] ^ mem[1152921551474929936];
            val_154 = val_150[0] ^ mem[1152921551474929940];
            val_155 = val_150[1] ^ mem[1152921551474929944];
            uint val_154 = val_150[1];
            val_156 = 2;
            val_154 = val_154 ^ mem[1152921551474929948];
            val_157 = 1152921505536131072;
            goto label_8;
            label_87:
            uint val_1 = val_153 & 255;
            System.UInt32[] val_2 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][0] ^ mem[1152921551474929936]) & 255)) << 2);
            System.UInt32[] val_3 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2);
            System.UInt32[] val_4 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)(((KW[0][1] ^ mem[1152921551474929944])>>16) & 0xFF)) << 2);
            var val_5 = W25 >> 24;
            System.UInt32[] val_6 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((W25 >> 24)) << 2);
            uint val_7 = val_154 & 255;
            System.UInt32[] val_8 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][0] ^ mem[1152921551474929940]) & 255)) << 2);
            System.UInt32[] val_9 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2);
            System.UInt32[] val_10 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((W25>>16) & 0xFF)) << 2);
            uint val_11 = val_153 >> 24;
            System.UInt32[] val_12 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][0] ^ mem[1152921551474929936]) >> 24)) << 2);
            uint val_13 = val_155 & 255;
            System.UInt32[] val_14 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][1] ^ mem[1152921551474929944]) & 255)) << 2);
            System.UInt32[] val_15 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((W25>>8) & 0xFF)) << 2);
            System.UInt32[] val_16 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)(((KW[0][0] ^ mem[1152921551474929936])>>16) & 0xFF)) << 2);
            uint val_17 = val_154 >> 24;
            System.UInt32[] val_18 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][0] ^ mem[1152921551474929940]) >> 24)) << 2);
            uint val_19 = val_154 & 255;
            System.UInt32[] val_20 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][1] ^ mem[1152921551474929948]) & 255)) << 2);
            System.UInt32[] val_21 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2);
            System.UInt32[] val_22 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)(((KW[0][0] ^ mem[1152921551474929940])>>16) & 0xFF)) << 2);
            var val_156 = (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>16) & 0xFF)) << 2) + 32;
            uint val_24 = val_155 >> 24;
            var val_25 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>16) & 0xFF)) << 2) + 32) >> 16;
            System.UInt32[] val_27 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((KW[0][1] ^ mem[1152921551474929944]) >> 24)) << 2);
            val_25 = ((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1152921551474929936]) & 255)) << 2) + 32)) ^ val_25;
            val_25 = val_25 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((W25 >> 24)) << 2) + 32) >> 8);
            System.UInt32[][] val_155 = val_151;
            val_155 = val_155 + 16;
            var val_34 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1152921551474929936]) >> 24)) << 2) + 32) >> 8;
            var val_35 = val_25 ^ (KW[0][0] + 32);
            val_35 = val_35 & 255;
            val_34 = (((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1152921551474929940]) & 255)) << 2) + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>16) & 0xFF)) << 2) + 32) >> 16)) ^ val_34;
            System.UInt32[] val_39 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[) << 2);
            var val_41 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1152921551474929940]) >> 24)) << 2) + 32) >> 8;
            val_34 = val_34 ^ (KW[0][0] + 36);
            val_156 = val_156 >> 16;
            val_41 = (((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929944]) & 255)) << 2) + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>16) & 0xFF)) << 2) + 32) >> 16)) ^ val_41;
            System.UInt32[] val_43 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1>>8) & 0xFF)) << 2);
            val_156 = ((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929948]) & 255)) << 2) + 32)) ^ val_156;
            var val_45 = val_41 ^ (KW[0][0] + 40);
            val_156 = val_156 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929944]) >> 24)) << 2) + 32) >> 8);
            System.UInt32[] val_46 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929944]) & 255)) << 2)>>16) & 0xFF)) << 2);
            var val_47 = val_156 ^ (KW[0][0] + 44);
            var val_48 = val_47 >> 24;
            System.UInt32[] val_49 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1 >> 24)) << 2);
            var val_50 = val_34 & 255;
            System.UInt32[] val_51 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[) << 2);
            System.UInt32[] val_52 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929944]) & 255)) << 2)>>8) & 0xFF)) << 2);
            System.UInt32[] val_53 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1>>16) & 0xFF)) << 2);
            var val_54 = val_35 >> 24;
            System.UInt32[] val_55 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1 >> 24)) << 2);
            var val_56 = val_45 & 255;
            System.UInt32[] val_57 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929944]) & 255)) << 2) << 2);
            System.UInt32[] val_58 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1>>8) & 0xFF)) << 2);
            System.UInt32[] val_59 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1>>16) & 0xFF)) << 2);
            var val_157 = (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32;
            var val_60 = val_34 >> 24;
            System.UInt32[] val_61 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1 >> 24)) << 2);
            var val_62 = val_47 & 255;
            System.UInt32[] val_63 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[) << 2);
            System.UInt32[] val_64 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1>>8) & 0xFF)) << 2);
            var val_65 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32) >> 24;
            val_157 = val_157 >> 16;
            var val_69 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle + 32);
            val_65 = val_65 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((( + 32);
            val_69 = val_69 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T + 32) >> 16);
            val_65 = val_65 ^ val_157;
            System.UInt32[] val_74 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][0] ^ mem[1>>16) & 0xFF)) << 2);
            val_158 = mem[(Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32];
            val_158 = (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32;
            if(Org.BouncyCastle.Crypto.Engines.AesEngine.T0 == null)
            {
                    val_158 = val_158;
            }
            
            if((val_45 >> 24) >= Org.BouncyCastle.Crypto.Engines.AesEngine.T0.Length)
            {
                    val_158 = val_158;
            }
            
            val_69 = (val_69 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle + 32) >> 8)) ^ ((KW + 16) + 32 + 32);
            val_154 = ((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32) >> 16)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle + 32) >> 8)) ^ ((KW + 16) + 32 + 36);
            val_155 = (val_65 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle + 32) >> 8)) ^ ((KW + 16) + 32 + 40);
            System.UInt32[] val_82 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((KW[0][1] ^ mem[1152921551474929944]) & 255)) << 2) >> 24)) << 2);
            val_157 = 1152921505536131072;
            val_151 = val_151;
            var val_158 = (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle + 32;
            val_153 = val_69;
            var val_159 = (KW + 16) + 32 + 44;
            val_158 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bounc + 32) >> 24) ^ val_158;
            val_158 = val_158 ^ (val_158 >> 16);
            val_158 = val_158 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((( + 32) >> 8);
            val_159 = val_158 ^ val_159;
            val_156 = 4;
            label_8:
            System.UInt32[][] val_87 = val_151 + (((long)(int)((val_156 - 1))) << 3);
            if(((long)val_156 - 1) < (mem[1152921551474929920] - 1))
            {
                goto label_87;
            }
            
            val_159 = null;
            var val_88 = val_153 & 255;
            System.UInt32[] val_89 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org) << 2);
            System.UInt32[] val_90 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEng>>8) & 0xFF)) << 2);
            System.UInt32[] val_91 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.>>16) & 0xFF)) << 2);
            var val_92 = val_159 >> 24;
            System.UInt32[] val_93 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org. >> 24)) << 2);
            var val_94 = val_154 & 255;
            System.UInt32[] val_95 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEn) << 2);
            System.UInt32[] val_96 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.>>8) & 0xFF)) << 2);
            System.UInt32[] val_97 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.>>16) & 0xFF)) << 2);
            var val_98 = val_153 >> 24;
            System.UInt32[] val_99 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org. >> 24)) << 2);
            var val_100 = val_155 & 255;
            System.UInt32[] val_101 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org) << 2);
            System.UInt32[] val_102 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.>>8) & 0xFF)) << 2);
            System.UInt32[] val_103 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.>>16) & 0xFF)) << 2);
            var val_104 = val_154 >> 24;
            System.UInt32[] val_105 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEng >> 24)) << 2);
            var val_106 = val_159 & 255;
            System.UInt32[] val_107 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929940])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org) << 2);
            System.UInt32[] val_108 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551474929944])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.>>8) & 0xFF)) << 2);
            System.UInt32[] val_109 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEng>>16) & 0xFF)) << 2);
            var val_111 = val_155 >> 24;
            var val_113 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551 + 32);
            System.UInt32[] val_114 = Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551474929936])>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org. >> 24)) << 2);
            var val_115 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[115 + 32) >> 24;
            val_113 = val_113 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[115 + 32) >> 16);
            var val_116 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551 + 32) >> 8;
            val_116 = val_113 ^ val_116;
            System.UInt32[][] val_160 = val_151;
            var val_119 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[115 + 32) >> 24;
            val_160 = val_160 + 32;
            var val_122 = val_116 ^ ((KW + ((long)(int)((val_156 - 1))) << 3) + 32 + 32);
            var val_124 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[115 + 32) >> 16;
            val_119 = val_119 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551 + 32);
            val_124 = val_119 ^ val_124;
            int val_127 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_122 & 255);
            var val_128 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 3 + 32) >> 8;
            val_115 = (((val_115 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << 2) + 3 + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[115 + 32) >> 16)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[1152921551 + 32) >> 8)) ^ ((KW + ((long)(int)((val_156 - 1))) << 3) + 32 + 36);
            val_128 = val_124 ^ val_128;
            var val_130 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][1] ^ mem[115 + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551 + 32);
            int val_131 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_115 >> 8) & 255);
            val_130 = val_130 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((W25>>8) & 0xFF)) << + 32) >> 16);
            var val_133 = val_128 ^ ((KW + ((long)(int)((val_156 - 1))) << 3) + 32 + 40);
            val_130 = val_130 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)(((KW[0][0] ^ mem[1152921551 + 32) >> 8);
            int val_134 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_133 >> 16) & 255);
            var val_135 = val_130 ^ ((KW + ((long)(int)((val_156 - 1))) << 3) + 32 + 44);
            val_130 = val_135 >> 24;
            int val_136 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + val_130;
            var val_161 = (KW + 32) + 32 + 32;
            val_161 = val_161 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCas + 32);
            mem[1152921551474929936] = val_161;
            var val_162 = val_115;
            val_162 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_162 & 255);
            var val_163 = val_133;
            val_163 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_163 >> 8) & 255);
            int val_138 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_135 >> 16) & 255);
            int val_140 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_122 >> 24);
            var val_164 = (KW + 32) + 32 + 36;
            val_164 = val_164 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCas + 32);
            mem[1152921551474929940] = val_164;
            var val_165 = val_133;
            val_165 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_165 & 255);
            int val_142 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_135 >> 8) & 255);
            int val_143 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_122 >> 16) & 255);
            int val_145 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_115 >> 24);
            var val_166 = (KW + 32) + 32 + 40;
            val_166 = val_166 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCas + 32);
            mem[1152921551474929944] = val_166;
            val_135 = val_135 & 255;
            int val_146 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + val_135;
            int val_147 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_122 >> 8) & 255);
            int val_148 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + ((uint)(val_115 >> 16) & 255);
            var val_167 = val_133;
            val_167 = Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (val_167 >> 24);
            var val_168 = (KW + 32) + 32 + 44;
            val_168 = val_168 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.T0 + ((uint)((((((((Org.BouncyCas + 32);
            mem[1152921551474929948] = val_168;
        }
        private void DecryptBlock(uint[][] KW)
        {
            System.UInt32[][] val_150;
            int val_151;
            var val_152;
            var val_153;
            var val_154;
            var val_155;
            var val_156;
            var val_157;
            var val_158;
            val_150 = KW;
            System.UInt32[] val_144 = val_150[this.ROUNDS];
            val_151 = KW[this.ROUNDS][0].Length;
            if(val_151 == 0)
            {
                    val_151 = KW[this.ROUNDS][0].Length;
            }
            
            if(val_151 <= 1)
            {
                    val_151 = KW[this.ROUNDS][0].Length;
            }
            
            if(val_151 <= 2)
            {
                    val_151 = KW[this.ROUNDS][0].Length;
            }
            
            uint val_1 = val_144[0] ^ this.C0;
            val_152 = val_144[0] ^ this.C1;
            val_153 = val_144[1] ^ this.C2;
            int val_149 = this.ROUNDS;
            int val_2 = val_149 - 1;
            val_154 = val_144[1] ^ this.C3;
            if(val_2 < 2)
            {
                    val_155 = val_1;
            }
            else
            {
                    val_149 = val_149 - 2;
                var val_154 = val_1;
                do
            {
                val_156 = null;
                System.UInt32[] val_150 = val_150[(long)val_2];
                val_156 = null;
                uint val_3 = val_154 & 255;
                System.UInt32[] val_4 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][0] ^ this.C0) & 255)) << 2);
                System.UInt32[] val_5 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2);
                System.UInt32[] val_6 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>16) & 0xFF)) << 2);
                uint val_7 = val_152 >> 24;
                System.UInt32[] val_8 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][0] ^ this.C1) >> 24)) << 2);
                uint val_9 = val_152 & 255;
                System.UInt32[] val_10 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][0] ^ this.C1) & 255)) << 2);
                System.UInt32[] val_11 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2);
                System.UInt32[] val_12 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>16) & 0xFF)) << 2);
                uint val_13 = val_153 >> 24;
                System.UInt32[] val_14 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][1] ^ this.C2) >> 24)) << 2);
                uint val_15 = val_153 & 255;
                System.UInt32[] val_16 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][1] ^ this.C2) & 255)) << 2);
                System.UInt32[] val_17 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2);
                System.UInt32[] val_18 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>16) & 0xFF)) << 2);
                uint val_19 = val_154 >> 24;
                System.UInt32[] val_20 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][1] ^ this.C3) >> 24)) << 2);
                uint val_21 = val_154 & 255;
                System.UInt32[] val_22 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][1] ^ this.C3) & 255)) << 2);
                System.UInt32[] val_23 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2);
                System.UInt32[] val_24 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>16) & 0xFF)) << 2);
                var val_156 = (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>16) & 0xFF)) << 2) + 32;
                val_154 = val_154 >> 24;
                System.UInt32[] val_28 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((KW[this.ROUNDS][0][0] ^ this.C0) >> 24)) << 2);
                var val_30 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][0] ^ this.C1) >> 24)) << 2) + 32) >> 8;
                val_30 = (((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][0] ^ this.C0) & 255)) << 2) + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>16) & 0xFF)) << 2) + 32) >> 16)) ^ val_30;
                var val_33 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][1] ^ this.C3) & 255)) << 2) + 32);
                val_156 = val_33 ^ (val_156 >> 16);
                System.UInt32[][] val_157 = val_150;
                val_157 = val_157 + (((long)(int)((this.ROUNDS - 2))) << 3);
                uint val_36 = val_30 ^ val_150[0];
                val_36 = val_36 & 255;
                var val_38 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][1] ^ this.C2) & 255)) << 2) + 32);
                val_38 = val_38 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>16) & 0xFF)) << 2) + 32) >> 16);
                var val_41 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32) >> 24;
                System.UInt32[] val_42 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUND) << 2);
                val_33 = (val_156 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][0] ^ this.C0) >> 24)) << 2) + 32) >> 8)) ^ val_150[1];
                val_38 = val_38 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][1] ^ this.C3) >> 24)) << 2) + 32) >> 8);
                var val_44 = val_41 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][0] ^ this.C1) & 255)) << 2) + 32);
                System.UInt32[] val_45 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>8) & 0xFF)) << 2);
                val_44 = val_44 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>16) & 0xFF)) << 2) + 32) >> 16);
                uint val_47 = val_38 ^ val_150[1];
                val_44 = val_44 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS][0][1] ^ this.C2) >> 24)) << 2) + 32) >> 8);
                System.UInt32[] val_48 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>16) & 0xFF)) << 2);
                val_41 = val_44 ^ val_150[0];
                uint val_49 = val_41 >> 24;
                System.UInt32[] val_50 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS >> 24)) << 2);
                uint val_51 = val_41 & 255;
                System.UInt32[] val_52 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUND) << 2);
                System.UInt32[] val_53 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>8) & 0xFF)) << 2);
                System.UInt32[] val_54 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>16) & 0xFF)) << 2);
                uint val_55 = val_47 >> 24;
                System.UInt32[] val_56 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS >> 24)) << 2);
                uint val_57 = val_47 & 255;
                System.UInt32[] val_58 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUND) << 2);
                System.UInt32[] val_59 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>8) & 0xFF)) << 2);
                System.UInt32[] val_60 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>16) & 0xFF)) << 2);
                uint val_61 = val_33 >> 24;
                System.UInt32[] val_62 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS >> 24)) << 2);
                uint val_63 = val_33 & 255;
                System.UInt32[] val_64 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUND) << 2);
                System.UInt32[] val_65 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>8) & 0xFF)) << 2);
                var val_66 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 24;
                var val_72 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32);
                val_66 = val_66 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32);
                val_72 = val_72 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 16);
                val_66 = val_66 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 16);
                var val_75 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32) >> 8;
                System.UInt32[] val_76 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS>>16) & 0xFF)) << 2);
                val_72 = val_72 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32) >> 8);
                val_75 = (((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 16)) ^ val_75;
                uint val_79 = val_36 >> 24;
                val_66 = val_66 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32) >> 8);
                val_150 = val_150;
                val_155 = val_72 ^ ((KW + ((long)(int)((this.ROUNDS - 2))) << 3) + 32 + 32);
                val_152 = val_75 ^ ((KW + ((long)(int)((this.ROUNDS - 2))) << 3) + 32 + 36);
                val_153 = val_66 ^ ((KW + ((long)(int)((this.ROUNDS - 2))) << 3) + 32 + 40);
                System.UInt32[] val_81 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((KW[this.ROUNDS >> 24)) << 2);
                var val_158 = (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32;
                val_158 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 24) ^ val_158;
                val_158 = val_158 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.Bou + 32) >> 16);
                val_158 = val_158 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Org.BouncyCast + 32) >> 8);
                val_154 = val_158 ^ ((KW + ((long)(int)((this.ROUNDS - 2))) << 3) + 32 + 44);
                int val_159 = val_149;
                var val_160 = (long)val_2;
                val_159 = val_159 - 2;
                val_160 = val_160 - 2;
            }
            while(val_160 > 1);
            
            }
            
            val_157 = null;
            val_158 = val_152;
            var val_84 = val_155 & 255;
            System.UInt32[] val_85 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (O) << 2);
            System.UInt32[] val_86 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>8) & 0xFF)) << 2);
            System.UInt32[] val_87 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>16) & 0xFF)) << 2);
            var val_88 =  >> 24;
            System.UInt32[] val_89 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or >> 24)) << 2);
            var val_90 =  & 255;
            System.UInt32[] val_91 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (O) << 2);
            System.UInt32[] val_92 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>8) & 0xFF)) << 2);
            System.UInt32[] val_93 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>16) & 0xFF)) << 2);
            var val_94 = val_153 >> 24;
            System.UInt32[] val_95 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or >> 24)) << 2);
            var val_96 = val_153 & 255;
            System.UInt32[] val_97 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (O) << 2);
            System.UInt32[] val_98 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>8) & 0xFF)) << 2);
            System.UInt32[] val_99 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>16) & 0xFF)) << 2);
            var val_100 = val_154 >> 24;
            System.UInt32[] val_101 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or >> 24)) << 2);
            var val_102 = val_154 & 255;
            System.UInt32[] val_103 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C1)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (O) << 2);
            var val_161 = (Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32;
            System.UInt32[] val_104 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][0] ^ this.C0)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>8) & 0xFF)) << 2);
            System.UInt32[] val_105 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C3)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or>>16) & 0xFF)) << 2);
            var val_107 = val_155 >> 24;
            var val_109 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32);
            System.UInt32[] val_110 = Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + (((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][0][1] ^ this.C2)>>8) & 0xFF)) << 2) + 32 >> 24) ^ (Or >> 24)) << 2);
            val_109 = val_109 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 16);
            var val_162 = KW + 40 + 44;
            var val_113 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 16;
            val_161 = (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 24) ^ val_161;
            var val_116 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 24;
            val_113 = val_161 ^ val_113;
            var val_117 = (val_109 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32) >> 8)) ^ (KW + 40 + 32);
            val_113 = val_113 ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32) >> 8);
            var val_119 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 16;
            val_116 = val_116 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32);
            val_119 = val_116 ^ val_119;
            val_162 = val_113 ^ val_162;
            System.Byte[] val_121 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_117 & 255);
            var val_122 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32) >> 8;
            val_122 = val_119 ^ val_122;
            System.Byte[] val_125 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_162 >> 8) & 255);
            var val_127 = ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32) >> 8;
            var val_128 = val_122 ^ (KW + 40 + 40);
            val_127 = (((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 24) ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.ROUNDS][ + 32)) ^ (((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)(((KW[this.R + 32) >> 16)) ^ val_127;
            System.Byte[] val_129 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_128 >> 16) & 255);
            var val_130 = val_127 ^ (KW + 40 + 36);
            val_127 = val_130 >> 24;
            System.Byte[] val_131 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + val_127;
            uint val_163 = KW + 32 + 32;
            val_163 = val_163 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastl + 32);
            this.C0 = val_163;
            System.Byte[] val_133 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_130 & 255);
            var val_164 = val_117;
            val_164 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_164 >> 8) & 255);
            var val_165 = val_162;
            val_165 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_165 >> 16) & 255);
            System.Byte[] val_135 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_128 >> 24);
            uint val_166 = KW + 32 + 36;
            val_166 = val_166 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastl + 32);
            this.C1 = val_166;
            System.Byte[] val_137 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_128 & 255);
            System.Byte[] val_138 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_130 >> 8) & 255);
            var val_167 = val_117;
            val_167 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_167 >> 16) & 255);
            var val_168 = val_162;
            val_168 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_168 >> 24);
            uint val_169 = KW + 32 + 40;
            val_169 = val_169 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastl + 32);
            this.C2 = val_169;
            var val_170 = val_162;
            val_170 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_170 & 255);
            System.Byte[] val_141 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_128 >> 8) & 255);
            System.Byte[] val_142 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + ((uint)(val_130 >> 16) & 255);
            var val_171 = val_117;
            val_171 = Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (val_171 >> 24);
            uint val_172 = KW + 32 + 44;
            val_172 = val_172 ^ ((Org.BouncyCastle.Crypto.Engines.AesEngine.Si + (((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 + ((uint)((((((((Org.BouncyCastl + 32);
            this.C3 = val_172;
        }
        private static AesEngine()
        {
            Org.BouncyCastle.Crypto.Engines.AesEngine.BLOCK_SIZE = new byte[256] {99, 124, 119, 123, 242, 107, 111, 197, 48, 1, 103, 43, 254, 215, 171, 118, 202, 130, 201, 125, 250, 89, 71, 240, 173, 212, 162, 175, 156, 164, 114, 192, 183, 253, 147, 38, 54, 63, 247, 204, 52, 165, 229, 241, 113, 216, 49, 21, 4, 199, 35, 195, 24, 150, 5, 154, 7, 18, 128, 226, 235, 39, 178, 117, 9, 131, 44, 26, 27, 110, 90, 160, 82, 59, 214, 179, 41, 227, 47, 132, 83, 209, 0, 237, 32, 252, 177, 91, 106, 203, 190, 57, 74, 76, 88, 207, 208, 239, 170, 251, 67, 77, 51, 133, 69, 249, 2, 127, 80, 60, 159, 168, 81, 163, 64, 143, 146, 157, 56, 245, 188, 182, 218, 33, 16, 255, 243, 210, 205, 12, 19, 236, 95, 151, 68, 23, 196, 167, 126, 61, 100, 93, 25, 115, 96, 129, 79, 220, 34, 42, 144, 136, 70, 238, 184, 20, 222, 94, 11, 219, 224, 50, 58, 10, 73, 6, 36, 92, 194, 211, 172, 98, 145, 149, 228, 121, 231, 200, 55, 109, 141, 213, 78, 169, 108, 86, 244, 234, 101, 122, 174, 8, 186, 120, 37, 46, 28, 166, 180, 198, 232, 221, 116, 31, 75, 189, 139, 138, 112, 62, 181, 102, 72, 3, 246, 14, 97, 53, 87, 185, 134, 193, 29, 158, 225, 248, 152, 17, 105, 217, 142, 148, 155, 30, 135, 233, 206, 85, 40, 223, 140, 161, 137, 13, 191, 230, 66, 104, 65, 153, 45, 15, 176, 84, 187, 22};
            Org.BouncyCastle.Crypto.Engines.AesEngine.Si = new byte[256] {82, 9, 106, 213, 48, 54, 165, 56, 191, 64, 163, 158, 129, 243, 215, 251, 124, 227, 57, 130, 155, 47, 255, 135, 52, 142, 67, 68, 196, 222, 233, 203, 84, 123, 148, 50, 166, 194, 35, 61, 238, 76, 149, 11, 66, 250, 195, 78, 8, 46, 161, 102, 40, 217, 36, 178, 118, 91, 162, 73, 109, 139, 209, 37, 114, 248, 246, 100, 134, 104, 152, 22, 212, 164, 92, 204, 93, 101, 182, 146, 108, 112, 72, 80, 253, 237, 185, 218, 94, 21, 70, 87, 167, 141, 157, 132, 144, 216, 171, 0, 140, 188, 211, 10, 247, 228, 88, 5, 184, 179, 69, 6, 208, 44, 30, 143, 202, 63, 15, 2, 193, 175, 189, 3, 1, 19, 138, 107, 58, 145, 17, 65, 79, 103, 220, 234, 151, 242, 207, 206, 240, 180, 230, 115, 150, 172, 116, 34, 231, 173, 53, 133, 226, 249, 55, 232, 28, 117, 223, 110, 71, 241, 26, 113, 29, 41, 197, 137, 111, 183, 98, 14, 170, 24, 190, 27, 252, 86, 62, 75, 198, 210, 121, 32, 154, 219, 192, 254, 120, 205, 90, 244, 31, 221, 168, 51, 136, 7, 199, 49, 177, 18, 16, 89, 39, 128, 236, 95, 96, 81, 127, 169, 25, 181, 74, 13, 45, 229, 122, 159, 147, 201, 156, 239, 160, 224, 59, 77, 174, 42, 245, 176, 200, 235, 187, 60, 131, 83, 153, 97, 23, 43, 4, 126, 186, 119, 214, 38, 225, 105, 20, 99, 85, 33, 12, 125};
            Org.BouncyCastle.Crypto.Engines.AesEngine.rcon = new byte[30] {1, 2, 4, 8, 16, 32, 64, 128, 27, 54, 108, 216, 171, 77, 154, 47, 94, 188, 99, 198, 151, 53, 106, 212, 179, 125, 250, 239, 197, 145};
            Org.BouncyCastle.Crypto.Engines.AesEngine.T0 = new uint[256] {-1520213050, -2072216328, -1720223762, -1921287178, 234025727, -1117033514, -1318096930, 1422247313, 1345335392, 50397442, -1452841010, 2099981142, 436141799, 1658312629, -424957107, -1703512340, 1170918031, -1652391393, 1086966153, -2021818886, 368769775, -346465870, -918075506, 200339707, -324162239, 1742001331, -39673249, -357585083, -1080255453, -140204973, -1770884380, 1539358875, -1028147339, 486407649, -1366060227, 1780885068, 1513502316, 1094664062, 49805301, 1338821763, 1546925160, -190470831, 887481809, 150073849, -1821281822, 1943591083, 1395732834, 1058346282, 201589768, 1388824469, 1696801606, 1589887901, 672667696, -1583966665, 251987210, -1248159185, 151455502, 907153956, -1686077413, 1038279391, 652995533, 1764173646, -843926913, -1619692054, 453576978, -1635548387, 1949051992, 773462580, 756751158, -1301385508, -296068428, -73359269, -162377052, 1295727478, 1641469623, -827083907, 2066295122, 1055122397, 1898917726, -1752923117, -179088474, 1758581177, 0, 753790401, 1612718144, 536673507, -927878791, -312779850, -1100322092, 1187761037, -641810841, 1262041458, -565556588, -733197160, -396863312, 1255133061, 1808847035, 720367557, -441800113, 385612781, -985447546, -682799718, 1429418854, -1803188975, -817543798, 284817897, 100794884, -2122350594, -263171936, 1144798328, -1163944155, -475486133, -212774494, -22830243, -1069531008, -1970303227, -1382903233, -1130521311, 1211644016, 83228145, -541279133, -1044990345, 1977277103, 1663115586, 806359072, 452984805, 250868733, 1842533055, 1288555905, 336333848, 890442534, 804056259, -513843266, -1567123659, -867941240, 957814574, 1472513171, -223893675, -2105639172, 1195195770, -1402706744, -413311558, 723065138, -1787595802, -1604296512, -1736343271, -783331426, 2145180835, 1713513028, 2116692564, -1416589253, -2088204277, -901364084, 703524551, -742868885, 1007948840, 2044649127, -497131844, 487262998, 1994120109, 1004593371, 1446130276, 1312438900, 503974420, -615954030, 168166924, 1814307912, -463709000, 1573044895, 1859376061, -273896381, -1503501628, -1466855111, -1533700815, 937747667, -1954973198, 854058965, 1137232011, 1496790894, -1217565222, -1936880383, 1691735473, -766620004, -525751991, -1267962664, -95005012, 133494003, 636152527, -1352309302, -1904575756, -374428089, 403179536, -709182865, -2005370640, 1864705354, 1915629148, 605822008, -240736681, -944458637, 1371981463, 602466507, 2094914977, -1670089496, 555687742, -582268010, -591544991, -2037675251, -2054518257, -1871679264, 1111375484, -994724495, -1436129588, -666351472, 84083462, 32962295, 302911004, -1553899070, 1597322602, -111716434, -793134743, -1853454825, 1489093017, 656219450, -1180787161, 954327513, 335083755, -1281845205, 856756514, -1150719534, 1893325225, -1987146233, -1483434957, -1231316179, 572399164, -1836611819, 552200649, 1238290055, -11184726, 2015897680, 2061492133, -1886614525, -123625127, -2138470135, 386731290, -624967835, 837215959, -968736124, -1201116976, -1019133566, -1332111063, 1999449434, 286199582, -877612933, -61582168, -692339859, 974525996};
            Org.BouncyCastle.Crypto.Engines.AesEngine.Tinv0 = new uint[256] {1353184337, 1399144830, -1012656358, -1772214470, -882136261, -247096033, -1420232020, -1828461749, 1442459680, -160598355, -1854485368, 625738485, -52959921, -674551099, -2143013594, -1885117771, 1230680542, 1729870373, -1743852987, -507445667, 41234371, 317738113, -1550367091, -956705941, -413167869, -1784901099, -344298049, -631680363, 763608788, -752782248, 694804553, 1154009486, 1787413109, 2021232372, 1799248025, -579749593, -1236278850, 397248752, 1722556617, -1271214467, 407560035, -2110711067, 1613975959, 1165972322, -529046351, -2068943941, 480281086, -1809118983, 1483229296, 436028815, -2022908268, -1208452270, 601060267, -503166094, 1468997603, 715871590, 120122290, 63092015, -1703164538, -1526188077, -226023376, -1297760477, -1167457534, 1552029421, 723308426, -1833666137, -252573709, -1578997426, -839591323, -708967162, 526529745, -1963022652, -1655493068, -1604979806, 853641733, 1978398372, 971801355, -1427152832, 111112542, 1360031421, -108388034, 1023860118, -1375387939, 1186850381, -1249028975, 90031217, 1876166148, -15380384, 620468249, -1746289194, -868007799, 2006899047, -1119688528, -2004121337, 945494503, -605108103, 1191869601, -384875908, -920746760, 0, -2088337399, 1223502642, -1401941730, 1316117100, -67170563, 1446544655, 517320253, 658058550, 1691946762, 564550760, -783000677, 976107044, -1318647284, 266819475, -761860428, -1634624741, 1338359936, -1574904735, 1766553434, 370807324, 179999714, -450191168, 1138762300, 488053522, 185403662, -1379431438, -1180125651, -928440812, -2061897385, 1275557295, -1143105042, -44007517, -1624899081, -1124765092, -985962940, 880737115, 1982415755, -590994485, 1761406390, 1676797112, -891538985, 277177154, 1076008723, 538035844, 2099530373, -130171950, 288553390, 1839278535, 1261411869, -214912292, -330136051, -790380169, 1813426987, -1715900247, -95906799, 577038663, -997393240, 440397984, -668172970, -275762398, -951170681, -1043253031, -22885748, 906744984, -813566554, 685669029, 646887386, -1530942145, -459458004, 227702864, -1681105046, 1648787028, -1038905866, -390539120, 1593260334, -173030526, -1098883681, 2090061929, -1456614033, -1290656305, 999926984, -1484974064, 1852021992, 2075868123, 158869197, -199730834, 28809964, -1466282109, 1701746150, 2129067946, 147831841, -420997649, -644094022, -835293366, -737566742, -696471511, -1347247055, 824393514, 815048134, -1067015627, 935087732, -1496677636, -1328508704, 366520115, 1251476721, -136647615, 240176511, 804688151, -1915335306, 1303441219, 1414376140, -553347356, -474623586, 461924940, -1205916479, 2136040774, 82468509, 1563790337, 1937016826, 776014843, 1511876531, 1389550482, 861278441, 323475053, -1939744870, 2047648055, -1911228327, -1992551445, -299390514, 902390199, -303751967, 1018251130, 1507840668, 1064563285, 2043548696, -1086863501, -355600557, 1537932639, 342834655, -2032450440, -2114736182, 1053059257, 741614648, 1598071746, 1925389590, 203809468, -1958134744, 1100287487, 1895934009, -558691320, -1662733096, -1866377628, 1636092795, 1890988757, 1952214088, 1113045200};
        }
    
    }

}
