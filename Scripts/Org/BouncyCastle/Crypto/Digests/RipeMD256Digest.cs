using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class RipeMD256Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 32;
        private int H0;
        private int H1;
        private int H2;
        private int H3;
        private int H4;
        private int H5;
        private int H6;
        private int H7;
        private int[] X;
        private int xOff;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public override string get_AlgorithmName()
        {
            return "RIPEMD256";
        }
        public override int GetDigestSize()
        {
            return 32;
        }
        public RipeMD256Digest()
        {
            this.X = new int[16];
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD256Digest).__il2cppRuntimeField_1F8;
        }
        public RipeMD256Digest(Org.BouncyCastle.Crypto.Digests.RipeMD256Digest t)
        {
            this.X = new int[16];
            Org.BouncyCastle.Crypto.Digests.RipeMD256Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.RipeMD256Digest t)
        {
            t.CopyIn(t:  t);
            if(t == null)
            {
                goto label_0;
            }
            
            this.H0 = t.H0;
            this.H1 = t.H1;
            this.H2 = t.H2;
            this.H3 = t.H3;
            this.H4 = t.H4;
            this.H5 = t.H5;
            this.H6 = t.H6;
            this.H7 = t.H7;
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
            this.H0 = 135970152;
            this.H1 = 0;
            this.H2 = 0;
            this.H3 = 3670080;
            this.H4 = 4194311;
            this.H5 = 1769500;
            this.H6 = 1;
            this.H7 = 5;
            if(0 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        internal override void ProcessWord(byte[] input, int inOff)
        {
            var val_15;
            System.Int32[] val_16;
            int val_17;
            byte val_18;
            var val_19;
            val_15 = this;
            val_16 = this.X;
            this.xOff = this.xOff + 1;
            val_17 = input.Length;
            if(val_17 <= inOff)
            {
                    val_17 = input.Length;
            }
            
            int val_2 = inOff + 1;
            if(val_2 >= val_17)
            {
                    val_17 = input.Length;
            }
            
            val_18 = input[(long)val_2];
            int val_3 = inOff + 2;
            if(val_3 >= val_17)
            {
                    val_17 = input.Length;
            }
            
            byte val_16 = input[(long)val_3];
            val_19 = (long)inOff + 3;
            byte val_17 = input[val_19];
            val_16[this.xOff] = input[(long)inOff];
            if(this.xOff != 16)
            {
                    return;
            }
            
            val_15 = ???;
            val_19 = ???;
            val_16 = ???;
            val_18 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD256Digest).__il2cppRuntimeField_228;
        }
        internal override void ProcessLength(long bitLength)
        {
            long val_1 = bitLength;
            this.X[14] = val_1;
            val_1 = val_1 >> 32;
            this.X[15] = val_1;
        }
        private void UnpackWord(int word, byte[] outBytes, int outOff)
        {
            outBytes[(long)outOff] = word;
            outBytes[(long)outOff + 1] = word >> 8;
            outBytes[(long)outOff + 2] = word >> 16;
            outBytes[(long)outOff + 3] = word >> 24;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            this.Finish();
            this.UnpackWord(word:  this.H0, outBytes:  output, outOff:  outOff);
            this.UnpackWord(word:  this.H1, outBytes:  output, outOff:  outOff + 4);
            this.UnpackWord(word:  this.H2, outBytes:  output, outOff:  outOff + 8);
            this.UnpackWord(word:  this.H3, outBytes:  output, outOff:  outOff + 12);
            this.UnpackWord(word:  this.H4, outBytes:  output, outOff:  outOff + 16);
            this.UnpackWord(word:  this.H5, outBytes:  output, outOff:  outOff + 20);
            this.UnpackWord(word:  this.H6, outBytes:  output, outOff:  outOff + 24);
            this.UnpackWord(word:  this.H7, outBytes:  output, outOff:  outOff + 28);
            return 32;
        }
        public override void Reset()
        {
            var val_1;
            this.Reset();
            val_1 = 0;
            this.xOff = 0;
            this.H0 = ;
            this.H1 = ;
            this.H2 = 1167088121787636990;
            this.H3 = 271733878;
            this.H4 = ;
            this.H5 = ;
            this.H6 = 81985529216486895;
            this.H7 = 19088743;
            goto label_0;
            label_4:
            val_1 = 1;
            this.X[0] = 0;
            label_0:
            if(val_1 != this.X.Length)
            {
                goto label_4;
            }
        
        }
        private int RL(int x, int n)
        {
            var val_2 = -n;
            val_2 = val_2 & 31;
            return (int)x >> val_2;
        }
        private int F1(int x, int y, int z)
        {
            return (int)y ^ x ^ z;
        }
        private int F2(int x, int y, int z)
        {
            return (int)(z & (~x)) | (y & x);
        }
        private int F3(int x, int y, int z)
        {
            return (int)(x | (~y)) ^ z;
        }
        private int F4(int x, int y, int z)
        {
            return (int)(z & x) | (y & (~z));
        }
        private int F1(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = c ^ b;
            val_1 = val_1 ^ d;
            var val_3 = -s;
            val_1 = val_1 + a;
            val_1 = val_1 + x;
            val_3 = val_3 & 31;
            return (int)val_1 >> val_3;
        }
        private int F2(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = c & b;
            val_1 = (d & (~b)) | val_1;
            val_1 = (a + x) + val_1;
            val_1 = val_1 + 1518500249;
            return (int)val_1 >> ((-s) & 31);
        }
        private int F3(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = b | (~c);
            val_1 = val_1 ^ d;
            val_1 = a + val_1;
            val_1 = val_1 + x;
            val_1 = val_1 + 1859775393;
            return (int)val_1 >> ((-s) & 31);
        }
        private int F4(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = d & b;
            val_1 = val_1 | (c & (~d));
            val_1 = (a + x) + val_1;
            val_1 = val_1 + 2400959708;
            return (int)val_1 >> ((-s) & 31);
        }
        private int FF1(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = c ^ b;
            val_1 = val_1 ^ d;
            var val_3 = -s;
            val_1 = val_1 + a;
            val_1 = val_1 + x;
            val_3 = val_3 & 31;
            return (int)val_1 >> val_3;
        }
        private int FF2(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = c & b;
            val_1 = (d & (~b)) | val_1;
            val_1 = (a + x) + val_1;
            val_1 = val_1 + 1836072691;
            return (int)val_1 >> ((-s) & 31);
        }
        private int FF3(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = b | (~c);
            val_1 = val_1 ^ d;
            val_1 = a + val_1;
            val_1 = val_1 + x;
            val_1 = val_1 + 1548603684;
            return (int)val_1 >> ((-s) & 31);
        }
        private int FF4(int a, int b, int c, int d, int x, int s)
        {
            int val_1 = d & b;
            val_1 = val_1 | (c & (~d));
            val_1 = (a + x) + val_1;
            val_1 = val_1 + 1352829926;
            return (int)val_1 >> ((-s) & 31);
        }
        internal override void ProcessBlock()
        {
            var val_634;
            int val_634 = this.X[0];
            int val_1 = this.H2 ^ this.H1;
            int val_635 = this.X[1];
            val_634 = (val_1 ^ this.H3 + this.H0) + val_634;
            int val_4 = val_634 >> 21;
            int val_636 = this.X[2];
            val_1 = val_1 ^ val_4;
            val_1 = val_1 + this.H3;
            int val_637 = this.X[3];
            val_635 = (val_1 + val_635) >> 18;
            int val_6 = val_4 ^ this.H1;
            val_6 = val_6 ^ val_635;
            val_6 = val_6 + this.H2;
            val_636 = (val_6 + val_636) >> 17;
            int val_8 = val_635 ^ val_4;
            val_8 = val_8 ^ val_636;
            val_8 = val_8 + this.H1;
            val_637 = (val_8 + val_637) >> 20;
            int val_10 = val_636 ^ val_635;
            val_4 = val_10 ^ val_637 + val_4;
            val_4 = (val_4 + this.X[4]) >> 27;
            int val_13 = val_637 ^ val_636;
            val_13 = val_13 ^ val_4 + val_635;
            int val_645 = this.X[11];
            val_10 = (val_13 + this.X[5]) >> 24;
            int val_16 = val_4 ^ val_637;
            int val_646 = this.X[12];
            val_16 = val_16 ^ val_10 + val_636;
            int val_647 = this.X[13];
            int val_654 = this.H7;
            val_635 = (val_16 + this.X[6]) >> 25;
            int val_19 = val_10 ^ val_4;
            int val_648 = this.X[14];
            val_19 = val_19 ^ val_635 + val_637;
            int val_649 = this.X[15];
            val_19 = (val_19 + this.X[7]) >> 23;
            int val_651 = this.H6;
            int val_23 = val_654 & this.H5;
            int val_650 = this.X[5];
            val_651 = val_651 & (~val_654);
            val_23 = val_23 | val_651;
            val_19 = val_635 ^ val_10 ^ val_19;
            val_23 = this.H4 + val_23;
            val_650 = val_23 + val_650;
            int val_26 = (val_650 + 1352829926) >> 24;
            int val_652 = this.H6;
            val_23 = val_26 & val_652;
            val_652 = this.H5 & (~val_652);
            int val_27 = (val_19 + val_4) + this.X[8];
            val_23 = val_23 | val_652;
            System.Int32[] val_656 = this.X;
            val_23 = (val_654 + 1352829926) + val_23;
            val_27 = val_27 >> 21;
            val_654 = (val_23 + this.X[14]) >> 23;
            int val_31 = val_654 & this.H5;
            val_31 = val_31 | (val_26 & (~this.H5));
            val_27 = val_19 ^ val_635 ^ val_27;
            System.Int32[] val_658 = this.X;
            val_31 = (this.H6 + 1352829926) + val_31;
            val_656 = val_31 + val_656[7];
            val_27 = val_27 + val_10;
            val_656 = val_656 >> 23;
            val_31 = val_656 & val_26;
            val_31 = val_31 | (val_654 & (~val_26));
            val_10 = val_27 + this.X[9];
            System.Int32[] val_660 = this.X;
            val_31 = (this.H5 + 1352829926) + val_31;
            val_658 = val_31 + val_658[0];
            val_10 = val_10 >> 19;
            val_658 = val_658 >> 21;
            int val_37 = val_658 & val_654;
            val_37 = val_37 | (val_656 & (~val_654));
            int val_39 = val_27 ^ val_19;
            val_37 = (val_26 + 1352829926) + val_37;
            int val_41 = val_37 + val_660[9];
            val_660 = val_41 >> 19;
            val_37 = val_660 & val_656;
            val_37 = val_37 | (val_658 & (~val_656));
            val_635 = (val_39 + val_635) + this.X[10];
            val_37 = (val_654 + 1352829926) + val_37;
            val_41 = val_37 + this.X[2];
            val_39 = val_635 >> 18;
            val_654 = val_41 >> 17;
            int val_46 = val_654 & val_658;
            val_46 = val_46 | (val_660 & (~val_658));
            val_46 = (val_656 + 1352829926) + val_46;
            val_41 = val_46 + this.X[11];
            int val_50 = val_41 >> 17;
            int val_52 = val_50 & val_660;
            val_52 = val_52 | (val_654 & (~val_660));
            val_10 = val_10;
            int val_58 = ((val_658 + 1352829926) + this.X[4]) >> 27;
            int val_61 = val_50 & (~val_654);
            int val_664 = this.X[13];
            int val_62 = val_58 & val_654;
            val_62 = (val_660 + 1352829926) + val_62;
            int val_65 = val_62;
            val_65 = val_65 >> 25;
            int val_68 = val_58;
            int val_69 = val_65;
            val_660 = (val_654 + 1352829926) + this.X[6];
            int val_73 = val_39 >> 26;
            val_654 = val_660 >> 25;
            int val_76 = val_65;
            int val_666 = this.X[15];
            int val_77 = val_654;
            int val_82 = (val_50 + 1352829926) >> 24;
            int val_86 = val_654;
            int val_87 = val_82;
            int val_89 = (val_10 >> 17) >> 25;
            int val_90 = val_73;
            int val_668 = this.X[1];
            int val_91 = val_58 + 1352829926;
            int val_92 = val_90;
            val_91 = val_91 + this.X[8];
            val_90 = val_92;
            int val_93 = val_91 >> 21;
            val_92 = val_90;
            val_91 = val_93;
            val_90 = val_92 >> 23;
            int val_94 = val_82;
            int val_670 = this.X[3];
            int val_96 = val_91;
            int val_103 = val_65 >> 18;
            int val_104 = val_89 >> 24;
            int val_672 = this.X[7];
            int val_105 = val_104;
            int val_108 = val_89;
            int val_111 = val_108 >> 25;
            val_108 = val_111;
            int val_673 = this.X[4];
            int val_113 = val_90;
            int val_115 = val_89;
            int val_117 = val_115 >> 26;
            val_115 = val_117;
            int val_674 = this.X[13];
            int val_119 = val_104;
            int val_121 = val_90;
            int val_123 = val_121 >> 24;
            val_121 = val_123;
            int val_675 = this.X[1];
            int val_125 = val_111;
            int val_128 = val_104;
            int val_129 = val_128 >> 19;
            int val_676 = this.X[10];
            val_128 = val_129;
            int val_131 = val_117;
            int val_677 = this.X[6];
            int val_134 = val_111;
            int val_678 = this.X[15];
            int val_135 = val_134 >> 21;
            val_134 = val_135;
            int val_679 = this.X[3];
            int val_137 = val_123;
            int val_680 = this.X[12];
            int val_141 = val_117 >> 23;
            int val_143 = val_93;
            int val_681 = this.X[0];
            int val_144 = val_141;
            int val_146 = val_103;
            int val_148 = val_129;
            int val_682 = this.X[9];
            int val_153 = ((val_654 + 1352829926) + this.X[10]) >> 18;
            int val_683 = this.X[5];
            int val_155 = val_123 >> 25;
            int val_157 = val_103;
            int val_158 = val_153;
            int val_159 = val_155;
            int val_684 = this.X[2];
            int val_162 = val_135;
            int val_164 = val_129;
            int val_166 = val_82;
            int val_685 = this.X[14];
            val_166 = val_166 >> 20;
            val_164 = val_164 >> 17;
            int val_169 = val_153;
            int val_170 = val_164;
            int val_686 = this.X[11];
            int val_171 = val_166;
            int val_174 = val_141;
            int val_687 = this.X[8];
            int val_178 = (val_93 + 1352829926) + this.X[12];
            val_178 = val_178 >> 26;
            int val_688 = this.X[6];
            int val_181 = val_135 >> 25;
            int val_182 = val_178;
            int val_185 = val_73;
            val_185 = val_185 >> 23;
            int val_186 = val_181;
            int val_188 = val_141;
            int val_689 = this.X[11];
            int val_189 = val_155;
            int val_191 = val_185;
            int val_193 = val_153;
            int val_194 = val_193;
            val_194 = val_194 >> 19;
            val_193 = val_194;
            int val_690 = this.X[3];
            int val_197 = val_193;
            int val_199 = val_166;
            int val_200 = val_199;
            int val_201 = val_188 >> 20;
            val_200 = val_200 >> 17;
            val_199 = val_200;
            int val_203 = val_199;
            val_188 = val_201;
            val_178 = (val_178 + 1548603684) + this.X[7];
            int val_206 = val_164;
            val_178 = val_178 >> 25;
            int val_692 = this.X[0];
            int val_209 = val_178;
            int val_214 = val_185 >> 20;
            int val_693 = this.X[13];
            int val_216 = val_155 >> 17;
            int val_218 = val_214;
            int val_222 = val_216;
            int val_224 = val_194 >> 24;
            int val_225 = val_181;
            int val_694 = this.X[5];
            int val_228 = val_224;
            int val_230 = val_200;
            int val_231 = val_230;
            val_231 = val_231 >> 23;
            val_230 = val_231;
            int val_233 = val_164;
            int val_234 = val_230;
            int val_236 = val_178 + 1548603684;
            val_178 = val_236 + this.X[10];
            val_233 = val_233 >> 23;
            val_178 = val_178 >> 21;
            val_236 = val_178;
            int val_237 = val_233;
            int val_696 = this.X[14];
            int val_238 = val_236;
            val_214 = val_214;
            int val_242 = val_201;
            val_214 = val_214 >> 25;
            int val_697 = this.X[15];
            int val_246 = val_214;
            int val_249 = val_224;
            val_249 = val_249 >> 25;
            int val_250 = val_181;
            int val_698 = this.X[8];
            int val_252 = val_249;
            val_250 = val_250 >> 21;
            int val_256 = val_231 >> 20;
            int val_257 = val_250;
            int val_259 = val_216;
            int val_699 = this.X[12];
            int val_262 = val_256;
            int val_264 = val_178;
            val_178 = val_264;
            int val_266 = val_178 >> 25;
            val_264 = val_266;
            int val_267 = val_201;
            int val_700 = this.X[4];
            int val_268 = val_264;
            int val_270 = val_214;
            val_267 = val_267 >> 25;
            int val_272 = val_270 >> 26;
            val_270 = val_272;
            int val_273 = val_267;
            int val_274 = val_270;
            int val_701 = this.X[9];
            int val_278 = val_249;
            int val_279 = val_233;
            val_278 = val_278 >> 17;
            int val_702 = this.X[1];
            int val_283 = val_278;
            val_256 = val_256 >> 19;
            int val_703 = this.X[2];
            int val_289 = val_256;
            int val_291 = val_266;
            int val_292 = val_216 >> 19;
            val_266 = val_291;
            val_266 = val_266 >> 21;
            int val_704 = this.X[3];
            val_291 = val_266;
            int val_293 = val_291;
            int val_294 = val_250;
            int val_297 = val_294 >> 21;
            int val_705 = this.X[10];
            val_294 = val_297;
            int val_298 = val_294;
            int val_300 = val_267;
            int val_302 = val_300 >> 19;
            int val_706 = this.X[14];
            val_300 = val_302;
            int val_303 = val_300;
            int val_305 = val_292;
            int val_307 = val_305 >> 26;
            int val_707 = this.X[4];
            val_305 = val_307;
            int val_308 = val_305;
            int val_310 = val_266;
            val_266 = val_310 >> 25;
            int val_708 = this.X[9];
            val_310 = val_266;
            int val_312 = val_310;
            int val_315 = val_297;
            int val_316 = val_315 >> 18;
            int val_709 = this.X[15];
            val_315 = val_316;
            int val_710 = this.X[8];
            int val_320 = val_302;
            int val_321 = val_320 >> 23;
            int val_711 = this.X[1];
            val_320 = val_321;
            int val_322 = val_320;
            int val_323 = val_307;
            int val_712 = this.X[2];
            int val_325 = val_323;
            int val_713 = this.X[7];
            int val_326 = val_325 >> 19;
            val_323 = val_326;
            int val_714 = this.X[0];
            val_325 = val_323;
            int val_327 = val_266;
            int val_715 = this.X[6];
            int val_329 = val_327;
            val_327 = val_329 >> 17;
            int val_716 = this.X[13];
            val_329 = val_327;
            int val_330 = val_329;
            int val_717 = this.X[11];
            int val_333 = val_316;
            int val_334 = val_292;
            int val_718 = this.X[5];
            int val_336 = val_333 >> 18;
            int val_337 = val_250;
            int val_722 = val_278;
            val_333 = val_336;
            int val_719 = this.X[12];
            int val_340 = val_333;
            int val_342 = val_233;
            val_342 = val_342 >> 20;
            int val_344 = val_722;
            int val_346 = val_256;
            int val_347 = val_321;
            int val_720 = this.X[15];
            int val_348 = val_272;
            int val_350 = val_348;
            val_347 = val_347 >> 24;
            val_350 = val_350 >> 23;
            val_348 = val_350;
            int val_721 = this.X[5];
            int val_352 = val_256;
            val_722 = val_722;
            int val_356 = val_347;
            int val_358 = val_722 >> 25;
            int val_359 = val_358;
            int val_723 = this.X[1];
            int val_361 = val_342;
            int val_366 = val_256 >> 17;
            int val_367 = val_326;
            int val_368 = val_366;
            int val_724 = this.X[3];
            int val_370 = val_350;
            val_367 = val_367 >> 19;
            val_342 = val_342;
            val_342 = val_342 >> 21;
            int val_374 = val_342;
            int val_725 = this.X[7];
            int val_377 = val_358;
            int val_379 = val_350;
            int val_380 = val_367;
            int val_383 = val_379 >> 24;
            val_379 = val_383;
            int val_385 = val_366;
            int val_726 = this.X[14];
            int val_388 = val_358;
            int val_390 = val_327 >> 26;
            int val_391 = val_388 >> 26;
            val_388 = val_391;
            int val_727 = this.X[6];
            int val_394 = val_342;
            val_366 = val_366;
            val_366 = val_366 >> 26;
            int val_397 = val_390;
            int val_399 = val_366;
            int val_728 = this.X[9];
            int val_401 = val_383;
            int val_406 = val_342 >> 18;
            int val_408 = val_406;
            int val_729 = this.X[11];
            int val_410 = val_391;
            val_336 = val_336 >> 27;
            int val_414 = val_383 >> 20;
            int val_417 = val_336;
            int val_419 = val_414;
            int val_730 = this.X[8];
            int val_420 = val_366;
            int val_422 = val_391;
            val_391 = val_422 >> 19;
            val_422 = val_391;
            int val_426 = val_406;
            int val_731 = this.X[12];
            int val_429 = val_366;
            int val_431 = val_347 >> 20;
            int val_432 = val_429 >> 27;
            val_429 = val_432;
            int val_732 = this.X[2];
            int val_434 = val_414;
            int val_438 = val_406;
            val_438 = val_438 >> 18;
            int val_439 = val_431;
            int val_441 = val_438;
            int val_733 = this.X[10];
            int val_443 = val_391;
            int val_447 = val_414;
            val_447 = val_447 >> 19;
            int val_448 = val_367;
            int val_734 = this.X[0];
            int val_450 = val_447;
            int val_451 = val_432;
            val_448 = val_448 >> 25;
            int val_456 = val_391 >> 19;
            val_448 = val_448;
            int val_735 = this.X[4];
            int val_458 = val_456;
            int val_460 = val_438;
            int val_736 = this.X[13];
            int val_465 = val_390;
            int val_466 = val_432 >> 25;
            val_465 = val_465 >> 27;
            int val_737 = this.X[1];
            int val_467 = val_465;
            int val_469 = val_466;
            int val_470 = val_336;
            int val_472 = val_470;
            val_472 = val_472 >> 21;
            val_470 = val_472;
            int val_473 = val_465;
            int val_738 = this.X[9];
            int val_474 = val_470;
            int val_476 = val_431;
            val_431 = val_476;
            val_431 = val_431 >> 20;
            val_476 = val_431;
            int val_477 = val_472;
            int val_739 = this.X[11];
            int val_478 = val_476;
            int val_480 = val_466;
            int val_481 = val_480;
            val_481 = val_481 >> 18;
            val_480 = val_481;
            int val_482 = val_431;
            int val_740 = this.X[10];
            int val_483 = val_480;
            int val_485 = val_465;
            val_465 = val_485;
            int val_486 = val_465 >> 17;
            val_485 = val_486;
            int val_487 = val_481;
            int val_741 = this.X[0];
            int val_488 = val_485;
            int val_490 = val_472;
            int val_491 = val_490;
            val_491 = val_491 >> 18;
            val_490 = val_491;
            int val_492 = val_486;
            int val_742 = this.X[8];
            int val_493 = val_490;
            val_431 = val_431;
            val_431 = val_431 >> 17;
            int val_743 = this.X[12];
            int val_497 = val_491;
            int val_498 = val_431;
            int val_744 = this.X[4];
            int val_501 = val_481;
            int val_745 = this.X[13];
            val_501 = val_501 >> 23;
            int val_503 = val_431;
            int val_746 = this.X[3];
            int val_504 = val_501;
            int val_747 = this.X[7];
            int val_507 = val_486;
            val_486 = val_507 >> 24;
            int val_748 = this.X[15];
            val_507 = val_486;
            int val_508 = val_501;
            int val_509 = val_507;
            int val_749 = this.X[14];
            int val_512 = val_491;
            int val_750 = this.X[5];
            int val_513 = val_512 >> 23;
            val_512 = val_513;
            int val_514 = val_486;
            int val_515 = val_466;
            int val_751 = this.X[6];
            int val_517 = val_512;
            int val_519 = val_447;
            int val_752 = this.X[2];
            int val_523 = val_431;
            int val_524 = val_438;
            val_523 = val_523 >> 18;
            val_524 = val_524 >> 27;
            int val_753 = this.X[8];
            int val_529 = val_513;
            int val_531 = val_523;
            int val_533 = val_456 >> 17;
            int val_754 = this.X[6];
            int val_538 = val_524;
            val_538 = val_538 >> 27;
            int val_539 = val_501;
            int val_755 = this.X[4];
            val_539 = val_539 >> 27;
            int val_543 = val_533;
            int val_545 = val_523;
            val_543 = val_543 >> 24;
            int val_546 = val_486;
            int val_756 = this.X[1];
            int val_547 = val_539;
            int val_551 = val_538;
            val_551 = val_551 >> 21;
            int val_757 = this.X[3];
            val_533 = val_543;
            int val_557 = val_546 >> 26;
            val_546 = val_557;
            int val_559 = val_539;
            int val_758 = this.X[11];
            val_538 = val_551;
            int val_563 = val_546;
            val_538 = val_538 >> 18;
            int val_759 = this.X[15];
            val_543 = val_533 >> 18;
            val_543 = val_543 >> 26;
            int val_569 = val_513;
            int val_760 = this.X[0];
            val_569 = val_569 >> 24;
            int val_576 = val_557;
            int val_577 = val_569;
            int val_761 = this.X[5];
            int val_584 = val_543 >> 26;
            val_523 = val_523;
            int val_762 = this.X[12];
            val_523 = val_523 >> 26;
            int val_589 = (val_538 >> 18) >> 23;
            int val_591 = val_569;
            int val_763 = this.X[2];
            val_543 = val_584;
            int val_595 = val_523;
            val_543 = val_543 >> 20;
            int val_764 = this.X[13];
            int val_601 = val_589;
            val_601 = val_601 >> 23;
            int val_602 = val_539;
            int val_765 = this.X[9];
            val_602 = val_602 >> 27;
            val_584 = val_543 >> 20;
            int val_608 = val_523;
            int val_609 = val_602;
            int val_766 = this.X[7];
            val_589 = val_601;
            int val_767 = this.X[10];
            val_543 = val_584;
            int val_620 = val_557 >> 20;
            int val_621 = val_543 >> 17;
            int val_768 = this.X[14];
            int val_625 = val_589 >> 27;
            val_625 = val_625 >> 24;
            val_634 = 0;
            this.H0 = this.H0;
            this.H1 = this.H1;
            this.H2 = this.H2;
            this.H3 = this.H3;
            this.H6 = this.H6;
            this.H7 = this.H7;
            this.H4 = this.H4;
            this.H5 = this.H5;
            this.xOff = 0;
            goto label_256;
            label_260:
            val_634 = 1;
            this.X[0] = 0;
            label_256:
            if(val_634 != this.X.Length)
            {
                goto label_260;
            }
        
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.RipeMD256Digest(t:  this);
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
