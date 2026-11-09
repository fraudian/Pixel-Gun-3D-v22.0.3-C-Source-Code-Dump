using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class Sha256Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 32;
        private uint H1;
        private uint H2;
        private uint H3;
        private uint H4;
        private uint H5;
        private uint H6;
        private uint H7;
        private uint H8;
        private uint[] X;
        private int xOff;
        private static readonly uint[] K;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public Sha256Digest()
        {
            this.X = new uint[64];
            this.H1 = ;
            this.H2 = ;
            this.H3 = 11912009169889063794;
            this.H4 = 2773480762;
            this.H5 = ;
            this.H6 = ;
            this.H7 = 6620516960021240235;
            this.H8 = 1541459225;
        }
        public Sha256Digest(Org.BouncyCastle.Crypto.Digests.Sha256Digest t)
        {
            this.X = new uint[64];
            Org.BouncyCastle.Crypto.Digests.Sha256Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.Sha256Digest t)
        {
            t.CopyIn(t:  t);
            if(t == null)
            {
                goto label_0;
            }
            
            this.H1 = t.H1;
            this.H2 = t.H2;
            this.H3 = t.H3;
            this.H4 = t.H4;
            this.H5 = t.H5;
            this.H6 = t.H6;
            this.H7 = t.H7;
            this.H8 = t.H8;
            if(t.X != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            System.Array.Copy(sourceArray:  t.X, sourceIndex:  0, destinationArray:  this.X, destinationIndex:  0, length:  t.X.Length);
            this.xOff = t.xOff;
            return;
            label_0:
            this.H1 = 135970152;
            this.H2 = 0;
            this.H3 = 0;
            this.H4 = 3670080;
            this.H5 = 4194311;
            this.H6 = 1769500;
            this.H7 = 1;
            this.H8 = 5;
            if(0 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public override string get_AlgorithmName()
        {
            return "SHA-256";
        }
        public override int GetDigestSize()
        {
            return 32;
        }
        internal override void ProcessWord(byte[] input, int inOff)
        {
            var val_8;
            System.UInt32[] val_9;
            val_8 = this;
            val_9 = this.X;
            val_9[(this.xOff) << 2] = Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs:  input, off:  inOff);
            int val_8 = this.xOff;
            val_8 = val_8 + 1;
            this.xOff = val_8;
            if(val_8 != 16)
            {
                    return;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Digests.Sha256Digest).__il2cppRuntimeField_228;
        }
        internal override void ProcessLength(long bitLength)
        {
            this.X[7] = bitLength >> 32;
            this.X[7] = bitLength;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            this.Finish();
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H1, bs:  output, off:  outOff);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H2, bs:  output, off:  outOff + 4);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H3, bs:  output, off:  outOff + 8);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H4, bs:  output, off:  outOff + 12);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H5, bs:  output, off:  outOff + 16);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H6, bs:  output, off:  outOff + 20);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H7, bs:  output, off:  outOff + 24);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n:  this.H8, bs:  output, off:  outOff + 28);
            return 32;
        }
        public override void Reset()
        {
            this.Reset();
            this.xOff = 0;
            this.H1 = ;
            this.H2 = ;
            this.H3 = 11912009169889063794;
            this.H4 = 2773480762;
            this.H5 = ;
            this.H6 = ;
            this.H7 = 6620516960021240235;
            this.H8 = 1541459225;
            System.Array.Clear(array:  this.X, index:  0, length:  this.X.Length);
        }
        private void initHs()
        {
            this.H1 = ;
            this.H2 = ;
            this.H3 = 11912009169889063794;
            this.H4 = 2773480762;
            this.H5 = ;
            this.H6 = ;
            this.H7 = 6620516960021240235;
            this.H8 = 1541459225;
        }
        internal override void ProcessBlock()
        {
            var val_145;
            var val_146;
            var val_147;
            var val_148;
            var val_149;
            var val_150;
            var val_154 = 0;
            do
            {
                var val_1 = val_154 + 14;
                var val_2 = mem[1152921553363344120] + 0;
                var val_151 = (mem[1152921553363344120] + 0) + 88;
                var val_3 = val_154 + 9;
                var val_4 = mem[1152921553363344120] + 0;
                var val_153 = (mem[1152921553363344120] + 0) + 68;
                var val_5 = val_154 + 1;
                var val_7 = mem[1152921553363344120] + 0;
                var val_152 = (mem[1152921553363344120] + 0) + 36;
                var val_11 = val_154 + 16;
                val_151 = ((val_151 >> 19) ^ (val_151 >> 10)) ^ ((((mem[1152921553363344120] + 0) + 88) << (32-17)) | (((mem[1152921553363344120] + 0) + 88) << 17));
                val_152 = ((val_152 >> 18) ^ (val_152 >> 3)) ^ ((((mem[1152921553363344120] + 0) + 36) << (32-7)) | (((mem[1152921553363344120] + 0) + 36) << 7));
                var val_12 = mem[1152921553363344120] + 0;
                var val_13 = val_153 + val_151;
                val_13 = val_13 + val_152;
                val_153 = val_13 + ((mem[1152921553363344120] + 0) + 32);
                var val_14 = mem[1152921553363344120] + 0;
                val_154 = val_154 + 1;
                mem2[0] = val_153;
            }
            while(val_154 != 48);
            
            var val_157 = mem[1152921553363344108];
            var val_155 = mem[1152921553363344104];
            do
            {
                val_145 = null;
                val_145 = null;
                var val_16 = (val_155 >> 6) ^ (((mem[1152921553363344104]) << (32-11)) | ((mem[1152921553363344104]) << 11));
                var val_18 = mem[1152921553363344112] & (~val_155);
                val_155 = val_16 ^ (((mem[1152921553363344104]) << (32-25)) | ((mem[1152921553363344104]) << 25));
                val_18 = val_18 ^ (val_155 & val_157);
                var val_156 = mem[1152921553363344116];
                var val_19 = mem[1152921553363344120] + 0;
                val_156 = val_18 + val_156;
                val_156 = val_156 + val_155;
                val_156 = val_156 + (Org.BouncyCastle.Crypto.Digests.Sha256Digest.K.Length + 32);
                var val_20 = val_156 + ((mem[1152921553363344120] + 0) + 32);
                val_16 = val_20 + mem[1152921553363344100];
                var val_25 = mem[1152921553363344092] & mem[1152921553363344096];
                var val_26 = ((mem[1152921553363344088] >> 2) ^ (((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13))) ^ (((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22));
                var val_27 = 0 + 1;
                val_25 = (mem[1152921553363344092] ^ mem[1152921553363344096] & mem[1152921553363344088]) ^ val_25;
                val_26 = val_26 + val_25;
                val_157 = val_26 + val_20;
                val_20 = ((val_16 >> 6) ^ ((((((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921553363344104] >> 6) ^ ((mem[11529215) << (32-11)) | (((((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921553363344104] >> 6) ^ ((mem[11529215) << 11))) ^ ((((((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921553363344104] >> 6) ^ ((mem[11529215) << (32-25)) | (((((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921553363344104] >> 6) ^ ((mem[11529215) << 25));
                var val_158 = mem[1152921553363344112];
                var val_33 = mem[1152921553363344120] + 0;
                val_158 = ((val_157 & (~val_16)) ^ (val_16 & val_155)) + val_158;
                val_158 = val_158 + val_20;
                val_158 = val_158 + (Org.BouncyCastle.Crypto.Digests.Sha256Digest.K.Length + 36);
                val_20 = val_158 + ((mem[1152921553363344120] + 0) + 36);
                var val_34 = val_20 + mem[1152921553363344096];
                var val_39 = mem[1152921553363344088] & mem[1152921553363344092];
                val_27 = val_27 + 1;
                val_39 = (val_157 & mem[1152921553363344088] ^ mem[1152921553363344092]) ^ val_39;
                val_146 = mem[Org.BouncyCastle.Crypto.Digests.Sha256Digest.K.Length + 40];
                val_146 = Org.BouncyCastle.Crypto.Digests.Sha256Digest.K.Length + 40;
                val_39 = (((val_157 >> 2) ^ ((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22)) + (() << (32-13)) | (((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22)) + (() << 13))) ^ ((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22)) + (() << (32-22)) | (((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22)) + (() << 22))) + val_39;
                var val_43 = val_34 & val_16;
                if(mem[1152921553363344120] == 0)
            {
                    val_146 = val_146;
            }
            
                var val_45 = val_39 + val_20;
                val_20 = ((val_34 >> 6) ^ ((((((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921) << (32-11)) | (((((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921) << 11))) ^ ((((((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921) << (32-25)) | (((((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921) << 25));
                val_43 = (val_155 & (~val_34)) ^ val_43;
                if(val_27 >= (mem[1152921553363344120] + 24))
            {
                    var val_160 = val_146;
                val_146 = val_160;
            }
            
                var val_159 = val_157;
                var val_46 = mem[1152921553363344120] + 0;
                val_159 = val_43 + val_159;
                val_159 = val_159 + val_20;
                val_159 = val_159 + val_146;
                val_20 = val_159 + ((mem[1152921553363344120] + 0) + 40);
                val_160 = val_20 + mem[1152921553363344092];
                var val_48 = (val_45 >> 2) ^ (((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22))) << (32-13)) | ((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22))) << 13));
                var val_51 = val_157 & mem[1152921553363344088];
                val_27 = val_27 + 1;
                val_48 = val_48 ^ (((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22))) << (32-22)) | ((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) << 22))) << 22));
                val_51 = (val_45 & val_157 ^ mem[1152921553363344088]) ^ val_51;
                var val_52 = val_160 >> 6;
                val_147 = mem[Org.BouncyCastle.Crypto.Digests.Sha256Digest.K.Length + 44];
                val_147 = Org.BouncyCastle.Crypto.Digests.Sha256Digest.K.Length + 44;
                val_51 = val_48 + val_51;
                val_52 = val_52 ^ ((((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[11) << (32-11)) | (((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[11) << 11));
                if(mem[1152921553363344120] == 0)
            {
                    val_147 = val_147;
            }
            
                var val_55 = val_51;
                val_52 = val_52 ^ ((((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[11) << (32-25)) | (((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[11) << 25));
                if(val_27 >= (mem[1152921553363344120] + 24))
            {
                    var val_162 = val_147;
                val_147 = val_162;
            }
            
                var val_161 = val_155;
                var val_57 = mem[1152921553363344120] + 0;
                val_161 = ((val_16 & (~val_160)) ^ (val_160 & val_34)) + val_161;
                val_161 = val_161 + val_52;
                val_161 = val_161 + val_147;
                val_162 = val_161 + ((mem[1152921553363344120] + 0) + 44);
                val_20 = val_162 + mem[1152921553363344088];
                var val_62 = val_45 & val_157;
                val_27 = val_27 + 1;
                val_62 = (val_55 & val_45 ^ val_157) ^ val_62;
                val_148 = 0;
                var val_67 = val_20 & val_160;
                if(mem[1152921553363344120] == 0)
            {
                    val_148 = val_148;
            }
            
                var val_69 = ((val_55 >> 2) ^ ((((((((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) <<) << (32-13)) | (((((((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) <<) << 13))) ^ ((((((((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) <<) << (32-22)) | (((((((((((((((((mem[1152921553363344088] >> 2) ^ ((mem[1152921553363344088]) << (32-13)) | ((mem[1152921553363344088]) << 13)) ^ ((mem[1152921553363344088]) << (32-22)) | ((mem[1152921553363344088]) <<) << 22));
                val_162 = (val_20 >> 6) ^ (((((((((((((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921553363344104] >> 6) ^ ((mem[1) << (32-11)) | ((((((((((((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) + mem[1152921553363344116]) + (((mem[1152921553363344104] >> 6) ^ ((mem[1) << 11));
                if(val_27 >= (mem[1152921553363344120] + 24))
            {
                    val_148 = val_148;
            }
            
                var val_163 = val_16;
                var val_71 = mem[1152921553363344120] + 0;
                val_163 = (val_34 & (~val_20)) + val_163;
                var val_74 = val_163;
                var val_77 = val_74;
                var val_78 = val_55 ^ val_45;
                var val_80 = val_55 & val_45;
                val_27 = val_27 + 1;
                var val_82 = val_69;
                val_149 = 3670080;
                var val_86 = val_77;
                if(mem[1152921553363344120] == 0)
            {
                    val_149 = val_149;
            }
            
                var val_88 = val_69 >> 2;
                val_74 = val_77 >> 6;
                if(val_27 >= (mem[1152921553363344120] + 24))
            {
                    val_149 = val_149;
            }
            
                var val_164 = val_34;
                var val_90 = mem[1152921553363344120] + 0;
                val_164 = val_160 + val_164;
                var val_91 = val_164;
                val_91 = val_91 + val_149;
                var val_92 = val_91 + ((mem[1152921553363344120] + 0) + 52);
                var val_95 = val_92;
                var val_96 = val_69;
                var val_98 = val_69;
                val_27 = val_27 + 1;
                var val_100 = val_88;
                var val_104 = val_95;
                var val_106 = val_88 >> 2;
                val_92 = ((val_95 >> 6) ^ (((((((((((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) +) << (32-11)) | ((((((((((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) +) << 11))) ^ (((((((((((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) +) << (32-25)) | ((((((((((((((((mem[1152921553363344104] & (~(((((((mem[1152921553363344108] & (~(((((((mem[1152921553363344112] & (~mem[1152921553363344104])) ^ (mem[1152921553363344104] & mem[1152921553363344108])) +) << 25));
                var val_165 = val_160;
                var val_108 = mem[1152921553363344120] + 0;
                val_165 = val_20 + val_165;
                var val_112 = val_165;
                var val_115 = val_88;
                var val_117 = val_88;
                val_27 = val_27 + 1;
                var val_119 = val_106;
                val_150 = 1769500;
                var val_123 = val_112;
                if(mem[1152921553363344120] == 0)
            {
                    val_150 = val_150;
            }
            
                var val_125 = val_106 >> 2;
                var val_126 = val_112 >> 6;
                if(val_27 >= (mem[1152921553363344120] + 24))
            {
                    val_150 = val_150;
            }
            
                var val_129 = mem[1152921553363344120] + 0;
                var val_133 = val_106;
                var val_135 = val_106;
                var val_139 = val_125;
                var val_140 = val_27 + 1;
                var val_142 = val_77;
                var val_143 = val_125 >> 2;
            }
            while(0 != 56);
            
            var val_166 = mem[1152921553363344112];
            val_166 = val_166 + val_95;
            mem[1152921553363344088] = mem[1152921553363344088];
            mem[1152921553363344092] = mem[1152921553363344092];
            mem[1152921553363344096] = mem[1152921553363344096];
            mem[1152921553363344100] = mem[1152921553363344100];
            mem[1152921553363344104] = mem[1152921553363344104];
            mem[1152921553363344108] = mem[1152921553363344108];
            mem[1152921553363344112] = val_166;
            mem[1152921553363344116] = mem[1152921553363344116];
            mem[1152921553363344128] = 0;
            System.Array.Clear(array:  mem[1152921553363344120], index:  0, length:  16);
        }
        private static uint Sum1Ch(uint x, uint y, uint z)
        {
            uint val_1 = x >> 6;
            uint val_2 = y & x;
            val_1 = val_1 ^ (((x) << (32-11)) | ((x) << 11));
            val_1 = val_1 ^ (((x) << (32-25)) | ((x) << 25));
            val_2 = (z & (~x)) ^ val_2;
            x = val_2 + val_1;
            return (uint)x;
        }
        private static uint Sum0Maj(uint x, uint y, uint z)
        {
            uint val_1 = x >> 2;
            uint val_2 = z ^ y;
            val_1 = val_1 ^ (((x) << (32-13)) | ((x) << 13));
            val_2 = val_2 & x;
            val_1 = val_1 ^ (((x) << (32-22)) | ((x) << 22));
            val_2 = val_2 ^ (z & y);
            x = val_2 + val_1;
            return (uint)x;
        }
        private static uint Theta0(uint x)
        {
            uint val_1 = x >> 18;
            val_1 = val_1 ^ (x >> 3);
            x = val_1 ^ (((x) << (32-7)) | ((x) << 7));
            return (uint)x;
        }
        private static uint Theta1(uint x)
        {
            uint val_1 = x >> 19;
            val_1 = val_1 ^ (x >> 10);
            x = val_1 ^ (((x) << (32-17)) | ((x) << 17));
            return (uint)x;
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.Sha256Digest(t:  this);
        }
        public override void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            Org.BouncyCastle.Utilities.IMemoable val_3 = other;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.CopyIn(t:  val_3);
        }
        private static Sha256Digest()
        {
            Org.BouncyCastle.Crypto.Digests.Sha256Digest.K = new uint[64] {1116352408, 1899447441, -1245643825, -373957723, 961987163, 1508970993, -1841331548, -1424204075, -670586216, 310598401, 607225278, 1426881987, 1925078388, -2132889090, -1680079193, -1046744716, -459576895, -272742522, 264347078, 604807628, 770255983, 1249150122, 1555081692, 1996064986, -1740746414, -1473132947, -1341970488, -1084653625, -958395405, -710438585, 113926993, 338241895, 666307205, 773529912, 1294757372, 1396182291, 1695183700, 1986661051, -2117940946, -1838011259, -1564481375, -1474664885, -1035236496, -949202525, -778901479, -694614492, -200395387, 275423344, 430227734, 506948616, 659060556, 883997877, 958139571, 1322822218, 1537002063, 1747873779, 1955562222, 2024104815, -2067236844, -1933114872, -1866530822, -1538233109, -1090935817, -965641998};
        }
    
    }

}
