using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class Sha1Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 20;
        private uint H1;
        private uint H2;
        private uint H3;
        private uint H4;
        private uint H5;
        private uint[] X;
        private int xOff;
        private const uint Y1 = 1518500249;
        private const uint Y2 = 1859775393;
        private const uint Y3 = 2400959708;
        private const uint Y4 = 3395469782;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public Sha1Digest()
        {
            this.X = new uint[80];
            goto typeof(Org.BouncyCastle.Crypto.Digests.Sha1Digest).__il2cppRuntimeField_1F8;
        }
        public Sha1Digest(Org.BouncyCastle.Crypto.Digests.Sha1Digest t)
        {
            this.X = new uint[80];
            Org.BouncyCastle.Crypto.Digests.Sha1Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.Sha1Digest t)
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
            if(1 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public override string get_AlgorithmName()
        {
            return "SHA-1";
        }
        public override int GetDigestSize()
        {
            return 20;
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
            goto typeof(Org.BouncyCastle.Crypto.Digests.Sha1Digest).__il2cppRuntimeField_228;
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
            return 20;
        }
        public override void Reset()
        {
            this.Reset();
            this.H5 = -1009589776;
            this.H1 = ;
            this.H2 = ;
            this.H3 = 1167088121787636990;
            this.H4 = 271733878;
            this.xOff = 0;
            System.Array.Clear(array:  this.X, index:  0, length:  this.X.Length);
        }
        private static uint F(uint u, uint v, uint w)
        {
            u = (w & (~u)) | (v & u);
            return (uint)u;
        }
        private static uint H(uint u, uint v, uint w)
        {
            u = v ^ u ^ w;
            return (uint)u;
        }
        private static uint G(uint u, uint v, uint w)
        {
            uint val_1 = w | v;
            val_1 = val_1 & u;
            u = val_1 | (w & v);
            return (uint)u;
        }
        internal override void ProcessBlock()
        {
            var val_155;
            var val_156;
            var val_157;
            var val_158;
            var val_159;
            var val_170 = 0;
            do
            {
                var val_1 = val_170 + 13;
                var val_2 = mem[1152921553358317040] + 0;
                var val_169 = (mem[1152921553358317040] + 0) + 84;
                var val_3 = val_170 + 8;
                var val_4 = mem[1152921553358317040] + 0;
                var val_5 = val_170 + 2;
                var val_6 = mem[1152921553358317040] + 0;
                var val_7 = mem[1152921553358317040] + 0;
                var val_8 = val_170 + 16;
                var val_9 = ((mem[1152921553358317040] + 0) + 64) ^ val_169;
                val_9 = val_9 ^ ((mem[1152921553358317040] + 0) + 40);
                val_169 = val_9 ^ ((mem[1152921553358317040] + 0) + 32);
                val_169 = val_169 >> 31;
                var val_10 = mem[1152921553358317040] + 0;
                val_170 = val_170 + 1;
                mem2[0] = val_169;
            }
            while(val_170 != 64);
            
            val_155 = 0;
            var val_173 = mem[1152921553358317016];
            var val_171 = mem[1152921553358317020];
            do
            {
                var val_12 = mem[1152921553358317028] & (~val_171);
                if(mem[1152921553358317040] == 0)
            {
                    val_155 = val_155;
            }
            
                val_12 = val_12 | (val_171 & mem[1152921553358317024]);
                if(val_155 >= (mem[1152921553358317040] + 24))
            {
                    val_155 = val_155;
            }
            
                var val_13 = mem[1152921553358317040] + 0;
                var val_15 = val_173 >> 27;
                val_15 = (mem[1152921553358317032] + val_12) + val_15;
                var val_16 = val_173 & (((mem[1152921553358317020]) << (32-2)) | ((mem[1152921553358317020]) << 2));
                var val_17 = val_15 + ((mem[1152921553358317040] + 0) + 32);
                if(mem[1152921553358317040] == 0)
            {
                    val_155 = val_155;
            }
            
                var val_19 = val_155 + 1;
                val_17 = val_17 + 1518500249;
                val_156 = val_171 >> 2;
                val_16 = val_16 | (mem[1152921553358317024] & (~val_173));
                if(val_19 >= (mem[1152921553358317040] + 24))
            {
                    val_156 = val_156;
                val_155 = val_155;
            }
            
                var val_20 = mem[1152921553358317040] + 0;
                var val_172 = (mem[1152921553358317040] + 0) + 36;
                val_15 = val_17 >> 27;
                val_171 = ((mem[1152921553358317028] + 1518500249) + val_16) + val_15;
                var val_24 = val_156 & (~val_17);
                if(mem[1152921553358317040] == 0)
            {
                    val_156 = val_156;
                val_155 = val_155;
            }
            
                val_19 = val_19 + 1;
                val_172 = val_171 + val_172;
                val_173 = val_173 >> 2;
                val_24 = val_24 | (val_17 & (((mem[1152921553358317016]) << (32-2)) | ((mem[1152921553358317016]) << 2)));
                if(val_19 >= (mem[1152921553358317040] + 24))
            {
                    val_156 = val_156;
                val_155 = val_155;
            }
            
                var val_25 = mem[1152921553358317040] + 0;
                var val_174 = (mem[1152921553358317040] + 0) + 40;
                val_15 = val_172 >> 27;
                val_24 = ((mem[1152921553358317024] + 1518500249) + val_24) + val_15;
                val_173 = val_173 & (~val_172);
                if(mem[1152921553358317040] == 0)
            {
                    val_156 = val_156;
                val_155 = val_155;
            }
            
                val_174 = val_24 + val_174;
                var val_29 = val_19 + 1;
                var val_30 = val_17 >> 2;
                val_17 = val_173 | (val_172 & (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[1152921553358317024]))) + (mem[1152921553358317016] >> 27)) + (mem[1152921553) << (32-2)) | ((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[1152921553358317024]))) + (mem[1152921553358317016] >> 27)) + (mem[1152921553) << 2)));
                if(val_29 >= (mem[1152921553358317040] + 24))
            {
                    val_156 = val_156;
                val_155 = val_155;
            }
            
                var val_31 = mem[1152921553358317040] + 0;
                var val_175 = (mem[1152921553358317040] + 0) + 44;
                val_15 = val_174 >> 27;
                val_173 = ((val_156 + 1518500249) + val_17) + val_15;
                var val_34 = val_174 & (((((((mem[1152921553358317028] + 1518500249) + ((mem[1152921553358317016] & ((mem[1152921553358317020]) << (32-2)) | ((mem[1152921553358317020]) << 2)) | (mem[1152921553358317024] & (~mem[11529215533583) << (32-2)) | ((((((mem[1152921553358317028] + 1518500249) + ((mem[1152921553358317016] & ((mem[1152921553358317020]) << (32-2)) | ((mem[1152921553358317020]) << 2)) | (mem[1152921553358317024] & (~mem[11529215533583) << 2));
                if(mem[1152921553358317040] == 0)
            {
                    val_155 = val_155;
            }
            
                val_29 = val_29 + 1;
                val_175 = val_173 + val_175;
                val_172 = val_172 >> 2;
                val_34 = (val_30 & (~val_174)) | val_34;
                if(val_29 >= (mem[1152921553358317040] + 24))
            {
                    val_155 = val_155;
            }
            
                var val_176 = val_173;
                var val_37 = mem[1152921553358317040] + 0;
                val_176 = val_176 + 1518500249;
                val_15 = val_175 >> 27;
                val_176 = val_176 + val_34;
                val_15 = val_176 + val_15;
                val_174 = val_174 >> 2;
                val_173 = val_15 + ((mem[1152921553358317040] + 0) + 48);
                var val_38 = val_29 + 1;
            }
            while((val_155 + 5) != 20);
            
            var val_178 = 0;
            do
            {
                var val_39 = val_178 + 20;
                var val_42 = mem[1152921553358317040] + 0;
                val_15 = val_173 >> 27;
                val_15 = (val_30 + val_174 ^ val_172 ^ val_175) + val_15;
                var val_44 = val_15 + ((mem[1152921553358317040] + 0) + 112);
                val_157 = val_175 >> 2;
                val_175 = val_173 ^ val_174 ^ ((((((((mem[1152921553358317020] >> 2) + 1518500249) + (((mem[1152921553358317016] >> 2) & (~((((mem[1152921553358317028] + 1518500249) + ((mem[1152921553358317016] & ((mem[1152921553358317020]) << (32-2) << (32-2)) | (((((((mem[1152921553358317020] >> 2) + 1518500249) + (((mem[1152921553358317016] >> 2) & (~((((mem[1152921553358317028] + 1518500249) + ((mem[1152921553358317016] & ((mem[1152921553358317020]) << (32-2) << 2));
                val_39 = val_39 + 1;
                val_44 = val_44 + 1859775393;
                if(val_39 >= (mem[1152921553358317040] + 24))
            {
                    val_157 = val_157;
            }
            
                var val_46 = mem[1152921553358317040] + 0;
                var val_47 = val_172 + 1859775393;
                val_15 = val_44 >> 27;
                val_47 = val_47 + val_175;
                var val_48 = val_47;
                if(mem[1152921553358317040] == 0)
            {
                    val_157 = val_157;
            }
            
                var val_50 = val_39 + 1;
                val_48 = val_48 + ((mem[1152921553358317040] + 0) + 116);
                var val_51 = val_173 >> 2;
                var val_52 = (val_157 ^ ((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[1152921553358317024]))) << (32-2)) | (((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[1152921553358317024]))) << 2))) ^ val_44;
                if(val_50 >= (mem[1152921553358317040] + 24))
            {
                    val_157 = val_157;
            }
            
                var val_53 = mem[1152921553358317040] + 0;
                var val_55 = val_48 >> 27;
                val_174 = (val_174 + 1859775393) + val_55;
                if(mem[1152921553358317040] == 0)
            {
                    val_157 = val_157;
            }
            
                var val_58 = val_50 + 1;
                var val_59 = val_44 >> 2;
                val_174 = val_174 + ((mem[1152921553358317040] + 0) + 120);
                var val_60 = (val_51 ^ ((((((((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[1152921553358317024]))) + (mem[1152921553358317016] >> 27)) + (mem[11529) << (32-2)) | (((((((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[1152921553358317024]))) + (mem[1152921553358317016] >> 27)) + (mem[11529) << 2))) ^ val_48;
                if(val_58 >= (mem[1152921553358317040] + 24))
            {
                    val_157 = val_157;
            }
            
                var val_61 = mem[1152921553358317040] + 0;
                var val_177 = (mem[1152921553358317040] + 0) + 124;
                val_55 = val_174 >> 27;
                var val_67 = val_58 + 1;
                val_177 = (val_157 + 1859775393) + val_177;
                var val_68 = val_59 ^ ((((((((((((mem[1152921553358317028] + 1518500249) + ((mem[1152921553358317016] & ((mem[1152921553358317020]) << (32-2)) | ((mem[1152921553358317020]) << 2)) | (mem[1152921553358317024] & (~mem[115292155) << (32-2)) | (((((((((((mem[1152921553358317028] + 1518500249) + ((mem[1152921553358317016] & ((mem[1152921553358317020]) << (32-2)) | ((mem[1152921553358317020]) << 2)) | (mem[1152921553358317024] & (~mem[115292155) << 2));
                var val_69 = mem[1152921553358317040] + 0;
                var val_71 = val_177 >> 27;
                val_178 = val_178 + 5;
                val_71 = (val_51 + 1859775393) + val_71;
                var val_73 = val_71 + ((mem[1152921553358317040] + 0) + 128);
                val_174 = val_174 >> 2;
            }
            while(val_178 != 20);
            
            var val_182 = 0;
            do
            {
                var val_74 = val_182 + 40;
                var val_75 = val_174;
                var val_78 = val_174;
                var val_79 = mem[1152921553358317040] + 0;
                val_71 = val_73 >> 27;
                var val_82 = val_59;
                var val_85 = val_174;
                val_74 = val_74 + 1;
                var val_86 = val_82 + ((mem[1152921553358317040] + 0) + 192);
                val_158 = val_177 >> 2;
                var val_87 = val_174;
                if(val_74 >= (mem[1152921553358317040] + 24))
            {
                    val_158 = val_158;
            }
            
                var val_179 = val_48 >> 2;
                var val_88 = mem[1152921553358317040] + 0;
                val_82 = val_86 >> 27;
                val_179 = val_179 + 2400959708;
                var val_180 = (mem[1152921553358317040] + 0) + 196;
                var val_91 = val_158 | (((((((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[11529215533583170) << (32-2)) | ((((((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[11529215533583170) << 2));
                var val_93 = val_158 & (((((((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[11529215533583170) << (32-2)) | ((((((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[11529215533583170) << 2));
                if(mem[1152921553358317040] == 0)
            {
                    val_158 = val_158;
            }
            
                val_74 = val_74 + 1;
                val_180 = val_179 + val_180;
                var val_94 = val_73 >> 2;
                var val_95 = val_86;
                if(val_74 >= (mem[1152921553358317040] + 24))
            {
                    val_158 = val_158;
            }
            
                var val_96 = mem[1152921553358317040] + 0;
                var val_98 = val_180 >> 27;
                var val_101 = val_94;
                var val_103 = val_94;
                if(mem[1152921553358317040] == 0)
            {
                    val_158 = val_158;
            }
            
                val_74 = val_74 + 1;
                val_86 = val_86 >> 2;
                var val_104 = val_174;
                var val_105 = val_180;
                if(val_74 >= (mem[1152921553358317040] + 24))
            {
                    val_158 = val_158;
            }
            
                var val_106 = mem[1152921553358317040] + 0;
                var val_181 = (mem[1152921553358317040] + 0) + 204;
                var val_108 = val_104 >> 27;
                var val_111 = val_86;
                var val_113 = val_86;
                var val_114 = val_74 + 1;
                val_181 = (val_158 + 2400959708) + val_181;
                val_180 = val_180 >> 2;
                var val_115 = val_104;
                var val_116 = mem[1152921553358317040] + 0;
                var val_117 = val_181 >> 27;
                val_182 = val_182 + 5;
                var val_120 = val_94;
                var val_121 = val_120;
                val_104 = val_104 >> 2;
            }
            while(val_182 != 20);
            
            var val_184 = 0;
            do
            {
                var val_122 = val_184 + 60;
                var val_124 = val_104;
                var val_125 = mem[1152921553358317040] + 0;
                val_120 = val_121 >> 27;
                var val_127 = val_86;
                val_159 = val_181 >> 2;
                var val_130 = val_121;
                val_122 = val_122 + 1;
                var val_131 = val_127;
                if(val_122 >= (mem[1152921553358317040] + 24))
            {
                    val_159 = val_159;
            }
            
                var val_132 = mem[1152921553358317040] + 0;
                val_127 = val_131 >> 27;
                if(mem[1152921553358317040] == 0)
            {
                    val_159 = val_159;
            }
            
                var val_137 = val_122 + 1;
                var val_138 = val_180;
                var val_139 = val_121 >> 2;
                var val_140 = val_159 ^ ((((((((((((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[115292155335) << (32-2)) | (((((((((((((((((mem[1152921553358317016] >> 2) + 1518500249) + (((((((mem[1152921553358317032] + ((mem[1152921553358317028] & (~mem[1152921553358317020])) | (mem[1152921553358317020] & mem[115292155335) << 2));
                if(val_137 >= (mem[1152921553358317040] + 24))
            {
                    val_159 = val_159;
            }
            
                var val_141 = mem[1152921553358317040] + 0;
                var val_143 = val_138 >> 27;
                val_104 = val_104;
                if(mem[1152921553358317040] == 0)
            {
                    val_159 = val_159;
            }
            
                var val_146 = val_137 + 1;
                var val_148 = val_104;
                var val_149 = val_139;
                if(val_146 >= (mem[1152921553358317040] + 24))
            {
                    val_159 = val_159;
            }
            
                var val_150 = mem[1152921553358317040] + 0;
                var val_183 = (mem[1152921553358317040] + 0) + 284;
                var val_152 = val_148 >> 27;
                var val_156 = val_138 >> 2;
                var val_157 = val_146 + 1;
                val_183 = (val_159 + 3395469782) + val_183;
                var val_158 = val_131 >> 2;
                var val_159 = mem[1152921553358317040] + 0;
                var val_161 = val_183 >> 27;
                val_184 = val_184 + 5;
                var val_164 = val_139;
                val_148 = val_148 >> 2;
            }
            while(val_184 != 20);
            
            var val_185 = mem[1152921553358317020];
            mem[1152921553358317048] = 0;
            val_185 = val_185 + val_183;
            mem[1152921553358317016] = mem[1152921553358317016];
            mem[1152921553358317020] = val_185;
            mem[1152921553358317024] = mem[1152921553358317024];
            mem[1152921553358317028] = mem[1152921553358317028];
            mem[1152921553358317032] = mem[1152921553358317032];
            System.Array.Clear(array:  mem[1152921553358317040], index:  0, length:  16);
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.Sha1Digest(t:  this);
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
    
    }

}
