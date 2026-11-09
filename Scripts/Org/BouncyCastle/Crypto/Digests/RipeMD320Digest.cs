using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class RipeMD320Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 40;
        private int H0;
        private int H1;
        private int H2;
        private int H3;
        private int H4;
        private int H5;
        private int H6;
        private int H7;
        private int H8;
        private int H9;
        private int[] X;
        private int xOff;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public override string get_AlgorithmName()
        {
            return "RIPEMD320";
        }
        public override int GetDigestSize()
        {
            return 40;
        }
        public RipeMD320Digest()
        {
            this.X = new int[16];
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD320Digest).__il2cppRuntimeField_1F8;
        }
        public RipeMD320Digest(Org.BouncyCastle.Crypto.Digests.RipeMD320Digest t)
        {
            this.X = new int[16];
            Org.BouncyCastle.Crypto.Digests.RipeMD320Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.RipeMD320Digest t)
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
            this.H8 = t.H8;
            this.H9 = t.H9;
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
            this.H8 = 0;
            this.H9 = 0;
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
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD320Digest).__il2cppRuntimeField_228;
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
            this.UnpackWord(word:  this.H8, outBytes:  output, outOff:  outOff + 32);
            this.UnpackWord(word:  this.H9, outBytes:  output, outOff:  outOff + 36);
            return 40;
        }
        public override void Reset()
        {
            var val_1;
            this.Reset();
            val_1 = 0;
            this.H8 = 19088743;
            this.H9 = 7695;
            this.H0 = ;
            this.H1 = ;
            this.H2 = 1167088121787636990;
            this.H3 = 271733878;
            this.H4 = ;
            this.H5 = ;
            this.H6 = 9920249034870405784;
            this.H7 = 2309737967;
            this.xOff = 0;
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
        private int F5(int x, int y, int z)
        {
            return (int)(y | (~z)) ^ x;
        }
        internal override void ProcessBlock()
        {
            int val_1034;
            int val_1035;
            int val_1036;
            int val_1037;
            int val_1038;
            int val_1039;
            int val_1040;
            var val_1041;
            int val_1042;
            var val_1043;
            int val_1029 = this.H4;
            int val_1033 = this.H1;
            int val_1030 = this.H2;
            int val_1 = val_1030 ^ val_1033;
            System.Int32[] val_1027 = this.X;
            val_1 = val_1 ^ this.H3;
            int val_1026 = val_1027[0];
            int val_2 = val_1 + this.H0;
            int val_3 = val_1033 ^ (((this.H2) << (32-22)) | ((this.H2) << 22));
            val_1026 = val_2 + val_1026;
            val_1026 = val_1026 >> 21;
            val_1027 = val_1026 + val_1029;
            val_3 = val_3 ^ val_1027;
            int val_1028 = this.X[1];
            val_2 = val_3 + val_1029;
            System.Int32[] val_1032 = this.X;
            int val_4 = val_1027 ^ (((this.H1) << (32-22)) | ((this.H1) << 22));
            val_1028 = val_2 + val_1028;
            val_1028 = val_1028 >> 18;
            val_1029 = val_1028 + this.H3;
            int val_5 = val_1030 >> 22;
            val_1030 = val_4 ^ val_1029;
            int val_1031 = val_1032[2];
            val_2 = val_1030 + this.H3;
            int val_6 = val_1029 ^ (((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) << (32-22)) | ((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) << 22));
            val_1031 = val_2 + val_1031;
            val_1031 = val_1031 >> 17;
            val_1032 = val_1031 + val_5;
            val_1033 = val_1033 >> 22;
            val_6 = val_6 ^ val_1032;
            int val_1034 = this.X[3];
            val_2 = val_6 + val_5;
            val_1034 = val_2 + val_1034;
            val_1034 = val_1034 >> 20;
            val_4 = val_1034 + val_1033;
            val_6 = (val_1032 ^ (((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3)) << (32-22)) | ((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3)) << 22))) ^ val_4;
            val_1033 = val_6 + val_1033;
            val_6 = val_1033 + this.X[4];
            int val_1036 = this.X[5];
            int val_8 = val_1027 >> 22;
            val_1027 = val_6 >> 27;
            val_6 = val_1027 + val_8;
            int val_10 = (val_4 ^ (((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ (((((() << (32-22)) | ((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ (((((() << 22))) ^ val_6;
            val_10 = val_10 + val_8;
            val_1036 = val_10 + val_1036;
            int val_11 = val_1029 >> 22;
            val_1029 = val_1036 >> 24;
            val_1029 = val_1029 + val_11;
            int val_13 = (val_6 ^ (((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((((((((t) << (32-22)) | ((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((((((((t) << 22))) ^ val_1029;
            int val_1040 = this.X[9];
            val_11 = val_13 + val_11;
            val_13 = val_11 + this.X[6];
            int val_1041 = this.X[10];
            int val_14 = val_1032 >> 22;
            val_8 = (val_13 >> 25) + val_14;
            val_1032 = val_1029 ^ (((((((((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ) << (32-22)) | ((((((((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ) << 22));
            int val_1042 = this.X[11];
            int val_16 = val_1032 ^ val_8;
            val_16 = val_16 + val_14;
            int val_1043 = this.X[12];
            int val_18 = val_4 >> 22;
            val_16 = (val_16 + this.X[7]) >> 23;
            int val_1044 = this.X[13];
            int val_1051 = this.H9;
            val_16 = val_16 + val_18;
            int val_1045 = this.X[14];
            int val_21 = (val_8 ^ (((((((((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((() << (32-22)) | ((((((((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((() << 22))) + val_18;
            val_21 = val_21 + this.X[8];
            int val_1046 = this.X[15];
            System.Int32[] val_1049 = this.X;
            int val_22 = val_6 >> 22;
            int val_24 = this.H7 | (~this.H8);
            val_6 = val_21 >> 21;
            val_24 = val_24 ^ this.H6;
            int val_1048 = this.H5;
            int val_1047 = val_1049[5];
            val_1048 = val_1048 + val_24;
            val_1047 = val_1048 + val_1047;
            val_1047 = val_1047 + 1352829926;
            val_1047 = val_1047 >> 24;
            val_1049 = val_1047 + val_1051;
            int val_29 = val_1049 ^ (this.H6 | (~(((this.H7) << (32-22)) | ((this.H7) << 22))));
            int val_30 = val_1051 + 1352829926;
            int val_1050 = this.X[14];
            val_30 = val_30 + val_29;
            System.Int32[] val_1054 = this.X;
            val_1051 = val_1049 | (~(((this.H6) << (32-22)) | ((this.H6) << 22)));
            val_1050 = val_30 + val_1050;
            val_1050 = val_1050 >> 23;
            val_29 = val_1050 + this.H8;
            int val_32 = val_1029 >> 22;
            int val_34 = this.H7 >> 22;
            int val_1053 = this.H8;
            int val_1052 = val_1054[7];
            int val_37 = val_16 >> 19;
            val_1053 = val_1053 + 1352829926;
            val_1053 = val_1053 + val_29 ^ val_1051;
            val_1052 = val_1053 + val_1052;
            val_1052 = val_1052 >> 23;
            val_1054 = val_1052 + val_34;
            val_29 = val_29 | (~((((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9)) << (32-22)) | (((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9)) << 22)));
            int val_39 = this.H6 >> 22;
            int val_1055 = this.X[0];
            int val_41 = val_34 + 1352829926;
            val_41 = val_41 + val_1054 ^ val_29;
            val_1055 = val_41 + val_1055;
            val_1055 = val_1055 >> 21;
            int val_43 = val_1055 + val_39;
            int val_45 = val_1049 >> 22;
            val_1049 = val_43 ^ (val_1054 | (~((((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (this.H6 | (~((this.H7) << (32-22)) | ((this.H7) << 22))))) + this.X[14]) << (32-22)) | (((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (this.H6 | (~((this.H7) << (32-22)) | ((this.H7) << 22))))) + this.X[14]) << 22))));
            int val_46 = val_6;
            int val_1056 = this.X[9];
            int val_47 = val_39 + 1352829926;
            val_47 = val_47 + val_1049;
            val_1056 = val_47 + val_1056;
            val_1056 = val_1056 >> 19;
            int val_48 = val_8 >> 22;
            val_46 = val_46 >> 18;
            val_1049 = val_1056 + val_45;
            int val_49 = val_43 | (~((((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (this.H6 | (~((this.H7) << (32-22)) | ((th) << (32-22)) | (((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (this.H6 | (~((this.H7) << (32-22)) | ((th) << 22)));
            int val_50 = val_46;
            val_49 = val_1049 ^ val_49;
            int val_52 = val_29 >> 22;
            int val_1057 = this.X[2];
            int val_54 = val_45 + 1352829926;
            val_54 = val_54 + val_49;
            val_1057 = val_54 + val_1057;
            val_1057 = val_1057 >> 17;
            val_45 = val_1057 + val_52;
            val_1054 = val_1054 >> 22;
            int val_57 = val_45 ^ (val_1049 | (~(((((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (thi) << (32-22)) | ((((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (thi) << 22))));
            int val_1058 = this.X[11];
            System.Int32[] val_1060 = this.X;
            val_52 = val_45 | (~(((((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) ) << (32-22)) | ((((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) ) << 22)));
            val_1058 = (val_52 + 1352829926) + val_1058;
            val_1058 = val_1058 >> 17;
            int val_61 = val_1058 + val_1054;
            int val_63 = val_43 >> 22;
            int val_64 = val_16 >> 22;
            int val_65 = val_61;
            int val_66 = val_37 >> 17;
            int val_1059 = val_1060[4];
            int val_69 = val_1054 + 1352829926;
            val_69 = val_69 + val_65;
            val_1059 = val_69 + val_1059;
            val_1059 = val_1059 >> 27;
            val_65 = val_1059 + val_63;
            val_1049 = val_1049 >> 22;
            val_1060 = val_65 ^ (val_61 | (~((((((((((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) >> 22) + 1352829926) + (((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829926) +) << (32-22)) | (((((((((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) >> 22) + 1352829926) + (((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829926) +) << 22))));
            int val_1061 = this.X[13];
            int val_71 = val_63 + 1352829926;
            System.Int32[] val_1063 = this.X;
            val_71 = val_71 + val_1060;
            int val_73 = val_71;
            val_73 = val_73 >> 25;
            val_63 = val_73;
            int val_74 = val_65 | (~((((((((((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (this.H6 | (~((this.H7) << (32-22)) | ((this.H7) << 22))))) + this) << (32-22)) | (((((((((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ^ (this.H6 | (~((this.H7) << (32-22)) | ((this.H7) << 22))))) + this) << 22)));
            val_45 = val_45 >> 22;
            val_1060 = val_63;
            int val_75 = val_50;
            int val_77 = val_6 >> 22;
            int val_1062 = val_1063[6];
            val_75 = val_75 >> 26;
            val_1062 = (val_1049 + 1352829926) + val_1062;
            val_1062 = val_1062 >> 25;
            val_1063 = val_1062;
            int val_79 = val_63;
            if(this.X == null)
            {
                    int val_1066 = val_61;
                int val_1067 = val_66;
            }
            
            int val_80 = val_75;
            int val_83 = val_1063;
            int val_1064 = this.X[15];
            int val_86 = val_45 + 1352829926;
            val_86 = val_86 >> 24;
            val_45 = val_86;
            int val_88 = val_1063 | (~(((((((((((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ) << (32-22)) | ((((((((((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) ) << 22)));
            int val_91 = val_45;
            val_1067 = val_1067;
            int val_1065 = this.X[8];
            int val_94 = val_45;
            val_1065 = ((val_1066 >> 22) + 1352829926) + val_1065;
            val_1065 = val_1065 >> 21;
            val_1066 = val_1065;
            int val_96 = val_1066;
            int val_97 = val_37 >> 22;
            val_1067 = val_1067 >> 25;
            int val_1068 = this.X[1];
            int val_102 = (val_65 >> 22) + 1352829926;
            val_102 = val_102 >> 18;
            int val_103 = val_102;
            int val_104 = val_1066 | (~((((((((((((((((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) >> 22) + 1352829926) + (((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829) << (32-22)) | (((((((((((((((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) + this.X[5]) + 1352829926) >> 24) + this.H9) >> 22) + 1352829926) + (((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829) << 22)));
            int val_107 = val_103;
            int val_1069 = this.X[10];
            int val_110 = val_63 >> 22;
            val_110 = val_110 >> 18;
            int val_112 = val_110;
            int val_113 = val_103;
            int val_114 = val_45 >> 22;
            int val_115 = val_112;
            int val_118 = val_50 >> 22;
            int val_1070 = this.X[3];
            val_1070 = ((val_1063 >> 22) + 1352829926) + val_1070;
            val_1070 = val_1070 >> 20;
            int val_121 = val_1070;
            int val_122 = val_112;
            int val_124 = val_1067 >> 22;
            int val_126 = val_121;
            int val_1071 = this.X[12];
            int val_129 = val_114;
            val_129 = val_129 >> 26;
            int val_130 = val_129;
            val_114 = val_130;
            int val_132 = val_124;
            int val_134 = val_80 >> 22;
            int val_1072 = this.X[7];
            int val_137 = val_66 >> 22;
            val_137 = val_137 >> 25;
            int val_138 = val_137;
            int val_139 = val_138;
            int val_141 = ~val_138;
            int val_1073 = this.X[4];
            int val_144 = val_134;
            val_144 = val_144 >> 26;
            val_134 = val_144;
            int val_145 = val_134;
            int val_147 = ~val_134;
            int val_1074 = this.X[13];
            int val_151 = val_124;
            val_151 = val_151 >> 24;
            int val_152 = val_151;
            int val_153 = val_152;
            int val_156 = ~val_152;
            int val_1075 = this.X[1];
            int val_159 = (val_80 >> 23) >> 22;
            val_159 = val_159 >> 19;
            int val_160 = val_159;
            int val_161 = val_160;
            int val_164 = ~val_160;
            int val_1076 = this.X[10];
            int val_167 = val_130 >> 22;
            val_167 = val_167 >> 21;
            int val_168 = val_167;
            int val_169 = val_168;
            val_134 = val_134 >> 22;
            int val_171 = ~val_168;
            int val_1077 = this.X[6];
            int val_174 = val_138 >> 22;
            val_174 = val_174 >> 23;
            int val_175 = val_174;
            int val_176 = val_175;
            int val_179 = ~val_175;
            int val_1078 = this.X[15];
            int val_182 = val_134;
            val_182 = val_182 >> 25;
            val_134 = val_182;
            int val_183 = val_134;
            val_160 = val_160 >> 22;
            int val_185 = ~val_134;
            int val_1079 = this.X[3];
            int val_188 = val_152 >> 22;
            val_188 = val_188 >> 17;
            int val_189 = val_188;
            int val_190 = val_189;
            int val_193 = ~val_189;
            int val_1080 = this.X[12];
            int val_196 = val_160;
            val_196 = val_196 >> 25;
            int val_197 = val_196;
            val_160 = val_197;
            int val_199 = ~val_197;
            int val_1081 = this.X[0];
            val_168 = (val_168 >> 22) >> 20;
            int val_1082 = this.X[9];
            int val_205 = val_168;
            val_168 = ~val_168;
            int val_1083 = this.X[5];
            int val_206 = val_168;
            int val_1087 = val_112;
            int val_1084 = this.X[2];
            int val_209 = val_175 >> 22;
            val_209 = val_209 >> 17;
            int val_1085 = this.X[14];
            int val_213 = val_209;
            val_1067 = val_1067;
            int val_1086 = this.X[11];
            int val_215 = val_213;
            int val_219 = ~val_213;
            val_1087 = val_1087 >> 22;
            int val_220 = val_1067 >> 24;
            int val_1088 = this.X[8];
            int val_222 = val_1087;
            int val_224 = val_134 >> 22;
            int val_225 = val_121;
            int val_226 = val_103 >> 22;
            int val_1089 = this.X[6];
            val_1089 = (val_1066 >> 22) + val_1089;
            val_1089 = val_1089 + 1548603684;
            val_1089 = val_1089 >> 23;
            int val_228 = val_1089;
            val_224 = val_224 >> 23;
            int val_231 = val_220;
            int val_232 = val_224;
            int val_233 = val_228 & (((((((((((((((((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) +) << (32-22)) | ((((((((((((((((((((this.H6 >> 22) + 1352829926) + (((((((this.H7 >> 22) + 1352829926) + ((((((this.H8 + 1352829926) + ((((((this.H9 + 1352829926) + ((((((this.H5 + ((this.H7 | (~this.H8)) ^ this.H6)) +) << 22));
            int val_1090 = this.X[11];
            int val_236 = val_226;
            val_236 = val_236 >> 19;
            val_226 = val_236;
            int val_238 = val_228 & (~(((((((((((((((((((((((((((((((((((((((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this) << (32-22)) | ((((((((((((((((((((((((((((((((((((((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this) << 22)));
            int val_239 = val_232;
            val_232 = ~val_232;
            int val_240 = val_226;
            int val_241 = val_121 >> 22;
            int val_242 = val_232;
            int val_1091 = this.X[3];
            int val_246 = val_1087;
            val_246 = val_246 >> 17;
            int val_247 = val_246;
            int val_249 = val_226;
            int val_251 = val_247;
            int val_1092 = this.X[7];
            int val_256 = val_241;
            val_256 = val_256 >> 25;
            int val_257 = val_256;
            val_241 = val_257;
            int val_258 = val_247;
            int val_1093 = val_197;
            val_1093 = val_1093 >> 22;
            int val_261 = val_241;
            int val_262 = (val_189 >> 22) >> 21;
            int val_1094 = this.X[0];
            System.Int32[] val_1096 = this.X;
            int val_265 = val_220 >> 22;
            val_265 = val_265 >> 20;
            int val_266 = val_265;
            int val_268 = val_257;
            int val_270 = val_266;
            int val_271 = val_262;
            int val_1095 = val_1096[13];
            int val_275 = val_266;
            val_1095 = ((val_228 >> 22) + 1548603684) + val_1095;
            val_1095 = val_1095 >> 24;
            int val_276 = val_1095;
            val_1096 = val_276;
            int val_277 = ~val_262;
            val_247 = val_247 >> 22;
            int val_279 = val_1096;
            if(this.X.Length <= 5)
            {
                    var val_1098 = val_226 >> 22;
            }
            
            int val_1097 = this.X[5];
            int val_282 = val_1098;
            val_282 = val_282 >> 23;
            int val_283 = val_282;
            val_1098 = val_283;
            int val_285 = val_276;
            int val_286 = val_257 >> 22;
            int val_288 = val_1098;
            int val_1099 = this.X[10];
            int val_292 = val_247;
            val_292 = val_292 >> 21;
            int val_293 = val_292;
            int val_296 = val_283;
            int val_297 = val_1093 >> 25;
            int val_299 = val_293;
            int val_1100 = this.X[14];
            int val_302 = val_286;
            val_302 = val_302 >> 25;
            val_286 = val_302;
            int val_304 = val_293;
            int val_305 = val_297;
            int val_307 = val_286;
            if(this.X.Length <= 15)
            {
                    var val_1102 = val_266 >> 22;
            }
            
            int val_309 = ~val_297;
            int val_1101 = this.X[15];
            int val_313 = val_1102;
            val_313 = val_313 >> 25;
            int val_314 = val_313;
            val_1102 = val_314;
            int val_315 = val_286;
            int val_318 = val_1102;
            int val_1103 = this.X[8];
            int val_322 = val_276 >> 22;
            val_322 = val_322 >> 20;
            int val_323 = val_322;
            int val_325 = val_314;
            val_293 = val_293 >> 22;
            int val_328 = val_323;
            int val_1104 = this.X[12];
            int val_331 = val_283 >> 22;
            val_331 = val_331 >> 25;
            int val_332 = val_331;
            int val_333 = (val_168 >> 22) >> 19;
            int val_335 = val_323;
            int val_337 = val_332;
            int val_338 = val_333;
            int val_1105 = this.X[4];
            int val_342 = val_293;
            val_342 = val_342 >> 26;
            int val_343 = val_342;
            int val_344 = ~val_333;
            int val_346 = val_332;
            int val_1106 = this.X[9];
            int val_348 = val_343;
            int val_1107 = this.X[1];
            int val_353 = val_286 >> 22;
            int val_357 = (val_213 >> 22) >> 20;
            int val_1108 = this.X[2];
            val_353 = val_353 >> 17;
            int val_360 = val_357;
            int val_361 = val_262 >> 22;
            int val_1109 = this.X[3];
            int val_364 = val_232 >> 22;
            val_364 = val_364 >> 21;
            int val_365 = val_364;
            int val_368 = val_365;
            int val_1110 = this.X[10];
            int val_371 = val_361;
            val_371 = val_371 >> 19;
            val_361 = val_371;
            int val_373 = val_361;
            int val_1111 = this.X[14];
            int val_377 = val_353 >> 22;
            val_377 = val_377 >> 26;
            int val_378 = val_377;
            val_357 = val_357 >> 22;
            int val_380 = val_378;
            int val_1112 = this.X[4];
            int val_383 = val_333 >> 22;
            val_383 = val_383 >> 25;
            int val_384 = val_383;
            val_365 = val_365 >> 22;
            int val_386 = val_384;
            int val_1113 = this.X[9];
            int val_389 = val_357;
            val_389 = val_389 >> 18;
            int val_390 = val_389;
            int val_392 = val_361 >> 22;
            int val_393 = val_390;
            int val_1114 = this.X[15];
            int val_396 = val_365;
            val_396 = val_396 >> 23;
            int val_397 = val_396;
            val_378 = val_378 >> 22;
            int val_399 = val_397;
            int val_1115 = this.X[8];
            int val_402 = val_392;
            val_402 = val_402 >> 19;
            val_392 = val_402;
            int val_405 = val_392;
            int val_1116 = this.X[1];
            int val_408 = val_378;
            val_408 = val_408 >> 17;
            int val_409 = val_408;
            val_378 = val_409;
            int val_410 = val_378;
            int val_1117 = this.X[2];
            val_384 >> 22 = val_384 >> 22;
            int val_412 = val_384 >> 22;
            int val_1118 = this.X[7];
            val_412 = val_412 >> 18;
            int val_415 = val_343;
            int val_416 = val_412;
            int val_417 = val_353;
            int val_1119 = this.X[0];
            int val_419 = val_314 >> 22;
            int val_421 = val_416;
            int val_1120 = this.X[6];
            val_419 = val_419 >> 19;
            int val_427 = val_419;
            int val_1121 = this.X[13];
            int val_431 = val_353;
            int val_432 = (val_390 >> 22) >> 24;
            int val_433 = val_427;
            int val_1122 = this.X[11];
            int val_436 = val_323 >> 22;
            int val_437 = val_432;
            int val_1123 = this.X[5];
            val_436 = val_436 >> 21;
            int val_442 = val_436;
            int val_1124 = this.X[12];
            val_436 = val_442;
            int val_447 = (val_397 >> 22) >> 19;
            int val_448 = val_436;
            int val_1125 = this.X[15];
            int val_453 = val_332 >> 22;
            val_453 = val_453 >> 23;
            int val_454 = val_453;
            int val_456 = val_454;
            int val_457 = val_447;
            int val_1126 = this.X[5];
            int val_462 = val_343 >> 22;
            val_462 = val_462 >> 25;
            int val_463 = val_462;
            int val_465 = val_427 >> 22;
            int val_466 = val_463;
            int val_467 = val_392 >> 22;
            int val_1127 = this.X[1];
            val_467 = val_467 >> 26;
            int val_471 = val_297 >> 22;
            val_471 = val_471 >> 17;
            int val_472 = val_471;
            int val_474 = val_467;
            val_442 = val_442 >> 22;
            int val_475 = val_472;
            int val_1128 = this.X[3];
            int val_479 = val_465;
            val_479 = val_479 >> 21;
            int val_480 = val_479;
            val_465 = val_480;
            int val_481 = val_465;
            int val_482 = val_474;
            int val_484 = val_454 >> 22;
            int val_1129 = this.X[7];
            int val_487 = val_442;
            val_487 = val_487 >> 24;
            val_442 = val_487;
            int val_490 = val_409 >> 22;
            int val_492 = val_442;
            int val_1130 = this.X[14];
            val_490 = val_490 >> 27;
            int val_496 = val_484;
            val_496 = val_496 >> 26;
            int val_497 = val_496;
            val_484 = val_497;
            int val_498 = val_490;
            val_472 = val_472 >> 22;
            int val_499 = val_484;
            val_490 = val_498;
            int val_1131 = this.X[6];
            int val_502 = val_463 >> 22;
            val_502 = val_502 >> 26;
            int val_503 = val_502;
            int val_505 = val_503;
            int val_506 = val_490;
            int val_1132 = this.X[9];
            int val_511 = val_472;
            val_511 = val_511 >> 18;
            val_472 = val_511;
            val_442 = val_442 >> 22;
            int val_514 = val_472;
            val_416 >> 22 = val_416 >> 22;
            int val_1133 = this.X[11];
            val_416 >> 22 = (val_416 >> 22) >> 20;
            int val_518 = val_480 >> 22;
            val_518 = val_518 >> 20;
            int val_519 = val_518;
            int val_521 = val_416 >> 22;
            val_497 = val_497 >> 22;
            int val_522 = val_519;
            int val_1134 = this.X[8];
            int val_526 = val_442;
            val_526 = val_526 >> 19;
            int val_527 = val_526;
            int val_529 = val_521;
            int val_1135 = this.X[12];
            val_527 = val_527;
            int val_1136 = this.X[2];
            int val_539 = (val_432 >> 22) >> 25;
            int val_1137 = this.X[10];
            int val_541 = val_497 >> 27;
            int val_545 = val_539;
            int val_1138 = this.X[0];
            int val_547 = val_541;
            int val_1139 = this.X[4];
            int val_556 = (val_447 >> 22) >> 27;
            int val_557 = val_521 >> 22;
            int val_1140 = this.X[13];
            int val_558 = (val_503 >> 22) >> 18;
            int val_560 = val_539;
            int val_561 = val_558 >> 22;
            int val_562 = val_498 >> 22;
            int val_563 = val_556;
            int val_1141 = this.X[1];
            int val_566 = val_563;
            val_566 = val_566 >> 21;
            val_563 = val_566;
            int val_568 = val_556;
            int val_569 = val_563;
            int val_1142 = this.X[9];
            int val_572 = val_562;
            val_572 = val_572 >> 20;
            val_562 = val_572;
            int val_574 = val_563;
            val_539 = val_539 >> 22;
            int val_575 = val_562;
            int val_1143 = this.X[11];
            int val_578 = val_557;
            val_578 = val_578 >> 18;
            val_557 = val_578;
            int val_580 = val_562;
            val_556 = val_556 >> 22;
            int val_581 = val_557;
            int val_1144 = this.X[10];
            int val_585 = val_539;
            val_585 = val_585 >> 17;
            val_539 = val_585;
            int val_587 = val_557;
            int val_589 = val_558;
            int val_591 = val_539;
            int val_1145 = this.X[0];
            int val_594 = val_556;
            val_594 = val_594 >> 18;
            int val_595 = val_594;
            int val_598 = val_539;
            int val_599 = val_595;
            int val_600 = val_472 >> 22;
            int val_601 = val_562 >> 22;
            int val_1146 = this.X[8];
            val_600 = val_600 >> 19;
            int val_605 = val_563 >> 22;
            val_605 = val_605 >> 17;
            int val_606 = val_605;
            int val_608 = val_595;
            int val_609 = val_600;
            int val_611 = val_606;
            int val_1147 = this.X[12];
            int val_1151 = val_595;
            int val_615 = val_601;
            val_615 = val_615 >> 23;
            int val_616 = val_615;
            val_601 = val_616;
            int val_617 = val_606;
            val_539 = val_539 >> 22;
            int val_618 = val_609;
            int val_620 = val_601;
            int val_1148 = this.X[4];
            int val_624 = val_557 >> 22;
            val_624 = val_624 >> 24;
            int val_625 = val_624;
            int val_627 = val_616;
            int val_629 = val_625;
            int val_1149 = this.X[13];
            int val_633 = val_539;
            int val_634 = (val_519 >> 22) >> 19;
            int val_1150 = this.X[3];
            int val_635 = val_633;
            val_1151 = val_1151 >> 22;
            val_633 = val_635 >> 23;
            int val_637 = val_634;
            int val_1152 = this.X[7];
            val_635 = val_633;
            int val_641 = val_625;
            int val_642 = val_527 >> 22;
            int val_1153 = this.X[15];
            int val_643 = val_635;
            val_642 = val_642 >> 25;
            int val_647 = val_642;
            int val_1154 = this.X[14];
            int val_652 = val_647;
            int val_1155 = this.X[5];
            int val_654 = val_1151 >> 18;
            int val_657 = val_635;
            int val_1156 = this.X[6];
            val_654 = val_654;
            val_634 = val_634 >> 22;
            int val_662 = (val_541 >> 22) >> 27;
            int val_1157 = this.X[2];
            int val_664 = val_606 >> 22;
            int val_665 = val_662;
            val_664 = val_664 >> 27;
            int val_666 = val_609 >> 22;
            int val_668 = val_634;
            int val_1158 = this.X[8];
            int val_671 = val_474 >> 22;
            val_671 = val_671 >> 17;
            int val_672 = val_671;
            int val_673 = val_664;
            int val_674 = val_672;
            int val_676 = ~val_672;
            int val_678 = val_654;
            int val_1159 = this.X[6];
            int val_682 = val_666;
            val_682 = val_682 >> 27;
            int val_683 = val_673;
            val_666 = val_682;
            int val_684 = val_666;
            int val_687 = ~val_666;
            int val_688 = val_647 >> 22;
            int val_1160 = this.X[4];
            int val_692 = val_634;
            val_692 = val_692 >> 24;
            int val_693 = val_692;
            int val_694 = val_693;
            int val_696 = (val_616 >> 22) >> 26;
            int val_699 = ~val_693;
            int val_1161 = this.X[1];
            int val_702 = val_688;
            val_702 = val_702 >> 21;
            int val_703 = val_702;
            int val_704 = val_696;
            int val_705 = val_703;
            val_688 = ~val_703;
            val_672 = val_672 >> 22;
            int val_706 = val_688;
            val_696 = val_704;
            int val_707 = val_673;
            int val_1162 = this.X[3];
            int val_711 = val_662 >> 22;
            val_711 = val_711 >> 18;
            int val_712 = val_711;
            int val_713 = val_712;
            int val_714 = val_696;
            int val_718 = ~val_712;
            int val_719 = val_625 >> 22;
            int val_1163 = this.X[11];
            int val_722 = val_672;
            val_722 = val_722 >> 18;
            int val_723 = val_722;
            int val_724 = val_723;
            val_719 = val_719 >> 24;
            int val_727 = ~val_723;
            int val_1164 = this.X[15];
            int val_731 = val_666 >> 22;
            int val_732 = val_719;
            val_731 = val_731 >> 26;
            int val_733 = val_731;
            int val_734 = val_733;
            int val_737 = val_704;
            int val_738 = ~val_733;
            int val_740 = val_732;
            int val_1165 = this.X[0];
            int val_744 = val_693 >> 22;
            val_744 = val_744 >> 18;
            int val_745 = val_744;
            int val_746 = val_745;
            int val_749 = ~val_745;
            int val_752 = val_635 >> 22;
            int val_1166 = this.X[5];
            int val_754 = val_703 >> 22;
            val_754 = val_754 >> 26;
            int val_755 = val_754;
            int val_756 = val_755;
            var val_1168 = val_712 >> 22;
            val_752 = val_752 >> 26;
            val_723 = val_723 >> 22;
            int val_759 = ~val_755;
            int val_1167 = this.X[12];
            int val_762 = val_1168;
            val_762 = val_762 >> 23;
            int val_763 = val_762;
            int val_764 = val_752;
            int val_765 = val_763;
            val_1168 = ~val_763;
            val_733 = val_733 >> 22;
            int val_766 = val_1168;
            int val_768 = val_732;
            int val_769 = val_764;
            int val_1169 = this.X[2];
            int val_773 = val_723;
            val_773 = val_773 >> 20;
            int val_774 = val_773;
            int val_775 = val_774;
            int val_779 = ~val_774;
            int val_781 = val_654 >> 22;
            int val_1170 = this.X[13];
            int val_783 = val_733;
            val_783 = val_783 >> 23;
            int val_784 = val_783;
            int val_785 = val_784;
            val_781 = val_781 >> 27;
            int val_787 = ~val_784;
            int val_789 = val_755 >> 22;
            int val_1171 = this.X[9];
            int val_791 = val_745 >> 22;
            int val_792 = val_791;
            val_792 = val_792 >> 20;
            val_791 = val_792;
            int val_793 = val_781;
            int val_794 = val_791;
            int val_798 = val_764;
            int val_799 = ~val_791;
            int val_1172 = this.X[7];
            int val_802 = val_789;
            int val_803 = val_802;
            val_803 = val_803 >> 27;
            val_802 = val_803;
            int val_804 = val_793;
            int val_805 = val_802;
            val_789 = ~val_802;
            int val_807 = val_789;
            int val_1174 = val_704;
            int val_1173 = this.X[10];
            int val_814 = (val_763 >> 22) >> 17;
            val_1174 = val_1174 >> 22;
            int val_1175 = this.X[14];
            int val_817 = (val_673 >> 22) >> 20;
            int val_819 = val_814;
            int val_820 = val_732 >> 22;
            int val_1176 = this.X[4];
            int val_823 = val_1174;
            val_823 = val_823 >> 23;
            int val_824 = val_823;
            int val_825 = val_817;
            int val_826 = val_824;
            int val_1177 = this.X[0];
            int val_829 = val_820;
            val_829 = val_829 >> 17;
            val_820 = val_829;
            int val_830 = val_824;
            int val_832 = val_820;
            int val_1178 = this.X[5];
            int val_835 = val_764 >> 22;
            val_835 = val_835 >> 27;
            int val_836 = val_835;
            int val_837 = val_820;
            int val_839 = val_836;
            int val_1179 = this.X[9];
            int val_842 = val_814 >> 22;
            val_842 = val_842 >> 21;
            val_814 = val_842;
            int val_843 = val_836;
            int val_844 = val_824 >> 22;
            int val_845 = val_814;
            int val_1180 = this.X[7];
            int val_848 = val_817 >> 22;
            val_848 = val_848 >> 26;
            int val_849 = val_848;
            int val_850 = val_814;
            int val_851 = val_849;
            int val_1181 = this.X[12];
            val_820 = val_820 >> 22;
            val_844 = val_844 >> 24;
            int val_855 = val_844;
            int val_856 = val_849;
            int val_1182 = this.X[2];
            int val_857 = val_855;
            int val_1183 = this.X[10];
            int val_1184 = this.X[14];
            int val_863 = val_820 >> 19;
            int val_864 = val_855;
            int val_865 = val_863;
            int val_1185 = this.X[1];
            int val_868 = val_836 >> 22;
            int val_1186 = this.X[3];
            val_868 = val_868 >> 20;
            int val_870 = val_868;
            int val_871 = val_863;
            int val_1187 = this.X[8];
            int val_872 = val_870;
            int val_1188 = this.X[11];
            int val_878 = val_814;
            int val_1189 = this.X[6];
            int val_880 = (val_814 >> 22) >> 27;
            int val_881 = ~val_814;
            int val_882 = val_870;
            int val_884 = val_880;
            int val_1190 = this.X[15];
            var val_1194 = val_863;
            val_849 >> 22 = val_849 >> 22;
            int val_890 = val_784 >> 22;
            int val_891 = val_802 >> 22;
            int val_1191 = this.X[13];
            val_849 >> 22 = (val_849 >> 22) >> 20;
            int val_893 = (val_774 >> 22) >> 24;
            int val_895 = val_849 >> 22;
            int val_897 = val_880;
            int val_898 = val_791 >> 22;
            int val_1192 = this.X[12];
            int val_901 = val_891;
            val_901 = val_901 >> 24;
            int val_902 = val_901;
            int val_903 = val_895;
            int val_1193 = this.X[15];
            int val_908 = val_855 >> 22;
            int val_910 = val_893;
            val_910 = val_910 >> 27;
            val_1034 = val_910;
            if(this.X == null)
            {
                    val_1034 = val_1034;
            }
            
            val_1194 = val_1194 >> 22;
            val_908 = val_908 >> 19;
            int val_911 = val_793 >> 22;
            if(this.X.Length <= 10)
            {
                    val_1034 = val_1034;
            }
            
            int val_1195 = this.X[10];
            int val_913 = val_908;
            int val_914 = val_895;
            int val_916 = val_902;
            val_916 = val_916 >> 20;
            val_891 = val_916;
            if(this.X == null)
            {
                    val_1034 = val_1034;
            }
            
            int val_918 = val_913;
            int val_920 = val_893 >> 22;
            int val_921 = val_1034;
            if(this.X.Length <= 4)
            {
                    val_1034 = val_1034;
            }
            
            int val_1196 = this.X[4];
            int val_924 = val_921;
            val_924 = val_924 >> 23;
            val_921 = val_924;
            if(this.X == null)
            {
                    val_1034 = val_1034;
            }
            
            int val_926 = val_902 >> 22;
            int val_928 = val_1194;
            if(this.X.Length <= 1)
            {
                    val_1034 = val_1034;
            }
            
            val_928 = val_928 >> 18;
            int val_1197 = this.X[1];
            int val_932 = val_891;
            val_932 = val_932 >> 20;
            val_1035 = val_932;
            if(this.X == null)
            {
                    val_1035 = val_1035;
                val_1034 = val_1034;
            }
            
            int val_933 = val_928;
            int val_934 = val_921;
            int val_935 = val_913;
            int val_936 = val_1034 >> 22;
            if(this.X.Length <= 5)
            {
                    val_1035 = val_1035;
            }
            
            int val_1198 = this.X[5];
            int val_937 = val_870 >> 22;
            int val_939 = val_934;
            val_939 = val_939 >> 27;
            int val_940 = val_933;
            val_934 = val_939;
            if(this.X == null)
            {
                    val_1035 = val_1035;
            }
            
            int val_943 = val_891 >> 22;
            val_891 = val_1035;
            if(this.X.Length <= 8)
            {
                    val_1035 = val_1035;
            }
            
            int val_1199 = this.X[8];
            int val_946 = val_891;
            val_946 = val_946 >> 18;
            val_1036 = val_946;
            if(this.X == null)
            {
                    val_1036 = val_1036;
                val_1035 = val_1035;
            }
            
            val_937 = val_937 >> 21;
            int val_948 = val_921 >> 22;
            val_921 = val_934;
            if(this.X.Length <= 7)
            {
                    val_1036 = val_1036;
                val_1035 = val_1035;
            }
            
            int val_1200 = this.X[7];
            int val_950 = val_937;
            int val_951 = val_933;
            int val_953 = val_921;
            val_953 = val_953 >> 26;
            int val_954 = val_953;
            if(this.X == null)
            {
                    val_1036 = val_1036;
                val_1035 = val_1035;
            }
            
            int val_956 = val_950;
            int val_958 = val_1035 >> 22;
            if(this.X.Length <= 6)
            {
                    val_1036 = val_1036;
            }
            
            int val_1201 = this.X[6];
            int val_962 = val_1036;
            val_962 = val_962 >> 24;
            val_1037 = val_962;
            if(this.X == null)
            {
                    val_1036 = val_1036;
                val_1037 = val_1037;
            }
            
            int val_964 = val_880 >> 22;
            int val_965 = val_934 >> 22;
            if(this.X.Length <= 2)
            {
                    int val_1202 = val_1037;
                val_1036 = val_1036;
                val_1037 = val_1202;
            }
            
            val_964 = val_964 >> 24;
            val_1202 = val_1037;
            int val_1203 = this.X[2];
            int val_969 = val_954;
            val_969 = val_969 >> 19;
            int val_970 = val_969;
            if(this.X == null)
            {
                    val_1036 = val_1036;
            }
            
            val_1038 = val_964;
            int val_971 = val_1036 >> 22;
            int val_972 = val_950;
            if(this.X.Length <= 13)
            {
                    val_1038 = val_1038;
            }
            
            int val_1204 = this.X[13];
            int val_974 = val_1038;
            int val_977 = val_1202;
            val_977 = val_977 >> 26;
            int val_978 = val_977;
            if(this.X == null)
            {
                    val_1038 = val_1038;
            }
            
            int val_981 = val_954 >> 22;
            val_954 = val_970;
            if(this.X.Length <= 14)
            {
                    val_1038 = val_1038;
            }
            
            int val_1205 = this.X[14];
            int val_984 = val_954;
            val_984 = val_984 >> 27;
            val_954 = val_984;
            if(this.X == null)
            {
                    val_1038 = val_1038;
            }
            
            int val_989 = val_1037 >> 22;
            if(this.X.Length == 0)
            {
                    val_1038 = val_1038;
            }
            
            int val_1206 = this.X[0];
            val_1039 = (val_895 >> 22) >> 27;
            int val_991 = val_1038;
            int val_993 = val_978;
            val_993 = val_993 >> 17;
            int val_994 = val_993;
            if(this.X == null)
            {
                    val_1039 = val_1039;
                val_1038 = val_1038;
            }
            
            int val_996 = val_1039;
            int val_998 = val_970 >> 22;
            if(this.X.Length <= 3)
            {
                    val_1039 = val_1039;
                val_1038 = val_1038;
            }
            
            int val_1207 = this.X[3];
            int val_1001 = val_954;
            val_1001 = val_1001 >> 19;
            val_1040 = val_1001;
            if(this.X == null)
            {
                    val_1040 = val_1040;
                val_1039 = val_1039;
                val_1038 = val_1038;
            }
            
            int val_1003 = val_978 >> 22;
            val_978 = val_994;
            val_913 >> 22 = val_913 >> 22;
            if(this.X.Length <= 9)
            {
                    val_1040 = val_1040;
                val_1039 = val_1039;
                val_1038 = val_1038;
            }
            
            val_913 >> 22 = (val_913 >> 22) >> 26;
            int val_1005 = val_933 >> 22;
            int val_1208 = this.X[9];
            int val_1007 = val_978;
            val_1007 = val_1007 >> 21;
            int val_1008 = val_1007;
            if(this.X == null)
            {
                    val_1040 = val_1040;
                val_1039 = val_1039;
                val_1038 = val_1038;
            }
            
            val_1041 = val_950 >> 22;
            val_1042 = val_1038 >> 22;
            int val_1010 = val_954 >> 22;
            int val_1011 = val_994 >> 22;
            if(this.X.Length <= 11)
            {
                    val_1039 = val_1039;
                val_1042 = val_1042;
                val_1040 = val_1040;
                val_1041 = val_1041;
            }
            
            int val_1209 = this.X[11];
            int val_1014 = val_1040;
            val_1014 = val_1014 >> 21;
            val_1040 = val_1040 >> 22;
            this.H0 = this.H0;
            this.H1 = val_913 >> 22;
            val_1043 = 0;
            this.H2 = this.H2;
            this.H3 = this.H3;
            this.H4 = this.H4;
            this.H5 = this.H5;
            this.H7 = this.H7;
            this.H8 = this.H8;
            this.H9 = this.H9;
            this.H6 = val_1014;
            this.xOff = 0;
            goto label_320;
            label_324:
            val_1043 = 1;
            this.X[0] = 0;
            label_320:
            if(val_1043 != this.X.Length)
            {
                goto label_324;
            }
        
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.RipeMD320Digest(t:  this);
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
