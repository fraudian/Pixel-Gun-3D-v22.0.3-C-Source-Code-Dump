using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class RipeMD160Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 20;
        private int H0;
        private int H1;
        private int H2;
        private int H3;
        private int H4;
        private int[] X;
        private int xOff;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public RipeMD160Digest()
        {
            this.X = new int[16];
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD160Digest).__il2cppRuntimeField_1F8;
        }
        public RipeMD160Digest(Org.BouncyCastle.Crypto.Digests.RipeMD160Digest t)
        {
            this.X = new int[16];
            Org.BouncyCastle.Crypto.Digests.RipeMD160Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.RipeMD160Digest t)
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
            if(1 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public override string get_AlgorithmName()
        {
            return "RIPEMD160";
        }
        public override int GetDigestSize()
        {
            return 20;
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
            goto typeof(Org.BouncyCastle.Crypto.Digests.RipeMD160Digest).__il2cppRuntimeField_228;
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
            return 20;
        }
        public override void Reset()
        {
            var val_1;
            this.Reset();
            val_1 = 0;
            this.H4 = -1009589776;
            this.H0 = ;
            this.H1 = ;
            this.H2 = 1167088121787636990;
            this.H3 = 271733878;
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
            int val_1061;
            int val_1062;
            int val_1063;
            int val_1064;
            int val_1065;
            var val_1066;
            int val_1067;
            var val_1068;
            int val_1056 = this.H0;
            int val_1059 = this.H1;
            int val_1058 = this.H2;
            int val_1062 = this.H4;
            int val_1 = val_1058 ^ val_1059;
            val_1 = val_1 ^ this.H3;
            int val_1054 = this.X[0];
            int val_2 = val_1 + val_1056;
            int val_3 = val_1059 ^ (((this.H2) << (32-22)) | ((this.H2) << 22));
            val_1054 = val_2 + val_1054;
            val_1054 = val_1054 >> 21;
            int val_4 = val_1054 + val_1062;
            val_3 = val_3 ^ val_4;
            int val_1055 = this.X[1];
            val_2 = val_3 + val_1062;
            val_1056 = val_4 ^ (((this.H1) << (32-22)) | ((this.H1) << 22));
            val_1055 = val_2 + val_1055;
            val_1055 = val_1055 >> 18;
            val_3 = val_1055 + this.H3;
            int val_5 = val_1058 >> 22;
            val_1056 = val_1056 ^ val_3;
            int val_1057 = this.X[2];
            val_2 = val_1056 + this.H3;
            val_1058 = val_3 ^ (((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) << (32-22)) | ((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) << 22));
            val_1057 = val_2 + val_1057;
            val_1057 = val_1057 >> 17;
            val_1056 = val_1057 + val_5;
            val_1059 = val_1059 >> 22;
            val_1058 = val_1058 ^ val_1056;
            int val_1060 = this.X[3];
            val_2 = val_1058 + val_5;
            val_1060 = val_2 + val_1060;
            val_1060 = val_1060 >> 20;
            val_5 = val_1060 + val_1059;
            int val_6 = val_1056 ^ (((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3)) << (32-22)) | ((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3)) << 22));
            val_4 = val_4 >> 22;
            val_6 = val_6 ^ val_5;
            int val_1061 = this.X[4];
            val_2 = val_6 + val_1059;
            int val_7 = val_5 ^ (((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ (((((() << (32-22)) | ((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ (((((() << 22));
            val_1061 = val_2 + val_1061;
            val_1061 = val_1061 >> 27;
            val_1062 = val_1061 + val_4;
            val_7 = val_7 ^ val_1062;
            int val_1063 = this.X[5];
            val_2 = val_7 + val_4;
            val_3 = val_3 >> 22;
            val_1063 = val_2 + val_1063;
            val_4 = val_1063 >> 24;
            val_1059 = val_4 + val_3;
            int val_8 = val_1062 ^ (((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((((((((t) << (32-22)) | ((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((((((((t) << 22));
            int val_1064 = this.X[6];
            val_8 = val_8 ^ val_1059;
            val_3 = val_8 + val_3;
            val_1064 = val_3 + val_1064;
            int val_9 = val_1056 >> 22;
            val_1064 = val_1064 >> 25;
            int val_1066 = this.X[8];
            val_1056 = val_1064 + val_9;
            int val_1067 = this.X[9];
            val_9 = ((val_1059 ^ (((((((((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ) << (32-22)) | ((((((((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ) << 22))) ^ val_1056) + val_9;
            int val_12 = val_9 + this.X[7];
            int val_1068 = this.X[10];
            int val_13 = val_5 >> 22;
            val_5 = (val_12 >> 23) + val_13;
            int val_15 = val_1056 ^ (((((((((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((() << (32-22)) | ((((((((((((((((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 22)) ^ ((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4)) + this.H4) + this.X[1]) >> 18) + this.H3) ^ ((() << 22));
            int val_1069 = this.X[11];
            val_15 = val_15 ^ val_5;
            val_13 = val_15 + val_13;
            int val_1070 = this.X[12];
            int val_17 = val_1062 >> 22;
            val_15 = val_13 >> 21;
            int val_1071 = this.X[13];
            int val_1079 = val_1062;
            val_12 = val_15;
            int val_1072 = this.X[14];
            int val_1073 = this.X[15];
            System.Int32[] val_1076 = this.X;
            int val_22 = val_1059 >> 22;
            int val_24 = val_1058 | (~this.H3);
            val_2 = (val_5 ^ (((((((((((((((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 2) << (32-22)) | ((((((((((((((((((((((((((this.H2 ^ this.H1) ^ this.H3) + this.H0) + this.X[0]) >> 21) + this.H4) ^ ((this.H1) << (32-22)) | ((this.H1) << 22)) ^ ((((((this.H1 ^ ((this.H2) << (32-22)) | ((this.H2) << 2) << 22))) >> 19;
            int val_1077 = val_1059;
            val_24 = val_24 ^ val_1077;
            int val_1075 = val_1056;
            int val_1074 = val_1076[5];
            val_1075 = val_1075 + val_24;
            val_1074 = val_1075 + val_1074;
            val_1074 = val_1074 + 1352829926;
            val_1074 = val_1074 >> 24;
            val_1076 = val_1074 + val_1079;
            val_1077 = val_1077 | (~val_5);
            int val_28 = val_1076 ^ val_1077;
            int val_29 = val_1079 + 1352829926;
            int val_1078 = this.X[14];
            val_29 = val_29 + val_28;
            System.Int32[] val_1081 = this.X;
            val_1078 = val_29 + val_1078;
            val_1078 = val_1078 >> 23;
            val_28 = val_1078 + this.H3;
            val_1079 = val_1076 | (~val_1059);
            val_1056 = val_1056 >> 22;
            int val_33 = val_12 >> 18;
            int val_1080 = val_1081[7];
            int val_35 = this.H3 + 1352829926;
            val_35 = val_35 + val_28 ^ val_1079;
            val_1080 = val_35 + val_1080;
            val_1080 = val_1080 >> 23;
            int val_36 = val_28 | (~((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4)) << (32-22)) | (((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4)) << 22)));
            val_1081 = val_1080 + val_5;
            val_36 = val_1081 ^ val_36;
            int val_1082 = this.X[0];
            int val_38 = val_5 + 1352829926;
            val_38 = val_38 + val_36;
            val_1082 = val_38 + val_1082;
            val_1082 = val_1082 >> 21;
            int val_40 = val_1082 + val_1059;
            int val_42 = val_1076 >> 22;
            val_1076 = val_40 ^ (val_1081 | (~((((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + this.X[14]) >> 23) + this.H3)) << (32-22)) | (((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + this.X[14]) >> 23) + this.H3)) << 22))));
            int val_43 = val_2;
            int val_44 = val_5 >> 22;
            int val_1083 = this.X[9];
            int val_45 = val_1059 + 1352829926;
            val_45 = val_45 + val_1076;
            System.Int32[] val_1085 = this.X;
            val_1083 = val_45 + val_1083;
            val_1083 = val_1083 >> 19;
            val_1081 = val_1083 + val_42;
            val_43 = val_43 >> 17;
            int val_46 = val_40 | (~((((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + this.X[) << (32-22)) | (((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + this.X[) << 22)));
            int val_47 = val_43;
            val_46 = val_1081 ^ val_46;
            int val_1084 = val_1085[2];
            int val_49 = val_28 >> 22;
            int val_51 = val_42 + 1352829926;
            val_51 = val_51 + val_46;
            val_1084 = val_51 + val_1084;
            val_1085 = val_1084 >> 17;
            int val_52 = val_1085 + val_49;
            int val_55 = val_52 ^ (val_1081 | (~(((((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (thi) << (32-22)) | ((((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (thi) << 22))));
            int val_56 = val_33;
            val_56 = val_56 >> 26;
            int val_59 = val_12 >> 22;
            int val_60 = (val_49 + 1352829926) + this.X[11];
            int val_61 = val_56;
            int val_63 = val_1081 >> 22;
            val_60 = (val_60 >> 17) + val_63;
            int val_67 = val_52 | (~(((((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) ) << (32-22)) | ((((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) ) << 22)));
            int val_69 = val_63 + 1352829926;
            int val_73 = val_2 >> 22;
            int val_74 = val_47 >> 25;
            int val_1090 = this.X[15];
            val_69 = ((val_69 + val_60) + this.X[4]) >> 27;
            int val_78 = val_40 >> 22;
            val_69 = val_69 + val_78;
            int val_80 = val_60 | (~((((((((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) >> 22) + 1352829926) + (((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829926) +) << (32-22)) | (((((((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) >> 22) + 1352829926) + (((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829926) +) << 22)));
            val_80 = val_69 ^ val_80;
            val_78 = val_78 + 1352829926;
            int val_81 = val_61;
            val_81 = val_81 >> 23;
            int val_83 = val_33 >> 22;
            int val_1092 = this.X[1];
            int val_89 = val_1081 >> 22;
            int val_1093 = this.X[10];
            int val_90 = ((val_78 + this.X[13]) >> 25) + val_89;
            val_74 = val_74;
            int val_91 = val_69 | (~((((((((((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + this.X[14]) >> 23) + this.H3) >) << (32-22)) | (((((((((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + this.X[14]) >> 23) + this.H3) >) << 22)));
            int val_92 = val_90;
            int val_94 = val_74;
            int val_1094 = this.X[3];
            int val_96 = val_47 >> 22;
            val_94 = val_94 >> 24;
            int val_97 = val_94;
            int val_98 = (val_89 + 1352829926) + this.X[6];
            int val_99 = val_74 >> 22;
            int val_1098 = val_61;
            val_98 = val_98 >> 25;
            int val_100 = val_52 >> 22;
            int val_1095 = this.X[12];
            int val_102 = val_97;
            int val_103 = val_98;
            val_90 = val_90 | (~((((((((((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + t) << (32-22)) | (((((((((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ^ (this.H1 | (~(this.H2 >> 22))))) + t) << 22)));
            int val_105 = val_99;
            val_100 = val_100 + 1352829926;
            int val_1096 = this.X[7];
            int val_108 = val_96;
            val_108 = val_108 >> 25;
            val_96 = val_108;
            int val_109 = val_103;
            int val_110 = val_96;
            int val_113 = ~val_96;
            int val_1097 = this.X[4];
            int val_117 = val_1098 >> 22;
            val_117 = val_117 >> 26;
            int val_118 = val_117;
            int val_1099 = val_81;
            val_1098 = val_118;
            val_1099 = val_1099 >> 22;
            int val_121 = val_60 >> 22;
            int val_122 = ~val_118;
            int val_123 = val_100 >> 24;
            int val_124 = val_103 | (~(((((((((((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ) << (32-22)) | ((((((((((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) ) << 22)));
            int val_1100 = this.X[13];
            int val_127 = val_99;
            val_127 = val_127 >> 24;
            int val_128 = val_127;
            int val_129 = val_128;
            val_121 = val_121 + 1352829926;
            int val_131 = val_123;
            int val_133 = ~val_128;
            int val_1101 = this.X[1];
            int val_136 = val_1099;
            val_136 = val_136 >> 19;
            int val_138 = val_136;
            int val_139 = val_138;
            int val_142 = val_121 + this.X[8];
            int val_143 = ~val_138;
            int val_144 = val_69 >> 22;
            int val_1102 = this.X[10];
            val_142 = val_142 >> 21;
            int val_147 = val_97 >> 22;
            val_147 = val_147 >> 21;
            int val_148 = val_147;
            int val_149 = val_148;
            int val_151 = val_142;
            int val_152 = ~val_148;
            int val_153 = val_123;
            val_144 = val_144 + 1352829926;
            int val_1103 = this.X[6];
            int val_157 = val_96 >> 22;
            val_157 = val_157 >> 23;
            int val_158 = val_157;
            int val_159 = val_151;
            int val_160 = val_158;
            int val_164 = ~val_158;
            if(this.X.Length <= 15)
            {
                    var val_1105 = val_118 >> 22;
            }
            
            int val_1104 = this.X[15];
            int val_168 = val_1105;
            val_168 = val_168 >> 25;
            int val_169 = val_168;
            val_1105 = val_169;
            int val_174 = ~val_169;
            int val_175 = val_144 >> 18;
            int val_176 = val_151 | (~((((((((((((((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) >> 22) + 1352829926) + (((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829) << (32-22)) | (((((((((((((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) >> 22) + 1352829926) + (((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829) << 22)));
            int val_1106 = this.X[3];
            int val_179 = val_128 >> 22;
            val_179 = val_179 >> 17;
            int val_180 = val_179;
            int val_181 = val_180;
            int val_183 = val_175;
            int val_186 = ~val_180;
            int val_1107 = this.X[12];
            int val_189 = val_138 >> 22;
            val_189 = val_189 >> 25;
            int val_190 = val_189;
            int val_191 = val_190;
            int val_1109 = val_148 >> 22;
            int val_195 = ~val_190;
            int val_200 = val_103 >> 22;
            int val_1108 = this.X[0];
            val_1109 = val_1109 >> 20;
            int val_202 = val_1109;
            int val_203 = (val_90 >> 22) >> 18;
            int val_204 = val_175;
            int val_1110 = this.X[9];
            int val_205 = val_203;
            val_200 = val_200 + 1352829926;
            int val_207 = val_202;
            int val_1111 = this.X[5];
            ~val_202 = ~val_202;
            int val_1113 = this.X[2];
            int val_214 = val_200 >> 20;
            int val_216 = val_203;
            int val_218 = val_214;
            int val_1114 = this.X[14];
            int val_221 = (val_158 >> 22) >> 17;
            int val_222 = val_123 >> 22;
            int val_224 = val_221;
            int val_1115 = this.X[11];
            int val_228 = ~val_221;
            val_222 = val_222 >> 26;
            int val_1116 = this.X[8];
            int val_233 = val_214;
            int val_234 = val_175 >> 22;
            int val_235 = val_222;
            int val_1117 = this.X[6];
            val_1117 = (val_151 >> 22) + val_1117;
            val_1117 = val_1117 + 1548603684;
            val_1117 = val_1117 >> 23;
            int val_240 = val_1117;
            int val_242 = val_222;
            int val_243 = (val_169 >> 22) >> 23;
            int val_244 = val_240 & (((((((((((((((((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) +) << (32-22)) | ((((((((((((((((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1352829926) + ((((((this.H3 + 1352829926) + ((((((this.H4 + 1352829926) + ((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) +) << 22));
            int val_1118 = this.X[11];
            int val_247 = val_234;
            val_247 = val_247 >> 19;
            val_234 = val_247;
            int val_249 = val_240 & (~((((((((((((((((((((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) >> 22) + 1352829926) + (((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1) << (32-22)) | (((((((((((((((((((((((((this.H0 + ((this.H2 | (~this.H3)) ^ this.H1)) + this.X[5]) + 1352829926) >> 24) + this.H4) >> 22) + 1352829926) + (((((((this.H1 >> 22) + 1352829926) + (((((((this.H2 >> 22) + 1) << 22)));
            int val_250 = val_243;
            int val_252 = val_234;
            int val_254 = ~val_243;
            int val_1119 = this.X[3];
            int val_258 = val_203 >> 22;
            val_258 = val_258 >> 17;
            int val_259 = val_258;
            int val_261 = val_234;
            int val_263 = val_259;
            int val_265 = val_180 >> 22;
            int val_1120 = this.X[7];
            int val_268 = val_214 >> 22;
            val_268 = val_268 >> 25;
            int val_269 = val_268;
            int val_271 = val_259;
            int val_1121 = val_190;
            val_265 = val_265 >> 21;
            int val_272 = val_240 >> 22;
            val_1121 = val_1121 >> 22;
            int val_273 = val_269;
            int val_274 = val_265;
            int val_1122 = this.X[0];
            int val_277 = val_222 >> 22;
            val_277 = val_277 >> 20;
            int val_278 = val_277;
            int val_280 = val_269;
            int val_282 = val_278;
            int val_283 = val_274;
            int val_1123 = this.X[13];
            val_1123 = (val_272 + 1548603684) + val_1123;
            val_1123 = val_1123 >> 24;
            int val_287 = val_1123;
            val_272 = val_287;
            int val_288 = val_278;
            int val_289 = ~val_274;
            int val_291 = val_272;
            int val_292 = val_259 >> 22;
            int val_1124 = this.X[5];
            int val_295 = val_234 >> 22;
            val_295 = val_295 >> 23;
            int val_296 = val_295;
            int val_299 = val_287;
            int val_301 = val_1121;
            int val_302 = val_296;
            int val_1125 = this.X[10];
            val_301 = val_301 >> 25;
            int val_306 = val_292;
            val_306 = val_306 >> 21;
            int val_307 = val_306;
            val_292 = val_307;
            int val_308 = val_296;
            int val_309 = val_301;
            int val_310 = val_292;
            int val_1126 = this.X[14];
            int val_313 = val_269 >> 22;
            int val_314 = val_309;
            int val_1127 = this.X[15];
            val_313 = val_313 >> 25;
            ~val_309 = ~val_309;
            int val_318 = val_313;
            int val_1129 = this.X[8];
            int val_321 = val_307;
            int val_323 = val_318;
            int val_1130 = this.X[12];
            int val_328 = (val_202 >> 22) >> 19;
            int val_329 = val_278 >> 22;
            val_329 = val_329 >> 25;
            int val_1131 = this.X[4];
            int val_331 = val_328;
            int val_333 = val_329;
            int val_334 = ~val_328;
            int val_1132 = this.X[9];
            int val_337 = val_318;
            int val_339 = val_333;
            int val_341 = val_221 >> 22;
            int val_1133 = this.X[1];
            val_341 = val_341 >> 20;
            val_287 >> 22 = val_287 >> 22;
            int val_1134 = this.X[2];
            int val_349 = (val_287 >> 22) >> 20;
            int val_350 = val_341;
            int val_1135 = this.X[3];
            int val_353 = val_333;
            int val_356 = val_243 >> 22;
            val_356 = val_356 >> 21;
            int val_357 = val_356;
            int val_359 = val_349;
            int val_361 = val_357;
            int val_1136 = this.X[10];
            int val_364 = val_274 >> 22;
            val_364 = val_364 >> 19;
            int val_365 = val_364;
            int val_368 = val_328 >> 22;
            int val_369 = val_365;
            int val_370 = val_296 >> 22;
            int val_1137 = this.X[14];
            val_370 = val_370 >> 25;
            int val_374 = val_309 >> 22;
            val_374 = val_374 >> 26;
            int val_375 = val_374;
            int val_377 = val_370;
            val_341 = val_341 >> 22;
            int val_378 = val_375;
            int val_380 = val_349;
            int val_1138 = this.X[4];
            int val_383 = val_368;
            val_383 = val_383 >> 25;
            int val_384 = val_383;
            val_368 = val_384;
            int val_385 = val_377;
            int val_387 = val_368;
            int val_1139 = this.X[9];
            int val_391 = val_341;
            val_391 = val_391 >> 18;
            int val_393 = val_391;
            int val_395 = val_393;
            int val_396 = val_307 >> 22;
            int val_1140 = this.X[15];
            val_396 = val_396 >> 26;
            int val_401 = val_357 >> 22;
            val_401 = val_401 >> 23;
            int val_402 = val_401;
            int val_404 = val_396;
            val_375 = val_375 >> 22;
            int val_405 = val_402;
            val_396 = val_404;
            int val_406 = val_377;
            int val_1141 = this.X[8];
            int val_409 = val_365 >> 22;
            val_409 = val_409 >> 19;
            int val_410 = val_409;
            int val_412 = val_396;
            val_384 = val_384 >> 22;
            int val_414 = val_410;
            int val_1142 = this.X[1];
            int val_417 = val_375;
            int val_1144 = val_333;
            val_417 = val_417 >> 17;
            int val_419 = val_417;
            int val_422 = val_419;
            int val_1143 = this.X[2];
            val_1144 = val_1144 >> 22;
            int val_424 = (val_318 >> 22) >> 17;
            val_384 = val_384;
            int val_425 = val_384;
            int val_426 = val_424;
            int val_1145 = this.X[7];
            val_393 = val_393 >> 22;
            val_425 = val_425 >> 18;
            val_424 = val_426;
            int val_427 = val_404;
            int val_428 = val_425;
            int val_429 = val_424;
            int val_1146 = this.X[0];
            int val_431 = val_1144;
            int val_433 = val_428;
            int val_1147 = this.X[6];
            val_431 = val_431 >> 19;
            int val_438 = val_393;
            int val_439 = val_431;
            val_438 = val_438 >> 24;
            int val_1148 = this.X[13];
            int val_442 = val_426;
            int val_443 = val_438;
            int val_444 = val_439;
            int val_1149 = this.X[11];
            int val_448 = val_443;
            int val_450 = val_349 >> 22;
            int val_1150 = this.X[5];
            val_450 = val_450 >> 21;
            int val_453 = val_450;
            int val_1151 = this.X[12];
            int val_459 = (val_402 >> 22) >> 19;
            int val_460 = val_453;
            int val_461 = val_404 >> 22;
            int val_1152 = this.X[15];
            int val_465 = val_377 >> 22;
            val_465 = val_465 >> 23;
            int val_466 = val_465;
            int val_468 = val_459;
            int val_470 = val_466;
            int val_1153 = this.X[5];
            int val_474 = val_461;
            val_474 = val_474 >> 25;
            int val_475 = val_474;
            val_461 = val_475;
            int val_476 = val_439 >> 22;
            int val_477 = val_461;
            int val_478 = val_410 >> 22;
            int val_1154 = this.X[1];
            val_478 = val_478 >> 26;
            int val_482 = val_426 >> 22;
            val_482 = val_482 >> 17;
            int val_483 = val_482;
            val_453 = val_453 >> 22;
            int val_486 = val_483;
            if(this.X.Length <= 3)
            {
                    int val_1155 = val_478;
            }
            
            val_1155 = val_1155;
            int val_1156 = this.X[3];
            int val_489 = val_476;
            val_489 = val_489 >> 21;
            int val_490 = val_489;
            val_476 = val_490;
            int val_491 = val_466 >> 22;
            int val_492 = val_476;
            int val_493 = val_1155;
            int val_1157 = this.X[7];
            int val_497 = val_453;
            val_497 = val_497 >> 24;
            int val_498 = val_497;
            int val_502 = val_498;
            int val_503 = val_419 >> 22;
            int val_1158 = this.X[14];
            val_503 = val_503 >> 27;
            int val_507 = val_491;
            val_507 = val_507 >> 26;
            int val_508 = val_507;
            int val_510 = val_503;
            val_483 = val_483 >> 22;
            val_491 = val_508;
            int val_1159 = this.X[6];
            int val_514 = val_475 >> 22;
            val_514 = val_514 >> 26;
            int val_515 = val_514;
            int val_517 = val_510;
            int val_519 = val_515;
            int val_1160 = this.X[9];
            int val_523 = val_483;
            val_523 = val_523 >> 18;
            int val_524 = val_523;
            int val_527 = val_524;
            int val_1161 = this.X[11];
            val_490 >> 22 = val_490 >> 22;
            int val_533 = (val_428 >> 22) >> 20;
            int val_1162 = this.X[8];
            val_498 = val_498 >> 22;
            int val_536 = (val_490 >> 22) >> 20;
            int val_537 = val_533;
            int val_1163 = this.X[12];
            int val_540 = val_443 >> 22;
            int val_541 = val_536;
            int val_1164 = this.X[2];
            val_540 = val_540 >> 25;
            int val_547 = val_540;
            int val_1165 = this.X[10];
            val_508 = val_508 >> 22;
            int val_550 = val_498 >> 19;
            int val_551 = val_547;
            int val_1166 = this.X[0];
            int val_555 = val_550;
            int val_557 = val_459 >> 22;
            int val_1167 = this.X[4];
            val_557 = val_557 >> 27;
            int val_560 = val_557;
            int val_1168 = this.X[13];
            int val_566 = val_547;
            int val_567 = val_508 >> 27;
            int val_568 = val_560;
            int val_569 = val_510 >> 22;
            int val_1169 = this.X[1];
            int val_573 = val_1155 >> 22;
            val_573 = val_573 >> 21;
            int val_574 = val_573;
            int val_576 = val_560;
            int val_577 = val_567;
            int val_579 = val_574;
            int val_1170 = this.X[9];
            int val_582 = val_569;
            val_582 = val_582 >> 20;
            val_569 = val_582;
            int val_585 = val_574;
            val_515 >> 22 = val_515 >> 22;
            int val_586 = val_569;
            int val_587 = val_547 >> 22;
            int val_1171 = this.X[11];
            int val_591 = val_533 >> 22;
            val_591 = val_591 >> 18;
            int val_592 = val_591;
            val_515 >> 22 = (val_515 >> 22) >> 18;
            int val_594 = val_569;
            int val_595 = val_515 >> 22;
            int val_596 = val_592;
            int val_1172 = this.X[10];
            int val_601 = val_587;
            val_601 = val_601 >> 17;
            val_587 = val_601;
            int val_603 = val_592;
            val_574 = val_574 >> 22;
            int val_604 = val_587;
            int val_605 = val_595;
            int val_1173 = this.X[0];
            int val_609 = val_560 >> 22;
            val_609 = val_609 >> 18;
            int val_610 = val_609;
            int val_613 = val_587;
            int val_615 = val_610;
            int val_616 = val_524 >> 22;
            int val_1174 = this.X[8];
            val_616 = val_616 >> 19;
            int val_620 = val_574;
            val_620 = val_620 >> 17;
            int val_621 = val_620;
            int val_623 = val_610;
            int val_624 = val_616;
            val_592 = val_592 >> 22;
            int val_625 = val_621;
            int val_1175 = this.X[12];
            int val_629 = val_569 >> 22;
            val_629 = val_629 >> 23;
            int val_630 = val_629;
            int val_632 = val_621;
            int val_633 = val_630;
            int val_634 = val_624;
            int val_1176 = this.X[4];
            int val_639 = val_592;
            val_639 = val_639 >> 24;
            int val_641 = val_639;
            int val_643 = val_630;
            int val_645 = val_641;
            int val_1177 = this.X[13];
            val_587 >> 22 = val_587 >> 22;
            int val_649 = (val_536 >> 22) >> 19;
            int val_1178 = this.X[3];
            val_587 >> 22 = (val_587 >> 22) >> 23;
            int val_653 = val_649;
            int val_1179 = this.X[7];
            int val_655 = val_587 >> 22;
            int val_656 = val_550 >> 22;
            int val_658 = val_641;
            int val_1180 = this.X[15];
            int val_660 = val_655;
            val_656 = val_656 >> 25;
            int val_664 = val_656;
            int val_1181 = this.X[14];
            int val_665 = val_610 >> 22;
            val_665 = val_665 >> 18;
            int val_668 = val_664;
            int val_1182 = this.X[5];
            int val_671 = val_665;
            int val_673 = val_655;
            int val_1183 = this.X[6];
            int val_675 = val_671;
            int val_676 = val_595 >> 22;
            int val_680 = (val_567 >> 22) >> 27;
            int val_681 = val_649 >> 22;
            int val_1184 = this.X[2];
            int val_683 = val_621 >> 22;
            int val_684 = val_680;
            val_683 = val_683 >> 27;
            int val_685 = val_681;
            int val_687 = val_624 >> 22;
            int val_1185 = this.X[8];
            int val_690 = val_676;
            int val_691 = val_683;
            val_690 = val_690 >> 17;
            int val_692 = val_690;
            int val_693 = val_692;
            val_676 = ~val_692;
            int val_694 = val_676;
            int val_696 = val_671;
            int val_697 = val_691;
            int val_1186 = this.X[6];
            int val_701 = val_687;
            val_701 = val_701 >> 27;
            int val_702 = val_701;
            int val_703 = val_702;
            val_687 = ~val_702;
            int val_705 = val_687;
            int val_708 = val_630 >> 22;
            int val_1187 = this.X[4];
            int val_710 = val_681;
            val_710 = val_710 >> 24;
            int val_711 = val_710;
            val_681 = val_711;
            var val_1189 = val_664 >> 22;
            val_708 = val_708 >> 26;
            int val_714 = ~val_711;
            int val_1188 = this.X[1];
            int val_718 = val_1189;
            int val_719 = val_708;
            val_718 = val_718 >> 21;
            int val_720 = val_718;
            int val_721 = val_720;
            val_1189 = ~val_720;
            int val_724 = val_691;
            int val_725 = val_1189;
            int val_726 = val_719;
            int val_1190 = this.X[3];
            int val_730 = val_680 >> 22;
            val_730 = val_730 >> 18;
            int val_731 = val_730;
            int val_732 = val_731;
            int val_736 = ~val_731;
            if(this.X.Length <= 11)
            {
                    var val_1237 = val_692 >> 22;
            }
            
            int val_738 = val_641 >> 22;
            int val_1191 = this.X[11];
            int val_740 = val_1237;
            val_740 = val_740 >> 18;
            int val_741 = val_740;
            int val_742 = val_741;
            val_738 = val_738 >> 24;
            val_711 = val_711 >> 22;
            int val_745 = ~val_741;
            int val_1192 = this.X[15];
            int val_748 = val_702 >> 22;
            int val_749 = val_738;
            val_748 = val_748 >> 26;
            int val_750 = val_748;
            int val_751 = val_750;
            int val_754 = val_719;
            int val_756 = ~val_750;
            int val_1193 = this.X[0];
            int val_760 = val_711;
            val_760 = val_760 >> 18;
            int val_761 = val_760;
            int val_762 = val_749;
            int val_763 = val_761;
            int val_767 = ~val_761;
            int val_1194 = this.X[5];
            int val_771 = val_720 >> 22;
            val_771 = val_771 >> 26;
            int val_772 = val_771;
            int val_773 = val_772;
            int val_776 = ~val_772;
            int val_777 = val_671 >> 22;
            int val_1195 = this.X[12];
            int val_780 = (val_655 >> 22) >> 26;
            val_731 = (val_731 >> 22) >> 23;
            int val_784 = val_749;
            int val_1196 = this.X[2];
            int val_785 = val_731;
            int val_786 = val_780;
            int val_787 = val_777;
            val_777 = val_787;
            int val_1197 = this.X[13];
            int val_788 = val_785;
            val_787 = val_777;
            int val_790 = ~val_785;
            val_787 = val_787 >> 27;
            int val_1198 = this.X[9];
            int val_794 = val_787;
            int val_797 = val_780;
            int val_798 = val_794;
            int val_1199 = this.X[7];
            int val_802 = (val_741 >> 22) >> 20;
            int val_1200 = this.X[10];
            int val_1201 = val_719;
            int val_804 = val_691 >> 22;
            int val_805 = val_802;
            val_1201 = val_1201 >> 22;
            val_804 = val_804 >> 20;
            int val_1202 = this.X[14];
            int val_808 = ~val_802;
            int val_809 = val_804;
            int val_811 = val_794;
            int val_813 = val_809;
            int val_1203 = this.X[4];
            int val_817 = val_809;
            int val_819 = val_1201;
            val_819 = val_819 >> 23;
            int val_820 = val_819;
            int val_822 = val_820;
            int val_1204 = this.X[0];
            int val_826 = val_749 >> 22;
            val_826 = val_826 >> 17;
            int val_827 = (val_750 >> 22) >> 23;
            int val_828 = val_826;
            int val_829 = val_820;
            int val_830 = val_828;
            val_794 = val_794 >> 22;
            int val_831 = val_827;
            int val_1205 = this.X[5];
            int val_834 = val_780 >> 22;
            val_834 = val_834 >> 27;
            int val_836 = val_834;
            int val_837 = val_828;
            int val_839 = ~val_827;
            int val_840 = val_836;
            int val_1206 = this.X[9];
            int val_844 = val_794;
            val_844 = val_844 >> 21;
            val_794 = val_844;
            int val_846 = val_836;
            int val_847 = val_820 >> 22;
            int val_848 = val_794;
            int val_849 = val_761 >> 22;
            int val_1207 = this.X[7];
            val_849 = val_849 >> 20;
            int val_853 = val_809 >> 22;
            val_853 = val_853 >> 26;
            int val_854 = val_853;
            int val_855 = val_794;
            int val_856 = val_849;
            int val_857 = val_854;
            int val_1208 = this.X[12];
            val_847 = val_847 >> 24;
            int val_862 = val_847;
            int val_863 = val_854;
            int val_864 = val_856;
            int val_866 = val_862;
            int val_1209 = this.X[2];
            int val_868 = ~val_856;
            int val_1210 = this.X[10];
            int val_872 = val_828 >> 22;
            int val_1211 = val_785;
            val_872 = val_872 >> 19;
            val_1211 = val_1211 >> 22;
            int val_1212 = this.X[14];
            int val_876 = val_872;
            int val_877 = (val_772 >> 22) >> 27;
            int val_878 = val_862;
            int val_879 = val_876;
            int val_1213 = this.X[1];
            int val_882 = val_877;
            int val_885 = ~val_877;
            int val_1214 = this.X[3];
            val_794 = val_794 >> 22;
            int val_889 = (val_836 >> 22) >> 20;
            int val_890 = val_876;
            int val_1215 = this.X[8];
            int val_892 = val_889;
            int val_897 = val_1211 >> 17;
            int val_1216 = this.X[11];
            int val_901 = val_897;
            int val_1217 = this.X[6];
            int val_904 = ~val_897;
            int val_905 = val_889;
            if(this.X == null)
            {
                    int val_1218 = val_794 >> 27;
            }
            
            val_1218 = val_1218;
            int val_1219 = this.X[15];
            int val_911 = val_877 >> 22;
            int val_914 = val_827 >> 22;
            val_1061 = (val_802 >> 22) >> 24;
            int val_1220 = this.X[13];
            if(this.X == null)
            {
                    val_1061 = val_1061;
            }
            
            int val_918 = (val_854 >> 22) >> 20;
            int val_919 = val_897;
            int val_920 = val_1218;
            int val_921 = val_856 >> 22;
            if(this.X.Length <= 12)
            {
                    val_1061 = val_1061;
            }
            
            int val_1221 = this.X[12];
            int val_924 = val_919;
            val_924 = val_924 >> 24;
            int val_925 = val_918;
            val_919 = val_924;
            if(this.X == null)
            {
                    val_1061 = val_1061;
            }
            
            if(this.X.Length <= 15)
            {
                    val_1061 = val_1061;
            }
            
            int val_1222 = this.X[15];
            int val_930 = val_862 >> 22;
            int val_932 = val_1061;
            val_932 = val_932 >> 27;
            int val_933 = val_932;
            if(this.X == null)
            {
                    val_1061 = val_1061;
            }
            
            val_930 = val_930 >> 19;
            val_897 = val_897 >> 22;
            if(this.X.Length <= 10)
            {
                    val_1061 = val_1061;
            }
            
            int val_1223 = this.X[10];
            int val_936 = val_930;
            int val_937 = val_918;
            int val_939 = val_919;
            val_939 = val_939 >> 20;
            int val_940 = val_939;
            if(this.X == null)
            {
                    val_1061 = val_1061;
            }
            
            int val_942 = val_936;
            int val_944 = val_1061 >> 22;
            int val_945 = val_933;
            int val_1224 = this.X[4];
            int val_948 = val_945;
            val_948 = val_948 >> 23;
            val_945 = val_948;
            int val_950 = val_876 >> 22;
            int val_951 = val_919 >> 22;
            val_919 = val_940;
            val_950 = val_950 >> 18;
            int val_1225 = this.X[1];
            int val_955 = val_919;
            val_955 = val_955 >> 20;
            val_1062 = val_955;
            if(this.X == null)
            {
                    val_1062 = val_1062;
            }
            
            int val_956 = val_950;
            int val_957 = val_945;
            int val_958 = val_936;
            int val_959 = val_933 >> 22;
            if(this.X.Length <= 5)
            {
                    val_1062 = val_1062;
            }
            
            int val_1226 = this.X[5];
            int val_962 = val_957;
            val_962 = val_962 >> 27;
            int val_963 = val_956;
            val_957 = val_962;
            if(this.X == null)
            {
                    val_1062 = val_1062;
            }
            
            int val_965 = val_889 >> 22;
            int val_966 = val_940 >> 22;
            if(this.X.Length <= 8)
            {
                    val_1062 = val_1062;
            }
            
            int val_1227 = this.X[8];
            int val_970 = val_1062;
            val_970 = val_970 >> 18;
            val_1063 = val_970;
            if(this.X == null)
            {
                    val_1063 = val_1063;
                val_1062 = val_1062;
            }
            
            val_965 = val_965 >> 21;
            int val_972 = val_945 >> 22;
            if(this.X.Length <= 7)
            {
                    val_1063 = val_1063;
                val_1062 = val_1062;
            }
            
            int val_1228 = this.X[7];
            int val_975 = val_965;
            int val_976 = val_956;
            int val_978 = val_957;
            val_978 = val_978 >> 26;
            int val_979 = val_978;
            if(this.X == null)
            {
                    val_1063 = val_1063;
                val_1062 = val_1062;
            }
            
            int val_981 = val_975;
            int val_983 = val_1062 >> 22;
            int val_984 = val_1063;
            if(this.X.Length <= 6)
            {
                    val_1063 = val_1063;
            }
            
            int val_1229 = this.X[6];
            int val_986 = val_984;
            val_986 = val_986 >> 24;
            val_984 = val_986;
            if(this.X == null)
            {
                    val_1063 = val_1063;
            }
            
            int val_990 = val_1218 >> 22;
            int val_991 = val_957 >> 22;
            if(this.X.Length <= 2)
            {
                    val_1063 = val_1063;
            }
            
            int val_1230 = this.X[2];
            int val_996 = val_979;
            val_996 = val_996 >> 19;
            val_1064 = val_996;
            if(this.X == null)
            {
                    val_1064 = val_1064;
                val_1063 = val_1063;
            }
            
            val_990 = val_990 >> 24;
            int val_997 = val_1063 >> 22;
            int val_998 = val_975;
            if(this.X.Length <= 13)
            {
                    val_1064 = val_1064;
            }
            
            int val_1231 = this.X[13];
            int val_1000 = val_990;
            int val_1003 = val_984;
            val_1003 = val_1003 >> 26;
            int val_1004 = val_1003;
            if(this.X == null)
            {
                    val_1064 = val_1064;
            }
            
            int val_1007 = val_979 >> 22;
            if(this.X.Length <= 14)
            {
                    val_1064 = val_1064;
            }
            
            int val_1232 = this.X[14];
            int val_1011 = val_1064;
            val_1011 = val_1011 >> 27;
            int val_1012 = val_1011;
            int val_1015 = val_984 >> 22;
            int val_1233 = this.X[0];
            val_1065 = (val_918 >> 22) >> 27;
            int val_1018 = val_990;
            int val_1020 = val_1004;
            val_1020 = val_1020 >> 17;
            int val_1021 = val_1020;
            if(this.X == null)
            {
                    val_1065 = val_1065;
            }
            
            int val_1023 = val_1065;
            int val_1025 = val_1012;
            int val_1026 = val_1064 >> 22;
            if(this.X.Length <= 3)
            {
                    val_1065 = val_1065;
            }
            
            int val_1234 = this.X[3];
            int val_1029 = val_1025;
            val_1029 = val_1029 >> 19;
            val_1025 = val_1029;
            if(this.X == null)
            {
                    val_1065 = val_1065;
            }
            
            val_1004 = val_1004 >> 22;
            if(this.X.Length <= 9)
            {
                    val_1065 = val_1065;
            }
            
            int val_1034 = val_956 >> 22;
            int val_1235 = this.X[9];
            int val_1037 = val_1021;
            val_1037 = val_1037 >> 21;
            int val_1038 = val_1037;
            if(this.X == null)
            {
                    val_1065 = val_1065;
            }
            
            val_1066 = val_975 >> 22;
            val_1067 = (val_936 >> 22) >> 26;
            val_1012 = val_1012 >> 22;
            int val_1039 = val_990 >> 22;
            val_1021 = val_1021 >> 22;
            if(this.X.Length <= 11)
            {
                    val_1067 = val_1067;
                val_1065 = val_1065;
                val_1066 = val_1066;
            }
            
            int val_1236 = this.X[11];
            int val_1044 = val_1025;
            val_1237 = val_1012;
            val_1044 = val_1044 >> 21;
            val_1068 = 0;
            this.H1 = val_1021;
            this.H2 = val_1012;
            this.H0 = val_1025 >> 22;
            this.H3 = val_1237;
            this.H4 = val_1067;
            this.xOff = 0;
            goto label_320;
            label_324:
            val_1068 = 1;
            this.X[0] = 0;
            label_320:
            if(val_1068 != this.X.Length)
            {
                goto label_324;
            }
        
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.RipeMD160Digest(t:  this);
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
