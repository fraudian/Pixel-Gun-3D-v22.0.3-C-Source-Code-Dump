using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class RipeMD128Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 16;
        private int H0;
        private int H1;
        private int H2;
        private int H3;
        private int[] X;
        private int xOff;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public RipeMD128Digest()
        {
            this.X = new int[16];
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD128Digest).__il2cppRuntimeField_1F8;
        }
        public RipeMD128Digest(Org.BouncyCastle.Crypto.Digests.RipeMD128Digest t)
        {
            this.X = new int[16];
            Org.BouncyCastle.Crypto.Digests.RipeMD128Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.RipeMD128Digest t)
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
            if(4194311 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public override string get_AlgorithmName()
        {
            return "RIPEMD128";
        }
        public override int GetDigestSize()
        {
            return 16;
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
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD128Digest).__il2cppRuntimeField_228;
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
            return 16;
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
            System.Int32[] val_586;
            var val_587;
            int val_588 = this.H0;
            int val_616 = this.H1;
            int val_587 = this.H2;
            int val_1 = val_587 ^ val_616;
            val_587 = val_1 ^ this.H3;
            val_587 = val_587 + val_588;
            val_588 = val_587 + this.X[0];
            int val_2 = val_588 >> 21;
            System.Int32[] val_591 = this.X;
            val_587 = val_1 ^ val_2;
            val_587 = val_587 + this.H3;
            val_1 = val_587 + this.X[1];
            val_1 = val_1 >> 18;
            int val_608 = this.H2;
            System.Int32[] val_593 = this.X;
            int val_3 = val_2 ^ val_616;
            val_3 = val_3 ^ val_1;
            val_3 = val_3 + val_608;
            val_591 = val_3 + val_591[2];
            val_591 = val_591 >> 17;
            int val_4 = val_1 ^ val_2;
            val_4 = val_4 ^ val_591;
            val_4 = val_4 + val_616;
            val_593 = val_4 + val_593[3];
            val_593 = val_593 >> 20;
            int val_5 = val_591 ^ val_1;
            val_5 = val_5 ^ val_593;
            val_5 = val_5 + val_2;
            val_2 = val_5 + this.X[4];
            val_2 = val_2 >> 27;
            int val_6 = val_593 ^ val_591;
            val_6 = val_6 ^ val_2;
            val_6 = val_6 + val_1;
            val_1 = val_6 + this.X[5];
            val_1 = val_1 >> 24;
            int val_7 = val_2 ^ val_593;
            val_7 = val_7 ^ val_1;
            val_7 = val_7 + val_591;
            val_591 = val_7 + this.X[6];
            val_591 = val_591 >> 25;
            int val_8 = val_1 ^ val_2;
            val_8 = val_8 ^ val_591;
            val_8 = val_8 + val_593;
            val_593 = val_8 + this.X[7];
            val_593 = val_593 >> 23;
            int val_9 = val_591 ^ val_1;
            val_9 = val_9 ^ val_593;
            val_9 = val_9 + val_2;
            val_2 = val_9 + this.X[8];
            val_2 = val_2 >> 21;
            System.Int32[] val_601 = this.X;
            int val_10 = val_593 ^ val_591;
            val_10 = val_10 ^ val_2;
            val_10 = val_10 + val_1;
            val_1 = val_10 + this.X[9];
            val_1 = val_1 >> 19;
            int val_11 = val_2 ^ val_593;
            val_11 = val_11 ^ val_1;
            val_11 = val_11 + val_591;
            val_591 = val_11 + val_601[10];
            val_601 = val_591 >> 18;
            int val_602 = this.X[11];
            int val_12 = val_1 ^ val_2;
            val_12 = val_12 ^ val_601;
            val_593 = val_12;
            val_593 = val_593 >> 17;
            int val_603 = this.X[12];
            int val_17 = val_601 ^ val_1;
            val_17 = val_17 >> 26;
            int val_604 = this.X[13];
            val_1 = val_593;
            val_2 = val_1 >> 25;
            int val_605 = this.X[14];
            val_601 = val_17;
            val_601 = val_601 >> 23;
            int val_606 = this.X[15];
            int val_26 = val_2;
            int val_27 = val_26;
            val_27 = val_27 >> 24;
            int val_607 = this.X[7];
            val_26 = val_27;
            val_608 = val_2;
            int val_28 = val_608;
            int val_29 = val_17;
            val_17 = val_29;
            val_17 = val_17 >> 25;
            val_29 = val_17;
            int val_609 = this.X[4];
            int val_32 = val_601;
            int val_34 = val_2;
            val_593 = val_34;
            val_2 = val_593 >> 26;
            val_34 = val_2;
            int val_610 = this.X[13];
            int val_36 = val_27;
            int val_38 = val_601;
            val_601 = val_38 >> 24;
            val_38 = val_601;
            int val_611 = this.X[1];
            int val_41 = val_17;
            int val_43 = val_27;
            val_27 = val_43;
            val_27 = val_27 >> 19;
            val_43 = val_27;
            int val_612 = this.X[10];
            int val_45 = val_2;
            int val_47 = val_17;
            val_17 = val_47;
            val_17 = val_17 >> 21;
            val_47 = val_17;
            int val_613 = this.X[6];
            int val_49 = val_601;
            int val_53 = val_2 >> 23;
            int val_54 = val_53;
            int val_614 = this.X[15];
            int val_56 = val_27;
            int val_615 = this.X[3];
            int val_60 = val_601 >> 25;
            val_616 = val_60;
            int val_617 = this.X[12];
            int val_62 = val_17;
            int val_618 = this.X[0];
            int val_65 = val_27;
            val_65 = val_65 >> 17;
            int val_619 = this.X[9];
            int val_66 = val_65;
            int val_68 = val_53;
            int val_69 = val_17;
            int val_620 = this.X[5];
            int val_621 = this.X[2];
            int val_72 = val_69 >> 25;
            val_69 = val_72;
            int val_622 = this.X[14];
            int val_74 = val_60;
            int val_623 = this.X[11];
            int val_77 = val_53;
            int val_78 = val_77 >> 20;
            int val_624 = this.X[8];
            val_77 = val_78;
            int val_80 = val_65;
            int val_625 = this.X[3];
            int val_626 = this.X[10];
            int val_84 = val_60 >> 17;
            int val_85 = val_84;
            int val_627 = this.X[14];
            int val_87 = val_72;
            int val_628 = this.X[4];
            int val_90 = val_65;
            val_90 = val_90 >> 23;
            int val_629 = this.X[9];
            int val_91 = val_90;
            int val_93 = val_78;
            int val_630 = this.X[15];
            int val_631 = this.X[8];
            int val_97 = val_72 >> 21;
            int val_98 = val_97;
            int val_632 = this.X[1];
            int val_100 = val_84;
            int val_667 = val_616;
            int val_633 = this.X[2];
            int val_104 = val_78 >> 25;
            int val_634 = this.X[7];
            int val_105 = val_104;
            int val_107 = val_90;
            int val_635 = this.X[0];
            val_84 = val_84;
            int val_636 = this.X[6];
            int val_110 = val_84 >> 19;
            int val_111 = val_110;
            int val_637 = this.X[13];
            int val_113 = val_97;
            int val_638 = this.X[11];
            int val_117 = val_90 >> 20;
            int val_639 = this.X[5];
            int val_119 = val_117;
            int val_640 = this.X[12];
            int val_121 = val_97;
            int val_641 = this.X[1];
            val_121 = val_121 >> 21;
            int val_642 = this.X[9];
            int val_124 = val_121;
            int val_125 = val_104;
            int val_643 = this.X[11];
            int val_127 = val_125;
            int val_644 = this.X[10];
            val_127 = val_127 >> 19;
            val_125 = val_127;
            int val_645 = this.X[0];
            int val_128 = val_125;
            int val_646 = this.X[8];
            int val_131 = val_110;
            val_131 = val_131 >> 26;
            int val_647 = this.X[12];
            val_110 = val_131;
            int val_133 = val_117;
            int val_648 = this.X[4];
            int val_135 = val_133;
            int val_649 = this.X[13];
            val_135 = val_135 >> 25;
            val_133 = val_135;
            int val_650 = this.X[3];
            int val_136 = val_133;
            int val_651 = this.X[7];
            int val_140 = val_121 >> 18;
            int val_652 = this.X[15];
            int val_142 = val_140;
            int val_143 = val_127;
            int val_653 = this.X[14];
            int val_145 = val_143;
            int val_654 = this.X[5];
            val_145 = val_145 >> 23;
            val_143 = val_145;
            int val_655 = this.X[6];
            int val_146 = val_143;
            int val_656 = this.X[2];
            System.Int32[] val_659 = this.X;
            int val_150 = val_131 >> 19;
            int val_658 = this.H2;
            int val_657 = val_659[5];
            System.Int32[] val_663 = this.X;
            int val_151 = this.H3 & val_667;
            val_658 = val_658 & (~this.H3);
            val_151 = val_151 | val_658;
            val_151 = val_588 + val_151;
            val_657 = val_151 + val_657;
            val_659 = val_657 + 1352829926;
            int val_153 = val_150;
            val_659 = val_659 >> 24;
            int val_661 = this.H2;
            val_151 = val_659 & val_661;
            val_661 = val_667 & (~val_661);
            val_151 = val_151 | val_661;
            int val_662 = this.H3;
            val_662 = val_662 + 1352829926;
            val_151 = val_662 + val_151;
            val_663 = val_151 + val_663[14];
            val_663 = val_663 >> 23;
            int val_156 = val_135;
            int val_157 = val_663 & val_667;
            val_157 = val_157 | (val_659 & (~val_667));
            int val_665 = this.H2;
            val_665 = val_665 + 1352829926;
            val_157 = val_665 + val_157;
            val_156 = val_156 >> 17;
            int val_159 = val_157 + this.X[7];
            val_159 = val_159 >> 23;
            val_157 = val_159 & val_659;
            val_157 = val_157 | (val_663 & (~val_659));
            val_157 = (val_667 + 1352829926) + val_157;
            int val_164 = val_156;
            val_667 = val_157 + this.X[0];
            val_667 = val_667 >> 21;
            val_157 = val_667 & val_663;
            val_157 = val_157 | (val_159 & (~val_663));
            val_157 = (val_659 + 1352829926) + val_157;
            val_659 = val_157 + this.X[9];
            int val_169 = val_140 >> 18;
            int val_170 = val_659 >> 19;
            val_157 = val_170 & val_159;
            val_157 = val_157 | (val_667 & (~val_159));
            System.Int32[] val_671 = this.X;
            val_157 = (val_663 + 1352829926) + val_157;
            val_663 = val_157 + this.X[2];
            int val_174 = val_169;
            val_663 = val_663 >> 17;
            int val_176 = val_663 & val_667;
            val_176 = val_176 | (val_170 & (~val_667));
            val_176 = (val_159 + 1352829926) + val_176;
            val_671 = val_176 + val_671[11];
            val_671 = val_671 >> 17;
            int val_180 = val_145;
            int val_181 = val_671 & val_170;
            val_181 = val_181 | (val_663 & (~val_170));
            System.Int32[] val_674 = this.X;
            val_180 = val_180 >> 24;
            val_159 = ((val_667 + 1352829926) + this.X[4]) >> 27;
            int val_188 = val_671 & (~val_663);
            int val_189 = val_159 & val_663;
            int val_190 = val_180;
            val_189 = (val_170 + 1352829926) + val_189;
            val_674 = val_189 + val_674[13];
            val_674 = val_674 >> 25;
            val_189 = val_674;
            int val_194 = val_159;
            int val_195 = val_189;
            int val_196 = val_150;
            int val_198 = val_663 + 1352829926;
            val_663 = val_198 + this.X[6];
            int val_199 = val_196 >> 19;
            int val_200 = val_663 >> 25;
            val_198 = val_200 & val_159;
            int val_201 = val_674;
            int val_202 = val_198;
            val_196 = val_199;
            System.Int32[] val_678 = this.X;
            val_671 = (val_671 + 1352829926) + this.X[15];
            val_671 = val_671 >> 24;
            int val_205 = val_196;
            int val_208 = val_200;
            int val_209 = val_671;
            val_678 = (val_159 + 1352829926) + val_678[8];
            val_678 = val_678 >> 21;
            int val_215 = val_671;
            int val_679 = this.X[1];
            int val_216 = val_678;
            System.Int32[] val_681 = this.X;
            int val_219 = val_156 >> 26;
            int val_222 = val_674 >> 18;
            int val_223 = val_678;
            int val_224 = val_219;
            int val_227 = val_222;
            int val_229 = val_200 + 1352829926;
            val_681 = val_229 + val_681[10];
            int val_231 = val_681 >> 18;
            val_229 = val_231;
            int val_232 = val_222;
            int val_233 = val_229;
            int val_234 = val_169;
            int val_682 = this.X[3];
            int val_236 = val_671;
            val_671 = val_236;
            int val_237 = val_234 >> 27;
            val_671 = val_671 >> 20;
            val_236 = val_671;
            int val_238 = val_231;
            int val_239 = val_236;
            val_678 = (val_678 + 1352829926) + this.X[12];
            val_234 = val_237;
            val_678 = val_678 >> 26;
            int val_684 = this.X[6];
            int val_245 = val_678;
            int val_248 = val_180;
            int val_249 = val_222;
            val_249 = val_249 >> 23;
            int val_250 = val_248;
            int val_685 = this.X[11];
            int val_252 = val_249;
            int val_254 = val_231 + 1548603684;
            val_250 = val_250 >> 20;
            val_231 = val_254;
            val_248 = val_250;
            val_231 = val_231 >> 19;
            val_254 = val_231;
            int val_255 = val_248;
            int val_686 = this.X[3];
            int val_257 = val_254;
            int val_259 = val_671;
            int val_260 = val_259;
            val_260 = val_260 >> 17;
            val_259 = val_260;
            int val_263 = val_259;
            int val_265 = val_678 + 1548603684;
            val_678 = val_265 + this.X[7];
            int val_266 = val_199 >> 25;
            int val_267 = val_678 >> 25;
            int val_688 = this.X[0];
            val_265 = val_267;
            int val_268 = val_265;
            val_249 = val_249;
            val_266 = val_266;
            int val_273 = val_249 >> 20;
            int val_689 = this.X[13];
            int val_274 = val_219;
            int val_276 = val_273;
            int val_280 = val_231 >> 24;
            int val_690 = this.X[5];
            val_274 = val_274 >> 27;
            int val_283 = val_280;
            val_260 = val_260;
            int val_287 = val_266;
            val_260 = val_260 >> 23;
            int val_289 = val_260;
            int val_292 = val_274;
            val_267 = (val_267 + 1548603684) + this.X[10];
            val_267 = val_267 >> 21;
            int val_692 = this.X[14];
            int val_296 = val_267;
            int val_298 = val_273;
            val_273 = val_298;
            int val_299 = val_237;
            val_273 = val_273 >> 25;
            int val_693 = this.X[15];
            val_298 = val_273;
            int val_300 = val_298;
            val_299 = val_299 >> 21;
            val_280 = val_280 >> 25;
            int val_305 = val_274;
            int val_306 = val_250;
            int val_694 = this.X[8];
            int val_307 = val_299;
            int val_309 = val_280;
            int val_311 = val_260;
            int val_314 = val_311 >> 20;
            val_311 = val_314;
            int val_695 = this.X[12];
            int val_316 = val_311;
            val_267 = val_267 + 1548603684;
            val_306 = val_306 >> 20;
            int val_319 = val_267 >> 25;
            int val_321 = val_299;
            int val_696 = this.X[4];
            int val_323 = val_319;
            int val_327 = val_306;
            int val_329 = val_273 >> 26;
            int val_697 = this.X[9];
            int val_332 = val_329;
            int val_335 = val_280;
            val_335 = val_335 >> 17;
            int val_336 = val_266;
            int val_698 = this.X[1];
            int val_338 = val_335;
            val_336 = val_336 >> 18;
            int val_342 = val_314 >> 19;
            int val_344 = val_306;
            int val_345 = val_336;
            int val_699 = this.X[2];
            int val_348 = val_342;
            int val_350 = val_319;
            val_319 = val_350;
            val_319 = val_319 >> 21;
            val_350 = val_319;
            int val_353 = val_335;
            int val_354 = val_274;
            int val_700 = this.X[15];
            val_329 = val_329;
            val_354 = val_354 >> 17;
            int val_357 = val_329 >> 23;
            int val_360 = val_336;
            int val_361 = val_357;
            int val_701 = this.X[5];
            int val_362 = val_342;
            val_335 = val_335;
            int val_365 = val_354;
            val_335 = val_335 >> 25;
            int val_367 = val_335;
            int val_702 = this.X[1];
            int val_369 = val_319;
            val_342 = val_342 >> 17;
            int val_374 = val_299;
            int val_375 = val_342;
            int val_703 = this.X[3];
            int val_377 = val_357;
            val_374 = val_374 >> 18;
            val_319 = val_319;
            val_319 = val_319 >> 21;
            int val_381 = val_354;
            int val_382 = val_319;
            int val_384 = val_335;
            int val_704 = this.X[7];
            int val_386 = val_374;
            int val_388 = val_357;
            val_357 = val_388 >> 24;
            val_388 = val_357;
            int val_392 = val_342;
            int val_393 = val_306;
            int val_705 = this.X[14];
            val_335 = val_335;
            val_393 = val_393 >> 17;
            int val_396 = val_335 >> 26;
            int val_399 = val_374;
            int val_400 = val_396;
            int val_706 = this.X[6];
            int val_401 = val_319;
            int val_405 = val_393;
            int val_407 = val_342 >> 26;
            int val_408 = val_407;
            int val_707 = this.X[9];
            int val_410 = val_357;
            val_319 = val_319;
            val_319 = val_319 >> 18;
            int val_414 = val_336;
            int val_415 = val_319;
            int val_708 = this.X[11];
            int val_417 = val_396;
            val_414 = val_414 >> 23;
            int val_422 = val_393;
            val_357 = val_357 >> 20;
            int val_423 = val_357;
            int val_425 = val_407;
            int val_709 = this.X[8];
            int val_427 = val_414;
            int val_429 = val_396;
            int val_432 = val_429 >> 19;
            val_429 = val_432;
            int val_434 = val_319;
            int val_435 = val_354;
            int val_710 = this.X[12];
            int val_437 = val_407;
            val_407 = val_437;
            val_435 = val_435 >> 24;
            int val_438 = val_407 >> 27;
            val_437 = val_438;
            int val_440 = val_414;
            int val_711 = this.X[2];
            int val_441 = val_357;
            val_319 = val_319;
            int val_445 = val_435;
            val_319 = val_319 >> 18;
            int val_447 = val_319;
            int val_712 = this.X[10];
            int val_449 = val_432;
            int val_453 = val_357;
            val_453 = val_453 >> 19;
            int val_455 = val_453;
            int val_713 = this.X[0];
            int val_457 = val_438;
            int val_458 = val_374 >> 23;
            int val_461 = val_432;
            val_461 = val_461 >> 19;
            int val_463 = val_435;
            int val_464 = val_461;
            int val_466 = val_458;
            int val_714 = this.X[4];
            int val_468 = val_319;
            int val_470 = val_438;
            int val_471 = val_470;
            val_438 = val_471 >> 25;
            val_470 = val_438;
            int val_474 = val_453;
            val_393 = val_393;
            int val_715 = this.X[13];
            val_393 = val_393 >> 18;
            val_319 = val_319 >> 27;
            int val_479 = val_458;
            int val_716 = this.X[8];
            val_471 = val_438;
            int val_483 = val_393;
            int val_717 = this.X[6];
            int val_491 = val_414;
            int val_718 = this.X[4];
            val_491 = val_491 >> 27;
            val_438 = (val_471 >> 17) >> 24;
            int val_498 = val_393;
            int val_499 = val_491;
            int val_719 = this.X[1];
            val_319 = val_319 >> 27;
            int val_505 = val_319 >> 21;
            int val_509 = val_435;
            int val_720 = this.X[3];
            int val_510 = val_438;
            val_509 = val_509 >> 26;
            val_510 = val_510 >> 18;
            int val_512 = val_491;
            int val_721 = this.X[11];
            int val_516 = val_505;
            int val_517 = val_509;
            val_516 = val_516 >> 18;
            int val_722 = this.X[15];
            val_438 = val_510 >> 26;
            int val_524 = val_458;
            int val_723 = this.X[0];
            val_524 = val_524 >> 24;
            val_505 = val_516;
            int val_529 = val_509;
            val_505 = val_505 >> 18;
            int val_530 = val_524;
            int val_724 = this.X[5];
            val_510 = val_438;
            int val_536 = val_510 >> 26;
            int val_540 = val_393;
            int val_725 = this.X[12];
            val_516 = val_505;
            val_540 = val_540 >> 26;
            int val_541 = val_516 >> 23;
            int val_545 = val_524;
            int val_726 = this.X[2];
            int val_548 = val_540;
            val_438 = val_536 >> 20;
            int val_727 = this.X[13];
            int val_554 = val_541;
            val_554 = val_554 >> 23;
            int val_555 = val_491;
            int val_728 = this.X[9];
            val_536 = val_438;
            val_555 = val_555 >> 27;
            val_536 = val_536 >> 20;
            int val_560 = val_540;
            int val_561 = val_555;
            int val_729 = this.X[7];
            val_541 = val_554;
            int val_567 = val_541 >> 27;
            int val_730 = this.X[10];
            val_586 = this.X;
            int val_572 = val_536;
            int val_573 = val_509 >> 20;
            val_572 = val_572 >> 17;
            int val_731 = val_586[14];
            int val_577 = val_567;
            val_577 = val_577 >> 24;
            val_587 = 0;
            this.H0 = val_567;
            this.H1 = val_536;
            this.H2 = val_577;
            this.H3 = val_572;
            this.xOff = 0;
            goto label_256;
            label_260:
            val_586 = 0;
            val_587 = 1;
            this.X[val_586] = 0;
            label_256:
            if(val_587 != this.X.Length)
            {
                goto label_260;
            }
        
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.RipeMD128Digest(t:  this);
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
