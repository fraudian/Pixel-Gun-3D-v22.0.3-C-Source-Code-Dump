using UnityEngine;

namespace Org.BouncyCastle.Math
{
    [Serializable]
    public class BigInteger
    {
        // Fields
        internal static readonly int[][] primeLists;
        internal static readonly int[] primeProducts;
        private const long IMASK = 4294967295;
        private const ulong UIMASK = 4294967295;
        private static readonly int[] ZeroMagnitude;
        private static readonly byte[] ZeroEncoding;
        private static readonly Org.BouncyCastle.Math.BigInteger[] SMALL_CONSTANTS;
        public static readonly Org.BouncyCastle.Math.BigInteger Zero;
        public static readonly Org.BouncyCastle.Math.BigInteger One;
        public static readonly Org.BouncyCastle.Math.BigInteger Two;
        public static readonly Org.BouncyCastle.Math.BigInteger Three;
        public static readonly Org.BouncyCastle.Math.BigInteger Ten;
        private static readonly byte[] BitLengthTable;
        private const int chunk2 = 1;
        private const int chunk8 = 1;
        private const int chunk10 = 19;
        private const int chunk16 = 16;
        private static readonly Org.BouncyCastle.Math.BigInteger radix2;
        private static readonly Org.BouncyCastle.Math.BigInteger radix2E;
        private static readonly Org.BouncyCastle.Math.BigInteger radix8;
        private static readonly Org.BouncyCastle.Math.BigInteger radix8E;
        private static readonly Org.BouncyCastle.Math.BigInteger radix10;
        private static readonly Org.BouncyCastle.Math.BigInteger radix10E;
        private static readonly Org.BouncyCastle.Math.BigInteger radix16;
        private static readonly Org.BouncyCastle.Math.BigInteger radix16E;
        private static readonly Org.BouncyCastle.Security.SecureRandom RandomSource;
        private static readonly int[] ExpWindowThresholds;
        private const int BitsPerByte = 8;
        private const int BitsPerInt = 32;
        private const int BytesPerInt = 4;
        private int[] magnitude;
        private int sign;
        private int nBits;
        private int nBitLength;
        private int mQuote;
        
        // Properties
        public int BitCount { get; }
        public int BitLength { get; }
        public int IntValue { get; }
        public long LongValue { get; }
        public int SignValue { get; }
        
