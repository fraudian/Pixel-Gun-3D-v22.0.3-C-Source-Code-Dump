using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class RC2Engine : IBlockCipher
    {
        // Fields
        private static readonly byte[] piTable;
        private const int BLOCK_SIZE = 8;
        private int[] workingKey;
        private bool encrypting;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        private int[] GenerateWorkingKey(byte[] key, int bits)
        {
            var val_11;
            int val_12;
            var val_13;
            var val_14;
            int val_15;
            int val_16;
            var val_17;
            var val_18;
            int val_19;
            int val_19 = bits;
            int[] val_1 = new int[128];
            val_11 = 0;
            goto label_1;
            label_6:
            val_12 = key.Length;
            if(val_11 == key.Length)
            {
                goto label_2;
            }
            
            label_7:
            val_11 = 1;
            val_1[0] = key[0];
            label_1:
            if(key == null)
            {
                goto label_6;
            }
            
            val_12 = key.Length;
            if(val_11 != val_12)
            {
                goto label_7;
            }
            
            label_2:
            if(val_12 <= 127)
            {
                    int val_2 = val_12 - 1;
                int val_14 = val_1[((long)(int)((key.Length - 1))) << 2];
                var val_16 = 0;
                do
            {
                val_13 = null;
                val_13 = null;
                int val_3 = val_1[0] + val_14;
                val_14 = val_3 & 255;
                int val_4 = val_12 + val_16;
                val_3 = Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + val_14;
                val_16 = val_16 + 1;
                val_1[((long)(int)((key.Length + 0))) << 2] = (Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + ((val_1[0x0][0] + val_1[((long)(int)((key.Length - 1))) << 2][0]) & 255)) + 32;
            }
            while((val_12 + val_16) < 128);
            
            }
            
            int val_6 = val_19 + 7;
            val_14 = null;
            val_14 = null;
            val_6 = val_6 >> 3;
            val_15 = 128 - (val_6 << );
            var val_18 = -val_19;
            val_18 = val_18 & 7;
            val_18 = 255 >> val_18;
            val_19 = (val_1[((128 - (((bits + 7) >> 3)) << )) << 2]) & val_18;
            int val_7 = Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + val_19;
            mem2[0] = (Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + (val_1[((128 - (((bits + 7) >> 3)) << )) << 2][0] & (255 >> (bits & 7)))) + 32;
            if(val_15 >= val_1.Length)
            {
                    do
            {
                val_17 = null;
                val_17 = null;
                val_16 = Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE;
                var val_9 = 135 - 8;
                int val_10 = val_1[63] ^ ((Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + (val_1[((128 - (((bits + 7) >> 3)) << )) << 2][0] & (255 >> (bits & 7)))) + 32);
                val_10 = val_16 + (long)val_10;
                val_15 = ((long)val_15 - 1) - 1;
                var val_11 = 135 - 1;
                val_1[((long)(int)(((128 - (((bits + 7) >> 3)) << ) - 1))) << 2] = (Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + (long)(int)((val_1[63] ^ (Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE + (val_1[((128 - (((bits + 7) >> 3)) << )) << 2][0] & (255 >> (bi + 32;
            }
            while((val_15 & 2147483648) == 0);
            
            }
            
            int[] val_12 = new int[64];
            val_18 = 0;
            goto label_33;
            label_38:
            val_19 = val_1.Length;
            if(0 >= val_19)
            {
                    val_19 = val_1.Length;
            }
            
            val_15 = val_1[0] + (val_1[4] << 8);
            val_18 = 1;
            val_12[0] = val_15;
            label_33:
            if(val_18 != val_12.Length)
            {
                goto label_38;
            }
            
            return (System.Int32[])val_12;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            this.encrypting = forEncryption;
            if(parameters != null)
            {
                    System.Byte[] val_3 = parameters.GetKey();
                this.workingKey = val_3.GenerateWorkingKey(key:  val_3, bits:  val_3.Length << 3);
                return;
            }
            
            System.ArgumentException val_10 = new System.ArgumentException(message:  "invalid parameter passed to RC2 init - "("invalid parameter passed to RC2 init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public virtual void Reset()
        {
        
        }
        public virtual string get_AlgorithmName()
        {
            return "RC2";
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
            if(this.workingKey != null)
            {
                    Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  inOff, len:  8, msg:  "input buffer too short");
                Org.BouncyCastle.Crypto.Check.OutputLength(buf:  output, off:  outOff, len:  8, msg:  "output buffer too short");
                if(this.encrypting != false)
            {
                    this.EncryptBlock(input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
                this.DecryptBlock(input:  input, inOff:  inOff, outBytes:  output, outOff:  outOff);
                return 8;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "RC2 engine not initialised");
        }
        private int RotateWordLeft(int x, int y)
        {
            var val_4 = 16;
            val_4 = val_4 - y;
            int val_1 = x & 65535;
            int val_2 = y & 31;
            val_4 = val_4 & 31;
            val_2 = val_1 << val_2;
            val_1 = val_1 >> val_4;
            return (int)val_1 | val_2;
        }
        private void EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            int val_69;
            var val_73;
            int val_75;
            var val_76;
            var val_77;
            int val_78;
            var val_79;
            var val_80;
            val_69 = input.Length;
            int val_1 = inOff + 7;
            if(val_1 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_71 = input[(long)val_1];
            int val_2 = inOff + 6;
            if(val_2 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_72 = input[(long)val_2];
            int val_3 = inOff + 5;
            if(val_3 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_73 = input[(long)val_3];
            int val_4 = inOff + 4;
            if(val_4 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_74 = input[(long)val_4];
            int val_5 = inOff + 3;
            if(val_5 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_75 = input[(long)val_5];
            int val_6 = inOff + 2;
            if(val_6 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_76 = input[(long)val_6];
            int val_7 = inOff + 1;
            if(val_7 >= val_69)
            {
                    val_69 = input.Length;
            }
            
            byte val_77 = input[(long)val_7];
            byte val_78 = input[(long)inOff];
            val_73 = 3;
            goto label_9;
            label_18:
            var val_8 = (long)inOff + (((long)(int)(input[(long)(int)((inOff + 1))][0])) << 2);
            var val_79 = ((long)(int)(inOff) + ((long)(int)(input[(long)(int)((inOff + 1))][0])) << 2) + 32;
            byte val_9 = val_72 & val_74;
            byte val_10 = val_76 & (~val_72);
            val_9 = val_9 + val_78;
            val_10 = val_9 + val_10;
            val_79 = (val_10 + val_79) & 65535;
            val_78 = val_79 << 1;
            val_77 = val_77 + 1;
            long val_81 = 1;
            int val_80 = this.workingKey[val_81];
            val_9 = val_78 & val_72;
            byte val_12 = val_74 & (~val_78);
            val_9 = val_9 + val_76;
            val_12 = val_9 + val_12;
            val_81 = val_12 + val_80;
            val_80 = val_81 & 65535;
            val_76 = val_80 << 2;
            val_77 = val_77 + 1;
            long val_83 = 2;
            int val_82 = this.workingKey[val_83];
            val_9 = val_76 & val_78;
            byte val_13 = val_72 & (~val_76);
            val_9 = val_9 + val_74;
            val_13 = val_9 + val_13;
            val_83 = val_13 + val_82;
            val_82 = val_83 & 65535;
            val_74 = val_82 << 3;
            byte val_14 = val_77 + 1;
            int val_84 = this.workingKey[3];
            val_9 = val_74 & val_76;
            byte val_15 = val_78 & (~val_74);
            val_9 = val_9 + val_72;
            val_15 = val_9 + val_15;
            val_84 = val_15 + val_84;
            val_15 = val_84 & 65535;
            val_72 = val_15 << 5;
            val_73 = 7;
            label_9:
            System.Int32[] val_86 = this.workingKey;
            if((val_73 - 3) < 17)
            {
                goto label_18;
            }
            
            val_75 = (val_86[val_72 & 63]) + val_78;
            val_86 = val_75 & 63;
            val_76 = this.workingKey[val_86] + val_76;
            val_86 = val_76 & 63;
            val_77 = this.workingKey[val_86] + val_74;
            val_86 = val_77 & 63;
            val_78 = this.workingKey[val_86] + val_72;
            val_79 = 23;
            goto label_26;
            label_35:
            int val_18 = val_86 + (((long)(int)(this.workingKey)) << 2);
            var val_90 = (((this.workingKey[((this.workingKey[((this.workingKey[(((((((((((((((((((((((((input[(long)(int)((inOff + 6))][0] & input[(long)(int)((inOff + 4))][0]) + input[(long)(int)(inOff)][0]) + (input[(long) + 32;
            val_9 = val_78 & val_77;
            val_15 = val_76 & (~val_78);
            val_9 = val_9 + val_75;
            val_15 = val_9 + val_15;
            val_90 = (val_15 + val_90) & 65535;
            val_75 = val_90 << 1;
            int val_91 = this.workingKey[21];
            val_9 = val_75 & val_78;
            int val_20 = val_77 & (~val_75);
            val_9 = val_9 + val_76;
            val_20 = val_9 + val_20;
            val_76 = val_20 << 2;
            int val_92 = this.workingKey[22];
            val_9 = val_76;
            int val_23 = val_78;
            int val_24 = val_9;
            val_77 = val_24 << 3;
            int val_93 = this.workingKey[23];
            val_24 = val_77;
            int val_28 = val_75;
            int val_29 = val_24;
            val_29 = val_29;
            val_78 = val_29 << 5;
            val_79 = 27;
            label_26:
            System.Int32[] val_95 = this.workingKey;
            if((val_79 - 3) < 41)
            {
                goto label_35;
            }
            
            val_74 = val_95[val_78];
            val_95 = val_74;
            int val_34 = this.workingKey[val_95];
            val_95 = val_34;
            val_75 = this.workingKey[val_95];
            val_95 = val_75;
            var val_103 = 0;
            val_78 = this.workingKey[val_95];
            do
            {
                var val_35 = val_103 + 44;
                int val_99 = this.workingKey[val_103];
                val_29 = val_78;
                val_29 = val_78;
                int val_36 = val_29;
                int val_37 = val_29;
                int val_38 = val_37;
                int val_39 = val_38;
                val_74 = val_39 << 1;
                val_35 = val_35 + 1;
                int val_100 = this.workingKey[val_103];
                val_38 = val_74;
                val_37 = val_74;
                int val_41 = val_38;
                int val_42 = val_37;
                int val_43 = val_42;
                int val_44 = val_43;
                val_34 = val_44 << 2;
                val_35 = val_35 + 1;
                int val_101 = this.workingKey[val_103];
                val_43 = val_34;
                val_42 = val_34;
                int val_46 = val_43;
                int val_47 = val_42;
                int val_48 = val_47;
                int val_49 = val_48;
                val_75 = val_49 << 3;
                val_35 = val_35 + 1;
                int val_102 = this.workingKey[val_103];
                val_48 = val_75;
                val_47 = val_75;
                int val_51 = val_48;
                int val_55 = val_47;
                val_78 = val_55 << 5;
                val_103 = val_103 + 4;
            }
            while((val_35 - 3) < 60);
            
            val_80 = (long)outOff;
            if((outBytes + 24) <= outOff)
            {
                    val_80 = val_80;
            }
            
            val_80 = outBytes + val_80;
            mem2[0] = val_74;
            int val_57 = outOff + 1;
            val_57 = outBytes + (long)val_57;
            mem2[0] = val_39 >> 7;
            System.Byte[] val_60 = outBytes + ((long)outOff + 2);
            mem2[0] = val_34;
            int val_61 = outOff + 3;
            val_61 = outBytes + (long)val_61;
            mem2[0] = val_44 >> 6;
            System.Byte[] val_64 = outBytes + ((long)outOff + 4);
            mem2[0] = val_75;
            int val_65 = outOff + 5;
            val_65 = outBytes + (long)val_65;
            mem2[0] = val_49 >> 5;
            System.Byte[] val_68 = outBytes + ((long)outOff + 6);
            mem2[0] = val_78;
            int val_69 = outOff + 7;
            val_69 = outBytes + (long)val_69;
            mem2[0] = val_55 >> 3;
        }
        private void DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            int val_103 = input.Length;
            int val_1 = inOff + 7;
            if(val_1 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            byte val_118 = input[(long)val_1];
            int val_2 = inOff + 6;
            if(val_2 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            int val_3 = inOff + 5;
            if(val_3 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            byte val_120 = input[(long)val_3];
            int val_4 = inOff + 4;
            if(val_4 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            byte val_121 = input[(long)val_4];
            int val_5 = inOff + 3;
            if(val_5 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            byte val_122 = input[(long)val_5];
            int val_6 = inOff + 2;
            if(val_6 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            byte val_123 = input[(long)val_6];
            int val_7 = inOff + 1;
            if(val_7 >= val_103)
            {
                    val_103 = input.Length;
            }
            
            byte val_124 = input[(long)val_7];
            byte val_125 = input[(long)inOff];
            var val_130 = 0;
            do
            {
                var val_10 = val_130 + 63;
                int val_126 = this.workingKey[val_130];
                byte val_14 = ((input[(long)val_2] & 65535) << 11) - ((val_121 & val_123) + (val_125 & (~val_121)));
                var val_17 = val_130 + 62;
                val_126 = val_14 - val_126;
                int val_127 = this.workingKey[val_130];
                val_14 = (((val_121 & 65535) << 13) - (val_123 & val_125)) - (val_126 & (~val_123));
                var val_23 = val_130 + 61;
                val_127 = val_14 - val_127;
                int val_128 = this.workingKey[val_130];
                byte val_25 = val_127 & (~val_125);
                byte val_27 = (((val_123 & 65535) << 14) - (val_126 & val_125)) - val_25;
                var val_29 = val_130 + 60;
                val_128 = val_27 - val_128;
                byte val_31 = val_127 & val_126;
                val_25 = val_128 & (~val_126);
                val_31 = ((val_125 & 65535) << 15) - val_31;
                val_25 = val_31 - val_25;
                val_130 = val_130 - 4;
                val_125 = val_25 - this.workingKey[val_130];
            }
            while((val_130 + 60) > 47);
            
            int val_131 = this.workingKey[val_127 & 63];
            System.Int32[] val_136 = this.workingKey;
            val_131 = val_126 - val_131;
            val_127 = val_127 - (this.workingKey[val_128 & 63]);
            val_128 = val_128 - (this.workingKey[val_125 & 63]);
            var val_140 = 0;
            val_126 = val_125 - (val_136[val_131 & 63]);
            do
            {
                var val_39 = val_140 + 43;
                int val_135 = this.workingKey[val_140];
                val_136 = ((val_131 & 65535) << 11) - ((val_127 & val_128) + (val_126 & (~val_127)));
                var val_45 = val_140 + 42;
                byte val_46 = val_136;
                int val_137 = this.workingKey[val_140];
                byte val_48 = val_46;
                var val_53 = val_140 + 41;
                byte val_54 = ((val_127 & 65535) << 13) - (val_128 & val_126);
                byte val_55 = val_46;
                int val_138 = this.workingKey[val_140];
                byte val_56 = val_54 & (~val_126);
                val_27 = (val_128 & 65535) << 14;
                var val_59 = val_140 + 40;
                val_138 = val_27 - val_138;
                int val_139 = this.workingKey[val_140];
                byte val_61 = val_54;
                byte val_62 = val_138;
                val_62 = ((val_126 & 65535) << 15) - val_62;
                val_140 = val_140 - 4;
                val_126 = val_62;
            }
            while((val_140 + 40) > 23);
            
            int val_141 = this.workingKey[val_54 & 63];
            int val_142 = this.workingKey[val_138 & 63];
            int val_143 = this.workingKey[val_126];
            byte val_68 = val_46;
            byte val_69 = val_54;
            byte val_71 = val_138;
            int val_144 = this.workingKey[val_68];
            var val_149 = 0;
            byte val_72 = val_126;
            do
            {
                var val_75 = val_149 + 19;
                byte val_76 = val_72;
                int val_145 = this.workingKey[val_149];
                byte val_78 = val_69;
                var val_82 = val_149 + 18;
                byte val_83 = val_68 << 11;
                byte val_84 = val_71;
                int val_146 = this.workingKey[val_149];
                byte val_85 = val_83;
                var val_90 = val_149 + 17;
                byte val_91 = (val_69 & 65535) << 13;
                byte val_92 = val_83;
                int val_147 = this.workingKey[val_149];
                byte val_93 = val_91;
                val_27 = (val_71 & 65535) << 14;
                var val_96 = val_149 + 16;
                val_147 = val_27 - val_147;
                int val_148 = this.workingKey[val_149];
                byte val_98 = val_91;
                byte val_99 = val_147;
                val_149 = val_149 - 4;
                val_72 = val_72 << 15;
            }
            while((val_149 + 16) > 3);
            
            System.Byte[] val_103 = outBytes + (long)outOff;
            mem2[0] = val_72;
            int val_104 = outOff + 1;
            val_104 = outBytes + (long)val_104;
            mem2[0] = val_72 >> 8;
            System.Byte[] val_107 = outBytes + ((long)outOff + 2);
            mem2[0] = val_147;
            int val_108 = outOff + 3;
            val_108 = outBytes + (long)val_108;
            mem2[0] = val_147 >> 8;
            System.Byte[] val_111 = outBytes + ((long)outOff + 4);
            mem2[0] = val_91;
            int val_112 = outOff + 5;
            val_112 = outBytes + (long)val_112;
            mem2[0] = val_91 >> 8;
            System.Byte[] val_115 = outBytes + ((long)outOff + 6);
            mem2[0] = val_83;
            int val_116 = outOff + 7;
            val_116 = outBytes + (long)val_116;
            mem2[0] = val_83 >> 8;
        }
        public RC2Engine()
        {
        
        }
        private static RC2Engine()
        {
            Org.BouncyCastle.Crypto.Engines.RC2Engine.BLOCK_SIZE = new byte[256] {217, 120, 249, 196, 25, 221, 181, 237, 40, 233, 253, 121, 74, 160, 216, 157, 198, 126, 55, 131, 43, 118, 83, 142, 98, 76, 100, 136, 68, 139, 251, 162, 23, 154, 89, 245, 135, 179, 79, 19, 97, 69, 109, 141, 9, 129, 125, 50, 189, 143, 64, 235, 134, 183, 123, 11, 240, 149, 33, 34, 92, 107, 78, 130, 84, 214, 101, 147, 206, 96, 178, 28, 115, 86, 192, 20, 167, 140, 241, 220, 18, 117, 202, 31, 59, 190, 228, 209, 66, 61, 212, 48, 163, 60, 182, 38, 111, 191, 14, 218, 70, 105, 7, 87, 39, 242, 29, 155, 188, 148, 67, 3, 248, 17, 199, 246, 144, 239, 62, 231, 6, 195, 213, 47, 200, 102, 30, 215, 8, 232, 234, 222, 128, 82, 238, 247, 132, 170, 114, 172, 53, 77, 106, 42, 150, 26, 210, 113, 90, 21, 73, 116, 75, 159, 208, 94, 4, 24, 164, 236, 194, 224, 65, 110, 15, 81, 203, 204, 36, 145, 175, 80, 161, 244, 112, 57, 153, 124, 58, 133, 35, 184, 180, 122, 252, 2, 54, 91, 37, 85, 151, 49, 45, 93, 250, 152, 227, 138, 146, 174, 5, 223, 41, 16, 103, 108, 186, 201, 211, 0, 230, 207, 225, 158, 168, 44, 99, 22, 1, 63, 88, 226, 137, 169, 13, 56, 52, 27, 171, 51, 255, 176, 187, 72, 12, 95, 185, 177, 205, 46, 197, 243, 219, 71, 229, 165, 156, 119, 10, 166, 32, 104, 254, 127, 193, 173};
        }
    
    }

}