        // Methods
        private static BigInteger()
        {
            var val_84;
            var val_85;
            ulong val_86;
            Org.BouncyCastle.Math.BigInteger[] val_87;
            var val_88;
            var val_89;
            var val_90;
            System.Int32[][] val_1 = new System.Int32[][64];
            val_84 = 1152921505725111792;
            int[] val_2 = new int[8] {3, 5, 7, 11, 13, 17, 19, 23};
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = new int[5] {29, 31, 37, 41, 43};
            val_1[2] = new int[5] {47, 53, 59, 61, 67};
            val_1[3] = new int[4] {71, 73, 79, 83};
            val_1[4] = new int[4] {89, 97, 101, 103};
            val_1[5] = new int[4] {107, 109, 113, 127};
            val_1[6] = new int[4] {131, 137, 139, 149};
            val_1[7] = new int[4] {151, 157, 163, 167};
            val_1[8] = new int[4] {173, 179, 181, 191};
            val_1[9] = new int[4] {193, 197, 199, 211};
            val_1[10] = new int[3] {223, 227, 229};
            val_1[11] = new int[3] {233, 239, 241};
            val_1[12] = new int[3] {251, 257, 263};
            val_1[13] = new int[3] {269, 271, 277};
            val_1[14] = new int[3] {281, 283, 293};
            val_1[15] = new int[3] {307, 311, 313};
            val_1[16] = new int[3] {317, 331, 337};
            val_1[17] = new int[3] {347, 349, 353};
            val_1[18] = new int[3] {359, 367, 373};
            val_1[19] = new int[3] {379, 383, 389};
            val_1[20] = new int[3] {397, 401, 409};
            val_1[21] = new int[3] {419, 421, 431};
            val_1[22] = new int[3] {433, 439, 443};
            val_1[23] = new int[3] {449, 457, 461};
            val_1[24] = new int[3] {463, 467, 479};
            val_1[25] = new int[3] {487, 491, 499};
            val_1[26] = new int[3] {503, 509, 521};
            val_1[27] = new int[3] {523, 541, 547};
            val_1[28] = new int[3] {557, 563, 569};
            val_1[29] = new int[3] {571, 577, 587};
            val_1[30] = new int[3] {593, 599, 601};
            val_1[31] = new int[3] {607, 613, 617};
            val_1[32] = new int[3] {619, 631, 641};
            val_1[33] = new int[3] {643, 647, 653};
            val_1[34] = new int[3] {659, 661, 673};
            val_1[35] = new int[3] {677, 683, 691};
            val_1[36] = new int[3] {701, 709, 719};
            val_1[37] = new int[3] {727, 733, 739};
            val_1[38] = new int[3] {743, 751, 757};
            val_1[39] = new int[3] {761, 769, 773};
            val_1[40] = new int[3] {787, 797, 809};
            val_1[41] = new int[3] {811, 821, 823};
            val_1[42] = new int[3] {827, 829, 839};
            val_1[43] = new int[3] {853, 857, 859};
            val_1[44] = new int[3] {863, 877, 881};
            val_1[45] = new int[3] {883, 887, 907};
            val_1[46] = new int[3] {911, 919, 929};
            val_1[47] = new int[3] {937, 941, 947};
            val_1[48] = new int[3] {953, 967, 971};
            val_1[49] = new int[3] {977, 983, 991};
            val_1[50] = new int[3] {997, 1009, 1013};
            val_1[51] = new int[3] {1019, 1021, 1031};
            val_1[52] = new int[3] {1033, 1039, 1049};
            val_1[53] = new int[3] {1051, 1061, 1063};
            val_1[54] = new int[3] {1069, 1087, 1091};
            val_1[55] = new int[3] {1093, 1097, 1103};
            val_1[56] = new int[3] {1109, 1117, 1123};
            val_1[57] = new int[3] {1129, 1151, 1153};
            val_1[58] = new int[3] {1163, 1171, 1181};
            val_1[59] = new int[3] {1187, 1193, 1201};
            val_1[60] = new int[3] {1213, 1217, 1223};
            val_1[61] = new int[3] {1229, 1231, 1237};
            val_1[62] = new int[3] {1249, 1259, 1277};
            val_1[63] = new int[3] {1279, 1283, 1289};
            Org.BouncyCastle.Math.BigInteger.BytesPerInt = val_1;
            int[] val_66 = new int[0];
            Org.BouncyCastle.Math.BigInteger.ZeroMagnitude = val_66;
            Org.BouncyCastle.Math.BigInteger.ZeroEncoding = new byte[0];
            Org.BouncyCastle.Math.BigInteger[] val_68 = new Org.BouncyCastle.Math.BigInteger[17];
            Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS = val_68;
            Org.BouncyCastle.Math.BigInteger.BitLengthTable = new byte[256] {0, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8};
            Org.BouncyCastle.Math.BigInteger.RandomSource = new Org.BouncyCastle.Security.SecureRandom();
            Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds = new int[8] {7, 25, 81, 241, 673, 1793, 4609, 2147483647};
            val_85 = null;
            Org.BouncyCastle.Math.BigInteger.Zero = new Org.BouncyCastle.Math.BigInteger(signum:  0, mag:  val_66, checkMag:  false);
            if(Org.BouncyCastle.Math.BigInteger.Zero == null)
            {
                    val_85 = null;
            }
            
            mem[1152921543937633084] = 0;
            if(Org.BouncyCastle.Math.BigInteger.Zero == null)
            {
                    val_85 = null;
            }
            
            mem[1152921543937633088] = 0;
            if(Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS == null)
            {
                goto label_198;
            }
            
            if(Org.BouncyCastle.Math.BigInteger.Zero != null)
            {
                goto label_199;
            }
            
            goto label_202;
            label_198:
            if(Org.BouncyCastle.Math.BigInteger.Zero == null)
            {
                goto label_202;
            }
            
            label_199:
            Org.BouncyCastle.Math.BigInteger val_87 = val_68[4];
            label_202:
            mem[1152921543937614448] = Org.BouncyCastle.Math.BigInteger.Zero;
            val_86 = 1;
            goto label_204;
            label_212:
            Org.BouncyCastle.Math.BigInteger val_73 = Org.BouncyCastle.Math.BigInteger.CreateUValueOf(value:  val_86);
            if(X23 == 0)
            {
                goto label_205;
            }
            
            if(val_73 != null)
            {
                goto label_206;
            }
            
            goto label_209;
            label_205:
            if(val_73 == null)
            {
                goto label_209;
            }
            
            label_206:
            label_209:
            var val_74 = X23 + 8;
            val_86 = 2;
            mem2[0] = val_73;
            label_204:
            val_87 = Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS;
            if(Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS == null)
            {
                    val_87 = Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS;
            }
            
            if(mem[1152921543937614440] > val_86)
            {
                goto label_212;
            }
            
            Org.BouncyCastle.Math.BigInteger.One = mem[1152921543937614456];
            Org.BouncyCastle.Math.BigInteger.Two = mem[1152921543937614464];
            Org.BouncyCastle.Math.BigInteger.Three = mem[1152921543937614472];
            Org.BouncyCastle.Math.BigInteger.Ten = mem[1152921543937614528];
            Org.BouncyCastle.Math.BigInteger.radix2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  2);
            Org.BouncyCastle.Math.BigInteger.radix2E = Org.BouncyCastle.Math.BigInteger.radix2.Pow(exp:  1);
            Org.BouncyCastle.Math.BigInteger.radix8 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  8);
            Org.BouncyCastle.Math.BigInteger.radix8E = Org.BouncyCastle.Math.BigInteger.radix8.Pow(exp:  1);
            Org.BouncyCastle.Math.BigInteger.radix10 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  10);
            Org.BouncyCastle.Math.BigInteger.radix10E = Org.BouncyCastle.Math.BigInteger.radix10.Pow(exp:  19);
            Org.BouncyCastle.Math.BigInteger.radix16 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  16);
            Org.BouncyCastle.Math.BigInteger.radix16E = Org.BouncyCastle.Math.BigInteger.radix16.Pow(exp:  16);
            val_88 = null;
            val_89 = 0;
            Org.BouncyCastle.Math.BigInteger.primeProducts = new int[0];
            goto label_226;
            label_237:
            System.Int32[][] val_84 = Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0;
            val_90 = mem[(val_1 + 0) + 32 + 24];
            val_90 = (val_1 + 0) + 32 + 24;
            if(val_90 == 0)
            {
                    val_90 = mem[(val_1 + 0) + 32 + 24];
                val_90 = (val_1 + 0) + 32 + 24;
            }
            
            val_84 = mem[(val_1 + 0) + 32 + 32];
            val_84 = (val_1 + 0) + 32 + 32;
            if(val_90 >= 2)
            {
                    do
            {
                if(1 >= val_90)
            {
                    val_90 = mem[(val_1 + 0) + 32 + 24];
                val_90 = (val_1 + 0) + 32 + 24;
            }
            
                var val_85 = ((val_1 + 0) + 32) + 4;
                val_84 = (((val_1 + 0) + 32 + 4) + 32) * val_84;
            }
            while((1 + 1) < val_90);
            
            }
            
            val_87 = Org.BouncyCastle.Math.BigInteger.primeProducts;
            mem2[0] = val_84;
            val_88 = null;
            val_89 = 1;
            label_226:
            if(val_89 < val_1.Length)
            {
                goto label_237;
            }
        
        }
        private static int GetByteLength(int nBits)
        {
            int val_1 = nBits + 7;
            nBits = ((val_1 < 0) ? (nBits + 14) : (val_1)) >> 3;
            return (int)nBits;
        }
        internal static Org.BouncyCastle.Math.BigInteger Arbitrary(int sizeInBits)
        {
            null = null;
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(sizeInBits:  sizeInBits, random:  Org.BouncyCastle.Math.BigInteger.RandomSource);
        }
        private BigInteger(int signum, int[] mag, bool checkMag)
        {
            var val_3;
            int val_4;
            var val_5;
            this.nBits = 0;
            this.nBitLength = 0;
            if(checkMag == false)
            {
                goto label_1;
            }
            
            val_3 = 0;
            goto label_2;
            label_6:
            if(mag[0] != 0)
            {
                goto label_4;
            }
            
            val_3 = 1;
            label_2:
            val_4 = mag.Length;
            if(val_3 < val_4)
            {
                goto label_6;
            }
            
            goto label_7;
            label_1:
            this.sign = signum;
            label_12:
            this.magnitude = mag;
            return;
            label_4:
            val_4 = mag.Length;
            label_7:
            if(val_4 == val_3)
            {
                    this.sign = 0;
                val_5 = null;
                val_5 = null;
                this.magnitude = Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
                return;
            }
            
            this.sign = signum;
            if(val_3 == 0)
            {
                goto label_12;
            }
            
            int val_1 = mag.Length - val_3;
            int[] val_2 = new int[0];
            this.magnitude = val_2;
            System.Array.Copy(sourceArray:  mag, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  val_2.Length);
        }
        public BigInteger(string value)
        {
        
        }
        public BigInteger(string str, int radix)
        {
            Org.BouncyCastle.Math.BigInteger val_31;
            Org.BouncyCastle.Math.BigInteger val_32;
            var val_33;
            System.Globalization.NumberStyles val_34;
            var val_35;
            Org.BouncyCastle.Math.BigInteger val_36;
            Org.BouncyCastle.Math.BigInteger val_37;
            var val_38;
            var val_39;
            var val_40;
            int val_41;
            var val_42;
            ulong val_43;
            Org.BouncyCastle.Math.BigInteger val_44;
            var val_45;
            var val_48;
            System.Int32[] val_49;
            var val_50;
            var val_51;
            string val_52;
            var val_53;
            var val_54;
            string val_56;
            val_31 = str;
            val_32 = this;
            this.nBits = 0;
            this.nBitLength = 0;
            if(val_31.Length == 0)
            {
                goto label_22;
            }
            
            if(radix <= 8)
            {
                goto label_3;
            }
            
            if(radix == 10)
            {
                goto label_4;
            }
            
            if(radix != 16)
            {
                goto label_10;
            }
            
            val_33 = null;
            val_33 = null;
            val_34 = 512;
            val_35 = 16;
            val_36 = 1152921505512919176;
            val_37 = 1152921505512919184;
            goto label_16;
            label_3:
            if(radix == 2)
            {
                goto label_9;
            }
            
            if(radix != 8)
            {
                goto label_10;
            }
            
            val_38 = null;
            val_38 = null;
            val_34 = 7;
            val_35 = 1;
            val_36 = 1152921505512919144;
            val_37 = 1152921505512919152;
            goto label_16;
            label_4:
            val_39 = null;
            val_39 = null;
            val_34 = 7;
            val_35 = 19;
            val_36 = 1152921505512919160;
            val_37 = 1152921505512919168;
            goto label_16;
            label_9:
            val_40 = null;
            val_40 = null;
            val_34 = 7;
            val_35 = 1;
            val_36 = 1152921505512919128;
            val_37 = 1152921505512919136;
            label_16:
            this.sign = 1;
            val_41 = 0;
            if((val_31.Chars[0] & 65535) != ('-'))
            {
                goto label_23;
            }
            
            if(val_31.Length == 1)
            {
                goto label_22;
            }
            
            this.sign = 0;
            val_41 = 1;
            goto label_23;
            label_27:
            if((System.Int32.Parse(s:  val_31.Chars[1], style:  val_34)) != 0)
            {
                goto label_25;
            }
            
            val_41 = 2;
            label_23:
            if(val_41 < val_31.Length)
            {
                goto label_27;
            }
            
            label_25:
            if(val_41 >= val_31.Length)
            {
                goto label_29;
            }
            
            val_42 = null;
            val_42 = null;
            val_43 = val_35 + val_41;
            val_44 = Org.BouncyCastle.Math.BigInteger.Zero;
            if(val_43 > val_31.Length)
            {
                goto label_33;
            }
            
            label_51:
            string val_10 = val_31.Substring(startIndex:  2, length:  1);
            ulong val_11 = System.UInt64.Parse(s:  val_10, style:  val_34);
            if(radix == 16)
            {
                goto label_37;
            }
            
            if(radix == 8)
            {
                goto label_38;
            }
            
            if(radix != 2)
            {
                goto label_39;
            }
            
            if(val_11 >= 2)
            {
                goto label_40;
            }
            
            val_45 = 1;
            goto label_44;
            label_37:
            val_45 = 64;
            goto label_44;
            label_38:
            if(val_11 >= 8)
            {
                goto label_45;
            }
            
            val_45 = 3;
            label_44:
            Org.BouncyCastle.Math.BigInteger val_13 = val_44.ShiftLeft(n:  3);
            goto label_47;
            label_39:
            label_47:
            val_43 = val_44.Multiply(val:  val_37);
            val_44 = val_43.Add(value:  Org.BouncyCastle.Math.BigInteger.CreateUValueOf(value:  val_11));
            val_41 = val_41 + val_35;
            if((val_35 + val_41) <= val_31.Length)
            {
                goto label_51;
            }
            
            label_33:
            if(val_41 >= val_31.Length)
            {
                goto label_53;
            }
            
            string val_19 = val_31.Substring(startIndex:  val_41);
            val_43 = System.UInt64.Parse(s:  val_19, style:  val_34);
            val_31 = Org.BouncyCastle.Math.BigInteger.CreateUValueOf(value:  val_43);
            if(val_15.sign < 1)
            {
                goto label_58;
            }
            
            if((radix == 2) || (radix == 8))
            {
                goto label_70;
            }
            
            if(radix != 16)
            {
                goto label_61;
            }
            
            Org.BouncyCastle.Math.BigInteger val_24 = val_44.ShiftLeft(n:  val_19.Length << 2);
            goto label_63;
            label_29:
            this.sign = 0;
            val_43 = 1152921505512914944;
            val_48 = null;
            val_48 = null;
            val_49 = 1152921505512919056;
            goto label_66;
            label_58:
            val_50 = val_31;
            label_53:
            if(val_50 != null)
            {
                goto label_71;
            }
            
            label_72:
            label_71:
            val_32 = val_32;
            val_49 = val_21.magnitude;
            label_66:
            mem[1152921543938375632] = mem[val_21.magnitude];
            return;
            label_61:
            label_63:
            val_51 = val_44.Multiply(val:  val_36.Pow(exp:  val_19.Length));
            label_70:
            if((val_51.Add(value:  val_31)) != null)
            {
                goto label_71;
            }
            
            goto label_72;
            label_40:
            val_52 = "Bad character in radix 2 string: ";
            goto label_73;
            label_45:
            val_52 = "Bad character in radix 8 string: ";
            label_73:
            val_53 = 1152921543938342144;
            val_54 = new System.FormatException(message:  val_52 + val_10);
            goto label_74;
            label_22:
            val_56 = "Zero length BigInteger";
            goto label_75;
            label_10:
            System.FormatException val_31 = null;
            val_56 = "Only bases 2, 8, 10, or 16 allowed";
            label_75:
            val_31 = new System.FormatException(message:  val_56);
            val_53 = 1152921543938342144;
            val_54 = val_31;
            label_74:
        }
        public BigInteger(byte[] bytes)
        {
            if(bytes != null)
            {
                    return;
            }
        
        }
        public BigInteger(byte[] bytes, int offset, int length)
        {
            Org.BouncyCastle.Math.BigInteger val_9;
            int val_10;
            int val_11;
            Org.BouncyCastle.Math.BigInteger val_12;
            System.Byte[] val_13;
            var val_14;
            var val_16;
            byte val_18;
            val_10 = length;
            val_11 = offset;
            val_12 = this;
            this.nBits = 0;
            this.nBitLength = 0;
            if(val_10 == 0)
            {
                goto label_1;
            }
            
            var val_11 = (long)val_11;
            if((bytes[val_11] & 2147483648) == 0)
            {
                    this.magnitude = Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes:  bytes, offset:  val_11, length:  val_10);
                this.sign = (val_1.Length != 0) ? 1 : 0;
                return;
            }
            
            int val_3 = val_10 + val_11;
            this.sign = 0;
            if(val_3 <= val_11)
            {
                goto label_9;
            }
            
            val_13 = (long)val_3;
            val_11 = val_11 + 32;
            label_12:
            if(null != 255)
            {
                goto label_11;
            }
            
            val_10 = val_10 - 1;
            val_11 = val_11 + 1;
            val_11 = val_11 + 1;
            if((val_11 - 31) < val_13)
            {
                goto label_12;
            }
            
            label_9:
            val_14 = null;
            val_14 = null;
            val_9 = Org.BouncyCastle.Math.BigInteger.One;
            this.magnitude = Org.BouncyCastle.Math.BigInteger.One.magnitude;
            return;
            label_11:
            byte[] val_5 = new byte[0];
            val_13 = val_5;
            if(val_10 > 0)
            {
                    do
            {
                byte val_12 = bytes[(long)val_11];
                val_11 = val_11 + 1;
                val_9 = val_12;
                val_9 = ~val_12;
                mem2[0] = val_9;
            }
            while(val_10 != (0 + 1));
            
                val_12 = val_12;
            }
            else
            {
                    val_10 = 0;
            }
            
            val_16 = val_10 - 1;
            goto label_23;
            label_27:
            val_16 = val_16 - 1;
            mem2[0] = 0;
            label_23:
            val_18 = val_13[(long)val_16];
            if(val_18 == 255)
            {
                goto label_27;
            }
            
            if(val_16 >= null)
            {
                    val_18 = mem[val_5[(long)(int)(((val_10 - 1) - 1))] + 32];
                val_18 = val_5[(long)(int)(((val_10 - 1) - 1))] + 32;
            }
            
            mem2[0] = val_18 + 1;
            this.magnitude = Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes:  val_5, offset:  0, length:  val_5.Length);
            return;
            label_1:
            System.FormatException val_9 = new System.FormatException(message:  "Zero length BigInteger");
        }
        private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
        {
            var val_8;
            var val_9;
            System.Int32[] val_10;
            int val_11;
            var val_12;
            var val_13;
            int val_8 = length;
            int val_7 = offset;
            int val_1 = val_8 + val_7;
            if(val_1 <= val_7)
            {
                goto label_7;
            }
            
            val_8 = (long)val_1;
            val_9 = (long)val_7 + 32;
            label_5:
            if(null != null)
            {
                goto label_4;
            }
            
            val_7 = val_7 + 1;
            val_9 = val_9 + 1;
            val_8 = val_8 - 1;
            if((val_9 - 31) < val_8)
            {
                goto label_5;
            }
            
            goto label_7;
            label_4:
            int val_3 = val_8 + 3;
            var val_4 = (val_8 < 0) ? (val_3) : (val_8);
            if(val_3 <= 3)
            {
                goto label_7;
            }
            
            int val_5 = val_3 >> 2;
            val_10 = new int[0];
            if(val_1 <= val_7)
            {
                goto label_8;
            }
            
            val_3 = val_4 & 4294967292;
            val_3 = val_8 - val_3;
            val_9 = 0;
            val_4 = (val_1 == val_7) ? 4 : (val_3);
            val_8 = val_8 - (val_7 << );
            do
            {
                val_4 = val_4 - 1;
                val_11 = 0 | 1152921505721910208;
                if(val_4 <= 0)
            {
                    val_9 = val_9 + 1;
                val_10[0] = val_11;
                val_11 = 0;
            }
            
                val_8 = val_8 - 1;
                val_12 = val_7 + 1;
            }
            while(val_8 != 0);
            
            label_21:
            if(val_9 >= val_6.Length)
            {
                    return val_10;
            }
            
            val_12 = (long)val_9;
            val_10[((long)(int)((val_9 + 1))) << 2] = val_11;
            return val_10;
            label_7:
            val_12 = 1152921505512914944;
            val_13 = null;
            val_13 = null;
            val_10 = Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
            return val_10;
            label_8:
            if(val_10 != null)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        public BigInteger(int sign, byte[] bytes)
        {
            if(bytes != null)
            {
                    return;
            }
        
        }
        public BigInteger(int sign, byte[] bytes, int offset, int length)
        {
            int val_5;
            var val_6;
            val_5 = length;
            this.nBits = 0;
            this.nBitLength = 0;
            if((sign + 1) < 3)
            {
                    if(sign != 0)
            {
                    val_5 = Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes:  bytes, offset:  offset, length:  val_5);
                this.magnitude = val_5;
                this.sign = (val_2.Length < 1) ? 0 : sign;
                return;
            }
            
                this.sign = 0;
                val_6 = null;
                val_6 = null;
                this.magnitude = Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
                return;
            }
            
            System.FormatException val_4 = new System.FormatException(message:  "Invalid sign value");
        }
        public BigInteger(int sizeInBits, System.Random random)
        {
            var val_12;
            int val_13;
            var val_14;
            val_12 = val_1;
            int val_11 = sizeInBits;
            this.nBits = 0;
            this.nBitLength = 0;
            val_1 = new System.Object();
            if((val_11 & 2147483648) == 0)
            {
                    this.nBits = 0;
                this.nBitLength = 0;
                if(val_11 != 0)
            {
                    int val_2 = val_11 + 7;
                byte[] val_6 = new byte[0];
                val_12 = (((val_2 < 0) ? (val_11 + 14) : (val_2)) >> 3) << 3;
                val_13 = val_6.Length;
                val_11 = val_12 - val_11;
                if(val_13 == 0)
            {
                    val_13 = val_6.Length;
            }
            
                byte val_12 = val_6[0];
                int val_7 = val_11 & 31;
                val_7 = 255 >> val_7;
                val_12 = val_7 & val_12;
                val_6[0] = val_12;
                this.magnitude = Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes:  val_6, offset:  0, length:  val_13);
                this.sign = (val_8.Length > 0) ? 1 : 0;
                return;
            }
            
                this.sign = 0;
                val_14 = null;
                val_14 = null;
                this.magnitude = Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
                return;
            }
            
            System.ArgumentException val_10 = new System.ArgumentException(message:  "sizeInBits must be non-negative");
        }
        public BigInteger(int bitLength, int certainty, System.Random random)
        {
            int val_14;
            var val_15;
            var val_16;
            int val_17;
            byte val_18;
            int val_19;
            var val_20;
            val_14 = bitLength;
            this.nBits = 0;
            this.nBitLength = 0;
            val_1 = new System.Object();
            if(val_14 <= 1)
            {
                goto label_1;
            }
            
            this.sign = 1;
            this.nBitLength = val_14;
            if(val_14 != 2)
            {
                goto label_2;
            }
            
            val_15 = null;
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_16 = null;
            if(Org.BouncyCastle.Math.BigInteger.Three == null)
            {
                goto label_7;
            }
            
            label_27:
            this.magnitude = Org.BouncyCastle.Math.BigInteger.Three.magnitude;
            return;
            label_2:
            int val_2 = val_14 + 7;
            var val_4 = (val_2 < 0) ? (val_14 + 14) : (val_2);
            var val_5 = val_4 >> 3;
            byte[] val_6 = new byte[0];
            val_2 = val_4 & 4294967288;
            var val_15 = 7;
            val_2 = val_2 - val_14;
            val_15 = val_15 - val_2;
            val_2 = val_2 & 31;
            val_14 = ((long)(val_4 >> 3) & 536870911) - 1;
            val_2 = 255 >> val_2;
            label_21:
            val_17 = val_6.Length;
            if(val_17 == 0)
            {
                    val_17 = val_6.Length;
            }
            
            val_18 = val_2 & val_6[0];
            val_6[0] = val_18;
            if(val_17 == 0)
            {
                    val_18 = val_6[0];
                val_17 = val_6.Length;
            }
            
            val_18 = (1 << (val_15 & 31)) | val_18;
            val_6[0] = val_18;
            mem2[0] = 1152921505721910208 | 1;
            this.magnitude = Org.BouncyCastle.Math.BigInteger.MakeMagnitude(bytes:  val_6, offset:  0, length:  val_6.Length);
            this.nBits = 0;
            this.mQuote = 0;
            if(certainty < 1)
            {
                    return;
            }
            
            val_19 = certainty;
            if((this.CheckProbablePrime(certainty:  val_19, random:  System.Random val_1 = random, randomlySelected:  true)) == true)
            {
                    return;
            }
            
            var val_19 = 1;
            label_24:
            int val_17 = this.magnitude.Length;
            val_17 = val_17 - 1;
            if(val_19 >= val_17)
            {
                goto label_21;
            }
            
            if(val_19 >= this.magnitude.Length)
            {
                    val_19 = 0;
            }
            
            this.magnitude[1] = val_1 ^ this.magnitude[1];
            val_19 = val_19 + 1;
            if((this.CheckProbablePrime(certainty:  certainty, random:  val_1, randomlySelected:  true)) == false)
            {
                goto label_24;
            }
            
            return;
            label_4:
            val_20 = null;
            if(Org.BouncyCastle.Math.BigInteger.Two != null)
            {
                goto label_27;
            }
            
            label_7:
            label_1:
            System.ArithmeticException val_14 = new System.ArithmeticException(message:  "bitLength < 2");
        }
        public Org.BouncyCastle.Math.BigInteger Abs()
        {
            if((this.sign & 2147483648) != 0)
            {
                    return this.Negate();
            }
            
            return (Org.BouncyCastle.Math.BigInteger)this;
        }
        private static int[] AddMagnitudes(int[] a, int[] b)
        {
            int val_6;
            int val_6 = a.Length;
            val_6 = b.Length;
            int val_1 = val_6 - 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (System.Int32[])a;
            }
            
            val_6 = val_6 - 1;
            int val_9 = 0;
            var val_10 = (long)val_1;
            do
            {
                val_9 = (val_9 + (a[((long)(int)((a.Length - 1))) << 2])) + (b[((long)(int)((b.Length - 1))) << 2]);
                mem2[0] = val_9;
                val_9 = val_9 >> 32;
                val_10 = val_10 - 1;
                var val_3 = (long)val_6 - 1;
            }
            while((val_10 & 2147483648) == 0);
            
            if(val_9 == 0)
            {
                    return (System.Int32[])a;
            }
            
            int val_4 = val_6 - val_6;
            do
            {
                if((val_4 & 2147483648) != 0)
            {
                    return (System.Int32[])a;
            }
            
                int val_5 = val_4 - 1;
                val_6 = (long)val_4;
                int val_11 = a[((long)(int)(((a.Length - 1) - b.Length))) << 2];
                val_11 = val_11 + 1;
                a[((long)(int)(((a.Length - 1) - b.Length))) << 2] = val_11;
            }
            while(val_11 == 0);
            
            return (System.Int32[])a;
        }
        public Org.BouncyCastle.Math.BigInteger Add(Org.BouncyCastle.Math.BigInteger value)
        {
            var val_3;
            var val_4;
            Org.BouncyCastle.Math.BigInteger val_5;
            var val_6;
            var val_7;
            val_3 = value;
            if(this.sign == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_3;
            }
            
            if(val_3 == null)
            {
                goto label_1;
            }
            
            val_4 = val_3;
            if(this.sign == value.sign)
            {
                    return this.AddToMagnitude(magToAdd:  value.magnitude);
            }
            
            if(value.sign == 0)
            {
                goto label_3;
            }
            
            label_9:
            if(val_3 == null)
            {
                goto label_4;
            }
            
            if((value.sign & 2147483648) != 0)
            {
                goto label_5;
            }
            
            label_10:
            val_5 = this.Negate();
            return this.Subtract(n:  val_5 = val_3.Negate());
            label_1:
            val_6 = 28563616;
            if(this.sign == 28563616)
            {
                    return this.AddToMagnitude(magToAdd:  value.magnitude);
            }
            
            val_7 = 24;
            if(28563616 != 0)
            {
                goto label_9;
            }
            
            label_3:
            val_3 = this;
            return (Org.BouncyCastle.Math.BigInteger)val_3;
            label_4:
            if(((value + 24) & 2147483648) == 0)
            {
                goto label_10;
            }
            
            label_5:
            return this.Subtract(n:  val_5);
        }
        private Org.BouncyCastle.Math.BigInteger AddToMagnitude(int[] magToAdd)
        {
            var val_10;
            var val_11;
            System.Array val_12;
            if(this.magnitude == null)
            {
                goto label_1;
            }
            
            label_17:
            var val_1 = (this.magnitude.Length < magToAdd.Length) ? magToAdd : this.magnitude;
            System.Int32[] val_2 = (this.magnitude.Length < magToAdd.Length) ? this.magnitude : magToAdd;
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            label_19:
            val_10 = mem[this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 24];
            val_10 = this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 24;
            if(val_10 != (this.magnitude.Length < magToAdd.Length ? this.magnitude : magToAdd + 24))
            {
                goto label_5;
            }
            
            if(val_10 == 0)
            {
                    val_10 = mem[this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 24];
                val_10 = this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 24;
            }
            
            val_11 = this.magnitude.Length < magToAdd.Length ? this.magnitude : magToAdd + 32;
            val_11 = ~(this.magnitude.Length < magToAdd.Length ? this.magnitude : magToAdd + 32);
            if(val_10 != 0)
            {
                goto label_9;
            }
            
            goto label_8;
            label_5:
            val_11 = 0;
            if(val_10 != 0)
            {
                goto label_9;
            }
            
            label_8:
            label_9:
            if((this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 32) < val_11)
            {
                goto label_10;
            }
            
            var val_3 = (this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 24) + 1;
            int[] val_4 = new int[0];
            val_12 = val_4;
            val_1.CopyTo(array:  val_4, index:  1);
            goto label_13;
            label_10:
            object val_5 = val_1.Clone();
            if(val_5 == null)
            {
                goto label_12;
            }
            
            val_12 = val_5;
            if(val_12 != null)
            {
                goto label_13;
            }
            
            label_12:
            val_12 = 0;
            label_13:
            System.Int32[] val_8 = Org.BouncyCastle.Math.BigInteger.AddMagnitudes(a:  val_12, b:  val_2);
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  this.sign, mag:  val_12, checkMag:  ((this.magnitude.Length < magToAdd.Length ? magToAdd : this.magnitude + 32) >= val_11) ? 1 : 0);
            label_1:
            if(magToAdd != null)
            {
                goto label_17;
            }
            
            goto label_17;
            label_3:
            if(val_2 != 0)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        public Org.BouncyCastle.Math.BigInteger And(Org.BouncyCastle.Math.BigInteger value)
        {
            var val_11;
            int val_12;
            Org.BouncyCastle.Math.BigInteger val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            Org.BouncyCastle.Math.BigInteger val_21;
            var val_22;
            int val_23;
            int val_24;
            int val_25;
            var val_26;
            val_11 = value;
            if(mem[1152921543941415736] == 0)
            {
                goto label_3;
            }
            
            val_12 = value.sign;
            if(val_12 == 0)
            {
                goto label_3;
            }
            
            val_13 = this;
            if(mem[1152921543941415736] <= 0)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = this.Add(value:  Org.BouncyCastle.Math.BigInteger.One);
                val_12 = value.sign;
            }
            
            val_15 = val_11;
            if(val_12 > 0)
            {
                goto label_8;
            }
            
            val_16 = null;
            val_16 = null;
            if((val_11.Add(value:  Org.BouncyCastle.Math.BigInteger.One)) == null)
            {
                goto label_11;
            }
            
            label_8:
            if((mem[1152921543941415736] & 2147483648) != 0)
            {
                goto label_12;
            }
            
            if(val_1.magnitude != null)
            {
                goto label_22;
            }
            
            label_23:
            label_22:
            int val_3 = System.Math.Max(val1:  val_1.magnitude.Length, val2:  val_2.magnitude.Length);
            int[] val_4 = new int[0];
            if(val_4 == null)
            {
                goto label_17;
            }
            
            val_17 = val_4;
            val_18 = val_4.Length;
            val_19 = val_18 - val_1.magnitude.Length;
            goto label_18;
            label_3:
            val_20 = null;
            val_20 = null;
            val_21 = Org.BouncyCastle.Math.BigInteger.Zero;
            return val_21;
            label_12:
            int val_9 = value.sign;
            val_9 = val_9 >> 31;
            if(val_1.magnitude != null)
            {
                goto label_22;
            }
            
            goto label_23;
            label_17:
            val_17 = 24;
            val_19 = 28563616 - val_1.magnitude.Length;
            val_18 = 28563616;
            label_18:
            val_22 = 0;
            val_18 = val_2.magnitude.Length - val_18;
            goto label_24;
            label_39:
            if(val_22 < val_19)
            {
                    val_23 = 0;
            }
            else
            {
                    int val_10 = -val_19;
                val_10 = val_10 + val_22;
                val_23 = val_1.magnitude[(long)val_10];
            }
            
            if(val_22 < (val_18 - val_2.magnitude.Length))
            {
                    val_24 = 0;
            }
            else
            {
                    int val_11 = val_18;
                val_11 = val_11 + val_22;
                val_24 = val_2.magnitude[(long)val_11];
            }
            
            val_25 = (val_24 ^ (value.sign >> 31)) & (val_23 ^ (mem[1152921543941415736] >> 31));
            val_4[0] = val_25;
            val_11 = val_11;
            if(val_9 != 0)
            {
                    val_26 = 28563616;
                if(val_22 >= val_26)
            {
                    val_25 = mem[val_4[0x0] + 32];
                val_25 = val_4[0x0] + 32;
                val_26 = 28563616;
            }
            
                mem2[0] = ~val_25;
            }
            
            val_22 = 1;
            label_24:
            if(val_22 < val_17)
            {
                goto label_39;
            }
            
            Org.BouncyCastle.Math.BigInteger val_8 = null;
            val_21 = val_8;
            val_8 = new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_4, checkMag:  true);
            if(val_9 == 0)
            {
                    return val_21;
            }
            
            if(val_21 != null)
            {
                    return val_8.Not();
            }
            
            return val_8.Not();
            label_11:
        }
        public Org.BouncyCastle.Math.BigInteger AndNot(Org.BouncyCastle.Math.BigInteger val)
        {
            return this.And(value:  val.Not());
        }
        public int get_BitCount()
        {
            int val_4;
            var val_5;
            val_4 = this.nBits;
            if(val_4 != 1)
            {
                    return val_4;
            }
            
            if((this.sign & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_5 = 0;
            val_4 = 0;
            goto label_3;
            label_9:
            int val_4 = this.magnitude[0];
            int val_1 = val_4 >> 1;
            val_1 = val_1 & 1431655765;
            val_1 = val_4 - val_1;
            val_1 = val_1 >> 2;
            val_1 = val_1 & 858993459;
            val_1 = val_1 + (val_1 & 858993459);
            val_1 = val_1 + (val_1 >> 4);
            val_1 = val_1 & 252645135;
            val_1 = val_1 + (val_1 >> 8);
            val_1 = val_1 + (val_1 >> 16);
            val_1 = val_1 & 63;
            val_4 = val_1 + val_4;
            val_5 = 1;
            label_3:
            if(val_5 < this.magnitude.Length)
            {
                goto label_9;
            }
            
            goto label_10;
            label_2:
            val_4 = this.Not();
            label_10:
            this.nBits = val_4;
            return val_4;
        }
        public static int BitCnt(int i)
        {
            int val_1 = i >> 1;
            val_1 = val_1 & 1431655765;
            val_1 = i - val_1;
            val_1 = val_1 >> 2;
            val_1 = val_1 & 858993459;
            val_1 = val_1 + (val_1 & 858993459);
            val_1 = val_1 + (val_1 >> 4);
            val_1 = val_1 & 252645135;
            val_1 = val_1 + (val_1 >> 8);
            val_1 = val_1 + (val_1 >> 16);
            i = val_1 & 63;
            return (int)i;
        }
        private static int CalcBitLength(int sign, int indx, int[] mag)
        {
            var val_7;
            int val_8;
            var val_9;
            val_7 = indx;
            var val_1 = (-33) - (val_7 << 5);
            goto label_1;
            label_5:
            val_8 = mag[((long)(int)(indx)) << 2];
            if(val_8 != 0)
            {
                goto label_3;
            }
            
            val_7 = val_7 + 1;
            val_1 = val_1 - 32;
            label_1:
            if(val_7 < mag.Length)
            {
                goto label_5;
            }
            
            val_9 = 0;
            return (int)val_9;
            label_3:
            if(val_7 >= mag.Length)
            {
                    val_8 = mem[mag[((long)(int)(indx)) << 2] + 32];
                val_8 = mag[((long)(int)(indx)) << 2] + 32;
            }
            
            int val_2 = Org.BouncyCastle.Math.BigInteger.BitLen(w:  val_8);
            int val_3 = val_2 + (mag.Length << 5);
            var val_5 = 7;
            val_3 = val_3 + val_1;
            val_5 = val_5 & (~(sign >> 31));
            val_9 = val_3 + 1;
            if(val_5 != 0)
            {
                    return (int)val_9;
            }
            
            var val_6 = -val_8;
            val_6 = val_8 & (~val_6);
            if(val_6 != 0)
            {
                    return (int)val_9;
            }
            
            val_7 = val_7 + 1;
            label_14:
            if(val_7 >= mag.Length)
            {
                goto label_12;
            }
            
            val_8 = (long)val_7;
            val_7 = val_7 + 1;
            if((mag[((long)(int)((indx + 1))) << 2]) == 0)
            {
                goto label_14;
            }
            
            return (int)val_9;
            label_12:
            val_9 = (val_2 + (mag.Length << 5)) + val_1;
            return (int)val_9;
        }
        public int get_BitLength()
        {
            int val_2 = this.nBitLength;
            if(val_2 != 1)
            {
                    return val_2;
            }
            
            if(this.sign != 0)
            {
                    val_2 = this.sign;
                int val_1 = Org.BouncyCastle.Math.BigInteger.CalcBitLength(sign:  val_2, indx:  0, mag:  this.magnitude);
            }
            else
            {
                    val_2 = 0;
            }
            
            this.nBitLength = val_2;
            return val_2;
        }
        internal static int BitLen(int w)
        {
            var val_11;
            System.Byte[] val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            int val_1 = w >> 24;
            if(val_1 != 0)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = Org.BouncyCastle.Math.BigInteger.BitLengthTable;
                System.Byte[] val_2 = val_12 + val_1;
                val_13 = ((Org.BouncyCastle.Math.BigInteger.BitLengthTable + (w >> 24)) + 32) + 24;
                return (int)val_13;
            }
            
            int val_3 = w >> 16;
            if(val_3 != 0)
            {
                    val_14 = null;
                val_14 = null;
                val_12 = Org.BouncyCastle.Math.BigInteger.BitLengthTable;
                System.Byte[] val_4 = val_12 + val_3;
                val_13 = ((Org.BouncyCastle.Math.BigInteger.BitLengthTable + (w >> 16)) + 32) + 16;
                return (int)val_13;
            }
            
            int val_5 = w >> 8;
            val_15 = null;
            if(val_5 != 0)
            {
                    val_16 = null;
                val_12 = Org.BouncyCastle.Math.BigInteger.BitLengthTable;
                System.Byte[] val_6 = val_12 + val_5;
                val_13 = ((Org.BouncyCastle.Math.BigInteger.BitLengthTable + (w >> 8)) + 32) + 8;
                return (int)val_13;
            }
            
            val_17 = null;
            val_12 = w;
            System.Byte[] val_7 = Org.BouncyCastle.Math.BigInteger.BitLengthTable + val_12;
            val_13 = mem[(Org.BouncyCastle.Math.BigInteger.BitLengthTable + w) + 32];
            val_13 = (Org.BouncyCastle.Math.BigInteger.BitLengthTable + w) + 32;
            return (int)val_13;
        }
        private bool QuickPow2Check()
        {
            if(this.sign < 1)
            {
                    return false;
            }
            
            return (bool)(this.nBits == 1) ? 1 : 0;
        }
        public int CompareTo(object obj)
        {
            object val_4 = obj;
            if(val_4 == null)
            {
                    return (int)this.CompareTo(value:  val_4 = 0);
            }
            
            return (int)this.CompareTo(value:  val_4);
        }
        private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
        {
            int val_1;
            int val_2;
            val_1 = yIndx;
            val_2 = xIndx;
            goto label_1;
            label_5:
            val_2 = val_2 + 1;
            label_1:
            if(val_2 == x.Length)
            {
                goto label_6;
            }
            
            if((x[((long)(int)((xIndx + 1))) << 2]) == 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_10:
            if((y[((long)(int)(yIndx)) << 2]) != 0)
            {
                    return Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  val_2, x:  x, yIndx:  val_1 = val_1 + 1, y:  y);
            }
            
            label_6:
            if(val_1 != y.Length)
            {
                goto label_10;
            }
            
            return Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  val_2, x:  x, yIndx:  val_1, y:  y);
        }
        private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
        {
            var val_3;
            int val_8 = yIndx;
            int val_7 = xIndx;
            if(x == null)
            {
                goto label_0;
            }
            
            label_5:
            int val_4 = x.Length;
            int val_3 = y.Length;
            val_3 = val_4 - val_3;
            val_3 = val_3 + (val_8 - val_7);
            if(val_3 == 0)
            {
                goto label_2;
            }
            
            val_4 = val_3 >> 31;
            val_3 = val_4 | 1;
            return (int)(val_5 >= val_6) ? (-0) : 0;
            label_0:
            if(y != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_2:
            if(val_4 > val_7)
            {
                    do
            {
                int val_5 = x[((long)(int)(xIndx)) << 2];
                int val_6 = y[((long)(int)(yIndx)) << 2];
                if(val_5 != val_6)
            {
                    return (int)(val_5 >= val_6) ? (-0) : 0;
            }
            
                val_7 = val_7 + 1;
                val_8 = val_8 + 1;
            }
            while(val_7 < x.Length);
            
            }
            
            val_3 = 0;
            return (int)(val_5 >= val_6) ? (-0) : 0;
        }
        public int CompareTo(Org.BouncyCastle.Math.BigInteger value)
        {
            System.Int32[] val_2;
            var val_3;
            val_2 = value;
            if(this.sign < value.sign)
            {
                    val_3 = 0;
                return (int)val_3;
            }
            
            if(this.sign > value.sign)
            {
                    val_3 = 1;
                return (int)val_3;
            }
            
            if(this.sign != 0)
            {
                    val_2 = value.magnitude;
                val_3 = (Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  0, x:  this.magnitude, yIndx:  0, y:  val_2)) * this.sign;
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        private int[] Divide(int[] x, int[] y)
        {
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            System.Int32[] val_28;
            var val_29;
            System.Array val_30;
            var val_31;
            Org.BouncyCastle.Math.BigInteger val_32;
            var val_33;
            var val_34;
            int val_35;
            var val_36;
            var val_38;
            var val_39;
            val_24 = 0;
            goto label_1;
            label_5:
            if(x[0] != 0)
            {
                goto label_3;
            }
            
            val_24 = 1;
            label_1:
            if(val_24 < x.Length)
            {
                goto label_5;
            }
            
            label_3:
            val_25 = 0;
            goto label_6;
            label_10:
            if(y[0] != 0)
            {
                goto label_8;
            }
            
            val_25 = 1;
            label_6:
            if(val_25 < y.Length)
            {
                goto label_10;
            }
            
            label_8:
            val_26 = 1152921505512914944;
            val_27 = Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  1, x:  x, yIndx:  1, y:  y);
            if(val_27 < 1)
            {
                goto label_13;
            }
            
            int val_26 = Org.BouncyCastle.Math.BigInteger.CalcBitLength(sign:  1, indx:  1, mag:  y);
            int val_3 = Org.BouncyCastle.Math.BigInteger.CalcBitLength(sign:  1, indx:  1, mag:  x);
            val_26 = val_3 - val_26;
            if(val_26 < 1)
            {
                goto label_16;
            }
            
            int val_5 = (val_26 >> 5) + 1;
            val_28 = new int[0];
            val_28[0] = 1 << (val_26 & 31);
            val_29 = 1152921505512914944;
            val_30 = Org.BouncyCastle.Math.BigInteger.ShiftLeft(mag:  y, n:  val_26);
            goto label_21;
            label_13:
            label_33:
            if(val_27 != 0)
            {
                    return (System.Int32[])val_16;
            }
            
            val_31 = null;
            val_31 = null;
            val_32 = Org.BouncyCastle.Math.BigInteger.One;
            System.Int32[] val_11 = Org.BouncyCastle.Math.BigInteger.AddMagnitudes(a:  new int[1], b:  Org.BouncyCastle.Math.BigInteger.One.magnitude);
            System.Array.Clear(array:  x, index:  1, length:  x.Length - val_24);
            return (System.Int32[])val_16;
            label_16:
            int[] val_13 = new int[1];
            val_28 = val_13;
            val_28[0] = 1;
            int[] val_15 = new int[0];
            val_30 = val_15;
            System.Array.Copy(sourceArray:  y, sourceIndex:  1, destinationArray:  val_15, destinationIndex:  0, length:  y.Length - val_25);
            label_21:
            int[] val_16 = new int[0];
            val_33 = 0;
            val_34 = 0;
            goto label_30;
            label_69:
            if((Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  1, x:  x, yIndx:  1, y:  y)) < 1)
            {
                goto label_33;
            }
            
            label_68:
            val_35 = val_26 - val_3;
            if(val_35 != 1)
            {
                goto label_34;
            }
            
            val_36 = null;
            if((val_30[0] >> 1) <= x[4])
            {
                goto label_42;
            }
            
            val_35 = 2;
            goto label_44;
            label_34:
            val_36 = null;
            if(val_35 <= 1)
            {
                goto label_42;
            }
            
            label_44:
            Org.BouncyCastle.Math.BigInteger.ShiftRightInPlace(start:  0, mag:  val_15, n:  val_35);
            int val_29 = val_26;
            val_29 = val_29 - val_35;
            Org.BouncyCastle.Math.BigInteger.ShiftRightInPlace(start:  0, mag:  val_13, n:  val_35);
            if(val_30 != null)
            {
                goto label_49;
            }
            
            goto label_46;
            label_42:
            Org.BouncyCastle.Math.BigInteger.ShiftRightOneInPlace(start:  0, mag:  val_15);
            int val_30 = val_29;
            val_30 = val_30 - 1;
            Org.BouncyCastle.Math.BigInteger.ShiftRightOneInPlace(start:  0, mag:  val_13);
            label_51:
            if(val_30 != null)
            {
                goto label_49;
            }
            
            label_46:
            label_49:
            if(val_30[0] == 0)
            {
                goto label_51;
            }
            
            val_33 = 0;
            do
            {
            
            }
            while(val_28[0] == 0);
            
            val_29 = 1152921505512914944;
            val_34 = (0 + 1) - 1;
            label_30:
            if(val_30 >= val_3)
            {
                    if(((Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  1, x:  x, yIndx:  0, y:  val_15)) & 2147483648) != 0)
            {
                goto label_68;
            }
            
            }
            
            val_38 = null;
            System.Int32[] val_21 = Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  x, yStart:  0, y:  val_15);
            System.Int32[] val_22 = Org.BouncyCastle.Math.BigInteger.AddMagnitudes(a:  val_16, b:  val_13);
            label_63:
            val_27 = x[4];
            if(val_27 != 0)
            {
                goto label_62;
            }
            
            val_24 = val_24 + 1;
            val_39 = 64 + 32;
            if(val_24 != x.Length)
            {
                goto label_63;
            }
            
            return (System.Int32[])val_16;
            label_62:
            if(val_24 >= x.Length)
            {
                    val_27 = mem[x[0x4] + 32];
                val_27 = x[0x4] + 32;
            }
            
            val_32 = 1152921505512914944;
            int val_33 = x.Length;
            val_33 = (Org.BouncyCastle.Math.BigInteger.BitLen(w:  val_27)) + (val_33 << 5);
            val_39 = val_33 - 64;
            if(val_39 > val_26)
            {
                goto label_68;
            }
            
            if(val_39 >= val_26)
            {
                goto label_69;
            }
            
            return (System.Int32[])val_16;
        }
        public Org.BouncyCastle.Math.BigInteger Divide(Org.BouncyCastle.Math.BigInteger val)
        {
            int val_13;
            var val_14;
            System.Int32[] val_15;
            Org.BouncyCastle.Math.BigInteger val_16;
            var val_17;
            var val_18;
            if(val.sign == 0)
            {
                goto label_2;
            }
            
            if(this.sign == 0)
            {
                goto label_3;
            }
            
            if((val.sign < 1) || (val.nBits != 1))
            {
                goto label_5;
            }
            
            if((this.sign & 2147483648) != 0)
            {
                goto label_6;
            }
            
            val_14 = val.BitLength;
            val_13 = this;
            goto label_17;
            label_5:
            object val_2 = this.magnitude.Clone();
            if(val_2 == null)
            {
                goto label_9;
            }
            
            val_15 = val_2;
            if(val_15 != null)
            {
                goto label_10;
            }
            
            label_9:
            val_15 = 0;
            label_10:
            val_13 = this.sign;
            Org.BouncyCastle.Math.BigInteger val_6 = null;
            val_16 = val_6;
            val_6 = new Org.BouncyCastle.Math.BigInteger(signum:  val.sign * val_13, mag:  X0.Divide(x:  val_15, y:  val.magnitude), checkMag:  true);
            return (Org.BouncyCastle.Math.BigInteger)val_16;
            label_3:
            val_17 = null;
            val_17 = null;
            val_16 = Org.BouncyCastle.Math.BigInteger.Zero;
            return (Org.BouncyCastle.Math.BigInteger)val_16;
            label_6:
            val_13 = this.Negate();
            val_18 = val;
            if((val.sign & 2147483648) != 0)
            {
                    if(val.Negate() == null)
            {
                    val_18 = 0;
            }
            
            }
            
            val_14 = this.BitLength;
            label_17:
            val_16 = val_13.ShiftRight(n:  val_14 - 1);
            if(val.sign == this.sign)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_16;
            }
            
            if(val_16 != null)
            {
                    return val_16.Negate();
            }
            
            return val_16.Negate();
            label_2:
            System.ArithmeticException val_12 = new System.ArithmeticException(message:  "Division by zero error");
        }
        public Org.BouncyCastle.Math.BigInteger[] DivideAndRemainder(Org.BouncyCastle.Math.BigInteger val)
        {
            int val_15;
            Org.BouncyCastle.Math.BigInteger val_16;
            int val_17;
            System.Int32[] val_18;
            Org.BouncyCastle.Math.BigInteger val_19;
            var val_20;
            int val_21;
            System.Int32[] val_22;
            var val_23;
            if(val.sign == 0)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Math.BigInteger[] val_1 = new Org.BouncyCastle.Math.BigInteger[2];
            if(this.sign == 0)
            {
                goto label_3;
            }
            
            if((val.sign < 1) || (val.nBits != 1))
            {
                goto label_5;
            }
            
            val_15 = val.BitLength - 1;
            if((this.sign & 2147483648) != 0)
            {
                    Org.BouncyCastle.Math.BigInteger val_3 = this.Negate();
            }
            
            val_16 = this.ShiftRight(n:  val_15);
            val_17 = this.LastNBits(n:  val_15);
            if(val.sign != this.sign)
            {
                goto label_8;
            }
            
            if(val_1 == null)
            {
                goto label_9;
            }
            
            label_29:
            if(val_16 != null)
            {
                goto label_10;
            }
            
            goto label_31;
            label_5:
            object val_6 = this.magnitude.Clone();
            if(val_6 == null)
            {
                goto label_13;
            }
            
            val_18 = val_6;
            if(val_18 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_18 = 0;
            label_14:
            val_15 = X0.Divide(x:  val_18, y:  val.magnitude);
            val_1[0] = new Org.BouncyCastle.Math.BigInteger(signum:  val.sign * this.sign, mag:  val_15, checkMag:  true);
            val_17 = this.sign;
            val_19 = new Org.BouncyCastle.Math.BigInteger();
            val_20 = 1;
            val_21 = val_17;
            val_22 = val_18;
            goto label_19;
            label_3:
            val_17 = 1152921505512914944;
            val_23 = null;
            val_23 = null;
            val_1[0] = Org.BouncyCastle.Math.BigInteger.Zero;
            val_19 = Org.BouncyCastle.Math.BigInteger.Zero;
            if(val_19 != null)
            {
                goto label_26;
            }
            
            goto label_34;
            label_8:
            val_16 = val_16.Negate();
            if(val_1 != null)
            {
                goto label_29;
            }
            
            label_9:
            if(val_16 == null)
            {
                goto label_31;
            }
            
            label_10:
            label_31:
            val_1[0] = val_16;
            Org.BouncyCastle.Math.BigInteger val_12 = null;
            val_19 = val_12;
            val_20 = 1;
            val_21 = this.sign;
            val_22 = val_17;
            label_19:
            val_12 = new Org.BouncyCastle.Math.BigInteger(signum:  val_21, mag:  val_22, checkMag:  true);
            if(val_19 == null)
            {
                goto label_34;
            }
            
            label_26:
            label_34:
            val_1[1] = val_19;
            return val_1;
            label_2:
            System.ArithmeticException val_13 = new System.ArithmeticException(message:  "Division by zero error");
        }
        public override bool Equals(object obj)
        {
            var val_2;
            if(this != obj)
            {
                    if(obj != null)
            {
                    return this.IsEqualMagnitude(x:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Math.BigInteger.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0);
            }
            
                val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        private bool IsEqualMagnitude(Org.BouncyCastle.Math.BigInteger x)
        {
            System.Int32[] val_1;
            var val_2;
            val_1 = this.magnitude;
            if(val_1 == null)
            {
                goto label_0;
            }
            
            label_13:
            if(this.magnitude.Length != x.magnitude.Length)
            {
                goto label_3;
            }
            
            val_1 = 0;
            label_10:
            if(val_1 >= this.magnitude.Length)
            {
                goto label_5;
            }
            
            val_1 = val_1 + 1;
            if(this.magnitude[0] == x.magnitude[0])
            {
                goto label_10;
            }
            
            label_3:
            val_2 = 0;
            return (bool)val_2;
            label_0:
            if(x != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_5:
            val_2 = 1;
            return (bool)val_2;
        }
        public Org.BouncyCastle.Math.BigInteger Gcd(Org.BouncyCastle.Math.BigInteger value)
        {
            var val_7;
            var val_8;
            val_7 = value;
            val_8 = this;
            if(value.sign == 0)
            {
                goto label_1;
            }
            
            if(this.sign != 0)
            {
                goto label_2;
            }
            
            val_8 = val_7;
            label_1:
            if((value.sign & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_8;
            }
            
            return val_8.Negate();
            label_5:
            val_7 = ???.Mod(m:  ???);
            val_8 = ???;
            label_2:
            if(val_1.sign != 0)
            {
                goto label_5;
            }
            
            return (Org.BouncyCastle.Math.BigInteger)val_8;
        }
        public override int GetHashCode()
        {
            System.Int32[] val_3;
            int val_4;
            System.Int32[] val_5;
            val_3 = this.magnitude;
            if(this.magnitude != null)
            {
                goto label_0;
            }
            
            val_3 = this.magnitude;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            label_0:
            val_4 = this.magnitude.Length;
            if(this.magnitude.Length == 0)
            {
                    return (int)val_4 ^ (this.sign >> 31);
            }
            
            val_5 = this.magnitude;
            val_4 = this.magnitude[0] ^ val_4;
            if(this.magnitude.Length < 2)
            {
                    return (int)val_4 ^ (this.sign >> 31);
            }
            
            val_5 = this.magnitude;
            var val_4 = -4294967296;
            val_4 = val_4 + ((this.magnitude.Length) << 32);
            val_4 = (val_5[val_4 >> 32]) ^ val_4;
            return (int)val_4 ^ (this.sign >> 31);
            label_1:
        }
        private Org.BouncyCastle.Math.BigInteger Inc()
        {
            var val_3;
            var val_4;
            Org.BouncyCastle.Math.BigInteger val_5;
            var val_6;
            if(this.sign == 0)
            {
                goto label_1;
            }
            
            if((this.sign & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_3 = null;
            val_3 = null;
            if(Org.BouncyCastle.Math.BigInteger.One != null)
            {
                    return this.AddToMagnitude(magToAdd:  Org.BouncyCastle.Math.BigInteger.One.magnitude);
            }
            
            return this.AddToMagnitude(magToAdd:  Org.BouncyCastle.Math.BigInteger.One.magnitude);
            label_1:
            val_4 = null;
            val_4 = null;
            val_5 = Org.BouncyCastle.Math.BigInteger.One;
            return (Org.BouncyCastle.Math.BigInteger)val_5;
            label_2:
            val_6 = null;
            val_6 = null;
            Org.BouncyCastle.Math.BigInteger val_2 = null;
            val_5 = val_2;
            val_2 = new Org.BouncyCastle.Math.BigInteger(signum:  0, mag:  Org.BouncyCastle.Math.BigInteger.doSubBigLil(bigMag:  this.magnitude, lilMag:  Org.BouncyCastle.Math.BigInteger.One.magnitude), checkMag:  true);
            return (Org.BouncyCastle.Math.BigInteger)val_5;
        }
        public int get_IntValue()
        {
            System.Int32[] val_4;
            int val_5;
            var val_6;
            if(this.sign == 0)
            {
                goto label_0;
            }
            
            val_4 = this.magnitude;
            if(val_4 == null)
            {
                goto label_1;
            }
            
            val_5 = this.magnitude.Length;
            goto label_5;
            label_0:
            val_6 = 0;
            return (int)(this.sign < 0) ? (-((val_4 + ((long)(int)((this.magnitude.Length - 1))) << 2) + 32)) : ((val_4 + ((long)(int)((this.magnitude.Length - 1))) << 2) + 32);
            label_1:
            val_5 = this.magnitude.Length;
            if(this.magnitude != null)
            {
                    val_4 = this.magnitude;
            }
            else
            {
                    val_4 = 0;
            }
            
            label_5:
            int val_1 = val_5 - 1;
            var val_2 = val_4 + (((long)(int)((this.magnitude.Length - 1))) << 2);
            return (int)(this.sign < 0) ? (-((val_4 + ((long)(int)((this.magnitude.Length - 1))) << 2) + 32)) : ((val_4 + ((long)(int)((this.magnitude.Length - 1))) << 2) + 32);
        }
        public bool IsProbablePrime(int certainty)
        {
            return this.IsProbablePrime(certainty:  certainty, randomlySelected:  false);
        }
        internal bool IsProbablePrime(int certainty, bool randomlySelected)
        {
            var val_12;
            int val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_12 = randomlySelected;
            val_13 = certainty;
            val_14 = this;
            if(val_13 < 1)
            {
                goto label_1;
            }
            
            if((this.sign & 2147483648) != 0)
            {
                    val_14 = this.Negate();
                if(val_14 == null)
            {
                goto label_15;
            }
            
            }
            
            val_15 = 0;
            label_15:
            val_16 = 1152921505512914944;
            val_17 = null;
            if((val_14.TestBit(n:  0)) == false)
            {
                goto label_4;
            }
            
            val_18 = null;
            if((val_14 & 1) == 0)
            {
                goto label_8;
            }
            
            val_19 = 0;
            return (bool)val_19;
            label_1:
            val_19 = 1;
            return (bool)val_19;
            label_4:
            val_20 = null;
            val_13 = ???;
            val_14 = ???;
            val_12 = ???;
            val_16 = ???;
            val_15 = ???;
            goto Org.BouncyCastle.Math.BigInteger.__il2cppRuntimeField_vtable;
            label_8:
            val_21 = mem[val_16];
            val_21 = val_16;
            if((((val_21 + 295) & 2) == 0) || ((val_21 + 216) != 0))
            {
                    return val_14.CheckProbablePrime(certainty:  val_13, random:  val_21 + 184 + 152, randomlySelected:  val_12 & 1);
            }
            
            val_21 = mem[val_16];
            val_21 = val_16;
            return val_14.CheckProbablePrime(certainty:  val_13, random:  val_21 + 184 + 152, randomlySelected:  val_12 & 1);
        }
        private bool CheckProbablePrime(int certainty, System.Random random, bool randomlySelected)
        {
            var val_11;
            var val_12;
            int val_13;
            var val_14;
            var val_15;
            val_11 = this.BitLength;
            val_12 = null;
            val_12 = null;
            val_13 = Org.BouncyCastle.Math.BigInteger.BytesPerInt;
            int val_3 = System.Math.Min(val1:  val_11 - 1, val2:  Org.BouncyCastle.Math.BigInteger.BytesPerInt + 24);
            if(val_3 < 1)
            {
                goto label_6;
            }
            
            label_18:
            val_14 = null;
            val_14 = null;
            val_11 = this.Remainder(m:  Org.BouncyCastle.Math.BigInteger.primeProducts.Length + 32);
            int val_5 = Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0;
            var val_11 = 0;
            label_16:
            if(val_11 >= ((Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0) + 32 + 24))
            {
                goto label_14;
            }
            
            var val_6 = ((Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0) + 32) + 0;
            val_11 = val_11 + 1;
            int val_7 = val_11 / (((Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0) + 32 + 0) + 32);
            val_7 = val_11 - (val_7 * (((Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0) + 32 + 0) + 32));
            if(val_7 != 0)
            {
                goto label_16;
            }
            
            goto label_17;
            label_14:
            val_13 = 0 + 1;
            if(val_13 < (long)val_3)
            {
                goto label_18;
            }
            
            label_6:
            randomlySelected = randomlySelected;
            return this.RabinMillerTest(certainty:  certainty, random:  random, randomlySelected:  randomlySelected);
            label_17:
            if(this.BitLength <= 15)
            {
                    var val_10 = (this.IntValue == (((Org.BouncyCastle.Math.BigInteger.BytesPerInt + 0) + 32 + 0) + 32)) ? 1 : 0;
                return (bool)val_15;
            }
            
            val_15 = 0;
            return (bool)val_15;
        }
        public bool RabinMillerTest(int certainty, System.Random random)
        {
            return this.RabinMillerTest(certainty:  certainty, random:  random, randomlySelected:  false);
        }
        internal bool RabinMillerTest(int certainty, System.Random random, bool randomlySelected)
        {
            int val_22;
            var val_23;
            int val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            int val_1 = this.BitLength;
            int val_2 = certainty - 1;
            var val_3 = (val_2 < 0) ? certainty : (val_2);
            val_3 = val_3 >> 1;
            val_22 = val_3 + 1;
            if(randomlySelected == false)
            {
                goto label_1;
            }
            
            if(val_1 > 1023)
            {
                    val_23 = 4;
            }
            else
            {
                    if(val_1 > 511)
            {
                    val_23 = 8;
            }
            else
            {
                    int val_4 = (val_1 > 255) ? 16 : 50;
            }
            
            }
            
            if(certainty <= 99)
            {
                goto label_6;
            }
            
            val_3 = val_3 + val_4;
            val_22 = val_3 - 49;
            label_1:
            if(this == null)
            {
                goto label_7;
            }
            
            label_11:
            val_24 = this.GetLowestSetBitMaskFirst(firstWordMask:  -2);
            goto label_8;
            label_6:
            val_22 = System.Math.Min(val1:  val_4, val2:  val_22);
            if(this != null)
            {
                goto label_11;
            }
            
            label_7:
            val_24 = this.GetLowestSetBitMaskFirst(firstWordMask:  -2);
            label_8:
            val_25 = null;
            val_25 = null;
            if(this.magnitude == null)
            {
                goto label_15;
            }
            
            label_38:
            Org.BouncyCastle.Math.BigInteger val_11 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  this.magnitude.Length << 5).Remainder(n:  this);
            do
            {
                label_35:
                Org.BouncyCastle.Math.BigInteger val_14 = new Org.BouncyCastle.Math.BigInteger(sizeInBits:  this.BitLength, random:  random);
            }
            while((Org.BouncyCastle.Math.BigInteger)[1152921543947485808].sign == 0);
            
            if(((((val_14.CompareTo(value:  this)) & 2147483648) == 0) || ((val_14.IsEqualMagnitude(x:  val_11)) == true)) || ((val_14.IsEqualMagnitude(x:  this.Subtract(n:  val_11))) == true))
            {
                goto label_35;
            }
            
            Org.BouncyCastle.Math.BigInteger val_18 = Org.BouncyCastle.Math.BigInteger.ModPowMonty(b:  val_14, e:  this.ShiftRight(n:  val_24), m:  this, convert:  false);
            val_26 = val_24;
            if((val_18 & 1) != 0)
            {
                goto label_28;
            }
            
            label_33:
            if((val_18 & 1) != 0)
            {
                goto label_28;
            }
            
            val_26 = val_26 - 1;
            if(val_26 == 0)
            {
                goto label_34;
            }
            
            val_27 = null;
            val_27 = null;
            if(((Org.BouncyCastle.Math.BigInteger.ModPowMonty(b:  val_18, e:  Org.BouncyCastle.Math.BigInteger.Two, m:  this, convert:  false)) & 1) == 0)
            {
                goto label_33;
            }
            
            goto label_34;
            label_28:
            val_22 = val_22 - 1;
            if(val_22 > 0)
            {
                goto label_35;
            }
            
            val_28 = 1;
            return (bool)val_28;
            label_34:
            val_28 = 0;
            return (bool)val_28;
            label_15:
            if(Org.BouncyCastle.Math.BigInteger.One != null)
            {
                goto label_38;
            }
            
            goto label_38;
        }
        public long get_LongValue()
        {
            System.Int32[] val_4;
            int val_5;
            int val_6;
            var val_7;
            if(this.sign == 0)
            {
                goto label_0;
            }
            
            val_4 = this.magnitude;
            if(this.magnitude != null)
            {
                goto label_1;
            }
            
            val_4 = this.magnitude;
            if(val_4 == null)
            {
                goto label_2;
            }
            
            label_1:
            val_5 = this.magnitude.Length;
            int val_1 = val_5 - 1;
            val_6 = val_4[(long)val_1];
            if(val_1 >= this.magnitude.Length)
            {
                    val_5 = this.magnitude;
                int val_4 = val_5[(long)val_5 - 2];
            }
            
            var val_3 = (this.sign < 0) ? (-val_6) : (val_6);
            return (long)val_7;
            label_0:
            val_7 = 0;
            return (long)val_7;
            label_2:
        }
        public Org.BouncyCastle.Math.BigInteger Max(Org.BouncyCastle.Math.BigInteger value)
        {
            return (Org.BouncyCastle.Math.BigInteger)((this.CompareTo(value:  value)) < 1) ? value : (this);
        }
        public Org.BouncyCastle.Math.BigInteger Min(Org.BouncyCastle.Math.BigInteger value)
        {
            return (Org.BouncyCastle.Math.BigInteger)((this.CompareTo(value:  value)) >= 0) ? value : (this);
        }
        public Org.BouncyCastle.Math.BigInteger Mod(Org.BouncyCastle.Math.BigInteger m)
        {
            if(m.sign > 0)
            {
                    Org.BouncyCastle.Math.BigInteger val_1 = this.Remainder(n:  m);
                if((val_1.sign & 2147483648) != 0)
            {
                    return val_1.Add(value:  m);
            }
            
                return val_1;
            }
            
            System.ArithmeticException val_2 = new System.ArithmeticException(message:  "Modulus must be positive");
        }
        public Org.BouncyCastle.Math.BigInteger ModInverse(Org.BouncyCastle.Math.BigInteger m)
        {
            Org.BouncyCastle.Math.BigInteger val_7;
            string val_9;
            Org.BouncyCastle.Math.BigInteger val_3 = 0;
            if(m.sign <= 0)
            {
                goto label_2;
            }
            
            if(m.nBits == 1)
            {
                    val_7 = this.ModInversePow2(m:  m);
                return val_7;
            }
            
            if(((Org.BouncyCastle.Math.BigInteger.ExtEuclid(a:  this.Remainder(n:  m), b:  m, u1Out: out  val_3)) & 1) == 0)
            {
                goto label_8;
            }
            
            val_7 = val_3;
            if((28563616 & 2147483648) == 0)
            {
                    return val_7;
            }
            
            val_7 = this.Add(value:  m);
            return val_7;
            label_2:
            val_9 = "Modulus must be positive";
            goto label_11;
            label_8:
            val_9 = "Numbers not relatively prime.";
            label_11:
            null = new System.ArithmeticException(message:  val_9);
        }
        private Org.BouncyCastle.Math.BigInteger ModInversePow2(Org.BouncyCastle.Math.BigInteger m)
        {
            Org.BouncyCastle.Math.BigInteger val_16;
            long val_17;
            var val_18;
            var val_19;
            val_16 = this;
            if((this.TestBit(n:  0)) != false)
            {
                    int val_3 = m.BitLength - 1;
                long val_4 = this.LongValue;
                long val_5 = val_4 << 1;
                val_5 = val_5 + 2;
                val_5 = val_5 & 8;
                var val_16 = 2;
                val_5 = val_5 + val_4;
                long val_6 = val_16 - (val_5 * val_4);
                val_5 = val_6 * val_5;
                val_6 = val_16 - (val_5 * val_4);
                val_5 = val_6 * val_5;
                val_6 = val_16 - (val_5 * val_4);
                val_5 = val_6 * val_5;
                val_16 = val_16 - (val_5 * val_4);
                val_17 = val_16 * val_5;
                if(val_3 <= 63)
            {
                    int val_7 = val_3 & 63;
                val_7 = 1 << val_7;
                val_7 = val_7 - 1;
                val_17 = val_17 & val_7;
            }
            
                val_18 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  val_17);
                if(val_3 >= 65)
            {
                    val_16 = this.Remainder(n:  m);
                do
            {
                val_19 = null;
                val_19 = null;
                val_18 = val_18.Multiply(val:  Org.BouncyCastle.Math.BigInteger.Two.Subtract(n:  val_18.Multiply(val:  val_16).Remainder(n:  m))).Remainder(n:  m);
            }
            while(0 < val_3);
            
            }
            
                if((val_14.sign & 2147483648) != 0)
            {
                    return val_18.Add(value:  m);
            }
            
                return (Org.BouncyCastle.Math.BigInteger)val_18;
            }
            
            System.ArithmeticException val_15 = new System.ArithmeticException(message:  "Numbers not relatively prime.");
        }
        private static int ModInverse32(int d)
        {
            int val_1 = d << 1;
            val_1 = val_1 + 2;
            val_1 = val_1 & 8;
            val_1 = val_1 + d;
            var val_3 = 2;
            int val_2 = val_3 - (val_1 * d);
            val_1 = val_2 * val_1;
            val_2 = val_3 - (val_1 * d);
            val_1 = val_2 * val_1;
            val_3 = val_3 - (val_1 * d);
            d = val_3 * val_1;
            return (int)d;
        }
        private static long ModInverse64(long d)
        {
            long val_1 = d << 1;
            val_1 = val_1 + 2;
            val_1 = val_1 & 8;
            val_1 = val_1 + d;
            var val_3 = 2;
            long val_2 = val_3 - (val_1 * d);
            val_1 = val_2 * val_1;
            val_2 = val_3 - (val_1 * d);
            val_1 = val_2 * val_1;
            val_2 = val_3 - (val_1 * d);
            val_1 = val_2 * val_1;
            val_3 = val_3 - (val_1 * d);
            d = val_3 * val_1;
            return (long)d;
        }
        private static Org.BouncyCastle.Math.BigInteger ExtEuclid(Org.BouncyCastle.Math.BigInteger a, Org.BouncyCastle.Math.BigInteger b, out Org.BouncyCastle.Math.BigInteger u1Out)
        {
            Org.BouncyCastle.Math.BigInteger val_4;
            var val_5;
            var val_6;
            Org.BouncyCastle.Math.BigInteger val_7;
            Org.BouncyCastle.Math.BigInteger val_8;
            var val_9;
            var val_10;
            val_4 = b;
            val_5 = a;
            val_6 = null;
            val_6 = null;
            val_7 = Org.BouncyCastle.Math.BigInteger.Zero;
            val_8 = Org.BouncyCastle.Math.BigInteger.One;
            if(b.sign >= 1)
            {
                goto label_4;
            }
            
            goto label_5;
            label_13:
            val_7 = val_8.Subtract(n:  X22.Multiply(val:  a.nBitLength));
            val_9 = X23;
            label_4:
            val_4 = val_9.DivideAndRemainder(val:  val_4)[1];
            if(val_3[1].sign >= 1)
            {
                goto label_13;
            }
            
            val_10 = val_4;
            val_8 = val_7;
            label_5:
            u1Out = val_8;
            return (Org.BouncyCastle.Math.BigInteger)val_10;
        }
        private static void ZeroOut(int[] x)
        {
            System.Array.Clear(array:  x, index:  0, length:  x.Length);
        }
        public Org.BouncyCastle.Math.BigInteger ModPow(Org.BouncyCastle.Math.BigInteger e, Org.BouncyCastle.Math.BigInteger m)
        {
            Org.BouncyCastle.Math.BigInteger val_7;
            var val_8;
            var val_9;
            Org.BouncyCastle.Math.BigInteger val_10;
            var val_11;
            var val_13;
            val_7 = e;
            if(m.sign <= 0)
            {
                goto label_2;
            }
            
            val_8 = null;
            val_8 = null;
            if((m & 1) == 0)
            {
                goto label_5;
            }
            
            label_11:
            val_9 = null;
            val_9 = null;
            val_10 = Org.BouncyCastle.Math.BigInteger.Zero;
            return (Org.BouncyCastle.Math.BigInteger)val_10;
            label_5:
            if(e.sign == 0)
            {
                goto label_10;
            }
            
            if(this.sign == 0)
            {
                goto label_11;
            }
            
            if((e.sign & 2147483648) != 0)
            {
                    val_7 = val_7.Negate();
            }
            
            val_11 = null;
            val_10 = this.Mod(m:  m);
            val_11 = null;
            if((val_7 & 1) != 0)
            {
                goto label_16;
            }
            
            var val_7 = -4294967296;
            val_7 = val_7 + ((m.magnitude.Length) << 32);
            if(((m.magnitude[val_7 >> 32]) & 1) != 0)
            {
                goto label_19;
            }
            
            Org.BouncyCastle.Math.BigInteger val_4 = Org.BouncyCastle.Math.BigInteger.ModPowBarrett(b:  val_10, e:  val_7, m:  m);
            goto label_22;
            label_10:
            val_13 = null;
            val_13 = null;
            val_10 = Org.BouncyCastle.Math.BigInteger.One;
            return (Org.BouncyCastle.Math.BigInteger)val_10;
            label_19:
            label_22:
            val_10 = Org.BouncyCastle.Math.BigInteger.ModPowMonty(b:  val_10, e:  val_7, m:  m, convert:  true);
            label_16:
            if((e.sign & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_10;
            }
            
            if(val_10 != null)
            {
                    return val_10.ModInverse(m:  m);
            }
            
            return val_10.ModInverse(m:  m);
            label_2:
            System.ArithmeticException val_6 = new System.ArithmeticException(message:  "Modulus must be positive");
        }
        private static Org.BouncyCastle.Math.BigInteger ModPowBarrett(Org.BouncyCastle.Math.BigInteger b, Org.BouncyCastle.Math.BigInteger e, Org.BouncyCastle.Math.BigInteger m)
        {
            var val_28;
            var val_29;
            Org.BouncyCastle.Math.BigInteger val_30;
            var val_31;
            Org.BouncyCastle.Math.BigInteger[] val_32;
            var val_33;
            var val_34;
            var val_35;
            val_28 = null;
            val_28 = null;
            Org.BouncyCastle.Math.BigInteger val_3 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  (m.magnitude.Length << 5) + 32);
            Org.BouncyCastle.Math.BigInteger val_6 = Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  m.magnitude.Length << 6).Divide(val:  m);
            int val_33 = 0;
            do
            {
                val_29 = null;
                val_29 = null;
                var val_8 = val_33 + 1;
                System.Int32[] val_9 = Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds + (((long)(int)((0 + 1))) << 2);
                val_33 = val_33 + 1;
            }
            while(e.BitLength > ((Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds + ((long)(int)((0 + 1))) << 2) + 32));
            
            var val_11 = 1 << (val_33 & 31);
            Org.BouncyCastle.Math.BigInteger[] val_12 = new Org.BouncyCastle.Math.BigInteger[0];
            if(val_12 == null)
            {
                goto label_14;
            }
            
            if(b != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(b == null)
            {
                goto label_18;
            }
            
            label_15:
            label_18:
            val_12[0] = b;
            val_30 = Org.BouncyCastle.Math.BigInteger.ReduceBarrett(x:  b.Square(), m:  m, mr:  val_3, yu:  val_6);
            if(val_11 >= 2)
            {
                    var val_36 = 0;
                do
            {
                var val_17 = val_36 + 1;
                Org.BouncyCastle.Math.BigInteger val_18 = Org.BouncyCastle.Math.BigInteger.ReduceBarrett(x:  val_12[val_36].Multiply(val:  val_30), m:  m, mr:  val_3, yu:  val_6);
                if(val_18 != null)
            {
                    Org.BouncyCastle.Math.BigInteger val_35 = val_12[4];
            }
            
                Org.BouncyCastle.Math.BigInteger[] val_19 = val_12 + 0;
                val_36 = val_36 + 1;
                mem2[0] = val_18;
            }
            while((val_11 - 1) != val_36);
            
            }
            
            val_31 = Org.BouncyCastle.Math.BigInteger.GetWindowList(mag:  e + 16, extraBits:  val_33);
            val_32 = val_12;
            int val_37 = val_31[0];
            int val_21 = val_37 & 255;
            val_33 = val_37 >> 8;
            if(val_21 == 1)
            {
                    val_33 = val_33 - 1;
            }
            else
            {
                    int val_22 = val_21 >> 1;
                Org.BouncyCastle.Math.BigInteger[] val_23 = val_32 + ((((val_20[0] & 255) >> 1)) << 3);
                val_30 = mem[(val_12 + (((val_20[0] & 255) >> 1)) << 3) + 32];
                val_30 = (val_12 + (((val_20[0] & 255) >> 1)) << 3) + 32;
            }
            
            val_34 = 1;
            goto label_55;
            label_60:
            System.Int32[] val_24 = val_31 & 255;
            val_35 = null;
            val_35 = null;
            System.Byte[] val_25 = Org.BouncyCastle.Math.BigInteger.BitLengthTable + val_24;
            val_33 = val_33 + ((Org.BouncyCastle.Math.BigInteger.BitLengthTable + (val_20 & 255)) + 32);
            if(val_33 < 1)
            {
                goto label_45;
            }
            
            val_32 = val_12;
            do
            {
                val_33 = val_33 - 1;
            }
            while(val_33 != 0);
            
            label_57:
            val_24 = val_24 >> 1;
            Org.BouncyCastle.Math.BigInteger[] val_28 = val_32 + ((((val_20 & 255) >> 1)) << 3);
            val_34 = 2;
            val_30 = Org.BouncyCastle.Math.BigInteger.ReduceBarrett(x:  Org.BouncyCastle.Math.BigInteger.ReduceBarrett(x:  val_30.Square(), m:  m, mr:  val_3, yu:  val_6).Multiply(val:  (val_12 + (((val_20 & 255) >> 1)) << 3) + 32), m:  m, mr:  val_3, yu:  val_6);
            val_33 = val_31 >> 8;
            val_31 = X27;
            goto label_55;
            label_45:
            if(val_12 != 0)
            {
                goto label_57;
            }
            
            goto label_57;
            label_55:
            if(val_31[4] != 1)
            {
                goto label_60;
            }
            
            if(val_33 < 1)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_30;
            }
            
            do
            {
                val_33 = val_33 - 1;
                val_30 = Org.BouncyCastle.Math.BigInteger.ReduceBarrett(x:  val_30.Square(), m:  m, mr:  val_3, yu:  val_6);
            }
            while(val_33 != 0);
            
            return (Org.BouncyCastle.Math.BigInteger)val_30;
        }
        private static Org.BouncyCastle.Math.BigInteger ReduceBarrett(Org.BouncyCastle.Math.BigInteger x, Org.BouncyCastle.Math.BigInteger m, Org.BouncyCastle.Math.BigInteger mr, Org.BouncyCastle.Math.BigInteger yu)
        {
            var val_16;
            var val_17;
            val_16 = x;
            val_17 = val_16.BitLength;
            if()
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_16;
            }
            
            if((val_17 - m.BitLength) < 2)
            {
                goto label_14;
            }
            
            int val_7 = m.magnitude.Length + 1;
            val_17 = val_16.DivideWords(w:  m.magnitude.Length - 1).Multiply(val:  yu).DivideWords(w:  val_7).Multiply(val:  m);
            val_16 = val_16.RemainderWords(w:  val_7).Subtract(n:  val_17.RemainderWords(w:  val_7));
            if((val_12.sign & 2147483648) == 0)
            {
                goto label_14;
            }
            
            Org.BouncyCastle.Math.BigInteger val_13 = val_16.Add(value:  mr);
            goto label_15;
            label_18:
            label_15:
            val_16 = val_16.Subtract(n:  m);
            label_14:
            if(((val_16.CompareTo(value:  m)) & 2147483648) == 0)
            {
                goto label_18;
            }
            
            return (Org.BouncyCastle.Math.BigInteger)val_16;
        }
        private static Org.BouncyCastle.Math.BigInteger ModPowMonty(Org.BouncyCastle.Math.BigInteger b, Org.BouncyCastle.Math.BigInteger e, Org.BouncyCastle.Math.BigInteger m, bool convert)
        {
            var val_26;
            System.Int32[] val_27;
            int val_28;
            var val_29;
            System.Int32[] val_30;
            var val_31;
            System.Int32[] val_32;
            System.Int32[] val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_26 = b;
            int val_1 = m.magnitude.Length << 5;
            int val_3 = m.BitLength + 2;
            bool val_4 = (val_3 <= (m.magnitude.Length << 5)) ? 1 : 0;
            int val_5 = m.GetMQuote();
            if(convert != false)
            {
                    val_26 = val_26.ShiftLeft(n:  val_1).Remainder(n:  m);
            }
            
            int val_8 = m.magnitude.Length + 1;
            int[] val_9 = new int[0];
            val_27 = val_7.magnitude;
            if(val_7.magnitude.Length < m.magnitude.Length)
            {
                    int val_10 = m.magnitude.Length & 4294967295;
                int[] val_11 = new int[0];
                val_27.CopyTo(array:  val_11, index:  m.magnitude.Length - val_7.magnitude.Length);
                val_27 = val_11;
            }
            
            if(((e + 16 + 24) <= 1) && (e.BitCount < 3))
            {
                    val_28 = 0;
            }
            else
            {
                    do
            {
                val_29 = null;
                val_29 = null;
                var val_15 = 0 + 1;
                System.Int32[] val_16 = Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds + (((long)(int)((0 + 1))) << 2);
                val_28 = 0 + 1;
            }
            while(e.BitLength > ((Org.BouncyCastle.Math.BigInteger.ExpWindowThresholds + ((long)(int)((0 + 1))) << 2) + 32));
            
            }
            
            var val_18 = 1 << (val_28 & 31);
            System.Int32[][] val_19 = new System.Int32[][0];
            if(val_27 != null)
            {
                    System.Int32[] val_37 = val_19[4];
            }
            
            mem[1152921543951040560] = val_27;
            val_30 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_11);
            val_31 = 1152921505512914944;
            Org.BouncyCastle.Math.BigInteger.SquareMonty(a:  val_9, x:  val_30, m:  m.magnitude, mDash:  val_5, smallMontyModulus:  val_4);
            if(val_18 >= 2)
            {
                    var val_39 = 0;
                do
            {
                System.Int32[][] val_22 = val_19 + 0;
                val_32 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  (val_19 + 0) + 32);
                if(val_32 != null)
            {
                    System.Int32[] val_38 = val_19[4];
            }
            
                System.Int32[][] val_25 = val_19 + 0;
                mem2[0] = val_32;
                if((val_39 + 1) >= mem[1152921543951040552])
            {
                    val_32 = mem[(val_19 + 0) + 40];
                val_32 = (val_19 + 0) + 40;
            }
            
                val_31 = 1152921505512914944;
                Org.BouncyCastle.Math.BigInteger.MultiplyMonty(a:  val_9, x:  val_32, y:  val_30, m:  m.magnitude, mDash:  val_5, smallMontyModulus:  val_4);
                val_28 = val_28;
                val_39 = val_39 + 1;
            }
            while((val_18 - 1) != val_39);
            
            }
            
            System.Int32[] val_41 = e + 16;
            val_33 = Org.BouncyCastle.Math.BigInteger.GetWindowList(mag:  val_41, extraBits:  val_28);
            int val_40 = val_33[0];
            int val_27 = val_40 & 255;
            val_34 = val_40 >> 8;
            if(val_27 == 1)
            {
                    val_34 = val_34 - 1;
            }
            else
            {
                    val_41 = val_27 >> 1;
                System.Int32[][] val_42 = val_19;
                val_42 = val_42 + ((((val_26[0] & 255) >> 1)) << 3);
                val_30 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  (val_19 + (((val_26[0] & 255) >> 1)) << 3) + 32);
            }
            
            val_35 = 1;
            goto label_43;
            label_58:
            val_36 = null;
            var val_29 = val_39 & 255;
            val_36 = null;
            System.Byte[] val_30 = Org.BouncyCastle.Math.BigInteger.BitLengthTable + val_29;
            val_34 = val_34 + ((Org.BouncyCastle.Math.BigInteger.BitLengthTable + ((0 + 1) & 255)) + 32);
            if(val_34 >= 1)
            {
                    do
            {
                Org.BouncyCastle.Math.BigInteger.SquareMonty(a:  val_9, x:  val_30, m:  m.magnitude, mDash:  val_5, smallMontyModulus:  val_4);
                val_34 = val_34 - 1;
            }
            while(val_34 != 0);
            
            }
            
            var val_31 = val_29 >> 1;
            System.Int32[][] val_32 = val_19 + (((((0 + 1) & 255) >> 1)) << 3);
            val_35 = val_28 + 1;
            Org.BouncyCastle.Math.BigInteger.MultiplyMonty(a:  val_9, x:  val_30, y:  (val_19 + ((((0 + 1) & 255) >> 1)) << 3) + 32, m:  m.magnitude, mDash:  val_5, smallMontyModulus:  val_4);
            val_33 = val_33;
            val_34 = val_39 >> 8;
            label_43:
            System.Int32[] val_33 = val_33 + (((long)(int)(((0 + 1) + 1))) << 2);
            if(((val_26 + ((long)(int)(((0 + 1) + 1))) << 2) + 32) != 1)
            {
                goto label_58;
            }
            
            if(val_34 >= 1)
            {
                    do
            {
                Org.BouncyCastle.Math.BigInteger.SquareMonty(a:  val_9, x:  val_30, m:  m.magnitude, mDash:  val_5, smallMontyModulus:  val_4);
                val_34 = val_34 - 1;
            }
            while(val_34 != 0);
            
            }
            
            if(convert != false)
            {
                    Org.BouncyCastle.Math.BigInteger.MontgomeryReduce(x:  val_30, m:  m.magnitude, mDash:  val_5);
                return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_30, checkMag:  true);
            }
            
            if(val_3 > val_1)
            {
                    return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_30, checkMag:  true);
            }
            
            if(((Org.BouncyCastle.Math.BigInteger.CompareTo(xIndx:  0, x:  val_30, yIndx:  0, y:  m.magnitude)) & 2147483648) != 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_30, checkMag:  true);
            }
            
            val_37 = null;
            System.Int32[] val_35 = Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  val_30, yStart:  0, y:  m.magnitude);
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_30, checkMag:  true);
        }
        private static int[] GetWindowList(int[] mag, int extraBits)
        {
            var val_9;
            int val_10;
            var val_11;
            var val_12;
            int val_13;
            int val_9 = mag[0];
            int val_1 = Org.BouncyCastle.Math.BigInteger.BitLen(w:  val_9);
            int val_10 = mag.Length;
            val_10 = val_1 + (val_10 << 5);
            val_10 = val_10 - 32;
            val_10 = val_10 / (extraBits + 1);
            int val_3 = val_10 + 2;
            int[] val_4 = new int[0];
            val_9 = 33 - val_1;
            val_10 = 1;
            var val_12 = 0;
            val_11 = 0;
            val_12 = 0;
            val_13 = val_9 << (val_9 & 31);
            goto label_5;
            label_23:
            val_13 = mag[0];
            val_9 = 0;
            label_5:
            if(val_9 <= 31)
            {
                goto label_21;
            }
            
            val_12 = val_12 + 1;
            if(val_12 != mag.Length)
            {
                goto label_23;
            }
            
            if((val_10 & 1) == 0)
            {
                    do
            {
                val_10 = 0;
                val_11 = val_11 + 1;
            }
            while((val_10 & 1) == 0);
            
            }
            
            var val_8 = val_12 + 1;
            val_10 = val_10 | (val_11 << 8);
            val_4[4] = val_10;
            val_4[((long)(int)((val_12 + 1))) << 2] = 0;
            return (System.Int32[])val_4;
        }
        private static int CreateWindowEntry(int mult, int zeroes)
        {
            if((mult & 1) == 0)
            {
                    do
            {
                mult = mult >> 1;
                zeroes = zeroes + 1;
            }
            while((mult & 1) == 0);
            
            }
            
            mult = mult | (zeroes << 8);
            return (int)mult;
        }
        private static int[] Square(int[] w, int[] x)
        {
            var val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            var val_24;
            int val_25;
            int val_26;
            var val_27;
            int val_28;
            val_18 = w.Length - 1;
            val_19 = x.Length;
            int val_1 = val_19 - 1;
            if(val_1 >= 1)
            {
                    int val_3 = 1 - val_19;
                do
            {
                val_20 = val_1;
                val_21 = w.Length;
                int val_15 = x[((long)(int)((x.Length - 1))) << 2];
                if(val_18 >= val_21)
            {
                    val_21 = w.Length;
            }
            
                var val_19 = (long)val_19 - 2;
                int val_4 = (w[((long)(int)((w.Length - 1))) << 2]) + (val_15 * val_15);
                val_22 = val_4 >> 32;
                mem2[0] = val_4;
                if(((val_19 - 2) & 2147483648) == 0)
            {
                    int val_6 = val_18 - 1;
                do
            {
                val_23 = w.Length;
                if(val_6 >= val_23)
            {
                    val_23 = w.Length;
            }
            
                val_22 = (X10 + val_22) + (w[((long)(int)(((w.Length - 1) - 1))) << 2]);
                mem2[0] = val_22;
                val_19 = val_19 - 1;
                val_22 = (val_22 >> 32) + (((x[((long)(int)((x.Length - 2))) << 2]) * val_15) >> 31);
                val_6 = val_6 - 1;
            }
            while((val_19 & 2147483648) == 0);
            
                val_20 = val_20;
                val_24 = val_18 + val_3;
            }
            
                val_25 = w.Length;
                if((val_24 - 1) >= val_25)
            {
                    val_25 = w.Length;
            }
            
                val_26 = val_22 + (w[((long)(int)((((w.Length - 1) + (1 - x.Length)) - 1))) << 2]);
                mem2[0] = val_26;
                var val_21 = val_19;
                val_24 = val_24 - 2;
                if((val_24 & 2147483648) == 0)
            {
                    val_26 = val_26 >> 32;
                w[((long)(int)((((w.Length - 1) + (1 - x.Length)) - 2))) << 2] = val_26;
            }
            
                val_27 = val_24 + (long)val_20;
                val_21 = val_21 - 1;
                val_3 = val_3 + 1;
                val_19 = val_20;
            }
            while(((long)val_20 - 1) > 0);
            
            }
            
            val_28 = w.Length;
            int val_22 = x[0];
            if(val_27 >= val_28)
            {
                    val_28 = w.Length;
            }
            
            val_22 = (w[((long)(int)(((((w.Length - 1) + (1 - x.Length)) - 2) + (long)(int)((x.Length - 1))))) << 2]) + (val_22 * val_22);
            int val_12 = val_27 - 1;
            mem2[0] = val_22;
            if((val_12 >> 31) != 0)
            {
                    return (System.Int32[])w;
            }
            
            val_27 = (long)val_12;
            int val_24 = w[((long)(int)((((((w.Length - 1) + (1 - x.Length)) - 2) + (long)(int)((x.Length - 1))) - 1))) << 2];
            val_24 = val_24 + (val_22 >> 32);
            w[((long)(int)((((((w.Length - 1) + (1 - x.Length)) - 2) + (long)(int)((x.Length - 1))) - 1))) << 2] = val_24;
            return (System.Int32[])w;
        }
        private static int[] Multiply(int[] x, int[] y, int[] z)
        {
            int val_7;
            int val_8;
            int val_9;
            var val_10;
            var val_11;
            int val_12;
            int val_13;
            if(z.Length < 1)
            {
                    return (System.Int32[])x;
            }
            
            if(x == null)
            {
                goto label_2;
            }
            
            label_21:
            int val_1 = x.Length - y.Length;
            label_19:
            val_7 = z.Length - 1;
            val_8 = (long)val_7;
            int val_4 = z[((long)(int)((z.Length - 1))) << 2];
            if(val_4 == 0)
            {
                goto label_8;
            }
            
            int val_6 = y.Length;
            int val_2 = val_6 - 1;
            if((val_2 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            val_9 = val_6 & 4294967295;
            val_10 = (long)val_2;
            val_11 = val_6 - 2;
            goto label_9;
            label_14:
            val_9 = y.Length;
            val_10 = val_10 - 1;
            val_11 = val_11 - 1;
            label_9:
            val_12 = x.Length;
            val_6 = val_1 + val_11;
            val_6 = val_6 + 1;
            if(val_6 >= val_12)
            {
                    val_12 = x.Length;
            }
            
            val_8 = (0 + ((y[(((long)(int)((y.Length - 1)) - 1)) << 2]) * val_4)) + (x[((long)(int)((((x.Length - y.Length) + ((y.Length - 2) - 1)) + 1))) << 2]);
            val_13 = val_8 >> 32;
            mem2[0] = val_8;
            if((val_11 & 2147483648) == 0)
            {
                goto label_14;
            }
            
            val_7 = val_7;
            goto label_15;
            label_8:
            val_13 = 0;
            label_15:
            val_1 = val_1 - 1;
            if((val_1 & 2147483648) == 0)
            {
                    val_8 = (long)val_1;
                x[((long)(int)(((x.Length - y.Length) - 1))) << 2] = val_13;
            }
            
            if(val_7 > 0)
            {
                goto label_19;
            }
            
            return (System.Int32[])x;
            label_2:
            if(y != null)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        private int GetMQuote()
        {
            int val_4 = this.mQuote;
            if(val_4 != 0)
            {
                    return val_4;
            }
            
            var val_3 = -4294967296;
            val_3 = val_3 + ((this.magnitude.Length) << 32);
            int val_4 = this.magnitude[val_3 >> 32];
            var val_5 = 2;
            val_5 = val_5 - (val_4 << 1);
            val_5 = val_5 & 8;
            val_5 = val_5 - val_4;
            var val_6 = 2;
            int val_2 = val_6 + (val_5 * val_4);
            val_5 = val_2 * val_5;
            val_2 = val_6 + (val_5 * val_4);
            val_5 = val_2 * val_5;
            val_6 = val_6 + (val_5 * val_4);
            val_4 = val_6 * val_5;
            this.mQuote = val_4;
            return val_4;
        }
        private static void MontgomeryReduce(int[] x, int[] m, uint mDash)
        {
            int val_8;
            System.Int32[] val_9;
            int val_10;
            int val_11;
            var val_12;
            val_9 = m;
            int val_7 = m.Length;
            int val_1 = val_7 - 1;
            if((val_1 & 2147483648) == 0)
            {
                    val_7 = val_7 - 2;
                val_7 = val_7 + 32;
                System.Int32[] val_10 = val_9[val_7];
                do
            {
                val_8 = mem[x[((m.Length - 1)) << 2][0x20]];
                val_8 = x[val_1 << 2][32];
                System.Int32[] val_2 = val_8 * mDash;
                var val_11 = val_9[val_1 << 2][32];
                val_11 = val_8 + (val_11 * val_2);
                val_10 = val_11 >> 32;
                if(((long)val_7 & 2147483648) == 0)
            {
                    var val_12 = 0;
                do
            {
                val_11 = x.Length;
                if(((long)val_7 + val_12) >= val_11)
            {
                    val_11 = x.Length;
            }
            
                val_9[val_1 << 2] = val_10 + ((m[((m.Length - 2) + 32)] + 0) * val_2);
                int val_4 = val_1 + val_12;
                val_8 = (val_9[val_1 << 2]) + 1152921505725111792;
                x[((long)(int)(((m.Length - 1) + 0))) << 2] = val_8;
                int val_13 = val_7;
                val_12 = val_12 - 1;
                val_10 = val_8 >> 32;
                val_9 = val_9;
                val_13 = val_13 + val_12;
            }
            while((val_13 & 2147483648) == 0);
            
            }
            
                int val_14 = val_1;
                x[0] = val_10;
                val_14 = val_14 - 1;
            }
            while((val_14 & 2147483648) == 0);
            
            }
            
            if(((Org.BouncyCastle.Math.BigInteger.CompareTo(xIndx:  0, x:  x, yIndx:  0, y:  val_9)) & 2147483648) != 0)
            {
                    return;
            }
            
            val_12 = null;
            System.Int32[] val_6 = Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  x, yStart:  0, y:  val_9);
        }
        private static void MultiplyMonty(int[] a, int[] x, int[] y, int[] m, uint mDash, bool smallMontyModulus)
        {
            System.Int32[] val_34;
            System.Int32[] val_35;
            var val_36;
            int val_37;
            System.Int32[] val_38;
            int val_39;
            int val_40;
            int val_41;
            var val_42;
            val_34 = m;
            val_35 = y;
            int val_37 = m.Length;
            int val_1 = val_37 - 1;
            if()
            {
                    int val_30 = x[0];
                int val_32 = val_34[0];
                uint val_33 = mDash;
                int val_2 = val_35[0] * val_30;
                val_33 = val_2 * val_33;
                val_33 = val_32 * val_33;
                val_2 = val_2 + val_33;
                val_2 = val_2 >> 32;
                val_2 = val_2 + (val_33 >> 32);
                val_30 = val_2 - ((val_2 > val_32) ? (val_32) : 0);
                x[0] = val_30;
                return;
            }
            
            int val_34 = val_35[((long)(int)((m.Length - 1))) << 2];
            int val_35 = x[((long)(int)((m.Length - 1))) << 2];
            val_36 = val_35 * val_34;
            int val_4 = val_36 * mDash;
            int val_36 = val_34[((long)(int)((m.Length - 1))) << 2];
            int val_5 = val_37 - 2;
            val_36 = val_36 * val_4;
            int val_6 = val_36 + val_36;
            val_6 = val_6 >> 32;
            val_37 = val_6 + (val_36 >> 32);
            if((val_5 & 2147483648) == 0)
            {
                    var val_7 = (long)val_5 + 8;
                do
            {
                val_37 = val_7 - 8;
                val_36 = val_35;
                System.Int32[] val_8 = 1152921505725111792 * val_35;
                val_35 = 1152921505725111792 * val_4;
                val_37 = (val_37 + val_8) + val_35;
                a[((long)(int)(m.Length)) << 2] = val_37;
                val_34 = val_34;
                int val_11 = val_37 - 1;
                val_37 = ((val_35 >> 32) + (val_8 >> 32)) + (val_37 >> 32);
                val_7 = val_7 - 1;
                val_35 = val_36;
            }
            while(((val_37 - 3) & 2147483648) == 0);
            
            }
            
            a[0] = val_37;
            val_38 = x;
            val_39 = val_37;
            int val_38 = val_5;
            val_40 = val_37 >> 32;
            if((val_38 & 2147483648) == 0)
            {
                    val_38 = val_38 + 32;
                System.Int32[] val_40 = val_35[val_38];
                val_35 = val_39 - 1;
                System.Int32[] val_41 = val_34[val_38];
                val_36 = (long)val_38;
                do
            {
                int val_42 = a[(val_39 << 32) >> 30][32];
                System.Int32[] val_16 = val_38 + (((long)(int)((m.Length - 2))) << 2);
                val_37 = mem[(x + ((long)(int)((m.Length - 2))) << 2) + 32];
                val_37 = (x + ((long)(int)((m.Length - 2))) << 2) + 32;
                int val_17 = val_37 * val_34;
                System.Int32[] val_18 = val_42 + val_17;
                val_42 = val_18 * mDash;
                var val_46 = 0;
                var val_43 = m[((long)(int)((m.Length - 1))) << 2] + 32;
                val_43 = val_43 * val_42;
                System.Int32[] val_19 = val_43 >> 32;
                val_19 = val_19 + (val_17 >> 32);
                val_43 = val_18 + val_43;
                val_17 = val_19 + (val_43 >> 32);
                do
            {
                var val_20 = val_36 + val_46;
                var val_21 = (y[((m.Length - 2) + 32)] + 0) * val_37;
                int val_22 = val_35 + val_46;
                val_41 = a.Length;
                System.Int32[] val_24 = (m[((m.Length - 2) + 32)] + 0) * val_42;
                if((val_35 + val_46) >= val_41)
            {
                    val_41 = a.Length;
            }
            
                int val_45 = val_37;
                System.Int32[] val_25 = val_17 + val_21;
                val_25 = val_25 + val_24;
                val_45 = val_45 + val_46;
                val_17 = val_25 + (a[((long)(int)(((m.Length - 1) + 0))) << 2]);
                a[((long)(int)((m.Length + 0))) << 2] = val_17;
                int val_47 = val_39 - 2;
                val_34 = val_34;
                val_46 = val_46 - 1;
                val_17 = ((val_24 >> 32) + (val_21 >> 32)) + (val_17 >> 32);
                val_47 = val_47 + val_46;
            }
            while((val_47 & 2147483648) == 0);
            
                val_42 = val_17 + val_40;
                a[0] = val_42;
                var val_48 = (long)val_38;
                val_40 = val_42 >> 32;
                val_38 = x;
                val_39 = val_37;
                val_48 = val_48 - 1;
            }
            while((val_48 & 2147483648) == 0);
            
            }
            
            a[0] = val_40;
            if(smallMontyModulus != true)
            {
                    val_36 = 1152921505512914944;
                if(((Org.BouncyCastle.Math.BigInteger.CompareTo(xIndx:  0, x:  a, yIndx:  0, y:  val_34)) & 2147483648) == 0)
            {
                    val_42 = null;
                System.Int32[] val_29 = Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  a, yStart:  0, y:  val_34);
            }
            
            }
            
            System.Array.Copy(sourceArray:  a, sourceIndex:  1, destinationArray:  val_38, destinationIndex:  0, length:  val_39);
        }
        private static void SquareMonty(int[] a, int[] x, int[] m, uint mDash, bool smallMontyModulus)
        {
            System.Int32[] val_48;
            int val_49;
            int val_50;
            int val_51;
            var val_52;
            System.Int32[] val_53;
            int val_54;
            int val_55;
            System.Int32[] val_56;
            int val_57;
            int val_58;
            int val_59;
            System.Int32[] val_60;
            var val_61;
            val_48 = x;
            val_49 = m.Length;
            int val_1 = val_49 - 1;
            if()
            {
                    int val_44 = val_48[0];
                int val_45 = m[0];
                uint val_46 = mDash;
                int val_2 = val_44 * val_44;
                val_46 = val_2 * val_46;
                val_46 = val_45 * val_46;
                val_2 = val_2 + val_46;
                val_2 = val_2 >> 32;
                val_2 = val_2 + (val_46 >> 32);
                val_44 = val_2 - ((val_2 > val_45) ? (val_45) : 0);
                mem2[0] = val_44;
                return;
            }
            
            int val_47 = val_48[((long)(int)((m.Length - 1))) << 2];
            int val_4 = val_47 * val_47;
            int val_5 = val_4 * mDash;
            System.Int32[] val_6 = m + (((long)(int)((m.Length - 1))) << 2);
            var val_48 = (m + ((long)(int)((m.Length - 1))) << 2) + 32;
            val_48 = val_48 * val_5;
            int val_7 = val_4 + val_48;
            val_7 = val_7 >> 32;
            val_50 = val_49 - 2;
            val_51 = val_7 + (val_48 >> 32);
            if((val_50 & 2147483648) == 0)
            {
                    val_49 = (long)val_50 + 8;
                do
            {
                var val_8 = val_49 - 8;
                val_52 = 1152921505725111792 * val_47;
                int val_9 = (m + (((long)(int)((m.Length - 2)) + 8)) << 2) * val_5;
                val_51 = (1152921505725111792 + val_51) + val_9;
                a[((long)(int)(m.Length)) << 2] = val_51;
                val_48 = val_48;
                int val_12 = val_49 - 1;
                val_51 = ((val_9 >> 32) + (val_52 >> 31)) + (val_51 >> 32);
                val_49 = val_49 - 1;
            }
            while(((val_49 - 3) & 2147483648) == 0);
            
                val_53 = m;
                val_49 = val_49;
            }
            else
            {
                    if(a != null)
            {
                
            }
            
                val_53 = m;
            }
            
            val_54 = val_51 >> 32;
            a[0] = val_51;
            if((val_50 & 2147483648) == 0)
            {
                    System.Int32[] val_15 = val_53 + (val_50 << 2);
                val_15 = val_15 + 32;
                var val_17 = (-12884901888) + ((m.Length) << 32);
                System.Int32[] val_49 = a[(val_49 << 32) >> 30][32];
                var val_19 = val_17 >> 32;
                do
            {
                System.Int32[] val_21 = val_49 * mDash;
                var val_51 = (m + ((long)(int)((m.Length - 1))) << 2) + 32;
                val_51 = val_49 + (val_51 * val_21);
                val_52 = val_51 >> 32;
                if((long)val_50 < (long)val_50)
            {
                    System.Int32[] val_53 = val_15;
                do
            {
                int val_22 = val_49 - 2;
                val_55 = a.Length;
                if((val_49 - 1) >= val_55)
            {
                    val_55 = a.Length;
            }
            
                System.Int32[] val_24 = val_52 + (val_53 * val_21);
                System.Int32[] val_25 = val_24 + (a[((long)(int)((m.Length - 1))) << 2]);
                a[((long)(int)(m.Length)) << 2] = val_25;
                val_56 = m;
                val_52 = val_25 >> 32;
                val_53 = val_53 - 4;
            }
            while((long)val_50 < ((val_49 - 3) << ));
            
            }
            
                System.Int32[] val_27 = val_48 + (((long)(int)((m.Length - 2))) << 2);
                System.Int32[] val_28 = val_56 + (((long)(int)((m.Length - 2))) << 2);
                var val_29 = ((x + ((long)(int)((m.Length - 2))) << 2) + 32) * ((x + ((long)(int)((m.Length - 2))) << 2) + 32);
                System.Int32[] val_30 = ((m + ((long)(int)((m.Length - 2))) << 2) + 32) * val_21;
                val_57 = a.Length;
                if(((long)val_50 + 1) >= val_57)
            {
                    val_57 = a.Length;
            }
            
                int val_54 = a[((long)(int)(((long)(int)((m.Length - 2)) + 1))) << 2];
                val_24 = val_52 + val_29;
                var val_32 = (long)val_50 + 2;
                val_24 = val_24 + val_30;
                System.Int32[] val_33 = val_24 + val_54;
                val_54 = val_33 >> 32;
                a[((long)(int)(((long)(int)((m.Length - 2)) + 2))) << 2] = val_33;
                var val_35 = (long)val_50 - 1;
                val_58 = (val_54 + (val_29 >> 32)) + (val_30 >> 32);
                if((val_35 & 2147483648) == 0)
            {
                    do
            {
                var val_36 = val_19 + 0;
                System.Int32[] val_55 = val_48[val_17 >> 30];
                val_55 = val_55 + 0;
                var val_57 = (x[((ulong)(-12884901888 + (m.Length) << 32)) >> 30] + 0) + 32;
                System.Int32[] val_56 = val_53 + (val_17 >> 30);
                val_56 = val_56 + 0;
                System.Int32[] val_37 = (((m + ((ulong)(-12884901888 + (m.Length) << 32)) >> 30) + 0) + 32) * val_21;
                val_59 = a.Length;
                val_57 = val_57 * ((x + ((long)(int)((m.Length - 2))) << 2) + 32);
                if((long)val_50 >= val_59)
            {
                    val_59 = a.Length;
            }
            
                int val_58 = a[((long)(int)((long)(int)((m.Length - 2)))) << 2];
                var val_38 = (long)val_50 + 1;
                val_24 = val_24 + val_58;
                val_58 = (val_24 + val_37) + val_58;
                val_58 = val_58 >> 32;
                a[((long)(int)(((long)(int)((m.Length - 2)) + 1))) << 2] = val_58;
                int val_59 = val_49 - 3;
                val_48 = val_48;
                var val_41 = val_19 + 0;
                val_52 = 0 - 1;
                val_59 = val_59 + val_52;
                val_58 = (val_58 + (val_57 >> 31)) + (val_37 >> 32);
            }
            while((val_59 & 2147483648) == 0);
            
            }
            else
            {
                    val_48 = val_48;
            }
            
                val_50 = val_58 + val_54;
                a[0] = val_50;
                val_49 = val_49;
                val_54 = val_50 >> 32;
                val_60 = m;
            }
            while((val_35 & 2147483648) == 0);
            
            }
            
            a[0] = val_54;
            if(smallMontyModulus != true)
            {
                    val_50 = 1152921505512914944;
                if(((Org.BouncyCastle.Math.BigInteger.CompareTo(xIndx:  0, x:  a, yIndx:  0, y:  val_60)) & 2147483648) == 0)
            {
                    val_61 = null;
                System.Int32[] val_43 = Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  a, yStart:  0, y:  val_60);
            }
            
            }
            
            System.Array.Copy(sourceArray:  a, sourceIndex:  1, destinationArray:  val_48, destinationIndex:  0, length:  val_49);
        }
        private static uint MultiplyMontyNIsOne(uint x, uint y, uint m, uint mDash)
        {
            uint val_1 = W8 * mDash;
            uint val_2 = val_1 & 4294967295;
            val_2 = val_2 + (y ?? x);
            val_2 = val_2 >> 32;
            val_1 = val_2 + (val_1 >> 32);
            x = val_1 - ((val_1 > m) ? m : 0);
            return (uint)x;
        }
        public Org.BouncyCastle.Math.BigInteger Multiply(Org.BouncyCastle.Math.BigInteger val)
        {
            int val_13;
            int val_15;
            Org.BouncyCastle.Math.BigInteger val_16;
            var val_17;
            if(val == this)
            {
                    return val.Square();
            }
            
            val_13 = this.sign;
            if((val.sign & val_13) == 0)
            {
                goto label_3;
            }
            
            if((val.sign < 1) || (val.nBits != 1))
            {
                goto label_5;
            }
            
            val = val.BitLength - 1;
            Org.BouncyCastle.Math.BigInteger val_3 = this.ShiftLeft(n:  val);
            val_15 = val.sign;
            goto label_6;
            label_5:
            if((this.sign < 1) || (this.nBits != 1))
            {
                goto label_8;
            }
            
            val_15 = this.sign;
            label_6:
            val_16 = val.ShiftLeft(n:  this.BitLength - 1);
            if(val_15 > 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_16;
            }
            
            if(val_16 != null)
            {
                    return val_16.Negate();
            }
            
            return val_16.Negate();
            label_3:
            val_17 = null;
            val_17 = null;
            val_16 = Org.BouncyCastle.Math.BigInteger.Zero;
            return (Org.BouncyCastle.Math.BigInteger)val_16;
            label_8:
            int val_7 = val.magnitude.Length + this.magnitude.Length;
            int[] val_8 = new int[0];
            val_13 = val_8;
            System.Int32[] val_9 = Org.BouncyCastle.Math.BigInteger.Multiply(x:  val_8, y:  this.magnitude, z:  val.magnitude);
            Org.BouncyCastle.Math.BigInteger val_12 = null;
            val_16 = val_12;
            val_12 = new Org.BouncyCastle.Math.BigInteger(signum:  this.sign ^ val.sign ^ 1, mag:  val_8, checkMag:  true);
            return (Org.BouncyCastle.Math.BigInteger)val_16;
        }
        public Org.BouncyCastle.Math.BigInteger Square()
        {
            System.Int32[] val_10;
            var val_11;
            System.Int32[] val_12;
            var val_13;
            Org.BouncyCastle.Math.BigInteger val_14;
            if(this.sign == 0)
            {
                goto label_1;
            }
            
            if((this.sign >= 1) && (this.nBits == 1))
            {
                    return this.ShiftLeft(n:  this.BitLength - 1);
            }
            
            val_10 = this.magnitude;
            if(val_10 == null)
            {
                goto label_4;
            }
            
            val_11 = this.magnitude.Length << 1;
            goto label_10;
            label_1:
            val_12 = 1152921505512914944;
            val_13 = null;
            val_13 = null;
            val_14 = Org.BouncyCastle.Math.BigInteger.Zero;
            return (Org.BouncyCastle.Math.BigInteger)val_14;
            label_4:
            val_11 = this.magnitude.Length << 1;
            if(this.magnitude != null)
            {
                    val_10 = this.magnitude;
            }
            else
            {
                    val_10 = 0;
            }
            
            label_10:
            int val_4 = val_11 - ((64 < 65536) ? 1 : 0);
            int[] val_5 = new int[0];
            val_12 = val_5;
            System.Int32[] val_6 = Org.BouncyCastle.Math.BigInteger.Square(w:  val_5, x:  this.magnitude);
            Org.BouncyCastle.Math.BigInteger val_7 = null;
            val_14 = val_7;
            val_7 = new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_5, checkMag:  false);
            return (Org.BouncyCastle.Math.BigInteger)val_14;
        }
        public Org.BouncyCastle.Math.BigInteger Negate()
        {
            if(this.sign == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)this;
            }
            
            Org.BouncyCastle.Math.BigInteger val_1 = null;
            this = val_1;
            val_1 = new Org.BouncyCastle.Math.BigInteger(signum:  -this.sign, mag:  this.magnitude, checkMag:  false);
            return (Org.BouncyCastle.Math.BigInteger)this;
        }
        public Org.BouncyCastle.Math.BigInteger NextProbablePrime()
        {
            var val_7;
            var val_9;
            Org.BouncyCastle.Math.BigInteger val_10;
            var val_11;
            var val_12;
            if((this.sign & 2147483648) != 0)
            {
                goto label_1;
            }
            
            val_7 = null;
            val_7 = null;
            if(((this.CompareTo(value:  Org.BouncyCastle.Math.BigInteger.Two)) & 2147483648) != 0)
            {
                goto label_4;
            }
            
            Org.BouncyCastle.Math.BigInteger val_2 = this.Inc();
            Org.BouncyCastle.Math.BigInteger val_3 = val_2.SetBit(n:  0);
            goto label_6;
            label_13:
            val_9 = null;
            val_9 = null;
            label_6:
            val_10 = val_2.Add(value:  Org.BouncyCastle.Math.BigInteger.Two);
            val_11 = null;
            val_11 = null;
            if((val_10.CheckProbablePrime(certainty:  100, random:  Org.BouncyCastle.Math.BigInteger.RandomSource, randomlySelected:  false)) == false)
            {
                goto label_13;
            }
            
            return val_10;
            label_4:
            val_12 = null;
            val_12 = null;
            val_10 = Org.BouncyCastle.Math.BigInteger.Two;
            return val_10;
            label_1:
            System.ArithmeticException val_6 = new System.ArithmeticException(message:  "Cannot be called on value < 0");
        }
        public Org.BouncyCastle.Math.BigInteger Not()
        {
            Org.BouncyCastle.Math.BigInteger val_1 = this.Inc();
            if(val_1 != null)
            {
                    return val_1.Negate();
            }
            
            return val_1.Negate();
        }
        public Org.BouncyCastle.Math.BigInteger Pow(int exp)
        {
            int val_6;
            Org.BouncyCastle.Math.BigInteger val_7;
            var val_8;
            var val_9;
            Org.BouncyCastle.Math.BigInteger val_10;
            var val_11;
            Org.BouncyCastle.Math.BigInteger val_12;
            string val_14;
            val_6 = exp;
            val_7 = this;
            if(val_6 <= 0)
            {
                goto label_1;
            }
            
            if(this.sign == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_10;
            }
            
            if((this.sign < 1) || (this.nBits != 1))
            {
                goto label_4;
            }
            
            int val_2 = this.BitLength - 1;
            if(val_6 >= (-2147483648))
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            if(Org.BouncyCastle.Math.BigInteger.One != null)
            {
                    return Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  val_6);
            }
            
            return Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  val_6);
            label_1:
            if((val_6 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            val_6 = 1152921505512914944;
            val_9 = null;
            val_9 = null;
            val_10 = Org.BouncyCastle.Math.BigInteger.One;
            return (Org.BouncyCastle.Math.BigInteger)val_10;
            label_4:
            val_11 = null;
            val_11 = null;
            goto label_15;
            label_19:
            val_12 = this.Multiply(val:  this);
            label_15:
            val_6 = val_6 >> 1;
            if(val_6 != 0)
            {
                goto label_19;
            }
            
            val_10 = Org.BouncyCastle.Math.BigInteger.One.Multiply(val:  val_12);
            return (Org.BouncyCastle.Math.BigInteger)val_10;
            label_9:
            val_14 = "Negative exponent";
            goto label_20;
            label_5:
            val_14 = "Result too large";
            label_20:
            null = new System.ArithmeticException(message:  val_14);
        }
        public static Org.BouncyCastle.Math.BigInteger ProbablePrime(int bitLength, System.Random random)
        {
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(bitLength:  bitLength, certainty:  100, random:  random);
        }
        private int Remainder(int m)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 0;
            goto label_0;
            label_4:
            int val_2 = this.magnitude[0];
            val_3 = 1;
            val_4 = val_2 - ((val_2 / (long)m) * (long)m);
            label_0:
            if(val_3 < this.magnitude.Length)
            {
                goto label_4;
            }
            
            return (int)val_4;
        }
        private static int[] Remainder(int[] x, int[] y)
        {
            var val_15;
            var val_16;
            int val_17;
            var val_18;
            System.Array val_19;
            var val_20;
            int val_21;
            var val_22;
            var val_24;
            var val_25;
            int val_26;
            val_15 = 0;
            goto label_1;
            label_5:
            if(x[0] != 0)
            {
                goto label_3;
            }
            
            val_15 = 1;
            label_1:
            if(val_15 < x.Length)
            {
                goto label_5;
            }
            
            label_3:
            val_16 = 0;
            goto label_6;
            label_10:
            val_17 = 0;
            if(y[0] != 0)
            {
                goto label_8;
            }
            
            val_16 = 1;
            label_6:
            if(val_16 < y.Length)
            {
                goto label_10;
            }
            
            label_8:
            val_18 = val_15;
            int val_1 = Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  1, x:  x, yIndx:  1, y:  y);
            if(val_1 < 1)
            {
                goto label_23;
            }
            
            val_17 = Org.BouncyCastle.Math.BigInteger.CalcBitLength(sign:  1, indx:  1, mag:  y);
            int val_3 = Org.BouncyCastle.Math.BigInteger.CalcBitLength(sign:  1, indx:  1, mag:  x);
            int val_4 = val_3 - val_17;
            if(val_4 >= 1)
            {
                    val_19 = Org.BouncyCastle.Math.BigInteger.ShiftLeft(mag:  y, n:  val_4);
                val_17 = val_3;
            }
            else
            {
                    int[] val_7 = new int[0];
                val_19 = val_7;
                System.Array.Copy(sourceArray:  y, sourceIndex:  1, destinationArray:  val_7, destinationIndex:  0, length:  y.Length - val_16);
            }
            
            val_20 = 0;
            goto label_20;
            label_57:
            val_18 = val_15;
            if((Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  1, x:  x, yIndx:  1, y:  y)) < 1)
            {
                goto label_23;
            }
            
            label_56:
            val_21 = val_17 - val_3;
            if(val_21 != 1)
            {
                goto label_24;
            }
            
            val_22 = null;
            if((val_19[0] >> 1) <= x[4])
            {
                goto label_32;
            }
            
            val_21 = 2;
            goto label_34;
            label_24:
            val_22 = null;
            if(val_21 <= 1)
            {
                goto label_32;
            }
            
            label_34:
            Org.BouncyCastle.Math.BigInteger.ShiftRightInPlace(start:  0, mag:  val_7, n:  val_21);
            val_17 = val_17 - val_21;
            if(val_19 != null)
            {
                goto label_39;
            }
            
            goto label_36;
            label_32:
            Org.BouncyCastle.Math.BigInteger.ShiftRightOneInPlace(start:  0, mag:  val_7);
            val_17 = val_17 - 1;
            label_41:
            if(val_19 != null)
            {
                goto label_39;
            }
            
            label_36:
            label_39:
            if(val_19[0] == 0)
            {
                goto label_41;
            }
            
            val_20 = 0;
            label_20:
            if(val_17 >= val_3)
            {
                    if(((Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  1, x:  x, yIndx:  0, y:  val_7)) & 2147483648) != 0)
            {
                goto label_56;
            }
            
            }
            
            val_24 = null;
            System.Int32[] val_11 = Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  x, yStart:  0, y:  val_7);
            val_25 = 64;
            label_51:
            val_26 = x[4];
            if(val_26 != 0)
            {
                goto label_50;
            }
            
            val_15 = val_15 + 1;
            val_25 = val_25 + 32;
            if(val_15 != x.Length)
            {
                goto label_51;
            }
            
            return (System.Int32[])x;
            label_50:
            if(val_15 >= x.Length)
            {
                    val_26 = mem[x[0x4] + 32];
                val_26 = x[0x4] + 32;
            }
            
            int val_19 = x.Length;
            val_19 = (Org.BouncyCastle.Math.BigInteger.BitLen(w:  val_26)) + (val_19 << 5);
            val_26 = val_19 - val_25;
            if(val_26 > val_17)
            {
                goto label_56;
            }
            
            if(val_26 >= val_17)
            {
                goto label_57;
            }
            
            return (System.Int32[])x;
            label_23:
            if(val_1 != 0)
            {
                    return (System.Int32[])x;
            }
            
            System.Array.Clear(array:  x, index:  1, length:  x.Length - val_15);
            return (System.Int32[])x;
        }
        public Org.BouncyCastle.Math.BigInteger Remainder(Org.BouncyCastle.Math.BigInteger n)
        {
            System.Int32[] val_12;
            Org.BouncyCastle.Math.BigInteger val_13;
            int val_14;
            System.Int32[] val_15;
            var val_16;
            var val_17;
            val_13 = this;
            if(n.sign == 0)
            {
                goto label_2;
            }
            
            if(this.sign == 0)
            {
                goto label_10;
            }
            
            if(n.magnitude.Length != 1)
            {
                goto label_8;
            }
            
            val_12 = n.magnitude;
            int val_12 = val_12[0];
            if(val_12 < 1)
            {
                goto label_8;
            }
            
            if(val_12 == 1)
            {
                goto label_10;
            }
            
            val_12 = this.Remainder(m:  val_12);
            if(val_12 == 0)
            {
                goto label_10;
            }
            
            int[] val_2 = new int[1];
            val_2[0] = val_12;
            val_13 = new Org.BouncyCastle.Math.BigInteger();
            val_14 = this.sign;
            val_15 = val_2;
            val_16 = 0;
            goto label_13;
            label_10:
            val_17 = null;
            val_17 = null;
            val_13 = Org.BouncyCastle.Math.BigInteger.Zero;
            return (Org.BouncyCastle.Math.BigInteger)val_13;
            label_8:
            val_12 = n.magnitude;
            if(((Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  0, x:  this.magnitude, yIndx:  0, y:  val_12)) & 2147483648) != 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_13;
            }
            
            if((n.sign < 1) || (n.nBits != 1))
            {
                goto label_21;
            }
            
            val_12 = this.LastNBits(n:  n.BitLength - 1);
            goto label_22;
            label_21:
            object val_7 = this.magnitude.Clone();
            if(val_7 == null)
            {
                goto label_24;
            }
            
            val_12 = val_7;
            if(val_12 != null)
            {
                goto label_25;
            }
            
            label_24:
            val_12 = 0;
            label_25:
            System.Int32[] val_9 = Org.BouncyCastle.Math.BigInteger.Remainder(x:  val_12, y:  n.magnitude);
            label_22:
            Org.BouncyCastle.Math.BigInteger val_10 = null;
            val_13 = val_10;
            val_16 = 1;
            val_14 = this.sign;
            val_15 = val_12;
            label_13:
            val_10 = new Org.BouncyCastle.Math.BigInteger(signum:  val_14, mag:  val_15, checkMag:  true);
            return (Org.BouncyCastle.Math.BigInteger)val_13;
            label_2:
            System.ArithmeticException val_11 = new System.ArithmeticException(message:  "Division by zero error");
        }
        private int[] LastNBits(int n)
        {
            int val_9;
            System.Array val_10;
            var val_11;
            var val_12;
            if(n > 0)
            {
                    int val_1 = n + 31;
                int val_2 = n + 62;
                val_9 = System.Math.Min(val1:  ((val_1 < 0) ? (val_2) : (val_1)) >> 5, val2:  this.magnitude.Length);
                int[] val_6 = new int[0];
                val_10 = val_6;
                System.Array.Copy(sourceArray:  this.magnitude, sourceIndex:  this.magnitude.Length - val_9, destinationArray:  val_6, destinationIndex:  0, length:  val_9);
                val_11 = (val_9 << 5) - n;
                if(val_11 < 1)
            {
                    return val_10;
            }
            
                int val_9 = val_10[0];
                val_2 = val_11 & 31;
                val_2 = 0 >> val_2;
                val_9 = val_9 & val_2;
                val_10[0] = val_9;
                return val_10;
            }
            
            val_11 = 1152921505512914944;
            val_12 = null;
            val_12 = null;
            val_10 = Org.BouncyCastle.Math.BigInteger.ZeroMagnitude;
            return val_10;
        }
        private Org.BouncyCastle.Math.BigInteger DivideWords(int w)
        {
            Org.BouncyCastle.Math.BigInteger val_3;
            var val_4;
            int val_3 = w;
            val_3 = this.magnitude.Length - val_3;
            if()
            {
                    int[] val_1 = new int[0];
                System.Array.Copy(sourceArray:  this.magnitude, sourceIndex:  0, destinationArray:  val_1, destinationIndex:  0, length:  val_3);
                Org.BouncyCastle.Math.BigInteger val_2 = null;
                val_3 = val_2;
                val_2 = new Org.BouncyCastle.Math.BigInteger(signum:  this.sign, mag:  val_1, checkMag:  false);
                return val_3;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Org.BouncyCastle.Math.BigInteger.Zero;
            return val_3;
        }
        private Org.BouncyCastle.Math.BigInteger RemainderWords(int w)
        {
            if()
            {
                    return (Org.BouncyCastle.Math.BigInteger)this;
            }
            
            int[] val_2 = new int[0];
            System.Array.Copy(sourceArray:  this.magnitude, sourceIndex:  this.magnitude.Length - w, destinationArray:  val_2, destinationIndex:  0, length:  w);
            Org.BouncyCastle.Math.BigInteger val_3 = null;
            this = val_3;
            val_3 = new Org.BouncyCastle.Math.BigInteger(signum:  this.sign, mag:  val_2, checkMag:  false);
            return (Org.BouncyCastle.Math.BigInteger)this;
        }
        private static int[] ShiftLeft(int[] mag, int n)
        {
            var val_12;
            int val_13;
            var val_14;
            System.Array val_15;
            int val_16;
            val_12 = mag;
            val_13 = n & 31;
            val_14 = n >> 5;
            if(val_13 == 0)
            {
                goto label_2;
            }
            
            int val_1 = (-n) & 31;
            int val_2 = val_12[0] >> val_1;
            if(val_2 == 0)
            {
                goto label_4;
            }
            
            int val_4 = (val_14 + mag.Length) + 1;
            val_15 = new int[0];
            val_15[0] = val_2;
            goto label_7;
            label_2:
            n = val_14 + mag.Length;
            int[] val_6 = new int[0];
            val_15 = val_6;
            val_12.CopyTo(array:  val_6, index:  0);
            return (System.Int32[])val_15;
            label_4:
            val_15 = new int[0];
            label_7:
            val_16 = mag.Length - 1;
            if(val_16 >= 1)
            {
                    int val_12 = val_12[0];
                do
            {
                var val_10 = 0 + 0;
                int val_14 = val_1;
                int val_13 = val_13;
                val_13 = val_12 << val_13;
                val_14 = 1152921505725111792 >> val_14;
                val_12 = val_14 | val_13;
                mem2[0] = val_12;
                val_12 = val_12;
            }
            while(val_16 != (0 + 1));
            
                int val_15 = 0 + mag.Length;
                val_13 = val_13;
                val_16 = val_16;
                val_15 = val_15 - 1;
            }
            
            int val_16 = val_12[((long)(int)((mag.Length - 1))) << 2];
            val_16 = val_16 << val_13;
            val_14 = (long)val_15;
            val_15[((long)(int)(((0 + mag.Length) - 1))) << 2] = val_16;
            return (System.Int32[])val_15;
        }
        private static int ShiftLeftOneInPlace(int[] x, int carry)
        {
            int val_5;
            int val_6;
            var val_7;
            var val_8;
            val_5 = carry;
            int val_1 = x.Length - 1;
            if((val_1 & 2147483648) != 0)
            {
                    return (int)val_5;
            }
            
            val_6 = x.Length & 4294967295;
            val_7 = (long)val_1;
            val_8 = x.Length - 2;
            goto label_2;
            label_5:
            val_6 = x.Length;
            val_7 = val_7 - 1;
            val_8 = val_8 - 1;
            label_2:
            if(val_7 >= val_6)
            {
                    val_6 = x.Length;
            }
            
            int val_2 = x[(((long)(int)((x.Length - 1)) - 1)) << 2];
            val_5 = val_5 | (val_2 << 1);
            x[(((long)(int)((x.Length - 1)) - 1)) << 2] = val_5;
            val_5 = val_2 >> 31;
            if((val_8 & 2147483648) == 0)
            {
                goto label_5;
            }
            
            return (int)val_5;
        }
        public Org.BouncyCastle.Math.BigInteger ShiftLeft(int n)
        {
            System.Int32[] val_6;
            int val_7;
            Org.BouncyCastle.Math.BigInteger val_8;
            var val_9;
            val_7 = n;
            val_8 = this;
            if(this.sign != 0)
            {
                    val_6 = this.magnitude;
                if(this.magnitude.Length != 0)
            {
                    if(val_7 == 0)
            {
                    return val_8;
            }
            
                if((val_7 & 2147483648) != 0)
            {
                    return this.ShiftRight(n:  -val_7);
            }
            
                Org.BouncyCastle.Math.BigInteger val_2 = null;
                val_6 = val_2;
                val_2 = new Org.BouncyCastle.Math.BigInteger(signum:  this.sign, mag:  Org.BouncyCastle.Math.BigInteger.ShiftLeft(mag:  this.magnitude, n:  val_7), checkMag:  true);
                if(this.nBits != 1)
            {
                    .nBits = ((this.sign > 0) ? 0 : (val_7)) + this.nBits;
            }
            
                if(this.nBitLength != 1)
            {
                    .nBitLength = this.nBitLength + val_7;
            }
            
                val_8 = val_6;
                return val_8;
            }
            
            }
            
            val_7 = 1152921505512914944;
            val_9 = null;
            val_9 = null;
            val_8 = Org.BouncyCastle.Math.BigInteger.Zero;
            return val_8;
        }
        private static void ShiftRightInPlace(int start, int[] mag, int n)
        {
            var val_10;
            var val_11;
            var val_12;
            int val_13;
            int val_14;
            int val_15;
            int val_11 = n;
            val_10 = mag;
            val_11 = start;
            int val_1 = val_11 >> 5;
            int val_2 = val_11 & 31;
            int val_3 = val_11 + (val_11 >> 5);
            val_12 = mag.Length - 1;
            if(val_1 == 0)
            {
                goto label_7;
            }
            
            if(val_12 < val_3)
            {
                goto label_2;
            }
            
            val_13 = mag.Length;
            var val_10 = val_12;
            goto label_3;
            label_6:
            val_13 = mag.Length;
            label_3:
            if(((-val_1) + val_10) >= val_13)
            {
                    val_13 = mag.Length;
            }
            
            val_10 = val_10 - 1;
            val_10[((long)(int)((mag.Length - 1))) << 2] = val_10[((long)(int)(((n >> 5) + (mag.Length - 1)))) << 2];
            if(val_10 >= val_3)
            {
                goto label_6;
            }
            
            label_2:
            int val_5 = val_3 - 1;
            if(val_5 >= val_11)
            {
                    do
            {
                val_5 = (long)val_5 - 1;
                val_10[((long)(int)(((start + (n) >> 5) - 1))) << 2] = 0;
            }
            while(val_5 >= val_11);
            
            }
            
            label_7:
            if(val_2 == 0)
            {
                    return;
            }
            
            if(val_12 > val_3)
            {
                    val_11 = (-val_11) & 31;
                int val_13 = mag.Length;
                int val_12 = val_10[((long)(int)((mag.Length - 1))) << 2];
                val_13 = val_13 - 2;
                var val_15 = (long)val_13;
                do
            {
                val_14 = mag.Length;
                if(val_15 >= val_14)
            {
                    val_14 = mag.Length;
            }
            
                int val_14 = val_10[((long)(int)((mag.Length - 2))) << 2];
                val_12 = (val_14 << val_11) | (val_12 >> val_2);
                val_11 = (long)val_12 - 1;
                val_10[((long)(int)((mag.Length - 1))) << 2] = val_12;
                val_15 = val_15 - 1;
                val_12 = val_14;
            }
            while(val_11 > val_3);
            
            }
            
            val_15 = mag.Length;
            if(val_3 >= val_15)
            {
                    val_15 = mag.Length;
            }
            
            mem2[0] = (val_10[((long)(int)((start + (n) >> 5))) << 2]) >> val_2;
        }
        private static void ShiftRightOneInPlace(int start, int[] mag)
        {
            var val_2;
            int val_3;
            var val_4;
            if(mag != null)
            {
                    val_2 = mag;
                val_3 = mag.Length;
                val_4 = val_3;
            }
            else
            {
                    val_2 = 24;
                val_4 = 28563616;
                val_3 = 28563616;
            }
            
            long val_5 = 28563615;
            if(val_5 > start)
            {
                    var val_6 = (long)val_4 - 2;
                do
            {
                int val_4 = mag[((long)(int)((val_4 - 2))) << 2];
                val_5 = val_5 - 1;
                mag[114254460] = mag[114254460];
                val_6 = val_6 - 1;
            }
            while(val_5 > start);
            
            }
            
            mem2[0] = (mag[((long)(int)(start)) << 2]) >> 1;
        }
        public Org.BouncyCastle.Math.BigInteger ShiftRight(int n)
        {
            int val_17;
            Org.BouncyCastle.Math.BigInteger val_18;
            System.Int32[] val_19;
            System.Int32[] val_20;
            int val_21;
            var val_22;
            var val_23;
            var val_24;
            val_17 = n;
            val_18 = this;
            if(val_17 == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_18;
            }
            
            if((val_17 & 2147483648) != 0)
            {
                    return this.ShiftLeft(n:  -val_17);
            }
            
            int val_1 = this.BitLength;
            if(val_1 <= val_17)
            {
                goto label_3;
            }
            
            var val_16 = 31;
            val_16 = val_16 - val_17;
            val_16 = val_16 + this.BitLength;
            int[] val_4 = new int[0];
            val_19 = this.magnitude;
            int val_5 = val_17 & 31;
            if(val_5 == 0)
            {
                goto label_4;
            }
            
            int val_6 = (val_16 >> 5) - 1;
            if(val_1 < val_17)
            {
                goto label_16;
            }
            
            int val_7 = val_17 >> 5;
            var val_19 = 0;
            do
            {
                int val_13 = ((this.magnitude.Length - 2) - val_7) + val_19;
                val_20 = (long)val_6 + val_19;
                val_21 = (this.magnitude[(long)((~val_7) + this.magnitude.Length) + val_19]) >> val_5;
                mem2[0] = val_21;
                if((val_13 & 2147483648) == 0)
            {
                    val_20 = this.magnitude;
                int val_18 = val_20[(long)val_13];
                val_18 = val_18 << ((-val_17) & 31);
                val_18 = val_18 | 1152921505725111792;
                mem2[0] = val_18;
            }
            
                val_19 = val_19 - 1;
            }
            while((((long)val_6 + val_19) & 2147483648) == 0);
            
            goto label_16;
            label_3:
            val_22 = null;
            if((this.sign & 2147483648) != 0)
            {
                goto label_17;
            }
            
            val_23 = null;
            val_18 = Org.BouncyCastle.Math.BigInteger.Zero;
            return (Org.BouncyCastle.Math.BigInteger)val_18;
            label_4:
            System.Array.Copy(sourceArray:  val_19, sourceIndex:  0, destinationArray:  val_4, destinationIndex:  0, length:  val_4.Length);
            label_16:
            val_17 = this.sign;
            Org.BouncyCastle.Math.BigInteger val_15 = null;
            val_18 = val_15;
            val_15 = new Org.BouncyCastle.Math.BigInteger(signum:  val_17, mag:  val_4, checkMag:  false);
            return (Org.BouncyCastle.Math.BigInteger)val_18;
            label_17:
            val_24 = null;
            if(Org.BouncyCastle.Math.BigInteger.One != null)
            {
                    return Org.BouncyCastle.Math.BigInteger.One.Negate();
            }
            
            return Org.BouncyCastle.Math.BigInteger.One.Negate();
        }
        public int get_SignValue()
        {
            return (int)this.sign;
        }
        private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
        {
            int val_8 = y.Length;
            int val_9 = 0;
            do
            {
                val_8 = val_8 - 1;
                val_9 = ((x[((long)(int)((x.Length - 1))) << 2]) - 1152921505725111792) + val_9;
                mem2[0] = val_9;
                val_9 = val_9 >> 63;
                y[(val_8 - 1) << 2][32] = (y[(val_8 - 1) << 2][32]) - 4;
            }
            while(val_8 > yStart);
            
            if(val_9 == 0)
            {
                    return (System.Int32[])x;
            }
            
            do
            {
                int val_10 = x[((long)(int)(((long)(int)((x.Length - 1)) - 1))) << 2];
                x[((long)(int)(((long)(int)((x.Length - 1)) - 1))) << 2] = val_10 - 1;
                var val_6 = ((long)((long)x.Length - 1) - 1) - 1;
            }
            while(val_10 == 0);
            
            return (System.Int32[])x;
        }
        public Org.BouncyCastle.Math.BigInteger Subtract(Org.BouncyCastle.Math.BigInteger n)
        {
            var val_8;
            Org.BouncyCastle.Math.BigInteger val_9;
            var val_10;
            val_9 = this;
            if(n.sign == 0)
            {
                    return val_9;
            }
            
            if(this.sign == 0)
            {
                    return n.Negate();
            }
            
            if(this.sign != n.sign)
            {
                    return this.Add(value:  n.Negate());
            }
            
            val_8 = Org.BouncyCastle.Math.BigInteger.CompareNoLeadingZeroes(xIndx:  0, x:  this.magnitude, yIndx:  0, y:  n.magnitude);
            if(val_8 != 0)
            {
                    var val_2 = (val_8 >= 0) ? (val_9) : n;
                var val_3 = (val_8 >= 0) ? n : (val_9);
                Org.BouncyCastle.Math.BigInteger val_6 = null;
                val_9 = val_6;
                val_6 = new Org.BouncyCastle.Math.BigInteger(signum:  this.sign * val_8, mag:  Org.BouncyCastle.Math.BigInteger.doSubBigLil(bigMag:  val_8 >= 0 ? this : n + 16, lilMag:  val_8 >= 0 ? n : this + 16), checkMag:  true);
                return val_9;
            }
            
            val_10 = null;
            val_10 = null;
            val_9 = Org.BouncyCastle.Math.BigInteger.Zero;
            return val_9;
        }
        private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
        {
            var val_4;
            System.Int32[] val_5;
            var val_6;
            object val_1 = bigMag.Clone();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_4 = null;
            val_5 = val_1;
            if(val_5 != null)
            {
                goto label_3;
            }
            
            label_2:
            val_5 = 0;
            label_3:
            val_6 = null;
            return (System.Int32[])Org.BouncyCastle.Math.BigInteger.Subtract(xStart:  Org.BouncyCastle.Math.BigInteger>>0&0xFFFFFFFF, x:  val_5, yStart:  0, y:  lilMag);
        }
        public byte[] ToByteArray()
        {
            return this.ToByteArray(unsigned:  false);
        }
        public byte[] ToByteArrayUnsigned()
        {
            return this.ToByteArray(unsigned:  true);
        }
        private byte[] ToByteArray(bool unsigned)
        {
            System.Byte[] val_34;
            int val_35;
            System.Int32[] val_36;
            var val_37;
            System.Int32[] val_38;
            byte val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            System.Int32[] val_45;
            var val_46;
            if(this.sign == 0)
            {
                goto label_1;
            }
            
            var val_4 = ((((this.sign > 0) ? 1 : 0) & unsigned) == false) ? (7 + 1) : 7;
            val_4 = val_4 + this.BitLength;
            val_4 = (val_4 < 0) ? (val_4 + 7) : (val_4);
            unsigned = val_4 >> 3;
            val_34 = new byte[0];
            int val_33 = this.magnitude.Length;
            val_35 = val_6.Length;
            val_36 = this.magnitude;
            if(this.sign < 1)
            {
                goto label_6;
            }
            
            if(val_33 >= 2)
            {
                    int val_7 = val_33 << 2;
                var val_37 = 0;
                val_33 = val_7 + 28;
                do
            {
                int val_34 = val_35 - 1;
                val_34 = val_34 + val_37;
                val_34[(long)val_34] = null;
                int val_35 = val_35 - 2;
                val_35 = val_35 + val_37;
                val_34[(long)val_35] = 0;
                int val_36 = val_35 - 3;
                val_36 = val_36 + val_37;
                val_34[(long)val_36] = 0;
                val_37 = (long)(val_35 - 4) + val_37;
                val_34[val_37] = 0;
                val_38 = this.magnitude;
                val_39 = ((long)val_33 + 1) - 1;
                val_37 = val_37 - 4;
                val_40 = (val_33 - 1) - 1;
            }
            while(val_39 > 2);
            
                val_41 = (val_35 + 4) - val_7;
            }
            
            int val_38 = val_38[0];
            do
            {
                val_42 = (long)val_41 - 1;
                val_34[val_42] = val_38;
                val_38 = val_38 >> 8;
                var val_17 = val_42 - 1;
            }
            while(val_38 >= 256);
            
            return (System.Byte[])val_34;
            label_1:
            if(unsigned == false)
            {
                goto label_20;
            }
            
            val_43 = null;
            val_43 = null;
            val_34 = Org.BouncyCastle.Math.BigInteger.ZeroEncoding;
            return (System.Byte[])val_34;
            label_6:
            int val_18 = val_33 - 1;
            if(this.sign > 1)
            {
                goto label_24;
            }
            
            val_44 = 0;
            if(val_36 != null)
            {
                goto label_35;
            }
            
            goto label_26;
            label_20:
            val_34 = new byte[1];
            return (System.Byte[])val_34;
            label_24:
            int val_21 = val_33 << 2;
            var val_42 = 1;
            do
            {
                int val_39 = val_35 - 1;
                val_39 = val_39 + 0;
                byte val_28 = (val_42 != 1) ? -1152921505878809472 : (!null);
                val_34[(long)val_39] = val_28;
                int val_40 = val_35 - 2;
                val_40 = val_40 + 0;
                val_34[(long)val_40] = val_28 >> 8;
                int val_41 = val_35 - 3;
                val_41 = val_41 + 0;
                val_34[(long)val_41] = val_28 >> 16;
                int val_43 = val_35 - 4;
                val_42 = val_42 & ((null == null) ? 1 : 0);
                val_43 = val_43 + 0;
                val_34[(long)val_43] = val_28 >> 24;
                val_37 = ((long)val_33 + 1) - 1;
                val_40 = 0 - 4;
                val_45 = this.magnitude;
                val_18 = val_18 - 1;
            }
            while(val_37 > 2);
            
            int val_45 = val_21;
            val_44 = (int)(val_42 >> 0) & 1;
            val_46 = (val_35 + 4) - val_45;
            if(val_45 != null)
            {
                goto label_35;
            }
            
            label_26:
            label_35:
            val_44 = val_45[0] + val_44;
            do
            {
                val_42 = val_46 - 1;
                val_39 = val_44 ^ 255;
                val_44 = val_44 >> 8;
                val_34[(long)val_42] = val_39;
            }
            while(val_44 > 255);
            
            if((long)val_42 < 1)
            {
                    return (System.Byte[])val_34;
            }
            
            val_45 = (long)val_42 - 1;
            val_34[(long)val_45] = 255;
            return (System.Byte[])val_34;
        }
        public override string ToString()
        {
            return this.ToString(radix:  10);
        }
        public string ToString(int radix)
        {
            System.Int32[] val_42;
            var val_43;
            System.Int32[] val_44;
            int val_45;
            System.Int32[] val_46;
            System.Int32[] val_47;
            var val_48;
            var val_49;
            string val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_56;
            Org.BouncyCastle.Math.BigInteger val_58;
            var val_59;
            var val_61;
            string val_63;
            var val_64;
            var val_67;
            val_42 = radix;
            val_43 = this;
            if(val_42 <= 8)
            {
                goto label_1;
            }
            
            if((val_42 == 10) || (val_42 == 16))
            {
                goto label_5;
            }
            
            goto label_6;
            label_1:
            if(val_42 != 2)
            {
                    if(val_42 != 8)
            {
                goto label_6;
            }
            
            }
            
            label_5:
            val_44 = this.magnitude;
            if(val_44 == null)
            {
                goto label_7;
            }
            
            if(this.sign == 0)
            {
                goto label_8;
            }
            
            val_45 = 0;
            goto label_9;
            label_14:
            if(this.magnitude[0] != 0)
            {
                goto label_12;
            }
            
            val_46 = this.magnitude;
            val_45 = 1;
            label_9:
            if(val_45 < this.magnitude.Length)
            {
                goto label_14;
            }
            
            label_12:
            val_47 = this.magnitude;
            if(this.magnitude.Length != val_45)
            {
                goto label_16;
            }
            
            label_8:
            val_48 = "0";
            return (string)val_48;
            label_7:
            val_48 = "null";
            return (string)val_48;
            label_16:
            val_49 = val_45 + 1;
            System.Text.StringBuilder val_1 = null;
            val_50 = 0;
            val_47 = val_1;
            val_1 = new System.Text.StringBuilder();
            if(this.sign == 1)
            {
                    val_50 = 45;
                System.Text.StringBuilder val_2 = val_1.Append(value:  '-');
            }
            
            if(val_42 <= 8)
            {
                goto label_21;
            }
            
            if(val_42 == 10)
            {
                goto label_22;
            }
            
            if(val_42 != 16)
            {
                goto label_133;
            }
            
            val_45 = 1152921504618561536;
            val_50 = System.Convert.ToString(value:  this.magnitude[1], toBase:  16);
            System.Text.StringBuilder val_4 = val_1.Append(value:  val_50);
            goto label_29;
            label_37:
            val_51 = (long)val_49;
            val_50 = System.Convert.ToString(value:  this.magnitude[val_51], toBase:  16);
            Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb:  val_1, s:  val_50, minLength:  8);
            val_52 = val_49 + 1;
            label_29:
            val_42 = this.magnitude;
            if(val_52 < this.magnitude.Length)
            {
                goto label_37;
            }
            
            goto label_133;
            label_21:
            if(val_42 == 2)
            {
                goto label_39;
            }
            
            if(val_42 != 8)
            {
                goto label_133;
            }
            
            if((this.sign & 2147483648) != 0)
            {
                    val_53 = this.Negate();
            }
            
            var val_52 = val_53.BitLength;
            val_51 = 1152921504618561536;
            val_42 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            val_52 = val_52 - 30;
            val_45 = IntValue;
            val_56 = 0;
            System.Text.StringBuilder val_15 = val_1.Append(value:  System.Convert.ToString(value:  val_45, toBase:  8));
            var val_53 = 0;
            val_53 = val_53 + 1;
            val_56 = 1;
            goto label_63;
            label_22:
            if((this.sign & 2147483648) != 0)
            {
                    val_58 = this.Negate();
                if(val_58 == null)
            {
                goto label_145;
            }
            
            }
            
            val_42 = 0;
            label_145:
            if(val_58.BitLength < 64)
            {
                goto label_66;
            }
            
            do
            {
                val_42 = 1 + 1;
            }
            while(0 < (-858993459));
            
            val_51 = 1152921505512914944;
            val_45 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  0);
            System.Collections.IList val_19 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            goto label_72;
            label_86:
            if(((this.CompareTo(value:  val_45)) & 2147483648) != 0)
            {
                goto label_73;
            }
            
            label_87:
            Org.BouncyCastle.Math.BigInteger[] val_21 = val_58.DivideAndRemainder(val:  val_45);
            val_59 = 0;
            var val_55 = 0;
            val_55 = val_55 + 1;
            val_59 = 2;
            int val_25 = val_19.Add(value:  System.Convert.ToString(value:  val_21[1].LongValue, toBase:  10));
            val_58 = val_21[0];
            label_72:
            if(val_58 == null)
            {
                goto label_86;
            }
            
            if(((val_58.CompareTo(value:  val_45)) & 2147483648) == 0)
            {
                goto label_87;
            }
            
            goto label_88;
            label_39:
            val_45 = 1152921504618561536;
            val_50 = System.Convert.ToString(value:  this.magnitude[1], toBase:  2);
            System.Text.StringBuilder val_28 = val_1.Append(value:  val_50);
            goto label_94;
            label_102:
            val_51 = (long)val_49;
            val_50 = System.Convert.ToString(value:  this.magnitude[val_51], toBase:  2);
            Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb:  val_1, s:  val_50, minLength:  32);
            val_61 = val_49 + 1;
            label_94:
            val_42 = this.magnitude;
            if(val_61 < this.magnitude.Length)
            {
                goto label_102;
            }
            
            goto label_133;
            label_66:
            val_50 = System.Convert.ToString(value:  val_58.LongValue, toBase:  10);
            System.Text.StringBuilder val_32 = val_1.Append(value:  val_50);
            if(val_47 != null)
            {
                goto label_144;
            }
            
            goto label_109;
            label_63:
            val_50 = public System.Int32 System.Collections.ICollection::get_Count();
            int val_35 = val_42.Count - 1;
            if((val_35 & 2147483648) != 0)
            {
                goto label_133;
            }
            
            val_45 = 1152921505512914944;
            val_51 = 1152921504624312320;
            do
            {
                var val_58 = 0;
                val_58 = val_58 + 1;
                val_56 = 0;
                val_63 = val_42.Item[val_35];
                if(val_63 != null)
            {
                    if(null != null)
            {
                    val_63 = 0;
            }
            
            }
            
                val_50 = val_63;
                Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb:  val_1, s:  val_50, minLength:  10);
                val_35 = val_35 - 1;
            }
            while((val_35 & 2147483648) == 0);
            
            goto label_133;
            label_73:
            val_58 = 0;
            label_88:
            val_64 = 0;
            System.Text.StringBuilder val_41 = val_1.Append(value:  System.Convert.ToString(value:  this.LongValue, toBase:  10));
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_64 = 1;
            val_50 = public System.Int32 System.Collections.ICollection::get_Count();
            int val_44 = val_19.Count - 1;
            if((val_44 & 2147483648) == 0)
            {
                    do
            {
                var val_60 = 0;
                val_60 = val_60 + 1;
                val_64 = 0;
                val_45 = val_19.Item[val_44];
                if((val_45 != null) && (null != null))
            {
                    val_45 = 0;
            }
            
                val_50 = val_45;
                Org.BouncyCastle.Math.BigInteger.AppendZeroExtendedString(sb:  val_1, s:  val_50, minLength:  val_42);
                val_44 = val_44 - 1;
            }
            while((val_44 & 2147483648) == 0);
            
            }
            
            label_133:
            if(val_47 != null)
            {
                goto label_144;
            }
            
            label_109:
            label_144:
            val_48 = val_47;
            return (string)val_48;
            label_6:
            val_67 = new System.FormatException(message:  "Only bases 2, 8, 10, 16 are allowed");
        }
        private static void AppendZeroExtendedString(System.Text.StringBuilder sb, string s, int minLength)
        {
            var val_4 = s.Length;
            goto label_1;
            label_3:
            System.Text.StringBuilder val_2 = sb.Append(value:  '0');
            val_4 = val_4 + 1;
            label_1:
            if(val_4 < minLength)
            {
                goto label_3;
            }
            
            System.Text.StringBuilder val_3 = sb.Append(value:  s);
        }
        private static Org.BouncyCastle.Math.BigInteger CreateUValueOf(ulong value)
        {
            int val_6;
            var val_7;
            ulong val_1 = value >> 32;
            if(val_1 != 0)
            {
                    int[] val_2 = new int[2];
                val_6 = val_2.Length;
                if(val_6 == 0)
            {
                    val_6 = val_2.Length;
            }
            
                val_2[0] = val_1;
                val_2[0] = value;
                return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_2, checkMag:  false);
            }
            
            if(value != 0)
            {
                    int[] val_4 = new int[1];
                val_4[0] = value;
                Org.BouncyCastle.Math.BigInteger val_5 = new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_4, checkMag:  false);
                var val_6 = -value;
                val_6 = value & (~val_6);
                if(val_6 != 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_2, checkMag:  false);
            }
            
                .nBits = 1;
                return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_2, checkMag:  false);
            }
            
            val_7 = null;
            val_7 = null;
            return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_2, checkMag:  false);
        }
        private static Org.BouncyCastle.Math.BigInteger CreateValueOf(long value)
        {
            if((value & 9223372036854775808) == 0)
            {
                    return Org.BouncyCastle.Math.BigInteger.CreateUValueOf(value:  value);
            }
            
            if(value == (-9223372036854775808))
            {
                    if(9223372036854775807 != 0)
            {
                    return this.Not();
            }
            
                return this.Not();
            }
            
            if((-value) != 0)
            {
                    return -value.Negate();
            }
            
            return -value.Negate();
        }
        public static Org.BouncyCastle.Math.BigInteger ValueOf(long value)
        {
            var val_2;
            var val_3;
            if((value & 9223372036854775808) != 0)
            {
                    return Org.BouncyCastle.Math.BigInteger.CreateValueOf(value:  value);
            }
            
            val_2 = null;
            val_2 = null;
            if(Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS.Length <= value)
            {
                    return Org.BouncyCastle.Math.BigInteger.CreateValueOf(value:  value);
            }
            
            val_3 = null;
            val_3 = null;
            Org.BouncyCastle.Math.BigInteger[] val_1 = Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS + ((value) << 3);
            return (Org.BouncyCastle.Math.BigInteger)(Org.BouncyCastle.Math.BigInteger.SMALL_CONSTANTS + (value) << 3) + 32;
        }
        public int GetLowestSetBit()
        {
            if(this.sign == 0)
            {
                    return 0;
            }
            
            return this.GetLowestSetBitMaskFirst(firstWordMask:  0);
        }
        private int GetLowestSetBitMaskFirst(int firstWordMask)
        {
            System.Int32[] val_5;
            int val_6;
            var val_7;
            var val_8;
            val_5 = this.magnitude;
            if(this.magnitude != null)
            {
                goto label_0;
            }
            
            val_5 = this.magnitude;
            if(val_5 == null)
            {
                goto label_1;
            }
            
            label_0:
            val_6 = (val_5[(long)this.magnitude.Length - 1]) & firstWordMask;
            if(val_6 != 0)
            {
                    val_7 = 0;
            }
            else
            {
                    int val_2 = this.magnitude.Length - 2;
                do
            {
                val_6 = this.magnitude[(long)val_2];
                val_7 = 0 + 32;
                val_5 = val_2 - 1;
            }
            while(val_6 == 0);
            
            }
            
            if((val_6 & 255) == 0)
            {
                goto label_11;
            }
            
            val_8 = val_6;
            if((val_8 & 1) == 0)
            {
                goto label_13;
            }
            
            return (int)val_7;
            label_1:
        }
        public bool TestBit(int n)
        {
            var val_6;
            var val_7;
            if((n & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if((this.sign & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_6 = n >> 5;
            if(val_6 >= this.magnitude.Length)
            {
                goto label_4;
            }
            
            int val_5 = this.magnitude.Length;
            val_5 = (~val_6) + val_5;
            val_6 = (long)val_5;
            int val_1 = n & 31;
            val_1 = 1 << val_1;
            var val_2 = (this.magnitude[val_6] != val_1) ? 1 : 0;
            return (bool)val_7;
            label_2:
            val_7 = (~this.Not()) & 1;
            return (bool)val_7;
            label_4:
            val_7 = 0;
            return (bool)val_7;
            label_1:
            System.ArithmeticException val_4 = new System.ArithmeticException(message:  "Bit position must not be negative");
        }
        public Org.BouncyCastle.Math.BigInteger Or(Org.BouncyCastle.Math.BigInteger value)
        {
            var val_12;
            Org.BouncyCastle.Math.BigInteger val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            int val_21;
            var val_22;
            var val_23;
            var val_24;
            int val_25;
            int val_26;
            var val_27;
            var val_28;
            val_13 = value;
            if(mem[1152921543963669096] == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_13;
            }
            
            val_14 = value.sign;
            if(val_14 == 0)
            {
                goto label_3;
            }
            
            val_15 = this;
            if(mem[1152921543963669096] <= 0)
            {
                    val_12 = 1152921505512914944;
                val_16 = null;
                val_16 = null;
                if((this.Add(value:  Org.BouncyCastle.Math.BigInteger.One)) == null)
            {
                    val_15 = 0;
            }
            
                val_14 = value.sign;
            }
            
            val_17 = val_13;
            if(val_14 > 0)
            {
                goto label_8;
            }
            
            val_12 = 1152921505512914944;
            val_18 = null;
            val_18 = null;
            if((val_13.Add(value:  Org.BouncyCastle.Math.BigInteger.One)) == null)
            {
                goto label_11;
            }
            
            label_8:
            if((mem[1152921543963669096] & 2147483648) != 0)
            {
                goto label_12;
            }
            
            val_19 = value.sign >> 31;
            goto label_13;
            label_3:
            val_13 = this;
            return (Org.BouncyCastle.Math.BigInteger)val_13;
            label_12:
            val_19 = 1;
            label_13:
            if(11993091 == 0)
            {
                goto label_15;
            }
            
            label_22:
            int val_3 = System.Math.Max(val1:  mem[4306960411], val2:  val_2.magnitude.Length);
            int[] val_4 = new int[0];
            if(val_4 == null)
            {
                goto label_19;
            }
            
            val_20 = val_4;
            val_21 = val_4.Length;
            val_22 = val_21 - mem[4306960411];
            goto label_20;
            label_15:
            if(val_2.magnitude != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_19:
            val_20 = 24;
            val_22 = 28563616 - mem[4306960411];
            val_21 = 28563616;
            label_20:
            val_23 = 0;
            val_21 = val_2.magnitude.Length - val_21;
            goto label_23;
            label_38:
            if(val_23 < val_22)
            {
                    val_24 = 0;
            }
            else
            {
                    var val_10 = -val_22;
                val_10 = val_10 + val_23;
                var val_6 = 11993091 + (((long)(int)(((28563616 - mem[4306960411]) + val_23))) << 2);
                val_24 = mem[(11993091 + ((long)(int)(((28563616 - mem[4306960411]) + val_23))) << 2) + 32];
                val_24 = (11993091 + ((long)(int)(((28563616 - mem[4306960411]) + val_23))) << 2) + 32;
            }
            
            if(val_23 < (val_21 - val_2.magnitude.Length))
            {
                    val_25 = 0;
            }
            else
            {
                    int val_11 = val_21;
                val_11 = val_11 + val_23;
                val_25 = val_2.magnitude[(long)val_11];
            }
            
            val_26 = (val_25 ^ (value.sign >> 31)) | (val_24 ^ (mem[1152921543963669096] >> 31));
            val_4[0] = val_26;
            if(val_19 != 0)
            {
                    val_27 = 28563616;
                if(val_23 >= val_27)
            {
                    val_28 = mem[val_4[0x0] + 32];
                val_28 = val_4[0x0] + 32;
                val_27 = 28563616;
            }
            
                val_12 = val_28;
                val_12 = ~val_28;
                mem2[0] = val_12;
            }
            
            val_23 = 1;
            label_23:
            if(val_23 < val_20)
            {
                goto label_38;
            }
            
            Org.BouncyCastle.Math.BigInteger val_9 = null;
            val_13 = val_9;
            val_9 = new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_4, checkMag:  true);
            if(val_19 == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_13;
            }
            
            if(val_13 != null)
            {
                    return val_9.Not();
            }
            
            return val_9.Not();
            label_11:
        }
        public Org.BouncyCastle.Math.BigInteger Xor(Org.BouncyCastle.Math.BigInteger value)
        {
            var val_14;
            Org.BouncyCastle.Math.BigInteger val_15;
            int val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            int val_22;
            var val_23;
            var val_24;
            var val_25;
            int val_26;
            int val_27;
            var val_28;
            var val_29;
            val_15 = value;
            if(mem[1152921543963895784] == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_15;
            }
            
            val_16 = value.sign;
            if(val_16 == 0)
            {
                goto label_3;
            }
            
            val_17 = this;
            if(mem[1152921543963895784] <= 0)
            {
                    val_14 = 1152921505512914944;
                val_18 = null;
                val_18 = null;
                if((this.Add(value:  Org.BouncyCastle.Math.BigInteger.One)) == null)
            {
                    val_17 = 0;
            }
            
                val_16 = value.sign;
            }
            
            val_19 = val_15;
            if(val_16 > 0)
            {
                goto label_8;
            }
            
            val_14 = 1152921505512914944;
            val_20 = null;
            val_20 = null;
            if((val_15.Add(value:  Org.BouncyCastle.Math.BigInteger.One)) == null)
            {
                goto label_11;
            }
            
            label_8:
            if(11993091 == 0)
            {
                goto label_12;
            }
            
            label_20:
            int val_3 = System.Math.Max(val1:  mem[4306960411], val2:  val_2.magnitude.Length);
            int[] val_4 = new int[0];
            if(val_4 == null)
            {
                goto label_16;
            }
            
            val_21 = val_4;
            val_22 = val_4.Length;
            val_23 = val_22 - mem[4306960411];
            goto label_17;
            label_3:
            val_15 = this;
            return (Org.BouncyCastle.Math.BigInteger)val_15;
            label_12:
            if(val_2.magnitude != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_16:
            val_21 = 24;
            val_23 = 28563616 - mem[4306960411];
            val_22 = 28563616;
            label_17:
            int val_5 = value.sign ^ mem[1152921543963895784];
            val_24 = 0;
            val_22 = val_2.magnitude.Length - val_22;
            goto label_21;
            label_36:
            if(val_24 < val_23)
            {
                    val_25 = 0;
            }
            else
            {
                    var val_12 = -val_23;
                val_12 = val_12 + val_24;
                var val_7 = 11993091 + (((long)(int)(((28563616 - mem[4306960411]) + val_24))) << 2);
                val_25 = mem[(11993091 + ((long)(int)(((28563616 - mem[4306960411]) + val_24))) << 2) + 32];
                val_25 = (11993091 + ((long)(int)(((28563616 - mem[4306960411]) + val_24))) << 2) + 32;
            }
            
            if(val_24 < (val_22 - val_2.magnitude.Length))
            {
                    val_26 = 0;
            }
            else
            {
                    int val_13 = val_22;
                val_13 = val_13 + val_24;
                val_26 = val_2.magnitude[(long)val_13];
            }
            
            int val_10 = val_26 ^ val_25;
            val_10 = val_10 ^ (mem[1152921543963895784] >> 31);
            val_27 = val_10 ^ (value.sign >> 31);
            val_4[0] = val_27;
            val_23 = val_23;
            if((val_5 & 2147483648) != 0)
            {
                    val_28 = 28563616;
                if(val_24 >= val_28)
            {
                    val_29 = mem[val_4[0x0] + 32];
                val_29 = val_4[0x0] + 32;
                val_28 = 28563616;
            }
            
                val_14 = val_29;
                val_14 = ~val_29;
                mem2[0] = val_14;
            }
            
            val_24 = 1;
            label_21:
            if(val_24 < val_21)
            {
                goto label_36;
            }
            
            Org.BouncyCastle.Math.BigInteger val_11 = null;
            val_15 = val_11;
            val_11 = new Org.BouncyCastle.Math.BigInteger(signum:  1, mag:  val_4, checkMag:  true);
            if((val_5 & 2147483648) == 0)
            {
                    return (Org.BouncyCastle.Math.BigInteger)val_15;
            }
            
            if(val_15 != null)
            {
                    return val_11.Not();
            }
            
            return val_11.Not();
            label_11:
        }
        public Org.BouncyCastle.Math.BigInteger SetBit(int n)
        {
            var val_6;
            if((n & 2147483648) == 0)
            {
                    if((this.TestBit(n:  n)) != false)
            {
                    return (Org.BouncyCastle.Math.BigInteger)this;
            }
            
                if(this.sign >= 1)
            {
                    if((this.BitLength - 1) > n)
            {
                    return this.FlipExistingBit(n:  n);
            }
            
            }
            
                val_6 = null;
                val_6 = null;
                return this.Or(value:  Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  n));
            }
            
            System.ArithmeticException val_5 = new System.ArithmeticException(message:  "Bit address less than zero");
        }
        public Org.BouncyCastle.Math.BigInteger ClearBit(int n)
        {
            var val_6;
            if((n & 2147483648) == 0)
            {
                    if((this.TestBit(n:  n)) == false)
            {
                    return (Org.BouncyCastle.Math.BigInteger)this;
            }
            
                if(this.sign >= 1)
            {
                    if((this.BitLength - 1) > n)
            {
                    return this.FlipExistingBit(n:  n);
            }
            
            }
            
                val_6 = null;
                val_6 = null;
                return this.AndNot(val:  Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  n));
            }
            
            System.ArithmeticException val_5 = new System.ArithmeticException(message:  "Bit address less than zero");
        }
        public Org.BouncyCastle.Math.BigInteger FlipBit(int n)
        {
            var val_5;
            if((n & 2147483648) == 0)
            {
                    if(this.sign >= 1)
            {
                    if((this.BitLength - 1) > n)
            {
                    return this.FlipExistingBit(n:  n);
            }
            
            }
            
                val_5 = null;
                val_5 = null;
                return this.Xor(value:  Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(n:  n));
            }
            
            System.ArithmeticException val_4 = new System.ArithmeticException(message:  "Bit address less than zero");
        }
        private Org.BouncyCastle.Math.BigInteger FlipExistingBit(int n)
        {
            object val_1 = this.magnitude.Clone();
            if(val_1 != null)
            {
                    var val_7 = 1152921505725111792;
                if(val_1 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 ^ (n >> 5);
                val_7 = val_6 + val_7;
                object val_2 = val_1 + (((long)(int)(((0 ^ ((int)n) >> 5) + 1152921505725111792))) << 2);
                int val_3 = n & 31;
                val_3 = 1 << val_3;
                val_3 = W10 ^ val_3;
                mem2[0] = val_3;
                return (Org.BouncyCastle.Math.BigInteger)new Org.BouncyCastle.Math.BigInteger(signum:  this.sign, mag:  val_1, checkMag:  false);
            }
            
                0 = 0;
            }
        
        }
    
    }

}
